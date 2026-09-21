# atp.ApiAutomation.Sharding

A standalone proof-of-concept: **does splitting a test suite across multiple
parallel pods (sharding + horizontal pod scaling) meaningfully reduce
wall-clock time, compared to running it on a single runner?**

This is a companion to [atp.ApiAutomation.Portfolio](https://github.com/aTapHub/atp.ApiAutomation.Portfolio),
which runs its real API tests on a self-hosted Kubernetes cluster (Talos,
via [actions-runner-controller](https://github.com/actions/actions-runner-controller)).
That project answers "how do we run tests on our own cluster." This one
answers a different question: "once tests run there, how do we make a large
suite finish faster by using more of the cluster at once."

## What's being proven

Sharding only pays off if the work is actually split evenly. A test suite in
the real world isn't uniform - some tests are fast, some are slow - so a
naive split (e.g. "first half of the classes go to shard 1") can easily leave
one shard doing most of the work while others sit idle. Two things need to
be true for the proof to mean anything:

1. **The test suite must have realistic, uneven timing** - not identical
   tests, not clustered by class.
2. **The sharding algorithm must account for that unevenness** - balance
   shards by expected duration, not by test count.

## The mock test suite

500 tests across 50 fixture classes (10 each), architected the same way as
the real framework's tests - not a flat pile of `Thread.Sleep` calls:

- A `SetupFixture` ([SetUpFixture]) builds a DI container once in
  `OneTimeSetUp`, same shape as `atp.ApiAutomation.Framework`'s.
- Each test resolves `ISleepService` via DI and calls `Sleep(ms)` - the DI
  path is genuinely exercised, not decorative.
- `[Parallelizable(ParallelScope.All)]` + `[assembly: LevelOfParallelism(75)]`
  - fixtures and tests within them both run concurrently, deliberately raised
  well above the rate limiter's capacity (below) so the limiter actually has
  contention to throttle, rather than sitting idle under a cap concurrency
  could never reach.
- The same `ExtentReports` HTML reporting setup.

### Rate limiter: simulating a real AUT's throughput cap

A mock suite that starts every test instantly whenever a slot is free isn't
realistic - a real AUT would rate-limit you. `SleepService` is gated by a
cluster-wide Redis-backed **token bucket** (capacity 25, refill 10/sec,
[Services/RedisRateLimiterService.cs](Services/RedisRateLimiterService.cs)),
layered behind a local `SemaphoreSlim` (per-pod concurrency cap, checked
first since it's free, before paying for a Redis round trip). Both numbers
stay **fixed regardless of shard count** - a real AUT's quota doesn't grow
just because more pods are hitting it, and this is what makes the plateau in
the results below happen at all.

Each test's sleep duration is **fixed at generation time** - the same every
run, never randomized at runtime. What's randomized is which duration lands
in which class, so no class is a homogeneous "all fast" or "all slow"
bucket - see `Generate-ShardingTests.ps1` (deterministic given its seed;
regenerating produces byte-identical output).

Duration distribution across the 500 tests:

| Bucket | Range | % | Count |
| --- | --- | --- | --- |
| Fast | <5s | 50% | 250 |
| Medium | 5-10s | 30% | 150 |
| Slow | 15s | 10% | 50 |
| Slower | 20s | 5% | 25 |
| Slowest | 30s | 5% | 25 |

`test-durations.json` is the manifest mapping every test's full name to its
duration - the source of truth a future sharding tool reads from to compute
a balanced partition, rather than guessing from test names or class count.

## Results

All four runs below went through this repo's own CI pipeline
([.github/workflows/sharding-pipeline.yml](.github/workflows/sharding-pipeline.yml),
`workflow_dispatch` with `mode`/`shard_count` inputs), on the real Talos
cluster, wall-clock timed from Kubernetes Job start to completion:

| Mode | Wall-clock | Result |
| --- | --- | --- |
| Single runner (N=1) | 182s | 500/500 passed |
| Sharded, N=4 | 90s | 500/500 passed (125 per shard) |
| Sharded, N=8 | 93s | 500/500 passed (62-63 per shard) |
| Sharded, N=12 | 90s | 500/500 passed (41-42 per shard) |

**Sharding helps, then plateaus.** 1→4 shards roughly halves the wall-clock
time (182s → 90s). But 4→8→12 shards buys essentially nothing further - all
three sit at ~90s, within run-to-run noise. This is the rate limiter doing
exactly what it's supposed to: past N=4, the bottleneck isn't "how many pods
can run concurrently" anymore, it's the shared token bucket that every shard
draws from regardless of pod count. More shards just means more pods queuing
on the same fixed-size limiter, not more throughput - the same shape you'd
see hitting a real rate-limited API with an ever-larger test farm.

Partition correctness was verified directly, not assumed: every sharded
run's actual executed-test list was diffed against
[Tools/ShardPlanner](Tools/ShardPlanner)'s locally-computed reference
partition for the same shard count and index, confirming zero overlap and
zero gaps across all 500 tests in every run.

## Status

- [x] Mock test suite generated and verified (compiles, runs, DI resolves,
      report generates correctly).
- [x] Rate limiter: cluster-wide Redis token bucket + local concurrency
      semaphore, simulating a rate-limited AUT.
- [x] Baseline: single-runner wall-clock time recorded (182s, see Results).
- [x] Sharding algorithm: `Tools/ShardPlanner` partitions the 500 tests
      across N shards by known duration (greedy bin-packing), verified
      balanced (<0.5% spread) for N=2,4,8,16.
- [x] Horizontal pod scaling wrapper: a Kubernetes Indexed Job
      (`completionMode: Indexed`, `parallelism`/`completions: N`,
      `k8s/test-job-sharded.yaml`), each pod reading `JOB_COMPLETION_INDEX`
      to compute and run its own shard.
- [x] Comparison: single-runner time vs. sharded time across N=4,8,12 (see
      Results) - run via this repo's own CI pipeline, independent of
      `atp.ApiAutomation.Portfolio`.

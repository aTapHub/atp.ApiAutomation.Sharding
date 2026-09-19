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
- `[Parallelizable(ParallelScope.Fixtures)]` + `[assembly:
  LevelOfParallelism(4)]` - fixtures run in parallel, tests within a fixture
  run sequentially. Same concurrency model the real suite already uses.
- The same `ExtentReports` HTML reporting setup.

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

## Status

- [x] Mock test suite generated and verified (compiles, runs, DI resolves,
      report generates correctly).
- [ ] Baseline: run all 500 on a single runner, record wall-clock time.
- [ ] Sharding algorithm: partition the 500 tests across N shards by known
      duration (greedy bin-packing), not by count.
- [ ] Horizontal pod scaling wrapper: a Kubernetes Indexed Job
      (`completionMode: Indexed`, `parallelism: N`), each pod running its
      own shard.
- [ ] Comparison: single-runner time vs. sharded time across a few values
      of N.

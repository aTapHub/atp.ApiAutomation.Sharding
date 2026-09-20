using StackExchange.Redis;

namespace atp.ApiAutomation.Sharding.Services
{
    // Cluster-wide token bucket: caps sustained request throughput across
    // every pod/shard, simulating a rate-limited AUT (e.g. "N requests/sec,
    // burst up to M"). Backed by Redis so bucket state is shared across
    // processes, not just in-memory.
    // Throughput-only gate - deliberately doesn't implement IRateLimiterService
    // (no Release: a spent token is never given back, only refilled by time).
    // Composed into CompositeRateLimiterService alongside a local concurrency gate.
    public class RedisRateLimiterService : IDisposable
    {
        private const string BucketKey = "sharding:ratelimiter:bucket";
        private static readonly TimeSpan PollInterval = TimeSpan.FromMilliseconds(50);

        // Lazily refills tokens based on elapsed time since the last touch,
        // then consumes one if available - all atomic in a single script so
        // concurrent callers can't race on the read-modify-write of the
        // token count. Uses Redis's own clock (TIME) rather than a
        // client-supplied timestamp so refill math can't be skewed by clock
        // drift between different pods/machines.
        private const string TryConsumeScript = @"
            local capacity = tonumber(ARGV[1])
            local refillPerSec = tonumber(ARGV[2])

            local time = redis.call('TIME')
            local nowMs = tonumber(time[1]) * 1000 + math.floor(tonumber(time[2]) / 1000)

            local tokens = tonumber(redis.call('HGET', KEYS[1], 'tokens'))
            local lastMs = tonumber(redis.call('HGET', KEYS[1], 'ts'))

            if tokens == nil then
                tokens = capacity
                lastMs = nowMs
            end

            local elapsedMs = nowMs - lastMs
            if elapsedMs > 0 then
                tokens = math.min(capacity, tokens + (elapsedMs / 1000.0) * refillPerSec)
            end

            local acquired = 0
            if tokens >= 1 then
                tokens = tokens - 1
                acquired = 1
            end

            redis.call('HSET', KEYS[1], 'tokens', tokens, 'ts', nowMs)
            return acquired";

        private readonly ConnectionMultiplexer _connection;
        private readonly IDatabase _db;
        private readonly int _capacity;
        private readonly int _refillPerSecond;

        public RedisRateLimiterService(string connectionString, int capacity, int refillPerSecond)
        {
            _capacity = capacity;
            _refillPerSecond = refillPerSecond;
            _connection = ConnectionMultiplexer.Connect(connectionString);
            _db = _connection.GetDatabase();
        }

        public void Acquire()
        {
            while ((int)_db.ScriptEvaluate(TryConsumeScript, new RedisKey[] { BucketKey }, new RedisValue[] { _capacity, _refillPerSecond }) == 0)
            {
                Thread.Sleep(PollInterval);
            }
        }

        public void Dispose()
        {
            _connection.Dispose();
        }
    }
}

namespace atp.ApiAutomation.Sharding.Services
{
    // Layers two independent gates, mirroring how real rate-limit-aware API
    // clients guard themselves: a local SemaphoreSlim caps how many tests
    // this pod runs concurrently (protects this process's own resources,
    // in-memory, cheap to check), then a cluster-wide Redis token bucket
    // caps sustained throughput across every pod (respects the simulated
    // AUT's rate limit, a network round trip). Local gate is checked first
    // since it's free - no reason to pay for a Redis round trip on a thread
    // that's going to block locally anyway.
    public class CompositeRateLimiterService : IRateLimiterService, IDisposable
    {
        private readonly SemaphoreSlim _localConcurrency;
        private readonly RedisRateLimiterService _tokenBucket;

        public CompositeRateLimiterService(int localConcurrencyLimit, RedisRateLimiterService tokenBucket)
        {
            _localConcurrency = new SemaphoreSlim(localConcurrencyLimit, localConcurrencyLimit);
            _tokenBucket = tokenBucket;
        }

        public void Acquire()
        {
            _localConcurrency.Wait();
            _tokenBucket.Acquire();
        }

        public void Release()
        {
            _localConcurrency.Release();
        }

        public void Dispose()
        {
            _localConcurrency.Dispose();
            _tokenBucket.Dispose();
        }
    }
}

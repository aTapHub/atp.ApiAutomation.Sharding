namespace atp.ApiAutomation.Sharding.Services
{
    public class SleepService : ISleepService
    {
        private readonly IRateLimiterService _rateLimiter;

        public SleepService(IRateLimiterService rateLimiter)
        {
            _rateLimiter = rateLimiter;
        }

        public void Sleep(int milliseconds)
        {
            _rateLimiter.Acquire();
            Thread.Sleep(milliseconds);
        }
    }
}

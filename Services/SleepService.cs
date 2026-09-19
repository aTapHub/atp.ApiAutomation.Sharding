namespace atp.ApiAutomation.Sharding.Services
{
    public class SleepService : ISleepService
    {
        public void Sleep(int milliseconds) => Thread.Sleep(milliseconds);
    }
}

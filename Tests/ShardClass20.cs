namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ShardClass20 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_6609ms()
        {
            SleepService.Sleep(6609);
            Test.Pass("Slept 6609ms.");
        }

        [Test]
        public void Test02_Sleeps_2808ms()
        {
            SleepService.Sleep(2808);
            Test.Pass("Slept 2808ms.");
        }

        [Test]
        public void Test03_Sleeps_4520ms()
        {
            SleepService.Sleep(4520);
            Test.Pass("Slept 4520ms.");
        }

        [Test]
        public void Test04_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test05_Sleeps_3239ms()
        {
            SleepService.Sleep(3239);
            Test.Pass("Slept 3239ms.");
        }

        [Test]
        public void Test06_Sleeps_7609ms()
        {
            SleepService.Sleep(7609);
            Test.Pass("Slept 7609ms.");
        }

        [Test]
        public void Test07_Sleeps_30000ms()
        {
            SleepService.Sleep(30000);
            Test.Pass("Slept 30000ms.");
        }

        [Test]
        public void Test08_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test09_Sleeps_2285ms()
        {
            SleepService.Sleep(2285);
            Test.Pass("Slept 2285ms.");
        }

        [Test]
        public void Test10_Sleeps_9923ms()
        {
            SleepService.Sleep(9923);
            Test.Pass("Slept 9923ms.");
        }
    }
}

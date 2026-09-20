namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ShardClass22 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test02_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test03_Sleeps_5477ms()
        {
            SleepService.Sleep(5477);
            Test.Pass("Slept 5477ms.");
        }

        [Test]
        public void Test04_Sleeps_1360ms()
        {
            SleepService.Sleep(1360);
            Test.Pass("Slept 1360ms.");
        }

        [Test]
        public void Test05_Sleeps_7315ms()
        {
            SleepService.Sleep(7315);
            Test.Pass("Slept 7315ms.");
        }

        [Test]
        public void Test06_Sleeps_2189ms()
        {
            SleepService.Sleep(2189);
            Test.Pass("Slept 2189ms.");
        }

        [Test]
        public void Test07_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test08_Sleeps_4053ms()
        {
            SleepService.Sleep(4053);
            Test.Pass("Slept 4053ms.");
        }

        [Test]
        public void Test09_Sleeps_2844ms()
        {
            SleepService.Sleep(2844);
            Test.Pass("Slept 2844ms.");
        }

        [Test]
        public void Test10_Sleeps_2779ms()
        {
            SleepService.Sleep(2779);
            Test.Pass("Slept 2779ms.");
        }
    }
}

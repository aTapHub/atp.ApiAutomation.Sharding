namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ShardClass27 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test02_Sleeps_30000ms()
        {
            SleepService.Sleep(30000);
            Test.Pass("Slept 30000ms.");
        }

        [Test]
        public void Test03_Sleeps_2501ms()
        {
            SleepService.Sleep(2501);
            Test.Pass("Slept 2501ms.");
        }

        [Test]
        public void Test04_Sleeps_5976ms()
        {
            SleepService.Sleep(5976);
            Test.Pass("Slept 5976ms.");
        }

        [Test]
        public void Test05_Sleeps_3366ms()
        {
            SleepService.Sleep(3366);
            Test.Pass("Slept 3366ms.");
        }

        [Test]
        public void Test06_Sleeps_7306ms()
        {
            SleepService.Sleep(7306);
            Test.Pass("Slept 7306ms.");
        }

        [Test]
        public void Test07_Sleeps_9597ms()
        {
            SleepService.Sleep(9597);
            Test.Pass("Slept 9597ms.");
        }

        [Test]
        public void Test08_Sleeps_1608ms()
        {
            SleepService.Sleep(1608);
            Test.Pass("Slept 1608ms.");
        }

        [Test]
        public void Test09_Sleeps_1141ms()
        {
            SleepService.Sleep(1141);
            Test.Pass("Slept 1141ms.");
        }

        [Test]
        public void Test10_Sleeps_1801ms()
        {
            SleepService.Sleep(1801);
            Test.Pass("Slept 1801ms.");
        }
    }
}

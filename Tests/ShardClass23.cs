namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ShardClass23 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test02_Sleeps_1485ms()
        {
            SleepService.Sleep(1485);
            Test.Pass("Slept 1485ms.");
        }

        [Test]
        public void Test03_Sleeps_2050ms()
        {
            SleepService.Sleep(2050);
            Test.Pass("Slept 2050ms.");
        }

        [Test]
        public void Test04_Sleeps_4526ms()
        {
            SleepService.Sleep(4526);
            Test.Pass("Slept 4526ms.");
        }

        [Test]
        public void Test05_Sleeps_6824ms()
        {
            SleepService.Sleep(6824);
            Test.Pass("Slept 6824ms.");
        }

        [Test]
        public void Test06_Sleeps_9297ms()
        {
            SleepService.Sleep(9297);
            Test.Pass("Slept 9297ms.");
        }

        [Test]
        public void Test07_Sleeps_6442ms()
        {
            SleepService.Sleep(6442);
            Test.Pass("Slept 6442ms.");
        }

        [Test]
        public void Test08_Sleeps_4704ms()
        {
            SleepService.Sleep(4704);
            Test.Pass("Slept 4704ms.");
        }

        [Test]
        public void Test09_Sleeps_1177ms()
        {
            SleepService.Sleep(1177);
            Test.Pass("Slept 1177ms.");
        }

        [Test]
        public void Test10_Sleeps_1108ms()
        {
            SleepService.Sleep(1108);
            Test.Pass("Slept 1108ms.");
        }
    }
}

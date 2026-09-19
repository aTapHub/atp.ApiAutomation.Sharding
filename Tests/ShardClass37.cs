namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass37 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test02_Sleeps_1424ms()
        {
            SleepService.Sleep(1424);
            Test.Pass("Slept 1424ms.");
        }

        [Test]
        public void Test03_Sleeps_6491ms()
        {
            SleepService.Sleep(6491);
            Test.Pass("Slept 6491ms.");
        }

        [Test]
        public void Test04_Sleeps_1255ms()
        {
            SleepService.Sleep(1255);
            Test.Pass("Slept 1255ms.");
        }

        [Test]
        public void Test05_Sleeps_4715ms()
        {
            SleepService.Sleep(4715);
            Test.Pass("Slept 4715ms.");
        }

        [Test]
        public void Test06_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test07_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test08_Sleeps_3069ms()
        {
            SleepService.Sleep(3069);
            Test.Pass("Slept 3069ms.");
        }

        [Test]
        public void Test09_Sleeps_8264ms()
        {
            SleepService.Sleep(8264);
            Test.Pass("Slept 8264ms.");
        }

        [Test]
        public void Test10_Sleeps_1274ms()
        {
            SleepService.Sleep(1274);
            Test.Pass("Slept 1274ms.");
        }
    }
}

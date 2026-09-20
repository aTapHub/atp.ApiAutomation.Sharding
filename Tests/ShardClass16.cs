namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ShardClass16 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test02_Sleeps_1914ms()
        {
            SleepService.Sleep(1914);
            Test.Pass("Slept 1914ms.");
        }

        [Test]
        public void Test03_Sleeps_1794ms()
        {
            SleepService.Sleep(1794);
            Test.Pass("Slept 1794ms.");
        }

        [Test]
        public void Test04_Sleeps_4004ms()
        {
            SleepService.Sleep(4004);
            Test.Pass("Slept 4004ms.");
        }

        [Test]
        public void Test05_Sleeps_30000ms()
        {
            SleepService.Sleep(30000);
            Test.Pass("Slept 30000ms.");
        }

        [Test]
        public void Test06_Sleeps_6935ms()
        {
            SleepService.Sleep(6935);
            Test.Pass("Slept 6935ms.");
        }

        [Test]
        public void Test07_Sleeps_2245ms()
        {
            SleepService.Sleep(2245);
            Test.Pass("Slept 2245ms.");
        }

        [Test]
        public void Test08_Sleeps_9583ms()
        {
            SleepService.Sleep(9583);
            Test.Pass("Slept 9583ms.");
        }

        [Test]
        public void Test09_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test10_Sleeps_1540ms()
        {
            SleepService.Sleep(1540);
            Test.Pass("Slept 1540ms.");
        }
    }
}

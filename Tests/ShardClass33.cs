namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass33 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_2232ms()
        {
            SleepService.Sleep(2232);
            Test.Pass("Slept 2232ms.");
        }

        [Test]
        public void Test02_Sleeps_3168ms()
        {
            SleepService.Sleep(3168);
            Test.Pass("Slept 3168ms.");
        }

        [Test]
        public void Test03_Sleeps_30000ms()
        {
            SleepService.Sleep(30000);
            Test.Pass("Slept 30000ms.");
        }

        [Test]
        public void Test04_Sleeps_8209ms()
        {
            SleepService.Sleep(8209);
            Test.Pass("Slept 8209ms.");
        }

        [Test]
        public void Test05_Sleeps_2029ms()
        {
            SleepService.Sleep(2029);
            Test.Pass("Slept 2029ms.");
        }

        [Test]
        public void Test06_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test07_Sleeps_2179ms()
        {
            SleepService.Sleep(2179);
            Test.Pass("Slept 2179ms.");
        }

        [Test]
        public void Test08_Sleeps_3208ms()
        {
            SleepService.Sleep(3208);
            Test.Pass("Slept 3208ms.");
        }

        [Test]
        public void Test09_Sleeps_4562ms()
        {
            SleepService.Sleep(4562);
            Test.Pass("Slept 4562ms.");
        }

        [Test]
        public void Test10_Sleeps_6454ms()
        {
            SleepService.Sleep(6454);
            Test.Pass("Slept 6454ms.");
        }
    }
}

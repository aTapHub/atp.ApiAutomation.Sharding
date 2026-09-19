namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass06 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_2688ms()
        {
            SleepService.Sleep(2688);
            Test.Pass("Slept 2688ms.");
        }

        [Test]
        public void Test02_Sleeps_3859ms()
        {
            SleepService.Sleep(3859);
            Test.Pass("Slept 3859ms.");
        }

        [Test]
        public void Test03_Sleeps_9873ms()
        {
            SleepService.Sleep(9873);
            Test.Pass("Slept 9873ms.");
        }

        [Test]
        public void Test04_Sleeps_1283ms()
        {
            SleepService.Sleep(1283);
            Test.Pass("Slept 1283ms.");
        }

        [Test]
        public void Test05_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test06_Sleeps_3084ms()
        {
            SleepService.Sleep(3084);
            Test.Pass("Slept 3084ms.");
        }

        [Test]
        public void Test07_Sleeps_1502ms()
        {
            SleepService.Sleep(1502);
            Test.Pass("Slept 1502ms.");
        }

        [Test]
        public void Test08_Sleeps_2460ms()
        {
            SleepService.Sleep(2460);
            Test.Pass("Slept 2460ms.");
        }

        [Test]
        public void Test09_Sleeps_5108ms()
        {
            SleepService.Sleep(5108);
            Test.Pass("Slept 5108ms.");
        }

        [Test]
        public void Test10_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }
    }
}

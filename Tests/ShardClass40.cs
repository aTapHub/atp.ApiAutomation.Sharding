namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass40 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_6127ms()
        {
            SleepService.Sleep(6127);
            Test.Pass("Slept 6127ms.");
        }

        [Test]
        public void Test02_Sleeps_2392ms()
        {
            SleepService.Sleep(2392);
            Test.Pass("Slept 2392ms.");
        }

        [Test]
        public void Test03_Sleeps_8167ms()
        {
            SleepService.Sleep(8167);
            Test.Pass("Slept 8167ms.");
        }

        [Test]
        public void Test04_Sleeps_2335ms()
        {
            SleepService.Sleep(2335);
            Test.Pass("Slept 2335ms.");
        }

        [Test]
        public void Test05_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test06_Sleeps_6756ms()
        {
            SleepService.Sleep(6756);
            Test.Pass("Slept 6756ms.");
        }

        [Test]
        public void Test07_Sleeps_4733ms()
        {
            SleepService.Sleep(4733);
            Test.Pass("Slept 4733ms.");
        }

        [Test]
        public void Test08_Sleeps_5769ms()
        {
            SleepService.Sleep(5769);
            Test.Pass("Slept 5769ms.");
        }

        [Test]
        public void Test09_Sleeps_1203ms()
        {
            SleepService.Sleep(1203);
            Test.Pass("Slept 1203ms.");
        }

        [Test]
        public void Test10_Sleeps_30000ms()
        {
            SleepService.Sleep(30000);
            Test.Pass("Slept 30000ms.");
        }
    }
}

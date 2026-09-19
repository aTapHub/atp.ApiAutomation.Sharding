namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass11 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test02_Sleeps_4959ms()
        {
            SleepService.Sleep(4959);
            Test.Pass("Slept 4959ms.");
        }

        [Test]
        public void Test03_Sleeps_5671ms()
        {
            SleepService.Sleep(5671);
            Test.Pass("Slept 5671ms.");
        }

        [Test]
        public void Test04_Sleeps_5994ms()
        {
            SleepService.Sleep(5994);
            Test.Pass("Slept 5994ms.");
        }

        [Test]
        public void Test05_Sleeps_5212ms()
        {
            SleepService.Sleep(5212);
            Test.Pass("Slept 5212ms.");
        }

        [Test]
        public void Test06_Sleeps_3849ms()
        {
            SleepService.Sleep(3849);
            Test.Pass("Slept 3849ms.");
        }

        [Test]
        public void Test07_Sleeps_9128ms()
        {
            SleepService.Sleep(9128);
            Test.Pass("Slept 9128ms.");
        }

        [Test]
        public void Test08_Sleeps_30000ms()
        {
            SleepService.Sleep(30000);
            Test.Pass("Slept 30000ms.");
        }

        [Test]
        public void Test09_Sleeps_30000ms()
        {
            SleepService.Sleep(30000);
            Test.Pass("Slept 30000ms.");
        }

        [Test]
        public void Test10_Sleeps_2616ms()
        {
            SleepService.Sleep(2616);
            Test.Pass("Slept 2616ms.");
        }
    }
}

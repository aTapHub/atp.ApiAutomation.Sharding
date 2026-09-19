namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass21 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_1923ms()
        {
            SleepService.Sleep(1923);
            Test.Pass("Slept 1923ms.");
        }

        [Test]
        public void Test02_Sleeps_1487ms()
        {
            SleepService.Sleep(1487);
            Test.Pass("Slept 1487ms.");
        }

        [Test]
        public void Test03_Sleeps_8984ms()
        {
            SleepService.Sleep(8984);
            Test.Pass("Slept 8984ms.");
        }

        [Test]
        public void Test04_Sleeps_2491ms()
        {
            SleepService.Sleep(2491);
            Test.Pass("Slept 2491ms.");
        }

        [Test]
        public void Test05_Sleeps_4629ms()
        {
            SleepService.Sleep(4629);
            Test.Pass("Slept 4629ms.");
        }

        [Test]
        public void Test06_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test07_Sleeps_8277ms()
        {
            SleepService.Sleep(8277);
            Test.Pass("Slept 8277ms.");
        }

        [Test]
        public void Test08_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test09_Sleeps_6994ms()
        {
            SleepService.Sleep(6994);
            Test.Pass("Slept 6994ms.");
        }

        [Test]
        public void Test10_Sleeps_3657ms()
        {
            SleepService.Sleep(3657);
            Test.Pass("Slept 3657ms.");
        }
    }
}

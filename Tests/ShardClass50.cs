namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ShardClass50 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_2602ms()
        {
            SleepService.Sleep(2602);
            Test.Pass("Slept 2602ms.");
        }

        [Test]
        public void Test02_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test03_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test04_Sleeps_9506ms()
        {
            SleepService.Sleep(9506);
            Test.Pass("Slept 9506ms.");
        }

        [Test]
        public void Test05_Sleeps_1204ms()
        {
            SleepService.Sleep(1204);
            Test.Pass("Slept 1204ms.");
        }

        [Test]
        public void Test06_Sleeps_7946ms()
        {
            SleepService.Sleep(7946);
            Test.Pass("Slept 7946ms.");
        }

        [Test]
        public void Test07_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test08_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test09_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test10_Sleeps_6761ms()
        {
            SleepService.Sleep(6761);
            Test.Pass("Slept 6761ms.");
        }
    }
}

namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ShardClass02 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_5679ms()
        {
            SleepService.Sleep(5679);
            Test.Pass("Slept 5679ms.");
        }

        [Test]
        public void Test02_Sleeps_4126ms()
        {
            SleepService.Sleep(4126);
            Test.Pass("Slept 4126ms.");
        }

        [Test]
        public void Test03_Sleeps_2422ms()
        {
            SleepService.Sleep(2422);
            Test.Pass("Slept 2422ms.");
        }

        [Test]
        public void Test04_Sleeps_1694ms()
        {
            SleepService.Sleep(1694);
            Test.Pass("Slept 1694ms.");
        }

        [Test]
        public void Test05_Sleeps_1118ms()
        {
            SleepService.Sleep(1118);
            Test.Pass("Slept 1118ms.");
        }

        [Test]
        public void Test06_Sleeps_2880ms()
        {
            SleepService.Sleep(2880);
            Test.Pass("Slept 2880ms.");
        }

        [Test]
        public void Test07_Sleeps_30000ms()
        {
            SleepService.Sleep(30000);
            Test.Pass("Slept 30000ms.");
        }

        [Test]
        public void Test08_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test09_Sleeps_3672ms()
        {
            SleepService.Sleep(3672);
            Test.Pass("Slept 3672ms.");
        }

        [Test]
        public void Test10_Sleeps_30000ms()
        {
            SleepService.Sleep(30000);
            Test.Pass("Slept 30000ms.");
        }
    }
}

namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass03 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_7771ms()
        {
            SleepService.Sleep(7771);
            Test.Pass("Slept 7771ms.");
        }

        [Test]
        public void Test02_Sleeps_4220ms()
        {
            SleepService.Sleep(4220);
            Test.Pass("Slept 4220ms.");
        }

        [Test]
        public void Test03_Sleeps_7066ms()
        {
            SleepService.Sleep(7066);
            Test.Pass("Slept 7066ms.");
        }

        [Test]
        public void Test04_Sleeps_9403ms()
        {
            SleepService.Sleep(9403);
            Test.Pass("Slept 9403ms.");
        }

        [Test]
        public void Test05_Sleeps_7619ms()
        {
            SleepService.Sleep(7619);
            Test.Pass("Slept 7619ms.");
        }

        [Test]
        public void Test06_Sleeps_4563ms()
        {
            SleepService.Sleep(4563);
            Test.Pass("Slept 4563ms.");
        }

        [Test]
        public void Test07_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test08_Sleeps_4315ms()
        {
            SleepService.Sleep(4315);
            Test.Pass("Slept 4315ms.");
        }

        [Test]
        public void Test09_Sleeps_2391ms()
        {
            SleepService.Sleep(2391);
            Test.Pass("Slept 2391ms.");
        }

        [Test]
        public void Test10_Sleeps_4220ms()
        {
            SleepService.Sleep(4220);
            Test.Pass("Slept 4220ms.");
        }
    }
}

namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass08 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_2331ms()
        {
            SleepService.Sleep(2331);
            Test.Pass("Slept 2331ms.");
        }

        [Test]
        public void Test02_Sleeps_4813ms()
        {
            SleepService.Sleep(4813);
            Test.Pass("Slept 4813ms.");
        }

        [Test]
        public void Test03_Sleeps_2682ms()
        {
            SleepService.Sleep(2682);
            Test.Pass("Slept 2682ms.");
        }

        [Test]
        public void Test04_Sleeps_8273ms()
        {
            SleepService.Sleep(8273);
            Test.Pass("Slept 8273ms.");
        }

        [Test]
        public void Test05_Sleeps_6586ms()
        {
            SleepService.Sleep(6586);
            Test.Pass("Slept 6586ms.");
        }

        [Test]
        public void Test06_Sleeps_1051ms()
        {
            SleepService.Sleep(1051);
            Test.Pass("Slept 1051ms.");
        }

        [Test]
        public void Test07_Sleeps_8025ms()
        {
            SleepService.Sleep(8025);
            Test.Pass("Slept 8025ms.");
        }

        [Test]
        public void Test08_Sleeps_1374ms()
        {
            SleepService.Sleep(1374);
            Test.Pass("Slept 1374ms.");
        }

        [Test]
        public void Test09_Sleeps_7142ms()
        {
            SleepService.Sleep(7142);
            Test.Pass("Slept 7142ms.");
        }

        [Test]
        public void Test10_Sleeps_2189ms()
        {
            SleepService.Sleep(2189);
            Test.Pass("Slept 2189ms.");
        }
    }
}

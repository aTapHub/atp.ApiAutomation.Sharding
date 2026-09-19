namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass14 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_1690ms()
        {
            SleepService.Sleep(1690);
            Test.Pass("Slept 1690ms.");
        }

        [Test]
        public void Test02_Sleeps_2747ms()
        {
            SleepService.Sleep(2747);
            Test.Pass("Slept 2747ms.");
        }

        [Test]
        public void Test03_Sleeps_3326ms()
        {
            SleepService.Sleep(3326);
            Test.Pass("Slept 3326ms.");
        }

        [Test]
        public void Test04_Sleeps_30000ms()
        {
            SleepService.Sleep(30000);
            Test.Pass("Slept 30000ms.");
        }

        [Test]
        public void Test05_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test06_Sleeps_8027ms()
        {
            SleepService.Sleep(8027);
            Test.Pass("Slept 8027ms.");
        }

        [Test]
        public void Test07_Sleeps_2158ms()
        {
            SleepService.Sleep(2158);
            Test.Pass("Slept 2158ms.");
        }

        [Test]
        public void Test08_Sleeps_5250ms()
        {
            SleepService.Sleep(5250);
            Test.Pass("Slept 5250ms.");
        }

        [Test]
        public void Test09_Sleeps_6869ms()
        {
            SleepService.Sleep(6869);
            Test.Pass("Slept 6869ms.");
        }

        [Test]
        public void Test10_Sleeps_1732ms()
        {
            SleepService.Sleep(1732);
            Test.Pass("Slept 1732ms.");
        }
    }
}

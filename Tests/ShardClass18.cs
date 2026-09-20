namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ShardClass18 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_3770ms()
        {
            SleepService.Sleep(3770);
            Test.Pass("Slept 3770ms.");
        }

        [Test]
        public void Test02_Sleeps_8468ms()
        {
            SleepService.Sleep(8468);
            Test.Pass("Slept 8468ms.");
        }

        [Test]
        public void Test03_Sleeps_4361ms()
        {
            SleepService.Sleep(4361);
            Test.Pass("Slept 4361ms.");
        }

        [Test]
        public void Test04_Sleeps_7257ms()
        {
            SleepService.Sleep(7257);
            Test.Pass("Slept 7257ms.");
        }

        [Test]
        public void Test05_Sleeps_3940ms()
        {
            SleepService.Sleep(3940);
            Test.Pass("Slept 3940ms.");
        }

        [Test]
        public void Test06_Sleeps_2254ms()
        {
            SleepService.Sleep(2254);
            Test.Pass("Slept 2254ms.");
        }

        [Test]
        public void Test07_Sleeps_30000ms()
        {
            SleepService.Sleep(30000);
            Test.Pass("Slept 30000ms.");
        }

        [Test]
        public void Test08_Sleeps_30000ms()
        {
            SleepService.Sleep(30000);
            Test.Pass("Slept 30000ms.");
        }

        [Test]
        public void Test09_Sleeps_5644ms()
        {
            SleepService.Sleep(5644);
            Test.Pass("Slept 5644ms.");
        }

        [Test]
        public void Test10_Sleeps_4528ms()
        {
            SleepService.Sleep(4528);
            Test.Pass("Slept 4528ms.");
        }
    }
}

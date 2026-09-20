namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ShardClass05 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_4064ms()
        {
            SleepService.Sleep(4064);
            Test.Pass("Slept 4064ms.");
        }

        [Test]
        public void Test02_Sleeps_4191ms()
        {
            SleepService.Sleep(4191);
            Test.Pass("Slept 4191ms.");
        }

        [Test]
        public void Test03_Sleeps_3172ms()
        {
            SleepService.Sleep(3172);
            Test.Pass("Slept 3172ms.");
        }

        [Test]
        public void Test04_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test05_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test06_Sleeps_9453ms()
        {
            SleepService.Sleep(9453);
            Test.Pass("Slept 9453ms.");
        }

        [Test]
        public void Test07_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test08_Sleeps_6622ms()
        {
            SleepService.Sleep(6622);
            Test.Pass("Slept 6622ms.");
        }

        [Test]
        public void Test09_Sleeps_3842ms()
        {
            SleepService.Sleep(3842);
            Test.Pass("Slept 3842ms.");
        }

        [Test]
        public void Test10_Sleeps_5818ms()
        {
            SleepService.Sleep(5818);
            Test.Pass("Slept 5818ms.");
        }
    }
}

namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ShardClass26 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test02_Sleeps_8255ms()
        {
            SleepService.Sleep(8255);
            Test.Pass("Slept 8255ms.");
        }

        [Test]
        public void Test03_Sleeps_1769ms()
        {
            SleepService.Sleep(1769);
            Test.Pass("Slept 1769ms.");
        }

        [Test]
        public void Test04_Sleeps_7100ms()
        {
            SleepService.Sleep(7100);
            Test.Pass("Slept 7100ms.");
        }

        [Test]
        public void Test05_Sleeps_4303ms()
        {
            SleepService.Sleep(4303);
            Test.Pass("Slept 4303ms.");
        }

        [Test]
        public void Test06_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test07_Sleeps_1563ms()
        {
            SleepService.Sleep(1563);
            Test.Pass("Slept 1563ms.");
        }

        [Test]
        public void Test08_Sleeps_5206ms()
        {
            SleepService.Sleep(5206);
            Test.Pass("Slept 5206ms.");
        }

        [Test]
        public void Test09_Sleeps_7896ms()
        {
            SleepService.Sleep(7896);
            Test.Pass("Slept 7896ms.");
        }

        [Test]
        public void Test10_Sleeps_9212ms()
        {
            SleepService.Sleep(9212);
            Test.Pass("Slept 9212ms.");
        }
    }
}

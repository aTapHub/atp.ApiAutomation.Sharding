namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass36 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_9724ms()
        {
            SleepService.Sleep(9724);
            Test.Pass("Slept 9724ms.");
        }

        [Test]
        public void Test02_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test03_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test04_Sleeps_2108ms()
        {
            SleepService.Sleep(2108);
            Test.Pass("Slept 2108ms.");
        }

        [Test]
        public void Test05_Sleeps_3418ms()
        {
            SleepService.Sleep(3418);
            Test.Pass("Slept 3418ms.");
        }

        [Test]
        public void Test06_Sleeps_2040ms()
        {
            SleepService.Sleep(2040);
            Test.Pass("Slept 2040ms.");
        }

        [Test]
        public void Test07_Sleeps_8262ms()
        {
            SleepService.Sleep(8262);
            Test.Pass("Slept 8262ms.");
        }

        [Test]
        public void Test08_Sleeps_2280ms()
        {
            SleepService.Sleep(2280);
            Test.Pass("Slept 2280ms.");
        }

        [Test]
        public void Test09_Sleeps_1746ms()
        {
            SleepService.Sleep(1746);
            Test.Pass("Slept 1746ms.");
        }

        [Test]
        public void Test10_Sleeps_3022ms()
        {
            SleepService.Sleep(3022);
            Test.Pass("Slept 3022ms.");
        }
    }
}

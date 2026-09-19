namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass15 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_7056ms()
        {
            SleepService.Sleep(7056);
            Test.Pass("Slept 7056ms.");
        }

        [Test]
        public void Test02_Sleeps_2815ms()
        {
            SleepService.Sleep(2815);
            Test.Pass("Slept 2815ms.");
        }

        [Test]
        public void Test03_Sleeps_1166ms()
        {
            SleepService.Sleep(1166);
            Test.Pass("Slept 1166ms.");
        }

        [Test]
        public void Test04_Sleeps_5154ms()
        {
            SleepService.Sleep(5154);
            Test.Pass("Slept 5154ms.");
        }

        [Test]
        public void Test05_Sleeps_6556ms()
        {
            SleepService.Sleep(6556);
            Test.Pass("Slept 6556ms.");
        }

        [Test]
        public void Test06_Sleeps_1862ms()
        {
            SleepService.Sleep(1862);
            Test.Pass("Slept 1862ms.");
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
        public void Test09_Sleeps_5915ms()
        {
            SleepService.Sleep(5915);
            Test.Pass("Slept 5915ms.");
        }

        [Test]
        public void Test10_Sleeps_3897ms()
        {
            SleepService.Sleep(3897);
            Test.Pass("Slept 3897ms.");
        }
    }
}

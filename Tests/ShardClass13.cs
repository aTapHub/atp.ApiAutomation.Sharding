namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass13 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_4533ms()
        {
            SleepService.Sleep(4533);
            Test.Pass("Slept 4533ms.");
        }

        [Test]
        public void Test02_Sleeps_3003ms()
        {
            SleepService.Sleep(3003);
            Test.Pass("Slept 3003ms.");
        }

        [Test]
        public void Test03_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test04_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test05_Sleeps_1567ms()
        {
            SleepService.Sleep(1567);
            Test.Pass("Slept 1567ms.");
        }

        [Test]
        public void Test06_Sleeps_8076ms()
        {
            SleepService.Sleep(8076);
            Test.Pass("Slept 8076ms.");
        }

        [Test]
        public void Test07_Sleeps_4169ms()
        {
            SleepService.Sleep(4169);
            Test.Pass("Slept 4169ms.");
        }

        [Test]
        public void Test08_Sleeps_5005ms()
        {
            SleepService.Sleep(5005);
            Test.Pass("Slept 5005ms.");
        }

        [Test]
        public void Test09_Sleeps_3119ms()
        {
            SleepService.Sleep(3119);
            Test.Pass("Slept 3119ms.");
        }

        [Test]
        public void Test10_Sleeps_3463ms()
        {
            SleepService.Sleep(3463);
            Test.Pass("Slept 3463ms.");
        }
    }
}

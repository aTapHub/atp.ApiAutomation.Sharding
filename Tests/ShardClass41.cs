namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass41 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_1444ms()
        {
            SleepService.Sleep(1444);
            Test.Pass("Slept 1444ms.");
        }

        [Test]
        public void Test02_Sleeps_3392ms()
        {
            SleepService.Sleep(3392);
            Test.Pass("Slept 3392ms.");
        }

        [Test]
        public void Test03_Sleeps_3688ms()
        {
            SleepService.Sleep(3688);
            Test.Pass("Slept 3688ms.");
        }

        [Test]
        public void Test04_Sleeps_2157ms()
        {
            SleepService.Sleep(2157);
            Test.Pass("Slept 2157ms.");
        }

        [Test]
        public void Test05_Sleeps_1036ms()
        {
            SleepService.Sleep(1036);
            Test.Pass("Slept 1036ms.");
        }

        [Test]
        public void Test06_Sleeps_5470ms()
        {
            SleepService.Sleep(5470);
            Test.Pass("Slept 5470ms.");
        }

        [Test]
        public void Test07_Sleeps_9949ms()
        {
            SleepService.Sleep(9949);
            Test.Pass("Slept 9949ms.");
        }

        [Test]
        public void Test08_Sleeps_2117ms()
        {
            SleepService.Sleep(2117);
            Test.Pass("Slept 2117ms.");
        }

        [Test]
        public void Test09_Sleeps_7687ms()
        {
            SleepService.Sleep(7687);
            Test.Pass("Slept 7687ms.");
        }

        [Test]
        public void Test10_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }
    }
}

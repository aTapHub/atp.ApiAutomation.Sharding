namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass34 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test02_Sleeps_4855ms()
        {
            SleepService.Sleep(4855);
            Test.Pass("Slept 4855ms.");
        }

        [Test]
        public void Test03_Sleeps_7031ms()
        {
            SleepService.Sleep(7031);
            Test.Pass("Slept 7031ms.");
        }

        [Test]
        public void Test04_Sleeps_4381ms()
        {
            SleepService.Sleep(4381);
            Test.Pass("Slept 4381ms.");
        }

        [Test]
        public void Test05_Sleeps_4115ms()
        {
            SleepService.Sleep(4115);
            Test.Pass("Slept 4115ms.");
        }

        [Test]
        public void Test06_Sleeps_1844ms()
        {
            SleepService.Sleep(1844);
            Test.Pass("Slept 1844ms.");
        }

        [Test]
        public void Test07_Sleeps_1574ms()
        {
            SleepService.Sleep(1574);
            Test.Pass("Slept 1574ms.");
        }

        [Test]
        public void Test08_Sleeps_3466ms()
        {
            SleepService.Sleep(3466);
            Test.Pass("Slept 3466ms.");
        }

        [Test]
        public void Test09_Sleeps_3592ms()
        {
            SleepService.Sleep(3592);
            Test.Pass("Slept 3592ms.");
        }

        [Test]
        public void Test10_Sleeps_8573ms()
        {
            SleepService.Sleep(8573);
            Test.Pass("Slept 8573ms.");
        }
    }
}

namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass31 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_1153ms()
        {
            SleepService.Sleep(1153);
            Test.Pass("Slept 1153ms.");
        }

        [Test]
        public void Test02_Sleeps_6885ms()
        {
            SleepService.Sleep(6885);
            Test.Pass("Slept 6885ms.");
        }

        [Test]
        public void Test03_Sleeps_9453ms()
        {
            SleepService.Sleep(9453);
            Test.Pass("Slept 9453ms.");
        }

        [Test]
        public void Test04_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test05_Sleeps_8381ms()
        {
            SleepService.Sleep(8381);
            Test.Pass("Slept 8381ms.");
        }

        [Test]
        public void Test06_Sleeps_4426ms()
        {
            SleepService.Sleep(4426);
            Test.Pass("Slept 4426ms.");
        }

        [Test]
        public void Test07_Sleeps_4624ms()
        {
            SleepService.Sleep(4624);
            Test.Pass("Slept 4624ms.");
        }

        [Test]
        public void Test08_Sleeps_4855ms()
        {
            SleepService.Sleep(4855);
            Test.Pass("Slept 4855ms.");
        }

        [Test]
        public void Test09_Sleeps_6092ms()
        {
            SleepService.Sleep(6092);
            Test.Pass("Slept 6092ms.");
        }

        [Test]
        public void Test10_Sleeps_2998ms()
        {
            SleepService.Sleep(2998);
            Test.Pass("Slept 2998ms.");
        }
    }
}

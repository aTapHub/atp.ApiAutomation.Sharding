namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass25 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test02_Sleeps_8199ms()
        {
            SleepService.Sleep(8199);
            Test.Pass("Slept 8199ms.");
        }

        [Test]
        public void Test03_Sleeps_2854ms()
        {
            SleepService.Sleep(2854);
            Test.Pass("Slept 2854ms.");
        }

        [Test]
        public void Test04_Sleeps_4948ms()
        {
            SleepService.Sleep(4948);
            Test.Pass("Slept 4948ms.");
        }

        [Test]
        public void Test05_Sleeps_30000ms()
        {
            SleepService.Sleep(30000);
            Test.Pass("Slept 30000ms.");
        }

        [Test]
        public void Test06_Sleeps_3129ms()
        {
            SleepService.Sleep(3129);
            Test.Pass("Slept 3129ms.");
        }

        [Test]
        public void Test07_Sleeps_7421ms()
        {
            SleepService.Sleep(7421);
            Test.Pass("Slept 7421ms.");
        }

        [Test]
        public void Test08_Sleeps_30000ms()
        {
            SleepService.Sleep(30000);
            Test.Pass("Slept 30000ms.");
        }

        [Test]
        public void Test09_Sleeps_9414ms()
        {
            SleepService.Sleep(9414);
            Test.Pass("Slept 9414ms.");
        }

        [Test]
        public void Test10_Sleeps_6754ms()
        {
            SleepService.Sleep(6754);
            Test.Pass("Slept 6754ms.");
        }
    }
}

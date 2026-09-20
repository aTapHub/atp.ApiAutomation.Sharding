namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ShardClass09 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_2122ms()
        {
            SleepService.Sleep(2122);
            Test.Pass("Slept 2122ms.");
        }

        [Test]
        public void Test02_Sleeps_4256ms()
        {
            SleepService.Sleep(4256);
            Test.Pass("Slept 4256ms.");
        }

        [Test]
        public void Test03_Sleeps_3091ms()
        {
            SleepService.Sleep(3091);
            Test.Pass("Slept 3091ms.");
        }

        [Test]
        public void Test04_Sleeps_3051ms()
        {
            SleepService.Sleep(3051);
            Test.Pass("Slept 3051ms.");
        }

        [Test]
        public void Test05_Sleeps_2469ms()
        {
            SleepService.Sleep(2469);
            Test.Pass("Slept 2469ms.");
        }

        [Test]
        public void Test06_Sleeps_6781ms()
        {
            SleepService.Sleep(6781);
            Test.Pass("Slept 6781ms.");
        }

        [Test]
        public void Test07_Sleeps_1222ms()
        {
            SleepService.Sleep(1222);
            Test.Pass("Slept 1222ms.");
        }

        [Test]
        public void Test08_Sleeps_9535ms()
        {
            SleepService.Sleep(9535);
            Test.Pass("Slept 9535ms.");
        }

        [Test]
        public void Test09_Sleeps_8761ms()
        {
            SleepService.Sleep(8761);
            Test.Pass("Slept 8761ms.");
        }

        [Test]
        public void Test10_Sleeps_4552ms()
        {
            SleepService.Sleep(4552);
            Test.Pass("Slept 4552ms.");
        }
    }
}

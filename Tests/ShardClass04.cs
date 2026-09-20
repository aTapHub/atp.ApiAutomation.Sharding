namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ShardClass04 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test02_Sleeps_3603ms()
        {
            SleepService.Sleep(3603);
            Test.Pass("Slept 3603ms.");
        }

        [Test]
        public void Test03_Sleeps_5003ms()
        {
            SleepService.Sleep(5003);
            Test.Pass("Slept 5003ms.");
        }

        [Test]
        public void Test04_Sleeps_8426ms()
        {
            SleepService.Sleep(8426);
            Test.Pass("Slept 8426ms.");
        }

        [Test]
        public void Test05_Sleeps_2538ms()
        {
            SleepService.Sleep(2538);
            Test.Pass("Slept 2538ms.");
        }

        [Test]
        public void Test06_Sleeps_4654ms()
        {
            SleepService.Sleep(4654);
            Test.Pass("Slept 4654ms.");
        }

        [Test]
        public void Test07_Sleeps_1727ms()
        {
            SleepService.Sleep(1727);
            Test.Pass("Slept 1727ms.");
        }

        [Test]
        public void Test08_Sleeps_1745ms()
        {
            SleepService.Sleep(1745);
            Test.Pass("Slept 1745ms.");
        }

        [Test]
        public void Test09_Sleeps_1594ms()
        {
            SleepService.Sleep(1594);
            Test.Pass("Slept 1594ms.");
        }

        [Test]
        public void Test10_Sleeps_9293ms()
        {
            SleepService.Sleep(9293);
            Test.Pass("Slept 9293ms.");
        }
    }
}

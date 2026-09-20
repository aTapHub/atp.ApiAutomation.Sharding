namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ShardClass07 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_8757ms()
        {
            SleepService.Sleep(8757);
            Test.Pass("Slept 8757ms.");
        }

        [Test]
        public void Test02_Sleeps_3844ms()
        {
            SleepService.Sleep(3844);
            Test.Pass("Slept 3844ms.");
        }

        [Test]
        public void Test03_Sleeps_6562ms()
        {
            SleepService.Sleep(6562);
            Test.Pass("Slept 6562ms.");
        }

        [Test]
        public void Test04_Sleeps_1209ms()
        {
            SleepService.Sleep(1209);
            Test.Pass("Slept 1209ms.");
        }

        [Test]
        public void Test05_Sleeps_3650ms()
        {
            SleepService.Sleep(3650);
            Test.Pass("Slept 3650ms.");
        }

        [Test]
        public void Test06_Sleeps_5917ms()
        {
            SleepService.Sleep(5917);
            Test.Pass("Slept 5917ms.");
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
        public void Test09_Sleeps_4264ms()
        {
            SleepService.Sleep(4264);
            Test.Pass("Slept 4264ms.");
        }

        [Test]
        public void Test10_Sleeps_9702ms()
        {
            SleepService.Sleep(9702);
            Test.Pass("Slept 9702ms.");
        }
    }
}

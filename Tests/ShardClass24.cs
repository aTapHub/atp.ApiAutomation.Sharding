namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ShardClass24 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_3537ms()
        {
            SleepService.Sleep(3537);
            Test.Pass("Slept 3537ms.");
        }

        [Test]
        public void Test02_Sleeps_5777ms()
        {
            SleepService.Sleep(5777);
            Test.Pass("Slept 5777ms.");
        }

        [Test]
        public void Test03_Sleeps_8219ms()
        {
            SleepService.Sleep(8219);
            Test.Pass("Slept 8219ms.");
        }

        [Test]
        public void Test04_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test05_Sleeps_7509ms()
        {
            SleepService.Sleep(7509);
            Test.Pass("Slept 7509ms.");
        }

        [Test]
        public void Test06_Sleeps_3505ms()
        {
            SleepService.Sleep(3505);
            Test.Pass("Slept 3505ms.");
        }

        [Test]
        public void Test07_Sleeps_1429ms()
        {
            SleepService.Sleep(1429);
            Test.Pass("Slept 1429ms.");
        }

        [Test]
        public void Test08_Sleeps_1011ms()
        {
            SleepService.Sleep(1011);
            Test.Pass("Slept 1011ms.");
        }

        [Test]
        public void Test09_Sleeps_3882ms()
        {
            SleepService.Sleep(3882);
            Test.Pass("Slept 3882ms.");
        }

        [Test]
        public void Test10_Sleeps_1878ms()
        {
            SleepService.Sleep(1878);
            Test.Pass("Slept 1878ms.");
        }
    }
}

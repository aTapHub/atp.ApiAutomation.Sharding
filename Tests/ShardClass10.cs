namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass10 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_9303ms()
        {
            SleepService.Sleep(9303);
            Test.Pass("Slept 9303ms.");
        }

        [Test]
        public void Test02_Sleeps_6042ms()
        {
            SleepService.Sleep(6042);
            Test.Pass("Slept 6042ms.");
        }

        [Test]
        public void Test03_Sleeps_3224ms()
        {
            SleepService.Sleep(3224);
            Test.Pass("Slept 3224ms.");
        }

        [Test]
        public void Test04_Sleeps_4738ms()
        {
            SleepService.Sleep(4738);
            Test.Pass("Slept 4738ms.");
        }

        [Test]
        public void Test05_Sleeps_3332ms()
        {
            SleepService.Sleep(3332);
            Test.Pass("Slept 3332ms.");
        }

        [Test]
        public void Test06_Sleeps_1015ms()
        {
            SleepService.Sleep(1015);
            Test.Pass("Slept 1015ms.");
        }

        [Test]
        public void Test07_Sleeps_3993ms()
        {
            SleepService.Sleep(3993);
            Test.Pass("Slept 3993ms.");
        }

        [Test]
        public void Test08_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test09_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test10_Sleeps_3065ms()
        {
            SleepService.Sleep(3065);
            Test.Pass("Slept 3065ms.");
        }
    }
}

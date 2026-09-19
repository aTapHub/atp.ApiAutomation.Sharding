namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass30 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test02_Sleeps_30000ms()
        {
            SleepService.Sleep(30000);
            Test.Pass("Slept 30000ms.");
        }

        [Test]
        public void Test03_Sleeps_5547ms()
        {
            SleepService.Sleep(5547);
            Test.Pass("Slept 5547ms.");
        }

        [Test]
        public void Test04_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test05_Sleeps_4583ms()
        {
            SleepService.Sleep(4583);
            Test.Pass("Slept 4583ms.");
        }

        [Test]
        public void Test06_Sleeps_8325ms()
        {
            SleepService.Sleep(8325);
            Test.Pass("Slept 8325ms.");
        }

        [Test]
        public void Test07_Sleeps_9765ms()
        {
            SleepService.Sleep(9765);
            Test.Pass("Slept 9765ms.");
        }

        [Test]
        public void Test08_Sleeps_1999ms()
        {
            SleepService.Sleep(1999);
            Test.Pass("Slept 1999ms.");
        }

        [Test]
        public void Test09_Sleeps_8360ms()
        {
            SleepService.Sleep(8360);
            Test.Pass("Slept 8360ms.");
        }

        [Test]
        public void Test10_Sleeps_3350ms()
        {
            SleepService.Sleep(3350);
            Test.Pass("Slept 3350ms.");
        }
    }
}

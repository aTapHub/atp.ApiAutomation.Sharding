namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass28 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_8933ms()
        {
            SleepService.Sleep(8933);
            Test.Pass("Slept 8933ms.");
        }

        [Test]
        public void Test02_Sleeps_1499ms()
        {
            SleepService.Sleep(1499);
            Test.Pass("Slept 1499ms.");
        }

        [Test]
        public void Test03_Sleeps_3053ms()
        {
            SleepService.Sleep(3053);
            Test.Pass("Slept 3053ms.");
        }

        [Test]
        public void Test04_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test05_Sleeps_5093ms()
        {
            SleepService.Sleep(5093);
            Test.Pass("Slept 5093ms.");
        }

        [Test]
        public void Test06_Sleeps_2295ms()
        {
            SleepService.Sleep(2295);
            Test.Pass("Slept 2295ms.");
        }

        [Test]
        public void Test07_Sleeps_3369ms()
        {
            SleepService.Sleep(3369);
            Test.Pass("Slept 3369ms.");
        }

        [Test]
        public void Test08_Sleeps_4045ms()
        {
            SleepService.Sleep(4045);
            Test.Pass("Slept 4045ms.");
        }

        [Test]
        public void Test09_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test10_Sleeps_9214ms()
        {
            SleepService.Sleep(9214);
            Test.Pass("Slept 9214ms.");
        }
    }
}

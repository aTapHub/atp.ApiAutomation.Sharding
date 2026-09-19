namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass12 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test02_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test03_Sleeps_2381ms()
        {
            SleepService.Sleep(2381);
            Test.Pass("Slept 2381ms.");
        }

        [Test]
        public void Test04_Sleeps_2856ms()
        {
            SleepService.Sleep(2856);
            Test.Pass("Slept 2856ms.");
        }

        [Test]
        public void Test05_Sleeps_3616ms()
        {
            SleepService.Sleep(3616);
            Test.Pass("Slept 3616ms.");
        }

        [Test]
        public void Test06_Sleeps_4523ms()
        {
            SleepService.Sleep(4523);
            Test.Pass("Slept 4523ms.");
        }

        [Test]
        public void Test07_Sleeps_1077ms()
        {
            SleepService.Sleep(1077);
            Test.Pass("Slept 1077ms.");
        }

        [Test]
        public void Test08_Sleeps_1988ms()
        {
            SleepService.Sleep(1988);
            Test.Pass("Slept 1988ms.");
        }

        [Test]
        public void Test09_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test10_Sleeps_9698ms()
        {
            SleepService.Sleep(9698);
            Test.Pass("Slept 9698ms.");
        }
    }
}

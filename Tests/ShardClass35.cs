namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class ShardClass35 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_30000ms()
        {
            SleepService.Sleep(30000);
            Test.Pass("Slept 30000ms.");
        }

        [Test]
        public void Test02_Sleeps_1596ms()
        {
            SleepService.Sleep(1596);
            Test.Pass("Slept 1596ms.");
        }

        [Test]
        public void Test03_Sleeps_1649ms()
        {
            SleepService.Sleep(1649);
            Test.Pass("Slept 1649ms.");
        }

        [Test]
        public void Test04_Sleeps_5009ms()
        {
            SleepService.Sleep(5009);
            Test.Pass("Slept 5009ms.");
        }

        [Test]
        public void Test05_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test06_Sleeps_1176ms()
        {
            SleepService.Sleep(1176);
            Test.Pass("Slept 1176ms.");
        }

        [Test]
        public void Test07_Sleeps_5542ms()
        {
            SleepService.Sleep(5542);
            Test.Pass("Slept 5542ms.");
        }

        [Test]
        public void Test08_Sleeps_8952ms()
        {
            SleepService.Sleep(8952);
            Test.Pass("Slept 8952ms.");
        }

        [Test]
        public void Test09_Sleeps_9135ms()
        {
            SleepService.Sleep(9135);
            Test.Pass("Slept 9135ms.");
        }

        [Test]
        public void Test10_Sleeps_9736ms()
        {
            SleepService.Sleep(9736);
            Test.Pass("Slept 9736ms.");
        }
    }
}

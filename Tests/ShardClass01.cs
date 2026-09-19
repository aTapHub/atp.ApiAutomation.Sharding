namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass01 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_7845ms()
        {
            SleepService.Sleep(7845);
            Test.Pass("Slept 7845ms.");
        }

        [Test]
        public void Test02_Sleeps_30000ms()
        {
            SleepService.Sleep(30000);
            Test.Pass("Slept 30000ms.");
        }

        [Test]
        public void Test03_Sleeps_7721ms()
        {
            SleepService.Sleep(7721);
            Test.Pass("Slept 7721ms.");
        }

        [Test]
        public void Test04_Sleeps_1952ms()
        {
            SleepService.Sleep(1952);
            Test.Pass("Slept 1952ms.");
        }

        [Test]
        public void Test05_Sleeps_15000ms()
        {
            SleepService.Sleep(15000);
            Test.Pass("Slept 15000ms.");
        }

        [Test]
        public void Test06_Sleeps_7965ms()
        {
            SleepService.Sleep(7965);
            Test.Pass("Slept 7965ms.");
        }

        [Test]
        public void Test07_Sleeps_5901ms()
        {
            SleepService.Sleep(5901);
            Test.Pass("Slept 5901ms.");
        }

        [Test]
        public void Test08_Sleeps_2866ms()
        {
            SleepService.Sleep(2866);
            Test.Pass("Slept 2866ms.");
        }

        [Test]
        public void Test09_Sleeps_9690ms()
        {
            SleepService.Sleep(9690);
            Test.Pass("Slept 9690ms.");
        }

        [Test]
        public void Test10_Sleeps_3872ms()
        {
            SleepService.Sleep(3872);
            Test.Pass("Slept 3872ms.");
        }
    }
}

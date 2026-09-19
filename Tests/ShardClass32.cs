namespace atp.ApiAutomation.Sharding.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ShardClass32 : BaseTest
    {
        [Test]
        public void Test01_Sleeps_7106ms()
        {
            SleepService.Sleep(7106);
            Test.Pass("Slept 7106ms.");
        }

        [Test]
        public void Test02_Sleeps_20000ms()
        {
            SleepService.Sleep(20000);
            Test.Pass("Slept 20000ms.");
        }

        [Test]
        public void Test03_Sleeps_3063ms()
        {
            SleepService.Sleep(3063);
            Test.Pass("Slept 3063ms.");
        }

        [Test]
        public void Test04_Sleeps_2600ms()
        {
            SleepService.Sleep(2600);
            Test.Pass("Slept 2600ms.");
        }

        [Test]
        public void Test05_Sleeps_4289ms()
        {
            SleepService.Sleep(4289);
            Test.Pass("Slept 4289ms.");
        }

        [Test]
        public void Test06_Sleeps_1035ms()
        {
            SleepService.Sleep(1035);
            Test.Pass("Slept 1035ms.");
        }

        [Test]
        public void Test07_Sleeps_8064ms()
        {
            SleepService.Sleep(8064);
            Test.Pass("Slept 8064ms.");
        }

        [Test]
        public void Test08_Sleeps_3537ms()
        {
            SleepService.Sleep(3537);
            Test.Pass("Slept 3537ms.");
        }

        [Test]
        public void Test09_Sleeps_6480ms()
        {
            SleepService.Sleep(6480);
            Test.Pass("Slept 6480ms.");
        }

        [Test]
        public void Test10_Sleeps_5497ms()
        {
            SleepService.Sleep(5497);
            Test.Pass("Slept 5497ms.");
        }
    }
}

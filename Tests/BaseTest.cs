using atp.ApiAutomation.Sharding.Services;
using AventStack.ExtentReports;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

[assembly: LevelOfParallelism(75)]
namespace atp.ApiAutomation.Sharding.Tests
{
    public class BaseTest
    {
        protected ExtentTest Test { get; set; } = null!;
        protected ISleepService SleepService { get; private set; } = null!;

        [OneTimeSetUp]
        public void ResolveServices()
        {
            SleepService = SetupFixture.ServiceProvider.GetRequiredService<ISleepService>();
        }

        [SetUp]
        public void Setup()
        {
            Test = SetupFixture.Extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var message = TestContext.CurrentContext.Result.Message;
            var stacktrace = TestContext.CurrentContext.Result.StackTrace;

            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                Test.Fail($"Test Failed: {message}");
                Test.Log(Status.Fail, stacktrace);
            }
            else if (status == NUnit.Framework.Interfaces.TestStatus.Skipped)
            {
                Test.Skip($"Test Skipped: {message}");
            }
            else
            {
                Test.Pass("Test Passed successfully.");
            }
        }
    }
}

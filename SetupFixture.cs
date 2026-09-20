using atp.ApiAutomation.Sharding.Services;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace atp.ApiAutomation.Sharding
{
    [SetUpFixture]
    public class SetupFixture
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;
        public static ExtentReports Extent { get; set; } = null!;

        private static readonly string reportDirectory
            = Path.Combine(TestContext.CurrentContext.TestDirectory, "TestReport");

        [OneTimeSetUp]
        public void SetupConfig()
        {
            // Dependency injection container - built once and shared across all
            // fixtures, same shape as atp.ApiAutomation.Framework's SetupFixture.
            var redisConnection = Environment.GetEnvironmentVariable("REDIS_CONNECTION") ?? "localhost:6379";
            var bucketCapacity = int.Parse(Environment.GetEnvironmentVariable("BUCKET_CAPACITY") ?? "25");
            var refillPerSecond = int.Parse(Environment.GetEnvironmentVariable("REFILL_PER_SECOND") ?? "10");

            var services = new ServiceCollection();
            services.AddSingleton<IRateLimiterService>(new RedisRateLimiterService(redisConnection, bucketCapacity, refillPerSecond));
            services.AddTransient<ISleepService, SleepService>();
            ServiceProvider = services.BuildServiceProvider();

            // Extent Report setup
            if (Directory.Exists(reportDirectory))
            {
                Directory.Delete(reportDirectory, true);
            }

            Directory.CreateDirectory(reportDirectory);

            Extent = new ExtentReports();

            var sparkReporter = new ExtentSparkReporter(Path.Combine(reportDirectory, "index.html"));
            Extent.AttachReporter(sparkReporter);

            Extent.AddSystemInfo(".NET Version", Environment.Version.ToString());
            Extent.AddSystemInfo("OS", Environment.OSVersion.VersionString);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            if (ServiceProvider is IDisposable disposableProvider)
            {
                disposableProvider.Dispose();
            }

            Extent.Flush();
        }
    }
}

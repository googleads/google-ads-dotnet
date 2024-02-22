using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V14.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Google.Ads.GoogleAds.Extensions.DependencyInjection.Tests
{
    /// <summary>
    /// Tests the dependency injection package.
    /// </summary>
    [TestFixture]
    [Category("Integration")]
    public class TestGoogleAdsClientServiceCollectionExtensions
    {
        private IGoogleAdsClient googleAdsClient;

        [SetUp]
        public void Setup()
        {
            // read the configuration from appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot Configuration = builder.Build();
            IServiceCollection services = new ServiceCollection();

            // add the Google Ads Client to the DI container
            services.AddGoogleAdsClient(Configuration);
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            // get the configured Google Ads Client from the DI container
            googleAdsClient = serviceProvider.GetService<IGoogleAdsClient>();
        }

        [Test]
        public async Task TestAddGoogleAdsClientAsync()
        {
            string customerId = "987654543";
            long adId = 123456789012;
            string query =
                "SELECT ad_group_ad.ad.id " +
                "FROM ad_group_ad " +
                $"WHERE ad_group_ad.ad.id={adId} LIMIT 1";

            GoogleAdsServiceClient googleAdsServiceClient = googleAdsClient.GetService(Services.V14.GoogleAdsService);

            Task t = googleAdsServiceClient.SearchStreamAsync(customerId, query,
                delegate (SearchGoogleAdsStreamResponse resp)
                {
                    foreach (GoogleAdsRow googleAdsRow in resp.Results)
                    {
                        Assert.AreEqual(googleAdsRow.AdGroupAd.Ad.Id, adId);
                    }
                });
            await t;
        }
    }
}

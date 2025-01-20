using System;
using System.IO;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V18.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;


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

        [Test]
        public void TestGetGoogleAdsClientFromDIContainer()
        {
            // read the configuration from appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot Configuration = builder.Build();
            IServiceCollection services = new ServiceCollection();

            // add the Google Ads Client to the DI container
            services.AddGoogleAdsClient(Configuration);
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            // get the configured Google Ads Client from the DI container
            googleAdsClient = serviceProvider.GetService<IGoogleAdsClient>();

            GoogleAdsServiceClient googleAdsService = googleAdsClient.GetService(
                Services.V18.GoogleAdsService);

            Assert.AreEqual("abcdefghijkl1234567890", googleAdsService.ServiceContext.Client.Config.DeveloperToken);
            Assert.AreEqual("TEST_OAUTH2_CLIENT_ID", googleAdsService.ServiceContext.Client.Config.OAuth2ClientId);
            Assert.AreEqual("TEST_OAUTH2_CLIENT_SECRET", googleAdsService.ServiceContext.Client.Config.OAuth2ClientSecret);
            Assert.AreEqual("TEST_OAUTH2_REFRESH_TOKEN", googleAdsService.ServiceContext.Client.Config.OAuth2RefreshToken);
            Assert.AreEqual("TEST_OAUTH2_PRN_EMAIL", googleAdsService.ServiceContext.Client.Config.OAuth2PrnEmail);
            Assert.AreEqual("TEST_EMAIL", googleAdsService.ServiceContext.Client.Config.OAuth2ServiceAccountEmail);
            Assert.AreEqual("TEST_PRIVATE_KEY", googleAdsService.ServiceContext.Client.Config.OAuth2PrivateKey);
            Assert.AreEqual("TEST_SCOPE", googleAdsService.ServiceContext.Client.Config.OAuth2Scope);
            Assert.IsTrue(googleAdsService.ServiceContext.Client.Config.UseCloudOrgForApiAccess);
            Assert.AreEqual(12345, googleAdsService.ServiceContext.Client.Config.MaxReceiveMessageSizeInBytes);
            Assert.AreEqual(54321, googleAdsService.ServiceContext.Client.Config.MaxMetadataSizeInBytes);
        }

    }
}

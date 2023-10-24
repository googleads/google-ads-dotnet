using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Extensions.DependencyInjection;
using Google.Ads.GoogleAds.Lib;
using Microsoft.Extensions.Configuration;
using GoogleAdsConfig = Google.Ads.GoogleAds.Extensions.DependencyInjection.GoogleAdsConfig;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class GoogleAdsClientServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the settings, Google Ads Config, and the Google Ads Client to the DI container.
        /// </summary>
        public static IServiceCollection AddGoogleAdsClient(this IServiceCollection services, IConfiguration config)
        {
            IConfigurationSection googleAdsSection = config.GetSection(GoogleAdsApiOptions.GoogleAdsApi);
            if (!googleAdsSection.Exists())
            {
                throw new Exception($"Missing {GoogleAdsApiOptions.GoogleAdsApi} configuration.");
            }

            // add the setting to the DI container as options
            services.Configure<GoogleAdsApiOptions>(googleAdsSection);

            // add the GoogleAdsConfig to the DI container
            services.AddSingleton<IGoogleAdsConfig, GoogleAdsConfig>();

            // add the GoogleAdsClient to the DI container
            services.AddTransient<IGoogleAdsClient, GoogleAdsClient>();

            return services;
        }
    }
}

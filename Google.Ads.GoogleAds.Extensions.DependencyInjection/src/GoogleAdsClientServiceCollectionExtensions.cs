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
        /// Adds the settings, Google Ads Config, and the Google Ads Client to the dependency
        /// injection container.
        /// </summary>
        public static IServiceCollection AddGoogleAdsClient(this IServiceCollection services, IConfiguration config)
        {
            IConfigurationSection googleAdsSection = config.GetSection(GoogleAdsApiOptions.GoogleAdsApi);
            if (!googleAdsSection.Exists())
            {
                throw new Exception($"Missing {GoogleAdsApiOptions.GoogleAdsApi} configuration.");
            }

            // Add the setting to the dependency injection container as options.
            services.Configure<GoogleAdsApiOptions>(googleAdsSection);

            // Add the GoogleAdsConfig to the dependency injection container.
            services.AddSingleton<IGoogleAdsConfig, GoogleAdsConfig>();

            // Add the GoogleAdsClient to the dependency injection container.
            services.AddTransient<IGoogleAdsClient, GoogleAdsClient>();

            return services;
        }
    }
}

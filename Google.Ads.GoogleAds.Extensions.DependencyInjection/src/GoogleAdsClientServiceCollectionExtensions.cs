using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Extensions.DependencyInjection;
using Google.Ads.GoogleAds.Lib;
using Microsoft.Extensions.Configuration;
using GoogleAdsConfig = Google.Ads.GoogleAds.Extensions.DependencyInjection.GoogleAdsConfig;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class GoogleAdsClientServiceCollectionExtensions
    {
        public static IServiceCollection AddGoogleAdsClient(this IServiceCollection services, IConfiguration config)
        {
            IConfigurationSection googleAdsSection = config.GetSection(GoogleAdsApiOptions.GoogleAdsApi);
            if (!googleAdsSection.Exists())
            {
                throw new Exception($"Missing {GoogleAdsApiOptions.GoogleAdsApi} configuration.");
            }

            services.Configure<GoogleAdsApiOptions>(googleAdsSection);
            services.AddSingleton<IGoogleAdsConfig, GoogleAdsConfig>();
            services.AddTransient<IGoogleAdsClient, GoogleAdsClient>();

            return services;
        }
    }
}

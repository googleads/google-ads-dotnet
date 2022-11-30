using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Lib;
using Microsoft.Extensions.Configuration;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// 
    /// </summary>
    public static class GoogleAdsClientServiceCollectionExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static IServiceCollection AddGoogleAdsClient(this IServiceCollection services, IConfiguration config)
        {
            IConfigurationSection googleAdsSection = config.GetSection(GoogleAdsApiOptions.GoogleAdsApi);
            if (!googleAdsSection.Exists())
            {
                throw new Exception($"Missing {GoogleAdsApiOptions.GoogleAdsApi} configuration.");
            }

            services.Configure<GoogleAdsApiOptions>(googleAdsSection);
            services.AddSingleton<IGoogleAdsConfig, GoogleAdsConfig>();
            services.AddSingleton<IGoogleAdsClient, GoogleAdsClient>();

            return services;
        }
    }
}

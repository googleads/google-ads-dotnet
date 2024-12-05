using System;
using Google.Ads.Gax.Config;
using Microsoft.Extensions.Options;

namespace Google.Ads.GoogleAds.Extensions.DependencyInjection
{
    /// <summary>
    /// Configuration options to be injected in a DI container.
    /// </summary>
    public class GoogleAdsConfig : GoogleAds.Config.GoogleAdsConfig
    {

        /// <summary>
        /// Public constructor. Loads the configuration from injected options.
        /// </summary>
        public GoogleAdsConfig(IOptions<GoogleAdsApiOptions> options)
        {
            DeveloperToken = options.Value.DeveloperToken;
            OAuth2Mode = (OAuth2Flow)Enum.Parse(typeof(OAuth2Flow), options.Value.OAuth2Mode);
            OAuth2ClientId = options.Value.OAuth2ClientId;
            OAuth2ClientSecret = options.Value.OAuth2ClientSecret;
            OAuth2RefreshToken = options.Value.OAuth2RefreshToken;
        }
    }
}

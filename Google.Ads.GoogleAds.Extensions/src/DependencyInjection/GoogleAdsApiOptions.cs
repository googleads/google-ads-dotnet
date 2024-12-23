namespace Google.Ads.GoogleAds.Extensions.DependencyInjection
{
    /// <summary>
    /// Google Ads API options used when injecting the configuration in a DI container.
    /// </summary>
    public class GoogleAdsApiOptions
    {
        /// <summary>
        /// The GoogleAdsApi prefix for configuration options.
        /// </summary>
        public const string GoogleAdsApi = "GoogleAdsApi";

        /// <summary>
        /// Gets or sets the developer token.
        /// </summary>
        public string DeveloperToken { get; set; }

        /// <summary>
        /// Gets or sets the OAuth2 mode.
        /// </summary>
        public string OAuth2Mode { get; set; }

        /// <summary>
        /// Gets or sets the OAuth2 client ID.
        /// </summary>
        public string OAuth2ClientId { get; set; }

        /// <summary>
        /// Gets or sets the OAuth2 client secret.
        /// </summary>
        public string OAuth2ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the OAuth2 refresh token.
        /// </summary>
        /// <remarks>This setting is applicable only when using OAuth2 web / application
        /// flow in offline mode.</remarks>
        public string OAuth2RefreshToken { get; set; }
    }
}

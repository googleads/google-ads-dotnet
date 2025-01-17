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

        /// <summary>
        /// Gets or sets the OAuth2 PRN email.
        /// </summary>
        public string OAuth2PrnEmail { get; set; }

        /// <summary>
        /// Gets or sets the OAuth2 secrets JSON path.
        /// </summary>
        public string OAuth2SecretsJsonPath { get; set; }

        /// <summary>
        /// Gets or sets the OAuth2 scope.
        /// </summary>
        public string OAuth2Scope { get; set; }

        /// <summary>
        /// Gets or sets the flag that specifies whether to use the Google Cloud Organization of
        /// your Google Cloud project instead of developer token to determine your Google Ads API
        /// access levels.
        /// </summary>
        public bool UseCloudOrgForApiAccess { get; set; }

        /// <summary>
        /// Gets or sets the maximum size in bytes of the message that can be received by the
        /// service client.
        /// </summary>
        public int MaxReceiveMessageSizeInBytes { get; set; }

        /// <summary>
        /// Gets or sets the maximum size in bytes of the metadata that can be received by the
        /// service client.
        /// </summary>
        public int MaxMetadataSizeInBytes { get; set; }
    }
}

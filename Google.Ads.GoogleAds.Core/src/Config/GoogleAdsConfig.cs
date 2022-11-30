// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Ads.Gax.Config;
using Google.Ads.GoogleAds.Lib;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Google.Ads.GoogleAds.Config
{
    /// <summary>
    /// The Google Ads Config interface to allow for DI container configuration.
    /// </summary>
    public interface IGoogleAdsConfig { }

    /// <summary>
    /// This class reads the configuration keys from App.config.
    /// </summary>
    public class GoogleAdsConfig : AdsConfig, IGoogleAdsConfig
    {
        /// <summary>
        /// The Google Ads API server URL.
        /// </summary>
        private const string GOOGLE_ADS_API_SERVER_URL = "https://googleads.googleapis.com";

        /// <summary>
        /// OAuth scope for Google Ads API.
        /// </summary>
        private const string DEFAULT_OAUTH_SCOPE = "https://www.googleapis.com/auth/adwords";

        /// <summary>
        /// The configuration section name in App.config file.
        /// </summary>
        /// <remarks>This is kept as such to provide backwards compatibility with the SOAP client
        /// libraries.</remarks>
        protected const string CONFIG_SECTION_NAME = "GoogleAdsApi";

        /// <summary>
        /// The client customer ID.
        /// </summary>
        /// <remarks>
        /// This setting is only for testing purposes.
        /// </remarks>
        private ConfigSetting<long> clientCustomerId =
            new ConfigSetting<long>("ClientCustomerId", 0);

        /// <summary>
        /// The Google Ads API server URL.
        /// </summary>
        /// <remarks>This setting is used only for testing purposes.</remarks>
        private readonly StringConfigSetting serverUrl = new StringConfigSetting(
            "GoogleAds.Server", GOOGLE_ADS_API_SERVER_URL);

        /// <summary>
        /// The developer token.
        /// </summary>
        private readonly StringConfigSetting developerToken = new StringConfigSetting(
            "DeveloperToken", "");

        /// <summary>
        /// The Login Customer ID.
        /// </summary>
        private readonly StringConfigSetting loginCustomerId = new StringConfigSetting(
            "LoginCustomerId", "");

        /// <summary>
        /// The linked Customer ID.
        /// </summary>
        private readonly StringConfigSetting linkedCustomerId = new StringConfigSetting(
            "LinkedCustomerId", "");

        /// <summary>
        /// Gets or sets the Google Ads API server URL.
        /// </summary>
        /// <remarks>This setting is used only for testing purposes.</remarks>
        public string ServerUrl
        {
            get => serverUrl.Value;
            set => SetPropertyAndNotify(serverUrl, value);
        }

        /// <summary>
        /// Gets or sets the developer token.
        /// </summary>
        public string DeveloperToken
        {
            get => developerToken.Value;
            set => SetPropertyAndNotify(developerToken, value);
        }

        /// <summary>
        /// Gets or sets the login customer id.
        /// </summary>
        /// <remarks>
        /// Required for manager accounts only. When authenticating as a Google Ads
        /// manager account, specifies the customer ID of the authenticating manager account.
        /// If your OAuth credentials are for a user with access to multiple manager accounts you
        /// must create a separate GoogleAdsClient instance for each manager account.
        /// </remarks>
        public string LoginCustomerId
        {
            get => loginCustomerId.Value;
            set => SetPropertyAndNotify(loginCustomerId, value);
        }

        /// <summary>
        /// Gets or sets the linked customer ID.
        /// </summary>
        /// <remarks>
        /// This header is only required for methods that update the resources of an entity when
        /// permissioned via Linked Accounts in the Google Ads UI(AccountLink resource in the
        /// Google Ads API). Set this value to the customer ID of the data provider that updates the
        /// resources of the specified customer ID. It should be set without dashes, for example:
        /// 1234567890 instead of 123-456-7890. Read https://support.google.com/google-ads/answer/7365001
        /// to learn more about Linked Accounts.
        /// </remarks>
        public string LinkedCustomerId
        {
            get => linkedCustomerId.Value;
            set => SetPropertyAndNotify(linkedCustomerId, value);
        }

        /// <summary>
        /// Gets or sets the client customerId.
        /// </summary>
        /// <remarks>This setting is only for testing purposes.</remarks>
        internal long ClientCustomerId
        {
            get => clientCustomerId.Value;
            set => SetPropertyAndNotify(clientCustomerId, value);
        }

        /// <summary>
        /// Public constructor. Loads the configuration from the <code>GoogleAdsApi</code> section
        /// of the App.config / Web.config.
        /// </summary>
        public GoogleAdsConfig() : base()
        {
            InitBeforeReadSettings();

            if (!LoadFromAppConfigSection(CONFIG_SECTION_NAME))
            {
                TryLoadFromEnvironmentFilePath(EnvironmentVariableNames.CONFIG_FILE_PATH,
                    CONFIG_SECTION_NAME);
            }
        }

        /// <summary>
        /// Public constructor. Loads the configuration from an <see cref="IConfigurationRoot"/>.
        /// </summary>
        /// <param name="configurationRoot">The configuration root.</param>
        public GoogleAdsConfig(IConfigurationRoot configurationRoot) : base(configurationRoot) { }

        /// <summary>
        /// Public constructor. Loads the configuration from a <see cref="IConfigurationSection"/>.
        /// </summary>
        /// <param name="configurationSection">The configuration section.</param>
        public GoogleAdsConfig(IConfigurationSection configurationSection)
            : base(configurationSection) { }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAdsConfig"/> class.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public GoogleAdsConfig(Dictionary<string, string> settings) : base(settings) { }

        /// <summary>
        /// Read all settings from App.config.
        /// </summary>
        /// <param name="settings">The parsed App.config settings.</param>
        protected override void ReadSettings(Dictionary<string, string> settings)
        {
            InitBeforeReadSettings();

            base.ReadSettings(settings);
            ReadSetting(settings, serverUrl);
            ReadSetting(settings, developerToken);
            ReadSetting(settings, loginCustomerId);
            ReadSetting(settings, linkedCustomerId);
            ReadSetting(settings, clientCustomerId);
        }

        /// <summary>
        /// Initializes various fields related to settings before reading settings.
        /// </summary>
        /// <remarks>Any configuration setting that is not initialized as part of the declaration
        /// should be initialized here instead of constructors, since ReadSettings() method will
        /// be called by the base() constructors before your constructor code executes.
        /// </remarks>
        private void InitBeforeReadSettings()
        {
            oAuth2Scope = new StringConfigSetting("OAuth2Scope", DEFAULT_OAUTH_SCOPE);

            ENV_VAR_TO_CONFIG_KEY_MAP = new ReadOnlyDictionary<string, string>(
                new Dictionary<string, string>() {
                { EnvironmentVariableNames.OAUTH2_MODE, oAuth2Mode.Name},
                { EnvironmentVariableNames.OAUTH2_CLIENT_ID, oAuth2ClientId.Name},
                { EnvironmentVariableNames.OAUTH2_CLIENT_SECRET, oAuth2ClientSecret.Name},
                { EnvironmentVariableNames.OAUTH2_REFRESH_TOKEN, oAuth2RefreshToken.Name},
                { EnvironmentVariableNames.OAUTH2_JSON_KEY_FILE_PATH, oAuth2SecretsJsonPath.Name},
                { EnvironmentVariableNames.OAUTH2_IMPERSONATED_EMAIL, oAuth2PrnEmail.Name},
                { EnvironmentVariableNames.DEVELOPER_TOKEN, developerToken.Name},
                { EnvironmentVariableNames.LOGIN_CUSTOMER_ID, loginCustomerId.Name},
                { EnvironmentVariableNames.LINKED_CUSTOMER_ID, linkedCustomerId.Name},
                { EnvironmentVariableNames.ENDPOINT, serverUrl.Name},
            });
        }
    }
}
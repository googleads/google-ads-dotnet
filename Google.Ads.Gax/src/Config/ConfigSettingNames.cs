// Copyright 2023 Google LLC
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

namespace Google.Ads.Gax.Config
{
    /// <summary>
    /// A class to list all the configuration setting names used by the library.
    /// </summary>
    public class ConfigSettingNames
    {
        /// <summary>
        /// The configuration setting name for OAuth2 mode.
        /// </summary>
        public const string OAUTH2_MODE = "OAuth2Mode";

        /// <summary>
        /// The configuration setting name for OAuth2 clientId.
        /// </summary>
        public const string OAUTH2_CLIENT_ID = "OAuth2ClientId";

        /// <summary>
        /// The configuration setting name for OAuth2 clientSecret.
        /// </summary>
        public const string OAUTH2_CLIENT_SECRET = "OAuth2ClientSecret";

        /// <summary>
        /// The configuration setting name for OAuth2 refresh token.
        /// </summary>
        public const string OAUTH2_REFRESH_TOKEN = "OAuth2RefreshToken";

        /// <summary>
        /// The configuration setting name for OAuth2 JSON key file path.
        /// </summary>
        public const string OAUTH2_JSON_KEY_FILE_PATH = "OAuth2SecretsJsonPath";

        /// <summary>
        /// The configuration setting name for OAuth2 impersonated email.
        /// </summary>
        public const string OAUTH2_IMPERSONATED_EMAIL = "OAuth2PrnEmail";

        /// <summary>
        /// The configuration setting name for the developer token.
        /// </summary>
        public const string DEVELOPER_TOKEN = "DeveloperToken";

        /// <summary>
        /// The configuration setting name for the login customer id.
        /// </summary>
        public const string LOGIN_CUSTOMER_ID = "LoginCustomerId";

        /// <summary>
        /// The configuration setting name for the linked customer id.
        /// </summary>
        public const string LINKED_CUSTOMER_ID = "LinkedCustomerId";
    }
}
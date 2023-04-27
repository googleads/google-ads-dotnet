// Copyright 2020 Google LLC
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

namespace Google.Ads.GoogleAds.Extensions.Config
{
    /// <summary>
    /// A class to list all the environment variable names used by the library.
    /// </summary>
    public class EnvironmentVariableNames
    {
        /// <summary>
        /// The prefix for all the environment variables.
        /// </summary>
        private const string PREFIX = "GOOGLE_ADS_";

        /// <summary>
        /// The environment variable for the file path for the configuration file. This
        /// should point to a settings.json as explained on
        /// https://developers.google.com/google-ads/api/docs/client-libs/dotnet/configuration#configuring_using_a_custom_json_file
        /// </summary>
        public const string CONFIG_FILE_PATH = PREFIX + "CONFIGURATION_FILE_PATH";

        /// <summary>
        /// The environment variable for OAuth2 mode.
        /// </summary>
        internal const string OAUTH2_MODE = PREFIX + "OAUTH2_MODE";

        /// <summary>
        /// The environment variable for OAuth2 client ID.
        /// </summary>
        internal const string OAUTH2_CLIENT_ID = PREFIX + "CLIENT_ID";

        /// <summary>
        /// The environment variable for OAuth2 client secret.
        /// </summary>
        internal const string OAUTH2_CLIENT_SECRET = PREFIX + "CLIENT_SECRET";

        /// <summary>
        /// The environment variable for OAuth2 refresh token.
        /// </summary>
        internal const string OAUTH2_REFRESH_TOKEN = PREFIX + "REFRESH_TOKEN";

        /// <summary>
        /// The environment variable for OAuth2 JSON key file path.
        /// </summary>
        internal const string OAUTH2_JSON_KEY_FILE_PATH = PREFIX + "JSON_KEY_FILE_PATH";

        /// <summary>
        /// The environment variable for OAuth2 JSON key file path.
        /// </summary>
        internal const string OAUTH2_IMPERSONATED_EMAIL = PREFIX + "IMPERSONATED_EMAIL";

        /// <summary>
        /// The environment variable for developer token.
        /// </summary>
        internal const string DEVELOPER_TOKEN = PREFIX + "DEVELOPER_TOKEN";

        /// <summary>
        /// The environment variable for login customer ID..
        /// </summary>
        internal const string LOGIN_CUSTOMER_ID = PREFIX + "LOGIN_CUSTOMER_ID";

        /// <summary>
        /// The environment variable for linked customer ID.
        /// </summary>
        internal const string LINKED_CUSTOMER_ID = PREFIX + "LINKED_CUSTOMER_ID";

        /// <summary>
        /// The environment variable for the API endpoint.
        /// </summary>
        internal const string ENDPOINT = PREFIX + "ENDPOINT";


    }
}

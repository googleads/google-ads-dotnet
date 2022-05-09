// Copyright 2019 Google LLC
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

using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Lib;
using System.IO;

using gacu = global::Google.Api.Ads.Common.Util;
using gagu = global::Google.Ads.GoogleAds.Util;

namespace Google.Ads.GoogleAds.Examples
{
    /// <summary>
    /// The Main class for this application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main method.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            // Common configuration keys. The same set of credentials work for both AdWords API
            // and Google Ads API.
            string developerToken = "INSERT_YOUR_DEVELOPER_TOKEN_HERE";
            long clientCustomerId = long.Parse("INSERT_YOUR_CLIENT_CUSTOMER_ID_HERE");
            string oAuth2clientId = "INSERT_OAUTH2_CLIENT_ID_HERE";
            string oAuth2Secret = "INSERT_OAUTH2_CLIENT_SECRET_HERE";
            string oAuth2RefreshToken = "INSERT_OAUTH2_REFRESH_TOKEN_HERE";

            // Login Customer ID is a new configuration setting required in Google Ads API. This
            // is the customer ID of the authorized customer to use in the request, without
            // hyphens(-). If your access to the customer account is through a manager account,
            // this header is required and must be set to the customer ID of the manager account.
            // See https://developers.google.com/google-ads/api/docs/concepts/call-structure#cid
            // to learn more about this setting.
            long loginCustomerId = long.Parse("INSERT_LOGIN_CUSTOMER_ID_HERE");

            // Initialize logging. Since this code example uses the same log file for both APIs,
            // you need to initialize the log stream once and reuse it for both libraries.
            StreamWriter writer = new StreamWriter("C:\\logs\\details.log");
            gacu::TraceUtilities.Configure(gacu::TraceUtilities.DETAILED_REQUEST_LOGS_SOURCE,
                writer, System.Diagnostics.SourceLevels.All);

            gagu::TraceUtilities.Configure(gagu::TraceUtilities.DETAILED_REQUEST_LOGS_SOURCE,
                writer, System.Diagnostics.SourceLevels.All);

            // Create AdWordsAppConfig and AdWordsUser instances, to be used for AdWords API calls.
            AdWordsAppConfig adWordsAppConfig = new AdWordsAppConfig()
            {
                DeveloperToken = developerToken,
                ClientCustomerId = clientCustomerId.ToString(),
                OAuth2ClientId = oAuth2clientId,
                OAuth2ClientSecret = oAuth2Secret,
                OAuth2RefreshToken = oAuth2RefreshToken
            };

            AdWordsUser adWordsUser = new AdWordsUser(adWordsAppConfig);

            // Create GoogleAdsConfig and GoogleAdsClient instances, to be used for AdWords API
            // calls.
            GoogleAdsConfig googleAdsConfig = new GoogleAdsConfig()
            {
                DeveloperToken = developerToken,
                LoginCustomerId = loginCustomerId.ToString(),
                OAuth2ClientId = oAuth2clientId,
                OAuth2ClientSecret = oAuth2Secret,
                OAuth2RefreshToken = oAuth2RefreshToken,
            };

            GoogleAdsClient googleAdsClient = new GoogleAdsClient(googleAdsConfig);

            // Uncomment the relevant code example to run it.

            // CampaignManagement example.
            // new CreateCompleteCampaignAdWordsApiOnly().Run(adWordsUser);
            // new CreateCompleteCampaignBothApisPhase1().Run(adWordsUser, googleAdsClient);
            // new CreateCompleteCampaignBothApisPhase2().Run(adWordsUser, googleAdsClient);
            // new CreateCompleteCampaignBothApisPhase3().Run(adWordsUser, googleAdsClient);
            // new CreateCompleteCampaignBothApisPhase4().Run(adWordsUser, googleAdsClient);
            // new CreateCompleteCampaignGoogleAdsApiOnly().Run(googleAdsClient, clientCustomerId);

            // CampaignReportToCsv example.
            // To write the report file to the home directory:
            // new CampaignReportToCsv().Run(googleAdsClient, clientCustomerId);
            // Alternatively, specify the output file path using an optional string argument:
            // new CampaignReportToCsv().Run(googleAdsClient, clientCustomerId, "/PATH/TO/output.csv");
        }
    }
}

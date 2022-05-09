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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Ads.GoogleAds.Examples
{
    /// <summary>
    /// Entry point for the application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The Google Ads API scope.
        /// </summary>
        private const string GOOGLE_ADS_API_SCOPE = "https://www.googleapis.com/auth/adwords";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static void Main(string[] args)
        {
            Console.WriteLine("This code example creates an OAuth2 refresh token for the " +
                "Google Ads API .NET Client library. This example works with both web and " +
                "desktop app OAuth client ID types. To use this application\n" +
                  "1) Follow the instructions on " +
                  "https://developers.google.com/google-ads/api/docs/oauth/cloud-project " +
                  "to generate a new client ID and secret.\n" +
                  "2) Run this application.\n" +
                  "3) Enter the client ID and client secret when prompted and follow the instructions.\n" +
                  "4) Once the output is generated, copy its contents into your App.config " +
                  "file. See https://developers.google.com/google-ads/api/docs/client-libs/dotnet/configuration " +
                  "for other configuration options.\n\n");

            Console.WriteLine("IMPORTANT: For web app clients types, you must add " +
                "'http://127.0.0.1/authorize' to the 'Authorized redirect URIs' list in your " +
                "Google Cloud Console project before running this example to avoid getting a " +
                "redirect_uri_mismatch error. Desktop app client types do not require the " +
                "local redirect to be explicitly configured in the console.\n\n");

            // Accept the client ID from user.
            Console.Write("Enter the client ID: ");
            string clientId = Console.ReadLine();

            // Accept the client ID from user.
            Console.Write("Enter the client secret: ");
            string clientSecret = Console.ReadLine();

            // Load the JSON secrets.
            ClientSecrets secrets = new ClientSecrets()
            {
                ClientId = clientId,
                ClientSecret = clientSecret
            };

            try
            {
                // Authorize the user using desktop flow. GoogleWebAuthorizationBroker creates a
                // web server that listens to a random port at 127.0.0.1 and the /authorize url
                // as loopback url. See https://github.com/googleapis/google-api-dotnet-client/blob/main/Src/Support/Google.Apis.Auth/OAuth2/LocalServerCodeReceiver.cs
                // for details.
                Task<UserCredential> task = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    secrets,
                    new string[] { GOOGLE_ADS_API_SCOPE },
                    string.Empty,
                    CancellationToken.None,
                    new NullDataStore()
                );
                UserCredential credential = task.Result;

                Console.WriteLine("\nCopy the following content into your App.config file.\n\n" +
                    $"<add key = 'OAuth2Mode' value = 'APPLICATION' />\n" +
                    $"<add key = 'OAuth2ClientId' value = '{clientId}' />\n" +
                    $"<add key = 'OAuth2ClientSecret' value = '{clientSecret}' />\n" +
                    $"<add key = 'OAuth2RefreshToken' value = " +
                    $"'{credential.Token.RefreshToken}' />\n");

                Console.WriteLine("/n" +
                    "<!-- Required for manager accounts only: Specify the login customer -->\n" +
                    "<!-- ID used to authenticate API calls. This will be the customer ID -->\n" +
                    "<!-- of the authenticated manager account. It should be set without -->\n" +
                    "<!-- dashes, for example: 1234567890 instead of 123-456-7890. You can -->\n" +
                    "<!-- also specify this later in code if your application uses -->\n" +
                    "<!-- multiple manager account OAuth pairs. -->\n" +
                    "<add key = 'LoginCustomerId' value = INSERT_LOGIN_CUSTOMER_ID_HERE />/n/n");


                Console.WriteLine("See https://developers.google.com/google-ads/api/docs/client-libs/dotnet/configuration " +
                    "for alternate configuration options.");
                Console.WriteLine("Press <Enter> to continue...");
                Console.ReadLine();
            }
            catch (AggregateException)
            {
                Console.WriteLine("An error occured while authorizing the user.");
            }
        }
    }
}

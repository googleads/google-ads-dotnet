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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V3.Errors;
using Google.Ads.GoogleAds.V3.Common;
using Google.Ads.GoogleAds.V3.Resources;
using Google.Ads.GoogleAds.V3.Services;

using System;

using static Google.Ads.GoogleAds.V3.Enums.KeywordMatchTypeEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.ProximityRadiusUnitsEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V3
{
    /// <summary>
    /// This code example illustrates how to search for language constants by name that
    /// includes the specified keyword. Then it searches for all the available mobile carrier
    /// constants with a given country code.
    /// </summary>
    public class SearchForTargetableLanguagesAndCarriers : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            SearchForTargetableLanguagesAndCarriers codeExample =
                new SearchForTargetableLanguagesAndCarriers();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The keyword to search for.
            string searchKeyword = "INSERT_SEARCH_KEYWORD_HERE";

            // The country code for which the search is performed.
            // A list of country codes can be referenced here:
            // https://developers.google.com/adwords/api/docs/appendix/geotargeting.
            string carrierCountryCode = "US";

            codeExample.Run(new GoogleAdsClient(), customerId, searchKeyword, carrierCountryCode);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example illustrates how to search for language constants by " +
                    "name that includes the specified keyword. Then it searches for all the " +
                    "available mobile carrier constants with a given country code.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="searchKeyword">The keyword to search for language code.</param>
        /// <param name="carrierCountryCode">The country code to search for carrier code.</param>
        public void Run(GoogleAdsClient client, long customerId, string searchKeyword,
            string carrierCountryCode)
        {
            try
            {
                SearchTargetableLanguages(client, customerId, searchKeyword);
                SearchTargetableCarriers(client, customerId, carrierCountryCode);
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        /// <summary>
        /// Searches the targetable carriers by country code.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="countryCode">The country code.</param>
        private void SearchTargetableCarriers(GoogleAdsClient client, long customerId,
            string countryCode)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V3.GoogleAdsService);

            // Create a query that retrieves the language constants by the keyword included
            // in the name.
            string query = $"SELECT carrier_constant.id, carrier_constant.name, " +
                $"carrier_constant.country_code FROM carrier_constant " +
                $"WHERE carrier_constant.country_code = '{countryCode}'";

            // Issue a search request.
            googleAdsService.SearchStream(customerId.ToString(), query,
                delegate (SearchGoogleAdsStreamResponse resp)
                {
                    // Display the results.
                    foreach (GoogleAdsRow criterionRow in resp.Results)
                    {
                        CarrierConstant carrier = criterionRow.CarrierConstant;
                        Console.WriteLine($"Carrier with ID {carrier.Id}, name '{carrier.Name}' " +
                            $"and country code '{carrier.CountryCode}' was found.");
                    }
                });

        }

        /// <summary>
        /// Search for targetable languages by keyword.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="searchKeyword">The keyword to search for.</param>
        private void SearchTargetableLanguages(GoogleAdsClient client, long customerId,
            string searchKeyword)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V3.GoogleAdsService);

            // Create a query that retrieves the language constants by the keyword included
            // in the name.
            string query = $"SELECT language_constant.id, language_constant.code, " +
                $"language_constant.name, language_constant.targetable " +
                $"FROM language_constant " +
                $"WHERE language_constant.name LIKE '%{searchKeyword}%'";

            // Issue a search request.
            googleAdsService.SearchStream(customerId.ToString(), query,
                delegate (SearchGoogleAdsStreamResponse resp)
                {
                    foreach (GoogleAdsRow criterionRow in resp.Results)
                    {
                        LanguageConstant language = criterionRow.LanguageConstant;
                            // Display the results.
                            Console.WriteLine($"Language with ID {language.Id}, code " +
                            $"'{language.Code}', name '{language.Name}'and targetable:" +
                            $" '{language.Targetable}' was found.");
                    }
                });

        }
    }
}

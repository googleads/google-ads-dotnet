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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V0.Services;
using Google.Api.Gax;
using System;

namespace Google.Ads.GoogleAds.Examples.V0
{
    /// <summary>
    /// This code example gets all campaigns. To add campaigns, run AddCampaigns.cs.
    /// </summary>
    public class GetCampaigns : ExampleBase
    {
        /// <summary>
        /// The page size to be used by default.
        /// </summary>
        private const int PAGE_SIZE = 1_000;

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            GetCampaigns codeExample = new GetCampaigns();

            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example gets all campaigns. To add campaigns, run AddCampaigns.cs.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V0.GoogleAdsService);

            // Create a request that will retrieve all campaigns using pages of the specified page size.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                PageSize = PAGE_SIZE,
                Query = "SELECT campaign.id, campaign.network_settings.target_content_network " +
                    "FROM campaign ORDER BY campaign.id",
                CustomerId = customerId.ToString()
            };

            try
            {
                // Issue the search request.
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchPagedResponse =
                    googleAdsService.Search(request);

                foreach (SearchGoogleAdsResponse response in searchPagedResponse.AsRawResponses())
                {
                    Console.WriteLine(response.FieldMask.Paths);
                    foreach (GoogleAdsRow googleAdsRow in response.Results)
                    {
                        Console.WriteLine("Campaign with ID {0} and name '{1}' was found.",
                            googleAdsRow.Campaign.Id, googleAdsRow.Campaign.Name);
                    }
                }
                // Iterate over all rows in all pages and prints the requested field values for the
                // campaign in each row.
                foreach (GoogleAdsRow googleAdsRow in searchPagedResponse)
                {
                    Console.WriteLine("Campaign with ID {0} and name '{1}' was found.",
                        googleAdsRow.Campaign.Id, googleAdsRow.Campaign.Name);
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
            }
        }
    }
}

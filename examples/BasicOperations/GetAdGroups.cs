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
using Google.Ads.GoogleAds.V3.Resources;
using Google.Ads.GoogleAds.V3.Services;
using Google.Api.Gax;

using System;

namespace Google.Ads.GoogleAds.Examples.V3
{
    /// <summary>
    /// This example gets ad groups.
    /// </summary>
    public class GetAdGroups : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            UpdateCampaign codeExample = new UpdateCampaign();

            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // Specify a campaign ID to restrict search to only a given campaign.
            long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, campaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This example gets ad groups.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">If specified, the search result is restricted only to this
        /// campaign ID.</param>
        public void Run(GoogleAdsClient client, long customerId, long? campaignId)
        {
            // Get the AdGroupService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V3.GoogleAdsService);

            // Create the search query.
            string searchQuery = "SELECT campaign.id, ad_group.id, ad_group.name FROM ad_group";
            if (campaignId != null)
            {
                searchQuery += $" WHERE campaign.id = {campaignId}";
            }

            try
            {
                // Retrieve the campaigns.
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchPagedResponse =
                    googleAdsService.Search(customerId.ToString(), searchQuery);

                // Display the results.
                foreach (GoogleAdsRow googleAdsRow in searchPagedResponse)
                {
                    AdGroup adGroup = googleAdsRow.AdGroup;
                    if (adGroup != null)
                    {
                        Console.WriteLine("Ad group with ID {0} and name '{1}' was found in " +
                            "campaign with ID: {2}.", adGroup.Id, adGroup.Name,
                            googleAdsRow.Campaign.Id);
                    }
                    else
                    {
                        Console.WriteLine("No ad group found for row.");
                    }
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

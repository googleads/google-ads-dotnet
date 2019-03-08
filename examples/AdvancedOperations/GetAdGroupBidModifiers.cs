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
using Google.Ads.GoogleAds.V1.Errors;
using Google.Ads.GoogleAds.V1.Resources;
using Google.Ads.GoogleAds.V1.Services;
using Google.Api.Gax;
using System;

namespace Google.Ads.GoogleAds.Examples.V1
{
    /// <summary>
    /// This code example gets ad group bid modifiers.
    /// </summary>
    public class GetAdGroupBidModifiers : ExampleBase
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
            GetAdGroupBidModifiers codeExample = new GetAdGroupBidModifiers();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The ad group ID for which ad group bid modiifers will be retrieved.
            long adGroupId = long.Parse("INSERT_ADGROUP_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, adGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example gets ad group bid modifiers.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ad group ID for which ad group bid modiifers will
        /// be retrieved.</param>
        public void Run(GoogleAdsClient client, long customerId, long? adGroupId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V1.GoogleAdsService);

            string searchQuery =
              "SELECT ad_group.id, ad_group_bid_modifier.criterion_id, "
                  + "ad_group_bid_modifier.bid_modifier, ad_group_bid_modifier.device.type, "
                  + "campaign.id FROM ad_group_bid_modifier";

            if (adGroupId != null)
            {
                searchQuery += $" WHERE ad_group.id = {adGroupId}";
            }

            // Creates a request that will retrieve ad group bid modifiers using pages of the
            // specified page size.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                Query = searchQuery,
                PageSize = PAGE_SIZE
            };
            try
            {
                // Issue the search request.
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchPagedResponse =
                    googleAdsService.Search(request);

                // Iterates over all rows in all pages and prints the requested field values for
                // the ad group bid modifiers in each row.
                foreach (GoogleAdsRow googleAdsRow in searchPagedResponse)
                {
                    AdGroupBidModifier adGroupBidModifier = googleAdsRow.AdGroupBidModifier;
                    AdGroup adGroup = googleAdsRow.AdGroup;
                    Campaign campaign = googleAdsRow.Campaign;
                    Console.WriteLine("Ad group bid modifier with criterion ID {0}, bid " +
                        "modifier value {1:0.00}, device type {2} was found in an ad group " +
                        "with ID {3} of campaign ID {4}.",
                        adGroupBidModifier.CriterionId,
                        adGroupBidModifier.BidModifier,
                        adGroupBidModifier.Device.Type,
                        adGroup.Id, campaign.Id);
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

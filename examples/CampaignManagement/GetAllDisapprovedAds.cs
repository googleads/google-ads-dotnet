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
using Google.Ads.GoogleAds.V1.Common;
using Google.Ads.GoogleAds.V1.Resources;
using Google.Ads.GoogleAds.V1.Services;
using Google.Api.Gax;
using System;
using static Google.Ads.GoogleAds.V1.Enums.PolicyApprovalStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V1
{
    /// <summary>
    /// This code example retrieves all the disapproved ads in a given campaign.
    /// </summary>
    public class GetAllDisapprovedAds : ExampleBase
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
            GetAllDisapprovedAds codeExample = new GetAllDisapprovedAds();
            Console.WriteLine(codeExample.Description);
            try
            {
                long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

                // The Google Ads customer ID for which the call is made.
                long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                codeExample.Run(new GoogleAdsClient(), customerId, campaignId);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occurred while running this code example. {0}",
                    ExampleUtilities.FormatException(e));
            }
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example retrieves all the disapproved ads in a given campaign.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="campaignId">Id of the campaign for which disapproved ads
        /// are retrieved.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V1.GoogleAdsService);

            String searchQuery =
                $@"SELECT
                    ad_group_ad.ad.id,
                    ad_group_ad.ad.type,
                    ad_group_ad.policy_summary
                FROM ad_group_ad
                WHERE
                    campaign.id = {campaignId}";

            // Create a request that will retrieve all Disapproved Ads
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                PageSize = PAGE_SIZE,
                Query = searchQuery,
                CustomerId = customerId.ToString()
            };

            int disapprovedAdsCount = 0;

            try
            {
                // Issue the search request.
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchPagedResponse =
                    googleAdsService.Search(request);

                // Iterate over all rows in all rows returned and count disapproved Ads
                foreach (GoogleAdsRow googleAdsRow in searchPagedResponse)
                {
                    AdGroupAdPolicySummary policySummary = googleAdsRow.AdGroupAd.PolicySummary;
                    AdGroupAd adGroupAd = googleAdsRow.AdGroupAd;
                    Ad ad = adGroupAd.Ad;

                    if (adGroupAd.PolicySummary.ApprovalStatus != PolicyApprovalStatus.Disapproved)
                    {
                        continue;
                    }

                    disapprovedAdsCount++;

                    Console.WriteLine(
                        "Ad with ID {0} and type '{1}' was disapproved with the " +
                        "following policy topic entries: ",
                        ad.Id, ad.Type);

                    // Display the policy topic entries related to the ad disapproval.
                    foreach (PolicyTopicEntry policyTopicEntry in policySummary.PolicyTopicEntries)
                    {
                        Console.WriteLine("  topic: {0}, type: '{1}'",
                            policyTopicEntry.Topic,
                            policyTopicEntry.Type);

                        // Display the attributes and values that triggered the policy topic.
                        if (policyTopicEntry.Evidences != null)
                        {
                            foreach (PolicyTopicEvidence evidence in policyTopicEntry.Evidences)
                            {
                                if (evidence.TextList != null)
                                {
                                    for (int i = 0; i < evidence.TextList.Texts.Count; i++)
                                    {
                                        Console.WriteLine("    evidence text[{0}]: {1}", i,
                                            evidence.TextList.Texts[i]);
                                    }
                                }
                            }
                        }
                    }
                }

                Console.WriteLine("Number of disapproved ads found: {0}", disapprovedAdsCount);
            }
            catch (Exception e)
            {
                throw new System.ApplicationException("Failed to get disapproved ads.", e);
            }
        }
    }
}

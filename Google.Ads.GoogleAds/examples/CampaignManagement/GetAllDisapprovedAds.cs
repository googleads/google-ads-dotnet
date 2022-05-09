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

using CommandLine;
using Google.Ads.Gax.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V10.Common;
using Google.Ads.GoogleAds.V10.Errors;
using Google.Ads.GoogleAds.V10.Resources;
using Google.Ads.GoogleAds.V10.Services;
using Google.Api.Gax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Ads.GoogleAds.Examples.V10
{
    /// <summary>
    /// This code example retrieves all the disapproved ads in a given campaign.
    /// </summary>
    public class GetAllDisapprovedAds : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetAllDisapprovedAds"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The customer ID for which the call is made.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// Id of the campaign for which disapproved ads are retrieved.
            /// </summary>
            [Option("campaignId", Required = true, HelpText =
                "Id of the campaign for which disapproved ads are retrieved.")]
            public long CampaignId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = new Options();
            CommandLine.Parser.Default.ParseArguments<Options>(args).MapResult(
                delegate (Options o)
                {
                    options = o;
                    return 0;
                }, delegate (IEnumerable<Error> errors)
                {
                    // The customer ID for which the call is made.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // Id of the campaign for which disapproved ads are retrieved.
                    options.CampaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

                    return 0;
                });

            GetAllDisapprovedAds codeExample = new GetAllDisapprovedAds();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.CampaignId);
        }

        /// <summary>
        /// The page size to be used by default.
        /// </summary>
        private const int PAGE_SIZE = 1_000;

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example retrieves all the disapproved ads in a given campaign.";

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
                Services.V10.GoogleAdsService);

            string searchQuery = $@"
                SELECT
                    ad_group_ad.ad.id,
                    ad_group_ad.ad.type,
                    ad_group_ad.policy_summary.approval_status,
                    ad_group_ad.policy_summary.policy_topic_entries
                FROM ad_group_ad
                WHERE
                    campaign.id = {campaignId}
                    AND ad_group_ad.policy_summary.approval_status = DISAPPROVED";

            // Create a request that will retrieve all Disapproved Ads
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                PageSize = PAGE_SIZE,
                Query = searchQuery,
                CustomerId = customerId.ToString(),
                ReturnTotalResultsCount = true
            };

            try
            {
                // Issue the search request.
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchPagedResponse =
                    googleAdsService.Search(request);

                long disapprovedAdsCount = searchPagedResponse.AsRawResponses()
                    .First().TotalResultsCount;

                // Iterate over all rows in all rows returned and count disapproved Ads
                foreach (GoogleAdsRow googleAdsRow in searchPagedResponse)
                {
                    AdGroupAdPolicySummary policySummary = googleAdsRow.AdGroupAd.PolicySummary;
                    AdGroupAd adGroupAd = googleAdsRow.AdGroupAd;
                    Ad ad = adGroupAd.Ad;
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
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }
    }
}

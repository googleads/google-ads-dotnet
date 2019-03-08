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

using static Google.Ads.GoogleAds.V1.Resources.CampaignCriterion;

namespace Google.Ads.GoogleAds.Examples.V1
{
    /// <summary>
    /// This code example illustrates getting campaign targeting criteria.
    /// </summary>
    public class GetCampaignTargetingCriteria : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            GetCampaignTargetingCriteria codeExample = new GetCampaignTargetingCriteria();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the campaign to from which targeting criteria are retrieved.
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
                return "This code example illustrates getting campaign targeting criteria.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to from which targeting criteria are
        /// retrieved.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V1.GoogleAdsService);

            // Create the query.
            string query = $@"SELECT campaign.id, campaign_criterion.campaign,
                campaign_criterion.criterion_id, campaign_criterion.negative,
                campaign_criterion.keyword.text, campaign_criterion.keyword.match_type
                FROM campaign_criterion WHERE campaign.id = {campaignId}";
            try
            {
                // Issue a search request.
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> result =
                  googleAdsService.Search(customerId.ToString(), query);

                // Display the results.
                foreach (GoogleAdsRow criterionRow in result)
                {
                    CampaignCriterion criterion = criterionRow.CampaignCriterion;
                    Console.Write($"Campaign criterion with id = '{criterion.CriterionId}' " +
                        "was retrieved:");
                    if (criterion.Negative.Value)
                    {
                        Console.Write("Negative ");
                    }
                    switch (criterion.CriterionCase)
                    {
                        case CriterionOneofCase.Keyword:
                            Console.Write($"Keyword with text '{criterion.Keyword.Text}' ");
                            Console.WriteLine($"and match type {criterion.Keyword.MatchType}.");
                            break;

                        default:
                            Console.WriteLine("Not a Keyword!");
                            break;
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

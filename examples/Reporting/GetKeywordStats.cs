// Copyright 2018 Google LLC.
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
using Google.Ads.GoogleAds.V1.Services;
using Google.Api.Gax;

using System;

namespace Google.Ads.GoogleAds.Examples.V1
{
    /// <summary>
    /// This code example illustrates getting campaign targeting criteria.
    /// </summary>
    public class GetKeywordStats : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            GetKeywordStats codeExample = new GetKeywordStats();
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
                return "This code example illustrates getting keyword stats.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer Id.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V1.GoogleAdsService);

            // Create the query.
            string query =
                $@"SELECT
                 campaign.id,
                 campaign.name,
                 ad_group.id,
                 ad_group.name,
                 ad_group_criterion.criterion_id,
                 ad_group_criterion.keyword.text,
                 ad_group_criterion.keyword.match_type,
                 metrics.impressions,
                 metrics.clicks,
                 metrics.cost_micros,
                 metrics.video_quartile_25_rate
             FROM keyword_view
             WHERE segments.date DURING LAST_7_DAYS
                 AND campaign.advertising_channel_type = 'SEARCH'
                 AND ad_group.status = 'ENABLED'
                 AND ad_group_criterion.status IN ('ENABLED','PAUSED')
             ORDER BY metrics.impressions DESC
             LIMIT 50";
            try
            {
                // Issue a search request.
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> result =
                    googleAdsService.Search(customerId.ToString(), query);

                // Display the results.
                foreach (GoogleAdsRow criterionRow in result)
                {
                    Console.WriteLine(
                        $"Keyword with text '{criterionRow.AdGroupCriterion.Keyword.Text}', " +
                        $" match type '{criterionRow.AdGroupCriterion.Keyword.MatchType}' and " +
                        $"ID {criterionRow.AdGroupCriterion.CriterionId} " +
                        $"in ad group '{criterionRow.AdGroup.Name}' with " +
                        $"ID {criterionRow.AdGroup.Id} " +
                        $"in campaign '{criterionRow.Campaign.Name}' " +
                        $"with ID {criterionRow.Campaign.Id} " +
                        $"had {criterionRow.Metrics.Impressions.ToString()} impressions, " +
                        $"{criterionRow.Metrics.Clicks} clicks, and " +
                        $"{criterionRow.Metrics.CostMicros} cost (in micros)" +
                        "during the last 7 days.");
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

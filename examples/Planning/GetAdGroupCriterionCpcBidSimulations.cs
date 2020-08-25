// Copyright 2020 Google LLC.
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

using System;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V4.Common;
using Google.Ads.GoogleAds.V4.Errors;
using Google.Ads.GoogleAds.V4.Resources;
using Google.Ads.GoogleAds.V4.Services;

namespace Google.Ads.GoogleAds.Examples.V4
{
    /// <summary>
    /// This example gets all available ad group criterion CPC bid simulations for a given ad group.
    /// To get ad groups, run GetAdGroups.cs.
    /// </summary>
    public class GetAdGroupCriterionCpcBidSimulations : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            GetAdGroupCriterionCpcBidSimulations codeExample =
                new GetAdGroupCriterionCpcBidSimulations();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The ad group ID for which to get available bid simulations.
            long adGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, adGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example gets all available ad group criterion CPC bid simulations for a given " +
            "ad group. To get ad groups, run GetAdGroups.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ad group ID for which to get ad group criterion CPC bid
        ///     simulations.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V4.GoogleAdsService);

            try
            {
                // Creates a query that retrieves the ad group criterion CPC bid simulations.
                string query = $@"
                    SELECT
                        ad_group_criterion_simulation.ad_group_id,
                        ad_group_criterion_simulation.criterion_id,
                        ad_group_criterion_simulation.start_date,
                        ad_group_criterion_simulation.end_date,
                        ad_group_criterion_simulation.cpc_bid_point_list.points
                    FROM
                        ad_group_criterion_simulation
                    WHERE
                        ad_group_criterion_simulation.type = CPC_BID AND
                        ad_group_criterion_simulation.ad_group_id = {adGroupId}";

                // Issue a search stream request.
                googleAdsService.SearchStream(customerId.ToString(), query,
                    delegate(SearchGoogleAdsStreamResponse response)
                    {
                        // Iterates over all rows in all messages and prints the requested field
                        // values for the ad group criterion CPC bid simulation in each row.
                        foreach (GoogleAdsRow googleAdsRow in response.Results)
                        {
                            AdGroupCriterionSimulation simulation =
                                googleAdsRow.AdGroupCriterionSimulation;

                            Console.WriteLine("Found ad group criterion CPC bid simulation for " +
                                $"ad group ID {simulation.AdGroupId}, " +
                                $"criterion ID {simulation.CriterionId}, " +
                                $"start date {simulation.StartDate}, " +
                                $"end date {simulation.EndDate}");

                            foreach (CpcBidSimulationPoint point in
                                simulation.CpcBidPointList.Points)
                            {
                                Console.WriteLine($"\tbid: {point.CpcBidMicros} => " +
                                    $"clicks: {point.Clicks}, " +
                                    $"cost: {point.CostMicros}, " +
                                    $"impressions: {point.Impressions}, " +
                                    $"biddable conversions: {point.BiddableConversions}, " +
                                    "biddable conversions value: " +
                                    $"{point.BiddableConversionsValue}");
                            }

                            Console.WriteLine();
                        }
                    }
                );
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

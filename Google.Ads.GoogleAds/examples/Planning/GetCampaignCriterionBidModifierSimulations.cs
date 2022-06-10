// Copyright 2020 Google LLC
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
using Google.Ads.GoogleAds.V11.Common;
using Google.Ads.GoogleAds.V11.Errors;
using Google.Ads.GoogleAds.V11.Resources;
using Google.Ads.GoogleAds.V11.Services;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V11
{
    /// <summary>
    /// This example gets all available criterion bid modifier simulations for a given campaign.
    /// To get campaigns, run GetCampaigns.cs.
    /// </summary>
    public class GetCampaignCriterionBidModifierSimulations : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetCampaignCriterionBidModifierSimulations"/>
        /// example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the call is made.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// The campaign ID to get the criterion bid modifier simulations.
            /// </summary>
            [Option("campaignId", Required = true, HelpText =
                "The campaign ID to get the criterion bid modifier simulations.")]
            public long CampaignId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            GetCampaignCriterionBidModifierSimulations codeExample =
                new GetCampaignCriterionBidModifierSimulations();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.CampaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example gets all available criterion bid modifier simulations for a given " +
            "campaign. To get campaigns, run GetCampaigns.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">The campaign ID to get the criterion bid modifier
        ///     simulations.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V11.GoogleAdsService);

            // Creates a query that retrieves the criterion bid modifier simulations.
            string query = $@"
                SELECT
                    campaign_criterion_simulation.criterion_id,
                    campaign_criterion_simulation.start_date,
                    campaign_criterion_simulation.end_date,
                    campaign_criterion_simulation.bid_modifier_point_list.points
                FROM campaign_criterion_simulation
                WHERE campaign_criterion_simulation.type = BID_MODIFIER
                AND campaign_criterion_simulation.campaign_id = {campaignId}";

            try
            {
                // Issue a search request.
                googleAdsService.SearchStream(customerId.ToString(), query,
                    delegate (SearchGoogleAdsStreamResponse response)
                    {
                        // Iterates over all rows in all messages and prints the requested field
                        // values for the campaign criterion bid modifier simulation in each row.
                        foreach (GoogleAdsRow googleAdsRow in response.Results)
                        {
                            CampaignCriterionSimulation simulation =
                                googleAdsRow.CampaignCriterionSimulation;
                            Console.WriteLine($@"Found campaign-level criterion bid modifier
                                simulation for criterion with ID
                                {simulation.CriterionId}, start date
                                {simulation.StartDate}, end date
                                {simulation.EndDate}, and points:");
                            foreach (BidModifierSimulationPoint point in
                                simulation.BidModifierPointList.Points)
                            {
                                Console.WriteLine($"\tbid modifier: {point.BidModifier:F} " +
                                    $"=> clicks: {point.Clicks}, " +
                                    $"cost: {point.CostMicros}, " +
                                    $"impressions: {point.Impressions}, " +
                                    $"parent clicks: {point.ParentClicks}, " +
                                    $"parent cost: {point.ParentCostMicros}, " +
                                    $"parent impressions: {point.ParentImpressions}, " +
                                    $"parent required budget: {point.ParentRequiredBudgetMicros}");
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

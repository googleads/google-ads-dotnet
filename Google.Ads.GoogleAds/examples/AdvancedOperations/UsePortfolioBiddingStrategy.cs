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
using Google.Ads.GoogleAds.V18.Common;
using Google.Ads.GoogleAds.V18.Enums;
using Google.Ads.GoogleAds.V18.Errors;
using Google.Ads.GoogleAds.V18.Resources;
using Google.Ads.GoogleAds.V18.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V18.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V18.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V18.Resources.Campaign.Types;

namespace Google.Ads.GoogleAds.Examples.V18
{
    /// <summary>
    /// This code example adds a portfolio bidding strategy and uses it to construct a campaign.
    /// </summary>
    public class UsePortfolioBiddingStrategy : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UsePortfolioBiddingStrategy"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the call is made.")]
            public long CustomerId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            UsePortfolioBiddingStrategy codeExample = new UsePortfolioBiddingStrategy();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a portfolio bidding strategy and uses it to construct a " +
            "campaign.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            try
            {
                // Create the portfolio bidding strategy.
                string BIDDINGSTRATEGY_NAME = "Maximize Clicks " +
                    ExampleUtilities.GetRandomString();
                const long BID_CEILING = 2000000;

                string portfolioBiddingStrategy = CreatePortfolioBiddingStrategy(
                    client, customerId, BIDDINGSTRATEGY_NAME, BID_CEILING);

                Console.WriteLine("Portfolio bidding strategy with resource name '{0}' " +
                    "was created.", portfolioBiddingStrategy);

                // Create the shared budget.
                string BUDGET_NAME = "Shared Interplanetary Budget #" +
                    ExampleUtilities.GetRandomString();
                const long BUDGET_AMOUNT = 30000000;

                string sharedBudget = CreateSharedBudget(client, customerId, BUDGET_NAME,
                    BUDGET_AMOUNT);

                Console.WriteLine("Shared budget with resource name '{0}' was created.",
                    sharedBudget);

                // Create the campaign.
                string CAMPAIGN_NAME = "Interplanetary Cruise #" +
                    ExampleUtilities.GetRandomString();

                string newCampaign = CreateCampaignWithBiddingStrategy(client, customerId,
                    CAMPAIGN_NAME, portfolioBiddingStrategy, sharedBudget);

                Console.WriteLine("Campaign with resource name '{0}' was created.", newCampaign);
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
        /// Creates the portfolio bidding strategy.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="name">The bidding strategy name.</param>
        /// <param name="bidCeiling">The bid ceiling amount in micros.</param>
        /// <returns>The bidding strategy resource name.</returns>
        // [START use_portfolio_bidding_strategy_1]
        private string CreatePortfolioBiddingStrategy(GoogleAdsClient client,
            long customerId, string name, long bidCeiling)
        {
            // Get the BiddingStrategyService.
            BiddingStrategyServiceClient biddingStrategyService = client.GetService(
                Services.V18.BiddingStrategyService);

            // Create a portfolio bidding strategy.
            BiddingStrategy biddingStrategy = new BiddingStrategy()
            {
                Name = name,

                TargetSpend = new TargetSpend()
                {
                    CpcBidCeilingMicros = bidCeiling,
                }
            };

            // Create operation.
            BiddingStrategyOperation biddingOperation = new BiddingStrategyOperation()
            {
                Create = biddingStrategy
            };

            // Create the portfolio bidding strategy.
            MutateBiddingStrategiesResponse biddingResponse =
                biddingStrategyService.MutateBiddingStrategies(
                    customerId.ToString(), new BiddingStrategyOperation[] { biddingOperation });

            return biddingResponse.Results[0].ResourceName;
        }
        // [END use_portfolio_bidding_strategy_1]

        /// <summary>
        /// Creates a shared campaign budget to be used to create the campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="name">The budget name.</param>
        /// <param name="amount">The budget amount in micros.</param>
        /// <returns>The budget resource name.</returns>
        // [START use_portfolio_bidding_strategy]
        private string CreateSharedBudget(GoogleAdsClient client, long customerId, string name,
            long amount)
        {
            // Get the CampaignBudgetService.
            CampaignBudgetServiceClient campaignBudgetService =
                client.GetService(Services.V18.CampaignBudgetService);

            // Create a shared budget.
            CampaignBudget budget = new CampaignBudget()
            {
                Name = name,
                AmountMicros = amount,
                DeliveryMethod = BudgetDeliveryMethodEnum.Types.BudgetDeliveryMethod.Standard,
                ExplicitlyShared = true
            };

            // Create the operation.
            CampaignBudgetOperation campaignBudgetOperation = new CampaignBudgetOperation()
            {
                Create = budget
            };

            // Make the mutate request.
            MutateCampaignBudgetsResponse retVal = campaignBudgetService.MutateCampaignBudgets(
                customerId.ToString(), new CampaignBudgetOperation[] { campaignBudgetOperation });
            return retVal.Results[0].ResourceName;
        }
        // [END use_portfolio_bidding_strategy]

        /// <summary>
        /// Creates the campaign with a portfolio bidding strategy.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="name">The campaign name.</param>
        /// <param name="biddingStrategyResourceName">The bidding strategy id.</param>
        /// <param name="campaignBudgetResourceName">The campaign budget resource name.</param>
        /// <returns>The campaign resource name.</returns>
        private string CreateCampaignWithBiddingStrategy(GoogleAdsClient client,
            long customerId, string name, string biddingStrategyResourceName,
            string campaignBudgetResourceName)
        {
            // Get the CampaignService.
            CampaignServiceClient campaignService = client.GetService(Services.V18.CampaignService);

            // [START use_portfolio_bidding_strategy_2]
            // Create the campaign.
            Campaign campaign = new Campaign()
            {
                Name = name,
                AdvertisingChannelType = AdvertisingChannelType.Search,

                // Recommendation: Set the campaign to PAUSED when creating it to prevent
                // the ads from immediately serving. Set to ENABLED once you've added
                // targeting and the ads are ready to serve.
                Status = CampaignStatus.Paused,

                // Set the campaign budget.
                CampaignBudget = campaignBudgetResourceName,

                // Set bidding strategy (required).
                BiddingStrategy = biddingStrategyResourceName,

                // Set the campaign network options.
                NetworkSettings = new NetworkSettings()
                {
                    TargetGoogleSearch = true,
                    TargetSearchNetwork = true,
                    TargetContentNetwork = true,
                    TargetPartnerSearchNetwork = false
                }
            };
            // [END use_portfolio_bidding_strategy_2]

            // Create the operation.
            CampaignOperation operation = new CampaignOperation()
            {
                Create = campaign
            };

            // Create the campaign.
            MutateCampaignsResponse retVal = campaignService.MutateCampaigns(
                customerId.ToString(), new CampaignOperation[] { operation });

            return retVal.Results[0].ResourceName;
        }
    }
}

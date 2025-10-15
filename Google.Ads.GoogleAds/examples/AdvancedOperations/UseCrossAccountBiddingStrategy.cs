// Copyright 2021 Google LLC
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
using System.Collections.Generic;
using System.Linq;
using CommandLine;
using Google.Ads.Gax.Examples;
using Google.Ads.Gax.Util;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V22.Common;
using Google.Ads.GoogleAds.V22.Errors;
using Google.Ads.GoogleAds.V22.Resources;
using Google.Ads.GoogleAds.V22.Services;
using static Google.Ads.GoogleAds.V22.Enums.BiddingStrategyTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V22
{
    /// <summary>
    /// This code example adds a cross-account bidding strategy to a manager account and attaches it
    /// to a client customer's campaign. Also lists all the bidding strategies that are owned by the
    /// manager and accessible by the customer.
    /// Please read our guide pages more information on bidding strategies:
    /// https://developers.google.com/google-ads/api/docs/campaigns/bidding/cross-account-strategies
    /// </summary>
    public class UseCrossAccountBiddingStrategy : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UseCrossAccountBiddingStrategy"/>
        /// example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads client customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads client customer ID for which the call is made.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// The ID of the account that owns the cross-account bidding strategy. This is
            /// typically the ID of the manager account.
            /// </summary>
            [Option("managerCustomerId", Required = true, HelpText =
                "The ID of the account that owns the cross-account bidding strategy. This is" +
                "typically the ID of the manager account.")]
            public long ManagerCustomerId { get; set; }

            /// <summary>
            /// The ID of the campaign owned by the customer ID to which the cross-account bidding
            /// strategy will be attached.
            /// </summary>
            [Option("campaignId", Required = true, HelpText =
                "The ID of the campaign owned by the customer ID to which the cross-account " +
                "bidding strategy will be attached.")]
            public long CampaignId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);
            UseCrossAccountBiddingStrategy codeExample = new UseCrossAccountBiddingStrategy();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.ManagerCustomerId,
                options.CampaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a cross-account bidding strategy to a manager account and " +
            "attaches it to a client customer's campaign. Also lists all the bidding strategies " +
            "that are owned by the manager and accessible by the customer.\n" +
            "Please read our guide pages more information on bidding strategies:" +
            "https://developers.google.com/google-ads/api/docs/campaigns/bidding/cross-account-strategies";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads client customer ID for which the call is
        /// made.</param>
        /// <param name="managerCustomerId">The manager customer ID.</param>
        /// <param name="campaignId">The ID of the campaign owned by the customer ID to which the
        /// cross-account bidding strategy will be attached.</param>
        public void Run(GoogleAdsClient client, long customerId, long managerCustomerId,
            long campaignId)
        {
            try
            {
                string biddingStrategyResourceName =
                    CreateBiddingStrategy(client, managerCustomerId);
                ListManagerOwnedBiddingStrategies(client, managerCustomerId);
                ListCustomerAccessibleBiddingStrategies(client, customerId);
                AttachCrossAccountBiddingStrategyToCampaign(client, customerId, campaignId,
                    biddingStrategyResourceName);
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

        // [START create_cross_account_strategy]
        /// <summary>
        /// Creates a new TargetSpend (Maximize Clicks) cross-account bidding strategy in the
        /// specified manager account.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="managerCustomerId">The manager customer ID.</param>
        /// <returns>The resource name of the newly created bidding strategy.</returns>
        private string CreateBiddingStrategy(GoogleAdsClient client, long managerCustomerId)
        {
            BiddingStrategyServiceClient biddingStrategyServiceClient =
                client.GetService(Services.V22.BiddingStrategyService);

            // Create a portfolio bidding strategy.
            // [START set_currency_code]
            BiddingStrategy portfolioBiddingStrategy = new BiddingStrategy
            {
                Name = $"Maximize clicks #{ExampleUtilities.GetRandomString()}",
                TargetSpend = new TargetSpend(),
                // Set the currency of the new bidding strategy. If not provided, the bidding
                // strategy uses the manager account's default currency.
                CurrencyCode = "USD"
            };
            // [END set_currency_code]

            // Send a create operation that will create the portfolio bidding strategy.
            MutateBiddingStrategiesResponse mutateBiddingStrategiesResponse =
                biddingStrategyServiceClient.MutateBiddingStrategies(managerCustomerId.ToString(),
                    new[]
                    {
                        new BiddingStrategyOperation
                        {
                            Create = portfolioBiddingStrategy
                        }
                    });

            // Print and return the resource name of the newly created cross-account bidding
            // strategy.
            string biddingStrategyResourceName =
                mutateBiddingStrategiesResponse.Results.First().ResourceName;
            Console.WriteLine("Created cross-account bidding strategy " +
                $"'{biddingStrategyResourceName}'.");

            return biddingStrategyResourceName;
        }
        // [END create_cross_account_strategy]

        // [START list_manager_strategies]
        /// <summary>
        /// Lists all cross-account bidding strategies in a specified manager account.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="managerCustomerId">The manager customer ID.</param>
        private void ListManagerOwnedBiddingStrategies(GoogleAdsClient client,
            long managerCustomerId)
        {
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V22.GoogleAdsService);

            // Create a GAQL query that will retrieve all cross-account bidding strategies.
            string query = @"
                SELECT
                  bidding_strategy.id,
                  bidding_strategy.name,
                  bidding_strategy.type,
                  bidding_strategy.currency_code
                FROM bidding_strategy";

            // Issue a streaming search request, then iterate through and print the results.
            googleAdsServiceClient.SearchStream(managerCustomerId.ToString(), query,
                delegate(SearchGoogleAdsStreamResponse resp)
                {
                    Console.WriteLine("Cross-account bid strategies in manager account " +
                        $"{managerCustomerId}:");

                    foreach (GoogleAdsRow googleAdsRow in resp.Results)
                    {
                        BiddingStrategy biddingStrategy = googleAdsRow.BiddingStrategy;

                        Console.WriteLine($"\tID: {biddingStrategy.Id}\n" +
                            $"\tName: {biddingStrategy.Name}\n" +
                            "\tStrategy type: " +
                            $"{Enum.GetName(typeof(BiddingStrategyType), biddingStrategy.Type)}\n" +
                            $"\tCurrency: {biddingStrategy.CurrencyCode}\n\n");
                    }
                }
            );
        }
        // [END list_manager_strategies]

        // [START list_accessible_strategies]
        /// <summary>
        /// Lists all bidding strategies available to specified client customer account. This
        /// includes both portfolio bidding strategies owned by the client customer account and
        /// cross-account bidding strategies shared by any of its managers.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads client customer ID for which the call is
        /// made.</param>
        private void ListCustomerAccessibleBiddingStrategies(GoogleAdsClient client,
            long customerId)
        {
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V22.GoogleAdsService);

            // Create a GAQL query that will retrieve all accessible bidding strategies.
            string query = @"
                SELECT
                  accessible_bidding_strategy.resource_name,
                  accessible_bidding_strategy.id,
                  accessible_bidding_strategy.name,
                  accessible_bidding_strategy.type,
                  accessible_bidding_strategy.owner_customer_id,
                  accessible_bidding_strategy.owner_descriptive_name
                FROM accessible_bidding_strategy";

            // Uncomment the following WHERE clause addition to the query to filter results to
            // *only* cross-account bidding strategies shared with the current customer by a manager
            // (and not also include the current customer's portfolio bidding strategies).
            // query += $" WHERE accessible_bidding_strategy.owner_customer_id != {customerId}";

            // Issue a streaming search request, then iterate through and print the results.
            googleAdsServiceClient.SearchStream(customerId.ToString(), query,
                delegate(SearchGoogleAdsStreamResponse resp)
                {
                    Console.WriteLine($"All bid strategies accessible by account {customerId}:");

                    foreach (GoogleAdsRow googleAdsRow in resp.Results)
                    {
                        AccessibleBiddingStrategy biddingStrategy =
                            googleAdsRow.AccessibleBiddingStrategy;

                        Console.WriteLine($"\tID: {biddingStrategy.Id}\n" +
                            $"\tName: {biddingStrategy.Name}\n" +
                            $"\tStrategy type: {biddingStrategy.Type.ToString()}\n" +
                            $"\tOwner customer ID: {biddingStrategy.OwnerCustomerId}\n" +
                            $"\tOwner description: {biddingStrategy.OwnerDescriptiveName}\n\n");
                    }
                }
            );
        }
        // [END list_accessible_strategies]

        // [START attach_strategy]
        /// <summary>
        /// Attaches a specified cross-account bidding strategy to a campaign owned by a specified
        /// client customer account.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads client customer ID for which the call is
        /// made.</param>
        /// <param name="campaignId">The ID of the campaign owned by the customer ID to which the
        /// cross-account bidding strategy will be attached.</param>
        /// <param name="biddingStrategyResourceName">A cross-account bidding strategy resource
        /// name.</param>
        private void AttachCrossAccountBiddingStrategyToCampaign(GoogleAdsClient client,
            long customerId, long campaignId, string biddingStrategyResourceName)
        {
            CampaignServiceClient campaignServiceClient =
                client.GetService(Services.V22.CampaignService);

            Campaign campaign = new Campaign
            {
                ResourceName = ResourceNames.Campaign(customerId, campaignId),
                BiddingStrategy = biddingStrategyResourceName
            };

            // Mutate the campaign and print the resource name of the updated campaign.
            MutateCampaignsResponse mutateCampaignsResponse =
                campaignServiceClient.MutateCampaigns(customerId.ToString(), new[]
                {
                    new CampaignOperation
                    {
                        Update = campaign,
                        UpdateMask = FieldMasks.AllSetFieldsOf(campaign)
                    }
                });

            Console.WriteLine("Updated campaign with resource name " +
                $"'{mutateCampaignsResponse.Results.First().ResourceName}'.");
        }
        // [END attach_strategy]
    }
}

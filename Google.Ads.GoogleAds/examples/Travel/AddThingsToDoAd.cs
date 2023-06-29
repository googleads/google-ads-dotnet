// Copyright 2023 Google LLC
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
using Google.Ads.Gax.Util;
using Google.Ads.GoogleAds.Extensions.Config;
using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V14.Common;
using Google.Ads.GoogleAds.V14.Errors;
using Google.Ads.GoogleAds.V14.Resources;
using Google.Ads.GoogleAds.V14.Services;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V14.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V14.Enums.AdGroupStatusEnum.Types;
using static Google.Ads.GoogleAds.V14.Enums.AdGroupTypeEnum.Types;
using static Google.Ads.GoogleAds.V14.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V14.Enums.AdvertisingChannelSubTypeEnum.Types;
using static Google.Ads.GoogleAds.V14.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V14.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V14.Resources.Campaign.Types;

namespace Google.Ads.GoogleAds.Examples.V14
{
    /// <summary>
    /// This example creates a Things to do campaign, an ad group and a Things to do ad.
    /// Prerequisite: You need to have an access to the Things to Do Center. The integration
    /// instructions can be found at: https://support.google.com/google-ads/answer/13387362.
    /// </summary>
    public class AddThingsToDoAd : ExampleBase
    {
        /// <summary>
        /// Command line options for running the
        /// <see cref="AddThingsToDoAd"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// The Things To Do Center account ID.
            /// </summary>
            [Option("thingsToDoCenterAccountId", Required = true, HelpText =
                "The Things To Do Center account ID.")]
            public long ThingsToDoCenterAccountId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddThingsToDoAd codeExample = new AddThingsToDoAd();
            Console.WriteLine(codeExample.Description);
            GoogleAdsClient client = new GoogleAdsClient();
            codeExample.Run(client, options.CustomerId,
                options.ThingsToDoCenterAccountId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This example creates a Things to do campaign, an " +
            "ad group and a Things to do ad.\n" +
            "Prerequisite: You need to have an access to the Things to Do Center. The " +
            "integration instructions can be found at: " +
            "https://support.google.com/google-ads/answer/13387362.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="thingsToDoCenterAccountId">The Things To Do Center account ID.</param>
        public void Run(GoogleAdsClient client, long customerId, long thingsToDoCenterAccountId)
        {
            // Creates a budget to be used by the campaign that will be created below.
            string budget = CreateBudget(client, customerId);

            // Creates a Things to do campaign.
            string campaign = CreateThingsToDoCampaign(client, customerId, budget,
                thingsToDoCenterAccountId);

            // Creates an ad group.
            string adGroup = CreateAdGroup(client, customerId, campaign);

            // Creates an ad.
            CreateAdGroupAd(client, customerId, adGroup);
        }

        /// <summary>
        /// Creates the budget for the campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>The resource name of the newly created campaign budget.</returns>
        private static string CreateBudget(GoogleAdsClient client, long customerId)
        {
            // Get the BudgetService.
            CampaignBudgetServiceClient budgetService = client.GetService(
                Services.V14.CampaignBudgetService);

            // Create the campaign budget.
            CampaignBudget budget = new CampaignBudget()
            {
                Name = "Interplanetary Cruise Budget #" + ExampleUtilities.GetRandomString(),
                DeliveryMethod = BudgetDeliveryMethod.Standard,
                AmountMicros = 500000,
                ExplicitlyShared = true
            };

            // Create the operation.
            CampaignBudgetOperation budgetOperation = new CampaignBudgetOperation()
            {
                Create = budget
            };

            // Create the campaign budget.
            MutateCampaignBudgetsResponse response = budgetService.MutateCampaignBudgets(
                customerId.ToString(), new CampaignBudgetOperation[] { budgetOperation });
            return response.Results[0].ResourceName;
        }

        /// <summary>
        /// Creates a new Things to do campaign in the specified customer account.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="budget">The resource name of the budget for the new campaign.</param>
        /// <param name="thingsToDoCenterAccountId">The Things to Do Center account ID.</param>
        /// <returns>The resource name of the newly created campaign.</returns>
        private static string CreateThingsToDoCampaign(GoogleAdsClient client, long customerId,
            string budget, long thingsToDoCenterAccountId)
        {

            // Get the CampaignService.
            CampaignServiceClient campaignService = client.GetService(Services.V14.CampaignService);

            // [START add_things_to_do_ad_1]
            // Creates a campaign.
            Campaign campaign = new Campaign()
            {
                Name = "Interplanetary Cruise #" + ExampleUtilities.GetRandomString(),
                AdvertisingChannelType = AdvertisingChannelType.Travel,
                AdvertisingChannelSubType = AdvertisingChannelSubType.TravelActivities,

                TravelCampaignSettings = new TravelCampaignSettings()
                {
                    TravelAccountId = thingsToDoCenterAccountId
                },

                // Recommendation: Set the campaign to PAUSED when creating it to prevent
                // the ads from immediately serving. Set to ENABLED once you've added
                // targeting and the ads are ready to serve
                Status = CampaignStatus.Paused,

                // Set the bidding strategy and budget.
                MaximizeConversionValue = new MaximizeConversionValue(),
                CampaignBudget = budget,

                // Set the campaign network options.
                NetworkSettings = new NetworkSettings
                {
                    TargetGoogleSearch = true
                }
            };
            // [END add_things_to_do_ad_1]

            MutateCampaignsResponse response = campaignService.MutateCampaigns(
                customerId.ToString(), new CampaignOperation[] { new CampaignOperation() {
                    Create = campaign
                }}
            );

            string campaignResourceName = response.Results[0].ResourceName;
            Console.WriteLine("Campaign with resource name = '{0}' was added.", campaignResourceName);

            return campaignResourceName;
        }

        /// <summary>
        /// Creates a new ad group in the specified Things to do campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaign">The resource name of the campaign for the new ad group.</param>
        /// <returns>The resource name of the newly created ad group.</returns>
        // [START add_things_to_do_ad_2]
        private static string CreateAdGroup(GoogleAdsClient client, long customerId,
            string campaign)
        {
            // Get the AdGroupService.
            AdGroupServiceClient adGroupService = client.GetService(Services.V14.AdGroupService);

            // Create the ad group.
            AdGroup adGroup = new AdGroup()
            {
                Name = $"Earth to Mars Cruises #{ExampleUtilities.GetRandomString()}",
                Status = AdGroupStatus.Enabled,
                Campaign = campaign,
                Type = AdGroupType.TravelAds
            };

            MutateAdGroupsResponse response = adGroupService.MutateAdGroups(
                customerId.ToString(), new AdGroupOperation[] { new AdGroupOperation() {
                    Create = adGroup
                }}
            );

            string adGroupResourceName = response.Results[0].ResourceName;
            Console.WriteLine("Ad group with resource name = '{0}' was added.", adGroupResourceName);

            return adGroupResourceName;
        }
        // [END add_things_to_do_ad_2]

        /// <summary>
        /// Creates a new ad group ad in the specified ad group.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroup">The resource name of the ad group for the new ad group ad.</param>
        // [START add_things_to_do_ad_3]
        private static void CreateAdGroupAd(GoogleAdsClient client, long customerId,
            string adGroup)
        {

            // Get the AdGroupAdService.
            AdGroupAdServiceClient adGroupAdService =
                client.GetService(Services.V14.AdGroupAdService);

            // Creates a new ad group ad and sets a travel ad info.
            AdGroupAd adGroupAd = new AdGroupAd()
            {
                Ad = new Ad()
                {
                    TravelAd = new TravelAdInfo()
                },
                // Set the ad group ad to enabled. Setting this to paused will cause an error for
                // Things to do campaigns. Pausing should happen at either the ad group or campaign
                // level.
                Status = AdGroupAdStatus.Enabled,
                AdGroup = adGroup
            };

            MutateAdGroupAdsResponse response = adGroupAdService.MutateAdGroupAds(
                customerId.ToString(), new AdGroupAdOperation[] { new AdGroupAdOperation() {
                    Create = adGroupAd
                }}
            );

            string adGroupAdResourceName = response.Results[0].ResourceName;
            Console.WriteLine("Ad group ad with resource name = '{0}' was added.",
                adGroupAdResourceName);
        }
        // [END add_things_to_do_ad_3]
    }
}
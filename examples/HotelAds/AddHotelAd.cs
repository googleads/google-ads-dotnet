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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V9.Common;
using Google.Ads.GoogleAds.V9.Errors;
using Google.Ads.GoogleAds.V9.Resources;
using Google.Ads.GoogleAds.V9.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V9.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.AdGroupStatusEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.AdGroupTypeEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V9.Resources.Campaign.Types;

namespace Google.Ads.GoogleAds.Examples.V9
{
    /// <summary>
    /// This code example creates a hotel campaign, a hotel ad group and hotel ad group ad.
    ///
    /// Prerequisite: You need to have access to the Hotel Ads Center, which can be granted during
    /// integration with Google Hotels. The integration instructions can be found at:
    /// https://support.google.com/hotelprices/answer/6101897.
    /// </summary>
    public class AddHotelAd : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddHotelAd"/> example.
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
            /// The Hotels account ID. You can see how to find the account ID
            /// in the Hotel Ads Center at: https://support.google.com/hotelprices/answer/6399770.
            /// This ID is the same account ID that you use in API requests to the Travel
            /// Partner APIs (https://developers.google.com/hotels/hotel-ads/api-reference/).
            /// </summary>
            [Option("hotelCenterAccountId", Required = true, HelpText =
                "The Hotels account ID. You can see how to find the account ID in the Hotel Ads " +
                "Center at: https://support.google.com/hotelprices/answer/6399770. This ID is " +
                "the same account ID that you use in API requests to the Travel Partner APIs " +
                "(https://developers.google.com/hotels/hotel-ads/api-reference/).")]
            public long HotelCenterAccountId { get; set; }

            /// <summary>
            /// The CPC bid ceiling micro amount.
            /// </summary>
            [Option("cpcBidCeilingMicroAmount", Required = false, HelpText =
                "The maximum bid limit that can be set when creating a campaign using the Percent" +
                " CPC bidding strategy.", Default = CPC_BID_CEILING_MICRO_AMOUNT)]
            public long CpcBidCeilingMicroAmount { get; set; }
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

                    // Specify your Hotels account ID below. You can see how to find the account ID
                    // in the Hotel Ads Center at: https://support.google.com/hotelprices/answer/6399770.
                    // This ID is the same account ID that you use in API requests to the Travel
                    // Partner APIs (https://developers.google.com/hotels/hotel-ads/api-reference/).
                    options.HotelCenterAccountId =
                        long.Parse("INSERT_HOTEL_CENTER_ACCOUNT_ID_HERE");

                    // Optional: Specify the maximum bid limit that can be set when creating a
                    // campaign using the Percent CPC bidding strategy.
                    long? cpcBidCeilingMicroAmount = CPC_BID_CEILING_MICRO_AMOUNT;

                    long tempVal = 0;
                    if (long.TryParse("INSERT_CPC_BID_CEILING_MICRO_AMOUNT", out tempVal))
                    {
                        cpcBidCeilingMicroAmount = tempVal;
                    }

                    options.CpcBidCeilingMicroAmount = cpcBidCeilingMicroAmount.Value;

                    return 0;
                });

            AddHotelAd codeExample = new AddHotelAd();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId,
                options.HotelCenterAccountId, options.CpcBidCeilingMicroAmount);
        }

        // Specify maximum bid limit that can be set when creating a campaign using the Percent CPC
        // bidding strategy.
        private const long CPC_BID_CEILING_MICRO_AMOUNT = 20000000;

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example creates a hotel campaign, a hotel ad group and hotel ad group ad." +
            "\n\n Prerequisite: You need to have access to the Hotel Ads Center, which can be " +
            "granted during integration with Google Hotels. The integration instructions can be " +
            "found at: https://support.google.com/hotelprices/answer/6101897.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="hotelCenterAccountId">The Hotel Center account ID.</param>
        /// <param name="cpcBidCeilingMicroAmount">The CPC bid ceiling micro amount.</param>
        // [START add_hotel_ad]
        public void Run(GoogleAdsClient client, long customerId, long hotelCenterAccountId,
            long cpcBidCeilingMicroAmount)
        {
            try
            {
                // Create a budget to be used by the campaign that will be created below.
                string budgetResourceName = AddCampaignBudget(client, customerId);

                // Create a hotel campaign.
                string campaignResourceName = AddHotelCampaign(client, customerId,
                    budgetResourceName, hotelCenterAccountId, cpcBidCeilingMicroAmount);

                // Create a hotel ad group.
                string adGroupResourceName = AddHotelAdGroup(client, customerId,
                    campaignResourceName);

                // Create a hotel ad group ad.
                AddHotelAdGroupAd(client, customerId, adGroupResourceName);
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
        // [END add_hotel_ad]

        /// <summary>
        /// Creates a new campaign budget in the specified client account.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>The resource name of the newly created budget.</returns>
        private static string AddCampaignBudget(GoogleAdsClient client, long customerId)
        {
            // Get the CampaignBudgetService.
            CampaignBudgetServiceClient service = client.GetService(
                Services.V9.CampaignBudgetService);

            // Create a campaign budget.
            CampaignBudget budget = new CampaignBudget()
            {
                Name = "Interplanetary Cruise Budget #" + ExampleUtilities.GetRandomString(),
                DeliveryMethod = BudgetDeliveryMethod.Standard,
                AmountMicros = 50000000
            };

            // Create a campaign budget operation.
            CampaignBudgetOperation campaignBudgetOperation = new CampaignBudgetOperation()
            {
                Create = budget
            };

            // Create the budget.
            MutateCampaignBudgetsResponse response = service.MutateCampaignBudgets(
                customerId.ToString(), new CampaignBudgetOperation[] { campaignBudgetOperation });

            string budgetResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Added a budget with resource name: '{budgetResourceName}'.");
            return budgetResourceName;
        }

        /// <summary>
        /// Creates a new hotel campaign in the specified client account.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="budgetResourceName">The resource name of budget for a new campaign.
        /// </param>
        /// <param name="hotelCenterAccountId">The Hotel Center account ID.</param>
        /// <param name="cpcBidCeilingMicroAmount">The CPC bid ceiling micro amount.</param>
        /// <returns>The resource name of the newly created campaign.</returns>
        private static string AddHotelCampaign(GoogleAdsClient client, long customerId,
            string budgetResourceName, long hotelCenterAccountId, long cpcBidCeilingMicroAmount)
        {
            // Get the CampaignService.
            CampaignServiceClient service = client.GetService(Services.V9.CampaignService);

            // [START add_hotel_ad_1]
            // Create a campaign.
            Campaign campaign = new Campaign()
            {
                Name = "Interplanetary Cruise Campaign #" + ExampleUtilities.GetRandomString(),

                // Configure settings related to hotel campaigns including advertising channel type
                // and hotel setting info.
                AdvertisingChannelType = AdvertisingChannelType.Hotel,
                HotelSetting = new HotelSettingInfo()
                {
                    HotelCenterId = hotelCenterAccountId
                },

                // Recommendation: Set the campaign to PAUSED when creating it to prevent
                // the ads from immediately serving. Set to ENABLED once you've added
                // targeting and the ads are ready to serve.
                Status = CampaignStatus.Paused,

                // Sets the bidding strategy to PercentCpc. Only Manual CPC and Percent CPC can
                // be used for hotel campaigns.
                PercentCpc = new PercentCpc()
                {
                    CpcBidCeilingMicros = cpcBidCeilingMicroAmount
                },

                // Set the budget.
                CampaignBudget = budgetResourceName,

                // Configure the campaign network options. Only Google Search is allowed for
                // hotel campaigns.
                NetworkSettings = new NetworkSettings()
                {
                    TargetGoogleSearch = true
                }
            };
            // [END add_hotel_ad_1]

            // Create a campaign operation.
            CampaignOperation campaignOperation = new CampaignOperation()
            {
                Create = campaign
            };

            // Issue a mutate request to add campaigns.
            MutateCampaignsResponse response = service.MutateCampaigns(customerId.ToString(),
                new CampaignOperation[] { campaignOperation });

            return response.Results[0].ResourceName;
        }

        /// <summary>
        /// Adds the hotel ad group.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignResourceName">The resource name of campaign that a new ad group
        /// will belong to.</param>
        /// <returns>The resource name of the newly created ad group.</returns>
        // [START add_hotel_ad_2]
        private static string AddHotelAdGroup(GoogleAdsClient client, long customerId,
            string campaignResourceName)
        {
            // Get the AdGroupService.
            AdGroupServiceClient service = client.GetService(Services.V9.AdGroupService);

            // Create an ad group.
            AdGroup adGroup = new AdGroup()
            {
                Name = "Earth to Mars Cruise #" + ExampleUtilities.GetRandomString(),

                // Sets the campaign.
                Campaign = campaignResourceName,

                // Optional: Sets the ad group type to HOTEL_ADS.
                // This cannot be set to other types.
                Type = AdGroupType.HotelAds,

                CpcBidMicros = 10000000,
                Status = AdGroupStatus.Enabled
            };

            // Create an ad group operation.
            AdGroupOperation adGroupOperation = new AdGroupOperation()
            {
                Create = adGroup
            };

            // Issue a mutate request to add an ad group.
            MutateAdGroupsResponse response = service.MutateAdGroups(customerId.ToString(),
                new AdGroupOperation[] { adGroupOperation });
            return response.Results[0].ResourceName;
        }
        // [END add_hotel_ad_2]

        /// <summary>
        /// Creates a new hotel ad group ad in the specified ad group.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupResourceName">The resource name of ad group that a new ad group
        /// ad will belong to</param>
        // [START add_hotel_ad_3]
        private static void AddHotelAdGroupAd(GoogleAdsClient client, long customerId,
            string adGroupResourceName)
        {
            // Get the AdGroupAdService.
            AdGroupAdServiceClient service = client.GetService(Services.V9.AdGroupAdService);

            // Create a new ad group ad and sets the hotel ad to it.
            AdGroupAd adGroupAd = new AdGroupAd()
            {
                // Create a new hotel ad.
                Ad = new Ad()
                {
                    HotelAd = new HotelAdInfo(),
                },
                // Set the ad group.
                AdGroup = adGroupResourceName,
                // Set the ad group ad to enabled.  Setting this to paused will cause an error
                // for hotel campaigns.  For hotels pausing should happen at either the ad group or
                // campaign level.
                Status = AdGroupAdStatus.Enabled
            };

            // Create an ad group ad operation.
            AdGroupAdOperation adGroupAdOperation = new AdGroupAdOperation()
            {
                Create = adGroupAd
            };

            // Issue a mutate request to add an ad group ad.
            MutateAdGroupAdsResponse response = service.MutateAdGroupAds(customerId.ToString(),
                new AdGroupAdOperation[] { adGroupAdOperation });

            MutateAdGroupAdResult addedAdGroupAd = response.Results[0];
            Console.WriteLine($"Added a hotel ad group ad with resource name " +
                $"{addedAdGroupAd.ResourceName}.");
        }
        // [END add_hotel_ad_3]
    }
}

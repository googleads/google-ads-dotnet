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
using Google.Ads.GoogleAds.V19.Common;
using Google.Ads.GoogleAds.V19.Errors;
using Google.Ads.GoogleAds.V19.Resources;
using Google.Ads.GoogleAds.V19.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V19.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.AdGroupStatusEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.AdGroupTypeEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.ListingGroupTypeEnum.Types;
using static Google.Ads.GoogleAds.V19.Resources.Campaign.Types;

namespace Google.Ads.GoogleAds.Examples.V19
{
    /// <summary>
    /// This code example creates a standard shopping campaign, a shopping product ad group and a
    /// shopping product ad.
    ///
    /// Prerequisite: You need to have access to a Merchant Center account. You can find
    /// instructions to create a Merchant Center account here:
    /// https://support.google.com/merchants/answer/188924.
    /// This account must be linked to your AdWords account.The integration instructions can be
    /// found at: https://developers.google.com/adwords/shopping/full-automation/articles/t15.
    /// </summary>
    public class AddShoppingProductAd : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddShoppingProductAd"/> example.
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
            /// The Merchant Center account ID.
            /// </summary>
            [Option("merchantCenterAccountId", Required = true, HelpText =
                "The Merchant Center account ID.")]
            public long MerchantCenterAccountId { get; set; }

            /// <summary>
            /// The boolean to indicate if a default listing group should be created for the ad
            /// group. Set to false if the listing group will be constructed elsewhere.
            /// See AddShoppingListingGroupTree for a more comprehensive example.
            /// </summary>
            [Option("createDefaultListingGroup", Required = true, HelpText =
                "The boolean to indicate if a default listing group should be created for the " +
                "ad group. Set to false if the listing group will be constructed elsewhere. " +
                "See AddShoppingListingGroupTree for a more comprehensive example.")]
            public bool CreateDefaultListingGroup { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddShoppingProductAd codeExample = new AddShoppingProductAd();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId,
                options.MerchantCenterAccountId, options.CreateDefaultListingGroup);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example creates a standard shopping campaign, a shopping product ad group " +
            "and a shopping product ad." +
            "\nPrerequisite: You need to have access to a Merchant Center account. You can find " +
            "instructions to create a Merchant Center account here: " +
            "https://support.google.com/merchants/answer/188924." +
            "\nThis account must be linked to your AdWords account.The integration instructions " +
            "can be found at: " +
            "https://developers.google.com/adwords/shopping/full-automation/articles/t15.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="merchantCenterAccountId">The Merchant Center account ID.</param>
        /// <param name="createDefaultListingGroup">The boolean to indicate if a default listing
        /// group should be created for the ad group. Set to false if the listing group will be
        /// constructed elsewhere.
        ///
        /// See AddShoppingListingGroupTree for a more comprehensive example.</param>
        public void Run(GoogleAdsClient client, long customerId, long merchantCenterAccountId,
            bool createDefaultListingGroup)
        {
            try
            {
                // Creates a budget to be used by the campaign that will be created below.
                string budgetResourceName = AddCampaignBudget(client, customerId);

                // Creates a standard shopping campaign.
                string campaignResourceName = AddStandardShoppingCampaign(
                    client, customerId, budgetResourceName, merchantCenterAccountId);

                // Creates a product shopping ad group.
                string adGroupResourceName = AddProductShoppingAdGroup(
                    client, customerId, campaignResourceName);

                // Creates a product shopping ad group ad.
                AddProductShoppingAdGroupAd(client, customerId, adGroupResourceName);

                if (createDefaultListingGroup)
                {
                    // Creates an ad group criterion containing a listing group.
                    // This will be the listing group tree for 'All products' and will contain
                    // a single biddable unit node.
                    AddDefaultShoppingListingGroup(client, customerId, adGroupResourceName);
                }
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
        /// Creates a new campaign budget in the specified client account.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <returns>Resource name of the newly created budget.</returns>
        /// <exception cref="GoogleAdsException">Thrown if an API request failed with one or more
        /// service errors.</exception>
        private string AddCampaignBudget(GoogleAdsClient client, long customerId)
        {
            // Get the CampaignBudgetService.
            CampaignBudgetServiceClient campaignBudgetService =
                client.GetService(Services.V19.CampaignBudgetService);

            CampaignBudget budget = new CampaignBudget()
            {
                Name = "Interplanetary Cruise Budget #" + ExampleUtilities.GetRandomString(),
                DeliveryMethod = BudgetDeliveryMethod.Standard,
                AmountMicros = 5_000_000L
            };

            CampaignBudgetOperation operation = new CampaignBudgetOperation()
            {
                Create = budget
            };

            MutateCampaignBudgetsResponse response =
                campaignBudgetService.MutateCampaignBudgets(customerId.ToString(),
                    new CampaignBudgetOperation[] { operation });
            string budgetResourceName = response.Results[0].ResourceName;
            Console.WriteLine("Added a budget with resource name: '{0}'.", budgetResourceName);
            return budgetResourceName;
        }

        /// <summary>
        ///  Creates a new standard shopping campaign in the specified client account.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="budgetResourceName">The resource name of the budget for the campaign.
        /// </param>
        /// <param name="merchantCenterAccountId">The Merchant Center account ID.</param>
        /// <returns>Resource name of the newly created campaign.</returns>
        /// <exception cref="GoogleAdsException">Thrown if an API request failed with one or more
        /// service errors.</exception>
        // [START add_shopping_product_ad_2]
        private string AddStandardShoppingCampaign(GoogleAdsClient client, long customerId,
            string budgetResourceName, long merchantCenterAccountId)
        {
            // Get the CampaignService.
            CampaignServiceClient campaignService =
                client.GetService(Services.V19.CampaignService);

            // Configures the shopping settings.
            ShoppingSetting shoppingSetting = new ShoppingSetting()
            {
                // Sets the priority of the campaign. Higher numbers take priority over lower
                // numbers. For Shopping Product Ad campaigns, allowed values are between 0 and 2,
                // inclusive.
                CampaignPriority = 0,

                MerchantId = merchantCenterAccountId,

                // Enables local inventory ads for this campaign.
                EnableLocal = true
            };

            // Create the standard shopping campaign.
            Campaign campaign = new Campaign()
            {
                Name = "Interplanetary Cruise #" + ExampleUtilities.GetRandomString(),

                // Configures settings related to shopping campaigns including advertising channel
                // type and shopping setting.
                AdvertisingChannelType = AdvertisingChannelType.Shopping,

                ShoppingSetting = shoppingSetting,

                // Recommendation: Set the campaign to PAUSED when creating it to prevent
                // the ads from immediately serving. Set to ENABLED once you've added
                // targeting and the ads are ready to serve
                Status = CampaignStatus.Paused,

                // Sets the bidding strategy to Manual CPC.
                // Recommendation: Use one of the automated bidding strategies for Shopping
                // campaigns to help you optimize your advertising spend. More information can be
                // found here: https://support.google.com/google-ads/answer/6309029
                ManualCpc = new ManualCpc(),

                // Sets the budget.
                CampaignBudget = budgetResourceName
            };

            // Creates a campaign operation.
            CampaignOperation operation = new CampaignOperation()
            {
                Create = campaign
            };

            // Issues a mutate request to add the campaign.
            MutateCampaignsResponse response =
                campaignService.MutateCampaigns(customerId.ToString(),
                    new CampaignOperation[] { operation });
            MutateCampaignResult result = response.Results[0];
            Console.WriteLine("Added a standard shopping campaign with resource name: '{0}'.",
                result.ResourceName);
            return result.ResourceName;
        }
        // [END add_shopping_product_ad_2]

        /// <summary>
        /// Creates a new product shopping ad group in the specified campaign.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="campaignResourceName">Resource name of the shopping campaign that the
        /// new ad group will belong to.</param>
        /// <returns>Resource name of the newly created ad group.</returns>
        /// <exception cref="GoogleAdsException">Thrown if an API request failed with one or more
        /// service errors.</exception>
        // [START add_shopping_product_ad_1]
        private string AddProductShoppingAdGroup(GoogleAdsClient client, long customerId,
                    string campaignResourceName)
        {
            // Get the AdGroupService.
            AdGroupServiceClient adGroupService = client.GetService(Services.V19.AdGroupService);

            // Creates an ad group.
            AdGroup adGroup = new AdGroup()
            {
                Name = "Earth to Mars Cruises #" + ExampleUtilities.GetRandomString(),
                Campaign = campaignResourceName,
                // Sets the ad group type to SHOPPING_PRODUCT_ADS. This is the only value possible
                // for ad groups that contain shopping product ads.
                Type = AdGroupType.ShoppingProductAds,
                CpcBidMicros = 1_000_000L,
                Status = AdGroupStatus.Enabled
            };

            // Creates an ad group operation.
            AdGroupOperation operation = new AdGroupOperation()
            {
                Create = adGroup
            };

            // Issues a mutate request to add an ad group.
            MutateAdGroupResult mutateAdGroupResult =
                adGroupService
                    .MutateAdGroups(customerId.ToString(), new AdGroupOperation[] { operation })
                    .Results[0];
            Console.WriteLine("Added a product shopping ad group with resource name: '{0}'.",
                mutateAdGroupResult.ResourceName);
            return mutateAdGroupResult.ResourceName;
        }
        // [END add_shopping_product_ad_1]

        /// <summary>
        /// Creates a new Shopping product ad group ad in the specified ad group.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="adGroupResourceName">The resource name of the ad group that the new ad
        /// group ad will belong to.</param>
        /// <returns>Resource name of the newly created ad group ad.</returns>
        /// <exception cref="GoogleAdsException">Thrown if an API request failed with one or more
        /// service errors.</exception>
        // [START add_shopping_product_ad]
        private string AddProductShoppingAdGroupAd(GoogleAdsClient client, long customerId,
            string adGroupResourceName)
        {
            // Get the AdGroupAdService.
            AdGroupAdServiceClient adGroupAdService = client.GetService(
                Services.V19.AdGroupAdService);

            // Creates a new shopping product ad.
            Ad ad = new Ad()
            {
                ShoppingProductAd = new ShoppingProductAdInfo()
                {
                }
            };

            // Creates a new ad group ad and sets the shopping product ad to it.
            AdGroupAd adGroupAd = new AdGroupAd()
            {
                // Sets the ad to the ad created above.
                Ad = ad,

                Status = AdGroupAdStatus.Paused,

                // Sets the ad group.
                AdGroup = adGroupResourceName
            };

            // Creates an ad group ad operation.
            AdGroupAdOperation operation = new AdGroupAdOperation()
            {
                Create = adGroupAd
            };

            // Issues a mutate request to add an ad group ad.
            MutateAdGroupAdResult mutateAdGroupAdResult = adGroupAdService.MutateAdGroupAds(
                customerId.ToString(), new AdGroupAdOperation[] { operation }).Results[0];
            Console.WriteLine("Added a product shopping ad group ad with resource name: '{0}'.",
                mutateAdGroupAdResult.ResourceName);
            return mutateAdGroupAdResult.ResourceName;
        }
        // [END add_shopping_product_ad]

        /// <summary>
        /// Creates a new default shopping listing group for the specified ad group. A listing
        /// group is the Google Ads API representation of a "product group" described in the
        /// Google Ads user interface. The listing group will be added to the ad group using an
        /// "ad group criterion".
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="adGroupResourceName">The resource name of the ad group that the new
        /// listing group will belong to.</param>
        /// <returns>Resource name of the newly created ad group criterion containing the
        /// listing group.</returns>
        /// <exception cref="GoogleAdsException">Thrown if an API request failed with one or more
        /// service errors.</exception>
        private string AddDefaultShoppingListingGroup(GoogleAdsClient client, long customerId,
            string adGroupResourceName)
        {
            // Get the AdGroupCriterionService.
            AdGroupCriterionServiceClient adGroupCriterionService = client.GetService(
                Services.V19.AdGroupCriterionService);

            // Creates a new ad group criterion. This will contain the "default" listing group (All
            // products).
            AdGroupCriterion adGroupCriterion = new AdGroupCriterion()
            {
                AdGroup = adGroupResourceName,
                Status = AdGroupCriterionStatus.Enabled,

                // Creates a new listing group. This will be the top-level "root" node.
                // Set the type of the listing group to be a biddable unit.
                ListingGroup = new ListingGroupInfo()
                {
                    Type = ListingGroupType.Unit
                },
                // Set the bid for products in this listing group unit.
                CpcBidMicros = 500_000L
            };

            AdGroupCriterionOperation operation = new AdGroupCriterionOperation()
            {
                Create = adGroupCriterion
            };

            MutateAdGroupCriterionResult mutateAdGroupCriteriaResult =
                adGroupCriterionService.MutateAdGroupCriteria(customerId.ToString(),
                    new AdGroupCriterionOperation[] { operation }).Results[0];
            Console.WriteLine("Added an ad group criterion containing a listing group with " +
                "resource name: '{0}'.", mutateAdGroupCriteriaResult.ResourceName);
            return mutateAdGroupCriteriaResult.ResourceName;
        }
    }
}

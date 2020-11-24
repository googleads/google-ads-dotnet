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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Common;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;

using System;
using static Google.Ads.GoogleAds.V6.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.AdGroupStatusEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.AdGroupTypeEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.ListingGroupTypeEnum.Types;
using static Google.Ads.GoogleAds.V6.Resources.Campaign.Types;
using static Google.Ads.GoogleAds.V6.Enums.AdvertisingChannelSubTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example creates a Smart Shopping campaign, a Smart Shopping ad group, a Smart
    /// Shopping ad group ad and a listing group for "All products".
    ///
    /// Prerequisite: You need to have access to a Merchant Center account. You can find
    /// instructions to create a Merchant Center account here:
    /// https://support.google.com/merchants/answer/188924. This account must be
    /// linked to your Google Ads account.The integration instructions can be found at:
    /// https://developers.google.com/adwords/shopping/full-automation/articles/t15.
    /// </summary>
    public class AddShoppingSmartAd : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddShoppingSmartAd codeExample = new AddShoppingSmartAd();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The Merchant Center account ID.
            long merchantCenterAccountId = long.Parse("INSERT_MERCHANT_CENTER_ACCOUNT_ID_HERE");

            // The boolean to indicate if a default listing group should be created for the
            // ad group. Set to false if the listing group will be constructed elsewhere.
            //
            // See AddShoppingListingGroupTree for a more comprehensive example.
            bool createDefaultListingGroup =
                bool.Parse("INSERT_CREATE_DEFAULT_LISTING_GROUP_HERE");
            codeExample.Run(new GoogleAdsClient(), customerId, merchantCenterAccountId,
                createDefaultListingGroup);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example creates a Smart Shopping campaign, a Smart Shopping ad group, a " +
            "Smart Shopping ad group ad and a listing group for \"All products\"." +
            "\nPrerequisite: You need to have access to a Merchant Center account. You can find " +
            "instructions to create a Merchant Center account here: " +
            "https://support.google.com/merchants/answer/188924.\nThis account must be linked to " +
            "your Google Ads account.The integration instructions can be found at: " +
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

                // Creates a Smart Shopping campaign.
                string campaignResourceName = AddSmartShoppingCampaign(
                    client, customerId, budgetResourceName, merchantCenterAccountId);

                // Creates a Smart Shopping ad group.
                string adGroupResourceName = AddSmartShoppingAdGroup(
                    client, customerId, campaignResourceName);

                // Creates a Smart Shopping ad group ad.
                AddSmartShoppingAdGroupAd(client, customerId, adGroupResourceName);

                if (createDefaultListingGroup)
                {
                    // A product group is a subset of inventory. Listing groups are the equivalent
                    // of product groups in the API and allow you to bid on the chosen group or
                    // exclude a group from bidding. This method creates an ad group criterion
                    // containing a listing group.
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
                client.GetService(Services.V6.CampaignBudgetService);

            CampaignBudget budget = new CampaignBudget()
            {
                Name = "Interplanetary Cruise Budget #" + ExampleUtilities.GetRandomString(),
                DeliveryMethod = BudgetDeliveryMethod.Standard,
                AmountMicros = 5_000_000L,
                // Budgets for Smart Shopping campaigns cannot be shared.
                ExplicitlyShared = false
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
        ///  Creates a new shopping campaign for Smart Shopping ads in the specified client account.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="budgetResourceName">The resource name of the budget for the campaign.
        /// </param>
        /// <param name="merchantCenterAccountId">The Merchant Center account ID.</param>
        /// <returns>Resource name of the newly created campaign.</returns>
        /// <exception cref="GoogleAdsException">Thrown if an API request failed with one or more
        /// service errors.</exception>
        // [START AddShoppingSmartAd_3]
        private string AddSmartShoppingCampaign(GoogleAdsClient client, long customerId,
            string budgetResourceName, long merchantCenterAccountId)
        {
            // Get the CampaignService.
            CampaignServiceClient campaignService =
                client.GetService(Services.V6.CampaignService);

            // Configures the shopping settings.
            ShoppingSetting shoppingSetting = new ShoppingSetting()
            {
                // Sets the sales country of products to include in the campaign.
                SalesCountry = "US",
                MerchantId = merchantCenterAccountId,
            };

            // [START AddShoppingSmartAd]
            // Create the standard shopping campaign.
            Campaign campaign = new Campaign()
            {
                Name = "Interplanetary Cruise #" + ExampleUtilities.GetRandomString(),

                // Configures settings related to shopping campaigns including advertising channel
                // type, sub-type and shopping setting.
                AdvertisingChannelType = AdvertisingChannelType.Shopping,
                AdvertisingChannelSubType = AdvertisingChannelSubType.ShoppingSmartAds,

                ShoppingSetting = shoppingSetting,

                // Recommendation: Set the campaign to PAUSED when creating it to prevent
                // the ads from immediately serving. Set to ENABLED once you've added
                // targeting and the ads are ready to serve
                Status = CampaignStatus.Paused,

                // Bidding strategy must be set directly on the campaign.
                // Setting a portfolio bidding strategy by resourceName is not supported.
                // Maximize conversion value is the only strategy supported for Smart Shopping
                // campaigns.
                // An optional ROAS (Return on Advertising Spend) can be set for
                // MaximizeConversionValue.
                // The ROAS value must be specified as a ratio in the API. It is calculated by
                // dividingW "total value" by "total spend".
                // For more information on maximize conversion value, see the support article:
                // http://support.google.com/google-ads/answer/7684216)
                MaximizeConversionValue = new MaximizeConversionValue()
                {
                    TargetRoas = 3.5
                },

                // Sets the budget.
                CampaignBudget = budgetResourceName
            };
            // [END AddShoppingSmartAd]

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
            Console.WriteLine("Added a Smart Shopping campaign with resource name: '{0}'.",
                result.ResourceName);
            return result.ResourceName;
        }

        /// <summary>
        // [END AddShoppingSmartAd_3]
        /// Creates a new ad group in the specified Smart Shopping campaign.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="campaignResourceName">Resource name of the shopping campaign that the
        /// new ad group will belong to.</param>
        /// <returns>Resource name of the newly created ad group.</returns>
        /// <exception cref="GoogleAdsException">Thrown if an API request failed with one or more
        /// service errors.</exception>
        // [START AddShoppingSmartAd_2]
        private string AddSmartShoppingAdGroup(GoogleAdsClient client, long customerId,
                    string campaignResourceName)
        {
            // Get the AdGroupService.
            AdGroupServiceClient adGroupService = client.GetService(Services.V6.AdGroupService);

            // Creates an ad group.
            AdGroup adGroup = new AdGroup()
            {
                Name = "Earth to Mars Cruises #" + ExampleUtilities.GetRandomString(),
                Campaign = campaignResourceName,
                // Sets the ad group type to SHOPPING_SMART_ADS. This cannot be set to
                // other types.
                Type = AdGroupType.ShoppingSmartAds,
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
            Console.WriteLine("Added a Smart Shopping ad group with resource name: '{0}'.",
                mutateAdGroupResult.ResourceName);
            return mutateAdGroupResult.ResourceName;
        }

        /// <summary>
        // [END AddShoppingSmartAd_2]
        /// Creates a new ad group ad in the specified Smart Shopping ad group.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="adGroupResourceName">The resource name of the ad group that the new ad
        /// group ad will belong to.</param>
        /// <returns>Resource name of the newly created ad group ad.</returns>
        /// <exception cref="GoogleAdsException">Thrown if an API request failed with one or more
        /// service errors.</exception>
        // [START AddShoppingSmartAd_1]
        private string AddSmartShoppingAdGroupAd(GoogleAdsClient client, long customerId,
            string adGroupResourceName)
        {
            // Get the AdGroupAdService.
            AdGroupAdServiceClient adGroupAdService = client.GetService(
                Services.V6.AdGroupAdService);

            // Creates a new shopping product ad.
            Ad ad = new Ad()
            {
                ShoppingSmartAd = new ShoppingSmartAdInfo()
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
            Console.WriteLine("Added a Smart Shopping ad group ad with resource name: '{0}'.",
                mutateAdGroupAdResult.ResourceName);
            return mutateAdGroupAdResult.ResourceName;
        }

        /// <summary>
        // [END AddShoppingSmartAd_1]
        /// Creates a new Shopping listing group for the specified ad group. This is known as a
        /// "product group" in the Google Ads user interface. The listing group will be added to
        /// the ad group using an "ad group criterion". For more information on listing groups see
        /// the Google Ads API Shopping guide: https://developers.google.com/google-ads/api/docs/shopping-ads/overview
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
                Services.V6.AdGroupCriterionService);

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
                // Note: Listing groups do not require bids for Smart Shopping campaigns.
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

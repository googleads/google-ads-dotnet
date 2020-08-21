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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V4.Common;
using Google.Ads.GoogleAds.V4.Errors;
using Google.Ads.GoogleAds.V4.Resources;
using Google.Ads.GoogleAds.V4.Services;

using System;

using static Google.Ads.GoogleAds.V4.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.AdGroupStatusEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.AdGroupTypeEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.WebpageConditionOperandEnum.Types;
using static Google.Ads.GoogleAds.V4.Resources.Campaign.Types;

namespace Google.Ads.GoogleAds.Examples.V4
{
    /// <summary>
    /// This code example adds dynamic search ads to a given ad group. To list
    /// ad groups, run GetAdGroups.cs.
    /// </summary>
    public class AddDynamicSearchAds : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddDynamicSearchAds codeExample =
                new AddDynamicSearchAds();
            Console.WriteLine(codeExample.Description);

            //The customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            //The ad group ID that contains the ad.
            long adGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, adGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds dynamic search ads to a given ad group. To list ad groups, " +
            "run GetAdGroups.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ad group ID to which ads are added.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId)
        {
            try
            {
                string budgetResourceName = AddCampaignBudget(client, customerId);
                string campaignResourceName = AddCampaign(client, customerId, budgetResourceName);
                string adGroupResourceName = AddAdGroup(client, customerId, campaignResourceName);
                AddExpandedDSA(client, customerId, adGroupResourceName);
                AddWebPageCriteria(client, customerId, adGroupResourceName);
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
        /// Adds a campaign budget.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>The campaign budget resource name.</returns>
        private static string AddCampaignBudget(GoogleAdsClient client, long customerId)
        {
            // Get the CampaignBudgetService.
            CampaignBudgetServiceClient campaignBudgetService =
                client.GetService(Services.V4.CampaignBudgetService);

            // Create the budget.
            CampaignBudget campaignBudget = new CampaignBudget()
            {
                Name = "Interplanetary Cruise Budget #" + ExampleUtilities.GetRandomString(),
                AmountMicros = 3_000_000,
                DeliveryMethod = BudgetDeliveryMethod.Standard
            };

            // Create the operation.
            CampaignBudgetOperation operation = new CampaignBudgetOperation()
            {
                Create = campaignBudget
            };

            // Add the campaign budget.
            MutateCampaignBudgetsResponse response =
                campaignBudgetService.MutateCampaignBudgets(customerId.ToString(),
                    new CampaignBudgetOperation[] { operation });
            // Display the result.

            string budgetResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Added budget with resource name '{budgetResourceName}'.");
            return budgetResourceName;
        }

        /// <summary>
        /// Adds a campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="budgetResourceName">The campaign budget resource name.</param>
        /// <returns>The campaign resource name.</returns>
        private static string AddCampaign(GoogleAdsClient client, long customerId,
            string budgetResourceName)
        {
            // Get the CampaignService.
            CampaignServiceClient campaignService = client.GetService(Services.V4.CampaignService);

            // Create the campaign.
            Campaign campaign = new Campaign()
            {
                Name = "Interplanetary Cruise #" + ExampleUtilities.GetRandomString(),
                AdvertisingChannelType = AdvertisingChannelType.Search,
                Status = CampaignStatus.Paused,
                ManualCpc = new ManualCpc(),
                CampaignBudget = budgetResourceName,

                // Enable the campaign for DSAs.
                DynamicSearchAdsSetting = new DynamicSearchAdsSetting()
                {
                    DomainName = "example.com",
                    LanguageCode = "en"
                },

                StartDate = DateTime.Now.AddDays(1).ToString("yyyyMMdd"),
                EndDate = DateTime.Now.AddDays(30).ToString("yyyyMMdd")
            };

            // Create the operation.
            CampaignOperation operation = new CampaignOperation()
            {
                Create = campaign
            };

            // Add the campaign.
            MutateCampaignsResponse response =
                campaignService.MutateCampaigns(customerId.ToString(),
                    new CampaignOperation[] { operation });

            // Displays the result.
            string campaignResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Added campaign with resource name '{campaignResourceName}'.");
            return campaignResourceName;
        }

        /// <summary>Adds an ad group.</summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignResourceName">The campaign resource name.</param>
        /// <returns>The ad group resource name.</returns>
        private static string AddAdGroup(GoogleAdsClient client, long customerId,
            string campaignResourceName)
        {
            // Get the AdGroupService.
            AdGroupServiceClient adGroupService = client.GetService(Services.V4.AdGroupService);

            // Create the ad group.
            AdGroup adGroup = new AdGroup()
            {
                Name = "Earth to Mars Cruises #" + ExampleUtilities.GetRandomString(),
                Campaign = campaignResourceName,
                Type = AdGroupType.SearchDynamicAds,
                Status = AdGroupStatus.Paused,
                TrackingUrlTemplate = "http://tracker.examples.com/traveltracker/{escapedlpurl}",
                CpcBidMicros = 50_000
            };

            // Create the operation.
            AdGroupOperation operation = new AdGroupOperation()
            {
                Create = adGroup
            };

            // Add the ad group.
            MutateAdGroupsResponse response =
                adGroupService.MutateAdGroups(customerId.ToString(),
                    new AdGroupOperation[] { operation });

            // Display the results.
            string adGroupResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Added ad group with resource name '{adGroupResourceName}'.");

            return adGroupResourceName;
        }

        /// <summary>Adds an expanded dynamic search ad.</summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupResourceName">The ad group resource name.</param>
        private static void AddExpandedDSA(GoogleAdsClient client, long customerId,
            string adGroupResourceName)
        {
            // Get the AdGroupAdService.
            AdGroupAdServiceClient adGroupAdService =
                client.GetService(Services.V4.AdGroupAdService);

            // Create an ad group ad.
            AdGroupAd adGroupAd = new AdGroupAd()
            {
                AdGroup = adGroupResourceName,
                Status = AdGroupAdStatus.Paused,

                // Set the ad as an expanded dynamic search ad.
                Ad = new Ad()
                {
                    ExpandedDynamicSearchAd = new ExpandedDynamicSearchAdInfo()
                    {
                        Description = "Buy tickets now!"
                    }
                }
            };

            // Create the operation.
            AdGroupAdOperation operation = new AdGroupAdOperation()
            {
                Create = adGroupAd
            };

            // Add the dynamic search ad.
            MutateAdGroupAdsResponse response = adGroupAdService.MutateAdGroupAds(
                customerId.ToString(), new AdGroupAdOperation[] { operation });

            // Display the response.
            Console.WriteLine($"Added ad group ad with resource name " +
                $"'{response.Results[0].ResourceName}'.");
        }

        /// <summary>Add webpage targeting criteria for the DSA ad group.</summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupResourceName">The resource name of the ad group for which targeting
        /// is aded.</param>
        private static void AddWebPageCriteria(GoogleAdsClient client, long customerId,
            string adGroupResourceName)
        {
            // Get the AdGroupCriterionService.
            AdGroupCriterionServiceClient adGroupCriterionService =
                client.GetService(Services.V4.AdGroupCriterionService);

            // Create the criterion.
            AdGroupCriterion adGroupCriterion = new AdGroupCriterion()
            {
                AdGroup = adGroupResourceName,
                CpcBidMicros = 1_000_000,
                Status = AdGroupCriterionStatus.Paused,

                // Set the webpage targeting criteria.
                Webpage = new WebpageInfo()
                {
                    CriterionName = "Special Offers",
                    Conditions =
                    {
                        // Adds the url targeting criteria.
                        new WebpageConditionInfo()
                        {
                            Operand = WebpageConditionOperand.Url,
                            Argument = "/specialoffers"
                        },
                        // Adds the page title criteria.
                        // The list of webpage targeting conditions are
                        // and-ed together when evaluated for targeting.
                        new WebpageConditionInfo()
                        {
                            Operand = WebpageConditionOperand.PageTitle,
                            Argument = "Special Offer"
                        }
                    }
                }
            };

            // Create the operation.
            AdGroupCriterionOperation operation = new AdGroupCriterionOperation()
            {
                Create = adGroupCriterion
            };

            // Add the webpage criteria.
            MutateAdGroupCriteriaResponse response =
                adGroupCriterionService.MutateAdGroupCriteria(
                    customerId.ToString(), new[] { operation });
            // Displays the results.
            Console.WriteLine($"Added ad group criterion with resource name " +
                $"'{response.Results[0].ResourceName}'");
        }
    }
}

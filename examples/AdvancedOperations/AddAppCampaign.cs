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
using Google.Ads.GoogleAds.V4.Common;
using Google.Ads.GoogleAds.V4.Errors;
using Google.Ads.GoogleAds.V4.Resources;
using Google.Ads.GoogleAds.V4.Services;

using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V4.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.AdGroupStatusEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.AdvertisingChannelSubTypeEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.AppCampaignAppStoreEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.AppCampaignBiddingStrategyGoalTypeEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.CriterionTypeEnum.Types;
using static Google.Ads.GoogleAds.V4.Resources.Campaign.Types;

namespace Google.Ads.GoogleAds.Examples.V4
{
    /// <summary>
    /// This code example adds a new App Campaign.
    /// </summary>
    public class AddAppCampaign : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddAppCampaign codeExample = new AddAppCampaign();
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
                return "This code example adds a new App Campaign.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            try
            {
                // Creates a budget for the campaign.
                string budgetResourceName = CreateBudget(client, customerId);

                // Creates the campaign.
                string campaignResourceName = CreateCampaign(client, customerId, budgetResourceName);

                // Sets campaign targeting.
                SetCampaignTargetingCriteria(client, customerId, campaignResourceName);

                // Creates an ad group.
                string adGroupResourceName = CreateAdGroup(client, customerId, campaignResourceName);

                // Creates an App ad.
                CreateAppAd(client, customerId, adGroupResourceName);
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
        /// Creates the budget for the campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>The resource name of the newly created campaign budget.</returns>
        private string CreateBudget(GoogleAdsClient client, long customerId)
        {
            // Get the BudgetService.
            CampaignBudgetServiceClient budgetService = client.GetService(
                Services.V4.CampaignBudgetService);

            // Creates a campaign budget.
            CampaignBudget budget = new CampaignBudget()
            {
                Name = "Interplanetary Cruise Budget #" + ExampleUtilities.GetRandomString(),
                DeliveryMethod = BudgetDeliveryMethod.Standard,
                AmountMicros = 50_000_000,
                // An App campaign cannot use a shared campaign budget.
                // explicitly_shared must be set to false.
                ExplicitlyShared = false
            };

            // Create the operation.
            CampaignBudgetOperation budgetOperation = new CampaignBudgetOperation()
            {
                Create = budget
            };

            // Create the campaign budget.
            MutateCampaignBudgetsResponse response = budgetService.MutateCampaignBudgets(
                customerId.ToString(), new CampaignBudgetOperation[] { budgetOperation });

            string budgetResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Created campaign budget with resource name " +
                $"'{budgetResourceName}'.");

            return budgetResourceName;
        }

        /// <summary>
        /// Creates an App campaign under the given customer ID.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="budgetResourceName">The budget resource name.</param>
        /// <returns>Resource name of the newly created campaign.</returns>
        private string CreateCampaign(GoogleAdsClient client, long customerId,
            string budgetResourceName)
        {
            // Get the CampaignService.
            CampaignServiceClient campaignService = client.GetService(Services.V4.CampaignService);

            // Create the campaign.
            Campaign campaign = new Campaign()
            {
                Name = "Interplanetary Cruise #" + ExampleUtilities.GetRandomString(),
                CampaignBudget = budgetResourceName,

                // Recommendation: Set the campaign to PAUSED when creating it to prevent
                // the ads from immediately serving. Set to ENABLED once you've added
                // targeting and the ads are ready to serve
                Status = CampaignStatus.Paused,

                // All App campaigns have an advertising_channel_type of
                // MULTI_CHANNEL to reflect the fact that ads from these campaigns are
                // eligible to appear on multiple channels.
                AdvertisingChannelType = AdvertisingChannelType.MultiChannel,
                AdvertisingChannelSubType = AdvertisingChannelSubType.AppCampaign,

                // Sets the target CPA to $1 / app install.
                //
                // campaign_bidding_strategy is a 'oneof' message so setting target_cpa
                // is mutually exclusive with other bidding strategies such as
                // manual_cpc, commission, maximize_conversions, etc.
                // See https://developers.google.com/google-ads/api/reference/rpc
                // under current version / resources / Campaign.
                TargetCpa = new TargetCpa()
                {
                    TargetCpaMicros = 1000000
                },

                // Sets the App campaign settings.
                AppCampaignSetting = new AppCampaignSetting()
                {
                    AppId = "com.google.android.apps.adwords",
                    AppStore = AppCampaignAppStore.GoogleAppStore,
                    // Optional: Optimize this campaign for getting new users for your app.
                    BiddingStrategyGoalType =
                        AppCampaignBiddingStrategyGoalType.OptimizeInstallsTargetInstallCost
                },

                // Optional: Set the start date.
                StartDate = DateTime.Now.AddDays(1).ToString("yyyyMMdd"),

                // Optional: Set the end date.
                EndDate = DateTime.Now.AddYears(1).ToString("yyyyMMdd"),
            };

            // Creates a campaign operation.
            CampaignOperation operation = new CampaignOperation()
            {
                Create = campaign
            };

            // Add the campaigns.
            MutateCampaignsResponse response = campaignService.MutateCampaigns(
                customerId.ToString(), new CampaignOperation[] { operation });

            // Display the results.
            string campaignResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Created App campaign with resource name '{campaignResourceName}'.");

            return campaignResourceName;
        }

        /// <summary>
        /// Sets campaign targeting criteria for a given campaign. Both location and language
        /// targeting are illustrated.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignResourceName">The resource name of the campaign to apply
        /// targeting to.</param>
        private void SetCampaignTargetingCriteria(GoogleAdsClient client, long customerId,
            string campaignResourceName)
        {
            // Get the CampaignCriterionService.
            CampaignCriterionServiceClient campaignCriterionService = client.GetService(
                Services.V4.CampaignCriterionService);

            List<CampaignCriterionOperation> operations = new List<CampaignCriterionOperation>();

            // Creates the location campaign criteria.
            // Besides using location_id, you can also search by location names from
            // GeoTargetConstantService.suggestGeoTargetConstants() and directly
            // apply GeoTargetConstant.resource_name here. An example can be found
            // in GetGeoTargetConstantByNames.cs.
            int[] locationIds = new int[]
            {
                21137, // California
                2484 // Mexico
            };

            foreach (int locationId in locationIds)
            {
                // Creates a campaign criterion.
                CampaignCriterion campaignCriterion = new CampaignCriterion()
                {
                    Campaign = campaignResourceName,
                    Type = CriterionType.Location,
                    Location = new LocationInfo()
                    {
                        GeoTargetConstant = ResourceNames.GeoTargetConstant(locationId)
                    }
                };

                // Creates a campaign criterion operation.
                CampaignCriterionOperation operation = new CampaignCriterionOperation()
                {
                    Create = campaignCriterion
                };

                operations.Add(operation);
            }

            // Creates the language campaign criteria.
            int[] languageIds = new int[]
            {
                1000, // English
                1003 // Spanish
            };

            foreach (int languageId in languageIds)
            {
                // Creates a campaign criterion.
                CampaignCriterion campaignCriterion = new CampaignCriterion()
                {
                    Campaign = campaignResourceName,
                    Type = CriterionType.Language,
                    Language = new LanguageInfo()
                    {
                        LanguageConstant = ResourceNames.LanguageConstant(languageId)
                    }
                };

                // Creates a campaign criterion operation.
                CampaignCriterionOperation operation = new CampaignCriterionOperation()
                {
                    Create = campaignCriterion
                };

                operations.Add(operation);
            }

            // Submits the criteria operations and prints their information.
            MutateCampaignCriteriaResponse response =
                campaignCriterionService.MutateCampaignCriteria(customerId.ToString(), operations);
            Console.WriteLine($"Created {response.Results.Count} campaign criteria with " +
                $"resource names:");

            foreach (MutateCampaignCriterionResult result in response.Results)
            {
                Console.WriteLine(result.ResourceName);
            }
        }

        /// <summary>
        /// Creates an ad group for a given campaign
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignResourceName">Resource name of the campaign to add the ad group
        /// to.</param>
        /// <returns>The resource name of the newly created ad group.</returns>
        private string CreateAdGroup(GoogleAdsClient client, long customerId,
            string campaignResourceName)
        {
            // Get the AdGroupService.
            AdGroupServiceClient adGroupService = client.GetService(Services.V4.AdGroupService);

            // Creates an ad group.
            // Note that the ad group type must not be set.
            // Since the advertising_channel_sub_type is APP_CAMPAIGN,
            //   1. you cannot override bid settings at the ad group level.
            //   2. you cannot add ad group criteria.
            AdGroup adGroup = new AdGroup()
            {
                Name = $"Earth to Mars Cruises #{ExampleUtilities.GetRandomString()}",
                Status = AdGroupStatus.Enabled,
                Campaign = campaignResourceName
            };

            // Creates an ad group operation.
            // Create the operation.
            AdGroupOperation operation = new AdGroupOperation()
            {
                Create = adGroup
            };

            // Submits the ad group operation to add the ad group and prints the results.
            MutateAdGroupsResponse response =
                adGroupService.MutateAdGroups(customerId.ToString(), new[] { operation });

            // Prints and returns the ad group resource name.
            string adGroupResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Created an ad group with resource name '{adGroupResourceName}'.");
            return adGroupResourceName;
        }

        /// <summary>
        /// Creates an App ad for a given ad group.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupResourceName">The resource name of the ad group to add the App
        /// ad to.</param>
        private void CreateAppAd(GoogleAdsClient client, long customerId,
                    string adGroupResourceName)
        {
            // Get the AdGroupAdService.
            AdGroupAdServiceClient adGroupAdService = client.GetService(
                Services.V4.AdGroupAdService);

            // Creates an ad group ad.
            AdGroupAd adGroupAd = new AdGroupAd
            {
                AdGroup = adGroupResourceName,
                Status = AdGroupAdStatus.Enabled,
                Ad = new Ad
                {
                    AppAd = new AppAdInfo
                    {
                        Headlines = {
                            new AdTextAsset()
                            {
                                Text = "A cool puzzle game"
                            },
                            new AdTextAsset()
                            {
                                Text = "Remove connected blocks"
                            },
                        },
                        Descriptions = {
                            new AdTextAsset()
                            {
                                Text = "3 difficulty levels"
                            },
                            new AdTextAsset()
                            {
                                Text = "4 colorful fun skins"
                            }
                        },
                        // Optional: You can set up to 20 image assets for your campaign.
                        //Images =
                        //{
                        //    new AdImageAsset()
                        //    {
                        //        Asset = ResourceNames.Asset(customerId, assetId)
                        //    }
                        //}
                    }
                }
            };

            // Create the operation.
            AdGroupAdOperation operation = new AdGroupAdOperation
            {
                Create = adGroupAd
            };

            // Submits the ad group ad operation to add the ad group ad and prints the results.
            MutateAdGroupAdsResponse response =
                adGroupAdService.MutateAdGroupAds(customerId.ToString(), new[] { operation });
            Console.WriteLine($"Created an ad group ad with ad with resource name " +
                $"'{response.Results[0].ResourceName}'.");
        }
    }
}

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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V7.Common;
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Resources;
using Google.Ads.GoogleAds.V7.Services;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V7.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V7.Enums.AdGroupStatusEnum.Types;
using static Google.Ads.GoogleAds.V7.Enums.AdvertisingChannelSubTypeEnum.Types;
using static Google.Ads.GoogleAds.V7.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V7.Enums.AssetTypeEnum.Types;
using static Google.Ads.GoogleAds.V7.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V7.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V7.Enums.LocationSourceTypeEnum.Types;
using static Google.Ads.GoogleAds.V7.Enums.OptimizationGoalTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// This example adds an Local campaign.
    /// Prerequisite: To create a Local campaign, you need to define the store locations you want
    /// to promote by linking your Google My Business account or selecting affiliate locations.
    /// More information about Local campaigns can be found at:
    /// https: //support.google.com/google-ads/answer/9118422.
    /// </summary>
    public class AddLocalCampaign : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddLocalCampaign"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID.")]
            public long CustomerId { get; set; }
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
                    // The Google Ads customer ID.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    return 0;
                });

            AddLocalCampaign codeExample = new AddLocalCampaign();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        private const string MARKETING_IMAGE_URL = "https://goo.gl/3b9Wfh";
        private const string LOGO_IMAGE_URL = "https://goo.gl/mtt54n";
        private const string YOUTUBE_VIDEO_ID = "t1fDo0VyeEo";

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example adds an Local campaign.\nPrerequisite: To create a Local campaign, " +
            "you need to define the store locations you want to promote by linking your " +
            "Google My Business account or selecting affiliate locations. More information " +
            "about Local campaigns can be found at: " +
            "https://support.google.com/google-ads/answer/9118422.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            try
            {
                // Create a budget for the campaign.
                string budgetResourceName = CreateCampaignBudget(client, customerId);

                // Create a campaign.
                string campaignResourceName = CreateCampaign(client, customerId,
                    budgetResourceName);

                // Create an ad group.
                string adGroupResourceName =
                    CreateAdGroup(client, customerId, campaignResourceName);

                // Create a Local ad.
                CreateLocalAd(client, customerId, adGroupResourceName);
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
        /// Creates a campaign budget.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <returns>The resource name of the newly created campaign budget.</returns>
        // [START add_local_campaign]
        private string CreateCampaignBudget(GoogleAdsClient client, in long customerId)
        {
            // Get the CampaignBudgetService client.
            CampaignBudgetServiceClient campaignBudgetServiceClient =
                client.GetService(Services.V7.CampaignBudgetService);

            // Create a campaign budget object.
            CampaignBudget campaignBudget = new CampaignBudget
            {
                Name = $"Interplanetary Cruise Budget #{ExampleUtilities.GetRandomString()}",
                AmountMicros = 50000000,
                DeliveryMethod = BudgetDeliveryMethod.Standard,
                // A Local campaign cannot use a shared campaign budget.
                ExplicitlyShared = false
            };

            // Create a campaign budget operation.
            CampaignBudgetOperation campaignBudgetOperation = new CampaignBudgetOperation
            {
                Create = campaignBudget
            };

            // Issue a mutate request to add the campaign budget, then print and return the
            // resulting budget's resource name.
            MutateCampaignBudgetsResponse campaignBudgetsResponse =
                campaignBudgetServiceClient.MutateCampaignBudgets(customerId.ToString(),
                    new[] { campaignBudgetOperation });

            string campaignBudgetResourceName =
                campaignBudgetsResponse.Results.First().ResourceName;
            Console.WriteLine(
                $"Created campaign budget with resource name '{campaignBudgetResourceName}'.");

            return campaignBudgetResourceName;
        }
        // [END add_local_campaign]

        /// <summary>
        /// Creates a Local campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="budgetResourceName">The resource name of the budget to use with the new
        ///     campaign.</param>
        /// <returns>The resource name of the newly created campaign.</returns>
        // [START add_local_campaign_1]
        private string CreateCampaign(GoogleAdsClient client, long customerId,
            string budgetResourceName)
        {
            // Get the CampaignService client.
            CampaignServiceClient campaignServiceClient =
                client.GetService(Services.V7.CampaignService);

            // Create a campaign object.
            Campaign campaign = new Campaign
            {
                Name = $"Interplanetary Cruise Local #{ExampleUtilities.GetRandomString()}",
                CampaignBudget = budgetResourceName,
                // Recommendation: Set the campaign to PAUSED when creating it to prevent the ads
                // from immediately serving. Set to ENABLED once you've added targeting and the ads
                // are ready to serve.
                Status = CampaignStatus.Paused,
                // All Local campaigns have an advertisingChannelType of LOCAL and
                // advertisingChannelSubtype of LOCAL_CAMPAIGN.
                AdvertisingChannelType = AdvertisingChannelType.Local,
                AdvertisingChannelSubType = AdvertisingChannelSubType.LocalCampaign,
                // Bidding strategy must be set directly on the campaign.Setting a portfolio bidding
                // strategy by resource name is not supported. Maximize conversion value is the only
                // strategy supported for Local campaigns. An optional ROAS (Return on Advertising
                // Spend) can be set for MaximizeConversionValue. The ROAS value must be specified
                // as a ratio in the API. It is calculated by dividing "total value" by
                // "total spend". For more information on maximize conversion value, see the support
                // article: http://support.google.com/google-ads/answer/7684216.
                MaximizeConversionValue = new MaximizeConversionValue
                {
                    TargetRoas = 3.5
                },
                // Configure the Local campaign setting.
                LocalCampaignSetting = new Campaign.Types.LocalCampaignSetting
                {
                    LocationSourceType = LocationSourceType.GoogleMyBusiness
                },
                // Optimization goal setting is mandatory for Local campaigns. This example selects
                // driving directions and call clicks as goals.
                OptimizationGoalSetting = new Campaign.Types.OptimizationGoalSetting
                {
                    OptimizationGoalTypes =
                    {
                        OptimizationGoalType.CallClicks, OptimizationGoalType.DrivingDirections
                    }
                }
            };

            // Create a campaign operation.
            CampaignOperation campaignOperation = new CampaignOperation
            {
                Create = campaign
            };

            // Issue a mutate request to add the campaign, then print and return the resulting
            // campaign's resource name.
            MutateCampaignsResponse campaignResponse =
                campaignServiceClient.MutateCampaigns(customerId.ToString(),
                    new[] { campaignOperation });

            string campaignResourceName = campaignResponse.Results.First().ResourceName;
            Console.WriteLine("Created Local campaign with resource name " +
                $"'{campaignResourceName}'.");

            return campaignResourceName;
        }
        // [END add_local_campaign_1]

        /// <summary>
        /// Creates an ad group for the given campaign.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="campaignResourceName">The campaign resource name to which to attach the ad
        ///     group.</param>
        /// <returns>The string resource name for the newly created ad group.</returns>
        // [START add_local_campaign_2]
        private string CreateAdGroup(GoogleAdsClient client, long customerId,
            string campaignResourceName)
        {
            // Create the ad group service client.
            AdGroupServiceClient adGroupServiceClient =
                client.GetService(Services.V7.AdGroupService);

            // Create the ad group.
            // Note that the ad group type must not be set.
            // Since the advertisingChannelSubType is LOCAL_CAMPAIGN:
            //   1. you cannot override bid settings at the ad group level.
            //   2. you cannot add ad group criteria.
            AdGroup adGroup = new AdGroup()
            {
                Name = $"Earth to Mars Cruises #{ExampleUtilities.GetRandomString()}",
                Campaign = campaignResourceName,
                Status = AdGroupStatus.Enabled
            };

            // Create the ad group operation.
            AdGroupOperation adGroupOperation = new AdGroupOperation()
            {
                Create = adGroup
            };

            // Issue a mutate request to add the ad group, then print and return the resulting ad
            // group's resource name.
            MutateAdGroupsResponse adGroupResponse = adGroupServiceClient.MutateAdGroups(
                customerId.ToString(), new[] { adGroupOperation });

            string adGroupResourceName = adGroupResponse.Results.First().ResourceName;
            Console.WriteLine($"Created ad group with resource name '{adGroupResourceName}'.");
            return adGroupResourceName;
        }
        // [END add_local_campaign_2]

        /// <summary>
        /// Creates a Local ad for the given ad group.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="adGroupResourceName">The ad group resource name to which the ad will
        ///     belong.</param>
        // [START add_local_campaign_3]
        private void CreateLocalAd(GoogleAdsClient client, in long customerId,
            string adGroupResourceName)
        {
            // Create the ad group service client.
            AdGroupAdServiceClient adGroupAdServiceClient =
                client.GetService(Services.V7.AdGroupAdService);

            // Create an ad group ad.
            AdGroupAd adGroupAd = new AdGroupAd
            {
                AdGroup = adGroupResourceName,
                Status = AdGroupAdStatus.Enabled,
                Ad = new Ad
                {
                    FinalUrls = { "https://www.example.com" },
                    LocalAd = new LocalAdInfo
                    {
                        Headlines =
                        {
                            CreateAdTextAsset("Best Space Cruise Line"),
                            CreateAdTextAsset("Experience the Stars")
                        },
                        Descriptions =
                        {
                            CreateAdTextAsset("Buy your tickets now"),
                            CreateAdTextAsset("Visit the Red Planet")
                        },
                        CallToActions = { CreateAdTextAsset("Shop Now") },
                        // Set the marketing image and logo image assets.
                        MarketingImages =
                        {
                            new AdImageAsset
                            {
                                Asset = CreateImageAsset(client, customerId, MARKETING_IMAGE_URL,
                                    "Marketing Image")
                            }
                        },
                        LogoImages =
                        {
                            new AdImageAsset
                            {
                                Asset = CreateImageAsset(client, customerId, LOGO_IMAGE_URL,
                                    "Square Marketing Image")
                            }
                        },
                        // Set the video assets.
                        Videos =
                        {
                            new AdVideoAsset
                            {
                                Asset = CreateYoutubeVideoAsset(client, customerId,
                                    YOUTUBE_VIDEO_ID, "Local Campaigns")
                            }
                        }
                    }
                }
            };

            // Create an ad group ad operation.
            AdGroupAdOperation adGroupAdOperation = new AdGroupAdOperation
            {
                Create = adGroupAd
            };

            // Issue a mutate request to add the ad group ad and print the resulting ad group ad's
            // resource name.
            MutateAdGroupAdsResponse adGroupAdResponse =
                adGroupAdServiceClient.MutateAdGroupAds(customerId.ToString(),
                    new[] { adGroupAdOperation });

            Console.WriteLine("Created ad group ad with resource name " +
                $"'{adGroupAdResponse.Results.First().ResourceName}'.");
        }
        // [END add_local_campaign_3]

        /// <summary>
        /// Creates an ad text asset with the given text.
        /// </summary>
        /// <param name="text">The text to include in the asset.</param>
        /// <returns>A new ad text asset with the given text.</returns>
        private AdTextAsset CreateAdTextAsset(string text)
        {
            return new AdTextAsset
            {
                Text = text
            };
        }

        /// <summary>
        /// Creates an image asset.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="imageUrl">The URL of the image source.</param>
        /// <param name="imageName">The name to associate with the image asset.</param>
        /// <returns>A new ad text asset with the given text.</returns>
        // [START add_local_campaign_4]
        private string CreateImageAsset(GoogleAdsClient client, long customerId, string imageUrl,
            string imageName)
        {
            // Get the AssetService client.
            AssetServiceClient assetService = client.GetService(Services.V7.AssetService);

            // Creates an image asset.
            byte[] imageContent = MediaUtilities.GetAssetDataFromUrl(imageUrl, client.Config);
            Asset asset = new Asset
            {
                Name = imageName,
                Type = AssetType.Image,
                ImageAsset = new ImageAsset
                {
                    Data = ByteString.CopyFrom(imageContent),
                }
            };

            // Create an asset operation.
            AssetOperation assetOperation = new AssetOperation
            {
                Create = asset
            };

            // Issue a mutate request to add the asset, then print and return the resulting asset's
            // resource name.
            MutateAssetsResponse assetResponse =
                assetService.MutateAssets(customerId.ToString(), new[] { assetOperation });

            string assetResourceName = assetResponse.Results.First().ResourceName;
            Console.WriteLine("A new image asset has been added with resource name: " +
                $"'{assetResourceName}'.");

            return assetResourceName;
        }
        // [END add_local_campaign_4]

        /// <summary>
        /// Creates a YouTube video asset.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="youtubeVideoId">The YouTube video ID to be attached to the asset.</param>
        /// <param name="youtubeVideoName">The name to associate with the video.</param>
        /// <returns></returns>
        // [START add_local_campaign_5]
        private string CreateYoutubeVideoAsset(GoogleAdsClient client, in long customerId,
            string youtubeVideoId, string youtubeVideoName)
        {
            // Get the AssetService client.
            AssetServiceClient assetServiceClient = client.GetService(Services.V7.AssetService);

            // Create an asset.
            Asset asset = new Asset
            {
                Name = youtubeVideoName,
                Type = AssetType.YoutubeVideo,
                YoutubeVideoAsset = new YoutubeVideoAsset
                {
                    YoutubeVideoId = youtubeVideoId
                }
            };

            // Create an asset operation.
            AssetOperation assetOperation = new AssetOperation
            {
                Create = asset
            };

            // Issue a mutate request to add the asset, then print and return the resulting asset's
            // resource name.
            MutateAssetsResponse assetResponse =
                assetServiceClient.MutateAssets(customerId.ToString(), new[] { assetOperation });

            string assetResourceName = assetResponse.Results.First().ResourceName;
            Console.WriteLine("A new YouTube video asset has been added with resource name: " +
                $"'{assetResourceName}'.");

            return assetResourceName;
        }
        // [END add_local_campaign_5]
    }
}

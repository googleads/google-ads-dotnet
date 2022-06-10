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
using Google.Ads.Gax.Util;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V11.Common;
using Google.Ads.GoogleAds.V11.Errors;
using Google.Ads.GoogleAds.V11.Resources;
using Google.Ads.GoogleAds.V11.Services;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V11.Enums.AdGroupStatusEnum.Types;
using static Google.Ads.GoogleAds.V11.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V11.Enums.AssetTypeEnum.Types;
using static Google.Ads.GoogleAds.V11.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V11.Enums.DisplayAdFormatSettingEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V11
{
    /// <summary>
    /// This code example creates a shopping campaign associated with an existing Merchant Center
    /// account, along with a related ad group and responsive display ad, and targets a user list
    /// for remarketing purposes.
    /// </summary>
    public class AddMerchantCenterDynamicRemarketingCampaign : ExampleBase
    {
        /// <summary>
        /// Command line options for running the
        /// <see cref="AddMerchantCenterDynamicRemarketingCampaign"/> example.
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
            /// ID of the Merchant Center account to be associated with the new campaign.
            /// </summary>
            [Option("merchantCenterAccountId", Required = true, HelpText =
                "ID of the Merchant Center account to be associated with the new campaign.")]
            public long MerchantCenterAccountId { get; set; }

            /// <summary>
            /// ID of the campaign budget to be associated with the new campaign.
            /// </summary>
            [Option("campaignBudgetId", Required = true, HelpText =
                "ID of the campaign budget to be associated with the new campaign.")]
            public long CampaignBudgetId { get; set; }

            /// <summary>
            /// ID of the user list to be used for remarketing.
            /// </summary>
            [Option("userListId", Required = true, HelpText =
                "ID of the user list to be used for remarketing.")]
            public long UserListId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddMerchantCenterDynamicRemarketingCampaign codeExample =
                new AddMerchantCenterDynamicRemarketingCampaign();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId,
                options.MerchantCenterAccountId, options.CampaignBudgetId, options.UserListId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example creates a shopping campaign associated with an existing Merchant " +
            "Center account, along with a related ad group and responsive display ad, and " +
            "targets a user list for remarketing purposes.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="merchantCenterAccountId">ID of the Merchant Center account to be
        /// associated with the new campaign.</param>
        /// <param name="campaignBudgetId">ID of the campaign budget to be associated with the new
        /// campaign.</param>
        /// <param name="userListId">ID of the user list to be used for remarketing.</param>
        public void Run(GoogleAdsClient client, long customerId, long merchantCenterAccountId,
            long campaignBudgetId, long userListId)
        {
            try
            {
                // Creates a shopping campaign associated with a given Merchant Center account.
                string campaignResourceName = CreateCampaign(client, customerId,
                    merchantCenterAccountId, campaignBudgetId);

                // Creates an ad group for the campaign.
                string adGroupResourceName = CreateAdGroup(client, customerId,
                    campaignResourceName);

                // Creates a responsive display ad in the ad group.
                CreateAd(client, customerId, adGroupResourceName);

                // Targets a specific user list for remarketing.
                AttachUserList(client, customerId, adGroupResourceName, userListId);
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
        /// Creates a campaign linked to a Merchant Center product feed.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="merchantCenterAccountId">The Merchant Center account ID.</param>
        /// <param name="campaignBudgetId">The campaign budget ID.</param>
        /// <returns>The string resource name for the newly created campaign.</returns>
        // [START add_merchant_center_dynamic_remarketing_campaign_2]
        private string CreateCampaign(GoogleAdsClient client, long customerId,
            long merchantCenterAccountId, long campaignBudgetId)
        {
            // Creates the Campaign Service client.
            CampaignServiceClient campaignServiceClient =
                client.GetService(Services.V11.CampaignService);

            string budgetResourceName = ResourceNames.CampaignBudget(customerId, campaignBudgetId);

            // Creates the campaign.
            Campaign campaign = new Campaign()
            {
                Name = "Shopping campaign #" + ExampleUtilities.GetRandomString(),
                // Dynamic remarketing campaigns are only available on the Google Display Network.
                AdvertisingChannelType = AdvertisingChannelType.Display,
                Status = CampaignStatus.Paused,
                CampaignBudget = budgetResourceName,
                ManualCpc = new ManualCpc(),
                // The settings for the shopping campaign.
                // This connects the campaign to the Merchant Center account.
                ShoppingSetting = new Campaign.Types.ShoppingSetting()
                {
                    CampaignPriority = 0,
                    MerchantId = merchantCenterAccountId,
                    // Display Network campaigns do not support partition by country. The only
                    // supported value is "ZZ". This signals that products from all countries are
                    // available in the campaign. The actual products which serve are based on
                    // the products tagged in the user list entry.
                    SalesCountry = "ZZ",
                    EnableLocal = true
                }
            };

            // Creates the campaign operation.
            CampaignOperation operation = new CampaignOperation()
            {
                Create = campaign
            };

            // Adds the campaign.
            MutateCampaignsResponse response = campaignServiceClient.MutateCampaigns(customerId
                .ToString(), new[] { operation });
            string campaignResourceName = response.Results.First().ResourceName;
            Console.WriteLine($"Created campaign with resource name '{campaignResourceName}'.");
            return campaignResourceName;
        }
        // [END add_merchant_center_dynamic_remarketing_campaign_2]

        /// <summary>
        /// Creates an ad group for the remarketing campaign.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="campaignResourceName">The campaign resource name.</param>
        /// <returns>The string resource name for the newly created ad group.</returns>
        // [START add_merchant_center_dynamic_remarketing_campaign_1]
        private string CreateAdGroup(GoogleAdsClient client, long customerId,
            string campaignResourceName)
        {
            // Creates the ad group service client.
            AdGroupServiceClient adGroupServiceClient =
                client.GetService(Services.V11.AdGroupService);

            // Creates the ad group.
            AdGroup adGroup = new AdGroup()
            {
                Name = "Dynamic remarketing ad group",
                Campaign = campaignResourceName,
                Status = AdGroupStatus.Enabled
            };

            // Creates the ad group operation.
            AdGroupOperation operation = new AdGroupOperation()
            {
                Create = adGroup
            };

            // Adds the ad group.
            MutateAdGroupsResponse response = adGroupServiceClient.MutateAdGroups(
                customerId.ToString(), new[] { operation });

            string adGroupResourceName = response.Results.First().ResourceName;
            Console.WriteLine($"Created ad group with resource name '{adGroupResourceName}'.");
            return adGroupResourceName;
        }
        // [END add_merchant_center_dynamic_remarketing_campaign_1]

        /// <summary>
        /// Creates the responsive display ad.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="adGroupResourceName">The ad group resource name to receive the ad.</param>
        // [START add_merchant_center_dynamic_remarketing_campaign]
        private void CreateAd(GoogleAdsClient client, long customerId, string adGroupResourceName)
        {
            // Creates the ad group ad service client.
            AdGroupAdServiceClient adGroupAdServiceClient =
                client.GetService(Services.V11.AdGroupAdService);

            string marketingImageUrl = "https://gaagl.page.link/Eit5";
            string marketingImageName = "Marketing Image";
            string marketingImageResourceName =
                UploadAsset(client, customerId, marketingImageUrl, marketingImageName);
            string squareMarketingImageName = "Square Marketing Image";
            string squareMarketingImageUrl = "https://gaagl.page.link/bjYi";
            string squareMarketingImageResourceName =
                UploadAsset(client, customerId, squareMarketingImageUrl, squareMarketingImageName);

            // Creates the responsive display ad info object.
            ResponsiveDisplayAdInfo responsiveDisplayAdInfo = new ResponsiveDisplayAdInfo()
            {
                MarketingImages =
                {
                    new AdImageAsset()
                    {
                        Asset = marketingImageResourceName
                    }
                },
                SquareMarketingImages =
                {
                    new AdImageAsset()
                    {
                        Asset = squareMarketingImageResourceName
                    }
                },
                Headlines =
                {
                    new AdTextAsset()
                    {
                        Text = "Travel"
                    }
                },
                LongHeadline = new AdTextAsset()
                {
                    Text = "Travel the World"
                },
                Descriptions =
                {
                    new AdTextAsset()
                    {
                        Text = "Take to the air!"
                    }
                },
                BusinessName = "Interplanetary Cruises",
                // Optional: Call to action text.
                // Valid texts: https://support.google.com/adwords/answer/7005917
                CallToActionText = "Apply Now",
                // Optional: Sets the ad colors.
                MainColor = "#0000ff",
                AccentColor = "#ffff00",
                // Optional: Sets to false to strictly render the ad using the colors.
                AllowFlexibleColor = false,
                // Optional: Sets the format setting that the ad will be served in.
                FormatSetting = DisplayAdFormatSetting.NonNative,
                // Optional: Creates a logo image and sets it to the ad.
                /*
                    LogoImages = { new AdImageAsset()
                    {
                        Asset = "INSERT_LOGO_IMAGE_RESOURCE_NAME_HERE"
                    }}
                */
                // Optional: Creates a square logo image and sets it to the ad.
                /*
                    SquareLogoImages = { new AdImageAsset()
                    {
                        Asset = "INSERT_SQUARE_LOGO_IMAGE_RESOURCE_NAME_HERE"
                    }}
                */
            };

            // Creates the ad.
            Ad ad = new Ad()
            {
                ResponsiveDisplayAd = responsiveDisplayAdInfo,
                FinalUrls = { "http://www.example.com/" }
            };

            // Creates the ad group ad.
            AdGroupAd adGroupAd = new AdGroupAd()
            {
                AdGroup = adGroupResourceName,
                Ad = ad
            };

            // Creates the ad group ad operation.
            AdGroupAdOperation operation = new AdGroupAdOperation()
            {
                Create = adGroupAd
            };

            // Adds the ad group ad.
            MutateAdGroupAdsResponse response = adGroupAdServiceClient.MutateAdGroupAds
                (customerId.ToString(), new[] { operation });
            Console.WriteLine("Created ad group ad with resource name " +
                              $"'{response.Results.First().ResourceName}'.");
        }
        // [END add_merchant_center_dynamic_remarketing_campaign]

        /// <summary>
        /// Adds an image to the Google Ads account.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="imageUrl">The URL of the image.</param>
        /// <param name="assetName">The name of the asset.</param>
        /// <returns>The string resource name of the newly uploaded asset.</returns>
        private string UploadAsset(GoogleAdsClient client, long customerId,
            string imageUrl, string assetName)
        {
            // Creates the asset service client.
            AssetServiceClient assetServiceClient = client.GetService(Services.V11.AssetService);

            byte[] imageData = MediaUtilities.GetAssetDataFromUrl(imageUrl, client.Config);

            // Creates the image asset.
            Asset asset = new Asset()
            {
                Name = assetName,
                Type = AssetType.Image,
                ImageAsset = new ImageAsset()
                {
                    Data = ByteString.CopyFrom(imageData)
                }
            };

            // Creates the asset operation.
            AssetOperation operation = new AssetOperation()
            {
                Create = asset
            };

            // Adds the image asset.
            MutateAssetsResponse response = assetServiceClient.MutateAssets(customerId.ToString()
                , new[] { operation });
            string imageResourceName = response.Results.First().ResourceName;
            Console.WriteLine($"Created image asset with resource name '{imageResourceName}'.");
            return imageResourceName;
        }

        /// <summary>
        /// Targets the specified user list to the specified ad group.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="adGroupResourceName">The campaign resource name.</param>
        /// <param name="userListId">The user list ID.</param>
        // [START add_merchant_center_dynamic_remarketing_campaign_3]
        private void AttachUserList(GoogleAdsClient client, long customerId,
            string adGroupResourceName, long userListId)
        {
            // Creates the ad group criterion service client.
            AdGroupCriterionServiceClient adGroupCriterionServiceClient = client.GetService
                (Services.V11.AdGroupCriterionService);

            string userListResourceName = ResourceNames.UserList(customerId, userListId);

            // Creates the ad group criterion that targets the user list.
            AdGroupCriterion adGroupCriterion = new AdGroupCriterion()
            {
                AdGroup = adGroupResourceName,
                UserList = new UserListInfo()
                {
                    UserList = userListResourceName
                }
            };

            // Creates the ad group criterion operation.
            AdGroupCriterionOperation operation = new AdGroupCriterionOperation()
            {
                Create = adGroupCriterion
            };

            // Adds the ad group criterion.
            MutateAdGroupCriteriaResponse response = adGroupCriterionServiceClient
                .MutateAdGroupCriteria(customerId.ToString(), new[] { operation });
            Console.WriteLine("Created ad group criterion with resource name " +
                              $"'{response.Results.First().ResourceName}'.");
        }
        // [END add_merchant_center_dynamic_remarketing_campaign_3]
    }
}

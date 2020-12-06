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
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V6.Common;
using Google.Ads.GoogleAds.V6.Enums;
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;
using Google.Protobuf;
using System;
using System.Linq;
using static Google.Ads.GoogleAds.V6.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.AdvertisingChannelSubTypeEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.AssetTypeEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.MimeTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    ///
    /// This code example adds a Smart Display campaign, an ad group and a responsive display ad.
    /// More information about Smart Display campaigns can be found at
    /// https://support.google.com/google-ads/answer/7020281.
    /// </summary>
    public class AddSmartDisplayAd : ExampleBase
    {
        private const string MARKETING_IMAGE_URL = "https://goo.gl/3b9Wfh";
        private const int MARKETING_IMAGE_WIDTH = 600;
        private const int MARKETING_IMAGE_HEIGHT = 315;

        private const string SQUARE_MARKETING_IMAGE_URL = "https://goo.gl/mtt54n";
        private const int SQUARE_MARKETING_IMAGE_SIZE = 512;

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddSmartDisplayAd codeExample = new AddSmartDisplayAd();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a Smart Display campaign, an ad group and a responsive " +
            "display ad. More information about Smart Display campaigns can be found at " +
            "https://support.google.com/google-ads/answer/7020281.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            try
            {
                string budgetResourceName = CreateBudget(client, customerId);
                string campaignResourceName = CreateSmartDisplayCampaign(client, customerId,
                    budgetResourceName);
                string adGroupResourceName = CreateAdGroup(client, customerId,
                    campaignResourceName);
                string marketingImageAssetResourceName = UploadImageAsset(client, customerId,
                    MARKETING_IMAGE_URL, MARKETING_IMAGE_WIDTH, MARKETING_IMAGE_HEIGHT);
                string squareMarketingImageAssetResourceName = UploadImageAsset(client, customerId,
                    SQUARE_MARKETING_IMAGE_URL, SQUARE_MARKETING_IMAGE_SIZE,
                    SQUARE_MARKETING_IMAGE_SIZE);
                CreateResponsiveDisplayAd(client, customerId, adGroupResourceName,
                    marketingImageAssetResourceName, squareMarketingImageAssetResourceName);
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
        // [START AddSmartDisplayAd]
        private static string CreateBudget(GoogleAdsClient client, long customerId)
        {
            // Get the BudgetService.
            CampaignBudgetServiceClient budgetService = client.GetService(
                Services.V6.CampaignBudgetService);

            // Create the campaign budget.
            CampaignBudget budget = new CampaignBudget()
            {
                Name = "Interplanetary Cruise Budget #" + ExampleUtilities.GetRandomString(),
                DeliveryMethod = BudgetDeliveryMethod.Standard,
                AmountMicros = 500000
            };

            // Create the operation.
            CampaignBudgetOperation budgetOperation = new CampaignBudgetOperation()
            {
                Create = budget
            };

            // Create the campaign budget.
            MutateCampaignBudgetsResponse response = budgetService.MutateCampaignBudgets(
                customerId.ToString(), new CampaignBudgetOperation[] { budgetOperation });

            string budgetResourceName = response.Results.First().ResourceName;

            // Print out some information about the added budget.
            Console.WriteLine($"Added campaign budget with resource name = '{budgetResourceName}'.");

            return budgetResourceName;
        }
        // [END AddSmartDisplayAd]

        /// <summary>
        /// Creates the smart display campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="budgetResourceName">The campaign budget resource name.</param>
        /// <returns>Resource name of the newly created campaign.</returns>
        // [START AddSmartDisplayAd_1]
        private string CreateSmartDisplayCampaign(GoogleAdsClient client, long customerId,
            string budgetResourceName)
        {
            // Get the CampaignService.
            CampaignServiceClient campaignService = client.GetService(Services.V6.CampaignService);

            // Create the campaign.
            Campaign campaign = new Campaign()
            {
                Name = "Smart Display Campaign #" + ExampleUtilities.GetRandomString(),

                // Smart Display campaign requires the advertising_channel_type as 'DISPLAY'.
                AdvertisingChannelType = AdvertisingChannelType.Display,

                // Smart Display campaign requires the advertising_channel_sub_type as
                // 'DISPLAY_SMART_CAMPAIGN'.
                AdvertisingChannelSubType = AdvertisingChannelSubType.DisplaySmartCampaign,

                // Recommendation: Set the campaign to PAUSED when creating it to prevent
                // the ads from immediately serving. Set to ENABLED once you've added
                // targeting and the ads are ready to serve
                Status = CampaignStatus.Paused,

                // Smart Display campaign requires the TargetCpa bidding strategy.
                TargetCpa = new TargetCpa() { TargetCpaMicros = 5000000 },

                CampaignBudget = budgetResourceName,

                // Optional: Set the start date.
                StartDate = DateTime.Now.AddDays(1).ToString("yyyyMMdd"),

                // Optional: Set the end date.
                EndDate = DateTime.Now.AddYears(1).ToString("yyyyMMdd"),
            };

            // Create the operation.
            CampaignOperation operation = new CampaignOperation() { Create = campaign };

            // Add the campaign.
            MutateCampaignsResponse response = campaignService.MutateCampaigns(
                customerId.ToString(), new[] { operation });

            string campaignResourceName = response.Results.First().ResourceName;

            // Print out some information about the added campaign.
            Console.WriteLine($"Added campaign with resource name = '{campaignResourceName}'.");

            return campaignResourceName;
        }
        // [END AddSmartDisplayAd_1]

        /// <summary>
        /// Creates the ad group.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignResourceName">The campaign resource name.</param>
        /// <returns>The resource name of the newly created ad group.</returns>
        // [START AddSmartDisplayAd_2]
        private string CreateAdGroup(GoogleAdsClient client, long customerId,
            string campaignResourceName)
        {
            // Get the AdGroupService.
            AdGroupServiceClient adGroupService = client.GetService(Services.V6.AdGroupService);

            // Create the ad group.
            AdGroup adGroup = new AdGroup()
            {
                Name = $"Earth to Mars Cruises #{ExampleUtilities.GetRandomString()}",
                Status = AdGroupStatusEnum.Types.AdGroupStatus.Enabled,
                Campaign = campaignResourceName,
            };

            // Create the operation.
            AdGroupOperation operation = new AdGroupOperation()
            {
                Create = adGroup
            };

            // Create the ad groups.
            MutateAdGroupsResponse response = adGroupService.MutateAdGroups(
                customerId.ToString(), new[] { operation });

            string adGroupResourceName = response.Results.First().ResourceName;

            // Print out some information about the added ad group.
            Console.WriteLine($"Added ad group with resource name = '{adGroupResourceName}'.");

            return adGroupResourceName;
        }
        // [END AddSmartDisplayAd_2]

        /// <summary>
        /// Uploads the image asset.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="imageUrl">The image URL.</param>
        /// <param name="width">The image width in pixels.</param>
        /// <param name="height">The image height in pixels.</param>
        /// <returns></returns>
        // [START AddSmartDisplayAd_4]
        private static string UploadImageAsset(GoogleAdsClient client, long customerId,
            string imageUrl, long width, long height)
        {
            // Get the AssetServiceClient.
            AssetServiceClient assetService =
                client.GetService(Services.V6.AssetService);

            // Creates an image content.
            byte[] imageContent = MediaUtilities.GetAssetDataFromUrl(imageUrl, client.Config);

            // Creates an image asset.
            ImageAsset imageAsset = new ImageAsset()
            {
                Data = ByteString.CopyFrom(imageContent),
                FileSize = imageContent.Length,
                MimeType = MimeType.ImageJpeg,
                FullSize = new ImageDimension()
                {
                    HeightPixels = height,
                    WidthPixels = width,
                    Url = imageUrl
                }
            };

            // Creates an asset.
            Asset asset = new Asset()
            {
                // Optional: Provide a unique friendly name to identify your asset.
                // If you specify the name field, then both the asset name and the image being
                // uploaded should be unique, and should not match another ACTIVE asset in this
                // customer account.
                // Name = 'Jupiter Trip #' + ExampleUtilities.GetRandomString(),
                Type = AssetType.Image,
                ImageAsset = imageAsset
            };

            // Creates an asset operation.
            AssetOperation operation = new AssetOperation()
            {
                Create = asset
            };

            // Issues a mutate request to add the asset.
            MutateAssetsResponse response =
                assetService.MutateAssets(customerId.ToString(), new[] { operation });

            string assetResourceName = response.Results.First().ResourceName;

            // Print out some information about the added asset.
            Console.WriteLine($"Added asset with resource name = '{assetResourceName}'.");

            return assetResourceName;
        }
        // [END AddSmartDisplayAd_4]

        /// <summary>
        /// Creates the responsive display ad.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupResourceName">The ad group resource name.</param>
        /// <param name="marketingImageAssetResourceName">The marketing image asset resource
        /// name.</param>
        /// <param name="squareMarketingImageAssetResourceName">The square marketing image asset
        /// resource name.</param>
        /// <returns>Resource name of the newly created ad.</returns>
        // [START AddSmartDisplayAd_3]
        private static string CreateResponsiveDisplayAd(GoogleAdsClient client, long customerId,
            string adGroupResourceName, string marketingImageAssetResourceName,
            string squareMarketingImageAssetResourceName)
        {
            // Get the AdGroupAdServiceClient.
            AdGroupAdServiceClient adGroupAdService =
                client.GetService(Services.V6.AdGroupAdService);

            // Creates a responsive display ad info.
            ResponsiveDisplayAdInfo responsiveDisplayAdInfo = new ResponsiveDisplayAdInfo()
            {
                // Sets some basic required information for the responsive display ad.
                Headlines = { new AdTextAsset() { Text = "Travel" } },
                LongHeadline = new AdTextAsset() { Text = "Travel the World" },
                Descriptions = { new AdTextAsset() { Text = "Take to the air!" } },
                BusinessName = "Google",

                // Sets the marketing image and square marketing image to the previously created
                // image assets.
                MarketingImages =
                {
                    new AdImageAsset() { Asset = marketingImageAssetResourceName }
                },
                SquareMarketingImages =
                {
                    new AdImageAsset() { Asset = squareMarketingImageAssetResourceName }
                },

                // Optional: Sets call to action text, price prefix and promotion text.
                CallToActionText = "Shop Now",
                PricePrefix = "as low as",
                PromoText = "Free shipping!"
            };

            // Creates an ad group ad with the created responsive display ad info.
            AdGroupAd adGroupAd = new AdGroupAd()
            {
                AdGroup = adGroupResourceName,
                Status = AdGroupAdStatus.Paused,
                Ad = new Ad()
                {
                    FinalUrls = { "https://www.example.com" },
                    ResponsiveDisplayAd = responsiveDisplayAdInfo
                }
            };

            // Creates an ad group ad operation.
            AdGroupAdOperation operation = new AdGroupAdOperation()
            {
                Create = adGroupAd
            };

            // Issues a mutate request to add the ad.
            MutateAdGroupAdsResponse response =
                adGroupAdService.MutateAdGroupAds(customerId.ToString(), new[] { operation });

            string adGroupAdResourceName = response.Results.First().ResourceName;

            // Print out some information about the added ad group ad.
            Console.WriteLine($"Added ad group ad with resource name = '{adGroupAdResourceName}'.");

            return adGroupAdResourceName;
        }
        // [END AddSmartDisplayAd_3]
    }
}

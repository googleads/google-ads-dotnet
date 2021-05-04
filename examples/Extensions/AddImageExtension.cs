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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V7.Common;
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Resources;
using Google.Ads.GoogleAds.V7.Services;

using System;
using System.Linq;

using static Google.Ads.GoogleAds.V7.Enums.ExtensionTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// This code example adds an image extension to a campaign. To create a campaign, run
    /// AddCampaigns.cs. To create an image asset, run UploadImageAsset.cs.
    /// </summary>
    public class AddImageExtension : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddImageExtension codeExample = new AddImageExtension();
            Console.WriteLine(codeExample.Description);

            // The customer ID for which the call is made.
            int customerId = int.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the campaign to which image extensions are added.
            long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

            // ID of the image asset to be used to create the image extension.
            long imageAssetId = long.Parse("INSERT_IMAGE_ASSET_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, campaignId, imageAssetId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds an image extension to a campaign. To create a campaign, run " +
            "AddCampaigns.cs. To create an image asset, run UploadImageAsset.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to which sitelinks are added.</param>
        /// <param name="imageAssetId">ID of the image asset to be used for creating the extension.
        /// </param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId,
            long imageAssetId)
        {
            // Get the CampaignExtensionSettingServiceClient.
            CampaignExtensionSettingServiceClient campaignExtensionSettingService =
                client.GetService(Services.V7.CampaignExtensionSettingService);

            try
            {
                // Creates an image extension.
                string imageExtensionResourceName =
                    CreateImageExtension(client, customerId, imageAssetId);
                string campaignResourceName = ResourceNames.Campaign(customerId, campaignId);

                // Creates a CampaignExtensionSetting.
                CampaignExtensionSetting campaignExtensionSetting = new CampaignExtensionSetting()
                {
                    Campaign = campaignResourceName,
                    ExtensionType = ExtensionType.Image,
                    ExtensionFeedItems = { imageExtensionResourceName }
                };

                // Creates the operation.
                CampaignExtensionSettingOperation operation =
                    new CampaignExtensionSettingOperation()
                    {
                        Create = campaignExtensionSetting
                    };

                // Creates the campaign extension.
                MutateCampaignExtensionSettingsResponse response =
                    campaignExtensionSettingService.MutateCampaignExtensionSettings(
                        customerId.ToString(), new[] { operation });
                foreach (MutateCampaignExtensionSettingResult result in response.Results)
                {
                    Console.WriteLine($"Created campaign extension setting with resource " +
                        $"name '{result.ResourceName}'.");
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
        /// Creates an image extension.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="imageAssetId">The ID of the image asset to be used for creating image
        /// extension.</param>
        /// <returns>Resource name of the newly created image extension.</returns>
        private static string CreateImageExtension(GoogleAdsClient client, long customerId,
            long imageAssetId)
        {
            // Get the ExtensionFeedItemServiceClient.
            ExtensionFeedItemServiceClient extensionFeedItemService =
                client.GetService(Services.V7.ExtensionFeedItemService);

            // Creates the image feed item using the provided image.
            ImageFeedItem imageFeedItem = new ImageFeedItem()
            {
                ImageAsset = ResourceNames.Asset(customerId, imageAssetId)
            };

            // Creates an ExtensionFeedItem from the ImageFeedItem.
            ExtensionFeedItem extensionFeedItem = new ExtensionFeedItem()
            {
                ImageFeedItem = imageFeedItem
            };

            ExtensionFeedItemOperation operation = new ExtensionFeedItemOperation()
            {
                Create = extensionFeedItem
            };

            // Adds the ExtensionFeedItem.
            MutateExtensionFeedItemsResponse response =
                extensionFeedItemService.MutateExtensionFeedItems(customerId.ToString(),
                    new[] { operation });

            // Displays the result.
            string resourceName = response.Results.First().ResourceName;
            Console.WriteLine($"Created an image extension with resource name '{resourceName}'.");

            return resourceName;
        }
    }
}
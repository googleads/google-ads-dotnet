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

using System;
using System.Collections.Generic;
using System.Linq;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Resources;
using Google.Ads.GoogleAds.V7.Services;
using static Google.Ads.GoogleAds.V7.Enums.ExtensionTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// Updates the sitelink campaign extension setting to replace its extension feed items. Note
    /// that this doesn't completely remove your old extension feed items. See
    /// https://developers.google.com/google-ads/api/docs/extensions/extension-settings/overview
    /// for details.
    /// </summary>
    public class UpdateSitelinkCampaignExtensionSetting : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            UpdateSitelinkCampaignExtensionSetting codeExample =
                new UpdateSitelinkCampaignExtensionSetting();

            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The campaign ID.
            long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

            // The extension feed item IDs to replace.
            long[] feedItemIds =
            {
                long.Parse("INSERT_FEED_ITEM_ID_1_HERE"),
                long.Parse("INSERT_FEED_ITEM_ID_2_HERE")
            };

            codeExample.Run(new GoogleAdsClient(), customerId, campaignId, feedItemIds);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "Updates the sitelink campaign extension setting to replace its extension feed " +
            "items. Note that this doesn't completely remove your old extension feed items. See " +
            "https://developers.google.com/google-ads/api/docs/extensions/extension-settings/overview" +
            " for details.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">The campaign ID.</param>
        /// <param name="feedItemIds">The extension feed item IDs to replace.</param>
        // [START update_sitelink_campaign_extension_setting]
        public void Run(GoogleAdsClient client, long customerId, long campaignId,
            long[] feedItemIds)
        {
            // Get the CampaignExtensionSettingService.
            CampaignExtensionSettingServiceClient campaignExtensionSettingService =
                client.GetService(Services.V7.CampaignExtensionSettingService);

            // Transform the specified extension feed item IDs to an array of resource names.
            IEnumerable<string> extensionFeedItems = feedItemIds.Select(feedItemId =>
                ResourceNames.ExtensionFeedItem(customerId, feedItemId));

            // Create a campaign extension setting using the specified campaign ID and extension
            // feed item resource names.
            CampaignExtensionSetting campaignExtensionSetting = new CampaignExtensionSetting
            {
                ResourceName = ResourceNames.CampaignExtensionSetting(customerId, campaignId,
                    ExtensionType.Sitelink)
            };
            campaignExtensionSetting.ExtensionFeedItems.Add(extensionFeedItems);

            // Construct an operation that will update the extension feed item using the FieldMasks
            // utilities to derive the update mask. This mask tells the Google Ads API which
            // attributes of the extension feed item you want to change.
            CampaignExtensionSettingOperation campaignExtensionSettingOperation =
                new CampaignExtensionSettingOperation
                {
                    Update = campaignExtensionSetting,
                    UpdateMask = FieldMasks.AllSetFieldsOf(campaignExtensionSetting)
                };

            try
            {
                // Issue a mutate request to update the campaign extension setting.
                MutateCampaignExtensionSettingsResponse response =
                    campaignExtensionSettingService.MutateCampaignExtensionSettings
                        (customerId.ToString(), new[] {campaignExtensionSettingOperation});

                // Print the resource name of the updated campaign extension setting.
                Console.WriteLine("Updated a campaign extension setting with resource name " +
                    $"'{response.Results.First().ResourceName}'.");
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
        // [END update_sitelink_campaign_extension_setting]
    }
}

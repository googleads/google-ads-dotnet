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

using CommandLine;
using Google.Ads.Gax.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V10.Common;
using Google.Ads.GoogleAds.V10.Enums;
using Google.Ads.GoogleAds.V10.Errors;
using Google.Ads.GoogleAds.V10.Resources;
using Google.Ads.GoogleAds.V10.Services;
using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Ads.GoogleAds.Examples.V10
{
    /// <summary>
    /// This code example retrieves the full details of a Promotion Feed-based extension and
    /// creates a matching Promotion asset-based extension. The new Asset-based extension will
    /// then be associated with the same campaigns and ad groups as the original Feed-based
    /// extension.
    /// Once copied, you should remove the Feed-based extension; see
    /// RemoveEntireSitelinkCampaignExtensionSetting.cs for an example.
    /// </summary>
    public class MigratePromotionFeedToAsset : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="MigratePromotionFeedToAsset"/> example.
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
            /// ID of the extension feed item to migrate.
            /// </summary>
            [Option("feedItemId", Required = true, HelpText =
                "ID of the extension feed item to migrate.")]
            public long FeedItemId { get; set; }
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

                    // ID of the extension feed item to migrate.
                    options.FeedItemId = long.Parse("INSERT_FEED_ITEM_ID_HERE");

                    return 0;
                });

            MigratePromotionFeedToAsset codeExample = new MigratePromotionFeedToAsset();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.FeedItemId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example retrieves the full details of a Promotion Feed-based extension " +
            "and creates a matching Promotion asset-based extension. The new Asset-based " +
            "extension will then be associated with the same campaigns and ad groups as the " +
            "original Feed-based extension.\n" +
            "Once copied, you should remove the Feed-based extension; see " +
            "RemoveEntireSitelinkCampaignExtensionSetting.cs for an example.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="feedItemId">ID of the extension feed item to migrate.</param>
        public void Run(GoogleAdsClient client, long customerId, long feedItemId)
        {
            // Get the GoogleAdsService client.
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V10.GoogleAdsService);

            string extensionFeedItemResourceName =
                ResourceNames.ExtensionFeedItem(customerId, feedItemId);

            try
            {
                // Get the target extension feed item.
                ExtensionFeedItem extensionFeedItem =
                    GetExtensionFeedItem(googleAdsServiceClient, customerId, feedItemId);

                // Get all campaign IDs associated with the extension feed item.
                List<long> campaignIds = GetTargetedCampaignIds(googleAdsServiceClient, customerId,
                    extensionFeedItemResourceName);

                // Get all ad group IDs associated with the extension feed item.
                List<long> adGroupIds = GetTargetedAdGroupIds(googleAdsServiceClient, customerId,
                    extensionFeedItemResourceName);

                // Create a new Promotion asset that matches the target extension feed item.
                string promotionAssetResourceName = CreatePromotionAssetFromFeed(client,
                    customerId, extensionFeedItem);

                // Associate the new Promotion asset with the same campaigns as the original.
                AssociateAssetWithCampaigns(client, customerId, promotionAssetResourceName,
                    campaignIds);

                // Associate the new Promotion asset with the same ad groups as the original.
                AssociateAssetWithAdGroups(client, customerId, promotionAssetResourceName,
                    adGroupIds);
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Gets the requested Promotion-type extension feed item.
        ///
        /// Note that extension feed items pertain to feeds that were created by Google. Use
        /// FeedService to instead retrieve a user-created Feed.
        /// </summary>
        /// <param name="googleAdsServiceClient">An initialized Google Ads API Service
        /// client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="feedItemId">ID of the extension feed item to migrate.</param>
        /// <returns>The requested ExtensionFeedItem, or null if no matching item was
        /// found.</returns>
        private ExtensionFeedItem GetExtensionFeedItem(
            GoogleAdsServiceClient googleAdsServiceClient,
            long customerId, long feedItemId)
        {
            // Create a query that will retrieve the requested Promotion-type extension feed item
            // and ensure that all fields are populated.
            string extensionFeedItemQuery = $@"
                SELECT
                    extension_feed_item.id,
                    extension_feed_item.ad_schedules,
                    extension_feed_item.device,
                    extension_feed_item.status,
                    extension_feed_item.start_date_time,
                    extension_feed_item.end_date_time,
                    extension_feed_item.targeted_campaign,
                    extension_feed_item.targeted_ad_group,
                    extension_feed_item.promotion_feed_item.discount_modifier,
                    extension_feed_item.promotion_feed_item.final_mobile_urls,
                    extension_feed_item.promotion_feed_item.final_url_suffix,
                    extension_feed_item.promotion_feed_item.final_urls,
                    extension_feed_item.promotion_feed_item.language_code,
                    extension_feed_item.promotion_feed_item.money_amount_off.amount_micros,
                    extension_feed_item.promotion_feed_item.money_amount_off.currency_code,
                    extension_feed_item.promotion_feed_item.occasion,
                    extension_feed_item.promotion_feed_item.orders_over_amount.amount_micros,
                    extension_feed_item.promotion_feed_item.orders_over_amount.currency_code,
                    extension_feed_item.promotion_feed_item.percent_off,
                    extension_feed_item.promotion_feed_item.promotion_code,
                    extension_feed_item.promotion_feed_item.promotion_end_date,
                    extension_feed_item.promotion_feed_item.promotion_start_date,
                    extension_feed_item.promotion_feed_item.promotion_target,
                    extension_feed_item.promotion_feed_item.tracking_url_template
                FROM extension_feed_item
                WHERE
                    extension_feed_item.extension_type = 'PROMOTION'
                    AND extension_feed_item.id = {feedItemId}
                LIMIT 1";

            ExtensionFeedItem fetchedExtensionFeedItem = null;

            // Issue a search request to get the extension feed item contents.
            googleAdsServiceClient.SearchStream(customerId.ToString(), extensionFeedItemQuery,
                delegate (SearchGoogleAdsStreamResponse response)
                {
                    fetchedExtensionFeedItem = response.Results.First().ExtensionFeedItem;
                }
            );
            Console.WriteLine(
                $"Retrieved details for ad extension with ID {fetchedExtensionFeedItem.Id}.");

            // Create a query to retrieve any URL customer parameters attached to the feed item.
            string urlCustomParametersQuery = $@"
                SELECT feed_item.url_custom_parameters
                FROM feed_item
                WHERE feed_item.id = {feedItemId}";

            // Issue a search request to get any URL custom parameters.
            googleAdsServiceClient.SearchStream(customerId.ToString(), urlCustomParametersQuery,
                delegate (SearchGoogleAdsStreamResponse response)
                {
                    RepeatedField<CustomParameter> urlCustomParameters =
                        response.Results.First().FeedItem.UrlCustomParameters;
                    Console.WriteLine(
                        $"Retrieved {urlCustomParameters.Count} attached URL custom parameters.");
                    if (urlCustomParameters.Count > 0)
                    {
                        fetchedExtensionFeedItem.PromotionFeedItem.UrlCustomParameters.Add(
                            urlCustomParameters);
                    }
                }
            );

            return fetchedExtensionFeedItem;
        }

        /// <summary>
        /// Finds and returns all of the campaigns that are associated with the specified Promotion
        /// extension feed item.
        /// </summary>
        /// <param name="googleAdsServiceClient">An initialized Google Ads API Service
        /// client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="extensionFeedResourceName">ID of the extension feed item to
        /// migrate.</param>
        /// <returns>A list of campaign IDs.</returns>
        // [START migrate_promotion_feed_to_asset_1]
        private List<long> GetTargetedCampaignIds(GoogleAdsServiceClient googleAdsServiceClient,
            long customerId, string extensionFeedResourceName)
        {
            List<long> campaignIds = new List<long>();

            string query = @"
                SELECT campaign.id, campaign_extension_setting.extension_feed_items
                FROM campaign_extension_setting
                WHERE campaign_extension_setting.extension_type = 'PROMOTION'
                  AND campaign.status != 'REMOVED'";

            googleAdsServiceClient.SearchStream(customerId.ToString(), query,
                delegate (SearchGoogleAdsStreamResponse response)
                {
                    foreach (GoogleAdsRow googleAdsRow in response.Results)
                    {
                        // Add the campaign ID to the list of IDs if the extension feed item is
                        // associated with this extension setting.
                        if (googleAdsRow.CampaignExtensionSetting.ExtensionFeedItems.Contains(
                            extensionFeedResourceName))
                        {
                            Console.WriteLine(
                                $"Found matching campaign with ID {googleAdsRow.Campaign.Id}.");
                            campaignIds.Add(googleAdsRow.Campaign.Id);
                        }
                    }
                }
            );

            return campaignIds;
        }
        // [END migrate_promotion_feed_to_asset_1]

        /// <summary>
        /// Finds and returns all of the ad groups that are associated with the specified Promotion
        /// extension feed item.
        /// </summary>
        /// <param name="googleAdsServiceClient">An initialized Google Ads API Service
        /// client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="extensionFeedItemResourceName">Resource name of the extension feed item to
        /// migrate.</param>
        /// <returns>A list of ad group IDs.</returns>
        private List<long> GetTargetedAdGroupIds(
            GoogleAdsServiceClient googleAdsServiceClient, long customerId,
            string extensionFeedItemResourceName)
        {
            List<long> adGroupIds = new List<long>();

            string query = @"
                SELECT ad_group.id, ad_group_extension_setting.extension_feed_items
                FROM ad_group_extension_setting
                WHERE ad_group_extension_setting.extension_type = 'PROMOTION'
                  AND ad_group.status != 'REMOVED'";

            googleAdsServiceClient.SearchStream(customerId.ToString(), query,
                delegate (SearchGoogleAdsStreamResponse response)
                {
                    foreach (GoogleAdsRow googleAdsRow in response.Results)
                    {
                        // Add the ad group ID to the list of IDs if the extension feed item is
                        // associated with this extension setting.
                        if (googleAdsRow.AdGroupExtensionSetting.ExtensionFeedItems.Contains(
                            extensionFeedItemResourceName))
                        {
                            Console.WriteLine(
                                $"Found matching ad group with ID {googleAdsRow.AdGroup.Id}.");
                            adGroupIds.Add(googleAdsRow.AdGroup.Id);
                        }
                    }
                }
            );

            return adGroupIds;
        }

        /// <summary>
        /// Create a Promotion asset that copies values from the specified extension feed item.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="extensionFeedItem">The extension feed item to be migrated.</param>
        /// <returns>The resource name of the newly created Promotion asset.</returns>
        // [START migrate_promotion_feed_to_asset]
        private string CreatePromotionAssetFromFeed(GoogleAdsClient client, long customerId,
            ExtensionFeedItem extensionFeedItem)
        {
            // Get the Asset Service client.
            AssetServiceClient assetServiceClient = client.GetService(Services.V10.AssetService);

            PromotionFeedItem promotionFeedItem = extensionFeedItem.PromotionFeedItem;

            // Create the Promotion asset.
            Asset asset = new Asset
            {
                // Name field is optional.
                Name = $"Migrated from feed item #{extensionFeedItem.Id}",
                PromotionAsset = new PromotionAsset
                {
                    PromotionTarget = promotionFeedItem.PromotionTarget,
                    DiscountModifier = promotionFeedItem.DiscountModifier,
                    RedemptionStartDate = promotionFeedItem.PromotionStartDate,
                    RedemptionEndDate = promotionFeedItem.PromotionEndDate,
                    Occasion = promotionFeedItem.Occasion,
                    LanguageCode = promotionFeedItem.LanguageCode,
                },
                TrackingUrlTemplate = promotionFeedItem.TrackingUrlTemplate,
                FinalUrlSuffix = promotionFeedItem.FinalUrlSuffix
            };

            // Either PercentOff or MoneyAmountOff must be set.
            if (promotionFeedItem.PercentOff > 0)
            {
                // Adjust the percent off scale when copying.
                asset.PromotionAsset.PercentOff = promotionFeedItem.PercentOff / 100;
            }
            else
            {
                asset.PromotionAsset.MoneyAmountOff = new Money
                {
                    AmountMicros = promotionFeedItem.MoneyAmountOff.AmountMicros,
                    CurrencyCode = promotionFeedItem.MoneyAmountOff.CurrencyCode
                };
            }

            // Either PromotionCode or OrdersOverAmount must be set.
            if (!string.IsNullOrEmpty(promotionFeedItem.PromotionCode))
            {
                asset.PromotionAsset.PromotionCode = promotionFeedItem.PromotionCode;
            }
            else
            {
                asset.PromotionAsset.OrdersOverAmount = new Money
                {
                    AmountMicros = promotionFeedItem.OrdersOverAmount.AmountMicros,
                    CurrencyCode = promotionFeedItem.OrdersOverAmount.CurrencyCode
                };
            }

            // Set the start and end dates if set in the existing extension.
            if (extensionFeedItem.HasStartDateTime)
            {
                asset.PromotionAsset.StartDate = DateTime.Parse(extensionFeedItem.StartDateTime)
                    .ToString("yyyy-MM-dd");
            }

            if (extensionFeedItem.HasEndDateTime)
            {
                asset.PromotionAsset.EndDate = DateTime.Parse(extensionFeedItem.EndDateTime)
                    .ToString("yyyy-MM-dd");
            }

            asset.PromotionAsset.AdScheduleTargets.Add(extensionFeedItem.AdSchedules);
            asset.FinalUrls.Add(promotionFeedItem.FinalUrls);
            asset.FinalMobileUrls.Add(promotionFeedItem.FinalMobileUrls);
            asset.UrlCustomParameters.Add(promotionFeedItem.UrlCustomParameters);

            // Build an operation to create the Promotion asset.
            AssetOperation operation = new AssetOperation
            {
                Create = asset
            };

            // Issue the request and return the resource name of the new Promotion asset.
            MutateAssetsResponse response = assetServiceClient.MutateAssets(
                customerId.ToString(), new[] { operation });
            Console.WriteLine("Created Promotion asset with resource name " +
                $"{response.Results.First().ResourceName}");
            return response.Results.First().ResourceName;
        }
        // [END migrate_promotion_feed_to_asset]

        /// <summary>
        /// Associates the specified Promotion asset with the specified campaigns.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="promotionAssetResourceName">The string resource name of the Promotion
        /// Asset.</param>
        /// <param name="campaignIds">A list of campaign IDs with which the Asset should be
        /// associated.</param>
        // [START migrate_promotion_feed_to_asset_2]
        private void AssociateAssetWithCampaigns(GoogleAdsClient client, long customerId,
            string promotionAssetResourceName, List<long> campaignIds)
        {
            if (campaignIds.Count == 0)
            {
                Console.WriteLine("Asset was not associated with any campaigns.");
                return;
            }

            CampaignAssetServiceClient campaignAssetServiceClient = client.GetService(Services.V10
                .CampaignAssetService);

            List<CampaignAssetOperation> operations = new List<CampaignAssetOperation>();

            foreach (long campaignId in campaignIds)
            {
                operations.Add(new CampaignAssetOperation
                {
                    Create = new CampaignAsset
                    {
                        Asset = promotionAssetResourceName,
                        FieldType = AssetFieldTypeEnum.Types.AssetFieldType.Promotion,
                        Campaign = ResourceNames.Campaign(customerId, campaignId),
                    }
                });
            }

            MutateCampaignAssetsResponse response = campaignAssetServiceClient.MutateCampaignAssets(
                customerId.ToString(), operations);

            foreach (MutateCampaignAssetResult result in response.Results)
            {
                Console.WriteLine($"Created campaign asset with resource name " +
                    $"{result.ResourceName}.");
            }
        }
        // [END migrate_promotion_feed_to_asset_2]

        /// <summary>
        /// Associates the specified Promotion asset with the specified ad groups.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="promotionAssetResourceName">The string resource name of the Promotion
        /// Asset.</param>
        /// <param name="adGroupIds">A list of ad group IDs with which the Asset should be
        /// associated.</param>
        private void AssociateAssetWithAdGroups(GoogleAdsClient client, long customerId,
            string promotionAssetResourceName, List<long> adGroupIds)
        {
            if (adGroupIds.Count == 0)
            {
                Console.WriteLine("Asset was not associated with any ad groups.");
                return;
            }

            AdGroupAssetServiceClient adGroupAssetServiceClient = client.GetService(Services.V10
                .AdGroupAssetService);

            List<AdGroupAssetOperation> operations = new List<AdGroupAssetOperation>();

            foreach (long adGroupId in adGroupIds)
            {
                operations.Add(new AdGroupAssetOperation
                {
                    Create = new AdGroupAsset
                    {
                        Asset = promotionAssetResourceName,
                        FieldType = AssetFieldTypeEnum.Types.AssetFieldType.Promotion,
                        AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                    }
                });
            }

            MutateAdGroupAssetsResponse response = adGroupAssetServiceClient.MutateAdGroupAssets(
                customerId.ToString(), operations);

            foreach (MutateAdGroupAssetResult result in response.Results)
            {
                Console.WriteLine($"Created ad group asset with resource name " +
                    $"{result.ResourceName}.");
            }
        }
    }
}

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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V14.Errors;
using Google.Ads.GoogleAds.V14.Services;
using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V14.Enums.ExtensionTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V14
{
    /// <summary>
    /// Removes the entire sitelink campaign extension setting by removing both the sitelink
    /// campaign extension setting itself and its associated sitelink extension feed items. This
    /// requires two steps, since removing the campaign extension setting doesn't automatically
    /// remove its extension feed items.
    ///
    /// To make this example work with other types of extensions, find references to 'Sitelink' and
    /// replace it with the extension type you wish to remove.
    /// </summary>
    public class RemoveEntireSitelinkCampaignExtensionSetting : ExampleBase
    {
        /// <summary>
        /// Command line options for running the
        /// <see cref="RemoveEntireSitelinkCampaignExtensionSetting"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// ID of the campaign from which sitelinks will be removed.
            /// </summary>
            [Option("campaignId", Required = true, HelpText =
                "ID of the campaign from which sitelinks will be removed.")]
            public long CampaignId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            RemoveEntireSitelinkCampaignExtensionSetting codeExample =
                new RemoveEntireSitelinkCampaignExtensionSetting();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.CampaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "Removes the entire sitelink campaign extension setting by removing both the" +
            " sitelink campaign extension setting itself and its associated sitelink extension " +
            "feed items. This requires two steps, since removing the campaign extension setting " +
            "doesn't automatically remove its extension feed items.\n\n" +
            "To make this example work with other types of extensions, find " +
            "references to 'Sitelink' and replace it with the extension type you wish to remove.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="campaignId">ID of the campaign from which sitelinks will be removed.
        /// </param>
        // [START remove_entire_sitelink_campaign_extension_setting]
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            // Get the GoogleAdsService client.
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V14.GoogleAdsService);

            List<MutateOperation> mutateOperations = new List<MutateOperation>();

            try
            {
                // Create a mutate operation the contains the campaign extension setting operation
                // to remove the specified sitelink campaign extension setting.
                mutateOperations.Add(
                    CreateSitelinkCampaignExtensionSettingMutateOperation(customerId, campaignId));

                // Get all sitelink extension feed items of the specified campaign.
                List<string> extensionFeedItemResourceNames =
                    GetAllSitelinkExtensionFeedItems(googleAdsServiceClient, customerId,
                        campaignId);

                // Create mutate operations, each of which contains an extension feed item
                // operation to remove the specified extension feed items.
                mutateOperations.AddRange(CreateExtensionFeedItemMutateOperations(
                    extensionFeedItemResourceNames));

                // Issue a mutate request to remove the campaign extension setting and its
                // extension feed items.
                MutateGoogleAdsResponse mutateGoogleAdsResponse = googleAdsServiceClient.Mutate(
                    customerId
                        .ToString(), mutateOperations);
                RepeatedField<MutateOperationResponse> mutateOpResponses =
                    mutateGoogleAdsResponse.MutateOperationResponses;

                // Print the information on the removed campaign extension setting and its
                // extension feed items.
                // Each mutate operation response is returned in the same order as we passed its
                // corresponding operation. Therefore, the first belongs to the campaign setting
                // operation, and the rest belong to the extension feed item operations.
                Console.WriteLine("Removed a campaign extension setting with resource name: " +
                    $"'{mutateOpResponses.First().CampaignExtensionSettingResult.ResourceName}'.");
                foreach (MutateOperationResponse response in mutateOpResponses.Skip(1))
                {
                    Console.WriteLine("Removed an extension feed item with resource name: " +
                        $"'{response.ExtensionFeedItemResult.ResourceName}'.");
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
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument Exception:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
        // [END remove_entire_sitelink_campaign_extension_setting]

        /// <summary>
        /// Creates a mutate operation for the sitelink campaign extension setting that will be
        /// removed.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="campaignId">The campaign ID from which the sitelink campaign extension
        /// setting will be removed.</param>
        /// <returns>The mutate operation for the sitelink campaign extension setting.</returns>
        private MutateOperation CreateSitelinkCampaignExtensionSettingMutateOperation(
            in long customerId, in long campaignId)
        {
            // Construct the resource name of the campaign extension setting to remove.
            string campaignExtensionSettingResourceName = ResourceNames.CampaignExtensionSetting
                (customerId, campaignId, ExtensionType.Sitelink);
            Console.WriteLine($"***name: {campaignExtensionSettingResourceName}");

            // Create a campaign extension setting operation.
            CampaignExtensionSettingOperation campaignExtensionSettingOperation =
                new CampaignExtensionSettingOperation
                {
                    Remove = campaignExtensionSettingResourceName
                };

            // Create and return a mutate operation for the campaign extension setting operation.
            return new MutateOperation
            {
                CampaignExtensionSettingOperation = campaignExtensionSettingOperation
            };
        }

        /// <summary>
        /// Return all sitelink extension feed items associated to the specified campaign extension
        /// setting.
        /// </summary>
        /// <param name="googleAdsServiceClient">An initialized Google Ads API Service client.
        /// </param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="campaignId">The campaign ID from which to fetch sitelink extension feed
        /// items.</param>
        /// <returns>A list of resource names of extension feed items.</returns>
        // [START remove_entire_sitelink_campaign_extension_setting_1]
        private List<string> GetAllSitelinkExtensionFeedItems(
            GoogleAdsServiceClient googleAdsServiceClient, in long customerId, in long campaignId)
        {
            // Create a query that retrieves all campaigns.
            string query = $@"
                SELECT
                  campaign_extension_setting.campaign,
                  campaign_extension_setting.extension_type,
                  campaign_extension_setting.extension_feed_items
                FROM campaign_extension_setting
                WHERE
                  campaign_extension_setting.campaign =
                      '{ResourceNames.Campaign(customerId, campaignId)}'
                  AND campaign_extension_setting.extension_type = 'SITELINK'";

            // Issue a search stream request, then iterate over all responses.
            // Print out and store in a list each extension feed item's resource name.
            List<string> extensionFeedItemResourceNames = new List<string>();
            googleAdsServiceClient.SearchStream(customerId.ToString(), query,
                delegate (SearchGoogleAdsStreamResponse resp)
                {
                    foreach (GoogleAdsRow googleAdsRow in resp.Results)
                    {
                        foreach (string extensionFeedItemResourceName in googleAdsRow
                            .CampaignExtensionSetting.ExtensionFeedItems)
                        {
                            extensionFeedItemResourceNames.Add(extensionFeedItemResourceName);
                            Console.WriteLine("Extension feed item with resource name " +
                                $"'{extensionFeedItemResourceName}' was found.");
                        }
                    }
                }
            );

            if (!extensionFeedItemResourceNames.Any())
            {
                throw new ArgumentException("The specified campaign does not contain a sitelink " +
                    "campaign extension setting.");
            }

            return extensionFeedItemResourceNames;
        }
        // [END remove_entire_sitelink_campaign_extension_setting_1]

        /// <summary>
        /// Creates mutate operations for the sitelink extension feed items that will be removed.
        /// </summary>
        /// <param name="extensionFeedItemResourceNames">The extension feed item resource
        ///     names.</param>
        /// <returns>An array of mutate operations for the extension feed items.</returns>
        private List<MutateOperation> CreateExtensionFeedItemMutateOperations(
            List<string> extensionFeedItemResourceNames)
        {
            return extensionFeedItemResourceNames
                .Select(extensionFeedItemResourceName =>
                    new ExtensionFeedItemOperation { Remove = extensionFeedItemResourceName })
                .Select(extensionFeedItemOperation =>
                    new MutateOperation {
                        ExtensionFeedItemOperation = extensionFeedItemOperation
                    })
                .ToList();
        }
    }
}

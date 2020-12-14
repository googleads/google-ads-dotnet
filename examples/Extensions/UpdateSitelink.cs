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
using System.Linq;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V6.Common;
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// Updates the sitelink extension feed item with the specified link text.
    /// </summary>
    public class UpdateSitelink : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            UpdateSitelink codeExample = new UpdateSitelink();

            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The feed item ID to update.
            long feedItemId = long.Parse("INSERT_FEED_ITEM_ID_HERE");

            // The new sitelink text.
            string sitelinkText = "INSERT_SITELINK_TEXT_HERE";

            codeExample.Run(new GoogleAdsClient(), customerId, feedItemId, sitelinkText);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "Updates the sitelink extension feed item with the specified link text.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="feedItemId">The feed item ID to update.</param>
        /// <param name="sitelinkText">The new sitelink text.</param>
        // [START UpdateSitelink]
        public void Run(GoogleAdsClient client, long customerId, long feedItemId,
            string sitelinkText)
        {
            // Get the ExtensionFeedItemService.
            ExtensionFeedItemServiceClient extensionFeedItemService =
                client.GetService(Services.V6.ExtensionFeedItemService);

            // Create an extension feed item using the specified feed item ID and sitelink text.
            ExtensionFeedItem extensionFeedItem = new ExtensionFeedItem
            {
                ResourceName = ResourceNames.ExtensionFeedItem(customerId, feedItemId),
                SitelinkFeedItem = new SitelinkFeedItem
                {
                    LinkText = sitelinkText
                }
            };

            // Construct an operation that will update the extension feed item using the FieldMasks
            // utilities to derive the update mask. This mask tells the Google Ads API which
            // attributes of the extension feed item you want to change.
            ExtensionFeedItemOperation extensionFeedItemOperation = new ExtensionFeedItemOperation
            {
                Update = extensionFeedItem,
                UpdateMask = FieldMasks.AllSetFieldsOf(extensionFeedItem)
            };

            try
            {
                // Issue a mutate request to update the extension feed item.
                MutateExtensionFeedItemsResponse response =
                    extensionFeedItemService.MutateExtensionFeedItems(
                        customerId.ToString(), new[] {extensionFeedItemOperation});

                // Print the resource name of the updated extension feed item.
                Console.WriteLine("Updated extension feed item with resource name " +
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
        // [END UpdateSitelink]
    }
}

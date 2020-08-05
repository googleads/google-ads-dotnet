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
using Google.Ads.GoogleAds.V4.Errors;
using Google.Ads.GoogleAds.V4.Resources;
using Google.Ads.GoogleAds.V4.Services;

namespace Google.Ads.GoogleAds.Examples.V4
{
    /// <summary>
    /// Adds a geo target to an extension feed item for targeting.
    /// </summary>
    public class AddGeoTarget : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddGeoTarget codeExample = new AddGeoTarget();

            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The feed item ID.
            long feedItemId = long.Parse("INSERT_FEED_ITEM_ID_HERE");

            // Geo target constant ID to add to the extension feed item.
            // A list of country codes can be referenced here:
            // https://developers.google.com/adwords/api/docs/appendix/geotargeting
            long? geoTargetConstantId = 2840; // USA

            codeExample.Run(new GoogleAdsClient(), customerId, feedItemId, geoTargetConstantId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "Adds a geo target to an extension feed item for " +
                                              "targeting.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="feedItemId">The feed item ID.</param>
        /// <param name="geoTargetConstantId">Geo target constant ID to add to the extension
        ///     feed item. Reverts to the United States (2840) if no value passed.</param>
        public void Run(GoogleAdsClient client, long customerId, long feedItemId,
            long? geoTargetConstantId)
        {
            // Get the ExtensionFeedItemServiceClient.
            ExtensionFeedItemServiceClient extensionFeedItemServiceClient =
                client.GetService(Services.V4.ExtensionFeedItemService);

            // Apply the default geo target constant ID (USA) if none was passed to the function.
            if (!geoTargetConstantId.HasValue)
            {
                geoTargetConstantId = 2840L;
            }

            // Creates an extension feed item using the specified feed item ID and geo target
            // constant ID for targeting.
            ExtensionFeedItem extensionFeedItem = new ExtensionFeedItem()
            {
                ResourceName = ResourceNames.ExtensionFeedItem(customerId, feedItemId),
                TargetedGeoTargetConstant = ResourceNames.GeoTargetConstant(geoTargetConstantId.Value)
            };

            // Constructs an operation that will update the extension feed item, using the
            // FieldMasks utility to derive the update mask. This mask tells the Google Ads API
            // which attributes of the extension feed item you want to change.
            ExtensionFeedItemOperation operation = new ExtensionFeedItemOperation()
            {
                Update = extensionFeedItem,
                UpdateMask = FieldMasks.AllSetFieldsOf(extensionFeedItem)
            };

            try
            {
                // Issues a mutate request to update the extension feed item.
                MutateExtensionFeedItemsResponse response =
                    extensionFeedItemServiceClient.MutateExtensionFeedItems(customerId.ToString(),
                        new[] {operation});

                // Prints the resource name of the updated extension feed item.
                Console.WriteLine("Updated extension feed item with resource name " +
                                  $"{response.Results.First().ResourceName}.");
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
    }
}

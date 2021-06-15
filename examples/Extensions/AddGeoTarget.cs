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
using Google.Ads.GoogleAds.V8.Errors;
using Google.Ads.GoogleAds.V8.Resources;
using Google.Ads.GoogleAds.V8.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Ads.GoogleAds.Examples.V8
{
    /// <summary>
    /// Adds a geo target to a extension feed item for targeting.
    /// </summary>
    public class AddGeoTarget : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddGeoTarget"/> example.
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
            /// The feed item ID.
            /// </summary>
            [Option("feedItemId", Required = true, HelpText =
                "The feed item ID.")]
            public long FeedItemId { get; set; }

            /// <summary>
            /// Geo target constant ID to add to the extension feed item. Reverts to the United
            /// States (2840) if no value passed.
            /// </summary>
            [Option("geoTargetConstantId", Required = false, HelpText =
                "Geo target constant ID to add to the extension feed item. Reverts to the United" +
                " States (2840) if no value passed.")]
            public long? GeoTargetConstantId { get; set; }
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
                    // The Google Ads customer ID for which the call is made.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // The feed item ID.
                    options.FeedItemId = long.Parse("INSERT_FEED_ITEM_ID_HERE");

                    // Geo target constant ID to add to the extension feed item.
                    // A list of country codes can be referenced here:
                    // https://developers.google.com/google-ads/api/reference/data/geotargets
                    options.GeoTargetConstantId = 2840; // USA

                    return 0;
                });

            AddGeoTarget codeExample = new AddGeoTarget();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.FeedItemId,
                options.GeoTargetConstantId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "Adds a geo target to an extension feed item for targeting.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="feedItemId">The feed item ID.</param>
        /// <param name="geoTargetConstantId">Geo target constant ID to add to the extension
        ///     feed item. Reverts to the United States (2840) if no value passed.</param>
        // [START add_geo_target]
        public void Run(GoogleAdsClient client, long customerId, long feedItemId,
            long? geoTargetConstantId)
        {
            // Get the ExtensionFeedItemServiceClient.
            ExtensionFeedItemServiceClient extensionFeedItemServiceClient =
                client.GetService(Services.V8.ExtensionFeedItemService);

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
                        new[] { operation });

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
        // [END add_geo_target]
    }
}

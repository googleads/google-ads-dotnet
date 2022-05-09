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
using Google.Ads.GoogleAds.V10.Common;
using Google.Ads.GoogleAds.V10.Errors;
using Google.Ads.GoogleAds.V10.Resources;
using Google.Ads.GoogleAds.V10.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Ads.GoogleAds.Examples.V10
{
    /// <summary>
    /// Updates the sitelink extension feed item with the specified link text.
    /// </summary>
    public class UpdateSitelink : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UpdateSitelink"/> example.
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
            /// The feed item ID to update.
            /// </summary>
            [Option("feedItemId", Required = true, HelpText =
                "The feed item ID to update.")]
            public long FeedItemId { get; set; }

            /// <summary>
            /// The new sitelink text.
            /// </summary>
            [Option("sitelinkText", Required = true, HelpText =
                "The new sitelink text.")]
            public string SitelinkText { get; set; }
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

                    // The feed item ID to update.
                    options.FeedItemId = long.Parse("INSERT_FEED_ITEM_ID_HERE");

                    // The new sitelink text.
                    options.SitelinkText = "INSERT_SITELINK_TEXT_HERE";

                    return 0;
                });

            UpdateSitelink codeExample = new UpdateSitelink();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.FeedItemId,
                options.SitelinkText);
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
        // [START update_sitelink]
        public void Run(GoogleAdsClient client, long customerId, long feedItemId,
            string sitelinkText)
        {
            // Get the ExtensionFeedItemService.
            ExtensionFeedItemServiceClient extensionFeedItemService =
                client.GetService(Services.V10.ExtensionFeedItemService);

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
                        customerId.ToString(), new[] { extensionFeedItemOperation });

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
        // [END update_sitelink]
    }
}

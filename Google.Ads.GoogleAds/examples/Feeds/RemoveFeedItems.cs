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
using Google.Ads.GoogleAds.V16.Errors;
using Google.Ads.GoogleAds.V16.Resources;
using Google.Ads.GoogleAds.V16.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Ads.GoogleAds.Examples.V16
{
    /// <summary>
    /// Removes feed items from a feed.
    /// </summary>
    public class RemoveFeedItems : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="RemoveFeedItems"/> example.
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
            /// The Feed ID to which the feed items belong.
            /// </summary>
            [Option("feedId", Required = true, HelpText =
                "The Feed ID to which the feed items belong.")]
            public long FeedId { get; set; }

            /// <summary>
            /// The IDs of the feed items to remove.
            /// </summary>
            [Option("feedItemIds", Required = true, HelpText =
                "The IDs of the feed items to remove.")]
            public IEnumerable<long> FeedItemIds { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            RemoveFeedItems codeExample = new RemoveFeedItems();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.FeedId,
                options.FeedItemIds.ToArray());
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "Removes feed items from a feed.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="feedId">The Feed ID to which the feed items belong.</param>
        /// <param name="feedItemIds">The IDs of the feed items to remove.</param>
        public void Run(GoogleAdsClient client, long customerId, long feedId, long[] feedItemIds)
        {
            FeedItemServiceClient feedItemServiceClient = client.GetService(
                Services.V16.FeedItemService);

            // Creates the remove operations.
            List<FeedItemOperation> operations = new List<FeedItemOperation>();

            foreach (long feedItemId in feedItemIds)
            {
                // Constructs the feed item resource name.
                string feedItemResourceName =
                    ResourceNames.FeedItem(customerId, feedId, feedItemId);

                // Constructs an operation that will remove the feed item based on the resource name
                // and adds it to the collection of operations.
                operations.Add(new FeedItemOperation
                {
                    Remove = feedItemResourceName
                });
            }

            try
            {
                // Issues a mutate request to remove the feed items.
                MutateFeedItemsResponse response =
                    feedItemServiceClient.MutateFeedItems(customerId.ToString(), operations);

                // Prints the resource names of the removed feed items.
                foreach (MutateFeedItemResult removedFeedItem in response.Results)
                {
                    Console.WriteLine("Removed feed item with resource name " +
                        $"'{removedFeedItem.ResourceName}'");
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
    }
}

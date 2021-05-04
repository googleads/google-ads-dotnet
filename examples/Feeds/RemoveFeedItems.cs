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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Services;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// Removes feed items from a feed.
    /// </summary>
    public class RemoveFeedItems : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            RemoveFeedItems codeExample = new RemoveFeedItems();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The Feed ID to which the feed items belong.
            long feedId = long.Parse("INSERT_FEED_ID_HERE");

            // The IDs of the feed items to remove.
            long[] feedItemIds =
            {
                long.Parse("INSERT_FEED_ITEM_ID_1_HERE"),
                long.Parse("INSERT_FEED_ITEM_ID_2_HERE")
            };

            codeExample.Run(new GoogleAdsClient(), customerId, feedId, feedItemIds);
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
                Services.V7.FeedItemService);

            // Creates the remove operations.
            List<FeedItemOperation> operations = new List<FeedItemOperation>();

            foreach (long feedItemId in feedItemIds)
            {
                // Constructs the feed item resource name.
                string feedItemResourceName =
                    ResourceNames.FeedItem(customerId, feedId, feedItemId);

                // Constructs an operation that will remove the feed item based on the resource
                // name and adds it to the collection of operations.
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

                //  Prints the resource names of the removed feed items.
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

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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Services;
using System;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example gets all feed items of the specified feed item set by fetching all
    /// feed item set links. To create a new feed item set, run CreateFeedItemSet.cs. To link
    /// a feed item to a feed item set, run LinkFeedItemSet.cs.
    /// </summary>
    public class GetFeedItemsOfFeedItemSet : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            GetFeedItemsOfFeedItemSet codeExample = new GetFeedItemsOfFeedItemSet();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the feed associated with the feed item set.
            long feedId = long.Parse("INSERT_FEED_ID_HERE");

            // ID of the feed item set.
            long feedItemSetId = long.Parse("FEED_ITEM_SET_ID");

            codeExample.Run(new GoogleAdsClient(), customerId, feedId, feedItemSetId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This code example gets all feed items of the " +
            "specified feed item set by fetching all feed item set links. To create a new feed " +
            "item set, run CreateFeedItemSet.cs. To link a feed item to a feed item set, " +
            "run LinkFeedItemSet.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="feedId">ID of the feed associated with the feed item set.</param>
        /// <param name="feedItemSetId">ID of the feed item set.</param>
        public void Run(GoogleAdsClient client, long customerId, long feedId, long feedItemSetId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V6.GoogleAdsService);

            string feedItemSetResourceName = ResourceNames.FeedItemSet(
                customerId, feedId, feedItemSetId);

            // Creates a query that retrieves all feed item set links associated with the
            // specified feed item set.
            string query = $@"
                SELECT
                    feed_item_set_link.feed_item
                FROM
                    feed_item_set_link
                WHERE
                    feed_item_set_link.feed_item_set = '{feedItemSetResourceName}'";

            try
            {
                Console.WriteLine("The feed items with the following resource names are linked " +
                    $"with the feed item set with ID {feedItemSetId}:");

                // Issue a search request.
                googleAdsService.SearchStream(customerId.ToString(), query,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        foreach (GoogleAdsRow googleAdsRow in resp.Results)
                        {
                            Console.WriteLine(googleAdsRow.FeedItemSetLink.FeedItem);
                        }
                    }
                );
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

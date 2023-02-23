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
using Google.Ads.GoogleAds.V13.Errors;
using Google.Ads.GoogleAds.V13.Resources;
using Google.Ads.GoogleAds.V13.Services;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V13
{
    /// <summary>
    /// This code example links the specified feed item to the specified feed item set. The
    /// specified feed item set must not be created as a dynamic set, i.e., neither
    /// <code>DynamicLocationSetFilter</code>
    /// nor
    /// <code>DynamicAffiliateLocationSetFilter</code>
    /// should be set. In addition, the feed item must belong to the feed associated with the feed
    /// item set.
    /// </summary>
    public class LinkFeedItemSet : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="LinkFeedItemSet"/> example.
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
            /// ID of the feed associated with the feed item set.
            /// </summary>
            [Option("feedId", Required = true, HelpText =
                "ID of the feed associated with the feed item set.")]
            public long FeedId { get; set; }

            /// <summary>
            /// ID of the feed item set.
            /// </summary>
            [Option("feedItemSetId", Required = true, HelpText =
                "ID of the feed item set.")]
            public long FeedItemSetId { get; set; }

            /// <summary>
            /// ID of the feed item to link to the set.
            /// </summary>
            [Option("feedItemId", Required = true, HelpText =
                "ID of the feed item to link to the set.")]
            public long FeedItemId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            LinkFeedItemSet codeExample = new LinkFeedItemSet();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.FeedId,
                options.FeedItemSetId, options.FeedItemId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This code example links the specified feed item " +
            "to the specified feed item set. The specified feed item set must not be created as " +
            "a dynamic set, i.e., neither <code>DynamicLocationSetFilter</code> nor " +
            "<code>DynamicAffiliateLocationSetFilter</code> should be set. In addition, the " +
            "feed item must belong to the feed associated with the feed item set.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="feedId">ID of the feed associated with the feed item set.</param>
        /// <param name="feedItemSetId">ID of the feed item set.</param>
        /// <param name="feedItemId">ID of the feed item to link to the set.</param>
        public void Run(GoogleAdsClient client, long customerId, long feedId, long feedItemSetId,
            long feedItemId)
        {
            // Get the FeedItemSetLinkService.
            FeedItemSetLinkServiceClient feedItemSetLinkService = client.GetService(
                Services.V13.FeedItemSetLinkService);

            // Creates a new feed item set link that binds the specified feed item set and feed
            // item.
            string feedItemSetResourceName = ResourceNames.FeedItemSet(customerId, feedId,
                feedItemSetId);
            string feedItemResourceName = ResourceNames.FeedItem(customerId, feedId, feedItemId);
            FeedItemSetLink feedItemSetLink = new FeedItemSetLink()
            {
                FeedItemSet = feedItemSetResourceName,
                FeedItem = feedItemResourceName
            };

            // Constructs a feed item set link operation.
            FeedItemSetLinkOperation operation = new FeedItemSetLinkOperation()
            {
                Create = feedItemSetLink
            };

            try
            {
                // Issues a mutate request to add the feed item set link on the server.
                MutateFeedItemSetLinksResponse response =
                    feedItemSetLinkService.MutateFeedItemSetLinks(customerId.ToString(),
                        new[] { operation });

                // Prints some information about the created feed item set link.
                foreach (MutateFeedItemSetLinkResult result in response.Results)
                {
                    Console.WriteLine($"Created a feed item set link with resource name " +
                        $"'{result.ResourceName}' that links feed item set " +
                        $"'{feedItemSetResourceName}' to feed item '{feedItemResourceName}'.");
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

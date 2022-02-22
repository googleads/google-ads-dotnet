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
using Google.Ads.GoogleAds.V10.Errors;
using Google.Ads.GoogleAds.V10.Resources;
using Google.Ads.GoogleAds.V10.Services;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V10
{
    /// <summary>
    /// This code example creates a new feed item set for a specified feed, which must belong to
    /// either a Google Ads location extension or an affiliate extension. This is equivalent to a
    /// "location group" in the Google Ads UI.See
    /// https://support.google.com/google-ads/answer/9288588 for more details.
    /// </summary>
    public class CreateFeedItemSet : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="CreateFeedItemSet"/> example.
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
            /// The Feed ID for creating the feed item set.
            /// </summary>
            [Option("feedId", Required = true, HelpText =
                "The Feed ID for creating the feed item set.")]
            public long FeedId { get; set; }
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

                    // The Feed ID for creating the feed item set.
                    options.FeedId = long.Parse("INSERT_FEED_ID_HERE");

                    return 0;
                });

            CreateFeedItemSet codeExample = new CreateFeedItemSet();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.FeedId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This code example creates a new feed item set for " +
            "a specified feed, which must belong to either a Google Ads location extension or " +
            "an affiliate extension. This is equivalent to a 'location group' in the Google " +
            "Ads UI. See https://support.google.com/google-ads/answer/9288588 for more details.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="feedId">The Feed ID for creating the feed item set.</param>
        public void Run(GoogleAdsClient client, long customerId, long feedId)
        {
            // Get the FeedItemSetService.
            FeedItemSetServiceClient feedItemService = client.GetService(
                Services.V10.FeedItemSetService);

            FeedItemSet feedItemSet = new FeedItemSet()
            {
                Feed = ResourceNames.Feed(customerId, feedId),
                DisplayName = "Feed Item Set #" + ExampleUtilities.GetRandomString(),
            };

            // A feed item set can be created as a dynamic set by setting an optional filter
            // field below. If your feed is a location extension, uncomment the code that calls
            // DynamicLocationSetFilter. If instead your feed is an affiliate extension,
            // uncomment the code that sets the DynamicAffiliateLocationSetFilter instead.

            // 1) Location extension.
            //feedItemSet.DynamicLocationSetFilter = new DynamicLocationSetFilter()
            //{
            //    // Dynamic location sets support filtering locations based on business name
            //    // and/or labels. If both are specified, the feed item set will only include
            //    // locations that satisfy both types of filters.
            //    BusinessNameFilter = new BusinessNameFilter()
            //    {
            //        BusinessName = "INSERT_YOUR_BUSINESS_NAME_HERE",
            //        FilterType = FeedItemSetStringFilterType.Exact,
            //    },
            //    // Adds a filter by feed item label resource name. If multiple labels are
            //    // specified, the feed item set will only include feed items with all of the
            //    // specified labels.
            //    Labels = { "INSERT_BUSINESS_LABEL_HERE" }
            //};

            // 2) Affiliate extension.
            //feedItemSet.DynamicAffiliateLocationSetFilter = new DynamicAffiliateLocationSetFilter()
            //{
            //    ChainIds = { long.Parse("INSERT_CHAIN_ID_HERE") }
            //};

            // Constructs an operation that will create a new feed item set.
            FeedItemSetOperation operation = new FeedItemSetOperation()
            {
                Create = feedItemSet
            };

            try
            {
                // Issues a mutate request to add the feed item set on the server.
                MutateFeedItemSetsResponse response =
                    feedItemService.MutateFeedItemSets(customerId.ToString(), new[] { operation });

                // Prints the resource names of the added feed item sets.
                foreach (MutateFeedItemSetResult addedFeedItemSet in response.Results)
                {
                    Console.WriteLine("Created a feed item set with resource name " +
                        $"'{addedFeedItemSet.ResourceName}'");
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

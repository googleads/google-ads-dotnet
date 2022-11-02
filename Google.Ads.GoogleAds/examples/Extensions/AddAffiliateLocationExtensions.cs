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
using Google.Ads.GoogleAds.V12.Common;
using Google.Ads.GoogleAds.V12.Errors;
using Google.Ads.GoogleAds.V12.Resources;
using Google.Ads.GoogleAds.V12.Services;
using Google.Api.Gax;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using static Google.Ads.GoogleAds.V12.Enums.AffiliateLocationFeedRelationshipTypeEnum.Types;
using static Google.Ads.GoogleAds.V12.Enums.AffiliateLocationPlaceholderFieldEnum.Types;
using static Google.Ads.GoogleAds.V12.Enums.FeedOriginEnum.Types;
using static Google.Ads.GoogleAds.V12.Enums.PlaceholderTypeEnum.Types;
using static Google.Ads.GoogleAds.V12.Resources.Feed.Types;

namespace Google.Ads.GoogleAds.Examples.V12
{
    /// <summary>
    /// This code example adds a feed that syncs retail addresses for a given retail chain ID and
    /// associates the feed with a campaign for serving affiliate location extensions.
    /// </summary>
    public class AddAffiliateLocationExtensions : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddAffiliateLocationExtensions"/>
        /// example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The customer ID for which the call is made.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// The retail chain ID.
            /// </summary>
            [Option("chainId", Required = true, HelpText =
                "The retail chain ID.")]
            public long ChainId { get; set; }

            /// <summary>
            /// The campaign ID for which the affiliate location extensions are added.
            /// </summary>
            [Option("campaignId", Required = true, HelpText =
                "The campaign ID for which the affiliate location extensions are added.")]
            public long CampaignId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddAffiliateLocationExtensions codeExample = new AddAffiliateLocationExtensions();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.ChainId, options.CampaignId);
        }

        // The maximum number of attempts to make to retrieve the FeedMappings before throwing an
        // exception.
        private const int MAX_FEEDMAPPING_RETRIEVAL_ATTEMPTS = 10;

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a feed that syncs retail addresses for a given retail chain " +
            "ID and associates the feed with a campaign for serving affiliate location extensions.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="chainId">The retail chain ID.</param>
        /// <param name="campaignId">
        /// The campaign ID for which the affiliate location extensions are added.
        /// </param>
        public void Run(GoogleAdsClient client, long customerId, long chainId, long campaignId)
        {
            try
            {
                string feedResourceName = CreateAffiliateLocationExtensionFeed(
                    client, customerId, chainId);
                // After the completion of the feed creation operation above the added feed will not
                // be available for usage in a campaign feed until the feed mappings are created. We
                // will wait with an exponential back-off policy until the feed mappings have been
                // created.
                FeedMapping feedMapping = WaitForFeedToBeReady(client, customerId,
                    feedResourceName);
                CreateCampaignFeed(client, customerId, campaignId, feedMapping,
                    feedResourceName, chainId);
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

        /// <summary>
        /// Creates the Affiliate Location Extension feed.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="chainId">The retail chain ID.</param>
        /// <returns>Resource name of the newly created Affiliate Location Extension feed.</returns>
        // [START add_affiliate_location_extensions]
        private static string CreateAffiliateLocationExtensionFeed(GoogleAdsClient client,
            long customerId, long chainId)
        {
            // Optional: Delete all existing location extension feeds. This is an optional step, and
            // is required for this code example to run correctly more than once.
            // 1. Google Ads only allows one location extension feed per email address.
            // 2. A Google Ads account cannot have a location extension feed and an affiliate
            // location extension feed at the same time.
            DeleteLocationExtensionFeeds(client, customerId);

            // Get the FeedServiceClient.
            FeedServiceClient feedService = client.GetService(Services.V12.FeedService);

            // Creates a feed that will sync to retail addresses for a given retail chain ID. Do not
            // add FeedAttributes to this object as Google Ads will add them automatically because
            // this will be a system generated feed.
            Feed feed = new Feed()
            {
                Name = "Affiliate Location Extension feed #" + ExampleUtilities.GetRandomString(),

                AffiliateLocationFeedData = new AffiliateLocationFeedData()
                {
                    ChainIds = { chainId },
                    RelationshipType = AffiliateLocationFeedRelationshipType.GeneralRetailer
                },
                // Since this feed's contents will be managed by Google, you must set its origin to
                // GOOGLE.
                Origin = FeedOrigin.Google
            };

            FeedOperation operation = new FeedOperation()
            {
                Create = feed
            };

            // Adds the feed.
            MutateFeedsResponse response =
                feedService.MutateFeeds(customerId.ToString(), new[] { operation });

            // Displays the results.
            string feedResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Affliate location extension feed created with resource name: " +
                $"{feedResourceName}.");
            return feedResourceName;
        }
        // [END add_affiliate_location_extensions]

        /// <summary>
        /// Deletes the old location extension feeds.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        private static void DeleteLocationExtensionFeeds(GoogleAdsClient client, long customerId)
        {
            // To delete a location extension feed, you need to
            // 1. Delete the CustomerFeed so that the location extensions from the feed stop
            // serving.
            // 2. Delete the feed so that Google Ads will no longer sync from the Business Profile
            // account.
            CustomerFeed[] oldCustomerFeeds =
                GetLocationExtensionCustomerFeeds(client, customerId);
            if (oldCustomerFeeds.Length != 0)
            {
                // Optional: You may also want to delete the CampaignFeeds and AdGroupFeeds.
                DeleteCustomerFeeds(client, customerId, oldCustomerFeeds);
            }
            Feed[] feeds = GetLocationExtensionFeeds(client, customerId);

            if (feeds.Length != 0)
            {
                RemoveFeeds(client, customerId, feeds);
            }
        }

        /// <summary>
        /// Gets the location extension feeds.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <returns>The list of location extension feeds.</returns>
        private static Feed[] GetLocationExtensionFeeds(GoogleAdsClient client, long customerId)
        {
            List<Feed> feeds = new List<Feed>();
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V12.GoogleAdsService);

            // Create the query.
            string query = $"SELECT feed.resource_name, feed.status, " +
                $"feed.places_location_feed_data.email_address, " +
                $"feed.affiliate_location_feed_data.chain_ids " +
                $" from feed where feed.status = ENABLED";

            PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> result =
                googleAdsService.Search(customerId.ToString(), query);

            foreach (GoogleAdsRow row in result)
            {
                // A location extension feed can be identified by checking whether the
                // PlacesLocationFeedData field is set (Location extensions feeds) or
                // AffiliateLocationFeedData field is set (Affiliate location extension feeds)
                Feed feed = row.Feed;
                if (feed.PlacesLocationFeedData != null || feed.AffiliateLocationFeedData != null)
                {
                    feeds.Add(feed);
                }
            }
            return feeds.ToArray();
        }

        /// <summary>
        /// Removes the feeds.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="feeds">The list of feeds to remove.</param>
        private static void RemoveFeeds(GoogleAdsClient client, long customerId, Feed[] feeds)
        {
            List<FeedOperation> operations = new List<FeedOperation>();
            foreach (Feed feed in feeds)
            {
                FeedOperation operation = new FeedOperation()
                {
                    Remove = feed.ResourceName,
                };
                operations.Add(operation);
            }
            FeedServiceClient feedService = client.GetService(
                Services.V12.FeedService);

            feedService.MutateFeeds(customerId.ToString(), operations.ToArray());
        }

        /// <summary>
        /// Gets the location extension customer feeds.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <returns>The list of location extension customer feeds.</returns>
        private static CustomerFeed[] GetLocationExtensionCustomerFeeds(GoogleAdsClient client,
            long customerId)
        {
            List<CustomerFeed> customerFeeds = new List<CustomerFeed>();
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V12.GoogleAdsService);

            // Create the query. A location extension customer feed can be identified by filtering
            // for placeholder_types=LOCATION (location extension feeds) or placeholder_types
            // =AFFILIATE_LOCATION (affiliate location extension feeds)
            string query = $"SELECT customer_feed.resource_name, customer_feed.feed, " +
                $"customer_feed.status, customer_feed.matching_function.function_string from " +
                $"customer_feed " +
                $"WHERE customer_feed.placeholder_types CONTAINS " +
                $"ANY(LOCATION, AFFILIATE_LOCATION) and customer_feed.status=ENABLED";

            PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> result =
                googleAdsService.Search(customerId.ToString(), query);

            foreach (GoogleAdsRow row in result)
            {
                customerFeeds.Add(row.CustomerFeed);
            }
            return customerFeeds.ToArray();
        }

        /// <summary>
        /// Deletes the customer feeds.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="customerFeeds">The customer feeds to delete.</param>
        private static void DeleteCustomerFeeds(GoogleAdsClient client, long customerId,
            CustomerFeed[] customerFeeds)
        {
            List<CustomerFeedOperation> operations = new List<CustomerFeedOperation>();
            foreach (CustomerFeed customerFeed in customerFeeds)
            {
                CustomerFeedOperation operation = new CustomerFeedOperation()
                {
                    Remove = customerFeed.ResourceName,
                };
                operations.Add(operation);
            }

            CustomerFeedServiceClient feedService = client.GetService(
                Services.V12.CustomerFeedService);

            feedService.MutateCustomerFeeds(customerId.ToString(), operations.ToArray());
        }

        /// <summary>
        /// Gets the Affiliate Location Extension feed mapping.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="feedResourceName">The feed resource name.</param>
        /// <returns>The newly created feed mapping.</returns>
        // [START add_affiliate_location_extensions_1]
        private static FeedMapping GetAffiliateLocationExtensionFeedMapping(GoogleAdsClient client,
            long customerId, string feedResourceName)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V12.GoogleAdsService);

            // Create the query.
            string query = $"SELECT feed_mapping.resource_name, " +
                $"feed_mapping.attribute_field_mappings, feed_mapping.status FROM " +
                $"feed_mapping WHERE feed_mapping.feed = '{feedResourceName}' and " +
                $"feed_mapping.status = ENABLED and feed_mapping.placeholder_type = " +
                "AFFILIATE_LOCATION LIMIT 1";

            // Issue a search request.
            PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> result =
                googleAdsService.Search(customerId.ToString(), query);

            // Display the results.
            GoogleAdsRow googleAdsRow = result.FirstOrDefault();
            return (googleAdsRow == null) ? null : googleAdsRow.FeedMapping;
        }
        // [END add_affiliate_location_extensions_1]

        /// <summary>
        /// Waits for the Affliate location extension feed to be ready.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="feedResourceName">Resource name of the feed.</param>
        // [START add_affiliate_location_extensions_2]
        private static FeedMapping WaitForFeedToBeReady(GoogleAdsClient client, long customerId,
            string feedResourceName)
        {
            int numAttempts = 0;
            int sleepSeconds = 0;

            while (numAttempts < MAX_FEEDMAPPING_RETRIEVAL_ATTEMPTS)
            {
                // Once you create a feed, Google's servers will setup the feed by creating feed
                // attributes and feed mapping. Once the feed mapping is created, it is ready to be
                // used for creating customer feed. This process is asynchronous, so we wait until
                // the feed mapping is created, peforming exponential backoff.
                FeedMapping feedMapping = GetAffiliateLocationExtensionFeedMapping(
                    client, customerId, feedResourceName);

                if (feedMapping == null)
                {
                    numAttempts++;
                    sleepSeconds = (int) (5 * Math.Pow(2, numAttempts));
                    Console.WriteLine($"Checked: #{numAttempts} time(s). Feed is not ready " +
                        $"yet. Waiting {sleepSeconds} seconds before trying again.");
                    Thread.Sleep(sleepSeconds * 1000);
                }
                else
                {
                    Console.WriteLine($"Feed {feedResourceName} is now ready.");
                    return feedMapping;
                }
            }
            throw new RpcException(new Status(StatusCode.DeadlineExceeded,
                $"Feed is not ready after {MAX_FEEDMAPPING_RETRIEVAL_ATTEMPTS}" +
                $" retries."));
        }
        // [END add_affiliate_location_extensions_2]

        /// <summary>
        /// Creates the campaign feed.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="campaignId">
        /// The campaign ID for which the affiliate location extensions are added.
        /// </param>
        /// <param name="feedMapping">
        /// The affliate location extension feedmapping for <paramref name="feedResourceName"/>
        /// </param>
        /// <param name="feedResourceName">The feed resource name.</param>
        /// <param name="chainId">The retail chain ID.</param>
        // [START add_affiliate_location_extensions_3]
        private static void CreateCampaignFeed(GoogleAdsClient client, long customerId,
            long campaignId, FeedMapping feedMapping, string feedResourceName, long chainId)
        {
            // Get the CampaignFeedService.
            CampaignFeedServiceClient campaignFeedService = client.GetService(
                Services.V12.CampaignFeedService);

            long attributeIdForChainId = GetAttributeIdForChainId(feedMapping);
            string feedId = FeedName.Parse(feedResourceName).FeedId;

            string matchingFunction =
                $"IN(FeedAttribute[{feedId}, {attributeIdForChainId}], {chainId})";
            // Adds a CampaignFeed that associates the feed with this campaign for the
            // AFFILIATE_LOCATION placeholder type.
            CampaignFeed campaignFeed = new CampaignFeed()
            {
                Feed = feedResourceName,
                PlaceholderTypes = { PlaceholderType.AffiliateLocation },
                MatchingFunction = new MatchingFunction()
                {
                    FunctionString = matchingFunction
                },
                Campaign = ResourceNames.Campaign(customerId, campaignId),
            };

            CampaignFeedOperation operation = new CampaignFeedOperation()
            {
                Create = campaignFeed
            };

            MutateCampaignFeedsResponse campaignFeedsResponse =
                campaignFeedService.MutateCampaignFeeds(
                    customerId.ToString(), new[] { operation });

            // Displays the result.
            string addedCampaignFeed = campaignFeedsResponse.Results[0].ResourceName;
            Console.WriteLine($"Campaign feed created with resource name: {addedCampaignFeed}.");
            return;
        }
        // [END add_affiliate_location_extensions_3]

        /// <summary>
        /// Gets the feed attribute ID for the retail chain Id.
        /// </summary>
        /// <param name="feedMapping">The feed mapping.</param>
        /// <returns>The feeed attribute ID.</returns>
        /// <exception cref="ArgumentException">
        /// Affiliate location feed mapping isn't setup correctly.
        /// </exception>
        // [START add_affiliate_location_extensions_4]
        public static long GetAttributeIdForChainId(FeedMapping feedMapping)
        {
            foreach (AttributeFieldMapping fieldMapping in feedMapping.AttributeFieldMappings)
            {
                if (fieldMapping.AffiliateLocationField ==
                    AffiliateLocationPlaceholderField.ChainId)
                {
                    return fieldMapping.FeedAttributeId;
                }
            }
            throw new ArgumentException("Affiliate location feed mapping isn't setup correctly.");
        }
        // [END add_affiliate_location_extensions_4]
    }
}

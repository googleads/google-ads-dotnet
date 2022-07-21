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
using Google.Ads.GoogleAds.V11.Common;
using Google.Ads.GoogleAds.V11.Errors;
using Google.Ads.GoogleAds.V11.Resources;
using Google.Ads.GoogleAds.V11.Services;
using Google.Api.Gax;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using static Google.Ads.GoogleAds.V11.Common.Operand.Types;
using static Google.Ads.GoogleAds.V11.Enums.FeedOriginEnum.Types;
using static Google.Ads.GoogleAds.V11.Enums.MatchingFunctionOperatorEnum.Types;
using static Google.Ads.GoogleAds.V11.Enums.PlaceholderTypeEnum.Types;
using static Google.Ads.GoogleAds.V11.Resources.Feed.Types;
using static Google.Ads.GoogleAds.V11.Resources.Feed.Types.PlacesLocationFeedData.Types;

namespace Google.Ads.GoogleAds.Examples.V11
{
    /// <summary>
    /// This code example adds a feed that syncs feed items from a Business Profile account
    /// and associates the feed with a customer.
    /// </summary>
    public class AddBusinessProfileLocationExtensions : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddBusinessProfileLocationExtensions"/>
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
            /// The Business Profile login email address.
            /// </summary>
            [Option("businessProfileEmailAddress", Required = true, HelpText =
                "The Business Profile login email address.")]
            public string BusinessProfileEmailAddress { get; set; }

            /// <summary>
            /// The Business Profile account identifier.
            /// </summary>
            [Option("businessAccountId", Required = false, HelpText =
                "The Business Profile account identifier.")]
            public string BusinessAccountId { get; set; }

            /// <summary>
            /// The OAuth2 access token for the Business Profile account.
            /// </summary>
            [Option("businessProfileAccessToken", Required = false, HelpText =
                "The OAuth2 access token for the Business Profile account.")]
            public string BusinessProfileAccessToken { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddBusinessProfileLocationExtensions codeExample =
                new AddBusinessProfileLocationExtensions();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId,
                options.BusinessProfileEmailAddress,
                options.BusinessAccountId, options.BusinessProfileAccessToken);
        }

        // The required scope for setting the OAuth info.
        private const string GOOGLE_ADS_SCOPE = "https://www.googleapis.com/auth/adwords";

        // The maximum number of attempts to make to retrieve the FeedMappings before throwing an
        // exception.
        private const int MAX_FEEDMAPPING_RETRIEVAL_ATTEMPTS = 10;

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a feed that syncs feed items from a Business Profile " +
            "account and associates the feed with a customer.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="businessProfileEmailAddress">The Business Profile login email address.
        /// </param>
        /// <param name="businessAccountId">The Business Profile account identifier.</param>
        /// <param name="businessProfileAccessToken">The OAuth2 access token for the Business
        /// Profile account.</param>
        public void Run(GoogleAdsClient client, long customerId,
            string businessProfileEmailAddress, string businessAccountId,
            string businessProfileAccessToken)
        {
            try
            {
                if (string.IsNullOrEmpty(businessProfileAccessToken))
                {
                    businessProfileAccessToken = client.Config.OAuth2AccessToken;
                }
                string businessProfileFeedResourceName = CreateBusinessProfileFeed(client, customerId, businessProfileEmailAddress,
                    businessAccountId, businessProfileAccessToken);
                // After the completion of the Feed ADD operation above the added feed will not be
                // available for usage in a CustomerFeed until the FeedMappings are created.
                // We will wait with an exponential back-off policy until the feedmappings have
                // been created.
                WaitForBusinessProfileFeedToBeReady(client, customerId, businessProfileFeedResourceName);
                CreateCustomerFeed(client, customerId, businessProfileFeedResourceName);
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
        /// Creates the Business Profile feed.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="businessProfileEmailAddress">The Business Profile login email address.
        /// </param>
        /// <param name="businessAccountId">The Business Profile account ID.</param>
        /// <param name="businessProfileAccessToken">The OAuth2 access token for the Business
        /// Profile account.</param>
        /// <returns>ID of the newly created Business Profile feed.</returns>
        // [START add_business_profile_location_extensions]
        private static string CreateBusinessProfileFeed(GoogleAdsClient client, long customerId,
            string businessProfileEmailAddress, string businessAccountId,
            string businessProfileAccessToken)
        {
            // Optional: Delete all existing location extension feeds. This is an optional step,
            // and is required for this code example to run correctly more than once.
            // 1. Google Ads only allows one location extension feed per email address.
            // 2. A Google Ads account cannot have a location extension feed and an affiliate
            // location extension feed at the same time.
            DeleteLocationExtensionFeeds(client, customerId);

            // Get the FeedServiceClient.
            FeedServiceClient feedService = client.GetService(Services.V11.FeedService);

            // Creates a feed that will sync to the Business Profile account specified by
            // businessProfileEmailAddress. Do not add FeedAttributes to this object as Google Ads
            // will add them automatically because this will be a system generated feed.
            Feed businessProfileFeed = new Feed()
            {
                Name = "Business Profile feed #" + ExampleUtilities.GetRandomString(),

                PlacesLocationFeedData = new PlacesLocationFeedData()
                {
                    EmailAddress = businessProfileEmailAddress,
                    // If the EmailAddress is for a Business Profile manager instead of the
                    // Business Profile account owner, then set BusinessAccountId to the Google+
                    // Page ID of a location for which the manager has access. This information is
                    // available through the Business Profile API. See
                    // https://developers.google.com/my-business/reference/rest/v4/accounts.locations#locationkey
                    // for details.
                    BusinessAccountId = string.IsNullOrEmpty(businessAccountId) ?
                        null : businessAccountId,
                    // Used to filter Business Profile listings by labels. If entries exist in
                    // label_filters, only listings that have at least one of the labels set are
                    // candidates to be synchronized into FeedItems. If no entries exist in
                    // label_filters, then all listings are candidates for syncing.
                    LabelFilters = { "Stores in New York" },
                    // Sets the authentication info to be able to connect Google Ads to the
                    // Business Profile account.
                    OauthInfo = new OAuthInfo()
                    {
                        HttpMethod = "GET",
                        HttpRequestUrl = GOOGLE_ADS_SCOPE,
                        HttpAuthorizationHeader = $"Bearer {businessProfileAccessToken}"
                    },
                },
                // Since this feed's feed items will be managed by Google,
                // you must set its origin to GOOGLE.
                Origin = FeedOrigin.Google
            };

            FeedOperation operation = new FeedOperation()
            {
                Create = businessProfileFeed
            };

            // Adds the feed.
            MutateFeedsResponse response =
                feedService.MutateFeeds(customerId.ToString(), new[] { operation });

            // Displays the results.
            string businessProfileFeedResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Business Profile feed created with resource name: " +
                $"{businessProfileFeedResourceName}.");
            return businessProfileFeedResourceName;
        }
        // [END add_business_profile_location_extensions]

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
                Services.V11.GoogleAdsService);

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
                Services.V11.FeedService);

            feedService.MutateFeeds(customerId.ToString(), operations.ToArray());
        }

        private static CustomerFeed[] GetLocationExtensionCustomerFeeds(GoogleAdsClient client,
            long customerId)
        {
            List<CustomerFeed> customerFeeds = new List<CustomerFeed>();
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V11.GoogleAdsService);

            // Create the query. A location extension customer feed can be identified by filtering
            // for placeholder_types=LOCATION (location extension feeds) or
            // placeholder_types =AFFILIATE_LOCATION (affiliate location extension feeds)
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
                Services.V11.CustomerFeedService);

            feedService.MutateCustomerFeeds(customerId.ToString(), operations.ToArray());
        }

        /// <summary>
        /// Gets the Business Profile feed mapping.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="businessProfileFeedResourceName">The Business Profile feed resource name.
        /// </param>
        /// <returns>The newly created feed mapping.</returns>
        // [START add_business_profile_location_extensions_1]
        private static FeedMapping GetBusinessProfileFeedMapping(GoogleAdsClient client,
            long customerId, string businessProfileFeedResourceName)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V11.GoogleAdsService);

            // Create the query.
            string query = $"SELECT feed_mapping.resource_name, feed_mapping.status FROM " +
                $"feed_mapping WHERE feed_mapping.feed = '{businessProfileFeedResourceName}' and " +
                $"feed_mapping.status = ENABLED and feed_mapping.placeholder_type = LOCATION" +
                $" LIMIT 1";

            // Issue a search request.
            PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> result =
                googleAdsService.Search(customerId.ToString(), query);

            // Display the results.
            GoogleAdsRow googleAdsRow = result.FirstOrDefault();
            return (googleAdsRow == null) ? null : googleAdsRow.FeedMapping;
        }
        // [END add_business_profile_location_extensions_1]

        /// <summary>
        /// Waits for the Business Profile feed to be ready.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="businessProfileFeedResourceName">The Business Profile feed resource name.
        /// </param>
        // [START add_business_profile_location_extensions_3]
        private static void WaitForBusinessProfileFeedToBeReady(GoogleAdsClient client,
            long customerId, string businessProfileFeedResourceName)
        {
            int numAttempts = 0;
            while (numAttempts < MAX_FEEDMAPPING_RETRIEVAL_ATTEMPTS)
            {
                // Once you create a feed, Google's servers will setup the feed by creating feed
                // attributes and feedmapping. Once the feedmapping is created, it is ready to be
                // used for creating customer feed.
                // This process is asynchronous, so we wait until the feed mapping is created,
                // peforming exponential backoff.
                FeedMapping feedMapping = GetBusinessProfileFeedMapping(client,
                    customerId, businessProfileFeedResourceName);

                if (feedMapping == null)
                {
                    numAttempts++;
                    int sleepSeconds = (int)(5 * Math.Pow(2, numAttempts));
                    Console.WriteLine($"Checked: #{numAttempts} time(s). Business Profile feed " +
                        $"is not ready yet. Waiting {sleepSeconds} seconds before trying again.");
                    Thread.Sleep(sleepSeconds * 1000);
                }
                else
                {
                    Console.WriteLine($"Business Profile Feed {businessProfileFeedResourceName} " +
                        $"is now ready.");
                    return;
                }
            }
            throw new RpcException(new Status(StatusCode.DeadlineExceeded,
                $"Business Profile Feed is not ready after {MAX_FEEDMAPPING_RETRIEVAL_ATTEMPTS} " +
                $"retries."));
        }
        // [END add_business_profile_location_extensions_3]

        /// <summary>
        /// Creates the customer feed.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="businessProfileFeedResourceName">The Business Profile feed resource name.
        /// </param>
        // [START add_business_profile_location_extensions_2]
        private static void CreateCustomerFeed(GoogleAdsClient client, long customerId,
            string businessProfileFeedResourceName)
        {
            // Get the CustomerFeedService.
            CustomerFeedServiceClient customerFeedService = client.GetService(
                Services.V11.CustomerFeedService);

            // Adds a CustomerFeed that associates the feed with this customer for
            // the LOCATION placeholder type.
            CustomerFeed customerFeed = new CustomerFeed()
            {
                Feed = businessProfileFeedResourceName,
                PlaceholderTypes = { PlaceholderType.Location },
                MatchingFunction = new MatchingFunction()
                {
                    LeftOperands =
                    {
                        new Operand()
                        {
                            ConstantOperand = new ConstantOperand()
                            {
                                BooleanValue = true
                            }
                        }
                    },
                    // Specify the function string as IDENTITY(true) to mark this feed as enabled.
                    FunctionString = "IDENTITY(true)",
                    Operator = MatchingFunctionOperator.Identity
                },
            };

            CustomerFeedOperation operation = new CustomerFeedOperation()
            {
                Create = customerFeed
            };

            MutateCustomerFeedsResponse customerFeedsResponse =
                customerFeedService.MutateCustomerFeeds(
                    customerId.ToString(), new[] { operation });

            // Displays the result.
            string addedCustomerFeed = customerFeedsResponse.Results[0].ResourceName;
            Console.WriteLine($"Customer feed created with resource name: {addedCustomerFeed}.");
            return;
        }
        // [END add_business_profile_location_extensions_2]
    }
}

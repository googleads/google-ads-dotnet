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
using Google.Ads.GoogleAds.V11.Errors;
using Google.Ads.GoogleAds.V11.Resources;
using Google.Ads.GoogleAds.V11.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V11.Enums.FeedAttributeTypeEnum.Types;
using static Google.Ads.GoogleAds.V11.Enums.FlightPlaceholderFieldEnum.Types;
using static Google.Ads.GoogleAds.V11.Enums.PlaceholderTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V11
{
    /// <summary>
    /// This code example adds a flights feed, creates the associated feed mapping, and
    /// adds a feed item. To update feeds, see UpdateFeedItemAttributeValue.cs.
    /// </summary>
    public class AddFlightsFeed : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddFlightsFeed"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID to which the flights feed is added.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID to which the flights feed is added.")]
            public long CustomerId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddFlightsFeed codeExample = new AddFlightsFeed();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a flights feed, creates the associated feed mapping, and " +
            "adds a feed item. To update feeds, see UpdateFeedItemAttributeValue.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID to which the flights feed is
        /// added.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            try
            {
                // Creates a new flights feed.
                string feedResourceName = CreateFeed(client, customerId);

                // Get the newly creates feed's attributes and packages them into a map. This read
                // operation is required to retrieve the attribute IDs.
                Dictionary<FlightPlaceholderField, FeedAttribute> feedAttributes =
                    GetFeed(client, customerId, feedResourceName);

                // Creates the feed mapping.
                CreateFeedMapping(client, customerId, feedAttributes, feedResourceName);

                // Creates a feed item.
                CreateFeedItem(client, customerId, feedAttributes, feedResourceName);
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
        /// Creates the feed.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the flights feed is
        /// added.</param>
        /// <returns>Resource name of the newly created feed.</returns>
        private string CreateFeed(GoogleAdsClient client, long customerId)
        {
            // Get the FeedService.
            FeedServiceClient feedService = client.GetService(Services.V11.FeedService);

            // Creates a Flight Description attribute.
            FeedAttribute flightDescriptionAttribute = new FeedAttribute()
            {
                Type = FeedAttributeType.String,
                Name = "Flight Description"
            };

            // Creates a Destination ID attribute.
            FeedAttribute destinationIdAttribute = new FeedAttribute()
            {
                Type = FeedAttributeType.String,
                Name = "Destination ID"
            };

            // Creates a Flight Price attribute.
            FeedAttribute flightPriceAttribute = new FeedAttribute()
            {
                Type = FeedAttributeType.String,
                Name = "Flight Price"
            };

            // Creates a Flight Sale Price attribute.
            FeedAttribute flightSalesPriceAttribute = new FeedAttribute()
            {
                Type = FeedAttributeType.String,
                Name = "Flight Sale Price"
            };

            // Creates a Final URLs attribute.
            FeedAttribute finalUrlsAttribute = new FeedAttribute()
            {
                Type = FeedAttributeType.UrlList,
                Name = "Final URLs"
            };

            // Creates the feed.
            Feed feed = new Feed()
            {
                Name = "Flights Feed #" + ExampleUtilities.GetRandomString(),
                Attributes =
                {
                    flightDescriptionAttribute,
                    destinationIdAttribute,
                    flightPriceAttribute,
                    flightSalesPriceAttribute,
                    finalUrlsAttribute
                }
            };

            // Creates the operation.
            FeedOperation operation = new FeedOperation()
            {
                Create = feed
            };

            // Adds the feed.
            MutateFeedsResponse response =
                feedService.MutateFeeds(customerId.ToString(), new[] { operation });

            string feedResourceName = response.Results[0].ResourceName;

            // Displays the result.
            Console.WriteLine($"Feed with resource name '{feedResourceName}' was created.");
            return feedResourceName;
        }

        /// <summary>
        /// Retrieves details about a feed. The initial query retrieves the FeedAttributes,
        /// or columns, of the feed. Each FeedAttribute will also include the FeedAttributeId,
        /// which will be used in a subsequent step. The example then inserts a new key, value
        /// pair into a map for each FeedAttribute, which is the return value of the method.
        /// The keys are the placeholder types that the columns will be. The values are the
        /// FeedAttributes.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the flights feed is
        /// added.</param>
        /// <param name="feedResourceName">The resource name of the feed.</param>
        /// <returns>
        /// A Map containing the FlightPlaceholderField and FeedAttribute.
        /// </returns>
        public Dictionary<FlightPlaceholderField, FeedAttribute> GetFeed(
            GoogleAdsClient client, long customerId, string feedResourceName)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V11.GoogleAdsService);

            // Constructs the query.
            string query = $"SELECT feed.attributes FROM feed WHERE feed.resource_name = " +
                $"'{feedResourceName}'";

            // Constructs the request.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                Query = query
            };

            // Issues the search request and get the first result, since we only need the
            // single feed item we created previously.
            GoogleAdsRow googleAdsRow = googleAdsService.Search(request).First();

            // Gets the attributes list from the feed and creates a map with keys of each attribute and
            // values of each corresponding ID.
            Dictionary<FlightPlaceholderField, FeedAttribute> feedAttributes =
                new Dictionary<FlightPlaceholderField, FeedAttribute>();

            // Loops through the feed attributes to populate the map.
            foreach (FeedAttribute feedAttribute in googleAdsRow.Feed.Attributes)
            {
                switch (feedAttribute.Name)
                {
                    case "Flight Description":
                        feedAttributes[FlightPlaceholderField.FlightDescription] = feedAttribute;
                        break;

                    case "Destination ID":
                        feedAttributes[FlightPlaceholderField.DestinationId] = feedAttribute;
                        break;

                    case "Flight Price":
                        feedAttributes[FlightPlaceholderField.FlightPrice] = feedAttribute;
                        break;

                    case "Flight Sale Price":
                        feedAttributes[FlightPlaceholderField.FlightSalePrice] = feedAttribute;
                        break;

                    case "Final URLs":
                        feedAttributes[FlightPlaceholderField.FinalUrls] = feedAttribute;
                        break;
                    // The full list of FlightPlaceholderFields can be found here
                    // https://developers.google.com/google-ads/api/reference/rpc/latest/FlightPlaceholderFieldEnum.FlightPlaceholderField
                    default:
                        throw new Exception("Invalid attribute name.");
                }
            }
            return feedAttributes;
        }

        /// <summary>
        /// Creates a feed mapping for a given feed.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the flights feed is
        /// added.</param>
        /// <param name="feedAttributes">The feed attributes.</param>
        /// <param name="feedResourceName">The resource name of the feed.</param>
        private void CreateFeedMapping(GoogleAdsClient client, long customerId,
            Dictionary<FlightPlaceholderField, FeedAttribute> feedAttributes,
            string feedResourceName)
        {
            // Get the FeedMappingServiceClient.
            FeedMappingServiceClient feedMappingService = client.GetService(
                Services.V11.FeedMappingService);

            // Maps the FeedAttributeIds to the fieldId constants.
            AttributeFieldMapping flightDescriptionMapping = new AttributeFieldMapping()
            {
                FeedAttributeId = feedAttributes[FlightPlaceholderField.FlightDescription].Id,
                FlightField = FlightPlaceholderField.FlightDescription
            };

            AttributeFieldMapping destinationIdMapping = new AttributeFieldMapping()
            {
                FeedAttributeId = feedAttributes[FlightPlaceholderField.DestinationId].Id,
                FlightField = FlightPlaceholderField.DestinationId
            };

            AttributeFieldMapping flightPriceMapping = new AttributeFieldMapping()
            {
                FeedAttributeId = feedAttributes[FlightPlaceholderField.FlightPrice].Id,
                FlightField = FlightPlaceholderField.FlightPrice
            };

            AttributeFieldMapping flightSalePriceMapping = new AttributeFieldMapping()
            {
                FeedAttributeId = feedAttributes[FlightPlaceholderField.FlightSalePrice].Id,
                FlightField = FlightPlaceholderField.FlightSalePrice
            };

            AttributeFieldMapping finalUrlsMapping = new AttributeFieldMapping()
            {
                FeedAttributeId = feedAttributes[FlightPlaceholderField.FinalUrls].Id,
                FlightField = FlightPlaceholderField.FinalUrls
            };

            // Creates the feed mapping.
            FeedMapping feedMapping = new FeedMapping()
            {
                PlaceholderType = PlaceholderType.DynamicFlight,
                Feed = feedResourceName,
                AttributeFieldMappings =
                {
                    flightDescriptionMapping,
                    destinationIdMapping,
                    flightPriceMapping,
                    flightSalePriceMapping,
                    finalUrlsMapping
                }
            };

            // Creates the operation.
            FeedMappingOperation operation = new FeedMappingOperation()
            {
                Create = feedMapping
            };

            // Adds the FeedMapping.
            MutateFeedMappingsResponse response = feedMappingService.MutateFeedMappings(
                customerId.ToString(), new[] { operation });

            // Displays the results.
            foreach (MutateFeedMappingResult result in response.Results)
            {
                Console.WriteLine($"Created feed mapping with resource name" +
                    $" '{result.ResourceName}'.");
            }
        }

        /// <summary>
        /// Adds a new item to the feed.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the flights feed is
        /// added.</param>
        /// <param name="feedAttributes">The feed attributes.</param>
        /// <param name="feedResourceName">The resource name of the feed.</param>
        private void CreateFeedItem(GoogleAdsClient client, long customerId,
            Dictionary<FlightPlaceholderField, FeedAttribute> feedAttributes,
            string feedResourceName)
        {
            // Get the FeedItemServiceClient.
            FeedItemServiceClient feedItemService = client.GetService(
                Services.V11.FeedItemService);

            // Creates the flight description feed attribute value.
            FeedItemAttributeValue flightDescription = new FeedItemAttributeValue()
            {
                FeedAttributeId = feedAttributes[FlightPlaceholderField.FlightDescription].Id,
                StringValue = "Earth to Mars"
            };

            // Creates the destination ID feed attribute value.
            FeedItemAttributeValue destinationId = new FeedItemAttributeValue()
            {
                FeedAttributeId = feedAttributes[FlightPlaceholderField.DestinationId].Id,
                StringValue = "Mars"
            };

            // Creates the flight price feed attribute value.
            FeedItemAttributeValue flightPrice = new FeedItemAttributeValue()
            {
                FeedAttributeId = feedAttributes[FlightPlaceholderField.FlightPrice].Id,
                StringValue = "499.99 USD"
            };

            // Creates the flight sale price feed attribute value.
            FeedItemAttributeValue flightSalePrice = new FeedItemAttributeValue()
            {
                FeedAttributeId = feedAttributes[FlightPlaceholderField.FlightSalePrice].Id,
                StringValue = "299.99 USD"
            };

            // Creates the final URLs feed attribute value.
            FeedItemAttributeValue finalUrls = new FeedItemAttributeValue()
            {
                FeedAttributeId = feedAttributes[FlightPlaceholderField.FinalUrls].Id,
                StringValues = { "http://www.example.com/flights/" }
            };

            // Creates the FeedItem, specifying the Feed ID and the attributes created above.
            FeedItem feedItem = new FeedItem()
            {
                Feed = feedResourceName,
                AttributeValues =
                {
                    flightDescription,
                    destinationId,
                    flightPrice,
                    flightSalePrice,
                    finalUrls
                }
            };

            // Creates an operation to add the FeedItem.
            FeedItemOperation operation = new FeedItemOperation()
            {
                Create = feedItem
            };

            // Adds the feed item.
            MutateFeedItemsResponse response =
                feedItemService.MutateFeedItems(customerId.ToString(),
                    new FeedItemOperation[] { operation });

            foreach (MutateFeedItemResult result in response.Results)
            {
                Console.WriteLine($"Created feed item with resource name '{result.ResourceName}'.");
            }
        }
    }
}

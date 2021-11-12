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
using Google.Ads.GoogleAds.V9.Errors;
using Google.Ads.GoogleAds.V9.Resources;
using Google.Ads.GoogleAds.V9.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V9.Enums.FlightPlaceholderFieldEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V9
{
    /// <summary>
    /// This code example updates a FeedItemAttributeValue in a flights feed. To create a flights
    /// feed, run the AddFlightsFeed.cs. This code example is specific to feeds of type
    /// DYNAMIC_FLIGHT. The attribute you are updating must be present on the feed. This code
    /// example is specifically for updating the StringValue of an attribute.
    /// </summary>
    public class UpdateFlightsFeedItemStringAttributeValue : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see
        /// cref="UpdateFlightsFeedItemStringAttributeValue"/> example.
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
            /// ID of the feed containing the feed item to be updated.
            /// </summary>
            [Option("feedId", Required = true, HelpText =
                "ID of the feed containing the feed item to be updated.")]
            public long FeedId { get; set; }

            /// <summary>
            /// ID of the feed item to be updated.
            /// </summary>
            [Option("feedItemId", Required = true, HelpText =
                "ID of the feed item to be updated.")]
            public long FeedItemId { get; set; }

            /// <summary>
            /// The placeholder type for the attribute to be removed.
            /// </summary>
            [Option("flightPlaceholderFieldName", Required = true, HelpText =
                "The placeholder type for the attribute to be removed.")]
            public string FlightPlaceholderFieldName { get; set; }

            /// <summary>
            /// Value with which to update the FeedAttributeValue.
            /// </summary>
            [Option("attributeValue", Required = true, HelpText =
                "Value with which to update the FeedAttributeValue.")]
            public string AttributeValue { get; set; }
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
                    // The customer ID for which the call is made.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // ID of the feed containing the feed item to be updated.
                    options.FeedId = long.Parse("INSERT_FEED_ID_HERE");

                    // ID of the feed item to be updated.
                    options.FeedItemId = long.Parse("INSERT_FEED_ITEM_ID_HERE");

                    // The placeholder type for the attribute to be removed.
                    options.FlightPlaceholderFieldName =
                        "INSERT_FLIGHT_PLACEHOLDER_FIELD_NAME_HERE";

                    // Value with which to update the FeedAttributeValue.
                    options.AttributeValue = "INSERT_ATTRIBUTE_VALUE_HERE";

                    return 0;
                });

            UpdateFlightsFeedItemStringAttributeValue codeExample =
                new UpdateFlightsFeedItemStringAttributeValue();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.FeedId,
                options.FeedItemId, options.FlightPlaceholderFieldName, options.AttributeValue);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example updates a FeedItemAttributeValue in a flights feed. To create a " +
            "flights feed, run the AddFlightsFeed.cs. This code example is specific to feeds of " +
            "type DYNAMIC_FLIGHT. The attribute you are updating must be present on the feed. " +
            "This code example is specifically for updating the StringValue of an attribute.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="feedId">ID of the feed containing the feed item to be updated.</param>
        /// <param name="feedItemId">ID of the feed item to be updated.</param>
        /// <param name="flightPlaceholderFieldName">
        /// The placeholder type for the attribute to be removed.
        /// </param>
        /// <param name="attributeValue">Value with which to update the FeedAttributeValue.</param>
        public void Run(GoogleAdsClient client, long customerId, long feedId, long feedItemId,
            string flightPlaceholderFieldName, string attributeValue)
        {
            try
            {
                UpdateFeedItem(client, customerId, feedId, feedItemId, flightPlaceholderFieldName,
                    attributeValue);
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
        /// Updates attribute value of the feed item. In order to update a FeedItemAttributeValue
        /// you must update the FeedItem.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="feedId">ID of the feed containing the feed item to be updated.</param>
        /// <param name="feedItemId">ID of the feed item to be updated.</param>
        /// <param name="flightPlaceholderFieldName">
        /// the placeholder type for the attribute to be updated.
        /// </param>
        /// <param name="attributeValue">
        /// String value with which to update the FeedAttributeValue.
        /// </param>
        // [START update_flights_feed_item_string_attribute_value]
        private void UpdateFeedItem(GoogleAdsClient client, long customerId, long feedId,
            long feedItemId, string flightPlaceholderFieldName, string attributeValue)
        {
            // Get the FeedItemServiceClient.
            FeedItemServiceClient feedItemService =
                client.GetService(Services.V9.FeedItemService);

            // Gets the feed resource name.
            string feedResourceName = ResourceNames.Feed(customerId, feedId);

            // Gets a map of the placeholder values and feed attributes.
            Dictionary<FlightPlaceholderField, FeedAttribute> feedAttributes =
                GetFeed(client, customerId, feedResourceName);

            // Gets the ID of the attribute to update. This is needed to specify which
            // FeedItemAttributeValue will be updated in the given FeedItem.
            FlightPlaceholderField placeholderField = (FlightPlaceholderField) Enum.Parse(
                typeof(FlightPlaceholderField), flightPlaceholderFieldName);
            long attributeId = feedAttributes[placeholderField].Id;

            // Gets the feed item resource name.
            string feedItemResourceName = ResourceNames.FeedItem(customerId, feedId, feedItemId);
            // Retrieves the feed item and its associated attributes based on its resource name.
            FeedItem feedItem = GetFeedItem(client, customerId, feedItemResourceName);
            // Creates the updated FeedItemAttributeValue.
            FeedItemAttributeValue feedItemAttributeValue = new FeedItemAttributeValue()
            {
                FeedAttributeId = attributeId,
                StringValue = attributeValue
            };

            // Creates a new FeedItem from the existing FeedItem. Any FeedItemAttributeValues that
            // are not included in the updated FeedItem will be removed from the FeedItem, which is
            // why you must create the FeedItem from the existing FeedItem and set the field(s)
            // that will be updated.
            int attributeIndex = feedItem.AttributeValues
                .Select((item, index) => new { item, index })
                .Where(itemIndexPair =>
                    itemIndexPair.item.FeedAttributeId == feedItemAttributeValue.FeedAttributeId)
                .Select(itemIndexPair => itemIndexPair.index + 1)
                .FirstOrDefault() - 1;

            if (attributeIndex == -1)
            {
                throw new ArgumentException("No matching feed attribute found for " +
                    $"value '{feedItemAttributeValue}'.");
            }

            feedItem.AttributeValues[attributeIndex] = feedItemAttributeValue;

            // Creates the operation.
            FeedItemOperation operation = new FeedItemOperation()
            {
                Update = feedItem,
                UpdateMask = FieldMasks.AllSetFieldsOf(feedItem)
            };

            // Updates the feed item.
            MutateFeedItemsResponse response =
                feedItemService.MutateFeedItems(customerId.ToString(), new[] { operation });

            foreach (MutateFeedItemResult result in response.Results)
            {
                Console.WriteLine($"Updated feed item with resource name " +
                    $"'{result.ResourceName}'.");
            }
        }

        /// <summary>
        /// Retrieves details about a feed. The initial query retrieves the FeedAttributes, or
        /// columns, of the feed. Each FeedAttribute will also include the FeedAttributeId, which
        /// will be used in a subsequent step. The example then inserts a new key, value pair into
        /// a map for each FeedAttribute, which is the return value of the method. The keys are the
        /// placeholder types that the columns will be. The values are the FeedAttributes.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">
        /// The Google Ads customer ID for which the flights feed is added.
        /// </param>
        /// <param name="feedResourceName">The resource name of the feed.</param>
        /// <returns>A Map containing the FlightPlaceholderField and FeedAttribute.</returns>
        public Dictionary<FlightPlaceholderField, FeedAttribute> GetFeed(
            GoogleAdsClient client, long customerId, string feedResourceName)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V9.GoogleAdsService);

            // Constructs the query.
            string query = "SELECT feed.attributes FROM feed WHERE feed.resource_name = " +
                $"'{feedResourceName}'";

            // Constructs the request.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                Query = query
            };

            // Issues the search request and get the first result, since we only need the single
            // feed item we created previously..
            GoogleAdsRow googleAdsRow = googleAdsService.Search(request).First();

            // Gets the attributes list from the feed and creates a map with keys of each attribute
            // and values of each corresponding ID.
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
        /// Retrieves a feed item and its attribute values given a resource name.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">
        /// The Google Ads customer ID for which the flights feed is added.
        /// </param>
        /// <param name="feedItemResourceName">Feed item resource name.</param>
        /// <returns>FeedItem with the given resource name.</returns>
        private FeedItem GetFeedItem(GoogleAdsClient client, long customerId,
            string feedItemResourceName)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V9.GoogleAdsService);

            // Constructs the query.
            string query = "SELECT feed_item.attribute_values FROM feed_item WHERE " +
                $"feed_item.resource_name = '{feedItemResourceName}'";

            // Constructs the request.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                Query = query
            };

            return googleAdsService.Search(request).First().FeedItem;
        }
        // [END update_flights_feed_item_string_attribute_value]
    }
}

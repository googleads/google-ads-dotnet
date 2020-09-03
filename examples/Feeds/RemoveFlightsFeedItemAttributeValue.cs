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
using System.Linq;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V5.Errors;
using Google.Ads.GoogleAds.V5.Resources;
using Google.Ads.GoogleAds.V5.Services;
using Google.Api.Gax;
using static Google.Ads.GoogleAds.V5.Enums.FlightPlaceholderFieldEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V5
{
    /// <summary>
    /// Removes a feed item attribute value of a feed item in a flights feed. To create a flights
    /// feed, run the AddFlightsFeed example. This example is specific to feeds of type DYNAMIC_FLIGHT.
    /// The attribute you are removing must be present on the feed.
    ///
    /// This example is specifically for removing an attribute of a flights feed item,
    /// but it can also be changed to work with other feed types.
    ///
    /// To make this work with other feed types, replace the FlightPlaceholderField enum with the
    /// equivalent one of your feed type, and replace the appropriate attribute names in the
    /// GetFeeds method.
    /// </summary>
    public class RemoveFlightsFeedItemAttributeValue : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            RemoveFlightsFeedItemAttributeValue codeExample =
                new RemoveFlightsFeedItemAttributeValue();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The Feed ID to which the feed item belongs.
            long feedId = long.Parse("INSERT_FEED_ID_HERE");

            // The ID of the feed item to be updated.
            long feedItemId = long.Parse("INSERT_FEED_ITEM_ID_HERE");

            // The flight placeholder field name for the attribute to be removed.
            string flightPlaceholderFieldName = "INSERT_FLIGHT_PLACEHOLDER_FIELD_NAME_HERE";

            codeExample.Run(new GoogleAdsClient(), customerId, feedId, feedItemId,
                flightPlaceholderFieldName);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "Removes a feed item attribute value of a feed item in a flights feed. To create a " +
            "flights feed, run the AddFlightsFeed example. This example is specific to feeds of " +
            "type DYNAMIC_FLIGHT. The attribute you are removing must be present on the feed.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="feedId">The Feed ID to which the feed item belongs.</param>
        /// <param name="feedItemId">The ID of the feed item to be updated.</param>
        /// <param name="flightPlaceholderFieldName">The flight placeholder field name for the
        /// attribute to be removed.</param>
        public void Run(GoogleAdsClient client, long customerId, long feedId, long feedItemId,
            string flightPlaceholderFieldName)
        {
            // Creates the Feed Item service client.
            FeedItemServiceClient feedItemServiceClient = client.GetService(
                Services.V5.FeedItemService);

            try
            {
                // Gets a map of the placeholder values to feed attributes.
                Dictionary<FlightPlaceholderField, FeedAttribute> placeholdersToFeedAttributesMap =
                    GetFeed(client, customerId, feedId);

                // Removes the attribute from the feed item.
                FlightPlaceholderField flightPlaceholderField =
                    (FlightPlaceholderField) Enum.Parse(typeof(FlightPlaceholderField),
                        flightPlaceholderFieldName, true);
                FeedItem feedItem = RemoveAttributeValueFromFeedItem(client, customerId, feedId,
                    feedItemId, placeholdersToFeedAttributesMap, flightPlaceholderField);

                // Creates the operation.
                FeedItemOperation operation = new FeedItemOperation
                {
                    Update = feedItem,
                    UpdateMask = FieldMasks.AllSetFieldsOf(feedItem)
                };

                // Updates the feed item and prints the results.
                MutateFeedItemsResponse response = feedItemServiceClient.MutateFeedItems
                    (customerId.ToString(), new[] {operation});
                foreach (MutateFeedItemResult result in response.Results)
                {
                    Console.WriteLine("Updated feed item with resource name " +
                        $"'{result.ResourceName}'.");
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
            catch (Exception e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                throw;
            }
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
        /// <param name="customerId">The Google Ads customer ID that has the flights feed.</param>
        /// <param name="feedId">The feed ID for which to get details.</param>
        /// <returns>A mapping of FlightPlaceholderFields to FeedAttributes.</returns>
        public Dictionary<FlightPlaceholderField, FeedAttribute> GetFeed(
            GoogleAdsClient client, long customerId, long feedId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V5.GoogleAdsService);

            string feedResourceName = ResourceNames.Feed(customerId, feedId);

            // Constructs the query.
            string query = "SELECT feed.attributes FROM feed WHERE feed.resource_name = " +
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
        /// Removes an attribute value from the specified feed item.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID that has the flights feed.</param>
        /// <param name="feedId">The feed ID that contains the target feed item.</param>
        /// <param name="feedItemId">The feed item ID that will be updated.</param>
        /// <param name="placeholdersToFeedAttributesMap">A mapping of FlightPlaceholderFields to
        /// FeedAttributes.</param>
        /// <param name="flightPlaceholderFieldName">The attributed field name to remove.</param>
        /// <returns>The modified feed item.</returns>
        /// <exception cref="ArgumentException">If the specified attribute was not found in the
        /// feed item.</exception>
        private FeedItem RemoveAttributeValueFromFeedItem(GoogleAdsClient client, long customerId,
            long feedId, long feedItemId,
            Dictionary<FlightPlaceholderField, FeedAttribute> placeholdersToFeedAttributesMap,
            FlightPlaceholderField flightPlaceholderFieldName)
        {
            // Gets the ID of the FeedAttribute for the placeholder field.
            long attributeId = placeholdersToFeedAttributesMap[flightPlaceholderFieldName].Id.Value;

            // Retrieves the feed item and its associated attributes based on its resource name.
            FeedItem feedItem = GetFeedItem(client, customerId, feedId, feedItemId);

            //Creates the FeedItemAttributeValue that will be updated.
            FeedItemAttributeValue feedItemAttributeValue = new FeedItemAttributeValue
            {
                FeedAttributeId = attributeId
            };

            // Gets the index of the attribute value that will be removed.
            int attributeIndex = feedItem.AttributeValues
                .Select((item, index) => new {item, index})
                .Where(itemIndexPair =>
                    itemIndexPair.item.FeedAttributeId.Value ==
                    feedItemAttributeValue.FeedAttributeId.Value)
                .Select(itemIndexPair => itemIndexPair.index + 1)
                .FirstOrDefault() - 1;

            if (attributeIndex == -1)
            {
                throw new ArgumentException("No matching feed attribute found for " +
                    $"value '{feedItemAttributeValue}'.");
            }

            // Returns the feed item with the removed FeedItemAttributeValue. Any
            // FeedItemAttributeValues that are not included in the updated FeedItem will be removed
            // from the FeedItem, which is why you must create the FeedItem from the existing
            // FeedItem and set the field(s) that will be removed.
            feedItem.AttributeValues.RemoveAt(attributeIndex);
            return feedItem;
        }

        /// <summary>
        /// Retrieves a feed item and its attribute values given a resource name.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="feedId">The feed ID that contains the target feed item.</param>
        /// <param name="feedItemId">The feed item ID that will be updated.</param>
        /// <returns>FeedItem with the given resource name.</returns>
        private FeedItem GetFeedItem(GoogleAdsClient client, long customerId,
            long feedId, long feedItemId)
        {
            // Gets the Google Ads service.
            GoogleAdsServiceClient googleAdsServiceClient = client.GetService(
                Services.V5.GoogleAdsService);

            // Constructs the resource name for the feed item.
            string feedItemResourceName = ResourceNames.FeedItem(customerId, feedId, feedItemId);

            // Constructs the query.
            string query = $@"
                SELECT feed_item.attribute_values
                FROM feed_item
                WHERE feed_item.resource_name = '{feedItemResourceName}'";

            // Issues the search request.
            PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchResponse =
                googleAdsServiceClient.Search(customerId.ToString(), query);

            // Returns the feed item attribute values.
            return searchResponse.First().FeedItem;
        }
    }
}

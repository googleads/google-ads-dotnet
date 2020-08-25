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
using Google.Ads.GoogleAds.V4.Errors;
using Google.Ads.GoogleAds.V4.Resources;
using Google.Ads.GoogleAds.V4.Services;
using static Google.Ads.GoogleAds.V4.Enums.FlightPlaceholderFieldEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V4
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
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            UpdateFlightsFeedItemStringAttributeValue codeExample =
                new UpdateFlightsFeedItemStringAttributeValue();
            Console.WriteLine(codeExample.Description);

            // The customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the feed containing the feed item to be updated.
            long feedId = long.Parse("INSERT_FEED_ID_HERE");

            // ID of the feed item to be updated.
            long feedItemId = long.Parse("INSERT_FEED_ITEM_ID_HERE");

            // The placeholder type name for the attribute to be removed.
            string flightPlaceholderFieldName = "INSERT_FLIGHT_PLACEHOLDER_FIELD_NAME_HERE";

            // Value with which to update the FeedAttributeValue.
            string attributeValue = "INSERT_ATTRIBUTE_VALUE_HERE";

            codeExample.Run(new GoogleAdsClient(), customerId, feedId, feedItemId,
                flightPlaceholderFieldName, attributeValue);
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
        /// <param name="flightPlaceholderFieldName">The placeholder type for the attribute to be
        /// removed.</param>
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
        /// <param name="flightPlaceholderFieldName">the placeholder type for the attribute to be
        /// updated.</param>
        /// <param name="attributeValue">String value with which to update the
        /// FeedAttributeValue.</param>
        private void UpdateFeedItem(GoogleAdsClient client, long customerId, long feedId,
            long feedItemId, string flightPlaceholderFieldName, string attributeValue)
        {
            // Get the FeedItemServiceClient.
            FeedItemServiceClient feedItemService =
                client.GetService(Services.V4.FeedItemService);

            // Gets the feed resource name.
            string feedResourceName = ResourceNames.Feed(customerId, feedId);

            // Gets a map of the placeholder values and feed attributes.
            Dictionary<FlightPlaceholderField, FeedAttribute> feedAttributes =
                GetFeed(client, customerId, feedResourceName);

            // Gets the ID of the attribute to update. This is needed to specify which
            // FeedItemAttributeValue will be updated in the given FeedItem.
            FlightPlaceholderField placeholderField = (FlightPlaceholderField) Enum.Parse(
                typeof(FlightPlaceholderField), flightPlaceholderFieldName);
            long attributeId = feedAttributes[placeholderField].Id.Value;

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
            feedItem.AttributeValues[GetAttributeIndex(feedItem, feedItemAttributeValue)] =
                feedItemAttributeValue;

            // Creates the operation.
            FeedItemOperation operation = new FeedItemOperation()
            {
                Update = feedItem,
                UpdateMask = FieldMasks.AllSetFieldsOf(feedItem)
            };

            // Updates the feed item.
            MutateFeedItemsResponse response =
                feedItemService.MutateFeedItems(customerId.ToString(), new[] {operation});

            foreach (MutateFeedItemResult result in response.Results)
            {
                Console.WriteLine($"Updated feed item with resource name '{result.ResourceName}'.");
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
                Services.V4.GoogleAdsService);

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
            // single feed item we created previously..
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
        /// <param name="customerId">The Google Ads customer ID for which the flights feed is
        /// added.</param>
        /// <param name="feedItemResourceName">Feed item resource name.</param>
        /// <returns>FeedItem with the given resource name.</returns>
        private FeedItem GetFeedItem(GoogleAdsClient client, long customerId,
            string feedItemResourceName)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V4.GoogleAdsService);

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

        /// <summary>
        /// Gets the ID of the attribute. This is needed to specify which FeedItemAttributeValue
        /// will be updated in the given FeedItem.
        /// </summary>
        /// <param name="feedItem">The FeedItem that will be updated.</param>
        /// <param name="newFeedItemAttributeValue">The new FeedItemAttributeValue that will be
        /// updated.</param>
        /// <returns>The index of the attribute.</returns>
        private int GetAttributeIndex(FeedItem feedItem,
            FeedItemAttributeValue newFeedItemAttributeValue)
        {
            int attributeIndex = -1;
            // Loops through attribute values to find the index of the FeedItemAttributeValue
            // to update.
            foreach (FeedItemAttributeValue feedItemAttributeValue in feedItem.AttributeValues)
            {
                attributeIndex = (attributeIndex == -1) ? attributeIndex + 1 : 0;
                // Checks if the current feedItemAttributeValue is the one we are updating.
                if (feedItemAttributeValue.FeedAttributeId
                    == newFeedItemAttributeValue.FeedAttributeId)
                {
                    break;
                }
            }

            // Throws an exception if the attribute value is not found.
            if (attributeIndex == -1)
            {
                new ArgumentException($"No matching feed attribute for feed item attribute " +
                    $"value: {newFeedItemAttributeValue}");
            }

            return attributeIndex;
        }
    }
}

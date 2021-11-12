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
using Google.Ads.GoogleAds.V9.Errors;
using Google.Ads.GoogleAds.V9.Resources;
using Google.Ads.GoogleAds.V9.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V9.Enums.FeedAttributeTypeEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.PlaceholderTypeEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.RealEstatePlaceholderFieldEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V9
{
    /// <summary>
    /// This code example adds a real estate feed, creates the feed mapping, and adds items to
    /// the feed. To update feeds, see UpdateFeedItemAttributeValue.cs.
    /// </summary>
    public class AddRealEstateFeed : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddRealEstateFeed"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the real estate feed is added.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the real estate feed is added.")]
            public long CustomerId { get; set; }
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
                    // The Google Ads customer ID for which the real estate feed is added.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    return 0;
                });

            AddRealEstateFeed codeExample = new AddRealEstateFeed();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a real estate feed, creates the feed mapping, and adds items " +
            "to the feed. To update feeds, see UpdateFeedItemAttributeValue.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the real estate feed is
        /// added.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            try
            {
                // Creates a new real estate feed.
                string feedResourceName = CreateFeed(client, customerId);

                // Get the newly creates feed's attributes and packages them into a map. This read
                // operation is required to retrieve the attribute IDs.
                Dictionary<RealEstatePlaceholderField, FeedAttribute> feedAttributes =
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
        /// <param name="customerId">The Google Ads customer ID for which the real estate feed is
        /// added.</param>
        /// <returns>Resource name of the newly created feed.</returns>
        private string CreateFeed(GoogleAdsClient client, long customerId)
        {
            // Get the FeedService.
            FeedServiceClient feedService = client.GetService(Services.V9.FeedService);

            // Creates a Listing ID attribute.
            FeedAttribute listingIdAttribute = new FeedAttribute()
            {
                Type = FeedAttributeType.String,
                Name = "Listing ID"
            };

            // Creates a Listing Name attribute.
            FeedAttribute listingNameAttribute = new FeedAttribute()
            {
                Type = FeedAttributeType.String,
                Name = "Listing Name"
            };

            // Creates a Final URLs attribute.
            FeedAttribute finalUrlsAttribute = new FeedAttribute()
            {
                Type = FeedAttributeType.UrlList,
                Name = "Final URLs"
            };

            // Creates an Image URL attribute
            FeedAttribute imageUrlAttribute = new FeedAttribute()
            {
                Type = FeedAttributeType.Url,
                Name = "Image URL"
            };

            // Creates a Contextual Keywords attribute
            FeedAttribute contextualKeywordsAttribute = new FeedAttribute()
            {
                Type = FeedAttributeType.StringList,
                Name = "Contextual Keywords"
            };

            // Creates the feed.
            Feed feed = new Feed()
            {
                Name = "Real Estate Feed #" + ExampleUtilities.GetRandomString(),
                Attributes =
                {
                    listingIdAttribute,
                    listingNameAttribute,
                    finalUrlsAttribute,
                    imageUrlAttribute,
                    contextualKeywordsAttribute
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
        /// <param name="customerId">The Google Ads customer ID for which the real estate feed is
        /// added.</param>
        /// <param name="feedResourceName">The resource name of the feed.</param>
        /// <returns>
        /// A Map containing the RealEstatePlaceholderField and FeedAttribute.
        /// </returns>
        // [START add_real_estate_feed]
        public Dictionary<RealEstatePlaceholderField, FeedAttribute> GetFeed(
            GoogleAdsClient client, long customerId, string feedResourceName)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V9.GoogleAdsService);

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

            // Gets the attributes list from the feed and creates a map with keys of each
            // attribute and values of each corresponding ID.

            Dictionary<RealEstatePlaceholderField, FeedAttribute> feedAttributes =
                new Dictionary<RealEstatePlaceholderField, FeedAttribute>();

            // Loops through the feed attributes to populate the map.
            foreach (FeedAttribute feedAttribute in googleAdsRow.Feed.Attributes)
            {
                switch (feedAttribute.Name)
                {
                    case "Listing ID":
                        feedAttributes[RealEstatePlaceholderField.ListingId] = feedAttribute;
                        break;

                    case "Listing Name":
                        feedAttributes[RealEstatePlaceholderField.ListingName] = feedAttribute;
                        break;

                    case "Final URLs":
                        feedAttributes[RealEstatePlaceholderField.FinalUrls] = feedAttribute;
                        break;

                    case "Image URL":
                        feedAttributes[RealEstatePlaceholderField.ImageUrl] = feedAttribute;
                        break;

                    case "Contextual Keywords":
                        feedAttributes[RealEstatePlaceholderField.ContextualKeywords] = feedAttribute;
                        break;
                    // The full list of RealEstatePlaceholderField can be found here
                    // https://developers.google.com/google-ads/api/reference/rpc/latest/RealEstatePlaceholderFieldEnum.RealEstatePlaceholderField
                    default:
                        throw new Exception("Invalid attribute name.");
                }
            }
            return feedAttributes;
        }
        // [END add_real_estate_feed]

        /// <summary>
        /// Creates a feed mapping for a given feed.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the real estate feed is
        /// added.</param>
        /// <param name="feedAttributes">The feed attributes.</param>
        /// <param name="feedResourceName">The resource name of the feed.</param>
        private void CreateFeedMapping(GoogleAdsClient client, long customerId,
            Dictionary<RealEstatePlaceholderField, FeedAttribute> feedAttributes,
            string feedResourceName)
        {
            // Get the FeedMappingServiceClient.
            FeedMappingServiceClient feedMappingService = client.GetService(
                Services.V9.FeedMappingService);

            // Maps the FeedAttributeIds to the placeholder values. The FeedAttributeId is the
            // ID of the FeedAttribute created in the CreatedFeed method. This can be thought of
            // as the generic ID of the column of the new feed. The placeholder value specifies
            // the type of column this is in the context of a real estate feed (e.g.
            // a LISTING_ID or LISTING_NAME). The FeedMapping associates the feed column by ID to
            // this type and controls how the feed attributes are presented in dynamic content.
            // See https://developers.google.com/google-ads/api/reference/rpc/latest/RealEstatePlaceholderFieldEnum.RealEstatePlaceholderField
            // for the full list of placeholder values.

            AttributeFieldMapping listingIdMapping = new AttributeFieldMapping()
            {
                FeedAttributeId = feedAttributes[RealEstatePlaceholderField.ListingId].Id,
                RealEstateField = RealEstatePlaceholderField.ListingId
            };

            AttributeFieldMapping listingNameMapping = new AttributeFieldMapping()
            {
                FeedAttributeId = feedAttributes[RealEstatePlaceholderField.ListingName].Id,
                RealEstateField = RealEstatePlaceholderField.ListingName
            };

            AttributeFieldMapping finalUrlsMapping = new AttributeFieldMapping()
            {
                FeedAttributeId = feedAttributes[RealEstatePlaceholderField.FinalUrls].Id,
                RealEstateField = RealEstatePlaceholderField.FinalUrls
            };

            AttributeFieldMapping imageUrlMapping = new AttributeFieldMapping()
            {
                FeedAttributeId = feedAttributes[RealEstatePlaceholderField.ImageUrl].Id,
                RealEstateField = RealEstatePlaceholderField.ImageUrl
            };

            AttributeFieldMapping contextualKeywordsMapping = new AttributeFieldMapping()
            {
                FeedAttributeId = feedAttributes[RealEstatePlaceholderField.ContextualKeywords].Id,
                RealEstateField = RealEstatePlaceholderField.ContextualKeywords
            };

            // Creates the feed mapping.
            FeedMapping feedMapping = new FeedMapping()
            {
                PlaceholderType = PlaceholderType.DynamicRealEstate,
                Feed = feedResourceName,
                AttributeFieldMappings =
                {
                    listingIdMapping,
                    listingNameMapping,
                    finalUrlsMapping,
                    imageUrlMapping,
                    contextualKeywordsMapping
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
        /// <param name="customerId">The Google Ads customer ID for which the real estate feed is
        /// added.</param>
        /// <param name="feedAttributes">The feed attributes.</param>
        /// <param name="feedResourceName">The resource name of the feed.</param>
        // [START add_real_estate_feed_1]
        private void CreateFeedItem(GoogleAdsClient client, long customerId,
            Dictionary<RealEstatePlaceholderField, FeedAttribute> feedAttributes,
            string feedResourceName)
        {
            // Get the FeedItemServiceClient.
            FeedItemServiceClient feedItemService = client.GetService(
                Services.V9.FeedItemService);

            // Creates the listing ID feed attribute value.
            FeedItemAttributeValue listingId = new FeedItemAttributeValue()
            {
                FeedAttributeId = feedAttributes[RealEstatePlaceholderField.ListingId].Id,
                StringValue = "ABC123DEF"
            };

            // Creates the listing name feed attribute value.
            FeedItemAttributeValue listingName = new FeedItemAttributeValue()
            {
                FeedAttributeId = feedAttributes[RealEstatePlaceholderField.ListingName].Id,
                StringValue = "Two bedroom with magnificent views"
            };

            // Creates the final URLs feed attribute value.
            FeedItemAttributeValue finalUrls = new FeedItemAttributeValue()
            {
                FeedAttributeId = feedAttributes[RealEstatePlaceholderField.FinalUrls].Id,
                StringValue = "http://www.example.com/listings/"
            };

            // Creates the image URL feed attribute value.
            FeedItemAttributeValue imageUrl = new FeedItemAttributeValue()
            {
                FeedAttributeId = feedAttributes[RealEstatePlaceholderField.ImageUrl].Id,
                StringValue = "http://www.example.com/listings/images?listing_id=ABC123DEF"
            };

            // Creates the contextual keywords feed attribute value.
            FeedItemAttributeValue contextualKeywords = new FeedItemAttributeValue()
            {
                FeedAttributeId = feedAttributes[RealEstatePlaceholderField.ContextualKeywords].Id,
                StringValues =
                {
                    "beach community",
                    "ocean view",
                    "two bedroom",
                }
            };

            // Creates the FeedItem, specifying the Feed ID and the attributes created above.
            FeedItem feedItem = new FeedItem()
            {
                Feed = feedResourceName,
                AttributeValues =
                {
                    listingId,
                    listingName,
                    finalUrls,
                    imageUrl,
                    contextualKeywords
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
                Console.WriteLine($"Created feed item with resource name " +
                    $"'{result.ResourceName}'.");
            }
        }
        // [END add_real_estate_feed_1]
    }
}

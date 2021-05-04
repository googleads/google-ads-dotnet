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
using Google.Ads.GoogleAds.V7.Common;
using Google.Ads.GoogleAds.V7.Enums;
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Resources;
using Google.Ads.GoogleAds.V7.Services;
using static Google.Ads.GoogleAds.V7.Enums.FeedAttributeTypeEnum.Types;
using static Google.Ads.GoogleAds.V7.Enums.SitelinkPlaceholderFieldEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// This code example adds sitelinks to a campaign using feed services.
    /// Run AddCampaigns.cs to create a campaign.
    /// </summary>
    public class AddSitelinksUsingFeeds : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddSitelinksUsingFeeds codeExample = new AddSitelinksUsingFeeds();
            Console.WriteLine(codeExample.Description);

            // The customer ID for which the call is made.
            int customerId = int.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the campaign to which sitelinks are added.
            long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

            // ID of the ad group to which sitelinks are added.
            // Set to null if you do not wish to limit targeting to a specific ad group.
            long? adGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, campaignId, adGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds sitelinks to a campaign using feed services. Run " +
            "AddCampaigns.cs to create a campaign.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to which sitelinks are added.</param>
        /// <param name="adGroupId">Optional ID of the ad group to which sitelinks are added.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId, long? adGroupId)
        {
            try
            {
                // Create a feed, which acts as a table to store data.
                Feed feed = CreateFeed(client, customerId);

                // Create feed items, which fill out the feed table with data.
                List<string> feedItems = CreateFeedItems(client, customerId, feed);

                // Create a feed mapping, which tells Google Ads how to interpret this data to
                // display additional sitelink information on ads.
                CreateFeedMapping(client, customerId, feed);

                // Create a campaign feed, which tells Google Ads which campaigns to use the
                // provided data with.
                CreateCampaignFeed(client, customerId, campaignId, feed);

                // If an ad group is specified, limit targeting only to the given ad group.
                // You must set targeting on a per-feed-item basis. This will restrict the first
                // feed item we added to only serve for the given ad group.
                if (adGroupId.HasValue)
                {
                    CreateAdGroupTargeting(client, customerId, adGroupId.Value, feedItems.First());
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

        /// <summary>
        /// Creates a feed, which acts as a table to store data.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <returns>The newly created feed.</returns>
        private Feed CreateFeed(GoogleAdsClient client, long customerId)
        {
            FeedServiceClient feedServiceClient = client.GetService(Services.V7.FeedService);
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V7.GoogleAdsService);

            Feed feed = new Feed()
            {
                Name = $"Sitelinks Feed {ExampleUtilities.GetRandomString()}",
                Origin = FeedOriginEnum.Types.FeedOrigin.User,
                // Specify the column name and data type. This is just raw data at this point, and
                // not yet linked to any particular purpose. The names are used to help us remember
                // what they are intended for later.
                Attributes =
                {
                    CreateFeedAttribute("Link Text", FeedAttributeType.String),
                    CreateFeedAttribute("Link Final URL", FeedAttributeType.UrlList),
                    CreateFeedAttribute("Line 1", FeedAttributeType.String),
                    CreateFeedAttribute("Line 2", FeedAttributeType.String)
                }
            };

            FeedOperation operation = new FeedOperation()
            {
                Create = feed
            };

            MutateFeedsResponse response = feedServiceClient.MutateFeeds(
                customerId.ToString(), new[] {operation});
            string feedResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Created feed with resource name '{feedResourceName}'.");

            // After we create the feed, we need to fetch it so we can determine the
            // attribute IDs, which will be required when populating feed items.
            return googleAdsService.Search(
                customerId.ToString(),
                $"SELECT feed.attributes FROM feed WHERE feed.resource_name = '{feedResourceName}'"
            ).First().Feed;
        }

        /// <summary>
        /// Helper method to construct a single FeedAttribute.
        /// </summary>
        /// <param name="name">The name of the attribute to store.</param>
        /// <param name="type">The type represented by this attributed.</param>
        /// <returns>The newly created FeedAttribute instance.</returns>
        private FeedAttribute CreateFeedAttribute(string name, FeedAttributeType type)
        {
            return new FeedAttribute()
            {
                Name = name,
                Type = type
            };
        }

        /// <summary>
        /// Helper method to construct a single FeedAttribute.
        /// </summary>
        /// <param name="feed">The feed for which the operation will be created.</param>
        /// <param name="text">The link text for the feed item.</param>
        /// <param name="finalUrl">The final URL for the feed item.</param>
        /// <param name="line1">Line 1 of the feed item.</param>
        /// <param name="line2">Line 2 of the feed item.</param>
        /// <returns>The newly created FeedAttribute instance.</returns>
        private FeedItemOperation NewFeedItemOperation(Feed feed, string text, string finalUrl,
            string line1, string line2)
        {
            // The attribute IDs come back in the same order that they were added.
            FeedItemAttributeValue linkTextAttributeValue = new FeedItemAttributeValue()
            {
                FeedAttributeId = feed.Attributes[0].Id,
                StringValue = text
            };
            FeedItemAttributeValue finalUrlAttributeValue = new FeedItemAttributeValue()
            {
                FeedAttributeId = feed.Attributes[1].Id,
                StringValues = {finalUrl}
            };
            FeedItemAttributeValue line1AttributeValue = new FeedItemAttributeValue()
            {
                FeedAttributeId = feed.Attributes[2].Id,
                StringValue = line1
            };
            FeedItemAttributeValue line2AttributeValue = new FeedItemAttributeValue()
            {
                FeedAttributeId = feed.Attributes[3].Id,
                StringValue = line2
            };

            FeedItem feedItem = new FeedItem()
            {
                Feed = feed.ResourceName,
                AttributeValues =
                {
                    linkTextAttributeValue,
                    finalUrlAttributeValue,
                    line1AttributeValue,
                    line2AttributeValue
                }
            };

            FeedItemOperation feedItemOperation = new FeedItemOperation()
            {
                Create = feedItem
            };

            return feedItemOperation;
        }

        /// <summary>
        /// Creates feed items, which fill out the feed table with data.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="feed">The feed for which the operation will be created.</param>
        /// <returns>A list of string Feed Item Resource Names.</returns>
        private List<string> CreateFeedItems(GoogleAdsClient client, long customerId, Feed feed)
        {
            FeedItemServiceClient feedItemService = client.GetService(Services.V7.FeedItemService);

            List<FeedItemOperation> operations = new List<FeedItemOperation>
            {
                NewFeedItemOperation(feed, "Home", "http://www.example.com",
                    "Home line 1", "Home line 2"),
                NewFeedItemOperation(feed, "Stores",
                    "http://www.example.com/stores", "Stores line 1", "Stores line 2"),
                NewFeedItemOperation(feed, "On Sale",
                    "http://www.example.com/sale", "On Sale line 1", "On Sale line 2"),
                NewFeedItemOperation(feed, "Support",
                    "http://www.example.com/support", "Support line 1", "Support line 2"),
                NewFeedItemOperation(feed, "Products",
                    "http://www.example.com/catalogue",
                    "Products line 1", "Products line 2"),
                NewFeedItemOperation(feed, "About Us", "http://www.example.com/about",
                    "About Us line 1", "About Us line 2")
            };

            MutateFeedItemsResponse response =
                feedItemService.MutateFeedItems(customerId.ToString(), operations);

            // We will need the resource name of each feed item to use in targeting.
            List<string> feedItemResourceNames = new List<string>();

            Console.WriteLine("Created the following feed items:");
            foreach (MutateFeedItemResult feedItemResult in response.Results)
            {
                Console.WriteLine($"\t{feedItemResult.ResourceName}");

                feedItemResourceNames.Add(feedItemResult.ResourceName);
            }

            return feedItemResourceNames;
        }

        /// <summary>
        /// Creates a feed mapping, which tells Google Ads how to interpret this data to display
        /// additional sitelink information on ads.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="feed">The feed for which the operation will be created.</param>
        private void CreateFeedMapping(GoogleAdsClient client, long customerId, Feed feed)
        {
            FeedMappingServiceClient feedMappingServiceClient =
                client.GetService(Services.V7.FeedMappingService);

            FeedMapping feedMapping = new FeedMapping
            {
                PlaceholderType = PlaceholderTypeEnum.Types.PlaceholderType.Sitelink,
                Feed = feed.ResourceName,
            };

            foreach (FeedAttribute feedAttribute in feed.Attributes)
            {
                AttributeFieldMapping attributeFieldMapping = new AttributeFieldMapping()
                {
                    FeedAttributeId = feedAttribute.Id
                };

                switch (feedAttribute.Name)
                {
                    case "Link Text":
                        attributeFieldMapping.SitelinkField = SitelinkPlaceholderField.Text;
                        break;
                    case "Link Final URL":
                        attributeFieldMapping.SitelinkField = SitelinkPlaceholderField.FinalUrls;
                        break;
                    case "Line 1":
                        attributeFieldMapping.SitelinkField = SitelinkPlaceholderField.Line1;
                        break;
                    case "Line 2":
                        attributeFieldMapping.SitelinkField = SitelinkPlaceholderField.Line2;
                        break;
                }

                feedMapping.AttributeFieldMappings.Add(attributeFieldMapping);
            }

            FeedMappingOperation operation = new FeedMappingOperation()
            {
                Create = feedMapping
            };

            MutateFeedMappingsResponse response = feedMappingServiceClient.MutateFeedMappings
                (customerId.ToString(), new[] {operation});

            Console.WriteLine($"Created feed mapping '{response.Results.First().ResourceName}'");
        }

        /// <summary>
        /// Creates a campaign feed, which tells Google Ads which campaigns to use the provided
        /// data with.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="campaignId">The campaign to receive the feed.</param>
        /// <param name="feed">The feed to connect to the campaign.</param>
        private void CreateCampaignFeed(GoogleAdsClient client, long customerId, long campaignId,
            Feed feed)
        {
            CampaignFeedServiceClient campaignFeedServiceClient =
                client.GetService(Services.V7.CampaignFeedService);

            // Fetch the Feed Item IDs and collapse them into a single comma-separated string.
            List<long> feedItemIds = feed.Attributes.Select(attr => attr.Id).ToList();
            string aggregatedFeedItemIds = string.Join(",", feedItemIds);
            CampaignFeed campaignFeed = new CampaignFeed()
            {
                Feed = feed.ResourceName,
                Campaign = ResourceNames.Campaign(customerId, campaignId),
                MatchingFunction = new MatchingFunction()
                {
                    FunctionString = $"AND(IN(FEED_ITEM_ID,{{ {aggregatedFeedItemIds} }})," +
                                     "EQUALS(CONTEXT.DEVICE,'Mobile'))"
                }
            };
            campaignFeed.PlaceholderTypes.Add(PlaceholderTypeEnum.Types.PlaceholderType.Sitelink);

            CampaignFeedOperation operation = new CampaignFeedOperation()
            {
                Create = campaignFeed
            };

            MutateCampaignFeedsResponse response = campaignFeedServiceClient.MutateCampaignFeeds(
                customerId.ToString(), new[] {operation});

            Console.WriteLine($"Created campaign feed '{response.Results.First().ResourceName}'");
        }

        /// <summary>
        /// Targets the feed items to the given ad group.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ID of the Ad Group being targeted.</param>
        /// <param name="feedItem">The feed item that was added to the feed.</param>
        private void CreateAdGroupTargeting(GoogleAdsClient client, long customerId, long adGroupId,
            string feedItem)
        {
            FeedItemTargetServiceClient feedItemTargetServiceClient =
                client.GetService(Services.V7.FeedItemTargetService);

            FeedItemTarget feedItemTarget = new FeedItemTarget()
            {
                FeedItem = feedItem,
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId)
            };

            FeedItemTargetOperation operation = new FeedItemTargetOperation()
            {
                Create = feedItemTarget
            };

            MutateFeedItemTargetsResponse response = feedItemTargetServiceClient
                .MutateFeedItemTargets(customerId.ToString(), new[] {operation});

            Console.WriteLine(
                $"Created feed item target '{response.Results.First().ResourceName}' " +
                $"for feed item '{feedItem}'.");
        }
    }
}

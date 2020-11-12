// Copyright 2019 Google LLC
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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V6.Common;
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V6.Enums.DsaPageFeedCriterionFieldEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.FeedAttributeTypeEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.FeedMappingCriterionTypeEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.WebpageConditionOperandEnum.Types;
using static Google.Ads.GoogleAds.V6.Resources.Campaign.Types;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example adds a page feed to specify precisely which URLs to use with your
    /// Dynamic Search Ads.
    /// </summary>
    public class AddDynamicPageFeed : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddDynamicPageFeed codeExample = new AddDynamicPageFeed();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the campaign for which dynamic page feeds are added.
            long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

            // ID of the ad group for which dynamic page feeds are added.
            long adGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, campaignId, adGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a page feed to specify precisely which URLs to use with your " +
            "Dynamic Search Ads.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign for which dynamic page feeds are added.
        /// </param>
        /// <param name="adGroupId">ID of the ad group for which dynamic page feeds are added.
        /// </param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId, long adGroupId)
        {
            try
            {
                string dsaPageUrlLabel = "discounts";

                // Get the page feed details. This code example creates a new feed, but you can
                // fetch and re-use an existing feed.
                String feedResourceName = CreateFeed(client, customerId);
                Dictionary<DsaPageFeedCriterionField, FeedAttribute> feedAttributes =
                  GetFeed(client, customerId, feedResourceName);
                CreateFeedMapping(client, customerId, feedResourceName, feedAttributes);
                CreateFeedItems(client, customerId, feedResourceName, feedAttributes,
                    dsaPageUrlLabel);

                // Associates the page feed with the campaign.
                UpdateCampaignDsaSetting(client, customerId, feedResourceName, campaignId);

                // Optional: Targets web pages matching the feed's label in the ad group.
                AddDsaTarget(client, customerId, adGroupId, dsaPageUrlLabel);

                Console.WriteLine($"Dynamic page feed setup is complete for campaign " +
                    $"ID {campaignId}");
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
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>The resource name of the newly created feed.</returns>
        private string CreateFeed(GoogleAdsClient client, long customerId)
        {
            // Get the FeedService.
            FeedServiceClient feedService = client.GetService(Services.V6.FeedService);

            // Create a URL attribute.
            FeedAttribute urlAttribute = new FeedAttribute()
            {
                Type = FeedAttributeType.UrlList,
                Name = "Page URL"
            };

            // Create a label attribute.
            FeedAttribute labelAttribute = new FeedAttribute()
            {
                Type = FeedAttributeType.StringList,
                Name = "Label"
            };

            // Create the feed.
            Feed feed = new Feed()
            {
                Name = "DSA Feed #" + ExampleUtilities.GetRandomString(),
                Attributes = { urlAttribute, labelAttribute }
            };

            // Create the operation.
            FeedOperation operation = new FeedOperation()
            {
                Create = feed
            };

            // Add the feed.
            MutateFeedsResponse response =
                feedService.MutateFeeds(customerId.ToString(), new[] { operation });

            string feedResourceName = response.Results[0].ResourceName;

            // Display the result.
            Console.WriteLine($"Feed with resource name '{feedResourceName}' was created.");

            return feedResourceName;
        }

        /// <summary>
        /// Retrieves details about a feed.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="feedResourceName">The feed resource name.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private Dictionary<DsaPageFeedCriterionField, FeedAttribute> GetFeed(
            GoogleAdsClient client, long customerId, string feedResourceName)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V6.GoogleAdsService);

            // Construct the query.
            String query = $"SELECT feed.attributes FROM feed WHERE feed.resource_name" +
                $" = '{feedResourceName}'";

            // Construct the request.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                Query = query
            };

            // Issue the search request.
            Feed feed = googleAdsService.Search(customerId.ToString(), query).First().Feed;

            Dictionary<DsaPageFeedCriterionField, FeedAttribute> retval =
                new Dictionary<DsaPageFeedCriterionField, FeedAttribute>();

            foreach (FeedAttribute attribute in feed.Attributes)
            {
                DsaPageFeedCriterionField key;
                switch (attribute.Name)
                {
                    case "Page URL":
                        key = DsaPageFeedCriterionField.PageUrl;
                        break;

                    case "Label":
                        key = DsaPageFeedCriterionField.Label;
                        break;

                    default:
                        throw new Exception("Unable to map attribute name to DSA page feed" +
                            " criterion.");
                }
                retval[key] = attribute;
            }

            return retval;
        }

        /// <summary>
        /// Creates a feed mapping for a given feed.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="feedResourceName">The feed resource for which feed mapping is created.
        /// </param>
        /// <param name="feedAttributes">The feed attributes.</param>
        private void CreateFeedMapping(GoogleAdsClient client, long customerId,
            string feedResourceName,
             Dictionary<DsaPageFeedCriterionField, FeedAttribute> feedAttributes
        )
        {
            // Get the FeedMappingService.
            FeedMappingServiceClient feedMappingService = client.GetService(
                Services.V6.FeedMappingService);

            FeedMapping feedMapping = new FeedMapping()
            {
                CriterionType = FeedMappingCriterionType.DsaPageFeed,
                Feed = feedResourceName,

                // Map the FeedAttributeId to the fieldId constants.
                AttributeFieldMappings =
                {
                    new AttributeFieldMapping()
                    {
                        FeedAttributeId = feedAttributes[DsaPageFeedCriterionField.PageUrl].Id,
                        DsaPageFeedField = DsaPageFeedCriterionField.PageUrl
                    },

                    new AttributeFieldMapping()
                    {
                        FeedAttributeId = feedAttributes[DsaPageFeedCriterionField.Label].Id,
                        DsaPageFeedField = DsaPageFeedCriterionField.Label
                    }
                }
            };

            // Create the operation.
            FeedMappingOperation operation = new FeedMappingOperation()
            {
                Create = feedMapping
            };

            // Add the FeedMapping.
            MutateFeedMappingsResponse response =
                feedMappingService.MutateFeedMappings(customerId.ToString(), new[] { operation });

            // Display the results.
            foreach (MutateFeedMappingResult result in response.Results)
            {
                Console.WriteLine($"Created feed mapping with resource name" +
                    $" '{result.ResourceName}'");
            }
        }

        /// <summary>
        /// Creates feed items for a given feed.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="feedResourceName">The feed resource for which feed items are created.
        /// </param>
        /// <param name="feedAttributes">The feed attributes.</param>
        /// <param name="dsaPageUrlLabel">The DSA page URL label.</param>
        private void CreateFeedItems(GoogleAdsClient client, long customerId,
            string feedResourceName,
            Dictionary<DsaPageFeedCriterionField, FeedAttribute> feedAttributes,
            string dsaPageUrlLabel)
        {
            // Get the FeedItemService.
            FeedItemServiceClient feedItemService = client.GetService(
                Services.V6.FeedItemService);

            List<string> urls = new List<string>
            {
                "http://www.example.com/discounts/rental-cars",
                "http://www.example.com/discounts/hotel-deals",
                "http://www.example.com/discounts/flight-deals"
            };

            List<FeedItemOperation> operations = new List<FeedItemOperation>();

            foreach (string url in urls)
            {
                // Create a feed item.
                FeedItem feedItem = new FeedItem()
                {
                    Feed = feedResourceName,
                    AttributeValues =
                    {
                        // Create a url attribute.
                        new FeedItemAttributeValue()
                        {
                            FeedAttributeId = feedAttributes[DsaPageFeedCriterionField.PageUrl].Id,
                            StringValue = url
                        },

                        // Creates a label attribute.
                        new FeedItemAttributeValue()
                        {
                            FeedAttributeId = feedAttributes[DsaPageFeedCriterionField.Label].Id,
                            StringValue = dsaPageUrlLabel
                        }
                    }
                };

                operations.Add(new FeedItemOperation()
                {
                    Create = feedItem
                });
            }

            // Add the feed items.
            MutateFeedItemsResponse response =
                feedItemService.MutateFeedItems(customerId.ToString(), operations);
            // Display the results.
            foreach (MutateFeedItemResult result in response.Results)
            {
                Console.WriteLine($"Created feed items with resource " +
                    $"name '{result.ResourceName}'.");
            }
        }

        /// <summary>
        /// Updates a campaign to set the DSA feed.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="feedResourceName">The DSA feed resource name</param>
        /// <param name="campaignId">ID of the campaign for which DSA settings are updated.</param>
        private void UpdateCampaignDsaSetting(GoogleAdsClient client, long customerId,
            string feedResourceName, long campaignId)
        {
            // Get the CampaignService.
            CampaignServiceClient campaignService = client.GetService(
                Services.V6.CampaignService);

            DynamicSearchAdsSetting dsaSetting = GetDsaSetting(client, customerId, campaignId);
            dsaSetting.Feeds.Add(feedResourceName);

            // Create the campaign.
            Campaign campaign = new Campaign()
            {
                ResourceName = ResourceNames.Campaign(customerId, campaignId),
                DynamicSearchAdsSetting = dsaSetting
            };

            // Create the operation.
            CampaignOperation operation = new CampaignOperation()
            {
                Update = campaign,
                UpdateMask = FieldMasks.AllSetFieldsOf(campaign)
            };

            // Update the campaign.
            MutateCampaignsResponse response =
                campaignService.MutateCampaigns(customerId.ToString(), new[] { operation });
            // Display the results.
            foreach (MutateCampaignResult mutateCampaignResult in response.Results)
            {
                Console.WriteLine($"Updated campaign with resourceName: " +
                    $"'{mutateCampaignResult.ResourceName}'.");
            }
        }

        /// <summary>
        /// Returns the DSA settings for a campaign. Throws an error if the campaign does not
        /// exist or is not a DSA campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign for which DSA settings are fetched.</param>
        /// <returns>The DSA settings.</returns>
        private DynamicSearchAdsSetting GetDsaSetting(GoogleAdsClient client, long customerId,
            long campaignId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V6.GoogleAdsService);

            // Creates the query.
            // You must request all DSA fields in order to update the DSA settings in the
            // following step.
            string query =
                "SELECT "
                    + "campaign.id, "
                    + "campaign.name, "
                    + "campaign.dynamic_search_ads_setting.domain_name, "
                    + "campaign.dynamic_search_ads_setting.language_code, "
                    + "campaign.dynamic_search_ads_setting.use_supplied_urls_only "
                    + "FROM "
                    + "campaign "
                    + "WHERE "
                    + "campaign.id = "
                    + campaignId;

            GoogleAdsRow result = googleAdsService.Search(
                customerId.ToString(), query).FirstOrDefault();

            if (result == null)
            {
                throw new Exception("No campaign found with ID: " + campaignId);
            }

            // Gets the DSA settings.
            DynamicSearchAdsSetting dynamicSearchAdsSetting =
                result.Campaign.DynamicSearchAdsSetting;

            // Throws an exception if the campaign is not a DSA campaign.
            if (dynamicSearchAdsSetting == null || string.IsNullOrEmpty(
                dynamicSearchAdsSetting.DomainName))
            {
                throw new Exception($"Campaign with ID {campaignId} is not a DSA campaign.");
            }

            return dynamicSearchAdsSetting;
        }

        private void AddDsaTarget(GoogleAdsClient client, long customerId, long adGroupId, string dsaPageUrlLabel)
        {
            // Get the AdGroupCriterionService.
            AdGroupCriterionServiceClient adGroupCriterionService = client.GetService(
                Services.V6.AdGroupCriterionService);

            // Create the webpage condition info.
            WebpageConditionInfo webpageConditionInfo = new WebpageConditionInfo()
            {
                Operand = WebpageConditionOperand.CustomLabel,
                Argument = dsaPageUrlLabel,
            };

            // Creates the webpage info.
            WebpageInfo webpageInfo = new WebpageInfo()
            {
                CriterionName = "Test Criterion",
                Conditions = { webpageConditionInfo }
            };

            // Creates the ad group criterion.
            AdGroupCriterion adGroupCriterion = new AdGroupCriterion()
            {
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                Webpage = webpageInfo,
                CpcBidMicros = 1_500_000
            };

            // Create the operation.
            AdGroupCriterionOperation operation = new AdGroupCriterionOperation()
            {
                Create = adGroupCriterion
            };

            // Add the ad group criterion.
            MutateAdGroupCriteriaResponse mutateAdGroupCriteriaResponse =
                adGroupCriterionService.MutateAdGroupCriteria(customerId.ToString(),
                    new[] { operation });

            // Display the results.
            foreach (MutateAdGroupCriterionResult result in mutateAdGroupCriteriaResponse.Results)
            {
                Console.WriteLine($"Created ad group criterion with resource name " +
                    $"'{result.ResourceName}'.");
            }
        }
    }
}

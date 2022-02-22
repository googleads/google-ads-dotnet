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
using Google.Api.Ads.AdWords.Lib;
using Google.Api.Gax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using aw = global::Google.Api.Ads.AdWords.v201809;
using gag__AdvertisingChannelType = Google.Ads.GoogleAds.V10.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType;
using gag__BudgetDeliveryMethod = Google.Ads.GoogleAds.V10.Enums.BudgetDeliveryMethodEnum.Types.BudgetDeliveryMethod;
using gag__CampaignStatus = Google.Ads.GoogleAds.V10.Enums.CampaignStatusEnum.Types.CampaignStatus;
using gag__NetworkSettings = Google.Ads.GoogleAds.V10.Resources.Campaign.Types.NetworkSettings;

using gagvc = Google.Ads.GoogleAds.V10.Common;
using gagver = Google.Ads.GoogleAds.V10.Errors;
using gagvr = Google.Ads.GoogleAds.V10.Resources;
using gagvs = Google.Ads.GoogleAds.V10.Services;

namespace Google.Ads.GoogleAds.Examples.V10.Migration.CampaignManagement
{
    /// <summary>
    /// This code example is the third in a series of code examples that shows how to create
    /// a Search campaign using the AdWords API, and then migrate it to the Google Ads API one
    /// functionality at a time. See other examples in this directory for code examples in various
    /// stages of migration.
    ///
    /// In this code example, the functionality to create campaign budget and search campaign have
    /// been migrated to the Google Ads API. The rest of the functionality - creating ad groups,
    /// keywords and expanded text ads are done using the AdWords API.
    /// </summary>
    public class CreateCompleteCampaignBothApisPhase2 : ExampleBase
    {
        /// <summary>
        /// Number of ads being added / updated in this code example.
        /// </summary>
        private const int NUMBER_OF_ADS = 5;

        /// <summary>
        /// The list of keywords being added in this code example.
        /// </summary>
        private readonly string[] KEYWORDS_TO_ADD = new string[]
        {
            "mars cruise",
            "space hotel"
        };

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example is the third in a series of code examples that " +
            "shows how to create a Search campaign using the AdWords API, and then " +
            "migrate it to the Google Ads API one functionality at a time. See other " +
            "examples in this directory for code examples in various stages of " +
            "migration. In this code example, the functionality to create campaign " +
            "budget and search campaign have been migrated to the Google Ads API. The " +
            "rest of the functionality - creating ad groups, keywords and expanded " +
            "text ads are done using the AdWords API.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="user">The Google Ads user.</param>
        /// <param name="client">The Google Ads client.</param>
        public void Run(AdWordsUser user, GoogleAdsClient client)
        {
            // Note: The IDs returned for various entities by both APIs are the same, and can
            // be used interchangeably.
            long customerId = long.Parse((user.Config as AdWordsAppConfig).ClientCustomerId);

            gagvr::CampaignBudget budget = CreateBudget(client, customerId);
            gagvr::Campaign campaign = CreateCampaign(client, customerId, budget.Id);
            aw::AdGroup adGroup = CreateAdGroup(user, campaign.Id);
            aw::AdGroupAd[] adGroupAds = CreateTextAds(user, adGroup.id);
            aw::AdGroupCriterion[] adGroupCriteria = CreateKeywords(user, adGroup.id,
                KEYWORDS_TO_ADD);
        }

        /// <summary>
        /// Creates the budget.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>The newly created budget instance.</returns>
        private static gagvr::CampaignBudget CreateBudget(GoogleAdsClient client, long customerId)
        {
            // Get the CampaignBudgetService.
            gagvs::CampaignBudgetServiceClient budgetService = client.GetService(
                Services.V10.CampaignBudgetService);

            // Create the campaign budget.
            gagvr::CampaignBudget budget = new gagvr::CampaignBudget()
            {
                Name = "Interplanetary Cruise Budget #" + ExampleUtilities.GetRandomString(),
                DeliveryMethod = gag__BudgetDeliveryMethod.Standard,
                AmountMicros = 500000
            };

            // Create the operation.
            gagvs::CampaignBudgetOperation budgetOperation = new gagvs::CampaignBudgetOperation()
            {
                Create = budget
            };

            // Create the campaign budget.
            gagvs::MutateCampaignBudgetsResponse response = budgetService.MutateCampaignBudgets(
                customerId.ToString(), new gagvs::CampaignBudgetOperation[] { budgetOperation });

            // Retrieve the newly created budget.
            string newResourceName = response.Results[0].ResourceName;
            gagvr::CampaignBudget newCampaignBudget =
                GetBudget(client, customerId, newResourceName);

            // Display the results.
            Console.WriteLine($"Budget with ID={newCampaignBudget.Id} and name=" +
                $"'{newCampaignBudget.Name}' was created.");

            // Return the newly created budget.
            return newCampaignBudget;
        }

        /// <summary>
        /// Gets the campaign budget.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="budgetResourceName">The budget resource.</param>
        /// <returns>The campaign budget.</returns>
        private static gagvr::CampaignBudget GetBudget(GoogleAdsClient client, long customerId,
            string budgetResourceName)
        {
            // Get the GoogleAdsService.
            gagvs::GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V10.GoogleAdsService);

            // Create the search query.
            string searchQuery = "SELECT campaign_budget.id, campaign_budget.name, " +
                $"campaign_budget.resource_name from campaign_budget where " +
                $"campaign_budget.resource_name='{budgetResourceName}'";

            // Retrieve the campaigns.
            PagedEnumerable<gagvs::SearchGoogleAdsResponse, gagvs::GoogleAdsRow>
                searchPagedResponse = googleAdsService.Search(customerId.ToString(), searchQuery);

            // Return the results.
            return searchPagedResponse.First().CampaignBudget;
        }

        /// <summary>
        /// Creates the campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="budgetId">The budget ID.</param>
        /// <returns>The newly created campaign instance.</returns>
        private static gagvr::Campaign CreateCampaign(GoogleAdsClient client, long customerId,
            long budgetId)
        {
            // Get the CampaignService.
            gagvs::CampaignServiceClient campaignService = client.GetService(
                Services.V10.CampaignService);

            // Create a budget to be used for the campaign.
            string budgetResource = gagver::ResourceNames.CampaignBudget(customerId, budgetId);

            // Create the campaign.
            gagvr::Campaign campaign = new gagvr::Campaign();
            campaign.Name = "Interplanetary Cruise #" + ExampleUtilities.GetRandomString();
            campaign.AdvertisingChannelType = gag__AdvertisingChannelType.Search;

            // Recommendation: Set the campaign to PAUSED when creating it to prevent
            // the ads from immediately serving. Set to ENABLED once you've added
            // targeting and the ads are ready to serve
            campaign.Status = gag__CampaignStatus.Paused;

            // Set the bidding strategy and budget.
            campaign.ManualCpc = new gagvc::ManualCpc();
            campaign.CampaignBudget = budgetResource;

            // Set the campaign network options.
            campaign.NetworkSettings = new gag__NetworkSettings
            {
                TargetGoogleSearch = true,
                TargetSearchNetwork = true,
                TargetContentNetwork = false,
                TargetPartnerSearchNetwork = false
            };

            // Optional: Set the start date.
            campaign.StartDate = DateTime.Now.AddDays(1).ToString("yyyyMMdd");

            // Optional: Set the end date.
            campaign.EndDate = DateTime.Now.AddYears(1).ToString("yyyyMMdd");

            // Create the operation.
            gagvs::CampaignOperation operation = new gagvs::CampaignOperation();
            operation.Create = campaign;

            // Add the campaign.
            gagvs::MutateCampaignsResponse retVal = campaignService.MutateCampaigns(
                customerId.ToString(), new gagvs::CampaignOperation[] { operation });

            // Retrieve the newly created campaign.
            string newResourceName = retVal.Results.First().ResourceName;
            gagvr::Campaign newCampaign = GetCampaign(client, customerId, newResourceName);

            // Display the results.
            Console.WriteLine($"Campaign with ID={newCampaign.Id} and name=" +
            $"'{newCampaign.Name}' was created.");

            // Return the newly created campaign.
            return newCampaign;
        }

        /// <summary>
        /// Gets the campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignResourceName">The campaign resource.</param>
        /// <returns>The campaign.</returns>
        private static gagvr::Campaign GetCampaign(GoogleAdsClient client, long customerId,
            string campaignResourceName)
        {
            // Get the GoogleAdsService.
            gagvs::GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V10.GoogleAdsService);

            // Create the search query.
            string searchQuery = "SELECT campaign.id, campaign.name, " +
                $"campaign.resource_name from campaign where " +
                $"campaign.resource_name='{campaignResourceName}'";

            // Retrieve the campaigns.
            PagedEnumerable<gagvs::SearchGoogleAdsResponse, gagvs::GoogleAdsRow>
                searchPagedResponse = googleAdsService.Search(customerId.ToString(), searchQuery);

            // Return the results.
            return searchPagedResponse.First().Campaign;
        }

        /// <summary>
        /// Creates the ad group.
        /// </summary>
        /// <param name="user">The Google Ads user.</param>
        /// <param name="campaignId">The campaign ID.</param>
        /// <returns>The newly created ad group instance.</returns>
        public aw::AdGroup CreateAdGroup(AdWordsUser user, long campaignId)
        {
            // Get the AdGroupService.
            using (aw::AdGroupService adGroupService =
                (aw::AdGroupService) user.GetService(AdWordsService.v201809.AdGroupService))
            {
                // Create the ad group.
                aw::AdGroup adGroup = new aw::AdGroup
                {
                    name = string.Format("Earth to Mars Cruises #{0}",
                        ExampleUtilities.GetRandomString()),
                    status = aw::AdGroupStatus.ENABLED,
                    campaignId = campaignId,

                    // Set the ad group bids.
                    biddingStrategyConfiguration = new aw::BiddingStrategyConfiguration()
                    {
                        bids = new aw::Bids[]
                        {
                            new aw::CpcBid
                            {
                                bid = new aw::Money
                                {
                                    microAmount = 10000000
                                }
                            }
                        }
                    },

                    // Optional: Set the rotation mode.
                    adGroupAdRotationMode = new aw::AdGroupAdRotationMode
                    {
                        adRotationMode = aw::AdRotationMode.OPTIMIZE
                    }
                };

                // Create the operation.
                aw::AdGroupOperation operation = new aw::AdGroupOperation
                {
                    @operator = aw::Operator.ADD,
                    operand = adGroup
                };

                // Create the ad group.
                aw::AdGroupReturnValue retVal = adGroupService.mutate(
                    new aw::AdGroupOperation[] { operation });

                // Retrieve the newly created ad group.
                aw::AdGroup newAdGroup = retVal.value[0];

                // Display the results.
                Console.WriteLine($"Ad Group with ID={newAdGroup.id} and name=" +
                    $"'{newAdGroup.name}' was created.");

                // Return the newly created ad group.
                return newAdGroup;
            }
        }

        /// <summary>
        /// Creates the text ads.
        /// </summary>
        /// <param name="user">The Google Ads user.</param>
        /// <param name="adGroupId">The ad group ID.</param>
        /// <returns>The list of newly created ad group ads.</returns>
        public aw::AdGroupAd[] CreateTextAds(AdWordsUser user, long adGroupId)
        {
            // Get the AdGroupAdService.
            using (aw::AdGroupAdService adGroupAdService =
                (aw::AdGroupAdService) user.GetService(AdWordsService.v201809.AdGroupAdService))
            {
                List<aw::AdGroupAdOperation> operations = new List<aw::AdGroupAdOperation>();

                for (int i = 0; i < NUMBER_OF_ADS; i++)
                {
                    // Create the expanded text ad.
                    aw::ExpandedTextAd expandedTextAd = new aw::ExpandedTextAd
                    {
                        headlinePart1 = "Cruise #" + i.ToString() + " to Mars",
                        headlinePart2 = "Best Space Cruise Line",
                        headlinePart3 = "For Your Loved Ones",
                        description = "Buy your tickets now!",
                        description2 = "Discount ends soon",
                        finalUrls = new string[]
                        {
                            "http://www.example.com/" + i
                        }
                    };

                    aw::AdGroupAd expandedTextAdGroupAd = new aw::AdGroupAd
                    {
                        adGroupId = adGroupId,
                        ad = expandedTextAd,

                        // Optional: Set the status.
                        status = aw::AdGroupAdStatus.PAUSED
                    };

                    // Create the operation.
                    aw::AdGroupAdOperation operation = new aw::AdGroupAdOperation
                    {
                        @operator = aw::Operator.ADD,
                        operand = expandedTextAdGroupAd
                    };

                    operations.Add(operation);
                }

                // Create the ads.
                aw::AdGroupAdReturnValue retVal = adGroupAdService.mutate(operations.ToArray());

                foreach (aw::AdGroupAd adGroupAd in retVal.value)
                {
                    // Retrieve the newly created ad.
                    aw::ExpandedTextAd newAd = adGroupAd.ad as aw::ExpandedTextAd;

                    // Display the results.
                    Console.WriteLine(
                        "Expanded text ad with ID '{0}' and headline '{1} - {2}' " +
                        "was added.", newAd.id, newAd.headlinePart1, newAd.headlinePart2);
                }

                // Return the newly created ad.
                return retVal.value;
            }
        }

        /// <summary>
        /// Creates the keywords.
        /// </summary>
        /// <param name="user">The Google Ads user.</param>
        /// <param name="adGroupId">The ad group ID.</param>
        /// <param name="keywords">The keywords to create.</param>
        /// <returns>The newly created ad group criteria.</returns>
        public aw::AdGroupCriterion[] CreateKeywords(AdWordsUser user, long adGroupId,
            string[] keywords)
        {
            // Get the AdGroupCriterionService.
            using (aw::AdGroupCriterionService adGroupCriterionService =
                (aw::AdGroupCriterionService) user.GetService(AdWordsService.v201809
                    .AdGroupCriterionService))
            {
                List<aw::AdGroupCriterionOperation> operations =
                    new List<aw::AdGroupCriterionOperation>();

                foreach (string keywordText in keywords)
                {
                    // Create the keyword.
                    aw::Keyword keyword = new aw::Keyword
                    {
                        text = keywordText,
                        matchType = aw::KeywordMatchType.BROAD
                    };

                    // Create the biddable ad group criterion.
                    aw::BiddableAdGroupCriterion keywordCriterion =
                        new aw::BiddableAdGroupCriterion
                        {
                            adGroupId = adGroupId,
                            criterion = keyword,

                            // Optional: Set the user status.
                            userStatus = aw::UserStatus.PAUSED,

                            // Optional: Set the keyword destination url.
                            finalUrls = new aw::UrlList()
                            {
                                urls = new string[]
                            {
                                "http://example.com/mars/cruise/?kw=" +
                                HttpUtility.UrlEncode(keywordText)
                            }
                            }
                        };

                    // Create the operations.
                    aw::AdGroupCriterionOperation operation = new aw::AdGroupCriterionOperation
                    {
                        @operator = aw::Operator.ADD,
                        operand = keywordCriterion
                    };

                    operations.Add(operation);
                }

                // Create the keywords.
                aw::AdGroupCriterionReturnValue retVal =
                    adGroupCriterionService.mutate(operations.ToArray());

                // Display the results.
                foreach (aw::AdGroupCriterion adGroupCriterion in retVal.value)
                {
                    Console.WriteLine(
                        "Keyword with ad group id = '{0}', keyword id = '{1}', text = " +
                        "'{2}' and match type = '{3}' was created.",
                        adGroupCriterion.adGroupId, adGroupCriterion.criterion.id,
                        (adGroupCriterion.criterion as aw::Keyword).text,
                        (adGroupCriterion.criterion as aw::Keyword).matchType);
                }

                // Return the newly created keywords.
                return retVal.value;
            }
        }
    }
}

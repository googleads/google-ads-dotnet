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

using Google.Ads.Gax.Examples;
using Google.Api.Ads.AdWords.Lib;
using System;
using System.Collections.Generic;
using System.Web;

using aw = global::Google.Api.Ads.AdWords.v201809;

namespace Google.Ads.GoogleAds.Examples.V10.Migration.CampaignManagement
{
    /// <summary>
    /// This code example is the first in a series of code examples that shows how to create
    /// a Search campaign using the AdWords API, and then migrate it to Google Ads API one
    /// functionality at a time. See other examples in this directory for code examples in various
    /// stages of migration.
    ///
    /// This code example represents the initial state, where the AdWords API is used to create a
    /// campaign budget, a Search campaign, ad groups, keywords and expanded text ads. None of the
    /// functionality has yet been migrated to the Google Ads API.
    /// </summary>
    public class CreateCompleteCampaignAdWordsApiOnly : ExampleBase
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
            "This code example is the first in a series of code examples that " +
            "shows how to create a Search campaign using the AdWords API, and then " +
            "migrate it to Google Ads API one functionality at a time. See other " +
            "examples in this directory for code examples in various stages of " +
            "migration. This code example represents the initial state, where the " +
            "AdWords API is used to create a campaign budget, a Search campaign, " +
            "ad groups, keywords and expanded text ads. None of the functionality has " +
            "yet been migrated to the Google Ads API.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="user">The Google Ads user.</param>
        public void Run(AdWordsUser user)
        {
            aw::Budget budget = CreateBudget(user);
            aw::Campaign campaign = CreateCampaign(user, budget.budgetId);
            aw::AdGroup adGroup = CreateAdGroup(user, campaign.id);
            aw::AdGroupAd[] adGroupAds = CreateTextAds(user, adGroup.id);
            aw::AdGroupCriterion[] adGroupCriteria = CreateKeywords(user, adGroup.id,
                KEYWORDS_TO_ADD);
        }

        /// <summary>
        /// Creates the budget for the campaign.
        /// </summary>
        /// <param name="user">The Google Ads user.</param>
        /// <returns>The newly created budget instance.</returns>
        private static aw::Budget CreateBudget(AdWordsUser user)
        {
            // Get the BudgetService.
            using (aw::BudgetService budgetService =
                (aw::BudgetService)user.GetService(AdWordsService.v201809.BudgetService))
            {
                // Create the campaign budget.
                aw::Budget budget = new aw::Budget
                {
                    name = "Interplanetary Cruise Budget #" + ExampleUtilities.GetRandomString(),
                    deliveryMethod = aw::BudgetBudgetDeliveryMethod.STANDARD,
                    amount = new aw::Money
                    {
                        microAmount = 500000
                    }
                };

                // Create the operation.
                aw::BudgetOperation budgetOperation = new aw::BudgetOperation
                {
                    @operator = aw::Operator.ADD,
                    operand = budget
                };

                // Create the budget.
                aw::BudgetReturnValue budgetRetval = budgetService.mutate(new aw::BudgetOperation[]
                {
                   budgetOperation
                });

                // Retrieve the newly created budget.
                aw::Budget newBudget = budgetRetval.value[0];

                // Display the results.
                Console.WriteLine($"Budget with ID={newBudget.budgetId} and name=" +
                    $"'{newBudget.name}' was created.");

                // Return the newly created budget.
                return newBudget;
            }
        }

        /// <summary>
        /// Creates the campaign.
        /// </summary>
        /// <param name="user">The Google Ads user.</param>
        /// <param name="budgetId">The budget ID.</param>
        /// <returns>The newly created campaign instance.</returns>
        public aw::Campaign CreateCampaign(AdWordsUser user, long budgetId)
        {
            // Get the CampaignService.
            using (aw::CampaignService campaignService =
                (aw::CampaignService)user.GetService(AdWordsService.v201809.CampaignService))
            {
                // Create the campaign.
                aw::Campaign campaign = new aw::Campaign
                {
                    name = "Interplanetary Cruise #" + ExampleUtilities.GetRandomString(),
                    advertisingChannelType = aw::AdvertisingChannelType.SEARCH,

                    // Recommendation: Set the campaign to PAUSED when creating it to prevent
                    // the ads from immediately serving. Set to ENABLED once you've added
                    // targeting and the ads are ready to serve.
                    status = aw::CampaignStatus.PAUSED
                };

                aw::BiddingStrategyConfiguration biddingConfig =
                    new aw::BiddingStrategyConfiguration
                    {
                        biddingStrategyType = aw::BiddingStrategyType.MANUAL_CPC
                    };
                campaign.biddingStrategyConfiguration = biddingConfig;

                campaign.budget = new aw::Budget
                {
                    budgetId = budgetId
                };

                // Set the campaign network options.
                campaign.networkSetting = new aw::NetworkSetting
                {
                    targetGoogleSearch = true,
                    targetSearchNetwork = true,
                    targetContentNetwork = false,
                    targetPartnerSearchNetwork = false
                };

                // Optional: Set the start date.
                campaign.startDate = DateTime.Now.AddDays(1).ToString("yyyyMMdd");

                // Optional: Set the end date.
                campaign.endDate = DateTime.Now.AddYears(1).ToString("yyyyMMdd");

                // Create the operation.
                aw::CampaignOperation operation = new aw::CampaignOperation
                {
                    @operator = aw::Operator.ADD,
                    operand = campaign
                };

                // Add the campaign.
                aw::CampaignReturnValue retVal = campaignService.mutate(
                    new aw::CampaignOperation[] { operation });

                // Retrieve the newly created campaign.
                aw::Campaign newCampaign = retVal.value[0];

                // Display the results.
                Console.WriteLine($"Campaign with ID={newCampaign.id} and name=" +
                    $"'{newCampaign.name}' was created.");

                // return the newly created campaign.
                return newCampaign;
            }
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
                (aw::AdGroupService)user.GetService(AdWordsService.v201809.AdGroupService))
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
                (aw::AdGroupAdService)user.GetService(AdWordsService.v201809.AdGroupAdService))
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
                (aw::AdGroupCriterionService)user.GetService(AdWordsService.v201809
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
// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using System;

namespace Google.Ads.GoogleAds.Lib
{

    //public class ResourceNames
    //{
        // public static string AccountB(long customerId, long adGroupId)
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/accountBudgets/{account_budget}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/accountBudgetProposals/{account_budget_proposal}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroups/{ad_group}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroupAds/{ad_group_ad}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroupCriteria/{ad_group_criteria}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroupFeeds/{ad_group_feed}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/ageRangeViews/{age_range_view}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/biddingStrategies/{bidding_strategy}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/hotelPerformanceView");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/hotelGroupViews/{hotel_group_view}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("googleAdsFields/{google_ads_field}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("geoTargetConstants/{geo_target_constant}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/genderViews/{gender_view}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/feedMappings/{feed_mapping}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/feedItems/{feed_item}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/feeds/{feed}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/displayKeywordViews/{display_keyword_view}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/customerManagerLinks/{customer_manager_link}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/customerFeeds/{customer_feed}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/customerClientLinks/{customer_client_link}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/customerClients/{customer_client}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/conversionActions/{conversion_action}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/changeStatus/{change_status}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("carrierConstants/{carrier_constant}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignSharedSets/{campaign_shared_set}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignGroups/{campaign_group}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignFeeds/{campaign_feed}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignCriteria/{campaign_criteria}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignBudgets/{campaign_budget}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignBidModifiers/{campaign_bid_modifier}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignAudienceViews/{campaign_audience_view}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/billingSetups/{billing_setup}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaigns/{campaign}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/videos/{video}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/userLists/{user_list}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/userInterests/{user_interest}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/topicViews/{topic_view}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("topicConstants/{topic_constant}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/sharedSets/{shared_set}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/sharedCriteria/{shared_criteria}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/searchTermViews/{search_term_view}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/recommendations/{recommendation}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/productGroupViews/{product_group_view}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/parentalStatusViews/{parental_status_view}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/mediaFiles/{media_file}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/managedPlacementViews/{managed_placement_view}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("languageConstants/{language_constant}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/keywordViews/{keyword_view}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/keywordPlanNegativeKeywords/{keyword_plan_negative_keyword}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/keywordPlanCampaigns/{keyword_plan_campaign}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}");
        //private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/keywordPlans/{keyword_plan}");


        /// <summary>
        /// Helper class to generate resource names for various entities.
        /// </summary>
    public class ResourceNames
    {
        /// <summary>
        /// Generate resource name for an ad group.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="adGroupId">The ad group ID.</param>
        /// <returns>The ad group resource name.</returns>
        public static string AdGroup(long customerId, long adGroupId)
        {
            new PathTemplate("customers/{customer}/accountBudgets/{account_budget}").Expand(customerId.ToString(), adGroupId.ToString());
            return $"customers/{customerId}/adGroups/{adGroupId}";
        }

        /// <summary>
        /// Generate resource name for an ad group ad.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="adGroupId">The ad group ID.</param>
        /// <param name="adId">The ad ID.</param>
        /// <returns>The ad group ad resource name.</returns>
        public static string AdGroupAd(long customerId, long adGroupId, long adId)
        {
            return $"customers/{customerId}/adGroupAds/{adGroupId}_{adId}";
        }

        /// <summary>
        /// Generate resource name for an ad group criterion.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="adGroupId">The ad group ID.</param>
        /// <param name="criterionId">The criterion ID.</param>
        /// <returns>The ad group criterion resource name.</returns>
        public static string AdGroupCriterion(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/adGroupCriteria/{adGroupId}_{criterionId}";
        }

        /// <summary>
        /// Generate resource name for a bidding strategy.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="biddingStrategyId">The bidding strategy ID.</param>
        /// <returns>The bidding strategy resource name.</returns>
        public static string BiddingStrategy(long customerId, long biddingStrategyId)
        {
            return $"customers/{customerId}/biddingStrategies/{biddingStrategyId}";
        }

        /// <summary>
        /// Generate resource name for a budget.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="budgetId">The budget ID.</param>
        /// <returns>The budget resource name.</returns>
        public static string Budget(long customerId, long budgetId)
        {
            return $"customers/{customerId}/budgets/{budgetId}";
        }

        /// <summary>
        /// Generate resource name for a campaign.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="campaignId">The campaign ID.</param>
        /// <returns>The campaign resource name.</returns>
        public static string Campaign(long customerId, long campaignId)
        {
            return $"customers/{customerId}/campaigns/{campaignId}";
        }

        /// <summary>
        /// Generate resource name for a campaign criterion.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="campaignId">The campaign ID.</param>
        /// <param name="criterionId">The criterion ID.</param>
        /// <returns>The campaign criterion resource name.</returns>
        public static string CampaignCriterion(long customerId, long campaignId, long criterionId)
        {
            return $"customers/{customerId}/campaignCriteria/{campaignId}_{criterionId}";
        }

        /// <summary>
        /// Generate resource name for a customer.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <returns>The customer resource name.</returns>
        public static string Customer(long customerId)
        {
            return $"customers/{customerId}";
        }

        /// <summary>
        /// Generate resource name for a Google Ads field.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <returns>The field resource name.</returns>
        public static string GoogleAdsField(long fieldName)
        {
            return $"googleAdsFields/{fieldName}";
        }

        /// <summary>
        /// Generate resource name for a keyword view.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="adGroupId">The ad group ID.</param>
        /// <param name="criterionId">The criterion ID.</param>
        /// <returns>The keyword view resource name.</returns>
        public static string KeywordView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/keywordViews/{adGroupId}_{criterionId}";
        }

        /// <summary>
        /// Generate resource name for an ad group bid modifier.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="adGroupId">The ad group ID.</param>
        /// <param name="criterionId">The criterion ID.</param>
        /// <returns>The ad group bid modifier resource name.</returns>
        public static string AdGroupBidModifier(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/adGroupBidModifiers/{adGroupId}_{criterionId}";
        }

        /// <summary>
        /// Generate resource name for a recommendation.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="recommendationId">The recommendation ID.</param>
        /// <returns>The recommendation resource name.</returns>
        public static string Recommendation(long customerId, long recommendationId)
        {
            return $"customers/{customerId}/recommendations/{recommendationId}";
        }

        /// <summary>
        /// Generate resource name for a language constant.
        /// </summary>
        /// <param name="languageConstantId">The language constant ID.</param>
        /// <returns>The language constant resource name.</returns>
        public static string LanguageConstant(long languageConstantId)
        {
            return $"languageConstants/{languageConstantId}";
        }

        /// <summary>
        /// Generate resource name for a geo target constant.
        /// </summary>
        /// <param name="geoTargetConstantId">The geo target constant ID.</param>
        /// <returns>The geo target constant resource name.</returns>
        public static string GeoTargetConstant(long geoTargetConstantId)
        {
            return $"geoTargetConstants/{geoTargetConstantId}";
        }

        /// <summary>
        /// Generate resource name for a campaign bid modifier.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="campaignBidModifierId">The campaign bid modifier ID.</param>
        /// <returns>The campaign bid modifier resource name.</returns>
        public static string CampaignBidModifier(long customerId, long campaignBidModifierId)
        {
            return $"customers/{customerId}/campaignBidModifiers/{campaignBidModifierId}";
        }

        /// <summary>
        /// Generate resource name for a campaign group.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="campaignGroupId">The campaign group ID.</param>
        /// <returns>The campaign bid modifier resource name.</returns>
        public static string CampaignGroup(long customerId, long campaignGroupId)
        {
            return $"customers/{customerId}/campaignGroups/{campaignGroupId}";
        }

        /// <summary>
        /// Generate resource name for a campaign shared set.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="campaignSharedSetId">The campaign shared set ID.</param>
        /// <returns>The campaign bid modifier resource name.</returns>
        public static string CampaignSharedSet(long customerId, long campaignSharedSetId)
        {
            return $"customers/{customerId}/campaignSharedSets/{campaignSharedSetId}";
        }

        /// <summary>
        /// Generate resource name for a shared criterion.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="sharedCriterionId">The shared criterion ID.</param>
        /// <returns>The shared criterion resource name.</returns>
        public static string SharedCriterion(long customerId, long sharedCriterionId)
        {
            return $"customers/{customerId}/sharedCriteria/{sharedCriterionId}";
        }

        /// <summary>
        /// Generate resource name for a shared set.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="sharedSetId">The shared criterion ID.</param>
        /// <returns>The shared set resource name.</returns>
        public static string SharedSet(long customerId, long sharedSetId)
        {
            return $"customers/{customerId}/sharedSets/{sharedSetId}";
        }

        /// <summary>
        /// Generate resource name for an account budget proposal.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="accountBudgetProposalId">The account budget proposal ID.</param>
        /// <returns>The account budget proposal name.</returns>
        public static string AccountBudgetProposal(long customerId, long accountBudgetProposalId)
        {
            return $"customers/{customerId}/accountBudgetProposals/{accountBudgetProposalId}";
        }

        /// <summary>
        /// Generate resource name for a change status.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="changeStatusId">The change status ID.</param>
        /// <returns>The change status resource name.</returns>
        public static string ChangeStatus(long customerId, long changeStatusId)
        {
            return $"customers/{customerId}/changeStatus/{changeStatusId}";
        }

        /// <summary>
        /// Generate resource name for a conversion action.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="conversionActionId">The conversion action ID.</param>
        /// <returns>The conversion action resource name.</returns>
        public static string ConversionAction(long customerId, long conversionActionId)
        {
            return $"customers/{customerId}/conversionActions/{conversionActionId}";
        }

        /// <summary>
        /// Generate resource name for a billing setup.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="billingSetupId">The billing setup ID.</param>
        /// <returns>The billing setup resource name.</returns>
        public static string BillingSetup(long customerId, long billingSetupId)
        {
            return $"customers/{customerId}/billingSetups/{billingSetupId}";
        }

        /// <summary>
        /// Generate resource name for a video.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="videoId">The video ID.</param>
        /// <returns>The video resource name.</returns>
        public static string Video(long customerId, long videoId)
        {
            return $"customers/{customerId}/videos/{videoId}";
        }
    }
}

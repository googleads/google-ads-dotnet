// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the \"License\");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an \"AS IS\" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;

namespace Google.Ads.GoogleAds.Lib
{
    /// <summary>
    /// Helper class to generate resource names for various entities.
    /// </summary>
    public class ResourceNames
    {

        /// <summary>
        /// Constructs a resource name for AccountBudget entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='accountBudgetId'>The accountBudget ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string AccountBudget(long customerId, long accountBudgetId)
        {
            return new PathTemplate("customers/{customer}/accountBudgets/{account_budget}")
                .Expand(customerId.ToString(), accountBudgetId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for AccountBudgetProposal entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='accountBudgetProposalId'>The accountBudgetProposal ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string AccountBudgetProposal(long customerId, long accountBudgetProposalId)
        {
            return new PathTemplate("customers/{customer}/accountBudgetProposals/{account_budget_proposal}")
                .Expand(customerId.ToString(), accountBudgetProposalId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for AdGroup entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='adGroupId'>The adGroup ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string AdGroup(long customerId, long adGroupId)
        {
            return new PathTemplate("customers/{customer}/adGroups/{ad_group}")
                .Expand(customerId.ToString(), adGroupId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for AdGroupAd entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='adGroupAdId'>The adGroupAd ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string AdGroupAd(long customerId, long adGroupAdId)
        {
            return new PathTemplate("customers/{customer}/adGroupAds/{ad_group_ad}")
                .Expand(customerId.ToString(), adGroupAdId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for AdGroupAudienceView entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='adGroupAudienceViewId'>The adGroupAudienceView ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string AdGroupAudienceView(long customerId, long adGroupAudienceViewId)
        {
            return new PathTemplate("customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}")
                .Expand(customerId.ToString(), adGroupAudienceViewId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for AdGroupBidModifier entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='adGroupBidModifierId'>The adGroupBidModifier ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string AdGroupBidModifier(long customerId, long adGroupBidModifierId)
        {
            return new PathTemplate("customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}")
                .Expand(customerId.ToString(), adGroupBidModifierId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for AdGroupCriteria entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='adGroupCriteriaId'>The adGroupCriteria ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string AdGroupCriteria(long customerId, long adGroupCriteriaId)
        {
            return new PathTemplate("customers/{customer}/adGroupCriteria/{ad_group_criteria}")
                .Expand(customerId.ToString(), adGroupCriteriaId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for AdGroupFeed entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='adGroupFeedId'>The adGroupFeed ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string AdGroupFeed(long customerId, long adGroupFeedId)
        {
            return new PathTemplate("customers/{customer}/adGroupFeeds/{ad_group_feed}")
                .Expand(customerId.ToString(), adGroupFeedId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for AdParameter entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='adParameterId'>The adParameter ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string AdParameter(long customerId, long adParameterId)
        {
            return new PathTemplate("customers/{customer}/adParameters/{ad_parameter}")
                .Expand(customerId.ToString(), adParameterId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for AdScheduleView entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='adScheduleViewId'>The adScheduleView ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string AdScheduleView(long customerId, long adScheduleViewId)
        {
            return new PathTemplate("customers/{customer}/adScheduleViews/{ad_schedule_view}")
                .Expand(customerId.ToString(), adScheduleViewId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for AgeRangeView entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='ageRangeViewId'>The ageRangeView ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string AgeRangeView(long customerId, long ageRangeViewId)
        {
            return new PathTemplate("customers/{customer}/ageRangeViews/{age_range_view}")
                .Expand(customerId.ToString(), ageRangeViewId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for BiddingStrategie entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='biddingStrategyId'>The biddingStrategy ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string BiddingStrategie(long customerId, long biddingStrategyId)
        {
            return new PathTemplate("customers/{customer}/biddingStrategies/{bidding_strategy}")
                .Expand(customerId.ToString(), biddingStrategyId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for BillingSetup entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='billingSetupId'>The billingSetup ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string BillingSetup(long customerId, long billingSetupId)
        {
            return new PathTemplate("customers/{customer}/billingSetups/{billing_setup}")
                .Expand(customerId.ToString(), billingSetupId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for Campaign entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='campaignId'>The campaign ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string Campaign(long customerId, long campaignId)
        {
            return new PathTemplate("customers/{customer}/campaigns/{campaign}")
                .Expand(customerId.ToString(), campaignId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for CampaignAudienceView entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='campaignAudienceViewId'>The campaignAudienceView ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string CampaignAudienceView(long customerId, long campaignAudienceViewId)
        {
            return new PathTemplate("customers/{customer}/campaignAudienceViews/{campaign_audience_view}")
                .Expand(customerId.ToString(), campaignAudienceViewId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for CampaignBidModifier entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='campaignBidModifierId'>The campaignBidModifier ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string CampaignBidModifier(long customerId, long campaignBidModifierId)
        {
            return new PathTemplate("customers/{customer}/campaignBidModifiers/{campaign_bid_modifier}")
                .Expand(customerId.ToString(), campaignBidModifierId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for CampaignBudget entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='campaignBudgetId'>The campaignBudget ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string CampaignBudget(long customerId, long campaignBudgetId)
        {
            return new PathTemplate("customers/{customer}/campaignBudgets/{campaign_budget}")
                .Expand(customerId.ToString(), campaignBudgetId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for CampaignCriteria entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='campaignCriteriaId'>The campaignCriteria ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string CampaignCriteria(long customerId, long campaignCriteriaId)
        {
            return new PathTemplate("customers/{customer}/campaignCriteria/{campaign_criteria}")
                .Expand(customerId.ToString(), campaignCriteriaId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for CampaignFeed entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='campaignFeedId'>The campaignFeed ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string CampaignFeed(long customerId, long campaignFeedId)
        {
            return new PathTemplate("customers/{customer}/campaignFeeds/{campaign_feed}")
                .Expand(customerId.ToString(), campaignFeedId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for CampaignSharedSet entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='campaignSharedSetId'>The campaignSharedSet ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string CampaignSharedSet(long customerId, long campaignSharedSetId)
        {
            return new PathTemplate("customers/{customer}/campaignSharedSets/{campaign_shared_set}")
                .Expand(customerId.ToString(), campaignSharedSetId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for CarrierConstant entity from its component parts.
        /// </summary>
        /// <param name='carrierConstantId'>The carrierConstant ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string CarrierConstant(long carrierConstantId)
        {
            return new PathTemplate("carrierConstants/{carrier_constant}")
                .Expand(carrierConstantId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for ChangeStatu entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='changeStatusId'>The changeStatus ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string ChangeStatu(long customerId, long changeStatusId)
        {
            return new PathTemplate("customers/{customer}/changeStatus/{change_status}")
                .Expand(customerId.ToString(), changeStatusId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for ConversionAction entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='conversionActionId'>The conversionAction ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string ConversionAction(long customerId, long conversionActionId)
        {
            return new PathTemplate("customers/{customer}/conversionActions/{conversion_action}")
                .Expand(customerId.ToString(), conversionActionId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for Customer entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string Customer(long customerId)
        {
            return new PathTemplate("customers/{customer}")
                .Expand(customerId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for CustomerClient entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='customerClientId'>The customerClient ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string CustomerClient(long customerId, long customerClientId)
        {
            return new PathTemplate("customers/{customer}/customerClients/{customer_client}")
                .Expand(customerId.ToString(), customerClientId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for CustomerClientLink entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='customerClientLinkId'>The customerClientLink ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string CustomerClientLink(long customerId, long customerClientLinkId)
        {
            return new PathTemplate("customers/{customer}/customerClientLinks/{customer_client_link}")
                .Expand(customerId.ToString(), customerClientLinkId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for CustomerFeed entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='customerFeedId'>The customerFeed ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string CustomerFeed(long customerId, long customerFeedId)
        {
            return new PathTemplate("customers/{customer}/customerFeeds/{customer_feed}")
                .Expand(customerId.ToString(), customerFeedId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for CustomerManagerLink entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='customerManagerLinkId'>The customerManagerLink ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string CustomerManagerLink(long customerId, long customerManagerLinkId)
        {
            return new PathTemplate("customers/{customer}/customerManagerLinks/{customer_manager_link}")
                .Expand(customerId.ToString(), customerManagerLinkId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for DisplayKeywordView entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='displayKeywordViewId'>The displayKeywordView ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string DisplayKeywordView(long customerId, long displayKeywordViewId)
        {
            return new PathTemplate("customers/{customer}/displayKeywordViews/{display_keyword_view}")
                .Expand(customerId.ToString(), displayKeywordViewId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for Feed entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='feedId'>The feed ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string Feed(long customerId, long feedId)
        {
            return new PathTemplate("customers/{customer}/feeds/{feed}")
                .Expand(customerId.ToString(), feedId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for FeedItem entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='feedItemId'>The feedItem ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string FeedItem(long customerId, long feedItemId)
        {
            return new PathTemplate("customers/{customer}/feedItems/{feed_item}")
                .Expand(customerId.ToString(), feedItemId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for FeedMapping entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='feedMappingId'>The feedMapping ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string FeedMapping(long customerId, long feedMappingId)
        {
            return new PathTemplate("customers/{customer}/feedMappings/{feed_mapping}")
                .Expand(customerId.ToString(), feedMappingId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for GenderView entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='genderViewId'>The genderView ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string GenderView(long customerId, long genderViewId)
        {
            return new PathTemplate("customers/{customer}/genderViews/{gender_view}")
                .Expand(customerId.ToString(), genderViewId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for GeoTargetConstant entity from its component parts.
        /// </summary>
        /// <param name='geoTargetConstantId'>The geoTargetConstant ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string GeoTargetConstant(long geoTargetConstantId)
        {
            return new PathTemplate("geoTargetConstants/{geo_target_constant}")
                .Expand(geoTargetConstantId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for GoogleAdsField entity from its component parts.
        /// </summary>
        /// <param name='googleAdsFieldId'>The googleAdsField ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string GoogleAdsField(long googleAdsFieldId)
        {
            return new PathTemplate("googleAdsFields/{google_ads_field}")
                .Expand(googleAdsFieldId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for HotelGroupView entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='hotelGroupViewId'>The hotelGroupView ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string HotelGroupView(long customerId, long hotelGroupViewId)
        {
            return new PathTemplate("customers/{customer}/hotelGroupViews/{hotel_group_view}")
                .Expand(customerId.ToString(), hotelGroupViewId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for HotelPerformanceView entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string HotelPerformanceView(long customerId)
        {
            return new PathTemplate("customers/{customer}/hotelPerformanceView")
                .Expand(customerId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for KeywordPlan entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='keywordPlanId'>The keywordPlan ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string KeywordPlan(long customerId, long keywordPlanId)
        {
            return new PathTemplate("customers/{customer}/keywordPlans/{keyword_plan}")
                .Expand(customerId.ToString(), keywordPlanId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for KeywordPlanAdGroup entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='keywordPlanAdGroupId'>The keywordPlanAdGroup ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string KeywordPlanAdGroup(long customerId, long keywordPlanAdGroupId)
        {
            return new PathTemplate("customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}")
                .Expand(customerId.ToString(), keywordPlanAdGroupId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for KeywordPlanCampaign entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='keywordPlanCampaignId'>The keywordPlanCampaign ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string KeywordPlanCampaign(long customerId, long keywordPlanCampaignId)
        {
            return new PathTemplate("customers/{customer}/keywordPlanCampaigns/{keyword_plan_campaign}")
                .Expand(customerId.ToString(), keywordPlanCampaignId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for KeywordPlanKeyword entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='keywordPlanKeywordId'>The keywordPlanKeyword ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string KeywordPlanKeyword(long customerId, long keywordPlanKeywordId)
        {
            return new PathTemplate("customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}")
                .Expand(customerId.ToString(), keywordPlanKeywordId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for KeywordPlanNegativeKeyword entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='keywordPlanNegativeKeywordId'>The keywordPlanNegativeKeyword ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string KeywordPlanNegativeKeyword(long customerId, long keywordPlanNegativeKeywordId)
        {
            return new PathTemplate("customers/{customer}/keywordPlanNegativeKeywords/{keyword_plan_negative_keyword}")
                .Expand(customerId.ToString(), keywordPlanNegativeKeywordId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for KeywordView entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='keywordViewId'>The keywordView ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string KeywordView(long customerId, long keywordViewId)
        {
            return new PathTemplate("customers/{customer}/keywordViews/{keyword_view}")
                .Expand(customerId.ToString(), keywordViewId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for LanguageConstant entity from its component parts.
        /// </summary>
        /// <param name='languageConstantId'>The languageConstant ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string LanguageConstant(long languageConstantId)
        {
            return new PathTemplate("languageConstants/{language_constant}")
                .Expand(languageConstantId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for ManagedPlacementView entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='managedPlacementViewId'>The managedPlacementView ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string ManagedPlacementView(long customerId, long managedPlacementViewId)
        {
            return new PathTemplate("customers/{customer}/managedPlacementViews/{managed_placement_view}")
                .Expand(customerId.ToString(), managedPlacementViewId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for MediaFile entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='mediaFileId'>The mediaFile ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string MediaFile(long customerId, long mediaFileId)
        {
            return new PathTemplate("customers/{customer}/mediaFiles/{media_file}")
                .Expand(customerId.ToString(), mediaFileId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for MobileAppCategoryConstant entity from its component parts.
        /// </summary>
        /// <param name='mobileAppCategoryConstantId'>The mobileAppCategoryConstant ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string MobileAppCategoryConstant(long mobileAppCategoryConstantId)
        {
            return new PathTemplate("mobileAppCategoryConstants/{mobile_app_category_constant}")
                .Expand(mobileAppCategoryConstantId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for MobileDeviceConstant entity from its component parts.
        /// </summary>
        /// <param name='mobileDeviceConstantId'>The mobileDeviceConstant ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string MobileDeviceConstant(long mobileDeviceConstantId)
        {
            return new PathTemplate("mobileDeviceConstants/{mobile_device_constant}")
                .Expand(mobileDeviceConstantId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for OperatingSystemVersionConstant entity from its component parts.
        /// </summary>
        /// <param name='operatingSystemVersionConstantId'>The operatingSystemVersionConstant ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string OperatingSystemVersionConstant(long operatingSystemVersionConstantId)
        {
            return new PathTemplate("operatingSystemVersionConstants/{operating_system_version_constant}")
                .Expand(operatingSystemVersionConstantId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for ParentalStatusView entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='parentalStatusViewId'>The parentalStatusView ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string ParentalStatusView(long customerId, long parentalStatusViewId)
        {
            return new PathTemplate("customers/{customer}/parentalStatusViews/{parental_status_view}")
                .Expand(customerId.ToString(), parentalStatusViewId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for ProductGroupView entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='productGroupViewId'>The productGroupView ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string ProductGroupView(long customerId, long productGroupViewId)
        {
            return new PathTemplate("customers/{customer}/productGroupViews/{product_group_view}")
                .Expand(customerId.ToString(), productGroupViewId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for Recommendation entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='recommendationId'>The recommendation ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string Recommendation(long customerId, long recommendationId)
        {
            return new PathTemplate("customers/{customer}/recommendations/{recommendation}")
                .Expand(customerId.ToString(), recommendationId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for RemarketingAction entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='remarketingActionId'>The remarketingAction ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string RemarketingAction(long customerId, long remarketingActionId)
        {
            return new PathTemplate("customers/{customer}/remarketingActions/{remarketing_action}")
                .Expand(customerId.ToString(), remarketingActionId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for SearchTermView entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='searchTermViewId'>The searchTermView ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string SearchTermView(long customerId, long searchTermViewId)
        {
            return new PathTemplate("customers/{customer}/searchTermViews/{search_term_view}")
                .Expand(customerId.ToString(), searchTermViewId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for SharedCriteria entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='sharedCriteriaId'>The sharedCriteria ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string SharedCriteria(long customerId, long sharedCriteriaId)
        {
            return new PathTemplate("customers/{customer}/sharedCriteria/{shared_criteria}")
                .Expand(customerId.ToString(), sharedCriteriaId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for SharedSet entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='sharedSetId'>The sharedSet ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string SharedSet(long customerId, long sharedSetId)
        {
            return new PathTemplate("customers/{customer}/sharedSets/{shared_set}")
                .Expand(customerId.ToString(), sharedSetId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for TopicConstant entity from its component parts.
        /// </summary>
        /// <param name='topicConstantId'>The topicConstant ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string TopicConstant(long topicConstantId)
        {
            return new PathTemplate("topicConstants/{topic_constant}")
                .Expand(topicConstantId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for TopicView entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='topicViewId'>The topicView ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string TopicView(long customerId, long topicViewId)
        {
            return new PathTemplate("customers/{customer}/topicViews/{topic_view}")
                .Expand(customerId.ToString(), topicViewId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for UserInterest entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='userInterestId'>The userInterest ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string UserInterest(long customerId, long userInterestId)
        {
            return new PathTemplate("customers/{customer}/userInterests/{user_interest}")
                .Expand(customerId.ToString(), userInterestId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for UserList entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='userListId'>The userList ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string UserList(long customerId, long userListId)
        {
            return new PathTemplate("customers/{customer}/userLists/{user_list}")
                .Expand(customerId.ToString(), userListId.ToString());
        }

        /// <summary>
        /// Constructs a resource name for Video entity from its component parts.
        /// </summary>
        /// <param name='customerId'>The customer ID.</param>
        /// <param name='videoId'>The video ID.</param>
        /// <returns>The formatted resource name.</returns>
        public static string Video(long customerId, long videoId)
        {
            return new PathTemplate("customers/{customer}/videos/{video}")
                .Expand(customerId.ToString(), videoId.ToString());
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
            return new PathTemplate("customers/{customerId}/adGroupAds/{adGroupId}_{adId}")
                .Expand(customerId.ToString(), adGroupId.ToString(),
                    adId.ToString());
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
            return new PathTemplate("customers/{customerId}/adGroupCriteria/{adGroupId}_{criterionId}")
                .Expand(customerId.ToString(), adGroupId.ToString(),
                    criterionId.ToString());
        }
    }
}

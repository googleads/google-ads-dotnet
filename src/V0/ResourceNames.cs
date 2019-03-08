// Copyright 2018 Google LLC
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

using System;
using System.Text;
using static Google.Ads.GoogleAds.V0.Enums.PlaceholderTypeEnum.Types;

#pragma warning disable 1591

namespace Google.Ads.GoogleAds.V0.Errors
{
    /// <summary>
    /// Helper class to generate resource names for various entities.
    /// </summary>
    public class ResourceNames
    {
        public static string AccountBudgetProposal(long customerId, long accountBudgetProposalId)
        {
            return $"customers/{customerId}/accountBudgetProposals/{accountBudgetProposalId}";
        }

        public static string AdGroup(long customerId, long adGroupId)
        {
            return $"customers/{customerId}/adGroups/{adGroupId}";
        }

        public static string AdGroupAd(long customerId, long adGroupId, long adId)
        {
            return $"customers/{customerId}/adGroupAds/{adGroupId}_{adId}";
        }

        public static string AdGroupAdLabel(long customerId, long adGroupId, long adId, long labelId)
        {
            return $"customers/{customerId}/adGroupAdLabels/{adGroupId}_{adId}_{labelId}";
        }

        public static string AdGroupAudienceView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/adGroupAudienceViews/{adGroupId}_{criterionId}";
        }

        public static string AdGroupBidModifier(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/adGroupBidModifiers/{adGroupId}_{criterionId}";
        }

        public static string AdGroupCriteria(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/adGroupCriteria/{adGroupId}_{criterionId}";
        }

        public static string AdGroupCriterionLabel(long customerId, long adGroupId, long criterionId, long labelId)
        {
            return $"customers/{customerId}/adGroupCriterionLabels/{adGroupId}_{criterionId}_{labelId}";
        }

        public static string AdGroupFeed(long customerId, long adGroupId, long feedId)
        {
            return $"customers/{customerId}/adGroupFeeds/{adGroupId}_{feedId}";
        }

        public static string AdGroupLabel(long customerId, long adGroupId, long labelId)
        {
            return $"customers/{customerId}/adGroupLabels/{adGroupId}_{labelId}";
        }

        public static string AdParameter(long customerId, long adGroupId, long criterionId, long parameterIndex)
        {
            return $"customers/{customerId}/adParameters/{adGroupId}_{criterionId}_{parameterIndex}";
        }

        public static string AdScheduleView(long customerId, long campaignId, long criterionId)
        {
            return $"customers/{customerId}/adScheduleViews/{campaignId}_{criterionId}";
        }

        public static string AgeRangeView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/ageRangeViews/{adGroupId}_{criterionId}";
        }

        public static string BiddingStrategy(long customerId, long biddingStrategyId)
        {
            return $"customers/{customerId}/biddingStrategies/{biddingStrategyId}";
        }

        public static string BillingSetup(long customerId, long billingSetupId)
        {
            return $"customers/{customerId}/billingSetups/{billingSetupId}";
        }

        public static string Campaign(long customerId, long campaignId)
        {
            return $"customers/{customerId}/campaigns/{campaignId}";
        }

        public static string CampaignAudienceView(long customerId, long campaignId, long criterionId)
        {
            return $"customers/{customerId}/campaignAudienceViews/{campaignId}_{criterionId}";
        }

        public static string CampaignBidModifier(long customerId, long campaignId, long criterionId)
        {
            return $"customers/{customerId}/campaignBidModifiers/{campaignId}_{criterionId}";
        }

        public static string CampaignBudget(long customerId, long budgetId)
        {
            return $"customers/{customerId}/campaignBudgets/{budgetId}";
        }

        public static string CampaignCriteria(long customerId, long campaignId, long criterionId)
        {
            return $"customers/{customerId}/campaignCriteria/{campaignId}_{criterionId}";
        }

        public static string CampaignFeed(long customerId, long campaignId, long feedId)
        {
            return $"customers/{customerId}/campaignFeeds/{campaignId}_{feedId}";
        }

        public static string CampaignLabel(long customerId, long campaignId, long labelId)
        {
            return $"customers/{customerId}/campaignLabels/{campaignId}_{labelId}";
        }

        public static string CampaignSharedSet(long customerId, long campaignId, long sharedSetId)
        {
            return $"customers/{customerId}/campaignSharedSets/{campaignId}_{sharedSetId}";
        }

        public static string CarrierConstant(long criterionId)
        {
            return $"carrierConstants/{criterionId}";
        }

        public static string ChangeStatus(long customerId, long changeStatusId)
        {
            return $"customers/{customerId}/changeStatus/{changeStatusId}";
        }

        public static string ClickView(long customerId, DateTime date, string gclid)
        {
            return $"customers/{customerId}/clickViews/{date.ToString("yyyy-MM-dd")}_{gclid}";
        }

        public static string ConversionAction(long customerId, long conversionActionId)
        {
            return $"customers/{customerId}/conversionActions/{conversionActionId}";
        }

        public static string CustomInterest(long customerId, long customInterestId)
        {
            return $"customers/{customerId}/customInterests/{customInterestId}";
        }

        public static string Customer(long customerId)
        {
            return $"customers/{customerId}";
        }

        public static string CustomerClient(long customerId, long clientCustomerId)
        {
            return $"customers/{customerId}/customerClients/{clientCustomerId}";
        }

        public static string CustomerClientLink(long customerId, long clientCustomerId, long managerLinkId)
        {
            return $"customers/{customerId}/customerClientLinks/{clientCustomerId}_{managerLinkId}";
        }

        public static string CustomerFeed(long customerId, long feedId)
        {
            return $"customers/{customerId}/customerFeeds/{feedId}";
        }

        public static string CustomerLabel(long customerId, long labelId)
        {
            return $"customers/{customerId}/customerLabels/{labelId}";
        }

        public static string CustomerManagerLink(long customerId, long manager_customerId, long managerLinkId)
        {
            return $"customers/{customerId}/customerManagerLinks/{manager_customerId}_{managerLinkId}";
        }

        public static string CustomerNegativeCriteria(long customerId, long criterionId)
        {
            return $"customers/{customerId}/customerNegativeCriteria/{criterionId}";
        }

        public static string DetailPlacementView(long customerId, long adGroupId, string placement)
        {
            return $"customers/{customerId}/detailPlacementViews/{adGroupId}_{Base64Encode(placement)}";
        }

        private static string Base64Encode(string text)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        }

        public static string DisplayKeywordView(long customerId, long adGroupId, string criterionId)
        {
            return $"customers/{customerId}/displayKeywordViews/{adGroupId}_{criterionId}";
        }

        public static string DomainCategorie(long customerId, long campaignId, string category, string languageCode)
        {
            return $"customers/{customerId}/domainCategories/{campaignId}_{Base64Encode(category)}_{languageCode}";
        }

        public static string DynamicSearchAdsSearchTermView(long customerId, long adGroupId, string searchTermFp, string headlineFp, string landingPageFp, string pageUrlFp)
        {
            return $"customers/{customerId}/dynamicSearchAdsSearchTermViews/{adGroupId}_{searchTermFp}_{headlineFp}_{landingPageFp}_{pageUrlFp}";
        }

        public static string ExtensionFeedItem(long customerId, long feedItemId)
        {
            return $"customers/{customerId}/extensionFeedItems/{feedItemId}";
        }

        public static string Feed(long customerId, long feedId)
        {
            return $"customers/{customerId}/feeds/{feedId}";
        }

        public static string FeedItem(long customerId, long feedId, long feedItemId)
        {
            return $"customers/{customerId}/feedItems/{feedId}_{feedItemId}";
        }

        public static string FeedMapping(long customerId, long feedId, long feedMappingId)
        {
            return $"customers/{customerId}/feedMappings/{feedId}_{feedMappingId}";
        }

        public static string FeedPlaceholderView(long customerId, PlaceholderType placeholderType)
        {
            return $"customers/{customerId}/feedPlaceholderViews/{placeholderType}";
        }

        public static string GenderView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/genderViews/{adGroupId}_{criterionId}";
        }

        public static string GeoTargetConstant(long geoTargetConstantId)
        {
            return $"geoTargetConstants/{geoTargetConstantId}";
        }

        public static string GeographicView(long customerId, long countryCriterionId, string locationType)
        {
            return $"customers/{customerId}/geographicViews/{countryCriterionId}_{locationType}";
        }

        public static string GoogleAdsField(string name)
        {
            return $"googleAdsFields/{name}";
        }

        public static string GroupPlacementView(long customerId, long adGroupId, string placement)
        {
            return $"customers/{customerId}/groupPlacementViews/{adGroupId}_{Base64Encode(placement)}";
        }

        public static string HotelGroupView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/hotelGroupViews/{adGroupId}_{criterionId}";
        }

        public static string HotelPerformanceView(long customerId)
        {
            return $"customers/{customerId}/hotelPerformanceView";
        }

        public static string KeywordPlan(long customerId, long kpPlanId)
        {
            return $"customers/{customerId}/keywordPlans/{kpPlanId}";
        }

        public static string KeywordPlanAdGroup(long customerId, long kpAdGroupId)
        {
            return $"customers/{customerId}/keywordPlanAdGroups/{kpAdGroupId}";
        }

        public static string KeywordPlanCampaign(long customerId, long kpCampaignId)
        {
            return $"customers/{customerId}/keywordPlanCampaigns/{kpCampaignId}";
        }

        public static string KeywordPlanKeyword(long customerId, long kpAdGroupKeywordId)
        {
            return $"customers/{customerId}/keywordPlanKeywords/{kpAdGroupKeywordId}";
        }

        public static string KeywordPlanNegativeKeyword(long customerId, long kpNegativeKeywordId)
        {
            return $"customers/{customerId}/keywordPlanNegativeKeywords/{kpNegativeKeywordId}";
        }

        public static string KeywordView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/keywordViews/{adGroupId}_{criterionId}";
        }

        public static string Label(long customerId, long labelId)
        {
            return $"customers/{customerId}/labels/{labelId}";
        }

        public static string LanguageConstant(long criterionId)
        {
            return $"languageConstants/{criterionId}";
        }

        public static string LocationView(long customerId, long campaignId, long criterionId)
        {
            return $"customers/{customerId}/locationViews/{campaignId}_{criterionId}";
        }

        public static string ManagedPlacementView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/managedPlacementViews/{adGroupId}_{criterionId}";
        }

        public static string MediaFile(long customerId, long mediaFileId)
        {
            return $"customers/{customerId}/mediaFiles/{mediaFileId}";
        }

        public static string MerchantCenterLink(long customerId, long merchantCenterId)
        {
            return $"customers/{customerId}/merchantCenterLinks/{merchantCenterId}";
        }

        public static string MobileAppCategoryConstant(long mobileAppCategoryId)
        {
            return $"mobileAppCategoryConstants/{mobileAppCategoryId}";
        }

        public static string MobileDeviceConstant(long criterionId)
        {
            return $"mobileDeviceConstants/{criterionId}";
        }

        public static string MobileDeviceConstant(long customerId, long mutateJobId)
        {
            return $"customers/{customerId}/mutateJobs/{mutateJobId}";
        }

        public static string OperatingSystemVersionConstant(long criterionId)
        {
            return $"operatingSystemVersionConstants/{criterionId}";
        }

        public static string ParentalStatusView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/parentalStatusViews/{adGroupId}_{criterionId}";
        }

        public static string PaymentsAccount(long customerId, long paymentsAccountId)
        {
            return $"customers/{customerId}/paymentsAccounts/{paymentsAccountId}";
        }

        public static string ProductBiddingCategoryConstant(string country_code, long level, long id)
        {
            return $"productBiddingCategoryConstants/{country_code}_{level}_{id}";
        }

        public static string ProductGroupView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/productGroupViews/{adGroupId}_{criterionId}";
        }

        public static string Recommendation(long customerId, long recommendationId)
        {
            return $"customers/{customerId}/recommendations/{recommendationId}";
        }

        public static string RemarketingAction(long customerId, long remarketingActionId)
        {
            return $"customers/{customerId}/remarketingActions/{remarketingActionId}";
        }

        public static string SearchTermView(long customerId, long campaignId, long adGroupId, string searchterm)
        {
            return $"customers/{customerId}/searchTermViews/{campaignId}_{adGroupId}_{Base64Encode(searchterm)}";
        }

        public static string SharedCriterion(long customerId, long sharedSetId, long criterionId)
        {
            return $"customers/{customerId}/sharedCriteria/{sharedSetId}_{criterionId}";
        }

        public static string SharedSet(long customerId, long sharedSetId)
        {
            return $"customers/{customerId}/sharedSets/{sharedSetId}";
        }

        public static string ShoppingPerformanceView(long customerId)
        {
            return $"customers/{customerId}/shoppingPerformanceView";
        }

        public static string TopicConstant(long topicId)
        {
            return $"topicConstants/{topicId}";
        }

        public static string TopicView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/topicViews/{adGroupId}_{criterionId}";
        }

        public static string UserInterest(long customerId, long userInterestId)
        {
            return $"customers/{customerId}/userInterests/{userInterestId}";
        }

        public static string UserList(long customerId, long userListId)
        {
            return $"customers/{customerId}/userLists/{userListId}";
        }

        public static string Video(long customerId, long videoId)
        {
            return $"customers/{customerId}/videos/{videoId}";
        }
    }
}

#pragma warning restore 1591

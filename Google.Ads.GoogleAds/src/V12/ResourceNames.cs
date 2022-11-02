// Copyright 2022 Google LLC
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

using Google.Ads.Gax.Util;
using Google.Ads.GoogleAds.Util;
using Google.Protobuf.Reflection;
using System;
using System.Linq;
using System.Text;
using static Google.Ads.GoogleAds.V12.Enums.AssetFieldTypeEnum.Types;
using static Google.Ads.GoogleAds.V12.Enums.ConversionActionCategoryEnum.Types;
using static Google.Ads.GoogleAds.V12.Enums.ConversionOriginEnum.Types;
using static Google.Ads.GoogleAds.V12.Enums.ExtensionTypeEnum.Types;
using static Google.Ads.GoogleAds.V12.Enums.FeedItemTargetTypeEnum.Types;
using static Google.Ads.GoogleAds.V12.Enums.PlaceholderTypeEnum.Types;
using static Google.Ads.GoogleAds.V12.Enums.ProductBiddingCategoryLevelEnum.Types;
using static Google.Ads.GoogleAds.V12.Enums.SimulationModificationMethodEnum.Types;
using static Google.Ads.GoogleAds.V12.Enums.SimulationTypeEnum.Types;

#pragma warning disable 1591

namespace Google.Ads.GoogleAds.V12.Errors
{
    /// <summary>
    /// Helper class to generate resource names for various entities.
    /// </summary>
    public class ResourceNames
    {
        public static string AccessibleBiddingStrategy(long customerId, long biddingStrategyId)
        {
            return $"customers/{customerId}/accessibleBiddingStrategies/{biddingStrategyId}";
        }

        public static string AccountBudgetProposal(long customerId, long accountBudgetProposalId)
        {
            return $"customers/{customerId}/accountBudgetProposals/{accountBudgetProposalId}";
        }

        public static string AccountLink(long customerId, long accountLinkId)
        {
            return $"customers/{customerId}/accountLinks/{accountLinkId}";
        }

        public static string Ad(long customerId, long adId)
        {
            return $"customers/{customerId}/ads/{adId}";
        }

        public static string AdGroup(long customerId, long adGroupId)
        {
            return $"customers/{customerId}/adGroups/{adGroupId}";
        }

        public static string AdGroupAd(long customerId, long adGroupId, long adId)
        {
            return $"customers/{customerId}/adGroupAds/{adGroupId}~{adId}";
        }

        public static string AdGroupAdAssetCombinationView(long customerId, long adGroupId,
            long adId, long assetCombinationIdLow, long assetCombinationIdHigh)
        {
            return $"customers/{customerId}/adGroupAdAssetCombinationViews/" +
                $"{adGroupId}~{adId}~{assetCombinationIdLow}~{assetCombinationIdHigh}";
        }

        public static string AdGroupAdLabel(long customerId, long adGroupId, long adId,
            long labelId)
        {
            return $"customers/{customerId}/adGroupAdLabels/{adGroupId}~{adId}~{labelId}";
        }

        public static string AdGroupAsset(long customerId, long adGroupId, long assetId,
            AssetFieldType fieldType)
        {
            return $"customers/{customerId}/adGroupAssets/{adGroupId}~{assetId}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(fieldType)}";
        }

        public static string AdGroupAssetSet(long customerId, long adGroupId, long assetSetId)
        {
            return $"customers/{customerId}/adGroupAssetSets/{adGroupId}~{assetSetId}";
        }

        public static string AdGroupAudienceView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/adGroupAudienceViews/{adGroupId}~{criterionId}";
        }

        public static string AdGroupBidModifier(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/adGroupBidModifiers/{adGroupId}~{criterionId}";
        }

        public static string AdGroupCriterion(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/adGroupCriteria/{adGroupId}~{criterionId}";
        }

        public static string AdGroupCriterionCustomizer(long customerId, long adGroupId,
            long criterionId, long customizerAttributeId)
        {
            return $"customers/{customerId}/adGroupCriterionCustomizers/{adGroupId}~" +
                $"{criterionId}~{customizerAttributeId}";
        }

        public static string AdGroupCriterionLabel(long customerId, long adGroupId,
            long criterionId, long labelId)
        {
            return $"customers/{customerId}/adGroupCriterionLabels/{adGroupId}~{criterionId}" +
                $"~{labelId}";
        }

        public static string AdGroupCriterionSimulation(long customerId, long adGroupId,
            long criterionId, SimulationType type, SimulationModificationMethod modificationMethod,
            DateTime startDate, DateTime endDate)
        {
            return $"customers/{customerId}/adGroupCriterionSimulations/{adGroupId}~" +
                $"{criterionId}~{ProtobufUtilities.GetOriginalEnumFieldName(type)}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(modificationMethod)}~" +
                $"{startDate:yyyy-MM-dd}" +
                $"~{endDate:yyyy-MM-dd}";
        }

        public static string AdGroupCustomizer(long customerId, long adGroupId,
            long customizerAttributeId)
        {
            return $"customers/{customerId}/adGroupCustomizers/{adGroupId}~" +
                $"{customizerAttributeId}";
        }

        public static string AdGroupExtensionSetting(long customerId, long adGroupId,
            ExtensionType extensionType)
        {
            return $"customers/{customerId}/adGroupExtensionSettings/{adGroupId}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(extensionType)}";
        }

        public static string AdGroupFeed(long customerId, long adGroupId, long feedId)
        {
            return $"customers/{customerId}/adGroupFeeds/{adGroupId}~{feedId}";
        }

        public static string AdGroupLabel(long customerId, long adGroupId, long labelId)
        {
            return $"customers/{customerId}/adGroupLabels/{adGroupId}~{labelId}";
        }

        public static string AdGroupSimulation(long customerId, long adGroupId,
            SimulationType type, SimulationModificationMethod modificationMethod,
            DateTime startDate, DateTime endDate)
        {
            return $"customers/{customerId}/adGroupSimulations/{adGroupId}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(type)}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(modificationMethod)}~" +
                $"{startDate:yyyy-MM-dd}~{endDate:yyyy-MM-dd}";
        }

        public static string AdParameter(long customerId, long adGroupId, long criterionId,
            long parameterIndex)
        {
            return $"customers/{customerId}/adParameters/{adGroupId}~{criterionId}~" +
                $"{parameterIndex}";
        }

        public static string AdScheduleView(long customerId, long campaignId, long criterionId)
        {
            return $"customers/{customerId}/adScheduleViews/{campaignId}~{criterionId}";
        }

        public static string AgeRangeView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/ageRangeViews/{adGroupId}~{criterionId}";
        }

        public static string Asset(long customerId, long assetId)
        {
            return $"customers/{customerId}/assets/{assetId}";
        }

        public static string AssetFieldTypeView(long customerId, AssetFieldType fieldType)
        {
            return $"customers/{customerId}/assetFieldTypeViews/" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(fieldType)}";
        }

        public static string AssetGroup(long customerId, long assetGroupId)
        {
            return $"customers/{customerId}/assetGroups/{assetGroupId}";
        }

        public static string AssetGroupAsset(long customerId, long assetGroupId, long assetId,
            AssetFieldType fieldType)
        {
            return $"customers/{customerId}/assetGroupAssets/{assetGroupId}~{assetId}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(fieldType)}";
        }

        public static string AssetGroupListingGroupFilter(long customerId, long assetGroupId,
            long listingGroupFilterId)
        {
            return $"customers/{customerId}/assetGroupListingGroupFilters/{assetGroupId}~" +
                $"{listingGroupFilterId}";
        }

        public static string AssetGroupProductGroupView(long customerId, long assetGroupId,
            long listingGroupFilterId)
        {
            return $"customers/{customerId}/assetGroupProductGroupViews/{assetGroupId}~" +
                $"{listingGroupFilterId}";
        }

        public static string AssetGroupSignal(long customerId, long assetGroupIdCriterionId)
        {
            return $"customers/{customerId}/assetGroupSignals/{assetGroupIdCriterionId}";
        }

        public static string AssetSet(long customerId, long assetSetId, long assetId)
        {
            return $"customers/{customerId}/assetSets/{assetSetId}";
        }

        public static string AssetSetAsset(long customerId, long assetSetId, long assetId)
        {
            return $"customers/{customerId}/assetSetAssets/{assetSetId}~{assetId}";
        }

        public static string Audience(long customerId, long audienceId)
        {
            return $"customers/{customerId}/audiences/{audienceId}";
        }

        public static string BatchJob(long customerId, long batchJobId)
        {
            return $"customers/{customerId}/batchJobs/{batchJobId}";
        }

        public static string BiddingDataExclusions(long customerId, long seasonalityEventId)
        {
            return $"customers/{customerId}/biddingDataExclusions/{seasonalityEventId}";
        }

        public static string BiddingSeasonalityAdjustment(long customerId, long seasonalityEventId)
        {
            return $"customers/{customerId}/biddingSeasonalityAdjustments/{seasonalityEventId}";
        }

        public static string BiddingStrategy(long customerId, long biddingStrategyId)
        {
            return $"customers/{customerId}/biddingStrategies/{biddingStrategyId}";
        }

        public static string BiddingStrategySimulation(long customerId, long biddingStrategyId,
            SimulationType type, SimulationModificationMethod modificationMethod,
            DateTime startDate, DateTime endDate)
        {
            return $"customers/{customerId}/biddingStrategySimulations/{biddingStrategyId}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(type)}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(modificationMethod)}~" +
                $"{startDate:yyyy-MM-dd}~{endDate:yyyy-MM-dd}";
        }

        public static string BillingSetup(long customerId, long billingSetupId)
        {
            return $"customers/{customerId}/billingSetups/{billingSetupId}";
        }

        public static string Campaign(long customerId, long campaignId)
        {
            return $"customers/{customerId}/campaigns/{campaignId}";
        }

        public static string CampaignAsset(long customerId, long campaignAssetId)
        {
            return $"customers/{customerId}/campaignAssets/{campaignAssetId}";
        }

        public static string CampaignAssetSet(long customerId, long campaignId, long assetSetId)
        {
            return $"customers/{customerId}/campaignAssetSets/{campaignId}~{assetSetId}";
        }

        public static string CampaignAudienceView(long customerId, long campaignId,
            long criterionId)
        {
            return $"customers/{customerId}/campaignAudienceViews/{campaignId}~{criterionId}";
        }

        public static string CampaignBidModifier(long customerId, long campaignId,
            long criterionId)
        {
            return $"customers/{customerId}/campaignBidModifiers/{campaignId}~{criterionId}";
        }

        public static string CampaignBudget(long customerId, long budgetId)
        {
            return $"customers/{customerId}/campaignBudgets/{budgetId}";
        }

        public static string CampaignConversionGoal(long customerId, long campaignId,
            ConversionActionCategory category, ConversionOrigin origin)
        {
            return $"customers/{customerId}/campaignConversionGoals/{campaignId}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(category)}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(origin)}";
        }

        public static string CampaignCriteria(long customerId, long campaignId, long criterionId)
        {
            return $"customers/{customerId}/campaignCriteria/{campaignId}~{criterionId}";
        }

        public static string CampaignCriterionSimulation(long customerId, long campaignId,
            long criterionId, SimulationType type, SimulationModificationMethod modificationMethod,
            DateTime startDate, DateTime endDate)
        {
            return $"customers/{customerId}/campaignCriterionSimulations/{campaignId}~" +
                $"{criterionId}~{ProtobufUtilities.GetOriginalEnumFieldName(type)}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(modificationMethod)}~" +
                $"{startDate:yyyy-MM-dd}~{endDate:yyyy-MM-dd}";
        }

        public static string CampaignCustomizer(long customerId, long campaignId,
            long customizerAttributeId)
        {
            return $"customers/{customerId}/campaignCustomizers/{campaignId}~" +
                $"{customizerAttributeId}";
        }

        public static string CampaignDraft(long customerId, long baseCampaignId, long draftId)
        {
            return $"customers/{customerId}/campaignDrafts/{baseCampaignId}~{draftId}";
        }

        public static string CampaignExperiment(long customerId, long campaignExperimentId)
        {
            return $"customers/{customerId}/campaignExperiments/{campaignExperimentId}";
        }

        public static string CampaignExtensionSetting(long customerId, long campaignId,
            ExtensionType extensionType)
        {
            return $"customers/{customerId}/campaignExtensionSettings/{campaignId}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(extensionType)}";
        }

        public static string CampaignFeed(long customerId, long campaignId, long feedId)
        {
            return $"customers/{customerId}/campaignFeeds/{campaignId}~{feedId}";
        }

        public static string CampaignGroup(long customerId, long campaignGroupId)
        {
            return $"customers/{customerId}/campaignGroups/{campaignGroupId}";
        }

        public static string CampaignLabel(long customerId, long campaignId, long labelId)
        {
            return $"customers/{customerId}/campaignLabels/{campaignId}~{labelId}";
        }

        public static string CampaignSharedSet(long customerId, long campaignId, long sharedSetId)
        {
            return $"customers/{customerId}/campaignSharedSets/{campaignId}~{sharedSetId}";
        }

        public static string CampaignSimulation(long customerId, long campaignId,
            SimulationType type, SimulationModificationMethod modificationMethod,
            DateTime startDate, DateTime endDate)
        {
            return $"customers/{customerId}/campaignSimulations/{campaignId}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(type)}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(modificationMethod)}~" +
                $"{startDate:yyyy-MM-dd}~{endDate:yyyy-MM-dd}";
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
            return $"customers/{customerId}/clickViews/{date:yyyy-MM-dd}~{gclid}";
        }

        public static string CombinedAudience(long customerId, long combinedAudienceId)
        {
            return $"customers/{customerId}/combinedAudiences/{combinedAudienceId}";
        }

        public static string ConversionAction(long customerId, long conversionActionId)
        {
            return $"customers/{customerId}/conversionActions/{conversionActionId}";
        }

        public static string ConversionCustomVariable(long customerId,
            long conversionCustomVariableId)
        {
            return $"customers/{customerId}/conversionCustomVariables/" +
                $"{conversionCustomVariableId}";
        }

        public static string ConversionGoalCampaignConfig(long customerId, long campaignId)
        {
            return $"customers/{customerId}/conversionGoalCampaignConfigs/{campaignId}";
        }

        public static string ConversionValueRule(long customerId, long conversionValueRuleId)
        {
            return $"customers/{customerId}/conversionValueRules/{conversionValueRuleId}";
        }

        public static string ConversionValueRuleSet(long customerId, long conversionValueRuleSetId)
        {
            return $"customers/{customerId}/conversionValueRuleSets/{conversionValueRuleSetId}";
        }

        public static string CurrencyConstant(string currencyCode)
        {
            return $"currencyConstants/{currencyCode}";
        }

        public static string CustomConversionGoal(long customerId, long goalId)
        {
            return $"customers/{customerId}/customConversionGoals/{goalId}";
        }

        public static string Customer(long customerId)
        {
            return $"customers/{customerId}";
        }

        public static string CustomerAsset(long customerId, long assetId, AssetFieldType fieldType)
        {
            return $"customers/{customerId}/customerAssets/{assetId}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(fieldType)}";
        }

        public static string CustomerAssetSet(long customerId, long assetSetId)
        {
            return $"customers/{customerId}/customerAssetSets/{assetSetId}";
        }

        public static string CustomerClient(long customerId, long clientCustomerId)
        {
            return $"customers/{customerId}/customerClients/{clientCustomerId}";
        }

        public static string CustomerClientLink(long customerId, long clientCustomerId,
            long managerLinkId)
        {
            return $"customers/{customerId}/customerClientLinks/" +
                $"{clientCustomerId}~{managerLinkId}";
        }

        public static string CustomerConversionGoal(long customerId,
            ConversionActionCategory category, ConversionOrigin origin)
        {
            return $"customers/{customerId}/customerConversionGoals/" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(category)}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(origin)}";
        }

        public static string CustomerCustomizer(long customerId, long customizerAttributeId)
        {
            return $"customers/{customerId}/customerCustomizers/{customizerAttributeId}";
        }

        public static string CustomerExtensionSetting(long customerId, ExtensionType extensionType)
        {
            return $"customers/{customerId}/customerExtensionSettings/" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(extensionType)}";
        }

        public static string CustomerFeed(long customerId, long feedId)
        {
            return $"customers/{customerId}/customerFeeds/{feedId}";
        }

        public static string CustomerLabel(long customerId, long labelId)
        {
            return $"customers/{customerId}/customerLabels/{labelId}";
        }

        public static string CustomerManagerLink(long customerId, long managerCustomerId,
            long managerLinkId)
        {
            return $"customers/{customerId}/customerManagerLinks/{managerCustomerId}~" +
                $"{managerLinkId}";
        }

        public static string CustomerNegativeCriteria(long customerId, long criterionId)
        {
            return $"customers/{customerId}/customerNegativeCriteria/{criterionId}";
        }

        public static string CustomerUserAccess(long customerId, long userId)
        {
            return $"customers/{customerId}/customerUserAccesses/{userId}";
        }

        public static string CustomerUserAccessInvitation(long customerId, long invitationId)

        {
            return $"customers/{customerId}/customerUserAccessInvitations/{invitationId}";
        }

        public static string CustomInterest(long customerId, long customInterestId)
        {
            return $"customers/{customerId}/customInterests/{customInterestId}";
        }

        public static string CustomizerAttribute(long customerId,
            long customizerAttributeId)
        {
            return $"customers/{customerId}/customizerAttributes/{customizerAttributeId}";
        }

        public static string DetailedDemographic(long customerId, long detailedDemographicId)
        {
            return $"customers/{customerId}/detailedDemographics/{detailedDemographicId}";
        }

        public static string DetailPlacementView(long customerId, long adGroupId, string placement)
        {
            return $"customers/{customerId}/detailPlacementViews/{adGroupId}~" +
                $"{Base64Encode(placement)}";
        }

        public static string DisplayKeywordView(long customerId, long adGroupId,
            string criterionId)
        {
            return $"customers/{customerId}/displayKeywordViews/{adGroupId}~{criterionId}";
        }

        public static string DomainCategory(long customerId, long campaignId, string category,
            string languageCode)
        {
            return $"customers/{customerId}/domainCategories/{campaignId}~" +
                $"{Base64Encode(category)}~{languageCode}";
        }

        public static string DynamicSearchAdsSearchTermView(long customerId, long adGroupId,
            string searchTermFp, string headlineFp, string landingPageFp, string pageUrlFp)
        {
            return $"customers/{customerId}/dynamicSearchAdsSearchTermViews/{adGroupId}~" +
                $"{searchTermFp}~{headlineFp}~{landingPageFp}~{pageUrlFp}";
        }

        public static string ExpandedLandingPageView(long customerId,
            string expandedFinalUrlFingerprint)
        {
            return $"customers/{customerId}/expandedLandingPageViews/" +
                $"{expandedFinalUrlFingerprint}";
        }

        public static string ExtensionFeedItem(long customerId, long feedItemId)
        {
            return $"customers/{customerId}/extensionFeedItems/{feedItemId}";
        }

        public static string Experiment(long customerId, long trialId)
        {
            return $"customers/{customerId}/experiments/{trialId}";
        }

        public static string ExperimentArm(long customerId, long trialId, long trialArmId)
        {
            return $"customers/{customerId}/experimentArms/{trialId}~{trialArmId}";
        }

        public static string Feed(long customerId, long feedId)
        {
            return $"customers/{customerId}/feeds/{feedId}";
        }

        public static string FeedItem(long customerId, long feedId, long feedItemId)
        {
            return $"customers/{customerId}/feedItems/{feedId}~{feedItemId}";
        }

        public static string FeedItemSet(long customerId, long feedId, long feedItemSetId)
        {
            return $"customers/{customerId}/feedItemSets/{feedId}~{feedItemSetId}";
        }

        public static string FeedItemSetLink(long customerId, long feedId, long feedItemId,
            long feedItemSetId)
        {
            return $"customers/{customerId}/feedItemSetLinks/" +
                $"{feedId}~{feedItemId}~{feedItemSetId}";
        }

        public static string FeedItemTarget(long customerId, long feedId, long feedItemId,
            FeedItemTargetType feedItemTargetType, long feedItemTargetId)
        {
            return $"customers/{customerId}/feedItemTargets/{feedId}~{feedItemId}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(feedItemTargetType)}~" +
                $"{feedItemTargetId}";
        }

        public static string FeedMapping(long customerId, long feedId, long feedMappingId)
        {
            return $"customers/{customerId}/feedMappings/{feedId}~{feedMappingId}";
        }

        public static string FeedPlaceholderView(long customerId, PlaceholderType placeholderType)
        {
            return $"customers/{customerId}/feedPlaceholderViews/" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(placeholderType)}";
        }

        public static string GenderView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/genderViews/{adGroupId}~{criterionId}";
        }

        public static string GeographicView(long customerId, long countryCriterionId,
            string locationType)
        {
            return $"customers/{customerId}/geographicViews/{countryCriterionId}~{locationType}";
        }

        public static string GeoTargetConstant(long geoTargetConstantId)
        {
            return $"geoTargetConstants/{geoTargetConstantId}";
        }

        public static string GoogleAdsField(string name)
        {
            return $"googleAdsFields/{name}";
        }

        public static string GroupPlacementView(long customerId, long adGroupId, string placement)
        {
            return $"customers/{customerId}/groupPlacementViews/{adGroupId}~" +
                $"{Base64Encode(placement)}";
        }

        public static string HotelGroupView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/hotelGroupViews/{adGroupId}~{criterionId}";
        }

        public static string HotelPerformanceView(long customerId)
        {
            return $"customers/{customerId}/hotelPerformanceView";
        }

        public static string HotelReconciliation(long customerId, long commissionId)
        {
            return $"customers/{customerId}/hotelReconciliations/{commissionId}";
        }

        public static string IncomeRangeView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/incomeRangeViews/{adGroupId}~{criterionId}";
        }

        public static string KeywordPlan(long customerId, long kpPlanId)
        {
            return $"customers/{customerId}/keywordPlans/{kpPlanId}";
        }

        public static string KeywordPlanAdGroup(long customerId, long kpAdGroupId)
        {
            return $"customers/{customerId}/keywordPlanAdGroups/{kpAdGroupId}";
        }

        public static string KeywordPlanAdGroupKeyword(long customerId, string kpAdGroupKeyword)
        {
            return $"customers/{customerId}/keywordPlanAdGroupKeywords/{kpAdGroupKeyword}";
        }

        public static string KeywordPlanCampaign(long customerId, long kpCampaignId)
        {
            return $"customers/{customerId}/keywordPlanCampaigns/{kpCampaignId}";
        }

        public static string KeywordPlanCampaignKeyword(long customerId, string kpCampaignKeyword)
        {
            return $"customers/{customerId}/keywordPlanCampaignKeywords/{kpCampaignKeyword}";
        }

        public static string KeywordPlanKeyword(long customerId, long kpAdGroupKeywordId)
        {
            return $"customers/{customerId}/keywordPlanKeywords/{kpAdGroupKeywordId}";
        }

        public static string KeywordPlanNegativeKeyword(long customerId, long kpNegativeKeywordId)
        {
            return $"customers/{customerId}/keywordPlanNegativeKeywords/{kpNegativeKeywordId}";
        }

        public static string KeywordThemeConstant(long expressCategoryId,
            long expressSubCategoryId)
        {
            return $"keywordThemeConstants/{expressCategoryId}~{expressSubCategoryId}";
        }

        public static string KeywordView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/keywordViews/{adGroupId}~{criterionId}";
        }

        public static string Label(long customerId, long labelId)
        {
            return $"customers/{customerId}/labels/{labelId}";
        }

        public static string LandingPageView(long customerId, string unexpandedFinalUrlFingerprint)
        {
            return $"customers/{customerId}/landingPageViews/{unexpandedFinalUrlFingerprint}";
        }

        public static string LanguageConstant(long criterionId)
        {
            return $"languageConstants/{criterionId}";
        }

        public static string LeadFormSubmissionData(long customerId, long leadFormSubmissionDataId)
        {
            return $"customers/{customerId}/leadFormSubmissionData/{leadFormSubmissionDataId}";
        }

        public static string LifeEvent(long customerId, long lifeEventId)
        {
            return $"customers/{customerId}/lifeEvents/{lifeEventId}";
        }

        public static string LocationView(long customerId, long campaignId, long criterionId)
        {
            return $"customers/{customerId}/locationViews/{campaignId}~{criterionId}";
        }

        public static string ManagedPlacementView(long customerId, long adGroupId,
            long criterionId)
        {
            return $"customers/{customerId}/managedPlacementViews/{adGroupId}~{criterionId}";
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

        public static string MutateJob(long customerId, long mutateJobId)
        {
            return $"customers/{customerId}/mutateJobs/{mutateJobId}";
        }

        public static string OperatingSystemVersionConstant(long criterionId)
        {
            return $"operatingSystemVersionConstants/{criterionId}";
        }

        public static string PaidOrganicSearchTermView(long customerId, long campaignId,
            long adGroupId, string searchterm)
        {
            return $"customers/{customerId}/paidOrganicSearchTermViews/{campaignId}~" +
                $"{adGroupId}_{Base64Encode(searchterm)}";
        }

        public static string ParentalStatusView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/parentalStatusViews/{adGroupId}~{criterionId}";
        }

        public static string PaymentsAccount(long customerId, string paymentsAccountId)
        {
            return $"customers/{customerId}/paymentsAccounts/{paymentsAccountId}";
        }

        public static string ProductBiddingCategoryConstant(string country_code,
            ProductBiddingCategoryLevel level, long id)
        {
            return $"productBiddingCategoryConstants/{country_code}~" +
                $"{ProtobufUtilities.GetOriginalEnumFieldName(level)}~{id}";
        }

        public static string ProductGroupView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/productGroupViews/{adGroupId}~{criterionId}";
        }

        public static string Recommendation(long customerId, long recommendationId)
        {
            return $"customers/{customerId}/recommendations/{recommendationId}";
        }

        public static string RemarketingAction(long customerId, long remarketingActionId)
        {
            return $"customers/{customerId}/remarketingActions/{remarketingActionId}";
        }

        public static string SearchTermView(long customerId, long campaignId, long adGroupId,
            string searchTerm)
        {
            return $"customers/{customerId}/searchTermViews/{campaignId}~" +
                $"{adGroupId}_{Base64Encode(searchTerm)}";
        }

        public static string SharedCriterion(long customerId, long sharedSetId, long criterionId)
        {
            return $"customers/{customerId}/sharedCriteria/{sharedSetId}~{criterionId}";
        }

        public static string SharedSet(long customerId, long sharedSetId)
        {
            return $"customers/{customerId}/sharedSets/{sharedSetId}";
        }

        public static string ShoppingPerformanceView(long customerId)
        {
            return $"customers/{customerId}/shoppingPerformanceView";
        }

        public static string SmartCampaignSearchTermView(long customerId, long campaignId,
            string query)
        {
            return $"customers/{customerId}/smartCampaignSearchTermViews/{campaignId}" +
                $"~{Base64Encode(query)}";
        }

        public static string SmartCampaignSetting(long customerId, long smartCampaignId)
        {
            return $"customers/{customerId}/smartCampaignSettings/{smartCampaignId}";
        }

        public static string ThirdPartyAppAnalyticsLinks(long customerId, long shareableLinkId)
        {
            return $"customers/{customerId}/thirdPartyAppAnalyticsLinks/{shareableLinkId}";
        }

        public static string TopicConstant(long topicId)
        {
            return $"topicConstants/{topicId}";
        }

        public static string TopicView(long customerId, long adGroupId, long criterionId)
        {
            return $"customers/{customerId}/topicViews/{adGroupId}~{criterionId}";
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

        private static string Base64Encode(string text)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(text));
        }
    }
}

#pragma warning restore 1591

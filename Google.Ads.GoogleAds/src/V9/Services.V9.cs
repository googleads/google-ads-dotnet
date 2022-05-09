// Copyright 2021, Google LLC
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

using Google.Ads.Gax.Lib;
using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V9.Services;
using Google.Api.Gax.Grpc;
using Grpc.Core;

namespace Google.Ads.GoogleAds
{
    /// <summary>
    ///  Class to act as a pseudo namespace provider for service creation.
    /// </summary>
    public partial class Services
    {
        /// <summary>
        /// Pseudo enum to list the services supported in V9.
        /// </summary>
        public class V9
        {

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AccessibleBiddingStrategyService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AccessibleBiddingStrategyServiceClient, AccessibleBiddingStrategyServiceSettings, GoogleAdsConfig> AccessibleBiddingStrategyService =
                new ServiceTemplate<AccessibleBiddingStrategyServiceClient, AccessibleBiddingStrategyServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AccountBudgetProposalService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AccountBudgetProposalServiceClient, AccountBudgetProposalServiceSettings, GoogleAdsConfig> AccountBudgetProposalService =
                new ServiceTemplate<AccountBudgetProposalServiceClient, AccountBudgetProposalServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AccountBudgetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AccountBudgetServiceClient, AccountBudgetServiceSettings, GoogleAdsConfig> AccountBudgetService =
                new ServiceTemplate<AccountBudgetServiceClient, AccountBudgetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AccountLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AccountLinkServiceClient, AccountLinkServiceSettings, GoogleAdsConfig> AccountLinkService =
                new ServiceTemplate<AccountLinkServiceClient, AccountLinkServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdGroupAdAssetViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAdAssetViewServiceClient, AdGroupAdAssetViewServiceSettings, GoogleAdsConfig> AdGroupAdAssetViewService =
                new ServiceTemplate<AdGroupAdAssetViewServiceClient, AdGroupAdAssetViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdGroupAdLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAdLabelServiceClient, AdGroupAdLabelServiceSettings, GoogleAdsConfig> AdGroupAdLabelService =
                new ServiceTemplate<AdGroupAdLabelServiceClient, AdGroupAdLabelServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdGroupAdService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAdServiceClient, AdGroupAdServiceSettings, GoogleAdsConfig> AdGroupAdService =
                new ServiceTemplate<AdGroupAdServiceClient, AdGroupAdServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdGroupAssetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAssetServiceClient, AdGroupAssetServiceSettings, GoogleAdsConfig> AdGroupAssetService =
                new ServiceTemplate<AdGroupAssetServiceClient, AdGroupAssetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdGroupAudienceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAudienceViewServiceClient, AdGroupAudienceViewServiceSettings, GoogleAdsConfig> AdGroupAudienceViewService =
                new ServiceTemplate<AdGroupAudienceViewServiceClient, AdGroupAudienceViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdGroupBidModifierService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupBidModifierServiceClient, AdGroupBidModifierServiceSettings, GoogleAdsConfig> AdGroupBidModifierService =
                new ServiceTemplate<AdGroupBidModifierServiceClient, AdGroupBidModifierServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdGroupCriterionCustomizerService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupCriterionCustomizerServiceClient, AdGroupCriterionCustomizerServiceSettings, GoogleAdsConfig> AdGroupCriterionCustomizerService =
                new ServiceTemplate<AdGroupCriterionCustomizerServiceClient, AdGroupCriterionCustomizerServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdGroupCriterionLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupCriterionLabelServiceClient, AdGroupCriterionLabelServiceSettings, GoogleAdsConfig> AdGroupCriterionLabelService =
                new ServiceTemplate<AdGroupCriterionLabelServiceClient, AdGroupCriterionLabelServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdGroupCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupCriterionServiceClient, AdGroupCriterionServiceSettings, GoogleAdsConfig> AdGroupCriterionService =
                new ServiceTemplate<AdGroupCriterionServiceClient, AdGroupCriterionServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdGroupCriterionSimulationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupCriterionSimulationServiceClient, AdGroupCriterionSimulationServiceSettings, GoogleAdsConfig> AdGroupCriterionSimulationService =
                new ServiceTemplate<AdGroupCriterionSimulationServiceClient, AdGroupCriterionSimulationServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdGroupCustomizerService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupCustomizerServiceClient, AdGroupCustomizerServiceSettings, GoogleAdsConfig> AdGroupCustomizerService =
                new ServiceTemplate<AdGroupCustomizerServiceClient, AdGroupCustomizerServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdGroupExtensionSettingService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupExtensionSettingServiceClient, AdGroupExtensionSettingServiceSettings, GoogleAdsConfig> AdGroupExtensionSettingService =
                new ServiceTemplate<AdGroupExtensionSettingServiceClient, AdGroupExtensionSettingServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdGroupFeedService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupFeedServiceClient, AdGroupFeedServiceSettings, GoogleAdsConfig> AdGroupFeedService =
                new ServiceTemplate<AdGroupFeedServiceClient, AdGroupFeedServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdGroupLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupLabelServiceClient, AdGroupLabelServiceSettings, GoogleAdsConfig> AdGroupLabelService =
                new ServiceTemplate<AdGroupLabelServiceClient, AdGroupLabelServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdGroupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupServiceClient, AdGroupServiceSettings, GoogleAdsConfig> AdGroupService =
                new ServiceTemplate<AdGroupServiceClient, AdGroupServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdGroupSimulationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupSimulationServiceClient, AdGroupSimulationServiceSettings, GoogleAdsConfig> AdGroupSimulationService =
                new ServiceTemplate<AdGroupSimulationServiceClient, AdGroupSimulationServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdParameterService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdParameterServiceClient, AdParameterServiceSettings, GoogleAdsConfig> AdParameterService =
                new ServiceTemplate<AdParameterServiceClient, AdParameterServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdScheduleViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdScheduleViewServiceClient, AdScheduleViewServiceSettings, GoogleAdsConfig> AdScheduleViewService =
                new ServiceTemplate<AdScheduleViewServiceClient, AdScheduleViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AdService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdServiceClient, AdServiceSettings, GoogleAdsConfig> AdService =
                new ServiceTemplate<AdServiceClient, AdServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AgeRangeViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AgeRangeViewServiceClient, AgeRangeViewServiceSettings, GoogleAdsConfig> AgeRangeViewService =
                new ServiceTemplate<AgeRangeViewServiceClient, AgeRangeViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AssetFieldTypeViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AssetFieldTypeViewServiceClient, AssetFieldTypeViewServiceSettings, GoogleAdsConfig> AssetFieldTypeViewService =
                new ServiceTemplate<AssetFieldTypeViewServiceClient, AssetFieldTypeViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AssetGroupAssetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AssetGroupAssetServiceClient, AssetGroupAssetServiceSettings, GoogleAdsConfig> AssetGroupAssetService =
                new ServiceTemplate<AssetGroupAssetServiceClient, AssetGroupAssetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AssetGroupListingGroupFilterService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AssetGroupListingGroupFilterServiceClient, AssetGroupListingGroupFilterServiceSettings, GoogleAdsConfig> AssetGroupListingGroupFilterService =
                new ServiceTemplate<AssetGroupListingGroupFilterServiceClient, AssetGroupListingGroupFilterServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AssetGroupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AssetGroupServiceClient, AssetGroupServiceSettings, GoogleAdsConfig> AssetGroupService =
                new ServiceTemplate<AssetGroupServiceClient, AssetGroupServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AssetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AssetServiceClient, AssetServiceSettings, GoogleAdsConfig> AssetService =
                new ServiceTemplate<AssetServiceClient, AssetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AssetSetAssetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AssetSetAssetServiceClient, AssetSetAssetServiceSettings, GoogleAdsConfig> AssetSetAssetService =
                new ServiceTemplate<AssetSetAssetServiceClient, AssetSetAssetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/AssetSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AssetSetServiceClient, AssetSetServiceSettings, GoogleAdsConfig> AssetSetService =
                new ServiceTemplate<AssetSetServiceClient, AssetSetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/BatchJobService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BatchJobServiceClient, BatchJobServiceSettings, GoogleAdsConfig> BatchJobService =
                new ServiceTemplate<BatchJobServiceClient, BatchJobServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/BiddingDataExclusionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BiddingDataExclusionServiceClient, BiddingDataExclusionServiceSettings, GoogleAdsConfig> BiddingDataExclusionService =
                new ServiceTemplate<BiddingDataExclusionServiceClient, BiddingDataExclusionServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/BiddingSeasonalityAdjustmentService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BiddingSeasonalityAdjustmentServiceClient, BiddingSeasonalityAdjustmentServiceSettings, GoogleAdsConfig> BiddingSeasonalityAdjustmentService =
                new ServiceTemplate<BiddingSeasonalityAdjustmentServiceClient, BiddingSeasonalityAdjustmentServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/BiddingStrategyService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BiddingStrategyServiceClient, BiddingStrategyServiceSettings, GoogleAdsConfig> BiddingStrategyService =
                new ServiceTemplate<BiddingStrategyServiceClient, BiddingStrategyServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/BiddingStrategySimulationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BiddingStrategySimulationServiceClient, BiddingStrategySimulationServiceSettings, GoogleAdsConfig> BiddingStrategySimulationService =
                new ServiceTemplate<BiddingStrategySimulationServiceClient, BiddingStrategySimulationServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/BillingSetupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BillingSetupServiceClient, BillingSetupServiceSettings, GoogleAdsConfig> BillingSetupService =
                new ServiceTemplate<BillingSetupServiceClient, BillingSetupServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CampaignAssetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignAssetServiceClient, CampaignAssetServiceSettings, GoogleAdsConfig> CampaignAssetService =
                new ServiceTemplate<CampaignAssetServiceClient, CampaignAssetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CampaignAssetSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignAssetSetServiceClient, CampaignAssetSetServiceSettings, GoogleAdsConfig> CampaignAssetSetService =
                new ServiceTemplate<CampaignAssetSetServiceClient, CampaignAssetSetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CampaignAudienceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignAudienceViewServiceClient, CampaignAudienceViewServiceSettings, GoogleAdsConfig> CampaignAudienceViewService =
                new ServiceTemplate<CampaignAudienceViewServiceClient, CampaignAudienceViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CampaignBidModifierService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignBidModifierServiceClient, CampaignBidModifierServiceSettings, GoogleAdsConfig> CampaignBidModifierService =
                new ServiceTemplate<CampaignBidModifierServiceClient, CampaignBidModifierServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CampaignBudgetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignBudgetServiceClient, CampaignBudgetServiceSettings, GoogleAdsConfig> CampaignBudgetService =
                new ServiceTemplate<CampaignBudgetServiceClient, CampaignBudgetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CampaignConversionGoalService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignConversionGoalServiceClient, CampaignConversionGoalServiceSettings, GoogleAdsConfig> CampaignConversionGoalService =
                new ServiceTemplate<CampaignConversionGoalServiceClient, CampaignConversionGoalServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CampaignCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignCriterionServiceClient, CampaignCriterionServiceSettings, GoogleAdsConfig> CampaignCriterionService =
                new ServiceTemplate<CampaignCriterionServiceClient, CampaignCriterionServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CampaignCriterionSimulationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignCriterionSimulationServiceClient, CampaignCriterionSimulationServiceSettings, GoogleAdsConfig> CampaignCriterionSimulationService =
                new ServiceTemplate<CampaignCriterionSimulationServiceClient, CampaignCriterionSimulationServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CampaignCustomizerService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignCustomizerServiceClient, CampaignCustomizerServiceSettings, GoogleAdsConfig> CampaignCustomizerService =
                new ServiceTemplate<CampaignCustomizerServiceClient, CampaignCustomizerServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CampaignDraftService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignDraftServiceClient, CampaignDraftServiceSettings, GoogleAdsConfig> CampaignDraftService =
                new ServiceTemplate<CampaignDraftServiceClient, CampaignDraftServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CampaignExperimentService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignExperimentServiceClient, CampaignExperimentServiceSettings, GoogleAdsConfig> CampaignExperimentService =
                new ServiceTemplate<CampaignExperimentServiceClient, CampaignExperimentServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CampaignExtensionSettingService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignExtensionSettingServiceClient, CampaignExtensionSettingServiceSettings, GoogleAdsConfig> CampaignExtensionSettingService =
                new ServiceTemplate<CampaignExtensionSettingServiceClient, CampaignExtensionSettingServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CampaignFeedService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignFeedServiceClient, CampaignFeedServiceSettings, GoogleAdsConfig> CampaignFeedService =
                new ServiceTemplate<CampaignFeedServiceClient, CampaignFeedServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CampaignLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignLabelServiceClient, CampaignLabelServiceSettings, GoogleAdsConfig> CampaignLabelService =
                new ServiceTemplate<CampaignLabelServiceClient, CampaignLabelServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CampaignService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignServiceClient, CampaignServiceSettings, GoogleAdsConfig> CampaignService =
                new ServiceTemplate<CampaignServiceClient, CampaignServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CampaignSharedSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignSharedSetServiceClient, CampaignSharedSetServiceSettings, GoogleAdsConfig> CampaignSharedSetService =
                new ServiceTemplate<CampaignSharedSetServiceClient, CampaignSharedSetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CampaignSimulationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignSimulationServiceClient, CampaignSimulationServiceSettings, GoogleAdsConfig> CampaignSimulationService =
                new ServiceTemplate<CampaignSimulationServiceClient, CampaignSimulationServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CarrierConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CarrierConstantServiceClient, CarrierConstantServiceSettings, GoogleAdsConfig> CarrierConstantService =
                new ServiceTemplate<CarrierConstantServiceClient, CarrierConstantServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ChangeStatusService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ChangeStatusServiceClient, ChangeStatusServiceSettings, GoogleAdsConfig> ChangeStatusService =
                new ServiceTemplate<ChangeStatusServiceClient, ChangeStatusServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ClickViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ClickViewServiceClient, ClickViewServiceSettings, GoogleAdsConfig> ClickViewService =
                new ServiceTemplate<ClickViewServiceClient, ClickViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CombinedAudienceService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CombinedAudienceServiceClient, CombinedAudienceServiceSettings, GoogleAdsConfig> CombinedAudienceService =
                new ServiceTemplate<CombinedAudienceServiceClient, CombinedAudienceServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ConversionActionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionActionServiceClient, ConversionActionServiceSettings, GoogleAdsConfig> ConversionActionService =
                new ServiceTemplate<ConversionActionServiceClient, ConversionActionServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ConversionAdjustmentUploadService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionAdjustmentUploadServiceClient, ConversionAdjustmentUploadServiceSettings, GoogleAdsConfig> ConversionAdjustmentUploadService =
                new ServiceTemplate<ConversionAdjustmentUploadServiceClient, ConversionAdjustmentUploadServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ConversionCustomVariableService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionCustomVariableServiceClient, ConversionCustomVariableServiceSettings, GoogleAdsConfig> ConversionCustomVariableService =
                new ServiceTemplate<ConversionCustomVariableServiceClient, ConversionCustomVariableServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ConversionGoalCampaignConfigService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionGoalCampaignConfigServiceClient, ConversionGoalCampaignConfigServiceSettings, GoogleAdsConfig> ConversionGoalCampaignConfigService =
                new ServiceTemplate<ConversionGoalCampaignConfigServiceClient, ConversionGoalCampaignConfigServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ConversionUploadService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionUploadServiceClient, ConversionUploadServiceSettings, GoogleAdsConfig> ConversionUploadService =
                new ServiceTemplate<ConversionUploadServiceClient, ConversionUploadServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ConversionValueRuleService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionValueRuleServiceClient, ConversionValueRuleServiceSettings, GoogleAdsConfig> ConversionValueRuleService =
                new ServiceTemplate<ConversionValueRuleServiceClient, ConversionValueRuleServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ConversionValueRuleSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionValueRuleSetServiceClient, ConversionValueRuleSetServiceSettings, GoogleAdsConfig> ConversionValueRuleSetService =
                new ServiceTemplate<ConversionValueRuleSetServiceClient, ConversionValueRuleSetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CurrencyConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CurrencyConstantServiceClient, CurrencyConstantServiceSettings, GoogleAdsConfig> CurrencyConstantService =
                new ServiceTemplate<CurrencyConstantServiceClient, CurrencyConstantServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CustomAudienceService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomAudienceServiceClient, CustomAudienceServiceSettings, GoogleAdsConfig> CustomAudienceService =
                new ServiceTemplate<CustomAudienceServiceClient, CustomAudienceServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CustomConversionGoalService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomConversionGoalServiceClient, CustomConversionGoalServiceSettings, GoogleAdsConfig> CustomConversionGoalService =
                new ServiceTemplate<CustomConversionGoalServiceClient, CustomConversionGoalServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CustomInterestService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomInterestServiceClient, CustomInterestServiceSettings, GoogleAdsConfig> CustomInterestService =
                new ServiceTemplate<CustomInterestServiceClient, CustomInterestServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CustomerAssetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerAssetServiceClient, CustomerAssetServiceSettings, GoogleAdsConfig> CustomerAssetService =
                new ServiceTemplate<CustomerAssetServiceClient, CustomerAssetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CustomerClientLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerClientLinkServiceClient, CustomerClientLinkServiceSettings, GoogleAdsConfig> CustomerClientLinkService =
                new ServiceTemplate<CustomerClientLinkServiceClient, CustomerClientLinkServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CustomerClientService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerClientServiceClient, CustomerClientServiceSettings, GoogleAdsConfig> CustomerClientService =
                new ServiceTemplate<CustomerClientServiceClient, CustomerClientServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CustomerConversionGoalService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerConversionGoalServiceClient, CustomerConversionGoalServiceSettings, GoogleAdsConfig> CustomerConversionGoalService =
                new ServiceTemplate<CustomerConversionGoalServiceClient, CustomerConversionGoalServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CustomerCustomizerService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerCustomizerServiceClient, CustomerCustomizerServiceSettings, GoogleAdsConfig> CustomerCustomizerService =
                new ServiceTemplate<CustomerCustomizerServiceClient, CustomerCustomizerServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CustomerExtensionSettingService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerExtensionSettingServiceClient, CustomerExtensionSettingServiceSettings, GoogleAdsConfig> CustomerExtensionSettingService =
                new ServiceTemplate<CustomerExtensionSettingServiceClient, CustomerExtensionSettingServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CustomerFeedService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerFeedServiceClient, CustomerFeedServiceSettings, GoogleAdsConfig> CustomerFeedService =
                new ServiceTemplate<CustomerFeedServiceClient, CustomerFeedServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CustomerLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerLabelServiceClient, CustomerLabelServiceSettings, GoogleAdsConfig> CustomerLabelService =
                new ServiceTemplate<CustomerLabelServiceClient, CustomerLabelServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CustomerManagerLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerManagerLinkServiceClient, CustomerManagerLinkServiceSettings, GoogleAdsConfig> CustomerManagerLinkService =
                new ServiceTemplate<CustomerManagerLinkServiceClient, CustomerManagerLinkServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CustomerNegativeCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerNegativeCriterionServiceClient, CustomerNegativeCriterionServiceSettings, GoogleAdsConfig> CustomerNegativeCriterionService =
                new ServiceTemplate<CustomerNegativeCriterionServiceClient, CustomerNegativeCriterionServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CustomerService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerServiceClient, CustomerServiceSettings, GoogleAdsConfig> CustomerService =
                new ServiceTemplate<CustomerServiceClient, CustomerServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CustomerUserAccessInvitationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerUserAccessInvitationServiceClient, CustomerUserAccessInvitationServiceSettings, GoogleAdsConfig> CustomerUserAccessInvitationService =
                new ServiceTemplate<CustomerUserAccessInvitationServiceClient, CustomerUserAccessInvitationServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CustomerUserAccessService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerUserAccessServiceClient, CustomerUserAccessServiceSettings, GoogleAdsConfig> CustomerUserAccessService =
                new ServiceTemplate<CustomerUserAccessServiceClient, CustomerUserAccessServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/CustomizerAttributeService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomizerAttributeServiceClient, CustomizerAttributeServiceSettings, GoogleAdsConfig> CustomizerAttributeService =
                new ServiceTemplate<CustomizerAttributeServiceClient, CustomizerAttributeServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/DetailPlacementViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DetailPlacementViewServiceClient, DetailPlacementViewServiceSettings, GoogleAdsConfig> DetailPlacementViewService =
                new ServiceTemplate<DetailPlacementViewServiceClient, DetailPlacementViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/DetailedDemographicService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DetailedDemographicServiceClient, DetailedDemographicServiceSettings, GoogleAdsConfig> DetailedDemographicService =
                new ServiceTemplate<DetailedDemographicServiceClient, DetailedDemographicServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/DisplayKeywordViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DisplayKeywordViewServiceClient, DisplayKeywordViewServiceSettings, GoogleAdsConfig> DisplayKeywordViewService =
                new ServiceTemplate<DisplayKeywordViewServiceClient, DisplayKeywordViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/DistanceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DistanceViewServiceClient, DistanceViewServiceSettings, GoogleAdsConfig> DistanceViewService =
                new ServiceTemplate<DistanceViewServiceClient, DistanceViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/DomainCategoryService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DomainCategoryServiceClient, DomainCategoryServiceSettings, GoogleAdsConfig> DomainCategoryService =
                new ServiceTemplate<DomainCategoryServiceClient, DomainCategoryServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/DynamicSearchAdsSearchTermViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DynamicSearchAdsSearchTermViewServiceClient, DynamicSearchAdsSearchTermViewServiceSettings, GoogleAdsConfig> DynamicSearchAdsSearchTermViewService =
                new ServiceTemplate<DynamicSearchAdsSearchTermViewServiceClient, DynamicSearchAdsSearchTermViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ExpandedLandingPageViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ExpandedLandingPageViewServiceClient, ExpandedLandingPageViewServiceSettings, GoogleAdsConfig> ExpandedLandingPageViewService =
                new ServiceTemplate<ExpandedLandingPageViewServiceClient, ExpandedLandingPageViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ExtensionFeedItemService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ExtensionFeedItemServiceClient, ExtensionFeedItemServiceSettings, GoogleAdsConfig> ExtensionFeedItemService =
                new ServiceTemplate<ExtensionFeedItemServiceClient, ExtensionFeedItemServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/FeedItemService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedItemServiceClient, FeedItemServiceSettings, GoogleAdsConfig> FeedItemService =
                new ServiceTemplate<FeedItemServiceClient, FeedItemServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/FeedItemSetLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedItemSetLinkServiceClient, FeedItemSetLinkServiceSettings, GoogleAdsConfig> FeedItemSetLinkService =
                new ServiceTemplate<FeedItemSetLinkServiceClient, FeedItemSetLinkServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/FeedItemSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedItemSetServiceClient, FeedItemSetServiceSettings, GoogleAdsConfig> FeedItemSetService =
                new ServiceTemplate<FeedItemSetServiceClient, FeedItemSetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/FeedItemTargetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedItemTargetServiceClient, FeedItemTargetServiceSettings, GoogleAdsConfig> FeedItemTargetService =
                new ServiceTemplate<FeedItemTargetServiceClient, FeedItemTargetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/FeedMappingService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedMappingServiceClient, FeedMappingServiceSettings, GoogleAdsConfig> FeedMappingService =
                new ServiceTemplate<FeedMappingServiceClient, FeedMappingServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/FeedPlaceholderViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedPlaceholderViewServiceClient, FeedPlaceholderViewServiceSettings, GoogleAdsConfig> FeedPlaceholderViewService =
                new ServiceTemplate<FeedPlaceholderViewServiceClient, FeedPlaceholderViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/FeedService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedServiceClient, FeedServiceSettings, GoogleAdsConfig> FeedService =
                new ServiceTemplate<FeedServiceClient, FeedServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/GenderViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GenderViewServiceClient, GenderViewServiceSettings, GoogleAdsConfig> GenderViewService =
                new ServiceTemplate<GenderViewServiceClient, GenderViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/GeoTargetConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GeoTargetConstantServiceClient, GeoTargetConstantServiceSettings, GoogleAdsConfig> GeoTargetConstantService =
                new ServiceTemplate<GeoTargetConstantServiceClient, GeoTargetConstantServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/GeographicViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GeographicViewServiceClient, GeographicViewServiceSettings, GoogleAdsConfig> GeographicViewService =
                new ServiceTemplate<GeographicViewServiceClient, GeographicViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/GoogleAdsFieldService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GoogleAdsFieldServiceClient, GoogleAdsFieldServiceSettings, GoogleAdsConfig> GoogleAdsFieldService =
                new ServiceTemplate<GoogleAdsFieldServiceClient, GoogleAdsFieldServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/GoogleAdsService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GoogleAdsServiceClient, GoogleAdsServiceSettings, GoogleAdsConfig> GoogleAdsService =
                new ServiceTemplate<GoogleAdsServiceClient, GoogleAdsServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/GroupPlacementViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GroupPlacementViewServiceClient, GroupPlacementViewServiceSettings, GoogleAdsConfig> GroupPlacementViewService =
                new ServiceTemplate<GroupPlacementViewServiceClient, GroupPlacementViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/HotelGroupViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<HotelGroupViewServiceClient, HotelGroupViewServiceSettings, GoogleAdsConfig> HotelGroupViewService =
                new ServiceTemplate<HotelGroupViewServiceClient, HotelGroupViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/HotelPerformanceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<HotelPerformanceViewServiceClient, HotelPerformanceViewServiceSettings, GoogleAdsConfig> HotelPerformanceViewService =
                new ServiceTemplate<HotelPerformanceViewServiceClient, HotelPerformanceViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/IncomeRangeViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<IncomeRangeViewServiceClient, IncomeRangeViewServiceSettings, GoogleAdsConfig> IncomeRangeViewService =
                new ServiceTemplate<IncomeRangeViewServiceClient, IncomeRangeViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/InvoiceService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<InvoiceServiceClient, InvoiceServiceSettings, GoogleAdsConfig> InvoiceService =
                new ServiceTemplate<InvoiceServiceClient, InvoiceServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/KeywordPlanAdGroupKeywordService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanAdGroupKeywordServiceClient, KeywordPlanAdGroupKeywordServiceSettings, GoogleAdsConfig> KeywordPlanAdGroupKeywordService =
                new ServiceTemplate<KeywordPlanAdGroupKeywordServiceClient, KeywordPlanAdGroupKeywordServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/KeywordPlanAdGroupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanAdGroupServiceClient, KeywordPlanAdGroupServiceSettings, GoogleAdsConfig> KeywordPlanAdGroupService =
                new ServiceTemplate<KeywordPlanAdGroupServiceClient, KeywordPlanAdGroupServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/KeywordPlanCampaignKeywordService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanCampaignKeywordServiceClient, KeywordPlanCampaignKeywordServiceSettings, GoogleAdsConfig> KeywordPlanCampaignKeywordService =
                new ServiceTemplate<KeywordPlanCampaignKeywordServiceClient, KeywordPlanCampaignKeywordServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/KeywordPlanCampaignService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanCampaignServiceClient, KeywordPlanCampaignServiceSettings, GoogleAdsConfig> KeywordPlanCampaignService =
                new ServiceTemplate<KeywordPlanCampaignServiceClient, KeywordPlanCampaignServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/KeywordPlanIdeaService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanIdeaServiceClient, KeywordPlanIdeaServiceSettings, GoogleAdsConfig> KeywordPlanIdeaService =
                new ServiceTemplate<KeywordPlanIdeaServiceClient, KeywordPlanIdeaServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/KeywordPlanService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanServiceClient, KeywordPlanServiceSettings, GoogleAdsConfig> KeywordPlanService =
                new ServiceTemplate<KeywordPlanServiceClient, KeywordPlanServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/KeywordThemeConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordThemeConstantServiceClient, KeywordThemeConstantServiceSettings, GoogleAdsConfig> KeywordThemeConstantService =
                new ServiceTemplate<KeywordThemeConstantServiceClient, KeywordThemeConstantServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/KeywordViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordViewServiceClient, KeywordViewServiceSettings, GoogleAdsConfig> KeywordViewService =
                new ServiceTemplate<KeywordViewServiceClient, KeywordViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/LabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<LabelServiceClient, LabelServiceSettings, GoogleAdsConfig> LabelService =
                new ServiceTemplate<LabelServiceClient, LabelServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/LandingPageViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<LandingPageViewServiceClient, LandingPageViewServiceSettings, GoogleAdsConfig> LandingPageViewService =
                new ServiceTemplate<LandingPageViewServiceClient, LandingPageViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/LanguageConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<LanguageConstantServiceClient, LanguageConstantServiceSettings, GoogleAdsConfig> LanguageConstantService =
                new ServiceTemplate<LanguageConstantServiceClient, LanguageConstantServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/LifeEventService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<LifeEventServiceClient, LifeEventServiceSettings, GoogleAdsConfig> LifeEventService =
                new ServiceTemplate<LifeEventServiceClient, LifeEventServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/LocationViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<LocationViewServiceClient, LocationViewServiceSettings, GoogleAdsConfig> LocationViewService =
                new ServiceTemplate<LocationViewServiceClient, LocationViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ManagedPlacementViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ManagedPlacementViewServiceClient, ManagedPlacementViewServiceSettings, GoogleAdsConfig> ManagedPlacementViewService =
                new ServiceTemplate<ManagedPlacementViewServiceClient, ManagedPlacementViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/MediaFileService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<MediaFileServiceClient, MediaFileServiceSettings, GoogleAdsConfig> MediaFileService =
                new ServiceTemplate<MediaFileServiceClient, MediaFileServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/MerchantCenterLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<MerchantCenterLinkServiceClient, MerchantCenterLinkServiceSettings, GoogleAdsConfig> MerchantCenterLinkService =
                new ServiceTemplate<MerchantCenterLinkServiceClient, MerchantCenterLinkServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/MobileAppCategoryConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<MobileAppCategoryConstantServiceClient, MobileAppCategoryConstantServiceSettings, GoogleAdsConfig> MobileAppCategoryConstantService =
                new ServiceTemplate<MobileAppCategoryConstantServiceClient, MobileAppCategoryConstantServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/MobileDeviceConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<MobileDeviceConstantServiceClient, MobileDeviceConstantServiceSettings, GoogleAdsConfig> MobileDeviceConstantService =
                new ServiceTemplate<MobileDeviceConstantServiceClient, MobileDeviceConstantServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/OfflineUserDataJobService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<OfflineUserDataJobServiceClient, OfflineUserDataJobServiceSettings, GoogleAdsConfig> OfflineUserDataJobService =
                new ServiceTemplate<OfflineUserDataJobServiceClient, OfflineUserDataJobServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/OperatingSystemVersionConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<OperatingSystemVersionConstantServiceClient, OperatingSystemVersionConstantServiceSettings, GoogleAdsConfig> OperatingSystemVersionConstantService =
                new ServiceTemplate<OperatingSystemVersionConstantServiceClient, OperatingSystemVersionConstantServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/PaidOrganicSearchTermViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<PaidOrganicSearchTermViewServiceClient, PaidOrganicSearchTermViewServiceSettings, GoogleAdsConfig> PaidOrganicSearchTermViewService =
                new ServiceTemplate<PaidOrganicSearchTermViewServiceClient, PaidOrganicSearchTermViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ParentalStatusViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ParentalStatusViewServiceClient, ParentalStatusViewServiceSettings, GoogleAdsConfig> ParentalStatusViewService =
                new ServiceTemplate<ParentalStatusViewServiceClient, ParentalStatusViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/PaymentsAccountService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<PaymentsAccountServiceClient, PaymentsAccountServiceSettings, GoogleAdsConfig> PaymentsAccountService =
                new ServiceTemplate<PaymentsAccountServiceClient, PaymentsAccountServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ProductBiddingCategoryConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ProductBiddingCategoryConstantServiceClient, ProductBiddingCategoryConstantServiceSettings, GoogleAdsConfig> ProductBiddingCategoryConstantService =
                new ServiceTemplate<ProductBiddingCategoryConstantServiceClient, ProductBiddingCategoryConstantServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ProductGroupViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ProductGroupViewServiceClient, ProductGroupViewServiceSettings, GoogleAdsConfig> ProductGroupViewService =
                new ServiceTemplate<ProductGroupViewServiceClient, ProductGroupViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ReachPlanService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ReachPlanServiceClient, ReachPlanServiceSettings, GoogleAdsConfig> ReachPlanService =
                new ServiceTemplate<ReachPlanServiceClient, ReachPlanServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/RecommendationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<RecommendationServiceClient, RecommendationServiceSettings, GoogleAdsConfig> RecommendationService =
                new ServiceTemplate<RecommendationServiceClient, RecommendationServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/RemarketingActionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<RemarketingActionServiceClient, RemarketingActionServiceSettings, GoogleAdsConfig> RemarketingActionService =
                new ServiceTemplate<RemarketingActionServiceClient, RemarketingActionServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/SearchTermViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SearchTermViewServiceClient, SearchTermViewServiceSettings, GoogleAdsConfig> SearchTermViewService =
                new ServiceTemplate<SearchTermViewServiceClient, SearchTermViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/SharedCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SharedCriterionServiceClient, SharedCriterionServiceSettings, GoogleAdsConfig> SharedCriterionService =
                new ServiceTemplate<SharedCriterionServiceClient, SharedCriterionServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/SharedSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SharedSetServiceClient, SharedSetServiceSettings, GoogleAdsConfig> SharedSetService =
                new ServiceTemplate<SharedSetServiceClient, SharedSetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ShoppingPerformanceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ShoppingPerformanceViewServiceClient, ShoppingPerformanceViewServiceSettings, GoogleAdsConfig> ShoppingPerformanceViewService =
                new ServiceTemplate<ShoppingPerformanceViewServiceClient, ShoppingPerformanceViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/SmartCampaignSearchTermViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SmartCampaignSearchTermViewServiceClient, SmartCampaignSearchTermViewServiceSettings, GoogleAdsConfig> SmartCampaignSearchTermViewService =
                new ServiceTemplate<SmartCampaignSearchTermViewServiceClient, SmartCampaignSearchTermViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/SmartCampaignSettingService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SmartCampaignSettingServiceClient, SmartCampaignSettingServiceSettings, GoogleAdsConfig> SmartCampaignSettingService =
                new ServiceTemplate<SmartCampaignSettingServiceClient, SmartCampaignSettingServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/SmartCampaignSuggestService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SmartCampaignSuggestServiceClient, SmartCampaignSuggestServiceSettings, GoogleAdsConfig> SmartCampaignSuggestService =
                new ServiceTemplate<SmartCampaignSuggestServiceClient, SmartCampaignSuggestServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/ThirdPartyAppAnalyticsLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ThirdPartyAppAnalyticsLinkServiceClient, ThirdPartyAppAnalyticsLinkServiceSettings, GoogleAdsConfig> ThirdPartyAppAnalyticsLinkService =
                new ServiceTemplate<ThirdPartyAppAnalyticsLinkServiceClient, ThirdPartyAppAnalyticsLinkServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/TopicConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<TopicConstantServiceClient, TopicConstantServiceSettings, GoogleAdsConfig> TopicConstantService =
                new ServiceTemplate<TopicConstantServiceClient, TopicConstantServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/TopicViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<TopicViewServiceClient, TopicViewServiceSettings, GoogleAdsConfig> TopicViewService =
                new ServiceTemplate<TopicViewServiceClient, TopicViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/UserDataService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<UserDataServiceClient, UserDataServiceSettings, GoogleAdsConfig> UserDataService =
                new ServiceTemplate<UserDataServiceClient, UserDataServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/UserInterestService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<UserInterestServiceClient, UserInterestServiceSettings, GoogleAdsConfig> UserInterestService =
                new ServiceTemplate<UserInterestServiceClient, UserInterestServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/UserListService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<UserListServiceClient, UserListServiceSettings, GoogleAdsConfig> UserListService =
                new ServiceTemplate<UserListServiceClient, UserListServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/UserLocationViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<UserLocationViewServiceClient, UserLocationViewServiceSettings, GoogleAdsConfig> UserLocationViewService =
                new ServiceTemplate<UserLocationViewServiceClient, UserLocationViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/VideoService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<VideoServiceClient, VideoServiceSettings, GoogleAdsConfig> VideoService =
                new ServiceTemplate<VideoServiceClient, VideoServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v9/WebpageViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<WebpageViewServiceClient, WebpageViewServiceSettings, GoogleAdsConfig> WebpageViewService =
                new ServiceTemplate<WebpageViewServiceClient, WebpageViewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// Creates the specified service.
            /// </summary>
            /// <param name="serviceName">Name of the service.</param>
            /// <param name="callInvoker">The call invoker.</param>
            /// <param name="settings">The service settings.</param>
            /// <returns>An instance of the service.</returns>
            public static GoogleAdsServiceClientBase Create(string serviceName, CallInvoker callInvoker, ServiceSettingsBase settings)
            {
                switch (serviceName)
                {

                    case "AccessibleBiddingStrategyServiceClient":
                        return AccessibleBiddingStrategyServiceClient.Create(callInvoker, (AccessibleBiddingStrategyServiceSettings) settings);


                    case "AccountBudgetProposalServiceClient":
                        return AccountBudgetProposalServiceClient.Create(callInvoker, (AccountBudgetProposalServiceSettings) settings);


                    case "AccountBudgetServiceClient":
                        return AccountBudgetServiceClient.Create(callInvoker, (AccountBudgetServiceSettings) settings);


                    case "AccountLinkServiceClient":
                        return AccountLinkServiceClient.Create(callInvoker, (AccountLinkServiceSettings) settings);


                    case "AdGroupAdAssetViewServiceClient":
                        return AdGroupAdAssetViewServiceClient.Create(callInvoker, (AdGroupAdAssetViewServiceSettings) settings);


                    case "AdGroupAdLabelServiceClient":
                        return AdGroupAdLabelServiceClient.Create(callInvoker, (AdGroupAdLabelServiceSettings) settings);


                    case "AdGroupAdServiceClient":
                        return AdGroupAdServiceClient.Create(callInvoker, (AdGroupAdServiceSettings) settings);


                    case "AdGroupAssetServiceClient":
                        return AdGroupAssetServiceClient.Create(callInvoker, (AdGroupAssetServiceSettings) settings);


                    case "AdGroupAudienceViewServiceClient":
                        return AdGroupAudienceViewServiceClient.Create(callInvoker, (AdGroupAudienceViewServiceSettings) settings);


                    case "AdGroupBidModifierServiceClient":
                        return AdGroupBidModifierServiceClient.Create(callInvoker, (AdGroupBidModifierServiceSettings) settings);


                    case "AdGroupCriterionCustomizerServiceClient":
                        return AdGroupCriterionCustomizerServiceClient.Create(callInvoker, (AdGroupCriterionCustomizerServiceSettings) settings);


                    case "AdGroupCriterionLabelServiceClient":
                        return AdGroupCriterionLabelServiceClient.Create(callInvoker, (AdGroupCriterionLabelServiceSettings) settings);


                    case "AdGroupCriterionServiceClient":
                        return AdGroupCriterionServiceClient.Create(callInvoker, (AdGroupCriterionServiceSettings) settings);


                    case "AdGroupCriterionSimulationServiceClient":
                        return AdGroupCriterionSimulationServiceClient.Create(callInvoker, (AdGroupCriterionSimulationServiceSettings) settings);


                    case "AdGroupCustomizerServiceClient":
                        return AdGroupCustomizerServiceClient.Create(callInvoker, (AdGroupCustomizerServiceSettings) settings);


                    case "AdGroupExtensionSettingServiceClient":
                        return AdGroupExtensionSettingServiceClient.Create(callInvoker, (AdGroupExtensionSettingServiceSettings) settings);


                    case "AdGroupFeedServiceClient":
                        return AdGroupFeedServiceClient.Create(callInvoker, (AdGroupFeedServiceSettings) settings);


                    case "AdGroupLabelServiceClient":
                        return AdGroupLabelServiceClient.Create(callInvoker, (AdGroupLabelServiceSettings) settings);


                    case "AdGroupServiceClient":
                        return AdGroupServiceClient.Create(callInvoker, (AdGroupServiceSettings) settings);


                    case "AdGroupSimulationServiceClient":
                        return AdGroupSimulationServiceClient.Create(callInvoker, (AdGroupSimulationServiceSettings) settings);


                    case "AdParameterServiceClient":
                        return AdParameterServiceClient.Create(callInvoker, (AdParameterServiceSettings) settings);


                    case "AdScheduleViewServiceClient":
                        return AdScheduleViewServiceClient.Create(callInvoker, (AdScheduleViewServiceSettings) settings);


                    case "AdServiceClient":
                        return AdServiceClient.Create(callInvoker, (AdServiceSettings) settings);


                    case "AgeRangeViewServiceClient":
                        return AgeRangeViewServiceClient.Create(callInvoker, (AgeRangeViewServiceSettings) settings);


                    case "AssetFieldTypeViewServiceClient":
                        return AssetFieldTypeViewServiceClient.Create(callInvoker, (AssetFieldTypeViewServiceSettings) settings);


                    case "AssetGroupAssetServiceClient":
                        return AssetGroupAssetServiceClient.Create(callInvoker, (AssetGroupAssetServiceSettings) settings);


                    case "AssetGroupListingGroupFilterServiceClient":
                        return AssetGroupListingGroupFilterServiceClient.Create(callInvoker, (AssetGroupListingGroupFilterServiceSettings) settings);


                    case "AssetGroupServiceClient":
                        return AssetGroupServiceClient.Create(callInvoker, (AssetGroupServiceSettings) settings);


                    case "AssetServiceClient":
                        return AssetServiceClient.Create(callInvoker, (AssetServiceSettings) settings);


                    case "AssetSetAssetServiceClient":
                        return AssetSetAssetServiceClient.Create(callInvoker, (AssetSetAssetServiceSettings) settings);


                    case "AssetSetServiceClient":
                        return AssetSetServiceClient.Create(callInvoker, (AssetSetServiceSettings) settings);


                    case "BatchJobServiceClient":
                        return BatchJobServiceClient.Create(callInvoker, (BatchJobServiceSettings) settings);


                    case "BiddingDataExclusionServiceClient":
                        return BiddingDataExclusionServiceClient.Create(callInvoker, (BiddingDataExclusionServiceSettings) settings);


                    case "BiddingSeasonalityAdjustmentServiceClient":
                        return BiddingSeasonalityAdjustmentServiceClient.Create(callInvoker, (BiddingSeasonalityAdjustmentServiceSettings) settings);


                    case "BiddingStrategyServiceClient":
                        return BiddingStrategyServiceClient.Create(callInvoker, (BiddingStrategyServiceSettings) settings);


                    case "BiddingStrategySimulationServiceClient":
                        return BiddingStrategySimulationServiceClient.Create(callInvoker, (BiddingStrategySimulationServiceSettings) settings);


                    case "BillingSetupServiceClient":
                        return BillingSetupServiceClient.Create(callInvoker, (BillingSetupServiceSettings) settings);


                    case "CampaignAssetServiceClient":
                        return CampaignAssetServiceClient.Create(callInvoker, (CampaignAssetServiceSettings) settings);


                    case "CampaignAssetSetServiceClient":
                        return CampaignAssetSetServiceClient.Create(callInvoker, (CampaignAssetSetServiceSettings) settings);


                    case "CampaignAudienceViewServiceClient":
                        return CampaignAudienceViewServiceClient.Create(callInvoker, (CampaignAudienceViewServiceSettings) settings);


                    case "CampaignBidModifierServiceClient":
                        return CampaignBidModifierServiceClient.Create(callInvoker, (CampaignBidModifierServiceSettings) settings);


                    case "CampaignBudgetServiceClient":
                        return CampaignBudgetServiceClient.Create(callInvoker, (CampaignBudgetServiceSettings) settings);


                    case "CampaignConversionGoalServiceClient":
                        return CampaignConversionGoalServiceClient.Create(callInvoker, (CampaignConversionGoalServiceSettings) settings);


                    case "CampaignCriterionServiceClient":
                        return CampaignCriterionServiceClient.Create(callInvoker, (CampaignCriterionServiceSettings) settings);


                    case "CampaignCriterionSimulationServiceClient":
                        return CampaignCriterionSimulationServiceClient.Create(callInvoker, (CampaignCriterionSimulationServiceSettings) settings);


                    case "CampaignCustomizerServiceClient":
                        return CampaignCustomizerServiceClient.Create(callInvoker, (CampaignCustomizerServiceSettings) settings);


                    case "CampaignDraftServiceClient":
                        return CampaignDraftServiceClient.Create(callInvoker, (CampaignDraftServiceSettings) settings);


                    case "CampaignExperimentServiceClient":
                        return CampaignExperimentServiceClient.Create(callInvoker, (CampaignExperimentServiceSettings) settings);


                    case "CampaignExtensionSettingServiceClient":
                        return CampaignExtensionSettingServiceClient.Create(callInvoker, (CampaignExtensionSettingServiceSettings) settings);


                    case "CampaignFeedServiceClient":
                        return CampaignFeedServiceClient.Create(callInvoker, (CampaignFeedServiceSettings) settings);


                    case "CampaignLabelServiceClient":
                        return CampaignLabelServiceClient.Create(callInvoker, (CampaignLabelServiceSettings) settings);


                    case "CampaignServiceClient":
                        return CampaignServiceClient.Create(callInvoker, (CampaignServiceSettings) settings);


                    case "CampaignSharedSetServiceClient":
                        return CampaignSharedSetServiceClient.Create(callInvoker, (CampaignSharedSetServiceSettings) settings);


                    case "CampaignSimulationServiceClient":
                        return CampaignSimulationServiceClient.Create(callInvoker, (CampaignSimulationServiceSettings) settings);


                    case "CarrierConstantServiceClient":
                        return CarrierConstantServiceClient.Create(callInvoker, (CarrierConstantServiceSettings) settings);


                    case "ChangeStatusServiceClient":
                        return ChangeStatusServiceClient.Create(callInvoker, (ChangeStatusServiceSettings) settings);


                    case "ClickViewServiceClient":
                        return ClickViewServiceClient.Create(callInvoker, (ClickViewServiceSettings) settings);


                    case "CombinedAudienceServiceClient":
                        return CombinedAudienceServiceClient.Create(callInvoker, (CombinedAudienceServiceSettings) settings);


                    case "ConversionActionServiceClient":
                        return ConversionActionServiceClient.Create(callInvoker, (ConversionActionServiceSettings) settings);


                    case "ConversionAdjustmentUploadServiceClient":
                        return ConversionAdjustmentUploadServiceClient.Create(callInvoker, (ConversionAdjustmentUploadServiceSettings) settings);


                    case "ConversionCustomVariableServiceClient":
                        return ConversionCustomVariableServiceClient.Create(callInvoker, (ConversionCustomVariableServiceSettings) settings);


                    case "ConversionGoalCampaignConfigServiceClient":
                        return ConversionGoalCampaignConfigServiceClient.Create(callInvoker, (ConversionGoalCampaignConfigServiceSettings) settings);


                    case "ConversionUploadServiceClient":
                        return ConversionUploadServiceClient.Create(callInvoker, (ConversionUploadServiceSettings) settings);


                    case "ConversionValueRuleServiceClient":
                        return ConversionValueRuleServiceClient.Create(callInvoker, (ConversionValueRuleServiceSettings) settings);


                    case "ConversionValueRuleSetServiceClient":
                        return ConversionValueRuleSetServiceClient.Create(callInvoker, (ConversionValueRuleSetServiceSettings) settings);


                    case "CurrencyConstantServiceClient":
                        return CurrencyConstantServiceClient.Create(callInvoker, (CurrencyConstantServiceSettings) settings);


                    case "CustomAudienceServiceClient":
                        return CustomAudienceServiceClient.Create(callInvoker, (CustomAudienceServiceSettings) settings);


                    case "CustomConversionGoalServiceClient":
                        return CustomConversionGoalServiceClient.Create(callInvoker, (CustomConversionGoalServiceSettings) settings);


                    case "CustomInterestServiceClient":
                        return CustomInterestServiceClient.Create(callInvoker, (CustomInterestServiceSettings) settings);


                    case "CustomerAssetServiceClient":
                        return CustomerAssetServiceClient.Create(callInvoker, (CustomerAssetServiceSettings) settings);


                    case "CustomerClientLinkServiceClient":
                        return CustomerClientLinkServiceClient.Create(callInvoker, (CustomerClientLinkServiceSettings) settings);


                    case "CustomerClientServiceClient":
                        return CustomerClientServiceClient.Create(callInvoker, (CustomerClientServiceSettings) settings);


                    case "CustomerConversionGoalServiceClient":
                        return CustomerConversionGoalServiceClient.Create(callInvoker, (CustomerConversionGoalServiceSettings) settings);


                    case "CustomerCustomizerServiceClient":
                        return CustomerCustomizerServiceClient.Create(callInvoker, (CustomerCustomizerServiceSettings) settings);


                    case "CustomerExtensionSettingServiceClient":
                        return CustomerExtensionSettingServiceClient.Create(callInvoker, (CustomerExtensionSettingServiceSettings) settings);


                    case "CustomerFeedServiceClient":
                        return CustomerFeedServiceClient.Create(callInvoker, (CustomerFeedServiceSettings) settings);


                    case "CustomerLabelServiceClient":
                        return CustomerLabelServiceClient.Create(callInvoker, (CustomerLabelServiceSettings) settings);


                    case "CustomerManagerLinkServiceClient":
                        return CustomerManagerLinkServiceClient.Create(callInvoker, (CustomerManagerLinkServiceSettings) settings);


                    case "CustomerNegativeCriterionServiceClient":
                        return CustomerNegativeCriterionServiceClient.Create(callInvoker, (CustomerNegativeCriterionServiceSettings) settings);


                    case "CustomerServiceClient":
                        return CustomerServiceClient.Create(callInvoker, (CustomerServiceSettings) settings);


                    case "CustomerUserAccessInvitationServiceClient":
                        return CustomerUserAccessInvitationServiceClient.Create(callInvoker, (CustomerUserAccessInvitationServiceSettings) settings);


                    case "CustomerUserAccessServiceClient":
                        return CustomerUserAccessServiceClient.Create(callInvoker, (CustomerUserAccessServiceSettings) settings);


                    case "CustomizerAttributeServiceClient":
                        return CustomizerAttributeServiceClient.Create(callInvoker, (CustomizerAttributeServiceSettings) settings);


                    case "DetailPlacementViewServiceClient":
                        return DetailPlacementViewServiceClient.Create(callInvoker, (DetailPlacementViewServiceSettings) settings);


                    case "DetailedDemographicServiceClient":
                        return DetailedDemographicServiceClient.Create(callInvoker, (DetailedDemographicServiceSettings) settings);


                    case "DisplayKeywordViewServiceClient":
                        return DisplayKeywordViewServiceClient.Create(callInvoker, (DisplayKeywordViewServiceSettings) settings);


                    case "DistanceViewServiceClient":
                        return DistanceViewServiceClient.Create(callInvoker, (DistanceViewServiceSettings) settings);


                    case "DomainCategoryServiceClient":
                        return DomainCategoryServiceClient.Create(callInvoker, (DomainCategoryServiceSettings) settings);


                    case "DynamicSearchAdsSearchTermViewServiceClient":
                        return DynamicSearchAdsSearchTermViewServiceClient.Create(callInvoker, (DynamicSearchAdsSearchTermViewServiceSettings) settings);


                    case "ExpandedLandingPageViewServiceClient":
                        return ExpandedLandingPageViewServiceClient.Create(callInvoker, (ExpandedLandingPageViewServiceSettings) settings);


                    case "ExtensionFeedItemServiceClient":
                        return ExtensionFeedItemServiceClient.Create(callInvoker, (ExtensionFeedItemServiceSettings) settings);


                    case "FeedItemServiceClient":
                        return FeedItemServiceClient.Create(callInvoker, (FeedItemServiceSettings) settings);


                    case "FeedItemSetLinkServiceClient":
                        return FeedItemSetLinkServiceClient.Create(callInvoker, (FeedItemSetLinkServiceSettings) settings);


                    case "FeedItemSetServiceClient":
                        return FeedItemSetServiceClient.Create(callInvoker, (FeedItemSetServiceSettings) settings);


                    case "FeedItemTargetServiceClient":
                        return FeedItemTargetServiceClient.Create(callInvoker, (FeedItemTargetServiceSettings) settings);


                    case "FeedMappingServiceClient":
                        return FeedMappingServiceClient.Create(callInvoker, (FeedMappingServiceSettings) settings);


                    case "FeedPlaceholderViewServiceClient":
                        return FeedPlaceholderViewServiceClient.Create(callInvoker, (FeedPlaceholderViewServiceSettings) settings);


                    case "FeedServiceClient":
                        return FeedServiceClient.Create(callInvoker, (FeedServiceSettings) settings);


                    case "GenderViewServiceClient":
                        return GenderViewServiceClient.Create(callInvoker, (GenderViewServiceSettings) settings);


                    case "GeoTargetConstantServiceClient":
                        return GeoTargetConstantServiceClient.Create(callInvoker, (GeoTargetConstantServiceSettings) settings);


                    case "GeographicViewServiceClient":
                        return GeographicViewServiceClient.Create(callInvoker, (GeographicViewServiceSettings) settings);


                    case "GoogleAdsFieldServiceClient":
                        return GoogleAdsFieldServiceClient.Create(callInvoker, (GoogleAdsFieldServiceSettings) settings);


                    case "GoogleAdsServiceClient":
                        return GoogleAdsServiceClient.Create(callInvoker, (GoogleAdsServiceSettings) settings);


                    case "GroupPlacementViewServiceClient":
                        return GroupPlacementViewServiceClient.Create(callInvoker, (GroupPlacementViewServiceSettings) settings);


                    case "HotelGroupViewServiceClient":
                        return HotelGroupViewServiceClient.Create(callInvoker, (HotelGroupViewServiceSettings) settings);


                    case "HotelPerformanceViewServiceClient":
                        return HotelPerformanceViewServiceClient.Create(callInvoker, (HotelPerformanceViewServiceSettings) settings);


                    case "IncomeRangeViewServiceClient":
                        return IncomeRangeViewServiceClient.Create(callInvoker, (IncomeRangeViewServiceSettings) settings);


                    case "InvoiceServiceClient":
                        return InvoiceServiceClient.Create(callInvoker, (InvoiceServiceSettings) settings);


                    case "KeywordPlanAdGroupKeywordServiceClient":
                        return KeywordPlanAdGroupKeywordServiceClient.Create(callInvoker, (KeywordPlanAdGroupKeywordServiceSettings) settings);


                    case "KeywordPlanAdGroupServiceClient":
                        return KeywordPlanAdGroupServiceClient.Create(callInvoker, (KeywordPlanAdGroupServiceSettings) settings);


                    case "KeywordPlanCampaignKeywordServiceClient":
                        return KeywordPlanCampaignKeywordServiceClient.Create(callInvoker, (KeywordPlanCampaignKeywordServiceSettings) settings);


                    case "KeywordPlanCampaignServiceClient":
                        return KeywordPlanCampaignServiceClient.Create(callInvoker, (KeywordPlanCampaignServiceSettings) settings);


                    case "KeywordPlanIdeaServiceClient":
                        return KeywordPlanIdeaServiceClient.Create(callInvoker, (KeywordPlanIdeaServiceSettings) settings);


                    case "KeywordPlanServiceClient":
                        return KeywordPlanServiceClient.Create(callInvoker, (KeywordPlanServiceSettings) settings);


                    case "KeywordThemeConstantServiceClient":
                        return KeywordThemeConstantServiceClient.Create(callInvoker, (KeywordThemeConstantServiceSettings) settings);


                    case "KeywordViewServiceClient":
                        return KeywordViewServiceClient.Create(callInvoker, (KeywordViewServiceSettings) settings);


                    case "LabelServiceClient":
                        return LabelServiceClient.Create(callInvoker, (LabelServiceSettings) settings);


                    case "LandingPageViewServiceClient":
                        return LandingPageViewServiceClient.Create(callInvoker, (LandingPageViewServiceSettings) settings);


                    case "LanguageConstantServiceClient":
                        return LanguageConstantServiceClient.Create(callInvoker, (LanguageConstantServiceSettings) settings);


                    case "LifeEventServiceClient":
                        return LifeEventServiceClient.Create(callInvoker, (LifeEventServiceSettings) settings);


                    case "LocationViewServiceClient":
                        return LocationViewServiceClient.Create(callInvoker, (LocationViewServiceSettings) settings);


                    case "ManagedPlacementViewServiceClient":
                        return ManagedPlacementViewServiceClient.Create(callInvoker, (ManagedPlacementViewServiceSettings) settings);


                    case "MediaFileServiceClient":
                        return MediaFileServiceClient.Create(callInvoker, (MediaFileServiceSettings) settings);


                    case "MerchantCenterLinkServiceClient":
                        return MerchantCenterLinkServiceClient.Create(callInvoker, (MerchantCenterLinkServiceSettings) settings);


                    case "MobileAppCategoryConstantServiceClient":
                        return MobileAppCategoryConstantServiceClient.Create(callInvoker, (MobileAppCategoryConstantServiceSettings) settings);


                    case "MobileDeviceConstantServiceClient":
                        return MobileDeviceConstantServiceClient.Create(callInvoker, (MobileDeviceConstantServiceSettings) settings);


                    case "OfflineUserDataJobServiceClient":
                        return OfflineUserDataJobServiceClient.Create(callInvoker, (OfflineUserDataJobServiceSettings) settings);


                    case "OperatingSystemVersionConstantServiceClient":
                        return OperatingSystemVersionConstantServiceClient.Create(callInvoker, (OperatingSystemVersionConstantServiceSettings) settings);


                    case "PaidOrganicSearchTermViewServiceClient":
                        return PaidOrganicSearchTermViewServiceClient.Create(callInvoker, (PaidOrganicSearchTermViewServiceSettings) settings);


                    case "ParentalStatusViewServiceClient":
                        return ParentalStatusViewServiceClient.Create(callInvoker, (ParentalStatusViewServiceSettings) settings);


                    case "PaymentsAccountServiceClient":
                        return PaymentsAccountServiceClient.Create(callInvoker, (PaymentsAccountServiceSettings) settings);


                    case "ProductBiddingCategoryConstantServiceClient":
                        return ProductBiddingCategoryConstantServiceClient.Create(callInvoker, (ProductBiddingCategoryConstantServiceSettings) settings);


                    case "ProductGroupViewServiceClient":
                        return ProductGroupViewServiceClient.Create(callInvoker, (ProductGroupViewServiceSettings) settings);


                    case "ReachPlanServiceClient":
                        return ReachPlanServiceClient.Create(callInvoker, (ReachPlanServiceSettings) settings);


                    case "RecommendationServiceClient":
                        return RecommendationServiceClient.Create(callInvoker, (RecommendationServiceSettings) settings);


                    case "RemarketingActionServiceClient":
                        return RemarketingActionServiceClient.Create(callInvoker, (RemarketingActionServiceSettings) settings);


                    case "SearchTermViewServiceClient":
                        return SearchTermViewServiceClient.Create(callInvoker, (SearchTermViewServiceSettings) settings);


                    case "SharedCriterionServiceClient":
                        return SharedCriterionServiceClient.Create(callInvoker, (SharedCriterionServiceSettings) settings);


                    case "SharedSetServiceClient":
                        return SharedSetServiceClient.Create(callInvoker, (SharedSetServiceSettings) settings);


                    case "ShoppingPerformanceViewServiceClient":
                        return ShoppingPerformanceViewServiceClient.Create(callInvoker, (ShoppingPerformanceViewServiceSettings) settings);


                    case "SmartCampaignSearchTermViewServiceClient":
                        return SmartCampaignSearchTermViewServiceClient.Create(callInvoker, (SmartCampaignSearchTermViewServiceSettings) settings);


                    case "SmartCampaignSettingServiceClient":
                        return SmartCampaignSettingServiceClient.Create(callInvoker, (SmartCampaignSettingServiceSettings) settings);


                    case "SmartCampaignSuggestServiceClient":
                        return SmartCampaignSuggestServiceClient.Create(callInvoker, (SmartCampaignSuggestServiceSettings) settings);


                    case "ThirdPartyAppAnalyticsLinkServiceClient":
                        return ThirdPartyAppAnalyticsLinkServiceClient.Create(callInvoker, (ThirdPartyAppAnalyticsLinkServiceSettings) settings);


                    case "TopicConstantServiceClient":
                        return TopicConstantServiceClient.Create(callInvoker, (TopicConstantServiceSettings) settings);


                    case "TopicViewServiceClient":
                        return TopicViewServiceClient.Create(callInvoker, (TopicViewServiceSettings) settings);


                    case "UserDataServiceClient":
                        return UserDataServiceClient.Create(callInvoker, (UserDataServiceSettings) settings);


                    case "UserInterestServiceClient":
                        return UserInterestServiceClient.Create(callInvoker, (UserInterestServiceSettings) settings);


                    case "UserListServiceClient":
                        return UserListServiceClient.Create(callInvoker, (UserListServiceSettings) settings);


                    case "UserLocationViewServiceClient":
                        return UserLocationViewServiceClient.Create(callInvoker, (UserLocationViewServiceSettings) settings);


                    case "VideoServiceClient":
                        return VideoServiceClient.Create(callInvoker, (VideoServiceSettings) settings);


                    case "WebpageViewServiceClient":
                        return WebpageViewServiceClient.Create(callInvoker, (WebpageViewServiceSettings) settings);


                    default:
                        return null;
                }
            }


        }
    }
}

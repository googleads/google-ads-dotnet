// Copyright 2025, Google LLC
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
using Google.Ads.GoogleAds.V21.Services;
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
        /// Pseudo enum to list the services supported in V21.
        /// </summary>
        public class V21
        {

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AccountBudgetProposalService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AccountBudgetProposalServiceClient, AccountBudgetProposalServiceSettings, GoogleAdsConfig> AccountBudgetProposalService =
                new ServiceTemplate<AccountBudgetProposalServiceClient, AccountBudgetProposalServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AccountLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AccountLinkServiceClient, AccountLinkServiceSettings, GoogleAdsConfig> AccountLinkService =
                new ServiceTemplate<AccountLinkServiceClient, AccountLinkServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AdGroupAdLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAdLabelServiceClient, AdGroupAdLabelServiceSettings, GoogleAdsConfig> AdGroupAdLabelService =
                new ServiceTemplate<AdGroupAdLabelServiceClient, AdGroupAdLabelServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AdGroupAdService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAdServiceClient, AdGroupAdServiceSettings, GoogleAdsConfig> AdGroupAdService =
                new ServiceTemplate<AdGroupAdServiceClient, AdGroupAdServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AdGroupAssetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAssetServiceClient, AdGroupAssetServiceSettings, GoogleAdsConfig> AdGroupAssetService =
                new ServiceTemplate<AdGroupAssetServiceClient, AdGroupAssetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AdGroupAssetSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAssetSetServiceClient, AdGroupAssetSetServiceSettings, GoogleAdsConfig> AdGroupAssetSetService =
                new ServiceTemplate<AdGroupAssetSetServiceClient, AdGroupAssetSetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AdGroupBidModifierService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupBidModifierServiceClient, AdGroupBidModifierServiceSettings, GoogleAdsConfig> AdGroupBidModifierService =
                new ServiceTemplate<AdGroupBidModifierServiceClient, AdGroupBidModifierServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AdGroupCriterionCustomizerService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupCriterionCustomizerServiceClient, AdGroupCriterionCustomizerServiceSettings, GoogleAdsConfig> AdGroupCriterionCustomizerService =
                new ServiceTemplate<AdGroupCriterionCustomizerServiceClient, AdGroupCriterionCustomizerServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AdGroupCriterionLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupCriterionLabelServiceClient, AdGroupCriterionLabelServiceSettings, GoogleAdsConfig> AdGroupCriterionLabelService =
                new ServiceTemplate<AdGroupCriterionLabelServiceClient, AdGroupCriterionLabelServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AdGroupCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupCriterionServiceClient, AdGroupCriterionServiceSettings, GoogleAdsConfig> AdGroupCriterionService =
                new ServiceTemplate<AdGroupCriterionServiceClient, AdGroupCriterionServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AdGroupCustomizerService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupCustomizerServiceClient, AdGroupCustomizerServiceSettings, GoogleAdsConfig> AdGroupCustomizerService =
                new ServiceTemplate<AdGroupCustomizerServiceClient, AdGroupCustomizerServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AdGroupLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupLabelServiceClient, AdGroupLabelServiceSettings, GoogleAdsConfig> AdGroupLabelService =
                new ServiceTemplate<AdGroupLabelServiceClient, AdGroupLabelServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AdGroupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupServiceClient, AdGroupServiceSettings, GoogleAdsConfig> AdGroupService =
                new ServiceTemplate<AdGroupServiceClient, AdGroupServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AdParameterService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdParameterServiceClient, AdParameterServiceSettings, GoogleAdsConfig> AdParameterService =
                new ServiceTemplate<AdParameterServiceClient, AdParameterServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AdService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdServiceClient, AdServiceSettings, GoogleAdsConfig> AdService =
                new ServiceTemplate<AdServiceClient, AdServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AssetGroupAssetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AssetGroupAssetServiceClient, AssetGroupAssetServiceSettings, GoogleAdsConfig> AssetGroupAssetService =
                new ServiceTemplate<AssetGroupAssetServiceClient, AssetGroupAssetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AssetGroupListingGroupFilterService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AssetGroupListingGroupFilterServiceClient, AssetGroupListingGroupFilterServiceSettings, GoogleAdsConfig> AssetGroupListingGroupFilterService =
                new ServiceTemplate<AssetGroupListingGroupFilterServiceClient, AssetGroupListingGroupFilterServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AssetGroupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AssetGroupServiceClient, AssetGroupServiceSettings, GoogleAdsConfig> AssetGroupService =
                new ServiceTemplate<AssetGroupServiceClient, AssetGroupServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AssetGroupSignalService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AssetGroupSignalServiceClient, AssetGroupSignalServiceSettings, GoogleAdsConfig> AssetGroupSignalService =
                new ServiceTemplate<AssetGroupSignalServiceClient, AssetGroupSignalServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AssetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AssetServiceClient, AssetServiceSettings, GoogleAdsConfig> AssetService =
                new ServiceTemplate<AssetServiceClient, AssetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AssetSetAssetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AssetSetAssetServiceClient, AssetSetAssetServiceSettings, GoogleAdsConfig> AssetSetAssetService =
                new ServiceTemplate<AssetSetAssetServiceClient, AssetSetAssetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AssetSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AssetSetServiceClient, AssetSetServiceSettings, GoogleAdsConfig> AssetSetService =
                new ServiceTemplate<AssetSetServiceClient, AssetSetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AudienceInsightsService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AudienceInsightsServiceClient, AudienceInsightsServiceSettings, GoogleAdsConfig> AudienceInsightsService =
                new ServiceTemplate<AudienceInsightsServiceClient, AudienceInsightsServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AudienceService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AudienceServiceClient, AudienceServiceSettings, GoogleAdsConfig> AudienceService =
                new ServiceTemplate<AudienceServiceClient, AudienceServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/AutomaticallyCreatedAssetRemovalService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AutomaticallyCreatedAssetRemovalServiceClient, AutomaticallyCreatedAssetRemovalServiceSettings, GoogleAdsConfig> AutomaticallyCreatedAssetRemovalService =
                new ServiceTemplate<AutomaticallyCreatedAssetRemovalServiceClient, AutomaticallyCreatedAssetRemovalServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/BatchJobService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BatchJobServiceClient, BatchJobServiceSettings, GoogleAdsConfig> BatchJobService =
                new ServiceTemplate<BatchJobServiceClient, BatchJobServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/BiddingDataExclusionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BiddingDataExclusionServiceClient, BiddingDataExclusionServiceSettings, GoogleAdsConfig> BiddingDataExclusionService =
                new ServiceTemplate<BiddingDataExclusionServiceClient, BiddingDataExclusionServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/BiddingSeasonalityAdjustmentService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BiddingSeasonalityAdjustmentServiceClient, BiddingSeasonalityAdjustmentServiceSettings, GoogleAdsConfig> BiddingSeasonalityAdjustmentService =
                new ServiceTemplate<BiddingSeasonalityAdjustmentServiceClient, BiddingSeasonalityAdjustmentServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/BiddingStrategyService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BiddingStrategyServiceClient, BiddingStrategyServiceSettings, GoogleAdsConfig> BiddingStrategyService =
                new ServiceTemplate<BiddingStrategyServiceClient, BiddingStrategyServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/BillingSetupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BillingSetupServiceClient, BillingSetupServiceSettings, GoogleAdsConfig> BillingSetupService =
                new ServiceTemplate<BillingSetupServiceClient, BillingSetupServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/BrandSuggestionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BrandSuggestionServiceClient, BrandSuggestionServiceSettings, GoogleAdsConfig> BrandSuggestionService =
                new ServiceTemplate<BrandSuggestionServiceClient, BrandSuggestionServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CampaignAssetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignAssetServiceClient, CampaignAssetServiceSettings, GoogleAdsConfig> CampaignAssetService =
                new ServiceTemplate<CampaignAssetServiceClient, CampaignAssetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CampaignAssetSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignAssetSetServiceClient, CampaignAssetSetServiceSettings, GoogleAdsConfig> CampaignAssetSetService =
                new ServiceTemplate<CampaignAssetSetServiceClient, CampaignAssetSetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CampaignBidModifierService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignBidModifierServiceClient, CampaignBidModifierServiceSettings, GoogleAdsConfig> CampaignBidModifierService =
                new ServiceTemplate<CampaignBidModifierServiceClient, CampaignBidModifierServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CampaignBudgetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignBudgetServiceClient, CampaignBudgetServiceSettings, GoogleAdsConfig> CampaignBudgetService =
                new ServiceTemplate<CampaignBudgetServiceClient, CampaignBudgetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CampaignConversionGoalService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignConversionGoalServiceClient, CampaignConversionGoalServiceSettings, GoogleAdsConfig> CampaignConversionGoalService =
                new ServiceTemplate<CampaignConversionGoalServiceClient, CampaignConversionGoalServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CampaignCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignCriterionServiceClient, CampaignCriterionServiceSettings, GoogleAdsConfig> CampaignCriterionService =
                new ServiceTemplate<CampaignCriterionServiceClient, CampaignCriterionServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CampaignCustomizerService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignCustomizerServiceClient, CampaignCustomizerServiceSettings, GoogleAdsConfig> CampaignCustomizerService =
                new ServiceTemplate<CampaignCustomizerServiceClient, CampaignCustomizerServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CampaignDraftService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignDraftServiceClient, CampaignDraftServiceSettings, GoogleAdsConfig> CampaignDraftService =
                new ServiceTemplate<CampaignDraftServiceClient, CampaignDraftServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CampaignGroupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignGroupServiceClient, CampaignGroupServiceSettings, GoogleAdsConfig> CampaignGroupService =
                new ServiceTemplate<CampaignGroupServiceClient, CampaignGroupServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CampaignLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignLabelServiceClient, CampaignLabelServiceSettings, GoogleAdsConfig> CampaignLabelService =
                new ServiceTemplate<CampaignLabelServiceClient, CampaignLabelServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CampaignLifecycleGoalService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignLifecycleGoalServiceClient, CampaignLifecycleGoalServiceSettings, GoogleAdsConfig> CampaignLifecycleGoalService =
                new ServiceTemplate<CampaignLifecycleGoalServiceClient, CampaignLifecycleGoalServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CampaignService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignServiceClient, CampaignServiceSettings, GoogleAdsConfig> CampaignService =
                new ServiceTemplate<CampaignServiceClient, CampaignServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CampaignSharedSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignSharedSetServiceClient, CampaignSharedSetServiceSettings, GoogleAdsConfig> CampaignSharedSetService =
                new ServiceTemplate<CampaignSharedSetServiceClient, CampaignSharedSetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/ContentCreatorInsightsService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ContentCreatorInsightsServiceClient, ContentCreatorInsightsServiceSettings, GoogleAdsConfig> ContentCreatorInsightsService =
                new ServiceTemplate<ContentCreatorInsightsServiceClient, ContentCreatorInsightsServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/ConversionActionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionActionServiceClient, ConversionActionServiceSettings, GoogleAdsConfig> ConversionActionService =
                new ServiceTemplate<ConversionActionServiceClient, ConversionActionServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/ConversionAdjustmentUploadService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionAdjustmentUploadServiceClient, ConversionAdjustmentUploadServiceSettings, GoogleAdsConfig> ConversionAdjustmentUploadService =
                new ServiceTemplate<ConversionAdjustmentUploadServiceClient, ConversionAdjustmentUploadServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/ConversionCustomVariableService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionCustomVariableServiceClient, ConversionCustomVariableServiceSettings, GoogleAdsConfig> ConversionCustomVariableService =
                new ServiceTemplate<ConversionCustomVariableServiceClient, ConversionCustomVariableServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/ConversionGoalCampaignConfigService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionGoalCampaignConfigServiceClient, ConversionGoalCampaignConfigServiceSettings, GoogleAdsConfig> ConversionGoalCampaignConfigService =
                new ServiceTemplate<ConversionGoalCampaignConfigServiceClient, ConversionGoalCampaignConfigServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/ConversionUploadService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionUploadServiceClient, ConversionUploadServiceSettings, GoogleAdsConfig> ConversionUploadService =
                new ServiceTemplate<ConversionUploadServiceClient, ConversionUploadServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/ConversionValueRuleService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionValueRuleServiceClient, ConversionValueRuleServiceSettings, GoogleAdsConfig> ConversionValueRuleService =
                new ServiceTemplate<ConversionValueRuleServiceClient, ConversionValueRuleServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/ConversionValueRuleSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionValueRuleSetServiceClient, ConversionValueRuleSetServiceSettings, GoogleAdsConfig> ConversionValueRuleSetService =
                new ServiceTemplate<ConversionValueRuleSetServiceClient, ConversionValueRuleSetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CustomAudienceService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomAudienceServiceClient, CustomAudienceServiceSettings, GoogleAdsConfig> CustomAudienceService =
                new ServiceTemplate<CustomAudienceServiceClient, CustomAudienceServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CustomConversionGoalService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomConversionGoalServiceClient, CustomConversionGoalServiceSettings, GoogleAdsConfig> CustomConversionGoalService =
                new ServiceTemplate<CustomConversionGoalServiceClient, CustomConversionGoalServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CustomInterestService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomInterestServiceClient, CustomInterestServiceSettings, GoogleAdsConfig> CustomInterestService =
                new ServiceTemplate<CustomInterestServiceClient, CustomInterestServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CustomerAssetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerAssetServiceClient, CustomerAssetServiceSettings, GoogleAdsConfig> CustomerAssetService =
                new ServiceTemplate<CustomerAssetServiceClient, CustomerAssetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CustomerAssetSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerAssetSetServiceClient, CustomerAssetSetServiceSettings, GoogleAdsConfig> CustomerAssetSetService =
                new ServiceTemplate<CustomerAssetSetServiceClient, CustomerAssetSetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CustomerClientLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerClientLinkServiceClient, CustomerClientLinkServiceSettings, GoogleAdsConfig> CustomerClientLinkService =
                new ServiceTemplate<CustomerClientLinkServiceClient, CustomerClientLinkServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CustomerConversionGoalService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerConversionGoalServiceClient, CustomerConversionGoalServiceSettings, GoogleAdsConfig> CustomerConversionGoalService =
                new ServiceTemplate<CustomerConversionGoalServiceClient, CustomerConversionGoalServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CustomerCustomizerService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerCustomizerServiceClient, CustomerCustomizerServiceSettings, GoogleAdsConfig> CustomerCustomizerService =
                new ServiceTemplate<CustomerCustomizerServiceClient, CustomerCustomizerServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CustomerLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerLabelServiceClient, CustomerLabelServiceSettings, GoogleAdsConfig> CustomerLabelService =
                new ServiceTemplate<CustomerLabelServiceClient, CustomerLabelServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CustomerLifecycleGoalService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerLifecycleGoalServiceClient, CustomerLifecycleGoalServiceSettings, GoogleAdsConfig> CustomerLifecycleGoalService =
                new ServiceTemplate<CustomerLifecycleGoalServiceClient, CustomerLifecycleGoalServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CustomerManagerLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerManagerLinkServiceClient, CustomerManagerLinkServiceSettings, GoogleAdsConfig> CustomerManagerLinkService =
                new ServiceTemplate<CustomerManagerLinkServiceClient, CustomerManagerLinkServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CustomerNegativeCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerNegativeCriterionServiceClient, CustomerNegativeCriterionServiceSettings, GoogleAdsConfig> CustomerNegativeCriterionService =
                new ServiceTemplate<CustomerNegativeCriterionServiceClient, CustomerNegativeCriterionServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CustomerService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerServiceClient, CustomerServiceSettings, GoogleAdsConfig> CustomerService =
                new ServiceTemplate<CustomerServiceClient, CustomerServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CustomerSkAdNetworkConversionValueSchemaService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerSkAdNetworkConversionValueSchemaServiceClient, CustomerSkAdNetworkConversionValueSchemaServiceSettings, GoogleAdsConfig> CustomerSkAdNetworkConversionValueSchemaService =
                new ServiceTemplate<CustomerSkAdNetworkConversionValueSchemaServiceClient, CustomerSkAdNetworkConversionValueSchemaServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CustomerUserAccessInvitationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerUserAccessInvitationServiceClient, CustomerUserAccessInvitationServiceSettings, GoogleAdsConfig> CustomerUserAccessInvitationService =
                new ServiceTemplate<CustomerUserAccessInvitationServiceClient, CustomerUserAccessInvitationServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CustomerUserAccessService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerUserAccessServiceClient, CustomerUserAccessServiceSettings, GoogleAdsConfig> CustomerUserAccessService =
                new ServiceTemplate<CustomerUserAccessServiceClient, CustomerUserAccessServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/CustomizerAttributeService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomizerAttributeServiceClient, CustomizerAttributeServiceSettings, GoogleAdsConfig> CustomizerAttributeService =
                new ServiceTemplate<CustomizerAttributeServiceClient, CustomizerAttributeServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/DataLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DataLinkServiceClient, DataLinkServiceSettings, GoogleAdsConfig> DataLinkService =
                new ServiceTemplate<DataLinkServiceClient, DataLinkServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/ExperimentArmService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ExperimentArmServiceClient, ExperimentArmServiceSettings, GoogleAdsConfig> ExperimentArmService =
                new ServiceTemplate<ExperimentArmServiceClient, ExperimentArmServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/ExperimentService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ExperimentServiceClient, ExperimentServiceSettings, GoogleAdsConfig> ExperimentService =
                new ServiceTemplate<ExperimentServiceClient, ExperimentServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/GeoTargetConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GeoTargetConstantServiceClient, GeoTargetConstantServiceSettings, GoogleAdsConfig> GeoTargetConstantService =
                new ServiceTemplate<GeoTargetConstantServiceClient, GeoTargetConstantServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/GoogleAdsFieldService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GoogleAdsFieldServiceClient, GoogleAdsFieldServiceSettings, GoogleAdsConfig> GoogleAdsFieldService =
                new ServiceTemplate<GoogleAdsFieldServiceClient, GoogleAdsFieldServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/GoogleAdsService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GoogleAdsServiceClient, GoogleAdsServiceSettings, GoogleAdsConfig> GoogleAdsService =
                new ServiceTemplate<GoogleAdsServiceClient, GoogleAdsServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/IdentityVerificationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<IdentityVerificationServiceClient, IdentityVerificationServiceSettings, GoogleAdsConfig> IdentityVerificationService =
                new ServiceTemplate<IdentityVerificationServiceClient, IdentityVerificationServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/InvoiceService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<InvoiceServiceClient, InvoiceServiceSettings, GoogleAdsConfig> InvoiceService =
                new ServiceTemplate<InvoiceServiceClient, InvoiceServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/KeywordPlanAdGroupKeywordService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanAdGroupKeywordServiceClient, KeywordPlanAdGroupKeywordServiceSettings, GoogleAdsConfig> KeywordPlanAdGroupKeywordService =
                new ServiceTemplate<KeywordPlanAdGroupKeywordServiceClient, KeywordPlanAdGroupKeywordServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/KeywordPlanAdGroupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanAdGroupServiceClient, KeywordPlanAdGroupServiceSettings, GoogleAdsConfig> KeywordPlanAdGroupService =
                new ServiceTemplate<KeywordPlanAdGroupServiceClient, KeywordPlanAdGroupServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/KeywordPlanCampaignKeywordService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanCampaignKeywordServiceClient, KeywordPlanCampaignKeywordServiceSettings, GoogleAdsConfig> KeywordPlanCampaignKeywordService =
                new ServiceTemplate<KeywordPlanCampaignKeywordServiceClient, KeywordPlanCampaignKeywordServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/KeywordPlanCampaignService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanCampaignServiceClient, KeywordPlanCampaignServiceSettings, GoogleAdsConfig> KeywordPlanCampaignService =
                new ServiceTemplate<KeywordPlanCampaignServiceClient, KeywordPlanCampaignServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/KeywordPlanIdeaService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanIdeaServiceClient, KeywordPlanIdeaServiceSettings, GoogleAdsConfig> KeywordPlanIdeaService =
                new ServiceTemplate<KeywordPlanIdeaServiceClient, KeywordPlanIdeaServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/KeywordPlanService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanServiceClient, KeywordPlanServiceSettings, GoogleAdsConfig> KeywordPlanService =
                new ServiceTemplate<KeywordPlanServiceClient, KeywordPlanServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/KeywordThemeConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordThemeConstantServiceClient, KeywordThemeConstantServiceSettings, GoogleAdsConfig> KeywordThemeConstantService =
                new ServiceTemplate<KeywordThemeConstantServiceClient, KeywordThemeConstantServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/LabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<LabelServiceClient, LabelServiceSettings, GoogleAdsConfig> LabelService =
                new ServiceTemplate<LabelServiceClient, LabelServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/LocalServicesLeadService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<LocalServicesLeadServiceClient, LocalServicesLeadServiceSettings, GoogleAdsConfig> LocalServicesLeadService =
                new ServiceTemplate<LocalServicesLeadServiceClient, LocalServicesLeadServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/OfflineUserDataJobService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<OfflineUserDataJobServiceClient, OfflineUserDataJobServiceSettings, GoogleAdsConfig> OfflineUserDataJobService =
                new ServiceTemplate<OfflineUserDataJobServiceClient, OfflineUserDataJobServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/PaymentsAccountService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<PaymentsAccountServiceClient, PaymentsAccountServiceSettings, GoogleAdsConfig> PaymentsAccountService =
                new ServiceTemplate<PaymentsAccountServiceClient, PaymentsAccountServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/ProductLinkInvitationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ProductLinkInvitationServiceClient, ProductLinkInvitationServiceSettings, GoogleAdsConfig> ProductLinkInvitationService =
                new ServiceTemplate<ProductLinkInvitationServiceClient, ProductLinkInvitationServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/ProductLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ProductLinkServiceClient, ProductLinkServiceSettings, GoogleAdsConfig> ProductLinkService =
                new ServiceTemplate<ProductLinkServiceClient, ProductLinkServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/ReachPlanService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ReachPlanServiceClient, ReachPlanServiceSettings, GoogleAdsConfig> ReachPlanService =
                new ServiceTemplate<ReachPlanServiceClient, ReachPlanServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/RecommendationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<RecommendationServiceClient, RecommendationServiceSettings, GoogleAdsConfig> RecommendationService =
                new ServiceTemplate<RecommendationServiceClient, RecommendationServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/RecommendationSubscriptionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<RecommendationSubscriptionServiceClient, RecommendationSubscriptionServiceSettings, GoogleAdsConfig> RecommendationSubscriptionService =
                new ServiceTemplate<RecommendationSubscriptionServiceClient, RecommendationSubscriptionServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/RemarketingActionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<RemarketingActionServiceClient, RemarketingActionServiceSettings, GoogleAdsConfig> RemarketingActionService =
                new ServiceTemplate<RemarketingActionServiceClient, RemarketingActionServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/ShareablePreviewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ShareablePreviewServiceClient, ShareablePreviewServiceSettings, GoogleAdsConfig> ShareablePreviewService =
                new ServiceTemplate<ShareablePreviewServiceClient, ShareablePreviewServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/SharedCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SharedCriterionServiceClient, SharedCriterionServiceSettings, GoogleAdsConfig> SharedCriterionService =
                new ServiceTemplate<SharedCriterionServiceClient, SharedCriterionServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/SharedSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SharedSetServiceClient, SharedSetServiceSettings, GoogleAdsConfig> SharedSetService =
                new ServiceTemplate<SharedSetServiceClient, SharedSetServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/SmartCampaignSettingService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SmartCampaignSettingServiceClient, SmartCampaignSettingServiceSettings, GoogleAdsConfig> SmartCampaignSettingService =
                new ServiceTemplate<SmartCampaignSettingServiceClient, SmartCampaignSettingServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/SmartCampaignSuggestService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SmartCampaignSuggestServiceClient, SmartCampaignSuggestServiceSettings, GoogleAdsConfig> SmartCampaignSuggestService =
                new ServiceTemplate<SmartCampaignSuggestServiceClient, SmartCampaignSuggestServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/ThirdPartyAppAnalyticsLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ThirdPartyAppAnalyticsLinkServiceClient, ThirdPartyAppAnalyticsLinkServiceSettings, GoogleAdsConfig> ThirdPartyAppAnalyticsLinkService =
                new ServiceTemplate<ThirdPartyAppAnalyticsLinkServiceClient, ThirdPartyAppAnalyticsLinkServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/TravelAssetSuggestionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<TravelAssetSuggestionServiceClient, TravelAssetSuggestionServiceSettings, GoogleAdsConfig> TravelAssetSuggestionService =
                new ServiceTemplate<TravelAssetSuggestionServiceClient, TravelAssetSuggestionServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/UserDataService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<UserDataServiceClient, UserDataServiceSettings, GoogleAdsConfig> UserDataService =
                new ServiceTemplate<UserDataServiceClient, UserDataServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/UserListCustomerTypeService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<UserListCustomerTypeServiceClient, UserListCustomerTypeServiceSettings, GoogleAdsConfig> UserListCustomerTypeService =
                new ServiceTemplate<UserListCustomerTypeServiceClient, UserListCustomerTypeServiceSettings, GoogleAdsConfig>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v21/UserListService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<UserListServiceClient, UserListServiceSettings, GoogleAdsConfig> UserListService =
                new ServiceTemplate<UserListServiceClient, UserListServiceSettings, GoogleAdsConfig>(Create);


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

                    case "AccountBudgetProposalServiceClient":
                        return AccountBudgetProposalServiceClient.Create(callInvoker, (AccountBudgetProposalServiceSettings) settings);


                    case "AccountLinkServiceClient":
                        return AccountLinkServiceClient.Create(callInvoker, (AccountLinkServiceSettings) settings);


                    case "AdGroupAdLabelServiceClient":
                        return AdGroupAdLabelServiceClient.Create(callInvoker, (AdGroupAdLabelServiceSettings) settings);


                    case "AdGroupAdServiceClient":
                        return AdGroupAdServiceClient.Create(callInvoker, (AdGroupAdServiceSettings) settings);


                    case "AdGroupAssetServiceClient":
                        return AdGroupAssetServiceClient.Create(callInvoker, (AdGroupAssetServiceSettings) settings);


                    case "AdGroupAssetSetServiceClient":
                        return AdGroupAssetSetServiceClient.Create(callInvoker, (AdGroupAssetSetServiceSettings) settings);


                    case "AdGroupBidModifierServiceClient":
                        return AdGroupBidModifierServiceClient.Create(callInvoker, (AdGroupBidModifierServiceSettings) settings);


                    case "AdGroupCriterionCustomizerServiceClient":
                        return AdGroupCriterionCustomizerServiceClient.Create(callInvoker, (AdGroupCriterionCustomizerServiceSettings) settings);


                    case "AdGroupCriterionLabelServiceClient":
                        return AdGroupCriterionLabelServiceClient.Create(callInvoker, (AdGroupCriterionLabelServiceSettings) settings);


                    case "AdGroupCriterionServiceClient":
                        return AdGroupCriterionServiceClient.Create(callInvoker, (AdGroupCriterionServiceSettings) settings);


                    case "AdGroupCustomizerServiceClient":
                        return AdGroupCustomizerServiceClient.Create(callInvoker, (AdGroupCustomizerServiceSettings) settings);


                    case "AdGroupLabelServiceClient":
                        return AdGroupLabelServiceClient.Create(callInvoker, (AdGroupLabelServiceSettings) settings);


                    case "AdGroupServiceClient":
                        return AdGroupServiceClient.Create(callInvoker, (AdGroupServiceSettings) settings);


                    case "AdParameterServiceClient":
                        return AdParameterServiceClient.Create(callInvoker, (AdParameterServiceSettings) settings);


                    case "AdServiceClient":
                        return AdServiceClient.Create(callInvoker, (AdServiceSettings) settings);


                    case "AssetGroupAssetServiceClient":
                        return AssetGroupAssetServiceClient.Create(callInvoker, (AssetGroupAssetServiceSettings) settings);


                    case "AssetGroupListingGroupFilterServiceClient":
                        return AssetGroupListingGroupFilterServiceClient.Create(callInvoker, (AssetGroupListingGroupFilterServiceSettings) settings);


                    case "AssetGroupServiceClient":
                        return AssetGroupServiceClient.Create(callInvoker, (AssetGroupServiceSettings) settings);


                    case "AssetGroupSignalServiceClient":
                        return AssetGroupSignalServiceClient.Create(callInvoker, (AssetGroupSignalServiceSettings) settings);


                    case "AssetServiceClient":
                        return AssetServiceClient.Create(callInvoker, (AssetServiceSettings) settings);


                    case "AssetSetAssetServiceClient":
                        return AssetSetAssetServiceClient.Create(callInvoker, (AssetSetAssetServiceSettings) settings);


                    case "AssetSetServiceClient":
                        return AssetSetServiceClient.Create(callInvoker, (AssetSetServiceSettings) settings);


                    case "AudienceInsightsServiceClient":
                        return AudienceInsightsServiceClient.Create(callInvoker, (AudienceInsightsServiceSettings) settings);


                    case "AudienceServiceClient":
                        return AudienceServiceClient.Create(callInvoker, (AudienceServiceSettings) settings);


                    case "AutomaticallyCreatedAssetRemovalServiceClient":
                        return AutomaticallyCreatedAssetRemovalServiceClient.Create(callInvoker, (AutomaticallyCreatedAssetRemovalServiceSettings) settings);


                    case "BatchJobServiceClient":
                        return BatchJobServiceClient.Create(callInvoker, (BatchJobServiceSettings) settings);


                    case "BiddingDataExclusionServiceClient":
                        return BiddingDataExclusionServiceClient.Create(callInvoker, (BiddingDataExclusionServiceSettings) settings);


                    case "BiddingSeasonalityAdjustmentServiceClient":
                        return BiddingSeasonalityAdjustmentServiceClient.Create(callInvoker, (BiddingSeasonalityAdjustmentServiceSettings) settings);


                    case "BiddingStrategyServiceClient":
                        return BiddingStrategyServiceClient.Create(callInvoker, (BiddingStrategyServiceSettings) settings);


                    case "BillingSetupServiceClient":
                        return BillingSetupServiceClient.Create(callInvoker, (BillingSetupServiceSettings) settings);


                    case "BrandSuggestionServiceClient":
                        return BrandSuggestionServiceClient.Create(callInvoker, (BrandSuggestionServiceSettings) settings);


                    case "CampaignAssetServiceClient":
                        return CampaignAssetServiceClient.Create(callInvoker, (CampaignAssetServiceSettings) settings);


                    case "CampaignAssetSetServiceClient":
                        return CampaignAssetSetServiceClient.Create(callInvoker, (CampaignAssetSetServiceSettings) settings);


                    case "CampaignBidModifierServiceClient":
                        return CampaignBidModifierServiceClient.Create(callInvoker, (CampaignBidModifierServiceSettings) settings);


                    case "CampaignBudgetServiceClient":
                        return CampaignBudgetServiceClient.Create(callInvoker, (CampaignBudgetServiceSettings) settings);


                    case "CampaignConversionGoalServiceClient":
                        return CampaignConversionGoalServiceClient.Create(callInvoker, (CampaignConversionGoalServiceSettings) settings);


                    case "CampaignCriterionServiceClient":
                        return CampaignCriterionServiceClient.Create(callInvoker, (CampaignCriterionServiceSettings) settings);


                    case "CampaignCustomizerServiceClient":
                        return CampaignCustomizerServiceClient.Create(callInvoker, (CampaignCustomizerServiceSettings) settings);


                    case "CampaignDraftServiceClient":
                        return CampaignDraftServiceClient.Create(callInvoker, (CampaignDraftServiceSettings) settings);


                    case "CampaignGroupServiceClient":
                        return CampaignGroupServiceClient.Create(callInvoker, (CampaignGroupServiceSettings) settings);


                    case "CampaignLabelServiceClient":
                        return CampaignLabelServiceClient.Create(callInvoker, (CampaignLabelServiceSettings) settings);


                    case "CampaignLifecycleGoalServiceClient":
                        return CampaignLifecycleGoalServiceClient.Create(callInvoker, (CampaignLifecycleGoalServiceSettings) settings);


                    case "CampaignServiceClient":
                        return CampaignServiceClient.Create(callInvoker, (CampaignServiceSettings) settings);


                    case "CampaignSharedSetServiceClient":
                        return CampaignSharedSetServiceClient.Create(callInvoker, (CampaignSharedSetServiceSettings) settings);


                    case "ContentCreatorInsightsServiceClient":
                        return ContentCreatorInsightsServiceClient.Create(callInvoker, (ContentCreatorInsightsServiceSettings) settings);


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


                    case "CustomAudienceServiceClient":
                        return CustomAudienceServiceClient.Create(callInvoker, (CustomAudienceServiceSettings) settings);


                    case "CustomConversionGoalServiceClient":
                        return CustomConversionGoalServiceClient.Create(callInvoker, (CustomConversionGoalServiceSettings) settings);


                    case "CustomInterestServiceClient":
                        return CustomInterestServiceClient.Create(callInvoker, (CustomInterestServiceSettings) settings);


                    case "CustomerAssetServiceClient":
                        return CustomerAssetServiceClient.Create(callInvoker, (CustomerAssetServiceSettings) settings);


                    case "CustomerAssetSetServiceClient":
                        return CustomerAssetSetServiceClient.Create(callInvoker, (CustomerAssetSetServiceSettings) settings);


                    case "CustomerClientLinkServiceClient":
                        return CustomerClientLinkServiceClient.Create(callInvoker, (CustomerClientLinkServiceSettings) settings);


                    case "CustomerConversionGoalServiceClient":
                        return CustomerConversionGoalServiceClient.Create(callInvoker, (CustomerConversionGoalServiceSettings) settings);


                    case "CustomerCustomizerServiceClient":
                        return CustomerCustomizerServiceClient.Create(callInvoker, (CustomerCustomizerServiceSettings) settings);


                    case "CustomerLabelServiceClient":
                        return CustomerLabelServiceClient.Create(callInvoker, (CustomerLabelServiceSettings) settings);


                    case "CustomerLifecycleGoalServiceClient":
                        return CustomerLifecycleGoalServiceClient.Create(callInvoker, (CustomerLifecycleGoalServiceSettings) settings);


                    case "CustomerManagerLinkServiceClient":
                        return CustomerManagerLinkServiceClient.Create(callInvoker, (CustomerManagerLinkServiceSettings) settings);


                    case "CustomerNegativeCriterionServiceClient":
                        return CustomerNegativeCriterionServiceClient.Create(callInvoker, (CustomerNegativeCriterionServiceSettings) settings);


                    case "CustomerServiceClient":
                        return CustomerServiceClient.Create(callInvoker, (CustomerServiceSettings) settings);


                    case "CustomerSkAdNetworkConversionValueSchemaServiceClient":
                        return CustomerSkAdNetworkConversionValueSchemaServiceClient.Create(callInvoker, (CustomerSkAdNetworkConversionValueSchemaServiceSettings) settings);


                    case "CustomerUserAccessInvitationServiceClient":
                        return CustomerUserAccessInvitationServiceClient.Create(callInvoker, (CustomerUserAccessInvitationServiceSettings) settings);


                    case "CustomerUserAccessServiceClient":
                        return CustomerUserAccessServiceClient.Create(callInvoker, (CustomerUserAccessServiceSettings) settings);


                    case "CustomizerAttributeServiceClient":
                        return CustomizerAttributeServiceClient.Create(callInvoker, (CustomizerAttributeServiceSettings) settings);


                    case "DataLinkServiceClient":
                        return DataLinkServiceClient.Create(callInvoker, (DataLinkServiceSettings) settings);


                    case "ExperimentArmServiceClient":
                        return ExperimentArmServiceClient.Create(callInvoker, (ExperimentArmServiceSettings) settings);


                    case "ExperimentServiceClient":
                        return ExperimentServiceClient.Create(callInvoker, (ExperimentServiceSettings) settings);


                    case "GeoTargetConstantServiceClient":
                        return GeoTargetConstantServiceClient.Create(callInvoker, (GeoTargetConstantServiceSettings) settings);


                    case "GoogleAdsFieldServiceClient":
                        return GoogleAdsFieldServiceClient.Create(callInvoker, (GoogleAdsFieldServiceSettings) settings);


                    case "GoogleAdsServiceClient":
                        return GoogleAdsServiceClient.Create(callInvoker, (GoogleAdsServiceSettings) settings);


                    case "IdentityVerificationServiceClient":
                        return IdentityVerificationServiceClient.Create(callInvoker, (IdentityVerificationServiceSettings) settings);


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


                    case "LabelServiceClient":
                        return LabelServiceClient.Create(callInvoker, (LabelServiceSettings) settings);


                    case "LocalServicesLeadServiceClient":
                        return LocalServicesLeadServiceClient.Create(callInvoker, (LocalServicesLeadServiceSettings) settings);


                    case "OfflineUserDataJobServiceClient":
                        return OfflineUserDataJobServiceClient.Create(callInvoker, (OfflineUserDataJobServiceSettings) settings);


                    case "PaymentsAccountServiceClient":
                        return PaymentsAccountServiceClient.Create(callInvoker, (PaymentsAccountServiceSettings) settings);


                    case "ProductLinkInvitationServiceClient":
                        return ProductLinkInvitationServiceClient.Create(callInvoker, (ProductLinkInvitationServiceSettings) settings);


                    case "ProductLinkServiceClient":
                        return ProductLinkServiceClient.Create(callInvoker, (ProductLinkServiceSettings) settings);


                    case "ReachPlanServiceClient":
                        return ReachPlanServiceClient.Create(callInvoker, (ReachPlanServiceSettings) settings);


                    case "RecommendationServiceClient":
                        return RecommendationServiceClient.Create(callInvoker, (RecommendationServiceSettings) settings);


                    case "RecommendationSubscriptionServiceClient":
                        return RecommendationSubscriptionServiceClient.Create(callInvoker, (RecommendationSubscriptionServiceSettings) settings);


                    case "RemarketingActionServiceClient":
                        return RemarketingActionServiceClient.Create(callInvoker, (RemarketingActionServiceSettings) settings);


                    case "ShareablePreviewServiceClient":
                        return ShareablePreviewServiceClient.Create(callInvoker, (ShareablePreviewServiceSettings) settings);


                    case "SharedCriterionServiceClient":
                        return SharedCriterionServiceClient.Create(callInvoker, (SharedCriterionServiceSettings) settings);


                    case "SharedSetServiceClient":
                        return SharedSetServiceClient.Create(callInvoker, (SharedSetServiceSettings) settings);


                    case "SmartCampaignSettingServiceClient":
                        return SmartCampaignSettingServiceClient.Create(callInvoker, (SmartCampaignSettingServiceSettings) settings);


                    case "SmartCampaignSuggestServiceClient":
                        return SmartCampaignSuggestServiceClient.Create(callInvoker, (SmartCampaignSuggestServiceSettings) settings);


                    case "ThirdPartyAppAnalyticsLinkServiceClient":
                        return ThirdPartyAppAnalyticsLinkServiceClient.Create(callInvoker, (ThirdPartyAppAnalyticsLinkServiceSettings) settings);


                    case "TravelAssetSuggestionServiceClient":
                        return TravelAssetSuggestionServiceClient.Create(callInvoker, (TravelAssetSuggestionServiceSettings) settings);


                    case "UserDataServiceClient":
                        return UserDataServiceClient.Create(callInvoker, (UserDataServiceSettings) settings);


                    case "UserListCustomerTypeServiceClient":
                        return UserListCustomerTypeServiceClient.Create(callInvoker, (UserListCustomerTypeServiceSettings) settings);


                    case "UserListServiceClient":
                        return UserListServiceClient.Create(callInvoker, (UserListServiceSettings) settings);


                    default:
                        return null;
                }
            }


        }
    }
}

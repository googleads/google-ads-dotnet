// Copyright 2020, Google LLC
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
using Google.Ads.GoogleAds.V6.Services;
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
        /// Pseudo enum to list the services supported in V6.
        /// </summary>
        public class V6
        {

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AccountBudgetProposalService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AccountBudgetProposalServiceClient, AccountBudgetProposalServiceSettings> AccountBudgetProposalService =
                new ServiceTemplate<AccountBudgetProposalServiceClient, AccountBudgetProposalServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AccountBudgetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AccountBudgetServiceClient, AccountBudgetServiceSettings> AccountBudgetService =
                new ServiceTemplate<AccountBudgetServiceClient, AccountBudgetServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AccountLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AccountLinkServiceClient, AccountLinkServiceSettings> AccountLinkService =
                new ServiceTemplate<AccountLinkServiceClient, AccountLinkServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AdGroupAdAssetViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAdAssetViewServiceClient, AdGroupAdAssetViewServiceSettings> AdGroupAdAssetViewService =
                new ServiceTemplate<AdGroupAdAssetViewServiceClient, AdGroupAdAssetViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AdGroupAdLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAdLabelServiceClient, AdGroupAdLabelServiceSettings> AdGroupAdLabelService =
                new ServiceTemplate<AdGroupAdLabelServiceClient, AdGroupAdLabelServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AdGroupAdService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAdServiceClient, AdGroupAdServiceSettings> AdGroupAdService =
                new ServiceTemplate<AdGroupAdServiceClient, AdGroupAdServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AdGroupAudienceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAudienceViewServiceClient, AdGroupAudienceViewServiceSettings> AdGroupAudienceViewService =
                new ServiceTemplate<AdGroupAudienceViewServiceClient, AdGroupAudienceViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AdGroupBidModifierService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupBidModifierServiceClient, AdGroupBidModifierServiceSettings> AdGroupBidModifierService =
                new ServiceTemplate<AdGroupBidModifierServiceClient, AdGroupBidModifierServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AdGroupCriterionLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupCriterionLabelServiceClient, AdGroupCriterionLabelServiceSettings> AdGroupCriterionLabelService =
                new ServiceTemplate<AdGroupCriterionLabelServiceClient, AdGroupCriterionLabelServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AdGroupCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupCriterionServiceClient, AdGroupCriterionServiceSettings> AdGroupCriterionService =
                new ServiceTemplate<AdGroupCriterionServiceClient, AdGroupCriterionServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AdGroupCriterionSimulationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupCriterionSimulationServiceClient, AdGroupCriterionSimulationServiceSettings> AdGroupCriterionSimulationService =
                new ServiceTemplate<AdGroupCriterionSimulationServiceClient, AdGroupCriterionSimulationServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AdGroupExtensionSettingService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupExtensionSettingServiceClient, AdGroupExtensionSettingServiceSettings> AdGroupExtensionSettingService =
                new ServiceTemplate<AdGroupExtensionSettingServiceClient, AdGroupExtensionSettingServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AdGroupFeedService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupFeedServiceClient, AdGroupFeedServiceSettings> AdGroupFeedService =
                new ServiceTemplate<AdGroupFeedServiceClient, AdGroupFeedServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AdGroupLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupLabelServiceClient, AdGroupLabelServiceSettings> AdGroupLabelService =
                new ServiceTemplate<AdGroupLabelServiceClient, AdGroupLabelServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AdGroupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupServiceClient, AdGroupServiceSettings> AdGroupService =
                new ServiceTemplate<AdGroupServiceClient, AdGroupServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AdGroupSimulationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupSimulationServiceClient, AdGroupSimulationServiceSettings> AdGroupSimulationService =
                new ServiceTemplate<AdGroupSimulationServiceClient, AdGroupSimulationServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AdParameterService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdParameterServiceClient, AdParameterServiceSettings> AdParameterService =
                new ServiceTemplate<AdParameterServiceClient, AdParameterServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AdScheduleViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdScheduleViewServiceClient, AdScheduleViewServiceSettings> AdScheduleViewService =
                new ServiceTemplate<AdScheduleViewServiceClient, AdScheduleViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AdService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdServiceClient, AdServiceSettings> AdService =
                new ServiceTemplate<AdServiceClient, AdServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AgeRangeViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AgeRangeViewServiceClient, AgeRangeViewServiceSettings> AgeRangeViewService =
                new ServiceTemplate<AgeRangeViewServiceClient, AgeRangeViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/AssetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AssetServiceClient, AssetServiceSettings> AssetService =
                new ServiceTemplate<AssetServiceClient, AssetServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/BatchJobService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BatchJobServiceClient, BatchJobServiceSettings> BatchJobService =
                new ServiceTemplate<BatchJobServiceClient, BatchJobServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/BiddingStrategyService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BiddingStrategyServiceClient, BiddingStrategyServiceSettings> BiddingStrategyService =
                new ServiceTemplate<BiddingStrategyServiceClient, BiddingStrategyServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/BillingSetupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BillingSetupServiceClient, BillingSetupServiceSettings> BillingSetupService =
                new ServiceTemplate<BillingSetupServiceClient, BillingSetupServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CampaignAssetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignAssetServiceClient, CampaignAssetServiceSettings> CampaignAssetService =
                new ServiceTemplate<CampaignAssetServiceClient, CampaignAssetServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CampaignAudienceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignAudienceViewServiceClient, CampaignAudienceViewServiceSettings> CampaignAudienceViewService =
                new ServiceTemplate<CampaignAudienceViewServiceClient, CampaignAudienceViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CampaignBidModifierService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignBidModifierServiceClient, CampaignBidModifierServiceSettings> CampaignBidModifierService =
                new ServiceTemplate<CampaignBidModifierServiceClient, CampaignBidModifierServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CampaignBudgetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignBudgetServiceClient, CampaignBudgetServiceSettings> CampaignBudgetService =
                new ServiceTemplate<CampaignBudgetServiceClient, CampaignBudgetServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CampaignCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignCriterionServiceClient, CampaignCriterionServiceSettings> CampaignCriterionService =
                new ServiceTemplate<CampaignCriterionServiceClient, CampaignCriterionServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CampaignCriterionSimulationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignCriterionSimulationServiceClient, CampaignCriterionSimulationServiceSettings> CampaignCriterionSimulationService =
                new ServiceTemplate<CampaignCriterionSimulationServiceClient, CampaignCriterionSimulationServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CampaignDraftService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignDraftServiceClient, CampaignDraftServiceSettings> CampaignDraftService =
                new ServiceTemplate<CampaignDraftServiceClient, CampaignDraftServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CampaignExperimentService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignExperimentServiceClient, CampaignExperimentServiceSettings> CampaignExperimentService =
                new ServiceTemplate<CampaignExperimentServiceClient, CampaignExperimentServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CampaignExtensionSettingService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignExtensionSettingServiceClient, CampaignExtensionSettingServiceSettings> CampaignExtensionSettingService =
                new ServiceTemplate<CampaignExtensionSettingServiceClient, CampaignExtensionSettingServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CampaignFeedService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignFeedServiceClient, CampaignFeedServiceSettings> CampaignFeedService =
                new ServiceTemplate<CampaignFeedServiceClient, CampaignFeedServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CampaignLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignLabelServiceClient, CampaignLabelServiceSettings> CampaignLabelService =
                new ServiceTemplate<CampaignLabelServiceClient, CampaignLabelServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CampaignService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignServiceClient, CampaignServiceSettings> CampaignService =
                new ServiceTemplate<CampaignServiceClient, CampaignServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CampaignSharedSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignSharedSetServiceClient, CampaignSharedSetServiceSettings> CampaignSharedSetService =
                new ServiceTemplate<CampaignSharedSetServiceClient, CampaignSharedSetServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CarrierConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CarrierConstantServiceClient, CarrierConstantServiceSettings> CarrierConstantService =
                new ServiceTemplate<CarrierConstantServiceClient, CarrierConstantServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/ChangeStatusService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ChangeStatusServiceClient, ChangeStatusServiceSettings> ChangeStatusService =
                new ServiceTemplate<ChangeStatusServiceClient, ChangeStatusServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/ClickViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ClickViewServiceClient, ClickViewServiceSettings> ClickViewService =
                new ServiceTemplate<ClickViewServiceClient, ClickViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CombinedAudienceService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CombinedAudienceServiceClient, CombinedAudienceServiceSettings> CombinedAudienceService =
                new ServiceTemplate<CombinedAudienceServiceClient, CombinedAudienceServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/ConversionActionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionActionServiceClient, ConversionActionServiceSettings> ConversionActionService =
                new ServiceTemplate<ConversionActionServiceClient, ConversionActionServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/ConversionAdjustmentUploadService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionAdjustmentUploadServiceClient, ConversionAdjustmentUploadServiceSettings> ConversionAdjustmentUploadService =
                new ServiceTemplate<ConversionAdjustmentUploadServiceClient, ConversionAdjustmentUploadServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/ConversionUploadService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionUploadServiceClient, ConversionUploadServiceSettings> ConversionUploadService =
                new ServiceTemplate<ConversionUploadServiceClient, ConversionUploadServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CurrencyConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CurrencyConstantServiceClient, CurrencyConstantServiceSettings> CurrencyConstantService =
                new ServiceTemplate<CurrencyConstantServiceClient, CurrencyConstantServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CustomAudienceService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomAudienceServiceClient, CustomAudienceServiceSettings> CustomAudienceService =
                new ServiceTemplate<CustomAudienceServiceClient, CustomAudienceServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CustomInterestService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomInterestServiceClient, CustomInterestServiceSettings> CustomInterestService =
                new ServiceTemplate<CustomInterestServiceClient, CustomInterestServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CustomerClientLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerClientLinkServiceClient, CustomerClientLinkServiceSettings> CustomerClientLinkService =
                new ServiceTemplate<CustomerClientLinkServiceClient, CustomerClientLinkServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CustomerClientService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerClientServiceClient, CustomerClientServiceSettings> CustomerClientService =
                new ServiceTemplate<CustomerClientServiceClient, CustomerClientServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CustomerExtensionSettingService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerExtensionSettingServiceClient, CustomerExtensionSettingServiceSettings> CustomerExtensionSettingService =
                new ServiceTemplate<CustomerExtensionSettingServiceClient, CustomerExtensionSettingServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CustomerFeedService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerFeedServiceClient, CustomerFeedServiceSettings> CustomerFeedService =
                new ServiceTemplate<CustomerFeedServiceClient, CustomerFeedServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CustomerLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerLabelServiceClient, CustomerLabelServiceSettings> CustomerLabelService =
                new ServiceTemplate<CustomerLabelServiceClient, CustomerLabelServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CustomerManagerLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerManagerLinkServiceClient, CustomerManagerLinkServiceSettings> CustomerManagerLinkService =
                new ServiceTemplate<CustomerManagerLinkServiceClient, CustomerManagerLinkServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CustomerNegativeCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerNegativeCriterionServiceClient, CustomerNegativeCriterionServiceSettings> CustomerNegativeCriterionService =
                new ServiceTemplate<CustomerNegativeCriterionServiceClient, CustomerNegativeCriterionServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CustomerService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerServiceClient, CustomerServiceSettings> CustomerService =
                new ServiceTemplate<CustomerServiceClient, CustomerServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CustomerUserAccessInvitationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerUserAccessInvitationServiceClient, CustomerUserAccessInvitationServiceSettings> CustomerUserAccessInvitationService =
                new ServiceTemplate<CustomerUserAccessInvitationServiceClient, CustomerUserAccessInvitationServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/CustomerUserAccessService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerUserAccessServiceClient, CustomerUserAccessServiceSettings> CustomerUserAccessService =
                new ServiceTemplate<CustomerUserAccessServiceClient, CustomerUserAccessServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/DetailPlacementViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DetailPlacementViewServiceClient, DetailPlacementViewServiceSettings> DetailPlacementViewService =
                new ServiceTemplate<DetailPlacementViewServiceClient, DetailPlacementViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/DisplayKeywordViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DisplayKeywordViewServiceClient, DisplayKeywordViewServiceSettings> DisplayKeywordViewService =
                new ServiceTemplate<DisplayKeywordViewServiceClient, DisplayKeywordViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/DistanceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DistanceViewServiceClient, DistanceViewServiceSettings> DistanceViewService =
                new ServiceTemplate<DistanceViewServiceClient, DistanceViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/DomainCategoryService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DomainCategoryServiceClient, DomainCategoryServiceSettings> DomainCategoryService =
                new ServiceTemplate<DomainCategoryServiceClient, DomainCategoryServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/DynamicSearchAdsSearchTermViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DynamicSearchAdsSearchTermViewServiceClient, DynamicSearchAdsSearchTermViewServiceSettings> DynamicSearchAdsSearchTermViewService =
                new ServiceTemplate<DynamicSearchAdsSearchTermViewServiceClient, DynamicSearchAdsSearchTermViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/ExpandedLandingPageViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ExpandedLandingPageViewServiceClient, ExpandedLandingPageViewServiceSettings> ExpandedLandingPageViewService =
                new ServiceTemplate<ExpandedLandingPageViewServiceClient, ExpandedLandingPageViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/ExtensionFeedItemService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ExtensionFeedItemServiceClient, ExtensionFeedItemServiceSettings> ExtensionFeedItemService =
                new ServiceTemplate<ExtensionFeedItemServiceClient, ExtensionFeedItemServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/FeedItemService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedItemServiceClient, FeedItemServiceSettings> FeedItemService =
                new ServiceTemplate<FeedItemServiceClient, FeedItemServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/FeedItemSetLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedItemSetLinkServiceClient, FeedItemSetLinkServiceSettings> FeedItemSetLinkService =
                new ServiceTemplate<FeedItemSetLinkServiceClient, FeedItemSetLinkServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/FeedItemSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedItemSetServiceClient, FeedItemSetServiceSettings> FeedItemSetService =
                new ServiceTemplate<FeedItemSetServiceClient, FeedItemSetServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/FeedItemTargetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedItemTargetServiceClient, FeedItemTargetServiceSettings> FeedItemTargetService =
                new ServiceTemplate<FeedItemTargetServiceClient, FeedItemTargetServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/FeedMappingService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedMappingServiceClient, FeedMappingServiceSettings> FeedMappingService =
                new ServiceTemplate<FeedMappingServiceClient, FeedMappingServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/FeedPlaceholderViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedPlaceholderViewServiceClient, FeedPlaceholderViewServiceSettings> FeedPlaceholderViewService =
                new ServiceTemplate<FeedPlaceholderViewServiceClient, FeedPlaceholderViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/FeedService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedServiceClient, FeedServiceSettings> FeedService =
                new ServiceTemplate<FeedServiceClient, FeedServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/GenderViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GenderViewServiceClient, GenderViewServiceSettings> GenderViewService =
                new ServiceTemplate<GenderViewServiceClient, GenderViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/GeoTargetConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GeoTargetConstantServiceClient, GeoTargetConstantServiceSettings> GeoTargetConstantService =
                new ServiceTemplate<GeoTargetConstantServiceClient, GeoTargetConstantServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/GeographicViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GeographicViewServiceClient, GeographicViewServiceSettings> GeographicViewService =
                new ServiceTemplate<GeographicViewServiceClient, GeographicViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/GoogleAdsFieldService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GoogleAdsFieldServiceClient, GoogleAdsFieldServiceSettings> GoogleAdsFieldService =
                new ServiceTemplate<GoogleAdsFieldServiceClient, GoogleAdsFieldServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/GoogleAdsService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GoogleAdsServiceClient, GoogleAdsServiceSettings> GoogleAdsService =
                new ServiceTemplate<GoogleAdsServiceClient, GoogleAdsServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/GroupPlacementViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GroupPlacementViewServiceClient, GroupPlacementViewServiceSettings> GroupPlacementViewService =
                new ServiceTemplate<GroupPlacementViewServiceClient, GroupPlacementViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/HotelGroupViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<HotelGroupViewServiceClient, HotelGroupViewServiceSettings> HotelGroupViewService =
                new ServiceTemplate<HotelGroupViewServiceClient, HotelGroupViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/HotelPerformanceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<HotelPerformanceViewServiceClient, HotelPerformanceViewServiceSettings> HotelPerformanceViewService =
                new ServiceTemplate<HotelPerformanceViewServiceClient, HotelPerformanceViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/IncomeRangeViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<IncomeRangeViewServiceClient, IncomeRangeViewServiceSettings> IncomeRangeViewService =
                new ServiceTemplate<IncomeRangeViewServiceClient, IncomeRangeViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/InvoiceService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<InvoiceServiceClient, InvoiceServiceSettings> InvoiceService =
                new ServiceTemplate<InvoiceServiceClient, InvoiceServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/KeywordPlanAdGroupKeywordService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanAdGroupKeywordServiceClient, KeywordPlanAdGroupKeywordServiceSettings> KeywordPlanAdGroupKeywordService =
                new ServiceTemplate<KeywordPlanAdGroupKeywordServiceClient, KeywordPlanAdGroupKeywordServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/KeywordPlanAdGroupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanAdGroupServiceClient, KeywordPlanAdGroupServiceSettings> KeywordPlanAdGroupService =
                new ServiceTemplate<KeywordPlanAdGroupServiceClient, KeywordPlanAdGroupServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/KeywordPlanCampaignKeywordService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanCampaignKeywordServiceClient, KeywordPlanCampaignKeywordServiceSettings> KeywordPlanCampaignKeywordService =
                new ServiceTemplate<KeywordPlanCampaignKeywordServiceClient, KeywordPlanCampaignKeywordServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/KeywordPlanCampaignService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanCampaignServiceClient, KeywordPlanCampaignServiceSettings> KeywordPlanCampaignService =
                new ServiceTemplate<KeywordPlanCampaignServiceClient, KeywordPlanCampaignServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/KeywordPlanIdeaService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanIdeaServiceClient, KeywordPlanIdeaServiceSettings> KeywordPlanIdeaService =
                new ServiceTemplate<KeywordPlanIdeaServiceClient, KeywordPlanIdeaServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/KeywordPlanService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanServiceClient, KeywordPlanServiceSettings> KeywordPlanService =
                new ServiceTemplate<KeywordPlanServiceClient, KeywordPlanServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/KeywordViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordViewServiceClient, KeywordViewServiceSettings> KeywordViewService =
                new ServiceTemplate<KeywordViewServiceClient, KeywordViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/LabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<LabelServiceClient, LabelServiceSettings> LabelService =
                new ServiceTemplate<LabelServiceClient, LabelServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/LandingPageViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<LandingPageViewServiceClient, LandingPageViewServiceSettings> LandingPageViewService =
                new ServiceTemplate<LandingPageViewServiceClient, LandingPageViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/LanguageConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<LanguageConstantServiceClient, LanguageConstantServiceSettings> LanguageConstantService =
                new ServiceTemplate<LanguageConstantServiceClient, LanguageConstantServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/LocationViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<LocationViewServiceClient, LocationViewServiceSettings> LocationViewService =
                new ServiceTemplate<LocationViewServiceClient, LocationViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/ManagedPlacementViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ManagedPlacementViewServiceClient, ManagedPlacementViewServiceSettings> ManagedPlacementViewService =
                new ServiceTemplate<ManagedPlacementViewServiceClient, ManagedPlacementViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/MediaFileService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<MediaFileServiceClient, MediaFileServiceSettings> MediaFileService =
                new ServiceTemplate<MediaFileServiceClient, MediaFileServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/MerchantCenterLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<MerchantCenterLinkServiceClient, MerchantCenterLinkServiceSettings> MerchantCenterLinkService =
                new ServiceTemplate<MerchantCenterLinkServiceClient, MerchantCenterLinkServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/MobileAppCategoryConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<MobileAppCategoryConstantServiceClient, MobileAppCategoryConstantServiceSettings> MobileAppCategoryConstantService =
                new ServiceTemplate<MobileAppCategoryConstantServiceClient, MobileAppCategoryConstantServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/MobileDeviceConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<MobileDeviceConstantServiceClient, MobileDeviceConstantServiceSettings> MobileDeviceConstantService =
                new ServiceTemplate<MobileDeviceConstantServiceClient, MobileDeviceConstantServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/OfflineUserDataJobService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<OfflineUserDataJobServiceClient, OfflineUserDataJobServiceSettings> OfflineUserDataJobService =
                new ServiceTemplate<OfflineUserDataJobServiceClient, OfflineUserDataJobServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/OperatingSystemVersionConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<OperatingSystemVersionConstantServiceClient, OperatingSystemVersionConstantServiceSettings> OperatingSystemVersionConstantService =
                new ServiceTemplate<OperatingSystemVersionConstantServiceClient, OperatingSystemVersionConstantServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/PaidOrganicSearchTermViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<PaidOrganicSearchTermViewServiceClient, PaidOrganicSearchTermViewServiceSettings> PaidOrganicSearchTermViewService =
                new ServiceTemplate<PaidOrganicSearchTermViewServiceClient, PaidOrganicSearchTermViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/ParentalStatusViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ParentalStatusViewServiceClient, ParentalStatusViewServiceSettings> ParentalStatusViewService =
                new ServiceTemplate<ParentalStatusViewServiceClient, ParentalStatusViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/PaymentsAccountService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<PaymentsAccountServiceClient, PaymentsAccountServiceSettings> PaymentsAccountService =
                new ServiceTemplate<PaymentsAccountServiceClient, PaymentsAccountServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/ProductBiddingCategoryConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ProductBiddingCategoryConstantServiceClient, ProductBiddingCategoryConstantServiceSettings> ProductBiddingCategoryConstantService =
                new ServiceTemplate<ProductBiddingCategoryConstantServiceClient, ProductBiddingCategoryConstantServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/ProductGroupViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ProductGroupViewServiceClient, ProductGroupViewServiceSettings> ProductGroupViewService =
                new ServiceTemplate<ProductGroupViewServiceClient, ProductGroupViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/ReachPlanService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ReachPlanServiceClient, ReachPlanServiceSettings> ReachPlanService =
                new ServiceTemplate<ReachPlanServiceClient, ReachPlanServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/RecommendationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<RecommendationServiceClient, RecommendationServiceSettings> RecommendationService =
                new ServiceTemplate<RecommendationServiceClient, RecommendationServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/RemarketingActionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<RemarketingActionServiceClient, RemarketingActionServiceSettings> RemarketingActionService =
                new ServiceTemplate<RemarketingActionServiceClient, RemarketingActionServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/SearchTermViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SearchTermViewServiceClient, SearchTermViewServiceSettings> SearchTermViewService =
                new ServiceTemplate<SearchTermViewServiceClient, SearchTermViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/SharedCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SharedCriterionServiceClient, SharedCriterionServiceSettings> SharedCriterionService =
                new ServiceTemplate<SharedCriterionServiceClient, SharedCriterionServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/SharedSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SharedSetServiceClient, SharedSetServiceSettings> SharedSetService =
                new ServiceTemplate<SharedSetServiceClient, SharedSetServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/ShoppingPerformanceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ShoppingPerformanceViewServiceClient, ShoppingPerformanceViewServiceSettings> ShoppingPerformanceViewService =
                new ServiceTemplate<ShoppingPerformanceViewServiceClient, ShoppingPerformanceViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/ThirdPartyAppAnalyticsLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ThirdPartyAppAnalyticsLinkServiceClient, ThirdPartyAppAnalyticsLinkServiceSettings> ThirdPartyAppAnalyticsLinkService =
                new ServiceTemplate<ThirdPartyAppAnalyticsLinkServiceClient, ThirdPartyAppAnalyticsLinkServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/TopicConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<TopicConstantServiceClient, TopicConstantServiceSettings> TopicConstantService =
                new ServiceTemplate<TopicConstantServiceClient, TopicConstantServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/TopicViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<TopicViewServiceClient, TopicViewServiceSettings> TopicViewService =
                new ServiceTemplate<TopicViewServiceClient, TopicViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/UserDataService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<UserDataServiceClient, UserDataServiceSettings> UserDataService =
                new ServiceTemplate<UserDataServiceClient, UserDataServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/UserInterestService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<UserInterestServiceClient, UserInterestServiceSettings> UserInterestService =
                new ServiceTemplate<UserInterestServiceClient, UserInterestServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/UserListService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<UserListServiceClient, UserListServiceSettings> UserListService =
                new ServiceTemplate<UserListServiceClient, UserListServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/UserLocationViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<UserLocationViewServiceClient, UserLocationViewServiceSettings> UserLocationViewService =
                new ServiceTemplate<UserLocationViewServiceClient, UserLocationViewServiceSettings>(Create);


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/v6/VideoService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<VideoServiceClient, VideoServiceSettings> VideoService =
                new ServiceTemplate<VideoServiceClient, VideoServiceSettings>(Create);


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


                    case "AdGroupAudienceViewServiceClient":
                        return AdGroupAudienceViewServiceClient.Create(callInvoker, (AdGroupAudienceViewServiceSettings) settings);


                    case "AdGroupBidModifierServiceClient":
                        return AdGroupBidModifierServiceClient.Create(callInvoker, (AdGroupBidModifierServiceSettings) settings);


                    case "AdGroupCriterionLabelServiceClient":
                        return AdGroupCriterionLabelServiceClient.Create(callInvoker, (AdGroupCriterionLabelServiceSettings) settings);


                    case "AdGroupCriterionServiceClient":
                        return AdGroupCriterionServiceClient.Create(callInvoker, (AdGroupCriterionServiceSettings) settings);


                    case "AdGroupCriterionSimulationServiceClient":
                        return AdGroupCriterionSimulationServiceClient.Create(callInvoker, (AdGroupCriterionSimulationServiceSettings) settings);


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


                    case "AssetServiceClient":
                        return AssetServiceClient.Create(callInvoker, (AssetServiceSettings) settings);


                    case "BatchJobServiceClient":
                        return BatchJobServiceClient.Create(callInvoker, (BatchJobServiceSettings) settings);


                    case "BiddingStrategyServiceClient":
                        return BiddingStrategyServiceClient.Create(callInvoker, (BiddingStrategyServiceSettings) settings);


                    case "BillingSetupServiceClient":
                        return BillingSetupServiceClient.Create(callInvoker, (BillingSetupServiceSettings) settings);


                    case "CampaignAssetServiceClient":
                        return CampaignAssetServiceClient.Create(callInvoker, (CampaignAssetServiceSettings) settings);


                    case "CampaignAudienceViewServiceClient":
                        return CampaignAudienceViewServiceClient.Create(callInvoker, (CampaignAudienceViewServiceSettings) settings);


                    case "CampaignBidModifierServiceClient":
                        return CampaignBidModifierServiceClient.Create(callInvoker, (CampaignBidModifierServiceSettings) settings);


                    case "CampaignBudgetServiceClient":
                        return CampaignBudgetServiceClient.Create(callInvoker, (CampaignBudgetServiceSettings) settings);


                    case "CampaignCriterionServiceClient":
                        return CampaignCriterionServiceClient.Create(callInvoker, (CampaignCriterionServiceSettings) settings);


                    case "CampaignCriterionSimulationServiceClient":
                        return CampaignCriterionSimulationServiceClient.Create(callInvoker, (CampaignCriterionSimulationServiceSettings) settings);


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


                    case "ConversionUploadServiceClient":
                        return ConversionUploadServiceClient.Create(callInvoker, (ConversionUploadServiceSettings) settings);


                    case "CurrencyConstantServiceClient":
                        return CurrencyConstantServiceClient.Create(callInvoker, (CurrencyConstantServiceSettings) settings);


                    case "CustomAudienceServiceClient":
                        return CustomAudienceServiceClient.Create(callInvoker, (CustomAudienceServiceSettings) settings);


                    case "CustomInterestServiceClient":
                        return CustomInterestServiceClient.Create(callInvoker, (CustomInterestServiceSettings) settings);


                    case "CustomerClientLinkServiceClient":
                        return CustomerClientLinkServiceClient.Create(callInvoker, (CustomerClientLinkServiceSettings) settings);


                    case "CustomerClientServiceClient":
                        return CustomerClientServiceClient.Create(callInvoker, (CustomerClientServiceSettings) settings);


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


                    case "DetailPlacementViewServiceClient":
                        return DetailPlacementViewServiceClient.Create(callInvoker, (DetailPlacementViewServiceSettings) settings);


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


                    case "KeywordViewServiceClient":
                        return KeywordViewServiceClient.Create(callInvoker, (KeywordViewServiceSettings) settings);


                    case "LabelServiceClient":
                        return LabelServiceClient.Create(callInvoker, (LabelServiceSettings) settings);


                    case "LandingPageViewServiceClient":
                        return LandingPageViewServiceClient.Create(callInvoker, (LandingPageViewServiceSettings) settings);


                    case "LanguageConstantServiceClient":
                        return LanguageConstantServiceClient.Create(callInvoker, (LanguageConstantServiceSettings) settings);


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


                    default:
                        return null;
                }
            }


        }
    }
}

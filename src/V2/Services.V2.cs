// Copyright 2019, Google LLC
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
using Google.Ads.GoogleAds.V2.Services;

namespace Google.Ads.GoogleAds
{
    /// <summary>
    ///  Class to act as a pseudo namespace provider for service creation.
    /// </summary>
    public partial class Services
    {
        /// <summary>
        /// Pseudo enum to list the services supported in V2.
        /// </summary>
        public class V2
        {

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AccountBudgetProposalService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AccountBudgetProposalServiceClient, AccountBudgetProposalServiceSettings> AccountBudgetProposalService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AccountBudgetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AccountBudgetServiceClient, AccountBudgetServiceSettings> AccountBudgetService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AdGroupAdAssetViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAdAssetViewServiceClient, AdGroupAdAssetViewServiceSettings> AdGroupAdAssetViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AdGroupAdLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAdLabelServiceClient, AdGroupAdLabelServiceSettings> AdGroupAdLabelService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AdGroupAdService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAdServiceClient, AdGroupAdServiceSettings> AdGroupAdService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AdGroupAudienceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAudienceViewServiceClient, AdGroupAudienceViewServiceSettings> AdGroupAudienceViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AdGroupBidModifierService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupBidModifierServiceClient, AdGroupBidModifierServiceSettings> AdGroupBidModifierService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AdGroupCriterionLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupCriterionLabelServiceClient, AdGroupCriterionLabelServiceSettings> AdGroupCriterionLabelService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AdGroupCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupCriterionServiceClient, AdGroupCriterionServiceSettings> AdGroupCriterionService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AdGroupCriterionSimulationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupCriterionSimulationServiceClient, AdGroupCriterionSimulationServiceSettings> AdGroupCriterionSimulationService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AdGroupExtensionSettingService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupExtensionSettingServiceClient, AdGroupExtensionSettingServiceSettings> AdGroupExtensionSettingService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AdGroupFeedService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupFeedServiceClient, AdGroupFeedServiceSettings> AdGroupFeedService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AdGroupLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupLabelServiceClient, AdGroupLabelServiceSettings> AdGroupLabelService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AdGroupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupServiceClient, AdGroupServiceSettings> AdGroupService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AdGroupSimulationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupSimulationServiceClient, AdGroupSimulationServiceSettings> AdGroupSimulationService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AdParameterService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdParameterServiceClient, AdParameterServiceSettings> AdParameterService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AdScheduleViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdScheduleViewServiceClient, AdScheduleViewServiceSettings> AdScheduleViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AdService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdServiceClient, AdServiceSettings> AdService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AgeRangeViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AgeRangeViewServiceClient, AgeRangeViewServiceSettings> AgeRangeViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.AssetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AssetServiceClient, AssetServiceSettings> AssetService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.BiddingStrategyService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BiddingStrategyServiceClient, BiddingStrategyServiceSettings> BiddingStrategyService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.BillingSetupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BillingSetupServiceClient, BillingSetupServiceSettings> BillingSetupService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CampaignAudienceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignAudienceViewServiceClient, CampaignAudienceViewServiceSettings> CampaignAudienceViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CampaignBidModifierService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignBidModifierServiceClient, CampaignBidModifierServiceSettings> CampaignBidModifierService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CampaignBudgetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignBudgetServiceClient, CampaignBudgetServiceSettings> CampaignBudgetService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CampaignCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignCriterionServiceClient, CampaignCriterionServiceSettings> CampaignCriterionService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CampaignCriterionSimulationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignCriterionSimulationServiceClient, CampaignCriterionSimulationServiceSettings> CampaignCriterionSimulationService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CampaignDraftService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignDraftServiceClient, CampaignDraftServiceSettings> CampaignDraftService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CampaignExperimentService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignExperimentServiceClient, CampaignExperimentServiceSettings> CampaignExperimentService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CampaignExtensionSettingService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignExtensionSettingServiceClient, CampaignExtensionSettingServiceSettings> CampaignExtensionSettingService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CampaignFeedService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignFeedServiceClient, CampaignFeedServiceSettings> CampaignFeedService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CampaignLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignLabelServiceClient, CampaignLabelServiceSettings> CampaignLabelService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CampaignService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignServiceClient, CampaignServiceSettings> CampaignService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CampaignSharedSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignSharedSetServiceClient, CampaignSharedSetServiceSettings> CampaignSharedSetService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CarrierConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CarrierConstantServiceClient, CarrierConstantServiceSettings> CarrierConstantService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.ChangeStatusService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ChangeStatusServiceClient, ChangeStatusServiceSettings> ChangeStatusService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.ClickViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ClickViewServiceClient, ClickViewServiceSettings> ClickViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.ConversionActionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionActionServiceClient, ConversionActionServiceSettings> ConversionActionService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.ConversionAdjustmentUploadService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionAdjustmentUploadServiceClient, ConversionAdjustmentUploadServiceSettings> ConversionAdjustmentUploadService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.ConversionUploadService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionUploadServiceClient, ConversionUploadServiceSettings> ConversionUploadService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CustomerClientLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerClientLinkServiceClient, CustomerClientLinkServiceSettings> CustomerClientLinkService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CustomerClientService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerClientServiceClient, CustomerClientServiceSettings> CustomerClientService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CustomerExtensionSettingService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerExtensionSettingServiceClient, CustomerExtensionSettingServiceSettings> CustomerExtensionSettingService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CustomerFeedService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerFeedServiceClient, CustomerFeedServiceSettings> CustomerFeedService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CustomerLabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerLabelServiceClient, CustomerLabelServiceSettings> CustomerLabelService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CustomerManagerLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerManagerLinkServiceClient, CustomerManagerLinkServiceSettings> CustomerManagerLinkService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CustomerNegativeCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerNegativeCriterionServiceClient, CustomerNegativeCriterionServiceSettings> CustomerNegativeCriterionService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CustomerService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerServiceClient, CustomerServiceSettings> CustomerService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.CustomInterestService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomInterestServiceClient, CustomInterestServiceSettings> CustomInterestService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.DetailPlacementViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DetailPlacementViewServiceClient, DetailPlacementViewServiceSettings> DetailPlacementViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.DisplayKeywordViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DisplayKeywordViewServiceClient, DisplayKeywordViewServiceSettings> DisplayKeywordViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.DistanceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DistanceViewServiceClient, DistanceViewServiceSettings> DistanceViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.DomainCategoryService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DomainCategoryServiceClient, DomainCategoryServiceSettings> DomainCategoryService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.DynamicSearchAdsSearchTermViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DynamicSearchAdsSearchTermViewServiceClient, DynamicSearchAdsSearchTermViewServiceSettings> DynamicSearchAdsSearchTermViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.ExpandedLandingPageViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ExpandedLandingPageViewServiceClient, ExpandedLandingPageViewServiceSettings> ExpandedLandingPageViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.ExtensionFeedItemService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ExtensionFeedItemServiceClient, ExtensionFeedItemServiceSettings> ExtensionFeedItemService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.FeedItemService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedItemServiceClient, FeedItemServiceSettings> FeedItemService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.FeedItemTargetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedItemTargetServiceClient, FeedItemTargetServiceSettings> FeedItemTargetService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.FeedMappingService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedMappingServiceClient, FeedMappingServiceSettings> FeedMappingService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.FeedPlaceholderViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedPlaceholderViewServiceClient, FeedPlaceholderViewServiceSettings> FeedPlaceholderViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.FeedService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedServiceClient, FeedServiceSettings> FeedService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.GenderViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GenderViewServiceClient, GenderViewServiceSettings> GenderViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.GeographicViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GeographicViewServiceClient, GeographicViewServiceSettings> GeographicViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.GeoTargetConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GeoTargetConstantServiceClient, GeoTargetConstantServiceSettings> GeoTargetConstantService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.GoogleAdsFieldService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GoogleAdsFieldServiceClient, GoogleAdsFieldServiceSettings> GoogleAdsFieldService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.GoogleAdsService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GoogleAdsServiceClient, GoogleAdsServiceSettings> GoogleAdsService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.GroupPlacementViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GroupPlacementViewServiceClient, GroupPlacementViewServiceSettings> GroupPlacementViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.HotelGroupViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<HotelGroupViewServiceClient, HotelGroupViewServiceSettings> HotelGroupViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.HotelPerformanceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<HotelPerformanceViewServiceClient, HotelPerformanceViewServiceSettings> HotelPerformanceViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.InvoiceService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<InvoiceServiceClient, InvoiceServiceSettings> InvoiceService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.KeywordPlanAdGroupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanAdGroupServiceClient, KeywordPlanAdGroupServiceSettings> KeywordPlanAdGroupService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.KeywordPlanCampaignService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanCampaignServiceClient, KeywordPlanCampaignServiceSettings> KeywordPlanCampaignService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.KeywordPlanIdeaService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanIdeaServiceClient, KeywordPlanIdeaServiceSettings> KeywordPlanIdeaService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.KeywordPlanKeywordService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanKeywordServiceClient, KeywordPlanKeywordServiceSettings> KeywordPlanKeywordService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.KeywordPlanNegativeKeywordService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanNegativeKeywordServiceClient, KeywordPlanNegativeKeywordServiceSettings> KeywordPlanNegativeKeywordService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.KeywordPlanService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanServiceClient, KeywordPlanServiceSettings> KeywordPlanService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.KeywordViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordViewServiceClient, KeywordViewServiceSettings> KeywordViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.LabelService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<LabelServiceClient, LabelServiceSettings> LabelService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.LandingPageViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<LandingPageViewServiceClient, LandingPageViewServiceSettings> LandingPageViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.LanguageConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<LanguageConstantServiceClient, LanguageConstantServiceSettings> LanguageConstantService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.LocationViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<LocationViewServiceClient, LocationViewServiceSettings> LocationViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.ManagedPlacementViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ManagedPlacementViewServiceClient, ManagedPlacementViewServiceSettings> ManagedPlacementViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.MediaFileService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<MediaFileServiceClient, MediaFileServiceSettings> MediaFileService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.MerchantCenterLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<MerchantCenterLinkServiceClient, MerchantCenterLinkServiceSettings> MerchantCenterLinkService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.MobileAppCategoryConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<MobileAppCategoryConstantServiceClient, MobileAppCategoryConstantServiceSettings> MobileAppCategoryConstantService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.MobileDeviceConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<MobileDeviceConstantServiceClient, MobileDeviceConstantServiceSettings> MobileDeviceConstantService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.MutateJobService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<MutateJobServiceClient, MutateJobServiceSettings> MutateJobService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.OperatingSystemVersionConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<OperatingSystemVersionConstantServiceClient, OperatingSystemVersionConstantServiceSettings> OperatingSystemVersionConstantService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.PaidOrganicSearchTermViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<PaidOrganicSearchTermViewServiceClient, PaidOrganicSearchTermViewServiceSettings> PaidOrganicSearchTermViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.ParentalStatusViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ParentalStatusViewServiceClient, ParentalStatusViewServiceSettings> ParentalStatusViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.PaymentsAccountService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<PaymentsAccountServiceClient, PaymentsAccountServiceSettings> PaymentsAccountService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.ProductBiddingCategoryConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ProductBiddingCategoryConstantServiceClient, ProductBiddingCategoryConstantServiceSettings> ProductBiddingCategoryConstantService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.ProductGroupViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ProductGroupViewServiceClient, ProductGroupViewServiceSettings> ProductGroupViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.ReachPlanService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ReachPlanServiceClient, ReachPlanServiceSettings> ReachPlanService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.RecommendationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<RecommendationServiceClient, RecommendationServiceSettings> RecommendationService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.RemarketingActionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<RemarketingActionServiceClient, RemarketingActionServiceSettings> RemarketingActionService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.SearchTermViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SearchTermViewServiceClient, SearchTermViewServiceSettings> SearchTermViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.SharedCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SharedCriterionServiceClient, SharedCriterionServiceSettings> SharedCriterionService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.SharedSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SharedSetServiceClient, SharedSetServiceSettings> SharedSetService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.ShoppingPerformanceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ShoppingPerformanceViewServiceClient, ShoppingPerformanceViewServiceSettings> ShoppingPerformanceViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.TopicConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<TopicConstantServiceClient, TopicConstantServiceSettings> TopicConstantService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.TopicViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<TopicViewServiceClient, TopicViewServiceSettings> TopicViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.UserInterestService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<UserInterestServiceClient, UserInterestServiceSettings> UserInterestService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.UserListService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<UserListServiceClient, UserListServiceSettings> UserListService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.UserLocationViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<UserLocationViewServiceClient, UserLocationViewServiceSettings> UserLocationViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v2.services#google.ads.googleads.v2.services.VideoService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<VideoServiceClient, VideoServiceSettings> VideoService;


        }
    }
}

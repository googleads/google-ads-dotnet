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
using Google.Ads.GoogleAds.V0.Services;

namespace Google.Ads.GoogleAds
{
    /// <summary>
    ///  Class to act as a pseudo namespace provider for service creation.
    /// </summary>
    public partial class Services
    {
        /// <summary>
        /// Pseudo enum to list the services supported in V0.
        /// </summary>
        public class V0
        {

            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.AccountBudgetProposalService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AccountBudgetProposalServiceClient, AccountBudgetProposalServiceSettings> AccountBudgetProposalService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.AccountBudgetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AccountBudgetServiceClient, AccountBudgetServiceSettings> AccountBudgetService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.AdGroupAdService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAdServiceClient, AdGroupAdServiceSettings> AdGroupAdService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.AdGroupAudienceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupAudienceViewServiceClient, AdGroupAudienceViewServiceSettings> AdGroupAudienceViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.AdGroupBidModifierService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupBidModifierServiceClient, AdGroupBidModifierServiceSettings> AdGroupBidModifierService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.AdGroupCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupCriterionServiceClient, AdGroupCriterionServiceSettings> AdGroupCriterionService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.AdGroupFeedService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupFeedServiceClient, AdGroupFeedServiceSettings> AdGroupFeedService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.AdGroupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdGroupServiceClient, AdGroupServiceSettings> AdGroupService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.AdParameterService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdParameterServiceClient, AdParameterServiceSettings> AdParameterService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.AdScheduleViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AdScheduleViewServiceClient, AdScheduleViewServiceSettings> AdScheduleViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.AgeRangeViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<AgeRangeViewServiceClient, AgeRangeViewServiceSettings> AgeRangeViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.BiddingStrategyService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BiddingStrategyServiceClient, BiddingStrategyServiceSettings> BiddingStrategyService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.BillingSetupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<BillingSetupServiceClient, BillingSetupServiceSettings> BillingSetupService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CampaignAudienceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignAudienceViewServiceClient, CampaignAudienceViewServiceSettings> CampaignAudienceViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CampaignBidModifierService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignBidModifierServiceClient, CampaignBidModifierServiceSettings> CampaignBidModifierService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CampaignBudgetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignBudgetServiceClient, CampaignBudgetServiceSettings> CampaignBudgetService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CampaignCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignCriterionServiceClient, CampaignCriterionServiceSettings> CampaignCriterionService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CampaignFeedService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignFeedServiceClient, CampaignFeedServiceSettings> CampaignFeedService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CampaignService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignServiceClient, CampaignServiceSettings> CampaignService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CampaignSharedSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CampaignSharedSetServiceClient, CampaignSharedSetServiceSettings> CampaignSharedSetService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CarrierConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CarrierConstantServiceClient, CarrierConstantServiceSettings> CarrierConstantService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.ChangeStatusService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ChangeStatusServiceClient, ChangeStatusServiceSettings> ChangeStatusService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.ConversionActionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ConversionActionServiceClient, ConversionActionServiceSettings> ConversionActionService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CustomerClientLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerClientLinkServiceClient, CustomerClientLinkServiceSettings> CustomerClientLinkService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CustomerClientService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerClientServiceClient, CustomerClientServiceSettings> CustomerClientService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CustomerFeedService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerFeedServiceClient, CustomerFeedServiceSettings> CustomerFeedService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CustomerManagerLinkService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerManagerLinkServiceClient, CustomerManagerLinkServiceSettings> CustomerManagerLinkService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.CustomerService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<CustomerServiceClient, CustomerServiceSettings> CustomerService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.DisplayKeywordViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<DisplayKeywordViewServiceClient, DisplayKeywordViewServiceSettings> DisplayKeywordViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.FeedItemService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedItemServiceClient, FeedItemServiceSettings> FeedItemService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.FeedMappingService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedMappingServiceClient, FeedMappingServiceSettings> FeedMappingService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.FeedService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<FeedServiceClient, FeedServiceSettings> FeedService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.GenderViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GenderViewServiceClient, GenderViewServiceSettings> GenderViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.GeoTargetConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GeoTargetConstantServiceClient, GeoTargetConstantServiceSettings> GeoTargetConstantService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.GoogleAdsFieldService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GoogleAdsFieldServiceClient, GoogleAdsFieldServiceSettings> GoogleAdsFieldService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.GoogleAdsService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<GoogleAdsServiceClient, GoogleAdsServiceSettings> GoogleAdsService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.HotelGroupViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<HotelGroupViewServiceClient, HotelGroupViewServiceSettings> HotelGroupViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.HotelPerformanceViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<HotelPerformanceViewServiceClient, HotelPerformanceViewServiceSettings> HotelPerformanceViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.KeywordPlanAdGroupService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanAdGroupServiceClient, KeywordPlanAdGroupServiceSettings> KeywordPlanAdGroupService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.KeywordPlanCampaignService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanCampaignServiceClient, KeywordPlanCampaignServiceSettings> KeywordPlanCampaignService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.KeywordPlanIdeaService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanIdeaServiceClient, KeywordPlanIdeaServiceSettings> KeywordPlanIdeaService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.KeywordPlanKeywordService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanKeywordServiceClient, KeywordPlanKeywordServiceSettings> KeywordPlanKeywordService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.KeywordPlanNegativeKeywordService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanNegativeKeywordServiceClient, KeywordPlanNegativeKeywordServiceSettings> KeywordPlanNegativeKeywordService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.KeywordPlanService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordPlanServiceClient, KeywordPlanServiceSettings> KeywordPlanService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.KeywordViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<KeywordViewServiceClient, KeywordViewServiceSettings> KeywordViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.LanguageConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<LanguageConstantServiceClient, LanguageConstantServiceSettings> LanguageConstantService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.ManagedPlacementViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ManagedPlacementViewServiceClient, ManagedPlacementViewServiceSettings> ManagedPlacementViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.MediaFileService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<MediaFileServiceClient, MediaFileServiceSettings> MediaFileService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.MobileAppCategoryConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<MobileAppCategoryConstantServiceClient, MobileAppCategoryConstantServiceSettings> MobileAppCategoryConstantService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.MobileDeviceConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<MobileDeviceConstantServiceClient, MobileDeviceConstantServiceSettings> MobileDeviceConstantService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.OperatingSystemVersionConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<OperatingSystemVersionConstantServiceClient, OperatingSystemVersionConstantServiceSettings> OperatingSystemVersionConstantService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.ParentalStatusViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ParentalStatusViewServiceClient, ParentalStatusViewServiceSettings> ParentalStatusViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.PaymentsAccountService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<PaymentsAccountServiceClient, PaymentsAccountServiceSettings> PaymentsAccountService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.ProductGroupViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<ProductGroupViewServiceClient, ProductGroupViewServiceSettings> ProductGroupViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.RecommendationService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<RecommendationServiceClient, RecommendationServiceSettings> RecommendationService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.RemarketingActionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<RemarketingActionServiceClient, RemarketingActionServiceSettings> RemarketingActionService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.SearchTermViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SearchTermViewServiceClient, SearchTermViewServiceSettings> SearchTermViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.SharedCriterionService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SharedCriterionServiceClient, SharedCriterionServiceSettings> SharedCriterionService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.SharedSetService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<SharedSetServiceClient, SharedSetServiceSettings> SharedSetService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.TopicConstantService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<TopicConstantServiceClient, TopicConstantServiceSettings> TopicConstantService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.TopicViewService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<TopicViewServiceClient, TopicViewServiceSettings> TopicViewService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.UserInterestService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<UserInterestServiceClient, UserInterestServiceSettings> UserInterestService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.UserListService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<UserListServiceClient, UserListServiceSettings> UserListService;


            /// <summary>
            /// See https://developers.google.com/google-ads/api/reference/rpc/google.ads.googleads.v0.services#google.ads.googleads.v0.services.VideoService
            /// for details.
            /// </summary>
            public static readonly ServiceTemplate<VideoServiceClient, VideoServiceSettings> VideoService;


        }
    }
}

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

using Google.Protobuf.WellKnownTypes;
using System.Linq;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagve = Google.Ads.GoogleAds.V0.Enums;
using scg = System.Collections.Generic;
using st = System.Threading;
using stt = System.Threading.Tasks;

#pragma warning disable CS1591

namespace Google.Ads.GoogleAds.V0.Services
{
    public abstract partial class CustomerServiceClient
    {
        public string[] ListAccessibleCustomers()
        {
            return ListAccessibleCustomers(new ListAccessibleCustomersRequest() { })
                .ResourceNames.ToArray();
        }
    }

    public abstract partial class GeoTargetConstantServiceClient
    {
        public virtual SuggestGeoTargetConstantsResponse SuggestGeoTargetConstants(
            StringValue locale,
            StringValue countryCode,
            gaxgrpc::CallSettings callSettings = null) => SuggestGeoTargetConstants(
                locale.Value, countryCode.Value, callSettings);

        public virtual stt::Task<SuggestGeoTargetConstantsResponse> SuggestGeoTargetConstantsAsync(
            StringValue locale,
            StringValue countryCode,
            gaxgrpc::CallSettings callSettings = null) => SuggestGeoTargetConstantsAsync(
                locale.Value, countryCode.Value, callSettings);
    }

    public abstract partial class KeywordPlanIdeaServiceClient
    {
        public virtual GenerateKeywordIdeaResponse GenerateKeywordIdeas(
            string customerId,
            StringValue language,
            scg::IEnumerable<string> geoTargetConstants,
            gagve::KeywordPlanNetworkEnum.Types.KeywordPlanNetwork keywordPlanNetwork,
            gaxgrpc::CallSettings callSettings = null) => GenerateKeywordIdeas(
                customerId, language.Value, geoTargetConstants, keywordPlanNetwork,
                callSettings);

        public virtual stt::Task<GenerateKeywordIdeaResponse> GenerateKeywordIdeasAsync(
            string customerId,
            StringValue language,
            scg::IEnumerable<string> geoTargetConstants,
            gagve::KeywordPlanNetworkEnum.Types.KeywordPlanNetwork keywordPlanNetwork,
            gaxgrpc::CallSettings callSettings = null) => GenerateKeywordIdeasAsync(
                customerId, language.Value, geoTargetConstants, keywordPlanNetwork,
                callSettings);
    }

    public abstract partial class AdGroupAdServiceClient
    {
        public virtual stt::Task<MutateAdGroupAdsResponse> MutateAdGroupAdsAsync(
            string customerId,
            scg::IEnumerable<AdGroupAdOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateAdGroupAdsAsync(customerId,
                operations, false, false, callSettings);

        public virtual MutateAdGroupAdsResponse MutateAdGroupAds(
            string customerId,
            scg::IEnumerable<AdGroupAdOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateAdGroupAds(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class AdGroupBidModifierServiceClient
    {
        public virtual stt::Task<MutateAdGroupBidModifiersResponse> MutateAdGroupBidModifiersAsync(
            string customerId,
            scg::IEnumerable<AdGroupBidModifierOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateAdGroupBidModifiersAsync(
                customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateAdGroupBidModifiersResponse> MutateAdGroupBidModifiersAsync(
            string customerId,
            scg::IEnumerable<AdGroupBidModifierOperation> operations,
            st::CancellationToken cancellationToken) => MutateAdGroupBidModifiersAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateAdGroupBidModifiersResponse MutateAdGroupBidModifiers(
            string customerId,
            scg::IEnumerable<AdGroupBidModifierOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateAdGroupBidModifiers(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class AdGroupCriterionServiceClient
    {
        public virtual stt::Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(
                string customerId,
                scg::IEnumerable<AdGroupCriterionOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateAdGroupCriteriaAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(
            string customerId,
            scg::IEnumerable<AdGroupCriterionOperation> operations,
            st::CancellationToken cancellationToken) => MutateAdGroupCriteriaAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateAdGroupCriteriaResponse MutateAdGroupCriteria(
            string customerId,
            scg::IEnumerable<AdGroupCriterionOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateAdGroupCriteria(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class AdGroupFeedServiceClient
    {
        public virtual stt::Task<MutateAdGroupFeedsResponse> MutateAdGroupFeedsAsync(
            string customerId,
            scg::IEnumerable<AdGroupFeedOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateAdGroupFeedsAsync(
                customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateAdGroupFeedsResponse> MutateAdGroupFeedsAsync(
            string customerId,
            scg::IEnumerable<AdGroupFeedOperation> operations,
            st::CancellationToken cancellationToken) => MutateAdGroupFeedsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateAdGroupFeedsResponse MutateAdGroupFeeds(
            string customerId,
            scg::IEnumerable<AdGroupFeedOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateAdGroupFeeds(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class AdGroupServiceClient
    {
        public virtual stt::Task<MutateAdGroupsResponse> MutateAdGroupsAsync(
                string customerId,
                scg::IEnumerable<AdGroupOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateAdGroupsAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateAdGroupsResponse> MutateAdGroupsAsync(
            string customerId,
            scg::IEnumerable<AdGroupOperation> operations,
            st::CancellationToken cancellationToken) => MutateAdGroupsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateAdGroupsResponse MutateAdGroups(
            string customerId,
            scg::IEnumerable<AdGroupOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateAdGroups(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class AdParameterServiceClient
    {
        public virtual stt::Task<MutateAdParametersResponse> MutateAdParametersAsync(
                string customerId,
                scg::IEnumerable<AdParameterOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateAdParametersAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateAdParametersResponse> MutateAdParametersAsync(
            string customerId,
            scg::IEnumerable<AdParameterOperation> operations,
            st::CancellationToken cancellationToken) => MutateAdParametersAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateAdParametersResponse MutateAdParameters(
            string customerId,
            scg::IEnumerable<AdParameterOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateAdParameters(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class BiddingStrategyServiceClient
    {
        public virtual stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(
                string customerId,
                scg::IEnumerable<BiddingStrategyOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateBiddingStrategiesAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(
            string customerId,
            scg::IEnumerable<BiddingStrategyOperation> operations,
            st::CancellationToken cancellationToken) => MutateBiddingStrategiesAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateBiddingStrategiesResponse MutateBiddingStrategies(
            string customerId,
            scg::IEnumerable<BiddingStrategyOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateBiddingStrategies(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class CampaignBidModifierServiceClient
    {
        public virtual stt::Task<MutateCampaignBidModifiersResponse> MutateCampaignBidModifiersAsync(
                string customerId,
                scg::IEnumerable<CampaignBidModifierOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateCampaignBidModifiersAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateCampaignBidModifiersResponse> MutateCampaignBidModifiersAsync(
            string customerId,
            scg::IEnumerable<CampaignBidModifierOperation> operations,
            st::CancellationToken cancellationToken) => MutateCampaignBidModifiersAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateCampaignBidModifiersResponse MutateCampaignBidModifiers(
            string customerId,
            scg::IEnumerable<CampaignBidModifierOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignBidModifiers(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class CampaignBudgetServiceClient
    {
        public virtual stt::Task<MutateCampaignBudgetsResponse> MutateCampaignBudgetsAsync(
                string customerId,
                scg::IEnumerable<CampaignBudgetOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateCampaignBudgetsAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateCampaignBudgetsResponse> MutateCampaignBudgetsAsync(
            string customerId,
            scg::IEnumerable<CampaignBudgetOperation> operations,
            st::CancellationToken cancellationToken) => MutateCampaignBudgetsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateCampaignBudgetsResponse MutateCampaignBudgets(
            string customerId,
            scg::IEnumerable<CampaignBudgetOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignBudgets(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class CampaignCriterionServiceClient
    {
        public virtual stt::Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(
                string customerId,
                scg::IEnumerable<CampaignCriterionOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateCampaignCriteriaAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(
            string customerId,
            scg::IEnumerable<CampaignCriterionOperation> operations,
            st::CancellationToken cancellationToken) => MutateCampaignCriteriaAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateCampaignCriteriaResponse MutateCampaignCriteria(
            string customerId,
            scg::IEnumerable<CampaignCriterionOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignCriteria(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class CampaignFeedServiceClient
    {
        public virtual stt::Task<MutateCampaignFeedsResponse> MutateCampaignFeedsAsync(
                string customerId,
                scg::IEnumerable<CampaignFeedOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateCampaignFeedsAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateCampaignFeedsResponse> MutateCampaignFeedsAsync(
            string customerId,
            scg::IEnumerable<CampaignFeedOperation> operations,
            st::CancellationToken cancellationToken) => MutateCampaignFeedsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateCampaignFeedsResponse MutateCampaignFeeds(
            string customerId,
            scg::IEnumerable<CampaignFeedOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignFeeds(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class CampaignServiceClient
    {
        public virtual stt::Task<MutateCampaignsResponse> MutateCampaignsAsync(
                string customerId,
                scg::IEnumerable<CampaignOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateCampaignsAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateCampaignsResponse> MutateCampaignsAsync(
            string customerId,
            scg::IEnumerable<CampaignOperation> operations,
            st::CancellationToken cancellationToken) => MutateCampaignsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateCampaignsResponse MutateCampaigns(
            string customerId,
            scg::IEnumerable<CampaignOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaigns(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class CampaignSharedSetServiceClient
    {
        public virtual stt::Task<MutateCampaignSharedSetsResponse> MutateCampaignSharedSetsAsync(
                string customerId,
                scg::IEnumerable<CampaignSharedSetOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateCampaignSharedSetsAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateCampaignSharedSetsResponse> MutateCampaignSharedSetsAsync(
            string customerId,
            scg::IEnumerable<CampaignSharedSetOperation> operations,
            st::CancellationToken cancellationToken) => MutateCampaignSharedSetsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateCampaignSharedSetsResponse MutateCampaignSharedSets(
            string customerId,
            scg::IEnumerable<CampaignSharedSetOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignSharedSets(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class ConversionActionServiceClient
    {
        public virtual stt::Task<MutateConversionActionsResponse> MutateConversionActionsAsync(
                string customerId,
                scg::IEnumerable<ConversionActionOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateConversionActionsAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateConversionActionsResponse> MutateConversionActionsAsync(
            string customerId,
            scg::IEnumerable<ConversionActionOperation> operations,
            st::CancellationToken cancellationToken) => MutateConversionActionsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateConversionActionsResponse MutateConversionActions(
            string customerId,
            scg::IEnumerable<ConversionActionOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateConversionActions(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class CustomerFeedServiceClient
    {
        public virtual stt::Task<MutateCustomerFeedsResponse> MutateCustomerFeedsAsync(
                string customerId,
                scg::IEnumerable<CustomerFeedOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateCustomerFeedsAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateCustomerFeedsResponse> MutateCustomerFeedsAsync(
            string customerId,
            scg::IEnumerable<CustomerFeedOperation> operations,
            st::CancellationToken cancellationToken) => MutateCustomerFeedsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateCustomerFeedsResponse MutateCustomerFeeds(
            string customerId,
            scg::IEnumerable<CustomerFeedOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCustomerFeeds(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class CustomerServiceClient
    {
        public virtual stt::Task<MutateCustomerResponse> MutateCustomerAsync(
            string customerId,
            CustomerOperation operation,
            gaxgrpc::CallSettings callSettings = null) => MutateCustomerAsync(
                    customerId, operation, false, callSettings);

        public virtual stt::Task<MutateCustomerResponse> MutateCustomerAsync(
             string customerId,
             CustomerOperation operation,
             st::CancellationToken cancellationToken) => MutateCustomerAsync(
                customerId, operation, false, cancellationToken);

        public virtual MutateCustomerResponse MutateCustomer(
            string customerId,
            CustomerOperation operation,
            gaxgrpc::CallSettings callSettings = null) => MutateCustomer(
                customerId, operation, false, callSettings);
    }

    public abstract partial class GoogleAdsServiceClient
    {
        public virtual gax::PagedAsyncEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> SearchAsync(
            string customerId,
            string query,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => SearchAsync(
                customerId, query, false, pageToken, pageSize, callSettings);

        public virtual gax::PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> Search(
                string customerId,
                string query,
                string pageToken = null,
                int? pageSize = null,
                gaxgrpc::CallSettings callSettings = null) => Search(
                customerId, query, false, pageToken, pageSize, callSettings);

        public virtual MutateGoogleAdsResponse Mutate(
            string customerId,
            scg::IEnumerable<MutateOperation> mutateOperations,
            gaxgrpc::CallSettings callSettings = null) => Mutate(
                customerId, mutateOperations, false, false, callSettings);

        public virtual stt::Task<MutateGoogleAdsResponse> MutateAsync(
            string customerId,
            scg::IEnumerable<MutateOperation> mutateOperations,
            gaxgrpc::CallSettings callSettings = null) => MutateAsync(
                customerId, mutateOperations, false, false, callSettings);

        public virtual stt::Task<MutateGoogleAdsResponse> MutateAsync(
            string customerId,
            scg::IEnumerable<MutateOperation> mutateOperations,
            st::CancellationToken cancellationToken) => MutateAsync(
                customerId,
                mutateOperations,
                false,
                false,
                cancellationToken);
    }

    public abstract partial class RecommendationServiceClient
    {
        public virtual ApplyRecommendationResponse ApplyRecommendation(
            string customerId,
            scg::IEnumerable<ApplyRecommendationOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => ApplyRecommendation(
                customerId, operations, false, callSettings);

        public virtual stt::Task<ApplyRecommendationResponse> ApplyRecommendationAsync(
            string customerId,
            scg::IEnumerable<ApplyRecommendationOperation> operations,
            st::CancellationToken cancellationToken) => ApplyRecommendationAsync(
                customerId, operations, false, cancellationToken);

        public virtual stt::Task<DismissRecommendationResponse> DismissRecommendationAsync(
            string customerId,
            scg::IEnumerable<DismissRecommendationRequest.Types.DismissRecommendationOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => DismissRecommendationAsync(
                customerId, false, operations, callSettings);

        public virtual stt::Task<DismissRecommendationResponse> DismissRecommendationAsync(
            string customerId,
            scg::IEnumerable<DismissRecommendationRequest.Types.DismissRecommendationOperation> operations,
            st::CancellationToken cancellationToken) => DismissRecommendationAsync(
                customerId,
                false,
                operations,
                cancellationToken);

        public virtual DismissRecommendationResponse DismissRecommendation(
            string customerId,
            scg::IEnumerable<DismissRecommendationRequest.Types.DismissRecommendationOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => DismissRecommendation(
                customerId, false, operations, callSettings);
    }

    public abstract partial class FeedItemServiceClient
    {
        public virtual stt::Task<MutateFeedItemsResponse> MutateFeedItemsAsync(
                string customerId,
                scg::IEnumerable<FeedItemOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateFeedItemsAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateFeedItemsResponse> MutateFeedItemsAsync(
            string customerId,
            scg::IEnumerable<FeedItemOperation> operations,
            st::CancellationToken cancellationToken) => MutateFeedItemsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateFeedItemsResponse MutateFeedItems(
            string customerId,
            scg::IEnumerable<FeedItemOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateFeedItems(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class FeedMappingServiceClient
    {
        public virtual stt::Task<MutateFeedMappingsResponse> MutateFeedMappingsAsync(
                string customerId,
                scg::IEnumerable<FeedMappingOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateFeedMappingsAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateFeedMappingsResponse> MutateFeedMappingsAsync(
            string customerId,
            scg::IEnumerable<FeedMappingOperation> operations,
            st::CancellationToken cancellationToken) => MutateFeedMappingsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateFeedMappingsResponse MutateFeedMappings(
            string customerId,
            scg::IEnumerable<FeedMappingOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateFeedMappings(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class FeedServiceClient
    {
        public virtual stt::Task<MutateFeedsResponse> MutateFeedsAsync(
                string customerId,
                scg::IEnumerable<FeedOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateFeedsAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateFeedsResponse> MutateFeedsAsync(
            string customerId,
            scg::IEnumerable<FeedOperation> operations,
            st::CancellationToken cancellationToken) => MutateFeedsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateFeedsResponse MutateFeeds(
            string customerId,
            scg::IEnumerable<FeedOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateFeeds(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class KeywordPlanAdGroupServiceClient
    {
        public virtual stt::Task<MutateKeywordPlanAdGroupsResponse> MutateKeywordPlanAdGroupsAsync(
                string customerId,
                scg::IEnumerable<KeywordPlanAdGroupOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlanAdGroupsAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateKeywordPlanAdGroupsResponse> MutateKeywordPlanAdGroupsAsync(
            string customerId,
            scg::IEnumerable<KeywordPlanAdGroupOperation> operations,
            st::CancellationToken cancellationToken) => MutateKeywordPlanAdGroupsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateKeywordPlanAdGroupsResponse MutateKeywordPlanAdGroups(
            string customerId,
            scg::IEnumerable<KeywordPlanAdGroupOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlanAdGroups(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class KeywordPlanCampaignServiceClient
    {
        public virtual stt::Task<MutateKeywordPlanCampaignsResponse> MutateKeywordPlanCampaignsAsync(
                string customerId,
                scg::IEnumerable<KeywordPlanCampaignOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlanCampaignsAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateKeywordPlanCampaignsResponse> MutateKeywordPlanCampaignsAsync(
            string customerId,
            scg::IEnumerable<KeywordPlanCampaignOperation> operations,
            st::CancellationToken cancellationToken) => MutateKeywordPlanCampaignsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateKeywordPlanCampaignsResponse MutateKeywordPlanCampaigns(
            string customerId,
            scg::IEnumerable<KeywordPlanCampaignOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlanCampaigns(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class KeywordPlanKeywordServiceClient
    {
        public virtual stt::Task<MutateKeywordPlanKeywordsResponse> MutateKeywordPlanKeywordsAsync(
                string customerId,
                scg::IEnumerable<KeywordPlanKeywordOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlanKeywordsAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateKeywordPlanKeywordsResponse> MutateKeywordPlanKeywordsAsync(
            string customerId,
            scg::IEnumerable<KeywordPlanKeywordOperation> operations,
            st::CancellationToken cancellationToken) => MutateKeywordPlanKeywordsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateKeywordPlanKeywordsResponse MutateKeywordPlanKeywords(
            string customerId,
            scg::IEnumerable<KeywordPlanKeywordOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlanKeywords(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class KeywordPlanNegativeKeywordServiceClient
    {
        public virtual stt::Task<MutateKeywordPlanNegativeKeywordsResponse> MutateKeywordPlanNegativeKeywordsAsync(
                string customerId,
                scg::IEnumerable<KeywordPlanNegativeKeywordOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlanNegativeKeywordsAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateKeywordPlanNegativeKeywordsResponse> MutateKeywordPlanNegativeKeywordsAsync(
            string customerId,
            scg::IEnumerable<KeywordPlanNegativeKeywordOperation> operations,
            st::CancellationToken cancellationToken) => MutateKeywordPlanNegativeKeywordsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateKeywordPlanNegativeKeywordsResponse MutateKeywordPlanNegativeKeywords(
            string customerId,
            scg::IEnumerable<KeywordPlanNegativeKeywordOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlanNegativeKeywords(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class KeywordPlanServiceClient
    {
        public virtual stt::Task<MutateKeywordPlansResponse> MutateKeywordPlansAsync(
                string customerId,
                scg::IEnumerable<KeywordPlanOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlansAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateKeywordPlansResponse> MutateKeywordPlansAsync(
            string customerId,
            scg::IEnumerable<KeywordPlanOperation> operations,
            st::CancellationToken cancellationToken) => MutateKeywordPlansAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateKeywordPlansResponse MutateKeywordPlans(
            string customerId,
            scg::IEnumerable<KeywordPlanOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlans(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class MediaFileServiceClient
    {
        public virtual stt::Task<MutateMediaFilesResponse> MutateMediaFilesAsync(
                string customerId,
                scg::IEnumerable<MediaFileOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateMediaFilesAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateMediaFilesResponse> MutateMediaFilesAsync(
            string customerId,
            scg::IEnumerable<MediaFileOperation> operations,
            st::CancellationToken cancellationToken) => MutateMediaFilesAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateMediaFilesResponse MutateMediaFiles(
            string customerId,
            scg::IEnumerable<MediaFileOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateMediaFiles(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class RemarketingActionServiceClient
    {
        public virtual stt::Task<MutateRemarketingActionsResponse> MutateRemarketingActionsAsync(
                string customerId,
                scg::IEnumerable<RemarketingActionOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateRemarketingActionsAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateRemarketingActionsResponse> MutateRemarketingActionsAsync(
            string customerId,
            scg::IEnumerable<RemarketingActionOperation> operations,
            st::CancellationToken cancellationToken) => MutateRemarketingActionsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateRemarketingActionsResponse MutateRemarketingActions(
            string customerId,
            scg::IEnumerable<RemarketingActionOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateRemarketingActions(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class SharedCriterionServiceClient
    {
        public virtual stt::Task<MutateSharedCriteriaResponse> MutateSharedCriteriaAsync(
                string customerId,
                scg::IEnumerable<SharedCriterionOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateSharedCriteriaAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateSharedCriteriaResponse> MutateSharedCriteriaAsync(
            string customerId,
            scg::IEnumerable<SharedCriterionOperation> operations,
            st::CancellationToken cancellationToken) => MutateSharedCriteriaAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateSharedCriteriaResponse MutateSharedCriteria(
            string customerId,
            scg::IEnumerable<SharedCriterionOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateSharedCriteria(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class SharedSetServiceClient
    {
        public virtual stt::Task<MutateSharedSetsResponse> MutateSharedSetsAsync(
                string customerId,
                scg::IEnumerable<SharedSetOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateSharedSetsAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateSharedSetsResponse> MutateSharedSetsAsync(
            string customerId,
            scg::IEnumerable<SharedSetOperation> operations,
            st::CancellationToken cancellationToken) => MutateSharedSetsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateSharedSetsResponse MutateSharedSets(
            string customerId,
            scg::IEnumerable<SharedSetOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateSharedSets(
                customerId, operations, false, false, callSettings);
    }

    public abstract partial class UserListServiceClient
    {
        public virtual stt::Task<MutateUserListsResponse> MutateUserListsAsync(
                string customerId,
                scg::IEnumerable<UserListOperation> operations,
                gaxgrpc::CallSettings callSettings = null) => MutateUserListsAsync(
                    customerId, operations, false, false, callSettings);

        public virtual stt::Task<MutateUserListsResponse> MutateUserListsAsync(
            string customerId,
            scg::IEnumerable<UserListOperation> operations,
            st::CancellationToken cancellationToken) => MutateUserListsAsync(
                customerId, operations, false, false, cancellationToken);

        public virtual MutateUserListsResponse MutateUserLists(
            string customerId,
            scg::IEnumerable<UserListOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateUserLists(
                customerId, operations, false, false, callSettings);
    }
}

#pragma warning restore CS1591

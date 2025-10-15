// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Ads.GoogleAds.V22.Services
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Ads.GoogleAds.V22.Services", GetFileDescriptors)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.CancelOperation",
                    // { "post": "/v22/{name=customers/*/operations/*}:cancel", "body": "*" }
                    proto::ByteString.FromBase64("IisvdjIyL3tuYW1lPWN1c3RvbWVycy8qL29wZXJhdGlvbnMvKn06Y2FuY2VsOgEq")
                },
                {
                    "google.longrunning.Operations.DeleteOperation",
                    // { "delete": "/v22/{name=customers/*/operations/*}" }
                    proto::ByteString.FromBase64("KiQvdjIyL3tuYW1lPWN1c3RvbWVycy8qL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v22/{name=customers/*/operations/*}" }
                    proto::ByteString.FromBase64("EiQvdjIyL3tuYW1lPWN1c3RvbWVycy8qL29wZXJhdGlvbnMvKn0=")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v22/{name=customers/*/operations}" }
                    proto::ByteString.FromBase64("EiIvdjIyL3tuYW1lPWN1c3RvbWVycy8qL29wZXJhdGlvbnN9")
                },
                {
                    "google.longrunning.Operations.WaitOperation",
                    // { "post": "/v22/{name=customers/*/operations/*}:wait", "body": "*" }
                    proto::ByteString.FromBase64("IikvdjIyL3tuYW1lPWN1c3RvbWVycy8qL29wZXJhdGlvbnMvKn06d2FpdDoBKg==")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AccountBudgetProposalServiceReflection.Descriptor;
            yield return AccountLinkServiceReflection.Descriptor;
            yield return AdGroupAdLabelServiceReflection.Descriptor;
            yield return AdGroupAdServiceReflection.Descriptor;
            yield return AdGroupAssetServiceReflection.Descriptor;
            yield return AdGroupAssetSetServiceReflection.Descriptor;
            yield return AdGroupBidModifierServiceReflection.Descriptor;
            yield return AdGroupCriterionCustomizerServiceReflection.Descriptor;
            yield return AdGroupCriterionLabelServiceReflection.Descriptor;
            yield return AdGroupCriterionServiceReflection.Descriptor;
            yield return AdGroupCustomizerServiceReflection.Descriptor;
            yield return AdGroupLabelServiceReflection.Descriptor;
            yield return AdGroupServiceReflection.Descriptor;
            yield return AdParameterServiceReflection.Descriptor;
            yield return AdServiceReflection.Descriptor;
            yield return AssetGenerationServiceReflection.Descriptor;
            yield return AssetGroupAssetServiceReflection.Descriptor;
            yield return AssetGroupListingGroupFilterServiceReflection.Descriptor;
            yield return AssetGroupServiceReflection.Descriptor;
            yield return AssetGroupSignalServiceReflection.Descriptor;
            yield return AssetServiceReflection.Descriptor;
            yield return AssetSetAssetServiceReflection.Descriptor;
            yield return AssetSetServiceReflection.Descriptor;
            yield return AudienceInsightsServiceReflection.Descriptor;
            yield return AudienceServiceReflection.Descriptor;
            yield return AutomaticallyCreatedAssetRemovalServiceReflection.Descriptor;
            yield return BatchJobServiceReflection.Descriptor;
            yield return BiddingDataExclusionServiceReflection.Descriptor;
            yield return BiddingSeasonalityAdjustmentServiceReflection.Descriptor;
            yield return BiddingStrategyServiceReflection.Descriptor;
            yield return BillingSetupServiceReflection.Descriptor;
            yield return BrandSuggestionServiceReflection.Descriptor;
            yield return CampaignAssetServiceReflection.Descriptor;
            yield return CampaignAssetSetServiceReflection.Descriptor;
            yield return CampaignBidModifierServiceReflection.Descriptor;
            yield return CampaignBudgetServiceReflection.Descriptor;
            yield return CampaignConversionGoalServiceReflection.Descriptor;
            yield return CampaignCriterionServiceReflection.Descriptor;
            yield return CampaignCustomizerServiceReflection.Descriptor;
            yield return CampaignDraftServiceReflection.Descriptor;
            yield return CampaignGoalConfigServiceReflection.Descriptor;
            yield return CampaignGroupServiceReflection.Descriptor;
            yield return CampaignLabelServiceReflection.Descriptor;
            yield return CampaignLifecycleGoalServiceReflection.Descriptor;
            yield return CampaignServiceReflection.Descriptor;
            yield return CampaignSharedSetServiceReflection.Descriptor;
            yield return ContentCreatorInsightsServiceReflection.Descriptor;
            yield return ConversionActionServiceReflection.Descriptor;
            yield return ConversionAdjustmentUploadServiceReflection.Descriptor;
            yield return ConversionCustomVariableServiceReflection.Descriptor;
            yield return ConversionGoalCampaignConfigServiceReflection.Descriptor;
            yield return ConversionUploadServiceReflection.Descriptor;
            yield return ConversionValueRuleServiceReflection.Descriptor;
            yield return ConversionValueRuleSetServiceReflection.Descriptor;
            yield return CustomAudienceServiceReflection.Descriptor;
            yield return CustomConversionGoalServiceReflection.Descriptor;
            yield return CustomInterestServiceReflection.Descriptor;
            yield return CustomerAssetServiceReflection.Descriptor;
            yield return CustomerAssetSetServiceReflection.Descriptor;
            yield return CustomerClientLinkServiceReflection.Descriptor;
            yield return CustomerConversionGoalServiceReflection.Descriptor;
            yield return CustomerCustomizerServiceReflection.Descriptor;
            yield return CustomerLabelServiceReflection.Descriptor;
            yield return CustomerLifecycleGoalServiceReflection.Descriptor;
            yield return CustomerManagerLinkServiceReflection.Descriptor;
            yield return CustomerNegativeCriterionServiceReflection.Descriptor;
            yield return CustomerServiceReflection.Descriptor;
            yield return CustomerSkAdNetworkConversionValueSchemaServiceReflection.Descriptor;
            yield return CustomerUserAccessInvitationServiceReflection.Descriptor;
            yield return CustomerUserAccessServiceReflection.Descriptor;
            yield return CustomizerAttributeServiceReflection.Descriptor;
            yield return DataLinkServiceReflection.Descriptor;
            yield return ExperimentArmServiceReflection.Descriptor;
            yield return ExperimentServiceReflection.Descriptor;
            yield return GeoTargetConstantServiceReflection.Descriptor;
            yield return GoalServiceReflection.Descriptor;
            yield return GoogleAdsFieldServiceReflection.Descriptor;
            yield return GoogleAdsServiceReflection.Descriptor;
            yield return IdentityVerificationServiceReflection.Descriptor;
            yield return InvoiceServiceReflection.Descriptor;
            yield return KeywordPlanAdGroupKeywordServiceReflection.Descriptor;
            yield return KeywordPlanAdGroupServiceReflection.Descriptor;
            yield return KeywordPlanCampaignKeywordServiceReflection.Descriptor;
            yield return KeywordPlanCampaignServiceReflection.Descriptor;
            yield return KeywordPlanIdeaServiceReflection.Descriptor;
            yield return KeywordPlanServiceReflection.Descriptor;
            yield return KeywordThemeConstantServiceReflection.Descriptor;
            yield return LabelServiceReflection.Descriptor;
            yield return LocalServicesLeadServiceReflection.Descriptor;
            yield return OfflineUserDataJobServiceReflection.Descriptor;
            yield return PaymentsAccountServiceReflection.Descriptor;
            yield return ProductLinkInvitationServiceReflection.Descriptor;
            yield return ProductLinkServiceReflection.Descriptor;
            yield return ReachPlanServiceReflection.Descriptor;
            yield return RecommendationServiceReflection.Descriptor;
            yield return RecommendationSubscriptionServiceReflection.Descriptor;
            yield return RemarketingActionServiceReflection.Descriptor;
            yield return ShareablePreviewServiceReflection.Descriptor;
            yield return SharedCriterionServiceReflection.Descriptor;
            yield return SharedSetServiceReflection.Descriptor;
            yield return SmartCampaignSettingServiceReflection.Descriptor;
            yield return SmartCampaignSuggestServiceReflection.Descriptor;
            yield return ThirdPartyAppAnalyticsLinkServiceReflection.Descriptor;
            yield return TravelAssetSuggestionServiceReflection.Descriptor;
            yield return UserDataServiceReflection.Descriptor;
            yield return UserListCustomerTypeServiceReflection.Descriptor;
            yield return UserListServiceReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}

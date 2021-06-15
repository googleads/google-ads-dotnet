// Copyright 2021 Google LLC
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

using gagve = Google.Ads.GoogleAds.V8.Enums;
using gagvr = Google.Ads.GoogleAds.V8.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V8.Services;

namespace Google.Ads.GoogleAds.Tests.V8.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRecommendationServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetRecommendationRequestObject()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            GetRecommendationRequest request = new GetRecommendationRequest
            {
                ResourceNameAsRecommendationName = gagvr::RecommendationName.FromCustomerRecommendation("[CUSTOMER_ID]", "[RECOMMENDATION_ID]"),
            };
            gagvr::Recommendation expectedResponse = new gagvr::Recommendation
            {
                ResourceNameAsRecommendationName = gagvr::RecommendationName.FromCustomerRecommendation("[CUSTOMER_ID]", "[RECOMMENDATION_ID]"),
                Type = gagve::RecommendationTypeEnum.Types.RecommendationType.MoveUnusedBudget,
                Impact = new gagvr::Recommendation.Types.RecommendationImpact(),
                CampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
                KeywordRecommendation = new gagvr::Recommendation.Types.KeywordRecommendation(),
                TextAdRecommendation = new gagvr::Recommendation.Types.TextAdRecommendation(),
                TargetCpaOptInRecommendation = new gagvr::Recommendation.Types.TargetCpaOptInRecommendation(),
                MaximizeConversionsOptInRecommendation = new gagvr::Recommendation.Types.MaximizeConversionsOptInRecommendation(),
                EnhancedCpcOptInRecommendation = new gagvr::Recommendation.Types.EnhancedCpcOptInRecommendation(),
                SearchPartnersOptInRecommendation = new gagvr::Recommendation.Types.SearchPartnersOptInRecommendation(),
                MaximizeClicksOptInRecommendation = new gagvr::Recommendation.Types.MaximizeClicksOptInRecommendation(),
                OptimizeAdRotationRecommendation = new gagvr::Recommendation.Types.OptimizeAdRotationRecommendation(),
                CalloutExtensionRecommendation = new gagvr::Recommendation.Types.CalloutExtensionRecommendation(),
                SitelinkExtensionRecommendation = new gagvr::Recommendation.Types.SitelinkExtensionRecommendation(),
                CallExtensionRecommendation = new gagvr::Recommendation.Types.CallExtensionRecommendation(),
                KeywordMatchTypeRecommendation = new gagvr::Recommendation.Types.KeywordMatchTypeRecommendation(),
                MoveUnusedBudgetRecommendation = new gagvr::Recommendation.Types.MoveUnusedBudgetRecommendation(),
                ForecastingCampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
                TargetRoasOptInRecommendation = new gagvr::Recommendation.Types.TargetRoasOptInRecommendation(),
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Dismissed = true,
                ResponsiveSearchAdRecommendation = new gagvr::Recommendation.Types.ResponsiveSearchAdRecommendation(),
                MarginalRoiCampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
            };
            mockGrpcClient.Setup(x => x.GetRecommendation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Recommendation response = client.GetRecommendation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetRecommendationRequestObjectAsync()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            GetRecommendationRequest request = new GetRecommendationRequest
            {
                ResourceNameAsRecommendationName = gagvr::RecommendationName.FromCustomerRecommendation("[CUSTOMER_ID]", "[RECOMMENDATION_ID]"),
            };
            gagvr::Recommendation expectedResponse = new gagvr::Recommendation
            {
                ResourceNameAsRecommendationName = gagvr::RecommendationName.FromCustomerRecommendation("[CUSTOMER_ID]", "[RECOMMENDATION_ID]"),
                Type = gagve::RecommendationTypeEnum.Types.RecommendationType.MoveUnusedBudget,
                Impact = new gagvr::Recommendation.Types.RecommendationImpact(),
                CampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
                KeywordRecommendation = new gagvr::Recommendation.Types.KeywordRecommendation(),
                TextAdRecommendation = new gagvr::Recommendation.Types.TextAdRecommendation(),
                TargetCpaOptInRecommendation = new gagvr::Recommendation.Types.TargetCpaOptInRecommendation(),
                MaximizeConversionsOptInRecommendation = new gagvr::Recommendation.Types.MaximizeConversionsOptInRecommendation(),
                EnhancedCpcOptInRecommendation = new gagvr::Recommendation.Types.EnhancedCpcOptInRecommendation(),
                SearchPartnersOptInRecommendation = new gagvr::Recommendation.Types.SearchPartnersOptInRecommendation(),
                MaximizeClicksOptInRecommendation = new gagvr::Recommendation.Types.MaximizeClicksOptInRecommendation(),
                OptimizeAdRotationRecommendation = new gagvr::Recommendation.Types.OptimizeAdRotationRecommendation(),
                CalloutExtensionRecommendation = new gagvr::Recommendation.Types.CalloutExtensionRecommendation(),
                SitelinkExtensionRecommendation = new gagvr::Recommendation.Types.SitelinkExtensionRecommendation(),
                CallExtensionRecommendation = new gagvr::Recommendation.Types.CallExtensionRecommendation(),
                KeywordMatchTypeRecommendation = new gagvr::Recommendation.Types.KeywordMatchTypeRecommendation(),
                MoveUnusedBudgetRecommendation = new gagvr::Recommendation.Types.MoveUnusedBudgetRecommendation(),
                ForecastingCampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
                TargetRoasOptInRecommendation = new gagvr::Recommendation.Types.TargetRoasOptInRecommendation(),
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Dismissed = true,
                ResponsiveSearchAdRecommendation = new gagvr::Recommendation.Types.ResponsiveSearchAdRecommendation(),
                MarginalRoiCampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
            };
            mockGrpcClient.Setup(x => x.GetRecommendationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Recommendation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Recommendation responseCallSettings = await client.GetRecommendationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Recommendation responseCancellationToken = await client.GetRecommendationAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetRecommendation()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            GetRecommendationRequest request = new GetRecommendationRequest
            {
                ResourceNameAsRecommendationName = gagvr::RecommendationName.FromCustomerRecommendation("[CUSTOMER_ID]", "[RECOMMENDATION_ID]"),
            };
            gagvr::Recommendation expectedResponse = new gagvr::Recommendation
            {
                ResourceNameAsRecommendationName = gagvr::RecommendationName.FromCustomerRecommendation("[CUSTOMER_ID]", "[RECOMMENDATION_ID]"),
                Type = gagve::RecommendationTypeEnum.Types.RecommendationType.MoveUnusedBudget,
                Impact = new gagvr::Recommendation.Types.RecommendationImpact(),
                CampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
                KeywordRecommendation = new gagvr::Recommendation.Types.KeywordRecommendation(),
                TextAdRecommendation = new gagvr::Recommendation.Types.TextAdRecommendation(),
                TargetCpaOptInRecommendation = new gagvr::Recommendation.Types.TargetCpaOptInRecommendation(),
                MaximizeConversionsOptInRecommendation = new gagvr::Recommendation.Types.MaximizeConversionsOptInRecommendation(),
                EnhancedCpcOptInRecommendation = new gagvr::Recommendation.Types.EnhancedCpcOptInRecommendation(),
                SearchPartnersOptInRecommendation = new gagvr::Recommendation.Types.SearchPartnersOptInRecommendation(),
                MaximizeClicksOptInRecommendation = new gagvr::Recommendation.Types.MaximizeClicksOptInRecommendation(),
                OptimizeAdRotationRecommendation = new gagvr::Recommendation.Types.OptimizeAdRotationRecommendation(),
                CalloutExtensionRecommendation = new gagvr::Recommendation.Types.CalloutExtensionRecommendation(),
                SitelinkExtensionRecommendation = new gagvr::Recommendation.Types.SitelinkExtensionRecommendation(),
                CallExtensionRecommendation = new gagvr::Recommendation.Types.CallExtensionRecommendation(),
                KeywordMatchTypeRecommendation = new gagvr::Recommendation.Types.KeywordMatchTypeRecommendation(),
                MoveUnusedBudgetRecommendation = new gagvr::Recommendation.Types.MoveUnusedBudgetRecommendation(),
                ForecastingCampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
                TargetRoasOptInRecommendation = new gagvr::Recommendation.Types.TargetRoasOptInRecommendation(),
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Dismissed = true,
                ResponsiveSearchAdRecommendation = new gagvr::Recommendation.Types.ResponsiveSearchAdRecommendation(),
                MarginalRoiCampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
            };
            mockGrpcClient.Setup(x => x.GetRecommendation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Recommendation response = client.GetRecommendation(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetRecommendationAsync()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            GetRecommendationRequest request = new GetRecommendationRequest
            {
                ResourceNameAsRecommendationName = gagvr::RecommendationName.FromCustomerRecommendation("[CUSTOMER_ID]", "[RECOMMENDATION_ID]"),
            };
            gagvr::Recommendation expectedResponse = new gagvr::Recommendation
            {
                ResourceNameAsRecommendationName = gagvr::RecommendationName.FromCustomerRecommendation("[CUSTOMER_ID]", "[RECOMMENDATION_ID]"),
                Type = gagve::RecommendationTypeEnum.Types.RecommendationType.MoveUnusedBudget,
                Impact = new gagvr::Recommendation.Types.RecommendationImpact(),
                CampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
                KeywordRecommendation = new gagvr::Recommendation.Types.KeywordRecommendation(),
                TextAdRecommendation = new gagvr::Recommendation.Types.TextAdRecommendation(),
                TargetCpaOptInRecommendation = new gagvr::Recommendation.Types.TargetCpaOptInRecommendation(),
                MaximizeConversionsOptInRecommendation = new gagvr::Recommendation.Types.MaximizeConversionsOptInRecommendation(),
                EnhancedCpcOptInRecommendation = new gagvr::Recommendation.Types.EnhancedCpcOptInRecommendation(),
                SearchPartnersOptInRecommendation = new gagvr::Recommendation.Types.SearchPartnersOptInRecommendation(),
                MaximizeClicksOptInRecommendation = new gagvr::Recommendation.Types.MaximizeClicksOptInRecommendation(),
                OptimizeAdRotationRecommendation = new gagvr::Recommendation.Types.OptimizeAdRotationRecommendation(),
                CalloutExtensionRecommendation = new gagvr::Recommendation.Types.CalloutExtensionRecommendation(),
                SitelinkExtensionRecommendation = new gagvr::Recommendation.Types.SitelinkExtensionRecommendation(),
                CallExtensionRecommendation = new gagvr::Recommendation.Types.CallExtensionRecommendation(),
                KeywordMatchTypeRecommendation = new gagvr::Recommendation.Types.KeywordMatchTypeRecommendation(),
                MoveUnusedBudgetRecommendation = new gagvr::Recommendation.Types.MoveUnusedBudgetRecommendation(),
                ForecastingCampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
                TargetRoasOptInRecommendation = new gagvr::Recommendation.Types.TargetRoasOptInRecommendation(),
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Dismissed = true,
                ResponsiveSearchAdRecommendation = new gagvr::Recommendation.Types.ResponsiveSearchAdRecommendation(),
                MarginalRoiCampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
            };
            mockGrpcClient.Setup(x => x.GetRecommendationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Recommendation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Recommendation responseCallSettings = await client.GetRecommendationAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Recommendation responseCancellationToken = await client.GetRecommendationAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetRecommendationResourceNames()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            GetRecommendationRequest request = new GetRecommendationRequest
            {
                ResourceNameAsRecommendationName = gagvr::RecommendationName.FromCustomerRecommendation("[CUSTOMER_ID]", "[RECOMMENDATION_ID]"),
            };
            gagvr::Recommendation expectedResponse = new gagvr::Recommendation
            {
                ResourceNameAsRecommendationName = gagvr::RecommendationName.FromCustomerRecommendation("[CUSTOMER_ID]", "[RECOMMENDATION_ID]"),
                Type = gagve::RecommendationTypeEnum.Types.RecommendationType.MoveUnusedBudget,
                Impact = new gagvr::Recommendation.Types.RecommendationImpact(),
                CampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
                KeywordRecommendation = new gagvr::Recommendation.Types.KeywordRecommendation(),
                TextAdRecommendation = new gagvr::Recommendation.Types.TextAdRecommendation(),
                TargetCpaOptInRecommendation = new gagvr::Recommendation.Types.TargetCpaOptInRecommendation(),
                MaximizeConversionsOptInRecommendation = new gagvr::Recommendation.Types.MaximizeConversionsOptInRecommendation(),
                EnhancedCpcOptInRecommendation = new gagvr::Recommendation.Types.EnhancedCpcOptInRecommendation(),
                SearchPartnersOptInRecommendation = new gagvr::Recommendation.Types.SearchPartnersOptInRecommendation(),
                MaximizeClicksOptInRecommendation = new gagvr::Recommendation.Types.MaximizeClicksOptInRecommendation(),
                OptimizeAdRotationRecommendation = new gagvr::Recommendation.Types.OptimizeAdRotationRecommendation(),
                CalloutExtensionRecommendation = new gagvr::Recommendation.Types.CalloutExtensionRecommendation(),
                SitelinkExtensionRecommendation = new gagvr::Recommendation.Types.SitelinkExtensionRecommendation(),
                CallExtensionRecommendation = new gagvr::Recommendation.Types.CallExtensionRecommendation(),
                KeywordMatchTypeRecommendation = new gagvr::Recommendation.Types.KeywordMatchTypeRecommendation(),
                MoveUnusedBudgetRecommendation = new gagvr::Recommendation.Types.MoveUnusedBudgetRecommendation(),
                ForecastingCampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
                TargetRoasOptInRecommendation = new gagvr::Recommendation.Types.TargetRoasOptInRecommendation(),
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Dismissed = true,
                ResponsiveSearchAdRecommendation = new gagvr::Recommendation.Types.ResponsiveSearchAdRecommendation(),
                MarginalRoiCampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
            };
            mockGrpcClient.Setup(x => x.GetRecommendation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Recommendation response = client.GetRecommendation(request.ResourceNameAsRecommendationName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetRecommendationResourceNamesAsync()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            GetRecommendationRequest request = new GetRecommendationRequest
            {
                ResourceNameAsRecommendationName = gagvr::RecommendationName.FromCustomerRecommendation("[CUSTOMER_ID]", "[RECOMMENDATION_ID]"),
            };
            gagvr::Recommendation expectedResponse = new gagvr::Recommendation
            {
                ResourceNameAsRecommendationName = gagvr::RecommendationName.FromCustomerRecommendation("[CUSTOMER_ID]", "[RECOMMENDATION_ID]"),
                Type = gagve::RecommendationTypeEnum.Types.RecommendationType.MoveUnusedBudget,
                Impact = new gagvr::Recommendation.Types.RecommendationImpact(),
                CampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
                KeywordRecommendation = new gagvr::Recommendation.Types.KeywordRecommendation(),
                TextAdRecommendation = new gagvr::Recommendation.Types.TextAdRecommendation(),
                TargetCpaOptInRecommendation = new gagvr::Recommendation.Types.TargetCpaOptInRecommendation(),
                MaximizeConversionsOptInRecommendation = new gagvr::Recommendation.Types.MaximizeConversionsOptInRecommendation(),
                EnhancedCpcOptInRecommendation = new gagvr::Recommendation.Types.EnhancedCpcOptInRecommendation(),
                SearchPartnersOptInRecommendation = new gagvr::Recommendation.Types.SearchPartnersOptInRecommendation(),
                MaximizeClicksOptInRecommendation = new gagvr::Recommendation.Types.MaximizeClicksOptInRecommendation(),
                OptimizeAdRotationRecommendation = new gagvr::Recommendation.Types.OptimizeAdRotationRecommendation(),
                CalloutExtensionRecommendation = new gagvr::Recommendation.Types.CalloutExtensionRecommendation(),
                SitelinkExtensionRecommendation = new gagvr::Recommendation.Types.SitelinkExtensionRecommendation(),
                CallExtensionRecommendation = new gagvr::Recommendation.Types.CallExtensionRecommendation(),
                KeywordMatchTypeRecommendation = new gagvr::Recommendation.Types.KeywordMatchTypeRecommendation(),
                MoveUnusedBudgetRecommendation = new gagvr::Recommendation.Types.MoveUnusedBudgetRecommendation(),
                ForecastingCampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
                TargetRoasOptInRecommendation = new gagvr::Recommendation.Types.TargetRoasOptInRecommendation(),
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Dismissed = true,
                ResponsiveSearchAdRecommendation = new gagvr::Recommendation.Types.ResponsiveSearchAdRecommendation(),
                MarginalRoiCampaignBudgetRecommendation = new gagvr::Recommendation.Types.CampaignBudgetRecommendation(),
            };
            mockGrpcClient.Setup(x => x.GetRecommendationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Recommendation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Recommendation responseCallSettings = await client.GetRecommendationAsync(request.ResourceNameAsRecommendationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Recommendation responseCancellationToken = await client.GetRecommendationAsync(request.ResourceNameAsRecommendationName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void ApplyRecommendationRequestObject()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            ApplyRecommendationRequest request = new ApplyRecommendationRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ApplyRecommendationOperation(),
                },
                PartialFailure = false,
            };
            ApplyRecommendationResponse expectedResponse = new ApplyRecommendationResponse
            {
                Results =
                {
                    new ApplyRecommendationResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.ApplyRecommendation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            ApplyRecommendationResponse response = client.ApplyRecommendation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task ApplyRecommendationRequestObjectAsync()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            ApplyRecommendationRequest request = new ApplyRecommendationRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ApplyRecommendationOperation(),
                },
                PartialFailure = false,
            };
            ApplyRecommendationResponse expectedResponse = new ApplyRecommendationResponse
            {
                Results =
                {
                    new ApplyRecommendationResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.ApplyRecommendationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApplyRecommendationResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            ApplyRecommendationResponse responseCallSettings = await client.ApplyRecommendationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            ApplyRecommendationResponse responseCancellationToken = await client.ApplyRecommendationAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void ApplyRecommendation()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            ApplyRecommendationRequest request = new ApplyRecommendationRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ApplyRecommendationOperation(),
                },
            };
            ApplyRecommendationResponse expectedResponse = new ApplyRecommendationResponse
            {
                Results =
                {
                    new ApplyRecommendationResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.ApplyRecommendation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            ApplyRecommendationResponse response = client.ApplyRecommendation(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task ApplyRecommendationAsync()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            ApplyRecommendationRequest request = new ApplyRecommendationRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ApplyRecommendationOperation(),
                },
            };
            ApplyRecommendationResponse expectedResponse = new ApplyRecommendationResponse
            {
                Results =
                {
                    new ApplyRecommendationResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.ApplyRecommendationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApplyRecommendationResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            ApplyRecommendationResponse responseCallSettings = await client.ApplyRecommendationAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            ApplyRecommendationResponse responseCancellationToken = await client.ApplyRecommendationAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void DismissRecommendationRequestObject()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            DismissRecommendationRequest request = new DismissRecommendationRequest
            {
                CustomerId = "customer_id3b3724cb",
                PartialFailure = false,
                Operations =
                {
                    new DismissRecommendationRequest.Types.DismissRecommendationOperation(),
                },
            };
            DismissRecommendationResponse expectedResponse = new DismissRecommendationResponse
            {
                Results =
                {
                    new DismissRecommendationResponse.Types.DismissRecommendationResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.DismissRecommendation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            DismissRecommendationResponse response = client.DismissRecommendation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task DismissRecommendationRequestObjectAsync()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            DismissRecommendationRequest request = new DismissRecommendationRequest
            {
                CustomerId = "customer_id3b3724cb",
                PartialFailure = false,
                Operations =
                {
                    new DismissRecommendationRequest.Types.DismissRecommendationOperation(),
                },
            };
            DismissRecommendationResponse expectedResponse = new DismissRecommendationResponse
            {
                Results =
                {
                    new DismissRecommendationResponse.Types.DismissRecommendationResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.DismissRecommendationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DismissRecommendationResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            DismissRecommendationResponse responseCallSettings = await client.DismissRecommendationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            DismissRecommendationResponse responseCancellationToken = await client.DismissRecommendationAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void DismissRecommendation()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            DismissRecommendationRequest request = new DismissRecommendationRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new DismissRecommendationRequest.Types.DismissRecommendationOperation(),
                },
            };
            DismissRecommendationResponse expectedResponse = new DismissRecommendationResponse
            {
                Results =
                {
                    new DismissRecommendationResponse.Types.DismissRecommendationResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.DismissRecommendation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            DismissRecommendationResponse response = client.DismissRecommendation(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task DismissRecommendationAsync()
        {
            moq::Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new moq::Mock<RecommendationService.RecommendationServiceClient>(moq::MockBehavior.Strict);
            DismissRecommendationRequest request = new DismissRecommendationRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new DismissRecommendationRequest.Types.DismissRecommendationOperation(),
                },
            };
            DismissRecommendationResponse expectedResponse = new DismissRecommendationResponse
            {
                Results =
                {
                    new DismissRecommendationResponse.Types.DismissRecommendationResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.DismissRecommendationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DismissRecommendationResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            DismissRecommendationResponse responseCallSettings = await client.DismissRecommendationAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            DismissRecommendationResponse responseCancellationToken = await client.DismissRecommendationAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

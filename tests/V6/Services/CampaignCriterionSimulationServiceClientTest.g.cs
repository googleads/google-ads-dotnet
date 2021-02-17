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

using gagvc = Google.Ads.GoogleAds.V6.Common;
using gagve = Google.Ads.GoogleAds.V6.Enums;
using gagvr = Google.Ads.GoogleAds.V6.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V6.Services;

namespace Google.Ads.GoogleAds.Tests.V6.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCampaignCriterionSimulationServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCampaignCriterionSimulationRequestObject()
        {
            moq::Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient> mockGrpcClient = new moq::Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient>(moq::MockBehavior.Strict);
            GetCampaignCriterionSimulationRequest request = new GetCampaignCriterionSimulationRequest
            {
                ResourceNameAsCampaignCriterionSimulationName = gagvr::CampaignCriterionSimulationName.FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::CampaignCriterionSimulation expectedResponse = new gagvr::CampaignCriterionSimulation
            {
                ResourceNameAsCampaignCriterionSimulationName = gagvr::CampaignCriterionSimulationName.FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                Type = gagve::SimulationTypeEnum.Types.SimulationType.PercentCpcBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                BidModifierPointList = new gagvc::BidModifierSimulationPointList(),
                CampaignId = -3743237468908008719L,
                CriterionId = 8584655242409302840L,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterionSimulation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignCriterionSimulationServiceClient client = new CampaignCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignCriterionSimulation response = client.GetCampaignCriterionSimulation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignCriterionSimulationRequestObjectAsync()
        {
            moq::Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient> mockGrpcClient = new moq::Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient>(moq::MockBehavior.Strict);
            GetCampaignCriterionSimulationRequest request = new GetCampaignCriterionSimulationRequest
            {
                ResourceNameAsCampaignCriterionSimulationName = gagvr::CampaignCriterionSimulationName.FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::CampaignCriterionSimulation expectedResponse = new gagvr::CampaignCriterionSimulation
            {
                ResourceNameAsCampaignCriterionSimulationName = gagvr::CampaignCriterionSimulationName.FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                Type = gagve::SimulationTypeEnum.Types.SimulationType.PercentCpcBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                BidModifierPointList = new gagvc::BidModifierSimulationPointList(),
                CampaignId = -3743237468908008719L,
                CriterionId = 8584655242409302840L,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterionSimulationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignCriterionSimulation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignCriterionSimulationServiceClient client = new CampaignCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignCriterionSimulation responseCallSettings = await client.GetCampaignCriterionSimulationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignCriterionSimulation responseCancellationToken = await client.GetCampaignCriterionSimulationAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignCriterionSimulation()
        {
            moq::Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient> mockGrpcClient = new moq::Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient>(moq::MockBehavior.Strict);
            GetCampaignCriterionSimulationRequest request = new GetCampaignCriterionSimulationRequest
            {
                ResourceNameAsCampaignCriterionSimulationName = gagvr::CampaignCriterionSimulationName.FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::CampaignCriterionSimulation expectedResponse = new gagvr::CampaignCriterionSimulation
            {
                ResourceNameAsCampaignCriterionSimulationName = gagvr::CampaignCriterionSimulationName.FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                Type = gagve::SimulationTypeEnum.Types.SimulationType.PercentCpcBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                BidModifierPointList = new gagvc::BidModifierSimulationPointList(),
                CampaignId = -3743237468908008719L,
                CriterionId = 8584655242409302840L,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterionSimulation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignCriterionSimulationServiceClient client = new CampaignCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignCriterionSimulation response = client.GetCampaignCriterionSimulation(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignCriterionSimulationAsync()
        {
            moq::Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient> mockGrpcClient = new moq::Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient>(moq::MockBehavior.Strict);
            GetCampaignCriterionSimulationRequest request = new GetCampaignCriterionSimulationRequest
            {
                ResourceNameAsCampaignCriterionSimulationName = gagvr::CampaignCriterionSimulationName.FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::CampaignCriterionSimulation expectedResponse = new gagvr::CampaignCriterionSimulation
            {
                ResourceNameAsCampaignCriterionSimulationName = gagvr::CampaignCriterionSimulationName.FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                Type = gagve::SimulationTypeEnum.Types.SimulationType.PercentCpcBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                BidModifierPointList = new gagvc::BidModifierSimulationPointList(),
                CampaignId = -3743237468908008719L,
                CriterionId = 8584655242409302840L,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterionSimulationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignCriterionSimulation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignCriterionSimulationServiceClient client = new CampaignCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignCriterionSimulation responseCallSettings = await client.GetCampaignCriterionSimulationAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignCriterionSimulation responseCancellationToken = await client.GetCampaignCriterionSimulationAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignCriterionSimulationResourceNames()
        {
            moq::Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient> mockGrpcClient = new moq::Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient>(moq::MockBehavior.Strict);
            GetCampaignCriterionSimulationRequest request = new GetCampaignCriterionSimulationRequest
            {
                ResourceNameAsCampaignCriterionSimulationName = gagvr::CampaignCriterionSimulationName.FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::CampaignCriterionSimulation expectedResponse = new gagvr::CampaignCriterionSimulation
            {
                ResourceNameAsCampaignCriterionSimulationName = gagvr::CampaignCriterionSimulationName.FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                Type = gagve::SimulationTypeEnum.Types.SimulationType.PercentCpcBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                BidModifierPointList = new gagvc::BidModifierSimulationPointList(),
                CampaignId = -3743237468908008719L,
                CriterionId = 8584655242409302840L,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterionSimulation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignCriterionSimulationServiceClient client = new CampaignCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignCriterionSimulation response = client.GetCampaignCriterionSimulation(request.ResourceNameAsCampaignCriterionSimulationName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignCriterionSimulationResourceNamesAsync()
        {
            moq::Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient> mockGrpcClient = new moq::Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient>(moq::MockBehavior.Strict);
            GetCampaignCriterionSimulationRequest request = new GetCampaignCriterionSimulationRequest
            {
                ResourceNameAsCampaignCriterionSimulationName = gagvr::CampaignCriterionSimulationName.FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::CampaignCriterionSimulation expectedResponse = new gagvr::CampaignCriterionSimulation
            {
                ResourceNameAsCampaignCriterionSimulationName = gagvr::CampaignCriterionSimulationName.FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                Type = gagve::SimulationTypeEnum.Types.SimulationType.PercentCpcBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                BidModifierPointList = new gagvc::BidModifierSimulationPointList(),
                CampaignId = -3743237468908008719L,
                CriterionId = 8584655242409302840L,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterionSimulationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignCriterionSimulation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignCriterionSimulationServiceClient client = new CampaignCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignCriterionSimulation responseCallSettings = await client.GetCampaignCriterionSimulationAsync(request.ResourceNameAsCampaignCriterionSimulationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignCriterionSimulation responseCancellationToken = await client.GetCampaignCriterionSimulationAsync(request.ResourceNameAsCampaignCriterionSimulationName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

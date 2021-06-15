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

using gagvc = Google.Ads.GoogleAds.V8.Common;
using gagve = Google.Ads.GoogleAds.V8.Enums;
using gagvr = Google.Ads.GoogleAds.V8.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V8.Services;

namespace Google.Ads.GoogleAds.Tests.V8.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCampaignSimulationServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCampaignSimulationRequestObject()
        {
            moq::Mock<CampaignSimulationService.CampaignSimulationServiceClient> mockGrpcClient = new moq::Mock<CampaignSimulationService.CampaignSimulationServiceClient>(moq::MockBehavior.Strict);
            GetCampaignSimulationRequest request = new GetCampaignSimulationRequest
            {
                ResourceNameAsCampaignSimulationName = gagvr::CampaignSimulationName.FromCustomerCampaignTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::CampaignSimulation expectedResponse = new gagvr::CampaignSimulation
            {
                ResourceNameAsCampaignSimulationName = gagvr::CampaignSimulationName.FromCustomerCampaignTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                CampaignId = -3743237468908008719L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.BidModifier,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Default,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
                TargetImpressionSharePointList = new gagvc::TargetImpressionShareSimulationPointList(),
                BudgetPointList = new gagvc::BudgetSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetCampaignSimulation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignSimulationServiceClient client = new CampaignSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignSimulation response = client.GetCampaignSimulation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignSimulationRequestObjectAsync()
        {
            moq::Mock<CampaignSimulationService.CampaignSimulationServiceClient> mockGrpcClient = new moq::Mock<CampaignSimulationService.CampaignSimulationServiceClient>(moq::MockBehavior.Strict);
            GetCampaignSimulationRequest request = new GetCampaignSimulationRequest
            {
                ResourceNameAsCampaignSimulationName = gagvr::CampaignSimulationName.FromCustomerCampaignTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::CampaignSimulation expectedResponse = new gagvr::CampaignSimulation
            {
                ResourceNameAsCampaignSimulationName = gagvr::CampaignSimulationName.FromCustomerCampaignTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                CampaignId = -3743237468908008719L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.BidModifier,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Default,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
                TargetImpressionSharePointList = new gagvc::TargetImpressionShareSimulationPointList(),
                BudgetPointList = new gagvc::BudgetSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetCampaignSimulationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignSimulation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignSimulationServiceClient client = new CampaignSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignSimulation responseCallSettings = await client.GetCampaignSimulationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignSimulation responseCancellationToken = await client.GetCampaignSimulationAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignSimulation()
        {
            moq::Mock<CampaignSimulationService.CampaignSimulationServiceClient> mockGrpcClient = new moq::Mock<CampaignSimulationService.CampaignSimulationServiceClient>(moq::MockBehavior.Strict);
            GetCampaignSimulationRequest request = new GetCampaignSimulationRequest
            {
                ResourceNameAsCampaignSimulationName = gagvr::CampaignSimulationName.FromCustomerCampaignTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::CampaignSimulation expectedResponse = new gagvr::CampaignSimulation
            {
                ResourceNameAsCampaignSimulationName = gagvr::CampaignSimulationName.FromCustomerCampaignTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                CampaignId = -3743237468908008719L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.BidModifier,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Default,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
                TargetImpressionSharePointList = new gagvc::TargetImpressionShareSimulationPointList(),
                BudgetPointList = new gagvc::BudgetSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetCampaignSimulation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignSimulationServiceClient client = new CampaignSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignSimulation response = client.GetCampaignSimulation(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignSimulationAsync()
        {
            moq::Mock<CampaignSimulationService.CampaignSimulationServiceClient> mockGrpcClient = new moq::Mock<CampaignSimulationService.CampaignSimulationServiceClient>(moq::MockBehavior.Strict);
            GetCampaignSimulationRequest request = new GetCampaignSimulationRequest
            {
                ResourceNameAsCampaignSimulationName = gagvr::CampaignSimulationName.FromCustomerCampaignTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::CampaignSimulation expectedResponse = new gagvr::CampaignSimulation
            {
                ResourceNameAsCampaignSimulationName = gagvr::CampaignSimulationName.FromCustomerCampaignTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                CampaignId = -3743237468908008719L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.BidModifier,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Default,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
                TargetImpressionSharePointList = new gagvc::TargetImpressionShareSimulationPointList(),
                BudgetPointList = new gagvc::BudgetSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetCampaignSimulationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignSimulation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignSimulationServiceClient client = new CampaignSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignSimulation responseCallSettings = await client.GetCampaignSimulationAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignSimulation responseCancellationToken = await client.GetCampaignSimulationAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignSimulationResourceNames()
        {
            moq::Mock<CampaignSimulationService.CampaignSimulationServiceClient> mockGrpcClient = new moq::Mock<CampaignSimulationService.CampaignSimulationServiceClient>(moq::MockBehavior.Strict);
            GetCampaignSimulationRequest request = new GetCampaignSimulationRequest
            {
                ResourceNameAsCampaignSimulationName = gagvr::CampaignSimulationName.FromCustomerCampaignTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::CampaignSimulation expectedResponse = new gagvr::CampaignSimulation
            {
                ResourceNameAsCampaignSimulationName = gagvr::CampaignSimulationName.FromCustomerCampaignTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                CampaignId = -3743237468908008719L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.BidModifier,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Default,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
                TargetImpressionSharePointList = new gagvc::TargetImpressionShareSimulationPointList(),
                BudgetPointList = new gagvc::BudgetSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetCampaignSimulation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignSimulationServiceClient client = new CampaignSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignSimulation response = client.GetCampaignSimulation(request.ResourceNameAsCampaignSimulationName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignSimulationResourceNamesAsync()
        {
            moq::Mock<CampaignSimulationService.CampaignSimulationServiceClient> mockGrpcClient = new moq::Mock<CampaignSimulationService.CampaignSimulationServiceClient>(moq::MockBehavior.Strict);
            GetCampaignSimulationRequest request = new GetCampaignSimulationRequest
            {
                ResourceNameAsCampaignSimulationName = gagvr::CampaignSimulationName.FromCustomerCampaignTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::CampaignSimulation expectedResponse = new gagvr::CampaignSimulation
            {
                ResourceNameAsCampaignSimulationName = gagvr::CampaignSimulationName.FromCustomerCampaignTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                CampaignId = -3743237468908008719L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.BidModifier,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Default,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
                TargetImpressionSharePointList = new gagvc::TargetImpressionShareSimulationPointList(),
                BudgetPointList = new gagvc::BudgetSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetCampaignSimulationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignSimulation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignSimulationServiceClient client = new CampaignSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignSimulation responseCallSettings = await client.GetCampaignSimulationAsync(request.ResourceNameAsCampaignSimulationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignSimulation responseCancellationToken = await client.GetCampaignSimulationAsync(request.ResourceNameAsCampaignSimulationName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

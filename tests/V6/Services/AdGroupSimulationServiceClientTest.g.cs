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
    public sealed class GeneratedAdGroupSimulationServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAdGroupSimulationRequestObject()
        {
            moq::Mock<AdGroupSimulationService.AdGroupSimulationServiceClient> mockGrpcClient = new moq::Mock<AdGroupSimulationService.AdGroupSimulationServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupSimulationRequest request = new GetAdGroupSimulationRequest
            {
                ResourceNameAsAdGroupSimulationName = gagvr::AdGroupSimulationName.FromCustomerAdGroupTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::AdGroupSimulation expectedResponse = new gagvr::AdGroupSimulation
            {
                ResourceNameAsAdGroupSimulationName = gagvr::AdGroupSimulationName.FromCustomerAdGroupTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                Type = gagve::SimulationTypeEnum.Types.SimulationType.PercentCpcBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                CpvBidPointList = new gagvc::CpvBidSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
                AdGroupId = -2072405675042603230L,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupSimulation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupSimulationServiceClient client = new AdGroupSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupSimulation response = client.GetAdGroupSimulation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupSimulationRequestObjectAsync()
        {
            moq::Mock<AdGroupSimulationService.AdGroupSimulationServiceClient> mockGrpcClient = new moq::Mock<AdGroupSimulationService.AdGroupSimulationServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupSimulationRequest request = new GetAdGroupSimulationRequest
            {
                ResourceNameAsAdGroupSimulationName = gagvr::AdGroupSimulationName.FromCustomerAdGroupTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::AdGroupSimulation expectedResponse = new gagvr::AdGroupSimulation
            {
                ResourceNameAsAdGroupSimulationName = gagvr::AdGroupSimulationName.FromCustomerAdGroupTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                Type = gagve::SimulationTypeEnum.Types.SimulationType.PercentCpcBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                CpvBidPointList = new gagvc::CpvBidSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
                AdGroupId = -2072405675042603230L,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupSimulationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupSimulation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupSimulationServiceClient client = new AdGroupSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupSimulation responseCallSettings = await client.GetAdGroupSimulationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupSimulation responseCancellationToken = await client.GetAdGroupSimulationAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupSimulation()
        {
            moq::Mock<AdGroupSimulationService.AdGroupSimulationServiceClient> mockGrpcClient = new moq::Mock<AdGroupSimulationService.AdGroupSimulationServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupSimulationRequest request = new GetAdGroupSimulationRequest
            {
                ResourceNameAsAdGroupSimulationName = gagvr::AdGroupSimulationName.FromCustomerAdGroupTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::AdGroupSimulation expectedResponse = new gagvr::AdGroupSimulation
            {
                ResourceNameAsAdGroupSimulationName = gagvr::AdGroupSimulationName.FromCustomerAdGroupTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                Type = gagve::SimulationTypeEnum.Types.SimulationType.PercentCpcBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                CpvBidPointList = new gagvc::CpvBidSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
                AdGroupId = -2072405675042603230L,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupSimulation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupSimulationServiceClient client = new AdGroupSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupSimulation response = client.GetAdGroupSimulation(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupSimulationAsync()
        {
            moq::Mock<AdGroupSimulationService.AdGroupSimulationServiceClient> mockGrpcClient = new moq::Mock<AdGroupSimulationService.AdGroupSimulationServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupSimulationRequest request = new GetAdGroupSimulationRequest
            {
                ResourceNameAsAdGroupSimulationName = gagvr::AdGroupSimulationName.FromCustomerAdGroupTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::AdGroupSimulation expectedResponse = new gagvr::AdGroupSimulation
            {
                ResourceNameAsAdGroupSimulationName = gagvr::AdGroupSimulationName.FromCustomerAdGroupTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                Type = gagve::SimulationTypeEnum.Types.SimulationType.PercentCpcBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                CpvBidPointList = new gagvc::CpvBidSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
                AdGroupId = -2072405675042603230L,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupSimulationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupSimulation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupSimulationServiceClient client = new AdGroupSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupSimulation responseCallSettings = await client.GetAdGroupSimulationAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupSimulation responseCancellationToken = await client.GetAdGroupSimulationAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupSimulationResourceNames()
        {
            moq::Mock<AdGroupSimulationService.AdGroupSimulationServiceClient> mockGrpcClient = new moq::Mock<AdGroupSimulationService.AdGroupSimulationServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupSimulationRequest request = new GetAdGroupSimulationRequest
            {
                ResourceNameAsAdGroupSimulationName = gagvr::AdGroupSimulationName.FromCustomerAdGroupTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::AdGroupSimulation expectedResponse = new gagvr::AdGroupSimulation
            {
                ResourceNameAsAdGroupSimulationName = gagvr::AdGroupSimulationName.FromCustomerAdGroupTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                Type = gagve::SimulationTypeEnum.Types.SimulationType.PercentCpcBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                CpvBidPointList = new gagvc::CpvBidSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
                AdGroupId = -2072405675042603230L,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupSimulation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupSimulationServiceClient client = new AdGroupSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupSimulation response = client.GetAdGroupSimulation(request.ResourceNameAsAdGroupSimulationName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupSimulationResourceNamesAsync()
        {
            moq::Mock<AdGroupSimulationService.AdGroupSimulationServiceClient> mockGrpcClient = new moq::Mock<AdGroupSimulationService.AdGroupSimulationServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupSimulationRequest request = new GetAdGroupSimulationRequest
            {
                ResourceNameAsAdGroupSimulationName = gagvr::AdGroupSimulationName.FromCustomerAdGroupTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::AdGroupSimulation expectedResponse = new gagvr::AdGroupSimulation
            {
                ResourceNameAsAdGroupSimulationName = gagvr::AdGroupSimulationName.FromCustomerAdGroupTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                Type = gagve::SimulationTypeEnum.Types.SimulationType.PercentCpcBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                CpvBidPointList = new gagvc::CpvBidSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
                AdGroupId = -2072405675042603230L,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupSimulationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupSimulation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupSimulationServiceClient client = new AdGroupSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupSimulation responseCallSettings = await client.GetAdGroupSimulationAsync(request.ResourceNameAsAdGroupSimulationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupSimulation responseCancellationToken = await client.GetAdGroupSimulationAsync(request.ResourceNameAsAdGroupSimulationName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

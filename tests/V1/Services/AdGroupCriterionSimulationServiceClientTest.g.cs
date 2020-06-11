// Copyright 2020 Google LLC
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

using gagvc = Google.Ads.GoogleAds.V1.Common;
using gagve = Google.Ads.GoogleAds.V1.Enums;
using gagvr = Google.Ads.GoogleAds.V1.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V1.Services;

namespace Google.Ads.GoogleAds.Tests.V1.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdGroupCriterionSimulationServiceClientTest
    {
        [Test]
        public void GetAdGroupCriterionSimulationRequestObject()
        {
            moq::Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionSimulationRequest request = new GetAdGroupCriterionSimulationRequest
            {
                ResourceNameAsAdGroupCriterionSimulationName = gagvr::AdGroupCriterionSimulationName.FromCustomerAdGroupCriterionSimulation("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]"),
            };
            gagvr::AdGroupCriterionSimulation expectedResponse = new gagvr::AdGroupCriterionSimulation
            {
                ResourceNameAsAdGroupCriterionSimulationName = gagvr::AdGroupCriterionSimulationName.FromCustomerAdGroupCriterionSimulation("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]"),
                AdGroupId = -2072405675042603230L,
                CriterionId = 8584655242409302840L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.CpvBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionSimulation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionSimulationServiceClient client = new AdGroupCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionSimulation response = client.GetAdGroupCriterionSimulation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAdGroupCriterionSimulationRequestObjectAsync()
        {
            moq::Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionSimulationRequest request = new GetAdGroupCriterionSimulationRequest
            {
                ResourceNameAsAdGroupCriterionSimulationName = gagvr::AdGroupCriterionSimulationName.FromCustomerAdGroupCriterionSimulation("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]"),
            };
            gagvr::AdGroupCriterionSimulation expectedResponse = new gagvr::AdGroupCriterionSimulation
            {
                ResourceNameAsAdGroupCriterionSimulationName = gagvr::AdGroupCriterionSimulationName.FromCustomerAdGroupCriterionSimulation("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]"),
                AdGroupId = -2072405675042603230L,
                CriterionId = 8584655242409302840L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.CpvBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionSimulationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupCriterionSimulation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionSimulationServiceClient client = new AdGroupCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionSimulation responseCallSettings = await client.GetAdGroupCriterionSimulationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupCriterionSimulation responseCancellationToken = await client.GetAdGroupCriterionSimulationAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroupCriterionSimulation()
        {
            moq::Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionSimulationRequest request = new GetAdGroupCriterionSimulationRequest
            {
                ResourceNameAsAdGroupCriterionSimulationName = gagvr::AdGroupCriterionSimulationName.FromCustomerAdGroupCriterionSimulation("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]"),
            };
            gagvr::AdGroupCriterionSimulation expectedResponse = new gagvr::AdGroupCriterionSimulation
            {
                ResourceNameAsAdGroupCriterionSimulationName = gagvr::AdGroupCriterionSimulationName.FromCustomerAdGroupCriterionSimulation("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]"),
                AdGroupId = -2072405675042603230L,
                CriterionId = 8584655242409302840L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.CpvBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionSimulation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionSimulationServiceClient client = new AdGroupCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionSimulation response = client.GetAdGroupCriterionSimulation(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAdGroupCriterionSimulationAsync()
        {
            moq::Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionSimulationRequest request = new GetAdGroupCriterionSimulationRequest
            {
                ResourceNameAsAdGroupCriterionSimulationName = gagvr::AdGroupCriterionSimulationName.FromCustomerAdGroupCriterionSimulation("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]"),
            };
            gagvr::AdGroupCriterionSimulation expectedResponse = new gagvr::AdGroupCriterionSimulation
            {
                ResourceNameAsAdGroupCriterionSimulationName = gagvr::AdGroupCriterionSimulationName.FromCustomerAdGroupCriterionSimulation("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]"),
                AdGroupId = -2072405675042603230L,
                CriterionId = 8584655242409302840L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.CpvBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionSimulationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupCriterionSimulation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionSimulationServiceClient client = new AdGroupCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionSimulation responseCallSettings = await client.GetAdGroupCriterionSimulationAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupCriterionSimulation responseCancellationToken = await client.GetAdGroupCriterionSimulationAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroupCriterionSimulationResourceNames()
        {
            moq::Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionSimulationRequest request = new GetAdGroupCriterionSimulationRequest
            {
                ResourceNameAsAdGroupCriterionSimulationName = gagvr::AdGroupCriterionSimulationName.FromCustomerAdGroupCriterionSimulation("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]"),
            };
            gagvr::AdGroupCriterionSimulation expectedResponse = new gagvr::AdGroupCriterionSimulation
            {
                ResourceNameAsAdGroupCriterionSimulationName = gagvr::AdGroupCriterionSimulationName.FromCustomerAdGroupCriterionSimulation("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]"),
                AdGroupId = -2072405675042603230L,
                CriterionId = 8584655242409302840L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.CpvBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionSimulation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionSimulationServiceClient client = new AdGroupCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionSimulation response = client.GetAdGroupCriterionSimulation(request.ResourceNameAsAdGroupCriterionSimulationName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAdGroupCriterionSimulationResourceNamesAsync()
        {
            moq::Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionSimulationRequest request = new GetAdGroupCriterionSimulationRequest
            {
                ResourceNameAsAdGroupCriterionSimulationName = gagvr::AdGroupCriterionSimulationName.FromCustomerAdGroupCriterionSimulation("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]"),
            };
            gagvr::AdGroupCriterionSimulation expectedResponse = new gagvr::AdGroupCriterionSimulation
            {
                ResourceNameAsAdGroupCriterionSimulationName = gagvr::AdGroupCriterionSimulationName.FromCustomerAdGroupCriterionSimulation("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]"),
                AdGroupId = -2072405675042603230L,
                CriterionId = 8584655242409302840L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.CpvBid,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unknown,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                CpcBidPointList = new gagvc::CpcBidSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionSimulationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupCriterionSimulation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionSimulationServiceClient client = new AdGroupCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionSimulation responseCallSettings = await client.GetAdGroupCriterionSimulationAsync(request.ResourceNameAsAdGroupCriterionSimulationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupCriterionSimulation responseCancellationToken = await client.GetAdGroupCriterionSimulationAsync(request.ResourceNameAsAdGroupCriterionSimulationName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

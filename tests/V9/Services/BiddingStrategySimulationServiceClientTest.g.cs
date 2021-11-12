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

using gagvc = Google.Ads.GoogleAds.V9.Common;
using gagve = Google.Ads.GoogleAds.V9.Enums;
using gagvr = Google.Ads.GoogleAds.V9.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V9.Services;

namespace Google.Ads.GoogleAds.Tests.V9.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBiddingStrategySimulationServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetBiddingStrategySimulationRequestObject()
        {
            moq::Mock<BiddingStrategySimulationService.BiddingStrategySimulationServiceClient> mockGrpcClient = new moq::Mock<BiddingStrategySimulationService.BiddingStrategySimulationServiceClient>(moq::MockBehavior.Strict);
            GetBiddingStrategySimulationRequest request = new GetBiddingStrategySimulationRequest
            {
                ResourceNameAsBiddingStrategySimulationName = gagvr::BiddingStrategySimulationName.FromCustomerBiddingStrategyTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::BiddingStrategySimulation expectedResponse = new gagvr::BiddingStrategySimulation
            {
                ResourceNameAsBiddingStrategySimulationName = gagvr::BiddingStrategySimulationName.FromCustomerBiddingStrategyTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                BiddingStrategyId = -1921746572122371004L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.BidModifier,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Default,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetBiddingStrategySimulation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingStrategySimulationServiceClient client = new BiddingStrategySimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingStrategySimulation response = client.GetBiddingStrategySimulation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetBiddingStrategySimulationRequestObjectAsync()
        {
            moq::Mock<BiddingStrategySimulationService.BiddingStrategySimulationServiceClient> mockGrpcClient = new moq::Mock<BiddingStrategySimulationService.BiddingStrategySimulationServiceClient>(moq::MockBehavior.Strict);
            GetBiddingStrategySimulationRequest request = new GetBiddingStrategySimulationRequest
            {
                ResourceNameAsBiddingStrategySimulationName = gagvr::BiddingStrategySimulationName.FromCustomerBiddingStrategyTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::BiddingStrategySimulation expectedResponse = new gagvr::BiddingStrategySimulation
            {
                ResourceNameAsBiddingStrategySimulationName = gagvr::BiddingStrategySimulationName.FromCustomerBiddingStrategyTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                BiddingStrategyId = -1921746572122371004L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.BidModifier,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Default,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetBiddingStrategySimulationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BiddingStrategySimulation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingStrategySimulationServiceClient client = new BiddingStrategySimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingStrategySimulation responseCallSettings = await client.GetBiddingStrategySimulationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BiddingStrategySimulation responseCancellationToken = await client.GetBiddingStrategySimulationAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetBiddingStrategySimulation()
        {
            moq::Mock<BiddingStrategySimulationService.BiddingStrategySimulationServiceClient> mockGrpcClient = new moq::Mock<BiddingStrategySimulationService.BiddingStrategySimulationServiceClient>(moq::MockBehavior.Strict);
            GetBiddingStrategySimulationRequest request = new GetBiddingStrategySimulationRequest
            {
                ResourceNameAsBiddingStrategySimulationName = gagvr::BiddingStrategySimulationName.FromCustomerBiddingStrategyTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::BiddingStrategySimulation expectedResponse = new gagvr::BiddingStrategySimulation
            {
                ResourceNameAsBiddingStrategySimulationName = gagvr::BiddingStrategySimulationName.FromCustomerBiddingStrategyTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                BiddingStrategyId = -1921746572122371004L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.BidModifier,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Default,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetBiddingStrategySimulation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingStrategySimulationServiceClient client = new BiddingStrategySimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingStrategySimulation response = client.GetBiddingStrategySimulation(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetBiddingStrategySimulationAsync()
        {
            moq::Mock<BiddingStrategySimulationService.BiddingStrategySimulationServiceClient> mockGrpcClient = new moq::Mock<BiddingStrategySimulationService.BiddingStrategySimulationServiceClient>(moq::MockBehavior.Strict);
            GetBiddingStrategySimulationRequest request = new GetBiddingStrategySimulationRequest
            {
                ResourceNameAsBiddingStrategySimulationName = gagvr::BiddingStrategySimulationName.FromCustomerBiddingStrategyTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::BiddingStrategySimulation expectedResponse = new gagvr::BiddingStrategySimulation
            {
                ResourceNameAsBiddingStrategySimulationName = gagvr::BiddingStrategySimulationName.FromCustomerBiddingStrategyTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                BiddingStrategyId = -1921746572122371004L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.BidModifier,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Default,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetBiddingStrategySimulationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BiddingStrategySimulation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingStrategySimulationServiceClient client = new BiddingStrategySimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingStrategySimulation responseCallSettings = await client.GetBiddingStrategySimulationAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BiddingStrategySimulation responseCancellationToken = await client.GetBiddingStrategySimulationAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetBiddingStrategySimulationResourceNames()
        {
            moq::Mock<BiddingStrategySimulationService.BiddingStrategySimulationServiceClient> mockGrpcClient = new moq::Mock<BiddingStrategySimulationService.BiddingStrategySimulationServiceClient>(moq::MockBehavior.Strict);
            GetBiddingStrategySimulationRequest request = new GetBiddingStrategySimulationRequest
            {
                ResourceNameAsBiddingStrategySimulationName = gagvr::BiddingStrategySimulationName.FromCustomerBiddingStrategyTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::BiddingStrategySimulation expectedResponse = new gagvr::BiddingStrategySimulation
            {
                ResourceNameAsBiddingStrategySimulationName = gagvr::BiddingStrategySimulationName.FromCustomerBiddingStrategyTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                BiddingStrategyId = -1921746572122371004L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.BidModifier,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Default,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetBiddingStrategySimulation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingStrategySimulationServiceClient client = new BiddingStrategySimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingStrategySimulation response = client.GetBiddingStrategySimulation(request.ResourceNameAsBiddingStrategySimulationName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetBiddingStrategySimulationResourceNamesAsync()
        {
            moq::Mock<BiddingStrategySimulationService.BiddingStrategySimulationServiceClient> mockGrpcClient = new moq::Mock<BiddingStrategySimulationService.BiddingStrategySimulationServiceClient>(moq::MockBehavior.Strict);
            GetBiddingStrategySimulationRequest request = new GetBiddingStrategySimulationRequest
            {
                ResourceNameAsBiddingStrategySimulationName = gagvr::BiddingStrategySimulationName.FromCustomerBiddingStrategyTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
            };
            gagvr::BiddingStrategySimulation expectedResponse = new gagvr::BiddingStrategySimulation
            {
                ResourceNameAsBiddingStrategySimulationName = gagvr::BiddingStrategySimulationName.FromCustomerBiddingStrategyTypeModificationMethodStartDateEndDate("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]", "[TYPE]", "[MODIFICATION_METHOD]", "[START_DATE]", "[END_DATE]"),
                BiddingStrategyId = -1921746572122371004L,
                Type = gagve::SimulationTypeEnum.Types.SimulationType.BidModifier,
                ModificationMethod = gagve::SimulationModificationMethodEnum.Types.SimulationModificationMethod.Default,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                TargetCpaPointList = new gagvc::TargetCpaSimulationPointList(),
                TargetRoasPointList = new gagvc::TargetRoasSimulationPointList(),
            };
            mockGrpcClient.Setup(x => x.GetBiddingStrategySimulationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BiddingStrategySimulation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingStrategySimulationServiceClient client = new BiddingStrategySimulationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingStrategySimulation responseCallSettings = await client.GetBiddingStrategySimulationAsync(request.ResourceNameAsBiddingStrategySimulationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BiddingStrategySimulation responseCancellationToken = await client.GetBiddingStrategySimulationAsync(request.ResourceNameAsBiddingStrategySimulationName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

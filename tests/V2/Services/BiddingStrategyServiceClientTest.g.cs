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

using gagvc = Google.Ads.GoogleAds.V2.Common;
using gagve = Google.Ads.GoogleAds.V2.Enums;
using gagvr = Google.Ads.GoogleAds.V2.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V2.Services;

namespace Google.Ads.GoogleAds.Tests.V2.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBiddingStrategyServiceClientTest
    {
        [Test]
        public void GetBiddingStrategyRequestObject()
        {
            moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient>(moq::MockBehavior.Strict);
            GetBiddingStrategyRequest request = new GetBiddingStrategyRequest
            {
                ResourceNameAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
            };
            gagvr::BiddingStrategy expectedResponse = new gagvr::BiddingStrategy
            {
                ResourceNameAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                Id = -6774108720365892680L,
                BiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                Type = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.ManualCpm,
                EnhancedCpc = new gagvc::EnhancedCpc(),
                PageOnePromoted = new gagvc::PageOnePromoted(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetOutrankShare = new gagvc::TargetOutrankShare(),
                TargetRoas = new gagvc::TargetRoas(),
                TargetSpend = new gagvc::TargetSpend(),
                CampaignCount = 7086295369533367171L,
                NonRemovedCampaignCount = 8279371121198864414L,
                Status = gagve::BiddingStrategyStatusEnum.Types.BiddingStrategyStatus.Enabled,
                TargetImpressionShare = new gagvc::TargetImpressionShare(),
            };
            mockGrpcClient.Setup(x => x.GetBiddingStrategy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingStrategy response = client.GetBiddingStrategy(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetBiddingStrategyRequestObjectAsync()
        {
            moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient>(moq::MockBehavior.Strict);
            GetBiddingStrategyRequest request = new GetBiddingStrategyRequest
            {
                ResourceNameAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
            };
            gagvr::BiddingStrategy expectedResponse = new gagvr::BiddingStrategy
            {
                ResourceNameAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                Id = -6774108720365892680L,
                BiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                Type = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.ManualCpm,
                EnhancedCpc = new gagvc::EnhancedCpc(),
                PageOnePromoted = new gagvc::PageOnePromoted(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetOutrankShare = new gagvc::TargetOutrankShare(),
                TargetRoas = new gagvc::TargetRoas(),
                TargetSpend = new gagvc::TargetSpend(),
                CampaignCount = 7086295369533367171L,
                NonRemovedCampaignCount = 8279371121198864414L,
                Status = gagve::BiddingStrategyStatusEnum.Types.BiddingStrategyStatus.Enabled,
                TargetImpressionShare = new gagvc::TargetImpressionShare(),
            };
            mockGrpcClient.Setup(x => x.GetBiddingStrategyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BiddingStrategy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingStrategy responseCallSettings = await client.GetBiddingStrategyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BiddingStrategy responseCancellationToken = await client.GetBiddingStrategyAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetBiddingStrategy()
        {
            moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient>(moq::MockBehavior.Strict);
            GetBiddingStrategyRequest request = new GetBiddingStrategyRequest
            {
                ResourceNameAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
            };
            gagvr::BiddingStrategy expectedResponse = new gagvr::BiddingStrategy
            {
                ResourceNameAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                Id = -6774108720365892680L,
                BiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                Type = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.ManualCpm,
                EnhancedCpc = new gagvc::EnhancedCpc(),
                PageOnePromoted = new gagvc::PageOnePromoted(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetOutrankShare = new gagvc::TargetOutrankShare(),
                TargetRoas = new gagvc::TargetRoas(),
                TargetSpend = new gagvc::TargetSpend(),
                CampaignCount = 7086295369533367171L,
                NonRemovedCampaignCount = 8279371121198864414L,
                Status = gagve::BiddingStrategyStatusEnum.Types.BiddingStrategyStatus.Enabled,
                TargetImpressionShare = new gagvc::TargetImpressionShare(),
            };
            mockGrpcClient.Setup(x => x.GetBiddingStrategy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingStrategy response = client.GetBiddingStrategy(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetBiddingStrategyAsync()
        {
            moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient>(moq::MockBehavior.Strict);
            GetBiddingStrategyRequest request = new GetBiddingStrategyRequest
            {
                ResourceNameAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
            };
            gagvr::BiddingStrategy expectedResponse = new gagvr::BiddingStrategy
            {
                ResourceNameAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                Id = -6774108720365892680L,
                BiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                Type = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.ManualCpm,
                EnhancedCpc = new gagvc::EnhancedCpc(),
                PageOnePromoted = new gagvc::PageOnePromoted(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetOutrankShare = new gagvc::TargetOutrankShare(),
                TargetRoas = new gagvc::TargetRoas(),
                TargetSpend = new gagvc::TargetSpend(),
                CampaignCount = 7086295369533367171L,
                NonRemovedCampaignCount = 8279371121198864414L,
                Status = gagve::BiddingStrategyStatusEnum.Types.BiddingStrategyStatus.Enabled,
                TargetImpressionShare = new gagvc::TargetImpressionShare(),
            };
            mockGrpcClient.Setup(x => x.GetBiddingStrategyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BiddingStrategy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingStrategy responseCallSettings = await client.GetBiddingStrategyAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BiddingStrategy responseCancellationToken = await client.GetBiddingStrategyAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetBiddingStrategyResourceNames()
        {
            moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient>(moq::MockBehavior.Strict);
            GetBiddingStrategyRequest request = new GetBiddingStrategyRequest
            {
                ResourceNameAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
            };
            gagvr::BiddingStrategy expectedResponse = new gagvr::BiddingStrategy
            {
                ResourceNameAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                Id = -6774108720365892680L,
                BiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                Type = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.ManualCpm,
                EnhancedCpc = new gagvc::EnhancedCpc(),
                PageOnePromoted = new gagvc::PageOnePromoted(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetOutrankShare = new gagvc::TargetOutrankShare(),
                TargetRoas = new gagvc::TargetRoas(),
                TargetSpend = new gagvc::TargetSpend(),
                CampaignCount = 7086295369533367171L,
                NonRemovedCampaignCount = 8279371121198864414L,
                Status = gagve::BiddingStrategyStatusEnum.Types.BiddingStrategyStatus.Enabled,
                TargetImpressionShare = new gagvc::TargetImpressionShare(),
            };
            mockGrpcClient.Setup(x => x.GetBiddingStrategy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingStrategy response = client.GetBiddingStrategy(request.ResourceNameAsBiddingStrategyName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetBiddingStrategyResourceNamesAsync()
        {
            moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient>(moq::MockBehavior.Strict);
            GetBiddingStrategyRequest request = new GetBiddingStrategyRequest
            {
                ResourceNameAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
            };
            gagvr::BiddingStrategy expectedResponse = new gagvr::BiddingStrategy
            {
                ResourceNameAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                Id = -6774108720365892680L,
                BiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                Type = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.ManualCpm,
                EnhancedCpc = new gagvc::EnhancedCpc(),
                PageOnePromoted = new gagvc::PageOnePromoted(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetOutrankShare = new gagvc::TargetOutrankShare(),
                TargetRoas = new gagvc::TargetRoas(),
                TargetSpend = new gagvc::TargetSpend(),
                CampaignCount = 7086295369533367171L,
                NonRemovedCampaignCount = 8279371121198864414L,
                Status = gagve::BiddingStrategyStatusEnum.Types.BiddingStrategyStatus.Enabled,
                TargetImpressionShare = new gagvc::TargetImpressionShare(),
            };
            mockGrpcClient.Setup(x => x.GetBiddingStrategyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BiddingStrategy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingStrategy responseCallSettings = await client.GetBiddingStrategyAsync(request.ResourceNameAsBiddingStrategyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BiddingStrategy responseCancellationToken = await client.GetBiddingStrategyAsync(request.ResourceNameAsBiddingStrategyName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateBiddingStrategiesRequestObject()
        {
            moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient>(moq::MockBehavior.Strict);
            MutateBiddingStrategiesRequest request = new MutateBiddingStrategiesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new BiddingStrategyOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateBiddingStrategiesResponse expectedResponse = new MutateBiddingStrategiesResponse
            {
                Results =
                {
                    new MutateBiddingStrategyResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateBiddingStrategies(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            MutateBiddingStrategiesResponse response = client.MutateBiddingStrategies(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateBiddingStrategiesRequestObjectAsync()
        {
            moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient>(moq::MockBehavior.Strict);
            MutateBiddingStrategiesRequest request = new MutateBiddingStrategiesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new BiddingStrategyOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateBiddingStrategiesResponse expectedResponse = new MutateBiddingStrategiesResponse
            {
                Results =
                {
                    new MutateBiddingStrategyResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateBiddingStrategiesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateBiddingStrategiesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            MutateBiddingStrategiesResponse responseCallSettings = await client.MutateBiddingStrategiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateBiddingStrategiesResponse responseCancellationToken = await client.MutateBiddingStrategiesAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateBiddingStrategies()
        {
            moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient>(moq::MockBehavior.Strict);
            MutateBiddingStrategiesRequest request = new MutateBiddingStrategiesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new BiddingStrategyOperation(),
                },
            };
            MutateBiddingStrategiesResponse expectedResponse = new MutateBiddingStrategiesResponse
            {
                Results =
                {
                    new MutateBiddingStrategyResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateBiddingStrategies(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            MutateBiddingStrategiesResponse response = client.MutateBiddingStrategies(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateBiddingStrategiesAsync()
        {
            moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new moq::Mock<BiddingStrategyService.BiddingStrategyServiceClient>(moq::MockBehavior.Strict);
            MutateBiddingStrategiesRequest request = new MutateBiddingStrategiesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new BiddingStrategyOperation(),
                },
            };
            MutateBiddingStrategiesResponse expectedResponse = new MutateBiddingStrategiesResponse
            {
                Results =
                {
                    new MutateBiddingStrategyResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateBiddingStrategiesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateBiddingStrategiesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            MutateBiddingStrategiesResponse responseCallSettings = await client.MutateBiddingStrategiesAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateBiddingStrategiesResponse responseCancellationToken = await client.MutateBiddingStrategiesAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

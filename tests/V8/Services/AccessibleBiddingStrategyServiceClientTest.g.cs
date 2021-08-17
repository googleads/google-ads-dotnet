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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V8.Services;

namespace Google.Ads.GoogleAds.Tests.V8.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAccessibleBiddingStrategyServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAccessibleBiddingStrategyRequestObject()
        {
            moq::Mock<AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient> mockGrpcClient = new moq::Mock<AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient>(moq::MockBehavior.Strict);
            GetAccessibleBiddingStrategyRequest request = new GetAccessibleBiddingStrategyRequest
            {
                ResourceNameAsAccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
            };
            gagvr::AccessibleBiddingStrategy expectedResponse = new gagvr::AccessibleBiddingStrategy
            {
                ResourceNameAsAccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                Id = -6774108720365892680L,
                AccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                Type = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.MaximizeConversionValue,
                OwnerCustomerId = -2650145682576888976L,
                OwnerDescriptiveName = "owner_descriptive_name9379a08d",
                MaximizeConversionValue = new gagvr::AccessibleBiddingStrategy.Types.MaximizeConversionValue(),
                MaximizeConversions = new gagvr::AccessibleBiddingStrategy.Types.MaximizeConversions(),
                TargetCpa = new gagvr::AccessibleBiddingStrategy.Types.TargetCpa(),
                TargetImpressionShare = new gagvr::AccessibleBiddingStrategy.Types.TargetImpressionShare(),
                TargetRoas = new gagvr::AccessibleBiddingStrategy.Types.TargetRoas(),
                TargetSpend = new gagvr::AccessibleBiddingStrategy.Types.TargetSpend(),
            };
            mockGrpcClient.Setup(x => x.GetAccessibleBiddingStrategy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessibleBiddingStrategyServiceClient client = new AccessibleBiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccessibleBiddingStrategy response = client.GetAccessibleBiddingStrategy(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAccessibleBiddingStrategyRequestObjectAsync()
        {
            moq::Mock<AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient> mockGrpcClient = new moq::Mock<AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient>(moq::MockBehavior.Strict);
            GetAccessibleBiddingStrategyRequest request = new GetAccessibleBiddingStrategyRequest
            {
                ResourceNameAsAccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
            };
            gagvr::AccessibleBiddingStrategy expectedResponse = new gagvr::AccessibleBiddingStrategy
            {
                ResourceNameAsAccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                Id = -6774108720365892680L,
                AccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                Type = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.MaximizeConversionValue,
                OwnerCustomerId = -2650145682576888976L,
                OwnerDescriptiveName = "owner_descriptive_name9379a08d",
                MaximizeConversionValue = new gagvr::AccessibleBiddingStrategy.Types.MaximizeConversionValue(),
                MaximizeConversions = new gagvr::AccessibleBiddingStrategy.Types.MaximizeConversions(),
                TargetCpa = new gagvr::AccessibleBiddingStrategy.Types.TargetCpa(),
                TargetImpressionShare = new gagvr::AccessibleBiddingStrategy.Types.TargetImpressionShare(),
                TargetRoas = new gagvr::AccessibleBiddingStrategy.Types.TargetRoas(),
                TargetSpend = new gagvr::AccessibleBiddingStrategy.Types.TargetSpend(),
            };
            mockGrpcClient.Setup(x => x.GetAccessibleBiddingStrategyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AccessibleBiddingStrategy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessibleBiddingStrategyServiceClient client = new AccessibleBiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccessibleBiddingStrategy responseCallSettings = await client.GetAccessibleBiddingStrategyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AccessibleBiddingStrategy responseCancellationToken = await client.GetAccessibleBiddingStrategyAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAccessibleBiddingStrategy()
        {
            moq::Mock<AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient> mockGrpcClient = new moq::Mock<AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient>(moq::MockBehavior.Strict);
            GetAccessibleBiddingStrategyRequest request = new GetAccessibleBiddingStrategyRequest
            {
                ResourceNameAsAccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
            };
            gagvr::AccessibleBiddingStrategy expectedResponse = new gagvr::AccessibleBiddingStrategy
            {
                ResourceNameAsAccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                Id = -6774108720365892680L,
                AccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                Type = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.MaximizeConversionValue,
                OwnerCustomerId = -2650145682576888976L,
                OwnerDescriptiveName = "owner_descriptive_name9379a08d",
                MaximizeConversionValue = new gagvr::AccessibleBiddingStrategy.Types.MaximizeConversionValue(),
                MaximizeConversions = new gagvr::AccessibleBiddingStrategy.Types.MaximizeConversions(),
                TargetCpa = new gagvr::AccessibleBiddingStrategy.Types.TargetCpa(),
                TargetImpressionShare = new gagvr::AccessibleBiddingStrategy.Types.TargetImpressionShare(),
                TargetRoas = new gagvr::AccessibleBiddingStrategy.Types.TargetRoas(),
                TargetSpend = new gagvr::AccessibleBiddingStrategy.Types.TargetSpend(),
            };
            mockGrpcClient.Setup(x => x.GetAccessibleBiddingStrategy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessibleBiddingStrategyServiceClient client = new AccessibleBiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccessibleBiddingStrategy response = client.GetAccessibleBiddingStrategy(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAccessibleBiddingStrategyAsync()
        {
            moq::Mock<AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient> mockGrpcClient = new moq::Mock<AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient>(moq::MockBehavior.Strict);
            GetAccessibleBiddingStrategyRequest request = new GetAccessibleBiddingStrategyRequest
            {
                ResourceNameAsAccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
            };
            gagvr::AccessibleBiddingStrategy expectedResponse = new gagvr::AccessibleBiddingStrategy
            {
                ResourceNameAsAccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                Id = -6774108720365892680L,
                AccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                Type = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.MaximizeConversionValue,
                OwnerCustomerId = -2650145682576888976L,
                OwnerDescriptiveName = "owner_descriptive_name9379a08d",
                MaximizeConversionValue = new gagvr::AccessibleBiddingStrategy.Types.MaximizeConversionValue(),
                MaximizeConversions = new gagvr::AccessibleBiddingStrategy.Types.MaximizeConversions(),
                TargetCpa = new gagvr::AccessibleBiddingStrategy.Types.TargetCpa(),
                TargetImpressionShare = new gagvr::AccessibleBiddingStrategy.Types.TargetImpressionShare(),
                TargetRoas = new gagvr::AccessibleBiddingStrategy.Types.TargetRoas(),
                TargetSpend = new gagvr::AccessibleBiddingStrategy.Types.TargetSpend(),
            };
            mockGrpcClient.Setup(x => x.GetAccessibleBiddingStrategyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AccessibleBiddingStrategy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessibleBiddingStrategyServiceClient client = new AccessibleBiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccessibleBiddingStrategy responseCallSettings = await client.GetAccessibleBiddingStrategyAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AccessibleBiddingStrategy responseCancellationToken = await client.GetAccessibleBiddingStrategyAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAccessibleBiddingStrategyResourceNames()
        {
            moq::Mock<AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient> mockGrpcClient = new moq::Mock<AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient>(moq::MockBehavior.Strict);
            GetAccessibleBiddingStrategyRequest request = new GetAccessibleBiddingStrategyRequest
            {
                ResourceNameAsAccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
            };
            gagvr::AccessibleBiddingStrategy expectedResponse = new gagvr::AccessibleBiddingStrategy
            {
                ResourceNameAsAccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                Id = -6774108720365892680L,
                AccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                Type = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.MaximizeConversionValue,
                OwnerCustomerId = -2650145682576888976L,
                OwnerDescriptiveName = "owner_descriptive_name9379a08d",
                MaximizeConversionValue = new gagvr::AccessibleBiddingStrategy.Types.MaximizeConversionValue(),
                MaximizeConversions = new gagvr::AccessibleBiddingStrategy.Types.MaximizeConversions(),
                TargetCpa = new gagvr::AccessibleBiddingStrategy.Types.TargetCpa(),
                TargetImpressionShare = new gagvr::AccessibleBiddingStrategy.Types.TargetImpressionShare(),
                TargetRoas = new gagvr::AccessibleBiddingStrategy.Types.TargetRoas(),
                TargetSpend = new gagvr::AccessibleBiddingStrategy.Types.TargetSpend(),
            };
            mockGrpcClient.Setup(x => x.GetAccessibleBiddingStrategy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccessibleBiddingStrategyServiceClient client = new AccessibleBiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccessibleBiddingStrategy response = client.GetAccessibleBiddingStrategy(request.ResourceNameAsAccessibleBiddingStrategyName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAccessibleBiddingStrategyResourceNamesAsync()
        {
            moq::Mock<AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient> mockGrpcClient = new moq::Mock<AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient>(moq::MockBehavior.Strict);
            GetAccessibleBiddingStrategyRequest request = new GetAccessibleBiddingStrategyRequest
            {
                ResourceNameAsAccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
            };
            gagvr::AccessibleBiddingStrategy expectedResponse = new gagvr::AccessibleBiddingStrategy
            {
                ResourceNameAsAccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                Id = -6774108720365892680L,
                AccessibleBiddingStrategyName = gagvr::AccessibleBiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                Type = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.MaximizeConversionValue,
                OwnerCustomerId = -2650145682576888976L,
                OwnerDescriptiveName = "owner_descriptive_name9379a08d",
                MaximizeConversionValue = new gagvr::AccessibleBiddingStrategy.Types.MaximizeConversionValue(),
                MaximizeConversions = new gagvr::AccessibleBiddingStrategy.Types.MaximizeConversions(),
                TargetCpa = new gagvr::AccessibleBiddingStrategy.Types.TargetCpa(),
                TargetImpressionShare = new gagvr::AccessibleBiddingStrategy.Types.TargetImpressionShare(),
                TargetRoas = new gagvr::AccessibleBiddingStrategy.Types.TargetRoas(),
                TargetSpend = new gagvr::AccessibleBiddingStrategy.Types.TargetSpend(),
            };
            mockGrpcClient.Setup(x => x.GetAccessibleBiddingStrategyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AccessibleBiddingStrategy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccessibleBiddingStrategyServiceClient client = new AccessibleBiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccessibleBiddingStrategy responseCallSettings = await client.GetAccessibleBiddingStrategyAsync(request.ResourceNameAsAccessibleBiddingStrategyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AccessibleBiddingStrategy responseCancellationToken = await client.GetAccessibleBiddingStrategyAsync(request.ResourceNameAsAccessibleBiddingStrategyName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

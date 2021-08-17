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
    public sealed class GeneratedConversionValueRuleServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetConversionValueRuleRequestObject()
        {
            moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient>(moq::MockBehavior.Strict);
            GetConversionValueRuleRequest request = new GetConversionValueRuleRequest
            {
                ResourceNameAsConversionValueRuleName = gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
            };
            gagvr::ConversionValueRule expectedResponse = new gagvr::ConversionValueRule
            {
                ResourceNameAsConversionValueRuleName = gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
                Id = -6774108720365892680L,
                Action = new gagvr::ConversionValueRule.Types.ValueRuleAction(),
                GeoLocationCondition = new gagvr::ConversionValueRule.Types.ValueRuleGeoLocationCondition(),
                DeviceCondition = new gagvr::ConversionValueRule.Types.ValueRuleDeviceCondition(),
                AudienceCondition = new gagvr::ConversionValueRule.Types.ValueRuleAudienceCondition(),
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                Status = gagve::ConversionValueRuleStatusEnum.Types.ConversionValueRuleStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetConversionValueRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionValueRuleServiceClient client = new ConversionValueRuleServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionValueRule response = client.GetConversionValueRule(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetConversionValueRuleRequestObjectAsync()
        {
            moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient>(moq::MockBehavior.Strict);
            GetConversionValueRuleRequest request = new GetConversionValueRuleRequest
            {
                ResourceNameAsConversionValueRuleName = gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
            };
            gagvr::ConversionValueRule expectedResponse = new gagvr::ConversionValueRule
            {
                ResourceNameAsConversionValueRuleName = gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
                Id = -6774108720365892680L,
                Action = new gagvr::ConversionValueRule.Types.ValueRuleAction(),
                GeoLocationCondition = new gagvr::ConversionValueRule.Types.ValueRuleGeoLocationCondition(),
                DeviceCondition = new gagvr::ConversionValueRule.Types.ValueRuleDeviceCondition(),
                AudienceCondition = new gagvr::ConversionValueRule.Types.ValueRuleAudienceCondition(),
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                Status = gagve::ConversionValueRuleStatusEnum.Types.ConversionValueRuleStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetConversionValueRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ConversionValueRule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionValueRuleServiceClient client = new ConversionValueRuleServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionValueRule responseCallSettings = await client.GetConversionValueRuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ConversionValueRule responseCancellationToken = await client.GetConversionValueRuleAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetConversionValueRule()
        {
            moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient>(moq::MockBehavior.Strict);
            GetConversionValueRuleRequest request = new GetConversionValueRuleRequest
            {
                ResourceNameAsConversionValueRuleName = gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
            };
            gagvr::ConversionValueRule expectedResponse = new gagvr::ConversionValueRule
            {
                ResourceNameAsConversionValueRuleName = gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
                Id = -6774108720365892680L,
                Action = new gagvr::ConversionValueRule.Types.ValueRuleAction(),
                GeoLocationCondition = new gagvr::ConversionValueRule.Types.ValueRuleGeoLocationCondition(),
                DeviceCondition = new gagvr::ConversionValueRule.Types.ValueRuleDeviceCondition(),
                AudienceCondition = new gagvr::ConversionValueRule.Types.ValueRuleAudienceCondition(),
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                Status = gagve::ConversionValueRuleStatusEnum.Types.ConversionValueRuleStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetConversionValueRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionValueRuleServiceClient client = new ConversionValueRuleServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionValueRule response = client.GetConversionValueRule(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetConversionValueRuleAsync()
        {
            moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient>(moq::MockBehavior.Strict);
            GetConversionValueRuleRequest request = new GetConversionValueRuleRequest
            {
                ResourceNameAsConversionValueRuleName = gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
            };
            gagvr::ConversionValueRule expectedResponse = new gagvr::ConversionValueRule
            {
                ResourceNameAsConversionValueRuleName = gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
                Id = -6774108720365892680L,
                Action = new gagvr::ConversionValueRule.Types.ValueRuleAction(),
                GeoLocationCondition = new gagvr::ConversionValueRule.Types.ValueRuleGeoLocationCondition(),
                DeviceCondition = new gagvr::ConversionValueRule.Types.ValueRuleDeviceCondition(),
                AudienceCondition = new gagvr::ConversionValueRule.Types.ValueRuleAudienceCondition(),
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                Status = gagve::ConversionValueRuleStatusEnum.Types.ConversionValueRuleStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetConversionValueRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ConversionValueRule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionValueRuleServiceClient client = new ConversionValueRuleServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionValueRule responseCallSettings = await client.GetConversionValueRuleAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ConversionValueRule responseCancellationToken = await client.GetConversionValueRuleAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetConversionValueRuleResourceNames()
        {
            moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient>(moq::MockBehavior.Strict);
            GetConversionValueRuleRequest request = new GetConversionValueRuleRequest
            {
                ResourceNameAsConversionValueRuleName = gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
            };
            gagvr::ConversionValueRule expectedResponse = new gagvr::ConversionValueRule
            {
                ResourceNameAsConversionValueRuleName = gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
                Id = -6774108720365892680L,
                Action = new gagvr::ConversionValueRule.Types.ValueRuleAction(),
                GeoLocationCondition = new gagvr::ConversionValueRule.Types.ValueRuleGeoLocationCondition(),
                DeviceCondition = new gagvr::ConversionValueRule.Types.ValueRuleDeviceCondition(),
                AudienceCondition = new gagvr::ConversionValueRule.Types.ValueRuleAudienceCondition(),
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                Status = gagve::ConversionValueRuleStatusEnum.Types.ConversionValueRuleStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetConversionValueRule(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionValueRuleServiceClient client = new ConversionValueRuleServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionValueRule response = client.GetConversionValueRule(request.ResourceNameAsConversionValueRuleName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetConversionValueRuleResourceNamesAsync()
        {
            moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient>(moq::MockBehavior.Strict);
            GetConversionValueRuleRequest request = new GetConversionValueRuleRequest
            {
                ResourceNameAsConversionValueRuleName = gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
            };
            gagvr::ConversionValueRule expectedResponse = new gagvr::ConversionValueRule
            {
                ResourceNameAsConversionValueRuleName = gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
                Id = -6774108720365892680L,
                Action = new gagvr::ConversionValueRule.Types.ValueRuleAction(),
                GeoLocationCondition = new gagvr::ConversionValueRule.Types.ValueRuleGeoLocationCondition(),
                DeviceCondition = new gagvr::ConversionValueRule.Types.ValueRuleDeviceCondition(),
                AudienceCondition = new gagvr::ConversionValueRule.Types.ValueRuleAudienceCondition(),
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                Status = gagve::ConversionValueRuleStatusEnum.Types.ConversionValueRuleStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetConversionValueRuleAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ConversionValueRule>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionValueRuleServiceClient client = new ConversionValueRuleServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionValueRule responseCallSettings = await client.GetConversionValueRuleAsync(request.ResourceNameAsConversionValueRuleName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ConversionValueRule responseCancellationToken = await client.GetConversionValueRuleAsync(request.ResourceNameAsConversionValueRuleName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateConversionValueRulesRequestObject()
        {
            moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient>(moq::MockBehavior.Strict);
            MutateConversionValueRulesRequest request = new MutateConversionValueRulesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionValueRuleOperation(),
                },
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
                PartialFailure = false,
            };
            MutateConversionValueRulesResponse expectedResponse = new MutateConversionValueRulesResponse
            {
                Results =
                {
                    new MutateConversionValueRuleResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionValueRules(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionValueRuleServiceClient client = new ConversionValueRuleServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionValueRulesResponse response = client.MutateConversionValueRules(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateConversionValueRulesRequestObjectAsync()
        {
            moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient>(moq::MockBehavior.Strict);
            MutateConversionValueRulesRequest request = new MutateConversionValueRulesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionValueRuleOperation(),
                },
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
                PartialFailure = false,
            };
            MutateConversionValueRulesResponse expectedResponse = new MutateConversionValueRulesResponse
            {
                Results =
                {
                    new MutateConversionValueRuleResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionValueRulesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateConversionValueRulesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionValueRuleServiceClient client = new ConversionValueRuleServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionValueRulesResponse responseCallSettings = await client.MutateConversionValueRulesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateConversionValueRulesResponse responseCancellationToken = await client.MutateConversionValueRulesAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateConversionValueRules()
        {
            moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient>(moq::MockBehavior.Strict);
            MutateConversionValueRulesRequest request = new MutateConversionValueRulesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionValueRuleOperation(),
                },
            };
            MutateConversionValueRulesResponse expectedResponse = new MutateConversionValueRulesResponse
            {
                Results =
                {
                    new MutateConversionValueRuleResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionValueRules(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionValueRuleServiceClient client = new ConversionValueRuleServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionValueRulesResponse response = client.MutateConversionValueRules(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateConversionValueRulesAsync()
        {
            moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleService.ConversionValueRuleServiceClient>(moq::MockBehavior.Strict);
            MutateConversionValueRulesRequest request = new MutateConversionValueRulesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionValueRuleOperation(),
                },
            };
            MutateConversionValueRulesResponse expectedResponse = new MutateConversionValueRulesResponse
            {
                Results =
                {
                    new MutateConversionValueRuleResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionValueRulesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateConversionValueRulesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionValueRuleServiceClient client = new ConversionValueRuleServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionValueRulesResponse responseCallSettings = await client.MutateConversionValueRulesAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateConversionValueRulesResponse responseCancellationToken = await client.MutateConversionValueRulesAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

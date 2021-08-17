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
    public sealed class GeneratedConversionValueRuleSetServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetConversionValueRuleSetRequestObject()
        {
            moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient>(moq::MockBehavior.Strict);
            GetConversionValueRuleSetRequest request = new GetConversionValueRuleSetRequest
            {
                ResourceNameAsConversionValueRuleSetName = gagvr::ConversionValueRuleSetName.FromCustomerConversionValueRuleSet("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_SET_ID]"),
            };
            gagvr::ConversionValueRuleSet expectedResponse = new gagvr::ConversionValueRuleSet
            {
                ResourceNameAsConversionValueRuleSetName = gagvr::ConversionValueRuleSetName.FromCustomerConversionValueRuleSet("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_SET_ID]"),
                Id = -6774108720365892680L,
                ConversionValueRulesAsConversionValueRuleNames =
                {
                    gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
                },
                Dimensions =
                {
                    gagve::ValueRuleSetDimensionEnum.Types.ValueRuleSetDimension.Unspecified,
                },
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                AttachmentType = gagve::ValueRuleSetAttachmentTypeEnum.Types.ValueRuleSetAttachmentType.Unspecified,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Status = gagve::ConversionValueRuleSetStatusEnum.Types.ConversionValueRuleSetStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetConversionValueRuleSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionValueRuleSetServiceClient client = new ConversionValueRuleSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionValueRuleSet response = client.GetConversionValueRuleSet(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetConversionValueRuleSetRequestObjectAsync()
        {
            moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient>(moq::MockBehavior.Strict);
            GetConversionValueRuleSetRequest request = new GetConversionValueRuleSetRequest
            {
                ResourceNameAsConversionValueRuleSetName = gagvr::ConversionValueRuleSetName.FromCustomerConversionValueRuleSet("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_SET_ID]"),
            };
            gagvr::ConversionValueRuleSet expectedResponse = new gagvr::ConversionValueRuleSet
            {
                ResourceNameAsConversionValueRuleSetName = gagvr::ConversionValueRuleSetName.FromCustomerConversionValueRuleSet("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_SET_ID]"),
                Id = -6774108720365892680L,
                ConversionValueRulesAsConversionValueRuleNames =
                {
                    gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
                },
                Dimensions =
                {
                    gagve::ValueRuleSetDimensionEnum.Types.ValueRuleSetDimension.Unspecified,
                },
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                AttachmentType = gagve::ValueRuleSetAttachmentTypeEnum.Types.ValueRuleSetAttachmentType.Unspecified,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Status = gagve::ConversionValueRuleSetStatusEnum.Types.ConversionValueRuleSetStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetConversionValueRuleSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ConversionValueRuleSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionValueRuleSetServiceClient client = new ConversionValueRuleSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionValueRuleSet responseCallSettings = await client.GetConversionValueRuleSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ConversionValueRuleSet responseCancellationToken = await client.GetConversionValueRuleSetAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetConversionValueRuleSet()
        {
            moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient>(moq::MockBehavior.Strict);
            GetConversionValueRuleSetRequest request = new GetConversionValueRuleSetRequest
            {
                ResourceNameAsConversionValueRuleSetName = gagvr::ConversionValueRuleSetName.FromCustomerConversionValueRuleSet("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_SET_ID]"),
            };
            gagvr::ConversionValueRuleSet expectedResponse = new gagvr::ConversionValueRuleSet
            {
                ResourceNameAsConversionValueRuleSetName = gagvr::ConversionValueRuleSetName.FromCustomerConversionValueRuleSet("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_SET_ID]"),
                Id = -6774108720365892680L,
                ConversionValueRulesAsConversionValueRuleNames =
                {
                    gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
                },
                Dimensions =
                {
                    gagve::ValueRuleSetDimensionEnum.Types.ValueRuleSetDimension.Unspecified,
                },
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                AttachmentType = gagve::ValueRuleSetAttachmentTypeEnum.Types.ValueRuleSetAttachmentType.Unspecified,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Status = gagve::ConversionValueRuleSetStatusEnum.Types.ConversionValueRuleSetStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetConversionValueRuleSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionValueRuleSetServiceClient client = new ConversionValueRuleSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionValueRuleSet response = client.GetConversionValueRuleSet(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetConversionValueRuleSetAsync()
        {
            moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient>(moq::MockBehavior.Strict);
            GetConversionValueRuleSetRequest request = new GetConversionValueRuleSetRequest
            {
                ResourceNameAsConversionValueRuleSetName = gagvr::ConversionValueRuleSetName.FromCustomerConversionValueRuleSet("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_SET_ID]"),
            };
            gagvr::ConversionValueRuleSet expectedResponse = new gagvr::ConversionValueRuleSet
            {
                ResourceNameAsConversionValueRuleSetName = gagvr::ConversionValueRuleSetName.FromCustomerConversionValueRuleSet("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_SET_ID]"),
                Id = -6774108720365892680L,
                ConversionValueRulesAsConversionValueRuleNames =
                {
                    gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
                },
                Dimensions =
                {
                    gagve::ValueRuleSetDimensionEnum.Types.ValueRuleSetDimension.Unspecified,
                },
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                AttachmentType = gagve::ValueRuleSetAttachmentTypeEnum.Types.ValueRuleSetAttachmentType.Unspecified,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Status = gagve::ConversionValueRuleSetStatusEnum.Types.ConversionValueRuleSetStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetConversionValueRuleSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ConversionValueRuleSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionValueRuleSetServiceClient client = new ConversionValueRuleSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionValueRuleSet responseCallSettings = await client.GetConversionValueRuleSetAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ConversionValueRuleSet responseCancellationToken = await client.GetConversionValueRuleSetAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetConversionValueRuleSetResourceNames()
        {
            moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient>(moq::MockBehavior.Strict);
            GetConversionValueRuleSetRequest request = new GetConversionValueRuleSetRequest
            {
                ResourceNameAsConversionValueRuleSetName = gagvr::ConversionValueRuleSetName.FromCustomerConversionValueRuleSet("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_SET_ID]"),
            };
            gagvr::ConversionValueRuleSet expectedResponse = new gagvr::ConversionValueRuleSet
            {
                ResourceNameAsConversionValueRuleSetName = gagvr::ConversionValueRuleSetName.FromCustomerConversionValueRuleSet("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_SET_ID]"),
                Id = -6774108720365892680L,
                ConversionValueRulesAsConversionValueRuleNames =
                {
                    gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
                },
                Dimensions =
                {
                    gagve::ValueRuleSetDimensionEnum.Types.ValueRuleSetDimension.Unspecified,
                },
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                AttachmentType = gagve::ValueRuleSetAttachmentTypeEnum.Types.ValueRuleSetAttachmentType.Unspecified,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Status = gagve::ConversionValueRuleSetStatusEnum.Types.ConversionValueRuleSetStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetConversionValueRuleSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionValueRuleSetServiceClient client = new ConversionValueRuleSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionValueRuleSet response = client.GetConversionValueRuleSet(request.ResourceNameAsConversionValueRuleSetName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetConversionValueRuleSetResourceNamesAsync()
        {
            moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient>(moq::MockBehavior.Strict);
            GetConversionValueRuleSetRequest request = new GetConversionValueRuleSetRequest
            {
                ResourceNameAsConversionValueRuleSetName = gagvr::ConversionValueRuleSetName.FromCustomerConversionValueRuleSet("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_SET_ID]"),
            };
            gagvr::ConversionValueRuleSet expectedResponse = new gagvr::ConversionValueRuleSet
            {
                ResourceNameAsConversionValueRuleSetName = gagvr::ConversionValueRuleSetName.FromCustomerConversionValueRuleSet("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_SET_ID]"),
                Id = -6774108720365892680L,
                ConversionValueRulesAsConversionValueRuleNames =
                {
                    gagvr::ConversionValueRuleName.FromCustomerConversionValueRule("[CUSTOMER_ID]", "[CONVERSION_VALUE_RULE_ID]"),
                },
                Dimensions =
                {
                    gagve::ValueRuleSetDimensionEnum.Types.ValueRuleSetDimension.Unspecified,
                },
                OwnerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                AttachmentType = gagve::ValueRuleSetAttachmentTypeEnum.Types.ValueRuleSetAttachmentType.Unspecified,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Status = gagve::ConversionValueRuleSetStatusEnum.Types.ConversionValueRuleSetStatus.Paused,
            };
            mockGrpcClient.Setup(x => x.GetConversionValueRuleSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ConversionValueRuleSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionValueRuleSetServiceClient client = new ConversionValueRuleSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ConversionValueRuleSet responseCallSettings = await client.GetConversionValueRuleSetAsync(request.ResourceNameAsConversionValueRuleSetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ConversionValueRuleSet responseCancellationToken = await client.GetConversionValueRuleSetAsync(request.ResourceNameAsConversionValueRuleSetName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateConversionValueRuleSetsRequestObject()
        {
            moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient>(moq::MockBehavior.Strict);
            MutateConversionValueRuleSetsRequest request = new MutateConversionValueRuleSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionValueRuleSetOperation(),
                },
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
                PartialFailure = false,
            };
            MutateConversionValueRuleSetsResponse expectedResponse = new MutateConversionValueRuleSetsResponse
            {
                Results =
                {
                    new MutateConversionValueRuleSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionValueRuleSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionValueRuleSetServiceClient client = new ConversionValueRuleSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionValueRuleSetsResponse response = client.MutateConversionValueRuleSets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateConversionValueRuleSetsRequestObjectAsync()
        {
            moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient>(moq::MockBehavior.Strict);
            MutateConversionValueRuleSetsRequest request = new MutateConversionValueRuleSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionValueRuleSetOperation(),
                },
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
                PartialFailure = false,
            };
            MutateConversionValueRuleSetsResponse expectedResponse = new MutateConversionValueRuleSetsResponse
            {
                Results =
                {
                    new MutateConversionValueRuleSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionValueRuleSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateConversionValueRuleSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionValueRuleSetServiceClient client = new ConversionValueRuleSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionValueRuleSetsResponse responseCallSettings = await client.MutateConversionValueRuleSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateConversionValueRuleSetsResponse responseCancellationToken = await client.MutateConversionValueRuleSetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateConversionValueRuleSets()
        {
            moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient>(moq::MockBehavior.Strict);
            MutateConversionValueRuleSetsRequest request = new MutateConversionValueRuleSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionValueRuleSetOperation(),
                },
            };
            MutateConversionValueRuleSetsResponse expectedResponse = new MutateConversionValueRuleSetsResponse
            {
                Results =
                {
                    new MutateConversionValueRuleSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionValueRuleSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionValueRuleSetServiceClient client = new ConversionValueRuleSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionValueRuleSetsResponse response = client.MutateConversionValueRuleSets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateConversionValueRuleSetsAsync()
        {
            moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient> mockGrpcClient = new moq::Mock<ConversionValueRuleSetService.ConversionValueRuleSetServiceClient>(moq::MockBehavior.Strict);
            MutateConversionValueRuleSetsRequest request = new MutateConversionValueRuleSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ConversionValueRuleSetOperation(),
                },
            };
            MutateConversionValueRuleSetsResponse expectedResponse = new MutateConversionValueRuleSetsResponse
            {
                Results =
                {
                    new MutateConversionValueRuleSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateConversionValueRuleSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateConversionValueRuleSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionValueRuleSetServiceClient client = new ConversionValueRuleSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionValueRuleSetsResponse responseCallSettings = await client.MutateConversionValueRuleSetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateConversionValueRuleSetsResponse responseCancellationToken = await client.MutateConversionValueRuleSetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

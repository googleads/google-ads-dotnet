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
    public sealed class GeneratedKeywordPlanAdGroupServiceClientTest
    {
        [Test]
        public void GetKeywordPlanAdGroupRequestObject()
        {
            moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanAdGroupRequest request = new GetKeywordPlanAdGroupRequest
            {
                ResourceNameAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
            };
            gagvr::KeywordPlanAdGroup expectedResponse = new gagvr::KeywordPlanAdGroup
            {
                ResourceNameAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                KeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                CpcBidMicros = 7321761304249472746L,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAdGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanAdGroup response = client.GetKeywordPlanAdGroup(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetKeywordPlanAdGroupRequestObjectAsync()
        {
            moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanAdGroupRequest request = new GetKeywordPlanAdGroupRequest
            {
                ResourceNameAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
            };
            gagvr::KeywordPlanAdGroup expectedResponse = new gagvr::KeywordPlanAdGroup
            {
                ResourceNameAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                KeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                CpcBidMicros = 7321761304249472746L,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAdGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanAdGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanAdGroup responseCallSettings = await client.GetKeywordPlanAdGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanAdGroup responseCancellationToken = await client.GetKeywordPlanAdGroupAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetKeywordPlanAdGroup()
        {
            moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanAdGroupRequest request = new GetKeywordPlanAdGroupRequest
            {
                ResourceNameAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
            };
            gagvr::KeywordPlanAdGroup expectedResponse = new gagvr::KeywordPlanAdGroup
            {
                ResourceNameAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                KeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                CpcBidMicros = 7321761304249472746L,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAdGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanAdGroup response = client.GetKeywordPlanAdGroup(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetKeywordPlanAdGroupAsync()
        {
            moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanAdGroupRequest request = new GetKeywordPlanAdGroupRequest
            {
                ResourceNameAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
            };
            gagvr::KeywordPlanAdGroup expectedResponse = new gagvr::KeywordPlanAdGroup
            {
                ResourceNameAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                KeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                CpcBidMicros = 7321761304249472746L,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAdGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanAdGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanAdGroup responseCallSettings = await client.GetKeywordPlanAdGroupAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanAdGroup responseCancellationToken = await client.GetKeywordPlanAdGroupAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetKeywordPlanAdGroupResourceNames()
        {
            moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanAdGroupRequest request = new GetKeywordPlanAdGroupRequest
            {
                ResourceNameAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
            };
            gagvr::KeywordPlanAdGroup expectedResponse = new gagvr::KeywordPlanAdGroup
            {
                ResourceNameAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                KeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                CpcBidMicros = 7321761304249472746L,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAdGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanAdGroup response = client.GetKeywordPlanAdGroup(request.ResourceNameAsKeywordPlanAdGroupName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetKeywordPlanAdGroupResourceNamesAsync()
        {
            moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanAdGroupRequest request = new GetKeywordPlanAdGroupRequest
            {
                ResourceNameAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
            };
            gagvr::KeywordPlanAdGroup expectedResponse = new gagvr::KeywordPlanAdGroup
            {
                ResourceNameAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                KeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                CpcBidMicros = 7321761304249472746L,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAdGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanAdGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanAdGroup responseCallSettings = await client.GetKeywordPlanAdGroupAsync(request.ResourceNameAsKeywordPlanAdGroupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanAdGroup responseCancellationToken = await client.GetKeywordPlanAdGroupAsync(request.ResourceNameAsKeywordPlanAdGroupName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateKeywordPlanAdGroupsRequestObject()
        {
            moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanAdGroupsRequest request = new MutateKeywordPlanAdGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanAdGroupOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateKeywordPlanAdGroupsResponse expectedResponse = new MutateKeywordPlanAdGroupsResponse
            {
                Results =
                {
                    new MutateKeywordPlanAdGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanAdGroups(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanAdGroupsResponse response = client.MutateKeywordPlanAdGroups(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateKeywordPlanAdGroupsRequestObjectAsync()
        {
            moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanAdGroupsRequest request = new MutateKeywordPlanAdGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanAdGroupOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateKeywordPlanAdGroupsResponse expectedResponse = new MutateKeywordPlanAdGroupsResponse
            {
                Results =
                {
                    new MutateKeywordPlanAdGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanAdGroupsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateKeywordPlanAdGroupsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanAdGroupsResponse responseCallSettings = await client.MutateKeywordPlanAdGroupsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateKeywordPlanAdGroupsResponse responseCancellationToken = await client.MutateKeywordPlanAdGroupsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateKeywordPlanAdGroups()
        {
            moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanAdGroupsRequest request = new MutateKeywordPlanAdGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanAdGroupOperation(),
                },
            };
            MutateKeywordPlanAdGroupsResponse expectedResponse = new MutateKeywordPlanAdGroupsResponse
            {
                Results =
                {
                    new MutateKeywordPlanAdGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanAdGroups(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanAdGroupsResponse response = client.MutateKeywordPlanAdGroups(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateKeywordPlanAdGroupsAsync()
        {
            moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanAdGroupsRequest request = new MutateKeywordPlanAdGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanAdGroupOperation(),
                },
            };
            MutateKeywordPlanAdGroupsResponse expectedResponse = new MutateKeywordPlanAdGroupsResponse
            {
                Results =
                {
                    new MutateKeywordPlanAdGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanAdGroupsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateKeywordPlanAdGroupsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanAdGroupsResponse responseCallSettings = await client.MutateKeywordPlanAdGroupsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateKeywordPlanAdGroupsResponse responseCancellationToken = await client.MutateKeywordPlanAdGroupsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

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

using gagve = Google.Ads.GoogleAds.V3.Enums;
using gagvr = Google.Ads.GoogleAds.V3.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V3.Services;

namespace Google.Ads.GoogleAds.Tests.V3.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedKeywordPlanNegativeKeywordServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetKeywordPlanNegativeKeywordRequestObject()
        {
            moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanNegativeKeywordRequest request = new GetKeywordPlanNegativeKeywordRequest
            {
                ResourceNameAsKeywordPlanNegativeKeywordName = gagvr::KeywordPlanNegativeKeywordName.FromCustomerKeywordPlanNegativeKeyword("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]"),
            };
            gagvr::KeywordPlanNegativeKeyword expectedResponse = new gagvr::KeywordPlanNegativeKeyword
            {
                ResourceNameAsKeywordPlanNegativeKeywordName = gagvr::KeywordPlanNegativeKeywordName.FromCustomerKeywordPlanNegativeKeyword("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanNegativeKeyword(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanNegativeKeyword response = client.GetKeywordPlanNegativeKeyword(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanNegativeKeywordRequestObjectAsync()
        {
            moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanNegativeKeywordRequest request = new GetKeywordPlanNegativeKeywordRequest
            {
                ResourceNameAsKeywordPlanNegativeKeywordName = gagvr::KeywordPlanNegativeKeywordName.FromCustomerKeywordPlanNegativeKeyword("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]"),
            };
            gagvr::KeywordPlanNegativeKeyword expectedResponse = new gagvr::KeywordPlanNegativeKeyword
            {
                ResourceNameAsKeywordPlanNegativeKeywordName = gagvr::KeywordPlanNegativeKeywordName.FromCustomerKeywordPlanNegativeKeyword("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanNegativeKeywordAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanNegativeKeyword>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanNegativeKeyword responseCallSettings = await client.GetKeywordPlanNegativeKeywordAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanNegativeKeyword responseCancellationToken = await client.GetKeywordPlanNegativeKeywordAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetKeywordPlanNegativeKeyword()
        {
            moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanNegativeKeywordRequest request = new GetKeywordPlanNegativeKeywordRequest
            {
                ResourceNameAsKeywordPlanNegativeKeywordName = gagvr::KeywordPlanNegativeKeywordName.FromCustomerKeywordPlanNegativeKeyword("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]"),
            };
            gagvr::KeywordPlanNegativeKeyword expectedResponse = new gagvr::KeywordPlanNegativeKeyword
            {
                ResourceNameAsKeywordPlanNegativeKeywordName = gagvr::KeywordPlanNegativeKeywordName.FromCustomerKeywordPlanNegativeKeyword("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanNegativeKeyword(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanNegativeKeyword response = client.GetKeywordPlanNegativeKeyword(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanNegativeKeywordAsync()
        {
            moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanNegativeKeywordRequest request = new GetKeywordPlanNegativeKeywordRequest
            {
                ResourceNameAsKeywordPlanNegativeKeywordName = gagvr::KeywordPlanNegativeKeywordName.FromCustomerKeywordPlanNegativeKeyword("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]"),
            };
            gagvr::KeywordPlanNegativeKeyword expectedResponse = new gagvr::KeywordPlanNegativeKeyword
            {
                ResourceNameAsKeywordPlanNegativeKeywordName = gagvr::KeywordPlanNegativeKeywordName.FromCustomerKeywordPlanNegativeKeyword("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanNegativeKeywordAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanNegativeKeyword>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanNegativeKeyword responseCallSettings = await client.GetKeywordPlanNegativeKeywordAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanNegativeKeyword responseCancellationToken = await client.GetKeywordPlanNegativeKeywordAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetKeywordPlanNegativeKeywordResourceNames()
        {
            moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanNegativeKeywordRequest request = new GetKeywordPlanNegativeKeywordRequest
            {
                ResourceNameAsKeywordPlanNegativeKeywordName = gagvr::KeywordPlanNegativeKeywordName.FromCustomerKeywordPlanNegativeKeyword("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]"),
            };
            gagvr::KeywordPlanNegativeKeyword expectedResponse = new gagvr::KeywordPlanNegativeKeyword
            {
                ResourceNameAsKeywordPlanNegativeKeywordName = gagvr::KeywordPlanNegativeKeywordName.FromCustomerKeywordPlanNegativeKeyword("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanNegativeKeyword(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanNegativeKeyword response = client.GetKeywordPlanNegativeKeyword(request.ResourceNameAsKeywordPlanNegativeKeywordName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanNegativeKeywordResourceNamesAsync()
        {
            moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanNegativeKeywordRequest request = new GetKeywordPlanNegativeKeywordRequest
            {
                ResourceNameAsKeywordPlanNegativeKeywordName = gagvr::KeywordPlanNegativeKeywordName.FromCustomerKeywordPlanNegativeKeyword("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]"),
            };
            gagvr::KeywordPlanNegativeKeyword expectedResponse = new gagvr::KeywordPlanNegativeKeyword
            {
                ResourceNameAsKeywordPlanNegativeKeywordName = gagvr::KeywordPlanNegativeKeywordName.FromCustomerKeywordPlanNegativeKeyword("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanNegativeKeywordAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanNegativeKeyword>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanNegativeKeyword responseCallSettings = await client.GetKeywordPlanNegativeKeywordAsync(request.ResourceNameAsKeywordPlanNegativeKeywordName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanNegativeKeyword responseCancellationToken = await client.GetKeywordPlanNegativeKeywordAsync(request.ResourceNameAsKeywordPlanNegativeKeywordName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateKeywordPlanNegativeKeywordsRequestObject()
        {
            moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanNegativeKeywordsRequest request = new MutateKeywordPlanNegativeKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanNegativeKeywordOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateKeywordPlanNegativeKeywordsResponse expectedResponse = new MutateKeywordPlanNegativeKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanNegativeKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanNegativeKeywords(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanNegativeKeywordsResponse response = client.MutateKeywordPlanNegativeKeywords(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateKeywordPlanNegativeKeywordsRequestObjectAsync()
        {
            moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanNegativeKeywordsRequest request = new MutateKeywordPlanNegativeKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanNegativeKeywordOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateKeywordPlanNegativeKeywordsResponse expectedResponse = new MutateKeywordPlanNegativeKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanNegativeKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanNegativeKeywordsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateKeywordPlanNegativeKeywordsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanNegativeKeywordsResponse responseCallSettings = await client.MutateKeywordPlanNegativeKeywordsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateKeywordPlanNegativeKeywordsResponse responseCancellationToken = await client.MutateKeywordPlanNegativeKeywordsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateKeywordPlanNegativeKeywords()
        {
            moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanNegativeKeywordsRequest request = new MutateKeywordPlanNegativeKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanNegativeKeywordOperation(),
                },
            };
            MutateKeywordPlanNegativeKeywordsResponse expectedResponse = new MutateKeywordPlanNegativeKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanNegativeKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanNegativeKeywords(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanNegativeKeywordsResponse response = client.MutateKeywordPlanNegativeKeywords(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateKeywordPlanNegativeKeywordsAsync()
        {
            moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanNegativeKeywordsRequest request = new MutateKeywordPlanNegativeKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanNegativeKeywordOperation(),
                },
            };
            MutateKeywordPlanNegativeKeywordsResponse expectedResponse = new MutateKeywordPlanNegativeKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanNegativeKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanNegativeKeywordsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateKeywordPlanNegativeKeywordsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanNegativeKeywordsResponse responseCallSettings = await client.MutateKeywordPlanNegativeKeywordsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateKeywordPlanNegativeKeywordsResponse responseCancellationToken = await client.MutateKeywordPlanNegativeKeywordsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

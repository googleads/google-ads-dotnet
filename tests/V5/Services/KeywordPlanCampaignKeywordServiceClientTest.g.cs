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

using gagve = Google.Ads.GoogleAds.V5.Enums;
using gagvr = Google.Ads.GoogleAds.V5.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V5.Services;

namespace Google.Ads.GoogleAds.Tests.V5.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedKeywordPlanCampaignKeywordServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetKeywordPlanCampaignKeywordRequestObject()
        {
            moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanCampaignKeywordRequest request = new GetKeywordPlanCampaignKeywordRequest
            {
                ResourceNameAsKeywordPlanCampaignKeywordName = gagvr::KeywordPlanCampaignKeywordName.FromCustomerKeywordPlanCampaignKeyword("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN_KEYWORD]"),
            };
            gagvr::KeywordPlanCampaignKeyword expectedResponse = new gagvr::KeywordPlanCampaignKeyword
            {
                ResourceNameAsKeywordPlanCampaignKeywordName = gagvr::KeywordPlanCampaignKeywordName.FromCustomerKeywordPlanCampaignKeyword("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN_KEYWORD]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanCampaignKeyword(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanCampaignKeywordServiceClient client = new KeywordPlanCampaignKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanCampaignKeyword response = client.GetKeywordPlanCampaignKeyword(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanCampaignKeywordRequestObjectAsync()
        {
            moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanCampaignKeywordRequest request = new GetKeywordPlanCampaignKeywordRequest
            {
                ResourceNameAsKeywordPlanCampaignKeywordName = gagvr::KeywordPlanCampaignKeywordName.FromCustomerKeywordPlanCampaignKeyword("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN_KEYWORD]"),
            };
            gagvr::KeywordPlanCampaignKeyword expectedResponse = new gagvr::KeywordPlanCampaignKeyword
            {
                ResourceNameAsKeywordPlanCampaignKeywordName = gagvr::KeywordPlanCampaignKeywordName.FromCustomerKeywordPlanCampaignKeyword("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN_KEYWORD]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanCampaignKeywordAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanCampaignKeyword>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanCampaignKeywordServiceClient client = new KeywordPlanCampaignKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanCampaignKeyword responseCallSettings = await client.GetKeywordPlanCampaignKeywordAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanCampaignKeyword responseCancellationToken = await client.GetKeywordPlanCampaignKeywordAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetKeywordPlanCampaignKeyword()
        {
            moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanCampaignKeywordRequest request = new GetKeywordPlanCampaignKeywordRequest
            {
                ResourceNameAsKeywordPlanCampaignKeywordName = gagvr::KeywordPlanCampaignKeywordName.FromCustomerKeywordPlanCampaignKeyword("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN_KEYWORD]"),
            };
            gagvr::KeywordPlanCampaignKeyword expectedResponse = new gagvr::KeywordPlanCampaignKeyword
            {
                ResourceNameAsKeywordPlanCampaignKeywordName = gagvr::KeywordPlanCampaignKeywordName.FromCustomerKeywordPlanCampaignKeyword("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN_KEYWORD]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanCampaignKeyword(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanCampaignKeywordServiceClient client = new KeywordPlanCampaignKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanCampaignKeyword response = client.GetKeywordPlanCampaignKeyword(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanCampaignKeywordAsync()
        {
            moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanCampaignKeywordRequest request = new GetKeywordPlanCampaignKeywordRequest
            {
                ResourceNameAsKeywordPlanCampaignKeywordName = gagvr::KeywordPlanCampaignKeywordName.FromCustomerKeywordPlanCampaignKeyword("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN_KEYWORD]"),
            };
            gagvr::KeywordPlanCampaignKeyword expectedResponse = new gagvr::KeywordPlanCampaignKeyword
            {
                ResourceNameAsKeywordPlanCampaignKeywordName = gagvr::KeywordPlanCampaignKeywordName.FromCustomerKeywordPlanCampaignKeyword("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN_KEYWORD]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanCampaignKeywordAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanCampaignKeyword>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanCampaignKeywordServiceClient client = new KeywordPlanCampaignKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanCampaignKeyword responseCallSettings = await client.GetKeywordPlanCampaignKeywordAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanCampaignKeyword responseCancellationToken = await client.GetKeywordPlanCampaignKeywordAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetKeywordPlanCampaignKeywordResourceNames()
        {
            moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanCampaignKeywordRequest request = new GetKeywordPlanCampaignKeywordRequest
            {
                ResourceNameAsKeywordPlanCampaignKeywordName = gagvr::KeywordPlanCampaignKeywordName.FromCustomerKeywordPlanCampaignKeyword("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN_KEYWORD]"),
            };
            gagvr::KeywordPlanCampaignKeyword expectedResponse = new gagvr::KeywordPlanCampaignKeyword
            {
                ResourceNameAsKeywordPlanCampaignKeywordName = gagvr::KeywordPlanCampaignKeywordName.FromCustomerKeywordPlanCampaignKeyword("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN_KEYWORD]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanCampaignKeyword(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanCampaignKeywordServiceClient client = new KeywordPlanCampaignKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanCampaignKeyword response = client.GetKeywordPlanCampaignKeyword(request.ResourceNameAsKeywordPlanCampaignKeywordName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanCampaignKeywordResourceNamesAsync()
        {
            moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanCampaignKeywordRequest request = new GetKeywordPlanCampaignKeywordRequest
            {
                ResourceNameAsKeywordPlanCampaignKeywordName = gagvr::KeywordPlanCampaignKeywordName.FromCustomerKeywordPlanCampaignKeyword("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN_KEYWORD]"),
            };
            gagvr::KeywordPlanCampaignKeyword expectedResponse = new gagvr::KeywordPlanCampaignKeyword
            {
                ResourceNameAsKeywordPlanCampaignKeywordName = gagvr::KeywordPlanCampaignKeywordName.FromCustomerKeywordPlanCampaignKeyword("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN_KEYWORD]"),
                KeywordPlanCampaignAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanCampaignKeywordAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanCampaignKeyword>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanCampaignKeywordServiceClient client = new KeywordPlanCampaignKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanCampaignKeyword responseCallSettings = await client.GetKeywordPlanCampaignKeywordAsync(request.ResourceNameAsKeywordPlanCampaignKeywordName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanCampaignKeyword responseCancellationToken = await client.GetKeywordPlanCampaignKeywordAsync(request.ResourceNameAsKeywordPlanCampaignKeywordName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateKeywordPlanCampaignKeywordsRequestObject()
        {
            moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanCampaignKeywordsRequest request = new MutateKeywordPlanCampaignKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanCampaignKeywordOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateKeywordPlanCampaignKeywordsResponse expectedResponse = new MutateKeywordPlanCampaignKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanCampaignKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanCampaignKeywords(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanCampaignKeywordServiceClient client = new KeywordPlanCampaignKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanCampaignKeywordsResponse response = client.MutateKeywordPlanCampaignKeywords(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateKeywordPlanCampaignKeywordsRequestObjectAsync()
        {
            moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanCampaignKeywordsRequest request = new MutateKeywordPlanCampaignKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanCampaignKeywordOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateKeywordPlanCampaignKeywordsResponse expectedResponse = new MutateKeywordPlanCampaignKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanCampaignKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanCampaignKeywordsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateKeywordPlanCampaignKeywordsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanCampaignKeywordServiceClient client = new KeywordPlanCampaignKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanCampaignKeywordsResponse responseCallSettings = await client.MutateKeywordPlanCampaignKeywordsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateKeywordPlanCampaignKeywordsResponse responseCancellationToken = await client.MutateKeywordPlanCampaignKeywordsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateKeywordPlanCampaignKeywords()
        {
            moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanCampaignKeywordsRequest request = new MutateKeywordPlanCampaignKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanCampaignKeywordOperation(),
                },
            };
            MutateKeywordPlanCampaignKeywordsResponse expectedResponse = new MutateKeywordPlanCampaignKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanCampaignKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanCampaignKeywords(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanCampaignKeywordServiceClient client = new KeywordPlanCampaignKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanCampaignKeywordsResponse response = client.MutateKeywordPlanCampaignKeywords(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateKeywordPlanCampaignKeywordsAsync()
        {
            moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanCampaignKeywordsRequest request = new MutateKeywordPlanCampaignKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanCampaignKeywordOperation(),
                },
            };
            MutateKeywordPlanCampaignKeywordsResponse expectedResponse = new MutateKeywordPlanCampaignKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanCampaignKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanCampaignKeywordsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateKeywordPlanCampaignKeywordsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanCampaignKeywordServiceClient client = new KeywordPlanCampaignKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanCampaignKeywordsResponse responseCallSettings = await client.MutateKeywordPlanCampaignKeywordsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateKeywordPlanCampaignKeywordsResponse responseCancellationToken = await client.MutateKeywordPlanCampaignKeywordsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

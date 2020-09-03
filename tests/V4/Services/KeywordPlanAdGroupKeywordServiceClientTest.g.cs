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

using gagve = Google.Ads.GoogleAds.V4.Enums;
using gagvr = Google.Ads.GoogleAds.V4.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V4.Services;

namespace Google.Ads.GoogleAds.Tests.V4.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedKeywordPlanAdGroupKeywordServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetKeywordPlanAdGroupKeywordRequestObject()
        {
            moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanAdGroupKeywordRequest request = new GetKeywordPlanAdGroupKeywordRequest
            {
                ResourceNameAsKeywordPlanAdGroupKeywordName = gagvr::KeywordPlanAdGroupKeywordName.FromCustomerKeywordPlanAdGroupKeyword("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP_KEYWORD]"),
            };
            gagvr::KeywordPlanAdGroupKeyword expectedResponse = new gagvr::KeywordPlanAdGroupKeyword
            {
                ResourceNameAsKeywordPlanAdGroupKeywordName = gagvr::KeywordPlanAdGroupKeywordName.FromCustomerKeywordPlanAdGroupKeyword("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP_KEYWORD]"),
                KeywordPlanAdGroupAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                CpcBidMicros = 7321761304249472746L,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAdGroupKeyword(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanAdGroupKeywordServiceClient client = new KeywordPlanAdGroupKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanAdGroupKeyword response = client.GetKeywordPlanAdGroupKeyword(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanAdGroupKeywordRequestObjectAsync()
        {
            moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanAdGroupKeywordRequest request = new GetKeywordPlanAdGroupKeywordRequest
            {
                ResourceNameAsKeywordPlanAdGroupKeywordName = gagvr::KeywordPlanAdGroupKeywordName.FromCustomerKeywordPlanAdGroupKeyword("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP_KEYWORD]"),
            };
            gagvr::KeywordPlanAdGroupKeyword expectedResponse = new gagvr::KeywordPlanAdGroupKeyword
            {
                ResourceNameAsKeywordPlanAdGroupKeywordName = gagvr::KeywordPlanAdGroupKeywordName.FromCustomerKeywordPlanAdGroupKeyword("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP_KEYWORD]"),
                KeywordPlanAdGroupAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                CpcBidMicros = 7321761304249472746L,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAdGroupKeywordAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanAdGroupKeyword>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanAdGroupKeywordServiceClient client = new KeywordPlanAdGroupKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanAdGroupKeyword responseCallSettings = await client.GetKeywordPlanAdGroupKeywordAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanAdGroupKeyword responseCancellationToken = await client.GetKeywordPlanAdGroupKeywordAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetKeywordPlanAdGroupKeyword()
        {
            moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanAdGroupKeywordRequest request = new GetKeywordPlanAdGroupKeywordRequest
            {
                ResourceNameAsKeywordPlanAdGroupKeywordName = gagvr::KeywordPlanAdGroupKeywordName.FromCustomerKeywordPlanAdGroupKeyword("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP_KEYWORD]"),
            };
            gagvr::KeywordPlanAdGroupKeyword expectedResponse = new gagvr::KeywordPlanAdGroupKeyword
            {
                ResourceNameAsKeywordPlanAdGroupKeywordName = gagvr::KeywordPlanAdGroupKeywordName.FromCustomerKeywordPlanAdGroupKeyword("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP_KEYWORD]"),
                KeywordPlanAdGroupAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                CpcBidMicros = 7321761304249472746L,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAdGroupKeyword(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanAdGroupKeywordServiceClient client = new KeywordPlanAdGroupKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanAdGroupKeyword response = client.GetKeywordPlanAdGroupKeyword(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanAdGroupKeywordAsync()
        {
            moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanAdGroupKeywordRequest request = new GetKeywordPlanAdGroupKeywordRequest
            {
                ResourceNameAsKeywordPlanAdGroupKeywordName = gagvr::KeywordPlanAdGroupKeywordName.FromCustomerKeywordPlanAdGroupKeyword("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP_KEYWORD]"),
            };
            gagvr::KeywordPlanAdGroupKeyword expectedResponse = new gagvr::KeywordPlanAdGroupKeyword
            {
                ResourceNameAsKeywordPlanAdGroupKeywordName = gagvr::KeywordPlanAdGroupKeywordName.FromCustomerKeywordPlanAdGroupKeyword("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP_KEYWORD]"),
                KeywordPlanAdGroupAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                CpcBidMicros = 7321761304249472746L,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAdGroupKeywordAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanAdGroupKeyword>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanAdGroupKeywordServiceClient client = new KeywordPlanAdGroupKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanAdGroupKeyword responseCallSettings = await client.GetKeywordPlanAdGroupKeywordAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanAdGroupKeyword responseCancellationToken = await client.GetKeywordPlanAdGroupKeywordAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetKeywordPlanAdGroupKeywordResourceNames()
        {
            moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanAdGroupKeywordRequest request = new GetKeywordPlanAdGroupKeywordRequest
            {
                ResourceNameAsKeywordPlanAdGroupKeywordName = gagvr::KeywordPlanAdGroupKeywordName.FromCustomerKeywordPlanAdGroupKeyword("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP_KEYWORD]"),
            };
            gagvr::KeywordPlanAdGroupKeyword expectedResponse = new gagvr::KeywordPlanAdGroupKeyword
            {
                ResourceNameAsKeywordPlanAdGroupKeywordName = gagvr::KeywordPlanAdGroupKeywordName.FromCustomerKeywordPlanAdGroupKeyword("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP_KEYWORD]"),
                KeywordPlanAdGroupAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                CpcBidMicros = 7321761304249472746L,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAdGroupKeyword(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanAdGroupKeywordServiceClient client = new KeywordPlanAdGroupKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanAdGroupKeyword response = client.GetKeywordPlanAdGroupKeyword(request.ResourceNameAsKeywordPlanAdGroupKeywordName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanAdGroupKeywordResourceNamesAsync()
        {
            moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanAdGroupKeywordRequest request = new GetKeywordPlanAdGroupKeywordRequest
            {
                ResourceNameAsKeywordPlanAdGroupKeywordName = gagvr::KeywordPlanAdGroupKeywordName.FromCustomerKeywordPlanAdGroupKeyword("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP_KEYWORD]"),
            };
            gagvr::KeywordPlanAdGroupKeyword expectedResponse = new gagvr::KeywordPlanAdGroupKeyword
            {
                ResourceNameAsKeywordPlanAdGroupKeywordName = gagvr::KeywordPlanAdGroupKeywordName.FromCustomerKeywordPlanAdGroupKeyword("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP_KEYWORD]"),
                KeywordPlanAdGroupAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                CpcBidMicros = 7321761304249472746L,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAdGroupKeywordAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanAdGroupKeyword>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanAdGroupKeywordServiceClient client = new KeywordPlanAdGroupKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanAdGroupKeyword responseCallSettings = await client.GetKeywordPlanAdGroupKeywordAsync(request.ResourceNameAsKeywordPlanAdGroupKeywordName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanAdGroupKeyword responseCancellationToken = await client.GetKeywordPlanAdGroupKeywordAsync(request.ResourceNameAsKeywordPlanAdGroupKeywordName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateKeywordPlanAdGroupKeywordsRequestObject()
        {
            moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanAdGroupKeywordsRequest request = new MutateKeywordPlanAdGroupKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanAdGroupKeywordOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateKeywordPlanAdGroupKeywordsResponse expectedResponse = new MutateKeywordPlanAdGroupKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanAdGroupKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanAdGroupKeywords(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanAdGroupKeywordServiceClient client = new KeywordPlanAdGroupKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanAdGroupKeywordsResponse response = client.MutateKeywordPlanAdGroupKeywords(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateKeywordPlanAdGroupKeywordsRequestObjectAsync()
        {
            moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanAdGroupKeywordsRequest request = new MutateKeywordPlanAdGroupKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanAdGroupKeywordOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateKeywordPlanAdGroupKeywordsResponse expectedResponse = new MutateKeywordPlanAdGroupKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanAdGroupKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanAdGroupKeywordsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateKeywordPlanAdGroupKeywordsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanAdGroupKeywordServiceClient client = new KeywordPlanAdGroupKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanAdGroupKeywordsResponse responseCallSettings = await client.MutateKeywordPlanAdGroupKeywordsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateKeywordPlanAdGroupKeywordsResponse responseCancellationToken = await client.MutateKeywordPlanAdGroupKeywordsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateKeywordPlanAdGroupKeywords()
        {
            moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanAdGroupKeywordsRequest request = new MutateKeywordPlanAdGroupKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanAdGroupKeywordOperation(),
                },
            };
            MutateKeywordPlanAdGroupKeywordsResponse expectedResponse = new MutateKeywordPlanAdGroupKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanAdGroupKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanAdGroupKeywords(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanAdGroupKeywordServiceClient client = new KeywordPlanAdGroupKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanAdGroupKeywordsResponse response = client.MutateKeywordPlanAdGroupKeywords(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateKeywordPlanAdGroupKeywordsAsync()
        {
            moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanAdGroupKeywordsRequest request = new MutateKeywordPlanAdGroupKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanAdGroupKeywordOperation(),
                },
            };
            MutateKeywordPlanAdGroupKeywordsResponse expectedResponse = new MutateKeywordPlanAdGroupKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanAdGroupKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanAdGroupKeywordsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateKeywordPlanAdGroupKeywordsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanAdGroupKeywordServiceClient client = new KeywordPlanAdGroupKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanAdGroupKeywordsResponse responseCallSettings = await client.MutateKeywordPlanAdGroupKeywordsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateKeywordPlanAdGroupKeywordsResponse responseCancellationToken = await client.MutateKeywordPlanAdGroupKeywordsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

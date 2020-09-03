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
    public sealed class GeneratedKeywordPlanKeywordServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetKeywordPlanKeywordRequestObject()
        {
            moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanKeywordRequest request = new GetKeywordPlanKeywordRequest
            {
                ResourceNameAsKeywordPlanKeywordName = gagvr::KeywordPlanKeywordName.FromCustomerKeywordPlanKeyword("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]"),
            };
            gagvr::KeywordPlanKeyword expectedResponse = new gagvr::KeywordPlanKeyword
            {
                ResourceNameAsKeywordPlanKeywordName = gagvr::KeywordPlanKeywordName.FromCustomerKeywordPlanKeyword("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]"),
                KeywordPlanAdGroupAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                CpcBidMicros = 7321761304249472746L,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanKeyword(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanKeyword response = client.GetKeywordPlanKeyword(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanKeywordRequestObjectAsync()
        {
            moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanKeywordRequest request = new GetKeywordPlanKeywordRequest
            {
                ResourceNameAsKeywordPlanKeywordName = gagvr::KeywordPlanKeywordName.FromCustomerKeywordPlanKeyword("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]"),
            };
            gagvr::KeywordPlanKeyword expectedResponse = new gagvr::KeywordPlanKeyword
            {
                ResourceNameAsKeywordPlanKeywordName = gagvr::KeywordPlanKeywordName.FromCustomerKeywordPlanKeyword("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]"),
                KeywordPlanAdGroupAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                CpcBidMicros = 7321761304249472746L,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanKeywordAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanKeyword>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanKeyword responseCallSettings = await client.GetKeywordPlanKeywordAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanKeyword responseCancellationToken = await client.GetKeywordPlanKeywordAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetKeywordPlanKeyword()
        {
            moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanKeywordRequest request = new GetKeywordPlanKeywordRequest
            {
                ResourceNameAsKeywordPlanKeywordName = gagvr::KeywordPlanKeywordName.FromCustomerKeywordPlanKeyword("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]"),
            };
            gagvr::KeywordPlanKeyword expectedResponse = new gagvr::KeywordPlanKeyword
            {
                ResourceNameAsKeywordPlanKeywordName = gagvr::KeywordPlanKeywordName.FromCustomerKeywordPlanKeyword("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]"),
                KeywordPlanAdGroupAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                CpcBidMicros = 7321761304249472746L,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanKeyword(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanKeyword response = client.GetKeywordPlanKeyword(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanKeywordAsync()
        {
            moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanKeywordRequest request = new GetKeywordPlanKeywordRequest
            {
                ResourceNameAsKeywordPlanKeywordName = gagvr::KeywordPlanKeywordName.FromCustomerKeywordPlanKeyword("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]"),
            };
            gagvr::KeywordPlanKeyword expectedResponse = new gagvr::KeywordPlanKeyword
            {
                ResourceNameAsKeywordPlanKeywordName = gagvr::KeywordPlanKeywordName.FromCustomerKeywordPlanKeyword("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]"),
                KeywordPlanAdGroupAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                CpcBidMicros = 7321761304249472746L,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanKeywordAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanKeyword>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanKeyword responseCallSettings = await client.GetKeywordPlanKeywordAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanKeyword responseCancellationToken = await client.GetKeywordPlanKeywordAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetKeywordPlanKeywordResourceNames()
        {
            moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanKeywordRequest request = new GetKeywordPlanKeywordRequest
            {
                ResourceNameAsKeywordPlanKeywordName = gagvr::KeywordPlanKeywordName.FromCustomerKeywordPlanKeyword("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]"),
            };
            gagvr::KeywordPlanKeyword expectedResponse = new gagvr::KeywordPlanKeyword
            {
                ResourceNameAsKeywordPlanKeywordName = gagvr::KeywordPlanKeywordName.FromCustomerKeywordPlanKeyword("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]"),
                KeywordPlanAdGroupAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                CpcBidMicros = 7321761304249472746L,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanKeyword(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanKeyword response = client.GetKeywordPlanKeyword(request.ResourceNameAsKeywordPlanKeywordName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanKeywordResourceNamesAsync()
        {
            moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanKeywordRequest request = new GetKeywordPlanKeywordRequest
            {
                ResourceNameAsKeywordPlanKeywordName = gagvr::KeywordPlanKeywordName.FromCustomerKeywordPlanKeyword("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]"),
            };
            gagvr::KeywordPlanKeyword expectedResponse = new gagvr::KeywordPlanKeyword
            {
                ResourceNameAsKeywordPlanKeywordName = gagvr::KeywordPlanKeywordName.FromCustomerKeywordPlanKeyword("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]"),
                KeywordPlanAdGroupAsKeywordPlanAdGroupName = gagvr::KeywordPlanAdGroupName.FromCustomerKeywordPlanAdGroup("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]"),
                Id = -6774108720365892680L,
                Text = "textec51b21c",
                MatchType = gagve::KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified,
                CpcBidMicros = 7321761304249472746L,
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanKeywordAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanKeyword>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanKeyword responseCallSettings = await client.GetKeywordPlanKeywordAsync(request.ResourceNameAsKeywordPlanKeywordName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanKeyword responseCancellationToken = await client.GetKeywordPlanKeywordAsync(request.ResourceNameAsKeywordPlanKeywordName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateKeywordPlanKeywordsRequestObject()
        {
            moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanKeywordsRequest request = new MutateKeywordPlanKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanKeywordOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateKeywordPlanKeywordsResponse expectedResponse = new MutateKeywordPlanKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanKeywords(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanKeywordsResponse response = client.MutateKeywordPlanKeywords(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateKeywordPlanKeywordsRequestObjectAsync()
        {
            moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanKeywordsRequest request = new MutateKeywordPlanKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanKeywordOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateKeywordPlanKeywordsResponse expectedResponse = new MutateKeywordPlanKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanKeywordsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateKeywordPlanKeywordsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanKeywordsResponse responseCallSettings = await client.MutateKeywordPlanKeywordsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateKeywordPlanKeywordsResponse responseCancellationToken = await client.MutateKeywordPlanKeywordsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateKeywordPlanKeywords()
        {
            moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanKeywordsRequest request = new MutateKeywordPlanKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanKeywordOperation(),
                },
            };
            MutateKeywordPlanKeywordsResponse expectedResponse = new MutateKeywordPlanKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanKeywords(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanKeywordsResponse response = client.MutateKeywordPlanKeywords(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateKeywordPlanKeywordsAsync()
        {
            moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanKeywordsRequest request = new MutateKeywordPlanKeywordsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanKeywordOperation(),
                },
            };
            MutateKeywordPlanKeywordsResponse expectedResponse = new MutateKeywordPlanKeywordsResponse
            {
                Results =
                {
                    new MutateKeywordPlanKeywordResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanKeywordsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateKeywordPlanKeywordsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanKeywordsResponse responseCallSettings = await client.MutateKeywordPlanKeywordsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateKeywordPlanKeywordsResponse responseCancellationToken = await client.MutateKeywordPlanKeywordsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

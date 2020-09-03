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
    public sealed class GeneratedKeywordPlanCampaignServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetKeywordPlanCampaignRequestObject()
        {
            moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanCampaignRequest request = new GetKeywordPlanCampaignRequest
            {
                ResourceNameAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
            };
            gagvr::KeywordPlanCampaign expectedResponse = new gagvr::KeywordPlanCampaign
            {
                ResourceNameAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                KeywordPlanAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                Id = -6774108720365892680L,
                KeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                LanguageConstantsAsLanguageConstantNames =
                {
                    gagvr::LanguageConstantName.FromLanguageConstant("[LANGUAGE_CONSTANT]"),
                },
                KeywordPlanNetwork = gagve::KeywordPlanNetworkEnum.Types.KeywordPlanNetwork.Unspecified,
                CpcBidMicros = 7321761304249472746L,
                GeoTargets =
                {
                    new gagvr::KeywordPlanGeoTarget(),
                },
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanCampaign(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanCampaign response = client.GetKeywordPlanCampaign(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanCampaignRequestObjectAsync()
        {
            moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanCampaignRequest request = new GetKeywordPlanCampaignRequest
            {
                ResourceNameAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
            };
            gagvr::KeywordPlanCampaign expectedResponse = new gagvr::KeywordPlanCampaign
            {
                ResourceNameAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                KeywordPlanAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                Id = -6774108720365892680L,
                KeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                LanguageConstantsAsLanguageConstantNames =
                {
                    gagvr::LanguageConstantName.FromLanguageConstant("[LANGUAGE_CONSTANT]"),
                },
                KeywordPlanNetwork = gagve::KeywordPlanNetworkEnum.Types.KeywordPlanNetwork.Unspecified,
                CpcBidMicros = 7321761304249472746L,
                GeoTargets =
                {
                    new gagvr::KeywordPlanGeoTarget(),
                },
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanCampaignAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanCampaign>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanCampaign responseCallSettings = await client.GetKeywordPlanCampaignAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanCampaign responseCancellationToken = await client.GetKeywordPlanCampaignAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetKeywordPlanCampaign()
        {
            moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanCampaignRequest request = new GetKeywordPlanCampaignRequest
            {
                ResourceNameAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
            };
            gagvr::KeywordPlanCampaign expectedResponse = new gagvr::KeywordPlanCampaign
            {
                ResourceNameAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                KeywordPlanAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                Id = -6774108720365892680L,
                KeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                LanguageConstantsAsLanguageConstantNames =
                {
                    gagvr::LanguageConstantName.FromLanguageConstant("[LANGUAGE_CONSTANT]"),
                },
                KeywordPlanNetwork = gagve::KeywordPlanNetworkEnum.Types.KeywordPlanNetwork.Unspecified,
                CpcBidMicros = 7321761304249472746L,
                GeoTargets =
                {
                    new gagvr::KeywordPlanGeoTarget(),
                },
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanCampaign(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanCampaign response = client.GetKeywordPlanCampaign(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanCampaignAsync()
        {
            moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanCampaignRequest request = new GetKeywordPlanCampaignRequest
            {
                ResourceNameAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
            };
            gagvr::KeywordPlanCampaign expectedResponse = new gagvr::KeywordPlanCampaign
            {
                ResourceNameAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                KeywordPlanAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                Id = -6774108720365892680L,
                KeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                LanguageConstantsAsLanguageConstantNames =
                {
                    gagvr::LanguageConstantName.FromLanguageConstant("[LANGUAGE_CONSTANT]"),
                },
                KeywordPlanNetwork = gagve::KeywordPlanNetworkEnum.Types.KeywordPlanNetwork.Unspecified,
                CpcBidMicros = 7321761304249472746L,
                GeoTargets =
                {
                    new gagvr::KeywordPlanGeoTarget(),
                },
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanCampaignAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanCampaign>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanCampaign responseCallSettings = await client.GetKeywordPlanCampaignAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanCampaign responseCancellationToken = await client.GetKeywordPlanCampaignAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetKeywordPlanCampaignResourceNames()
        {
            moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanCampaignRequest request = new GetKeywordPlanCampaignRequest
            {
                ResourceNameAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
            };
            gagvr::KeywordPlanCampaign expectedResponse = new gagvr::KeywordPlanCampaign
            {
                ResourceNameAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                KeywordPlanAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                Id = -6774108720365892680L,
                KeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                LanguageConstantsAsLanguageConstantNames =
                {
                    gagvr::LanguageConstantName.FromLanguageConstant("[LANGUAGE_CONSTANT]"),
                },
                KeywordPlanNetwork = gagve::KeywordPlanNetworkEnum.Types.KeywordPlanNetwork.Unspecified,
                CpcBidMicros = 7321761304249472746L,
                GeoTargets =
                {
                    new gagvr::KeywordPlanGeoTarget(),
                },
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanCampaign(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanCampaign response = client.GetKeywordPlanCampaign(request.ResourceNameAsKeywordPlanCampaignName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanCampaignResourceNamesAsync()
        {
            moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanCampaignRequest request = new GetKeywordPlanCampaignRequest
            {
                ResourceNameAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
            };
            gagvr::KeywordPlanCampaign expectedResponse = new gagvr::KeywordPlanCampaign
            {
                ResourceNameAsKeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                KeywordPlanAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                Id = -6774108720365892680L,
                KeywordPlanCampaignName = gagvr::KeywordPlanCampaignName.FromCustomerKeywordPlanCampaign("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]"),
                LanguageConstantsAsLanguageConstantNames =
                {
                    gagvr::LanguageConstantName.FromLanguageConstant("[LANGUAGE_CONSTANT]"),
                },
                KeywordPlanNetwork = gagve::KeywordPlanNetworkEnum.Types.KeywordPlanNetwork.Unspecified,
                CpcBidMicros = 7321761304249472746L,
                GeoTargets =
                {
                    new gagvr::KeywordPlanGeoTarget(),
                },
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanCampaignAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlanCampaign>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlanCampaign responseCallSettings = await client.GetKeywordPlanCampaignAsync(request.ResourceNameAsKeywordPlanCampaignName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlanCampaign responseCancellationToken = await client.GetKeywordPlanCampaignAsync(request.ResourceNameAsKeywordPlanCampaignName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateKeywordPlanCampaignsRequestObject()
        {
            moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanCampaignsRequest request = new MutateKeywordPlanCampaignsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanCampaignOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateKeywordPlanCampaignsResponse expectedResponse = new MutateKeywordPlanCampaignsResponse
            {
                Results =
                {
                    new MutateKeywordPlanCampaignResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanCampaigns(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanCampaignsResponse response = client.MutateKeywordPlanCampaigns(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateKeywordPlanCampaignsRequestObjectAsync()
        {
            moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanCampaignsRequest request = new MutateKeywordPlanCampaignsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanCampaignOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateKeywordPlanCampaignsResponse expectedResponse = new MutateKeywordPlanCampaignsResponse
            {
                Results =
                {
                    new MutateKeywordPlanCampaignResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanCampaignsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateKeywordPlanCampaignsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanCampaignsResponse responseCallSettings = await client.MutateKeywordPlanCampaignsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateKeywordPlanCampaignsResponse responseCancellationToken = await client.MutateKeywordPlanCampaignsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateKeywordPlanCampaigns()
        {
            moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanCampaignsRequest request = new MutateKeywordPlanCampaignsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanCampaignOperation(),
                },
            };
            MutateKeywordPlanCampaignsResponse expectedResponse = new MutateKeywordPlanCampaignsResponse
            {
                Results =
                {
                    new MutateKeywordPlanCampaignResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanCampaigns(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanCampaignsResponse response = client.MutateKeywordPlanCampaigns(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateKeywordPlanCampaignsAsync()
        {
            moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlanCampaignsRequest request = new MutateKeywordPlanCampaignsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanCampaignOperation(),
                },
            };
            MutateKeywordPlanCampaignsResponse expectedResponse = new MutateKeywordPlanCampaignsResponse
            {
                Results =
                {
                    new MutateKeywordPlanCampaignResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlanCampaignsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateKeywordPlanCampaignsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanCampaignsResponse responseCallSettings = await client.MutateKeywordPlanCampaignsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateKeywordPlanCampaignsResponse responseCancellationToken = await client.MutateKeywordPlanCampaignsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

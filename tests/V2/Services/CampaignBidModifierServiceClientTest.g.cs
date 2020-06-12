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
    public sealed class GeneratedCampaignBidModifierServiceClientTest
    {
        [Test]
        public void GetCampaignBidModifierRequestObject()
        {
            moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(moq::MockBehavior.Strict);
            GetCampaignBidModifierRequest request = new GetCampaignBidModifierRequest
            {
                ResourceNameAsCampaignBidModifierName = gagvr::CampaignBidModifierName.FromCustomerCampaignBidModifier("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]"),
            };
            gagvr::CampaignBidModifier expectedResponse = new gagvr::CampaignBidModifier
            {
                ResourceNameAsCampaignBidModifierName = gagvr::CampaignBidModifierName.FromCustomerCampaignBidModifier("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195068951933E+17,
                InteractionType = new gagvc::InteractionTypeInfo(),
            };
            mockGrpcClient.Setup(x => x.GetCampaignBidModifier(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignBidModifier response = client.GetCampaignBidModifier(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCampaignBidModifierRequestObjectAsync()
        {
            moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(moq::MockBehavior.Strict);
            GetCampaignBidModifierRequest request = new GetCampaignBidModifierRequest
            {
                ResourceNameAsCampaignBidModifierName = gagvr::CampaignBidModifierName.FromCustomerCampaignBidModifier("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]"),
            };
            gagvr::CampaignBidModifier expectedResponse = new gagvr::CampaignBidModifier
            {
                ResourceNameAsCampaignBidModifierName = gagvr::CampaignBidModifierName.FromCustomerCampaignBidModifier("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195068951933E+17,
                InteractionType = new gagvc::InteractionTypeInfo(),
            };
            mockGrpcClient.Setup(x => x.GetCampaignBidModifierAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignBidModifier>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignBidModifier responseCallSettings = await client.GetCampaignBidModifierAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignBidModifier responseCancellationToken = await client.GetCampaignBidModifierAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaignBidModifier()
        {
            moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(moq::MockBehavior.Strict);
            GetCampaignBidModifierRequest request = new GetCampaignBidModifierRequest
            {
                ResourceNameAsCampaignBidModifierName = gagvr::CampaignBidModifierName.FromCustomerCampaignBidModifier("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]"),
            };
            gagvr::CampaignBidModifier expectedResponse = new gagvr::CampaignBidModifier
            {
                ResourceNameAsCampaignBidModifierName = gagvr::CampaignBidModifierName.FromCustomerCampaignBidModifier("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195068951933E+17,
                InteractionType = new gagvc::InteractionTypeInfo(),
            };
            mockGrpcClient.Setup(x => x.GetCampaignBidModifier(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignBidModifier response = client.GetCampaignBidModifier(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCampaignBidModifierAsync()
        {
            moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(moq::MockBehavior.Strict);
            GetCampaignBidModifierRequest request = new GetCampaignBidModifierRequest
            {
                ResourceNameAsCampaignBidModifierName = gagvr::CampaignBidModifierName.FromCustomerCampaignBidModifier("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]"),
            };
            gagvr::CampaignBidModifier expectedResponse = new gagvr::CampaignBidModifier
            {
                ResourceNameAsCampaignBidModifierName = gagvr::CampaignBidModifierName.FromCustomerCampaignBidModifier("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195068951933E+17,
                InteractionType = new gagvc::InteractionTypeInfo(),
            };
            mockGrpcClient.Setup(x => x.GetCampaignBidModifierAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignBidModifier>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignBidModifier responseCallSettings = await client.GetCampaignBidModifierAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignBidModifier responseCancellationToken = await client.GetCampaignBidModifierAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaignBidModifierResourceNames()
        {
            moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(moq::MockBehavior.Strict);
            GetCampaignBidModifierRequest request = new GetCampaignBidModifierRequest
            {
                ResourceNameAsCampaignBidModifierName = gagvr::CampaignBidModifierName.FromCustomerCampaignBidModifier("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]"),
            };
            gagvr::CampaignBidModifier expectedResponse = new gagvr::CampaignBidModifier
            {
                ResourceNameAsCampaignBidModifierName = gagvr::CampaignBidModifierName.FromCustomerCampaignBidModifier("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195068951933E+17,
                InteractionType = new gagvc::InteractionTypeInfo(),
            };
            mockGrpcClient.Setup(x => x.GetCampaignBidModifier(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignBidModifier response = client.GetCampaignBidModifier(request.ResourceNameAsCampaignBidModifierName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCampaignBidModifierResourceNamesAsync()
        {
            moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(moq::MockBehavior.Strict);
            GetCampaignBidModifierRequest request = new GetCampaignBidModifierRequest
            {
                ResourceNameAsCampaignBidModifierName = gagvr::CampaignBidModifierName.FromCustomerCampaignBidModifier("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]"),
            };
            gagvr::CampaignBidModifier expectedResponse = new gagvr::CampaignBidModifier
            {
                ResourceNameAsCampaignBidModifierName = gagvr::CampaignBidModifierName.FromCustomerCampaignBidModifier("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195068951933E+17,
                InteractionType = new gagvc::InteractionTypeInfo(),
            };
            mockGrpcClient.Setup(x => x.GetCampaignBidModifierAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignBidModifier>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignBidModifier responseCallSettings = await client.GetCampaignBidModifierAsync(request.ResourceNameAsCampaignBidModifierName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignBidModifier responseCancellationToken = await client.GetCampaignBidModifierAsync(request.ResourceNameAsCampaignBidModifierName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignBidModifiersRequestObject()
        {
            moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignBidModifiersRequest request = new MutateCampaignBidModifiersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignBidModifierOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCampaignBidModifiersResponse expectedResponse = new MutateCampaignBidModifiersResponse
            {
                Results =
                {
                    new MutateCampaignBidModifierResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignBidModifiers(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignBidModifiersResponse response = client.MutateCampaignBidModifiers(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateCampaignBidModifiersRequestObjectAsync()
        {
            moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignBidModifiersRequest request = new MutateCampaignBidModifiersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignBidModifierOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCampaignBidModifiersResponse expectedResponse = new MutateCampaignBidModifiersResponse
            {
                Results =
                {
                    new MutateCampaignBidModifierResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignBidModifiersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignBidModifiersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignBidModifiersResponse responseCallSettings = await client.MutateCampaignBidModifiersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignBidModifiersResponse responseCancellationToken = await client.MutateCampaignBidModifiersAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignBidModifiers()
        {
            moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignBidModifiersRequest request = new MutateCampaignBidModifiersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignBidModifierOperation(),
                },
            };
            MutateCampaignBidModifiersResponse expectedResponse = new MutateCampaignBidModifiersResponse
            {
                Results =
                {
                    new MutateCampaignBidModifierResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignBidModifiers(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignBidModifiersResponse response = client.MutateCampaignBidModifiers(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateCampaignBidModifiersAsync()
        {
            moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new moq::Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignBidModifiersRequest request = new MutateCampaignBidModifiersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignBidModifierOperation(),
                },
            };
            MutateCampaignBidModifiersResponse expectedResponse = new MutateCampaignBidModifiersResponse
            {
                Results =
                {
                    new MutateCampaignBidModifierResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignBidModifiersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignBidModifiersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignBidModifiersResponse responseCallSettings = await client.MutateCampaignBidModifiersAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignBidModifiersResponse responseCancellationToken = await client.MutateCampaignBidModifiersAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

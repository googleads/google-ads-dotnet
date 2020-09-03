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
    public sealed class GeneratedCampaignSharedSetServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCampaignSharedSetRequestObject()
        {
            moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(moq::MockBehavior.Strict);
            GetCampaignSharedSetRequest request = new GetCampaignSharedSetRequest
            {
                ResourceNameAsCampaignSharedSetName = gagvr::CampaignSharedSetName.FromCustomerCampaignSharedSet("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]"),
            };
            gagvr::CampaignSharedSet expectedResponse = new gagvr::CampaignSharedSet
            {
                ResourceNameAsCampaignSharedSetName = gagvr::CampaignSharedSetName.FromCustomerCampaignSharedSet("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]"),
                Status = gagve::CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Enabled,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                SharedSetAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignSharedSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignSharedSet response = client.GetCampaignSharedSet(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignSharedSetRequestObjectAsync()
        {
            moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(moq::MockBehavior.Strict);
            GetCampaignSharedSetRequest request = new GetCampaignSharedSetRequest
            {
                ResourceNameAsCampaignSharedSetName = gagvr::CampaignSharedSetName.FromCustomerCampaignSharedSet("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]"),
            };
            gagvr::CampaignSharedSet expectedResponse = new gagvr::CampaignSharedSet
            {
                ResourceNameAsCampaignSharedSetName = gagvr::CampaignSharedSetName.FromCustomerCampaignSharedSet("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]"),
                Status = gagve::CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Enabled,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                SharedSetAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignSharedSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignSharedSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignSharedSet responseCallSettings = await client.GetCampaignSharedSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignSharedSet responseCancellationToken = await client.GetCampaignSharedSetAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignSharedSet()
        {
            moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(moq::MockBehavior.Strict);
            GetCampaignSharedSetRequest request = new GetCampaignSharedSetRequest
            {
                ResourceNameAsCampaignSharedSetName = gagvr::CampaignSharedSetName.FromCustomerCampaignSharedSet("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]"),
            };
            gagvr::CampaignSharedSet expectedResponse = new gagvr::CampaignSharedSet
            {
                ResourceNameAsCampaignSharedSetName = gagvr::CampaignSharedSetName.FromCustomerCampaignSharedSet("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]"),
                Status = gagve::CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Enabled,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                SharedSetAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignSharedSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignSharedSet response = client.GetCampaignSharedSet(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignSharedSetAsync()
        {
            moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(moq::MockBehavior.Strict);
            GetCampaignSharedSetRequest request = new GetCampaignSharedSetRequest
            {
                ResourceNameAsCampaignSharedSetName = gagvr::CampaignSharedSetName.FromCustomerCampaignSharedSet("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]"),
            };
            gagvr::CampaignSharedSet expectedResponse = new gagvr::CampaignSharedSet
            {
                ResourceNameAsCampaignSharedSetName = gagvr::CampaignSharedSetName.FromCustomerCampaignSharedSet("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]"),
                Status = gagve::CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Enabled,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                SharedSetAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignSharedSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignSharedSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignSharedSet responseCallSettings = await client.GetCampaignSharedSetAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignSharedSet responseCancellationToken = await client.GetCampaignSharedSetAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignSharedSetResourceNames()
        {
            moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(moq::MockBehavior.Strict);
            GetCampaignSharedSetRequest request = new GetCampaignSharedSetRequest
            {
                ResourceNameAsCampaignSharedSetName = gagvr::CampaignSharedSetName.FromCustomerCampaignSharedSet("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]"),
            };
            gagvr::CampaignSharedSet expectedResponse = new gagvr::CampaignSharedSet
            {
                ResourceNameAsCampaignSharedSetName = gagvr::CampaignSharedSetName.FromCustomerCampaignSharedSet("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]"),
                Status = gagve::CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Enabled,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                SharedSetAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignSharedSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignSharedSet response = client.GetCampaignSharedSet(request.ResourceNameAsCampaignSharedSetName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignSharedSetResourceNamesAsync()
        {
            moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(moq::MockBehavior.Strict);
            GetCampaignSharedSetRequest request = new GetCampaignSharedSetRequest
            {
                ResourceNameAsCampaignSharedSetName = gagvr::CampaignSharedSetName.FromCustomerCampaignSharedSet("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]"),
            };
            gagvr::CampaignSharedSet expectedResponse = new gagvr::CampaignSharedSet
            {
                ResourceNameAsCampaignSharedSetName = gagvr::CampaignSharedSetName.FromCustomerCampaignSharedSet("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]"),
                Status = gagve::CampaignSharedSetStatusEnum.Types.CampaignSharedSetStatus.Enabled,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                SharedSetAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignSharedSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignSharedSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignSharedSet responseCallSettings = await client.GetCampaignSharedSetAsync(request.ResourceNameAsCampaignSharedSetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignSharedSet responseCancellationToken = await client.GetCampaignSharedSetAsync(request.ResourceNameAsCampaignSharedSetName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignSharedSetsRequestObject()
        {
            moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignSharedSetsRequest request = new MutateCampaignSharedSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignSharedSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCampaignSharedSetsResponse expectedResponse = new MutateCampaignSharedSetsResponse
            {
                Results =
                {
                    new MutateCampaignSharedSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignSharedSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignSharedSetsResponse response = client.MutateCampaignSharedSets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignSharedSetsRequestObjectAsync()
        {
            moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignSharedSetsRequest request = new MutateCampaignSharedSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignSharedSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCampaignSharedSetsResponse expectedResponse = new MutateCampaignSharedSetsResponse
            {
                Results =
                {
                    new MutateCampaignSharedSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignSharedSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignSharedSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignSharedSetsResponse responseCallSettings = await client.MutateCampaignSharedSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignSharedSetsResponse responseCancellationToken = await client.MutateCampaignSharedSetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignSharedSets()
        {
            moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignSharedSetsRequest request = new MutateCampaignSharedSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignSharedSetOperation(),
                },
            };
            MutateCampaignSharedSetsResponse expectedResponse = new MutateCampaignSharedSetsResponse
            {
                Results =
                {
                    new MutateCampaignSharedSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignSharedSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignSharedSetsResponse response = client.MutateCampaignSharedSets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignSharedSetsAsync()
        {
            moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignSharedSetsRequest request = new MutateCampaignSharedSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignSharedSetOperation(),
                },
            };
            MutateCampaignSharedSetsResponse expectedResponse = new MutateCampaignSharedSetsResponse
            {
                Results =
                {
                    new MutateCampaignSharedSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignSharedSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignSharedSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignSharedSetsResponse responseCallSettings = await client.MutateCampaignSharedSetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignSharedSetsResponse responseCancellationToken = await client.MutateCampaignSharedSetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

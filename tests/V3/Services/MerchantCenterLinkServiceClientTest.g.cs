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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V3.Services;

namespace Google.Ads.GoogleAds.Tests.V3.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedMerchantCenterLinkServiceClientTest
    {
        [Test]
        public void ListMerchantCenterLinksRequestObject()
        {
            moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(moq::MockBehavior.Strict);
            ListMerchantCenterLinksRequest request = new ListMerchantCenterLinksRequest
            {
                CustomerId = "customer_id3b3724cb",
            };
            ListMerchantCenterLinksResponse expectedResponse = new ListMerchantCenterLinksResponse
            {
                MerchantCenterLinks =
                {
                    new gagvr::MerchantCenterLink(),
                },
            };
            mockGrpcClient.Setup(x => x.ListMerchantCenterLinks(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            ListMerchantCenterLinksResponse response = client.ListMerchantCenterLinks(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task ListMerchantCenterLinksRequestObjectAsync()
        {
            moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(moq::MockBehavior.Strict);
            ListMerchantCenterLinksRequest request = new ListMerchantCenterLinksRequest
            {
                CustomerId = "customer_id3b3724cb",
            };
            ListMerchantCenterLinksResponse expectedResponse = new ListMerchantCenterLinksResponse
            {
                MerchantCenterLinks =
                {
                    new gagvr::MerchantCenterLink(),
                },
            };
            mockGrpcClient.Setup(x => x.ListMerchantCenterLinksAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListMerchantCenterLinksResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            ListMerchantCenterLinksResponse responseCallSettings = await client.ListMerchantCenterLinksAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            ListMerchantCenterLinksResponse responseCancellationToken = await client.ListMerchantCenterLinksAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void ListMerchantCenterLinks()
        {
            moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(moq::MockBehavior.Strict);
            ListMerchantCenterLinksRequest request = new ListMerchantCenterLinksRequest
            {
                CustomerId = "customer_id3b3724cb",
            };
            ListMerchantCenterLinksResponse expectedResponse = new ListMerchantCenterLinksResponse
            {
                MerchantCenterLinks =
                {
                    new gagvr::MerchantCenterLink(),
                },
            };
            mockGrpcClient.Setup(x => x.ListMerchantCenterLinks(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            ListMerchantCenterLinksResponse response = client.ListMerchantCenterLinks(request.CustomerId);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task ListMerchantCenterLinksAsync()
        {
            moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(moq::MockBehavior.Strict);
            ListMerchantCenterLinksRequest request = new ListMerchantCenterLinksRequest
            {
                CustomerId = "customer_id3b3724cb",
            };
            ListMerchantCenterLinksResponse expectedResponse = new ListMerchantCenterLinksResponse
            {
                MerchantCenterLinks =
                {
                    new gagvr::MerchantCenterLink(),
                },
            };
            mockGrpcClient.Setup(x => x.ListMerchantCenterLinksAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListMerchantCenterLinksResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            ListMerchantCenterLinksResponse responseCallSettings = await client.ListMerchantCenterLinksAsync(request.CustomerId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            ListMerchantCenterLinksResponse responseCancellationToken = await client.ListMerchantCenterLinksAsync(request.CustomerId, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetMerchantCenterLinkRequestObject()
        {
            moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(moq::MockBehavior.Strict);
            GetMerchantCenterLinkRequest request = new GetMerchantCenterLinkRequest
            {
                ResourceNameAsMerchantCenterLinkName = gagvr::MerchantCenterLinkName.FromCustomerMerchantCenterLink("[CUSTOMER]", "[MERCHANT_CENTER_LINK]"),
            };
            gagvr::MerchantCenterLink expectedResponse = new gagvr::MerchantCenterLink
            {
                ResourceNameAsMerchantCenterLinkName = gagvr::MerchantCenterLinkName.FromCustomerMerchantCenterLink("[CUSTOMER]", "[MERCHANT_CENTER_LINK]"),
                Id = -6774108720365892680L,
                MerchantCenterAccountName = "merchant_center_account_name94680907",
                Status = gagve::MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetMerchantCenterLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MerchantCenterLink response = client.GetMerchantCenterLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetMerchantCenterLinkRequestObjectAsync()
        {
            moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(moq::MockBehavior.Strict);
            GetMerchantCenterLinkRequest request = new GetMerchantCenterLinkRequest
            {
                ResourceNameAsMerchantCenterLinkName = gagvr::MerchantCenterLinkName.FromCustomerMerchantCenterLink("[CUSTOMER]", "[MERCHANT_CENTER_LINK]"),
            };
            gagvr::MerchantCenterLink expectedResponse = new gagvr::MerchantCenterLink
            {
                ResourceNameAsMerchantCenterLinkName = gagvr::MerchantCenterLinkName.FromCustomerMerchantCenterLink("[CUSTOMER]", "[MERCHANT_CENTER_LINK]"),
                Id = -6774108720365892680L,
                MerchantCenterAccountName = "merchant_center_account_name94680907",
                Status = gagve::MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetMerchantCenterLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::MerchantCenterLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MerchantCenterLink responseCallSettings = await client.GetMerchantCenterLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::MerchantCenterLink responseCancellationToken = await client.GetMerchantCenterLinkAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetMerchantCenterLink()
        {
            moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(moq::MockBehavior.Strict);
            GetMerchantCenterLinkRequest request = new GetMerchantCenterLinkRequest
            {
                ResourceNameAsMerchantCenterLinkName = gagvr::MerchantCenterLinkName.FromCustomerMerchantCenterLink("[CUSTOMER]", "[MERCHANT_CENTER_LINK]"),
            };
            gagvr::MerchantCenterLink expectedResponse = new gagvr::MerchantCenterLink
            {
                ResourceNameAsMerchantCenterLinkName = gagvr::MerchantCenterLinkName.FromCustomerMerchantCenterLink("[CUSTOMER]", "[MERCHANT_CENTER_LINK]"),
                Id = -6774108720365892680L,
                MerchantCenterAccountName = "merchant_center_account_name94680907",
                Status = gagve::MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetMerchantCenterLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MerchantCenterLink response = client.GetMerchantCenterLink(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetMerchantCenterLinkAsync()
        {
            moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(moq::MockBehavior.Strict);
            GetMerchantCenterLinkRequest request = new GetMerchantCenterLinkRequest
            {
                ResourceNameAsMerchantCenterLinkName = gagvr::MerchantCenterLinkName.FromCustomerMerchantCenterLink("[CUSTOMER]", "[MERCHANT_CENTER_LINK]"),
            };
            gagvr::MerchantCenterLink expectedResponse = new gagvr::MerchantCenterLink
            {
                ResourceNameAsMerchantCenterLinkName = gagvr::MerchantCenterLinkName.FromCustomerMerchantCenterLink("[CUSTOMER]", "[MERCHANT_CENTER_LINK]"),
                Id = -6774108720365892680L,
                MerchantCenterAccountName = "merchant_center_account_name94680907",
                Status = gagve::MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetMerchantCenterLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::MerchantCenterLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MerchantCenterLink responseCallSettings = await client.GetMerchantCenterLinkAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::MerchantCenterLink responseCancellationToken = await client.GetMerchantCenterLinkAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetMerchantCenterLinkResourceNames()
        {
            moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(moq::MockBehavior.Strict);
            GetMerchantCenterLinkRequest request = new GetMerchantCenterLinkRequest
            {
                ResourceNameAsMerchantCenterLinkName = gagvr::MerchantCenterLinkName.FromCustomerMerchantCenterLink("[CUSTOMER]", "[MERCHANT_CENTER_LINK]"),
            };
            gagvr::MerchantCenterLink expectedResponse = new gagvr::MerchantCenterLink
            {
                ResourceNameAsMerchantCenterLinkName = gagvr::MerchantCenterLinkName.FromCustomerMerchantCenterLink("[CUSTOMER]", "[MERCHANT_CENTER_LINK]"),
                Id = -6774108720365892680L,
                MerchantCenterAccountName = "merchant_center_account_name94680907",
                Status = gagve::MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetMerchantCenterLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MerchantCenterLink response = client.GetMerchantCenterLink(request.ResourceNameAsMerchantCenterLinkName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetMerchantCenterLinkResourceNamesAsync()
        {
            moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(moq::MockBehavior.Strict);
            GetMerchantCenterLinkRequest request = new GetMerchantCenterLinkRequest
            {
                ResourceNameAsMerchantCenterLinkName = gagvr::MerchantCenterLinkName.FromCustomerMerchantCenterLink("[CUSTOMER]", "[MERCHANT_CENTER_LINK]"),
            };
            gagvr::MerchantCenterLink expectedResponse = new gagvr::MerchantCenterLink
            {
                ResourceNameAsMerchantCenterLinkName = gagvr::MerchantCenterLinkName.FromCustomerMerchantCenterLink("[CUSTOMER]", "[MERCHANT_CENTER_LINK]"),
                Id = -6774108720365892680L,
                MerchantCenterAccountName = "merchant_center_account_name94680907",
                Status = gagve::MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetMerchantCenterLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::MerchantCenterLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MerchantCenterLink responseCallSettings = await client.GetMerchantCenterLinkAsync(request.ResourceNameAsMerchantCenterLinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::MerchantCenterLink responseCancellationToken = await client.GetMerchantCenterLinkAsync(request.ResourceNameAsMerchantCenterLinkName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateMerchantCenterLinkRequestObject()
        {
            moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(moq::MockBehavior.Strict);
            MutateMerchantCenterLinkRequest request = new MutateMerchantCenterLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new MerchantCenterLinkOperation(),
            };
            MutateMerchantCenterLinkResponse expectedResponse = new MutateMerchantCenterLinkResponse
            {
                Result = new MutateMerchantCenterLinkResult(),
            };
            mockGrpcClient.Setup(x => x.MutateMerchantCenterLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateMerchantCenterLinkResponse response = client.MutateMerchantCenterLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateMerchantCenterLinkRequestObjectAsync()
        {
            moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(moq::MockBehavior.Strict);
            MutateMerchantCenterLinkRequest request = new MutateMerchantCenterLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new MerchantCenterLinkOperation(),
            };
            MutateMerchantCenterLinkResponse expectedResponse = new MutateMerchantCenterLinkResponse
            {
                Result = new MutateMerchantCenterLinkResult(),
            };
            mockGrpcClient.Setup(x => x.MutateMerchantCenterLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateMerchantCenterLinkResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateMerchantCenterLinkResponse responseCallSettings = await client.MutateMerchantCenterLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateMerchantCenterLinkResponse responseCancellationToken = await client.MutateMerchantCenterLinkAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateMerchantCenterLink()
        {
            moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(moq::MockBehavior.Strict);
            MutateMerchantCenterLinkRequest request = new MutateMerchantCenterLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new MerchantCenterLinkOperation(),
            };
            MutateMerchantCenterLinkResponse expectedResponse = new MutateMerchantCenterLinkResponse
            {
                Result = new MutateMerchantCenterLinkResult(),
            };
            mockGrpcClient.Setup(x => x.MutateMerchantCenterLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateMerchantCenterLinkResponse response = client.MutateMerchantCenterLink(request.CustomerId, request.Operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateMerchantCenterLinkAsync()
        {
            moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new moq::Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(moq::MockBehavior.Strict);
            MutateMerchantCenterLinkRequest request = new MutateMerchantCenterLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new MerchantCenterLinkOperation(),
            };
            MutateMerchantCenterLinkResponse expectedResponse = new MutateMerchantCenterLinkResponse
            {
                Result = new MutateMerchantCenterLinkResult(),
            };
            mockGrpcClient.Setup(x => x.MutateMerchantCenterLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateMerchantCenterLinkResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateMerchantCenterLinkResponse responseCallSettings = await client.MutateMerchantCenterLinkAsync(request.CustomerId, request.Operation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateMerchantCenterLinkResponse responseCancellationToken = await client.MutateMerchantCenterLinkAsync(request.CustomerId, request.Operation, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

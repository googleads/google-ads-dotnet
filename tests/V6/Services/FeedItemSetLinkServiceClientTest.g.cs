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

using gagvr = Google.Ads.GoogleAds.V6.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V6.Services;

namespace Google.Ads.GoogleAds.Tests.V6.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFeedItemSetLinkServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetFeedItemSetLinkRequestObject()
        {
            moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemSetLinkRequest request = new GetFeedItemSetLinkRequest
            {
                ResourceNameAsFeedItemSetLinkName = gagvr::FeedItemSetLinkName.FromCustomerFeedFeedItemSetFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]", "[FEED_ITEM_ID]"),
            };
            gagvr::FeedItemSetLink expectedResponse = new gagvr::FeedItemSetLink
            {
                ResourceNameAsFeedItemSetLinkName = gagvr::FeedItemSetLinkName.FromCustomerFeedFeedItemSetFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]", "[FEED_ITEM_ID]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_ID]"),
                FeedItemSetAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetFeedItemSetLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemSetLinkServiceClient client = new FeedItemSetLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemSetLink response = client.GetFeedItemSetLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetFeedItemSetLinkRequestObjectAsync()
        {
            moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemSetLinkRequest request = new GetFeedItemSetLinkRequest
            {
                ResourceNameAsFeedItemSetLinkName = gagvr::FeedItemSetLinkName.FromCustomerFeedFeedItemSetFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]", "[FEED_ITEM_ID]"),
            };
            gagvr::FeedItemSetLink expectedResponse = new gagvr::FeedItemSetLink
            {
                ResourceNameAsFeedItemSetLinkName = gagvr::FeedItemSetLinkName.FromCustomerFeedFeedItemSetFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]", "[FEED_ITEM_ID]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_ID]"),
                FeedItemSetAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetFeedItemSetLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedItemSetLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemSetLinkServiceClient client = new FeedItemSetLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemSetLink responseCallSettings = await client.GetFeedItemSetLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedItemSetLink responseCancellationToken = await client.GetFeedItemSetLinkAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetFeedItemSetLink()
        {
            moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemSetLinkRequest request = new GetFeedItemSetLinkRequest
            {
                ResourceNameAsFeedItemSetLinkName = gagvr::FeedItemSetLinkName.FromCustomerFeedFeedItemSetFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]", "[FEED_ITEM_ID]"),
            };
            gagvr::FeedItemSetLink expectedResponse = new gagvr::FeedItemSetLink
            {
                ResourceNameAsFeedItemSetLinkName = gagvr::FeedItemSetLinkName.FromCustomerFeedFeedItemSetFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]", "[FEED_ITEM_ID]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_ID]"),
                FeedItemSetAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetFeedItemSetLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemSetLinkServiceClient client = new FeedItemSetLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemSetLink response = client.GetFeedItemSetLink(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetFeedItemSetLinkAsync()
        {
            moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemSetLinkRequest request = new GetFeedItemSetLinkRequest
            {
                ResourceNameAsFeedItemSetLinkName = gagvr::FeedItemSetLinkName.FromCustomerFeedFeedItemSetFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]", "[FEED_ITEM_ID]"),
            };
            gagvr::FeedItemSetLink expectedResponse = new gagvr::FeedItemSetLink
            {
                ResourceNameAsFeedItemSetLinkName = gagvr::FeedItemSetLinkName.FromCustomerFeedFeedItemSetFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]", "[FEED_ITEM_ID]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_ID]"),
                FeedItemSetAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetFeedItemSetLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedItemSetLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemSetLinkServiceClient client = new FeedItemSetLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemSetLink responseCallSettings = await client.GetFeedItemSetLinkAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedItemSetLink responseCancellationToken = await client.GetFeedItemSetLinkAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetFeedItemSetLinkResourceNames()
        {
            moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemSetLinkRequest request = new GetFeedItemSetLinkRequest
            {
                ResourceNameAsFeedItemSetLinkName = gagvr::FeedItemSetLinkName.FromCustomerFeedFeedItemSetFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]", "[FEED_ITEM_ID]"),
            };
            gagvr::FeedItemSetLink expectedResponse = new gagvr::FeedItemSetLink
            {
                ResourceNameAsFeedItemSetLinkName = gagvr::FeedItemSetLinkName.FromCustomerFeedFeedItemSetFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]", "[FEED_ITEM_ID]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_ID]"),
                FeedItemSetAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetFeedItemSetLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemSetLinkServiceClient client = new FeedItemSetLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemSetLink response = client.GetFeedItemSetLink(request.ResourceNameAsFeedItemSetLinkName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetFeedItemSetLinkResourceNamesAsync()
        {
            moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemSetLinkRequest request = new GetFeedItemSetLinkRequest
            {
                ResourceNameAsFeedItemSetLinkName = gagvr::FeedItemSetLinkName.FromCustomerFeedFeedItemSetFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]", "[FEED_ITEM_ID]"),
            };
            gagvr::FeedItemSetLink expectedResponse = new gagvr::FeedItemSetLink
            {
                ResourceNameAsFeedItemSetLinkName = gagvr::FeedItemSetLinkName.FromCustomerFeedFeedItemSetFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]", "[FEED_ITEM_ID]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_ID]"),
                FeedItemSetAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetFeedItemSetLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedItemSetLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemSetLinkServiceClient client = new FeedItemSetLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemSetLink responseCallSettings = await client.GetFeedItemSetLinkAsync(request.ResourceNameAsFeedItemSetLinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedItemSetLink responseCancellationToken = await client.GetFeedItemSetLinkAsync(request.ResourceNameAsFeedItemSetLinkName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateFeedItemSetLinksRequestObject()
        {
            moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemSetLinksRequest request = new MutateFeedItemSetLinksRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemSetLinkOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateFeedItemSetLinksResponse expectedResponse = new MutateFeedItemSetLinksResponse
            {
                Results =
                {
                    new MutateFeedItemSetLinkResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemSetLinks(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemSetLinkServiceClient client = new FeedItemSetLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemSetLinksResponse response = client.MutateFeedItemSetLinks(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateFeedItemSetLinksRequestObjectAsync()
        {
            moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemSetLinksRequest request = new MutateFeedItemSetLinksRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemSetLinkOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateFeedItemSetLinksResponse expectedResponse = new MutateFeedItemSetLinksResponse
            {
                Results =
                {
                    new MutateFeedItemSetLinkResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemSetLinksAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateFeedItemSetLinksResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemSetLinkServiceClient client = new FeedItemSetLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemSetLinksResponse responseCallSettings = await client.MutateFeedItemSetLinksAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateFeedItemSetLinksResponse responseCancellationToken = await client.MutateFeedItemSetLinksAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateFeedItemSetLinks()
        {
            moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemSetLinksRequest request = new MutateFeedItemSetLinksRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemSetLinkOperation(),
                },
            };
            MutateFeedItemSetLinksResponse expectedResponse = new MutateFeedItemSetLinksResponse
            {
                Results =
                {
                    new MutateFeedItemSetLinkResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemSetLinks(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemSetLinkServiceClient client = new FeedItemSetLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemSetLinksResponse response = client.MutateFeedItemSetLinks(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateFeedItemSetLinksAsync()
        {
            moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetLinkService.FeedItemSetLinkServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemSetLinksRequest request = new MutateFeedItemSetLinksRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemSetLinkOperation(),
                },
            };
            MutateFeedItemSetLinksResponse expectedResponse = new MutateFeedItemSetLinksResponse
            {
                Results =
                {
                    new MutateFeedItemSetLinkResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemSetLinksAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateFeedItemSetLinksResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemSetLinkServiceClient client = new FeedItemSetLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemSetLinksResponse responseCallSettings = await client.MutateFeedItemSetLinksAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateFeedItemSetLinksResponse responseCancellationToken = await client.MutateFeedItemSetLinksAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

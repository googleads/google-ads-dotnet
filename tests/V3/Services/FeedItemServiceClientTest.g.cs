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

using gagvc = Google.Ads.GoogleAds.V3.Common;
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
    public sealed class GeneratedFeedItemServiceClientTest
    {
        [Test]
        public void GetFeedItemRequestObject()
        {
            moq::Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new moq::Mock<FeedItemService.FeedItemServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemRequest request = new GetFeedItemRequest
            {
                ResourceNameAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
            };
            gagvr::FeedItem expectedResponse = new gagvr::FeedItem
            {
                ResourceNameAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Id = -6774108720365892680L,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                AttributeValues =
                {
                    new gagvr::FeedItemAttributeValue(),
                },
                GeoTargetingRestriction = gagve::GeoTargetingRestrictionEnum.Types.GeoTargetingRestriction.LocationOfPresence,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                Status = gagve::FeedItemStatusEnum.Types.FeedItemStatus.Enabled,
                PolicyInfos =
                {
                    new gagvr::FeedItemPlaceholderPolicyInfo(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFeedItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItem response = client.GetFeedItem(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetFeedItemRequestObjectAsync()
        {
            moq::Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new moq::Mock<FeedItemService.FeedItemServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemRequest request = new GetFeedItemRequest
            {
                ResourceNameAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
            };
            gagvr::FeedItem expectedResponse = new gagvr::FeedItem
            {
                ResourceNameAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Id = -6774108720365892680L,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                AttributeValues =
                {
                    new gagvr::FeedItemAttributeValue(),
                },
                GeoTargetingRestriction = gagve::GeoTargetingRestrictionEnum.Types.GeoTargetingRestriction.LocationOfPresence,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                Status = gagve::FeedItemStatusEnum.Types.FeedItemStatus.Enabled,
                PolicyInfos =
                {
                    new gagvr::FeedItemPlaceholderPolicyInfo(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFeedItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItem responseCallSettings = await client.GetFeedItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedItem responseCancellationToken = await client.GetFeedItemAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetFeedItem()
        {
            moq::Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new moq::Mock<FeedItemService.FeedItemServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemRequest request = new GetFeedItemRequest
            {
                ResourceNameAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
            };
            gagvr::FeedItem expectedResponse = new gagvr::FeedItem
            {
                ResourceNameAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Id = -6774108720365892680L,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                AttributeValues =
                {
                    new gagvr::FeedItemAttributeValue(),
                },
                GeoTargetingRestriction = gagve::GeoTargetingRestrictionEnum.Types.GeoTargetingRestriction.LocationOfPresence,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                Status = gagve::FeedItemStatusEnum.Types.FeedItemStatus.Enabled,
                PolicyInfos =
                {
                    new gagvr::FeedItemPlaceholderPolicyInfo(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFeedItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItem response = client.GetFeedItem(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetFeedItemAsync()
        {
            moq::Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new moq::Mock<FeedItemService.FeedItemServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemRequest request = new GetFeedItemRequest
            {
                ResourceNameAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
            };
            gagvr::FeedItem expectedResponse = new gagvr::FeedItem
            {
                ResourceNameAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Id = -6774108720365892680L,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                AttributeValues =
                {
                    new gagvr::FeedItemAttributeValue(),
                },
                GeoTargetingRestriction = gagve::GeoTargetingRestrictionEnum.Types.GeoTargetingRestriction.LocationOfPresence,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                Status = gagve::FeedItemStatusEnum.Types.FeedItemStatus.Enabled,
                PolicyInfos =
                {
                    new gagvr::FeedItemPlaceholderPolicyInfo(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFeedItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItem responseCallSettings = await client.GetFeedItemAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedItem responseCancellationToken = await client.GetFeedItemAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetFeedItemResourceNames()
        {
            moq::Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new moq::Mock<FeedItemService.FeedItemServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemRequest request = new GetFeedItemRequest
            {
                ResourceNameAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
            };
            gagvr::FeedItem expectedResponse = new gagvr::FeedItem
            {
                ResourceNameAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Id = -6774108720365892680L,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                AttributeValues =
                {
                    new gagvr::FeedItemAttributeValue(),
                },
                GeoTargetingRestriction = gagve::GeoTargetingRestrictionEnum.Types.GeoTargetingRestriction.LocationOfPresence,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                Status = gagve::FeedItemStatusEnum.Types.FeedItemStatus.Enabled,
                PolicyInfos =
                {
                    new gagvr::FeedItemPlaceholderPolicyInfo(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFeedItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItem response = client.GetFeedItem(request.ResourceNameAsFeedItemName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetFeedItemResourceNamesAsync()
        {
            moq::Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new moq::Mock<FeedItemService.FeedItemServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemRequest request = new GetFeedItemRequest
            {
                ResourceNameAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
            };
            gagvr::FeedItem expectedResponse = new gagvr::FeedItem
            {
                ResourceNameAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Id = -6774108720365892680L,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                AttributeValues =
                {
                    new gagvr::FeedItemAttributeValue(),
                },
                GeoTargetingRestriction = gagve::GeoTargetingRestrictionEnum.Types.GeoTargetingRestriction.LocationOfPresence,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                Status = gagve::FeedItemStatusEnum.Types.FeedItemStatus.Enabled,
                PolicyInfos =
                {
                    new gagvr::FeedItemPlaceholderPolicyInfo(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFeedItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItem responseCallSettings = await client.GetFeedItemAsync(request.ResourceNameAsFeedItemName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedItem responseCancellationToken = await client.GetFeedItemAsync(request.ResourceNameAsFeedItemName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateFeedItemsRequestObject()
        {
            moq::Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new moq::Mock<FeedItemService.FeedItemServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemsRequest request = new MutateFeedItemsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateFeedItemsResponse expectedResponse = new MutateFeedItemsResponse
            {
                Results =
                {
                    new MutateFeedItemResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedItems(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemsResponse response = client.MutateFeedItems(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateFeedItemsRequestObjectAsync()
        {
            moq::Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new moq::Mock<FeedItemService.FeedItemServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemsRequest request = new MutateFeedItemsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateFeedItemsResponse expectedResponse = new MutateFeedItemsResponse
            {
                Results =
                {
                    new MutateFeedItemResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateFeedItemsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemsResponse responseCallSettings = await client.MutateFeedItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateFeedItemsResponse responseCancellationToken = await client.MutateFeedItemsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateFeedItems()
        {
            moq::Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new moq::Mock<FeedItemService.FeedItemServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemsRequest request = new MutateFeedItemsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemOperation(),
                },
            };
            MutateFeedItemsResponse expectedResponse = new MutateFeedItemsResponse
            {
                Results =
                {
                    new MutateFeedItemResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedItems(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemsResponse response = client.MutateFeedItems(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateFeedItemsAsync()
        {
            moq::Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new moq::Mock<FeedItemService.FeedItemServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemsRequest request = new MutateFeedItemsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemOperation(),
                },
            };
            MutateFeedItemsResponse expectedResponse = new MutateFeedItemsResponse
            {
                Results =
                {
                    new MutateFeedItemResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateFeedItemsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemsResponse responseCallSettings = await client.MutateFeedItemsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateFeedItemsResponse responseCancellationToken = await client.MutateFeedItemsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

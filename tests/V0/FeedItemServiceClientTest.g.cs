// Copyright 2018 Google LLC
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

// TODO( b/119694056): Removed Comment

namespace Google.Ads.GoogleAds.V0.Services.Tests
{
    using Google.Ads.GoogleAds.V0.Resources;
    using apis = Google.Ads.GoogleAds.V0.Services;
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using NUnit.Framework;

    /// <summary>Generated unit tests</summary>
    public class GeneratedFeedItemServiceClientTest
    {
        [Test]
        public void GetFeedItem()
        {
            Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new Mock<FeedItemService.FeedItemServiceClient>(MockBehavior.Strict);
            GetFeedItemRequest expectedRequest = new GetFeedItemRequest
            {
                ResourceName = new FeedItemName("[CUSTOMER]", "[FEED_ITEM]").ToString(),
            };
            FeedItem expectedResponse = new FeedItem
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedItem(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new FeedItemName("[CUSTOMER]", "[FEED_ITEM]").ToString();
            FeedItem response = client.GetFeedItem(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetFeedItemAsync()
        {
            Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new Mock<FeedItemService.FeedItemServiceClient>(MockBehavior.Strict);
            GetFeedItemRequest expectedRequest = new GetFeedItemRequest
            {
                ResourceName = new FeedItemName("[CUSTOMER]", "[FEED_ITEM]").ToString(),
            };
            FeedItem expectedResponse = new FeedItem
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedItemAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<FeedItem>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new FeedItemName("[CUSTOMER]", "[FEED_ITEM]").ToString();
            FeedItem response = await client.GetFeedItemAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetFeedItem2()
        {
            Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new Mock<FeedItemService.FeedItemServiceClient>(MockBehavior.Strict);
            GetFeedItemRequest request = new GetFeedItemRequest
            {
                ResourceName = new FeedItemName("[CUSTOMER]", "[FEED_ITEM]").ToString(),
            };
            FeedItem expectedResponse = new FeedItem
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedItem(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            FeedItem response = client.GetFeedItem(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetFeedItemAsync2()
        {
            Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new Mock<FeedItemService.FeedItemServiceClient>(MockBehavior.Strict);
            GetFeedItemRequest request = new GetFeedItemRequest
            {
                ResourceName = new FeedItemName("[CUSTOMER]", "[FEED_ITEM]").ToString(),
            };
            FeedItem expectedResponse = new FeedItem
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedItemAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<FeedItem>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            FeedItem response = await client.GetFeedItemAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateFeedItems()
        {
            Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new Mock<FeedItemService.FeedItemServiceClient>(MockBehavior.Strict);
            MutateFeedItemsRequest expectedRequest = new MutateFeedItemsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateFeedItemsResponse expectedResponse = new MutateFeedItemsResponse();
            mockGrpcClient.Setup(x => x.MutateFeedItems(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<FeedItemOperation> operations = new List<FeedItemOperation>();
            MutateFeedItemsResponse response = client.MutateFeedItems(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateFeedItemsAsync()
        {
            Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new Mock<FeedItemService.FeedItemServiceClient>(MockBehavior.Strict);
            MutateFeedItemsRequest expectedRequest = new MutateFeedItemsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateFeedItemsResponse expectedResponse = new MutateFeedItemsResponse();
            mockGrpcClient.Setup(x => x.MutateFeedItemsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateFeedItemsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<FeedItemOperation> operations = new List<FeedItemOperation>();
            MutateFeedItemsResponse response = await client.MutateFeedItemsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateFeedItems2()
        {
            Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new Mock<FeedItemService.FeedItemServiceClient>(MockBehavior.Strict);
            MutateFeedItemsRequest request = new MutateFeedItemsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateFeedItemsResponse expectedResponse = new MutateFeedItemsResponse();
            mockGrpcClient.Setup(x => x.MutateFeedItems(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemsResponse response = client.MutateFeedItems(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateFeedItemsAsync2()
        {
            Mock<FeedItemService.FeedItemServiceClient> mockGrpcClient = new Mock<FeedItemService.FeedItemServiceClient>(MockBehavior.Strict);
            MutateFeedItemsRequest request = new MutateFeedItemsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateFeedItemsResponse expectedResponse = new MutateFeedItemsResponse();
            mockGrpcClient.Setup(x => x.MutateFeedItemsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateFeedItemsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemServiceClient client = new FeedItemServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemsResponse response = await client.MutateFeedItemsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

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

namespace Google.Ads.GoogleAds.V3.Services.Tests
{
    using Google.Ads.GoogleAds.V3.Resources;
    using apis = Google.Ads.GoogleAds.V3.Services;
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
    public class GeneratedFeedServiceClientTest
    {
        [Test]
        public void GetFeed()
        {
            Mock<FeedService.FeedServiceClient> mockGrpcClient = new Mock<FeedService.FeedServiceClient>(MockBehavior.Strict);
            GetFeedRequest expectedRequest = new GetFeedRequest
            {
                ResourceName = new FeedName("[CUSTOMER]", "[FEED]").ToString(),
            };
            Feed expectedResponse = new Feed
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeed(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new FeedName("[CUSTOMER]", "[FEED]").ToString();
            Feed response = client.GetFeed(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetFeedAsync()
        {
            Mock<FeedService.FeedServiceClient> mockGrpcClient = new Mock<FeedService.FeedServiceClient>(MockBehavior.Strict);
            GetFeedRequest expectedRequest = new GetFeedRequest
            {
                ResourceName = new FeedName("[CUSTOMER]", "[FEED]").ToString(),
            };
            Feed expectedResponse = new Feed
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Feed>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new FeedName("[CUSTOMER]", "[FEED]").ToString();
            Feed response = await client.GetFeedAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetFeed2()
        {
            Mock<FeedService.FeedServiceClient> mockGrpcClient = new Mock<FeedService.FeedServiceClient>(MockBehavior.Strict);
            GetFeedRequest request = new GetFeedRequest
            {
                ResourceName = new FeedName("[CUSTOMER]", "[FEED]").ToString(),
            };
            Feed expectedResponse = new Feed
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeed(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            Feed response = client.GetFeed(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetFeedAsync2()
        {
            Mock<FeedService.FeedServiceClient> mockGrpcClient = new Mock<FeedService.FeedServiceClient>(MockBehavior.Strict);
            GetFeedRequest request = new GetFeedRequest
            {
                ResourceName = new FeedName("[CUSTOMER]", "[FEED]").ToString(),
            };
            Feed expectedResponse = new Feed
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Feed>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            Feed response = await client.GetFeedAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateFeeds()
        {
            Mock<FeedService.FeedServiceClient> mockGrpcClient = new Mock<FeedService.FeedServiceClient>(MockBehavior.Strict);
            MutateFeedsRequest expectedRequest = new MutateFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateFeedsResponse expectedResponse = new MutateFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateFeeds(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<FeedOperation> operations = new List<FeedOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateFeedsResponse response = client.MutateFeeds(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateFeedsAsync()
        {
            Mock<FeedService.FeedServiceClient> mockGrpcClient = new Mock<FeedService.FeedServiceClient>(MockBehavior.Strict);
            MutateFeedsRequest expectedRequest = new MutateFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateFeedsResponse expectedResponse = new MutateFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateFeedsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateFeedsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<FeedOperation> operations = new List<FeedOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateFeedsResponse response = await client.MutateFeedsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateFeeds2()
        {
            Mock<FeedService.FeedServiceClient> mockGrpcClient = new Mock<FeedService.FeedServiceClient>(MockBehavior.Strict);
            MutateFeedsRequest expectedRequest = new MutateFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateFeedsResponse expectedResponse = new MutateFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateFeeds(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<FeedOperation> operations = new List<FeedOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateFeedsResponse response = client.MutateFeeds(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateFeedsAsync2()
        {
            Mock<FeedService.FeedServiceClient> mockGrpcClient = new Mock<FeedService.FeedServiceClient>(MockBehavior.Strict);
            MutateFeedsRequest expectedRequest = new MutateFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateFeedsResponse expectedResponse = new MutateFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateFeedsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateFeedsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<FeedOperation> operations = new List<FeedOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateFeedsResponse response = await client.MutateFeedsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateFeeds3()
        {
            Mock<FeedService.FeedServiceClient> mockGrpcClient = new Mock<FeedService.FeedServiceClient>(MockBehavior.Strict);
            MutateFeedsRequest request = new MutateFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateFeedsResponse expectedResponse = new MutateFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateFeeds(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedsResponse response = client.MutateFeeds(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateFeedsAsync3()
        {
            Mock<FeedService.FeedServiceClient> mockGrpcClient = new Mock<FeedService.FeedServiceClient>(MockBehavior.Strict);
            MutateFeedsRequest request = new MutateFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateFeedsResponse expectedResponse = new MutateFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateFeedsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateFeedsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedsResponse response = await client.MutateFeedsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

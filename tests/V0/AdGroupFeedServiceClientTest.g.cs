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
    public class GeneratedAdGroupFeedServiceClientTest
    {
        [Test]
        public void GetAdGroupFeed()
        {
            Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new Mock<AdGroupFeedService.AdGroupFeedServiceClient>(MockBehavior.Strict);
            GetAdGroupFeedRequest expectedRequest = new GetAdGroupFeedRequest
            {
                ResourceName = new AdGroupFeedName("[CUSTOMER]", "[AD_GROUP_FEED]").ToString(),
            };
            AdGroupFeed expectedResponse = new AdGroupFeed
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupFeed(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupFeedName("[CUSTOMER]", "[AD_GROUP_FEED]").ToString();
            AdGroupFeed response = client.GetAdGroupFeed(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupFeedAsync()
        {
            Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new Mock<AdGroupFeedService.AdGroupFeedServiceClient>(MockBehavior.Strict);
            GetAdGroupFeedRequest expectedRequest = new GetAdGroupFeedRequest
            {
                ResourceName = new AdGroupFeedName("[CUSTOMER]", "[AD_GROUP_FEED]").ToString(),
            };
            AdGroupFeed expectedResponse = new AdGroupFeed
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupFeedAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupFeed>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupFeedName("[CUSTOMER]", "[AD_GROUP_FEED]").ToString();
            AdGroupFeed response = await client.GetAdGroupFeedAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroupFeed2()
        {
            Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new Mock<AdGroupFeedService.AdGroupFeedServiceClient>(MockBehavior.Strict);
            GetAdGroupFeedRequest request = new GetAdGroupFeedRequest
            {
                ResourceName = new AdGroupFeedName("[CUSTOMER]", "[AD_GROUP_FEED]").ToString(),
            };
            AdGroupFeed expectedResponse = new AdGroupFeed
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupFeed(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupFeed response = client.GetAdGroupFeed(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupFeedAsync2()
        {
            Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new Mock<AdGroupFeedService.AdGroupFeedServiceClient>(MockBehavior.Strict);
            GetAdGroupFeedRequest request = new GetAdGroupFeedRequest
            {
                ResourceName = new AdGroupFeedName("[CUSTOMER]", "[AD_GROUP_FEED]").ToString(),
            };
            AdGroupFeed expectedResponse = new AdGroupFeed
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupFeedAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupFeed>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupFeed response = await client.GetAdGroupFeedAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupFeeds()
        {
            Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new Mock<AdGroupFeedService.AdGroupFeedServiceClient>(MockBehavior.Strict);
            MutateAdGroupFeedsRequest expectedRequest = new MutateAdGroupFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupFeedsResponse expectedResponse = new MutateAdGroupFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupFeeds(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupFeedOperation> operations = new List<AdGroupFeedOperation>();
            MutateAdGroupFeedsResponse response = client.MutateAdGroupFeeds(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupFeedsAsync()
        {
            Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new Mock<AdGroupFeedService.AdGroupFeedServiceClient>(MockBehavior.Strict);
            MutateAdGroupFeedsRequest expectedRequest = new MutateAdGroupFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupFeedsResponse expectedResponse = new MutateAdGroupFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupFeedsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupFeedsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupFeedOperation> operations = new List<AdGroupFeedOperation>();
            MutateAdGroupFeedsResponse response = await client.MutateAdGroupFeedsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupFeeds2()
        {
            Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new Mock<AdGroupFeedService.AdGroupFeedServiceClient>(MockBehavior.Strict);
            MutateAdGroupFeedsRequest request = new MutateAdGroupFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupFeedsResponse expectedResponse = new MutateAdGroupFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupFeeds(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupFeedsResponse response = client.MutateAdGroupFeeds(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupFeedsAsync2()
        {
            Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new Mock<AdGroupFeedService.AdGroupFeedServiceClient>(MockBehavior.Strict);
            MutateAdGroupFeedsRequest request = new MutateAdGroupFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupFeedsResponse expectedResponse = new MutateAdGroupFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupFeedsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupFeedsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupFeedsResponse response = await client.MutateAdGroupFeedsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

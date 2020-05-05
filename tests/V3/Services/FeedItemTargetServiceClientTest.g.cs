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
    public class GeneratedFeedItemTargetServiceClientTest
    {
        [Test]
        public void GetFeedItemTarget()
        {
            Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new Mock<FeedItemTargetService.FeedItemTargetServiceClient>(MockBehavior.Strict);
            GetFeedItemTargetRequest expectedRequest = new GetFeedItemTargetRequest
            {
                ResourceName = new FeedItemTargetName("[CUSTOMER]", "[FEED_ITEM_TARGET]").ToString(),
            };
            FeedItemTarget expectedResponse = new FeedItemTarget
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedItemTarget(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new FeedItemTargetName("[CUSTOMER]", "[FEED_ITEM_TARGET]").ToString();
            FeedItemTarget response = client.GetFeedItemTarget(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetFeedItemTargetAsync()
        {
            Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new Mock<FeedItemTargetService.FeedItemTargetServiceClient>(MockBehavior.Strict);
            GetFeedItemTargetRequest expectedRequest = new GetFeedItemTargetRequest
            {
                ResourceName = new FeedItemTargetName("[CUSTOMER]", "[FEED_ITEM_TARGET]").ToString(),
            };
            FeedItemTarget expectedResponse = new FeedItemTarget
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedItemTargetAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<FeedItemTarget>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new FeedItemTargetName("[CUSTOMER]", "[FEED_ITEM_TARGET]").ToString();
            FeedItemTarget response = await client.GetFeedItemTargetAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetFeedItemTarget2()
        {
            Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new Mock<FeedItemTargetService.FeedItemTargetServiceClient>(MockBehavior.Strict);
            GetFeedItemTargetRequest request = new GetFeedItemTargetRequest
            {
                ResourceName = new FeedItemTargetName("[CUSTOMER]", "[FEED_ITEM_TARGET]").ToString(),
            };
            FeedItemTarget expectedResponse = new FeedItemTarget
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedItemTarget(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            FeedItemTarget response = client.GetFeedItemTarget(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetFeedItemTargetAsync2()
        {
            Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new Mock<FeedItemTargetService.FeedItemTargetServiceClient>(MockBehavior.Strict);
            GetFeedItemTargetRequest request = new GetFeedItemTargetRequest
            {
                ResourceName = new FeedItemTargetName("[CUSTOMER]", "[FEED_ITEM_TARGET]").ToString(),
            };
            FeedItemTarget expectedResponse = new FeedItemTarget
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedItemTargetAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<FeedItemTarget>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            FeedItemTarget response = await client.GetFeedItemTargetAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateFeedItemTargets()
        {
            Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new Mock<FeedItemTargetService.FeedItemTargetServiceClient>(MockBehavior.Strict);
            MutateFeedItemTargetsRequest expectedRequest = new MutateFeedItemTargetsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateFeedItemTargetsResponse expectedResponse = new MutateFeedItemTargetsResponse();
            mockGrpcClient.Setup(x => x.MutateFeedItemTargets(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<FeedItemTargetOperation> operations = new List<FeedItemTargetOperation>();
            MutateFeedItemTargetsResponse response = client.MutateFeedItemTargets(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateFeedItemTargetsAsync()
        {
            Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new Mock<FeedItemTargetService.FeedItemTargetServiceClient>(MockBehavior.Strict);
            MutateFeedItemTargetsRequest expectedRequest = new MutateFeedItemTargetsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateFeedItemTargetsResponse expectedResponse = new MutateFeedItemTargetsResponse();
            mockGrpcClient.Setup(x => x.MutateFeedItemTargetsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateFeedItemTargetsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<FeedItemTargetOperation> operations = new List<FeedItemTargetOperation>();
            MutateFeedItemTargetsResponse response = await client.MutateFeedItemTargetsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateFeedItemTargets2()
        {
            Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new Mock<FeedItemTargetService.FeedItemTargetServiceClient>(MockBehavior.Strict);
            MutateFeedItemTargetsRequest request = new MutateFeedItemTargetsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateFeedItemTargetsResponse expectedResponse = new MutateFeedItemTargetsResponse();
            mockGrpcClient.Setup(x => x.MutateFeedItemTargets(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemTargetsResponse response = client.MutateFeedItemTargets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateFeedItemTargetsAsync2()
        {
            Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new Mock<FeedItemTargetService.FeedItemTargetServiceClient>(MockBehavior.Strict);
            MutateFeedItemTargetsRequest request = new MutateFeedItemTargetsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateFeedItemTargetsResponse expectedResponse = new MutateFeedItemTargetsResponse();
            mockGrpcClient.Setup(x => x.MutateFeedItemTargetsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateFeedItemTargetsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemTargetsResponse response = await client.MutateFeedItemTargetsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

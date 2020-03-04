// Copyright 2019 Google LLC
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
    public class GeneratedFeedPlaceholderViewServiceClientTest
    {
        [Test]
        public void GetFeedPlaceholderView()
        {
            Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient> mockGrpcClient = new Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient>(MockBehavior.Strict);
            GetFeedPlaceholderViewRequest expectedRequest = new GetFeedPlaceholderViewRequest
            {
                ResourceName = new FeedPlaceholderViewName("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]").ToString(),
            };
            FeedPlaceholderView expectedResponse = new FeedPlaceholderView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedPlaceholderView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedPlaceholderViewServiceClient client = new FeedPlaceholderViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new FeedPlaceholderViewName("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]").ToString();
            FeedPlaceholderView response = client.GetFeedPlaceholderView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetFeedPlaceholderViewAsync()
        {
            Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient> mockGrpcClient = new Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient>(MockBehavior.Strict);
            GetFeedPlaceholderViewRequest expectedRequest = new GetFeedPlaceholderViewRequest
            {
                ResourceName = new FeedPlaceholderViewName("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]").ToString(),
            };
            FeedPlaceholderView expectedResponse = new FeedPlaceholderView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedPlaceholderViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<FeedPlaceholderView>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedPlaceholderViewServiceClient client = new FeedPlaceholderViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new FeedPlaceholderViewName("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]").ToString();
            FeedPlaceholderView response = await client.GetFeedPlaceholderViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetFeedPlaceholderView2()
        {
            Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient> mockGrpcClient = new Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient>(MockBehavior.Strict);
            GetFeedPlaceholderViewRequest request = new GetFeedPlaceholderViewRequest
            {
                ResourceName = new FeedPlaceholderViewName("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]").ToString(),
            };
            FeedPlaceholderView expectedResponse = new FeedPlaceholderView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedPlaceholderView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedPlaceholderViewServiceClient client = new FeedPlaceholderViewServiceClientImpl(mockGrpcClient.Object, null);
            FeedPlaceholderView response = client.GetFeedPlaceholderView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetFeedPlaceholderViewAsync2()
        {
            Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient> mockGrpcClient = new Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient>(MockBehavior.Strict);
            GetFeedPlaceholderViewRequest request = new GetFeedPlaceholderViewRequest
            {
                ResourceName = new FeedPlaceholderViewName("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]").ToString(),
            };
            FeedPlaceholderView expectedResponse = new FeedPlaceholderView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedPlaceholderViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<FeedPlaceholderView>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedPlaceholderViewServiceClient client = new FeedPlaceholderViewServiceClientImpl(mockGrpcClient.Object, null);
            FeedPlaceholderView response = await client.GetFeedPlaceholderViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

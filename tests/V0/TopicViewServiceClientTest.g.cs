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

// Generated code. DO NOT EDIT!

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
    public class GeneratedTopicViewServiceClientTest
    {
        [Test]
        public void GetTopicView()
        {
            Mock<TopicViewService.TopicViewServiceClient> mockGrpcClient = new Mock<TopicViewService.TopicViewServiceClient>(MockBehavior.Strict);
            GetTopicViewRequest expectedRequest = new GetTopicViewRequest
            {
                ResourceName = new TopicViewName("[CUSTOMER]", "[TOPIC_VIEW]").ToString(),
            };
            TopicView expectedResponse = new TopicView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetTopicView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TopicViewServiceClient client = new TopicViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new TopicViewName("[CUSTOMER]", "[TOPIC_VIEW]").ToString();
            TopicView response = client.GetTopicView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetTopicViewAsync()
        {
            Mock<TopicViewService.TopicViewServiceClient> mockGrpcClient = new Mock<TopicViewService.TopicViewServiceClient>(MockBehavior.Strict);
            GetTopicViewRequest expectedRequest = new GetTopicViewRequest
            {
                ResourceName = new TopicViewName("[CUSTOMER]", "[TOPIC_VIEW]").ToString(),
            };
            TopicView expectedResponse = new TopicView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetTopicViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TopicView>(Task.FromResult(expectedResponse), null, null, null, null));
            TopicViewServiceClient client = new TopicViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new TopicViewName("[CUSTOMER]", "[TOPIC_VIEW]").ToString();
            TopicView response = await client.GetTopicViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetTopicView2()
        {
            Mock<TopicViewService.TopicViewServiceClient> mockGrpcClient = new Mock<TopicViewService.TopicViewServiceClient>(MockBehavior.Strict);
            GetTopicViewRequest request = new GetTopicViewRequest
            {
                ResourceName = new TopicViewName("[CUSTOMER]", "[TOPIC_VIEW]").ToString(),
            };
            TopicView expectedResponse = new TopicView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetTopicView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TopicViewServiceClient client = new TopicViewServiceClientImpl(mockGrpcClient.Object, null);
            TopicView response = client.GetTopicView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetTopicViewAsync2()
        {
            Mock<TopicViewService.TopicViewServiceClient> mockGrpcClient = new Mock<TopicViewService.TopicViewServiceClient>(MockBehavior.Strict);
            GetTopicViewRequest request = new GetTopicViewRequest
            {
                ResourceName = new TopicViewName("[CUSTOMER]", "[TOPIC_VIEW]").ToString(),
            };
            TopicView expectedResponse = new TopicView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetTopicViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TopicView>(Task.FromResult(expectedResponse), null, null, null, null));
            TopicViewServiceClient client = new TopicViewServiceClientImpl(mockGrpcClient.Object, null);
            TopicView response = await client.GetTopicViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

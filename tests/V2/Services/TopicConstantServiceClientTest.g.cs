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

namespace Google.Ads.GoogleAds.V2.Services.Tests
{
    using Google.Ads.GoogleAds.V2.Resources;
    using apis = Google.Ads.GoogleAds.V2.Services;
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
    public class GeneratedTopicConstantServiceClientTest
    {
        [Test]
        public void GetTopicConstant()
        {
            Mock<TopicConstantService.TopicConstantServiceClient> mockGrpcClient = new Mock<TopicConstantService.TopicConstantServiceClient>(MockBehavior.Strict);
            GetTopicConstantRequest expectedRequest = new GetTopicConstantRequest
            {
                ResourceName = new TopicConstantName("[TOPIC_CONSTANT]").ToString(),
            };
            TopicConstant expectedResponse = new TopicConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetTopicConstant(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TopicConstantServiceClient client = new TopicConstantServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new TopicConstantName("[TOPIC_CONSTANT]").ToString();
            TopicConstant response = client.GetTopicConstant(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetTopicConstantAsync()
        {
            Mock<TopicConstantService.TopicConstantServiceClient> mockGrpcClient = new Mock<TopicConstantService.TopicConstantServiceClient>(MockBehavior.Strict);
            GetTopicConstantRequest expectedRequest = new GetTopicConstantRequest
            {
                ResourceName = new TopicConstantName("[TOPIC_CONSTANT]").ToString(),
            };
            TopicConstant expectedResponse = new TopicConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetTopicConstantAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TopicConstant>(Task.FromResult(expectedResponse), null, null, null, null));
            TopicConstantServiceClient client = new TopicConstantServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new TopicConstantName("[TOPIC_CONSTANT]").ToString();
            TopicConstant response = await client.GetTopicConstantAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetTopicConstant2()
        {
            Mock<TopicConstantService.TopicConstantServiceClient> mockGrpcClient = new Mock<TopicConstantService.TopicConstantServiceClient>(MockBehavior.Strict);
            GetTopicConstantRequest request = new GetTopicConstantRequest
            {
                ResourceName = new TopicConstantName("[TOPIC_CONSTANT]").ToString(),
            };
            TopicConstant expectedResponse = new TopicConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetTopicConstant(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            TopicConstantServiceClient client = new TopicConstantServiceClientImpl(mockGrpcClient.Object, null);
            TopicConstant response = client.GetTopicConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetTopicConstantAsync2()
        {
            Mock<TopicConstantService.TopicConstantServiceClient> mockGrpcClient = new Mock<TopicConstantService.TopicConstantServiceClient>(MockBehavior.Strict);
            GetTopicConstantRequest request = new GetTopicConstantRequest
            {
                ResourceName = new TopicConstantName("[TOPIC_CONSTANT]").ToString(),
            };
            TopicConstant expectedResponse = new TopicConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetTopicConstantAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<TopicConstant>(Task.FromResult(expectedResponse), null, null, null, null));
            TopicConstantServiceClient client = new TopicConstantServiceClientImpl(mockGrpcClient.Object, null);
            TopicConstant response = await client.GetTopicConstantAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

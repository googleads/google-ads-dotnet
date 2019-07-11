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
    public class GeneratedVideoServiceClientTest
    {
        [Test]
        public void GetVideo()
        {
            Mock<VideoService.VideoServiceClient> mockGrpcClient = new Mock<VideoService.VideoServiceClient>(MockBehavior.Strict);
            GetVideoRequest expectedRequest = new GetVideoRequest
            {
                ResourceName = new VideoName("[CUSTOMER]", "[VIDEO]").ToString(),
            };
            Video expectedResponse = new Video
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetVideo(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            VideoServiceClient client = new VideoServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new VideoName("[CUSTOMER]", "[VIDEO]").ToString();
            Video response = client.GetVideo(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetVideoAsync()
        {
            Mock<VideoService.VideoServiceClient> mockGrpcClient = new Mock<VideoService.VideoServiceClient>(MockBehavior.Strict);
            GetVideoRequest expectedRequest = new GetVideoRequest
            {
                ResourceName = new VideoName("[CUSTOMER]", "[VIDEO]").ToString(),
            };
            Video expectedResponse = new Video
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetVideoAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Video>(Task.FromResult(expectedResponse), null, null, null, null));
            VideoServiceClient client = new VideoServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new VideoName("[CUSTOMER]", "[VIDEO]").ToString();
            Video response = await client.GetVideoAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetVideo2()
        {
            Mock<VideoService.VideoServiceClient> mockGrpcClient = new Mock<VideoService.VideoServiceClient>(MockBehavior.Strict);
            GetVideoRequest request = new GetVideoRequest
            {
                ResourceName = new VideoName("[CUSTOMER]", "[VIDEO]").ToString(),
            };
            Video expectedResponse = new Video
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetVideo(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            VideoServiceClient client = new VideoServiceClientImpl(mockGrpcClient.Object, null);
            Video response = client.GetVideo(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetVideoAsync2()
        {
            Mock<VideoService.VideoServiceClient> mockGrpcClient = new Mock<VideoService.VideoServiceClient>(MockBehavior.Strict);
            GetVideoRequest request = new GetVideoRequest
            {
                ResourceName = new VideoName("[CUSTOMER]", "[VIDEO]").ToString(),
            };
            Video expectedResponse = new Video
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetVideoAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Video>(Task.FromResult(expectedResponse), null, null, null, null));
            VideoServiceClient client = new VideoServiceClientImpl(mockGrpcClient.Object, null);
            Video response = await client.GetVideoAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

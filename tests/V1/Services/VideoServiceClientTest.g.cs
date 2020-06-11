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

using gagvr = Google.Ads.GoogleAds.V1.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V1.Services;

namespace Google.Ads.GoogleAds.Tests.V1.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedVideoServiceClientTest
    {
        [Test]
        public void GetVideoRequestObject()
        {
            moq::Mock<VideoService.VideoServiceClient> mockGrpcClient = new moq::Mock<VideoService.VideoServiceClient>(moq::MockBehavior.Strict);
            GetVideoRequest request = new GetVideoRequest
            {
                ResourceNameAsVideoName = gagvr::VideoName.FromCustomerVideo("[CUSTOMER]", "[VIDEO]"),
            };
            gagvr::Video expectedResponse = new gagvr::Video
            {
                ResourceNameAsVideoName = gagvr::VideoName.FromCustomerVideo("[CUSTOMER]", "[VIDEO]"),
                Id = "id74b70bb8",
                ChannelId = "channel_id856ceb72",
                DurationMillis = 4964327688054496886L,
                Title = "title17dbd3d5",
            };
            mockGrpcClient.Setup(x => x.GetVideo(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoServiceClient client = new VideoServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Video response = client.GetVideo(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetVideoRequestObjectAsync()
        {
            moq::Mock<VideoService.VideoServiceClient> mockGrpcClient = new moq::Mock<VideoService.VideoServiceClient>(moq::MockBehavior.Strict);
            GetVideoRequest request = new GetVideoRequest
            {
                ResourceNameAsVideoName = gagvr::VideoName.FromCustomerVideo("[CUSTOMER]", "[VIDEO]"),
            };
            gagvr::Video expectedResponse = new gagvr::Video
            {
                ResourceNameAsVideoName = gagvr::VideoName.FromCustomerVideo("[CUSTOMER]", "[VIDEO]"),
                Id = "id74b70bb8",
                ChannelId = "channel_id856ceb72",
                DurationMillis = 4964327688054496886L,
                Title = "title17dbd3d5",
            };
            mockGrpcClient.Setup(x => x.GetVideoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Video>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoServiceClient client = new VideoServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Video responseCallSettings = await client.GetVideoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Video responseCancellationToken = await client.GetVideoAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetVideo()
        {
            moq::Mock<VideoService.VideoServiceClient> mockGrpcClient = new moq::Mock<VideoService.VideoServiceClient>(moq::MockBehavior.Strict);
            GetVideoRequest request = new GetVideoRequest
            {
                ResourceNameAsVideoName = gagvr::VideoName.FromCustomerVideo("[CUSTOMER]", "[VIDEO]"),
            };
            gagvr::Video expectedResponse = new gagvr::Video
            {
                ResourceNameAsVideoName = gagvr::VideoName.FromCustomerVideo("[CUSTOMER]", "[VIDEO]"),
                Id = "id74b70bb8",
                ChannelId = "channel_id856ceb72",
                DurationMillis = 4964327688054496886L,
                Title = "title17dbd3d5",
            };
            mockGrpcClient.Setup(x => x.GetVideo(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoServiceClient client = new VideoServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Video response = client.GetVideo(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetVideoAsync()
        {
            moq::Mock<VideoService.VideoServiceClient> mockGrpcClient = new moq::Mock<VideoService.VideoServiceClient>(moq::MockBehavior.Strict);
            GetVideoRequest request = new GetVideoRequest
            {
                ResourceNameAsVideoName = gagvr::VideoName.FromCustomerVideo("[CUSTOMER]", "[VIDEO]"),
            };
            gagvr::Video expectedResponse = new gagvr::Video
            {
                ResourceNameAsVideoName = gagvr::VideoName.FromCustomerVideo("[CUSTOMER]", "[VIDEO]"),
                Id = "id74b70bb8",
                ChannelId = "channel_id856ceb72",
                DurationMillis = 4964327688054496886L,
                Title = "title17dbd3d5",
            };
            mockGrpcClient.Setup(x => x.GetVideoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Video>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoServiceClient client = new VideoServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Video responseCallSettings = await client.GetVideoAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Video responseCancellationToken = await client.GetVideoAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetVideoResourceNames()
        {
            moq::Mock<VideoService.VideoServiceClient> mockGrpcClient = new moq::Mock<VideoService.VideoServiceClient>(moq::MockBehavior.Strict);
            GetVideoRequest request = new GetVideoRequest
            {
                ResourceNameAsVideoName = gagvr::VideoName.FromCustomerVideo("[CUSTOMER]", "[VIDEO]"),
            };
            gagvr::Video expectedResponse = new gagvr::Video
            {
                ResourceNameAsVideoName = gagvr::VideoName.FromCustomerVideo("[CUSTOMER]", "[VIDEO]"),
                Id = "id74b70bb8",
                ChannelId = "channel_id856ceb72",
                DurationMillis = 4964327688054496886L,
                Title = "title17dbd3d5",
            };
            mockGrpcClient.Setup(x => x.GetVideo(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VideoServiceClient client = new VideoServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Video response = client.GetVideo(request.ResourceNameAsVideoName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetVideoResourceNamesAsync()
        {
            moq::Mock<VideoService.VideoServiceClient> mockGrpcClient = new moq::Mock<VideoService.VideoServiceClient>(moq::MockBehavior.Strict);
            GetVideoRequest request = new GetVideoRequest
            {
                ResourceNameAsVideoName = gagvr::VideoName.FromCustomerVideo("[CUSTOMER]", "[VIDEO]"),
            };
            gagvr::Video expectedResponse = new gagvr::Video
            {
                ResourceNameAsVideoName = gagvr::VideoName.FromCustomerVideo("[CUSTOMER]", "[VIDEO]"),
                Id = "id74b70bb8",
                ChannelId = "channel_id856ceb72",
                DurationMillis = 4964327688054496886L,
                Title = "title17dbd3d5",
            };
            mockGrpcClient.Setup(x => x.GetVideoAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Video>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VideoServiceClient client = new VideoServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Video responseCallSettings = await client.GetVideoAsync(request.ResourceNameAsVideoName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Video responseCancellationToken = await client.GetVideoAsync(request.ResourceNameAsVideoName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

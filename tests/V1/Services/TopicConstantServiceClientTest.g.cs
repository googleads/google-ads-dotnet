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
    public sealed class GeneratedTopicConstantServiceClientTest
    {
        [Test]
        public void GetTopicConstantRequestObject()
        {
            moq::Mock<TopicConstantService.TopicConstantServiceClient> mockGrpcClient = new moq::Mock<TopicConstantService.TopicConstantServiceClient>(moq::MockBehavior.Strict);
            GetTopicConstantRequest request = new GetTopicConstantRequest
            {
                ResourceNameAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
            };
            gagvr::TopicConstant expectedResponse = new gagvr::TopicConstant
            {
                ResourceNameAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
                Id = -6774108720365892680L,
                TopicConstantParentAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
                Path = { "path0b1dfed6", },
            };
            mockGrpcClient.Setup(x => x.GetTopicConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TopicConstantServiceClient client = new TopicConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::TopicConstant response = client.GetTopicConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetTopicConstantRequestObjectAsync()
        {
            moq::Mock<TopicConstantService.TopicConstantServiceClient> mockGrpcClient = new moq::Mock<TopicConstantService.TopicConstantServiceClient>(moq::MockBehavior.Strict);
            GetTopicConstantRequest request = new GetTopicConstantRequest
            {
                ResourceNameAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
            };
            gagvr::TopicConstant expectedResponse = new gagvr::TopicConstant
            {
                ResourceNameAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
                Id = -6774108720365892680L,
                TopicConstantParentAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
                Path = { "path0b1dfed6", },
            };
            mockGrpcClient.Setup(x => x.GetTopicConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::TopicConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TopicConstantServiceClient client = new TopicConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::TopicConstant responseCallSettings = await client.GetTopicConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::TopicConstant responseCancellationToken = await client.GetTopicConstantAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetTopicConstant()
        {
            moq::Mock<TopicConstantService.TopicConstantServiceClient> mockGrpcClient = new moq::Mock<TopicConstantService.TopicConstantServiceClient>(moq::MockBehavior.Strict);
            GetTopicConstantRequest request = new GetTopicConstantRequest
            {
                ResourceNameAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
            };
            gagvr::TopicConstant expectedResponse = new gagvr::TopicConstant
            {
                ResourceNameAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
                Id = -6774108720365892680L,
                TopicConstantParentAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
                Path = { "path0b1dfed6", },
            };
            mockGrpcClient.Setup(x => x.GetTopicConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TopicConstantServiceClient client = new TopicConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::TopicConstant response = client.GetTopicConstant(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetTopicConstantAsync()
        {
            moq::Mock<TopicConstantService.TopicConstantServiceClient> mockGrpcClient = new moq::Mock<TopicConstantService.TopicConstantServiceClient>(moq::MockBehavior.Strict);
            GetTopicConstantRequest request = new GetTopicConstantRequest
            {
                ResourceNameAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
            };
            gagvr::TopicConstant expectedResponse = new gagvr::TopicConstant
            {
                ResourceNameAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
                Id = -6774108720365892680L,
                TopicConstantParentAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
                Path = { "path0b1dfed6", },
            };
            mockGrpcClient.Setup(x => x.GetTopicConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::TopicConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TopicConstantServiceClient client = new TopicConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::TopicConstant responseCallSettings = await client.GetTopicConstantAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::TopicConstant responseCancellationToken = await client.GetTopicConstantAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetTopicConstantResourceNames()
        {
            moq::Mock<TopicConstantService.TopicConstantServiceClient> mockGrpcClient = new moq::Mock<TopicConstantService.TopicConstantServiceClient>(moq::MockBehavior.Strict);
            GetTopicConstantRequest request = new GetTopicConstantRequest
            {
                ResourceNameAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
            };
            gagvr::TopicConstant expectedResponse = new gagvr::TopicConstant
            {
                ResourceNameAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
                Id = -6774108720365892680L,
                TopicConstantParentAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
                Path = { "path0b1dfed6", },
            };
            mockGrpcClient.Setup(x => x.GetTopicConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TopicConstantServiceClient client = new TopicConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::TopicConstant response = client.GetTopicConstant(request.ResourceNameAsTopicConstantName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetTopicConstantResourceNamesAsync()
        {
            moq::Mock<TopicConstantService.TopicConstantServiceClient> mockGrpcClient = new moq::Mock<TopicConstantService.TopicConstantServiceClient>(moq::MockBehavior.Strict);
            GetTopicConstantRequest request = new GetTopicConstantRequest
            {
                ResourceNameAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
            };
            gagvr::TopicConstant expectedResponse = new gagvr::TopicConstant
            {
                ResourceNameAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
                Id = -6774108720365892680L,
                TopicConstantParentAsTopicConstantName = gagvr::TopicConstantName.FromTopicConstant("[TOPIC_CONSTANT]"),
                Path = { "path0b1dfed6", },
            };
            mockGrpcClient.Setup(x => x.GetTopicConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::TopicConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TopicConstantServiceClient client = new TopicConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::TopicConstant responseCallSettings = await client.GetTopicConstantAsync(request.ResourceNameAsTopicConstantName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::TopicConstant responseCancellationToken = await client.GetTopicConstantAsync(request.ResourceNameAsTopicConstantName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

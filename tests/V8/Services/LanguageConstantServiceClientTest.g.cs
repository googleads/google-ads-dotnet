// Copyright 2021 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V8.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V8.Services;

namespace Google.Ads.GoogleAds.Tests.V8.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedLanguageConstantServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetLanguageConstantRequestObject()
        {
            moq::Mock<LanguageConstantService.LanguageConstantServiceClient> mockGrpcClient = new moq::Mock<LanguageConstantService.LanguageConstantServiceClient>(moq::MockBehavior.Strict);
            GetLanguageConstantRequest request = new GetLanguageConstantRequest
            {
                ResourceNameAsLanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::LanguageConstant expectedResponse = new gagvr::LanguageConstant
            {
                ResourceNameAsLanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
                Id = -6774108720365892680L,
                Code = "code946733c1",
                LanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
                Targetable = true,
            };
            mockGrpcClient.Setup(x => x.GetLanguageConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageConstantServiceClient client = new LanguageConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LanguageConstant response = client.GetLanguageConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetLanguageConstantRequestObjectAsync()
        {
            moq::Mock<LanguageConstantService.LanguageConstantServiceClient> mockGrpcClient = new moq::Mock<LanguageConstantService.LanguageConstantServiceClient>(moq::MockBehavior.Strict);
            GetLanguageConstantRequest request = new GetLanguageConstantRequest
            {
                ResourceNameAsLanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::LanguageConstant expectedResponse = new gagvr::LanguageConstant
            {
                ResourceNameAsLanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
                Id = -6774108720365892680L,
                Code = "code946733c1",
                LanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
                Targetable = true,
            };
            mockGrpcClient.Setup(x => x.GetLanguageConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::LanguageConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageConstantServiceClient client = new LanguageConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LanguageConstant responseCallSettings = await client.GetLanguageConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::LanguageConstant responseCancellationToken = await client.GetLanguageConstantAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetLanguageConstant()
        {
            moq::Mock<LanguageConstantService.LanguageConstantServiceClient> mockGrpcClient = new moq::Mock<LanguageConstantService.LanguageConstantServiceClient>(moq::MockBehavior.Strict);
            GetLanguageConstantRequest request = new GetLanguageConstantRequest
            {
                ResourceNameAsLanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::LanguageConstant expectedResponse = new gagvr::LanguageConstant
            {
                ResourceNameAsLanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
                Id = -6774108720365892680L,
                Code = "code946733c1",
                LanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
                Targetable = true,
            };
            mockGrpcClient.Setup(x => x.GetLanguageConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageConstantServiceClient client = new LanguageConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LanguageConstant response = client.GetLanguageConstant(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetLanguageConstantAsync()
        {
            moq::Mock<LanguageConstantService.LanguageConstantServiceClient> mockGrpcClient = new moq::Mock<LanguageConstantService.LanguageConstantServiceClient>(moq::MockBehavior.Strict);
            GetLanguageConstantRequest request = new GetLanguageConstantRequest
            {
                ResourceNameAsLanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::LanguageConstant expectedResponse = new gagvr::LanguageConstant
            {
                ResourceNameAsLanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
                Id = -6774108720365892680L,
                Code = "code946733c1",
                LanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
                Targetable = true,
            };
            mockGrpcClient.Setup(x => x.GetLanguageConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::LanguageConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageConstantServiceClient client = new LanguageConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LanguageConstant responseCallSettings = await client.GetLanguageConstantAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::LanguageConstant responseCancellationToken = await client.GetLanguageConstantAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetLanguageConstantResourceNames()
        {
            moq::Mock<LanguageConstantService.LanguageConstantServiceClient> mockGrpcClient = new moq::Mock<LanguageConstantService.LanguageConstantServiceClient>(moq::MockBehavior.Strict);
            GetLanguageConstantRequest request = new GetLanguageConstantRequest
            {
                ResourceNameAsLanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::LanguageConstant expectedResponse = new gagvr::LanguageConstant
            {
                ResourceNameAsLanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
                Id = -6774108720365892680L,
                Code = "code946733c1",
                LanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
                Targetable = true,
            };
            mockGrpcClient.Setup(x => x.GetLanguageConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LanguageConstantServiceClient client = new LanguageConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LanguageConstant response = client.GetLanguageConstant(request.ResourceNameAsLanguageConstantName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetLanguageConstantResourceNamesAsync()
        {
            moq::Mock<LanguageConstantService.LanguageConstantServiceClient> mockGrpcClient = new moq::Mock<LanguageConstantService.LanguageConstantServiceClient>(moq::MockBehavior.Strict);
            GetLanguageConstantRequest request = new GetLanguageConstantRequest
            {
                ResourceNameAsLanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::LanguageConstant expectedResponse = new gagvr::LanguageConstant
            {
                ResourceNameAsLanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
                Id = -6774108720365892680L,
                Code = "code946733c1",
                LanguageConstantName = gagvr::LanguageConstantName.FromCriterion("[CRITERION_ID]"),
                Targetable = true,
            };
            mockGrpcClient.Setup(x => x.GetLanguageConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::LanguageConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LanguageConstantServiceClient client = new LanguageConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LanguageConstant responseCallSettings = await client.GetLanguageConstantAsync(request.ResourceNameAsLanguageConstantName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::LanguageConstant responseCancellationToken = await client.GetLanguageConstantAsync(request.ResourceNameAsLanguageConstantName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

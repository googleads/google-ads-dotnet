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

using gagvr = Google.Ads.GoogleAds.V7.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V7.Services;

namespace Google.Ads.GoogleAds.Tests.V7.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedMobileAppCategoryConstantServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetMobileAppCategoryConstantRequestObject()
        {
            moq::Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient> mockGrpcClient = new moq::Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient>(moq::MockBehavior.Strict);
            GetMobileAppCategoryConstantRequest request = new GetMobileAppCategoryConstantRequest
            {
                ResourceNameAsMobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
            };
            gagvr::MobileAppCategoryConstant expectedResponse = new gagvr::MobileAppCategoryConstant
            {
                ResourceNameAsMobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
                Id = 1958153144,
                MobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetMobileAppCategoryConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MobileAppCategoryConstantServiceClient client = new MobileAppCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MobileAppCategoryConstant response = client.GetMobileAppCategoryConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetMobileAppCategoryConstantRequestObjectAsync()
        {
            moq::Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient> mockGrpcClient = new moq::Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient>(moq::MockBehavior.Strict);
            GetMobileAppCategoryConstantRequest request = new GetMobileAppCategoryConstantRequest
            {
                ResourceNameAsMobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
            };
            gagvr::MobileAppCategoryConstant expectedResponse = new gagvr::MobileAppCategoryConstant
            {
                ResourceNameAsMobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
                Id = 1958153144,
                MobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetMobileAppCategoryConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::MobileAppCategoryConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MobileAppCategoryConstantServiceClient client = new MobileAppCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MobileAppCategoryConstant responseCallSettings = await client.GetMobileAppCategoryConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::MobileAppCategoryConstant responseCancellationToken = await client.GetMobileAppCategoryConstantAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetMobileAppCategoryConstant()
        {
            moq::Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient> mockGrpcClient = new moq::Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient>(moq::MockBehavior.Strict);
            GetMobileAppCategoryConstantRequest request = new GetMobileAppCategoryConstantRequest
            {
                ResourceNameAsMobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
            };
            gagvr::MobileAppCategoryConstant expectedResponse = new gagvr::MobileAppCategoryConstant
            {
                ResourceNameAsMobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
                Id = 1958153144,
                MobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetMobileAppCategoryConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MobileAppCategoryConstantServiceClient client = new MobileAppCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MobileAppCategoryConstant response = client.GetMobileAppCategoryConstant(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetMobileAppCategoryConstantAsync()
        {
            moq::Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient> mockGrpcClient = new moq::Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient>(moq::MockBehavior.Strict);
            GetMobileAppCategoryConstantRequest request = new GetMobileAppCategoryConstantRequest
            {
                ResourceNameAsMobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
            };
            gagvr::MobileAppCategoryConstant expectedResponse = new gagvr::MobileAppCategoryConstant
            {
                ResourceNameAsMobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
                Id = 1958153144,
                MobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetMobileAppCategoryConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::MobileAppCategoryConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MobileAppCategoryConstantServiceClient client = new MobileAppCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MobileAppCategoryConstant responseCallSettings = await client.GetMobileAppCategoryConstantAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::MobileAppCategoryConstant responseCancellationToken = await client.GetMobileAppCategoryConstantAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetMobileAppCategoryConstantResourceNames()
        {
            moq::Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient> mockGrpcClient = new moq::Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient>(moq::MockBehavior.Strict);
            GetMobileAppCategoryConstantRequest request = new GetMobileAppCategoryConstantRequest
            {
                ResourceNameAsMobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
            };
            gagvr::MobileAppCategoryConstant expectedResponse = new gagvr::MobileAppCategoryConstant
            {
                ResourceNameAsMobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
                Id = 1958153144,
                MobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetMobileAppCategoryConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MobileAppCategoryConstantServiceClient client = new MobileAppCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MobileAppCategoryConstant response = client.GetMobileAppCategoryConstant(request.ResourceNameAsMobileAppCategoryConstantName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetMobileAppCategoryConstantResourceNamesAsync()
        {
            moq::Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient> mockGrpcClient = new moq::Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient>(moq::MockBehavior.Strict);
            GetMobileAppCategoryConstantRequest request = new GetMobileAppCategoryConstantRequest
            {
                ResourceNameAsMobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
            };
            gagvr::MobileAppCategoryConstant expectedResponse = new gagvr::MobileAppCategoryConstant
            {
                ResourceNameAsMobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
                Id = 1958153144,
                MobileAppCategoryConstantName = gagvr::MobileAppCategoryConstantName.FromMobileAppCategory("[MOBILE_APP_CATEGORY_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetMobileAppCategoryConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::MobileAppCategoryConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MobileAppCategoryConstantServiceClient client = new MobileAppCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MobileAppCategoryConstant responseCallSettings = await client.GetMobileAppCategoryConstantAsync(request.ResourceNameAsMobileAppCategoryConstantName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::MobileAppCategoryConstant responseCancellationToken = await client.GetMobileAppCategoryConstantAsync(request.ResourceNameAsMobileAppCategoryConstantName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

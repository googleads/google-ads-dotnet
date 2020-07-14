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

using gagve = Google.Ads.GoogleAds.V4.Enums;
using gagvr = Google.Ads.GoogleAds.V4.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V4.Services;

namespace Google.Ads.GoogleAds.Tests.V4.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedMobileDeviceConstantServiceClientTest
    {
        [Test]
        public void GetMobileDeviceConstantRequestObject()
        {
            moq::Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient> mockGrpcClient = new moq::Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient>(moq::MockBehavior.Strict);
            GetMobileDeviceConstantRequest request = new GetMobileDeviceConstantRequest
            {
                ResourceNameAsMobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
            };
            gagvr::MobileDeviceConstant expectedResponse = new gagvr::MobileDeviceConstant
            {
                ResourceNameAsMobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
                Id = -6774108720365892680L,
                MobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
                ManufacturerName = "manufacturer_name23641b86",
                OperatingSystemName = "operating_system_namea90f0a1e",
                Type = gagve::MobileDeviceTypeEnum.Types.MobileDeviceType.Tablet,
            };
            mockGrpcClient.Setup(x => x.GetMobileDeviceConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MobileDeviceConstantServiceClient client = new MobileDeviceConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MobileDeviceConstant response = client.GetMobileDeviceConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetMobileDeviceConstantRequestObjectAsync()
        {
            moq::Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient> mockGrpcClient = new moq::Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient>(moq::MockBehavior.Strict);
            GetMobileDeviceConstantRequest request = new GetMobileDeviceConstantRequest
            {
                ResourceNameAsMobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
            };
            gagvr::MobileDeviceConstant expectedResponse = new gagvr::MobileDeviceConstant
            {
                ResourceNameAsMobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
                Id = -6774108720365892680L,
                MobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
                ManufacturerName = "manufacturer_name23641b86",
                OperatingSystemName = "operating_system_namea90f0a1e",
                Type = gagve::MobileDeviceTypeEnum.Types.MobileDeviceType.Tablet,
            };
            mockGrpcClient.Setup(x => x.GetMobileDeviceConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::MobileDeviceConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MobileDeviceConstantServiceClient client = new MobileDeviceConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MobileDeviceConstant responseCallSettings = await client.GetMobileDeviceConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::MobileDeviceConstant responseCancellationToken = await client.GetMobileDeviceConstantAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetMobileDeviceConstant()
        {
            moq::Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient> mockGrpcClient = new moq::Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient>(moq::MockBehavior.Strict);
            GetMobileDeviceConstantRequest request = new GetMobileDeviceConstantRequest
            {
                ResourceNameAsMobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
            };
            gagvr::MobileDeviceConstant expectedResponse = new gagvr::MobileDeviceConstant
            {
                ResourceNameAsMobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
                Id = -6774108720365892680L,
                MobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
                ManufacturerName = "manufacturer_name23641b86",
                OperatingSystemName = "operating_system_namea90f0a1e",
                Type = gagve::MobileDeviceTypeEnum.Types.MobileDeviceType.Tablet,
            };
            mockGrpcClient.Setup(x => x.GetMobileDeviceConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MobileDeviceConstantServiceClient client = new MobileDeviceConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MobileDeviceConstant response = client.GetMobileDeviceConstant(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetMobileDeviceConstantAsync()
        {
            moq::Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient> mockGrpcClient = new moq::Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient>(moq::MockBehavior.Strict);
            GetMobileDeviceConstantRequest request = new GetMobileDeviceConstantRequest
            {
                ResourceNameAsMobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
            };
            gagvr::MobileDeviceConstant expectedResponse = new gagvr::MobileDeviceConstant
            {
                ResourceNameAsMobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
                Id = -6774108720365892680L,
                MobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
                ManufacturerName = "manufacturer_name23641b86",
                OperatingSystemName = "operating_system_namea90f0a1e",
                Type = gagve::MobileDeviceTypeEnum.Types.MobileDeviceType.Tablet,
            };
            mockGrpcClient.Setup(x => x.GetMobileDeviceConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::MobileDeviceConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MobileDeviceConstantServiceClient client = new MobileDeviceConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MobileDeviceConstant responseCallSettings = await client.GetMobileDeviceConstantAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::MobileDeviceConstant responseCancellationToken = await client.GetMobileDeviceConstantAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetMobileDeviceConstantResourceNames()
        {
            moq::Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient> mockGrpcClient = new moq::Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient>(moq::MockBehavior.Strict);
            GetMobileDeviceConstantRequest request = new GetMobileDeviceConstantRequest
            {
                ResourceNameAsMobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
            };
            gagvr::MobileDeviceConstant expectedResponse = new gagvr::MobileDeviceConstant
            {
                ResourceNameAsMobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
                Id = -6774108720365892680L,
                MobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
                ManufacturerName = "manufacturer_name23641b86",
                OperatingSystemName = "operating_system_namea90f0a1e",
                Type = gagve::MobileDeviceTypeEnum.Types.MobileDeviceType.Tablet,
            };
            mockGrpcClient.Setup(x => x.GetMobileDeviceConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MobileDeviceConstantServiceClient client = new MobileDeviceConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MobileDeviceConstant response = client.GetMobileDeviceConstant(request.ResourceNameAsMobileDeviceConstantName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetMobileDeviceConstantResourceNamesAsync()
        {
            moq::Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient> mockGrpcClient = new moq::Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient>(moq::MockBehavior.Strict);
            GetMobileDeviceConstantRequest request = new GetMobileDeviceConstantRequest
            {
                ResourceNameAsMobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
            };
            gagvr::MobileDeviceConstant expectedResponse = new gagvr::MobileDeviceConstant
            {
                ResourceNameAsMobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
                Id = -6774108720365892680L,
                MobileDeviceConstantName = gagvr::MobileDeviceConstantName.FromMobileDeviceConstant("[MOBILE_DEVICE_CONSTANT]"),
                ManufacturerName = "manufacturer_name23641b86",
                OperatingSystemName = "operating_system_namea90f0a1e",
                Type = gagve::MobileDeviceTypeEnum.Types.MobileDeviceType.Tablet,
            };
            mockGrpcClient.Setup(x => x.GetMobileDeviceConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::MobileDeviceConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MobileDeviceConstantServiceClient client = new MobileDeviceConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MobileDeviceConstant responseCallSettings = await client.GetMobileDeviceConstantAsync(request.ResourceNameAsMobileDeviceConstantName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::MobileDeviceConstant responseCancellationToken = await client.GetMobileDeviceConstantAsync(request.ResourceNameAsMobileDeviceConstantName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

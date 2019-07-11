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
    public class GeneratedMobileDeviceConstantServiceClientTest
    {
        [Test]
        public void GetMobileDeviceConstant()
        {
            Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient> mockGrpcClient = new Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient>(MockBehavior.Strict);
            GetMobileDeviceConstantRequest expectedRequest = new GetMobileDeviceConstantRequest
            {
                ResourceName = new MobileDeviceConstantName("[MOBILE_DEVICE_CONSTANT]").ToString(),
            };
            MobileDeviceConstant expectedResponse = new MobileDeviceConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMobileDeviceConstant(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MobileDeviceConstantServiceClient client = new MobileDeviceConstantServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new MobileDeviceConstantName("[MOBILE_DEVICE_CONSTANT]").ToString();
            MobileDeviceConstant response = client.GetMobileDeviceConstant(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetMobileDeviceConstantAsync()
        {
            Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient> mockGrpcClient = new Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient>(MockBehavior.Strict);
            GetMobileDeviceConstantRequest expectedRequest = new GetMobileDeviceConstantRequest
            {
                ResourceName = new MobileDeviceConstantName("[MOBILE_DEVICE_CONSTANT]").ToString(),
            };
            MobileDeviceConstant expectedResponse = new MobileDeviceConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMobileDeviceConstantAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MobileDeviceConstant>(Task.FromResult(expectedResponse), null, null, null, null));
            MobileDeviceConstantServiceClient client = new MobileDeviceConstantServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new MobileDeviceConstantName("[MOBILE_DEVICE_CONSTANT]").ToString();
            MobileDeviceConstant response = await client.GetMobileDeviceConstantAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetMobileDeviceConstant2()
        {
            Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient> mockGrpcClient = new Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient>(MockBehavior.Strict);
            GetMobileDeviceConstantRequest request = new GetMobileDeviceConstantRequest
            {
                ResourceName = new MobileDeviceConstantName("[MOBILE_DEVICE_CONSTANT]").ToString(),
            };
            MobileDeviceConstant expectedResponse = new MobileDeviceConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMobileDeviceConstant(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MobileDeviceConstantServiceClient client = new MobileDeviceConstantServiceClientImpl(mockGrpcClient.Object, null);
            MobileDeviceConstant response = client.GetMobileDeviceConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetMobileDeviceConstantAsync2()
        {
            Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient> mockGrpcClient = new Mock<MobileDeviceConstantService.MobileDeviceConstantServiceClient>(MockBehavior.Strict);
            GetMobileDeviceConstantRequest request = new GetMobileDeviceConstantRequest
            {
                ResourceName = new MobileDeviceConstantName("[MOBILE_DEVICE_CONSTANT]").ToString(),
            };
            MobileDeviceConstant expectedResponse = new MobileDeviceConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMobileDeviceConstantAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MobileDeviceConstant>(Task.FromResult(expectedResponse), null, null, null, null));
            MobileDeviceConstantServiceClient client = new MobileDeviceConstantServiceClientImpl(mockGrpcClient.Object, null);
            MobileDeviceConstant response = await client.GetMobileDeviceConstantAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

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
    public class GeneratedOperatingSystemVersionConstantServiceClientTest
    {
        [Test]
        public void GetOperatingSystemVersionConstant()
        {
            Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient> mockGrpcClient = new Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient>(MockBehavior.Strict);
            GetOperatingSystemVersionConstantRequest expectedRequest = new GetOperatingSystemVersionConstantRequest
            {
                ResourceName = new OperatingSystemVersionConstantName("[OPERATING_SYSTEM_VERSION_CONSTANT]").ToString(),
            };
            OperatingSystemVersionConstant expectedResponse = new OperatingSystemVersionConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetOperatingSystemVersionConstant(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OperatingSystemVersionConstantServiceClient client = new OperatingSystemVersionConstantServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new OperatingSystemVersionConstantName("[OPERATING_SYSTEM_VERSION_CONSTANT]").ToString();
            OperatingSystemVersionConstant response = client.GetOperatingSystemVersionConstant(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetOperatingSystemVersionConstantAsync()
        {
            Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient> mockGrpcClient = new Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient>(MockBehavior.Strict);
            GetOperatingSystemVersionConstantRequest expectedRequest = new GetOperatingSystemVersionConstantRequest
            {
                ResourceName = new OperatingSystemVersionConstantName("[OPERATING_SYSTEM_VERSION_CONSTANT]").ToString(),
            };
            OperatingSystemVersionConstant expectedResponse = new OperatingSystemVersionConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetOperatingSystemVersionConstantAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<OperatingSystemVersionConstant>(Task.FromResult(expectedResponse), null, null, null, null));
            OperatingSystemVersionConstantServiceClient client = new OperatingSystemVersionConstantServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new OperatingSystemVersionConstantName("[OPERATING_SYSTEM_VERSION_CONSTANT]").ToString();
            OperatingSystemVersionConstant response = await client.GetOperatingSystemVersionConstantAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetOperatingSystemVersionConstant2()
        {
            Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient> mockGrpcClient = new Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient>(MockBehavior.Strict);
            GetOperatingSystemVersionConstantRequest request = new GetOperatingSystemVersionConstantRequest
            {
                ResourceName = new OperatingSystemVersionConstantName("[OPERATING_SYSTEM_VERSION_CONSTANT]").ToString(),
            };
            OperatingSystemVersionConstant expectedResponse = new OperatingSystemVersionConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetOperatingSystemVersionConstant(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OperatingSystemVersionConstantServiceClient client = new OperatingSystemVersionConstantServiceClientImpl(mockGrpcClient.Object, null);
            OperatingSystemVersionConstant response = client.GetOperatingSystemVersionConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetOperatingSystemVersionConstantAsync2()
        {
            Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient> mockGrpcClient = new Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient>(MockBehavior.Strict);
            GetOperatingSystemVersionConstantRequest request = new GetOperatingSystemVersionConstantRequest
            {
                ResourceName = new OperatingSystemVersionConstantName("[OPERATING_SYSTEM_VERSION_CONSTANT]").ToString(),
            };
            OperatingSystemVersionConstant expectedResponse = new OperatingSystemVersionConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetOperatingSystemVersionConstantAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<OperatingSystemVersionConstant>(Task.FromResult(expectedResponse), null, null, null, null));
            OperatingSystemVersionConstantServiceClient client = new OperatingSystemVersionConstantServiceClientImpl(mockGrpcClient.Object, null);
            OperatingSystemVersionConstant response = await client.GetOperatingSystemVersionConstantAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

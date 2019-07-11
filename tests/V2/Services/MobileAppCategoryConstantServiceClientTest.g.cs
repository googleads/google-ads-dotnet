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
    public class GeneratedMobileAppCategoryConstantServiceClientTest
    {
        [Test]
        public void GetMobileAppCategoryConstant()
        {
            Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient> mockGrpcClient = new Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient>(MockBehavior.Strict);
            GetMobileAppCategoryConstantRequest expectedRequest = new GetMobileAppCategoryConstantRequest
            {
                ResourceName = new MobileAppCategoryConstantName("[MOBILE_APP_CATEGORY_CONSTANT]").ToString(),
            };
            MobileAppCategoryConstant expectedResponse = new MobileAppCategoryConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMobileAppCategoryConstant(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MobileAppCategoryConstantServiceClient client = new MobileAppCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new MobileAppCategoryConstantName("[MOBILE_APP_CATEGORY_CONSTANT]").ToString();
            MobileAppCategoryConstant response = client.GetMobileAppCategoryConstant(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetMobileAppCategoryConstantAsync()
        {
            Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient> mockGrpcClient = new Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient>(MockBehavior.Strict);
            GetMobileAppCategoryConstantRequest expectedRequest = new GetMobileAppCategoryConstantRequest
            {
                ResourceName = new MobileAppCategoryConstantName("[MOBILE_APP_CATEGORY_CONSTANT]").ToString(),
            };
            MobileAppCategoryConstant expectedResponse = new MobileAppCategoryConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMobileAppCategoryConstantAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MobileAppCategoryConstant>(Task.FromResult(expectedResponse), null, null, null, null));
            MobileAppCategoryConstantServiceClient client = new MobileAppCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new MobileAppCategoryConstantName("[MOBILE_APP_CATEGORY_CONSTANT]").ToString();
            MobileAppCategoryConstant response = await client.GetMobileAppCategoryConstantAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetMobileAppCategoryConstant2()
        {
            Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient> mockGrpcClient = new Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient>(MockBehavior.Strict);
            GetMobileAppCategoryConstantRequest request = new GetMobileAppCategoryConstantRequest
            {
                ResourceName = new MobileAppCategoryConstantName("[MOBILE_APP_CATEGORY_CONSTANT]").ToString(),
            };
            MobileAppCategoryConstant expectedResponse = new MobileAppCategoryConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMobileAppCategoryConstant(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MobileAppCategoryConstantServiceClient client = new MobileAppCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            MobileAppCategoryConstant response = client.GetMobileAppCategoryConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetMobileAppCategoryConstantAsync2()
        {
            Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient> mockGrpcClient = new Mock<MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient>(MockBehavior.Strict);
            GetMobileAppCategoryConstantRequest request = new GetMobileAppCategoryConstantRequest
            {
                ResourceName = new MobileAppCategoryConstantName("[MOBILE_APP_CATEGORY_CONSTANT]").ToString(),
            };
            MobileAppCategoryConstant expectedResponse = new MobileAppCategoryConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMobileAppCategoryConstantAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MobileAppCategoryConstant>(Task.FromResult(expectedResponse), null, null, null, null));
            MobileAppCategoryConstantServiceClient client = new MobileAppCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            MobileAppCategoryConstant response = await client.GetMobileAppCategoryConstantAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

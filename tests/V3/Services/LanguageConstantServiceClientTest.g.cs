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

namespace Google.Ads.GoogleAds.V3.Services.Tests
{
    using Google.Ads.GoogleAds.V3.Resources;
    using apis = Google.Ads.GoogleAds.V3.Services;
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
    public class GeneratedLanguageConstantServiceClientTest
    {
        [Test]
        public void GetLanguageConstant()
        {
            Mock<LanguageConstantService.LanguageConstantServiceClient> mockGrpcClient = new Mock<LanguageConstantService.LanguageConstantServiceClient>(MockBehavior.Strict);
            GetLanguageConstantRequest expectedRequest = new GetLanguageConstantRequest
            {
                ResourceName = new LanguageConstantName("[LANGUAGE_CONSTANT]").ToString(),
            };
            LanguageConstant expectedResponse = new LanguageConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetLanguageConstant(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageConstantServiceClient client = new LanguageConstantServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new LanguageConstantName("[LANGUAGE_CONSTANT]").ToString();
            LanguageConstant response = client.GetLanguageConstant(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetLanguageConstantAsync()
        {
            Mock<LanguageConstantService.LanguageConstantServiceClient> mockGrpcClient = new Mock<LanguageConstantService.LanguageConstantServiceClient>(MockBehavior.Strict);
            GetLanguageConstantRequest expectedRequest = new GetLanguageConstantRequest
            {
                ResourceName = new LanguageConstantName("[LANGUAGE_CONSTANT]").ToString(),
            };
            LanguageConstant expectedResponse = new LanguageConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetLanguageConstantAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LanguageConstant>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageConstantServiceClient client = new LanguageConstantServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new LanguageConstantName("[LANGUAGE_CONSTANT]").ToString();
            LanguageConstant response = await client.GetLanguageConstantAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetLanguageConstant2()
        {
            Mock<LanguageConstantService.LanguageConstantServiceClient> mockGrpcClient = new Mock<LanguageConstantService.LanguageConstantServiceClient>(MockBehavior.Strict);
            GetLanguageConstantRequest request = new GetLanguageConstantRequest
            {
                ResourceName = new LanguageConstantName("[LANGUAGE_CONSTANT]").ToString(),
            };
            LanguageConstant expectedResponse = new LanguageConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetLanguageConstant(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LanguageConstantServiceClient client = new LanguageConstantServiceClientImpl(mockGrpcClient.Object, null);
            LanguageConstant response = client.GetLanguageConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetLanguageConstantAsync2()
        {
            Mock<LanguageConstantService.LanguageConstantServiceClient> mockGrpcClient = new Mock<LanguageConstantService.LanguageConstantServiceClient>(MockBehavior.Strict);
            GetLanguageConstantRequest request = new GetLanguageConstantRequest
            {
                ResourceName = new LanguageConstantName("[LANGUAGE_CONSTANT]").ToString(),
            };
            LanguageConstant expectedResponse = new LanguageConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetLanguageConstantAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LanguageConstant>(Task.FromResult(expectedResponse), null, null, null, null));
            LanguageConstantServiceClient client = new LanguageConstantServiceClientImpl(mockGrpcClient.Object, null);
            LanguageConstant response = await client.GetLanguageConstantAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

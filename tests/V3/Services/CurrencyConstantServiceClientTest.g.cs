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
    public class GeneratedCurrencyConstantServiceClientTest
    {
        [Test]
        public void GetCurrencyConstant()
        {
            Mock<CurrencyConstantService.CurrencyConstantServiceClient> mockGrpcClient = new Mock<CurrencyConstantService.CurrencyConstantServiceClient>(MockBehavior.Strict);
            GetCurrencyConstantRequest expectedRequest = new GetCurrencyConstantRequest
            {
                ResourceName = new CurrencyConstantName("[CURRENCY_CONSTANT]").ToString(),
            };
            CurrencyConstant expectedResponse = new CurrencyConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCurrencyConstant(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CurrencyConstantServiceClient client = new CurrencyConstantServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CurrencyConstantName("[CURRENCY_CONSTANT]").ToString();
            CurrencyConstant response = client.GetCurrencyConstant(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCurrencyConstantAsync()
        {
            Mock<CurrencyConstantService.CurrencyConstantServiceClient> mockGrpcClient = new Mock<CurrencyConstantService.CurrencyConstantServiceClient>(MockBehavior.Strict);
            GetCurrencyConstantRequest expectedRequest = new GetCurrencyConstantRequest
            {
                ResourceName = new CurrencyConstantName("[CURRENCY_CONSTANT]").ToString(),
            };
            CurrencyConstant expectedResponse = new CurrencyConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCurrencyConstantAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CurrencyConstant>(Task.FromResult(expectedResponse), null, null, null, null));
            CurrencyConstantServiceClient client = new CurrencyConstantServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CurrencyConstantName("[CURRENCY_CONSTANT]").ToString();
            CurrencyConstant response = await client.GetCurrencyConstantAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCurrencyConstant2()
        {
            Mock<CurrencyConstantService.CurrencyConstantServiceClient> mockGrpcClient = new Mock<CurrencyConstantService.CurrencyConstantServiceClient>(MockBehavior.Strict);
            GetCurrencyConstantRequest request = new GetCurrencyConstantRequest
            {
                ResourceName = new CurrencyConstantName("[CURRENCY_CONSTANT]").ToString(),
            };
            CurrencyConstant expectedResponse = new CurrencyConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCurrencyConstant(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CurrencyConstantServiceClient client = new CurrencyConstantServiceClientImpl(mockGrpcClient.Object, null);
            CurrencyConstant response = client.GetCurrencyConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCurrencyConstantAsync2()
        {
            Mock<CurrencyConstantService.CurrencyConstantServiceClient> mockGrpcClient = new Mock<CurrencyConstantService.CurrencyConstantServiceClient>(MockBehavior.Strict);
            GetCurrencyConstantRequest request = new GetCurrencyConstantRequest
            {
                ResourceName = new CurrencyConstantName("[CURRENCY_CONSTANT]").ToString(),
            };
            CurrencyConstant expectedResponse = new CurrencyConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCurrencyConstantAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CurrencyConstant>(Task.FromResult(expectedResponse), null, null, null, null));
            CurrencyConstantServiceClient client = new CurrencyConstantServiceClientImpl(mockGrpcClient.Object, null);
            CurrencyConstant response = await client.GetCurrencyConstantAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

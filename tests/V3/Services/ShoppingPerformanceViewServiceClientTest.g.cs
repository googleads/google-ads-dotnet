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
    public class GeneratedShoppingPerformanceViewServiceClientTest
    {
        [Test]
        public void GetShoppingPerformanceView()
        {
            Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient> mockGrpcClient = new Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient>(MockBehavior.Strict);
            GetShoppingPerformanceViewRequest expectedRequest = new GetShoppingPerformanceViewRequest
            {
                ResourceName = new ShoppingPerformanceViewName("[CUSTOMER]").ToString(),
            };
            ShoppingPerformanceView expectedResponse = new ShoppingPerformanceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetShoppingPerformanceView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ShoppingPerformanceViewServiceClient client = new ShoppingPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ShoppingPerformanceViewName("[CUSTOMER]").ToString();
            ShoppingPerformanceView response = client.GetShoppingPerformanceView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetShoppingPerformanceViewAsync()
        {
            Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient> mockGrpcClient = new Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient>(MockBehavior.Strict);
            GetShoppingPerformanceViewRequest expectedRequest = new GetShoppingPerformanceViewRequest
            {
                ResourceName = new ShoppingPerformanceViewName("[CUSTOMER]").ToString(),
            };
            ShoppingPerformanceView expectedResponse = new ShoppingPerformanceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetShoppingPerformanceViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ShoppingPerformanceView>(Task.FromResult(expectedResponse), null, null, null, null));
            ShoppingPerformanceViewServiceClient client = new ShoppingPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ShoppingPerformanceViewName("[CUSTOMER]").ToString();
            ShoppingPerformanceView response = await client.GetShoppingPerformanceViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetShoppingPerformanceView2()
        {
            Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient> mockGrpcClient = new Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient>(MockBehavior.Strict);
            GetShoppingPerformanceViewRequest request = new GetShoppingPerformanceViewRequest
            {
                ResourceName = new ShoppingPerformanceViewName("[CUSTOMER]").ToString(),
            };
            ShoppingPerformanceView expectedResponse = new ShoppingPerformanceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetShoppingPerformanceView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ShoppingPerformanceViewServiceClient client = new ShoppingPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            ShoppingPerformanceView response = client.GetShoppingPerformanceView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetShoppingPerformanceViewAsync2()
        {
            Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient> mockGrpcClient = new Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient>(MockBehavior.Strict);
            GetShoppingPerformanceViewRequest request = new GetShoppingPerformanceViewRequest
            {
                ResourceName = new ShoppingPerformanceViewName("[CUSTOMER]").ToString(),
            };
            ShoppingPerformanceView expectedResponse = new ShoppingPerformanceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetShoppingPerformanceViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ShoppingPerformanceView>(Task.FromResult(expectedResponse), null, null, null, null));
            ShoppingPerformanceViewServiceClient client = new ShoppingPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            ShoppingPerformanceView response = await client.GetShoppingPerformanceViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

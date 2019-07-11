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
    public class GeneratedClickViewServiceClientTest
    {
        [Test]
        public void GetClickView()
        {
            Mock<ClickViewService.ClickViewServiceClient> mockGrpcClient = new Mock<ClickViewService.ClickViewServiceClient>(MockBehavior.Strict);
            GetClickViewRequest expectedRequest = new GetClickViewRequest
            {
                ResourceName = new ClickViewName("[CUSTOMER]", "[CLICK_VIEW]").ToString(),
            };
            ClickView expectedResponse = new ClickView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetClickView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClickViewServiceClient client = new ClickViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ClickViewName("[CUSTOMER]", "[CLICK_VIEW]").ToString();
            ClickView response = client.GetClickView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetClickViewAsync()
        {
            Mock<ClickViewService.ClickViewServiceClient> mockGrpcClient = new Mock<ClickViewService.ClickViewServiceClient>(MockBehavior.Strict);
            GetClickViewRequest expectedRequest = new GetClickViewRequest
            {
                ResourceName = new ClickViewName("[CUSTOMER]", "[CLICK_VIEW]").ToString(),
            };
            ClickView expectedResponse = new ClickView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetClickViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ClickView>(Task.FromResult(expectedResponse), null, null, null, null));
            ClickViewServiceClient client = new ClickViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ClickViewName("[CUSTOMER]", "[CLICK_VIEW]").ToString();
            ClickView response = await client.GetClickViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetClickView2()
        {
            Mock<ClickViewService.ClickViewServiceClient> mockGrpcClient = new Mock<ClickViewService.ClickViewServiceClient>(MockBehavior.Strict);
            GetClickViewRequest request = new GetClickViewRequest
            {
                ResourceName = new ClickViewName("[CUSTOMER]", "[CLICK_VIEW]").ToString(),
            };
            ClickView expectedResponse = new ClickView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetClickView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ClickViewServiceClient client = new ClickViewServiceClientImpl(mockGrpcClient.Object, null);
            ClickView response = client.GetClickView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetClickViewAsync2()
        {
            Mock<ClickViewService.ClickViewServiceClient> mockGrpcClient = new Mock<ClickViewService.ClickViewServiceClient>(MockBehavior.Strict);
            GetClickViewRequest request = new GetClickViewRequest
            {
                ResourceName = new ClickViewName("[CUSTOMER]", "[CLICK_VIEW]").ToString(),
            };
            ClickView expectedResponse = new ClickView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetClickViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ClickView>(Task.FromResult(expectedResponse), null, null, null, null));
            ClickViewServiceClient client = new ClickViewServiceClientImpl(mockGrpcClient.Object, null);
            ClickView response = await client.GetClickViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

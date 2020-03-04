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
    public class GeneratedDisplayKeywordViewServiceClientTest
    {
        [Test]
        public void GetDisplayKeywordView()
        {
            Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient> mockGrpcClient = new Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient>(MockBehavior.Strict);
            GetDisplayKeywordViewRequest expectedRequest = new GetDisplayKeywordViewRequest
            {
                ResourceName = new DisplayKeywordViewName("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]").ToString(),
            };
            DisplayKeywordView expectedResponse = new DisplayKeywordView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDisplayKeywordView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DisplayKeywordViewServiceClient client = new DisplayKeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new DisplayKeywordViewName("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]").ToString();
            DisplayKeywordView response = client.GetDisplayKeywordView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetDisplayKeywordViewAsync()
        {
            Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient> mockGrpcClient = new Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient>(MockBehavior.Strict);
            GetDisplayKeywordViewRequest expectedRequest = new GetDisplayKeywordViewRequest
            {
                ResourceName = new DisplayKeywordViewName("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]").ToString(),
            };
            DisplayKeywordView expectedResponse = new DisplayKeywordView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDisplayKeywordViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DisplayKeywordView>(Task.FromResult(expectedResponse), null, null, null, null));
            DisplayKeywordViewServiceClient client = new DisplayKeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new DisplayKeywordViewName("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]").ToString();
            DisplayKeywordView response = await client.GetDisplayKeywordViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetDisplayKeywordView2()
        {
            Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient> mockGrpcClient = new Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient>(MockBehavior.Strict);
            GetDisplayKeywordViewRequest request = new GetDisplayKeywordViewRequest
            {
                ResourceName = new DisplayKeywordViewName("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]").ToString(),
            };
            DisplayKeywordView expectedResponse = new DisplayKeywordView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDisplayKeywordView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DisplayKeywordViewServiceClient client = new DisplayKeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            DisplayKeywordView response = client.GetDisplayKeywordView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetDisplayKeywordViewAsync2()
        {
            Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient> mockGrpcClient = new Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient>(MockBehavior.Strict);
            GetDisplayKeywordViewRequest request = new GetDisplayKeywordViewRequest
            {
                ResourceName = new DisplayKeywordViewName("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]").ToString(),
            };
            DisplayKeywordView expectedResponse = new DisplayKeywordView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDisplayKeywordViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DisplayKeywordView>(Task.FromResult(expectedResponse), null, null, null, null));
            DisplayKeywordViewServiceClient client = new DisplayKeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            DisplayKeywordView response = await client.GetDisplayKeywordViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

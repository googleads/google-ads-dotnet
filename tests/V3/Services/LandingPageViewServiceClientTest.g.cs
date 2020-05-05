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
    public class GeneratedLandingPageViewServiceClientTest
    {
        [Test]
        public void GetLandingPageView()
        {
            Mock<LandingPageViewService.LandingPageViewServiceClient> mockGrpcClient = new Mock<LandingPageViewService.LandingPageViewServiceClient>(MockBehavior.Strict);
            GetLandingPageViewRequest expectedRequest = new GetLandingPageViewRequest
            {
                ResourceName = new LandingPageViewName("[CUSTOMER]", "[LANDING_PAGE_VIEW]").ToString(),
            };
            LandingPageView expectedResponse = new LandingPageView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetLandingPageView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LandingPageViewServiceClient client = new LandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new LandingPageViewName("[CUSTOMER]", "[LANDING_PAGE_VIEW]").ToString();
            LandingPageView response = client.GetLandingPageView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetLandingPageViewAsync()
        {
            Mock<LandingPageViewService.LandingPageViewServiceClient> mockGrpcClient = new Mock<LandingPageViewService.LandingPageViewServiceClient>(MockBehavior.Strict);
            GetLandingPageViewRequest expectedRequest = new GetLandingPageViewRequest
            {
                ResourceName = new LandingPageViewName("[CUSTOMER]", "[LANDING_PAGE_VIEW]").ToString(),
            };
            LandingPageView expectedResponse = new LandingPageView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetLandingPageViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LandingPageView>(Task.FromResult(expectedResponse), null, null, null, null));
            LandingPageViewServiceClient client = new LandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new LandingPageViewName("[CUSTOMER]", "[LANDING_PAGE_VIEW]").ToString();
            LandingPageView response = await client.GetLandingPageViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetLandingPageView2()
        {
            Mock<LandingPageViewService.LandingPageViewServiceClient> mockGrpcClient = new Mock<LandingPageViewService.LandingPageViewServiceClient>(MockBehavior.Strict);
            GetLandingPageViewRequest request = new GetLandingPageViewRequest
            {
                ResourceName = new LandingPageViewName("[CUSTOMER]", "[LANDING_PAGE_VIEW]").ToString(),
            };
            LandingPageView expectedResponse = new LandingPageView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetLandingPageView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LandingPageViewServiceClient client = new LandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            LandingPageView response = client.GetLandingPageView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetLandingPageViewAsync2()
        {
            Mock<LandingPageViewService.LandingPageViewServiceClient> mockGrpcClient = new Mock<LandingPageViewService.LandingPageViewServiceClient>(MockBehavior.Strict);
            GetLandingPageViewRequest request = new GetLandingPageViewRequest
            {
                ResourceName = new LandingPageViewName("[CUSTOMER]", "[LANDING_PAGE_VIEW]").ToString(),
            };
            LandingPageView expectedResponse = new LandingPageView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetLandingPageViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LandingPageView>(Task.FromResult(expectedResponse), null, null, null, null));
            LandingPageViewServiceClient client = new LandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            LandingPageView response = await client.GetLandingPageViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

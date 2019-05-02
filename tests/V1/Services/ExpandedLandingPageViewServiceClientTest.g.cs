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

namespace Google.Ads.GoogleAds.V1.Services.Tests
{
    using Google.Ads.GoogleAds.V1.Resources;
    using apis = Google.Ads.GoogleAds.V1.Services;
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
    public class GeneratedExpandedLandingPageViewServiceClientTest
    {
        [Test]
        public void GetExpandedLandingPageView()
        {
            Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient> mockGrpcClient = new Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient>(MockBehavior.Strict);
            GetExpandedLandingPageViewRequest expectedRequest = new GetExpandedLandingPageViewRequest
            {
                ResourceName = new ExpandedLandingPageViewName("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]").ToString(),
            };
            ExpandedLandingPageView expectedResponse = new ExpandedLandingPageView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetExpandedLandingPageView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ExpandedLandingPageViewServiceClient client = new ExpandedLandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ExpandedLandingPageViewName("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]").ToString();
            ExpandedLandingPageView response = client.GetExpandedLandingPageView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetExpandedLandingPageViewAsync()
        {
            Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient> mockGrpcClient = new Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient>(MockBehavior.Strict);
            GetExpandedLandingPageViewRequest expectedRequest = new GetExpandedLandingPageViewRequest
            {
                ResourceName = new ExpandedLandingPageViewName("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]").ToString(),
            };
            ExpandedLandingPageView expectedResponse = new ExpandedLandingPageView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetExpandedLandingPageViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ExpandedLandingPageView>(Task.FromResult(expectedResponse), null, null, null, null));
            ExpandedLandingPageViewServiceClient client = new ExpandedLandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ExpandedLandingPageViewName("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]").ToString();
            ExpandedLandingPageView response = await client.GetExpandedLandingPageViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetExpandedLandingPageView2()
        {
            Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient> mockGrpcClient = new Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient>(MockBehavior.Strict);
            GetExpandedLandingPageViewRequest request = new GetExpandedLandingPageViewRequest
            {
                ResourceName = new ExpandedLandingPageViewName("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]").ToString(),
            };
            ExpandedLandingPageView expectedResponse = new ExpandedLandingPageView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetExpandedLandingPageView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ExpandedLandingPageViewServiceClient client = new ExpandedLandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            ExpandedLandingPageView response = client.GetExpandedLandingPageView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetExpandedLandingPageViewAsync2()
        {
            Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient> mockGrpcClient = new Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient>(MockBehavior.Strict);
            GetExpandedLandingPageViewRequest request = new GetExpandedLandingPageViewRequest
            {
                ResourceName = new ExpandedLandingPageViewName("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]").ToString(),
            };
            ExpandedLandingPageView expectedResponse = new ExpandedLandingPageView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetExpandedLandingPageViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ExpandedLandingPageView>(Task.FromResult(expectedResponse), null, null, null, null));
            ExpandedLandingPageViewServiceClient client = new ExpandedLandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            ExpandedLandingPageView response = await client.GetExpandedLandingPageViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

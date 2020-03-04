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
    public class GeneratedAdScheduleViewServiceClientTest
    {
        [Test]
        public void GetAdScheduleView()
        {
            Mock<AdScheduleViewService.AdScheduleViewServiceClient> mockGrpcClient = new Mock<AdScheduleViewService.AdScheduleViewServiceClient>(MockBehavior.Strict);
            GetAdScheduleViewRequest expectedRequest = new GetAdScheduleViewRequest
            {
                ResourceName = new AdScheduleViewName("[CUSTOMER]", "[AD_SCHEDULE_VIEW]").ToString(),
            };
            AdScheduleView expectedResponse = new AdScheduleView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdScheduleView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdScheduleViewServiceClient client = new AdScheduleViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdScheduleViewName("[CUSTOMER]", "[AD_SCHEDULE_VIEW]").ToString();
            AdScheduleView response = client.GetAdScheduleView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdScheduleViewAsync()
        {
            Mock<AdScheduleViewService.AdScheduleViewServiceClient> mockGrpcClient = new Mock<AdScheduleViewService.AdScheduleViewServiceClient>(MockBehavior.Strict);
            GetAdScheduleViewRequest expectedRequest = new GetAdScheduleViewRequest
            {
                ResourceName = new AdScheduleViewName("[CUSTOMER]", "[AD_SCHEDULE_VIEW]").ToString(),
            };
            AdScheduleView expectedResponse = new AdScheduleView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdScheduleViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdScheduleView>(Task.FromResult(expectedResponse), null, null, null, null));
            AdScheduleViewServiceClient client = new AdScheduleViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdScheduleViewName("[CUSTOMER]", "[AD_SCHEDULE_VIEW]").ToString();
            AdScheduleView response = await client.GetAdScheduleViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdScheduleView2()
        {
            Mock<AdScheduleViewService.AdScheduleViewServiceClient> mockGrpcClient = new Mock<AdScheduleViewService.AdScheduleViewServiceClient>(MockBehavior.Strict);
            GetAdScheduleViewRequest request = new GetAdScheduleViewRequest
            {
                ResourceName = new AdScheduleViewName("[CUSTOMER]", "[AD_SCHEDULE_VIEW]").ToString(),
            };
            AdScheduleView expectedResponse = new AdScheduleView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdScheduleView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdScheduleViewServiceClient client = new AdScheduleViewServiceClientImpl(mockGrpcClient.Object, null);
            AdScheduleView response = client.GetAdScheduleView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdScheduleViewAsync2()
        {
            Mock<AdScheduleViewService.AdScheduleViewServiceClient> mockGrpcClient = new Mock<AdScheduleViewService.AdScheduleViewServiceClient>(MockBehavior.Strict);
            GetAdScheduleViewRequest request = new GetAdScheduleViewRequest
            {
                ResourceName = new AdScheduleViewName("[CUSTOMER]", "[AD_SCHEDULE_VIEW]").ToString(),
            };
            AdScheduleView expectedResponse = new AdScheduleView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdScheduleViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdScheduleView>(Task.FromResult(expectedResponse), null, null, null, null));
            AdScheduleViewServiceClient client = new AdScheduleViewServiceClientImpl(mockGrpcClient.Object, null);
            AdScheduleView response = await client.GetAdScheduleViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

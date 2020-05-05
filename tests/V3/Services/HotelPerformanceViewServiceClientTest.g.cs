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
    public class GeneratedHotelPerformanceViewServiceClientTest
    {
        [Test]
        public void GetHotelPerformanceView()
        {
            Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient> mockGrpcClient = new Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient>(MockBehavior.Strict);
            GetHotelPerformanceViewRequest expectedRequest = new GetHotelPerformanceViewRequest
            {
                ResourceName = new HotelPerformanceViewName("[CUSTOMER]").ToString(),
            };
            HotelPerformanceView expectedResponse = new HotelPerformanceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetHotelPerformanceView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            HotelPerformanceViewServiceClient client = new HotelPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new HotelPerformanceViewName("[CUSTOMER]").ToString();
            HotelPerformanceView response = client.GetHotelPerformanceView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetHotelPerformanceViewAsync()
        {
            Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient> mockGrpcClient = new Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient>(MockBehavior.Strict);
            GetHotelPerformanceViewRequest expectedRequest = new GetHotelPerformanceViewRequest
            {
                ResourceName = new HotelPerformanceViewName("[CUSTOMER]").ToString(),
            };
            HotelPerformanceView expectedResponse = new HotelPerformanceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetHotelPerformanceViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<HotelPerformanceView>(Task.FromResult(expectedResponse), null, null, null, null));
            HotelPerformanceViewServiceClient client = new HotelPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new HotelPerformanceViewName("[CUSTOMER]").ToString();
            HotelPerformanceView response = await client.GetHotelPerformanceViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetHotelPerformanceView2()
        {
            Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient> mockGrpcClient = new Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient>(MockBehavior.Strict);
            GetHotelPerformanceViewRequest request = new GetHotelPerformanceViewRequest
            {
                ResourceName = new HotelPerformanceViewName("[CUSTOMER]").ToString(),
            };
            HotelPerformanceView expectedResponse = new HotelPerformanceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetHotelPerformanceView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            HotelPerformanceViewServiceClient client = new HotelPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            HotelPerformanceView response = client.GetHotelPerformanceView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetHotelPerformanceViewAsync2()
        {
            Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient> mockGrpcClient = new Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient>(MockBehavior.Strict);
            GetHotelPerformanceViewRequest request = new GetHotelPerformanceViewRequest
            {
                ResourceName = new HotelPerformanceViewName("[CUSTOMER]").ToString(),
            };
            HotelPerformanceView expectedResponse = new HotelPerformanceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetHotelPerformanceViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<HotelPerformanceView>(Task.FromResult(expectedResponse), null, null, null, null));
            HotelPerformanceViewServiceClient client = new HotelPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            HotelPerformanceView response = await client.GetHotelPerformanceViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

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
    public class GeneratedHotelGroupViewServiceClientTest
    {
        [Test]
        public void GetHotelGroupView()
        {
            Mock<HotelGroupViewService.HotelGroupViewServiceClient> mockGrpcClient = new Mock<HotelGroupViewService.HotelGroupViewServiceClient>(MockBehavior.Strict);
            GetHotelGroupViewRequest expectedRequest = new GetHotelGroupViewRequest
            {
                ResourceName = new HotelGroupViewName("[CUSTOMER]", "[HOTEL_GROUP_VIEW]").ToString(),
            };
            HotelGroupView expectedResponse = new HotelGroupView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetHotelGroupView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            HotelGroupViewServiceClient client = new HotelGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new HotelGroupViewName("[CUSTOMER]", "[HOTEL_GROUP_VIEW]").ToString();
            HotelGroupView response = client.GetHotelGroupView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetHotelGroupViewAsync()
        {
            Mock<HotelGroupViewService.HotelGroupViewServiceClient> mockGrpcClient = new Mock<HotelGroupViewService.HotelGroupViewServiceClient>(MockBehavior.Strict);
            GetHotelGroupViewRequest expectedRequest = new GetHotelGroupViewRequest
            {
                ResourceName = new HotelGroupViewName("[CUSTOMER]", "[HOTEL_GROUP_VIEW]").ToString(),
            };
            HotelGroupView expectedResponse = new HotelGroupView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetHotelGroupViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<HotelGroupView>(Task.FromResult(expectedResponse), null, null, null, null));
            HotelGroupViewServiceClient client = new HotelGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new HotelGroupViewName("[CUSTOMER]", "[HOTEL_GROUP_VIEW]").ToString();
            HotelGroupView response = await client.GetHotelGroupViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetHotelGroupView2()
        {
            Mock<HotelGroupViewService.HotelGroupViewServiceClient> mockGrpcClient = new Mock<HotelGroupViewService.HotelGroupViewServiceClient>(MockBehavior.Strict);
            GetHotelGroupViewRequest request = new GetHotelGroupViewRequest
            {
                ResourceName = new HotelGroupViewName("[CUSTOMER]", "[HOTEL_GROUP_VIEW]").ToString(),
            };
            HotelGroupView expectedResponse = new HotelGroupView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetHotelGroupView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            HotelGroupViewServiceClient client = new HotelGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            HotelGroupView response = client.GetHotelGroupView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetHotelGroupViewAsync2()
        {
            Mock<HotelGroupViewService.HotelGroupViewServiceClient> mockGrpcClient = new Mock<HotelGroupViewService.HotelGroupViewServiceClient>(MockBehavior.Strict);
            GetHotelGroupViewRequest request = new GetHotelGroupViewRequest
            {
                ResourceName = new HotelGroupViewName("[CUSTOMER]", "[HOTEL_GROUP_VIEW]").ToString(),
            };
            HotelGroupView expectedResponse = new HotelGroupView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetHotelGroupViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<HotelGroupView>(Task.FromResult(expectedResponse), null, null, null, null));
            HotelGroupViewServiceClient client = new HotelGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            HotelGroupView response = await client.GetHotelGroupViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

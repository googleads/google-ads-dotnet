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
    public class GeneratedLocationViewServiceClientTest
    {
        [Test]
        public void GetLocationView()
        {
            Mock<LocationViewService.LocationViewServiceClient> mockGrpcClient = new Mock<LocationViewService.LocationViewServiceClient>(MockBehavior.Strict);
            GetLocationViewRequest expectedRequest = new GetLocationViewRequest
            {
                ResourceName = new LocationViewName("[CUSTOMER]", "[LOCATION_VIEW]").ToString(),
            };
            LocationView expectedResponse = new LocationView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetLocationView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LocationViewServiceClient client = new LocationViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new LocationViewName("[CUSTOMER]", "[LOCATION_VIEW]").ToString();
            LocationView response = client.GetLocationView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetLocationViewAsync()
        {
            Mock<LocationViewService.LocationViewServiceClient> mockGrpcClient = new Mock<LocationViewService.LocationViewServiceClient>(MockBehavior.Strict);
            GetLocationViewRequest expectedRequest = new GetLocationViewRequest
            {
                ResourceName = new LocationViewName("[CUSTOMER]", "[LOCATION_VIEW]").ToString(),
            };
            LocationView expectedResponse = new LocationView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetLocationViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LocationView>(Task.FromResult(expectedResponse), null, null, null, null));
            LocationViewServiceClient client = new LocationViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new LocationViewName("[CUSTOMER]", "[LOCATION_VIEW]").ToString();
            LocationView response = await client.GetLocationViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetLocationView2()
        {
            Mock<LocationViewService.LocationViewServiceClient> mockGrpcClient = new Mock<LocationViewService.LocationViewServiceClient>(MockBehavior.Strict);
            GetLocationViewRequest request = new GetLocationViewRequest
            {
                ResourceName = new LocationViewName("[CUSTOMER]", "[LOCATION_VIEW]").ToString(),
            };
            LocationView expectedResponse = new LocationView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetLocationView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LocationViewServiceClient client = new LocationViewServiceClientImpl(mockGrpcClient.Object, null);
            LocationView response = client.GetLocationView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetLocationViewAsync2()
        {
            Mock<LocationViewService.LocationViewServiceClient> mockGrpcClient = new Mock<LocationViewService.LocationViewServiceClient>(MockBehavior.Strict);
            GetLocationViewRequest request = new GetLocationViewRequest
            {
                ResourceName = new LocationViewName("[CUSTOMER]", "[LOCATION_VIEW]").ToString(),
            };
            LocationView expectedResponse = new LocationView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetLocationViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LocationView>(Task.FromResult(expectedResponse), null, null, null, null));
            LocationViewServiceClient client = new LocationViewServiceClientImpl(mockGrpcClient.Object, null);
            LocationView response = await client.GetLocationViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

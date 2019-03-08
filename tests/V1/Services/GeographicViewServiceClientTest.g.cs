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
    public class GeneratedGeographicViewServiceClientTest
    {
        [Test]
        public void GetGeographicView()
        {
            Mock<GeographicViewService.GeographicViewServiceClient> mockGrpcClient = new Mock<GeographicViewService.GeographicViewServiceClient>(MockBehavior.Strict);
            GetGeographicViewRequest expectedRequest = new GetGeographicViewRequest
            {
                ResourceName = new GeographicViewName("[CUSTOMER]", "[GEOGRAPHIC_VIEW]").ToString(),
            };
            GeographicView expectedResponse = new GeographicView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetGeographicView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GeographicViewServiceClient client = new GeographicViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new GeographicViewName("[CUSTOMER]", "[GEOGRAPHIC_VIEW]").ToString();
            GeographicView response = client.GetGeographicView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetGeographicViewAsync()
        {
            Mock<GeographicViewService.GeographicViewServiceClient> mockGrpcClient = new Mock<GeographicViewService.GeographicViewServiceClient>(MockBehavior.Strict);
            GetGeographicViewRequest expectedRequest = new GetGeographicViewRequest
            {
                ResourceName = new GeographicViewName("[CUSTOMER]", "[GEOGRAPHIC_VIEW]").ToString(),
            };
            GeographicView expectedResponse = new GeographicView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetGeographicViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GeographicView>(Task.FromResult(expectedResponse), null, null, null, null));
            GeographicViewServiceClient client = new GeographicViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new GeographicViewName("[CUSTOMER]", "[GEOGRAPHIC_VIEW]").ToString();
            GeographicView response = await client.GetGeographicViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetGeographicView2()
        {
            Mock<GeographicViewService.GeographicViewServiceClient> mockGrpcClient = new Mock<GeographicViewService.GeographicViewServiceClient>(MockBehavior.Strict);
            GetGeographicViewRequest request = new GetGeographicViewRequest
            {
                ResourceName = new GeographicViewName("[CUSTOMER]", "[GEOGRAPHIC_VIEW]").ToString(),
            };
            GeographicView expectedResponse = new GeographicView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetGeographicView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GeographicViewServiceClient client = new GeographicViewServiceClientImpl(mockGrpcClient.Object, null);
            GeographicView response = client.GetGeographicView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetGeographicViewAsync2()
        {
            Mock<GeographicViewService.GeographicViewServiceClient> mockGrpcClient = new Mock<GeographicViewService.GeographicViewServiceClient>(MockBehavior.Strict);
            GetGeographicViewRequest request = new GetGeographicViewRequest
            {
                ResourceName = new GeographicViewName("[CUSTOMER]", "[GEOGRAPHIC_VIEW]").ToString(),
            };
            GeographicView expectedResponse = new GeographicView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetGeographicViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GeographicView>(Task.FromResult(expectedResponse), null, null, null, null));
            GeographicViewServiceClient client = new GeographicViewServiceClientImpl(mockGrpcClient.Object, null);
            GeographicView response = await client.GetGeographicViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

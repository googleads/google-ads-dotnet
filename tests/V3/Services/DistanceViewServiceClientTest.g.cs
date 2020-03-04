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
    public class GeneratedDistanceViewServiceClientTest
    {
        [Test]
        public void GetDistanceView()
        {
            Mock<DistanceViewService.DistanceViewServiceClient> mockGrpcClient = new Mock<DistanceViewService.DistanceViewServiceClient>(MockBehavior.Strict);
            GetDistanceViewRequest expectedRequest = new GetDistanceViewRequest
            {
                ResourceName = new DistanceViewName("[CUSTOMER]", "[DISTANCE_VIEW]").ToString(),
            };
            DistanceView expectedResponse = new DistanceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDistanceView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DistanceViewServiceClient client = new DistanceViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new DistanceViewName("[CUSTOMER]", "[DISTANCE_VIEW]").ToString();
            DistanceView response = client.GetDistanceView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetDistanceViewAsync()
        {
            Mock<DistanceViewService.DistanceViewServiceClient> mockGrpcClient = new Mock<DistanceViewService.DistanceViewServiceClient>(MockBehavior.Strict);
            GetDistanceViewRequest expectedRequest = new GetDistanceViewRequest
            {
                ResourceName = new DistanceViewName("[CUSTOMER]", "[DISTANCE_VIEW]").ToString(),
            };
            DistanceView expectedResponse = new DistanceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDistanceViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DistanceView>(Task.FromResult(expectedResponse), null, null, null, null));
            DistanceViewServiceClient client = new DistanceViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new DistanceViewName("[CUSTOMER]", "[DISTANCE_VIEW]").ToString();
            DistanceView response = await client.GetDistanceViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetDistanceView2()
        {
            Mock<DistanceViewService.DistanceViewServiceClient> mockGrpcClient = new Mock<DistanceViewService.DistanceViewServiceClient>(MockBehavior.Strict);
            GetDistanceViewRequest request = new GetDistanceViewRequest
            {
                ResourceName = new DistanceViewName("[CUSTOMER]", "[DISTANCE_VIEW]").ToString(),
            };
            DistanceView expectedResponse = new DistanceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDistanceView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DistanceViewServiceClient client = new DistanceViewServiceClientImpl(mockGrpcClient.Object, null);
            DistanceView response = client.GetDistanceView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetDistanceViewAsync2()
        {
            Mock<DistanceViewService.DistanceViewServiceClient> mockGrpcClient = new Mock<DistanceViewService.DistanceViewServiceClient>(MockBehavior.Strict);
            GetDistanceViewRequest request = new GetDistanceViewRequest
            {
                ResourceName = new DistanceViewName("[CUSTOMER]", "[DISTANCE_VIEW]").ToString(),
            };
            DistanceView expectedResponse = new DistanceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDistanceViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DistanceView>(Task.FromResult(expectedResponse), null, null, null, null));
            DistanceViewServiceClient client = new DistanceViewServiceClientImpl(mockGrpcClient.Object, null);
            DistanceView response = await client.GetDistanceViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

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
    public class GeneratedDetailPlacementViewServiceClientTest
    {
        [Test]
        public void GetDetailPlacementView()
        {
            Mock<DetailPlacementViewService.DetailPlacementViewServiceClient> mockGrpcClient = new Mock<DetailPlacementViewService.DetailPlacementViewServiceClient>(MockBehavior.Strict);
            GetDetailPlacementViewRequest expectedRequest = new GetDetailPlacementViewRequest
            {
                ResourceName = new DetailPlacementViewName("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]").ToString(),
            };
            DetailPlacementView expectedResponse = new DetailPlacementView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDetailPlacementView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DetailPlacementViewServiceClient client = new DetailPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new DetailPlacementViewName("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]").ToString();
            DetailPlacementView response = client.GetDetailPlacementView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetDetailPlacementViewAsync()
        {
            Mock<DetailPlacementViewService.DetailPlacementViewServiceClient> mockGrpcClient = new Mock<DetailPlacementViewService.DetailPlacementViewServiceClient>(MockBehavior.Strict);
            GetDetailPlacementViewRequest expectedRequest = new GetDetailPlacementViewRequest
            {
                ResourceName = new DetailPlacementViewName("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]").ToString(),
            };
            DetailPlacementView expectedResponse = new DetailPlacementView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDetailPlacementViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DetailPlacementView>(Task.FromResult(expectedResponse), null, null, null, null));
            DetailPlacementViewServiceClient client = new DetailPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new DetailPlacementViewName("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]").ToString();
            DetailPlacementView response = await client.GetDetailPlacementViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetDetailPlacementView2()
        {
            Mock<DetailPlacementViewService.DetailPlacementViewServiceClient> mockGrpcClient = new Mock<DetailPlacementViewService.DetailPlacementViewServiceClient>(MockBehavior.Strict);
            GetDetailPlacementViewRequest request = new GetDetailPlacementViewRequest
            {
                ResourceName = new DetailPlacementViewName("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]").ToString(),
            };
            DetailPlacementView expectedResponse = new DetailPlacementView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDetailPlacementView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DetailPlacementViewServiceClient client = new DetailPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            DetailPlacementView response = client.GetDetailPlacementView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetDetailPlacementViewAsync2()
        {
            Mock<DetailPlacementViewService.DetailPlacementViewServiceClient> mockGrpcClient = new Mock<DetailPlacementViewService.DetailPlacementViewServiceClient>(MockBehavior.Strict);
            GetDetailPlacementViewRequest request = new GetDetailPlacementViewRequest
            {
                ResourceName = new DetailPlacementViewName("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]").ToString(),
            };
            DetailPlacementView expectedResponse = new DetailPlacementView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDetailPlacementViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DetailPlacementView>(Task.FromResult(expectedResponse), null, null, null, null));
            DetailPlacementViewServiceClient client = new DetailPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            DetailPlacementView response = await client.GetDetailPlacementViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

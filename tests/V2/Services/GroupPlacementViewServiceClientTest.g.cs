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

namespace Google.Ads.GoogleAds.V2.Services.Tests
{
    using Google.Ads.GoogleAds.V2.Resources;
    using apis = Google.Ads.GoogleAds.V2.Services;
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
    public class GeneratedGroupPlacementViewServiceClientTest
    {
        [Test]
        public void GetGroupPlacementView()
        {
            Mock<GroupPlacementViewService.GroupPlacementViewServiceClient> mockGrpcClient = new Mock<GroupPlacementViewService.GroupPlacementViewServiceClient>(MockBehavior.Strict);
            GetGroupPlacementViewRequest expectedRequest = new GetGroupPlacementViewRequest
            {
                ResourceName = new GroupPlacementViewName("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]").ToString(),
            };
            GroupPlacementView expectedResponse = new GroupPlacementView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetGroupPlacementView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GroupPlacementViewServiceClient client = new GroupPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new GroupPlacementViewName("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]").ToString();
            GroupPlacementView response = client.GetGroupPlacementView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetGroupPlacementViewAsync()
        {
            Mock<GroupPlacementViewService.GroupPlacementViewServiceClient> mockGrpcClient = new Mock<GroupPlacementViewService.GroupPlacementViewServiceClient>(MockBehavior.Strict);
            GetGroupPlacementViewRequest expectedRequest = new GetGroupPlacementViewRequest
            {
                ResourceName = new GroupPlacementViewName("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]").ToString(),
            };
            GroupPlacementView expectedResponse = new GroupPlacementView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetGroupPlacementViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GroupPlacementView>(Task.FromResult(expectedResponse), null, null, null, null));
            GroupPlacementViewServiceClient client = new GroupPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new GroupPlacementViewName("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]").ToString();
            GroupPlacementView response = await client.GetGroupPlacementViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetGroupPlacementView2()
        {
            Mock<GroupPlacementViewService.GroupPlacementViewServiceClient> mockGrpcClient = new Mock<GroupPlacementViewService.GroupPlacementViewServiceClient>(MockBehavior.Strict);
            GetGroupPlacementViewRequest request = new GetGroupPlacementViewRequest
            {
                ResourceName = new GroupPlacementViewName("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]").ToString(),
            };
            GroupPlacementView expectedResponse = new GroupPlacementView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetGroupPlacementView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GroupPlacementViewServiceClient client = new GroupPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            GroupPlacementView response = client.GetGroupPlacementView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetGroupPlacementViewAsync2()
        {
            Mock<GroupPlacementViewService.GroupPlacementViewServiceClient> mockGrpcClient = new Mock<GroupPlacementViewService.GroupPlacementViewServiceClient>(MockBehavior.Strict);
            GetGroupPlacementViewRequest request = new GetGroupPlacementViewRequest
            {
                ResourceName = new GroupPlacementViewName("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]").ToString(),
            };
            GroupPlacementView expectedResponse = new GroupPlacementView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetGroupPlacementViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GroupPlacementView>(Task.FromResult(expectedResponse), null, null, null, null));
            GroupPlacementViewServiceClient client = new GroupPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            GroupPlacementView response = await client.GetGroupPlacementViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

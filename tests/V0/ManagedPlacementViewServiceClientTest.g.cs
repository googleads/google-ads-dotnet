// Copyright 2018 Google LLC
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

namespace Google.Ads.GoogleAds.V0.Services.Tests
{
    using Google.Ads.GoogleAds.V0.Resources;
    using apis = Google.Ads.GoogleAds.V0.Services;
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
    public class GeneratedManagedPlacementViewServiceClientTest
    {
        [Test]
        public void GetManagedPlacementView()
        {
            Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient> mockGrpcClient = new Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient>(MockBehavior.Strict);
            GetManagedPlacementViewRequest expectedRequest = new GetManagedPlacementViewRequest
            {
                ResourceName = new ManagedPlacementViewName("[CUSTOMER]", "[MANAGED_PLACEMENT_VIEW]").ToString(),
            };
            ManagedPlacementView expectedResponse = new ManagedPlacementView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetManagedPlacementView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ManagedPlacementViewServiceClient client = new ManagedPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ManagedPlacementViewName("[CUSTOMER]", "[MANAGED_PLACEMENT_VIEW]").ToString();
            ManagedPlacementView response = client.GetManagedPlacementView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetManagedPlacementViewAsync()
        {
            Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient> mockGrpcClient = new Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient>(MockBehavior.Strict);
            GetManagedPlacementViewRequest expectedRequest = new GetManagedPlacementViewRequest
            {
                ResourceName = new ManagedPlacementViewName("[CUSTOMER]", "[MANAGED_PLACEMENT_VIEW]").ToString(),
            };
            ManagedPlacementView expectedResponse = new ManagedPlacementView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetManagedPlacementViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ManagedPlacementView>(Task.FromResult(expectedResponse), null, null, null, null));
            ManagedPlacementViewServiceClient client = new ManagedPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ManagedPlacementViewName("[CUSTOMER]", "[MANAGED_PLACEMENT_VIEW]").ToString();
            ManagedPlacementView response = await client.GetManagedPlacementViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetManagedPlacementView2()
        {
            Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient> mockGrpcClient = new Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient>(MockBehavior.Strict);
            GetManagedPlacementViewRequest request = new GetManagedPlacementViewRequest
            {
                ResourceName = new ManagedPlacementViewName("[CUSTOMER]", "[MANAGED_PLACEMENT_VIEW]").ToString(),
            };
            ManagedPlacementView expectedResponse = new ManagedPlacementView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetManagedPlacementView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ManagedPlacementViewServiceClient client = new ManagedPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            ManagedPlacementView response = client.GetManagedPlacementView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetManagedPlacementViewAsync2()
        {
            Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient> mockGrpcClient = new Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient>(MockBehavior.Strict);
            GetManagedPlacementViewRequest request = new GetManagedPlacementViewRequest
            {
                ResourceName = new ManagedPlacementViewName("[CUSTOMER]", "[MANAGED_PLACEMENT_VIEW]").ToString(),
            };
            ManagedPlacementView expectedResponse = new ManagedPlacementView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetManagedPlacementViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ManagedPlacementView>(Task.FromResult(expectedResponse), null, null, null, null));
            ManagedPlacementViewServiceClient client = new ManagedPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            ManagedPlacementView response = await client.GetManagedPlacementViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

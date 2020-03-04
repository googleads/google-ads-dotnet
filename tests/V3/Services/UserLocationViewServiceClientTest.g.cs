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
    public class GeneratedUserLocationViewServiceClientTest
    {
        [Test]
        public void GetUserLocationView()
        {
            Mock<UserLocationViewService.UserLocationViewServiceClient> mockGrpcClient = new Mock<UserLocationViewService.UserLocationViewServiceClient>(MockBehavior.Strict);
            GetUserLocationViewRequest expectedRequest = new GetUserLocationViewRequest
            {
                ResourceName = new UserLocationViewName("[CUSTOMER]", "[USER_LOCATION_VIEW]").ToString(),
            };
            UserLocationView expectedResponse = new UserLocationView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetUserLocationView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UserLocationViewServiceClient client = new UserLocationViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new UserLocationViewName("[CUSTOMER]", "[USER_LOCATION_VIEW]").ToString();
            UserLocationView response = client.GetUserLocationView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetUserLocationViewAsync()
        {
            Mock<UserLocationViewService.UserLocationViewServiceClient> mockGrpcClient = new Mock<UserLocationViewService.UserLocationViewServiceClient>(MockBehavior.Strict);
            GetUserLocationViewRequest expectedRequest = new GetUserLocationViewRequest
            {
                ResourceName = new UserLocationViewName("[CUSTOMER]", "[USER_LOCATION_VIEW]").ToString(),
            };
            UserLocationView expectedResponse = new UserLocationView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetUserLocationViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UserLocationView>(Task.FromResult(expectedResponse), null, null, null, null));
            UserLocationViewServiceClient client = new UserLocationViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new UserLocationViewName("[CUSTOMER]", "[USER_LOCATION_VIEW]").ToString();
            UserLocationView response = await client.GetUserLocationViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetUserLocationView2()
        {
            Mock<UserLocationViewService.UserLocationViewServiceClient> mockGrpcClient = new Mock<UserLocationViewService.UserLocationViewServiceClient>(MockBehavior.Strict);
            GetUserLocationViewRequest request = new GetUserLocationViewRequest
            {
                ResourceName = new UserLocationViewName("[CUSTOMER]", "[USER_LOCATION_VIEW]").ToString(),
            };
            UserLocationView expectedResponse = new UserLocationView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetUserLocationView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UserLocationViewServiceClient client = new UserLocationViewServiceClientImpl(mockGrpcClient.Object, null);
            UserLocationView response = client.GetUserLocationView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetUserLocationViewAsync2()
        {
            Mock<UserLocationViewService.UserLocationViewServiceClient> mockGrpcClient = new Mock<UserLocationViewService.UserLocationViewServiceClient>(MockBehavior.Strict);
            GetUserLocationViewRequest request = new GetUserLocationViewRequest
            {
                ResourceName = new UserLocationViewName("[CUSTOMER]", "[USER_LOCATION_VIEW]").ToString(),
            };
            UserLocationView expectedResponse = new UserLocationView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetUserLocationViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UserLocationView>(Task.FromResult(expectedResponse), null, null, null, null));
            UserLocationViewServiceClient client = new UserLocationViewServiceClientImpl(mockGrpcClient.Object, null);
            UserLocationView response = await client.GetUserLocationViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

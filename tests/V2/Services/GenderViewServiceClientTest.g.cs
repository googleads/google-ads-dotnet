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
    public class GeneratedGenderViewServiceClientTest
    {
        [Test]
        public void GetGenderView()
        {
            Mock<GenderViewService.GenderViewServiceClient> mockGrpcClient = new Mock<GenderViewService.GenderViewServiceClient>(MockBehavior.Strict);
            GetGenderViewRequest expectedRequest = new GetGenderViewRequest
            {
                ResourceName = new GenderViewName("[CUSTOMER]", "[GENDER_VIEW]").ToString(),
            };
            GenderView expectedResponse = new GenderView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetGenderView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GenderViewServiceClient client = new GenderViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new GenderViewName("[CUSTOMER]", "[GENDER_VIEW]").ToString();
            GenderView response = client.GetGenderView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetGenderViewAsync()
        {
            Mock<GenderViewService.GenderViewServiceClient> mockGrpcClient = new Mock<GenderViewService.GenderViewServiceClient>(MockBehavior.Strict);
            GetGenderViewRequest expectedRequest = new GetGenderViewRequest
            {
                ResourceName = new GenderViewName("[CUSTOMER]", "[GENDER_VIEW]").ToString(),
            };
            GenderView expectedResponse = new GenderView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetGenderViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GenderView>(Task.FromResult(expectedResponse), null, null, null, null));
            GenderViewServiceClient client = new GenderViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new GenderViewName("[CUSTOMER]", "[GENDER_VIEW]").ToString();
            GenderView response = await client.GetGenderViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetGenderView2()
        {
            Mock<GenderViewService.GenderViewServiceClient> mockGrpcClient = new Mock<GenderViewService.GenderViewServiceClient>(MockBehavior.Strict);
            GetGenderViewRequest request = new GetGenderViewRequest
            {
                ResourceName = new GenderViewName("[CUSTOMER]", "[GENDER_VIEW]").ToString(),
            };
            GenderView expectedResponse = new GenderView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetGenderView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GenderViewServiceClient client = new GenderViewServiceClientImpl(mockGrpcClient.Object, null);
            GenderView response = client.GetGenderView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetGenderViewAsync2()
        {
            Mock<GenderViewService.GenderViewServiceClient> mockGrpcClient = new Mock<GenderViewService.GenderViewServiceClient>(MockBehavior.Strict);
            GetGenderViewRequest request = new GetGenderViewRequest
            {
                ResourceName = new GenderViewName("[CUSTOMER]", "[GENDER_VIEW]").ToString(),
            };
            GenderView expectedResponse = new GenderView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetGenderViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GenderView>(Task.FromResult(expectedResponse), null, null, null, null));
            GenderViewServiceClient client = new GenderViewServiceClientImpl(mockGrpcClient.Object, null);
            GenderView response = await client.GetGenderViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

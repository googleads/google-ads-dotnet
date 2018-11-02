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
    public class GeneratedParentalStatusViewServiceClientTest
    {
        [Test]
        public void GetParentalStatusView()
        {
            Mock<ParentalStatusViewService.ParentalStatusViewServiceClient> mockGrpcClient = new Mock<ParentalStatusViewService.ParentalStatusViewServiceClient>(MockBehavior.Strict);
            GetParentalStatusViewRequest expectedRequest = new GetParentalStatusViewRequest
            {
                ResourceName = new ParentalStatusViewName("[CUSTOMER]", "[PARENTAL_STATUS_VIEW]").ToString(),
            };
            ParentalStatusView expectedResponse = new ParentalStatusView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetParentalStatusView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ParentalStatusViewServiceClient client = new ParentalStatusViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ParentalStatusViewName("[CUSTOMER]", "[PARENTAL_STATUS_VIEW]").ToString();
            ParentalStatusView response = client.GetParentalStatusView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetParentalStatusViewAsync()
        {
            Mock<ParentalStatusViewService.ParentalStatusViewServiceClient> mockGrpcClient = new Mock<ParentalStatusViewService.ParentalStatusViewServiceClient>(MockBehavior.Strict);
            GetParentalStatusViewRequest expectedRequest = new GetParentalStatusViewRequest
            {
                ResourceName = new ParentalStatusViewName("[CUSTOMER]", "[PARENTAL_STATUS_VIEW]").ToString(),
            };
            ParentalStatusView expectedResponse = new ParentalStatusView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetParentalStatusViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ParentalStatusView>(Task.FromResult(expectedResponse), null, null, null, null));
            ParentalStatusViewServiceClient client = new ParentalStatusViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ParentalStatusViewName("[CUSTOMER]", "[PARENTAL_STATUS_VIEW]").ToString();
            ParentalStatusView response = await client.GetParentalStatusViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetParentalStatusView2()
        {
            Mock<ParentalStatusViewService.ParentalStatusViewServiceClient> mockGrpcClient = new Mock<ParentalStatusViewService.ParentalStatusViewServiceClient>(MockBehavior.Strict);
            GetParentalStatusViewRequest request = new GetParentalStatusViewRequest
            {
                ResourceName = new ParentalStatusViewName("[CUSTOMER]", "[PARENTAL_STATUS_VIEW]").ToString(),
            };
            ParentalStatusView expectedResponse = new ParentalStatusView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetParentalStatusView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ParentalStatusViewServiceClient client = new ParentalStatusViewServiceClientImpl(mockGrpcClient.Object, null);
            ParentalStatusView response = client.GetParentalStatusView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetParentalStatusViewAsync2()
        {
            Mock<ParentalStatusViewService.ParentalStatusViewServiceClient> mockGrpcClient = new Mock<ParentalStatusViewService.ParentalStatusViewServiceClient>(MockBehavior.Strict);
            GetParentalStatusViewRequest request = new GetParentalStatusViewRequest
            {
                ResourceName = new ParentalStatusViewName("[CUSTOMER]", "[PARENTAL_STATUS_VIEW]").ToString(),
            };
            ParentalStatusView expectedResponse = new ParentalStatusView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetParentalStatusViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ParentalStatusView>(Task.FromResult(expectedResponse), null, null, null, null));
            ParentalStatusViewServiceClient client = new ParentalStatusViewServiceClientImpl(mockGrpcClient.Object, null);
            ParentalStatusView response = await client.GetParentalStatusViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

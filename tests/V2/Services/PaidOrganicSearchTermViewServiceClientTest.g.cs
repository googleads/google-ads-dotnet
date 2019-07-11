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
    public class GeneratedPaidOrganicSearchTermViewServiceClientTest
    {
        [Test]
        public void GetPaidOrganicSearchTermView()
        {
            Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient> mockGrpcClient = new Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient>(MockBehavior.Strict);
            GetPaidOrganicSearchTermViewRequest expectedRequest = new GetPaidOrganicSearchTermViewRequest
            {
                ResourceName = new PaidOrganicSearchTermViewName("[CUSTOMER]", "[PAID_ORGANIC_SEARCH_TERM_VIEW]").ToString(),
            };
            PaidOrganicSearchTermView expectedResponse = new PaidOrganicSearchTermView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetPaidOrganicSearchTermView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            PaidOrganicSearchTermViewServiceClient client = new PaidOrganicSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new PaidOrganicSearchTermViewName("[CUSTOMER]", "[PAID_ORGANIC_SEARCH_TERM_VIEW]").ToString();
            PaidOrganicSearchTermView response = client.GetPaidOrganicSearchTermView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetPaidOrganicSearchTermViewAsync()
        {
            Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient> mockGrpcClient = new Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient>(MockBehavior.Strict);
            GetPaidOrganicSearchTermViewRequest expectedRequest = new GetPaidOrganicSearchTermViewRequest
            {
                ResourceName = new PaidOrganicSearchTermViewName("[CUSTOMER]", "[PAID_ORGANIC_SEARCH_TERM_VIEW]").ToString(),
            };
            PaidOrganicSearchTermView expectedResponse = new PaidOrganicSearchTermView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetPaidOrganicSearchTermViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<PaidOrganicSearchTermView>(Task.FromResult(expectedResponse), null, null, null, null));
            PaidOrganicSearchTermViewServiceClient client = new PaidOrganicSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new PaidOrganicSearchTermViewName("[CUSTOMER]", "[PAID_ORGANIC_SEARCH_TERM_VIEW]").ToString();
            PaidOrganicSearchTermView response = await client.GetPaidOrganicSearchTermViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetPaidOrganicSearchTermView2()
        {
            Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient> mockGrpcClient = new Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient>(MockBehavior.Strict);
            GetPaidOrganicSearchTermViewRequest request = new GetPaidOrganicSearchTermViewRequest
            {
                ResourceName = new PaidOrganicSearchTermViewName("[CUSTOMER]", "[PAID_ORGANIC_SEARCH_TERM_VIEW]").ToString(),
            };
            PaidOrganicSearchTermView expectedResponse = new PaidOrganicSearchTermView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetPaidOrganicSearchTermView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            PaidOrganicSearchTermViewServiceClient client = new PaidOrganicSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            PaidOrganicSearchTermView response = client.GetPaidOrganicSearchTermView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetPaidOrganicSearchTermViewAsync2()
        {
            Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient> mockGrpcClient = new Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient>(MockBehavior.Strict);
            GetPaidOrganicSearchTermViewRequest request = new GetPaidOrganicSearchTermViewRequest
            {
                ResourceName = new PaidOrganicSearchTermViewName("[CUSTOMER]", "[PAID_ORGANIC_SEARCH_TERM_VIEW]").ToString(),
            };
            PaidOrganicSearchTermView expectedResponse = new PaidOrganicSearchTermView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetPaidOrganicSearchTermViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<PaidOrganicSearchTermView>(Task.FromResult(expectedResponse), null, null, null, null));
            PaidOrganicSearchTermViewServiceClient client = new PaidOrganicSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            PaidOrganicSearchTermView response = await client.GetPaidOrganicSearchTermViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

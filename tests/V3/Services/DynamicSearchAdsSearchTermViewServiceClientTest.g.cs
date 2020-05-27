// Copyright 2020 Google LLC
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
    public class GeneratedDynamicSearchAdsSearchTermViewServiceClientTest
    {
        [Test]
        public void GetDynamicSearchAdsSearchTermView()
        {
            Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient> mockGrpcClient = new Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient>(MockBehavior.Strict);
            GetDynamicSearchAdsSearchTermViewRequest expectedRequest = new GetDynamicSearchAdsSearchTermViewRequest
            {
                ResourceName = new DynamicSearchAdsSearchTermViewName("[CUSTOMER]", "[DYNAMIC_SEARCH_ADS_SEARCH_TERM_VIEW]").ToString(),
            };
            DynamicSearchAdsSearchTermView expectedResponse = new DynamicSearchAdsSearchTermView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDynamicSearchAdsSearchTermView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DynamicSearchAdsSearchTermViewServiceClient client = new DynamicSearchAdsSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new DynamicSearchAdsSearchTermViewName("[CUSTOMER]", "[DYNAMIC_SEARCH_ADS_SEARCH_TERM_VIEW]").ToString();
            DynamicSearchAdsSearchTermView response = client.GetDynamicSearchAdsSearchTermView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetDynamicSearchAdsSearchTermViewAsync()
        {
            Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient> mockGrpcClient = new Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient>(MockBehavior.Strict);
            GetDynamicSearchAdsSearchTermViewRequest expectedRequest = new GetDynamicSearchAdsSearchTermViewRequest
            {
                ResourceName = new DynamicSearchAdsSearchTermViewName("[CUSTOMER]", "[DYNAMIC_SEARCH_ADS_SEARCH_TERM_VIEW]").ToString(),
            };
            DynamicSearchAdsSearchTermView expectedResponse = new DynamicSearchAdsSearchTermView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDynamicSearchAdsSearchTermViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DynamicSearchAdsSearchTermView>(Task.FromResult(expectedResponse), null, null, null, null));
            DynamicSearchAdsSearchTermViewServiceClient client = new DynamicSearchAdsSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new DynamicSearchAdsSearchTermViewName("[CUSTOMER]", "[DYNAMIC_SEARCH_ADS_SEARCH_TERM_VIEW]").ToString();
            DynamicSearchAdsSearchTermView response = await client.GetDynamicSearchAdsSearchTermViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetDynamicSearchAdsSearchTermView2()
        {
            Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient> mockGrpcClient = new Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient>(MockBehavior.Strict);
            GetDynamicSearchAdsSearchTermViewRequest request = new GetDynamicSearchAdsSearchTermViewRequest
            {
                ResourceName = new DynamicSearchAdsSearchTermViewName("[CUSTOMER]", "[DYNAMIC_SEARCH_ADS_SEARCH_TERM_VIEW]").ToString(),
            };
            DynamicSearchAdsSearchTermView expectedResponse = new DynamicSearchAdsSearchTermView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDynamicSearchAdsSearchTermView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DynamicSearchAdsSearchTermViewServiceClient client = new DynamicSearchAdsSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            DynamicSearchAdsSearchTermView response = client.GetDynamicSearchAdsSearchTermView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetDynamicSearchAdsSearchTermViewAsync2()
        {
            Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient> mockGrpcClient = new Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient>(MockBehavior.Strict);
            GetDynamicSearchAdsSearchTermViewRequest request = new GetDynamicSearchAdsSearchTermViewRequest
            {
                ResourceName = new DynamicSearchAdsSearchTermViewName("[CUSTOMER]", "[DYNAMIC_SEARCH_ADS_SEARCH_TERM_VIEW]").ToString(),
            };
            DynamicSearchAdsSearchTermView expectedResponse = new DynamicSearchAdsSearchTermView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDynamicSearchAdsSearchTermViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DynamicSearchAdsSearchTermView>(Task.FromResult(expectedResponse), null, null, null, null));
            DynamicSearchAdsSearchTermViewServiceClient client = new DynamicSearchAdsSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            DynamicSearchAdsSearchTermView response = await client.GetDynamicSearchAdsSearchTermViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

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

// TODO( b/119694056): Removed Comment

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
    public class GeneratedSearchTermViewServiceClientTest
    {
        [Test]
        public void GetSearchTermView()
        {
            Mock<SearchTermViewService.SearchTermViewServiceClient> mockGrpcClient = new Mock<SearchTermViewService.SearchTermViewServiceClient>(MockBehavior.Strict);
            GetSearchTermViewRequest expectedRequest = new GetSearchTermViewRequest
            {
                ResourceName = new SearchTermViewName("[CUSTOMER]", "[SEARCH_TERM_VIEW]").ToString(),
            };
            SearchTermView expectedResponse = new SearchTermView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetSearchTermView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SearchTermViewServiceClient client = new SearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new SearchTermViewName("[CUSTOMER]", "[SEARCH_TERM_VIEW]").ToString();
            SearchTermView response = client.GetSearchTermView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetSearchTermViewAsync()
        {
            Mock<SearchTermViewService.SearchTermViewServiceClient> mockGrpcClient = new Mock<SearchTermViewService.SearchTermViewServiceClient>(MockBehavior.Strict);
            GetSearchTermViewRequest expectedRequest = new GetSearchTermViewRequest
            {
                ResourceName = new SearchTermViewName("[CUSTOMER]", "[SEARCH_TERM_VIEW]").ToString(),
            };
            SearchTermView expectedResponse = new SearchTermView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetSearchTermViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SearchTermView>(Task.FromResult(expectedResponse), null, null, null, null));
            SearchTermViewServiceClient client = new SearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new SearchTermViewName("[CUSTOMER]", "[SEARCH_TERM_VIEW]").ToString();
            SearchTermView response = await client.GetSearchTermViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetSearchTermView2()
        {
            Mock<SearchTermViewService.SearchTermViewServiceClient> mockGrpcClient = new Mock<SearchTermViewService.SearchTermViewServiceClient>(MockBehavior.Strict);
            GetSearchTermViewRequest request = new GetSearchTermViewRequest
            {
                ResourceName = new SearchTermViewName("[CUSTOMER]", "[SEARCH_TERM_VIEW]").ToString(),
            };
            SearchTermView expectedResponse = new SearchTermView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetSearchTermView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SearchTermViewServiceClient client = new SearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            SearchTermView response = client.GetSearchTermView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetSearchTermViewAsync2()
        {
            Mock<SearchTermViewService.SearchTermViewServiceClient> mockGrpcClient = new Mock<SearchTermViewService.SearchTermViewServiceClient>(MockBehavior.Strict);
            GetSearchTermViewRequest request = new GetSearchTermViewRequest
            {
                ResourceName = new SearchTermViewName("[CUSTOMER]", "[SEARCH_TERM_VIEW]").ToString(),
            };
            SearchTermView expectedResponse = new SearchTermView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetSearchTermViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SearchTermView>(Task.FromResult(expectedResponse), null, null, null, null));
            SearchTermViewServiceClient client = new SearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            SearchTermView response = await client.GetSearchTermViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

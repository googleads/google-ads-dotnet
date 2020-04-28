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
    public class GeneratedKeywordViewServiceClientTest
    {
        [Test]
        public void GetKeywordView()
        {
            Mock<KeywordViewService.KeywordViewServiceClient> mockGrpcClient = new Mock<KeywordViewService.KeywordViewServiceClient>(MockBehavior.Strict);
            GetKeywordViewRequest expectedRequest = new GetKeywordViewRequest
            {
                ResourceName = new KeywordViewName("[CUSTOMER]", "[KEYWORD_VIEW]").ToString(),
            };
            KeywordView expectedResponse = new KeywordView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordViewServiceClient client = new KeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new KeywordViewName("[CUSTOMER]", "[KEYWORD_VIEW]").ToString();
            KeywordView response = client.GetKeywordView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetKeywordViewAsync()
        {
            Mock<KeywordViewService.KeywordViewServiceClient> mockGrpcClient = new Mock<KeywordViewService.KeywordViewServiceClient>(MockBehavior.Strict);
            GetKeywordViewRequest expectedRequest = new GetKeywordViewRequest
            {
                ResourceName = new KeywordViewName("[CUSTOMER]", "[KEYWORD_VIEW]").ToString(),
            };
            KeywordView expectedResponse = new KeywordView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<KeywordView>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordViewServiceClient client = new KeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new KeywordViewName("[CUSTOMER]", "[KEYWORD_VIEW]").ToString();
            KeywordView response = await client.GetKeywordViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetKeywordView2()
        {
            Mock<KeywordViewService.KeywordViewServiceClient> mockGrpcClient = new Mock<KeywordViewService.KeywordViewServiceClient>(MockBehavior.Strict);
            GetKeywordViewRequest request = new GetKeywordViewRequest
            {
                ResourceName = new KeywordViewName("[CUSTOMER]", "[KEYWORD_VIEW]").ToString(),
            };
            KeywordView expectedResponse = new KeywordView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordViewServiceClient client = new KeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            KeywordView response = client.GetKeywordView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetKeywordViewAsync2()
        {
            Mock<KeywordViewService.KeywordViewServiceClient> mockGrpcClient = new Mock<KeywordViewService.KeywordViewServiceClient>(MockBehavior.Strict);
            GetKeywordViewRequest request = new GetKeywordViewRequest
            {
                ResourceName = new KeywordViewName("[CUSTOMER]", "[KEYWORD_VIEW]").ToString(),
            };
            KeywordView expectedResponse = new KeywordView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<KeywordView>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordViewServiceClient client = new KeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            KeywordView response = await client.GetKeywordViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

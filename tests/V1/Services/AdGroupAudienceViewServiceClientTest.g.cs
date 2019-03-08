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
    public class GeneratedAdGroupAudienceViewServiceClientTest
    {
        [Test]
        public void GetAdGroupAudienceView()
        {
            Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient> mockGrpcClient = new Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient>(MockBehavior.Strict);
            GetAdGroupAudienceViewRequest expectedRequest = new GetAdGroupAudienceViewRequest
            {
                ResourceName = new AdGroupAudienceViewName("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]").ToString(),
            };
            AdGroupAudienceView expectedResponse = new AdGroupAudienceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAudienceView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupAudienceViewServiceClient client = new AdGroupAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupAudienceViewName("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]").ToString();
            AdGroupAudienceView response = client.GetAdGroupAudienceView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupAudienceViewAsync()
        {
            Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient> mockGrpcClient = new Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient>(MockBehavior.Strict);
            GetAdGroupAudienceViewRequest expectedRequest = new GetAdGroupAudienceViewRequest
            {
                ResourceName = new AdGroupAudienceViewName("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]").ToString(),
            };
            AdGroupAudienceView expectedResponse = new AdGroupAudienceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAudienceViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupAudienceView>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAudienceViewServiceClient client = new AdGroupAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupAudienceViewName("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]").ToString();
            AdGroupAudienceView response = await client.GetAdGroupAudienceViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroupAudienceView2()
        {
            Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient> mockGrpcClient = new Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient>(MockBehavior.Strict);
            GetAdGroupAudienceViewRequest request = new GetAdGroupAudienceViewRequest
            {
                ResourceName = new AdGroupAudienceViewName("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]").ToString(),
            };
            AdGroupAudienceView expectedResponse = new AdGroupAudienceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAudienceView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupAudienceViewServiceClient client = new AdGroupAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupAudienceView response = client.GetAdGroupAudienceView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupAudienceViewAsync2()
        {
            Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient> mockGrpcClient = new Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient>(MockBehavior.Strict);
            GetAdGroupAudienceViewRequest request = new GetAdGroupAudienceViewRequest
            {
                ResourceName = new AdGroupAudienceViewName("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]").ToString(),
            };
            AdGroupAudienceView expectedResponse = new AdGroupAudienceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAudienceViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupAudienceView>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAudienceViewServiceClient client = new AdGroupAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupAudienceView response = await client.GetAdGroupAudienceViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

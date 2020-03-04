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
    public class GeneratedAdGroupAdAssetViewServiceClientTest
    {
        [Test]
        public void GetAdGroupAdAssetView()
        {
            Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient> mockGrpcClient = new Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient>(MockBehavior.Strict);
            GetAdGroupAdAssetViewRequest expectedRequest = new GetAdGroupAdAssetViewRequest
            {
                ResourceName = new AdGroupAdAssetViewName("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]").ToString(),
            };
            AdGroupAdAssetView expectedResponse = new AdGroupAdAssetView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdAssetView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupAdAssetViewServiceClient client = new AdGroupAdAssetViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupAdAssetViewName("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]").ToString();
            AdGroupAdAssetView response = client.GetAdGroupAdAssetView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupAdAssetViewAsync()
        {
            Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient> mockGrpcClient = new Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient>(MockBehavior.Strict);
            GetAdGroupAdAssetViewRequest expectedRequest = new GetAdGroupAdAssetViewRequest
            {
                ResourceName = new AdGroupAdAssetViewName("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]").ToString(),
            };
            AdGroupAdAssetView expectedResponse = new AdGroupAdAssetView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdAssetViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupAdAssetView>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdAssetViewServiceClient client = new AdGroupAdAssetViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupAdAssetViewName("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]").ToString();
            AdGroupAdAssetView response = await client.GetAdGroupAdAssetViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroupAdAssetView2()
        {
            Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient> mockGrpcClient = new Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient>(MockBehavior.Strict);
            GetAdGroupAdAssetViewRequest request = new GetAdGroupAdAssetViewRequest
            {
                ResourceName = new AdGroupAdAssetViewName("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]").ToString(),
            };
            AdGroupAdAssetView expectedResponse = new AdGroupAdAssetView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdAssetView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupAdAssetViewServiceClient client = new AdGroupAdAssetViewServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupAdAssetView response = client.GetAdGroupAdAssetView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupAdAssetViewAsync2()
        {
            Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient> mockGrpcClient = new Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient>(MockBehavior.Strict);
            GetAdGroupAdAssetViewRequest request = new GetAdGroupAdAssetViewRequest
            {
                ResourceName = new AdGroupAdAssetViewName("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]").ToString(),
            };
            AdGroupAdAssetView expectedResponse = new AdGroupAdAssetView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdAssetViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupAdAssetView>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdAssetViewServiceClient client = new AdGroupAdAssetViewServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupAdAssetView response = await client.GetAdGroupAdAssetViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

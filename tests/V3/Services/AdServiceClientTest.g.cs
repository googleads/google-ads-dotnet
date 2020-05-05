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
    public class GeneratedAdServiceClientTest
    {
        [Test]
        public void GetAd()
        {
            Mock<AdService.AdServiceClient> mockGrpcClient = new Mock<AdService.AdServiceClient>(MockBehavior.Strict);
            GetAdRequest expectedRequest = new GetAdRequest
            {
                ResourceName = new AdName("[CUSTOMER]", "[AD]").ToString(),
            };
            Ad expectedResponse = new Ad
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAd(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdName("[CUSTOMER]", "[AD]").ToString();
            Ad response = client.GetAd(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdAsync()
        {
            Mock<AdService.AdServiceClient> mockGrpcClient = new Mock<AdService.AdServiceClient>(MockBehavior.Strict);
            GetAdRequest expectedRequest = new GetAdRequest
            {
                ResourceName = new AdName("[CUSTOMER]", "[AD]").ToString(),
            };
            Ad expectedResponse = new Ad
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Ad>(Task.FromResult(expectedResponse), null, null, null, null));
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdName("[CUSTOMER]", "[AD]").ToString();
            Ad response = await client.GetAdAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAd2()
        {
            Mock<AdService.AdServiceClient> mockGrpcClient = new Mock<AdService.AdServiceClient>(MockBehavior.Strict);
            GetAdRequest request = new GetAdRequest
            {
                ResourceName = new AdName("[CUSTOMER]", "[AD]").ToString(),
            };
            Ad expectedResponse = new Ad
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAd(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            Ad response = client.GetAd(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdAsync2()
        {
            Mock<AdService.AdServiceClient> mockGrpcClient = new Mock<AdService.AdServiceClient>(MockBehavior.Strict);
            GetAdRequest request = new GetAdRequest
            {
                ResourceName = new AdName("[CUSTOMER]", "[AD]").ToString(),
            };
            Ad expectedResponse = new Ad
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Ad>(Task.FromResult(expectedResponse), null, null, null, null));
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            Ad response = await client.GetAdAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAds()
        {
            Mock<AdService.AdServiceClient> mockGrpcClient = new Mock<AdService.AdServiceClient>(MockBehavior.Strict);
            MutateAdsRequest expectedRequest = new MutateAdsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdsResponse expectedResponse = new MutateAdsResponse();
            mockGrpcClient.Setup(x => x.MutateAds(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdOperation> operations = new List<AdOperation>();
            MutateAdsResponse response = client.MutateAds(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdsAsync()
        {
            Mock<AdService.AdServiceClient> mockGrpcClient = new Mock<AdService.AdServiceClient>(MockBehavior.Strict);
            MutateAdsRequest expectedRequest = new MutateAdsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdsResponse expectedResponse = new MutateAdsResponse();
            mockGrpcClient.Setup(x => x.MutateAdsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdOperation> operations = new List<AdOperation>();
            MutateAdsResponse response = await client.MutateAdsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAds2()
        {
            Mock<AdService.AdServiceClient> mockGrpcClient = new Mock<AdService.AdServiceClient>(MockBehavior.Strict);
            MutateAdsRequest request = new MutateAdsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdsResponse expectedResponse = new MutateAdsResponse();
            mockGrpcClient.Setup(x => x.MutateAds(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdsResponse response = client.MutateAds(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdsAsync2()
        {
            Mock<AdService.AdServiceClient> mockGrpcClient = new Mock<AdService.AdServiceClient>(MockBehavior.Strict);
            MutateAdsRequest request = new MutateAdsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdsResponse expectedResponse = new MutateAdsResponse();
            mockGrpcClient.Setup(x => x.MutateAdsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdServiceClient client = new AdServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdsResponse response = await client.MutateAdsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

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
    public class GeneratedAdGroupAdServiceClientTest
    {
        [Test]
        public void GetAdGroupAd()
        {
            Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new Mock<AdGroupAdService.AdGroupAdServiceClient>(MockBehavior.Strict);
            GetAdGroupAdRequest expectedRequest = new GetAdGroupAdRequest
            {
                ResourceName = new AdGroupAdName("[CUSTOMER]", "[AD_GROUP_AD]").ToString(),
            };
            AdGroupAd expectedResponse = new AdGroupAd
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAd(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupAdName("[CUSTOMER]", "[AD_GROUP_AD]").ToString();
            AdGroupAd response = client.GetAdGroupAd(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupAdAsync()
        {
            Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new Mock<AdGroupAdService.AdGroupAdServiceClient>(MockBehavior.Strict);
            GetAdGroupAdRequest expectedRequest = new GetAdGroupAdRequest
            {
                ResourceName = new AdGroupAdName("[CUSTOMER]", "[AD_GROUP_AD]").ToString(),
            };
            AdGroupAd expectedResponse = new AdGroupAd
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupAd>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupAdName("[CUSTOMER]", "[AD_GROUP_AD]").ToString();
            AdGroupAd response = await client.GetAdGroupAdAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroupAd2()
        {
            Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new Mock<AdGroupAdService.AdGroupAdServiceClient>(MockBehavior.Strict);
            GetAdGroupAdRequest request = new GetAdGroupAdRequest
            {
                ResourceName = new AdGroupAdName("[CUSTOMER]", "[AD_GROUP_AD]").ToString(),
            };
            AdGroupAd expectedResponse = new AdGroupAd
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAd(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupAd response = client.GetAdGroupAd(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupAdAsync2()
        {
            Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new Mock<AdGroupAdService.AdGroupAdServiceClient>(MockBehavior.Strict);
            GetAdGroupAdRequest request = new GetAdGroupAdRequest
            {
                ResourceName = new AdGroupAdName("[CUSTOMER]", "[AD_GROUP_AD]").ToString(),
            };
            AdGroupAd expectedResponse = new AdGroupAd
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupAd>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupAd response = await client.GetAdGroupAdAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupAds()
        {
            Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new Mock<AdGroupAdService.AdGroupAdServiceClient>(MockBehavior.Strict);
            MutateAdGroupAdsRequest expectedRequest = new MutateAdGroupAdsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdGroupAdsResponse expectedResponse = new MutateAdGroupAdsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupAds(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupAdOperation> operations = new List<AdGroupAdOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdGroupAdsResponse response = client.MutateAdGroupAds(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupAdsAsync()
        {
            Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new Mock<AdGroupAdService.AdGroupAdServiceClient>(MockBehavior.Strict);
            MutateAdGroupAdsRequest expectedRequest = new MutateAdGroupAdsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdGroupAdsResponse expectedResponse = new MutateAdGroupAdsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupAdsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupAdsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupAdOperation> operations = new List<AdGroupAdOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdGroupAdsResponse response = await client.MutateAdGroupAdsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupAds2()
        {
            Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new Mock<AdGroupAdService.AdGroupAdServiceClient>(MockBehavior.Strict);
            MutateAdGroupAdsRequest expectedRequest = new MutateAdGroupAdsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupAdsResponse expectedResponse = new MutateAdGroupAdsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupAds(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupAdOperation> operations = new List<AdGroupAdOperation>();
            MutateAdGroupAdsResponse response = client.MutateAdGroupAds(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupAdsAsync2()
        {
            Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new Mock<AdGroupAdService.AdGroupAdServiceClient>(MockBehavior.Strict);
            MutateAdGroupAdsRequest expectedRequest = new MutateAdGroupAdsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupAdsResponse expectedResponse = new MutateAdGroupAdsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupAdsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupAdsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupAdOperation> operations = new List<AdGroupAdOperation>();
            MutateAdGroupAdsResponse response = await client.MutateAdGroupAdsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupAds3()
        {
            Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new Mock<AdGroupAdService.AdGroupAdServiceClient>(MockBehavior.Strict);
            MutateAdGroupAdsRequest request = new MutateAdGroupAdsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupAdsResponse expectedResponse = new MutateAdGroupAdsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupAds(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupAdsResponse response = client.MutateAdGroupAds(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupAdsAsync3()
        {
            Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new Mock<AdGroupAdService.AdGroupAdServiceClient>(MockBehavior.Strict);
            MutateAdGroupAdsRequest request = new MutateAdGroupAdsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupAdsResponse expectedResponse = new MutateAdGroupAdsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupAdsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupAdsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupAdsResponse response = await client.MutateAdGroupAdsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

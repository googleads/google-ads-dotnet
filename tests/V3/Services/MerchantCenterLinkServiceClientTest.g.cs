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
    public class GeneratedMerchantCenterLinkServiceClientTest
    {
        [Test]
        public void ListMerchantCenterLinks()
        {
            Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(MockBehavior.Strict);
            ListMerchantCenterLinksRequest expectedRequest = new ListMerchantCenterLinksRequest
            {
                CustomerId = "customerId-1772061412",
            };
            ListMerchantCenterLinksResponse expectedResponse = new ListMerchantCenterLinksResponse();
            mockGrpcClient.Setup(x => x.ListMerchantCenterLinks(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            ListMerchantCenterLinksResponse response = client.ListMerchantCenterLinks(customerId);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task ListMerchantCenterLinksAsync()
        {
            Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(MockBehavior.Strict);
            ListMerchantCenterLinksRequest expectedRequest = new ListMerchantCenterLinksRequest
            {
                CustomerId = "customerId-1772061412",
            };
            ListMerchantCenterLinksResponse expectedResponse = new ListMerchantCenterLinksResponse();
            mockGrpcClient.Setup(x => x.ListMerchantCenterLinksAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListMerchantCenterLinksResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            ListMerchantCenterLinksResponse response = await client.ListMerchantCenterLinksAsync(customerId);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void ListMerchantCenterLinks2()
        {
            Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(MockBehavior.Strict);
            ListMerchantCenterLinksRequest request = new ListMerchantCenterLinksRequest
            {
                CustomerId = "customerId-1772061412",
            };
            ListMerchantCenterLinksResponse expectedResponse = new ListMerchantCenterLinksResponse();
            mockGrpcClient.Setup(x => x.ListMerchantCenterLinks(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            ListMerchantCenterLinksResponse response = client.ListMerchantCenterLinks(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task ListMerchantCenterLinksAsync2()
        {
            Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(MockBehavior.Strict);
            ListMerchantCenterLinksRequest request = new ListMerchantCenterLinksRequest
            {
                CustomerId = "customerId-1772061412",
            };
            ListMerchantCenterLinksResponse expectedResponse = new ListMerchantCenterLinksResponse();
            mockGrpcClient.Setup(x => x.ListMerchantCenterLinksAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListMerchantCenterLinksResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            ListMerchantCenterLinksResponse response = await client.ListMerchantCenterLinksAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetMerchantCenterLink()
        {
            Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(MockBehavior.Strict);
            GetMerchantCenterLinkRequest expectedRequest = new GetMerchantCenterLinkRequest
            {
                ResourceName = new MerchantCenterLinkName("[CUSTOMER]", "[MERCHANT_CENTER_LINK]").ToString(),
            };
            MerchantCenterLink expectedResponse = new MerchantCenterLink
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMerchantCenterLink(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new MerchantCenterLinkName("[CUSTOMER]", "[MERCHANT_CENTER_LINK]").ToString();
            MerchantCenterLink response = client.GetMerchantCenterLink(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetMerchantCenterLinkAsync()
        {
            Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(MockBehavior.Strict);
            GetMerchantCenterLinkRequest expectedRequest = new GetMerchantCenterLinkRequest
            {
                ResourceName = new MerchantCenterLinkName("[CUSTOMER]", "[MERCHANT_CENTER_LINK]").ToString(),
            };
            MerchantCenterLink expectedResponse = new MerchantCenterLink
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMerchantCenterLinkAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MerchantCenterLink>(Task.FromResult(expectedResponse), null, null, null, null));
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new MerchantCenterLinkName("[CUSTOMER]", "[MERCHANT_CENTER_LINK]").ToString();
            MerchantCenterLink response = await client.GetMerchantCenterLinkAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetMerchantCenterLink2()
        {
            Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(MockBehavior.Strict);
            GetMerchantCenterLinkRequest request = new GetMerchantCenterLinkRequest
            {
                ResourceName = new MerchantCenterLinkName("[CUSTOMER]", "[MERCHANT_CENTER_LINK]").ToString(),
            };
            MerchantCenterLink expectedResponse = new MerchantCenterLink
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMerchantCenterLink(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            MerchantCenterLink response = client.GetMerchantCenterLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetMerchantCenterLinkAsync2()
        {
            Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(MockBehavior.Strict);
            GetMerchantCenterLinkRequest request = new GetMerchantCenterLinkRequest
            {
                ResourceName = new MerchantCenterLinkName("[CUSTOMER]", "[MERCHANT_CENTER_LINK]").ToString(),
            };
            MerchantCenterLink expectedResponse = new MerchantCenterLink
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMerchantCenterLinkAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MerchantCenterLink>(Task.FromResult(expectedResponse), null, null, null, null));
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            MerchantCenterLink response = await client.GetMerchantCenterLinkAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateMerchantCenterLink()
        {
            Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(MockBehavior.Strict);
            MutateMerchantCenterLinkRequest expectedRequest = new MutateMerchantCenterLinkRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new MerchantCenterLinkOperation(),
            };
            MutateMerchantCenterLinkResponse expectedResponse = new MutateMerchantCenterLinkResponse();
            mockGrpcClient.Setup(x => x.MutateMerchantCenterLink(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            MerchantCenterLinkOperation operation = new MerchantCenterLinkOperation();
            MutateMerchantCenterLinkResponse response = client.MutateMerchantCenterLink(customerId, operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateMerchantCenterLinkAsync()
        {
            Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(MockBehavior.Strict);
            MutateMerchantCenterLinkRequest expectedRequest = new MutateMerchantCenterLinkRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new MerchantCenterLinkOperation(),
            };
            MutateMerchantCenterLinkResponse expectedResponse = new MutateMerchantCenterLinkResponse();
            mockGrpcClient.Setup(x => x.MutateMerchantCenterLinkAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateMerchantCenterLinkResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            MerchantCenterLinkOperation operation = new MerchantCenterLinkOperation();
            MutateMerchantCenterLinkResponse response = await client.MutateMerchantCenterLinkAsync(customerId, operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateMerchantCenterLink2()
        {
            Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(MockBehavior.Strict);
            MutateMerchantCenterLinkRequest request = new MutateMerchantCenterLinkRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new MerchantCenterLinkOperation(),
            };
            MutateMerchantCenterLinkResponse expectedResponse = new MutateMerchantCenterLinkResponse();
            mockGrpcClient.Setup(x => x.MutateMerchantCenterLink(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateMerchantCenterLinkResponse response = client.MutateMerchantCenterLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateMerchantCenterLinkAsync2()
        {
            Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient> mockGrpcClient = new Mock<MerchantCenterLinkService.MerchantCenterLinkServiceClient>(MockBehavior.Strict);
            MutateMerchantCenterLinkRequest request = new MutateMerchantCenterLinkRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new MerchantCenterLinkOperation(),
            };
            MutateMerchantCenterLinkResponse expectedResponse = new MutateMerchantCenterLinkResponse();
            mockGrpcClient.Setup(x => x.MutateMerchantCenterLinkAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateMerchantCenterLinkResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            MerchantCenterLinkServiceClient client = new MerchantCenterLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateMerchantCenterLinkResponse response = await client.MutateMerchantCenterLinkAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

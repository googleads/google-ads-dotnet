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
    public class GeneratedExtensionFeedItemServiceClientTest
    {
        [Test]
        public void GetExtensionFeedItem()
        {
            Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(MockBehavior.Strict);
            GetExtensionFeedItemRequest expectedRequest = new GetExtensionFeedItemRequest
            {
                ResourceName = new ExtensionFeedItemName("[CUSTOMER]", "[EXTENSION_FEED_ITEM]").ToString(),
            };
            ExtensionFeedItem expectedResponse = new ExtensionFeedItem
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetExtensionFeedItem(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ExtensionFeedItemName("[CUSTOMER]", "[EXTENSION_FEED_ITEM]").ToString();
            ExtensionFeedItem response = client.GetExtensionFeedItem(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetExtensionFeedItemAsync()
        {
            Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(MockBehavior.Strict);
            GetExtensionFeedItemRequest expectedRequest = new GetExtensionFeedItemRequest
            {
                ResourceName = new ExtensionFeedItemName("[CUSTOMER]", "[EXTENSION_FEED_ITEM]").ToString(),
            };
            ExtensionFeedItem expectedResponse = new ExtensionFeedItem
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetExtensionFeedItemAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ExtensionFeedItem>(Task.FromResult(expectedResponse), null, null, null, null));
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ExtensionFeedItemName("[CUSTOMER]", "[EXTENSION_FEED_ITEM]").ToString();
            ExtensionFeedItem response = await client.GetExtensionFeedItemAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetExtensionFeedItem2()
        {
            Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(MockBehavior.Strict);
            GetExtensionFeedItemRequest request = new GetExtensionFeedItemRequest
            {
                ResourceName = new ExtensionFeedItemName("[CUSTOMER]", "[EXTENSION_FEED_ITEM]").ToString(),
            };
            ExtensionFeedItem expectedResponse = new ExtensionFeedItem
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetExtensionFeedItem(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            ExtensionFeedItem response = client.GetExtensionFeedItem(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetExtensionFeedItemAsync2()
        {
            Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(MockBehavior.Strict);
            GetExtensionFeedItemRequest request = new GetExtensionFeedItemRequest
            {
                ResourceName = new ExtensionFeedItemName("[CUSTOMER]", "[EXTENSION_FEED_ITEM]").ToString(),
            };
            ExtensionFeedItem expectedResponse = new ExtensionFeedItem
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetExtensionFeedItemAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ExtensionFeedItem>(Task.FromResult(expectedResponse), null, null, null, null));
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            ExtensionFeedItem response = await client.GetExtensionFeedItemAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateExtensionFeedItems()
        {
            Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(MockBehavior.Strict);
            MutateExtensionFeedItemsRequest expectedRequest = new MutateExtensionFeedItemsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                ValidateOnly = false,
            };
            MutateExtensionFeedItemsResponse expectedResponse = new MutateExtensionFeedItemsResponse();
            mockGrpcClient.Setup(x => x.MutateExtensionFeedItems(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ExtensionFeedItemOperation> operations = new List<ExtensionFeedItemOperation>();
            bool validateOnly = false;
            MutateExtensionFeedItemsResponse response = client.MutateExtensionFeedItems(customerId, operations, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateExtensionFeedItemsAsync()
        {
            Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(MockBehavior.Strict);
            MutateExtensionFeedItemsRequest expectedRequest = new MutateExtensionFeedItemsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                ValidateOnly = false,
            };
            MutateExtensionFeedItemsResponse expectedResponse = new MutateExtensionFeedItemsResponse();
            mockGrpcClient.Setup(x => x.MutateExtensionFeedItemsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateExtensionFeedItemsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ExtensionFeedItemOperation> operations = new List<ExtensionFeedItemOperation>();
            bool validateOnly = false;
            MutateExtensionFeedItemsResponse response = await client.MutateExtensionFeedItemsAsync(customerId, operations, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateExtensionFeedItems2()
        {
            Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(MockBehavior.Strict);
            MutateExtensionFeedItemsRequest expectedRequest = new MutateExtensionFeedItemsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateExtensionFeedItemsResponse expectedResponse = new MutateExtensionFeedItemsResponse();
            mockGrpcClient.Setup(x => x.MutateExtensionFeedItems(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ExtensionFeedItemOperation> operations = new List<ExtensionFeedItemOperation>();
            MutateExtensionFeedItemsResponse response = client.MutateExtensionFeedItems(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateExtensionFeedItemsAsync2()
        {
            Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(MockBehavior.Strict);
            MutateExtensionFeedItemsRequest expectedRequest = new MutateExtensionFeedItemsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateExtensionFeedItemsResponse expectedResponse = new MutateExtensionFeedItemsResponse();
            mockGrpcClient.Setup(x => x.MutateExtensionFeedItemsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateExtensionFeedItemsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ExtensionFeedItemOperation> operations = new List<ExtensionFeedItemOperation>();
            MutateExtensionFeedItemsResponse response = await client.MutateExtensionFeedItemsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateExtensionFeedItems3()
        {
            Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(MockBehavior.Strict);
            MutateExtensionFeedItemsRequest request = new MutateExtensionFeedItemsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateExtensionFeedItemsResponse expectedResponse = new MutateExtensionFeedItemsResponse();
            mockGrpcClient.Setup(x => x.MutateExtensionFeedItems(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            MutateExtensionFeedItemsResponse response = client.MutateExtensionFeedItems(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateExtensionFeedItemsAsync3()
        {
            Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(MockBehavior.Strict);
            MutateExtensionFeedItemsRequest request = new MutateExtensionFeedItemsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateExtensionFeedItemsResponse expectedResponse = new MutateExtensionFeedItemsResponse();
            mockGrpcClient.Setup(x => x.MutateExtensionFeedItemsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateExtensionFeedItemsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            MutateExtensionFeedItemsResponse response = await client.MutateExtensionFeedItemsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

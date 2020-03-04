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
    public class GeneratedCustomerFeedServiceClientTest
    {
        [Test]
        public void GetCustomerFeed()
        {
            Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new Mock<CustomerFeedService.CustomerFeedServiceClient>(MockBehavior.Strict);
            GetCustomerFeedRequest expectedRequest = new GetCustomerFeedRequest
            {
                ResourceName = new CustomerFeedName("[CUSTOMER]", "[CUSTOMER_FEED]").ToString(),
            };
            CustomerFeed expectedResponse = new CustomerFeed
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerFeed(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerFeedName("[CUSTOMER]", "[CUSTOMER_FEED]").ToString();
            CustomerFeed response = client.GetCustomerFeed(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerFeedAsync()
        {
            Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new Mock<CustomerFeedService.CustomerFeedServiceClient>(MockBehavior.Strict);
            GetCustomerFeedRequest expectedRequest = new GetCustomerFeedRequest
            {
                ResourceName = new CustomerFeedName("[CUSTOMER]", "[CUSTOMER_FEED]").ToString(),
            };
            CustomerFeed expectedResponse = new CustomerFeed
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerFeedAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CustomerFeed>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerFeedName("[CUSTOMER]", "[CUSTOMER_FEED]").ToString();
            CustomerFeed response = await client.GetCustomerFeedAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCustomerFeed2()
        {
            Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new Mock<CustomerFeedService.CustomerFeedServiceClient>(MockBehavior.Strict);
            GetCustomerFeedRequest request = new GetCustomerFeedRequest
            {
                ResourceName = new CustomerFeedName("[CUSTOMER]", "[CUSTOMER_FEED]").ToString(),
            };
            CustomerFeed expectedResponse = new CustomerFeed
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerFeed(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            CustomerFeed response = client.GetCustomerFeed(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerFeedAsync2()
        {
            Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new Mock<CustomerFeedService.CustomerFeedServiceClient>(MockBehavior.Strict);
            GetCustomerFeedRequest request = new GetCustomerFeedRequest
            {
                ResourceName = new CustomerFeedName("[CUSTOMER]", "[CUSTOMER_FEED]").ToString(),
            };
            CustomerFeed expectedResponse = new CustomerFeed
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerFeedAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CustomerFeed>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            CustomerFeed response = await client.GetCustomerFeedAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerFeeds()
        {
            Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new Mock<CustomerFeedService.CustomerFeedServiceClient>(MockBehavior.Strict);
            MutateCustomerFeedsRequest expectedRequest = new MutateCustomerFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCustomerFeedsResponse expectedResponse = new MutateCustomerFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerFeeds(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerFeedOperation> operations = new List<CustomerFeedOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCustomerFeedsResponse response = client.MutateCustomerFeeds(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomerFeedsAsync()
        {
            Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new Mock<CustomerFeedService.CustomerFeedServiceClient>(MockBehavior.Strict);
            MutateCustomerFeedsRequest expectedRequest = new MutateCustomerFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCustomerFeedsResponse expectedResponse = new MutateCustomerFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerFeedsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomerFeedsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerFeedOperation> operations = new List<CustomerFeedOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCustomerFeedsResponse response = await client.MutateCustomerFeedsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerFeeds2()
        {
            Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new Mock<CustomerFeedService.CustomerFeedServiceClient>(MockBehavior.Strict);
            MutateCustomerFeedsRequest expectedRequest = new MutateCustomerFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerFeedsResponse expectedResponse = new MutateCustomerFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerFeeds(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerFeedOperation> operations = new List<CustomerFeedOperation>();
            MutateCustomerFeedsResponse response = client.MutateCustomerFeeds(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomerFeedsAsync2()
        {
            Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new Mock<CustomerFeedService.CustomerFeedServiceClient>(MockBehavior.Strict);
            MutateCustomerFeedsRequest expectedRequest = new MutateCustomerFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerFeedsResponse expectedResponse = new MutateCustomerFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerFeedsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomerFeedsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerFeedOperation> operations = new List<CustomerFeedOperation>();
            MutateCustomerFeedsResponse response = await client.MutateCustomerFeedsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerFeeds3()
        {
            Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new Mock<CustomerFeedService.CustomerFeedServiceClient>(MockBehavior.Strict);
            MutateCustomerFeedsRequest request = new MutateCustomerFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerFeedsResponse expectedResponse = new MutateCustomerFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerFeeds(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerFeedsResponse response = client.MutateCustomerFeeds(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomerFeedsAsync3()
        {
            Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new Mock<CustomerFeedService.CustomerFeedServiceClient>(MockBehavior.Strict);
            MutateCustomerFeedsRequest request = new MutateCustomerFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerFeedsResponse expectedResponse = new MutateCustomerFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerFeedsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomerFeedsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerFeedsResponse response = await client.MutateCustomerFeedsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

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
    public class GeneratedCustomerManagerLinkServiceClientTest
    {
        [Test]
        public void GetCustomerManagerLink()
        {
            Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(MockBehavior.Strict);
            GetCustomerManagerLinkRequest expectedRequest = new GetCustomerManagerLinkRequest
            {
                ResourceName = new CustomerManagerLinkName("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]").ToString(),
            };
            CustomerManagerLink expectedResponse = new CustomerManagerLink
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerManagerLink(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerManagerLinkName("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]").ToString();
            CustomerManagerLink response = client.GetCustomerManagerLink(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerManagerLinkAsync()
        {
            Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(MockBehavior.Strict);
            GetCustomerManagerLinkRequest expectedRequest = new GetCustomerManagerLinkRequest
            {
                ResourceName = new CustomerManagerLinkName("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]").ToString(),
            };
            CustomerManagerLink expectedResponse = new CustomerManagerLink
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerManagerLinkAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CustomerManagerLink>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerManagerLinkName("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]").ToString();
            CustomerManagerLink response = await client.GetCustomerManagerLinkAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCustomerManagerLink2()
        {
            Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(MockBehavior.Strict);
            GetCustomerManagerLinkRequest request = new GetCustomerManagerLinkRequest
            {
                ResourceName = new CustomerManagerLinkName("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]").ToString(),
            };
            CustomerManagerLink expectedResponse = new CustomerManagerLink
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerManagerLink(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            CustomerManagerLink response = client.GetCustomerManagerLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerManagerLinkAsync2()
        {
            Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(MockBehavior.Strict);
            GetCustomerManagerLinkRequest request = new GetCustomerManagerLinkRequest
            {
                ResourceName = new CustomerManagerLinkName("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]").ToString(),
            };
            CustomerManagerLink expectedResponse = new CustomerManagerLink
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerManagerLinkAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CustomerManagerLink>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            CustomerManagerLink response = await client.GetCustomerManagerLinkAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerManagerLink()
        {
            Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(MockBehavior.Strict);
            MutateCustomerManagerLinkRequest expectedRequest = new MutateCustomerManagerLinkRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerManagerLinkResponse expectedResponse = new MutateCustomerManagerLinkResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerManagerLink(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerManagerLinkOperation> operations = new List<CustomerManagerLinkOperation>();
            MutateCustomerManagerLinkResponse response = client.MutateCustomerManagerLink(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomerManagerLinkAsync()
        {
            Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(MockBehavior.Strict);
            MutateCustomerManagerLinkRequest expectedRequest = new MutateCustomerManagerLinkRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerManagerLinkResponse expectedResponse = new MutateCustomerManagerLinkResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerManagerLinkAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomerManagerLinkResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerManagerLinkOperation> operations = new List<CustomerManagerLinkOperation>();
            MutateCustomerManagerLinkResponse response = await client.MutateCustomerManagerLinkAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerManagerLink2()
        {
            Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(MockBehavior.Strict);
            MutateCustomerManagerLinkRequest request = new MutateCustomerManagerLinkRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerManagerLinkResponse expectedResponse = new MutateCustomerManagerLinkResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerManagerLink(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerManagerLinkResponse response = client.MutateCustomerManagerLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomerManagerLinkAsync2()
        {
            Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(MockBehavior.Strict);
            MutateCustomerManagerLinkRequest request = new MutateCustomerManagerLinkRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerManagerLinkResponse expectedResponse = new MutateCustomerManagerLinkResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerManagerLinkAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomerManagerLinkResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerManagerLinkResponse response = await client.MutateCustomerManagerLinkAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MoveManagerLink()
        {
            Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(MockBehavior.Strict);
            MoveManagerLinkRequest expectedRequest = new MoveManagerLinkRequest
            {
                CustomerId = "customerId-1772061412",
                PreviousCustomerManagerLink = "previousCustomerManagerLink-1454597947",
                NewManager = "newManager90619918",
            };
            MoveManagerLinkResponse expectedResponse = new MoveManagerLinkResponse
            {
                ResourceName = "resourceName979421212",
            };
            mockGrpcClient.Setup(x => x.MoveManagerLink(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            string previousCustomerManagerLink = "previousCustomerManagerLink-1454597947";
            string newManager = "newManager90619918";
            MoveManagerLinkResponse response = client.MoveManagerLink(customerId, previousCustomerManagerLink, newManager);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MoveManagerLinkAsync()
        {
            Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(MockBehavior.Strict);
            MoveManagerLinkRequest expectedRequest = new MoveManagerLinkRequest
            {
                CustomerId = "customerId-1772061412",
                PreviousCustomerManagerLink = "previousCustomerManagerLink-1454597947",
                NewManager = "newManager90619918",
            };
            MoveManagerLinkResponse expectedResponse = new MoveManagerLinkResponse
            {
                ResourceName = "resourceName979421212",
            };
            mockGrpcClient.Setup(x => x.MoveManagerLinkAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MoveManagerLinkResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            string previousCustomerManagerLink = "previousCustomerManagerLink-1454597947";
            string newManager = "newManager90619918";
            MoveManagerLinkResponse response = await client.MoveManagerLinkAsync(customerId, previousCustomerManagerLink, newManager);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MoveManagerLink2()
        {
            Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(MockBehavior.Strict);
            MoveManagerLinkRequest request = new MoveManagerLinkRequest
            {
                CustomerId = "customerId-1772061412",
                PreviousCustomerManagerLink = "previousCustomerManagerLink-1454597947",
                NewManager = "newManager90619918",
            };
            MoveManagerLinkResponse expectedResponse = new MoveManagerLinkResponse
            {
                ResourceName = "resourceName979421212",
            };
            mockGrpcClient.Setup(x => x.MoveManagerLink(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            MoveManagerLinkResponse response = client.MoveManagerLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MoveManagerLinkAsync2()
        {
            Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(MockBehavior.Strict);
            MoveManagerLinkRequest request = new MoveManagerLinkRequest
            {
                CustomerId = "customerId-1772061412",
                PreviousCustomerManagerLink = "previousCustomerManagerLink-1454597947",
                NewManager = "newManager90619918",
            };
            MoveManagerLinkResponse expectedResponse = new MoveManagerLinkResponse
            {
                ResourceName = "resourceName979421212",
            };
            mockGrpcClient.Setup(x => x.MoveManagerLinkAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MoveManagerLinkResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            MoveManagerLinkResponse response = await client.MoveManagerLinkAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

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
    public class GeneratedCustomerServiceClientTest
    {
        [Test]
        public void GetCustomer()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            GetCustomerRequest expectedRequest = new GetCustomerRequest
            {
                ResourceName = new CustomerName("[CUSTOMER]").ToString(),
            };
            Customer expectedResponse = new Customer
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomer(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerName("[CUSTOMER]").ToString();
            Customer response = client.GetCustomer(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerAsync()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            GetCustomerRequest expectedRequest = new GetCustomerRequest
            {
                ResourceName = new CustomerName("[CUSTOMER]").ToString(),
            };
            Customer expectedResponse = new Customer
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Customer>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerName("[CUSTOMER]").ToString();
            Customer response = await client.GetCustomerAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCustomer2()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            GetCustomerRequest request = new GetCustomerRequest
            {
                ResourceName = new CustomerName("[CUSTOMER]").ToString(),
            };
            Customer expectedResponse = new Customer
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomer(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            Customer response = client.GetCustomer(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerAsync2()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            GetCustomerRequest request = new GetCustomerRequest
            {
                ResourceName = new CustomerName("[CUSTOMER]").ToString(),
            };
            Customer expectedResponse = new Customer
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Customer>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            Customer response = await client.GetCustomerAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomer()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            MutateCustomerRequest expectedRequest = new MutateCustomerRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new CustomerOperation(),
                ValidateOnly = false,
            };
            MutateCustomerResponse expectedResponse = new MutateCustomerResponse();
            mockGrpcClient.Setup(x => x.MutateCustomer(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            CustomerOperation operation = new CustomerOperation();
            bool validateOnly = false;
            MutateCustomerResponse response = client.MutateCustomer(customerId, operation, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomerAsync()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            MutateCustomerRequest expectedRequest = new MutateCustomerRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new CustomerOperation(),
                ValidateOnly = false,
            };
            MutateCustomerResponse expectedResponse = new MutateCustomerResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomerResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            CustomerOperation operation = new CustomerOperation();
            bool validateOnly = false;
            MutateCustomerResponse response = await client.MutateCustomerAsync(customerId, operation, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomer2()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            MutateCustomerRequest expectedRequest = new MutateCustomerRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new CustomerOperation(),
            };
            MutateCustomerResponse expectedResponse = new MutateCustomerResponse();
            mockGrpcClient.Setup(x => x.MutateCustomer(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            CustomerOperation operation = new CustomerOperation();
            MutateCustomerResponse response = client.MutateCustomer(customerId, operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomerAsync2()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            MutateCustomerRequest expectedRequest = new MutateCustomerRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new CustomerOperation(),
            };
            MutateCustomerResponse expectedResponse = new MutateCustomerResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomerResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            CustomerOperation operation = new CustomerOperation();
            MutateCustomerResponse response = await client.MutateCustomerAsync(customerId, operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomer3()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            MutateCustomerRequest request = new MutateCustomerRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new CustomerOperation(),
            };
            MutateCustomerResponse expectedResponse = new MutateCustomerResponse();
            mockGrpcClient.Setup(x => x.MutateCustomer(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerResponse response = client.MutateCustomer(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomerAsync3()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            MutateCustomerRequest request = new MutateCustomerRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new CustomerOperation(),
            };
            MutateCustomerResponse expectedResponse = new MutateCustomerResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomerResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerResponse response = await client.MutateCustomerAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void ListAccessibleCustomers()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            ListAccessibleCustomersRequest request = new ListAccessibleCustomersRequest();
            ListAccessibleCustomersResponse expectedResponse = new ListAccessibleCustomersResponse();
            mockGrpcClient.Setup(x => x.ListAccessibleCustomers(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            ListAccessibleCustomersResponse response = client.ListAccessibleCustomers(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task ListAccessibleCustomersAsync()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            ListAccessibleCustomersRequest request = new ListAccessibleCustomersRequest();
            ListAccessibleCustomersResponse expectedResponse = new ListAccessibleCustomersResponse();
            mockGrpcClient.Setup(x => x.ListAccessibleCustomersAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListAccessibleCustomersResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            ListAccessibleCustomersResponse response = await client.ListAccessibleCustomersAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void CreateCustomerClient()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            CreateCustomerClientRequest expectedRequest = new CreateCustomerClientRequest
            {
                CustomerId = "customerId-1772061412",
                CustomerClient = new Customer(),
            };
            CreateCustomerClientResponse expectedResponse = new CreateCustomerClientResponse
            {
                ResourceName = "resourceName979421212",
            };
            mockGrpcClient.Setup(x => x.CreateCustomerClient(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            Customer customerClient = new Customer();
            CreateCustomerClientResponse response = client.CreateCustomerClient(customerId, customerClient);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task CreateCustomerClientAsync()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            CreateCustomerClientRequest expectedRequest = new CreateCustomerClientRequest
            {
                CustomerId = "customerId-1772061412",
                CustomerClient = new Customer(),
            };
            CreateCustomerClientResponse expectedResponse = new CreateCustomerClientResponse
            {
                ResourceName = "resourceName979421212",
            };
            mockGrpcClient.Setup(x => x.CreateCustomerClientAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CreateCustomerClientResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            Customer customerClient = new Customer();
            CreateCustomerClientResponse response = await client.CreateCustomerClientAsync(customerId, customerClient);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void CreateCustomerClient2()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            CreateCustomerClientRequest request = new CreateCustomerClientRequest
            {
                CustomerId = "customerId-1772061412",
                CustomerClient = new Customer(),
            };
            CreateCustomerClientResponse expectedResponse = new CreateCustomerClientResponse
            {
                ResourceName = "resourceName979421212",
            };
            mockGrpcClient.Setup(x => x.CreateCustomerClient(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            CreateCustomerClientResponse response = client.CreateCustomerClient(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task CreateCustomerClientAsync2()
        {
            Mock<CustomerService.CustomerServiceClient> mockGrpcClient = new Mock<CustomerService.CustomerServiceClient>(MockBehavior.Strict);
            CreateCustomerClientRequest request = new CreateCustomerClientRequest
            {
                CustomerId = "customerId-1772061412",
                CustomerClient = new Customer(),
            };
            CreateCustomerClientResponse expectedResponse = new CreateCustomerClientResponse
            {
                ResourceName = "resourceName979421212",
            };
            mockGrpcClient.Setup(x => x.CreateCustomerClientAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CreateCustomerClientResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerServiceClient client = new CustomerServiceClientImpl(mockGrpcClient.Object, null);
            CreateCustomerClientResponse response = await client.CreateCustomerClientAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

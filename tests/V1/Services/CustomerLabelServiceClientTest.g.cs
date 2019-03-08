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
    public class GeneratedCustomerLabelServiceClientTest
    {
        [Test]
        public void GetCustomerLabel()
        {
            Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new Mock<CustomerLabelService.CustomerLabelServiceClient>(MockBehavior.Strict);
            GetCustomerLabelRequest expectedRequest = new GetCustomerLabelRequest
            {
                ResourceName = new CustomerLabelName("[CUSTOMER]", "[CUSTOMER_LABEL]").ToString(),
            };
            CustomerLabel expectedResponse = new CustomerLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerLabel(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerLabelName("[CUSTOMER]", "[CUSTOMER_LABEL]").ToString();
            CustomerLabel response = client.GetCustomerLabel(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerLabelAsync()
        {
            Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new Mock<CustomerLabelService.CustomerLabelServiceClient>(MockBehavior.Strict);
            GetCustomerLabelRequest expectedRequest = new GetCustomerLabelRequest
            {
                ResourceName = new CustomerLabelName("[CUSTOMER]", "[CUSTOMER_LABEL]").ToString(),
            };
            CustomerLabel expectedResponse = new CustomerLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerLabelAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CustomerLabel>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerLabelName("[CUSTOMER]", "[CUSTOMER_LABEL]").ToString();
            CustomerLabel response = await client.GetCustomerLabelAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCustomerLabel2()
        {
            Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new Mock<CustomerLabelService.CustomerLabelServiceClient>(MockBehavior.Strict);
            GetCustomerLabelRequest request = new GetCustomerLabelRequest
            {
                ResourceName = new CustomerLabelName("[CUSTOMER]", "[CUSTOMER_LABEL]").ToString(),
            };
            CustomerLabel expectedResponse = new CustomerLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerLabel(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            CustomerLabel response = client.GetCustomerLabel(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerLabelAsync2()
        {
            Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new Mock<CustomerLabelService.CustomerLabelServiceClient>(MockBehavior.Strict);
            GetCustomerLabelRequest request = new GetCustomerLabelRequest
            {
                ResourceName = new CustomerLabelName("[CUSTOMER]", "[CUSTOMER_LABEL]").ToString(),
            };
            CustomerLabel expectedResponse = new CustomerLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerLabelAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CustomerLabel>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            CustomerLabel response = await client.GetCustomerLabelAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerLabels()
        {
            Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new Mock<CustomerLabelService.CustomerLabelServiceClient>(MockBehavior.Strict);
            MutateCustomerLabelsRequest expectedRequest = new MutateCustomerLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCustomerLabelsResponse expectedResponse = new MutateCustomerLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerLabels(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerLabelOperation> operations = new List<CustomerLabelOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCustomerLabelsResponse response = client.MutateCustomerLabels(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomerLabelsAsync()
        {
            Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new Mock<CustomerLabelService.CustomerLabelServiceClient>(MockBehavior.Strict);
            MutateCustomerLabelsRequest expectedRequest = new MutateCustomerLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCustomerLabelsResponse expectedResponse = new MutateCustomerLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerLabelsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomerLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerLabelOperation> operations = new List<CustomerLabelOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCustomerLabelsResponse response = await client.MutateCustomerLabelsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerLabels2()
        {
            Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new Mock<CustomerLabelService.CustomerLabelServiceClient>(MockBehavior.Strict);
            MutateCustomerLabelsRequest expectedRequest = new MutateCustomerLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerLabelsResponse expectedResponse = new MutateCustomerLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerLabels(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerLabelOperation> operations = new List<CustomerLabelOperation>();
            MutateCustomerLabelsResponse response = client.MutateCustomerLabels(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomerLabelsAsync2()
        {
            Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new Mock<CustomerLabelService.CustomerLabelServiceClient>(MockBehavior.Strict);
            MutateCustomerLabelsRequest expectedRequest = new MutateCustomerLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerLabelsResponse expectedResponse = new MutateCustomerLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerLabelsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomerLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerLabelOperation> operations = new List<CustomerLabelOperation>();
            MutateCustomerLabelsResponse response = await client.MutateCustomerLabelsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerLabels3()
        {
            Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new Mock<CustomerLabelService.CustomerLabelServiceClient>(MockBehavior.Strict);
            MutateCustomerLabelsRequest request = new MutateCustomerLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerLabelsResponse expectedResponse = new MutateCustomerLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerLabels(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerLabelsResponse response = client.MutateCustomerLabels(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomerLabelsAsync3()
        {
            Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new Mock<CustomerLabelService.CustomerLabelServiceClient>(MockBehavior.Strict);
            MutateCustomerLabelsRequest request = new MutateCustomerLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerLabelsResponse expectedResponse = new MutateCustomerLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerLabelsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomerLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerLabelsResponse response = await client.MutateCustomerLabelsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

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
    public class GeneratedCustomerNegativeCriterionServiceClientTest
    {
        [Test]
        public void GetCustomerNegativeCriterion()
        {
            Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(MockBehavior.Strict);
            GetCustomerNegativeCriterionRequest expectedRequest = new GetCustomerNegativeCriterionRequest
            {
                ResourceName = new CustomerNegativeCriteriaName("[CUSTOMER]", "[CUSTOMER_NEGATIVE_CRITERIA]").ToString(),
            };
            CustomerNegativeCriterion expectedResponse = new CustomerNegativeCriterion
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerNegativeCriterion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerNegativeCriteriaName("[CUSTOMER]", "[CUSTOMER_NEGATIVE_CRITERIA]").ToString();
            CustomerNegativeCriterion response = client.GetCustomerNegativeCriterion(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerNegativeCriterionAsync()
        {
            Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(MockBehavior.Strict);
            GetCustomerNegativeCriterionRequest expectedRequest = new GetCustomerNegativeCriterionRequest
            {
                ResourceName = new CustomerNegativeCriteriaName("[CUSTOMER]", "[CUSTOMER_NEGATIVE_CRITERIA]").ToString(),
            };
            CustomerNegativeCriterion expectedResponse = new CustomerNegativeCriterion
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerNegativeCriterionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CustomerNegativeCriterion>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerNegativeCriteriaName("[CUSTOMER]", "[CUSTOMER_NEGATIVE_CRITERIA]").ToString();
            CustomerNegativeCriterion response = await client.GetCustomerNegativeCriterionAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCustomerNegativeCriterion2()
        {
            Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(MockBehavior.Strict);
            GetCustomerNegativeCriterionRequest request = new GetCustomerNegativeCriterionRequest
            {
                ResourceName = new CustomerNegativeCriteriaName("[CUSTOMER]", "[CUSTOMER_NEGATIVE_CRITERIA]").ToString(),
            };
            CustomerNegativeCriterion expectedResponse = new CustomerNegativeCriterion
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerNegativeCriterion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            CustomerNegativeCriterion response = client.GetCustomerNegativeCriterion(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerNegativeCriterionAsync2()
        {
            Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(MockBehavior.Strict);
            GetCustomerNegativeCriterionRequest request = new GetCustomerNegativeCriterionRequest
            {
                ResourceName = new CustomerNegativeCriteriaName("[CUSTOMER]", "[CUSTOMER_NEGATIVE_CRITERIA]").ToString(),
            };
            CustomerNegativeCriterion expectedResponse = new CustomerNegativeCriterion
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerNegativeCriterionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CustomerNegativeCriterion>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            CustomerNegativeCriterion response = await client.GetCustomerNegativeCriterionAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerNegativeCriteria()
        {
            Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(MockBehavior.Strict);
            MutateCustomerNegativeCriteriaRequest expectedRequest = new MutateCustomerNegativeCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCustomerNegativeCriteriaResponse expectedResponse = new MutateCustomerNegativeCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerNegativeCriteria(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerNegativeCriterionOperation> operations = new List<CustomerNegativeCriterionOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCustomerNegativeCriteriaResponse response = client.MutateCustomerNegativeCriteria(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomerNegativeCriteriaAsync()
        {
            Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(MockBehavior.Strict);
            MutateCustomerNegativeCriteriaRequest expectedRequest = new MutateCustomerNegativeCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCustomerNegativeCriteriaResponse expectedResponse = new MutateCustomerNegativeCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerNegativeCriteriaAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomerNegativeCriteriaResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerNegativeCriterionOperation> operations = new List<CustomerNegativeCriterionOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCustomerNegativeCriteriaResponse response = await client.MutateCustomerNegativeCriteriaAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerNegativeCriteria2()
        {
            Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(MockBehavior.Strict);
            MutateCustomerNegativeCriteriaRequest expectedRequest = new MutateCustomerNegativeCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerNegativeCriteriaResponse expectedResponse = new MutateCustomerNegativeCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerNegativeCriteria(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerNegativeCriterionOperation> operations = new List<CustomerNegativeCriterionOperation>();
            MutateCustomerNegativeCriteriaResponse response = client.MutateCustomerNegativeCriteria(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomerNegativeCriteriaAsync2()
        {
            Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(MockBehavior.Strict);
            MutateCustomerNegativeCriteriaRequest expectedRequest = new MutateCustomerNegativeCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerNegativeCriteriaResponse expectedResponse = new MutateCustomerNegativeCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerNegativeCriteriaAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomerNegativeCriteriaResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerNegativeCriterionOperation> operations = new List<CustomerNegativeCriterionOperation>();
            MutateCustomerNegativeCriteriaResponse response = await client.MutateCustomerNegativeCriteriaAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerNegativeCriteria3()
        {
            Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(MockBehavior.Strict);
            MutateCustomerNegativeCriteriaRequest request = new MutateCustomerNegativeCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerNegativeCriteriaResponse expectedResponse = new MutateCustomerNegativeCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerNegativeCriteria(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerNegativeCriteriaResponse response = client.MutateCustomerNegativeCriteria(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomerNegativeCriteriaAsync3()
        {
            Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(MockBehavior.Strict);
            MutateCustomerNegativeCriteriaRequest request = new MutateCustomerNegativeCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerNegativeCriteriaResponse expectedResponse = new MutateCustomerNegativeCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerNegativeCriteriaAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomerNegativeCriteriaResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerNegativeCriteriaResponse response = await client.MutateCustomerNegativeCriteriaAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

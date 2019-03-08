// Copyright 2018 Google LLC
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

// TODO( b/119694056): Removed Comment

namespace Google.Ads.GoogleAds.V0.Services.Tests
{
    using Google.Ads.GoogleAds.V0.Resources;
    using apis = Google.Ads.GoogleAds.V0.Services;
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
    public class GeneratedCustomerClientServiceClientTest
    {
        [Test]
        public void GetCustomerClient()
        {
            Mock<CustomerClientService.CustomerClientServiceClient> mockGrpcClient = new Mock<CustomerClientService.CustomerClientServiceClient>(MockBehavior.Strict);
            GetCustomerClientRequest expectedRequest = new GetCustomerClientRequest
            {
                ResourceName = new CustomerClientName("[CUSTOMER]", "[CUSTOMER_CLIENT]").ToString(),
            };
            CustomerClient expectedResponse = new CustomerClient
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerClient(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerClientServiceClient client = new CustomerClientServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerClientName("[CUSTOMER]", "[CUSTOMER_CLIENT]").ToString();
            CustomerClient response = client.GetCustomerClient(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerClientAsync()
        {
            Mock<CustomerClientService.CustomerClientServiceClient> mockGrpcClient = new Mock<CustomerClientService.CustomerClientServiceClient>(MockBehavior.Strict);
            GetCustomerClientRequest expectedRequest = new GetCustomerClientRequest
            {
                ResourceName = new CustomerClientName("[CUSTOMER]", "[CUSTOMER_CLIENT]").ToString(),
            };
            CustomerClient expectedResponse = new CustomerClient
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerClientAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CustomerClient>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerClientServiceClient client = new CustomerClientServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerClientName("[CUSTOMER]", "[CUSTOMER_CLIENT]").ToString();
            CustomerClient response = await client.GetCustomerClientAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCustomerClient2()
        {
            Mock<CustomerClientService.CustomerClientServiceClient> mockGrpcClient = new Mock<CustomerClientService.CustomerClientServiceClient>(MockBehavior.Strict);
            GetCustomerClientRequest request = new GetCustomerClientRequest
            {
                ResourceName = new CustomerClientName("[CUSTOMER]", "[CUSTOMER_CLIENT]").ToString(),
            };
            CustomerClient expectedResponse = new CustomerClient
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerClient(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerClientServiceClient client = new CustomerClientServiceClientImpl(mockGrpcClient.Object, null);
            CustomerClient response = client.GetCustomerClient(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerClientAsync2()
        {
            Mock<CustomerClientService.CustomerClientServiceClient> mockGrpcClient = new Mock<CustomerClientService.CustomerClientServiceClient>(MockBehavior.Strict);
            GetCustomerClientRequest request = new GetCustomerClientRequest
            {
                ResourceName = new CustomerClientName("[CUSTOMER]", "[CUSTOMER_CLIENT]").ToString(),
            };
            CustomerClient expectedResponse = new CustomerClient
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerClientAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CustomerClient>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerClientServiceClient client = new CustomerClientServiceClientImpl(mockGrpcClient.Object, null);
            CustomerClient response = await client.GetCustomerClientAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

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

    }
}

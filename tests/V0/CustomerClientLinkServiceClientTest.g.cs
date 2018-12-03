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
    public class GeneratedCustomerClientLinkServiceClientTest
    {
        [Test]
        public void GetCustomerClientLink()
        {
            Mock<CustomerClientLinkService.CustomerClientLinkServiceClient> mockGrpcClient = new Mock<CustomerClientLinkService.CustomerClientLinkServiceClient>(MockBehavior.Strict);
            GetCustomerClientLinkRequest expectedRequest = new GetCustomerClientLinkRequest
            {
                ResourceName = new CustomerClientLinkName("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]").ToString(),
            };
            CustomerClientLink expectedResponse = new CustomerClientLink
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerClientLink(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerClientLinkName("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]").ToString();
            CustomerClientLink response = client.GetCustomerClientLink(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerClientLinkAsync()
        {
            Mock<CustomerClientLinkService.CustomerClientLinkServiceClient> mockGrpcClient = new Mock<CustomerClientLinkService.CustomerClientLinkServiceClient>(MockBehavior.Strict);
            GetCustomerClientLinkRequest expectedRequest = new GetCustomerClientLinkRequest
            {
                ResourceName = new CustomerClientLinkName("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]").ToString(),
            };
            CustomerClientLink expectedResponse = new CustomerClientLink
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerClientLinkAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CustomerClientLink>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerClientLinkName("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]").ToString();
            CustomerClientLink response = await client.GetCustomerClientLinkAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCustomerClientLink2()
        {
            Mock<CustomerClientLinkService.CustomerClientLinkServiceClient> mockGrpcClient = new Mock<CustomerClientLinkService.CustomerClientLinkServiceClient>(MockBehavior.Strict);
            GetCustomerClientLinkRequest request = new GetCustomerClientLinkRequest
            {
                ResourceName = new CustomerClientLinkName("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]").ToString(),
            };
            CustomerClientLink expectedResponse = new CustomerClientLink
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerClientLink(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null);
            CustomerClientLink response = client.GetCustomerClientLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerClientLinkAsync2()
        {
            Mock<CustomerClientLinkService.CustomerClientLinkServiceClient> mockGrpcClient = new Mock<CustomerClientLinkService.CustomerClientLinkServiceClient>(MockBehavior.Strict);
            GetCustomerClientLinkRequest request = new GetCustomerClientLinkRequest
            {
                ResourceName = new CustomerClientLinkName("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]").ToString(),
            };
            CustomerClientLink expectedResponse = new CustomerClientLink
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerClientLinkAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CustomerClientLink>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null);
            CustomerClientLink response = await client.GetCustomerClientLinkAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

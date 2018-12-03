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
    public class GeneratedPaymentsAccountServiceClientTest
    {
        [Test]
        public void ListPaymentsAccounts()
        {
            Mock<PaymentsAccountService.PaymentsAccountServiceClient> mockGrpcClient = new Mock<PaymentsAccountService.PaymentsAccountServiceClient>(MockBehavior.Strict);
            ListPaymentsAccountsRequest expectedRequest = new ListPaymentsAccountsRequest
            {
                CustomerId = "customerId-1772061412",
            };
            ListPaymentsAccountsResponse expectedResponse = new ListPaymentsAccountsResponse();
            mockGrpcClient.Setup(x => x.ListPaymentsAccounts(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            PaymentsAccountServiceClient client = new PaymentsAccountServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            ListPaymentsAccountsResponse response = client.ListPaymentsAccounts(customerId);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task ListPaymentsAccountsAsync()
        {
            Mock<PaymentsAccountService.PaymentsAccountServiceClient> mockGrpcClient = new Mock<PaymentsAccountService.PaymentsAccountServiceClient>(MockBehavior.Strict);
            ListPaymentsAccountsRequest expectedRequest = new ListPaymentsAccountsRequest
            {
                CustomerId = "customerId-1772061412",
            };
            ListPaymentsAccountsResponse expectedResponse = new ListPaymentsAccountsResponse();
            mockGrpcClient.Setup(x => x.ListPaymentsAccountsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListPaymentsAccountsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            PaymentsAccountServiceClient client = new PaymentsAccountServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            ListPaymentsAccountsResponse response = await client.ListPaymentsAccountsAsync(customerId);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void ListPaymentsAccounts2()
        {
            Mock<PaymentsAccountService.PaymentsAccountServiceClient> mockGrpcClient = new Mock<PaymentsAccountService.PaymentsAccountServiceClient>(MockBehavior.Strict);
            ListPaymentsAccountsRequest request = new ListPaymentsAccountsRequest
            {
                CustomerId = "customerId-1772061412",
            };
            ListPaymentsAccountsResponse expectedResponse = new ListPaymentsAccountsResponse();
            mockGrpcClient.Setup(x => x.ListPaymentsAccounts(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            PaymentsAccountServiceClient client = new PaymentsAccountServiceClientImpl(mockGrpcClient.Object, null);
            ListPaymentsAccountsResponse response = client.ListPaymentsAccounts(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task ListPaymentsAccountsAsync2()
        {
            Mock<PaymentsAccountService.PaymentsAccountServiceClient> mockGrpcClient = new Mock<PaymentsAccountService.PaymentsAccountServiceClient>(MockBehavior.Strict);
            ListPaymentsAccountsRequest request = new ListPaymentsAccountsRequest
            {
                CustomerId = "customerId-1772061412",
            };
            ListPaymentsAccountsResponse expectedResponse = new ListPaymentsAccountsResponse();
            mockGrpcClient.Setup(x => x.ListPaymentsAccountsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListPaymentsAccountsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            PaymentsAccountServiceClient client = new PaymentsAccountServiceClientImpl(mockGrpcClient.Object, null);
            ListPaymentsAccountsResponse response = await client.ListPaymentsAccountsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

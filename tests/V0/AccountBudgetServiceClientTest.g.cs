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

// Generated code. DO NOT EDIT!

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
    public class GeneratedAccountBudgetServiceClientTest
    {
        [Test]
        public void GetAccountBudget()
        {
            Mock<AccountBudgetService.AccountBudgetServiceClient> mockGrpcClient = new Mock<AccountBudgetService.AccountBudgetServiceClient>(MockBehavior.Strict);
            GetAccountBudgetRequest expectedRequest = new GetAccountBudgetRequest
            {
                ResourceName = new AccountBudgetName("[CUSTOMER]", "[ACCOUNT_BUDGET]").ToString(),
            };
            AccountBudget expectedResponse = new AccountBudget
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAccountBudget(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AccountBudgetServiceClient client = new AccountBudgetServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AccountBudgetName("[CUSTOMER]", "[ACCOUNT_BUDGET]").ToString();
            AccountBudget response = client.GetAccountBudget(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAccountBudgetAsync()
        {
            Mock<AccountBudgetService.AccountBudgetServiceClient> mockGrpcClient = new Mock<AccountBudgetService.AccountBudgetServiceClient>(MockBehavior.Strict);
            GetAccountBudgetRequest expectedRequest = new GetAccountBudgetRequest
            {
                ResourceName = new AccountBudgetName("[CUSTOMER]", "[ACCOUNT_BUDGET]").ToString(),
            };
            AccountBudget expectedResponse = new AccountBudget
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAccountBudgetAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AccountBudget>(Task.FromResult(expectedResponse), null, null, null, null));
            AccountBudgetServiceClient client = new AccountBudgetServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AccountBudgetName("[CUSTOMER]", "[ACCOUNT_BUDGET]").ToString();
            AccountBudget response = await client.GetAccountBudgetAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAccountBudget2()
        {
            Mock<AccountBudgetService.AccountBudgetServiceClient> mockGrpcClient = new Mock<AccountBudgetService.AccountBudgetServiceClient>(MockBehavior.Strict);
            GetAccountBudgetRequest request = new GetAccountBudgetRequest
            {
                ResourceName = new AccountBudgetName("[CUSTOMER]", "[ACCOUNT_BUDGET]").ToString(),
            };
            AccountBudget expectedResponse = new AccountBudget
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAccountBudget(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AccountBudgetServiceClient client = new AccountBudgetServiceClientImpl(mockGrpcClient.Object, null);
            AccountBudget response = client.GetAccountBudget(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAccountBudgetAsync2()
        {
            Mock<AccountBudgetService.AccountBudgetServiceClient> mockGrpcClient = new Mock<AccountBudgetService.AccountBudgetServiceClient>(MockBehavior.Strict);
            GetAccountBudgetRequest request = new GetAccountBudgetRequest
            {
                ResourceName = new AccountBudgetName("[CUSTOMER]", "[ACCOUNT_BUDGET]").ToString(),
            };
            AccountBudget expectedResponse = new AccountBudget
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAccountBudgetAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AccountBudget>(Task.FromResult(expectedResponse), null, null, null, null));
            AccountBudgetServiceClient client = new AccountBudgetServiceClientImpl(mockGrpcClient.Object, null);
            AccountBudget response = await client.GetAccountBudgetAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

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
    public class GeneratedAccountBudgetProposalServiceClientTest
    {
        [Test]
        public void GetAccountBudgetProposal()
        {
            Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(MockBehavior.Strict);
            GetAccountBudgetProposalRequest expectedRequest = new GetAccountBudgetProposalRequest
            {
                ResourceName = new AccountBudgetProposalName("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]").ToString(),
            };
            AccountBudgetProposal expectedResponse = new AccountBudgetProposal
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAccountBudgetProposal(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AccountBudgetProposalName("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]").ToString();
            AccountBudgetProposal response = client.GetAccountBudgetProposal(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAccountBudgetProposalAsync()
        {
            Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(MockBehavior.Strict);
            GetAccountBudgetProposalRequest expectedRequest = new GetAccountBudgetProposalRequest
            {
                ResourceName = new AccountBudgetProposalName("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]").ToString(),
            };
            AccountBudgetProposal expectedResponse = new AccountBudgetProposal
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAccountBudgetProposalAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AccountBudgetProposal>(Task.FromResult(expectedResponse), null, null, null, null));
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AccountBudgetProposalName("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]").ToString();
            AccountBudgetProposal response = await client.GetAccountBudgetProposalAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAccountBudgetProposal2()
        {
            Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(MockBehavior.Strict);
            GetAccountBudgetProposalRequest request = new GetAccountBudgetProposalRequest
            {
                ResourceName = new AccountBudgetProposalName("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]").ToString(),
            };
            AccountBudgetProposal expectedResponse = new AccountBudgetProposal
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAccountBudgetProposal(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            AccountBudgetProposal response = client.GetAccountBudgetProposal(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAccountBudgetProposalAsync2()
        {
            Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(MockBehavior.Strict);
            GetAccountBudgetProposalRequest request = new GetAccountBudgetProposalRequest
            {
                ResourceName = new AccountBudgetProposalName("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]").ToString(),
            };
            AccountBudgetProposal expectedResponse = new AccountBudgetProposal
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAccountBudgetProposalAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AccountBudgetProposal>(Task.FromResult(expectedResponse), null, null, null, null));
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            AccountBudgetProposal response = await client.GetAccountBudgetProposalAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAccountBudgetProposal()
        {
            Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(MockBehavior.Strict);
            MutateAccountBudgetProposalRequest expectedRequest = new MutateAccountBudgetProposalRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new AccountBudgetProposalOperation(),
                ValidateOnly = false,
            };
            MutateAccountBudgetProposalResponse expectedResponse = new MutateAccountBudgetProposalResponse();
            mockGrpcClient.Setup(x => x.MutateAccountBudgetProposal(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            AccountBudgetProposalOperation operation = new AccountBudgetProposalOperation();
            bool validateOnly = false;
            MutateAccountBudgetProposalResponse response = client.MutateAccountBudgetProposal(customerId, operation, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAccountBudgetProposalAsync()
        {
            Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(MockBehavior.Strict);
            MutateAccountBudgetProposalRequest expectedRequest = new MutateAccountBudgetProposalRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new AccountBudgetProposalOperation(),
                ValidateOnly = false,
            };
            MutateAccountBudgetProposalResponse expectedResponse = new MutateAccountBudgetProposalResponse();
            mockGrpcClient.Setup(x => x.MutateAccountBudgetProposalAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAccountBudgetProposalResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            AccountBudgetProposalOperation operation = new AccountBudgetProposalOperation();
            bool validateOnly = false;
            MutateAccountBudgetProposalResponse response = await client.MutateAccountBudgetProposalAsync(customerId, operation, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAccountBudgetProposal2()
        {
            Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(MockBehavior.Strict);
            MutateAccountBudgetProposalRequest expectedRequest = new MutateAccountBudgetProposalRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new AccountBudgetProposalOperation(),
            };
            MutateAccountBudgetProposalResponse expectedResponse = new MutateAccountBudgetProposalResponse();
            mockGrpcClient.Setup(x => x.MutateAccountBudgetProposal(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            AccountBudgetProposalOperation operation = new AccountBudgetProposalOperation();
            MutateAccountBudgetProposalResponse response = client.MutateAccountBudgetProposal(customerId, operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAccountBudgetProposalAsync2()
        {
            Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(MockBehavior.Strict);
            MutateAccountBudgetProposalRequest expectedRequest = new MutateAccountBudgetProposalRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new AccountBudgetProposalOperation(),
            };
            MutateAccountBudgetProposalResponse expectedResponse = new MutateAccountBudgetProposalResponse();
            mockGrpcClient.Setup(x => x.MutateAccountBudgetProposalAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAccountBudgetProposalResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            AccountBudgetProposalOperation operation = new AccountBudgetProposalOperation();
            MutateAccountBudgetProposalResponse response = await client.MutateAccountBudgetProposalAsync(customerId, operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAccountBudgetProposal3()
        {
            Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(MockBehavior.Strict);
            MutateAccountBudgetProposalRequest request = new MutateAccountBudgetProposalRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new AccountBudgetProposalOperation(),
            };
            MutateAccountBudgetProposalResponse expectedResponse = new MutateAccountBudgetProposalResponse();
            mockGrpcClient.Setup(x => x.MutateAccountBudgetProposal(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            MutateAccountBudgetProposalResponse response = client.MutateAccountBudgetProposal(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAccountBudgetProposalAsync3()
        {
            Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(MockBehavior.Strict);
            MutateAccountBudgetProposalRequest request = new MutateAccountBudgetProposalRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new AccountBudgetProposalOperation(),
            };
            MutateAccountBudgetProposalResponse expectedResponse = new MutateAccountBudgetProposalResponse();
            mockGrpcClient.Setup(x => x.MutateAccountBudgetProposalAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAccountBudgetProposalResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            MutateAccountBudgetProposalResponse response = await client.MutateAccountBudgetProposalAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

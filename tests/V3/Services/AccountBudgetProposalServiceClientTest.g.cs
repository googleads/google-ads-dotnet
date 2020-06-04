// Copyright 2020 Google LLC
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

using gagve = Google.Ads.GoogleAds.V3.Enums;
using gagvr = Google.Ads.GoogleAds.V3.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V3.Services;

namespace Google.Ads.GoogleAds.Tests.V3.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAccountBudgetProposalServiceClientTest
    {
        [Test]
        public void GetAccountBudgetProposalRequestObject()
        {
            moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(moq::MockBehavior.Strict);
            GetAccountBudgetProposalRequest request = new GetAccountBudgetProposalRequest
            {
                ResourceNameAsAccountBudgetProposalName = gagvr::AccountBudgetProposalName.FromCustomerAccountBudgetProposal("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]"),
            };
            gagvr::AccountBudgetProposal expectedResponse = new gagvr::AccountBudgetProposal
            {
                ResourceNameAsAccountBudgetProposalName = gagvr::AccountBudgetProposalName.FromCustomerAccountBudgetProposal("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]"),
                BillingSetupAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                AccountBudgetAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                ProposalType = gagve::AccountBudgetProposalTypeEnum.Types.AccountBudgetProposalType.Remove,
                ProposedName = "proposed_name7d4b2591",
                ProposedStartTimeType = gagve::TimeTypeEnum.Types.TimeType.Unspecified,
                ProposedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                ProposedSpendingLimitMicros = 6806956772888455592L,
                ProposedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                ProposedPurchaseOrderNumber = "proposed_purchase_order_numbere58f9418",
                ProposedNotes = "proposed_notes1d6c3942",
                Id = -6774108720365892680L,
                Status = gagve::AccountBudgetProposalStatusEnum.Types.AccountBudgetProposalStatus.ApprovedHeld,
                CreationDateTime = "creation_date_time2f8c0159",
                ApprovalDateTime = "approval_date_timecefef4db",
                ProposedStartDateTime = "proposed_start_date_time4e2f84a3",
                ProposedEndDateTime = "proposed_end_date_time39aa28a5",
                ApprovedStartDateTime = "approved_start_date_time20090a2c",
                ApprovedEndDateTime = "approved_end_date_time99d3ab5d",
                ApprovedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Forever,
                ApprovedSpendingLimitMicros = 1674109600829643495L,
                ApprovedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetAccountBudgetProposal(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountBudgetProposal response = client.GetAccountBudgetProposal(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAccountBudgetProposalRequestObjectAsync()
        {
            moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(moq::MockBehavior.Strict);
            GetAccountBudgetProposalRequest request = new GetAccountBudgetProposalRequest
            {
                ResourceNameAsAccountBudgetProposalName = gagvr::AccountBudgetProposalName.FromCustomerAccountBudgetProposal("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]"),
            };
            gagvr::AccountBudgetProposal expectedResponse = new gagvr::AccountBudgetProposal
            {
                ResourceNameAsAccountBudgetProposalName = gagvr::AccountBudgetProposalName.FromCustomerAccountBudgetProposal("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]"),
                BillingSetupAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                AccountBudgetAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                ProposalType = gagve::AccountBudgetProposalTypeEnum.Types.AccountBudgetProposalType.Remove,
                ProposedName = "proposed_name7d4b2591",
                ProposedStartTimeType = gagve::TimeTypeEnum.Types.TimeType.Unspecified,
                ProposedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                ProposedSpendingLimitMicros = 6806956772888455592L,
                ProposedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                ProposedPurchaseOrderNumber = "proposed_purchase_order_numbere58f9418",
                ProposedNotes = "proposed_notes1d6c3942",
                Id = -6774108720365892680L,
                Status = gagve::AccountBudgetProposalStatusEnum.Types.AccountBudgetProposalStatus.ApprovedHeld,
                CreationDateTime = "creation_date_time2f8c0159",
                ApprovalDateTime = "approval_date_timecefef4db",
                ProposedStartDateTime = "proposed_start_date_time4e2f84a3",
                ProposedEndDateTime = "proposed_end_date_time39aa28a5",
                ApprovedStartDateTime = "approved_start_date_time20090a2c",
                ApprovedEndDateTime = "approved_end_date_time99d3ab5d",
                ApprovedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Forever,
                ApprovedSpendingLimitMicros = 1674109600829643495L,
                ApprovedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetAccountBudgetProposalAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AccountBudgetProposal>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountBudgetProposal responseCallSettings = await client.GetAccountBudgetProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AccountBudgetProposal responseCancellationToken = await client.GetAccountBudgetProposalAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAccountBudgetProposal()
        {
            moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(moq::MockBehavior.Strict);
            GetAccountBudgetProposalRequest request = new GetAccountBudgetProposalRequest
            {
                ResourceNameAsAccountBudgetProposalName = gagvr::AccountBudgetProposalName.FromCustomerAccountBudgetProposal("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]"),
            };
            gagvr::AccountBudgetProposal expectedResponse = new gagvr::AccountBudgetProposal
            {
                ResourceNameAsAccountBudgetProposalName = gagvr::AccountBudgetProposalName.FromCustomerAccountBudgetProposal("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]"),
                BillingSetupAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                AccountBudgetAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                ProposalType = gagve::AccountBudgetProposalTypeEnum.Types.AccountBudgetProposalType.Remove,
                ProposedName = "proposed_name7d4b2591",
                ProposedStartTimeType = gagve::TimeTypeEnum.Types.TimeType.Unspecified,
                ProposedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                ProposedSpendingLimitMicros = 6806956772888455592L,
                ProposedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                ProposedPurchaseOrderNumber = "proposed_purchase_order_numbere58f9418",
                ProposedNotes = "proposed_notes1d6c3942",
                Id = -6774108720365892680L,
                Status = gagve::AccountBudgetProposalStatusEnum.Types.AccountBudgetProposalStatus.ApprovedHeld,
                CreationDateTime = "creation_date_time2f8c0159",
                ApprovalDateTime = "approval_date_timecefef4db",
                ProposedStartDateTime = "proposed_start_date_time4e2f84a3",
                ProposedEndDateTime = "proposed_end_date_time39aa28a5",
                ApprovedStartDateTime = "approved_start_date_time20090a2c",
                ApprovedEndDateTime = "approved_end_date_time99d3ab5d",
                ApprovedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Forever,
                ApprovedSpendingLimitMicros = 1674109600829643495L,
                ApprovedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetAccountBudgetProposal(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountBudgetProposal response = client.GetAccountBudgetProposal(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAccountBudgetProposalAsync()
        {
            moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(moq::MockBehavior.Strict);
            GetAccountBudgetProposalRequest request = new GetAccountBudgetProposalRequest
            {
                ResourceNameAsAccountBudgetProposalName = gagvr::AccountBudgetProposalName.FromCustomerAccountBudgetProposal("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]"),
            };
            gagvr::AccountBudgetProposal expectedResponse = new gagvr::AccountBudgetProposal
            {
                ResourceNameAsAccountBudgetProposalName = gagvr::AccountBudgetProposalName.FromCustomerAccountBudgetProposal("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]"),
                BillingSetupAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                AccountBudgetAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                ProposalType = gagve::AccountBudgetProposalTypeEnum.Types.AccountBudgetProposalType.Remove,
                ProposedName = "proposed_name7d4b2591",
                ProposedStartTimeType = gagve::TimeTypeEnum.Types.TimeType.Unspecified,
                ProposedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                ProposedSpendingLimitMicros = 6806956772888455592L,
                ProposedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                ProposedPurchaseOrderNumber = "proposed_purchase_order_numbere58f9418",
                ProposedNotes = "proposed_notes1d6c3942",
                Id = -6774108720365892680L,
                Status = gagve::AccountBudgetProposalStatusEnum.Types.AccountBudgetProposalStatus.ApprovedHeld,
                CreationDateTime = "creation_date_time2f8c0159",
                ApprovalDateTime = "approval_date_timecefef4db",
                ProposedStartDateTime = "proposed_start_date_time4e2f84a3",
                ProposedEndDateTime = "proposed_end_date_time39aa28a5",
                ApprovedStartDateTime = "approved_start_date_time20090a2c",
                ApprovedEndDateTime = "approved_end_date_time99d3ab5d",
                ApprovedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Forever,
                ApprovedSpendingLimitMicros = 1674109600829643495L,
                ApprovedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetAccountBudgetProposalAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AccountBudgetProposal>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountBudgetProposal responseCallSettings = await client.GetAccountBudgetProposalAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AccountBudgetProposal responseCancellationToken = await client.GetAccountBudgetProposalAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAccountBudgetProposalResourceNames()
        {
            moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(moq::MockBehavior.Strict);
            GetAccountBudgetProposalRequest request = new GetAccountBudgetProposalRequest
            {
                ResourceNameAsAccountBudgetProposalName = gagvr::AccountBudgetProposalName.FromCustomerAccountBudgetProposal("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]"),
            };
            gagvr::AccountBudgetProposal expectedResponse = new gagvr::AccountBudgetProposal
            {
                ResourceNameAsAccountBudgetProposalName = gagvr::AccountBudgetProposalName.FromCustomerAccountBudgetProposal("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]"),
                BillingSetupAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                AccountBudgetAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                ProposalType = gagve::AccountBudgetProposalTypeEnum.Types.AccountBudgetProposalType.Remove,
                ProposedName = "proposed_name7d4b2591",
                ProposedStartTimeType = gagve::TimeTypeEnum.Types.TimeType.Unspecified,
                ProposedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                ProposedSpendingLimitMicros = 6806956772888455592L,
                ProposedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                ProposedPurchaseOrderNumber = "proposed_purchase_order_numbere58f9418",
                ProposedNotes = "proposed_notes1d6c3942",
                Id = -6774108720365892680L,
                Status = gagve::AccountBudgetProposalStatusEnum.Types.AccountBudgetProposalStatus.ApprovedHeld,
                CreationDateTime = "creation_date_time2f8c0159",
                ApprovalDateTime = "approval_date_timecefef4db",
                ProposedStartDateTime = "proposed_start_date_time4e2f84a3",
                ProposedEndDateTime = "proposed_end_date_time39aa28a5",
                ApprovedStartDateTime = "approved_start_date_time20090a2c",
                ApprovedEndDateTime = "approved_end_date_time99d3ab5d",
                ApprovedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Forever,
                ApprovedSpendingLimitMicros = 1674109600829643495L,
                ApprovedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetAccountBudgetProposal(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountBudgetProposal response = client.GetAccountBudgetProposal(request.ResourceNameAsAccountBudgetProposalName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAccountBudgetProposalResourceNamesAsync()
        {
            moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(moq::MockBehavior.Strict);
            GetAccountBudgetProposalRequest request = new GetAccountBudgetProposalRequest
            {
                ResourceNameAsAccountBudgetProposalName = gagvr::AccountBudgetProposalName.FromCustomerAccountBudgetProposal("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]"),
            };
            gagvr::AccountBudgetProposal expectedResponse = new gagvr::AccountBudgetProposal
            {
                ResourceNameAsAccountBudgetProposalName = gagvr::AccountBudgetProposalName.FromCustomerAccountBudgetProposal("[CUSTOMER]", "[ACCOUNT_BUDGET_PROPOSAL]"),
                BillingSetupAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                AccountBudgetAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                ProposalType = gagve::AccountBudgetProposalTypeEnum.Types.AccountBudgetProposalType.Remove,
                ProposedName = "proposed_name7d4b2591",
                ProposedStartTimeType = gagve::TimeTypeEnum.Types.TimeType.Unspecified,
                ProposedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                ProposedSpendingLimitMicros = 6806956772888455592L,
                ProposedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                ProposedPurchaseOrderNumber = "proposed_purchase_order_numbere58f9418",
                ProposedNotes = "proposed_notes1d6c3942",
                Id = -6774108720365892680L,
                Status = gagve::AccountBudgetProposalStatusEnum.Types.AccountBudgetProposalStatus.ApprovedHeld,
                CreationDateTime = "creation_date_time2f8c0159",
                ApprovalDateTime = "approval_date_timecefef4db",
                ProposedStartDateTime = "proposed_start_date_time4e2f84a3",
                ProposedEndDateTime = "proposed_end_date_time39aa28a5",
                ApprovedStartDateTime = "approved_start_date_time20090a2c",
                ApprovedEndDateTime = "approved_end_date_time99d3ab5d",
                ApprovedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Forever,
                ApprovedSpendingLimitMicros = 1674109600829643495L,
                ApprovedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetAccountBudgetProposalAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AccountBudgetProposal>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountBudgetProposal responseCallSettings = await client.GetAccountBudgetProposalAsync(request.ResourceNameAsAccountBudgetProposalName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AccountBudgetProposal responseCancellationToken = await client.GetAccountBudgetProposalAsync(request.ResourceNameAsAccountBudgetProposalName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAccountBudgetProposalRequestObject()
        {
            moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(moq::MockBehavior.Strict);
            MutateAccountBudgetProposalRequest request = new MutateAccountBudgetProposalRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new AccountBudgetProposalOperation(),
                ValidateOnly = true,
            };
            MutateAccountBudgetProposalResponse expectedResponse = new MutateAccountBudgetProposalResponse
            {
                Result = new MutateAccountBudgetProposalResult(),
            };
            mockGrpcClient.Setup(x => x.MutateAccountBudgetProposal(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            MutateAccountBudgetProposalResponse response = client.MutateAccountBudgetProposal(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateAccountBudgetProposalRequestObjectAsync()
        {
            moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(moq::MockBehavior.Strict);
            MutateAccountBudgetProposalRequest request = new MutateAccountBudgetProposalRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new AccountBudgetProposalOperation(),
                ValidateOnly = true,
            };
            MutateAccountBudgetProposalResponse expectedResponse = new MutateAccountBudgetProposalResponse
            {
                Result = new MutateAccountBudgetProposalResult(),
            };
            mockGrpcClient.Setup(x => x.MutateAccountBudgetProposalAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAccountBudgetProposalResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            MutateAccountBudgetProposalResponse responseCallSettings = await client.MutateAccountBudgetProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAccountBudgetProposalResponse responseCancellationToken = await client.MutateAccountBudgetProposalAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAccountBudgetProposal()
        {
            moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(moq::MockBehavior.Strict);
            MutateAccountBudgetProposalRequest request = new MutateAccountBudgetProposalRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new AccountBudgetProposalOperation(),
            };
            MutateAccountBudgetProposalResponse expectedResponse = new MutateAccountBudgetProposalResponse
            {
                Result = new MutateAccountBudgetProposalResult(),
            };
            mockGrpcClient.Setup(x => x.MutateAccountBudgetProposal(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            MutateAccountBudgetProposalResponse response = client.MutateAccountBudgetProposal(request.CustomerId, request.Operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateAccountBudgetProposalAsync()
        {
            moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient> mockGrpcClient = new moq::Mock<AccountBudgetProposalService.AccountBudgetProposalServiceClient>(moq::MockBehavior.Strict);
            MutateAccountBudgetProposalRequest request = new MutateAccountBudgetProposalRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new AccountBudgetProposalOperation(),
            };
            MutateAccountBudgetProposalResponse expectedResponse = new MutateAccountBudgetProposalResponse
            {
                Result = new MutateAccountBudgetProposalResult(),
            };
            mockGrpcClient.Setup(x => x.MutateAccountBudgetProposalAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAccountBudgetProposalResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccountBudgetProposalServiceClient client = new AccountBudgetProposalServiceClientImpl(mockGrpcClient.Object, null);
            MutateAccountBudgetProposalResponse responseCallSettings = await client.MutateAccountBudgetProposalAsync(request.CustomerId, request.Operation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAccountBudgetProposalResponse responseCancellationToken = await client.MutateAccountBudgetProposalAsync(request.CustomerId, request.Operation, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

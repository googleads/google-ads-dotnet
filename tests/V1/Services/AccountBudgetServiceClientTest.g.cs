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

using gagve = Google.Ads.GoogleAds.V1.Enums;
using gagvr = Google.Ads.GoogleAds.V1.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V1.Services;

namespace Google.Ads.GoogleAds.Tests.V1.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAccountBudgetServiceClientTest
    {
        [Test]
        public void GetAccountBudgetRequestObject()
        {
            moq::Mock<AccountBudgetService.AccountBudgetServiceClient> mockGrpcClient = new moq::Mock<AccountBudgetService.AccountBudgetServiceClient>(moq::MockBehavior.Strict);
            GetAccountBudgetRequest request = new GetAccountBudgetRequest
            {
                ResourceNameAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
            };
            gagvr::AccountBudget expectedResponse = new gagvr::AccountBudget
            {
                ResourceNameAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                Id = -6774108720365892680L,
                BillingSetupAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                Status = gagve::AccountBudgetStatusEnum.Types.AccountBudgetStatus.Cancelled,
                AccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                ProposedStartDateTime = "proposed_start_date_time4e2f84a3",
                ApprovedStartDateTime = "approved_start_date_time20090a2c",
                ProposedEndDateTime = "proposed_end_date_time39aa28a5",
                ProposedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                ApprovedEndDateTime = "approved_end_date_time99d3ab5d",
                ApprovedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Forever,
                ProposedSpendingLimitMicros = 6806956772888455592L,
                ProposedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                ApprovedSpendingLimitMicros = 1674109600829643495L,
                ApprovedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                AdjustedSpendingLimitMicros = 5260592673487875057L,
                AdjustedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unspecified,
                TotalAdjustmentsMicros = -1818058180873398375L,
                AmountServedMicros = -8683779131450697164L,
                PurchaseOrderNumber = "purchase_order_number7be7181f",
                Notes = "notes00b55843",
                PendingProposal = new gagvr::AccountBudget.Types.PendingAccountBudgetProposal(),
            };
            mockGrpcClient.Setup(x => x.GetAccountBudget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccountBudgetServiceClient client = new AccountBudgetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountBudget response = client.GetAccountBudget(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAccountBudgetRequestObjectAsync()
        {
            moq::Mock<AccountBudgetService.AccountBudgetServiceClient> mockGrpcClient = new moq::Mock<AccountBudgetService.AccountBudgetServiceClient>(moq::MockBehavior.Strict);
            GetAccountBudgetRequest request = new GetAccountBudgetRequest
            {
                ResourceNameAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
            };
            gagvr::AccountBudget expectedResponse = new gagvr::AccountBudget
            {
                ResourceNameAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                Id = -6774108720365892680L,
                BillingSetupAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                Status = gagve::AccountBudgetStatusEnum.Types.AccountBudgetStatus.Cancelled,
                AccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                ProposedStartDateTime = "proposed_start_date_time4e2f84a3",
                ApprovedStartDateTime = "approved_start_date_time20090a2c",
                ProposedEndDateTime = "proposed_end_date_time39aa28a5",
                ProposedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                ApprovedEndDateTime = "approved_end_date_time99d3ab5d",
                ApprovedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Forever,
                ProposedSpendingLimitMicros = 6806956772888455592L,
                ProposedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                ApprovedSpendingLimitMicros = 1674109600829643495L,
                ApprovedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                AdjustedSpendingLimitMicros = 5260592673487875057L,
                AdjustedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unspecified,
                TotalAdjustmentsMicros = -1818058180873398375L,
                AmountServedMicros = -8683779131450697164L,
                PurchaseOrderNumber = "purchase_order_number7be7181f",
                Notes = "notes00b55843",
                PendingProposal = new gagvr::AccountBudget.Types.PendingAccountBudgetProposal(),
            };
            mockGrpcClient.Setup(x => x.GetAccountBudgetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AccountBudget>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccountBudgetServiceClient client = new AccountBudgetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountBudget responseCallSettings = await client.GetAccountBudgetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AccountBudget responseCancellationToken = await client.GetAccountBudgetAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAccountBudget()
        {
            moq::Mock<AccountBudgetService.AccountBudgetServiceClient> mockGrpcClient = new moq::Mock<AccountBudgetService.AccountBudgetServiceClient>(moq::MockBehavior.Strict);
            GetAccountBudgetRequest request = new GetAccountBudgetRequest
            {
                ResourceNameAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
            };
            gagvr::AccountBudget expectedResponse = new gagvr::AccountBudget
            {
                ResourceNameAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                Id = -6774108720365892680L,
                BillingSetupAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                Status = gagve::AccountBudgetStatusEnum.Types.AccountBudgetStatus.Cancelled,
                AccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                ProposedStartDateTime = "proposed_start_date_time4e2f84a3",
                ApprovedStartDateTime = "approved_start_date_time20090a2c",
                ProposedEndDateTime = "proposed_end_date_time39aa28a5",
                ProposedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                ApprovedEndDateTime = "approved_end_date_time99d3ab5d",
                ApprovedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Forever,
                ProposedSpendingLimitMicros = 6806956772888455592L,
                ProposedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                ApprovedSpendingLimitMicros = 1674109600829643495L,
                ApprovedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                AdjustedSpendingLimitMicros = 5260592673487875057L,
                AdjustedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unspecified,
                TotalAdjustmentsMicros = -1818058180873398375L,
                AmountServedMicros = -8683779131450697164L,
                PurchaseOrderNumber = "purchase_order_number7be7181f",
                Notes = "notes00b55843",
                PendingProposal = new gagvr::AccountBudget.Types.PendingAccountBudgetProposal(),
            };
            mockGrpcClient.Setup(x => x.GetAccountBudget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccountBudgetServiceClient client = new AccountBudgetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountBudget response = client.GetAccountBudget(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAccountBudgetAsync()
        {
            moq::Mock<AccountBudgetService.AccountBudgetServiceClient> mockGrpcClient = new moq::Mock<AccountBudgetService.AccountBudgetServiceClient>(moq::MockBehavior.Strict);
            GetAccountBudgetRequest request = new GetAccountBudgetRequest
            {
                ResourceNameAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
            };
            gagvr::AccountBudget expectedResponse = new gagvr::AccountBudget
            {
                ResourceNameAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                Id = -6774108720365892680L,
                BillingSetupAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                Status = gagve::AccountBudgetStatusEnum.Types.AccountBudgetStatus.Cancelled,
                AccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                ProposedStartDateTime = "proposed_start_date_time4e2f84a3",
                ApprovedStartDateTime = "approved_start_date_time20090a2c",
                ProposedEndDateTime = "proposed_end_date_time39aa28a5",
                ProposedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                ApprovedEndDateTime = "approved_end_date_time99d3ab5d",
                ApprovedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Forever,
                ProposedSpendingLimitMicros = 6806956772888455592L,
                ProposedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                ApprovedSpendingLimitMicros = 1674109600829643495L,
                ApprovedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                AdjustedSpendingLimitMicros = 5260592673487875057L,
                AdjustedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unspecified,
                TotalAdjustmentsMicros = -1818058180873398375L,
                AmountServedMicros = -8683779131450697164L,
                PurchaseOrderNumber = "purchase_order_number7be7181f",
                Notes = "notes00b55843",
                PendingProposal = new gagvr::AccountBudget.Types.PendingAccountBudgetProposal(),
            };
            mockGrpcClient.Setup(x => x.GetAccountBudgetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AccountBudget>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccountBudgetServiceClient client = new AccountBudgetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountBudget responseCallSettings = await client.GetAccountBudgetAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AccountBudget responseCancellationToken = await client.GetAccountBudgetAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAccountBudgetResourceNames()
        {
            moq::Mock<AccountBudgetService.AccountBudgetServiceClient> mockGrpcClient = new moq::Mock<AccountBudgetService.AccountBudgetServiceClient>(moq::MockBehavior.Strict);
            GetAccountBudgetRequest request = new GetAccountBudgetRequest
            {
                ResourceNameAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
            };
            gagvr::AccountBudget expectedResponse = new gagvr::AccountBudget
            {
                ResourceNameAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                Id = -6774108720365892680L,
                BillingSetupAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                Status = gagve::AccountBudgetStatusEnum.Types.AccountBudgetStatus.Cancelled,
                AccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                ProposedStartDateTime = "proposed_start_date_time4e2f84a3",
                ApprovedStartDateTime = "approved_start_date_time20090a2c",
                ProposedEndDateTime = "proposed_end_date_time39aa28a5",
                ProposedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                ApprovedEndDateTime = "approved_end_date_time99d3ab5d",
                ApprovedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Forever,
                ProposedSpendingLimitMicros = 6806956772888455592L,
                ProposedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                ApprovedSpendingLimitMicros = 1674109600829643495L,
                ApprovedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                AdjustedSpendingLimitMicros = 5260592673487875057L,
                AdjustedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unspecified,
                TotalAdjustmentsMicros = -1818058180873398375L,
                AmountServedMicros = -8683779131450697164L,
                PurchaseOrderNumber = "purchase_order_number7be7181f",
                Notes = "notes00b55843",
                PendingProposal = new gagvr::AccountBudget.Types.PendingAccountBudgetProposal(),
            };
            mockGrpcClient.Setup(x => x.GetAccountBudget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccountBudgetServiceClient client = new AccountBudgetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountBudget response = client.GetAccountBudget(request.ResourceNameAsAccountBudgetName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAccountBudgetResourceNamesAsync()
        {
            moq::Mock<AccountBudgetService.AccountBudgetServiceClient> mockGrpcClient = new moq::Mock<AccountBudgetService.AccountBudgetServiceClient>(moq::MockBehavior.Strict);
            GetAccountBudgetRequest request = new GetAccountBudgetRequest
            {
                ResourceNameAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
            };
            gagvr::AccountBudget expectedResponse = new gagvr::AccountBudget
            {
                ResourceNameAsAccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                Id = -6774108720365892680L,
                BillingSetupAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                Status = gagve::AccountBudgetStatusEnum.Types.AccountBudgetStatus.Cancelled,
                AccountBudgetName = gagvr::AccountBudgetName.FromCustomerAccountBudget("[CUSTOMER]", "[ACCOUNT_BUDGET]"),
                ProposedStartDateTime = "proposed_start_date_time4e2f84a3",
                ApprovedStartDateTime = "approved_start_date_time20090a2c",
                ProposedEndDateTime = "proposed_end_date_time39aa28a5",
                ProposedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                ApprovedEndDateTime = "approved_end_date_time99d3ab5d",
                ApprovedEndTimeType = gagve::TimeTypeEnum.Types.TimeType.Forever,
                ProposedSpendingLimitMicros = 6806956772888455592L,
                ProposedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                ApprovedSpendingLimitMicros = 1674109600829643495L,
                ApprovedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unknown,
                AdjustedSpendingLimitMicros = 5260592673487875057L,
                AdjustedSpendingLimitType = gagve::SpendingLimitTypeEnum.Types.SpendingLimitType.Unspecified,
                TotalAdjustmentsMicros = -1818058180873398375L,
                AmountServedMicros = -8683779131450697164L,
                PurchaseOrderNumber = "purchase_order_number7be7181f",
                Notes = "notes00b55843",
                PendingProposal = new gagvr::AccountBudget.Types.PendingAccountBudgetProposal(),
            };
            mockGrpcClient.Setup(x => x.GetAccountBudgetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AccountBudget>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccountBudgetServiceClient client = new AccountBudgetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountBudget responseCallSettings = await client.GetAccountBudgetAsync(request.ResourceNameAsAccountBudgetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AccountBudget responseCancellationToken = await client.GetAccountBudgetAsync(request.ResourceNameAsAccountBudgetName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

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
    public sealed class GeneratedBillingSetupServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetBillingSetupRequestObject()
        {
            moq::Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new moq::Mock<BillingSetupService.BillingSetupServiceClient>(moq::MockBehavior.Strict);
            GetBillingSetupRequest request = new GetBillingSetupRequest
            {
                ResourceNameAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
            };
            gagvr::BillingSetup expectedResponse = new gagvr::BillingSetup
            {
                ResourceNameAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                Id = -6774108720365892680L,
                Status = gagve::BillingSetupStatusEnum.Types.BillingSetupStatus.Pending,
                StartDateTime = "start_date_timeea924cb1",
                StartTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                PaymentsAccountAsPaymentsAccountName = gagvr::PaymentsAccountName.FromCustomerPaymentsAccount("[CUSTOMER]", "[PAYMENTS_ACCOUNT]"),
                PaymentsAccountInfo = new gagvr::BillingSetup.Types.PaymentsAccountInfo(),
                EndDateTime = "end_date_timea95363f3",
                EndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetBillingSetup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BillingSetup response = client.GetBillingSetup(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetBillingSetupRequestObjectAsync()
        {
            moq::Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new moq::Mock<BillingSetupService.BillingSetupServiceClient>(moq::MockBehavior.Strict);
            GetBillingSetupRequest request = new GetBillingSetupRequest
            {
                ResourceNameAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
            };
            gagvr::BillingSetup expectedResponse = new gagvr::BillingSetup
            {
                ResourceNameAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                Id = -6774108720365892680L,
                Status = gagve::BillingSetupStatusEnum.Types.BillingSetupStatus.Pending,
                StartDateTime = "start_date_timeea924cb1",
                StartTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                PaymentsAccountAsPaymentsAccountName = gagvr::PaymentsAccountName.FromCustomerPaymentsAccount("[CUSTOMER]", "[PAYMENTS_ACCOUNT]"),
                PaymentsAccountInfo = new gagvr::BillingSetup.Types.PaymentsAccountInfo(),
                EndDateTime = "end_date_timea95363f3",
                EndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetBillingSetupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BillingSetup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BillingSetup responseCallSettings = await client.GetBillingSetupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BillingSetup responseCancellationToken = await client.GetBillingSetupAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetBillingSetup()
        {
            moq::Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new moq::Mock<BillingSetupService.BillingSetupServiceClient>(moq::MockBehavior.Strict);
            GetBillingSetupRequest request = new GetBillingSetupRequest
            {
                ResourceNameAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
            };
            gagvr::BillingSetup expectedResponse = new gagvr::BillingSetup
            {
                ResourceNameAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                Id = -6774108720365892680L,
                Status = gagve::BillingSetupStatusEnum.Types.BillingSetupStatus.Pending,
                StartDateTime = "start_date_timeea924cb1",
                StartTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                PaymentsAccountAsPaymentsAccountName = gagvr::PaymentsAccountName.FromCustomerPaymentsAccount("[CUSTOMER]", "[PAYMENTS_ACCOUNT]"),
                PaymentsAccountInfo = new gagvr::BillingSetup.Types.PaymentsAccountInfo(),
                EndDateTime = "end_date_timea95363f3",
                EndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetBillingSetup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BillingSetup response = client.GetBillingSetup(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetBillingSetupAsync()
        {
            moq::Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new moq::Mock<BillingSetupService.BillingSetupServiceClient>(moq::MockBehavior.Strict);
            GetBillingSetupRequest request = new GetBillingSetupRequest
            {
                ResourceNameAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
            };
            gagvr::BillingSetup expectedResponse = new gagvr::BillingSetup
            {
                ResourceNameAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                Id = -6774108720365892680L,
                Status = gagve::BillingSetupStatusEnum.Types.BillingSetupStatus.Pending,
                StartDateTime = "start_date_timeea924cb1",
                StartTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                PaymentsAccountAsPaymentsAccountName = gagvr::PaymentsAccountName.FromCustomerPaymentsAccount("[CUSTOMER]", "[PAYMENTS_ACCOUNT]"),
                PaymentsAccountInfo = new gagvr::BillingSetup.Types.PaymentsAccountInfo(),
                EndDateTime = "end_date_timea95363f3",
                EndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetBillingSetupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BillingSetup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BillingSetup responseCallSettings = await client.GetBillingSetupAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BillingSetup responseCancellationToken = await client.GetBillingSetupAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetBillingSetupResourceNames()
        {
            moq::Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new moq::Mock<BillingSetupService.BillingSetupServiceClient>(moq::MockBehavior.Strict);
            GetBillingSetupRequest request = new GetBillingSetupRequest
            {
                ResourceNameAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
            };
            gagvr::BillingSetup expectedResponse = new gagvr::BillingSetup
            {
                ResourceNameAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                Id = -6774108720365892680L,
                Status = gagve::BillingSetupStatusEnum.Types.BillingSetupStatus.Pending,
                StartDateTime = "start_date_timeea924cb1",
                StartTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                PaymentsAccountAsPaymentsAccountName = gagvr::PaymentsAccountName.FromCustomerPaymentsAccount("[CUSTOMER]", "[PAYMENTS_ACCOUNT]"),
                PaymentsAccountInfo = new gagvr::BillingSetup.Types.PaymentsAccountInfo(),
                EndDateTime = "end_date_timea95363f3",
                EndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetBillingSetup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BillingSetup response = client.GetBillingSetup(request.ResourceNameAsBillingSetupName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetBillingSetupResourceNamesAsync()
        {
            moq::Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new moq::Mock<BillingSetupService.BillingSetupServiceClient>(moq::MockBehavior.Strict);
            GetBillingSetupRequest request = new GetBillingSetupRequest
            {
                ResourceNameAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
            };
            gagvr::BillingSetup expectedResponse = new gagvr::BillingSetup
            {
                ResourceNameAsBillingSetupName = gagvr::BillingSetupName.FromCustomerBillingSetup("[CUSTOMER]", "[BILLING_SETUP]"),
                Id = -6774108720365892680L,
                Status = gagve::BillingSetupStatusEnum.Types.BillingSetupStatus.Pending,
                StartDateTime = "start_date_timeea924cb1",
                StartTimeType = gagve::TimeTypeEnum.Types.TimeType.Unknown,
                PaymentsAccountAsPaymentsAccountName = gagvr::PaymentsAccountName.FromCustomerPaymentsAccount("[CUSTOMER]", "[PAYMENTS_ACCOUNT]"),
                PaymentsAccountInfo = new gagvr::BillingSetup.Types.PaymentsAccountInfo(),
                EndDateTime = "end_date_timea95363f3",
                EndTimeType = gagve::TimeTypeEnum.Types.TimeType.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetBillingSetupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BillingSetup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BillingSetup responseCallSettings = await client.GetBillingSetupAsync(request.ResourceNameAsBillingSetupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BillingSetup responseCancellationToken = await client.GetBillingSetupAsync(request.ResourceNameAsBillingSetupName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateBillingSetupRequestObject()
        {
            moq::Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new moq::Mock<BillingSetupService.BillingSetupServiceClient>(moq::MockBehavior.Strict);
            MutateBillingSetupRequest request = new MutateBillingSetupRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new BillingSetupOperation(),
            };
            MutateBillingSetupResponse expectedResponse = new MutateBillingSetupResponse
            {
                Result = new MutateBillingSetupResult(),
            };
            mockGrpcClient.Setup(x => x.MutateBillingSetup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            MutateBillingSetupResponse response = client.MutateBillingSetup(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateBillingSetupRequestObjectAsync()
        {
            moq::Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new moq::Mock<BillingSetupService.BillingSetupServiceClient>(moq::MockBehavior.Strict);
            MutateBillingSetupRequest request = new MutateBillingSetupRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new BillingSetupOperation(),
            };
            MutateBillingSetupResponse expectedResponse = new MutateBillingSetupResponse
            {
                Result = new MutateBillingSetupResult(),
            };
            mockGrpcClient.Setup(x => x.MutateBillingSetupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateBillingSetupResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            MutateBillingSetupResponse responseCallSettings = await client.MutateBillingSetupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateBillingSetupResponse responseCancellationToken = await client.MutateBillingSetupAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateBillingSetup()
        {
            moq::Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new moq::Mock<BillingSetupService.BillingSetupServiceClient>(moq::MockBehavior.Strict);
            MutateBillingSetupRequest request = new MutateBillingSetupRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new BillingSetupOperation(),
            };
            MutateBillingSetupResponse expectedResponse = new MutateBillingSetupResponse
            {
                Result = new MutateBillingSetupResult(),
            };
            mockGrpcClient.Setup(x => x.MutateBillingSetup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            MutateBillingSetupResponse response = client.MutateBillingSetup(request.CustomerId, request.Operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateBillingSetupAsync()
        {
            moq::Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new moq::Mock<BillingSetupService.BillingSetupServiceClient>(moq::MockBehavior.Strict);
            MutateBillingSetupRequest request = new MutateBillingSetupRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new BillingSetupOperation(),
            };
            MutateBillingSetupResponse expectedResponse = new MutateBillingSetupResponse
            {
                Result = new MutateBillingSetupResult(),
            };
            mockGrpcClient.Setup(x => x.MutateBillingSetupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateBillingSetupResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            MutateBillingSetupResponse responseCallSettings = await client.MutateBillingSetupAsync(request.CustomerId, request.Operation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateBillingSetupResponse responseCancellationToken = await client.MutateBillingSetupAsync(request.CustomerId, request.Operation, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

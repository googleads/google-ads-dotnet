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

using gagve = Google.Ads.GoogleAds.V4.Enums;
using gagvr = Google.Ads.GoogleAds.V4.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V4.Services;

namespace Google.Ads.GoogleAds.Tests.V4.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAccountLinkServiceClientTest
    {
        [Test]
        public void GetAccountLinkRequestObject()
        {
            moq::Mock<AccountLinkService.AccountLinkServiceClient> mockGrpcClient = new moq::Mock<AccountLinkService.AccountLinkServiceClient>(moq::MockBehavior.Strict);
            GetAccountLinkRequest request = new GetAccountLinkRequest
            {
                ResourceNameAsAccountLinkName = gagvr::AccountLinkName.FromCustomerAccountLink("[CUSTOMER]", "[ACCOUNT_LINK]"),
            };
            gagvr::AccountLink expectedResponse = new gagvr::AccountLink
            {
                ResourceNameAsAccountLinkName = gagvr::AccountLinkName.FromCustomerAccountLink("[CUSTOMER]", "[ACCOUNT_LINK]"),
                AccountLinkId = 2714466098325457917L,
                Status = gagve::AccountLinkStatusEnum.Types.AccountLinkStatus.Enabled,
                Type = gagve::LinkedAccountTypeEnum.Types.LinkedAccountType.Unspecified,
                ThirdPartyAppAnalytics = new gagvr::ThirdPartyAppAnalyticsLinkIdentifier(),
            };
            mockGrpcClient.Setup(x => x.GetAccountLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccountLinkServiceClient client = new AccountLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountLink response = client.GetAccountLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAccountLinkRequestObjectAsync()
        {
            moq::Mock<AccountLinkService.AccountLinkServiceClient> mockGrpcClient = new moq::Mock<AccountLinkService.AccountLinkServiceClient>(moq::MockBehavior.Strict);
            GetAccountLinkRequest request = new GetAccountLinkRequest
            {
                ResourceNameAsAccountLinkName = gagvr::AccountLinkName.FromCustomerAccountLink("[CUSTOMER]", "[ACCOUNT_LINK]"),
            };
            gagvr::AccountLink expectedResponse = new gagvr::AccountLink
            {
                ResourceNameAsAccountLinkName = gagvr::AccountLinkName.FromCustomerAccountLink("[CUSTOMER]", "[ACCOUNT_LINK]"),
                AccountLinkId = 2714466098325457917L,
                Status = gagve::AccountLinkStatusEnum.Types.AccountLinkStatus.Enabled,
                Type = gagve::LinkedAccountTypeEnum.Types.LinkedAccountType.Unspecified,
                ThirdPartyAppAnalytics = new gagvr::ThirdPartyAppAnalyticsLinkIdentifier(),
            };
            mockGrpcClient.Setup(x => x.GetAccountLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AccountLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccountLinkServiceClient client = new AccountLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountLink responseCallSettings = await client.GetAccountLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AccountLink responseCancellationToken = await client.GetAccountLinkAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAccountLink()
        {
            moq::Mock<AccountLinkService.AccountLinkServiceClient> mockGrpcClient = new moq::Mock<AccountLinkService.AccountLinkServiceClient>(moq::MockBehavior.Strict);
            GetAccountLinkRequest request = new GetAccountLinkRequest
            {
                ResourceNameAsAccountLinkName = gagvr::AccountLinkName.FromCustomerAccountLink("[CUSTOMER]", "[ACCOUNT_LINK]"),
            };
            gagvr::AccountLink expectedResponse = new gagvr::AccountLink
            {
                ResourceNameAsAccountLinkName = gagvr::AccountLinkName.FromCustomerAccountLink("[CUSTOMER]", "[ACCOUNT_LINK]"),
                AccountLinkId = 2714466098325457917L,
                Status = gagve::AccountLinkStatusEnum.Types.AccountLinkStatus.Enabled,
                Type = gagve::LinkedAccountTypeEnum.Types.LinkedAccountType.Unspecified,
                ThirdPartyAppAnalytics = new gagvr::ThirdPartyAppAnalyticsLinkIdentifier(),
            };
            mockGrpcClient.Setup(x => x.GetAccountLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccountLinkServiceClient client = new AccountLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountLink response = client.GetAccountLink(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAccountLinkAsync()
        {
            moq::Mock<AccountLinkService.AccountLinkServiceClient> mockGrpcClient = new moq::Mock<AccountLinkService.AccountLinkServiceClient>(moq::MockBehavior.Strict);
            GetAccountLinkRequest request = new GetAccountLinkRequest
            {
                ResourceNameAsAccountLinkName = gagvr::AccountLinkName.FromCustomerAccountLink("[CUSTOMER]", "[ACCOUNT_LINK]"),
            };
            gagvr::AccountLink expectedResponse = new gagvr::AccountLink
            {
                ResourceNameAsAccountLinkName = gagvr::AccountLinkName.FromCustomerAccountLink("[CUSTOMER]", "[ACCOUNT_LINK]"),
                AccountLinkId = 2714466098325457917L,
                Status = gagve::AccountLinkStatusEnum.Types.AccountLinkStatus.Enabled,
                Type = gagve::LinkedAccountTypeEnum.Types.LinkedAccountType.Unspecified,
                ThirdPartyAppAnalytics = new gagvr::ThirdPartyAppAnalyticsLinkIdentifier(),
            };
            mockGrpcClient.Setup(x => x.GetAccountLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AccountLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccountLinkServiceClient client = new AccountLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountLink responseCallSettings = await client.GetAccountLinkAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AccountLink responseCancellationToken = await client.GetAccountLinkAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAccountLinkResourceNames()
        {
            moq::Mock<AccountLinkService.AccountLinkServiceClient> mockGrpcClient = new moq::Mock<AccountLinkService.AccountLinkServiceClient>(moq::MockBehavior.Strict);
            GetAccountLinkRequest request = new GetAccountLinkRequest
            {
                ResourceNameAsAccountLinkName = gagvr::AccountLinkName.FromCustomerAccountLink("[CUSTOMER]", "[ACCOUNT_LINK]"),
            };
            gagvr::AccountLink expectedResponse = new gagvr::AccountLink
            {
                ResourceNameAsAccountLinkName = gagvr::AccountLinkName.FromCustomerAccountLink("[CUSTOMER]", "[ACCOUNT_LINK]"),
                AccountLinkId = 2714466098325457917L,
                Status = gagve::AccountLinkStatusEnum.Types.AccountLinkStatus.Enabled,
                Type = gagve::LinkedAccountTypeEnum.Types.LinkedAccountType.Unspecified,
                ThirdPartyAppAnalytics = new gagvr::ThirdPartyAppAnalyticsLinkIdentifier(),
            };
            mockGrpcClient.Setup(x => x.GetAccountLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccountLinkServiceClient client = new AccountLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountLink response = client.GetAccountLink(request.ResourceNameAsAccountLinkName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAccountLinkResourceNamesAsync()
        {
            moq::Mock<AccountLinkService.AccountLinkServiceClient> mockGrpcClient = new moq::Mock<AccountLinkService.AccountLinkServiceClient>(moq::MockBehavior.Strict);
            GetAccountLinkRequest request = new GetAccountLinkRequest
            {
                ResourceNameAsAccountLinkName = gagvr::AccountLinkName.FromCustomerAccountLink("[CUSTOMER]", "[ACCOUNT_LINK]"),
            };
            gagvr::AccountLink expectedResponse = new gagvr::AccountLink
            {
                ResourceNameAsAccountLinkName = gagvr::AccountLinkName.FromCustomerAccountLink("[CUSTOMER]", "[ACCOUNT_LINK]"),
                AccountLinkId = 2714466098325457917L,
                Status = gagve::AccountLinkStatusEnum.Types.AccountLinkStatus.Enabled,
                Type = gagve::LinkedAccountTypeEnum.Types.LinkedAccountType.Unspecified,
                ThirdPartyAppAnalytics = new gagvr::ThirdPartyAppAnalyticsLinkIdentifier(),
            };
            mockGrpcClient.Setup(x => x.GetAccountLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AccountLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccountLinkServiceClient client = new AccountLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AccountLink responseCallSettings = await client.GetAccountLinkAsync(request.ResourceNameAsAccountLinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AccountLink responseCancellationToken = await client.GetAccountLinkAsync(request.ResourceNameAsAccountLinkName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAccountLinkRequestObject()
        {
            moq::Mock<AccountLinkService.AccountLinkServiceClient> mockGrpcClient = new moq::Mock<AccountLinkService.AccountLinkServiceClient>(moq::MockBehavior.Strict);
            MutateAccountLinkRequest request = new MutateAccountLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new AccountLinkOperation(),
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateAccountLinkResponse expectedResponse = new MutateAccountLinkResponse
            {
                Result = new MutateAccountLinkResult(),
            };
            mockGrpcClient.Setup(x => x.MutateAccountLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccountLinkServiceClient client = new AccountLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateAccountLinkResponse response = client.MutateAccountLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateAccountLinkRequestObjectAsync()
        {
            moq::Mock<AccountLinkService.AccountLinkServiceClient> mockGrpcClient = new moq::Mock<AccountLinkService.AccountLinkServiceClient>(moq::MockBehavior.Strict);
            MutateAccountLinkRequest request = new MutateAccountLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new AccountLinkOperation(),
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateAccountLinkResponse expectedResponse = new MutateAccountLinkResponse
            {
                Result = new MutateAccountLinkResult(),
            };
            mockGrpcClient.Setup(x => x.MutateAccountLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAccountLinkResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccountLinkServiceClient client = new AccountLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateAccountLinkResponse responseCallSettings = await client.MutateAccountLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAccountLinkResponse responseCancellationToken = await client.MutateAccountLinkAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAccountLink()
        {
            moq::Mock<AccountLinkService.AccountLinkServiceClient> mockGrpcClient = new moq::Mock<AccountLinkService.AccountLinkServiceClient>(moq::MockBehavior.Strict);
            MutateAccountLinkRequest request = new MutateAccountLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new AccountLinkOperation(),
            };
            MutateAccountLinkResponse expectedResponse = new MutateAccountLinkResponse
            {
                Result = new MutateAccountLinkResult(),
            };
            mockGrpcClient.Setup(x => x.MutateAccountLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AccountLinkServiceClient client = new AccountLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateAccountLinkResponse response = client.MutateAccountLink(request.CustomerId, request.Operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateAccountLinkAsync()
        {
            moq::Mock<AccountLinkService.AccountLinkServiceClient> mockGrpcClient = new moq::Mock<AccountLinkService.AccountLinkServiceClient>(moq::MockBehavior.Strict);
            MutateAccountLinkRequest request = new MutateAccountLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new AccountLinkOperation(),
            };
            MutateAccountLinkResponse expectedResponse = new MutateAccountLinkResponse
            {
                Result = new MutateAccountLinkResult(),
            };
            mockGrpcClient.Setup(x => x.MutateAccountLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAccountLinkResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AccountLinkServiceClient client = new AccountLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateAccountLinkResponse responseCallSettings = await client.MutateAccountLinkAsync(request.CustomerId, request.Operation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAccountLinkResponse responseCancellationToken = await client.MutateAccountLinkAsync(request.CustomerId, request.Operation, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

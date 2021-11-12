// Copyright 2021 Google LLC
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

using gagve = Google.Ads.GoogleAds.V9.Enums;
using gagvr = Google.Ads.GoogleAds.V9.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V9.Services;

namespace Google.Ads.GoogleAds.Tests.V9.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCustomerUserAccessInvitationServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCustomerUserAccessInvitationRequestObject()
        {
            moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient>(moq::MockBehavior.Strict);
            GetCustomerUserAccessInvitationRequest request = new GetCustomerUserAccessInvitationRequest
            {
                ResourceNameAsCustomerUserAccessInvitationName = gagvr::CustomerUserAccessInvitationName.FromCustomerInvitation("[CUSTOMER_ID]", "[INVITATION_ID]"),
            };
            gagvr::CustomerUserAccessInvitation expectedResponse = new gagvr::CustomerUserAccessInvitation
            {
                ResourceNameAsCustomerUserAccessInvitationName = gagvr::CustomerUserAccessInvitationName.FromCustomerInvitation("[CUSTOMER_ID]", "[INVITATION_ID]"),
                InvitationId = -4996900927385391354L,
                AccessRole = gagve::AccessRoleEnum.Types.AccessRole.Unspecified,
                EmailAddress = "email_addressf3aae0b5",
                CreationDateTime = "creation_date_time2f8c0159",
                InvitationStatus = gagve::AccessInvitationStatusEnum.Types.AccessInvitationStatus.Pending,
            };
            mockGrpcClient.Setup(x => x.GetCustomerUserAccessInvitation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerUserAccessInvitationServiceClient client = new CustomerUserAccessInvitationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerUserAccessInvitation response = client.GetCustomerUserAccessInvitation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerUserAccessInvitationRequestObjectAsync()
        {
            moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient>(moq::MockBehavior.Strict);
            GetCustomerUserAccessInvitationRequest request = new GetCustomerUserAccessInvitationRequest
            {
                ResourceNameAsCustomerUserAccessInvitationName = gagvr::CustomerUserAccessInvitationName.FromCustomerInvitation("[CUSTOMER_ID]", "[INVITATION_ID]"),
            };
            gagvr::CustomerUserAccessInvitation expectedResponse = new gagvr::CustomerUserAccessInvitation
            {
                ResourceNameAsCustomerUserAccessInvitationName = gagvr::CustomerUserAccessInvitationName.FromCustomerInvitation("[CUSTOMER_ID]", "[INVITATION_ID]"),
                InvitationId = -4996900927385391354L,
                AccessRole = gagve::AccessRoleEnum.Types.AccessRole.Unspecified,
                EmailAddress = "email_addressf3aae0b5",
                CreationDateTime = "creation_date_time2f8c0159",
                InvitationStatus = gagve::AccessInvitationStatusEnum.Types.AccessInvitationStatus.Pending,
            };
            mockGrpcClient.Setup(x => x.GetCustomerUserAccessInvitationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerUserAccessInvitation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerUserAccessInvitationServiceClient client = new CustomerUserAccessInvitationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerUserAccessInvitation responseCallSettings = await client.GetCustomerUserAccessInvitationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerUserAccessInvitation responseCancellationToken = await client.GetCustomerUserAccessInvitationAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCustomerUserAccessInvitation()
        {
            moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient>(moq::MockBehavior.Strict);
            GetCustomerUserAccessInvitationRequest request = new GetCustomerUserAccessInvitationRequest
            {
                ResourceNameAsCustomerUserAccessInvitationName = gagvr::CustomerUserAccessInvitationName.FromCustomerInvitation("[CUSTOMER_ID]", "[INVITATION_ID]"),
            };
            gagvr::CustomerUserAccessInvitation expectedResponse = new gagvr::CustomerUserAccessInvitation
            {
                ResourceNameAsCustomerUserAccessInvitationName = gagvr::CustomerUserAccessInvitationName.FromCustomerInvitation("[CUSTOMER_ID]", "[INVITATION_ID]"),
                InvitationId = -4996900927385391354L,
                AccessRole = gagve::AccessRoleEnum.Types.AccessRole.Unspecified,
                EmailAddress = "email_addressf3aae0b5",
                CreationDateTime = "creation_date_time2f8c0159",
                InvitationStatus = gagve::AccessInvitationStatusEnum.Types.AccessInvitationStatus.Pending,
            };
            mockGrpcClient.Setup(x => x.GetCustomerUserAccessInvitation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerUserAccessInvitationServiceClient client = new CustomerUserAccessInvitationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerUserAccessInvitation response = client.GetCustomerUserAccessInvitation(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerUserAccessInvitationAsync()
        {
            moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient>(moq::MockBehavior.Strict);
            GetCustomerUserAccessInvitationRequest request = new GetCustomerUserAccessInvitationRequest
            {
                ResourceNameAsCustomerUserAccessInvitationName = gagvr::CustomerUserAccessInvitationName.FromCustomerInvitation("[CUSTOMER_ID]", "[INVITATION_ID]"),
            };
            gagvr::CustomerUserAccessInvitation expectedResponse = new gagvr::CustomerUserAccessInvitation
            {
                ResourceNameAsCustomerUserAccessInvitationName = gagvr::CustomerUserAccessInvitationName.FromCustomerInvitation("[CUSTOMER_ID]", "[INVITATION_ID]"),
                InvitationId = -4996900927385391354L,
                AccessRole = gagve::AccessRoleEnum.Types.AccessRole.Unspecified,
                EmailAddress = "email_addressf3aae0b5",
                CreationDateTime = "creation_date_time2f8c0159",
                InvitationStatus = gagve::AccessInvitationStatusEnum.Types.AccessInvitationStatus.Pending,
            };
            mockGrpcClient.Setup(x => x.GetCustomerUserAccessInvitationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerUserAccessInvitation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerUserAccessInvitationServiceClient client = new CustomerUserAccessInvitationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerUserAccessInvitation responseCallSettings = await client.GetCustomerUserAccessInvitationAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerUserAccessInvitation responseCancellationToken = await client.GetCustomerUserAccessInvitationAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCustomerUserAccessInvitationResourceNames()
        {
            moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient>(moq::MockBehavior.Strict);
            GetCustomerUserAccessInvitationRequest request = new GetCustomerUserAccessInvitationRequest
            {
                ResourceNameAsCustomerUserAccessInvitationName = gagvr::CustomerUserAccessInvitationName.FromCustomerInvitation("[CUSTOMER_ID]", "[INVITATION_ID]"),
            };
            gagvr::CustomerUserAccessInvitation expectedResponse = new gagvr::CustomerUserAccessInvitation
            {
                ResourceNameAsCustomerUserAccessInvitationName = gagvr::CustomerUserAccessInvitationName.FromCustomerInvitation("[CUSTOMER_ID]", "[INVITATION_ID]"),
                InvitationId = -4996900927385391354L,
                AccessRole = gagve::AccessRoleEnum.Types.AccessRole.Unspecified,
                EmailAddress = "email_addressf3aae0b5",
                CreationDateTime = "creation_date_time2f8c0159",
                InvitationStatus = gagve::AccessInvitationStatusEnum.Types.AccessInvitationStatus.Pending,
            };
            mockGrpcClient.Setup(x => x.GetCustomerUserAccessInvitation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerUserAccessInvitationServiceClient client = new CustomerUserAccessInvitationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerUserAccessInvitation response = client.GetCustomerUserAccessInvitation(request.ResourceNameAsCustomerUserAccessInvitationName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerUserAccessInvitationResourceNamesAsync()
        {
            moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient>(moq::MockBehavior.Strict);
            GetCustomerUserAccessInvitationRequest request = new GetCustomerUserAccessInvitationRequest
            {
                ResourceNameAsCustomerUserAccessInvitationName = gagvr::CustomerUserAccessInvitationName.FromCustomerInvitation("[CUSTOMER_ID]", "[INVITATION_ID]"),
            };
            gagvr::CustomerUserAccessInvitation expectedResponse = new gagvr::CustomerUserAccessInvitation
            {
                ResourceNameAsCustomerUserAccessInvitationName = gagvr::CustomerUserAccessInvitationName.FromCustomerInvitation("[CUSTOMER_ID]", "[INVITATION_ID]"),
                InvitationId = -4996900927385391354L,
                AccessRole = gagve::AccessRoleEnum.Types.AccessRole.Unspecified,
                EmailAddress = "email_addressf3aae0b5",
                CreationDateTime = "creation_date_time2f8c0159",
                InvitationStatus = gagve::AccessInvitationStatusEnum.Types.AccessInvitationStatus.Pending,
            };
            mockGrpcClient.Setup(x => x.GetCustomerUserAccessInvitationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerUserAccessInvitation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerUserAccessInvitationServiceClient client = new CustomerUserAccessInvitationServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerUserAccessInvitation responseCallSettings = await client.GetCustomerUserAccessInvitationAsync(request.ResourceNameAsCustomerUserAccessInvitationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerUserAccessInvitation responseCancellationToken = await client.GetCustomerUserAccessInvitationAsync(request.ResourceNameAsCustomerUserAccessInvitationName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomerUserAccessInvitationRequestObject()
        {
            moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerUserAccessInvitationRequest request = new MutateCustomerUserAccessInvitationRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerUserAccessInvitationOperation(),
            };
            MutateCustomerUserAccessInvitationResponse expectedResponse = new MutateCustomerUserAccessInvitationResponse
            {
                Result = new MutateCustomerUserAccessInvitationResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerUserAccessInvitation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerUserAccessInvitationServiceClient client = new CustomerUserAccessInvitationServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerUserAccessInvitationResponse response = client.MutateCustomerUserAccessInvitation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerUserAccessInvitationRequestObjectAsync()
        {
            moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerUserAccessInvitationRequest request = new MutateCustomerUserAccessInvitationRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerUserAccessInvitationOperation(),
            };
            MutateCustomerUserAccessInvitationResponse expectedResponse = new MutateCustomerUserAccessInvitationResponse
            {
                Result = new MutateCustomerUserAccessInvitationResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerUserAccessInvitationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerUserAccessInvitationResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerUserAccessInvitationServiceClient client = new CustomerUserAccessInvitationServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerUserAccessInvitationResponse responseCallSettings = await client.MutateCustomerUserAccessInvitationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerUserAccessInvitationResponse responseCancellationToken = await client.MutateCustomerUserAccessInvitationAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomerUserAccessInvitation()
        {
            moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerUserAccessInvitationRequest request = new MutateCustomerUserAccessInvitationRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerUserAccessInvitationOperation(),
            };
            MutateCustomerUserAccessInvitationResponse expectedResponse = new MutateCustomerUserAccessInvitationResponse
            {
                Result = new MutateCustomerUserAccessInvitationResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerUserAccessInvitation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerUserAccessInvitationServiceClient client = new CustomerUserAccessInvitationServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerUserAccessInvitationResponse response = client.MutateCustomerUserAccessInvitation(request.CustomerId, request.Operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerUserAccessInvitationAsync()
        {
            moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerUserAccessInvitationRequest request = new MutateCustomerUserAccessInvitationRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerUserAccessInvitationOperation(),
            };
            MutateCustomerUserAccessInvitationResponse expectedResponse = new MutateCustomerUserAccessInvitationResponse
            {
                Result = new MutateCustomerUserAccessInvitationResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerUserAccessInvitationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerUserAccessInvitationResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerUserAccessInvitationServiceClient client = new CustomerUserAccessInvitationServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerUserAccessInvitationResponse responseCallSettings = await client.MutateCustomerUserAccessInvitationAsync(request.CustomerId, request.Operation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerUserAccessInvitationResponse responseCancellationToken = await client.MutateCustomerUserAccessInvitationAsync(request.CustomerId, request.Operation, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

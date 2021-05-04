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

using gagve = Google.Ads.GoogleAds.V7.Enums;
using gagvr = Google.Ads.GoogleAds.V7.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V7.Services;

namespace Google.Ads.GoogleAds.Tests.V7.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCustomerUserAccessServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCustomerUserAccessRequestObject()
        {
            moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient>(moq::MockBehavior.Strict);
            GetCustomerUserAccessRequest request = new GetCustomerUserAccessRequest
            {
                ResourceNameAsCustomerUserAccessName = gagvr::CustomerUserAccessName.FromCustomerUser("[CUSTOMER_ID]", "[USER_ID]"),
            };
            gagvr::CustomerUserAccess expectedResponse = new gagvr::CustomerUserAccess
            {
                ResourceNameAsCustomerUserAccessName = gagvr::CustomerUserAccessName.FromCustomerUser("[CUSTOMER_ID]", "[USER_ID]"),
                UserId = -7972883667886640920L,
                EmailAddress = "email_addressf3aae0b5",
                AccessRole = gagve::AccessRoleEnum.Types.AccessRole.Unspecified,
                AccessCreationDateTime = "access_creation_date_time7709b5b1",
                InviterUserEmailAddress = "inviter_user_email_address38e90785",
            };
            mockGrpcClient.Setup(x => x.GetCustomerUserAccess(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerUserAccessServiceClient client = new CustomerUserAccessServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerUserAccess response = client.GetCustomerUserAccess(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerUserAccessRequestObjectAsync()
        {
            moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient>(moq::MockBehavior.Strict);
            GetCustomerUserAccessRequest request = new GetCustomerUserAccessRequest
            {
                ResourceNameAsCustomerUserAccessName = gagvr::CustomerUserAccessName.FromCustomerUser("[CUSTOMER_ID]", "[USER_ID]"),
            };
            gagvr::CustomerUserAccess expectedResponse = new gagvr::CustomerUserAccess
            {
                ResourceNameAsCustomerUserAccessName = gagvr::CustomerUserAccessName.FromCustomerUser("[CUSTOMER_ID]", "[USER_ID]"),
                UserId = -7972883667886640920L,
                EmailAddress = "email_addressf3aae0b5",
                AccessRole = gagve::AccessRoleEnum.Types.AccessRole.Unspecified,
                AccessCreationDateTime = "access_creation_date_time7709b5b1",
                InviterUserEmailAddress = "inviter_user_email_address38e90785",
            };
            mockGrpcClient.Setup(x => x.GetCustomerUserAccessAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerUserAccess>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerUserAccessServiceClient client = new CustomerUserAccessServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerUserAccess responseCallSettings = await client.GetCustomerUserAccessAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerUserAccess responseCancellationToken = await client.GetCustomerUserAccessAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCustomerUserAccess()
        {
            moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient>(moq::MockBehavior.Strict);
            GetCustomerUserAccessRequest request = new GetCustomerUserAccessRequest
            {
                ResourceNameAsCustomerUserAccessName = gagvr::CustomerUserAccessName.FromCustomerUser("[CUSTOMER_ID]", "[USER_ID]"),
            };
            gagvr::CustomerUserAccess expectedResponse = new gagvr::CustomerUserAccess
            {
                ResourceNameAsCustomerUserAccessName = gagvr::CustomerUserAccessName.FromCustomerUser("[CUSTOMER_ID]", "[USER_ID]"),
                UserId = -7972883667886640920L,
                EmailAddress = "email_addressf3aae0b5",
                AccessRole = gagve::AccessRoleEnum.Types.AccessRole.Unspecified,
                AccessCreationDateTime = "access_creation_date_time7709b5b1",
                InviterUserEmailAddress = "inviter_user_email_address38e90785",
            };
            mockGrpcClient.Setup(x => x.GetCustomerUserAccess(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerUserAccessServiceClient client = new CustomerUserAccessServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerUserAccess response = client.GetCustomerUserAccess(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerUserAccessAsync()
        {
            moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient>(moq::MockBehavior.Strict);
            GetCustomerUserAccessRequest request = new GetCustomerUserAccessRequest
            {
                ResourceNameAsCustomerUserAccessName = gagvr::CustomerUserAccessName.FromCustomerUser("[CUSTOMER_ID]", "[USER_ID]"),
            };
            gagvr::CustomerUserAccess expectedResponse = new gagvr::CustomerUserAccess
            {
                ResourceNameAsCustomerUserAccessName = gagvr::CustomerUserAccessName.FromCustomerUser("[CUSTOMER_ID]", "[USER_ID]"),
                UserId = -7972883667886640920L,
                EmailAddress = "email_addressf3aae0b5",
                AccessRole = gagve::AccessRoleEnum.Types.AccessRole.Unspecified,
                AccessCreationDateTime = "access_creation_date_time7709b5b1",
                InviterUserEmailAddress = "inviter_user_email_address38e90785",
            };
            mockGrpcClient.Setup(x => x.GetCustomerUserAccessAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerUserAccess>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerUserAccessServiceClient client = new CustomerUserAccessServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerUserAccess responseCallSettings = await client.GetCustomerUserAccessAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerUserAccess responseCancellationToken = await client.GetCustomerUserAccessAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCustomerUserAccessResourceNames()
        {
            moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient>(moq::MockBehavior.Strict);
            GetCustomerUserAccessRequest request = new GetCustomerUserAccessRequest
            {
                ResourceNameAsCustomerUserAccessName = gagvr::CustomerUserAccessName.FromCustomerUser("[CUSTOMER_ID]", "[USER_ID]"),
            };
            gagvr::CustomerUserAccess expectedResponse = new gagvr::CustomerUserAccess
            {
                ResourceNameAsCustomerUserAccessName = gagvr::CustomerUserAccessName.FromCustomerUser("[CUSTOMER_ID]", "[USER_ID]"),
                UserId = -7972883667886640920L,
                EmailAddress = "email_addressf3aae0b5",
                AccessRole = gagve::AccessRoleEnum.Types.AccessRole.Unspecified,
                AccessCreationDateTime = "access_creation_date_time7709b5b1",
                InviterUserEmailAddress = "inviter_user_email_address38e90785",
            };
            mockGrpcClient.Setup(x => x.GetCustomerUserAccess(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerUserAccessServiceClient client = new CustomerUserAccessServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerUserAccess response = client.GetCustomerUserAccess(request.ResourceNameAsCustomerUserAccessName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerUserAccessResourceNamesAsync()
        {
            moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient>(moq::MockBehavior.Strict);
            GetCustomerUserAccessRequest request = new GetCustomerUserAccessRequest
            {
                ResourceNameAsCustomerUserAccessName = gagvr::CustomerUserAccessName.FromCustomerUser("[CUSTOMER_ID]", "[USER_ID]"),
            };
            gagvr::CustomerUserAccess expectedResponse = new gagvr::CustomerUserAccess
            {
                ResourceNameAsCustomerUserAccessName = gagvr::CustomerUserAccessName.FromCustomerUser("[CUSTOMER_ID]", "[USER_ID]"),
                UserId = -7972883667886640920L,
                EmailAddress = "email_addressf3aae0b5",
                AccessRole = gagve::AccessRoleEnum.Types.AccessRole.Unspecified,
                AccessCreationDateTime = "access_creation_date_time7709b5b1",
                InviterUserEmailAddress = "inviter_user_email_address38e90785",
            };
            mockGrpcClient.Setup(x => x.GetCustomerUserAccessAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerUserAccess>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerUserAccessServiceClient client = new CustomerUserAccessServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerUserAccess responseCallSettings = await client.GetCustomerUserAccessAsync(request.ResourceNameAsCustomerUserAccessName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerUserAccess responseCancellationToken = await client.GetCustomerUserAccessAsync(request.ResourceNameAsCustomerUserAccessName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomerUserAccessRequestObject()
        {
            moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerUserAccessRequest request = new MutateCustomerUserAccessRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerUserAccessOperation(),
            };
            MutateCustomerUserAccessResponse expectedResponse = new MutateCustomerUserAccessResponse
            {
                Result = new MutateCustomerUserAccessResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerUserAccess(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerUserAccessServiceClient client = new CustomerUserAccessServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerUserAccessResponse response = client.MutateCustomerUserAccess(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerUserAccessRequestObjectAsync()
        {
            moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerUserAccessRequest request = new MutateCustomerUserAccessRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerUserAccessOperation(),
            };
            MutateCustomerUserAccessResponse expectedResponse = new MutateCustomerUserAccessResponse
            {
                Result = new MutateCustomerUserAccessResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerUserAccessAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerUserAccessResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerUserAccessServiceClient client = new CustomerUserAccessServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerUserAccessResponse responseCallSettings = await client.MutateCustomerUserAccessAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerUserAccessResponse responseCancellationToken = await client.MutateCustomerUserAccessAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomerUserAccess()
        {
            moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerUserAccessRequest request = new MutateCustomerUserAccessRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerUserAccessOperation(),
            };
            MutateCustomerUserAccessResponse expectedResponse = new MutateCustomerUserAccessResponse
            {
                Result = new MutateCustomerUserAccessResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerUserAccess(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerUserAccessServiceClient client = new CustomerUserAccessServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerUserAccessResponse response = client.MutateCustomerUserAccess(request.CustomerId, request.Operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerUserAccessAsync()
        {
            moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient> mockGrpcClient = new moq::Mock<CustomerUserAccessService.CustomerUserAccessServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerUserAccessRequest request = new MutateCustomerUserAccessRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerUserAccessOperation(),
            };
            MutateCustomerUserAccessResponse expectedResponse = new MutateCustomerUserAccessResponse
            {
                Result = new MutateCustomerUserAccessResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerUserAccessAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerUserAccessResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerUserAccessServiceClient client = new CustomerUserAccessServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerUserAccessResponse responseCallSettings = await client.MutateCustomerUserAccessAsync(request.CustomerId, request.Operation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerUserAccessResponse responseCancellationToken = await client.MutateCustomerUserAccessAsync(request.CustomerId, request.Operation, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

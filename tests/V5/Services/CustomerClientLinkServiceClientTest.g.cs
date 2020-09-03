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

using gagve = Google.Ads.GoogleAds.V5.Enums;
using gagvr = Google.Ads.GoogleAds.V5.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V5.Services;

namespace Google.Ads.GoogleAds.Tests.V5.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCustomerClientLinkServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCustomerClientLinkRequestObject()
        {
            moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerClientLinkRequest request = new GetCustomerClientLinkRequest
            {
                ResourceNameAsCustomerClientLinkName = gagvr::CustomerClientLinkName.FromCustomerCustomerClientLink("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]"),
            };
            gagvr::CustomerClientLink expectedResponse = new gagvr::CustomerClientLink
            {
                ResourceNameAsCustomerClientLinkName = gagvr::CustomerClientLinkName.FromCustomerCustomerClientLink("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]"),
                ClientCustomer = "client_customerf58ac5fa",
                ManagerLinkId = 1955158851327798968L,
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
                Hidden = true,
            };
            mockGrpcClient.Setup(x => x.GetCustomerClientLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerClientLink response = client.GetCustomerClientLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerClientLinkRequestObjectAsync()
        {
            moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerClientLinkRequest request = new GetCustomerClientLinkRequest
            {
                ResourceNameAsCustomerClientLinkName = gagvr::CustomerClientLinkName.FromCustomerCustomerClientLink("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]"),
            };
            gagvr::CustomerClientLink expectedResponse = new gagvr::CustomerClientLink
            {
                ResourceNameAsCustomerClientLinkName = gagvr::CustomerClientLinkName.FromCustomerCustomerClientLink("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]"),
                ClientCustomer = "client_customerf58ac5fa",
                ManagerLinkId = 1955158851327798968L,
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
                Hidden = true,
            };
            mockGrpcClient.Setup(x => x.GetCustomerClientLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerClientLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerClientLink responseCallSettings = await client.GetCustomerClientLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerClientLink responseCancellationToken = await client.GetCustomerClientLinkAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCustomerClientLink()
        {
            moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerClientLinkRequest request = new GetCustomerClientLinkRequest
            {
                ResourceNameAsCustomerClientLinkName = gagvr::CustomerClientLinkName.FromCustomerCustomerClientLink("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]"),
            };
            gagvr::CustomerClientLink expectedResponse = new gagvr::CustomerClientLink
            {
                ResourceNameAsCustomerClientLinkName = gagvr::CustomerClientLinkName.FromCustomerCustomerClientLink("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]"),
                ClientCustomer = "client_customerf58ac5fa",
                ManagerLinkId = 1955158851327798968L,
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
                Hidden = true,
            };
            mockGrpcClient.Setup(x => x.GetCustomerClientLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerClientLink response = client.GetCustomerClientLink(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerClientLinkAsync()
        {
            moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerClientLinkRequest request = new GetCustomerClientLinkRequest
            {
                ResourceNameAsCustomerClientLinkName = gagvr::CustomerClientLinkName.FromCustomerCustomerClientLink("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]"),
            };
            gagvr::CustomerClientLink expectedResponse = new gagvr::CustomerClientLink
            {
                ResourceNameAsCustomerClientLinkName = gagvr::CustomerClientLinkName.FromCustomerCustomerClientLink("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]"),
                ClientCustomer = "client_customerf58ac5fa",
                ManagerLinkId = 1955158851327798968L,
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
                Hidden = true,
            };
            mockGrpcClient.Setup(x => x.GetCustomerClientLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerClientLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerClientLink responseCallSettings = await client.GetCustomerClientLinkAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerClientLink responseCancellationToken = await client.GetCustomerClientLinkAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCustomerClientLinkResourceNames()
        {
            moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerClientLinkRequest request = new GetCustomerClientLinkRequest
            {
                ResourceNameAsCustomerClientLinkName = gagvr::CustomerClientLinkName.FromCustomerCustomerClientLink("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]"),
            };
            gagvr::CustomerClientLink expectedResponse = new gagvr::CustomerClientLink
            {
                ResourceNameAsCustomerClientLinkName = gagvr::CustomerClientLinkName.FromCustomerCustomerClientLink("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]"),
                ClientCustomer = "client_customerf58ac5fa",
                ManagerLinkId = 1955158851327798968L,
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
                Hidden = true,
            };
            mockGrpcClient.Setup(x => x.GetCustomerClientLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerClientLink response = client.GetCustomerClientLink(request.ResourceNameAsCustomerClientLinkName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerClientLinkResourceNamesAsync()
        {
            moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerClientLinkRequest request = new GetCustomerClientLinkRequest
            {
                ResourceNameAsCustomerClientLinkName = gagvr::CustomerClientLinkName.FromCustomerCustomerClientLink("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]"),
            };
            gagvr::CustomerClientLink expectedResponse = new gagvr::CustomerClientLink
            {
                ResourceNameAsCustomerClientLinkName = gagvr::CustomerClientLinkName.FromCustomerCustomerClientLink("[CUSTOMER]", "[CUSTOMER_CLIENT_LINK]"),
                ClientCustomer = "client_customerf58ac5fa",
                ManagerLinkId = 1955158851327798968L,
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
                Hidden = true,
            };
            mockGrpcClient.Setup(x => x.GetCustomerClientLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerClientLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerClientLink responseCallSettings = await client.GetCustomerClientLinkAsync(request.ResourceNameAsCustomerClientLinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerClientLink responseCancellationToken = await client.GetCustomerClientLinkAsync(request.ResourceNameAsCustomerClientLinkName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomerClientLinkRequestObject()
        {
            moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerClientLinkRequest request = new MutateCustomerClientLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerClientLinkOperation(),
            };
            MutateCustomerClientLinkResponse expectedResponse = new MutateCustomerClientLinkResponse
            {
                Result = new MutateCustomerClientLinkResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerClientLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerClientLinkResponse response = client.MutateCustomerClientLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerClientLinkRequestObjectAsync()
        {
            moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerClientLinkRequest request = new MutateCustomerClientLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerClientLinkOperation(),
            };
            MutateCustomerClientLinkResponse expectedResponse = new MutateCustomerClientLinkResponse
            {
                Result = new MutateCustomerClientLinkResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerClientLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerClientLinkResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerClientLinkResponse responseCallSettings = await client.MutateCustomerClientLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerClientLinkResponse responseCancellationToken = await client.MutateCustomerClientLinkAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomerClientLink()
        {
            moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerClientLinkRequest request = new MutateCustomerClientLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerClientLinkOperation(),
            };
            MutateCustomerClientLinkResponse expectedResponse = new MutateCustomerClientLinkResponse
            {
                Result = new MutateCustomerClientLinkResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerClientLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerClientLinkResponse response = client.MutateCustomerClientLink(request.CustomerId, request.Operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerClientLinkAsync()
        {
            moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerClientLinkRequest request = new MutateCustomerClientLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerClientLinkOperation(),
            };
            MutateCustomerClientLinkResponse expectedResponse = new MutateCustomerClientLinkResponse
            {
                Result = new MutateCustomerClientLinkResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerClientLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerClientLinkResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerClientLinkResponse responseCallSettings = await client.MutateCustomerClientLinkAsync(request.CustomerId, request.Operation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerClientLinkResponse responseCancellationToken = await client.MutateCustomerClientLinkAsync(request.CustomerId, request.Operation, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

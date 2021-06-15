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

using gagve = Google.Ads.GoogleAds.V8.Enums;
using gagvr = Google.Ads.GoogleAds.V8.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V8.Services;

namespace Google.Ads.GoogleAds.Tests.V8.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCustomerManagerLinkServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCustomerManagerLinkRequestObject()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerManagerLinkRequest request = new GetCustomerManagerLinkRequest
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerManagerCustomerManagerLink("[CUSTOMER_ID]", "[MANAGER_CUSTOMER_ID]", "[MANAGER_LINK_ID]"),
            };
            gagvr::CustomerManagerLink expectedResponse = new gagvr::CustomerManagerLink
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerManagerCustomerManagerLink("[CUSTOMER_ID]", "[MANAGER_CUSTOMER_ID]", "[MANAGER_LINK_ID]"),
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
                ManagerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                ManagerLinkId = 1955158851327798968L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerManagerLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerManagerLink response = client.GetCustomerManagerLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerManagerLinkRequestObjectAsync()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerManagerLinkRequest request = new GetCustomerManagerLinkRequest
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerManagerCustomerManagerLink("[CUSTOMER_ID]", "[MANAGER_CUSTOMER_ID]", "[MANAGER_LINK_ID]"),
            };
            gagvr::CustomerManagerLink expectedResponse = new gagvr::CustomerManagerLink
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerManagerCustomerManagerLink("[CUSTOMER_ID]", "[MANAGER_CUSTOMER_ID]", "[MANAGER_LINK_ID]"),
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
                ManagerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                ManagerLinkId = 1955158851327798968L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerManagerLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerManagerLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerManagerLink responseCallSettings = await client.GetCustomerManagerLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerManagerLink responseCancellationToken = await client.GetCustomerManagerLinkAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCustomerManagerLink()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerManagerLinkRequest request = new GetCustomerManagerLinkRequest
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerManagerCustomerManagerLink("[CUSTOMER_ID]", "[MANAGER_CUSTOMER_ID]", "[MANAGER_LINK_ID]"),
            };
            gagvr::CustomerManagerLink expectedResponse = new gagvr::CustomerManagerLink
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerManagerCustomerManagerLink("[CUSTOMER_ID]", "[MANAGER_CUSTOMER_ID]", "[MANAGER_LINK_ID]"),
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
                ManagerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                ManagerLinkId = 1955158851327798968L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerManagerLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerManagerLink response = client.GetCustomerManagerLink(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerManagerLinkAsync()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerManagerLinkRequest request = new GetCustomerManagerLinkRequest
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerManagerCustomerManagerLink("[CUSTOMER_ID]", "[MANAGER_CUSTOMER_ID]", "[MANAGER_LINK_ID]"),
            };
            gagvr::CustomerManagerLink expectedResponse = new gagvr::CustomerManagerLink
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerManagerCustomerManagerLink("[CUSTOMER_ID]", "[MANAGER_CUSTOMER_ID]", "[MANAGER_LINK_ID]"),
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
                ManagerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                ManagerLinkId = 1955158851327798968L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerManagerLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerManagerLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerManagerLink responseCallSettings = await client.GetCustomerManagerLinkAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerManagerLink responseCancellationToken = await client.GetCustomerManagerLinkAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCustomerManagerLinkResourceNames()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerManagerLinkRequest request = new GetCustomerManagerLinkRequest
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerManagerCustomerManagerLink("[CUSTOMER_ID]", "[MANAGER_CUSTOMER_ID]", "[MANAGER_LINK_ID]"),
            };
            gagvr::CustomerManagerLink expectedResponse = new gagvr::CustomerManagerLink
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerManagerCustomerManagerLink("[CUSTOMER_ID]", "[MANAGER_CUSTOMER_ID]", "[MANAGER_LINK_ID]"),
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
                ManagerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                ManagerLinkId = 1955158851327798968L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerManagerLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerManagerLink response = client.GetCustomerManagerLink(request.ResourceNameAsCustomerManagerLinkName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerManagerLinkResourceNamesAsync()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerManagerLinkRequest request = new GetCustomerManagerLinkRequest
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerManagerCustomerManagerLink("[CUSTOMER_ID]", "[MANAGER_CUSTOMER_ID]", "[MANAGER_LINK_ID]"),
            };
            gagvr::CustomerManagerLink expectedResponse = new gagvr::CustomerManagerLink
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerManagerCustomerManagerLink("[CUSTOMER_ID]", "[MANAGER_CUSTOMER_ID]", "[MANAGER_LINK_ID]"),
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
                ManagerCustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER_ID]"),
                ManagerLinkId = 1955158851327798968L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerManagerLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerManagerLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerManagerLink responseCallSettings = await client.GetCustomerManagerLinkAsync(request.ResourceNameAsCustomerManagerLinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerManagerLink responseCancellationToken = await client.GetCustomerManagerLinkAsync(request.ResourceNameAsCustomerManagerLinkName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomerManagerLinkRequestObject()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerManagerLinkRequest request = new MutateCustomerManagerLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerManagerLinkOperation(),
                },
                ValidateOnly = true,
            };
            MutateCustomerManagerLinkResponse expectedResponse = new MutateCustomerManagerLinkResponse
            {
                Results =
                {
                    new MutateCustomerManagerLinkResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomerManagerLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerManagerLinkResponse response = client.MutateCustomerManagerLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerManagerLinkRequestObjectAsync()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerManagerLinkRequest request = new MutateCustomerManagerLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerManagerLinkOperation(),
                },
                ValidateOnly = true,
            };
            MutateCustomerManagerLinkResponse expectedResponse = new MutateCustomerManagerLinkResponse
            {
                Results =
                {
                    new MutateCustomerManagerLinkResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomerManagerLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerManagerLinkResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerManagerLinkResponse responseCallSettings = await client.MutateCustomerManagerLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerManagerLinkResponse responseCancellationToken = await client.MutateCustomerManagerLinkAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomerManagerLink()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerManagerLinkRequest request = new MutateCustomerManagerLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerManagerLinkOperation(),
                },
            };
            MutateCustomerManagerLinkResponse expectedResponse = new MutateCustomerManagerLinkResponse
            {
                Results =
                {
                    new MutateCustomerManagerLinkResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomerManagerLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerManagerLinkResponse response = client.MutateCustomerManagerLink(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerManagerLinkAsync()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerManagerLinkRequest request = new MutateCustomerManagerLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerManagerLinkOperation(),
                },
            };
            MutateCustomerManagerLinkResponse expectedResponse = new MutateCustomerManagerLinkResponse
            {
                Results =
                {
                    new MutateCustomerManagerLinkResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomerManagerLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerManagerLinkResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerManagerLinkResponse responseCallSettings = await client.MutateCustomerManagerLinkAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerManagerLinkResponse responseCancellationToken = await client.MutateCustomerManagerLinkAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MoveManagerLinkRequestObject()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            MoveManagerLinkRequest request = new MoveManagerLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                PreviousCustomerManagerLink = "previous_customer_manager_linkb33a0aa8",
                NewManager = "new_managerbf35b8c4",
                ValidateOnly = true,
            };
            MoveManagerLinkResponse expectedResponse = new MoveManagerLinkResponse
            {
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.MoveManagerLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            MoveManagerLinkResponse response = client.MoveManagerLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MoveManagerLinkRequestObjectAsync()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            MoveManagerLinkRequest request = new MoveManagerLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                PreviousCustomerManagerLink = "previous_customer_manager_linkb33a0aa8",
                NewManager = "new_managerbf35b8c4",
                ValidateOnly = true,
            };
            MoveManagerLinkResponse expectedResponse = new MoveManagerLinkResponse
            {
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.MoveManagerLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MoveManagerLinkResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            MoveManagerLinkResponse responseCallSettings = await client.MoveManagerLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MoveManagerLinkResponse responseCancellationToken = await client.MoveManagerLinkAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MoveManagerLink()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            MoveManagerLinkRequest request = new MoveManagerLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                PreviousCustomerManagerLink = "previous_customer_manager_linkb33a0aa8",
                NewManager = "new_managerbf35b8c4",
            };
            MoveManagerLinkResponse expectedResponse = new MoveManagerLinkResponse
            {
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.MoveManagerLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            MoveManagerLinkResponse response = client.MoveManagerLink(request.CustomerId, request.PreviousCustomerManagerLink, request.NewManager);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MoveManagerLinkAsync()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            MoveManagerLinkRequest request = new MoveManagerLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                PreviousCustomerManagerLink = "previous_customer_manager_linkb33a0aa8",
                NewManager = "new_managerbf35b8c4",
            };
            MoveManagerLinkResponse expectedResponse = new MoveManagerLinkResponse
            {
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.MoveManagerLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MoveManagerLinkResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            MoveManagerLinkResponse responseCallSettings = await client.MoveManagerLinkAsync(request.CustomerId, request.PreviousCustomerManagerLink, request.NewManager, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MoveManagerLinkResponse responseCancellationToken = await client.MoveManagerLinkAsync(request.CustomerId, request.PreviousCustomerManagerLink, request.NewManager, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

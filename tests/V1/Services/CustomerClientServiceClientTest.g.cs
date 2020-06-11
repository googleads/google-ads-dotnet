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
    public sealed class GeneratedCustomerClientServiceClientTest
    {
        [Test]
        public void GetCustomerClientRequestObject()
        {
            moq::Mock<CustomerClientService.CustomerClientServiceClient> mockGrpcClient = new moq::Mock<CustomerClientService.CustomerClientServiceClient>(moq::MockBehavior.Strict);
            GetCustomerClientRequest request = new GetCustomerClientRequest
            {
                ResourceNameAsCustomerClientName = gagvr::CustomerClientName.FromCustomerCustomerClient("[CUSTOMER]", "[CUSTOMER_CLIENT]"),
            };
            gagvr::CustomerClient expectedResponse = new gagvr::CustomerClient
            {
                ResourceNameAsCustomerClientName = gagvr::CustomerClientName.FromCustomerCustomerClient("[CUSTOMER]", "[CUSTOMER_CLIENT]"),
                ClientCustomer = "client_customerf58ac5fa",
                Hidden = true,
                Level = -1767934904342353463L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerClient(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerClientServiceClient client = new CustomerClientServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerClient response = client.GetCustomerClient(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCustomerClientRequestObjectAsync()
        {
            moq::Mock<CustomerClientService.CustomerClientServiceClient> mockGrpcClient = new moq::Mock<CustomerClientService.CustomerClientServiceClient>(moq::MockBehavior.Strict);
            GetCustomerClientRequest request = new GetCustomerClientRequest
            {
                ResourceNameAsCustomerClientName = gagvr::CustomerClientName.FromCustomerCustomerClient("[CUSTOMER]", "[CUSTOMER_CLIENT]"),
            };
            gagvr::CustomerClient expectedResponse = new gagvr::CustomerClient
            {
                ResourceNameAsCustomerClientName = gagvr::CustomerClientName.FromCustomerCustomerClient("[CUSTOMER]", "[CUSTOMER_CLIENT]"),
                ClientCustomer = "client_customerf58ac5fa",
                Hidden = true,
                Level = -1767934904342353463L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerClientAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerClient>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerClientServiceClient client = new CustomerClientServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerClient responseCallSettings = await client.GetCustomerClientAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerClient responseCancellationToken = await client.GetCustomerClientAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCustomerClient()
        {
            moq::Mock<CustomerClientService.CustomerClientServiceClient> mockGrpcClient = new moq::Mock<CustomerClientService.CustomerClientServiceClient>(moq::MockBehavior.Strict);
            GetCustomerClientRequest request = new GetCustomerClientRequest
            {
                ResourceNameAsCustomerClientName = gagvr::CustomerClientName.FromCustomerCustomerClient("[CUSTOMER]", "[CUSTOMER_CLIENT]"),
            };
            gagvr::CustomerClient expectedResponse = new gagvr::CustomerClient
            {
                ResourceNameAsCustomerClientName = gagvr::CustomerClientName.FromCustomerCustomerClient("[CUSTOMER]", "[CUSTOMER_CLIENT]"),
                ClientCustomer = "client_customerf58ac5fa",
                Hidden = true,
                Level = -1767934904342353463L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerClient(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerClientServiceClient client = new CustomerClientServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerClient response = client.GetCustomerClient(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCustomerClientAsync()
        {
            moq::Mock<CustomerClientService.CustomerClientServiceClient> mockGrpcClient = new moq::Mock<CustomerClientService.CustomerClientServiceClient>(moq::MockBehavior.Strict);
            GetCustomerClientRequest request = new GetCustomerClientRequest
            {
                ResourceNameAsCustomerClientName = gagvr::CustomerClientName.FromCustomerCustomerClient("[CUSTOMER]", "[CUSTOMER_CLIENT]"),
            };
            gagvr::CustomerClient expectedResponse = new gagvr::CustomerClient
            {
                ResourceNameAsCustomerClientName = gagvr::CustomerClientName.FromCustomerCustomerClient("[CUSTOMER]", "[CUSTOMER_CLIENT]"),
                ClientCustomer = "client_customerf58ac5fa",
                Hidden = true,
                Level = -1767934904342353463L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerClientAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerClient>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerClientServiceClient client = new CustomerClientServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerClient responseCallSettings = await client.GetCustomerClientAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerClient responseCancellationToken = await client.GetCustomerClientAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCustomerClientResourceNames()
        {
            moq::Mock<CustomerClientService.CustomerClientServiceClient> mockGrpcClient = new moq::Mock<CustomerClientService.CustomerClientServiceClient>(moq::MockBehavior.Strict);
            GetCustomerClientRequest request = new GetCustomerClientRequest
            {
                ResourceNameAsCustomerClientName = gagvr::CustomerClientName.FromCustomerCustomerClient("[CUSTOMER]", "[CUSTOMER_CLIENT]"),
            };
            gagvr::CustomerClient expectedResponse = new gagvr::CustomerClient
            {
                ResourceNameAsCustomerClientName = gagvr::CustomerClientName.FromCustomerCustomerClient("[CUSTOMER]", "[CUSTOMER_CLIENT]"),
                ClientCustomer = "client_customerf58ac5fa",
                Hidden = true,
                Level = -1767934904342353463L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerClient(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerClientServiceClient client = new CustomerClientServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerClient response = client.GetCustomerClient(request.ResourceNameAsCustomerClientName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCustomerClientResourceNamesAsync()
        {
            moq::Mock<CustomerClientService.CustomerClientServiceClient> mockGrpcClient = new moq::Mock<CustomerClientService.CustomerClientServiceClient>(moq::MockBehavior.Strict);
            GetCustomerClientRequest request = new GetCustomerClientRequest
            {
                ResourceNameAsCustomerClientName = gagvr::CustomerClientName.FromCustomerCustomerClient("[CUSTOMER]", "[CUSTOMER_CLIENT]"),
            };
            gagvr::CustomerClient expectedResponse = new gagvr::CustomerClient
            {
                ResourceNameAsCustomerClientName = gagvr::CustomerClientName.FromCustomerCustomerClient("[CUSTOMER]", "[CUSTOMER_CLIENT]"),
                ClientCustomer = "client_customerf58ac5fa",
                Hidden = true,
                Level = -1767934904342353463L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerClientAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerClient>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerClientServiceClient client = new CustomerClientServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerClient responseCallSettings = await client.GetCustomerClientAsync(request.ResourceNameAsCustomerClientName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerClient responseCancellationToken = await client.GetCustomerClientAsync(request.ResourceNameAsCustomerClientName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

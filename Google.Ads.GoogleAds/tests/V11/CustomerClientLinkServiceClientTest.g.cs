// Copyright 2022 Google LLC
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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V11.Services;

namespace Google.Ads.GoogleAds.Tests.V11.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCustomerClientLinkServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateCustomerClientLinkRequestObject()
        {
            moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerClientLinkRequest request = new MutateCustomerClientLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerClientLinkOperation(),
                ValidateOnly = true,
            };
            MutateCustomerClientLinkResponse expectedResponse = new MutateCustomerClientLinkResponse
            {
                Result = new MutateCustomerClientLinkResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerClientLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCustomerClientLinkResponse response = client.MutateCustomerClientLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateCustomerClientLinkRequestObjectAsync()
        {
            moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerClientLinkService.CustomerClientLinkServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerClientLinkRequest request = new MutateCustomerClientLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new CustomerClientLinkOperation(),
                ValidateOnly = true,
            };
            MutateCustomerClientLinkResponse expectedResponse = new MutateCustomerClientLinkResponse
            {
                Result = new MutateCustomerClientLinkResult(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerClientLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerClientLinkResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCustomerClientLinkResponse responseCallSettings = await client.MutateCustomerClientLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerClientLinkResponse responseCancellationToken = await client.MutateCustomerClientLinkAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
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
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCustomerClientLinkResponse response = client.MutateCustomerClientLink(request.CustomerId, request.Operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
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
            CustomerClientLinkServiceClient client = new CustomerClientLinkServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCustomerClientLinkResponse responseCallSettings = await client.MutateCustomerClientLinkAsync(request.CustomerId, request.Operation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerClientLinkResponse responseCancellationToken = await client.MutateCustomerClientLinkAsync(request.CustomerId, request.Operation, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

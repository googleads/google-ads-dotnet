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

using gagvr = Google.Ads.GoogleAds.V4.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V4.Services;

namespace Google.Ads.GoogleAds.Tests.V4.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCustomerLabelServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCustomerLabelRequestObject()
        {
            moq::Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new moq::Mock<CustomerLabelService.CustomerLabelServiceClient>(moq::MockBehavior.Strict);
            GetCustomerLabelRequest request = new GetCustomerLabelRequest
            {
                ResourceNameAsCustomerLabelName = gagvr::CustomerLabelName.FromCustomerCustomerLabel("[CUSTOMER]", "[CUSTOMER_LABEL]"),
            };
            gagvr::CustomerLabel expectedResponse = new gagvr::CustomerLabel
            {
                ResourceNameAsCustomerLabelName = gagvr::CustomerLabelName.FromCustomerCustomerLabel("[CUSTOMER]", "[CUSTOMER_LABEL]"),
                CustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetCustomerLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerLabel response = client.GetCustomerLabel(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerLabelRequestObjectAsync()
        {
            moq::Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new moq::Mock<CustomerLabelService.CustomerLabelServiceClient>(moq::MockBehavior.Strict);
            GetCustomerLabelRequest request = new GetCustomerLabelRequest
            {
                ResourceNameAsCustomerLabelName = gagvr::CustomerLabelName.FromCustomerCustomerLabel("[CUSTOMER]", "[CUSTOMER_LABEL]"),
            };
            gagvr::CustomerLabel expectedResponse = new gagvr::CustomerLabel
            {
                ResourceNameAsCustomerLabelName = gagvr::CustomerLabelName.FromCustomerCustomerLabel("[CUSTOMER]", "[CUSTOMER_LABEL]"),
                CustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetCustomerLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerLabel responseCallSettings = await client.GetCustomerLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerLabel responseCancellationToken = await client.GetCustomerLabelAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCustomerLabel()
        {
            moq::Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new moq::Mock<CustomerLabelService.CustomerLabelServiceClient>(moq::MockBehavior.Strict);
            GetCustomerLabelRequest request = new GetCustomerLabelRequest
            {
                ResourceNameAsCustomerLabelName = gagvr::CustomerLabelName.FromCustomerCustomerLabel("[CUSTOMER]", "[CUSTOMER_LABEL]"),
            };
            gagvr::CustomerLabel expectedResponse = new gagvr::CustomerLabel
            {
                ResourceNameAsCustomerLabelName = gagvr::CustomerLabelName.FromCustomerCustomerLabel("[CUSTOMER]", "[CUSTOMER_LABEL]"),
                CustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetCustomerLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerLabel response = client.GetCustomerLabel(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerLabelAsync()
        {
            moq::Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new moq::Mock<CustomerLabelService.CustomerLabelServiceClient>(moq::MockBehavior.Strict);
            GetCustomerLabelRequest request = new GetCustomerLabelRequest
            {
                ResourceNameAsCustomerLabelName = gagvr::CustomerLabelName.FromCustomerCustomerLabel("[CUSTOMER]", "[CUSTOMER_LABEL]"),
            };
            gagvr::CustomerLabel expectedResponse = new gagvr::CustomerLabel
            {
                ResourceNameAsCustomerLabelName = gagvr::CustomerLabelName.FromCustomerCustomerLabel("[CUSTOMER]", "[CUSTOMER_LABEL]"),
                CustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetCustomerLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerLabel responseCallSettings = await client.GetCustomerLabelAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerLabel responseCancellationToken = await client.GetCustomerLabelAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCustomerLabelResourceNames()
        {
            moq::Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new moq::Mock<CustomerLabelService.CustomerLabelServiceClient>(moq::MockBehavior.Strict);
            GetCustomerLabelRequest request = new GetCustomerLabelRequest
            {
                ResourceNameAsCustomerLabelName = gagvr::CustomerLabelName.FromCustomerCustomerLabel("[CUSTOMER]", "[CUSTOMER_LABEL]"),
            };
            gagvr::CustomerLabel expectedResponse = new gagvr::CustomerLabel
            {
                ResourceNameAsCustomerLabelName = gagvr::CustomerLabelName.FromCustomerCustomerLabel("[CUSTOMER]", "[CUSTOMER_LABEL]"),
                CustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetCustomerLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerLabel response = client.GetCustomerLabel(request.ResourceNameAsCustomerLabelName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerLabelResourceNamesAsync()
        {
            moq::Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new moq::Mock<CustomerLabelService.CustomerLabelServiceClient>(moq::MockBehavior.Strict);
            GetCustomerLabelRequest request = new GetCustomerLabelRequest
            {
                ResourceNameAsCustomerLabelName = gagvr::CustomerLabelName.FromCustomerCustomerLabel("[CUSTOMER]", "[CUSTOMER_LABEL]"),
            };
            gagvr::CustomerLabel expectedResponse = new gagvr::CustomerLabel
            {
                ResourceNameAsCustomerLabelName = gagvr::CustomerLabelName.FromCustomerCustomerLabel("[CUSTOMER]", "[CUSTOMER_LABEL]"),
                CustomerAsCustomerName = gagvr::CustomerName.FromCustomer("[CUSTOMER]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetCustomerLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerLabel responseCallSettings = await client.GetCustomerLabelAsync(request.ResourceNameAsCustomerLabelName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerLabel responseCancellationToken = await client.GetCustomerLabelAsync(request.ResourceNameAsCustomerLabelName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomerLabelsRequestObject()
        {
            moq::Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new moq::Mock<CustomerLabelService.CustomerLabelServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerLabelsRequest request = new MutateCustomerLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCustomerLabelsResponse expectedResponse = new MutateCustomerLabelsResponse
            {
                Results =
                {
                    new MutateCustomerLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerLabelsResponse response = client.MutateCustomerLabels(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerLabelsRequestObjectAsync()
        {
            moq::Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new moq::Mock<CustomerLabelService.CustomerLabelServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerLabelsRequest request = new MutateCustomerLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCustomerLabelsResponse expectedResponse = new MutateCustomerLabelsResponse
            {
                Results =
                {
                    new MutateCustomerLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerLabelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerLabelsResponse responseCallSettings = await client.MutateCustomerLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerLabelsResponse responseCancellationToken = await client.MutateCustomerLabelsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomerLabels()
        {
            moq::Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new moq::Mock<CustomerLabelService.CustomerLabelServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerLabelsRequest request = new MutateCustomerLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerLabelOperation(),
                },
            };
            MutateCustomerLabelsResponse expectedResponse = new MutateCustomerLabelsResponse
            {
                Results =
                {
                    new MutateCustomerLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerLabelsResponse response = client.MutateCustomerLabels(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerLabelsAsync()
        {
            moq::Mock<CustomerLabelService.CustomerLabelServiceClient> mockGrpcClient = new moq::Mock<CustomerLabelService.CustomerLabelServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerLabelsRequest request = new MutateCustomerLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerLabelOperation(),
                },
            };
            MutateCustomerLabelsResponse expectedResponse = new MutateCustomerLabelsResponse
            {
                Results =
                {
                    new MutateCustomerLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerLabelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerLabelServiceClient client = new CustomerLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerLabelsResponse responseCallSettings = await client.MutateCustomerLabelsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerLabelsResponse responseCancellationToken = await client.MutateCustomerLabelsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

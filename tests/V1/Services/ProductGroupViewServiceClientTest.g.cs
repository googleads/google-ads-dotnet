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
    public sealed class GeneratedProductGroupViewServiceClientTest
    {
        [Test]
        public void GetProductGroupViewRequestObject()
        {
            moq::Mock<ProductGroupViewService.ProductGroupViewServiceClient> mockGrpcClient = new moq::Mock<ProductGroupViewService.ProductGroupViewServiceClient>(moq::MockBehavior.Strict);
            GetProductGroupViewRequest request = new GetProductGroupViewRequest
            {
                ResourceNameAsProductGroupViewName = gagvr::ProductGroupViewName.FromCustomerProductGroupView("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]"),
            };
            gagvr::ProductGroupView expectedResponse = new gagvr::ProductGroupView
            {
                ResourceNameAsProductGroupViewName = gagvr::ProductGroupViewName.FromCustomerProductGroupView("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetProductGroupView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductGroupViewServiceClient client = new ProductGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ProductGroupView response = client.GetProductGroupView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetProductGroupViewRequestObjectAsync()
        {
            moq::Mock<ProductGroupViewService.ProductGroupViewServiceClient> mockGrpcClient = new moq::Mock<ProductGroupViewService.ProductGroupViewServiceClient>(moq::MockBehavior.Strict);
            GetProductGroupViewRequest request = new GetProductGroupViewRequest
            {
                ResourceNameAsProductGroupViewName = gagvr::ProductGroupViewName.FromCustomerProductGroupView("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]"),
            };
            gagvr::ProductGroupView expectedResponse = new gagvr::ProductGroupView
            {
                ResourceNameAsProductGroupViewName = gagvr::ProductGroupViewName.FromCustomerProductGroupView("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetProductGroupViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ProductGroupView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductGroupViewServiceClient client = new ProductGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ProductGroupView responseCallSettings = await client.GetProductGroupViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ProductGroupView responseCancellationToken = await client.GetProductGroupViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetProductGroupView()
        {
            moq::Mock<ProductGroupViewService.ProductGroupViewServiceClient> mockGrpcClient = new moq::Mock<ProductGroupViewService.ProductGroupViewServiceClient>(moq::MockBehavior.Strict);
            GetProductGroupViewRequest request = new GetProductGroupViewRequest
            {
                ResourceNameAsProductGroupViewName = gagvr::ProductGroupViewName.FromCustomerProductGroupView("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]"),
            };
            gagvr::ProductGroupView expectedResponse = new gagvr::ProductGroupView
            {
                ResourceNameAsProductGroupViewName = gagvr::ProductGroupViewName.FromCustomerProductGroupView("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetProductGroupView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductGroupViewServiceClient client = new ProductGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ProductGroupView response = client.GetProductGroupView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetProductGroupViewAsync()
        {
            moq::Mock<ProductGroupViewService.ProductGroupViewServiceClient> mockGrpcClient = new moq::Mock<ProductGroupViewService.ProductGroupViewServiceClient>(moq::MockBehavior.Strict);
            GetProductGroupViewRequest request = new GetProductGroupViewRequest
            {
                ResourceNameAsProductGroupViewName = gagvr::ProductGroupViewName.FromCustomerProductGroupView("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]"),
            };
            gagvr::ProductGroupView expectedResponse = new gagvr::ProductGroupView
            {
                ResourceNameAsProductGroupViewName = gagvr::ProductGroupViewName.FromCustomerProductGroupView("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetProductGroupViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ProductGroupView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductGroupViewServiceClient client = new ProductGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ProductGroupView responseCallSettings = await client.GetProductGroupViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ProductGroupView responseCancellationToken = await client.GetProductGroupViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetProductGroupViewResourceNames()
        {
            moq::Mock<ProductGroupViewService.ProductGroupViewServiceClient> mockGrpcClient = new moq::Mock<ProductGroupViewService.ProductGroupViewServiceClient>(moq::MockBehavior.Strict);
            GetProductGroupViewRequest request = new GetProductGroupViewRequest
            {
                ResourceNameAsProductGroupViewName = gagvr::ProductGroupViewName.FromCustomerProductGroupView("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]"),
            };
            gagvr::ProductGroupView expectedResponse = new gagvr::ProductGroupView
            {
                ResourceNameAsProductGroupViewName = gagvr::ProductGroupViewName.FromCustomerProductGroupView("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetProductGroupView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductGroupViewServiceClient client = new ProductGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ProductGroupView response = client.GetProductGroupView(request.ResourceNameAsProductGroupViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetProductGroupViewResourceNamesAsync()
        {
            moq::Mock<ProductGroupViewService.ProductGroupViewServiceClient> mockGrpcClient = new moq::Mock<ProductGroupViewService.ProductGroupViewServiceClient>(moq::MockBehavior.Strict);
            GetProductGroupViewRequest request = new GetProductGroupViewRequest
            {
                ResourceNameAsProductGroupViewName = gagvr::ProductGroupViewName.FromCustomerProductGroupView("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]"),
            };
            gagvr::ProductGroupView expectedResponse = new gagvr::ProductGroupView
            {
                ResourceNameAsProductGroupViewName = gagvr::ProductGroupViewName.FromCustomerProductGroupView("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetProductGroupViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ProductGroupView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductGroupViewServiceClient client = new ProductGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ProductGroupView responseCallSettings = await client.GetProductGroupViewAsync(request.ResourceNameAsProductGroupViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ProductGroupView responseCancellationToken = await client.GetProductGroupViewAsync(request.ResourceNameAsProductGroupViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

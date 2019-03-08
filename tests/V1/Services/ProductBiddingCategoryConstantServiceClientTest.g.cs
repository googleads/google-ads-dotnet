// Copyright 2019 Google LLC
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

namespace Google.Ads.GoogleAds.V1.Services.Tests
{
    using Google.Ads.GoogleAds.V1.Resources;
    using apis = Google.Ads.GoogleAds.V1.Services;
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using NUnit.Framework;

    /// <summary>Generated unit tests</summary>
    public class GeneratedProductBiddingCategoryConstantServiceClientTest
    {
        [Test]
        public void GetProductBiddingCategoryConstant()
        {
            Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient> mockGrpcClient = new Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient>(MockBehavior.Strict);
            GetProductBiddingCategoryConstantRequest expectedRequest = new GetProductBiddingCategoryConstantRequest
            {
                ResourceName = new ProductBiddingCategoryConstantName("[PRODUCT_BIDDING_CATEGORY_CONSTANT]").ToString(),
            };
            ProductBiddingCategoryConstant expectedResponse = new ProductBiddingCategoryConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetProductBiddingCategoryConstant(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductBiddingCategoryConstantServiceClient client = new ProductBiddingCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ProductBiddingCategoryConstantName("[PRODUCT_BIDDING_CATEGORY_CONSTANT]").ToString();
            ProductBiddingCategoryConstant response = client.GetProductBiddingCategoryConstant(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetProductBiddingCategoryConstantAsync()
        {
            Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient> mockGrpcClient = new Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient>(MockBehavior.Strict);
            GetProductBiddingCategoryConstantRequest expectedRequest = new GetProductBiddingCategoryConstantRequest
            {
                ResourceName = new ProductBiddingCategoryConstantName("[PRODUCT_BIDDING_CATEGORY_CONSTANT]").ToString(),
            };
            ProductBiddingCategoryConstant expectedResponse = new ProductBiddingCategoryConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetProductBiddingCategoryConstantAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ProductBiddingCategoryConstant>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductBiddingCategoryConstantServiceClient client = new ProductBiddingCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ProductBiddingCategoryConstantName("[PRODUCT_BIDDING_CATEGORY_CONSTANT]").ToString();
            ProductBiddingCategoryConstant response = await client.GetProductBiddingCategoryConstantAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetProductBiddingCategoryConstant2()
        {
            Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient> mockGrpcClient = new Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient>(MockBehavior.Strict);
            GetProductBiddingCategoryConstantRequest request = new GetProductBiddingCategoryConstantRequest
            {
                ResourceName = new ProductBiddingCategoryConstantName("[PRODUCT_BIDDING_CATEGORY_CONSTANT]").ToString(),
            };
            ProductBiddingCategoryConstant expectedResponse = new ProductBiddingCategoryConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetProductBiddingCategoryConstant(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductBiddingCategoryConstantServiceClient client = new ProductBiddingCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            ProductBiddingCategoryConstant response = client.GetProductBiddingCategoryConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetProductBiddingCategoryConstantAsync2()
        {
            Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient> mockGrpcClient = new Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient>(MockBehavior.Strict);
            GetProductBiddingCategoryConstantRequest request = new GetProductBiddingCategoryConstantRequest
            {
                ResourceName = new ProductBiddingCategoryConstantName("[PRODUCT_BIDDING_CATEGORY_CONSTANT]").ToString(),
            };
            ProductBiddingCategoryConstant expectedResponse = new ProductBiddingCategoryConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetProductBiddingCategoryConstantAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ProductBiddingCategoryConstant>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductBiddingCategoryConstantServiceClient client = new ProductBiddingCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            ProductBiddingCategoryConstant response = await client.GetProductBiddingCategoryConstantAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

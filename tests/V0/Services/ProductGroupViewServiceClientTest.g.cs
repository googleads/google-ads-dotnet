// Copyright 2018 Google LLC
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

// TODO( b/119694056): Removed Comment

namespace Google.Ads.GoogleAds.V0.Services.Tests
{
    using Google.Ads.GoogleAds.V0.Resources;
    using apis = Google.Ads.GoogleAds.V0.Services;
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
    public class GeneratedProductGroupViewServiceClientTest
    {
        [Test]
        public void GetProductGroupView()
        {
            Mock<ProductGroupViewService.ProductGroupViewServiceClient> mockGrpcClient = new Mock<ProductGroupViewService.ProductGroupViewServiceClient>(MockBehavior.Strict);
            GetProductGroupViewRequest expectedRequest = new GetProductGroupViewRequest
            {
                ResourceName = new ProductGroupViewName("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]").ToString(),
            };
            ProductGroupView expectedResponse = new ProductGroupView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetProductGroupView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductGroupViewServiceClient client = new ProductGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ProductGroupViewName("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]").ToString();
            ProductGroupView response = client.GetProductGroupView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetProductGroupViewAsync()
        {
            Mock<ProductGroupViewService.ProductGroupViewServiceClient> mockGrpcClient = new Mock<ProductGroupViewService.ProductGroupViewServiceClient>(MockBehavior.Strict);
            GetProductGroupViewRequest expectedRequest = new GetProductGroupViewRequest
            {
                ResourceName = new ProductGroupViewName("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]").ToString(),
            };
            ProductGroupView expectedResponse = new ProductGroupView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetProductGroupViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ProductGroupView>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductGroupViewServiceClient client = new ProductGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ProductGroupViewName("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]").ToString();
            ProductGroupView response = await client.GetProductGroupViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetProductGroupView2()
        {
            Mock<ProductGroupViewService.ProductGroupViewServiceClient> mockGrpcClient = new Mock<ProductGroupViewService.ProductGroupViewServiceClient>(MockBehavior.Strict);
            GetProductGroupViewRequest request = new GetProductGroupViewRequest
            {
                ResourceName = new ProductGroupViewName("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]").ToString(),
            };
            ProductGroupView expectedResponse = new ProductGroupView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetProductGroupView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ProductGroupViewServiceClient client = new ProductGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            ProductGroupView response = client.GetProductGroupView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetProductGroupViewAsync2()
        {
            Mock<ProductGroupViewService.ProductGroupViewServiceClient> mockGrpcClient = new Mock<ProductGroupViewService.ProductGroupViewServiceClient>(MockBehavior.Strict);
            GetProductGroupViewRequest request = new GetProductGroupViewRequest
            {
                ResourceName = new ProductGroupViewName("[CUSTOMER]", "[PRODUCT_GROUP_VIEW]").ToString(),
            };
            ProductGroupView expectedResponse = new ProductGroupView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetProductGroupViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ProductGroupView>(Task.FromResult(expectedResponse), null, null, null, null));
            ProductGroupViewServiceClient client = new ProductGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            ProductGroupView response = await client.GetProductGroupViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

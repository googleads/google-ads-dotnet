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

namespace Google.Ads.GoogleAds.V2.Services.Tests
{
    using Google.Ads.GoogleAds.V2.Resources;
    using apis = Google.Ads.GoogleAds.V2.Services;
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
    public class GeneratedDomainCategoryServiceClientTest
    {
        [Test]
        public void GetDomainCategory()
        {
            Mock<DomainCategoryService.DomainCategoryServiceClient> mockGrpcClient = new Mock<DomainCategoryService.DomainCategoryServiceClient>(MockBehavior.Strict);
            GetDomainCategoryRequest expectedRequest = new GetDomainCategoryRequest
            {
                ResourceName = new DomainCategoryName("[CUSTOMER]", "[DOMAIN_CATEGORY]").ToString(),
            };
            DomainCategory expectedResponse = new DomainCategory
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDomainCategory(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DomainCategoryServiceClient client = new DomainCategoryServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new DomainCategoryName("[CUSTOMER]", "[DOMAIN_CATEGORY]").ToString();
            DomainCategory response = client.GetDomainCategory(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetDomainCategoryAsync()
        {
            Mock<DomainCategoryService.DomainCategoryServiceClient> mockGrpcClient = new Mock<DomainCategoryService.DomainCategoryServiceClient>(MockBehavior.Strict);
            GetDomainCategoryRequest expectedRequest = new GetDomainCategoryRequest
            {
                ResourceName = new DomainCategoryName("[CUSTOMER]", "[DOMAIN_CATEGORY]").ToString(),
            };
            DomainCategory expectedResponse = new DomainCategory
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDomainCategoryAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DomainCategory>(Task.FromResult(expectedResponse), null, null, null, null));
            DomainCategoryServiceClient client = new DomainCategoryServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new DomainCategoryName("[CUSTOMER]", "[DOMAIN_CATEGORY]").ToString();
            DomainCategory response = await client.GetDomainCategoryAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetDomainCategory2()
        {
            Mock<DomainCategoryService.DomainCategoryServiceClient> mockGrpcClient = new Mock<DomainCategoryService.DomainCategoryServiceClient>(MockBehavior.Strict);
            GetDomainCategoryRequest request = new GetDomainCategoryRequest
            {
                ResourceName = new DomainCategoryName("[CUSTOMER]", "[DOMAIN_CATEGORY]").ToString(),
            };
            DomainCategory expectedResponse = new DomainCategory
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDomainCategory(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            DomainCategoryServiceClient client = new DomainCategoryServiceClientImpl(mockGrpcClient.Object, null);
            DomainCategory response = client.GetDomainCategory(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetDomainCategoryAsync2()
        {
            Mock<DomainCategoryService.DomainCategoryServiceClient> mockGrpcClient = new Mock<DomainCategoryService.DomainCategoryServiceClient>(MockBehavior.Strict);
            GetDomainCategoryRequest request = new GetDomainCategoryRequest
            {
                ResourceName = new DomainCategoryName("[CUSTOMER]", "[DOMAIN_CATEGORY]").ToString(),
            };
            DomainCategory expectedResponse = new DomainCategory
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetDomainCategoryAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DomainCategory>(Task.FromResult(expectedResponse), null, null, null, null));
            DomainCategoryServiceClient client = new DomainCategoryServiceClientImpl(mockGrpcClient.Object, null);
            DomainCategory response = await client.GetDomainCategoryAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

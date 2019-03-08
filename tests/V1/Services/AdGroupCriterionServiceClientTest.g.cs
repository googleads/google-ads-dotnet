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
    public class GeneratedAdGroupCriterionServiceClientTest
    {
        [Test]
        public void GetAdGroupCriterion()
        {
            Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(MockBehavior.Strict);
            GetAdGroupCriterionRequest expectedRequest = new GetAdGroupCriterionRequest
            {
                ResourceName = new AdGroupCriteriaName("[CUSTOMER]", "[AD_GROUP_CRITERIA]").ToString(),
            };
            AdGroupCriterion expectedResponse = new AdGroupCriterion
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupCriteriaName("[CUSTOMER]", "[AD_GROUP_CRITERIA]").ToString();
            AdGroupCriterion response = client.GetAdGroupCriterion(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupCriterionAsync()
        {
            Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(MockBehavior.Strict);
            GetAdGroupCriterionRequest expectedRequest = new GetAdGroupCriterionRequest
            {
                ResourceName = new AdGroupCriteriaName("[CUSTOMER]", "[AD_GROUP_CRITERIA]").ToString(),
            };
            AdGroupCriterion expectedResponse = new AdGroupCriterion
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupCriterion>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupCriteriaName("[CUSTOMER]", "[AD_GROUP_CRITERIA]").ToString();
            AdGroupCriterion response = await client.GetAdGroupCriterionAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroupCriterion2()
        {
            Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(MockBehavior.Strict);
            GetAdGroupCriterionRequest request = new GetAdGroupCriterionRequest
            {
                ResourceName = new AdGroupCriteriaName("[CUSTOMER]", "[AD_GROUP_CRITERIA]").ToString(),
            };
            AdGroupCriterion expectedResponse = new AdGroupCriterion
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupCriterion response = client.GetAdGroupCriterion(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupCriterionAsync2()
        {
            Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(MockBehavior.Strict);
            GetAdGroupCriterionRequest request = new GetAdGroupCriterionRequest
            {
                ResourceName = new AdGroupCriteriaName("[CUSTOMER]", "[AD_GROUP_CRITERIA]").ToString(),
            };
            AdGroupCriterion expectedResponse = new AdGroupCriterion
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupCriterion>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupCriterion response = await client.GetAdGroupCriterionAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupCriteria()
        {
            Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(MockBehavior.Strict);
            MutateAdGroupCriteriaRequest expectedRequest = new MutateAdGroupCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdGroupCriteriaResponse expectedResponse = new MutateAdGroupCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupCriteria(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupCriterionOperation> operations = new List<AdGroupCriterionOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdGroupCriteriaResponse response = client.MutateAdGroupCriteria(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupCriteriaAsync()
        {
            Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(MockBehavior.Strict);
            MutateAdGroupCriteriaRequest expectedRequest = new MutateAdGroupCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdGroupCriteriaResponse expectedResponse = new MutateAdGroupCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupCriteriaAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupCriteriaResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupCriterionOperation> operations = new List<AdGroupCriterionOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdGroupCriteriaResponse response = await client.MutateAdGroupCriteriaAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupCriteria2()
        {
            Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(MockBehavior.Strict);
            MutateAdGroupCriteriaRequest expectedRequest = new MutateAdGroupCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupCriteriaResponse expectedResponse = new MutateAdGroupCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupCriteria(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupCriterionOperation> operations = new List<AdGroupCriterionOperation>();
            MutateAdGroupCriteriaResponse response = client.MutateAdGroupCriteria(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupCriteriaAsync2()
        {
            Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(MockBehavior.Strict);
            MutateAdGroupCriteriaRequest expectedRequest = new MutateAdGroupCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupCriteriaResponse expectedResponse = new MutateAdGroupCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupCriteriaAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupCriteriaResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupCriterionOperation> operations = new List<AdGroupCriterionOperation>();
            MutateAdGroupCriteriaResponse response = await client.MutateAdGroupCriteriaAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupCriteria3()
        {
            Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(MockBehavior.Strict);
            MutateAdGroupCriteriaRequest request = new MutateAdGroupCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupCriteriaResponse expectedResponse = new MutateAdGroupCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupCriteria(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriteriaResponse response = client.MutateAdGroupCriteria(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupCriteriaAsync3()
        {
            Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(MockBehavior.Strict);
            MutateAdGroupCriteriaRequest request = new MutateAdGroupCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupCriteriaResponse expectedResponse = new MutateAdGroupCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupCriteriaAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupCriteriaResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriteriaResponse response = await client.MutateAdGroupCriteriaAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

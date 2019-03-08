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
    public class GeneratedSharedCriterionServiceClientTest
    {
        [Test]
        public void GetSharedCriterion()
        {
            Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new Mock<SharedCriterionService.SharedCriterionServiceClient>(MockBehavior.Strict);
            GetSharedCriterionRequest expectedRequest = new GetSharedCriterionRequest
            {
                ResourceName = new SharedCriteriaName("[CUSTOMER]", "[SHARED_CRITERIA]").ToString(),
            };
            SharedCriterion expectedResponse = new SharedCriterion
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetSharedCriterion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new SharedCriteriaName("[CUSTOMER]", "[SHARED_CRITERIA]").ToString();
            SharedCriterion response = client.GetSharedCriterion(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetSharedCriterionAsync()
        {
            Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new Mock<SharedCriterionService.SharedCriterionServiceClient>(MockBehavior.Strict);
            GetSharedCriterionRequest expectedRequest = new GetSharedCriterionRequest
            {
                ResourceName = new SharedCriteriaName("[CUSTOMER]", "[SHARED_CRITERIA]").ToString(),
            };
            SharedCriterion expectedResponse = new SharedCriterion
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetSharedCriterionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SharedCriterion>(Task.FromResult(expectedResponse), null, null, null, null));
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new SharedCriteriaName("[CUSTOMER]", "[SHARED_CRITERIA]").ToString();
            SharedCriterion response = await client.GetSharedCriterionAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetSharedCriterion2()
        {
            Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new Mock<SharedCriterionService.SharedCriterionServiceClient>(MockBehavior.Strict);
            GetSharedCriterionRequest request = new GetSharedCriterionRequest
            {
                ResourceName = new SharedCriteriaName("[CUSTOMER]", "[SHARED_CRITERIA]").ToString(),
            };
            SharedCriterion expectedResponse = new SharedCriterion
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetSharedCriterion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            SharedCriterion response = client.GetSharedCriterion(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetSharedCriterionAsync2()
        {
            Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new Mock<SharedCriterionService.SharedCriterionServiceClient>(MockBehavior.Strict);
            GetSharedCriterionRequest request = new GetSharedCriterionRequest
            {
                ResourceName = new SharedCriteriaName("[CUSTOMER]", "[SHARED_CRITERIA]").ToString(),
            };
            SharedCriterion expectedResponse = new SharedCriterion
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetSharedCriterionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SharedCriterion>(Task.FromResult(expectedResponse), null, null, null, null));
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            SharedCriterion response = await client.GetSharedCriterionAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateSharedCriteria()
        {
            Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new Mock<SharedCriterionService.SharedCriterionServiceClient>(MockBehavior.Strict);
            MutateSharedCriteriaRequest expectedRequest = new MutateSharedCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateSharedCriteriaResponse expectedResponse = new MutateSharedCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateSharedCriteria(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<SharedCriterionOperation> operations = new List<SharedCriterionOperation>();
            MutateSharedCriteriaResponse response = client.MutateSharedCriteria(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateSharedCriteriaAsync()
        {
            Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new Mock<SharedCriterionService.SharedCriterionServiceClient>(MockBehavior.Strict);
            MutateSharedCriteriaRequest expectedRequest = new MutateSharedCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateSharedCriteriaResponse expectedResponse = new MutateSharedCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateSharedCriteriaAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateSharedCriteriaResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<SharedCriterionOperation> operations = new List<SharedCriterionOperation>();
            MutateSharedCriteriaResponse response = await client.MutateSharedCriteriaAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateSharedCriteria2()
        {
            Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new Mock<SharedCriterionService.SharedCriterionServiceClient>(MockBehavior.Strict);
            MutateSharedCriteriaRequest request = new MutateSharedCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateSharedCriteriaResponse expectedResponse = new MutateSharedCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateSharedCriteria(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateSharedCriteriaResponse response = client.MutateSharedCriteria(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateSharedCriteriaAsync2()
        {
            Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new Mock<SharedCriterionService.SharedCriterionServiceClient>(MockBehavior.Strict);
            MutateSharedCriteriaRequest request = new MutateSharedCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateSharedCriteriaResponse expectedResponse = new MutateSharedCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateSharedCriteriaAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateSharedCriteriaResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateSharedCriteriaResponse response = await client.MutateSharedCriteriaAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

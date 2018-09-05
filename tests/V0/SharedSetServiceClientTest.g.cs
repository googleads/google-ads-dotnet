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

// Generated code. DO NOT EDIT!

namespace Google.Ads.GoogleAds.V0.Services.Tests
{
    using Google.Ads.GoogleAds.V0.Resources;
    using Google.Ads.GoogleAds.V0.Services;
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
    public class GeneratedSharedSetServiceClientTest
    {
        [Test]
        public void GetSharedSet()
        {
            Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new Mock<SharedSetService.SharedSetServiceClient>(MockBehavior.Strict);
            GetSharedSetRequest expectedRequest = new GetSharedSetRequest
            {
                ResourceName = new SharedSetName("[CUSTOMER]", "[SHARED_SET]").ToString(),
            };
            SharedSet expectedResponse = new SharedSet
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetSharedSet(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new SharedSetName("[CUSTOMER]", "[SHARED_SET]").ToString();
            SharedSet response = client.GetSharedSet(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetSharedSetAsync()
        {
            Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new Mock<SharedSetService.SharedSetServiceClient>(MockBehavior.Strict);
            GetSharedSetRequest expectedRequest = new GetSharedSetRequest
            {
                ResourceName = new SharedSetName("[CUSTOMER]", "[SHARED_SET]").ToString(),
            };
            SharedSet expectedResponse = new SharedSet
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetSharedSetAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SharedSet>(Task.FromResult(expectedResponse), null, null, null, null));
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new SharedSetName("[CUSTOMER]", "[SHARED_SET]").ToString();
            SharedSet response = await client.GetSharedSetAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetSharedSet2()
        {
            Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new Mock<SharedSetService.SharedSetServiceClient>(MockBehavior.Strict);
            GetSharedSetRequest request = new GetSharedSetRequest
            {
                ResourceName = new SharedSetName("[CUSTOMER]", "[SHARED_SET]").ToString(),
            };
            SharedSet expectedResponse = new SharedSet
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetSharedSet(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            SharedSet response = client.GetSharedSet(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetSharedSetAsync2()
        {
            Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new Mock<SharedSetService.SharedSetServiceClient>(MockBehavior.Strict);
            GetSharedSetRequest request = new GetSharedSetRequest
            {
                ResourceName = new SharedSetName("[CUSTOMER]", "[SHARED_SET]").ToString(),
            };
            SharedSet expectedResponse = new SharedSet
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetSharedSetAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SharedSet>(Task.FromResult(expectedResponse), null, null, null, null));
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            SharedSet response = await client.GetSharedSetAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateSharedSets()
        {
            Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new Mock<SharedSetService.SharedSetServiceClient>(MockBehavior.Strict);
            MutateSharedSetsRequest expectedRequest = new MutateSharedSetsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateSharedSetsResponse expectedResponse = new MutateSharedSetsResponse();
            mockGrpcClient.Setup(x => x.MutateSharedSets(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<SharedSetOperation> operations = new List<SharedSetOperation>();
            MutateSharedSetsResponse response = client.MutateSharedSets(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateSharedSetsAsync()
        {
            Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new Mock<SharedSetService.SharedSetServiceClient>(MockBehavior.Strict);
            MutateSharedSetsRequest expectedRequest = new MutateSharedSetsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateSharedSetsResponse expectedResponse = new MutateSharedSetsResponse();
            mockGrpcClient.Setup(x => x.MutateSharedSetsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateSharedSetsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<SharedSetOperation> operations = new List<SharedSetOperation>();
            MutateSharedSetsResponse response = await client.MutateSharedSetsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateSharedSets2()
        {
            Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new Mock<SharedSetService.SharedSetServiceClient>(MockBehavior.Strict);
            MutateSharedSetsRequest request = new MutateSharedSetsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateSharedSetsResponse expectedResponse = new MutateSharedSetsResponse();
            mockGrpcClient.Setup(x => x.MutateSharedSets(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateSharedSetsResponse response = client.MutateSharedSets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateSharedSetsAsync2()
        {
            Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new Mock<SharedSetService.SharedSetServiceClient>(MockBehavior.Strict);
            MutateSharedSetsRequest request = new MutateSharedSetsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateSharedSetsResponse expectedResponse = new MutateSharedSetsResponse();
            mockGrpcClient.Setup(x => x.MutateSharedSetsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateSharedSetsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateSharedSetsResponse response = await client.MutateSharedSetsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

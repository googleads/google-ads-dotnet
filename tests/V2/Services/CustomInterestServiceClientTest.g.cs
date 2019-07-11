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
    public class GeneratedCustomInterestServiceClientTest
    {
        [Test]
        public void GetCustomInterest()
        {
            Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new Mock<CustomInterestService.CustomInterestServiceClient>(MockBehavior.Strict);
            GetCustomInterestRequest expectedRequest = new GetCustomInterestRequest
            {
                ResourceName = new CustomInterestName("[CUSTOMER]", "[CUSTOM_INTEREST]").ToString(),
            };
            CustomInterest expectedResponse = new CustomInterest
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomInterest(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomInterestName("[CUSTOMER]", "[CUSTOM_INTEREST]").ToString();
            CustomInterest response = client.GetCustomInterest(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomInterestAsync()
        {
            Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new Mock<CustomInterestService.CustomInterestServiceClient>(MockBehavior.Strict);
            GetCustomInterestRequest expectedRequest = new GetCustomInterestRequest
            {
                ResourceName = new CustomInterestName("[CUSTOMER]", "[CUSTOM_INTEREST]").ToString(),
            };
            CustomInterest expectedResponse = new CustomInterest
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomInterestAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CustomInterest>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomInterestName("[CUSTOMER]", "[CUSTOM_INTEREST]").ToString();
            CustomInterest response = await client.GetCustomInterestAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCustomInterest2()
        {
            Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new Mock<CustomInterestService.CustomInterestServiceClient>(MockBehavior.Strict);
            GetCustomInterestRequest request = new GetCustomInterestRequest
            {
                ResourceName = new CustomInterestName("[CUSTOMER]", "[CUSTOM_INTEREST]").ToString(),
            };
            CustomInterest expectedResponse = new CustomInterest
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomInterest(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            CustomInterest response = client.GetCustomInterest(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomInterestAsync2()
        {
            Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new Mock<CustomInterestService.CustomInterestServiceClient>(MockBehavior.Strict);
            GetCustomInterestRequest request = new GetCustomInterestRequest
            {
                ResourceName = new CustomInterestName("[CUSTOMER]", "[CUSTOM_INTEREST]").ToString(),
            };
            CustomInterest expectedResponse = new CustomInterest
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomInterestAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CustomInterest>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            CustomInterest response = await client.GetCustomInterestAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomInterests()
        {
            Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new Mock<CustomInterestService.CustomInterestServiceClient>(MockBehavior.Strict);
            MutateCustomInterestsRequest expectedRequest = new MutateCustomInterestsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                ValidateOnly = false,
            };
            MutateCustomInterestsResponse expectedResponse = new MutateCustomInterestsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomInterests(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomInterestOperation> operations = new List<CustomInterestOperation>();
            bool validateOnly = false;
            MutateCustomInterestsResponse response = client.MutateCustomInterests(customerId, operations, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomInterestsAsync()
        {
            Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new Mock<CustomInterestService.CustomInterestServiceClient>(MockBehavior.Strict);
            MutateCustomInterestsRequest expectedRequest = new MutateCustomInterestsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                ValidateOnly = false,
            };
            MutateCustomInterestsResponse expectedResponse = new MutateCustomInterestsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomInterestsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomInterestsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomInterestOperation> operations = new List<CustomInterestOperation>();
            bool validateOnly = false;
            MutateCustomInterestsResponse response = await client.MutateCustomInterestsAsync(customerId, operations, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomInterests2()
        {
            Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new Mock<CustomInterestService.CustomInterestServiceClient>(MockBehavior.Strict);
            MutateCustomInterestsRequest expectedRequest = new MutateCustomInterestsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomInterestsResponse expectedResponse = new MutateCustomInterestsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomInterests(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomInterestOperation> operations = new List<CustomInterestOperation>();
            MutateCustomInterestsResponse response = client.MutateCustomInterests(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomInterestsAsync2()
        {
            Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new Mock<CustomInterestService.CustomInterestServiceClient>(MockBehavior.Strict);
            MutateCustomInterestsRequest expectedRequest = new MutateCustomInterestsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomInterestsResponse expectedResponse = new MutateCustomInterestsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomInterestsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomInterestsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomInterestOperation> operations = new List<CustomInterestOperation>();
            MutateCustomInterestsResponse response = await client.MutateCustomInterestsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomInterests3()
        {
            Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new Mock<CustomInterestService.CustomInterestServiceClient>(MockBehavior.Strict);
            MutateCustomInterestsRequest request = new MutateCustomInterestsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomInterestsResponse expectedResponse = new MutateCustomInterestsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomInterests(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomInterestsResponse response = client.MutateCustomInterests(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomInterestsAsync3()
        {
            Mock<CustomInterestService.CustomInterestServiceClient> mockGrpcClient = new Mock<CustomInterestService.CustomInterestServiceClient>(MockBehavior.Strict);
            MutateCustomInterestsRequest request = new MutateCustomInterestsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomInterestsResponse expectedResponse = new MutateCustomInterestsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomInterestsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomInterestsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomInterestServiceClient client = new CustomInterestServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomInterestsResponse response = await client.MutateCustomInterestsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

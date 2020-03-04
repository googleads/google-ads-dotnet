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

namespace Google.Ads.GoogleAds.V3.Services.Tests
{
    using apis = Google.Ads.GoogleAds.V3.Services;
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
    public class GeneratedGoogleAdsServiceClientTest
    {
        [Test]
        public void Mutate()
        {
            Mock<GoogleAdsService.GoogleAdsServiceClient> mockGrpcClient = new Mock<GoogleAdsService.GoogleAdsServiceClient>(MockBehavior.Strict);
            MutateGoogleAdsRequest expectedRequest = new MutateGoogleAdsRequest
            {
                CustomerId = "customerId-1772061412",
                MutateOperations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateGoogleAdsResponse expectedResponse = new MutateGoogleAdsResponse();
            mockGrpcClient.Setup(x => x.Mutate(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GoogleAdsServiceClient client = new GoogleAdsServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<MutateOperation> mutateOperations = new List<MutateOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateGoogleAdsResponse response = client.Mutate(customerId, mutateOperations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAsync()
        {
            Mock<GoogleAdsService.GoogleAdsServiceClient> mockGrpcClient = new Mock<GoogleAdsService.GoogleAdsServiceClient>(MockBehavior.Strict);
            MutateGoogleAdsRequest expectedRequest = new MutateGoogleAdsRequest
            {
                CustomerId = "customerId-1772061412",
                MutateOperations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateGoogleAdsResponse expectedResponse = new MutateGoogleAdsResponse();
            mockGrpcClient.Setup(x => x.MutateAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateGoogleAdsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            GoogleAdsServiceClient client = new GoogleAdsServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<MutateOperation> mutateOperations = new List<MutateOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateGoogleAdsResponse response = await client.MutateAsync(customerId, mutateOperations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void Mutate2()
        {
            Mock<GoogleAdsService.GoogleAdsServiceClient> mockGrpcClient = new Mock<GoogleAdsService.GoogleAdsServiceClient>(MockBehavior.Strict);
            MutateGoogleAdsRequest expectedRequest = new MutateGoogleAdsRequest
            {
                CustomerId = "customerId-1772061412",
                MutateOperations = { },
            };
            MutateGoogleAdsResponse expectedResponse = new MutateGoogleAdsResponse();
            mockGrpcClient.Setup(x => x.Mutate(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GoogleAdsServiceClient client = new GoogleAdsServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<MutateOperation> mutateOperations = new List<MutateOperation>();
            MutateGoogleAdsResponse response = client.Mutate(customerId, mutateOperations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAsync2()
        {
            Mock<GoogleAdsService.GoogleAdsServiceClient> mockGrpcClient = new Mock<GoogleAdsService.GoogleAdsServiceClient>(MockBehavior.Strict);
            MutateGoogleAdsRequest expectedRequest = new MutateGoogleAdsRequest
            {
                CustomerId = "customerId-1772061412",
                MutateOperations = { },
            };
            MutateGoogleAdsResponse expectedResponse = new MutateGoogleAdsResponse();
            mockGrpcClient.Setup(x => x.MutateAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateGoogleAdsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            GoogleAdsServiceClient client = new GoogleAdsServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<MutateOperation> mutateOperations = new List<MutateOperation>();
            MutateGoogleAdsResponse response = await client.MutateAsync(customerId, mutateOperations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void Mutate3()
        {
            Mock<GoogleAdsService.GoogleAdsServiceClient> mockGrpcClient = new Mock<GoogleAdsService.GoogleAdsServiceClient>(MockBehavior.Strict);
            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest
            {
                CustomerId = "customerId-1772061412",
                MutateOperations = { },
            };
            MutateGoogleAdsResponse expectedResponse = new MutateGoogleAdsResponse();
            mockGrpcClient.Setup(x => x.Mutate(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GoogleAdsServiceClient client = new GoogleAdsServiceClientImpl(mockGrpcClient.Object, null);
            MutateGoogleAdsResponse response = client.Mutate(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAsync3()
        {
            Mock<GoogleAdsService.GoogleAdsServiceClient> mockGrpcClient = new Mock<GoogleAdsService.GoogleAdsServiceClient>(MockBehavior.Strict);
            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest
            {
                CustomerId = "customerId-1772061412",
                MutateOperations = { },
            };
            MutateGoogleAdsResponse expectedResponse = new MutateGoogleAdsResponse();
            mockGrpcClient.Setup(x => x.MutateAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateGoogleAdsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            GoogleAdsServiceClient client = new GoogleAdsServiceClientImpl(mockGrpcClient.Object, null);
            MutateGoogleAdsResponse response = await client.MutateAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

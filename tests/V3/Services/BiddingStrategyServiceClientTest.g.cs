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

namespace Google.Ads.GoogleAds.V3.Services.Tests
{
    using Google.Ads.GoogleAds.V3.Resources;
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
    public class GeneratedBiddingStrategyServiceClientTest
    {
        [Test]
        public void GetBiddingStrategy()
        {
            Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new Mock<BiddingStrategyService.BiddingStrategyServiceClient>(MockBehavior.Strict);
            GetBiddingStrategyRequest expectedRequest = new GetBiddingStrategyRequest
            {
                ResourceName = new BiddingStrategyName("[CUSTOMER]", "[BIDDING_STRATEGY]").ToString(),
            };
            BiddingStrategy expectedResponse = new BiddingStrategy
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetBiddingStrategy(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new BiddingStrategyName("[CUSTOMER]", "[BIDDING_STRATEGY]").ToString();
            BiddingStrategy response = client.GetBiddingStrategy(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetBiddingStrategyAsync()
        {
            Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new Mock<BiddingStrategyService.BiddingStrategyServiceClient>(MockBehavior.Strict);
            GetBiddingStrategyRequest expectedRequest = new GetBiddingStrategyRequest
            {
                ResourceName = new BiddingStrategyName("[CUSTOMER]", "[BIDDING_STRATEGY]").ToString(),
            };
            BiddingStrategy expectedResponse = new BiddingStrategy
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetBiddingStrategyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<BiddingStrategy>(Task.FromResult(expectedResponse), null, null, null, null));
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new BiddingStrategyName("[CUSTOMER]", "[BIDDING_STRATEGY]").ToString();
            BiddingStrategy response = await client.GetBiddingStrategyAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetBiddingStrategy2()
        {
            Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new Mock<BiddingStrategyService.BiddingStrategyServiceClient>(MockBehavior.Strict);
            GetBiddingStrategyRequest request = new GetBiddingStrategyRequest
            {
                ResourceName = new BiddingStrategyName("[CUSTOMER]", "[BIDDING_STRATEGY]").ToString(),
            };
            BiddingStrategy expectedResponse = new BiddingStrategy
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetBiddingStrategy(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            BiddingStrategy response = client.GetBiddingStrategy(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetBiddingStrategyAsync2()
        {
            Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new Mock<BiddingStrategyService.BiddingStrategyServiceClient>(MockBehavior.Strict);
            GetBiddingStrategyRequest request = new GetBiddingStrategyRequest
            {
                ResourceName = new BiddingStrategyName("[CUSTOMER]", "[BIDDING_STRATEGY]").ToString(),
            };
            BiddingStrategy expectedResponse = new BiddingStrategy
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetBiddingStrategyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<BiddingStrategy>(Task.FromResult(expectedResponse), null, null, null, null));
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            BiddingStrategy response = await client.GetBiddingStrategyAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateBiddingStrategies()
        {
            Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new Mock<BiddingStrategyService.BiddingStrategyServiceClient>(MockBehavior.Strict);
            MutateBiddingStrategiesRequest expectedRequest = new MutateBiddingStrategiesRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateBiddingStrategiesResponse expectedResponse = new MutateBiddingStrategiesResponse();
            mockGrpcClient.Setup(x => x.MutateBiddingStrategies(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<BiddingStrategyOperation> operations = new List<BiddingStrategyOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateBiddingStrategiesResponse response = client.MutateBiddingStrategies(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateBiddingStrategiesAsync()
        {
            Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new Mock<BiddingStrategyService.BiddingStrategyServiceClient>(MockBehavior.Strict);
            MutateBiddingStrategiesRequest expectedRequest = new MutateBiddingStrategiesRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateBiddingStrategiesResponse expectedResponse = new MutateBiddingStrategiesResponse();
            mockGrpcClient.Setup(x => x.MutateBiddingStrategiesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateBiddingStrategiesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<BiddingStrategyOperation> operations = new List<BiddingStrategyOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateBiddingStrategiesResponse response = await client.MutateBiddingStrategiesAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateBiddingStrategies2()
        {
            Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new Mock<BiddingStrategyService.BiddingStrategyServiceClient>(MockBehavior.Strict);
            MutateBiddingStrategiesRequest expectedRequest = new MutateBiddingStrategiesRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateBiddingStrategiesResponse expectedResponse = new MutateBiddingStrategiesResponse();
            mockGrpcClient.Setup(x => x.MutateBiddingStrategies(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<BiddingStrategyOperation> operations = new List<BiddingStrategyOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateBiddingStrategiesResponse response = client.MutateBiddingStrategies(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateBiddingStrategiesAsync2()
        {
            Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new Mock<BiddingStrategyService.BiddingStrategyServiceClient>(MockBehavior.Strict);
            MutateBiddingStrategiesRequest expectedRequest = new MutateBiddingStrategiesRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateBiddingStrategiesResponse expectedResponse = new MutateBiddingStrategiesResponse();
            mockGrpcClient.Setup(x => x.MutateBiddingStrategiesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateBiddingStrategiesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<BiddingStrategyOperation> operations = new List<BiddingStrategyOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateBiddingStrategiesResponse response = await client.MutateBiddingStrategiesAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateBiddingStrategies3()
        {
            Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new Mock<BiddingStrategyService.BiddingStrategyServiceClient>(MockBehavior.Strict);
            MutateBiddingStrategiesRequest request = new MutateBiddingStrategiesRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateBiddingStrategiesResponse expectedResponse = new MutateBiddingStrategiesResponse();
            mockGrpcClient.Setup(x => x.MutateBiddingStrategies(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            MutateBiddingStrategiesResponse response = client.MutateBiddingStrategies(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateBiddingStrategiesAsync3()
        {
            Mock<BiddingStrategyService.BiddingStrategyServiceClient> mockGrpcClient = new Mock<BiddingStrategyService.BiddingStrategyServiceClient>(MockBehavior.Strict);
            MutateBiddingStrategiesRequest request = new MutateBiddingStrategiesRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateBiddingStrategiesResponse expectedResponse = new MutateBiddingStrategiesResponse();
            mockGrpcClient.Setup(x => x.MutateBiddingStrategiesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateBiddingStrategiesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BiddingStrategyServiceClient client = new BiddingStrategyServiceClientImpl(mockGrpcClient.Object, null);
            MutateBiddingStrategiesResponse response = await client.MutateBiddingStrategiesAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

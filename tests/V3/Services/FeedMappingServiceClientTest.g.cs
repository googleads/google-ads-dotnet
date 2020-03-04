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
    public class GeneratedFeedMappingServiceClientTest
    {
        [Test]
        public void GetFeedMapping()
        {
            Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new Mock<FeedMappingService.FeedMappingServiceClient>(MockBehavior.Strict);
            GetFeedMappingRequest expectedRequest = new GetFeedMappingRequest
            {
                ResourceName = new FeedMappingName("[CUSTOMER]", "[FEED_MAPPING]").ToString(),
            };
            FeedMapping expectedResponse = new FeedMapping
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedMapping(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new FeedMappingName("[CUSTOMER]", "[FEED_MAPPING]").ToString();
            FeedMapping response = client.GetFeedMapping(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetFeedMappingAsync()
        {
            Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new Mock<FeedMappingService.FeedMappingServiceClient>(MockBehavior.Strict);
            GetFeedMappingRequest expectedRequest = new GetFeedMappingRequest
            {
                ResourceName = new FeedMappingName("[CUSTOMER]", "[FEED_MAPPING]").ToString(),
            };
            FeedMapping expectedResponse = new FeedMapping
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedMappingAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<FeedMapping>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new FeedMappingName("[CUSTOMER]", "[FEED_MAPPING]").ToString();
            FeedMapping response = await client.GetFeedMappingAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetFeedMapping2()
        {
            Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new Mock<FeedMappingService.FeedMappingServiceClient>(MockBehavior.Strict);
            GetFeedMappingRequest request = new GetFeedMappingRequest
            {
                ResourceName = new FeedMappingName("[CUSTOMER]", "[FEED_MAPPING]").ToString(),
            };
            FeedMapping expectedResponse = new FeedMapping
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedMapping(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            FeedMapping response = client.GetFeedMapping(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetFeedMappingAsync2()
        {
            Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new Mock<FeedMappingService.FeedMappingServiceClient>(MockBehavior.Strict);
            GetFeedMappingRequest request = new GetFeedMappingRequest
            {
                ResourceName = new FeedMappingName("[CUSTOMER]", "[FEED_MAPPING]").ToString(),
            };
            FeedMapping expectedResponse = new FeedMapping
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetFeedMappingAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<FeedMapping>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            FeedMapping response = await client.GetFeedMappingAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateFeedMappings()
        {
            Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new Mock<FeedMappingService.FeedMappingServiceClient>(MockBehavior.Strict);
            MutateFeedMappingsRequest expectedRequest = new MutateFeedMappingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateFeedMappingsResponse expectedResponse = new MutateFeedMappingsResponse();
            mockGrpcClient.Setup(x => x.MutateFeedMappings(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<FeedMappingOperation> operations = new List<FeedMappingOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateFeedMappingsResponse response = client.MutateFeedMappings(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateFeedMappingsAsync()
        {
            Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new Mock<FeedMappingService.FeedMappingServiceClient>(MockBehavior.Strict);
            MutateFeedMappingsRequest expectedRequest = new MutateFeedMappingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateFeedMappingsResponse expectedResponse = new MutateFeedMappingsResponse();
            mockGrpcClient.Setup(x => x.MutateFeedMappingsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateFeedMappingsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<FeedMappingOperation> operations = new List<FeedMappingOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateFeedMappingsResponse response = await client.MutateFeedMappingsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateFeedMappings2()
        {
            Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new Mock<FeedMappingService.FeedMappingServiceClient>(MockBehavior.Strict);
            MutateFeedMappingsRequest expectedRequest = new MutateFeedMappingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateFeedMappingsResponse expectedResponse = new MutateFeedMappingsResponse();
            mockGrpcClient.Setup(x => x.MutateFeedMappings(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<FeedMappingOperation> operations = new List<FeedMappingOperation>();
            MutateFeedMappingsResponse response = client.MutateFeedMappings(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateFeedMappingsAsync2()
        {
            Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new Mock<FeedMappingService.FeedMappingServiceClient>(MockBehavior.Strict);
            MutateFeedMappingsRequest expectedRequest = new MutateFeedMappingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateFeedMappingsResponse expectedResponse = new MutateFeedMappingsResponse();
            mockGrpcClient.Setup(x => x.MutateFeedMappingsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateFeedMappingsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<FeedMappingOperation> operations = new List<FeedMappingOperation>();
            MutateFeedMappingsResponse response = await client.MutateFeedMappingsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateFeedMappings3()
        {
            Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new Mock<FeedMappingService.FeedMappingServiceClient>(MockBehavior.Strict);
            MutateFeedMappingsRequest request = new MutateFeedMappingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateFeedMappingsResponse expectedResponse = new MutateFeedMappingsResponse();
            mockGrpcClient.Setup(x => x.MutateFeedMappings(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedMappingsResponse response = client.MutateFeedMappings(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateFeedMappingsAsync3()
        {
            Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new Mock<FeedMappingService.FeedMappingServiceClient>(MockBehavior.Strict);
            MutateFeedMappingsRequest request = new MutateFeedMappingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateFeedMappingsResponse expectedResponse = new MutateFeedMappingsResponse();
            mockGrpcClient.Setup(x => x.MutateFeedMappingsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateFeedMappingsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedMappingsResponse response = await client.MutateFeedMappingsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

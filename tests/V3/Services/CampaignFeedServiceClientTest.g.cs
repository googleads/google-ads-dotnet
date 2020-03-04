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
    public class GeneratedCampaignFeedServiceClientTest
    {
        [Test]
        public void GetCampaignFeed()
        {
            Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new Mock<CampaignFeedService.CampaignFeedServiceClient>(MockBehavior.Strict);
            GetCampaignFeedRequest expectedRequest = new GetCampaignFeedRequest
            {
                ResourceName = new CampaignFeedName("[CUSTOMER]", "[CAMPAIGN_FEED]").ToString(),
            };
            CampaignFeed expectedResponse = new CampaignFeed
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignFeed(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignFeedName("[CUSTOMER]", "[CAMPAIGN_FEED]").ToString();
            CampaignFeed response = client.GetCampaignFeed(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignFeedAsync()
        {
            Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new Mock<CampaignFeedService.CampaignFeedServiceClient>(MockBehavior.Strict);
            GetCampaignFeedRequest expectedRequest = new GetCampaignFeedRequest
            {
                ResourceName = new CampaignFeedName("[CUSTOMER]", "[CAMPAIGN_FEED]").ToString(),
            };
            CampaignFeed expectedResponse = new CampaignFeed
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignFeedAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignFeed>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignFeedName("[CUSTOMER]", "[CAMPAIGN_FEED]").ToString();
            CampaignFeed response = await client.GetCampaignFeedAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaignFeed2()
        {
            Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new Mock<CampaignFeedService.CampaignFeedServiceClient>(MockBehavior.Strict);
            GetCampaignFeedRequest request = new GetCampaignFeedRequest
            {
                ResourceName = new CampaignFeedName("[CUSTOMER]", "[CAMPAIGN_FEED]").ToString(),
            };
            CampaignFeed expectedResponse = new CampaignFeed
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignFeed(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            CampaignFeed response = client.GetCampaignFeed(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignFeedAsync2()
        {
            Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new Mock<CampaignFeedService.CampaignFeedServiceClient>(MockBehavior.Strict);
            GetCampaignFeedRequest request = new GetCampaignFeedRequest
            {
                ResourceName = new CampaignFeedName("[CUSTOMER]", "[CAMPAIGN_FEED]").ToString(),
            };
            CampaignFeed expectedResponse = new CampaignFeed
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignFeedAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignFeed>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            CampaignFeed response = await client.GetCampaignFeedAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignFeeds()
        {
            Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new Mock<CampaignFeedService.CampaignFeedServiceClient>(MockBehavior.Strict);
            MutateCampaignFeedsRequest expectedRequest = new MutateCampaignFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCampaignFeedsResponse expectedResponse = new MutateCampaignFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignFeeds(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignFeedOperation> operations = new List<CampaignFeedOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCampaignFeedsResponse response = client.MutateCampaignFeeds(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignFeedsAsync()
        {
            Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new Mock<CampaignFeedService.CampaignFeedServiceClient>(MockBehavior.Strict);
            MutateCampaignFeedsRequest expectedRequest = new MutateCampaignFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCampaignFeedsResponse expectedResponse = new MutateCampaignFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignFeedsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignFeedsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignFeedOperation> operations = new List<CampaignFeedOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCampaignFeedsResponse response = await client.MutateCampaignFeedsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignFeeds2()
        {
            Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new Mock<CampaignFeedService.CampaignFeedServiceClient>(MockBehavior.Strict);
            MutateCampaignFeedsRequest expectedRequest = new MutateCampaignFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignFeedsResponse expectedResponse = new MutateCampaignFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignFeeds(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignFeedOperation> operations = new List<CampaignFeedOperation>();
            MutateCampaignFeedsResponse response = client.MutateCampaignFeeds(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignFeedsAsync2()
        {
            Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new Mock<CampaignFeedService.CampaignFeedServiceClient>(MockBehavior.Strict);
            MutateCampaignFeedsRequest expectedRequest = new MutateCampaignFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignFeedsResponse expectedResponse = new MutateCampaignFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignFeedsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignFeedsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignFeedOperation> operations = new List<CampaignFeedOperation>();
            MutateCampaignFeedsResponse response = await client.MutateCampaignFeedsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignFeeds3()
        {
            Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new Mock<CampaignFeedService.CampaignFeedServiceClient>(MockBehavior.Strict);
            MutateCampaignFeedsRequest request = new MutateCampaignFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignFeedsResponse expectedResponse = new MutateCampaignFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignFeeds(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignFeedsResponse response = client.MutateCampaignFeeds(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignFeedsAsync3()
        {
            Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new Mock<CampaignFeedService.CampaignFeedServiceClient>(MockBehavior.Strict);
            MutateCampaignFeedsRequest request = new MutateCampaignFeedsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignFeedsResponse expectedResponse = new MutateCampaignFeedsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignFeedsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignFeedsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignFeedsResponse response = await client.MutateCampaignFeedsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

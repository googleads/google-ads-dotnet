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
    public class GeneratedCampaignSharedSetServiceClientTest
    {
        [Test]
        public void GetCampaignSharedSet()
        {
            Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(MockBehavior.Strict);
            GetCampaignSharedSetRequest expectedRequest = new GetCampaignSharedSetRequest
            {
                ResourceName = new CampaignSharedSetName("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]").ToString(),
            };
            CampaignSharedSet expectedResponse = new CampaignSharedSet
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignSharedSet(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignSharedSetName("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]").ToString();
            CampaignSharedSet response = client.GetCampaignSharedSet(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignSharedSetAsync()
        {
            Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(MockBehavior.Strict);
            GetCampaignSharedSetRequest expectedRequest = new GetCampaignSharedSetRequest
            {
                ResourceName = new CampaignSharedSetName("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]").ToString(),
            };
            CampaignSharedSet expectedResponse = new CampaignSharedSet
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignSharedSetAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignSharedSet>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignSharedSetName("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]").ToString();
            CampaignSharedSet response = await client.GetCampaignSharedSetAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaignSharedSet2()
        {
            Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(MockBehavior.Strict);
            GetCampaignSharedSetRequest request = new GetCampaignSharedSetRequest
            {
                ResourceName = new CampaignSharedSetName("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]").ToString(),
            };
            CampaignSharedSet expectedResponse = new CampaignSharedSet
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignSharedSet(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            CampaignSharedSet response = client.GetCampaignSharedSet(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignSharedSetAsync2()
        {
            Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(MockBehavior.Strict);
            GetCampaignSharedSetRequest request = new GetCampaignSharedSetRequest
            {
                ResourceName = new CampaignSharedSetName("[CUSTOMER]", "[CAMPAIGN_SHARED_SET]").ToString(),
            };
            CampaignSharedSet expectedResponse = new CampaignSharedSet
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignSharedSetAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignSharedSet>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            CampaignSharedSet response = await client.GetCampaignSharedSetAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignSharedSets()
        {
            Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(MockBehavior.Strict);
            MutateCampaignSharedSetsRequest expectedRequest = new MutateCampaignSharedSetsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignSharedSetsResponse expectedResponse = new MutateCampaignSharedSetsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignSharedSets(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignSharedSetOperation> operations = new List<CampaignSharedSetOperation>();
            MutateCampaignSharedSetsResponse response = client.MutateCampaignSharedSets(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignSharedSetsAsync()
        {
            Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(MockBehavior.Strict);
            MutateCampaignSharedSetsRequest expectedRequest = new MutateCampaignSharedSetsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignSharedSetsResponse expectedResponse = new MutateCampaignSharedSetsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignSharedSetsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignSharedSetsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignSharedSetOperation> operations = new List<CampaignSharedSetOperation>();
            MutateCampaignSharedSetsResponse response = await client.MutateCampaignSharedSetsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignSharedSets2()
        {
            Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(MockBehavior.Strict);
            MutateCampaignSharedSetsRequest request = new MutateCampaignSharedSetsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignSharedSetsResponse expectedResponse = new MutateCampaignSharedSetsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignSharedSets(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignSharedSetsResponse response = client.MutateCampaignSharedSets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignSharedSetsAsync2()
        {
            Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(MockBehavior.Strict);
            MutateCampaignSharedSetsRequest request = new MutateCampaignSharedSetsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignSharedSetsResponse expectedResponse = new MutateCampaignSharedSetsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignSharedSetsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignSharedSetsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignSharedSetsResponse response = await client.MutateCampaignSharedSetsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

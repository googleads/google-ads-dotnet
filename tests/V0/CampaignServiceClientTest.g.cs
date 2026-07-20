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
    public class GeneratedCampaignServiceClientTest
    {
        [Test]
        public void GetCampaign()
        {
            Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new Mock<CampaignService.CampaignServiceClient>(MockBehavior.Strict);
            GetCampaignRequest expectedRequest = new GetCampaignRequest
            {
                ResourceName = new CampaignName("[CUSTOMER]", "[CAMPAIGN]").ToString(),
            };
            Campaign expectedResponse = new Campaign
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaign(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignName("[CUSTOMER]", "[CAMPAIGN]").ToString();
            Campaign response = client.GetCampaign(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignAsync()
        {
            Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new Mock<CampaignService.CampaignServiceClient>(MockBehavior.Strict);
            GetCampaignRequest expectedRequest = new GetCampaignRequest
            {
                ResourceName = new CampaignName("[CUSTOMER]", "[CAMPAIGN]").ToString(),
            };
            Campaign expectedResponse = new Campaign
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Campaign>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignName("[CUSTOMER]", "[CAMPAIGN]").ToString();
            Campaign response = await client.GetCampaignAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaign2()
        {
            Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new Mock<CampaignService.CampaignServiceClient>(MockBehavior.Strict);
            GetCampaignRequest request = new GetCampaignRequest
            {
                ResourceName = new CampaignName("[CUSTOMER]", "[CAMPAIGN]").ToString(),
            };
            Campaign expectedResponse = new Campaign
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaign(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            Campaign response = client.GetCampaign(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignAsync2()
        {
            Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new Mock<CampaignService.CampaignServiceClient>(MockBehavior.Strict);
            GetCampaignRequest request = new GetCampaignRequest
            {
                ResourceName = new CampaignName("[CUSTOMER]", "[CAMPAIGN]").ToString(),
            };
            Campaign expectedResponse = new Campaign
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Campaign>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            Campaign response = await client.GetCampaignAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaigns()
        {
            Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new Mock<CampaignService.CampaignServiceClient>(MockBehavior.Strict);
            MutateCampaignsRequest expectedRequest = new MutateCampaignsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignsResponse expectedResponse = new MutateCampaignsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaigns(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignOperation> operations = new List<CampaignOperation>();
            MutateCampaignsResponse response = client.MutateCampaigns(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignsAsync()
        {
            Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new Mock<CampaignService.CampaignServiceClient>(MockBehavior.Strict);
            MutateCampaignsRequest expectedRequest = new MutateCampaignsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignsResponse expectedResponse = new MutateCampaignsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignOperation> operations = new List<CampaignOperation>();
            MutateCampaignsResponse response = await client.MutateCampaignsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaigns2()
        {
            Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new Mock<CampaignService.CampaignServiceClient>(MockBehavior.Strict);
            MutateCampaignsRequest request = new MutateCampaignsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignsResponse expectedResponse = new MutateCampaignsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaigns(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignsResponse response = client.MutateCampaigns(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignsAsync2()
        {
            Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new Mock<CampaignService.CampaignServiceClient>(MockBehavior.Strict);
            MutateCampaignsRequest request = new MutateCampaignsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignsResponse expectedResponse = new MutateCampaignsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignsResponse response = await client.MutateCampaignsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

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
    public class GeneratedCampaignAudienceViewServiceClientTest
    {
        [Test]
        public void GetCampaignAudienceView()
        {
            Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient> mockGrpcClient = new Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient>(MockBehavior.Strict);
            GetCampaignAudienceViewRequest expectedRequest = new GetCampaignAudienceViewRequest
            {
                ResourceName = new CampaignAudienceViewName("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]").ToString(),
            };
            CampaignAudienceView expectedResponse = new CampaignAudienceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignAudienceView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignAudienceViewServiceClient client = new CampaignAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignAudienceViewName("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]").ToString();
            CampaignAudienceView response = client.GetCampaignAudienceView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignAudienceViewAsync()
        {
            Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient> mockGrpcClient = new Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient>(MockBehavior.Strict);
            GetCampaignAudienceViewRequest expectedRequest = new GetCampaignAudienceViewRequest
            {
                ResourceName = new CampaignAudienceViewName("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]").ToString(),
            };
            CampaignAudienceView expectedResponse = new CampaignAudienceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignAudienceViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignAudienceView>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignAudienceViewServiceClient client = new CampaignAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignAudienceViewName("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]").ToString();
            CampaignAudienceView response = await client.GetCampaignAudienceViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaignAudienceView2()
        {
            Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient> mockGrpcClient = new Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient>(MockBehavior.Strict);
            GetCampaignAudienceViewRequest request = new GetCampaignAudienceViewRequest
            {
                ResourceName = new CampaignAudienceViewName("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]").ToString(),
            };
            CampaignAudienceView expectedResponse = new CampaignAudienceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignAudienceView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignAudienceViewServiceClient client = new CampaignAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            CampaignAudienceView response = client.GetCampaignAudienceView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignAudienceViewAsync2()
        {
            Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient> mockGrpcClient = new Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient>(MockBehavior.Strict);
            GetCampaignAudienceViewRequest request = new GetCampaignAudienceViewRequest
            {
                ResourceName = new CampaignAudienceViewName("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]").ToString(),
            };
            CampaignAudienceView expectedResponse = new CampaignAudienceView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignAudienceViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignAudienceView>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignAudienceViewServiceClient client = new CampaignAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            CampaignAudienceView response = await client.GetCampaignAudienceViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

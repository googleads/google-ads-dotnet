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
    public class GeneratedCampaignCriterionSimulationServiceClientTest
    {
        [Test]
        public void GetCampaignCriterionSimulation()
        {
            Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient> mockGrpcClient = new Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient>(MockBehavior.Strict);
            GetCampaignCriterionSimulationRequest expectedRequest = new GetCampaignCriterionSimulationRequest
            {
                ResourceName = new CampaignCriterionSimulationName("[CUSTOMER]", "[CAMPAIGN_CRITERION_SIMULATION]").ToString(),
            };
            CampaignCriterionSimulation expectedResponse = new CampaignCriterionSimulation
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterionSimulation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignCriterionSimulationServiceClient client = new CampaignCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignCriterionSimulationName("[CUSTOMER]", "[CAMPAIGN_CRITERION_SIMULATION]").ToString();
            CampaignCriterionSimulation response = client.GetCampaignCriterionSimulation(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignCriterionSimulationAsync()
        {
            Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient> mockGrpcClient = new Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient>(MockBehavior.Strict);
            GetCampaignCriterionSimulationRequest expectedRequest = new GetCampaignCriterionSimulationRequest
            {
                ResourceName = new CampaignCriterionSimulationName("[CUSTOMER]", "[CAMPAIGN_CRITERION_SIMULATION]").ToString(),
            };
            CampaignCriterionSimulation expectedResponse = new CampaignCriterionSimulation
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterionSimulationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignCriterionSimulation>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignCriterionSimulationServiceClient client = new CampaignCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignCriterionSimulationName("[CUSTOMER]", "[CAMPAIGN_CRITERION_SIMULATION]").ToString();
            CampaignCriterionSimulation response = await client.GetCampaignCriterionSimulationAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaignCriterionSimulation2()
        {
            Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient> mockGrpcClient = new Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient>(MockBehavior.Strict);
            GetCampaignCriterionSimulationRequest request = new GetCampaignCriterionSimulationRequest
            {
                ResourceName = new CampaignCriterionSimulationName("[CUSTOMER]", "[CAMPAIGN_CRITERION_SIMULATION]").ToString(),
            };
            CampaignCriterionSimulation expectedResponse = new CampaignCriterionSimulation
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterionSimulation(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignCriterionSimulationServiceClient client = new CampaignCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            CampaignCriterionSimulation response = client.GetCampaignCriterionSimulation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignCriterionSimulationAsync2()
        {
            Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient> mockGrpcClient = new Mock<CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient>(MockBehavior.Strict);
            GetCampaignCriterionSimulationRequest request = new GetCampaignCriterionSimulationRequest
            {
                ResourceName = new CampaignCriterionSimulationName("[CUSTOMER]", "[CAMPAIGN_CRITERION_SIMULATION]").ToString(),
            };
            CampaignCriterionSimulation expectedResponse = new CampaignCriterionSimulation
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterionSimulationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignCriterionSimulation>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignCriterionSimulationServiceClient client = new CampaignCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            CampaignCriterionSimulation response = await client.GetCampaignCriterionSimulationAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

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
    public class GeneratedAdGroupCriterionSimulationServiceClientTest
    {
        [Test]
        public void GetAdGroupCriterionSimulation()
        {
            Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient> mockGrpcClient = new Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient>(MockBehavior.Strict);
            GetAdGroupCriterionSimulationRequest expectedRequest = new GetAdGroupCriterionSimulationRequest
            {
                ResourceName = new AdGroupCriterionSimulationName("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]").ToString(),
            };
            AdGroupCriterionSimulation expectedResponse = new AdGroupCriterionSimulation
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionSimulation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupCriterionSimulationServiceClient client = new AdGroupCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupCriterionSimulationName("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]").ToString();
            AdGroupCriterionSimulation response = client.GetAdGroupCriterionSimulation(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupCriterionSimulationAsync()
        {
            Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient> mockGrpcClient = new Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient>(MockBehavior.Strict);
            GetAdGroupCriterionSimulationRequest expectedRequest = new GetAdGroupCriterionSimulationRequest
            {
                ResourceName = new AdGroupCriterionSimulationName("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]").ToString(),
            };
            AdGroupCriterionSimulation expectedResponse = new AdGroupCriterionSimulation
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionSimulationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupCriterionSimulation>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionSimulationServiceClient client = new AdGroupCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupCriterionSimulationName("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]").ToString();
            AdGroupCriterionSimulation response = await client.GetAdGroupCriterionSimulationAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroupCriterionSimulation2()
        {
            Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient> mockGrpcClient = new Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient>(MockBehavior.Strict);
            GetAdGroupCriterionSimulationRequest request = new GetAdGroupCriterionSimulationRequest
            {
                ResourceName = new AdGroupCriterionSimulationName("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]").ToString(),
            };
            AdGroupCriterionSimulation expectedResponse = new AdGroupCriterionSimulation
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionSimulation(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupCriterionSimulationServiceClient client = new AdGroupCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupCriterionSimulation response = client.GetAdGroupCriterionSimulation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupCriterionSimulationAsync2()
        {
            Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient> mockGrpcClient = new Mock<AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient>(MockBehavior.Strict);
            GetAdGroupCriterionSimulationRequest request = new GetAdGroupCriterionSimulationRequest
            {
                ResourceName = new AdGroupCriterionSimulationName("[CUSTOMER]", "[AD_GROUP_CRITERION_SIMULATION]").ToString(),
            };
            AdGroupCriterionSimulation expectedResponse = new AdGroupCriterionSimulation
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionSimulationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupCriterionSimulation>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionSimulationServiceClient client = new AdGroupCriterionSimulationServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupCriterionSimulation response = await client.GetAdGroupCriterionSimulationAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

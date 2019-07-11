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
    public class GeneratedAdGroupSimulationServiceClientTest
    {
        [Test]
        public void GetAdGroupSimulation()
        {
            Mock<AdGroupSimulationService.AdGroupSimulationServiceClient> mockGrpcClient = new Mock<AdGroupSimulationService.AdGroupSimulationServiceClient>(MockBehavior.Strict);
            GetAdGroupSimulationRequest expectedRequest = new GetAdGroupSimulationRequest
            {
                ResourceName = new AdGroupSimulationName("[CUSTOMER]", "[AD_GROUP_SIMULATION]").ToString(),
            };
            AdGroupSimulation expectedResponse = new AdGroupSimulation
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupSimulation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupSimulationServiceClient client = new AdGroupSimulationServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupSimulationName("[CUSTOMER]", "[AD_GROUP_SIMULATION]").ToString();
            AdGroupSimulation response = client.GetAdGroupSimulation(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupSimulationAsync()
        {
            Mock<AdGroupSimulationService.AdGroupSimulationServiceClient> mockGrpcClient = new Mock<AdGroupSimulationService.AdGroupSimulationServiceClient>(MockBehavior.Strict);
            GetAdGroupSimulationRequest expectedRequest = new GetAdGroupSimulationRequest
            {
                ResourceName = new AdGroupSimulationName("[CUSTOMER]", "[AD_GROUP_SIMULATION]").ToString(),
            };
            AdGroupSimulation expectedResponse = new AdGroupSimulation
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupSimulationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupSimulation>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupSimulationServiceClient client = new AdGroupSimulationServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupSimulationName("[CUSTOMER]", "[AD_GROUP_SIMULATION]").ToString();
            AdGroupSimulation response = await client.GetAdGroupSimulationAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroupSimulation2()
        {
            Mock<AdGroupSimulationService.AdGroupSimulationServiceClient> mockGrpcClient = new Mock<AdGroupSimulationService.AdGroupSimulationServiceClient>(MockBehavior.Strict);
            GetAdGroupSimulationRequest request = new GetAdGroupSimulationRequest
            {
                ResourceName = new AdGroupSimulationName("[CUSTOMER]", "[AD_GROUP_SIMULATION]").ToString(),
            };
            AdGroupSimulation expectedResponse = new AdGroupSimulation
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupSimulation(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupSimulationServiceClient client = new AdGroupSimulationServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupSimulation response = client.GetAdGroupSimulation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupSimulationAsync2()
        {
            Mock<AdGroupSimulationService.AdGroupSimulationServiceClient> mockGrpcClient = new Mock<AdGroupSimulationService.AdGroupSimulationServiceClient>(MockBehavior.Strict);
            GetAdGroupSimulationRequest request = new GetAdGroupSimulationRequest
            {
                ResourceName = new AdGroupSimulationName("[CUSTOMER]", "[AD_GROUP_SIMULATION]").ToString(),
            };
            AdGroupSimulation expectedResponse = new AdGroupSimulation
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupSimulationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupSimulation>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupSimulationServiceClient client = new AdGroupSimulationServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupSimulation response = await client.GetAdGroupSimulationAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

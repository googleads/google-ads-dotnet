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
    public class GeneratedReachPlanServiceClientTest
    {
        [Test]
        public void ListPlannableLocations()
        {
            Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new Mock<ReachPlanService.ReachPlanServiceClient>(MockBehavior.Strict);
            ListPlannableLocationsRequest request = new ListPlannableLocationsRequest();
            ListPlannableLocationsResponse expectedResponse = new ListPlannableLocationsResponse();
            mockGrpcClient.Setup(x => x.ListPlannableLocations(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            ListPlannableLocationsResponse response = client.ListPlannableLocations(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task ListPlannableLocationsAsync()
        {
            Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new Mock<ReachPlanService.ReachPlanServiceClient>(MockBehavior.Strict);
            ListPlannableLocationsRequest request = new ListPlannableLocationsRequest();
            ListPlannableLocationsResponse expectedResponse = new ListPlannableLocationsResponse();
            mockGrpcClient.Setup(x => x.ListPlannableLocationsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListPlannableLocationsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            ListPlannableLocationsResponse response = await client.ListPlannableLocationsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void ListPlannableProducts()
        {
            Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new Mock<ReachPlanService.ReachPlanServiceClient>(MockBehavior.Strict);
            ListPlannableProductsRequest expectedRequest = new ListPlannableProductsRequest
            {
                PlannableLocationId = null,
            };
            ListPlannableProductsResponse expectedResponse = new ListPlannableProductsResponse();
            mockGrpcClient.Setup(x => x.ListPlannableProducts(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            string plannableLocationId = null;
            ListPlannableProductsResponse response = client.ListPlannableProducts(plannableLocationId);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task ListPlannableProductsAsync()
        {
            Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new Mock<ReachPlanService.ReachPlanServiceClient>(MockBehavior.Strict);
            ListPlannableProductsRequest expectedRequest = new ListPlannableProductsRequest
            {
                PlannableLocationId = null,
            };
            ListPlannableProductsResponse expectedResponse = new ListPlannableProductsResponse();
            mockGrpcClient.Setup(x => x.ListPlannableProductsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListPlannableProductsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            string plannableLocationId = null;
            ListPlannableProductsResponse response = await client.ListPlannableProductsAsync(plannableLocationId);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void ListPlannableProducts2()
        {
            Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new Mock<ReachPlanService.ReachPlanServiceClient>(MockBehavior.Strict);
            ListPlannableProductsRequest request = new ListPlannableProductsRequest
            {
                PlannableLocationId = null,
            };
            ListPlannableProductsResponse expectedResponse = new ListPlannableProductsResponse();
            mockGrpcClient.Setup(x => x.ListPlannableProducts(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            ListPlannableProductsResponse response = client.ListPlannableProducts(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task ListPlannableProductsAsync2()
        {
            Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new Mock<ReachPlanService.ReachPlanServiceClient>(MockBehavior.Strict);
            ListPlannableProductsRequest request = new ListPlannableProductsRequest
            {
                PlannableLocationId = null,
            };
            ListPlannableProductsResponse expectedResponse = new ListPlannableProductsResponse();
            mockGrpcClient.Setup(x => x.ListPlannableProductsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListPlannableProductsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            ListPlannableProductsResponse response = await client.ListPlannableProductsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GenerateProductMixIdeas()
        {
            Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new Mock<ReachPlanService.ReachPlanServiceClient>(MockBehavior.Strict);
            GenerateProductMixIdeasRequest request = new GenerateProductMixIdeasRequest
            {
                CustomerId = "customerId-1772061412",
                PlannableLocationId = null,
                CurrencyCode = null,
                BudgetMicros = null,
                Preferences = new Preferences(),
            };
            GenerateProductMixIdeasResponse expectedResponse = new GenerateProductMixIdeasResponse();
            mockGrpcClient.Setup(x => x.GenerateProductMixIdeas(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateProductMixIdeasResponse response = client.GenerateProductMixIdeas(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GenerateProductMixIdeasAsync()
        {
            Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new Mock<ReachPlanService.ReachPlanServiceClient>(MockBehavior.Strict);
            GenerateProductMixIdeasRequest request = new GenerateProductMixIdeasRequest
            {
                CustomerId = "customerId-1772061412",
                PlannableLocationId = null,
                CurrencyCode = null,
                BudgetMicros = null,
                Preferences = new Preferences(),
            };
            GenerateProductMixIdeasResponse expectedResponse = new GenerateProductMixIdeasResponse();
            mockGrpcClient.Setup(x => x.GenerateProductMixIdeasAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GenerateProductMixIdeasResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateProductMixIdeasResponse response = await client.GenerateProductMixIdeasAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GenerateReachForecast()
        {
            Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new Mock<ReachPlanService.ReachPlanServiceClient>(MockBehavior.Strict);
            GenerateReachForecastRequest request = new GenerateReachForecastRequest
            {
                CustomerId = "customerId-1772061412",
                CurrencyCode = null,
                CampaignDuration = new CampaignDuration(),
                CookieFrequencyCap = null,
                MinEffectiveFrequency = null,
                Targeting = new Targeting(),
                PlannedProducts = { },
            };
            GenerateReachForecastResponse expectedResponse = new GenerateReachForecastResponse();
            mockGrpcClient.Setup(x => x.GenerateReachForecast(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateReachForecastResponse response = client.GenerateReachForecast(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GenerateReachForecastAsync()
        {
            Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new Mock<ReachPlanService.ReachPlanServiceClient>(MockBehavior.Strict);
            GenerateReachForecastRequest request = new GenerateReachForecastRequest
            {
                CustomerId = "customerId-1772061412",
                CurrencyCode = null,
                CampaignDuration = new CampaignDuration(),
                CookieFrequencyCap = null,
                MinEffectiveFrequency = null,
                Targeting = new Targeting(),
                PlannedProducts = { },
            };
            GenerateReachForecastResponse expectedResponse = new GenerateReachForecastResponse();
            mockGrpcClient.Setup(x => x.GenerateReachForecastAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GenerateReachForecastResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateReachForecastResponse response = await client.GenerateReachForecastAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

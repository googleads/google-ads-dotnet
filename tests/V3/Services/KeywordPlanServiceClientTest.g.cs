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
    public class GeneratedKeywordPlanServiceClientTest
    {
        [Test]
        public void GetKeywordPlan()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            GetKeywordPlanRequest expectedRequest = new GetKeywordPlanRequest
            {
                ResourceName = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString(),
            };
            KeywordPlan expectedResponse = new KeywordPlan
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlan(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString();
            KeywordPlan response = client.GetKeywordPlan(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetKeywordPlanAsync()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            GetKeywordPlanRequest expectedRequest = new GetKeywordPlanRequest
            {
                ResourceName = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString(),
            };
            KeywordPlan expectedResponse = new KeywordPlan
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<KeywordPlan>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString();
            KeywordPlan response = await client.GetKeywordPlanAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetKeywordPlan2()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            GetKeywordPlanRequest request = new GetKeywordPlanRequest
            {
                ResourceName = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString(),
            };
            KeywordPlan expectedResponse = new KeywordPlan
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlan(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            KeywordPlan response = client.GetKeywordPlan(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetKeywordPlanAsync2()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            GetKeywordPlanRequest request = new GetKeywordPlanRequest
            {
                ResourceName = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString(),
            };
            KeywordPlan expectedResponse = new KeywordPlan
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<KeywordPlan>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            KeywordPlan response = await client.GetKeywordPlanAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateKeywordPlans()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            MutateKeywordPlansRequest expectedRequest = new MutateKeywordPlansRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateKeywordPlansResponse expectedResponse = new MutateKeywordPlansResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlans(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<KeywordPlanOperation> operations = new List<KeywordPlanOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateKeywordPlansResponse response = client.MutateKeywordPlans(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateKeywordPlansAsync()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            MutateKeywordPlansRequest expectedRequest = new MutateKeywordPlansRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateKeywordPlansResponse expectedResponse = new MutateKeywordPlansResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlansAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateKeywordPlansResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<KeywordPlanOperation> operations = new List<KeywordPlanOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateKeywordPlansResponse response = await client.MutateKeywordPlansAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateKeywordPlans2()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            MutateKeywordPlansRequest expectedRequest = new MutateKeywordPlansRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateKeywordPlansResponse expectedResponse = new MutateKeywordPlansResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlans(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<KeywordPlanOperation> operations = new List<KeywordPlanOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateKeywordPlansResponse response = client.MutateKeywordPlans(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateKeywordPlansAsync2()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            MutateKeywordPlansRequest expectedRequest = new MutateKeywordPlansRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateKeywordPlansResponse expectedResponse = new MutateKeywordPlansResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlansAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateKeywordPlansResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<KeywordPlanOperation> operations = new List<KeywordPlanOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateKeywordPlansResponse response = await client.MutateKeywordPlansAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateKeywordPlans3()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            MutateKeywordPlansRequest request = new MutateKeywordPlansRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlansResponse expectedResponse = new MutateKeywordPlansResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlans(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlansResponse response = client.MutateKeywordPlans(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateKeywordPlansAsync3()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            MutateKeywordPlansRequest request = new MutateKeywordPlansRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlansResponse expectedResponse = new MutateKeywordPlansResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlansAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateKeywordPlansResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlansResponse response = await client.MutateKeywordPlansAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GenerateForecastMetrics()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            GenerateForecastMetricsRequest expectedRequest = new GenerateForecastMetricsRequest
            {
                KeywordPlan = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString(),
            };
            GenerateForecastMetricsResponse expectedResponse = new GenerateForecastMetricsResponse();
            mockGrpcClient.Setup(x => x.GenerateForecastMetrics(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            string formattedKeywordPlan = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString();
            GenerateForecastMetricsResponse response = client.GenerateForecastMetrics(formattedKeywordPlan);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GenerateForecastMetricsAsync()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            GenerateForecastMetricsRequest expectedRequest = new GenerateForecastMetricsRequest
            {
                KeywordPlan = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString(),
            };
            GenerateForecastMetricsResponse expectedResponse = new GenerateForecastMetricsResponse();
            mockGrpcClient.Setup(x => x.GenerateForecastMetricsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GenerateForecastMetricsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            string formattedKeywordPlan = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString();
            GenerateForecastMetricsResponse response = await client.GenerateForecastMetricsAsync(formattedKeywordPlan);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GenerateForecastMetrics2()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            GenerateForecastMetricsRequest request = new GenerateForecastMetricsRequest
            {
                KeywordPlan = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString(),
            };
            GenerateForecastMetricsResponse expectedResponse = new GenerateForecastMetricsResponse();
            mockGrpcClient.Setup(x => x.GenerateForecastMetrics(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateForecastMetricsResponse response = client.GenerateForecastMetrics(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GenerateForecastMetricsAsync2()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            GenerateForecastMetricsRequest request = new GenerateForecastMetricsRequest
            {
                KeywordPlan = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString(),
            };
            GenerateForecastMetricsResponse expectedResponse = new GenerateForecastMetricsResponse();
            mockGrpcClient.Setup(x => x.GenerateForecastMetricsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GenerateForecastMetricsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateForecastMetricsResponse response = await client.GenerateForecastMetricsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GenerateHistoricalMetrics()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            GenerateHistoricalMetricsRequest expectedRequest = new GenerateHistoricalMetricsRequest
            {
                KeywordPlan = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString(),
            };
            GenerateHistoricalMetricsResponse expectedResponse = new GenerateHistoricalMetricsResponse();
            mockGrpcClient.Setup(x => x.GenerateHistoricalMetrics(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            string formattedKeywordPlan = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString();
            GenerateHistoricalMetricsResponse response = client.GenerateHistoricalMetrics(formattedKeywordPlan);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GenerateHistoricalMetricsAsync()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            GenerateHistoricalMetricsRequest expectedRequest = new GenerateHistoricalMetricsRequest
            {
                KeywordPlan = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString(),
            };
            GenerateHistoricalMetricsResponse expectedResponse = new GenerateHistoricalMetricsResponse();
            mockGrpcClient.Setup(x => x.GenerateHistoricalMetricsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GenerateHistoricalMetricsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            string formattedKeywordPlan = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString();
            GenerateHistoricalMetricsResponse response = await client.GenerateHistoricalMetricsAsync(formattedKeywordPlan);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GenerateHistoricalMetrics2()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            GenerateHistoricalMetricsRequest request = new GenerateHistoricalMetricsRequest
            {
                KeywordPlan = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString(),
            };
            GenerateHistoricalMetricsResponse expectedResponse = new GenerateHistoricalMetricsResponse();
            mockGrpcClient.Setup(x => x.GenerateHistoricalMetrics(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateHistoricalMetricsResponse response = client.GenerateHistoricalMetrics(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GenerateHistoricalMetricsAsync2()
        {
            Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new Mock<KeywordPlanService.KeywordPlanServiceClient>(MockBehavior.Strict);
            GenerateHistoricalMetricsRequest request = new GenerateHistoricalMetricsRequest
            {
                KeywordPlan = new KeywordPlanName("[CUSTOMER]", "[KEYWORD_PLAN]").ToString(),
            };
            GenerateHistoricalMetricsResponse expectedResponse = new GenerateHistoricalMetricsResponse();
            mockGrpcClient.Setup(x => x.GenerateHistoricalMetricsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GenerateHistoricalMetricsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateHistoricalMetricsResponse response = await client.GenerateHistoricalMetricsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

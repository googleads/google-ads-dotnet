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
    public class GeneratedRecommendationServiceClientTest
    {
        [Test]
        public void GetRecommendation()
        {
            Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new Mock<RecommendationService.RecommendationServiceClient>(MockBehavior.Strict);
            GetRecommendationRequest expectedRequest = new GetRecommendationRequest
            {
                ResourceName = new RecommendationName("[CUSTOMER]", "[RECOMMENDATION]").ToString(),
            };
            Recommendation expectedResponse = new Recommendation
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetRecommendation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new RecommendationName("[CUSTOMER]", "[RECOMMENDATION]").ToString();
            Recommendation response = client.GetRecommendation(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetRecommendationAsync()
        {
            Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new Mock<RecommendationService.RecommendationServiceClient>(MockBehavior.Strict);
            GetRecommendationRequest expectedRequest = new GetRecommendationRequest
            {
                ResourceName = new RecommendationName("[CUSTOMER]", "[RECOMMENDATION]").ToString(),
            };
            Recommendation expectedResponse = new Recommendation
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetRecommendationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Recommendation>(Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new RecommendationName("[CUSTOMER]", "[RECOMMENDATION]").ToString();
            Recommendation response = await client.GetRecommendationAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetRecommendation2()
        {
            Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new Mock<RecommendationService.RecommendationServiceClient>(MockBehavior.Strict);
            GetRecommendationRequest request = new GetRecommendationRequest
            {
                ResourceName = new RecommendationName("[CUSTOMER]", "[RECOMMENDATION]").ToString(),
            };
            Recommendation expectedResponse = new Recommendation
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetRecommendation(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            Recommendation response = client.GetRecommendation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetRecommendationAsync2()
        {
            Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new Mock<RecommendationService.RecommendationServiceClient>(MockBehavior.Strict);
            GetRecommendationRequest request = new GetRecommendationRequest
            {
                ResourceName = new RecommendationName("[CUSTOMER]", "[RECOMMENDATION]").ToString(),
            };
            Recommendation expectedResponse = new Recommendation
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetRecommendationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Recommendation>(Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            Recommendation response = await client.GetRecommendationAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void ApplyRecommendation()
        {
            Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new Mock<RecommendationService.RecommendationServiceClient>(MockBehavior.Strict);
            ApplyRecommendationRequest expectedRequest = new ApplyRecommendationRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            ApplyRecommendationResponse expectedResponse = new ApplyRecommendationResponse();
            mockGrpcClient.Setup(x => x.ApplyRecommendation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ApplyRecommendationOperation> operations = new List<ApplyRecommendationOperation>();
            ApplyRecommendationResponse response = client.ApplyRecommendation(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task ApplyRecommendationAsync()
        {
            Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new Mock<RecommendationService.RecommendationServiceClient>(MockBehavior.Strict);
            ApplyRecommendationRequest expectedRequest = new ApplyRecommendationRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            ApplyRecommendationResponse expectedResponse = new ApplyRecommendationResponse();
            mockGrpcClient.Setup(x => x.ApplyRecommendationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ApplyRecommendationResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ApplyRecommendationOperation> operations = new List<ApplyRecommendationOperation>();
            ApplyRecommendationResponse response = await client.ApplyRecommendationAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void ApplyRecommendation2()
        {
            Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new Mock<RecommendationService.RecommendationServiceClient>(MockBehavior.Strict);
            ApplyRecommendationRequest request = new ApplyRecommendationRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            ApplyRecommendationResponse expectedResponse = new ApplyRecommendationResponse();
            mockGrpcClient.Setup(x => x.ApplyRecommendation(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            ApplyRecommendationResponse response = client.ApplyRecommendation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task ApplyRecommendationAsync2()
        {
            Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new Mock<RecommendationService.RecommendationServiceClient>(MockBehavior.Strict);
            ApplyRecommendationRequest request = new ApplyRecommendationRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            ApplyRecommendationResponse expectedResponse = new ApplyRecommendationResponse();
            mockGrpcClient.Setup(x => x.ApplyRecommendationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ApplyRecommendationResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            ApplyRecommendationResponse response = await client.ApplyRecommendationAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

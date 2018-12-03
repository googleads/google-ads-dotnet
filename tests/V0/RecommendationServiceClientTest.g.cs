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

// TODO( b/119694056): Removed Comment

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
                PartialFailure = true,
                Operations = { },
            };
            ApplyRecommendationResponse expectedResponse = new ApplyRecommendationResponse();
            mockGrpcClient.Setup(x => x.ApplyRecommendation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            bool partialFailure = true;
            IEnumerable<ApplyRecommendationOperation> operations = new List<ApplyRecommendationOperation>();
            ApplyRecommendationResponse response = client.ApplyRecommendation(customerId, partialFailure, operations);
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
                PartialFailure = true,
                Operations = { },
            };
            ApplyRecommendationResponse expectedResponse = new ApplyRecommendationResponse();
            mockGrpcClient.Setup(x => x.ApplyRecommendationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ApplyRecommendationResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            bool partialFailure = true;
            IEnumerable<ApplyRecommendationOperation> operations = new List<ApplyRecommendationOperation>();
            ApplyRecommendationResponse response = await client.ApplyRecommendationAsync(customerId, partialFailure, operations);
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
                PartialFailure = true,
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
                PartialFailure = true,
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

        [Test]
        public void DismissRecommendation()
        {
            Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new Mock<RecommendationService.RecommendationServiceClient>(MockBehavior.Strict);
            DismissRecommendationRequest expectedRequest = new DismissRecommendationRequest
            {
                CustomerId = "customerId-1772061412",
                PartialFailure = true,
                Operations = { },
            };
            DismissRecommendationResponse expectedResponse = new DismissRecommendationResponse();
            mockGrpcClient.Setup(x => x.DismissRecommendation(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            bool partialFailure = true;
            IEnumerable<DismissRecommendationRequest.Types.DismissRecommendationOperation> operations = new List<DismissRecommendationRequest.Types.DismissRecommendationOperation>();
            DismissRecommendationResponse response = client.DismissRecommendation(customerId, partialFailure, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task DismissRecommendationAsync()
        {
            Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new Mock<RecommendationService.RecommendationServiceClient>(MockBehavior.Strict);
            DismissRecommendationRequest expectedRequest = new DismissRecommendationRequest
            {
                CustomerId = "customerId-1772061412",
                PartialFailure = true,
                Operations = { },
            };
            DismissRecommendationResponse expectedResponse = new DismissRecommendationResponse();
            mockGrpcClient.Setup(x => x.DismissRecommendationAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DismissRecommendationResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            bool partialFailure = true;
            IEnumerable<DismissRecommendationRequest.Types.DismissRecommendationOperation> operations = new List<DismissRecommendationRequest.Types.DismissRecommendationOperation>();
            DismissRecommendationResponse response = await client.DismissRecommendationAsync(customerId, partialFailure, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void DismissRecommendation2()
        {
            Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new Mock<RecommendationService.RecommendationServiceClient>(MockBehavior.Strict);
            DismissRecommendationRequest request = new DismissRecommendationRequest
            {
                CustomerId = "customerId-1772061412",
                PartialFailure = true,
                Operations = { },
            };
            DismissRecommendationResponse expectedResponse = new DismissRecommendationResponse();
            mockGrpcClient.Setup(x => x.DismissRecommendation(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            DismissRecommendationResponse response = client.DismissRecommendation(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task DismissRecommendationAsync2()
        {
            Mock<RecommendationService.RecommendationServiceClient> mockGrpcClient = new Mock<RecommendationService.RecommendationServiceClient>(MockBehavior.Strict);
            DismissRecommendationRequest request = new DismissRecommendationRequest
            {
                CustomerId = "customerId-1772061412",
                PartialFailure = true,
                Operations = { },
            };
            DismissRecommendationResponse expectedResponse = new DismissRecommendationResponse();
            mockGrpcClient.Setup(x => x.DismissRecommendationAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DismissRecommendationResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            RecommendationServiceClient client = new RecommendationServiceClientImpl(mockGrpcClient.Object, null);
            DismissRecommendationResponse response = await client.DismissRecommendationAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

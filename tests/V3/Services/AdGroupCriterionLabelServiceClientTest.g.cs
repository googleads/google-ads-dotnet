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
    public class GeneratedAdGroupCriterionLabelServiceClientTest
    {
        [Test]
        public void GetAdGroupCriterionLabel()
        {
            Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(MockBehavior.Strict);
            GetAdGroupCriterionLabelRequest expectedRequest = new GetAdGroupCriterionLabelRequest
            {
                ResourceName = new AdGroupCriterionLabelName("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]").ToString(),
            };
            AdGroupCriterionLabel expectedResponse = new AdGroupCriterionLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionLabel(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupCriterionLabelName("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]").ToString();
            AdGroupCriterionLabel response = client.GetAdGroupCriterionLabel(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupCriterionLabelAsync()
        {
            Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(MockBehavior.Strict);
            GetAdGroupCriterionLabelRequest expectedRequest = new GetAdGroupCriterionLabelRequest
            {
                ResourceName = new AdGroupCriterionLabelName("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]").ToString(),
            };
            AdGroupCriterionLabel expectedResponse = new AdGroupCriterionLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionLabelAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupCriterionLabel>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupCriterionLabelName("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]").ToString();
            AdGroupCriterionLabel response = await client.GetAdGroupCriterionLabelAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroupCriterionLabel2()
        {
            Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(MockBehavior.Strict);
            GetAdGroupCriterionLabelRequest request = new GetAdGroupCriterionLabelRequest
            {
                ResourceName = new AdGroupCriterionLabelName("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]").ToString(),
            };
            AdGroupCriterionLabel expectedResponse = new AdGroupCriterionLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionLabel(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupCriterionLabel response = client.GetAdGroupCriterionLabel(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupCriterionLabelAsync2()
        {
            Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(MockBehavior.Strict);
            GetAdGroupCriterionLabelRequest request = new GetAdGroupCriterionLabelRequest
            {
                ResourceName = new AdGroupCriterionLabelName("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]").ToString(),
            };
            AdGroupCriterionLabel expectedResponse = new AdGroupCriterionLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionLabelAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupCriterionLabel>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupCriterionLabel response = await client.GetAdGroupCriterionLabelAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupCriterionLabels()
        {
            Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupCriterionLabelsRequest expectedRequest = new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdGroupCriterionLabelsResponse expectedResponse = new MutateAdGroupCriterionLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionLabels(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupCriterionLabelOperation> operations = new List<AdGroupCriterionLabelOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdGroupCriterionLabelsResponse response = client.MutateAdGroupCriterionLabels(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupCriterionLabelsAsync()
        {
            Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupCriterionLabelsRequest expectedRequest = new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdGroupCriterionLabelsResponse expectedResponse = new MutateAdGroupCriterionLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionLabelsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupCriterionLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupCriterionLabelOperation> operations = new List<AdGroupCriterionLabelOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdGroupCriterionLabelsResponse response = await client.MutateAdGroupCriterionLabelsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupCriterionLabels2()
        {
            Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupCriterionLabelsRequest expectedRequest = new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupCriterionLabelsResponse expectedResponse = new MutateAdGroupCriterionLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionLabels(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupCriterionLabelOperation> operations = new List<AdGroupCriterionLabelOperation>();
            MutateAdGroupCriterionLabelsResponse response = client.MutateAdGroupCriterionLabels(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupCriterionLabelsAsync2()
        {
            Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupCriterionLabelsRequest expectedRequest = new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupCriterionLabelsResponse expectedResponse = new MutateAdGroupCriterionLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionLabelsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupCriterionLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupCriterionLabelOperation> operations = new List<AdGroupCriterionLabelOperation>();
            MutateAdGroupCriterionLabelsResponse response = await client.MutateAdGroupCriterionLabelsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupCriterionLabels3()
        {
            Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupCriterionLabelsRequest request = new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupCriterionLabelsResponse expectedResponse = new MutateAdGroupCriterionLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionLabels(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriterionLabelsResponse response = client.MutateAdGroupCriterionLabels(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupCriterionLabelsAsync3()
        {
            Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupCriterionLabelsRequest request = new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupCriterionLabelsResponse expectedResponse = new MutateAdGroupCriterionLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionLabelsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupCriterionLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriterionLabelsResponse response = await client.MutateAdGroupCriterionLabelsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

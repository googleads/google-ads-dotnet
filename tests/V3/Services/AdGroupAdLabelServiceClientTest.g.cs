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
    public class GeneratedAdGroupAdLabelServiceClientTest
    {
        [Test]
        public void GetAdGroupAdLabel()
        {
            Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(MockBehavior.Strict);
            GetAdGroupAdLabelRequest expectedRequest = new GetAdGroupAdLabelRequest
            {
                ResourceName = new AdGroupAdLabelName("[CUSTOMER]", "[AD_GROUP_AD_LABEL]").ToString(),
            };
            AdGroupAdLabel expectedResponse = new AdGroupAdLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdLabel(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupAdLabelName("[CUSTOMER]", "[AD_GROUP_AD_LABEL]").ToString();
            AdGroupAdLabel response = client.GetAdGroupAdLabel(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupAdLabelAsync()
        {
            Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(MockBehavior.Strict);
            GetAdGroupAdLabelRequest expectedRequest = new GetAdGroupAdLabelRequest
            {
                ResourceName = new AdGroupAdLabelName("[CUSTOMER]", "[AD_GROUP_AD_LABEL]").ToString(),
            };
            AdGroupAdLabel expectedResponse = new AdGroupAdLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdLabelAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupAdLabel>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupAdLabelName("[CUSTOMER]", "[AD_GROUP_AD_LABEL]").ToString();
            AdGroupAdLabel response = await client.GetAdGroupAdLabelAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroupAdLabel2()
        {
            Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(MockBehavior.Strict);
            GetAdGroupAdLabelRequest request = new GetAdGroupAdLabelRequest
            {
                ResourceName = new AdGroupAdLabelName("[CUSTOMER]", "[AD_GROUP_AD_LABEL]").ToString(),
            };
            AdGroupAdLabel expectedResponse = new AdGroupAdLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdLabel(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupAdLabel response = client.GetAdGroupAdLabel(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupAdLabelAsync2()
        {
            Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(MockBehavior.Strict);
            GetAdGroupAdLabelRequest request = new GetAdGroupAdLabelRequest
            {
                ResourceName = new AdGroupAdLabelName("[CUSTOMER]", "[AD_GROUP_AD_LABEL]").ToString(),
            };
            AdGroupAdLabel expectedResponse = new AdGroupAdLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdLabelAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupAdLabel>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupAdLabel response = await client.GetAdGroupAdLabelAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupAdLabels()
        {
            Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupAdLabelsRequest expectedRequest = new MutateAdGroupAdLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdGroupAdLabelsResponse expectedResponse = new MutateAdGroupAdLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupAdLabels(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupAdLabelOperation> operations = new List<AdGroupAdLabelOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdGroupAdLabelsResponse response = client.MutateAdGroupAdLabels(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupAdLabelsAsync()
        {
            Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupAdLabelsRequest expectedRequest = new MutateAdGroupAdLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdGroupAdLabelsResponse expectedResponse = new MutateAdGroupAdLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupAdLabelsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupAdLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupAdLabelOperation> operations = new List<AdGroupAdLabelOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdGroupAdLabelsResponse response = await client.MutateAdGroupAdLabelsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupAdLabels2()
        {
            Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupAdLabelsRequest expectedRequest = new MutateAdGroupAdLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdGroupAdLabelsResponse expectedResponse = new MutateAdGroupAdLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupAdLabels(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupAdLabelOperation> operations = new List<AdGroupAdLabelOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdGroupAdLabelsResponse response = client.MutateAdGroupAdLabels(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupAdLabelsAsync2()
        {
            Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupAdLabelsRequest expectedRequest = new MutateAdGroupAdLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdGroupAdLabelsResponse expectedResponse = new MutateAdGroupAdLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupAdLabelsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupAdLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupAdLabelOperation> operations = new List<AdGroupAdLabelOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdGroupAdLabelsResponse response = await client.MutateAdGroupAdLabelsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupAdLabels3()
        {
            Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupAdLabelsRequest request = new MutateAdGroupAdLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupAdLabelsResponse expectedResponse = new MutateAdGroupAdLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupAdLabels(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupAdLabelsResponse response = client.MutateAdGroupAdLabels(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupAdLabelsAsync3()
        {
            Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupAdLabelsRequest request = new MutateAdGroupAdLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupAdLabelsResponse expectedResponse = new MutateAdGroupAdLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupAdLabelsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupAdLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupAdLabelsResponse response = await client.MutateAdGroupAdLabelsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

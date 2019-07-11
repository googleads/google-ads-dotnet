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
    public class GeneratedAdGroupLabelServiceClientTest
    {
        [Test]
        public void GetAdGroupLabel()
        {
            Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new Mock<AdGroupLabelService.AdGroupLabelServiceClient>(MockBehavior.Strict);
            GetAdGroupLabelRequest expectedRequest = new GetAdGroupLabelRequest
            {
                ResourceName = new AdGroupLabelName("[CUSTOMER]", "[AD_GROUP_LABEL]").ToString(),
            };
            AdGroupLabel expectedResponse = new AdGroupLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupLabel(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupLabelName("[CUSTOMER]", "[AD_GROUP_LABEL]").ToString();
            AdGroupLabel response = client.GetAdGroupLabel(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupLabelAsync()
        {
            Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new Mock<AdGroupLabelService.AdGroupLabelServiceClient>(MockBehavior.Strict);
            GetAdGroupLabelRequest expectedRequest = new GetAdGroupLabelRequest
            {
                ResourceName = new AdGroupLabelName("[CUSTOMER]", "[AD_GROUP_LABEL]").ToString(),
            };
            AdGroupLabel expectedResponse = new AdGroupLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupLabelAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupLabel>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupLabelName("[CUSTOMER]", "[AD_GROUP_LABEL]").ToString();
            AdGroupLabel response = await client.GetAdGroupLabelAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroupLabel2()
        {
            Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new Mock<AdGroupLabelService.AdGroupLabelServiceClient>(MockBehavior.Strict);
            GetAdGroupLabelRequest request = new GetAdGroupLabelRequest
            {
                ResourceName = new AdGroupLabelName("[CUSTOMER]", "[AD_GROUP_LABEL]").ToString(),
            };
            AdGroupLabel expectedResponse = new AdGroupLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupLabel(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupLabel response = client.GetAdGroupLabel(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupLabelAsync2()
        {
            Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new Mock<AdGroupLabelService.AdGroupLabelServiceClient>(MockBehavior.Strict);
            GetAdGroupLabelRequest request = new GetAdGroupLabelRequest
            {
                ResourceName = new AdGroupLabelName("[CUSTOMER]", "[AD_GROUP_LABEL]").ToString(),
            };
            AdGroupLabel expectedResponse = new AdGroupLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupLabelAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupLabel>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupLabel response = await client.GetAdGroupLabelAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupLabels()
        {
            Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new Mock<AdGroupLabelService.AdGroupLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupLabelsRequest expectedRequest = new MutateAdGroupLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdGroupLabelsResponse expectedResponse = new MutateAdGroupLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupLabels(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupLabelOperation> operations = new List<AdGroupLabelOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdGroupLabelsResponse response = client.MutateAdGroupLabels(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupLabelsAsync()
        {
            Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new Mock<AdGroupLabelService.AdGroupLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupLabelsRequest expectedRequest = new MutateAdGroupLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdGroupLabelsResponse expectedResponse = new MutateAdGroupLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupLabelsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupLabelOperation> operations = new List<AdGroupLabelOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdGroupLabelsResponse response = await client.MutateAdGroupLabelsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupLabels2()
        {
            Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new Mock<AdGroupLabelService.AdGroupLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupLabelsRequest expectedRequest = new MutateAdGroupLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupLabelsResponse expectedResponse = new MutateAdGroupLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupLabels(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupLabelOperation> operations = new List<AdGroupLabelOperation>();
            MutateAdGroupLabelsResponse response = client.MutateAdGroupLabels(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupLabelsAsync2()
        {
            Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new Mock<AdGroupLabelService.AdGroupLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupLabelsRequest expectedRequest = new MutateAdGroupLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupLabelsResponse expectedResponse = new MutateAdGroupLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupLabelsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupLabelOperation> operations = new List<AdGroupLabelOperation>();
            MutateAdGroupLabelsResponse response = await client.MutateAdGroupLabelsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupLabels3()
        {
            Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new Mock<AdGroupLabelService.AdGroupLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupLabelsRequest request = new MutateAdGroupLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupLabelsResponse expectedResponse = new MutateAdGroupLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupLabels(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupLabelsResponse response = client.MutateAdGroupLabels(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupLabelsAsync3()
        {
            Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new Mock<AdGroupLabelService.AdGroupLabelServiceClient>(MockBehavior.Strict);
            MutateAdGroupLabelsRequest request = new MutateAdGroupLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupLabelsResponse expectedResponse = new MutateAdGroupLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupLabelsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupLabelsResponse response = await client.MutateAdGroupLabelsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

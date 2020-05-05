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
    public class GeneratedCampaignLabelServiceClientTest
    {
        [Test]
        public void GetCampaignLabel()
        {
            Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new Mock<CampaignLabelService.CampaignLabelServiceClient>(MockBehavior.Strict);
            GetCampaignLabelRequest expectedRequest = new GetCampaignLabelRequest
            {
                ResourceName = new CampaignLabelName("[CUSTOMER]", "[CAMPAIGN_LABEL]").ToString(),
            };
            CampaignLabel expectedResponse = new CampaignLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignLabel(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignLabelName("[CUSTOMER]", "[CAMPAIGN_LABEL]").ToString();
            CampaignLabel response = client.GetCampaignLabel(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignLabelAsync()
        {
            Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new Mock<CampaignLabelService.CampaignLabelServiceClient>(MockBehavior.Strict);
            GetCampaignLabelRequest expectedRequest = new GetCampaignLabelRequest
            {
                ResourceName = new CampaignLabelName("[CUSTOMER]", "[CAMPAIGN_LABEL]").ToString(),
            };
            CampaignLabel expectedResponse = new CampaignLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignLabelAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignLabel>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignLabelName("[CUSTOMER]", "[CAMPAIGN_LABEL]").ToString();
            CampaignLabel response = await client.GetCampaignLabelAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaignLabel2()
        {
            Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new Mock<CampaignLabelService.CampaignLabelServiceClient>(MockBehavior.Strict);
            GetCampaignLabelRequest request = new GetCampaignLabelRequest
            {
                ResourceName = new CampaignLabelName("[CUSTOMER]", "[CAMPAIGN_LABEL]").ToString(),
            };
            CampaignLabel expectedResponse = new CampaignLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignLabel(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            CampaignLabel response = client.GetCampaignLabel(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignLabelAsync2()
        {
            Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new Mock<CampaignLabelService.CampaignLabelServiceClient>(MockBehavior.Strict);
            GetCampaignLabelRequest request = new GetCampaignLabelRequest
            {
                ResourceName = new CampaignLabelName("[CUSTOMER]", "[CAMPAIGN_LABEL]").ToString(),
            };
            CampaignLabel expectedResponse = new CampaignLabel
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignLabelAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignLabel>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            CampaignLabel response = await client.GetCampaignLabelAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignLabels()
        {
            Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new Mock<CampaignLabelService.CampaignLabelServiceClient>(MockBehavior.Strict);
            MutateCampaignLabelsRequest expectedRequest = new MutateCampaignLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCampaignLabelsResponse expectedResponse = new MutateCampaignLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignLabels(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignLabelOperation> operations = new List<CampaignLabelOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCampaignLabelsResponse response = client.MutateCampaignLabels(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignLabelsAsync()
        {
            Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new Mock<CampaignLabelService.CampaignLabelServiceClient>(MockBehavior.Strict);
            MutateCampaignLabelsRequest expectedRequest = new MutateCampaignLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCampaignLabelsResponse expectedResponse = new MutateCampaignLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignLabelsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignLabelOperation> operations = new List<CampaignLabelOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCampaignLabelsResponse response = await client.MutateCampaignLabelsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignLabels2()
        {
            Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new Mock<CampaignLabelService.CampaignLabelServiceClient>(MockBehavior.Strict);
            MutateCampaignLabelsRequest expectedRequest = new MutateCampaignLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCampaignLabelsResponse expectedResponse = new MutateCampaignLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignLabels(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignLabelOperation> operations = new List<CampaignLabelOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCampaignLabelsResponse response = client.MutateCampaignLabels(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignLabelsAsync2()
        {
            Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new Mock<CampaignLabelService.CampaignLabelServiceClient>(MockBehavior.Strict);
            MutateCampaignLabelsRequest expectedRequest = new MutateCampaignLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCampaignLabelsResponse expectedResponse = new MutateCampaignLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignLabelsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignLabelOperation> operations = new List<CampaignLabelOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCampaignLabelsResponse response = await client.MutateCampaignLabelsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignLabels3()
        {
            Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new Mock<CampaignLabelService.CampaignLabelServiceClient>(MockBehavior.Strict);
            MutateCampaignLabelsRequest request = new MutateCampaignLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignLabelsResponse expectedResponse = new MutateCampaignLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignLabels(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignLabelsResponse response = client.MutateCampaignLabels(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignLabelsAsync3()
        {
            Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new Mock<CampaignLabelService.CampaignLabelServiceClient>(MockBehavior.Strict);
            MutateCampaignLabelsRequest request = new MutateCampaignLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignLabelsResponse expectedResponse = new MutateCampaignLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignLabelsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignLabelsResponse response = await client.MutateCampaignLabelsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

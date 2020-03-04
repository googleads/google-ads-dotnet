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
    public class GeneratedCampaignCriterionServiceClientTest
    {
        [Test]
        public void GetCampaignCriterion()
        {
            Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new Mock<CampaignCriterionService.CampaignCriterionServiceClient>(MockBehavior.Strict);
            GetCampaignCriterionRequest expectedRequest = new GetCampaignCriterionRequest
            {
                ResourceName = new CampaignCriteriaName("[CUSTOMER]", "[CAMPAIGN_CRITERIA]").ToString(),
            };
            CampaignCriterion expectedResponse = new CampaignCriterion
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignCriteriaName("[CUSTOMER]", "[CAMPAIGN_CRITERIA]").ToString();
            CampaignCriterion response = client.GetCampaignCriterion(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignCriterionAsync()
        {
            Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new Mock<CampaignCriterionService.CampaignCriterionServiceClient>(MockBehavior.Strict);
            GetCampaignCriterionRequest expectedRequest = new GetCampaignCriterionRequest
            {
                ResourceName = new CampaignCriteriaName("[CUSTOMER]", "[CAMPAIGN_CRITERIA]").ToString(),
            };
            CampaignCriterion expectedResponse = new CampaignCriterion
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignCriterion>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignCriteriaName("[CUSTOMER]", "[CAMPAIGN_CRITERIA]").ToString();
            CampaignCriterion response = await client.GetCampaignCriterionAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaignCriterion2()
        {
            Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new Mock<CampaignCriterionService.CampaignCriterionServiceClient>(MockBehavior.Strict);
            GetCampaignCriterionRequest request = new GetCampaignCriterionRequest
            {
                ResourceName = new CampaignCriteriaName("[CUSTOMER]", "[CAMPAIGN_CRITERIA]").ToString(),
            };
            CampaignCriterion expectedResponse = new CampaignCriterion
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            CampaignCriterion response = client.GetCampaignCriterion(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignCriterionAsync2()
        {
            Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new Mock<CampaignCriterionService.CampaignCriterionServiceClient>(MockBehavior.Strict);
            GetCampaignCriterionRequest request = new GetCampaignCriterionRequest
            {
                ResourceName = new CampaignCriteriaName("[CUSTOMER]", "[CAMPAIGN_CRITERIA]").ToString(),
            };
            CampaignCriterion expectedResponse = new CampaignCriterion
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignCriterion>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            CampaignCriterion response = await client.GetCampaignCriterionAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignCriteria()
        {
            Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new Mock<CampaignCriterionService.CampaignCriterionServiceClient>(MockBehavior.Strict);
            MutateCampaignCriteriaRequest expectedRequest = new MutateCampaignCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCampaignCriteriaResponse expectedResponse = new MutateCampaignCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignCriteria(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignCriterionOperation> operations = new List<CampaignCriterionOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCampaignCriteriaResponse response = client.MutateCampaignCriteria(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignCriteriaAsync()
        {
            Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new Mock<CampaignCriterionService.CampaignCriterionServiceClient>(MockBehavior.Strict);
            MutateCampaignCriteriaRequest expectedRequest = new MutateCampaignCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCampaignCriteriaResponse expectedResponse = new MutateCampaignCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignCriteriaAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignCriteriaResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignCriterionOperation> operations = new List<CampaignCriterionOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCampaignCriteriaResponse response = await client.MutateCampaignCriteriaAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignCriteria2()
        {
            Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new Mock<CampaignCriterionService.CampaignCriterionServiceClient>(MockBehavior.Strict);
            MutateCampaignCriteriaRequest expectedRequest = new MutateCampaignCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignCriteriaResponse expectedResponse = new MutateCampaignCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignCriteria(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignCriterionOperation> operations = new List<CampaignCriterionOperation>();
            MutateCampaignCriteriaResponse response = client.MutateCampaignCriteria(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignCriteriaAsync2()
        {
            Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new Mock<CampaignCriterionService.CampaignCriterionServiceClient>(MockBehavior.Strict);
            MutateCampaignCriteriaRequest expectedRequest = new MutateCampaignCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignCriteriaResponse expectedResponse = new MutateCampaignCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignCriteriaAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignCriteriaResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignCriterionOperation> operations = new List<CampaignCriterionOperation>();
            MutateCampaignCriteriaResponse response = await client.MutateCampaignCriteriaAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignCriteria3()
        {
            Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new Mock<CampaignCriterionService.CampaignCriterionServiceClient>(MockBehavior.Strict);
            MutateCampaignCriteriaRequest request = new MutateCampaignCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignCriteriaResponse expectedResponse = new MutateCampaignCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignCriteria(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignCriteriaResponse response = client.MutateCampaignCriteria(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignCriteriaAsync3()
        {
            Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new Mock<CampaignCriterionService.CampaignCriterionServiceClient>(MockBehavior.Strict);
            MutateCampaignCriteriaRequest request = new MutateCampaignCriteriaRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignCriteriaResponse expectedResponse = new MutateCampaignCriteriaResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignCriteriaAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignCriteriaResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignCriteriaResponse response = await client.MutateCampaignCriteriaAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

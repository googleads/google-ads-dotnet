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
    using Google.LongRunning;
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
    public class GeneratedCampaignDraftServiceClientTest
    {
        [Test]
        public void GetCampaignDraft()
        {
            Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new Mock<CampaignDraftService.CampaignDraftServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetCampaignDraftRequest expectedRequest = new GetCampaignDraftRequest
            {
                ResourceName = new CampaignDraftName("[CUSTOMER]", "[CAMPAIGN_DRAFT]").ToString(),
            };
            CampaignDraft expectedResponse = new CampaignDraft
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignDraft(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignDraftName("[CUSTOMER]", "[CAMPAIGN_DRAFT]").ToString();
            CampaignDraft response = client.GetCampaignDraft(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignDraftAsync()
        {
            Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new Mock<CampaignDraftService.CampaignDraftServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetCampaignDraftRequest expectedRequest = new GetCampaignDraftRequest
            {
                ResourceName = new CampaignDraftName("[CUSTOMER]", "[CAMPAIGN_DRAFT]").ToString(),
            };
            CampaignDraft expectedResponse = new CampaignDraft
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignDraftAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignDraft>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignDraftName("[CUSTOMER]", "[CAMPAIGN_DRAFT]").ToString();
            CampaignDraft response = await client.GetCampaignDraftAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaignDraft2()
        {
            Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new Mock<CampaignDraftService.CampaignDraftServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetCampaignDraftRequest request = new GetCampaignDraftRequest
            {
                ResourceName = new CampaignDraftName("[CUSTOMER]", "[CAMPAIGN_DRAFT]").ToString(),
            };
            CampaignDraft expectedResponse = new CampaignDraft
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignDraft(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            CampaignDraft response = client.GetCampaignDraft(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignDraftAsync2()
        {
            Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new Mock<CampaignDraftService.CampaignDraftServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetCampaignDraftRequest request = new GetCampaignDraftRequest
            {
                ResourceName = new CampaignDraftName("[CUSTOMER]", "[CAMPAIGN_DRAFT]").ToString(),
            };
            CampaignDraft expectedResponse = new CampaignDraft
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignDraftAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignDraft>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            CampaignDraft response = await client.GetCampaignDraftAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignDrafts()
        {
            Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new Mock<CampaignDraftService.CampaignDraftServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            MutateCampaignDraftsRequest expectedRequest = new MutateCampaignDraftsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCampaignDraftsResponse expectedResponse = new MutateCampaignDraftsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignDrafts(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignDraftOperation> operations = new List<CampaignDraftOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCampaignDraftsResponse response = client.MutateCampaignDrafts(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignDraftsAsync()
        {
            Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new Mock<CampaignDraftService.CampaignDraftServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            MutateCampaignDraftsRequest expectedRequest = new MutateCampaignDraftsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCampaignDraftsResponse expectedResponse = new MutateCampaignDraftsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignDraftsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignDraftsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignDraftOperation> operations = new List<CampaignDraftOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCampaignDraftsResponse response = await client.MutateCampaignDraftsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignDrafts2()
        {
            Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new Mock<CampaignDraftService.CampaignDraftServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            MutateCampaignDraftsRequest expectedRequest = new MutateCampaignDraftsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignDraftsResponse expectedResponse = new MutateCampaignDraftsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignDrafts(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignDraftOperation> operations = new List<CampaignDraftOperation>();
            MutateCampaignDraftsResponse response = client.MutateCampaignDrafts(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignDraftsAsync2()
        {
            Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new Mock<CampaignDraftService.CampaignDraftServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            MutateCampaignDraftsRequest expectedRequest = new MutateCampaignDraftsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignDraftsResponse expectedResponse = new MutateCampaignDraftsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignDraftsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignDraftsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignDraftOperation> operations = new List<CampaignDraftOperation>();
            MutateCampaignDraftsResponse response = await client.MutateCampaignDraftsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignDrafts3()
        {
            Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new Mock<CampaignDraftService.CampaignDraftServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            MutateCampaignDraftsRequest request = new MutateCampaignDraftsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignDraftsResponse expectedResponse = new MutateCampaignDraftsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignDrafts(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignDraftsResponse response = client.MutateCampaignDrafts(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignDraftsAsync3()
        {
            Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new Mock<CampaignDraftService.CampaignDraftServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            MutateCampaignDraftsRequest request = new MutateCampaignDraftsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignDraftsResponse expectedResponse = new MutateCampaignDraftsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignDraftsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignDraftsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignDraftsResponse response = await client.MutateCampaignDraftsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

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
    public class GeneratedCampaignExperimentServiceClientTest
    {
        [Test]
        public void GetCampaignExperiment()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetCampaignExperimentRequest expectedRequest = new GetCampaignExperimentRequest
            {
                ResourceName = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString(),
            };
            CampaignExperiment expectedResponse = new CampaignExperiment
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignExperiment(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString();
            CampaignExperiment response = client.GetCampaignExperiment(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignExperimentAsync()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetCampaignExperimentRequest expectedRequest = new GetCampaignExperimentRequest
            {
                ResourceName = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString(),
            };
            CampaignExperiment expectedResponse = new CampaignExperiment
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignExperimentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignExperiment>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString();
            CampaignExperiment response = await client.GetCampaignExperimentAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaignExperiment2()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetCampaignExperimentRequest request = new GetCampaignExperimentRequest
            {
                ResourceName = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString(),
            };
            CampaignExperiment expectedResponse = new CampaignExperiment
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignExperiment(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            CampaignExperiment response = client.GetCampaignExperiment(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignExperimentAsync2()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetCampaignExperimentRequest request = new GetCampaignExperimentRequest
            {
                ResourceName = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString(),
            };
            CampaignExperiment expectedResponse = new CampaignExperiment
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignExperimentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignExperiment>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            CampaignExperiment response = await client.GetCampaignExperimentAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignExperiments()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            MutateCampaignExperimentsRequest expectedRequest = new MutateCampaignExperimentsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCampaignExperimentsResponse expectedResponse = new MutateCampaignExperimentsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignExperiments(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignExperimentOperation> operations = new List<CampaignExperimentOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCampaignExperimentsResponse response = client.MutateCampaignExperiments(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignExperimentsAsync()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            MutateCampaignExperimentsRequest expectedRequest = new MutateCampaignExperimentsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCampaignExperimentsResponse expectedResponse = new MutateCampaignExperimentsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignExperimentsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignExperimentsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignExperimentOperation> operations = new List<CampaignExperimentOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCampaignExperimentsResponse response = await client.MutateCampaignExperimentsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignExperiments2()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            MutateCampaignExperimentsRequest expectedRequest = new MutateCampaignExperimentsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignExperimentsResponse expectedResponse = new MutateCampaignExperimentsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignExperiments(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignExperimentOperation> operations = new List<CampaignExperimentOperation>();
            MutateCampaignExperimentsResponse response = client.MutateCampaignExperiments(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignExperimentsAsync2()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            MutateCampaignExperimentsRequest expectedRequest = new MutateCampaignExperimentsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignExperimentsResponse expectedResponse = new MutateCampaignExperimentsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignExperimentsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignExperimentsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignExperimentOperation> operations = new List<CampaignExperimentOperation>();
            MutateCampaignExperimentsResponse response = await client.MutateCampaignExperimentsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignExperiments3()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            MutateCampaignExperimentsRequest request = new MutateCampaignExperimentsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignExperimentsResponse expectedResponse = new MutateCampaignExperimentsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignExperiments(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignExperimentsResponse response = client.MutateCampaignExperiments(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignExperimentsAsync3()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            MutateCampaignExperimentsRequest request = new MutateCampaignExperimentsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignExperimentsResponse expectedResponse = new MutateCampaignExperimentsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignExperimentsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignExperimentsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignExperimentsResponse response = await client.MutateCampaignExperimentsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GraduateCampaignExperiment()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GraduateCampaignExperimentRequest expectedRequest = new GraduateCampaignExperimentRequest
            {
                CampaignExperiment = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString(),
                CampaignBudget = "campaignBudget1992382804",
            };
            GraduateCampaignExperimentResponse expectedResponse = new GraduateCampaignExperimentResponse
            {
                GraduatedCampaign = "graduatedCampaign-758391274",
            };
            mockGrpcClient.Setup(x => x.GraduateCampaignExperiment(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedCampaignExperiment = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString();
            string campaignBudget = "campaignBudget1992382804";
            GraduateCampaignExperimentResponse response = client.GraduateCampaignExperiment(formattedCampaignExperiment, campaignBudget);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GraduateCampaignExperimentAsync()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GraduateCampaignExperimentRequest expectedRequest = new GraduateCampaignExperimentRequest
            {
                CampaignExperiment = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString(),
                CampaignBudget = "campaignBudget1992382804",
            };
            GraduateCampaignExperimentResponse expectedResponse = new GraduateCampaignExperimentResponse
            {
                GraduatedCampaign = "graduatedCampaign-758391274",
            };
            mockGrpcClient.Setup(x => x.GraduateCampaignExperimentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GraduateCampaignExperimentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedCampaignExperiment = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString();
            string campaignBudget = "campaignBudget1992382804";
            GraduateCampaignExperimentResponse response = await client.GraduateCampaignExperimentAsync(formattedCampaignExperiment, campaignBudget);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GraduateCampaignExperiment2()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GraduateCampaignExperimentRequest request = new GraduateCampaignExperimentRequest
            {
                CampaignExperiment = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString(),
                CampaignBudget = "campaignBudget1992382804",
            };
            GraduateCampaignExperimentResponse expectedResponse = new GraduateCampaignExperimentResponse
            {
                GraduatedCampaign = "graduatedCampaign-758391274",
            };
            mockGrpcClient.Setup(x => x.GraduateCampaignExperiment(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            GraduateCampaignExperimentResponse response = client.GraduateCampaignExperiment(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GraduateCampaignExperimentAsync2()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GraduateCampaignExperimentRequest request = new GraduateCampaignExperimentRequest
            {
                CampaignExperiment = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString(),
                CampaignBudget = "campaignBudget1992382804",
            };
            GraduateCampaignExperimentResponse expectedResponse = new GraduateCampaignExperimentResponse
            {
                GraduatedCampaign = "graduatedCampaign-758391274",
            };
            mockGrpcClient.Setup(x => x.GraduateCampaignExperimentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GraduateCampaignExperimentResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            GraduateCampaignExperimentResponse response = await client.GraduateCampaignExperimentAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void EndCampaignExperiment()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            EndCampaignExperimentRequest expectedRequest = new EndCampaignExperimentRequest
            {
                CampaignExperiment = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.EndCampaignExperiment(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedCampaignExperiment = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString();
            client.EndCampaignExperiment(formattedCampaignExperiment);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task EndCampaignExperimentAsync()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            EndCampaignExperimentRequest expectedRequest = new EndCampaignExperimentRequest
            {
                CampaignExperiment = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.EndCampaignExperimentAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            string formattedCampaignExperiment = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString();
            await client.EndCampaignExperimentAsync(formattedCampaignExperiment);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void EndCampaignExperiment2()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            EndCampaignExperimentRequest request = new EndCampaignExperimentRequest
            {
                CampaignExperiment = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.EndCampaignExperiment(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            client.EndCampaignExperiment(request);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task EndCampaignExperimentAsync2()
        {
            Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new Mock<CampaignExperimentService.CampaignExperimentServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            EndCampaignExperimentRequest request = new EndCampaignExperimentRequest
            {
                CampaignExperiment = new CampaignExperimentName("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.EndCampaignExperimentAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            await client.EndCampaignExperimentAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}

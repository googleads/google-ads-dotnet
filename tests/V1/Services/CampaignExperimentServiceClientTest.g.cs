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

using gagve = Google.Ads.GoogleAds.V1.Enums;
using gagvr = Google.Ads.GoogleAds.V1.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V1.Services;

namespace Google.Ads.GoogleAds.Tests.V1.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCampaignExperimentServiceClientTest
    {
        [Test]
        public void GetCampaignExperimentRequestObject()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCampaignExperimentRequest request = new GetCampaignExperimentRequest
            {
                ResourceNameAsCampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
            };
            gagvr::CampaignExperiment expectedResponse = new gagvr::CampaignExperiment
            {
                ResourceNameAsCampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
                Id = -6774108720365892680L,
                CampaignDraftAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                CampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
                Description = "description2cf9da67",
                TrafficSplitPercent = -7167375592409567671L,
                TrafficSplitType = gagve::CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType.RandomQuery,
                ExperimentCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignExperimentStatusEnum.Types.CampaignExperimentStatus.Initializing,
                LongRunningOperation = "long_running_operation0897bd41",
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetCampaignExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExperiment response = client.GetCampaignExperiment(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCampaignExperimentRequestObjectAsync()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCampaignExperimentRequest request = new GetCampaignExperimentRequest
            {
                ResourceNameAsCampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
            };
            gagvr::CampaignExperiment expectedResponse = new gagvr::CampaignExperiment
            {
                ResourceNameAsCampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
                Id = -6774108720365892680L,
                CampaignDraftAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                CampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
                Description = "description2cf9da67",
                TrafficSplitPercent = -7167375592409567671L,
                TrafficSplitType = gagve::CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType.RandomQuery,
                ExperimentCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignExperimentStatusEnum.Types.CampaignExperimentStatus.Initializing,
                LongRunningOperation = "long_running_operation0897bd41",
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetCampaignExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignExperiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExperiment responseCallSettings = await client.GetCampaignExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignExperiment responseCancellationToken = await client.GetCampaignExperimentAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaignExperiment()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCampaignExperimentRequest request = new GetCampaignExperimentRequest
            {
                ResourceNameAsCampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
            };
            gagvr::CampaignExperiment expectedResponse = new gagvr::CampaignExperiment
            {
                ResourceNameAsCampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
                Id = -6774108720365892680L,
                CampaignDraftAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                CampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
                Description = "description2cf9da67",
                TrafficSplitPercent = -7167375592409567671L,
                TrafficSplitType = gagve::CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType.RandomQuery,
                ExperimentCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignExperimentStatusEnum.Types.CampaignExperimentStatus.Initializing,
                LongRunningOperation = "long_running_operation0897bd41",
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetCampaignExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExperiment response = client.GetCampaignExperiment(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCampaignExperimentAsync()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCampaignExperimentRequest request = new GetCampaignExperimentRequest
            {
                ResourceNameAsCampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
            };
            gagvr::CampaignExperiment expectedResponse = new gagvr::CampaignExperiment
            {
                ResourceNameAsCampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
                Id = -6774108720365892680L,
                CampaignDraftAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                CampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
                Description = "description2cf9da67",
                TrafficSplitPercent = -7167375592409567671L,
                TrafficSplitType = gagve::CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType.RandomQuery,
                ExperimentCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignExperimentStatusEnum.Types.CampaignExperimentStatus.Initializing,
                LongRunningOperation = "long_running_operation0897bd41",
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetCampaignExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignExperiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExperiment responseCallSettings = await client.GetCampaignExperimentAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignExperiment responseCancellationToken = await client.GetCampaignExperimentAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaignExperimentResourceNames()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCampaignExperimentRequest request = new GetCampaignExperimentRequest
            {
                ResourceNameAsCampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
            };
            gagvr::CampaignExperiment expectedResponse = new gagvr::CampaignExperiment
            {
                ResourceNameAsCampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
                Id = -6774108720365892680L,
                CampaignDraftAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                CampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
                Description = "description2cf9da67",
                TrafficSplitPercent = -7167375592409567671L,
                TrafficSplitType = gagve::CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType.RandomQuery,
                ExperimentCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignExperimentStatusEnum.Types.CampaignExperimentStatus.Initializing,
                LongRunningOperation = "long_running_operation0897bd41",
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetCampaignExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExperiment response = client.GetCampaignExperiment(request.ResourceNameAsCampaignExperimentName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCampaignExperimentResourceNamesAsync()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCampaignExperimentRequest request = new GetCampaignExperimentRequest
            {
                ResourceNameAsCampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
            };
            gagvr::CampaignExperiment expectedResponse = new gagvr::CampaignExperiment
            {
                ResourceNameAsCampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
                Id = -6774108720365892680L,
                CampaignDraftAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                CampaignExperimentName = gagvr::CampaignExperimentName.FromCustomerCampaignExperiment("[CUSTOMER]", "[CAMPAIGN_EXPERIMENT]"),
                Description = "description2cf9da67",
                TrafficSplitPercent = -7167375592409567671L,
                TrafficSplitType = gagve::CampaignExperimentTrafficSplitTypeEnum.Types.CampaignExperimentTrafficSplitType.RandomQuery,
                ExperimentCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignExperimentStatusEnum.Types.CampaignExperimentStatus.Initializing,
                LongRunningOperation = "long_running_operation0897bd41",
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
            };
            mockGrpcClient.Setup(x => x.GetCampaignExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignExperiment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExperiment responseCallSettings = await client.GetCampaignExperimentAsync(request.ResourceNameAsCampaignExperimentName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignExperiment responseCancellationToken = await client.GetCampaignExperimentAsync(request.ResourceNameAsCampaignExperimentName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignExperimentsRequestObject()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            MutateCampaignExperimentsRequest request = new MutateCampaignExperimentsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignExperimentOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCampaignExperimentsResponse expectedResponse = new MutateCampaignExperimentsResponse
            {
                Results =
                {
                    new MutateCampaignExperimentResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignExperiments(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignExperimentsResponse response = client.MutateCampaignExperiments(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateCampaignExperimentsRequestObjectAsync()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            MutateCampaignExperimentsRequest request = new MutateCampaignExperimentsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignExperimentOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCampaignExperimentsResponse expectedResponse = new MutateCampaignExperimentsResponse
            {
                Results =
                {
                    new MutateCampaignExperimentResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignExperimentsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignExperimentsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignExperimentsResponse responseCallSettings = await client.MutateCampaignExperimentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignExperimentsResponse responseCancellationToken = await client.MutateCampaignExperimentsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignExperiments()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            MutateCampaignExperimentsRequest request = new MutateCampaignExperimentsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignExperimentOperation(),
                },
            };
            MutateCampaignExperimentsResponse expectedResponse = new MutateCampaignExperimentsResponse
            {
                Results =
                {
                    new MutateCampaignExperimentResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignExperiments(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignExperimentsResponse response = client.MutateCampaignExperiments(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateCampaignExperimentsAsync()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            MutateCampaignExperimentsRequest request = new MutateCampaignExperimentsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignExperimentOperation(),
                },
            };
            MutateCampaignExperimentsResponse expectedResponse = new MutateCampaignExperimentsResponse
            {
                Results =
                {
                    new MutateCampaignExperimentResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignExperimentsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignExperimentsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignExperimentsResponse responseCallSettings = await client.MutateCampaignExperimentsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignExperimentsResponse responseCancellationToken = await client.MutateCampaignExperimentsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GraduateCampaignExperimentRequestObject()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GraduateCampaignExperimentRequest request = new GraduateCampaignExperimentRequest
            {
                CampaignExperiment = "campaign_experimente81fbe81",
                CampaignBudget = "campaign_budgetc3f474d4",
            };
            GraduateCampaignExperimentResponse expectedResponse = new GraduateCampaignExperimentResponse
            {
                GraduatedCampaign = "graduated_campaign1b91421c",
            };
            mockGrpcClient.Setup(x => x.GraduateCampaignExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            GraduateCampaignExperimentResponse response = client.GraduateCampaignExperiment(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GraduateCampaignExperimentRequestObjectAsync()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GraduateCampaignExperimentRequest request = new GraduateCampaignExperimentRequest
            {
                CampaignExperiment = "campaign_experimente81fbe81",
                CampaignBudget = "campaign_budgetc3f474d4",
            };
            GraduateCampaignExperimentResponse expectedResponse = new GraduateCampaignExperimentResponse
            {
                GraduatedCampaign = "graduated_campaign1b91421c",
            };
            mockGrpcClient.Setup(x => x.GraduateCampaignExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GraduateCampaignExperimentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            GraduateCampaignExperimentResponse responseCallSettings = await client.GraduateCampaignExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            GraduateCampaignExperimentResponse responseCancellationToken = await client.GraduateCampaignExperimentAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GraduateCampaignExperiment()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GraduateCampaignExperimentRequest request = new GraduateCampaignExperimentRequest
            {
                CampaignExperiment = "campaign_experimente81fbe81",
                CampaignBudget = "campaign_budgetc3f474d4",
            };
            GraduateCampaignExperimentResponse expectedResponse = new GraduateCampaignExperimentResponse
            {
                GraduatedCampaign = "graduated_campaign1b91421c",
            };
            mockGrpcClient.Setup(x => x.GraduateCampaignExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            GraduateCampaignExperimentResponse response = client.GraduateCampaignExperiment(request.CampaignExperiment, request.CampaignBudget);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GraduateCampaignExperimentAsync()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GraduateCampaignExperimentRequest request = new GraduateCampaignExperimentRequest
            {
                CampaignExperiment = "campaign_experimente81fbe81",
                CampaignBudget = "campaign_budgetc3f474d4",
            };
            GraduateCampaignExperimentResponse expectedResponse = new GraduateCampaignExperimentResponse
            {
                GraduatedCampaign = "graduated_campaign1b91421c",
            };
            mockGrpcClient.Setup(x => x.GraduateCampaignExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GraduateCampaignExperimentResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            GraduateCampaignExperimentResponse responseCallSettings = await client.GraduateCampaignExperimentAsync(request.CampaignExperiment, request.CampaignBudget, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            GraduateCampaignExperimentResponse responseCancellationToken = await client.GraduateCampaignExperimentAsync(request.CampaignExperiment, request.CampaignBudget, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void EndCampaignExperimentRequestObject()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            EndCampaignExperimentRequest request = new EndCampaignExperimentRequest
            {
                CampaignExperiment = "campaign_experimente81fbe81",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.EndCampaignExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            client.EndCampaignExperiment(request);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task EndCampaignExperimentRequestObjectAsync()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            EndCampaignExperimentRequest request = new EndCampaignExperimentRequest
            {
                CampaignExperiment = "campaign_experimente81fbe81",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.EndCampaignExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            await client.EndCampaignExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.EndCampaignExperimentAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void EndCampaignExperiment()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            EndCampaignExperimentRequest request = new EndCampaignExperimentRequest
            {
                CampaignExperiment = "campaign_experimente81fbe81",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.EndCampaignExperiment(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            client.EndCampaignExperiment(request.CampaignExperiment);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task EndCampaignExperimentAsync()
        {
            moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient> mockGrpcClient = new moq::Mock<CampaignExperimentService.CampaignExperimentServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            EndCampaignExperimentRequest request = new EndCampaignExperimentRequest
            {
                CampaignExperiment = "campaign_experimente81fbe81",
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.EndCampaignExperimentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExperimentServiceClient client = new CampaignExperimentServiceClientImpl(mockGrpcClient.Object, null);
            await client.EndCampaignExperimentAsync(request.CampaignExperiment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.EndCampaignExperimentAsync(request.CampaignExperiment, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}

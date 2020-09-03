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

using gagve = Google.Ads.GoogleAds.V3.Enums;
using gagvr = Google.Ads.GoogleAds.V3.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V3.Services;

namespace Google.Ads.GoogleAds.Tests.V3.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCampaignDraftServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCampaignDraftRequestObject()
        {
            moq::Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new moq::Mock<CampaignDraftService.CampaignDraftServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCampaignDraftRequest request = new GetCampaignDraftRequest
            {
                ResourceNameAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
            };
            gagvr::CampaignDraft expectedResponse = new gagvr::CampaignDraft
            {
                ResourceNameAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                DraftId = -3652444185194679204L,
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                DraftCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignDraftStatusEnum.Types.CampaignDraftStatus.Removed,
                HasExperimentRunning = true,
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetCampaignDraft(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignDraft response = client.GetCampaignDraft(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignDraftRequestObjectAsync()
        {
            moq::Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new moq::Mock<CampaignDraftService.CampaignDraftServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCampaignDraftRequest request = new GetCampaignDraftRequest
            {
                ResourceNameAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
            };
            gagvr::CampaignDraft expectedResponse = new gagvr::CampaignDraft
            {
                ResourceNameAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                DraftId = -3652444185194679204L,
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                DraftCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignDraftStatusEnum.Types.CampaignDraftStatus.Removed,
                HasExperimentRunning = true,
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetCampaignDraftAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignDraft>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignDraft responseCallSettings = await client.GetCampaignDraftAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignDraft responseCancellationToken = await client.GetCampaignDraftAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignDraft()
        {
            moq::Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new moq::Mock<CampaignDraftService.CampaignDraftServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCampaignDraftRequest request = new GetCampaignDraftRequest
            {
                ResourceNameAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
            };
            gagvr::CampaignDraft expectedResponse = new gagvr::CampaignDraft
            {
                ResourceNameAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                DraftId = -3652444185194679204L,
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                DraftCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignDraftStatusEnum.Types.CampaignDraftStatus.Removed,
                HasExperimentRunning = true,
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetCampaignDraft(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignDraft response = client.GetCampaignDraft(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignDraftAsync()
        {
            moq::Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new moq::Mock<CampaignDraftService.CampaignDraftServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCampaignDraftRequest request = new GetCampaignDraftRequest
            {
                ResourceNameAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
            };
            gagvr::CampaignDraft expectedResponse = new gagvr::CampaignDraft
            {
                ResourceNameAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                DraftId = -3652444185194679204L,
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                DraftCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignDraftStatusEnum.Types.CampaignDraftStatus.Removed,
                HasExperimentRunning = true,
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetCampaignDraftAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignDraft>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignDraft responseCallSettings = await client.GetCampaignDraftAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignDraft responseCancellationToken = await client.GetCampaignDraftAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignDraftResourceNames()
        {
            moq::Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new moq::Mock<CampaignDraftService.CampaignDraftServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCampaignDraftRequest request = new GetCampaignDraftRequest
            {
                ResourceNameAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
            };
            gagvr::CampaignDraft expectedResponse = new gagvr::CampaignDraft
            {
                ResourceNameAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                DraftId = -3652444185194679204L,
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                DraftCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignDraftStatusEnum.Types.CampaignDraftStatus.Removed,
                HasExperimentRunning = true,
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetCampaignDraft(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignDraft response = client.GetCampaignDraft(request.ResourceNameAsCampaignDraftName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignDraftResourceNamesAsync()
        {
            moq::Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new moq::Mock<CampaignDraftService.CampaignDraftServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetCampaignDraftRequest request = new GetCampaignDraftRequest
            {
                ResourceNameAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
            };
            gagvr::CampaignDraft expectedResponse = new gagvr::CampaignDraft
            {
                ResourceNameAsCampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                DraftId = -3652444185194679204L,
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CampaignDraftName = gagvr::CampaignDraftName.FromCustomerCampaignDraft("[CUSTOMER]", "[CAMPAIGN_DRAFT]"),
                DraftCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignDraftStatusEnum.Types.CampaignDraftStatus.Removed,
                HasExperimentRunning = true,
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetCampaignDraftAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignDraft>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignDraft responseCallSettings = await client.GetCampaignDraftAsync(request.ResourceNameAsCampaignDraftName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignDraft responseCancellationToken = await client.GetCampaignDraftAsync(request.ResourceNameAsCampaignDraftName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignDraftsRequestObject()
        {
            moq::Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new moq::Mock<CampaignDraftService.CampaignDraftServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            MutateCampaignDraftsRequest request = new MutateCampaignDraftsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignDraftOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCampaignDraftsResponse expectedResponse = new MutateCampaignDraftsResponse
            {
                Results =
                {
                    new MutateCampaignDraftResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignDrafts(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignDraftsResponse response = client.MutateCampaignDrafts(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignDraftsRequestObjectAsync()
        {
            moq::Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new moq::Mock<CampaignDraftService.CampaignDraftServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            MutateCampaignDraftsRequest request = new MutateCampaignDraftsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignDraftOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCampaignDraftsResponse expectedResponse = new MutateCampaignDraftsResponse
            {
                Results =
                {
                    new MutateCampaignDraftResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignDraftsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignDraftsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignDraftsResponse responseCallSettings = await client.MutateCampaignDraftsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignDraftsResponse responseCancellationToken = await client.MutateCampaignDraftsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignDrafts()
        {
            moq::Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new moq::Mock<CampaignDraftService.CampaignDraftServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            MutateCampaignDraftsRequest request = new MutateCampaignDraftsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignDraftOperation(),
                },
            };
            MutateCampaignDraftsResponse expectedResponse = new MutateCampaignDraftsResponse
            {
                Results =
                {
                    new MutateCampaignDraftResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignDrafts(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignDraftsResponse response = client.MutateCampaignDrafts(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignDraftsAsync()
        {
            moq::Mock<CampaignDraftService.CampaignDraftServiceClient> mockGrpcClient = new moq::Mock<CampaignDraftService.CampaignDraftServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            MutateCampaignDraftsRequest request = new MutateCampaignDraftsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignDraftOperation(),
                },
            };
            MutateCampaignDraftsResponse expectedResponse = new MutateCampaignDraftsResponse
            {
                Results =
                {
                    new MutateCampaignDraftResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignDraftsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignDraftsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignDraftServiceClient client = new CampaignDraftServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignDraftsResponse responseCallSettings = await client.MutateCampaignDraftsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignDraftsResponse responseCancellationToken = await client.MutateCampaignDraftsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

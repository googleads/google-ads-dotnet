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

using gagvr = Google.Ads.GoogleAds.V5.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V5.Services;

namespace Google.Ads.GoogleAds.Tests.V5.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCampaignLabelServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCampaignLabelRequestObject()
        {
            moq::Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new moq::Mock<CampaignLabelService.CampaignLabelServiceClient>(moq::MockBehavior.Strict);
            GetCampaignLabelRequest request = new GetCampaignLabelRequest
            {
                ResourceNameAsCampaignLabelName = gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
            };
            gagvr::CampaignLabel expectedResponse = new gagvr::CampaignLabel
            {
                ResourceNameAsCampaignLabelName = gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignLabel response = client.GetCampaignLabel(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignLabelRequestObjectAsync()
        {
            moq::Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new moq::Mock<CampaignLabelService.CampaignLabelServiceClient>(moq::MockBehavior.Strict);
            GetCampaignLabelRequest request = new GetCampaignLabelRequest
            {
                ResourceNameAsCampaignLabelName = gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
            };
            gagvr::CampaignLabel expectedResponse = new gagvr::CampaignLabel
            {
                ResourceNameAsCampaignLabelName = gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignLabel responseCallSettings = await client.GetCampaignLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignLabel responseCancellationToken = await client.GetCampaignLabelAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignLabel()
        {
            moq::Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new moq::Mock<CampaignLabelService.CampaignLabelServiceClient>(moq::MockBehavior.Strict);
            GetCampaignLabelRequest request = new GetCampaignLabelRequest
            {
                ResourceNameAsCampaignLabelName = gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
            };
            gagvr::CampaignLabel expectedResponse = new gagvr::CampaignLabel
            {
                ResourceNameAsCampaignLabelName = gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignLabel response = client.GetCampaignLabel(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignLabelAsync()
        {
            moq::Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new moq::Mock<CampaignLabelService.CampaignLabelServiceClient>(moq::MockBehavior.Strict);
            GetCampaignLabelRequest request = new GetCampaignLabelRequest
            {
                ResourceNameAsCampaignLabelName = gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
            };
            gagvr::CampaignLabel expectedResponse = new gagvr::CampaignLabel
            {
                ResourceNameAsCampaignLabelName = gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignLabel responseCallSettings = await client.GetCampaignLabelAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignLabel responseCancellationToken = await client.GetCampaignLabelAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignLabelResourceNames()
        {
            moq::Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new moq::Mock<CampaignLabelService.CampaignLabelServiceClient>(moq::MockBehavior.Strict);
            GetCampaignLabelRequest request = new GetCampaignLabelRequest
            {
                ResourceNameAsCampaignLabelName = gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
            };
            gagvr::CampaignLabel expectedResponse = new gagvr::CampaignLabel
            {
                ResourceNameAsCampaignLabelName = gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignLabel response = client.GetCampaignLabel(request.ResourceNameAsCampaignLabelName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignLabelResourceNamesAsync()
        {
            moq::Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new moq::Mock<CampaignLabelService.CampaignLabelServiceClient>(moq::MockBehavior.Strict);
            GetCampaignLabelRequest request = new GetCampaignLabelRequest
            {
                ResourceNameAsCampaignLabelName = gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
            };
            gagvr::CampaignLabel expectedResponse = new gagvr::CampaignLabel
            {
                ResourceNameAsCampaignLabelName = gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignLabel responseCallSettings = await client.GetCampaignLabelAsync(request.ResourceNameAsCampaignLabelName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignLabel responseCancellationToken = await client.GetCampaignLabelAsync(request.ResourceNameAsCampaignLabelName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignLabelsRequestObject()
        {
            moq::Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new moq::Mock<CampaignLabelService.CampaignLabelServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignLabelsRequest request = new MutateCampaignLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCampaignLabelsResponse expectedResponse = new MutateCampaignLabelsResponse
            {
                Results =
                {
                    new MutateCampaignLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignLabelsResponse response = client.MutateCampaignLabels(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignLabelsRequestObjectAsync()
        {
            moq::Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new moq::Mock<CampaignLabelService.CampaignLabelServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignLabelsRequest request = new MutateCampaignLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCampaignLabelsResponse expectedResponse = new MutateCampaignLabelsResponse
            {
                Results =
                {
                    new MutateCampaignLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignLabelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignLabelsResponse responseCallSettings = await client.MutateCampaignLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignLabelsResponse responseCancellationToken = await client.MutateCampaignLabelsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignLabels()
        {
            moq::Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new moq::Mock<CampaignLabelService.CampaignLabelServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignLabelsRequest request = new MutateCampaignLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignLabelOperation(),
                },
            };
            MutateCampaignLabelsResponse expectedResponse = new MutateCampaignLabelsResponse
            {
                Results =
                {
                    new MutateCampaignLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignLabelsResponse response = client.MutateCampaignLabels(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignLabelsAsync()
        {
            moq::Mock<CampaignLabelService.CampaignLabelServiceClient> mockGrpcClient = new moq::Mock<CampaignLabelService.CampaignLabelServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignLabelsRequest request = new MutateCampaignLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignLabelOperation(),
                },
            };
            MutateCampaignLabelsResponse expectedResponse = new MutateCampaignLabelsResponse
            {
                Results =
                {
                    new MutateCampaignLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignLabelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignLabelServiceClient client = new CampaignLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignLabelsResponse responseCallSettings = await client.MutateCampaignLabelsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignLabelsResponse responseCancellationToken = await client.MutateCampaignLabelsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

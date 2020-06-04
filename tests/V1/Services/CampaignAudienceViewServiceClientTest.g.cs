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

using gagvr = Google.Ads.GoogleAds.V1.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V1.Services;

namespace Google.Ads.GoogleAds.Tests.V1.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCampaignAudienceViewServiceClientTest
    {
        [Test]
        public void GetCampaignAudienceViewRequestObject()
        {
            moq::Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient> mockGrpcClient = new moq::Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient>(moq::MockBehavior.Strict);
            GetCampaignAudienceViewRequest request = new GetCampaignAudienceViewRequest
            {
                ResourceNameAsCampaignAudienceViewName = gagvr::CampaignAudienceViewName.FromCustomerCampaignAudienceView("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]"),
            };
            gagvr::CampaignAudienceView expectedResponse = new gagvr::CampaignAudienceView
            {
                ResourceNameAsCampaignAudienceViewName = gagvr::CampaignAudienceViewName.FromCustomerCampaignAudienceView("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignAudienceView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignAudienceViewServiceClient client = new CampaignAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignAudienceView response = client.GetCampaignAudienceView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCampaignAudienceViewRequestObjectAsync()
        {
            moq::Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient> mockGrpcClient = new moq::Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient>(moq::MockBehavior.Strict);
            GetCampaignAudienceViewRequest request = new GetCampaignAudienceViewRequest
            {
                ResourceNameAsCampaignAudienceViewName = gagvr::CampaignAudienceViewName.FromCustomerCampaignAudienceView("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]"),
            };
            gagvr::CampaignAudienceView expectedResponse = new gagvr::CampaignAudienceView
            {
                ResourceNameAsCampaignAudienceViewName = gagvr::CampaignAudienceViewName.FromCustomerCampaignAudienceView("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignAudienceViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignAudienceView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignAudienceViewServiceClient client = new CampaignAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignAudienceView responseCallSettings = await client.GetCampaignAudienceViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignAudienceView responseCancellationToken = await client.GetCampaignAudienceViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaignAudienceView()
        {
            moq::Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient> mockGrpcClient = new moq::Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient>(moq::MockBehavior.Strict);
            GetCampaignAudienceViewRequest request = new GetCampaignAudienceViewRequest
            {
                ResourceNameAsCampaignAudienceViewName = gagvr::CampaignAudienceViewName.FromCustomerCampaignAudienceView("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]"),
            };
            gagvr::CampaignAudienceView expectedResponse = new gagvr::CampaignAudienceView
            {
                ResourceNameAsCampaignAudienceViewName = gagvr::CampaignAudienceViewName.FromCustomerCampaignAudienceView("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignAudienceView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignAudienceViewServiceClient client = new CampaignAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignAudienceView response = client.GetCampaignAudienceView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCampaignAudienceViewAsync()
        {
            moq::Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient> mockGrpcClient = new moq::Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient>(moq::MockBehavior.Strict);
            GetCampaignAudienceViewRequest request = new GetCampaignAudienceViewRequest
            {
                ResourceNameAsCampaignAudienceViewName = gagvr::CampaignAudienceViewName.FromCustomerCampaignAudienceView("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]"),
            };
            gagvr::CampaignAudienceView expectedResponse = new gagvr::CampaignAudienceView
            {
                ResourceNameAsCampaignAudienceViewName = gagvr::CampaignAudienceViewName.FromCustomerCampaignAudienceView("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignAudienceViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignAudienceView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignAudienceViewServiceClient client = new CampaignAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignAudienceView responseCallSettings = await client.GetCampaignAudienceViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignAudienceView responseCancellationToken = await client.GetCampaignAudienceViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaignAudienceViewResourceNames()
        {
            moq::Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient> mockGrpcClient = new moq::Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient>(moq::MockBehavior.Strict);
            GetCampaignAudienceViewRequest request = new GetCampaignAudienceViewRequest
            {
                ResourceNameAsCampaignAudienceViewName = gagvr::CampaignAudienceViewName.FromCustomerCampaignAudienceView("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]"),
            };
            gagvr::CampaignAudienceView expectedResponse = new gagvr::CampaignAudienceView
            {
                ResourceNameAsCampaignAudienceViewName = gagvr::CampaignAudienceViewName.FromCustomerCampaignAudienceView("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignAudienceView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignAudienceViewServiceClient client = new CampaignAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignAudienceView response = client.GetCampaignAudienceView(request.ResourceNameAsCampaignAudienceViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCampaignAudienceViewResourceNamesAsync()
        {
            moq::Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient> mockGrpcClient = new moq::Mock<CampaignAudienceViewService.CampaignAudienceViewServiceClient>(moq::MockBehavior.Strict);
            GetCampaignAudienceViewRequest request = new GetCampaignAudienceViewRequest
            {
                ResourceNameAsCampaignAudienceViewName = gagvr::CampaignAudienceViewName.FromCustomerCampaignAudienceView("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]"),
            };
            gagvr::CampaignAudienceView expectedResponse = new gagvr::CampaignAudienceView
            {
                ResourceNameAsCampaignAudienceViewName = gagvr::CampaignAudienceViewName.FromCustomerCampaignAudienceView("[CUSTOMER]", "[CAMPAIGN_AUDIENCE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetCampaignAudienceViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignAudienceView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignAudienceViewServiceClient client = new CampaignAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignAudienceView responseCallSettings = await client.GetCampaignAudienceViewAsync(request.ResourceNameAsCampaignAudienceViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignAudienceView responseCancellationToken = await client.GetCampaignAudienceViewAsync(request.ResourceNameAsCampaignAudienceViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

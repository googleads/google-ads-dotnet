// Copyright 2022 Google LLC
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

using gagve = Google.Ads.GoogleAds.V10.Enums;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V10.Services;

namespace Google.Ads.GoogleAds.Tests.V10.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCampaignServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateCampaignsRequestObject()
        {
            moq::Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new moq::Mock<CampaignService.CampaignServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignsRequest request = new MutateCampaignsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignsResponse expectedResponse = new MutateCampaignsResponse
            {
                Results =
                {
                    new MutateCampaignResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaigns(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignsResponse response = client.MutateCampaigns(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateCampaignsRequestObjectAsync()
        {
            moq::Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new moq::Mock<CampaignService.CampaignServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignsRequest request = new MutateCampaignsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignsResponse expectedResponse = new MutateCampaignsResponse
            {
                Results =
                {
                    new MutateCampaignResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignsResponse responseCallSettings = await client.MutateCampaignsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignsResponse responseCancellationToken = await client.MutateCampaignsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateCampaigns()
        {
            moq::Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new moq::Mock<CampaignService.CampaignServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignsRequest request = new MutateCampaignsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignOperation(),
                },
            };
            MutateCampaignsResponse expectedResponse = new MutateCampaignsResponse
            {
                Results =
                {
                    new MutateCampaignResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaigns(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignsResponse response = client.MutateCampaigns(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateCampaignsAsync()
        {
            moq::Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new moq::Mock<CampaignService.CampaignServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignsRequest request = new MutateCampaignsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignOperation(),
                },
            };
            MutateCampaignsResponse expectedResponse = new MutateCampaignsResponse
            {
                Results =
                {
                    new MutateCampaignResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignsResponse responseCallSettings = await client.MutateCampaignsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignsResponse responseCancellationToken = await client.MutateCampaignsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

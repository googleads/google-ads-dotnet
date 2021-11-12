// Copyright 2021 Google LLC
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

using gagve = Google.Ads.GoogleAds.V9.Enums;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V9.Services;

namespace Google.Ads.GoogleAds.Tests.V9.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCampaignAssetSetServiceClientTest
    {
        [Category("Smoke")][Test]
        public void MutateCampaignAssetSetsRequestObject()
        {
            moq::Mock<CampaignAssetSetService.CampaignAssetSetServiceClient> mockGrpcClient = new moq::Mock<CampaignAssetSetService.CampaignAssetSetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignAssetSetsRequest request = new MutateCampaignAssetSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignAssetSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignAssetSetsResponse expectedResponse = new MutateCampaignAssetSetsResponse
            {
                Results =
                {
                    new MutateCampaignAssetSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignAssetSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignAssetSetServiceClient client = new CampaignAssetSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignAssetSetsResponse response = client.MutateCampaignAssetSets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignAssetSetsRequestObjectAsync()
        {
            moq::Mock<CampaignAssetSetService.CampaignAssetSetServiceClient> mockGrpcClient = new moq::Mock<CampaignAssetSetService.CampaignAssetSetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignAssetSetsRequest request = new MutateCampaignAssetSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignAssetSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignAssetSetsResponse expectedResponse = new MutateCampaignAssetSetsResponse
            {
                Results =
                {
                    new MutateCampaignAssetSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignAssetSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignAssetSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignAssetSetServiceClient client = new CampaignAssetSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignAssetSetsResponse responseCallSettings = await client.MutateCampaignAssetSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignAssetSetsResponse responseCancellationToken = await client.MutateCampaignAssetSetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignAssetSets()
        {
            moq::Mock<CampaignAssetSetService.CampaignAssetSetServiceClient> mockGrpcClient = new moq::Mock<CampaignAssetSetService.CampaignAssetSetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignAssetSetsRequest request = new MutateCampaignAssetSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignAssetSetOperation(),
                },
            };
            MutateCampaignAssetSetsResponse expectedResponse = new MutateCampaignAssetSetsResponse
            {
                Results =
                {
                    new MutateCampaignAssetSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignAssetSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignAssetSetServiceClient client = new CampaignAssetSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignAssetSetsResponse response = client.MutateCampaignAssetSets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignAssetSetsAsync()
        {
            moq::Mock<CampaignAssetSetService.CampaignAssetSetServiceClient> mockGrpcClient = new moq::Mock<CampaignAssetSetService.CampaignAssetSetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignAssetSetsRequest request = new MutateCampaignAssetSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignAssetSetOperation(),
                },
            };
            MutateCampaignAssetSetsResponse expectedResponse = new MutateCampaignAssetSetsResponse
            {
                Results =
                {
                    new MutateCampaignAssetSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignAssetSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignAssetSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignAssetSetServiceClient client = new CampaignAssetSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignAssetSetsResponse responseCallSettings = await client.MutateCampaignAssetSetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignAssetSetsResponse responseCancellationToken = await client.MutateCampaignAssetSetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

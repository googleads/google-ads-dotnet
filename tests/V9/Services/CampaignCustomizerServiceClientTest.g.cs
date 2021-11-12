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
    public sealed class GeneratedCampaignCustomizerServiceClientTest
    {
        [Category("Smoke")][Test]
        public void MutateCampaignCustomizersRequestObject()
        {
            moq::Mock<CampaignCustomizerService.CampaignCustomizerServiceClient> mockGrpcClient = new moq::Mock<CampaignCustomizerService.CampaignCustomizerServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignCustomizersRequest request = new MutateCampaignCustomizersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignCustomizerOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignCustomizersResponse expectedResponse = new MutateCampaignCustomizersResponse
            {
                Results =
                {
                    new MutateCampaignCustomizerResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignCustomizers(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignCustomizerServiceClient client = new CampaignCustomizerServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignCustomizersResponse response = client.MutateCampaignCustomizers(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignCustomizersRequestObjectAsync()
        {
            moq::Mock<CampaignCustomizerService.CampaignCustomizerServiceClient> mockGrpcClient = new moq::Mock<CampaignCustomizerService.CampaignCustomizerServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignCustomizersRequest request = new MutateCampaignCustomizersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignCustomizerOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignCustomizersResponse expectedResponse = new MutateCampaignCustomizersResponse
            {
                Results =
                {
                    new MutateCampaignCustomizerResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignCustomizersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignCustomizersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignCustomizerServiceClient client = new CampaignCustomizerServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignCustomizersResponse responseCallSettings = await client.MutateCampaignCustomizersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignCustomizersResponse responseCancellationToken = await client.MutateCampaignCustomizersAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignCustomizers()
        {
            moq::Mock<CampaignCustomizerService.CampaignCustomizerServiceClient> mockGrpcClient = new moq::Mock<CampaignCustomizerService.CampaignCustomizerServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignCustomizersRequest request = new MutateCampaignCustomizersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignCustomizerOperation(),
                },
            };
            MutateCampaignCustomizersResponse expectedResponse = new MutateCampaignCustomizersResponse
            {
                Results =
                {
                    new MutateCampaignCustomizerResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignCustomizers(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignCustomizerServiceClient client = new CampaignCustomizerServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignCustomizersResponse response = client.MutateCampaignCustomizers(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignCustomizersAsync()
        {
            moq::Mock<CampaignCustomizerService.CampaignCustomizerServiceClient> mockGrpcClient = new moq::Mock<CampaignCustomizerService.CampaignCustomizerServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignCustomizersRequest request = new MutateCampaignCustomizersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignCustomizerOperation(),
                },
            };
            MutateCampaignCustomizersResponse expectedResponse = new MutateCampaignCustomizersResponse
            {
                Results =
                {
                    new MutateCampaignCustomizerResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignCustomizersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignCustomizersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignCustomizerServiceClient client = new CampaignCustomizerServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignCustomizersResponse responseCallSettings = await client.MutateCampaignCustomizersAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignCustomizersResponse responseCancellationToken = await client.MutateCampaignCustomizersAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

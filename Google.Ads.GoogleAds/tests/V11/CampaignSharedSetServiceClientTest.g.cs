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

#pragma warning disable CS8981
using gagve = Google.Ads.GoogleAds.V11.Enums;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V11.Services;

namespace Google.Ads.GoogleAds.Tests.V11.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCampaignSharedSetServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateCampaignSharedSetsRequestObject()
        {
            moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignSharedSetsRequest request = new MutateCampaignSharedSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignSharedSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignSharedSetsResponse expectedResponse = new MutateCampaignSharedSetsResponse
            {
                Results =
                {
                    new MutateCampaignSharedSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignSharedSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCampaignSharedSetsResponse response = client.MutateCampaignSharedSets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateCampaignSharedSetsRequestObjectAsync()
        {
            moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignSharedSetsRequest request = new MutateCampaignSharedSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignSharedSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignSharedSetsResponse expectedResponse = new MutateCampaignSharedSetsResponse
            {
                Results =
                {
                    new MutateCampaignSharedSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignSharedSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignSharedSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCampaignSharedSetsResponse responseCallSettings = await client.MutateCampaignSharedSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignSharedSetsResponse responseCancellationToken = await client.MutateCampaignSharedSetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateCampaignSharedSets()
        {
            moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignSharedSetsRequest request = new MutateCampaignSharedSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignSharedSetOperation(),
                },
            };
            MutateCampaignSharedSetsResponse expectedResponse = new MutateCampaignSharedSetsResponse
            {
                Results =
                {
                    new MutateCampaignSharedSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignSharedSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCampaignSharedSetsResponse response = client.MutateCampaignSharedSets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateCampaignSharedSetsAsync()
        {
            moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient> mockGrpcClient = new moq::Mock<CampaignSharedSetService.CampaignSharedSetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignSharedSetsRequest request = new MutateCampaignSharedSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignSharedSetOperation(),
                },
            };
            MutateCampaignSharedSetsResponse expectedResponse = new MutateCampaignSharedSetsResponse
            {
                Results =
                {
                    new MutateCampaignSharedSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignSharedSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignSharedSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignSharedSetServiceClient client = new CampaignSharedSetServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateCampaignSharedSetsResponse responseCallSettings = await client.MutateCampaignSharedSetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignSharedSetsResponse responseCancellationToken = await client.MutateCampaignSharedSetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

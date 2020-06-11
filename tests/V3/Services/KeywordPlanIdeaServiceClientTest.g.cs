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
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V3.Services;

namespace Google.Ads.GoogleAds.Tests.V3.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedKeywordPlanIdeaServiceClientTest
    {
        [Test]
        public void GenerateKeywordIdeasRequestObject()
        {
            moq::Mock<KeywordPlanIdeaService.KeywordPlanIdeaServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanIdeaService.KeywordPlanIdeaServiceClient>(moq::MockBehavior.Strict);
            GenerateKeywordIdeasRequest request = new GenerateKeywordIdeasRequest
            {
                CustomerId = "customer_id3b3724cb",
                KeywordAndUrlSeed = new KeywordAndUrlSeed(),
                KeywordSeed = new KeywordSeed(),
                UrlSeed = new UrlSeed(),
                Language = "language7dae1285",
                GeoTargetConstants =
                {
                    "geo_target_constants2f692206",
                },
                KeywordPlanNetwork = gagve::KeywordPlanNetworkEnum.Types.KeywordPlanNetwork.Unspecified,
            };
            GenerateKeywordIdeaResponse expectedResponse = new GenerateKeywordIdeaResponse
            {
                Results =
                {
                    new GenerateKeywordIdeaResult(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateKeywordIdeas(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanIdeaServiceClient client = new KeywordPlanIdeaServiceClientImpl(mockGrpcClient.Object, null);
            GenerateKeywordIdeaResponse response = client.GenerateKeywordIdeas(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GenerateKeywordIdeasRequestObjectAsync()
        {
            moq::Mock<KeywordPlanIdeaService.KeywordPlanIdeaServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanIdeaService.KeywordPlanIdeaServiceClient>(moq::MockBehavior.Strict);
            GenerateKeywordIdeasRequest request = new GenerateKeywordIdeasRequest
            {
                CustomerId = "customer_id3b3724cb",
                KeywordAndUrlSeed = new KeywordAndUrlSeed(),
                KeywordSeed = new KeywordSeed(),
                UrlSeed = new UrlSeed(),
                Language = "language7dae1285",
                GeoTargetConstants =
                {
                    "geo_target_constants2f692206",
                },
                KeywordPlanNetwork = gagve::KeywordPlanNetworkEnum.Types.KeywordPlanNetwork.Unspecified,
            };
            GenerateKeywordIdeaResponse expectedResponse = new GenerateKeywordIdeaResponse
            {
                Results =
                {
                    new GenerateKeywordIdeaResult(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateKeywordIdeasAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateKeywordIdeaResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanIdeaServiceClient client = new KeywordPlanIdeaServiceClientImpl(mockGrpcClient.Object, null);
            GenerateKeywordIdeaResponse responseCallSettings = await client.GenerateKeywordIdeasAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            GenerateKeywordIdeaResponse responseCancellationToken = await client.GenerateKeywordIdeasAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

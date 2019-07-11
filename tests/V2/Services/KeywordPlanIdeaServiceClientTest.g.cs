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

namespace Google.Ads.GoogleAds.V2.Services.Tests
{
    using Google.Ads.GoogleAds.V2.Enums;
    using apis = Google.Ads.GoogleAds.V2.Services;
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
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
    public class GeneratedKeywordPlanIdeaServiceClientTest
    {
        [Test]
        public void GenerateKeywordIdeas()
        {
            Mock<KeywordPlanIdeaService.KeywordPlanIdeaServiceClient> mockGrpcClient = new Mock<KeywordPlanIdeaService.KeywordPlanIdeaServiceClient>(MockBehavior.Strict);
            GenerateKeywordIdeasRequest expectedRequest = new GenerateKeywordIdeasRequest
            {
                CustomerId = "customerId-1772061412",
                Language = null,
                GeoTargetConstants = { },
                KeywordPlanNetwork = KeywordPlanNetworkEnum.Types.KeywordPlanNetwork.Unspecified,
            };
            GenerateKeywordIdeaResponse expectedResponse = new GenerateKeywordIdeaResponse();
            mockGrpcClient.Setup(x => x.GenerateKeywordIdeas(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanIdeaServiceClient client = new KeywordPlanIdeaServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            string language = null;
            IEnumerable<string> geoTargetConstants = new List<string>();
            KeywordPlanNetworkEnum.Types.KeywordPlanNetwork keywordPlanNetwork = KeywordPlanNetworkEnum.Types.KeywordPlanNetwork.Unspecified;
            GenerateKeywordIdeaResponse response = client.GenerateKeywordIdeas(customerId, language, geoTargetConstants, keywordPlanNetwork);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GenerateKeywordIdeasAsync()
        {
            Mock<KeywordPlanIdeaService.KeywordPlanIdeaServiceClient> mockGrpcClient = new Mock<KeywordPlanIdeaService.KeywordPlanIdeaServiceClient>(MockBehavior.Strict);
            GenerateKeywordIdeasRequest expectedRequest = new GenerateKeywordIdeasRequest
            {
                CustomerId = "customerId-1772061412",
                Language = null,
                GeoTargetConstants = { },
                KeywordPlanNetwork = KeywordPlanNetworkEnum.Types.KeywordPlanNetwork.Unspecified,
            };
            GenerateKeywordIdeaResponse expectedResponse = new GenerateKeywordIdeaResponse();
            mockGrpcClient.Setup(x => x.GenerateKeywordIdeasAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GenerateKeywordIdeaResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanIdeaServiceClient client = new KeywordPlanIdeaServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            string language = null;
            IEnumerable<string> geoTargetConstants = new List<string>();
            KeywordPlanNetworkEnum.Types.KeywordPlanNetwork keywordPlanNetwork = KeywordPlanNetworkEnum.Types.KeywordPlanNetwork.Unspecified;
            GenerateKeywordIdeaResponse response = await client.GenerateKeywordIdeasAsync(customerId, language, geoTargetConstants, keywordPlanNetwork);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GenerateKeywordIdeas2()
        {
            Mock<KeywordPlanIdeaService.KeywordPlanIdeaServiceClient> mockGrpcClient = new Mock<KeywordPlanIdeaService.KeywordPlanIdeaServiceClient>(MockBehavior.Strict);
            GenerateKeywordIdeasRequest request = new GenerateKeywordIdeasRequest
            {
                CustomerId = "customerId-1772061412",
                Language = null,
                GeoTargetConstants = { },
                KeywordPlanNetwork = KeywordPlanNetworkEnum.Types.KeywordPlanNetwork.Unspecified,
            };
            GenerateKeywordIdeaResponse expectedResponse = new GenerateKeywordIdeaResponse();
            mockGrpcClient.Setup(x => x.GenerateKeywordIdeas(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanIdeaServiceClient client = new KeywordPlanIdeaServiceClientImpl(mockGrpcClient.Object, null);
            GenerateKeywordIdeaResponse response = client.GenerateKeywordIdeas(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GenerateKeywordIdeasAsync2()
        {
            Mock<KeywordPlanIdeaService.KeywordPlanIdeaServiceClient> mockGrpcClient = new Mock<KeywordPlanIdeaService.KeywordPlanIdeaServiceClient>(MockBehavior.Strict);
            GenerateKeywordIdeasRequest request = new GenerateKeywordIdeasRequest
            {
                CustomerId = "customerId-1772061412",
                Language = null,
                GeoTargetConstants = { },
                KeywordPlanNetwork = KeywordPlanNetworkEnum.Types.KeywordPlanNetwork.Unspecified,
            };
            GenerateKeywordIdeaResponse expectedResponse = new GenerateKeywordIdeaResponse();
            mockGrpcClient.Setup(x => x.GenerateKeywordIdeasAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GenerateKeywordIdeaResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanIdeaServiceClient client = new KeywordPlanIdeaServiceClientImpl(mockGrpcClient.Object, null);
            GenerateKeywordIdeaResponse response = await client.GenerateKeywordIdeasAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

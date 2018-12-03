// Copyright 2018 Google LLC
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

// TODO( b/119694056): Removed Comment

namespace Google.Ads.GoogleAds.V0.Services.Tests
{
    using Google.Ads.GoogleAds.V0.Resources;
    using apis = Google.Ads.GoogleAds.V0.Services;
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
    public class GeneratedKeywordPlanKeywordServiceClientTest
    {
        [Test]
        public void GetKeywordPlanKeyword()
        {
            Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(MockBehavior.Strict);
            GetKeywordPlanKeywordRequest expectedRequest = new GetKeywordPlanKeywordRequest
            {
                ResourceName = new KeywordPlanKeywordName("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]").ToString(),
            };
            KeywordPlanKeyword expectedResponse = new KeywordPlanKeyword
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanKeyword(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new KeywordPlanKeywordName("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]").ToString();
            KeywordPlanKeyword response = client.GetKeywordPlanKeyword(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetKeywordPlanKeywordAsync()
        {
            Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(MockBehavior.Strict);
            GetKeywordPlanKeywordRequest expectedRequest = new GetKeywordPlanKeywordRequest
            {
                ResourceName = new KeywordPlanKeywordName("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]").ToString(),
            };
            KeywordPlanKeyword expectedResponse = new KeywordPlanKeyword
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanKeywordAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<KeywordPlanKeyword>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new KeywordPlanKeywordName("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]").ToString();
            KeywordPlanKeyword response = await client.GetKeywordPlanKeywordAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetKeywordPlanKeyword2()
        {
            Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(MockBehavior.Strict);
            GetKeywordPlanKeywordRequest request = new GetKeywordPlanKeywordRequest
            {
                ResourceName = new KeywordPlanKeywordName("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]").ToString(),
            };
            KeywordPlanKeyword expectedResponse = new KeywordPlanKeyword
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanKeyword(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            KeywordPlanKeyword response = client.GetKeywordPlanKeyword(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetKeywordPlanKeywordAsync2()
        {
            Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(MockBehavior.Strict);
            GetKeywordPlanKeywordRequest request = new GetKeywordPlanKeywordRequest
            {
                ResourceName = new KeywordPlanKeywordName("[CUSTOMER]", "[KEYWORD_PLAN_KEYWORD]").ToString(),
            };
            KeywordPlanKeyword expectedResponse = new KeywordPlanKeyword
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanKeywordAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<KeywordPlanKeyword>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            KeywordPlanKeyword response = await client.GetKeywordPlanKeywordAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateKeywordPlanKeywords()
        {
            Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanKeywordsRequest expectedRequest = new MutateKeywordPlanKeywordsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlanKeywordsResponse expectedResponse = new MutateKeywordPlanKeywordsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanKeywords(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<KeywordPlanKeywordOperation> operations = new List<KeywordPlanKeywordOperation>();
            MutateKeywordPlanKeywordsResponse response = client.MutateKeywordPlanKeywords(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateKeywordPlanKeywordsAsync()
        {
            Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanKeywordsRequest expectedRequest = new MutateKeywordPlanKeywordsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlanKeywordsResponse expectedResponse = new MutateKeywordPlanKeywordsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanKeywordsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateKeywordPlanKeywordsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<KeywordPlanKeywordOperation> operations = new List<KeywordPlanKeywordOperation>();
            MutateKeywordPlanKeywordsResponse response = await client.MutateKeywordPlanKeywordsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateKeywordPlanKeywords2()
        {
            Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanKeywordsRequest request = new MutateKeywordPlanKeywordsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlanKeywordsResponse expectedResponse = new MutateKeywordPlanKeywordsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanKeywords(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanKeywordsResponse response = client.MutateKeywordPlanKeywords(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateKeywordPlanKeywordsAsync2()
        {
            Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanKeywordService.KeywordPlanKeywordServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanKeywordsRequest request = new MutateKeywordPlanKeywordsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlanKeywordsResponse expectedResponse = new MutateKeywordPlanKeywordsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanKeywordsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateKeywordPlanKeywordsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanKeywordServiceClient client = new KeywordPlanKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanKeywordsResponse response = await client.MutateKeywordPlanKeywordsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

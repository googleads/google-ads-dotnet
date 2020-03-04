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

namespace Google.Ads.GoogleAds.V3.Services.Tests
{
    using Google.Ads.GoogleAds.V3.Resources;
    using apis = Google.Ads.GoogleAds.V3.Services;
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
    public class GeneratedKeywordPlanNegativeKeywordServiceClientTest
    {
        [Test]
        public void GetKeywordPlanNegativeKeyword()
        {
            Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(MockBehavior.Strict);
            GetKeywordPlanNegativeKeywordRequest expectedRequest = new GetKeywordPlanNegativeKeywordRequest
            {
                ResourceName = new KeywordPlanNegativeKeywordName("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]").ToString(),
            };
            KeywordPlanNegativeKeyword expectedResponse = new KeywordPlanNegativeKeyword
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanNegativeKeyword(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new KeywordPlanNegativeKeywordName("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]").ToString();
            KeywordPlanNegativeKeyword response = client.GetKeywordPlanNegativeKeyword(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetKeywordPlanNegativeKeywordAsync()
        {
            Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(MockBehavior.Strict);
            GetKeywordPlanNegativeKeywordRequest expectedRequest = new GetKeywordPlanNegativeKeywordRequest
            {
                ResourceName = new KeywordPlanNegativeKeywordName("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]").ToString(),
            };
            KeywordPlanNegativeKeyword expectedResponse = new KeywordPlanNegativeKeyword
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanNegativeKeywordAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<KeywordPlanNegativeKeyword>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new KeywordPlanNegativeKeywordName("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]").ToString();
            KeywordPlanNegativeKeyword response = await client.GetKeywordPlanNegativeKeywordAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetKeywordPlanNegativeKeyword2()
        {
            Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(MockBehavior.Strict);
            GetKeywordPlanNegativeKeywordRequest request = new GetKeywordPlanNegativeKeywordRequest
            {
                ResourceName = new KeywordPlanNegativeKeywordName("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]").ToString(),
            };
            KeywordPlanNegativeKeyword expectedResponse = new KeywordPlanNegativeKeyword
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanNegativeKeyword(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            KeywordPlanNegativeKeyword response = client.GetKeywordPlanNegativeKeyword(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetKeywordPlanNegativeKeywordAsync2()
        {
            Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(MockBehavior.Strict);
            GetKeywordPlanNegativeKeywordRequest request = new GetKeywordPlanNegativeKeywordRequest
            {
                ResourceName = new KeywordPlanNegativeKeywordName("[CUSTOMER]", "[KEYWORD_PLAN_NEGATIVE_KEYWORD]").ToString(),
            };
            KeywordPlanNegativeKeyword expectedResponse = new KeywordPlanNegativeKeyword
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanNegativeKeywordAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<KeywordPlanNegativeKeyword>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            KeywordPlanNegativeKeyword response = await client.GetKeywordPlanNegativeKeywordAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateKeywordPlanNegativeKeywords()
        {
            Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanNegativeKeywordsRequest expectedRequest = new MutateKeywordPlanNegativeKeywordsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateKeywordPlanNegativeKeywordsResponse expectedResponse = new MutateKeywordPlanNegativeKeywordsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanNegativeKeywords(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<KeywordPlanNegativeKeywordOperation> operations = new List<KeywordPlanNegativeKeywordOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateKeywordPlanNegativeKeywordsResponse response = client.MutateKeywordPlanNegativeKeywords(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateKeywordPlanNegativeKeywordsAsync()
        {
            Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanNegativeKeywordsRequest expectedRequest = new MutateKeywordPlanNegativeKeywordsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateKeywordPlanNegativeKeywordsResponse expectedResponse = new MutateKeywordPlanNegativeKeywordsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanNegativeKeywordsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateKeywordPlanNegativeKeywordsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<KeywordPlanNegativeKeywordOperation> operations = new List<KeywordPlanNegativeKeywordOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateKeywordPlanNegativeKeywordsResponse response = await client.MutateKeywordPlanNegativeKeywordsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateKeywordPlanNegativeKeywords2()
        {
            Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanNegativeKeywordsRequest expectedRequest = new MutateKeywordPlanNegativeKeywordsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlanNegativeKeywordsResponse expectedResponse = new MutateKeywordPlanNegativeKeywordsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanNegativeKeywords(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<KeywordPlanNegativeKeywordOperation> operations = new List<KeywordPlanNegativeKeywordOperation>();
            MutateKeywordPlanNegativeKeywordsResponse response = client.MutateKeywordPlanNegativeKeywords(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateKeywordPlanNegativeKeywordsAsync2()
        {
            Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanNegativeKeywordsRequest expectedRequest = new MutateKeywordPlanNegativeKeywordsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlanNegativeKeywordsResponse expectedResponse = new MutateKeywordPlanNegativeKeywordsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanNegativeKeywordsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateKeywordPlanNegativeKeywordsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<KeywordPlanNegativeKeywordOperation> operations = new List<KeywordPlanNegativeKeywordOperation>();
            MutateKeywordPlanNegativeKeywordsResponse response = await client.MutateKeywordPlanNegativeKeywordsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateKeywordPlanNegativeKeywords3()
        {
            Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanNegativeKeywordsRequest request = new MutateKeywordPlanNegativeKeywordsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlanNegativeKeywordsResponse expectedResponse = new MutateKeywordPlanNegativeKeywordsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanNegativeKeywords(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanNegativeKeywordsResponse response = client.MutateKeywordPlanNegativeKeywords(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateKeywordPlanNegativeKeywordsAsync3()
        {
            Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient> mockGrpcClient = new Mock<KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanNegativeKeywordsRequest request = new MutateKeywordPlanNegativeKeywordsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlanNegativeKeywordsResponse expectedResponse = new MutateKeywordPlanNegativeKeywordsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanNegativeKeywordsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateKeywordPlanNegativeKeywordsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanNegativeKeywordServiceClient client = new KeywordPlanNegativeKeywordServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanNegativeKeywordsResponse response = await client.MutateKeywordPlanNegativeKeywordsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

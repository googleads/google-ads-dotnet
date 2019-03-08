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
    public class GeneratedKeywordPlanCampaignServiceClientTest
    {
        [Test]
        public void GetKeywordPlanCampaign()
        {
            Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(MockBehavior.Strict);
            GetKeywordPlanCampaignRequest expectedRequest = new GetKeywordPlanCampaignRequest
            {
                ResourceName = new KeywordPlanCampaignName("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]").ToString(),
            };
            KeywordPlanCampaign expectedResponse = new KeywordPlanCampaign
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanCampaign(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new KeywordPlanCampaignName("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]").ToString();
            KeywordPlanCampaign response = client.GetKeywordPlanCampaign(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetKeywordPlanCampaignAsync()
        {
            Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(MockBehavior.Strict);
            GetKeywordPlanCampaignRequest expectedRequest = new GetKeywordPlanCampaignRequest
            {
                ResourceName = new KeywordPlanCampaignName("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]").ToString(),
            };
            KeywordPlanCampaign expectedResponse = new KeywordPlanCampaign
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanCampaignAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<KeywordPlanCampaign>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new KeywordPlanCampaignName("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]").ToString();
            KeywordPlanCampaign response = await client.GetKeywordPlanCampaignAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetKeywordPlanCampaign2()
        {
            Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(MockBehavior.Strict);
            GetKeywordPlanCampaignRequest request = new GetKeywordPlanCampaignRequest
            {
                ResourceName = new KeywordPlanCampaignName("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]").ToString(),
            };
            KeywordPlanCampaign expectedResponse = new KeywordPlanCampaign
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanCampaign(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            KeywordPlanCampaign response = client.GetKeywordPlanCampaign(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetKeywordPlanCampaignAsync2()
        {
            Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(MockBehavior.Strict);
            GetKeywordPlanCampaignRequest request = new GetKeywordPlanCampaignRequest
            {
                ResourceName = new KeywordPlanCampaignName("[CUSTOMER]", "[KEYWORD_PLAN_CAMPAIGN]").ToString(),
            };
            KeywordPlanCampaign expectedResponse = new KeywordPlanCampaign
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanCampaignAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<KeywordPlanCampaign>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            KeywordPlanCampaign response = await client.GetKeywordPlanCampaignAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateKeywordPlanCampaigns()
        {
            Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanCampaignsRequest expectedRequest = new MutateKeywordPlanCampaignsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlanCampaignsResponse expectedResponse = new MutateKeywordPlanCampaignsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanCampaigns(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<KeywordPlanCampaignOperation> operations = new List<KeywordPlanCampaignOperation>();
            MutateKeywordPlanCampaignsResponse response = client.MutateKeywordPlanCampaigns(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateKeywordPlanCampaignsAsync()
        {
            Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanCampaignsRequest expectedRequest = new MutateKeywordPlanCampaignsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlanCampaignsResponse expectedResponse = new MutateKeywordPlanCampaignsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanCampaignsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateKeywordPlanCampaignsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<KeywordPlanCampaignOperation> operations = new List<KeywordPlanCampaignOperation>();
            MutateKeywordPlanCampaignsResponse response = await client.MutateKeywordPlanCampaignsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateKeywordPlanCampaigns2()
        {
            Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanCampaignsRequest request = new MutateKeywordPlanCampaignsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlanCampaignsResponse expectedResponse = new MutateKeywordPlanCampaignsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanCampaigns(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanCampaignsResponse response = client.MutateKeywordPlanCampaigns(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateKeywordPlanCampaignsAsync2()
        {
            Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient> mockGrpcClient = new Mock<KeywordPlanCampaignService.KeywordPlanCampaignServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanCampaignsRequest request = new MutateKeywordPlanCampaignsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlanCampaignsResponse expectedResponse = new MutateKeywordPlanCampaignsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanCampaignsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateKeywordPlanCampaignsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanCampaignServiceClient client = new KeywordPlanCampaignServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanCampaignsResponse response = await client.MutateKeywordPlanCampaignsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

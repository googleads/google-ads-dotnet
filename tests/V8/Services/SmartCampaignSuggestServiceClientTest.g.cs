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

using gagvc = Google.Ads.GoogleAds.V8.Common;
using gagvr = Google.Ads.GoogleAds.V8.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V8.Services;

namespace Google.Ads.GoogleAds.Tests.V8.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSmartCampaignSuggestServiceClientTest
    {
        [Category("Smoke")][Test]
        public void SuggestSmartCampaignBudgetOptionsRequestObject()
        {
            moq::Mock<SmartCampaignSuggestService.SmartCampaignSuggestServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSuggestService.SmartCampaignSuggestServiceClient>(moq::MockBehavior.Strict);
            SuggestSmartCampaignBudgetOptionsRequest request = new SuggestSmartCampaignBudgetOptionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                SuggestionInfo = new SmartCampaignSuggestionInfo(),
            };
            SuggestSmartCampaignBudgetOptionsResponse expectedResponse = new SuggestSmartCampaignBudgetOptionsResponse
            {
                Low = new SuggestSmartCampaignBudgetOptionsResponse.Types.BudgetOption(),
                Recommended = new SuggestSmartCampaignBudgetOptionsResponse.Types.BudgetOption(),
                High = new SuggestSmartCampaignBudgetOptionsResponse.Types.BudgetOption(),
            };
            mockGrpcClient.Setup(x => x.SuggestSmartCampaignBudgetOptions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SmartCampaignSuggestServiceClient client = new SmartCampaignSuggestServiceClientImpl(mockGrpcClient.Object, null);
            SuggestSmartCampaignBudgetOptionsResponse response = client.SuggestSmartCampaignBudgetOptions(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task SuggestSmartCampaignBudgetOptionsRequestObjectAsync()
        {
            moq::Mock<SmartCampaignSuggestService.SmartCampaignSuggestServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSuggestService.SmartCampaignSuggestServiceClient>(moq::MockBehavior.Strict);
            SuggestSmartCampaignBudgetOptionsRequest request = new SuggestSmartCampaignBudgetOptionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                SuggestionInfo = new SmartCampaignSuggestionInfo(),
            };
            SuggestSmartCampaignBudgetOptionsResponse expectedResponse = new SuggestSmartCampaignBudgetOptionsResponse
            {
                Low = new SuggestSmartCampaignBudgetOptionsResponse.Types.BudgetOption(),
                Recommended = new SuggestSmartCampaignBudgetOptionsResponse.Types.BudgetOption(),
                High = new SuggestSmartCampaignBudgetOptionsResponse.Types.BudgetOption(),
            };
            mockGrpcClient.Setup(x => x.SuggestSmartCampaignBudgetOptionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SuggestSmartCampaignBudgetOptionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SmartCampaignSuggestServiceClient client = new SmartCampaignSuggestServiceClientImpl(mockGrpcClient.Object, null);
            SuggestSmartCampaignBudgetOptionsResponse responseCallSettings = await client.SuggestSmartCampaignBudgetOptionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            SuggestSmartCampaignBudgetOptionsResponse responseCancellationToken = await client.SuggestSmartCampaignBudgetOptionsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void SuggestSmartCampaignAdRequestObject()
        {
            moq::Mock<SmartCampaignSuggestService.SmartCampaignSuggestServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSuggestService.SmartCampaignSuggestServiceClient>(moq::MockBehavior.Strict);
            SuggestSmartCampaignAdRequest request = new SuggestSmartCampaignAdRequest
            {
                CustomerId = "customer_id3b3724cb",
                SuggestionInfo = new SmartCampaignSuggestionInfo(),
            };
            SuggestSmartCampaignAdResponse expectedResponse = new SuggestSmartCampaignAdResponse
            {
                AdInfo = new gagvc::SmartCampaignAdInfo(),
            };
            mockGrpcClient.Setup(x => x.SuggestSmartCampaignAd(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SmartCampaignSuggestServiceClient client = new SmartCampaignSuggestServiceClientImpl(mockGrpcClient.Object, null);
            SuggestSmartCampaignAdResponse response = client.SuggestSmartCampaignAd(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task SuggestSmartCampaignAdRequestObjectAsync()
        {
            moq::Mock<SmartCampaignSuggestService.SmartCampaignSuggestServiceClient> mockGrpcClient = new moq::Mock<SmartCampaignSuggestService.SmartCampaignSuggestServiceClient>(moq::MockBehavior.Strict);
            SuggestSmartCampaignAdRequest request = new SuggestSmartCampaignAdRequest
            {
                CustomerId = "customer_id3b3724cb",
                SuggestionInfo = new SmartCampaignSuggestionInfo(),
            };
            SuggestSmartCampaignAdResponse expectedResponse = new SuggestSmartCampaignAdResponse
            {
                AdInfo = new gagvc::SmartCampaignAdInfo(),
            };
            mockGrpcClient.Setup(x => x.SuggestSmartCampaignAdAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SuggestSmartCampaignAdResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SmartCampaignSuggestServiceClient client = new SmartCampaignSuggestServiceClientImpl(mockGrpcClient.Object, null);
            SuggestSmartCampaignAdResponse responseCallSettings = await client.SuggestSmartCampaignAdAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            SuggestSmartCampaignAdResponse responseCancellationToken = await client.SuggestSmartCampaignAdAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

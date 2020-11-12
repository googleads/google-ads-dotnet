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

using gagvr = Google.Ads.GoogleAds.V6.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V6.Services;

namespace Google.Ads.GoogleAds.Tests.V6.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDomainCategoryServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetDomainCategoryRequestObject()
        {
            moq::Mock<DomainCategoryService.DomainCategoryServiceClient> mockGrpcClient = new moq::Mock<DomainCategoryService.DomainCategoryServiceClient>(moq::MockBehavior.Strict);
            GetDomainCategoryRequest request = new GetDomainCategoryRequest
            {
                ResourceNameAsDomainCategoryName = gagvr::DomainCategoryName.FromCustomerCampaignBase64CategoryLanguageCode("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[BASE64_CATEGORY]", "[LANGUAGE_CODE]"),
            };
            gagvr::DomainCategory expectedResponse = new gagvr::DomainCategory
            {
                ResourceNameAsDomainCategoryName = gagvr::DomainCategoryName.FromCustomerCampaignBase64CategoryLanguageCode("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[BASE64_CATEGORY]", "[LANGUAGE_CODE]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Category = "category2f35efc4",
                LanguageCode = "language_code2f6c7160",
                Domain = "domaine8825fad",
                CoverageFraction = -7.485837735521371E+17,
                CategoryRank = 1518138877595598869L,
                HasChildren = true,
                RecommendedCpcBidMicros = -6300343548803856813L,
            };
            mockGrpcClient.Setup(x => x.GetDomainCategory(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainCategoryServiceClient client = new DomainCategoryServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DomainCategory response = client.GetDomainCategory(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetDomainCategoryRequestObjectAsync()
        {
            moq::Mock<DomainCategoryService.DomainCategoryServiceClient> mockGrpcClient = new moq::Mock<DomainCategoryService.DomainCategoryServiceClient>(moq::MockBehavior.Strict);
            GetDomainCategoryRequest request = new GetDomainCategoryRequest
            {
                ResourceNameAsDomainCategoryName = gagvr::DomainCategoryName.FromCustomerCampaignBase64CategoryLanguageCode("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[BASE64_CATEGORY]", "[LANGUAGE_CODE]"),
            };
            gagvr::DomainCategory expectedResponse = new gagvr::DomainCategory
            {
                ResourceNameAsDomainCategoryName = gagvr::DomainCategoryName.FromCustomerCampaignBase64CategoryLanguageCode("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[BASE64_CATEGORY]", "[LANGUAGE_CODE]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Category = "category2f35efc4",
                LanguageCode = "language_code2f6c7160",
                Domain = "domaine8825fad",
                CoverageFraction = -7.485837735521371E+17,
                CategoryRank = 1518138877595598869L,
                HasChildren = true,
                RecommendedCpcBidMicros = -6300343548803856813L,
            };
            mockGrpcClient.Setup(x => x.GetDomainCategoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DomainCategory>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainCategoryServiceClient client = new DomainCategoryServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DomainCategory responseCallSettings = await client.GetDomainCategoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DomainCategory responseCancellationToken = await client.GetDomainCategoryAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetDomainCategory()
        {
            moq::Mock<DomainCategoryService.DomainCategoryServiceClient> mockGrpcClient = new moq::Mock<DomainCategoryService.DomainCategoryServiceClient>(moq::MockBehavior.Strict);
            GetDomainCategoryRequest request = new GetDomainCategoryRequest
            {
                ResourceNameAsDomainCategoryName = gagvr::DomainCategoryName.FromCustomerCampaignBase64CategoryLanguageCode("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[BASE64_CATEGORY]", "[LANGUAGE_CODE]"),
            };
            gagvr::DomainCategory expectedResponse = new gagvr::DomainCategory
            {
                ResourceNameAsDomainCategoryName = gagvr::DomainCategoryName.FromCustomerCampaignBase64CategoryLanguageCode("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[BASE64_CATEGORY]", "[LANGUAGE_CODE]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Category = "category2f35efc4",
                LanguageCode = "language_code2f6c7160",
                Domain = "domaine8825fad",
                CoverageFraction = -7.485837735521371E+17,
                CategoryRank = 1518138877595598869L,
                HasChildren = true,
                RecommendedCpcBidMicros = -6300343548803856813L,
            };
            mockGrpcClient.Setup(x => x.GetDomainCategory(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainCategoryServiceClient client = new DomainCategoryServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DomainCategory response = client.GetDomainCategory(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetDomainCategoryAsync()
        {
            moq::Mock<DomainCategoryService.DomainCategoryServiceClient> mockGrpcClient = new moq::Mock<DomainCategoryService.DomainCategoryServiceClient>(moq::MockBehavior.Strict);
            GetDomainCategoryRequest request = new GetDomainCategoryRequest
            {
                ResourceNameAsDomainCategoryName = gagvr::DomainCategoryName.FromCustomerCampaignBase64CategoryLanguageCode("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[BASE64_CATEGORY]", "[LANGUAGE_CODE]"),
            };
            gagvr::DomainCategory expectedResponse = new gagvr::DomainCategory
            {
                ResourceNameAsDomainCategoryName = gagvr::DomainCategoryName.FromCustomerCampaignBase64CategoryLanguageCode("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[BASE64_CATEGORY]", "[LANGUAGE_CODE]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Category = "category2f35efc4",
                LanguageCode = "language_code2f6c7160",
                Domain = "domaine8825fad",
                CoverageFraction = -7.485837735521371E+17,
                CategoryRank = 1518138877595598869L,
                HasChildren = true,
                RecommendedCpcBidMicros = -6300343548803856813L,
            };
            mockGrpcClient.Setup(x => x.GetDomainCategoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DomainCategory>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainCategoryServiceClient client = new DomainCategoryServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DomainCategory responseCallSettings = await client.GetDomainCategoryAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DomainCategory responseCancellationToken = await client.GetDomainCategoryAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetDomainCategoryResourceNames()
        {
            moq::Mock<DomainCategoryService.DomainCategoryServiceClient> mockGrpcClient = new moq::Mock<DomainCategoryService.DomainCategoryServiceClient>(moq::MockBehavior.Strict);
            GetDomainCategoryRequest request = new GetDomainCategoryRequest
            {
                ResourceNameAsDomainCategoryName = gagvr::DomainCategoryName.FromCustomerCampaignBase64CategoryLanguageCode("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[BASE64_CATEGORY]", "[LANGUAGE_CODE]"),
            };
            gagvr::DomainCategory expectedResponse = new gagvr::DomainCategory
            {
                ResourceNameAsDomainCategoryName = gagvr::DomainCategoryName.FromCustomerCampaignBase64CategoryLanguageCode("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[BASE64_CATEGORY]", "[LANGUAGE_CODE]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Category = "category2f35efc4",
                LanguageCode = "language_code2f6c7160",
                Domain = "domaine8825fad",
                CoverageFraction = -7.485837735521371E+17,
                CategoryRank = 1518138877595598869L,
                HasChildren = true,
                RecommendedCpcBidMicros = -6300343548803856813L,
            };
            mockGrpcClient.Setup(x => x.GetDomainCategory(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DomainCategoryServiceClient client = new DomainCategoryServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DomainCategory response = client.GetDomainCategory(request.ResourceNameAsDomainCategoryName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetDomainCategoryResourceNamesAsync()
        {
            moq::Mock<DomainCategoryService.DomainCategoryServiceClient> mockGrpcClient = new moq::Mock<DomainCategoryService.DomainCategoryServiceClient>(moq::MockBehavior.Strict);
            GetDomainCategoryRequest request = new GetDomainCategoryRequest
            {
                ResourceNameAsDomainCategoryName = gagvr::DomainCategoryName.FromCustomerCampaignBase64CategoryLanguageCode("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[BASE64_CATEGORY]", "[LANGUAGE_CODE]"),
            };
            gagvr::DomainCategory expectedResponse = new gagvr::DomainCategory
            {
                ResourceNameAsDomainCategoryName = gagvr::DomainCategoryName.FromCustomerCampaignBase64CategoryLanguageCode("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[BASE64_CATEGORY]", "[LANGUAGE_CODE]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Category = "category2f35efc4",
                LanguageCode = "language_code2f6c7160",
                Domain = "domaine8825fad",
                CoverageFraction = -7.485837735521371E+17,
                CategoryRank = 1518138877595598869L,
                HasChildren = true,
                RecommendedCpcBidMicros = -6300343548803856813L,
            };
            mockGrpcClient.Setup(x => x.GetDomainCategoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DomainCategory>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DomainCategoryServiceClient client = new DomainCategoryServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DomainCategory responseCallSettings = await client.GetDomainCategoryAsync(request.ResourceNameAsDomainCategoryName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DomainCategory responseCancellationToken = await client.GetDomainCategoryAsync(request.ResourceNameAsDomainCategoryName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

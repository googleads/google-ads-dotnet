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
    public sealed class GeneratedDynamicSearchAdsSearchTermViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetDynamicSearchAdsSearchTermViewRequestObject()
        {
            moq::Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetDynamicSearchAdsSearchTermViewRequest request = new GetDynamicSearchAdsSearchTermViewRequest
            {
                ResourceNameAsDynamicSearchAdsSearchTermViewName = gagvr::DynamicSearchAdsSearchTermViewName.FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[SEARCH_TERM_FINGERPRINT]", "[HEADLINE_FINGERPRINT]", "[LANDING_PAGE_FINGERPRINT]", "[PAGE_URL_FINGERPRINT]"),
            };
            gagvr::DynamicSearchAdsSearchTermView expectedResponse = new gagvr::DynamicSearchAdsSearchTermView
            {
                ResourceNameAsDynamicSearchAdsSearchTermViewName = gagvr::DynamicSearchAdsSearchTermViewName.FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[SEARCH_TERM_FINGERPRINT]", "[HEADLINE_FINGERPRINT]", "[LANDING_PAGE_FINGERPRINT]", "[PAGE_URL_FINGERPRINT]"),
                SearchTerm = "search_term6c01a1df",
                Headline = "headline583098ef",
                LandingPage = "landing_page89bf8d81",
                PageUrl = "page_url886e2c07",
                HasNegativeKeyword = false,
                HasMatchingKeyword = true,
                HasNegativeUrl = true,
            };
            mockGrpcClient.Setup(x => x.GetDynamicSearchAdsSearchTermView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DynamicSearchAdsSearchTermViewServiceClient client = new DynamicSearchAdsSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DynamicSearchAdsSearchTermView response = client.GetDynamicSearchAdsSearchTermView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetDynamicSearchAdsSearchTermViewRequestObjectAsync()
        {
            moq::Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetDynamicSearchAdsSearchTermViewRequest request = new GetDynamicSearchAdsSearchTermViewRequest
            {
                ResourceNameAsDynamicSearchAdsSearchTermViewName = gagvr::DynamicSearchAdsSearchTermViewName.FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[SEARCH_TERM_FINGERPRINT]", "[HEADLINE_FINGERPRINT]", "[LANDING_PAGE_FINGERPRINT]", "[PAGE_URL_FINGERPRINT]"),
            };
            gagvr::DynamicSearchAdsSearchTermView expectedResponse = new gagvr::DynamicSearchAdsSearchTermView
            {
                ResourceNameAsDynamicSearchAdsSearchTermViewName = gagvr::DynamicSearchAdsSearchTermViewName.FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[SEARCH_TERM_FINGERPRINT]", "[HEADLINE_FINGERPRINT]", "[LANDING_PAGE_FINGERPRINT]", "[PAGE_URL_FINGERPRINT]"),
                SearchTerm = "search_term6c01a1df",
                Headline = "headline583098ef",
                LandingPage = "landing_page89bf8d81",
                PageUrl = "page_url886e2c07",
                HasNegativeKeyword = false,
                HasMatchingKeyword = true,
                HasNegativeUrl = true,
            };
            mockGrpcClient.Setup(x => x.GetDynamicSearchAdsSearchTermViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DynamicSearchAdsSearchTermView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DynamicSearchAdsSearchTermViewServiceClient client = new DynamicSearchAdsSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DynamicSearchAdsSearchTermView responseCallSettings = await client.GetDynamicSearchAdsSearchTermViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DynamicSearchAdsSearchTermView responseCancellationToken = await client.GetDynamicSearchAdsSearchTermViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetDynamicSearchAdsSearchTermView()
        {
            moq::Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetDynamicSearchAdsSearchTermViewRequest request = new GetDynamicSearchAdsSearchTermViewRequest
            {
                ResourceNameAsDynamicSearchAdsSearchTermViewName = gagvr::DynamicSearchAdsSearchTermViewName.FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[SEARCH_TERM_FINGERPRINT]", "[HEADLINE_FINGERPRINT]", "[LANDING_PAGE_FINGERPRINT]", "[PAGE_URL_FINGERPRINT]"),
            };
            gagvr::DynamicSearchAdsSearchTermView expectedResponse = new gagvr::DynamicSearchAdsSearchTermView
            {
                ResourceNameAsDynamicSearchAdsSearchTermViewName = gagvr::DynamicSearchAdsSearchTermViewName.FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[SEARCH_TERM_FINGERPRINT]", "[HEADLINE_FINGERPRINT]", "[LANDING_PAGE_FINGERPRINT]", "[PAGE_URL_FINGERPRINT]"),
                SearchTerm = "search_term6c01a1df",
                Headline = "headline583098ef",
                LandingPage = "landing_page89bf8d81",
                PageUrl = "page_url886e2c07",
                HasNegativeKeyword = false,
                HasMatchingKeyword = true,
                HasNegativeUrl = true,
            };
            mockGrpcClient.Setup(x => x.GetDynamicSearchAdsSearchTermView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DynamicSearchAdsSearchTermViewServiceClient client = new DynamicSearchAdsSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DynamicSearchAdsSearchTermView response = client.GetDynamicSearchAdsSearchTermView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetDynamicSearchAdsSearchTermViewAsync()
        {
            moq::Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetDynamicSearchAdsSearchTermViewRequest request = new GetDynamicSearchAdsSearchTermViewRequest
            {
                ResourceNameAsDynamicSearchAdsSearchTermViewName = gagvr::DynamicSearchAdsSearchTermViewName.FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[SEARCH_TERM_FINGERPRINT]", "[HEADLINE_FINGERPRINT]", "[LANDING_PAGE_FINGERPRINT]", "[PAGE_URL_FINGERPRINT]"),
            };
            gagvr::DynamicSearchAdsSearchTermView expectedResponse = new gagvr::DynamicSearchAdsSearchTermView
            {
                ResourceNameAsDynamicSearchAdsSearchTermViewName = gagvr::DynamicSearchAdsSearchTermViewName.FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[SEARCH_TERM_FINGERPRINT]", "[HEADLINE_FINGERPRINT]", "[LANDING_PAGE_FINGERPRINT]", "[PAGE_URL_FINGERPRINT]"),
                SearchTerm = "search_term6c01a1df",
                Headline = "headline583098ef",
                LandingPage = "landing_page89bf8d81",
                PageUrl = "page_url886e2c07",
                HasNegativeKeyword = false,
                HasMatchingKeyword = true,
                HasNegativeUrl = true,
            };
            mockGrpcClient.Setup(x => x.GetDynamicSearchAdsSearchTermViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DynamicSearchAdsSearchTermView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DynamicSearchAdsSearchTermViewServiceClient client = new DynamicSearchAdsSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DynamicSearchAdsSearchTermView responseCallSettings = await client.GetDynamicSearchAdsSearchTermViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DynamicSearchAdsSearchTermView responseCancellationToken = await client.GetDynamicSearchAdsSearchTermViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetDynamicSearchAdsSearchTermViewResourceNames()
        {
            moq::Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetDynamicSearchAdsSearchTermViewRequest request = new GetDynamicSearchAdsSearchTermViewRequest
            {
                ResourceNameAsDynamicSearchAdsSearchTermViewName = gagvr::DynamicSearchAdsSearchTermViewName.FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[SEARCH_TERM_FINGERPRINT]", "[HEADLINE_FINGERPRINT]", "[LANDING_PAGE_FINGERPRINT]", "[PAGE_URL_FINGERPRINT]"),
            };
            gagvr::DynamicSearchAdsSearchTermView expectedResponse = new gagvr::DynamicSearchAdsSearchTermView
            {
                ResourceNameAsDynamicSearchAdsSearchTermViewName = gagvr::DynamicSearchAdsSearchTermViewName.FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[SEARCH_TERM_FINGERPRINT]", "[HEADLINE_FINGERPRINT]", "[LANDING_PAGE_FINGERPRINT]", "[PAGE_URL_FINGERPRINT]"),
                SearchTerm = "search_term6c01a1df",
                Headline = "headline583098ef",
                LandingPage = "landing_page89bf8d81",
                PageUrl = "page_url886e2c07",
                HasNegativeKeyword = false,
                HasMatchingKeyword = true,
                HasNegativeUrl = true,
            };
            mockGrpcClient.Setup(x => x.GetDynamicSearchAdsSearchTermView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DynamicSearchAdsSearchTermViewServiceClient client = new DynamicSearchAdsSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DynamicSearchAdsSearchTermView response = client.GetDynamicSearchAdsSearchTermView(request.ResourceNameAsDynamicSearchAdsSearchTermViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetDynamicSearchAdsSearchTermViewResourceNamesAsync()
        {
            moq::Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetDynamicSearchAdsSearchTermViewRequest request = new GetDynamicSearchAdsSearchTermViewRequest
            {
                ResourceNameAsDynamicSearchAdsSearchTermViewName = gagvr::DynamicSearchAdsSearchTermViewName.FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[SEARCH_TERM_FINGERPRINT]", "[HEADLINE_FINGERPRINT]", "[LANDING_PAGE_FINGERPRINT]", "[PAGE_URL_FINGERPRINT]"),
            };
            gagvr::DynamicSearchAdsSearchTermView expectedResponse = new gagvr::DynamicSearchAdsSearchTermView
            {
                ResourceNameAsDynamicSearchAdsSearchTermViewName = gagvr::DynamicSearchAdsSearchTermViewName.FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[SEARCH_TERM_FINGERPRINT]", "[HEADLINE_FINGERPRINT]", "[LANDING_PAGE_FINGERPRINT]", "[PAGE_URL_FINGERPRINT]"),
                SearchTerm = "search_term6c01a1df",
                Headline = "headline583098ef",
                LandingPage = "landing_page89bf8d81",
                PageUrl = "page_url886e2c07",
                HasNegativeKeyword = false,
                HasMatchingKeyword = true,
                HasNegativeUrl = true,
            };
            mockGrpcClient.Setup(x => x.GetDynamicSearchAdsSearchTermViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DynamicSearchAdsSearchTermView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DynamicSearchAdsSearchTermViewServiceClient client = new DynamicSearchAdsSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DynamicSearchAdsSearchTermView responseCallSettings = await client.GetDynamicSearchAdsSearchTermViewAsync(request.ResourceNameAsDynamicSearchAdsSearchTermViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DynamicSearchAdsSearchTermView responseCancellationToken = await client.GetDynamicSearchAdsSearchTermViewAsync(request.ResourceNameAsDynamicSearchAdsSearchTermViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

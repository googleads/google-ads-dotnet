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

using gagvr = Google.Ads.GoogleAds.V7.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V7.Services;

namespace Google.Ads.GoogleAds.Tests.V7.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPaidOrganicSearchTermViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetPaidOrganicSearchTermViewRequestObject()
        {
            moq::Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetPaidOrganicSearchTermViewRequest request = new GetPaidOrganicSearchTermViewRequest
            {
                ResourceNameAsPaidOrganicSearchTermViewName = gagvr::PaidOrganicSearchTermViewName.FromCustomerCampaignAdGroupBase64SearchTerm("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[BASE64_SEARCH_TERM]"),
            };
            gagvr::PaidOrganicSearchTermView expectedResponse = new gagvr::PaidOrganicSearchTermView
            {
                ResourceNameAsPaidOrganicSearchTermViewName = gagvr::PaidOrganicSearchTermViewName.FromCustomerCampaignAdGroupBase64SearchTerm("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[BASE64_SEARCH_TERM]"),
                SearchTerm = "search_term6c01a1df",
            };
            mockGrpcClient.Setup(x => x.GetPaidOrganicSearchTermView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PaidOrganicSearchTermViewServiceClient client = new PaidOrganicSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::PaidOrganicSearchTermView response = client.GetPaidOrganicSearchTermView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetPaidOrganicSearchTermViewRequestObjectAsync()
        {
            moq::Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetPaidOrganicSearchTermViewRequest request = new GetPaidOrganicSearchTermViewRequest
            {
                ResourceNameAsPaidOrganicSearchTermViewName = gagvr::PaidOrganicSearchTermViewName.FromCustomerCampaignAdGroupBase64SearchTerm("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[BASE64_SEARCH_TERM]"),
            };
            gagvr::PaidOrganicSearchTermView expectedResponse = new gagvr::PaidOrganicSearchTermView
            {
                ResourceNameAsPaidOrganicSearchTermViewName = gagvr::PaidOrganicSearchTermViewName.FromCustomerCampaignAdGroupBase64SearchTerm("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[BASE64_SEARCH_TERM]"),
                SearchTerm = "search_term6c01a1df",
            };
            mockGrpcClient.Setup(x => x.GetPaidOrganicSearchTermViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::PaidOrganicSearchTermView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PaidOrganicSearchTermViewServiceClient client = new PaidOrganicSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::PaidOrganicSearchTermView responseCallSettings = await client.GetPaidOrganicSearchTermViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::PaidOrganicSearchTermView responseCancellationToken = await client.GetPaidOrganicSearchTermViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetPaidOrganicSearchTermView()
        {
            moq::Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetPaidOrganicSearchTermViewRequest request = new GetPaidOrganicSearchTermViewRequest
            {
                ResourceNameAsPaidOrganicSearchTermViewName = gagvr::PaidOrganicSearchTermViewName.FromCustomerCampaignAdGroupBase64SearchTerm("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[BASE64_SEARCH_TERM]"),
            };
            gagvr::PaidOrganicSearchTermView expectedResponse = new gagvr::PaidOrganicSearchTermView
            {
                ResourceNameAsPaidOrganicSearchTermViewName = gagvr::PaidOrganicSearchTermViewName.FromCustomerCampaignAdGroupBase64SearchTerm("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[BASE64_SEARCH_TERM]"),
                SearchTerm = "search_term6c01a1df",
            };
            mockGrpcClient.Setup(x => x.GetPaidOrganicSearchTermView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PaidOrganicSearchTermViewServiceClient client = new PaidOrganicSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::PaidOrganicSearchTermView response = client.GetPaidOrganicSearchTermView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetPaidOrganicSearchTermViewAsync()
        {
            moq::Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetPaidOrganicSearchTermViewRequest request = new GetPaidOrganicSearchTermViewRequest
            {
                ResourceNameAsPaidOrganicSearchTermViewName = gagvr::PaidOrganicSearchTermViewName.FromCustomerCampaignAdGroupBase64SearchTerm("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[BASE64_SEARCH_TERM]"),
            };
            gagvr::PaidOrganicSearchTermView expectedResponse = new gagvr::PaidOrganicSearchTermView
            {
                ResourceNameAsPaidOrganicSearchTermViewName = gagvr::PaidOrganicSearchTermViewName.FromCustomerCampaignAdGroupBase64SearchTerm("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[BASE64_SEARCH_TERM]"),
                SearchTerm = "search_term6c01a1df",
            };
            mockGrpcClient.Setup(x => x.GetPaidOrganicSearchTermViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::PaidOrganicSearchTermView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PaidOrganicSearchTermViewServiceClient client = new PaidOrganicSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::PaidOrganicSearchTermView responseCallSettings = await client.GetPaidOrganicSearchTermViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::PaidOrganicSearchTermView responseCancellationToken = await client.GetPaidOrganicSearchTermViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetPaidOrganicSearchTermViewResourceNames()
        {
            moq::Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetPaidOrganicSearchTermViewRequest request = new GetPaidOrganicSearchTermViewRequest
            {
                ResourceNameAsPaidOrganicSearchTermViewName = gagvr::PaidOrganicSearchTermViewName.FromCustomerCampaignAdGroupBase64SearchTerm("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[BASE64_SEARCH_TERM]"),
            };
            gagvr::PaidOrganicSearchTermView expectedResponse = new gagvr::PaidOrganicSearchTermView
            {
                ResourceNameAsPaidOrganicSearchTermViewName = gagvr::PaidOrganicSearchTermViewName.FromCustomerCampaignAdGroupBase64SearchTerm("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[BASE64_SEARCH_TERM]"),
                SearchTerm = "search_term6c01a1df",
            };
            mockGrpcClient.Setup(x => x.GetPaidOrganicSearchTermView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PaidOrganicSearchTermViewServiceClient client = new PaidOrganicSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::PaidOrganicSearchTermView response = client.GetPaidOrganicSearchTermView(request.ResourceNameAsPaidOrganicSearchTermViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetPaidOrganicSearchTermViewResourceNamesAsync()
        {
            moq::Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient> mockGrpcClient = new moq::Mock<PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetPaidOrganicSearchTermViewRequest request = new GetPaidOrganicSearchTermViewRequest
            {
                ResourceNameAsPaidOrganicSearchTermViewName = gagvr::PaidOrganicSearchTermViewName.FromCustomerCampaignAdGroupBase64SearchTerm("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[BASE64_SEARCH_TERM]"),
            };
            gagvr::PaidOrganicSearchTermView expectedResponse = new gagvr::PaidOrganicSearchTermView
            {
                ResourceNameAsPaidOrganicSearchTermViewName = gagvr::PaidOrganicSearchTermViewName.FromCustomerCampaignAdGroupBase64SearchTerm("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[AD_GROUP_ID]", "[BASE64_SEARCH_TERM]"),
                SearchTerm = "search_term6c01a1df",
            };
            mockGrpcClient.Setup(x => x.GetPaidOrganicSearchTermViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::PaidOrganicSearchTermView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PaidOrganicSearchTermViewServiceClient client = new PaidOrganicSearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::PaidOrganicSearchTermView responseCallSettings = await client.GetPaidOrganicSearchTermViewAsync(request.ResourceNameAsPaidOrganicSearchTermViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::PaidOrganicSearchTermView responseCancellationToken = await client.GetPaidOrganicSearchTermViewAsync(request.ResourceNameAsPaidOrganicSearchTermViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

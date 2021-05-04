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
    public sealed class GeneratedAdScheduleViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAdScheduleViewRequestObject()
        {
            moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient> mockGrpcClient = new moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient>(moq::MockBehavior.Strict);
            GetAdScheduleViewRequest request = new GetAdScheduleViewRequest
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdScheduleView expectedResponse = new gagvr::AdScheduleView
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdScheduleView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdScheduleViewServiceClient client = new AdScheduleViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdScheduleView response = client.GetAdScheduleView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdScheduleViewRequestObjectAsync()
        {
            moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient> mockGrpcClient = new moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient>(moq::MockBehavior.Strict);
            GetAdScheduleViewRequest request = new GetAdScheduleViewRequest
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdScheduleView expectedResponse = new gagvr::AdScheduleView
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdScheduleViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdScheduleView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdScheduleViewServiceClient client = new AdScheduleViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdScheduleView responseCallSettings = await client.GetAdScheduleViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdScheduleView responseCancellationToken = await client.GetAdScheduleViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdScheduleView()
        {
            moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient> mockGrpcClient = new moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient>(moq::MockBehavior.Strict);
            GetAdScheduleViewRequest request = new GetAdScheduleViewRequest
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdScheduleView expectedResponse = new gagvr::AdScheduleView
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdScheduleView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdScheduleViewServiceClient client = new AdScheduleViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdScheduleView response = client.GetAdScheduleView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdScheduleViewAsync()
        {
            moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient> mockGrpcClient = new moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient>(moq::MockBehavior.Strict);
            GetAdScheduleViewRequest request = new GetAdScheduleViewRequest
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdScheduleView expectedResponse = new gagvr::AdScheduleView
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdScheduleViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdScheduleView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdScheduleViewServiceClient client = new AdScheduleViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdScheduleView responseCallSettings = await client.GetAdScheduleViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdScheduleView responseCancellationToken = await client.GetAdScheduleViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdScheduleViewResourceNames()
        {
            moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient> mockGrpcClient = new moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient>(moq::MockBehavior.Strict);
            GetAdScheduleViewRequest request = new GetAdScheduleViewRequest
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdScheduleView expectedResponse = new gagvr::AdScheduleView
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdScheduleView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdScheduleViewServiceClient client = new AdScheduleViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdScheduleView response = client.GetAdScheduleView(request.ResourceNameAsAdScheduleViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdScheduleViewResourceNamesAsync()
        {
            moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient> mockGrpcClient = new moq::Mock<AdScheduleViewService.AdScheduleViewServiceClient>(moq::MockBehavior.Strict);
            GetAdScheduleViewRequest request = new GetAdScheduleViewRequest
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdScheduleView expectedResponse = new gagvr::AdScheduleView
            {
                ResourceNameAsAdScheduleViewName = gagvr::AdScheduleViewName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAdScheduleViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdScheduleView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdScheduleViewServiceClient client = new AdScheduleViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdScheduleView responseCallSettings = await client.GetAdScheduleViewAsync(request.ResourceNameAsAdScheduleViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdScheduleView responseCancellationToken = await client.GetAdScheduleViewAsync(request.ResourceNameAsAdScheduleViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

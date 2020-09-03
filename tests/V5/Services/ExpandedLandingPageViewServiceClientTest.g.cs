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

using gagvr = Google.Ads.GoogleAds.V5.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V5.Services;

namespace Google.Ads.GoogleAds.Tests.V5.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedExpandedLandingPageViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetExpandedLandingPageViewRequestObject()
        {
            moq::Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient> mockGrpcClient = new moq::Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient>(moq::MockBehavior.Strict);
            GetExpandedLandingPageViewRequest request = new GetExpandedLandingPageViewRequest
            {
                ResourceNameAsExpandedLandingPageViewName = gagvr::ExpandedLandingPageViewName.FromCustomerExpandedLandingPageView("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]"),
            };
            gagvr::ExpandedLandingPageView expectedResponse = new gagvr::ExpandedLandingPageView
            {
                ResourceNameAsExpandedLandingPageViewName = gagvr::ExpandedLandingPageViewName.FromCustomerExpandedLandingPageView("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]"),
                ExpandedFinalUrl = "expanded_final_url4339aa97",
            };
            mockGrpcClient.Setup(x => x.GetExpandedLandingPageView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExpandedLandingPageViewServiceClient client = new ExpandedLandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ExpandedLandingPageView response = client.GetExpandedLandingPageView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetExpandedLandingPageViewRequestObjectAsync()
        {
            moq::Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient> mockGrpcClient = new moq::Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient>(moq::MockBehavior.Strict);
            GetExpandedLandingPageViewRequest request = new GetExpandedLandingPageViewRequest
            {
                ResourceNameAsExpandedLandingPageViewName = gagvr::ExpandedLandingPageViewName.FromCustomerExpandedLandingPageView("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]"),
            };
            gagvr::ExpandedLandingPageView expectedResponse = new gagvr::ExpandedLandingPageView
            {
                ResourceNameAsExpandedLandingPageViewName = gagvr::ExpandedLandingPageViewName.FromCustomerExpandedLandingPageView("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]"),
                ExpandedFinalUrl = "expanded_final_url4339aa97",
            };
            mockGrpcClient.Setup(x => x.GetExpandedLandingPageViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ExpandedLandingPageView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExpandedLandingPageViewServiceClient client = new ExpandedLandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ExpandedLandingPageView responseCallSettings = await client.GetExpandedLandingPageViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ExpandedLandingPageView responseCancellationToken = await client.GetExpandedLandingPageViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetExpandedLandingPageView()
        {
            moq::Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient> mockGrpcClient = new moq::Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient>(moq::MockBehavior.Strict);
            GetExpandedLandingPageViewRequest request = new GetExpandedLandingPageViewRequest
            {
                ResourceNameAsExpandedLandingPageViewName = gagvr::ExpandedLandingPageViewName.FromCustomerExpandedLandingPageView("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]"),
            };
            gagvr::ExpandedLandingPageView expectedResponse = new gagvr::ExpandedLandingPageView
            {
                ResourceNameAsExpandedLandingPageViewName = gagvr::ExpandedLandingPageViewName.FromCustomerExpandedLandingPageView("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]"),
                ExpandedFinalUrl = "expanded_final_url4339aa97",
            };
            mockGrpcClient.Setup(x => x.GetExpandedLandingPageView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExpandedLandingPageViewServiceClient client = new ExpandedLandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ExpandedLandingPageView response = client.GetExpandedLandingPageView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetExpandedLandingPageViewAsync()
        {
            moq::Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient> mockGrpcClient = new moq::Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient>(moq::MockBehavior.Strict);
            GetExpandedLandingPageViewRequest request = new GetExpandedLandingPageViewRequest
            {
                ResourceNameAsExpandedLandingPageViewName = gagvr::ExpandedLandingPageViewName.FromCustomerExpandedLandingPageView("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]"),
            };
            gagvr::ExpandedLandingPageView expectedResponse = new gagvr::ExpandedLandingPageView
            {
                ResourceNameAsExpandedLandingPageViewName = gagvr::ExpandedLandingPageViewName.FromCustomerExpandedLandingPageView("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]"),
                ExpandedFinalUrl = "expanded_final_url4339aa97",
            };
            mockGrpcClient.Setup(x => x.GetExpandedLandingPageViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ExpandedLandingPageView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExpandedLandingPageViewServiceClient client = new ExpandedLandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ExpandedLandingPageView responseCallSettings = await client.GetExpandedLandingPageViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ExpandedLandingPageView responseCancellationToken = await client.GetExpandedLandingPageViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetExpandedLandingPageViewResourceNames()
        {
            moq::Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient> mockGrpcClient = new moq::Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient>(moq::MockBehavior.Strict);
            GetExpandedLandingPageViewRequest request = new GetExpandedLandingPageViewRequest
            {
                ResourceNameAsExpandedLandingPageViewName = gagvr::ExpandedLandingPageViewName.FromCustomerExpandedLandingPageView("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]"),
            };
            gagvr::ExpandedLandingPageView expectedResponse = new gagvr::ExpandedLandingPageView
            {
                ResourceNameAsExpandedLandingPageViewName = gagvr::ExpandedLandingPageViewName.FromCustomerExpandedLandingPageView("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]"),
                ExpandedFinalUrl = "expanded_final_url4339aa97",
            };
            mockGrpcClient.Setup(x => x.GetExpandedLandingPageView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExpandedLandingPageViewServiceClient client = new ExpandedLandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ExpandedLandingPageView response = client.GetExpandedLandingPageView(request.ResourceNameAsExpandedLandingPageViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetExpandedLandingPageViewResourceNamesAsync()
        {
            moq::Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient> mockGrpcClient = new moq::Mock<ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient>(moq::MockBehavior.Strict);
            GetExpandedLandingPageViewRequest request = new GetExpandedLandingPageViewRequest
            {
                ResourceNameAsExpandedLandingPageViewName = gagvr::ExpandedLandingPageViewName.FromCustomerExpandedLandingPageView("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]"),
            };
            gagvr::ExpandedLandingPageView expectedResponse = new gagvr::ExpandedLandingPageView
            {
                ResourceNameAsExpandedLandingPageViewName = gagvr::ExpandedLandingPageViewName.FromCustomerExpandedLandingPageView("[CUSTOMER]", "[EXPANDED_LANDING_PAGE_VIEW]"),
                ExpandedFinalUrl = "expanded_final_url4339aa97",
            };
            mockGrpcClient.Setup(x => x.GetExpandedLandingPageViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ExpandedLandingPageView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExpandedLandingPageViewServiceClient client = new ExpandedLandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ExpandedLandingPageView responseCallSettings = await client.GetExpandedLandingPageViewAsync(request.ResourceNameAsExpandedLandingPageViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ExpandedLandingPageView responseCancellationToken = await client.GetExpandedLandingPageViewAsync(request.ResourceNameAsExpandedLandingPageViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

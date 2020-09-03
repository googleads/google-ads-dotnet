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

using gagvc = Google.Ads.GoogleAds.V3.Common;
using gagvr = Google.Ads.GoogleAds.V3.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V3.Services;

namespace Google.Ads.GoogleAds.Tests.V3.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedClickViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetClickViewRequestObject()
        {
            moq::Mock<ClickViewService.ClickViewServiceClient> mockGrpcClient = new moq::Mock<ClickViewService.ClickViewServiceClient>(moq::MockBehavior.Strict);
            GetClickViewRequest request = new GetClickViewRequest
            {
                ResourceNameAsClickViewName = gagvr::ClickViewName.FromCustomerClickView("[CUSTOMER]", "[CLICK_VIEW]"),
            };
            gagvr::ClickView expectedResponse = new gagvr::ClickView
            {
                ResourceNameAsClickViewName = gagvr::ClickViewName.FromCustomerClickView("[CUSTOMER]", "[CLICK_VIEW]"),
                Gclid = "gclid3179810b",
                AreaOfInterest = new gagvc::ClickLocation(),
                LocationOfPresence = new gagvc::ClickLocation(),
                PageNumber = -4823514921865917552L,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
            };
            mockGrpcClient.Setup(x => x.GetClickView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClickViewServiceClient client = new ClickViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ClickView response = client.GetClickView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetClickViewRequestObjectAsync()
        {
            moq::Mock<ClickViewService.ClickViewServiceClient> mockGrpcClient = new moq::Mock<ClickViewService.ClickViewServiceClient>(moq::MockBehavior.Strict);
            GetClickViewRequest request = new GetClickViewRequest
            {
                ResourceNameAsClickViewName = gagvr::ClickViewName.FromCustomerClickView("[CUSTOMER]", "[CLICK_VIEW]"),
            };
            gagvr::ClickView expectedResponse = new gagvr::ClickView
            {
                ResourceNameAsClickViewName = gagvr::ClickViewName.FromCustomerClickView("[CUSTOMER]", "[CLICK_VIEW]"),
                Gclid = "gclid3179810b",
                AreaOfInterest = new gagvc::ClickLocation(),
                LocationOfPresence = new gagvc::ClickLocation(),
                PageNumber = -4823514921865917552L,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
            };
            mockGrpcClient.Setup(x => x.GetClickViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ClickView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClickViewServiceClient client = new ClickViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ClickView responseCallSettings = await client.GetClickViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ClickView responseCancellationToken = await client.GetClickViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetClickView()
        {
            moq::Mock<ClickViewService.ClickViewServiceClient> mockGrpcClient = new moq::Mock<ClickViewService.ClickViewServiceClient>(moq::MockBehavior.Strict);
            GetClickViewRequest request = new GetClickViewRequest
            {
                ResourceNameAsClickViewName = gagvr::ClickViewName.FromCustomerClickView("[CUSTOMER]", "[CLICK_VIEW]"),
            };
            gagvr::ClickView expectedResponse = new gagvr::ClickView
            {
                ResourceNameAsClickViewName = gagvr::ClickViewName.FromCustomerClickView("[CUSTOMER]", "[CLICK_VIEW]"),
                Gclid = "gclid3179810b",
                AreaOfInterest = new gagvc::ClickLocation(),
                LocationOfPresence = new gagvc::ClickLocation(),
                PageNumber = -4823514921865917552L,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
            };
            mockGrpcClient.Setup(x => x.GetClickView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClickViewServiceClient client = new ClickViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ClickView response = client.GetClickView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetClickViewAsync()
        {
            moq::Mock<ClickViewService.ClickViewServiceClient> mockGrpcClient = new moq::Mock<ClickViewService.ClickViewServiceClient>(moq::MockBehavior.Strict);
            GetClickViewRequest request = new GetClickViewRequest
            {
                ResourceNameAsClickViewName = gagvr::ClickViewName.FromCustomerClickView("[CUSTOMER]", "[CLICK_VIEW]"),
            };
            gagvr::ClickView expectedResponse = new gagvr::ClickView
            {
                ResourceNameAsClickViewName = gagvr::ClickViewName.FromCustomerClickView("[CUSTOMER]", "[CLICK_VIEW]"),
                Gclid = "gclid3179810b",
                AreaOfInterest = new gagvc::ClickLocation(),
                LocationOfPresence = new gagvc::ClickLocation(),
                PageNumber = -4823514921865917552L,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
            };
            mockGrpcClient.Setup(x => x.GetClickViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ClickView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClickViewServiceClient client = new ClickViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ClickView responseCallSettings = await client.GetClickViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ClickView responseCancellationToken = await client.GetClickViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetClickViewResourceNames()
        {
            moq::Mock<ClickViewService.ClickViewServiceClient> mockGrpcClient = new moq::Mock<ClickViewService.ClickViewServiceClient>(moq::MockBehavior.Strict);
            GetClickViewRequest request = new GetClickViewRequest
            {
                ResourceNameAsClickViewName = gagvr::ClickViewName.FromCustomerClickView("[CUSTOMER]", "[CLICK_VIEW]"),
            };
            gagvr::ClickView expectedResponse = new gagvr::ClickView
            {
                ResourceNameAsClickViewName = gagvr::ClickViewName.FromCustomerClickView("[CUSTOMER]", "[CLICK_VIEW]"),
                Gclid = "gclid3179810b",
                AreaOfInterest = new gagvc::ClickLocation(),
                LocationOfPresence = new gagvc::ClickLocation(),
                PageNumber = -4823514921865917552L,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
            };
            mockGrpcClient.Setup(x => x.GetClickView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ClickViewServiceClient client = new ClickViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ClickView response = client.GetClickView(request.ResourceNameAsClickViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetClickViewResourceNamesAsync()
        {
            moq::Mock<ClickViewService.ClickViewServiceClient> mockGrpcClient = new moq::Mock<ClickViewService.ClickViewServiceClient>(moq::MockBehavior.Strict);
            GetClickViewRequest request = new GetClickViewRequest
            {
                ResourceNameAsClickViewName = gagvr::ClickViewName.FromCustomerClickView("[CUSTOMER]", "[CLICK_VIEW]"),
            };
            gagvr::ClickView expectedResponse = new gagvr::ClickView
            {
                ResourceNameAsClickViewName = gagvr::ClickViewName.FromCustomerClickView("[CUSTOMER]", "[CLICK_VIEW]"),
                Gclid = "gclid3179810b",
                AreaOfInterest = new gagvc::ClickLocation(),
                LocationOfPresence = new gagvc::ClickLocation(),
                PageNumber = -4823514921865917552L,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
            };
            mockGrpcClient.Setup(x => x.GetClickViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ClickView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ClickViewServiceClient client = new ClickViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ClickView responseCallSettings = await client.GetClickViewAsync(request.ResourceNameAsClickViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ClickView responseCancellationToken = await client.GetClickViewAsync(request.ResourceNameAsClickViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

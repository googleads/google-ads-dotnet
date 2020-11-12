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
    public sealed class GeneratedThirdPartyAppAnalyticsLinkServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetThirdPartyAppAnalyticsLinkRequestObject()
        {
            moq::Mock<ThirdPartyAppAnalyticsLinkService.ThirdPartyAppAnalyticsLinkServiceClient> mockGrpcClient = new moq::Mock<ThirdPartyAppAnalyticsLinkService.ThirdPartyAppAnalyticsLinkServiceClient>(moq::MockBehavior.Strict);
            GetThirdPartyAppAnalyticsLinkRequest request = new GetThirdPartyAppAnalyticsLinkRequest
            {
                ResourceNameAsThirdPartyAppAnalyticsLinkName = gagvr::ThirdPartyAppAnalyticsLinkName.FromCustomerCustomerLink("[CUSTOMER_ID]", "[CUSTOMER_LINK_ID]"),
            };
            gagvr::ThirdPartyAppAnalyticsLink expectedResponse = new gagvr::ThirdPartyAppAnalyticsLink
            {
                ResourceNameAsThirdPartyAppAnalyticsLinkName = gagvr::ThirdPartyAppAnalyticsLinkName.FromCustomerCustomerLink("[CUSTOMER_ID]", "[CUSTOMER_LINK_ID]"),
                ShareableLinkId = "shareable_link_id5121ee42",
            };
            mockGrpcClient.Setup(x => x.GetThirdPartyAppAnalyticsLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ThirdPartyAppAnalyticsLinkServiceClient client = new ThirdPartyAppAnalyticsLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ThirdPartyAppAnalyticsLink response = client.GetThirdPartyAppAnalyticsLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetThirdPartyAppAnalyticsLinkRequestObjectAsync()
        {
            moq::Mock<ThirdPartyAppAnalyticsLinkService.ThirdPartyAppAnalyticsLinkServiceClient> mockGrpcClient = new moq::Mock<ThirdPartyAppAnalyticsLinkService.ThirdPartyAppAnalyticsLinkServiceClient>(moq::MockBehavior.Strict);
            GetThirdPartyAppAnalyticsLinkRequest request = new GetThirdPartyAppAnalyticsLinkRequest
            {
                ResourceNameAsThirdPartyAppAnalyticsLinkName = gagvr::ThirdPartyAppAnalyticsLinkName.FromCustomerCustomerLink("[CUSTOMER_ID]", "[CUSTOMER_LINK_ID]"),
            };
            gagvr::ThirdPartyAppAnalyticsLink expectedResponse = new gagvr::ThirdPartyAppAnalyticsLink
            {
                ResourceNameAsThirdPartyAppAnalyticsLinkName = gagvr::ThirdPartyAppAnalyticsLinkName.FromCustomerCustomerLink("[CUSTOMER_ID]", "[CUSTOMER_LINK_ID]"),
                ShareableLinkId = "shareable_link_id5121ee42",
            };
            mockGrpcClient.Setup(x => x.GetThirdPartyAppAnalyticsLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ThirdPartyAppAnalyticsLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ThirdPartyAppAnalyticsLinkServiceClient client = new ThirdPartyAppAnalyticsLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ThirdPartyAppAnalyticsLink responseCallSettings = await client.GetThirdPartyAppAnalyticsLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ThirdPartyAppAnalyticsLink responseCancellationToken = await client.GetThirdPartyAppAnalyticsLinkAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void RegenerateShareableLinkIdRequestObject()
        {
            moq::Mock<ThirdPartyAppAnalyticsLinkService.ThirdPartyAppAnalyticsLinkServiceClient> mockGrpcClient = new moq::Mock<ThirdPartyAppAnalyticsLinkService.ThirdPartyAppAnalyticsLinkServiceClient>(moq::MockBehavior.Strict);
            RegenerateShareableLinkIdRequest request = new RegenerateShareableLinkIdRequest
            {
                ResourceNameAsThirdPartyAppAnalyticsLinkName = gagvr::ThirdPartyAppAnalyticsLinkName.FromCustomerCustomerLink("[CUSTOMER_ID]", "[CUSTOMER_LINK_ID]"),
            };
            RegenerateShareableLinkIdResponse expectedResponse = new RegenerateShareableLinkIdResponse { };
            mockGrpcClient.Setup(x => x.RegenerateShareableLinkId(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ThirdPartyAppAnalyticsLinkServiceClient client = new ThirdPartyAppAnalyticsLinkServiceClientImpl(mockGrpcClient.Object, null);
            RegenerateShareableLinkIdResponse response = client.RegenerateShareableLinkId(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task RegenerateShareableLinkIdRequestObjectAsync()
        {
            moq::Mock<ThirdPartyAppAnalyticsLinkService.ThirdPartyAppAnalyticsLinkServiceClient> mockGrpcClient = new moq::Mock<ThirdPartyAppAnalyticsLinkService.ThirdPartyAppAnalyticsLinkServiceClient>(moq::MockBehavior.Strict);
            RegenerateShareableLinkIdRequest request = new RegenerateShareableLinkIdRequest
            {
                ResourceNameAsThirdPartyAppAnalyticsLinkName = gagvr::ThirdPartyAppAnalyticsLinkName.FromCustomerCustomerLink("[CUSTOMER_ID]", "[CUSTOMER_LINK_ID]"),
            };
            RegenerateShareableLinkIdResponse expectedResponse = new RegenerateShareableLinkIdResponse { };
            mockGrpcClient.Setup(x => x.RegenerateShareableLinkIdAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegenerateShareableLinkIdResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ThirdPartyAppAnalyticsLinkServiceClient client = new ThirdPartyAppAnalyticsLinkServiceClientImpl(mockGrpcClient.Object, null);
            RegenerateShareableLinkIdResponse responseCallSettings = await client.RegenerateShareableLinkIdAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            RegenerateShareableLinkIdResponse responseCancellationToken = await client.RegenerateShareableLinkIdAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

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

using gagvr = Google.Ads.GoogleAds.V2.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V2.Services;

namespace Google.Ads.GoogleAds.Tests.V2.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdGroupAudienceViewServiceClientTest
    {
        [Test]
        public void GetAdGroupAudienceViewRequestObject()
        {
            moq::Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient> mockGrpcClient = new moq::Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAudienceViewRequest request = new GetAdGroupAudienceViewRequest
            {
                ResourceNameAsAdGroupAudienceViewName = gagvr::AdGroupAudienceViewName.FromCustomerAdGroupAudienceView("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]"),
            };
            gagvr::AdGroupAudienceView expectedResponse = new gagvr::AdGroupAudienceView
            {
                ResourceNameAsAdGroupAudienceViewName = gagvr::AdGroupAudienceViewName.FromCustomerAdGroupAudienceView("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAudienceView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAudienceViewServiceClient client = new AdGroupAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAudienceView response = client.GetAdGroupAudienceView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAdGroupAudienceViewRequestObjectAsync()
        {
            moq::Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient> mockGrpcClient = new moq::Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAudienceViewRequest request = new GetAdGroupAudienceViewRequest
            {
                ResourceNameAsAdGroupAudienceViewName = gagvr::AdGroupAudienceViewName.FromCustomerAdGroupAudienceView("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]"),
            };
            gagvr::AdGroupAudienceView expectedResponse = new gagvr::AdGroupAudienceView
            {
                ResourceNameAsAdGroupAudienceViewName = gagvr::AdGroupAudienceViewName.FromCustomerAdGroupAudienceView("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAudienceViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupAudienceView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAudienceViewServiceClient client = new AdGroupAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAudienceView responseCallSettings = await client.GetAdGroupAudienceViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupAudienceView responseCancellationToken = await client.GetAdGroupAudienceViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroupAudienceView()
        {
            moq::Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient> mockGrpcClient = new moq::Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAudienceViewRequest request = new GetAdGroupAudienceViewRequest
            {
                ResourceNameAsAdGroupAudienceViewName = gagvr::AdGroupAudienceViewName.FromCustomerAdGroupAudienceView("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]"),
            };
            gagvr::AdGroupAudienceView expectedResponse = new gagvr::AdGroupAudienceView
            {
                ResourceNameAsAdGroupAudienceViewName = gagvr::AdGroupAudienceViewName.FromCustomerAdGroupAudienceView("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAudienceView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAudienceViewServiceClient client = new AdGroupAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAudienceView response = client.GetAdGroupAudienceView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAdGroupAudienceViewAsync()
        {
            moq::Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient> mockGrpcClient = new moq::Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAudienceViewRequest request = new GetAdGroupAudienceViewRequest
            {
                ResourceNameAsAdGroupAudienceViewName = gagvr::AdGroupAudienceViewName.FromCustomerAdGroupAudienceView("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]"),
            };
            gagvr::AdGroupAudienceView expectedResponse = new gagvr::AdGroupAudienceView
            {
                ResourceNameAsAdGroupAudienceViewName = gagvr::AdGroupAudienceViewName.FromCustomerAdGroupAudienceView("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAudienceViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupAudienceView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAudienceViewServiceClient client = new AdGroupAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAudienceView responseCallSettings = await client.GetAdGroupAudienceViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupAudienceView responseCancellationToken = await client.GetAdGroupAudienceViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroupAudienceViewResourceNames()
        {
            moq::Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient> mockGrpcClient = new moq::Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAudienceViewRequest request = new GetAdGroupAudienceViewRequest
            {
                ResourceNameAsAdGroupAudienceViewName = gagvr::AdGroupAudienceViewName.FromCustomerAdGroupAudienceView("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]"),
            };
            gagvr::AdGroupAudienceView expectedResponse = new gagvr::AdGroupAudienceView
            {
                ResourceNameAsAdGroupAudienceViewName = gagvr::AdGroupAudienceViewName.FromCustomerAdGroupAudienceView("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAudienceView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAudienceViewServiceClient client = new AdGroupAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAudienceView response = client.GetAdGroupAudienceView(request.ResourceNameAsAdGroupAudienceViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAdGroupAudienceViewResourceNamesAsync()
        {
            moq::Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient> mockGrpcClient = new moq::Mock<AdGroupAudienceViewService.AdGroupAudienceViewServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAudienceViewRequest request = new GetAdGroupAudienceViewRequest
            {
                ResourceNameAsAdGroupAudienceViewName = gagvr::AdGroupAudienceViewName.FromCustomerAdGroupAudienceView("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]"),
            };
            gagvr::AdGroupAudienceView expectedResponse = new gagvr::AdGroupAudienceView
            {
                ResourceNameAsAdGroupAudienceViewName = gagvr::AdGroupAudienceViewName.FromCustomerAdGroupAudienceView("[CUSTOMER]", "[AD_GROUP_AUDIENCE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAudienceViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupAudienceView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAudienceViewServiceClient client = new AdGroupAudienceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAudienceView responseCallSettings = await client.GetAdGroupAudienceViewAsync(request.ResourceNameAsAdGroupAudienceViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupAudienceView responseCancellationToken = await client.GetAdGroupAudienceViewAsync(request.ResourceNameAsAdGroupAudienceViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

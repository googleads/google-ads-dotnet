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

using gagvr = Google.Ads.GoogleAds.V1.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V1.Services;

namespace Google.Ads.GoogleAds.Tests.V1.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDisplayKeywordViewServiceClientTest
    {
        [Test]
        public void GetDisplayKeywordViewRequestObject()
        {
            moq::Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient> mockGrpcClient = new moq::Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetDisplayKeywordViewRequest request = new GetDisplayKeywordViewRequest
            {
                ResourceNameAsDisplayKeywordViewName = gagvr::DisplayKeywordViewName.FromCustomerDisplayKeywordView("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]"),
            };
            gagvr::DisplayKeywordView expectedResponse = new gagvr::DisplayKeywordView
            {
                ResourceNameAsDisplayKeywordViewName = gagvr::DisplayKeywordViewName.FromCustomerDisplayKeywordView("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetDisplayKeywordView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DisplayKeywordViewServiceClient client = new DisplayKeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DisplayKeywordView response = client.GetDisplayKeywordView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetDisplayKeywordViewRequestObjectAsync()
        {
            moq::Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient> mockGrpcClient = new moq::Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetDisplayKeywordViewRequest request = new GetDisplayKeywordViewRequest
            {
                ResourceNameAsDisplayKeywordViewName = gagvr::DisplayKeywordViewName.FromCustomerDisplayKeywordView("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]"),
            };
            gagvr::DisplayKeywordView expectedResponse = new gagvr::DisplayKeywordView
            {
                ResourceNameAsDisplayKeywordViewName = gagvr::DisplayKeywordViewName.FromCustomerDisplayKeywordView("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetDisplayKeywordViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DisplayKeywordView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DisplayKeywordViewServiceClient client = new DisplayKeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DisplayKeywordView responseCallSettings = await client.GetDisplayKeywordViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DisplayKeywordView responseCancellationToken = await client.GetDisplayKeywordViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetDisplayKeywordView()
        {
            moq::Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient> mockGrpcClient = new moq::Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetDisplayKeywordViewRequest request = new GetDisplayKeywordViewRequest
            {
                ResourceNameAsDisplayKeywordViewName = gagvr::DisplayKeywordViewName.FromCustomerDisplayKeywordView("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]"),
            };
            gagvr::DisplayKeywordView expectedResponse = new gagvr::DisplayKeywordView
            {
                ResourceNameAsDisplayKeywordViewName = gagvr::DisplayKeywordViewName.FromCustomerDisplayKeywordView("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetDisplayKeywordView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DisplayKeywordViewServiceClient client = new DisplayKeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DisplayKeywordView response = client.GetDisplayKeywordView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetDisplayKeywordViewAsync()
        {
            moq::Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient> mockGrpcClient = new moq::Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetDisplayKeywordViewRequest request = new GetDisplayKeywordViewRequest
            {
                ResourceNameAsDisplayKeywordViewName = gagvr::DisplayKeywordViewName.FromCustomerDisplayKeywordView("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]"),
            };
            gagvr::DisplayKeywordView expectedResponse = new gagvr::DisplayKeywordView
            {
                ResourceNameAsDisplayKeywordViewName = gagvr::DisplayKeywordViewName.FromCustomerDisplayKeywordView("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetDisplayKeywordViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DisplayKeywordView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DisplayKeywordViewServiceClient client = new DisplayKeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DisplayKeywordView responseCallSettings = await client.GetDisplayKeywordViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DisplayKeywordView responseCancellationToken = await client.GetDisplayKeywordViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetDisplayKeywordViewResourceNames()
        {
            moq::Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient> mockGrpcClient = new moq::Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetDisplayKeywordViewRequest request = new GetDisplayKeywordViewRequest
            {
                ResourceNameAsDisplayKeywordViewName = gagvr::DisplayKeywordViewName.FromCustomerDisplayKeywordView("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]"),
            };
            gagvr::DisplayKeywordView expectedResponse = new gagvr::DisplayKeywordView
            {
                ResourceNameAsDisplayKeywordViewName = gagvr::DisplayKeywordViewName.FromCustomerDisplayKeywordView("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetDisplayKeywordView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DisplayKeywordViewServiceClient client = new DisplayKeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DisplayKeywordView response = client.GetDisplayKeywordView(request.ResourceNameAsDisplayKeywordViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetDisplayKeywordViewResourceNamesAsync()
        {
            moq::Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient> mockGrpcClient = new moq::Mock<DisplayKeywordViewService.DisplayKeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetDisplayKeywordViewRequest request = new GetDisplayKeywordViewRequest
            {
                ResourceNameAsDisplayKeywordViewName = gagvr::DisplayKeywordViewName.FromCustomerDisplayKeywordView("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]"),
            };
            gagvr::DisplayKeywordView expectedResponse = new gagvr::DisplayKeywordView
            {
                ResourceNameAsDisplayKeywordViewName = gagvr::DisplayKeywordViewName.FromCustomerDisplayKeywordView("[CUSTOMER]", "[DISPLAY_KEYWORD_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetDisplayKeywordViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DisplayKeywordView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DisplayKeywordViewServiceClient client = new DisplayKeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DisplayKeywordView responseCallSettings = await client.GetDisplayKeywordViewAsync(request.ResourceNameAsDisplayKeywordViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DisplayKeywordView responseCancellationToken = await client.GetDisplayKeywordViewAsync(request.ResourceNameAsDisplayKeywordViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

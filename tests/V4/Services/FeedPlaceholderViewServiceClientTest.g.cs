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

using gagve = Google.Ads.GoogleAds.V4.Enums;
using gagvr = Google.Ads.GoogleAds.V4.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V4.Services;

namespace Google.Ads.GoogleAds.Tests.V4.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFeedPlaceholderViewServiceClientTest
    {
        [Test]
        public void GetFeedPlaceholderViewRequestObject()
        {
            moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient> mockGrpcClient = new moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient>(moq::MockBehavior.Strict);
            GetFeedPlaceholderViewRequest request = new GetFeedPlaceholderViewRequest
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerFeedPlaceholderView("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]"),
            };
            gagvr::FeedPlaceholderView expectedResponse = new gagvr::FeedPlaceholderView
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerFeedPlaceholderView("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.Message,
            };
            mockGrpcClient.Setup(x => x.GetFeedPlaceholderView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedPlaceholderViewServiceClient client = new FeedPlaceholderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedPlaceholderView response = client.GetFeedPlaceholderView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetFeedPlaceholderViewRequestObjectAsync()
        {
            moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient> mockGrpcClient = new moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient>(moq::MockBehavior.Strict);
            GetFeedPlaceholderViewRequest request = new GetFeedPlaceholderViewRequest
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerFeedPlaceholderView("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]"),
            };
            gagvr::FeedPlaceholderView expectedResponse = new gagvr::FeedPlaceholderView
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerFeedPlaceholderView("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.Message,
            };
            mockGrpcClient.Setup(x => x.GetFeedPlaceholderViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedPlaceholderView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedPlaceholderViewServiceClient client = new FeedPlaceholderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedPlaceholderView responseCallSettings = await client.GetFeedPlaceholderViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedPlaceholderView responseCancellationToken = await client.GetFeedPlaceholderViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetFeedPlaceholderView()
        {
            moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient> mockGrpcClient = new moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient>(moq::MockBehavior.Strict);
            GetFeedPlaceholderViewRequest request = new GetFeedPlaceholderViewRequest
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerFeedPlaceholderView("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]"),
            };
            gagvr::FeedPlaceholderView expectedResponse = new gagvr::FeedPlaceholderView
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerFeedPlaceholderView("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.Message,
            };
            mockGrpcClient.Setup(x => x.GetFeedPlaceholderView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedPlaceholderViewServiceClient client = new FeedPlaceholderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedPlaceholderView response = client.GetFeedPlaceholderView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetFeedPlaceholderViewAsync()
        {
            moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient> mockGrpcClient = new moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient>(moq::MockBehavior.Strict);
            GetFeedPlaceholderViewRequest request = new GetFeedPlaceholderViewRequest
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerFeedPlaceholderView("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]"),
            };
            gagvr::FeedPlaceholderView expectedResponse = new gagvr::FeedPlaceholderView
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerFeedPlaceholderView("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.Message,
            };
            mockGrpcClient.Setup(x => x.GetFeedPlaceholderViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedPlaceholderView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedPlaceholderViewServiceClient client = new FeedPlaceholderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedPlaceholderView responseCallSettings = await client.GetFeedPlaceholderViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedPlaceholderView responseCancellationToken = await client.GetFeedPlaceholderViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetFeedPlaceholderViewResourceNames()
        {
            moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient> mockGrpcClient = new moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient>(moq::MockBehavior.Strict);
            GetFeedPlaceholderViewRequest request = new GetFeedPlaceholderViewRequest
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerFeedPlaceholderView("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]"),
            };
            gagvr::FeedPlaceholderView expectedResponse = new gagvr::FeedPlaceholderView
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerFeedPlaceholderView("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.Message,
            };
            mockGrpcClient.Setup(x => x.GetFeedPlaceholderView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedPlaceholderViewServiceClient client = new FeedPlaceholderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedPlaceholderView response = client.GetFeedPlaceholderView(request.ResourceNameAsFeedPlaceholderViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetFeedPlaceholderViewResourceNamesAsync()
        {
            moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient> mockGrpcClient = new moq::Mock<FeedPlaceholderViewService.FeedPlaceholderViewServiceClient>(moq::MockBehavior.Strict);
            GetFeedPlaceholderViewRequest request = new GetFeedPlaceholderViewRequest
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerFeedPlaceholderView("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]"),
            };
            gagvr::FeedPlaceholderView expectedResponse = new gagvr::FeedPlaceholderView
            {
                ResourceNameAsFeedPlaceholderViewName = gagvr::FeedPlaceholderViewName.FromCustomerFeedPlaceholderView("[CUSTOMER]", "[FEED_PLACEHOLDER_VIEW]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.Message,
            };
            mockGrpcClient.Setup(x => x.GetFeedPlaceholderViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedPlaceholderView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedPlaceholderViewServiceClient client = new FeedPlaceholderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedPlaceholderView responseCallSettings = await client.GetFeedPlaceholderViewAsync(request.ResourceNameAsFeedPlaceholderViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedPlaceholderView responseCancellationToken = await client.GetFeedPlaceholderViewAsync(request.ResourceNameAsFeedPlaceholderViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

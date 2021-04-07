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

using gagve = Google.Ads.GoogleAds.V4.Enums;
using gagvr = Google.Ads.GoogleAds.V4.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V4.Services;

namespace Google.Ads.GoogleAds.Tests.V4.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFeedServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetFeedRequestObject()
        {
            moq::Mock<FeedService.FeedServiceClient> mockGrpcClient = new moq::Mock<FeedService.FeedServiceClient>(moq::MockBehavior.Strict);
            GetFeedRequest request = new GetFeedRequest
            {
                ResourceNameAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
            };
            gagvr::Feed expectedResponse = new gagvr::Feed
            {
                ResourceNameAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Id = -6774108720365892680L,
                FeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Attributes =
                {
                    new gagvr::FeedAttribute(),
                },
                Origin = gagve::FeedOriginEnum.Types.FeedOrigin.Unspecified,
                PlacesLocationFeedData = new gagvr::Feed.Types.PlacesLocationFeedData(),
                AffiliateLocationFeedData = new gagvr::Feed.Types.AffiliateLocationFeedData(),
                Status = gagve::FeedStatusEnum.Types.FeedStatus.Enabled,
                AttributeOperations =
                {
                    new gagvr::FeedAttributeOperation(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Feed response = client.GetFeed(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetFeedRequestObjectAsync()
        {
            moq::Mock<FeedService.FeedServiceClient> mockGrpcClient = new moq::Mock<FeedService.FeedServiceClient>(moq::MockBehavior.Strict);
            GetFeedRequest request = new GetFeedRequest
            {
                ResourceNameAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
            };
            gagvr::Feed expectedResponse = new gagvr::Feed
            {
                ResourceNameAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Id = -6774108720365892680L,
                FeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Attributes =
                {
                    new gagvr::FeedAttribute(),
                },
                Origin = gagve::FeedOriginEnum.Types.FeedOrigin.Unspecified,
                PlacesLocationFeedData = new gagvr::Feed.Types.PlacesLocationFeedData(),
                AffiliateLocationFeedData = new gagvr::Feed.Types.AffiliateLocationFeedData(),
                Status = gagve::FeedStatusEnum.Types.FeedStatus.Enabled,
                AttributeOperations =
                {
                    new gagvr::FeedAttributeOperation(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Feed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Feed responseCallSettings = await client.GetFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Feed responseCancellationToken = await client.GetFeedAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetFeed()
        {
            moq::Mock<FeedService.FeedServiceClient> mockGrpcClient = new moq::Mock<FeedService.FeedServiceClient>(moq::MockBehavior.Strict);
            GetFeedRequest request = new GetFeedRequest
            {
                ResourceNameAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
            };
            gagvr::Feed expectedResponse = new gagvr::Feed
            {
                ResourceNameAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Id = -6774108720365892680L,
                FeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Attributes =
                {
                    new gagvr::FeedAttribute(),
                },
                Origin = gagve::FeedOriginEnum.Types.FeedOrigin.Unspecified,
                PlacesLocationFeedData = new gagvr::Feed.Types.PlacesLocationFeedData(),
                AffiliateLocationFeedData = new gagvr::Feed.Types.AffiliateLocationFeedData(),
                Status = gagve::FeedStatusEnum.Types.FeedStatus.Enabled,
                AttributeOperations =
                {
                    new gagvr::FeedAttributeOperation(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Feed response = client.GetFeed(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetFeedAsync()
        {
            moq::Mock<FeedService.FeedServiceClient> mockGrpcClient = new moq::Mock<FeedService.FeedServiceClient>(moq::MockBehavior.Strict);
            GetFeedRequest request = new GetFeedRequest
            {
                ResourceNameAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
            };
            gagvr::Feed expectedResponse = new gagvr::Feed
            {
                ResourceNameAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Id = -6774108720365892680L,
                FeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Attributes =
                {
                    new gagvr::FeedAttribute(),
                },
                Origin = gagve::FeedOriginEnum.Types.FeedOrigin.Unspecified,
                PlacesLocationFeedData = new gagvr::Feed.Types.PlacesLocationFeedData(),
                AffiliateLocationFeedData = new gagvr::Feed.Types.AffiliateLocationFeedData(),
                Status = gagve::FeedStatusEnum.Types.FeedStatus.Enabled,
                AttributeOperations =
                {
                    new gagvr::FeedAttributeOperation(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Feed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Feed responseCallSettings = await client.GetFeedAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Feed responseCancellationToken = await client.GetFeedAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetFeedResourceNames()
        {
            moq::Mock<FeedService.FeedServiceClient> mockGrpcClient = new moq::Mock<FeedService.FeedServiceClient>(moq::MockBehavior.Strict);
            GetFeedRequest request = new GetFeedRequest
            {
                ResourceNameAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
            };
            gagvr::Feed expectedResponse = new gagvr::Feed
            {
                ResourceNameAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Id = -6774108720365892680L,
                FeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Attributes =
                {
                    new gagvr::FeedAttribute(),
                },
                Origin = gagve::FeedOriginEnum.Types.FeedOrigin.Unspecified,
                PlacesLocationFeedData = new gagvr::Feed.Types.PlacesLocationFeedData(),
                AffiliateLocationFeedData = new gagvr::Feed.Types.AffiliateLocationFeedData(),
                Status = gagve::FeedStatusEnum.Types.FeedStatus.Enabled,
                AttributeOperations =
                {
                    new gagvr::FeedAttributeOperation(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Feed response = client.GetFeed(request.ResourceNameAsFeedName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetFeedResourceNamesAsync()
        {
            moq::Mock<FeedService.FeedServiceClient> mockGrpcClient = new moq::Mock<FeedService.FeedServiceClient>(moq::MockBehavior.Strict);
            GetFeedRequest request = new GetFeedRequest
            {
                ResourceNameAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
            };
            gagvr::Feed expectedResponse = new gagvr::Feed
            {
                ResourceNameAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Id = -6774108720365892680L,
                FeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                Attributes =
                {
                    new gagvr::FeedAttribute(),
                },
                Origin = gagve::FeedOriginEnum.Types.FeedOrigin.Unspecified,
                PlacesLocationFeedData = new gagvr::Feed.Types.PlacesLocationFeedData(),
                AffiliateLocationFeedData = new gagvr::Feed.Types.AffiliateLocationFeedData(),
                Status = gagve::FeedStatusEnum.Types.FeedStatus.Enabled,
                AttributeOperations =
                {
                    new gagvr::FeedAttributeOperation(),
                },
            };
            mockGrpcClient.Setup(x => x.GetFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Feed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Feed responseCallSettings = await client.GetFeedAsync(request.ResourceNameAsFeedName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Feed responseCancellationToken = await client.GetFeedAsync(request.ResourceNameAsFeedName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateFeedsRequestObject()
        {
            moq::Mock<FeedService.FeedServiceClient> mockGrpcClient = new moq::Mock<FeedService.FeedServiceClient>(moq::MockBehavior.Strict);
            MutateFeedsRequest request = new MutateFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateFeedsResponse expectedResponse = new MutateFeedsResponse
            {
                Results =
                {
                    new MutateFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeeds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedsResponse response = client.MutateFeeds(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateFeedsRequestObjectAsync()
        {
            moq::Mock<FeedService.FeedServiceClient> mockGrpcClient = new moq::Mock<FeedService.FeedServiceClient>(moq::MockBehavior.Strict);
            MutateFeedsRequest request = new MutateFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateFeedsResponse expectedResponse = new MutateFeedsResponse
            {
                Results =
                {
                    new MutateFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateFeedsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedsResponse responseCallSettings = await client.MutateFeedsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateFeedsResponse responseCancellationToken = await client.MutateFeedsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateFeeds()
        {
            moq::Mock<FeedService.FeedServiceClient> mockGrpcClient = new moq::Mock<FeedService.FeedServiceClient>(moq::MockBehavior.Strict);
            MutateFeedsRequest request = new MutateFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedOperation(),
                },
            };
            MutateFeedsResponse expectedResponse = new MutateFeedsResponse
            {
                Results =
                {
                    new MutateFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeeds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedsResponse response = client.MutateFeeds(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateFeedsAsync()
        {
            moq::Mock<FeedService.FeedServiceClient> mockGrpcClient = new moq::Mock<FeedService.FeedServiceClient>(moq::MockBehavior.Strict);
            MutateFeedsRequest request = new MutateFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedOperation(),
                },
            };
            MutateFeedsResponse expectedResponse = new MutateFeedsResponse
            {
                Results =
                {
                    new MutateFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateFeedsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedServiceClient client = new FeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedsResponse responseCallSettings = await client.MutateFeedsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateFeedsResponse responseCancellationToken = await client.MutateFeedsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

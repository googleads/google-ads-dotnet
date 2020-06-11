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

using gagvc = Google.Ads.GoogleAds.V2.Common;
using gagve = Google.Ads.GoogleAds.V2.Enums;
using gagvr = Google.Ads.GoogleAds.V2.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V2.Services;

namespace Google.Ads.GoogleAds.Tests.V2.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdGroupFeedServiceClientTest
    {
        [Test]
        public void GetAdGroupFeedRequestObject()
        {
            moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupFeedRequest request = new GetAdGroupFeedRequest
            {
                ResourceNameAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
            };
            gagvr::AdGroupFeed expectedResponse = new gagvr::AdGroupFeed
            {
                ResourceNameAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetAdGroupFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupFeed response = client.GetAdGroupFeed(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAdGroupFeedRequestObjectAsync()
        {
            moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupFeedRequest request = new GetAdGroupFeedRequest
            {
                ResourceNameAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
            };
            gagvr::AdGroupFeed expectedResponse = new gagvr::AdGroupFeed
            {
                ResourceNameAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetAdGroupFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupFeed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupFeed responseCallSettings = await client.GetAdGroupFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupFeed responseCancellationToken = await client.GetAdGroupFeedAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroupFeed()
        {
            moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupFeedRequest request = new GetAdGroupFeedRequest
            {
                ResourceNameAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
            };
            gagvr::AdGroupFeed expectedResponse = new gagvr::AdGroupFeed
            {
                ResourceNameAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetAdGroupFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupFeed response = client.GetAdGroupFeed(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAdGroupFeedAsync()
        {
            moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupFeedRequest request = new GetAdGroupFeedRequest
            {
                ResourceNameAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
            };
            gagvr::AdGroupFeed expectedResponse = new gagvr::AdGroupFeed
            {
                ResourceNameAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetAdGroupFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupFeed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupFeed responseCallSettings = await client.GetAdGroupFeedAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupFeed responseCancellationToken = await client.GetAdGroupFeedAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroupFeedResourceNames()
        {
            moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupFeedRequest request = new GetAdGroupFeedRequest
            {
                ResourceNameAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
            };
            gagvr::AdGroupFeed expectedResponse = new gagvr::AdGroupFeed
            {
                ResourceNameAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetAdGroupFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupFeed response = client.GetAdGroupFeed(request.ResourceNameAsAdGroupFeedName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetAdGroupFeedResourceNamesAsync()
        {
            moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupFeedRequest request = new GetAdGroupFeedRequest
            {
                ResourceNameAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
            };
            gagvr::AdGroupFeed expectedResponse = new gagvr::AdGroupFeed
            {
                ResourceNameAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetAdGroupFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupFeed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupFeed responseCallSettings = await client.GetAdGroupFeedAsync(request.ResourceNameAsAdGroupFeedName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupFeed responseCancellationToken = await client.GetAdGroupFeedAsync(request.ResourceNameAsAdGroupFeedName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupFeedsRequestObject()
        {
            moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupFeedsRequest request = new MutateAdGroupFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupFeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateAdGroupFeedsResponse expectedResponse = new MutateAdGroupFeedsResponse
            {
                Results =
                {
                    new MutateAdGroupFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupFeeds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupFeedsResponse response = client.MutateAdGroupFeeds(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateAdGroupFeedsRequestObjectAsync()
        {
            moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupFeedsRequest request = new MutateAdGroupFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupFeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateAdGroupFeedsResponse expectedResponse = new MutateAdGroupFeedsResponse
            {
                Results =
                {
                    new MutateAdGroupFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupFeedsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupFeedsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupFeedsResponse responseCallSettings = await client.MutateAdGroupFeedsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupFeedsResponse responseCancellationToken = await client.MutateAdGroupFeedsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupFeeds()
        {
            moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupFeedsRequest request = new MutateAdGroupFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupFeedOperation(),
                },
            };
            MutateAdGroupFeedsResponse expectedResponse = new MutateAdGroupFeedsResponse
            {
                Results =
                {
                    new MutateAdGroupFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupFeeds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupFeedsResponse response = client.MutateAdGroupFeeds(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateAdGroupFeedsAsync()
        {
            moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient> mockGrpcClient = new moq::Mock<AdGroupFeedService.AdGroupFeedServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupFeedsRequest request = new MutateAdGroupFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupFeedOperation(),
                },
            };
            MutateAdGroupFeedsResponse expectedResponse = new MutateAdGroupFeedsResponse
            {
                Results =
                {
                    new MutateAdGroupFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupFeedsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupFeedsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupFeedServiceClient client = new AdGroupFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupFeedsResponse responseCallSettings = await client.MutateAdGroupFeedsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupFeedsResponse responseCancellationToken = await client.MutateAdGroupFeedsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

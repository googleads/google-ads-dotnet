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

using gagvc = Google.Ads.GoogleAds.V5.Common;
using gagve = Google.Ads.GoogleAds.V5.Enums;
using gagvr = Google.Ads.GoogleAds.V5.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V5.Services;

namespace Google.Ads.GoogleAds.Tests.V5.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCampaignFeedServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCampaignFeedRequestObject()
        {
            moq::Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new moq::Mock<CampaignFeedService.CampaignFeedServiceClient>(moq::MockBehavior.Strict);
            GetCampaignFeedRequest request = new GetCampaignFeedRequest
            {
                ResourceNameAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
            };
            gagvr::CampaignFeed expectedResponse = new gagvr::CampaignFeed
            {
                ResourceNameAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetCampaignFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignFeed response = client.GetCampaignFeed(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignFeedRequestObjectAsync()
        {
            moq::Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new moq::Mock<CampaignFeedService.CampaignFeedServiceClient>(moq::MockBehavior.Strict);
            GetCampaignFeedRequest request = new GetCampaignFeedRequest
            {
                ResourceNameAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
            };
            gagvr::CampaignFeed expectedResponse = new gagvr::CampaignFeed
            {
                ResourceNameAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetCampaignFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignFeed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignFeed responseCallSettings = await client.GetCampaignFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignFeed responseCancellationToken = await client.GetCampaignFeedAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignFeed()
        {
            moq::Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new moq::Mock<CampaignFeedService.CampaignFeedServiceClient>(moq::MockBehavior.Strict);
            GetCampaignFeedRequest request = new GetCampaignFeedRequest
            {
                ResourceNameAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
            };
            gagvr::CampaignFeed expectedResponse = new gagvr::CampaignFeed
            {
                ResourceNameAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetCampaignFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignFeed response = client.GetCampaignFeed(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignFeedAsync()
        {
            moq::Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new moq::Mock<CampaignFeedService.CampaignFeedServiceClient>(moq::MockBehavior.Strict);
            GetCampaignFeedRequest request = new GetCampaignFeedRequest
            {
                ResourceNameAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
            };
            gagvr::CampaignFeed expectedResponse = new gagvr::CampaignFeed
            {
                ResourceNameAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetCampaignFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignFeed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignFeed responseCallSettings = await client.GetCampaignFeedAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignFeed responseCancellationToken = await client.GetCampaignFeedAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignFeedResourceNames()
        {
            moq::Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new moq::Mock<CampaignFeedService.CampaignFeedServiceClient>(moq::MockBehavior.Strict);
            GetCampaignFeedRequest request = new GetCampaignFeedRequest
            {
                ResourceNameAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
            };
            gagvr::CampaignFeed expectedResponse = new gagvr::CampaignFeed
            {
                ResourceNameAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetCampaignFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignFeed response = client.GetCampaignFeed(request.ResourceNameAsCampaignFeedName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignFeedResourceNamesAsync()
        {
            moq::Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new moq::Mock<CampaignFeedService.CampaignFeedServiceClient>(moq::MockBehavior.Strict);
            GetCampaignFeedRequest request = new GetCampaignFeedRequest
            {
                ResourceNameAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
            };
            gagvr::CampaignFeed expectedResponse = new gagvr::CampaignFeed
            {
                ResourceNameAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetCampaignFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignFeed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignFeed responseCallSettings = await client.GetCampaignFeedAsync(request.ResourceNameAsCampaignFeedName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignFeed responseCancellationToken = await client.GetCampaignFeedAsync(request.ResourceNameAsCampaignFeedName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignFeedsRequestObject()
        {
            moq::Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new moq::Mock<CampaignFeedService.CampaignFeedServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignFeedsRequest request = new MutateCampaignFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignFeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignFeedsResponse expectedResponse = new MutateCampaignFeedsResponse
            {
                Results =
                {
                    new MutateCampaignFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignFeeds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignFeedsResponse response = client.MutateCampaignFeeds(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignFeedsRequestObjectAsync()
        {
            moq::Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new moq::Mock<CampaignFeedService.CampaignFeedServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignFeedsRequest request = new MutateCampaignFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignFeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignFeedsResponse expectedResponse = new MutateCampaignFeedsResponse
            {
                Results =
                {
                    new MutateCampaignFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignFeedsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignFeedsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignFeedsResponse responseCallSettings = await client.MutateCampaignFeedsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignFeedsResponse responseCancellationToken = await client.MutateCampaignFeedsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignFeeds()
        {
            moq::Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new moq::Mock<CampaignFeedService.CampaignFeedServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignFeedsRequest request = new MutateCampaignFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignFeedOperation(),
                },
            };
            MutateCampaignFeedsResponse expectedResponse = new MutateCampaignFeedsResponse
            {
                Results =
                {
                    new MutateCampaignFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignFeeds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignFeedsResponse response = client.MutateCampaignFeeds(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignFeedsAsync()
        {
            moq::Mock<CampaignFeedService.CampaignFeedServiceClient> mockGrpcClient = new moq::Mock<CampaignFeedService.CampaignFeedServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignFeedsRequest request = new MutateCampaignFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignFeedOperation(),
                },
            };
            MutateCampaignFeedsResponse expectedResponse = new MutateCampaignFeedsResponse
            {
                Results =
                {
                    new MutateCampaignFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignFeedsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignFeedsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignFeedServiceClient client = new CampaignFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignFeedsResponse responseCallSettings = await client.MutateCampaignFeedsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignFeedsResponse responseCancellationToken = await client.MutateCampaignFeedsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

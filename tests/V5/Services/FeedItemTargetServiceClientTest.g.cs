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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V5.Services;

namespace Google.Ads.GoogleAds.Tests.V5.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFeedItemTargetServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetFeedItemTargetRequestObject()
        {
            moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemTargetRequest request = new GetFeedItemTargetRequest
            {
                ResourceNameAsFeedItemTargetName = gagvr::FeedItemTargetName.FromCustomerFeedItemTarget("[CUSTOMER]", "[FEED_ITEM_TARGET]"),
            };
            gagvr::FeedItemTarget expectedResponse = new gagvr::FeedItemTarget
            {
                ResourceNameAsFeedItemTargetName = gagvr::FeedItemTargetName.FromCustomerFeedItemTarget("[CUSTOMER]", "[FEED_ITEM_TARGET]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                FeedItemTargetType = gagve::FeedItemTargetTypeEnum.Types.FeedItemTargetType.Criterion,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                FeedItemTargetId = -5234855566520350663L,
                Keyword = new gagvc::KeywordInfo(),
                GeoTargetConstantAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                Device = gagve::FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice.Mobile,
                AdSchedule = new gagvc::AdScheduleInfo(),
                Status = gagve::FeedItemTargetStatusEnum.Types.FeedItemTargetStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedItemTarget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemTarget response = client.GetFeedItemTarget(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetFeedItemTargetRequestObjectAsync()
        {
            moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemTargetRequest request = new GetFeedItemTargetRequest
            {
                ResourceNameAsFeedItemTargetName = gagvr::FeedItemTargetName.FromCustomerFeedItemTarget("[CUSTOMER]", "[FEED_ITEM_TARGET]"),
            };
            gagvr::FeedItemTarget expectedResponse = new gagvr::FeedItemTarget
            {
                ResourceNameAsFeedItemTargetName = gagvr::FeedItemTargetName.FromCustomerFeedItemTarget("[CUSTOMER]", "[FEED_ITEM_TARGET]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                FeedItemTargetType = gagve::FeedItemTargetTypeEnum.Types.FeedItemTargetType.Criterion,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                FeedItemTargetId = -5234855566520350663L,
                Keyword = new gagvc::KeywordInfo(),
                GeoTargetConstantAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                Device = gagve::FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice.Mobile,
                AdSchedule = new gagvc::AdScheduleInfo(),
                Status = gagve::FeedItemTargetStatusEnum.Types.FeedItemTargetStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedItemTargetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedItemTarget>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemTarget responseCallSettings = await client.GetFeedItemTargetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedItemTarget responseCancellationToken = await client.GetFeedItemTargetAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetFeedItemTarget()
        {
            moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemTargetRequest request = new GetFeedItemTargetRequest
            {
                ResourceNameAsFeedItemTargetName = gagvr::FeedItemTargetName.FromCustomerFeedItemTarget("[CUSTOMER]", "[FEED_ITEM_TARGET]"),
            };
            gagvr::FeedItemTarget expectedResponse = new gagvr::FeedItemTarget
            {
                ResourceNameAsFeedItemTargetName = gagvr::FeedItemTargetName.FromCustomerFeedItemTarget("[CUSTOMER]", "[FEED_ITEM_TARGET]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                FeedItemTargetType = gagve::FeedItemTargetTypeEnum.Types.FeedItemTargetType.Criterion,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                FeedItemTargetId = -5234855566520350663L,
                Keyword = new gagvc::KeywordInfo(),
                GeoTargetConstantAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                Device = gagve::FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice.Mobile,
                AdSchedule = new gagvc::AdScheduleInfo(),
                Status = gagve::FeedItemTargetStatusEnum.Types.FeedItemTargetStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedItemTarget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemTarget response = client.GetFeedItemTarget(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetFeedItemTargetAsync()
        {
            moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemTargetRequest request = new GetFeedItemTargetRequest
            {
                ResourceNameAsFeedItemTargetName = gagvr::FeedItemTargetName.FromCustomerFeedItemTarget("[CUSTOMER]", "[FEED_ITEM_TARGET]"),
            };
            gagvr::FeedItemTarget expectedResponse = new gagvr::FeedItemTarget
            {
                ResourceNameAsFeedItemTargetName = gagvr::FeedItemTargetName.FromCustomerFeedItemTarget("[CUSTOMER]", "[FEED_ITEM_TARGET]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                FeedItemTargetType = gagve::FeedItemTargetTypeEnum.Types.FeedItemTargetType.Criterion,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                FeedItemTargetId = -5234855566520350663L,
                Keyword = new gagvc::KeywordInfo(),
                GeoTargetConstantAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                Device = gagve::FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice.Mobile,
                AdSchedule = new gagvc::AdScheduleInfo(),
                Status = gagve::FeedItemTargetStatusEnum.Types.FeedItemTargetStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedItemTargetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedItemTarget>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemTarget responseCallSettings = await client.GetFeedItemTargetAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedItemTarget responseCancellationToken = await client.GetFeedItemTargetAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetFeedItemTargetResourceNames()
        {
            moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemTargetRequest request = new GetFeedItemTargetRequest
            {
                ResourceNameAsFeedItemTargetName = gagvr::FeedItemTargetName.FromCustomerFeedItemTarget("[CUSTOMER]", "[FEED_ITEM_TARGET]"),
            };
            gagvr::FeedItemTarget expectedResponse = new gagvr::FeedItemTarget
            {
                ResourceNameAsFeedItemTargetName = gagvr::FeedItemTargetName.FromCustomerFeedItemTarget("[CUSTOMER]", "[FEED_ITEM_TARGET]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                FeedItemTargetType = gagve::FeedItemTargetTypeEnum.Types.FeedItemTargetType.Criterion,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                FeedItemTargetId = -5234855566520350663L,
                Keyword = new gagvc::KeywordInfo(),
                GeoTargetConstantAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                Device = gagve::FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice.Mobile,
                AdSchedule = new gagvc::AdScheduleInfo(),
                Status = gagve::FeedItemTargetStatusEnum.Types.FeedItemTargetStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedItemTarget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemTarget response = client.GetFeedItemTarget(request.ResourceNameAsFeedItemTargetName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetFeedItemTargetResourceNamesAsync()
        {
            moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemTargetRequest request = new GetFeedItemTargetRequest
            {
                ResourceNameAsFeedItemTargetName = gagvr::FeedItemTargetName.FromCustomerFeedItemTarget("[CUSTOMER]", "[FEED_ITEM_TARGET]"),
            };
            gagvr::FeedItemTarget expectedResponse = new gagvr::FeedItemTarget
            {
                ResourceNameAsFeedItemTargetName = gagvr::FeedItemTargetName.FromCustomerFeedItemTarget("[CUSTOMER]", "[FEED_ITEM_TARGET]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                FeedItemTargetType = gagve::FeedItemTargetTypeEnum.Types.FeedItemTargetType.Criterion,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                FeedItemTargetId = -5234855566520350663L,
                Keyword = new gagvc::KeywordInfo(),
                GeoTargetConstantAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                Device = gagve::FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice.Mobile,
                AdSchedule = new gagvc::AdScheduleInfo(),
                Status = gagve::FeedItemTargetStatusEnum.Types.FeedItemTargetStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedItemTargetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedItemTarget>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemTarget responseCallSettings = await client.GetFeedItemTargetAsync(request.ResourceNameAsFeedItemTargetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedItemTarget responseCancellationToken = await client.GetFeedItemTargetAsync(request.ResourceNameAsFeedItemTargetName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateFeedItemTargetsRequestObject()
        {
            moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemTargetsRequest request = new MutateFeedItemTargetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemTargetOperation(),
                },
            };
            MutateFeedItemTargetsResponse expectedResponse = new MutateFeedItemTargetsResponse
            {
                Results =
                {
                    new MutateFeedItemTargetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemTargets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemTargetsResponse response = client.MutateFeedItemTargets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateFeedItemTargetsRequestObjectAsync()
        {
            moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemTargetsRequest request = new MutateFeedItemTargetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemTargetOperation(),
                },
            };
            MutateFeedItemTargetsResponse expectedResponse = new MutateFeedItemTargetsResponse
            {
                Results =
                {
                    new MutateFeedItemTargetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemTargetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateFeedItemTargetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemTargetsResponse responseCallSettings = await client.MutateFeedItemTargetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateFeedItemTargetsResponse responseCancellationToken = await client.MutateFeedItemTargetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateFeedItemTargets()
        {
            moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemTargetsRequest request = new MutateFeedItemTargetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemTargetOperation(),
                },
            };
            MutateFeedItemTargetsResponse expectedResponse = new MutateFeedItemTargetsResponse
            {
                Results =
                {
                    new MutateFeedItemTargetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemTargets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemTargetsResponse response = client.MutateFeedItemTargets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateFeedItemTargetsAsync()
        {
            moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient> mockGrpcClient = new moq::Mock<FeedItemTargetService.FeedItemTargetServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemTargetsRequest request = new MutateFeedItemTargetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemTargetOperation(),
                },
            };
            MutateFeedItemTargetsResponse expectedResponse = new MutateFeedItemTargetsResponse
            {
                Results =
                {
                    new MutateFeedItemTargetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemTargetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateFeedItemTargetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemTargetServiceClient client = new FeedItemTargetServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemTargetsResponse responseCallSettings = await client.MutateFeedItemTargetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateFeedItemTargetsResponse responseCancellationToken = await client.MutateFeedItemTargetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

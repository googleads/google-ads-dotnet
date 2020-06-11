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

using gagve = Google.Ads.GoogleAds.V1.Enums;
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
    public sealed class GeneratedChangeStatusServiceClientTest
    {
        [Test]
        public void GetChangeStatusRequestObject()
        {
            moq::Mock<ChangeStatusService.ChangeStatusServiceClient> mockGrpcClient = new moq::Mock<ChangeStatusService.ChangeStatusServiceClient>(moq::MockBehavior.Strict);
            GetChangeStatusRequest request = new GetChangeStatusRequest
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER]", "[CHANGE_STATUS]"),
            };
            gagvr::ChangeStatus expectedResponse = new gagvr::ChangeStatus
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER]", "[CHANGE_STATUS]"),
                LastChangeDateTime = "last_change_date_time05524d04",
                ResourceType = gagve::ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Feed,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                ResourceStatus = gagve::ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER]", "[AD_GROUP_CRITERION]"),
                CampaignCriterionAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                AdGroupFeedAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
                CampaignFeedAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
                AdGroupBidModifierAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupBidModifier("[CUSTOMER]", "[AD_GROUP_BID_MODIFIER]"),
            };
            mockGrpcClient.Setup(x => x.GetChangeStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ChangeStatusServiceClient client = new ChangeStatusServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ChangeStatus response = client.GetChangeStatus(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetChangeStatusRequestObjectAsync()
        {
            moq::Mock<ChangeStatusService.ChangeStatusServiceClient> mockGrpcClient = new moq::Mock<ChangeStatusService.ChangeStatusServiceClient>(moq::MockBehavior.Strict);
            GetChangeStatusRequest request = new GetChangeStatusRequest
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER]", "[CHANGE_STATUS]"),
            };
            gagvr::ChangeStatus expectedResponse = new gagvr::ChangeStatus
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER]", "[CHANGE_STATUS]"),
                LastChangeDateTime = "last_change_date_time05524d04",
                ResourceType = gagve::ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Feed,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                ResourceStatus = gagve::ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER]", "[AD_GROUP_CRITERION]"),
                CampaignCriterionAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                AdGroupFeedAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
                CampaignFeedAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
                AdGroupBidModifierAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupBidModifier("[CUSTOMER]", "[AD_GROUP_BID_MODIFIER]"),
            };
            mockGrpcClient.Setup(x => x.GetChangeStatusAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ChangeStatus>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ChangeStatusServiceClient client = new ChangeStatusServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ChangeStatus responseCallSettings = await client.GetChangeStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ChangeStatus responseCancellationToken = await client.GetChangeStatusAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetChangeStatus()
        {
            moq::Mock<ChangeStatusService.ChangeStatusServiceClient> mockGrpcClient = new moq::Mock<ChangeStatusService.ChangeStatusServiceClient>(moq::MockBehavior.Strict);
            GetChangeStatusRequest request = new GetChangeStatusRequest
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER]", "[CHANGE_STATUS]"),
            };
            gagvr::ChangeStatus expectedResponse = new gagvr::ChangeStatus
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER]", "[CHANGE_STATUS]"),
                LastChangeDateTime = "last_change_date_time05524d04",
                ResourceType = gagve::ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Feed,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                ResourceStatus = gagve::ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER]", "[AD_GROUP_CRITERION]"),
                CampaignCriterionAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                AdGroupFeedAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
                CampaignFeedAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
                AdGroupBidModifierAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupBidModifier("[CUSTOMER]", "[AD_GROUP_BID_MODIFIER]"),
            };
            mockGrpcClient.Setup(x => x.GetChangeStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ChangeStatusServiceClient client = new ChangeStatusServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ChangeStatus response = client.GetChangeStatus(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetChangeStatusAsync()
        {
            moq::Mock<ChangeStatusService.ChangeStatusServiceClient> mockGrpcClient = new moq::Mock<ChangeStatusService.ChangeStatusServiceClient>(moq::MockBehavior.Strict);
            GetChangeStatusRequest request = new GetChangeStatusRequest
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER]", "[CHANGE_STATUS]"),
            };
            gagvr::ChangeStatus expectedResponse = new gagvr::ChangeStatus
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER]", "[CHANGE_STATUS]"),
                LastChangeDateTime = "last_change_date_time05524d04",
                ResourceType = gagve::ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Feed,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                ResourceStatus = gagve::ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER]", "[AD_GROUP_CRITERION]"),
                CampaignCriterionAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                AdGroupFeedAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
                CampaignFeedAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
                AdGroupBidModifierAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupBidModifier("[CUSTOMER]", "[AD_GROUP_BID_MODIFIER]"),
            };
            mockGrpcClient.Setup(x => x.GetChangeStatusAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ChangeStatus>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ChangeStatusServiceClient client = new ChangeStatusServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ChangeStatus responseCallSettings = await client.GetChangeStatusAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ChangeStatus responseCancellationToken = await client.GetChangeStatusAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetChangeStatusResourceNames()
        {
            moq::Mock<ChangeStatusService.ChangeStatusServiceClient> mockGrpcClient = new moq::Mock<ChangeStatusService.ChangeStatusServiceClient>(moq::MockBehavior.Strict);
            GetChangeStatusRequest request = new GetChangeStatusRequest
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER]", "[CHANGE_STATUS]"),
            };
            gagvr::ChangeStatus expectedResponse = new gagvr::ChangeStatus
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER]", "[CHANGE_STATUS]"),
                LastChangeDateTime = "last_change_date_time05524d04",
                ResourceType = gagve::ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Feed,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                ResourceStatus = gagve::ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER]", "[AD_GROUP_CRITERION]"),
                CampaignCriterionAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                AdGroupFeedAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
                CampaignFeedAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
                AdGroupBidModifierAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupBidModifier("[CUSTOMER]", "[AD_GROUP_BID_MODIFIER]"),
            };
            mockGrpcClient.Setup(x => x.GetChangeStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ChangeStatusServiceClient client = new ChangeStatusServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ChangeStatus response = client.GetChangeStatus(request.ResourceNameAsChangeStatusName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetChangeStatusResourceNamesAsync()
        {
            moq::Mock<ChangeStatusService.ChangeStatusServiceClient> mockGrpcClient = new moq::Mock<ChangeStatusService.ChangeStatusServiceClient>(moq::MockBehavior.Strict);
            GetChangeStatusRequest request = new GetChangeStatusRequest
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER]", "[CHANGE_STATUS]"),
            };
            gagvr::ChangeStatus expectedResponse = new gagvr::ChangeStatus
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER]", "[CHANGE_STATUS]"),
                LastChangeDateTime = "last_change_date_time05524d04",
                ResourceType = gagve::ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Feed,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                ResourceStatus = gagve::ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER]", "[AD_GROUP_CRITERION]"),
                CampaignCriterionAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedItem("[CUSTOMER]", "[FEED_ITEM]"),
                AdGroupFeedAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER]", "[AD_GROUP_FEED]"),
                CampaignFeedAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER]", "[CAMPAIGN_FEED]"),
                AdGroupBidModifierAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupBidModifier("[CUSTOMER]", "[AD_GROUP_BID_MODIFIER]"),
            };
            mockGrpcClient.Setup(x => x.GetChangeStatusAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ChangeStatus>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ChangeStatusServiceClient client = new ChangeStatusServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ChangeStatus responseCallSettings = await client.GetChangeStatusAsync(request.ResourceNameAsChangeStatusName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ChangeStatus responseCancellationToken = await client.GetChangeStatusAsync(request.ResourceNameAsChangeStatusName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

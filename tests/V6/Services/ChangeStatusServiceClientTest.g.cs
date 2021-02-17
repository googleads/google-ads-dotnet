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

using gagve = Google.Ads.GoogleAds.V6.Enums;
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
    public sealed class GeneratedChangeStatusServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetChangeStatusRequestObject()
        {
            moq::Mock<ChangeStatusService.ChangeStatusServiceClient> mockGrpcClient = new moq::Mock<ChangeStatusService.ChangeStatusServiceClient>(moq::MockBehavior.Strict);
            GetChangeStatusRequest request = new GetChangeStatusRequest
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER_ID]", "[CHANGE_STATUS_ID]"),
            };
            gagvr::ChangeStatus expectedResponse = new gagvr::ChangeStatus
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER_ID]", "[CHANGE_STATUS_ID]"),
                ResourceType = gagve::ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Feed,
                ResourceStatus = gagve::ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                LastChangeDateTime = "last_change_date_time05524d04",
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[AD_ID]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                CampaignCriterionAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_ID]"),
                AdGroupFeedAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[FEED_ID]"),
                CampaignFeedAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[FEED_ID]"),
                AdGroupBidModifierAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetChangeStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ChangeStatusServiceClient client = new ChangeStatusServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ChangeStatus response = client.GetChangeStatus(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetChangeStatusRequestObjectAsync()
        {
            moq::Mock<ChangeStatusService.ChangeStatusServiceClient> mockGrpcClient = new moq::Mock<ChangeStatusService.ChangeStatusServiceClient>(moq::MockBehavior.Strict);
            GetChangeStatusRequest request = new GetChangeStatusRequest
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER_ID]", "[CHANGE_STATUS_ID]"),
            };
            gagvr::ChangeStatus expectedResponse = new gagvr::ChangeStatus
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER_ID]", "[CHANGE_STATUS_ID]"),
                ResourceType = gagve::ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Feed,
                ResourceStatus = gagve::ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                LastChangeDateTime = "last_change_date_time05524d04",
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[AD_ID]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                CampaignCriterionAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_ID]"),
                AdGroupFeedAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[FEED_ID]"),
                CampaignFeedAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[FEED_ID]"),
                AdGroupBidModifierAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetChangeStatusAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ChangeStatus>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ChangeStatusServiceClient client = new ChangeStatusServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ChangeStatus responseCallSettings = await client.GetChangeStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ChangeStatus responseCancellationToken = await client.GetChangeStatusAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetChangeStatus()
        {
            moq::Mock<ChangeStatusService.ChangeStatusServiceClient> mockGrpcClient = new moq::Mock<ChangeStatusService.ChangeStatusServiceClient>(moq::MockBehavior.Strict);
            GetChangeStatusRequest request = new GetChangeStatusRequest
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER_ID]", "[CHANGE_STATUS_ID]"),
            };
            gagvr::ChangeStatus expectedResponse = new gagvr::ChangeStatus
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER_ID]", "[CHANGE_STATUS_ID]"),
                ResourceType = gagve::ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Feed,
                ResourceStatus = gagve::ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                LastChangeDateTime = "last_change_date_time05524d04",
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[AD_ID]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                CampaignCriterionAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_ID]"),
                AdGroupFeedAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[FEED_ID]"),
                CampaignFeedAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[FEED_ID]"),
                AdGroupBidModifierAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetChangeStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ChangeStatusServiceClient client = new ChangeStatusServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ChangeStatus response = client.GetChangeStatus(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetChangeStatusAsync()
        {
            moq::Mock<ChangeStatusService.ChangeStatusServiceClient> mockGrpcClient = new moq::Mock<ChangeStatusService.ChangeStatusServiceClient>(moq::MockBehavior.Strict);
            GetChangeStatusRequest request = new GetChangeStatusRequest
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER_ID]", "[CHANGE_STATUS_ID]"),
            };
            gagvr::ChangeStatus expectedResponse = new gagvr::ChangeStatus
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER_ID]", "[CHANGE_STATUS_ID]"),
                ResourceType = gagve::ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Feed,
                ResourceStatus = gagve::ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                LastChangeDateTime = "last_change_date_time05524d04",
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[AD_ID]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                CampaignCriterionAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_ID]"),
                AdGroupFeedAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[FEED_ID]"),
                CampaignFeedAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[FEED_ID]"),
                AdGroupBidModifierAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetChangeStatusAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ChangeStatus>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ChangeStatusServiceClient client = new ChangeStatusServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ChangeStatus responseCallSettings = await client.GetChangeStatusAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ChangeStatus responseCancellationToken = await client.GetChangeStatusAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetChangeStatusResourceNames()
        {
            moq::Mock<ChangeStatusService.ChangeStatusServiceClient> mockGrpcClient = new moq::Mock<ChangeStatusService.ChangeStatusServiceClient>(moq::MockBehavior.Strict);
            GetChangeStatusRequest request = new GetChangeStatusRequest
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER_ID]", "[CHANGE_STATUS_ID]"),
            };
            gagvr::ChangeStatus expectedResponse = new gagvr::ChangeStatus
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER_ID]", "[CHANGE_STATUS_ID]"),
                ResourceType = gagve::ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Feed,
                ResourceStatus = gagve::ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                LastChangeDateTime = "last_change_date_time05524d04",
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[AD_ID]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                CampaignCriterionAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_ID]"),
                AdGroupFeedAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[FEED_ID]"),
                CampaignFeedAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[FEED_ID]"),
                AdGroupBidModifierAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetChangeStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ChangeStatusServiceClient client = new ChangeStatusServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ChangeStatus response = client.GetChangeStatus(request.ResourceNameAsChangeStatusName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetChangeStatusResourceNamesAsync()
        {
            moq::Mock<ChangeStatusService.ChangeStatusServiceClient> mockGrpcClient = new moq::Mock<ChangeStatusService.ChangeStatusServiceClient>(moq::MockBehavior.Strict);
            GetChangeStatusRequest request = new GetChangeStatusRequest
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER_ID]", "[CHANGE_STATUS_ID]"),
            };
            gagvr::ChangeStatus expectedResponse = new gagvr::ChangeStatus
            {
                ResourceNameAsChangeStatusName = gagvr::ChangeStatusName.FromCustomerChangeStatus("[CUSTOMER_ID]", "[CHANGE_STATUS_ID]"),
                ResourceType = gagve::ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Feed,
                ResourceStatus = gagve::ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                LastChangeDateTime = "last_change_date_time05524d04",
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[AD_ID]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                CampaignCriterionAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[CRITERION_ID]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
                FeedItemAsFeedItemName = gagvr::FeedItemName.FromCustomerFeedFeedItem("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_ID]"),
                AdGroupFeedAsAdGroupFeedName = gagvr::AdGroupFeedName.FromCustomerAdGroupFeed("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[FEED_ID]"),
                CampaignFeedAsCampaignFeedName = gagvr::CampaignFeedName.FromCustomerCampaignFeed("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[FEED_ID]"),
                AdGroupBidModifierAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
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

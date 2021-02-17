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

using gagvc = Google.Ads.GoogleAds.V6.Common;
using gagve = Google.Ads.GoogleAds.V6.Enums;
using gagvr = Google.Ads.GoogleAds.V6.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V6.Services;

namespace Google.Ads.GoogleAds.Tests.V6.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedExtensionFeedItemServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetExtensionFeedItemRequestObject()
        {
            moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(moq::MockBehavior.Strict);
            GetExtensionFeedItemRequest request = new GetExtensionFeedItemRequest
            {
                ResourceNameAsExtensionFeedItemName = gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
            };
            gagvr::ExtensionFeedItem expectedResponse = new gagvr::ExtensionFeedItem
            {
                ResourceNameAsExtensionFeedItemName = gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                SitelinkFeedItem = new gagvc::SitelinkFeedItem(),
                StructuredSnippetFeedItem = new gagvc::StructuredSnippetFeedItem(),
                Status = gagve::FeedItemStatusEnum.Types.FeedItemStatus.Enabled,
                AppFeedItem = new gagvc::AppFeedItem(),
                CallFeedItem = new gagvc::CallFeedItem(),
                CalloutFeedItem = new gagvc::CalloutFeedItem(),
                TextMessageFeedItem = new gagvc::TextMessageFeedItem(),
                PriceFeedItem = new gagvc::PriceFeedItem(),
                PromotionFeedItem = new gagvc::PromotionFeedItem(),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                LocationFeedItem = new gagvc::LocationFeedItem(),
                AffiliateLocationFeedItem = new gagvc::AffiliateLocationFeedItem(),
                AdSchedules =
                {
                    new gagvc::AdScheduleInfo(),
                },
                Device = gagve::FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice.Mobile,
                TargetedKeyword = new gagvc::KeywordInfo(),
                HotelCalloutFeedItem = new gagvc::HotelCalloutFeedItem(),
                Id = -6774108720365892680L,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                TargetedCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                TargetedAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                TargetedGeoTargetConstantAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                ImageFeedItem = new gagvc::ImageFeedItem(),
            };
            mockGrpcClient.Setup(x => x.GetExtensionFeedItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ExtensionFeedItem response = client.GetExtensionFeedItem(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetExtensionFeedItemRequestObjectAsync()
        {
            moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(moq::MockBehavior.Strict);
            GetExtensionFeedItemRequest request = new GetExtensionFeedItemRequest
            {
                ResourceNameAsExtensionFeedItemName = gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
            };
            gagvr::ExtensionFeedItem expectedResponse = new gagvr::ExtensionFeedItem
            {
                ResourceNameAsExtensionFeedItemName = gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                SitelinkFeedItem = new gagvc::SitelinkFeedItem(),
                StructuredSnippetFeedItem = new gagvc::StructuredSnippetFeedItem(),
                Status = gagve::FeedItemStatusEnum.Types.FeedItemStatus.Enabled,
                AppFeedItem = new gagvc::AppFeedItem(),
                CallFeedItem = new gagvc::CallFeedItem(),
                CalloutFeedItem = new gagvc::CalloutFeedItem(),
                TextMessageFeedItem = new gagvc::TextMessageFeedItem(),
                PriceFeedItem = new gagvc::PriceFeedItem(),
                PromotionFeedItem = new gagvc::PromotionFeedItem(),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                LocationFeedItem = new gagvc::LocationFeedItem(),
                AffiliateLocationFeedItem = new gagvc::AffiliateLocationFeedItem(),
                AdSchedules =
                {
                    new gagvc::AdScheduleInfo(),
                },
                Device = gagve::FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice.Mobile,
                TargetedKeyword = new gagvc::KeywordInfo(),
                HotelCalloutFeedItem = new gagvc::HotelCalloutFeedItem(),
                Id = -6774108720365892680L,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                TargetedCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                TargetedAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                TargetedGeoTargetConstantAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                ImageFeedItem = new gagvc::ImageFeedItem(),
            };
            mockGrpcClient.Setup(x => x.GetExtensionFeedItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ExtensionFeedItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ExtensionFeedItem responseCallSettings = await client.GetExtensionFeedItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ExtensionFeedItem responseCancellationToken = await client.GetExtensionFeedItemAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetExtensionFeedItem()
        {
            moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(moq::MockBehavior.Strict);
            GetExtensionFeedItemRequest request = new GetExtensionFeedItemRequest
            {
                ResourceNameAsExtensionFeedItemName = gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
            };
            gagvr::ExtensionFeedItem expectedResponse = new gagvr::ExtensionFeedItem
            {
                ResourceNameAsExtensionFeedItemName = gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                SitelinkFeedItem = new gagvc::SitelinkFeedItem(),
                StructuredSnippetFeedItem = new gagvc::StructuredSnippetFeedItem(),
                Status = gagve::FeedItemStatusEnum.Types.FeedItemStatus.Enabled,
                AppFeedItem = new gagvc::AppFeedItem(),
                CallFeedItem = new gagvc::CallFeedItem(),
                CalloutFeedItem = new gagvc::CalloutFeedItem(),
                TextMessageFeedItem = new gagvc::TextMessageFeedItem(),
                PriceFeedItem = new gagvc::PriceFeedItem(),
                PromotionFeedItem = new gagvc::PromotionFeedItem(),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                LocationFeedItem = new gagvc::LocationFeedItem(),
                AffiliateLocationFeedItem = new gagvc::AffiliateLocationFeedItem(),
                AdSchedules =
                {
                    new gagvc::AdScheduleInfo(),
                },
                Device = gagve::FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice.Mobile,
                TargetedKeyword = new gagvc::KeywordInfo(),
                HotelCalloutFeedItem = new gagvc::HotelCalloutFeedItem(),
                Id = -6774108720365892680L,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                TargetedCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                TargetedAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                TargetedGeoTargetConstantAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                ImageFeedItem = new gagvc::ImageFeedItem(),
            };
            mockGrpcClient.Setup(x => x.GetExtensionFeedItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ExtensionFeedItem response = client.GetExtensionFeedItem(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetExtensionFeedItemAsync()
        {
            moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(moq::MockBehavior.Strict);
            GetExtensionFeedItemRequest request = new GetExtensionFeedItemRequest
            {
                ResourceNameAsExtensionFeedItemName = gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
            };
            gagvr::ExtensionFeedItem expectedResponse = new gagvr::ExtensionFeedItem
            {
                ResourceNameAsExtensionFeedItemName = gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                SitelinkFeedItem = new gagvc::SitelinkFeedItem(),
                StructuredSnippetFeedItem = new gagvc::StructuredSnippetFeedItem(),
                Status = gagve::FeedItemStatusEnum.Types.FeedItemStatus.Enabled,
                AppFeedItem = new gagvc::AppFeedItem(),
                CallFeedItem = new gagvc::CallFeedItem(),
                CalloutFeedItem = new gagvc::CalloutFeedItem(),
                TextMessageFeedItem = new gagvc::TextMessageFeedItem(),
                PriceFeedItem = new gagvc::PriceFeedItem(),
                PromotionFeedItem = new gagvc::PromotionFeedItem(),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                LocationFeedItem = new gagvc::LocationFeedItem(),
                AffiliateLocationFeedItem = new gagvc::AffiliateLocationFeedItem(),
                AdSchedules =
                {
                    new gagvc::AdScheduleInfo(),
                },
                Device = gagve::FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice.Mobile,
                TargetedKeyword = new gagvc::KeywordInfo(),
                HotelCalloutFeedItem = new gagvc::HotelCalloutFeedItem(),
                Id = -6774108720365892680L,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                TargetedCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                TargetedAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                TargetedGeoTargetConstantAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                ImageFeedItem = new gagvc::ImageFeedItem(),
            };
            mockGrpcClient.Setup(x => x.GetExtensionFeedItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ExtensionFeedItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ExtensionFeedItem responseCallSettings = await client.GetExtensionFeedItemAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ExtensionFeedItem responseCancellationToken = await client.GetExtensionFeedItemAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetExtensionFeedItemResourceNames()
        {
            moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(moq::MockBehavior.Strict);
            GetExtensionFeedItemRequest request = new GetExtensionFeedItemRequest
            {
                ResourceNameAsExtensionFeedItemName = gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
            };
            gagvr::ExtensionFeedItem expectedResponse = new gagvr::ExtensionFeedItem
            {
                ResourceNameAsExtensionFeedItemName = gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                SitelinkFeedItem = new gagvc::SitelinkFeedItem(),
                StructuredSnippetFeedItem = new gagvc::StructuredSnippetFeedItem(),
                Status = gagve::FeedItemStatusEnum.Types.FeedItemStatus.Enabled,
                AppFeedItem = new gagvc::AppFeedItem(),
                CallFeedItem = new gagvc::CallFeedItem(),
                CalloutFeedItem = new gagvc::CalloutFeedItem(),
                TextMessageFeedItem = new gagvc::TextMessageFeedItem(),
                PriceFeedItem = new gagvc::PriceFeedItem(),
                PromotionFeedItem = new gagvc::PromotionFeedItem(),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                LocationFeedItem = new gagvc::LocationFeedItem(),
                AffiliateLocationFeedItem = new gagvc::AffiliateLocationFeedItem(),
                AdSchedules =
                {
                    new gagvc::AdScheduleInfo(),
                },
                Device = gagve::FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice.Mobile,
                TargetedKeyword = new gagvc::KeywordInfo(),
                HotelCalloutFeedItem = new gagvc::HotelCalloutFeedItem(),
                Id = -6774108720365892680L,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                TargetedCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                TargetedAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                TargetedGeoTargetConstantAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                ImageFeedItem = new gagvc::ImageFeedItem(),
            };
            mockGrpcClient.Setup(x => x.GetExtensionFeedItem(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ExtensionFeedItem response = client.GetExtensionFeedItem(request.ResourceNameAsExtensionFeedItemName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetExtensionFeedItemResourceNamesAsync()
        {
            moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(moq::MockBehavior.Strict);
            GetExtensionFeedItemRequest request = new GetExtensionFeedItemRequest
            {
                ResourceNameAsExtensionFeedItemName = gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
            };
            gagvr::ExtensionFeedItem expectedResponse = new gagvr::ExtensionFeedItem
            {
                ResourceNameAsExtensionFeedItemName = gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                SitelinkFeedItem = new gagvc::SitelinkFeedItem(),
                StructuredSnippetFeedItem = new gagvc::StructuredSnippetFeedItem(),
                Status = gagve::FeedItemStatusEnum.Types.FeedItemStatus.Enabled,
                AppFeedItem = new gagvc::AppFeedItem(),
                CallFeedItem = new gagvc::CallFeedItem(),
                CalloutFeedItem = new gagvc::CalloutFeedItem(),
                TextMessageFeedItem = new gagvc::TextMessageFeedItem(),
                PriceFeedItem = new gagvc::PriceFeedItem(),
                PromotionFeedItem = new gagvc::PromotionFeedItem(),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                LocationFeedItem = new gagvc::LocationFeedItem(),
                AffiliateLocationFeedItem = new gagvc::AffiliateLocationFeedItem(),
                AdSchedules =
                {
                    new gagvc::AdScheduleInfo(),
                },
                Device = gagve::FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice.Mobile,
                TargetedKeyword = new gagvc::KeywordInfo(),
                HotelCalloutFeedItem = new gagvc::HotelCalloutFeedItem(),
                Id = -6774108720365892680L,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                TargetedCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                TargetedAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                TargetedGeoTargetConstantAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromCriterion("[CRITERION_ID]"),
                ImageFeedItem = new gagvc::ImageFeedItem(),
            };
            mockGrpcClient.Setup(x => x.GetExtensionFeedItemAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ExtensionFeedItem>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ExtensionFeedItem responseCallSettings = await client.GetExtensionFeedItemAsync(request.ResourceNameAsExtensionFeedItemName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ExtensionFeedItem responseCancellationToken = await client.GetExtensionFeedItemAsync(request.ResourceNameAsExtensionFeedItemName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateExtensionFeedItemsRequestObject()
        {
            moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(moq::MockBehavior.Strict);
            MutateExtensionFeedItemsRequest request = new MutateExtensionFeedItemsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ExtensionFeedItemOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateExtensionFeedItemsResponse expectedResponse = new MutateExtensionFeedItemsResponse
            {
                Results =
                {
                    new MutateExtensionFeedItemResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateExtensionFeedItems(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            MutateExtensionFeedItemsResponse response = client.MutateExtensionFeedItems(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateExtensionFeedItemsRequestObjectAsync()
        {
            moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(moq::MockBehavior.Strict);
            MutateExtensionFeedItemsRequest request = new MutateExtensionFeedItemsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ExtensionFeedItemOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateExtensionFeedItemsResponse expectedResponse = new MutateExtensionFeedItemsResponse
            {
                Results =
                {
                    new MutateExtensionFeedItemResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateExtensionFeedItemsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateExtensionFeedItemsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            MutateExtensionFeedItemsResponse responseCallSettings = await client.MutateExtensionFeedItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateExtensionFeedItemsResponse responseCancellationToken = await client.MutateExtensionFeedItemsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateExtensionFeedItems()
        {
            moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(moq::MockBehavior.Strict);
            MutateExtensionFeedItemsRequest request = new MutateExtensionFeedItemsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ExtensionFeedItemOperation(),
                },
            };
            MutateExtensionFeedItemsResponse expectedResponse = new MutateExtensionFeedItemsResponse
            {
                Results =
                {
                    new MutateExtensionFeedItemResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateExtensionFeedItems(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            MutateExtensionFeedItemsResponse response = client.MutateExtensionFeedItems(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateExtensionFeedItemsAsync()
        {
            moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient> mockGrpcClient = new moq::Mock<ExtensionFeedItemService.ExtensionFeedItemServiceClient>(moq::MockBehavior.Strict);
            MutateExtensionFeedItemsRequest request = new MutateExtensionFeedItemsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new ExtensionFeedItemOperation(),
                },
            };
            MutateExtensionFeedItemsResponse expectedResponse = new MutateExtensionFeedItemsResponse
            {
                Results =
                {
                    new MutateExtensionFeedItemResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateExtensionFeedItemsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateExtensionFeedItemsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ExtensionFeedItemServiceClient client = new ExtensionFeedItemServiceClientImpl(mockGrpcClient.Object, null);
            MutateExtensionFeedItemsResponse responseCallSettings = await client.MutateExtensionFeedItemsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateExtensionFeedItemsResponse responseCancellationToken = await client.MutateExtensionFeedItemsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

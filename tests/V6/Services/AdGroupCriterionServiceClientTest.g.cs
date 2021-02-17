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
    public sealed class GeneratedAdGroupCriterionServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAdGroupCriterionRequestObject()
        {
            moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionRequest request = new GetAdGroupCriterionRequest
            {
                ResourceNameAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdGroupCriterion expectedResponse = new gagvr::AdGroupCriterion
            {
                ResourceNameAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                Status = gagve::AdGroupCriterionStatusEnum.Types.AdGroupCriterionStatus.Removed,
                QualityInfo = new gagvr::AdGroupCriterion.Types.QualityInfo(),
                PositionEstimates = new gagvr::AdGroupCriterion.Types.PositionEstimates(),
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                EffectiveCpcBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroup,
                EffectiveCpmBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                EffectiveCpvBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unspecified,
                Type = gagve::CriterionTypeEnum.Types.CriterionType.MobileApplication,
                Keyword = new gagvc::KeywordInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                ListingGroup = new gagvc::ListingGroupInfo(),
                EffectivePercentCpcBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroup,
                AgeRange = new gagvc::AgeRangeInfo(),
                Gender = new gagvc::GenderInfo(),
                IncomeRange = new gagvc::IncomeRangeInfo(),
                ParentalStatus = new gagvc::ParentalStatusInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                UserList = new gagvc::UserListInfo(),
                Topic = new gagvc::TopicInfo(),
                UserInterest = new gagvc::UserInterestInfo(),
                Webpage = new gagvc::WebpageInfo(),
                AppPaymentModel = new gagvc::AppPaymentModelInfo(),
                CustomAffinity = new gagvc::CustomAffinityInfo(),
                CustomIntent = new gagvc::CustomIntentInfo(),
                SystemServingStatus = gagve::CriterionSystemServingStatusEnum.Types.CriterionSystemServingStatus.Unknown,
                ApprovalStatus = gagve::AdGroupCriterionApprovalStatusEnum.Types.AdGroupCriterionApprovalStatus.Approved,
                CriterionId = 8584655242409302840L,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Negative = false,
                DisapprovalReasons =
                {
                    "disapproval_reasons9e26b1a0",
                },
                BidModifier = 1.6595195068951933E+17,
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                CpvBidMicros = 3393527949878021854L,
                PercentCpcBidMicros = 3342096754779167220L,
                EffectiveCpcBidMicros = -8231435192357073166L,
                EffectiveCpmBidMicros = -8933191455000353270L,
                EffectiveCpvBidMicros = 3707485164400289602L,
                EffectivePercentCpcBidMicros = 8313662352690151473L,
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                FinalUrlSuffix = "final_url_suffix046ed37a",
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CustomAudience = new gagvc::CustomAudienceInfo(),
                CombinedAudience = new gagvc::CombinedAudienceInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterion response = client.GetAdGroupCriterion(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupCriterionRequestObjectAsync()
        {
            moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionRequest request = new GetAdGroupCriterionRequest
            {
                ResourceNameAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdGroupCriterion expectedResponse = new gagvr::AdGroupCriterion
            {
                ResourceNameAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                Status = gagve::AdGroupCriterionStatusEnum.Types.AdGroupCriterionStatus.Removed,
                QualityInfo = new gagvr::AdGroupCriterion.Types.QualityInfo(),
                PositionEstimates = new gagvr::AdGroupCriterion.Types.PositionEstimates(),
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                EffectiveCpcBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroup,
                EffectiveCpmBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                EffectiveCpvBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unspecified,
                Type = gagve::CriterionTypeEnum.Types.CriterionType.MobileApplication,
                Keyword = new gagvc::KeywordInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                ListingGroup = new gagvc::ListingGroupInfo(),
                EffectivePercentCpcBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroup,
                AgeRange = new gagvc::AgeRangeInfo(),
                Gender = new gagvc::GenderInfo(),
                IncomeRange = new gagvc::IncomeRangeInfo(),
                ParentalStatus = new gagvc::ParentalStatusInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                UserList = new gagvc::UserListInfo(),
                Topic = new gagvc::TopicInfo(),
                UserInterest = new gagvc::UserInterestInfo(),
                Webpage = new gagvc::WebpageInfo(),
                AppPaymentModel = new gagvc::AppPaymentModelInfo(),
                CustomAffinity = new gagvc::CustomAffinityInfo(),
                CustomIntent = new gagvc::CustomIntentInfo(),
                SystemServingStatus = gagve::CriterionSystemServingStatusEnum.Types.CriterionSystemServingStatus.Unknown,
                ApprovalStatus = gagve::AdGroupCriterionApprovalStatusEnum.Types.AdGroupCriterionApprovalStatus.Approved,
                CriterionId = 8584655242409302840L,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Negative = false,
                DisapprovalReasons =
                {
                    "disapproval_reasons9e26b1a0",
                },
                BidModifier = 1.6595195068951933E+17,
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                CpvBidMicros = 3393527949878021854L,
                PercentCpcBidMicros = 3342096754779167220L,
                EffectiveCpcBidMicros = -8231435192357073166L,
                EffectiveCpmBidMicros = -8933191455000353270L,
                EffectiveCpvBidMicros = 3707485164400289602L,
                EffectivePercentCpcBidMicros = 8313662352690151473L,
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                FinalUrlSuffix = "final_url_suffix046ed37a",
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CustomAudience = new gagvc::CustomAudienceInfo(),
                CombinedAudience = new gagvc::CombinedAudienceInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupCriterion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterion responseCallSettings = await client.GetAdGroupCriterionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupCriterion responseCancellationToken = await client.GetAdGroupCriterionAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupCriterion()
        {
            moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionRequest request = new GetAdGroupCriterionRequest
            {
                ResourceNameAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdGroupCriterion expectedResponse = new gagvr::AdGroupCriterion
            {
                ResourceNameAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                Status = gagve::AdGroupCriterionStatusEnum.Types.AdGroupCriterionStatus.Removed,
                QualityInfo = new gagvr::AdGroupCriterion.Types.QualityInfo(),
                PositionEstimates = new gagvr::AdGroupCriterion.Types.PositionEstimates(),
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                EffectiveCpcBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroup,
                EffectiveCpmBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                EffectiveCpvBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unspecified,
                Type = gagve::CriterionTypeEnum.Types.CriterionType.MobileApplication,
                Keyword = new gagvc::KeywordInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                ListingGroup = new gagvc::ListingGroupInfo(),
                EffectivePercentCpcBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroup,
                AgeRange = new gagvc::AgeRangeInfo(),
                Gender = new gagvc::GenderInfo(),
                IncomeRange = new gagvc::IncomeRangeInfo(),
                ParentalStatus = new gagvc::ParentalStatusInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                UserList = new gagvc::UserListInfo(),
                Topic = new gagvc::TopicInfo(),
                UserInterest = new gagvc::UserInterestInfo(),
                Webpage = new gagvc::WebpageInfo(),
                AppPaymentModel = new gagvc::AppPaymentModelInfo(),
                CustomAffinity = new gagvc::CustomAffinityInfo(),
                CustomIntent = new gagvc::CustomIntentInfo(),
                SystemServingStatus = gagve::CriterionSystemServingStatusEnum.Types.CriterionSystemServingStatus.Unknown,
                ApprovalStatus = gagve::AdGroupCriterionApprovalStatusEnum.Types.AdGroupCriterionApprovalStatus.Approved,
                CriterionId = 8584655242409302840L,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Negative = false,
                DisapprovalReasons =
                {
                    "disapproval_reasons9e26b1a0",
                },
                BidModifier = 1.6595195068951933E+17,
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                CpvBidMicros = 3393527949878021854L,
                PercentCpcBidMicros = 3342096754779167220L,
                EffectiveCpcBidMicros = -8231435192357073166L,
                EffectiveCpmBidMicros = -8933191455000353270L,
                EffectiveCpvBidMicros = 3707485164400289602L,
                EffectivePercentCpcBidMicros = 8313662352690151473L,
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                FinalUrlSuffix = "final_url_suffix046ed37a",
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CustomAudience = new gagvc::CustomAudienceInfo(),
                CombinedAudience = new gagvc::CombinedAudienceInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterion response = client.GetAdGroupCriterion(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupCriterionAsync()
        {
            moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionRequest request = new GetAdGroupCriterionRequest
            {
                ResourceNameAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdGroupCriterion expectedResponse = new gagvr::AdGroupCriterion
            {
                ResourceNameAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                Status = gagve::AdGroupCriterionStatusEnum.Types.AdGroupCriterionStatus.Removed,
                QualityInfo = new gagvr::AdGroupCriterion.Types.QualityInfo(),
                PositionEstimates = new gagvr::AdGroupCriterion.Types.PositionEstimates(),
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                EffectiveCpcBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroup,
                EffectiveCpmBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                EffectiveCpvBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unspecified,
                Type = gagve::CriterionTypeEnum.Types.CriterionType.MobileApplication,
                Keyword = new gagvc::KeywordInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                ListingGroup = new gagvc::ListingGroupInfo(),
                EffectivePercentCpcBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroup,
                AgeRange = new gagvc::AgeRangeInfo(),
                Gender = new gagvc::GenderInfo(),
                IncomeRange = new gagvc::IncomeRangeInfo(),
                ParentalStatus = new gagvc::ParentalStatusInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                UserList = new gagvc::UserListInfo(),
                Topic = new gagvc::TopicInfo(),
                UserInterest = new gagvc::UserInterestInfo(),
                Webpage = new gagvc::WebpageInfo(),
                AppPaymentModel = new gagvc::AppPaymentModelInfo(),
                CustomAffinity = new gagvc::CustomAffinityInfo(),
                CustomIntent = new gagvc::CustomIntentInfo(),
                SystemServingStatus = gagve::CriterionSystemServingStatusEnum.Types.CriterionSystemServingStatus.Unknown,
                ApprovalStatus = gagve::AdGroupCriterionApprovalStatusEnum.Types.AdGroupCriterionApprovalStatus.Approved,
                CriterionId = 8584655242409302840L,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Negative = false,
                DisapprovalReasons =
                {
                    "disapproval_reasons9e26b1a0",
                },
                BidModifier = 1.6595195068951933E+17,
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                CpvBidMicros = 3393527949878021854L,
                PercentCpcBidMicros = 3342096754779167220L,
                EffectiveCpcBidMicros = -8231435192357073166L,
                EffectiveCpmBidMicros = -8933191455000353270L,
                EffectiveCpvBidMicros = 3707485164400289602L,
                EffectivePercentCpcBidMicros = 8313662352690151473L,
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                FinalUrlSuffix = "final_url_suffix046ed37a",
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CustomAudience = new gagvc::CustomAudienceInfo(),
                CombinedAudience = new gagvc::CombinedAudienceInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupCriterion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterion responseCallSettings = await client.GetAdGroupCriterionAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupCriterion responseCancellationToken = await client.GetAdGroupCriterionAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupCriterionResourceNames()
        {
            moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionRequest request = new GetAdGroupCriterionRequest
            {
                ResourceNameAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdGroupCriterion expectedResponse = new gagvr::AdGroupCriterion
            {
                ResourceNameAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                Status = gagve::AdGroupCriterionStatusEnum.Types.AdGroupCriterionStatus.Removed,
                QualityInfo = new gagvr::AdGroupCriterion.Types.QualityInfo(),
                PositionEstimates = new gagvr::AdGroupCriterion.Types.PositionEstimates(),
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                EffectiveCpcBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroup,
                EffectiveCpmBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                EffectiveCpvBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unspecified,
                Type = gagve::CriterionTypeEnum.Types.CriterionType.MobileApplication,
                Keyword = new gagvc::KeywordInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                ListingGroup = new gagvc::ListingGroupInfo(),
                EffectivePercentCpcBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroup,
                AgeRange = new gagvc::AgeRangeInfo(),
                Gender = new gagvc::GenderInfo(),
                IncomeRange = new gagvc::IncomeRangeInfo(),
                ParentalStatus = new gagvc::ParentalStatusInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                UserList = new gagvc::UserListInfo(),
                Topic = new gagvc::TopicInfo(),
                UserInterest = new gagvc::UserInterestInfo(),
                Webpage = new gagvc::WebpageInfo(),
                AppPaymentModel = new gagvc::AppPaymentModelInfo(),
                CustomAffinity = new gagvc::CustomAffinityInfo(),
                CustomIntent = new gagvc::CustomIntentInfo(),
                SystemServingStatus = gagve::CriterionSystemServingStatusEnum.Types.CriterionSystemServingStatus.Unknown,
                ApprovalStatus = gagve::AdGroupCriterionApprovalStatusEnum.Types.AdGroupCriterionApprovalStatus.Approved,
                CriterionId = 8584655242409302840L,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Negative = false,
                DisapprovalReasons =
                {
                    "disapproval_reasons9e26b1a0",
                },
                BidModifier = 1.6595195068951933E+17,
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                CpvBidMicros = 3393527949878021854L,
                PercentCpcBidMicros = 3342096754779167220L,
                EffectiveCpcBidMicros = -8231435192357073166L,
                EffectiveCpmBidMicros = -8933191455000353270L,
                EffectiveCpvBidMicros = 3707485164400289602L,
                EffectivePercentCpcBidMicros = 8313662352690151473L,
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                FinalUrlSuffix = "final_url_suffix046ed37a",
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CustomAudience = new gagvc::CustomAudienceInfo(),
                CombinedAudience = new gagvc::CombinedAudienceInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterion response = client.GetAdGroupCriterion(request.ResourceNameAsAdGroupCriterionName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupCriterionResourceNamesAsync()
        {
            moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionRequest request = new GetAdGroupCriterionRequest
            {
                ResourceNameAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdGroupCriterion expectedResponse = new gagvr::AdGroupCriterion
            {
                ResourceNameAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                Status = gagve::AdGroupCriterionStatusEnum.Types.AdGroupCriterionStatus.Removed,
                QualityInfo = new gagvr::AdGroupCriterion.Types.QualityInfo(),
                PositionEstimates = new gagvr::AdGroupCriterion.Types.PositionEstimates(),
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                EffectiveCpcBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroup,
                EffectiveCpmBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                EffectiveCpvBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unspecified,
                Type = gagve::CriterionTypeEnum.Types.CriterionType.MobileApplication,
                Keyword = new gagvc::KeywordInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                ListingGroup = new gagvc::ListingGroupInfo(),
                EffectivePercentCpcBidSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroup,
                AgeRange = new gagvc::AgeRangeInfo(),
                Gender = new gagvc::GenderInfo(),
                IncomeRange = new gagvc::IncomeRangeInfo(),
                ParentalStatus = new gagvc::ParentalStatusInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                UserList = new gagvc::UserListInfo(),
                Topic = new gagvc::TopicInfo(),
                UserInterest = new gagvc::UserInterestInfo(),
                Webpage = new gagvc::WebpageInfo(),
                AppPaymentModel = new gagvc::AppPaymentModelInfo(),
                CustomAffinity = new gagvc::CustomAffinityInfo(),
                CustomIntent = new gagvc::CustomIntentInfo(),
                SystemServingStatus = gagve::CriterionSystemServingStatusEnum.Types.CriterionSystemServingStatus.Unknown,
                ApprovalStatus = gagve::AdGroupCriterionApprovalStatusEnum.Types.AdGroupCriterionApprovalStatus.Approved,
                CriterionId = 8584655242409302840L,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Negative = false,
                DisapprovalReasons =
                {
                    "disapproval_reasons9e26b1a0",
                },
                BidModifier = 1.6595195068951933E+17,
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                CpvBidMicros = 3393527949878021854L,
                PercentCpcBidMicros = 3342096754779167220L,
                EffectiveCpcBidMicros = -8231435192357073166L,
                EffectiveCpmBidMicros = -8933191455000353270L,
                EffectiveCpvBidMicros = 3707485164400289602L,
                EffectivePercentCpcBidMicros = 8313662352690151473L,
                FinalUrls =
                {
                    "final_urls3ed0b71b",
                },
                FinalMobileUrls =
                {
                    "final_mobile_urlsf4131aa0",
                },
                FinalUrlSuffix = "final_url_suffix046ed37a",
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CustomAudience = new gagvc::CustomAudienceInfo(),
                CombinedAudience = new gagvc::CombinedAudienceInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupCriterion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterion responseCallSettings = await client.GetAdGroupCriterionAsync(request.ResourceNameAsAdGroupCriterionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupCriterion responseCancellationToken = await client.GetAdGroupCriterionAsync(request.ResourceNameAsAdGroupCriterionName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupCriteriaRequestObject()
        {
            moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriteriaRequest request = new MutateAdGroupCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupCriteriaResponse expectedResponse = new MutateAdGroupCriteriaResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriteria(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriteriaResponse response = client.MutateAdGroupCriteria(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupCriteriaRequestObjectAsync()
        {
            moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriteriaRequest request = new MutateAdGroupCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupCriteriaResponse expectedResponse = new MutateAdGroupCriteriaResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriteriaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupCriteriaResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriteriaResponse responseCallSettings = await client.MutateAdGroupCriteriaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupCriteriaResponse responseCancellationToken = await client.MutateAdGroupCriteriaAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupCriteria()
        {
            moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriteriaRequest request = new MutateAdGroupCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionOperation(),
                },
            };
            MutateAdGroupCriteriaResponse expectedResponse = new MutateAdGroupCriteriaResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriteria(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriteriaResponse response = client.MutateAdGroupCriteria(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupCriteriaAsync()
        {
            moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriteriaRequest request = new MutateAdGroupCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionOperation(),
                },
            };
            MutateAdGroupCriteriaResponse expectedResponse = new MutateAdGroupCriteriaResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriteriaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupCriteriaResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriteriaResponse responseCallSettings = await client.MutateAdGroupCriteriaAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupCriteriaResponse responseCancellationToken = await client.MutateAdGroupCriteriaAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

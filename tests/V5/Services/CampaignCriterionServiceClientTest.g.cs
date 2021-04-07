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
    public sealed class GeneratedCampaignCriterionServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCampaignCriterionRequestObject()
        {
            moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient>(moq::MockBehavior.Strict);
            GetCampaignCriterionRequest request = new GetCampaignCriterionRequest
            {
                ResourceNameAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
            };
            gagvr::CampaignCriterion expectedResponse = new gagvr::CampaignCriterion
            {
                ResourceNameAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.Location,
                Keyword = new gagvc::KeywordInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                Location = new gagvc::LocationInfo(),
                Device = new gagvc::DeviceInfo(),
                AdSchedule = new gagvc::AdScheduleInfo(),
                AgeRange = new gagvc::AgeRangeInfo(),
                Gender = new gagvc::GenderInfo(),
                IncomeRange = new gagvc::IncomeRangeInfo(),
                ParentalStatus = new gagvc::ParentalStatusInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                UserList = new gagvc::UserListInfo(),
                Proximity = new gagvc::ProximityInfo(),
                Topic = new gagvc::TopicInfo(),
                ListingScope = new gagvc::ListingScopeInfo(),
                Language = new gagvc::LanguageInfo(),
                IpBlock = new gagvc::IpBlockInfo(),
                ContentLabel = new gagvc::ContentLabelInfo(),
                Carrier = new gagvc::CarrierInfo(),
                UserInterest = new gagvc::UserInterestInfo(),
                Webpage = new gagvc::WebpageInfo(),
                OperatingSystemVersion = new gagvc::OperatingSystemVersionInfo(),
                MobileDevice = new gagvc::MobileDeviceInfo(),
                LocationGroup = new gagvc::LocationGroupInfo(),
                Status = gagve::CampaignCriterionStatusEnum.Types.CampaignCriterionStatus.Removed,
                CustomAffinity = new gagvc::CustomAffinityInfo(),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195E+17F,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignCriterion response = client.GetCampaignCriterion(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignCriterionRequestObjectAsync()
        {
            moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient>(moq::MockBehavior.Strict);
            GetCampaignCriterionRequest request = new GetCampaignCriterionRequest
            {
                ResourceNameAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
            };
            gagvr::CampaignCriterion expectedResponse = new gagvr::CampaignCriterion
            {
                ResourceNameAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.Location,
                Keyword = new gagvc::KeywordInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                Location = new gagvc::LocationInfo(),
                Device = new gagvc::DeviceInfo(),
                AdSchedule = new gagvc::AdScheduleInfo(),
                AgeRange = new gagvc::AgeRangeInfo(),
                Gender = new gagvc::GenderInfo(),
                IncomeRange = new gagvc::IncomeRangeInfo(),
                ParentalStatus = new gagvc::ParentalStatusInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                UserList = new gagvc::UserListInfo(),
                Proximity = new gagvc::ProximityInfo(),
                Topic = new gagvc::TopicInfo(),
                ListingScope = new gagvc::ListingScopeInfo(),
                Language = new gagvc::LanguageInfo(),
                IpBlock = new gagvc::IpBlockInfo(),
                ContentLabel = new gagvc::ContentLabelInfo(),
                Carrier = new gagvc::CarrierInfo(),
                UserInterest = new gagvc::UserInterestInfo(),
                Webpage = new gagvc::WebpageInfo(),
                OperatingSystemVersion = new gagvc::OperatingSystemVersionInfo(),
                MobileDevice = new gagvc::MobileDeviceInfo(),
                LocationGroup = new gagvc::LocationGroupInfo(),
                Status = gagve::CampaignCriterionStatusEnum.Types.CampaignCriterionStatus.Removed,
                CustomAffinity = new gagvc::CustomAffinityInfo(),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195E+17F,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignCriterion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignCriterion responseCallSettings = await client.GetCampaignCriterionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignCriterion responseCancellationToken = await client.GetCampaignCriterionAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignCriterion()
        {
            moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient>(moq::MockBehavior.Strict);
            GetCampaignCriterionRequest request = new GetCampaignCriterionRequest
            {
                ResourceNameAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
            };
            gagvr::CampaignCriterion expectedResponse = new gagvr::CampaignCriterion
            {
                ResourceNameAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.Location,
                Keyword = new gagvc::KeywordInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                Location = new gagvc::LocationInfo(),
                Device = new gagvc::DeviceInfo(),
                AdSchedule = new gagvc::AdScheduleInfo(),
                AgeRange = new gagvc::AgeRangeInfo(),
                Gender = new gagvc::GenderInfo(),
                IncomeRange = new gagvc::IncomeRangeInfo(),
                ParentalStatus = new gagvc::ParentalStatusInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                UserList = new gagvc::UserListInfo(),
                Proximity = new gagvc::ProximityInfo(),
                Topic = new gagvc::TopicInfo(),
                ListingScope = new gagvc::ListingScopeInfo(),
                Language = new gagvc::LanguageInfo(),
                IpBlock = new gagvc::IpBlockInfo(),
                ContentLabel = new gagvc::ContentLabelInfo(),
                Carrier = new gagvc::CarrierInfo(),
                UserInterest = new gagvc::UserInterestInfo(),
                Webpage = new gagvc::WebpageInfo(),
                OperatingSystemVersion = new gagvc::OperatingSystemVersionInfo(),
                MobileDevice = new gagvc::MobileDeviceInfo(),
                LocationGroup = new gagvc::LocationGroupInfo(),
                Status = gagve::CampaignCriterionStatusEnum.Types.CampaignCriterionStatus.Removed,
                CustomAffinity = new gagvc::CustomAffinityInfo(),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195E+17F,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignCriterion response = client.GetCampaignCriterion(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignCriterionAsync()
        {
            moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient>(moq::MockBehavior.Strict);
            GetCampaignCriterionRequest request = new GetCampaignCriterionRequest
            {
                ResourceNameAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
            };
            gagvr::CampaignCriterion expectedResponse = new gagvr::CampaignCriterion
            {
                ResourceNameAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.Location,
                Keyword = new gagvc::KeywordInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                Location = new gagvc::LocationInfo(),
                Device = new gagvc::DeviceInfo(),
                AdSchedule = new gagvc::AdScheduleInfo(),
                AgeRange = new gagvc::AgeRangeInfo(),
                Gender = new gagvc::GenderInfo(),
                IncomeRange = new gagvc::IncomeRangeInfo(),
                ParentalStatus = new gagvc::ParentalStatusInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                UserList = new gagvc::UserListInfo(),
                Proximity = new gagvc::ProximityInfo(),
                Topic = new gagvc::TopicInfo(),
                ListingScope = new gagvc::ListingScopeInfo(),
                Language = new gagvc::LanguageInfo(),
                IpBlock = new gagvc::IpBlockInfo(),
                ContentLabel = new gagvc::ContentLabelInfo(),
                Carrier = new gagvc::CarrierInfo(),
                UserInterest = new gagvc::UserInterestInfo(),
                Webpage = new gagvc::WebpageInfo(),
                OperatingSystemVersion = new gagvc::OperatingSystemVersionInfo(),
                MobileDevice = new gagvc::MobileDeviceInfo(),
                LocationGroup = new gagvc::LocationGroupInfo(),
                Status = gagve::CampaignCriterionStatusEnum.Types.CampaignCriterionStatus.Removed,
                CustomAffinity = new gagvc::CustomAffinityInfo(),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195E+17F,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignCriterion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignCriterion responseCallSettings = await client.GetCampaignCriterionAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignCriterion responseCancellationToken = await client.GetCampaignCriterionAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignCriterionResourceNames()
        {
            moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient>(moq::MockBehavior.Strict);
            GetCampaignCriterionRequest request = new GetCampaignCriterionRequest
            {
                ResourceNameAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
            };
            gagvr::CampaignCriterion expectedResponse = new gagvr::CampaignCriterion
            {
                ResourceNameAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.Location,
                Keyword = new gagvc::KeywordInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                Location = new gagvc::LocationInfo(),
                Device = new gagvc::DeviceInfo(),
                AdSchedule = new gagvc::AdScheduleInfo(),
                AgeRange = new gagvc::AgeRangeInfo(),
                Gender = new gagvc::GenderInfo(),
                IncomeRange = new gagvc::IncomeRangeInfo(),
                ParentalStatus = new gagvc::ParentalStatusInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                UserList = new gagvc::UserListInfo(),
                Proximity = new gagvc::ProximityInfo(),
                Topic = new gagvc::TopicInfo(),
                ListingScope = new gagvc::ListingScopeInfo(),
                Language = new gagvc::LanguageInfo(),
                IpBlock = new gagvc::IpBlockInfo(),
                ContentLabel = new gagvc::ContentLabelInfo(),
                Carrier = new gagvc::CarrierInfo(),
                UserInterest = new gagvc::UserInterestInfo(),
                Webpage = new gagvc::WebpageInfo(),
                OperatingSystemVersion = new gagvc::OperatingSystemVersionInfo(),
                MobileDevice = new gagvc::MobileDeviceInfo(),
                LocationGroup = new gagvc::LocationGroupInfo(),
                Status = gagve::CampaignCriterionStatusEnum.Types.CampaignCriterionStatus.Removed,
                CustomAffinity = new gagvc::CustomAffinityInfo(),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195E+17F,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignCriterion response = client.GetCampaignCriterion(request.ResourceNameAsCampaignCriterionName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignCriterionResourceNamesAsync()
        {
            moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient>(moq::MockBehavior.Strict);
            GetCampaignCriterionRequest request = new GetCampaignCriterionRequest
            {
                ResourceNameAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
            };
            gagvr::CampaignCriterion expectedResponse = new gagvr::CampaignCriterion
            {
                ResourceNameAsCampaignCriterionName = gagvr::CampaignCriterionName.FromCustomerCampaignCriterion("[CUSTOMER]", "[CAMPAIGN_CRITERION]"),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.Location,
                Keyword = new gagvc::KeywordInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                Location = new gagvc::LocationInfo(),
                Device = new gagvc::DeviceInfo(),
                AdSchedule = new gagvc::AdScheduleInfo(),
                AgeRange = new gagvc::AgeRangeInfo(),
                Gender = new gagvc::GenderInfo(),
                IncomeRange = new gagvc::IncomeRangeInfo(),
                ParentalStatus = new gagvc::ParentalStatusInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                UserList = new gagvc::UserListInfo(),
                Proximity = new gagvc::ProximityInfo(),
                Topic = new gagvc::TopicInfo(),
                ListingScope = new gagvc::ListingScopeInfo(),
                Language = new gagvc::LanguageInfo(),
                IpBlock = new gagvc::IpBlockInfo(),
                ContentLabel = new gagvc::ContentLabelInfo(),
                Carrier = new gagvc::CarrierInfo(),
                UserInterest = new gagvc::UserInterestInfo(),
                Webpage = new gagvc::WebpageInfo(),
                OperatingSystemVersion = new gagvc::OperatingSystemVersionInfo(),
                MobileDevice = new gagvc::MobileDeviceInfo(),
                LocationGroup = new gagvc::LocationGroupInfo(),
                Status = gagve::CampaignCriterionStatusEnum.Types.CampaignCriterionStatus.Removed,
                CustomAffinity = new gagvc::CustomAffinityInfo(),
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195E+17F,
                Negative = false,
            };
            mockGrpcClient.Setup(x => x.GetCampaignCriterionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignCriterion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignCriterion responseCallSettings = await client.GetCampaignCriterionAsync(request.ResourceNameAsCampaignCriterionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignCriterion responseCancellationToken = await client.GetCampaignCriterionAsync(request.ResourceNameAsCampaignCriterionName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignCriteriaRequestObject()
        {
            moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignCriteriaRequest request = new MutateCampaignCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignCriteriaResponse expectedResponse = new MutateCampaignCriteriaResponse
            {
                Results =
                {
                    new MutateCampaignCriterionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignCriteria(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignCriteriaResponse response = client.MutateCampaignCriteria(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignCriteriaRequestObjectAsync()
        {
            moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignCriteriaRequest request = new MutateCampaignCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignCriteriaResponse expectedResponse = new MutateCampaignCriteriaResponse
            {
                Results =
                {
                    new MutateCampaignCriterionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignCriteriaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignCriteriaResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignCriteriaResponse responseCallSettings = await client.MutateCampaignCriteriaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignCriteriaResponse responseCancellationToken = await client.MutateCampaignCriteriaAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignCriteria()
        {
            moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignCriteriaRequest request = new MutateCampaignCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignCriterionOperation(),
                },
            };
            MutateCampaignCriteriaResponse expectedResponse = new MutateCampaignCriteriaResponse
            {
                Results =
                {
                    new MutateCampaignCriterionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignCriteria(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignCriteriaResponse response = client.MutateCampaignCriteria(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignCriteriaAsync()
        {
            moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient> mockGrpcClient = new moq::Mock<CampaignCriterionService.CampaignCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignCriteriaRequest request = new MutateCampaignCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignCriterionOperation(),
                },
            };
            MutateCampaignCriteriaResponse expectedResponse = new MutateCampaignCriteriaResponse
            {
                Results =
                {
                    new MutateCampaignCriterionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignCriteriaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignCriteriaResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignCriterionServiceClient client = new CampaignCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignCriteriaResponse responseCallSettings = await client.MutateCampaignCriteriaAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignCriteriaResponse responseCancellationToken = await client.MutateCampaignCriteriaAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

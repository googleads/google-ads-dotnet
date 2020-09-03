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

using gagvc = Google.Ads.GoogleAds.V3.Common;
using gagve = Google.Ads.GoogleAds.V3.Enums;
using gagvr = Google.Ads.GoogleAds.V3.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V3.Services;

namespace Google.Ads.GoogleAds.Tests.V3.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCampaignServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCampaignRequestObject()
        {
            moq::Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new moq::Mock<CampaignService.CampaignServiceClient>(moq::MockBehavior.Strict);
            GetCampaignRequest request = new GetCampaignRequest
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
            };
            gagvr::Campaign expectedResponse = new gagvr::Campaign
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Id = -6774108720365892680L,
                CampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignStatusEnum.Types.CampaignStatus.Removed,
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER]", "[CAMPAIGN_BUDGET]"),
                AdServingOptimizationStatus = gagve::AdServingOptimizationStatusEnum.Types.AdServingOptimizationStatus.ConversionOptimize,
                AdvertisingChannelType = gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.MultiChannel,
                AdvertisingChannelSubType = gagve::AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType.VideoOutstream,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                NetworkSettings = new gagvr::Campaign.Types.NetworkSettings(),
                ExperimentType = gagve::CampaignExperimentTypeEnum.Types.CampaignExperimentType.Unknown,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                ServingStatus = gagve::CampaignServingStatusEnum.Types.CampaignServingStatus.Ended,
                BiddingStrategyType = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.TargetCpa,
                BiddingStrategyAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                ManualCpc = new gagvc::ManualCpc(),
                ManualCpm = new gagvc::ManualCpm(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetSpend = new gagvc::TargetSpend(),
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                TargetRoas = new gagvc::TargetRoas(),
                MaximizeConversions = new gagvc::MaximizeConversions(),
                MaximizeConversionValue = new gagvc::MaximizeConversionValue(),
                HotelSetting = new gagvr::Campaign.Types.HotelSettingInfo(),
                DynamicSearchAdsSetting = new gagvr::Campaign.Types.DynamicSearchAdsSetting(),
                PercentCpc = new gagvc::PercentCpc(),
                ShoppingSetting = new gagvr::Campaign.Types.ShoppingSetting(),
                ManualCpv = new gagvc::ManualCpv(),
                FinalUrlSuffix = "final_url_suffix046ed37a",
                RealTimeBiddingSetting = new gagvc::RealTimeBiddingSetting(),
                FrequencyCaps =
                {
                    new gagvc::FrequencyCapEntry(),
                },
                TargetCpm = new gagvc::TargetCpm(),
                VideoBrandSafetySuitability = gagve::BrandSafetySuitabilityEnum.Types.BrandSafetySuitability.Unknown,
                TargetingSetting = new gagvc::TargetingSetting(),
                VanityPharma = new gagvr::Campaign.Types.VanityPharma(),
                SelectiveOptimization = new gagvr::Campaign.Types.SelectiveOptimization(),
                TrackingSetting = new gagvr::Campaign.Types.TrackingSetting(),
                GeoTargetTypeSetting = new gagvr::Campaign.Types.GeoTargetTypeSetting(),
                TargetImpressionShare = new gagvc::TargetImpressionShare(),
                Commission = new gagvc::Commission(),
                AppCampaignSetting = new gagvr::Campaign.Types.AppCampaignSetting(),
                PaymentMode = gagve::PaymentModeEnum.Types.PaymentMode.Clicks,
                LabelsAsCampaignLabelNames =
                {
                    gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
                },
                OptimizationScore = -4.7741588361660064E+17,
            };
            mockGrpcClient.Setup(x => x.GetCampaign(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Campaign response = client.GetCampaign(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignRequestObjectAsync()
        {
            moq::Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new moq::Mock<CampaignService.CampaignServiceClient>(moq::MockBehavior.Strict);
            GetCampaignRequest request = new GetCampaignRequest
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
            };
            gagvr::Campaign expectedResponse = new gagvr::Campaign
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Id = -6774108720365892680L,
                CampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignStatusEnum.Types.CampaignStatus.Removed,
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER]", "[CAMPAIGN_BUDGET]"),
                AdServingOptimizationStatus = gagve::AdServingOptimizationStatusEnum.Types.AdServingOptimizationStatus.ConversionOptimize,
                AdvertisingChannelType = gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.MultiChannel,
                AdvertisingChannelSubType = gagve::AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType.VideoOutstream,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                NetworkSettings = new gagvr::Campaign.Types.NetworkSettings(),
                ExperimentType = gagve::CampaignExperimentTypeEnum.Types.CampaignExperimentType.Unknown,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                ServingStatus = gagve::CampaignServingStatusEnum.Types.CampaignServingStatus.Ended,
                BiddingStrategyType = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.TargetCpa,
                BiddingStrategyAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                ManualCpc = new gagvc::ManualCpc(),
                ManualCpm = new gagvc::ManualCpm(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetSpend = new gagvc::TargetSpend(),
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                TargetRoas = new gagvc::TargetRoas(),
                MaximizeConversions = new gagvc::MaximizeConversions(),
                MaximizeConversionValue = new gagvc::MaximizeConversionValue(),
                HotelSetting = new gagvr::Campaign.Types.HotelSettingInfo(),
                DynamicSearchAdsSetting = new gagvr::Campaign.Types.DynamicSearchAdsSetting(),
                PercentCpc = new gagvc::PercentCpc(),
                ShoppingSetting = new gagvr::Campaign.Types.ShoppingSetting(),
                ManualCpv = new gagvc::ManualCpv(),
                FinalUrlSuffix = "final_url_suffix046ed37a",
                RealTimeBiddingSetting = new gagvc::RealTimeBiddingSetting(),
                FrequencyCaps =
                {
                    new gagvc::FrequencyCapEntry(),
                },
                TargetCpm = new gagvc::TargetCpm(),
                VideoBrandSafetySuitability = gagve::BrandSafetySuitabilityEnum.Types.BrandSafetySuitability.Unknown,
                TargetingSetting = new gagvc::TargetingSetting(),
                VanityPharma = new gagvr::Campaign.Types.VanityPharma(),
                SelectiveOptimization = new gagvr::Campaign.Types.SelectiveOptimization(),
                TrackingSetting = new gagvr::Campaign.Types.TrackingSetting(),
                GeoTargetTypeSetting = new gagvr::Campaign.Types.GeoTargetTypeSetting(),
                TargetImpressionShare = new gagvc::TargetImpressionShare(),
                Commission = new gagvc::Commission(),
                AppCampaignSetting = new gagvr::Campaign.Types.AppCampaignSetting(),
                PaymentMode = gagve::PaymentModeEnum.Types.PaymentMode.Clicks,
                LabelsAsCampaignLabelNames =
                {
                    gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
                },
                OptimizationScore = -4.7741588361660064E+17,
            };
            mockGrpcClient.Setup(x => x.GetCampaignAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Campaign>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Campaign responseCallSettings = await client.GetCampaignAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Campaign responseCancellationToken = await client.GetCampaignAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaign()
        {
            moq::Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new moq::Mock<CampaignService.CampaignServiceClient>(moq::MockBehavior.Strict);
            GetCampaignRequest request = new GetCampaignRequest
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
            };
            gagvr::Campaign expectedResponse = new gagvr::Campaign
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Id = -6774108720365892680L,
                CampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignStatusEnum.Types.CampaignStatus.Removed,
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER]", "[CAMPAIGN_BUDGET]"),
                AdServingOptimizationStatus = gagve::AdServingOptimizationStatusEnum.Types.AdServingOptimizationStatus.ConversionOptimize,
                AdvertisingChannelType = gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.MultiChannel,
                AdvertisingChannelSubType = gagve::AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType.VideoOutstream,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                NetworkSettings = new gagvr::Campaign.Types.NetworkSettings(),
                ExperimentType = gagve::CampaignExperimentTypeEnum.Types.CampaignExperimentType.Unknown,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                ServingStatus = gagve::CampaignServingStatusEnum.Types.CampaignServingStatus.Ended,
                BiddingStrategyType = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.TargetCpa,
                BiddingStrategyAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                ManualCpc = new gagvc::ManualCpc(),
                ManualCpm = new gagvc::ManualCpm(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetSpend = new gagvc::TargetSpend(),
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                TargetRoas = new gagvc::TargetRoas(),
                MaximizeConversions = new gagvc::MaximizeConversions(),
                MaximizeConversionValue = new gagvc::MaximizeConversionValue(),
                HotelSetting = new gagvr::Campaign.Types.HotelSettingInfo(),
                DynamicSearchAdsSetting = new gagvr::Campaign.Types.DynamicSearchAdsSetting(),
                PercentCpc = new gagvc::PercentCpc(),
                ShoppingSetting = new gagvr::Campaign.Types.ShoppingSetting(),
                ManualCpv = new gagvc::ManualCpv(),
                FinalUrlSuffix = "final_url_suffix046ed37a",
                RealTimeBiddingSetting = new gagvc::RealTimeBiddingSetting(),
                FrequencyCaps =
                {
                    new gagvc::FrequencyCapEntry(),
                },
                TargetCpm = new gagvc::TargetCpm(),
                VideoBrandSafetySuitability = gagve::BrandSafetySuitabilityEnum.Types.BrandSafetySuitability.Unknown,
                TargetingSetting = new gagvc::TargetingSetting(),
                VanityPharma = new gagvr::Campaign.Types.VanityPharma(),
                SelectiveOptimization = new gagvr::Campaign.Types.SelectiveOptimization(),
                TrackingSetting = new gagvr::Campaign.Types.TrackingSetting(),
                GeoTargetTypeSetting = new gagvr::Campaign.Types.GeoTargetTypeSetting(),
                TargetImpressionShare = new gagvc::TargetImpressionShare(),
                Commission = new gagvc::Commission(),
                AppCampaignSetting = new gagvr::Campaign.Types.AppCampaignSetting(),
                PaymentMode = gagve::PaymentModeEnum.Types.PaymentMode.Clicks,
                LabelsAsCampaignLabelNames =
                {
                    gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
                },
                OptimizationScore = -4.7741588361660064E+17,
            };
            mockGrpcClient.Setup(x => x.GetCampaign(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Campaign response = client.GetCampaign(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignAsync()
        {
            moq::Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new moq::Mock<CampaignService.CampaignServiceClient>(moq::MockBehavior.Strict);
            GetCampaignRequest request = new GetCampaignRequest
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
            };
            gagvr::Campaign expectedResponse = new gagvr::Campaign
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Id = -6774108720365892680L,
                CampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignStatusEnum.Types.CampaignStatus.Removed,
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER]", "[CAMPAIGN_BUDGET]"),
                AdServingOptimizationStatus = gagve::AdServingOptimizationStatusEnum.Types.AdServingOptimizationStatus.ConversionOptimize,
                AdvertisingChannelType = gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.MultiChannel,
                AdvertisingChannelSubType = gagve::AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType.VideoOutstream,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                NetworkSettings = new gagvr::Campaign.Types.NetworkSettings(),
                ExperimentType = gagve::CampaignExperimentTypeEnum.Types.CampaignExperimentType.Unknown,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                ServingStatus = gagve::CampaignServingStatusEnum.Types.CampaignServingStatus.Ended,
                BiddingStrategyType = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.TargetCpa,
                BiddingStrategyAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                ManualCpc = new gagvc::ManualCpc(),
                ManualCpm = new gagvc::ManualCpm(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetSpend = new gagvc::TargetSpend(),
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                TargetRoas = new gagvc::TargetRoas(),
                MaximizeConversions = new gagvc::MaximizeConversions(),
                MaximizeConversionValue = new gagvc::MaximizeConversionValue(),
                HotelSetting = new gagvr::Campaign.Types.HotelSettingInfo(),
                DynamicSearchAdsSetting = new gagvr::Campaign.Types.DynamicSearchAdsSetting(),
                PercentCpc = new gagvc::PercentCpc(),
                ShoppingSetting = new gagvr::Campaign.Types.ShoppingSetting(),
                ManualCpv = new gagvc::ManualCpv(),
                FinalUrlSuffix = "final_url_suffix046ed37a",
                RealTimeBiddingSetting = new gagvc::RealTimeBiddingSetting(),
                FrequencyCaps =
                {
                    new gagvc::FrequencyCapEntry(),
                },
                TargetCpm = new gagvc::TargetCpm(),
                VideoBrandSafetySuitability = gagve::BrandSafetySuitabilityEnum.Types.BrandSafetySuitability.Unknown,
                TargetingSetting = new gagvc::TargetingSetting(),
                VanityPharma = new gagvr::Campaign.Types.VanityPharma(),
                SelectiveOptimization = new gagvr::Campaign.Types.SelectiveOptimization(),
                TrackingSetting = new gagvr::Campaign.Types.TrackingSetting(),
                GeoTargetTypeSetting = new gagvr::Campaign.Types.GeoTargetTypeSetting(),
                TargetImpressionShare = new gagvc::TargetImpressionShare(),
                Commission = new gagvc::Commission(),
                AppCampaignSetting = new gagvr::Campaign.Types.AppCampaignSetting(),
                PaymentMode = gagve::PaymentModeEnum.Types.PaymentMode.Clicks,
                LabelsAsCampaignLabelNames =
                {
                    gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
                },
                OptimizationScore = -4.7741588361660064E+17,
            };
            mockGrpcClient.Setup(x => x.GetCampaignAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Campaign>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Campaign responseCallSettings = await client.GetCampaignAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Campaign responseCancellationToken = await client.GetCampaignAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignResourceNames()
        {
            moq::Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new moq::Mock<CampaignService.CampaignServiceClient>(moq::MockBehavior.Strict);
            GetCampaignRequest request = new GetCampaignRequest
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
            };
            gagvr::Campaign expectedResponse = new gagvr::Campaign
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Id = -6774108720365892680L,
                CampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignStatusEnum.Types.CampaignStatus.Removed,
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER]", "[CAMPAIGN_BUDGET]"),
                AdServingOptimizationStatus = gagve::AdServingOptimizationStatusEnum.Types.AdServingOptimizationStatus.ConversionOptimize,
                AdvertisingChannelType = gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.MultiChannel,
                AdvertisingChannelSubType = gagve::AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType.VideoOutstream,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                NetworkSettings = new gagvr::Campaign.Types.NetworkSettings(),
                ExperimentType = gagve::CampaignExperimentTypeEnum.Types.CampaignExperimentType.Unknown,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                ServingStatus = gagve::CampaignServingStatusEnum.Types.CampaignServingStatus.Ended,
                BiddingStrategyType = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.TargetCpa,
                BiddingStrategyAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                ManualCpc = new gagvc::ManualCpc(),
                ManualCpm = new gagvc::ManualCpm(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetSpend = new gagvc::TargetSpend(),
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                TargetRoas = new gagvc::TargetRoas(),
                MaximizeConversions = new gagvc::MaximizeConversions(),
                MaximizeConversionValue = new gagvc::MaximizeConversionValue(),
                HotelSetting = new gagvr::Campaign.Types.HotelSettingInfo(),
                DynamicSearchAdsSetting = new gagvr::Campaign.Types.DynamicSearchAdsSetting(),
                PercentCpc = new gagvc::PercentCpc(),
                ShoppingSetting = new gagvr::Campaign.Types.ShoppingSetting(),
                ManualCpv = new gagvc::ManualCpv(),
                FinalUrlSuffix = "final_url_suffix046ed37a",
                RealTimeBiddingSetting = new gagvc::RealTimeBiddingSetting(),
                FrequencyCaps =
                {
                    new gagvc::FrequencyCapEntry(),
                },
                TargetCpm = new gagvc::TargetCpm(),
                VideoBrandSafetySuitability = gagve::BrandSafetySuitabilityEnum.Types.BrandSafetySuitability.Unknown,
                TargetingSetting = new gagvc::TargetingSetting(),
                VanityPharma = new gagvr::Campaign.Types.VanityPharma(),
                SelectiveOptimization = new gagvr::Campaign.Types.SelectiveOptimization(),
                TrackingSetting = new gagvr::Campaign.Types.TrackingSetting(),
                GeoTargetTypeSetting = new gagvr::Campaign.Types.GeoTargetTypeSetting(),
                TargetImpressionShare = new gagvc::TargetImpressionShare(),
                Commission = new gagvc::Commission(),
                AppCampaignSetting = new gagvr::Campaign.Types.AppCampaignSetting(),
                PaymentMode = gagve::PaymentModeEnum.Types.PaymentMode.Clicks,
                LabelsAsCampaignLabelNames =
                {
                    gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
                },
                OptimizationScore = -4.7741588361660064E+17,
            };
            mockGrpcClient.Setup(x => x.GetCampaign(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Campaign response = client.GetCampaign(request.ResourceNameAsCampaignName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignResourceNamesAsync()
        {
            moq::Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new moq::Mock<CampaignService.CampaignServiceClient>(moq::MockBehavior.Strict);
            GetCampaignRequest request = new GetCampaignRequest
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
            };
            gagvr::Campaign expectedResponse = new gagvr::Campaign
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Id = -6774108720365892680L,
                CampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Status = gagve::CampaignStatusEnum.Types.CampaignStatus.Removed,
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER]", "[CAMPAIGN_BUDGET]"),
                AdServingOptimizationStatus = gagve::AdServingOptimizationStatusEnum.Types.AdServingOptimizationStatus.ConversionOptimize,
                AdvertisingChannelType = gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.MultiChannel,
                AdvertisingChannelSubType = gagve::AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType.VideoOutstream,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                NetworkSettings = new gagvr::Campaign.Types.NetworkSettings(),
                ExperimentType = gagve::CampaignExperimentTypeEnum.Types.CampaignExperimentType.Unknown,
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                ServingStatus = gagve::CampaignServingStatusEnum.Types.CampaignServingStatus.Ended,
                BiddingStrategyType = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.TargetCpa,
                BiddingStrategyAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER]", "[BIDDING_STRATEGY]"),
                ManualCpc = new gagvc::ManualCpc(),
                ManualCpm = new gagvc::ManualCpm(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetSpend = new gagvc::TargetSpend(),
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                TargetRoas = new gagvc::TargetRoas(),
                MaximizeConversions = new gagvc::MaximizeConversions(),
                MaximizeConversionValue = new gagvc::MaximizeConversionValue(),
                HotelSetting = new gagvr::Campaign.Types.HotelSettingInfo(),
                DynamicSearchAdsSetting = new gagvr::Campaign.Types.DynamicSearchAdsSetting(),
                PercentCpc = new gagvc::PercentCpc(),
                ShoppingSetting = new gagvr::Campaign.Types.ShoppingSetting(),
                ManualCpv = new gagvc::ManualCpv(),
                FinalUrlSuffix = "final_url_suffix046ed37a",
                RealTimeBiddingSetting = new gagvc::RealTimeBiddingSetting(),
                FrequencyCaps =
                {
                    new gagvc::FrequencyCapEntry(),
                },
                TargetCpm = new gagvc::TargetCpm(),
                VideoBrandSafetySuitability = gagve::BrandSafetySuitabilityEnum.Types.BrandSafetySuitability.Unknown,
                TargetingSetting = new gagvc::TargetingSetting(),
                VanityPharma = new gagvr::Campaign.Types.VanityPharma(),
                SelectiveOptimization = new gagvr::Campaign.Types.SelectiveOptimization(),
                TrackingSetting = new gagvr::Campaign.Types.TrackingSetting(),
                GeoTargetTypeSetting = new gagvr::Campaign.Types.GeoTargetTypeSetting(),
                TargetImpressionShare = new gagvc::TargetImpressionShare(),
                Commission = new gagvc::Commission(),
                AppCampaignSetting = new gagvr::Campaign.Types.AppCampaignSetting(),
                PaymentMode = gagve::PaymentModeEnum.Types.PaymentMode.Clicks,
                LabelsAsCampaignLabelNames =
                {
                    gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER]", "[CAMPAIGN_LABEL]"),
                },
                OptimizationScore = -4.7741588361660064E+17,
            };
            mockGrpcClient.Setup(x => x.GetCampaignAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Campaign>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Campaign responseCallSettings = await client.GetCampaignAsync(request.ResourceNameAsCampaignName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Campaign responseCancellationToken = await client.GetCampaignAsync(request.ResourceNameAsCampaignName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignsRequestObject()
        {
            moq::Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new moq::Mock<CampaignService.CampaignServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignsRequest request = new MutateCampaignsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCampaignsResponse expectedResponse = new MutateCampaignsResponse
            {
                Results =
                {
                    new MutateCampaignResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaigns(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignsResponse response = client.MutateCampaigns(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignsRequestObjectAsync()
        {
            moq::Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new moq::Mock<CampaignService.CampaignServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignsRequest request = new MutateCampaignsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCampaignsResponse expectedResponse = new MutateCampaignsResponse
            {
                Results =
                {
                    new MutateCampaignResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignsResponse responseCallSettings = await client.MutateCampaignsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignsResponse responseCancellationToken = await client.MutateCampaignsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaigns()
        {
            moq::Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new moq::Mock<CampaignService.CampaignServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignsRequest request = new MutateCampaignsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignOperation(),
                },
            };
            MutateCampaignsResponse expectedResponse = new MutateCampaignsResponse
            {
                Results =
                {
                    new MutateCampaignResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaigns(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignsResponse response = client.MutateCampaigns(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignsAsync()
        {
            moq::Mock<CampaignService.CampaignServiceClient> mockGrpcClient = new moq::Mock<CampaignService.CampaignServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignsRequest request = new MutateCampaignsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignOperation(),
                },
            };
            MutateCampaignsResponse expectedResponse = new MutateCampaignsResponse
            {
                Results =
                {
                    new MutateCampaignResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignServiceClient client = new CampaignServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignsResponse responseCallSettings = await client.MutateCampaignsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignsResponse responseCancellationToken = await client.MutateCampaignsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

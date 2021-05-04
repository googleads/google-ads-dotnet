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

using gagvc = Google.Ads.GoogleAds.V7.Common;
using gagve = Google.Ads.GoogleAds.V7.Enums;
using gagvr = Google.Ads.GoogleAds.V7.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V7.Services;

namespace Google.Ads.GoogleAds.Tests.V7.Services
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
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            gagvr::Campaign expectedResponse = new gagvr::Campaign
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Status = gagve::CampaignStatusEnum.Types.CampaignStatus.Removed,
                AdServingOptimizationStatus = gagve::AdServingOptimizationStatusEnum.Types.AdServingOptimizationStatus.ConversionOptimize,
                AdvertisingChannelType = gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.MultiChannel,
                AdvertisingChannelSubType = gagve::AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType.AppCampaign,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                NetworkSettings = new gagvr::Campaign.Types.NetworkSettings(),
                ExperimentType = gagve::CampaignExperimentTypeEnum.Types.CampaignExperimentType.Unknown,
                ServingStatus = gagve::CampaignServingStatusEnum.Types.CampaignServingStatus.Ended,
                BiddingStrategyType = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.TargetCpa,
                ManualCpc = new gagvc::ManualCpc(),
                ManualCpm = new gagvc::ManualCpm(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetSpend = new gagvc::TargetSpend(),
                TargetRoas = new gagvc::TargetRoas(),
                MaximizeConversions = new gagvc::MaximizeConversions(),
                MaximizeConversionValue = new gagvc::MaximizeConversionValue(),
                HotelSetting = new gagvr::Campaign.Types.HotelSettingInfo(),
                DynamicSearchAdsSetting = new gagvr::Campaign.Types.DynamicSearchAdsSetting(),
                PercentCpc = new gagvc::PercentCpc(),
                ShoppingSetting = new gagvr::Campaign.Types.ShoppingSetting(),
                ManualCpv = new gagvc::ManualCpv(),
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
                LocalCampaignSetting = new gagvr::Campaign.Types.LocalCampaignSetting(),
                AppCampaignSetting = new gagvr::Campaign.Types.AppCampaignSetting(),
                PaymentMode = gagve::PaymentModeEnum.Types.PaymentMode.Clicks,
                OptimizationGoalSetting = new gagvr::Campaign.Types.OptimizationGoalSetting(),
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Id = -6774108720365892680L,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                LabelsAsCampaignLabelNames =
                {
                    gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[LABEL_ID]"),
                },
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                FinalUrlSuffix = "final_url_suffix046ed37a",
                OptimizationScore = -4.7741588361660064E+17,
                BiddingStrategyAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                ExcludedParentAssetFieldTypes =
                {
                    gagve::AssetFieldTypeEnum.Types.AssetFieldType.Unknown,
                },
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
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            gagvr::Campaign expectedResponse = new gagvr::Campaign
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Status = gagve::CampaignStatusEnum.Types.CampaignStatus.Removed,
                AdServingOptimizationStatus = gagve::AdServingOptimizationStatusEnum.Types.AdServingOptimizationStatus.ConversionOptimize,
                AdvertisingChannelType = gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.MultiChannel,
                AdvertisingChannelSubType = gagve::AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType.AppCampaign,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                NetworkSettings = new gagvr::Campaign.Types.NetworkSettings(),
                ExperimentType = gagve::CampaignExperimentTypeEnum.Types.CampaignExperimentType.Unknown,
                ServingStatus = gagve::CampaignServingStatusEnum.Types.CampaignServingStatus.Ended,
                BiddingStrategyType = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.TargetCpa,
                ManualCpc = new gagvc::ManualCpc(),
                ManualCpm = new gagvc::ManualCpm(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetSpend = new gagvc::TargetSpend(),
                TargetRoas = new gagvc::TargetRoas(),
                MaximizeConversions = new gagvc::MaximizeConversions(),
                MaximizeConversionValue = new gagvc::MaximizeConversionValue(),
                HotelSetting = new gagvr::Campaign.Types.HotelSettingInfo(),
                DynamicSearchAdsSetting = new gagvr::Campaign.Types.DynamicSearchAdsSetting(),
                PercentCpc = new gagvc::PercentCpc(),
                ShoppingSetting = new gagvr::Campaign.Types.ShoppingSetting(),
                ManualCpv = new gagvc::ManualCpv(),
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
                LocalCampaignSetting = new gagvr::Campaign.Types.LocalCampaignSetting(),
                AppCampaignSetting = new gagvr::Campaign.Types.AppCampaignSetting(),
                PaymentMode = gagve::PaymentModeEnum.Types.PaymentMode.Clicks,
                OptimizationGoalSetting = new gagvr::Campaign.Types.OptimizationGoalSetting(),
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Id = -6774108720365892680L,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                LabelsAsCampaignLabelNames =
                {
                    gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[LABEL_ID]"),
                },
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                FinalUrlSuffix = "final_url_suffix046ed37a",
                OptimizationScore = -4.7741588361660064E+17,
                BiddingStrategyAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                ExcludedParentAssetFieldTypes =
                {
                    gagve::AssetFieldTypeEnum.Types.AssetFieldType.Unknown,
                },
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
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            gagvr::Campaign expectedResponse = new gagvr::Campaign
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Status = gagve::CampaignStatusEnum.Types.CampaignStatus.Removed,
                AdServingOptimizationStatus = gagve::AdServingOptimizationStatusEnum.Types.AdServingOptimizationStatus.ConversionOptimize,
                AdvertisingChannelType = gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.MultiChannel,
                AdvertisingChannelSubType = gagve::AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType.AppCampaign,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                NetworkSettings = new gagvr::Campaign.Types.NetworkSettings(),
                ExperimentType = gagve::CampaignExperimentTypeEnum.Types.CampaignExperimentType.Unknown,
                ServingStatus = gagve::CampaignServingStatusEnum.Types.CampaignServingStatus.Ended,
                BiddingStrategyType = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.TargetCpa,
                ManualCpc = new gagvc::ManualCpc(),
                ManualCpm = new gagvc::ManualCpm(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetSpend = new gagvc::TargetSpend(),
                TargetRoas = new gagvc::TargetRoas(),
                MaximizeConversions = new gagvc::MaximizeConversions(),
                MaximizeConversionValue = new gagvc::MaximizeConversionValue(),
                HotelSetting = new gagvr::Campaign.Types.HotelSettingInfo(),
                DynamicSearchAdsSetting = new gagvr::Campaign.Types.DynamicSearchAdsSetting(),
                PercentCpc = new gagvc::PercentCpc(),
                ShoppingSetting = new gagvr::Campaign.Types.ShoppingSetting(),
                ManualCpv = new gagvc::ManualCpv(),
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
                LocalCampaignSetting = new gagvr::Campaign.Types.LocalCampaignSetting(),
                AppCampaignSetting = new gagvr::Campaign.Types.AppCampaignSetting(),
                PaymentMode = gagve::PaymentModeEnum.Types.PaymentMode.Clicks,
                OptimizationGoalSetting = new gagvr::Campaign.Types.OptimizationGoalSetting(),
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Id = -6774108720365892680L,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                LabelsAsCampaignLabelNames =
                {
                    gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[LABEL_ID]"),
                },
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                FinalUrlSuffix = "final_url_suffix046ed37a",
                OptimizationScore = -4.7741588361660064E+17,
                BiddingStrategyAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                ExcludedParentAssetFieldTypes =
                {
                    gagve::AssetFieldTypeEnum.Types.AssetFieldType.Unknown,
                },
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
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            gagvr::Campaign expectedResponse = new gagvr::Campaign
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Status = gagve::CampaignStatusEnum.Types.CampaignStatus.Removed,
                AdServingOptimizationStatus = gagve::AdServingOptimizationStatusEnum.Types.AdServingOptimizationStatus.ConversionOptimize,
                AdvertisingChannelType = gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.MultiChannel,
                AdvertisingChannelSubType = gagve::AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType.AppCampaign,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                NetworkSettings = new gagvr::Campaign.Types.NetworkSettings(),
                ExperimentType = gagve::CampaignExperimentTypeEnum.Types.CampaignExperimentType.Unknown,
                ServingStatus = gagve::CampaignServingStatusEnum.Types.CampaignServingStatus.Ended,
                BiddingStrategyType = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.TargetCpa,
                ManualCpc = new gagvc::ManualCpc(),
                ManualCpm = new gagvc::ManualCpm(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetSpend = new gagvc::TargetSpend(),
                TargetRoas = new gagvc::TargetRoas(),
                MaximizeConversions = new gagvc::MaximizeConversions(),
                MaximizeConversionValue = new gagvc::MaximizeConversionValue(),
                HotelSetting = new gagvr::Campaign.Types.HotelSettingInfo(),
                DynamicSearchAdsSetting = new gagvr::Campaign.Types.DynamicSearchAdsSetting(),
                PercentCpc = new gagvc::PercentCpc(),
                ShoppingSetting = new gagvr::Campaign.Types.ShoppingSetting(),
                ManualCpv = new gagvc::ManualCpv(),
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
                LocalCampaignSetting = new gagvr::Campaign.Types.LocalCampaignSetting(),
                AppCampaignSetting = new gagvr::Campaign.Types.AppCampaignSetting(),
                PaymentMode = gagve::PaymentModeEnum.Types.PaymentMode.Clicks,
                OptimizationGoalSetting = new gagvr::Campaign.Types.OptimizationGoalSetting(),
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Id = -6774108720365892680L,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                LabelsAsCampaignLabelNames =
                {
                    gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[LABEL_ID]"),
                },
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                FinalUrlSuffix = "final_url_suffix046ed37a",
                OptimizationScore = -4.7741588361660064E+17,
                BiddingStrategyAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                ExcludedParentAssetFieldTypes =
                {
                    gagve::AssetFieldTypeEnum.Types.AssetFieldType.Unknown,
                },
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
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            gagvr::Campaign expectedResponse = new gagvr::Campaign
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Status = gagve::CampaignStatusEnum.Types.CampaignStatus.Removed,
                AdServingOptimizationStatus = gagve::AdServingOptimizationStatusEnum.Types.AdServingOptimizationStatus.ConversionOptimize,
                AdvertisingChannelType = gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.MultiChannel,
                AdvertisingChannelSubType = gagve::AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType.AppCampaign,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                NetworkSettings = new gagvr::Campaign.Types.NetworkSettings(),
                ExperimentType = gagve::CampaignExperimentTypeEnum.Types.CampaignExperimentType.Unknown,
                ServingStatus = gagve::CampaignServingStatusEnum.Types.CampaignServingStatus.Ended,
                BiddingStrategyType = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.TargetCpa,
                ManualCpc = new gagvc::ManualCpc(),
                ManualCpm = new gagvc::ManualCpm(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetSpend = new gagvc::TargetSpend(),
                TargetRoas = new gagvc::TargetRoas(),
                MaximizeConversions = new gagvc::MaximizeConversions(),
                MaximizeConversionValue = new gagvc::MaximizeConversionValue(),
                HotelSetting = new gagvr::Campaign.Types.HotelSettingInfo(),
                DynamicSearchAdsSetting = new gagvr::Campaign.Types.DynamicSearchAdsSetting(),
                PercentCpc = new gagvc::PercentCpc(),
                ShoppingSetting = new gagvr::Campaign.Types.ShoppingSetting(),
                ManualCpv = new gagvc::ManualCpv(),
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
                LocalCampaignSetting = new gagvr::Campaign.Types.LocalCampaignSetting(),
                AppCampaignSetting = new gagvr::Campaign.Types.AppCampaignSetting(),
                PaymentMode = gagve::PaymentModeEnum.Types.PaymentMode.Clicks,
                OptimizationGoalSetting = new gagvr::Campaign.Types.OptimizationGoalSetting(),
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Id = -6774108720365892680L,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                LabelsAsCampaignLabelNames =
                {
                    gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[LABEL_ID]"),
                },
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                FinalUrlSuffix = "final_url_suffix046ed37a",
                OptimizationScore = -4.7741588361660064E+17,
                BiddingStrategyAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                ExcludedParentAssetFieldTypes =
                {
                    gagve::AssetFieldTypeEnum.Types.AssetFieldType.Unknown,
                },
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
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
            };
            gagvr::Campaign expectedResponse = new gagvr::Campaign
            {
                ResourceNameAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Status = gagve::CampaignStatusEnum.Types.CampaignStatus.Removed,
                AdServingOptimizationStatus = gagve::AdServingOptimizationStatusEnum.Types.AdServingOptimizationStatus.ConversionOptimize,
                AdvertisingChannelType = gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.MultiChannel,
                AdvertisingChannelSubType = gagve::AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType.AppCampaign,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                NetworkSettings = new gagvr::Campaign.Types.NetworkSettings(),
                ExperimentType = gagve::CampaignExperimentTypeEnum.Types.CampaignExperimentType.Unknown,
                ServingStatus = gagve::CampaignServingStatusEnum.Types.CampaignServingStatus.Ended,
                BiddingStrategyType = gagve::BiddingStrategyTypeEnum.Types.BiddingStrategyType.TargetCpa,
                ManualCpc = new gagvc::ManualCpc(),
                ManualCpm = new gagvc::ManualCpm(),
                TargetCpa = new gagvc::TargetCpa(),
                TargetSpend = new gagvc::TargetSpend(),
                TargetRoas = new gagvc::TargetRoas(),
                MaximizeConversions = new gagvc::MaximizeConversions(),
                MaximizeConversionValue = new gagvc::MaximizeConversionValue(),
                HotelSetting = new gagvr::Campaign.Types.HotelSettingInfo(),
                DynamicSearchAdsSetting = new gagvr::Campaign.Types.DynamicSearchAdsSetting(),
                PercentCpc = new gagvc::PercentCpc(),
                ShoppingSetting = new gagvr::Campaign.Types.ShoppingSetting(),
                ManualCpv = new gagvc::ManualCpv(),
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
                LocalCampaignSetting = new gagvr::Campaign.Types.LocalCampaignSetting(),
                AppCampaignSetting = new gagvr::Campaign.Types.AppCampaignSetting(),
                PaymentMode = gagve::PaymentModeEnum.Types.PaymentMode.Clicks,
                OptimizationGoalSetting = new gagvr::Campaign.Types.OptimizationGoalSetting(),
                BaseCampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                Id = -6774108720365892680L,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                LabelsAsCampaignLabelNames =
                {
                    gagvr::CampaignLabelName.FromCustomerCampaignLabel("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[LABEL_ID]"),
                },
                CampaignBudgetAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                StartDate = "start_date11b9dbea",
                EndDate = "end_date89dae890",
                FinalUrlSuffix = "final_url_suffix046ed37a",
                OptimizationScore = -4.7741588361660064E+17,
                BiddingStrategyAsBiddingStrategyName = gagvr::BiddingStrategyName.FromCustomerBiddingStrategy("[CUSTOMER_ID]", "[BIDDING_STRATEGY_ID]"),
                ExcludedParentAssetFieldTypes =
                {
                    gagve::AssetFieldTypeEnum.Types.AssetFieldType.Unknown,
                },
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
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
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
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
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

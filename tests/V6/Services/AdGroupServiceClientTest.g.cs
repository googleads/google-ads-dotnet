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
    public sealed class GeneratedAdGroupServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAdGroupRequestObject()
        {
            moq::Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new moq::Mock<AdGroupService.AdGroupServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupRequest request = new GetAdGroupRequest
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
            };
            gagvr::AdGroup expectedResponse = new gagvr::AdGroup
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Status = gagve::AdGroupStatusEnum.Types.AdGroupStatus.Removed,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                Type = gagve::AdGroupTypeEnum.Types.AdGroupType.VideoBumper,
                ExplorerAutoOptimizerSetting = new gagvc::ExplorerAutoOptimizerSetting(),
                AdRotationMode = gagve::AdGroupAdRotationModeEnum.Types.AdGroupAdRotationMode.Unspecified,
                DisplayCustomBidDimension = gagve::TargetingDimensionEnum.Types.TargetingDimension.AgeRange,
                TargetingSetting = new gagvc::TargetingSetting(),
                EffectiveTargetCpaSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unknown,
                EffectiveTargetRoasSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                Id = -6774108720365892680L,
                AdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                TargetCpaMicros = 5263516020894046876L,
                CpvBidMicros = 3393527949878021854L,
                TargetCpmMicros = 2683842186664132327L,
                TargetRoas = 1.0830159587289216E+18,
                PercentCpcBidMicros = 3342096754779167220L,
                FinalUrlSuffix = "final_url_suffix046ed37a",
                EffectiveTargetCpaMicros = 9173558632194584770L,
                EffectiveTargetRoas = -5.789428044530098E+17,
                LabelsAsAdGroupLabelNames =
                {
                    gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[LABEL_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetAdGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroup response = client.GetAdGroup(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupRequestObjectAsync()
        {
            moq::Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new moq::Mock<AdGroupService.AdGroupServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupRequest request = new GetAdGroupRequest
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
            };
            gagvr::AdGroup expectedResponse = new gagvr::AdGroup
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Status = gagve::AdGroupStatusEnum.Types.AdGroupStatus.Removed,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                Type = gagve::AdGroupTypeEnum.Types.AdGroupType.VideoBumper,
                ExplorerAutoOptimizerSetting = new gagvc::ExplorerAutoOptimizerSetting(),
                AdRotationMode = gagve::AdGroupAdRotationModeEnum.Types.AdGroupAdRotationMode.Unspecified,
                DisplayCustomBidDimension = gagve::TargetingDimensionEnum.Types.TargetingDimension.AgeRange,
                TargetingSetting = new gagvc::TargetingSetting(),
                EffectiveTargetCpaSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unknown,
                EffectiveTargetRoasSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                Id = -6774108720365892680L,
                AdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                TargetCpaMicros = 5263516020894046876L,
                CpvBidMicros = 3393527949878021854L,
                TargetCpmMicros = 2683842186664132327L,
                TargetRoas = 1.0830159587289216E+18,
                PercentCpcBidMicros = 3342096754779167220L,
                FinalUrlSuffix = "final_url_suffix046ed37a",
                EffectiveTargetCpaMicros = 9173558632194584770L,
                EffectiveTargetRoas = -5.789428044530098E+17,
                LabelsAsAdGroupLabelNames =
                {
                    gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[LABEL_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroup responseCallSettings = await client.GetAdGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroup responseCancellationToken = await client.GetAdGroupAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroup()
        {
            moq::Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new moq::Mock<AdGroupService.AdGroupServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupRequest request = new GetAdGroupRequest
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
            };
            gagvr::AdGroup expectedResponse = new gagvr::AdGroup
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Status = gagve::AdGroupStatusEnum.Types.AdGroupStatus.Removed,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                Type = gagve::AdGroupTypeEnum.Types.AdGroupType.VideoBumper,
                ExplorerAutoOptimizerSetting = new gagvc::ExplorerAutoOptimizerSetting(),
                AdRotationMode = gagve::AdGroupAdRotationModeEnum.Types.AdGroupAdRotationMode.Unspecified,
                DisplayCustomBidDimension = gagve::TargetingDimensionEnum.Types.TargetingDimension.AgeRange,
                TargetingSetting = new gagvc::TargetingSetting(),
                EffectiveTargetCpaSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unknown,
                EffectiveTargetRoasSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                Id = -6774108720365892680L,
                AdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                TargetCpaMicros = 5263516020894046876L,
                CpvBidMicros = 3393527949878021854L,
                TargetCpmMicros = 2683842186664132327L,
                TargetRoas = 1.0830159587289216E+18,
                PercentCpcBidMicros = 3342096754779167220L,
                FinalUrlSuffix = "final_url_suffix046ed37a",
                EffectiveTargetCpaMicros = 9173558632194584770L,
                EffectiveTargetRoas = -5.789428044530098E+17,
                LabelsAsAdGroupLabelNames =
                {
                    gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[LABEL_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetAdGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroup response = client.GetAdGroup(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupAsync()
        {
            moq::Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new moq::Mock<AdGroupService.AdGroupServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupRequest request = new GetAdGroupRequest
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
            };
            gagvr::AdGroup expectedResponse = new gagvr::AdGroup
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Status = gagve::AdGroupStatusEnum.Types.AdGroupStatus.Removed,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                Type = gagve::AdGroupTypeEnum.Types.AdGroupType.VideoBumper,
                ExplorerAutoOptimizerSetting = new gagvc::ExplorerAutoOptimizerSetting(),
                AdRotationMode = gagve::AdGroupAdRotationModeEnum.Types.AdGroupAdRotationMode.Unspecified,
                DisplayCustomBidDimension = gagve::TargetingDimensionEnum.Types.TargetingDimension.AgeRange,
                TargetingSetting = new gagvc::TargetingSetting(),
                EffectiveTargetCpaSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unknown,
                EffectiveTargetRoasSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                Id = -6774108720365892680L,
                AdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                TargetCpaMicros = 5263516020894046876L,
                CpvBidMicros = 3393527949878021854L,
                TargetCpmMicros = 2683842186664132327L,
                TargetRoas = 1.0830159587289216E+18,
                PercentCpcBidMicros = 3342096754779167220L,
                FinalUrlSuffix = "final_url_suffix046ed37a",
                EffectiveTargetCpaMicros = 9173558632194584770L,
                EffectiveTargetRoas = -5.789428044530098E+17,
                LabelsAsAdGroupLabelNames =
                {
                    gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[LABEL_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroup responseCallSettings = await client.GetAdGroupAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroup responseCancellationToken = await client.GetAdGroupAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupResourceNames()
        {
            moq::Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new moq::Mock<AdGroupService.AdGroupServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupRequest request = new GetAdGroupRequest
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
            };
            gagvr::AdGroup expectedResponse = new gagvr::AdGroup
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Status = gagve::AdGroupStatusEnum.Types.AdGroupStatus.Removed,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                Type = gagve::AdGroupTypeEnum.Types.AdGroupType.VideoBumper,
                ExplorerAutoOptimizerSetting = new gagvc::ExplorerAutoOptimizerSetting(),
                AdRotationMode = gagve::AdGroupAdRotationModeEnum.Types.AdGroupAdRotationMode.Unspecified,
                DisplayCustomBidDimension = gagve::TargetingDimensionEnum.Types.TargetingDimension.AgeRange,
                TargetingSetting = new gagvc::TargetingSetting(),
                EffectiveTargetCpaSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unknown,
                EffectiveTargetRoasSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                Id = -6774108720365892680L,
                AdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                TargetCpaMicros = 5263516020894046876L,
                CpvBidMicros = 3393527949878021854L,
                TargetCpmMicros = 2683842186664132327L,
                TargetRoas = 1.0830159587289216E+18,
                PercentCpcBidMicros = 3342096754779167220L,
                FinalUrlSuffix = "final_url_suffix046ed37a",
                EffectiveTargetCpaMicros = 9173558632194584770L,
                EffectiveTargetRoas = -5.789428044530098E+17,
                LabelsAsAdGroupLabelNames =
                {
                    gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[LABEL_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetAdGroup(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroup response = client.GetAdGroup(request.ResourceNameAsAdGroupName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupResourceNamesAsync()
        {
            moq::Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new moq::Mock<AdGroupService.AdGroupServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupRequest request = new GetAdGroupRequest
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
            };
            gagvr::AdGroup expectedResponse = new gagvr::AdGroup
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                Status = gagve::AdGroupStatusEnum.Types.AdGroupStatus.Removed,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                Type = gagve::AdGroupTypeEnum.Types.AdGroupType.VideoBumper,
                ExplorerAutoOptimizerSetting = new gagvc::ExplorerAutoOptimizerSetting(),
                AdRotationMode = gagve::AdGroupAdRotationModeEnum.Types.AdGroupAdRotationMode.Unspecified,
                DisplayCustomBidDimension = gagve::TargetingDimensionEnum.Types.TargetingDimension.AgeRange,
                TargetingSetting = new gagvc::TargetingSetting(),
                EffectiveTargetCpaSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unknown,
                EffectiveTargetRoasSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                Id = -6774108720365892680L,
                AdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                TargetCpaMicros = 5263516020894046876L,
                CpvBidMicros = 3393527949878021854L,
                TargetCpmMicros = 2683842186664132327L,
                TargetRoas = 1.0830159587289216E+18,
                PercentCpcBidMicros = 3342096754779167220L,
                FinalUrlSuffix = "final_url_suffix046ed37a",
                EffectiveTargetCpaMicros = 9173558632194584770L,
                EffectiveTargetRoas = -5.789428044530098E+17,
                LabelsAsAdGroupLabelNames =
                {
                    gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[LABEL_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroup>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroup responseCallSettings = await client.GetAdGroupAsync(request.ResourceNameAsAdGroupName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroup responseCancellationToken = await client.GetAdGroupAsync(request.ResourceNameAsAdGroupName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupsRequestObject()
        {
            moq::Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new moq::Mock<AdGroupService.AdGroupServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupsRequest request = new MutateAdGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupsResponse expectedResponse = new MutateAdGroupsResponse
            {
                Results =
                {
                    new MutateAdGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroups(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupsResponse response = client.MutateAdGroups(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupsRequestObjectAsync()
        {
            moq::Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new moq::Mock<AdGroupService.AdGroupServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupsRequest request = new MutateAdGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupsResponse expectedResponse = new MutateAdGroupsResponse
            {
                Results =
                {
                    new MutateAdGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupsResponse responseCallSettings = await client.MutateAdGroupsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupsResponse responseCancellationToken = await client.MutateAdGroupsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroups()
        {
            moq::Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new moq::Mock<AdGroupService.AdGroupServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupsRequest request = new MutateAdGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupOperation(),
                },
            };
            MutateAdGroupsResponse expectedResponse = new MutateAdGroupsResponse
            {
                Results =
                {
                    new MutateAdGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroups(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupsResponse response = client.MutateAdGroups(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupsAsync()
        {
            moq::Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new moq::Mock<AdGroupService.AdGroupServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupsRequest request = new MutateAdGroupsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupOperation(),
                },
            };
            MutateAdGroupsResponse expectedResponse = new MutateAdGroupsResponse
            {
                Results =
                {
                    new MutateAdGroupResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupsResponse responseCallSettings = await client.MutateAdGroupsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupsResponse responseCancellationToken = await client.MutateAdGroupsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

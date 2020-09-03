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

using gagvc = Google.Ads.GoogleAds.V4.Common;
using gagve = Google.Ads.GoogleAds.V4.Enums;
using gagvr = Google.Ads.GoogleAds.V4.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V4.Services;

namespace Google.Ads.GoogleAds.Tests.V4.Services
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
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
            };
            gagvr::AdGroup expectedResponse = new gagvr::AdGroup
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Id = -6774108720365892680L,
                AdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::AdGroupStatusEnum.Types.AdGroupStatus.Removed,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Type = gagve::AdGroupTypeEnum.Types.AdGroupType.VideoBumper,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                CpvBidMicros = 3393527949878021854L,
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                PercentCpcBidMicros = 3342096754779167220L,
                ExplorerAutoOptimizerSetting = new gagvc::ExplorerAutoOptimizerSetting(),
                AdRotationMode = gagve::AdGroupAdRotationModeEnum.Types.AdGroupAdRotationMode.Unspecified,
                DisplayCustomBidDimension = gagve::TargetingDimensionEnum.Types.TargetingDimension.AgeRange,
                FinalUrlSuffix = "final_url_suffix046ed37a",
                TargetingSetting = new gagvc::TargetingSetting(),
                TargetCpmMicros = 2683842186664132327L,
                TargetCpaMicros = 5263516020894046876L,
                EffectiveTargetCpaMicros = 9173558632194584770L,
                EffectiveTargetCpaSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unknown,
                TargetRoas = 1.0830159587289216E+18,
                EffectiveTargetRoas = -5.789428044530098E+17,
                EffectiveTargetRoasSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                LabelsAsAdGroupLabelNames =
                {
                    gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
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
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
            };
            gagvr::AdGroup expectedResponse = new gagvr::AdGroup
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Id = -6774108720365892680L,
                AdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::AdGroupStatusEnum.Types.AdGroupStatus.Removed,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Type = gagve::AdGroupTypeEnum.Types.AdGroupType.VideoBumper,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                CpvBidMicros = 3393527949878021854L,
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                PercentCpcBidMicros = 3342096754779167220L,
                ExplorerAutoOptimizerSetting = new gagvc::ExplorerAutoOptimizerSetting(),
                AdRotationMode = gagve::AdGroupAdRotationModeEnum.Types.AdGroupAdRotationMode.Unspecified,
                DisplayCustomBidDimension = gagve::TargetingDimensionEnum.Types.TargetingDimension.AgeRange,
                FinalUrlSuffix = "final_url_suffix046ed37a",
                TargetingSetting = new gagvc::TargetingSetting(),
                TargetCpmMicros = 2683842186664132327L,
                TargetCpaMicros = 5263516020894046876L,
                EffectiveTargetCpaMicros = 9173558632194584770L,
                EffectiveTargetCpaSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unknown,
                TargetRoas = 1.0830159587289216E+18,
                EffectiveTargetRoas = -5.789428044530098E+17,
                EffectiveTargetRoasSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                LabelsAsAdGroupLabelNames =
                {
                    gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
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
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
            };
            gagvr::AdGroup expectedResponse = new gagvr::AdGroup
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Id = -6774108720365892680L,
                AdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::AdGroupStatusEnum.Types.AdGroupStatus.Removed,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Type = gagve::AdGroupTypeEnum.Types.AdGroupType.VideoBumper,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                CpvBidMicros = 3393527949878021854L,
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                PercentCpcBidMicros = 3342096754779167220L,
                ExplorerAutoOptimizerSetting = new gagvc::ExplorerAutoOptimizerSetting(),
                AdRotationMode = gagve::AdGroupAdRotationModeEnum.Types.AdGroupAdRotationMode.Unspecified,
                DisplayCustomBidDimension = gagve::TargetingDimensionEnum.Types.TargetingDimension.AgeRange,
                FinalUrlSuffix = "final_url_suffix046ed37a",
                TargetingSetting = new gagvc::TargetingSetting(),
                TargetCpmMicros = 2683842186664132327L,
                TargetCpaMicros = 5263516020894046876L,
                EffectiveTargetCpaMicros = 9173558632194584770L,
                EffectiveTargetCpaSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unknown,
                TargetRoas = 1.0830159587289216E+18,
                EffectiveTargetRoas = -5.789428044530098E+17,
                EffectiveTargetRoasSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                LabelsAsAdGroupLabelNames =
                {
                    gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
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
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
            };
            gagvr::AdGroup expectedResponse = new gagvr::AdGroup
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Id = -6774108720365892680L,
                AdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::AdGroupStatusEnum.Types.AdGroupStatus.Removed,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Type = gagve::AdGroupTypeEnum.Types.AdGroupType.VideoBumper,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                CpvBidMicros = 3393527949878021854L,
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                PercentCpcBidMicros = 3342096754779167220L,
                ExplorerAutoOptimizerSetting = new gagvc::ExplorerAutoOptimizerSetting(),
                AdRotationMode = gagve::AdGroupAdRotationModeEnum.Types.AdGroupAdRotationMode.Unspecified,
                DisplayCustomBidDimension = gagve::TargetingDimensionEnum.Types.TargetingDimension.AgeRange,
                FinalUrlSuffix = "final_url_suffix046ed37a",
                TargetingSetting = new gagvc::TargetingSetting(),
                TargetCpmMicros = 2683842186664132327L,
                TargetCpaMicros = 5263516020894046876L,
                EffectiveTargetCpaMicros = 9173558632194584770L,
                EffectiveTargetCpaSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unknown,
                TargetRoas = 1.0830159587289216E+18,
                EffectiveTargetRoas = -5.789428044530098E+17,
                EffectiveTargetRoasSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                LabelsAsAdGroupLabelNames =
                {
                    gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
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
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
            };
            gagvr::AdGroup expectedResponse = new gagvr::AdGroup
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Id = -6774108720365892680L,
                AdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::AdGroupStatusEnum.Types.AdGroupStatus.Removed,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Type = gagve::AdGroupTypeEnum.Types.AdGroupType.VideoBumper,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                CpvBidMicros = 3393527949878021854L,
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                PercentCpcBidMicros = 3342096754779167220L,
                ExplorerAutoOptimizerSetting = new gagvc::ExplorerAutoOptimizerSetting(),
                AdRotationMode = gagve::AdGroupAdRotationModeEnum.Types.AdGroupAdRotationMode.Unspecified,
                DisplayCustomBidDimension = gagve::TargetingDimensionEnum.Types.TargetingDimension.AgeRange,
                FinalUrlSuffix = "final_url_suffix046ed37a",
                TargetingSetting = new gagvc::TargetingSetting(),
                TargetCpmMicros = 2683842186664132327L,
                TargetCpaMicros = 5263516020894046876L,
                EffectiveTargetCpaMicros = 9173558632194584770L,
                EffectiveTargetCpaSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unknown,
                TargetRoas = 1.0830159587289216E+18,
                EffectiveTargetRoas = -5.789428044530098E+17,
                EffectiveTargetRoasSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                LabelsAsAdGroupLabelNames =
                {
                    gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
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
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
            };
            gagvr::AdGroup expectedResponse = new gagvr::AdGroup
            {
                ResourceNameAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Id = -6774108720365892680L,
                AdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::AdGroupStatusEnum.Types.AdGroupStatus.Removed,
                UrlCustomParameters =
                {
                    new gagvc::CustomParameter(),
                },
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER]", "[CAMPAIGN]"),
                Type = gagve::AdGroupTypeEnum.Types.AdGroupType.VideoBumper,
                TrackingUrlTemplate = "tracking_url_template157f152a",
                CpcBidMicros = 7321761304249472746L,
                CpmBidMicros = -6938481569984464040L,
                CpvBidMicros = 3393527949878021854L,
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                PercentCpcBidMicros = 3342096754779167220L,
                ExplorerAutoOptimizerSetting = new gagvc::ExplorerAutoOptimizerSetting(),
                AdRotationMode = gagve::AdGroupAdRotationModeEnum.Types.AdGroupAdRotationMode.Unspecified,
                DisplayCustomBidDimension = gagve::TargetingDimensionEnum.Types.TargetingDimension.AgeRange,
                FinalUrlSuffix = "final_url_suffix046ed37a",
                TargetingSetting = new gagvc::TargetingSetting(),
                TargetCpmMicros = 2683842186664132327L,
                TargetCpaMicros = 5263516020894046876L,
                EffectiveTargetCpaMicros = 9173558632194584770L,
                EffectiveTargetCpaSource = gagve::BiddingSourceEnum.Types.BiddingSource.Unknown,
                TargetRoas = 1.0830159587289216E+18,
                EffectiveTargetRoas = -5.789428044530098E+17,
                EffectiveTargetRoasSource = gagve::BiddingSourceEnum.Types.BiddingSource.AdGroupCriterion,
                LabelsAsAdGroupLabelNames =
                {
                    gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
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

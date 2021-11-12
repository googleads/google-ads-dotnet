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

using gagve = Google.Ads.GoogleAds.V9.Enums;
using gagvr = Google.Ads.GoogleAds.V9.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V9.Services;

namespace Google.Ads.GoogleAds.Tests.V9.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCampaignExtensionSettingServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCampaignExtensionSettingRequestObject()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCampaignExtensionSettingRequest request = new GetCampaignExtensionSettingRequest
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[EXTENSION_TYPE]"),
            };
            gagvr::CampaignExtensionSetting expectedResponse = new gagvr::CampaignExtensionSetting
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[EXTENSION_TYPE]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetCampaignExtensionSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExtensionSetting response = client.GetCampaignExtensionSetting(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignExtensionSettingRequestObjectAsync()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCampaignExtensionSettingRequest request = new GetCampaignExtensionSettingRequest
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[EXTENSION_TYPE]"),
            };
            gagvr::CampaignExtensionSetting expectedResponse = new gagvr::CampaignExtensionSetting
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[EXTENSION_TYPE]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetCampaignExtensionSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignExtensionSetting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExtensionSetting responseCallSettings = await client.GetCampaignExtensionSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignExtensionSetting responseCancellationToken = await client.GetCampaignExtensionSettingAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignExtensionSetting()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCampaignExtensionSettingRequest request = new GetCampaignExtensionSettingRequest
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[EXTENSION_TYPE]"),
            };
            gagvr::CampaignExtensionSetting expectedResponse = new gagvr::CampaignExtensionSetting
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[EXTENSION_TYPE]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetCampaignExtensionSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExtensionSetting response = client.GetCampaignExtensionSetting(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignExtensionSettingAsync()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCampaignExtensionSettingRequest request = new GetCampaignExtensionSettingRequest
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[EXTENSION_TYPE]"),
            };
            gagvr::CampaignExtensionSetting expectedResponse = new gagvr::CampaignExtensionSetting
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[EXTENSION_TYPE]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetCampaignExtensionSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignExtensionSetting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExtensionSetting responseCallSettings = await client.GetCampaignExtensionSettingAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignExtensionSetting responseCancellationToken = await client.GetCampaignExtensionSettingAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignExtensionSettingResourceNames()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCampaignExtensionSettingRequest request = new GetCampaignExtensionSettingRequest
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[EXTENSION_TYPE]"),
            };
            gagvr::CampaignExtensionSetting expectedResponse = new gagvr::CampaignExtensionSetting
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[EXTENSION_TYPE]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetCampaignExtensionSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExtensionSetting response = client.GetCampaignExtensionSetting(request.ResourceNameAsCampaignExtensionSettingName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignExtensionSettingResourceNamesAsync()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCampaignExtensionSettingRequest request = new GetCampaignExtensionSettingRequest
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[EXTENSION_TYPE]"),
            };
            gagvr::CampaignExtensionSetting expectedResponse = new gagvr::CampaignExtensionSetting
            {
                ResourceNameAsCampaignExtensionSettingName = gagvr::CampaignExtensionSettingName.FromCustomerCampaignExtensionType("[CUSTOMER_ID]", "[CAMPAIGN_ID]", "[EXTENSION_TYPE]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
                CampaignAsCampaignName = gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetCampaignExtensionSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignExtensionSetting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignExtensionSetting responseCallSettings = await client.GetCampaignExtensionSettingAsync(request.ResourceNameAsCampaignExtensionSettingName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignExtensionSetting responseCancellationToken = await client.GetCampaignExtensionSettingAsync(request.ResourceNameAsCampaignExtensionSettingName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignExtensionSettingsRequestObject()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignExtensionSettingsRequest request = new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignExtensionSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignExtensionSettingsResponse expectedResponse = new MutateCampaignExtensionSettingsResponse
            {
                Results =
                {
                    new MutateCampaignExtensionSettingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignExtensionSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignExtensionSettingsResponse response = client.MutateCampaignExtensionSettings(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignExtensionSettingsRequestObjectAsync()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignExtensionSettingsRequest request = new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignExtensionSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignExtensionSettingsResponse expectedResponse = new MutateCampaignExtensionSettingsResponse
            {
                Results =
                {
                    new MutateCampaignExtensionSettingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignExtensionSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignExtensionSettingsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignExtensionSettingsResponse responseCallSettings = await client.MutateCampaignExtensionSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignExtensionSettingsResponse responseCancellationToken = await client.MutateCampaignExtensionSettingsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignExtensionSettings()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignExtensionSettingsRequest request = new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignExtensionSettingOperation(),
                },
            };
            MutateCampaignExtensionSettingsResponse expectedResponse = new MutateCampaignExtensionSettingsResponse
            {
                Results =
                {
                    new MutateCampaignExtensionSettingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignExtensionSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignExtensionSettingsResponse response = client.MutateCampaignExtensionSettings(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignExtensionSettingsAsync()
        {
            moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignExtensionSettingsRequest request = new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignExtensionSettingOperation(),
                },
            };
            MutateCampaignExtensionSettingsResponse expectedResponse = new MutateCampaignExtensionSettingsResponse
            {
                Results =
                {
                    new MutateCampaignExtensionSettingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignExtensionSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignExtensionSettingsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignExtensionSettingsResponse responseCallSettings = await client.MutateCampaignExtensionSettingsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignExtensionSettingsResponse responseCancellationToken = await client.MutateCampaignExtensionSettingsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

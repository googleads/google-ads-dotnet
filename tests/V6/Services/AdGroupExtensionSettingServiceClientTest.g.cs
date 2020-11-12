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
    public sealed class GeneratedAdGroupExtensionSettingServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAdGroupExtensionSettingRequestObject()
        {
            moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupExtensionSettingRequest request = new GetAdGroupExtensionSettingRequest
            {
                ResourceNameAsAdGroupExtensionSettingName = gagvr::AdGroupExtensionSettingName.FromCustomerAdGroupExtensionType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[EXTENSION_TYPE]"),
            };
            gagvr::AdGroupExtensionSetting expectedResponse = new gagvr::AdGroupExtensionSetting
            {
                ResourceNameAsAdGroupExtensionSettingName = gagvr::AdGroupExtensionSettingName.FromCustomerAdGroupExtensionType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[EXTENSION_TYPE]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetAdGroupExtensionSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupExtensionSetting response = client.GetAdGroupExtensionSetting(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupExtensionSettingRequestObjectAsync()
        {
            moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupExtensionSettingRequest request = new GetAdGroupExtensionSettingRequest
            {
                ResourceNameAsAdGroupExtensionSettingName = gagvr::AdGroupExtensionSettingName.FromCustomerAdGroupExtensionType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[EXTENSION_TYPE]"),
            };
            gagvr::AdGroupExtensionSetting expectedResponse = new gagvr::AdGroupExtensionSetting
            {
                ResourceNameAsAdGroupExtensionSettingName = gagvr::AdGroupExtensionSettingName.FromCustomerAdGroupExtensionType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[EXTENSION_TYPE]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetAdGroupExtensionSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupExtensionSetting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupExtensionSetting responseCallSettings = await client.GetAdGroupExtensionSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupExtensionSetting responseCancellationToken = await client.GetAdGroupExtensionSettingAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupExtensionSetting()
        {
            moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupExtensionSettingRequest request = new GetAdGroupExtensionSettingRequest
            {
                ResourceNameAsAdGroupExtensionSettingName = gagvr::AdGroupExtensionSettingName.FromCustomerAdGroupExtensionType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[EXTENSION_TYPE]"),
            };
            gagvr::AdGroupExtensionSetting expectedResponse = new gagvr::AdGroupExtensionSetting
            {
                ResourceNameAsAdGroupExtensionSettingName = gagvr::AdGroupExtensionSettingName.FromCustomerAdGroupExtensionType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[EXTENSION_TYPE]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetAdGroupExtensionSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupExtensionSetting response = client.GetAdGroupExtensionSetting(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupExtensionSettingAsync()
        {
            moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupExtensionSettingRequest request = new GetAdGroupExtensionSettingRequest
            {
                ResourceNameAsAdGroupExtensionSettingName = gagvr::AdGroupExtensionSettingName.FromCustomerAdGroupExtensionType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[EXTENSION_TYPE]"),
            };
            gagvr::AdGroupExtensionSetting expectedResponse = new gagvr::AdGroupExtensionSetting
            {
                ResourceNameAsAdGroupExtensionSettingName = gagvr::AdGroupExtensionSettingName.FromCustomerAdGroupExtensionType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[EXTENSION_TYPE]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetAdGroupExtensionSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupExtensionSetting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupExtensionSetting responseCallSettings = await client.GetAdGroupExtensionSettingAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupExtensionSetting responseCancellationToken = await client.GetAdGroupExtensionSettingAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupExtensionSettingResourceNames()
        {
            moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupExtensionSettingRequest request = new GetAdGroupExtensionSettingRequest
            {
                ResourceNameAsAdGroupExtensionSettingName = gagvr::AdGroupExtensionSettingName.FromCustomerAdGroupExtensionType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[EXTENSION_TYPE]"),
            };
            gagvr::AdGroupExtensionSetting expectedResponse = new gagvr::AdGroupExtensionSetting
            {
                ResourceNameAsAdGroupExtensionSettingName = gagvr::AdGroupExtensionSettingName.FromCustomerAdGroupExtensionType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[EXTENSION_TYPE]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetAdGroupExtensionSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupExtensionSetting response = client.GetAdGroupExtensionSetting(request.ResourceNameAsAdGroupExtensionSettingName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupExtensionSettingResourceNamesAsync()
        {
            moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupExtensionSettingRequest request = new GetAdGroupExtensionSettingRequest
            {
                ResourceNameAsAdGroupExtensionSettingName = gagvr::AdGroupExtensionSettingName.FromCustomerAdGroupExtensionType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[EXTENSION_TYPE]"),
            };
            gagvr::AdGroupExtensionSetting expectedResponse = new gagvr::AdGroupExtensionSetting
            {
                ResourceNameAsAdGroupExtensionSettingName = gagvr::AdGroupExtensionSettingName.FromCustomerAdGroupExtensionType("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[EXTENSION_TYPE]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerFeedItem("[CUSTOMER_ID]", "[FEED_ITEM_ID]"),
                },
            };
            mockGrpcClient.Setup(x => x.GetAdGroupExtensionSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupExtensionSetting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupExtensionSetting responseCallSettings = await client.GetAdGroupExtensionSettingAsync(request.ResourceNameAsAdGroupExtensionSettingName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupExtensionSetting responseCancellationToken = await client.GetAdGroupExtensionSettingAsync(request.ResourceNameAsAdGroupExtensionSettingName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupExtensionSettingsRequestObject()
        {
            moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupExtensionSettingsRequest request = new MutateAdGroupExtensionSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupExtensionSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateAdGroupExtensionSettingsResponse expectedResponse = new MutateAdGroupExtensionSettingsResponse
            {
                Results =
                {
                    new MutateAdGroupExtensionSettingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupExtensionSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupExtensionSettingsResponse response = client.MutateAdGroupExtensionSettings(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupExtensionSettingsRequestObjectAsync()
        {
            moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupExtensionSettingsRequest request = new MutateAdGroupExtensionSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupExtensionSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateAdGroupExtensionSettingsResponse expectedResponse = new MutateAdGroupExtensionSettingsResponse
            {
                Results =
                {
                    new MutateAdGroupExtensionSettingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupExtensionSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupExtensionSettingsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupExtensionSettingsResponse responseCallSettings = await client.MutateAdGroupExtensionSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupExtensionSettingsResponse responseCancellationToken = await client.MutateAdGroupExtensionSettingsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupExtensionSettings()
        {
            moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupExtensionSettingsRequest request = new MutateAdGroupExtensionSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupExtensionSettingOperation(),
                },
            };
            MutateAdGroupExtensionSettingsResponse expectedResponse = new MutateAdGroupExtensionSettingsResponse
            {
                Results =
                {
                    new MutateAdGroupExtensionSettingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupExtensionSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupExtensionSettingsResponse response = client.MutateAdGroupExtensionSettings(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupExtensionSettingsAsync()
        {
            moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupExtensionSettingsRequest request = new MutateAdGroupExtensionSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupExtensionSettingOperation(),
                },
            };
            MutateAdGroupExtensionSettingsResponse expectedResponse = new MutateAdGroupExtensionSettingsResponse
            {
                Results =
                {
                    new MutateAdGroupExtensionSettingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupExtensionSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupExtensionSettingsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupExtensionSettingsResponse responseCallSettings = await client.MutateAdGroupExtensionSettingsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupExtensionSettingsResponse responseCancellationToken = await client.MutateAdGroupExtensionSettingsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

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
    public sealed class GeneratedCustomerExtensionSettingServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCustomerExtensionSettingRequestObject()
        {
            moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCustomerExtensionSettingRequest request = new GetCustomerExtensionSettingRequest
            {
                ResourceNameAsCustomerExtensionSettingName = gagvr::CustomerExtensionSettingName.FromCustomerCustomerExtensionSetting("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]"),
            };
            gagvr::CustomerExtensionSetting expectedResponse = new gagvr::CustomerExtensionSetting
            {
                ResourceNameAsCustomerExtensionSettingName = gagvr::CustomerExtensionSettingName.FromCustomerCustomerExtensionSetting("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerExtensionFeedItem("[CUSTOMER]", "[EXTENSION_FEED_ITEM]"),
                },
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetCustomerExtensionSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerExtensionSetting response = client.GetCustomerExtensionSetting(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerExtensionSettingRequestObjectAsync()
        {
            moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCustomerExtensionSettingRequest request = new GetCustomerExtensionSettingRequest
            {
                ResourceNameAsCustomerExtensionSettingName = gagvr::CustomerExtensionSettingName.FromCustomerCustomerExtensionSetting("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]"),
            };
            gagvr::CustomerExtensionSetting expectedResponse = new gagvr::CustomerExtensionSetting
            {
                ResourceNameAsCustomerExtensionSettingName = gagvr::CustomerExtensionSettingName.FromCustomerCustomerExtensionSetting("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerExtensionFeedItem("[CUSTOMER]", "[EXTENSION_FEED_ITEM]"),
                },
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetCustomerExtensionSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerExtensionSetting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerExtensionSetting responseCallSettings = await client.GetCustomerExtensionSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerExtensionSetting responseCancellationToken = await client.GetCustomerExtensionSettingAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCustomerExtensionSetting()
        {
            moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCustomerExtensionSettingRequest request = new GetCustomerExtensionSettingRequest
            {
                ResourceNameAsCustomerExtensionSettingName = gagvr::CustomerExtensionSettingName.FromCustomerCustomerExtensionSetting("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]"),
            };
            gagvr::CustomerExtensionSetting expectedResponse = new gagvr::CustomerExtensionSetting
            {
                ResourceNameAsCustomerExtensionSettingName = gagvr::CustomerExtensionSettingName.FromCustomerCustomerExtensionSetting("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerExtensionFeedItem("[CUSTOMER]", "[EXTENSION_FEED_ITEM]"),
                },
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetCustomerExtensionSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerExtensionSetting response = client.GetCustomerExtensionSetting(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerExtensionSettingAsync()
        {
            moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCustomerExtensionSettingRequest request = new GetCustomerExtensionSettingRequest
            {
                ResourceNameAsCustomerExtensionSettingName = gagvr::CustomerExtensionSettingName.FromCustomerCustomerExtensionSetting("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]"),
            };
            gagvr::CustomerExtensionSetting expectedResponse = new gagvr::CustomerExtensionSetting
            {
                ResourceNameAsCustomerExtensionSettingName = gagvr::CustomerExtensionSettingName.FromCustomerCustomerExtensionSetting("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerExtensionFeedItem("[CUSTOMER]", "[EXTENSION_FEED_ITEM]"),
                },
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetCustomerExtensionSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerExtensionSetting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerExtensionSetting responseCallSettings = await client.GetCustomerExtensionSettingAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerExtensionSetting responseCancellationToken = await client.GetCustomerExtensionSettingAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCustomerExtensionSettingResourceNames()
        {
            moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCustomerExtensionSettingRequest request = new GetCustomerExtensionSettingRequest
            {
                ResourceNameAsCustomerExtensionSettingName = gagvr::CustomerExtensionSettingName.FromCustomerCustomerExtensionSetting("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]"),
            };
            gagvr::CustomerExtensionSetting expectedResponse = new gagvr::CustomerExtensionSetting
            {
                ResourceNameAsCustomerExtensionSettingName = gagvr::CustomerExtensionSettingName.FromCustomerCustomerExtensionSetting("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerExtensionFeedItem("[CUSTOMER]", "[EXTENSION_FEED_ITEM]"),
                },
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetCustomerExtensionSetting(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerExtensionSetting response = client.GetCustomerExtensionSetting(request.ResourceNameAsCustomerExtensionSettingName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerExtensionSettingResourceNamesAsync()
        {
            moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            GetCustomerExtensionSettingRequest request = new GetCustomerExtensionSettingRequest
            {
                ResourceNameAsCustomerExtensionSettingName = gagvr::CustomerExtensionSettingName.FromCustomerCustomerExtensionSetting("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]"),
            };
            gagvr::CustomerExtensionSetting expectedResponse = new gagvr::CustomerExtensionSetting
            {
                ResourceNameAsCustomerExtensionSettingName = gagvr::CustomerExtensionSettingName.FromCustomerCustomerExtensionSetting("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]"),
                ExtensionType = gagve::ExtensionTypeEnum.Types.ExtensionType.Promotion,
                ExtensionFeedItemsAsExtensionFeedItemNames =
                {
                    gagvr::ExtensionFeedItemName.FromCustomerExtensionFeedItem("[CUSTOMER]", "[EXTENSION_FEED_ITEM]"),
                },
                Device = gagve::ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unknown,
            };
            mockGrpcClient.Setup(x => x.GetCustomerExtensionSettingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerExtensionSetting>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerExtensionSetting responseCallSettings = await client.GetCustomerExtensionSettingAsync(request.ResourceNameAsCustomerExtensionSettingName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerExtensionSetting responseCancellationToken = await client.GetCustomerExtensionSettingAsync(request.ResourceNameAsCustomerExtensionSettingName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomerExtensionSettingsRequestObject()
        {
            moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerExtensionSettingsRequest request = new MutateCustomerExtensionSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerExtensionSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCustomerExtensionSettingsResponse expectedResponse = new MutateCustomerExtensionSettingsResponse
            {
                Results =
                {
                    new MutateCustomerExtensionSettingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerExtensionSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerExtensionSettingsResponse response = client.MutateCustomerExtensionSettings(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerExtensionSettingsRequestObjectAsync()
        {
            moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerExtensionSettingsRequest request = new MutateCustomerExtensionSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerExtensionSettingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCustomerExtensionSettingsResponse expectedResponse = new MutateCustomerExtensionSettingsResponse
            {
                Results =
                {
                    new MutateCustomerExtensionSettingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerExtensionSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerExtensionSettingsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerExtensionSettingsResponse responseCallSettings = await client.MutateCustomerExtensionSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerExtensionSettingsResponse responseCancellationToken = await client.MutateCustomerExtensionSettingsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomerExtensionSettings()
        {
            moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerExtensionSettingsRequest request = new MutateCustomerExtensionSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerExtensionSettingOperation(),
                },
            };
            MutateCustomerExtensionSettingsResponse expectedResponse = new MutateCustomerExtensionSettingsResponse
            {
                Results =
                {
                    new MutateCustomerExtensionSettingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerExtensionSettings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerExtensionSettingsResponse response = client.MutateCustomerExtensionSettings(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerExtensionSettingsAsync()
        {
            moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new moq::Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerExtensionSettingsRequest request = new MutateCustomerExtensionSettingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerExtensionSettingOperation(),
                },
            };
            MutateCustomerExtensionSettingsResponse expectedResponse = new MutateCustomerExtensionSettingsResponse
            {
                Results =
                {
                    new MutateCustomerExtensionSettingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerExtensionSettingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerExtensionSettingsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerExtensionSettingsResponse responseCallSettings = await client.MutateCustomerExtensionSettingsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerExtensionSettingsResponse responseCancellationToken = await client.MutateCustomerExtensionSettingsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

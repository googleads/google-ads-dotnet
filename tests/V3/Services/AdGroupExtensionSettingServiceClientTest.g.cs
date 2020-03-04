// Copyright 2019 Google LLC
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

namespace Google.Ads.GoogleAds.V3.Services.Tests
{
    using Google.Ads.GoogleAds.V3.Resources;
    using apis = Google.Ads.GoogleAds.V3.Services;
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using NUnit.Framework;

    /// <summary>Generated unit tests</summary>
    public class GeneratedAdGroupExtensionSettingServiceClientTest
    {
        [Test]
        public void GetAdGroupExtensionSetting()
        {
            Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(MockBehavior.Strict);
            GetAdGroupExtensionSettingRequest expectedRequest = new GetAdGroupExtensionSettingRequest
            {
                ResourceName = new AdGroupExtensionSettingName("[CUSTOMER]", "[AD_GROUP_EXTENSION_SETTING]").ToString(),
            };
            AdGroupExtensionSetting expectedResponse = new AdGroupExtensionSetting
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupExtensionSetting(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupExtensionSettingName("[CUSTOMER]", "[AD_GROUP_EXTENSION_SETTING]").ToString();
            AdGroupExtensionSetting response = client.GetAdGroupExtensionSetting(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupExtensionSettingAsync()
        {
            Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(MockBehavior.Strict);
            GetAdGroupExtensionSettingRequest expectedRequest = new GetAdGroupExtensionSettingRequest
            {
                ResourceName = new AdGroupExtensionSettingName("[CUSTOMER]", "[AD_GROUP_EXTENSION_SETTING]").ToString(),
            };
            AdGroupExtensionSetting expectedResponse = new AdGroupExtensionSetting
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupExtensionSettingAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupExtensionSetting>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupExtensionSettingName("[CUSTOMER]", "[AD_GROUP_EXTENSION_SETTING]").ToString();
            AdGroupExtensionSetting response = await client.GetAdGroupExtensionSettingAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroupExtensionSetting2()
        {
            Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(MockBehavior.Strict);
            GetAdGroupExtensionSettingRequest request = new GetAdGroupExtensionSettingRequest
            {
                ResourceName = new AdGroupExtensionSettingName("[CUSTOMER]", "[AD_GROUP_EXTENSION_SETTING]").ToString(),
            };
            AdGroupExtensionSetting expectedResponse = new AdGroupExtensionSetting
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupExtensionSetting(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupExtensionSetting response = client.GetAdGroupExtensionSetting(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupExtensionSettingAsync2()
        {
            Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(MockBehavior.Strict);
            GetAdGroupExtensionSettingRequest request = new GetAdGroupExtensionSettingRequest
            {
                ResourceName = new AdGroupExtensionSettingName("[CUSTOMER]", "[AD_GROUP_EXTENSION_SETTING]").ToString(),
            };
            AdGroupExtensionSetting expectedResponse = new AdGroupExtensionSetting
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupExtensionSettingAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupExtensionSetting>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            AdGroupExtensionSetting response = await client.GetAdGroupExtensionSettingAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupExtensionSettings()
        {
            Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateAdGroupExtensionSettingsRequest expectedRequest = new MutateAdGroupExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdGroupExtensionSettingsResponse expectedResponse = new MutateAdGroupExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupExtensionSettings(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupExtensionSettingOperation> operations = new List<AdGroupExtensionSettingOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdGroupExtensionSettingsResponse response = client.MutateAdGroupExtensionSettings(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupExtensionSettingsAsync()
        {
            Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateAdGroupExtensionSettingsRequest expectedRequest = new MutateAdGroupExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdGroupExtensionSettingsResponse expectedResponse = new MutateAdGroupExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupExtensionSettingsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupExtensionSettingsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupExtensionSettingOperation> operations = new List<AdGroupExtensionSettingOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdGroupExtensionSettingsResponse response = await client.MutateAdGroupExtensionSettingsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupExtensionSettings2()
        {
            Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateAdGroupExtensionSettingsRequest expectedRequest = new MutateAdGroupExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupExtensionSettingsResponse expectedResponse = new MutateAdGroupExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupExtensionSettings(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupExtensionSettingOperation> operations = new List<AdGroupExtensionSettingOperation>();
            MutateAdGroupExtensionSettingsResponse response = client.MutateAdGroupExtensionSettings(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupExtensionSettingsAsync2()
        {
            Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateAdGroupExtensionSettingsRequest expectedRequest = new MutateAdGroupExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupExtensionSettingsResponse expectedResponse = new MutateAdGroupExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupExtensionSettingsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupExtensionSettingsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupExtensionSettingOperation> operations = new List<AdGroupExtensionSettingOperation>();
            MutateAdGroupExtensionSettingsResponse response = await client.MutateAdGroupExtensionSettingsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroupExtensionSettings3()
        {
            Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateAdGroupExtensionSettingsRequest request = new MutateAdGroupExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupExtensionSettingsResponse expectedResponse = new MutateAdGroupExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupExtensionSettings(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupExtensionSettingsResponse response = client.MutateAdGroupExtensionSettings(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupExtensionSettingsAsync3()
        {
            Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient> mockGrpcClient = new Mock<AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateAdGroupExtensionSettingsRequest request = new MutateAdGroupExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupExtensionSettingsResponse expectedResponse = new MutateAdGroupExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupExtensionSettingsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupExtensionSettingsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupExtensionSettingServiceClient client = new AdGroupExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupExtensionSettingsResponse response = await client.MutateAdGroupExtensionSettingsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

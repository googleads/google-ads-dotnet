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

namespace Google.Ads.GoogleAds.V1.Services.Tests
{
    using Google.Ads.GoogleAds.V1.Resources;
    using apis = Google.Ads.GoogleAds.V1.Services;
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
    public class GeneratedCampaignExtensionSettingServiceClientTest
    {
        [Test]
        public void GetCampaignExtensionSetting()
        {
            Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(MockBehavior.Strict);
            GetCampaignExtensionSettingRequest expectedRequest = new GetCampaignExtensionSettingRequest
            {
                ResourceName = new CampaignExtensionSettingName("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]").ToString(),
            };
            CampaignExtensionSetting expectedResponse = new CampaignExtensionSetting
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignExtensionSetting(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignExtensionSettingName("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]").ToString();
            CampaignExtensionSetting response = client.GetCampaignExtensionSetting(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignExtensionSettingAsync()
        {
            Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(MockBehavior.Strict);
            GetCampaignExtensionSettingRequest expectedRequest = new GetCampaignExtensionSettingRequest
            {
                ResourceName = new CampaignExtensionSettingName("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]").ToString(),
            };
            CampaignExtensionSetting expectedResponse = new CampaignExtensionSetting
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignExtensionSettingAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignExtensionSetting>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignExtensionSettingName("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]").ToString();
            CampaignExtensionSetting response = await client.GetCampaignExtensionSettingAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaignExtensionSetting2()
        {
            Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(MockBehavior.Strict);
            GetCampaignExtensionSettingRequest request = new GetCampaignExtensionSettingRequest
            {
                ResourceName = new CampaignExtensionSettingName("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]").ToString(),
            };
            CampaignExtensionSetting expectedResponse = new CampaignExtensionSetting
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignExtensionSetting(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            CampaignExtensionSetting response = client.GetCampaignExtensionSetting(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignExtensionSettingAsync2()
        {
            Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(MockBehavior.Strict);
            GetCampaignExtensionSettingRequest request = new GetCampaignExtensionSettingRequest
            {
                ResourceName = new CampaignExtensionSettingName("[CUSTOMER]", "[CAMPAIGN_EXTENSION_SETTING]").ToString(),
            };
            CampaignExtensionSetting expectedResponse = new CampaignExtensionSetting
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignExtensionSettingAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignExtensionSetting>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            CampaignExtensionSetting response = await client.GetCampaignExtensionSettingAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignExtensionSettings()
        {
            Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateCampaignExtensionSettingsRequest expectedRequest = new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCampaignExtensionSettingsResponse expectedResponse = new MutateCampaignExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignExtensionSettings(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignExtensionSettingOperation> operations = new List<CampaignExtensionSettingOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCampaignExtensionSettingsResponse response = client.MutateCampaignExtensionSettings(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignExtensionSettingsAsync()
        {
            Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateCampaignExtensionSettingsRequest expectedRequest = new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCampaignExtensionSettingsResponse expectedResponse = new MutateCampaignExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignExtensionSettingsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignExtensionSettingsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignExtensionSettingOperation> operations = new List<CampaignExtensionSettingOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCampaignExtensionSettingsResponse response = await client.MutateCampaignExtensionSettingsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignExtensionSettings2()
        {
            Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateCampaignExtensionSettingsRequest expectedRequest = new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignExtensionSettingsResponse expectedResponse = new MutateCampaignExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignExtensionSettings(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignExtensionSettingOperation> operations = new List<CampaignExtensionSettingOperation>();
            MutateCampaignExtensionSettingsResponse response = client.MutateCampaignExtensionSettings(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignExtensionSettingsAsync2()
        {
            Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateCampaignExtensionSettingsRequest expectedRequest = new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignExtensionSettingsResponse expectedResponse = new MutateCampaignExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignExtensionSettingsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignExtensionSettingsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignExtensionSettingOperation> operations = new List<CampaignExtensionSettingOperation>();
            MutateCampaignExtensionSettingsResponse response = await client.MutateCampaignExtensionSettingsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignExtensionSettings3()
        {
            Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateCampaignExtensionSettingsRequest request = new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignExtensionSettingsResponse expectedResponse = new MutateCampaignExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignExtensionSettings(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignExtensionSettingsResponse response = client.MutateCampaignExtensionSettings(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignExtensionSettingsAsync3()
        {
            Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient> mockGrpcClient = new Mock<CampaignExtensionSettingService.CampaignExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateCampaignExtensionSettingsRequest request = new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignExtensionSettingsResponse expectedResponse = new MutateCampaignExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignExtensionSettingsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignExtensionSettingsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignExtensionSettingServiceClient client = new CampaignExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignExtensionSettingsResponse response = await client.MutateCampaignExtensionSettingsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

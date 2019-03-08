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
    public class GeneratedCustomerExtensionSettingServiceClientTest
    {
        [Test]
        public void GetCustomerExtensionSetting()
        {
            Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(MockBehavior.Strict);
            GetCustomerExtensionSettingRequest expectedRequest = new GetCustomerExtensionSettingRequest
            {
                ResourceName = new CustomerExtensionSettingName("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]").ToString(),
            };
            CustomerExtensionSetting expectedResponse = new CustomerExtensionSetting
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerExtensionSetting(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerExtensionSettingName("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]").ToString();
            CustomerExtensionSetting response = client.GetCustomerExtensionSetting(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerExtensionSettingAsync()
        {
            Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(MockBehavior.Strict);
            GetCustomerExtensionSettingRequest expectedRequest = new GetCustomerExtensionSettingRequest
            {
                ResourceName = new CustomerExtensionSettingName("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]").ToString(),
            };
            CustomerExtensionSetting expectedResponse = new CustomerExtensionSetting
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerExtensionSettingAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CustomerExtensionSetting>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CustomerExtensionSettingName("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]").ToString();
            CustomerExtensionSetting response = await client.GetCustomerExtensionSettingAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCustomerExtensionSetting2()
        {
            Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(MockBehavior.Strict);
            GetCustomerExtensionSettingRequest request = new GetCustomerExtensionSettingRequest
            {
                ResourceName = new CustomerExtensionSettingName("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]").ToString(),
            };
            CustomerExtensionSetting expectedResponse = new CustomerExtensionSetting
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerExtensionSetting(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            CustomerExtensionSetting response = client.GetCustomerExtensionSetting(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCustomerExtensionSettingAsync2()
        {
            Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(MockBehavior.Strict);
            GetCustomerExtensionSettingRequest request = new GetCustomerExtensionSettingRequest
            {
                ResourceName = new CustomerExtensionSettingName("[CUSTOMER]", "[CUSTOMER_EXTENSION_SETTING]").ToString(),
            };
            CustomerExtensionSetting expectedResponse = new CustomerExtensionSetting
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCustomerExtensionSettingAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CustomerExtensionSetting>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            CustomerExtensionSetting response = await client.GetCustomerExtensionSettingAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerExtensionSettings()
        {
            Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateCustomerExtensionSettingsRequest expectedRequest = new MutateCustomerExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCustomerExtensionSettingsResponse expectedResponse = new MutateCustomerExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerExtensionSettings(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerExtensionSettingOperation> operations = new List<CustomerExtensionSettingOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCustomerExtensionSettingsResponse response = client.MutateCustomerExtensionSettings(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomerExtensionSettingsAsync()
        {
            Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateCustomerExtensionSettingsRequest expectedRequest = new MutateCustomerExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateCustomerExtensionSettingsResponse expectedResponse = new MutateCustomerExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerExtensionSettingsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomerExtensionSettingsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerExtensionSettingOperation> operations = new List<CustomerExtensionSettingOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateCustomerExtensionSettingsResponse response = await client.MutateCustomerExtensionSettingsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerExtensionSettings2()
        {
            Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateCustomerExtensionSettingsRequest expectedRequest = new MutateCustomerExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerExtensionSettingsResponse expectedResponse = new MutateCustomerExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerExtensionSettings(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerExtensionSettingOperation> operations = new List<CustomerExtensionSettingOperation>();
            MutateCustomerExtensionSettingsResponse response = client.MutateCustomerExtensionSettings(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomerExtensionSettingsAsync2()
        {
            Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateCustomerExtensionSettingsRequest expectedRequest = new MutateCustomerExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerExtensionSettingsResponse expectedResponse = new MutateCustomerExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerExtensionSettingsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomerExtensionSettingsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CustomerExtensionSettingOperation> operations = new List<CustomerExtensionSettingOperation>();
            MutateCustomerExtensionSettingsResponse response = await client.MutateCustomerExtensionSettingsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerExtensionSettings3()
        {
            Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateCustomerExtensionSettingsRequest request = new MutateCustomerExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerExtensionSettingsResponse expectedResponse = new MutateCustomerExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerExtensionSettings(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerExtensionSettingsResponse response = client.MutateCustomerExtensionSettings(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCustomerExtensionSettingsAsync3()
        {
            Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient> mockGrpcClient = new Mock<CustomerExtensionSettingService.CustomerExtensionSettingServiceClient>(MockBehavior.Strict);
            MutateCustomerExtensionSettingsRequest request = new MutateCustomerExtensionSettingsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCustomerExtensionSettingsResponse expectedResponse = new MutateCustomerExtensionSettingsResponse();
            mockGrpcClient.Setup(x => x.MutateCustomerExtensionSettingsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCustomerExtensionSettingsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CustomerExtensionSettingServiceClient client = new CustomerExtensionSettingServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerExtensionSettingsResponse response = await client.MutateCustomerExtensionSettingsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

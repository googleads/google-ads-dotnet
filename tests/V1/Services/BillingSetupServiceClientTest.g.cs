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
    public class GeneratedBillingSetupServiceClientTest
    {
        [Test]
        public void GetBillingSetup()
        {
            Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new Mock<BillingSetupService.BillingSetupServiceClient>(MockBehavior.Strict);
            GetBillingSetupRequest expectedRequest = new GetBillingSetupRequest
            {
                ResourceName = new BillingSetupName("[CUSTOMER]", "[BILLING_SETUP]").ToString(),
            };
            BillingSetup expectedResponse = new BillingSetup
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetBillingSetup(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new BillingSetupName("[CUSTOMER]", "[BILLING_SETUP]").ToString();
            BillingSetup response = client.GetBillingSetup(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetBillingSetupAsync()
        {
            Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new Mock<BillingSetupService.BillingSetupServiceClient>(MockBehavior.Strict);
            GetBillingSetupRequest expectedRequest = new GetBillingSetupRequest
            {
                ResourceName = new BillingSetupName("[CUSTOMER]", "[BILLING_SETUP]").ToString(),
            };
            BillingSetup expectedResponse = new BillingSetup
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetBillingSetupAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<BillingSetup>(Task.FromResult(expectedResponse), null, null, null, null));
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new BillingSetupName("[CUSTOMER]", "[BILLING_SETUP]").ToString();
            BillingSetup response = await client.GetBillingSetupAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetBillingSetup2()
        {
            Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new Mock<BillingSetupService.BillingSetupServiceClient>(MockBehavior.Strict);
            GetBillingSetupRequest request = new GetBillingSetupRequest
            {
                ResourceName = new BillingSetupName("[CUSTOMER]", "[BILLING_SETUP]").ToString(),
            };
            BillingSetup expectedResponse = new BillingSetup
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetBillingSetup(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            BillingSetup response = client.GetBillingSetup(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetBillingSetupAsync2()
        {
            Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new Mock<BillingSetupService.BillingSetupServiceClient>(MockBehavior.Strict);
            GetBillingSetupRequest request = new GetBillingSetupRequest
            {
                ResourceName = new BillingSetupName("[CUSTOMER]", "[BILLING_SETUP]").ToString(),
            };
            BillingSetup expectedResponse = new BillingSetup
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetBillingSetupAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<BillingSetup>(Task.FromResult(expectedResponse), null, null, null, null));
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            BillingSetup response = await client.GetBillingSetupAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateBillingSetup()
        {
            Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new Mock<BillingSetupService.BillingSetupServiceClient>(MockBehavior.Strict);
            MutateBillingSetupRequest expectedRequest = new MutateBillingSetupRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new BillingSetupOperation(),
            };
            MutateBillingSetupResponse expectedResponse = new MutateBillingSetupResponse();
            mockGrpcClient.Setup(x => x.MutateBillingSetup(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            BillingSetupOperation operation = new BillingSetupOperation();
            MutateBillingSetupResponse response = client.MutateBillingSetup(customerId, operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateBillingSetupAsync()
        {
            Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new Mock<BillingSetupService.BillingSetupServiceClient>(MockBehavior.Strict);
            MutateBillingSetupRequest expectedRequest = new MutateBillingSetupRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new BillingSetupOperation(),
            };
            MutateBillingSetupResponse expectedResponse = new MutateBillingSetupResponse();
            mockGrpcClient.Setup(x => x.MutateBillingSetupAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateBillingSetupResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            BillingSetupOperation operation = new BillingSetupOperation();
            MutateBillingSetupResponse response = await client.MutateBillingSetupAsync(customerId, operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateBillingSetup2()
        {
            Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new Mock<BillingSetupService.BillingSetupServiceClient>(MockBehavior.Strict);
            MutateBillingSetupRequest request = new MutateBillingSetupRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new BillingSetupOperation(),
            };
            MutateBillingSetupResponse expectedResponse = new MutateBillingSetupResponse();
            mockGrpcClient.Setup(x => x.MutateBillingSetup(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            MutateBillingSetupResponse response = client.MutateBillingSetup(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateBillingSetupAsync2()
        {
            Mock<BillingSetupService.BillingSetupServiceClient> mockGrpcClient = new Mock<BillingSetupService.BillingSetupServiceClient>(MockBehavior.Strict);
            MutateBillingSetupRequest request = new MutateBillingSetupRequest
            {
                CustomerId = "customerId-1772061412",
                Operation = new BillingSetupOperation(),
            };
            MutateBillingSetupResponse expectedResponse = new MutateBillingSetupResponse();
            mockGrpcClient.Setup(x => x.MutateBillingSetupAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateBillingSetupResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            BillingSetupServiceClient client = new BillingSetupServiceClientImpl(mockGrpcClient.Object, null);
            MutateBillingSetupResponse response = await client.MutateBillingSetupAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

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

namespace Google.Ads.GoogleAds.V2.Services.Tests
{
    using Google.Ads.GoogleAds.V2.Resources;
    using apis = Google.Ads.GoogleAds.V2.Services;
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
    public class GeneratedChangeStatusServiceClientTest
    {
        [Test]
        public void GetChangeStatus()
        {
            Mock<ChangeStatusService.ChangeStatusServiceClient> mockGrpcClient = new Mock<ChangeStatusService.ChangeStatusServiceClient>(MockBehavior.Strict);
            GetChangeStatusRequest expectedRequest = new GetChangeStatusRequest
            {
                ResourceName = new ChangeStatusName("[CUSTOMER]", "[CHANGE_STATUS]").ToString(),
            };
            ChangeStatus expectedResponse = new ChangeStatus
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetChangeStatus(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ChangeStatusServiceClient client = new ChangeStatusServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ChangeStatusName("[CUSTOMER]", "[CHANGE_STATUS]").ToString();
            ChangeStatus response = client.GetChangeStatus(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetChangeStatusAsync()
        {
            Mock<ChangeStatusService.ChangeStatusServiceClient> mockGrpcClient = new Mock<ChangeStatusService.ChangeStatusServiceClient>(MockBehavior.Strict);
            GetChangeStatusRequest expectedRequest = new GetChangeStatusRequest
            {
                ResourceName = new ChangeStatusName("[CUSTOMER]", "[CHANGE_STATUS]").ToString(),
            };
            ChangeStatus expectedResponse = new ChangeStatus
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetChangeStatusAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ChangeStatus>(Task.FromResult(expectedResponse), null, null, null, null));
            ChangeStatusServiceClient client = new ChangeStatusServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ChangeStatusName("[CUSTOMER]", "[CHANGE_STATUS]").ToString();
            ChangeStatus response = await client.GetChangeStatusAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetChangeStatus2()
        {
            Mock<ChangeStatusService.ChangeStatusServiceClient> mockGrpcClient = new Mock<ChangeStatusService.ChangeStatusServiceClient>(MockBehavior.Strict);
            GetChangeStatusRequest request = new GetChangeStatusRequest
            {
                ResourceName = new ChangeStatusName("[CUSTOMER]", "[CHANGE_STATUS]").ToString(),
            };
            ChangeStatus expectedResponse = new ChangeStatus
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetChangeStatus(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ChangeStatusServiceClient client = new ChangeStatusServiceClientImpl(mockGrpcClient.Object, null);
            ChangeStatus response = client.GetChangeStatus(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetChangeStatusAsync2()
        {
            Mock<ChangeStatusService.ChangeStatusServiceClient> mockGrpcClient = new Mock<ChangeStatusService.ChangeStatusServiceClient>(MockBehavior.Strict);
            GetChangeStatusRequest request = new GetChangeStatusRequest
            {
                ResourceName = new ChangeStatusName("[CUSTOMER]", "[CHANGE_STATUS]").ToString(),
            };
            ChangeStatus expectedResponse = new ChangeStatus
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetChangeStatusAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ChangeStatus>(Task.FromResult(expectedResponse), null, null, null, null));
            ChangeStatusServiceClient client = new ChangeStatusServiceClientImpl(mockGrpcClient.Object, null);
            ChangeStatus response = await client.GetChangeStatusAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

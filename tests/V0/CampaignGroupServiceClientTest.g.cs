// Copyright 2018 Google LLC
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

namespace Google.Ads.GoogleAds.V0.Services.Tests
{
    using Google.Ads.GoogleAds.V0.Resources;
    using Google.Ads.GoogleAds.V0.Services;
    using apis = Google.Ads.GoogleAds.V0.Services;
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
    public class GeneratedCampaignGroupServiceClientTest
    {
        [Test]
        public void GetCampaignGroup()
        {
            Mock<CampaignGroupService.CampaignGroupServiceClient> mockGrpcClient = new Mock<CampaignGroupService.CampaignGroupServiceClient>(MockBehavior.Strict);
            GetCampaignGroupRequest expectedRequest = new GetCampaignGroupRequest
            {
                ResourceName = new CampaignGroupName("[CUSTOMER]", "[CAMPAIGN_GROUP]").ToString(),
            };
            CampaignGroup expectedResponse = new CampaignGroup
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignGroup(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignGroupServiceClient client = new CampaignGroupServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignGroupName("[CUSTOMER]", "[CAMPAIGN_GROUP]").ToString();
            CampaignGroup response = client.GetCampaignGroup(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignGroupAsync()
        {
            Mock<CampaignGroupService.CampaignGroupServiceClient> mockGrpcClient = new Mock<CampaignGroupService.CampaignGroupServiceClient>(MockBehavior.Strict);
            GetCampaignGroupRequest expectedRequest = new GetCampaignGroupRequest
            {
                ResourceName = new CampaignGroupName("[CUSTOMER]", "[CAMPAIGN_GROUP]").ToString(),
            };
            CampaignGroup expectedResponse = new CampaignGroup
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignGroupAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignGroup>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignGroupServiceClient client = new CampaignGroupServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignGroupName("[CUSTOMER]", "[CAMPAIGN_GROUP]").ToString();
            CampaignGroup response = await client.GetCampaignGroupAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaignGroup2()
        {
            Mock<CampaignGroupService.CampaignGroupServiceClient> mockGrpcClient = new Mock<CampaignGroupService.CampaignGroupServiceClient>(MockBehavior.Strict);
            GetCampaignGroupRequest request = new GetCampaignGroupRequest
            {
                ResourceName = new CampaignGroupName("[CUSTOMER]", "[CAMPAIGN_GROUP]").ToString(),
            };
            CampaignGroup expectedResponse = new CampaignGroup
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignGroup(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignGroupServiceClient client = new CampaignGroupServiceClientImpl(mockGrpcClient.Object, null);
            CampaignGroup response = client.GetCampaignGroup(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignGroupAsync2()
        {
            Mock<CampaignGroupService.CampaignGroupServiceClient> mockGrpcClient = new Mock<CampaignGroupService.CampaignGroupServiceClient>(MockBehavior.Strict);
            GetCampaignGroupRequest request = new GetCampaignGroupRequest
            {
                ResourceName = new CampaignGroupName("[CUSTOMER]", "[CAMPAIGN_GROUP]").ToString(),
            };
            CampaignGroup expectedResponse = new CampaignGroup
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignGroupAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignGroup>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignGroupServiceClient client = new CampaignGroupServiceClientImpl(mockGrpcClient.Object, null);
            CampaignGroup response = await client.GetCampaignGroupAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignGroups()
        {
            Mock<CampaignGroupService.CampaignGroupServiceClient> mockGrpcClient = new Mock<CampaignGroupService.CampaignGroupServiceClient>(MockBehavior.Strict);
            MutateCampaignGroupsRequest expectedRequest = new MutateCampaignGroupsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignGroupsResponse expectedResponse = new MutateCampaignGroupsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignGroups(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignGroupServiceClient client = new CampaignGroupServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignGroupOperation> operations = new List<CampaignGroupOperation>();
            MutateCampaignGroupsResponse response = client.MutateCampaignGroups(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignGroupsAsync()
        {
            Mock<CampaignGroupService.CampaignGroupServiceClient> mockGrpcClient = new Mock<CampaignGroupService.CampaignGroupServiceClient>(MockBehavior.Strict);
            MutateCampaignGroupsRequest expectedRequest = new MutateCampaignGroupsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignGroupsResponse expectedResponse = new MutateCampaignGroupsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignGroupsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignGroupsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignGroupServiceClient client = new CampaignGroupServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignGroupOperation> operations = new List<CampaignGroupOperation>();
            MutateCampaignGroupsResponse response = await client.MutateCampaignGroupsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignGroups2()
        {
            Mock<CampaignGroupService.CampaignGroupServiceClient> mockGrpcClient = new Mock<CampaignGroupService.CampaignGroupServiceClient>(MockBehavior.Strict);
            MutateCampaignGroupsRequest request = new MutateCampaignGroupsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignGroupsResponse expectedResponse = new MutateCampaignGroupsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignGroups(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignGroupServiceClient client = new CampaignGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignGroupsResponse response = client.MutateCampaignGroups(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignGroupsAsync2()
        {
            Mock<CampaignGroupService.CampaignGroupServiceClient> mockGrpcClient = new Mock<CampaignGroupService.CampaignGroupServiceClient>(MockBehavior.Strict);
            MutateCampaignGroupsRequest request = new MutateCampaignGroupsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignGroupsResponse expectedResponse = new MutateCampaignGroupsResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignGroupsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignGroupsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignGroupServiceClient client = new CampaignGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignGroupsResponse response = await client.MutateCampaignGroupsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

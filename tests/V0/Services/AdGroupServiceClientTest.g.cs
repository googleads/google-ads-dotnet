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

// TODO( b/119694056): Removed Comment

namespace Google.Ads.GoogleAds.V0.Services.Tests
{
    using Google.Ads.GoogleAds.V0.Resources;
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
    public class GeneratedAdGroupServiceClientTest
    {
        [Test]
        public void GetAdGroup()
        {
            Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new Mock<AdGroupService.AdGroupServiceClient>(MockBehavior.Strict);
            GetAdGroupRequest expectedRequest = new GetAdGroupRequest
            {
                ResourceName = new AdGroupName("[CUSTOMER]", "[AD_GROUP]").ToString(),
            };
            AdGroup expectedResponse = new AdGroup
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroup(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupName("[CUSTOMER]", "[AD_GROUP]").ToString();
            AdGroup response = client.GetAdGroup(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupAsync()
        {
            Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new Mock<AdGroupService.AdGroupServiceClient>(MockBehavior.Strict);
            GetAdGroupRequest expectedRequest = new GetAdGroupRequest
            {
                ResourceName = new AdGroupName("[CUSTOMER]", "[AD_GROUP]").ToString(),
            };
            AdGroup expectedResponse = new AdGroup
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroup>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdGroupName("[CUSTOMER]", "[AD_GROUP]").ToString();
            AdGroup response = await client.GetAdGroupAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdGroup2()
        {
            Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new Mock<AdGroupService.AdGroupServiceClient>(MockBehavior.Strict);
            GetAdGroupRequest request = new GetAdGroupRequest
            {
                ResourceName = new AdGroupName("[CUSTOMER]", "[AD_GROUP]").ToString(),
            };
            AdGroup expectedResponse = new AdGroup
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroup(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            AdGroup response = client.GetAdGroup(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdGroupAsync2()
        {
            Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new Mock<AdGroupService.AdGroupServiceClient>(MockBehavior.Strict);
            GetAdGroupRequest request = new GetAdGroupRequest
            {
                ResourceName = new AdGroupName("[CUSTOMER]", "[AD_GROUP]").ToString(),
            };
            AdGroup expectedResponse = new AdGroup
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdGroup>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            AdGroup response = await client.GetAdGroupAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroups()
        {
            Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new Mock<AdGroupService.AdGroupServiceClient>(MockBehavior.Strict);
            MutateAdGroupsRequest expectedRequest = new MutateAdGroupsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupsResponse expectedResponse = new MutateAdGroupsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroups(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupOperation> operations = new List<AdGroupOperation>();
            MutateAdGroupsResponse response = client.MutateAdGroups(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupsAsync()
        {
            Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new Mock<AdGroupService.AdGroupServiceClient>(MockBehavior.Strict);
            MutateAdGroupsRequest expectedRequest = new MutateAdGroupsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupsResponse expectedResponse = new MutateAdGroupsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdGroupOperation> operations = new List<AdGroupOperation>();
            MutateAdGroupsResponse response = await client.MutateAdGroupsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdGroups2()
        {
            Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new Mock<AdGroupService.AdGroupServiceClient>(MockBehavior.Strict);
            MutateAdGroupsRequest request = new MutateAdGroupsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupsResponse expectedResponse = new MutateAdGroupsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroups(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupsResponse response = client.MutateAdGroups(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdGroupsAsync2()
        {
            Mock<AdGroupService.AdGroupServiceClient> mockGrpcClient = new Mock<AdGroupService.AdGroupServiceClient>(MockBehavior.Strict);
            MutateAdGroupsRequest request = new MutateAdGroupsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdGroupsResponse expectedResponse = new MutateAdGroupsResponse();
            mockGrpcClient.Setup(x => x.MutateAdGroupsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupServiceClient client = new AdGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupsResponse response = await client.MutateAdGroupsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

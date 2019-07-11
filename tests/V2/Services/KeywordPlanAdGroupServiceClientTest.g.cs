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
    public class GeneratedKeywordPlanAdGroupServiceClientTest
    {
        [Test]
        public void GetKeywordPlanAdGroup()
        {
            Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(MockBehavior.Strict);
            GetKeywordPlanAdGroupRequest expectedRequest = new GetKeywordPlanAdGroupRequest
            {
                ResourceName = new KeywordPlanAdGroupName("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]").ToString(),
            };
            KeywordPlanAdGroup expectedResponse = new KeywordPlanAdGroup
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAdGroup(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new KeywordPlanAdGroupName("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]").ToString();
            KeywordPlanAdGroup response = client.GetKeywordPlanAdGroup(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetKeywordPlanAdGroupAsync()
        {
            Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(MockBehavior.Strict);
            GetKeywordPlanAdGroupRequest expectedRequest = new GetKeywordPlanAdGroupRequest
            {
                ResourceName = new KeywordPlanAdGroupName("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]").ToString(),
            };
            KeywordPlanAdGroup expectedResponse = new KeywordPlanAdGroup
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAdGroupAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<KeywordPlanAdGroup>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new KeywordPlanAdGroupName("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]").ToString();
            KeywordPlanAdGroup response = await client.GetKeywordPlanAdGroupAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetKeywordPlanAdGroup2()
        {
            Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(MockBehavior.Strict);
            GetKeywordPlanAdGroupRequest request = new GetKeywordPlanAdGroupRequest
            {
                ResourceName = new KeywordPlanAdGroupName("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]").ToString(),
            };
            KeywordPlanAdGroup expectedResponse = new KeywordPlanAdGroup
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAdGroup(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            KeywordPlanAdGroup response = client.GetKeywordPlanAdGroup(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetKeywordPlanAdGroupAsync2()
        {
            Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(MockBehavior.Strict);
            GetKeywordPlanAdGroupRequest request = new GetKeywordPlanAdGroupRequest
            {
                ResourceName = new KeywordPlanAdGroupName("[CUSTOMER]", "[KEYWORD_PLAN_AD_GROUP]").ToString(),
            };
            KeywordPlanAdGroup expectedResponse = new KeywordPlanAdGroup
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAdGroupAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<KeywordPlanAdGroup>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            KeywordPlanAdGroup response = await client.GetKeywordPlanAdGroupAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateKeywordPlanAdGroups()
        {
            Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanAdGroupsRequest expectedRequest = new MutateKeywordPlanAdGroupsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateKeywordPlanAdGroupsResponse expectedResponse = new MutateKeywordPlanAdGroupsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanAdGroups(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<KeywordPlanAdGroupOperation> operations = new List<KeywordPlanAdGroupOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateKeywordPlanAdGroupsResponse response = client.MutateKeywordPlanAdGroups(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateKeywordPlanAdGroupsAsync()
        {
            Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanAdGroupsRequest expectedRequest = new MutateKeywordPlanAdGroupsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateKeywordPlanAdGroupsResponse expectedResponse = new MutateKeywordPlanAdGroupsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanAdGroupsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateKeywordPlanAdGroupsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<KeywordPlanAdGroupOperation> operations = new List<KeywordPlanAdGroupOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateKeywordPlanAdGroupsResponse response = await client.MutateKeywordPlanAdGroupsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateKeywordPlanAdGroups2()
        {
            Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanAdGroupsRequest expectedRequest = new MutateKeywordPlanAdGroupsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlanAdGroupsResponse expectedResponse = new MutateKeywordPlanAdGroupsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanAdGroups(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<KeywordPlanAdGroupOperation> operations = new List<KeywordPlanAdGroupOperation>();
            MutateKeywordPlanAdGroupsResponse response = client.MutateKeywordPlanAdGroups(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateKeywordPlanAdGroupsAsync2()
        {
            Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanAdGroupsRequest expectedRequest = new MutateKeywordPlanAdGroupsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlanAdGroupsResponse expectedResponse = new MutateKeywordPlanAdGroupsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanAdGroupsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateKeywordPlanAdGroupsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<KeywordPlanAdGroupOperation> operations = new List<KeywordPlanAdGroupOperation>();
            MutateKeywordPlanAdGroupsResponse response = await client.MutateKeywordPlanAdGroupsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateKeywordPlanAdGroups3()
        {
            Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanAdGroupsRequest request = new MutateKeywordPlanAdGroupsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlanAdGroupsResponse expectedResponse = new MutateKeywordPlanAdGroupsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanAdGroups(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanAdGroupsResponse response = client.MutateKeywordPlanAdGroups(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateKeywordPlanAdGroupsAsync3()
        {
            Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient> mockGrpcClient = new Mock<KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient>(MockBehavior.Strict);
            MutateKeywordPlanAdGroupsRequest request = new MutateKeywordPlanAdGroupsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateKeywordPlanAdGroupsResponse expectedResponse = new MutateKeywordPlanAdGroupsResponse();
            mockGrpcClient.Setup(x => x.MutateKeywordPlanAdGroupsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateKeywordPlanAdGroupsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanAdGroupServiceClient client = new KeywordPlanAdGroupServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlanAdGroupsResponse response = await client.MutateKeywordPlanAdGroupsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

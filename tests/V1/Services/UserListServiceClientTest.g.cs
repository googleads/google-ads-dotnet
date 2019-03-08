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
    public class GeneratedUserListServiceClientTest
    {
        [Test]
        public void GetUserList()
        {
            Mock<UserListService.UserListServiceClient> mockGrpcClient = new Mock<UserListService.UserListServiceClient>(MockBehavior.Strict);
            GetUserListRequest expectedRequest = new GetUserListRequest
            {
                ResourceName = new UserListName("[CUSTOMER]", "[USER_LIST]").ToString(),
            };
            UserList expectedResponse = new UserList
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetUserList(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new UserListName("[CUSTOMER]", "[USER_LIST]").ToString();
            UserList response = client.GetUserList(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetUserListAsync()
        {
            Mock<UserListService.UserListServiceClient> mockGrpcClient = new Mock<UserListService.UserListServiceClient>(MockBehavior.Strict);
            GetUserListRequest expectedRequest = new GetUserListRequest
            {
                ResourceName = new UserListName("[CUSTOMER]", "[USER_LIST]").ToString(),
            };
            UserList expectedResponse = new UserList
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetUserListAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UserList>(Task.FromResult(expectedResponse), null, null, null, null));
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new UserListName("[CUSTOMER]", "[USER_LIST]").ToString();
            UserList response = await client.GetUserListAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetUserList2()
        {
            Mock<UserListService.UserListServiceClient> mockGrpcClient = new Mock<UserListService.UserListServiceClient>(MockBehavior.Strict);
            GetUserListRequest request = new GetUserListRequest
            {
                ResourceName = new UserListName("[CUSTOMER]", "[USER_LIST]").ToString(),
            };
            UserList expectedResponse = new UserList
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetUserList(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            UserList response = client.GetUserList(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetUserListAsync2()
        {
            Mock<UserListService.UserListServiceClient> mockGrpcClient = new Mock<UserListService.UserListServiceClient>(MockBehavior.Strict);
            GetUserListRequest request = new GetUserListRequest
            {
                ResourceName = new UserListName("[CUSTOMER]", "[USER_LIST]").ToString(),
            };
            UserList expectedResponse = new UserList
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetUserListAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UserList>(Task.FromResult(expectedResponse), null, null, null, null));
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            UserList response = await client.GetUserListAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateUserLists()
        {
            Mock<UserListService.UserListServiceClient> mockGrpcClient = new Mock<UserListService.UserListServiceClient>(MockBehavior.Strict);
            MutateUserListsRequest expectedRequest = new MutateUserListsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateUserListsResponse expectedResponse = new MutateUserListsResponse();
            mockGrpcClient.Setup(x => x.MutateUserLists(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<UserListOperation> operations = new List<UserListOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateUserListsResponse response = client.MutateUserLists(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateUserListsAsync()
        {
            Mock<UserListService.UserListServiceClient> mockGrpcClient = new Mock<UserListService.UserListServiceClient>(MockBehavior.Strict);
            MutateUserListsRequest expectedRequest = new MutateUserListsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateUserListsResponse expectedResponse = new MutateUserListsResponse();
            mockGrpcClient.Setup(x => x.MutateUserListsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateUserListsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<UserListOperation> operations = new List<UserListOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateUserListsResponse response = await client.MutateUserListsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateUserLists2()
        {
            Mock<UserListService.UserListServiceClient> mockGrpcClient = new Mock<UserListService.UserListServiceClient>(MockBehavior.Strict);
            MutateUserListsRequest expectedRequest = new MutateUserListsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateUserListsResponse expectedResponse = new MutateUserListsResponse();
            mockGrpcClient.Setup(x => x.MutateUserLists(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<UserListOperation> operations = new List<UserListOperation>();
            MutateUserListsResponse response = client.MutateUserLists(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateUserListsAsync2()
        {
            Mock<UserListService.UserListServiceClient> mockGrpcClient = new Mock<UserListService.UserListServiceClient>(MockBehavior.Strict);
            MutateUserListsRequest expectedRequest = new MutateUserListsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateUserListsResponse expectedResponse = new MutateUserListsResponse();
            mockGrpcClient.Setup(x => x.MutateUserListsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateUserListsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<UserListOperation> operations = new List<UserListOperation>();
            MutateUserListsResponse response = await client.MutateUserListsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateUserLists3()
        {
            Mock<UserListService.UserListServiceClient> mockGrpcClient = new Mock<UserListService.UserListServiceClient>(MockBehavior.Strict);
            MutateUserListsRequest request = new MutateUserListsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateUserListsResponse expectedResponse = new MutateUserListsResponse();
            mockGrpcClient.Setup(x => x.MutateUserLists(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            MutateUserListsResponse response = client.MutateUserLists(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateUserListsAsync3()
        {
            Mock<UserListService.UserListServiceClient> mockGrpcClient = new Mock<UserListService.UserListServiceClient>(MockBehavior.Strict);
            MutateUserListsRequest request = new MutateUserListsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateUserListsResponse expectedResponse = new MutateUserListsResponse();
            mockGrpcClient.Setup(x => x.MutateUserListsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateUserListsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            MutateUserListsResponse response = await client.MutateUserListsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

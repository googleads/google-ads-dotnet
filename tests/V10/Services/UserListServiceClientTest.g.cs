// Copyright 2022 Google LLC
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

using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V10.Services;

namespace Google.Ads.GoogleAds.Tests.V10.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedUserListServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateUserListsRequestObject()
        {
            moq::Mock<UserListService.UserListServiceClient> mockGrpcClient = new moq::Mock<UserListService.UserListServiceClient>(moq::MockBehavior.Strict);
            MutateUserListsRequest request = new MutateUserListsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new UserListOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateUserListsResponse expectedResponse = new MutateUserListsResponse
            {
                Results =
                {
                    new MutateUserListResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateUserLists(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            MutateUserListsResponse response = client.MutateUserLists(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateUserListsRequestObjectAsync()
        {
            moq::Mock<UserListService.UserListServiceClient> mockGrpcClient = new moq::Mock<UserListService.UserListServiceClient>(moq::MockBehavior.Strict);
            MutateUserListsRequest request = new MutateUserListsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new UserListOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateUserListsResponse expectedResponse = new MutateUserListsResponse
            {
                Results =
                {
                    new MutateUserListResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateUserListsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateUserListsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            MutateUserListsResponse responseCallSettings = await client.MutateUserListsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateUserListsResponse responseCancellationToken = await client.MutateUserListsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateUserLists()
        {
            moq::Mock<UserListService.UserListServiceClient> mockGrpcClient = new moq::Mock<UserListService.UserListServiceClient>(moq::MockBehavior.Strict);
            MutateUserListsRequest request = new MutateUserListsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new UserListOperation(),
                },
            };
            MutateUserListsResponse expectedResponse = new MutateUserListsResponse
            {
                Results =
                {
                    new MutateUserListResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateUserLists(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            MutateUserListsResponse response = client.MutateUserLists(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateUserListsAsync()
        {
            moq::Mock<UserListService.UserListServiceClient> mockGrpcClient = new moq::Mock<UserListService.UserListServiceClient>(moq::MockBehavior.Strict);
            MutateUserListsRequest request = new MutateUserListsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new UserListOperation(),
                },
            };
            MutateUserListsResponse expectedResponse = new MutateUserListsResponse
            {
                Results =
                {
                    new MutateUserListResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateUserListsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateUserListsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            MutateUserListsResponse responseCallSettings = await client.MutateUserListsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateUserListsResponse responseCancellationToken = await client.MutateUserListsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

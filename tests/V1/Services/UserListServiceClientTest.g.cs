// Copyright 2020 Google LLC
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

using gagvc = Google.Ads.GoogleAds.V1.Common;
using gagve = Google.Ads.GoogleAds.V1.Enums;
using gagvr = Google.Ads.GoogleAds.V1.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V1.Services;

namespace Google.Ads.GoogleAds.Tests.V1.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedUserListServiceClientTest
    {
        [Test]
        public void GetUserListRequestObject()
        {
            moq::Mock<UserListService.UserListServiceClient> mockGrpcClient = new moq::Mock<UserListService.UserListServiceClient>(moq::MockBehavior.Strict);
            GetUserListRequest request = new GetUserListRequest
            {
                ResourceNameAsUserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
            };
            gagvr::UserList expectedResponse = new gagvr::UserList
            {
                ResourceNameAsUserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
                Id = -6774108720365892680L,
                ReadOnly = false,
                UserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
                Description = "description2cf9da67",
                MembershipStatus = gagve::UserListMembershipStatusEnum.Types.UserListMembershipStatus.Open,
                IntegrationCode = "integration_codeb56c28f6",
                MembershipLifeSpan = 8593891943371112615L,
                SizeForDisplay = -3774093290138442712L,
                SizeRangeForDisplay = gagve::UserListSizeRangeEnum.Types.UserListSizeRange.Unknown,
                SizeForSearch = 7931927642168968409L,
                SizeRangeForSearch = gagve::UserListSizeRangeEnum.Types.UserListSizeRange.OneHundredThousandToThreeHundredThousand,
                Type = gagve::UserListTypeEnum.Types.UserListType.CrmBased,
                ClosingReason = gagve::UserListClosingReasonEnum.Types.UserListClosingReason.Unused,
                AccessReason = gagve::AccessReasonEnum.Types.AccessReason.Affiliated,
                AccountUserListStatus = gagve::UserListAccessStatusEnum.Types.UserListAccessStatus.Disabled,
                EligibleForSearch = false,
                EligibleForDisplay = true,
                CrmBasedUserList = new gagvc::CrmBasedUserListInfo(),
                SimilarUserList = new gagvc::SimilarUserListInfo(),
                RuleBasedUserList = new gagvc::RuleBasedUserListInfo(),
                LogicalUserList = new gagvc::LogicalUserListInfo(),
                BasicUserList = new gagvc::BasicUserListInfo(),
            };
            mockGrpcClient.Setup(x => x.GetUserList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserList response = client.GetUserList(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetUserListRequestObjectAsync()
        {
            moq::Mock<UserListService.UserListServiceClient> mockGrpcClient = new moq::Mock<UserListService.UserListServiceClient>(moq::MockBehavior.Strict);
            GetUserListRequest request = new GetUserListRequest
            {
                ResourceNameAsUserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
            };
            gagvr::UserList expectedResponse = new gagvr::UserList
            {
                ResourceNameAsUserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
                Id = -6774108720365892680L,
                ReadOnly = false,
                UserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
                Description = "description2cf9da67",
                MembershipStatus = gagve::UserListMembershipStatusEnum.Types.UserListMembershipStatus.Open,
                IntegrationCode = "integration_codeb56c28f6",
                MembershipLifeSpan = 8593891943371112615L,
                SizeForDisplay = -3774093290138442712L,
                SizeRangeForDisplay = gagve::UserListSizeRangeEnum.Types.UserListSizeRange.Unknown,
                SizeForSearch = 7931927642168968409L,
                SizeRangeForSearch = gagve::UserListSizeRangeEnum.Types.UserListSizeRange.OneHundredThousandToThreeHundredThousand,
                Type = gagve::UserListTypeEnum.Types.UserListType.CrmBased,
                ClosingReason = gagve::UserListClosingReasonEnum.Types.UserListClosingReason.Unused,
                AccessReason = gagve::AccessReasonEnum.Types.AccessReason.Affiliated,
                AccountUserListStatus = gagve::UserListAccessStatusEnum.Types.UserListAccessStatus.Disabled,
                EligibleForSearch = false,
                EligibleForDisplay = true,
                CrmBasedUserList = new gagvc::CrmBasedUserListInfo(),
                SimilarUserList = new gagvc::SimilarUserListInfo(),
                RuleBasedUserList = new gagvc::RuleBasedUserListInfo(),
                LogicalUserList = new gagvc::LogicalUserListInfo(),
                BasicUserList = new gagvc::BasicUserListInfo(),
            };
            mockGrpcClient.Setup(x => x.GetUserListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::UserList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserList responseCallSettings = await client.GetUserListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::UserList responseCancellationToken = await client.GetUserListAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetUserList()
        {
            moq::Mock<UserListService.UserListServiceClient> mockGrpcClient = new moq::Mock<UserListService.UserListServiceClient>(moq::MockBehavior.Strict);
            GetUserListRequest request = new GetUserListRequest
            {
                ResourceNameAsUserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
            };
            gagvr::UserList expectedResponse = new gagvr::UserList
            {
                ResourceNameAsUserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
                Id = -6774108720365892680L,
                ReadOnly = false,
                UserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
                Description = "description2cf9da67",
                MembershipStatus = gagve::UserListMembershipStatusEnum.Types.UserListMembershipStatus.Open,
                IntegrationCode = "integration_codeb56c28f6",
                MembershipLifeSpan = 8593891943371112615L,
                SizeForDisplay = -3774093290138442712L,
                SizeRangeForDisplay = gagve::UserListSizeRangeEnum.Types.UserListSizeRange.Unknown,
                SizeForSearch = 7931927642168968409L,
                SizeRangeForSearch = gagve::UserListSizeRangeEnum.Types.UserListSizeRange.OneHundredThousandToThreeHundredThousand,
                Type = gagve::UserListTypeEnum.Types.UserListType.CrmBased,
                ClosingReason = gagve::UserListClosingReasonEnum.Types.UserListClosingReason.Unused,
                AccessReason = gagve::AccessReasonEnum.Types.AccessReason.Affiliated,
                AccountUserListStatus = gagve::UserListAccessStatusEnum.Types.UserListAccessStatus.Disabled,
                EligibleForSearch = false,
                EligibleForDisplay = true,
                CrmBasedUserList = new gagvc::CrmBasedUserListInfo(),
                SimilarUserList = new gagvc::SimilarUserListInfo(),
                RuleBasedUserList = new gagvc::RuleBasedUserListInfo(),
                LogicalUserList = new gagvc::LogicalUserListInfo(),
                BasicUserList = new gagvc::BasicUserListInfo(),
            };
            mockGrpcClient.Setup(x => x.GetUserList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserList response = client.GetUserList(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetUserListAsync()
        {
            moq::Mock<UserListService.UserListServiceClient> mockGrpcClient = new moq::Mock<UserListService.UserListServiceClient>(moq::MockBehavior.Strict);
            GetUserListRequest request = new GetUserListRequest
            {
                ResourceNameAsUserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
            };
            gagvr::UserList expectedResponse = new gagvr::UserList
            {
                ResourceNameAsUserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
                Id = -6774108720365892680L,
                ReadOnly = false,
                UserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
                Description = "description2cf9da67",
                MembershipStatus = gagve::UserListMembershipStatusEnum.Types.UserListMembershipStatus.Open,
                IntegrationCode = "integration_codeb56c28f6",
                MembershipLifeSpan = 8593891943371112615L,
                SizeForDisplay = -3774093290138442712L,
                SizeRangeForDisplay = gagve::UserListSizeRangeEnum.Types.UserListSizeRange.Unknown,
                SizeForSearch = 7931927642168968409L,
                SizeRangeForSearch = gagve::UserListSizeRangeEnum.Types.UserListSizeRange.OneHundredThousandToThreeHundredThousand,
                Type = gagve::UserListTypeEnum.Types.UserListType.CrmBased,
                ClosingReason = gagve::UserListClosingReasonEnum.Types.UserListClosingReason.Unused,
                AccessReason = gagve::AccessReasonEnum.Types.AccessReason.Affiliated,
                AccountUserListStatus = gagve::UserListAccessStatusEnum.Types.UserListAccessStatus.Disabled,
                EligibleForSearch = false,
                EligibleForDisplay = true,
                CrmBasedUserList = new gagvc::CrmBasedUserListInfo(),
                SimilarUserList = new gagvc::SimilarUserListInfo(),
                RuleBasedUserList = new gagvc::RuleBasedUserListInfo(),
                LogicalUserList = new gagvc::LogicalUserListInfo(),
                BasicUserList = new gagvc::BasicUserListInfo(),
            };
            mockGrpcClient.Setup(x => x.GetUserListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::UserList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserList responseCallSettings = await client.GetUserListAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::UserList responseCancellationToken = await client.GetUserListAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetUserListResourceNames()
        {
            moq::Mock<UserListService.UserListServiceClient> mockGrpcClient = new moq::Mock<UserListService.UserListServiceClient>(moq::MockBehavior.Strict);
            GetUserListRequest request = new GetUserListRequest
            {
                ResourceNameAsUserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
            };
            gagvr::UserList expectedResponse = new gagvr::UserList
            {
                ResourceNameAsUserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
                Id = -6774108720365892680L,
                ReadOnly = false,
                UserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
                Description = "description2cf9da67",
                MembershipStatus = gagve::UserListMembershipStatusEnum.Types.UserListMembershipStatus.Open,
                IntegrationCode = "integration_codeb56c28f6",
                MembershipLifeSpan = 8593891943371112615L,
                SizeForDisplay = -3774093290138442712L,
                SizeRangeForDisplay = gagve::UserListSizeRangeEnum.Types.UserListSizeRange.Unknown,
                SizeForSearch = 7931927642168968409L,
                SizeRangeForSearch = gagve::UserListSizeRangeEnum.Types.UserListSizeRange.OneHundredThousandToThreeHundredThousand,
                Type = gagve::UserListTypeEnum.Types.UserListType.CrmBased,
                ClosingReason = gagve::UserListClosingReasonEnum.Types.UserListClosingReason.Unused,
                AccessReason = gagve::AccessReasonEnum.Types.AccessReason.Affiliated,
                AccountUserListStatus = gagve::UserListAccessStatusEnum.Types.UserListAccessStatus.Disabled,
                EligibleForSearch = false,
                EligibleForDisplay = true,
                CrmBasedUserList = new gagvc::CrmBasedUserListInfo(),
                SimilarUserList = new gagvc::SimilarUserListInfo(),
                RuleBasedUserList = new gagvc::RuleBasedUserListInfo(),
                LogicalUserList = new gagvc::LogicalUserListInfo(),
                BasicUserList = new gagvc::BasicUserListInfo(),
            };
            mockGrpcClient.Setup(x => x.GetUserList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserList response = client.GetUserList(request.ResourceNameAsUserListName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetUserListResourceNamesAsync()
        {
            moq::Mock<UserListService.UserListServiceClient> mockGrpcClient = new moq::Mock<UserListService.UserListServiceClient>(moq::MockBehavior.Strict);
            GetUserListRequest request = new GetUserListRequest
            {
                ResourceNameAsUserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
            };
            gagvr::UserList expectedResponse = new gagvr::UserList
            {
                ResourceNameAsUserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
                Id = -6774108720365892680L,
                ReadOnly = false,
                UserListName = gagvr::UserListName.FromCustomerUserList("[CUSTOMER]", "[USER_LIST]"),
                Description = "description2cf9da67",
                MembershipStatus = gagve::UserListMembershipStatusEnum.Types.UserListMembershipStatus.Open,
                IntegrationCode = "integration_codeb56c28f6",
                MembershipLifeSpan = 8593891943371112615L,
                SizeForDisplay = -3774093290138442712L,
                SizeRangeForDisplay = gagve::UserListSizeRangeEnum.Types.UserListSizeRange.Unknown,
                SizeForSearch = 7931927642168968409L,
                SizeRangeForSearch = gagve::UserListSizeRangeEnum.Types.UserListSizeRange.OneHundredThousandToThreeHundredThousand,
                Type = gagve::UserListTypeEnum.Types.UserListType.CrmBased,
                ClosingReason = gagve::UserListClosingReasonEnum.Types.UserListClosingReason.Unused,
                AccessReason = gagve::AccessReasonEnum.Types.AccessReason.Affiliated,
                AccountUserListStatus = gagve::UserListAccessStatusEnum.Types.UserListAccessStatus.Disabled,
                EligibleForSearch = false,
                EligibleForDisplay = true,
                CrmBasedUserList = new gagvc::CrmBasedUserListInfo(),
                SimilarUserList = new gagvc::SimilarUserListInfo(),
                RuleBasedUserList = new gagvc::RuleBasedUserListInfo(),
                LogicalUserList = new gagvc::LogicalUserListInfo(),
                BasicUserList = new gagvc::BasicUserListInfo(),
            };
            mockGrpcClient.Setup(x => x.GetUserListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::UserList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserListServiceClient client = new UserListServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserList responseCallSettings = await client.GetUserListAsync(request.ResourceNameAsUserListName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::UserList responseCancellationToken = await client.GetUserListAsync(request.ResourceNameAsUserListName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
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

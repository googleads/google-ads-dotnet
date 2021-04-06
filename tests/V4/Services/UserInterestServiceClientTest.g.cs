// Copyright 2021 Google LLC
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

using gagvc = Google.Ads.GoogleAds.V4.Common;
using gagve = Google.Ads.GoogleAds.V4.Enums;
using gagvr = Google.Ads.GoogleAds.V4.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V4.Services;

namespace Google.Ads.GoogleAds.Tests.V4.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedUserInterestServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetUserInterestRequestObject()
        {
            moq::Mock<UserInterestService.UserInterestServiceClient> mockGrpcClient = new moq::Mock<UserInterestService.UserInterestServiceClient>(moq::MockBehavior.Strict);
            GetUserInterestRequest request = new GetUserInterestRequest
            {
                ResourceNameAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
            };
            gagvr::UserInterest expectedResponse = new gagvr::UserInterest
            {
                ResourceNameAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                TaxonomyType = gagve::UserInterestTaxonomyTypeEnum.Types.UserInterestTaxonomyType.Unknown,
                UserInterestId = 3507346946980618534L,
                UserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                UserInterestParentAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetUserInterest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserInterestServiceClient client = new UserInterestServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserInterest response = client.GetUserInterest(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetUserInterestRequestObjectAsync()
        {
            moq::Mock<UserInterestService.UserInterestServiceClient> mockGrpcClient = new moq::Mock<UserInterestService.UserInterestServiceClient>(moq::MockBehavior.Strict);
            GetUserInterestRequest request = new GetUserInterestRequest
            {
                ResourceNameAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
            };
            gagvr::UserInterest expectedResponse = new gagvr::UserInterest
            {
                ResourceNameAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                TaxonomyType = gagve::UserInterestTaxonomyTypeEnum.Types.UserInterestTaxonomyType.Unknown,
                UserInterestId = 3507346946980618534L,
                UserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                UserInterestParentAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetUserInterestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::UserInterest>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserInterestServiceClient client = new UserInterestServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserInterest responseCallSettings = await client.GetUserInterestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::UserInterest responseCancellationToken = await client.GetUserInterestAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetUserInterest()
        {
            moq::Mock<UserInterestService.UserInterestServiceClient> mockGrpcClient = new moq::Mock<UserInterestService.UserInterestServiceClient>(moq::MockBehavior.Strict);
            GetUserInterestRequest request = new GetUserInterestRequest
            {
                ResourceNameAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
            };
            gagvr::UserInterest expectedResponse = new gagvr::UserInterest
            {
                ResourceNameAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                TaxonomyType = gagve::UserInterestTaxonomyTypeEnum.Types.UserInterestTaxonomyType.Unknown,
                UserInterestId = 3507346946980618534L,
                UserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                UserInterestParentAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetUserInterest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserInterestServiceClient client = new UserInterestServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserInterest response = client.GetUserInterest(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetUserInterestAsync()
        {
            moq::Mock<UserInterestService.UserInterestServiceClient> mockGrpcClient = new moq::Mock<UserInterestService.UserInterestServiceClient>(moq::MockBehavior.Strict);
            GetUserInterestRequest request = new GetUserInterestRequest
            {
                ResourceNameAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
            };
            gagvr::UserInterest expectedResponse = new gagvr::UserInterest
            {
                ResourceNameAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                TaxonomyType = gagve::UserInterestTaxonomyTypeEnum.Types.UserInterestTaxonomyType.Unknown,
                UserInterestId = 3507346946980618534L,
                UserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                UserInterestParentAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetUserInterestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::UserInterest>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserInterestServiceClient client = new UserInterestServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserInterest responseCallSettings = await client.GetUserInterestAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::UserInterest responseCancellationToken = await client.GetUserInterestAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetUserInterestResourceNames()
        {
            moq::Mock<UserInterestService.UserInterestServiceClient> mockGrpcClient = new moq::Mock<UserInterestService.UserInterestServiceClient>(moq::MockBehavior.Strict);
            GetUserInterestRequest request = new GetUserInterestRequest
            {
                ResourceNameAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
            };
            gagvr::UserInterest expectedResponse = new gagvr::UserInterest
            {
                ResourceNameAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                TaxonomyType = gagve::UserInterestTaxonomyTypeEnum.Types.UserInterestTaxonomyType.Unknown,
                UserInterestId = 3507346946980618534L,
                UserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                UserInterestParentAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetUserInterest(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserInterestServiceClient client = new UserInterestServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserInterest response = client.GetUserInterest(request.ResourceNameAsUserInterestName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetUserInterestResourceNamesAsync()
        {
            moq::Mock<UserInterestService.UserInterestServiceClient> mockGrpcClient = new moq::Mock<UserInterestService.UserInterestServiceClient>(moq::MockBehavior.Strict);
            GetUserInterestRequest request = new GetUserInterestRequest
            {
                ResourceNameAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
            };
            gagvr::UserInterest expectedResponse = new gagvr::UserInterest
            {
                ResourceNameAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                TaxonomyType = gagve::UserInterestTaxonomyTypeEnum.Types.UserInterestTaxonomyType.Unknown,
                UserInterestId = 3507346946980618534L,
                UserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                UserInterestParentAsUserInterestName = gagvr::UserInterestName.FromCustomerUserInterest("[CUSTOMER]", "[USER_INTEREST]"),
                LaunchedToAll = true,
                Availabilities =
                {
                    new gagvc::CriterionCategoryAvailability(),
                },
            };
            mockGrpcClient.Setup(x => x.GetUserInterestAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::UserInterest>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserInterestServiceClient client = new UserInterestServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::UserInterest responseCallSettings = await client.GetUserInterestAsync(request.ResourceNameAsUserInterestName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::UserInterest responseCancellationToken = await client.GetUserInterestAsync(request.ResourceNameAsUserInterestName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

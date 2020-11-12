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

using gagvc = Google.Ads.GoogleAds.V6.Common;
using gagve = Google.Ads.GoogleAds.V6.Enums;
using gagvr = Google.Ads.GoogleAds.V6.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V6.Services;

namespace Google.Ads.GoogleAds.Tests.V6.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSharedCriterionServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetSharedCriterionRequestObject()
        {
            moq::Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new moq::Mock<SharedCriterionService.SharedCriterionServiceClient>(moq::MockBehavior.Strict);
            GetSharedCriterionRequest request = new GetSharedCriterionRequest
            {
                ResourceNameAsSharedCriterionName = gagvr::SharedCriterionName.FromCustomerSharedSetCriterion("[CUSTOMER_ID]", "[SHARED_SET_ID]", "[CRITERION_ID]"),
            };
            gagvr::SharedCriterion expectedResponse = new gagvr::SharedCriterion
            {
                ResourceNameAsSharedCriterionName = gagvr::SharedCriterionName.FromCustomerSharedSetCriterion("[CUSTOMER_ID]", "[SHARED_SET_ID]", "[CRITERION_ID]"),
                Keyword = new gagvc::KeywordInfo(),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.AdSchedule,
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                SharedSetAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER_ID]", "[SHARED_SET_ID]"),
                CriterionId = 8584655242409302840L,
            };
            mockGrpcClient.Setup(x => x.GetSharedCriterion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SharedCriterion response = client.GetSharedCriterion(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetSharedCriterionRequestObjectAsync()
        {
            moq::Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new moq::Mock<SharedCriterionService.SharedCriterionServiceClient>(moq::MockBehavior.Strict);
            GetSharedCriterionRequest request = new GetSharedCriterionRequest
            {
                ResourceNameAsSharedCriterionName = gagvr::SharedCriterionName.FromCustomerSharedSetCriterion("[CUSTOMER_ID]", "[SHARED_SET_ID]", "[CRITERION_ID]"),
            };
            gagvr::SharedCriterion expectedResponse = new gagvr::SharedCriterion
            {
                ResourceNameAsSharedCriterionName = gagvr::SharedCriterionName.FromCustomerSharedSetCriterion("[CUSTOMER_ID]", "[SHARED_SET_ID]", "[CRITERION_ID]"),
                Keyword = new gagvc::KeywordInfo(),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.AdSchedule,
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                SharedSetAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER_ID]", "[SHARED_SET_ID]"),
                CriterionId = 8584655242409302840L,
            };
            mockGrpcClient.Setup(x => x.GetSharedCriterionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SharedCriterion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SharedCriterion responseCallSettings = await client.GetSharedCriterionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::SharedCriterion responseCancellationToken = await client.GetSharedCriterionAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetSharedCriterion()
        {
            moq::Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new moq::Mock<SharedCriterionService.SharedCriterionServiceClient>(moq::MockBehavior.Strict);
            GetSharedCriterionRequest request = new GetSharedCriterionRequest
            {
                ResourceNameAsSharedCriterionName = gagvr::SharedCriterionName.FromCustomerSharedSetCriterion("[CUSTOMER_ID]", "[SHARED_SET_ID]", "[CRITERION_ID]"),
            };
            gagvr::SharedCriterion expectedResponse = new gagvr::SharedCriterion
            {
                ResourceNameAsSharedCriterionName = gagvr::SharedCriterionName.FromCustomerSharedSetCriterion("[CUSTOMER_ID]", "[SHARED_SET_ID]", "[CRITERION_ID]"),
                Keyword = new gagvc::KeywordInfo(),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.AdSchedule,
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                SharedSetAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER_ID]", "[SHARED_SET_ID]"),
                CriterionId = 8584655242409302840L,
            };
            mockGrpcClient.Setup(x => x.GetSharedCriterion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SharedCriterion response = client.GetSharedCriterion(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetSharedCriterionAsync()
        {
            moq::Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new moq::Mock<SharedCriterionService.SharedCriterionServiceClient>(moq::MockBehavior.Strict);
            GetSharedCriterionRequest request = new GetSharedCriterionRequest
            {
                ResourceNameAsSharedCriterionName = gagvr::SharedCriterionName.FromCustomerSharedSetCriterion("[CUSTOMER_ID]", "[SHARED_SET_ID]", "[CRITERION_ID]"),
            };
            gagvr::SharedCriterion expectedResponse = new gagvr::SharedCriterion
            {
                ResourceNameAsSharedCriterionName = gagvr::SharedCriterionName.FromCustomerSharedSetCriterion("[CUSTOMER_ID]", "[SHARED_SET_ID]", "[CRITERION_ID]"),
                Keyword = new gagvc::KeywordInfo(),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.AdSchedule,
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                SharedSetAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER_ID]", "[SHARED_SET_ID]"),
                CriterionId = 8584655242409302840L,
            };
            mockGrpcClient.Setup(x => x.GetSharedCriterionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SharedCriterion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SharedCriterion responseCallSettings = await client.GetSharedCriterionAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::SharedCriterion responseCancellationToken = await client.GetSharedCriterionAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetSharedCriterionResourceNames()
        {
            moq::Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new moq::Mock<SharedCriterionService.SharedCriterionServiceClient>(moq::MockBehavior.Strict);
            GetSharedCriterionRequest request = new GetSharedCriterionRequest
            {
                ResourceNameAsSharedCriterionName = gagvr::SharedCriterionName.FromCustomerSharedSetCriterion("[CUSTOMER_ID]", "[SHARED_SET_ID]", "[CRITERION_ID]"),
            };
            gagvr::SharedCriterion expectedResponse = new gagvr::SharedCriterion
            {
                ResourceNameAsSharedCriterionName = gagvr::SharedCriterionName.FromCustomerSharedSetCriterion("[CUSTOMER_ID]", "[SHARED_SET_ID]", "[CRITERION_ID]"),
                Keyword = new gagvc::KeywordInfo(),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.AdSchedule,
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                SharedSetAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER_ID]", "[SHARED_SET_ID]"),
                CriterionId = 8584655242409302840L,
            };
            mockGrpcClient.Setup(x => x.GetSharedCriterion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SharedCriterion response = client.GetSharedCriterion(request.ResourceNameAsSharedCriterionName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetSharedCriterionResourceNamesAsync()
        {
            moq::Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new moq::Mock<SharedCriterionService.SharedCriterionServiceClient>(moq::MockBehavior.Strict);
            GetSharedCriterionRequest request = new GetSharedCriterionRequest
            {
                ResourceNameAsSharedCriterionName = gagvr::SharedCriterionName.FromCustomerSharedSetCriterion("[CUSTOMER_ID]", "[SHARED_SET_ID]", "[CRITERION_ID]"),
            };
            gagvr::SharedCriterion expectedResponse = new gagvr::SharedCriterion
            {
                ResourceNameAsSharedCriterionName = gagvr::SharedCriterionName.FromCustomerSharedSetCriterion("[CUSTOMER_ID]", "[SHARED_SET_ID]", "[CRITERION_ID]"),
                Keyword = new gagvc::KeywordInfo(),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.AdSchedule,
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                Placement = new gagvc::PlacementInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                SharedSetAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER_ID]", "[SHARED_SET_ID]"),
                CriterionId = 8584655242409302840L,
            };
            mockGrpcClient.Setup(x => x.GetSharedCriterionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SharedCriterion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SharedCriterion responseCallSettings = await client.GetSharedCriterionAsync(request.ResourceNameAsSharedCriterionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::SharedCriterion responseCancellationToken = await client.GetSharedCriterionAsync(request.ResourceNameAsSharedCriterionName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateSharedCriteriaRequestObject()
        {
            moq::Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new moq::Mock<SharedCriterionService.SharedCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateSharedCriteriaRequest request = new MutateSharedCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new SharedCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateSharedCriteriaResponse expectedResponse = new MutateSharedCriteriaResponse
            {
                Results =
                {
                    new MutateSharedCriterionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateSharedCriteria(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateSharedCriteriaResponse response = client.MutateSharedCriteria(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateSharedCriteriaRequestObjectAsync()
        {
            moq::Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new moq::Mock<SharedCriterionService.SharedCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateSharedCriteriaRequest request = new MutateSharedCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new SharedCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateSharedCriteriaResponse expectedResponse = new MutateSharedCriteriaResponse
            {
                Results =
                {
                    new MutateSharedCriterionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateSharedCriteriaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateSharedCriteriaResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateSharedCriteriaResponse responseCallSettings = await client.MutateSharedCriteriaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateSharedCriteriaResponse responseCancellationToken = await client.MutateSharedCriteriaAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateSharedCriteria()
        {
            moq::Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new moq::Mock<SharedCriterionService.SharedCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateSharedCriteriaRequest request = new MutateSharedCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new SharedCriterionOperation(),
                },
            };
            MutateSharedCriteriaResponse expectedResponse = new MutateSharedCriteriaResponse
            {
                Results =
                {
                    new MutateSharedCriterionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateSharedCriteria(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateSharedCriteriaResponse response = client.MutateSharedCriteria(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateSharedCriteriaAsync()
        {
            moq::Mock<SharedCriterionService.SharedCriterionServiceClient> mockGrpcClient = new moq::Mock<SharedCriterionService.SharedCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateSharedCriteriaRequest request = new MutateSharedCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new SharedCriterionOperation(),
                },
            };
            MutateSharedCriteriaResponse expectedResponse = new MutateSharedCriteriaResponse
            {
                Results =
                {
                    new MutateSharedCriterionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateSharedCriteriaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateSharedCriteriaResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SharedCriterionServiceClient client = new SharedCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateSharedCriteriaResponse responseCallSettings = await client.MutateSharedCriteriaAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateSharedCriteriaResponse responseCancellationToken = await client.MutateSharedCriteriaAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

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

using gagve = Google.Ads.GoogleAds.V2.Enums;
using gagvr = Google.Ads.GoogleAds.V2.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V2.Services;

namespace Google.Ads.GoogleAds.Tests.V2.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFeedMappingServiceClientTest
    {
        [Test]
        public void GetFeedMappingRequestObject()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            GetFeedMappingRequest request = new GetFeedMappingRequest
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedMapping("[CUSTOMER]", "[FEED_MAPPING]"),
            };
            gagvr::FeedMapping expectedResponse = new gagvr::FeedMapping
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedMapping("[CUSTOMER]", "[FEED_MAPPING]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.Message,
                CriterionType = gagve::FeedMappingCriterionTypeEnum.Types.FeedMappingCriterionType.Unknown,
                AttributeFieldMappings =
                {
                    new gagvr::AttributeFieldMapping(),
                },
                Status = gagve::FeedMappingStatusEnum.Types.FeedMappingStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedMapping(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedMapping response = client.GetFeedMapping(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetFeedMappingRequestObjectAsync()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            GetFeedMappingRequest request = new GetFeedMappingRequest
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedMapping("[CUSTOMER]", "[FEED_MAPPING]"),
            };
            gagvr::FeedMapping expectedResponse = new gagvr::FeedMapping
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedMapping("[CUSTOMER]", "[FEED_MAPPING]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.Message,
                CriterionType = gagve::FeedMappingCriterionTypeEnum.Types.FeedMappingCriterionType.Unknown,
                AttributeFieldMappings =
                {
                    new gagvr::AttributeFieldMapping(),
                },
                Status = gagve::FeedMappingStatusEnum.Types.FeedMappingStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedMappingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedMapping>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedMapping responseCallSettings = await client.GetFeedMappingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedMapping responseCancellationToken = await client.GetFeedMappingAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetFeedMapping()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            GetFeedMappingRequest request = new GetFeedMappingRequest
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedMapping("[CUSTOMER]", "[FEED_MAPPING]"),
            };
            gagvr::FeedMapping expectedResponse = new gagvr::FeedMapping
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedMapping("[CUSTOMER]", "[FEED_MAPPING]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.Message,
                CriterionType = gagve::FeedMappingCriterionTypeEnum.Types.FeedMappingCriterionType.Unknown,
                AttributeFieldMappings =
                {
                    new gagvr::AttributeFieldMapping(),
                },
                Status = gagve::FeedMappingStatusEnum.Types.FeedMappingStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedMapping(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedMapping response = client.GetFeedMapping(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetFeedMappingAsync()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            GetFeedMappingRequest request = new GetFeedMappingRequest
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedMapping("[CUSTOMER]", "[FEED_MAPPING]"),
            };
            gagvr::FeedMapping expectedResponse = new gagvr::FeedMapping
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedMapping("[CUSTOMER]", "[FEED_MAPPING]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.Message,
                CriterionType = gagve::FeedMappingCriterionTypeEnum.Types.FeedMappingCriterionType.Unknown,
                AttributeFieldMappings =
                {
                    new gagvr::AttributeFieldMapping(),
                },
                Status = gagve::FeedMappingStatusEnum.Types.FeedMappingStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedMappingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedMapping>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedMapping responseCallSettings = await client.GetFeedMappingAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedMapping responseCancellationToken = await client.GetFeedMappingAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetFeedMappingResourceNames()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            GetFeedMappingRequest request = new GetFeedMappingRequest
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedMapping("[CUSTOMER]", "[FEED_MAPPING]"),
            };
            gagvr::FeedMapping expectedResponse = new gagvr::FeedMapping
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedMapping("[CUSTOMER]", "[FEED_MAPPING]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.Message,
                CriterionType = gagve::FeedMappingCriterionTypeEnum.Types.FeedMappingCriterionType.Unknown,
                AttributeFieldMappings =
                {
                    new gagvr::AttributeFieldMapping(),
                },
                Status = gagve::FeedMappingStatusEnum.Types.FeedMappingStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedMapping(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedMapping response = client.GetFeedMapping(request.ResourceNameAsFeedMappingName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetFeedMappingResourceNamesAsync()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            GetFeedMappingRequest request = new GetFeedMappingRequest
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedMapping("[CUSTOMER]", "[FEED_MAPPING]"),
            };
            gagvr::FeedMapping expectedResponse = new gagvr::FeedMapping
            {
                ResourceNameAsFeedMappingName = gagvr::FeedMappingName.FromCustomerFeedMapping("[CUSTOMER]", "[FEED_MAPPING]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                PlaceholderType = gagve::PlaceholderTypeEnum.Types.PlaceholderType.Message,
                CriterionType = gagve::FeedMappingCriterionTypeEnum.Types.FeedMappingCriterionType.Unknown,
                AttributeFieldMappings =
                {
                    new gagvr::AttributeFieldMapping(),
                },
                Status = gagve::FeedMappingStatusEnum.Types.FeedMappingStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedMappingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedMapping>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedMapping responseCallSettings = await client.GetFeedMappingAsync(request.ResourceNameAsFeedMappingName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedMapping responseCancellationToken = await client.GetFeedMappingAsync(request.ResourceNameAsFeedMappingName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateFeedMappingsRequestObject()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            MutateFeedMappingsRequest request = new MutateFeedMappingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedMappingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateFeedMappingsResponse expectedResponse = new MutateFeedMappingsResponse
            {
                Results =
                {
                    new MutateFeedMappingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedMappings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedMappingsResponse response = client.MutateFeedMappings(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateFeedMappingsRequestObjectAsync()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            MutateFeedMappingsRequest request = new MutateFeedMappingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedMappingOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateFeedMappingsResponse expectedResponse = new MutateFeedMappingsResponse
            {
                Results =
                {
                    new MutateFeedMappingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedMappingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateFeedMappingsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedMappingsResponse responseCallSettings = await client.MutateFeedMappingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateFeedMappingsResponse responseCancellationToken = await client.MutateFeedMappingsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateFeedMappings()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            MutateFeedMappingsRequest request = new MutateFeedMappingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedMappingOperation(),
                },
            };
            MutateFeedMappingsResponse expectedResponse = new MutateFeedMappingsResponse
            {
                Results =
                {
                    new MutateFeedMappingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedMappings(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedMappingsResponse response = client.MutateFeedMappings(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateFeedMappingsAsync()
        {
            moq::Mock<FeedMappingService.FeedMappingServiceClient> mockGrpcClient = new moq::Mock<FeedMappingService.FeedMappingServiceClient>(moq::MockBehavior.Strict);
            MutateFeedMappingsRequest request = new MutateFeedMappingsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedMappingOperation(),
                },
            };
            MutateFeedMappingsResponse expectedResponse = new MutateFeedMappingsResponse
            {
                Results =
                {
                    new MutateFeedMappingResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateFeedMappingsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateFeedMappingsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedMappingServiceClient client = new FeedMappingServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedMappingsResponse responseCallSettings = await client.MutateFeedMappingsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateFeedMappingsResponse responseCancellationToken = await client.MutateFeedMappingsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

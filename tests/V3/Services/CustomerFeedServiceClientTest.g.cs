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

using gagvc = Google.Ads.GoogleAds.V3.Common;
using gagve = Google.Ads.GoogleAds.V3.Enums;
using gagvr = Google.Ads.GoogleAds.V3.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V3.Services;

namespace Google.Ads.GoogleAds.Tests.V3.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCustomerFeedServiceClientTest
    {
        [Test]
        public void GetCustomerFeedRequestObject()
        {
            moq::Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new moq::Mock<CustomerFeedService.CustomerFeedServiceClient>(moq::MockBehavior.Strict);
            GetCustomerFeedRequest request = new GetCustomerFeedRequest
            {
                ResourceNameAsCustomerFeedName = gagvr::CustomerFeedName.FromCustomerCustomerFeed("[CUSTOMER]", "[CUSTOMER_FEED]"),
            };
            gagvr::CustomerFeed expectedResponse = new gagvr::CustomerFeed
            {
                ResourceNameAsCustomerFeedName = gagvr::CustomerFeedName.FromCustomerCustomerFeed("[CUSTOMER]", "[CUSTOMER_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetCustomerFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerFeed response = client.GetCustomerFeed(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCustomerFeedRequestObjectAsync()
        {
            moq::Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new moq::Mock<CustomerFeedService.CustomerFeedServiceClient>(moq::MockBehavior.Strict);
            GetCustomerFeedRequest request = new GetCustomerFeedRequest
            {
                ResourceNameAsCustomerFeedName = gagvr::CustomerFeedName.FromCustomerCustomerFeed("[CUSTOMER]", "[CUSTOMER_FEED]"),
            };
            gagvr::CustomerFeed expectedResponse = new gagvr::CustomerFeed
            {
                ResourceNameAsCustomerFeedName = gagvr::CustomerFeedName.FromCustomerCustomerFeed("[CUSTOMER]", "[CUSTOMER_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetCustomerFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerFeed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerFeed responseCallSettings = await client.GetCustomerFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerFeed responseCancellationToken = await client.GetCustomerFeedAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCustomerFeed()
        {
            moq::Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new moq::Mock<CustomerFeedService.CustomerFeedServiceClient>(moq::MockBehavior.Strict);
            GetCustomerFeedRequest request = new GetCustomerFeedRequest
            {
                ResourceNameAsCustomerFeedName = gagvr::CustomerFeedName.FromCustomerCustomerFeed("[CUSTOMER]", "[CUSTOMER_FEED]"),
            };
            gagvr::CustomerFeed expectedResponse = new gagvr::CustomerFeed
            {
                ResourceNameAsCustomerFeedName = gagvr::CustomerFeedName.FromCustomerCustomerFeed("[CUSTOMER]", "[CUSTOMER_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetCustomerFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerFeed response = client.GetCustomerFeed(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCustomerFeedAsync()
        {
            moq::Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new moq::Mock<CustomerFeedService.CustomerFeedServiceClient>(moq::MockBehavior.Strict);
            GetCustomerFeedRequest request = new GetCustomerFeedRequest
            {
                ResourceNameAsCustomerFeedName = gagvr::CustomerFeedName.FromCustomerCustomerFeed("[CUSTOMER]", "[CUSTOMER_FEED]"),
            };
            gagvr::CustomerFeed expectedResponse = new gagvr::CustomerFeed
            {
                ResourceNameAsCustomerFeedName = gagvr::CustomerFeedName.FromCustomerCustomerFeed("[CUSTOMER]", "[CUSTOMER_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetCustomerFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerFeed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerFeed responseCallSettings = await client.GetCustomerFeedAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerFeed responseCancellationToken = await client.GetCustomerFeedAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCustomerFeedResourceNames()
        {
            moq::Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new moq::Mock<CustomerFeedService.CustomerFeedServiceClient>(moq::MockBehavior.Strict);
            GetCustomerFeedRequest request = new GetCustomerFeedRequest
            {
                ResourceNameAsCustomerFeedName = gagvr::CustomerFeedName.FromCustomerCustomerFeed("[CUSTOMER]", "[CUSTOMER_FEED]"),
            };
            gagvr::CustomerFeed expectedResponse = new gagvr::CustomerFeed
            {
                ResourceNameAsCustomerFeedName = gagvr::CustomerFeedName.FromCustomerCustomerFeed("[CUSTOMER]", "[CUSTOMER_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetCustomerFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerFeed response = client.GetCustomerFeed(request.ResourceNameAsCustomerFeedName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCustomerFeedResourceNamesAsync()
        {
            moq::Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new moq::Mock<CustomerFeedService.CustomerFeedServiceClient>(moq::MockBehavior.Strict);
            GetCustomerFeedRequest request = new GetCustomerFeedRequest
            {
                ResourceNameAsCustomerFeedName = gagvr::CustomerFeedName.FromCustomerCustomerFeed("[CUSTOMER]", "[CUSTOMER_FEED]"),
            };
            gagvr::CustomerFeed expectedResponse = new gagvr::CustomerFeed
            {
                ResourceNameAsCustomerFeedName = gagvr::CustomerFeedName.FromCustomerCustomerFeed("[CUSTOMER]", "[CUSTOMER_FEED]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER]", "[FEED]"),
                PlaceholderTypes =
                {
                    gagve::PlaceholderTypeEnum.Types.PlaceholderType.Location,
                },
                MatchingFunction = new gagvc::MatchingFunction(),
                Status = gagve::FeedLinkStatusEnum.Types.FeedLinkStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetCustomerFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerFeed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerFeed responseCallSettings = await client.GetCustomerFeedAsync(request.ResourceNameAsCustomerFeedName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerFeed responseCancellationToken = await client.GetCustomerFeedAsync(request.ResourceNameAsCustomerFeedName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerFeedsRequestObject()
        {
            moq::Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new moq::Mock<CustomerFeedService.CustomerFeedServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerFeedsRequest request = new MutateCustomerFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerFeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCustomerFeedsResponse expectedResponse = new MutateCustomerFeedsResponse
            {
                Results =
                {
                    new MutateCustomerFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerFeeds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerFeedsResponse response = client.MutateCustomerFeeds(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateCustomerFeedsRequestObjectAsync()
        {
            moq::Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new moq::Mock<CustomerFeedService.CustomerFeedServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerFeedsRequest request = new MutateCustomerFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerFeedOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateCustomerFeedsResponse expectedResponse = new MutateCustomerFeedsResponse
            {
                Results =
                {
                    new MutateCustomerFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerFeedsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerFeedsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerFeedsResponse responseCallSettings = await client.MutateCustomerFeedsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerFeedsResponse responseCancellationToken = await client.MutateCustomerFeedsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerFeeds()
        {
            moq::Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new moq::Mock<CustomerFeedService.CustomerFeedServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerFeedsRequest request = new MutateCustomerFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerFeedOperation(),
                },
            };
            MutateCustomerFeedsResponse expectedResponse = new MutateCustomerFeedsResponse
            {
                Results =
                {
                    new MutateCustomerFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerFeeds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerFeedsResponse response = client.MutateCustomerFeeds(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateCustomerFeedsAsync()
        {
            moq::Mock<CustomerFeedService.CustomerFeedServiceClient> mockGrpcClient = new moq::Mock<CustomerFeedService.CustomerFeedServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerFeedsRequest request = new MutateCustomerFeedsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerFeedOperation(),
                },
            };
            MutateCustomerFeedsResponse expectedResponse = new MutateCustomerFeedsResponse
            {
                Results =
                {
                    new MutateCustomerFeedResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerFeedsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerFeedsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerFeedServiceClient client = new CustomerFeedServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerFeedsResponse responseCallSettings = await client.MutateCustomerFeedsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerFeedsResponse responseCancellationToken = await client.MutateCustomerFeedsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

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

using gagvc = Google.Ads.GoogleAds.V6.Common;
using gagve = Google.Ads.GoogleAds.V6.Enums;
using gagvr = Google.Ads.GoogleAds.V6.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V6.Services;

namespace Google.Ads.GoogleAds.Tests.V6.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedFeedItemSetServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetFeedItemSetRequestObject()
        {
            moq::Mock<FeedItemSetService.FeedItemSetServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetService.FeedItemSetServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemSetRequest request = new GetFeedItemSetRequest
            {
                ResourceNameAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
            };
            gagvr::FeedItemSet expectedResponse = new gagvr::FeedItemSet
            {
                ResourceNameAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
                FeedItemSetId = 2017070211045731158L,
                DisplayName = "display_name137f65c2",
                DynamicLocationSetFilter = new gagvc::DynamicLocationSetFilter(),
                DynamicAffiliateLocationSetFilter = new gagvc::DynamicAffiliateLocationSetFilter(),
                Status = gagve::FeedItemSetStatusEnum.Types.FeedItemSetStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedItemSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemSetServiceClient client = new FeedItemSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemSet response = client.GetFeedItemSet(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetFeedItemSetRequestObjectAsync()
        {
            moq::Mock<FeedItemSetService.FeedItemSetServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetService.FeedItemSetServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemSetRequest request = new GetFeedItemSetRequest
            {
                ResourceNameAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
            };
            gagvr::FeedItemSet expectedResponse = new gagvr::FeedItemSet
            {
                ResourceNameAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
                FeedItemSetId = 2017070211045731158L,
                DisplayName = "display_name137f65c2",
                DynamicLocationSetFilter = new gagvc::DynamicLocationSetFilter(),
                DynamicAffiliateLocationSetFilter = new gagvc::DynamicAffiliateLocationSetFilter(),
                Status = gagve::FeedItemSetStatusEnum.Types.FeedItemSetStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedItemSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedItemSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemSetServiceClient client = new FeedItemSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemSet responseCallSettings = await client.GetFeedItemSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedItemSet responseCancellationToken = await client.GetFeedItemSetAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetFeedItemSet()
        {
            moq::Mock<FeedItemSetService.FeedItemSetServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetService.FeedItemSetServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemSetRequest request = new GetFeedItemSetRequest
            {
                ResourceNameAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
            };
            gagvr::FeedItemSet expectedResponse = new gagvr::FeedItemSet
            {
                ResourceNameAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
                FeedItemSetId = 2017070211045731158L,
                DisplayName = "display_name137f65c2",
                DynamicLocationSetFilter = new gagvc::DynamicLocationSetFilter(),
                DynamicAffiliateLocationSetFilter = new gagvc::DynamicAffiliateLocationSetFilter(),
                Status = gagve::FeedItemSetStatusEnum.Types.FeedItemSetStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedItemSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemSetServiceClient client = new FeedItemSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemSet response = client.GetFeedItemSet(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetFeedItemSetAsync()
        {
            moq::Mock<FeedItemSetService.FeedItemSetServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetService.FeedItemSetServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemSetRequest request = new GetFeedItemSetRequest
            {
                ResourceNameAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
            };
            gagvr::FeedItemSet expectedResponse = new gagvr::FeedItemSet
            {
                ResourceNameAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
                FeedItemSetId = 2017070211045731158L,
                DisplayName = "display_name137f65c2",
                DynamicLocationSetFilter = new gagvc::DynamicLocationSetFilter(),
                DynamicAffiliateLocationSetFilter = new gagvc::DynamicAffiliateLocationSetFilter(),
                Status = gagve::FeedItemSetStatusEnum.Types.FeedItemSetStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedItemSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedItemSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemSetServiceClient client = new FeedItemSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemSet responseCallSettings = await client.GetFeedItemSetAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedItemSet responseCancellationToken = await client.GetFeedItemSetAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetFeedItemSetResourceNames()
        {
            moq::Mock<FeedItemSetService.FeedItemSetServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetService.FeedItemSetServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemSetRequest request = new GetFeedItemSetRequest
            {
                ResourceNameAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
            };
            gagvr::FeedItemSet expectedResponse = new gagvr::FeedItemSet
            {
                ResourceNameAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
                FeedItemSetId = 2017070211045731158L,
                DisplayName = "display_name137f65c2",
                DynamicLocationSetFilter = new gagvc::DynamicLocationSetFilter(),
                DynamicAffiliateLocationSetFilter = new gagvc::DynamicAffiliateLocationSetFilter(),
                Status = gagve::FeedItemSetStatusEnum.Types.FeedItemSetStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedItemSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemSetServiceClient client = new FeedItemSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemSet response = client.GetFeedItemSet(request.ResourceNameAsFeedItemSetName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetFeedItemSetResourceNamesAsync()
        {
            moq::Mock<FeedItemSetService.FeedItemSetServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetService.FeedItemSetServiceClient>(moq::MockBehavior.Strict);
            GetFeedItemSetRequest request = new GetFeedItemSetRequest
            {
                ResourceNameAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
            };
            gagvr::FeedItemSet expectedResponse = new gagvr::FeedItemSet
            {
                ResourceNameAsFeedItemSetName = gagvr::FeedItemSetName.FromCustomerFeedFeedItemSet("[CUSTOMER_ID]", "[FEED_ID]", "[FEED_ITEM_SET_ID]"),
                FeedAsFeedName = gagvr::FeedName.FromCustomerFeed("[CUSTOMER_ID]", "[FEED_ID]"),
                FeedItemSetId = 2017070211045731158L,
                DisplayName = "display_name137f65c2",
                DynamicLocationSetFilter = new gagvc::DynamicLocationSetFilter(),
                DynamicAffiliateLocationSetFilter = new gagvc::DynamicAffiliateLocationSetFilter(),
                Status = gagve::FeedItemSetStatusEnum.Types.FeedItemSetStatus.Enabled,
            };
            mockGrpcClient.Setup(x => x.GetFeedItemSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::FeedItemSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemSetServiceClient client = new FeedItemSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::FeedItemSet responseCallSettings = await client.GetFeedItemSetAsync(request.ResourceNameAsFeedItemSetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::FeedItemSet responseCancellationToken = await client.GetFeedItemSetAsync(request.ResourceNameAsFeedItemSetName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateFeedItemSetsRequestObject()
        {
            moq::Mock<FeedItemSetService.FeedItemSetServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetService.FeedItemSetServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemSetsRequest request = new MutateFeedItemSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateFeedItemSetsResponse expectedResponse = new MutateFeedItemSetsResponse
            {
                Results =
                {
                    new MutateFeedItemSetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemSetServiceClient client = new FeedItemSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemSetsResponse response = client.MutateFeedItemSets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateFeedItemSetsRequestObjectAsync()
        {
            moq::Mock<FeedItemSetService.FeedItemSetServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetService.FeedItemSetServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemSetsRequest request = new MutateFeedItemSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateFeedItemSetsResponse expectedResponse = new MutateFeedItemSetsResponse
            {
                Results =
                {
                    new MutateFeedItemSetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateFeedItemSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemSetServiceClient client = new FeedItemSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemSetsResponse responseCallSettings = await client.MutateFeedItemSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateFeedItemSetsResponse responseCancellationToken = await client.MutateFeedItemSetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateFeedItemSets()
        {
            moq::Mock<FeedItemSetService.FeedItemSetServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetService.FeedItemSetServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemSetsRequest request = new MutateFeedItemSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemSetOperation(),
                },
            };
            MutateFeedItemSetsResponse expectedResponse = new MutateFeedItemSetsResponse
            {
                Results =
                {
                    new MutateFeedItemSetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            FeedItemSetServiceClient client = new FeedItemSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemSetsResponse response = client.MutateFeedItemSets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateFeedItemSetsAsync()
        {
            moq::Mock<FeedItemSetService.FeedItemSetServiceClient> mockGrpcClient = new moq::Mock<FeedItemSetService.FeedItemSetServiceClient>(moq::MockBehavior.Strict);
            MutateFeedItemSetsRequest request = new MutateFeedItemSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new FeedItemSetOperation(),
                },
            };
            MutateFeedItemSetsResponse expectedResponse = new MutateFeedItemSetsResponse
            {
                Results =
                {
                    new MutateFeedItemSetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateFeedItemSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateFeedItemSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            FeedItemSetServiceClient client = new FeedItemSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateFeedItemSetsResponse responseCallSettings = await client.MutateFeedItemSetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateFeedItemSetsResponse responseCancellationToken = await client.MutateFeedItemSetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

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

using gagve = Google.Ads.GoogleAds.V9.Enums;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V9.Services;

namespace Google.Ads.GoogleAds.Tests.V9.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAssetGroupListingGroupFilterServiceClientTest
    {
        [Category("Smoke")][Test]
        public void MutateAssetGroupListingGroupFiltersRequestObject()
        {
            moq::Mock<AssetGroupListingGroupFilterService.AssetGroupListingGroupFilterServiceClient> mockGrpcClient = new moq::Mock<AssetGroupListingGroupFilterService.AssetGroupListingGroupFilterServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupListingGroupFiltersRequest request = new MutateAssetGroupListingGroupFiltersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupListingGroupFilterOperation(),
                },
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAssetGroupListingGroupFiltersResponse expectedResponse = new MutateAssetGroupListingGroupFiltersResponse
            {
                Results =
                {
                    new MutateAssetGroupListingGroupFilterResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroupListingGroupFilters(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetGroupListingGroupFilterServiceClient client = new AssetGroupListingGroupFilterServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetGroupListingGroupFiltersResponse response = client.MutateAssetGroupListingGroupFilters(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAssetGroupListingGroupFiltersRequestObjectAsync()
        {
            moq::Mock<AssetGroupListingGroupFilterService.AssetGroupListingGroupFilterServiceClient> mockGrpcClient = new moq::Mock<AssetGroupListingGroupFilterService.AssetGroupListingGroupFilterServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupListingGroupFiltersRequest request = new MutateAssetGroupListingGroupFiltersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupListingGroupFilterOperation(),
                },
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAssetGroupListingGroupFiltersResponse expectedResponse = new MutateAssetGroupListingGroupFiltersResponse
            {
                Results =
                {
                    new MutateAssetGroupListingGroupFilterResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroupListingGroupFiltersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetGroupListingGroupFiltersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetGroupListingGroupFilterServiceClient client = new AssetGroupListingGroupFilterServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetGroupListingGroupFiltersResponse responseCallSettings = await client.MutateAssetGroupListingGroupFiltersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetGroupListingGroupFiltersResponse responseCancellationToken = await client.MutateAssetGroupListingGroupFiltersAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAssetGroupListingGroupFilters()
        {
            moq::Mock<AssetGroupListingGroupFilterService.AssetGroupListingGroupFilterServiceClient> mockGrpcClient = new moq::Mock<AssetGroupListingGroupFilterService.AssetGroupListingGroupFilterServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupListingGroupFiltersRequest request = new MutateAssetGroupListingGroupFiltersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupListingGroupFilterOperation(),
                },
            };
            MutateAssetGroupListingGroupFiltersResponse expectedResponse = new MutateAssetGroupListingGroupFiltersResponse
            {
                Results =
                {
                    new MutateAssetGroupListingGroupFilterResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroupListingGroupFilters(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetGroupListingGroupFilterServiceClient client = new AssetGroupListingGroupFilterServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetGroupListingGroupFiltersResponse response = client.MutateAssetGroupListingGroupFilters(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAssetGroupListingGroupFiltersAsync()
        {
            moq::Mock<AssetGroupListingGroupFilterService.AssetGroupListingGroupFilterServiceClient> mockGrpcClient = new moq::Mock<AssetGroupListingGroupFilterService.AssetGroupListingGroupFilterServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupListingGroupFiltersRequest request = new MutateAssetGroupListingGroupFiltersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupListingGroupFilterOperation(),
                },
            };
            MutateAssetGroupListingGroupFiltersResponse expectedResponse = new MutateAssetGroupListingGroupFiltersResponse
            {
                Results =
                {
                    new MutateAssetGroupListingGroupFilterResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroupListingGroupFiltersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetGroupListingGroupFiltersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetGroupListingGroupFilterServiceClient client = new AssetGroupListingGroupFilterServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetGroupListingGroupFiltersResponse responseCallSettings = await client.MutateAssetGroupListingGroupFiltersAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetGroupListingGroupFiltersResponse responseCancellationToken = await client.MutateAssetGroupListingGroupFiltersAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

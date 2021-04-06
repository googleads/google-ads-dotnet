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
    public sealed class GeneratedAssetServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAssetRequestObject()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            GetAssetRequest request = new GetAssetRequest
            {
                ResourceNameAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
            };
            gagvr::Asset expectedResponse = new gagvr::Asset
            {
                ResourceNameAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
                Id = -6774108720365892680L,
                AssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
                Type = gagve::AssetTypeEnum.Types.AssetType.Image,
                YoutubeVideoAsset = new gagvc::YoutubeVideoAsset(),
                MediaBundleAsset = new gagvc::MediaBundleAsset(),
                ImageAsset = new gagvc::ImageAsset(),
                TextAsset = new gagvc::TextAsset(),
                BookOnGoogleAsset = new gagvc::BookOnGoogleAsset(),
            };
            mockGrpcClient.Setup(x => x.GetAsset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Asset response = client.GetAsset(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAssetRequestObjectAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            GetAssetRequest request = new GetAssetRequest
            {
                ResourceNameAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
            };
            gagvr::Asset expectedResponse = new gagvr::Asset
            {
                ResourceNameAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
                Id = -6774108720365892680L,
                AssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
                Type = gagve::AssetTypeEnum.Types.AssetType.Image,
                YoutubeVideoAsset = new gagvc::YoutubeVideoAsset(),
                MediaBundleAsset = new gagvc::MediaBundleAsset(),
                ImageAsset = new gagvc::ImageAsset(),
                TextAsset = new gagvc::TextAsset(),
                BookOnGoogleAsset = new gagvc::BookOnGoogleAsset(),
            };
            mockGrpcClient.Setup(x => x.GetAssetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Asset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Asset responseCallSettings = await client.GetAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Asset responseCancellationToken = await client.GetAssetAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAsset()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            GetAssetRequest request = new GetAssetRequest
            {
                ResourceNameAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
            };
            gagvr::Asset expectedResponse = new gagvr::Asset
            {
                ResourceNameAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
                Id = -6774108720365892680L,
                AssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
                Type = gagve::AssetTypeEnum.Types.AssetType.Image,
                YoutubeVideoAsset = new gagvc::YoutubeVideoAsset(),
                MediaBundleAsset = new gagvc::MediaBundleAsset(),
                ImageAsset = new gagvc::ImageAsset(),
                TextAsset = new gagvc::TextAsset(),
                BookOnGoogleAsset = new gagvc::BookOnGoogleAsset(),
            };
            mockGrpcClient.Setup(x => x.GetAsset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Asset response = client.GetAsset(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAssetAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            GetAssetRequest request = new GetAssetRequest
            {
                ResourceNameAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
            };
            gagvr::Asset expectedResponse = new gagvr::Asset
            {
                ResourceNameAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
                Id = -6774108720365892680L,
                AssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
                Type = gagve::AssetTypeEnum.Types.AssetType.Image,
                YoutubeVideoAsset = new gagvc::YoutubeVideoAsset(),
                MediaBundleAsset = new gagvc::MediaBundleAsset(),
                ImageAsset = new gagvc::ImageAsset(),
                TextAsset = new gagvc::TextAsset(),
                BookOnGoogleAsset = new gagvc::BookOnGoogleAsset(),
            };
            mockGrpcClient.Setup(x => x.GetAssetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Asset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Asset responseCallSettings = await client.GetAssetAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Asset responseCancellationToken = await client.GetAssetAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAssetResourceNames()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            GetAssetRequest request = new GetAssetRequest
            {
                ResourceNameAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
            };
            gagvr::Asset expectedResponse = new gagvr::Asset
            {
                ResourceNameAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
                Id = -6774108720365892680L,
                AssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
                Type = gagve::AssetTypeEnum.Types.AssetType.Image,
                YoutubeVideoAsset = new gagvc::YoutubeVideoAsset(),
                MediaBundleAsset = new gagvc::MediaBundleAsset(),
                ImageAsset = new gagvc::ImageAsset(),
                TextAsset = new gagvc::TextAsset(),
                BookOnGoogleAsset = new gagvc::BookOnGoogleAsset(),
            };
            mockGrpcClient.Setup(x => x.GetAsset(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Asset response = client.GetAsset(request.ResourceNameAsAssetName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAssetResourceNamesAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            GetAssetRequest request = new GetAssetRequest
            {
                ResourceNameAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
            };
            gagvr::Asset expectedResponse = new gagvr::Asset
            {
                ResourceNameAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
                Id = -6774108720365892680L,
                AssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
                Type = gagve::AssetTypeEnum.Types.AssetType.Image,
                YoutubeVideoAsset = new gagvc::YoutubeVideoAsset(),
                MediaBundleAsset = new gagvc::MediaBundleAsset(),
                ImageAsset = new gagvc::ImageAsset(),
                TextAsset = new gagvc::TextAsset(),
                BookOnGoogleAsset = new gagvc::BookOnGoogleAsset(),
            };
            mockGrpcClient.Setup(x => x.GetAssetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Asset>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Asset responseCallSettings = await client.GetAssetAsync(request.ResourceNameAsAssetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Asset responseCancellationToken = await client.GetAssetAsync(request.ResourceNameAsAssetName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAssetsRequestObject()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetsRequest request = new MutateAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetOperation(),
                },
            };
            MutateAssetsResponse expectedResponse = new MutateAssetsResponse
            {
                Results =
                {
                    new MutateAssetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateAssets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetsResponse response = client.MutateAssets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAssetsRequestObjectAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetsRequest request = new MutateAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetOperation(),
                },
            };
            MutateAssetsResponse expectedResponse = new MutateAssetsResponse
            {
                Results =
                {
                    new MutateAssetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateAssetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetsResponse responseCallSettings = await client.MutateAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetsResponse responseCancellationToken = await client.MutateAssetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAssets()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetsRequest request = new MutateAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetOperation(),
                },
            };
            MutateAssetsResponse expectedResponse = new MutateAssetsResponse
            {
                Results =
                {
                    new MutateAssetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateAssets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetsResponse response = client.MutateAssets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAssetsAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            MutateAssetsRequest request = new MutateAssetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetOperation(),
                },
            };
            MutateAssetsResponse expectedResponse = new MutateAssetsResponse
            {
                Results =
                {
                    new MutateAssetResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateAssetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetsResponse responseCallSettings = await client.MutateAssetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetsResponse responseCancellationToken = await client.MutateAssetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

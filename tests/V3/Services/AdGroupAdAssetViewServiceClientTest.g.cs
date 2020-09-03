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

using gagve = Google.Ads.GoogleAds.V3.Enums;
using gagvr = Google.Ads.GoogleAds.V3.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V3.Services;

namespace Google.Ads.GoogleAds.Tests.V3.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdGroupAdAssetViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAdGroupAdAssetViewRequestObject()
        {
            moq::Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdAssetViewRequest request = new GetAdGroupAdAssetViewRequest
            {
                ResourceNameAsAdGroupAdAssetViewName = gagvr::AdGroupAdAssetViewName.FromCustomerAdGroupAdAssetView("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]"),
            };
            gagvr::AdGroupAdAssetView expectedResponse = new gagvr::AdGroupAdAssetView
            {
                ResourceNameAsAdGroupAdAssetViewName = gagvr::AdGroupAdAssetViewName.FromCustomerAdGroupAdAssetView("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
                PolicySummary = new gagvr::AdGroupAdAssetPolicySummary(),
                PerformanceLabel = gagve::AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Pending,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdAssetView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAdAssetViewServiceClient client = new AdGroupAdAssetViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAdAssetView response = client.GetAdGroupAdAssetView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupAdAssetViewRequestObjectAsync()
        {
            moq::Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdAssetViewRequest request = new GetAdGroupAdAssetViewRequest
            {
                ResourceNameAsAdGroupAdAssetViewName = gagvr::AdGroupAdAssetViewName.FromCustomerAdGroupAdAssetView("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]"),
            };
            gagvr::AdGroupAdAssetView expectedResponse = new gagvr::AdGroupAdAssetView
            {
                ResourceNameAsAdGroupAdAssetViewName = gagvr::AdGroupAdAssetViewName.FromCustomerAdGroupAdAssetView("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
                PolicySummary = new gagvr::AdGroupAdAssetPolicySummary(),
                PerformanceLabel = gagve::AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Pending,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdAssetViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupAdAssetView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdAssetViewServiceClient client = new AdGroupAdAssetViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAdAssetView responseCallSettings = await client.GetAdGroupAdAssetViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupAdAssetView responseCancellationToken = await client.GetAdGroupAdAssetViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupAdAssetView()
        {
            moq::Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdAssetViewRequest request = new GetAdGroupAdAssetViewRequest
            {
                ResourceNameAsAdGroupAdAssetViewName = gagvr::AdGroupAdAssetViewName.FromCustomerAdGroupAdAssetView("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]"),
            };
            gagvr::AdGroupAdAssetView expectedResponse = new gagvr::AdGroupAdAssetView
            {
                ResourceNameAsAdGroupAdAssetViewName = gagvr::AdGroupAdAssetViewName.FromCustomerAdGroupAdAssetView("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
                PolicySummary = new gagvr::AdGroupAdAssetPolicySummary(),
                PerformanceLabel = gagve::AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Pending,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdAssetView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAdAssetViewServiceClient client = new AdGroupAdAssetViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAdAssetView response = client.GetAdGroupAdAssetView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupAdAssetViewAsync()
        {
            moq::Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdAssetViewRequest request = new GetAdGroupAdAssetViewRequest
            {
                ResourceNameAsAdGroupAdAssetViewName = gagvr::AdGroupAdAssetViewName.FromCustomerAdGroupAdAssetView("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]"),
            };
            gagvr::AdGroupAdAssetView expectedResponse = new gagvr::AdGroupAdAssetView
            {
                ResourceNameAsAdGroupAdAssetViewName = gagvr::AdGroupAdAssetViewName.FromCustomerAdGroupAdAssetView("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
                PolicySummary = new gagvr::AdGroupAdAssetPolicySummary(),
                PerformanceLabel = gagve::AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Pending,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdAssetViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupAdAssetView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdAssetViewServiceClient client = new AdGroupAdAssetViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAdAssetView responseCallSettings = await client.GetAdGroupAdAssetViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupAdAssetView responseCancellationToken = await client.GetAdGroupAdAssetViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupAdAssetViewResourceNames()
        {
            moq::Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdAssetViewRequest request = new GetAdGroupAdAssetViewRequest
            {
                ResourceNameAsAdGroupAdAssetViewName = gagvr::AdGroupAdAssetViewName.FromCustomerAdGroupAdAssetView("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]"),
            };
            gagvr::AdGroupAdAssetView expectedResponse = new gagvr::AdGroupAdAssetView
            {
                ResourceNameAsAdGroupAdAssetViewName = gagvr::AdGroupAdAssetViewName.FromCustomerAdGroupAdAssetView("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
                PolicySummary = new gagvr::AdGroupAdAssetPolicySummary(),
                PerformanceLabel = gagve::AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Pending,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdAssetView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAdAssetViewServiceClient client = new AdGroupAdAssetViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAdAssetView response = client.GetAdGroupAdAssetView(request.ResourceNameAsAdGroupAdAssetViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupAdAssetViewResourceNamesAsync()
        {
            moq::Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdAssetViewRequest request = new GetAdGroupAdAssetViewRequest
            {
                ResourceNameAsAdGroupAdAssetViewName = gagvr::AdGroupAdAssetViewName.FromCustomerAdGroupAdAssetView("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]"),
            };
            gagvr::AdGroupAdAssetView expectedResponse = new gagvr::AdGroupAdAssetView
            {
                ResourceNameAsAdGroupAdAssetViewName = gagvr::AdGroupAdAssetViewName.FromCustomerAdGroupAdAssetView("[CUSTOMER]", "[AD_GROUP_AD_ASSET_VIEW]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
                PolicySummary = new gagvr::AdGroupAdAssetPolicySummary(),
                PerformanceLabel = gagve::AssetPerformanceLabelEnum.Types.AssetPerformanceLabel.Pending,
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                AssetAsAssetName = gagvr::AssetName.FromCustomerAsset("[CUSTOMER]", "[ASSET]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdAssetViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupAdAssetView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdAssetViewServiceClient client = new AdGroupAdAssetViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAdAssetView responseCallSettings = await client.GetAdGroupAdAssetViewAsync(request.ResourceNameAsAdGroupAdAssetViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupAdAssetView responseCancellationToken = await client.GetAdGroupAdAssetViewAsync(request.ResourceNameAsAdGroupAdAssetViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

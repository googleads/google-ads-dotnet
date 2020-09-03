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
    public sealed class GeneratedGeoTargetConstantServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetGeoTargetConstantRequestObject()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            GetGeoTargetConstantRequest request = new GetGeoTargetConstantRequest
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
            };
            gagvr::GeoTargetConstant expectedResponse = new gagvr::GeoTargetConstant
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                Id = -6774108720365892680L,
                GeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                CountryCode = "country_code8debec55",
                TargetType = "target_type1235462e",
                Status = gagve::GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus.Enabled,
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetGeoTargetConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeoTargetConstant response = client.GetGeoTargetConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetGeoTargetConstantRequestObjectAsync()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            GetGeoTargetConstantRequest request = new GetGeoTargetConstantRequest
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
            };
            gagvr::GeoTargetConstant expectedResponse = new gagvr::GeoTargetConstant
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                Id = -6774108720365892680L,
                GeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                CountryCode = "country_code8debec55",
                TargetType = "target_type1235462e",
                Status = gagve::GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus.Enabled,
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetGeoTargetConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GeoTargetConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeoTargetConstant responseCallSettings = await client.GetGeoTargetConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::GeoTargetConstant responseCancellationToken = await client.GetGeoTargetConstantAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetGeoTargetConstant()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            GetGeoTargetConstantRequest request = new GetGeoTargetConstantRequest
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
            };
            gagvr::GeoTargetConstant expectedResponse = new gagvr::GeoTargetConstant
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                Id = -6774108720365892680L,
                GeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                CountryCode = "country_code8debec55",
                TargetType = "target_type1235462e",
                Status = gagve::GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus.Enabled,
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetGeoTargetConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeoTargetConstant response = client.GetGeoTargetConstant(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetGeoTargetConstantAsync()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            GetGeoTargetConstantRequest request = new GetGeoTargetConstantRequest
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
            };
            gagvr::GeoTargetConstant expectedResponse = new gagvr::GeoTargetConstant
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                Id = -6774108720365892680L,
                GeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                CountryCode = "country_code8debec55",
                TargetType = "target_type1235462e",
                Status = gagve::GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus.Enabled,
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetGeoTargetConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GeoTargetConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeoTargetConstant responseCallSettings = await client.GetGeoTargetConstantAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::GeoTargetConstant responseCancellationToken = await client.GetGeoTargetConstantAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetGeoTargetConstantResourceNames()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            GetGeoTargetConstantRequest request = new GetGeoTargetConstantRequest
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
            };
            gagvr::GeoTargetConstant expectedResponse = new gagvr::GeoTargetConstant
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                Id = -6774108720365892680L,
                GeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                CountryCode = "country_code8debec55",
                TargetType = "target_type1235462e",
                Status = gagve::GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus.Enabled,
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetGeoTargetConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeoTargetConstant response = client.GetGeoTargetConstant(request.ResourceNameAsGeoTargetConstantName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetGeoTargetConstantResourceNamesAsync()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            GetGeoTargetConstantRequest request = new GetGeoTargetConstantRequest
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
            };
            gagvr::GeoTargetConstant expectedResponse = new gagvr::GeoTargetConstant
            {
                ResourceNameAsGeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                Id = -6774108720365892680L,
                GeoTargetConstantName = gagvr::GeoTargetConstantName.FromGeoTargetConstant("[GEO_TARGET_CONSTANT]"),
                CountryCode = "country_code8debec55",
                TargetType = "target_type1235462e",
                Status = gagve::GeoTargetConstantStatusEnum.Types.GeoTargetConstantStatus.Enabled,
                CanonicalName = "canonical_name5e3d81e6",
            };
            mockGrpcClient.Setup(x => x.GetGeoTargetConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GeoTargetConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeoTargetConstant responseCallSettings = await client.GetGeoTargetConstantAsync(request.ResourceNameAsGeoTargetConstantName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::GeoTargetConstant responseCancellationToken = await client.GetGeoTargetConstantAsync(request.ResourceNameAsGeoTargetConstantName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void SuggestGeoTargetConstantsRequestObject()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            SuggestGeoTargetConstantsRequest request = new SuggestGeoTargetConstantsRequest
            {
                LocationNames = new SuggestGeoTargetConstantsRequest.Types.LocationNames(),
                GeoTargets = new SuggestGeoTargetConstantsRequest.Types.GeoTargets(),
                Locale = "locale9e6d21fb",
                CountryCode = "country_code8debec55",
            };
            SuggestGeoTargetConstantsResponse expectedResponse = new SuggestGeoTargetConstantsResponse
            {
                GeoTargetConstantSuggestions =
                {
                    new GeoTargetConstantSuggestion(),
                },
            };
            mockGrpcClient.Setup(x => x.SuggestGeoTargetConstants(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
            SuggestGeoTargetConstantsResponse response = client.SuggestGeoTargetConstants(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task SuggestGeoTargetConstantsRequestObjectAsync()
        {
            moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient> mockGrpcClient = new moq::Mock<GeoTargetConstantService.GeoTargetConstantServiceClient>(moq::MockBehavior.Strict);
            SuggestGeoTargetConstantsRequest request = new SuggestGeoTargetConstantsRequest
            {
                LocationNames = new SuggestGeoTargetConstantsRequest.Types.LocationNames(),
                GeoTargets = new SuggestGeoTargetConstantsRequest.Types.GeoTargets(),
                Locale = "locale9e6d21fb",
                CountryCode = "country_code8debec55",
            };
            SuggestGeoTargetConstantsResponse expectedResponse = new SuggestGeoTargetConstantsResponse
            {
                GeoTargetConstantSuggestions =
                {
                    new GeoTargetConstantSuggestion(),
                },
            };
            mockGrpcClient.Setup(x => x.SuggestGeoTargetConstantsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SuggestGeoTargetConstantsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GeoTargetConstantServiceClient client = new GeoTargetConstantServiceClientImpl(mockGrpcClient.Object, null);
            SuggestGeoTargetConstantsResponse responseCallSettings = await client.SuggestGeoTargetConstantsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            SuggestGeoTargetConstantsResponse responseCancellationToken = await client.SuggestGeoTargetConstantsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

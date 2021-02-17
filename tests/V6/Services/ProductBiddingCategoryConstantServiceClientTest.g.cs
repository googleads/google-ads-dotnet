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
    public sealed class GeneratedProductBiddingCategoryConstantServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetProductBiddingCategoryConstantRequestObject()
        {
            moq::Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient> mockGrpcClient = new moq::Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient>(moq::MockBehavior.Strict);
            GetProductBiddingCategoryConstantRequest request = new GetProductBiddingCategoryConstantRequest
            {
                ResourceNameAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
            };
            gagvr::ProductBiddingCategoryConstant expectedResponse = new gagvr::ProductBiddingCategoryConstant
            {
                ResourceNameAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
                Level = gagve::ProductBiddingCategoryLevelEnum.Types.ProductBiddingCategoryLevel.Unknown,
                Status = gagve::ProductBiddingCategoryStatusEnum.Types.ProductBiddingCategoryStatus.Active,
                Id = -6774108720365892680L,
                CountryCode = "country_code8debec55",
                ProductBiddingCategoryConstantParentAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
                LanguageCode = "language_code2f6c7160",
                LocalizedName = "localized_namefc402dfa",
            };
            mockGrpcClient.Setup(x => x.GetProductBiddingCategoryConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductBiddingCategoryConstantServiceClient client = new ProductBiddingCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ProductBiddingCategoryConstant response = client.GetProductBiddingCategoryConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetProductBiddingCategoryConstantRequestObjectAsync()
        {
            moq::Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient> mockGrpcClient = new moq::Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient>(moq::MockBehavior.Strict);
            GetProductBiddingCategoryConstantRequest request = new GetProductBiddingCategoryConstantRequest
            {
                ResourceNameAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
            };
            gagvr::ProductBiddingCategoryConstant expectedResponse = new gagvr::ProductBiddingCategoryConstant
            {
                ResourceNameAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
                Level = gagve::ProductBiddingCategoryLevelEnum.Types.ProductBiddingCategoryLevel.Unknown,
                Status = gagve::ProductBiddingCategoryStatusEnum.Types.ProductBiddingCategoryStatus.Active,
                Id = -6774108720365892680L,
                CountryCode = "country_code8debec55",
                ProductBiddingCategoryConstantParentAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
                LanguageCode = "language_code2f6c7160",
                LocalizedName = "localized_namefc402dfa",
            };
            mockGrpcClient.Setup(x => x.GetProductBiddingCategoryConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ProductBiddingCategoryConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductBiddingCategoryConstantServiceClient client = new ProductBiddingCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ProductBiddingCategoryConstant responseCallSettings = await client.GetProductBiddingCategoryConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ProductBiddingCategoryConstant responseCancellationToken = await client.GetProductBiddingCategoryConstantAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetProductBiddingCategoryConstant()
        {
            moq::Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient> mockGrpcClient = new moq::Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient>(moq::MockBehavior.Strict);
            GetProductBiddingCategoryConstantRequest request = new GetProductBiddingCategoryConstantRequest
            {
                ResourceNameAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
            };
            gagvr::ProductBiddingCategoryConstant expectedResponse = new gagvr::ProductBiddingCategoryConstant
            {
                ResourceNameAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
                Level = gagve::ProductBiddingCategoryLevelEnum.Types.ProductBiddingCategoryLevel.Unknown,
                Status = gagve::ProductBiddingCategoryStatusEnum.Types.ProductBiddingCategoryStatus.Active,
                Id = -6774108720365892680L,
                CountryCode = "country_code8debec55",
                ProductBiddingCategoryConstantParentAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
                LanguageCode = "language_code2f6c7160",
                LocalizedName = "localized_namefc402dfa",
            };
            mockGrpcClient.Setup(x => x.GetProductBiddingCategoryConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductBiddingCategoryConstantServiceClient client = new ProductBiddingCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ProductBiddingCategoryConstant response = client.GetProductBiddingCategoryConstant(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetProductBiddingCategoryConstantAsync()
        {
            moq::Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient> mockGrpcClient = new moq::Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient>(moq::MockBehavior.Strict);
            GetProductBiddingCategoryConstantRequest request = new GetProductBiddingCategoryConstantRequest
            {
                ResourceNameAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
            };
            gagvr::ProductBiddingCategoryConstant expectedResponse = new gagvr::ProductBiddingCategoryConstant
            {
                ResourceNameAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
                Level = gagve::ProductBiddingCategoryLevelEnum.Types.ProductBiddingCategoryLevel.Unknown,
                Status = gagve::ProductBiddingCategoryStatusEnum.Types.ProductBiddingCategoryStatus.Active,
                Id = -6774108720365892680L,
                CountryCode = "country_code8debec55",
                ProductBiddingCategoryConstantParentAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
                LanguageCode = "language_code2f6c7160",
                LocalizedName = "localized_namefc402dfa",
            };
            mockGrpcClient.Setup(x => x.GetProductBiddingCategoryConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ProductBiddingCategoryConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductBiddingCategoryConstantServiceClient client = new ProductBiddingCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ProductBiddingCategoryConstant responseCallSettings = await client.GetProductBiddingCategoryConstantAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ProductBiddingCategoryConstant responseCancellationToken = await client.GetProductBiddingCategoryConstantAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetProductBiddingCategoryConstantResourceNames()
        {
            moq::Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient> mockGrpcClient = new moq::Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient>(moq::MockBehavior.Strict);
            GetProductBiddingCategoryConstantRequest request = new GetProductBiddingCategoryConstantRequest
            {
                ResourceNameAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
            };
            gagvr::ProductBiddingCategoryConstant expectedResponse = new gagvr::ProductBiddingCategoryConstant
            {
                ResourceNameAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
                Level = gagve::ProductBiddingCategoryLevelEnum.Types.ProductBiddingCategoryLevel.Unknown,
                Status = gagve::ProductBiddingCategoryStatusEnum.Types.ProductBiddingCategoryStatus.Active,
                Id = -6774108720365892680L,
                CountryCode = "country_code8debec55",
                ProductBiddingCategoryConstantParentAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
                LanguageCode = "language_code2f6c7160",
                LocalizedName = "localized_namefc402dfa",
            };
            mockGrpcClient.Setup(x => x.GetProductBiddingCategoryConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ProductBiddingCategoryConstantServiceClient client = new ProductBiddingCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ProductBiddingCategoryConstant response = client.GetProductBiddingCategoryConstant(request.ResourceNameAsProductBiddingCategoryConstantName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetProductBiddingCategoryConstantResourceNamesAsync()
        {
            moq::Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient> mockGrpcClient = new moq::Mock<ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient>(moq::MockBehavior.Strict);
            GetProductBiddingCategoryConstantRequest request = new GetProductBiddingCategoryConstantRequest
            {
                ResourceNameAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
            };
            gagvr::ProductBiddingCategoryConstant expectedResponse = new gagvr::ProductBiddingCategoryConstant
            {
                ResourceNameAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
                Level = gagve::ProductBiddingCategoryLevelEnum.Types.ProductBiddingCategoryLevel.Unknown,
                Status = gagve::ProductBiddingCategoryStatusEnum.Types.ProductBiddingCategoryStatus.Active,
                Id = -6774108720365892680L,
                CountryCode = "country_code8debec55",
                ProductBiddingCategoryConstantParentAsProductBiddingCategoryConstantName = gagvr::ProductBiddingCategoryConstantName.FromCountryCodeLevelId("[COUNTRY_CODE]", "[LEVEL]", "[ID]"),
                LanguageCode = "language_code2f6c7160",
                LocalizedName = "localized_namefc402dfa",
            };
            mockGrpcClient.Setup(x => x.GetProductBiddingCategoryConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ProductBiddingCategoryConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ProductBiddingCategoryConstantServiceClient client = new ProductBiddingCategoryConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ProductBiddingCategoryConstant responseCallSettings = await client.GetProductBiddingCategoryConstantAsync(request.ResourceNameAsProductBiddingCategoryConstantName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ProductBiddingCategoryConstant responseCancellationToken = await client.GetProductBiddingCategoryConstantAsync(request.ResourceNameAsProductBiddingCategoryConstantName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

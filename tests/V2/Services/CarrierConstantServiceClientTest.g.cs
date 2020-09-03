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

using gagvr = Google.Ads.GoogleAds.V2.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V2.Services;

namespace Google.Ads.GoogleAds.Tests.V2.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCarrierConstantServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCarrierConstantRequestObject()
        {
            moq::Mock<CarrierConstantService.CarrierConstantServiceClient> mockGrpcClient = new moq::Mock<CarrierConstantService.CarrierConstantServiceClient>(moq::MockBehavior.Strict);
            GetCarrierConstantRequest request = new GetCarrierConstantRequest
            {
                ResourceNameAsCarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
            };
            gagvr::CarrierConstant expectedResponse = new gagvr::CarrierConstant
            {
                ResourceNameAsCarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
                Id = -6774108720365892680L,
                CarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
                CountryCode = "country_code8debec55",
            };
            mockGrpcClient.Setup(x => x.GetCarrierConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CarrierConstantServiceClient client = new CarrierConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CarrierConstant response = client.GetCarrierConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCarrierConstantRequestObjectAsync()
        {
            moq::Mock<CarrierConstantService.CarrierConstantServiceClient> mockGrpcClient = new moq::Mock<CarrierConstantService.CarrierConstantServiceClient>(moq::MockBehavior.Strict);
            GetCarrierConstantRequest request = new GetCarrierConstantRequest
            {
                ResourceNameAsCarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
            };
            gagvr::CarrierConstant expectedResponse = new gagvr::CarrierConstant
            {
                ResourceNameAsCarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
                Id = -6774108720365892680L,
                CarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
                CountryCode = "country_code8debec55",
            };
            mockGrpcClient.Setup(x => x.GetCarrierConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CarrierConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CarrierConstantServiceClient client = new CarrierConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CarrierConstant responseCallSettings = await client.GetCarrierConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CarrierConstant responseCancellationToken = await client.GetCarrierConstantAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCarrierConstant()
        {
            moq::Mock<CarrierConstantService.CarrierConstantServiceClient> mockGrpcClient = new moq::Mock<CarrierConstantService.CarrierConstantServiceClient>(moq::MockBehavior.Strict);
            GetCarrierConstantRequest request = new GetCarrierConstantRequest
            {
                ResourceNameAsCarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
            };
            gagvr::CarrierConstant expectedResponse = new gagvr::CarrierConstant
            {
                ResourceNameAsCarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
                Id = -6774108720365892680L,
                CarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
                CountryCode = "country_code8debec55",
            };
            mockGrpcClient.Setup(x => x.GetCarrierConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CarrierConstantServiceClient client = new CarrierConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CarrierConstant response = client.GetCarrierConstant(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCarrierConstantAsync()
        {
            moq::Mock<CarrierConstantService.CarrierConstantServiceClient> mockGrpcClient = new moq::Mock<CarrierConstantService.CarrierConstantServiceClient>(moq::MockBehavior.Strict);
            GetCarrierConstantRequest request = new GetCarrierConstantRequest
            {
                ResourceNameAsCarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
            };
            gagvr::CarrierConstant expectedResponse = new gagvr::CarrierConstant
            {
                ResourceNameAsCarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
                Id = -6774108720365892680L,
                CarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
                CountryCode = "country_code8debec55",
            };
            mockGrpcClient.Setup(x => x.GetCarrierConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CarrierConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CarrierConstantServiceClient client = new CarrierConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CarrierConstant responseCallSettings = await client.GetCarrierConstantAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CarrierConstant responseCancellationToken = await client.GetCarrierConstantAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCarrierConstantResourceNames()
        {
            moq::Mock<CarrierConstantService.CarrierConstantServiceClient> mockGrpcClient = new moq::Mock<CarrierConstantService.CarrierConstantServiceClient>(moq::MockBehavior.Strict);
            GetCarrierConstantRequest request = new GetCarrierConstantRequest
            {
                ResourceNameAsCarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
            };
            gagvr::CarrierConstant expectedResponse = new gagvr::CarrierConstant
            {
                ResourceNameAsCarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
                Id = -6774108720365892680L,
                CarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
                CountryCode = "country_code8debec55",
            };
            mockGrpcClient.Setup(x => x.GetCarrierConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CarrierConstantServiceClient client = new CarrierConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CarrierConstant response = client.GetCarrierConstant(request.ResourceNameAsCarrierConstantName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCarrierConstantResourceNamesAsync()
        {
            moq::Mock<CarrierConstantService.CarrierConstantServiceClient> mockGrpcClient = new moq::Mock<CarrierConstantService.CarrierConstantServiceClient>(moq::MockBehavior.Strict);
            GetCarrierConstantRequest request = new GetCarrierConstantRequest
            {
                ResourceNameAsCarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
            };
            gagvr::CarrierConstant expectedResponse = new gagvr::CarrierConstant
            {
                ResourceNameAsCarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
                Id = -6774108720365892680L,
                CarrierConstantName = gagvr::CarrierConstantName.FromCarrierConstant("[CARRIER_CONSTANT]"),
                CountryCode = "country_code8debec55",
            };
            mockGrpcClient.Setup(x => x.GetCarrierConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CarrierConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CarrierConstantServiceClient client = new CarrierConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CarrierConstant responseCallSettings = await client.GetCarrierConstantAsync(request.ResourceNameAsCarrierConstantName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CarrierConstant responseCancellationToken = await client.GetCarrierConstantAsync(request.ResourceNameAsCarrierConstantName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

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
    public sealed class GeneratedCurrencyConstantServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCurrencyConstantRequestObject()
        {
            moq::Mock<CurrencyConstantService.CurrencyConstantServiceClient> mockGrpcClient = new moq::Mock<CurrencyConstantService.CurrencyConstantServiceClient>(moq::MockBehavior.Strict);
            GetCurrencyConstantRequest request = new GetCurrencyConstantRequest
            {
                ResourceNameAsCurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
            };
            gagvr::CurrencyConstant expectedResponse = new gagvr::CurrencyConstant
            {
                ResourceNameAsCurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
                Code = "code946733c1",
                CurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
                Symbol = "symbol68f2bf97",
                BillableUnitMicros = -4065431154313687083L,
            };
            mockGrpcClient.Setup(x => x.GetCurrencyConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CurrencyConstantServiceClient client = new CurrencyConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CurrencyConstant response = client.GetCurrencyConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCurrencyConstantRequestObjectAsync()
        {
            moq::Mock<CurrencyConstantService.CurrencyConstantServiceClient> mockGrpcClient = new moq::Mock<CurrencyConstantService.CurrencyConstantServiceClient>(moq::MockBehavior.Strict);
            GetCurrencyConstantRequest request = new GetCurrencyConstantRequest
            {
                ResourceNameAsCurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
            };
            gagvr::CurrencyConstant expectedResponse = new gagvr::CurrencyConstant
            {
                ResourceNameAsCurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
                Code = "code946733c1",
                CurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
                Symbol = "symbol68f2bf97",
                BillableUnitMicros = -4065431154313687083L,
            };
            mockGrpcClient.Setup(x => x.GetCurrencyConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CurrencyConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CurrencyConstantServiceClient client = new CurrencyConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CurrencyConstant responseCallSettings = await client.GetCurrencyConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CurrencyConstant responseCancellationToken = await client.GetCurrencyConstantAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCurrencyConstant()
        {
            moq::Mock<CurrencyConstantService.CurrencyConstantServiceClient> mockGrpcClient = new moq::Mock<CurrencyConstantService.CurrencyConstantServiceClient>(moq::MockBehavior.Strict);
            GetCurrencyConstantRequest request = new GetCurrencyConstantRequest
            {
                ResourceNameAsCurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
            };
            gagvr::CurrencyConstant expectedResponse = new gagvr::CurrencyConstant
            {
                ResourceNameAsCurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
                Code = "code946733c1",
                CurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
                Symbol = "symbol68f2bf97",
                BillableUnitMicros = -4065431154313687083L,
            };
            mockGrpcClient.Setup(x => x.GetCurrencyConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CurrencyConstantServiceClient client = new CurrencyConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CurrencyConstant response = client.GetCurrencyConstant(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCurrencyConstantAsync()
        {
            moq::Mock<CurrencyConstantService.CurrencyConstantServiceClient> mockGrpcClient = new moq::Mock<CurrencyConstantService.CurrencyConstantServiceClient>(moq::MockBehavior.Strict);
            GetCurrencyConstantRequest request = new GetCurrencyConstantRequest
            {
                ResourceNameAsCurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
            };
            gagvr::CurrencyConstant expectedResponse = new gagvr::CurrencyConstant
            {
                ResourceNameAsCurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
                Code = "code946733c1",
                CurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
                Symbol = "symbol68f2bf97",
                BillableUnitMicros = -4065431154313687083L,
            };
            mockGrpcClient.Setup(x => x.GetCurrencyConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CurrencyConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CurrencyConstantServiceClient client = new CurrencyConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CurrencyConstant responseCallSettings = await client.GetCurrencyConstantAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CurrencyConstant responseCancellationToken = await client.GetCurrencyConstantAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCurrencyConstantResourceNames()
        {
            moq::Mock<CurrencyConstantService.CurrencyConstantServiceClient> mockGrpcClient = new moq::Mock<CurrencyConstantService.CurrencyConstantServiceClient>(moq::MockBehavior.Strict);
            GetCurrencyConstantRequest request = new GetCurrencyConstantRequest
            {
                ResourceNameAsCurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
            };
            gagvr::CurrencyConstant expectedResponse = new gagvr::CurrencyConstant
            {
                ResourceNameAsCurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
                Code = "code946733c1",
                CurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
                Symbol = "symbol68f2bf97",
                BillableUnitMicros = -4065431154313687083L,
            };
            mockGrpcClient.Setup(x => x.GetCurrencyConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CurrencyConstantServiceClient client = new CurrencyConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CurrencyConstant response = client.GetCurrencyConstant(request.ResourceNameAsCurrencyConstantName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCurrencyConstantResourceNamesAsync()
        {
            moq::Mock<CurrencyConstantService.CurrencyConstantServiceClient> mockGrpcClient = new moq::Mock<CurrencyConstantService.CurrencyConstantServiceClient>(moq::MockBehavior.Strict);
            GetCurrencyConstantRequest request = new GetCurrencyConstantRequest
            {
                ResourceNameAsCurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
            };
            gagvr::CurrencyConstant expectedResponse = new gagvr::CurrencyConstant
            {
                ResourceNameAsCurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
                Code = "code946733c1",
                CurrencyConstantName = gagvr::CurrencyConstantName.FromCurrencyConstant("[CURRENCY_CONSTANT]"),
                Symbol = "symbol68f2bf97",
                BillableUnitMicros = -4065431154313687083L,
            };
            mockGrpcClient.Setup(x => x.GetCurrencyConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CurrencyConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CurrencyConstantServiceClient client = new CurrencyConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CurrencyConstant responseCallSettings = await client.GetCurrencyConstantAsync(request.ResourceNameAsCurrencyConstantName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CurrencyConstant responseCancellationToken = await client.GetCurrencyConstantAsync(request.ResourceNameAsCurrencyConstantName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

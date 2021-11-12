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

using gagvr = Google.Ads.GoogleAds.V9.Resources;
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
    public sealed class GeneratedHotelPerformanceViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetHotelPerformanceViewRequestObject()
        {
            moq::Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient> mockGrpcClient = new moq::Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient>(moq::MockBehavior.Strict);
            GetHotelPerformanceViewRequest request = new GetHotelPerformanceViewRequest
            {
                ResourceNameAsHotelPerformanceViewName = gagvr::HotelPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            gagvr::HotelPerformanceView expectedResponse = new gagvr::HotelPerformanceView
            {
                ResourceNameAsHotelPerformanceViewName = gagvr::HotelPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetHotelPerformanceView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HotelPerformanceViewServiceClient client = new HotelPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::HotelPerformanceView response = client.GetHotelPerformanceView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetHotelPerformanceViewRequestObjectAsync()
        {
            moq::Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient> mockGrpcClient = new moq::Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient>(moq::MockBehavior.Strict);
            GetHotelPerformanceViewRequest request = new GetHotelPerformanceViewRequest
            {
                ResourceNameAsHotelPerformanceViewName = gagvr::HotelPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            gagvr::HotelPerformanceView expectedResponse = new gagvr::HotelPerformanceView
            {
                ResourceNameAsHotelPerformanceViewName = gagvr::HotelPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetHotelPerformanceViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::HotelPerformanceView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HotelPerformanceViewServiceClient client = new HotelPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::HotelPerformanceView responseCallSettings = await client.GetHotelPerformanceViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::HotelPerformanceView responseCancellationToken = await client.GetHotelPerformanceViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetHotelPerformanceView()
        {
            moq::Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient> mockGrpcClient = new moq::Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient>(moq::MockBehavior.Strict);
            GetHotelPerformanceViewRequest request = new GetHotelPerformanceViewRequest
            {
                ResourceNameAsHotelPerformanceViewName = gagvr::HotelPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            gagvr::HotelPerformanceView expectedResponse = new gagvr::HotelPerformanceView
            {
                ResourceNameAsHotelPerformanceViewName = gagvr::HotelPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetHotelPerformanceView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HotelPerformanceViewServiceClient client = new HotelPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::HotelPerformanceView response = client.GetHotelPerformanceView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetHotelPerformanceViewAsync()
        {
            moq::Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient> mockGrpcClient = new moq::Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient>(moq::MockBehavior.Strict);
            GetHotelPerformanceViewRequest request = new GetHotelPerformanceViewRequest
            {
                ResourceNameAsHotelPerformanceViewName = gagvr::HotelPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            gagvr::HotelPerformanceView expectedResponse = new gagvr::HotelPerformanceView
            {
                ResourceNameAsHotelPerformanceViewName = gagvr::HotelPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetHotelPerformanceViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::HotelPerformanceView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HotelPerformanceViewServiceClient client = new HotelPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::HotelPerformanceView responseCallSettings = await client.GetHotelPerformanceViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::HotelPerformanceView responseCancellationToken = await client.GetHotelPerformanceViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetHotelPerformanceViewResourceNames()
        {
            moq::Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient> mockGrpcClient = new moq::Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient>(moq::MockBehavior.Strict);
            GetHotelPerformanceViewRequest request = new GetHotelPerformanceViewRequest
            {
                ResourceNameAsHotelPerformanceViewName = gagvr::HotelPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            gagvr::HotelPerformanceView expectedResponse = new gagvr::HotelPerformanceView
            {
                ResourceNameAsHotelPerformanceViewName = gagvr::HotelPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetHotelPerformanceView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HotelPerformanceViewServiceClient client = new HotelPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::HotelPerformanceView response = client.GetHotelPerformanceView(request.ResourceNameAsHotelPerformanceViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetHotelPerformanceViewResourceNamesAsync()
        {
            moq::Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient> mockGrpcClient = new moq::Mock<HotelPerformanceViewService.HotelPerformanceViewServiceClient>(moq::MockBehavior.Strict);
            GetHotelPerformanceViewRequest request = new GetHotelPerformanceViewRequest
            {
                ResourceNameAsHotelPerformanceViewName = gagvr::HotelPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            gagvr::HotelPerformanceView expectedResponse = new gagvr::HotelPerformanceView
            {
                ResourceNameAsHotelPerformanceViewName = gagvr::HotelPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetHotelPerformanceViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::HotelPerformanceView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HotelPerformanceViewServiceClient client = new HotelPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::HotelPerformanceView responseCallSettings = await client.GetHotelPerformanceViewAsync(request.ResourceNameAsHotelPerformanceViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::HotelPerformanceView responseCancellationToken = await client.GetHotelPerformanceViewAsync(request.ResourceNameAsHotelPerformanceViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

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
    public sealed class GeneratedShoppingPerformanceViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetShoppingPerformanceViewRequestObject()
        {
            moq::Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient> mockGrpcClient = new moq::Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient>(moq::MockBehavior.Strict);
            GetShoppingPerformanceViewRequest request = new GetShoppingPerformanceViewRequest
            {
                ResourceNameAsShoppingPerformanceViewName = gagvr::ShoppingPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            gagvr::ShoppingPerformanceView expectedResponse = new gagvr::ShoppingPerformanceView
            {
                ResourceNameAsShoppingPerformanceViewName = gagvr::ShoppingPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetShoppingPerformanceView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ShoppingPerformanceViewServiceClient client = new ShoppingPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ShoppingPerformanceView response = client.GetShoppingPerformanceView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetShoppingPerformanceViewRequestObjectAsync()
        {
            moq::Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient> mockGrpcClient = new moq::Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient>(moq::MockBehavior.Strict);
            GetShoppingPerformanceViewRequest request = new GetShoppingPerformanceViewRequest
            {
                ResourceNameAsShoppingPerformanceViewName = gagvr::ShoppingPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            gagvr::ShoppingPerformanceView expectedResponse = new gagvr::ShoppingPerformanceView
            {
                ResourceNameAsShoppingPerformanceViewName = gagvr::ShoppingPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetShoppingPerformanceViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ShoppingPerformanceView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ShoppingPerformanceViewServiceClient client = new ShoppingPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ShoppingPerformanceView responseCallSettings = await client.GetShoppingPerformanceViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ShoppingPerformanceView responseCancellationToken = await client.GetShoppingPerformanceViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetShoppingPerformanceView()
        {
            moq::Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient> mockGrpcClient = new moq::Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient>(moq::MockBehavior.Strict);
            GetShoppingPerformanceViewRequest request = new GetShoppingPerformanceViewRequest
            {
                ResourceNameAsShoppingPerformanceViewName = gagvr::ShoppingPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            gagvr::ShoppingPerformanceView expectedResponse = new gagvr::ShoppingPerformanceView
            {
                ResourceNameAsShoppingPerformanceViewName = gagvr::ShoppingPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetShoppingPerformanceView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ShoppingPerformanceViewServiceClient client = new ShoppingPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ShoppingPerformanceView response = client.GetShoppingPerformanceView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetShoppingPerformanceViewAsync()
        {
            moq::Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient> mockGrpcClient = new moq::Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient>(moq::MockBehavior.Strict);
            GetShoppingPerformanceViewRequest request = new GetShoppingPerformanceViewRequest
            {
                ResourceNameAsShoppingPerformanceViewName = gagvr::ShoppingPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            gagvr::ShoppingPerformanceView expectedResponse = new gagvr::ShoppingPerformanceView
            {
                ResourceNameAsShoppingPerformanceViewName = gagvr::ShoppingPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetShoppingPerformanceViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ShoppingPerformanceView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ShoppingPerformanceViewServiceClient client = new ShoppingPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ShoppingPerformanceView responseCallSettings = await client.GetShoppingPerformanceViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ShoppingPerformanceView responseCancellationToken = await client.GetShoppingPerformanceViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetShoppingPerformanceViewResourceNames()
        {
            moq::Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient> mockGrpcClient = new moq::Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient>(moq::MockBehavior.Strict);
            GetShoppingPerformanceViewRequest request = new GetShoppingPerformanceViewRequest
            {
                ResourceNameAsShoppingPerformanceViewName = gagvr::ShoppingPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            gagvr::ShoppingPerformanceView expectedResponse = new gagvr::ShoppingPerformanceView
            {
                ResourceNameAsShoppingPerformanceViewName = gagvr::ShoppingPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetShoppingPerformanceView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ShoppingPerformanceViewServiceClient client = new ShoppingPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ShoppingPerformanceView response = client.GetShoppingPerformanceView(request.ResourceNameAsShoppingPerformanceViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetShoppingPerformanceViewResourceNamesAsync()
        {
            moq::Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient> mockGrpcClient = new moq::Mock<ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient>(moq::MockBehavior.Strict);
            GetShoppingPerformanceViewRequest request = new GetShoppingPerformanceViewRequest
            {
                ResourceNameAsShoppingPerformanceViewName = gagvr::ShoppingPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            gagvr::ShoppingPerformanceView expectedResponse = new gagvr::ShoppingPerformanceView
            {
                ResourceNameAsShoppingPerformanceViewName = gagvr::ShoppingPerformanceViewName.FromCustomer("[CUSTOMER_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetShoppingPerformanceViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ShoppingPerformanceView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ShoppingPerformanceViewServiceClient client = new ShoppingPerformanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ShoppingPerformanceView responseCallSettings = await client.GetShoppingPerformanceViewAsync(request.ResourceNameAsShoppingPerformanceViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ShoppingPerformanceView responseCancellationToken = await client.GetShoppingPerformanceViewAsync(request.ResourceNameAsShoppingPerformanceViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

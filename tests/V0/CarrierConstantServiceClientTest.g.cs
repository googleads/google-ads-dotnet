// Copyright 2018 Google LLC
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

// TODO( b/119694056): Removed Comment

namespace Google.Ads.GoogleAds.V0.Services.Tests
{
    using Google.Ads.GoogleAds.V0.Resources;
    using apis = Google.Ads.GoogleAds.V0.Services;
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using NUnit.Framework;

    /// <summary>Generated unit tests</summary>
    public class GeneratedCarrierConstantServiceClientTest
    {
        [Test]
        public void GetCarrierConstant()
        {
            Mock<CarrierConstantService.CarrierConstantServiceClient> mockGrpcClient = new Mock<CarrierConstantService.CarrierConstantServiceClient>(MockBehavior.Strict);
            GetCarrierConstantRequest expectedRequest = new GetCarrierConstantRequest
            {
                ResourceName = new CarrierConstantName("[CARRIER_CONSTANT]").ToString(),
            };
            CarrierConstant expectedResponse = new CarrierConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCarrierConstant(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CarrierConstantServiceClient client = new CarrierConstantServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CarrierConstantName("[CARRIER_CONSTANT]").ToString();
            CarrierConstant response = client.GetCarrierConstant(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCarrierConstantAsync()
        {
            Mock<CarrierConstantService.CarrierConstantServiceClient> mockGrpcClient = new Mock<CarrierConstantService.CarrierConstantServiceClient>(MockBehavior.Strict);
            GetCarrierConstantRequest expectedRequest = new GetCarrierConstantRequest
            {
                ResourceName = new CarrierConstantName("[CARRIER_CONSTANT]").ToString(),
            };
            CarrierConstant expectedResponse = new CarrierConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCarrierConstantAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CarrierConstant>(Task.FromResult(expectedResponse), null, null, null, null));
            CarrierConstantServiceClient client = new CarrierConstantServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CarrierConstantName("[CARRIER_CONSTANT]").ToString();
            CarrierConstant response = await client.GetCarrierConstantAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCarrierConstant2()
        {
            Mock<CarrierConstantService.CarrierConstantServiceClient> mockGrpcClient = new Mock<CarrierConstantService.CarrierConstantServiceClient>(MockBehavior.Strict);
            GetCarrierConstantRequest request = new GetCarrierConstantRequest
            {
                ResourceName = new CarrierConstantName("[CARRIER_CONSTANT]").ToString(),
            };
            CarrierConstant expectedResponse = new CarrierConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCarrierConstant(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CarrierConstantServiceClient client = new CarrierConstantServiceClientImpl(mockGrpcClient.Object, null);
            CarrierConstant response = client.GetCarrierConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCarrierConstantAsync2()
        {
            Mock<CarrierConstantService.CarrierConstantServiceClient> mockGrpcClient = new Mock<CarrierConstantService.CarrierConstantServiceClient>(MockBehavior.Strict);
            GetCarrierConstantRequest request = new GetCarrierConstantRequest
            {
                ResourceName = new CarrierConstantName("[CARRIER_CONSTANT]").ToString(),
            };
            CarrierConstant expectedResponse = new CarrierConstant
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCarrierConstantAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CarrierConstant>(Task.FromResult(expectedResponse), null, null, null, null));
            CarrierConstantServiceClient client = new CarrierConstantServiceClientImpl(mockGrpcClient.Object, null);
            CarrierConstant response = await client.GetCarrierConstantAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

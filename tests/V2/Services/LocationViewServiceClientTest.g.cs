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
    public sealed class GeneratedLocationViewServiceClientTest
    {
        [Test]
        public void GetLocationViewRequestObject()
        {
            moq::Mock<LocationViewService.LocationViewServiceClient> mockGrpcClient = new moq::Mock<LocationViewService.LocationViewServiceClient>(moq::MockBehavior.Strict);
            GetLocationViewRequest request = new GetLocationViewRequest
            {
                ResourceNameAsLocationViewName = gagvr::LocationViewName.FromCustomerLocationView("[CUSTOMER]", "[LOCATION_VIEW]"),
            };
            gagvr::LocationView expectedResponse = new gagvr::LocationView
            {
                ResourceNameAsLocationViewName = gagvr::LocationViewName.FromCustomerLocationView("[CUSTOMER]", "[LOCATION_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetLocationView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LocationViewServiceClient client = new LocationViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LocationView response = client.GetLocationView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetLocationViewRequestObjectAsync()
        {
            moq::Mock<LocationViewService.LocationViewServiceClient> mockGrpcClient = new moq::Mock<LocationViewService.LocationViewServiceClient>(moq::MockBehavior.Strict);
            GetLocationViewRequest request = new GetLocationViewRequest
            {
                ResourceNameAsLocationViewName = gagvr::LocationViewName.FromCustomerLocationView("[CUSTOMER]", "[LOCATION_VIEW]"),
            };
            gagvr::LocationView expectedResponse = new gagvr::LocationView
            {
                ResourceNameAsLocationViewName = gagvr::LocationViewName.FromCustomerLocationView("[CUSTOMER]", "[LOCATION_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetLocationViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::LocationView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LocationViewServiceClient client = new LocationViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LocationView responseCallSettings = await client.GetLocationViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::LocationView responseCancellationToken = await client.GetLocationViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetLocationView()
        {
            moq::Mock<LocationViewService.LocationViewServiceClient> mockGrpcClient = new moq::Mock<LocationViewService.LocationViewServiceClient>(moq::MockBehavior.Strict);
            GetLocationViewRequest request = new GetLocationViewRequest
            {
                ResourceNameAsLocationViewName = gagvr::LocationViewName.FromCustomerLocationView("[CUSTOMER]", "[LOCATION_VIEW]"),
            };
            gagvr::LocationView expectedResponse = new gagvr::LocationView
            {
                ResourceNameAsLocationViewName = gagvr::LocationViewName.FromCustomerLocationView("[CUSTOMER]", "[LOCATION_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetLocationView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LocationViewServiceClient client = new LocationViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LocationView response = client.GetLocationView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetLocationViewAsync()
        {
            moq::Mock<LocationViewService.LocationViewServiceClient> mockGrpcClient = new moq::Mock<LocationViewService.LocationViewServiceClient>(moq::MockBehavior.Strict);
            GetLocationViewRequest request = new GetLocationViewRequest
            {
                ResourceNameAsLocationViewName = gagvr::LocationViewName.FromCustomerLocationView("[CUSTOMER]", "[LOCATION_VIEW]"),
            };
            gagvr::LocationView expectedResponse = new gagvr::LocationView
            {
                ResourceNameAsLocationViewName = gagvr::LocationViewName.FromCustomerLocationView("[CUSTOMER]", "[LOCATION_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetLocationViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::LocationView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LocationViewServiceClient client = new LocationViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LocationView responseCallSettings = await client.GetLocationViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::LocationView responseCancellationToken = await client.GetLocationViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetLocationViewResourceNames()
        {
            moq::Mock<LocationViewService.LocationViewServiceClient> mockGrpcClient = new moq::Mock<LocationViewService.LocationViewServiceClient>(moq::MockBehavior.Strict);
            GetLocationViewRequest request = new GetLocationViewRequest
            {
                ResourceNameAsLocationViewName = gagvr::LocationViewName.FromCustomerLocationView("[CUSTOMER]", "[LOCATION_VIEW]"),
            };
            gagvr::LocationView expectedResponse = new gagvr::LocationView
            {
                ResourceNameAsLocationViewName = gagvr::LocationViewName.FromCustomerLocationView("[CUSTOMER]", "[LOCATION_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetLocationView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LocationViewServiceClient client = new LocationViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LocationView response = client.GetLocationView(request.ResourceNameAsLocationViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetLocationViewResourceNamesAsync()
        {
            moq::Mock<LocationViewService.LocationViewServiceClient> mockGrpcClient = new moq::Mock<LocationViewService.LocationViewServiceClient>(moq::MockBehavior.Strict);
            GetLocationViewRequest request = new GetLocationViewRequest
            {
                ResourceNameAsLocationViewName = gagvr::LocationViewName.FromCustomerLocationView("[CUSTOMER]", "[LOCATION_VIEW]"),
            };
            gagvr::LocationView expectedResponse = new gagvr::LocationView
            {
                ResourceNameAsLocationViewName = gagvr::LocationViewName.FromCustomerLocationView("[CUSTOMER]", "[LOCATION_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetLocationViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::LocationView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LocationViewServiceClient client = new LocationViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LocationView responseCallSettings = await client.GetLocationViewAsync(request.ResourceNameAsLocationViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::LocationView responseCancellationToken = await client.GetLocationViewAsync(request.ResourceNameAsLocationViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

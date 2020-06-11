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
    public sealed class GeneratedDistanceViewServiceClientTest
    {
        [Test]
        public void GetDistanceViewRequestObject()
        {
            moq::Mock<DistanceViewService.DistanceViewServiceClient> mockGrpcClient = new moq::Mock<DistanceViewService.DistanceViewServiceClient>(moq::MockBehavior.Strict);
            GetDistanceViewRequest request = new GetDistanceViewRequest
            {
                ResourceNameAsDistanceViewName = gagvr::DistanceViewName.FromCustomerDistanceView("[CUSTOMER]", "[DISTANCE_VIEW]"),
            };
            gagvr::DistanceView expectedResponse = new gagvr::DistanceView
            {
                ResourceNameAsDistanceViewName = gagvr::DistanceViewName.FromCustomerDistanceView("[CUSTOMER]", "[DISTANCE_VIEW]"),
                DistanceBucket = gagve::DistanceBucketEnum.Types.DistanceBucket.Within25Miles,
                MetricSystem = true,
            };
            mockGrpcClient.Setup(x => x.GetDistanceView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DistanceViewServiceClient client = new DistanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DistanceView response = client.GetDistanceView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetDistanceViewRequestObjectAsync()
        {
            moq::Mock<DistanceViewService.DistanceViewServiceClient> mockGrpcClient = new moq::Mock<DistanceViewService.DistanceViewServiceClient>(moq::MockBehavior.Strict);
            GetDistanceViewRequest request = new GetDistanceViewRequest
            {
                ResourceNameAsDistanceViewName = gagvr::DistanceViewName.FromCustomerDistanceView("[CUSTOMER]", "[DISTANCE_VIEW]"),
            };
            gagvr::DistanceView expectedResponse = new gagvr::DistanceView
            {
                ResourceNameAsDistanceViewName = gagvr::DistanceViewName.FromCustomerDistanceView("[CUSTOMER]", "[DISTANCE_VIEW]"),
                DistanceBucket = gagve::DistanceBucketEnum.Types.DistanceBucket.Within25Miles,
                MetricSystem = true,
            };
            mockGrpcClient.Setup(x => x.GetDistanceViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DistanceView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DistanceViewServiceClient client = new DistanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DistanceView responseCallSettings = await client.GetDistanceViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DistanceView responseCancellationToken = await client.GetDistanceViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetDistanceView()
        {
            moq::Mock<DistanceViewService.DistanceViewServiceClient> mockGrpcClient = new moq::Mock<DistanceViewService.DistanceViewServiceClient>(moq::MockBehavior.Strict);
            GetDistanceViewRequest request = new GetDistanceViewRequest
            {
                ResourceNameAsDistanceViewName = gagvr::DistanceViewName.FromCustomerDistanceView("[CUSTOMER]", "[DISTANCE_VIEW]"),
            };
            gagvr::DistanceView expectedResponse = new gagvr::DistanceView
            {
                ResourceNameAsDistanceViewName = gagvr::DistanceViewName.FromCustomerDistanceView("[CUSTOMER]", "[DISTANCE_VIEW]"),
                DistanceBucket = gagve::DistanceBucketEnum.Types.DistanceBucket.Within25Miles,
                MetricSystem = true,
            };
            mockGrpcClient.Setup(x => x.GetDistanceView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DistanceViewServiceClient client = new DistanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DistanceView response = client.GetDistanceView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetDistanceViewAsync()
        {
            moq::Mock<DistanceViewService.DistanceViewServiceClient> mockGrpcClient = new moq::Mock<DistanceViewService.DistanceViewServiceClient>(moq::MockBehavior.Strict);
            GetDistanceViewRequest request = new GetDistanceViewRequest
            {
                ResourceNameAsDistanceViewName = gagvr::DistanceViewName.FromCustomerDistanceView("[CUSTOMER]", "[DISTANCE_VIEW]"),
            };
            gagvr::DistanceView expectedResponse = new gagvr::DistanceView
            {
                ResourceNameAsDistanceViewName = gagvr::DistanceViewName.FromCustomerDistanceView("[CUSTOMER]", "[DISTANCE_VIEW]"),
                DistanceBucket = gagve::DistanceBucketEnum.Types.DistanceBucket.Within25Miles,
                MetricSystem = true,
            };
            mockGrpcClient.Setup(x => x.GetDistanceViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DistanceView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DistanceViewServiceClient client = new DistanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DistanceView responseCallSettings = await client.GetDistanceViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DistanceView responseCancellationToken = await client.GetDistanceViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetDistanceViewResourceNames()
        {
            moq::Mock<DistanceViewService.DistanceViewServiceClient> mockGrpcClient = new moq::Mock<DistanceViewService.DistanceViewServiceClient>(moq::MockBehavior.Strict);
            GetDistanceViewRequest request = new GetDistanceViewRequest
            {
                ResourceNameAsDistanceViewName = gagvr::DistanceViewName.FromCustomerDistanceView("[CUSTOMER]", "[DISTANCE_VIEW]"),
            };
            gagvr::DistanceView expectedResponse = new gagvr::DistanceView
            {
                ResourceNameAsDistanceViewName = gagvr::DistanceViewName.FromCustomerDistanceView("[CUSTOMER]", "[DISTANCE_VIEW]"),
                DistanceBucket = gagve::DistanceBucketEnum.Types.DistanceBucket.Within25Miles,
                MetricSystem = true,
            };
            mockGrpcClient.Setup(x => x.GetDistanceView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DistanceViewServiceClient client = new DistanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DistanceView response = client.GetDistanceView(request.ResourceNameAsDistanceViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetDistanceViewResourceNamesAsync()
        {
            moq::Mock<DistanceViewService.DistanceViewServiceClient> mockGrpcClient = new moq::Mock<DistanceViewService.DistanceViewServiceClient>(moq::MockBehavior.Strict);
            GetDistanceViewRequest request = new GetDistanceViewRequest
            {
                ResourceNameAsDistanceViewName = gagvr::DistanceViewName.FromCustomerDistanceView("[CUSTOMER]", "[DISTANCE_VIEW]"),
            };
            gagvr::DistanceView expectedResponse = new gagvr::DistanceView
            {
                ResourceNameAsDistanceViewName = gagvr::DistanceViewName.FromCustomerDistanceView("[CUSTOMER]", "[DISTANCE_VIEW]"),
                DistanceBucket = gagve::DistanceBucketEnum.Types.DistanceBucket.Within25Miles,
                MetricSystem = true,
            };
            mockGrpcClient.Setup(x => x.GetDistanceViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DistanceView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DistanceViewServiceClient client = new DistanceViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DistanceView responseCallSettings = await client.GetDistanceViewAsync(request.ResourceNameAsDistanceViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DistanceView responseCancellationToken = await client.GetDistanceViewAsync(request.ResourceNameAsDistanceViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

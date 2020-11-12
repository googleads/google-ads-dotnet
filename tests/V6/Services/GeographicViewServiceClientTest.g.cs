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
    public sealed class GeneratedGeographicViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetGeographicViewRequestObject()
        {
            moq::Mock<GeographicViewService.GeographicViewServiceClient> mockGrpcClient = new moq::Mock<GeographicViewService.GeographicViewServiceClient>(moq::MockBehavior.Strict);
            GetGeographicViewRequest request = new GetGeographicViewRequest
            {
                ResourceNameAsGeographicViewName = gagvr::GeographicViewName.FromCustomerCountryCriterionLocationType("[CUSTOMER_ID]", "[COUNTRY_CRITERION_ID]", "[LOCATION_TYPE]"),
            };
            gagvr::GeographicView expectedResponse = new gagvr::GeographicView
            {
                ResourceNameAsGeographicViewName = gagvr::GeographicViewName.FromCustomerCountryCriterionLocationType("[CUSTOMER_ID]", "[COUNTRY_CRITERION_ID]", "[LOCATION_TYPE]"),
                LocationType = gagve::GeoTargetingTypeEnum.Types.GeoTargetingType.LocationOfPresence,
                CountryCriterionId = 7801114990940938649L,
            };
            mockGrpcClient.Setup(x => x.GetGeographicView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GeographicViewServiceClient client = new GeographicViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeographicView response = client.GetGeographicView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetGeographicViewRequestObjectAsync()
        {
            moq::Mock<GeographicViewService.GeographicViewServiceClient> mockGrpcClient = new moq::Mock<GeographicViewService.GeographicViewServiceClient>(moq::MockBehavior.Strict);
            GetGeographicViewRequest request = new GetGeographicViewRequest
            {
                ResourceNameAsGeographicViewName = gagvr::GeographicViewName.FromCustomerCountryCriterionLocationType("[CUSTOMER_ID]", "[COUNTRY_CRITERION_ID]", "[LOCATION_TYPE]"),
            };
            gagvr::GeographicView expectedResponse = new gagvr::GeographicView
            {
                ResourceNameAsGeographicViewName = gagvr::GeographicViewName.FromCustomerCountryCriterionLocationType("[CUSTOMER_ID]", "[COUNTRY_CRITERION_ID]", "[LOCATION_TYPE]"),
                LocationType = gagve::GeoTargetingTypeEnum.Types.GeoTargetingType.LocationOfPresence,
                CountryCriterionId = 7801114990940938649L,
            };
            mockGrpcClient.Setup(x => x.GetGeographicViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GeographicView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GeographicViewServiceClient client = new GeographicViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeographicView responseCallSettings = await client.GetGeographicViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::GeographicView responseCancellationToken = await client.GetGeographicViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetGeographicView()
        {
            moq::Mock<GeographicViewService.GeographicViewServiceClient> mockGrpcClient = new moq::Mock<GeographicViewService.GeographicViewServiceClient>(moq::MockBehavior.Strict);
            GetGeographicViewRequest request = new GetGeographicViewRequest
            {
                ResourceNameAsGeographicViewName = gagvr::GeographicViewName.FromCustomerCountryCriterionLocationType("[CUSTOMER_ID]", "[COUNTRY_CRITERION_ID]", "[LOCATION_TYPE]"),
            };
            gagvr::GeographicView expectedResponse = new gagvr::GeographicView
            {
                ResourceNameAsGeographicViewName = gagvr::GeographicViewName.FromCustomerCountryCriterionLocationType("[CUSTOMER_ID]", "[COUNTRY_CRITERION_ID]", "[LOCATION_TYPE]"),
                LocationType = gagve::GeoTargetingTypeEnum.Types.GeoTargetingType.LocationOfPresence,
                CountryCriterionId = 7801114990940938649L,
            };
            mockGrpcClient.Setup(x => x.GetGeographicView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GeographicViewServiceClient client = new GeographicViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeographicView response = client.GetGeographicView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetGeographicViewAsync()
        {
            moq::Mock<GeographicViewService.GeographicViewServiceClient> mockGrpcClient = new moq::Mock<GeographicViewService.GeographicViewServiceClient>(moq::MockBehavior.Strict);
            GetGeographicViewRequest request = new GetGeographicViewRequest
            {
                ResourceNameAsGeographicViewName = gagvr::GeographicViewName.FromCustomerCountryCriterionLocationType("[CUSTOMER_ID]", "[COUNTRY_CRITERION_ID]", "[LOCATION_TYPE]"),
            };
            gagvr::GeographicView expectedResponse = new gagvr::GeographicView
            {
                ResourceNameAsGeographicViewName = gagvr::GeographicViewName.FromCustomerCountryCriterionLocationType("[CUSTOMER_ID]", "[COUNTRY_CRITERION_ID]", "[LOCATION_TYPE]"),
                LocationType = gagve::GeoTargetingTypeEnum.Types.GeoTargetingType.LocationOfPresence,
                CountryCriterionId = 7801114990940938649L,
            };
            mockGrpcClient.Setup(x => x.GetGeographicViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GeographicView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GeographicViewServiceClient client = new GeographicViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeographicView responseCallSettings = await client.GetGeographicViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::GeographicView responseCancellationToken = await client.GetGeographicViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetGeographicViewResourceNames()
        {
            moq::Mock<GeographicViewService.GeographicViewServiceClient> mockGrpcClient = new moq::Mock<GeographicViewService.GeographicViewServiceClient>(moq::MockBehavior.Strict);
            GetGeographicViewRequest request = new GetGeographicViewRequest
            {
                ResourceNameAsGeographicViewName = gagvr::GeographicViewName.FromCustomerCountryCriterionLocationType("[CUSTOMER_ID]", "[COUNTRY_CRITERION_ID]", "[LOCATION_TYPE]"),
            };
            gagvr::GeographicView expectedResponse = new gagvr::GeographicView
            {
                ResourceNameAsGeographicViewName = gagvr::GeographicViewName.FromCustomerCountryCriterionLocationType("[CUSTOMER_ID]", "[COUNTRY_CRITERION_ID]", "[LOCATION_TYPE]"),
                LocationType = gagve::GeoTargetingTypeEnum.Types.GeoTargetingType.LocationOfPresence,
                CountryCriterionId = 7801114990940938649L,
            };
            mockGrpcClient.Setup(x => x.GetGeographicView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GeographicViewServiceClient client = new GeographicViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeographicView response = client.GetGeographicView(request.ResourceNameAsGeographicViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetGeographicViewResourceNamesAsync()
        {
            moq::Mock<GeographicViewService.GeographicViewServiceClient> mockGrpcClient = new moq::Mock<GeographicViewService.GeographicViewServiceClient>(moq::MockBehavior.Strict);
            GetGeographicViewRequest request = new GetGeographicViewRequest
            {
                ResourceNameAsGeographicViewName = gagvr::GeographicViewName.FromCustomerCountryCriterionLocationType("[CUSTOMER_ID]", "[COUNTRY_CRITERION_ID]", "[LOCATION_TYPE]"),
            };
            gagvr::GeographicView expectedResponse = new gagvr::GeographicView
            {
                ResourceNameAsGeographicViewName = gagvr::GeographicViewName.FromCustomerCountryCriterionLocationType("[CUSTOMER_ID]", "[COUNTRY_CRITERION_ID]", "[LOCATION_TYPE]"),
                LocationType = gagve::GeoTargetingTypeEnum.Types.GeoTargetingType.LocationOfPresence,
                CountryCriterionId = 7801114990940938649L,
            };
            mockGrpcClient.Setup(x => x.GetGeographicViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GeographicView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GeographicViewServiceClient client = new GeographicViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GeographicView responseCallSettings = await client.GetGeographicViewAsync(request.ResourceNameAsGeographicViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::GeographicView responseCancellationToken = await client.GetGeographicViewAsync(request.ResourceNameAsGeographicViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

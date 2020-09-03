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
    public sealed class GeneratedReachPlanServiceClientTest
    {
        [Category("Smoke")][Test]
        public void ListPlannableLocationsRequestObject()
        {
            moq::Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new moq::Mock<ReachPlanService.ReachPlanServiceClient>(moq::MockBehavior.Strict);
            ListPlannableLocationsRequest request = new ListPlannableLocationsRequest { };
            ListPlannableLocationsResponse expectedResponse = new ListPlannableLocationsResponse
            {
                PlannableLocations =
                {
                    new PlannableLocation(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPlannableLocations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            ListPlannableLocationsResponse response = client.ListPlannableLocations(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task ListPlannableLocationsRequestObjectAsync()
        {
            moq::Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new moq::Mock<ReachPlanService.ReachPlanServiceClient>(moq::MockBehavior.Strict);
            ListPlannableLocationsRequest request = new ListPlannableLocationsRequest { };
            ListPlannableLocationsResponse expectedResponse = new ListPlannableLocationsResponse
            {
                PlannableLocations =
                {
                    new PlannableLocation(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPlannableLocationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListPlannableLocationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            ListPlannableLocationsResponse responseCallSettings = await client.ListPlannableLocationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            ListPlannableLocationsResponse responseCancellationToken = await client.ListPlannableLocationsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void ListPlannableProductsRequestObject()
        {
            moq::Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new moq::Mock<ReachPlanService.ReachPlanServiceClient>(moq::MockBehavior.Strict);
            ListPlannableProductsRequest request = new ListPlannableProductsRequest
            {
                PlannableLocationId = "plannable_location_idbae428fa",
            };
            ListPlannableProductsResponse expectedResponse = new ListPlannableProductsResponse
            {
                ProductMetadata =
                {
                    new ProductMetadata(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPlannableProducts(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            ListPlannableProductsResponse response = client.ListPlannableProducts(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task ListPlannableProductsRequestObjectAsync()
        {
            moq::Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new moq::Mock<ReachPlanService.ReachPlanServiceClient>(moq::MockBehavior.Strict);
            ListPlannableProductsRequest request = new ListPlannableProductsRequest
            {
                PlannableLocationId = "plannable_location_idbae428fa",
            };
            ListPlannableProductsResponse expectedResponse = new ListPlannableProductsResponse
            {
                ProductMetadata =
                {
                    new ProductMetadata(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPlannableProductsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListPlannableProductsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            ListPlannableProductsResponse responseCallSettings = await client.ListPlannableProductsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            ListPlannableProductsResponse responseCancellationToken = await client.ListPlannableProductsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void ListPlannableProducts()
        {
            moq::Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new moq::Mock<ReachPlanService.ReachPlanServiceClient>(moq::MockBehavior.Strict);
            ListPlannableProductsRequest request = new ListPlannableProductsRequest
            {
                PlannableLocationId = "plannable_location_idbae428fa",
            };
            ListPlannableProductsResponse expectedResponse = new ListPlannableProductsResponse
            {
                ProductMetadata =
                {
                    new ProductMetadata(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPlannableProducts(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            ListPlannableProductsResponse response = client.ListPlannableProducts(request.PlannableLocationId);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task ListPlannableProductsAsync()
        {
            moq::Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new moq::Mock<ReachPlanService.ReachPlanServiceClient>(moq::MockBehavior.Strict);
            ListPlannableProductsRequest request = new ListPlannableProductsRequest
            {
                PlannableLocationId = "plannable_location_idbae428fa",
            };
            ListPlannableProductsResponse expectedResponse = new ListPlannableProductsResponse
            {
                ProductMetadata =
                {
                    new ProductMetadata(),
                },
            };
            mockGrpcClient.Setup(x => x.ListPlannableProductsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListPlannableProductsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            ListPlannableProductsResponse responseCallSettings = await client.ListPlannableProductsAsync(request.PlannableLocationId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            ListPlannableProductsResponse responseCancellationToken = await client.ListPlannableProductsAsync(request.PlannableLocationId, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GenerateProductMixIdeasRequestObject()
        {
            moq::Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new moq::Mock<ReachPlanService.ReachPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateProductMixIdeasRequest request = new GenerateProductMixIdeasRequest
            {
                CustomerId = "customer_id3b3724cb",
                PlannableLocationId = "plannable_location_idbae428fa",
                CurrencyCode = "currency_code7f81e352",
                BudgetMicros = 6302061979031921068L,
                Preferences = new Preferences(),
            };
            GenerateProductMixIdeasResponse expectedResponse = new GenerateProductMixIdeasResponse
            {
                ProductAllocation =
                {
                    new ProductAllocation(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateProductMixIdeas(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateProductMixIdeasResponse response = client.GenerateProductMixIdeas(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GenerateProductMixIdeasRequestObjectAsync()
        {
            moq::Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new moq::Mock<ReachPlanService.ReachPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateProductMixIdeasRequest request = new GenerateProductMixIdeasRequest
            {
                CustomerId = "customer_id3b3724cb",
                PlannableLocationId = "plannable_location_idbae428fa",
                CurrencyCode = "currency_code7f81e352",
                BudgetMicros = 6302061979031921068L,
                Preferences = new Preferences(),
            };
            GenerateProductMixIdeasResponse expectedResponse = new GenerateProductMixIdeasResponse
            {
                ProductAllocation =
                {
                    new ProductAllocation(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateProductMixIdeasAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateProductMixIdeasResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateProductMixIdeasResponse responseCallSettings = await client.GenerateProductMixIdeasAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            GenerateProductMixIdeasResponse responseCancellationToken = await client.GenerateProductMixIdeasAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GenerateProductMixIdeas()
        {
            moq::Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new moq::Mock<ReachPlanService.ReachPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateProductMixIdeasRequest request = new GenerateProductMixIdeasRequest
            {
                CustomerId = "customer_id3b3724cb",
                PlannableLocationId = "plannable_location_idbae428fa",
                CurrencyCode = "currency_code7f81e352",
                BudgetMicros = 6302061979031921068L,
            };
            GenerateProductMixIdeasResponse expectedResponse = new GenerateProductMixIdeasResponse
            {
                ProductAllocation =
                {
                    new ProductAllocation(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateProductMixIdeas(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateProductMixIdeasResponse response = client.GenerateProductMixIdeas(request.CustomerId, request.PlannableLocationId, request.CurrencyCode, request.BudgetMicros);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GenerateProductMixIdeasAsync()
        {
            moq::Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new moq::Mock<ReachPlanService.ReachPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateProductMixIdeasRequest request = new GenerateProductMixIdeasRequest
            {
                CustomerId = "customer_id3b3724cb",
                PlannableLocationId = "plannable_location_idbae428fa",
                CurrencyCode = "currency_code7f81e352",
                BudgetMicros = 6302061979031921068L,
            };
            GenerateProductMixIdeasResponse expectedResponse = new GenerateProductMixIdeasResponse
            {
                ProductAllocation =
                {
                    new ProductAllocation(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateProductMixIdeasAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateProductMixIdeasResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateProductMixIdeasResponse responseCallSettings = await client.GenerateProductMixIdeasAsync(request.CustomerId, request.PlannableLocationId, request.CurrencyCode, request.BudgetMicros, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            GenerateProductMixIdeasResponse responseCancellationToken = await client.GenerateProductMixIdeasAsync(request.CustomerId, request.PlannableLocationId, request.CurrencyCode, request.BudgetMicros, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GenerateReachForecastRequestObject()
        {
            moq::Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new moq::Mock<ReachPlanService.ReachPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateReachForecastRequest request = new GenerateReachForecastRequest
            {
                CustomerId = "customer_id3b3724cb",
                CurrencyCode = "currency_code7f81e352",
                CampaignDuration = new CampaignDuration(),
                CookieFrequencyCap = 1624044206,
                MinEffectiveFrequency = -519821093,
                Targeting = new Targeting(),
                PlannedProducts =
                {
                    new PlannedProduct(),
                },
            };
            GenerateReachForecastResponse expectedResponse = new GenerateReachForecastResponse
            {
                OnTargetAudienceMetrics = new OnTargetAudienceMetrics(),
                ReachCurve = new ReachCurve(),
            };
            mockGrpcClient.Setup(x => x.GenerateReachForecast(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateReachForecastResponse response = client.GenerateReachForecast(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GenerateReachForecastRequestObjectAsync()
        {
            moq::Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new moq::Mock<ReachPlanService.ReachPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateReachForecastRequest request = new GenerateReachForecastRequest
            {
                CustomerId = "customer_id3b3724cb",
                CurrencyCode = "currency_code7f81e352",
                CampaignDuration = new CampaignDuration(),
                CookieFrequencyCap = 1624044206,
                MinEffectiveFrequency = -519821093,
                Targeting = new Targeting(),
                PlannedProducts =
                {
                    new PlannedProduct(),
                },
            };
            GenerateReachForecastResponse expectedResponse = new GenerateReachForecastResponse
            {
                OnTargetAudienceMetrics = new OnTargetAudienceMetrics(),
                ReachCurve = new ReachCurve(),
            };
            mockGrpcClient.Setup(x => x.GenerateReachForecastAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateReachForecastResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateReachForecastResponse responseCallSettings = await client.GenerateReachForecastAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            GenerateReachForecastResponse responseCancellationToken = await client.GenerateReachForecastAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GenerateReachForecast()
        {
            moq::Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new moq::Mock<ReachPlanService.ReachPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateReachForecastRequest request = new GenerateReachForecastRequest
            {
                CustomerId = "customer_id3b3724cb",
                CampaignDuration = new CampaignDuration(),
                PlannedProducts =
                {
                    new PlannedProduct(),
                },
            };
            GenerateReachForecastResponse expectedResponse = new GenerateReachForecastResponse
            {
                OnTargetAudienceMetrics = new OnTargetAudienceMetrics(),
                ReachCurve = new ReachCurve(),
            };
            mockGrpcClient.Setup(x => x.GenerateReachForecast(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateReachForecastResponse response = client.GenerateReachForecast(request.CustomerId, request.CampaignDuration, request.PlannedProducts);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GenerateReachForecastAsync()
        {
            moq::Mock<ReachPlanService.ReachPlanServiceClient> mockGrpcClient = new moq::Mock<ReachPlanService.ReachPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateReachForecastRequest request = new GenerateReachForecastRequest
            {
                CustomerId = "customer_id3b3724cb",
                CampaignDuration = new CampaignDuration(),
                PlannedProducts =
                {
                    new PlannedProduct(),
                },
            };
            GenerateReachForecastResponse expectedResponse = new GenerateReachForecastResponse
            {
                OnTargetAudienceMetrics = new OnTargetAudienceMetrics(),
                ReachCurve = new ReachCurve(),
            };
            mockGrpcClient.Setup(x => x.GenerateReachForecastAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateReachForecastResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ReachPlanServiceClient client = new ReachPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateReachForecastResponse responseCallSettings = await client.GenerateReachForecastAsync(request.CustomerId, request.CampaignDuration, request.PlannedProducts, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            GenerateReachForecastResponse responseCancellationToken = await client.GenerateReachForecastAsync(request.CustomerId, request.CampaignDuration, request.PlannedProducts, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

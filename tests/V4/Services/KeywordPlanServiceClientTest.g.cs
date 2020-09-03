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
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V4.Services;

namespace Google.Ads.GoogleAds.Tests.V4.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedKeywordPlanServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetKeywordPlanRequestObject()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanRequest request = new GetKeywordPlanRequest
            {
                ResourceNameAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
            };
            gagvr::KeywordPlan expectedResponse = new gagvr::KeywordPlan
            {
                ResourceNameAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                Id = -6774108720365892680L,
                KeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                ForecastPeriod = new gagvr::KeywordPlanForecastPeriod(),
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlan(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlan response = client.GetKeywordPlan(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanRequestObjectAsync()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanRequest request = new GetKeywordPlanRequest
            {
                ResourceNameAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
            };
            gagvr::KeywordPlan expectedResponse = new gagvr::KeywordPlan
            {
                ResourceNameAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                Id = -6774108720365892680L,
                KeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                ForecastPeriod = new gagvr::KeywordPlanForecastPeriod(),
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlan>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlan responseCallSettings = await client.GetKeywordPlanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlan responseCancellationToken = await client.GetKeywordPlanAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetKeywordPlan()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanRequest request = new GetKeywordPlanRequest
            {
                ResourceNameAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
            };
            gagvr::KeywordPlan expectedResponse = new gagvr::KeywordPlan
            {
                ResourceNameAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                Id = -6774108720365892680L,
                KeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                ForecastPeriod = new gagvr::KeywordPlanForecastPeriod(),
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlan(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlan response = client.GetKeywordPlan(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanAsync()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanRequest request = new GetKeywordPlanRequest
            {
                ResourceNameAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
            };
            gagvr::KeywordPlan expectedResponse = new gagvr::KeywordPlan
            {
                ResourceNameAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                Id = -6774108720365892680L,
                KeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                ForecastPeriod = new gagvr::KeywordPlanForecastPeriod(),
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlan>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlan responseCallSettings = await client.GetKeywordPlanAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlan responseCancellationToken = await client.GetKeywordPlanAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetKeywordPlanResourceNames()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanRequest request = new GetKeywordPlanRequest
            {
                ResourceNameAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
            };
            gagvr::KeywordPlan expectedResponse = new gagvr::KeywordPlan
            {
                ResourceNameAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                Id = -6774108720365892680L,
                KeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                ForecastPeriod = new gagvr::KeywordPlanForecastPeriod(),
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlan(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlan response = client.GetKeywordPlan(request.ResourceNameAsKeywordPlanName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetKeywordPlanResourceNamesAsync()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GetKeywordPlanRequest request = new GetKeywordPlanRequest
            {
                ResourceNameAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
            };
            gagvr::KeywordPlan expectedResponse = new gagvr::KeywordPlan
            {
                ResourceNameAsKeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                Id = -6774108720365892680L,
                KeywordPlanName = gagvr::KeywordPlanName.FromCustomerKeywordPlan("[CUSTOMER]", "[KEYWORD_PLAN]"),
                ForecastPeriod = new gagvr::KeywordPlanForecastPeriod(),
            };
            mockGrpcClient.Setup(x => x.GetKeywordPlanAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordPlan>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordPlan responseCallSettings = await client.GetKeywordPlanAsync(request.ResourceNameAsKeywordPlanName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordPlan responseCancellationToken = await client.GetKeywordPlanAsync(request.ResourceNameAsKeywordPlanName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateKeywordPlansRequestObject()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlansRequest request = new MutateKeywordPlansRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateKeywordPlansResponse expectedResponse = new MutateKeywordPlansResponse
            {
                Results =
                {
                    new MutateKeywordPlansResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlans(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlansResponse response = client.MutateKeywordPlans(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateKeywordPlansRequestObjectAsync()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlansRequest request = new MutateKeywordPlansRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateKeywordPlansResponse expectedResponse = new MutateKeywordPlansResponse
            {
                Results =
                {
                    new MutateKeywordPlansResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlansAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateKeywordPlansResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlansResponse responseCallSettings = await client.MutateKeywordPlansAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateKeywordPlansResponse responseCancellationToken = await client.MutateKeywordPlansAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateKeywordPlans()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlansRequest request = new MutateKeywordPlansRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanOperation(),
                },
            };
            MutateKeywordPlansResponse expectedResponse = new MutateKeywordPlansResponse
            {
                Results =
                {
                    new MutateKeywordPlansResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlans(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlansResponse response = client.MutateKeywordPlans(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateKeywordPlansAsync()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            MutateKeywordPlansRequest request = new MutateKeywordPlansRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new KeywordPlanOperation(),
                },
            };
            MutateKeywordPlansResponse expectedResponse = new MutateKeywordPlansResponse
            {
                Results =
                {
                    new MutateKeywordPlansResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateKeywordPlansAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateKeywordPlansResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            MutateKeywordPlansResponse responseCallSettings = await client.MutateKeywordPlansAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateKeywordPlansResponse responseCancellationToken = await client.MutateKeywordPlansAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GenerateForecastCurveRequestObject()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateForecastCurveRequest request = new GenerateForecastCurveRequest
            {
                KeywordPlan = "keyword_plan348c505a",
            };
            GenerateForecastCurveResponse expectedResponse = new GenerateForecastCurveResponse
            {
                CampaignForecastCurves =
                {
                    new KeywordPlanCampaignForecastCurve(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateForecastCurve(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateForecastCurveResponse response = client.GenerateForecastCurve(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GenerateForecastCurveRequestObjectAsync()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateForecastCurveRequest request = new GenerateForecastCurveRequest
            {
                KeywordPlan = "keyword_plan348c505a",
            };
            GenerateForecastCurveResponse expectedResponse = new GenerateForecastCurveResponse
            {
                CampaignForecastCurves =
                {
                    new KeywordPlanCampaignForecastCurve(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateForecastCurveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateForecastCurveResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateForecastCurveResponse responseCallSettings = await client.GenerateForecastCurveAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            GenerateForecastCurveResponse responseCancellationToken = await client.GenerateForecastCurveAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GenerateForecastCurve()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateForecastCurveRequest request = new GenerateForecastCurveRequest
            {
                KeywordPlan = "keyword_plan348c505a",
            };
            GenerateForecastCurveResponse expectedResponse = new GenerateForecastCurveResponse
            {
                CampaignForecastCurves =
                {
                    new KeywordPlanCampaignForecastCurve(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateForecastCurve(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateForecastCurveResponse response = client.GenerateForecastCurve(request.KeywordPlan);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GenerateForecastCurveAsync()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateForecastCurveRequest request = new GenerateForecastCurveRequest
            {
                KeywordPlan = "keyword_plan348c505a",
            };
            GenerateForecastCurveResponse expectedResponse = new GenerateForecastCurveResponse
            {
                CampaignForecastCurves =
                {
                    new KeywordPlanCampaignForecastCurve(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateForecastCurveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateForecastCurveResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateForecastCurveResponse responseCallSettings = await client.GenerateForecastCurveAsync(request.KeywordPlan, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            GenerateForecastCurveResponse responseCancellationToken = await client.GenerateForecastCurveAsync(request.KeywordPlan, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GenerateForecastMetricsRequestObject()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateForecastMetricsRequest request = new GenerateForecastMetricsRequest
            {
                KeywordPlan = "keyword_plan348c505a",
            };
            GenerateForecastMetricsResponse expectedResponse = new GenerateForecastMetricsResponse
            {
                CampaignForecasts =
                {
                    new KeywordPlanCampaignForecast(),
                },
                AdGroupForecasts =
                {
                    new KeywordPlanAdGroupForecast(),
                },
                KeywordForecasts =
                {
                    new KeywordPlanKeywordForecast(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateForecastMetrics(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateForecastMetricsResponse response = client.GenerateForecastMetrics(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GenerateForecastMetricsRequestObjectAsync()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateForecastMetricsRequest request = new GenerateForecastMetricsRequest
            {
                KeywordPlan = "keyword_plan348c505a",
            };
            GenerateForecastMetricsResponse expectedResponse = new GenerateForecastMetricsResponse
            {
                CampaignForecasts =
                {
                    new KeywordPlanCampaignForecast(),
                },
                AdGroupForecasts =
                {
                    new KeywordPlanAdGroupForecast(),
                },
                KeywordForecasts =
                {
                    new KeywordPlanKeywordForecast(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateForecastMetricsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateForecastMetricsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateForecastMetricsResponse responseCallSettings = await client.GenerateForecastMetricsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            GenerateForecastMetricsResponse responseCancellationToken = await client.GenerateForecastMetricsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GenerateForecastMetrics()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateForecastMetricsRequest request = new GenerateForecastMetricsRequest
            {
                KeywordPlan = "keyword_plan348c505a",
            };
            GenerateForecastMetricsResponse expectedResponse = new GenerateForecastMetricsResponse
            {
                CampaignForecasts =
                {
                    new KeywordPlanCampaignForecast(),
                },
                AdGroupForecasts =
                {
                    new KeywordPlanAdGroupForecast(),
                },
                KeywordForecasts =
                {
                    new KeywordPlanKeywordForecast(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateForecastMetrics(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateForecastMetricsResponse response = client.GenerateForecastMetrics(request.KeywordPlan);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GenerateForecastMetricsAsync()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateForecastMetricsRequest request = new GenerateForecastMetricsRequest
            {
                KeywordPlan = "keyword_plan348c505a",
            };
            GenerateForecastMetricsResponse expectedResponse = new GenerateForecastMetricsResponse
            {
                CampaignForecasts =
                {
                    new KeywordPlanCampaignForecast(),
                },
                AdGroupForecasts =
                {
                    new KeywordPlanAdGroupForecast(),
                },
                KeywordForecasts =
                {
                    new KeywordPlanKeywordForecast(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateForecastMetricsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateForecastMetricsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateForecastMetricsResponse responseCallSettings = await client.GenerateForecastMetricsAsync(request.KeywordPlan, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            GenerateForecastMetricsResponse responseCancellationToken = await client.GenerateForecastMetricsAsync(request.KeywordPlan, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GenerateHistoricalMetricsRequestObject()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateHistoricalMetricsRequest request = new GenerateHistoricalMetricsRequest
            {
                KeywordPlan = "keyword_plan348c505a",
            };
            GenerateHistoricalMetricsResponse expectedResponse = new GenerateHistoricalMetricsResponse
            {
                Metrics =
                {
                    new KeywordPlanKeywordHistoricalMetrics(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateHistoricalMetrics(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateHistoricalMetricsResponse response = client.GenerateHistoricalMetrics(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GenerateHistoricalMetricsRequestObjectAsync()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateHistoricalMetricsRequest request = new GenerateHistoricalMetricsRequest
            {
                KeywordPlan = "keyword_plan348c505a",
            };
            GenerateHistoricalMetricsResponse expectedResponse = new GenerateHistoricalMetricsResponse
            {
                Metrics =
                {
                    new KeywordPlanKeywordHistoricalMetrics(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateHistoricalMetricsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateHistoricalMetricsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateHistoricalMetricsResponse responseCallSettings = await client.GenerateHistoricalMetricsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            GenerateHistoricalMetricsResponse responseCancellationToken = await client.GenerateHistoricalMetricsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GenerateHistoricalMetrics()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateHistoricalMetricsRequest request = new GenerateHistoricalMetricsRequest
            {
                KeywordPlan = "keyword_plan348c505a",
            };
            GenerateHistoricalMetricsResponse expectedResponse = new GenerateHistoricalMetricsResponse
            {
                Metrics =
                {
                    new KeywordPlanKeywordHistoricalMetrics(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateHistoricalMetrics(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateHistoricalMetricsResponse response = client.GenerateHistoricalMetrics(request.KeywordPlan);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GenerateHistoricalMetricsAsync()
        {
            moq::Mock<KeywordPlanService.KeywordPlanServiceClient> mockGrpcClient = new moq::Mock<KeywordPlanService.KeywordPlanServiceClient>(moq::MockBehavior.Strict);
            GenerateHistoricalMetricsRequest request = new GenerateHistoricalMetricsRequest
            {
                KeywordPlan = "keyword_plan348c505a",
            };
            GenerateHistoricalMetricsResponse expectedResponse = new GenerateHistoricalMetricsResponse
            {
                Metrics =
                {
                    new KeywordPlanKeywordHistoricalMetrics(),
                },
            };
            mockGrpcClient.Setup(x => x.GenerateHistoricalMetricsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateHistoricalMetricsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordPlanServiceClient client = new KeywordPlanServiceClientImpl(mockGrpcClient.Object, null);
            GenerateHistoricalMetricsResponse responseCallSettings = await client.GenerateHistoricalMetricsAsync(request.KeywordPlan, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            GenerateHistoricalMetricsResponse responseCancellationToken = await client.GenerateHistoricalMetricsAsync(request.KeywordPlan, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

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

using gagve = Google.Ads.GoogleAds.V6.Enums;
using gagvr = Google.Ads.GoogleAds.V6.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V6.Services;

namespace Google.Ads.GoogleAds.Tests.V6.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCampaignBudgetServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCampaignBudgetRequestObject()
        {
            moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient>(moq::MockBehavior.Strict);
            GetCampaignBudgetRequest request = new GetCampaignBudgetRequest
            {
                ResourceNameAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
            };
            gagvr::CampaignBudget expectedResponse = new gagvr::CampaignBudget
            {
                ResourceNameAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                Status = gagve::BudgetStatusEnum.Types.BudgetStatus.Enabled,
                DeliveryMethod = gagve::BudgetDeliveryMethodEnum.Types.BudgetDeliveryMethod.Standard,
                Period = gagve::BudgetPeriodEnum.Types.BudgetPeriod.Unspecified,
                Type = gagve::BudgetTypeEnum.Types.BudgetType.Unspecified,
                Id = -6774108720365892680L,
                CampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                AmountMicros = -5708430407335026218L,
                TotalAmountMicros = -8735537612243809071L,
                ExplicitlyShared = true,
                ReferenceCount = -8440758895662409664L,
                HasRecommendedBudget = false,
                RecommendedBudgetAmountMicros = -5174015606152417050L,
                RecommendedBudgetEstimatedChangeWeeklyClicks = 5003538975719544582L,
                RecommendedBudgetEstimatedChangeWeeklyCostMicros = 6886876539534848907L,
                RecommendedBudgetEstimatedChangeWeeklyInteractions = -4068174795511900246L,
                RecommendedBudgetEstimatedChangeWeeklyViews = -4598204636615893095L,
            };
            mockGrpcClient.Setup(x => x.GetCampaignBudget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignBudget response = client.GetCampaignBudget(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignBudgetRequestObjectAsync()
        {
            moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient>(moq::MockBehavior.Strict);
            GetCampaignBudgetRequest request = new GetCampaignBudgetRequest
            {
                ResourceNameAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
            };
            gagvr::CampaignBudget expectedResponse = new gagvr::CampaignBudget
            {
                ResourceNameAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                Status = gagve::BudgetStatusEnum.Types.BudgetStatus.Enabled,
                DeliveryMethod = gagve::BudgetDeliveryMethodEnum.Types.BudgetDeliveryMethod.Standard,
                Period = gagve::BudgetPeriodEnum.Types.BudgetPeriod.Unspecified,
                Type = gagve::BudgetTypeEnum.Types.BudgetType.Unspecified,
                Id = -6774108720365892680L,
                CampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                AmountMicros = -5708430407335026218L,
                TotalAmountMicros = -8735537612243809071L,
                ExplicitlyShared = true,
                ReferenceCount = -8440758895662409664L,
                HasRecommendedBudget = false,
                RecommendedBudgetAmountMicros = -5174015606152417050L,
                RecommendedBudgetEstimatedChangeWeeklyClicks = 5003538975719544582L,
                RecommendedBudgetEstimatedChangeWeeklyCostMicros = 6886876539534848907L,
                RecommendedBudgetEstimatedChangeWeeklyInteractions = -4068174795511900246L,
                RecommendedBudgetEstimatedChangeWeeklyViews = -4598204636615893095L,
            };
            mockGrpcClient.Setup(x => x.GetCampaignBudgetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignBudget>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignBudget responseCallSettings = await client.GetCampaignBudgetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignBudget responseCancellationToken = await client.GetCampaignBudgetAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignBudget()
        {
            moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient>(moq::MockBehavior.Strict);
            GetCampaignBudgetRequest request = new GetCampaignBudgetRequest
            {
                ResourceNameAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
            };
            gagvr::CampaignBudget expectedResponse = new gagvr::CampaignBudget
            {
                ResourceNameAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                Status = gagve::BudgetStatusEnum.Types.BudgetStatus.Enabled,
                DeliveryMethod = gagve::BudgetDeliveryMethodEnum.Types.BudgetDeliveryMethod.Standard,
                Period = gagve::BudgetPeriodEnum.Types.BudgetPeriod.Unspecified,
                Type = gagve::BudgetTypeEnum.Types.BudgetType.Unspecified,
                Id = -6774108720365892680L,
                CampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                AmountMicros = -5708430407335026218L,
                TotalAmountMicros = -8735537612243809071L,
                ExplicitlyShared = true,
                ReferenceCount = -8440758895662409664L,
                HasRecommendedBudget = false,
                RecommendedBudgetAmountMicros = -5174015606152417050L,
                RecommendedBudgetEstimatedChangeWeeklyClicks = 5003538975719544582L,
                RecommendedBudgetEstimatedChangeWeeklyCostMicros = 6886876539534848907L,
                RecommendedBudgetEstimatedChangeWeeklyInteractions = -4068174795511900246L,
                RecommendedBudgetEstimatedChangeWeeklyViews = -4598204636615893095L,
            };
            mockGrpcClient.Setup(x => x.GetCampaignBudget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignBudget response = client.GetCampaignBudget(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignBudgetAsync()
        {
            moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient>(moq::MockBehavior.Strict);
            GetCampaignBudgetRequest request = new GetCampaignBudgetRequest
            {
                ResourceNameAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
            };
            gagvr::CampaignBudget expectedResponse = new gagvr::CampaignBudget
            {
                ResourceNameAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                Status = gagve::BudgetStatusEnum.Types.BudgetStatus.Enabled,
                DeliveryMethod = gagve::BudgetDeliveryMethodEnum.Types.BudgetDeliveryMethod.Standard,
                Period = gagve::BudgetPeriodEnum.Types.BudgetPeriod.Unspecified,
                Type = gagve::BudgetTypeEnum.Types.BudgetType.Unspecified,
                Id = -6774108720365892680L,
                CampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                AmountMicros = -5708430407335026218L,
                TotalAmountMicros = -8735537612243809071L,
                ExplicitlyShared = true,
                ReferenceCount = -8440758895662409664L,
                HasRecommendedBudget = false,
                RecommendedBudgetAmountMicros = -5174015606152417050L,
                RecommendedBudgetEstimatedChangeWeeklyClicks = 5003538975719544582L,
                RecommendedBudgetEstimatedChangeWeeklyCostMicros = 6886876539534848907L,
                RecommendedBudgetEstimatedChangeWeeklyInteractions = -4068174795511900246L,
                RecommendedBudgetEstimatedChangeWeeklyViews = -4598204636615893095L,
            };
            mockGrpcClient.Setup(x => x.GetCampaignBudgetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignBudget>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignBudget responseCallSettings = await client.GetCampaignBudgetAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignBudget responseCancellationToken = await client.GetCampaignBudgetAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCampaignBudgetResourceNames()
        {
            moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient>(moq::MockBehavior.Strict);
            GetCampaignBudgetRequest request = new GetCampaignBudgetRequest
            {
                ResourceNameAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
            };
            gagvr::CampaignBudget expectedResponse = new gagvr::CampaignBudget
            {
                ResourceNameAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                Status = gagve::BudgetStatusEnum.Types.BudgetStatus.Enabled,
                DeliveryMethod = gagve::BudgetDeliveryMethodEnum.Types.BudgetDeliveryMethod.Standard,
                Period = gagve::BudgetPeriodEnum.Types.BudgetPeriod.Unspecified,
                Type = gagve::BudgetTypeEnum.Types.BudgetType.Unspecified,
                Id = -6774108720365892680L,
                CampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                AmountMicros = -5708430407335026218L,
                TotalAmountMicros = -8735537612243809071L,
                ExplicitlyShared = true,
                ReferenceCount = -8440758895662409664L,
                HasRecommendedBudget = false,
                RecommendedBudgetAmountMicros = -5174015606152417050L,
                RecommendedBudgetEstimatedChangeWeeklyClicks = 5003538975719544582L,
                RecommendedBudgetEstimatedChangeWeeklyCostMicros = 6886876539534848907L,
                RecommendedBudgetEstimatedChangeWeeklyInteractions = -4068174795511900246L,
                RecommendedBudgetEstimatedChangeWeeklyViews = -4598204636615893095L,
            };
            mockGrpcClient.Setup(x => x.GetCampaignBudget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignBudget response = client.GetCampaignBudget(request.ResourceNameAsCampaignBudgetName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCampaignBudgetResourceNamesAsync()
        {
            moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient>(moq::MockBehavior.Strict);
            GetCampaignBudgetRequest request = new GetCampaignBudgetRequest
            {
                ResourceNameAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
            };
            gagvr::CampaignBudget expectedResponse = new gagvr::CampaignBudget
            {
                ResourceNameAsCampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                Status = gagve::BudgetStatusEnum.Types.BudgetStatus.Enabled,
                DeliveryMethod = gagve::BudgetDeliveryMethodEnum.Types.BudgetDeliveryMethod.Standard,
                Period = gagve::BudgetPeriodEnum.Types.BudgetPeriod.Unspecified,
                Type = gagve::BudgetTypeEnum.Types.BudgetType.Unspecified,
                Id = -6774108720365892680L,
                CampaignBudgetName = gagvr::CampaignBudgetName.FromCustomerCampaignBudget("[CUSTOMER_ID]", "[CAMPAIGN_BUDGET_ID]"),
                AmountMicros = -5708430407335026218L,
                TotalAmountMicros = -8735537612243809071L,
                ExplicitlyShared = true,
                ReferenceCount = -8440758895662409664L,
                HasRecommendedBudget = false,
                RecommendedBudgetAmountMicros = -5174015606152417050L,
                RecommendedBudgetEstimatedChangeWeeklyClicks = 5003538975719544582L,
                RecommendedBudgetEstimatedChangeWeeklyCostMicros = 6886876539534848907L,
                RecommendedBudgetEstimatedChangeWeeklyInteractions = -4068174795511900246L,
                RecommendedBudgetEstimatedChangeWeeklyViews = -4598204636615893095L,
            };
            mockGrpcClient.Setup(x => x.GetCampaignBudgetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CampaignBudget>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CampaignBudget responseCallSettings = await client.GetCampaignBudgetAsync(request.ResourceNameAsCampaignBudgetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CampaignBudget responseCancellationToken = await client.GetCampaignBudgetAsync(request.ResourceNameAsCampaignBudgetName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignBudgetsRequestObject()
        {
            moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignBudgetsRequest request = new MutateCampaignBudgetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignBudgetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignBudgetsResponse expectedResponse = new MutateCampaignBudgetsResponse
            {
                Results =
                {
                    new MutateCampaignBudgetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignBudgets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignBudgetsResponse response = client.MutateCampaignBudgets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignBudgetsRequestObjectAsync()
        {
            moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignBudgetsRequest request = new MutateCampaignBudgetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignBudgetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCampaignBudgetsResponse expectedResponse = new MutateCampaignBudgetsResponse
            {
                Results =
                {
                    new MutateCampaignBudgetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignBudgetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignBudgetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignBudgetsResponse responseCallSettings = await client.MutateCampaignBudgetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignBudgetsResponse responseCancellationToken = await client.MutateCampaignBudgetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCampaignBudgets()
        {
            moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignBudgetsRequest request = new MutateCampaignBudgetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignBudgetOperation(),
                },
            };
            MutateCampaignBudgetsResponse expectedResponse = new MutateCampaignBudgetsResponse
            {
                Results =
                {
                    new MutateCampaignBudgetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignBudgets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignBudgetsResponse response = client.MutateCampaignBudgets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCampaignBudgetsAsync()
        {
            moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new moq::Mock<CampaignBudgetService.CampaignBudgetServiceClient>(moq::MockBehavior.Strict);
            MutateCampaignBudgetsRequest request = new MutateCampaignBudgetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CampaignBudgetOperation(),
                },
            };
            MutateCampaignBudgetsResponse expectedResponse = new MutateCampaignBudgetsResponse
            {
                Results =
                {
                    new MutateCampaignBudgetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCampaignBudgetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCampaignBudgetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignBudgetsResponse responseCallSettings = await client.MutateCampaignBudgetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCampaignBudgetsResponse responseCancellationToken = await client.MutateCampaignBudgetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

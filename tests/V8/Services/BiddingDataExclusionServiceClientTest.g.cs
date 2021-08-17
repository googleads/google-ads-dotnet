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

using gagve = Google.Ads.GoogleAds.V8.Enums;
using gagvr = Google.Ads.GoogleAds.V8.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V8.Services;

namespace Google.Ads.GoogleAds.Tests.V8.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBiddingDataExclusionServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetBiddingDataExclusionRequestObject()
        {
            moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient> mockGrpcClient = new moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient>(moq::MockBehavior.Strict);
            GetBiddingDataExclusionRequest request = new GetBiddingDataExclusionRequest
            {
                ResourceNameAsBiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
            };
            gagvr::BiddingDataExclusion expectedResponse = new gagvr::BiddingDataExclusion
            {
                ResourceNameAsBiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                DataExclusionId = 3666595228757949308L,
                Scope = gagve::SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Campaign,
                Status = gagve::SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Enabled,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                BiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                Description = "description2cf9da67",
                Devices =
                {
                    gagve::DeviceEnum.Types.Device.Unspecified,
                },
                CampaignsAsCampaignNames =
                {
                    gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                },
                AdvertisingChannelTypes =
                {
                    gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.Local,
                },
            };
            mockGrpcClient.Setup(x => x.GetBiddingDataExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingDataExclusionServiceClient client = new BiddingDataExclusionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingDataExclusion response = client.GetBiddingDataExclusion(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetBiddingDataExclusionRequestObjectAsync()
        {
            moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient> mockGrpcClient = new moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient>(moq::MockBehavior.Strict);
            GetBiddingDataExclusionRequest request = new GetBiddingDataExclusionRequest
            {
                ResourceNameAsBiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
            };
            gagvr::BiddingDataExclusion expectedResponse = new gagvr::BiddingDataExclusion
            {
                ResourceNameAsBiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                DataExclusionId = 3666595228757949308L,
                Scope = gagve::SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Campaign,
                Status = gagve::SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Enabled,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                BiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                Description = "description2cf9da67",
                Devices =
                {
                    gagve::DeviceEnum.Types.Device.Unspecified,
                },
                CampaignsAsCampaignNames =
                {
                    gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                },
                AdvertisingChannelTypes =
                {
                    gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.Local,
                },
            };
            mockGrpcClient.Setup(x => x.GetBiddingDataExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BiddingDataExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingDataExclusionServiceClient client = new BiddingDataExclusionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingDataExclusion responseCallSettings = await client.GetBiddingDataExclusionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BiddingDataExclusion responseCancellationToken = await client.GetBiddingDataExclusionAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetBiddingDataExclusion()
        {
            moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient> mockGrpcClient = new moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient>(moq::MockBehavior.Strict);
            GetBiddingDataExclusionRequest request = new GetBiddingDataExclusionRequest
            {
                ResourceNameAsBiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
            };
            gagvr::BiddingDataExclusion expectedResponse = new gagvr::BiddingDataExclusion
            {
                ResourceNameAsBiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                DataExclusionId = 3666595228757949308L,
                Scope = gagve::SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Campaign,
                Status = gagve::SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Enabled,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                BiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                Description = "description2cf9da67",
                Devices =
                {
                    gagve::DeviceEnum.Types.Device.Unspecified,
                },
                CampaignsAsCampaignNames =
                {
                    gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                },
                AdvertisingChannelTypes =
                {
                    gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.Local,
                },
            };
            mockGrpcClient.Setup(x => x.GetBiddingDataExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingDataExclusionServiceClient client = new BiddingDataExclusionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingDataExclusion response = client.GetBiddingDataExclusion(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetBiddingDataExclusionAsync()
        {
            moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient> mockGrpcClient = new moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient>(moq::MockBehavior.Strict);
            GetBiddingDataExclusionRequest request = new GetBiddingDataExclusionRequest
            {
                ResourceNameAsBiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
            };
            gagvr::BiddingDataExclusion expectedResponse = new gagvr::BiddingDataExclusion
            {
                ResourceNameAsBiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                DataExclusionId = 3666595228757949308L,
                Scope = gagve::SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Campaign,
                Status = gagve::SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Enabled,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                BiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                Description = "description2cf9da67",
                Devices =
                {
                    gagve::DeviceEnum.Types.Device.Unspecified,
                },
                CampaignsAsCampaignNames =
                {
                    gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                },
                AdvertisingChannelTypes =
                {
                    gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.Local,
                },
            };
            mockGrpcClient.Setup(x => x.GetBiddingDataExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BiddingDataExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingDataExclusionServiceClient client = new BiddingDataExclusionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingDataExclusion responseCallSettings = await client.GetBiddingDataExclusionAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BiddingDataExclusion responseCancellationToken = await client.GetBiddingDataExclusionAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetBiddingDataExclusionResourceNames()
        {
            moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient> mockGrpcClient = new moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient>(moq::MockBehavior.Strict);
            GetBiddingDataExclusionRequest request = new GetBiddingDataExclusionRequest
            {
                ResourceNameAsBiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
            };
            gagvr::BiddingDataExclusion expectedResponse = new gagvr::BiddingDataExclusion
            {
                ResourceNameAsBiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                DataExclusionId = 3666595228757949308L,
                Scope = gagve::SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Campaign,
                Status = gagve::SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Enabled,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                BiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                Description = "description2cf9da67",
                Devices =
                {
                    gagve::DeviceEnum.Types.Device.Unspecified,
                },
                CampaignsAsCampaignNames =
                {
                    gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                },
                AdvertisingChannelTypes =
                {
                    gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.Local,
                },
            };
            mockGrpcClient.Setup(x => x.GetBiddingDataExclusion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingDataExclusionServiceClient client = new BiddingDataExclusionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingDataExclusion response = client.GetBiddingDataExclusion(request.ResourceNameAsBiddingDataExclusionName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetBiddingDataExclusionResourceNamesAsync()
        {
            moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient> mockGrpcClient = new moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient>(moq::MockBehavior.Strict);
            GetBiddingDataExclusionRequest request = new GetBiddingDataExclusionRequest
            {
                ResourceNameAsBiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
            };
            gagvr::BiddingDataExclusion expectedResponse = new gagvr::BiddingDataExclusion
            {
                ResourceNameAsBiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                DataExclusionId = 3666595228757949308L,
                Scope = gagve::SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Campaign,
                Status = gagve::SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Enabled,
                StartDateTime = "start_date_timeea924cb1",
                EndDateTime = "end_date_timea95363f3",
                BiddingDataExclusionName = gagvr::BiddingDataExclusionName.FromCustomerSeasonalityEvent("[CUSTOMER_ID]", "[SEASONALITY_EVENT_ID]"),
                Description = "description2cf9da67",
                Devices =
                {
                    gagve::DeviceEnum.Types.Device.Unspecified,
                },
                CampaignsAsCampaignNames =
                {
                    gagvr::CampaignName.FromCustomerCampaign("[CUSTOMER_ID]", "[CAMPAIGN_ID]"),
                },
                AdvertisingChannelTypes =
                {
                    gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType.Local,
                },
            };
            mockGrpcClient.Setup(x => x.GetBiddingDataExclusionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BiddingDataExclusion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingDataExclusionServiceClient client = new BiddingDataExclusionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BiddingDataExclusion responseCallSettings = await client.GetBiddingDataExclusionAsync(request.ResourceNameAsBiddingDataExclusionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BiddingDataExclusion responseCancellationToken = await client.GetBiddingDataExclusionAsync(request.ResourceNameAsBiddingDataExclusionName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateBiddingDataExclusionsRequestObject()
        {
            moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient> mockGrpcClient = new moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient>(moq::MockBehavior.Strict);
            MutateBiddingDataExclusionsRequest request = new MutateBiddingDataExclusionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new BiddingDataExclusionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateBiddingDataExclusionsResponse expectedResponse = new MutateBiddingDataExclusionsResponse
            {
                Results =
                {
                    new MutateBiddingDataExclusionsResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateBiddingDataExclusions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingDataExclusionServiceClient client = new BiddingDataExclusionServiceClientImpl(mockGrpcClient.Object, null);
            MutateBiddingDataExclusionsResponse response = client.MutateBiddingDataExclusions(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateBiddingDataExclusionsRequestObjectAsync()
        {
            moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient> mockGrpcClient = new moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient>(moq::MockBehavior.Strict);
            MutateBiddingDataExclusionsRequest request = new MutateBiddingDataExclusionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new BiddingDataExclusionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateBiddingDataExclusionsResponse expectedResponse = new MutateBiddingDataExclusionsResponse
            {
                Results =
                {
                    new MutateBiddingDataExclusionsResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateBiddingDataExclusionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateBiddingDataExclusionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingDataExclusionServiceClient client = new BiddingDataExclusionServiceClientImpl(mockGrpcClient.Object, null);
            MutateBiddingDataExclusionsResponse responseCallSettings = await client.MutateBiddingDataExclusionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateBiddingDataExclusionsResponse responseCancellationToken = await client.MutateBiddingDataExclusionsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateBiddingDataExclusions()
        {
            moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient> mockGrpcClient = new moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient>(moq::MockBehavior.Strict);
            MutateBiddingDataExclusionsRequest request = new MutateBiddingDataExclusionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new BiddingDataExclusionOperation(),
                },
            };
            MutateBiddingDataExclusionsResponse expectedResponse = new MutateBiddingDataExclusionsResponse
            {
                Results =
                {
                    new MutateBiddingDataExclusionsResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateBiddingDataExclusions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BiddingDataExclusionServiceClient client = new BiddingDataExclusionServiceClientImpl(mockGrpcClient.Object, null);
            MutateBiddingDataExclusionsResponse response = client.MutateBiddingDataExclusions(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateBiddingDataExclusionsAsync()
        {
            moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient> mockGrpcClient = new moq::Mock<BiddingDataExclusionService.BiddingDataExclusionServiceClient>(moq::MockBehavior.Strict);
            MutateBiddingDataExclusionsRequest request = new MutateBiddingDataExclusionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new BiddingDataExclusionOperation(),
                },
            };
            MutateBiddingDataExclusionsResponse expectedResponse = new MutateBiddingDataExclusionsResponse
            {
                Results =
                {
                    new MutateBiddingDataExclusionsResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateBiddingDataExclusionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateBiddingDataExclusionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BiddingDataExclusionServiceClient client = new BiddingDataExclusionServiceClientImpl(mockGrpcClient.Object, null);
            MutateBiddingDataExclusionsResponse responseCallSettings = await client.MutateBiddingDataExclusionsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateBiddingDataExclusionsResponse responseCancellationToken = await client.MutateBiddingDataExclusionsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

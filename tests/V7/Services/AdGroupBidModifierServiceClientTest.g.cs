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

using gagvc = Google.Ads.GoogleAds.V7.Common;
using gagve = Google.Ads.GoogleAds.V7.Enums;
using gagvr = Google.Ads.GoogleAds.V7.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V7.Services;

namespace Google.Ads.GoogleAds.Tests.V7.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdGroupBidModifierServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAdGroupBidModifierRequestObject()
        {
            moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupBidModifierRequest request = new GetAdGroupBidModifierRequest
            {
                ResourceNameAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdGroupBidModifier expectedResponse = new gagvr::AdGroupBidModifier
            {
                ResourceNameAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                HotelDateSelectionType = new gagvc::HotelDateSelectionTypeInfo(),
                HotelAdvanceBookingWindow = new gagvc::HotelAdvanceBookingWindowInfo(),
                HotelLengthOfStay = new gagvc::HotelLengthOfStayInfo(),
                HotelCheckInDay = new gagvc::HotelCheckInDayInfo(),
                BidModifierSource = gagve::BidModifierSourceEnum.Types.BidModifierSource.AdGroup,
                Device = new gagvc::DeviceInfo(),
                PreferredContent = new gagvc::PreferredContentInfo(),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195068951933E+17,
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                HotelCheckInDateRange = new gagvc::HotelCheckInDateRangeInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupBidModifier(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupBidModifier response = client.GetAdGroupBidModifier(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupBidModifierRequestObjectAsync()
        {
            moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupBidModifierRequest request = new GetAdGroupBidModifierRequest
            {
                ResourceNameAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdGroupBidModifier expectedResponse = new gagvr::AdGroupBidModifier
            {
                ResourceNameAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                HotelDateSelectionType = new gagvc::HotelDateSelectionTypeInfo(),
                HotelAdvanceBookingWindow = new gagvc::HotelAdvanceBookingWindowInfo(),
                HotelLengthOfStay = new gagvc::HotelLengthOfStayInfo(),
                HotelCheckInDay = new gagvc::HotelCheckInDayInfo(),
                BidModifierSource = gagve::BidModifierSourceEnum.Types.BidModifierSource.AdGroup,
                Device = new gagvc::DeviceInfo(),
                PreferredContent = new gagvc::PreferredContentInfo(),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195068951933E+17,
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                HotelCheckInDateRange = new gagvc::HotelCheckInDateRangeInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupBidModifierAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupBidModifier>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupBidModifier responseCallSettings = await client.GetAdGroupBidModifierAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupBidModifier responseCancellationToken = await client.GetAdGroupBidModifierAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupBidModifier()
        {
            moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupBidModifierRequest request = new GetAdGroupBidModifierRequest
            {
                ResourceNameAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdGroupBidModifier expectedResponse = new gagvr::AdGroupBidModifier
            {
                ResourceNameAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                HotelDateSelectionType = new gagvc::HotelDateSelectionTypeInfo(),
                HotelAdvanceBookingWindow = new gagvc::HotelAdvanceBookingWindowInfo(),
                HotelLengthOfStay = new gagvc::HotelLengthOfStayInfo(),
                HotelCheckInDay = new gagvc::HotelCheckInDayInfo(),
                BidModifierSource = gagve::BidModifierSourceEnum.Types.BidModifierSource.AdGroup,
                Device = new gagvc::DeviceInfo(),
                PreferredContent = new gagvc::PreferredContentInfo(),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195068951933E+17,
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                HotelCheckInDateRange = new gagvc::HotelCheckInDateRangeInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupBidModifier(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupBidModifier response = client.GetAdGroupBidModifier(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupBidModifierAsync()
        {
            moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupBidModifierRequest request = new GetAdGroupBidModifierRequest
            {
                ResourceNameAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdGroupBidModifier expectedResponse = new gagvr::AdGroupBidModifier
            {
                ResourceNameAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                HotelDateSelectionType = new gagvc::HotelDateSelectionTypeInfo(),
                HotelAdvanceBookingWindow = new gagvc::HotelAdvanceBookingWindowInfo(),
                HotelLengthOfStay = new gagvc::HotelLengthOfStayInfo(),
                HotelCheckInDay = new gagvc::HotelCheckInDayInfo(),
                BidModifierSource = gagve::BidModifierSourceEnum.Types.BidModifierSource.AdGroup,
                Device = new gagvc::DeviceInfo(),
                PreferredContent = new gagvc::PreferredContentInfo(),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195068951933E+17,
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                HotelCheckInDateRange = new gagvc::HotelCheckInDateRangeInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupBidModifierAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupBidModifier>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupBidModifier responseCallSettings = await client.GetAdGroupBidModifierAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupBidModifier responseCancellationToken = await client.GetAdGroupBidModifierAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupBidModifierResourceNames()
        {
            moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupBidModifierRequest request = new GetAdGroupBidModifierRequest
            {
                ResourceNameAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdGroupBidModifier expectedResponse = new gagvr::AdGroupBidModifier
            {
                ResourceNameAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                HotelDateSelectionType = new gagvc::HotelDateSelectionTypeInfo(),
                HotelAdvanceBookingWindow = new gagvc::HotelAdvanceBookingWindowInfo(),
                HotelLengthOfStay = new gagvc::HotelLengthOfStayInfo(),
                HotelCheckInDay = new gagvc::HotelCheckInDayInfo(),
                BidModifierSource = gagve::BidModifierSourceEnum.Types.BidModifierSource.AdGroup,
                Device = new gagvc::DeviceInfo(),
                PreferredContent = new gagvc::PreferredContentInfo(),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195068951933E+17,
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                HotelCheckInDateRange = new gagvc::HotelCheckInDateRangeInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupBidModifier(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupBidModifier response = client.GetAdGroupBidModifier(request.ResourceNameAsAdGroupBidModifierName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupBidModifierResourceNamesAsync()
        {
            moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupBidModifierRequest request = new GetAdGroupBidModifierRequest
            {
                ResourceNameAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AdGroupBidModifier expectedResponse = new gagvr::AdGroupBidModifier
            {
                ResourceNameAsAdGroupBidModifierName = gagvr::AdGroupBidModifierName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                HotelDateSelectionType = new gagvc::HotelDateSelectionTypeInfo(),
                HotelAdvanceBookingWindow = new gagvc::HotelAdvanceBookingWindowInfo(),
                HotelLengthOfStay = new gagvc::HotelLengthOfStayInfo(),
                HotelCheckInDay = new gagvc::HotelCheckInDayInfo(),
                BidModifierSource = gagve::BidModifierSourceEnum.Types.BidModifierSource.AdGroup,
                Device = new gagvc::DeviceInfo(),
                PreferredContent = new gagvc::PreferredContentInfo(),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                CriterionId = 8584655242409302840L,
                BidModifier = 1.6595195068951933E+17,
                BaseAdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER_ID]", "[AD_GROUP_ID]"),
                HotelCheckInDateRange = new gagvc::HotelCheckInDateRangeInfo(),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupBidModifierAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupBidModifier>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupBidModifier responseCallSettings = await client.GetAdGroupBidModifierAsync(request.ResourceNameAsAdGroupBidModifierName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupBidModifier responseCancellationToken = await client.GetAdGroupBidModifierAsync(request.ResourceNameAsAdGroupBidModifierName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupBidModifiersRequestObject()
        {
            moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupBidModifiersRequest request = new MutateAdGroupBidModifiersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupBidModifierOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupBidModifiersResponse expectedResponse = new MutateAdGroupBidModifiersResponse
            {
                Results =
                {
                    new MutateAdGroupBidModifierResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupBidModifiers(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupBidModifiersResponse response = client.MutateAdGroupBidModifiers(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupBidModifiersRequestObjectAsync()
        {
            moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupBidModifiersRequest request = new MutateAdGroupBidModifiersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupBidModifierOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupBidModifiersResponse expectedResponse = new MutateAdGroupBidModifiersResponse
            {
                Results =
                {
                    new MutateAdGroupBidModifierResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupBidModifiersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupBidModifiersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupBidModifiersResponse responseCallSettings = await client.MutateAdGroupBidModifiersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupBidModifiersResponse responseCancellationToken = await client.MutateAdGroupBidModifiersAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupBidModifiers()
        {
            moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupBidModifiersRequest request = new MutateAdGroupBidModifiersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupBidModifierOperation(),
                },
            };
            MutateAdGroupBidModifiersResponse expectedResponse = new MutateAdGroupBidModifiersResponse
            {
                Results =
                {
                    new MutateAdGroupBidModifierResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupBidModifiers(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupBidModifiersResponse response = client.MutateAdGroupBidModifiers(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupBidModifiersAsync()
        {
            moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new moq::Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupBidModifiersRequest request = new MutateAdGroupBidModifiersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupBidModifierOperation(),
                },
            };
            MutateAdGroupBidModifiersResponse expectedResponse = new MutateAdGroupBidModifiersResponse
            {
                Results =
                {
                    new MutateAdGroupBidModifierResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupBidModifiersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupBidModifiersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupBidModifiersResponse responseCallSettings = await client.MutateAdGroupBidModifiersAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupBidModifiersResponse responseCancellationToken = await client.MutateAdGroupBidModifiersAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

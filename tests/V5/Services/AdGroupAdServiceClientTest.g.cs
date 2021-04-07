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

using gagve = Google.Ads.GoogleAds.V5.Enums;
using gagvr = Google.Ads.GoogleAds.V5.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V5.Services;

namespace Google.Ads.GoogleAds.Tests.V5.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdGroupAdServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAdGroupAdRequestObject()
        {
            moq::Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdService.AdGroupAdServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdRequest request = new GetAdGroupAdRequest
            {
                ResourceNameAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
            };
            gagvr::AdGroupAd expectedResponse = new gagvr::AdGroupAd
            {
                ResourceNameAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                Status = gagve::AdGroupAdStatusEnum.Types.AdGroupAdStatus.Removed,
                Ad = new gagvr::Ad(),
                PolicySummary = new gagvr::AdGroupAdPolicySummary(),
                AdStrength = gagve::AdStrengthEnum.Types.AdStrength.Excellent,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAd(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAd response = client.GetAdGroupAd(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupAdRequestObjectAsync()
        {
            moq::Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdService.AdGroupAdServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdRequest request = new GetAdGroupAdRequest
            {
                ResourceNameAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
            };
            gagvr::AdGroupAd expectedResponse = new gagvr::AdGroupAd
            {
                ResourceNameAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                Status = gagve::AdGroupAdStatusEnum.Types.AdGroupAdStatus.Removed,
                Ad = new gagvr::Ad(),
                PolicySummary = new gagvr::AdGroupAdPolicySummary(),
                AdStrength = gagve::AdStrengthEnum.Types.AdStrength.Excellent,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupAd>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAd responseCallSettings = await client.GetAdGroupAdAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupAd responseCancellationToken = await client.GetAdGroupAdAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupAd()
        {
            moq::Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdService.AdGroupAdServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdRequest request = new GetAdGroupAdRequest
            {
                ResourceNameAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
            };
            gagvr::AdGroupAd expectedResponse = new gagvr::AdGroupAd
            {
                ResourceNameAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                Status = gagve::AdGroupAdStatusEnum.Types.AdGroupAdStatus.Removed,
                Ad = new gagvr::Ad(),
                PolicySummary = new gagvr::AdGroupAdPolicySummary(),
                AdStrength = gagve::AdStrengthEnum.Types.AdStrength.Excellent,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAd(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAd response = client.GetAdGroupAd(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupAdAsync()
        {
            moq::Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdService.AdGroupAdServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdRequest request = new GetAdGroupAdRequest
            {
                ResourceNameAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
            };
            gagvr::AdGroupAd expectedResponse = new gagvr::AdGroupAd
            {
                ResourceNameAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                Status = gagve::AdGroupAdStatusEnum.Types.AdGroupAdStatus.Removed,
                Ad = new gagvr::Ad(),
                PolicySummary = new gagvr::AdGroupAdPolicySummary(),
                AdStrength = gagve::AdStrengthEnum.Types.AdStrength.Excellent,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupAd>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAd responseCallSettings = await client.GetAdGroupAdAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupAd responseCancellationToken = await client.GetAdGroupAdAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupAdResourceNames()
        {
            moq::Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdService.AdGroupAdServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdRequest request = new GetAdGroupAdRequest
            {
                ResourceNameAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
            };
            gagvr::AdGroupAd expectedResponse = new gagvr::AdGroupAd
            {
                ResourceNameAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                Status = gagve::AdGroupAdStatusEnum.Types.AdGroupAdStatus.Removed,
                Ad = new gagvr::Ad(),
                PolicySummary = new gagvr::AdGroupAdPolicySummary(),
                AdStrength = gagve::AdStrengthEnum.Types.AdStrength.Excellent,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAd(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAd response = client.GetAdGroupAd(request.ResourceNameAsAdGroupAdName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupAdResourceNamesAsync()
        {
            moq::Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdService.AdGroupAdServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdRequest request = new GetAdGroupAdRequest
            {
                ResourceNameAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
            };
            gagvr::AdGroupAd expectedResponse = new gagvr::AdGroupAd
            {
                ResourceNameAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                Status = gagve::AdGroupAdStatusEnum.Types.AdGroupAdStatus.Removed,
                Ad = new gagvr::Ad(),
                PolicySummary = new gagvr::AdGroupAdPolicySummary(),
                AdStrength = gagve::AdStrengthEnum.Types.AdStrength.Excellent,
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupAd>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAd responseCallSettings = await client.GetAdGroupAdAsync(request.ResourceNameAsAdGroupAdName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupAd responseCancellationToken = await client.GetAdGroupAdAsync(request.ResourceNameAsAdGroupAdName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupAdsRequestObject()
        {
            moq::Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdService.AdGroupAdServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupAdsRequest request = new MutateAdGroupAdsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupAdOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupAdsResponse expectedResponse = new MutateAdGroupAdsResponse
            {
                Results =
                {
                    new MutateAdGroupAdResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupAds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupAdsResponse response = client.MutateAdGroupAds(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupAdsRequestObjectAsync()
        {
            moq::Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdService.AdGroupAdServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupAdsRequest request = new MutateAdGroupAdsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupAdOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupAdsResponse expectedResponse = new MutateAdGroupAdsResponse
            {
                Results =
                {
                    new MutateAdGroupAdResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupAdsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupAdsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupAdsResponse responseCallSettings = await client.MutateAdGroupAdsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupAdsResponse responseCancellationToken = await client.MutateAdGroupAdsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupAds()
        {
            moq::Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdService.AdGroupAdServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupAdsRequest request = new MutateAdGroupAdsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupAdOperation(),
                },
            };
            MutateAdGroupAdsResponse expectedResponse = new MutateAdGroupAdsResponse
            {
                Results =
                {
                    new MutateAdGroupAdResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupAds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupAdsResponse response = client.MutateAdGroupAds(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupAdsAsync()
        {
            moq::Mock<AdGroupAdService.AdGroupAdServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdService.AdGroupAdServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupAdsRequest request = new MutateAdGroupAdsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupAdOperation(),
                },
            };
            MutateAdGroupAdsResponse expectedResponse = new MutateAdGroupAdsResponse
            {
                Results =
                {
                    new MutateAdGroupAdResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupAdsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupAdsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdServiceClient client = new AdGroupAdServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupAdsResponse responseCallSettings = await client.MutateAdGroupAdsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupAdsResponse responseCancellationToken = await client.MutateAdGroupAdsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

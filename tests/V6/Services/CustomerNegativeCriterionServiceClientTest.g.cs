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

using gagvc = Google.Ads.GoogleAds.V6.Common;
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
    public sealed class GeneratedCustomerNegativeCriterionServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCustomerNegativeCriterionRequestObject()
        {
            moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(moq::MockBehavior.Strict);
            GetCustomerNegativeCriterionRequest request = new GetCustomerNegativeCriterionRequest
            {
                ResourceNameAsCustomerNegativeCriterionName = gagvr::CustomerNegativeCriterionName.FromCustomerCriterion("[CUSTOMER_ID]", "[CRITERION_ID]"),
            };
            gagvr::CustomerNegativeCriterion expectedResponse = new gagvr::CustomerNegativeCriterion
            {
                ResourceNameAsCustomerNegativeCriterionName = gagvr::CustomerNegativeCriterionName.FromCustomerCriterion("[CUSTOMER_ID]", "[CRITERION_ID]"),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.MobileApplication,
                ContentLabel = new gagvc::ContentLabelInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                Placement = new gagvc::PlacementInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                Id = -6774108720365892680L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerNegativeCriterion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerNegativeCriterion response = client.GetCustomerNegativeCriterion(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerNegativeCriterionRequestObjectAsync()
        {
            moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(moq::MockBehavior.Strict);
            GetCustomerNegativeCriterionRequest request = new GetCustomerNegativeCriterionRequest
            {
                ResourceNameAsCustomerNegativeCriterionName = gagvr::CustomerNegativeCriterionName.FromCustomerCriterion("[CUSTOMER_ID]", "[CRITERION_ID]"),
            };
            gagvr::CustomerNegativeCriterion expectedResponse = new gagvr::CustomerNegativeCriterion
            {
                ResourceNameAsCustomerNegativeCriterionName = gagvr::CustomerNegativeCriterionName.FromCustomerCriterion("[CUSTOMER_ID]", "[CRITERION_ID]"),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.MobileApplication,
                ContentLabel = new gagvc::ContentLabelInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                Placement = new gagvc::PlacementInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                Id = -6774108720365892680L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerNegativeCriterionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerNegativeCriterion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerNegativeCriterion responseCallSettings = await client.GetCustomerNegativeCriterionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerNegativeCriterion responseCancellationToken = await client.GetCustomerNegativeCriterionAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCustomerNegativeCriterion()
        {
            moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(moq::MockBehavior.Strict);
            GetCustomerNegativeCriterionRequest request = new GetCustomerNegativeCriterionRequest
            {
                ResourceNameAsCustomerNegativeCriterionName = gagvr::CustomerNegativeCriterionName.FromCustomerCriterion("[CUSTOMER_ID]", "[CRITERION_ID]"),
            };
            gagvr::CustomerNegativeCriterion expectedResponse = new gagvr::CustomerNegativeCriterion
            {
                ResourceNameAsCustomerNegativeCriterionName = gagvr::CustomerNegativeCriterionName.FromCustomerCriterion("[CUSTOMER_ID]", "[CRITERION_ID]"),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.MobileApplication,
                ContentLabel = new gagvc::ContentLabelInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                Placement = new gagvc::PlacementInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                Id = -6774108720365892680L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerNegativeCriterion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerNegativeCriterion response = client.GetCustomerNegativeCriterion(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerNegativeCriterionAsync()
        {
            moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(moq::MockBehavior.Strict);
            GetCustomerNegativeCriterionRequest request = new GetCustomerNegativeCriterionRequest
            {
                ResourceNameAsCustomerNegativeCriterionName = gagvr::CustomerNegativeCriterionName.FromCustomerCriterion("[CUSTOMER_ID]", "[CRITERION_ID]"),
            };
            gagvr::CustomerNegativeCriterion expectedResponse = new gagvr::CustomerNegativeCriterion
            {
                ResourceNameAsCustomerNegativeCriterionName = gagvr::CustomerNegativeCriterionName.FromCustomerCriterion("[CUSTOMER_ID]", "[CRITERION_ID]"),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.MobileApplication,
                ContentLabel = new gagvc::ContentLabelInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                Placement = new gagvc::PlacementInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                Id = -6774108720365892680L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerNegativeCriterionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerNegativeCriterion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerNegativeCriterion responseCallSettings = await client.GetCustomerNegativeCriterionAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerNegativeCriterion responseCancellationToken = await client.GetCustomerNegativeCriterionAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCustomerNegativeCriterionResourceNames()
        {
            moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(moq::MockBehavior.Strict);
            GetCustomerNegativeCriterionRequest request = new GetCustomerNegativeCriterionRequest
            {
                ResourceNameAsCustomerNegativeCriterionName = gagvr::CustomerNegativeCriterionName.FromCustomerCriterion("[CUSTOMER_ID]", "[CRITERION_ID]"),
            };
            gagvr::CustomerNegativeCriterion expectedResponse = new gagvr::CustomerNegativeCriterion
            {
                ResourceNameAsCustomerNegativeCriterionName = gagvr::CustomerNegativeCriterionName.FromCustomerCriterion("[CUSTOMER_ID]", "[CRITERION_ID]"),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.MobileApplication,
                ContentLabel = new gagvc::ContentLabelInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                Placement = new gagvc::PlacementInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                Id = -6774108720365892680L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerNegativeCriterion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerNegativeCriterion response = client.GetCustomerNegativeCriterion(request.ResourceNameAsCustomerNegativeCriterionName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomerNegativeCriterionResourceNamesAsync()
        {
            moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(moq::MockBehavior.Strict);
            GetCustomerNegativeCriterionRequest request = new GetCustomerNegativeCriterionRequest
            {
                ResourceNameAsCustomerNegativeCriterionName = gagvr::CustomerNegativeCriterionName.FromCustomerCriterion("[CUSTOMER_ID]", "[CRITERION_ID]"),
            };
            gagvr::CustomerNegativeCriterion expectedResponse = new gagvr::CustomerNegativeCriterion
            {
                ResourceNameAsCustomerNegativeCriterionName = gagvr::CustomerNegativeCriterionName.FromCustomerCriterion("[CUSTOMER_ID]", "[CRITERION_ID]"),
                Type = gagve::CriterionTypeEnum.Types.CriterionType.MobileApplication,
                ContentLabel = new gagvc::ContentLabelInfo(),
                MobileApplication = new gagvc::MobileApplicationInfo(),
                MobileAppCategory = new gagvc::MobileAppCategoryInfo(),
                Placement = new gagvc::PlacementInfo(),
                YoutubeVideo = new gagvc::YouTubeVideoInfo(),
                YoutubeChannel = new gagvc::YouTubeChannelInfo(),
                Id = -6774108720365892680L,
            };
            mockGrpcClient.Setup(x => x.GetCustomerNegativeCriterionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerNegativeCriterion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerNegativeCriterion responseCallSettings = await client.GetCustomerNegativeCriterionAsync(request.ResourceNameAsCustomerNegativeCriterionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerNegativeCriterion responseCancellationToken = await client.GetCustomerNegativeCriterionAsync(request.ResourceNameAsCustomerNegativeCriterionName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomerNegativeCriteriaRequestObject()
        {
            moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerNegativeCriteriaRequest request = new MutateCustomerNegativeCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerNegativeCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCustomerNegativeCriteriaResponse expectedResponse = new MutateCustomerNegativeCriteriaResponse
            {
                Results =
                {
                    new MutateCustomerNegativeCriteriaResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerNegativeCriteria(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerNegativeCriteriaResponse response = client.MutateCustomerNegativeCriteria(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerNegativeCriteriaRequestObjectAsync()
        {
            moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerNegativeCriteriaRequest request = new MutateCustomerNegativeCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerNegativeCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateCustomerNegativeCriteriaResponse expectedResponse = new MutateCustomerNegativeCriteriaResponse
            {
                Results =
                {
                    new MutateCustomerNegativeCriteriaResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerNegativeCriteriaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerNegativeCriteriaResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerNegativeCriteriaResponse responseCallSettings = await client.MutateCustomerNegativeCriteriaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerNegativeCriteriaResponse responseCancellationToken = await client.MutateCustomerNegativeCriteriaAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomerNegativeCriteria()
        {
            moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerNegativeCriteriaRequest request = new MutateCustomerNegativeCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerNegativeCriterionOperation(),
                },
            };
            MutateCustomerNegativeCriteriaResponse expectedResponse = new MutateCustomerNegativeCriteriaResponse
            {
                Results =
                {
                    new MutateCustomerNegativeCriteriaResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerNegativeCriteria(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerNegativeCriteriaResponse response = client.MutateCustomerNegativeCriteria(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerNegativeCriteriaAsync()
        {
            moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient> mockGrpcClient = new moq::Mock<CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerNegativeCriteriaRequest request = new MutateCustomerNegativeCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerNegativeCriterionOperation(),
                },
            };
            MutateCustomerNegativeCriteriaResponse expectedResponse = new MutateCustomerNegativeCriteriaResponse
            {
                Results =
                {
                    new MutateCustomerNegativeCriteriaResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateCustomerNegativeCriteriaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerNegativeCriteriaResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerNegativeCriterionServiceClient client = new CustomerNegativeCriterionServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerNegativeCriteriaResponse responseCallSettings = await client.MutateCustomerNegativeCriteriaAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerNegativeCriteriaResponse responseCancellationToken = await client.MutateCustomerNegativeCriteriaAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

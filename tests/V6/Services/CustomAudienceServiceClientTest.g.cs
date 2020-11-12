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
    public sealed class GeneratedCustomAudienceServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetCustomAudienceRequestObject()
        {
            moq::Mock<CustomAudienceService.CustomAudienceServiceClient> mockGrpcClient = new moq::Mock<CustomAudienceService.CustomAudienceServiceClient>(moq::MockBehavior.Strict);
            GetCustomAudienceRequest request = new GetCustomAudienceRequest
            {
                ResourceNameAsCustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
            };
            gagvr::CustomAudience expectedResponse = new gagvr::CustomAudience
            {
                ResourceNameAsCustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
                Id = -6774108720365892680L,
                Status = gagve::CustomAudienceStatusEnum.Types.CustomAudienceStatus.Enabled,
                CustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
                Type = gagve::CustomAudienceTypeEnum.Types.CustomAudienceType.Interest,
                Description = "description2cf9da67",
                Members =
                {
                    new gagvr::CustomAudienceMember(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomAudience(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomAudienceServiceClient client = new CustomAudienceServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomAudience response = client.GetCustomAudience(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomAudienceRequestObjectAsync()
        {
            moq::Mock<CustomAudienceService.CustomAudienceServiceClient> mockGrpcClient = new moq::Mock<CustomAudienceService.CustomAudienceServiceClient>(moq::MockBehavior.Strict);
            GetCustomAudienceRequest request = new GetCustomAudienceRequest
            {
                ResourceNameAsCustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
            };
            gagvr::CustomAudience expectedResponse = new gagvr::CustomAudience
            {
                ResourceNameAsCustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
                Id = -6774108720365892680L,
                Status = gagve::CustomAudienceStatusEnum.Types.CustomAudienceStatus.Enabled,
                CustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
                Type = gagve::CustomAudienceTypeEnum.Types.CustomAudienceType.Interest,
                Description = "description2cf9da67",
                Members =
                {
                    new gagvr::CustomAudienceMember(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomAudienceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomAudience>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomAudienceServiceClient client = new CustomAudienceServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomAudience responseCallSettings = await client.GetCustomAudienceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomAudience responseCancellationToken = await client.GetCustomAudienceAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCustomAudience()
        {
            moq::Mock<CustomAudienceService.CustomAudienceServiceClient> mockGrpcClient = new moq::Mock<CustomAudienceService.CustomAudienceServiceClient>(moq::MockBehavior.Strict);
            GetCustomAudienceRequest request = new GetCustomAudienceRequest
            {
                ResourceNameAsCustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
            };
            gagvr::CustomAudience expectedResponse = new gagvr::CustomAudience
            {
                ResourceNameAsCustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
                Id = -6774108720365892680L,
                Status = gagve::CustomAudienceStatusEnum.Types.CustomAudienceStatus.Enabled,
                CustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
                Type = gagve::CustomAudienceTypeEnum.Types.CustomAudienceType.Interest,
                Description = "description2cf9da67",
                Members =
                {
                    new gagvr::CustomAudienceMember(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomAudience(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomAudienceServiceClient client = new CustomAudienceServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomAudience response = client.GetCustomAudience(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomAudienceAsync()
        {
            moq::Mock<CustomAudienceService.CustomAudienceServiceClient> mockGrpcClient = new moq::Mock<CustomAudienceService.CustomAudienceServiceClient>(moq::MockBehavior.Strict);
            GetCustomAudienceRequest request = new GetCustomAudienceRequest
            {
                ResourceNameAsCustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
            };
            gagvr::CustomAudience expectedResponse = new gagvr::CustomAudience
            {
                ResourceNameAsCustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
                Id = -6774108720365892680L,
                Status = gagve::CustomAudienceStatusEnum.Types.CustomAudienceStatus.Enabled,
                CustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
                Type = gagve::CustomAudienceTypeEnum.Types.CustomAudienceType.Interest,
                Description = "description2cf9da67",
                Members =
                {
                    new gagvr::CustomAudienceMember(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomAudienceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomAudience>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomAudienceServiceClient client = new CustomAudienceServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomAudience responseCallSettings = await client.GetCustomAudienceAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomAudience responseCancellationToken = await client.GetCustomAudienceAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetCustomAudienceResourceNames()
        {
            moq::Mock<CustomAudienceService.CustomAudienceServiceClient> mockGrpcClient = new moq::Mock<CustomAudienceService.CustomAudienceServiceClient>(moq::MockBehavior.Strict);
            GetCustomAudienceRequest request = new GetCustomAudienceRequest
            {
                ResourceNameAsCustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
            };
            gagvr::CustomAudience expectedResponse = new gagvr::CustomAudience
            {
                ResourceNameAsCustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
                Id = -6774108720365892680L,
                Status = gagve::CustomAudienceStatusEnum.Types.CustomAudienceStatus.Enabled,
                CustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
                Type = gagve::CustomAudienceTypeEnum.Types.CustomAudienceType.Interest,
                Description = "description2cf9da67",
                Members =
                {
                    new gagvr::CustomAudienceMember(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomAudience(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomAudienceServiceClient client = new CustomAudienceServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomAudience response = client.GetCustomAudience(request.ResourceNameAsCustomAudienceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetCustomAudienceResourceNamesAsync()
        {
            moq::Mock<CustomAudienceService.CustomAudienceServiceClient> mockGrpcClient = new moq::Mock<CustomAudienceService.CustomAudienceServiceClient>(moq::MockBehavior.Strict);
            GetCustomAudienceRequest request = new GetCustomAudienceRequest
            {
                ResourceNameAsCustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
            };
            gagvr::CustomAudience expectedResponse = new gagvr::CustomAudience
            {
                ResourceNameAsCustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
                Id = -6774108720365892680L,
                Status = gagve::CustomAudienceStatusEnum.Types.CustomAudienceStatus.Enabled,
                CustomAudienceName = gagvr::CustomAudienceName.FromCustomerCustomAudience("[CUSTOMER_ID]", "[CUSTOM_AUDIENCE_ID]"),
                Type = gagve::CustomAudienceTypeEnum.Types.CustomAudienceType.Interest,
                Description = "description2cf9da67",
                Members =
                {
                    new gagvr::CustomAudienceMember(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomAudienceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomAudience>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomAudienceServiceClient client = new CustomAudienceServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomAudience responseCallSettings = await client.GetCustomAudienceAsync(request.ResourceNameAsCustomAudienceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomAudience responseCancellationToken = await client.GetCustomAudienceAsync(request.ResourceNameAsCustomAudienceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomAudiencesRequestObject()
        {
            moq::Mock<CustomAudienceService.CustomAudienceServiceClient> mockGrpcClient = new moq::Mock<CustomAudienceService.CustomAudienceServiceClient>(moq::MockBehavior.Strict);
            MutateCustomAudiencesRequest request = new MutateCustomAudiencesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomAudienceOperation(),
                },
                ValidateOnly = true,
            };
            MutateCustomAudiencesResponse expectedResponse = new MutateCustomAudiencesResponse
            {
                Results =
                {
                    new MutateCustomAudienceResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomAudiences(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomAudienceServiceClient client = new CustomAudienceServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomAudiencesResponse response = client.MutateCustomAudiences(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomAudiencesRequestObjectAsync()
        {
            moq::Mock<CustomAudienceService.CustomAudienceServiceClient> mockGrpcClient = new moq::Mock<CustomAudienceService.CustomAudienceServiceClient>(moq::MockBehavior.Strict);
            MutateCustomAudiencesRequest request = new MutateCustomAudiencesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomAudienceOperation(),
                },
                ValidateOnly = true,
            };
            MutateCustomAudiencesResponse expectedResponse = new MutateCustomAudiencesResponse
            {
                Results =
                {
                    new MutateCustomAudienceResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomAudiencesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomAudiencesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomAudienceServiceClient client = new CustomAudienceServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomAudiencesResponse responseCallSettings = await client.MutateCustomAudiencesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomAudiencesResponse responseCancellationToken = await client.MutateCustomAudiencesAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomAudiences()
        {
            moq::Mock<CustomAudienceService.CustomAudienceServiceClient> mockGrpcClient = new moq::Mock<CustomAudienceService.CustomAudienceServiceClient>(moq::MockBehavior.Strict);
            MutateCustomAudiencesRequest request = new MutateCustomAudiencesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomAudienceOperation(),
                },
            };
            MutateCustomAudiencesResponse expectedResponse = new MutateCustomAudiencesResponse
            {
                Results =
                {
                    new MutateCustomAudienceResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomAudiences(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomAudienceServiceClient client = new CustomAudienceServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomAudiencesResponse response = client.MutateCustomAudiences(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomAudiencesAsync()
        {
            moq::Mock<CustomAudienceService.CustomAudienceServiceClient> mockGrpcClient = new moq::Mock<CustomAudienceService.CustomAudienceServiceClient>(moq::MockBehavior.Strict);
            MutateCustomAudiencesRequest request = new MutateCustomAudiencesRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomAudienceOperation(),
                },
            };
            MutateCustomAudiencesResponse expectedResponse = new MutateCustomAudiencesResponse
            {
                Results =
                {
                    new MutateCustomAudienceResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomAudiencesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomAudiencesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomAudienceServiceClient client = new CustomAudienceServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomAudiencesResponse responseCallSettings = await client.MutateCustomAudiencesAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomAudiencesResponse responseCancellationToken = await client.MutateCustomAudiencesAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

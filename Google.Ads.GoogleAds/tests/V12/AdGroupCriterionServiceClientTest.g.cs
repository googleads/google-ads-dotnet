// Copyright 2022 Google LLC
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

#pragma warning disable CS8981
using gagve = Google.Ads.GoogleAds.V12.Enums;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V12.Services;

namespace Google.Ads.GoogleAds.Tests.V12.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdGroupCriterionServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateAdGroupCriteriaRequestObject()
        {
            moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriteriaRequest request = new MutateAdGroupCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupCriteriaResponse expectedResponse = new MutateAdGroupCriteriaResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriteria(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateAdGroupCriteriaResponse response = client.MutateAdGroupCriteria(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateAdGroupCriteriaRequestObjectAsync()
        {
            moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriteriaRequest request = new MutateAdGroupCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupCriteriaResponse expectedResponse = new MutateAdGroupCriteriaResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriteriaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupCriteriaResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateAdGroupCriteriaResponse responseCallSettings = await client.MutateAdGroupCriteriaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupCriteriaResponse responseCancellationToken = await client.MutateAdGroupCriteriaAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateAdGroupCriteria()
        {
            moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriteriaRequest request = new MutateAdGroupCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionOperation(),
                },
            };
            MutateAdGroupCriteriaResponse expectedResponse = new MutateAdGroupCriteriaResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriteria(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateAdGroupCriteriaResponse response = client.MutateAdGroupCriteria(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateAdGroupCriteriaAsync()
        {
            moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionService.AdGroupCriterionServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriteriaRequest request = new MutateAdGroupCriteriaRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionOperation(),
                },
            };
            MutateAdGroupCriteriaResponse expectedResponse = new MutateAdGroupCriteriaResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriteriaAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupCriteriaResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionServiceClient client = new AdGroupCriterionServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateAdGroupCriteriaResponse responseCallSettings = await client.MutateAdGroupCriteriaAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupCriteriaResponse responseCancellationToken = await client.MutateAdGroupCriteriaAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
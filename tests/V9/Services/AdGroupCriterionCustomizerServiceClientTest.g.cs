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

using gagve = Google.Ads.GoogleAds.V9.Enums;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V9.Services;

namespace Google.Ads.GoogleAds.Tests.V9.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdGroupCriterionCustomizerServiceClientTest
    {
        [Category("Smoke")][Test]
        public void MutateAdGroupCriterionCustomizersRequestObject()
        {
            moq::Mock<AdGroupCriterionCustomizerService.AdGroupCriterionCustomizerServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionCustomizerService.AdGroupCriterionCustomizerServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriterionCustomizersRequest request = new MutateAdGroupCriterionCustomizersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionCustomizerOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupCriterionCustomizersResponse expectedResponse = new MutateAdGroupCriterionCustomizersResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionCustomizerResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionCustomizers(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionCustomizerServiceClient client = new AdGroupCriterionCustomizerServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriterionCustomizersResponse response = client.MutateAdGroupCriterionCustomizers(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupCriterionCustomizersRequestObjectAsync()
        {
            moq::Mock<AdGroupCriterionCustomizerService.AdGroupCriterionCustomizerServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionCustomizerService.AdGroupCriterionCustomizerServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriterionCustomizersRequest request = new MutateAdGroupCriterionCustomizersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionCustomizerOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdGroupCriterionCustomizersResponse expectedResponse = new MutateAdGroupCriterionCustomizersResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionCustomizerResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionCustomizersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupCriterionCustomizersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionCustomizerServiceClient client = new AdGroupCriterionCustomizerServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriterionCustomizersResponse responseCallSettings = await client.MutateAdGroupCriterionCustomizersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupCriterionCustomizersResponse responseCancellationToken = await client.MutateAdGroupCriterionCustomizersAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupCriterionCustomizers()
        {
            moq::Mock<AdGroupCriterionCustomizerService.AdGroupCriterionCustomizerServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionCustomizerService.AdGroupCriterionCustomizerServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriterionCustomizersRequest request = new MutateAdGroupCriterionCustomizersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionCustomizerOperation(),
                },
            };
            MutateAdGroupCriterionCustomizersResponse expectedResponse = new MutateAdGroupCriterionCustomizersResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionCustomizerResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionCustomizers(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionCustomizerServiceClient client = new AdGroupCriterionCustomizerServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriterionCustomizersResponse response = client.MutateAdGroupCriterionCustomizers(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupCriterionCustomizersAsync()
        {
            moq::Mock<AdGroupCriterionCustomizerService.AdGroupCriterionCustomizerServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionCustomizerService.AdGroupCriterionCustomizerServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriterionCustomizersRequest request = new MutateAdGroupCriterionCustomizersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionCustomizerOperation(),
                },
            };
            MutateAdGroupCriterionCustomizersResponse expectedResponse = new MutateAdGroupCriterionCustomizersResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionCustomizerResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionCustomizersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupCriterionCustomizersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionCustomizerServiceClient client = new AdGroupCriterionCustomizerServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriterionCustomizersResponse responseCallSettings = await client.MutateAdGroupCriterionCustomizersAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupCriterionCustomizersResponse responseCancellationToken = await client.MutateAdGroupCriterionCustomizersAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

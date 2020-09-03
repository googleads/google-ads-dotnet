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
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V2.Services;

namespace Google.Ads.GoogleAds.Tests.V2.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedGoogleAdsServiceClientTest
    {
        [Category("Smoke")][Test]
        public void MutateRequestObject()
        {
            moq::Mock<GoogleAdsService.GoogleAdsServiceClient> mockGrpcClient = new moq::Mock<GoogleAdsService.GoogleAdsServiceClient>(moq::MockBehavior.Strict);
            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest
            {
                CustomerId = "customer_id3b3724cb",
                MutateOperations =
                {
                    new MutateOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateGoogleAdsResponse expectedResponse = new MutateGoogleAdsResponse
            {
                MutateOperationResponses =
                {
                    new MutateOperationResponse(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.Mutate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GoogleAdsServiceClient client = new GoogleAdsServiceClientImpl(mockGrpcClient.Object, null);
            MutateGoogleAdsResponse response = client.Mutate(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateRequestObjectAsync()
        {
            moq::Mock<GoogleAdsService.GoogleAdsServiceClient> mockGrpcClient = new moq::Mock<GoogleAdsService.GoogleAdsServiceClient>(moq::MockBehavior.Strict);
            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest
            {
                CustomerId = "customer_id3b3724cb",
                MutateOperations =
                {
                    new MutateOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateGoogleAdsResponse expectedResponse = new MutateGoogleAdsResponse
            {
                MutateOperationResponses =
                {
                    new MutateOperationResponse(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateGoogleAdsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GoogleAdsServiceClient client = new GoogleAdsServiceClientImpl(mockGrpcClient.Object, null);
            MutateGoogleAdsResponse responseCallSettings = await client.MutateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateGoogleAdsResponse responseCancellationToken = await client.MutateAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void Mutate()
        {
            moq::Mock<GoogleAdsService.GoogleAdsServiceClient> mockGrpcClient = new moq::Mock<GoogleAdsService.GoogleAdsServiceClient>(moq::MockBehavior.Strict);
            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest
            {
                CustomerId = "customer_id3b3724cb",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            MutateGoogleAdsResponse expectedResponse = new MutateGoogleAdsResponse
            {
                MutateOperationResponses =
                {
                    new MutateOperationResponse(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.Mutate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GoogleAdsServiceClient client = new GoogleAdsServiceClientImpl(mockGrpcClient.Object, null);
            MutateGoogleAdsResponse response = client.Mutate(request.CustomerId, request.MutateOperations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAsync()
        {
            moq::Mock<GoogleAdsService.GoogleAdsServiceClient> mockGrpcClient = new moq::Mock<GoogleAdsService.GoogleAdsServiceClient>(moq::MockBehavior.Strict);
            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest
            {
                CustomerId = "customer_id3b3724cb",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            MutateGoogleAdsResponse expectedResponse = new MutateGoogleAdsResponse
            {
                MutateOperationResponses =
                {
                    new MutateOperationResponse(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateGoogleAdsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GoogleAdsServiceClient client = new GoogleAdsServiceClientImpl(mockGrpcClient.Object, null);
            MutateGoogleAdsResponse responseCallSettings = await client.MutateAsync(request.CustomerId, request.MutateOperations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateGoogleAdsResponse responseCancellationToken = await client.MutateAsync(request.CustomerId, request.MutateOperations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

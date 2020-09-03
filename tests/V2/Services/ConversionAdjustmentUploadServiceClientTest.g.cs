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
    public sealed class GeneratedConversionAdjustmentUploadServiceClientTest
    {
        [Category("Smoke")][Test]
        public void UploadConversionAdjustmentsRequestObject()
        {
            moq::Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient> mockGrpcClient = new moq::Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient>(moq::MockBehavior.Strict);
            UploadConversionAdjustmentsRequest request = new UploadConversionAdjustmentsRequest
            {
                CustomerId = "customer_id3b3724cb",
                ConversionAdjustments =
                {
                    new ConversionAdjustment(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            UploadConversionAdjustmentsResponse expectedResponse = new UploadConversionAdjustmentsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new ConversionAdjustmentResult(),
                },
            };
            mockGrpcClient.Setup(x => x.UploadConversionAdjustments(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionAdjustmentUploadServiceClient client = new ConversionAdjustmentUploadServiceClientImpl(mockGrpcClient.Object, null);
            UploadConversionAdjustmentsResponse response = client.UploadConversionAdjustments(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task UploadConversionAdjustmentsRequestObjectAsync()
        {
            moq::Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient> mockGrpcClient = new moq::Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient>(moq::MockBehavior.Strict);
            UploadConversionAdjustmentsRequest request = new UploadConversionAdjustmentsRequest
            {
                CustomerId = "customer_id3b3724cb",
                ConversionAdjustments =
                {
                    new ConversionAdjustment(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            UploadConversionAdjustmentsResponse expectedResponse = new UploadConversionAdjustmentsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new ConversionAdjustmentResult(),
                },
            };
            mockGrpcClient.Setup(x => x.UploadConversionAdjustmentsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UploadConversionAdjustmentsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionAdjustmentUploadServiceClient client = new ConversionAdjustmentUploadServiceClientImpl(mockGrpcClient.Object, null);
            UploadConversionAdjustmentsResponse responseCallSettings = await client.UploadConversionAdjustmentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            UploadConversionAdjustmentsResponse responseCancellationToken = await client.UploadConversionAdjustmentsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void UploadConversionAdjustments()
        {
            moq::Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient> mockGrpcClient = new moq::Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient>(moq::MockBehavior.Strict);
            UploadConversionAdjustmentsRequest request = new UploadConversionAdjustmentsRequest
            {
                CustomerId = "customer_id3b3724cb",
                ConversionAdjustments =
                {
                    new ConversionAdjustment(),
                },
                PartialFailure = false,
            };
            UploadConversionAdjustmentsResponse expectedResponse = new UploadConversionAdjustmentsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new ConversionAdjustmentResult(),
                },
            };
            mockGrpcClient.Setup(x => x.UploadConversionAdjustments(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionAdjustmentUploadServiceClient client = new ConversionAdjustmentUploadServiceClientImpl(mockGrpcClient.Object, null);
            UploadConversionAdjustmentsResponse response = client.UploadConversionAdjustments(request.CustomerId, request.ConversionAdjustments, request.PartialFailure);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task UploadConversionAdjustmentsAsync()
        {
            moq::Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient> mockGrpcClient = new moq::Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient>(moq::MockBehavior.Strict);
            UploadConversionAdjustmentsRequest request = new UploadConversionAdjustmentsRequest
            {
                CustomerId = "customer_id3b3724cb",
                ConversionAdjustments =
                {
                    new ConversionAdjustment(),
                },
                PartialFailure = false,
            };
            UploadConversionAdjustmentsResponse expectedResponse = new UploadConversionAdjustmentsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new ConversionAdjustmentResult(),
                },
            };
            mockGrpcClient.Setup(x => x.UploadConversionAdjustmentsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UploadConversionAdjustmentsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionAdjustmentUploadServiceClient client = new ConversionAdjustmentUploadServiceClientImpl(mockGrpcClient.Object, null);
            UploadConversionAdjustmentsResponse responseCallSettings = await client.UploadConversionAdjustmentsAsync(request.CustomerId, request.ConversionAdjustments, request.PartialFailure, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            UploadConversionAdjustmentsResponse responseCancellationToken = await client.UploadConversionAdjustmentsAsync(request.CustomerId, request.ConversionAdjustments, request.PartialFailure, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

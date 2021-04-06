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

using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V4.Services;

namespace Google.Ads.GoogleAds.Tests.V4.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedConversionUploadServiceClientTest
    {
        [Category("Smoke")][Test]
        public void UploadClickConversionsRequestObject()
        {
            moq::Mock<ConversionUploadService.ConversionUploadServiceClient> mockGrpcClient = new moq::Mock<ConversionUploadService.ConversionUploadServiceClient>(moq::MockBehavior.Strict);
            UploadClickConversionsRequest request = new UploadClickConversionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Conversions =
                {
                    new ClickConversion(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            UploadClickConversionsResponse expectedResponse = new UploadClickConversionsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new ClickConversionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.UploadClickConversions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionUploadServiceClient client = new ConversionUploadServiceClientImpl(mockGrpcClient.Object, null);
            UploadClickConversionsResponse response = client.UploadClickConversions(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task UploadClickConversionsRequestObjectAsync()
        {
            moq::Mock<ConversionUploadService.ConversionUploadServiceClient> mockGrpcClient = new moq::Mock<ConversionUploadService.ConversionUploadServiceClient>(moq::MockBehavior.Strict);
            UploadClickConversionsRequest request = new UploadClickConversionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Conversions =
                {
                    new ClickConversion(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            UploadClickConversionsResponse expectedResponse = new UploadClickConversionsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new ClickConversionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.UploadClickConversionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UploadClickConversionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionUploadServiceClient client = new ConversionUploadServiceClientImpl(mockGrpcClient.Object, null);
            UploadClickConversionsResponse responseCallSettings = await client.UploadClickConversionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            UploadClickConversionsResponse responseCancellationToken = await client.UploadClickConversionsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void UploadClickConversions()
        {
            moq::Mock<ConversionUploadService.ConversionUploadServiceClient> mockGrpcClient = new moq::Mock<ConversionUploadService.ConversionUploadServiceClient>(moq::MockBehavior.Strict);
            UploadClickConversionsRequest request = new UploadClickConversionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Conversions =
                {
                    new ClickConversion(),
                },
                PartialFailure = false,
            };
            UploadClickConversionsResponse expectedResponse = new UploadClickConversionsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new ClickConversionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.UploadClickConversions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionUploadServiceClient client = new ConversionUploadServiceClientImpl(mockGrpcClient.Object, null);
            UploadClickConversionsResponse response = client.UploadClickConversions(request.CustomerId, request.Conversions, request.PartialFailure);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task UploadClickConversionsAsync()
        {
            moq::Mock<ConversionUploadService.ConversionUploadServiceClient> mockGrpcClient = new moq::Mock<ConversionUploadService.ConversionUploadServiceClient>(moq::MockBehavior.Strict);
            UploadClickConversionsRequest request = new UploadClickConversionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Conversions =
                {
                    new ClickConversion(),
                },
                PartialFailure = false,
            };
            UploadClickConversionsResponse expectedResponse = new UploadClickConversionsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new ClickConversionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.UploadClickConversionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UploadClickConversionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionUploadServiceClient client = new ConversionUploadServiceClientImpl(mockGrpcClient.Object, null);
            UploadClickConversionsResponse responseCallSettings = await client.UploadClickConversionsAsync(request.CustomerId, request.Conversions, request.PartialFailure, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            UploadClickConversionsResponse responseCancellationToken = await client.UploadClickConversionsAsync(request.CustomerId, request.Conversions, request.PartialFailure, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void UploadCallConversionsRequestObject()
        {
            moq::Mock<ConversionUploadService.ConversionUploadServiceClient> mockGrpcClient = new moq::Mock<ConversionUploadService.ConversionUploadServiceClient>(moq::MockBehavior.Strict);
            UploadCallConversionsRequest request = new UploadCallConversionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Conversions =
                {
                    new CallConversion(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            UploadCallConversionsResponse expectedResponse = new UploadCallConversionsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new CallConversionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.UploadCallConversions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionUploadServiceClient client = new ConversionUploadServiceClientImpl(mockGrpcClient.Object, null);
            UploadCallConversionsResponse response = client.UploadCallConversions(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task UploadCallConversionsRequestObjectAsync()
        {
            moq::Mock<ConversionUploadService.ConversionUploadServiceClient> mockGrpcClient = new moq::Mock<ConversionUploadService.ConversionUploadServiceClient>(moq::MockBehavior.Strict);
            UploadCallConversionsRequest request = new UploadCallConversionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Conversions =
                {
                    new CallConversion(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            UploadCallConversionsResponse expectedResponse = new UploadCallConversionsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new CallConversionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.UploadCallConversionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UploadCallConversionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionUploadServiceClient client = new ConversionUploadServiceClientImpl(mockGrpcClient.Object, null);
            UploadCallConversionsResponse responseCallSettings = await client.UploadCallConversionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            UploadCallConversionsResponse responseCancellationToken = await client.UploadCallConversionsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void UploadCallConversions()
        {
            moq::Mock<ConversionUploadService.ConversionUploadServiceClient> mockGrpcClient = new moq::Mock<ConversionUploadService.ConversionUploadServiceClient>(moq::MockBehavior.Strict);
            UploadCallConversionsRequest request = new UploadCallConversionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Conversions =
                {
                    new CallConversion(),
                },
                PartialFailure = false,
            };
            UploadCallConversionsResponse expectedResponse = new UploadCallConversionsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new CallConversionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.UploadCallConversions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ConversionUploadServiceClient client = new ConversionUploadServiceClientImpl(mockGrpcClient.Object, null);
            UploadCallConversionsResponse response = client.UploadCallConversions(request.CustomerId, request.Conversions, request.PartialFailure);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task UploadCallConversionsAsync()
        {
            moq::Mock<ConversionUploadService.ConversionUploadServiceClient> mockGrpcClient = new moq::Mock<ConversionUploadService.ConversionUploadServiceClient>(moq::MockBehavior.Strict);
            UploadCallConversionsRequest request = new UploadCallConversionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Conversions =
                {
                    new CallConversion(),
                },
                PartialFailure = false,
            };
            UploadCallConversionsResponse expectedResponse = new UploadCallConversionsResponse
            {
                PartialFailureError = new gr::Status(),
                Results =
                {
                    new CallConversionResult(),
                },
            };
            mockGrpcClient.Setup(x => x.UploadCallConversionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UploadCallConversionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ConversionUploadServiceClient client = new ConversionUploadServiceClientImpl(mockGrpcClient.Object, null);
            UploadCallConversionsResponse responseCallSettings = await client.UploadCallConversionsAsync(request.CustomerId, request.Conversions, request.PartialFailure, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            UploadCallConversionsResponse responseCancellationToken = await client.UploadCallConversionsAsync(request.CustomerId, request.Conversions, request.PartialFailure, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

// Copyright 2019 Google LLC
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

namespace Google.Ads.GoogleAds.V1.Services.Tests
{
    using apis = Google.Ads.GoogleAds.V1.Services;
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using NUnit.Framework;

    /// <summary>Generated unit tests</summary>
    public class GeneratedConversionAdjustmentUploadServiceClientTest
    {
        [Test]
        public void UploadConversionAdjustments()
        {
            Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient> mockGrpcClient = new Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient>(MockBehavior.Strict);
            UploadConversionAdjustmentsRequest expectedRequest = new UploadConversionAdjustmentsRequest
            {
                CustomerId = "customerId-1772061412",
                ConversionAdjustments = { },
                PartialFailure = true,
            };
            UploadConversionAdjustmentsResponse expectedResponse = new UploadConversionAdjustmentsResponse();
            mockGrpcClient.Setup(x => x.UploadConversionAdjustments(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConversionAdjustmentUploadServiceClient client = new ConversionAdjustmentUploadServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ConversionAdjustment> conversionAdjustments = new List<ConversionAdjustment>();
            bool partialFailure = true;
            UploadConversionAdjustmentsResponse response = client.UploadConversionAdjustments(customerId, conversionAdjustments, partialFailure);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task UploadConversionAdjustmentsAsync()
        {
            Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient> mockGrpcClient = new Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient>(MockBehavior.Strict);
            UploadConversionAdjustmentsRequest expectedRequest = new UploadConversionAdjustmentsRequest
            {
                CustomerId = "customerId-1772061412",
                ConversionAdjustments = { },
                PartialFailure = true,
            };
            UploadConversionAdjustmentsResponse expectedResponse = new UploadConversionAdjustmentsResponse();
            mockGrpcClient.Setup(x => x.UploadConversionAdjustmentsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UploadConversionAdjustmentsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ConversionAdjustmentUploadServiceClient client = new ConversionAdjustmentUploadServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ConversionAdjustment> conversionAdjustments = new List<ConversionAdjustment>();
            bool partialFailure = true;
            UploadConversionAdjustmentsResponse response = await client.UploadConversionAdjustmentsAsync(customerId, conversionAdjustments, partialFailure);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void UploadConversionAdjustments2()
        {
            Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient> mockGrpcClient = new Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient>(MockBehavior.Strict);
            UploadConversionAdjustmentsRequest expectedRequest = new UploadConversionAdjustmentsRequest
            {
                CustomerId = "customerId-1772061412",
                ConversionAdjustments = { },
            };
            UploadConversionAdjustmentsResponse expectedResponse = new UploadConversionAdjustmentsResponse();
            mockGrpcClient.Setup(x => x.UploadConversionAdjustments(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConversionAdjustmentUploadServiceClient client = new ConversionAdjustmentUploadServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ConversionAdjustment> conversionAdjustments = new List<ConversionAdjustment>();
            UploadConversionAdjustmentsResponse response = client.UploadConversionAdjustments(customerId, conversionAdjustments);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task UploadConversionAdjustmentsAsync2()
        {
            Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient> mockGrpcClient = new Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient>(MockBehavior.Strict);
            UploadConversionAdjustmentsRequest expectedRequest = new UploadConversionAdjustmentsRequest
            {
                CustomerId = "customerId-1772061412",
                ConversionAdjustments = { },
            };
            UploadConversionAdjustmentsResponse expectedResponse = new UploadConversionAdjustmentsResponse();
            mockGrpcClient.Setup(x => x.UploadConversionAdjustmentsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UploadConversionAdjustmentsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ConversionAdjustmentUploadServiceClient client = new ConversionAdjustmentUploadServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ConversionAdjustment> conversionAdjustments = new List<ConversionAdjustment>();
            UploadConversionAdjustmentsResponse response = await client.UploadConversionAdjustmentsAsync(customerId, conversionAdjustments);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void UploadConversionAdjustments3()
        {
            Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient> mockGrpcClient = new Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient>(MockBehavior.Strict);
            UploadConversionAdjustmentsRequest request = new UploadConversionAdjustmentsRequest
            {
                CustomerId = "customerId-1772061412",
                ConversionAdjustments = { },
            };
            UploadConversionAdjustmentsResponse expectedResponse = new UploadConversionAdjustmentsResponse();
            mockGrpcClient.Setup(x => x.UploadConversionAdjustments(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConversionAdjustmentUploadServiceClient client = new ConversionAdjustmentUploadServiceClientImpl(mockGrpcClient.Object, null);
            UploadConversionAdjustmentsResponse response = client.UploadConversionAdjustments(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task UploadConversionAdjustmentsAsync3()
        {
            Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient> mockGrpcClient = new Mock<ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient>(MockBehavior.Strict);
            UploadConversionAdjustmentsRequest request = new UploadConversionAdjustmentsRequest
            {
                CustomerId = "customerId-1772061412",
                ConversionAdjustments = { },
            };
            UploadConversionAdjustmentsResponse expectedResponse = new UploadConversionAdjustmentsResponse();
            mockGrpcClient.Setup(x => x.UploadConversionAdjustmentsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UploadConversionAdjustmentsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ConversionAdjustmentUploadServiceClient client = new ConversionAdjustmentUploadServiceClientImpl(mockGrpcClient.Object, null);
            UploadConversionAdjustmentsResponse response = await client.UploadConversionAdjustmentsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

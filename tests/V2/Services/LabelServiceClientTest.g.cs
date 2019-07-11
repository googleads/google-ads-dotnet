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

namespace Google.Ads.GoogleAds.V2.Services.Tests
{
    using Google.Ads.GoogleAds.V2.Resources;
    using apis = Google.Ads.GoogleAds.V2.Services;
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
    public class GeneratedLabelServiceClientTest
    {
        [Test]
        public void GetLabel()
        {
            Mock<LabelService.LabelServiceClient> mockGrpcClient = new Mock<LabelService.LabelServiceClient>(MockBehavior.Strict);
            GetLabelRequest expectedRequest = new GetLabelRequest
            {
                ResourceName = new LabelName("[CUSTOMER]", "[LABEL]").ToString(),
            };
            Label expectedResponse = new Label
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetLabel(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new LabelName("[CUSTOMER]", "[LABEL]").ToString();
            Label response = client.GetLabel(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetLabelAsync()
        {
            Mock<LabelService.LabelServiceClient> mockGrpcClient = new Mock<LabelService.LabelServiceClient>(MockBehavior.Strict);
            GetLabelRequest expectedRequest = new GetLabelRequest
            {
                ResourceName = new LabelName("[CUSTOMER]", "[LABEL]").ToString(),
            };
            Label expectedResponse = new Label
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetLabelAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Label>(Task.FromResult(expectedResponse), null, null, null, null));
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new LabelName("[CUSTOMER]", "[LABEL]").ToString();
            Label response = await client.GetLabelAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetLabel2()
        {
            Mock<LabelService.LabelServiceClient> mockGrpcClient = new Mock<LabelService.LabelServiceClient>(MockBehavior.Strict);
            GetLabelRequest request = new GetLabelRequest
            {
                ResourceName = new LabelName("[CUSTOMER]", "[LABEL]").ToString(),
            };
            Label expectedResponse = new Label
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetLabel(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            Label response = client.GetLabel(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetLabelAsync2()
        {
            Mock<LabelService.LabelServiceClient> mockGrpcClient = new Mock<LabelService.LabelServiceClient>(MockBehavior.Strict);
            GetLabelRequest request = new GetLabelRequest
            {
                ResourceName = new LabelName("[CUSTOMER]", "[LABEL]").ToString(),
            };
            Label expectedResponse = new Label
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetLabelAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Label>(Task.FromResult(expectedResponse), null, null, null, null));
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            Label response = await client.GetLabelAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateLabels()
        {
            Mock<LabelService.LabelServiceClient> mockGrpcClient = new Mock<LabelService.LabelServiceClient>(MockBehavior.Strict);
            MutateLabelsRequest expectedRequest = new MutateLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateLabelsResponse expectedResponse = new MutateLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateLabels(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<LabelOperation> operations = new List<LabelOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateLabelsResponse response = client.MutateLabels(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateLabelsAsync()
        {
            Mock<LabelService.LabelServiceClient> mockGrpcClient = new Mock<LabelService.LabelServiceClient>(MockBehavior.Strict);
            MutateLabelsRequest expectedRequest = new MutateLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateLabelsResponse expectedResponse = new MutateLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateLabelsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<LabelOperation> operations = new List<LabelOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateLabelsResponse response = await client.MutateLabelsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateLabels2()
        {
            Mock<LabelService.LabelServiceClient> mockGrpcClient = new Mock<LabelService.LabelServiceClient>(MockBehavior.Strict);
            MutateLabelsRequest expectedRequest = new MutateLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateLabelsResponse expectedResponse = new MutateLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateLabels(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<LabelOperation> operations = new List<LabelOperation>();
            MutateLabelsResponse response = client.MutateLabels(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateLabelsAsync2()
        {
            Mock<LabelService.LabelServiceClient> mockGrpcClient = new Mock<LabelService.LabelServiceClient>(MockBehavior.Strict);
            MutateLabelsRequest expectedRequest = new MutateLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateLabelsResponse expectedResponse = new MutateLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateLabelsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<LabelOperation> operations = new List<LabelOperation>();
            MutateLabelsResponse response = await client.MutateLabelsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateLabels3()
        {
            Mock<LabelService.LabelServiceClient> mockGrpcClient = new Mock<LabelService.LabelServiceClient>(MockBehavior.Strict);
            MutateLabelsRequest request = new MutateLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateLabelsResponse expectedResponse = new MutateLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateLabels(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateLabelsResponse response = client.MutateLabels(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateLabelsAsync3()
        {
            Mock<LabelService.LabelServiceClient> mockGrpcClient = new Mock<LabelService.LabelServiceClient>(MockBehavior.Strict);
            MutateLabelsRequest request = new MutateLabelsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateLabelsResponse expectedResponse = new MutateLabelsResponse();
            mockGrpcClient.Setup(x => x.MutateLabelsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateLabelsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateLabelsResponse response = await client.MutateLabelsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

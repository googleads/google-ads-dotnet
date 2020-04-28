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

namespace Google.Ads.GoogleAds.V3.Services.Tests
{
    using Google.Ads.GoogleAds.V3.Resources;
    using apis = Google.Ads.GoogleAds.V3.Services;
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
    public class GeneratedConversionActionServiceClientTest
    {
        [Test]
        public void GetConversionAction()
        {
            Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new Mock<ConversionActionService.ConversionActionServiceClient>(MockBehavior.Strict);
            GetConversionActionRequest expectedRequest = new GetConversionActionRequest
            {
                ResourceName = new ConversionActionName("[CUSTOMER]", "[CONVERSION_ACTION]").ToString(),
            };
            ConversionAction expectedResponse = new ConversionAction
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetConversionAction(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ConversionActionName("[CUSTOMER]", "[CONVERSION_ACTION]").ToString();
            ConversionAction response = client.GetConversionAction(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetConversionActionAsync()
        {
            Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new Mock<ConversionActionService.ConversionActionServiceClient>(MockBehavior.Strict);
            GetConversionActionRequest expectedRequest = new GetConversionActionRequest
            {
                ResourceName = new ConversionActionName("[CUSTOMER]", "[CONVERSION_ACTION]").ToString(),
            };
            ConversionAction expectedResponse = new ConversionAction
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetConversionActionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ConversionAction>(Task.FromResult(expectedResponse), null, null, null, null));
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new ConversionActionName("[CUSTOMER]", "[CONVERSION_ACTION]").ToString();
            ConversionAction response = await client.GetConversionActionAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetConversionAction2()
        {
            Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new Mock<ConversionActionService.ConversionActionServiceClient>(MockBehavior.Strict);
            GetConversionActionRequest request = new GetConversionActionRequest
            {
                ResourceName = new ConversionActionName("[CUSTOMER]", "[CONVERSION_ACTION]").ToString(),
            };
            ConversionAction expectedResponse = new ConversionAction
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetConversionAction(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            ConversionAction response = client.GetConversionAction(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetConversionActionAsync2()
        {
            Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new Mock<ConversionActionService.ConversionActionServiceClient>(MockBehavior.Strict);
            GetConversionActionRequest request = new GetConversionActionRequest
            {
                ResourceName = new ConversionActionName("[CUSTOMER]", "[CONVERSION_ACTION]").ToString(),
            };
            ConversionAction expectedResponse = new ConversionAction
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetConversionActionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ConversionAction>(Task.FromResult(expectedResponse), null, null, null, null));
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            ConversionAction response = await client.GetConversionActionAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateConversionActions()
        {
            Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new Mock<ConversionActionService.ConversionActionServiceClient>(MockBehavior.Strict);
            MutateConversionActionsRequest expectedRequest = new MutateConversionActionsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateConversionActionsResponse expectedResponse = new MutateConversionActionsResponse();
            mockGrpcClient.Setup(x => x.MutateConversionActions(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ConversionActionOperation> operations = new List<ConversionActionOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateConversionActionsResponse response = client.MutateConversionActions(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateConversionActionsAsync()
        {
            Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new Mock<ConversionActionService.ConversionActionServiceClient>(MockBehavior.Strict);
            MutateConversionActionsRequest expectedRequest = new MutateConversionActionsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateConversionActionsResponse expectedResponse = new MutateConversionActionsResponse();
            mockGrpcClient.Setup(x => x.MutateConversionActionsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateConversionActionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ConversionActionOperation> operations = new List<ConversionActionOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateConversionActionsResponse response = await client.MutateConversionActionsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateConversionActions2()
        {
            Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new Mock<ConversionActionService.ConversionActionServiceClient>(MockBehavior.Strict);
            MutateConversionActionsRequest expectedRequest = new MutateConversionActionsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateConversionActionsResponse expectedResponse = new MutateConversionActionsResponse();
            mockGrpcClient.Setup(x => x.MutateConversionActions(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ConversionActionOperation> operations = new List<ConversionActionOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateConversionActionsResponse response = client.MutateConversionActions(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateConversionActionsAsync2()
        {
            Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new Mock<ConversionActionService.ConversionActionServiceClient>(MockBehavior.Strict);
            MutateConversionActionsRequest expectedRequest = new MutateConversionActionsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateConversionActionsResponse expectedResponse = new MutateConversionActionsResponse();
            mockGrpcClient.Setup(x => x.MutateConversionActionsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateConversionActionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<ConversionActionOperation> operations = new List<ConversionActionOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateConversionActionsResponse response = await client.MutateConversionActionsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateConversionActions3()
        {
            Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new Mock<ConversionActionService.ConversionActionServiceClient>(MockBehavior.Strict);
            MutateConversionActionsRequest request = new MutateConversionActionsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateConversionActionsResponse expectedResponse = new MutateConversionActionsResponse();
            mockGrpcClient.Setup(x => x.MutateConversionActions(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionActionsResponse response = client.MutateConversionActions(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateConversionActionsAsync3()
        {
            Mock<ConversionActionService.ConversionActionServiceClient> mockGrpcClient = new Mock<ConversionActionService.ConversionActionServiceClient>(MockBehavior.Strict);
            MutateConversionActionsRequest request = new MutateConversionActionsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateConversionActionsResponse expectedResponse = new MutateConversionActionsResponse();
            mockGrpcClient.Setup(x => x.MutateConversionActionsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateConversionActionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ConversionActionServiceClient client = new ConversionActionServiceClientImpl(mockGrpcClient.Object, null);
            MutateConversionActionsResponse response = await client.MutateConversionActionsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

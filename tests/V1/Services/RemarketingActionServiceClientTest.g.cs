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
    using Google.Ads.GoogleAds.V1.Resources;
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
    public class GeneratedRemarketingActionServiceClientTest
    {
        [Test]
        public void GetRemarketingAction()
        {
            Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new Mock<RemarketingActionService.RemarketingActionServiceClient>(MockBehavior.Strict);
            GetRemarketingActionRequest expectedRequest = new GetRemarketingActionRequest
            {
                ResourceName = new RemarketingActionName("[CUSTOMER]", "[REMARKETING_ACTION]").ToString(),
            };
            RemarketingAction expectedResponse = new RemarketingAction
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetRemarketingAction(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new RemarketingActionName("[CUSTOMER]", "[REMARKETING_ACTION]").ToString();
            RemarketingAction response = client.GetRemarketingAction(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetRemarketingActionAsync()
        {
            Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new Mock<RemarketingActionService.RemarketingActionServiceClient>(MockBehavior.Strict);
            GetRemarketingActionRequest expectedRequest = new GetRemarketingActionRequest
            {
                ResourceName = new RemarketingActionName("[CUSTOMER]", "[REMARKETING_ACTION]").ToString(),
            };
            RemarketingAction expectedResponse = new RemarketingAction
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetRemarketingActionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<RemarketingAction>(Task.FromResult(expectedResponse), null, null, null, null));
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new RemarketingActionName("[CUSTOMER]", "[REMARKETING_ACTION]").ToString();
            RemarketingAction response = await client.GetRemarketingActionAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetRemarketingAction2()
        {
            Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new Mock<RemarketingActionService.RemarketingActionServiceClient>(MockBehavior.Strict);
            GetRemarketingActionRequest request = new GetRemarketingActionRequest
            {
                ResourceName = new RemarketingActionName("[CUSTOMER]", "[REMARKETING_ACTION]").ToString(),
            };
            RemarketingAction expectedResponse = new RemarketingAction
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetRemarketingAction(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            RemarketingAction response = client.GetRemarketingAction(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetRemarketingActionAsync2()
        {
            Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new Mock<RemarketingActionService.RemarketingActionServiceClient>(MockBehavior.Strict);
            GetRemarketingActionRequest request = new GetRemarketingActionRequest
            {
                ResourceName = new RemarketingActionName("[CUSTOMER]", "[REMARKETING_ACTION]").ToString(),
            };
            RemarketingAction expectedResponse = new RemarketingAction
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetRemarketingActionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<RemarketingAction>(Task.FromResult(expectedResponse), null, null, null, null));
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            RemarketingAction response = await client.GetRemarketingActionAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateRemarketingActions()
        {
            Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new Mock<RemarketingActionService.RemarketingActionServiceClient>(MockBehavior.Strict);
            MutateRemarketingActionsRequest expectedRequest = new MutateRemarketingActionsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateRemarketingActionsResponse expectedResponse = new MutateRemarketingActionsResponse();
            mockGrpcClient.Setup(x => x.MutateRemarketingActions(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<RemarketingActionOperation> operations = new List<RemarketingActionOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateRemarketingActionsResponse response = client.MutateRemarketingActions(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateRemarketingActionsAsync()
        {
            Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new Mock<RemarketingActionService.RemarketingActionServiceClient>(MockBehavior.Strict);
            MutateRemarketingActionsRequest expectedRequest = new MutateRemarketingActionsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateRemarketingActionsResponse expectedResponse = new MutateRemarketingActionsResponse();
            mockGrpcClient.Setup(x => x.MutateRemarketingActionsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateRemarketingActionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<RemarketingActionOperation> operations = new List<RemarketingActionOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateRemarketingActionsResponse response = await client.MutateRemarketingActionsAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateRemarketingActions2()
        {
            Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new Mock<RemarketingActionService.RemarketingActionServiceClient>(MockBehavior.Strict);
            MutateRemarketingActionsRequest expectedRequest = new MutateRemarketingActionsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateRemarketingActionsResponse expectedResponse = new MutateRemarketingActionsResponse();
            mockGrpcClient.Setup(x => x.MutateRemarketingActions(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<RemarketingActionOperation> operations = new List<RemarketingActionOperation>();
            MutateRemarketingActionsResponse response = client.MutateRemarketingActions(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateRemarketingActionsAsync2()
        {
            Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new Mock<RemarketingActionService.RemarketingActionServiceClient>(MockBehavior.Strict);
            MutateRemarketingActionsRequest expectedRequest = new MutateRemarketingActionsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateRemarketingActionsResponse expectedResponse = new MutateRemarketingActionsResponse();
            mockGrpcClient.Setup(x => x.MutateRemarketingActionsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateRemarketingActionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<RemarketingActionOperation> operations = new List<RemarketingActionOperation>();
            MutateRemarketingActionsResponse response = await client.MutateRemarketingActionsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateRemarketingActions3()
        {
            Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new Mock<RemarketingActionService.RemarketingActionServiceClient>(MockBehavior.Strict);
            MutateRemarketingActionsRequest request = new MutateRemarketingActionsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateRemarketingActionsResponse expectedResponse = new MutateRemarketingActionsResponse();
            mockGrpcClient.Setup(x => x.MutateRemarketingActions(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            MutateRemarketingActionsResponse response = client.MutateRemarketingActions(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateRemarketingActionsAsync3()
        {
            Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new Mock<RemarketingActionService.RemarketingActionServiceClient>(MockBehavior.Strict);
            MutateRemarketingActionsRequest request = new MutateRemarketingActionsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateRemarketingActionsResponse expectedResponse = new MutateRemarketingActionsResponse();
            mockGrpcClient.Setup(x => x.MutateRemarketingActionsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateRemarketingActionsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            MutateRemarketingActionsResponse response = await client.MutateRemarketingActionsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

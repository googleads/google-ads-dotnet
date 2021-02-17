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

using gagvc = Google.Ads.GoogleAds.V6.Common;
using gagvr = Google.Ads.GoogleAds.V6.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V6.Services;

namespace Google.Ads.GoogleAds.Tests.V6.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRemarketingActionServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetRemarketingActionRequestObject()
        {
            moq::Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new moq::Mock<RemarketingActionService.RemarketingActionServiceClient>(moq::MockBehavior.Strict);
            GetRemarketingActionRequest request = new GetRemarketingActionRequest
            {
                ResourceNameAsRemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
            };
            gagvr::RemarketingAction expectedResponse = new gagvr::RemarketingAction
            {
                ResourceNameAsRemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
                TagSnippets =
                {
                    new gagvc::TagSnippet(),
                },
                Id = -6774108720365892680L,
                RemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetRemarketingAction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::RemarketingAction response = client.GetRemarketingAction(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetRemarketingActionRequestObjectAsync()
        {
            moq::Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new moq::Mock<RemarketingActionService.RemarketingActionServiceClient>(moq::MockBehavior.Strict);
            GetRemarketingActionRequest request = new GetRemarketingActionRequest
            {
                ResourceNameAsRemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
            };
            gagvr::RemarketingAction expectedResponse = new gagvr::RemarketingAction
            {
                ResourceNameAsRemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
                TagSnippets =
                {
                    new gagvc::TagSnippet(),
                },
                Id = -6774108720365892680L,
                RemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetRemarketingActionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::RemarketingAction>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::RemarketingAction responseCallSettings = await client.GetRemarketingActionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::RemarketingAction responseCancellationToken = await client.GetRemarketingActionAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetRemarketingAction()
        {
            moq::Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new moq::Mock<RemarketingActionService.RemarketingActionServiceClient>(moq::MockBehavior.Strict);
            GetRemarketingActionRequest request = new GetRemarketingActionRequest
            {
                ResourceNameAsRemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
            };
            gagvr::RemarketingAction expectedResponse = new gagvr::RemarketingAction
            {
                ResourceNameAsRemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
                TagSnippets =
                {
                    new gagvc::TagSnippet(),
                },
                Id = -6774108720365892680L,
                RemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetRemarketingAction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::RemarketingAction response = client.GetRemarketingAction(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetRemarketingActionAsync()
        {
            moq::Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new moq::Mock<RemarketingActionService.RemarketingActionServiceClient>(moq::MockBehavior.Strict);
            GetRemarketingActionRequest request = new GetRemarketingActionRequest
            {
                ResourceNameAsRemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
            };
            gagvr::RemarketingAction expectedResponse = new gagvr::RemarketingAction
            {
                ResourceNameAsRemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
                TagSnippets =
                {
                    new gagvc::TagSnippet(),
                },
                Id = -6774108720365892680L,
                RemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetRemarketingActionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::RemarketingAction>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::RemarketingAction responseCallSettings = await client.GetRemarketingActionAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::RemarketingAction responseCancellationToken = await client.GetRemarketingActionAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetRemarketingActionResourceNames()
        {
            moq::Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new moq::Mock<RemarketingActionService.RemarketingActionServiceClient>(moq::MockBehavior.Strict);
            GetRemarketingActionRequest request = new GetRemarketingActionRequest
            {
                ResourceNameAsRemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
            };
            gagvr::RemarketingAction expectedResponse = new gagvr::RemarketingAction
            {
                ResourceNameAsRemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
                TagSnippets =
                {
                    new gagvc::TagSnippet(),
                },
                Id = -6774108720365892680L,
                RemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetRemarketingAction(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::RemarketingAction response = client.GetRemarketingAction(request.ResourceNameAsRemarketingActionName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetRemarketingActionResourceNamesAsync()
        {
            moq::Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new moq::Mock<RemarketingActionService.RemarketingActionServiceClient>(moq::MockBehavior.Strict);
            GetRemarketingActionRequest request = new GetRemarketingActionRequest
            {
                ResourceNameAsRemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
            };
            gagvr::RemarketingAction expectedResponse = new gagvr::RemarketingAction
            {
                ResourceNameAsRemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
                TagSnippets =
                {
                    new gagvc::TagSnippet(),
                },
                Id = -6774108720365892680L,
                RemarketingActionName = gagvr::RemarketingActionName.FromCustomerRemarketingAction("[CUSTOMER_ID]", "[REMARKETING_ACTION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetRemarketingActionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::RemarketingAction>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::RemarketingAction responseCallSettings = await client.GetRemarketingActionAsync(request.ResourceNameAsRemarketingActionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::RemarketingAction responseCancellationToken = await client.GetRemarketingActionAsync(request.ResourceNameAsRemarketingActionName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateRemarketingActionsRequestObject()
        {
            moq::Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new moq::Mock<RemarketingActionService.RemarketingActionServiceClient>(moq::MockBehavior.Strict);
            MutateRemarketingActionsRequest request = new MutateRemarketingActionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new RemarketingActionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateRemarketingActionsResponse expectedResponse = new MutateRemarketingActionsResponse
            {
                Results =
                {
                    new MutateRemarketingActionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateRemarketingActions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            MutateRemarketingActionsResponse response = client.MutateRemarketingActions(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateRemarketingActionsRequestObjectAsync()
        {
            moq::Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new moq::Mock<RemarketingActionService.RemarketingActionServiceClient>(moq::MockBehavior.Strict);
            MutateRemarketingActionsRequest request = new MutateRemarketingActionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new RemarketingActionOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateRemarketingActionsResponse expectedResponse = new MutateRemarketingActionsResponse
            {
                Results =
                {
                    new MutateRemarketingActionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateRemarketingActionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateRemarketingActionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            MutateRemarketingActionsResponse responseCallSettings = await client.MutateRemarketingActionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateRemarketingActionsResponse responseCancellationToken = await client.MutateRemarketingActionsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateRemarketingActions()
        {
            moq::Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new moq::Mock<RemarketingActionService.RemarketingActionServiceClient>(moq::MockBehavior.Strict);
            MutateRemarketingActionsRequest request = new MutateRemarketingActionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new RemarketingActionOperation(),
                },
            };
            MutateRemarketingActionsResponse expectedResponse = new MutateRemarketingActionsResponse
            {
                Results =
                {
                    new MutateRemarketingActionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateRemarketingActions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            MutateRemarketingActionsResponse response = client.MutateRemarketingActions(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateRemarketingActionsAsync()
        {
            moq::Mock<RemarketingActionService.RemarketingActionServiceClient> mockGrpcClient = new moq::Mock<RemarketingActionService.RemarketingActionServiceClient>(moq::MockBehavior.Strict);
            MutateRemarketingActionsRequest request = new MutateRemarketingActionsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new RemarketingActionOperation(),
                },
            };
            MutateRemarketingActionsResponse expectedResponse = new MutateRemarketingActionsResponse
            {
                Results =
                {
                    new MutateRemarketingActionResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateRemarketingActionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateRemarketingActionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RemarketingActionServiceClient client = new RemarketingActionServiceClientImpl(mockGrpcClient.Object, null);
            MutateRemarketingActionsResponse responseCallSettings = await client.MutateRemarketingActionsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateRemarketingActionsResponse responseCancellationToken = await client.MutateRemarketingActionsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

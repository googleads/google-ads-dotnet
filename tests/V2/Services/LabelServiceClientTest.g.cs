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

using gagvc = Google.Ads.GoogleAds.V2.Common;
using gagve = Google.Ads.GoogleAds.V2.Enums;
using gagvr = Google.Ads.GoogleAds.V2.Resources;
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
    public sealed class GeneratedLabelServiceClientTest
    {
        [Test]
        public void GetLabelRequestObject()
        {
            moq::Mock<LabelService.LabelServiceClient> mockGrpcClient = new moq::Mock<LabelService.LabelServiceClient>(moq::MockBehavior.Strict);
            GetLabelRequest request = new GetLabelRequest
            {
                ResourceNameAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            gagvr::Label expectedResponse = new gagvr::Label
            {
                ResourceNameAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
                Id = -6774108720365892680L,
                LabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
                Status = gagve::LabelStatusEnum.Types.LabelStatus.Enabled,
                TextLabel = new gagvc::TextLabel(),
            };
            mockGrpcClient.Setup(x => x.GetLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Label response = client.GetLabel(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetLabelRequestObjectAsync()
        {
            moq::Mock<LabelService.LabelServiceClient> mockGrpcClient = new moq::Mock<LabelService.LabelServiceClient>(moq::MockBehavior.Strict);
            GetLabelRequest request = new GetLabelRequest
            {
                ResourceNameAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            gagvr::Label expectedResponse = new gagvr::Label
            {
                ResourceNameAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
                Id = -6774108720365892680L,
                LabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
                Status = gagve::LabelStatusEnum.Types.LabelStatus.Enabled,
                TextLabel = new gagvc::TextLabel(),
            };
            mockGrpcClient.Setup(x => x.GetLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Label>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Label responseCallSettings = await client.GetLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Label responseCancellationToken = await client.GetLabelAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetLabel()
        {
            moq::Mock<LabelService.LabelServiceClient> mockGrpcClient = new moq::Mock<LabelService.LabelServiceClient>(moq::MockBehavior.Strict);
            GetLabelRequest request = new GetLabelRequest
            {
                ResourceNameAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            gagvr::Label expectedResponse = new gagvr::Label
            {
                ResourceNameAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
                Id = -6774108720365892680L,
                LabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
                Status = gagve::LabelStatusEnum.Types.LabelStatus.Enabled,
                TextLabel = new gagvc::TextLabel(),
            };
            mockGrpcClient.Setup(x => x.GetLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Label response = client.GetLabel(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetLabelAsync()
        {
            moq::Mock<LabelService.LabelServiceClient> mockGrpcClient = new moq::Mock<LabelService.LabelServiceClient>(moq::MockBehavior.Strict);
            GetLabelRequest request = new GetLabelRequest
            {
                ResourceNameAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            gagvr::Label expectedResponse = new gagvr::Label
            {
                ResourceNameAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
                Id = -6774108720365892680L,
                LabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
                Status = gagve::LabelStatusEnum.Types.LabelStatus.Enabled,
                TextLabel = new gagvc::TextLabel(),
            };
            mockGrpcClient.Setup(x => x.GetLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Label>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Label responseCallSettings = await client.GetLabelAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Label responseCancellationToken = await client.GetLabelAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetLabelResourceNames()
        {
            moq::Mock<LabelService.LabelServiceClient> mockGrpcClient = new moq::Mock<LabelService.LabelServiceClient>(moq::MockBehavior.Strict);
            GetLabelRequest request = new GetLabelRequest
            {
                ResourceNameAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            gagvr::Label expectedResponse = new gagvr::Label
            {
                ResourceNameAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
                Id = -6774108720365892680L,
                LabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
                Status = gagve::LabelStatusEnum.Types.LabelStatus.Enabled,
                TextLabel = new gagvc::TextLabel(),
            };
            mockGrpcClient.Setup(x => x.GetLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Label response = client.GetLabel(request.ResourceNameAsLabelName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetLabelResourceNamesAsync()
        {
            moq::Mock<LabelService.LabelServiceClient> mockGrpcClient = new moq::Mock<LabelService.LabelServiceClient>(moq::MockBehavior.Strict);
            GetLabelRequest request = new GetLabelRequest
            {
                ResourceNameAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            gagvr::Label expectedResponse = new gagvr::Label
            {
                ResourceNameAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
                Id = -6774108720365892680L,
                LabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
                Status = gagve::LabelStatusEnum.Types.LabelStatus.Enabled,
                TextLabel = new gagvc::TextLabel(),
            };
            mockGrpcClient.Setup(x => x.GetLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::Label>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::Label responseCallSettings = await client.GetLabelAsync(request.ResourceNameAsLabelName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::Label responseCancellationToken = await client.GetLabelAsync(request.ResourceNameAsLabelName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateLabelsRequestObject()
        {
            moq::Mock<LabelService.LabelServiceClient> mockGrpcClient = new moq::Mock<LabelService.LabelServiceClient>(moq::MockBehavior.Strict);
            MutateLabelsRequest request = new MutateLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new LabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateLabelsResponse expectedResponse = new MutateLabelsResponse
            {
                Results =
                {
                    new MutateLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateLabelsResponse response = client.MutateLabels(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateLabelsRequestObjectAsync()
        {
            moq::Mock<LabelService.LabelServiceClient> mockGrpcClient = new moq::Mock<LabelService.LabelServiceClient>(moq::MockBehavior.Strict);
            MutateLabelsRequest request = new MutateLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new LabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateLabelsResponse expectedResponse = new MutateLabelsResponse
            {
                Results =
                {
                    new MutateLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateLabelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateLabelsResponse responseCallSettings = await client.MutateLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateLabelsResponse responseCancellationToken = await client.MutateLabelsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateLabels()
        {
            moq::Mock<LabelService.LabelServiceClient> mockGrpcClient = new moq::Mock<LabelService.LabelServiceClient>(moq::MockBehavior.Strict);
            MutateLabelsRequest request = new MutateLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new LabelOperation(),
                },
            };
            MutateLabelsResponse expectedResponse = new MutateLabelsResponse
            {
                Results =
                {
                    new MutateLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateLabelsResponse response = client.MutateLabels(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateLabelsAsync()
        {
            moq::Mock<LabelService.LabelServiceClient> mockGrpcClient = new moq::Mock<LabelService.LabelServiceClient>(moq::MockBehavior.Strict);
            MutateLabelsRequest request = new MutateLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new LabelOperation(),
                },
            };
            MutateLabelsResponse expectedResponse = new MutateLabelsResponse
            {
                Results =
                {
                    new MutateLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateLabelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LabelServiceClient client = new LabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateLabelsResponse responseCallSettings = await client.MutateLabelsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateLabelsResponse responseCancellationToken = await client.MutateLabelsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

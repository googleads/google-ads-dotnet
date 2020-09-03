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

using gagvr = Google.Ads.GoogleAds.V5.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V5.Services;

namespace Google.Ads.GoogleAds.Tests.V5.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdGroupCriterionLabelServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAdGroupCriterionLabelRequestObject()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionLabelRequest request = new GetAdGroupCriterionLabelRequest
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]"),
            };
            gagvr::AdGroupCriterionLabel expectedResponse = new gagvr::AdGroupCriterionLabel
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER]", "[AD_GROUP_CRITERION]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionLabel response = client.GetAdGroupCriterionLabel(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupCriterionLabelRequestObjectAsync()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionLabelRequest request = new GetAdGroupCriterionLabelRequest
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]"),
            };
            gagvr::AdGroupCriterionLabel expectedResponse = new gagvr::AdGroupCriterionLabel
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER]", "[AD_GROUP_CRITERION]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupCriterionLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionLabel responseCallSettings = await client.GetAdGroupCriterionLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupCriterionLabel responseCancellationToken = await client.GetAdGroupCriterionLabelAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupCriterionLabel()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionLabelRequest request = new GetAdGroupCriterionLabelRequest
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]"),
            };
            gagvr::AdGroupCriterionLabel expectedResponse = new gagvr::AdGroupCriterionLabel
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER]", "[AD_GROUP_CRITERION]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionLabel response = client.GetAdGroupCriterionLabel(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupCriterionLabelAsync()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionLabelRequest request = new GetAdGroupCriterionLabelRequest
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]"),
            };
            gagvr::AdGroupCriterionLabel expectedResponse = new gagvr::AdGroupCriterionLabel
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER]", "[AD_GROUP_CRITERION]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupCriterionLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionLabel responseCallSettings = await client.GetAdGroupCriterionLabelAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupCriterionLabel responseCancellationToken = await client.GetAdGroupCriterionLabelAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupCriterionLabelResourceNames()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionLabelRequest request = new GetAdGroupCriterionLabelRequest
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]"),
            };
            gagvr::AdGroupCriterionLabel expectedResponse = new gagvr::AdGroupCriterionLabel
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER]", "[AD_GROUP_CRITERION]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionLabel response = client.GetAdGroupCriterionLabel(request.ResourceNameAsAdGroupCriterionLabelName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupCriterionLabelResourceNamesAsync()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupCriterionLabelRequest request = new GetAdGroupCriterionLabelRequest
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]"),
            };
            gagvr::AdGroupCriterionLabel expectedResponse = new gagvr::AdGroupCriterionLabel
            {
                ResourceNameAsAdGroupCriterionLabelName = gagvr::AdGroupCriterionLabelName.FromCustomerAdGroupCriterionLabel("[CUSTOMER]", "[AD_GROUP_CRITERION_LABEL]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER]", "[AD_GROUP_CRITERION]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupCriterionLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupCriterionLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupCriterionLabel responseCallSettings = await client.GetAdGroupCriterionLabelAsync(request.ResourceNameAsAdGroupCriterionLabelName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupCriterionLabel responseCancellationToken = await client.GetAdGroupCriterionLabelAsync(request.ResourceNameAsAdGroupCriterionLabelName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupCriterionLabelsRequestObject()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriterionLabelsRequest request = new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateAdGroupCriterionLabelsResponse expectedResponse = new MutateAdGroupCriterionLabelsResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriterionLabelsResponse response = client.MutateAdGroupCriterionLabels(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupCriterionLabelsRequestObjectAsync()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriterionLabelsRequest request = new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateAdGroupCriterionLabelsResponse expectedResponse = new MutateAdGroupCriterionLabelsResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupCriterionLabelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriterionLabelsResponse responseCallSettings = await client.MutateAdGroupCriterionLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupCriterionLabelsResponse responseCancellationToken = await client.MutateAdGroupCriterionLabelsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupCriterionLabels()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriterionLabelsRequest request = new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionLabelOperation(),
                },
            };
            MutateAdGroupCriterionLabelsResponse expectedResponse = new MutateAdGroupCriterionLabelsResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriterionLabelsResponse response = client.MutateAdGroupCriterionLabels(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupCriterionLabelsAsync()
        {
            moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupCriterionLabelsRequest request = new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupCriterionLabelOperation(),
                },
            };
            MutateAdGroupCriterionLabelsResponse expectedResponse = new MutateAdGroupCriterionLabelsResponse
            {
                Results =
                {
                    new MutateAdGroupCriterionLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupCriterionLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupCriterionLabelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupCriterionLabelServiceClient client = new AdGroupCriterionLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupCriterionLabelsResponse responseCallSettings = await client.MutateAdGroupCriterionLabelsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupCriterionLabelsResponse responseCancellationToken = await client.MutateAdGroupCriterionLabelsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

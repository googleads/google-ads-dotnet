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

using gagvr = Google.Ads.GoogleAds.V3.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V3.Services;

namespace Google.Ads.GoogleAds.Tests.V3.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdGroupLabelServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAdGroupLabelRequestObject()
        {
            moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupLabelRequest request = new GetAdGroupLabelRequest
            {
                ResourceNameAsAdGroupLabelName = gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
            };
            gagvr::AdGroupLabel expectedResponse = new gagvr::AdGroupLabel
            {
                ResourceNameAsAdGroupLabelName = gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupLabel response = client.GetAdGroupLabel(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupLabelRequestObjectAsync()
        {
            moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupLabelRequest request = new GetAdGroupLabelRequest
            {
                ResourceNameAsAdGroupLabelName = gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
            };
            gagvr::AdGroupLabel expectedResponse = new gagvr::AdGroupLabel
            {
                ResourceNameAsAdGroupLabelName = gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupLabel responseCallSettings = await client.GetAdGroupLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupLabel responseCancellationToken = await client.GetAdGroupLabelAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupLabel()
        {
            moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupLabelRequest request = new GetAdGroupLabelRequest
            {
                ResourceNameAsAdGroupLabelName = gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
            };
            gagvr::AdGroupLabel expectedResponse = new gagvr::AdGroupLabel
            {
                ResourceNameAsAdGroupLabelName = gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupLabel response = client.GetAdGroupLabel(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupLabelAsync()
        {
            moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupLabelRequest request = new GetAdGroupLabelRequest
            {
                ResourceNameAsAdGroupLabelName = gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
            };
            gagvr::AdGroupLabel expectedResponse = new gagvr::AdGroupLabel
            {
                ResourceNameAsAdGroupLabelName = gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupLabel responseCallSettings = await client.GetAdGroupLabelAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupLabel responseCancellationToken = await client.GetAdGroupLabelAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupLabelResourceNames()
        {
            moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupLabelRequest request = new GetAdGroupLabelRequest
            {
                ResourceNameAsAdGroupLabelName = gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
            };
            gagvr::AdGroupLabel expectedResponse = new gagvr::AdGroupLabel
            {
                ResourceNameAsAdGroupLabelName = gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupLabel response = client.GetAdGroupLabel(request.ResourceNameAsAdGroupLabelName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupLabelResourceNamesAsync()
        {
            moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupLabelRequest request = new GetAdGroupLabelRequest
            {
                ResourceNameAsAdGroupLabelName = gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
            };
            gagvr::AdGroupLabel expectedResponse = new gagvr::AdGroupLabel
            {
                ResourceNameAsAdGroupLabelName = gagvr::AdGroupLabelName.FromCustomerAdGroupLabel("[CUSTOMER]", "[AD_GROUP_LABEL]"),
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupLabel responseCallSettings = await client.GetAdGroupLabelAsync(request.ResourceNameAsAdGroupLabelName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupLabel responseCancellationToken = await client.GetAdGroupLabelAsync(request.ResourceNameAsAdGroupLabelName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupLabelsRequestObject()
        {
            moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupLabelsRequest request = new MutateAdGroupLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateAdGroupLabelsResponse expectedResponse = new MutateAdGroupLabelsResponse
            {
                Results =
                {
                    new MutateAdGroupLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupLabelsResponse response = client.MutateAdGroupLabels(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupLabelsRequestObjectAsync()
        {
            moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupLabelsRequest request = new MutateAdGroupLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateAdGroupLabelsResponse expectedResponse = new MutateAdGroupLabelsResponse
            {
                Results =
                {
                    new MutateAdGroupLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupLabelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupLabelsResponse responseCallSettings = await client.MutateAdGroupLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupLabelsResponse responseCancellationToken = await client.MutateAdGroupLabelsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupLabels()
        {
            moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupLabelsRequest request = new MutateAdGroupLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupLabelOperation(),
                },
            };
            MutateAdGroupLabelsResponse expectedResponse = new MutateAdGroupLabelsResponse
            {
                Results =
                {
                    new MutateAdGroupLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupLabelsResponse response = client.MutateAdGroupLabels(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupLabelsAsync()
        {
            moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupLabelService.AdGroupLabelServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupLabelsRequest request = new MutateAdGroupLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupLabelOperation(),
                },
            };
            MutateAdGroupLabelsResponse expectedResponse = new MutateAdGroupLabelsResponse
            {
                Results =
                {
                    new MutateAdGroupLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupLabelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupLabelServiceClient client = new AdGroupLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupLabelsResponse responseCallSettings = await client.MutateAdGroupLabelsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupLabelsResponse responseCancellationToken = await client.MutateAdGroupLabelsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

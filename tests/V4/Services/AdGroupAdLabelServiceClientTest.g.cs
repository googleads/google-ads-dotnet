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

using gagvr = Google.Ads.GoogleAds.V4.Resources;
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
    public sealed class GeneratedAdGroupAdLabelServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAdGroupAdLabelRequestObject()
        {
            moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdLabelRequest request = new GetAdGroupAdLabelRequest
            {
                ResourceNameAsAdGroupAdLabelName = gagvr::AdGroupAdLabelName.FromCustomerAdGroupAdLabel("[CUSTOMER]", "[AD_GROUP_AD_LABEL]"),
            };
            gagvr::AdGroupAdLabel expectedResponse = new gagvr::AdGroupAdLabel
            {
                ResourceNameAsAdGroupAdLabelName = gagvr::AdGroupAdLabelName.FromCustomerAdGroupAdLabel("[CUSTOMER]", "[AD_GROUP_AD_LABEL]"),
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAdLabel response = client.GetAdGroupAdLabel(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupAdLabelRequestObjectAsync()
        {
            moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdLabelRequest request = new GetAdGroupAdLabelRequest
            {
                ResourceNameAsAdGroupAdLabelName = gagvr::AdGroupAdLabelName.FromCustomerAdGroupAdLabel("[CUSTOMER]", "[AD_GROUP_AD_LABEL]"),
            };
            gagvr::AdGroupAdLabel expectedResponse = new gagvr::AdGroupAdLabel
            {
                ResourceNameAsAdGroupAdLabelName = gagvr::AdGroupAdLabelName.FromCustomerAdGroupAdLabel("[CUSTOMER]", "[AD_GROUP_AD_LABEL]"),
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupAdLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAdLabel responseCallSettings = await client.GetAdGroupAdLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupAdLabel responseCancellationToken = await client.GetAdGroupAdLabelAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupAdLabel()
        {
            moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdLabelRequest request = new GetAdGroupAdLabelRequest
            {
                ResourceNameAsAdGroupAdLabelName = gagvr::AdGroupAdLabelName.FromCustomerAdGroupAdLabel("[CUSTOMER]", "[AD_GROUP_AD_LABEL]"),
            };
            gagvr::AdGroupAdLabel expectedResponse = new gagvr::AdGroupAdLabel
            {
                ResourceNameAsAdGroupAdLabelName = gagvr::AdGroupAdLabelName.FromCustomerAdGroupAdLabel("[CUSTOMER]", "[AD_GROUP_AD_LABEL]"),
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAdLabel response = client.GetAdGroupAdLabel(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupAdLabelAsync()
        {
            moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdLabelRequest request = new GetAdGroupAdLabelRequest
            {
                ResourceNameAsAdGroupAdLabelName = gagvr::AdGroupAdLabelName.FromCustomerAdGroupAdLabel("[CUSTOMER]", "[AD_GROUP_AD_LABEL]"),
            };
            gagvr::AdGroupAdLabel expectedResponse = new gagvr::AdGroupAdLabel
            {
                ResourceNameAsAdGroupAdLabelName = gagvr::AdGroupAdLabelName.FromCustomerAdGroupAdLabel("[CUSTOMER]", "[AD_GROUP_AD_LABEL]"),
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupAdLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAdLabel responseCallSettings = await client.GetAdGroupAdLabelAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupAdLabel responseCancellationToken = await client.GetAdGroupAdLabelAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdGroupAdLabelResourceNames()
        {
            moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdLabelRequest request = new GetAdGroupAdLabelRequest
            {
                ResourceNameAsAdGroupAdLabelName = gagvr::AdGroupAdLabelName.FromCustomerAdGroupAdLabel("[CUSTOMER]", "[AD_GROUP_AD_LABEL]"),
            };
            gagvr::AdGroupAdLabel expectedResponse = new gagvr::AdGroupAdLabel
            {
                ResourceNameAsAdGroupAdLabelName = gagvr::AdGroupAdLabelName.FromCustomerAdGroupAdLabel("[CUSTOMER]", "[AD_GROUP_AD_LABEL]"),
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdLabel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAdLabel response = client.GetAdGroupAdLabel(request.ResourceNameAsAdGroupAdLabelName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdGroupAdLabelResourceNamesAsync()
        {
            moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(moq::MockBehavior.Strict);
            GetAdGroupAdLabelRequest request = new GetAdGroupAdLabelRequest
            {
                ResourceNameAsAdGroupAdLabelName = gagvr::AdGroupAdLabelName.FromCustomerAdGroupAdLabel("[CUSTOMER]", "[AD_GROUP_AD_LABEL]"),
            };
            gagvr::AdGroupAdLabel expectedResponse = new gagvr::AdGroupAdLabel
            {
                ResourceNameAsAdGroupAdLabelName = gagvr::AdGroupAdLabelName.FromCustomerAdGroupAdLabel("[CUSTOMER]", "[AD_GROUP_AD_LABEL]"),
                AdGroupAdAsAdGroupAdName = gagvr::AdGroupAdName.FromCustomerAdGroupAd("[CUSTOMER]", "[AD_GROUP_AD]"),
                LabelAsLabelName = gagvr::LabelName.FromCustomerLabel("[CUSTOMER]", "[LABEL]"),
            };
            mockGrpcClient.Setup(x => x.GetAdGroupAdLabelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdGroupAdLabel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdGroupAdLabel responseCallSettings = await client.GetAdGroupAdLabelAsync(request.ResourceNameAsAdGroupAdLabelName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdGroupAdLabel responseCancellationToken = await client.GetAdGroupAdLabelAsync(request.ResourceNameAsAdGroupAdLabelName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupAdLabelsRequestObject()
        {
            moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupAdLabelsRequest request = new MutateAdGroupAdLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupAdLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateAdGroupAdLabelsResponse expectedResponse = new MutateAdGroupAdLabelsResponse
            {
                Results =
                {
                    new MutateAdGroupAdLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupAdLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupAdLabelsResponse response = client.MutateAdGroupAdLabels(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupAdLabelsRequestObjectAsync()
        {
            moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupAdLabelsRequest request = new MutateAdGroupAdLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupAdLabelOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateAdGroupAdLabelsResponse expectedResponse = new MutateAdGroupAdLabelsResponse
            {
                Results =
                {
                    new MutateAdGroupAdLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupAdLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupAdLabelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupAdLabelsResponse responseCallSettings = await client.MutateAdGroupAdLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupAdLabelsResponse responseCancellationToken = await client.MutateAdGroupAdLabelsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdGroupAdLabels()
        {
            moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupAdLabelsRequest request = new MutateAdGroupAdLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupAdLabelOperation(),
                },
            };
            MutateAdGroupAdLabelsResponse expectedResponse = new MutateAdGroupAdLabelsResponse
            {
                Results =
                {
                    new MutateAdGroupAdLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupAdLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupAdLabelsResponse response = client.MutateAdGroupAdLabels(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdGroupAdLabelsAsync()
        {
            moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient> mockGrpcClient = new moq::Mock<AdGroupAdLabelService.AdGroupAdLabelServiceClient>(moq::MockBehavior.Strict);
            MutateAdGroupAdLabelsRequest request = new MutateAdGroupAdLabelsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdGroupAdLabelOperation(),
                },
            };
            MutateAdGroupAdLabelsResponse expectedResponse = new MutateAdGroupAdLabelsResponse
            {
                Results =
                {
                    new MutateAdGroupAdLabelResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdGroupAdLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdGroupAdLabelsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdGroupAdLabelServiceClient client = new AdGroupAdLabelServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdGroupAdLabelsResponse responseCallSettings = await client.MutateAdGroupAdLabelsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdGroupAdLabelsResponse responseCancellationToken = await client.MutateAdGroupAdLabelsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

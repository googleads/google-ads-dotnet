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

using gagve = Google.Ads.GoogleAds.V6.Enums;
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
    public sealed class GeneratedAdParameterServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAdParameterRequestObject()
        {
            moq::Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new moq::Mock<AdParameterService.AdParameterServiceClient>(moq::MockBehavior.Strict);
            GetAdParameterRequest request = new GetAdParameterRequest
            {
                ResourceNameAsAdParameterName = gagvr::AdParameterName.FromCustomerAdGroupCriterionParameterIndex("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[PARAMETER_INDEX]"),
            };
            gagvr::AdParameter expectedResponse = new gagvr::AdParameter
            {
                ResourceNameAsAdParameterName = gagvr::AdParameterName.FromCustomerAdGroupCriterionParameterIndex("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[PARAMETER_INDEX]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                ParameterIndex = 2776974389611536835L,
                InsertionText = "insertion_text562a41ad",
            };
            mockGrpcClient.Setup(x => x.GetAdParameter(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdParameter response = client.GetAdParameter(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdParameterRequestObjectAsync()
        {
            moq::Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new moq::Mock<AdParameterService.AdParameterServiceClient>(moq::MockBehavior.Strict);
            GetAdParameterRequest request = new GetAdParameterRequest
            {
                ResourceNameAsAdParameterName = gagvr::AdParameterName.FromCustomerAdGroupCriterionParameterIndex("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[PARAMETER_INDEX]"),
            };
            gagvr::AdParameter expectedResponse = new gagvr::AdParameter
            {
                ResourceNameAsAdParameterName = gagvr::AdParameterName.FromCustomerAdGroupCriterionParameterIndex("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[PARAMETER_INDEX]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                ParameterIndex = 2776974389611536835L,
                InsertionText = "insertion_text562a41ad",
            };
            mockGrpcClient.Setup(x => x.GetAdParameterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdParameter>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdParameter responseCallSettings = await client.GetAdParameterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdParameter responseCancellationToken = await client.GetAdParameterAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdParameter()
        {
            moq::Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new moq::Mock<AdParameterService.AdParameterServiceClient>(moq::MockBehavior.Strict);
            GetAdParameterRequest request = new GetAdParameterRequest
            {
                ResourceNameAsAdParameterName = gagvr::AdParameterName.FromCustomerAdGroupCriterionParameterIndex("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[PARAMETER_INDEX]"),
            };
            gagvr::AdParameter expectedResponse = new gagvr::AdParameter
            {
                ResourceNameAsAdParameterName = gagvr::AdParameterName.FromCustomerAdGroupCriterionParameterIndex("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[PARAMETER_INDEX]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                ParameterIndex = 2776974389611536835L,
                InsertionText = "insertion_text562a41ad",
            };
            mockGrpcClient.Setup(x => x.GetAdParameter(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdParameter response = client.GetAdParameter(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdParameterAsync()
        {
            moq::Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new moq::Mock<AdParameterService.AdParameterServiceClient>(moq::MockBehavior.Strict);
            GetAdParameterRequest request = new GetAdParameterRequest
            {
                ResourceNameAsAdParameterName = gagvr::AdParameterName.FromCustomerAdGroupCriterionParameterIndex("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[PARAMETER_INDEX]"),
            };
            gagvr::AdParameter expectedResponse = new gagvr::AdParameter
            {
                ResourceNameAsAdParameterName = gagvr::AdParameterName.FromCustomerAdGroupCriterionParameterIndex("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[PARAMETER_INDEX]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                ParameterIndex = 2776974389611536835L,
                InsertionText = "insertion_text562a41ad",
            };
            mockGrpcClient.Setup(x => x.GetAdParameterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdParameter>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdParameter responseCallSettings = await client.GetAdParameterAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdParameter responseCancellationToken = await client.GetAdParameterAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAdParameterResourceNames()
        {
            moq::Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new moq::Mock<AdParameterService.AdParameterServiceClient>(moq::MockBehavior.Strict);
            GetAdParameterRequest request = new GetAdParameterRequest
            {
                ResourceNameAsAdParameterName = gagvr::AdParameterName.FromCustomerAdGroupCriterionParameterIndex("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[PARAMETER_INDEX]"),
            };
            gagvr::AdParameter expectedResponse = new gagvr::AdParameter
            {
                ResourceNameAsAdParameterName = gagvr::AdParameterName.FromCustomerAdGroupCriterionParameterIndex("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[PARAMETER_INDEX]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                ParameterIndex = 2776974389611536835L,
                InsertionText = "insertion_text562a41ad",
            };
            mockGrpcClient.Setup(x => x.GetAdParameter(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdParameter response = client.GetAdParameter(request.ResourceNameAsAdParameterName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAdParameterResourceNamesAsync()
        {
            moq::Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new moq::Mock<AdParameterService.AdParameterServiceClient>(moq::MockBehavior.Strict);
            GetAdParameterRequest request = new GetAdParameterRequest
            {
                ResourceNameAsAdParameterName = gagvr::AdParameterName.FromCustomerAdGroupCriterionParameterIndex("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[PARAMETER_INDEX]"),
            };
            gagvr::AdParameter expectedResponse = new gagvr::AdParameter
            {
                ResourceNameAsAdParameterName = gagvr::AdParameterName.FromCustomerAdGroupCriterionParameterIndex("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]", "[PARAMETER_INDEX]"),
                AdGroupCriterionAsAdGroupCriterionName = gagvr::AdGroupCriterionName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
                ParameterIndex = 2776974389611536835L,
                InsertionText = "insertion_text562a41ad",
            };
            mockGrpcClient.Setup(x => x.GetAdParameterAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AdParameter>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AdParameter responseCallSettings = await client.GetAdParameterAsync(request.ResourceNameAsAdParameterName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AdParameter responseCancellationToken = await client.GetAdParameterAsync(request.ResourceNameAsAdParameterName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdParametersRequestObject()
        {
            moq::Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new moq::Mock<AdParameterService.AdParameterServiceClient>(moq::MockBehavior.Strict);
            MutateAdParametersRequest request = new MutateAdParametersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdParameterOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdParametersResponse expectedResponse = new MutateAdParametersResponse
            {
                Results =
                {
                    new MutateAdParameterResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdParameters(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdParametersResponse response = client.MutateAdParameters(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdParametersRequestObjectAsync()
        {
            moq::Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new moq::Mock<AdParameterService.AdParameterServiceClient>(moq::MockBehavior.Strict);
            MutateAdParametersRequest request = new MutateAdParametersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdParameterOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAdParametersResponse expectedResponse = new MutateAdParametersResponse
            {
                Results =
                {
                    new MutateAdParameterResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdParametersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdParametersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdParametersResponse responseCallSettings = await client.MutateAdParametersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdParametersResponse responseCancellationToken = await client.MutateAdParametersAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateAdParameters()
        {
            moq::Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new moq::Mock<AdParameterService.AdParameterServiceClient>(moq::MockBehavior.Strict);
            MutateAdParametersRequest request = new MutateAdParametersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdParameterOperation(),
                },
            };
            MutateAdParametersResponse expectedResponse = new MutateAdParametersResponse
            {
                Results =
                {
                    new MutateAdParameterResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdParameters(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdParametersResponse response = client.MutateAdParameters(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateAdParametersAsync()
        {
            moq::Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new moq::Mock<AdParameterService.AdParameterServiceClient>(moq::MockBehavior.Strict);
            MutateAdParametersRequest request = new MutateAdParametersRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AdParameterOperation(),
                },
            };
            MutateAdParametersResponse expectedResponse = new MutateAdParametersResponse
            {
                Results =
                {
                    new MutateAdParameterResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAdParametersAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAdParametersResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdParametersResponse responseCallSettings = await client.MutateAdParametersAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAdParametersResponse responseCancellationToken = await client.MutateAdParametersAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

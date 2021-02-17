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

using gagvr = Google.Ads.GoogleAds.V6.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V6.Services;

namespace Google.Ads.GoogleAds.Tests.V6.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAgeRangeViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAgeRangeViewRequestObject()
        {
            moq::Mock<AgeRangeViewService.AgeRangeViewServiceClient> mockGrpcClient = new moq::Mock<AgeRangeViewService.AgeRangeViewServiceClient>(moq::MockBehavior.Strict);
            GetAgeRangeViewRequest request = new GetAgeRangeViewRequest
            {
                ResourceNameAsAgeRangeViewName = gagvr::AgeRangeViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AgeRangeView expectedResponse = new gagvr::AgeRangeView
            {
                ResourceNameAsAgeRangeViewName = gagvr::AgeRangeViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAgeRangeView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgeRangeViewServiceClient client = new AgeRangeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AgeRangeView response = client.GetAgeRangeView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAgeRangeViewRequestObjectAsync()
        {
            moq::Mock<AgeRangeViewService.AgeRangeViewServiceClient> mockGrpcClient = new moq::Mock<AgeRangeViewService.AgeRangeViewServiceClient>(moq::MockBehavior.Strict);
            GetAgeRangeViewRequest request = new GetAgeRangeViewRequest
            {
                ResourceNameAsAgeRangeViewName = gagvr::AgeRangeViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AgeRangeView expectedResponse = new gagvr::AgeRangeView
            {
                ResourceNameAsAgeRangeViewName = gagvr::AgeRangeViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAgeRangeViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AgeRangeView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgeRangeViewServiceClient client = new AgeRangeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AgeRangeView responseCallSettings = await client.GetAgeRangeViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AgeRangeView responseCancellationToken = await client.GetAgeRangeViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAgeRangeView()
        {
            moq::Mock<AgeRangeViewService.AgeRangeViewServiceClient> mockGrpcClient = new moq::Mock<AgeRangeViewService.AgeRangeViewServiceClient>(moq::MockBehavior.Strict);
            GetAgeRangeViewRequest request = new GetAgeRangeViewRequest
            {
                ResourceNameAsAgeRangeViewName = gagvr::AgeRangeViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AgeRangeView expectedResponse = new gagvr::AgeRangeView
            {
                ResourceNameAsAgeRangeViewName = gagvr::AgeRangeViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAgeRangeView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgeRangeViewServiceClient client = new AgeRangeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AgeRangeView response = client.GetAgeRangeView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAgeRangeViewAsync()
        {
            moq::Mock<AgeRangeViewService.AgeRangeViewServiceClient> mockGrpcClient = new moq::Mock<AgeRangeViewService.AgeRangeViewServiceClient>(moq::MockBehavior.Strict);
            GetAgeRangeViewRequest request = new GetAgeRangeViewRequest
            {
                ResourceNameAsAgeRangeViewName = gagvr::AgeRangeViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AgeRangeView expectedResponse = new gagvr::AgeRangeView
            {
                ResourceNameAsAgeRangeViewName = gagvr::AgeRangeViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAgeRangeViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AgeRangeView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgeRangeViewServiceClient client = new AgeRangeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AgeRangeView responseCallSettings = await client.GetAgeRangeViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AgeRangeView responseCancellationToken = await client.GetAgeRangeViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAgeRangeViewResourceNames()
        {
            moq::Mock<AgeRangeViewService.AgeRangeViewServiceClient> mockGrpcClient = new moq::Mock<AgeRangeViewService.AgeRangeViewServiceClient>(moq::MockBehavior.Strict);
            GetAgeRangeViewRequest request = new GetAgeRangeViewRequest
            {
                ResourceNameAsAgeRangeViewName = gagvr::AgeRangeViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AgeRangeView expectedResponse = new gagvr::AgeRangeView
            {
                ResourceNameAsAgeRangeViewName = gagvr::AgeRangeViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAgeRangeView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AgeRangeViewServiceClient client = new AgeRangeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AgeRangeView response = client.GetAgeRangeView(request.ResourceNameAsAgeRangeViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAgeRangeViewResourceNamesAsync()
        {
            moq::Mock<AgeRangeViewService.AgeRangeViewServiceClient> mockGrpcClient = new moq::Mock<AgeRangeViewService.AgeRangeViewServiceClient>(moq::MockBehavior.Strict);
            GetAgeRangeViewRequest request = new GetAgeRangeViewRequest
            {
                ResourceNameAsAgeRangeViewName = gagvr::AgeRangeViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::AgeRangeView expectedResponse = new gagvr::AgeRangeView
            {
                ResourceNameAsAgeRangeViewName = gagvr::AgeRangeViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetAgeRangeViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AgeRangeView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AgeRangeViewServiceClient client = new AgeRangeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AgeRangeView responseCallSettings = await client.GetAgeRangeViewAsync(request.ResourceNameAsAgeRangeViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AgeRangeView responseCancellationToken = await client.GetAgeRangeViewAsync(request.ResourceNameAsAgeRangeViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

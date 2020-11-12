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
    public sealed class GeneratedParentalStatusViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetParentalStatusViewRequestObject()
        {
            moq::Mock<ParentalStatusViewService.ParentalStatusViewServiceClient> mockGrpcClient = new moq::Mock<ParentalStatusViewService.ParentalStatusViewServiceClient>(moq::MockBehavior.Strict);
            GetParentalStatusViewRequest request = new GetParentalStatusViewRequest
            {
                ResourceNameAsParentalStatusViewName = gagvr::ParentalStatusViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::ParentalStatusView expectedResponse = new gagvr::ParentalStatusView
            {
                ResourceNameAsParentalStatusViewName = gagvr::ParentalStatusViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetParentalStatusView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParentalStatusViewServiceClient client = new ParentalStatusViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ParentalStatusView response = client.GetParentalStatusView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetParentalStatusViewRequestObjectAsync()
        {
            moq::Mock<ParentalStatusViewService.ParentalStatusViewServiceClient> mockGrpcClient = new moq::Mock<ParentalStatusViewService.ParentalStatusViewServiceClient>(moq::MockBehavior.Strict);
            GetParentalStatusViewRequest request = new GetParentalStatusViewRequest
            {
                ResourceNameAsParentalStatusViewName = gagvr::ParentalStatusViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::ParentalStatusView expectedResponse = new gagvr::ParentalStatusView
            {
                ResourceNameAsParentalStatusViewName = gagvr::ParentalStatusViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetParentalStatusViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ParentalStatusView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParentalStatusViewServiceClient client = new ParentalStatusViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ParentalStatusView responseCallSettings = await client.GetParentalStatusViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ParentalStatusView responseCancellationToken = await client.GetParentalStatusViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetParentalStatusView()
        {
            moq::Mock<ParentalStatusViewService.ParentalStatusViewServiceClient> mockGrpcClient = new moq::Mock<ParentalStatusViewService.ParentalStatusViewServiceClient>(moq::MockBehavior.Strict);
            GetParentalStatusViewRequest request = new GetParentalStatusViewRequest
            {
                ResourceNameAsParentalStatusViewName = gagvr::ParentalStatusViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::ParentalStatusView expectedResponse = new gagvr::ParentalStatusView
            {
                ResourceNameAsParentalStatusViewName = gagvr::ParentalStatusViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetParentalStatusView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParentalStatusViewServiceClient client = new ParentalStatusViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ParentalStatusView response = client.GetParentalStatusView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetParentalStatusViewAsync()
        {
            moq::Mock<ParentalStatusViewService.ParentalStatusViewServiceClient> mockGrpcClient = new moq::Mock<ParentalStatusViewService.ParentalStatusViewServiceClient>(moq::MockBehavior.Strict);
            GetParentalStatusViewRequest request = new GetParentalStatusViewRequest
            {
                ResourceNameAsParentalStatusViewName = gagvr::ParentalStatusViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::ParentalStatusView expectedResponse = new gagvr::ParentalStatusView
            {
                ResourceNameAsParentalStatusViewName = gagvr::ParentalStatusViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetParentalStatusViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ParentalStatusView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParentalStatusViewServiceClient client = new ParentalStatusViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ParentalStatusView responseCallSettings = await client.GetParentalStatusViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ParentalStatusView responseCancellationToken = await client.GetParentalStatusViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetParentalStatusViewResourceNames()
        {
            moq::Mock<ParentalStatusViewService.ParentalStatusViewServiceClient> mockGrpcClient = new moq::Mock<ParentalStatusViewService.ParentalStatusViewServiceClient>(moq::MockBehavior.Strict);
            GetParentalStatusViewRequest request = new GetParentalStatusViewRequest
            {
                ResourceNameAsParentalStatusViewName = gagvr::ParentalStatusViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::ParentalStatusView expectedResponse = new gagvr::ParentalStatusView
            {
                ResourceNameAsParentalStatusViewName = gagvr::ParentalStatusViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetParentalStatusView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ParentalStatusViewServiceClient client = new ParentalStatusViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ParentalStatusView response = client.GetParentalStatusView(request.ResourceNameAsParentalStatusViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetParentalStatusViewResourceNamesAsync()
        {
            moq::Mock<ParentalStatusViewService.ParentalStatusViewServiceClient> mockGrpcClient = new moq::Mock<ParentalStatusViewService.ParentalStatusViewServiceClient>(moq::MockBehavior.Strict);
            GetParentalStatusViewRequest request = new GetParentalStatusViewRequest
            {
                ResourceNameAsParentalStatusViewName = gagvr::ParentalStatusViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::ParentalStatusView expectedResponse = new gagvr::ParentalStatusView
            {
                ResourceNameAsParentalStatusViewName = gagvr::ParentalStatusViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetParentalStatusViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ParentalStatusView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ParentalStatusViewServiceClient client = new ParentalStatusViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ParentalStatusView responseCallSettings = await client.GetParentalStatusViewAsync(request.ResourceNameAsParentalStatusViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ParentalStatusView responseCancellationToken = await client.GetParentalStatusViewAsync(request.ResourceNameAsParentalStatusViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

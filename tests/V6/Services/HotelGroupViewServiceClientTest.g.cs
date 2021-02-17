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
    public sealed class GeneratedHotelGroupViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetHotelGroupViewRequestObject()
        {
            moq::Mock<HotelGroupViewService.HotelGroupViewServiceClient> mockGrpcClient = new moq::Mock<HotelGroupViewService.HotelGroupViewServiceClient>(moq::MockBehavior.Strict);
            GetHotelGroupViewRequest request = new GetHotelGroupViewRequest
            {
                ResourceNameAsHotelGroupViewName = gagvr::HotelGroupViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::HotelGroupView expectedResponse = new gagvr::HotelGroupView
            {
                ResourceNameAsHotelGroupViewName = gagvr::HotelGroupViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetHotelGroupView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HotelGroupViewServiceClient client = new HotelGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::HotelGroupView response = client.GetHotelGroupView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetHotelGroupViewRequestObjectAsync()
        {
            moq::Mock<HotelGroupViewService.HotelGroupViewServiceClient> mockGrpcClient = new moq::Mock<HotelGroupViewService.HotelGroupViewServiceClient>(moq::MockBehavior.Strict);
            GetHotelGroupViewRequest request = new GetHotelGroupViewRequest
            {
                ResourceNameAsHotelGroupViewName = gagvr::HotelGroupViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::HotelGroupView expectedResponse = new gagvr::HotelGroupView
            {
                ResourceNameAsHotelGroupViewName = gagvr::HotelGroupViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetHotelGroupViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::HotelGroupView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HotelGroupViewServiceClient client = new HotelGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::HotelGroupView responseCallSettings = await client.GetHotelGroupViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::HotelGroupView responseCancellationToken = await client.GetHotelGroupViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetHotelGroupView()
        {
            moq::Mock<HotelGroupViewService.HotelGroupViewServiceClient> mockGrpcClient = new moq::Mock<HotelGroupViewService.HotelGroupViewServiceClient>(moq::MockBehavior.Strict);
            GetHotelGroupViewRequest request = new GetHotelGroupViewRequest
            {
                ResourceNameAsHotelGroupViewName = gagvr::HotelGroupViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::HotelGroupView expectedResponse = new gagvr::HotelGroupView
            {
                ResourceNameAsHotelGroupViewName = gagvr::HotelGroupViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetHotelGroupView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HotelGroupViewServiceClient client = new HotelGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::HotelGroupView response = client.GetHotelGroupView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetHotelGroupViewAsync()
        {
            moq::Mock<HotelGroupViewService.HotelGroupViewServiceClient> mockGrpcClient = new moq::Mock<HotelGroupViewService.HotelGroupViewServiceClient>(moq::MockBehavior.Strict);
            GetHotelGroupViewRequest request = new GetHotelGroupViewRequest
            {
                ResourceNameAsHotelGroupViewName = gagvr::HotelGroupViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::HotelGroupView expectedResponse = new gagvr::HotelGroupView
            {
                ResourceNameAsHotelGroupViewName = gagvr::HotelGroupViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetHotelGroupViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::HotelGroupView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HotelGroupViewServiceClient client = new HotelGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::HotelGroupView responseCallSettings = await client.GetHotelGroupViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::HotelGroupView responseCancellationToken = await client.GetHotelGroupViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetHotelGroupViewResourceNames()
        {
            moq::Mock<HotelGroupViewService.HotelGroupViewServiceClient> mockGrpcClient = new moq::Mock<HotelGroupViewService.HotelGroupViewServiceClient>(moq::MockBehavior.Strict);
            GetHotelGroupViewRequest request = new GetHotelGroupViewRequest
            {
                ResourceNameAsHotelGroupViewName = gagvr::HotelGroupViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::HotelGroupView expectedResponse = new gagvr::HotelGroupView
            {
                ResourceNameAsHotelGroupViewName = gagvr::HotelGroupViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetHotelGroupView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            HotelGroupViewServiceClient client = new HotelGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::HotelGroupView response = client.GetHotelGroupView(request.ResourceNameAsHotelGroupViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetHotelGroupViewResourceNamesAsync()
        {
            moq::Mock<HotelGroupViewService.HotelGroupViewServiceClient> mockGrpcClient = new moq::Mock<HotelGroupViewService.HotelGroupViewServiceClient>(moq::MockBehavior.Strict);
            GetHotelGroupViewRequest request = new GetHotelGroupViewRequest
            {
                ResourceNameAsHotelGroupViewName = gagvr::HotelGroupViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::HotelGroupView expectedResponse = new gagvr::HotelGroupView
            {
                ResourceNameAsHotelGroupViewName = gagvr::HotelGroupViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetHotelGroupViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::HotelGroupView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            HotelGroupViewServiceClient client = new HotelGroupViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::HotelGroupView responseCallSettings = await client.GetHotelGroupViewAsync(request.ResourceNameAsHotelGroupViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::HotelGroupView responseCancellationToken = await client.GetHotelGroupViewAsync(request.ResourceNameAsHotelGroupViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

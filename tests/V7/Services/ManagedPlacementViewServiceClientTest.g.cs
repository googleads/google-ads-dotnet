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

using gagvr = Google.Ads.GoogleAds.V7.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V7.Services;

namespace Google.Ads.GoogleAds.Tests.V7.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedManagedPlacementViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetManagedPlacementViewRequestObject()
        {
            moq::Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient> mockGrpcClient = new moq::Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetManagedPlacementViewRequest request = new GetManagedPlacementViewRequest
            {
                ResourceNameAsManagedPlacementViewName = gagvr::ManagedPlacementViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::ManagedPlacementView expectedResponse = new gagvr::ManagedPlacementView
            {
                ResourceNameAsManagedPlacementViewName = gagvr::ManagedPlacementViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetManagedPlacementView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ManagedPlacementViewServiceClient client = new ManagedPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ManagedPlacementView response = client.GetManagedPlacementView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetManagedPlacementViewRequestObjectAsync()
        {
            moq::Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient> mockGrpcClient = new moq::Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetManagedPlacementViewRequest request = new GetManagedPlacementViewRequest
            {
                ResourceNameAsManagedPlacementViewName = gagvr::ManagedPlacementViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::ManagedPlacementView expectedResponse = new gagvr::ManagedPlacementView
            {
                ResourceNameAsManagedPlacementViewName = gagvr::ManagedPlacementViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetManagedPlacementViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ManagedPlacementView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ManagedPlacementViewServiceClient client = new ManagedPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ManagedPlacementView responseCallSettings = await client.GetManagedPlacementViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ManagedPlacementView responseCancellationToken = await client.GetManagedPlacementViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetManagedPlacementView()
        {
            moq::Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient> mockGrpcClient = new moq::Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetManagedPlacementViewRequest request = new GetManagedPlacementViewRequest
            {
                ResourceNameAsManagedPlacementViewName = gagvr::ManagedPlacementViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::ManagedPlacementView expectedResponse = new gagvr::ManagedPlacementView
            {
                ResourceNameAsManagedPlacementViewName = gagvr::ManagedPlacementViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetManagedPlacementView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ManagedPlacementViewServiceClient client = new ManagedPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ManagedPlacementView response = client.GetManagedPlacementView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetManagedPlacementViewAsync()
        {
            moq::Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient> mockGrpcClient = new moq::Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetManagedPlacementViewRequest request = new GetManagedPlacementViewRequest
            {
                ResourceNameAsManagedPlacementViewName = gagvr::ManagedPlacementViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::ManagedPlacementView expectedResponse = new gagvr::ManagedPlacementView
            {
                ResourceNameAsManagedPlacementViewName = gagvr::ManagedPlacementViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetManagedPlacementViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ManagedPlacementView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ManagedPlacementViewServiceClient client = new ManagedPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ManagedPlacementView responseCallSettings = await client.GetManagedPlacementViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ManagedPlacementView responseCancellationToken = await client.GetManagedPlacementViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetManagedPlacementViewResourceNames()
        {
            moq::Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient> mockGrpcClient = new moq::Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetManagedPlacementViewRequest request = new GetManagedPlacementViewRequest
            {
                ResourceNameAsManagedPlacementViewName = gagvr::ManagedPlacementViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::ManagedPlacementView expectedResponse = new gagvr::ManagedPlacementView
            {
                ResourceNameAsManagedPlacementViewName = gagvr::ManagedPlacementViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetManagedPlacementView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ManagedPlacementViewServiceClient client = new ManagedPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ManagedPlacementView response = client.GetManagedPlacementView(request.ResourceNameAsManagedPlacementViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetManagedPlacementViewResourceNamesAsync()
        {
            moq::Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient> mockGrpcClient = new moq::Mock<ManagedPlacementViewService.ManagedPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetManagedPlacementViewRequest request = new GetManagedPlacementViewRequest
            {
                ResourceNameAsManagedPlacementViewName = gagvr::ManagedPlacementViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::ManagedPlacementView expectedResponse = new gagvr::ManagedPlacementView
            {
                ResourceNameAsManagedPlacementViewName = gagvr::ManagedPlacementViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetManagedPlacementViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::ManagedPlacementView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ManagedPlacementViewServiceClient client = new ManagedPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::ManagedPlacementView responseCallSettings = await client.GetManagedPlacementViewAsync(request.ResourceNameAsManagedPlacementViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::ManagedPlacementView responseCancellationToken = await client.GetManagedPlacementViewAsync(request.ResourceNameAsManagedPlacementViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

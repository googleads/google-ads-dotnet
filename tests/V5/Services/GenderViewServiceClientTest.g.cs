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

using gagvr = Google.Ads.GoogleAds.V5.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V5.Services;

namespace Google.Ads.GoogleAds.Tests.V5.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedGenderViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetGenderViewRequestObject()
        {
            moq::Mock<GenderViewService.GenderViewServiceClient> mockGrpcClient = new moq::Mock<GenderViewService.GenderViewServiceClient>(moq::MockBehavior.Strict);
            GetGenderViewRequest request = new GetGenderViewRequest
            {
                ResourceNameAsGenderViewName = gagvr::GenderViewName.FromCustomerGenderView("[CUSTOMER]", "[GENDER_VIEW]"),
            };
            gagvr::GenderView expectedResponse = new gagvr::GenderView
            {
                ResourceNameAsGenderViewName = gagvr::GenderViewName.FromCustomerGenderView("[CUSTOMER]", "[GENDER_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetGenderView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GenderViewServiceClient client = new GenderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GenderView response = client.GetGenderView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetGenderViewRequestObjectAsync()
        {
            moq::Mock<GenderViewService.GenderViewServiceClient> mockGrpcClient = new moq::Mock<GenderViewService.GenderViewServiceClient>(moq::MockBehavior.Strict);
            GetGenderViewRequest request = new GetGenderViewRequest
            {
                ResourceNameAsGenderViewName = gagvr::GenderViewName.FromCustomerGenderView("[CUSTOMER]", "[GENDER_VIEW]"),
            };
            gagvr::GenderView expectedResponse = new gagvr::GenderView
            {
                ResourceNameAsGenderViewName = gagvr::GenderViewName.FromCustomerGenderView("[CUSTOMER]", "[GENDER_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetGenderViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GenderView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GenderViewServiceClient client = new GenderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GenderView responseCallSettings = await client.GetGenderViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::GenderView responseCancellationToken = await client.GetGenderViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetGenderView()
        {
            moq::Mock<GenderViewService.GenderViewServiceClient> mockGrpcClient = new moq::Mock<GenderViewService.GenderViewServiceClient>(moq::MockBehavior.Strict);
            GetGenderViewRequest request = new GetGenderViewRequest
            {
                ResourceNameAsGenderViewName = gagvr::GenderViewName.FromCustomerGenderView("[CUSTOMER]", "[GENDER_VIEW]"),
            };
            gagvr::GenderView expectedResponse = new gagvr::GenderView
            {
                ResourceNameAsGenderViewName = gagvr::GenderViewName.FromCustomerGenderView("[CUSTOMER]", "[GENDER_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetGenderView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GenderViewServiceClient client = new GenderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GenderView response = client.GetGenderView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetGenderViewAsync()
        {
            moq::Mock<GenderViewService.GenderViewServiceClient> mockGrpcClient = new moq::Mock<GenderViewService.GenderViewServiceClient>(moq::MockBehavior.Strict);
            GetGenderViewRequest request = new GetGenderViewRequest
            {
                ResourceNameAsGenderViewName = gagvr::GenderViewName.FromCustomerGenderView("[CUSTOMER]", "[GENDER_VIEW]"),
            };
            gagvr::GenderView expectedResponse = new gagvr::GenderView
            {
                ResourceNameAsGenderViewName = gagvr::GenderViewName.FromCustomerGenderView("[CUSTOMER]", "[GENDER_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetGenderViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GenderView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GenderViewServiceClient client = new GenderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GenderView responseCallSettings = await client.GetGenderViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::GenderView responseCancellationToken = await client.GetGenderViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetGenderViewResourceNames()
        {
            moq::Mock<GenderViewService.GenderViewServiceClient> mockGrpcClient = new moq::Mock<GenderViewService.GenderViewServiceClient>(moq::MockBehavior.Strict);
            GetGenderViewRequest request = new GetGenderViewRequest
            {
                ResourceNameAsGenderViewName = gagvr::GenderViewName.FromCustomerGenderView("[CUSTOMER]", "[GENDER_VIEW]"),
            };
            gagvr::GenderView expectedResponse = new gagvr::GenderView
            {
                ResourceNameAsGenderViewName = gagvr::GenderViewName.FromCustomerGenderView("[CUSTOMER]", "[GENDER_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetGenderView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GenderViewServiceClient client = new GenderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GenderView response = client.GetGenderView(request.ResourceNameAsGenderViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetGenderViewResourceNamesAsync()
        {
            moq::Mock<GenderViewService.GenderViewServiceClient> mockGrpcClient = new moq::Mock<GenderViewService.GenderViewServiceClient>(moq::MockBehavior.Strict);
            GetGenderViewRequest request = new GetGenderViewRequest
            {
                ResourceNameAsGenderViewName = gagvr::GenderViewName.FromCustomerGenderView("[CUSTOMER]", "[GENDER_VIEW]"),
            };
            gagvr::GenderView expectedResponse = new gagvr::GenderView
            {
                ResourceNameAsGenderViewName = gagvr::GenderViewName.FromCustomerGenderView("[CUSTOMER]", "[GENDER_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetGenderViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GenderView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GenderViewServiceClient client = new GenderViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GenderView responseCallSettings = await client.GetGenderViewAsync(request.ResourceNameAsGenderViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::GenderView responseCancellationToken = await client.GetGenderViewAsync(request.ResourceNameAsGenderViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V4.Services;

namespace Google.Ads.GoogleAds.Tests.V4.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedIncomeRangeViewServiceClientTest
    {
        [Test]
        public void GetIncomeRangeViewRequestObject()
        {
            moq::Mock<IncomeRangeViewService.IncomeRangeViewServiceClient> mockGrpcClient = new moq::Mock<IncomeRangeViewService.IncomeRangeViewServiceClient>(moq::MockBehavior.Strict);
            GetIncomeRangeViewRequest request = new GetIncomeRangeViewRequest
            {
                ResourceNameAsIncomeRangeViewName = gagvr::IncomeRangeViewName.FromCustomerIncomeRangeView("[CUSTOMER]", "[INCOME_RANGE_VIEW]"),
            };
            gagvr::IncomeRangeView expectedResponse = new gagvr::IncomeRangeView
            {
                ResourceNameAsIncomeRangeViewName = gagvr::IncomeRangeViewName.FromCustomerIncomeRangeView("[CUSTOMER]", "[INCOME_RANGE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetIncomeRangeView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IncomeRangeViewServiceClient client = new IncomeRangeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::IncomeRangeView response = client.GetIncomeRangeView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetIncomeRangeViewRequestObjectAsync()
        {
            moq::Mock<IncomeRangeViewService.IncomeRangeViewServiceClient> mockGrpcClient = new moq::Mock<IncomeRangeViewService.IncomeRangeViewServiceClient>(moq::MockBehavior.Strict);
            GetIncomeRangeViewRequest request = new GetIncomeRangeViewRequest
            {
                ResourceNameAsIncomeRangeViewName = gagvr::IncomeRangeViewName.FromCustomerIncomeRangeView("[CUSTOMER]", "[INCOME_RANGE_VIEW]"),
            };
            gagvr::IncomeRangeView expectedResponse = new gagvr::IncomeRangeView
            {
                ResourceNameAsIncomeRangeViewName = gagvr::IncomeRangeViewName.FromCustomerIncomeRangeView("[CUSTOMER]", "[INCOME_RANGE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetIncomeRangeViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::IncomeRangeView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IncomeRangeViewServiceClient client = new IncomeRangeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::IncomeRangeView responseCallSettings = await client.GetIncomeRangeViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::IncomeRangeView responseCancellationToken = await client.GetIncomeRangeViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetIncomeRangeView()
        {
            moq::Mock<IncomeRangeViewService.IncomeRangeViewServiceClient> mockGrpcClient = new moq::Mock<IncomeRangeViewService.IncomeRangeViewServiceClient>(moq::MockBehavior.Strict);
            GetIncomeRangeViewRequest request = new GetIncomeRangeViewRequest
            {
                ResourceNameAsIncomeRangeViewName = gagvr::IncomeRangeViewName.FromCustomerIncomeRangeView("[CUSTOMER]", "[INCOME_RANGE_VIEW]"),
            };
            gagvr::IncomeRangeView expectedResponse = new gagvr::IncomeRangeView
            {
                ResourceNameAsIncomeRangeViewName = gagvr::IncomeRangeViewName.FromCustomerIncomeRangeView("[CUSTOMER]", "[INCOME_RANGE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetIncomeRangeView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IncomeRangeViewServiceClient client = new IncomeRangeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::IncomeRangeView response = client.GetIncomeRangeView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetIncomeRangeViewAsync()
        {
            moq::Mock<IncomeRangeViewService.IncomeRangeViewServiceClient> mockGrpcClient = new moq::Mock<IncomeRangeViewService.IncomeRangeViewServiceClient>(moq::MockBehavior.Strict);
            GetIncomeRangeViewRequest request = new GetIncomeRangeViewRequest
            {
                ResourceNameAsIncomeRangeViewName = gagvr::IncomeRangeViewName.FromCustomerIncomeRangeView("[CUSTOMER]", "[INCOME_RANGE_VIEW]"),
            };
            gagvr::IncomeRangeView expectedResponse = new gagvr::IncomeRangeView
            {
                ResourceNameAsIncomeRangeViewName = gagvr::IncomeRangeViewName.FromCustomerIncomeRangeView("[CUSTOMER]", "[INCOME_RANGE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetIncomeRangeViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::IncomeRangeView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IncomeRangeViewServiceClient client = new IncomeRangeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::IncomeRangeView responseCallSettings = await client.GetIncomeRangeViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::IncomeRangeView responseCancellationToken = await client.GetIncomeRangeViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetIncomeRangeViewResourceNames()
        {
            moq::Mock<IncomeRangeViewService.IncomeRangeViewServiceClient> mockGrpcClient = new moq::Mock<IncomeRangeViewService.IncomeRangeViewServiceClient>(moq::MockBehavior.Strict);
            GetIncomeRangeViewRequest request = new GetIncomeRangeViewRequest
            {
                ResourceNameAsIncomeRangeViewName = gagvr::IncomeRangeViewName.FromCustomerIncomeRangeView("[CUSTOMER]", "[INCOME_RANGE_VIEW]"),
            };
            gagvr::IncomeRangeView expectedResponse = new gagvr::IncomeRangeView
            {
                ResourceNameAsIncomeRangeViewName = gagvr::IncomeRangeViewName.FromCustomerIncomeRangeView("[CUSTOMER]", "[INCOME_RANGE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetIncomeRangeView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IncomeRangeViewServiceClient client = new IncomeRangeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::IncomeRangeView response = client.GetIncomeRangeView(request.ResourceNameAsIncomeRangeViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetIncomeRangeViewResourceNamesAsync()
        {
            moq::Mock<IncomeRangeViewService.IncomeRangeViewServiceClient> mockGrpcClient = new moq::Mock<IncomeRangeViewService.IncomeRangeViewServiceClient>(moq::MockBehavior.Strict);
            GetIncomeRangeViewRequest request = new GetIncomeRangeViewRequest
            {
                ResourceNameAsIncomeRangeViewName = gagvr::IncomeRangeViewName.FromCustomerIncomeRangeView("[CUSTOMER]", "[INCOME_RANGE_VIEW]"),
            };
            gagvr::IncomeRangeView expectedResponse = new gagvr::IncomeRangeView
            {
                ResourceNameAsIncomeRangeViewName = gagvr::IncomeRangeViewName.FromCustomerIncomeRangeView("[CUSTOMER]", "[INCOME_RANGE_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetIncomeRangeViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::IncomeRangeView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IncomeRangeViewServiceClient client = new IncomeRangeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::IncomeRangeView responseCallSettings = await client.GetIncomeRangeViewAsync(request.ResourceNameAsIncomeRangeViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::IncomeRangeView responseCancellationToken = await client.GetIncomeRangeViewAsync(request.ResourceNameAsIncomeRangeViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

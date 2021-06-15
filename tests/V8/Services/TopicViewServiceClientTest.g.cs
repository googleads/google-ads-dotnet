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

using gagvr = Google.Ads.GoogleAds.V8.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V8.Services;

namespace Google.Ads.GoogleAds.Tests.V8.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTopicViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetTopicViewRequestObject()
        {
            moq::Mock<TopicViewService.TopicViewServiceClient> mockGrpcClient = new moq::Mock<TopicViewService.TopicViewServiceClient>(moq::MockBehavior.Strict);
            GetTopicViewRequest request = new GetTopicViewRequest
            {
                ResourceNameAsTopicViewName = gagvr::TopicViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::TopicView expectedResponse = new gagvr::TopicView
            {
                ResourceNameAsTopicViewName = gagvr::TopicViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetTopicView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TopicViewServiceClient client = new TopicViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::TopicView response = client.GetTopicView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetTopicViewRequestObjectAsync()
        {
            moq::Mock<TopicViewService.TopicViewServiceClient> mockGrpcClient = new moq::Mock<TopicViewService.TopicViewServiceClient>(moq::MockBehavior.Strict);
            GetTopicViewRequest request = new GetTopicViewRequest
            {
                ResourceNameAsTopicViewName = gagvr::TopicViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::TopicView expectedResponse = new gagvr::TopicView
            {
                ResourceNameAsTopicViewName = gagvr::TopicViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetTopicViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::TopicView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TopicViewServiceClient client = new TopicViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::TopicView responseCallSettings = await client.GetTopicViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::TopicView responseCancellationToken = await client.GetTopicViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetTopicView()
        {
            moq::Mock<TopicViewService.TopicViewServiceClient> mockGrpcClient = new moq::Mock<TopicViewService.TopicViewServiceClient>(moq::MockBehavior.Strict);
            GetTopicViewRequest request = new GetTopicViewRequest
            {
                ResourceNameAsTopicViewName = gagvr::TopicViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::TopicView expectedResponse = new gagvr::TopicView
            {
                ResourceNameAsTopicViewName = gagvr::TopicViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetTopicView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TopicViewServiceClient client = new TopicViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::TopicView response = client.GetTopicView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetTopicViewAsync()
        {
            moq::Mock<TopicViewService.TopicViewServiceClient> mockGrpcClient = new moq::Mock<TopicViewService.TopicViewServiceClient>(moq::MockBehavior.Strict);
            GetTopicViewRequest request = new GetTopicViewRequest
            {
                ResourceNameAsTopicViewName = gagvr::TopicViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::TopicView expectedResponse = new gagvr::TopicView
            {
                ResourceNameAsTopicViewName = gagvr::TopicViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetTopicViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::TopicView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TopicViewServiceClient client = new TopicViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::TopicView responseCallSettings = await client.GetTopicViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::TopicView responseCancellationToken = await client.GetTopicViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetTopicViewResourceNames()
        {
            moq::Mock<TopicViewService.TopicViewServiceClient> mockGrpcClient = new moq::Mock<TopicViewService.TopicViewServiceClient>(moq::MockBehavior.Strict);
            GetTopicViewRequest request = new GetTopicViewRequest
            {
                ResourceNameAsTopicViewName = gagvr::TopicViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::TopicView expectedResponse = new gagvr::TopicView
            {
                ResourceNameAsTopicViewName = gagvr::TopicViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetTopicView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TopicViewServiceClient client = new TopicViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::TopicView response = client.GetTopicView(request.ResourceNameAsTopicViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetTopicViewResourceNamesAsync()
        {
            moq::Mock<TopicViewService.TopicViewServiceClient> mockGrpcClient = new moq::Mock<TopicViewService.TopicViewServiceClient>(moq::MockBehavior.Strict);
            GetTopicViewRequest request = new GetTopicViewRequest
            {
                ResourceNameAsTopicViewName = gagvr::TopicViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            gagvr::TopicView expectedResponse = new gagvr::TopicView
            {
                ResourceNameAsTopicViewName = gagvr::TopicViewName.FromCustomerAdGroupCriterion("[CUSTOMER_ID]", "[AD_GROUP_ID]", "[CRITERION_ID]"),
            };
            mockGrpcClient.Setup(x => x.GetTopicViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::TopicView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TopicViewServiceClient client = new TopicViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::TopicView responseCallSettings = await client.GetTopicViewAsync(request.ResourceNameAsTopicViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::TopicView responseCancellationToken = await client.GetTopicViewAsync(request.ResourceNameAsTopicViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

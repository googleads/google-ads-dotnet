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

using gagvr = Google.Ads.GoogleAds.V1.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V1.Services;

namespace Google.Ads.GoogleAds.Tests.V1.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedKeywordViewServiceClientTest
    {
        [Test]
        public void GetKeywordViewRequestObject()
        {
            moq::Mock<KeywordViewService.KeywordViewServiceClient> mockGrpcClient = new moq::Mock<KeywordViewService.KeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetKeywordViewRequest request = new GetKeywordViewRequest
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerKeywordView("[CUSTOMER]", "[KEYWORD_VIEW]"),
            };
            gagvr::KeywordView expectedResponse = new gagvr::KeywordView
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerKeywordView("[CUSTOMER]", "[KEYWORD_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetKeywordView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordViewServiceClient client = new KeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordView response = client.GetKeywordView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetKeywordViewRequestObjectAsync()
        {
            moq::Mock<KeywordViewService.KeywordViewServiceClient> mockGrpcClient = new moq::Mock<KeywordViewService.KeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetKeywordViewRequest request = new GetKeywordViewRequest
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerKeywordView("[CUSTOMER]", "[KEYWORD_VIEW]"),
            };
            gagvr::KeywordView expectedResponse = new gagvr::KeywordView
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerKeywordView("[CUSTOMER]", "[KEYWORD_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetKeywordViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordViewServiceClient client = new KeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordView responseCallSettings = await client.GetKeywordViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordView responseCancellationToken = await client.GetKeywordViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetKeywordView()
        {
            moq::Mock<KeywordViewService.KeywordViewServiceClient> mockGrpcClient = new moq::Mock<KeywordViewService.KeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetKeywordViewRequest request = new GetKeywordViewRequest
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerKeywordView("[CUSTOMER]", "[KEYWORD_VIEW]"),
            };
            gagvr::KeywordView expectedResponse = new gagvr::KeywordView
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerKeywordView("[CUSTOMER]", "[KEYWORD_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetKeywordView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordViewServiceClient client = new KeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordView response = client.GetKeywordView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetKeywordViewAsync()
        {
            moq::Mock<KeywordViewService.KeywordViewServiceClient> mockGrpcClient = new moq::Mock<KeywordViewService.KeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetKeywordViewRequest request = new GetKeywordViewRequest
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerKeywordView("[CUSTOMER]", "[KEYWORD_VIEW]"),
            };
            gagvr::KeywordView expectedResponse = new gagvr::KeywordView
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerKeywordView("[CUSTOMER]", "[KEYWORD_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetKeywordViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordViewServiceClient client = new KeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordView responseCallSettings = await client.GetKeywordViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordView responseCancellationToken = await client.GetKeywordViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetKeywordViewResourceNames()
        {
            moq::Mock<KeywordViewService.KeywordViewServiceClient> mockGrpcClient = new moq::Mock<KeywordViewService.KeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetKeywordViewRequest request = new GetKeywordViewRequest
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerKeywordView("[CUSTOMER]", "[KEYWORD_VIEW]"),
            };
            gagvr::KeywordView expectedResponse = new gagvr::KeywordView
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerKeywordView("[CUSTOMER]", "[KEYWORD_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetKeywordView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeywordViewServiceClient client = new KeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordView response = client.GetKeywordView(request.ResourceNameAsKeywordViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetKeywordViewResourceNamesAsync()
        {
            moq::Mock<KeywordViewService.KeywordViewServiceClient> mockGrpcClient = new moq::Mock<KeywordViewService.KeywordViewServiceClient>(moq::MockBehavior.Strict);
            GetKeywordViewRequest request = new GetKeywordViewRequest
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerKeywordView("[CUSTOMER]", "[KEYWORD_VIEW]"),
            };
            gagvr::KeywordView expectedResponse = new gagvr::KeywordView
            {
                ResourceNameAsKeywordViewName = gagvr::KeywordViewName.FromCustomerKeywordView("[CUSTOMER]", "[KEYWORD_VIEW]"),
            };
            mockGrpcClient.Setup(x => x.GetKeywordViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::KeywordView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeywordViewServiceClient client = new KeywordViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::KeywordView responseCallSettings = await client.GetKeywordViewAsync(request.ResourceNameAsKeywordViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::KeywordView responseCancellationToken = await client.GetKeywordViewAsync(request.ResourceNameAsKeywordViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

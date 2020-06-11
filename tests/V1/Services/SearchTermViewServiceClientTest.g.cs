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

using gagve = Google.Ads.GoogleAds.V1.Enums;
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
    public sealed class GeneratedSearchTermViewServiceClientTest
    {
        [Test]
        public void GetSearchTermViewRequestObject()
        {
            moq::Mock<SearchTermViewService.SearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SearchTermViewService.SearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSearchTermViewRequest request = new GetSearchTermViewRequest
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
            };
            gagvr::SearchTermView expectedResponse = new gagvr::SearchTermView
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
                SearchTerm = "search_term6c01a1df",
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Added,
            };
            mockGrpcClient.Setup(x => x.GetSearchTermView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SearchTermViewServiceClient client = new SearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SearchTermView response = client.GetSearchTermView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetSearchTermViewRequestObjectAsync()
        {
            moq::Mock<SearchTermViewService.SearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SearchTermViewService.SearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSearchTermViewRequest request = new GetSearchTermViewRequest
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
            };
            gagvr::SearchTermView expectedResponse = new gagvr::SearchTermView
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
                SearchTerm = "search_term6c01a1df",
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Added,
            };
            mockGrpcClient.Setup(x => x.GetSearchTermViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SearchTermView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SearchTermViewServiceClient client = new SearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SearchTermView responseCallSettings = await client.GetSearchTermViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::SearchTermView responseCancellationToken = await client.GetSearchTermViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetSearchTermView()
        {
            moq::Mock<SearchTermViewService.SearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SearchTermViewService.SearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSearchTermViewRequest request = new GetSearchTermViewRequest
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
            };
            gagvr::SearchTermView expectedResponse = new gagvr::SearchTermView
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
                SearchTerm = "search_term6c01a1df",
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Added,
            };
            mockGrpcClient.Setup(x => x.GetSearchTermView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SearchTermViewServiceClient client = new SearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SearchTermView response = client.GetSearchTermView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetSearchTermViewAsync()
        {
            moq::Mock<SearchTermViewService.SearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SearchTermViewService.SearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSearchTermViewRequest request = new GetSearchTermViewRequest
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
            };
            gagvr::SearchTermView expectedResponse = new gagvr::SearchTermView
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
                SearchTerm = "search_term6c01a1df",
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Added,
            };
            mockGrpcClient.Setup(x => x.GetSearchTermViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SearchTermView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SearchTermViewServiceClient client = new SearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SearchTermView responseCallSettings = await client.GetSearchTermViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::SearchTermView responseCancellationToken = await client.GetSearchTermViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetSearchTermViewResourceNames()
        {
            moq::Mock<SearchTermViewService.SearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SearchTermViewService.SearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSearchTermViewRequest request = new GetSearchTermViewRequest
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
            };
            gagvr::SearchTermView expectedResponse = new gagvr::SearchTermView
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
                SearchTerm = "search_term6c01a1df",
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Added,
            };
            mockGrpcClient.Setup(x => x.GetSearchTermView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SearchTermViewServiceClient client = new SearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SearchTermView response = client.GetSearchTermView(request.ResourceNameAsSearchTermViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetSearchTermViewResourceNamesAsync()
        {
            moq::Mock<SearchTermViewService.SearchTermViewServiceClient> mockGrpcClient = new moq::Mock<SearchTermViewService.SearchTermViewServiceClient>(moq::MockBehavior.Strict);
            GetSearchTermViewRequest request = new GetSearchTermViewRequest
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
            };
            gagvr::SearchTermView expectedResponse = new gagvr::SearchTermView
            {
                ResourceNameAsSearchTermViewName = gagvr::SearchTermViewName.FromCustomerSearchTermView("[CUSTOMER]", "[SEARCH_TERM_VIEW]"),
                SearchTerm = "search_term6c01a1df",
                AdGroupAsAdGroupName = gagvr::AdGroupName.FromCustomerAdGroup("[CUSTOMER]", "[AD_GROUP]"),
                Status = gagve::SearchTermTargetingStatusEnum.Types.SearchTermTargetingStatus.Added,
            };
            mockGrpcClient.Setup(x => x.GetSearchTermViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SearchTermView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SearchTermViewServiceClient client = new SearchTermViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SearchTermView responseCallSettings = await client.GetSearchTermViewAsync(request.ResourceNameAsSearchTermViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::SearchTermView responseCancellationToken = await client.GetSearchTermViewAsync(request.ResourceNameAsSearchTermViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

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

using gagve = Google.Ads.GoogleAds.V2.Enums;
using gagvr = Google.Ads.GoogleAds.V2.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V2.Services;

namespace Google.Ads.GoogleAds.Tests.V2.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDetailPlacementViewServiceClientTest
    {
        [Test]
        public void GetDetailPlacementViewRequestObject()
        {
            moq::Mock<DetailPlacementViewService.DetailPlacementViewServiceClient> mockGrpcClient = new moq::Mock<DetailPlacementViewService.DetailPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetDetailPlacementViewRequest request = new GetDetailPlacementViewRequest
            {
                ResourceNameAsDetailPlacementViewName = gagvr::DetailPlacementViewName.FromCustomerDetailPlacementView("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]"),
            };
            gagvr::DetailPlacementView expectedResponse = new gagvr::DetailPlacementView
            {
                ResourceNameAsDetailPlacementViewName = gagvr::DetailPlacementViewName.FromCustomerDetailPlacementView("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]"),
                Placement = "placementb440552a",
                DisplayName = "display_name137f65c2",
                GroupPlacementTargetUrl = "group_placement_target_urlb7f47882",
                TargetUrl = "target_url95bdaf9b",
                PlacementType = gagve::PlacementTypeEnum.Types.PlacementType.Website,
            };
            mockGrpcClient.Setup(x => x.GetDetailPlacementView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DetailPlacementViewServiceClient client = new DetailPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DetailPlacementView response = client.GetDetailPlacementView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetDetailPlacementViewRequestObjectAsync()
        {
            moq::Mock<DetailPlacementViewService.DetailPlacementViewServiceClient> mockGrpcClient = new moq::Mock<DetailPlacementViewService.DetailPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetDetailPlacementViewRequest request = new GetDetailPlacementViewRequest
            {
                ResourceNameAsDetailPlacementViewName = gagvr::DetailPlacementViewName.FromCustomerDetailPlacementView("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]"),
            };
            gagvr::DetailPlacementView expectedResponse = new gagvr::DetailPlacementView
            {
                ResourceNameAsDetailPlacementViewName = gagvr::DetailPlacementViewName.FromCustomerDetailPlacementView("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]"),
                Placement = "placementb440552a",
                DisplayName = "display_name137f65c2",
                GroupPlacementTargetUrl = "group_placement_target_urlb7f47882",
                TargetUrl = "target_url95bdaf9b",
                PlacementType = gagve::PlacementTypeEnum.Types.PlacementType.Website,
            };
            mockGrpcClient.Setup(x => x.GetDetailPlacementViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DetailPlacementView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DetailPlacementViewServiceClient client = new DetailPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DetailPlacementView responseCallSettings = await client.GetDetailPlacementViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DetailPlacementView responseCancellationToken = await client.GetDetailPlacementViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetDetailPlacementView()
        {
            moq::Mock<DetailPlacementViewService.DetailPlacementViewServiceClient> mockGrpcClient = new moq::Mock<DetailPlacementViewService.DetailPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetDetailPlacementViewRequest request = new GetDetailPlacementViewRequest
            {
                ResourceNameAsDetailPlacementViewName = gagvr::DetailPlacementViewName.FromCustomerDetailPlacementView("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]"),
            };
            gagvr::DetailPlacementView expectedResponse = new gagvr::DetailPlacementView
            {
                ResourceNameAsDetailPlacementViewName = gagvr::DetailPlacementViewName.FromCustomerDetailPlacementView("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]"),
                Placement = "placementb440552a",
                DisplayName = "display_name137f65c2",
                GroupPlacementTargetUrl = "group_placement_target_urlb7f47882",
                TargetUrl = "target_url95bdaf9b",
                PlacementType = gagve::PlacementTypeEnum.Types.PlacementType.Website,
            };
            mockGrpcClient.Setup(x => x.GetDetailPlacementView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DetailPlacementViewServiceClient client = new DetailPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DetailPlacementView response = client.GetDetailPlacementView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetDetailPlacementViewAsync()
        {
            moq::Mock<DetailPlacementViewService.DetailPlacementViewServiceClient> mockGrpcClient = new moq::Mock<DetailPlacementViewService.DetailPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetDetailPlacementViewRequest request = new GetDetailPlacementViewRequest
            {
                ResourceNameAsDetailPlacementViewName = gagvr::DetailPlacementViewName.FromCustomerDetailPlacementView("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]"),
            };
            gagvr::DetailPlacementView expectedResponse = new gagvr::DetailPlacementView
            {
                ResourceNameAsDetailPlacementViewName = gagvr::DetailPlacementViewName.FromCustomerDetailPlacementView("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]"),
                Placement = "placementb440552a",
                DisplayName = "display_name137f65c2",
                GroupPlacementTargetUrl = "group_placement_target_urlb7f47882",
                TargetUrl = "target_url95bdaf9b",
                PlacementType = gagve::PlacementTypeEnum.Types.PlacementType.Website,
            };
            mockGrpcClient.Setup(x => x.GetDetailPlacementViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DetailPlacementView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DetailPlacementViewServiceClient client = new DetailPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DetailPlacementView responseCallSettings = await client.GetDetailPlacementViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DetailPlacementView responseCancellationToken = await client.GetDetailPlacementViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetDetailPlacementViewResourceNames()
        {
            moq::Mock<DetailPlacementViewService.DetailPlacementViewServiceClient> mockGrpcClient = new moq::Mock<DetailPlacementViewService.DetailPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetDetailPlacementViewRequest request = new GetDetailPlacementViewRequest
            {
                ResourceNameAsDetailPlacementViewName = gagvr::DetailPlacementViewName.FromCustomerDetailPlacementView("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]"),
            };
            gagvr::DetailPlacementView expectedResponse = new gagvr::DetailPlacementView
            {
                ResourceNameAsDetailPlacementViewName = gagvr::DetailPlacementViewName.FromCustomerDetailPlacementView("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]"),
                Placement = "placementb440552a",
                DisplayName = "display_name137f65c2",
                GroupPlacementTargetUrl = "group_placement_target_urlb7f47882",
                TargetUrl = "target_url95bdaf9b",
                PlacementType = gagve::PlacementTypeEnum.Types.PlacementType.Website,
            };
            mockGrpcClient.Setup(x => x.GetDetailPlacementView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DetailPlacementViewServiceClient client = new DetailPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DetailPlacementView response = client.GetDetailPlacementView(request.ResourceNameAsDetailPlacementViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetDetailPlacementViewResourceNamesAsync()
        {
            moq::Mock<DetailPlacementViewService.DetailPlacementViewServiceClient> mockGrpcClient = new moq::Mock<DetailPlacementViewService.DetailPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetDetailPlacementViewRequest request = new GetDetailPlacementViewRequest
            {
                ResourceNameAsDetailPlacementViewName = gagvr::DetailPlacementViewName.FromCustomerDetailPlacementView("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]"),
            };
            gagvr::DetailPlacementView expectedResponse = new gagvr::DetailPlacementView
            {
                ResourceNameAsDetailPlacementViewName = gagvr::DetailPlacementViewName.FromCustomerDetailPlacementView("[CUSTOMER]", "[DETAIL_PLACEMENT_VIEW]"),
                Placement = "placementb440552a",
                DisplayName = "display_name137f65c2",
                GroupPlacementTargetUrl = "group_placement_target_urlb7f47882",
                TargetUrl = "target_url95bdaf9b",
                PlacementType = gagve::PlacementTypeEnum.Types.PlacementType.Website,
            };
            mockGrpcClient.Setup(x => x.GetDetailPlacementViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::DetailPlacementView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DetailPlacementViewServiceClient client = new DetailPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::DetailPlacementView responseCallSettings = await client.GetDetailPlacementViewAsync(request.ResourceNameAsDetailPlacementViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::DetailPlacementView responseCancellationToken = await client.GetDetailPlacementViewAsync(request.ResourceNameAsDetailPlacementViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

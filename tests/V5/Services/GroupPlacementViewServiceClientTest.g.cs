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

using gagve = Google.Ads.GoogleAds.V5.Enums;
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
    public sealed class GeneratedGroupPlacementViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetGroupPlacementViewRequestObject()
        {
            moq::Mock<GroupPlacementViewService.GroupPlacementViewServiceClient> mockGrpcClient = new moq::Mock<GroupPlacementViewService.GroupPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetGroupPlacementViewRequest request = new GetGroupPlacementViewRequest
            {
                ResourceNameAsGroupPlacementViewName = gagvr::GroupPlacementViewName.FromCustomerGroupPlacementView("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]"),
            };
            gagvr::GroupPlacementView expectedResponse = new gagvr::GroupPlacementView
            {
                ResourceNameAsGroupPlacementViewName = gagvr::GroupPlacementViewName.FromCustomerGroupPlacementView("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]"),
                Placement = "placementb440552a",
                DisplayName = "display_name137f65c2",
                TargetUrl = "target_url95bdaf9b",
                PlacementType = gagve::PlacementTypeEnum.Types.PlacementType.Website,
            };
            mockGrpcClient.Setup(x => x.GetGroupPlacementView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupPlacementViewServiceClient client = new GroupPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GroupPlacementView response = client.GetGroupPlacementView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetGroupPlacementViewRequestObjectAsync()
        {
            moq::Mock<GroupPlacementViewService.GroupPlacementViewServiceClient> mockGrpcClient = new moq::Mock<GroupPlacementViewService.GroupPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetGroupPlacementViewRequest request = new GetGroupPlacementViewRequest
            {
                ResourceNameAsGroupPlacementViewName = gagvr::GroupPlacementViewName.FromCustomerGroupPlacementView("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]"),
            };
            gagvr::GroupPlacementView expectedResponse = new gagvr::GroupPlacementView
            {
                ResourceNameAsGroupPlacementViewName = gagvr::GroupPlacementViewName.FromCustomerGroupPlacementView("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]"),
                Placement = "placementb440552a",
                DisplayName = "display_name137f65c2",
                TargetUrl = "target_url95bdaf9b",
                PlacementType = gagve::PlacementTypeEnum.Types.PlacementType.Website,
            };
            mockGrpcClient.Setup(x => x.GetGroupPlacementViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GroupPlacementView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupPlacementViewServiceClient client = new GroupPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GroupPlacementView responseCallSettings = await client.GetGroupPlacementViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::GroupPlacementView responseCancellationToken = await client.GetGroupPlacementViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetGroupPlacementView()
        {
            moq::Mock<GroupPlacementViewService.GroupPlacementViewServiceClient> mockGrpcClient = new moq::Mock<GroupPlacementViewService.GroupPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetGroupPlacementViewRequest request = new GetGroupPlacementViewRequest
            {
                ResourceNameAsGroupPlacementViewName = gagvr::GroupPlacementViewName.FromCustomerGroupPlacementView("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]"),
            };
            gagvr::GroupPlacementView expectedResponse = new gagvr::GroupPlacementView
            {
                ResourceNameAsGroupPlacementViewName = gagvr::GroupPlacementViewName.FromCustomerGroupPlacementView("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]"),
                Placement = "placementb440552a",
                DisplayName = "display_name137f65c2",
                TargetUrl = "target_url95bdaf9b",
                PlacementType = gagve::PlacementTypeEnum.Types.PlacementType.Website,
            };
            mockGrpcClient.Setup(x => x.GetGroupPlacementView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupPlacementViewServiceClient client = new GroupPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GroupPlacementView response = client.GetGroupPlacementView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetGroupPlacementViewAsync()
        {
            moq::Mock<GroupPlacementViewService.GroupPlacementViewServiceClient> mockGrpcClient = new moq::Mock<GroupPlacementViewService.GroupPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetGroupPlacementViewRequest request = new GetGroupPlacementViewRequest
            {
                ResourceNameAsGroupPlacementViewName = gagvr::GroupPlacementViewName.FromCustomerGroupPlacementView("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]"),
            };
            gagvr::GroupPlacementView expectedResponse = new gagvr::GroupPlacementView
            {
                ResourceNameAsGroupPlacementViewName = gagvr::GroupPlacementViewName.FromCustomerGroupPlacementView("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]"),
                Placement = "placementb440552a",
                DisplayName = "display_name137f65c2",
                TargetUrl = "target_url95bdaf9b",
                PlacementType = gagve::PlacementTypeEnum.Types.PlacementType.Website,
            };
            mockGrpcClient.Setup(x => x.GetGroupPlacementViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GroupPlacementView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupPlacementViewServiceClient client = new GroupPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GroupPlacementView responseCallSettings = await client.GetGroupPlacementViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::GroupPlacementView responseCancellationToken = await client.GetGroupPlacementViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetGroupPlacementViewResourceNames()
        {
            moq::Mock<GroupPlacementViewService.GroupPlacementViewServiceClient> mockGrpcClient = new moq::Mock<GroupPlacementViewService.GroupPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetGroupPlacementViewRequest request = new GetGroupPlacementViewRequest
            {
                ResourceNameAsGroupPlacementViewName = gagvr::GroupPlacementViewName.FromCustomerGroupPlacementView("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]"),
            };
            gagvr::GroupPlacementView expectedResponse = new gagvr::GroupPlacementView
            {
                ResourceNameAsGroupPlacementViewName = gagvr::GroupPlacementViewName.FromCustomerGroupPlacementView("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]"),
                Placement = "placementb440552a",
                DisplayName = "display_name137f65c2",
                TargetUrl = "target_url95bdaf9b",
                PlacementType = gagve::PlacementTypeEnum.Types.PlacementType.Website,
            };
            mockGrpcClient.Setup(x => x.GetGroupPlacementView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GroupPlacementViewServiceClient client = new GroupPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GroupPlacementView response = client.GetGroupPlacementView(request.ResourceNameAsGroupPlacementViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetGroupPlacementViewResourceNamesAsync()
        {
            moq::Mock<GroupPlacementViewService.GroupPlacementViewServiceClient> mockGrpcClient = new moq::Mock<GroupPlacementViewService.GroupPlacementViewServiceClient>(moq::MockBehavior.Strict);
            GetGroupPlacementViewRequest request = new GetGroupPlacementViewRequest
            {
                ResourceNameAsGroupPlacementViewName = gagvr::GroupPlacementViewName.FromCustomerGroupPlacementView("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]"),
            };
            gagvr::GroupPlacementView expectedResponse = new gagvr::GroupPlacementView
            {
                ResourceNameAsGroupPlacementViewName = gagvr::GroupPlacementViewName.FromCustomerGroupPlacementView("[CUSTOMER]", "[GROUP_PLACEMENT_VIEW]"),
                Placement = "placementb440552a",
                DisplayName = "display_name137f65c2",
                TargetUrl = "target_url95bdaf9b",
                PlacementType = gagve::PlacementTypeEnum.Types.PlacementType.Website,
            };
            mockGrpcClient.Setup(x => x.GetGroupPlacementViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GroupPlacementView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GroupPlacementViewServiceClient client = new GroupPlacementViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GroupPlacementView responseCallSettings = await client.GetGroupPlacementViewAsync(request.ResourceNameAsGroupPlacementViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::GroupPlacementView responseCancellationToken = await client.GetGroupPlacementViewAsync(request.ResourceNameAsGroupPlacementViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

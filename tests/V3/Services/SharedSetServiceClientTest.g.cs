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

using gagve = Google.Ads.GoogleAds.V3.Enums;
using gagvr = Google.Ads.GoogleAds.V3.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V3.Services;

namespace Google.Ads.GoogleAds.Tests.V3.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSharedSetServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetSharedSetRequestObject()
        {
            moq::Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new moq::Mock<SharedSetService.SharedSetServiceClient>(moq::MockBehavior.Strict);
            GetSharedSetRequest request = new GetSharedSetRequest
            {
                ResourceNameAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
            };
            gagvr::SharedSet expectedResponse = new gagvr::SharedSet
            {
                ResourceNameAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
                Id = -6774108720365892680L,
                Type = gagve::SharedSetTypeEnum.Types.SharedSetType.NegativePlacements,
                SharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
                Status = gagve::SharedSetStatusEnum.Types.SharedSetStatus.Enabled,
                MemberCount = -5151590354343439845L,
                ReferenceCount = -8440758895662409664L,
            };
            mockGrpcClient.Setup(x => x.GetSharedSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SharedSet response = client.GetSharedSet(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetSharedSetRequestObjectAsync()
        {
            moq::Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new moq::Mock<SharedSetService.SharedSetServiceClient>(moq::MockBehavior.Strict);
            GetSharedSetRequest request = new GetSharedSetRequest
            {
                ResourceNameAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
            };
            gagvr::SharedSet expectedResponse = new gagvr::SharedSet
            {
                ResourceNameAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
                Id = -6774108720365892680L,
                Type = gagve::SharedSetTypeEnum.Types.SharedSetType.NegativePlacements,
                SharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
                Status = gagve::SharedSetStatusEnum.Types.SharedSetStatus.Enabled,
                MemberCount = -5151590354343439845L,
                ReferenceCount = -8440758895662409664L,
            };
            mockGrpcClient.Setup(x => x.GetSharedSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SharedSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SharedSet responseCallSettings = await client.GetSharedSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::SharedSet responseCancellationToken = await client.GetSharedSetAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetSharedSet()
        {
            moq::Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new moq::Mock<SharedSetService.SharedSetServiceClient>(moq::MockBehavior.Strict);
            GetSharedSetRequest request = new GetSharedSetRequest
            {
                ResourceNameAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
            };
            gagvr::SharedSet expectedResponse = new gagvr::SharedSet
            {
                ResourceNameAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
                Id = -6774108720365892680L,
                Type = gagve::SharedSetTypeEnum.Types.SharedSetType.NegativePlacements,
                SharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
                Status = gagve::SharedSetStatusEnum.Types.SharedSetStatus.Enabled,
                MemberCount = -5151590354343439845L,
                ReferenceCount = -8440758895662409664L,
            };
            mockGrpcClient.Setup(x => x.GetSharedSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SharedSet response = client.GetSharedSet(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetSharedSetAsync()
        {
            moq::Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new moq::Mock<SharedSetService.SharedSetServiceClient>(moq::MockBehavior.Strict);
            GetSharedSetRequest request = new GetSharedSetRequest
            {
                ResourceNameAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
            };
            gagvr::SharedSet expectedResponse = new gagvr::SharedSet
            {
                ResourceNameAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
                Id = -6774108720365892680L,
                Type = gagve::SharedSetTypeEnum.Types.SharedSetType.NegativePlacements,
                SharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
                Status = gagve::SharedSetStatusEnum.Types.SharedSetStatus.Enabled,
                MemberCount = -5151590354343439845L,
                ReferenceCount = -8440758895662409664L,
            };
            mockGrpcClient.Setup(x => x.GetSharedSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SharedSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SharedSet responseCallSettings = await client.GetSharedSetAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::SharedSet responseCancellationToken = await client.GetSharedSetAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetSharedSetResourceNames()
        {
            moq::Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new moq::Mock<SharedSetService.SharedSetServiceClient>(moq::MockBehavior.Strict);
            GetSharedSetRequest request = new GetSharedSetRequest
            {
                ResourceNameAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
            };
            gagvr::SharedSet expectedResponse = new gagvr::SharedSet
            {
                ResourceNameAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
                Id = -6774108720365892680L,
                Type = gagve::SharedSetTypeEnum.Types.SharedSetType.NegativePlacements,
                SharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
                Status = gagve::SharedSetStatusEnum.Types.SharedSetStatus.Enabled,
                MemberCount = -5151590354343439845L,
                ReferenceCount = -8440758895662409664L,
            };
            mockGrpcClient.Setup(x => x.GetSharedSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SharedSet response = client.GetSharedSet(request.ResourceNameAsSharedSetName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetSharedSetResourceNamesAsync()
        {
            moq::Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new moq::Mock<SharedSetService.SharedSetServiceClient>(moq::MockBehavior.Strict);
            GetSharedSetRequest request = new GetSharedSetRequest
            {
                ResourceNameAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
            };
            gagvr::SharedSet expectedResponse = new gagvr::SharedSet
            {
                ResourceNameAsSharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
                Id = -6774108720365892680L,
                Type = gagve::SharedSetTypeEnum.Types.SharedSetType.NegativePlacements,
                SharedSetName = gagvr::SharedSetName.FromCustomerSharedSet("[CUSTOMER]", "[SHARED_SET]"),
                Status = gagve::SharedSetStatusEnum.Types.SharedSetStatus.Enabled,
                MemberCount = -5151590354343439845L,
                ReferenceCount = -8440758895662409664L,
            };
            mockGrpcClient.Setup(x => x.GetSharedSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::SharedSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::SharedSet responseCallSettings = await client.GetSharedSetAsync(request.ResourceNameAsSharedSetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::SharedSet responseCancellationToken = await client.GetSharedSetAsync(request.ResourceNameAsSharedSetName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateSharedSetsRequestObject()
        {
            moq::Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new moq::Mock<SharedSetService.SharedSetServiceClient>(moq::MockBehavior.Strict);
            MutateSharedSetsRequest request = new MutateSharedSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new SharedSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateSharedSetsResponse expectedResponse = new MutateSharedSetsResponse
            {
                Results =
                {
                    new MutateSharedSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateSharedSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateSharedSetsResponse response = client.MutateSharedSets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateSharedSetsRequestObjectAsync()
        {
            moq::Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new moq::Mock<SharedSetService.SharedSetServiceClient>(moq::MockBehavior.Strict);
            MutateSharedSetsRequest request = new MutateSharedSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new SharedSetOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
            };
            MutateSharedSetsResponse expectedResponse = new MutateSharedSetsResponse
            {
                Results =
                {
                    new MutateSharedSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateSharedSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateSharedSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateSharedSetsResponse responseCallSettings = await client.MutateSharedSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateSharedSetsResponse responseCancellationToken = await client.MutateSharedSetsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateSharedSets()
        {
            moq::Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new moq::Mock<SharedSetService.SharedSetServiceClient>(moq::MockBehavior.Strict);
            MutateSharedSetsRequest request = new MutateSharedSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new SharedSetOperation(),
                },
            };
            MutateSharedSetsResponse expectedResponse = new MutateSharedSetsResponse
            {
                Results =
                {
                    new MutateSharedSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateSharedSets(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateSharedSetsResponse response = client.MutateSharedSets(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateSharedSetsAsync()
        {
            moq::Mock<SharedSetService.SharedSetServiceClient> mockGrpcClient = new moq::Mock<SharedSetService.SharedSetServiceClient>(moq::MockBehavior.Strict);
            MutateSharedSetsRequest request = new MutateSharedSetsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new SharedSetOperation(),
                },
            };
            MutateSharedSetsResponse expectedResponse = new MutateSharedSetsResponse
            {
                Results =
                {
                    new MutateSharedSetResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateSharedSetsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateSharedSetsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SharedSetServiceClient client = new SharedSetServiceClientImpl(mockGrpcClient.Object, null);
            MutateSharedSetsResponse responseCallSettings = await client.MutateSharedSetsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateSharedSetsResponse responseCancellationToken = await client.MutateSharedSetsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

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

using gagvc = Google.Ads.GoogleAds.V6.Common;
using gagve = Google.Ads.GoogleAds.V6.Enums;
using gagvr = Google.Ads.GoogleAds.V6.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V6.Services;

namespace Google.Ads.GoogleAds.Tests.V6.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedOfflineUserDataJobServiceClientTest
    {
        [Category("Smoke")][Test]
        public void CreateOfflineUserDataJobRequestObject()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateOfflineUserDataJobRequest request = new CreateOfflineUserDataJobRequest
            {
                CustomerId = "customer_id3b3724cb",
                Job = new gagvr::OfflineUserDataJob(),
            };
            CreateOfflineUserDataJobResponse expectedResponse = new CreateOfflineUserDataJobResponse
            {
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.CreateOfflineUserDataJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            CreateOfflineUserDataJobResponse response = client.CreateOfflineUserDataJob(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task CreateOfflineUserDataJobRequestObjectAsync()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateOfflineUserDataJobRequest request = new CreateOfflineUserDataJobRequest
            {
                CustomerId = "customer_id3b3724cb",
                Job = new gagvr::OfflineUserDataJob(),
            };
            CreateOfflineUserDataJobResponse expectedResponse = new CreateOfflineUserDataJobResponse
            {
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.CreateOfflineUserDataJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CreateOfflineUserDataJobResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            CreateOfflineUserDataJobResponse responseCallSettings = await client.CreateOfflineUserDataJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            CreateOfflineUserDataJobResponse responseCancellationToken = await client.CreateOfflineUserDataJobAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void CreateOfflineUserDataJob()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateOfflineUserDataJobRequest request = new CreateOfflineUserDataJobRequest
            {
                CustomerId = "customer_id3b3724cb",
                Job = new gagvr::OfflineUserDataJob(),
            };
            CreateOfflineUserDataJobResponse expectedResponse = new CreateOfflineUserDataJobResponse
            {
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.CreateOfflineUserDataJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            CreateOfflineUserDataJobResponse response = client.CreateOfflineUserDataJob(request.CustomerId, request.Job);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task CreateOfflineUserDataJobAsync()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateOfflineUserDataJobRequest request = new CreateOfflineUserDataJobRequest
            {
                CustomerId = "customer_id3b3724cb",
                Job = new gagvr::OfflineUserDataJob(),
            };
            CreateOfflineUserDataJobResponse expectedResponse = new CreateOfflineUserDataJobResponse
            {
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.CreateOfflineUserDataJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CreateOfflineUserDataJobResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            CreateOfflineUserDataJobResponse responseCallSettings = await client.CreateOfflineUserDataJobAsync(request.CustomerId, request.Job, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            CreateOfflineUserDataJobResponse responseCancellationToken = await client.CreateOfflineUserDataJobAsync(request.CustomerId, request.Job, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetOfflineUserDataJobRequestObject()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOfflineUserDataJobRequest request = new GetOfflineUserDataJobRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
            };
            gagvr::OfflineUserDataJob expectedResponse = new gagvr::OfflineUserDataJob
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Type = gagve::OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType.StoreSalesUploadThirdParty,
                Status = gagve::OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus.Pending,
                FailureReason = gagve::OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason.Unspecified,
                CustomerMatchUserListMetadata = new gagvc::CustomerMatchUserListMetadata(),
                StoreSalesMetadata = new gagvc::StoreSalesMetadata(),
                Id = -6774108720365892680L,
                ExternalId = -7826829054039660530L,
            };
            mockGrpcClient.Setup(x => x.GetOfflineUserDataJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::OfflineUserDataJob response = client.GetOfflineUserDataJob(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetOfflineUserDataJobRequestObjectAsync()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOfflineUserDataJobRequest request = new GetOfflineUserDataJobRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
            };
            gagvr::OfflineUserDataJob expectedResponse = new gagvr::OfflineUserDataJob
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Type = gagve::OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType.StoreSalesUploadThirdParty,
                Status = gagve::OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus.Pending,
                FailureReason = gagve::OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason.Unspecified,
                CustomerMatchUserListMetadata = new gagvc::CustomerMatchUserListMetadata(),
                StoreSalesMetadata = new gagvc::StoreSalesMetadata(),
                Id = -6774108720365892680L,
                ExternalId = -7826829054039660530L,
            };
            mockGrpcClient.Setup(x => x.GetOfflineUserDataJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::OfflineUserDataJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::OfflineUserDataJob responseCallSettings = await client.GetOfflineUserDataJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::OfflineUserDataJob responseCancellationToken = await client.GetOfflineUserDataJobAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetOfflineUserDataJob()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOfflineUserDataJobRequest request = new GetOfflineUserDataJobRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
            };
            gagvr::OfflineUserDataJob expectedResponse = new gagvr::OfflineUserDataJob
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Type = gagve::OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType.StoreSalesUploadThirdParty,
                Status = gagve::OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus.Pending,
                FailureReason = gagve::OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason.Unspecified,
                CustomerMatchUserListMetadata = new gagvc::CustomerMatchUserListMetadata(),
                StoreSalesMetadata = new gagvc::StoreSalesMetadata(),
                Id = -6774108720365892680L,
                ExternalId = -7826829054039660530L,
            };
            mockGrpcClient.Setup(x => x.GetOfflineUserDataJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::OfflineUserDataJob response = client.GetOfflineUserDataJob(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetOfflineUserDataJobAsync()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOfflineUserDataJobRequest request = new GetOfflineUserDataJobRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
            };
            gagvr::OfflineUserDataJob expectedResponse = new gagvr::OfflineUserDataJob
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Type = gagve::OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType.StoreSalesUploadThirdParty,
                Status = gagve::OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus.Pending,
                FailureReason = gagve::OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason.Unspecified,
                CustomerMatchUserListMetadata = new gagvc::CustomerMatchUserListMetadata(),
                StoreSalesMetadata = new gagvc::StoreSalesMetadata(),
                Id = -6774108720365892680L,
                ExternalId = -7826829054039660530L,
            };
            mockGrpcClient.Setup(x => x.GetOfflineUserDataJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::OfflineUserDataJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::OfflineUserDataJob responseCallSettings = await client.GetOfflineUserDataJobAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::OfflineUserDataJob responseCancellationToken = await client.GetOfflineUserDataJobAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetOfflineUserDataJobResourceNames()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOfflineUserDataJobRequest request = new GetOfflineUserDataJobRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
            };
            gagvr::OfflineUserDataJob expectedResponse = new gagvr::OfflineUserDataJob
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Type = gagve::OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType.StoreSalesUploadThirdParty,
                Status = gagve::OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus.Pending,
                FailureReason = gagve::OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason.Unspecified,
                CustomerMatchUserListMetadata = new gagvc::CustomerMatchUserListMetadata(),
                StoreSalesMetadata = new gagvc::StoreSalesMetadata(),
                Id = -6774108720365892680L,
                ExternalId = -7826829054039660530L,
            };
            mockGrpcClient.Setup(x => x.GetOfflineUserDataJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::OfflineUserDataJob response = client.GetOfflineUserDataJob(request.ResourceNameAsOfflineUserDataJobName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetOfflineUserDataJobResourceNamesAsync()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetOfflineUserDataJobRequest request = new GetOfflineUserDataJobRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
            };
            gagvr::OfflineUserDataJob expectedResponse = new gagvr::OfflineUserDataJob
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Type = gagve::OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType.StoreSalesUploadThirdParty,
                Status = gagve::OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus.Pending,
                FailureReason = gagve::OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason.Unspecified,
                CustomerMatchUserListMetadata = new gagvc::CustomerMatchUserListMetadata(),
                StoreSalesMetadata = new gagvc::StoreSalesMetadata(),
                Id = -6774108720365892680L,
                ExternalId = -7826829054039660530L,
            };
            mockGrpcClient.Setup(x => x.GetOfflineUserDataJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::OfflineUserDataJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::OfflineUserDataJob responseCallSettings = await client.GetOfflineUserDataJobAsync(request.ResourceNameAsOfflineUserDataJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::OfflineUserDataJob responseCancellationToken = await client.GetOfflineUserDataJobAsync(request.ResourceNameAsOfflineUserDataJobName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void AddOfflineUserDataJobOperationsRequestObject()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddOfflineUserDataJobOperationsRequest request = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Operations =
                {
                    new OfflineUserDataJobOperation(),
                },
                EnablePartialFailure = true,
            };
            AddOfflineUserDataJobOperationsResponse expectedResponse = new AddOfflineUserDataJobOperationsResponse
            {
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.AddOfflineUserDataJobOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            AddOfflineUserDataJobOperationsResponse response = client.AddOfflineUserDataJobOperations(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task AddOfflineUserDataJobOperationsRequestObjectAsync()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddOfflineUserDataJobOperationsRequest request = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Operations =
                {
                    new OfflineUserDataJobOperation(),
                },
                EnablePartialFailure = true,
            };
            AddOfflineUserDataJobOperationsResponse expectedResponse = new AddOfflineUserDataJobOperationsResponse
            {
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.AddOfflineUserDataJobOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddOfflineUserDataJobOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            AddOfflineUserDataJobOperationsResponse responseCallSettings = await client.AddOfflineUserDataJobOperationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            AddOfflineUserDataJobOperationsResponse responseCancellationToken = await client.AddOfflineUserDataJobOperationsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void AddOfflineUserDataJobOperations()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddOfflineUserDataJobOperationsRequest request = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Operations =
                {
                    new OfflineUserDataJobOperation(),
                },
            };
            AddOfflineUserDataJobOperationsResponse expectedResponse = new AddOfflineUserDataJobOperationsResponse
            {
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.AddOfflineUserDataJobOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            AddOfflineUserDataJobOperationsResponse response = client.AddOfflineUserDataJobOperations(request.ResourceName, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task AddOfflineUserDataJobOperationsAsync()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddOfflineUserDataJobOperationsRequest request = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Operations =
                {
                    new OfflineUserDataJobOperation(),
                },
            };
            AddOfflineUserDataJobOperationsResponse expectedResponse = new AddOfflineUserDataJobOperationsResponse
            {
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.AddOfflineUserDataJobOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddOfflineUserDataJobOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            AddOfflineUserDataJobOperationsResponse responseCallSettings = await client.AddOfflineUserDataJobOperationsAsync(request.ResourceName, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            AddOfflineUserDataJobOperationsResponse responseCancellationToken = await client.AddOfflineUserDataJobOperationsAsync(request.ResourceName, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void AddOfflineUserDataJobOperationsResourceNames()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddOfflineUserDataJobOperationsRequest request = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Operations =
                {
                    new OfflineUserDataJobOperation(),
                },
            };
            AddOfflineUserDataJobOperationsResponse expectedResponse = new AddOfflineUserDataJobOperationsResponse
            {
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.AddOfflineUserDataJobOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            AddOfflineUserDataJobOperationsResponse response = client.AddOfflineUserDataJobOperations(request.ResourceNameAsOfflineUserDataJobName, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task AddOfflineUserDataJobOperationsResourceNamesAsync()
        {
            moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new moq::Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddOfflineUserDataJobOperationsRequest request = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceNameAsOfflineUserDataJobName = gagvr::OfflineUserDataJobName.FromCustomerOfflineUserDataUpdate("[CUSTOMER_ID]", "[OFFLINE_USER_DATA_UPDATE_ID]"),
                Operations =
                {
                    new OfflineUserDataJobOperation(),
                },
            };
            AddOfflineUserDataJobOperationsResponse expectedResponse = new AddOfflineUserDataJobOperationsResponse
            {
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.AddOfflineUserDataJobOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddOfflineUserDataJobOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            AddOfflineUserDataJobOperationsResponse responseCallSettings = await client.AddOfflineUserDataJobOperationsAsync(request.ResourceNameAsOfflineUserDataJobName, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            AddOfflineUserDataJobOperationsResponse responseCancellationToken = await client.AddOfflineUserDataJobOperationsAsync(request.ResourceNameAsOfflineUserDataJobName, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

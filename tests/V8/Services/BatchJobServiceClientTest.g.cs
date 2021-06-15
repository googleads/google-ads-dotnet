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

using gagve = Google.Ads.GoogleAds.V8.Enums;
using gagvr = Google.Ads.GoogleAds.V8.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V8.Services;

namespace Google.Ads.GoogleAds.Tests.V8.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedBatchJobServiceClientTest
    {
        [Category("Smoke")][Test]
        public void MutateBatchJobRequestObject()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            MutateBatchJobRequest request = new MutateBatchJobRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new BatchJobOperation(),
            };
            MutateBatchJobResponse expectedResponse = new MutateBatchJobResponse
            {
                Result = new MutateBatchJobResult(),
            };
            mockGrpcClient.Setup(x => x.MutateBatchJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            MutateBatchJobResponse response = client.MutateBatchJob(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateBatchJobRequestObjectAsync()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            MutateBatchJobRequest request = new MutateBatchJobRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new BatchJobOperation(),
            };
            MutateBatchJobResponse expectedResponse = new MutateBatchJobResponse
            {
                Result = new MutateBatchJobResult(),
            };
            mockGrpcClient.Setup(x => x.MutateBatchJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateBatchJobResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            MutateBatchJobResponse responseCallSettings = await client.MutateBatchJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateBatchJobResponse responseCancellationToken = await client.MutateBatchJobAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateBatchJob()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            MutateBatchJobRequest request = new MutateBatchJobRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new BatchJobOperation(),
            };
            MutateBatchJobResponse expectedResponse = new MutateBatchJobResponse
            {
                Result = new MutateBatchJobResult(),
            };
            mockGrpcClient.Setup(x => x.MutateBatchJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            MutateBatchJobResponse response = client.MutateBatchJob(request.CustomerId, request.Operation);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateBatchJobAsync()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            MutateBatchJobRequest request = new MutateBatchJobRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operation = new BatchJobOperation(),
            };
            MutateBatchJobResponse expectedResponse = new MutateBatchJobResponse
            {
                Result = new MutateBatchJobResult(),
            };
            mockGrpcClient.Setup(x => x.MutateBatchJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateBatchJobResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            MutateBatchJobResponse responseCallSettings = await client.MutateBatchJobAsync(request.CustomerId, request.Operation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateBatchJobResponse responseCancellationToken = await client.MutateBatchJobAsync(request.CustomerId, request.Operation, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetBatchJobRequestObject()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchJobRequest request = new GetBatchJobRequest
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
            };
            gagvr::BatchJob expectedResponse = new gagvr::BatchJob
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
                Metadata = new gagvr::BatchJob.Types.BatchJobMetadata(),
                Status = gagve::BatchJobStatusEnum.Types.BatchJobStatus.Done,
                Id = -6774108720365892680L,
                NextAddSequenceToken = "next_add_sequence_token93fee49d",
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetBatchJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BatchJob response = client.GetBatchJob(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetBatchJobRequestObjectAsync()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchJobRequest request = new GetBatchJobRequest
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
            };
            gagvr::BatchJob expectedResponse = new gagvr::BatchJob
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
                Metadata = new gagvr::BatchJob.Types.BatchJobMetadata(),
                Status = gagve::BatchJobStatusEnum.Types.BatchJobStatus.Done,
                Id = -6774108720365892680L,
                NextAddSequenceToken = "next_add_sequence_token93fee49d",
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetBatchJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BatchJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BatchJob responseCallSettings = await client.GetBatchJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BatchJob responseCancellationToken = await client.GetBatchJobAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetBatchJob()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchJobRequest request = new GetBatchJobRequest
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
            };
            gagvr::BatchJob expectedResponse = new gagvr::BatchJob
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
                Metadata = new gagvr::BatchJob.Types.BatchJobMetadata(),
                Status = gagve::BatchJobStatusEnum.Types.BatchJobStatus.Done,
                Id = -6774108720365892680L,
                NextAddSequenceToken = "next_add_sequence_token93fee49d",
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetBatchJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BatchJob response = client.GetBatchJob(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetBatchJobAsync()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchJobRequest request = new GetBatchJobRequest
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
            };
            gagvr::BatchJob expectedResponse = new gagvr::BatchJob
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
                Metadata = new gagvr::BatchJob.Types.BatchJobMetadata(),
                Status = gagve::BatchJobStatusEnum.Types.BatchJobStatus.Done,
                Id = -6774108720365892680L,
                NextAddSequenceToken = "next_add_sequence_token93fee49d",
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetBatchJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BatchJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BatchJob responseCallSettings = await client.GetBatchJobAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BatchJob responseCancellationToken = await client.GetBatchJobAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetBatchJobResourceNames()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchJobRequest request = new GetBatchJobRequest
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
            };
            gagvr::BatchJob expectedResponse = new gagvr::BatchJob
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
                Metadata = new gagvr::BatchJob.Types.BatchJobMetadata(),
                Status = gagve::BatchJobStatusEnum.Types.BatchJobStatus.Done,
                Id = -6774108720365892680L,
                NextAddSequenceToken = "next_add_sequence_token93fee49d",
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetBatchJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BatchJob response = client.GetBatchJob(request.ResourceNameAsBatchJobName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetBatchJobResourceNamesAsync()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetBatchJobRequest request = new GetBatchJobRequest
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
            };
            gagvr::BatchJob expectedResponse = new gagvr::BatchJob
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
                Metadata = new gagvr::BatchJob.Types.BatchJobMetadata(),
                Status = gagve::BatchJobStatusEnum.Types.BatchJobStatus.Done,
                Id = -6774108720365892680L,
                NextAddSequenceToken = "next_add_sequence_token93fee49d",
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetBatchJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::BatchJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::BatchJob responseCallSettings = await client.GetBatchJobAsync(request.ResourceNameAsBatchJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::BatchJob responseCancellationToken = await client.GetBatchJobAsync(request.ResourceNameAsBatchJobName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void AddBatchJobOperationsRequestObject()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddBatchJobOperationsRequest request = new AddBatchJobOperationsRequest
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
                SequenceToken = "sequence_tokene6b46f6e",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddBatchJobOperationsResponse expectedResponse = new AddBatchJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddBatchJobOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            AddBatchJobOperationsResponse response = client.AddBatchJobOperations(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task AddBatchJobOperationsRequestObjectAsync()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddBatchJobOperationsRequest request = new AddBatchJobOperationsRequest
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
                SequenceToken = "sequence_tokene6b46f6e",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddBatchJobOperationsResponse expectedResponse = new AddBatchJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddBatchJobOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddBatchJobOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            AddBatchJobOperationsResponse responseCallSettings = await client.AddBatchJobOperationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            AddBatchJobOperationsResponse responseCancellationToken = await client.AddBatchJobOperationsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void AddBatchJobOperations1()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddBatchJobOperationsRequest request = new AddBatchJobOperationsRequest
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
                SequenceToken = "sequence_tokene6b46f6e",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddBatchJobOperationsResponse expectedResponse = new AddBatchJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddBatchJobOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            AddBatchJobOperationsResponse response = client.AddBatchJobOperations(request.ResourceName, request.SequenceToken, request.MutateOperations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task AddBatchJobOperations1Async()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddBatchJobOperationsRequest request = new AddBatchJobOperationsRequest
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
                SequenceToken = "sequence_tokene6b46f6e",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddBatchJobOperationsResponse expectedResponse = new AddBatchJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddBatchJobOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddBatchJobOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            AddBatchJobOperationsResponse responseCallSettings = await client.AddBatchJobOperationsAsync(request.ResourceName, request.SequenceToken, request.MutateOperations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            AddBatchJobOperationsResponse responseCancellationToken = await client.AddBatchJobOperationsAsync(request.ResourceName, request.SequenceToken, request.MutateOperations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void AddBatchJobOperations1ResourceNames()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddBatchJobOperationsRequest request = new AddBatchJobOperationsRequest
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
                SequenceToken = "sequence_tokene6b46f6e",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddBatchJobOperationsResponse expectedResponse = new AddBatchJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddBatchJobOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            AddBatchJobOperationsResponse response = client.AddBatchJobOperations(request.ResourceNameAsBatchJobName, request.SequenceToken, request.MutateOperations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task AddBatchJobOperations1ResourceNamesAsync()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddBatchJobOperationsRequest request = new AddBatchJobOperationsRequest
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
                SequenceToken = "sequence_tokene6b46f6e",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddBatchJobOperationsResponse expectedResponse = new AddBatchJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddBatchJobOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddBatchJobOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            AddBatchJobOperationsResponse responseCallSettings = await client.AddBatchJobOperationsAsync(request.ResourceNameAsBatchJobName, request.SequenceToken, request.MutateOperations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            AddBatchJobOperationsResponse responseCancellationToken = await client.AddBatchJobOperationsAsync(request.ResourceNameAsBatchJobName, request.SequenceToken, request.MutateOperations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void AddBatchJobOperations2()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddBatchJobOperationsRequest request = new AddBatchJobOperationsRequest
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddBatchJobOperationsResponse expectedResponse = new AddBatchJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddBatchJobOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            AddBatchJobOperationsResponse response = client.AddBatchJobOperations(request.ResourceName, request.MutateOperations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task AddBatchJobOperations2Async()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddBatchJobOperationsRequest request = new AddBatchJobOperationsRequest
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddBatchJobOperationsResponse expectedResponse = new AddBatchJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddBatchJobOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddBatchJobOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            AddBatchJobOperationsResponse responseCallSettings = await client.AddBatchJobOperationsAsync(request.ResourceName, request.MutateOperations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            AddBatchJobOperationsResponse responseCancellationToken = await client.AddBatchJobOperationsAsync(request.ResourceName, request.MutateOperations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void AddBatchJobOperations2ResourceNames()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddBatchJobOperationsRequest request = new AddBatchJobOperationsRequest
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddBatchJobOperationsResponse expectedResponse = new AddBatchJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddBatchJobOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            AddBatchJobOperationsResponse response = client.AddBatchJobOperations(request.ResourceNameAsBatchJobName, request.MutateOperations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task AddBatchJobOperations2ResourceNamesAsync()
        {
            moq::Mock<BatchJobService.BatchJobServiceClient> mockGrpcClient = new moq::Mock<BatchJobService.BatchJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddBatchJobOperationsRequest request = new AddBatchJobOperationsRequest
            {
                ResourceNameAsBatchJobName = gagvr::BatchJobName.FromCustomerBatchJob("[CUSTOMER_ID]", "[BATCH_JOB_ID]"),
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddBatchJobOperationsResponse expectedResponse = new AddBatchJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddBatchJobOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddBatchJobOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            BatchJobServiceClient client = new BatchJobServiceClientImpl(mockGrpcClient.Object, null);
            AddBatchJobOperationsResponse responseCallSettings = await client.AddBatchJobOperationsAsync(request.ResourceNameAsBatchJobName, request.MutateOperations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            AddBatchJobOperationsResponse responseCancellationToken = await client.AddBatchJobOperationsAsync(request.ResourceNameAsBatchJobName, request.MutateOperations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

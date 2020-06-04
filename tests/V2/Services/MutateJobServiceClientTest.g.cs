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
using lro = Google.LongRunning;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V2.Services;

namespace Google.Ads.GoogleAds.Tests.V2.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedMutateJobServiceClientTest
    {
        [Test]
        public void CreateMutateJobRequestObject()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMutateJobRequest request = new CreateMutateJobRequest
            {
                CustomerId = "customer_id3b3724cb",
            };
            CreateMutateJobResponse expectedResponse = new CreateMutateJobResponse
            {
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.CreateMutateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            CreateMutateJobResponse response = client.CreateMutateJob(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task CreateMutateJobRequestObjectAsync()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMutateJobRequest request = new CreateMutateJobRequest
            {
                CustomerId = "customer_id3b3724cb",
            };
            CreateMutateJobResponse expectedResponse = new CreateMutateJobResponse
            {
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.CreateMutateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CreateMutateJobResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            CreateMutateJobResponse responseCallSettings = await client.CreateMutateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            CreateMutateJobResponse responseCancellationToken = await client.CreateMutateJobAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void CreateMutateJob()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMutateJobRequest request = new CreateMutateJobRequest
            {
                CustomerId = "customer_id3b3724cb",
            };
            CreateMutateJobResponse expectedResponse = new CreateMutateJobResponse
            {
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.CreateMutateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            CreateMutateJobResponse response = client.CreateMutateJob(request.CustomerId);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task CreateMutateJobAsync()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateMutateJobRequest request = new CreateMutateJobRequest
            {
                CustomerId = "customer_id3b3724cb",
            };
            CreateMutateJobResponse expectedResponse = new CreateMutateJobResponse
            {
                ResourceName = "resource_name8cc2e687",
            };
            mockGrpcClient.Setup(x => x.CreateMutateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CreateMutateJobResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            CreateMutateJobResponse responseCallSettings = await client.CreateMutateJobAsync(request.CustomerId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            CreateMutateJobResponse responseCancellationToken = await client.CreateMutateJobAsync(request.CustomerId, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetMutateJobRequestObject()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMutateJobRequest request = new GetMutateJobRequest
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
            };
            gagvr::MutateJob expectedResponse = new gagvr::MutateJob
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
                Id = -6774108720365892680L,
                NextAddSequenceToken = "next_add_sequence_token93fee49d",
                Metadata = new gagvr::MutateJob.Types.MutateJobMetadata(),
                Status = gagve::MutateJobStatusEnum.Types.MutateJobStatus.Done,
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetMutateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MutateJob response = client.GetMutateJob(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetMutateJobRequestObjectAsync()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMutateJobRequest request = new GetMutateJobRequest
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
            };
            gagvr::MutateJob expectedResponse = new gagvr::MutateJob
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
                Id = -6774108720365892680L,
                NextAddSequenceToken = "next_add_sequence_token93fee49d",
                Metadata = new gagvr::MutateJob.Types.MutateJobMetadata(),
                Status = gagve::MutateJobStatusEnum.Types.MutateJobStatus.Done,
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetMutateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::MutateJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MutateJob responseCallSettings = await client.GetMutateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::MutateJob responseCancellationToken = await client.GetMutateJobAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetMutateJob()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMutateJobRequest request = new GetMutateJobRequest
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
            };
            gagvr::MutateJob expectedResponse = new gagvr::MutateJob
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
                Id = -6774108720365892680L,
                NextAddSequenceToken = "next_add_sequence_token93fee49d",
                Metadata = new gagvr::MutateJob.Types.MutateJobMetadata(),
                Status = gagve::MutateJobStatusEnum.Types.MutateJobStatus.Done,
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetMutateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MutateJob response = client.GetMutateJob(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetMutateJobAsync()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMutateJobRequest request = new GetMutateJobRequest
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
            };
            gagvr::MutateJob expectedResponse = new gagvr::MutateJob
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
                Id = -6774108720365892680L,
                NextAddSequenceToken = "next_add_sequence_token93fee49d",
                Metadata = new gagvr::MutateJob.Types.MutateJobMetadata(),
                Status = gagve::MutateJobStatusEnum.Types.MutateJobStatus.Done,
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetMutateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::MutateJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MutateJob responseCallSettings = await client.GetMutateJobAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::MutateJob responseCancellationToken = await client.GetMutateJobAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetMutateJobResourceNames()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMutateJobRequest request = new GetMutateJobRequest
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
            };
            gagvr::MutateJob expectedResponse = new gagvr::MutateJob
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
                Id = -6774108720365892680L,
                NextAddSequenceToken = "next_add_sequence_token93fee49d",
                Metadata = new gagvr::MutateJob.Types.MutateJobMetadata(),
                Status = gagve::MutateJobStatusEnum.Types.MutateJobStatus.Done,
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetMutateJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MutateJob response = client.GetMutateJob(request.ResourceNameAsMutateJobName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetMutateJobResourceNamesAsync()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetMutateJobRequest request = new GetMutateJobRequest
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
            };
            gagvr::MutateJob expectedResponse = new gagvr::MutateJob
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
                Id = -6774108720365892680L,
                NextAddSequenceToken = "next_add_sequence_token93fee49d",
                Metadata = new gagvr::MutateJob.Types.MutateJobMetadata(),
                Status = gagve::MutateJobStatusEnum.Types.MutateJobStatus.Done,
                LongRunningOperation = "long_running_operation0897bd41",
            };
            mockGrpcClient.Setup(x => x.GetMutateJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::MutateJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::MutateJob responseCallSettings = await client.GetMutateJobAsync(request.ResourceNameAsMutateJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::MutateJob responseCancellationToken = await client.GetMutateJobAsync(request.ResourceNameAsMutateJobName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void AddMutateJobOperationsRequestObject()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddMutateJobOperationsRequest request = new AddMutateJobOperationsRequest
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
                SequenceToken = "sequence_tokene6b46f6e",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddMutateJobOperationsResponse expectedResponse = new AddMutateJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddMutateJobOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            AddMutateJobOperationsResponse response = client.AddMutateJobOperations(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task AddMutateJobOperationsRequestObjectAsync()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddMutateJobOperationsRequest request = new AddMutateJobOperationsRequest
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
                SequenceToken = "sequence_tokene6b46f6e",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddMutateJobOperationsResponse expectedResponse = new AddMutateJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddMutateJobOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddMutateJobOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            AddMutateJobOperationsResponse responseCallSettings = await client.AddMutateJobOperationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            AddMutateJobOperationsResponse responseCancellationToken = await client.AddMutateJobOperationsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void AddMutateJobOperations1()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddMutateJobOperationsRequest request = new AddMutateJobOperationsRequest
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
                SequenceToken = "sequence_tokene6b46f6e",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddMutateJobOperationsResponse expectedResponse = new AddMutateJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddMutateJobOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            AddMutateJobOperationsResponse response = client.AddMutateJobOperations(request.ResourceName, request.SequenceToken, request.MutateOperations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task AddMutateJobOperations1Async()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddMutateJobOperationsRequest request = new AddMutateJobOperationsRequest
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
                SequenceToken = "sequence_tokene6b46f6e",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddMutateJobOperationsResponse expectedResponse = new AddMutateJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddMutateJobOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddMutateJobOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            AddMutateJobOperationsResponse responseCallSettings = await client.AddMutateJobOperationsAsync(request.ResourceName, request.SequenceToken, request.MutateOperations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            AddMutateJobOperationsResponse responseCancellationToken = await client.AddMutateJobOperationsAsync(request.ResourceName, request.SequenceToken, request.MutateOperations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void AddMutateJobOperations1ResourceNames()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddMutateJobOperationsRequest request = new AddMutateJobOperationsRequest
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
                SequenceToken = "sequence_tokene6b46f6e",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddMutateJobOperationsResponse expectedResponse = new AddMutateJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddMutateJobOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            AddMutateJobOperationsResponse response = client.AddMutateJobOperations(request.ResourceNameAsMutateJobName, request.SequenceToken, request.MutateOperations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task AddMutateJobOperations1ResourceNamesAsync()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddMutateJobOperationsRequest request = new AddMutateJobOperationsRequest
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
                SequenceToken = "sequence_tokene6b46f6e",
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddMutateJobOperationsResponse expectedResponse = new AddMutateJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddMutateJobOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddMutateJobOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            AddMutateJobOperationsResponse responseCallSettings = await client.AddMutateJobOperationsAsync(request.ResourceNameAsMutateJobName, request.SequenceToken, request.MutateOperations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            AddMutateJobOperationsResponse responseCancellationToken = await client.AddMutateJobOperationsAsync(request.ResourceNameAsMutateJobName, request.SequenceToken, request.MutateOperations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void AddMutateJobOperations2()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddMutateJobOperationsRequest request = new AddMutateJobOperationsRequest
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddMutateJobOperationsResponse expectedResponse = new AddMutateJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddMutateJobOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            AddMutateJobOperationsResponse response = client.AddMutateJobOperations(request.ResourceName, request.MutateOperations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task AddMutateJobOperations2Async()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddMutateJobOperationsRequest request = new AddMutateJobOperationsRequest
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddMutateJobOperationsResponse expectedResponse = new AddMutateJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddMutateJobOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddMutateJobOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            AddMutateJobOperationsResponse responseCallSettings = await client.AddMutateJobOperationsAsync(request.ResourceName, request.MutateOperations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            AddMutateJobOperationsResponse responseCancellationToken = await client.AddMutateJobOperationsAsync(request.ResourceName, request.MutateOperations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void AddMutateJobOperations2ResourceNames()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddMutateJobOperationsRequest request = new AddMutateJobOperationsRequest
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddMutateJobOperationsResponse expectedResponse = new AddMutateJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddMutateJobOperations(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            AddMutateJobOperationsResponse response = client.AddMutateJobOperations(request.ResourceNameAsMutateJobName, request.MutateOperations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task AddMutateJobOperations2ResourceNamesAsync()
        {
            moq::Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new moq::Mock<MutateJobService.MutateJobServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddMutateJobOperationsRequest request = new AddMutateJobOperationsRequest
            {
                ResourceNameAsMutateJobName = gagvr::MutateJobName.FromCustomerMutateJob("[CUSTOMER]", "[MUTATE_JOB]"),
                MutateOperations =
                {
                    new MutateOperation(),
                },
            };
            AddMutateJobOperationsResponse expectedResponse = new AddMutateJobOperationsResponse
            {
                TotalOperations = -8188520186954789005L,
                NextSequenceToken = "next_sequence_token160dabc7",
            };
            mockGrpcClient.Setup(x => x.AddMutateJobOperationsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AddMutateJobOperationsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            AddMutateJobOperationsResponse responseCallSettings = await client.AddMutateJobOperationsAsync(request.ResourceNameAsMutateJobName, request.MutateOperations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            AddMutateJobOperationsResponse responseCancellationToken = await client.AddMutateJobOperationsAsync(request.ResourceNameAsMutateJobName, request.MutateOperations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

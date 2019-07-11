// Copyright 2019 Google LLC
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

namespace Google.Ads.GoogleAds.V2.Services.Tests
{
    using Google.Ads.GoogleAds.V2.Resources;
    using apis = Google.Ads.GoogleAds.V2.Services;
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using NUnit.Framework;

    /// <summary>Generated unit tests</summary>
    public class GeneratedMutateJobServiceClientTest
    {
        [Test]
        public void CreateMutateJob()
        {
            Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new Mock<MutateJobService.MutateJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateMutateJobRequest expectedRequest = new CreateMutateJobRequest
            {
                CustomerId = "customerId-1772061412",
            };
            CreateMutateJobResponse expectedResponse = new CreateMutateJobResponse
            {
                ResourceName = "resourceName979421212",
            };
            mockGrpcClient.Setup(x => x.CreateMutateJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            CreateMutateJobResponse response = client.CreateMutateJob(customerId);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task CreateMutateJobAsync()
        {
            Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new Mock<MutateJobService.MutateJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateMutateJobRequest expectedRequest = new CreateMutateJobRequest
            {
                CustomerId = "customerId-1772061412",
            };
            CreateMutateJobResponse expectedResponse = new CreateMutateJobResponse
            {
                ResourceName = "resourceName979421212",
            };
            mockGrpcClient.Setup(x => x.CreateMutateJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CreateMutateJobResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            CreateMutateJobResponse response = await client.CreateMutateJobAsync(customerId);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void CreateMutateJob2()
        {
            Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new Mock<MutateJobService.MutateJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateMutateJobRequest request = new CreateMutateJobRequest
            {
                CustomerId = "customerId-1772061412",
            };
            CreateMutateJobResponse expectedResponse = new CreateMutateJobResponse
            {
                ResourceName = "resourceName979421212",
            };
            mockGrpcClient.Setup(x => x.CreateMutateJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            CreateMutateJobResponse response = client.CreateMutateJob(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task CreateMutateJobAsync2()
        {
            Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new Mock<MutateJobService.MutateJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateMutateJobRequest request = new CreateMutateJobRequest
            {
                CustomerId = "customerId-1772061412",
            };
            CreateMutateJobResponse expectedResponse = new CreateMutateJobResponse
            {
                ResourceName = "resourceName979421212",
            };
            mockGrpcClient.Setup(x => x.CreateMutateJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CreateMutateJobResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            CreateMutateJobResponse response = await client.CreateMutateJobAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetMutateJob()
        {
            Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new Mock<MutateJobService.MutateJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetMutateJobRequest expectedRequest = new GetMutateJobRequest
            {
                ResourceName = new MutateJobName("[CUSTOMER]", "[MUTATE_JOB]").ToString(),
            };
            MutateJob expectedResponse = new MutateJob
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMutateJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new MutateJobName("[CUSTOMER]", "[MUTATE_JOB]").ToString();
            MutateJob response = client.GetMutateJob(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetMutateJobAsync()
        {
            Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new Mock<MutateJobService.MutateJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetMutateJobRequest expectedRequest = new GetMutateJobRequest
            {
                ResourceName = new MutateJobName("[CUSTOMER]", "[MUTATE_JOB]").ToString(),
            };
            MutateJob expectedResponse = new MutateJob
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMutateJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateJob>(Task.FromResult(expectedResponse), null, null, null, null));
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new MutateJobName("[CUSTOMER]", "[MUTATE_JOB]").ToString();
            MutateJob response = await client.GetMutateJobAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetMutateJob2()
        {
            Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new Mock<MutateJobService.MutateJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetMutateJobRequest request = new GetMutateJobRequest
            {
                ResourceName = new MutateJobName("[CUSTOMER]", "[MUTATE_JOB]").ToString(),
            };
            MutateJob expectedResponse = new MutateJob
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMutateJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            MutateJob response = client.GetMutateJob(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetMutateJobAsync2()
        {
            Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new Mock<MutateJobService.MutateJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetMutateJobRequest request = new GetMutateJobRequest
            {
                ResourceName = new MutateJobName("[CUSTOMER]", "[MUTATE_JOB]").ToString(),
            };
            MutateJob expectedResponse = new MutateJob
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMutateJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateJob>(Task.FromResult(expectedResponse), null, null, null, null));
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            MutateJob response = await client.GetMutateJobAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void AddMutateJobOperations()
        {
            Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new Mock<MutateJobService.MutateJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            AddMutateJobOperationsRequest expectedRequest = new AddMutateJobOperationsRequest
            {
                ResourceName = new MutateJobName("[CUSTOMER]", "[MUTATE_JOB]").ToString(),
                SequenceToken = "sequenceToken-868155397",
                MutateOperations = { },
            };
            AddMutateJobOperationsResponse expectedResponse = new AddMutateJobOperationsResponse
            {
                TotalOperations = 1685086151L,
                NextSequenceToken = "nextSequenceToken388644551",
            };
            mockGrpcClient.Setup(x => x.AddMutateJobOperations(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new MutateJobName("[CUSTOMER]", "[MUTATE_JOB]").ToString();
            string sequenceToken = "sequenceToken-868155397";
            IEnumerable<MutateOperation> mutateOperations = new List<MutateOperation>();
            AddMutateJobOperationsResponse response = client.AddMutateJobOperations(formattedResourceName, sequenceToken, mutateOperations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task AddMutateJobOperationsAsync()
        {
            Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new Mock<MutateJobService.MutateJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            AddMutateJobOperationsRequest expectedRequest = new AddMutateJobOperationsRequest
            {
                ResourceName = new MutateJobName("[CUSTOMER]", "[MUTATE_JOB]").ToString(),
                SequenceToken = "sequenceToken-868155397",
                MutateOperations = { },
            };
            AddMutateJobOperationsResponse expectedResponse = new AddMutateJobOperationsResponse
            {
                TotalOperations = 1685086151L,
                NextSequenceToken = "nextSequenceToken388644551",
            };
            mockGrpcClient.Setup(x => x.AddMutateJobOperationsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AddMutateJobOperationsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new MutateJobName("[CUSTOMER]", "[MUTATE_JOB]").ToString();
            string sequenceToken = "sequenceToken-868155397";
            IEnumerable<MutateOperation> mutateOperations = new List<MutateOperation>();
            AddMutateJobOperationsResponse response = await client.AddMutateJobOperationsAsync(formattedResourceName, sequenceToken, mutateOperations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void AddMutateJobOperations2()
        {
            Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new Mock<MutateJobService.MutateJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            AddMutateJobOperationsRequest request = new AddMutateJobOperationsRequest
            {
                ResourceName = new MutateJobName("[CUSTOMER]", "[MUTATE_JOB]").ToString(),
                SequenceToken = "sequenceToken-868155397",
                MutateOperations = { },
            };
            AddMutateJobOperationsResponse expectedResponse = new AddMutateJobOperationsResponse
            {
                TotalOperations = 1685086151L,
                NextSequenceToken = "nextSequenceToken388644551",
            };
            mockGrpcClient.Setup(x => x.AddMutateJobOperations(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            AddMutateJobOperationsResponse response = client.AddMutateJobOperations(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task AddMutateJobOperationsAsync2()
        {
            Mock<MutateJobService.MutateJobServiceClient> mockGrpcClient = new Mock<MutateJobService.MutateJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            AddMutateJobOperationsRequest request = new AddMutateJobOperationsRequest
            {
                ResourceName = new MutateJobName("[CUSTOMER]", "[MUTATE_JOB]").ToString(),
                SequenceToken = "sequenceToken-868155397",
                MutateOperations = { },
            };
            AddMutateJobOperationsResponse expectedResponse = new AddMutateJobOperationsResponse
            {
                TotalOperations = 1685086151L,
                NextSequenceToken = "nextSequenceToken388644551",
            };
            mockGrpcClient.Setup(x => x.AddMutateJobOperationsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AddMutateJobOperationsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            MutateJobServiceClient client = new MutateJobServiceClientImpl(mockGrpcClient.Object, null);
            AddMutateJobOperationsResponse response = await client.AddMutateJobOperationsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

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

namespace Google.Ads.GoogleAds.V3.Services.Tests
{
    using Google.Ads.GoogleAds.V3.Resources;
    using apis = Google.Ads.GoogleAds.V3.Services;
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
    public class GeneratedOfflineUserDataJobServiceClientTest
    {
        [Test]
        public void CreateOfflineUserDataJob()
        {
            Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateOfflineUserDataJobRequest expectedRequest = new CreateOfflineUserDataJobRequest
            {
                CustomerId = "customerId-1772061412",
                Job = new OfflineUserDataJob(),
            };
            CreateOfflineUserDataJobResponse expectedResponse = new CreateOfflineUserDataJobResponse
            {
                ResourceName = "resourceName979421212",
            };
            mockGrpcClient.Setup(x => x.CreateOfflineUserDataJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            OfflineUserDataJob job = new OfflineUserDataJob();
            CreateOfflineUserDataJobResponse response = client.CreateOfflineUserDataJob(customerId, job);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task CreateOfflineUserDataJobAsync()
        {
            Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateOfflineUserDataJobRequest expectedRequest = new CreateOfflineUserDataJobRequest
            {
                CustomerId = "customerId-1772061412",
                Job = new OfflineUserDataJob(),
            };
            CreateOfflineUserDataJobResponse expectedResponse = new CreateOfflineUserDataJobResponse
            {
                ResourceName = "resourceName979421212",
            };
            mockGrpcClient.Setup(x => x.CreateOfflineUserDataJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CreateOfflineUserDataJobResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            OfflineUserDataJob job = new OfflineUserDataJob();
            CreateOfflineUserDataJobResponse response = await client.CreateOfflineUserDataJobAsync(customerId, job);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void CreateOfflineUserDataJob2()
        {
            Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateOfflineUserDataJobRequest request = new CreateOfflineUserDataJobRequest
            {
                CustomerId = "customerId-1772061412",
                Job = new OfflineUserDataJob(),
            };
            CreateOfflineUserDataJobResponse expectedResponse = new CreateOfflineUserDataJobResponse
            {
                ResourceName = "resourceName979421212",
            };
            mockGrpcClient.Setup(x => x.CreateOfflineUserDataJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            CreateOfflineUserDataJobResponse response = client.CreateOfflineUserDataJob(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task CreateOfflineUserDataJobAsync2()
        {
            Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateOfflineUserDataJobRequest request = new CreateOfflineUserDataJobRequest
            {
                CustomerId = "customerId-1772061412",
                Job = new OfflineUserDataJob(),
            };
            CreateOfflineUserDataJobResponse expectedResponse = new CreateOfflineUserDataJobResponse
            {
                ResourceName = "resourceName979421212",
            };
            mockGrpcClient.Setup(x => x.CreateOfflineUserDataJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CreateOfflineUserDataJobResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            CreateOfflineUserDataJobResponse response = await client.CreateOfflineUserDataJobAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetOfflineUserDataJob()
        {
            Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetOfflineUserDataJobRequest expectedRequest = new GetOfflineUserDataJobRequest
            {
                ResourceName = new OfflineUserDataJobName("[CUSTOMER]", "[OFFLINE_USER_DATA_JOB]").ToString(),
            };
            OfflineUserDataJob expectedResponse = new OfflineUserDataJob
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetOfflineUserDataJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new OfflineUserDataJobName("[CUSTOMER]", "[OFFLINE_USER_DATA_JOB]").ToString();
            OfflineUserDataJob response = client.GetOfflineUserDataJob(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetOfflineUserDataJobAsync()
        {
            Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetOfflineUserDataJobRequest expectedRequest = new GetOfflineUserDataJobRequest
            {
                ResourceName = new OfflineUserDataJobName("[CUSTOMER]", "[OFFLINE_USER_DATA_JOB]").ToString(),
            };
            OfflineUserDataJob expectedResponse = new OfflineUserDataJob
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetOfflineUserDataJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<OfflineUserDataJob>(Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new OfflineUserDataJobName("[CUSTOMER]", "[OFFLINE_USER_DATA_JOB]").ToString();
            OfflineUserDataJob response = await client.GetOfflineUserDataJobAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetOfflineUserDataJob2()
        {
            Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetOfflineUserDataJobRequest request = new GetOfflineUserDataJobRequest
            {
                ResourceName = new OfflineUserDataJobName("[CUSTOMER]", "[OFFLINE_USER_DATA_JOB]").ToString(),
            };
            OfflineUserDataJob expectedResponse = new OfflineUserDataJob
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetOfflineUserDataJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            OfflineUserDataJob response = client.GetOfflineUserDataJob(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetOfflineUserDataJobAsync2()
        {
            Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetOfflineUserDataJobRequest request = new GetOfflineUserDataJobRequest
            {
                ResourceName = new OfflineUserDataJobName("[CUSTOMER]", "[OFFLINE_USER_DATA_JOB]").ToString(),
            };
            OfflineUserDataJob expectedResponse = new OfflineUserDataJob
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetOfflineUserDataJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<OfflineUserDataJob>(Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            OfflineUserDataJob response = await client.GetOfflineUserDataJobAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void AddOfflineUserDataJobOperations()
        {
            Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            AddOfflineUserDataJobOperationsRequest expectedRequest = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceName = new OfflineUserDataJobName("[CUSTOMER]", "[OFFLINE_USER_DATA_JOB]").ToString(),
                EnablePartialFailure = null,
                Operations = { },
            };
            AddOfflineUserDataJobOperationsResponse expectedResponse = new AddOfflineUserDataJobOperationsResponse();
            mockGrpcClient.Setup(x => x.AddOfflineUserDataJobOperations(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new OfflineUserDataJobName("[CUSTOMER]", "[OFFLINE_USER_DATA_JOB]").ToString();
            bool? enablePartialFailure = null;
            IEnumerable<OfflineUserDataJobOperation> operations = new List<OfflineUserDataJobOperation>();
            AddOfflineUserDataJobOperationsResponse response = client.AddOfflineUserDataJobOperations(formattedResourceName, enablePartialFailure, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task AddOfflineUserDataJobOperationsAsync()
        {
            Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            AddOfflineUserDataJobOperationsRequest expectedRequest = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceName = new OfflineUserDataJobName("[CUSTOMER]", "[OFFLINE_USER_DATA_JOB]").ToString(),
                EnablePartialFailure = null,
                Operations = { },
            };
            AddOfflineUserDataJobOperationsResponse expectedResponse = new AddOfflineUserDataJobOperationsResponse();
            mockGrpcClient.Setup(x => x.AddOfflineUserDataJobOperationsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AddOfflineUserDataJobOperationsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new OfflineUserDataJobName("[CUSTOMER]", "[OFFLINE_USER_DATA_JOB]").ToString();
            bool? enablePartialFailure = null;
            IEnumerable<OfflineUserDataJobOperation> operations = new List<OfflineUserDataJobOperation>();
            AddOfflineUserDataJobOperationsResponse response = await client.AddOfflineUserDataJobOperationsAsync(formattedResourceName, enablePartialFailure, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void AddOfflineUserDataJobOperations2()
        {
            Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            AddOfflineUserDataJobOperationsRequest request = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceName = new OfflineUserDataJobName("[CUSTOMER]", "[OFFLINE_USER_DATA_JOB]").ToString(),
                EnablePartialFailure = null,
                Operations = { },
            };
            AddOfflineUserDataJobOperationsResponse expectedResponse = new AddOfflineUserDataJobOperationsResponse();
            mockGrpcClient.Setup(x => x.AddOfflineUserDataJobOperations(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            AddOfflineUserDataJobOperationsResponse response = client.AddOfflineUserDataJobOperations(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task AddOfflineUserDataJobOperationsAsync2()
        {
            Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient> mockGrpcClient = new Mock<OfflineUserDataJobService.OfflineUserDataJobServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            AddOfflineUserDataJobOperationsRequest request = new AddOfflineUserDataJobOperationsRequest
            {
                ResourceName = new OfflineUserDataJobName("[CUSTOMER]", "[OFFLINE_USER_DATA_JOB]").ToString(),
                EnablePartialFailure = null,
                Operations = { },
            };
            AddOfflineUserDataJobOperationsResponse expectedResponse = new AddOfflineUserDataJobOperationsResponse();
            mockGrpcClient.Setup(x => x.AddOfflineUserDataJobOperationsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AddOfflineUserDataJobOperationsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            OfflineUserDataJobServiceClient client = new OfflineUserDataJobServiceClientImpl(mockGrpcClient.Object, null);
            AddOfflineUserDataJobOperationsResponse response = await client.AddOfflineUserDataJobOperationsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

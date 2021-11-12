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

using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V9.Services;

namespace Google.Ads.GoogleAds.Tests.V9.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCustomerConversionGoalServiceClientTest
    {
        [Category("Smoke")][Test]
        public void MutateCustomerConversionGoalsRequestObject()
        {
            moq::Mock<CustomerConversionGoalService.CustomerConversionGoalServiceClient> mockGrpcClient = new moq::Mock<CustomerConversionGoalService.CustomerConversionGoalServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerConversionGoalsRequest request = new MutateCustomerConversionGoalsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerConversionGoalOperation(),
                },
                ValidateOnly = true,
            };
            MutateCustomerConversionGoalsResponse expectedResponse = new MutateCustomerConversionGoalsResponse
            {
                Results =
                {
                    new MutateCustomerConversionGoalResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomerConversionGoals(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerConversionGoalServiceClient client = new CustomerConversionGoalServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerConversionGoalsResponse response = client.MutateCustomerConversionGoals(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerConversionGoalsRequestObjectAsync()
        {
            moq::Mock<CustomerConversionGoalService.CustomerConversionGoalServiceClient> mockGrpcClient = new moq::Mock<CustomerConversionGoalService.CustomerConversionGoalServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerConversionGoalsRequest request = new MutateCustomerConversionGoalsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerConversionGoalOperation(),
                },
                ValidateOnly = true,
            };
            MutateCustomerConversionGoalsResponse expectedResponse = new MutateCustomerConversionGoalsResponse
            {
                Results =
                {
                    new MutateCustomerConversionGoalResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomerConversionGoalsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerConversionGoalsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerConversionGoalServiceClient client = new CustomerConversionGoalServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerConversionGoalsResponse responseCallSettings = await client.MutateCustomerConversionGoalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerConversionGoalsResponse responseCancellationToken = await client.MutateCustomerConversionGoalsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void MutateCustomerConversionGoals()
        {
            moq::Mock<CustomerConversionGoalService.CustomerConversionGoalServiceClient> mockGrpcClient = new moq::Mock<CustomerConversionGoalService.CustomerConversionGoalServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerConversionGoalsRequest request = new MutateCustomerConversionGoalsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerConversionGoalOperation(),
                },
            };
            MutateCustomerConversionGoalsResponse expectedResponse = new MutateCustomerConversionGoalsResponse
            {
                Results =
                {
                    new MutateCustomerConversionGoalResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomerConversionGoals(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerConversionGoalServiceClient client = new CustomerConversionGoalServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerConversionGoalsResponse response = client.MutateCustomerConversionGoals(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task MutateCustomerConversionGoalsAsync()
        {
            moq::Mock<CustomerConversionGoalService.CustomerConversionGoalServiceClient> mockGrpcClient = new moq::Mock<CustomerConversionGoalService.CustomerConversionGoalServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerConversionGoalsRequest request = new MutateCustomerConversionGoalsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerConversionGoalOperation(),
                },
            };
            MutateCustomerConversionGoalsResponse expectedResponse = new MutateCustomerConversionGoalsResponse
            {
                Results =
                {
                    new MutateCustomerConversionGoalResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomerConversionGoalsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerConversionGoalsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerConversionGoalServiceClient client = new CustomerConversionGoalServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerConversionGoalsResponse responseCallSettings = await client.MutateCustomerConversionGoalsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerConversionGoalsResponse responseCancellationToken = await client.MutateCustomerConversionGoalsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

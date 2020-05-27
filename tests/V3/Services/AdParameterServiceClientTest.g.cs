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
    public class GeneratedAdParameterServiceClientTest
    {
        [Test]
        public void GetAdParameter()
        {
            Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new Mock<AdParameterService.AdParameterServiceClient>(MockBehavior.Strict);
            GetAdParameterRequest expectedRequest = new GetAdParameterRequest
            {
                ResourceName = new AdParameterName("[CUSTOMER]", "[AD_PARAMETER]").ToString(),
            };
            AdParameter expectedResponse = new AdParameter
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdParameter(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdParameterName("[CUSTOMER]", "[AD_PARAMETER]").ToString();
            AdParameter response = client.GetAdParameter(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdParameterAsync()
        {
            Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new Mock<AdParameterService.AdParameterServiceClient>(MockBehavior.Strict);
            GetAdParameterRequest expectedRequest = new GetAdParameterRequest
            {
                ResourceName = new AdParameterName("[CUSTOMER]", "[AD_PARAMETER]").ToString(),
            };
            AdParameter expectedResponse = new AdParameter
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdParameterAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdParameter>(Task.FromResult(expectedResponse), null, null, null, null));
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AdParameterName("[CUSTOMER]", "[AD_PARAMETER]").ToString();
            AdParameter response = await client.GetAdParameterAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAdParameter2()
        {
            Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new Mock<AdParameterService.AdParameterServiceClient>(MockBehavior.Strict);
            GetAdParameterRequest request = new GetAdParameterRequest
            {
                ResourceName = new AdParameterName("[CUSTOMER]", "[AD_PARAMETER]").ToString(),
            };
            AdParameter expectedResponse = new AdParameter
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdParameter(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            AdParameter response = client.GetAdParameter(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAdParameterAsync2()
        {
            Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new Mock<AdParameterService.AdParameterServiceClient>(MockBehavior.Strict);
            GetAdParameterRequest request = new GetAdParameterRequest
            {
                ResourceName = new AdParameterName("[CUSTOMER]", "[AD_PARAMETER]").ToString(),
            };
            AdParameter expectedResponse = new AdParameter
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAdParameterAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AdParameter>(Task.FromResult(expectedResponse), null, null, null, null));
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            AdParameter response = await client.GetAdParameterAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdParameters()
        {
            Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new Mock<AdParameterService.AdParameterServiceClient>(MockBehavior.Strict);
            MutateAdParametersRequest expectedRequest = new MutateAdParametersRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdParametersResponse expectedResponse = new MutateAdParametersResponse();
            mockGrpcClient.Setup(x => x.MutateAdParameters(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdParameterOperation> operations = new List<AdParameterOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdParametersResponse response = client.MutateAdParameters(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdParametersAsync()
        {
            Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new Mock<AdParameterService.AdParameterServiceClient>(MockBehavior.Strict);
            MutateAdParametersRequest expectedRequest = new MutateAdParametersRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdParametersResponse expectedResponse = new MutateAdParametersResponse();
            mockGrpcClient.Setup(x => x.MutateAdParametersAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdParametersResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdParameterOperation> operations = new List<AdParameterOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdParametersResponse response = await client.MutateAdParametersAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdParameters2()
        {
            Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new Mock<AdParameterService.AdParameterServiceClient>(MockBehavior.Strict);
            MutateAdParametersRequest expectedRequest = new MutateAdParametersRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdParametersResponse expectedResponse = new MutateAdParametersResponse();
            mockGrpcClient.Setup(x => x.MutateAdParameters(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdParameterOperation> operations = new List<AdParameterOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdParametersResponse response = client.MutateAdParameters(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdParametersAsync2()
        {
            Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new Mock<AdParameterService.AdParameterServiceClient>(MockBehavior.Strict);
            MutateAdParametersRequest expectedRequest = new MutateAdParametersRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
                PartialFailure = true,
                ValidateOnly = false,
            };
            MutateAdParametersResponse expectedResponse = new MutateAdParametersResponse();
            mockGrpcClient.Setup(x => x.MutateAdParametersAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdParametersResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AdParameterOperation> operations = new List<AdParameterOperation>();
            bool partialFailure = true;
            bool validateOnly = false;
            MutateAdParametersResponse response = await client.MutateAdParametersAsync(customerId, operations, partialFailure, validateOnly);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAdParameters3()
        {
            Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new Mock<AdParameterService.AdParameterServiceClient>(MockBehavior.Strict);
            MutateAdParametersRequest request = new MutateAdParametersRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdParametersResponse expectedResponse = new MutateAdParametersResponse();
            mockGrpcClient.Setup(x => x.MutateAdParameters(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdParametersResponse response = client.MutateAdParameters(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAdParametersAsync3()
        {
            Mock<AdParameterService.AdParameterServiceClient> mockGrpcClient = new Mock<AdParameterService.AdParameterServiceClient>(MockBehavior.Strict);
            MutateAdParametersRequest request = new MutateAdParametersRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAdParametersResponse expectedResponse = new MutateAdParametersResponse();
            mockGrpcClient.Setup(x => x.MutateAdParametersAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdParametersResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AdParameterServiceClient client = new AdParameterServiceClientImpl(mockGrpcClient.Object, null);
            MutateAdParametersResponse response = await client.MutateAdParametersAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

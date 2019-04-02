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

namespace Google.Ads.GoogleAds.V1.Services.Tests
{
    using Google.Ads.GoogleAds.V1.Resources;
    using apis = Google.Ads.GoogleAds.V1.Services;
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
    public class GeneratedAssetServiceClientTest
    {
        [Test]
        public void GetAsset()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            GetAssetRequest expectedRequest = new GetAssetRequest
            {
                ResourceName = new AssetName("[CUSTOMER]", "[ASSET]").ToString(),
            };
            Asset expectedResponse = new Asset
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAsset(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AssetName("[CUSTOMER]", "[ASSET]").ToString();
            Asset response = client.GetAsset(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAssetAsync()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            GetAssetRequest expectedRequest = new GetAssetRequest
            {
                ResourceName = new AssetName("[CUSTOMER]", "[ASSET]").ToString(),
            };
            Asset expectedResponse = new Asset
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAssetAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Asset>(Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AssetName("[CUSTOMER]", "[ASSET]").ToString();
            Asset response = await client.GetAssetAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAsset2()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            GetAssetRequest request = new GetAssetRequest
            {
                ResourceName = new AssetName("[CUSTOMER]", "[ASSET]").ToString(),
            };
            Asset expectedResponse = new Asset
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAsset(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            Asset response = client.GetAsset(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAssetAsync2()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            GetAssetRequest request = new GetAssetRequest
            {
                ResourceName = new AssetName("[CUSTOMER]", "[ASSET]").ToString(),
            };
            Asset expectedResponse = new Asset
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAssetAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Asset>(Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            Asset response = await client.GetAssetAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAssets()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            MutateAssetsRequest expectedRequest = new MutateAssetsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAssetsResponse expectedResponse = new MutateAssetsResponse();
            mockGrpcClient.Setup(x => x.MutateAssets(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AssetOperation> operations = new List<AssetOperation>();
            MutateAssetsResponse response = client.MutateAssets(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAssetsAsync()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            MutateAssetsRequest expectedRequest = new MutateAssetsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAssetsResponse expectedResponse = new MutateAssetsResponse();
            mockGrpcClient.Setup(x => x.MutateAssetsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAssetsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<AssetOperation> operations = new List<AssetOperation>();
            MutateAssetsResponse response = await client.MutateAssetsAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateAssets2()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            MutateAssetsRequest request = new MutateAssetsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAssetsResponse expectedResponse = new MutateAssetsResponse();
            mockGrpcClient.Setup(x => x.MutateAssets(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetsResponse response = client.MutateAssets(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateAssetsAsync2()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            MutateAssetsRequest request = new MutateAssetsRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateAssetsResponse expectedResponse = new MutateAssetsResponse();
            mockGrpcClient.Setup(x => x.MutateAssetsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateAssetsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            MutateAssetsResponse response = await client.MutateAssetsAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

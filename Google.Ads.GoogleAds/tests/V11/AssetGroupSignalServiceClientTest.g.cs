// Copyright 2022 Google LLC
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

#pragma warning disable CS8981
using gagve = Google.Ads.GoogleAds.V11.Enums;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V11.Services;

namespace Google.Ads.GoogleAds.Tests.V11.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAssetGroupSignalServiceClientTest
    {
        [Category("Autogenerated")][Test]
        public void MutateAssetGroupSignalsRequestObject()
        {
            moq::Mock<AssetGroupSignalService.AssetGroupSignalServiceClient> mockGrpcClient = new moq::Mock<AssetGroupSignalService.AssetGroupSignalServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupSignalsRequest request = new MutateAssetGroupSignalsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupSignalOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAssetGroupSignalsResponse expectedResponse = new MutateAssetGroupSignalsResponse
            {
                Results =
                {
                    new MutateAssetGroupSignalResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroupSignals(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetGroupSignalServiceClient client = new AssetGroupSignalServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateAssetGroupSignalsResponse response = client.MutateAssetGroupSignals(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateAssetGroupSignalsRequestObjectAsync()
        {
            moq::Mock<AssetGroupSignalService.AssetGroupSignalServiceClient> mockGrpcClient = new moq::Mock<AssetGroupSignalService.AssetGroupSignalServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupSignalsRequest request = new MutateAssetGroupSignalsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupSignalOperation(),
                },
                PartialFailure = false,
                ValidateOnly = true,
                ResponseContentType = gagve::ResponseContentTypeEnum.Types.ResponseContentType.ResourceNameOnly,
            };
            MutateAssetGroupSignalsResponse expectedResponse = new MutateAssetGroupSignalsResponse
            {
                Results =
                {
                    new MutateAssetGroupSignalResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroupSignalsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetGroupSignalsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetGroupSignalServiceClient client = new AssetGroupSignalServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateAssetGroupSignalsResponse responseCallSettings = await client.MutateAssetGroupSignalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetGroupSignalsResponse responseCancellationToken = await client.MutateAssetGroupSignalsAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public void MutateAssetGroupSignals()
        {
            moq::Mock<AssetGroupSignalService.AssetGroupSignalServiceClient> mockGrpcClient = new moq::Mock<AssetGroupSignalService.AssetGroupSignalServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupSignalsRequest request = new MutateAssetGroupSignalsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupSignalOperation(),
                },
            };
            MutateAssetGroupSignalsResponse expectedResponse = new MutateAssetGroupSignalsResponse
            {
                Results =
                {
                    new MutateAssetGroupSignalResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroupSignals(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetGroupSignalServiceClient client = new AssetGroupSignalServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateAssetGroupSignalsResponse response = client.MutateAssetGroupSignals(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Autogenerated")][Test]
        public async stt::Task MutateAssetGroupSignalsAsync()
        {
            moq::Mock<AssetGroupSignalService.AssetGroupSignalServiceClient> mockGrpcClient = new moq::Mock<AssetGroupSignalService.AssetGroupSignalServiceClient>(moq::MockBehavior.Strict);
            MutateAssetGroupSignalsRequest request = new MutateAssetGroupSignalsRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new AssetGroupSignalOperation(),
                },
            };
            MutateAssetGroupSignalsResponse expectedResponse = new MutateAssetGroupSignalsResponse
            {
                Results =
                {
                    new MutateAssetGroupSignalResult(),
                },
                PartialFailureError = new gr::Status(),
            };
            mockGrpcClient.Setup(x => x.MutateAssetGroupSignalsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateAssetGroupSignalsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetGroupSignalServiceClient client = new AssetGroupSignalServiceClientImpl(mockGrpcClient.Object, null, null);
            MutateAssetGroupSignalsResponse responseCallSettings = await client.MutateAssetGroupSignalsAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateAssetGroupSignalsResponse responseCancellationToken = await client.MutateAssetGroupSignalsAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

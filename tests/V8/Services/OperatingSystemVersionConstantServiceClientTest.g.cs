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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V8.Services;

namespace Google.Ads.GoogleAds.Tests.V8.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedOperatingSystemVersionConstantServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetOperatingSystemVersionConstantRequestObject()
        {
            moq::Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient> mockGrpcClient = new moq::Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient>(moq::MockBehavior.Strict);
            GetOperatingSystemVersionConstantRequest request = new GetOperatingSystemVersionConstantRequest
            {
                ResourceNameAsOperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::OperatingSystemVersionConstant expectedResponse = new gagvr::OperatingSystemVersionConstant
            {
                ResourceNameAsOperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
                OperatorType = gagve::OperatingSystemVersionOperatorTypeEnum.Types.OperatingSystemVersionOperatorType.EqualsTo,
                Id = -6774108720365892680L,
                OperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
                OsMajorVersion = -1997824152,
                OsMinorVersion = -1302821028,
            };
            mockGrpcClient.Setup(x => x.GetOperatingSystemVersionConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OperatingSystemVersionConstantServiceClient client = new OperatingSystemVersionConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::OperatingSystemVersionConstant response = client.GetOperatingSystemVersionConstant(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetOperatingSystemVersionConstantRequestObjectAsync()
        {
            moq::Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient> mockGrpcClient = new moq::Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient>(moq::MockBehavior.Strict);
            GetOperatingSystemVersionConstantRequest request = new GetOperatingSystemVersionConstantRequest
            {
                ResourceNameAsOperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::OperatingSystemVersionConstant expectedResponse = new gagvr::OperatingSystemVersionConstant
            {
                ResourceNameAsOperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
                OperatorType = gagve::OperatingSystemVersionOperatorTypeEnum.Types.OperatingSystemVersionOperatorType.EqualsTo,
                Id = -6774108720365892680L,
                OperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
                OsMajorVersion = -1997824152,
                OsMinorVersion = -1302821028,
            };
            mockGrpcClient.Setup(x => x.GetOperatingSystemVersionConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::OperatingSystemVersionConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OperatingSystemVersionConstantServiceClient client = new OperatingSystemVersionConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::OperatingSystemVersionConstant responseCallSettings = await client.GetOperatingSystemVersionConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::OperatingSystemVersionConstant responseCancellationToken = await client.GetOperatingSystemVersionConstantAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetOperatingSystemVersionConstant()
        {
            moq::Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient> mockGrpcClient = new moq::Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient>(moq::MockBehavior.Strict);
            GetOperatingSystemVersionConstantRequest request = new GetOperatingSystemVersionConstantRequest
            {
                ResourceNameAsOperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::OperatingSystemVersionConstant expectedResponse = new gagvr::OperatingSystemVersionConstant
            {
                ResourceNameAsOperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
                OperatorType = gagve::OperatingSystemVersionOperatorTypeEnum.Types.OperatingSystemVersionOperatorType.EqualsTo,
                Id = -6774108720365892680L,
                OperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
                OsMajorVersion = -1997824152,
                OsMinorVersion = -1302821028,
            };
            mockGrpcClient.Setup(x => x.GetOperatingSystemVersionConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OperatingSystemVersionConstantServiceClient client = new OperatingSystemVersionConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::OperatingSystemVersionConstant response = client.GetOperatingSystemVersionConstant(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetOperatingSystemVersionConstantAsync()
        {
            moq::Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient> mockGrpcClient = new moq::Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient>(moq::MockBehavior.Strict);
            GetOperatingSystemVersionConstantRequest request = new GetOperatingSystemVersionConstantRequest
            {
                ResourceNameAsOperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::OperatingSystemVersionConstant expectedResponse = new gagvr::OperatingSystemVersionConstant
            {
                ResourceNameAsOperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
                OperatorType = gagve::OperatingSystemVersionOperatorTypeEnum.Types.OperatingSystemVersionOperatorType.EqualsTo,
                Id = -6774108720365892680L,
                OperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
                OsMajorVersion = -1997824152,
                OsMinorVersion = -1302821028,
            };
            mockGrpcClient.Setup(x => x.GetOperatingSystemVersionConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::OperatingSystemVersionConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OperatingSystemVersionConstantServiceClient client = new OperatingSystemVersionConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::OperatingSystemVersionConstant responseCallSettings = await client.GetOperatingSystemVersionConstantAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::OperatingSystemVersionConstant responseCancellationToken = await client.GetOperatingSystemVersionConstantAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetOperatingSystemVersionConstantResourceNames()
        {
            moq::Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient> mockGrpcClient = new moq::Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient>(moq::MockBehavior.Strict);
            GetOperatingSystemVersionConstantRequest request = new GetOperatingSystemVersionConstantRequest
            {
                ResourceNameAsOperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::OperatingSystemVersionConstant expectedResponse = new gagvr::OperatingSystemVersionConstant
            {
                ResourceNameAsOperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
                OperatorType = gagve::OperatingSystemVersionOperatorTypeEnum.Types.OperatingSystemVersionOperatorType.EqualsTo,
                Id = -6774108720365892680L,
                OperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
                OsMajorVersion = -1997824152,
                OsMinorVersion = -1302821028,
            };
            mockGrpcClient.Setup(x => x.GetOperatingSystemVersionConstant(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OperatingSystemVersionConstantServiceClient client = new OperatingSystemVersionConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::OperatingSystemVersionConstant response = client.GetOperatingSystemVersionConstant(request.ResourceNameAsOperatingSystemVersionConstantName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetOperatingSystemVersionConstantResourceNamesAsync()
        {
            moq::Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient> mockGrpcClient = new moq::Mock<OperatingSystemVersionConstantService.OperatingSystemVersionConstantServiceClient>(moq::MockBehavior.Strict);
            GetOperatingSystemVersionConstantRequest request = new GetOperatingSystemVersionConstantRequest
            {
                ResourceNameAsOperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
            };
            gagvr::OperatingSystemVersionConstant expectedResponse = new gagvr::OperatingSystemVersionConstant
            {
                ResourceNameAsOperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
                OperatorType = gagve::OperatingSystemVersionOperatorTypeEnum.Types.OperatingSystemVersionOperatorType.EqualsTo,
                Id = -6774108720365892680L,
                OperatingSystemVersionConstantName = gagvr::OperatingSystemVersionConstantName.FromCriterion("[CRITERION_ID]"),
                OsMajorVersion = -1997824152,
                OsMinorVersion = -1302821028,
            };
            mockGrpcClient.Setup(x => x.GetOperatingSystemVersionConstantAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::OperatingSystemVersionConstant>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OperatingSystemVersionConstantServiceClient client = new OperatingSystemVersionConstantServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::OperatingSystemVersionConstant responseCallSettings = await client.GetOperatingSystemVersionConstantAsync(request.ResourceNameAsOperatingSystemVersionConstantName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::OperatingSystemVersionConstant responseCancellationToken = await client.GetOperatingSystemVersionConstantAsync(request.ResourceNameAsOperatingSystemVersionConstantName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

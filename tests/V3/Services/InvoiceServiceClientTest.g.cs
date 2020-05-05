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
    using Google.Ads.GoogleAds.V3.Enums;
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
    public class GeneratedInvoiceServiceClientTest
    {
        [Test]
        public void ListInvoices()
        {
            Mock<InvoiceService.InvoiceServiceClient> mockGrpcClient = new Mock<InvoiceService.InvoiceServiceClient>(MockBehavior.Strict);
            ListInvoicesRequest expectedRequest = new ListInvoicesRequest
            {
                CustomerId = "customerId-1772061412",
                BillingSetup = "billingSetup-1181632583",
                IssueYear = "issueYear1443510243",
                IssueMonth = MonthOfYearEnum.Types.MonthOfYear.Unspecified,
            };
            ListInvoicesResponse expectedResponse = new ListInvoicesResponse();
            mockGrpcClient.Setup(x => x.ListInvoices(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            InvoiceServiceClient client = new InvoiceServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            string billingSetup = "billingSetup-1181632583";
            string issueYear = "issueYear1443510243";
            MonthOfYearEnum.Types.MonthOfYear issueMonth = MonthOfYearEnum.Types.MonthOfYear.Unspecified;
            ListInvoicesResponse response = client.ListInvoices(customerId, billingSetup, issueYear, issueMonth);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task ListInvoicesAsync()
        {
            Mock<InvoiceService.InvoiceServiceClient> mockGrpcClient = new Mock<InvoiceService.InvoiceServiceClient>(MockBehavior.Strict);
            ListInvoicesRequest expectedRequest = new ListInvoicesRequest
            {
                CustomerId = "customerId-1772061412",
                BillingSetup = "billingSetup-1181632583",
                IssueYear = "issueYear1443510243",
                IssueMonth = MonthOfYearEnum.Types.MonthOfYear.Unspecified,
            };
            ListInvoicesResponse expectedResponse = new ListInvoicesResponse();
            mockGrpcClient.Setup(x => x.ListInvoicesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListInvoicesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            InvoiceServiceClient client = new InvoiceServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            string billingSetup = "billingSetup-1181632583";
            string issueYear = "issueYear1443510243";
            MonthOfYearEnum.Types.MonthOfYear issueMonth = MonthOfYearEnum.Types.MonthOfYear.Unspecified;
            ListInvoicesResponse response = await client.ListInvoicesAsync(customerId, billingSetup, issueYear, issueMonth);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void ListInvoices2()
        {
            Mock<InvoiceService.InvoiceServiceClient> mockGrpcClient = new Mock<InvoiceService.InvoiceServiceClient>(MockBehavior.Strict);
            ListInvoicesRequest request = new ListInvoicesRequest
            {
                CustomerId = "customerId-1772061412",
                BillingSetup = "billingSetup-1181632583",
                IssueYear = "issueYear1443510243",
                IssueMonth = MonthOfYearEnum.Types.MonthOfYear.Unspecified,
            };
            ListInvoicesResponse expectedResponse = new ListInvoicesResponse();
            mockGrpcClient.Setup(x => x.ListInvoices(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            InvoiceServiceClient client = new InvoiceServiceClientImpl(mockGrpcClient.Object, null);
            ListInvoicesResponse response = client.ListInvoices(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task ListInvoicesAsync2()
        {
            Mock<InvoiceService.InvoiceServiceClient> mockGrpcClient = new Mock<InvoiceService.InvoiceServiceClient>(MockBehavior.Strict);
            ListInvoicesRequest request = new ListInvoicesRequest
            {
                CustomerId = "customerId-1772061412",
                BillingSetup = "billingSetup-1181632583",
                IssueYear = "issueYear1443510243",
                IssueMonth = MonthOfYearEnum.Types.MonthOfYear.Unspecified,
            };
            ListInvoicesResponse expectedResponse = new ListInvoicesResponse();
            mockGrpcClient.Setup(x => x.ListInvoicesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListInvoicesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            InvoiceServiceClient client = new InvoiceServiceClientImpl(mockGrpcClient.Object, null);
            ListInvoicesResponse response = await client.ListInvoicesAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

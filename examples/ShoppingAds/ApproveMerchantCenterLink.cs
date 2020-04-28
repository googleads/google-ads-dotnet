﻿// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V3.Errors;
using Google.Ads.GoogleAds.V3.Resources;
using Google.Ads.GoogleAds.V3.Services;

using System;
using static Google.Ads.GoogleAds.V3.Enums.MerchantCenterLinkStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V3
{
    /// <summary>
    /// This code example demonstrates how to approve a Merchant Center link request.
    /// 
    /// Prerequisite: You need to have access to a Merchant Center account. You can find
    /// instructions to create a Merchant Center account here:
    /// https://support.google.com/merchants/answer/188924.
    /// 
    /// To run this code example, you must use the Merchant Center UI or the Content API for
    /// Shopping to send a link request between your Merchant Center and Google Ads accounts.
    /// </summary>
    public class ApproveMerchantCenterLink : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            ApproveMerchantCenterLink codeExample = new ApproveMerchantCenterLink();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The Merchant center whose link request is to be approved.
            long merchantCenterAccountId = long.Parse("INSERT_MERCHANT_CENTER_ACCOUNT_ID_HERE");
            codeExample.Run(new GoogleAdsClient(), customerId, merchantCenterAccountId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example demonstrates how to approve a Merchant Center link " +
                    "request.\nPrerequisite: You need to have access to a Merchant Center " +
                    "account. You can find instructions to create a Merchant Center account " +
                    "here: https://support.google.com/merchants/answer/188924. To run this code " +
                    "example, you must use the Merchant Center UI or the Content API for " +
                    "Shopping to send a link request between your Merchant Center and Google " +
                    "Ads accounts.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="merchantCenterAccountId">The Merchant center whose link request is to be
        /// approved</param>
        public void Run(GoogleAdsClient client, long customerId, long merchantCenterAccountId)
        {
            // Get the MerchantCenterLink.
            MerchantCenterLinkServiceClient merchantCenterLinkService = client.GetService(
                Services.V3.MerchantCenterLinkService);

            try
            {
                // Retrieve all the existing Merchant Center links.
                ListMerchantCenterLinksResponse response =
                    merchantCenterLinkService.ListMerchantCenterLinks(customerId.ToString());

                Console.WriteLine($"{response.MerchantCenterLinks.Count} Merchant Center link(s)" +
                    $" found with the following details:");

                // Iterate the results, and filter for links with pending status.
                foreach (MerchantCenterLink merchantCenterLink in response.MerchantCenterLinks)
                {
                    Console.Write($"Link '{merchantCenterLink.ResourceName}' has status " +
                        $"'{merchantCenterLink.Status}'.");

                    // Checks if there is a link for the Merchant Center account we are looking
                    // for, then only approves the link if it is in a 'PENDING' state.
                    if (merchantCenterLink.Status == MerchantCenterLinkStatus.Pending &&
                        merchantCenterLink.Id == merchantCenterAccountId)
                    {
                        UpdateMerchantCenterLinkStatus(customerId, merchantCenterLinkService,
                            merchantCenterLink, MerchantCenterLinkStatus.Enabled);
                    }

                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        /// <summary>
        /// Updates the status of a Merchant Center link request for a given resource name.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="merchantCenterLinkService">The merchant center link service.</param>
        /// <param name="merchantCenterLink">The merchant center link.</param>
        /// <param name="status"></param>
        private static void UpdateMerchantCenterLinkStatus(long customerId,
            MerchantCenterLinkServiceClient merchantCenterLinkService,
            MerchantCenterLink merchantCenterLink, MerchantCenterLinkStatus status)
        {
            // Enables the pending link.
            MerchantCenterLink linkToUpdate = new MerchantCenterLink()
            {
                ResourceName = merchantCenterLink.ResourceName,
                Status = status
            };

            // Creates an operation.
            MerchantCenterLinkOperation operation = new MerchantCenterLinkOperation()
            {
                Update = linkToUpdate,
                UpdateMask = FieldMasks.AllSetFieldsOf(linkToUpdate)
            };

            // Updates the link.
            MutateMerchantCenterLinkResponse mutateResponse =
                merchantCenterLinkService.MutateMerchantCenterLink(
                    customerId.ToString(), operation);

            // Displays the result.
            Console.WriteLine($"The status of Merchant Center Link with resource name " +
                $"'{mutateResponse.Result.ResourceName}' to Google Ads account : " +
                $"{customerId} was updated to {status}.");
        }
    }
}

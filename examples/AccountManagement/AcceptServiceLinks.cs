// Copyright 2019 Google LLC
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
    /// This code example accepts all pending invitations from Google Merchant Center accounts
    /// to your Google Ads account.
    /// </summary>
    public class AcceptServiceLinks : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AcceptServiceLinks codeExample = new AcceptServiceLinks();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example accepts all pending invitations from Google Merchant " +
                    "Center accounts to your Google Ads account.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the MerchantCenterLink.
            MerchantCenterLinkServiceClient merchantCenterLinkService = client.GetService(
                Services.V3.MerchantCenterLinkService);

            try
            {
                // Retrieve all the existing Merchant Center links.
                ListMerchantCenterLinksResponse response =
                    merchantCenterLinkService.ListMerchantCenterLinks(customerId.ToString());

                // Iterate the results, and filter for links with pending status.
                foreach (MerchantCenterLink merchantCenterLink in response.MerchantCenterLinks)
                {
                    if (merchantCenterLink.Status == MerchantCenterLinkStatus.Pending)
                    {
                        // Enables the pending link.
                        MerchantCenterLink linkToUpdate = new MerchantCenterLink()
                        {
                            ResourceName = merchantCenterLink.ResourceName,
                            Status = MerchantCenterLinkStatus.Enabled
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
                        Console.WriteLine($"Enabled a Merchant Center Link with resource name " +
                            $"'{mutateResponse.Result.ResourceName}' to Google Ads account : " +
                            $"{customerId}");
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
    }
}

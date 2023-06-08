// Copyright 2020 Google LLC
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

using CommandLine;
using Google.Ads.Gax.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V14.Common;
using Google.Ads.GoogleAds.V14.Errors;
using Google.Ads.GoogleAds.V14.Resources;
using Google.Ads.GoogleAds.V14.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V14.Enums.ExtensionTypeEnum.Types;
using static Google.Ads.GoogleAds.V14.Enums.AssetFieldTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V14
{
    /// <summary>
    /// This example adds a hotel callout extension to a specific account, campaign within the
    /// account, and ad group within the campaign.
    /// </summary>
    public class AddHotelCallout : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddHotelCallout"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The customer ID for which the call is made.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// The language code for the text. See supported languages at:
            /// https://developers.google.com/hotels/hotel-ads/api-reference/language-codes.
            /// </summary>
            [Option("languageCode", Required = true, HelpText =
                "The language code for the text. See supported languages at: " +
                "https://developers.google.com/hotels/hotel-ads/api-reference/language-codes.")]
            public string LanguageCode { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddHotelCallout codeExample = new AddHotelCallout();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.LanguageCode);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example adds a hotel callout extension to a specific account.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="languageCode">The language code for the text. See supported languages at:
        /// https://developers.google.com/hotels/hotel-ads/api-reference/language-codes.</param>
        public void Run(GoogleAdsClient client, long customerId, string languageCode)
        {
            try
            {
                // Creates assets for the hotel callout extensions.
                List<string> assetResourceNames =
                    AddExtensionAsset(client, customerId, languageCode);

                // Adds the extensions at the account level, so these will serve in all eligible
                // campaigns.
                LinkAssetToAccount(client, customerId, assetResourceNames);
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
        /// Creates a new asset for the callout.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="languageCode">The language code for the text.</param>
        /// <returns>The created extension feed item's resource name.</returns>
        private List<string> AddExtensionAsset(GoogleAdsClient client, in long customerId,
            string languageCode)
        {
            List<HotelCalloutAsset> hotelCalloutAssets = new List<HotelCalloutAsset>();

            // Creates the callouts with text and specified language.
            hotelCalloutAssets.Add(
                new HotelCalloutAsset
                {
                    Text = "Activities",
                    LanguageCode = languageCode,
                });
            hotelCalloutAssets.Add(
                new HotelCalloutAsset
                {
                    Text = "Facilities",
                    LanguageCode = languageCode,
                });

            // Wraps the HotelCalloutAsset in an Asset and creates an AssetOperation to add the
            // Asset.
            List<AssetOperation> operations = new List<AssetOperation>();

            foreach (HotelCalloutAsset asset in hotelCalloutAssets)
            {
                operations.Add(new AssetOperation
                {
                    Create = new Asset
                    {
                        HotelCalloutAsset = asset,
                    },
                });
            }

            // Issues the create request to create the assets.

            AssetServiceClient assetClient = client.GetService(Services.V14.AssetService);
            MutateAssetsResponse response =
                assetClient.MutateAssets(customerId.ToString(), operations);
            List<MutateAssetResult> results = response.Results.ToList();
            List<string> resourceNames = new List<string>();
            // Prints some information about the result.
            foreach (MutateAssetResult result in results)
            {
                resourceNames.Add(result.ResourceName);
                Console.WriteLine("Created hotel call out asset with resource name " +
                    result.ResourceName);
            }

            return resourceNames;
        }

        /// <summary>
        /// Link asset to customer.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="assetResourceNames">The asset resource names.</param>
        /// <returns>The created extension feed item's resource name.</returns>
        private void LinkAssetToAccount(GoogleAdsClient client, in long customerId,
            List<string> assetResourceNames)
        {
            // Creates a CustomerAsset link for each Asset resource name provided, then converts
            // this into a CustomerAssetOperation to create the Asset.
            List<CustomerAssetOperation> customerAssetOperations =
              new List<CustomerAssetOperation>();

            foreach (string asset in assetResourceNames)
            {
                customerAssetOperations.Add(
                    new CustomerAssetOperation
                    {
                        Create = new CustomerAsset
                        {
                            Asset = asset,
                            FieldType = AssetFieldType.HotelCallout,
                        },
                    });
            }

            // Issues the create request to add the callout.
            CustomerAssetServiceClient customerAssetServiceClient =
                client.GetService(Services.V14.CustomerAssetService);

            MutateCustomerAssetsResponse response =
              customerAssetServiceClient.MutateCustomerAssets(customerId.ToString(),
                  customerAssetOperations);

            foreach (MutateCustomerAssetResult result in response.Results)
            {
                Console.WriteLine("Added an account extension with resource name: " +
                    result.ResourceName);
            }
        }
    }
}

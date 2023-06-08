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
using Google.Ads.GoogleAds.V14.Enums;
using Google.Ads.GoogleAds.V14.Errors;
using Google.Ads.GoogleAds.V14.Resources;
using Google.Ads.GoogleAds.V14.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V14.Enums.PriceExtensionPriceQualifierEnum.Types;
using static Google.Ads.GoogleAds.V14.Enums.PriceExtensionPriceUnitEnum.Types;
using static Google.Ads.GoogleAds.V14.Enums.PriceExtensionTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V14
{
    /// <summary>
    /// This code example adds a price extension and associates it with an account.
    /// </summary>
    public class AddPrices : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddPrices"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The customer ID for which the call is made.")]
            public long CustomerId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddPrices codeExample = new AddPrices();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example adds a price extension and associates it with an account.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            try
            {
                // Create a new price asset.
                string priceAssetResourceName = CreatePriceAsset(client, customerId);

                // Add the new price asset to the account, so it will serve all
                // campaigns under the account.
                AddExtensionToAccount(client, customerId, priceAssetResourceName);
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
        /// Creates a price asset.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <returns>the resource name of the newly created price asset.</returns>
        private string CreatePriceAsset(GoogleAdsClient client, long customerId)
        {
            PriceAsset priceAsset = new PriceAsset
            {
                Type = PriceExtensionType.Services,
                // Price qualifier is optional.
                PriceQualifier = PriceExtensionPriceQualifier.From,
                LanguageCode = "en",
                PriceOfferings = {
                    CreatePriceOffering(
                        "Scrubs",
                        "Body Scrub, Salt Scrub",
                        "http://www.example.com/scrubs",
                        "http://m.example.com/scrubs",
                        60000000, // 60 USD
                        "USD",
                        PriceExtensionPriceUnit.PerHour
                    ),
                    CreatePriceOffering(
                        "Hair Cuts",
                        "Once a month",
                        "http://www.example.com/haircuts",
                        "http://m.example.com/haircuts",
                        250000000, // 60 USD
                        "USD",
                        PriceExtensionPriceUnit.PerMonth
                    ),
                    CreatePriceOffering(
                        "Skin Care Package",
                        "Four times a month",
                        "http://www.example.com/skincarepackage",
                        null,
                        250000000, // 250 USD
                        "USD",
                        PriceExtensionPriceUnit.PerMonth
                    ),
                },
            };

            Asset asset = new Asset
            {
                Name = "Price Asset #" + ExampleUtilities.GetRandomString(),
                TrackingUrlTemplate = "http://tracker.example.com/?u={lpurl}",
                PriceAsset = priceAsset,
            };

            AssetOperation operation = new AssetOperation
            {
                Create = asset,
            };

            AssetServiceClient assetClient = client.GetService(Services.V14.AssetService);
            MutateAssetsResponse response = assetClient.MutateAssets(customerId.ToString(),
                new[] { operation });
            string resourceName = response.Results[0].ResourceName;

            Console.WriteLine($"Created price asset with resource name '{resourceName}'.");

            return resourceName;
        }

        /// <summary>
        /// Adds the price asset to the customer account, allowing it to serve all campaigns under
        /// the account.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="priceAssetResourceName">The price asset resource name for which the call is
        /// made.</param>
        private void AddExtensionToAccount(GoogleAdsClient client, long customerId,
            string priceAssetResourceName)
        {
            CustomerAsset customerAsset = new CustomerAsset
            {
                Asset = priceAssetResourceName,
                FieldType = AssetFieldTypeEnum.Types.AssetFieldType.Price,
            };

            // Issues the create request to add the callout.
            CustomerAssetServiceClient customerAssetServiceClient =
                client.GetService(Services.V14.CustomerAssetService);
            CustomerAssetOperation operation = new CustomerAssetOperation
            {
                Create = customerAsset,
            };

            CustomerAssetServiceClient assetClient =
              client.GetService(Services.V14.CustomerAssetService);
            MutateCustomerAssetsResponse response =
              assetClient.MutateCustomerAssets(customerId.ToString(), new[] { operation });

            string resourceName = response.Results[0].ResourceName;

            Console.WriteLine($"Created customer asset with resource name '{resourceName}'.");
        }

        /// <summary>
        /// Creates a new price offering with the specified attributes.
        /// </summary>
        /// <param name="header">The header for the price offering.</param>
        /// <param name="description">The description for the price offering.</param>
        /// <param name="finalUrl">The final url for the price offering.</param>
        /// <param name="finalMobileUrl">The final mobile url for the price offering. Can be set to
        /// null.</param>
        /// <param name="priceInMicros">The price in micros.</param>
        /// <param name="currencyCode">The currency code.</param>
        /// <param name="unit">The price unit.</param>
        private PriceOffering CreatePriceOffering(string header, string description,
            string finalUrl, string finalMobileUrl, long priceInMicros,
            string currencyCode, PriceExtensionPriceUnit unit)
        {
            PriceOffering priceOffering = new PriceOffering
            {
                Header = header,
                Description = description,
                FinalUrl = finalUrl,
                Price = new Money
                {
                    AmountMicros = priceInMicros,
                    CurrencyCode = currencyCode,
                },
                Unit = unit,
            };

            if (finalMobileUrl != null)
            {
                priceOffering.FinalMobileUrl = finalMobileUrl;
            }

            return priceOffering;
        }
    }
}
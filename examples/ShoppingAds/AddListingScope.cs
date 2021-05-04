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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V7.Common;
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Resources;
using Google.Ads.GoogleAds.V7.Services;
using System;
using static Google.Ads.GoogleAds.V7.Enums.ProductCustomAttributeIndexEnum.Types;
using static Google.Ads.GoogleAds.V7.Enums.ProductTypeLevelEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// This code example adds a shopping listing scope to a shopping campaign. The example will
    /// construct and add a new listing scope which will act as the inventory filter for the
    /// campaign. The campaign will only advertise products that match the following requirements:
    ///
    /// <ul>
    ///   <li>Brand is "google"</li>
    ///   <li>Custom label 0 is "top_selling_products"</li>
    ///   <li>Product type (level 1) is "electronics"</li>
    ///   <li>Product type(level 2) is "smartphones"</li>
    /// </ul>
    ///
    /// Only one listing scope is allowed per campaign. Remove any existing listing scopes before
    /// running this code example.
    /// </summary>
    public class AddListingScope : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddListingScope codeExample = new AddListingScope();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The campaign to which listing scope is added.
            long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, campaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a shopping listing scope to a shopping campaign. The example " +
            "will construct and add a new listing scope which will act as the inventory filter " +
            "for the campaign. The campaign will only advertise products that match the " +
            "following requirements: \n" +
            " - Brand is 'google'\n" +
            " - Custom label 0 is 'top_selling_products'\n" +
            " - Product type (level 1) is 'electronics'\n" +
            " - Product type (level 2) is 'smartphones'\n" +
            "Only one listing scope is allowed per campaign. Remove any existing listing scopes " +
            "before running this code example.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">The campaign to which listing scope is added.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            // Get the CampaignCriterionService.
            CampaignCriterionServiceClient campaignCriterionService =
                client.GetService(Services.V7.CampaignCriterionService);

            // A listing scope allows you to filter the products that will be included in a given
            // campaign. You can specify multiple dimensions with conditions that must be met for
            // a product to be included in a campaign.
            // A typical ListingScope might only have a few dimensions. This example demonstrates
            // a range of different dimensions you could use.
            ListingScopeInfo listingScope = new ListingScopeInfo()
            {
                Dimensions =
                {
                    // Creates a ProductBrand dimension set to "google".
                    new ListingDimensionInfo()
                    {
                        ProductBrand = new ProductBrandInfo()
                        {
                            Value = "google"
                        }
                    },

                    // Creates a ProductCustomAttribute dimension for INDEX0 set to
                    // "top_selling_products".
                    new ListingDimensionInfo()
                    {
                        ProductCustomAttribute = new ProductCustomAttributeInfo()
                        {
                            Index = ProductCustomAttributeIndex.Index0,
                            Value = "top_selling_products"
                        }
                    },

                    // Creates a ProductType dimension for LEVEL1 set to "electronics".
                    new ListingDimensionInfo()
                    {
                        ProductType = new ProductTypeInfo()
                        {
                            Level = ProductTypeLevel.Level1,
                            Value = "electronics"
                        }
                    },

                    // Creates a ProductType dimension for LEVEL2 set to "smartphones".
                    new ListingDimensionInfo()
                    {
                        ProductType = new ProductTypeInfo()
                        {
                            Level = ProductTypeLevel.Level2,
                            Value = "smartphones"
                        }
                    },
                }
            };

            string campaignResourceName = ResourceNames.Campaign(customerId, campaignId);

            // Creates a campaign criterion to store the listing scope.
            CampaignCriterion campaignCriterion = new CampaignCriterion()
            {
                Campaign = campaignResourceName,
                ListingScope = listingScope
            };

            CampaignCriterionOperation operation = new CampaignCriterionOperation()
            {
                Create = campaignCriterion
            };

            try
            {
                // Calls the mutate method to add the campaign criterion.
                MutateCampaignCriteriaResponse response =
                    campaignCriterionService.MutateCampaignCriteria(
                        customerId.ToString(), new[] { operation });
                Console.WriteLine($"Added {response.Results.Count} campaign criteria:");
                foreach (MutateCampaignCriterionResult result in response.Results)
                {
                    Console.WriteLine(result.ResourceName);
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

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
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;

using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example fetches the set of valid ProductBiddingCategories.
    /// </summary>
    public class GetProductBiddingCategoryConstant : ExampleBase
    {
        /// <summary>
        /// Node that tracks a product bidding category's id, name, and child nodes.
        /// </summary>

        public class CategoryNode
        {
            /// <summary>
            /// The resource name of the category.
            /// </summary>
            public string ResourceName
            {
                get;
                private set;
            }

            /// <summary>
            /// Gets or sets the localized name of the category.
            /// </summary>
            public string LocalizedName
            {
                get;
                set;
            }

            /// <summary>
            /// Gets the list of child.
            /// </summary>
            public List<CategoryNode> Children
            {
                get;
            } = new List<CategoryNode>();

            /// <summary>
            /// Constructor for categories first encountered as non-parent elements in the results.
            /// </summary>
            /// <param name="resourceName">The resource name of the category.</param>
            /// <param name="localizedName">The name of the category.</param>
            public CategoryNode(string resourceName, string localizedName)
            {
                if (string.IsNullOrEmpty(resourceName))
                {
                    throw new ArgumentNullException();
                }
                this.ResourceName = resourceName;
                this.LocalizedName = localizedName;
            }

            /// <summary>
            /// Constructor for categories first encountered as a parent category, in which case
            /// only the ID is available.
            /// </summary>
            /// <param name="resourceName">The resource name of the category.</param>
            public CategoryNode(string resourceName) : this(resourceName, null) { }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            GetProductBiddingCategoryConstant codeExample = new GetProductBiddingCategoryConstant();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example fetches the set of valid ProductBiddingCategories.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsServiceClient .
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V6.GoogleAdsService);

            // Creates the query.
            string query = "SELECT product_bidding_category_constant.localized_name, " +
                "product_bidding_category_constant.product_bidding_category_constant_parent " +
                "FROM product_bidding_category_constant WHERE " +
                "product_bidding_category_constant.country_code IN ('US') ORDER BY " +
                "product_bidding_category_constant.localized_name ASC";

            // Creates the request.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                Query = query
            };

            // Creates a list of top level category nodes.
            List<CategoryNode> rootCategories = new List<CategoryNode>();

            // Creates a map of category ID to category node for all categories found in the
            // results.
            // This Map is a convenience lookup to enable fast retrieval of existing nodes.
            Dictionary<string, CategoryNode> biddingCategories =
                new Dictionary<string, CategoryNode>();

            try
            {
                // Performs the search request.
                foreach (GoogleAdsRow googleAdsRow in googleAdsService.Search(request))
                {
                    ProductBiddingCategoryConstant productBiddingCategory =
                        googleAdsRow.ProductBiddingCategoryConstant;

                    string localizedName = productBiddingCategory.LocalizedName;
                    string resourceName = productBiddingCategory.ResourceName;

                    CategoryNode node = null;
                    if (biddingCategories.ContainsKey(resourceName))
                    {
                        node = biddingCategories[resourceName];
                    }
                    else
                    {
                        node = new CategoryNode(resourceName, localizedName);
                        biddingCategories[resourceName] = node;
                    }

                    if (string.IsNullOrEmpty(node.LocalizedName))
                    {
                        // Ensures that the name attribute for the node is set. Name will be null for
                        //nodes added to biddingCategories as a result of being a parentNode below.
                        node.LocalizedName = localizedName;
                    }

                    if (!string.IsNullOrEmpty(
                        productBiddingCategory.ProductBiddingCategoryConstantParent))
                    {
                        string parentResourceName =
                            productBiddingCategory.ProductBiddingCategoryConstantParent;
                        CategoryNode parentNode = null;

                        if (biddingCategories.ContainsKey(parentResourceName))
                        {
                            parentNode = biddingCategories[parentResourceName];
                        }
                        else
                        {
                            parentNode = new CategoryNode(parentResourceName);
                            biddingCategories[parentResourceName] = parentNode;
                        }
                        parentNode.Children.Add(node);
                    }
                    else
                    {
                        rootCategories.Add(node);
                    }
                }
                DisplayCategories(rootCategories, "");
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
        /// Recursively prints out each category node and its children.
        /// </summary>
        /// <param name="categories">The categories to print.</param>
        /// <param name="prefix">The string to print at the beginning of each line of output.
        /// </param>
        private static void DisplayCategories(IEnumerable<CategoryNode> categories,
            string prefix)
        {
            foreach (CategoryNode category in categories)
            {
                Console.WriteLine($"{prefix}{category.LocalizedName}" +
                    $" [{category.ResourceName}]");
                DisplayCategories(category.Children, $"{prefix}{category.LocalizedName} > ");
            }
        }
    }
}

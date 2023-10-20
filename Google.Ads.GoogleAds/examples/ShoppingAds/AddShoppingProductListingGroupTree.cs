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

using CommandLine;
using Google.Ads.Gax.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V15.Common;
using Google.Ads.GoogleAds.V15.Errors;
using Google.Ads.GoogleAds.V15.Resources;
using Google.Ads.GoogleAds.V15.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V15.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V15.Enums.ListingGroupTypeEnum.Types;
using static Google.Ads.GoogleAds.V15.Enums.ProductConditionEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V15
{
    /// <summary>
    /// This code example shows how to add a shopping listing group tree to a shopping ad group.
    /// The example will clear an existing listing group tree and rebuild it include the following
    /// tree structure:
    ///
    /// <code>
    /// ProductCanonicalCondition NEW $0.20
    /// ProductCanonicalCondition USED $0.10
    /// ProductCanonicalCondition null (everything else)
    ///  ProductBrand CoolBrand $0.90
    ///  ProductBrand CheapBrand $0.01
    ///  ProductBrand null (everything else) $0.50
    /// </code>
    /// </summary>
    public class AddShoppingProductListingGroupTree : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddShoppingProductListingGroupTree"/>
        /// example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the call is made.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// The ID of the ad group.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "The ID of the ad group.")]
            public long AdGroupId { get; set; }

            /// <summary>
            /// The boolean to indicate whether to replace the existing listing group tree on the
            /// ad group, if it already exists. The example will throw a
            /// LISTING_GROUP_ALREADY_EXISTS error if listing group tree already exists and this
            /// option is not set to true.
            /// </summary>
            [Option("replaceExistingTree", Required = true, HelpText =
                "The boolean to indicate whether to replace the existing listing group tree on " +
                "the ad group, if it already exists. The example will throw a " +
                "LISTING_GROUP_ALREADY_EXISTS error if listing group tree already exists and " +
                "this option is not set to true.")]
            public bool ReplaceExistingTree { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddShoppingProductListingGroupTree codeExample =
                new AddShoppingProductListingGroupTree();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.AdGroupId,
                options.ReplaceExistingTree);
        }

        /// <summary>
        /// The page size to be used by default.
        /// </summary>
        private const int PAGE_SIZE = 1_000;

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example shows how to add a shopping listing group tree to a shopping ad " +
            "group. The example will clear an existing listing group tree and rebuild it include " +
            "the following tree structure:\n" +
            "ProductCanonicalCondition NEW $0.20\n" +
            "ProductCanonicalCondition USED $0.10\n" +
            "ProductCanonicalCondition null (everything else)\n" +
            "  ProductBrand CoolBrand $0.90\n" +
            "  ProductBrand CheapBrand $0.01\n" +
            "  ProductBrand null (everything else) $0.50\n";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ID of the ad group.</param>
        /// <param name="replaceExistingTree">The boolean to indicate whether to replace the
        /// existing listing group tree on the ad group, if it already exists. The example will
        /// throw a <code>LISTING_GROUP_ALREADY_EXISTS</code> error if listing group tree already
        /// exists and this option is not set to true.</param>
        // [START add_shopping_product_listing_group_tree]
        public void Run(GoogleAdsClient client, long customerId, long adGroupId,
            bool replaceExistingTree)
        {
            // Get the AdGroupCriterionService.
            AdGroupCriterionServiceClient adGroupCriterionService =
                client.GetService(Services.V15.AdGroupCriterionService);

            try
            {
                // 1) Optional: Remove the existing listing group tree, if it already exists on the
                // ad group.
                if (replaceExistingTree)
                {
                    RemoveListingGroupTree(client, customerId, adGroupId);
                }
                // Create a list of ad group criterion to add
                List<AdGroupCriterionOperation> operations = new List<AdGroupCriterionOperation>();

                // 2) Construct the listing group tree "root" node.

                // Subdivision node: (Root node)
                AdGroupCriterion adGroupCriterionRoot = CreateListingGroupSubdivisionRoot(
                    customerId, adGroupId, -1L);

                // Get the resource name that will be used for the root node.
                // This resource has not been created yet and will include the temporary ID as
                // part of the criterion ID.
                String adGroupCriterionResourceNameRoot = adGroupCriterionRoot.ResourceName;
                operations.Add(new AdGroupCriterionOperation()
                {
                    Create = adGroupCriterionRoot
                });

                // 3) Construct the listing group unit nodes for NEW, USED and other

                // Biddable Unit node: (Condition NEW node)
                // * Product Condition: NEW
                // * CPC bid: $0.20
                AdGroupCriterion adGroupCriterionConditionNew =
                    CreateListingGroupUnitBiddable(
                        customerId,
                        adGroupId,
                        adGroupCriterionResourceNameRoot,
                        new ListingDimensionInfo()
                        {
                            ProductCondition = new ProductConditionInfo()
                            {
                                Condition = ProductCondition.New
                            }
                        },
                        200_000L);
                operations.Add(new AdGroupCriterionOperation()
                {
                    Create = adGroupCriterionConditionNew
                });

                // Biddable Unit node: (Condition USED node)
                // * Product Condition: USED
                // * CPC bid: $0.10
                AdGroupCriterion adGroupCriterionConditionUsed =
                    CreateListingGroupUnitBiddable(
                        customerId,
                        adGroupId,
                        adGroupCriterionResourceNameRoot,
                        new ListingDimensionInfo()
                        {
                            ProductCondition = new ProductConditionInfo()
                            {
                                Condition = ProductCondition.Used
                            }
                        },
                        100_000L
                    );
                operations.Add(new AdGroupCriterionOperation()
                {
                    Create = adGroupCriterionConditionUsed
                });

                // Sub-division node: (Condition "other" node)
                // * Product Condition: (not specified)
                AdGroupCriterion adGroupCriterionConditionOther =
                    CreateListingGroupSubdivision(
                        customerId,
                        adGroupId,
                        -2L,
                        adGroupCriterionResourceNameRoot,
                        new ListingDimensionInfo()
                        {
                            // All sibling nodes must have the same dimension type, even if they
                            // don't contain a bid.
                            ProductCondition = new ProductConditionInfo()
                        }
                    );
                // Get the resource name that will be used for the condition other node.
                // This resource has not been created yet and will include the temporary ID as
                // part of the criterion ID.
                String adGroupCriterionResourceNameConditionOther =
                    adGroupCriterionConditionOther.ResourceName;
                operations.Add(new AdGroupCriterionOperation()
                {
                    Create = adGroupCriterionConditionOther
                });

                // 4) Construct the listing group unit nodes for CoolBrand, CheapBrand and other

                // Biddable Unit node: (Brand CoolBrand node)
                // * Brand: CoolBrand
                // * CPC bid: $0.90
                AdGroupCriterion adGroupCriterionBrandCoolBrand =
                    CreateListingGroupUnitBiddable(
                        customerId,
                        adGroupId,
                        adGroupCriterionResourceNameConditionOther,
                        new ListingDimensionInfo()
                        {
                            ProductBrand = new ProductBrandInfo()
                            {
                                Value = "CoolBrand"
                            }
                        },
                        900_000L);
                operations.Add(new AdGroupCriterionOperation()
                {
                    Create = adGroupCriterionBrandCoolBrand
                });

                // Biddable Unit node: (Brand CheapBrand node)
                // * Brand: CheapBrand
                // * CPC bid: $0.01
                AdGroupCriterion adGroupCriterionBrandCheapBrand =
                    CreateListingGroupUnitBiddable(
                        customerId,
                        adGroupId,
                        adGroupCriterionResourceNameConditionOther,
                        new ListingDimensionInfo()
                        {
                            ProductBrand = new ProductBrandInfo()
                            {
                                Value = "CheapBrand"
                            }
                        },
                        10_000L);

                operations.Add(new AdGroupCriterionOperation()
                {
                    Create = adGroupCriterionBrandCheapBrand
                });

                // Biddable Unit node: (Brand other node)
                // * Brand: CheapBrand
                // * CPC bid: $0.01
                AdGroupCriterion adGroupCriterionBrandOther =
                    CreateListingGroupUnitBiddable(
                        customerId,
                        adGroupId,
                        adGroupCriterionResourceNameConditionOther,
                        new ListingDimensionInfo()
                        {
                            ProductBrand = new ProductBrandInfo()
                        },
                        50_000L);
                operations.Add(new AdGroupCriterionOperation()
                {
                    Create = adGroupCriterionBrandOther
                });

                // Issues a mutate request to add the ad group criterion to the ad group.
                MutateAdGroupCriteriaResponse response =
                    adGroupCriterionService.MutateAdGroupCriteria(
                        customerId.ToString(), operations);

                // Display the results.
                foreach (MutateAdGroupCriterionResult mutateAdGroupCriterionResult
                    in response.Results)
                {
                    Console.WriteLine("Added ad group criterion for listing group with resource " +
                        $"name: '{mutateAdGroupCriterionResult.ResourceName}.");
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
        // [END add_shopping_product_listing_group_tree]

        /// <summary>
        /// Removes all the ad group criteria that define the existing listing group tree for an
        /// ad group. Returns without an error if all listing group criterion are successfully
        /// removed.
        /// </summary>
        /// <param name="client">The Google Ads API client..</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="adGroupId">The ID of the ad group that the new listing group tree will
        /// be removed from.</param>
        /// <exception cref="GoogleAdsException">Thrown if an API request failed with one or more
        /// service errors.</exception>
        private void RemoveListingGroupTree(GoogleAdsClient client, long customerId,
            long adGroupId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V15.GoogleAdsService);

            // Get the AdGroupCriterionService.
            AdGroupCriterionServiceClient adGroupCriterionService =
                client.GetService(Services.V15.AdGroupCriterionService);

            String searchQuery = "SELECT ad_group_criterion.resource_name FROM " +
                "ad_group_criterion WHERE ad_group_criterion.type = LISTING_GROUP AND " +
                "ad_group_criterion.listing_group.parent_ad_group_criterion IS NULL " +
                $"AND ad_group.id = {adGroupId}";

            // Creates a request that will retrieve all listing groups where the parent ad group
            // criterion is NULL (and hence the root node in the tree) for a given ad group ID.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                PageSize = PAGE_SIZE,
                Query = searchQuery
            };

            // Issues the search request.
            GoogleAdsRow googleAdsRow = googleAdsService.Search(request).FirstOrDefault();

            if (googleAdsRow == null)
            {
                return;
            }

            AdGroupCriterion adGroupCriterion = googleAdsRow.AdGroupCriterion;
            Console.WriteLine("Found ad group criterion with the resource name: '{0}'.",
                adGroupCriterion.ResourceName);

            AdGroupCriterionOperation operation = new AdGroupCriterionOperation()
            {
                Remove = adGroupCriterion.ResourceName
            };

            MutateAdGroupCriteriaResponse response =
                adGroupCriterionService.MutateAdGroupCriteria(
                    customerId.ToString(), new AdGroupCriterionOperation[] { operation });
            Console.WriteLine($"Removed {response.Results.Count}.");
        }

        /// <summary>
        /// Creates a new criterion containing a biddable unit listing group node.
        /// </summary>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="adGroupId">The ID of the ad group.</param>
        /// <param name="parentAdGroupCriterionResourceName">The resource name of the parent of
        /// this criterion.</param>
        /// <param name="listingDimensionInfo">The ListingDimensionInfo to be set for this listing
        /// group.</param>
        /// <param name="cpcBidMicros">The CPC bid for items in this listing group. This value
        /// should be specified in micros.</param>
        /// <returns>The ad group criterion object that contains the biddable unit listing group
        /// node.</returns>
        private AdGroupCriterion CreateListingGroupUnitBiddable(long customerId, long adGroupId,
            String parentAdGroupCriterionResourceName, ListingDimensionInfo listingDimensionInfo,
            long cpcBidMicros)
        {
            String adGroupResourceName = ResourceNames.AdGroup(customerId, adGroupId);
            AdGroupCriterion adGroupCriterion = new AdGroupCriterion()
            {
                // The resource name the ad group the listing group node will be attached to unit.
                // Note: Listing group units do not require temporary IDs if ad group resource name
                // and parentAdGroupCriterionResourceName are specified. To use temporary IDs for
                // unit criteria, use ResourceName property.
                AdGroup = adGroupResourceName,
                Status = AdGroupCriterionStatus.Enabled,
                ListingGroup = new ListingGroupInfo()
                {
                    // Set the type as a UNIT, which will allow the group to be biddable
                    Type = ListingGroupType.Unit,

                    // Set the ad group criterion resource name for the parent listing group.
                    // This can include a criterion ID if the parent criterion is not yet created.
                    // Use StringValue to convert from a String to a compatible argument type.
                    ParentAdGroupCriterion = parentAdGroupCriterionResourceName,

                    // Case values contain the listing dimension used for the node.
                    CaseValue = listingDimensionInfo
                },

                // Set the bid for this listing group unit.
                // This will be used as the CPC bid for items that are included in this
                // listing group
                CpcBidMicros = cpcBidMicros
            };
            return adGroupCriterion;
        }

        /// <summary>
        /// Creates a new criterion containing a subdivision listing group node.
        /// </summary>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="adGroupId">The ID of the ad group.</param>
        /// <param name="adGroupCriterionId">The ID of the criterion. This value will used to
        /// construct the resource name. This can be a negative number if the criterion is yet to
        /// be created.</param>
        /// <param name="parentAdGroupCriterionResourceName">The resource name of the parent of
        /// this criterion.</param>
        /// <param name="listingDimensionInfo">The ListingDimensionInfo to be set for this listing
        /// group.</param>
        /// <returns>The ad group criterion object that contains the subdivision listing group
        /// node.</returns>
        private AdGroupCriterion CreateListingGroupSubdivision(long customerId, long adGroupId,
            long adGroupCriterionId, String parentAdGroupCriterionResourceName,
            ListingDimensionInfo listingDimensionInfo)
        {
            String adGroupCriterionResourceName = ResourceNames.AdGroupCriterion(
                customerId, adGroupId, adGroupCriterionId);

            AdGroupCriterion adGroupCriterion = new AdGroupCriterion()
            {
                // The resource name the criterion will be created with. This will define the
                // ID for the ad group criterion.
                ResourceName = adGroupCriterionResourceName,
                Status = AdGroupCriterionStatus.Enabled,
                ListingGroup = new ListingGroupInfo()
                {
                    Type = ListingGroupType.Subdivision,

                    // Set the ad group criterion resource name for the parent listing group.
                    // This can include a criterion ID if the parent criterion is not yet created.
                    // Use StringValue to convert from a String to a compatible argument type.
                    ParentAdGroupCriterion = parentAdGroupCriterionResourceName,

                    // Case values contain the listing dimension used for the node.
                    CaseValue = listingDimensionInfo
                }
            };

            return adGroupCriterion;
        }

        /// <summary>
        /// Creates a new criterion containing a root subdivision listing group node.
        /// </summary>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="adGroupId">The ID of the ad group.</param>
        /// <param name="adGroupCriterionId">The ID of the criterion. This value will used to
        /// construct the resource name. This can be a negative number if the criterion is yet
        /// to be created.</param>
        /// <returns>The ad group criterion object that contains the listing group root node.
        /// </returns>
        private AdGroupCriterion CreateListingGroupSubdivisionRoot(long customerId, long adGroupId,
            long adGroupCriterionId)
        {
            String adGroupCriterionResourceName = ResourceNames.AdGroupCriterion(customerId,
                adGroupId, adGroupCriterionId);

            AdGroupCriterion adGroupCriterion = new AdGroupCriterion()
            {
                // The resource name the criterion will be created with. This will define the ID
                // for the ad group criterion.
                ResourceName = adGroupCriterionResourceName,
                Status = AdGroupCriterionStatus.Enabled,
                ListingGroup = new ListingGroupInfo()
                {
                    // Set the type as a SUBDIVISION, which will allow the node to be the parent of
                    // another sub-tree.
                    Type = ListingGroupType.Subdivision
                }
            };
            return adGroupCriterion;
        }
    }
}

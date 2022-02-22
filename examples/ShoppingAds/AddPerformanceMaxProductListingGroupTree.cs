// Copyright 2022 Google LLC
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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V10.Common;
using Google.Ads.GoogleAds.V10.Enums;
using Google.Ads.GoogleAds.V10.Errors;
using Google.Ads.GoogleAds.V10.Resources;
using Google.Ads.GoogleAds.V10.Services;
using Google.Api.Gax;
using Google.Protobuf.Collections;
using Google.Protobuf;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading;
using static Google.Ads.GoogleAds.V10.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.AdGroupStatusEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.AdGroupTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.ConversionActionCategoryEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.ConversionOriginEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.AdvertisingChannelSubTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.AssetGroupStatusEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.ListingGroupFilterTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.ListingGroupFilterVerticalEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.ListingGroupFilterProductConditionEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.AssetTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.BiddingStrategyTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.BudgetTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.CriterionTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.ListingGroupTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.MediaTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.ProductConditionEnum.Types;
using static Google.Ads.GoogleAds.V10.Resources.Campaign.Types;
using static Google.Ads.GoogleAds.V10.Resources.ListingGroupFilterDimension.Types;
using static Google.Ads.GoogleAds.V10.Services.SmartCampaignSuggestionInfo.Types;

namespace Google.Ads.GoogleAds.Examples.V10
{
    /// <summary>
    /// This example shows how to add product partitions to a Performance Max retail campaign.
    ///
    /// For Performance Max campaigns, product partitions are represented using the
    /// AssetGroupListingGroupFilter resource. This resource can be combined with itself to form a
    /// hierarchy that creates a product partition tree.
    ///
    /// For more information about Performance Max retail campaigns, see the
    /// <see cref="AddPerformanceMaxRetailCampaign"/> example.
    /// </summary>
    public class AddPerformanceMaxProductListingGroupTree : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see
        /// cref="AddPerformanceMaxProductListingGroupTree"/>
        /// example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// The Asset Group ID.
            /// </summary>
            [Option("assetGroupId", Required = true, HelpText =
                "The Asset Group ID.")]
            public long AssetGroupId { get; set; }

            /// <summary>
            /// An option to remove the listing group tree from the asset group when this example is
            /// run.
            /// </summary>
            [Option("shouldReplaceExistingProductTree", Required = false, HelpText =
                "An option that removes the existing listing group tree from the asset group.")]
            public bool ShouldReplaceExistingProductTree { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = new Options();
            Parser.Default.ParseArguments<Options>(args).MapResult(
                delegate (Options o)
                {
                    options = o;
                    return 0;
                }, delegate (IEnumerable<Error> errors)
                {
                    // The Google Ads customer ID.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // The Asset Group ID
                    options.AssetGroupId = long.Parse("INSERT_ASSET_GROUP_ID_HERE");

                    // The option to remove the existing listing group tree.
                    //
                    // If the current AssetGroup already has a tree of ListingGroupFilter's, and you
                    // try to add a new set of ListinGroupFilter's including a root filter, you'll
                    // receive a 'ASSET_GROUP_LISTING_GROUP_FILTER_ERROR_MULTIPLE_ROOTS' error.
                    //
                    // Setting this option to true via the CLI or here will remove the existing tree
                    // and prevent this error.
                    options.ShouldReplaceExistingProductTree = false;

                    return 0;
                });

            AddPerformanceMaxProductListingGroupTree codeExample =
                new AddPerformanceMaxProductListingGroupTree();

            Console.WriteLine(codeExample.Description);

            codeExample.Run(
                new GoogleAdsClient(),
                options.CustomerId,
                options.AssetGroupId,
                options.ShouldReplaceExistingProductTree
            );
        }

        // [START add_performance_max_product_listing_group_tree]
        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example shows how to add a product listing group tree to  a " +
            "Performance Max retail campaign.";

        /// <summary>
        /// A factory that creates MutateOperation's for removing an existing tree of
        /// AssetGroupListingGroupFilter's.
        ///
        /// AssetGroupListingGroupFilter's must be removed in a specific order: all of the children
        /// of a filter must be removed before the filter itself, otherwise the API will return an
        /// error.
        ///
        /// This object is intended to be used with an array of MutateOperations to perform a series
        /// of related updates to an AssetGroup.
        /// </summary>
        private class AssetGroupListingGroupFilterRemoveOperationFactory {
            private string rootResourceName;
            private Dictionary<string, AssetGroupListingGroupFilter> resources;
            private Dictionary<string, HashSet<string>> parentsToChildren;

            public AssetGroupListingGroupFilterRemoveOperationFactory(
                List<AssetGroupListingGroupFilter> resources)
            {
                if (resources.Count == 0) {
                    throw new InvalidOperationException("No listing group filters to remove");
                }

                this.resources = new Dictionary<string, AssetGroupListingGroupFilter>();
                this.parentsToChildren = new Dictionary<string, HashSet<string>>();

                foreach (AssetGroupListingGroupFilter filter in resources)
                {
                    this.resources[filter.ResourceName] = filter;

                    // When the node has no parent, it means it's the root node, which is treated
                    // differently.
                    if (string.IsNullOrEmpty(filter.ParentListingGroupFilter))
                    {
                        if (!string.IsNullOrEmpty(this.rootResourceName))
                        {
                            throw new InvalidOperationException("More than one root node");
                        }

                        this.rootResourceName = filter.ResourceName;
                        continue;
                    }

                    string parentResourceName = filter.ParentListingGroupFilter;

                    HashSet<string> siblings;

                    // Check to see if we've already visited a sibling in this group, and fetch or
                    // create a new set as required.
                    if (this.parentsToChildren.ContainsKey(parentResourceName))
                    {
                        siblings = this.parentsToChildren[parentResourceName];
                    } else {
                        siblings = new HashSet<string>();
                    }

                    siblings.Add(filter.ResourceName);
                    this.parentsToChildren[parentResourceName] = siblings;
                }
            }

            // [START add_performance_max_product_listing_group_tree_2]
            /// <summary>
            /// Creates a list of MutateOperation's that remove all of the resources in the tree
            /// originally used to create this factory object.
            /// </summary>
            /// <returns>A list of MutateOperation's</returns>
            public List<MutateOperation> RemoveAll()
            {
                return this.RemoveDescendentsAndFilter(this.rootResourceName);
            }
            // [END add_performance_max_product_listing_group_tree_2]

            // [START add_performance_max_product_listing_group_tree_3]
            /// <summary>
            /// Creates a list of MutateOperation's that remove all the descendents of the specified
            /// AssetGroupListingGroupFilter resource name. The order of removal is post-order,
            /// where all the children (and their children, recursively) are removed first. Then,
            /// the node itself is removed.
            /// </summary>
            /// <returns>A list of MutateOperation's</returns>
            public List<MutateOperation> RemoveDescendentsAndFilter(string resourceName)
            {
                List<MutateOperation> operations =  new List<MutateOperation>();

                if (this.parentsToChildren.ContainsKey(resourceName))
                {
                    HashSet<string> children = this.parentsToChildren[resourceName];

                    foreach (string child in children)
                    {
                        operations.AddRange(this.RemoveDescendentsAndFilter(child));
                    }
                }

                AssetGroupListingGroupFilterOperation operation =
                    new AssetGroupListingGroupFilterOperation()
                    {
                        Remove = resourceName
                    };

                operations.Add(
                    new MutateOperation()
                    {
                        AssetGroupListingGroupFilterOperation = operation
                    }
                );

                return operations;
            }
            // [END add_performance_max_product_listing_group_tree_3]
        }

        private const int TEMPORARY_ID_LISTING_GROUP_ROOT = -1;

        /// <summary>
        /// A factory that creates MutateOperation's wrapping
        /// AssetGroupListingGroupFilterMutateOperation's for a specific customerId and
        /// assetGroupId.
        ///
        /// This object is intended to be used with an array of MutateOperations to perform an
        /// atomic update to an AssetGroup.
        /// </summary>
        private class AssetGroupListingGroupFilterCreateOperationFactory {
            private long customerId;
            private long assetGroupId;
            private long rootListingGroupId;
            private long nextId;

            public AssetGroupListingGroupFilterCreateOperationFactory(
                long customerId,
                long assetGroupId,
                long rootListingGroupId)
            {
                this.customerId = customerId;
                this.assetGroupId = assetGroupId;
                this.rootListingGroupId = rootListingGroupId;
                this.nextId = this.rootListingGroupId - 1;
            }

            /// <summary>
            /// Returns a new temporary ID to be used for a resource name in a MutateOperation. See
            /// https://developers.google.com/google-ads/api/docs/mutating/best-practices#temporary_resource_names
            /// for details about temporary ID's.
            /// </summary>
            /// <returns>A new temporary ID.</returns>
            public long NextId()
            {
                long i = nextId;
                Interlocked.Decrement(ref nextId);
                return i;
            }

            // [START add_performance_max_product_listing_group_tree_4]
            /// <summary>
            /// Creates a MutateOperation that creates a root AssetGroupListingGroupFilter for the
            /// factory's AssetGroup.
            ///
            /// The root node or partition is the default, which is displayed as "All Products".
            /// </summary>
            /// <returns>A MutateOperation</returns>
            public MutateOperation CreateRoot()
            {
                AssetGroupListingGroupFilter listingGroupFilter = new AssetGroupListingGroupFilter()
                {
                    ResourceName = ResourceNames.AssetGroupListingGroupFilter(
                        this.customerId,
                        this.assetGroupId,
                        this.rootListingGroupId
                    ),

                    AssetGroup = ResourceNames.AssetGroup(
                        this.customerId,
                        this.assetGroupId
                    ),

                    // The root listing group filter node should be unset.
                    // ParentListingGroupFilter = "",

                    // The UnitIncluded type means this node has no children, and listings that fall
                    // into this category will be included in ads.
                    Type = ListingGroupFilterType.Subdivision,

                    // Because this is a Performance Max campaign for retail, we need to specify
                    // that this is in the shopping vertical.
                    Vertical = ListingGroupFilterVertical.Shopping
                };

                AssetGroupListingGroupFilterOperation operation =
                    new AssetGroupListingGroupFilterOperation()
                    {
                        Create = listingGroupFilter
                    };

                return new MutateOperation()
                {
                    AssetGroupListingGroupFilterOperation = operation
                };
            }
            // [END add_performance_max_product_listing_group_tree_4]

            // [START add_performance_max_product_listing_group_tree_5]
            /// <summary>
            /// Creates a MutateOperation that creates a intermediate AssetGroupListingGroupFilter
            /// for the factory's AssetGroup.
            ///
            /// Use this method if the filter will have child filters. Otherwise, use the
            /// CreateUnit method.
            /// </summary>
            /// <param name="parent">The ID of the parent AssetGroupListingGroupFilter.</param>
            /// <param name="id">The ID of AssetGroupListingGroupFilter that will be
            /// created.</param>
            /// <param name="dimension">The dimension to associate with the
            /// AssetGroupListingGroupFilter.</param>
            /// <returns>A MutateOperation</returns>
            public MutateOperation CreateSubdivision(
                long parent,
                long id,
                ListingGroupFilterDimension dimension)
            {
                AssetGroupListingGroupFilter listingGroupFilter = new AssetGroupListingGroupFilter()
                {
                    ResourceName = ResourceNames.AssetGroupListingGroupFilter(
                        this.customerId,
                        this.assetGroupId,
                        id
                    ),

                    AssetGroup = ResourceNames.AssetGroup(
                        this.customerId,
                        this.assetGroupId
                    ),

                    ParentListingGroupFilter = ResourceNames.AssetGroupListingGroupFilter(
                        this.customerId,
                        this.assetGroupId,
                        parent
                    ),

                    // We must use the Subdivision type to indicate that the
                    // AssetGroupListingGroupFilter will have children.
                    Type = ListingGroupFilterType.Subdivision,

                    // Because this is a Performance Max campaign for retail, we need to specify
                    // that this is in the shopping vertical.
                    Vertical = ListingGroupFilterVertical.Shopping,

                    CaseValue = dimension
                };

                AssetGroupListingGroupFilterOperation filterOperation =
                    new AssetGroupListingGroupFilterOperation()
                    {
                        Create = listingGroupFilter
                    };

                return new MutateOperation()
                {
                    AssetGroupListingGroupFilterOperation = filterOperation
                };
            }
            // [END add_performance_max_product_listing_group_tree_5]

            // [START add_performance_max_product_listing_group_tree_6]
            /// <summary>
            /// Creates a MutateOperation that creates a child AssetGroupListingGroupFilter
            /// for the factory's AssetGroup.
            ///
            /// Use this method if the filter won't have child filters. Otherwise, use the
            /// CreateSubdivision method.
            /// </summary>
            /// <param name="parent">The ID of the parent AssetGroupListingGroupFilter.</param>
            /// <param name="id">The ID of AssetGroupListingGroupFilter that will be
            /// created.</param>
            /// <param name="dimension">The dimension to associate with the
            /// AssetGroupListingGroupFilter.</param>
            /// <returns>A MutateOperation</returns>
            public MutateOperation CreateUnit(
                long parent,
                long id,
                ListingGroupFilterDimension dimension)
            {
                AssetGroupListingGroupFilter listingGroupFilter = new AssetGroupListingGroupFilter()
                {
                    ResourceName = ResourceNames.AssetGroupListingGroupFilter(
                        this.customerId,
                        this.assetGroupId,
                        id
                    ),

                    AssetGroup = ResourceNames.AssetGroup(
                        this.customerId,
                        this.assetGroupId
                    ),

                    ParentListingGroupFilter = ResourceNames.AssetGroupListingGroupFilter(
                        this.customerId,
                        this.assetGroupId,
                        parent
                    ),

                    // We must use the UnitIncluded type to indicate that the
                    // AssetGroupListingGroupFilter won't have children.
                    Type = ListingGroupFilterType.UnitIncluded,

                    // Because this is a Performance Max campaign for retail, we need to specify
                    // that this is in the shopping vertical.
                    Vertical = ListingGroupFilterVertical.Shopping,

                    CaseValue = dimension
                };

                AssetGroupListingGroupFilterOperation filterOperation =
                    new AssetGroupListingGroupFilterOperation()
                    {
                        Create = listingGroupFilter
                    };

                return new MutateOperation()
                {
                    AssetGroupListingGroupFilterOperation = filterOperation
                };
            }
            // [END add_performance_max_product_listing_group_tree_6]
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="assetGroupId">The asset group id for the Performance Max campaign.</param>
        /// <param name="shouldReplaceExistingProductTree">Option to remove existing product tree
        /// from the passed in asset group.</param>
        public void Run(
            GoogleAdsClient client,
            long customerId,
            long assetGroupId,
            bool shouldReplaceExistingProductTree)
        {
            // [START add_performance_max_product_listing_group_tree_1]
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V10.GoogleAdsService);

            string assetGroupResourceName = ResourceNames.AssetGroup(customerId, assetGroupId);

            // We use a factory create all the MutateOperation's that manipulate a specific
            // AssetGroup for a specific customer. The operations returned by the factory's methods
            // are used to optionally remove all AssetGroupListingGroupFilter's from the tree, and
            // then to construct a new tree of filters. These filters can have a parent-child
            // relationship, and also include a special root that includes all children.
            //
            // When creating these filters, we use temporary ID's to create the hierarchy between
            // the root listing group filter, and the subdivisions and leave nodes beneath that.
            //
            // The factory specific to a customerId and assetGroupId is created below.
            AssetGroupListingGroupFilterCreateOperationFactory createOperationFactory =
                new AssetGroupListingGroupFilterCreateOperationFactory(
                    customerId,
                    assetGroupId,
                    TEMPORARY_ID_LISTING_GROUP_ROOT
                );

            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest
            {
                CustomerId = customerId.ToString()
            };

            if (shouldReplaceExistingProductTree)
            {
                List<AssetGroupListingGroupFilter> existingListingGroupFilters =
                    GetAllExistingListingGroupFilterAssetsInAssetGroup(
                        client,
                        customerId,
                        assetGroupResourceName
                    );

                if (existingListingGroupFilters.Count > 0) {
                    // A special factory object that ensures the creation of remove operations in the
                    // correct order (child listing group filters must be removed before their parents).
                    AssetGroupListingGroupFilterRemoveOperationFactory removeOperationFactory =
                        new AssetGroupListingGroupFilterRemoveOperationFactory(
                            existingListingGroupFilters
                        );

                    request.MutateOperations.AddRange(removeOperationFactory.RemoveAll());
                }
            }

            request.MutateOperations.Add(createOperationFactory.CreateRoot());

            request.MutateOperations.Add(
                createOperationFactory.CreateUnit(
                    TEMPORARY_ID_LISTING_GROUP_ROOT,
                    createOperationFactory.NextId(),
                    new ListingGroupFilterDimension()
                    {
                        ProductCondition = new ListingGroupFilterDimension.Types.ProductCondition()
                        {
                            Condition = ListingGroupFilterProductCondition.New
                        }
                    }
                )
            );

            request.MutateOperations.Add(
                createOperationFactory.CreateUnit(
                    TEMPORARY_ID_LISTING_GROUP_ROOT,
                    createOperationFactory.NextId(),
                    new ListingGroupFilterDimension()
                    {
                        ProductCondition = new ListingGroupFilterDimension.Types.ProductCondition()
                        {
                            Condition = ListingGroupFilterProductCondition.Used
                        }
                    }
                )
            );

            // We save this ID because create child nodes underneath it.
            long subdivisionIdConditionOther = createOperationFactory.NextId();

            request.MutateOperations.Add(
                // We're calling CreateSubdivision because this listing group will have children.
                createOperationFactory.CreateSubdivision(
                    TEMPORARY_ID_LISTING_GROUP_ROOT,
                    subdivisionIdConditionOther,
                    new ListingGroupFilterDimension()
                    {
                        // All sibling nodes must have the same dimension type. We use an empty
                        // ProductCondition to indicate that this is an "Other" partition.
                        ProductCondition = new ListingGroupFilterDimension.Types.ProductCondition()
                    }
                )
            );

            request.MutateOperations.Add(
                createOperationFactory.CreateUnit(
                    subdivisionIdConditionOther,
                    createOperationFactory.NextId(),
                    new ListingGroupFilterDimension()
                    {
                        ProductBrand = new ProductBrand()
                        {
                            Value = "CoolBrand"
                        }
                    }
                )
            );

            request.MutateOperations.Add(
                createOperationFactory.CreateUnit(
                    subdivisionIdConditionOther,
                    createOperationFactory.NextId(),
                    new ListingGroupFilterDimension()
                    {
                        ProductBrand = new ProductBrand()
                        {
                            Value = "CheapBrand"
                        }
                    }
                )
            );

            request.MutateOperations.Add(
                createOperationFactory.CreateUnit(
                    subdivisionIdConditionOther,
                    createOperationFactory.NextId(),
                    new ListingGroupFilterDimension()
                    {
                        ProductBrand = new ProductBrand()
                    }
                )
            );

            MutateGoogleAdsResponse response = googleAdsServiceClient.Mutate(request);

            PrintResponseDetails(request, response);
            // [END add_performance_max_product_listing_group_tree_1]
        }

        // [START add_performance_max_product_listing_group_tree_7]
        /// <summary>
        /// Fetches all of the listing group filters in an asset group.
        /// </summary>
        /// <param name="client">The Google Ads Client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="assetGroupResourceName">The resource name of the asset group.</param>
        /// <returns>A list of asset group listing filter resources.</returns>
        private List<AssetGroupListingGroupFilter>
            GetAllExistingListingGroupFilterAssetsInAssetGroup(
                GoogleAdsClient client,
                long customerId,
                string assetGroupResourceName)
        {
            List<AssetGroupListingGroupFilter> resources =  new List<AssetGroupListingGroupFilter>();

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V10.GoogleAdsService);

            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                PageSize = 10000,
                Query =
                    $@"
                    SELECT
                        asset_group_listing_group_filter.resource_name,
                        asset_group_listing_group_filter.parent_listing_group_filter
                    FROM asset_group_listing_group_filter
                    WHERE
                        asset_group_listing_group_filter.asset_group = '{assetGroupResourceName}'
                    "
            };

            // The below enumerable will automatically iterate through the pages of the search
            // request. The limit to the number of listing group filters permitted in a Performance
            // Max campaign can be found here:
            // https://developers.google.com/google-ads/api/docs/best-practices/system-limits
            PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchPagedResponse =
                googleAdsService.Search(request);

            foreach (GoogleAdsRow row in searchPagedResponse)
            {
                resources.Add(row.AssetGroupListingGroupFilter);
            }

            return resources;
        }
        // [END add_performance_max_product_listing_group_tree_7]
        // [START add_performance_max_product_listing_group_tree]

        /// <summary>
        /// Prints the details of a MutateGoogleAdsResponse. Parses the "response" oneof field name
        /// and uses it to extract the new entity's name and resource name.
        /// </summary>
        /// <param name="request">A MutateGoogleAdsRequest instance.</param>
        /// <param name="response">A MutateGoogleAdsResponse instance.</param>
        private void PrintResponseDetails(MutateGoogleAdsRequest request, MutateGoogleAdsResponse response)
        {
            // Parse the Mutate response to print details about the entities that were created
            // in the request.
            for (int i = 0; i < response.MutateOperationResponses.Count; i++)
            {
                MutateOperation operationRequest = request.MutateOperations[i];
                MutateOperationResponse operationResponse = response.MutateOperationResponses[i];

                if (operationResponse.ResponseCase != MutateOperationResponse.ResponseOneofCase.AssetGroupListingGroupFilterResult)
                {
                    string entityName = operationResponse.ResponseCase.ToString();
                    // Trim the substring "Result" from the end of the entity name.
                    entityName = entityName.Remove(entityName.Length - 6);

                    Console.WriteLine($"Unsupported entity type: {entityName}");
                }

                string resourceName = operationResponse.AssetGroupListingGroupFilterResult.ResourceName;
                AssetGroupListingGroupFilterOperation assetOperation = operationRequest.AssetGroupListingGroupFilterOperation;

                switch (assetOperation.OperationCase)
                {
                    case AssetGroupListingGroupFilterOperation.OperationOneofCase.Create:
                        Console.WriteLine(
                            $"Created a(n) AssetGroupListingGroupFilter with resource name: '{resourceName}'.");
                        break;

                    case AssetGroupListingGroupFilterOperation.OperationOneofCase.Remove:
                        Console.WriteLine(
                            $"Removed a(n) AssetGroupListingGroupFilter with resource name: '{resourceName}'.");
                        break;

                    default:
                        Console.WriteLine($"Unsupported operation type: {assetOperation.OperationCase.ToString()}");
                        continue;
                }
            }
        }
    }
}

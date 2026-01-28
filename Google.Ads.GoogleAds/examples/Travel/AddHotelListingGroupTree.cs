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
using Google.Ads.GoogleAds.V23.Common;
using Google.Ads.GoogleAds.V23.Errors;
using Google.Ads.GoogleAds.V23.Resources;
using Google.Ads.GoogleAds.V23.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V23.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V23.Enums.ListingGroupTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V23
{
    /// <summary>
    /// This example shows how to add a hotel listing group tree, which has two levels. The first
    /// level is partitioned by the hotel class. The second level is partitioned by the country
    /// region.
    ///
    /// Each level is composed of two types of nodes: `UNIT` and `SUBDIVISION`.
    /// `UNIT` nodes serve as a leaf node in a tree and can have bid amount set.
    /// `SUBDIVISION` nodes serve as an internal node where a subtree will be built. The
    /// `SUBDIVISION` node can't have bid amount set.
    /// See https://developers.google.com/google-ads/api/docs/hotel-ads/overview for more information.
    ///
    /// Note: Only one listing group tree can be added. Attempting to add another listing group tree
    /// to an ad group that already has one will fail.
    /// </summary>
    public class AddHotelListingGroupTree : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddHotelListingGroupTree"/> example.
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
            /// The ad group ID of the ad group to which the hotel listing will be added.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "The ad group ID of the ad group to which the hotel listing will be added.")]
            public long AdGroupId { get; set; }

            /// <summary>
            /// The CPC bid micro amount to be set on created ad group criteria.
            /// </summary>
            [Option("percentCpcBidMicroAmount", Required = true, HelpText =
                "The CPC bid micro amount to be set on created ad group criteria.")]
            public long PercentCpcBidMicroAmount { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddHotelListingGroupTree codeExample = new AddHotelListingGroupTree();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.AdGroupId,
                options.PercentCpcBidMicroAmount);
        }

        // The next temporary criterion ID to be used, which is a negative integer.

        // When creating a tree, we need to specify the parent-child relationships between nodes.
        // However, until a criterion has been created on the server we do not have a criterion ID
        // with which to refer to it.

        // Instead, we can specify temporary IDs that are specific to a single mutate request. Once
        // a criterion is created, it is assigned an ID as normal and the temporary ID will no
        // longer refer to it.
        private int nextTempId = -1;

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example shows how to add a hotel listing group tree, which has two levels. The " +
            "first level is partitioned by the hotel class. The second level is partitioned by " +
            "the country region.\n\n" +
            "Each level is composed of two types of nodes: `UNIT` and `SUBDIVISION`.\n" +
            "\t'UNIT' nodes serve as a leaf node in a tree and can have bid amount set.\n" +
            "\t'SUBDIVISION' nodes serve as an internal node where a subtree will be built. The " +
            "'SUBDIVISION' node can't have bid amount set.\n" +
            "See https://developers.google.com/google-ads/api/docs/hotel-ads/overview for more " +
            "information.\n\n" +
            "Note: Only one listing group tree can be added. Attempting to add another listing " +
            "group tree to an ad group that already has one will fail.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="adGroupId">The ad group ID of the ad group to which the hotel listing will
        /// be added.</param>
        /// <param name="percentCpcBidMicroAmount">The CPC bid micro amount to be set on created
        /// ad group criteria.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId,
            long percentCpcBidMicroAmount)
        {
            // Get the AdGroupCriterionService client.
            AdGroupCriterionServiceClient adGroupCriterionService =
                client.GetService(Services.V23.AdGroupCriterionService);

            List<AdGroupCriterionOperation> operations = new List<AdGroupCriterionOperation>();

            try
            {
                // Creates the root of the tree as a SUBDIVISION node.
                string rootResourceName = AddRootNode(customerId, adGroupId, operations,
                    percentCpcBidMicroAmount);

                // Creates child nodes of level 1, partitioned by the hotel class info.
                string otherHotelResourceName = AddLevel1Nodes(customerId, adGroupId,
                    rootResourceName, operations, percentCpcBidMicroAmount);

                // Creates child nodes of level 2, partitioned by the hotel country region info.
                AddLevel2Nodes(customerId, adGroupId, otherHotelResourceName, operations,
                    percentCpcBidMicroAmount);

                // Adds the listing group and prints the resulting node resource names.
                MutateAdGroupCriteriaResponse response =
                    adGroupCriterionService.MutateAdGroupCriteria(customerId.ToString(),
                        operations);

                Console.WriteLine($"Added {response.Results.Count} listing group info entities " +
                    "with resource names:");
                foreach (MutateAdGroupCriterionResult adGroupCriterionResult in response.Results)
                {
                    Console.WriteLine($"\t{adGroupCriterionResult.ResourceName}");
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
        /// Creates the root node of the listing group tree and adds its create operation to the
        /// operations list.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="adGroupId">The ad group ID to which the hotel listing group will be
        ///     added.</param>
        /// <param name="operations">A list of AdGroupCriterionOperations.</param>
        /// <param name="percentCpcBidMicroAmount">The CPC bid micro amount to be set on created
        ///     ad group criteria.</param>
        /// <returns>The string resource name of the root of the tree.</returns>
        private string AddRootNode(long customerId, long adGroupId,
            List<AdGroupCriterionOperation> operations, long percentCpcBidMicroAmount)
        {
            // Create the root of the tree as a SUBDIVISION node.
            ListingGroupInfo rootListingGroupInfo =
                CreateListingGroupInfo(ListingGroupType.Subdivision);

            AdGroupCriterion rootAdGroupCriterion = CreateAdGroupCriterion(customerId, adGroupId,
                rootListingGroupInfo, percentCpcBidMicroAmount);

            // Create an operation and add it to the list of operations.
            operations.Add(new AdGroupCriterionOperation
            {
                Create = rootAdGroupCriterion
            });

            // Decrement the temp ID for the next ad group criterion.
            nextTempId--;

            return rootAdGroupCriterion.ResourceName;
        }

        /// <summary>
        /// Creates child nodes on level 1, partitioned by the hotel class info.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="adGroupId">The ad group ID to which the hotel listing group will be
        /// added.</param>
        /// <param name="rootResourceName">The string resource name of the listing group's root
        /// node.</param>
        /// <param name="operations">A list of AdGroupCriterionOperations.</param>
        /// <param name="percentCpcBidMicroAmount">The CPC bid micro amount to be set on created
        /// ad group criteria.</param>
        /// <returns>The string resource name of the "other hotel classes" node, which serves as the
        /// parent node for the next level of the listing tree.</returns>
        // [START add_hotel_listing_group_tree]
        private string AddLevel1Nodes(long customerId, long adGroupId, string rootResourceName,
            List<AdGroupCriterionOperation> operations, long percentCpcBidMicroAmount)
        {
            // Create listing dimension info for 5-star class hotels.
            ListingDimensionInfo fiveStarredListingDimensionInfo = new ListingDimensionInfo
            {
                HotelClass = new HotelClassInfo
                {
                    Value = 5
                }
            };

            // Create a listing group info for 5-star hotels as a UNIT node.
            ListingGroupInfo fiveStarredUnit = CreateListingGroupInfo(ListingGroupType.Unit,
                rootResourceName, fiveStarredListingDimensionInfo);

            // Create an ad group criterion for 5-star hotels.
            AdGroupCriterion fiveStarredAdGroupCriterion = CreateAdGroupCriterion(customerId,
                adGroupId, fiveStarredUnit, percentCpcBidMicroAmount);

            // Create an operation and add it to the list of operations.
            operations.Add(new AdGroupCriterionOperation
            {
                Create = fiveStarredAdGroupCriterion
            });

            // Decrement the temp ID for the next ad group criterion.
            nextTempId--;

            // You can also create more UNIT nodes for other hotel classes by copying the above code
            // in this method and modifying the value passed to HotelClassInfo().
            // For instance, passing 4 instead of 5 in the above code will instead create a UNIT
            // node of 4-star hotels.

            // Create hotel class info and dimension info for other hotel classes by *not*
            // specifying any attributes on those object.
            ListingDimensionInfo otherHotelsListingDimensionInfo = new ListingDimensionInfo
            {
                HotelClass = new HotelClassInfo()
            };

            // Create listing group info for other hotel classes as a SUBDIVISION node, which will
            // be used as a parent node for children nodes of the next level.
            ListingGroupInfo otherHotelsSubdivisionListingGroupInfo = CreateListingGroupInfo
                (ListingGroupType.Subdivision, rootResourceName, otherHotelsListingDimensionInfo);

            // Create an ad group criterion for other hotel classes.
            AdGroupCriterion otherHotelsAdGroupCriterion = CreateAdGroupCriterion(customerId,
                adGroupId, otherHotelsSubdivisionListingGroupInfo, percentCpcBidMicroAmount);

            // Create an operation and add it to the list of operations.
            operations.Add(new AdGroupCriterionOperation
            {
                Create = otherHotelsAdGroupCriterion
            });

            // Decrement the temp ID for the next ad group criterion.
            nextTempId--;

            return otherHotelsAdGroupCriterion.ResourceName;
        }
        // [END add_hotel_listing_group_tree]

        /// <summary>
        /// Creates child nodes on level 2, partitioned by the country region.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="adGroupId">The ad group ID to which the hotel listing group will be
        /// added.</param>
        /// <param name="parentResourceName">The resource name of the parent criterion for the
        /// nodes to be added at this level.</param>
        /// <param name="operations">A list of AdGroupCriterionOperations.</param>
        /// <param name="percentCpcBidMicroAmount">The CPC bid micro amount to be set on created
        /// ad group criteria.</param>
        private void AddLevel2Nodes(long customerId, long adGroupId, string parentResourceName,
            List<AdGroupCriterionOperation> operations, long percentCpcBidMicroAmount)
        {
            // Create hotel dimension info for hotels in Japan. The criterion ID for Japan is 2392.
            // See https://developers.google.com/google-ads/api/reference/data/geotargets for
            // criteria ID of other countries.
            ListingDimensionInfo japanListingDimensionInfo = new ListingDimensionInfo
            {
                HotelCountryRegion = new HotelCountryRegionInfo
                {
                    CountryRegionCriterion = ResourceNames.GeoTargetConstant(2392)
                }
            };

            // Create listing group info for hotels in Japan as a UNIT node.
            ListingGroupInfo japanHotelsUnit = CreateListingGroupInfo(ListingGroupType.Unit,
                parentResourceName, japanListingDimensionInfo);

            // Create an ad group criterion for hotels in Japan.
            AdGroupCriterion japanHotelsAdGroupCriterion = CreateAdGroupCriterion(customerId,
                adGroupId, japanHotelsUnit, percentCpcBidMicroAmount);

            // Create an operation and add it to the list of operations.
            operations.Add(new AdGroupCriterionOperation
            {
                Create = japanHotelsAdGroupCriterion
            });

            // Decrement the temp ID for the next ad group criterion.
            nextTempId--;

            // Create hotel class info and dimension info for hotels in other regions.
            ListingDimensionInfo otherHotelRegionsListingDimensionInfo = new ListingDimensionInfo
            {
                HotelCountryRegion = new HotelCountryRegionInfo()
            };

            // Create listing group info for hotels in other regions as a UNIT node.
            // The "others" node is always required for every level of the tree.
            ListingGroupInfo otherHotelRegionsUnit = CreateListingGroupInfo(
                ListingGroupType.Unit, parentResourceName, otherHotelRegionsListingDimensionInfo);

            // Create an ad group criterion for other hotel country regions.
            AdGroupCriterion otherHotelRegionsAdGroupCriterion =
                CreateAdGroupCriterion(customerId, adGroupId, otherHotelRegionsUnit,
                    percentCpcBidMicroAmount);

            // Create an operation and add it to the list of operations.
            operations.Add(new AdGroupCriterionOperation
            {
                Create = otherHotelRegionsAdGroupCriterion
            });

            // Decrement the temp ID for the next ad group criterion.
            nextTempId--;
        }

        /// <summary>
        /// Creates the listing group info with the provided parameters.
        /// </summary>
        /// <param name="listingGroupType">The listing group type.</param>
        /// <param name="parentCriterionResourceName">Optional resource name of the parent criterion
        ///     ID to set for this listing group info.</param>
        /// <param name="caseValue">Optional dimension info for the listing group.</param>
        /// <returns>A populated ListingGroupInfo.</returns>
        private ListingGroupInfo CreateListingGroupInfo(ListingGroupType listingGroupType,
            string parentCriterionResourceName = null, ListingDimensionInfo caseValue = null)
        {
            ListingGroupInfo listingGroupInfo = new ListingGroupInfo
            {
                Type = listingGroupType
            };

            if (parentCriterionResourceName != null)
            {
                listingGroupInfo.ParentAdGroupCriterion = parentCriterionResourceName;
                listingGroupInfo.CaseValue = caseValue;
            }

            return listingGroupInfo;
        }

        /// <summary>
        /// Creates an ad group criterion from the provided listing group info.
        /// Bid amount will be set on the created ad group criterion when listing group info type
        /// is `UNIT`. Setting bid amount for `SUBDIVISION` types is not allowed.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="adGroupId">The ad group ID to which the criterion will belong.</param>
        /// <param name="listingGroupInfo">The listing group info to apply to the criterion.</param>
        /// <param name="percentCpcBidMicroAmount">The CPC bid micro amount to set for the
        /// ad group criterion.</param>
        /// <returns>A populated ad group criterion.</returns>
        private AdGroupCriterion CreateAdGroupCriterion(long customerId, long adGroupId,
            ListingGroupInfo listingGroupInfo, long percentCpcBidMicroAmount)
        {
            AdGroupCriterion adGroupCriterion = new AdGroupCriterion
            {
                Status = AdGroupCriterionStatus.Enabled,
                ListingGroup = listingGroupInfo,
                ResourceName = ResourceNames.AdGroupCriterion(customerId, adGroupId, nextTempId)
            };

            // Bids are only valid for UNIT nodes.
            if (listingGroupInfo.Type == ListingGroupType.Unit)
            {
                adGroupCriterion.PercentCpcBidMicros = percentCpcBidMicroAmount;
            }

            return adGroupCriterion;
        }
    }
}

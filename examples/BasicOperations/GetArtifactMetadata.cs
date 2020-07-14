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
using Google.Ads.GoogleAds.V4.Errors;
using Google.Ads.GoogleAds.V4.Resources;
using Google.Ads.GoogleAds.V4.Services;
using Google.Api.Gax;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Ads.GoogleAds.Examples.V4
{
    /// <summary>
    /// This code example gets the metadata, such as whether the artifact is selectable, filterable
    /// and sortable, of an artifact. The artifact can be either a resource (such as customer,
    /// campaign) or a field (such as metrics.impressions, campaign.id). It'll also show the data
    /// type and artifacts that are selectable with the artifact.
    /// </summary>
    public class GetArtifactMetadata : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            GetArtifactMetadata codeExample = new GetArtifactMetadata();

            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The artifact for which metadata is retrieved. The artifact can be either a
            // resource (such as customer, campaign) or a field (such as metrics.impressions,
            // campaign.id).
            string artifactName = "INSERT_ARTIFACT_NAME_HERE";

            codeExample.Run(new GoogleAdsClient(), customerId, artifactName);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example gets the metadata, such as whether the artifact is " +
                    "selectable, filterable and sortable, of an artifact. The artifact can be " +
                    "either a resource (such as customer, campaign) or a field (such as " +
                    "metrics.impressions, campaign.id). It'll also show the data type and " +
                    "artifacts that are selectable with the artifact.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="artifactName">The artifact for which metadata is retrieved.</param>
        public void Run(GoogleAdsClient client, long customerId, string artifactName)
        {
            // Get the GoogleAdsFieldService.
            GoogleAdsFieldServiceClient googleAdsFieldService = client.GetService(
                Services.V4.GoogleAdsFieldService);

            // Create the query.
            string searchQuery = $"SELECT name, category, selectable, filterable, sortable, " +
                $"selectable_with, data_type, is_repeated WHERE name = '{artifactName}'";

            try
            {
                // Search for an artifact whose name is the same as the specified artifactName.
                PagedEnumerable<SearchGoogleAdsFieldsResponse, GoogleAdsField> googleAdsFields =
                    googleAdsFieldService.SearchGoogleAdsFields(searchQuery);

                if (googleAdsFields.Any())
                {
                    // Get all returned artifacts and print out their metadata.
                    foreach (GoogleAdsField googleAdsField in googleAdsFields)
                    {
                        Console.WriteLine("An artifact named '{0}' with category '{1}' and " +
                            "data type '{2}' {3} selectable, {4} filterable, {5} sortable " +
                            "and {6} repeated.",
                            googleAdsField.Name, googleAdsField.Category, googleAdsField.DataType,
                            getIsOrIsNot(googleAdsField.Selectable),
                            getIsOrIsNot(googleAdsField.Filterable),
                            getIsOrIsNot(googleAdsField.Sortable),
                            getIsOrIsNot(googleAdsField.IsRepeated));

                        List<string> selectableLists = new List<string>(
                            googleAdsField.SelectableWith);
                        selectableLists.Sort();

                        Console.WriteLine("The artifact can be selected with the following " +
                            "artifacts:");
                        foreach (string item in selectableLists)
                        {
                            Console.WriteLine("- " + item);
                        }
                    }
                }
                else
                {
                    Console.Error.WriteLine($"The specified artifact '{artifactName}' " +
                        "doesn't exist.");
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
        /// Returns "is" when the specified value is true and "is not" when the specified value
        /// is false.
        /// </summary>
        /// <param name="boolValue">The bool value.</param>
        /// <returns>True, </returns>
        private String getIsOrIsNot(bool? boolValue)
        {
            return boolValue.Value ? "is" : "is not";
        }
    }
}

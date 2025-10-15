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
using Google.Ads.GoogleAds.V22.Errors;
using Google.Ads.GoogleAds.V22.Resources;
using Google.Ads.GoogleAds.V22.Services;
using Google.Api.Gax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Ads.GoogleAds.Examples.V22
{
    /// <summary>
    /// This code example searches for <see cref="GoogleAdsField" /> that match a given prefix,
    /// retrieving metadata such as whether the field is selectable, filterable, or sortable,
    /// along with the data type and the fields that are selectable with the field. Each
    /// <code>GoogleAdsField</code> represents either a resource (such as <code>customer</code>,
    /// <code>campaign</code> or a field (such as <code>metrics.impressions</code>,
    /// <code>campaign.id</code>).
    /// </summary>
    public class SearchForGoogleAdsFields : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="SearchForGoogleAdsFields"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The name prefix to search for matching GoogleAdsFields.
            /// </summary>
            [Option("namePrefix", Required = true, HelpText =
                "The name prefix to search for matching GoogleAdsFields.")]
            public string NamePrefix { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            SearchForGoogleAdsFields codeExample = new SearchForGoogleAdsFields();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.NamePrefix);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example searches for <see cref='GoogleAdsField' /> that match a given " +
            "prefix retrieving metadata such as whether the field is selectable, filterable, " +
            "or sortable, along with the data type and the fields that are selectable with " +
            "the field. Each <code>GoogleAdsField</code> represents either a resource (such " +
            "as <code>customer</code>, <code>campaign</code> or a field (such as " +
            "<code>metrics.impressions</code>, <code>campaign.id</code>).";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="namePrefix">The name prefix to search for matching GoogleAdsFields.</param>
        public void Run(GoogleAdsClient client, string namePrefix)
        {
            // Get the GoogleAdsFieldService.
            GoogleAdsFieldServiceClient googleAdsFieldService = client.GetService(
                Services.V22.GoogleAdsFieldService);

            // Create the query.
            string searchQuery = $"SELECT name, category, selectable, filterable, sortable, " +
                $"selectable_with, data_type, is_repeated, selectable_with WHERE " +
                $"name LIKE '{namePrefix}%%'";

            try
            {
                // Searches for all fields whose name begins with the specified namePrefix.
                PagedEnumerable<SearchGoogleAdsFieldsResponse, GoogleAdsField> googleAdsFields =
                    googleAdsFieldService.SearchGoogleAdsFields(searchQuery);

                if (googleAdsFields.Any())
                {
                    // Get all returned artifacts and print out their metadata.
                    foreach (GoogleAdsField googleAdsField in googleAdsFields)
                    {
                        Console.WriteLine(googleAdsField.Name);
                        Console.WriteLine($"  Category: {googleAdsField.Category}");
                        Console.WriteLine($"  DataType: {googleAdsField.DataType}");
                        Console.WriteLine($"  Selectable: {googleAdsField.Selectable}");
                        Console.WriteLine($"  Filterable: {googleAdsField.Filterable}");
                        Console.WriteLine($"  Sortable: {googleAdsField.Sortable}");
                        Console.WriteLine($"  Repeated: {googleAdsField.IsRepeated}");

                        if (googleAdsField.SelectableWith.Count > 0)
                        {
                            List<string> selectableLists = new List<string>(
                                googleAdsField.SelectableWith);
                            selectableLists.Sort();

                            Console.WriteLine("  Selectable with:");
                            foreach (string item in selectableLists)
                            {
                                Console.WriteLine($"    {item}");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.Error.WriteLine($"No GoogleAdsFields found with a name that " +
                        $"begins with '{namePrefix}'.");
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

// Copyright 2019 Google LLC.
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
using Google.Ads.GoogleAds.V12.Errors;
using Google.Ads.GoogleAds.V12.Resources;
using Google.Ads.GoogleAds.V12.Services;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V12
{
    /// <summary>
    /// This code example illustrates getting keywords and demonstrates how to use the
    /// omit_unselected_resource_names option in GAQL to reduce payload size.
    /// </summary>
    public class GetKeywords : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetKeywords"/> example.
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
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("omitUnselectedResourceNames", Required = false, HelpText =
                "Specifies whether to omit unselected resource names from response.",
                Default = false)]
            public bool? OmitUnselectedResourceNames { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            GetKeywords codeExample = new GetKeywords();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId, options.OmitUnselectedResourceNames);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This code example illustrates getting keywords " +
            "and demonstrates how to use the omit_unselected_resource_names option in GAQL to " +
            "reduce payload size.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="omitUnselectedResourceNames">Specifies whether to omit unselected resource
        /// names from response.</param>
        public void Run(GoogleAdsClient client, long customerId, bool? omitUnselectedResourceNames)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V12.GoogleAdsService);
            try
            {
                string query =
                    $@"SELECT
                        ad_group.id,
                        ad_group.status,
                        ad_group_criterion.criterion_id,
                        ad_group_criterion.keyword.text,
                        ad_group_criterion.keyword.match_type
                    FROM ad_group_criterion
                    WHERE ad_group_criterion.type = 'KEYWORD'
                        AND ad_group.status = 'ENABLED'
                        AND ad_group_criterion.status IN ('ENABLED', 'PAUSED')";

                // Adds omit_unselected_resource_names=true to the PARAMETERS clause of the
                // Google Ads Query Language (GAQL) query, which excludes the resource names of
                // all resources that aren't explicitly requested in the SELECT clause.
                // Enabling this option reduces payload size, but if you plan to use a returned
                // object in subsequent mutate operations, make sure you explicitly request its
                // "resource_name" field in the SELECT clause.
                //
                // Read more about PARAMETERS:
                // https://developers.google.com/google-ads/api/docs/query/structure#parameters
                if (omitUnselectedResourceNames.HasValue && omitUnselectedResourceNames.Value)
                {
                    query += " PARAMETERS omit_unselected_resource_names=true";
                }

                googleAdsService.SearchStream(customerId.ToString(), query,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        foreach (GoogleAdsRow criterionRow in resp.Results)
                        {
                            AdGroup adGroup = criterionRow.AdGroup;
                            AdGroupCriterion criterion = criterionRow.AdGroupCriterion;
                            string andResourceName = null;
                            if (omitUnselectedResourceNames.HasValue &&
                                omitUnselectedResourceNames.Value)
                            {
                                andResourceName = "";
                            }
                            else
                            {
                                andResourceName = $" and resource name '{adGroup.ResourceName}'";
                            }

                            Console.WriteLine("Keyword with text '{0}', id = '{1}' and " +
                                "match type = '{2}' was retrieved for ad group '{3}'{4}.",
                                criterion.Keyword.Text, criterion.CriterionId,
                                criterion.Keyword.MatchType, adGroup.Id, andResourceName);
                        }
                    }
                );
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

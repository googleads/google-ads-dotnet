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
using Google.Ads.GoogleAds.V15.Errors;
using Google.Ads.GoogleAds.V15.Services;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V15
{
    /// <summary>
    /// This code example illustrates getting GeoTargetConstants by given location names.
    /// </summary>
    public class GetGeoTargetConstantsByNames : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetGeoTargetConstantsByNames"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            GetGeoTargetConstantsByNames codeExample = new GetGeoTargetConstantsByNames();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient());
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example illustrates getting GeoTargetConstants by given location names.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        // [START get_geo_target_constants_by_names]
        public void Run(GoogleAdsClient client)
        {
            // Get the GeoTargetConstantServiceClient.
            GeoTargetConstantServiceClient geoService =
                client.GetService(Services.V15.GeoTargetConstantService);

            // Locale is using ISO 639-1 format. If an invalid locale is given,
            // 'en' is used by default.
            string locale = "en";

            // A list of country codes can be referenced here:
            // https://developers.google.com/google-ads/api/reference/data/geotargets
            string countryCode = "FR";

            string[] locations = { "Paris", "Quebec", "Spain", "Deutschland" };

            SuggestGeoTargetConstantsRequest request = new SuggestGeoTargetConstantsRequest()
            {
                Locale = locale,
                CountryCode = countryCode,
                LocationNames = new SuggestGeoTargetConstantsRequest.Types.LocationNames()
            };

            request.LocationNames.Names.AddRange(locations);

            try
            {
                SuggestGeoTargetConstantsResponse response =
                    geoService.SuggestGeoTargetConstants(request);

                foreach (GeoTargetConstantSuggestion suggestion
                    in response.GeoTargetConstantSuggestions)
                {
                    Console.WriteLine(
                        $"{suggestion.GeoTargetConstant.ResourceName} " +
                        $"({suggestion.GeoTargetConstant.Name}, " +
                        $"{suggestion.GeoTargetConstant.CountryCode}, " +
                        $"{suggestion.GeoTargetConstant.TargetType}, " +
                        $"{suggestion.GeoTargetConstant.Status}) is found in locale " +
                        $"({suggestion.Locale}) with reach ({suggestion.Reach}) " +
                        $"for search term ({suggestion.SearchTerm}).");
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
        // [END get_geo_target_constants_by_names]
    }
}

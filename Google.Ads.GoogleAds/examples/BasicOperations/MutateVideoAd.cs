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
using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Extensions.Config;
using Google.Ads.GoogleAds.V23.Common;
using Google.Ads.GoogleAds.V23.Errors;
using Google.Ads.GoogleAds.V23.Resources;
using Google.Ads.GoogleAds.V23.Services;
using System;
using Google.Ads.Gax.Util;

namespace Google.Ads.GoogleAds.Examples.V23
{
    /// <summary>
    /// This code example gets all campaigns. To add campaigns, run AddCampaigns.cs.
    /// </summary>
    public class MutateVideoAd : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetCampaigns"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the call is made.")]
            public long CustomerId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            MutateVideoAd codeExample = new MutateVideoAd();
            Console.WriteLine(codeExample.Description);
            GoogleAdsConfig config = new GoogleAdsConfig();
            config.LoadFromEnvironmentVariables();
            codeExample.Run(new GoogleAdsClient(config),
                options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "Raibaz";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        // [START get_campaigns]
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsService.
            AdGroupAdServiceClient adService = client.GetService(
                Services.V23.AdGroupAdService);

            AdGroupAd ad = new AdGroupAd()
            {
                ResourceName = "customers/6217949978/adGroupAds/190990481718~788102225263",                
                Ad = new Ad()
                {
                    VideoResponsiveAd = new VideoResponsiveAdInfo()
                    {                        
                    }
                }
            };

            ad.Ad.VideoResponsiveAd.Videos.Add(new AdVideoAsset()
            {
                Asset =  "customers/6217949978/assets/316211038174",                
            });

            AdGroupAdOperation op = new AdGroupAdOperation()
            {
                Update = ad,
                UpdateMask = FieldMasks.AllSetFieldsOf(ad)
            };

            try
            {
                MutateAdGroupAdsResponse response = adService.MutateAdGroupAds(
                    customerId.ToString(),
                    new AdGroupAdOperation [] { op }
                );
                
                MutateAdGroupAdResult result = response.Results[0];
                

                Console.WriteLine($"Ad group ad with resource name '{result.ResourceName}' " +
                    "was updated.");
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

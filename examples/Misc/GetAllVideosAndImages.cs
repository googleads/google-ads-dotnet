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
using Google.Ads.GoogleAds.V2.Errors;
using Google.Ads.GoogleAds.V2.Resources;
using Google.Ads.GoogleAds.V2.Services;

using System;

namespace Google.Ads.GoogleAds.Examples.V2
{
    /// <summary>
    /// This code example gets all video and image files.
    /// </summary>
    public class GetAllVideosAndImages : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            GetAllVideosAndImages codeExample = new GetAllVideosAndImages();
            Console.WriteLine(codeExample.Description);

            // The customer ID for which the call is made.
            int customerId = int.Parse("INSERT_CUSTOMER_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example gets all video and image files.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsServiceClient.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V2.GoogleAdsService);

            // Creates a request that will retrieve all video and image files.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                Query = "SELECT media_file.id, media_file.name, media_file.type " +
                  "FROM media_file where media_file.type in ('IMAGE', 'VIDEO') ORDER BY " +
                  "media_file.id"
            };

            try
            {
                // Issues the search request and prints the results.
                int count = 0;
                foreach (GoogleAdsRow row in googleAdsService.Search(request))
                {
                    MediaFile mediaFile = row.MediaFile;

                    Console.WriteLine($"Media file with ID {mediaFile.Id}, name " +
                        $"'{mediaFile.Name}', and type '{mediaFile.Type}' was found.");
                    count++;
                }
                if (count == 0)
                {
                    // Displays a response if no media files are found.
                    if (count == 0)
                    {
                        Console.WriteLine("No media files found.");
                    }
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
            }
        }
    }
}

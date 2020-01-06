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
using Google.Ads.GoogleAds.V2.Common;
using Google.Ads.GoogleAds.V2.Errors;
using Google.Ads.GoogleAds.V2.Resources;
using Google.Ads.GoogleAds.V2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Ads.GoogleAds.V2.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V2.Enums.KeywordMatchTypeEnum.Types;
using static Google.Ads.GoogleAds.V2.Errors.QuotaErrorEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V2
{
    /// <summary>
    /// This code example demonstrates how to handle RateExceededError in an application.
    /// This code example runs 5 threads in parallel, each thread attempting to validate
    /// 100 keywords in a single request.While spanning 5 parallel threads is unlikely to
    /// trigger a rate exceeded error, substantially increasing the  number of threads may
    /// have that effect.Note that this example is for illustrative purposes only, and you
    /// shouldn't intentionally try to trigger a rate exceed error in your application.
    /// </summary>
    public class HandleRateExceededError : ExampleBase
    {
        // Number of threads to use in the code example.
        private const int NUM_THREADS = 5;

        // Number of keywords to be validated in each API call.
        private const int NUM_KEYWORDS = 100;

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            HandleRateExceededError codeExample = new HandleRateExceededError();
            Console.WriteLine(codeExample.Description);
            try
            {
                // The Google Ads customer ID for which the call is made.
                long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                // the ad group ID to which keywords are added.
                long campaignId = long.Parse("INSERT_ADGROUP_ID_HERE");

                codeExample.Run(new GoogleAdsClient(), customerId, campaignId);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occurred while running this code example. {0}",
                    ExampleUtilities.FormatException(e));
            }
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example demonstrates how to handle RateExceededError in an " +
                    "application. This code example runs 5 threads in parallel, each thread " +
                    "attempting to validate 100 keywords in a single request.While spanning 5" +
                    " parallel threads is unlikely to trigger a rate exceeded error, " +
                    "substantially increasing the  number of threads may have that effect. Note " +
                    "that this example is for illustrative purposes only, and you shouldn't " +
                    "intentionally try to trigger a rate exceed error in your application.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="adGroupId">ID of the ad group to which keywords are added.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId)
        {
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < NUM_THREADS; i++)
            {
                Task t = CreateKeyword(client, i, customerId, adGroupId);
                t.Start();
                tasks.Add(t);
            }

            Task.WaitAll(tasks.ToArray());
        }

        /// <summary>
        /// Displays the result from the mutate operation.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ad group to which keywords are added.</param>
        /// <param name="threadIndex">The thread ID.</param>
        private async Task CreateKeyword(GoogleAdsClient client, int threadIndex, long customerId,
            long adGroupId)
        {
            // Get the AdGroupCriterionServiceClient.
            AdGroupCriterionServiceClient adGroupCriterionService =
                client.GetService(Services.V2.AdGroupCriterionService);

            List<AdGroupCriterionOperation> operations = new List<AdGroupCriterionOperation>();

            for (int i = 0; i < NUM_KEYWORDS; i++)
            {
                AdGroupCriterion criterion = new AdGroupCriterion()
                {
                    Keyword = new KeywordInfo()
                    {
                        Text = $"mars cruise thread {threadIndex} seed {i}",
                        MatchType = KeywordMatchType.Exact
                    },
                    AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                    Status = AdGroupCriterionStatus.Paused
                };

                // Creates the operation.
                operations.Add(new AdGroupCriterionOperation() { Create = criterion });
            }

            int retryCount = 0;
            int retrySeconds = 10;
            const int NUM_RETRIES = 3;

            while (retryCount < NUM_RETRIES)
            {
                try
                {
                    // Makes the validateOnly mutate request.
                    MutateAdGroupCriteriaResponse response =
                        await adGroupCriterionService.MutateAdGroupCriteriaAsync(
                            customerId.ToString(), operations, false, true);
                    Console.WriteLine($"Validated {operations.Count} ad group criteria:");
                    break;
                }
                catch (GoogleAdsException e)
                {
                    // Checks if any of the errors are QuotaError.RESOURCE_EXHAUSTED or
                    // QuotaError.RESOURCE_TEMPORARILY_EXHAUSTED.
                    if (e.Failure.Errors.Where(err =>
                        err.ErrorCode.QuotaError == QuotaError.ResourceExhausted ||
                        err.ErrorCode.QuotaError == QuotaError.ResourceTemporarilyExhausted)
                        .Count() > 0)
                    {
                        Console.Error.WriteLine(
                            $"Received rate exceeded error, retry after {retrySeconds} seconds.");
                        Thread.Sleep(retrySeconds * 1000);
                        retryCount++;
                        // Uses an exponential backoff policy to avoid polling too aggressively.
                        retrySeconds *= 2;
                    }
                    else
                    {
                        Console.WriteLine("Failure:");
                        Console.WriteLine($"Message: {e.Message}");
                        Console.WriteLine($"Failure: {e.Failure}");
                        Console.WriteLine($"Request ID: {e.RequestId}");
                        break;
                    }
                }
                finally
                {
                    if (retryCount == NUM_RETRIES)
                    {
                        throw new Exception($"Could not recover after making {retryCount} " +
                            $"attempts.");
                    }
                }
            }
        }
    }
}

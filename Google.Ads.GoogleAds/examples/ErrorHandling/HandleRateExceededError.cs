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
using Google.Ads.GoogleAds.V14.Common;
using Google.Ads.GoogleAds.V14.Errors;
using Google.Ads.GoogleAds.V14.Resources;
using Google.Ads.GoogleAds.V14.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Ads.GoogleAds.V14.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V14.Enums.KeywordMatchTypeEnum.Types;
using static Google.Ads.GoogleAds.V14.Errors.QuotaErrorEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V14
{
    /// <summary>
    /// This code example demonstrates how to handle RateExceededError in an application.
    /// This code example runs 5 threads in parallel, each thread attempting to validate
    /// 100 keywords in a single request. While spanning 5 parallel threads is unlikely to
    /// trigger a rate exceeded error, substantially increasing the  number of threads may
    /// have that effect. Note that this example is for illustrative purposes only, and you
    /// shouldn't intentionally try to trigger a rate exceed error in your application.
    /// </summary>
    public class HandleRateExceededError : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="HandleRateExceededError"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The customer ID for which the call is made.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// ID of the ad group to which keywords are added.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "ID of the ad group to which keywords are added.")]
            public long AdGroupId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            HandleRateExceededError codeExample = new HandleRateExceededError();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.AdGroupId);
        }

        // Number of threads to use in the code example.
        private const int NUM_THREADS = 5;

        // Number of keywords to be validated in each API call.
        private const int NUM_KEYWORDS = 5000;

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example demonstrates how to handle RateExceededError in an application. " +
            "This code example runs 5 threads in parallel, each thread attempting to validate " +
            "100 keywords in a single request. While spanning 5 parallel threads is unlikely to " +
            "trigger a rate exceeded error, substantially increasing the  number of threads may " +
            "have that effect. Note that this example is for illustrative purposes only, and you " +
            "shouldn't intentionally try to trigger a rate exceed error in your application.";

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
            await Task.Run(() =>
            {
                // Get the AdGroupCriterionServiceClient.
                AdGroupCriterionServiceClient adGroupCriterionService =
                    client.GetService(Services.V14.AdGroupCriterionService);

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
                int retrySeconds = 30;
                const int NUM_RETRIES = 3;

                while (retryCount < NUM_RETRIES)
                {
                    try
                    {
                        // Makes the validateOnly mutate request.
                        MutateAdGroupCriteriaResponse response =
                            adGroupCriterionService.MutateAdGroupCriteria(
                                new MutateAdGroupCriteriaRequest()
                                {
                                    CustomerId = customerId.ToString(),
                                    Operations = { operations },
                                    PartialFailure = false,
                                    ValidateOnly = true
                                });
                        Console.WriteLine($"[{threadIndex}] Validated {operations.Count} " +
                            $"ad group criteria:");
                        break;
                    }
                    catch (GoogleAdsException e)
                    {
                        // Checks if any of the errors are QuotaError.RESOURCE_EXHAUSTED or
                        // QuotaError.RESOURCE_TEMPORARILY_EXHAUSTED.
                        // Note: The code assumes that the developer token is approved for
                        // Standard Access.
                        if (e.Failure != null)
                        {
                            bool isRateExceededError = false;
                            e.Failure.Errors
                            .Where(err =>
                                err.ErrorCode.QuotaError == QuotaError.ResourceExhausted ||
                                err.ErrorCode.QuotaError == QuotaError.ResourceTemporarilyExhausted)
                            .ToList()
                            .ForEach(delegate (GoogleAdsError err)
                                {
                                    Console.Error.WriteLine($"[{threadIndex}] Received rate " +
                                        $"exceeded error. Message says, \"{err.Message}\".");
                                    isRateExceededError = true;
                                }
                            );
                            if (isRateExceededError)
                            {
                                Console.Error.WriteLine(
                                    $"[{threadIndex}] Will retry after  {retrySeconds} seconds.");
                                Thread.Sleep(retrySeconds * 1000);
                                retryCount++;
                                // Uses an exponential backoff policy to avoid polling too
                                // aggressively.
                                retrySeconds *= 2;
                            }
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
                            throw new Exception($"[{ threadIndex }] Could not recover after " +
                                $"making {retryCount} attempts.");
                        }
                    }
                }
            });
        }
    }
}

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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V9.Common;
using Google.Ads.GoogleAds.V9.Errors;
using Google.Ads.GoogleAds.V9.Resources;
using Google.Ads.GoogleAds.V9.Services;
using Google.Api.Gax;
using Google.LongRunning;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V9.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.AdGroupTypeEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.KeywordMatchTypeEnum.Types;
using static Google.Ads.GoogleAds.V9.Resources.BatchJob.Types;

namespace Google.Ads.GoogleAds.Examples.V9
{
    /// <summary>
    /// This code example adds complete campaigns including campaign budgets, campaigns, ad groups
    /// and keywords using BatchJobService.
    /// </summary>
    public class AddCompleteCampaignsUsingBatchJob : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddCompleteCampaignsUsingBatchJob"/>
        /// example.
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
            Options options = new Options();
            CommandLine.Parser.Default.ParseArguments<Options>(args).MapResult(
                delegate (Options o)
                {
                    options = o;
                    return 0;
                }, delegate (IEnumerable<Error> errors)
                {
                    // The Google Ads customer ID for which the call is made.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    return 0;
                });

            AddCompleteCampaignsUsingBatchJob codeExample = new AddCompleteCampaignsUsingBatchJob();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        /// <summary>
        /// The number of campaigns to add.
        /// </summary>
        private const int NUMBER_OF_CAMPAIGNS_TO_ADD = 2;

        /// <summary>
        /// The number of ad groups per campaign to add.
        /// </summary>
        private const int NUMBER_OF_AD_GROUPS_TO_ADD = 2;

        /// <summary>
        /// The number of keywords per ad group to add.
        /// </summary>
        private const int NUMBER_OF_KEYWORDS_TO_ADD = 4;

        /// <summary>
        /// The maximum total poll interval in seconds.
        /// </summary>
        private const int MAX_TOTAL_POLL_INTERVAL_SECONDS = 60;

        /// <summary>
        /// The page size for retrieving results.
        /// </summary>
        private const int PAGE_SIZE = 1000;

        /// <summary>
        /// The negative temporary ID used in batch job operations.
        /// </summary>
        private static long temporaryId = -1;

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds complete campaigns including campaign budgets, campaigns, " +
            "ad groups and keywords using BatchJobService.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Gets the BatchJobService.
            BatchJobServiceClient batchJobService =
                client.GetService(Services.V9.BatchJobService);

            try
            {
                string batchJobResourceName = CreateBatchJob(batchJobService, customerId);
                AddAllBatchJobOperations(batchJobService, customerId, batchJobResourceName);
                Operation<Empty, BatchJobMetadata> operationResponse =
                    RunBatchJob(batchJobService, batchJobResourceName);
                PollBatchJob(operationResponse);
                FetchAndPrintResults(batchJobService, batchJobResourceName);
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
        /// Creates the batch job.
        /// </summary>
        /// <param name="batchJobService">The batch job service.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>The resource name of the created batch job.</returns>
        // [START add_complete_campaigns_using_batch_job]
        private static string CreateBatchJob(BatchJobServiceClient batchJobService,
            long customerId)
        {
            BatchJobOperation operation = new BatchJobOperation()
            {
                Create = new BatchJob()
                {
                }
            };
            string batchJobResourceName =
                batchJobService.MutateBatchJob(customerId.ToString(), operation)
                .Result.ResourceName;
            Console.WriteLine($"Created a batch job with resource name: " +
                $"'{batchJobResourceName}'.");

            return batchJobResourceName;
        }
        // [END add_complete_campaigns_using_batch_job]

        /// <summary>
        /// Adds all batch job operations to the batch job. As this is the first time for this
        /// batch job, the sequence token is not set. The response will contain the next sequence
        /// token that you can use to upload more operations in the future.
        /// </summary>
        /// <param name="batchJobService">The batch job service.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="batchJobResourceName">The resource name of batch job to which the batch
        /// job operations will be added.
        /// </param>
        // [START add_complete_campaigns_using_batch_job_1]
        private static void AddAllBatchJobOperations(BatchJobServiceClient batchJobService,
            long customerId, string batchJobResourceName)
        {
            AddBatchJobOperationsResponse response =
                batchJobService.AddBatchJobOperations(
                    new AddBatchJobOperationsRequest()
                    {
                        ResourceName = batchJobResourceName,
                        MutateOperations = { BuildAllOperations(customerId) }
                    });
            Console.WriteLine($"{response.TotalOperations} mutate operations have been added" +
                $" so far.");

            // You can use this next sequence token for calling AddBatchJobOperations() next time.
            Console.WriteLine($"Next sequence token for adding next operations is " +
                $"'{response.NextSequenceToken}'.");
        }
        // [END add_complete_campaigns_using_batch_job_1]

        /// <summary>
        /// Requests the API to run the batch job for executing all uploaded batch job
        /// operations.
        /// </summary>
        /// <param name="batchJobService">The batch job service client.</param>
        /// <param name="batchJobResourceName">The resource name of batch job to be run.</param>
        /// <returns>The operation response from running batch job.</returns>
        // [START add_complete_campaigns_using_batch_job_2]
        private Operation<Empty, BatchJobMetadata> RunBatchJob(
            BatchJobServiceClient batchJobService, string batchJobResourceName)
        {
            Operation<Empty, BatchJobMetadata> operationResponse =
                batchJobService.RunBatchJob(batchJobResourceName);
            Console.WriteLine($"Batch job with resource name '{batchJobResourceName}' has been " +
                $"executed.");

            return operationResponse;
        }
        // [END add_complete_campaigns_using_batch_job_2]

        /// <summary>
        /// Polls the server until the batch job execution finishes by setting the total
        /// time to wait before time-out.
        /// </summary>
        /// <param name="operationResponse">The operation response used to poll the server.</param>
        // [START add_complete_campaigns_using_batch_job_3]
        private static void PollBatchJob(Operation<Empty, BatchJobMetadata> operationResponse)
        {
            PollSettings pollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromSeconds(MAX_TOTAL_POLL_INTERVAL_SECONDS)),
                TimeSpan.FromSeconds(1));
            operationResponse.PollUntilCompleted(pollSettings);
        }
        // [END add_complete_campaigns_using_batch_job_3]

        /// <summary>
        /// Fetches and prints all the results from running the batch job.
        /// </summary>
        /// <param name="batchJobService">The batch job service.</param>
        /// <param name="batchJobResourceName">The resource name of batch job to get its results.
        /// </param>
        // [START add_complete_campaigns_using_batch_job_4]
        private static void FetchAndPrintResults(BatchJobServiceClient batchJobService,
            string batchJobResourceName)
        {
            Console.WriteLine($"batch job with resource name '{batchJobResourceName}' has " +
                $"finished. Now, printing its results...");

            ListBatchJobResultsRequest request = new ListBatchJobResultsRequest()
            {
                ResourceName = batchJobResourceName,
                PageSize = PAGE_SIZE,
            };
            ListBatchJobResultsResponse resp = new ListBatchJobResultsResponse();
            // Gets all the results from running batch job and prints their information.
            foreach (BatchJobResult batchJobResult in
                batchJobService.ListBatchJobResults(request))
            {
                if (!batchJobResult.IsFailed)
                {
                    Console.WriteLine($"batch job result #{batchJobResult.OperationIndex} is " +
                        $"successful and response is of type " +
                        $"'{batchJobResult.MutateOperationResponse.ResponseCase}'.");
                }
                else
                {
                    Console.WriteLine($"batch job result #{batchJobResult.OperationIndex} " +
                        $"failed with error message {batchJobResult.Status.Message}.");

                    foreach (GoogleAdsError error in batchJobResult.Failure.Errors)
                    {
                        Console.WriteLine($"Error found: {error}.");
                    }
                }
            }
        }
        // [END add_complete_campaigns_using_batch_job_4]

        /// <summary>
        /// Builds all operations for creating a complete campaign and return an array of
        /// their corresponding mutate operations.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>The mutate operations to be added to a batch job.</returns>
        private static List<MutateOperation> BuildAllOperations(long customerId)
        {
            List<MutateOperation> mutateOperations = new List<MutateOperation>();

            // Creates a new campaign budget operation and adds it to the array of mutate operations.
            CampaignBudgetOperation campaignBudgetOperation =
                BuildCampaignBudgetOperation(customerId);
            mutateOperations.Add(
                new MutateOperation()
                {
                    CampaignBudgetOperation = campaignBudgetOperation
                }
            );

            // Creates new campaign operations and adds them to the array of mutate operations.
            List<CampaignOperation> campaignOperations =
                BuildCampaignOperations(customerId, campaignBudgetOperation.Create.ResourceName);
            foreach (CampaignOperation campaignOperation in campaignOperations)
            {
                mutateOperations.Add(
                    new MutateOperation()
                    {
                        CampaignOperation = campaignOperation
                    }
                );
            }

            // Creates new campaign criterion operations and adds them to the array of mutate
            // operations.
            List<CampaignCriterionOperation> campaignCriterionOperations =
                BuildCampaignCriterionOperations(campaignOperations);
            foreach (CampaignCriterionOperation campaignCriterionOperation in
                campaignCriterionOperations)
            {
                mutateOperations.Add(
                    new MutateOperation()
                    {
                        CampaignCriterionOperation = campaignCriterionOperation
                    }
                );
            }

            // Creates new ad group operations and adds them to the array of mutate operations.
            List<AdGroupOperation> adGroupOperations = BuildAdGroupOperations(customerId,
                campaignOperations);
            foreach (AdGroupOperation adGroupOperation in adGroupOperations)
            {
                mutateOperations.Add(
                    new MutateOperation()
                    {
                        AdGroupOperation = adGroupOperation
                    }
                );
            }

            // Creates new ad group criterion operations and adds them to the array of mutate
            // operations.
            List<AdGroupCriterionOperation> adGroupCriterionOperations =
                BuildAdGroupCriterionOperations(adGroupOperations);
            foreach (AdGroupCriterionOperation adGroupCriterionOperation in
                adGroupCriterionOperations)
            {
                mutateOperations.Add(
                    new MutateOperation()
                    {
                        AdGroupCriterionOperation = adGroupCriterionOperation
                    }
                );
            }

            // Creates new ad group ad operations and adds them to the array of mutate operations.
            List<AdGroupAdOperation> adGroupAdOperations =
                BuildAdGroupAdOperations(adGroupOperations);
            foreach (AdGroupAdOperation adGroupAdOperation in adGroupAdOperations)
            {
                mutateOperations.Add(
                    new MutateOperation()
                    {
                        AdGroupAdOperation = adGroupAdOperation
                    }
                );
            }

            return mutateOperations;
        }

        /// <summary>
        /// Builds a new campaign budget operation for the specified customer ID.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>The campaign budget operation.</returns>
        private static CampaignBudgetOperation BuildCampaignBudgetOperation(long customerId)
        {
            // Creates a campaign budget.
            CampaignBudget budget = new CampaignBudget()
            {
                ResourceName = ResourceNames.CampaignBudget(customerId, GetNextTemporaryId()),
                Name = "batch job Budget #" + ExampleUtilities.GetRandomString(),
                DeliveryMethod = BudgetDeliveryMethod.Standard,
                AmountMicros = 5_000_000
            };
            // Creates a campaign budget operation.
            return new CampaignBudgetOperation()
            {
                Create = budget
            };
        }

        /// <summary>
        /// Builds new campaign operations for the specified customer ID.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignBudgetResourceName">The resource name of campaign budget to be
        /// used to create campaigns.</param>
        /// <returns>The campaign operations.</returns>
        private static List<CampaignOperation> BuildCampaignOperations(long customerId,
            string campaignBudgetResourceName)
        {
            List<CampaignOperation> operations = new List<CampaignOperation>();

            for (int i = 0; i < NUMBER_OF_CAMPAIGNS_TO_ADD; i++)
            {
                // Creates a campaign.
                long campaignId = GetNextTemporaryId();
                Campaign campaign = new Campaign()
                {
                    ResourceName = ResourceNames.Campaign(customerId, campaignId),
                    Name = "batch job campaign #" + ExampleUtilities.GetRandomString(),
                    AdvertisingChannelType = AdvertisingChannelType.Search,

                    // Recommendation: Set the campaign to PAUSED when creating it to prevent
                    // the ads from immediately serving. Set to ENABLED once you've added
                    // targeting and the ads are ready to serve.
                    Status = CampaignStatus.Paused,

                    // Sets the bidding strategy and budget.
                    ManualCpc = new ManualCpc(),
                    CampaignBudget = campaignBudgetResourceName
                };

                // Creates a campaign operation and adds it to the operations list.
                CampaignOperation op = new CampaignOperation()
                {
                    Create = campaign
                };
                operations.Add(op);
            }

            return operations;
        }

        /// <summary>
        /// Builds new campaign criterion operations for creating negative campaign criteria
        /// (as keywords).
        /// </summary>
        /// <param name="campaignOperations">The campaign operations to be used to create
        /// campaign criteria.</param>
        /// <returns>The campaign criterion operations.</returns>
        private static List<CampaignCriterionOperation> BuildCampaignCriterionOperations(
                    List<CampaignOperation> campaignOperations)
        {
            List<CampaignCriterionOperation> operations =
                new List<CampaignCriterionOperation>();

            foreach (CampaignOperation campaignOperation in campaignOperations)
            {
                // Creates a campaign criterion.
                CampaignCriterion campaignCriterion = new CampaignCriterion()
                {
                    Keyword = new KeywordInfo()
                    {
                        Text = "venus",
                        MatchType = KeywordMatchType.Broad
                    },
                    // Sets the campaign criterion as a negative criterion.
                    Negative = true,
                    Campaign = campaignOperation.Create.ResourceName
                };

                // Creates a campaign criterion operation and adds it to the operations list.
                CampaignCriterionOperation op = new CampaignCriterionOperation()
                {
                    Create = campaignCriterion
                };
                operations.Add(op);
            }

            return operations;
        }

        /// <summary>
        /// Builds new ad group operations for the specified customer ID.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignOperations">The campaign operations to be used to create ad
        /// groups.</param>
        /// <returns>The ad group operations.</returns>
        private static List<AdGroupOperation> BuildAdGroupOperations(
                    long customerId, List<CampaignOperation> campaignOperations)
        {
            List<AdGroupOperation> operations = new List<AdGroupOperation>();

            foreach (CampaignOperation campaignOperation in campaignOperations)
            {
                for (int i = 0; i < NUMBER_OF_AD_GROUPS_TO_ADD; i++)
                {
                    // Creates an ad group.
                    long adGroupId = GetNextTemporaryId();
                    AdGroup adGroup = new AdGroup()
                    {
                        ResourceName = ResourceNames.AdGroup(customerId, adGroupId),
                        Name = "batch job ad group #" + ExampleUtilities.GetShortRandomString(),
                        Campaign = campaignOperation.Create.ResourceName,
                        Type = AdGroupType.SearchStandard,
                        CpcBidMicros = 10_000_000
                    };

                    // Creates an ad group operation and adds it to the operations list.
                    AdGroupOperation op = new AdGroupOperation()
                    {
                        Create = adGroup
                    };
                    operations.Add(op);
                }
            }

            return operations;
        }

        /// <summary>
        /// Builds new ad group criterion operations for creating keywords. 50% of keywords are
        /// created some invalid characters to demonstrate how BatchJobService returns information
        /// about such errors.
        /// </summary>
        /// <param name="adGroupOperations">The ad group operations to be used to create ad group
        /// criteria.</param>
        /// <returns>The ad group criterion operations.</returns>
        private static List<AdGroupCriterionOperation> BuildAdGroupCriterionOperations(
                    List<AdGroupOperation> adGroupOperations)
        {
            List<AdGroupCriterionOperation> operations = new List<AdGroupCriterionOperation>();

            foreach (AdGroupOperation adGroupOperation in adGroupOperations)
            {
                for (int i = 0; i < NUMBER_OF_KEYWORDS_TO_ADD; i++)
                {
                    // Creates a keyword text by making 50% of keywords invalid to demonstrate
                    // error handling.
                    string keywordText = "mars" + i;
                    if (i % 2 == 0)
                    {
                        keywordText += "!!!";
                    }
                    // Creates an ad group criterion using the created keyword text.
                    AdGroupCriterion adGroupCriterion = new AdGroupCriterion()
                    {
                        Keyword = new KeywordInfo()
                        {
                            Text = keywordText,
                            MatchType = KeywordMatchType.Broad,
                        },
                        AdGroup = adGroupOperation.Create.ResourceName,
                        Status = AdGroupCriterionStatus.Paused
                    };

                    // Creates an ad group criterion operation and adds it to the operations list.
                    AdGroupCriterionOperation op = new AdGroupCriterionOperation()
                    {
                        Create = adGroupCriterion
                    };
                    operations.Add(op);
                }
            }

            return operations;
        }

        /// <summary>
        /// Builds the ad group ad operations.
        /// </summary>
        /// <param name="adGroupOperations">The ad group operations to be used to create ad
        /// group ads.</param>
        /// <returns>The ad group ad operations.</returns>
        private static List<AdGroupAdOperation> BuildAdGroupAdOperations(
                    List<AdGroupOperation> adGroupOperations)
        {
            List<AdGroupAdOperation> operations = new List<AdGroupAdOperation>();

            foreach (AdGroupOperation adGroupOperation in adGroupOperations)
            {
                // Creates an ad group ad.
                AdGroupAd adGroupAd = new AdGroupAd()
                {
                    Ad = new Ad
                    {
                        FinalUrls = { "http://www.example.com/" },

                        // Sets the expanded text ad info on an ad.
                        ExpandedTextAd = new ExpandedTextAdInfo
                        {
                            HeadlinePart1 = "Cruise #" + ExampleUtilities.GetShortRandomString() +
                            " to Mars",
                            HeadlinePart2 = "Best Space Cruise Line",
                            Description = "Buy your tickets now!",
                        },
                    },
                    AdGroup = adGroupOperation.Create.ResourceName,
                    // Optional: Set the status.
                    Status = AdGroupAdStatus.Paused,
                };

                // Creates an ad group ad operation and adds it to the operations list.
                AdGroupAdOperation op = new AdGroupAdOperation()
                {
                    Create = adGroupAd
                };
                operations.Add(op);
            }

            return operations;
        }

        /// <summary>
        /// Returns the next temporary ID and decreases it by one.
        /// </summary>
        /// <returns>The next temporary ID.</returns>
        private static long GetNextTemporaryId()
        {
            return temporaryId--;
        }
    }
}

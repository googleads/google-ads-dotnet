// Copyright 2026 Google LLC
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
using Google.Ads.Gax.Util;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V25.Errors;
using Google.Ads.GoogleAds.V25.Resources;
using Google.Ads.GoogleAds.V25.Services;
using Google.Api.Gax;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V25.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V25.Enums.ExperimentTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V25
{
    /// <summary>
    /// Retrieves performance metrics for an experiment, evaluates the performance,
    /// and takes action on the experiment accordingly.
    /// It shows how to query statistical significance metrics for the experiment,
    /// and how to execute actions such as promoting, ending, or graduating an experiment.
    /// </summary>
    public class EvaluateAndUpdateExperiment : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="EvaluateAndUpdateExperiment"/> example.
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
            /// The experiment ID.
            /// </summary>
            [Option("experimentId", Required = true, HelpText =
                "The experiment ID.")]
            public long ExperimentId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            EvaluateAndUpdateExperiment codeExample = new EvaluateAndUpdateExperiment();
            Console.WriteLine(codeExample.Description);            
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.ExperimentId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "Retrieves performance metrics for an experiment, evaluates the performance, " +
            "and takes action on the experiment accordingly. " +
            "It shows how to query statistical significance metrics for the experiment, " +
            "and how to execute actions such as promoting, ending, or graduating an experiment.";

        // Constants for decision making
        // Choose a confidence level based on your specific needs.
        // - The p-value (probability value) is the probability that the observed performance
        //   difference between control and treatment occurred by random chance rather than due
        //   to the changes in the experiment. A lower p-value represents higher confidence.
        // - For example, a p-value threshold of 0.05 corresponds to a 95% confidence level
        //   (the academic standard for statistical significance).
        private const double P_VALUE_THRESHOLD = 0.05; // 95% confidence level

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="experimentId">The experiment ID.</param>
        public void Run(GoogleAdsClient client, long customerId, long experimentId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V25.GoogleAdsService);

            // Query to retrieve the experiment.
            // Notice that we request the statistical metrics (for example, p-value, point estimate,
            // margin of error) which are populated based on the treatment arm.
            string query = $@"
                SELECT
                  experiment.resource_name,
                  experiment.name,
                  experiment.experiment_id,
                  experiment.type,
                  metrics.conversions_absolute_change_p_value,
                  metrics.conversions_absolute_change_point_estimate,
                  metrics.conversions_absolute_change_margin_of_error,
                  metrics.clicks_p_value,
                  metrics.clicks_point_estimate,
                  metrics.clicks_margin_of_error
                FROM experiment
                WHERE experiment.experiment_id = {experimentId}";

            // Create a request that will retrieve the experiment.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                Query = query
            };

            try
            {
                // Issue the search request.
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchPagedResponse =
                    googleAdsService.Search(request);

                bool hasResults = false;
                foreach (GoogleAdsRow row in searchPagedResponse)
                {
                    hasResults = true;
                    Console.WriteLine($"Found experiment: {row.Experiment.Name}");
                    Console.WriteLine($"  Resource Name: {row.Experiment.ResourceName}");

                    EvaluateExperiment(client, customerId, row);
                }

                if (!hasResults)
                {
                    Console.WriteLine($"No experiment found for experiment ID: {experimentId}");
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
        /// Evaluates the performance of the experiment and updates it accordingly
        /// (for example, promotes, ends, or graduates).
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="row">A GoogleAdsRow containing the experiment and metrics.</param>
        // [START evaluate_and_update_experiment_1]
        private static void EvaluateExperiment(GoogleAdsClient client, long customerId, GoogleAdsRow row)
        {
            // This function evaluates performance metrics and immediately takes action
            // to update the experiment's status (promote, end, or graduate) if
            // statistical significance thresholds are met.
            var metrics = row.Metrics;
            string experimentResourceName = row.Experiment.ResourceName;

            bool hasConvMetrics = metrics.HasConversionsAbsoluteChangePValue
                && metrics.HasConversionsAbsoluteChangePointEstimate
                && metrics.HasConversionsAbsoluteChangeMarginOfError;

            bool hasClickMetrics = metrics.HasClicksPValue
                && metrics.HasClicksPointEstimate
                && metrics.HasClicksMarginOfError;

            // 1. Evaluate conversion success as a primary success signal if available.
            // - Point Estimate: Represents the estimated average lift or difference in conversions.
            // - Margin of Error: Outlines the confidence interval bounds. Note that the margin_of_error
            //   provided by the API is calculated for a preset confidence level which is set based on
            //   the experiment type.
            // - Lower Bound: (Point Estimate - Margin of Error). If this value is above 0,
            //   we have statistical significance that performance has improved.
            if (hasConvMetrics)
            {
                double convPValue = metrics.ConversionsAbsoluteChangePValue;
                double convLift = metrics.ConversionsAbsoluteChangePointEstimate;
                double convError = metrics.ConversionsAbsoluteChangeMarginOfError;
                double convLowerBound = convLift - convError;

                if (convPValue <= P_VALUE_THRESHOLD)
                {
                    if (convLowerBound > 0)
                    {
                        Console.WriteLine(
                            $"Significant Success: Conversions increased. Even at the lower" +
                            $" bound, the lift is {convLowerBound:F2}. Promoting changes.");
                        PromoteExperiment(client, customerId, experimentResourceName);
                        return;
                    }
                    else if ((convLift + convError) < 0)
                    {
                        Console.WriteLine(
                            $"Significant Decline: Even the upper bound ({convLift + convError:F2}) " +
                            $"is below zero. Ending experiment.");
                        EndExperiment(client, customerId, experimentResourceName);
                        return;
                    }
                }
            }

            // 2. Evaluate click volume as a secondary signal.
            // This is helpful as an early indicator or for lower-volume accounts.
            if (hasClickMetrics)
            {
                double clickPValue = metrics.ClicksPValue;
                double clickLift = metrics.ClicksPointEstimate;
                double clickError = metrics.ClicksMarginOfError;
                double clickLowerBound = clickLift - clickError;

                if (clickPValue <= P_VALUE_THRESHOLD && clickLowerBound > 0)
                {
                    // We have a directional winner: high confidence in more traffic,
                    // but not enough data to confirm conversion impact yet.
                    Console.WriteLine(
                        $"Click volume is significantly up (+{clickLift * 100:F1}%).");

                    // Graduation is only supported for separate campaign experiments, not
                    // intra-campaign experiments where there is no separate treatment campaign.
                    if (row.Experiment.Type != ExperimentType.AdoptBroadMatchKeywords
                        && row.Experiment.Type != ExperimentType.AdoptAiMax)
                    {
                        Console.WriteLine("Graduating treatment campaign for further manual analysis.");
                        GraduateExperiment(client, customerId, experimentResourceName);
                    }
                    else
                    {
                        Console.WriteLine(
                            "Intra-campaign trial detected: graduation is not supported. " +
                            "Continuing to run the experiment to gather more conversion data.");
                    }
                    return;
                }
            }

            // 3. Print status if no action was taken.
            if (hasConvMetrics || hasClickMetrics)
            {
                string convStatus = hasConvMetrics
                    ? $"Conversions (p={metrics.ConversionsAbsoluteChangePValue:F2}, " +
                      $"lift={metrics.ConversionsAbsoluteChangePointEstimate:F2} +/- " +
                      $"{metrics.ConversionsAbsoluteChangeMarginOfError:F2})"
                    : "Conversions (not populated)";

                string clickStatus = hasClickMetrics
                    ? $"Clicks (p={metrics.ClicksPValue:F2}, " +
                      $"lift={metrics.ClicksPointEstimate:F2} +/- " +
                      $"{metrics.ClicksMarginOfError:F2})"
                    : "Clicks (not populated)";

                Console.WriteLine(
                    $"Inconclusive: No significant action taken. {convStatus}, {clickStatus}. " +
                    "Allowing the experiment to continue running.");
            }
            else
            {
                Console.WriteLine(
                    "Conversion and click performance metrics are not yet populated. " +
                    "Allowing the experiment to continue running.");
            }
        }
        // [END evaluate_and_update_experiment_1]

        /// <summary>
        /// Promotes the experiment trial campaign to the base campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="experimentResourceName">The resource name of the experiment to promote.</param>
        private static void PromoteExperiment(GoogleAdsClient client, long customerId, string experimentResourceName)
        {
            ExperimentServiceClient experimentService = client.GetService(
                Services.V25.ExperimentService);

            // This method returns a long running operation (LRO).
            // - To block until the operation is complete: call operation.PollUntilCompleted()
            // - For non-blocking status checks: use operation.IsCompleted
            // - For manual polling or persistent tracking: store operation.Name
            //
            // For more information on handling LROs, see:
            // https://developers.google.com/google-ads/api/docs/concepts/long-running-operations
            var operation = experimentService.PromoteExperiment(experimentResourceName);

            Console.WriteLine($"Started promotion for experiment: {experimentResourceName}");
            Console.WriteLine(
                $"The promotion is running asynchronously. You can track its progress " +
                $"using the long-running operation: {operation.Name}");
            Console.WriteLine(
                "Best Practice: If the promotion fails, you can retrieve the full list " +
                "of errors by calling ExperimentService.ListExperimentAsyncErrors.");
        }

        /// <summary>
        /// Immediately ends the experiment.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="experimentResourceName">The resource name of the experiment to end.</param>
        private static void EndExperiment(GoogleAdsClient client, long customerId, string experimentResourceName)
        {
            ExperimentServiceClient experimentService = client.GetService(
                Services.V25.ExperimentService);

            experimentService.EndExperiment(experimentResourceName);
            Console.WriteLine($"Successfully ended experiment: {experimentResourceName}");
        }

        /// <summary>
        /// Graduates the experiment to a full standalone campaign.
        /// </summary>
        /// <remarks>
        /// This process involves creating a new budget and mapping the treatment campaign to it.
        /// </remarks>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="experimentResourceName">The resource name of the experiment to graduate.</param>
        private static void GraduateExperiment(GoogleAdsClient client, long customerId, string experimentResourceName)
        {
            // 1. Create a new campaign budget for the graduating campaign.
            CampaignBudgetServiceClient campaignBudgetService = client.GetService(
                Services.V25.CampaignBudgetService);

            CampaignBudget campaignBudget = new CampaignBudget()
            {
                Name = $"Graduated Experiment Budget #{ExampleUtilities.GetRandomString()}",
                AmountMicros = 50_000_000, // $50.00/day budget
                DeliveryMethod = BudgetDeliveryMethod.Standard
            };

            CampaignBudgetOperation budgetOperation = new CampaignBudgetOperation()
            {
                Create = campaignBudget
            };

            MutateCampaignBudgetsResponse budgetResponse = campaignBudgetService.MutateCampaignBudgets(
                customerId.ToString(), new[] { budgetOperation });

            string budgetResourceName = budgetResponse.Results.First().ResourceName;
            Console.WriteLine($"Created new standalone campaign budget with resource name: '{budgetResourceName}'.");

            // 2. Query the experiment_arm to retrieve the treatment campaign's resource name.
            // The treatment arm has control set to False.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V25.GoogleAdsService);

            // Query for the campaigns associated with the treatment arm of the experiment.
            string query = $"SELECT experiment_arm.campaigns FROM experiment_arm " +
                $"WHERE experiment_arm.experiment = '{experimentResourceName}' " +
                $"AND experiment_arm.control = FALSE";

            string treatmentCampaignResourceName = null;

            // Find the resource name of the treatment campaign.
            googleAdsService.SearchStream(customerId.ToString(), query,
                delegate (SearchGoogleAdsStreamResponse resp)
                {
                    foreach (GoogleAdsRow row in resp.Results)
                    {
                        if (row.ExperimentArm.Campaigns.Count > 0)
                        {
                            treatmentCampaignResourceName = row.ExperimentArm.Campaigns.First();
                            break;
                        }
                    }
                }
            );

            // Verify that a treatment campaign was found.
            if (string.IsNullOrEmpty(treatmentCampaignResourceName))
            {
                Console.WriteLine("Could not find the treatment campaign associated with this experiment.");
                return;
            }

            // 3. Build the budget mapping and execute the graduation request.
            ExperimentServiceClient experimentService = client.GetService(
                Services.V25.ExperimentService);

            CampaignBudgetMapping budgetMapping = new CampaignBudgetMapping()
            {
                ExperimentCampaign = treatmentCampaignResourceName,
                CampaignBudget = budgetResourceName
            };

            experimentService.GraduateExperiment(experimentResourceName, new[] { budgetMapping });

            Console.WriteLine($"Successfully graduated experiment campaign '{treatmentCampaignResourceName}' " +
                $"with new budget '{budgetResourceName}'.");
        }
    }
}

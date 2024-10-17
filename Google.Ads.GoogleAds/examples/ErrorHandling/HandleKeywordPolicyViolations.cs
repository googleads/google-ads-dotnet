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
using Google.Ads.GoogleAds.V18.Common;
using Google.Ads.GoogleAds.V18.Errors;
using Google.Ads.GoogleAds.V18.Resources;
using Google.Ads.GoogleAds.V18.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V18.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V18.Enums.KeywordMatchTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V18
{
    /// <summary>
    /// This code example demonstrates how to request an exemption for policy violations of a
    /// keyword. Note that the example uses an exemptible policy-violating keyword by default.
    /// If you use a keyword that contains non-exemptible policy violations, they will not be
    /// sent for exemption request and you will still fail to create a keyword.
    /// If you specify a keyword that doesn't violate any policies, this example will just add the
    /// keyword as usual, similar to what the AddKeywords example does.
    /// Note that once you've requested policy exemption for a keyword, when you send a request for
    /// adding it again, the request will pass like when you add a non-violating keyword.
    /// </summary>
    public class HandleKeywordPolicyViolations : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="HandleKeywordPolicyViolations"/> example.
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

            /// <summary>
            /// The keyword text to add to the ad group.
            /// </summary>
            [Option("keywordText", Required = false, HelpText =
                "The keyword text to add to the ad group.")]
            public string KeywordText { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            HandleKeywordPolicyViolations codeExample = new HandleKeywordPolicyViolations();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.AdGroupId,
                options.KeywordText);
        }

        /// <summary>
        /// The default keyword to be used if keyword is not provided.
        /// </summary>
        private const string DEFAULT_KEYWORD = "medication";

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example demonstrates how to request an exemption for policy violations of " +
            "a keyword. Note that the example uses an exemptible policy-violating keyword by " +
            "default. If you use a keyword that contains non-exemptible policy violations, they " +
            "will not be sent for exemption request and you will still fail to create a keyword. " +
            "If you specify a keyword that doesn't violate any policies, this example will just " +
            "add the keyword as usual, similar to what the AddKeywords example does. Note that " +
            "once you've requested policy exemption for a keyword, when you send a request for " +
            "adding it again, the request will pass like when you add a non-violating keyword.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="adGroupId">ID of the ad group to which keywords are added.</param>
        /// <param name="keywordText">The keyword text to add to the ad group.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId,
            string keywordText)
        {
            // Get the AdGroupCriterionServiceClient.
            AdGroupCriterionServiceClient service = client.GetService(
                Services.V18.AdGroupCriterionService);

            if (string.IsNullOrEmpty(keywordText))
            {
                keywordText = DEFAULT_KEYWORD;
            }
            // Configures the keyword text and match type settings.
            KeywordInfo keywordInfo = new KeywordInfo()
            {
                Text = keywordText,
                MatchType = KeywordMatchType.Exact
            };

            // Constructs an ad group criterion using the keyword text info above.
            AdGroupCriterion adGroupCriterion = new AdGroupCriterion()
            {
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                Status = AdGroupCriterionStatus.Paused,
                Keyword = keywordInfo
            };

            AdGroupCriterionOperation operation = new AdGroupCriterionOperation()
            {
                Create = adGroupCriterion
            };

            try
            {
                try
                {
                    // Try sending a mutate request to add the keyword.
                    MutateAdGroupCriteriaResponse response = service.MutateAdGroupCriteria(
                        customerId.ToString(), new[] { operation });
                    Console.WriteLine($"Added a keyword with resource name " +
                        $"'{response.Results[0].ResourceName}'.");
                }
                catch (GoogleAdsException ex)
                {
                    PolicyViolationKey[] exemptPolicyViolationKeys =
                        FetchExemptPolicyViolationKeys(ex);

                    // Try sending exemption requests for creating a keyword. However, if your
                    // keyword contains many policy violations, but not all of them are exemptible,
                    // the request will not be sent.
                    RequestExemption(customerId, service, operation, exemptPolicyViolationKeys);
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
        /// Collects all policy violation keys that can be exempted for sending a exemption
        /// request later.
        /// </summary>
        /// <param name="ex">The Google Ads exception.</param>
        /// <returns>The exemptible policy violation keys.</returns>
        // [START handle_keyword_policy_violations]
        private static PolicyViolationKey[] FetchExemptPolicyViolationKeys(GoogleAdsException ex)
        {
            bool isFullyExemptable = true;
            List<PolicyViolationKey> exemptPolicyViolationKeys = new List<PolicyViolationKey>();

            Console.WriteLine("Google Ads failure details:");
            foreach (GoogleAdsError error in ex.Failure.Errors)
            {
                if (error.ErrorCode.ErrorCodeCase !=
                    ErrorCode.ErrorCodeOneofCase.PolicyViolationError)
                {
                    Console.WriteLine("No exemption request is sent because there are other " +
                        "non-policy related errors thrown.");
                    throw ex;
                }
                if (error.Details != null && error.Details.PolicyViolationDetails != null)
                {
                    PolicyViolationDetails details = error.Details.PolicyViolationDetails;
                    Console.WriteLine($"- Policy violation details:");

                    Console.WriteLine(" - Policy violation details:");
                    Console.WriteLine($"   - External policy name: '{details.ExternalPolicyName}'");
                    Console.WriteLine($"   - External policy description: " +
                        $"'{details.ExternalPolicyDescription}'");
                    Console.WriteLine($"   - Is exemptable: '{details.IsExemptible}'");

                    if (details.IsExemptible && details.Key != null)
                    {
                        PolicyViolationKey key = details.Key;
                        Console.WriteLine($"   - Policy violation key:");
                        Console.WriteLine($"     - Name: {key.PolicyName}");
                        Console.WriteLine($"     - Violating Text: {key.ViolatingText}");
                        exemptPolicyViolationKeys.Add(key);
                    }
                    else
                    {
                        isFullyExemptable = false;
                    }
                }
            }

            if (!isFullyExemptable)
            {
                Console.WriteLine("No exemption request is sent because your keyword " +
                    "contained some non-exemptible policy violations.");
                throw ex;
            }
            return exemptPolicyViolationKeys.ToArray();
        }
        // [END handle_keyword_policy_violations]

        /// <summary>
        /// Sends exemption requests for creating a keyword.
        /// </summary>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="service">The ad group criterion service.</param>
        /// <param name="operation">The ad group criterion operation to request exemption for.
        /// </param>
        /// <param name="exemptPolicyViolationKeys">The exemptable policy violation keys.</param>
        // [START handle_keyword_policy_violations_1]
        private static void RequestExemption(
            long customerId, AdGroupCriterionServiceClient service,
            AdGroupCriterionOperation operation, PolicyViolationKey[] exemptPolicyViolationKeys)
        {
            Console.WriteLine("Try adding a keyword again by requesting exemption for its policy "
                + "violations.");
            PolicyValidationParameter validationParameter = new PolicyValidationParameter();
            validationParameter.ExemptPolicyViolationKeys.AddRange(exemptPolicyViolationKeys);
            operation.ExemptPolicyViolationKeys.AddRange(exemptPolicyViolationKeys);

            MutateAdGroupCriteriaResponse response = service.MutateAdGroupCriteria(
                customerId.ToString(), new[] { operation });
            Console.WriteLine($"Successfully added a keyword with resource name " +
                $"'{response.Results[0].ResourceName}' by requesting for policy violation " +
                $"exemption.");
        }
        // [END handle_keyword_policy_violations_1]
    }
}

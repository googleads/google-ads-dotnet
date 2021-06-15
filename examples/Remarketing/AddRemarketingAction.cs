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
using Google.Ads.GoogleAds.V8.Common;
using Google.Ads.GoogleAds.V8.Errors;
using Google.Ads.GoogleAds.V8.Resources;
using Google.Ads.GoogleAds.V8.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Ads.GoogleAds.Examples.V8
{
    /// <summary>
    /// This code example adds a new remarketing action to the customer and then retrieves its
    /// associated tag snippets.
    /// </summary>
    public class AddRemarketingAction : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddRemarketingAction"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the conversion action is added.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the conversion action is added.")]
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
                    // The Google Ads customer ID for which the conversion action is added.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    return 0;
                });

            AddRemarketingAction codeExample = new AddRemarketingAction();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a new remarketing action to the customer and then retrieves " +
            "its associated tag snippets.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the conversion action is
        /// added.</param>
        // [START add_remarketing_action]
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the RemarketingActionService.
            RemarketingActionServiceClient remarketingActionService =
                client.GetService(Services.V8.RemarketingActionService);

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V8.GoogleAdsService);

            try
            {
                // Creates a remarketing action with the specified name.
                RemarketingAction remarketingAction = new RemarketingAction()
                {
                    Name = $"Remarketing action # {ExampleUtilities.GetRandomString()}"
                };
                // Creates a remarketing action operation.
                RemarketingActionOperation remarketingActionOperation =
                    new RemarketingActionOperation()
                    {
                        Create = remarketingAction
                    };

                // Issues a mutate request to add the remarketing action and prints out
                // some information.
                MutateRemarketingActionsResponse response =
                    remarketingActionService.MutateRemarketingActions(
                        customerId.ToString(), new[] { remarketingActionOperation });

                string remarketingActionResourceName = response.Results[0].ResourceName;

                Console.WriteLine($"Added remarketing action with resource name " +
                    $"'{remarketingActionResourceName}'.");

                // Creates a query that retrieves the previously created remarketing action
                // with its generated tag snippets.
                // [START add_remarketing_action_1]
                var query = $"SELECT remarketing_action.id, remarketing_action.name, " +
                    $"remarketing_action.tag_snippets FROM remarketing_action " +
                    $"WHERE remarketing_action.resource_name = '{remarketingActionResourceName}'";
                // [END add_remarketing_action_1]

                // Issues a search request and retrieve the results. There is only one row
                // because we limited the search using the resource name, which is unique.
                RemarketingAction result = googleAdsService.Search(customerId.ToString(), query)
                    .First()
                    .RemarketingAction;

                // Display the result.
                Console.WriteLine($"Remarketing action has ID {result.Id} and name" +
                    $" '{result.Id}'.");

                Console.WriteLine("It has the following generated tag snippets:");
                foreach (TagSnippet tagSnippet in result.TagSnippets)
                {
                    Console.WriteLine($"Tag snippet with code type '{tagSnippet.Type}' and code " +
                        $"page format '{tagSnippet.PageFormat}' has the following global site " +
                        $"tag:{tagSnippet.GlobalSiteTag} \n\nand the following event snippet:" +
                        $"{tagSnippet.EventSnippet}.");
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
        // [END add_remarketing_actions]
    }
}

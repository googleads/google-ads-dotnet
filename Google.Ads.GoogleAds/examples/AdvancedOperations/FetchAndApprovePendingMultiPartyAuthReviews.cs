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
using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V25.Errors;
using Google.Ads.GoogleAds.V25.Services;
using Google.Ads.GoogleAds.Extensions.Config;

using System;
using static Google.Ads.GoogleAds.V25.Enums.MultiPartyAuthReviewTargetResourceEnum.Types;
using static Google.Ads.GoogleAds.V25.Enums.MultiPartyAuthOperationTypeEnum.Types;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V25.Enums.MultiPartyAuthReviewStatusEnum.Types;
using System.Linq;
using Google.Rpc;
using System.IO;

namespace Google.Ads.GoogleAds.Examples.V25
{
    /// <summary>
    /// This code example fetches pending multi-party approvals and approves the first pending
    /// review request.
    /// </summary>
    public class FetchAndApprovePendingMultiPartyAuthReviews : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="FetchAndApprovePendingMultiPartyAuthReviews"/>
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
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            GoogleAdsConfig config = new GoogleAdsConfig();
            GoogleAdsClient client = new GoogleAdsClient(config);

            FetchAndApprovePendingMultiPartyAuthReviews codeExample =
                new FetchAndApprovePendingMultiPartyAuthReviews();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(client, options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example fetches pending multi-party approvals and approves the first " +
            "pending review request.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            try
            {
                // Retrieve the list of MPA auth reviews.
                List<string> pendingReviews = FetchPendingMPAReviews(client, customerId);

                if (pendingReviews.Count > 0)
                {
                    // Multi party auth reviews can only be resolved one at a time. In this code
                    // example, we illustrate approving the first pending review request.
                    ApproveMPAReview(client, customerId, pendingReviews[0]);
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
        /// Approves the MPA auth review.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="pendingReview">The pending multi-party auth review resource to be
        /// approved.</param>
        // [START approve_mpa_review]
        private void ApproveMPAReview(GoogleAdsClient client, long customerId, 
            string pendingReview)
        {
            // Get the ultiPartyAuthReviewService.
            MultiPartyAuthReviewServiceClient mpaReviewService = client.GetService(
                Services.V25.MultiPartyAuthReviewService);

            // Currently, you can only approve one request at a time. In addition, the approvals
            // can only be done by a second administrator.
            var request = new ResolveMultiPartyAuthReviewRequest()
            {
                CustomerId = customerId.ToString(),
                Operations = {
                    new ResolveMultiPartyAuthReviewOperation() {
                        MultiPartyAuthReview = pendingReview,
                        NewStatus = MultiPartyAuthReviewStatus.Approved,
                    }
                }
            };
            var response = mpaReviewService.ResolveMultiPartyAuthReview(request);

            ResolveMultiPartyAuthReviewResultOrError result =
                response.ResultOrError.First();
            if (result.ResultOrErrorCase ==
                ResolveMultiPartyAuthReviewResultOrError.ResultOrErrorOneofCase.Result)
            {
                Console.WriteLine($"Approved multi-party auth review: " +
                    $"{result.Result.MultiPartyAuthReview}.");
                if (result.Result.HasCustomerUserAccessInvitation)
                {
                    Console.WriteLine($"New user invitation created: " +
                        $"{result.Result.CustomerUserAccessInvitation}");
                }
                else if (result.Result.HasCustomerUserAccess)
                {
                    Console.WriteLine($"Affected customer user access resource: " +
                        $"{result.Result.CustomerUserAccess}");
                }
            }
            else
            {
                GoogleAdsFailure failure = result.PartialFailure;
                Console.WriteLine($"{failure.Errors.Count} partial failure error(s) " +
                    $"occurred");
            }
        }
        // [END approve_mpa_review]

        /// <summary>
        /// Fetches the pending MPA reviews.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>A list of resources for the pending multi-party auth reviews.</returns>
        // [START fetch_mpa_review]
        private List<string> FetchPendingMPAReviews(GoogleAdsClient client,
            long customerId)
        {
            List<string> pendingReviews = new List<string>();

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V25.GoogleAdsService);

            // Create a query that will retrieve all the pending MPA reviews.
            string query =
                @"SELECT
                    multi_party_auth_review.resource_name,
                    multi_party_auth_review.multi_party_auth_review_id,
                    multi_party_auth_review.creation_date_time,
                    multi_party_auth_review.request_user_email,
                    multi_party_auth_review.operation_type,
                    multi_party_auth_review.justification,
                    multi_party_auth_review.target_resource,
                    multi_party_auth_review.customer_user_access_review.old_customer_user_access,
                    multi_party_auth_review.customer_user_access_review.new_customer_user_access,
                    multi_party_auth_review.customer_user_access_invitation_review.new_customer_user_access_invitation
                FROM multi_party_auth_review
                WHERE multi_party_auth_review.review_status = 'PENDING'";

            // Issue a search request.
            googleAdsService.SearchStream(customerId.ToString(), query,
                delegate (SearchGoogleAdsStreamResponse resp)
                {
                    foreach (GoogleAdsRow googleAdsRow in resp.Results)
                    {
                        var mpaReview = googleAdsRow.MultiPartyAuthReview;
                        Console.WriteLine($"{mpaReview.RequestUserEmail} created a pending " +
                            $"multi-party auth review with ID {mpaReview.MultiPartyAuthReviewId}" +
                            $" at {mpaReview.CreationDateTime}. This request is for target " +
                            $"resource type = {mpaReview.TargetResource} and operation type = " +
                            $"{mpaReview.OperationType}. The justification is " +
                            $"\"{mpaReview.Justification}\".");

                        if (mpaReview.TargetResource ==
                            MultiPartyAuthReviewTargetResource.CustomerUserAccess)
                        {
                            var accessReview = mpaReview.CustomerUserAccessReview;
                            if (mpaReview.OperationType == MultiPartyAuthOperationType.Update)
                            {
                                // When updating a customer user access, only the new access level
                                // is populated.
                                Console.WriteLine("Old resource name: {0}, new access role: {1}.",
                                    accessReview.OldCustomerUserAccess,
                                    accessReview.NewCustomerUserAccess.AccessRole);
                            }
                            else if (mpaReview.OperationType == MultiPartyAuthOperationType.Remove)
                            {
                                Console.WriteLine("Old resource name: {0}.",
                                    accessReview.OldCustomerUserAccess);
                            }
                        }
                        else if (mpaReview.TargetResource ==
                            MultiPartyAuthReviewTargetResource.CustomerUserAccessInvitation)
                        {
                            var newInvite = mpaReview.CustomerUserAccessInvitationReview
                                .NewCustomerUserAccessInvitation;
                            Console.WriteLine("Invitation email address: {0}, Role: {1}.",
                                newInvite.EmailAddress, newInvite.AccessRole);
                        }

                        pendingReviews.Add(mpaReview.ResourceName);
                    }
                });
            return pendingReviews;
        }
        // [END fetch_mpa_review]
    }
}

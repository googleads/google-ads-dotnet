// Copyright 2024 Google LLC
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
using Google.Ads.GoogleAds.V16.Errors;
using Google.Ads.GoogleAds.V16.Services;
using static Google.Ads.GoogleAds.V16.Enums.IdentityVerificationProgramEnum.Types;
using static Google.Ads.GoogleAds.V16.Enums.IdentityVerificationProgramStatusEnum.Types;
using System;
using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Extensions.Config;

namespace Google.Ads.GoogleAds.Examples.V16
{
    /// <summary>
    /// This code example illustrates how to retrieve the status of the advertiser identity
    /// verification program and, if required and not already started, how to start the verification
    /// process.
    /// </summary>
    public class VerifyAdvertiserIdentity : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="VerifyAdvertiserIdentity"/> example.
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

            VerifyAdvertiserIdentity codeExample = new VerifyAdvertiserIdentity();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example retrieves the status of the advertiser identity verification " +
             "program and, if required and not already started, starts the verification process.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Retrieve the current Advertiser Identity Verification status.
            IdentityVerification identityVerification =
                GetIdentityVerification(client, customerId);

            if (identityVerification == null)
            {

                // If GetIdentityVerification returned an empty response, the account is not
                // enrolled in mandatory identity verification.
                Console.WriteLine($"Account {customerId} is not required to perform advertiser " +
                    "identity verification.\n" +
                    "See https://support.google.com/adspolicy/answer/9703665 for details on how " +
                    "and when an account is required to undergo the advertiser identity " +
                    "verification program.");
                    return;
            }
            else
            {
                switch(identityVerification.VerificationProgress.ProgramStatus)
                {
                    case IdentityVerificationProgramStatus.Unspecified:
                        // Starts an identity verification session.
                        StartIdentityVerification(client, customerId);
                        // Calls GetIdentityVerification again to retrieve the verification progress
                        // after starting an identity verification session.
                        GetIdentityVerification(client, customerId);
                        break;
                    case IdentityVerificationProgramStatus.PendingUserAction:
                        // If there is an identity verification session in progress, there is no
                        // need to start another one by calling StartIdentityVerification.
                        Console.WriteLine("There is an advertiser identity verification session " +
                            "in progress.\n" +
                            "The URL for the verification process is: " +
                            identityVerification.VerificationProgress.ActionUrl +
                            " and it will expire at " +
                            identityVerification.VerificationProgress.InvitationLinkExpirationTime);
                        break;
                    case IdentityVerificationProgramStatus.PendingReview:
                        Console.WriteLine("The verification is under review.");
                        break;
                    case IdentityVerificationProgramStatus.Success:
                        Console.WriteLine("The verification completed successfully.");
                        break;
                    default:
                        Console.WriteLine("The verification has an unknown state.");
                        break;
                }
            }
        }

        /// <summary>
        /// Retrieves the status of the advertiser identity verification process.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        // [START verify_advertiser_identity_1]
        private static IdentityVerification GetIdentityVerification(
                GoogleAdsClient client, long customerId)
        {
            IdentityVerificationServiceClient identityVerificationService =
                client.GetService(Services.V16.IdentityVerificationService);

            try {
                GetIdentityVerificationResponse response =
                    identityVerificationService.GetIdentityVerification(
                        new GetIdentityVerificationRequest()
                        {
                            CustomerId = customerId.ToString()
                        }
                    );

                    if (response.IdentityVerification.Count == 0)
                    {
                        return null;
                    }

                    IdentityVerification identityVerification = response.IdentityVerification[0];
                    string deadline =
                        identityVerification.IdentityVerificationRequirement.VerificationCompletionDeadlineTime;
                     IdentityVerificationProgress identityVerificationProgress =
                        identityVerification.VerificationProgress;
                    Console.WriteLine($"Account {customerId} has a verification completion " +
                        $"deadline of {deadline} and status " +
                        $"{identityVerificationProgress.ProgramStatus} for advertiser identity " +
                        "verification.");

                    return identityVerification;
            } catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }


        }
        // [END verify_advertiser_identity_1]

        /// <summary>
        /// Starts the identity verification process.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        // [START verify_advertiser_identity_2]
        private static void StartIdentityVerification(GoogleAdsClient client, long customerId)
        {
            IdentityVerificationServiceClient identityVerificationService =
                client.GetService(Services.V16.IdentityVerificationService);

            StartIdentityVerificationRequest request = new StartIdentityVerificationRequest()
            {
                CustomerId = customerId.ToString(),
                VerificationProgram = IdentityVerificationProgram.AdvertiserIdentityVerification
            };

            try {
                identityVerificationService.StartIdentityVerification(request);
            } catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }
        // [END verify_advertiser_identity_2]
    }
}

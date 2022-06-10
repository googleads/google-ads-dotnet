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
using Google.Ads.GoogleAds.V11.Common;
using Google.Ads.GoogleAds.V11.Errors;
using Google.Ads.GoogleAds.V11.Resources;
using Google.Ads.GoogleAds.V11.Services;
using Google.Api.Gax;
using Google.LongRunning;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using static Google.Ads.GoogleAds.V11.Enums.CustomerMatchUploadKeyTypeEnum.Types;
using static Google.Ads.GoogleAds.V11.Enums.OfflineUserDataJobStatusEnum.Types;
using static Google.Ads.GoogleAds.V11.Enums.OfflineUserDataJobTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V11
{
    /// <summary>
    ///  This code example uses Customer Match to create a new user list (a.k.a. audience) and adds
    ///  users to it.
    ///
    ///  Note: It may take up to several hours for the list to be populated with users.
    ///  Email addresses must be associated with a Google account.
    ///  For privacy purposes, the user list size will show as zero until the list has
    ///  at least 1,000 users. After that, the size will be rounded to the two most
    ///  significant digits.
    /// </summary>
    public class AddCustomerMatchUserList : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddCustomerMatchUserList"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the user list is added.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the user list is added.")]
            public long CustomerId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddCustomerMatchUserList codeExample = new AddCustomerMatchUserList();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        private static SHA256 digest = SHA256.Create();

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example uses Customer Match to create a new user list (a.k.a. audience) " +
            "and adds users to it. \nNote: It may take up to several hours for the list to be " +
            "populated with users. Email addresses must be associated with a Google account. For " +
            "privacy purposes, the user list size will show as zero until the list has at least " +
            "1,000 users. After that, the size will be rounded to the two most significant digits.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the user list is added.
        /// </param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            try
            {
                string userListResourceName = CreateCustomerMatchUserList(client, customerId);
                string offlineUserDataJobResourceName = AddUsersToCustomerMatchUserList(
                    client, customerId, userListResourceName);

                // Since offline user data jobs may take 24 hours or more to complete, you may need
                // to call this function periodically until the job completes.
                CheckJobStatusAndPrintResults(client, customerId, offlineUserDataJobResourceName,
                    userListResourceName);
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
        /// Creates the customer match user list.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the user list is added.
        /// </param>
        /// <returns>The resource name of the newly created user list</returns>
        private string CreateCustomerMatchUserList(GoogleAdsClient client, long customerId)
        {
            // Get the UserListService.
            UserListServiceClient service = client.GetService(Services.V11.UserListService);

            // Creates the user list.
            UserList userList = new UserList()
            {
                Name = $"Customer Match list# {ExampleUtilities.GetShortRandomString()}",
                Description = "A list of customers that originated from email and physical" +
                    " addresses",
                // Customer Match user lists can use a membership life span of 10000 to
                // indicate unlimited; otherwise normal values apply.
                // Sets the membership life span to 30 days.
                MembershipLifeSpan = 30,
                CrmBasedUserList = new CrmBasedUserListInfo()
                {
                    UploadKeyType = CustomerMatchUploadKeyType.ContactInfo
                }
            };
            // Creates the user list operation.
            UserListOperation operation = new UserListOperation()
            {
                Create = userList
            };

            // Issues a mutate request to add the user list and prints some information.
            MutateUserListsResponse response = service.MutateUserLists(
                customerId.ToString(), new[] { operation });
            string userListResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"User list with resource name '{userListResourceName}' " +
                $"was created.");
            return userListResourceName;
        }

        /// <summary>
        /// Creates and executes an asynchronous job to add users to the Customer Match user list.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which calls are made.
        /// </param>
        /// <param name="userListResourceName">the resource name of the Customer Match user list
        /// to add users to</param>
        /// <remarks>Resource of the offline user data job.</remarks>
        // [START add_customer_match_user_list]
        private static string AddUsersToCustomerMatchUserList(GoogleAdsClient client,
            long customerId, string userListResourceName)
        {
            // Get the OfflineUserDataJobService.
            OfflineUserDataJobServiceClient service = client.GetService(
                Services.V11.OfflineUserDataJobService);

            // Creates a new offline user data job.
            OfflineUserDataJob offlineUserDataJob = new OfflineUserDataJob()
            {
                Type = OfflineUserDataJobType.CustomerMatchUserList,
                CustomerMatchUserListMetadata = new CustomerMatchUserListMetadata()
                {
                    UserList = userListResourceName
                }
            };

            // Issues a request to create the offline user data job.
            CreateOfflineUserDataJobResponse response1 = service.CreateOfflineUserDataJob(
                customerId.ToString(), offlineUserDataJob);
            string offlineUserDataJobResourceName = response1.ResourceName;
            Console.WriteLine($"Created an offline user data job with resource name: " +
                $"'{offlineUserDataJobResourceName}'.");

            AddOfflineUserDataJobOperationsRequest request =
                new AddOfflineUserDataJobOperationsRequest()
                {
                    ResourceName = offlineUserDataJobResourceName,
                    Operations = { BuildOfflineUserDataJobOperations() },
                    EnablePartialFailure = true,
                };
            // Issues a request to add the operations to the offline user data job.
            AddOfflineUserDataJobOperationsResponse response2 =
                service.AddOfflineUserDataJobOperations(request);

            // Prints the status message if any partial failure error is returned.
            // Note: The details of each partial failure error are not printed here,
            // you can refer to the example HandlePartialFailure.cs to learn more.
            if (response2.PartialFailureError != null)
            {
                // Extracts the partial failure from the response status.
                GoogleAdsFailure partialFailure = response2.PartialFailure;
                Console.WriteLine($"{partialFailure.Errors.Count} partial failure error(s) " +
                    $"occurred");
            }
            Console.WriteLine("The operations are added to the offline user data job.");

            // Issues an asynchronous request to run the offline user data job for executing
            // all added operations.
            Operation<Empty, OfflineUserDataJobMetadata> operationResponse =
                service.RunOfflineUserDataJob(offlineUserDataJobResourceName);

            Console.WriteLine("Asynchronous request to execute the added operations started.");

            // Since offline user data jobs may take 24 hours or more to complete, it may not be
            // practical to do operationResponse.PollUntilCompleted() to wait for the results.
            // Instead, we save the offlineUserDataJobResourceName and use GoogleAdsService.Search
            // to check for the job status periodically.
            // In case you wish to follow the PollUntilCompleted or PollOnce approach, make sure
            // you keep both operationResponse and service variables alive until the polling
            // completes.

            return offlineUserDataJobResourceName;
        }
        // [END add_customer_match_user_list]

        /// <summary>
        /// Retrieves, checks, and prints the status of the offline user data job.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which calls are made.
        /// </param>
        /// <param name="offlineUserDataJobResourceName">Resource name of the of the offline user
        /// data job.</param>
        /// <param name="userListResourceName">Resource name of the Customer Match user list.</param>
        private static void CheckJobStatusAndPrintResults(GoogleAdsClient client, long customerId,
            string offlineUserDataJobResourceName, string userListResourceName)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient service = client.GetService(Services.V11.GoogleAdsService);

            string query = "SELECT offline_user_data_job.resource_name, " +
                "offline_user_data_job.id, offline_user_data_job.status, " +
                "offline_user_data_job.type, offline_user_data_job.failure_reason " +
                "FROM offline_user_data_job WHERE " +
                $"offline_user_data_job.resource_name = '{offlineUserDataJobResourceName}'";

            // Issues the query and gets the GoogleAdsRow containing the job from the response.
            GoogleAdsRow googleAdsRow = service.Search(customerId.ToString(), query).First();

            OfflineUserDataJob offlineUserDataJob = googleAdsRow.OfflineUserDataJob;
            Console.WriteLine($"Offline user data job ID {offlineUserDataJob.Id} with type " +
                $"'{offlineUserDataJob.Type}' has status: {offlineUserDataJob.Status}");
                
            switch (offlineUserDataJob.Status)
            {
                case OfflineUserDataJobStatus.Success:
                    // Prints information about the user list.
                    PrintCustomerMatchUserListInfo(client, customerId, userListResourceName);
                    break;

                case OfflineUserDataJobStatus.Failed:
                    Console.WriteLine($"  Failure reason: {offlineUserDataJob.FailureReason}");
                    break;

                case OfflineUserDataJobStatus.Pending:
                case OfflineUserDataJobStatus.Running:
                    Console.WriteLine("To check the status of the job periodically, use the " +
                        $"following GAQL query with GoogleAdsService.search:\n\n{query}");
                    break;
            }
        }

        /// <summary>
        /// Builds and returns offline user data job operations to add one user identified by an
        /// email address and one user identified based on a physical address.
        /// </summary>
        /// <returns>An array with the operations</returns>
        private static OfflineUserDataJobOperation[] BuildOfflineUserDataJobOperations()
        {
            // [START add_customer_match_user_list_2]
            // Creates a first user data based on an email address.
            UserData userDataWithEmailAddress = new UserData()
            {
                UserIdentifiers = {
                    new UserIdentifier()
                    {
                        // Hash normalized email addresses based on SHA-256 hashing algorithm.
                        HashedEmail = NormalizeAndHash("customer@example.com")
                    }
                }
            };

            // Creates a second user data based on a physical address.
            UserData userDataWithPhysicalAddress = new UserData()
            {
                UserIdentifiers =
                {
                    new UserIdentifier()
                    {
                        AddressInfo = new OfflineUserAddressInfo()
                        {
                            // First and last name must be normalized and hashed.
                            HashedFirstName = NormalizeAndHash("John"),
                            HashedLastName = NormalizeAndHash("Doe"),
                            // Country code and zip code are sent in plain text.
                            CountryCode = "US",
                            PostalCode = "10011"
                        }
                    }
                }
            };
            // [END add_customer_match_user_list_2]

            // Creates the operations to add the two users.
            return new OfflineUserDataJobOperation[]
            {
                new OfflineUserDataJobOperation()
                {
                    Create = userDataWithEmailAddress
                },
                new OfflineUserDataJobOperation()
                {
                    Create = userDataWithPhysicalAddress
                }
            };
        }

        /// <summary>
        /// Prints information about the Customer Match user list.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which calls are made.
        /// </param>
        /// <param name="userListResourceName">The resource name of the Customer Match user list
        /// to print information about.</param>
        private static void PrintCustomerMatchUserListInfo(GoogleAdsClient client, long customerId,
            string userListResourceName)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient service =
                client.GetService(Services.V11.GoogleAdsService);

            // Creates a query that retrieves the user list.
            string query =
                "SELECT user_list.size_for_display, user_list.size_for_search " +
                "FROM user_list " +
                $"WHERE user_list.resource_name = '{userListResourceName}'";
            // Issues a search stream request.
            service.SearchStream(customerId.ToString(), query,
               delegate (SearchGoogleAdsStreamResponse resp)
               {
                   // Display the results.
                   foreach (GoogleAdsRow userListRow in resp.Results)
                   {
                       UserList userList = userListRow.UserList;
                       Console.WriteLine("The estimated number of users that the user list " +
                           $"'{userList.ResourceName}' has is {userList.SizeForDisplay}" +
                           $" for Display and {userList.SizeForSearch} for Search.");
                   }
               }
           );

            Console.WriteLine("Reminder: It may take several hours for the user list to be " +
                "populated with the users so getting zeros for the estimations is expected.");
        }

        /// <summary>
        /// Normalizes and hashes a string value.
        /// </summary>
        /// <param name="value">The value to normalize and hash.</param>
        /// <returns>The normalized and hashed value.</returns>
        private static string NormalizeAndHash(string value)
        {
            return ToSha256String(digest, ToNormalizedValue(value));
        }

        /// <summary>
        /// Hash a string value using SHA-256 hashing algorithm.
        /// </summary>
        /// <param name="digest">Provides the algorithm for SHA-256.</param>
        /// <param name="value">The string value (e.g. an email address) to hash.</param>
        /// <returns>The hashed value.</returns>
        private static string ToSha256String(SHA256 digest, string value)
        {
            byte[] digestBytes = digest.ComputeHash(Encoding.UTF8.GetBytes(value));
            // Convert the byte array into an unhyphenated hexadecimal string.
            return BitConverter.ToString(digestBytes).Replace("-", string.Empty);
        }

        /// <summary>
        /// Removes leading and trailing whitespace and converts all characters to
        /// lower case.
        /// </summary>
        /// <param name="value">The value to normalize.</param>
        /// <returns>The normalized value.</returns>
        private static string ToNormalizedValue(string value)
        {
            return value.Trim().ToLower();
        }
    }
}

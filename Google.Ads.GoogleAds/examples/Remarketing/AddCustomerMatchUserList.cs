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
using Google.Ads.GoogleAds.V13.Common;
using Google.Ads.GoogleAds.V13.Errors;
using Google.Ads.GoogleAds.V13.Resources;
using Google.Ads.GoogleAds.V13.Services;
using Google.Api.Gax;
using Google.LongRunning;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using static Google.Ads.GoogleAds.V13.Enums.CustomerMatchUploadKeyTypeEnum.Types;
using static Google.Ads.GoogleAds.V13.Enums.OfflineUserDataJobStatusEnum.Types;
using static Google.Ads.GoogleAds.V13.Enums.OfflineUserDataJobTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V13
{
    /// <summary>
    /// Creates operations to add members to a user list (a.k.a. audience) using an
    /// OfflineUserDataJob, and if requested, runs the job.
    ///
    /// <p>If a job ID is specified, this example adds operations to that job.
    /// Otherwise, it creates a new job for the operations.</p>
    ///
    /// <p>IMPORTANT: Your application should create a single job containing
    /// <em>all</em> of the operations for a user list. This will be far more efficient
    /// than creating and running multiple jobs that each contain a small set of
    /// operations.</p>
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

            /// <summary>
            /// If true, runs the OfflineUserDataJob after adding operations. The default value is
            /// false.
            /// </summary>
            [Option("runJob", Required = false, HelpText =
                "If true, runs the OfflineUserDataJob after adding operations. The default value " +
                "is false.")]
            public bool RunJob { get; set; } = false;

            /// <summary>
            /// The ID of an existing user list. If not specified, this example will create a new
            /// user list.
            /// </summary>
            [Option("userListId", Required = false, HelpText =
                "The ID of an existing user list. If not specified, this example will create a " +
                "new user list.")]
            public long? UserListId { get; set; }

            /// <summary>
            /// The ID of an existing OfflineUserDataJob in the PENDING state. If not specified,
            /// this example will create a new job.
            /// </summary>
            [Option("offlineUserDataJobId", Required = false, HelpText =
                "The ID of an existing OfflineUserDataJob in the PENDING state. If not specified," +
                "this example will create a new job.")]
            public long? OfflineUserDataJobId { get; set; }
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
            codeExample.Run(new GoogleAdsClient(), options.CustomerId,
                options.RunJob, options.UserListId, options.OfflineUserDataJobId);
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
        /// <param name="customerId">The Google Ads customer ID for which the user list is
        /// added.</param>
        /// <param name="runJob">If true, runs the offlineUserDataJob after adding operations.
        /// </param>
        /// <param name="userListId">The ID of an existing user list.</param>
        /// <param name="offlineUserDataJobId">The ID of an existing OfflineUserDataJob.</param>
        public void Run(GoogleAdsClient client, long customerId, bool runJob,
            long? userListId, long? offlineUserDataJobId)
        {
            try
            {
                string userListResourceName = null;
                if (offlineUserDataJobId == null)
                {
                    if (userListId == null)
                    {
                        userListResourceName = CreateCustomerMatchUserList(client, customerId);
                    }
                    else
                    {
                        userListResourceName = ResourceNames.UserList(customerId, userListId.Value);
                    }
                }

                string offlineUserDataJobResourceName = AddUsersToCustomerMatchUserList(
                    client, customerId, userListResourceName, runJob, offlineUserDataJobId);

                // Since offline user data jobs may take 24 hours or more to complete, you may need
                // to call this function periodically until the job completes.
                if (runJob)
                {
                    CheckJobStatusAndPrintResults(client, customerId,
                        offlineUserDataJobResourceName);
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
        /// Creates the customer match user list.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the user list is added.
        /// </param>
        /// <returns>The resource name of the newly created user list</returns>
        private string CreateCustomerMatchUserList(GoogleAdsClient client, long customerId)
        {
            // Get the UserListService.
            UserListServiceClient service = client.GetService(Services.V13.UserListService);

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
        /// <param name="userListResourceName">The resource name of the Customer Match user list
        /// to add users to</param>
        /// <param name="runJob">If true, runs the offlineUserDataJob after adding operations.
        /// </param>
        /// <param name="offlineUserDataJobId">The ID of an existing OfflineUserDataJob.</param>
        /// <remarks>Resource of the offline user data job.</remarks>
        // [START add_customer_match_user_list]
        private static string AddUsersToCustomerMatchUserList(GoogleAdsClient client,
            long customerId, string userListResourceName, bool runJob,
            long? offlineUserDataJobId)
        {
            // Get the OfflineUserDataJobService.
            OfflineUserDataJobServiceClient service = client.GetService(
                Services.V13.OfflineUserDataJobService);

            string offlineUserDataJobResourceName;
            if (offlineUserDataJobId == null)
            {
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
                offlineUserDataJobResourceName = response1.ResourceName;
                Console.WriteLine($"Created an offline user data job with resource name: " +
                    $"'{offlineUserDataJobResourceName}'.");
            } else {
                // Reuses the specified offline user data job.
                offlineUserDataJobResourceName =
                    ResourceNames.OfflineUserDataJob(customerId, offlineUserDataJobId.Value);
            }

            AddOfflineUserDataJobOperationsRequest request =
                new AddOfflineUserDataJobOperationsRequest()
                {
                    ResourceName = offlineUserDataJobResourceName,
                    Operations = { BuildOfflineUserDataJobOperations() },
                    EnablePartialFailure = true,
                };
            // Issues a request to add the operations to the offline user data job. This example
            // only adds a few operations, so it only sends one AddOfflineUserDataJobOperations
            // request.
            // If your application is adding a large number of operations, split the operations into
            // batches and send multiple AddOfflineUserDataJobOperations requests for the SAME job.
            // See https://developers.google.com/google-ads/api/docs/remarketing/audience-types/customer-match#customer_match_considerations
            // and https://developers.google.com/google-ads/api/docs/best-practices/quotas#user_data
            // for more information on the per-request limits.
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

            if (!runJob)
            {
                Console.WriteLine($"Not running offline user data job " +
                    "'{offlineUserDataJobResourceName}', as requested.");
                return offlineUserDataJobResourceName;
            }

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
        private static void CheckJobStatusAndPrintResults(GoogleAdsClient client, long customerId,
            string offlineUserDataJobResourceName)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient service = client.GetService(Services.V13.GoogleAdsService);

            string query = "SELECT offline_user_data_job.resource_name, " +
                "offline_user_data_job.id, offline_user_data_job.status, " +
                "offline_user_data_job.type, offline_user_data_job.failure_reason " +
                "offline_user_data_job.customer_match_user_list_metadata_user_list " +
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
                    PrintCustomerMatchUserListInfo(client, customerId,
                        offlineUserDataJob.CustomerMatchUserListMetadata.UserList);
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

            // Creates a raw input list of unhashed user information, where each element of the list
            // represents a single user and is a map containing a separate entry for the keys
            // "email", "phone", "firstName", "lastName", "countryCode", and "postalCode".
            // In your application, this data might come from a file or a database.
            List<Dictionary<string, string>> rawRecords = new List<Dictionary<string, string>>();

            // The first user data has an email address and a phone number.
            Dictionary<string, string> rawRecord1 = new Dictionary<string, string>();
            rawRecord1.Add("email", "test@gmail.com");
            // Phone number to be converted to E.164 format, with a leading '+' as required.
            // This includes whitespace that will be removed later.
            rawRecord1.Add("phone", "+1 234 5678910");

            // The second user data has an email address, a mailing address, and a phone number.
            Dictionary<string, string> rawRecord2 = new Dictionary<string, string>();
            // Email address that includes a period (.) before the Gmail domain.
            rawRecord2.Add("email", "test.2@gmail.com");
            // Address that includes all four required elements: first name, last name, country
            // code, and postal code.
            rawRecord2.Add("firstName", "John");
            rawRecord2.Add("lastName", "Doe");
            rawRecord2.Add("countryCode", "US");
            rawRecord2.Add("postalCode", "10011");
            // Phone number to be converted to E.164 format, with a leading '+' as required.
            // This includes whitespace that will be removed later.
            rawRecord2.Add("phone", "+1 234 5678911");

            // The third user data only has an email address.
            Dictionary<string, string> rawRecord3 = new Dictionary<string, string>();
            rawRecord3.Add("email", "test3@gmail.com");

            // Adds the raw records to the raw input list.
            rawRecords.Add(rawRecord1);
            rawRecords.Add(rawRecord2);
            rawRecords.Add(rawRecord3);

            // Iterates over the raw input list and creates a UserData object for each record.
            List<UserData> userDataList = new List<UserData>();
            foreach (Dictionary<string, string> rawRecord in rawRecords) {
                // Creates a UserData object that represents a member of the user list.
                UserData userData = new UserData();
                // Checks if the record has email, phone, or address information, and adds a
                // SEPARATE UserIdentifier object for each one found.
                // For example, a record with an email address and a phone number will result in a
                // UserData with two UserIdentifiers.

                // IMPORTANT: Since the identifier attribute of UserIdentifier
                // (https://developers.google.com/google-ads/api/reference/rpc/latest/UserIdentifier)
                // is a oneof
                // (https://protobuf.dev/programming-guides/proto3/#oneof-features), you must set
                // only ONE of hashedEmail, hashedPhoneNumber, mobileId, thirdPartyUserId,
                // or addressInfo.
                // Setting more than one of these attributes on the same UserIdentifier will clear
                // all the other members of the oneof.
                // For example, the following code is INCORRECT and will result in a UserIdentifier
                // with ONLY a hashedPhoneNumber.
                //
                // UserIdentifier incorrectlyPopulatedUserIdentifier = new UserIdentifier()
                // {
                //      HashedEmail = "...",
                //      HashedPhoneNumber = "..."
                // };
                //
                // The separate 'if' statements below demonstrate the correct approach for creating
                // a UserData for a member with multiple UserIdentifiers.

                // Checks if the record has an email address, and if so, adds a UserIdentifier
                // for it.
                if (rawRecord.ContainsKey("email")) {
                    UserIdentifier hashedEmailIdentifier = new UserIdentifier()
                    {
                        HashedEmail = NormalizeAndHash(rawRecord["email"], true)
                    };

                    userData.UserIdentifiers.Add(hashedEmailIdentifier);
                }

                // Checks if the record has a phone number, and if so, adds a UserIdentifier for it.
                if (rawRecord.ContainsKey("phone")) {
                    UserIdentifier hashedPhoneNumberIdentifier = new UserIdentifier()
                    {
                        HashedPhoneNumber = NormalizeAndHash(rawRecord["phone"], true)
                    };

                    // Adds the hashed phone number identifier to the UserData object's list.
                    userData.UserIdentifiers.Add(hashedPhoneNumberIdentifier);
                }

                // Checks if the record has all the required mailing address elements, and if so,
                // adds a UserIdentifier for the mailing address.
                if (rawRecord.ContainsKey("firstName")) {
                    // Checks if the record contains all the other required elements of a mailing
                    // address.
                    HashSet<string> missingAddressKeys = new HashSet<string>();
                    foreach (string addressKey in new string[] {"lastName", "countryCode",
                        "postalCode"}) {
                    if (!rawRecord.ContainsKey(addressKey)) {
                        missingAddressKeys.Add(addressKey);
                    }
                    }

                    if (!missingAddressKeys.Any()) {
                    Console.WriteLine(
                        $"Skipping addition of mailing address information because the following " +
                            "required keys are missing: {missingAddressKeys}");
                    } else {
                        // Creates an OfflineUserAddressInfo object that contains all the required
                        // elements of a mailing address.
                        OfflineUserAddressInfo addressInfo = new OfflineUserAddressInfo()
                        {
                            HashedFirstName = NormalizeAndHash(rawRecord["firstName"]),
                            HashedLastName = NormalizeAndHash(rawRecord["lastName"]),
                            CountryCode = rawRecord["countryCode"],
                            PostalCode = rawRecord["postalCode"]
                        };

                        UserIdentifier addressIdentifier = new UserIdentifier()
                        {
                            AddressInfo = addressInfo
                        };

                        // Adds the address identifier to the UserData object's list.
                        userData.UserIdentifiers.Add(addressIdentifier);
                    }
                }

                if (userData.UserIdentifiers.Any())
                {
                    userDataList.Add(userData);
                }
            }

            // [END add_customer_match_user_list_2]

            // Creates the operations to add the users.
            List<OfflineUserDataJobOperation> operations = new List<OfflineUserDataJobOperation>();
            foreach(UserData userData in userDataList)
            {
                operations.Add(new OfflineUserDataJobOperation()
                {
                    Create = userData
                });
            }
            return operations.ToArray();
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
                client.GetService(Services.V13.GoogleAdsService);

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
        /// <param name="trimIntermediateSpaces">If true, removes leading, trailing and intermediate
        /// spaces from the string before hashing. Otherwise, only removes leading and trailing
        /// spaces before hashing.</param>
        /// <returns>The normalized and hashed value.</returns>
        private static string NormalizeAndHash(string value, bool trimIntermediateSpaces = false)
        {
            string normalized;
            if (trimIntermediateSpaces)
            {
                normalized = value.Replace(" ", "").ToLower();
            }
            else
            {
                normalized = ToNormalizedValue(value);
            }
            return ToSha256String(digest, normalized);
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

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V3.Common;
using Google.Ads.GoogleAds.V3.Errors;
using Google.Ads.GoogleAds.V3.Resources;
using Google.Ads.GoogleAds.V3.Services;
using static Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobTypeEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V3
{
    /// <summary>
    /// This code example uploads offline data for store sales transactions.
    /// This feature is only available to allowlisted accounts. See
    /// https://support.google.com/google-ads/answer/7620302 for more details.
    /// </summary>
    public class UploadStoreSalesTransactions : ExampleBase
    {
        // Gets a digest for generating hashed values using SHA-256. You must normalize and hash the
        // the value for any field where the name begins with "hashed". See the normalizeAndHash()
        // method.
        private static readonly SHA256 _digest = SHA256.Create();

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            UploadStoreSalesTransactions codeExample = new UploadStoreSalesTransactions();

            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The type of user data in the job (first or third party). If you have an official
            // store sales partnership with Google, use StoreSalesUploadThirdParty.
            // Otherwise, use StoreSalesUploadFirstParty or omit this parameter.
            OfflineUserDataJobType offlineUserDataJobType =
                OfflineUserDataJobType.StoreSalesUploadFirstParty;

            // The ID of a store sales conversion action.
            long conversionActionId = long.Parse("INSERT_CONVERSION_ACTION_ID_HERE");

            // Optional (but recommended) external ID to identify the offline user data job.
            long? externalId = long.Parse("INSERT_EXTERNAL_ID_HERE");

            // OPTIONAL: If uploading third party data, also specify the following values:
            string advertiserUploadDateTime = "INSERT_ADVERTISER_UPLOAD_DATE_TIME_HERE";
            string bridgeMapVersionId = "INSERT_BRIDGE_MAP_VERSION_ID_HERE";
            long? partnerId = long.Parse("INSERT_PARTNER_ID_HERE");


            codeExample.Run(new GoogleAdsClient(), customerId, conversionActionId,
                offlineUserDataJobType: offlineUserDataJobType,
                externalId: externalId,
                advertiserUploadDateTime: advertiserUploadDateTime,
                bridgeMapVersionId: bridgeMapVersionId,
                partnerId: partnerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example uploads offline data for store sales transactions. " +
                       "This feature is only available to allowlisted accounts. " +
                       "See https://support.google.com/google-ads/answer/7620302 for more details.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="conversionActionId">The ID of a store sales conversion action.</param>
        /// <param name="offlineUserDataJobType">The type of user data in the job (first or third
        ///     party). If you have an official store sales partnership with Google, use
        ///     StoreSalesUploadThirdParty. Otherwise, use StoreSalesUploadFirstParty or
        ///     omit this parameter.</param>
        /// <param name="externalId">Optional (but recommended) external ID to identify the offline
        ///     user data job.</param>
        /// <param name="advertiserUploadDateTime">Date and time the advertiser uploaded data to the
        ///     partner. Only required if uploading third party data.</param>
        /// <param name="bridgeMapVersionId">Version of partner IDs to be used for uploads. Only
        ///     required if uploading third party data.</param>
        /// <param name="partnerId">ID of the third party partner. Only required if uploading third
        ///     party data.</param>
        public void Run(GoogleAdsClient client, long customerId, long conversionActionId,
            OfflineUserDataJobType offlineUserDataJobType =
                OfflineUserDataJobType.StoreSalesUploadFirstParty,
            long? externalId = null, string advertiserUploadDateTime = null,
            string bridgeMapVersionId = null, long? partnerId = null)
        {
            // Get the CampaignService.
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient =
                client.GetService(Services.V3.OfflineUserDataJobService);

            // Ensure that a valid job type is provided.
            if (offlineUserDataJobType != OfflineUserDataJobType.StoreSalesUploadFirstParty &
                offlineUserDataJobType != OfflineUserDataJobType.StoreSalesUploadThirdParty)
            {
                Console.WriteLine("Invalid job type specified, defaulting to First Party.");
                offlineUserDataJobType = OfflineUserDataJobType.StoreSalesUploadFirstParty;
            }

            try
            {
                // Creates an offline user data job for uploading transactions.
                string offlineUserDataJobResourceName =
                    CreateOfflineUserDataJob(offlineUserDataJobServiceClient, customerId,
                        offlineUserDataJobType, externalId, advertiserUploadDateTime,
                        bridgeMapVersionId, partnerId);

                // Adds transactions to the job.
                AddTransactionsToOfflineUserDataJob(offlineUserDataJobServiceClient, customerId,
                    offlineUserDataJobResourceName, conversionActionId);

                // Issues an asynchronous request to run the offline user data job.
                offlineUserDataJobServiceClient.RunOfflineUserDataJobAsync(
                    offlineUserDataJobResourceName);

                Console.WriteLine("Sent request to asynchronously run offline user data job " +
                                  $"{offlineUserDataJobResourceName}.");

                // Offline user data jobs may take up to 24 hours to complete, so instead of waiting
                // for the job to complete, retrieves and displays the job status once and then
                // prints the query to use to check the job again later.
                CheckJobStatus(client, customerId, offlineUserDataJobResourceName);
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
        /// Creates an offline user data job for uploading store sales transactions.
        /// </summary>
        /// <param name="offlineUserDataJobServiceClient">The offline user data job service
        ///     client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="offlineUserDataJobType">The type of user data in the job (first or third
        ///     party). If you have an official store sales partnership with Google, use
        ///     StoreSalesUploadThirdParty. Otherwise, use StoreSalesUploadFirstParty or
        ///     omit this parameter.</param>
        /// <param name="externalId">Optional (but recommended) external ID to identify the offline
        ///     user data job.</param>
        /// <param name="advertiserUploadDateTime">Date and time the advertiser uploaded data to the
        ///     partner. Only required if uploading third party data.</param>
        /// <param name="bridgeMapVersionId">Version of partner IDs to be used for uploads. Only
        ///     required if uploading third party data.</param>
        /// <param name="partnerId">ID of the third party partner. Only required if uploading third
        ///     party data.</param>
        /// <returns>The resource name of the created job.</returns>
        private string CreateOfflineUserDataJob(
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient, long customerId,
            OfflineUserDataJobType offlineUserDataJobType, long? externalId,
            string advertiserUploadDateTime, string bridgeMapVersionId, long? partnerId)
        {
            // TIP: If you are migrating from the AdWords API, please note that Google Ads API uses
            // the term "fraction" instead of "rate". For example, loyaltyRate in the AdWords API is
            // called loyaltyFraction in the Google Ads API.

            // Please refer to https://support.google.com/google-ads/answer/7506124 for additional
            // details.
            StoreSalesMetadata storeSalesMetadata = new StoreSalesMetadata()
            {
                // Sets the fraction of your overall sales that you (or the advertiser, in the third
                // party case) can associate with a customer (email, phone number, address, etc.) in
                // your database or loyalty program.
                // For example, set this to 0.7 if you have 100 transactions over 30 days, and out
                // of those 100 transactions, you can identify 70 by an email address or phone
                // number.
                LoyaltyFraction = 0.7,
                // Sets the fraction of sales you're uploading out of the overall sales that you (or
                // the advertiser, in the third party case) can associate with a customer. In most
                // cases, you will set this to 1.0.
                // Continuing the example above for loyalty fraction, a value of 1.0 here indicates
                // that you are uploading all 70 of the transactions that can be identified by an
                // email address or phone number.
                TransactionUploadFraction = 1.0
            };

            // Creates additional metadata required for uploading third party data.
            if (offlineUserDataJobType == OfflineUserDataJobType.StoreSalesUploadThirdParty)
            {
                StoreSalesThirdPartyMetadata storeSalesThirdPartyMetadata =
                    new StoreSalesThirdPartyMetadata()
                    {
                        // The date/time must be in the format "yyyy-MM-dd hh:mm:ss".
                        AdvertiserUploadDateTime = advertiserUploadDateTime,

                        // Sets the fraction of transactions you received from the advertiser that
                        // have valid formatting and values. This captures any transactions the
                        // advertiser provided to you but which you are unable to upload to Google
                        // due to formatting errors or missing data.
                        // In most cases, you will set this to 1.0.
                        ValidTransactionFraction = 1.0,

                        // Sets the fraction of valid transactions (as defined above) you received
                        // from the advertiser that you (the third party) have matched to an
                        // external user ID on your side.
                        // In most cases, you will set this to 1.0.
                        PartnerMatchFraction = 1.0,

                        // Sets the fraction of transactions you (the third party) are uploading out
                        // of the transactions you received from the advertiser that meet both of
                        // the following criteria:
                        // 1. Are valid in terms of formatting and values. See valid transaction
                        // fraction above.
                        // 2. You matched to an external user ID on your side. See partner match
                        // fraction above.
                        // In most cases, you will set this to 1.0.
                        PartnerUploadFraction = 1.0,

                        // Sets the version of partner IDs to be used for uploads.
                        // Please speak with your Google representative to get the values to use for
                        // the bridge map version and partner IDs.
                        BridgeMapVersionId = bridgeMapVersionId,

                        // Sets the third party partner ID uploading the transactions.
                        PartnerId = partnerId
                    };

                storeSalesMetadata.ThirdPartyMetadata = storeSalesThirdPartyMetadata;
            }

            // Creates a new offline user data job.
            OfflineUserDataJob offlineUserDataJob = new OfflineUserDataJob()
            {
                Type = offlineUserDataJobType,
                StoreSalesMetadata = storeSalesMetadata
            };

            if (externalId.HasValue)
            {
                offlineUserDataJob.ExternalId = externalId.Value;
            }

            // Issues a request to create the offline user data job.
            CreateOfflineUserDataJobResponse createOfflineUserDataJobResponse =
                offlineUserDataJobServiceClient.CreateOfflineUserDataJob(
                    customerId.ToString(), offlineUserDataJob);
            string offlineUserDataJobResourceName = createOfflineUserDataJobResponse.ResourceName;
            Console.WriteLine("Created an offline user data job with resource name: " +
                              $"{offlineUserDataJobResourceName}.");
            return offlineUserDataJobResourceName;
        }

        /// <summary>
        /// Adds operations to a job for a set of sample transactions.
        /// </summary>
        /// <param name="offlineUserDataJobServiceClient">The offline user data job service
        ///     client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="offlineUserDataJobResourceName">The resource name of the job to which to
        ///     add transactions.</param>
        /// <param name="conversionActionId">The ID of a store sales conversion action.</param>
        private void AddTransactionsToOfflineUserDataJob(
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient, long customerId,
            string offlineUserDataJobResourceName, long conversionActionId)
        {
            // Constructions an operation for each transaction.
            List<OfflineUserDataJobOperation> userDataJobOperations =
                BuildOfflineUserDataJobOperations(customerId, conversionActionId);

            // Issues a request with partial failure enabled to add the operations to the offline
            // user data job.
            AddOfflineUserDataJobOperationsResponse response = offlineUserDataJobServiceClient
                .AddOfflineUserDataJobOperations(new AddOfflineUserDataJobOperationsRequest()
                {
                    EnablePartialFailure = true,
                    ResourceName = offlineUserDataJobResourceName,
                    Operations = {userDataJobOperations}
                });

            // Prints the status message if any partial failure error is returned.
            // NOTE: The details of each partial failure error are not printed here, you can refer
            // to the example HandlePartialFailure.cs to learn more.
            if (response.PartialFailureError != null)
            {
                Console.WriteLine($"Encountered {response.PartialFailureError.Details.Count} " +
                    $"partial failure errors while adding {userDataJobOperations.Count} " +
                    "operations to the offline user data job: " +
                    $"'{response.PartialFailureError.Message}'. Only the successfully added " +
                    "operations will be executed when the job runs.");
            }
            else
            {
                Console.WriteLine($"Successfully added {userDataJobOperations.Count} operations " +
                    "to the offline user data job.");
            }
        }

        /// <summary>
        /// Creates a list of offline user data job operations for sample transactions.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="conversionActionId">The ID of a store sales conversion action.</param>
        /// <returns>A list of operations.</returns>
        private List<OfflineUserDataJobOperation> BuildOfflineUserDataJobOperations(long customerId,
            long conversionActionId)
        {
            // Create the first transaction for upload based on an email address and state.
            UserData userDataWithEmailAddress = new UserData()
            {
                UserIdentifiers =
                {
                    new UserIdentifier()
                    {
                        // Email addresses must be normalized and hashed.
                        HashedEmail = NormalizeAndHash("customer@example.com")
                    },
                    new UserIdentifier()
                    {
                        AddressInfo = new OfflineUserAddressInfo()
                        {
                            State = "NY"
                        }
                    },
                },
                TransactionAttribute = new TransactionAttribute()
                {
                    ConversionAction =
                        ResourceNames.ConversionAction(customerId, conversionActionId),
                    CurrencyCode = "USD",
                    // Converts the transaction amount from $200 USD to micros.
                    TransactionAmountMicros = 200L * 1_000_000L,
                    // Specifies the date and time of the transaction. This date and time will be
                    // interpreted by the API using the Google Ads customer's time zone.
                    // The date/time must be in the format "yyyy-MM-dd hh:mm:ss".
                    TransactionDateTime = "2020-05-01 23:52:12"
                }
            };

            // Creates the second transaction for upload based on a physical address.
            UserData userDataWithPhysicalAddress = new UserData()
            {
                UserIdentifiers =
                {
                    new UserIdentifier()
                    {
                        AddressInfo = new OfflineUserAddressInfo()
                        {
                            // Names must be normalized and hashed.
                            HashedFirstName = NormalizeAndHash("John"),
                            HashedLastName = NormalizeAndHash("Doe"),
                            CountryCode = "US",
                            PostalCode = "10011"
                        }
                    }
                },
                TransactionAttribute = new TransactionAttribute()
                {
                    ConversionAction =
                        ResourceNames.ConversionAction(customerId, conversionActionId),
                    CurrencyCode = "EUR",
                    // Converts the transaction amount from 450 EUR to micros.
                    TransactionAmountMicros = 450L * 1_000_000L,
                    // Specifies the date and time of the transaction. This date and time will be
                    // interpreted by the API using the Google Ads customer's time zone.
                    // The date/time must be in the format "yyyy-MM-dd hh:mm:ss".
                    TransactionDateTime = "2020-05-14 19:07:02"
                }
            };

            // Creates the operations to add the two transactions.
            List<OfflineUserDataJobOperation> operations = new List<OfflineUserDataJobOperation>()
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

            return operations;
        }

        /// <summary>
        /// Normalizes and hashes a string value.
        /// </summary>
        /// <param name="value">The value to normalize and hash.</param>
        /// <returns>The normalized and hashed value.</returns>
        private static string NormalizeAndHash(string value)
        {
            return ToSha256String(_digest, ToNormalizedValue(value));
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

        /// <summary>
        /// Retrieves, checks, and prints the status of the offline user data job.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="offlineUserDataJobResourceName">The resource name of the job whose status
        ///     you wish to check.</param>
        private void CheckJobStatus(GoogleAdsClient client, long customerId,
            string offlineUserDataJobResourceName)
        {
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V3.GoogleAdsService);

            string query = $@"SELECT offline_user_data_job.resource_name,
                    offline_user_data_job.id,
                    offline_user_data_job.status,
                    offline_user_data_job.type,
                    offline_user_data_job.failure_reason
                FROM offline_user_data_job
                WHERE offline_user_data_job.resource_name = '{offlineUserDataJobResourceName}'";

            // Issues the query and gets the GoogleAdsRow containing the job from the response.
            GoogleAdsRow googleAdsRow = googleAdsServiceClient.Search(
                customerId.ToString(), query).First();

            OfflineUserDataJob offlineUserDataJob = googleAdsRow.OfflineUserDataJob;

            OfflineUserDataJobStatus jobStatus = offlineUserDataJob.Status;
            Console.WriteLine($"Offline user data job ID {offlineUserDataJob.Id} with type " +
                $"'{offlineUserDataJob.Type}' has status {offlineUserDataJob.Status}.");

            if (jobStatus == OfflineUserDataJobStatus.Failed)
            {
                Console.WriteLine($"\tFailure reason: {offlineUserDataJob.FailureReason}");
            }
            else if (jobStatus == OfflineUserDataJobStatus.Pending |
                     jobStatus == OfflineUserDataJobStatus.Running)
            {
                Console.WriteLine("\nTo check the status of the job periodically, use the" +
                    $"following GAQL query with GoogleAdsService.Search:\n{query}\n");
            }
        }
    }
}

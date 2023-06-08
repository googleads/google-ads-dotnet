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
using CommandLine;
using Google.Ads.Gax.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V14.Common;
using Google.Ads.GoogleAds.V14.Errors;
using Google.Ads.GoogleAds.V14.Resources;
using Google.Ads.GoogleAds.V14.Services;
using static Google.Ads.GoogleAds.V14.Enums.OfflineUserDataJobStatusEnum.Types;
using static Google.Ads.GoogleAds.V14.Enums.OfflineUserDataJobTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V14
{
    /// <summary>
    /// This code example uploads offline data for store sales transactions.
    /// This feature is only available to allowlisted accounts. See
    /// https://support.google.com/google-ads/answer/7620302 for more details.
    /// </summary>
    public class UploadStoreSalesTransactions : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UploadStoreSalesTransactions"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the call is made.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// The ID of a store sales conversion action.
            /// </summary>
            [Option("conversionActionId", Required = true, HelpText =
                "The ID of a store sales conversion action.")]
            public long ConversionActionId { get; set; }

            /// <summary>
            /// The type of user data in the job (first or third party). If you have an official
            /// store sales partnership with Google, use StoreSalesUploadThirdParty. Otherwise,
            /// use StoreSalesUploadFirstParty or omit this parameter.
            /// </summary>
            [Option("offlineUserDataJobType", Required = false, HelpText =
                    "The type of user data in the job (first or third party). If you have an" +
                    " official store sales partnership with Google, use " +
                    "StoreSalesUploadThirdParty. Otherwise, use StoreSalesUploadFirstParty or " +
                    "omit this parameter.",
                Default = OfflineUserDataJobType.StoreSalesUploadFirstParty)]
            public OfflineUserDataJobType OfflineUserDataJobType { get; set; }

            /// <summary>
            /// Optional (but recommended) external ID to identify the offline user data job.
            /// </summary>
            [Option("externalId", Required = false, HelpText =
                    "Optional (but recommended) external ID to identify the offline user data job.",
                Default = null)]
            public long? ExternalId { get; set; }

            /// <summary>
            /// Date and time the advertiser uploaded data to the partner. Only required if
            /// uploading third party data.
            /// </summary>
            [Option("advertiserUploadDateTime", Required = false, HelpText =
                "Date and time the advertiser uploaded data to the partner. Only required if " +
                "uploading third party data.", Default = null)]
            public string AdvertiserUploadDateTime { get; set; }

            /// <summary>
            /// Version of partner IDs to be used for uploads. Only required if uploading third
            /// party data.
            /// </summary>
            [Option("bridgeMapVersionId", Required = false, HelpText =
                "Version of partner IDs to be used for uploads. Only required if uploading " +
                "third party data.", Default = null)]
            public string BridgeMapVersionId { get; set; }

            /// <summary>
            /// ID of the third party partner. Only required if uploading third party data.
            /// </summary>
            [Option("partnerId", Required = false, HelpText =
                    "ID of the third party partner. Only required if uploading third party data.",
                Default = null)]
            public long? PartnerId { get; set; }

            /// <summary>
            /// Optional custom key name. Only required if uploading data with custom key and
            /// values.
            /// </summary>
            [Option("customKey", Required = false, HelpText =
                "Optional custom key name. Only required if uploading data with custom key and" +
                " values.", Default = null)]
            public string CustomKey { get; set; }

            /// <summary>
            /// A unique identifier of a product, either the Merchant Center Item ID or Global Trade
            /// Item Number (GTIN). Only required if uploading with item attributes.
            /// </summary>
            [Option("itemId", Required = false, HelpText =
                    "A unique identifier of a product, either the Merchant Center Item ID or " +
                    "Global Trade Item Number (GTIN). Only required if uploading with item " +
                    "attributes.",
                Default = null)]
            public string ItemId { get; set; }

            /// <summary>
            /// A Merchant Center Account ID. Only required if uploading with item attributes.
            /// </summary>
            [Option("merchantCenterAccountId", Required = false, HelpText =
                    "A Merchant Center Account ID. Only required if uploading with item " +
                    "attributes.",
                Default = null)]
            public long? MerchantCenterAccountId { get; set; }

            /// <summary>
            /// A two-letter country code of the location associated with the feed where your items
            /// are uploaded. Only required if uploading with item attributes.
            /// For a list of country codes see:
            /// https://developers.google.com/google-ads/api/reference/data/codes-formats#expandable-16
            /// </summary>
            [Option("countryCode", Required = false, HelpText =
                    "A two-letter country code of the location associated with the feed where your " +
                    "items are uploaded. Only required if uploading with item attributes.\nFor a " +
                    "list of country codes see: " +
                    "https://developers.google.com/google-ads/api/reference/data/codes-formats#expandable-16",
                Default = null)]
            public string CountryCode { get; set; }

            /// <summary>
            /// A two-letter language code of the language associated with the feed where your items
            /// are uploaded. Only required if uploading with item attributes. For a list of
            /// language codes see:
            /// https://developers.google.com/google-ads/api/reference/data/codes-formats#expandable-7
            /// </summary>
            [Option("languageCode", Required = false, HelpText =
                    "A two-letter language code of the language associated with the feed where " +
                    "your items are uploaded. Only required if uploading with item attributes.\n" +
                    "For a list of language codes see: " +
                    "https://developers.google.com/google-ads/api/reference/data/codes-formats#expandable-7",
                Default = null)]
            public string LanguageCode { get; set; }

            /// <summary>
            /// The number of items sold. Can only be set when at least one other item attribute has
            /// been provided. Only required if uploading with item attributes.
            /// </summary>
            [Option("quantity", Required = false, HelpText =
                    "The number of items sold. Only required if uploading with item attributes.",
                Default = 1)]
            public long Quantity { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            UploadStoreSalesTransactions codeExample = new UploadStoreSalesTransactions();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.ConversionActionId,
                options.OfflineUserDataJobType, options.ExternalId,
                options.AdvertiserUploadDateTime, options.BridgeMapVersionId, options.PartnerId,
                options.CustomKey, options.ItemId, options.MerchantCenterAccountId,
                options.CountryCode,
                options.LanguageCode, options.Quantity);
        }

        // Gets a digest for generating hashed values using SHA-256. You must normalize and hash the
        // the value for any field where the name begins with "hashed". See the normalizeAndHash()
        // method.
        private static readonly SHA256 _digest = SHA256.Create();

        // If uploading data with custom key and values, specify the value:
        private const string CUSTOM_VALUE = "INSERT_CUSTOM_VALUE_HERE";

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example uploads offline data for store sales transactions. This feature " +
            "is only available to allowlisted accounts. See " +
            "https://support.google.com/google-ads/answer/7620302 for more details.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="conversionActionId">The ID of a store sales conversion action.</param>
        /// <param name="offlineUserDataJobType">The type of user data in the job (first or third
        /// party). If you have an official store sales partnership with Google, use
        /// StoreSalesUploadThirdParty. Otherwise, use StoreSalesUploadFirstParty or
        /// omit this parameter.</param>
        /// <param name="externalId">Optional (but recommended) external ID to identify the offline
        /// user data job.</param>
        /// <param name="advertiserUploadDateTime">Date and time the advertiser uploaded data to the
        /// partner. Only required if uploading third party data.</param>
        /// <param name="bridgeMapVersionId">Version of partner IDs to be used for uploads. Only
        /// required if uploading third party data.</param>
        /// <param name="partnerId">ID of the third party partner. Only required if uploading third
        /// party data.</param>
        /// <param name="customKey">Optional custom key name. Only required if uploading data
        /// with custom key and values.</param>
        /// <param name="itemId">A unique identifier of a product, either the Merchant Center Item
        /// ID or Global Trade Item Number (GTIN). Only required if uploading with item
        /// attributes.</param>
        /// <param name="merchantCenterAccountId">A Merchant Center Account ID. Only required if uploading with
        /// item attributes.</param>
        /// <param name="countryCode">A two-letter country code of the location associated with the
        /// feed where your items are uploaded. Only required if uploading with item
        /// attributes.</param>
        /// <param name="languageCode">A two-letter language code of the language associated with
        /// the feed where your items are uploaded. Only required if uploading with item
        /// attributes.</param>
        /// <param name="quantity">The number of items sold. Only required if uploading with item
        /// attributes.</param>
        public void Run(GoogleAdsClient client, long customerId, long conversionActionId,
            OfflineUserDataJobType offlineUserDataJobType, long? externalId,
            string advertiserUploadDateTime, string bridgeMapVersionId, long? partnerId,
            string customKey, string itemId, long? merchantCenterAccountId, string countryCode,
            string languageCode, long quantity)
        {
            // Get the OfflineUserDataJobServiceClient.
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient =
                client.GetService(Services.V14.OfflineUserDataJobService);

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
                        bridgeMapVersionId, partnerId, customKey);

                // Adds transactions to the job.
                AddTransactionsToOfflineUserDataJob(offlineUserDataJobServiceClient, customerId,
                    offlineUserDataJobResourceName, conversionActionId, customKey, itemId,
                    merchantCenterAccountId, countryCode, languageCode, quantity);

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
        /// client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="offlineUserDataJobType">The type of user data in the job (first or third
        /// party). If you have an official store sales partnership with Google, use
        /// StoreSalesUploadThirdParty. Otherwise, use StoreSalesUploadFirstParty or
        /// omit this parameter.</param>
        /// <param name="externalId">Optional (but recommended) external ID to identify the offline
        /// user data job.</param>
        /// <param name="advertiserUploadDateTime">Date and time the advertiser uploaded data to the
        /// partner. Only required if uploading third party data.</param>
        /// <param name="bridgeMapVersionId">Version of partner IDs to be used for uploads. Only
        /// required if uploading third party data.</param>
        /// <param name="partnerId">ID of the third party partner. Only required if uploading third
        /// party data.</param>
        /// <param name="customKey">The custom key, or null if not uploading data with custom key
        /// and value.</param>
        /// <returns>The resource name of the created job.</returns>
        private string CreateOfflineUserDataJob(
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient, long customerId,
            OfflineUserDataJobType offlineUserDataJobType, long? externalId,
            string advertiserUploadDateTime, string bridgeMapVersionId, long? partnerId,
            string customKey)
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

            // Apply the custom key if provided.
            if (!string.IsNullOrEmpty(customKey))
            {
                storeSalesMetadata.CustomKey = customKey;
            }

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
                    };

                // Sets the third party partner ID uploading the transactions.
                if (partnerId.HasValue)
                {
                    storeSalesThirdPartyMetadata.PartnerId = partnerId.Value;
                }

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
        /// client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="offlineUserDataJobResourceName">The resource name of the job to which to
        /// add transactions.</param>
        /// <param name="conversionActionId">The ID of a store sales conversion action.</param>
        /// <param name="customKey">The custom key, or null if not uploading data with custom key
        /// and value.</param>
        /// <param name="itemId">A unique identifier of a product, or null if not uploading with
        /// item attributes.</param>
        /// <param name="merchantCenterAccountId">A Merchant Center Account ID, or null if not
        /// uploading with item attributes.</param>
        /// <param name="countryCode">A two-letter country code, or null if not uploading with
        /// item attributes.</param>
        /// <param name="languageCode">A two-letter language code, or null if not uploading with
        /// item attributes.</param>
        /// <param name="quantity">The number of items sold, or null if not uploading with
        /// item attributes.</param>
        private void AddTransactionsToOfflineUserDataJob(
            OfflineUserDataJobServiceClient offlineUserDataJobServiceClient, long customerId,
            string offlineUserDataJobResourceName, long conversionActionId, string customKey,
            string itemId, long? merchantCenterAccountId, string countryCode, string languageCode,
            long quantity)
        {
            // Constructions an operation for each transaction.
            List<OfflineUserDataJobOperation> userDataJobOperations =
                BuildOfflineUserDataJobOperations(customerId, conversionActionId, customKey, itemId,
                    merchantCenterAccountId, countryCode, languageCode, quantity);

            // [START enable_warnings_1]
            // Constructs a request with partial failure enabled to add the operations to the
            // offline user data job, and enable_warnings set to true to retrieve warnings.
            AddOfflineUserDataJobOperationsRequest request =
                new AddOfflineUserDataJobOperationsRequest()
            {
                EnablePartialFailure = true,
                ResourceName = offlineUserDataJobResourceName,
                Operations = { userDataJobOperations },
                EnableWarnings = true,
            };

            AddOfflineUserDataJobOperationsResponse response = offlineUserDataJobServiceClient
                .AddOfflineUserDataJobOperations(request);
            // [END enable_warnings_1]

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

            // [START enable_warnings_2]
            // Prints the number of warnings if any warnings are returned. You can access
            // details of each warning using the same approach you'd use for partial failure
            // errors.
            if (request.EnableWarnings && response.Warnings != null)
            {
                // Extracts the warnings from the response.
                GoogleAdsFailure warnings = response.Warnings;
                Console.WriteLine($"{warnings.Errors.Count} warning(s) occurred");
            }
            // [END enable_warnings_2]
        }

        /// <summary>
        /// Creates a list of offline user data job operations for sample transactions.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="conversionActionId">The ID of a store sales conversion action.</param>
        /// <param name="customKey">The custom key, or null if not uploading data with custom key
        /// and value.</param>
        /// <param name="itemId">A unique identifier of a product, or null if not uploading with
        /// item attributes.</param>
        /// <param name="merchantCenterAccountId">A Merchant Center Account ID, or null if not
        /// uploading with item attributes.</param>
        /// <param name="countryCode">A two-letter country code, or null if not uploading with
        /// item attributes.</param>
        /// <param name="languageCode">A two-letter language code, or null if not uploading with
        /// item attributes.</param>
        /// <param name="quantity">The number of items sold, or null if not uploading with
        /// item attributes.</param>
        /// <returns>A list of operations.</returns>
        private List<OfflineUserDataJobOperation> BuildOfflineUserDataJobOperations(long customerId,
            long conversionActionId, string customKey, string itemId, long? merchantCenterAccountId,
            string countryCode, string languageCode, long quantity)
        {
            // Create the first transaction for upload based on an email address and state.
            UserData userDataWithEmailAddress = new UserData()
            {
                UserIdentifiers =
                {
                    new UserIdentifier()
                    {
                        // Email addresses must be normalized and hashed.
                        HashedEmail = NormalizeAndHash("dana@example.com")
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
                    // If item attributes are provided, this value represents the total value of the
                    // items after multiplying the unit price per item by the quantity provided in
                    // the ItemAttribute.
                    TransactionAmountMicros = 200L * 1_000_000L,
                    // Specifies the date and time of the transaction. The format is
                    // "YYYY-MM-DD HH:MM:SS[+HH:MM]", where [+HH:MM] is an optional
                    // timezone offset from UTC. If the offset is absent, the API will
                    // use the account's timezone as default. Examples: "2018-03-05 09:15:00"
                    // or "2018-02-01 14:34:30+03:00".
                    TransactionDateTime =
                        DateTime.Today.AddDays(-2).ToString("yyyy-MM-dd HH:mm:ss")
                }
            };

            // Set the custom value if a custom key was provided.
            if (!string.IsNullOrEmpty(customKey))
            {
                userDataWithEmailAddress.TransactionAttribute.CustomValue = CUSTOM_VALUE;
            }

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
                            HashedFirstName = NormalizeAndHash("Alex"),
                            HashedLastName = NormalizeAndHash("Quinn"),
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
                    // e.g. "2020-05-14 19:07:02".
                    TransactionDateTime = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd HH:mm:ss")
                }
            };

            // Set the item attribute if provided.
            if (!string.IsNullOrEmpty(itemId))
            {
                userDataWithPhysicalAddress.TransactionAttribute.ItemAttribute = new ItemAttribute
                {
                    ItemId = itemId,
                    MerchantId = merchantCenterAccountId.Value,
                    CountryCode = countryCode,
                    LanguageCode = languageCode,
                    // Quantity field should only be set when at least one of the other item
                    // attributes is present.
                    Quantity = quantity
                };
            }

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
        /// you wish to check.</param>
        private void CheckJobStatus(GoogleAdsClient client, long customerId,
            string offlineUserDataJobResourceName)
        {
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V14.GoogleAdsService);

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

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
using Google.Ads.GoogleAds.V7.Common;
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Resources;
using Google.Ads.GoogleAds.V7.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V7.Enums.ExtensionTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// This example adds a hotel callout extension to a specific account, campaign within the
    /// account, and ad group within the campaign.
    /// </summary>
    public class AddHotelCallout : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddHotelCallout"/> example.
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
            /// ID of the campaign to which the hotel callout extension will be added.
            /// </summary>
            [Option("campaignId", Required = true, HelpText =
                "ID of the campaign to which the hotel callout extension will be added.")]
            public long CampaignId { get; set; }

            /// <summary>
            /// ID of the ad group to which the hotel callout extension will be added.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "ID of the ad group to which the hotel callout extension will be added.")]
            public long AdGroupId { get; set; }

            /// <summary>
            /// Callout text for the extension.
            /// </summary>
            [Option("calloutText", Required = true, HelpText =
                "Callout text for the extension.")]
            public string CalloutText { get; set; }

            /// <summary>
            /// The language code for the text. See supported languages at:
            /// https://developers.google.com/hotels/hotel-ads/api-reference/language-codes.
            /// </summary>
            [Option("languageCode", Required = true, HelpText =
                "The language code for the text. See supported languages at: " +
                "https://developers.google.com/hotels/hotel-ads/api-reference/language-codes.")]
            public string LanguageCode { get; set; }
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
                    // The customer ID for which the call is made.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // ID of the campaign to which the hotel callout extension will be added.
                    options.CampaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

                    // ID of the ad group to which the hotel callout extension will be added.
                    options.AdGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

                    // Callout text for the extension.
                    options.CalloutText = "INSERT_CALLOUT_TEXT_HERE";

                    // The language code for the text. See supported languages at:
                    // https://developers.google.com/hotels/hotel-ads/api-reference/language-codes.
                    options.LanguageCode = "INSERT_LANGUAGE_CODE_HERE";

                    return 0;
                });

            AddHotelCallout codeExample = new AddHotelCallout();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.CampaignId,
                options.AdGroupId, options.CalloutText, options.LanguageCode);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example adds a hotel callout extension to a specific account, campaign within " +
            "the account, and ad group within the campaign.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to which the hotel callout extension will be
        /// added.</param>
        /// <param name="adGroupId">ID of the ad group to which the hotel callout extension will be
        /// added.</param>
        /// <param name="calloutText">Callout text for the extension.</param>
        /// <param name="languageCode">The language code for the text. See supported languages at:
        /// https://developers.google.com/hotels/hotel-ads/api-reference/language-codes.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId, long adGroupId,
            string calloutText, string languageCode)
        {
            try
            {
                // Creates an extension feed item as hotel callout.
                string extensionFeedItemResourceName = AddExtensionFeedItem(client, customerId,
                    calloutText, languageCode);

                // Adds the extension feed item to the account.
                AddExtensionToAccount(client, customerId, extensionFeedItemResourceName);

                // Adds the extension feed item to the campaign.
                AddExtensionToCampaign(client, customerId, campaignId,
                    extensionFeedItemResourceName);

                // Adds the extension feed item to the ad group.
                AddExtensionToAdGroup(client, customerId, adGroupId, extensionFeedItemResourceName);
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
        /// Creates a new extension feed item for the callout extension.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="calloutText">Callout text for the extension.</param>
        /// <param name="languageCode">The language code for the text.</param>
        /// <returns>The created extension feed item's resource name.</returns>
        private string AddExtensionFeedItem(GoogleAdsClient client, in long customerId,
            string calloutText, string languageCode)
        {
            // Gets the ExtensionFeedItemService client.
            ExtensionFeedItemServiceClient extensionFeedItemService =
                client.GetService(Services.V7.ExtensionFeedItemService);

            // Creates the callout extension with the specified text and language.
            HotelCalloutFeedItem hotelCalloutFeedItem = new HotelCalloutFeedItem
            {
                Text = calloutText,
                LanguageCode = languageCode
            };

            // Creates a feed item from the hotel callout extension.
            ExtensionFeedItem extensionFeedItem = new ExtensionFeedItem
            {
                HotelCalloutFeedItem = hotelCalloutFeedItem
            };

            // Creates an extension feed item operation.
            ExtensionFeedItemOperation extensionFeedItemOperation = new ExtensionFeedItemOperation
            {
                Create = extensionFeedItem
            };

            // Issues a mutate request to add the extension feed item and print its information.
            MutateExtensionFeedItemsResponse response =
                extensionFeedItemService.MutateExtensionFeedItems(customerId.ToString(),
                    new[] { extensionFeedItemOperation });
            string extensionFeedItemResourceName = response.Results.First().ResourceName;
            Console.WriteLine("Created an extension feed item with resource name " +
                $"'{extensionFeedItemResourceName}'.");

            return extensionFeedItemResourceName;
        }

        /// <summary>
        /// Adds the extension feed item to the customer account.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="extensionFeedItemResourceName">The extension feed item's resource
        /// name.</param>
        private void AddExtensionToAccount(GoogleAdsClient client, in long customerId,
            string extensionFeedItemResourceName)
        {
            // Gets the CustomerExtensionSettingService client.
            CustomerExtensionSettingServiceClient customerExtensionSettingService =
                client.GetService(Services.V7.CustomerExtensionSettingService);

            // Creates a customer extension setting, sets its type to HOTEL_CALLOUT, and attaches
            // the feed item.
            CustomerExtensionSetting customerExtensionSetting = new CustomerExtensionSetting
            {
                ExtensionType = ExtensionType.HotelCallout,
            };
            customerExtensionSetting.ExtensionFeedItems.Add(extensionFeedItemResourceName);

            // Creates a customer extension setting operation.
            CustomerExtensionSettingOperation customerExtensionSettingOperation =
                new CustomerExtensionSettingOperation
                {
                    Create = customerExtensionSetting
                };

            // Issues a mutate request to add the customer extension setting and prints its
            // information.
            MutateCustomerExtensionSettingsResponse response =
                customerExtensionSettingService.MutateCustomerExtensionSettings(
                    customerId.ToString(), new[] { customerExtensionSettingOperation });
            Console.WriteLine("Created a customer extension setting with resource name " +
                $"'{response.Results.First().ResourceName}'");
        }

        /// <summary>
        /// Adds the extension feed item to the specified campaign.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="campaignId">The campaign ID to which to add the extension.</param>
        /// <param name="extensionFeedItemResourceName">The extension feed item's resource
        /// name.</param>
        private void AddExtensionToCampaign(GoogleAdsClient client, in long customerId,
            in long campaignId, string extensionFeedItemResourceName)
        {
            // Gets the CampaignExtensionSettingService client.
            CampaignExtensionSettingServiceClient campaignExtensionSettingService =
                client.GetService(Services.V7.CampaignExtensionSettingService);

            // Creates a campaign extension setting, sets its type to HOTEL_CALLOUT, and attaches
            // the feed item.
            CampaignExtensionSetting campaignExtensionSetting = new CampaignExtensionSetting
            {
                Campaign = ResourceNames.Campaign(customerId, campaignId),
                ExtensionType = ExtensionType.HotelCallout
            };
            campaignExtensionSetting.ExtensionFeedItems.Add(extensionFeedItemResourceName);

            // Creates a campaign extension setting operation.
            CampaignExtensionSettingOperation campaignExtensionSettingOperation =
                new CampaignExtensionSettingOperation
                {
                    Create = campaignExtensionSetting
                };

            // Issues a mutate request to add the campaign extension setting and prints its
            // information.
            MutateCampaignExtensionSettingsResponse response =
                campaignExtensionSettingService.MutateCampaignExtensionSettings(
                    customerId.ToString(), new[] { campaignExtensionSettingOperation });
            Console.WriteLine("Created a campaign extension setting with resource name " +
                $"'{response.Results.First().ResourceName}'");
        }

        /// <summary>
        /// Adds the extension feed item to the specified ad group.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="adGroupId">The ad group ID to which to add the extension.</param>
        /// <param name="extensionFeedItemResourceName">The extension feed item's resource
        /// name.</param>
        private void AddExtensionToAdGroup(GoogleAdsClient client, in long customerId,
            in long adGroupId, string extensionFeedItemResourceName)
        {
            // Gets the AdGroupExtensionSettingService client.
            AdGroupExtensionSettingServiceClient adGroupExtensionSettingService =
                client.GetService(Services.V7.AdGroupExtensionSettingService);

            // Creates an ad group extension setting, sets its type to HOTEL_CALLOUT, and attaches
            // the feed item.
            AdGroupExtensionSetting adGroupExtensionSetting = new AdGroupExtensionSetting
            {
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                ExtensionType = ExtensionType.HotelCallout
            };
            adGroupExtensionSetting.ExtensionFeedItems.Add(extensionFeedItemResourceName);

            // Creates an ad group extension setting operation.
            AdGroupExtensionSettingOperation adGroupExtensionSettingOperation =
                new AdGroupExtensionSettingOperation
                {
                    Create = adGroupExtensionSetting
                };

            // Issues a mutate request to add the ad group extension setting and prints its
            // information.
            MutateAdGroupExtensionSettingsResponse response =
                adGroupExtensionSettingService.MutateAdGroupExtensionSettings(
                    customerId.ToString(), new[] { adGroupExtensionSettingOperation });
            Console.WriteLine("Created an ad group extension setting with resource name " +
                $"'{response.Results.First().ResourceName}'");
        }
    }
}

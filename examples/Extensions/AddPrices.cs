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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V3.Common;
using Google.Ads.GoogleAds.V3.Enums;
using Google.Ads.GoogleAds.V3.Errors;
using Google.Ads.GoogleAds.V3.Resources;
using Google.Ads.GoogleAds.V3.Services;

using System;

using static Google.Ads.GoogleAds.V3.Enums.ExtensionTypeEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.MinuteOfHourEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.PriceExtensionPriceQualifierEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.PriceExtensionPriceUnitEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.PriceExtensionTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V3
{
    /// <summary>
    /// This code example adds a price extension and associates it with an account. Campaign
    /// targeting is also set using the specified campaign ID. To get campaigns, run
    /// GetCampaigns.cs.
    /// </summary>
    public class AddPrices : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddPrices codeExample = new AddPrices();
            Console.WriteLine(codeExample.Description);

            // The customer ID for which the call is made.
            int customerId = int.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the campaign to which price extensions are added.
            long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, campaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example adds a price extension and associates it with an " +
                    "account. Campaign targeting is also set using the specified campaign ID. " +
                    "To get campaigns, run GetCampaigns.cs.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to targeting are added.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            // Get the CustomerExtensionSettingServiceClient.
            CustomerExtensionSettingServiceClient customerExtensionSettingService =
                client.GetService(Services.V3.CustomerExtensionSettingService);

            try
            {
                // Creates an extension feed item as price.
                string extensionFeedItemResourceName =
                    CreateExtensionFeedItem(client, customerId, campaignId);

                // Creates a customer extension setting using the previously created extension
                // feed item. This associates the price extension to your account.
                CustomerExtensionSetting customerExtensionSetting =
                    new CustomerExtensionSetting()
                    {
                        ExtensionType = ExtensionType.Price,
                        ExtensionFeedItems = { extensionFeedItemResourceName }
                    };

                // Creates an operation to add the extension setting.
                CustomerExtensionSettingOperation operation =
                    new CustomerExtensionSettingOperation()
                    {
                        Create = customerExtensionSetting
                    };

                // Issues a mutate request to add the customer extension setting
                // and prints its information.
                MutateCustomerExtensionSettingsResponse response =
                    customerExtensionSettingService.MutateCustomerExtensionSettings(
                        customerId.ToString(), new[] { operation });

                foreach (MutateCustomerExtensionSettingResult result in response.Results)
                {
                    Console.WriteLine("Created customer extension setting with resource name: " +
                        result.ResourceName);
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
            }
        }

        /// <summary>
        /// Creates an extension feed item for price extension.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to target.</param>
        /// <returns>the resource name of the newly created extension feed item.</returns>
        private string CreateExtensionFeedItem(GoogleAdsClient client, long customerId,
            long campaignId)
        {
            // Get the ExtensionFeedItemServiceClient.
            ExtensionFeedItemServiceClient extensionFeedItemService =
                client.GetService(Services.V3.ExtensionFeedItemService);

            // Creates the price extension feed item.
            PriceFeedItem priceFeedItem = new PriceFeedItem()
            {
                Type = PriceExtensionType.Services,
                // Optional: sets a qualifier text to show with the price extension.
                PriceQualifier = PriceExtensionPriceQualifier.From,
                TrackingUrlTemplate = "http://tracker.example.com/?u={lpurl}",
                LanguageCode = "en",
                // To create a price extension, at least three price offerings are needed.
                PriceOfferings =
                {
                    CreatePriceOffer(
                        "Scrubs",
                        "Body Scrub, Salt Scrub",
                        60000000, // 60 USD
                        "USD",
                        PriceExtensionPriceUnit.PerHour,
                        "http://www.example.com/scrubs",
                        "http://m.example.com/scrubs"),
                    CreatePriceOffer(
                        "Hair Cuts",
                        "Once a month",
                        75000000, // 75 USD
                        "USD",
                        PriceExtensionPriceUnit.PerMonth,
                        "http://www.example.com/haircuts",
                        "http://m.example.com/haircuts"),
                    CreatePriceOffer(
                        "Skin Care Package",
                        "Four times a month",
                        250000000, // 250 USD
                        "USD",
                        PriceExtensionPriceUnit.PerMonth,
                        "http://www.example.com/skincarepackage",
                        null)
                }
            };

            // Creates an extension feed item from the price feed item.
            ExtensionFeedItem extensionFeedItem = new ExtensionFeedItem()
            {
                ExtensionType = ExtensionType.Price,
                PriceFeedItem = priceFeedItem,
                TargetedCampaign = ResourceNames.Campaign(customerId, campaignId),
                AdSchedules =
                {
                    CreateAdScheduleInfo(DayOfWeekEnum.Types.DayOfWeek.Sunday, 10,
                        MinuteOfHour.Zero, 18, MinuteOfHour.Zero),
                    CreateAdScheduleInfo(DayOfWeekEnum.Types.DayOfWeek.Saturday, 10,
                        MinuteOfHour.Zero, 22, MinuteOfHour.Zero)
                }
            };

            // Creates an operation to add the feed item.
            ExtensionFeedItemOperation operation = new ExtensionFeedItemOperation()
            {
                Create = extensionFeedItem
            };

            // Issues a mutate request to add the extension feed item and prints its information.
            MutateExtensionFeedItemsResponse response =
                extensionFeedItemService.MutateExtensionFeedItems(customerId.ToString(),
                    new[] { operation });
            string resourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Created extension feed item with resource name: {resourceName}.");
            return resourceName;
        }

        /// <summary>
        /// Creates a new price offer with the specified parameters.
        /// </summary>
        /// <param name="header">The headline for the price extension.</param>
        /// <param name="description">The detailed description line that may show on the price
        /// extension.</param>
        /// <param name="priceInMicros">The price to display, measured in micros
        /// (e.g. 1_000_000 micros = 1 USD).</param>
        /// <param name="currencyCode">The currency code representing the unit of currency.</param>
        /// <param name="unit">Optionally set a unit describing the quantity obtained for the
        /// price.</param>
        /// <param name="finalUrl">The final URL to which a click on the price extension drives
        /// traffic.</param>
        /// <param name="finalMobileUrl">The final URL to which mobile clicks on the price
        /// extension drives traffic.</param>
        /// <returns></returns>
        private PriceOffer CreatePriceOffer(string header, string description, int priceInMicros,
            string currencyCode, PriceExtensionPriceUnit unit, string finalUrl,
            string finalMobileUrl)
        {
            PriceOffer priceOffer = new PriceOffer()
            {
                Header = header,
                Description = description,
                FinalUrls = { finalUrl },
                Price = new Money()
                {
                    AmountMicros = priceInMicros,
                    CurrencyCode = currencyCode
                },
                Unit = unit
            };

            // Optional: Sets the final mobile URLs.
            if (!string.IsNullOrEmpty(finalMobileUrl))
            {
                priceOffer.FinalMobileUrls.Add(finalMobileUrl);
            }
            return priceOffer;
        }

        /// <summary>
        /// Creates a new AdScheduleInfo with the specified attributes.
        /// </summary>
        /// <param name="day">Day of the week of the AdScheduleInfo.</param>
        /// <param name="startHour">The starting hour of the AdScheduleInfo.</param>
        /// <param name="startMinute">The starting minute of the AdScheduleInfo.</param>
        /// <param name="endHour">The ending hour of the AdScheduleInfo.</param>
        /// <param name="endMinute">The ending minute of the AdScheduleInfo.</param>
        /// <returns>The ad schedule info.</returns>
        private static AdScheduleInfo CreateAdScheduleInfo(DayOfWeekEnum.Types.DayOfWeek day,
            int startHour, MinuteOfHour startMinute, int endHour, MinuteOfHour endMinute)
        {
            return new AdScheduleInfo()
            {
                DayOfWeek = day,
                StartHour = startHour,
                StartMinute = startMinute,
                EndHour = endHour,
                EndMinute = endMinute
            };
        }
    }
}

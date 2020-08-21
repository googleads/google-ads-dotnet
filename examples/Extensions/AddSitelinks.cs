﻿// Copyright 2020 Google LLC
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
using Google.Ads.GoogleAds.V4.Common;
using Google.Ads.GoogleAds.V4.Enums;
using Google.Ads.GoogleAds.V4.Errors;
using Google.Ads.GoogleAds.V4.Resources;
using Google.Ads.GoogleAds.V4.Services;

using System;
using System.Collections.Generic;

using static Google.Ads.GoogleAds.V4.Enums.ExtensionTypeEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.FeedItemTargetDeviceEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.KeywordMatchTypeEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.MinuteOfHourEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V4
{
    /// <summary>
    /// This code example adds sitelinks to a campaign. To create a campaign, run AddCampaigns.cs.
    /// </summary>
    public class AddSitelinks : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddSitelinks codeExample = new AddSitelinks();
            Console.WriteLine(codeExample.Description);

            // The customer ID for which the call is made.
            int customerId = int.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the campaign to which sitelinks are added.
            long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, campaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds sitelinks to a campaign. To create a campaign, run " +
            "AddCampaigns.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to which sitelinks are added.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            // Get the CampaignExtensionSettingServiceClient.
            CampaignExtensionSettingServiceClient campaignExtensionSettingService =
                client.GetService(Services.V4.CampaignExtensionSettingService);

            string campaignResourceName = ResourceNames.Campaign(customerId, campaignId);

            List<string> extensionFeedItems =
                CreateExtensionFeedItems(client, customerId, campaignResourceName);

            // Creates a CampaignExtensionSetting.
            CampaignExtensionSetting campaignExtensionSetting = new CampaignExtensionSetting()
            {
                Campaign = campaignResourceName,
                ExtensionType = ExtensionType.Sitelink,
                ExtensionFeedItems = { extensionFeedItems }
            };

            // Creates the operation.
            CampaignExtensionSettingOperation operation = new CampaignExtensionSettingOperation()
            {
                Create = campaignExtensionSetting
            };

            try
            {
                MutateCampaignExtensionSettingsResponse response =
                    campaignExtensionSettingService.MutateCampaignExtensionSettings(
                        customerId.ToString(), new[] { operation });
                foreach (MutateCampaignExtensionSettingResult result in response.Results)
                {
                    Console.WriteLine($"Created CampaignExtensionSetting with resource" +
                        $" name '{result.ResourceName}'.");
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
        /// Creates a list of ExtensionFeedItems.
        /// </summary>
        ///<param name="client">The Google Ads API client.</param>
        ///<param name="customerId">The client customer ID.</param>
        ///<param name="campaignResourceName">The resource name of the campaign to target.</param>
        private static List<string> CreateExtensionFeedItems(GoogleAdsClient client,
            long customerId, string campaignResourceName)
        {
            // Get the ExtensionFeedItemServiceClient.
            ExtensionFeedItemServiceClient extensionFeedItemService =
                client.GetService(Services.V4.ExtensionFeedItemService);

            SitelinkFeedItem sitelinkFeedItem1 = CreateSitelinkFeedItem(
                "Store Hours", "http://www.example.com/storehours");

            // Creates an ExtensionFeedItem from the SitelinkFeedItem.
            ExtensionFeedItem extensionFeedItem1 = new ExtensionFeedItem()
            {
                ExtensionType = ExtensionType.Sitelink,
                SitelinkFeedItem = sitelinkFeedItem1,
                TargetedCampaign = campaignResourceName
            };

            List<ExtensionFeedItemOperation> operations = new List<ExtensionFeedItemOperation>();

            // Creates an ExtensionFeedItemOperation and adds it to the operations List.
            operations.Add(new ExtensionFeedItemOperation() { Create = extensionFeedItem1 });

            SitelinkFeedItem sitelinkFeedItem2 = CreateSitelinkFeedItem(
                "Thanksgiving Specials", "http://www.example.com/thanksgiving");

            DateTime startTime = new DateTime(DateTime.Now.Year, 11, 20, 0, 0, 0);
            if (startTime < DateTime.Now)
            {
                // Move the startTime to next year if the current date is past November 20th.
                startTime = startTime.AddYears(1);
            }

            // Converts to a string in the required format.
            string startTimeString = startTime.ToString("yyyy-MM-dd hh:mm:ss");

            // Use the same year as startTime when creating endTime.
            DateTime endTime = new DateTime(startTime.Year, 11, 27, 23, 59, 59);

            string unitedStates = ResourceNames.GeoTargetConstant(2840);

            ExtensionFeedItem extensionFeedItem2 = new ExtensionFeedItem()
            {
                ExtensionType = ExtensionType.Sitelink,
                SitelinkFeedItem = sitelinkFeedItem2,
                TargetedCampaign = campaignResourceName,

                // StartDateTime should be formatted in "yyyy-MM-dd hh:mm:ss" format.
                StartDateTime = startTime.ToString("yyyy-MM-dd hh:mm:ss"),

                // EndDateTime should be formatted in "yyyy-MM-dd hh:mm:ss" format.
                EndDateTime = endTime.ToString("yyyy-MM-dd hh:mm:ss"),

                // Targets this sitelink for United States only.
                // A list of country codes can be referenced here:
                // https://developers.google.com/adwords/api/docs/appendix/geotargeting
                TargetedGeoTargetConstant = ResourceNames.GeoTargetConstant(2840)
            };

            operations.Add(new ExtensionFeedItemOperation() { Create = extensionFeedItem2 });

            SitelinkFeedItem sitelinkFeedItem3 = CreateSitelinkFeedItem(
                "Wifi available", "http://www.example.com/mobile/wifi");

            ExtensionFeedItem extensionFeedItem3 = new ExtensionFeedItem()
            {
                ExtensionType = ExtensionType.Sitelink,
                SitelinkFeedItem = sitelinkFeedItem3,
                TargetedCampaign = campaignResourceName,
                Device = FeedItemTargetDevice.Mobile,
                TargetedKeyword = new KeywordInfo()
                {
                    Text = "free wifi",
                    MatchType = KeywordMatchType.Broad
                }
            };

            operations.Add(new ExtensionFeedItemOperation() { Create = extensionFeedItem3 });

            SitelinkFeedItem sitelinkFeedItem4 = CreateSitelinkFeedItem(
                "Happy hours", "http://www.example.com/happyhours");

            ExtensionFeedItem extensionFeedItem4 = new ExtensionFeedItem()
            {
                ExtensionType = ExtensionType.Sitelink,
                SitelinkFeedItem = sitelinkFeedItem4,
                TargetedCampaign = campaignResourceName,
                AdSchedules = {
                    CreateAdScheduleInfo(DayOfWeekEnum.Types.DayOfWeek.Monday, 18,
                        MinuteOfHour.Zero, 21, MinuteOfHour.Zero),
                    CreateAdScheduleInfo(DayOfWeekEnum.Types.DayOfWeek.Tuesday, 18,
                        MinuteOfHour.Zero, 21, MinuteOfHour.Zero),
                    CreateAdScheduleInfo(DayOfWeekEnum.Types.DayOfWeek.Wednesday, 18,
                        MinuteOfHour.Zero, 21, MinuteOfHour.Zero),
                    CreateAdScheduleInfo(DayOfWeekEnum.Types.DayOfWeek.Thursday, 18,
                        MinuteOfHour.Zero, 21, MinuteOfHour.Zero),
                    CreateAdScheduleInfo(DayOfWeekEnum.Types.DayOfWeek.Friday, 18,
                        MinuteOfHour.Zero, 21, MinuteOfHour.Zero),
                }
            };

            operations.Add(new ExtensionFeedItemOperation() { Create = extensionFeedItem4 });

            // Adds the ExtensionFeedItem.
            MutateExtensionFeedItemsResponse response =
                extensionFeedItemService.MutateExtensionFeedItems(customerId.ToString(),
                    operations);
            Console.WriteLine($"Added {response.Results.Count}:");

            List<string> resourceNames = new List<string>();
            foreach (MutateExtensionFeedItemResult result in response.Results)
            {
                Console.WriteLine($"Created ExtensionFeedItems with " +
                    $"resource name '{result.ResourceName}'.");
                resourceNames.Add(result.ResourceName);
            }
            return resourceNames;
        }


        /// <summary>
        /// Creates a new SitelinkFeedItem with the specified attributes.
        /// </summary>
        /// <param name="sitelinkText">The text of the sitelink feed item.</param>
        /// <param name="sitelinkUrl">The URL of the sitelink feed item.</param>
        /// <returns>The sitelink feed item.</returns>
        private static SitelinkFeedItem CreateSitelinkFeedItem(string sitelinkText,
        string sitelinkUrl)
        {
            return new SitelinkFeedItem()
            {
                LinkText = sitelinkText,
                FinalUrls = { sitelinkUrl }
            };
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

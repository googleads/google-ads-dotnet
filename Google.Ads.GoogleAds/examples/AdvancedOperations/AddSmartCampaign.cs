// Copyright 2021 Google LLC
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
using CommandLine;
using Google.Ads.Gax.Examples;
using Google.Ads.Gax.Util;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V21.Common;
using Google.Ads.GoogleAds.V21.Enums;
using Google.Ads.GoogleAds.V21.Errors;
using Google.Ads.GoogleAds.V21.Resources;
using Google.Ads.GoogleAds.V21.Services;
using static Google.Ads.GoogleAds.V21.Enums.AdGroupTypeEnum.Types;
using static Google.Ads.GoogleAds.V21.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V21.Enums.AdvertisingChannelSubTypeEnum.Types;
using static Google.Ads.GoogleAds.V21.Enums.BudgetTypeEnum.Types;
using static Google.Ads.GoogleAds.V21.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V21.Enums.EuPoliticalAdvertisingStatusEnum.Types;
using static Google.Ads.GoogleAds.V21.Services.SmartCampaignSuggestionInfo.Types;

namespace Google.Ads.GoogleAds.Examples.V21
{
    /// <summary>
    /// This example shows how to create a Smart Campaign.
    ///
    /// More details on Smart Campaigns can be found here:
    /// https://support.google.com/google-ads/answer/7652860
    /// </summary>
    public class AddSmartCampaign : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddSmartCampaign"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// A keyword text used to retrieve keyword theme constant suggestions from the
            /// KeywordThemeConstantService. These keyword theme suggestions are generated
            /// using auto-completion data for the given text and may help improve the
            /// performance of the Smart campaign.
            /// </summary>
            [Option("keywordText", Required = false, HelpText =
                "A keyword text used to retrieve keyword theme constant suggestions from the " +
                "KeywordThemeConstantService. These keyword theme suggestions are generated " +
                "using auto-completion data for the given text and may help improve the " +
                "performance of the Smart campaign.",
                Default = DEFAULT_KEYWORD_TEXT)]
            public string Keyword { get; set; }

            /// <summary>
            /// A keyword text used to create a freeform keyword theme, which is entirely
            /// user-specified and not derived from any suggestion service. Using free-form
            /// keyword themes is typically not recommended because they are less effective
            /// than suggested keyword themes, however they are useful in situations where a
            /// very specific term needs to be targeted.
            /// </summary>
            [Option("freeformKeywordText", Required = false, HelpText =
                "A keyword text used to create a freeform keyword theme, which is entirely " +
                "user-specified and not derived from any suggestion service. Using free-form " +
                "keyword themes is typically not recommended because they are less effective " +
                "than suggested keyword themes, however they are useful in situations where a " +
                "very specific term needs to be targeted.",
                Default = DEFAULT_KEYWORD_TEXT)]
            public string FreeformKeywordText { get; set; }

            /// <summary>
            /// The identifier for a Business Profile location</summary>
            [Option("BusinessProfileLocation", Required = false, HelpText =
                "The identifier for a Business Profile location.")]
            public string BusinessProfileLocation { get; set; }

            /// <summary>
            /// The name of a Business Profile business. This is required if a business
            /// location ID is not provided.
            /// </summary>
            [Option("businessName", Required = false, HelpText =
                "The name of a Business Profile business. This is required if a " +
                "business location ID is not provided.")]
            public string BusinessName { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddSmartCampaign codeExample = new AddSmartCampaign();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.Keyword,
                options.FreeformKeywordText, options.BusinessProfileLocation,
                options.BusinessName);
        }

        private const string DEFAULT_KEYWORD_TEXT = "travel";

        // Geo target constant for New York City.
        private const long GEO_TARGET_CONSTANT = 1023191;
        private const string COUNTRY_CODE = "US";
        private const string LANGUAGE_CODE = "en";
        private const string LANDING_PAGE_URL = "http://www.example.com";
        private const string PHONE_NUMBER = "800-555-0100";
        private const long BUDGET_TEMPORARY_ID = -1;
        private const long SMART_CAMPAIGN_TEMPORARY_ID = -2;
        private const long AD_GROUP_TEMPORARY_ID = -3;
        private const int NUM_REQUIRED_HEADLINES = 3;
        private const int NUM_REQUIRED_DESCRIPTIONS = 2;

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example shows how to create a Smart Campaign.\nMore details on Smart " +
            "Campaigns can be found here: https: //support.google.com/google-ads/answer/7652860";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="keywordText">A keyword string used for generating keyword themes.</param>
        /// <param name="freeFormKeywordText">A keyword used to create a free-form keyword theme.
        /// </param>
        /// <param name="businessProfileLocation">The identifier of a Business Profile location.
        /// </param>
        /// <param name="businessName">The name of a Business Profile business.</param>
        public void Run(GoogleAdsClient client, long customerId, string keywordText,
            string freeFormKeywordText, string businessProfileLocation, string businessName)
        {
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V21.GoogleAdsService);

            try
            {
                // [START add_smart_campaign_12]
                // Gets the SmartCampaignSuggestionInfo object which acts as the basis for many
                // of the entities necessary to create a Smart campaign. It will be reused a number
                // of times to retrieve suggestions for keyword themes, budget amount, ad
                //creatives, and campaign criteria.
                SmartCampaignSuggestionInfo suggestionInfo =
                    GetSmartCampaignSuggestionInfo(client, businessProfileLocation, businessName);

                // Generates a list of keyword themes using the SuggestKeywordThemes method on the
                // SmartCampaignSuggestService. It is strongly recommended that you use this
                // strategy for generating keyword themes.
                List<KeywordThemeConstant> keywordThemeConstants =
                    GetKeywordThemeSuggestions(client, customerId, suggestionInfo);

                // Optionally retrieves auto-complete suggestions for the given keyword text and
                // adds them to the list of keyWordThemeConstants.
                if (keywordText != null)
                {
                    keywordThemeConstants.AddRange(GetKeywordTextAutoCompletions(
                        client, keywordText));
                }

                // Converts the KeywordThemeConstants to KeywordThemeInfos.
                List<KeywordThemeInfo> keywordThemeInfos = keywordThemeConstants.Select(
                    constant =>
                        new KeywordThemeInfo { KeywordThemeConstant = constant.ResourceName })
                    .ToList();

                // Optionally includes any freeform keywords verbatim.
                if (freeFormKeywordText != null)
                {
                    keywordThemeInfos.Add(new KeywordThemeInfo()
                    {
                        FreeFormKeywordTheme = freeFormKeywordText
                    });
                }

                // Includes the keyword suggestions in the overall SuggestionInfo object.
                // [START add_smart_campaign_13]
                suggestionInfo.KeywordThemes.Add(keywordThemeInfos);
                // [END add_smart_campaign_13]
                // [END add_smart_campaign_12]

                SmartCampaignAdInfo adSuggestions = GetAdSuggestions(client, customerId,
                    suggestionInfo);

                long suggestedBudgetAmount = GetBudgetSuggestion(client, customerId,
                    suggestionInfo);

                // [START add_smart_campaign_7]
                // The below methods create and return MutateOperations that we later provide to
                // the GoogleAdsService.Mutate method in order to create the entities in a single
                // request. Since the entities for a Smart campaign are closely tied to one-another
                // it's considered a best practice to create them in a single Mutate request; the
                // entities will either all complete successfully or fail entirely, leaving no
                // orphaned entities. See:
                // https://developers.google.com/google-ads/api/docs/mutating/overview
                MutateOperation campaignBudgetOperation =
                    CreateCampaignBudgetOperation(customerId, suggestedBudgetAmount);
                MutateOperation smartCampaignOperation =
                    CreateSmartCampaignOperation(customerId);
                MutateOperation smartCampaignSettingOperation =
                    CreateSmartCampaignSettingOperation(customerId, businessProfileLocation,
                        businessName);
                IEnumerable<MutateOperation> campaignCriterionOperations =
                    CreateCampaignCriterionOperations(customerId, keywordThemeInfos,
                        suggestionInfo);
                MutateOperation adGroupOperation = CreateAdGroupOperation(customerId);
                MutateOperation adGroupAdOperation = CreateAdGroupAdOperation(customerId,
                    adSuggestions);

                // Send the operations in a single mutate request.
                MutateGoogleAdsRequest mutateGoogleAdsRequest = new MutateGoogleAdsRequest
                {
                    CustomerId = customerId.ToString()
                };
                // It's important to create these entities in this order because they depend on
                // each other, for example the SmartCampaignSetting and ad group depend on the
                // campaign, and the ad group ad depends on the ad group.
                mutateGoogleAdsRequest.MutateOperations.Add(campaignBudgetOperation);
                mutateGoogleAdsRequest.MutateOperations.Add(smartCampaignOperation);
                mutateGoogleAdsRequest.MutateOperations.Add(smartCampaignSettingOperation);
                mutateGoogleAdsRequest.MutateOperations.Add(campaignCriterionOperations);
                mutateGoogleAdsRequest.MutateOperations.Add(adGroupOperation);
                mutateGoogleAdsRequest.MutateOperations.Add(adGroupAdOperation);

                MutateGoogleAdsResponse response =
                    googleAdsServiceClient.Mutate(mutateGoogleAdsRequest);

                PrintResponseDetails(response);
                // [END add_smart_campaign_7]
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

        // [START add_smart_campaign_11]
        /// <summary>
        /// Retrieves KeywordThemeConstants suggestions with the SmartCampaignSuggestService.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="suggestionInfo">The suggestion information.</param>
        /// <returns>The suggestions.</returns>
        private List<KeywordThemeConstant> GetKeywordThemeSuggestions(
            GoogleAdsClient client, long customerId, SmartCampaignSuggestionInfo suggestionInfo)
        {
            SmartCampaignSuggestServiceClient smartCampaignSuggestService =
                client.GetService(Services.V21.SmartCampaignSuggestService);

            SuggestKeywordThemesRequest request = new SuggestKeywordThemesRequest()
            {
                SuggestionInfo = suggestionInfo,
                CustomerId = customerId.ToString()
            };

            SuggestKeywordThemesResponse response =
                smartCampaignSuggestService.SuggestKeywordThemes(request);

            // Prints some information about the result.
            Console.WriteLine($"Retrieved {response.KeywordThemes.Count} keyword theme " +
                $"constant suggestions from the SuggestKeywordThemes method.");
            return response.KeywordThemes.ToList().ConvertAll(x => x.KeywordThemeConstant);
        }
        // [END add_smart_campaign_11]


        // [START add_smart_campaign]
        /// <summary>
        /// Retrieves KeywordThemeConstants that are derived from autocomplete data for the
        /// given keyword text.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="keywordText">A keyword used for generating keyword auto completions.
        /// </param>
        /// <returns>A list of KeywordThemeConstants.</returns>
        private IEnumerable<KeywordThemeConstant> GetKeywordTextAutoCompletions(
            GoogleAdsClient client, string keywordText)
        {
            KeywordThemeConstantServiceClient keywordThemeConstantServiceClient =
                client.GetService(Services.V21.KeywordThemeConstantService);

            SuggestKeywordThemeConstantsRequest request = new SuggestKeywordThemeConstantsRequest
            {
                QueryText = keywordText,
                CountryCode = COUNTRY_CODE,
                LanguageCode = LANGUAGE_CODE
            };

            SuggestKeywordThemeConstantsResponse response =
                keywordThemeConstantServiceClient.SuggestKeywordThemeConstants(request);

            Console.WriteLine($"Retrieved {response.KeywordThemeConstants.Count} keyword theme " +
                $"constants using the keyword '{keywordText}'.");
            return response.KeywordThemeConstants.ToList();
        }
        // [END add_smart_campaign]

        // [START add_smart_campaign_9]
        /// <summary>
        /// Builds a SmartCampaignSuggestionInfo object with business details.
        ///
        /// The details are used by the SmartCampaignSuggestService to suggest a
        /// budget amount as well as creatives for the ad.
        ///
        /// Note that when retrieving ad creative suggestions it's required that the
        /// "final_url", "language_code" and "keyword_themes" fields are set on the
        /// SmartCampaignSuggestionInfo instance.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="businessProfileLocation">The identifier of a Business Profile location.
        /// </param>
        /// <param name="businessName">The name of a Business Profile.</param>
        /// <returns>A SmartCampaignSuggestionInfo instance .</returns>
        private SmartCampaignSuggestionInfo GetSmartCampaignSuggestionInfo(GoogleAdsClient client,
            string businessProfileLocation, string businessName)
        {
            // Note: This is broken since businessLocationId is not yet renamed in
            // SmartCampaignSuggestionInfo. The use of dynamic temporarily fixes the broken build.
            // TODO(Anash): Revert the type change once this field is fixed.
            dynamic suggestionInfo = new SmartCampaignSuggestionInfo
            {
                // Add the URL of the campaign's landing page.
                FinalUrl = LANDING_PAGE_URL,
                LanguageCode = LANGUAGE_CODE,
                // Construct location information using the given geo target constant. It's
                // also possible to provide a geographic proximity using the "proximity"
                // field on suggestion_info, for example:
                // Proximity = new ProximityInfo
                // {
                //     Address = new AddressInfo
                //     {
                //         PostalCode = "INSERT_POSTAL_CODE",
                //         ProvinceCode = "INSERT_PROVINCE_CODE",
                //         CountryCode = "INSERT_COUNTRY_CODE",
                //         ProvinceName = "INSERT_PROVINCE_NAME",
                //         StreetAddress = "INSERT_STREET_ADDRESS",
                //         StreetAddress2 = "INSERT_STREET_ADDRESS_2",
                //         CityName = "INSERT_CITY_NAME"
                //     },
                //     Radius = Double.Parse("INSERT_RADIUS"),
                //     RadiusUnits = ProximityRadiusUnits.Kilometers
                // }
                // For more information on proximities see:
                // https://developers.google.com/google-ads/api/reference/rpc/latest/ProximityInfo
                LocationList = new LocationList()
                {
                    Locations =
                    {
                        new LocationInfo
                        {
                            // Set the location to the resource name of the given geo target
                            // constant.
                            GeoTargetConstant =
                                ResourceNames.GeoTargetConstant(GEO_TARGET_CONSTANT)
                        }
                    }
                }
            };

            // Add the Business Profile location if provided.
            if (!string.IsNullOrEmpty(businessProfileLocation))
            {
                suggestionInfo.BusinessProfileLocation = businessProfileLocation;
            }
            else
            {
                suggestionInfo.BusinessContext = new BusinessContext
                {
                    BusinessName = businessName,
                };
            }

            // Add a schedule detailing which days of the week the business is open. This schedule
            // describes a business that is open on Mondays from 9:00 AM to 5:00 PM.
            AdScheduleInfo adScheduleInfo = new AdScheduleInfo
            {
                // Set the day of this schedule as Monday.
                DayOfWeek = DayOfWeekEnum.Types.DayOfWeek.Monday,
                // Set the start hour to 9 AM.
                StartHour = 9,
                // Set the end hour to 5 PM.
                EndHour = 17,
                // Set the start and end minutes to zero.
                StartMinute = MinuteOfHourEnum.Types.MinuteOfHour.Zero,
                EndMinute = MinuteOfHourEnum.Types.MinuteOfHour.Zero
            };

            suggestionInfo.AdSchedules.Add(adScheduleInfo);

            return suggestionInfo;
        }
        // [END add_smart_campaign_9]

        // [START add_smart_campaign_1]
        /// <summary>
        /// Retrieves a suggested budget amount for a new budget.
        /// Using the SmartCampaignSuggestService to determine a daily budget for new and existing
        /// Smart campaigns is highly recommended because it helps the campaigns achieve optimal
        /// performance.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="suggestionInfo"></param>
        /// <returns>A daily budget amount in micros.</returns>
        private long GetBudgetSuggestion(GoogleAdsClient client, long customerId,
            SmartCampaignSuggestionInfo suggestionInfo)
        {
            SmartCampaignSuggestServiceClient smartCampaignSuggestServiceClient = client.GetService
                (Services.V21.SmartCampaignSuggestService);

            SuggestSmartCampaignBudgetOptionsRequest request =
                new SuggestSmartCampaignBudgetOptionsRequest
                {
                    CustomerId = customerId.ToString(),
                    // You can retrieve suggestions for an existing campaign by setting the
                    // "Campaign" field of the request to the resource name of a campaign and
                    // leaving the rest of the request fields below unset:
                    // Campaign = "INSERT_CAMPAIGN_RESOURCE_NAME_HERE",

                    // Since these suggestions are for a new campaign, we're going to use the
                    // SuggestionInfo field instead.
                    SuggestionInfo = suggestionInfo,
                };

            LocationInfo locationInfo = new LocationInfo
            {
                // Set the location to the resource name of the given geo target constant.
                GeoTargetConstant = ResourceNames.GeoTargetConstant(GEO_TARGET_CONSTANT)
            };

            // Issue a request to retrieve a budget suggestion.
            SuggestSmartCampaignBudgetOptionsResponse response =
                smartCampaignSuggestServiceClient.SuggestSmartCampaignBudgetOptions(request);

            // Three tiers of options will be returned: "low", "high", and "recommended".
            // Here we will use the "recommended" option. The amount is specified in micros, where
            // one million is equivalent to one currency unit.
            Console.WriteLine($"A daily budget amount of " +
                $"{response.Recommended.DailyAmountMicros}" +
                $" was suggested, garnering an estimated minimum of " +
                $"{response.Recommended.Metrics.MinDailyClicks} clicks and an estimated " +
                $"maximum of {response.Recommended.Metrics.MaxDailyClicks} clicks per day.");

            return response.Recommended.DailyAmountMicros;
        }
        // [END add_smart_campaign_1]

        // [START add_smart_campaign_10]
        /// <summary>
        /// Retrieves creative suggestions for a Smart campaign ad.
        ///
        /// Using the SmartCampaignSuggestService to suggest creatives for new
        /// and existing Smart campaigns is highly recommended because it helps
        /// the campaigns achieve optimal performance.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="suggestionInfo">a SmartCampaignSuggestionInfo instance
        /// with details about the business being advertised.</param>
        /// <returns>A SmartCampaignAdInfo instance with suggested headlines and
        /// descriptions.</returns>
        private SmartCampaignAdInfo GetAdSuggestions(GoogleAdsClient client,
            long customerId, SmartCampaignSuggestionInfo suggestionInfo)
        {
            SmartCampaignSuggestServiceClient smartCampaignSuggestService =
              client.GetService(Services.V21.SmartCampaignSuggestService);

            SuggestSmartCampaignAdRequest request = new SuggestSmartCampaignAdRequest
            {
                CustomerId = customerId.ToString(),
                // Unlike the SuggestSmartCampaignBudgetOptions method, it's only possible to
                // use suggestion_info to retrieve ad creative suggestions.
                SuggestionInfo = suggestionInfo
            };

            // Issue a request to retrieve ad creative suggestions.
            SuggestSmartCampaignAdResponse response =
              smartCampaignSuggestService.SuggestSmartCampaignAd(request);

            // The SmartCampaignAdInfo object in the response contains a list of up to
            // three headlines and two descriptions. Note that some of the suggestions
            // may have empty strings as text. Before setting these on the ad you should
            // review them and filter out any empty values.
            SmartCampaignAdInfo adSuggestions = response.AdInfo;

            if (adSuggestions != null)
            {
                Console.WriteLine($"The following headlines were suggested:");
                foreach (AdTextAsset headline in adSuggestions.Headlines)
                {
                    Console.WriteLine($"\t{headline.Text}");
                }

                Console.WriteLine($"And the following descriptions were suggested:");
                foreach (AdTextAsset description in adSuggestions.Descriptions)
                {
                    Console.WriteLine($"\t{description.Text}");
                }
            }
            else
            {
                Console.WriteLine("No ad suggestions were found.");
                adSuggestions = new SmartCampaignAdInfo();
            }

            return adSuggestions;
        }
        // [END add_smart_campaign_10]

        // [START add_smart_campaign_2]
        /// <summary>
        /// Creates a MutateOperation that creates a new CampaignBudget.
        /// A temporary ID will be assigned to this campaign budget so that it can be referenced by
        /// other objects being created in the same Mutate request.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="suggestedBudgetAmount">A daily amount budget in micros.</param>
        /// <returns>A MutateOperation that creates a CampaignBudget</returns>
        private MutateOperation CreateCampaignBudgetOperation(long customerId,
            long suggestedBudgetAmount)
        {
            return new MutateOperation
            {
                CampaignBudgetOperation = new CampaignBudgetOperation
                {
                    Create = new CampaignBudget
                    {
                        Name = $"Smart campaign budget #{ExampleUtilities.GetRandomString()}",
                        // A budget used for Smart campaigns must have the type SMART_CAMPAIGN.
                        Type = BudgetType.SmartCampaign,
                        // The suggested budget amount from the SmartCampaignSuggestService is a
                        // daily budget. We don't need to specify that here, because the budget
                        // period already defaults to DAILY.
                        AmountMicros = suggestedBudgetAmount,
                        // Set a temporary ID in the budget's resource name so it can be referenced
                        // by the campaign in later steps.
                        ResourceName = ResourceNames.CampaignBudget(
                            customerId, BUDGET_TEMPORARY_ID)
                    }
                }
            };
        }
        // [END add_smart_campaign_2]

        // [START add_smart_campaign_3]
        /// <summary>
        /// Creates a MutateOperation that creates a new Smart campaign.
        /// A temporary ID will be assigned to this campaign so that it can be referenced by other
        /// objects being created in the same Mutate request.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <returns>A MutateOperation that creates a campaign.</returns>
        private MutateOperation CreateSmartCampaignOperation(long customerId)
        {
            return new MutateOperation
            {
                CampaignOperation = new CampaignOperation
                {
                    Create = new Campaign
                    {
                        Name = $"Smart campaign #{ExampleUtilities.GetRandomString()}",
                        // Set the campaign status as PAUSED. The campaign is the only entity in
                        // the mutate request that should have its status set.
                        Status = CampaignStatus.Paused,
                        // AdvertisingChannelType must be SMART.
                        AdvertisingChannelType = AdvertisingChannelType.Smart,
                        // AdvertisingChannelSubType must be SMART_CAMPAIGN.
                        AdvertisingChannelSubType = AdvertisingChannelSubType.SmartCampaign,
                        // Assign the resource name with a temporary ID.
                        ResourceName =
                            ResourceNames.Campaign(customerId, SMART_CAMPAIGN_TEMPORARY_ID),
                        // Set the budget using the given budget resource name.
                        CampaignBudget =
                            ResourceNames.CampaignBudget(customerId, BUDGET_TEMPORARY_ID),

                        // Declare whether or not this campaign contains political ads targeting the EU.
                        ContainsEuPoliticalAdvertising = EuPoliticalAdvertisingStatus.DoesNotContainEuPoliticalAdvertising,
                    }
                }
            };
        }
        // [END add_smart_campaign_3]

        // [START add_smart_campaign_4]
        /// <summary>
        /// Creates a MutateOperation to create a new SmartCampaignSetting. SmartCampaignSettings
        /// are unique in that they only support UPDATE operations, which are used to update and
        /// create them. Below we will use a temporary ID in the resource name to associate it with
        /// the campaign created in the previous step.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="businessProfileLocation">The identifier of a Business Profile location.</param>
        /// <param name="businessName">The name of a Business Profile business.</param>
        /// <returns>A MutateOperation that creates a SmartCampaignSetting.</returns>
        private MutateOperation CreateSmartCampaignSettingOperation(long customerId,
            string businessProfileLocation, string businessName)
        {
            SmartCampaignSetting smartCampaignSetting = new SmartCampaignSetting
            {
                // Set a temporary ID in the campaign setting's resource name to associate it with
                // the campaign created in the previous step.
                ResourceName =
                    ResourceNames.SmartCampaignSetting(customerId, SMART_CAMPAIGN_TEMPORARY_ID),
                // Below we configure the SmartCampaignSetting using many of the same details used
                // to generate a budget suggestion.
                PhoneNumber = new SmartCampaignSetting.Types.PhoneNumber
                {
                    CountryCode = COUNTRY_CODE,
                    PhoneNumber_ = PHONE_NUMBER
                },
                FinalUrl = LANDING_PAGE_URL,
                AdvertisingLanguageCode = LANGUAGE_CODE
            };

            // Either a business profile location or a business name must be added to the
            // SmartCampaignSetting.
            if (!string.IsNullOrEmpty(businessProfileLocation))
            {
                // Transform Google Business Location ID to a compatible format before
                // passing it onto the API.
                smartCampaignSetting.BusinessProfileLocation = businessProfileLocation;
            }
            else
            {
                smartCampaignSetting.BusinessName = businessName;
            }

            return new MutateOperation
            {
                SmartCampaignSettingOperation = new SmartCampaignSettingOperation
                {
                    Update = smartCampaignSetting,
                    // Set the update mask on the operation. This is required since the smart
                    // campaign setting is created in an UPDATE operation. Here the update mask
                    // will be a list of all the fields that were set on the SmartCampaignSetting.
                    UpdateMask = FieldMasks.AllSetFieldsOf(smartCampaignSetting)
                }
            };
        }
        // [END add_smart_campaign_4]

        // [START add_smart_campaign_8]
        /// <summary>
        /// Creates a list of MutateOperations that create new campaign criteria.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="keywordThemeInfos">A list of KeywordThemeInfos.</param>
        /// <param name="suggestionInfo">A SmartCampaignSuggestionInfo instance.</param>
        /// <returns>A list of MutateOperations that create new campaign criteria.</returns>
        private IEnumerable<MutateOperation> CreateCampaignCriterionOperations(long customerId,
            IEnumerable<KeywordThemeInfo> keywordThemeInfos, SmartCampaignSuggestionInfo
            suggestionInfo)
        {
            List<MutateOperation> mutateOperations = keywordThemeInfos.Select(
                keywordThemeInfo => new MutateOperation
                {
                    CampaignCriterionOperation = new CampaignCriterionOperation
                    {
                        Create = new CampaignCriterion
                        {
                            // Set the campaign ID to a temporary ID.
                            Campaign = ResourceNames.Campaign(
                                customerId, SMART_CAMPAIGN_TEMPORARY_ID),
                            // Set the keyword theme to each KeywordThemeInfo in turn.
                            KeywordTheme = keywordThemeInfo,
                        }
                    }
                }).ToList();

            // Create a location criterion for each location in the suggestion info.
            mutateOperations.AddRange(
                suggestionInfo.LocationList.Locations.Select(
                    locationInfo => new MutateOperation()
                    {
                        CampaignCriterionOperation = new CampaignCriterionOperation()
                        {
                            Create = new CampaignCriterion()
                            {
                                // Set the campaign ID to a temporary ID.
                                Campaign = ResourceNames.Campaign(customerId,
                                    SMART_CAMPAIGN_TEMPORARY_ID),
                                // Set the location to the given location.
                                Location = locationInfo
                            }
                        }
                    }).ToList()
            );
            return mutateOperations;
        }
        // [END add_smart_campaign_8]

        // [START add_smart_campaign_5]
        /// <summary>
        /// Creates a MutateOperation that creates a new ad group.
        /// A temporary ID will be used in the campaign resource name for this ad group to
        /// associate it with the Smart campaign created in earlier steps. A temporary ID will
        /// also be used for its own resource name so that we can associate an ad group ad with
        /// it later in the process.
        /// Only one ad group can be created for a given Smart campaign.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <returns>A MutateOperation that creates a new ad group.</returns>
        private MutateOperation CreateAdGroupOperation(long customerId)
        {
            return new MutateOperation
            {
                AdGroupOperation = new AdGroupOperation
                {
                    Create = new AdGroup
                    {
                        // Set the ad group ID to a temporary ID.
                        ResourceName = ResourceNames.AdGroup(customerId, AD_GROUP_TEMPORARY_ID),
                        Name = $"Smart campaign ad group #{ExampleUtilities.GetRandomString()}",
                        // Set the campaign ID to a temporary ID.
                        Campaign = ResourceNames.Campaign(customerId, SMART_CAMPAIGN_TEMPORARY_ID),
                        // The ad group type must be SmartCampaignAds.
                        Type = AdGroupType.SmartCampaignAds
                    }
                }
            };
        }
        // [END add_smart_campaign_5]

        // [START add_smart_campaign_6]
        /// <summary>
        /// Creates a MutateOperation that creates a new ad group ad.
        /// A temporary ID will be used in the ad group resource name for this ad group ad to
        /// associate it with the ad group created in earlier steps.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="adSuggestions">SmartCampaignAdInfo with ad creative
        /// suggestions.</param>
        /// <returns>A MutateOperation that creates a new ad group ad.</returns>
        private MutateOperation CreateAdGroupAdOperation(long customerId, SmartCampaignAdInfo
            adSuggestions)
        {
            AdGroupAd adGroupAd = new AdGroupAd
            {
                AdGroup = ResourceNames.AdGroup(customerId, AD_GROUP_TEMPORARY_ID),
                Ad = new Ad
                {
                    SmartCampaignAd = new SmartCampaignAdInfo(),
                },
            };

            SmartCampaignAdInfo ad = adGroupAd.Ad.SmartCampaignAd;

            // The SmartCampaignAdInfo object includes headlines and descriptions
            // retrieved from the SmartCampaignSuggestService.SuggestSmartCampaignAd
            // method. It's recommended that users review and approve or update these
            // creatives before they're set on the ad. It's possible that some or all of
            // these assets may contain empty texts, which should not be set on the ad
            // and instead should be replaced with meaninful texts from the user. Below
            // we just accept the creatives that were suggested while filtering out empty
            // assets. If no headlines or descriptions were suggested, then we manually
            // add some, otherwise this operation will generate an INVALID_ARGUMENT
            // error. Individual workflows will likely vary here.
            ad.Headlines.Add(adSuggestions.Headlines);
            ad.Descriptions.Add(adSuggestions.Descriptions);

            // If there are fewer headlines than are required, we manually add additional
            // headlines to make up for the difference.
            if (adSuggestions.Headlines.Count() < NUM_REQUIRED_HEADLINES)
            {
                for (int i = 0; i < NUM_REQUIRED_HEADLINES - adSuggestions.Headlines.Count(); i++)
                {
                    ad.Headlines.Add(new AdTextAsset()
                    {
                        Text = $"Placeholder headline {i + 1}"
                    });
                }
            }

            // If there are fewer descriptions than are required, we manually add
            // additional descriptions to make up for the difference.
            if (adSuggestions.Descriptions.Count() < NUM_REQUIRED_DESCRIPTIONS)
            {
                for (int i = 0; i < NUM_REQUIRED_DESCRIPTIONS -
                    adSuggestions.Descriptions.Count(); i++)
                {
                    ad.Descriptions.Add(new AdTextAsset()
                    {
                        Text = $"Placeholder description {i + 1}"
                    });
                }
            }

            return new MutateOperation
            {
                AdGroupAdOperation = new AdGroupAdOperation
                {
                    Create = adGroupAd
                }
            };
        }
        // [END add_smart_campaign_6]

        // [START add_smart_campaign_14]
        /// <summary>
        /// Converts the business location ID from the format returned by Business Profile
        /// to the format expected by the API.
        /// </summary>
        /// <param name="businessLocationId">The business location identifier.</param>
        /// <returns>The transformed ID.</returns>
        private long ConvertBusinessLocationId(ulong businessLocationId)
        {
            // The business location ID is an unsigned 64-bit integer. However, the Google Ads API
            // expects a signed 64-bit integer. So we convert the unsigned ID into a signed ID,
            // while allowing an overflow, so that the ID wraps around if it is too large.
            return unchecked((long) businessLocationId);
        }
        // [END add_smart_campaign_14]

        /// <summary>
        /// Prints the details of a MutateGoogleAdsResponse. Parses the "response" oneof field name
        /// and uses it to extract the new entity's name and resource name.
        /// </summary>
        /// <param name="response">A MutateGoogleAdsResponse instance.</param>
        private void PrintResponseDetails(MutateGoogleAdsResponse response)
        {
            // Parse the Mutate response to print details about the entities that were created
            // in the request.
            foreach (MutateOperationResponse operationResponse in response.MutateOperationResponses)
            {
                string resourceName = "<not found>";

                string entityName = operationResponse.ResponseCase.ToString();
                // Trim the substring "Result" from the end of the entity name.
                entityName = entityName.Remove(entityName.Length - 6);

                switch (operationResponse.ResponseCase)
                {
                    case MutateOperationResponse.ResponseOneofCase.AdGroupResult:
                        resourceName = operationResponse.AdGroupResult.ResourceName;
                        break;
                    case MutateOperationResponse.ResponseOneofCase.AdGroupAdResult:
                        resourceName = operationResponse.AdGroupAdResult.ResourceName;
                        break;
                    case MutateOperationResponse.ResponseOneofCase.CampaignResult:
                        resourceName = operationResponse.CampaignResult.ResourceName;
                        break;
                    case MutateOperationResponse.ResponseOneofCase.CampaignBudgetResult:
                        resourceName = operationResponse.CampaignBudgetResult.ResourceName;
                        break;
                    case MutateOperationResponse.ResponseOneofCase.CampaignCriterionResult:
                        resourceName = operationResponse.CampaignCriterionResult.ResourceName;
                        break;
                    case MutateOperationResponse.ResponseOneofCase.SmartCampaignSettingResult:
                        resourceName = operationResponse.SmartCampaignSettingResult.ResourceName;
                        break;
                }

                Console.WriteLine(
                    $"Created a(n) {entityName} with resource name: '{resourceName}'.");
            }
        }
    }
}

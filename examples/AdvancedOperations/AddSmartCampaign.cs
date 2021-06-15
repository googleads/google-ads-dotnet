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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V8.Common;
using Google.Ads.GoogleAds.V8.Enums;
using Google.Ads.GoogleAds.V8.Errors;
using Google.Ads.GoogleAds.V8.Resources;
using Google.Ads.GoogleAds.V8.Services;
using static Google.Ads.GoogleAds.V8.Enums.AdGroupTypeEnum.Types;
using static Google.Ads.GoogleAds.V8.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V8.Enums.AdvertisingChannelSubTypeEnum.Types;
using static Google.Ads.GoogleAds.V8.Enums.BudgetTypeEnum.Types;
using static Google.Ads.GoogleAds.V8.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V8.Enums.CriterionTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V8
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
            /// A keyword text used to generate a set of keyword themes, which are used to improve
            /// the budget recommendation and performance of the Smart Campaign. Default value is
            /// defined in the DEFAULT_KEYWORD_TEXT constant.
            /// </summary>
            [Option("keywordText", Required = false, HelpText =
                    "A keyword text used to generate a set of keyword themes, which are used to " +
                    "improve the budget recommendation and performance of the Smart Campaign." +
                    "\nDefault value is defined in the DEFAULT_KEYWORD_TEXT constant.",
                Default = DEFAULT_KEYWORD_TEXT)]
            public string Keyword { get; set; }

            /// <summary>
            /// The ID of a Google My Business (GMB) location.  This is required if a business name
            /// is not provided. This ID can be retrieved using the GMB API, for details see:
            /// https://developers.google.com/my-business/reference/rest/v4/accounts.locations
            /// </summary>
            [Option("businessLocationId", Required = false, HelpText =
                "The ID of a Google My Business (GMB) location. This is required if a business " +
                "name is not provided.\n" +
                "This ID can be retrieved using the GMB API; for details see: " +
                "https://developers.google.com/my-business/reference/rest/v4/accounts.locations")]
            public long? BusinessLocationId { get; set; }

            /// <summary>
            /// The name of a Google My Business (GMB) business. This is required if a business
            /// location ID is not provided.
            /// </summary>
            [Option("businessName", Required = false, HelpText =
                "The name of a Google My Business (GMB) business. This is required if a business " +
                "location ID is not provided.")]
            public string BusinessName { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = new Options();
            Parser.Default.ParseArguments<Options>(args).MapResult(
                delegate(Options o)
                {
                    options = o;
                    return 0;
                }, delegate(IEnumerable<Error> errors)
                {
                    // The Google Ads customer ID.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // A keyword text used to generate a set of keyword themes, which are used to
                    // improve the budget recommendation and performance of the Smart Campaign.
                    options.Keyword = DEFAULT_KEYWORD_TEXT;

                    // The ID of a Google My Business (GMB) location. This is required if a business
                    // name is not provided.
                    options.BusinessLocationId = long.Parse("INSERT_BUSINESS_LOCATION_ID_HERE");

                    // The name of a Google My Business (GMB) business. This is required if a
                    // business location ID is not provided.
                    options.BusinessName = "INSERT_BUSINESS_NAME_HERE";

                    return 0;
                });

            AddSmartCampaign codeExample = new AddSmartCampaign();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.Keyword,
                options.BusinessLocationId, options.BusinessName);
        }

        private const string DEFAULT_KEYWORD_TEXT = "travel";

        // Geo target constant for New York City.
        private const long GEO_TARGET_CONSTANT = 1023191;
        private const string COUNTRY_CODE = "US";
        private const string LANGUAGE_CODE = "en";
        private const string LANDING_PAGE_URL = "http://www.example.com";
        private const string PHONE_NUMBER = "555-555-5555";
        private const long BUDGET_TEMPORARY_ID = -1;
        private const long SMART_CAMPAIGN_TEMPORARY_ID = -2;
        private const long AD_GROUP_TEMPORARY_ID = -3;

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example shows how to create a Smart Campaign.\nMore details on Smart Campaigns " +
            "can be found here: https: //support.google.com/google-ads/answer/7652860";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="keywordText">A keyword string used for generating keyword themes.</param>
        /// <param name="businessLocationId">The ID of a Google My Business location.</param>
        /// <param name="businessName">The name of a Google My Business business.</param>
        public void Run(GoogleAdsClient client, long customerId, string keywordText,
            long? businessLocationId, string businessName)
        {
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V8.GoogleAdsService);

            try
            {
                IEnumerable<KeywordThemeConstant> keywordThemeConstants =
                    GetKeywordThemeConstants(client, keywordText);

                // Map the KeywordThemeConstants to KeywordThemeInfo objects.
                IEnumerable<KeywordThemeInfo> keywordThemeInfos = keywordThemeConstants.Select(
                        constant =>
                            new KeywordThemeInfo {KeywordThemeConstant = constant.ResourceName})
                    .ToList();

                long suggestedBudgetAmount = GetBudgetSuggestion(client, customerId,
                    businessLocationId, keywordThemeInfos);

                // [START add_smart_campaign_7]
                // The below methods create and return MutateOperations that we later provide to the
                // GoogleAdsService.Mutate method in order to create the entities in a single
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
                    CreateSmartCampaignSettingOperation(customerId, businessLocationId,
                        businessName);
                IEnumerable<MutateOperation> campaignCriterionOperations =
                    CreateCampaignCriterionOperations(customerId, keywordThemeInfos);
                MutateOperation adGroupOperation = CreateAdGroupOperation(customerId);
                MutateOperation adGroupAdOperation = CreateAdGroupAdOperation(customerId);

                // Send the operations in a single mutate request.
                MutateGoogleAdsRequest mutateGoogleAdsRequest = new MutateGoogleAdsRequest
                {
                    CustomerId = customerId.ToString()
                };
                // It's important to create these entities in this order because they depend on each
                // other, for example the SmartCampaignSetting and ad group depend on the campaign,
                // and the ad group ad depends on the ad group.
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

        // [START add_smart_campaign]
        /// <summary>
        /// Retrieves keyword theme constants for the given criteria.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="keywordText">A keyword used for generating keyword themes.</param>
        /// <returns>A list of KeywordThemeConstants.</returns>
        private IEnumerable<KeywordThemeConstant> GetKeywordThemeConstants(GoogleAdsClient client,
            string keywordText)
        {
            KeywordThemeConstantServiceClient keywordThemeConstantServiceClient =
                client.GetService(Services.V8.KeywordThemeConstantService);

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

        // [START add_smart_campaign_1]
        /// <summary>
        /// Retrieves a suggested budget amount for a new budget.
        /// Using the SmartCampaignSuggestService to determine a daily budget for new and existing
        /// Smart campaigns is highly recommended because it helps the campaigns achieve optimal
        /// performance.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="businessLocationId">The ID of a Google My Business location.</param>
        /// <param name="keywordThemeInfos">A list of KeywordThemeInfos.</param>
        /// <returns>A daily budget amount in micros.</returns>
        private long GetBudgetSuggestion(GoogleAdsClient client, long customerId, long?
            businessLocationId, IEnumerable<KeywordThemeInfo> keywordThemeInfos)
        {
            SmartCampaignSuggestServiceClient smartCampaignSuggestServiceClient = client.GetService
                (Services.V8.SmartCampaignSuggestService);

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
                    SuggestionInfo = new SmartCampaignSuggestionInfo
                    {
                        // Add the URL of the campaign's landing page.
                        FinalUrl = LANDING_PAGE_URL,
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
                        LocationList = new SmartCampaignSuggestionInfo.Types.LocationList()
                    }
                };

            LocationInfo locationInfo = new LocationInfo
            {
                // Set the location to the resource name of the given geo target constant.
                GeoTargetConstant = ResourceNames.GeoTargetConstant(GEO_TARGET_CONSTANT)
            };

            // Add the LocationInfo object to the list of locations on the SuggestionInfo object.
            // You have the option of providing multiple locations when using location-based
            // suggestions.
            request.SuggestionInfo.LocationList.Locations.Add(locationInfo);

            // Add the KeywordThemeInfo objects to the SuggestionInfo object.
            request.SuggestionInfo.KeywordThemes.Add(keywordThemeInfos);

            // Add the GMB location ID if provided.
            if (businessLocationId.HasValue)
            {
                request.SuggestionInfo.BusinessLocationId = businessLocationId.Value;
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

            request.SuggestionInfo.AdSchedules.Add(adScheduleInfo);

            // Issue a request to retrieve a budget suggestion.
            SuggestSmartCampaignBudgetOptionsResponse response =
                smartCampaignSuggestServiceClient.SuggestSmartCampaignBudgetOptions(request);

            // Three tiers of options will be returned: "low", "high", and "recommended".
            // Here we will use the "recommended" option. The amount is specified in micros, where
            // one million is equivalent to one currency unit.
            Console.WriteLine($"A daily budget amount of {response.Recommended.DailyAmountMicros}" +
                $" was suggested, garnering an estimated minimum of " +
                $"{response.Recommended.Metrics.MinDailyClicks} clicks and an estimated maximum " +
                $"of {response.Recommended.Metrics.MaxDailyClicks} clicks per day.");

            return response.Recommended.DailyAmountMicros;
        }
        // [END add_smart_campaign_1]

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
                        ResourceName = ResourceNames.CampaignBudget(customerId, BUDGET_TEMPORARY_ID)
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
                        // Set the campaign status as PAUSED. The campaign is the only entity in the
                        // mutate request that should have its status set.
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
                            ResourceNames.CampaignBudget(customerId, BUDGET_TEMPORARY_ID)
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
        /// <param name="businessLocationId">The ID of a Google My Business location.</param>
        /// <param name="businessName">The name of a Google My Business business.</param>
        /// <returns>A MutateOperation that creates a SmartCampaignSetting.</returns>
        private MutateOperation CreateSmartCampaignSettingOperation(long customerId,
            long? businessLocationId, string businessName)
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

            // Either a business location ID or a business name must be added to the
            // SmartCampaignSetting.
            if (businessLocationId.HasValue)
            {
                smartCampaignSetting.BusinessLocationId = businessLocationId.Value;
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
                    // campaign setting is created in an UPDATE operation. Here the update mask will
                    // be a list of all the fields that were set on the SmartCampaignSetting.
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
        /// <returns>A list of MutateOperations that create new campaign criteria.</returns>
        private IEnumerable<MutateOperation> CreateCampaignCriterionOperations(long customerId,
            IEnumerable<KeywordThemeInfo> keywordThemeInfos)
        {
            return keywordThemeInfos.Select(keywordThemeInfo => new MutateOperation
            {
                CampaignCriterionOperation = new CampaignCriterionOperation
                {
                    Create = new CampaignCriterion
                    {
                        // Set the campaign ID to a temporary ID.
                        Campaign = ResourceNames.Campaign(customerId, SMART_CAMPAIGN_TEMPORARY_ID),
                        // Set the criterion type to KeywordTheme.
                        Type = CriterionType.KeywordTheme,
                        // Set the keyword theme to each KeywordThemeInfo in turn.
                        KeywordTheme = keywordThemeInfo,
                    }
                }
            }).ToList();
        }
        // [END add_smart_campaign_8]

        // [START add_smart_campaign_5]
        /// <summary>
        /// Creates a MutateOperation that creates a new ad group.
        /// A temporary ID will be used in the campaign resource name for this ad group to associate
        /// it with the Smart campaign created in earlier steps. A temporary ID will also be used
        /// for its own resource name so that we can associate an ad group ad with it later in the
        /// process.
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
        /// <returns>A MutateOperation that creates a new ad group ad.</returns>
        private MutateOperation CreateAdGroupAdOperation(long customerId)
        {
            AdGroupAd adGroupAd = new AdGroupAd
            {
                AdGroup = ResourceNames.AdGroup(customerId, AD_GROUP_TEMPORARY_ID),
                Ad = new Ad
                {
                    SmartCampaignAd = new SmartCampaignAdInfo()
                }
            };

            // At most, three headlines can be specified for a Smart campaign ad.
            adGroupAd.Ad.SmartCampaignAd.Headlines.Add(new[]
                {
                    new AdTextAsset
                    {
                        Text = "Headline number one"
                    },
                    new AdTextAsset
                    {
                        Text = "Headline number two"
                    },
                    new AdTextAsset
                    {
                        Text = "Headline number three"
                    }
                }
            );

            // At most, two descriptions can be specified for a Smart campaign ad.
            adGroupAd.Ad.SmartCampaignAd.Descriptions.Add(new[]
                {
                    new AdTextAsset
                    {
                        Text = "Description number one"
                    },
                    new AdTextAsset
                    {
                        Text = "Description number two"
                    },
                }
            );

            return new MutateOperation
            {
                AdGroupAdOperation = new AdGroupAdOperation
                {
                    Create = adGroupAd
                }
            };
        }
        //[END add_smart_campaign_6]

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
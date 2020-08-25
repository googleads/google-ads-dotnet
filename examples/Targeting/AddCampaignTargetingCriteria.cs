// Copyright 2019 Google LLC
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
using Google.Ads.GoogleAds.V4.Errors;
using Google.Ads.GoogleAds.V4.Common;
using Google.Ads.GoogleAds.V4.Resources;
using Google.Ads.GoogleAds.V4.Services;

using System;

using static Google.Ads.GoogleAds.V4.Enums.KeywordMatchTypeEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.ProximityRadiusUnitsEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V4
{
    /// <summary>
    /// This code example illustrates adding campaign targeting criteria.
    /// </summary>
    public class AddCampaignTargetingCriteria : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddCampaignTargetingCriteria codeExample = new AddCampaignTargetingCriteria();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the campaign to which targeting criteria are added.
            long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

            // The keyword text to be added as a negative criterion to the keyword.
            string keywordText = "INSERT_KEYWORD_TEXT_HERE";

            // ID of the campaign to which targeting criteria are added.
            long locationId = long.Parse("INSERT_LOCATION_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, campaignId,
                keywordText, locationId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example illustrates adding campaign targeting criteria.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to which targeting criteria are added.
        /// </param>
        /// <param name="keywordText">the keyword text for which to add a criterion.</param>
        /// <param name="locationId">the locationId for which to add a criterion.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId,
            string keywordText, long locationId)
        {
            // Get the CampaignCriterionService.
            CampaignCriterionServiceClient campaignCriterionService =
                client.GetService(Services.V4.CampaignCriterionService);

            // Set the Campaign Resource Name
            string campaignResourceName = ResourceNames.Campaign(customerId, campaignId);

            // Add a campaign level negative keyword from keywordText.
            CampaignCriterion keywordCriterion = buildNegativeKeywordCriterion(keywordText,
                campaignResourceName);

            // Creates a location constant (provided by GeoTargetConstantService) as a campaign
            // targeting criterion. Please refer to GetGeoTargetConstantsByName.cs for retrieval
            // of location constants.
            CampaignCriterion locationCriterion = buildLocationCriterion(locationId,
                campaignResourceName);

            // Add a proximity criterion
            CampaignCriterion proximityCriterion = buildProximityCriterion(campaignResourceName);

            // Create the operations.
            CampaignCriterionOperation negativeCriterionOperation =
                new CampaignCriterionOperation()
                {
                    Create = keywordCriterion
                };

            CampaignCriterionOperation locationCriterionOperation =
                new CampaignCriterionOperation()
                {
                    Create = locationCriterion
                };

            CampaignCriterionOperation proximityCriterionOperation =
                new CampaignCriterionOperation()
                {
                    Create = proximityCriterion
                };

            CampaignCriterionOperation[] operations = new CampaignCriterionOperation[] {
                negativeCriterionOperation,
                locationCriterionOperation,
                proximityCriterionOperation
            };

            try
            {
                // Create the campaign criterion.
                MutateCampaignCriteriaResponse response =
                    campaignCriterionService.MutateCampaignCriteria(customerId.ToString(),
                        operations);

                // Display the results.
                foreach (MutateCampaignCriterionResult criterionResult in response.Results)
                {
                    Console.WriteLine($"New campaign criterion with resource name = " +
                        $"'{criterionResult.ResourceName}' was added to campaign " +
                        "ID {campaignId}.");
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
        /// Creates a negative keyword as a campaign targeting criterion.
        /// </summary>
        /// <param name="keywordText">the keyword text to exclude.</param>
        /// <param name="campaignResourceName">the campaign where the keyword will be excluded.
        /// </param>
        /// <returns>a campaign criterion object with the negative keyword targeting.</returns>
        private CampaignCriterion buildNegativeKeywordCriterion(string keywordText,
            string campaignResourceName)
        {
            return new CampaignCriterion()
            {
                Campaign = campaignResourceName,
                Negative = true,
                Keyword = new KeywordInfo()
                {
                    MatchType = KeywordMatchType.Broad,
                    Text = keywordText
                }
            };
        }

        /// <summary>
        /// Creates a negative keyword as a campaign targeting criterion.
        /// </summary>
        /// <param name="locationId">the location to target.</param>
        /// <param name="campaignResourceName">the campaign where the keyword will be excluded.
        /// </param>
        /// <returns>a campaign criterion object with the specified locationId and resource name.
        /// </returns>
        private CampaignCriterion buildLocationCriterion(long locationId,
            string campaignResourceName)
        {
            GeoTargetConstantName location = new GeoTargetConstantName(locationId.ToString());
            return new CampaignCriterion()
            {
                Campaign = campaignResourceName,
                Location = new LocationInfo()
                {
                    GeoTargetConstant = location.ToString()
                }
            };
        }

        /// <summary>
        /// Creates a proximity Criterion.
        /// </summary>
        /// <param name="campaignResourceName">the campaign where the proximity will be added.
        /// </param>
        /// <returns>a campaign criterion object with the specified locationId and resource name.
        /// </returns>
        private CampaignCriterion buildProximityCriterion(string campaignResourceName)
        {
            ProximityInfo proximity = new ProximityInfo()
            {
                Address = new AddressInfo()
                {
                    StreetAddress = "38 avenue de l'Opéra",
                    CityName = "Paris",
                    PostalCode = "75002",
                    CountryCode = "FR"
                },
                Radius = 10d,
                // Default is kilometers.
                RadiusUnits = ProximityRadiusUnits.Miles
            };

            return new CampaignCriterion()
            {
                Campaign = campaignResourceName,
                Proximity = proximity
            };
        }
    }
}

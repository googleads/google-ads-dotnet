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
using Google.Ads.GoogleAds.V3.Errors;
using Google.Ads.GoogleAds.V3.Common;
using Google.Ads.GoogleAds.V3.Services;

using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V3.Enums.DeviceEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.GenderTypeEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.ReachPlanAdLengthEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.ReachPlanAgeRangeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V3
{
    /// <summary>
    /// This example demonstrates how to interact with the ReachPlanService to find plannable
    /// locations and product codes, build a media plan, and generate a video ads reach forecast.
    /// </summary>
    public class ForecastReach : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            ForecastReach codeExample = new ForecastReach();
            Console.WriteLine(codeExample.Description);

            // The customer ID for which the call is made.
            int customerId = int.Parse("INSERT_CUSTOMER_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This example demonstrates how to interact with the ReachPlanService to " +
                    "find plannable locations and product codes, build a media plan, and " +
                    "generate a video ads reach forecast.";
            }
        }

        /// <summary>
        /// Runs the code example, showing a typical series of calls to the
        /// <see cref="Services.V3.ReachPlanService"/>.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            string locationId = "2840";  // US
            string currencyCode = "USD";
            long budgetMicros = 500_000_000_000L;
            ReachPlanServiceClient reachPlanService =
                client.GetService(Services.V3.ReachPlanService);

            try
            {
                ShowPlannableLocations(reachPlanService);
                ShowPlannableProducts(reachPlanService, locationId);
                ForecastManualMix(
                    reachPlanService, customerId.ToString(), locationId, currencyCode, budgetMicros);
                ForecastSuggestedMix(
                    reachPlanService, customerId.ToString(), locationId, currencyCode, budgetMicros);
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
        /// Maps friendly names of plannable locations to location IDs usable with
        /// <see cref="ReachPlanServiceClient"/>.
        /// </summary>
        /// <param name="reachPlanService">Instance of Reach Plan Service client.</param>
        public void ShowPlannableLocations(ReachPlanServiceClient reachPlanService)
        {
            ListPlannableLocationsRequest request = new ListPlannableLocationsRequest();
            ListPlannableLocationsResponse response = reachPlanService.ListPlannableLocations(
                request);

            Console.WriteLine("Plannable Locations:");
            Console.WriteLine("Name,\tId,\t,ParentCountryId");
            foreach (PlannableLocation location in response.PlannableLocations)
            {
                Console.WriteLine(
                    $"\"{location.Name}\",\t{location.Id},{location.ParentCountryId}");
            }
        }


        /// <summary>
        /// Lists plannable products for a given location.
        /// </summary>
        /// <param name="reachPlanService">Instance of Reach Plan Service client.</param>
        /// <param name="locationId">Location ID to plan for. To find a valid locaction ID, either
        /// see https://developers.google.com/adwords/api/docs/appendix/geotargeting or call
        /// <see cref="ReachPlanServiceClient.ListPlannableLocations"/>.</param>
        public void ShowPlannableProducts(
            ReachPlanServiceClient reachPlanService, string locationId)
        {
            ListPlannableProductsRequest request = new ListPlannableProductsRequest()
            {
                PlannableLocationId = locationId
            };
            ListPlannableProductsResponse response = reachPlanService.ListPlannableProducts(
                request);

            Console.WriteLine($"Plannable Products for location {locationId}:");
            foreach (ProductMetadata product in response.ProductMetadata)
            {
                Console.WriteLine($"{product.PlannableProductCode}:");
                Console.WriteLine("Age Ranges:");
                foreach (var ageRange in product.PlannableTargeting.AgeRanges)
                {
                    Console.WriteLine($"\t- {ageRange}");
                }
                Console.WriteLine("Genders:");
                foreach (var gender in product.PlannableTargeting.Genders)
                {
                    Console.WriteLine($"\t- {gender.Type}");
                }
                Console.WriteLine("Devices:");
                foreach (var device in product.PlannableTargeting.Devices)
                {
                    Console.WriteLine($"\t- {device.Type}");
                }
            }
        }

        /// <summary>
        /// Create a base request to generate a reach forecast.
        /// </summary>
        /// <param name="customerId">The customer ID for the reach forecast.</param>
        /// <param name="productMix">The product mix for the reach forecast.</param>
        /// <param name="locationId">Location ID to plan for. To find a valid locaction ID, either
        /// see https://developers.google.com/adwords/api/docs/appendix/geotargeting or call
        /// <see cref="ReachPlanServiceClient.ListPlannableLocations"/>.</param>
        /// <param name="currencyCode">Three-character ISO 4217 currency code.</param>
        public GenerateReachForecastRequest BuildReachRequest(
            string customerId, List<PlannedProduct> productMix, string locationId,
            string currencyCode)
        {
            // Valid durations are between 1 and 90 days.
            CampaignDuration duration = new CampaignDuration()
            {
                DurationInDays = 28
            };

            GenderInfo[] genders = new GenderInfo[]
            {
                new GenderInfo() { Type = GenderType.Female },
                new GenderInfo() { Type = GenderType.Male }
            };

            DeviceInfo[] devices = new DeviceInfo[]
            {
                new DeviceInfo() { Type = Device.Desktop },
                new DeviceInfo() { Type = Device.Mobile },
                new DeviceInfo() { Type = Device.Tablet }
            };

            Targeting targeting = new Targeting()
            {
                PlannableLocationId = locationId,
                AgeRange = ReachPlanAgeRange.AgeRange1865Up,

            };
            targeting.Genders.AddRange(genders);
            targeting.Devices.AddRange(devices);

            // See the docs for defaults and valid ranges:
            // https://developers.google.com/google-ads/api/reference/rpc/Google.Ads.GoogleAds.V3.services#Google.Ads.GoogleAds.V3.services.GenerateReachForecastRequest
            GenerateReachForecastRequest request = new GenerateReachForecastRequest()
            {
                CustomerId = customerId,
                CurrencyCode = currencyCode,
                CampaignDuration = duration,
                Targeting = targeting,
                MinEffectiveFrequency = 1
            };

            request.PlannedProducts.AddRange(productMix);

            return request;
        }

        /// <summary>
        /// Pulls and prints the reach curve for the given request.
        /// </summary>
        /// <param name="reachPlanService">Instance of Reach Plan Service client.</param>
        /// <param name="request">An already-populated reach curve request.</param>
        public void PullReachCurve(
            ReachPlanServiceClient reachPlanService, GenerateReachForecastRequest request)
        {
            GenerateReachForecastResponse response = reachPlanService.GenerateReachForecast(
                request);
            Console.WriteLine("Reach curve output:");
            Console.WriteLine(
                "Currency,\tCost Micros,\tOn-Target Reach,\tOn-Target Imprs,\tTotal Reach," +
                    "\tTotal Imprs,\tProducts");
            foreach (ReachForecast point in response.ReachCurve.ReachForecasts)
            {
                Console.Write($"{request.CurrencyCode},\t");
                Console.Write($"{point.CostMicros},\t");
                Console.Write($"{point.Forecast.OnTargetReach},\t");
                Console.Write($"{point.Forecast.OnTargetImpressions},\t");
                Console.Write($"{point.Forecast.TotalReach},\t");
                Console.Write($"{point.Forecast.TotalImpressions},\t");
                Console.Write($"\"[");
                foreach (ProductAllocation product in point.ForecastedProductAllocations)
                {
                    Console.Write($"(Product: {product.PlannableProductCode}, ");
                    Console.Write($"Budget Micros: {product.BudgetMicros}), ");
                }
                Console.WriteLine($"]\"");
            }
        }

        /// <summary>
        /// Pulls a forecast for a budget split 15% and 85% between two products.
        /// </summary>
        /// <param name="reachPlanService">Instance of Reach Plan Service client.</param>
        /// <param name="customerId">The customer ID for the reach forecast.</param>
        /// <param name="locationId">Location ID to plan for. To find a valid locaction ID, either
        /// see https://developers.google.com/adwords/api/docs/appendix/geotargeting or call
        /// <see cref="ReachPlanServiceClient.ListPlannableLocations"/>.</param>
        /// <param name="currencyCode">Three-character ISO 4217 currency code.</param>
        /// <param name="budgetMicros">Budget in currency to plan for.</param>
        public void ForecastManualMix(
                        ReachPlanServiceClient reachPlanService,
                        string customerId,
                        string locationId,
                        string currencyCode,
                        long budgetMicros)
        {
            List<PlannedProduct> productMix = new List<PlannedProduct>();

            // Set up a ratio to split the budget between two products.
            double trueviewAllocation = 0.15;
            double bumperAllocation = 1 - trueviewAllocation;

            // See listPlannableProducts on ReachPlanService to retrieve a list
            // of valid PlannableProductCode's for a given location:
            // https://developers.google.com/google-ads/api/reference/rpc/Google.Ads.GoogleAds.V3.services#reachplanservice
            productMix.Add(new PlannedProduct()
            {
                PlannableProductCode = "TRUEVIEW_IN_STREAM",
                BudgetMicros = Convert.ToInt64((double)budgetMicros * trueviewAllocation)
            });
            productMix.Add(new PlannedProduct()
            {
                PlannableProductCode = "BUMPER",
                BudgetMicros = Convert.ToInt64((double)budgetMicros * bumperAllocation)
            });

            GenerateReachForecastRequest request =
                BuildReachRequest(customerId, productMix, locationId, currencyCode);

            PullReachCurve(reachPlanService, request);
        }

        /// <summary>
        /// Pulls a forecast for a product mix suggested based on preferences for whether the ad
        /// would have a guaranteed price, play with sound, would be skippable, would include top
        /// content, and a desired ad length.
        /// </summary>
        /// <param name="reachPlanService">Instance of Reach Plan Service client.</param>
        /// <param name="customerId">The customer ID for the reach forecast.</param>
        /// <param name="locationId">Location ID to plan for. To find a valid locaction ID, either
        /// see https://developers.google.com/adwords/api/docs/appendix/geotargeting or call
        /// <see cref="ReachPlanServiceClient.ListPlannableLocations"/>.</param>
        /// <param name="currencyCode">Three-character ISO 4217 currency code.</param>
        /// <param name="budgetMicros">Budget in currency micro-units to plan for.</param>
        public void ForecastSuggestedMix(
            ReachPlanServiceClient reachPlanService,
            string customerId,
            string locationId,
            string currencyCode,
            long budgetMicros)
        {
            // Note: If preferences are too restrictive, then the response will be empty.
            Preferences preferences = new Preferences()
            {
                HasGuaranteedPrice = true,
                StartsWithSound = true,
                IsSkippable = false,
                TopContentOnly = true,
                AdLength = ReachPlanAdLength.FifteenOrTwentySeconds
            };

            GenerateProductMixIdeasRequest mixRequest = new GenerateProductMixIdeasRequest()
            {
                BudgetMicros = Convert.ToInt64((double)budgetMicros),
                CurrencyCode = currencyCode,
                CustomerId = customerId,
                PlannableLocationId = locationId,
                Preferences = preferences
            };

            GenerateProductMixIdeasResponse mixResponse =
                reachPlanService.GenerateProductMixIdeas(mixRequest);

            List<PlannedProduct> productMix = new List<PlannedProduct>();

            foreach (ProductAllocation product in mixResponse.ProductAllocation)
            {
                productMix.Add(
                    new PlannedProduct()
                    {
                        PlannableProductCode = product.PlannableProductCode,
                        BudgetMicros = product.BudgetMicros
                    });
            }

            GenerateReachForecastRequest curveRequest =
                BuildReachRequest(customerId, productMix, locationId, currencyCode);

            PullReachCurve(reachPlanService, curveRequest);
        }
    }
}

// Copyright 2023 Google LLC
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
using Google.Ads.GoogleAds.V17.Common;
using Google.Ads.GoogleAds.V17.Errors;
using Google.Ads.GoogleAds.V17.Resources;
using Google.Ads.GoogleAds.V17.Services;
using System;
using static Google.Ads.GoogleAds.V17.Enums.KeywordMatchTypeEnum.Types;
using static Google.Ads.GoogleAds.V17.Enums.KeywordPlanNetworkEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V17;

/// <summary>
/// This code example generates forecast metrics for keyword planning.
/// Guide: https://developers.google.com/google-ads/api/docs/keyword-planning/generate-forecast-metrics
/// </summary>
public class GenerateForecastMetrics : ExampleBase
{
    /// <summary>
    /// Command line options for running the <see cref="GenerateForecastMetrics"/> example.
    /// </summary>
    public class Options : OptionsBase
    {
        /// <summary>
        /// The customer ID for which the call is made.
        /// </summary>
        [Option("customerId", Required = true, HelpText =
            "The customer ID for which the call is made.")]
        public long CustomerId { get; set; }
    }

    /// <summary>
    /// Main method, to run this code example as a standalone application.
    /// </summary>
    /// <param name="args">The command line arguments.</param>
    public static void Main(string[] args)
    {
        Options options = ExampleUtilities.ParseCommandLine<Options>(args);

        GenerateForecastMetrics codeExample = new GenerateForecastMetrics();
        Console.WriteLine(codeExample.Description);
        codeExample.Run(new GoogleAdsClient(), options.CustomerId);
    }

    /// <summary>
    /// Returns a description about the code example.
    /// </summary>
    public override string Description =>
        "This code example generates forecast metrics for keyword planning.";

    /// <summary>
    /// Runs the code example.
    /// </summary>
    /// <param name="client">The Google Ads client.</param>
    /// <param name="customerId">The customer ID for which the call is made.</param>
    // [START generate_forecast_metrics]
    public void Run(GoogleAdsClient client, long customerId)
    {
        CampaignToForecast campaignToForecast = CreateCampaignToForecast();

        KeywordPlanIdeaServiceClient keywordPlanIdeaService =
                client.GetService(Services.V17.KeywordPlanIdeaService);

        GenerateKeywordForecastMetricsRequest request = new GenerateKeywordForecastMetricsRequest()
        {
            CustomerId = customerId.ToString(),
            Campaign = campaignToForecast,
            ForecastPeriod = new DateRange()
            {
                // Set the forecast start date to tomorrow.
                StartDate = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"),
                // Set the forecast end date to 30 days from today.
                EndDate = DateTime.Now.AddDays(30).ToString("yyyy-MM-dd"),
            }
        };

        try
        {
            GenerateKeywordForecastMetricsResponse response =
                keywordPlanIdeaService.GenerateKeywordForecastMetrics(request);

            KeywordForecastMetrics metrics = response.CampaignForecastMetrics;

            Console.WriteLine($"Estimated daily clicks: {metrics.Clicks}.");
            Console.WriteLine($"Estimated daily impressions: {metrics.Impressions}.");
            Console.WriteLine($"Estimated average cpc (micros): {metrics.AverageCpcMicros}.");
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
    /// Creates the campaign to forecast. A campaign to forecast lets you try out
    /// various configuration and keywords to find the best optimization for your
    /// future campaigns. Once you've found the best campaign configuration,
    /// create a serving campaign in your Google Ads account with similar values
    /// and keywords. For more details, see:
    /// https://support.google.com/google-ads/answer/3022575
    /// </summary>
    private CampaignToForecast CreateCampaignToForecast()
    {
        CampaignToForecast campaignToForecast = new CampaignToForecast()
        {
            KeywordPlanNetwork = KeywordPlanNetwork.GoogleSearch,
            BiddingStrategy = new CampaignToForecast.Types.CampaignBiddingStrategy()
            {
                ManualCpcBiddingStrategy = new ManualCpcBiddingStrategy()
                {
                    MaxCpcBidMicros = 1_000_000
                }
            }
        };

        // See https://developers.google.com/google-ads/api/reference/data/geotargets
        // for the list of geo target IDs.
        campaignToForecast.GeoModifiers.Add(new CriterionBidModifier()
        {
            // Geo target constant 2840 is for USA.
            GeoTargetConstant = ResourceNames.GeoTargetConstant(2840)
        });

        // See https://developers.google.com/google-ads/api/reference/data/codes-formats#languages
        // for the list of language criteria IDs.
        // Language constant 1000 is for English.
        campaignToForecast.LanguageConstants.Add(ResourceNames.LanguageConstant(1000));

        // Create forecast ad group based on themes such as creative relevance, product category,
        // or cost per click.
        ForecastAdGroup forecastAdGroup = new ForecastAdGroup();

        forecastAdGroup.BiddableKeywords.Add(new BiddableKeyword()
        {
            MaxCpcBidMicros = 2_500_000,
            Keyword = new KeywordInfo()
            {
                Text = "mars cruise",
                MatchType = KeywordMatchType.Broad
            }
        });

        forecastAdGroup.BiddableKeywords.Add(new BiddableKeyword()
        {
            MaxCpcBidMicros = 1_500_000,
            Keyword = new KeywordInfo()
            {
                Text = "cheap cruise",
                MatchType = KeywordMatchType.Phrase
            }
        });

        forecastAdGroup.BiddableKeywords.Add(new BiddableKeyword()
        {
            MaxCpcBidMicros = 1_990_000,
            Keyword = new KeywordInfo()
            {
                Text = "jupiter cruise",
                MatchType = KeywordMatchType.Broad
            }
        });

        forecastAdGroup.NegativeKeywords.Add(new KeywordInfo()
        {
            Text = "moon walk",
            MatchType = KeywordMatchType.Broad
        });

        campaignToForecast.AdGroups.Add(forecastAdGroup);

        return campaignToForecast;
    }
    // [END generate_forecast_metrics]
}
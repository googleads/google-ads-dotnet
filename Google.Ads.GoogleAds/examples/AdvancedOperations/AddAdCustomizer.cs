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
using Google.Ads.Gax.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V11.Common;
using Google.Ads.GoogleAds.V11.Errors;
using Google.Ads.GoogleAds.V11.Resources;
using Google.Ads.GoogleAds.V11.Services;
using System;
using System.Collections.Generic;
using Google.Ads.GoogleAds.V11.Enums;
using static Google.Ads.GoogleAds.V11.Enums.CustomizerAttributeTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V11
{
    /// <summary>
    /// This code example adds an ad customizer feed and associates it with the customer.
    /// Then it adds an ad that uses the feed to populate dynamic data.
    /// </summary>
    public class AddAdCustomizer : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddAdCustomizer"/> example.
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
            /// ID of the ad groups to which ad customizers are added.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "ID of the ad group to which ad customizers are added.")]
            public long AdGroupId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddAdCustomizer codeExample = new AddAdCustomizer();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId,
                options.AdGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds an ad customizer feed and associates it with the customer. " +
            "Then it adds an ad that uses the feed to populate dynamic data.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">ID of the ad groups to which ad customizers are added.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId)
        {            
            // Get the AdGroupBidModifierService.
            AdGroupBidModifierServiceClient adGroupBidModifierService =
                client.GetService(Services.V11.AdGroupBidModifierService);

            string stringCustomizerName = "Planet_" + ExampleUtilities.GetShortRandomString();
            string priceCustomizerName = "Price_" + ExampleUtilities.GetShortRandomString();

            try
            {
                // Create ad customizer attributes.
                string textCustomizerAttributeResourceName =
                    CreateTextCustomizerAttribute(client, customerId, stringCustomizerName);
                string priceCustomizerAttributeResourceName =
                    CreatePriceCustomizerAttributes(client, customerId, priceCustomizerName);

                // Link the customizer attributes to the ad group.
                LinkCustomizerAttributes(client, customerId, adGroupId,
                    textCustomizerAttributeResourceName, priceCustomizerAttributeResourceName);
                
                // Create ads with the customizations provided by the feed items.
                CreateAdsWithCustomizations(client, customerId, adGroupId,
                    stringCustomizerName, priceCustomizerName);
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
        /// Creates a text customizer attribute ad returns its resource name.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>        
        /// <param name="customizerName">The name of the customizer to create.</param>
        // [START add_ad_customizer]
        private string CreateTextCustomizerAttribute(GoogleAdsClient client, long customerId,
            string customizerName)
        {
            CustomizerAttributeServiceClient customizerAttributeService = 
                client.GetService(Services.V11.CustomizerAttributeService);

            CustomizerAttribute nameAttribute = new CustomizerAttribute()
            {
                Name = customizerName,
                Type = CustomizerAttributeType.Text
            };

            CustomizerAttributeOperation nameAttributeOperation = new CustomizerAttributeOperation(){
                Create = nameAttribute
            };

            MutateCustomizerAttributesResponse response =
                customizerAttributeService.MutateCustomizerAttributes(customerId.ToString(),
                    new[] {nameAttributeOperation});

            string customizerAttributeResourceName = response.Results[0].ResourceName; 
            Console.WriteLine($"Added name customizer attribute with resource name" +
                $" '{customizerAttributeResourceName}'.");

            return customizerAttributeResourceName;
        }
        // [END add_ad_customizer]

        /// <summary>
        /// Creates a price customizer attribute ad returns its resource name.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>        
        /// <param name="customizerName">The name of the customizer to create.</param>
        // [START add_ad_customizer_1]
        private string CreatePriceCustomizerAttributes(GoogleAdsClient client, long customerId,
            string customizerName)
        {
            CustomizerAttributeServiceClient customizerAttributeService = 
                client.GetService(Services.V11.CustomizerAttributeService);
    
            CustomizerAttribute priceAttribute = new CustomizerAttribute()
            {
                Name = customizerName,
                Type = CustomizerAttributeType.Price
            };
    
            CustomizerAttributeOperation priceAttributeOperation = new CustomizerAttributeOperation(){
                Create = priceAttribute
            };

            List<string> customizerAttributeResourceNames = new List<string>();
            MutateCustomizerAttributesResponse response =
                customizerAttributeService.MutateCustomizerAttributes(customerId.ToString(),
                    new[] {priceAttributeOperation});

            string customizerAttributeResourceName = response.Results[0].ResourceName; 
            Console.WriteLine($"Added price customizer attribute with resource name" +
                $" '{customizerAttributeResourceName}'.");

            return customizerAttributeResourceName;
        }
        // [END add_ad_customizer_1]

        /// <summary>
        /// Restricts the customizer attributes to work only with a specific ad group; this prevents
        /// the customizer attributes from being used elsewhere and makes sure they are used only for
        /// customizing a specific ad group.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ad group ID to bind the customizer attributes to.</param>
        /// <param name="textCustomizerAttributeResourceName">The resource name of the text customizer attribute.</param>
        /// <param name="priceCustomizerAttributeResourceName">The resource name of the price customizer attribute.</param>
        // [START add_ad_customizer_2]
        private void LinkCustomizerAttributes(GoogleAdsClient client,
            long customerId, long adGroupId,
            string textCustomizerAttributeResourceName,
            string priceCustomizerAttributeResourceName)
        {
            AdGroupCustomizerServiceClient adGroupCustomizerService =
                client.GetService(Services.V11.AdGroupCustomizerService);

            List<AdGroupCustomizerOperation> adGroupCustomizerOperations =
                new List<AdGroupCustomizerOperation>();

            AdGroupCustomizer marsCustomizer = new AdGroupCustomizer(){
                CustomizerAttribute = textCustomizerAttributeResourceName,
                Value = new CustomizerValue(){
                    Type = CustomizerAttributeType.Text,
                    StringValue = "Mars"
                },
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId)
            };
            adGroupCustomizerOperations.Add(new AdGroupCustomizerOperation(){
                Create = marsCustomizer
            });

            AdGroupCustomizer priceCustomizer = new AdGroupCustomizer(){
                CustomizerAttribute = priceCustomizerAttributeResourceName,
                Value = new CustomizerValue(){
                    Type = CustomizerAttributeType.Price,
                    StringValue = "100.0€"
                },
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId)
            };
            adGroupCustomizerOperations.Add(new AdGroupCustomizerOperation(){
                Create = priceCustomizer
            });                        

            MutateAdGroupCustomizersResponse response =                
                adGroupCustomizerService.MutateAdGroupCustomizers(customerId.ToString(),
                    adGroupCustomizerOperations);

            foreach (MutateAdGroupCustomizerResult result in response.Results)
            {
                Console.WriteLine($"Added an ad group customizer with resource name '{result.ResourceName}'.");
            }
        }
        // [END add_ad_customizer_2]

        /// <summary>
        /// Creates responsive search ads that use the ad customizer feed to populate the placeholders.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ad group IDs in which to create the ads.</param>
        /// <param name="stringCustomizerName">Name of the string customizer.</param>
        /// <param name="priceCustomizerName">Name of the price customizer.</param>
        // [START add_ad_customizer_3]
        private void CreateAdsWithCustomizations(GoogleAdsClient client, long customerId,
            long adGroupId, string stringCustomizerName, string priceCustomizerName)
        {
            // Get the AdGroupAdServiceClient.
            AdGroupAdServiceClient adGroupAdService =
                client.GetService(Services.V11.AdGroupAdService);

            // Creates a responsive search ad using the feed attribute names as placeholders.
            Ad ad = new Ad()
            {
                ResponsiveSearchAd = new ResponsiveSearchAdInfo()
                {
                    Headlines =
                    {
                        new AdTextAsset()
                        {
                            Text = $"Luxury cruise to {{CUSTOMIZER.{stringCustomizerName}:Venus}}",
                            PinnedField = ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Headline1
                        },
                        new AdTextAsset() { Text = $"Only {{CUSTOMIZER.{priceCustomizerName}:10.0€}}" },
                        new AdTextAsset()
                        {
                            Text = $"Cruise to {{CUSTOMIZER.{stringCustomizerName}:Venus}} for {{CUSTOMIZER.{priceCustomizerName}:10.0€}}"
                        }
                    },
                    Descriptions =
                    {
                        new AdTextAsset() { Text = $"Tickets are only {{CUSTOMIZER.{priceCustomizerName}:10.0€}}!" },
                        new AdTextAsset() { Text = $"Buy your tickets to {{CUSTOMIZER.{stringCustomizerName}:Venus}} now!" }
                    }
                },
                FinalUrls = { "http://www.example.com" }
            };

            List<AdGroupAdOperation> adGroupAdOperations = new List<AdGroupAdOperation>();
            
            AdGroupAd adGroupAd = new AdGroupAd()
            {
                Ad = ad,
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId)
            };

            adGroupAdOperations.Add(new AdGroupAdOperation()
            {
                Create = adGroupAd
            });    

            MutateAdGroupAdsResponse response =
                adGroupAdService.MutateAdGroupAds(customerId.ToString(), adGroupAdOperations);

            Console.WriteLine($"Added {response.Results.Count} ads:");
            foreach (MutateAdGroupAdResult result in response.Results)
            {
                Console.WriteLine($"Added an ad with resource name '{result.ResourceName}'.");
            }
        }
        // [END add_ad_customizer_3]
    }
}

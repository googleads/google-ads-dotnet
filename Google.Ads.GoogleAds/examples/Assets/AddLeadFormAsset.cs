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
using Google.Ads.GoogleAds.V20.Common;
using Google.Ads.GoogleAds.V20.Errors;
using Google.Ads.GoogleAds.V20.Resources;
using Google.Ads.GoogleAds.V20.Services;
using System;
using static Google.Ads.GoogleAds.V20.Enums.LeadFormCallToActionTypeEnum.Types;
using static Google.Ads.GoogleAds.V20.Enums.LeadFormFieldUserInputTypeEnum.Types;
using static Google.Ads.GoogleAds.V20.Enums.LeadFormPostSubmitCallToActionTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V20
{
    /// <summary>
    /// This code example creates a lead form asset for a campaign. Run
    /// AddCampaigns.cs to create a campaign.
    /// </summary>
    public class AddLeadFormAsset : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddLeadFormAsset"/> example.
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
            /// ID of the campaign to which lead form assets are added.
            /// </summary>
            [Option("campaignId", Required = true, HelpText =
                "ID of the campaign to which lead form assets are added.")]
            public long CampaignId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddLeadFormAsset codeExample = new AddLeadFormAsset();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.CampaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example creates a lead form for a campaign. " +
            "Run AddCampaigns.cs to create a campaign.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="campaignId">
        /// ID of the campaign to which lead form assets are added.
        /// </param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            try
            {
                // Create a lead form asset.
                string leadFormAssetResourceName = CreateLeadFormAsset(client, customerId);
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
        /// Creates the lead form asset.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <returns>The lead form asset resource name.</returns>
        // [START add_lead_form_asset]
        private string CreateLeadFormAsset(GoogleAdsClient client, long customerId)
        {
            AssetServiceClient assetService = client.GetService(Services.V20.AssetService);

            // Creates the lead form asset.
            Asset leadFormAsset = new Asset()
            {
                Name = $"Interplanetary Cruise #{ExampleUtilities.GetRandomString()} Lead Form",
                LeadFormAsset = new LeadFormAsset()
                {
                    // Specify the details of the asset that the users will see.
                    CallToActionType = LeadFormCallToActionType.BookNow,
                    CallToActionDescription = "Latest trip to Jupiter!",

                    // Define the form details.
                    BusinessName = "Interplanetary Cruise",
                    Headline = "Trip to Jupiter",
                    Description = "Our latest trip to Jupiter is now open for booking.",
                    PrivacyPolicyUrl = "http://example.com/privacy",

                    // Define the fields to be displayed to the user.
                    Fields = {
                        new LeadFormField()
                        {
                            InputType = LeadFormFieldUserInputType.FullName,
                        },
                        new LeadFormField()
                        {
                            InputType = LeadFormFieldUserInputType.Email,
                        },
                        new LeadFormField()
                        {
                            InputType = LeadFormFieldUserInputType.PhoneNumber,
                        },
                        new LeadFormField()
                        {
                            InputType = LeadFormFieldUserInputType.PreferredContactTime,
                            SingleChoiceAnswers = new LeadFormSingleChoiceAnswers()
                            {
                                Answers = { "Before 9 AM", "Any time", "After 5 PM" }
                            }
                        },
                        new LeadFormField()
                        {
                            InputType = LeadFormFieldUserInputType.TravelBudget,
                        },
                    },

                    // Optional: You can also specify a background image asset. To upload an asset,
                    // see Misc/UploadImageAsset.cs. BackgroundImageAsset =
                    // "INSERT_IMAGE_ASSET_HERE",

                    // Optional: Define the response page after the user signs up on the form.
                    PostSubmitHeadline = "Thanks for signing up!",
                    PostSubmitDescription = "We will reach out to you shortly. Visit our website " +
                    "to see past trip details.",
                    PostSubmitCallToActionType = LeadFormPostSubmitCallToActionType.VisitSite,

                    // Optional: Display a custom disclosure that displays along with the Google
                    // disclaimer on the form.
                    CustomDisclosure = "Trip may get cancelled due to meteor shower.",

                    // Optional: Define a delivery method for the form response. See
                    // https://developers.google.com/google-ads/webhook/docs/overview for more
                    // details on how to define a webhook.
                    DeliveryMethods =
                    {
                        new LeadFormDeliveryMethod()
                        {
                            Webhook = new WebhookDelivery()
                            {
                                AdvertiserWebhookUrl = "http://example.com/webhook",
                                GoogleSecret = "interplanetary google secret",
                                PayloadSchemaVersion = 3L
                            }
                        }
                    },
                },
                FinalUrls = { "http://example.com/jupiter" }
            };

            // Creates the operation.
            AssetOperation operation = new AssetOperation()
            {
                Create = leadFormAsset,
            };

            // Makes the API call.
            MutateAssetsResponse response = assetService.MutateAssets(customerId.ToString(),
                new[] { operation });

            string leadFormAssetResourceName = response.Results[0].ResourceName;

            // Displays the result.
            Console.WriteLine($"Asset with resource name = '{leadFormAssetResourceName}' " +
                "was created.");
            return leadFormAssetResourceName;
        }
        // [END add_lead_form_asset]
    }
}

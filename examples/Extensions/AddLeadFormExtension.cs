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

using System;
using System.Collections.Generic;
using System.Linq;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V6.Common;
using Google.Ads.GoogleAds.V6.Enums;
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;
using static Google.Ads.GoogleAds.V6.Enums.AssetLinkStatusEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.FeedAttributeTypeEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.LeadFormCallToActionTypeEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.LeadFormFieldUserInputTypeEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.LeadFormPostSubmitCallToActionTypeEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.SitelinkPlaceholderFieldEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example creates a lead form and a lead form extension for a campaign. Run
    /// AddCampaigns.cs to create a campaign.
    /// </summary>
    public class AddLeadFormExtension : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddLeadFormExtension codeExample = new AddLeadFormExtension();
            Console.WriteLine(codeExample.Description);

            // The customer ID for which the call is made.
            int customerId = int.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the campaign to which lead form extesions are added.
            long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, campaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example creates a lead form and a lead form extension for a campaign. " +
            "Run AddCampaigns.cs to create a campaign.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to which lead form extensions are
        /// added.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            try
            {
                // Create a lead form asset.
                string leadFormAssetResourceName = CreateLeadFormAsset(client, customerId);

                // Create a lead form extension for the campaign.
                CreateLeadFormExtension(client, customerId, campaignId, leadFormAssetResourceName);
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
        /// Creates the lead form extension.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to which lead form extensions are
        /// added.</param>
        /// <param name="leadFormAssetResourceName">The lead form asset resource name.</param>
        // [START AddLeadFormExtension_1]
        private void CreateLeadFormExtension(GoogleAdsClient client, long customerId,
            long campaignId, string leadFormAssetResourceName)
        {
            CampaignAssetServiceClient campaignAssetService = client.GetService(
                Services.V6.CampaignAssetService);

            // Creates the campaign asset for the lead form.
            CampaignAsset campaignAsset = new CampaignAsset()
            {
                Asset = leadFormAssetResourceName,
                FieldType = AssetFieldTypeEnum.Types.AssetFieldType.LeadForm,
                Campaign = ResourceNames.Campaign(customerId, campaignId),
            };

            CampaignAssetOperation operation = new CampaignAssetOperation()
            {
                Create = campaignAsset
            };

            MutateCampaignAssetsResponse response = campaignAssetService.MutateCampaignAssets(
                customerId.ToString(), new[] { operation });

            foreach (MutateCampaignAssetResult result in response.Results)
            {
                Console.WriteLine("Created campaign asset with resource name =" +
                    $" '{result.ResourceName}' for campaign ID {campaignId}.");
            }
        }
        // [END AddLeadFormExtension_1]

        /// <summary>
        /// Creates the lead form asset.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <returns>The lead form asset resource name.</returns>
        // [START AddLeadFormExtension]
        private string CreateLeadFormAsset(GoogleAdsClient client, long customerId)
        {
            AssetServiceClient assetService = client.GetService(Services.V6.AssetService);

            // Creates the lead form asset.
            Asset leadFormAsset = new Asset()
            {
                Name = $"Interplanetary Cruise #{ExampleUtilities.GetRandomString()} Lead Form",
                LeadFormAsset = new LeadFormAsset()
                {
                    // Specify the details of the extension that the users will see.
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

                    // Optional: You can also specify a background image asset.
                    // To upload an asset, see Misc/UploadImageAsset.cs.
                    // BackgroundImageAsset = "INSERT_IMAGE_ASSET_HERE",

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
        // [END AddLeadFormExtension]
    }
}

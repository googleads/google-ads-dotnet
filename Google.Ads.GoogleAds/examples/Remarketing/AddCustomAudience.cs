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

using CommandLine;
using Google.Ads.Gax.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V13.Errors;
using Google.Ads.GoogleAds.V13.Resources;
using Google.Ads.GoogleAds.V13.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V13.Enums.CustomAudienceMemberTypeEnum.Types;
using static Google.Ads.GoogleAds.V13.Enums.CustomAudienceStatusEnum.Types;
using static Google.Ads.GoogleAds.V13.Enums.CustomAudienceTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V13
{
    /// <summary>
    /// This example illustrates adding a custom audience. Custom audiences help you reach your
    /// ideal audience by entering relevant keywords, URLs and apps. For more information about
    /// custom audiences, see:
    /// https://support.google.com/google-ads/answer/9805516.
    /// </summary>
    public class AddCustomAudience : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddCustomAudience"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the conversion action is added.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the conversion action is added.")]
            public long CustomerId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddCustomAudience codeExample = new AddCustomAudience();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example illustrates adding a custom audience. Custom audiences help you reach " +
            "your ideal audience by entering relevant keywords, URLs and apps. For more " +
            "information about custom audiences, see:" +
            "https://support.google.com/google-ads/answer/9805516.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the conversion action is
        /// added.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the CustomAudienceService client.
            CustomAudienceServiceClient customAudienceServiceClient =
                client.GetService(Services.V13.CustomAudienceService);

            // Create a custom audience.
            CustomAudience customAudience = new CustomAudience
            {
                Name = $"Example CustomAudience #{ExampleUtilities.GetRandomString()}",
                Description = "Custom audiences who have searched specific terms on Google Search",
                // Match customers by what they searched on Google Search.
                // Note: "INTEREST" OR "PURCHASE_INTENT" is not allowed for the type field of newly
                // created custom audience. Use "AUTO" instead of these 2 options when creating a
                // new custom audience.
                Type = CustomAudienceType.Search,
                Status = CustomAudienceStatus.Enabled,
            };

            // Add custom audience members to the custom audience. Customers that meet any of the
            // membership conditions will be reached.
            // Keywords or keyword phrases, which describe the customers' interests or search terms.
            customAudience.Members.Add(CreateCustomAudienceMember(CustomAudienceMemberType.Keyword,
                "mars cruise"));
            customAudience.Members.Add(CreateCustomAudienceMember(CustomAudienceMemberType.Keyword,
                "jupiter cruise"));
            // Website URLs that your customers might visit.
            customAudience.Members.Add(CreateCustomAudienceMember(CustomAudienceMemberType.Url,
                "http://www.example.com/locations/mars"));
            customAudience.Members.Add(CreateCustomAudienceMember(CustomAudienceMemberType.Url,
                "http://www.example.com/locations/jupiter"));
            // Package names of Android apps which customers might install.
            customAudience.Members.Add(CreateCustomAudienceMember(CustomAudienceMemberType.App,
                "com.google.android.apps.adwords"));

            // Create a custom audience operation.
            CustomAudienceOperation customAudienceOperation = new CustomAudienceOperation
            {
                Create = customAudience
            };

            try
            {
                // Add the custom audience and display the results.
                MutateCustomAudiencesResponse customAudiencesResponse = customAudienceServiceClient
                    .MutateCustomAudiences(customerId.ToString(), new[] { customAudienceOperation });

                Console.WriteLine("New custom audience added with resource name: " +
                    $"'{customAudiencesResponse.Results.First().ResourceName}'.");
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
        /// Creates a custom audience member.
        /// </summary>
        /// <param name="memberType">The intended type of the new audience member.</param>
        /// <param name="value">The custom value to assign to the new audience member.</param>
        /// <returns></returns>
        public CustomAudienceMember CreateCustomAudienceMember(CustomAudienceMemberType memberType,
            string value)
        {
            CustomAudienceMember customAudienceMember = new CustomAudienceMember
            {
                MemberType = memberType
            };

            switch (memberType)
            {
                case CustomAudienceMemberType.Keyword:
                    customAudienceMember.Keyword = value;
                    break;

                case CustomAudienceMemberType.Url:
                    customAudienceMember.Url = value;
                    break;

                case CustomAudienceMemberType.App:
                    customAudienceMember.App = value;
                    break;
            }

            return customAudienceMember;
        }
    }
}

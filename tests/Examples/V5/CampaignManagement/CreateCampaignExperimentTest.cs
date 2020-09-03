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

using Google.Ads.GoogleAds.Examples.V5;
using Google.Ads.GoogleAds.V5.Resources;
using NUnit.Framework;

namespace Google.Ads.GoogleAds.Tests.Examples.V5
{
    /// <summary>
    /// Tests the CreateCampaignExperiment code example.
    /// </summary>
    [TestFixture]
    [Category("CodeExamples")]
    internal class CreateCampaignExperimentTest : ExampleTestsBase
    {
        /// <summary>
        /// The base campaign ID for test purposes.
        /// </summary>
        private long campaignId;

        /// <summary>
        /// The campaign draft ID for test purposes.
        /// </summary>
        private long draftId;

        /// <summary>
        /// Inits this instance.
        /// </summary>
        [SetUp]
        public void Init()
        {
            string budgetResourceName = ExampleTestsUtils.CreateBudget(client, false);
            string campaignResourceName = ExampleTestsUtils.CreateCampaign(client,
                budgetResourceName);
            campaignId = long.Parse(CampaignName.Parse(campaignResourceName).CampaignId);
            string campaignDraftResourceName = ExampleTestsUtils.CreateCampaignDraft(client,
                config.ClientCustomerId, campaignId);
            draftId = long.Parse(CampaignDraftName.Parse(campaignDraftResourceName)
                .CampaignDraftId);
        }

        /// <summary>
        /// Tests the Run method.
        /// </summary>
        [Test]
        public void TestRun()
        {
            RunExample(delegate ()
            {
                new CreateCampaignExperiment().Run(client, config.ClientCustomerId,
                    campaignId, draftId);
            });
        }
    }
}

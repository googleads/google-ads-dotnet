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

using Google.Ads.GoogleAds.Examples.V4;
using NUnit.Framework;

namespace Google.Ads.GoogleAds.Tests.Examples.V4
{
    /// <summary>
    /// Tests the AddAffiliateLocationExtensions code example.
    /// </summary>
    [TestFixture]
    [Category("CodeExamples")]
    internal class AddAffiliateLocationExtensionsTest : ExampleTestsBase
    {
        /// <summary>
        /// The campaign ID for running tests.
        /// </summary>
        private long campaignId;

        /// <summary>
        /// The CVS chain identifier. See https://developers.google.com/adwords/api/docs/appendix/codes-formats#chain-ids
        /// for allowed list of IDs.
        /// </summary>
        private const long CVS_CHAIN_ID = 100013;
        /// <summary>
        /// Inits this instance.
        /// </summary>
        [SetUp]
        public void Init()
        {
            string budgetResourceName = ExampleTestsUtils.CreateBudget(client);
            string campaignResourceName = ExampleTestsUtils.CreateCampaign(client,
                budgetResourceName);
            campaignId = ExampleTestsUtils.GetCampaign(client, campaignResourceName);
        }

        /// <summary>
        /// Tests the Run method.
        /// </summary>
        [Test]
        public void TestRun()
        {
            RunExample(delegate ()
            {
                new AddAffiliateLocationExtensions().Run(client, config.ClientCustomerId,
                    CVS_CHAIN_ID, campaignId);
            });
        }
    }
}

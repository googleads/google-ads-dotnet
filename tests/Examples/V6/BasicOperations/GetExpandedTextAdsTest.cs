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

using NUnit.Framework;
using Google.Ads.GoogleAds.Examples.V6;

namespace Google.Ads.GoogleAds.Tests.Examples.V6
{
    /// <summary>
    /// Tests the GetExpandedTextAds code example.
    /// </summary>
    [TestFixture]
    [Category("CodeExamples")]
    internal class GetExpandedTextAdsTest : ExampleTestsBase
    {
        /// <summary>
        /// The ad group ID for test purposes.
        /// </summary>
        private long adGroupId;

        /// <summary>
        /// Inits this instance.
        /// </summary>
        [SetUp]
        public void Init()
        {
            string budgetResourceName = ExampleTestsUtils.CreateBudget(client);
            string campaignResourceName = ExampleTestsUtils.CreateCampaign(client, budgetResourceName);
            string adGroupResourceName = ExampleTestsUtils.CreateAdGroup(client, campaignResourceName);
            adGroupId = ExampleTestsUtils.GetAdGroup(client, adGroupResourceName);

            string adGroupAd1ResourceName = ExampleTestsUtils.CreateExpandedTextAd(
                client, adGroupResourceName);
            string adGroupAd2ResourceName = ExampleTestsUtils.CreateExpandedTextAd(
                client, adGroupResourceName);
        }

        /// <summary>
        /// Tests the Run method.
        /// </summary>
        [Test]
        public void TestRun()
        {
            RunExample(delegate ()
            {
                new GetExpandedTextAds().Run(client, config.ClientCustomerId, adGroupId);
            });
        }

        /// <summary>
        /// Tests the Run method.
        /// </summary>
        [Test]
        public void TestRunEmptyAdGroupId()
        {
            RunExample(delegate ()
            {
                new GetExpandedTextAds().Run(client, config.ClientCustomerId, null);
            });
        }
    }
}

// Copyright 2026 Google LLC
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

using Google.Ads.Gax.Logging;
using Google.Ads.GoogleAds.Logging;
using Google.Protobuf.WellKnownTypes;
using NUnit.Framework;
using V24Resources = Google.Ads.GoogleAds.V24.Resources;
using V24Services = Google.Ads.GoogleAds.V24.Services;
using V25Resources = Google.Ads.GoogleAds.V25.Resources;
using V25Services = Google.Ads.GoogleAds.V25.Services;

namespace Google.Ads.GoogleAds.Tests.Logging
{
    /// <summary>
    /// Tests for <see cref="LogFormatter"/> class covering LocalServicesLead masking.
    /// </summary>
    [TestFixture]
    [Category("Smoke")]
    internal class LogFormatterTests
    {
        private ILogFormatter logFormatter = new LogFormatter();

        /// <summary>
        /// Test masking LocalServicesLead in V24 response.
        /// </summary>
        [Test]
        public void TestMaskLocalServicesLeadV24()
        {
            V24Services.SearchGoogleAdsResponse response = new V24Services.SearchGoogleAdsResponse
            {
                FieldMask = new FieldMask
                {
                    Paths = { "local_services_lead.contact_details" }
                }
            };
            V24Services.GoogleAdsRow row = new V24Services.GoogleAdsRow
            {
                LocalServicesLead = new V24Resources.LocalServicesLead
                {
                    ContactDetails = new V24Resources.ContactDetails
                    {
                        PhoneNumber = "+16505550100",
                        Email = "test@example.com",
                        ConsumerName = "John Doe"
                    }
                }
            };
            response.Results.Add(row);

            string formattedResponse = logFormatter.FormatResponseBody(response);

            Assert.True(formattedResponse.Contains("\"phoneNumber\": \"REDACTED\""));
            Assert.True(formattedResponse.Contains("\"email\": \"REDACTED\""));
            Assert.True(formattedResponse.Contains("\"consumerName\": \"REDACTED\""));
            Assert.False(formattedResponse.Contains("test@example.com"));
            Assert.False(formattedResponse.Contains("+16505550100"));
        }

        /// <summary>
        /// Test masking LocalServicesLead in V25 response (where Email is removed and PhoneNumberExtension is added).
        /// </summary>
        [Test]
        public void TestMaskLocalServicesLeadV25()
        {
            V25Services.SearchGoogleAdsResponse response = new V25Services.SearchGoogleAdsResponse
            {
                FieldMask = new FieldMask
                {
                    Paths = { "local_services_lead.contact_details.phone_number_extension" }
                }
            };
            V25Services.GoogleAdsRow row = new V25Services.GoogleAdsRow
            {
                LocalServicesLead = new V25Resources.LocalServicesLead
                {
                    ContactDetails = new V25Resources.ContactDetails
                    {
                        PhoneNumber = "+16505550100",
                        ConsumerName = "Jane Doe",
                        PhoneNumberExtension = "1234"
                    }
                }
            };
            response.Results.Add(row);

            string formattedResponse = logFormatter.FormatResponseBody(response);

            Assert.True(formattedResponse.Contains("\"phoneNumber\": \"REDACTED\""));
            Assert.True(formattedResponse.Contains("\"consumerName\": \"REDACTED\""));
            Assert.True(formattedResponse.Contains("\"phoneNumberExtension\": \"REDACTED\""));
            Assert.False(formattedResponse.Contains("1234"));
            Assert.False(formattedResponse.Contains("+16505550100"));
        }

        /// <summary>
        /// Test redaction of GAQL request querying phone_number_extension.
        /// </summary>
        [Test]
        public void TestMaskLocalServicesLeadQueryV25()
        {
            V25Services.SearchGoogleAdsRequest request = new V25Services.SearchGoogleAdsRequest
            {
                CustomerId = "1234567890",
                Query = "SELECT local_services_lead.contact_details.phone_number_extension FROM local_services_lead"
            };

            string formattedRequest = logFormatter.FormatRequestBody(request);

            Assert.True(formattedRequest.Contains("\"query\": \"REDACTED\""));
            Assert.False(formattedRequest.Contains("phone_number_extension"));
        }
    }
}

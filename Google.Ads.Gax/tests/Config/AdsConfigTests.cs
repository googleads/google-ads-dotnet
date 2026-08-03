// Copyright 2024 Google LLC
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

using Google.Ads.Gax.Config;
using Google.Apis.Auth.OAuth2;
using NUnit.Framework;
using System;
using System.IO;
using System.Text;

namespace Google.Ads.Gax.Tests.Config
{
    /// <summary>
    /// Tests for <see cref="AdsConfig"/> class.
    /// </summary>
    [TestFixture]
    [Category("Smoke")]
    internal class AdsConfigTests
    {

        /// <summary>
        /// Tests if a stream containing OAuth2 secrets is loaded correctly.
        /// </summary>
        [Test]
        public void TestLoadOauth2SecretsFromStream()
        {
            string testCredentials = "{\"client_email\": \"test@test.com\", \"private_key\": \"test_key\"}";

            AdsConfig config = new AdsConfig();
            config.LoadOAuth2SecretsFromStream(new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(testCredentials))));
            Assert.AreEqual("test@test.com", config.OAuth2ServiceAccountEmail);
        }

        /// <summary>
        /// Tests if loading a stream without the private key throws an exception.
        /// </summary>
        [Test]
        public void TestLoadOauth2SecretsFromStreamWithoutPrivateKeyThrowsException()
        {
            string testCredentials = "{\"client_email\": \"test@test.com\"}";

            AdsConfig config = new AdsConfig();
            Assert.Throws<ArgumentException>(() => config.LoadOAuth2SecretsFromStream(
                    new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(testCredentials)))
                ));
        }

        /// <summary>
        /// Tests if loading a stream without the client email throws an exception.
        /// </summary>
        [Test]
        public void TestLoadOauth2SecretsFromStreamWithoutClientEmailThrowsException()
        {
            string testCredentials = "{\"private_key\": \"test_key\"}";

            AdsConfig config = new AdsConfig();
            Assert.Throws<ArgumentException>(() => config.LoadOAuth2SecretsFromStream(
                    new StreamReader(new MemoryStream(Encoding.UTF8.GetBytes(testCredentials)))
                ));
        }
        /// <summary>
        /// Tests if custom credentials can be set and retrieved.
        /// </summary>
        [Test]
        public void TestSetCredentials()
        {
            ICredential credential = GoogleCredential.FromAccessToken("test_token");
            AdsConfig config = new AdsConfig();
            config.Credentials = credential;
            Assert.AreSame(credential, config.Credentials);
        }

        /// <summary>
        /// Tests if setting an OAuth2 property clears manually set credentials.
        /// </summary>
        [Test]
        public void TestOAuth2PropertyChangeResetsCredentials()
        {
            ICredential credential = GoogleCredential.FromAccessToken("test_token");
            AdsConfig config = new AdsConfig();
            config.Credentials = credential;
            Assert.AreSame(credential, config.Credentials);

            config.OAuth2ClientId = "new_client_id";
            // OAuth2ClientId change should reset credential field to null,
            // so getting Credentials will attempt CreateCredentials() instead of returning the custom credential.
            Assert.AreNotSame(credential, config.Credentials);
        }
    }
}

// Copyright 2018 Google LLC
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

using Google.Ads.GoogleAds.Config;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;

namespace Google.Ads.GoogleAds.Tests.Config
{
    /// <summary>
    /// Tests for <see cref="GoogleAdsConfig"/> class.
    /// </summary>
    [TestFixture]
    [Category("Smoke")]
    internal class GoogleAdsConfigTests : GoogleAdsConfig
    {
        /// <summary>
        /// Test value for <see cref="GoogleAdsConfig.ServerUrl"/> property.
        /// </summary>
        private const string SERVER_URL_VALUE = "TEST_SERVER_URL";

        /// <summary>
        /// Test value for <see cref="GoogleAdsConfig.Timeout"/> property.
        /// </summary>
        private const int TIMEOUT_VALUE = 5000;

        /// <summary>
        /// Test value for <see cref="GoogleAdsConfig.DeveloperToken"/> property.
        /// </summary>
        private const string DEVELOPER_TOKEN_VALUE = "abcdefghijkl1234567890";

        /// <summary>
        /// Test value for <see cref="GoogleAdsConfig.LoginCustomerId"/> property.
        /// </summary>
        private const string LOGIN_CUSTOMER_ID_VALUE = "1234567890";

        /// <summary>
        /// Test value for <see cref="GoogleAdsConfig.LinkedCustomerId"/> property.
        /// </summary>
        private const string LINKED_CUSTOMER_ID_VALUE = "4567891234";

        /// <summary>
        /// Test value for <see cref="GoogleAdsConfig.ClientCustomerId"/> property.
        /// </summary>
        private const string CLIENT_CUSTOMER_ID_VALUE = "987654543";

        /// <summary>
        /// Test value for <see cref="GoogleAdsConfig.OAuth2ClientId"/> property.
        /// </summary>
        private const string OAUTH2_CLIENT_ID_VALUE = "TEST_OAUTH2_CLIENT_ID";

        /// <summary>
        /// Test value for <see cref="GoogleAdsConfig.OAuth2ClientSecret"/> property.
        /// </summary>
        private const string OAUTH2_CLIENT_SECRET_VALUE = "TEST_OAUTH2_CLIENT_SECRET";

        /// <summary>
        /// Test value for <see cref="GoogleAdsConfig.OAuth2RefreshToken"/> property.
        /// </summary>
        private const string OAUTH2_REFRESH_TOKEN_VALUE = "TEST_OAUTH2_REFRESH_TOKEN";

        /// <summary>
        /// Test value for <see cref="GoogleAdsConfig.OAuth2Scope"/> property.
        /// </summary>
        private const string OAUTH2_SCOPE_VALUE = "TEST_OAUTH2_SCOPE";

        /// <summary>
        /// Test value for <see cref="GoogleAdsConfig.Proxy"/> property.
        /// </summary>
        private const string PROXY_SERVER_VALUE = "http://test.url";

        /// <summary>
        /// Test value for <see cref="GoogleAdsConfig.Proxy"/> property.
        /// </summary>
        private const string PROXY_USER_VALUE = "TEST_PROXY_USER";

        /// <summary>
        /// Test value for <see cref="GoogleAdsConfig.Proxy"/> property.
        /// </summary>
        private const string PROXY_PASSWORD_VALUE = "TEST_PROXY_PASSWORD";

        /// <summary>
        /// Test value for <see cref="GoogleAdsConfig.Proxy"/> property.
        /// </summary>
        private const string PROXY_DOMAIN_VALUE = "TEST_PROXY_DOMAIN";

        /// <summary>
        /// The test configuration settings.
        /// </summary>
        private readonly Dictionary<string, string> CONFIG_SETTINGS =
            new Dictionary<string, string>() {
                { "Timeout", TIMEOUT_VALUE.ToString() },
                { "GoogleAds.Server", SERVER_URL_VALUE },
                { "DeveloperToken", DEVELOPER_TOKEN_VALUE },
                { "LoginCustomerId", LOGIN_CUSTOMER_ID_VALUE },
                { "LinkedCustomerId", LINKED_CUSTOMER_ID_VALUE },
                { "ClientCustomerId", CLIENT_CUSTOMER_ID_VALUE },
                { "OAuth2ClientId", OAUTH2_CLIENT_ID_VALUE },
                { "OAuth2ClientSecret", OAUTH2_CLIENT_SECRET_VALUE },
                { "OAuth2RefreshToken", OAUTH2_REFRESH_TOKEN_VALUE },
                { "OAuth2Scope", OAUTH2_SCOPE_VALUE },
                { "ProxyServer", PROXY_SERVER_VALUE },
                { "ProxyUser", PROXY_USER_VALUE },
                { "ProxyPassword", PROXY_PASSWORD_VALUE },
                { "ProxyDomain", PROXY_DOMAIN_VALUE },
            };

        /// <summary>
        /// Tests the <see cref="GoogleAdsConfig.ReadSettings(Dictionary{string, string})"/> method.
        /// </summary>
        [Test]
        public void TestReadSettings()
        {
            ReadSettings(CONFIG_SETTINGS);
            Assert.AreEqual(SERVER_URL_VALUE, this.ServerUrl);
            Assert.AreEqual(TIMEOUT_VALUE, this.Timeout);
            Assert.AreEqual(DEVELOPER_TOKEN_VALUE, this.DeveloperToken);
            Assert.AreEqual(LOGIN_CUSTOMER_ID_VALUE, this.LoginCustomerId);
            Assert.AreEqual(LINKED_CUSTOMER_ID_VALUE, this.LinkedCustomerId);
            Assert.AreEqual(CLIENT_CUSTOMER_ID_VALUE, this.ClientCustomerId.ToString());
            Assert.AreEqual(OAUTH2_CLIENT_ID_VALUE, this.OAuth2ClientId);
            Assert.AreEqual(OAUTH2_CLIENT_SECRET_VALUE, this.OAuth2ClientSecret);
            Assert.AreEqual(OAUTH2_REFRESH_TOKEN_VALUE, this.OAuth2RefreshToken);
            Assert.AreEqual(OAUTH2_SCOPE_VALUE, this.OAuth2Scope);

            // Tests for Proxy field.
            NetworkCredential credential = (NetworkCredential) this.Proxy.Credentials;
            Assert.AreEqual(new Uri(PROXY_SERVER_VALUE).AbsoluteUri, 
                this.Proxy.Address.AbsoluteUri);
            Assert.AreEqual(PROXY_USER_VALUE, credential.UserName);
            Assert.AreEqual(PROXY_PASSWORD_VALUE, credential.Password);
            Assert.AreEqual(PROXY_DOMAIN_VALUE, credential.Domain);

        }
    }
}
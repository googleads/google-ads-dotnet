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

using Google.Ads.GoogleAds.Config;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Ads.GoogleAds.Examples
{
    /// <summary>
    /// Helper class for OAuth2 web flow.
    /// </summary>
    public class WebLoginHelper
    {
        /// <summary>
        /// The http context.
        /// </summary>
        private HttpContext context;

        /// <summary>
        /// The authorization code flow instance.
        /// </summary>
        private GoogleAuthorizationCodeFlow flow;

        /// <summary>
        /// The config instance.
        /// </summary>
        private GoogleAdsConfig config;

        /// <summary>
        /// The credentials key name.
        /// </summary>
        private const string CREDENTIALS_KEY = "credentials";

        /// <summary>
        /// The state parameter. If set on the callback URI, and will be passed back once the
        /// user is authorized.
        /// </summary>
        private const string STATE_PARAMETER = "test";

        /// <summary>
        /// Initializes a new instance of the <see cref="WebLoginHelper"/> class.
        /// </summary>
        /// <param name="context">The HTTP context.</param>
        /// <param name="config">The Google Ads configuration.</param>
        public WebLoginHelper(HttpContext context, GoogleAdsConfig config)
        {
            this.context = context;
            this.config = config;
            flow = new GoogleAuthorizationCodeFlow(
                new GoogleAuthorizationCodeFlow.Initializer
                {
                    ClientSecrets = new ClientSecrets()
                    {
                        ClientId = config.OAuth2ClientId,
                        ClientSecret = config.OAuth2ClientSecret
                    },
                    Scopes = new[] { config.OAuth2Scope },
                    // Set the state parameter so we can distinguish between a normal
                    // page load and a callback.
                    UserDefinedQueryParams = new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("state", STATE_PARAMETER)
                    }
                }
            );
        }

        /// <summary>
        /// Redirects the user to the OAuth server.
        /// </summary>
        public IActionResult RedirectUsertoOAuthServer()
        {
            Uri authorizationUrl = flow.CreateAuthorizationCodeRequest(
                GetCurrentPagePath()).Build();
            return new RedirectResult(authorizationUrl.AbsoluteUri);
        }

        /// <summary>
        /// Exchanges the authorization code for credentials.
        /// </summary>
        /// <returns>The <see cref="TokenResponse"/> object that contains the access
        /// and refresh tokens.</returns>
        public TokenResponse ExchangeAuthorizationCodeForCredentials()
        {
            string authorizationCode = this.context.Request.Query["code"];

            Task<TokenResponse> responseTask = flow.ExchangeCodeForTokenAsync(null,
                authorizationCode, GetCurrentPagePath(), CancellationToken.None);
            responseTask.Wait();

            TokenResponse response = responseTask.Result;

            // Save the credentials.
            this.TokenResponse = response;
            return response;
        }

        /// <summary>
        /// Checks whether the user is logged in or not.
        /// </summary>
        public bool IsLoggedIn
        {
            get
            {
                return TokenResponse != null;
            }
        }

        /// <summary>
        /// Gets or sets the token response of the logged in user.
        /// </summary>
        public TokenResponse TokenResponse
        {
            get
            {
                string creds = this.context.Session.GetString(CREDENTIALS_KEY);
                if (creds == null)
                {
                    return null;
                }
                TokenResponse response = JsonConvert.DeserializeObject<TokenResponse>(creds);

                return string.IsNullOrEmpty(creds) ? null :
                    JsonConvert.DeserializeObject<TokenResponse>(creds);
            }
            set
            {
                value.AccessToken = null;
                string creds = JsonConvert.SerializeObject(value);
                this.context.Session.SetString(CREDENTIALS_KEY, creds);
            }
        }

        /// <summary>
        /// Logs out the current user.
        /// </summary>
        public void Logout()
        {
            this.context.Session.Remove(CREDENTIALS_KEY);
        }

        /// <summary>
        /// Determines whether the current page load is due to a callback from the OAuth server.
        /// </summary>
        public bool IsCallbackFromOAuthServer()
        {
            return !string.IsNullOrEmpty(this.context.Request.Query["state"]);
        }

        /// <summary>
        /// Gets path to the current page.
        /// </summary>
        /// <returns>The path to the current page.</returns>
        private string GetCurrentPagePath()
        {
            return new Uri(this.context.Request.GetDisplayUrl()).GetLeftPart(UriPartial.Path);
        }
    }
}
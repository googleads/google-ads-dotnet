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
using Google.Ads.GoogleAds.Extensions.Config;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Google.Ads.GoogleAds.Examples
{
    /// <summary>
    /// The controller for the login flow.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    [Route("login")]
    public class LoginController : Controller
    {
        /// <summary>
        /// The login helper.
        /// </summary>
        private WebLoginHelper loginHelper;

        /// <summary>
        /// The Google Ads configuration.
        /// </summary>
        private GoogleAdsConfig config;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginController"/> class.
        /// </summary>
        /// <param name="configRoot">The configuration root.</param>
        public LoginController(IConfiguration configRoot)
        {
            IConfigurationSection section = configRoot.GetSection("GoogleAdsApi");
            config = new GoogleAdsConfig();
            config.LoadFromConfigurationSection(section);
        }

        /// <summary>
        /// Handles the GET call.
        /// </summary>
        public IActionResult OnGet()
        {
            loginHelper = new WebLoginHelper(this.HttpContext, config);
            if (loginHelper.IsLoggedIn)
            {
                // Redirect to the main page.
                return Redirect("/Index");
            }
            else if (loginHelper.IsCallbackFromOAuthServer())
            {
                loginHelper.ExchangeAuthorizationCodeForCredentials();

                // Redirect to the main page.
                return Redirect("/Index");
            }
            else
            {
                // Redirect the user to the OAuth2 login page.
                return loginHelper.RedirectUsertoOAuthServer();
            }
        }
    }
}
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
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Google.Ads.GoogleAds.Examples
{
    /// <summary>
    /// The model class for the index page.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.RazorPages.PageModel" />
    public class IndexModel : PageModel
    {
        /// <summary>
        /// The login helper.
        /// </summary>
        public WebLoginHelper loginHelper;

        /// <summary>
        /// The Google Ads configuration.
        /// </summary>
        private GoogleAdsConfig config;

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModel"/> class.
        /// </summary>
        /// <param name="configRoot">The configuration root.</param>
        public IndexModel(IConfiguration configRoot)
        {
            IConfigurationSection section = configRoot.GetSection("GoogleAdsApi");
            config = new GoogleAdsConfig();
            config.LoadFromConfigurationSection(section);
        }

        /// <summary>
        /// Handles the GET call.
        /// </summary>
        /// <returns></returns>
        public IActionResult OnGet()
        {
            this.loginHelper = new WebLoginHelper(this.HttpContext, config);
            return Page();
        }

        /// <summary>
        /// Handles the POST call when the login button is clicked.
        /// </summary>
        public IActionResult OnPostLogin()
        {
            return RedirectToPage("./Login");
        }

        /// <summary>
        /// Handles the POST call when the logout button is clicked.
        /// </summary>
        public IActionResult OnPostLogout()
        {
            this.loginHelper.Logout();
            return RedirectToPage();
        }
    }
}
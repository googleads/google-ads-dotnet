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

using System;

namespace Google.Ads.GoogleAds.Examples
{
    public partial class Login : System.Web.UI.Page
    {
        /// <summary>
        /// The login helper.
        /// </summary>
        private WebLoginHelper loginHelper;

        /// <summary>
        /// Initializes a new instance of the <see cref="Login"/> class.
        /// </summary>
        public Login()
        {
            loginHelper = new WebLoginHelper(this);
        }

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            // Initialize login helper only in the page load, otherwise session information
            // won't be available.

            if (loginHelper.IsLoggedIn)
            {
                // Redirect to the main page.
                Response.Redirect("/Default.aspx");
            }
            else if (loginHelper.IsCallbackFromOAuthServer())
            {
                loginHelper.ExchangeAuthorizationCodeForCredentials();

                // Redirect to the main page.
                Response.Redirect("/Default.aspx");
            }
            else
            {
                // Redirect the user to the OAuth2 login page.
                loginHelper.RedirectUsertoOAuthServer();
            }
        }
    }
}

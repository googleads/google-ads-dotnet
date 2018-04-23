// Copyright 2017, Google Inc. All Rights Reserved.
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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Util.Store;

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;

namespace Google.Ads.Adwords.Examples.AuthenticateInWebApplication {

  public partial class Default : Page {

    /// <summary>
    /// The AdWords API scope.
    /// </summary>
    private const string ADWORDS_API_SCOPE = "https://www.googleapis.com/auth/adwords";

    /// <summary>
    /// Path to store the secrets file.
    /// </summary>
    private const string CLIENT_SECRETS_PATH = "client_secret.json";

    /// <summary>
    /// A user identifier for the Data store.
    /// </summary>
    private const string USER_ID = "me";

    /// <summary>
    /// The state parameter. If set on the callback URI, and will be passed back once the user is
    /// authorized.
    /// </summary>
    private const string STATE_PARAMETER = "test";

    /// <summary>
    /// The authorization code flow.
    /// </summary>
    GoogleAuthorizationCodeFlow flow;

    /// <summary>
    /// Initializes a new instance of the <see cref="Default"/> class.
    /// </summary>
    public Default() {
      flow = new GoogleAuthorizationCodeFlow(
        new GoogleAuthorizationCodeFlow.Initializer {
          ClientSecrets = LoadClientSecrets(),
          Scopes = new[] { ADWORDS_API_SCOPE },

          // Since we want to retrieve the credentials for further processing,
          // use a null data store.
          DataStore = new NullDataStore(),

          // Set the state parameter so we can distinguish between a normal
          // page load and a callback.
          UserDefinedQueryParams = new KeyValuePair<string, string>[] {
            new KeyValuePair<string, string>("state", STATE_PARAMETER)
          }
        }
      );
    }

    /// <summary>
    /// Loads the client secrets from the JSON file.
    /// </summary>
    /// <returns>The client secrets.</returns>
    private ClientSecrets LoadClientSecrets() {
      ClientSecrets secrets = null;

      string credentialsPath = Server.MapPath("~") + CLIENT_SECRETS_PATH;

      using (FileStream fs = File.OpenRead(credentialsPath)) {
        secrets = GoogleClientSecrets.Load(fs).Secrets;
      }

      return secrets;
    }

    /// <summary>
    /// Gets the call back URL for OAuth web flow.
    /// </summary>
    /// <returns>The callback URL.</returns>
    private string GetCallBackUrl() {
      return HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Path);
    }

    /// <summary>
    /// Exchanges the authorization code for credentials.
    /// </summary>
    /// <returns>The <see cref="TokenResponse"/> object that contains the access
    /// and refresh tokens.</returns>
    private TokenResponse ExchangeAuthorizationCodeForCredentials() {
      string url = this.Request.Url.OriginalString;
      string authorizationCode = this.Request.QueryString["code"];

      Task<TokenResponse> responseTask = flow.ExchangeCodeForTokenAsync(USER_ID,
        authorizationCode, GetCallBackUrl(), CancellationToken.None);
      responseTask.Wait();
      TokenResponse response = responseTask.Result;
      return response;
    }

    /// <summary>
    /// Handles the Load event of the Page control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void Page_Load(object sender, EventArgs e) {
      // This code example stores the user credentials in the session. In a
      // production application, this should be stored in a secured database.
      UserCredential credential = (UserCredential) Session["credentials"];

      if (credential != null) {
        btnLogin.Visible = false;
        lblStatus.Text = "Logged in.";
     } else {
        btnLogin.Visible = true;
        lblStatus.Text = "Not logged in.";

        string state = this.Request.QueryString["state"];

        // If state parameter is set, then this is a callback.
        if (!string.IsNullOrEmpty(state)) {
          TokenResponse response = ExchangeAuthorizationCodeForCredentials();

          // Save the credentials and hide the login button.
          credential = new UserCredential(flow, STATE_PARAMETER, response);
          Session["credentials"] = credential;
          btnLogin.Visible = false;
          lblStatus.Text = "Logged in.";

          // Optional: You can now redirect the user to an appropriate page.
        }
      }
    }

    /// <summary>
    /// Handles the Click event of the btnLogin control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    protected void btnLogin_Click(object sender, EventArgs e) {
      Uri authorizationUrl = flow.CreateAuthorizationCodeRequest(GetCallBackUrl()).Build();

      this.Response.Redirect(authorizationUrl.AbsoluteUri);
    }
  }
}

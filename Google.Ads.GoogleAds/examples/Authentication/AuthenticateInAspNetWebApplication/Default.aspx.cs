// Copyright 2019 Google LLC
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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V17.Services;
using Google.Api.Gax;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Google.Ads.GoogleAds.Examples
{

    /// <summary>
    /// The default webpage.
    /// </summary>
    public partial class Default : Page
    {

        /// <summary>
        /// The login helper.
        /// </summary>
        public WebLoginHelper loginHelper;

        /// <summary>
        /// The Google Ads client.
        /// </summary>
        private GoogleAdsClient client = new GoogleAdsClient();

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            this.loginHelper = new WebLoginHelper(this);
            if (loginHelper.IsLoggedIn)
            {
                client.Config.OAuth2RefreshToken = loginHelper.Credentials.Token.RefreshToken;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnLogout control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            loginHelper.Logout();
        }

        /// <summary>
        /// Handles the Click event of the btnLogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Login.aspx");
        }

        /// <summary>
        /// Handles the Click event of the btnGetCampaigns control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        async protected void btnGetCampaigns_Click(object sender, EventArgs e)
        {
            string customerId = txtCustomerId.Text;
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
              Services.V17.GoogleAdsService);

            // Create a request that will retrieve all campaigns.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                Query = "SELECT campaign.id, campaign.name, campaign.status FROM campaign " +
                    "ORDER BY campaign.id",
                CustomerId = customerId.ToString()
            };

            // Issue the search request.
            PagedAsyncEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchPagedResponse =
                googleAdsService.SearchAsync(request);

            // Iterate over all rows in all pages and prints the requested field values for the
            // campaign in each row.
            await foreach (GoogleAdsRow googleAdsRow in searchPagedResponse)
            {
                TableRow row = new TableRow();
                row.Cells.Add(new TableCell()
                {
                    Text = googleAdsRow.Campaign.Id.ToString()
                });
                row.Cells.Add(new TableCell()
                {
                    Text = googleAdsRow.Campaign.Name
                });
                row.Cells.Add(new TableCell()
                {
                    Text = googleAdsRow.Campaign.Status.ToString()
                });
                CampaignTable.Rows.Add(row);
            }
        }
    }
}

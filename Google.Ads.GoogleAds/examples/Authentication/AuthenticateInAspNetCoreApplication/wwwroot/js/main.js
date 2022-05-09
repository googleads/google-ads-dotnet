/*
 * Copyright 2021 Google LLC
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http: *www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/**
 * Handle the click for getcampaigns button on the index page.
 */
function DisplayCampaigns() {
    var inputBox = document.getElementById("customerid");
    if (!inputBox.checkValidity()) {
        return;
    }
    var customerId = $(inputBox).val();
    $.ajax({
        type: "GET",
        url: '/ads/' + customerId + '/campaigns',
        contentType: "application/json; charset=utf-8",
        dataType: "json"
    }).done(function (data) {
        var html = [];
        for (i = 0; i < data.length; i++) {
            var tableclass = ((i % 2) == 0) ? "table-active" : "table-light";
            html.push(
                "<tr class='" + tableclass + "'>",
                "<td>" + data[i].id + "</td>",
                "<td>" + data[i].name + "</td>",
                "<td>" + data[i].status + "</td>",
                "</tr>"
            );
            $("#campaigndata").html(html.join("\n"));
        }
    });
    return false;
}
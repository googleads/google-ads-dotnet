﻿// Copyright 2020 Google LLC
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

namespace Google.Ads.GoogleAds.Lib
{
    /// <summary>
    /// Key names to be used in gRPC metadata headers.
    /// </summary>
    internal class MetadataKeyNames
    {
        /// <summary>
        /// The developer token keyname in request metadata.
        /// </summary>
        internal const string DeveloperToken = "developer-token";

        /// <summary>
        /// The login customer ID keyname in request metadata.
        /// </summary>
        internal const string LoginCustomerId = "login-customer-id";

        /// <summary>
        /// The linked customer ID keyname in request metadata.
        /// </summary>
        internal const string LinkedCustomerId = "linked-customer-id";

        /// <summary>
        /// The library identifier keyname in request metadata.
        /// </summary>
        internal const string LibraryIdentifier = "x-goog-api-client";

        /// <summary>
        /// The metadata key name for request ID.
        /// </summary>
        internal const string RequestId = "request-id";

        /// <summary>
        /// The metadata key name suffix for the serialized failure object.
        /// </summary>
        internal const string FailureKeySuffix = "errors.googleadsfailure-bin";

        /// <summary>
        /// The metadata key name for the serialized failure object.
        /// </summary>
        internal const string FailureKeyTemplate = "google.ads.googleads.{0}."
            + FailureKeySuffix;

        /// <summary>
        /// The metadata key name for the inviter email address.
        /// </summary>
        internal const string CustomerUserAccessInviterEmailAddress =
            "customer_user_access.inviter_user_email_address";

        /// <summary>
        /// The metadata key name for the invitation email address.
        /// </summary>
        internal const string CustomerUserAccessInvitationEmailAddress =
            "customer_user_access_invitation.email_address";

        /// <summary>
        /// The metadata key name for the email address.
        /// </summary>
        internal const string CustomerUserAccessEmailAddress = "customer_user_access.email_address";

        /// <summary>
        /// The metadata key name for the ChangeEvent user email address.
        /// </summary>
        internal const string ChangeEventUserEmail = "change_event.user_email";

        /// <summary>
        /// The metadata key name for the Feed placeholder email address.
        /// </summary>
        internal const string FeedPlaceholderEmailAddress =
            "feed.places_location_feed_data.email_address";
    }
}

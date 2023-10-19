// Copyright 2022 Google LLC
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

using Google.Ads.Gax.Lib;
using Google.Ads.Gax.Logging;
using Google.Ads.GoogleAds.Lib;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Google.Ads.GoogleAds.Logging
{
    /// <summary>
    /// Default implementation of <see cref="ILogFormatter"/>
    /// </summary>
    internal class LogFormatter : ILogFormatter
    {
        private const string MASK_PATTERN = "REDACTED";

        private static readonly HashSet<string> REQUEST_HEADERS_TO_MASK =
            new HashSet<string>() { MetadataKeyNames.DeveloperToken };

        private static readonly HashSet<string> RESPONSE_HEADERS_TO_MASK =
            new HashSet<string>() { };

        private static readonly HashSet<string> REQUEST_RESPONSE_BODY_FIELDS_TO_MASK =
            new HashSet<string>() {
                MetadataKeyNames.CustomerUserAccessInviterEmailAddress,
                MetadataKeyNames.CustomerUserAccessEmailAddress,
                MetadataKeyNames.ChangeEventUserEmail,
                MetadataKeyNames.FeedPlaceholderEmailAddress,
                MetadataKeyNames.CustomerUserAccessInvitationEmailAddress,
                MetadataKeyNames.LocalServicesLeadContactDetails,
                MetadataKeyNames.LocalServicesLeadConversationMessageDetailText,
            };

        private static readonly Regex GAQL_REDACTION_MATCHER =
            new Regex(string.Join("|", REQUEST_RESPONSE_BODY_FIELDS_TO_MASK));

        #region ILogCustomizer methods

        /// <summary>
        /// Formats the request body.
        /// </summary>
        /// <param name="body">The request body.</param>
        /// <returns>
        /// The formatted text.
        /// </returns>
        public string FormatRequestBody(object body) =>
            FormatBody(body, REQUEST_RESPONSE_BODY_FIELDS_TO_MASK);

        /// <summary>
        /// Formats the response body.
        /// </summary>
        /// <param name="body">The response body.</param>
        /// <returns>
        /// The formatted text.
        /// </returns>
        public string FormatResponseBody(object body) =>
            FormatBody(body, REQUEST_RESPONSE_BODY_FIELDS_TO_MASK);

        /// <summary>
        /// Formats the request headers.
        /// </summary>
        /// <param name="header">The request header.</param>
        /// <returns>
        /// The formatted text.
        /// </returns>
        public string FormatRequestHeaders(Metadata header) =>
            FormatHeaders(header, REQUEST_HEADERS_TO_MASK);

        /// <summary>
        /// Formats the response headers.
        /// </summary>
        /// <param name="header">The response header.</param>
        /// <returns>
        /// The formatted text.
        /// </returns>
        public string FormatResponseHeaders(Metadata header) =>
            FormatHeaders(header, RESPONSE_HEADERS_TO_MASK);

        /// <summary>
        /// Gets the request ID for logging.
        /// </summary>
        /// <param name="responseHeaders">The response headers.</param>
        /// <param name="response">The response.</param>
        /// <param name="exception">The exception, if available.</param>
        /// <returns>The request ID.</returns>
        public string GetRequestId(Metadata responseHeaders, object response,
            RpcException exception)
        {
            string requestId = new AdsResponseMetadata(responseHeaders).RequestId;
            // For streaming calls, the trailing response headers are returned only after
            // the entire stream is read, whereas we write summary logs each time we retrieve
            // a response object from the stream. As a result, the requestId in summary logs
            // appear blank in all except the last entry. As a fix, we read the request Id
            // from the stream response object as a fallback.
            if (string.IsNullOrEmpty(requestId))
            {
                IResponseMetadata responseMetadata = response as IResponseMetadata;
                if (responseMetadata != null)
                {
                    requestId = responseMetadata.RequestId;
                }
            }
            if (string.IsNullOrEmpty(requestId))
            {
                AdsBaseException adsException = exception as AdsBaseException;
                if (adsException != null)
                {
                    requestId = adsException.RequestId;
                }
            }
            return requestId;
        }

        #endregion ILogCustomizer methods

        /// <summary>
        /// Formats the response body.
        /// </summary>
        /// <param name="body">The response body.</param>
        /// <param name="keysToMask">The keys to mask.</param>
        /// <returns>The formatted body.</returns>
        private static string FormatBody(object body, HashSet<string> keysToMask)
        {
            if (body == null)
            {
                return "{ }";
            }

            string bodyTypeName = body.GetType().Name;

            switch (bodyTypeName)
            {
                // Handle masking for GoogleAdsService::Search and GoogleAdsService::SearchStream
                // requests.
                // Note: We are proactively masking the whole query if we find a match of the
                // field we are interested in. We can make this more restrictive in the future
                // by masking only relevant section of the query.
                case "SearchGoogleAdsRequest":
                case "SearchGoogleAdsStreamRequest":
                    {
                        object clonedMessage = CloneMessage(body);
                        MaskQueryInSearchRequest(clonedMessage);
                        return clonedMessage.ToString();
                    }
                // Handle masking for GoogleAdsService::Search and GoogleAdsService::SearchStream
                // responses.
                // Note: We are taking advantage of the fact that when using the above methods,
                // the response contains the read field masks. We can examine them and skip
                // masking if the fields of interest aren't present in the list.
                // Note: It is important to clone the object first, or we will rewrite the response
                // returned to the user.
                // Note: We use the dynamic keyword in this code. This saves us a lot of reflection
                // code by having the compiler generate it for us.
                case "SearchGoogleAdsResponse":
                case "SearchGoogleAdsStreamResponse":
                    {
                        FieldMask fieldMask = GetFieldMask(body);
                        if (fieldMask != null)
                        {
                            foreach (string mask in fieldMask.Paths)
                            {
                                if (keysToMask.Contains(mask))
                                {
                                    object clonedMessage = CloneMessage(body);
                                    MaskFieldsInSearchResponse(clonedMessage);
                                    return clonedMessage.ToString();
                                }
                            }
                        }
                        return body.ToString();
                    }

                // Handle masking for CustomerUserAccessService::GetCustomerUserAccess.
                case "CustomerUserAccess":
                    {
                        object clonedMessage = CloneMessage(body);
                        MaskCustomerUserAccess(clonedMessage);
                        return clonedMessage.ToString();
                    }

                // Handle masking for FeedService::GetFeed.
                case "Feed":
                    {
                        object clonedMessage = CloneMessage(body);
                        MaskFeed(clonedMessage);
                        return clonedMessage.ToString();
                    }

                // Handle masking for FeedService::MutateFeeds.
                case "MutateFeedsRequest":
                    {
                        object clonedMessage = CloneMessage(body);
                        MaskMutateFeedsRequest(clonedMessage);
                        return clonedMessage.ToString();
                    }

                // Handle masking for CustomerUserAccessService::MutateCustomerUserAccess.
                case "MutateCustomerUserAccessRequest":
                    {
                        object clonedMessage = CloneMessage(body);
                        MaskMutateCustomerUserAccessRequest(clonedMessage);
                        return clonedMessage.ToString();
                    }

                // Handle masking for CustomerUserAccessService::MutateCustomerUserAccess.
                case "CreateCustomerClientRequest":
                    {
                        object clonedMessage = CloneMessage(body);
                        MaskCreateCustomerClientRequest(clonedMessage);
                        return clonedMessage.ToString();
                    }

                default:
                    return body.ToString();
            }
        }

        /// <summary>
        /// Masks the query in search request within a <code>SearchGoogleAdsRequest</code> or
        /// <code>SearchGoogleAdsStreamRequest</code> object when making
        /// <code>GoogleAdsService::Search</code> or <code>GoogleAdsService::SearchStream</code>
        /// call and privacy-sensitive fields are requested.
        /// </summary>
        /// <param name="body">The request body.</param>
        private static void MaskQueryInSearchRequest(dynamic body)
        {
            string query = body.Query;
            Match match = GAQL_REDACTION_MATCHER.Match(query);
            if (match.Success)
            {
                body.Query = MASK_PATTERN;
            }
        }

        /// <summary>
        /// Masks the email address fields within a <code>MutateFeedsRequest</code>
        /// object when making an <code>FeedService::MutateFeeds</code> API call.
        /// </summary>
        /// <param name="body">The request body.</param>
        private static void MaskMutateFeedsRequest(dynamic body)
        {
            try
            {
                if (body.Operations != null)
                {
                    foreach (var operation in body.Operations)
                    {
                        if (operation.Create != null)
                        {
                            MaskFeed(operation.Create);
                        }
                        if (operation.Update != null)
                        {
                            MaskFeed(operation.Update);
                        }
                    }
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Masks the email address fields within a <code>CreateCustomerClientRequest</code>
        /// object.
        /// </summary>
        /// <param name="body">The request body.</param>
        private static void MaskCreateCustomerClientRequest(dynamic body)
        {
            try
            {
                if (body != null)
                {
                    body.EmailAddress = MASK_PATTERN;
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Masks the user access fields within a <code>MutateCustomerUserAccessRequest</code>
        /// object.
        /// </summary>
        /// <param name="body">The request body.</param>
        private static void MaskMutateCustomerUserAccessRequest(dynamic body)
        {
            try
            {
                if (body != null && body.Operation != null && body.Operation.Update != null)
                {
                    MaskCustomerUserAccess(body.Operation.Update);
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Masks the user access invitation fields within a
        /// <code>MutateCustomerUserAccessInvitationRequest</code> object.
        /// </summary>
        /// <param name="body">The request body.</param>
        private static void MaskMutateCustomerUserAccessInvitation(dynamic body)
        {
            try
            {
                if (body != null && body.Operation != null && body.Operation.Create != null)
                {
                    MaskCustomerUserAccessInvitation(body.Operation.Create);
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Masks the user access fields within a <code>SearchGoogleAdsResponse</code> or
        /// <code>SearchGoogleAdsStreamResponse</code> object when making
        /// <code>GoogleAdsService::Search</code> or <code>GoogleAdsService::SearchStream</code>
        /// call.
        /// </summary>
        /// <param name="response">The response object.</param>
        private static void MaskFieldsInSearchResponse(dynamic response)
        {
            try
            {
                if (response != null)
                {
                    foreach (var row in response.Results)
                    {
                        MaskCustomerUserAccess(row.CustomerUserAccess);
                        MaskCustomerUserAccessInvitation(row.CustomerUserAccessInvitation);
                        MaskChangeEvent(row.ChangeEvent);
                        MaskFeed(row.Feed);
                    }
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Masks the user email field within a <code>Feed</code> object.
        /// </summary>
        /// <param name="body">The <code>Feed</code> object.</param>
        private static void MaskFeed(dynamic body)
        {
            try
            {
                if (body != null && body.PlacesLocationFeedData != null)
                {
                    body.PlacesLocationFeedData.EmailAddress = MASK_PATTERN;
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Masks the user email field within a <code>ChangeEvent</code> object.
        /// </summary>
        /// <param name="body">The <code>ChangeEvent</code> object.</param>
        private static void MaskChangeEvent(dynamic body)
        {
            try
            {
                if (body != null)
                {
                    body.UserEmail = MASK_PATTERN;
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Masks the user access fields within a <code>CustomerUserAccess</code> object.
        /// </summary>
        /// <param name="body">The <code>CustomerUserAccess</code> object.</param>
        private static void MaskCustomerUserAccess(dynamic body)
        {
            try
            {
                if (body != null)
                {
                    body.InviterUserEmailAddress = MASK_PATTERN;
                    body.EmailAddress = MASK_PATTERN;
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Masks the email field within a <code>CustomerUserAccessInvitation</code> object.
        /// </summary>
        /// <param name="body">The <code>CustomerUserAccessInvitation</code> object.</param>
        private static void MaskCustomerUserAccessInvitation(dynamic body)
        {
            try
            {
                if (body != null)
                {
                    body.EmailAddress = MASK_PATTERN;
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Clones the message.
        /// </summary>
        /// <param name="message">The message object.</param>
        /// <returns>The cloned message.</returns>
        private static object CloneMessage(dynamic message)
        {
            return message.Clone();
        }

        /// <summary>
        /// Gets the value of the field mask property of an object.
        /// </summary>
        /// <param name="response">The response object.</param>
        /// <returns>The value of the FieldMask property, or null if the value cannot be
        /// retrieved.</returns>
        private static FieldMask GetFieldMask(dynamic response)
        {
            try
            {
                return response.FieldMask;
            }
            catch (RuntimeBinderException)
            {
                return null;
            }
        }

        /// <summary>
        /// Formats the metadata headers.
        /// </summary>
        /// <param name="metadata">The header metadata.</param>
        /// <param name="keysToMask">The keys to mask.</param>
        /// <returns>The formatted text.</returns>
        private static string FormatHeaders(Metadata metadata, HashSet<string> keysToMask)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            if (metadata != null)
            {
                foreach (Metadata.Entry entry in metadata)
                {
                    if (keysToMask.Contains(entry.Key))
                    {
                        headers[entry.Key] = MASK_PATTERN;
                    }
                    else
                    {
                        if (entry.IsBinary)
                        {
                            headers[entry.Key] = Convert.ToBase64String(entry.ValueBytes);
                        }
                        else
                        {
                            headers[entry.Key] = entry.Value;
                        }
                    }
                }
            }
            return JsonConvert.SerializeObject(headers, Formatting.Indented);
        }
    }
}
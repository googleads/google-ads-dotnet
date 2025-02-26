/*
 * Copyright 2025 Google Inc. All Rights Reserved.
 * Use of this source code is governed by a BSD-style
 * license that can be found in the LICENSE file or at
 * https://developers.google.com/open-source/licenses/bsd
 */

using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;

// Interfaces and implementations of synchronous page streaming. These are gathered into a single file
// for convenience.

namespace Google.Api.Gax.Grpc
{
    /// <summary>
    /// A sequence of resources, obtained lazily via API operations which retrieve a page at a time.
    /// This class replaces the GrpcPagedEnumerable class from the <code>Google.Api.Gax.Grpc</code>
    /// package, since the Google Ads API does not support setting a page size.
    /// For further details on paging in the Google Ads API, see
    /// https://ads-developers.googleblog.com/2024/07/upcoming-changes-to-page-size-in-google.html
    /// </summary>
    /// <typeparam name="TRequest">The API request type.</typeparam>
    /// <typeparam name="TResponse">The API response type. Each response contains a page of resources.</typeparam>
    /// <typeparam name="TResource">The resource type contained within the response.</typeparam>
    public sealed class AdsPagedEnumerable<TRequest, TResponse, TResource> : PagedEnumerable<TResponse, TResource>
        where TRequest : class, IPageRequest, IMessage<TRequest>
        where TResponse : class, IPageResponse<TResource>, IMessage<TResponse>
    {
        private readonly ApiCall<TRequest, TResponse> _apiCall;
        private readonly TRequest _request;
        private readonly CallSettings _callSettings;

        /// <summary>
        /// Creates a new lazily-evaluated sequence from the given API call, initial request, and call settings.
        /// </summary>
        /// <remarks>The request is cloned each time the sequence is evaluated.</remarks>
        /// <param name="apiCall">The API call made each time a page is required.</param>
        /// <param name="request">The initial request.</param>
        /// <param name="callSettings">The settings to apply to each API call.</param>
        public AdsPagedEnumerable(ApiCall<TRequest, TResponse> apiCall, TRequest request, CallSettings callSettings)
        {
            _apiCall = apiCall;
            _request = request;
            _callSettings = callSettings;
        }

        /// <inheritdoc/>
        public override IEnumerable<TResponse> AsRawResponses()
        {
            var request = _request.Clone();
            while (true)
            {
                var current = _apiCall.Sync(request, _callSettings);
                var nextPageToken = current.NextPageToken;
                yield return current;
                if (nextPageToken == "")
                {
                    yield break;
                }
                // Prepare the next request...
                request.PageToken = nextPageToken;
            }
        }

        /// <inheritdoc/>
        public override IEnumerator<TResource> GetEnumerator() => AsRawResponses().SelectMany(page => page).GetEnumerator();

        /// <inheritdoc/>
        public override Page<TResource> ReadPage(int pageSize)
        {
            throw new NotImplementedException(
                "Setting a page size is not supported in the Google Ads API"
            );
        }
    }
}
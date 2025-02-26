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
using System.Threading;
using System.Threading.Tasks;

// Interfaces and implementations of asynchronous page streaming. These are gathered into a single file
// for convenience.

namespace Google.Api.Gax.Grpc
{
    /// <summary>
    /// An asynchronous sequence of resources, obtained lazily via API operations which retrieve a page at a time.
    /// This class replaces the GrpcPagedAsyncnumerable class from the <code>Google.Api.Gax.Grpc</code>
    /// package, since the Google Ads API does not support setting a page size.
    /// For further details on paging in the Google Ads API, see
    /// https://ads-developers.googleblog.com/2024/07/upcoming-changes-to-page-size-in-google.html
    /// </summary>
    /// <typeparam name="TRequest">The API request type.</typeparam>
    /// <typeparam name="TResponse">The API response type. Each response contains a page of resources.</typeparam>
    /// <typeparam name="TResource">The resource type contained within the response.</typeparam>
    public sealed class AdsPagedAsyncEnumerable<TRequest, TResponse, TResource> : PagedAsyncEnumerable<TResponse, TResource>
        where TRequest : class, IPageRequest, IMessage<TRequest>
        where TResponse : class, IPageResponse<TResource>, IMessage<TResponse>
    {
        private readonly ResponseAsyncEnumerable<TRequest, TResponse, TResource> _pages;

        /// <summary>
        /// Creates a new lazily-evaluated asynchronous sequence from the given API call, initial request, and call settings.
        /// </summary>
        /// <remarks>The request is cloned each time the sequence is evaluated.</remarks>
        /// <param name="apiCall">The API call made each time a page is required.</param>
        /// <param name="request">The initial request.</param>
        /// <param name="callSettings">The settings to apply to each API call.</param>
        public AdsPagedAsyncEnumerable(ApiCall<TRequest, TResponse> apiCall,
            TRequest request, CallSettings callSettings)
        {
            _pages = new ResponseAsyncEnumerable<TRequest, TResponse, TResource>(apiCall, request, callSettings);
        }

        /// <inheritdoc/>
        public override IAsyncEnumerable<TResponse> AsRawResponses() => _pages;

        /// <inheritdoc/>
        public override Task<Page<TResource>> ReadPageAsync(
            int pageSize, CancellationToken cancellationToken = default(CancellationToken)) =>
                throw new NotImplementedException(
                    "Setting a page size is not supported in the Google Ads API"
                );

        /// <inheritdoc/>
        public override IAsyncEnumerator<TResource> GetAsyncEnumerator(CancellationToken cancellationToken = default) =>
            new ResourceEnumerator<TResource, TResponse>(_pages.GetAsyncEnumerator(cancellationToken), cancellationToken);
    }

    /// <summary>
    /// Class to effectively perform SelectMany on the pages, extracting resources.
    /// This allows us to avoid taking a dependency on System.Linq.Async.
    /// </summary>
    internal sealed class ResourceEnumerator<TResource, TResponse> : IAsyncEnumerator<TResource>
        where TResponse : IPageResponse<TResource>
    {
        private readonly CancellationToken _cancellationToken;
        private readonly IAsyncEnumerator<TResponse> _responseEnumerator;

        public TResource Current { get; private set; }
        private IEnumerator<TResource> _currentResponse;
        private bool _finished;

        internal ResourceEnumerator(IAsyncEnumerator<TResponse> responseEnumerator, CancellationToken cancellationToken)
        {
            _responseEnumerator = responseEnumerator;
            _cancellationToken = cancellationToken;
        }

        public ValueTask DisposeAsync() => _responseEnumerator.DisposeAsync();

        public async ValueTask<bool> MoveNextAsync()
        {
            if (_finished)
            {
                return false;
            }
            // This needs to be in a loop to handle the case where we get multiple empty responses.
            while (true)
            {
                _cancellationToken.ThrowIfCancellationRequested();
                if (_currentResponse == null)
                {
                    var hasNextResponse = await _responseEnumerator.MoveNextAsync().ConfigureAwait(false);
                    if (!hasNextResponse)
                    {
                        _finished = true;
                        return false;
                    }
                    _currentResponse = _responseEnumerator.Current.GetEnumerator();
                }
                if (_currentResponse.MoveNext())
                {
                    Current = _currentResponse.Current;
                    return true;
                }
                else
                {
                    _currentResponse = null;
                }
            }
        }
    }

    /// <summary>
    /// An asynchronous sequence of API responses, each containing a page of resources.
    /// </summary>
    /// <typeparam name="TRequest">The API request type.</typeparam>
    /// <typeparam name="TResponse">The API response type.</typeparam>
    /// <typeparam name="TResource">The resource type contained within the response.</typeparam>
    internal sealed class ResponseAsyncEnumerable<TRequest, TResponse, TResource> : IAsyncEnumerable<TResponse>
        where TRequest : class, IPageRequest, IMessage<TRequest>
        where TResponse : class, IPageResponse<TResource>, IMessage<TResponse>
    {
        private readonly CallSettings _callSettings;
        private readonly TRequest _request;
        private readonly ApiCall<TRequest, TResponse> _apiCall;

        public ResponseAsyncEnumerable(ApiCall<TRequest, TResponse> apiCall,
            TRequest request, CallSettings callSettings)
        {
            _callSettings = callSettings;
            _request = request;
            _apiCall = apiCall;
        }

        /// <inheritdoc />
        public IAsyncEnumerator<TResponse> GetAsyncEnumerator(CancellationToken cancellationToken) =>
            new ResponseAsyncEnumerator(_callSettings, _request.Clone(), _apiCall, cancellationToken);

        internal async Task<Page<TResource>> GetCompletePageAsync(
            int pageSize, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = _request.Clone();
            var items = new List<TResource>(pageSize);
            string nextPageToken = "";
            while (items.Count < pageSize)
            {
                cancellationToken.ThrowIfCancellationRequested();
                int requestCount = pageSize - items.Count;
                request.PageSize = requestCount;
                CallSettings effectiveCallSettings = _callSettings;
                if (cancellationToken != default(CancellationToken))
                {
                    effectiveCallSettings = _callSettings.WithCancellationToken(cancellationToken);
                }

                var current = await _apiCall.Async(request, effectiveCallSettings).ConfigureAwait(false);
                items.AddRange(current);
                if (items.Count > pageSize)
                {
                    // TODO: Better exception type?
                    throw new NotSupportedException("Invalid server response: " +
                        $"requested {requestCount} items, received {current.Count()} items");
                }
                nextPageToken = current.NextPageToken;
                if (nextPageToken == "")
                {
                    break;
                }
                // Prepare the next request...
                request.PageToken = nextPageToken;
            }
            return new Page<TResource>(items, nextPageToken);
        }

        private class ResponseAsyncEnumerator : IAsyncEnumerator<TResponse>
        {
            private readonly CallSettings _callSettings;
            private readonly ApiCall<TRequest, TResponse> _apiCall;
            private readonly TRequest _request; // This is mutated during iteration
            private readonly CancellationToken _cancellationToken;
            private bool _finished;

            public ResponseAsyncEnumerator(CallSettings callSettings,
                TRequest request, ApiCall<TRequest, TResponse> apiCall,
                CancellationToken cancellationToken)
            {
                _callSettings = callSettings;
                _request = request;
                _apiCall = apiCall;
                _cancellationToken = cancellationToken;
            }

            public TResponse Current { get; private set; }

            public async ValueTask<bool> MoveNextAsync()
            {
                _cancellationToken.ThrowIfCancellationRequested();
                if (_finished)
                {
                    return false;
                }
                CallSettings effectiveCallSettings = _callSettings;
                if (_cancellationToken != default(CancellationToken))
                {
                    effectiveCallSettings = _callSettings.WithCancellationToken(_cancellationToken);
                }
                Current = await _apiCall.Async(_request, effectiveCallSettings).ConfigureAwait(false);
                var nextPageToken = Current.NextPageToken;
                if (nextPageToken == "")
                {
                    _finished = true;
                }
                // Prepare the next request...
                _request.PageToken = nextPageToken;
                return true;
            }

            public ValueTask DisposeAsync() => default;
        }
    }
}
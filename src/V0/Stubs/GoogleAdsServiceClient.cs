// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V0.Services {

  /// <summary>
  /// Settings for a <see cref="GoogleAdsServiceClient"/>.
  /// </summary>
  public sealed partial class GoogleAdsServiceSettings : ServiceSettingsBase {

    /// <summary>
    /// Get a new instance of the default <see cref="GoogleAdsServiceSettings"/>.
    /// </summary>
    /// <returns>
    /// A new instance of the default <see cref="GoogleAdsServiceSettings"/>.
    /// </returns>
    public static GoogleAdsServiceSettings GetDefault() => new GoogleAdsServiceSettings();

    /// <summary>
    /// Constructs a new <see cref="GoogleAdsServiceSettings"/> object with default settings.
    /// </summary>
    public GoogleAdsServiceSettings() {
    }

    private GoogleAdsServiceSettings(GoogleAdsServiceSettings existing) : base(existing) {
      GaxPreconditions.CheckNotNull(existing, nameof(existing));
      SearchSettings = existing.SearchSettings;
      OnCopy(existing);
    }

    partial void OnCopy(GoogleAdsServiceSettings existing);

    /// <summary>
    /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
    /// for "Idempotent" <see cref="GoogleAdsServiceClient"/> RPC methods.
    /// </summary>
    /// <remarks>
    /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
    /// <list type="bullet">
    /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
    /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
    /// </list>
    /// </remarks>
    public static Predicate<RpcException> IdempotentRetryFilter {
      get;
    } =
        RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

    /// <summary>
    /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
    /// for "NonIdempotent" <see cref="GoogleAdsServiceClient"/> RPC methods.
    /// </summary>
    /// <remarks>
    /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
    /// </remarks>
    public static Predicate<RpcException> NonIdempotentRetryFilter {
      get;
    } =
        RetrySettings.FilterForStatusCodes();

    /// <summary>
    /// "Default" retry backoff for <see cref="GoogleAdsServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" retry backoff for <see cref="GoogleAdsServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" retry backoff for <see cref="GoogleAdsServiceClient"/> RPC methods is defined as:
    /// <list type="bullet">
    /// <item><description>Initial delay: 100 milliseconds</description></item>
    /// <item><description>Maximum delay: 60000 milliseconds</description></item>
    /// <item><description>Delay multiplier: 1.3</description></item>
    /// </list>
    /// </remarks>
    public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
        delay: TimeSpan.FromMilliseconds(100),
        maxDelay: TimeSpan.FromMilliseconds(60000),
        delayMultiplier: 1.3
    );

    /// <summary>
    /// "Default" timeout backoff for <see cref="GoogleAdsServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" timeout backoff for <see cref="GoogleAdsServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" timeout backoff for <see cref="GoogleAdsServiceClient"/> RPC methods is defined as:
    /// <list type="bullet">
    /// <item><description>Initial timeout: 20000 milliseconds</description></item>
    /// <item><description>Timeout multiplier: 1.0</description></item>
    /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
    /// </list>
    /// </remarks>
    public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
        delay: TimeSpan.FromMilliseconds(20000),
        maxDelay: TimeSpan.FromMilliseconds(20000),
        delayMultiplier: 1.0
    );

    /// <summary>
    /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
    /// <c>GoogleAdsServiceClient.Search</c> and <c>GoogleAdsServiceClient.SearchAsync</c>.
    /// </summary>
    /// <remarks>
    /// The default <c>GoogleAdsServiceClient.Search</c> and
    /// <c>GoogleAdsServiceClient.SearchAsync</c> <see cref="RetrySettings"/> are:
    /// <list type="bullet">
    /// <item><description>Initial retry delay: 100 milliseconds</description></item>
    /// <item><description>Retry delay multiplier: 1.3</description></item>
    /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
    /// <item><description>Initial timeout: 20000 milliseconds</description></item>
    /// <item><description>Timeout multiplier: 1.0</description></item>
    /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
    /// </list>
    /// Retry will be attempted on the following response status codes:
    /// <list>
    /// <item><description>No status codes</description></item>
    /// </list>
    /// Default RPC expiration is 600000 milliseconds.
    /// </remarks>
    public CallSettings SearchSettings {
      get; set;
    } = CallSettings.FromCallTiming(
        CallTiming.FromRetry(new RetrySettings(
            retryBackoff: GetDefaultRetryBackoff(),
            timeoutBackoff: GetDefaultTimeoutBackoff(),
            totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            retryFilter: NonIdempotentRetryFilter
        )));

    /// <summary>
    /// Creates a deep clone of this object, with all the same property values.
    /// </summary>
    /// <returns>A deep clone of this <see cref="GoogleAdsServiceSettings"/> object.</returns>
    public GoogleAdsServiceSettings Clone() => new GoogleAdsServiceSettings(this);
  }

  /// <summary>
  /// GoogleAdsService client wrapper, for convenient use.
  /// </summary>
  public abstract partial class GoogleAdsServiceClient {

    /// <summary>
    /// The default endpoint for the GoogleAdsService service, which is a host of "googleads.googleapis.com" and a port of 443.
    /// </summary>
    public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("googleads.googleapis.com", 443);

    /// <summary>
    /// The default GoogleAdsService scopes.
    /// </summary>
    /// <remarks>
    /// The default GoogleAdsService scopes are:
    /// <list type="bullet">
    /// </list>
    /// </remarks>
    public static IReadOnlyList<string> DefaultScopes {
      get;
    } = new ReadOnlyCollection<string>(new string[] {
        });

    private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

    // Note: we could have parameterless overloads of Create and CreateAsync,
    // documented to just use the default endpoint, settings and credentials.
    // Pros:
    // - Might be more reassuring on first use
    // - Allows method group conversions
    // Con: overloads!

    /// <summary>
    /// Asynchronously creates a <see cref="GoogleAdsServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary.
    /// </summary>
    /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="GoogleAdsServiceSettings"/>.</param>
    /// <returns>The task representing the created <see cref="GoogleAdsServiceClient"/>.</returns>
    public static async Task<GoogleAdsServiceClient> CreateAsync(ServiceEndpoint endpoint = null, GoogleAdsServiceSettings settings = null) {
      Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
      return Create(channel, settings);
    }

    /// <summary>
    /// Synchronously creates a <see cref="GoogleAdsServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary.
    /// </summary>
    /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="GoogleAdsServiceSettings"/>.</param>
    /// <returns>The created <see cref="GoogleAdsServiceClient"/>.</returns>
    public static GoogleAdsServiceClient Create(ServiceEndpoint endpoint = null, GoogleAdsServiceSettings settings = null) {
      Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
      return Create(channel, settings);
    }

    /// <summary>
    /// Creates a <see cref="GoogleAdsServiceClient"/> which uses the specified channel for remote operations.
    /// </summary>
    /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
    /// <param name="settings">Optional <see cref="GoogleAdsServiceSettings"/>.</param>
    /// <returns>The created <see cref="GoogleAdsServiceClient"/>.</returns>
    public static GoogleAdsServiceClient Create(Channel channel, GoogleAdsServiceSettings settings = null) {
      GaxPreconditions.CheckNotNull(channel, nameof(channel));
      GoogleAdsService.GoogleAdsServiceClient grpcClient = new GoogleAdsService.GoogleAdsServiceClient(channel);
      return new GoogleAdsServiceClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, GoogleAdsServiceSettings)"/>
    /// and <see cref="CreateAsync(ServiceEndpoint, GoogleAdsServiceSettings)"/>. Channels which weren't automatically
    /// created are not affected.
    /// </summary>
    /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, GoogleAdsServiceSettings)"/>
    /// and <see cref="CreateAsync(ServiceEndpoint, GoogleAdsServiceSettings)"/> will create new channels, which could
    /// in turn be shut down by another call to this method.</remarks>
    /// <returns>A task representing the asynchronous shutdown operation.</returns>
    public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

    /// <summary>
    /// The underlying gRPC GoogleAdsService client.
    /// </summary>
    public virtual GoogleAdsService.GoogleAdsServiceClient GrpcClient {
      get {
        throw new NotImplementedException();
      }
    }

    /// <summary>
    /// Returns all rows that match the search query.
    /// </summary>
    /// <param name="customerId">
    /// The ID of the customer being queried.
    /// </param>
    /// <param name="query">
    /// The query string.
    /// </param>
    /// <param name="pageToken">
    /// The token returned from the previous request.
    /// A value of <c>null</c> or an empty string retrieves the first page.
    /// </param>
    /// <param name="pageSize">
    /// The size of page to request. The response will not be larger than this, but may be smaller.
    /// A value of <c>null</c> or 0 uses a server-defined page size.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A pageable asynchronous sequence of <see cref="GoogleAdsRow"/> resources.
    /// </returns>
    public virtual PagedAsyncEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> SearchAsync(
        string customerId,
        string query,
        string pageToken = null,
        int? pageSize = null,
        CallSettings callSettings = null) => SearchAsync(
            new SearchGoogleAdsRequest {
              CustomerId = GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
              Query = GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
              PageToken = pageToken ?? "",
              PageSize = pageSize ?? 0,
            },
            callSettings);

    /// <summary>
    /// Returns all rows that match the search query.
    /// </summary>
    /// <param name="customerId">
    /// The ID of the customer being queried.
    /// </param>
    /// <param name="query">
    /// The query string.
    /// </param>
    /// <param name="pageToken">
    /// The token returned from the previous request.
    /// A value of <c>null</c> or an empty string retrieves the first page.
    /// </param>
    /// <param name="pageSize">
    /// The size of page to request. The response will not be larger than this, but may be smaller.
    /// A value of <c>null</c> or 0 uses a server-defined page size.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A pageable sequence of <see cref="GoogleAdsRow"/> resources.
    /// </returns>
    public virtual PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> Search(
        string customerId,
        string query,
        string pageToken = null,
        int? pageSize = null,
        CallSettings callSettings = null) => Search(
            new SearchGoogleAdsRequest {
              CustomerId = GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
              Query = GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
              PageToken = pageToken ?? "",
              PageSize = pageSize ?? 0,
            },
            callSettings);

    /// <summary>
    /// Returns all rows that match the search query.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A pageable asynchronous sequence of <see cref="GoogleAdsRow"/> resources.
    /// </returns>
    public virtual PagedAsyncEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> SearchAsync(
        SearchGoogleAdsRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Returns all rows that match the search query.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A pageable sequence of <see cref="GoogleAdsRow"/> resources.
    /// </returns>
    public virtual PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> Search(
        SearchGoogleAdsRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }
  }

  /// <summary>
  /// GoogleAdsService client wrapper implementation, for convenient use.
  /// </summary>
  public sealed partial class GoogleAdsServiceClientImpl : GoogleAdsServiceClient {
    private readonly ApiCall<SearchGoogleAdsRequest, SearchGoogleAdsResponse> _callSearch;

    /// <summary>
    /// Constructs a client wrapper for the GoogleAdsService service, with the specified gRPC client and settings.
    /// </summary>
    /// <param name="grpcClient">The underlying gRPC client.</param>
    /// <param name="settings">The base <see cref="GoogleAdsServiceSettings"/> used within this client </param>
    public GoogleAdsServiceClientImpl(GoogleAdsService.GoogleAdsServiceClient grpcClient, GoogleAdsServiceSettings settings) {
      GrpcClient = grpcClient;
      GoogleAdsServiceSettings effectiveSettings = settings ?? GoogleAdsServiceSettings.GetDefault();
      ClientHelper clientHelper = new ClientHelper(effectiveSettings);
      _callSearch = clientHelper.BuildApiCall<SearchGoogleAdsRequest, SearchGoogleAdsResponse>(
          GrpcClient.SearchAsync, GrpcClient.Search, effectiveSettings.SearchSettings);
      Modify_ApiCall(ref _callSearch);
      Modify_SearchApiCall(ref _callSearch);
      OnConstruction(grpcClient, effectiveSettings, clientHelper);
    }

    // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

    // Partial methods called for every ApiCall on construction.
    // Allows modification of all the underlying ApiCall objects.
    partial void Modify_ApiCall<TRequest, TResponse>(ref ApiCall<TRequest, TResponse> call)
        where TRequest : class, IMessage<TRequest>
        where TResponse : class, IMessage<TResponse>;

    // Partial methods called for each ApiCall on construction.
    // Allows per-RPC-method modification of the underlying ApiCall object.
    partial void Modify_SearchApiCall(ref ApiCall<SearchGoogleAdsRequest, SearchGoogleAdsResponse> call);

    partial void OnConstruction(GoogleAdsService.GoogleAdsServiceClient grpcClient, GoogleAdsServiceSettings effectiveSettings, ClientHelper clientHelper);

    /// <summary>
    /// The underlying gRPC GoogleAdsService client.
    /// </summary>
    public override GoogleAdsService.GoogleAdsServiceClient GrpcClient {
      get;
    }

    // Partial methods called on each request.
    // Allows per-RPC-call modification to the request and CallSettings objects,
    // before the underlying RPC is performed.
    partial void Modify_SearchGoogleAdsRequest(ref SearchGoogleAdsRequest request, ref CallSettings settings);

    /// <summary>
    /// Returns all rows that match the search query.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A pageable asynchronous sequence of <see cref="GoogleAdsRow"/> resources.
    /// </returns>
    public override PagedAsyncEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> SearchAsync(
        SearchGoogleAdsRequest request,
        CallSettings callSettings = null) {
      Modify_SearchGoogleAdsRequest(ref request, ref callSettings);
      return new GrpcPagedAsyncEnumerable<SearchGoogleAdsRequest, SearchGoogleAdsResponse, GoogleAdsRow>(_callSearch, request, callSettings);
    }

    /// <summary>
    /// Returns all rows that match the search query.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A pageable sequence of <see cref="GoogleAdsRow"/> resources.
    /// </returns>
    public override PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> Search(
        SearchGoogleAdsRequest request,
        CallSettings callSettings = null) {
      Modify_SearchGoogleAdsRequest(ref request, ref callSettings);
      return new GrpcPagedEnumerable<SearchGoogleAdsRequest, SearchGoogleAdsResponse, GoogleAdsRow>(_callSearch, request, callSettings);
    }
  }

  // Partial classes to enable page-streaming

  public partial class SearchGoogleAdsRequest : IPageRequest {
  }

  public partial class SearchGoogleAdsResponse : IPageResponse<GoogleAdsRow> {

    /// <summary>
    /// Returns an enumerator that iterates through the resources in this response.
    /// </summary>
    public IEnumerator<GoogleAdsRow> GetEnumerator() => Results.GetEnumerator();

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
  }
}
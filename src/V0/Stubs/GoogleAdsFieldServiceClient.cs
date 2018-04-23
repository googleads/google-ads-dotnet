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

using Google.Ads.GoogleAds.V0.Resources;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V0.Services {

  /// <summary>
  /// Settings for a <see cref="GoogleAdsFieldServiceClient"/>.
  /// </summary>
  public sealed partial class GoogleAdsFieldServiceSettings : ServiceSettingsBase {

    /// <summary>
    /// Get a new instance of the default <see cref="GoogleAdsFieldServiceSettings"/>.
    /// </summary>
    /// <returns>
    /// A new instance of the default <see cref="GoogleAdsFieldServiceSettings"/>.
    /// </returns>
    public static GoogleAdsFieldServiceSettings GetDefault() => new GoogleAdsFieldServiceSettings();

    /// <summary>
    /// Constructs a new <see cref="GoogleAdsFieldServiceSettings"/> object with default settings.
    /// </summary>
    public GoogleAdsFieldServiceSettings() {
    }

    private GoogleAdsFieldServiceSettings(GoogleAdsFieldServiceSettings existing) : base(existing) {
      GaxPreconditions.CheckNotNull(existing, nameof(existing));
      GetGoogleAdsFieldSettings = existing.GetGoogleAdsFieldSettings;
      SearchGoogleAdsFieldsSettings = existing.SearchGoogleAdsFieldsSettings;
      OnCopy(existing);
    }

    partial void OnCopy(GoogleAdsFieldServiceSettings existing);

    /// <summary>
    /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
    /// for "Idempotent" <see cref="GoogleAdsFieldServiceClient"/> RPC methods.
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
    /// for "NonIdempotent" <see cref="GoogleAdsFieldServiceClient"/> RPC methods.
    /// </summary>
    /// <remarks>
    /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
    /// </remarks>
    public static Predicate<RpcException> NonIdempotentRetryFilter {
      get;
    } =
        RetrySettings.FilterForStatusCodes();

    /// <summary>
    /// "Default" retry backoff for <see cref="GoogleAdsFieldServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" retry backoff for <see cref="GoogleAdsFieldServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" retry backoff for <see cref="GoogleAdsFieldServiceClient"/> RPC methods is defined as:
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
    /// "Default" timeout backoff for <see cref="GoogleAdsFieldServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" timeout backoff for <see cref="GoogleAdsFieldServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" timeout backoff for <see cref="GoogleAdsFieldServiceClient"/> RPC methods is defined as:
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
    /// <c>GoogleAdsFieldServiceClient.GetGoogleAdsField</c> and <c>GoogleAdsFieldServiceClient.GetGoogleAdsFieldAsync</c>.
    /// </summary>
    /// <remarks>
    /// The default <c>GoogleAdsFieldServiceClient.GetGoogleAdsField</c> and
    /// <c>GoogleAdsFieldServiceClient.GetGoogleAdsFieldAsync</c> <see cref="RetrySettings"/> are:
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
    /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
    /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
    /// </list>
    /// Default RPC expiration is 600000 milliseconds.
    /// </remarks>
    public CallSettings GetGoogleAdsFieldSettings {
      get; set;
    } = CallSettings.FromCallTiming(
        CallTiming.FromRetry(new RetrySettings(
            retryBackoff: GetDefaultRetryBackoff(),
            timeoutBackoff: GetDefaultTimeoutBackoff(),
            totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            retryFilter: IdempotentRetryFilter
        )));

    /// <summary>
    /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
    /// <c>GoogleAdsFieldServiceClient.SearchGoogleAdsFields</c> and <c>GoogleAdsFieldServiceClient.SearchGoogleAdsFieldsAsync</c>.
    /// </summary>
    /// <remarks>
    /// The default <c>GoogleAdsFieldServiceClient.SearchGoogleAdsFields</c> and
    /// <c>GoogleAdsFieldServiceClient.SearchGoogleAdsFieldsAsync</c> <see cref="RetrySettings"/> are:
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
    public CallSettings SearchGoogleAdsFieldsSettings {
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
    /// <returns>A deep clone of this <see cref="GoogleAdsFieldServiceSettings"/> object.</returns>
    public GoogleAdsFieldServiceSettings Clone() => new GoogleAdsFieldServiceSettings(this);
  }

  /// <summary>
  /// GoogleAdsFieldService client wrapper, for convenient use.
  /// </summary>
  public abstract partial class GoogleAdsFieldServiceClient {

    /// <summary>
    /// The default endpoint for the GoogleAdsFieldService service, which is a host of "googleads.googleapis.com" and a port of 443.
    /// </summary>
    public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("googleads.googleapis.com", 443);

    /// <summary>
    /// The default GoogleAdsFieldService scopes.
    /// </summary>
    /// <remarks>
    /// The default GoogleAdsFieldService scopes are:
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
    /// Asynchronously creates a <see cref="GoogleAdsFieldServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary.
    /// </summary>
    /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="GoogleAdsFieldServiceSettings"/>.</param>
    /// <returns>The task representing the created <see cref="GoogleAdsFieldServiceClient"/>.</returns>
    public static async Task<GoogleAdsFieldServiceClient> CreateAsync(ServiceEndpoint endpoint = null, GoogleAdsFieldServiceSettings settings = null) {
      Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
      return Create(channel, settings);
    }

    /// <summary>
    /// Synchronously creates a <see cref="GoogleAdsFieldServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary.
    /// </summary>
    /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="GoogleAdsFieldServiceSettings"/>.</param>
    /// <returns>The created <see cref="GoogleAdsFieldServiceClient"/>.</returns>
    public static GoogleAdsFieldServiceClient Create(ServiceEndpoint endpoint = null, GoogleAdsFieldServiceSettings settings = null) {
      Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
      return Create(channel, settings);
    }

    /// <summary>
    /// Creates a <see cref="GoogleAdsFieldServiceClient"/> which uses the specified channel for remote operations.
    /// </summary>
    /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
    /// <param name="settings">Optional <see cref="GoogleAdsFieldServiceSettings"/>.</param>
    /// <returns>The created <see cref="GoogleAdsFieldServiceClient"/>.</returns>
    public static GoogleAdsFieldServiceClient Create(Channel channel, GoogleAdsFieldServiceSettings settings = null) {
      GaxPreconditions.CheckNotNull(channel, nameof(channel));
      GoogleAdsFieldService.GoogleAdsFieldServiceClient grpcClient = new GoogleAdsFieldService.GoogleAdsFieldServiceClient(channel);
      return new GoogleAdsFieldServiceClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, GoogleAdsFieldServiceSettings)"/>
    /// and <see cref="CreateAsync(ServiceEndpoint, GoogleAdsFieldServiceSettings)"/>. Channels which weren't automatically
    /// created are not affected.
    /// </summary>
    /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, GoogleAdsFieldServiceSettings)"/>
    /// and <see cref="CreateAsync(ServiceEndpoint, GoogleAdsFieldServiceSettings)"/> will create new channels, which could
    /// in turn be shut down by another call to this method.</remarks>
    /// <returns>A task representing the asynchronous shutdown operation.</returns>
    public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

    /// <summary>
    /// The underlying gRPC GoogleAdsFieldService client.
    /// </summary>
    public virtual GoogleAdsFieldService.GoogleAdsFieldServiceClient GrpcClient {
      get {
        throw new NotImplementedException();
      }
    }

    /// <summary>
    /// Returns just the requested field.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the field to get.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<GoogleAdsField> GetGoogleAdsFieldAsync(
        string resourceName,
        CallSettings callSettings = null) => GetGoogleAdsFieldAsync(
            new GetGoogleAdsFieldRequest {
              ResourceName = GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            },
            callSettings);

    /// <summary>
    /// Returns just the requested field.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the field to get.
    /// </param>
    /// <param name="cancellationToken">
    /// A <see cref="CancellationToken"/> to use for this RPC.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<GoogleAdsField> GetGoogleAdsFieldAsync(
        string resourceName,
        CancellationToken cancellationToken) => GetGoogleAdsFieldAsync(
            resourceName,
            CallSettings.FromCancellationToken(cancellationToken));

    /// <summary>
    /// Returns just the requested field.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the field to get.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public virtual GoogleAdsField GetGoogleAdsField(
        string resourceName,
        CallSettings callSettings = null) => GetGoogleAdsField(
            new GetGoogleAdsFieldRequest {
              ResourceName = GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            },
            callSettings);

    /// <summary>
    /// Returns just the requested field.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<GoogleAdsField> GetGoogleAdsFieldAsync(
        GetGoogleAdsFieldRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Returns just the requested field.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public virtual GoogleAdsField GetGoogleAdsField(
        GetGoogleAdsFieldRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Returns all fields that match the search query.
    /// </summary>
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
    /// A pageable asynchronous sequence of <see cref="GoogleAdsField"/> resources.
    /// </returns>
    public virtual PagedAsyncEnumerable<SearchGoogleAdsFieldsResponse, GoogleAdsField> SearchGoogleAdsFieldsAsync(
        string query,
        string pageToken = null,
        int? pageSize = null,
        CallSettings callSettings = null) => SearchGoogleAdsFieldsAsync(
            new SearchGoogleAdsFieldsRequest {
              Query = GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
              PageToken = pageToken ?? "",
              PageSize = pageSize ?? 0,
            },
            callSettings);

    /// <summary>
    /// Returns all fields that match the search query.
    /// </summary>
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
    /// A pageable sequence of <see cref="GoogleAdsField"/> resources.
    /// </returns>
    public virtual PagedEnumerable<SearchGoogleAdsFieldsResponse, GoogleAdsField> SearchGoogleAdsFields(
        string query,
        string pageToken = null,
        int? pageSize = null,
        CallSettings callSettings = null) => SearchGoogleAdsFields(
            new SearchGoogleAdsFieldsRequest {
              Query = GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
              PageToken = pageToken ?? "",
              PageSize = pageSize ?? 0,
            },
            callSettings);

    /// <summary>
    /// Returns all fields that match the search query.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A pageable asynchronous sequence of <see cref="GoogleAdsField"/> resources.
    /// </returns>
    public virtual PagedAsyncEnumerable<SearchGoogleAdsFieldsResponse, GoogleAdsField> SearchGoogleAdsFieldsAsync(
        SearchGoogleAdsFieldsRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Returns all fields that match the search query.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A pageable sequence of <see cref="GoogleAdsField"/> resources.
    /// </returns>
    public virtual PagedEnumerable<SearchGoogleAdsFieldsResponse, GoogleAdsField> SearchGoogleAdsFields(
        SearchGoogleAdsFieldsRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }
  }

  /// <summary>
  /// GoogleAdsFieldService client wrapper implementation, for convenient use.
  /// </summary>
  public sealed partial class GoogleAdsFieldServiceClientImpl : GoogleAdsFieldServiceClient {
    private readonly ApiCall<GetGoogleAdsFieldRequest, GoogleAdsField> _callGetGoogleAdsField;
    private readonly ApiCall<SearchGoogleAdsFieldsRequest, SearchGoogleAdsFieldsResponse> _callSearchGoogleAdsFields;

    /// <summary>
    /// Constructs a client wrapper for the GoogleAdsFieldService service, with the specified gRPC client and settings.
    /// </summary>
    /// <param name="grpcClient">The underlying gRPC client.</param>
    /// <param name="settings">The base <see cref="GoogleAdsFieldServiceSettings"/> used within this client </param>
    public GoogleAdsFieldServiceClientImpl(GoogleAdsFieldService.GoogleAdsFieldServiceClient grpcClient, GoogleAdsFieldServiceSettings settings) {
      GrpcClient = grpcClient;
      GoogleAdsFieldServiceSettings effectiveSettings = settings ?? GoogleAdsFieldServiceSettings.GetDefault();
      ClientHelper clientHelper = new ClientHelper(effectiveSettings);
      _callGetGoogleAdsField = clientHelper.BuildApiCall<GetGoogleAdsFieldRequest, GoogleAdsField>(
          GrpcClient.GetGoogleAdsFieldAsync, GrpcClient.GetGoogleAdsField, effectiveSettings.GetGoogleAdsFieldSettings);
      _callSearchGoogleAdsFields = clientHelper.BuildApiCall<SearchGoogleAdsFieldsRequest, SearchGoogleAdsFieldsResponse>(
          GrpcClient.SearchGoogleAdsFieldsAsync, GrpcClient.SearchGoogleAdsFields, effectiveSettings.SearchGoogleAdsFieldsSettings);
      Modify_ApiCall(ref _callGetGoogleAdsField);
      Modify_GetGoogleAdsFieldApiCall(ref _callGetGoogleAdsField);
      Modify_ApiCall(ref _callSearchGoogleAdsFields);
      Modify_SearchGoogleAdsFieldsApiCall(ref _callSearchGoogleAdsFields);
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
    partial void Modify_GetGoogleAdsFieldApiCall(ref ApiCall<GetGoogleAdsFieldRequest, GoogleAdsField> call);

    partial void Modify_SearchGoogleAdsFieldsApiCall(ref ApiCall<SearchGoogleAdsFieldsRequest, SearchGoogleAdsFieldsResponse> call);

    partial void OnConstruction(GoogleAdsFieldService.GoogleAdsFieldServiceClient grpcClient, GoogleAdsFieldServiceSettings effectiveSettings, ClientHelper clientHelper);

    /// <summary>
    /// The underlying gRPC GoogleAdsFieldService client.
    /// </summary>
    public override GoogleAdsFieldService.GoogleAdsFieldServiceClient GrpcClient {
      get;
    }

    // Partial methods called on each request.
    // Allows per-RPC-call modification to the request and CallSettings objects,
    // before the underlying RPC is performed.
    partial void Modify_GetGoogleAdsFieldRequest(ref GetGoogleAdsFieldRequest request, ref CallSettings settings);

    partial void Modify_SearchGoogleAdsFieldsRequest(ref SearchGoogleAdsFieldsRequest request, ref CallSettings settings);

    /// <summary>
    /// Returns just the requested field.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public override Task<GoogleAdsField> GetGoogleAdsFieldAsync(
        GetGoogleAdsFieldRequest request,
        CallSettings callSettings = null) {
      Modify_GetGoogleAdsFieldRequest(ref request, ref callSettings);
      return _callGetGoogleAdsField.Async(request, callSettings);
    }

    /// <summary>
    /// Returns just the requested field.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public override GoogleAdsField GetGoogleAdsField(
        GetGoogleAdsFieldRequest request,
        CallSettings callSettings = null) {
      Modify_GetGoogleAdsFieldRequest(ref request, ref callSettings);
      return _callGetGoogleAdsField.Sync(request, callSettings);
    }

    /// <summary>
    /// Returns all fields that match the search query.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A pageable asynchronous sequence of <see cref="GoogleAdsField"/> resources.
    /// </returns>
    public override PagedAsyncEnumerable<SearchGoogleAdsFieldsResponse, GoogleAdsField> SearchGoogleAdsFieldsAsync(
        SearchGoogleAdsFieldsRequest request,
        CallSettings callSettings = null) {
      Modify_SearchGoogleAdsFieldsRequest(ref request, ref callSettings);
      return new GrpcPagedAsyncEnumerable<SearchGoogleAdsFieldsRequest, SearchGoogleAdsFieldsResponse, GoogleAdsField>(_callSearchGoogleAdsFields, request, callSettings);
    }

    /// <summary>
    /// Returns all fields that match the search query.
    /// </summary>
    /// <param name="request">
    /// The request object containing all of the parameters for the API call.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A pageable sequence of <see cref="GoogleAdsField"/> resources.
    /// </returns>
    public override PagedEnumerable<SearchGoogleAdsFieldsResponse, GoogleAdsField> SearchGoogleAdsFields(
        SearchGoogleAdsFieldsRequest request,
        CallSettings callSettings = null) {
      Modify_SearchGoogleAdsFieldsRequest(ref request, ref callSettings);
      return new GrpcPagedEnumerable<SearchGoogleAdsFieldsRequest, SearchGoogleAdsFieldsResponse, GoogleAdsField>(_callSearchGoogleAdsFields, request, callSettings);
    }
  }

  // Partial classes to enable page-streaming

  public partial class SearchGoogleAdsFieldsRequest : IPageRequest {
  }

  public partial class SearchGoogleAdsFieldsResponse : IPageResponse<GoogleAdsField> {

    /// <summary>
    /// Returns an enumerator that iterates through the resources in this response.
    /// </summary>
    public IEnumerator<GoogleAdsField> GetEnumerator() => Results.GetEnumerator();

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
  }
}
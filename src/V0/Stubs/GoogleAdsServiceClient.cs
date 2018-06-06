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

using gagvs = Google.Ads.GoogleAds.V0.Services;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using pb = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Ads.GoogleAds.V0.Services {

  /// <summary>
  /// Settings for a <see cref="GoogleAdsServiceClient"/>.
  /// </summary>
  public sealed partial class GoogleAdsServiceSettings : gaxgrpc::ServiceSettingsBase {

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
      gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
      SearchSettings = existing.SearchSettings;
      OnCopy(existing);
    }

    partial void OnCopy(GoogleAdsServiceSettings existing);

    /// <summary>
    /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
    /// for "Idempotent" <see cref="GoogleAdsServiceClient"/> RPC methods.
    /// </summary>
    /// <remarks>
    /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
    /// <list type="bullet">
    /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
    /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
    /// </list>
    /// </remarks>
    public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter {
      get;
    } =
        gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

    /// <summary>
    /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
    /// for "NonIdempotent" <see cref="GoogleAdsServiceClient"/> RPC methods.
    /// </summary>
    /// <remarks>
    /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
    /// </remarks>
    public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter {
      get;
    } =
        gaxgrpc::RetrySettings.FilterForStatusCodes();

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
    public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
        delay: sys::TimeSpan.FromMilliseconds(100),
        maxDelay: sys::TimeSpan.FromMilliseconds(60000),
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
    public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
        delay: sys::TimeSpan.FromMilliseconds(20000),
        maxDelay: sys::TimeSpan.FromMilliseconds(20000),
        delayMultiplier: 1.0
    );

    /// <summary>
    /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
    /// <c>GoogleAdsServiceClient.Search</c> and <c>GoogleAdsServiceClient.SearchAsync</c>.
    /// </summary>
    /// <remarks>
    /// The default <c>GoogleAdsServiceClient.Search</c> and
    /// <c>GoogleAdsServiceClient.SearchAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
    public gaxgrpc::CallSettings SearchSettings {
      get; set;
    } = gaxgrpc::CallSettings.FromCallTiming(
        gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
            retryBackoff: GetDefaultRetryBackoff(),
            timeoutBackoff: GetDefaultTimeoutBackoff(),
            totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
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
    public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

    /// <summary>
    /// The default GoogleAdsService scopes.
    /// </summary>
    /// <remarks>
    /// The default GoogleAdsService scopes are:
    /// <list type="bullet">
    /// </list>
    /// </remarks>
    public static scg::IReadOnlyList<string> DefaultScopes {
      get;
    } = new sco::ReadOnlyCollection<string>(new string[] {
        });

    private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

    /// <summary>
    /// Asynchronously creates a <see cref="GoogleAdsServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary. See the example for how to use custom credentials.
    /// </summary>
    /// <example>
    /// This sample shows how to create a client using default credentials:
    /// <code>
    /// using Google.Ads.Googleads.V0.Services;
    /// ...
    /// // When running on Google Cloud Platform this will use the project Compute Credential.
    /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
    /// // credential file to use that credential.
    /// GoogleAdsServiceClient client = await GoogleAdsServiceClient.CreateAsync();
    /// </code>
    /// This sample shows how to create a client using credentials loaded from a JSON file:
    /// <code>
    /// using Google.Ads.Googleads.V0.Services;
    /// using Google.Apis.Auth.OAuth2;
    /// using Grpc.Auth;
    /// using Grpc.Core;
    /// ...
    /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
    /// Channel channel = new Channel(
    ///     GoogleAdsServiceClient.DefaultEndpoint.Host, GoogleAdsServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
    /// GoogleAdsServiceClient client = GoogleAdsServiceClient.Create(channel);
    /// ...
    /// // Shutdown the channel when it is no longer required.
    /// await channel.ShutdownAsync();
    /// </code>
    /// </example>
    /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="GoogleAdsServiceSettings"/>.</param>
    /// <returns>The task representing the created <see cref="GoogleAdsServiceClient"/>.</returns>
    public static async stt::Task<GoogleAdsServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, GoogleAdsServiceSettings settings = null) {
      grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
      return Create(channel, settings);
    }

    /// <summary>
    /// Synchronously creates a <see cref="GoogleAdsServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary. See the example for how to use custom credentials.
    /// </summary>
    /// <example>
    /// This sample shows how to create a client using default credentials:
    /// <code>
    /// using Google.Ads.Googleads.V0.Services;
    /// ...
    /// // When running on Google Cloud Platform this will use the project Compute Credential.
    /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
    /// // credential file to use that credential.
    /// GoogleAdsServiceClient client = GoogleAdsServiceClient.Create();
    /// </code>
    /// This sample shows how to create a client using credentials loaded from a JSON file:
    /// <code>
    /// using Google.Ads.Googleads.V0.Services;
    /// using Google.Apis.Auth.OAuth2;
    /// using Grpc.Auth;
    /// using Grpc.Core;
    /// ...
    /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
    /// Channel channel = new Channel(
    ///     GoogleAdsServiceClient.DefaultEndpoint.Host, GoogleAdsServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
    /// GoogleAdsServiceClient client = GoogleAdsServiceClient.Create(channel);
    /// ...
    /// // Shutdown the channel when it is no longer required.
    /// channel.ShutdownAsync().Wait();
    /// </code>
    /// </example>
    /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="GoogleAdsServiceSettings"/>.</param>
    /// <returns>The created <see cref="GoogleAdsServiceClient"/>.</returns>
    public static GoogleAdsServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, GoogleAdsServiceSettings settings = null) {
      grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
      return Create(channel, settings);
    }

    /// <summary>
    /// Creates a <see cref="GoogleAdsServiceClient"/> which uses the specified channel for remote operations.
    /// </summary>
    /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
    /// <param name="settings">Optional <see cref="GoogleAdsServiceSettings"/>.</param>
    /// <returns>The created <see cref="GoogleAdsServiceClient"/>.</returns>
    public static GoogleAdsServiceClient Create(grpccore::Channel channel, GoogleAdsServiceSettings settings = null) {
      gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
      GoogleAdsService.GoogleAdsServiceClient grpcClient = new GoogleAdsService.GoogleAdsServiceClient(channel);
      return new GoogleAdsServiceClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, GoogleAdsServiceSettings)"/>
    /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, GoogleAdsServiceSettings)"/>. Channels which weren't automatically
    /// created are not affected.
    /// </summary>
    /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, GoogleAdsServiceSettings)"/>
    /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, GoogleAdsServiceSettings)"/> will create new channels, which could
    /// in turn be shut down by another call to this method.</remarks>
    /// <returns>A task representing the asynchronous shutdown operation.</returns>
    public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

    /// <summary>
    /// The underlying gRPC GoogleAdsService client.
    /// </summary>
    public virtual GoogleAdsService.GoogleAdsServiceClient GrpcClient {
      get {
        throw new sys::NotImplementedException();
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
    /// A pageable asynchronous sequence of <see cref="gagvs::GoogleAdsRow"/> resources.
    /// </returns>
    public virtual gax::PagedAsyncEnumerable<gagvs::SearchGoogleAdsResponse, gagvs::GoogleAdsRow> SearchAsync(
        string customerId,
        string query,
        string pageToken = null,
        int? pageSize = null,
        gaxgrpc::CallSettings callSettings = null) => SearchAsync(
            new gagvs::SearchGoogleAdsRequest {
              CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
              Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
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
    /// A pageable sequence of <see cref="gagvs::GoogleAdsRow"/> resources.
    /// </returns>
    public virtual gax::PagedEnumerable<gagvs::SearchGoogleAdsResponse, gagvs::GoogleAdsRow> Search(
        string customerId,
        string query,
        string pageToken = null,
        int? pageSize = null,
        gaxgrpc::CallSettings callSettings = null) => Search(
            new gagvs::SearchGoogleAdsRequest {
              CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
              Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
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
    /// A pageable asynchronous sequence of <see cref="gagvs::GoogleAdsRow"/> resources.
    /// </returns>
    public virtual gax::PagedAsyncEnumerable<gagvs::SearchGoogleAdsResponse, gagvs::GoogleAdsRow> SearchAsync(
        gagvs::SearchGoogleAdsRequest request,
        gaxgrpc::CallSettings callSettings = null) {
      throw new sys::NotImplementedException();
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
    /// A pageable sequence of <see cref="gagvs::GoogleAdsRow"/> resources.
    /// </returns>
    public virtual gax::PagedEnumerable<gagvs::SearchGoogleAdsResponse, gagvs::GoogleAdsRow> Search(
        gagvs::SearchGoogleAdsRequest request,
        gaxgrpc::CallSettings callSettings = null) {
      throw new sys::NotImplementedException();
    }
  }

  /// <summary>
  /// GoogleAdsService client wrapper implementation, for convenient use.
  /// </summary>
  public sealed partial class GoogleAdsServiceClientImpl : GoogleAdsServiceClient {
    private readonly gaxgrpc::ApiCall<gagvs::SearchGoogleAdsRequest, gagvs::SearchGoogleAdsResponse> _callSearch;

    /// <summary>
    /// Constructs a client wrapper for the GoogleAdsService service, with the specified gRPC client and settings.
    /// </summary>
    /// <param name="grpcClient">The underlying gRPC client.</param>
    /// <param name="settings">The base <see cref="GoogleAdsServiceSettings"/> used within this client </param>
    public GoogleAdsServiceClientImpl(GoogleAdsService.GoogleAdsServiceClient grpcClient, GoogleAdsServiceSettings settings) {
      GrpcClient = grpcClient;
      GoogleAdsServiceSettings effectiveSettings = settings ?? GoogleAdsServiceSettings.GetDefault();
      gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
      _callSearch = clientHelper.BuildApiCall<gagvs::SearchGoogleAdsRequest, gagvs::SearchGoogleAdsResponse>(
          GrpcClient.SearchAsync, GrpcClient.Search, effectiveSettings.SearchSettings);
      Modify_ApiCall(ref _callSearch);
      Modify_SearchApiCall(ref _callSearch);
      OnConstruction(grpcClient, effectiveSettings, clientHelper);
    }

    // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

    // Partial methods called for every ApiCall on construction.
    // Allows modification of all the underlying ApiCall objects.
    partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
        where TRequest : class, pb::IMessage<TRequest>
        where TResponse : class, pb::IMessage<TResponse>;

    // Partial methods called for each ApiCall on construction.
    // Allows per-RPC-method modification of the underlying ApiCall object.
    partial void Modify_SearchApiCall(ref gaxgrpc::ApiCall<gagvs::SearchGoogleAdsRequest, gagvs::SearchGoogleAdsResponse> call);

    partial void OnConstruction(GoogleAdsService.GoogleAdsServiceClient grpcClient, GoogleAdsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

    /// <summary>
    /// The underlying gRPC GoogleAdsService client.
    /// </summary>
    public override GoogleAdsService.GoogleAdsServiceClient GrpcClient {
      get;
    }

    // Partial methods called on each request.
    // Allows per-RPC-call modification to the request and CallSettings objects,
    // before the underlying RPC is performed.
    partial void Modify_SearchGoogleAdsRequest(ref gagvs::SearchGoogleAdsRequest request, ref gaxgrpc::CallSettings settings);

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
    /// A pageable asynchronous sequence of <see cref="gagvs::GoogleAdsRow"/> resources.
    /// </returns>
    public override gax::PagedAsyncEnumerable<gagvs::SearchGoogleAdsResponse, gagvs::GoogleAdsRow> SearchAsync(
        gagvs::SearchGoogleAdsRequest request,
        gaxgrpc::CallSettings callSettings = null) {
      Modify_SearchGoogleAdsRequest(ref request, ref callSettings);
      return new gaxgrpc::GrpcPagedAsyncEnumerable<gagvs::SearchGoogleAdsRequest, gagvs::SearchGoogleAdsResponse, gagvs::GoogleAdsRow>(_callSearch, request, callSettings);
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
    /// A pageable sequence of <see cref="gagvs::GoogleAdsRow"/> resources.
    /// </returns>
    public override gax::PagedEnumerable<gagvs::SearchGoogleAdsResponse, gagvs::GoogleAdsRow> Search(
        gagvs::SearchGoogleAdsRequest request,
        gaxgrpc::CallSettings callSettings = null) {
      Modify_SearchGoogleAdsRequest(ref request, ref callSettings);
      return new gaxgrpc::GrpcPagedEnumerable<gagvs::SearchGoogleAdsRequest, gagvs::SearchGoogleAdsResponse, gagvs::GoogleAdsRow>(_callSearch, request, callSettings);
    }
  }

  // Partial classes to enable page-streaming

  public partial class SearchGoogleAdsRequest : gaxgrpc::IPageRequest {
  }

  public partial class SearchGoogleAdsResponse : gaxgrpc::IPageResponse<gagvs::GoogleAdsRow> {

    /// <summary>
    /// Returns an enumerator that iterates through the resources in this response.
    /// </summary>
    public scg::IEnumerator<gagvs::GoogleAdsRow> GetEnumerator() => Results.GetEnumerator();

    /// <inheritdoc/>
    sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
  }
}
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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V0.Services {

  /// <summary>
  /// Settings for a <see cref="KeywordViewServiceClient"/>.
  /// </summary>
  public sealed partial class KeywordViewServiceSettings : ServiceSettingsBase {

    /// <summary>
    /// Get a new instance of the default <see cref="KeywordViewServiceSettings"/>.
    /// </summary>
    /// <returns>
    /// A new instance of the default <see cref="KeywordViewServiceSettings"/>.
    /// </returns>
    public static KeywordViewServiceSettings GetDefault() => new KeywordViewServiceSettings();

    /// <summary>
    /// Constructs a new <see cref="KeywordViewServiceSettings"/> object with default settings.
    /// </summary>
    public KeywordViewServiceSettings() {
    }

    private KeywordViewServiceSettings(KeywordViewServiceSettings existing) : base(existing) {
      GaxPreconditions.CheckNotNull(existing, nameof(existing));
      GetKeywordViewSettings = existing.GetKeywordViewSettings;
      OnCopy(existing);
    }

    partial void OnCopy(KeywordViewServiceSettings existing);

    /// <summary>
    /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
    /// for "Idempotent" <see cref="KeywordViewServiceClient"/> RPC methods.
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
    /// for "NonIdempotent" <see cref="KeywordViewServiceClient"/> RPC methods.
    /// </summary>
    /// <remarks>
    /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
    /// </remarks>
    public static Predicate<RpcException> NonIdempotentRetryFilter {
      get;
    } =
        RetrySettings.FilterForStatusCodes();

    /// <summary>
    /// "Default" retry backoff for <see cref="KeywordViewServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" retry backoff for <see cref="KeywordViewServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" retry backoff for <see cref="KeywordViewServiceClient"/> RPC methods is defined as:
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
    /// "Default" timeout backoff for <see cref="KeywordViewServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" timeout backoff for <see cref="KeywordViewServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" timeout backoff for <see cref="KeywordViewServiceClient"/> RPC methods is defined as:
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
    /// <c>KeywordViewServiceClient.GetKeywordView</c> and <c>KeywordViewServiceClient.GetKeywordViewAsync</c>.
    /// </summary>
    /// <remarks>
    /// The default <c>KeywordViewServiceClient.GetKeywordView</c> and
    /// <c>KeywordViewServiceClient.GetKeywordViewAsync</c> <see cref="RetrySettings"/> are:
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
    public CallSettings GetKeywordViewSettings {
      get; set;
    } = CallSettings.FromCallTiming(
        CallTiming.FromRetry(new RetrySettings(
            retryBackoff: GetDefaultRetryBackoff(),
            timeoutBackoff: GetDefaultTimeoutBackoff(),
            totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            retryFilter: IdempotentRetryFilter
        )));

    /// <summary>
    /// Creates a deep clone of this object, with all the same property values.
    /// </summary>
    /// <returns>A deep clone of this <see cref="KeywordViewServiceSettings"/> object.</returns>
    public KeywordViewServiceSettings Clone() => new KeywordViewServiceSettings(this);
  }

  /// <summary>
  /// KeywordViewService client wrapper, for convenient use.
  /// </summary>
  public abstract partial class KeywordViewServiceClient {

    /// <summary>
    /// The default endpoint for the KeywordViewService service, which is a host of "googleads.googleapis.com" and a port of 443.
    /// </summary>
    public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("googleads.googleapis.com", 443);

    /// <summary>
    /// The default KeywordViewService scopes.
    /// </summary>
    /// <remarks>
    /// The default KeywordViewService scopes are:
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
    /// Asynchronously creates a <see cref="KeywordViewServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary.
    /// </summary>
    /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="KeywordViewServiceSettings"/>.</param>
    /// <returns>The task representing the created <see cref="KeywordViewServiceClient"/>.</returns>
    public static async Task<KeywordViewServiceClient> CreateAsync(ServiceEndpoint endpoint = null, KeywordViewServiceSettings settings = null) {
      Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
      return Create(channel, settings);
    }

    /// <summary>
    /// Synchronously creates a <see cref="KeywordViewServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary.
    /// </summary>
    /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="KeywordViewServiceSettings"/>.</param>
    /// <returns>The created <see cref="KeywordViewServiceClient"/>.</returns>
    public static KeywordViewServiceClient Create(ServiceEndpoint endpoint = null, KeywordViewServiceSettings settings = null) {
      Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
      return Create(channel, settings);
    }

    /// <summary>
    /// Creates a <see cref="KeywordViewServiceClient"/> which uses the specified channel for remote operations.
    /// </summary>
    /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
    /// <param name="settings">Optional <see cref="KeywordViewServiceSettings"/>.</param>
    /// <returns>The created <see cref="KeywordViewServiceClient"/>.</returns>
    public static KeywordViewServiceClient Create(Channel channel, KeywordViewServiceSettings settings = null) {
      GaxPreconditions.CheckNotNull(channel, nameof(channel));
      KeywordViewService.KeywordViewServiceClient grpcClient = new KeywordViewService.KeywordViewServiceClient(channel);
      return new KeywordViewServiceClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, KeywordViewServiceSettings)"/>
    /// and <see cref="CreateAsync(ServiceEndpoint, KeywordViewServiceSettings)"/>. Channels which weren't automatically
    /// created are not affected.
    /// </summary>
    /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, KeywordViewServiceSettings)"/>
    /// and <see cref="CreateAsync(ServiceEndpoint, KeywordViewServiceSettings)"/> will create new channels, which could
    /// in turn be shut down by another call to this method.</remarks>
    /// <returns>A task representing the asynchronous shutdown operation.</returns>
    public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

    /// <summary>
    /// The underlying gRPC KeywordViewService client.
    /// </summary>
    public virtual KeywordViewService.KeywordViewServiceClient GrpcClient {
      get {
        throw new NotImplementedException();
      }
    }

    /// <summary>
    /// Returns the requested keyword view in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the keyword view to fetch.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<KeywordView> GetKeywordViewAsync(
        string resourceName,
        CallSettings callSettings = null) => GetKeywordViewAsync(
            new GetKeywordViewRequest {
              ResourceName = GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            },
            callSettings);

    /// <summary>
    /// Returns the requested keyword view in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the keyword view to fetch.
    /// </param>
    /// <param name="cancellationToken">
    /// A <see cref="CancellationToken"/> to use for this RPC.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<KeywordView> GetKeywordViewAsync(
        string resourceName,
        CancellationToken cancellationToken) => GetKeywordViewAsync(
            resourceName,
            CallSettings.FromCancellationToken(cancellationToken));

    /// <summary>
    /// Returns the requested keyword view in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the keyword view to fetch.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public virtual KeywordView GetKeywordView(
        string resourceName,
        CallSettings callSettings = null) => GetKeywordView(
            new GetKeywordViewRequest {
              ResourceName = GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            },
            callSettings);

    /// <summary>
    /// Returns the requested keyword view in full detail.
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
    public virtual Task<KeywordView> GetKeywordViewAsync(
        GetKeywordViewRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the requested keyword view in full detail.
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
    public virtual KeywordView GetKeywordView(
        GetKeywordViewRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }
  }

  /// <summary>
  /// KeywordViewService client wrapper implementation, for convenient use.
  /// </summary>
  public sealed partial class KeywordViewServiceClientImpl : KeywordViewServiceClient {
    private readonly ApiCall<GetKeywordViewRequest, KeywordView> _callGetKeywordView;

    /// <summary>
    /// Constructs a client wrapper for the KeywordViewService service, with the specified gRPC client and settings.
    /// </summary>
    /// <param name="grpcClient">The underlying gRPC client.</param>
    /// <param name="settings">The base <see cref="KeywordViewServiceSettings"/> used within this client </param>
    public KeywordViewServiceClientImpl(KeywordViewService.KeywordViewServiceClient grpcClient, KeywordViewServiceSettings settings) {
      GrpcClient = grpcClient;
      KeywordViewServiceSettings effectiveSettings = settings ?? KeywordViewServiceSettings.GetDefault();
      ClientHelper clientHelper = new ClientHelper(effectiveSettings);
      _callGetKeywordView = clientHelper.BuildApiCall<GetKeywordViewRequest, KeywordView>(
          GrpcClient.GetKeywordViewAsync, GrpcClient.GetKeywordView, effectiveSettings.GetKeywordViewSettings);
      Modify_ApiCall(ref _callGetKeywordView);
      Modify_GetKeywordViewApiCall(ref _callGetKeywordView);
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
    partial void Modify_GetKeywordViewApiCall(ref ApiCall<GetKeywordViewRequest, KeywordView> call);

    partial void OnConstruction(KeywordViewService.KeywordViewServiceClient grpcClient, KeywordViewServiceSettings effectiveSettings, ClientHelper clientHelper);

    /// <summary>
    /// The underlying gRPC KeywordViewService client.
    /// </summary>
    public override KeywordViewService.KeywordViewServiceClient GrpcClient {
      get;
    }

    // Partial methods called on each request.
    // Allows per-RPC-call modification to the request and CallSettings objects,
    // before the underlying RPC is performed.
    partial void Modify_GetKeywordViewRequest(ref GetKeywordViewRequest request, ref CallSettings settings);

    /// <summary>
    /// Returns the requested keyword view in full detail.
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
    public override Task<KeywordView> GetKeywordViewAsync(
        GetKeywordViewRequest request,
        CallSettings callSettings = null) {
      Modify_GetKeywordViewRequest(ref request, ref callSettings);
      return _callGetKeywordView.Async(request, callSettings);
    }

    /// <summary>
    /// Returns the requested keyword view in full detail.
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
    public override KeywordView GetKeywordView(
        GetKeywordViewRequest request,
        CallSettings callSettings = null) {
      Modify_GetKeywordViewRequest(ref request, ref callSettings);
      return _callGetKeywordView.Sync(request, callSettings);
    }
  }

  // Partial classes to enable page-streaming
}
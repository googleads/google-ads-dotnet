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
  /// Settings for a <see cref="BiddingStrategyServiceClient"/>.
  /// </summary>
  public sealed partial class BiddingStrategyServiceSettings : ServiceSettingsBase {

    /// <summary>
    /// Get a new instance of the default <see cref="BiddingStrategyServiceSettings"/>.
    /// </summary>
    /// <returns>
    /// A new instance of the default <see cref="BiddingStrategyServiceSettings"/>.
    /// </returns>
    public static BiddingStrategyServiceSettings GetDefault() => new BiddingStrategyServiceSettings();

    /// <summary>
    /// Constructs a new <see cref="BiddingStrategyServiceSettings"/> object with default settings.
    /// </summary>
    public BiddingStrategyServiceSettings() {
    }

    private BiddingStrategyServiceSettings(BiddingStrategyServiceSettings existing) : base(existing) {
      GaxPreconditions.CheckNotNull(existing, nameof(existing));
      GetBiddingStrategySettings = existing.GetBiddingStrategySettings;
      MutateBiddingStrategiesSettings = existing.MutateBiddingStrategiesSettings;
      OnCopy(existing);
    }

    partial void OnCopy(BiddingStrategyServiceSettings existing);

    /// <summary>
    /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
    /// for "Idempotent" <see cref="BiddingStrategyServiceClient"/> RPC methods.
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
    /// for "NonIdempotent" <see cref="BiddingStrategyServiceClient"/> RPC methods.
    /// </summary>
    /// <remarks>
    /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
    /// </remarks>
    public static Predicate<RpcException> NonIdempotentRetryFilter {
      get;
    } =
        RetrySettings.FilterForStatusCodes();

    /// <summary>
    /// "Default" retry backoff for <see cref="BiddingStrategyServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" retry backoff for <see cref="BiddingStrategyServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" retry backoff for <see cref="BiddingStrategyServiceClient"/> RPC methods is defined as:
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
    /// "Default" timeout backoff for <see cref="BiddingStrategyServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" timeout backoff for <see cref="BiddingStrategyServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" timeout backoff for <see cref="BiddingStrategyServiceClient"/> RPC methods is defined as:
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
    /// <c>BiddingStrategyServiceClient.GetBiddingStrategy</c> and <c>BiddingStrategyServiceClient.GetBiddingStrategyAsync</c>.
    /// </summary>
    /// <remarks>
    /// The default <c>BiddingStrategyServiceClient.GetBiddingStrategy</c> and
    /// <c>BiddingStrategyServiceClient.GetBiddingStrategyAsync</c> <see cref="RetrySettings"/> are:
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
    public CallSettings GetBiddingStrategySettings {
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
    /// <c>BiddingStrategyServiceClient.MutateBiddingStrategies</c> and <c>BiddingStrategyServiceClient.MutateBiddingStrategiesAsync</c>.
    /// </summary>
    /// <remarks>
    /// The default <c>BiddingStrategyServiceClient.MutateBiddingStrategies</c> and
    /// <c>BiddingStrategyServiceClient.MutateBiddingStrategiesAsync</c> <see cref="RetrySettings"/> are:
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
    public CallSettings MutateBiddingStrategiesSettings {
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
    /// <returns>A deep clone of this <see cref="BiddingStrategyServiceSettings"/> object.</returns>
    public BiddingStrategyServiceSettings Clone() => new BiddingStrategyServiceSettings(this);
  }

  /// <summary>
  /// BiddingStrategyService client wrapper, for convenient use.
  /// </summary>
  public abstract partial class BiddingStrategyServiceClient {

    /// <summary>
    /// The default endpoint for the BiddingStrategyService service, which is a host of "googleads.googleapis.com" and a port of 443.
    /// </summary>
    public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("googleads.googleapis.com", 443);

    /// <summary>
    /// The default BiddingStrategyService scopes.
    /// </summary>
    /// <remarks>
    /// The default BiddingStrategyService scopes are:
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
    /// Asynchronously creates a <see cref="BiddingStrategyServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary.
    /// </summary>
    /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="BiddingStrategyServiceSettings"/>.</param>
    /// <returns>The task representing the created <see cref="BiddingStrategyServiceClient"/>.</returns>
    public static async Task<BiddingStrategyServiceClient> CreateAsync(ServiceEndpoint endpoint = null, BiddingStrategyServiceSettings settings = null) {
      Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
      return Create(channel, settings);
    }

    /// <summary>
    /// Synchronously creates a <see cref="BiddingStrategyServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary.
    /// </summary>
    /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="BiddingStrategyServiceSettings"/>.</param>
    /// <returns>The created <see cref="BiddingStrategyServiceClient"/>.</returns>
    public static BiddingStrategyServiceClient Create(ServiceEndpoint endpoint = null, BiddingStrategyServiceSettings settings = null) {
      Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
      return Create(channel, settings);
    }

    /// <summary>
    /// Creates a <see cref="BiddingStrategyServiceClient"/> which uses the specified channel for remote operations.
    /// </summary>
    /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
    /// <param name="settings">Optional <see cref="BiddingStrategyServiceSettings"/>.</param>
    /// <returns>The created <see cref="BiddingStrategyServiceClient"/>.</returns>
    public static BiddingStrategyServiceClient Create(Channel channel, BiddingStrategyServiceSettings settings = null) {
      GaxPreconditions.CheckNotNull(channel, nameof(channel));
      BiddingStrategyService.BiddingStrategyServiceClient grpcClient = new BiddingStrategyService.BiddingStrategyServiceClient(channel);
      return new BiddingStrategyServiceClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, BiddingStrategyServiceSettings)"/>
    /// and <see cref="CreateAsync(ServiceEndpoint, BiddingStrategyServiceSettings)"/>. Channels which weren't automatically
    /// created are not affected.
    /// </summary>
    /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, BiddingStrategyServiceSettings)"/>
    /// and <see cref="CreateAsync(ServiceEndpoint, BiddingStrategyServiceSettings)"/> will create new channels, which could
    /// in turn be shut down by another call to this method.</remarks>
    /// <returns>A task representing the asynchronous shutdown operation.</returns>
    public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

    /// <summary>
    /// The underlying gRPC BiddingStrategyService client.
    /// </summary>
    public virtual BiddingStrategyService.BiddingStrategyServiceClient GrpcClient {
      get {
        throw new NotImplementedException();
      }
    }

    /// <summary>
    /// Returns the requested bidding strategy in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the bidding strategy to fetch.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<BiddingStrategy> GetBiddingStrategyAsync(
        string resourceName,
        CallSettings callSettings = null) => GetBiddingStrategyAsync(
            new GetBiddingStrategyRequest {
              ResourceName = GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            },
            callSettings);

    /// <summary>
    /// Returns the requested bidding strategy in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the bidding strategy to fetch.
    /// </param>
    /// <param name="cancellationToken">
    /// A <see cref="CancellationToken"/> to use for this RPC.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<BiddingStrategy> GetBiddingStrategyAsync(
        string resourceName,
        CancellationToken cancellationToken) => GetBiddingStrategyAsync(
            resourceName,
            CallSettings.FromCancellationToken(cancellationToken));

    /// <summary>
    /// Returns the requested bidding strategy in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the bidding strategy to fetch.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public virtual BiddingStrategy GetBiddingStrategy(
        string resourceName,
        CallSettings callSettings = null) => GetBiddingStrategy(
            new GetBiddingStrategyRequest {
              ResourceName = GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            },
            callSettings);

    /// <summary>
    /// Returns the requested bidding strategy in full detail.
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
    public virtual Task<BiddingStrategy> GetBiddingStrategyAsync(
        GetBiddingStrategyRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the requested bidding strategy in full detail.
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
    public virtual BiddingStrategy GetBiddingStrategy(
        GetBiddingStrategyRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Creates, updates, or removes bidding strategies. Operation statuses are
    /// returned.
    /// </summary>
    /// <param name="customerId">
    /// The ID of the customer whose bidding strategies are being modified.
    /// </param>
    /// <param name="operations">
    /// The list of operations to perform on individual bidding strategies.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(
        string customerId,
        IEnumerable<BiddingStrategyOperation> operations,
        CallSettings callSettings = null) => MutateBiddingStrategiesAsync(
            new MutateBiddingStrategiesRequest {
              CustomerId = GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
              Operations = { GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
            },
            callSettings);

    /// <summary>
    /// Creates, updates, or removes bidding strategies. Operation statuses are
    /// returned.
    /// </summary>
    /// <param name="customerId">
    /// The ID of the customer whose bidding strategies are being modified.
    /// </param>
    /// <param name="operations">
    /// The list of operations to perform on individual bidding strategies.
    /// </param>
    /// <param name="cancellationToken">
    /// A <see cref="CancellationToken"/> to use for this RPC.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(
        string customerId,
        IEnumerable<BiddingStrategyOperation> operations,
        CancellationToken cancellationToken) => MutateBiddingStrategiesAsync(
            customerId,
            operations,
            CallSettings.FromCancellationToken(cancellationToken));

    /// <summary>
    /// Creates, updates, or removes bidding strategies. Operation statuses are
    /// returned.
    /// </summary>
    /// <param name="customerId">
    /// The ID of the customer whose bidding strategies are being modified.
    /// </param>
    /// <param name="operations">
    /// The list of operations to perform on individual bidding strategies.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public virtual MutateBiddingStrategiesResponse MutateBiddingStrategies(
        string customerId,
        IEnumerable<BiddingStrategyOperation> operations,
        CallSettings callSettings = null) => MutateBiddingStrategies(
            new MutateBiddingStrategiesRequest {
              CustomerId = GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
              Operations = { GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
            },
            callSettings);

    /// <summary>
    /// Creates, updates, or removes bidding strategies. Operation statuses are
    /// returned.
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
    public virtual Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(
        MutateBiddingStrategiesRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Creates, updates, or removes bidding strategies. Operation statuses are
    /// returned.
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
    public virtual MutateBiddingStrategiesResponse MutateBiddingStrategies(
        MutateBiddingStrategiesRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }
  }

  /// <summary>
  /// BiddingStrategyService client wrapper implementation, for convenient use.
  /// </summary>
  public sealed partial class BiddingStrategyServiceClientImpl : BiddingStrategyServiceClient {
    private readonly ApiCall<GetBiddingStrategyRequest, BiddingStrategy> _callGetBiddingStrategy;
    private readonly ApiCall<MutateBiddingStrategiesRequest, MutateBiddingStrategiesResponse> _callMutateBiddingStrategies;

    /// <summary>
    /// Constructs a client wrapper for the BiddingStrategyService service, with the specified gRPC client and settings.
    /// </summary>
    /// <param name="grpcClient">The underlying gRPC client.</param>
    /// <param name="settings">The base <see cref="BiddingStrategyServiceSettings"/> used within this client </param>
    public BiddingStrategyServiceClientImpl(BiddingStrategyService.BiddingStrategyServiceClient grpcClient, BiddingStrategyServiceSettings settings) {
      GrpcClient = grpcClient;
      BiddingStrategyServiceSettings effectiveSettings = settings ?? BiddingStrategyServiceSettings.GetDefault();
      ClientHelper clientHelper = new ClientHelper(effectiveSettings);
      _callGetBiddingStrategy = clientHelper.BuildApiCall<GetBiddingStrategyRequest, BiddingStrategy>(
          GrpcClient.GetBiddingStrategyAsync, GrpcClient.GetBiddingStrategy, effectiveSettings.GetBiddingStrategySettings);
      _callMutateBiddingStrategies = clientHelper.BuildApiCall<MutateBiddingStrategiesRequest, MutateBiddingStrategiesResponse>(
          GrpcClient.MutateBiddingStrategiesAsync, GrpcClient.MutateBiddingStrategies, effectiveSettings.MutateBiddingStrategiesSettings);
      Modify_ApiCall(ref _callGetBiddingStrategy);
      Modify_GetBiddingStrategyApiCall(ref _callGetBiddingStrategy);
      Modify_ApiCall(ref _callMutateBiddingStrategies);
      Modify_MutateBiddingStrategiesApiCall(ref _callMutateBiddingStrategies);
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
    partial void Modify_GetBiddingStrategyApiCall(ref ApiCall<GetBiddingStrategyRequest, BiddingStrategy> call);

    partial void Modify_MutateBiddingStrategiesApiCall(ref ApiCall<MutateBiddingStrategiesRequest, MutateBiddingStrategiesResponse> call);

    partial void OnConstruction(BiddingStrategyService.BiddingStrategyServiceClient grpcClient, BiddingStrategyServiceSettings effectiveSettings, ClientHelper clientHelper);

    /// <summary>
    /// The underlying gRPC BiddingStrategyService client.
    /// </summary>
    public override BiddingStrategyService.BiddingStrategyServiceClient GrpcClient {
      get;
    }

    // Partial methods called on each request.
    // Allows per-RPC-call modification to the request and CallSettings objects,
    // before the underlying RPC is performed.
    partial void Modify_GetBiddingStrategyRequest(ref GetBiddingStrategyRequest request, ref CallSettings settings);

    partial void Modify_MutateBiddingStrategiesRequest(ref MutateBiddingStrategiesRequest request, ref CallSettings settings);

    /// <summary>
    /// Returns the requested bidding strategy in full detail.
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
    public override Task<BiddingStrategy> GetBiddingStrategyAsync(
        GetBiddingStrategyRequest request,
        CallSettings callSettings = null) {
      Modify_GetBiddingStrategyRequest(ref request, ref callSettings);
      return _callGetBiddingStrategy.Async(request, callSettings);
    }

    /// <summary>
    /// Returns the requested bidding strategy in full detail.
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
    public override BiddingStrategy GetBiddingStrategy(
        GetBiddingStrategyRequest request,
        CallSettings callSettings = null) {
      Modify_GetBiddingStrategyRequest(ref request, ref callSettings);
      return _callGetBiddingStrategy.Sync(request, callSettings);
    }

    /// <summary>
    /// Creates, updates, or removes bidding strategies. Operation statuses are
    /// returned.
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
    public override Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(
        MutateBiddingStrategiesRequest request,
        CallSettings callSettings = null) {
      Modify_MutateBiddingStrategiesRequest(ref request, ref callSettings);
      return _callMutateBiddingStrategies.Async(request, callSettings);
    }

    /// <summary>
    /// Creates, updates, or removes bidding strategies. Operation statuses are
    /// returned.
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
    public override MutateBiddingStrategiesResponse MutateBiddingStrategies(
        MutateBiddingStrategiesRequest request,
        CallSettings callSettings = null) {
      Modify_MutateBiddingStrategiesRequest(ref request, ref callSettings);
      return _callMutateBiddingStrategies.Sync(request, callSettings);
    }
  }

  // Partial classes to enable page-streaming
}
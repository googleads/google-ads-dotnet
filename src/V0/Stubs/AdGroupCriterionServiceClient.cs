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
  /// Settings for a <see cref="AdGroupCriterionServiceClient"/>.
  /// </summary>
  public sealed partial class AdGroupCriterionServiceSettings : ServiceSettingsBase {

    /// <summary>
    /// Get a new instance of the default <see cref="AdGroupCriterionServiceSettings"/>.
    /// </summary>
    /// <returns>
    /// A new instance of the default <see cref="AdGroupCriterionServiceSettings"/>.
    /// </returns>
    public static AdGroupCriterionServiceSettings GetDefault() => new AdGroupCriterionServiceSettings();

    /// <summary>
    /// Constructs a new <see cref="AdGroupCriterionServiceSettings"/> object with default settings.
    /// </summary>
    public AdGroupCriterionServiceSettings() {
    }

    private AdGroupCriterionServiceSettings(AdGroupCriterionServiceSettings existing) : base(existing) {
      GaxPreconditions.CheckNotNull(existing, nameof(existing));
      GetAdGroupCriterionSettings = existing.GetAdGroupCriterionSettings;
      MutateAdGroupCriteriaSettings = existing.MutateAdGroupCriteriaSettings;
      OnCopy(existing);
    }

    partial void OnCopy(AdGroupCriterionServiceSettings existing);

    /// <summary>
    /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
    /// for "Idempotent" <see cref="AdGroupCriterionServiceClient"/> RPC methods.
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
    /// for "NonIdempotent" <see cref="AdGroupCriterionServiceClient"/> RPC methods.
    /// </summary>
    /// <remarks>
    /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
    /// </remarks>
    public static Predicate<RpcException> NonIdempotentRetryFilter {
      get;
    } =
        RetrySettings.FilterForStatusCodes();

    /// <summary>
    /// "Default" retry backoff for <see cref="AdGroupCriterionServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" retry backoff for <see cref="AdGroupCriterionServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" retry backoff for <see cref="AdGroupCriterionServiceClient"/> RPC methods is defined as:
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
    /// "Default" timeout backoff for <see cref="AdGroupCriterionServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" timeout backoff for <see cref="AdGroupCriterionServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" timeout backoff for <see cref="AdGroupCriterionServiceClient"/> RPC methods is defined as:
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
    /// <c>AdGroupCriterionServiceClient.GetAdGroupCriterion</c> and <c>AdGroupCriterionServiceClient.GetAdGroupCriterionAsync</c>.
    /// </summary>
    /// <remarks>
    /// The default <c>AdGroupCriterionServiceClient.GetAdGroupCriterion</c> and
    /// <c>AdGroupCriterionServiceClient.GetAdGroupCriterionAsync</c> <see cref="RetrySettings"/> are:
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
    public CallSettings GetAdGroupCriterionSettings {
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
    /// <c>AdGroupCriterionServiceClient.MutateAdGroupCriteria</c> and <c>AdGroupCriterionServiceClient.MutateAdGroupCriteriaAsync</c>.
    /// </summary>
    /// <remarks>
    /// The default <c>AdGroupCriterionServiceClient.MutateAdGroupCriteria</c> and
    /// <c>AdGroupCriterionServiceClient.MutateAdGroupCriteriaAsync</c> <see cref="RetrySettings"/> are:
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
    public CallSettings MutateAdGroupCriteriaSettings {
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
    /// <returns>A deep clone of this <see cref="AdGroupCriterionServiceSettings"/> object.</returns>
    public AdGroupCriterionServiceSettings Clone() => new AdGroupCriterionServiceSettings(this);
  }

  /// <summary>
  /// AdGroupCriterionService client wrapper, for convenient use.
  /// </summary>
  public abstract partial class AdGroupCriterionServiceClient {

    /// <summary>
    /// The default endpoint for the AdGroupCriterionService service, which is a host of "googleads.googleapis.com" and a port of 443.
    /// </summary>
    public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("googleads.googleapis.com", 443);

    /// <summary>
    /// The default AdGroupCriterionService scopes.
    /// </summary>
    /// <remarks>
    /// The default AdGroupCriterionService scopes are:
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
    /// Asynchronously creates a <see cref="AdGroupCriterionServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary.
    /// </summary>
    /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="AdGroupCriterionServiceSettings"/>.</param>
    /// <returns>The task representing the created <see cref="AdGroupCriterionServiceClient"/>.</returns>
    public static async Task<AdGroupCriterionServiceClient> CreateAsync(ServiceEndpoint endpoint = null, AdGroupCriterionServiceSettings settings = null) {
      Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
      return Create(channel, settings);
    }

    /// <summary>
    /// Synchronously creates a <see cref="AdGroupCriterionServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary.
    /// </summary>
    /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="AdGroupCriterionServiceSettings"/>.</param>
    /// <returns>The created <see cref="AdGroupCriterionServiceClient"/>.</returns>
    public static AdGroupCriterionServiceClient Create(ServiceEndpoint endpoint = null, AdGroupCriterionServiceSettings settings = null) {
      Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
      return Create(channel, settings);
    }

    /// <summary>
    /// Creates a <see cref="AdGroupCriterionServiceClient"/> which uses the specified channel for remote operations.
    /// </summary>
    /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
    /// <param name="settings">Optional <see cref="AdGroupCriterionServiceSettings"/>.</param>
    /// <returns>The created <see cref="AdGroupCriterionServiceClient"/>.</returns>
    public static AdGroupCriterionServiceClient Create(Channel channel, AdGroupCriterionServiceSettings settings = null) {
      GaxPreconditions.CheckNotNull(channel, nameof(channel));
      AdGroupCriterionService.AdGroupCriterionServiceClient grpcClient = new AdGroupCriterionService.AdGroupCriterionServiceClient(channel);
      return new AdGroupCriterionServiceClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, AdGroupCriterionServiceSettings)"/>
    /// and <see cref="CreateAsync(ServiceEndpoint, AdGroupCriterionServiceSettings)"/>. Channels which weren't automatically
    /// created are not affected.
    /// </summary>
    /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, AdGroupCriterionServiceSettings)"/>
    /// and <see cref="CreateAsync(ServiceEndpoint, AdGroupCriterionServiceSettings)"/> will create new channels, which could
    /// in turn be shut down by another call to this method.</remarks>
    /// <returns>A task representing the asynchronous shutdown operation.</returns>
    public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

    /// <summary>
    /// The underlying gRPC AdGroupCriterionService client.
    /// </summary>
    public virtual AdGroupCriterionService.AdGroupCriterionServiceClient GrpcClient {
      get {
        throw new NotImplementedException();
      }
    }

    /// <summary>
    /// Returns the requested criterion in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the criterion to fetch.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<AdGroupCriterion> GetAdGroupCriterionAsync(
        string resourceName,
        CallSettings callSettings = null) => GetAdGroupCriterionAsync(
            new GetAdGroupCriterionRequest {
              ResourceName = GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            },
            callSettings);

    /// <summary>
    /// Returns the requested criterion in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the criterion to fetch.
    /// </param>
    /// <param name="cancellationToken">
    /// A <see cref="CancellationToken"/> to use for this RPC.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<AdGroupCriterion> GetAdGroupCriterionAsync(
        string resourceName,
        CancellationToken cancellationToken) => GetAdGroupCriterionAsync(
            resourceName,
            CallSettings.FromCancellationToken(cancellationToken));

    /// <summary>
    /// Returns the requested criterion in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the criterion to fetch.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public virtual AdGroupCriterion GetAdGroupCriterion(
        string resourceName,
        CallSettings callSettings = null) => GetAdGroupCriterion(
            new GetAdGroupCriterionRequest {
              ResourceName = GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            },
            callSettings);

    /// <summary>
    /// Returns the requested criterion in full detail.
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
    public virtual Task<AdGroupCriterion> GetAdGroupCriterionAsync(
        GetAdGroupCriterionRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the requested criterion in full detail.
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
    public virtual AdGroupCriterion GetAdGroupCriterion(
        GetAdGroupCriterionRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Creates, updates, or removes criteria. Operation statuses are returned.
    /// </summary>
    /// <param name="customerId">
    /// ID of the customer whose criteria are being modified.
    /// </param>
    /// <param name="operations">
    /// The list of operations to perform on individual criteria.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(
        string customerId,
        IEnumerable<AdGroupCriterionOperation> operations,
        CallSettings callSettings = null) => MutateAdGroupCriteriaAsync(
            new MutateAdGroupCriteriaRequest {
              CustomerId = GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
              Operations = { GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
            },
            callSettings);

    /// <summary>
    /// Creates, updates, or removes criteria. Operation statuses are returned.
    /// </summary>
    /// <param name="customerId">
    /// ID of the customer whose criteria are being modified.
    /// </param>
    /// <param name="operations">
    /// The list of operations to perform on individual criteria.
    /// </param>
    /// <param name="cancellationToken">
    /// A <see cref="CancellationToken"/> to use for this RPC.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(
        string customerId,
        IEnumerable<AdGroupCriterionOperation> operations,
        CancellationToken cancellationToken) => MutateAdGroupCriteriaAsync(
            customerId,
            operations,
            CallSettings.FromCancellationToken(cancellationToken));

    /// <summary>
    /// Creates, updates, or removes criteria. Operation statuses are returned.
    /// </summary>
    /// <param name="customerId">
    /// ID of the customer whose criteria are being modified.
    /// </param>
    /// <param name="operations">
    /// The list of operations to perform on individual criteria.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public virtual MutateAdGroupCriteriaResponse MutateAdGroupCriteria(
        string customerId,
        IEnumerable<AdGroupCriterionOperation> operations,
        CallSettings callSettings = null) => MutateAdGroupCriteria(
            new MutateAdGroupCriteriaRequest {
              CustomerId = GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
              Operations = { GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
            },
            callSettings);

    /// <summary>
    /// Creates, updates, or removes criteria. Operation statuses are returned.
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
    public virtual Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(
        MutateAdGroupCriteriaRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Creates, updates, or removes criteria. Operation statuses are returned.
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
    public virtual MutateAdGroupCriteriaResponse MutateAdGroupCriteria(
        MutateAdGroupCriteriaRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }
  }

  /// <summary>
  /// AdGroupCriterionService client wrapper implementation, for convenient use.
  /// </summary>
  public sealed partial class AdGroupCriterionServiceClientImpl : AdGroupCriterionServiceClient {
    private readonly ApiCall<GetAdGroupCriterionRequest, AdGroupCriterion> _callGetAdGroupCriterion;
    private readonly ApiCall<MutateAdGroupCriteriaRequest, MutateAdGroupCriteriaResponse> _callMutateAdGroupCriteria;

    /// <summary>
    /// Constructs a client wrapper for the AdGroupCriterionService service, with the specified gRPC client and settings.
    /// </summary>
    /// <param name="grpcClient">The underlying gRPC client.</param>
    /// <param name="settings">The base <see cref="AdGroupCriterionServiceSettings"/> used within this client </param>
    public AdGroupCriterionServiceClientImpl(AdGroupCriterionService.AdGroupCriterionServiceClient grpcClient, AdGroupCriterionServiceSettings settings) {
      GrpcClient = grpcClient;
      AdGroupCriterionServiceSettings effectiveSettings = settings ?? AdGroupCriterionServiceSettings.GetDefault();
      ClientHelper clientHelper = new ClientHelper(effectiveSettings);
      _callGetAdGroupCriterion = clientHelper.BuildApiCall<GetAdGroupCriterionRequest, AdGroupCriterion>(
          GrpcClient.GetAdGroupCriterionAsync, GrpcClient.GetAdGroupCriterion, effectiveSettings.GetAdGroupCriterionSettings);
      _callMutateAdGroupCriteria = clientHelper.BuildApiCall<MutateAdGroupCriteriaRequest, MutateAdGroupCriteriaResponse>(
          GrpcClient.MutateAdGroupCriteriaAsync, GrpcClient.MutateAdGroupCriteria, effectiveSettings.MutateAdGroupCriteriaSettings);
      Modify_ApiCall(ref _callGetAdGroupCriterion);
      Modify_GetAdGroupCriterionApiCall(ref _callGetAdGroupCriterion);
      Modify_ApiCall(ref _callMutateAdGroupCriteria);
      Modify_MutateAdGroupCriteriaApiCall(ref _callMutateAdGroupCriteria);
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
    partial void Modify_GetAdGroupCriterionApiCall(ref ApiCall<GetAdGroupCriterionRequest, AdGroupCriterion> call);

    partial void Modify_MutateAdGroupCriteriaApiCall(ref ApiCall<MutateAdGroupCriteriaRequest, MutateAdGroupCriteriaResponse> call);

    partial void OnConstruction(AdGroupCriterionService.AdGroupCriterionServiceClient grpcClient, AdGroupCriterionServiceSettings effectiveSettings, ClientHelper clientHelper);

    /// <summary>
    /// The underlying gRPC AdGroupCriterionService client.
    /// </summary>
    public override AdGroupCriterionService.AdGroupCriterionServiceClient GrpcClient {
      get;
    }

    // Partial methods called on each request.
    // Allows per-RPC-call modification to the request and CallSettings objects,
    // before the underlying RPC is performed.
    partial void Modify_GetAdGroupCriterionRequest(ref GetAdGroupCriterionRequest request, ref CallSettings settings);

    partial void Modify_MutateAdGroupCriteriaRequest(ref MutateAdGroupCriteriaRequest request, ref CallSettings settings);

    /// <summary>
    /// Returns the requested criterion in full detail.
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
    public override Task<AdGroupCriterion> GetAdGroupCriterionAsync(
        GetAdGroupCriterionRequest request,
        CallSettings callSettings = null) {
      Modify_GetAdGroupCriterionRequest(ref request, ref callSettings);
      return _callGetAdGroupCriterion.Async(request, callSettings);
    }

    /// <summary>
    /// Returns the requested criterion in full detail.
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
    public override AdGroupCriterion GetAdGroupCriterion(
        GetAdGroupCriterionRequest request,
        CallSettings callSettings = null) {
      Modify_GetAdGroupCriterionRequest(ref request, ref callSettings);
      return _callGetAdGroupCriterion.Sync(request, callSettings);
    }

    /// <summary>
    /// Creates, updates, or removes criteria. Operation statuses are returned.
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
    public override Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(
        MutateAdGroupCriteriaRequest request,
        CallSettings callSettings = null) {
      Modify_MutateAdGroupCriteriaRequest(ref request, ref callSettings);
      return _callMutateAdGroupCriteria.Async(request, callSettings);
    }

    /// <summary>
    /// Creates, updates, or removes criteria. Operation statuses are returned.
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
    public override MutateAdGroupCriteriaResponse MutateAdGroupCriteria(
        MutateAdGroupCriteriaRequest request,
        CallSettings callSettings = null) {
      Modify_MutateAdGroupCriteriaRequest(ref request, ref callSettings);
      return _callMutateAdGroupCriteria.Sync(request, callSettings);
    }
  }

  // Partial classes to enable page-streaming
}
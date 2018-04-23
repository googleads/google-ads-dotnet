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
  /// Settings for a <see cref="CampaignCriterionServiceClient"/>.
  /// </summary>
  public sealed partial class CampaignCriterionServiceSettings : ServiceSettingsBase {

    /// <summary>
    /// Get a new instance of the default <see cref="CampaignCriterionServiceSettings"/>.
    /// </summary>
    /// <returns>
    /// A new instance of the default <see cref="CampaignCriterionServiceSettings"/>.
    /// </returns>
    public static CampaignCriterionServiceSettings GetDefault() => new CampaignCriterionServiceSettings();

    /// <summary>
    /// Constructs a new <see cref="CampaignCriterionServiceSettings"/> object with default settings.
    /// </summary>
    public CampaignCriterionServiceSettings() {
    }

    private CampaignCriterionServiceSettings(CampaignCriterionServiceSettings existing) : base(existing) {
      GaxPreconditions.CheckNotNull(existing, nameof(existing));
      GetCampaignCriterionSettings = existing.GetCampaignCriterionSettings;
      MutateCampaignCriteriaSettings = existing.MutateCampaignCriteriaSettings;
      OnCopy(existing);
    }

    partial void OnCopy(CampaignCriterionServiceSettings existing);

    /// <summary>
    /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
    /// for "Idempotent" <see cref="CampaignCriterionServiceClient"/> RPC methods.
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
    /// for "NonIdempotent" <see cref="CampaignCriterionServiceClient"/> RPC methods.
    /// </summary>
    /// <remarks>
    /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
    /// </remarks>
    public static Predicate<RpcException> NonIdempotentRetryFilter {
      get;
    } =
        RetrySettings.FilterForStatusCodes();

    /// <summary>
    /// "Default" retry backoff for <see cref="CampaignCriterionServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" retry backoff for <see cref="CampaignCriterionServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" retry backoff for <see cref="CampaignCriterionServiceClient"/> RPC methods is defined as:
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
    /// "Default" timeout backoff for <see cref="CampaignCriterionServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" timeout backoff for <see cref="CampaignCriterionServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" timeout backoff for <see cref="CampaignCriterionServiceClient"/> RPC methods is defined as:
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
    /// <c>CampaignCriterionServiceClient.GetCampaignCriterion</c> and <c>CampaignCriterionServiceClient.GetCampaignCriterionAsync</c>.
    /// </summary>
    /// <remarks>
    /// The default <c>CampaignCriterionServiceClient.GetCampaignCriterion</c> and
    /// <c>CampaignCriterionServiceClient.GetCampaignCriterionAsync</c> <see cref="RetrySettings"/> are:
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
    public CallSettings GetCampaignCriterionSettings {
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
    /// <c>CampaignCriterionServiceClient.MutateCampaignCriteria</c> and <c>CampaignCriterionServiceClient.MutateCampaignCriteriaAsync</c>.
    /// </summary>
    /// <remarks>
    /// The default <c>CampaignCriterionServiceClient.MutateCampaignCriteria</c> and
    /// <c>CampaignCriterionServiceClient.MutateCampaignCriteriaAsync</c> <see cref="RetrySettings"/> are:
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
    public CallSettings MutateCampaignCriteriaSettings {
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
    /// <returns>A deep clone of this <see cref="CampaignCriterionServiceSettings"/> object.</returns>
    public CampaignCriterionServiceSettings Clone() => new CampaignCriterionServiceSettings(this);
  }

  /// <summary>
  /// CampaignCriterionService client wrapper, for convenient use.
  /// </summary>
  public abstract partial class CampaignCriterionServiceClient {

    /// <summary>
    /// The default endpoint for the CampaignCriterionService service, which is a host of "googleads.googleapis.com" and a port of 443.
    /// </summary>
    public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("googleads.googleapis.com", 443);

    /// <summary>
    /// The default CampaignCriterionService scopes.
    /// </summary>
    /// <remarks>
    /// The default CampaignCriterionService scopes are:
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
    /// Asynchronously creates a <see cref="CampaignCriterionServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary.
    /// </summary>
    /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="CampaignCriterionServiceSettings"/>.</param>
    /// <returns>The task representing the created <see cref="CampaignCriterionServiceClient"/>.</returns>
    public static async Task<CampaignCriterionServiceClient> CreateAsync(ServiceEndpoint endpoint = null, CampaignCriterionServiceSettings settings = null) {
      Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
      return Create(channel, settings);
    }

    /// <summary>
    /// Synchronously creates a <see cref="CampaignCriterionServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary.
    /// </summary>
    /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="CampaignCriterionServiceSettings"/>.</param>
    /// <returns>The created <see cref="CampaignCriterionServiceClient"/>.</returns>
    public static CampaignCriterionServiceClient Create(ServiceEndpoint endpoint = null, CampaignCriterionServiceSettings settings = null) {
      Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
      return Create(channel, settings);
    }

    /// <summary>
    /// Creates a <see cref="CampaignCriterionServiceClient"/> which uses the specified channel for remote operations.
    /// </summary>
    /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
    /// <param name="settings">Optional <see cref="CampaignCriterionServiceSettings"/>.</param>
    /// <returns>The created <see cref="CampaignCriterionServiceClient"/>.</returns>
    public static CampaignCriterionServiceClient Create(Channel channel, CampaignCriterionServiceSettings settings = null) {
      GaxPreconditions.CheckNotNull(channel, nameof(channel));
      CampaignCriterionService.CampaignCriterionServiceClient grpcClient = new CampaignCriterionService.CampaignCriterionServiceClient(channel);
      return new CampaignCriterionServiceClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, CampaignCriterionServiceSettings)"/>
    /// and <see cref="CreateAsync(ServiceEndpoint, CampaignCriterionServiceSettings)"/>. Channels which weren't automatically
    /// created are not affected.
    /// </summary>
    /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, CampaignCriterionServiceSettings)"/>
    /// and <see cref="CreateAsync(ServiceEndpoint, CampaignCriterionServiceSettings)"/> will create new channels, which could
    /// in turn be shut down by another call to this method.</remarks>
    /// <returns>A task representing the asynchronous shutdown operation.</returns>
    public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

    /// <summary>
    /// The underlying gRPC CampaignCriterionService client.
    /// </summary>
    public virtual CampaignCriterionService.CampaignCriterionServiceClient GrpcClient {
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
    public virtual Task<CampaignCriterion> GetCampaignCriterionAsync(
        string resourceName,
        CallSettings callSettings = null) => GetCampaignCriterionAsync(
            new GetCampaignCriterionRequest {
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
    public virtual Task<CampaignCriterion> GetCampaignCriterionAsync(
        string resourceName,
        CancellationToken cancellationToken) => GetCampaignCriterionAsync(
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
    public virtual CampaignCriterion GetCampaignCriterion(
        string resourceName,
        CallSettings callSettings = null) => GetCampaignCriterion(
            new GetCampaignCriterionRequest {
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
    public virtual Task<CampaignCriterion> GetCampaignCriterionAsync(
        GetCampaignCriterionRequest request,
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
    public virtual CampaignCriterion GetCampaignCriterion(
        GetCampaignCriterionRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Creates, updates, or removes criteria. Operation statuses are returned.
    /// </summary>
    /// <param name="customerId">
    /// The ID of the customer whose criteria are being modified.
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
    public virtual Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(
        string customerId,
        IEnumerable<CampaignCriterionOperation> operations,
        CallSettings callSettings = null) => MutateCampaignCriteriaAsync(
            new MutateCampaignCriteriaRequest {
              CustomerId = GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
              Operations = { GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
            },
            callSettings);

    /// <summary>
    /// Creates, updates, or removes criteria. Operation statuses are returned.
    /// </summary>
    /// <param name="customerId">
    /// The ID of the customer whose criteria are being modified.
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
    public virtual Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(
        string customerId,
        IEnumerable<CampaignCriterionOperation> operations,
        CancellationToken cancellationToken) => MutateCampaignCriteriaAsync(
            customerId,
            operations,
            CallSettings.FromCancellationToken(cancellationToken));

    /// <summary>
    /// Creates, updates, or removes criteria. Operation statuses are returned.
    /// </summary>
    /// <param name="customerId">
    /// The ID of the customer whose criteria are being modified.
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
    public virtual MutateCampaignCriteriaResponse MutateCampaignCriteria(
        string customerId,
        IEnumerable<CampaignCriterionOperation> operations,
        CallSettings callSettings = null) => MutateCampaignCriteria(
            new MutateCampaignCriteriaRequest {
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
    public virtual Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(
        MutateCampaignCriteriaRequest request,
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
    public virtual MutateCampaignCriteriaResponse MutateCampaignCriteria(
        MutateCampaignCriteriaRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }
  }

  /// <summary>
  /// CampaignCriterionService client wrapper implementation, for convenient use.
  /// </summary>
  public sealed partial class CampaignCriterionServiceClientImpl : CampaignCriterionServiceClient {
    private readonly ApiCall<GetCampaignCriterionRequest, CampaignCriterion> _callGetCampaignCriterion;
    private readonly ApiCall<MutateCampaignCriteriaRequest, MutateCampaignCriteriaResponse> _callMutateCampaignCriteria;

    /// <summary>
    /// Constructs a client wrapper for the CampaignCriterionService service, with the specified gRPC client and settings.
    /// </summary>
    /// <param name="grpcClient">The underlying gRPC client.</param>
    /// <param name="settings">The base <see cref="CampaignCriterionServiceSettings"/> used within this client </param>
    public CampaignCriterionServiceClientImpl(CampaignCriterionService.CampaignCriterionServiceClient grpcClient, CampaignCriterionServiceSettings settings) {
      GrpcClient = grpcClient;
      CampaignCriterionServiceSettings effectiveSettings = settings ?? CampaignCriterionServiceSettings.GetDefault();
      ClientHelper clientHelper = new ClientHelper(effectiveSettings);
      _callGetCampaignCriterion = clientHelper.BuildApiCall<GetCampaignCriterionRequest, CampaignCriterion>(
          GrpcClient.GetCampaignCriterionAsync, GrpcClient.GetCampaignCriterion, effectiveSettings.GetCampaignCriterionSettings);
      _callMutateCampaignCriteria = clientHelper.BuildApiCall<MutateCampaignCriteriaRequest, MutateCampaignCriteriaResponse>(
          GrpcClient.MutateCampaignCriteriaAsync, GrpcClient.MutateCampaignCriteria, effectiveSettings.MutateCampaignCriteriaSettings);
      Modify_ApiCall(ref _callGetCampaignCriterion);
      Modify_GetCampaignCriterionApiCall(ref _callGetCampaignCriterion);
      Modify_ApiCall(ref _callMutateCampaignCriteria);
      Modify_MutateCampaignCriteriaApiCall(ref _callMutateCampaignCriteria);
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
    partial void Modify_GetCampaignCriterionApiCall(ref ApiCall<GetCampaignCriterionRequest, CampaignCriterion> call);

    partial void Modify_MutateCampaignCriteriaApiCall(ref ApiCall<MutateCampaignCriteriaRequest, MutateCampaignCriteriaResponse> call);

    partial void OnConstruction(CampaignCriterionService.CampaignCriterionServiceClient grpcClient, CampaignCriterionServiceSettings effectiveSettings, ClientHelper clientHelper);

    /// <summary>
    /// The underlying gRPC CampaignCriterionService client.
    /// </summary>
    public override CampaignCriterionService.CampaignCriterionServiceClient GrpcClient {
      get;
    }

    // Partial methods called on each request.
    // Allows per-RPC-call modification to the request and CallSettings objects,
    // before the underlying RPC is performed.
    partial void Modify_GetCampaignCriterionRequest(ref GetCampaignCriterionRequest request, ref CallSettings settings);

    partial void Modify_MutateCampaignCriteriaRequest(ref MutateCampaignCriteriaRequest request, ref CallSettings settings);

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
    public override Task<CampaignCriterion> GetCampaignCriterionAsync(
        GetCampaignCriterionRequest request,
        CallSettings callSettings = null) {
      Modify_GetCampaignCriterionRequest(ref request, ref callSettings);
      return _callGetCampaignCriterion.Async(request, callSettings);
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
    public override CampaignCriterion GetCampaignCriterion(
        GetCampaignCriterionRequest request,
        CallSettings callSettings = null) {
      Modify_GetCampaignCriterionRequest(ref request, ref callSettings);
      return _callGetCampaignCriterion.Sync(request, callSettings);
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
    public override Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(
        MutateCampaignCriteriaRequest request,
        CallSettings callSettings = null) {
      Modify_MutateCampaignCriteriaRequest(ref request, ref callSettings);
      return _callMutateCampaignCriteria.Async(request, callSettings);
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
    public override MutateCampaignCriteriaResponse MutateCampaignCriteria(
        MutateCampaignCriteriaRequest request,
        CallSettings callSettings = null) {
      Modify_MutateCampaignCriteriaRequest(ref request, ref callSettings);
      return _callMutateCampaignCriteria.Sync(request, callSettings);
    }
  }

  // Partial classes to enable page-streaming
}
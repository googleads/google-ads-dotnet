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
  /// Settings for a <see cref="CampaignServiceClient"/>.
  /// </summary>
  public sealed partial class CampaignServiceSettings : ServiceSettingsBase {

    /// <summary>
    /// Get a new instance of the default <see cref="CampaignServiceSettings"/>.
    /// </summary>
    /// <returns>
    /// A new instance of the default <see cref="CampaignServiceSettings"/>.
    /// </returns>
    public static CampaignServiceSettings GetDefault() => new CampaignServiceSettings();

    /// <summary>
    /// Constructs a new <see cref="CampaignServiceSettings"/> object with default settings.
    /// </summary>
    public CampaignServiceSettings() {
    }

    private CampaignServiceSettings(CampaignServiceSettings existing) : base(existing) {
      GaxPreconditions.CheckNotNull(existing, nameof(existing));
      GetCampaignSettings = existing.GetCampaignSettings;
      MutateCampaignsSettings = existing.MutateCampaignsSettings;
      OnCopy(existing);
    }

    partial void OnCopy(CampaignServiceSettings existing);

    /// <summary>
    /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
    /// for "Idempotent" <see cref="CampaignServiceClient"/> RPC methods.
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
    /// for "NonIdempotent" <see cref="CampaignServiceClient"/> RPC methods.
    /// </summary>
    /// <remarks>
    /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
    /// </remarks>
    public static Predicate<RpcException> NonIdempotentRetryFilter {
      get;
    } =
        RetrySettings.FilterForStatusCodes();

    /// <summary>
    /// "Default" retry backoff for <see cref="CampaignServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" retry backoff for <see cref="CampaignServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" retry backoff for <see cref="CampaignServiceClient"/> RPC methods is defined as:
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
    /// "Default" timeout backoff for <see cref="CampaignServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" timeout backoff for <see cref="CampaignServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" timeout backoff for <see cref="CampaignServiceClient"/> RPC methods is defined as:
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
    /// <c>CampaignServiceClient.GetCampaign</c> and <c>CampaignServiceClient.GetCampaignAsync</c>.
    /// </summary>
    /// <remarks>
    /// The default <c>CampaignServiceClient.GetCampaign</c> and
    /// <c>CampaignServiceClient.GetCampaignAsync</c> <see cref="RetrySettings"/> are:
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
    public CallSettings GetCampaignSettings {
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
    /// <c>CampaignServiceClient.MutateCampaigns</c> and <c>CampaignServiceClient.MutateCampaignsAsync</c>.
    /// </summary>
    /// <remarks>
    /// The default <c>CampaignServiceClient.MutateCampaigns</c> and
    /// <c>CampaignServiceClient.MutateCampaignsAsync</c> <see cref="RetrySettings"/> are:
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
    public CallSettings MutateCampaignsSettings {
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
    /// <returns>A deep clone of this <see cref="CampaignServiceSettings"/> object.</returns>
    public CampaignServiceSettings Clone() => new CampaignServiceSettings(this);
  }

  /// <summary>
  /// CampaignService client wrapper, for convenient use.
  /// </summary>
  public abstract partial class CampaignServiceClient {

    /// <summary>
    /// The default endpoint for the CampaignService service, which is a host of "googleads.googleapis.com" and a port of 443.
    /// </summary>
    public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("googleads.googleapis.com", 443);

    /// <summary>
    /// The default CampaignService scopes.
    /// </summary>
    /// <remarks>
    /// The default CampaignService scopes are:
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
    /// Asynchronously creates a <see cref="CampaignServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary.
    /// </summary>
    /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="CampaignServiceSettings"/>.</param>
    /// <returns>The task representing the created <see cref="CampaignServiceClient"/>.</returns>
    public static async Task<CampaignServiceClient> CreateAsync(ServiceEndpoint endpoint = null, CampaignServiceSettings settings = null) {
      Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
      return Create(channel, settings);
    }

    /// <summary>
    /// Synchronously creates a <see cref="CampaignServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary.
    /// </summary>
    /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="CampaignServiceSettings"/>.</param>
    /// <returns>The created <see cref="CampaignServiceClient"/>.</returns>
    public static CampaignServiceClient Create(ServiceEndpoint endpoint = null, CampaignServiceSettings settings = null) {
      Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
      return Create(channel, settings);
    }

    /// <summary>
    /// Creates a <see cref="CampaignServiceClient"/> which uses the specified channel for remote operations.
    /// </summary>
    /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
    /// <param name="settings">Optional <see cref="CampaignServiceSettings"/>.</param>
    /// <returns>The created <see cref="CampaignServiceClient"/>.</returns>
    public static CampaignServiceClient Create(Channel channel, CampaignServiceSettings settings = null) {
      GaxPreconditions.CheckNotNull(channel, nameof(channel));
      CampaignService.CampaignServiceClient grpcClient = new CampaignService.CampaignServiceClient(channel);
      return new CampaignServiceClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, CampaignServiceSettings)"/>
    /// and <see cref="CreateAsync(ServiceEndpoint, CampaignServiceSettings)"/>. Channels which weren't automatically
    /// created are not affected.
    /// </summary>
    /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, CampaignServiceSettings)"/>
    /// and <see cref="CreateAsync(ServiceEndpoint, CampaignServiceSettings)"/> will create new channels, which could
    /// in turn be shut down by another call to this method.</remarks>
    /// <returns>A task representing the asynchronous shutdown operation.</returns>
    public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

    /// <summary>
    /// The underlying gRPC CampaignService client.
    /// </summary>
    public virtual CampaignService.CampaignServiceClient GrpcClient {
      get {
        throw new NotImplementedException();
      }
    }

    /// <summary>
    /// Returns the requested campaign in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the campaign to fetch.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<Campaign> GetCampaignAsync(
        string resourceName,
        CallSettings callSettings = null) => GetCampaignAsync(
            new GetCampaignRequest {
              ResourceName = GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            },
            callSettings);

    /// <summary>
    /// Returns the requested campaign in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the campaign to fetch.
    /// </param>
    /// <param name="cancellationToken">
    /// A <see cref="CancellationToken"/> to use for this RPC.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<Campaign> GetCampaignAsync(
        string resourceName,
        CancellationToken cancellationToken) => GetCampaignAsync(
            resourceName,
            CallSettings.FromCancellationToken(cancellationToken));

    /// <summary>
    /// Returns the requested campaign in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the campaign to fetch.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public virtual Campaign GetCampaign(
        string resourceName,
        CallSettings callSettings = null) => GetCampaign(
            new GetCampaignRequest {
              ResourceName = GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            },
            callSettings);

    /// <summary>
    /// Returns the requested campaign in full detail.
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
    public virtual Task<Campaign> GetCampaignAsync(
        GetCampaignRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the requested campaign in full detail.
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
    public virtual Campaign GetCampaign(
        GetCampaignRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Creates, updates, or removes campaigns. Operation statuses are returned.
    /// </summary>
    /// <param name="customerId">
    /// The ID of the customer whose campaigns are being modified.
    /// </param>
    /// <param name="operations">
    /// The list of operations to perform on individual campaigns.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<MutateCampaignsResponse> MutateCampaignsAsync(
        string customerId,
        IEnumerable<CampaignOperation> operations,
        CallSettings callSettings = null) => MutateCampaignsAsync(
            new MutateCampaignsRequest {
              CustomerId = GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
              Operations = { GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
            },
            callSettings);

    /// <summary>
    /// Creates, updates, or removes campaigns. Operation statuses are returned.
    /// </summary>
    /// <param name="customerId">
    /// The ID of the customer whose campaigns are being modified.
    /// </param>
    /// <param name="operations">
    /// The list of operations to perform on individual campaigns.
    /// </param>
    /// <param name="cancellationToken">
    /// A <see cref="CancellationToken"/> to use for this RPC.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<MutateCampaignsResponse> MutateCampaignsAsync(
        string customerId,
        IEnumerable<CampaignOperation> operations,
        CancellationToken cancellationToken) => MutateCampaignsAsync(
            customerId,
            operations,
            CallSettings.FromCancellationToken(cancellationToken));

    /// <summary>
    /// Creates, updates, or removes campaigns. Operation statuses are returned.
    /// </summary>
    /// <param name="customerId">
    /// The ID of the customer whose campaigns are being modified.
    /// </param>
    /// <param name="operations">
    /// The list of operations to perform on individual campaigns.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public virtual MutateCampaignsResponse MutateCampaigns(
        string customerId,
        IEnumerable<CampaignOperation> operations,
        CallSettings callSettings = null) => MutateCampaigns(
            new MutateCampaignsRequest {
              CustomerId = GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
              Operations = { GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
            },
            callSettings);

    /// <summary>
    /// Creates, updates, or removes campaigns. Operation statuses are returned.
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
    public virtual Task<MutateCampaignsResponse> MutateCampaignsAsync(
        MutateCampaignsRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Creates, updates, or removes campaigns. Operation statuses are returned.
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
    public virtual MutateCampaignsResponse MutateCampaigns(
        MutateCampaignsRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }
  }

  /// <summary>
  /// CampaignService client wrapper implementation, for convenient use.
  /// </summary>
  public sealed partial class CampaignServiceClientImpl : CampaignServiceClient {
    private readonly ApiCall<GetCampaignRequest, Campaign> _callGetCampaign;
    private readonly ApiCall<MutateCampaignsRequest, MutateCampaignsResponse> _callMutateCampaigns;

    /// <summary>
    /// Constructs a client wrapper for the CampaignService service, with the specified gRPC client and settings.
    /// </summary>
    /// <param name="grpcClient">The underlying gRPC client.</param>
    /// <param name="settings">The base <see cref="CampaignServiceSettings"/> used within this client </param>
    public CampaignServiceClientImpl(CampaignService.CampaignServiceClient grpcClient, CampaignServiceSettings settings) {
      GrpcClient = grpcClient;
      CampaignServiceSettings effectiveSettings = settings ?? CampaignServiceSettings.GetDefault();
      ClientHelper clientHelper = new ClientHelper(effectiveSettings);
      _callGetCampaign = clientHelper.BuildApiCall<GetCampaignRequest, Campaign>(
          GrpcClient.GetCampaignAsync, GrpcClient.GetCampaign, effectiveSettings.GetCampaignSettings);
      _callMutateCampaigns = clientHelper.BuildApiCall<MutateCampaignsRequest, MutateCampaignsResponse>(
          GrpcClient.MutateCampaignsAsync, GrpcClient.MutateCampaigns, effectiveSettings.MutateCampaignsSettings);
      Modify_ApiCall(ref _callGetCampaign);
      Modify_GetCampaignApiCall(ref _callGetCampaign);
      Modify_ApiCall(ref _callMutateCampaigns);
      Modify_MutateCampaignsApiCall(ref _callMutateCampaigns);
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
    partial void Modify_GetCampaignApiCall(ref ApiCall<GetCampaignRequest, Campaign> call);

    partial void Modify_MutateCampaignsApiCall(ref ApiCall<MutateCampaignsRequest, MutateCampaignsResponse> call);

    partial void OnConstruction(CampaignService.CampaignServiceClient grpcClient, CampaignServiceSettings effectiveSettings, ClientHelper clientHelper);

    /// <summary>
    /// The underlying gRPC CampaignService client.
    /// </summary>
    public override CampaignService.CampaignServiceClient GrpcClient {
      get;
    }

    // Partial methods called on each request.
    // Allows per-RPC-call modification to the request and CallSettings objects,
    // before the underlying RPC is performed.
    partial void Modify_GetCampaignRequest(ref GetCampaignRequest request, ref CallSettings settings);

    partial void Modify_MutateCampaignsRequest(ref MutateCampaignsRequest request, ref CallSettings settings);

    /// <summary>
    /// Returns the requested campaign in full detail.
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
    public override Task<Campaign> GetCampaignAsync(
        GetCampaignRequest request,
        CallSettings callSettings = null) {
      Modify_GetCampaignRequest(ref request, ref callSettings);
      return _callGetCampaign.Async(request, callSettings);
    }

    /// <summary>
    /// Returns the requested campaign in full detail.
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
    public override Campaign GetCampaign(
        GetCampaignRequest request,
        CallSettings callSettings = null) {
      Modify_GetCampaignRequest(ref request, ref callSettings);
      return _callGetCampaign.Sync(request, callSettings);
    }

    /// <summary>
    /// Creates, updates, or removes campaigns. Operation statuses are returned.
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
    public override Task<MutateCampaignsResponse> MutateCampaignsAsync(
        MutateCampaignsRequest request,
        CallSettings callSettings = null) {
      Modify_MutateCampaignsRequest(ref request, ref callSettings);
      return _callMutateCampaigns.Async(request, callSettings);
    }

    /// <summary>
    /// Creates, updates, or removes campaigns. Operation statuses are returned.
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
    public override MutateCampaignsResponse MutateCampaigns(
        MutateCampaignsRequest request,
        CallSettings callSettings = null) {
      Modify_MutateCampaignsRequest(ref request, ref callSettings);
      return _callMutateCampaigns.Sync(request, callSettings);
    }
  }

  // Partial classes to enable page-streaming
}
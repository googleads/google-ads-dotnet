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
  /// Settings for a <see cref="AdGroupServiceClient"/>.
  /// </summary>
  public sealed partial class AdGroupServiceSettings : ServiceSettingsBase {

    /// <summary>
    /// Get a new instance of the default <see cref="AdGroupServiceSettings"/>.
    /// </summary>
    /// <returns>
    /// A new instance of the default <see cref="AdGroupServiceSettings"/>.
    /// </returns>
    public static AdGroupServiceSettings GetDefault() => new AdGroupServiceSettings();

    /// <summary>
    /// Constructs a new <see cref="AdGroupServiceSettings"/> object with default settings.
    /// </summary>
    public AdGroupServiceSettings() {
    }

    private AdGroupServiceSettings(AdGroupServiceSettings existing) : base(existing) {
      GaxPreconditions.CheckNotNull(existing, nameof(existing));
      GetAdGroupSettings = existing.GetAdGroupSettings;
      MutateAdGroupsSettings = existing.MutateAdGroupsSettings;
      OnCopy(existing);
    }

    partial void OnCopy(AdGroupServiceSettings existing);

    /// <summary>
    /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
    /// for "Idempotent" <see cref="AdGroupServiceClient"/> RPC methods.
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
    /// for "NonIdempotent" <see cref="AdGroupServiceClient"/> RPC methods.
    /// </summary>
    /// <remarks>
    /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
    /// </remarks>
    public static Predicate<RpcException> NonIdempotentRetryFilter {
      get;
    } =
        RetrySettings.FilterForStatusCodes();

    /// <summary>
    /// "Default" retry backoff for <see cref="AdGroupServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" retry backoff for <see cref="AdGroupServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" retry backoff for <see cref="AdGroupServiceClient"/> RPC methods is defined as:
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
    /// "Default" timeout backoff for <see cref="AdGroupServiceClient"/> RPC methods.
    /// </summary>
    /// <returns>
    /// The "Default" timeout backoff for <see cref="AdGroupServiceClient"/> RPC methods.
    /// </returns>
    /// <remarks>
    /// The "Default" timeout backoff for <see cref="AdGroupServiceClient"/> RPC methods is defined as:
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
    /// <c>AdGroupServiceClient.GetAdGroup</c> and <c>AdGroupServiceClient.GetAdGroupAsync</c>.
    /// </summary>
    /// <remarks>
    /// The default <c>AdGroupServiceClient.GetAdGroup</c> and
    /// <c>AdGroupServiceClient.GetAdGroupAsync</c> <see cref="RetrySettings"/> are:
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
    public CallSettings GetAdGroupSettings {
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
    /// <c>AdGroupServiceClient.MutateAdGroups</c> and <c>AdGroupServiceClient.MutateAdGroupsAsync</c>.
    /// </summary>
    /// <remarks>
    /// The default <c>AdGroupServiceClient.MutateAdGroups</c> and
    /// <c>AdGroupServiceClient.MutateAdGroupsAsync</c> <see cref="RetrySettings"/> are:
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
    public CallSettings MutateAdGroupsSettings {
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
    /// <returns>A deep clone of this <see cref="AdGroupServiceSettings"/> object.</returns>
    public AdGroupServiceSettings Clone() => new AdGroupServiceSettings(this);
  }

  /// <summary>
  /// AdGroupService client wrapper, for convenient use.
  /// </summary>
  public abstract partial class AdGroupServiceClient {

    /// <summary>
    /// The default endpoint for the AdGroupService service, which is a host of "googleads.googleapis.com" and a port of 443.
    /// </summary>
    public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("googleads.googleapis.com", 443);

    /// <summary>
    /// The default AdGroupService scopes.
    /// </summary>
    /// <remarks>
    /// The default AdGroupService scopes are:
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
    /// Asynchronously creates a <see cref="AdGroupServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary.
    /// </summary>
    /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="AdGroupServiceSettings"/>.</param>
    /// <returns>The task representing the created <see cref="AdGroupServiceClient"/>.</returns>
    public static async Task<AdGroupServiceClient> CreateAsync(ServiceEndpoint endpoint = null, AdGroupServiceSettings settings = null) {
      Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
      return Create(channel, settings);
    }

    /// <summary>
    /// Synchronously creates a <see cref="AdGroupServiceClient"/>, applying defaults for all unspecified settings,
    /// and creating a channel connecting to the given endpoint with application default credentials where
    /// necessary.
    /// </summary>
    /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
    /// <param name="settings">Optional <see cref="AdGroupServiceSettings"/>.</param>
    /// <returns>The created <see cref="AdGroupServiceClient"/>.</returns>
    public static AdGroupServiceClient Create(ServiceEndpoint endpoint = null, AdGroupServiceSettings settings = null) {
      Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
      return Create(channel, settings);
    }

    /// <summary>
    /// Creates a <see cref="AdGroupServiceClient"/> which uses the specified channel for remote operations.
    /// </summary>
    /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
    /// <param name="settings">Optional <see cref="AdGroupServiceSettings"/>.</param>
    /// <returns>The created <see cref="AdGroupServiceClient"/>.</returns>
    public static AdGroupServiceClient Create(Channel channel, AdGroupServiceSettings settings = null) {
      GaxPreconditions.CheckNotNull(channel, nameof(channel));
      AdGroupService.AdGroupServiceClient grpcClient = new AdGroupService.AdGroupServiceClient(channel);
      return new AdGroupServiceClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, AdGroupServiceSettings)"/>
    /// and <see cref="CreateAsync(ServiceEndpoint, AdGroupServiceSettings)"/>. Channels which weren't automatically
    /// created are not affected.
    /// </summary>
    /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, AdGroupServiceSettings)"/>
    /// and <see cref="CreateAsync(ServiceEndpoint, AdGroupServiceSettings)"/> will create new channels, which could
    /// in turn be shut down by another call to this method.</remarks>
    /// <returns>A task representing the asynchronous shutdown operation.</returns>
    public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

    /// <summary>
    /// The underlying gRPC AdGroupService client.
    /// </summary>
    public virtual AdGroupService.AdGroupServiceClient GrpcClient {
      get {
        throw new NotImplementedException();
      }
    }

    /// <summary>
    /// Returns the requested ad group in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the ad group to fetch.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<AdGroup> GetAdGroupAsync(
        string resourceName,
        CallSettings callSettings = null) => GetAdGroupAsync(
            new GetAdGroupRequest {
              ResourceName = GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            },
            callSettings);

    /// <summary>
    /// Returns the requested ad group in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the ad group to fetch.
    /// </param>
    /// <param name="cancellationToken">
    /// A <see cref="CancellationToken"/> to use for this RPC.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<AdGroup> GetAdGroupAsync(
        string resourceName,
        CancellationToken cancellationToken) => GetAdGroupAsync(
            resourceName,
            CallSettings.FromCancellationToken(cancellationToken));

    /// <summary>
    /// Returns the requested ad group in full detail.
    /// </summary>
    /// <param name="resourceName">
    /// The resource name of the ad group to fetch.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public virtual AdGroup GetAdGroup(
        string resourceName,
        CallSettings callSettings = null) => GetAdGroup(
            new GetAdGroupRequest {
              ResourceName = GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            },
            callSettings);

    /// <summary>
    /// Returns the requested ad group in full detail.
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
    public virtual Task<AdGroup> GetAdGroupAsync(
        GetAdGroupRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the requested ad group in full detail.
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
    public virtual AdGroup GetAdGroup(
        GetAdGroupRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Creates, updates, or removes ad groups. Operation statuses are returned.
    /// </summary>
    /// <param name="customerId">
    /// The ID of the customer whose ad groups are being modified.
    /// </param>
    /// <param name="operations">
    /// The list of operations to perform on individual ad groups.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<MutateAdGroupsResponse> MutateAdGroupsAsync(
        string customerId,
        IEnumerable<AdGroupOperation> operations,
        CallSettings callSettings = null) => MutateAdGroupsAsync(
            new MutateAdGroupsRequest {
              CustomerId = GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
              Operations = { GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
            },
            callSettings);

    /// <summary>
    /// Creates, updates, or removes ad groups. Operation statuses are returned.
    /// </summary>
    /// <param name="customerId">
    /// The ID of the customer whose ad groups are being modified.
    /// </param>
    /// <param name="operations">
    /// The list of operations to perform on individual ad groups.
    /// </param>
    /// <param name="cancellationToken">
    /// A <see cref="CancellationToken"/> to use for this RPC.
    /// </param>
    /// <returns>
    /// A Task containing the RPC response.
    /// </returns>
    public virtual Task<MutateAdGroupsResponse> MutateAdGroupsAsync(
        string customerId,
        IEnumerable<AdGroupOperation> operations,
        CancellationToken cancellationToken) => MutateAdGroupsAsync(
            customerId,
            operations,
            CallSettings.FromCancellationToken(cancellationToken));

    /// <summary>
    /// Creates, updates, or removes ad groups. Operation statuses are returned.
    /// </summary>
    /// <param name="customerId">
    /// The ID of the customer whose ad groups are being modified.
    /// </param>
    /// <param name="operations">
    /// The list of operations to perform on individual ad groups.
    /// </param>
    /// <param name="callSettings">
    /// If not null, applies overrides to this RPC call.
    /// </param>
    /// <returns>
    /// The RPC response.
    /// </returns>
    public virtual MutateAdGroupsResponse MutateAdGroups(
        string customerId,
        IEnumerable<AdGroupOperation> operations,
        CallSettings callSettings = null) => MutateAdGroups(
            new MutateAdGroupsRequest {
              CustomerId = GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
              Operations = { GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
            },
            callSettings);

    /// <summary>
    /// Creates, updates, or removes ad groups. Operation statuses are returned.
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
    public virtual Task<MutateAdGroupsResponse> MutateAdGroupsAsync(
        MutateAdGroupsRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Creates, updates, or removes ad groups. Operation statuses are returned.
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
    public virtual MutateAdGroupsResponse MutateAdGroups(
        MutateAdGroupsRequest request,
        CallSettings callSettings = null) {
      throw new NotImplementedException();
    }
  }

  /// <summary>
  /// AdGroupService client wrapper implementation, for convenient use.
  /// </summary>
  public sealed partial class AdGroupServiceClientImpl : AdGroupServiceClient {
    private readonly ApiCall<GetAdGroupRequest, AdGroup> _callGetAdGroup;
    private readonly ApiCall<MutateAdGroupsRequest, MutateAdGroupsResponse> _callMutateAdGroups;

    /// <summary>
    /// Constructs a client wrapper for the AdGroupService service, with the specified gRPC client and settings.
    /// </summary>
    /// <param name="grpcClient">The underlying gRPC client.</param>
    /// <param name="settings">The base <see cref="AdGroupServiceSettings"/> used within this client </param>
    public AdGroupServiceClientImpl(AdGroupService.AdGroupServiceClient grpcClient, AdGroupServiceSettings settings) {
      GrpcClient = grpcClient;
      AdGroupServiceSettings effectiveSettings = settings ?? AdGroupServiceSettings.GetDefault();
      ClientHelper clientHelper = new ClientHelper(effectiveSettings);
      _callGetAdGroup = clientHelper.BuildApiCall<GetAdGroupRequest, AdGroup>(
          GrpcClient.GetAdGroupAsync, GrpcClient.GetAdGroup, effectiveSettings.GetAdGroupSettings);
      _callMutateAdGroups = clientHelper.BuildApiCall<MutateAdGroupsRequest, MutateAdGroupsResponse>(
          GrpcClient.MutateAdGroupsAsync, GrpcClient.MutateAdGroups, effectiveSettings.MutateAdGroupsSettings);
      Modify_ApiCall(ref _callGetAdGroup);
      Modify_GetAdGroupApiCall(ref _callGetAdGroup);
      Modify_ApiCall(ref _callMutateAdGroups);
      Modify_MutateAdGroupsApiCall(ref _callMutateAdGroups);
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
    partial void Modify_GetAdGroupApiCall(ref ApiCall<GetAdGroupRequest, AdGroup> call);

    partial void Modify_MutateAdGroupsApiCall(ref ApiCall<MutateAdGroupsRequest, MutateAdGroupsResponse> call);

    partial void OnConstruction(AdGroupService.AdGroupServiceClient grpcClient, AdGroupServiceSettings effectiveSettings, ClientHelper clientHelper);

    /// <summary>
    /// The underlying gRPC AdGroupService client.
    /// </summary>
    public override AdGroupService.AdGroupServiceClient GrpcClient {
      get;
    }

    // Partial methods called on each request.
    // Allows per-RPC-call modification to the request and CallSettings objects,
    // before the underlying RPC is performed.
    partial void Modify_GetAdGroupRequest(ref GetAdGroupRequest request, ref CallSettings settings);

    partial void Modify_MutateAdGroupsRequest(ref MutateAdGroupsRequest request, ref CallSettings settings);

    /// <summary>
    /// Returns the requested ad group in full detail.
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
    public override Task<AdGroup> GetAdGroupAsync(
        GetAdGroupRequest request,
        CallSettings callSettings = null) {
      Modify_GetAdGroupRequest(ref request, ref callSettings);
      return _callGetAdGroup.Async(request, callSettings);
    }

    /// <summary>
    /// Returns the requested ad group in full detail.
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
    public override AdGroup GetAdGroup(
        GetAdGroupRequest request,
        CallSettings callSettings = null) {
      Modify_GetAdGroupRequest(ref request, ref callSettings);
      return _callGetAdGroup.Sync(request, callSettings);
    }

    /// <summary>
    /// Creates, updates, or removes ad groups. Operation statuses are returned.
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
    public override Task<MutateAdGroupsResponse> MutateAdGroupsAsync(
        MutateAdGroupsRequest request,
        CallSettings callSettings = null) {
      Modify_MutateAdGroupsRequest(ref request, ref callSettings);
      return _callMutateAdGroups.Async(request, callSettings);
    }

    /// <summary>
    /// Creates, updates, or removes ad groups. Operation statuses are returned.
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
    public override MutateAdGroupsResponse MutateAdGroups(
        MutateAdGroupsRequest request,
        CallSettings callSettings = null) {
      Modify_MutateAdGroupsRequest(ref request, ref callSettings);
      return _callMutateAdGroups.Sync(request, callSettings);
    }
  }

  // Partial classes to enable page-streaming
}
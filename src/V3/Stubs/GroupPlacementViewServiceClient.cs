// Copyright 2020 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V3.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V3.Services
{
    /// <summary>
    /// Settings for a <see cref="GroupPlacementViewServiceClient"/>.
    /// </summary>
    public sealed partial class GroupPlacementViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="GroupPlacementViewServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="GroupPlacementViewServiceSettings"/>.
        /// </returns>
        public static GroupPlacementViewServiceSettings GetDefault() => new GroupPlacementViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="GroupPlacementViewServiceSettings"/> object with default settings.
        /// </summary>
        public GroupPlacementViewServiceSettings() { }

        private GroupPlacementViewServiceSettings(GroupPlacementViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetGroupPlacementViewSettings = existing.GetGroupPlacementViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GroupPlacementViewServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="GroupPlacementViewServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="GroupPlacementViewServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="GroupPlacementViewServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="GroupPlacementViewServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="GroupPlacementViewServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 5000 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(5000),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="GroupPlacementViewServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="GroupPlacementViewServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="GroupPlacementViewServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 3600000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(3600000),
            maxDelay: sys::TimeSpan.FromMilliseconds(3600000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupPlacementViewServiceClient.GetGroupPlacementView</c> and <c>GroupPlacementViewServiceClient.GetGroupPlacementViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GroupPlacementViewServiceClient.GetGroupPlacementView</c> and
        /// <c>GroupPlacementViewServiceClient.GetGroupPlacementViewAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 3600000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 3600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetGroupPlacementViewSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="GroupPlacementViewServiceSettings"/> object.</returns>
        public GroupPlacementViewServiceSettings Clone() => new GroupPlacementViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GroupPlacementViewServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class GroupPlacementViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<GroupPlacementViewServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public GroupPlacementViewServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override GroupPlacementViewServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GroupPlacementViewServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<GroupPlacementViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GroupPlacementViewServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => GroupPlacementViewServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => GroupPlacementViewServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => GroupPlacementViewServiceClient.ChannelPool;
    }

    /// <summary>
    /// GroupPlacementViewService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class GroupPlacementViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the GroupPlacementViewService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default GroupPlacementViewService scopes.
        /// </summary>
        /// <remarks>
        /// The default GroupPlacementViewService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="GroupPlacementViewServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// GroupPlacementViewServiceClient client = await GroupPlacementViewServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     GroupPlacementViewServiceClient.DefaultEndpoint.Host, GroupPlacementViewServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// GroupPlacementViewServiceClient client = GroupPlacementViewServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="GroupPlacementViewServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="GroupPlacementViewServiceClient"/>.</returns>
        public static async stt::Task<GroupPlacementViewServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, GroupPlacementViewServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="GroupPlacementViewServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// GroupPlacementViewServiceClient client = GroupPlacementViewServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     GroupPlacementViewServiceClient.DefaultEndpoint.Host, GroupPlacementViewServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// GroupPlacementViewServiceClient client = GroupPlacementViewServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="GroupPlacementViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="GroupPlacementViewServiceClient"/>.</returns>
        public static GroupPlacementViewServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, GroupPlacementViewServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="GroupPlacementViewServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="GroupPlacementViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="GroupPlacementViewServiceClient"/>.</returns>
        public static GroupPlacementViewServiceClient Create(grpccore::Channel channel, GroupPlacementViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="GroupPlacementViewServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="GroupPlacementViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="GroupPlacementViewServiceClient"/>.</returns>
        public static GroupPlacementViewServiceClient Create(grpccore::CallInvoker callInvoker, GroupPlacementViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GroupPlacementViewService.GroupPlacementViewServiceClient grpcClient = new GroupPlacementViewService.GroupPlacementViewServiceClient(callInvoker);
            return new GroupPlacementViewServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, GroupPlacementViewServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, GroupPlacementViewServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, GroupPlacementViewServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, GroupPlacementViewServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC GroupPlacementViewService client.
        /// </summary>
        public virtual GroupPlacementViewService.GroupPlacementViewServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Group Placement view to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::GroupPlacementView> GetGroupPlacementViewAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetGroupPlacementViewAsync(
                new GetGroupPlacementViewRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Group Placement view to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::GroupPlacementView> GetGroupPlacementViewAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetGroupPlacementViewAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Group Placement view to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::GroupPlacementView GetGroupPlacementView(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetGroupPlacementView(
                new GetGroupPlacementViewRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
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
        public virtual stt::Task<gagvr::GroupPlacementView> GetGroupPlacementViewAsync(
            GetGroupPlacementViewRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::GroupPlacementView> GetGroupPlacementViewAsync(
            GetGroupPlacementViewRequest request,
            st::CancellationToken cancellationToken) => GetGroupPlacementViewAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
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
        public virtual gagvr::GroupPlacementView GetGroupPlacementView(
            GetGroupPlacementViewRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// GroupPlacementViewService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class GroupPlacementViewServiceClientImpl : GroupPlacementViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetGroupPlacementViewRequest, gagvr::GroupPlacementView> _callGetGroupPlacementView;

        /// <summary>
        /// Constructs a client wrapper for the GroupPlacementViewService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GroupPlacementViewServiceSettings"/> used within this client </param>
        public GroupPlacementViewServiceClientImpl(GroupPlacementViewService.GroupPlacementViewServiceClient grpcClient, GroupPlacementViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            GroupPlacementViewServiceSettings effectiveSettings = settings ?? GroupPlacementViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetGroupPlacementView = clientHelper.BuildApiCall<GetGroupPlacementViewRequest, gagvr::GroupPlacementView>(
                GrpcClient.GetGroupPlacementViewAsync, GrpcClient.GetGroupPlacementView, effectiveSettings.GetGroupPlacementViewSettings)
                .WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetGroupPlacementView);
            Modify_GetGroupPlacementViewApiCall(ref _callGetGroupPlacementView);
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
        partial void Modify_GetGroupPlacementViewApiCall(ref gaxgrpc::ApiCall<GetGroupPlacementViewRequest, gagvr::GroupPlacementView> call);
        partial void OnConstruction(GroupPlacementViewService.GroupPlacementViewServiceClient grpcClient, GroupPlacementViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC GroupPlacementViewService client.
        /// </summary>
        public override GroupPlacementViewService.GroupPlacementViewServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetGroupPlacementViewRequest(ref GetGroupPlacementViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
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
        public override stt::Task<gagvr::GroupPlacementView> GetGroupPlacementViewAsync(
            GetGroupPlacementViewRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGroupPlacementViewRequest(ref request, ref callSettings);
            return _callGetGroupPlacementView.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
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
        public override gagvr::GroupPlacementView GetGroupPlacementView(
            GetGroupPlacementViewRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGroupPlacementViewRequest(ref request, ref callSettings);
            return _callGetGroupPlacementView.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

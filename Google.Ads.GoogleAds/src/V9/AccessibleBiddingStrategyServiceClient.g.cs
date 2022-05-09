// Copyright 2021 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V9.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V9.Services
{
    /// <summary>Settings for <see cref="AccessibleBiddingStrategyServiceClient"/> instances.</summary>
    public sealed partial class AccessibleBiddingStrategyServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AccessibleBiddingStrategyServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AccessibleBiddingStrategyServiceSettings"/>.</returns>
        public static AccessibleBiddingStrategyServiceSettings GetDefault() => new AccessibleBiddingStrategyServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AccessibleBiddingStrategyServiceSettings"/> object with default settings.
        /// </summary>
        public AccessibleBiddingStrategyServiceSettings()
        {
        }

        private AccessibleBiddingStrategyServiceSettings(AccessibleBiddingStrategyServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAccessibleBiddingStrategySettings = existing.GetAccessibleBiddingStrategySettings;
            OnCopy(existing);
        }

        partial void OnCopy(AccessibleBiddingStrategyServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccessibleBiddingStrategyServiceClient.GetAccessibleBiddingStrategy</c> and
        /// <c>AccessibleBiddingStrategyServiceClient.GetAccessibleBiddingStrategyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 14400 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAccessibleBiddingStrategySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AccessibleBiddingStrategyServiceSettings"/> object.</returns>
        public AccessibleBiddingStrategyServiceSettings Clone() => new AccessibleBiddingStrategyServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AccessibleBiddingStrategyServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class AccessibleBiddingStrategyServiceClientBuilder : gaxgrpc::ClientBuilderBase<AccessibleBiddingStrategyServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AccessibleBiddingStrategyServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AccessibleBiddingStrategyServiceClientBuilder()
        {
            UseJwtAccessWithScopes = AccessibleBiddingStrategyServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref AccessibleBiddingStrategyServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AccessibleBiddingStrategyServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AccessibleBiddingStrategyServiceClient Build()
        {
            AccessibleBiddingStrategyServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AccessibleBiddingStrategyServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AccessibleBiddingStrategyServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AccessibleBiddingStrategyServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AccessibleBiddingStrategyServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AccessibleBiddingStrategyServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AccessibleBiddingStrategyServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AccessibleBiddingStrategyServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            AccessibleBiddingStrategyServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AccessibleBiddingStrategyServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AccessibleBiddingStrategyService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to read accessible bidding strategies.
    /// </remarks>
    public abstract partial class AccessibleBiddingStrategyServiceClient
    {
        /// <summary>
        /// The default endpoint for the AccessibleBiddingStrategyService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AccessibleBiddingStrategyService scopes.</summary>
        /// <remarks>
        /// The default AccessibleBiddingStrategyService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AccessibleBiddingStrategyServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AccessibleBiddingStrategyServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AccessibleBiddingStrategyServiceClient"/>.</returns>
        public static stt::Task<AccessibleBiddingStrategyServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AccessibleBiddingStrategyServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AccessibleBiddingStrategyServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AccessibleBiddingStrategyServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AccessibleBiddingStrategyServiceClient"/>.</returns>
        public static AccessibleBiddingStrategyServiceClient Create() =>
            new AccessibleBiddingStrategyServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AccessibleBiddingStrategyServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AccessibleBiddingStrategyServiceSettings"/>.</param>
        /// <returns>The created <see cref="AccessibleBiddingStrategyServiceClient"/>.</returns>
        internal static AccessibleBiddingStrategyServiceClient Create(grpccore::CallInvoker callInvoker, AccessibleBiddingStrategyServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient grpcClient = new AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient(callInvoker);
            return new AccessibleBiddingStrategyServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC AccessibleBiddingStrategyService client</summary>
        public virtual AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested accessible bidding strategy in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AccessibleBiddingStrategy GetAccessibleBiddingStrategy(GetAccessibleBiddingStrategyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested accessible bidding strategy in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccessibleBiddingStrategy> GetAccessibleBiddingStrategyAsync(GetAccessibleBiddingStrategyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested accessible bidding strategy in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccessibleBiddingStrategy> GetAccessibleBiddingStrategyAsync(GetAccessibleBiddingStrategyRequest request, st::CancellationToken cancellationToken) =>
            GetAccessibleBiddingStrategyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested accessible bidding strategy in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the accessible bidding strategy to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AccessibleBiddingStrategy GetAccessibleBiddingStrategy(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessibleBiddingStrategy(new GetAccessibleBiddingStrategyRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested accessible bidding strategy in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the accessible bidding strategy to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccessibleBiddingStrategy> GetAccessibleBiddingStrategyAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessibleBiddingStrategyAsync(new GetAccessibleBiddingStrategyRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested accessible bidding strategy in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the accessible bidding strategy to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccessibleBiddingStrategy> GetAccessibleBiddingStrategyAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAccessibleBiddingStrategyAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested accessible bidding strategy in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the accessible bidding strategy to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AccessibleBiddingStrategy GetAccessibleBiddingStrategy(gagvr::AccessibleBiddingStrategyName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessibleBiddingStrategy(new GetAccessibleBiddingStrategyRequest
            {
                ResourceNameAsAccessibleBiddingStrategyName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested accessible bidding strategy in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the accessible bidding strategy to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccessibleBiddingStrategy> GetAccessibleBiddingStrategyAsync(gagvr::AccessibleBiddingStrategyName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAccessibleBiddingStrategyAsync(new GetAccessibleBiddingStrategyRequest
            {
                ResourceNameAsAccessibleBiddingStrategyName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested accessible bidding strategy in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the accessible bidding strategy to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccessibleBiddingStrategy> GetAccessibleBiddingStrategyAsync(gagvr::AccessibleBiddingStrategyName resourceName, st::CancellationToken cancellationToken) =>
            GetAccessibleBiddingStrategyAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AccessibleBiddingStrategyService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to read accessible bidding strategies.
    /// </remarks>
    public sealed partial class AccessibleBiddingStrategyServiceClientImpl : AccessibleBiddingStrategyServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAccessibleBiddingStrategyRequest, gagvr::AccessibleBiddingStrategy> _callGetAccessibleBiddingStrategy;

        /// <summary>
        /// Constructs a client wrapper for the AccessibleBiddingStrategyService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AccessibleBiddingStrategyServiceSettings"/> used within this client.
        /// </param>
        public AccessibleBiddingStrategyServiceClientImpl(AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient grpcClient, AccessibleBiddingStrategyServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AccessibleBiddingStrategyServiceSettings effectiveSettings = settings ?? AccessibleBiddingStrategyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAccessibleBiddingStrategy = clientHelper.BuildApiCall<GetAccessibleBiddingStrategyRequest, gagvr::AccessibleBiddingStrategy>(grpcClient.GetAccessibleBiddingStrategyAsync, grpcClient.GetAccessibleBiddingStrategy, effectiveSettings.GetAccessibleBiddingStrategySettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAccessibleBiddingStrategy);
            Modify_GetAccessibleBiddingStrategyApiCall(ref _callGetAccessibleBiddingStrategy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAccessibleBiddingStrategyApiCall(ref gaxgrpc::ApiCall<GetAccessibleBiddingStrategyRequest, gagvr::AccessibleBiddingStrategy> call);

        partial void OnConstruction(AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient grpcClient, AccessibleBiddingStrategyServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AccessibleBiddingStrategyService client</summary>
        public override AccessibleBiddingStrategyService.AccessibleBiddingStrategyServiceClient GrpcClient { get; }

        partial void Modify_GetAccessibleBiddingStrategyRequest(ref GetAccessibleBiddingStrategyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested accessible bidding strategy in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::AccessibleBiddingStrategy GetAccessibleBiddingStrategy(GetAccessibleBiddingStrategyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccessibleBiddingStrategyRequest(ref request, ref callSettings);
            return _callGetAccessibleBiddingStrategy.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested accessible bidding strategy in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::AccessibleBiddingStrategy> GetAccessibleBiddingStrategyAsync(GetAccessibleBiddingStrategyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccessibleBiddingStrategyRequest(ref request, ref callSettings);
            return _callGetAccessibleBiddingStrategy.Async(request, callSettings);
        }
    }
}

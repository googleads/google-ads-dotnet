// Copyright 2022 Google LLC
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

namespace Google.Ads.GoogleAds.V10.Services
{
    /// <summary>Settings for <see cref="ThirdPartyAppAnalyticsLinkServiceClient"/> instances.</summary>
    public sealed partial class ThirdPartyAppAnalyticsLinkServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ThirdPartyAppAnalyticsLinkServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="ThirdPartyAppAnalyticsLinkServiceSettings"/>.</returns>
        public static ThirdPartyAppAnalyticsLinkServiceSettings GetDefault() =>
            new ThirdPartyAppAnalyticsLinkServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ThirdPartyAppAnalyticsLinkServiceSettings"/> object with default settings.
        /// </summary>
        public ThirdPartyAppAnalyticsLinkServiceSettings()
        {
        }

        private ThirdPartyAppAnalyticsLinkServiceSettings(ThirdPartyAppAnalyticsLinkServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RegenerateShareableLinkIdSettings = existing.RegenerateShareableLinkIdSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ThirdPartyAppAnalyticsLinkServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ThirdPartyAppAnalyticsLinkServiceClient.RegenerateShareableLinkId</c> and
        /// <c>ThirdPartyAppAnalyticsLinkServiceClient.RegenerateShareableLinkIdAsync</c>.
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
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RegenerateShareableLinkIdSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ThirdPartyAppAnalyticsLinkServiceSettings"/> object.</returns>
        public ThirdPartyAppAnalyticsLinkServiceSettings Clone() => new ThirdPartyAppAnalyticsLinkServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ThirdPartyAppAnalyticsLinkServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class ThirdPartyAppAnalyticsLinkServiceClientBuilder : gaxgrpc::ClientBuilderBase<ThirdPartyAppAnalyticsLinkServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ThirdPartyAppAnalyticsLinkServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ThirdPartyAppAnalyticsLinkServiceClientBuilder()
        {
            UseJwtAccessWithScopes = ThirdPartyAppAnalyticsLinkServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref ThirdPartyAppAnalyticsLinkServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ThirdPartyAppAnalyticsLinkServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ThirdPartyAppAnalyticsLinkServiceClient Build()
        {
            ThirdPartyAppAnalyticsLinkServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ThirdPartyAppAnalyticsLinkServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ThirdPartyAppAnalyticsLinkServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ThirdPartyAppAnalyticsLinkServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ThirdPartyAppAnalyticsLinkServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ThirdPartyAppAnalyticsLinkServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ThirdPartyAppAnalyticsLinkServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ThirdPartyAppAnalyticsLinkServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            ThirdPartyAppAnalyticsLinkServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ThirdPartyAppAnalyticsLinkServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ThirdPartyAppAnalyticsLinkService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service allows management of links between Google Ads and third party
    /// app analytics.
    /// </remarks>
    public abstract partial class ThirdPartyAppAnalyticsLinkServiceClient
    {
        /// <summary>
        /// The default endpoint for the ThirdPartyAppAnalyticsLinkService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ThirdPartyAppAnalyticsLinkService scopes.</summary>
        /// <remarks>
        /// The default ThirdPartyAppAnalyticsLinkService scopes are:
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
        /// Asynchronously creates a <see cref="ThirdPartyAppAnalyticsLinkServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ThirdPartyAppAnalyticsLinkServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ThirdPartyAppAnalyticsLinkServiceClient"/>.</returns>
        public static stt::Task<ThirdPartyAppAnalyticsLinkServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ThirdPartyAppAnalyticsLinkServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ThirdPartyAppAnalyticsLinkServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ThirdPartyAppAnalyticsLinkServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ThirdPartyAppAnalyticsLinkServiceClient"/>.</returns>
        public static ThirdPartyAppAnalyticsLinkServiceClient Create() =>
            new ThirdPartyAppAnalyticsLinkServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ThirdPartyAppAnalyticsLinkServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ThirdPartyAppAnalyticsLinkServiceSettings"/>.</param>
        /// <returns>The created <see cref="ThirdPartyAppAnalyticsLinkServiceClient"/>.</returns>
        internal static ThirdPartyAppAnalyticsLinkServiceClient Create(grpccore::CallInvoker callInvoker, ThirdPartyAppAnalyticsLinkServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ThirdPartyAppAnalyticsLinkService.ThirdPartyAppAnalyticsLinkServiceClient grpcClient = new ThirdPartyAppAnalyticsLinkService.ThirdPartyAppAnalyticsLinkServiceClient(callInvoker);
            return new ThirdPartyAppAnalyticsLinkServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ThirdPartyAppAnalyticsLinkService client</summary>
        public virtual ThirdPartyAppAnalyticsLinkService.ThirdPartyAppAnalyticsLinkServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Regenerate ThirdPartyAppAnalyticsLink.shareable_link_id that should be
        /// provided to the third party when setting up app analytics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RegenerateShareableLinkIdResponse RegenerateShareableLinkId(RegenerateShareableLinkIdRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Regenerate ThirdPartyAppAnalyticsLink.shareable_link_id that should be
        /// provided to the third party when setting up app analytics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegenerateShareableLinkIdResponse> RegenerateShareableLinkIdAsync(RegenerateShareableLinkIdRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Regenerate ThirdPartyAppAnalyticsLink.shareable_link_id that should be
        /// provided to the third party when setting up app analytics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegenerateShareableLinkIdResponse> RegenerateShareableLinkIdAsync(RegenerateShareableLinkIdRequest request, st::CancellationToken cancellationToken) =>
            RegenerateShareableLinkIdAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ThirdPartyAppAnalyticsLinkService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service allows management of links between Google Ads and third party
    /// app analytics.
    /// </remarks>
    public sealed partial class ThirdPartyAppAnalyticsLinkServiceClientImpl : ThirdPartyAppAnalyticsLinkServiceClient
    {
        private readonly gaxgrpc::ApiCall<RegenerateShareableLinkIdRequest, RegenerateShareableLinkIdResponse> _callRegenerateShareableLinkId;

        /// <summary>
        /// Constructs a client wrapper for the ThirdPartyAppAnalyticsLinkService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ThirdPartyAppAnalyticsLinkServiceSettings"/> used within this client.
        /// </param>
        public ThirdPartyAppAnalyticsLinkServiceClientImpl(ThirdPartyAppAnalyticsLinkService.ThirdPartyAppAnalyticsLinkServiceClient grpcClient, ThirdPartyAppAnalyticsLinkServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ThirdPartyAppAnalyticsLinkServiceSettings effectiveSettings = settings ?? ThirdPartyAppAnalyticsLinkServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callRegenerateShareableLinkId = clientHelper.BuildApiCall<RegenerateShareableLinkIdRequest, RegenerateShareableLinkIdResponse>(grpcClient.RegenerateShareableLinkIdAsync, grpcClient.RegenerateShareableLinkId, effectiveSettings.RegenerateShareableLinkIdSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callRegenerateShareableLinkId);
            Modify_RegenerateShareableLinkIdApiCall(ref _callRegenerateShareableLinkId);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RegenerateShareableLinkIdApiCall(ref gaxgrpc::ApiCall<RegenerateShareableLinkIdRequest, RegenerateShareableLinkIdResponse> call);

        partial void OnConstruction(ThirdPartyAppAnalyticsLinkService.ThirdPartyAppAnalyticsLinkServiceClient grpcClient, ThirdPartyAppAnalyticsLinkServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ThirdPartyAppAnalyticsLinkService client</summary>
        public override ThirdPartyAppAnalyticsLinkService.ThirdPartyAppAnalyticsLinkServiceClient GrpcClient { get; }

        partial void Modify_RegenerateShareableLinkIdRequest(ref RegenerateShareableLinkIdRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Regenerate ThirdPartyAppAnalyticsLink.shareable_link_id that should be
        /// provided to the third party when setting up app analytics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RegenerateShareableLinkIdResponse RegenerateShareableLinkId(RegenerateShareableLinkIdRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegenerateShareableLinkIdRequest(ref request, ref callSettings);
            return _callRegenerateShareableLinkId.Sync(request, callSettings);
        }

        /// <summary>
        /// Regenerate ThirdPartyAppAnalyticsLink.shareable_link_id that should be
        /// provided to the third party when setting up app analytics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RegenerateShareableLinkIdResponse> RegenerateShareableLinkIdAsync(RegenerateShareableLinkIdRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegenerateShareableLinkIdRequest(ref request, ref callSettings);
            return _callRegenerateShareableLinkId.Async(request, callSettings);
        }
    }
}

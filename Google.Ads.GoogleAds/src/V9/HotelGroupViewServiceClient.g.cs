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
    /// <summary>Settings for <see cref="HotelGroupViewServiceClient"/> instances.</summary>
    public sealed partial class HotelGroupViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="HotelGroupViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="HotelGroupViewServiceSettings"/>.</returns>
        public static HotelGroupViewServiceSettings GetDefault() => new HotelGroupViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="HotelGroupViewServiceSettings"/> object with default settings.
        /// </summary>
        public HotelGroupViewServiceSettings()
        {
        }

        private HotelGroupViewServiceSettings(HotelGroupViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetHotelGroupViewSettings = existing.GetHotelGroupViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(HotelGroupViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HotelGroupViewServiceClient.GetHotelGroupView</c> and
        /// <c>HotelGroupViewServiceClient.GetHotelGroupViewAsync</c>.
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
        public gaxgrpc::CallSettings GetHotelGroupViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="HotelGroupViewServiceSettings"/> object.</returns>
        public HotelGroupViewServiceSettings Clone() => new HotelGroupViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="HotelGroupViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class HotelGroupViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<HotelGroupViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public HotelGroupViewServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public HotelGroupViewServiceClientBuilder()
        {
            UseJwtAccessWithScopes = HotelGroupViewServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref HotelGroupViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<HotelGroupViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override HotelGroupViewServiceClient Build()
        {
            HotelGroupViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<HotelGroupViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<HotelGroupViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private HotelGroupViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return HotelGroupViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<HotelGroupViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return HotelGroupViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => HotelGroupViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => HotelGroupViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => HotelGroupViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>HotelGroupViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Hotel Group Views.
    /// </remarks>
    public abstract partial class HotelGroupViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the HotelGroupViewService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default HotelGroupViewService scopes.</summary>
        /// <remarks>
        /// The default HotelGroupViewService scopes are:
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
        /// Asynchronously creates a <see cref="HotelGroupViewServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="HotelGroupViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="HotelGroupViewServiceClient"/>.</returns>
        public static stt::Task<HotelGroupViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new HotelGroupViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="HotelGroupViewServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="HotelGroupViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="HotelGroupViewServiceClient"/>.</returns>
        public static HotelGroupViewServiceClient Create() => new HotelGroupViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="HotelGroupViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="HotelGroupViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="HotelGroupViewServiceClient"/>.</returns>
        internal static HotelGroupViewServiceClient Create(grpccore::CallInvoker callInvoker, HotelGroupViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            HotelGroupViewService.HotelGroupViewServiceClient grpcClient = new HotelGroupViewService.HotelGroupViewServiceClient(callInvoker);
            return new HotelGroupViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC HotelGroupViewService client</summary>
        public virtual HotelGroupViewService.HotelGroupViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Hotel Group View in full detail.
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
        public virtual gagvr::HotelGroupView GetHotelGroupView(GetHotelGroupViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Hotel Group View in full detail.
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
        public virtual stt::Task<gagvr::HotelGroupView> GetHotelGroupViewAsync(GetHotelGroupViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Hotel Group View in full detail.
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
        public virtual stt::Task<gagvr::HotelGroupView> GetHotelGroupViewAsync(GetHotelGroupViewRequest request, st::CancellationToken cancellationToken) =>
            GetHotelGroupViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Hotel Group View in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Hotel Group View to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::HotelGroupView GetHotelGroupView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetHotelGroupView(new GetHotelGroupViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Hotel Group View in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Hotel Group View to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::HotelGroupView> GetHotelGroupViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetHotelGroupViewAsync(new GetHotelGroupViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Hotel Group View in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Hotel Group View to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::HotelGroupView> GetHotelGroupViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetHotelGroupViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Hotel Group View in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Hotel Group View to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::HotelGroupView GetHotelGroupView(gagvr::HotelGroupViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetHotelGroupView(new GetHotelGroupViewRequest
            {
                ResourceNameAsHotelGroupViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Hotel Group View in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Hotel Group View to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::HotelGroupView> GetHotelGroupViewAsync(gagvr::HotelGroupViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetHotelGroupViewAsync(new GetHotelGroupViewRequest
            {
                ResourceNameAsHotelGroupViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Hotel Group View in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Hotel Group View to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::HotelGroupView> GetHotelGroupViewAsync(gagvr::HotelGroupViewName resourceName, st::CancellationToken cancellationToken) =>
            GetHotelGroupViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>HotelGroupViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Hotel Group Views.
    /// </remarks>
    public sealed partial class HotelGroupViewServiceClientImpl : HotelGroupViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetHotelGroupViewRequest, gagvr::HotelGroupView> _callGetHotelGroupView;

        /// <summary>
        /// Constructs a client wrapper for the HotelGroupViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="HotelGroupViewServiceSettings"/> used within this client.</param>
        public HotelGroupViewServiceClientImpl(HotelGroupViewService.HotelGroupViewServiceClient grpcClient, HotelGroupViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            HotelGroupViewServiceSettings effectiveSettings = settings ?? HotelGroupViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetHotelGroupView = clientHelper.BuildApiCall<GetHotelGroupViewRequest, gagvr::HotelGroupView>(grpcClient.GetHotelGroupViewAsync, grpcClient.GetHotelGroupView, effectiveSettings.GetHotelGroupViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetHotelGroupView);
            Modify_GetHotelGroupViewApiCall(ref _callGetHotelGroupView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetHotelGroupViewApiCall(ref gaxgrpc::ApiCall<GetHotelGroupViewRequest, gagvr::HotelGroupView> call);

        partial void OnConstruction(HotelGroupViewService.HotelGroupViewServiceClient grpcClient, HotelGroupViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC HotelGroupViewService client</summary>
        public override HotelGroupViewService.HotelGroupViewServiceClient GrpcClient { get; }

        partial void Modify_GetHotelGroupViewRequest(ref GetHotelGroupViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested Hotel Group View in full detail.
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
        public override gagvr::HotelGroupView GetHotelGroupView(GetHotelGroupViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHotelGroupViewRequest(ref request, ref callSettings);
            return _callGetHotelGroupView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Hotel Group View in full detail.
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
        public override stt::Task<gagvr::HotelGroupView> GetHotelGroupViewAsync(GetHotelGroupViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHotelGroupViewRequest(ref request, ref callSettings);
            return _callGetHotelGroupView.Async(request, callSettings);
        }
    }
}

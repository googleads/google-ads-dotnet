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
    /// <summary>Settings for <see cref="AdScheduleViewServiceClient"/> instances.</summary>
    public sealed partial class AdScheduleViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdScheduleViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdScheduleViewServiceSettings"/>.</returns>
        public static AdScheduleViewServiceSettings GetDefault() => new AdScheduleViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AdScheduleViewServiceSettings"/> object with default settings.
        /// </summary>
        public AdScheduleViewServiceSettings()
        {
        }

        private AdScheduleViewServiceSettings(AdScheduleViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdScheduleViewSettings = existing.GetAdScheduleViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdScheduleViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdScheduleViewServiceClient.GetAdScheduleView</c> and
        /// <c>AdScheduleViewServiceClient.GetAdScheduleViewAsync</c>.
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
        public gaxgrpc::CallSettings GetAdScheduleViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdScheduleViewServiceSettings"/> object.</returns>
        public AdScheduleViewServiceSettings Clone() => new AdScheduleViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdScheduleViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class AdScheduleViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdScheduleViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdScheduleViewServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AdScheduleViewServiceClientBuilder()
        {
            UseJwtAccessWithScopes = AdScheduleViewServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref AdScheduleViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdScheduleViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdScheduleViewServiceClient Build()
        {
            AdScheduleViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdScheduleViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdScheduleViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdScheduleViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdScheduleViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AdScheduleViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdScheduleViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AdScheduleViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AdScheduleViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdScheduleViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AdScheduleViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch ad schedule views.
    /// </remarks>
    public abstract partial class AdScheduleViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdScheduleViewService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdScheduleViewService scopes.</summary>
        /// <remarks>
        /// The default AdScheduleViewService scopes are:
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
        /// Asynchronously creates a <see cref="AdScheduleViewServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AdScheduleViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdScheduleViewServiceClient"/>.</returns>
        public static stt::Task<AdScheduleViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdScheduleViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdScheduleViewServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AdScheduleViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdScheduleViewServiceClient"/>.</returns>
        public static AdScheduleViewServiceClient Create() => new AdScheduleViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdScheduleViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdScheduleViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdScheduleViewServiceClient"/>.</returns>
        internal static AdScheduleViewServiceClient Create(grpccore::CallInvoker callInvoker, AdScheduleViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdScheduleViewService.AdScheduleViewServiceClient grpcClient = new AdScheduleViewService.AdScheduleViewServiceClient(callInvoker);
            return new AdScheduleViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AdScheduleViewService client</summary>
        public virtual AdScheduleViewService.AdScheduleViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad schedule view in full detail.
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
        public virtual gagvr::AdScheduleView GetAdScheduleView(GetAdScheduleViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad schedule view in full detail.
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
        public virtual stt::Task<gagvr::AdScheduleView> GetAdScheduleViewAsync(GetAdScheduleViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad schedule view in full detail.
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
        public virtual stt::Task<gagvr::AdScheduleView> GetAdScheduleViewAsync(GetAdScheduleViewRequest request, st::CancellationToken cancellationToken) =>
            GetAdScheduleViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad schedule view in full detail.
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
        /// Required. The resource name of the ad schedule view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdScheduleView GetAdScheduleView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdScheduleView(new GetAdScheduleViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad schedule view in full detail.
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
        /// Required. The resource name of the ad schedule view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdScheduleView> GetAdScheduleViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdScheduleViewAsync(new GetAdScheduleViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad schedule view in full detail.
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
        /// Required. The resource name of the ad schedule view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdScheduleView> GetAdScheduleViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAdScheduleViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad schedule view in full detail.
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
        /// Required. The resource name of the ad schedule view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdScheduleView GetAdScheduleView(gagvr::AdScheduleViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdScheduleView(new GetAdScheduleViewRequest
            {
                ResourceNameAsAdScheduleViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad schedule view in full detail.
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
        /// Required. The resource name of the ad schedule view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdScheduleView> GetAdScheduleViewAsync(gagvr::AdScheduleViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdScheduleViewAsync(new GetAdScheduleViewRequest
            {
                ResourceNameAsAdScheduleViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad schedule view in full detail.
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
        /// Required. The resource name of the ad schedule view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdScheduleView> GetAdScheduleViewAsync(gagvr::AdScheduleViewName resourceName, st::CancellationToken cancellationToken) =>
            GetAdScheduleViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdScheduleViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch ad schedule views.
    /// </remarks>
    public sealed partial class AdScheduleViewServiceClientImpl : AdScheduleViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdScheduleViewRequest, gagvr::AdScheduleView> _callGetAdScheduleView;

        /// <summary>
        /// Constructs a client wrapper for the AdScheduleViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdScheduleViewServiceSettings"/> used within this client.</param>
        public AdScheduleViewServiceClientImpl(AdScheduleViewService.AdScheduleViewServiceClient grpcClient, AdScheduleViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AdScheduleViewServiceSettings effectiveSettings = settings ?? AdScheduleViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAdScheduleView = clientHelper.BuildApiCall<GetAdScheduleViewRequest, gagvr::AdScheduleView>(grpcClient.GetAdScheduleViewAsync, grpcClient.GetAdScheduleView, effectiveSettings.GetAdScheduleViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAdScheduleView);
            Modify_GetAdScheduleViewApiCall(ref _callGetAdScheduleView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdScheduleViewApiCall(ref gaxgrpc::ApiCall<GetAdScheduleViewRequest, gagvr::AdScheduleView> call);

        partial void OnConstruction(AdScheduleViewService.AdScheduleViewServiceClient grpcClient, AdScheduleViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdScheduleViewService client</summary>
        public override AdScheduleViewService.AdScheduleViewServiceClient GrpcClient { get; }

        partial void Modify_GetAdScheduleViewRequest(ref GetAdScheduleViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested ad schedule view in full detail.
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
        public override gagvr::AdScheduleView GetAdScheduleView(GetAdScheduleViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdScheduleViewRequest(ref request, ref callSettings);
            return _callGetAdScheduleView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested ad schedule view in full detail.
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
        public override stt::Task<gagvr::AdScheduleView> GetAdScheduleViewAsync(GetAdScheduleViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdScheduleViewRequest(ref request, ref callSettings);
            return _callGetAdScheduleView.Async(request, callSettings);
        }
    }
}

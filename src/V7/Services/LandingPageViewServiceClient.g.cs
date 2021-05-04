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

using gagvr = Google.Ads.GoogleAds.V7.Resources;
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

namespace Google.Ads.GoogleAds.V7.Services
{
    /// <summary>Settings for <see cref="LandingPageViewServiceClient"/> instances.</summary>
    public sealed partial class LandingPageViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LandingPageViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LandingPageViewServiceSettings"/>.</returns>
        public static LandingPageViewServiceSettings GetDefault() => new LandingPageViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="LandingPageViewServiceSettings"/> object with default settings.
        /// </summary>
        public LandingPageViewServiceSettings()
        {
        }

        private LandingPageViewServiceSettings(LandingPageViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetLandingPageViewSettings = existing.GetLandingPageViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LandingPageViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LandingPageViewServiceClient.GetLandingPageView</c> and
        /// <c>LandingPageViewServiceClient.GetLandingPageViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLandingPageViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LandingPageViewServiceSettings"/> object.</returns>
        public LandingPageViewServiceSettings Clone() => new LandingPageViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LandingPageViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class LandingPageViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<LandingPageViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LandingPageViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref LandingPageViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LandingPageViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LandingPageViewServiceClient Build()
        {
            LandingPageViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LandingPageViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LandingPageViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LandingPageViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LandingPageViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<LandingPageViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LandingPageViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => LandingPageViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => LandingPageViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LandingPageViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>LandingPageViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch landing page views.
    /// </remarks>
    public abstract partial class LandingPageViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the LandingPageViewService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default LandingPageViewService scopes.</summary>
        /// <remarks>
        /// The default LandingPageViewService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="LandingPageViewServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="LandingPageViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LandingPageViewServiceClient"/>.</returns>
        public static stt::Task<LandingPageViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LandingPageViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LandingPageViewServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="LandingPageViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LandingPageViewServiceClient"/>.</returns>
        public static LandingPageViewServiceClient Create() => new LandingPageViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LandingPageViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LandingPageViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="LandingPageViewServiceClient"/>.</returns>
        internal static LandingPageViewServiceClient Create(grpccore::CallInvoker callInvoker, LandingPageViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LandingPageViewService.LandingPageViewServiceClient grpcClient = new LandingPageViewService.LandingPageViewServiceClient(callInvoker);
            return new LandingPageViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC LandingPageViewService client</summary>
        public virtual LandingPageViewService.LandingPageViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested landing page view in full detail.
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
        public virtual gagvr::LandingPageView GetLandingPageView(GetLandingPageViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested landing page view in full detail.
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
        public virtual stt::Task<gagvr::LandingPageView> GetLandingPageViewAsync(GetLandingPageViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested landing page view in full detail.
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
        public virtual stt::Task<gagvr::LandingPageView> GetLandingPageViewAsync(GetLandingPageViewRequest request, st::CancellationToken cancellationToken) =>
            GetLandingPageViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested landing page view in full detail.
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
        /// Required. The resource name of the landing page view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::LandingPageView GetLandingPageView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLandingPageView(new GetLandingPageViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested landing page view in full detail.
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
        /// Required. The resource name of the landing page view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LandingPageView> GetLandingPageViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLandingPageViewAsync(new GetLandingPageViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested landing page view in full detail.
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
        /// Required. The resource name of the landing page view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LandingPageView> GetLandingPageViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetLandingPageViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested landing page view in full detail.
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
        /// Required. The resource name of the landing page view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::LandingPageView GetLandingPageView(gagvr::LandingPageViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLandingPageView(new GetLandingPageViewRequest
            {
                ResourceNameAsLandingPageViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested landing page view in full detail.
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
        /// Required. The resource name of the landing page view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LandingPageView> GetLandingPageViewAsync(gagvr::LandingPageViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLandingPageViewAsync(new GetLandingPageViewRequest
            {
                ResourceNameAsLandingPageViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested landing page view in full detail.
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
        /// Required. The resource name of the landing page view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LandingPageView> GetLandingPageViewAsync(gagvr::LandingPageViewName resourceName, st::CancellationToken cancellationToken) =>
            GetLandingPageViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LandingPageViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch landing page views.
    /// </remarks>
    public sealed partial class LandingPageViewServiceClientImpl : LandingPageViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetLandingPageViewRequest, gagvr::LandingPageView> _callGetLandingPageView;

        /// <summary>
        /// Constructs a client wrapper for the LandingPageViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="LandingPageViewServiceSettings"/> used within this client.
        /// </param>
        public LandingPageViewServiceClientImpl(LandingPageViewService.LandingPageViewServiceClient grpcClient, LandingPageViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            LandingPageViewServiceSettings effectiveSettings = settings ?? LandingPageViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetLandingPageView = clientHelper.BuildApiCall<GetLandingPageViewRequest, gagvr::LandingPageView>(grpcClient.GetLandingPageViewAsync, grpcClient.GetLandingPageView, effectiveSettings.GetLandingPageViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetLandingPageView);
            Modify_GetLandingPageViewApiCall(ref _callGetLandingPageView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetLandingPageViewApiCall(ref gaxgrpc::ApiCall<GetLandingPageViewRequest, gagvr::LandingPageView> call);

        partial void OnConstruction(LandingPageViewService.LandingPageViewServiceClient grpcClient, LandingPageViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LandingPageViewService client</summary>
        public override LandingPageViewService.LandingPageViewServiceClient GrpcClient { get; }

        partial void Modify_GetLandingPageViewRequest(ref GetLandingPageViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested landing page view in full detail.
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
        public override gagvr::LandingPageView GetLandingPageView(GetLandingPageViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLandingPageViewRequest(ref request, ref callSettings);
            return _callGetLandingPageView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested landing page view in full detail.
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
        public override stt::Task<gagvr::LandingPageView> GetLandingPageViewAsync(GetLandingPageViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLandingPageViewRequest(ref request, ref callSettings);
            return _callGetLandingPageView.Async(request, callSettings);
        }
    }
}

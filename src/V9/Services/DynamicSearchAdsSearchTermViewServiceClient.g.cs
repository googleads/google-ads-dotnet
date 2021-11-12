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
    /// <summary>Settings for <see cref="DynamicSearchAdsSearchTermViewServiceClient"/> instances.</summary>
    public sealed partial class DynamicSearchAdsSearchTermViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="DynamicSearchAdsSearchTermViewServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="DynamicSearchAdsSearchTermViewServiceSettings"/>.
        /// </returns>
        public static DynamicSearchAdsSearchTermViewServiceSettings GetDefault() =>
            new DynamicSearchAdsSearchTermViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DynamicSearchAdsSearchTermViewServiceSettings"/> object with default settings.
        /// </summary>
        public DynamicSearchAdsSearchTermViewServiceSettings()
        {
        }

        private DynamicSearchAdsSearchTermViewServiceSettings(DynamicSearchAdsSearchTermViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDynamicSearchAdsSearchTermViewSettings = existing.GetDynamicSearchAdsSearchTermViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DynamicSearchAdsSearchTermViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DynamicSearchAdsSearchTermViewServiceClient.GetDynamicSearchAdsSearchTermView</c> and
        /// <c>DynamicSearchAdsSearchTermViewServiceClient.GetDynamicSearchAdsSearchTermViewAsync</c>.
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
        public gaxgrpc::CallSettings GetDynamicSearchAdsSearchTermViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DynamicSearchAdsSearchTermViewServiceSettings"/> object.</returns>
        public DynamicSearchAdsSearchTermViewServiceSettings Clone() =>
            new DynamicSearchAdsSearchTermViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DynamicSearchAdsSearchTermViewServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class DynamicSearchAdsSearchTermViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<DynamicSearchAdsSearchTermViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DynamicSearchAdsSearchTermViewServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DynamicSearchAdsSearchTermViewServiceClientBuilder()
        {
            UseJwtAccessWithScopes = DynamicSearchAdsSearchTermViewServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref DynamicSearchAdsSearchTermViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DynamicSearchAdsSearchTermViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DynamicSearchAdsSearchTermViewServiceClient Build()
        {
            DynamicSearchAdsSearchTermViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DynamicSearchAdsSearchTermViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DynamicSearchAdsSearchTermViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DynamicSearchAdsSearchTermViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DynamicSearchAdsSearchTermViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<DynamicSearchAdsSearchTermViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DynamicSearchAdsSearchTermViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => DynamicSearchAdsSearchTermViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            DynamicSearchAdsSearchTermViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DynamicSearchAdsSearchTermViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>DynamicSearchAdsSearchTermViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch dynamic search ads views.
    /// </remarks>
    public abstract partial class DynamicSearchAdsSearchTermViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the DynamicSearchAdsSearchTermViewService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default DynamicSearchAdsSearchTermViewService scopes.</summary>
        /// <remarks>
        /// The default DynamicSearchAdsSearchTermViewService scopes are:
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
        /// Asynchronously creates a <see cref="DynamicSearchAdsSearchTermViewServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DynamicSearchAdsSearchTermViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>
        /// The task representing the created <see cref="DynamicSearchAdsSearchTermViewServiceClient"/>.
        /// </returns>
        public static stt::Task<DynamicSearchAdsSearchTermViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DynamicSearchAdsSearchTermViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DynamicSearchAdsSearchTermViewServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DynamicSearchAdsSearchTermViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DynamicSearchAdsSearchTermViewServiceClient"/>.</returns>
        public static DynamicSearchAdsSearchTermViewServiceClient Create() =>
            new DynamicSearchAdsSearchTermViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DynamicSearchAdsSearchTermViewServiceClient"/> which uses the specified call invoker
        /// for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DynamicSearchAdsSearchTermViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="DynamicSearchAdsSearchTermViewServiceClient"/>.</returns>
        internal static DynamicSearchAdsSearchTermViewServiceClient Create(grpccore::CallInvoker callInvoker, DynamicSearchAdsSearchTermViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient grpcClient = new DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient(callInvoker);
            return new DynamicSearchAdsSearchTermViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC DynamicSearchAdsSearchTermViewService client</summary>
        public virtual DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested dynamic search ads search term view in full detail.
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
        public virtual gagvr::DynamicSearchAdsSearchTermView GetDynamicSearchAdsSearchTermView(GetDynamicSearchAdsSearchTermViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested dynamic search ads search term view in full detail.
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
        public virtual stt::Task<gagvr::DynamicSearchAdsSearchTermView> GetDynamicSearchAdsSearchTermViewAsync(GetDynamicSearchAdsSearchTermViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested dynamic search ads search term view in full detail.
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
        public virtual stt::Task<gagvr::DynamicSearchAdsSearchTermView> GetDynamicSearchAdsSearchTermViewAsync(GetDynamicSearchAdsSearchTermViewRequest request, st::CancellationToken cancellationToken) =>
            GetDynamicSearchAdsSearchTermViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested dynamic search ads search term view in full detail.
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
        /// Required. The resource name of the dynamic search ads search term view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::DynamicSearchAdsSearchTermView GetDynamicSearchAdsSearchTermView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDynamicSearchAdsSearchTermView(new GetDynamicSearchAdsSearchTermViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested dynamic search ads search term view in full detail.
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
        /// Required. The resource name of the dynamic search ads search term view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DynamicSearchAdsSearchTermView> GetDynamicSearchAdsSearchTermViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDynamicSearchAdsSearchTermViewAsync(new GetDynamicSearchAdsSearchTermViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested dynamic search ads search term view in full detail.
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
        /// Required. The resource name of the dynamic search ads search term view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DynamicSearchAdsSearchTermView> GetDynamicSearchAdsSearchTermViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetDynamicSearchAdsSearchTermViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested dynamic search ads search term view in full detail.
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
        /// Required. The resource name of the dynamic search ads search term view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::DynamicSearchAdsSearchTermView GetDynamicSearchAdsSearchTermView(gagvr::DynamicSearchAdsSearchTermViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDynamicSearchAdsSearchTermView(new GetDynamicSearchAdsSearchTermViewRequest
            {
                ResourceNameAsDynamicSearchAdsSearchTermViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested dynamic search ads search term view in full detail.
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
        /// Required. The resource name of the dynamic search ads search term view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DynamicSearchAdsSearchTermView> GetDynamicSearchAdsSearchTermViewAsync(gagvr::DynamicSearchAdsSearchTermViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDynamicSearchAdsSearchTermViewAsync(new GetDynamicSearchAdsSearchTermViewRequest
            {
                ResourceNameAsDynamicSearchAdsSearchTermViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested dynamic search ads search term view in full detail.
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
        /// Required. The resource name of the dynamic search ads search term view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DynamicSearchAdsSearchTermView> GetDynamicSearchAdsSearchTermViewAsync(gagvr::DynamicSearchAdsSearchTermViewName resourceName, st::CancellationToken cancellationToken) =>
            GetDynamicSearchAdsSearchTermViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DynamicSearchAdsSearchTermViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch dynamic search ads views.
    /// </remarks>
    public sealed partial class DynamicSearchAdsSearchTermViewServiceClientImpl : DynamicSearchAdsSearchTermViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDynamicSearchAdsSearchTermViewRequest, gagvr::DynamicSearchAdsSearchTermView> _callGetDynamicSearchAdsSearchTermView;

        /// <summary>
        /// Constructs a client wrapper for the DynamicSearchAdsSearchTermViewService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DynamicSearchAdsSearchTermViewServiceSettings"/> used within this client.
        /// </param>
        public DynamicSearchAdsSearchTermViewServiceClientImpl(DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient grpcClient, DynamicSearchAdsSearchTermViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DynamicSearchAdsSearchTermViewServiceSettings effectiveSettings = settings ?? DynamicSearchAdsSearchTermViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetDynamicSearchAdsSearchTermView = clientHelper.BuildApiCall<GetDynamicSearchAdsSearchTermViewRequest, gagvr::DynamicSearchAdsSearchTermView>(grpcClient.GetDynamicSearchAdsSearchTermViewAsync, grpcClient.GetDynamicSearchAdsSearchTermView, effectiveSettings.GetDynamicSearchAdsSearchTermViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetDynamicSearchAdsSearchTermView);
            Modify_GetDynamicSearchAdsSearchTermViewApiCall(ref _callGetDynamicSearchAdsSearchTermView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDynamicSearchAdsSearchTermViewApiCall(ref gaxgrpc::ApiCall<GetDynamicSearchAdsSearchTermViewRequest, gagvr::DynamicSearchAdsSearchTermView> call);

        partial void OnConstruction(DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient grpcClient, DynamicSearchAdsSearchTermViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DynamicSearchAdsSearchTermViewService client</summary>
        public override DynamicSearchAdsSearchTermViewService.DynamicSearchAdsSearchTermViewServiceClient GrpcClient { get; }

        partial void Modify_GetDynamicSearchAdsSearchTermViewRequest(ref GetDynamicSearchAdsSearchTermViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested dynamic search ads search term view in full detail.
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
        public override gagvr::DynamicSearchAdsSearchTermView GetDynamicSearchAdsSearchTermView(GetDynamicSearchAdsSearchTermViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDynamicSearchAdsSearchTermViewRequest(ref request, ref callSettings);
            return _callGetDynamicSearchAdsSearchTermView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested dynamic search ads search term view in full detail.
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
        public override stt::Task<gagvr::DynamicSearchAdsSearchTermView> GetDynamicSearchAdsSearchTermViewAsync(GetDynamicSearchAdsSearchTermViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDynamicSearchAdsSearchTermViewRequest(ref request, ref callSettings);
            return _callGetDynamicSearchAdsSearchTermView.Async(request, callSettings);
        }
    }
}

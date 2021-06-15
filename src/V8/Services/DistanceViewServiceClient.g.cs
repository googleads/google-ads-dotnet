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

using gagvr = Google.Ads.GoogleAds.V8.Resources;
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

namespace Google.Ads.GoogleAds.V8.Services
{
    /// <summary>Settings for <see cref="DistanceViewServiceClient"/> instances.</summary>
    public sealed partial class DistanceViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DistanceViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DistanceViewServiceSettings"/>.</returns>
        public static DistanceViewServiceSettings GetDefault() => new DistanceViewServiceSettings();

        /// <summary>Constructs a new <see cref="DistanceViewServiceSettings"/> object with default settings.</summary>
        public DistanceViewServiceSettings()
        {
        }

        private DistanceViewServiceSettings(DistanceViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDistanceViewSettings = existing.GetDistanceViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DistanceViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DistanceViewServiceClient.GetDistanceView</c> and <c>DistanceViewServiceClient.GetDistanceViewAsync</c>.
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
        public gaxgrpc::CallSettings GetDistanceViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DistanceViewServiceSettings"/> object.</returns>
        public DistanceViewServiceSettings Clone() => new DistanceViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DistanceViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class DistanceViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<DistanceViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DistanceViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref DistanceViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DistanceViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DistanceViewServiceClient Build()
        {
            DistanceViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DistanceViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DistanceViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DistanceViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DistanceViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<DistanceViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DistanceViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => DistanceViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => DistanceViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DistanceViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>DistanceViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch distance views.
    /// </remarks>
    public abstract partial class DistanceViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the DistanceViewService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default DistanceViewService scopes.</summary>
        /// <remarks>
        /// The default DistanceViewService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="DistanceViewServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="DistanceViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DistanceViewServiceClient"/>.</returns>
        public static stt::Task<DistanceViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DistanceViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DistanceViewServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="DistanceViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DistanceViewServiceClient"/>.</returns>
        public static DistanceViewServiceClient Create() => new DistanceViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DistanceViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DistanceViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="DistanceViewServiceClient"/>.</returns>
        internal static DistanceViewServiceClient Create(grpccore::CallInvoker callInvoker, DistanceViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DistanceViewService.DistanceViewServiceClient grpcClient = new DistanceViewService.DistanceViewServiceClient(callInvoker);
            return new DistanceViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC DistanceViewService client</summary>
        public virtual DistanceViewService.DistanceViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the attributes of the requested distance view.
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
        public virtual gagvr::DistanceView GetDistanceView(GetDistanceViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the attributes of the requested distance view.
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
        public virtual stt::Task<gagvr::DistanceView> GetDistanceViewAsync(GetDistanceViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the attributes of the requested distance view.
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
        public virtual stt::Task<gagvr::DistanceView> GetDistanceViewAsync(GetDistanceViewRequest request, st::CancellationToken cancellationToken) =>
            GetDistanceViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the attributes of the requested distance view.
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
        /// Required. The resource name of the distance view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::DistanceView GetDistanceView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDistanceView(new GetDistanceViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the attributes of the requested distance view.
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
        /// Required. The resource name of the distance view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DistanceView> GetDistanceViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDistanceViewAsync(new GetDistanceViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the attributes of the requested distance view.
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
        /// Required. The resource name of the distance view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DistanceView> GetDistanceViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetDistanceViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the attributes of the requested distance view.
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
        /// Required. The resource name of the distance view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::DistanceView GetDistanceView(gagvr::DistanceViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDistanceView(new GetDistanceViewRequest
            {
                ResourceNameAsDistanceViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the attributes of the requested distance view.
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
        /// Required. The resource name of the distance view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DistanceView> GetDistanceViewAsync(gagvr::DistanceViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDistanceViewAsync(new GetDistanceViewRequest
            {
                ResourceNameAsDistanceViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the attributes of the requested distance view.
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
        /// Required. The resource name of the distance view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DistanceView> GetDistanceViewAsync(gagvr::DistanceViewName resourceName, st::CancellationToken cancellationToken) =>
            GetDistanceViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DistanceViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch distance views.
    /// </remarks>
    public sealed partial class DistanceViewServiceClientImpl : DistanceViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDistanceViewRequest, gagvr::DistanceView> _callGetDistanceView;

        /// <summary>
        /// Constructs a client wrapper for the DistanceViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DistanceViewServiceSettings"/> used within this client.</param>
        public DistanceViewServiceClientImpl(DistanceViewService.DistanceViewServiceClient grpcClient, DistanceViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DistanceViewServiceSettings effectiveSettings = settings ?? DistanceViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetDistanceView = clientHelper.BuildApiCall<GetDistanceViewRequest, gagvr::DistanceView>(grpcClient.GetDistanceViewAsync, grpcClient.GetDistanceView, effectiveSettings.GetDistanceViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetDistanceView);
            Modify_GetDistanceViewApiCall(ref _callGetDistanceView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDistanceViewApiCall(ref gaxgrpc::ApiCall<GetDistanceViewRequest, gagvr::DistanceView> call);

        partial void OnConstruction(DistanceViewService.DistanceViewServiceClient grpcClient, DistanceViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DistanceViewService client</summary>
        public override DistanceViewService.DistanceViewServiceClient GrpcClient { get; }

        partial void Modify_GetDistanceViewRequest(ref GetDistanceViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the attributes of the requested distance view.
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
        public override gagvr::DistanceView GetDistanceView(GetDistanceViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDistanceViewRequest(ref request, ref callSettings);
            return _callGetDistanceView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the attributes of the requested distance view.
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
        public override stt::Task<gagvr::DistanceView> GetDistanceViewAsync(GetDistanceViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDistanceViewRequest(ref request, ref callSettings);
            return _callGetDistanceView.Async(request, callSettings);
        }
    }
}

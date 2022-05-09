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
    /// <summary>Settings for <see cref="IncomeRangeViewServiceClient"/> instances.</summary>
    public sealed partial class IncomeRangeViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="IncomeRangeViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="IncomeRangeViewServiceSettings"/>.</returns>
        public static IncomeRangeViewServiceSettings GetDefault() => new IncomeRangeViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="IncomeRangeViewServiceSettings"/> object with default settings.
        /// </summary>
        public IncomeRangeViewServiceSettings()
        {
        }

        private IncomeRangeViewServiceSettings(IncomeRangeViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetIncomeRangeViewSettings = existing.GetIncomeRangeViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(IncomeRangeViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncomeRangeViewServiceClient.GetIncomeRangeView</c> and
        /// <c>IncomeRangeViewServiceClient.GetIncomeRangeViewAsync</c>.
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
        public gaxgrpc::CallSettings GetIncomeRangeViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="IncomeRangeViewServiceSettings"/> object.</returns>
        public IncomeRangeViewServiceSettings Clone() => new IncomeRangeViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IncomeRangeViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class IncomeRangeViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<IncomeRangeViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public IncomeRangeViewServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public IncomeRangeViewServiceClientBuilder()
        {
            UseJwtAccessWithScopes = IncomeRangeViewServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref IncomeRangeViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<IncomeRangeViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override IncomeRangeViewServiceClient Build()
        {
            IncomeRangeViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<IncomeRangeViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<IncomeRangeViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private IncomeRangeViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IncomeRangeViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<IncomeRangeViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IncomeRangeViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => IncomeRangeViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => IncomeRangeViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => IncomeRangeViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>IncomeRangeViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage income range views.
    /// </remarks>
    public abstract partial class IncomeRangeViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the IncomeRangeViewService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default IncomeRangeViewService scopes.</summary>
        /// <remarks>
        /// The default IncomeRangeViewService scopes are:
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
        /// Asynchronously creates a <see cref="IncomeRangeViewServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="IncomeRangeViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="IncomeRangeViewServiceClient"/>.</returns>
        public static stt::Task<IncomeRangeViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new IncomeRangeViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="IncomeRangeViewServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="IncomeRangeViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="IncomeRangeViewServiceClient"/>.</returns>
        public static IncomeRangeViewServiceClient Create() => new IncomeRangeViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="IncomeRangeViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="IncomeRangeViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="IncomeRangeViewServiceClient"/>.</returns>
        internal static IncomeRangeViewServiceClient Create(grpccore::CallInvoker callInvoker, IncomeRangeViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            IncomeRangeViewService.IncomeRangeViewServiceClient grpcClient = new IncomeRangeViewService.IncomeRangeViewServiceClient(callInvoker);
            return new IncomeRangeViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC IncomeRangeViewService client</summary>
        public virtual IncomeRangeViewService.IncomeRangeViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested income range view in full detail.
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
        public virtual gagvr::IncomeRangeView GetIncomeRangeView(GetIncomeRangeViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested income range view in full detail.
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
        public virtual stt::Task<gagvr::IncomeRangeView> GetIncomeRangeViewAsync(GetIncomeRangeViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested income range view in full detail.
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
        public virtual stt::Task<gagvr::IncomeRangeView> GetIncomeRangeViewAsync(GetIncomeRangeViewRequest request, st::CancellationToken cancellationToken) =>
            GetIncomeRangeViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested income range view in full detail.
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
        /// Required. The resource name of the income range view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::IncomeRangeView GetIncomeRangeView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetIncomeRangeView(new GetIncomeRangeViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested income range view in full detail.
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
        /// Required. The resource name of the income range view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::IncomeRangeView> GetIncomeRangeViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetIncomeRangeViewAsync(new GetIncomeRangeViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested income range view in full detail.
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
        /// Required. The resource name of the income range view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::IncomeRangeView> GetIncomeRangeViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetIncomeRangeViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested income range view in full detail.
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
        /// Required. The resource name of the income range view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::IncomeRangeView GetIncomeRangeView(gagvr::IncomeRangeViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetIncomeRangeView(new GetIncomeRangeViewRequest
            {
                ResourceNameAsIncomeRangeViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested income range view in full detail.
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
        /// Required. The resource name of the income range view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::IncomeRangeView> GetIncomeRangeViewAsync(gagvr::IncomeRangeViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetIncomeRangeViewAsync(new GetIncomeRangeViewRequest
            {
                ResourceNameAsIncomeRangeViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested income range view in full detail.
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
        /// Required. The resource name of the income range view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::IncomeRangeView> GetIncomeRangeViewAsync(gagvr::IncomeRangeViewName resourceName, st::CancellationToken cancellationToken) =>
            GetIncomeRangeViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>IncomeRangeViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage income range views.
    /// </remarks>
    public sealed partial class IncomeRangeViewServiceClientImpl : IncomeRangeViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetIncomeRangeViewRequest, gagvr::IncomeRangeView> _callGetIncomeRangeView;

        /// <summary>
        /// Constructs a client wrapper for the IncomeRangeViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="IncomeRangeViewServiceSettings"/> used within this client.
        /// </param>
        public IncomeRangeViewServiceClientImpl(IncomeRangeViewService.IncomeRangeViewServiceClient grpcClient, IncomeRangeViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            IncomeRangeViewServiceSettings effectiveSettings = settings ?? IncomeRangeViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetIncomeRangeView = clientHelper.BuildApiCall<GetIncomeRangeViewRequest, gagvr::IncomeRangeView>(grpcClient.GetIncomeRangeViewAsync, grpcClient.GetIncomeRangeView, effectiveSettings.GetIncomeRangeViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetIncomeRangeView);
            Modify_GetIncomeRangeViewApiCall(ref _callGetIncomeRangeView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetIncomeRangeViewApiCall(ref gaxgrpc::ApiCall<GetIncomeRangeViewRequest, gagvr::IncomeRangeView> call);

        partial void OnConstruction(IncomeRangeViewService.IncomeRangeViewServiceClient grpcClient, IncomeRangeViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC IncomeRangeViewService client</summary>
        public override IncomeRangeViewService.IncomeRangeViewServiceClient GrpcClient { get; }

        partial void Modify_GetIncomeRangeViewRequest(ref GetIncomeRangeViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested income range view in full detail.
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
        public override gagvr::IncomeRangeView GetIncomeRangeView(GetIncomeRangeViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIncomeRangeViewRequest(ref request, ref callSettings);
            return _callGetIncomeRangeView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested income range view in full detail.
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
        public override stt::Task<gagvr::IncomeRangeView> GetIncomeRangeViewAsync(GetIncomeRangeViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIncomeRangeViewRequest(ref request, ref callSettings);
            return _callGetIncomeRangeView.Async(request, callSettings);
        }
    }
}

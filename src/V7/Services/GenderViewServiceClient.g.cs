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
    /// <summary>Settings for <see cref="GenderViewServiceClient"/> instances.</summary>
    public sealed partial class GenderViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GenderViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GenderViewServiceSettings"/>.</returns>
        public static GenderViewServiceSettings GetDefault() => new GenderViewServiceSettings();

        /// <summary>Constructs a new <see cref="GenderViewServiceSettings"/> object with default settings.</summary>
        public GenderViewServiceSettings()
        {
        }

        private GenderViewServiceSettings(GenderViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetGenderViewSettings = existing.GetGenderViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GenderViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GenderViewServiceClient.GetGenderView</c> and <c>GenderViewServiceClient.GetGenderViewAsync</c>.
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
        public gaxgrpc::CallSettings GetGenderViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GenderViewServiceSettings"/> object.</returns>
        public GenderViewServiceSettings Clone() => new GenderViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GenderViewServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class GenderViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<GenderViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GenderViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref GenderViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GenderViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GenderViewServiceClient Build()
        {
            GenderViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GenderViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GenderViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GenderViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GenderViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<GenderViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GenderViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => GenderViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => GenderViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GenderViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>GenderViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage gender views.
    /// </remarks>
    public abstract partial class GenderViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the GenderViewService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default GenderViewService scopes.</summary>
        /// <remarks>
        /// The default GenderViewService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="GenderViewServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GenderViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GenderViewServiceClient"/>.</returns>
        public static stt::Task<GenderViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GenderViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GenderViewServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GenderViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GenderViewServiceClient"/>.</returns>
        public static GenderViewServiceClient Create() => new GenderViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GenderViewServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GenderViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="GenderViewServiceClient"/>.</returns>
        internal static GenderViewServiceClient Create(grpccore::CallInvoker callInvoker, GenderViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GenderViewService.GenderViewServiceClient grpcClient = new GenderViewService.GenderViewServiceClient(callInvoker);
            return new GenderViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC GenderViewService client</summary>
        public virtual GenderViewService.GenderViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested gender view in full detail.
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
        public virtual gagvr::GenderView GetGenderView(GetGenderViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested gender view in full detail.
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
        public virtual stt::Task<gagvr::GenderView> GetGenderViewAsync(GetGenderViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested gender view in full detail.
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
        public virtual stt::Task<gagvr::GenderView> GetGenderViewAsync(GetGenderViewRequest request, st::CancellationToken cancellationToken) =>
            GetGenderViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested gender view in full detail.
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
        /// Required. The resource name of the gender view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::GenderView GetGenderView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetGenderView(new GetGenderViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested gender view in full detail.
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
        /// Required. The resource name of the gender view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GenderView> GetGenderViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetGenderViewAsync(new GetGenderViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested gender view in full detail.
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
        /// Required. The resource name of the gender view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GenderView> GetGenderViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetGenderViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested gender view in full detail.
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
        /// Required. The resource name of the gender view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::GenderView GetGenderView(gagvr::GenderViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetGenderView(new GetGenderViewRequest
            {
                ResourceNameAsGenderViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested gender view in full detail.
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
        /// Required. The resource name of the gender view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GenderView> GetGenderViewAsync(gagvr::GenderViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetGenderViewAsync(new GetGenderViewRequest
            {
                ResourceNameAsGenderViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested gender view in full detail.
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
        /// Required. The resource name of the gender view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GenderView> GetGenderViewAsync(gagvr::GenderViewName resourceName, st::CancellationToken cancellationToken) =>
            GetGenderViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GenderViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage gender views.
    /// </remarks>
    public sealed partial class GenderViewServiceClientImpl : GenderViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetGenderViewRequest, gagvr::GenderView> _callGetGenderView;

        /// <summary>
        /// Constructs a client wrapper for the GenderViewService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GenderViewServiceSettings"/> used within this client.</param>
        public GenderViewServiceClientImpl(GenderViewService.GenderViewServiceClient grpcClient, GenderViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            GenderViewServiceSettings effectiveSettings = settings ?? GenderViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetGenderView = clientHelper.BuildApiCall<GetGenderViewRequest, gagvr::GenderView>(grpcClient.GetGenderViewAsync, grpcClient.GetGenderView, effectiveSettings.GetGenderViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetGenderView);
            Modify_GetGenderViewApiCall(ref _callGetGenderView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetGenderViewApiCall(ref gaxgrpc::ApiCall<GetGenderViewRequest, gagvr::GenderView> call);

        partial void OnConstruction(GenderViewService.GenderViewServiceClient grpcClient, GenderViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GenderViewService client</summary>
        public override GenderViewService.GenderViewServiceClient GrpcClient { get; }

        partial void Modify_GetGenderViewRequest(ref GetGenderViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested gender view in full detail.
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
        public override gagvr::GenderView GetGenderView(GetGenderViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGenderViewRequest(ref request, ref callSettings);
            return _callGetGenderView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested gender view in full detail.
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
        public override stt::Task<gagvr::GenderView> GetGenderViewAsync(GetGenderViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGenderViewRequest(ref request, ref callSettings);
            return _callGetGenderView.Async(request, callSettings);
        }
    }
}

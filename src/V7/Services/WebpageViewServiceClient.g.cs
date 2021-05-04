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
    /// <summary>Settings for <see cref="WebpageViewServiceClient"/> instances.</summary>
    public sealed partial class WebpageViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="WebpageViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="WebpageViewServiceSettings"/>.</returns>
        public static WebpageViewServiceSettings GetDefault() => new WebpageViewServiceSettings();

        /// <summary>Constructs a new <see cref="WebpageViewServiceSettings"/> object with default settings.</summary>
        public WebpageViewServiceSettings()
        {
        }

        private WebpageViewServiceSettings(WebpageViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetWebpageViewSettings = existing.GetWebpageViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(WebpageViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>WebpageViewServiceClient.GetWebpageView</c> and <c>WebpageViewServiceClient.GetWebpageViewAsync</c>.
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
        public gaxgrpc::CallSettings GetWebpageViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="WebpageViewServiceSettings"/> object.</returns>
        public WebpageViewServiceSettings Clone() => new WebpageViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="WebpageViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class WebpageViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<WebpageViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public WebpageViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref WebpageViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<WebpageViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override WebpageViewServiceClient Build()
        {
            WebpageViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<WebpageViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<WebpageViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private WebpageViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return WebpageViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<WebpageViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return WebpageViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => WebpageViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => WebpageViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => WebpageViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>WebpageViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage webpage views.
    /// </remarks>
    public abstract partial class WebpageViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the WebpageViewService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default WebpageViewService scopes.</summary>
        /// <remarks>
        /// The default WebpageViewService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="WebpageViewServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="WebpageViewServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="WebpageViewServiceClient"/>.</returns>
        public static stt::Task<WebpageViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new WebpageViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="WebpageViewServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="WebpageViewServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="WebpageViewServiceClient"/>.</returns>
        public static WebpageViewServiceClient Create() => new WebpageViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="WebpageViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="WebpageViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="WebpageViewServiceClient"/>.</returns>
        internal static WebpageViewServiceClient Create(grpccore::CallInvoker callInvoker, WebpageViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            WebpageViewService.WebpageViewServiceClient grpcClient = new WebpageViewService.WebpageViewServiceClient(callInvoker);
            return new WebpageViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC WebpageViewService client</summary>
        public virtual WebpageViewService.WebpageViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested webpage view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::WebpageView GetWebpageView(GetWebpageViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested webpage view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::WebpageView> GetWebpageViewAsync(GetWebpageViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested webpage view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::WebpageView> GetWebpageViewAsync(GetWebpageViewRequest request, st::CancellationToken cancellationToken) =>
            GetWebpageViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested webpage view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the webpage view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::WebpageView GetWebpageView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetWebpageView(new GetWebpageViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested webpage view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the webpage view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::WebpageView> GetWebpageViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetWebpageViewAsync(new GetWebpageViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested webpage view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the webpage view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::WebpageView> GetWebpageViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetWebpageViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested webpage view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the webpage view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::WebpageView GetWebpageView(gagvr::WebpageViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetWebpageView(new GetWebpageViewRequest
            {
                ResourceNameAsWebpageViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested webpage view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the webpage view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::WebpageView> GetWebpageViewAsync(gagvr::WebpageViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetWebpageViewAsync(new GetWebpageViewRequest
            {
                ResourceNameAsWebpageViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested webpage view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the webpage view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::WebpageView> GetWebpageViewAsync(gagvr::WebpageViewName resourceName, st::CancellationToken cancellationToken) =>
            GetWebpageViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>WebpageViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage webpage views.
    /// </remarks>
    public sealed partial class WebpageViewServiceClientImpl : WebpageViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetWebpageViewRequest, gagvr::WebpageView> _callGetWebpageView;

        /// <summary>
        /// Constructs a client wrapper for the WebpageViewService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="WebpageViewServiceSettings"/> used within this client.</param>
        public WebpageViewServiceClientImpl(WebpageViewService.WebpageViewServiceClient grpcClient, WebpageViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            WebpageViewServiceSettings effectiveSettings = settings ?? WebpageViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetWebpageView = clientHelper.BuildApiCall<GetWebpageViewRequest, gagvr::WebpageView>(grpcClient.GetWebpageViewAsync, grpcClient.GetWebpageView, effectiveSettings.GetWebpageViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetWebpageView);
            Modify_GetWebpageViewApiCall(ref _callGetWebpageView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetWebpageViewApiCall(ref gaxgrpc::ApiCall<GetWebpageViewRequest, gagvr::WebpageView> call);

        partial void OnConstruction(WebpageViewService.WebpageViewServiceClient grpcClient, WebpageViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC WebpageViewService client</summary>
        public override WebpageViewService.WebpageViewServiceClient GrpcClient { get; }

        partial void Modify_GetWebpageViewRequest(ref GetWebpageViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested webpage view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::WebpageView GetWebpageView(GetWebpageViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWebpageViewRequest(ref request, ref callSettings);
            return _callGetWebpageView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested webpage view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::WebpageView> GetWebpageViewAsync(GetWebpageViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWebpageViewRequest(ref request, ref callSettings);
            return _callGetWebpageView.Async(request, callSettings);
        }
    }
}

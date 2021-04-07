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

using gagvr = Google.Ads.GoogleAds.V4.Resources;
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

namespace Google.Ads.GoogleAds.V4.Services
{
    /// <summary>Settings for <see cref="FeedPlaceholderViewServiceClient"/> instances.</summary>
    public sealed partial class FeedPlaceholderViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FeedPlaceholderViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FeedPlaceholderViewServiceSettings"/>.</returns>
        public static FeedPlaceholderViewServiceSettings GetDefault() => new FeedPlaceholderViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="FeedPlaceholderViewServiceSettings"/> object with default settings.
        /// </summary>
        public FeedPlaceholderViewServiceSettings()
        {
        }

        private FeedPlaceholderViewServiceSettings(FeedPlaceholderViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetFeedPlaceholderViewSettings = existing.GetFeedPlaceholderViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FeedPlaceholderViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedPlaceholderViewServiceClient.GetFeedPlaceholderView</c> and
        /// <c>FeedPlaceholderViewServiceClient.GetFeedPlaceholderViewAsync</c>.
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
        public gaxgrpc::CallSettings GetFeedPlaceholderViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FeedPlaceholderViewServiceSettings"/> object.</returns>
        public FeedPlaceholderViewServiceSettings Clone() => new FeedPlaceholderViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FeedPlaceholderViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class FeedPlaceholderViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<FeedPlaceholderViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FeedPlaceholderViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref FeedPlaceholderViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FeedPlaceholderViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FeedPlaceholderViewServiceClient Build()
        {
            FeedPlaceholderViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FeedPlaceholderViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FeedPlaceholderViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FeedPlaceholderViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FeedPlaceholderViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<FeedPlaceholderViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FeedPlaceholderViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => FeedPlaceholderViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => FeedPlaceholderViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FeedPlaceholderViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>FeedPlaceholderViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch feed placeholder views.
    /// </remarks>
    public abstract partial class FeedPlaceholderViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the FeedPlaceholderViewService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default FeedPlaceholderViewService scopes.</summary>
        /// <remarks>
        /// The default FeedPlaceholderViewService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="FeedPlaceholderViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="FeedPlaceholderViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FeedPlaceholderViewServiceClient"/>.</returns>
        public static stt::Task<FeedPlaceholderViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FeedPlaceholderViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FeedPlaceholderViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="FeedPlaceholderViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FeedPlaceholderViewServiceClient"/>.</returns>
        public static FeedPlaceholderViewServiceClient Create() => new FeedPlaceholderViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FeedPlaceholderViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FeedPlaceholderViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="FeedPlaceholderViewServiceClient"/>.</returns>
        internal static FeedPlaceholderViewServiceClient Create(grpccore::CallInvoker callInvoker, FeedPlaceholderViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FeedPlaceholderViewService.FeedPlaceholderViewServiceClient grpcClient = new FeedPlaceholderViewService.FeedPlaceholderViewServiceClient(callInvoker);
            return new FeedPlaceholderViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC FeedPlaceholderViewService client</summary>
        public virtual FeedPlaceholderViewService.FeedPlaceholderViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::FeedPlaceholderView GetFeedPlaceholderView(GetFeedPlaceholderViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedPlaceholderView> GetFeedPlaceholderViewAsync(GetFeedPlaceholderViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedPlaceholderView> GetFeedPlaceholderViewAsync(GetFeedPlaceholderViewRequest request, st::CancellationToken cancellationToken) =>
            GetFeedPlaceholderViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed placeholder view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::FeedPlaceholderView GetFeedPlaceholderView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedPlaceholderView(new GetFeedPlaceholderViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed placeholder view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedPlaceholderView> GetFeedPlaceholderViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedPlaceholderViewAsync(new GetFeedPlaceholderViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed placeholder view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedPlaceholderView> GetFeedPlaceholderViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetFeedPlaceholderViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed placeholder view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::FeedPlaceholderView GetFeedPlaceholderView(gagvr::FeedPlaceholderViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedPlaceholderView(new GetFeedPlaceholderViewRequest
            {
                ResourceNameAsFeedPlaceholderViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed placeholder view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedPlaceholderView> GetFeedPlaceholderViewAsync(gagvr::FeedPlaceholderViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedPlaceholderViewAsync(new GetFeedPlaceholderViewRequest
            {
                ResourceNameAsFeedPlaceholderViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed placeholder view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedPlaceholderView> GetFeedPlaceholderViewAsync(gagvr::FeedPlaceholderViewName resourceName, st::CancellationToken cancellationToken) =>
            GetFeedPlaceholderViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FeedPlaceholderViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch feed placeholder views.
    /// </remarks>
    public sealed partial class FeedPlaceholderViewServiceClientImpl : FeedPlaceholderViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetFeedPlaceholderViewRequest, gagvr::FeedPlaceholderView> _callGetFeedPlaceholderView;

        /// <summary>
        /// Constructs a client wrapper for the FeedPlaceholderViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="FeedPlaceholderViewServiceSettings"/> used within this client.
        /// </param>
        public FeedPlaceholderViewServiceClientImpl(FeedPlaceholderViewService.FeedPlaceholderViewServiceClient grpcClient, FeedPlaceholderViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            FeedPlaceholderViewServiceSettings effectiveSettings = settings ?? FeedPlaceholderViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetFeedPlaceholderView = clientHelper.BuildApiCall<GetFeedPlaceholderViewRequest, gagvr::FeedPlaceholderView>(grpcClient.GetFeedPlaceholderViewAsync, grpcClient.GetFeedPlaceholderView, effectiveSettings.GetFeedPlaceholderViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetFeedPlaceholderView);
            Modify_GetFeedPlaceholderViewApiCall(ref _callGetFeedPlaceholderView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetFeedPlaceholderViewApiCall(ref gaxgrpc::ApiCall<GetFeedPlaceholderViewRequest, gagvr::FeedPlaceholderView> call);

        partial void OnConstruction(FeedPlaceholderViewService.FeedPlaceholderViewServiceClient grpcClient, FeedPlaceholderViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FeedPlaceholderViewService client</summary>
        public override FeedPlaceholderViewService.FeedPlaceholderViewServiceClient GrpcClient { get; }

        partial void Modify_GetFeedPlaceholderViewRequest(ref GetFeedPlaceholderViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::FeedPlaceholderView GetFeedPlaceholderView(GetFeedPlaceholderViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedPlaceholderViewRequest(ref request, ref callSettings);
            return _callGetFeedPlaceholderView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::FeedPlaceholderView> GetFeedPlaceholderViewAsync(GetFeedPlaceholderViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedPlaceholderViewRequest(ref request, ref callSettings);
            return _callGetFeedPlaceholderView.Async(request, callSettings);
        }
    }
}

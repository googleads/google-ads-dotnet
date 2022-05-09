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
    /// <summary>Settings for <see cref="TopicViewServiceClient"/> instances.</summary>
    public sealed partial class TopicViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TopicViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TopicViewServiceSettings"/>.</returns>
        public static TopicViewServiceSettings GetDefault() => new TopicViewServiceSettings();

        /// <summary>Constructs a new <see cref="TopicViewServiceSettings"/> object with default settings.</summary>
        public TopicViewServiceSettings()
        {
        }

        private TopicViewServiceSettings(TopicViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetTopicViewSettings = existing.GetTopicViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TopicViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TopicViewServiceClient.GetTopicView</c> and <c>TopicViewServiceClient.GetTopicViewAsync</c>.
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
        public gaxgrpc::CallSettings GetTopicViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TopicViewServiceSettings"/> object.</returns>
        public TopicViewServiceSettings Clone() => new TopicViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TopicViewServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class TopicViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<TopicViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TopicViewServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TopicViewServiceClientBuilder()
        {
            UseJwtAccessWithScopes = TopicViewServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref TopicViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TopicViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TopicViewServiceClient Build()
        {
            TopicViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TopicViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TopicViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TopicViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TopicViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<TopicViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TopicViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => TopicViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => TopicViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TopicViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>TopicViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage topic views.
    /// </remarks>
    public abstract partial class TopicViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the TopicViewService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default TopicViewService scopes.</summary>
        /// <remarks>
        /// The default TopicViewService scopes are:
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
        /// Asynchronously creates a <see cref="TopicViewServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TopicViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TopicViewServiceClient"/>.</returns>
        public static stt::Task<TopicViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TopicViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TopicViewServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TopicViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TopicViewServiceClient"/>.</returns>
        public static TopicViewServiceClient Create() => new TopicViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TopicViewServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TopicViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="TopicViewServiceClient"/>.</returns>
        internal static TopicViewServiceClient Create(grpccore::CallInvoker callInvoker, TopicViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TopicViewService.TopicViewServiceClient grpcClient = new TopicViewService.TopicViewServiceClient(callInvoker);
            return new TopicViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC TopicViewService client</summary>
        public virtual TopicViewService.TopicViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested topic view in full detail.
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
        public virtual gagvr::TopicView GetTopicView(GetTopicViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested topic view in full detail.
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
        public virtual stt::Task<gagvr::TopicView> GetTopicViewAsync(GetTopicViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested topic view in full detail.
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
        public virtual stt::Task<gagvr::TopicView> GetTopicViewAsync(GetTopicViewRequest request, st::CancellationToken cancellationToken) =>
            GetTopicViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested topic view in full detail.
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
        /// Required. The resource name of the topic view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::TopicView GetTopicView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicView(new GetTopicViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested topic view in full detail.
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
        /// Required. The resource name of the topic view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::TopicView> GetTopicViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicViewAsync(new GetTopicViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested topic view in full detail.
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
        /// Required. The resource name of the topic view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::TopicView> GetTopicViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetTopicViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested topic view in full detail.
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
        /// Required. The resource name of the topic view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::TopicView GetTopicView(gagvr::TopicViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicView(new GetTopicViewRequest
            {
                ResourceNameAsTopicViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested topic view in full detail.
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
        /// Required. The resource name of the topic view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::TopicView> GetTopicViewAsync(gagvr::TopicViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicViewAsync(new GetTopicViewRequest
            {
                ResourceNameAsTopicViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested topic view in full detail.
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
        /// Required. The resource name of the topic view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::TopicView> GetTopicViewAsync(gagvr::TopicViewName resourceName, st::CancellationToken cancellationToken) =>
            GetTopicViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TopicViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage topic views.
    /// </remarks>
    public sealed partial class TopicViewServiceClientImpl : TopicViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetTopicViewRequest, gagvr::TopicView> _callGetTopicView;

        /// <summary>
        /// Constructs a client wrapper for the TopicViewService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TopicViewServiceSettings"/> used within this client.</param>
        public TopicViewServiceClientImpl(TopicViewService.TopicViewServiceClient grpcClient, TopicViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            TopicViewServiceSettings effectiveSettings = settings ?? TopicViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetTopicView = clientHelper.BuildApiCall<GetTopicViewRequest, gagvr::TopicView>(grpcClient.GetTopicViewAsync, grpcClient.GetTopicView, effectiveSettings.GetTopicViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetTopicView);
            Modify_GetTopicViewApiCall(ref _callGetTopicView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetTopicViewApiCall(ref gaxgrpc::ApiCall<GetTopicViewRequest, gagvr::TopicView> call);

        partial void OnConstruction(TopicViewService.TopicViewServiceClient grpcClient, TopicViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TopicViewService client</summary>
        public override TopicViewService.TopicViewServiceClient GrpcClient { get; }

        partial void Modify_GetTopicViewRequest(ref GetTopicViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested topic view in full detail.
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
        public override gagvr::TopicView GetTopicView(GetTopicViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTopicViewRequest(ref request, ref callSettings);
            return _callGetTopicView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested topic view in full detail.
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
        public override stt::Task<gagvr::TopicView> GetTopicViewAsync(GetTopicViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTopicViewRequest(ref request, ref callSettings);
            return _callGetTopicView.Async(request, callSettings);
        }
    }
}

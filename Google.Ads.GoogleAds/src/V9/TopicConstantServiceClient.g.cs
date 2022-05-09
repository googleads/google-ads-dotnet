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
    /// <summary>Settings for <see cref="TopicConstantServiceClient"/> instances.</summary>
    public sealed partial class TopicConstantServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TopicConstantServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TopicConstantServiceSettings"/>.</returns>
        public static TopicConstantServiceSettings GetDefault() => new TopicConstantServiceSettings();

        /// <summary>Constructs a new <see cref="TopicConstantServiceSettings"/> object with default settings.</summary>
        public TopicConstantServiceSettings()
        {
        }

        private TopicConstantServiceSettings(TopicConstantServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetTopicConstantSettings = existing.GetTopicConstantSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TopicConstantServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TopicConstantServiceClient.GetTopicConstant</c> and <c>TopicConstantServiceClient.GetTopicConstantAsync</c>
        /// .
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
        public gaxgrpc::CallSettings GetTopicConstantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TopicConstantServiceSettings"/> object.</returns>
        public TopicConstantServiceSettings Clone() => new TopicConstantServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TopicConstantServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class TopicConstantServiceClientBuilder : gaxgrpc::ClientBuilderBase<TopicConstantServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TopicConstantServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TopicConstantServiceClientBuilder()
        {
            UseJwtAccessWithScopes = TopicConstantServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref TopicConstantServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TopicConstantServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TopicConstantServiceClient Build()
        {
            TopicConstantServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TopicConstantServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TopicConstantServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TopicConstantServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TopicConstantServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<TopicConstantServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TopicConstantServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => TopicConstantServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => TopicConstantServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TopicConstantServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>TopicConstantService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch topic constants.
    /// </remarks>
    public abstract partial class TopicConstantServiceClient
    {
        /// <summary>
        /// The default endpoint for the TopicConstantService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default TopicConstantService scopes.</summary>
        /// <remarks>
        /// The default TopicConstantService scopes are:
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
        /// Asynchronously creates a <see cref="TopicConstantServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="TopicConstantServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TopicConstantServiceClient"/>.</returns>
        public static stt::Task<TopicConstantServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TopicConstantServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TopicConstantServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="TopicConstantServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TopicConstantServiceClient"/>.</returns>
        public static TopicConstantServiceClient Create() => new TopicConstantServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TopicConstantServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TopicConstantServiceSettings"/>.</param>
        /// <returns>The created <see cref="TopicConstantServiceClient"/>.</returns>
        internal static TopicConstantServiceClient Create(grpccore::CallInvoker callInvoker, TopicConstantServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TopicConstantService.TopicConstantServiceClient grpcClient = new TopicConstantService.TopicConstantServiceClient(callInvoker);
            return new TopicConstantServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC TopicConstantService client</summary>
        public virtual TopicConstantService.TopicConstantServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested topic constant in full detail.
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
        public virtual gagvr::TopicConstant GetTopicConstant(GetTopicConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested topic constant in full detail.
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
        public virtual stt::Task<gagvr::TopicConstant> GetTopicConstantAsync(GetTopicConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested topic constant in full detail.
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
        public virtual stt::Task<gagvr::TopicConstant> GetTopicConstantAsync(GetTopicConstantRequest request, st::CancellationToken cancellationToken) =>
            GetTopicConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested topic constant in full detail.
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
        /// Required. Resource name of the Topic to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::TopicConstant GetTopicConstant(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicConstant(new GetTopicConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested topic constant in full detail.
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
        /// Required. Resource name of the Topic to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::TopicConstant> GetTopicConstantAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicConstantAsync(new GetTopicConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested topic constant in full detail.
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
        /// Required. Resource name of the Topic to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::TopicConstant> GetTopicConstantAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetTopicConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested topic constant in full detail.
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
        /// Required. Resource name of the Topic to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::TopicConstant GetTopicConstant(gagvr::TopicConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicConstant(new GetTopicConstantRequest
            {
                ResourceNameAsTopicConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested topic constant in full detail.
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
        /// Required. Resource name of the Topic to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::TopicConstant> GetTopicConstantAsync(gagvr::TopicConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicConstantAsync(new GetTopicConstantRequest
            {
                ResourceNameAsTopicConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested topic constant in full detail.
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
        /// Required. Resource name of the Topic to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::TopicConstant> GetTopicConstantAsync(gagvr::TopicConstantName resourceName, st::CancellationToken cancellationToken) =>
            GetTopicConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TopicConstantService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch topic constants.
    /// </remarks>
    public sealed partial class TopicConstantServiceClientImpl : TopicConstantServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetTopicConstantRequest, gagvr::TopicConstant> _callGetTopicConstant;

        /// <summary>
        /// Constructs a client wrapper for the TopicConstantService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TopicConstantServiceSettings"/> used within this client.</param>
        public TopicConstantServiceClientImpl(TopicConstantService.TopicConstantServiceClient grpcClient, TopicConstantServiceSettings settings)
        {
            GrpcClient = grpcClient;
            TopicConstantServiceSettings effectiveSettings = settings ?? TopicConstantServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetTopicConstant = clientHelper.BuildApiCall<GetTopicConstantRequest, gagvr::TopicConstant>(grpcClient.GetTopicConstantAsync, grpcClient.GetTopicConstant, effectiveSettings.GetTopicConstantSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetTopicConstant);
            Modify_GetTopicConstantApiCall(ref _callGetTopicConstant);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetTopicConstantApiCall(ref gaxgrpc::ApiCall<GetTopicConstantRequest, gagvr::TopicConstant> call);

        partial void OnConstruction(TopicConstantService.TopicConstantServiceClient grpcClient, TopicConstantServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TopicConstantService client</summary>
        public override TopicConstantService.TopicConstantServiceClient GrpcClient { get; }

        partial void Modify_GetTopicConstantRequest(ref GetTopicConstantRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested topic constant in full detail.
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
        public override gagvr::TopicConstant GetTopicConstant(GetTopicConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTopicConstantRequest(ref request, ref callSettings);
            return _callGetTopicConstant.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested topic constant in full detail.
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
        public override stt::Task<gagvr::TopicConstant> GetTopicConstantAsync(GetTopicConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTopicConstantRequest(ref request, ref callSettings);
            return _callGetTopicConstant.Async(request, callSettings);
        }
    }
}

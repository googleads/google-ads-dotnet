// Copyright 2022 Google LLC
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

namespace Google.Ads.GoogleAds.V10.Services
{
    /// <summary>Settings for <see cref="FeedItemSetLinkServiceClient"/> instances.</summary>
    public sealed partial class FeedItemSetLinkServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FeedItemSetLinkServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FeedItemSetLinkServiceSettings"/>.</returns>
        public static FeedItemSetLinkServiceSettings GetDefault() => new FeedItemSetLinkServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="FeedItemSetLinkServiceSettings"/> object with default settings.
        /// </summary>
        public FeedItemSetLinkServiceSettings()
        {
        }

        private FeedItemSetLinkServiceSettings(FeedItemSetLinkServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateFeedItemSetLinksSettings = existing.MutateFeedItemSetLinksSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FeedItemSetLinkServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedItemSetLinkServiceClient.MutateFeedItemSetLinks</c> and
        /// <c>FeedItemSetLinkServiceClient.MutateFeedItemSetLinksAsync</c>.
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
        public gaxgrpc::CallSettings MutateFeedItemSetLinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FeedItemSetLinkServiceSettings"/> object.</returns>
        public FeedItemSetLinkServiceSettings Clone() => new FeedItemSetLinkServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FeedItemSetLinkServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class FeedItemSetLinkServiceClientBuilder : gaxgrpc::ClientBuilderBase<FeedItemSetLinkServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FeedItemSetLinkServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FeedItemSetLinkServiceClientBuilder()
        {
            UseJwtAccessWithScopes = FeedItemSetLinkServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref FeedItemSetLinkServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FeedItemSetLinkServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FeedItemSetLinkServiceClient Build()
        {
            FeedItemSetLinkServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FeedItemSetLinkServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FeedItemSetLinkServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FeedItemSetLinkServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FeedItemSetLinkServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<FeedItemSetLinkServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FeedItemSetLinkServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => FeedItemSetLinkServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => FeedItemSetLinkServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FeedItemSetLinkServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>FeedItemSetLinkService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage feed item set links.
    /// </remarks>
    public abstract partial class FeedItemSetLinkServiceClient
    {
        /// <summary>
        /// The default endpoint for the FeedItemSetLinkService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default FeedItemSetLinkService scopes.</summary>
        /// <remarks>
        /// The default FeedItemSetLinkService scopes are:
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
        /// Asynchronously creates a <see cref="FeedItemSetLinkServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="FeedItemSetLinkServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FeedItemSetLinkServiceClient"/>.</returns>
        public static stt::Task<FeedItemSetLinkServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FeedItemSetLinkServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FeedItemSetLinkServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="FeedItemSetLinkServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FeedItemSetLinkServiceClient"/>.</returns>
        public static FeedItemSetLinkServiceClient Create() => new FeedItemSetLinkServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FeedItemSetLinkServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FeedItemSetLinkServiceSettings"/>.</param>
        /// <returns>The created <see cref="FeedItemSetLinkServiceClient"/>.</returns>
        internal static FeedItemSetLinkServiceClient Create(grpccore::CallInvoker callInvoker, FeedItemSetLinkServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FeedItemSetLinkService.FeedItemSetLinkServiceClient grpcClient = new FeedItemSetLinkService.FeedItemSetLinkServiceClient(callInvoker);
            return new FeedItemSetLinkServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC FeedItemSetLinkService client</summary>
        public virtual FeedItemSetLinkService.FeedItemSetLinkServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes feed item set links.
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
        public virtual MutateFeedItemSetLinksResponse MutateFeedItemSetLinks(MutateFeedItemSetLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes feed item set links.
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
        public virtual stt::Task<MutateFeedItemSetLinksResponse> MutateFeedItemSetLinksAsync(MutateFeedItemSetLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes feed item set links.
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
        public virtual stt::Task<MutateFeedItemSetLinksResponse> MutateFeedItemSetLinksAsync(MutateFeedItemSetLinksRequest request, st::CancellationToken cancellationToken) =>
            MutateFeedItemSetLinksAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes feed item set links.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose feed item set links are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feed item set links.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateFeedItemSetLinksResponse MutateFeedItemSetLinks(string customerId, scg::IEnumerable<FeedItemSetLinkOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateFeedItemSetLinks(new MutateFeedItemSetLinksRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes feed item set links.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose feed item set links are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feed item set links.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedItemSetLinksResponse> MutateFeedItemSetLinksAsync(string customerId, scg::IEnumerable<FeedItemSetLinkOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateFeedItemSetLinksAsync(new MutateFeedItemSetLinksRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes feed item set links.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose feed item set links are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feed item set links.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedItemSetLinksResponse> MutateFeedItemSetLinksAsync(string customerId, scg::IEnumerable<FeedItemSetLinkOperation> operations, st::CancellationToken cancellationToken) =>
            MutateFeedItemSetLinksAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FeedItemSetLinkService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage feed item set links.
    /// </remarks>
    public sealed partial class FeedItemSetLinkServiceClientImpl : FeedItemSetLinkServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateFeedItemSetLinksRequest, MutateFeedItemSetLinksResponse> _callMutateFeedItemSetLinks;

        /// <summary>
        /// Constructs a client wrapper for the FeedItemSetLinkService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="FeedItemSetLinkServiceSettings"/> used within this client.
        /// </param>
        public FeedItemSetLinkServiceClientImpl(FeedItemSetLinkService.FeedItemSetLinkServiceClient grpcClient, FeedItemSetLinkServiceSettings settings)
        {
            GrpcClient = grpcClient;
            FeedItemSetLinkServiceSettings effectiveSettings = settings ?? FeedItemSetLinkServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callMutateFeedItemSetLinks = clientHelper.BuildApiCall<MutateFeedItemSetLinksRequest, MutateFeedItemSetLinksResponse>(grpcClient.MutateFeedItemSetLinksAsync, grpcClient.MutateFeedItemSetLinks, effectiveSettings.MutateFeedItemSetLinksSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateFeedItemSetLinks);
            Modify_MutateFeedItemSetLinksApiCall(ref _callMutateFeedItemSetLinks);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateFeedItemSetLinksApiCall(ref gaxgrpc::ApiCall<MutateFeedItemSetLinksRequest, MutateFeedItemSetLinksResponse> call);

        partial void OnConstruction(FeedItemSetLinkService.FeedItemSetLinkServiceClient grpcClient, FeedItemSetLinkServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FeedItemSetLinkService client</summary>
        public override FeedItemSetLinkService.FeedItemSetLinkServiceClient GrpcClient { get; }

        partial void Modify_MutateFeedItemSetLinksRequest(ref MutateFeedItemSetLinksRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes feed item set links.
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
        public override MutateFeedItemSetLinksResponse MutateFeedItemSetLinks(MutateFeedItemSetLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateFeedItemSetLinksRequest(ref request, ref callSettings);
            return _callMutateFeedItemSetLinks.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes feed item set links.
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
        public override stt::Task<MutateFeedItemSetLinksResponse> MutateFeedItemSetLinksAsync(MutateFeedItemSetLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateFeedItemSetLinksRequest(ref request, ref callSettings);
            return _callMutateFeedItemSetLinks.Async(request, callSettings);
        }
    }
}

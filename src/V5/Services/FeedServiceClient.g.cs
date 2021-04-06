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

using gagvr = Google.Ads.GoogleAds.V5.Resources;
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

namespace Google.Ads.GoogleAds.V5.Services
{
    /// <summary>Settings for <see cref="FeedServiceClient"/> instances.</summary>
    public sealed partial class FeedServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FeedServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FeedServiceSettings"/>.</returns>
        public static FeedServiceSettings GetDefault() => new FeedServiceSettings();

        /// <summary>Constructs a new <see cref="FeedServiceSettings"/> object with default settings.</summary>
        public FeedServiceSettings()
        {
        }

        private FeedServiceSettings(FeedServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetFeedSettings = existing.GetFeedSettings;
            MutateFeedsSettings = existing.MutateFeedsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FeedServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>FeedServiceClient.GetFeed</c>
        ///  and <c>FeedServiceClient.GetFeedAsync</c>.
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
        public gaxgrpc::CallSettings GetFeedSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedServiceClient.MutateFeeds</c> and <c>FeedServiceClient.MutateFeedsAsync</c>.
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
        public gaxgrpc::CallSettings MutateFeedsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FeedServiceSettings"/> object.</returns>
        public FeedServiceSettings Clone() => new FeedServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FeedServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    internal sealed partial class FeedServiceClientBuilder : gaxgrpc::ClientBuilderBase<FeedServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FeedServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref FeedServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FeedServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FeedServiceClient Build()
        {
            FeedServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FeedServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FeedServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FeedServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FeedServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<FeedServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FeedServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => FeedServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => FeedServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FeedServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>FeedService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage feeds.
    /// </remarks>
    public abstract partial class FeedServiceClient
    {
        /// <summary>
        /// The default endpoint for the FeedService service, which is a host of "googleads.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default FeedService scopes.</summary>
        /// <remarks>
        /// The default FeedService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="FeedServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FeedServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FeedServiceClient"/>.</returns>
        public static stt::Task<FeedServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FeedServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FeedServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FeedServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FeedServiceClient"/>.</returns>
        public static FeedServiceClient Create() => new FeedServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FeedServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FeedServiceSettings"/>.</param>
        /// <returns>The created <see cref="FeedServiceClient"/>.</returns>
        internal static FeedServiceClient Create(grpccore::CallInvoker callInvoker, FeedServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FeedService.FeedServiceClient grpcClient = new FeedService.FeedServiceClient(callInvoker);
            return new FeedServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC FeedService client</summary>
        public virtual FeedService.FeedServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::Feed GetFeed(GetFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Feed> GetFeedAsync(GetFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Feed> GetFeedAsync(GetFeedRequest request, st::CancellationToken cancellationToken) =>
            GetFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::Feed GetFeed(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeed(new GetFeedRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Feed> GetFeedAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedAsync(new GetFeedRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Feed> GetFeedAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetFeedAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::Feed GetFeed(gagvr::FeedName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeed(new GetFeedRequest
            {
                ResourceNameAsFeedName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Feed> GetFeedAsync(gagvr::FeedName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedAsync(new GetFeedRequest
            {
                ResourceNameAsFeedName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Feed> GetFeedAsync(gagvr::FeedName resourceName, st::CancellationToken cancellationToken) =>
            GetFeedAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateFeedsResponse MutateFeeds(MutateFeedsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedsResponse> MutateFeedsAsync(MutateFeedsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedsResponse> MutateFeedsAsync(MutateFeedsRequest request, st::CancellationToken cancellationToken) =>
            MutateFeedsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose feeds are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feeds.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateFeedsResponse MutateFeeds(string customerId, scg::IEnumerable<FeedOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateFeeds(new MutateFeedsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose feeds are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feeds.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedsResponse> MutateFeedsAsync(string customerId, scg::IEnumerable<FeedOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateFeedsAsync(new MutateFeedsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose feeds are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feeds.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedsResponse> MutateFeedsAsync(string customerId, scg::IEnumerable<FeedOperation> operations, st::CancellationToken cancellationToken) =>
            MutateFeedsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FeedService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage feeds.
    /// </remarks>
    public sealed partial class FeedServiceClientImpl : FeedServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetFeedRequest, gagvr::Feed> _callGetFeed;

        private readonly gaxgrpc::ApiCall<MutateFeedsRequest, MutateFeedsResponse> _callMutateFeeds;

        /// <summary>
        /// Constructs a client wrapper for the FeedService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FeedServiceSettings"/> used within this client.</param>
        public FeedServiceClientImpl(FeedService.FeedServiceClient grpcClient, FeedServiceSettings settings)
        {
            GrpcClient = grpcClient;
            FeedServiceSettings effectiveSettings = settings ?? FeedServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetFeed = clientHelper.BuildApiCall<GetFeedRequest, gagvr::Feed>(grpcClient.GetFeedAsync, grpcClient.GetFeed, effectiveSettings.GetFeedSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetFeed);
            Modify_GetFeedApiCall(ref _callGetFeed);
            _callMutateFeeds = clientHelper.BuildApiCall<MutateFeedsRequest, MutateFeedsResponse>(grpcClient.MutateFeedsAsync, grpcClient.MutateFeeds, effectiveSettings.MutateFeedsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateFeeds);
            Modify_MutateFeedsApiCall(ref _callMutateFeeds);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetFeedApiCall(ref gaxgrpc::ApiCall<GetFeedRequest, gagvr::Feed> call);

        partial void Modify_MutateFeedsApiCall(ref gaxgrpc::ApiCall<MutateFeedsRequest, MutateFeedsResponse> call);

        partial void OnConstruction(FeedService.FeedServiceClient grpcClient, FeedServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FeedService client</summary>
        public override FeedService.FeedServiceClient GrpcClient { get; }

        partial void Modify_GetFeedRequest(ref GetFeedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateFeedsRequest(ref MutateFeedsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::Feed GetFeed(GetFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedRequest(ref request, ref callSettings);
            return _callGetFeed.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::Feed> GetFeedAsync(GetFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedRequest(ref request, ref callSettings);
            return _callGetFeed.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateFeedsResponse MutateFeeds(MutateFeedsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateFeedsRequest(ref request, ref callSettings);
            return _callMutateFeeds.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateFeedsResponse> MutateFeedsAsync(MutateFeedsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateFeedsRequest(ref request, ref callSettings);
            return _callMutateFeeds.Async(request, callSettings);
        }
    }
}

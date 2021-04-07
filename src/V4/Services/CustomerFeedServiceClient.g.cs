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
    /// <summary>Settings for <see cref="CustomerFeedServiceClient"/> instances.</summary>
    public sealed partial class CustomerFeedServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomerFeedServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomerFeedServiceSettings"/>.</returns>
        public static CustomerFeedServiceSettings GetDefault() => new CustomerFeedServiceSettings();

        /// <summary>Constructs a new <see cref="CustomerFeedServiceSettings"/> object with default settings.</summary>
        public CustomerFeedServiceSettings()
        {
        }

        private CustomerFeedServiceSettings(CustomerFeedServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCustomerFeedSettings = existing.GetCustomerFeedSettings;
            MutateCustomerFeedsSettings = existing.MutateCustomerFeedsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerFeedServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerFeedServiceClient.GetCustomerFeed</c> and <c>CustomerFeedServiceClient.GetCustomerFeedAsync</c>.
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
        public gaxgrpc::CallSettings GetCustomerFeedSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerFeedServiceClient.MutateCustomerFeeds</c> and
        /// <c>CustomerFeedServiceClient.MutateCustomerFeedsAsync</c>.
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
        public gaxgrpc::CallSettings MutateCustomerFeedsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomerFeedServiceSettings"/> object.</returns>
        public CustomerFeedServiceSettings Clone() => new CustomerFeedServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerFeedServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CustomerFeedServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerFeedServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomerFeedServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CustomerFeedServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomerFeedServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomerFeedServiceClient Build()
        {
            CustomerFeedServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomerFeedServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomerFeedServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomerFeedServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerFeedServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CustomerFeedServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerFeedServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CustomerFeedServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CustomerFeedServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerFeedServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CustomerFeedService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer feeds.
    /// </remarks>
    public abstract partial class CustomerFeedServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerFeedService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomerFeedService scopes.</summary>
        /// <remarks>
        /// The default CustomerFeedService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerFeedServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerFeedServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomerFeedServiceClient"/>.</returns>
        public static stt::Task<CustomerFeedServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomerFeedServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomerFeedServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerFeedServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomerFeedServiceClient"/>.</returns>
        public static CustomerFeedServiceClient Create() => new CustomerFeedServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomerFeedServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomerFeedServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerFeedServiceClient"/>.</returns>
        internal static CustomerFeedServiceClient Create(grpccore::CallInvoker callInvoker, CustomerFeedServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerFeedService.CustomerFeedServiceClient grpcClient = new CustomerFeedService.CustomerFeedServiceClient(callInvoker);
            return new CustomerFeedServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CustomerFeedService client</summary>
        public virtual CustomerFeedService.CustomerFeedServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested customer feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerFeed GetCustomerFeed(GetCustomerFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested customer feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerFeed> GetCustomerFeedAsync(GetCustomerFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested customer feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerFeed> GetCustomerFeedAsync(GetCustomerFeedRequest request, st::CancellationToken cancellationToken) =>
            GetCustomerFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested customer feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer feed to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerFeed GetCustomerFeed(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerFeed(new GetCustomerFeedRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested customer feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer feed to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerFeed> GetCustomerFeedAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerFeedAsync(new GetCustomerFeedRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested customer feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer feed to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerFeed> GetCustomerFeedAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCustomerFeedAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested customer feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer feed to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerFeed GetCustomerFeed(gagvr::CustomerFeedName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerFeed(new GetCustomerFeedRequest
            {
                ResourceNameAsCustomerFeedName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested customer feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer feed to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerFeed> GetCustomerFeedAsync(gagvr::CustomerFeedName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerFeedAsync(new GetCustomerFeedRequest
            {
                ResourceNameAsCustomerFeedName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested customer feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer feed to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerFeed> GetCustomerFeedAsync(gagvr::CustomerFeedName resourceName, st::CancellationToken cancellationToken) =>
            GetCustomerFeedAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes customer feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerFeedsResponse MutateCustomerFeeds(MutateCustomerFeedsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes customer feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerFeedsResponse> MutateCustomerFeedsAsync(MutateCustomerFeedsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes customer feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerFeedsResponse> MutateCustomerFeedsAsync(MutateCustomerFeedsRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomerFeedsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes customer feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer feeds are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer feeds.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerFeedsResponse MutateCustomerFeeds(string customerId, scg::IEnumerable<CustomerFeedOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerFeeds(new MutateCustomerFeedsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes customer feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer feeds are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer feeds.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerFeedsResponse> MutateCustomerFeedsAsync(string customerId, scg::IEnumerable<CustomerFeedOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerFeedsAsync(new MutateCustomerFeedsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes customer feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer feeds are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer feeds.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerFeedsResponse> MutateCustomerFeedsAsync(string customerId, scg::IEnumerable<CustomerFeedOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCustomerFeedsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomerFeedService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer feeds.
    /// </remarks>
    public sealed partial class CustomerFeedServiceClientImpl : CustomerFeedServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCustomerFeedRequest, gagvr::CustomerFeed> _callGetCustomerFeed;

        private readonly gaxgrpc::ApiCall<MutateCustomerFeedsRequest, MutateCustomerFeedsResponse> _callMutateCustomerFeeds;

        /// <summary>
        /// Constructs a client wrapper for the CustomerFeedService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CustomerFeedServiceSettings"/> used within this client.</param>
        public CustomerFeedServiceClientImpl(CustomerFeedService.CustomerFeedServiceClient grpcClient, CustomerFeedServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CustomerFeedServiceSettings effectiveSettings = settings ?? CustomerFeedServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCustomerFeed = clientHelper.BuildApiCall<GetCustomerFeedRequest, gagvr::CustomerFeed>(grpcClient.GetCustomerFeedAsync, grpcClient.GetCustomerFeed, effectiveSettings.GetCustomerFeedSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCustomerFeed);
            Modify_GetCustomerFeedApiCall(ref _callGetCustomerFeed);
            _callMutateCustomerFeeds = clientHelper.BuildApiCall<MutateCustomerFeedsRequest, MutateCustomerFeedsResponse>(grpcClient.MutateCustomerFeedsAsync, grpcClient.MutateCustomerFeeds, effectiveSettings.MutateCustomerFeedsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomerFeeds);
            Modify_MutateCustomerFeedsApiCall(ref _callMutateCustomerFeeds);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCustomerFeedApiCall(ref gaxgrpc::ApiCall<GetCustomerFeedRequest, gagvr::CustomerFeed> call);

        partial void Modify_MutateCustomerFeedsApiCall(ref gaxgrpc::ApiCall<MutateCustomerFeedsRequest, MutateCustomerFeedsResponse> call);

        partial void OnConstruction(CustomerFeedService.CustomerFeedServiceClient grpcClient, CustomerFeedServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomerFeedService client</summary>
        public override CustomerFeedService.CustomerFeedServiceClient GrpcClient { get; }

        partial void Modify_GetCustomerFeedRequest(ref GetCustomerFeedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateCustomerFeedsRequest(ref MutateCustomerFeedsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested customer feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::CustomerFeed GetCustomerFeed(GetCustomerFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerFeedRequest(ref request, ref callSettings);
            return _callGetCustomerFeed.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested customer feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CustomerFeed> GetCustomerFeedAsync(GetCustomerFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerFeedRequest(ref request, ref callSettings);
            return _callGetCustomerFeed.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes customer feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCustomerFeedsResponse MutateCustomerFeeds(MutateCustomerFeedsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerFeedsRequest(ref request, ref callSettings);
            return _callMutateCustomerFeeds.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes customer feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCustomerFeedsResponse> MutateCustomerFeedsAsync(MutateCustomerFeedsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerFeedsRequest(ref request, ref callSettings);
            return _callMutateCustomerFeeds.Async(request, callSettings);
        }
    }
}

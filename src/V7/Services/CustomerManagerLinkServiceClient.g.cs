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
    /// <summary>Settings for <see cref="CustomerManagerLinkServiceClient"/> instances.</summary>
    public sealed partial class CustomerManagerLinkServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomerManagerLinkServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomerManagerLinkServiceSettings"/>.</returns>
        public static CustomerManagerLinkServiceSettings GetDefault() => new CustomerManagerLinkServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomerManagerLinkServiceSettings"/> object with default settings.
        /// </summary>
        public CustomerManagerLinkServiceSettings()
        {
        }

        private CustomerManagerLinkServiceSettings(CustomerManagerLinkServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCustomerManagerLinkSettings = existing.GetCustomerManagerLinkSettings;
            MutateCustomerManagerLinkSettings = existing.MutateCustomerManagerLinkSettings;
            MoveManagerLinkSettings = existing.MoveManagerLinkSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerManagerLinkServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerManagerLinkServiceClient.GetCustomerManagerLink</c> and
        /// <c>CustomerManagerLinkServiceClient.GetCustomerManagerLinkAsync</c>.
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
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomerManagerLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerManagerLinkServiceClient.MutateCustomerManagerLink</c> and
        /// <c>CustomerManagerLinkServiceClient.MutateCustomerManagerLinkAsync</c>.
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
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateCustomerManagerLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerManagerLinkServiceClient.MoveManagerLink</c> and
        /// <c>CustomerManagerLinkServiceClient.MoveManagerLinkAsync</c>.
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
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MoveManagerLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomerManagerLinkServiceSettings"/> object.</returns>
        public CustomerManagerLinkServiceSettings Clone() => new CustomerManagerLinkServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerManagerLinkServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CustomerManagerLinkServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerManagerLinkServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomerManagerLinkServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CustomerManagerLinkServiceClientBuilder()
        {
            UseJwtAccessWithScopes = CustomerManagerLinkServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref CustomerManagerLinkServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomerManagerLinkServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomerManagerLinkServiceClient Build()
        {
            CustomerManagerLinkServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomerManagerLinkServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomerManagerLinkServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomerManagerLinkServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerManagerLinkServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CustomerManagerLinkServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerManagerLinkServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CustomerManagerLinkServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CustomerManagerLinkServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerManagerLinkServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CustomerManagerLinkService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer-manager links.
    /// </remarks>
    public abstract partial class CustomerManagerLinkServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerManagerLinkService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomerManagerLinkService scopes.</summary>
        /// <remarks>
        /// The default CustomerManagerLinkService scopes are:
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
        /// Asynchronously creates a <see cref="CustomerManagerLinkServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerManagerLinkServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomerManagerLinkServiceClient"/>.</returns>
        public static stt::Task<CustomerManagerLinkServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomerManagerLinkServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomerManagerLinkServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerManagerLinkServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomerManagerLinkServiceClient"/>.</returns>
        public static CustomerManagerLinkServiceClient Create() => new CustomerManagerLinkServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomerManagerLinkServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomerManagerLinkServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerManagerLinkServiceClient"/>.</returns>
        internal static CustomerManagerLinkServiceClient Create(grpccore::CallInvoker callInvoker, CustomerManagerLinkServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerManagerLinkService.CustomerManagerLinkServiceClient grpcClient = new CustomerManagerLinkService.CustomerManagerLinkServiceClient(callInvoker);
            return new CustomerManagerLinkServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CustomerManagerLinkService client</summary>
        public virtual CustomerManagerLinkService.CustomerManagerLinkServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
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
        public virtual gagvr::CustomerManagerLink GetCustomerManagerLink(GetCustomerManagerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
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
        public virtual stt::Task<gagvr::CustomerManagerLink> GetCustomerManagerLinkAsync(GetCustomerManagerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
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
        public virtual stt::Task<gagvr::CustomerManagerLink> GetCustomerManagerLinkAsync(GetCustomerManagerLinkRequest request, st::CancellationToken cancellationToken) =>
            GetCustomerManagerLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
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
        /// Required. The resource name of the CustomerManagerLink to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerManagerLink GetCustomerManagerLink(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerManagerLink(new GetCustomerManagerLinkRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
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
        /// Required. The resource name of the CustomerManagerLink to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerManagerLink> GetCustomerManagerLinkAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerManagerLinkAsync(new GetCustomerManagerLinkRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
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
        /// Required. The resource name of the CustomerManagerLink to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerManagerLink> GetCustomerManagerLinkAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCustomerManagerLinkAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
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
        /// Required. The resource name of the CustomerManagerLink to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerManagerLink GetCustomerManagerLink(gagvr::CustomerManagerLinkName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerManagerLink(new GetCustomerManagerLinkRequest
            {
                ResourceNameAsCustomerManagerLinkName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
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
        /// Required. The resource name of the CustomerManagerLink to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerManagerLink> GetCustomerManagerLinkAsync(gagvr::CustomerManagerLinkName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerManagerLinkAsync(new GetCustomerManagerLinkRequest
            {
                ResourceNameAsCustomerManagerLinkName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
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
        /// Required. The resource name of the CustomerManagerLink to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerManagerLink> GetCustomerManagerLinkAsync(gagvr::CustomerManagerLinkName resourceName, st::CancellationToken cancellationToken) =>
            GetCustomerManagerLinkAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates customer manager links. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [ManagerLinkError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerManagerLinkResponse MutateCustomerManagerLink(MutateCustomerManagerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates customer manager links. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [ManagerLinkError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerManagerLinkResponse> MutateCustomerManagerLinkAsync(MutateCustomerManagerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates customer manager links. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [ManagerLinkError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerManagerLinkResponse> MutateCustomerManagerLinkAsync(MutateCustomerManagerLinkRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomerManagerLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates customer manager links. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [ManagerLinkError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer manager links are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer manager links.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerManagerLinkResponse MutateCustomerManagerLink(string customerId, scg::IEnumerable<CustomerManagerLinkOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerManagerLink(new MutateCustomerManagerLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or updates customer manager links. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [ManagerLinkError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer manager links are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer manager links.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerManagerLinkResponse> MutateCustomerManagerLinkAsync(string customerId, scg::IEnumerable<CustomerManagerLinkOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerManagerLinkAsync(new MutateCustomerManagerLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or updates customer manager links. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [ManagerLinkError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer manager links are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer manager links.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerManagerLinkResponse> MutateCustomerManagerLinkAsync(string customerId, scg::IEnumerable<CustomerManagerLinkOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCustomerManagerLinkAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves a client customer to a new manager customer.
        /// This simplifies the complex request that requires two operations to move
        /// a client customer to a new manager. i.e:
        /// 1. Update operation with Status INACTIVE (previous manager) and,
        /// 2. Update operation with Status ACTIVE (new manager).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MoveManagerLinkResponse MoveManagerLink(MoveManagerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves a client customer to a new manager customer.
        /// This simplifies the complex request that requires two operations to move
        /// a client customer to a new manager. i.e:
        /// 1. Update operation with Status INACTIVE (previous manager) and,
        /// 2. Update operation with Status ACTIVE (new manager).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MoveManagerLinkResponse> MoveManagerLinkAsync(MoveManagerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves a client customer to a new manager customer.
        /// This simplifies the complex request that requires two operations to move
        /// a client customer to a new manager. i.e:
        /// 1. Update operation with Status INACTIVE (previous manager) and,
        /// 2. Update operation with Status ACTIVE (new manager).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MoveManagerLinkResponse> MoveManagerLinkAsync(MoveManagerLinkRequest request, st::CancellationToken cancellationToken) =>
            MoveManagerLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves a client customer to a new manager customer.
        /// This simplifies the complex request that requires two operations to move
        /// a client customer to a new manager. i.e:
        /// 1. Update operation with Status INACTIVE (previous manager) and,
        /// 2. Update operation with Status ACTIVE (new manager).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the client customer that is being moved.
        /// </param>
        /// <param name="previousCustomerManagerLink">
        /// Required. The resource name of the previous CustomerManagerLink.
        /// The resource name has the form:
        /// `customers/{customer_id}/customerManagerLinks/{manager_customer_id}~{manager_link_id}`
        /// </param>
        /// <param name="newManager">
        /// Required. The resource name of the new manager customer that the client wants to move
        /// to. Customer resource names have the format: "customers/{customer_id}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MoveManagerLinkResponse MoveManagerLink(string customerId, string previousCustomerManagerLink, string newManager, gaxgrpc::CallSettings callSettings = null) =>
            MoveManagerLink(new MoveManagerLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                PreviousCustomerManagerLink = gax::GaxPreconditions.CheckNotNullOrEmpty(previousCustomerManagerLink, nameof(previousCustomerManagerLink)),
                NewManager = gax::GaxPreconditions.CheckNotNullOrEmpty(newManager, nameof(newManager)),
            }, callSettings);

        /// <summary>
        /// Moves a client customer to a new manager customer.
        /// This simplifies the complex request that requires two operations to move
        /// a client customer to a new manager. i.e:
        /// 1. Update operation with Status INACTIVE (previous manager) and,
        /// 2. Update operation with Status ACTIVE (new manager).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the client customer that is being moved.
        /// </param>
        /// <param name="previousCustomerManagerLink">
        /// Required. The resource name of the previous CustomerManagerLink.
        /// The resource name has the form:
        /// `customers/{customer_id}/customerManagerLinks/{manager_customer_id}~{manager_link_id}`
        /// </param>
        /// <param name="newManager">
        /// Required. The resource name of the new manager customer that the client wants to move
        /// to. Customer resource names have the format: "customers/{customer_id}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MoveManagerLinkResponse> MoveManagerLinkAsync(string customerId, string previousCustomerManagerLink, string newManager, gaxgrpc::CallSettings callSettings = null) =>
            MoveManagerLinkAsync(new MoveManagerLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                PreviousCustomerManagerLink = gax::GaxPreconditions.CheckNotNullOrEmpty(previousCustomerManagerLink, nameof(previousCustomerManagerLink)),
                NewManager = gax::GaxPreconditions.CheckNotNullOrEmpty(newManager, nameof(newManager)),
            }, callSettings);

        /// <summary>
        /// Moves a client customer to a new manager customer.
        /// This simplifies the complex request that requires two operations to move
        /// a client customer to a new manager. i.e:
        /// 1. Update operation with Status INACTIVE (previous manager) and,
        /// 2. Update operation with Status ACTIVE (new manager).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the client customer that is being moved.
        /// </param>
        /// <param name="previousCustomerManagerLink">
        /// Required. The resource name of the previous CustomerManagerLink.
        /// The resource name has the form:
        /// `customers/{customer_id}/customerManagerLinks/{manager_customer_id}~{manager_link_id}`
        /// </param>
        /// <param name="newManager">
        /// Required. The resource name of the new manager customer that the client wants to move
        /// to. Customer resource names have the format: "customers/{customer_id}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MoveManagerLinkResponse> MoveManagerLinkAsync(string customerId, string previousCustomerManagerLink, string newManager, st::CancellationToken cancellationToken) =>
            MoveManagerLinkAsync(customerId, previousCustomerManagerLink, newManager, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomerManagerLinkService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer-manager links.
    /// </remarks>
    public sealed partial class CustomerManagerLinkServiceClientImpl : CustomerManagerLinkServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCustomerManagerLinkRequest, gagvr::CustomerManagerLink> _callGetCustomerManagerLink;

        private readonly gaxgrpc::ApiCall<MutateCustomerManagerLinkRequest, MutateCustomerManagerLinkResponse> _callMutateCustomerManagerLink;

        private readonly gaxgrpc::ApiCall<MoveManagerLinkRequest, MoveManagerLinkResponse> _callMoveManagerLink;

        /// <summary>
        /// Constructs a client wrapper for the CustomerManagerLinkService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CustomerManagerLinkServiceSettings"/> used within this client.
        /// </param>
        public CustomerManagerLinkServiceClientImpl(CustomerManagerLinkService.CustomerManagerLinkServiceClient grpcClient, CustomerManagerLinkServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CustomerManagerLinkServiceSettings effectiveSettings = settings ?? CustomerManagerLinkServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCustomerManagerLink = clientHelper.BuildApiCall<GetCustomerManagerLinkRequest, gagvr::CustomerManagerLink>(grpcClient.GetCustomerManagerLinkAsync, grpcClient.GetCustomerManagerLink, effectiveSettings.GetCustomerManagerLinkSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCustomerManagerLink);
            Modify_GetCustomerManagerLinkApiCall(ref _callGetCustomerManagerLink);
            _callMutateCustomerManagerLink = clientHelper.BuildApiCall<MutateCustomerManagerLinkRequest, MutateCustomerManagerLinkResponse>(grpcClient.MutateCustomerManagerLinkAsync, grpcClient.MutateCustomerManagerLink, effectiveSettings.MutateCustomerManagerLinkSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomerManagerLink);
            Modify_MutateCustomerManagerLinkApiCall(ref _callMutateCustomerManagerLink);
            _callMoveManagerLink = clientHelper.BuildApiCall<MoveManagerLinkRequest, MoveManagerLinkResponse>(grpcClient.MoveManagerLinkAsync, grpcClient.MoveManagerLink, effectiveSettings.MoveManagerLinkSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMoveManagerLink);
            Modify_MoveManagerLinkApiCall(ref _callMoveManagerLink);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCustomerManagerLinkApiCall(ref gaxgrpc::ApiCall<GetCustomerManagerLinkRequest, gagvr::CustomerManagerLink> call);

        partial void Modify_MutateCustomerManagerLinkApiCall(ref gaxgrpc::ApiCall<MutateCustomerManagerLinkRequest, MutateCustomerManagerLinkResponse> call);

        partial void Modify_MoveManagerLinkApiCall(ref gaxgrpc::ApiCall<MoveManagerLinkRequest, MoveManagerLinkResponse> call);

        partial void OnConstruction(CustomerManagerLinkService.CustomerManagerLinkServiceClient grpcClient, CustomerManagerLinkServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomerManagerLinkService client</summary>
        public override CustomerManagerLinkService.CustomerManagerLinkServiceClient GrpcClient { get; }

        partial void Modify_GetCustomerManagerLinkRequest(ref GetCustomerManagerLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateCustomerManagerLinkRequest(ref MutateCustomerManagerLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MoveManagerLinkRequest(ref MoveManagerLinkRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
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
        public override gagvr::CustomerManagerLink GetCustomerManagerLink(GetCustomerManagerLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerManagerLinkRequest(ref request, ref callSettings);
            return _callGetCustomerManagerLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested CustomerManagerLink in full detail.
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
        public override stt::Task<gagvr::CustomerManagerLink> GetCustomerManagerLinkAsync(GetCustomerManagerLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerManagerLinkRequest(ref request, ref callSettings);
            return _callGetCustomerManagerLink.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or updates customer manager links. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [ManagerLinkError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCustomerManagerLinkResponse MutateCustomerManagerLink(MutateCustomerManagerLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerManagerLinkRequest(ref request, ref callSettings);
            return _callMutateCustomerManagerLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or updates customer manager links. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [ManagerLinkError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCustomerManagerLinkResponse> MutateCustomerManagerLinkAsync(MutateCustomerManagerLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerManagerLinkRequest(ref request, ref callSettings);
            return _callMutateCustomerManagerLink.Async(request, callSettings);
        }

        /// <summary>
        /// Moves a client customer to a new manager customer.
        /// This simplifies the complex request that requires two operations to move
        /// a client customer to a new manager. i.e:
        /// 1. Update operation with Status INACTIVE (previous manager) and,
        /// 2. Update operation with Status ACTIVE (new manager).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MoveManagerLinkResponse MoveManagerLink(MoveManagerLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveManagerLinkRequest(ref request, ref callSettings);
            return _callMoveManagerLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Moves a client customer to a new manager customer.
        /// This simplifies the complex request that requires two operations to move
        /// a client customer to a new manager. i.e:
        /// 1. Update operation with Status INACTIVE (previous manager) and,
        /// 2. Update operation with Status ACTIVE (new manager).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MoveManagerLinkResponse> MoveManagerLinkAsync(MoveManagerLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveManagerLinkRequest(ref request, ref callSettings);
            return _callMoveManagerLink.Async(request, callSettings);
        }
    }
}

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

using gagvr = Google.Ads.GoogleAds.V8.Resources;
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

namespace Google.Ads.GoogleAds.V8.Services
{
    /// <summary>Settings for <see cref="CustomerClientLinkServiceClient"/> instances.</summary>
    public sealed partial class CustomerClientLinkServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomerClientLinkServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomerClientLinkServiceSettings"/>.</returns>
        public static CustomerClientLinkServiceSettings GetDefault() => new CustomerClientLinkServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomerClientLinkServiceSettings"/> object with default settings.
        /// </summary>
        public CustomerClientLinkServiceSettings()
        {
        }

        private CustomerClientLinkServiceSettings(CustomerClientLinkServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCustomerClientLinkSettings = existing.GetCustomerClientLinkSettings;
            MutateCustomerClientLinkSettings = existing.MutateCustomerClientLinkSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerClientLinkServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerClientLinkServiceClient.GetCustomerClientLink</c> and
        /// <c>CustomerClientLinkServiceClient.GetCustomerClientLinkAsync</c>.
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
        public gaxgrpc::CallSettings GetCustomerClientLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerClientLinkServiceClient.MutateCustomerClientLink</c> and
        /// <c>CustomerClientLinkServiceClient.MutateCustomerClientLinkAsync</c>.
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
        public gaxgrpc::CallSettings MutateCustomerClientLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomerClientLinkServiceSettings"/> object.</returns>
        public CustomerClientLinkServiceSettings Clone() => new CustomerClientLinkServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerClientLinkServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CustomerClientLinkServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerClientLinkServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomerClientLinkServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CustomerClientLinkServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomerClientLinkServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomerClientLinkServiceClient Build()
        {
            CustomerClientLinkServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomerClientLinkServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomerClientLinkServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomerClientLinkServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerClientLinkServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CustomerClientLinkServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerClientLinkServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CustomerClientLinkServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CustomerClientLinkServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerClientLinkServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CustomerClientLinkService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer client links.
    /// </remarks>
    public abstract partial class CustomerClientLinkServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerClientLinkService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomerClientLinkService scopes.</summary>
        /// <remarks>
        /// The default CustomerClientLinkService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerClientLinkServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerClientLinkServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomerClientLinkServiceClient"/>.</returns>
        public static stt::Task<CustomerClientLinkServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomerClientLinkServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomerClientLinkServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerClientLinkServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomerClientLinkServiceClient"/>.</returns>
        public static CustomerClientLinkServiceClient Create() => new CustomerClientLinkServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomerClientLinkServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomerClientLinkServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerClientLinkServiceClient"/>.</returns>
        internal static CustomerClientLinkServiceClient Create(grpccore::CallInvoker callInvoker, CustomerClientLinkServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerClientLinkService.CustomerClientLinkServiceClient grpcClient = new CustomerClientLinkService.CustomerClientLinkServiceClient(callInvoker);
            return new CustomerClientLinkServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CustomerClientLinkService client</summary>
        public virtual CustomerClientLinkService.CustomerClientLinkServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
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
        public virtual gagvr::CustomerClientLink GetCustomerClientLink(GetCustomerClientLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
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
        public virtual stt::Task<gagvr::CustomerClientLink> GetCustomerClientLinkAsync(GetCustomerClientLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
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
        public virtual stt::Task<gagvr::CustomerClientLink> GetCustomerClientLinkAsync(GetCustomerClientLinkRequest request, st::CancellationToken cancellationToken) =>
            GetCustomerClientLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
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
        /// Required. The resource name of the customer client link to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerClientLink GetCustomerClientLink(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerClientLink(new GetCustomerClientLinkRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
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
        /// Required. The resource name of the customer client link to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerClientLink> GetCustomerClientLinkAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerClientLinkAsync(new GetCustomerClientLinkRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
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
        /// Required. The resource name of the customer client link to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerClientLink> GetCustomerClientLinkAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCustomerClientLinkAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
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
        /// Required. The resource name of the customer client link to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerClientLink GetCustomerClientLink(gagvr::CustomerClientLinkName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerClientLink(new GetCustomerClientLinkRequest
            {
                ResourceNameAsCustomerClientLinkName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
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
        /// Required. The resource name of the customer client link to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerClientLink> GetCustomerClientLinkAsync(gagvr::CustomerClientLinkName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerClientLinkAsync(new GetCustomerClientLinkRequest
            {
                ResourceNameAsCustomerClientLinkName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
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
        /// Required. The resource name of the customer client link to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerClientLink> GetCustomerClientLinkAsync(gagvr::CustomerClientLinkName resourceName, st::CancellationToken cancellationToken) =>
            GetCustomerClientLinkAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates a customer client link. Operation statuses are returned.
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
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerClientLinkResponse MutateCustomerClientLink(MutateCustomerClientLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates a customer client link. Operation statuses are returned.
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
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerClientLinkResponse> MutateCustomerClientLinkAsync(MutateCustomerClientLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates a customer client link. Operation statuses are returned.
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
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerClientLinkResponse> MutateCustomerClientLinkAsync(MutateCustomerClientLinkRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomerClientLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates a customer client link. Operation statuses are returned.
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
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer link are being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the individual CustomerClientLink.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerClientLinkResponse MutateCustomerClientLink(string customerId, CustomerClientLinkOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerClientLink(new MutateCustomerClientLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Creates or updates a customer client link. Operation statuses are returned.
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
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer link are being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the individual CustomerClientLink.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerClientLinkResponse> MutateCustomerClientLinkAsync(string customerId, CustomerClientLinkOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerClientLinkAsync(new MutateCustomerClientLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Creates or updates a customer client link. Operation statuses are returned.
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
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer link are being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the individual CustomerClientLink.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerClientLinkResponse> MutateCustomerClientLinkAsync(string customerId, CustomerClientLinkOperation operation, st::CancellationToken cancellationToken) =>
            MutateCustomerClientLinkAsync(customerId, operation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomerClientLinkService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer client links.
    /// </remarks>
    public sealed partial class CustomerClientLinkServiceClientImpl : CustomerClientLinkServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCustomerClientLinkRequest, gagvr::CustomerClientLink> _callGetCustomerClientLink;

        private readonly gaxgrpc::ApiCall<MutateCustomerClientLinkRequest, MutateCustomerClientLinkResponse> _callMutateCustomerClientLink;

        /// <summary>
        /// Constructs a client wrapper for the CustomerClientLinkService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CustomerClientLinkServiceSettings"/> used within this client.
        /// </param>
        public CustomerClientLinkServiceClientImpl(CustomerClientLinkService.CustomerClientLinkServiceClient grpcClient, CustomerClientLinkServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CustomerClientLinkServiceSettings effectiveSettings = settings ?? CustomerClientLinkServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCustomerClientLink = clientHelper.BuildApiCall<GetCustomerClientLinkRequest, gagvr::CustomerClientLink>(grpcClient.GetCustomerClientLinkAsync, grpcClient.GetCustomerClientLink, effectiveSettings.GetCustomerClientLinkSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCustomerClientLink);
            Modify_GetCustomerClientLinkApiCall(ref _callGetCustomerClientLink);
            _callMutateCustomerClientLink = clientHelper.BuildApiCall<MutateCustomerClientLinkRequest, MutateCustomerClientLinkResponse>(grpcClient.MutateCustomerClientLinkAsync, grpcClient.MutateCustomerClientLink, effectiveSettings.MutateCustomerClientLinkSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomerClientLink);
            Modify_MutateCustomerClientLinkApiCall(ref _callMutateCustomerClientLink);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCustomerClientLinkApiCall(ref gaxgrpc::ApiCall<GetCustomerClientLinkRequest, gagvr::CustomerClientLink> call);

        partial void Modify_MutateCustomerClientLinkApiCall(ref gaxgrpc::ApiCall<MutateCustomerClientLinkRequest, MutateCustomerClientLinkResponse> call);

        partial void OnConstruction(CustomerClientLinkService.CustomerClientLinkServiceClient grpcClient, CustomerClientLinkServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomerClientLinkService client</summary>
        public override CustomerClientLinkService.CustomerClientLinkServiceClient GrpcClient { get; }

        partial void Modify_GetCustomerClientLinkRequest(ref GetCustomerClientLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateCustomerClientLinkRequest(ref MutateCustomerClientLinkRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
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
        public override gagvr::CustomerClientLink GetCustomerClientLink(GetCustomerClientLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerClientLinkRequest(ref request, ref callSettings);
            return _callGetCustomerClientLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
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
        public override stt::Task<gagvr::CustomerClientLink> GetCustomerClientLinkAsync(GetCustomerClientLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerClientLinkRequest(ref request, ref callSettings);
            return _callGetCustomerClientLink.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or updates a customer client link. Operation statuses are returned.
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
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCustomerClientLinkResponse MutateCustomerClientLink(MutateCustomerClientLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerClientLinkRequest(ref request, ref callSettings);
            return _callMutateCustomerClientLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or updates a customer client link. Operation statuses are returned.
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
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCustomerClientLinkResponse> MutateCustomerClientLinkAsync(MutateCustomerClientLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerClientLinkRequest(ref request, ref callSettings);
            return _callMutateCustomerClientLink.Async(request, callSettings);
        }
    }
}

// Copyright 2023 Google LLC
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

#pragma warning disable CS8981
using gagvr = Google.Ads.GoogleAds.V13.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V13.Services
{
    /// <summary>Settings for <see cref="CustomerServiceClient"/> instances.</summary>
    public sealed partial class CustomerServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomerServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomerServiceSettings"/>.</returns>
        public static CustomerServiceSettings GetDefault() => new CustomerServiceSettings();

        /// <summary>Constructs a new <see cref="CustomerServiceSettings"/> object with default settings.</summary>
        public CustomerServiceSettings()
        {
        }

        private CustomerServiceSettings(CustomerServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCustomerSettings = existing.MutateCustomerSettings;
            ListAccessibleCustomersSettings = existing.ListAccessibleCustomersSettings;
            CreateCustomerClientSettings = existing.CreateCustomerClientSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerServiceClient.MutateCustomer</c> and <c>CustomerServiceClient.MutateCustomerAsync</c>.
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
        public gaxgrpc::CallSettings MutateCustomerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerServiceClient.ListAccessibleCustomers</c> and
        /// <c>CustomerServiceClient.ListAccessibleCustomersAsync</c>.
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
        public gaxgrpc::CallSettings ListAccessibleCustomersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerServiceClient.CreateCustomerClient</c> and <c>CustomerServiceClient.CreateCustomerClientAsync</c>
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
        public gaxgrpc::CallSettings CreateCustomerClientSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomerServiceSettings"/> object.</returns>
        public CustomerServiceSettings Clone() => new CustomerServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class CustomerServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomerServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CustomerServiceClientBuilder() : base(CustomerServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CustomerServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomerServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomerServiceClient Build()
        {
            CustomerServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomerServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomerServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomerServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<CustomerServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerServiceClient.ChannelPool;
    }

    /// <summary>CustomerService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customers.
    /// </remarks>
    public abstract partial class CustomerServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomerService scopes.</summary>
        /// <remarks>
        /// The default CustomerService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CustomerService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CustomerServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomerServiceClient"/>.</returns>
        public static stt::Task<CustomerServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomerServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomerServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CustomerServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomerServiceClient"/>.</returns>
        public static CustomerServiceClient Create() => new CustomerServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomerServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomerServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CustomerServiceClient"/>.</returns>
        internal static CustomerServiceClient Create(grpccore::CallInvoker callInvoker, CustomerServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerService.CustomerServiceClient grpcClient = new CustomerService.CustomerServiceClient(callInvoker);
            return new CustomerServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CustomerService client</summary>
        public virtual CustomerService.CustomerServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerResponse MutateCustomer(MutateCustomerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerResponse> MutateCustomerAsync(MutateCustomerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerResponse> MutateCustomerAsync(MutateCustomerRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the customer
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerResponse MutateCustomer(string customerId, CustomerOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomer(new MutateCustomerRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the customer
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerResponse> MutateCustomerAsync(string customerId, CustomerOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerAsync(new MutateCustomerRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the customer
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerResponse> MutateCustomerAsync(string customerId, CustomerOperation operation, st::CancellationToken cancellationToken) =>
            MutateCustomerAsync(customerId, operation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns resource names of customers directly accessible by the
        /// user authenticating the call.
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
        public virtual ListAccessibleCustomersResponse ListAccessibleCustomers(ListAccessibleCustomersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns resource names of customers directly accessible by the
        /// user authenticating the call.
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
        public virtual stt::Task<ListAccessibleCustomersResponse> ListAccessibleCustomersAsync(ListAccessibleCustomersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns resource names of customers directly accessible by the
        /// user authenticating the call.
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
        public virtual stt::Task<ListAccessibleCustomersResponse> ListAccessibleCustomersAsync(ListAccessibleCustomersRequest request, st::CancellationToken cancellationToken) =>
            ListAccessibleCustomersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// 
        /// List of thrown errors:
        /// [AccessInvitationError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CurrencyCodeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [ManagerLinkError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [StringLengthError]()
        /// [TimeZoneError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateCustomerClientResponse CreateCustomerClient(CreateCustomerClientRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// 
        /// List of thrown errors:
        /// [AccessInvitationError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CurrencyCodeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [ManagerLinkError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [StringLengthError]()
        /// [TimeZoneError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateCustomerClientResponse> CreateCustomerClientAsync(CreateCustomerClientRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// 
        /// List of thrown errors:
        /// [AccessInvitationError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CurrencyCodeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [ManagerLinkError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [StringLengthError]()
        /// [TimeZoneError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateCustomerClientResponse> CreateCustomerClientAsync(CreateCustomerClientRequest request, st::CancellationToken cancellationToken) =>
            CreateCustomerClientAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// 
        /// List of thrown errors:
        /// [AccessInvitationError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CurrencyCodeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [ManagerLinkError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [StringLengthError]()
        /// [TimeZoneError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the Manager under whom client customer is being
        /// created.
        /// </param>
        /// <param name="customerClient">
        /// Required. The new client customer to create. The resource name on this
        /// customer will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateCustomerClientResponse CreateCustomerClient(string customerId, gagvr::Customer customerClient, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomerClient(new CreateCustomerClientRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                CustomerClient = gax::GaxPreconditions.CheckNotNull(customerClient, nameof(customerClient)),
            }, callSettings);

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// 
        /// List of thrown errors:
        /// [AccessInvitationError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CurrencyCodeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [ManagerLinkError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [StringLengthError]()
        /// [TimeZoneError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the Manager under whom client customer is being
        /// created.
        /// </param>
        /// <param name="customerClient">
        /// Required. The new client customer to create. The resource name on this
        /// customer will be ignored.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateCustomerClientResponse> CreateCustomerClientAsync(string customerId, gagvr::Customer customerClient, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomerClientAsync(new CreateCustomerClientRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                CustomerClient = gax::GaxPreconditions.CheckNotNull(customerClient, nameof(customerClient)),
            }, callSettings);

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// 
        /// List of thrown errors:
        /// [AccessInvitationError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CurrencyCodeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [ManagerLinkError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [StringLengthError]()
        /// [TimeZoneError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the Manager under whom client customer is being
        /// created.
        /// </param>
        /// <param name="customerClient">
        /// Required. The new client customer to create. The resource name on this
        /// customer will be ignored.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateCustomerClientResponse> CreateCustomerClientAsync(string customerId, gagvr::Customer customerClient, st::CancellationToken cancellationToken) =>
            CreateCustomerClientAsync(customerId, customerClient, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomerService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customers.
    /// </remarks>
    public sealed partial class CustomerServiceClientImpl : CustomerServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCustomerRequest, MutateCustomerResponse> _callMutateCustomer;

        private readonly gaxgrpc::ApiCall<ListAccessibleCustomersRequest, ListAccessibleCustomersResponse> _callListAccessibleCustomers;

        private readonly gaxgrpc::ApiCall<CreateCustomerClientRequest, CreateCustomerClientResponse> _callCreateCustomerClient;

        /// <summary>
        /// Constructs a client wrapper for the CustomerService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CustomerServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CustomerServiceClientImpl(CustomerService.CustomerServiceClient grpcClient, CustomerServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CustomerServiceSettings effectiveSettings = settings ?? CustomerServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callMutateCustomer = clientHelper.BuildApiCall<MutateCustomerRequest, MutateCustomerResponse>("MutateCustomer", grpcClient.MutateCustomerAsync, grpcClient.MutateCustomer, effectiveSettings.MutateCustomerSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomer);
            Modify_MutateCustomerApiCall(ref _callMutateCustomer);
            _callListAccessibleCustomers = clientHelper.BuildApiCall<ListAccessibleCustomersRequest, ListAccessibleCustomersResponse>("ListAccessibleCustomers", grpcClient.ListAccessibleCustomersAsync, grpcClient.ListAccessibleCustomers, effectiveSettings.ListAccessibleCustomersSettings);
            Modify_ApiCall(ref _callListAccessibleCustomers);
            Modify_ListAccessibleCustomersApiCall(ref _callListAccessibleCustomers);
            _callCreateCustomerClient = clientHelper.BuildApiCall<CreateCustomerClientRequest, CreateCustomerClientResponse>("CreateCustomerClient", grpcClient.CreateCustomerClientAsync, grpcClient.CreateCustomerClient, effectiveSettings.CreateCustomerClientSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callCreateCustomerClient);
            Modify_CreateCustomerClientApiCall(ref _callCreateCustomerClient);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCustomerApiCall(ref gaxgrpc::ApiCall<MutateCustomerRequest, MutateCustomerResponse> call);

        partial void Modify_ListAccessibleCustomersApiCall(ref gaxgrpc::ApiCall<ListAccessibleCustomersRequest, ListAccessibleCustomersResponse> call);

        partial void Modify_CreateCustomerClientApiCall(ref gaxgrpc::ApiCall<CreateCustomerClientRequest, CreateCustomerClientResponse> call);

        partial void OnConstruction(CustomerService.CustomerServiceClient grpcClient, CustomerServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomerService client</summary>
        public override CustomerService.CustomerServiceClient GrpcClient { get; }

        partial void Modify_MutateCustomerRequest(ref MutateCustomerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAccessibleCustomersRequest(ref ListAccessibleCustomersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCustomerClientRequest(ref CreateCustomerClientRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCustomerResponse MutateCustomer(MutateCustomerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerRequest(ref request, ref callSettings);
            return _callMutateCustomer.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCustomerResponse> MutateCustomerAsync(MutateCustomerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerRequest(ref request, ref callSettings);
            return _callMutateCustomer.Async(request, callSettings);
        }

        /// <summary>
        /// Returns resource names of customers directly accessible by the
        /// user authenticating the call.
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
        public override ListAccessibleCustomersResponse ListAccessibleCustomers(ListAccessibleCustomersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccessibleCustomersRequest(ref request, ref callSettings);
            return _callListAccessibleCustomers.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns resource names of customers directly accessible by the
        /// user authenticating the call.
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
        public override stt::Task<ListAccessibleCustomersResponse> ListAccessibleCustomersAsync(ListAccessibleCustomersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccessibleCustomersRequest(ref request, ref callSettings);
            return _callListAccessibleCustomers.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// 
        /// List of thrown errors:
        /// [AccessInvitationError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CurrencyCodeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [ManagerLinkError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [StringLengthError]()
        /// [TimeZoneError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CreateCustomerClientResponse CreateCustomerClient(CreateCustomerClientRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomerClientRequest(ref request, ref callSettings);
            return _callCreateCustomerClient.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// 
        /// List of thrown errors:
        /// [AccessInvitationError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CurrencyCodeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [ManagerLinkError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [StringLengthError]()
        /// [TimeZoneError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CreateCustomerClientResponse> CreateCustomerClientAsync(CreateCustomerClientRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomerClientRequest(ref request, ref callSettings);
            return _callCreateCustomerClient.Async(request, callSettings);
        }
    }
}

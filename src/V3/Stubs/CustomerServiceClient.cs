// Copyright 2020 Google LLC
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

using gagve = Google.Ads.GoogleAds.V3.Enums;
using gagvr = Google.Ads.GoogleAds.V3.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V3.Services
{
    /// <summary>
    /// Settings for a <see cref="CustomerServiceClient"/>.
    /// </summary>
    public sealed partial class CustomerServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="CustomerServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="CustomerServiceSettings"/>.
        /// </returns>
        public static CustomerServiceSettings GetDefault() => new CustomerServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomerServiceSettings"/> object with default settings.
        /// </summary>
        public CustomerServiceSettings() { }

        private CustomerServiceSettings(CustomerServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCustomerSettings = existing.GetCustomerSettings;
            MutateCustomerSettings = existing.MutateCustomerSettings;
            ListAccessibleCustomersSettings = existing.ListAccessibleCustomersSettings;
            CreateCustomerClientSettings = existing.CreateCustomerClientSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="CustomerServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="CustomerServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="CustomerServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="CustomerServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="CustomerServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 5000 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(5000),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="CustomerServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="CustomerServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="CustomerServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 3600000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(3600000),
            maxDelay: sys::TimeSpan.FromMilliseconds(3600000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerServiceClient.GetCustomer</c> and <c>CustomerServiceClient.GetCustomerAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CustomerServiceClient.GetCustomer</c> and
        /// <c>CustomerServiceClient.GetCustomerAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 3600000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 3600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomerSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerServiceClient.MutateCustomer</c> and <c>CustomerServiceClient.MutateCustomerAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CustomerServiceClient.MutateCustomer</c> and
        /// <c>CustomerServiceClient.MutateCustomerAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 3600000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 3600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings MutateCustomerSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerServiceClient.ListAccessibleCustomers</c> and <c>CustomerServiceClient.ListAccessibleCustomersAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CustomerServiceClient.ListAccessibleCustomers</c> and
        /// <c>CustomerServiceClient.ListAccessibleCustomersAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 3600000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 3600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListAccessibleCustomersSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerServiceClient.CreateCustomerClient</c> and <c>CustomerServiceClient.CreateCustomerClientAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CustomerServiceClient.CreateCustomerClient</c> and
        /// <c>CustomerServiceClient.CreateCustomerClientAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 3600000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 3600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateCustomerClientSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="CustomerServiceSettings"/> object.</returns>
        public CustomerServiceSettings Clone() => new CustomerServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CustomerServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public CustomerServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override CustomerServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<CustomerServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => CustomerServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CustomerServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerServiceClient.ChannelPool;
    }

    /// <summary>
    /// CustomerService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class CustomerServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default CustomerService scopes.
        /// </summary>
        /// <remarks>
        /// The default CustomerService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// CustomerServiceClient client = await CustomerServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     CustomerServiceClient.DefaultEndpoint.Host, CustomerServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CustomerServiceClient client = CustomerServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CustomerServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="CustomerServiceClient"/>.</returns>
        public static async stt::Task<CustomerServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, CustomerServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="CustomerServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// CustomerServiceClient client = CustomerServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     CustomerServiceClient.DefaultEndpoint.Host, CustomerServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CustomerServiceClient client = CustomerServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CustomerServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerServiceClient"/>.</returns>
        public static CustomerServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, CustomerServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="CustomerServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CustomerServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerServiceClient"/>.</returns>
        public static CustomerServiceClient Create(grpccore::Channel channel, CustomerServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="CustomerServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CustomerServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerServiceClient"/>.</returns>
        public static CustomerServiceClient Create(grpccore::CallInvoker callInvoker, CustomerServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerService.CustomerServiceClient grpcClient = new CustomerService.CustomerServiceClient(callInvoker);
            return new CustomerServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, CustomerServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CustomerServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, CustomerServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CustomerServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC CustomerService client.
        /// </summary>
        public virtual CustomerService.CustomerServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested customer in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::Customer> GetCustomerAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCustomerAsync(
                new GetCustomerRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested customer in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::Customer> GetCustomerAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetCustomerAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested customer in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::Customer GetCustomer(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCustomer(
                new GetCustomerRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested customer in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::Customer> GetCustomerAsync(
            GetCustomerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested customer in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::Customer> GetCustomerAsync(
            GetCustomerRequest request,
            st::CancellationToken cancellationToken) => GetCustomerAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested customer in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::Customer GetCustomer(
            GetCustomerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the customer
        /// </param>
        /// <param name="validateOnly">
        /// If true, the request is validated but not executed. Only errors are
        /// returned, not results.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCustomerResponse> MutateCustomerAsync(
            string customerId,
            CustomerOperation operation,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateCustomerAsync(
                new MutateCustomerRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the customer
        /// </param>
        /// <param name="validateOnly">
        /// If true, the request is validated but not executed. Only errors are
        /// returned, not results.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCustomerResponse> MutateCustomerAsync(
            string customerId,
            CustomerOperation operation,
            bool? validateOnly,
            st::CancellationToken cancellationToken) => MutateCustomerAsync(
                customerId,
                operation,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the customer
        /// </param>
        /// <param name="validateOnly">
        /// If true, the request is validated but not executed. Only errors are
        /// returned, not results.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateCustomerResponse MutateCustomer(
            string customerId,
            CustomerOperation operation,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateCustomer(
                new MutateCustomerRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the customer
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCustomerResponse> MutateCustomerAsync(
            string customerId,
            CustomerOperation operation,
            gaxgrpc::CallSettings callSettings = null) => MutateCustomerAsync(
                new MutateCustomerRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
                },
                callSettings);

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the customer
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCustomerResponse> MutateCustomerAsync(
            string customerId,
            CustomerOperation operation,
            st::CancellationToken cancellationToken) => MutateCustomerAsync(
                customerId,
                operation,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the customer
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateCustomerResponse MutateCustomer(
            string customerId,
            CustomerOperation operation,
            gaxgrpc::CallSettings callSettings = null) => MutateCustomer(
                new MutateCustomerRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
                },
                callSettings);

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCustomerResponse> MutateCustomerAsync(
            MutateCustomerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCustomerResponse> MutateCustomerAsync(
            MutateCustomerRequest request,
            st::CancellationToken cancellationToken) => MutateCustomerAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateCustomerResponse MutateCustomer(
            MutateCustomerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns resource names of customers directly accessible by the
        /// user authenticating the call.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListAccessibleCustomersResponse> ListAccessibleCustomersAsync(
            ListAccessibleCustomersRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns resource names of customers directly accessible by the
        /// user authenticating the call.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListAccessibleCustomersResponse> ListAccessibleCustomersAsync(
            ListAccessibleCustomersRequest request,
            st::CancellationToken cancellationToken) => ListAccessibleCustomersAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns resource names of customers directly accessible by the
        /// user authenticating the call.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListAccessibleCustomersResponse ListAccessibleCustomers(
            ListAccessibleCustomersRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the Manager under whom client customer is being created.
        /// </param>
        /// <param name="customerClient">
        /// Required. The new client customer to create. The resource name on this customer
        /// will be ignored.
        /// </param>
        /// <param name="emailAddress">
        /// Email address of the user who should be invited on the created client
        /// customer. Accessible to whitelisted customers only.
        /// </param>
        /// <param name="accessRole">
        /// The proposed role of user on the created client customer.
        /// Accessible to whitelisted customers only.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CreateCustomerClientResponse> CreateCustomerClientAsync(
            string customerId,
            gagvr::Customer customerClient,
            string emailAddress,
            gagve::AccessRoleEnum.Types.AccessRole? accessRole,
            gaxgrpc::CallSettings callSettings = null) => CreateCustomerClientAsync(
                new CreateCustomerClientRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    CustomerClient = gax::GaxPreconditions.CheckNotNull(customerClient, nameof(customerClient)),
                    EmailAddress = emailAddress, // Optional
                    AccessRole = accessRole ?? gagve::AccessRoleEnum.Types.AccessRole.Unspecified, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the Manager under whom client customer is being created.
        /// </param>
        /// <param name="customerClient">
        /// Required. The new client customer to create. The resource name on this customer
        /// will be ignored.
        /// </param>
        /// <param name="emailAddress">
        /// Email address of the user who should be invited on the created client
        /// customer. Accessible to whitelisted customers only.
        /// </param>
        /// <param name="accessRole">
        /// The proposed role of user on the created client customer.
        /// Accessible to whitelisted customers only.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CreateCustomerClientResponse> CreateCustomerClientAsync(
            string customerId,
            gagvr::Customer customerClient,
            string emailAddress,
            gagve::AccessRoleEnum.Types.AccessRole? accessRole,
            st::CancellationToken cancellationToken) => CreateCustomerClientAsync(
                customerId,
                customerClient,
                emailAddress,
                accessRole,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the Manager under whom client customer is being created.
        /// </param>
        /// <param name="customerClient">
        /// Required. The new client customer to create. The resource name on this customer
        /// will be ignored.
        /// </param>
        /// <param name="emailAddress">
        /// Email address of the user who should be invited on the created client
        /// customer. Accessible to whitelisted customers only.
        /// </param>
        /// <param name="accessRole">
        /// The proposed role of user on the created client customer.
        /// Accessible to whitelisted customers only.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CreateCustomerClientResponse CreateCustomerClient(
            string customerId,
            gagvr::Customer customerClient,
            string emailAddress,
            gagve::AccessRoleEnum.Types.AccessRole? accessRole,
            gaxgrpc::CallSettings callSettings = null) => CreateCustomerClient(
                new CreateCustomerClientRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    CustomerClient = gax::GaxPreconditions.CheckNotNull(customerClient, nameof(customerClient)),
                    EmailAddress = emailAddress, // Optional
                    AccessRole = accessRole ?? gagve::AccessRoleEnum.Types.AccessRole.Unspecified, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the Manager under whom client customer is being created.
        /// </param>
        /// <param name="customerClient">
        /// Required. The new client customer to create. The resource name on this customer
        /// will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CreateCustomerClientResponse> CreateCustomerClientAsync(
            string customerId,
            gagvr::Customer customerClient,
            gaxgrpc::CallSettings callSettings = null) => CreateCustomerClientAsync(
                new CreateCustomerClientRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    CustomerClient = gax::GaxPreconditions.CheckNotNull(customerClient, nameof(customerClient)),
                },
                callSettings);

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the Manager under whom client customer is being created.
        /// </param>
        /// <param name="customerClient">
        /// Required. The new client customer to create. The resource name on this customer
        /// will be ignored.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CreateCustomerClientResponse> CreateCustomerClientAsync(
            string customerId,
            gagvr::Customer customerClient,
            st::CancellationToken cancellationToken) => CreateCustomerClientAsync(
                customerId,
                customerClient,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the Manager under whom client customer is being created.
        /// </param>
        /// <param name="customerClient">
        /// Required. The new client customer to create. The resource name on this customer
        /// will be ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CreateCustomerClientResponse CreateCustomerClient(
            string customerId,
            gagvr::Customer customerClient,
            gaxgrpc::CallSettings callSettings = null) => CreateCustomerClient(
                new CreateCustomerClientRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    CustomerClient = gax::GaxPreconditions.CheckNotNull(customerClient, nameof(customerClient)),
                },
                callSettings);

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CreateCustomerClientResponse> CreateCustomerClientAsync(
            CreateCustomerClientRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CreateCustomerClientResponse> CreateCustomerClientAsync(
            CreateCustomerClientRequest request,
            st::CancellationToken cancellationToken) => CreateCustomerClientAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CreateCustomerClientResponse CreateCustomerClient(
            CreateCustomerClientRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// CustomerService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class CustomerServiceClientImpl : CustomerServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCustomerRequest, gagvr::Customer> _callGetCustomer;
        private readonly gaxgrpc::ApiCall<MutateCustomerRequest, MutateCustomerResponse> _callMutateCustomer;
        private readonly gaxgrpc::ApiCall<ListAccessibleCustomersRequest, ListAccessibleCustomersResponse> _callListAccessibleCustomers;
        private readonly gaxgrpc::ApiCall<CreateCustomerClientRequest, CreateCustomerClientResponse> _callCreateCustomerClient;

        /// <summary>
        /// Constructs a client wrapper for the CustomerService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CustomerServiceSettings"/> used within this client </param>
        public CustomerServiceClientImpl(CustomerService.CustomerServiceClient grpcClient, CustomerServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CustomerServiceSettings effectiveSettings = settings ?? CustomerServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCustomer = clientHelper.BuildApiCall<GetCustomerRequest, gagvr::Customer>(
                GrpcClient.GetCustomerAsync, GrpcClient.GetCustomer, effectiveSettings.GetCustomerSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource_name={request.ResourceName}"));
            _callMutateCustomer = clientHelper.BuildApiCall<MutateCustomerRequest, MutateCustomerResponse>(
                GrpcClient.MutateCustomerAsync, GrpcClient.MutateCustomer, effectiveSettings.MutateCustomerSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"customer_id={request.CustomerId}"));
            _callListAccessibleCustomers = clientHelper.BuildApiCall<ListAccessibleCustomersRequest, ListAccessibleCustomersResponse>(
                GrpcClient.ListAccessibleCustomersAsync, GrpcClient.ListAccessibleCustomers, effectiveSettings.ListAccessibleCustomersSettings);
            _callCreateCustomerClient = clientHelper.BuildApiCall<CreateCustomerClientRequest, CreateCustomerClientResponse>(
                GrpcClient.CreateCustomerClientAsync, GrpcClient.CreateCustomerClient, effectiveSettings.CreateCustomerClientSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"customer_id={request.CustomerId}"));
            Modify_ApiCall(ref _callGetCustomer);
            Modify_GetCustomerApiCall(ref _callGetCustomer);
            Modify_ApiCall(ref _callMutateCustomer);
            Modify_MutateCustomerApiCall(ref _callMutateCustomer);
            Modify_ApiCall(ref _callListAccessibleCustomers);
            Modify_ListAccessibleCustomersApiCall(ref _callListAccessibleCustomers);
            Modify_ApiCall(ref _callCreateCustomerClient);
            Modify_CreateCustomerClientApiCall(ref _callCreateCustomerClient);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_GetCustomerApiCall(ref gaxgrpc::ApiCall<GetCustomerRequest, gagvr::Customer> call);
        partial void Modify_MutateCustomerApiCall(ref gaxgrpc::ApiCall<MutateCustomerRequest, MutateCustomerResponse> call);
        partial void Modify_ListAccessibleCustomersApiCall(ref gaxgrpc::ApiCall<ListAccessibleCustomersRequest, ListAccessibleCustomersResponse> call);
        partial void Modify_CreateCustomerClientApiCall(ref gaxgrpc::ApiCall<CreateCustomerClientRequest, CreateCustomerClientResponse> call);
        partial void OnConstruction(CustomerService.CustomerServiceClient grpcClient, CustomerServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC CustomerService client.
        /// </summary>
        public override CustomerService.CustomerServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetCustomerRequest(ref GetCustomerRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateCustomerRequest(ref MutateCustomerRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListAccessibleCustomersRequest(ref ListAccessibleCustomersRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateCustomerClientRequest(ref CreateCustomerClientRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested customer in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<gagvr::Customer> GetCustomerAsync(
            GetCustomerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerRequest(ref request, ref callSettings);
            return _callGetCustomer.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested customer in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override gagvr::Customer GetCustomer(
            GetCustomerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerRequest(ref request, ref callSettings);
            return _callGetCustomer.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<MutateCustomerResponse> MutateCustomerAsync(
            MutateCustomerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerRequest(ref request, ref callSettings);
            return _callMutateCustomer.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a customer. Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override MutateCustomerResponse MutateCustomer(
            MutateCustomerRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerRequest(ref request, ref callSettings);
            return _callMutateCustomer.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns resource names of customers directly accessible by the
        /// user authenticating the call.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ListAccessibleCustomersResponse> ListAccessibleCustomersAsync(
            ListAccessibleCustomersRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccessibleCustomersRequest(ref request, ref callSettings);
            return _callListAccessibleCustomers.Async(request, callSettings);
        }

        /// <summary>
        /// Returns resource names of customers directly accessible by the
        /// user authenticating the call.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ListAccessibleCustomersResponse ListAccessibleCustomers(
            ListAccessibleCustomersRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAccessibleCustomersRequest(ref request, ref callSettings);
            return _callListAccessibleCustomers.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<CreateCustomerClientResponse> CreateCustomerClientAsync(
            CreateCustomerClientRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomerClientRequest(ref request, ref callSettings);
            return _callCreateCustomerClient.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new client under manager. The new client customer is returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override CreateCustomerClientResponse CreateCustomerClient(
            CreateCustomerClientRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomerClientRequest(ref request, ref callSettings);
            return _callCreateCustomerClient.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

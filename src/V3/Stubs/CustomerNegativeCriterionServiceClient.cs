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
    /// Settings for a <see cref="CustomerNegativeCriterionServiceClient"/>.
    /// </summary>
    public sealed partial class CustomerNegativeCriterionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="CustomerNegativeCriterionServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="CustomerNegativeCriterionServiceSettings"/>.
        /// </returns>
        public static CustomerNegativeCriterionServiceSettings GetDefault() => new CustomerNegativeCriterionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomerNegativeCriterionServiceSettings"/> object with default settings.
        /// </summary>
        public CustomerNegativeCriterionServiceSettings() { }

        private CustomerNegativeCriterionServiceSettings(CustomerNegativeCriterionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCustomerNegativeCriterionSettings = existing.GetCustomerNegativeCriterionSettings;
            MutateCustomerNegativeCriteriaSettings = existing.MutateCustomerNegativeCriteriaSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerNegativeCriterionServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="CustomerNegativeCriterionServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="CustomerNegativeCriterionServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="CustomerNegativeCriterionServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="CustomerNegativeCriterionServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="CustomerNegativeCriterionServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="CustomerNegativeCriterionServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="CustomerNegativeCriterionServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="CustomerNegativeCriterionServiceClient"/> RPC methods is defined as:
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
        /// <c>CustomerNegativeCriterionServiceClient.GetCustomerNegativeCriterion</c> and <c>CustomerNegativeCriterionServiceClient.GetCustomerNegativeCriterionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CustomerNegativeCriterionServiceClient.GetCustomerNegativeCriterion</c> and
        /// <c>CustomerNegativeCriterionServiceClient.GetCustomerNegativeCriterionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetCustomerNegativeCriterionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerNegativeCriterionServiceClient.MutateCustomerNegativeCriteria</c> and <c>CustomerNegativeCriterionServiceClient.MutateCustomerNegativeCriteriaAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CustomerNegativeCriterionServiceClient.MutateCustomerNegativeCriteria</c> and
        /// <c>CustomerNegativeCriterionServiceClient.MutateCustomerNegativeCriteriaAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings MutateCustomerNegativeCriteriaSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="CustomerNegativeCriterionServiceSettings"/> object.</returns>
        public CustomerNegativeCriterionServiceSettings Clone() => new CustomerNegativeCriterionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerNegativeCriterionServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CustomerNegativeCriterionServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerNegativeCriterionServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public CustomerNegativeCriterionServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override CustomerNegativeCriterionServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerNegativeCriterionServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<CustomerNegativeCriterionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerNegativeCriterionServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => CustomerNegativeCriterionServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CustomerNegativeCriterionServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerNegativeCriterionServiceClient.ChannelPool;
    }

    /// <summary>
    /// CustomerNegativeCriterionService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class CustomerNegativeCriterionServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerNegativeCriterionService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default CustomerNegativeCriterionService scopes.
        /// </summary>
        /// <remarks>
        /// The default CustomerNegativeCriterionService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerNegativeCriterionServiceClient"/>, applying defaults for all unspecified settings,
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
        /// CustomerNegativeCriterionServiceClient client = await CustomerNegativeCriterionServiceClient.CreateAsync();
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
        ///     CustomerNegativeCriterionServiceClient.DefaultEndpoint.Host, CustomerNegativeCriterionServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CustomerNegativeCriterionServiceClient client = CustomerNegativeCriterionServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CustomerNegativeCriterionServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="CustomerNegativeCriterionServiceClient"/>.</returns>
        public static async stt::Task<CustomerNegativeCriterionServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, CustomerNegativeCriterionServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="CustomerNegativeCriterionServiceClient"/>, applying defaults for all unspecified settings,
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
        /// CustomerNegativeCriterionServiceClient client = CustomerNegativeCriterionServiceClient.Create();
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
        ///     CustomerNegativeCriterionServiceClient.DefaultEndpoint.Host, CustomerNegativeCriterionServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CustomerNegativeCriterionServiceClient client = CustomerNegativeCriterionServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CustomerNegativeCriterionServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerNegativeCriterionServiceClient"/>.</returns>
        public static CustomerNegativeCriterionServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, CustomerNegativeCriterionServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="CustomerNegativeCriterionServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CustomerNegativeCriterionServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerNegativeCriterionServiceClient"/>.</returns>
        public static CustomerNegativeCriterionServiceClient Create(grpccore::Channel channel, CustomerNegativeCriterionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="CustomerNegativeCriterionServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CustomerNegativeCriterionServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerNegativeCriterionServiceClient"/>.</returns>
        public static CustomerNegativeCriterionServiceClient Create(grpccore::CallInvoker callInvoker, CustomerNegativeCriterionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient grpcClient = new CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient(callInvoker);
            return new CustomerNegativeCriterionServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, CustomerNegativeCriterionServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CustomerNegativeCriterionServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, CustomerNegativeCriterionServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CustomerNegativeCriterionServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC CustomerNegativeCriterionService client.
        /// </summary>
        public virtual CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the criterion to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CustomerNegativeCriterion> GetCustomerNegativeCriterionAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCustomerNegativeCriterionAsync(
                new GetCustomerNegativeCriterionRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the criterion to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CustomerNegativeCriterion> GetCustomerNegativeCriterionAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetCustomerNegativeCriterionAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the criterion to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::CustomerNegativeCriterion GetCustomerNegativeCriterion(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCustomerNegativeCriterion(
                new GetCustomerNegativeCriterionRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested criterion in full detail.
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
        public virtual stt::Task<gagvr::CustomerNegativeCriterion> GetCustomerNegativeCriterionAsync(
            GetCustomerNegativeCriterionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested criterion in full detail.
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
        public virtual stt::Task<gagvr::CustomerNegativeCriterion> GetCustomerNegativeCriterionAsync(
            GetCustomerNegativeCriterionRequest request,
            st::CancellationToken cancellationToken) => GetCustomerNegativeCriterionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested criterion in full detail.
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
        public virtual gagvr::CustomerNegativeCriterion GetCustomerNegativeCriterion(
            GetCustomerNegativeCriterionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="partialFailure">
        /// If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// Default is false.
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
        public virtual stt::Task<MutateCustomerNegativeCriteriaResponse> MutateCustomerNegativeCriteriaAsync(
            string customerId,
            scg::IEnumerable<CustomerNegativeCriterionOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateCustomerNegativeCriteriaAsync(
                new MutateCustomerNegativeCriteriaRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="partialFailure">
        /// If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// Default is false.
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
        public virtual stt::Task<MutateCustomerNegativeCriteriaResponse> MutateCustomerNegativeCriteriaAsync(
            string customerId,
            scg::IEnumerable<CustomerNegativeCriterionOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            st::CancellationToken cancellationToken) => MutateCustomerNegativeCriteriaAsync(
                customerId,
                operations,
                partialFailure,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="partialFailure">
        /// If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// Default is false.
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
        public virtual MutateCustomerNegativeCriteriaResponse MutateCustomerNegativeCriteria(
            string customerId,
            scg::IEnumerable<CustomerNegativeCriterionOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateCustomerNegativeCriteria(
                new MutateCustomerNegativeCriteriaRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCustomerNegativeCriteriaResponse> MutateCustomerNegativeCriteriaAsync(
            string customerId,
            scg::IEnumerable<CustomerNegativeCriterionOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCustomerNegativeCriteriaAsync(
                new MutateCustomerNegativeCriteriaRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCustomerNegativeCriteriaResponse> MutateCustomerNegativeCriteriaAsync(
            string customerId,
            scg::IEnumerable<CustomerNegativeCriterionOperation> operations,
            st::CancellationToken cancellationToken) => MutateCustomerNegativeCriteriaAsync(
                customerId,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateCustomerNegativeCriteriaResponse MutateCustomerNegativeCriteria(
            string customerId,
            scg::IEnumerable<CustomerNegativeCriterionOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCustomerNegativeCriteria(
                new MutateCustomerNegativeCriteriaRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
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
        public virtual stt::Task<MutateCustomerNegativeCriteriaResponse> MutateCustomerNegativeCriteriaAsync(
            MutateCustomerNegativeCriteriaRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
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
        public virtual stt::Task<MutateCustomerNegativeCriteriaResponse> MutateCustomerNegativeCriteriaAsync(
            MutateCustomerNegativeCriteriaRequest request,
            st::CancellationToken cancellationToken) => MutateCustomerNegativeCriteriaAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
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
        public virtual MutateCustomerNegativeCriteriaResponse MutateCustomerNegativeCriteria(
            MutateCustomerNegativeCriteriaRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// CustomerNegativeCriterionService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class CustomerNegativeCriterionServiceClientImpl : CustomerNegativeCriterionServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCustomerNegativeCriterionRequest, gagvr::CustomerNegativeCriterion> _callGetCustomerNegativeCriterion;
        private readonly gaxgrpc::ApiCall<MutateCustomerNegativeCriteriaRequest, MutateCustomerNegativeCriteriaResponse> _callMutateCustomerNegativeCriteria;

        /// <summary>
        /// Constructs a client wrapper for the CustomerNegativeCriterionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CustomerNegativeCriterionServiceSettings"/> used within this client </param>
        public CustomerNegativeCriterionServiceClientImpl(CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient grpcClient, CustomerNegativeCriterionServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CustomerNegativeCriterionServiceSettings effectiveSettings = settings ?? CustomerNegativeCriterionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCustomerNegativeCriterion = clientHelper.BuildApiCall<GetCustomerNegativeCriterionRequest, gagvr::CustomerNegativeCriterion>(
                GrpcClient.GetCustomerNegativeCriterionAsync, GrpcClient.GetCustomerNegativeCriterion, effectiveSettings.GetCustomerNegativeCriterionSettings)
                .WithGoogleRequestParam("resource_name", request => request.ResourceName);
            _callMutateCustomerNegativeCriteria = clientHelper.BuildApiCall<MutateCustomerNegativeCriteriaRequest, MutateCustomerNegativeCriteriaResponse>(
                GrpcClient.MutateCustomerNegativeCriteriaAsync, GrpcClient.MutateCustomerNegativeCriteria, effectiveSettings.MutateCustomerNegativeCriteriaSettings)
                .WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGetCustomerNegativeCriterion);
            Modify_GetCustomerNegativeCriterionApiCall(ref _callGetCustomerNegativeCriterion);
            Modify_ApiCall(ref _callMutateCustomerNegativeCriteria);
            Modify_MutateCustomerNegativeCriteriaApiCall(ref _callMutateCustomerNegativeCriteria);
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
        partial void Modify_GetCustomerNegativeCriterionApiCall(ref gaxgrpc::ApiCall<GetCustomerNegativeCriterionRequest, gagvr::CustomerNegativeCriterion> call);
        partial void Modify_MutateCustomerNegativeCriteriaApiCall(ref gaxgrpc::ApiCall<MutateCustomerNegativeCriteriaRequest, MutateCustomerNegativeCriteriaResponse> call);
        partial void OnConstruction(CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient grpcClient, CustomerNegativeCriterionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC CustomerNegativeCriterionService client.
        /// </summary>
        public override CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetCustomerNegativeCriterionRequest(ref GetCustomerNegativeCriterionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateCustomerNegativeCriteriaRequest(ref MutateCustomerNegativeCriteriaRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested criterion in full detail.
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
        public override stt::Task<gagvr::CustomerNegativeCriterion> GetCustomerNegativeCriterionAsync(
            GetCustomerNegativeCriterionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerNegativeCriterionRequest(ref request, ref callSettings);
            return _callGetCustomerNegativeCriterion.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested criterion in full detail.
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
        public override gagvr::CustomerNegativeCriterion GetCustomerNegativeCriterion(
            GetCustomerNegativeCriterionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerNegativeCriterionRequest(ref request, ref callSettings);
            return _callGetCustomerNegativeCriterion.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
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
        public override stt::Task<MutateCustomerNegativeCriteriaResponse> MutateCustomerNegativeCriteriaAsync(
            MutateCustomerNegativeCriteriaRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerNegativeCriteriaRequest(ref request, ref callSettings);
            return _callMutateCustomerNegativeCriteria.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
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
        public override MutateCustomerNegativeCriteriaResponse MutateCustomerNegativeCriteria(
            MutateCustomerNegativeCriteriaRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerNegativeCriteriaRequest(ref request, ref callSettings);
            return _callMutateCustomerNegativeCriteria.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

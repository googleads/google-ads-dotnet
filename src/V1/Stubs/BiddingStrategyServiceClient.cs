// Copyright 2019 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V1.Resources;
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

namespace Google.Ads.GoogleAds.V1.Services
{
    /// <summary>
    /// Settings for a <see cref="BiddingStrategyServiceClient"/>.
    /// </summary>
    public sealed partial class BiddingStrategyServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="BiddingStrategyServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="BiddingStrategyServiceSettings"/>.
        /// </returns>
        public static BiddingStrategyServiceSettings GetDefault() => new BiddingStrategyServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="BiddingStrategyServiceSettings"/> object with default settings.
        /// </summary>
        public BiddingStrategyServiceSettings() { }

        private BiddingStrategyServiceSettings(BiddingStrategyServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetBiddingStrategySettings = existing.GetBiddingStrategySettings;
            MutateBiddingStrategiesSettings = existing.MutateBiddingStrategiesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BiddingStrategyServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="BiddingStrategyServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="BiddingStrategyServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="BiddingStrategyServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="BiddingStrategyServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="BiddingStrategyServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="BiddingStrategyServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="BiddingStrategyServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="BiddingStrategyServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BiddingStrategyServiceClient.GetBiddingStrategy</c> and <c>BiddingStrategyServiceClient.GetBiddingStrategyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BiddingStrategyServiceClient.GetBiddingStrategy</c> and
        /// <c>BiddingStrategyServiceClient.GetBiddingStrategyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetBiddingStrategySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BiddingStrategyServiceClient.MutateBiddingStrategies</c> and <c>BiddingStrategyServiceClient.MutateBiddingStrategiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BiddingStrategyServiceClient.MutateBiddingStrategies</c> and
        /// <c>BiddingStrategyServiceClient.MutateBiddingStrategiesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings MutateBiddingStrategiesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="BiddingStrategyServiceSettings"/> object.</returns>
        public BiddingStrategyServiceSettings Clone() => new BiddingStrategyServiceSettings(this);
    }

    /// <summary>
    /// BiddingStrategyService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class BiddingStrategyServiceClient
    {
        /// <summary>
        /// The default endpoint for the BiddingStrategyService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default BiddingStrategyService scopes.
        /// </summary>
        /// <remarks>
        /// The default BiddingStrategyService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="BiddingStrategyServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V1.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// BiddingStrategyServiceClient client = await BiddingStrategyServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V1.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     BiddingStrategyServiceClient.DefaultEndpoint.Host, BiddingStrategyServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// BiddingStrategyServiceClient client = BiddingStrategyServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BiddingStrategyServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="BiddingStrategyServiceClient"/>.</returns>
        public static async stt::Task<BiddingStrategyServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, BiddingStrategyServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="BiddingStrategyServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V1.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// BiddingStrategyServiceClient client = BiddingStrategyServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V1.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     BiddingStrategyServiceClient.DefaultEndpoint.Host, BiddingStrategyServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// BiddingStrategyServiceClient client = BiddingStrategyServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BiddingStrategyServiceSettings"/>.</param>
        /// <returns>The created <see cref="BiddingStrategyServiceClient"/>.</returns>
        public static BiddingStrategyServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, BiddingStrategyServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="BiddingStrategyServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BiddingStrategyServiceSettings"/>.</param>
        /// <returns>The created <see cref="BiddingStrategyServiceClient"/>.</returns>
        public static BiddingStrategyServiceClient Create(grpccore::Channel channel, BiddingStrategyServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="BiddingStrategyServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BiddingStrategyServiceSettings"/>.</param>
        /// <returns>The created <see cref="BiddingStrategyServiceClient"/>.</returns>
        public static BiddingStrategyServiceClient Create(grpccore::CallInvoker callInvoker, BiddingStrategyServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BiddingStrategyService.BiddingStrategyServiceClient grpcClient = new BiddingStrategyService.BiddingStrategyServiceClient(callInvoker);
            return new BiddingStrategyServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, BiddingStrategyServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, BiddingStrategyServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, BiddingStrategyServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, BiddingStrategyServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC BiddingStrategyService client.
        /// </summary>
        public virtual BiddingStrategyService.BiddingStrategyServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the bidding strategy to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::BiddingStrategy> GetBiddingStrategyAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetBiddingStrategyAsync(
                new GetBiddingStrategyRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the bidding strategy to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::BiddingStrategy> GetBiddingStrategyAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetBiddingStrategyAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the bidding strategy to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::BiddingStrategy GetBiddingStrategy(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetBiddingStrategy(
                new GetBiddingStrategyRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
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
        public virtual stt::Task<gagvr::BiddingStrategy> GetBiddingStrategyAsync(
            GetBiddingStrategyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
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
        public virtual stt::Task<gagvr::BiddingStrategy> GetBiddingStrategyAsync(
            GetBiddingStrategyRequest request,
            st::CancellationToken cancellationToken) => GetBiddingStrategyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
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
        public virtual gagvr::BiddingStrategy GetBiddingStrategy(
            GetBiddingStrategyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose bidding strategies are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual bidding strategies.
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
        public virtual stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(
            string customerId,
            scg::IEnumerable<BiddingStrategyOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateBiddingStrategiesAsync(
                new MutateBiddingStrategiesRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose bidding strategies are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual bidding strategies.
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
        public virtual stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(
            string customerId,
            scg::IEnumerable<BiddingStrategyOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            st::CancellationToken cancellationToken) => MutateBiddingStrategiesAsync(
                customerId,
                operations,
                partialFailure,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose bidding strategies are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual bidding strategies.
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
        public virtual MutateBiddingStrategiesResponse MutateBiddingStrategies(
            string customerId,
            scg::IEnumerable<BiddingStrategyOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateBiddingStrategies(
                new MutateBiddingStrategiesRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose bidding strategies are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual bidding strategies.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(
            string customerId,
            scg::IEnumerable<BiddingStrategyOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateBiddingStrategiesAsync(
                new MutateBiddingStrategiesRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose bidding strategies are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual bidding strategies.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(
            string customerId,
            scg::IEnumerable<BiddingStrategyOperation> operations,
            st::CancellationToken cancellationToken) => MutateBiddingStrategiesAsync(
                customerId,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose bidding strategies are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual bidding strategies.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateBiddingStrategiesResponse MutateBiddingStrategies(
            string customerId,
            scg::IEnumerable<BiddingStrategyOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateBiddingStrategies(
                new MutateBiddingStrategiesRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
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
        public virtual stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(
            MutateBiddingStrategiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
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
        public virtual stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(
            MutateBiddingStrategiesRequest request,
            st::CancellationToken cancellationToken) => MutateBiddingStrategiesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
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
        public virtual MutateBiddingStrategiesResponse MutateBiddingStrategies(
            MutateBiddingStrategiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// BiddingStrategyService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class BiddingStrategyServiceClientImpl : BiddingStrategyServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetBiddingStrategyRequest, gagvr::BiddingStrategy> _callGetBiddingStrategy;
        private readonly gaxgrpc::ApiCall<MutateBiddingStrategiesRequest, MutateBiddingStrategiesResponse> _callMutateBiddingStrategies;

        /// <summary>
        /// Constructs a client wrapper for the BiddingStrategyService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BiddingStrategyServiceSettings"/> used within this client </param>
        public BiddingStrategyServiceClientImpl(BiddingStrategyService.BiddingStrategyServiceClient grpcClient, BiddingStrategyServiceSettings settings)
        {
            GrpcClient = grpcClient;
            BiddingStrategyServiceSettings effectiveSettings = settings ?? BiddingStrategyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetBiddingStrategy = clientHelper.BuildApiCall<GetBiddingStrategyRequest, gagvr::BiddingStrategy>(
                GrpcClient.GetBiddingStrategyAsync, GrpcClient.GetBiddingStrategy, effectiveSettings.GetBiddingStrategySettings);
            _callMutateBiddingStrategies = clientHelper.BuildApiCall<MutateBiddingStrategiesRequest, MutateBiddingStrategiesResponse>(
                GrpcClient.MutateBiddingStrategiesAsync, GrpcClient.MutateBiddingStrategies, effectiveSettings.MutateBiddingStrategiesSettings);
            Modify_ApiCall(ref _callGetBiddingStrategy);
            Modify_GetBiddingStrategyApiCall(ref _callGetBiddingStrategy);
            Modify_ApiCall(ref _callMutateBiddingStrategies);
            Modify_MutateBiddingStrategiesApiCall(ref _callMutateBiddingStrategies);
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
        partial void Modify_GetBiddingStrategyApiCall(ref gaxgrpc::ApiCall<GetBiddingStrategyRequest, gagvr::BiddingStrategy> call);
        partial void Modify_MutateBiddingStrategiesApiCall(ref gaxgrpc::ApiCall<MutateBiddingStrategiesRequest, MutateBiddingStrategiesResponse> call);
        partial void OnConstruction(BiddingStrategyService.BiddingStrategyServiceClient grpcClient, BiddingStrategyServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC BiddingStrategyService client.
        /// </summary>
        public override BiddingStrategyService.BiddingStrategyServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetBiddingStrategyRequest(ref GetBiddingStrategyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateBiddingStrategiesRequest(ref MutateBiddingStrategiesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
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
        public override stt::Task<gagvr::BiddingStrategy> GetBiddingStrategyAsync(
            GetBiddingStrategyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBiddingStrategyRequest(ref request, ref callSettings);
            return _callGetBiddingStrategy.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
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
        public override gagvr::BiddingStrategy GetBiddingStrategy(
            GetBiddingStrategyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBiddingStrategyRequest(ref request, ref callSettings);
            return _callGetBiddingStrategy.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
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
        public override stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(
            MutateBiddingStrategiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateBiddingStrategiesRequest(ref request, ref callSettings);
            return _callMutateBiddingStrategies.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
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
        public override MutateBiddingStrategiesResponse MutateBiddingStrategies(
            MutateBiddingStrategiesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateBiddingStrategiesRequest(ref request, ref callSettings);
            return _callMutateBiddingStrategies.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

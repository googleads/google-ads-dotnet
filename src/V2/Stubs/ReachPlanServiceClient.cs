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

namespace Google.Ads.GoogleAds.V2.Services
{
    /// <summary>
    /// Settings for a <see cref="ReachPlanServiceClient"/>.
    /// </summary>
    public sealed partial class ReachPlanServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ReachPlanServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ReachPlanServiceSettings"/>.
        /// </returns>
        public static ReachPlanServiceSettings GetDefault() => new ReachPlanServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ReachPlanServiceSettings"/> object with default settings.
        /// </summary>
        public ReachPlanServiceSettings() { }

        private ReachPlanServiceSettings(ReachPlanServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListPlannableLocationsSettings = existing.ListPlannableLocationsSettings;
            ListPlannableProductsSettings = existing.ListPlannableProductsSettings;
            GenerateProductMixIdeasSettings = existing.GenerateProductMixIdeasSettings;
            GenerateReachForecastSettings = existing.GenerateReachForecastSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ReachPlanServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ReachPlanServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="ReachPlanServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ReachPlanServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ReachPlanServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ReachPlanServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="ReachPlanServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ReachPlanServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ReachPlanServiceClient"/> RPC methods is defined as:
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
        /// <c>ReachPlanServiceClient.ListPlannableLocations</c> and <c>ReachPlanServiceClient.ListPlannableLocationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ReachPlanServiceClient.ListPlannableLocations</c> and
        /// <c>ReachPlanServiceClient.ListPlannableLocationsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListPlannableLocationsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachPlanServiceClient.ListPlannableProducts</c> and <c>ReachPlanServiceClient.ListPlannableProductsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ReachPlanServiceClient.ListPlannableProducts</c> and
        /// <c>ReachPlanServiceClient.ListPlannableProductsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListPlannableProductsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachPlanServiceClient.GenerateProductMixIdeas</c> and <c>ReachPlanServiceClient.GenerateProductMixIdeasAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ReachPlanServiceClient.GenerateProductMixIdeas</c> and
        /// <c>ReachPlanServiceClient.GenerateProductMixIdeasAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GenerateProductMixIdeasSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachPlanServiceClient.GenerateReachForecast</c> and <c>ReachPlanServiceClient.GenerateReachForecastAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ReachPlanServiceClient.GenerateReachForecast</c> and
        /// <c>ReachPlanServiceClient.GenerateReachForecastAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GenerateReachForecastSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ReachPlanServiceSettings"/> object.</returns>
        public ReachPlanServiceSettings Clone() => new ReachPlanServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReachPlanServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ReachPlanServiceClientBuilder : gaxgrpc::ClientBuilderBase<ReachPlanServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public ReachPlanServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override ReachPlanServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReachPlanServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<ReachPlanServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReachPlanServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => ReachPlanServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ReachPlanServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReachPlanServiceClient.ChannelPool;
    }

    /// <summary>
    /// ReachPlanService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ReachPlanServiceClient
    {
        /// <summary>
        /// The default endpoint for the ReachPlanService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default ReachPlanService scopes.
        /// </summary>
        /// <remarks>
        /// The default ReachPlanService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="ReachPlanServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V2.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ReachPlanServiceClient client = await ReachPlanServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V2.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ReachPlanServiceClient.DefaultEndpoint.Host, ReachPlanServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ReachPlanServiceClient client = ReachPlanServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ReachPlanServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ReachPlanServiceClient"/>.</returns>
        public static async stt::Task<ReachPlanServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ReachPlanServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ReachPlanServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V2.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ReachPlanServiceClient client = ReachPlanServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V2.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ReachPlanServiceClient.DefaultEndpoint.Host, ReachPlanServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ReachPlanServiceClient client = ReachPlanServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ReachPlanServiceSettings"/>.</param>
        /// <returns>The created <see cref="ReachPlanServiceClient"/>.</returns>
        public static ReachPlanServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, ReachPlanServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ReachPlanServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ReachPlanServiceSettings"/>.</param>
        /// <returns>The created <see cref="ReachPlanServiceClient"/>.</returns>
        public static ReachPlanServiceClient Create(grpccore::Channel channel, ReachPlanServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ReachPlanServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ReachPlanServiceSettings"/>.</param>
        /// <returns>The created <see cref="ReachPlanServiceClient"/>.</returns>
        public static ReachPlanServiceClient Create(grpccore::CallInvoker callInvoker, ReachPlanServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReachPlanService.ReachPlanServiceClient grpcClient = new ReachPlanService.ReachPlanServiceClient(callInvoker);
            return new ReachPlanServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, ReachPlanServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ReachPlanServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, ReachPlanServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ReachPlanServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ReachPlanService client.
        /// </summary>
        public virtual ReachPlanService.ReachPlanServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the list of plannable locations (for example, countries &amp; DMAs).
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
        public virtual stt::Task<ListPlannableLocationsResponse> ListPlannableLocationsAsync(
            ListPlannableLocationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the list of plannable locations (for example, countries &amp; DMAs).
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
        public virtual stt::Task<ListPlannableLocationsResponse> ListPlannableLocationsAsync(
            ListPlannableLocationsRequest request,
            st::CancellationToken cancellationToken) => ListPlannableLocationsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of plannable locations (for example, countries &amp; DMAs).
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
        public virtual ListPlannableLocationsResponse ListPlannableLocations(
            ListPlannableLocationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// </summary>
        /// <param name="plannableLocationId">
        /// The ID of the selected location for planning. To list the available
        /// plannable location ids use ListPlannableLocations.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListPlannableProductsResponse> ListPlannableProductsAsync(
            string plannableLocationId,
            gaxgrpc::CallSettings callSettings = null) => ListPlannableProductsAsync(
                new ListPlannableProductsRequest
                {
                    PlannableLocationId = gax::GaxPreconditions.CheckNotNullOrEmpty(plannableLocationId, nameof(plannableLocationId)),
                },
                callSettings);

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// </summary>
        /// <param name="plannableLocationId">
        /// The ID of the selected location for planning. To list the available
        /// plannable location ids use ListPlannableLocations.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListPlannableProductsResponse> ListPlannableProductsAsync(
            string plannableLocationId,
            st::CancellationToken cancellationToken) => ListPlannableProductsAsync(
                plannableLocationId,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// </summary>
        /// <param name="plannableLocationId">
        /// The ID of the selected location for planning. To list the available
        /// plannable location ids use ListPlannableLocations.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListPlannableProductsResponse ListPlannableProducts(
            string plannableLocationId,
            gaxgrpc::CallSettings callSettings = null) => ListPlannableProducts(
                new ListPlannableProductsRequest
                {
                    PlannableLocationId = gax::GaxPreconditions.CheckNotNullOrEmpty(plannableLocationId, nameof(plannableLocationId)),
                },
                callSettings);

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
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
        public virtual stt::Task<ListPlannableProductsResponse> ListPlannableProductsAsync(
            ListPlannableProductsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
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
        public virtual stt::Task<ListPlannableProductsResponse> ListPlannableProductsAsync(
            ListPlannableProductsRequest request,
            st::CancellationToken cancellationToken) => ListPlannableProductsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
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
        public virtual ListPlannableProductsResponse ListPlannableProducts(
            ListPlannableProductsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Generates a product mix ideas given a set of preferences. This method
        /// helps the advertiser to obtain a good mix of ad formats and budget
        /// allocations based on its preferences.
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
        public virtual stt::Task<GenerateProductMixIdeasResponse> GenerateProductMixIdeasAsync(
            GenerateProductMixIdeasRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Generates a product mix ideas given a set of preferences. This method
        /// helps the advertiser to obtain a good mix of ad formats and budget
        /// allocations based on its preferences.
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
        public virtual stt::Task<GenerateProductMixIdeasResponse> GenerateProductMixIdeasAsync(
            GenerateProductMixIdeasRequest request,
            st::CancellationToken cancellationToken) => GenerateProductMixIdeasAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a product mix ideas given a set of preferences. This method
        /// helps the advertiser to obtain a good mix of ad formats and budget
        /// allocations based on its preferences.
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
        public virtual GenerateProductMixIdeasResponse GenerateProductMixIdeas(
            GenerateProductMixIdeasRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
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
        public virtual stt::Task<GenerateReachForecastResponse> GenerateReachForecastAsync(
            GenerateReachForecastRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
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
        public virtual stt::Task<GenerateReachForecastResponse> GenerateReachForecastAsync(
            GenerateReachForecastRequest request,
            st::CancellationToken cancellationToken) => GenerateReachForecastAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
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
        public virtual GenerateReachForecastResponse GenerateReachForecast(
            GenerateReachForecastRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// ReachPlanService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ReachPlanServiceClientImpl : ReachPlanServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListPlannableLocationsRequest, ListPlannableLocationsResponse> _callListPlannableLocations;
        private readonly gaxgrpc::ApiCall<ListPlannableProductsRequest, ListPlannableProductsResponse> _callListPlannableProducts;
        private readonly gaxgrpc::ApiCall<GenerateProductMixIdeasRequest, GenerateProductMixIdeasResponse> _callGenerateProductMixIdeas;
        private readonly gaxgrpc::ApiCall<GenerateReachForecastRequest, GenerateReachForecastResponse> _callGenerateReachForecast;

        /// <summary>
        /// Constructs a client wrapper for the ReachPlanService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ReachPlanServiceSettings"/> used within this client </param>
        public ReachPlanServiceClientImpl(ReachPlanService.ReachPlanServiceClient grpcClient, ReachPlanServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ReachPlanServiceSettings effectiveSettings = settings ?? ReachPlanServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListPlannableLocations = clientHelper.BuildApiCall<ListPlannableLocationsRequest, ListPlannableLocationsResponse>(
                GrpcClient.ListPlannableLocationsAsync, GrpcClient.ListPlannableLocations, effectiveSettings.ListPlannableLocationsSettings);
            _callListPlannableProducts = clientHelper.BuildApiCall<ListPlannableProductsRequest, ListPlannableProductsResponse>(
                GrpcClient.ListPlannableProductsAsync, GrpcClient.ListPlannableProducts, effectiveSettings.ListPlannableProductsSettings);
            _callGenerateProductMixIdeas = clientHelper.BuildApiCall<GenerateProductMixIdeasRequest, GenerateProductMixIdeasResponse>(
                GrpcClient.GenerateProductMixIdeasAsync, GrpcClient.GenerateProductMixIdeas, effectiveSettings.GenerateProductMixIdeasSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"customer_id={request.CustomerId}"));
            _callGenerateReachForecast = clientHelper.BuildApiCall<GenerateReachForecastRequest, GenerateReachForecastResponse>(
                GrpcClient.GenerateReachForecastAsync, GrpcClient.GenerateReachForecast, effectiveSettings.GenerateReachForecastSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"customer_id={request.CustomerId}"));
            Modify_ApiCall(ref _callListPlannableLocations);
            Modify_ListPlannableLocationsApiCall(ref _callListPlannableLocations);
            Modify_ApiCall(ref _callListPlannableProducts);
            Modify_ListPlannableProductsApiCall(ref _callListPlannableProducts);
            Modify_ApiCall(ref _callGenerateProductMixIdeas);
            Modify_GenerateProductMixIdeasApiCall(ref _callGenerateProductMixIdeas);
            Modify_ApiCall(ref _callGenerateReachForecast);
            Modify_GenerateReachForecastApiCall(ref _callGenerateReachForecast);
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
        partial void Modify_ListPlannableLocationsApiCall(ref gaxgrpc::ApiCall<ListPlannableLocationsRequest, ListPlannableLocationsResponse> call);
        partial void Modify_ListPlannableProductsApiCall(ref gaxgrpc::ApiCall<ListPlannableProductsRequest, ListPlannableProductsResponse> call);
        partial void Modify_GenerateProductMixIdeasApiCall(ref gaxgrpc::ApiCall<GenerateProductMixIdeasRequest, GenerateProductMixIdeasResponse> call);
        partial void Modify_GenerateReachForecastApiCall(ref gaxgrpc::ApiCall<GenerateReachForecastRequest, GenerateReachForecastResponse> call);
        partial void OnConstruction(ReachPlanService.ReachPlanServiceClient grpcClient, ReachPlanServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ReachPlanService client.
        /// </summary>
        public override ReachPlanService.ReachPlanServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListPlannableLocationsRequest(ref ListPlannableLocationsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListPlannableProductsRequest(ref ListPlannableProductsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GenerateProductMixIdeasRequest(ref GenerateProductMixIdeasRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GenerateReachForecastRequest(ref GenerateReachForecastRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of plannable locations (for example, countries &amp; DMAs).
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
        public override stt::Task<ListPlannableLocationsResponse> ListPlannableLocationsAsync(
            ListPlannableLocationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlannableLocationsRequest(ref request, ref callSettings);
            return _callListPlannableLocations.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of plannable locations (for example, countries &amp; DMAs).
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
        public override ListPlannableLocationsResponse ListPlannableLocations(
            ListPlannableLocationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlannableLocationsRequest(ref request, ref callSettings);
            return _callListPlannableLocations.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
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
        public override stt::Task<ListPlannableProductsResponse> ListPlannableProductsAsync(
            ListPlannableProductsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlannableProductsRequest(ref request, ref callSettings);
            return _callListPlannableProducts.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
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
        public override ListPlannableProductsResponse ListPlannableProducts(
            ListPlannableProductsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlannableProductsRequest(ref request, ref callSettings);
            return _callListPlannableProducts.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates a product mix ideas given a set of preferences. This method
        /// helps the advertiser to obtain a good mix of ad formats and budget
        /// allocations based on its preferences.
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
        public override stt::Task<GenerateProductMixIdeasResponse> GenerateProductMixIdeasAsync(
            GenerateProductMixIdeasRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateProductMixIdeasRequest(ref request, ref callSettings);
            return _callGenerateProductMixIdeas.Async(request, callSettings);
        }

        /// <summary>
        /// Generates a product mix ideas given a set of preferences. This method
        /// helps the advertiser to obtain a good mix of ad formats and budget
        /// allocations based on its preferences.
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
        public override GenerateProductMixIdeasResponse GenerateProductMixIdeas(
            GenerateProductMixIdeasRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateProductMixIdeasRequest(ref request, ref callSettings);
            return _callGenerateProductMixIdeas.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
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
        public override stt::Task<GenerateReachForecastResponse> GenerateReachForecastAsync(
            GenerateReachForecastRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateReachForecastRequest(ref request, ref callSettings);
            return _callGenerateReachForecast.Async(request, callSettings);
        }

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
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
        public override GenerateReachForecastResponse GenerateReachForecast(
            GenerateReachForecastRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateReachForecastRequest(ref request, ref callSettings);
            return _callGenerateReachForecast.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

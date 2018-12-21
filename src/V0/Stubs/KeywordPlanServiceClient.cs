// Copyright 2018 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V0.Resources;
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

namespace Google.Ads.GoogleAds.V0.Services
{
    /// <summary>
    /// Settings for a <see cref="KeywordPlanServiceClient"/>.
    /// </summary>
    public sealed partial class KeywordPlanServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="KeywordPlanServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="KeywordPlanServiceSettings"/>.
        /// </returns>
        public static KeywordPlanServiceSettings GetDefault() => new KeywordPlanServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="KeywordPlanServiceSettings"/> object with default settings.
        /// </summary>
        public KeywordPlanServiceSettings() { }

        private KeywordPlanServiceSettings(KeywordPlanServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetKeywordPlanSettings = existing.GetKeywordPlanSettings;
            MutateKeywordPlansSettings = existing.MutateKeywordPlansSettings;
            GenerateForecastMetricsSettings = existing.GenerateForecastMetricsSettings;
            GenerateHistoricalMetricsSettings = existing.GenerateHistoricalMetricsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(KeywordPlanServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="KeywordPlanServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="KeywordPlanServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="KeywordPlanServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="KeywordPlanServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="KeywordPlanServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="KeywordPlanServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="KeywordPlanServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="KeywordPlanServiceClient"/> RPC methods is defined as:
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
        /// <c>KeywordPlanServiceClient.GetKeywordPlan</c> and <c>KeywordPlanServiceClient.GetKeywordPlanAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeywordPlanServiceClient.GetKeywordPlan</c> and
        /// <c>KeywordPlanServiceClient.GetKeywordPlanAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetKeywordPlanSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanServiceClient.MutateKeywordPlans</c> and <c>KeywordPlanServiceClient.MutateKeywordPlansAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeywordPlanServiceClient.MutateKeywordPlans</c> and
        /// <c>KeywordPlanServiceClient.MutateKeywordPlansAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings MutateKeywordPlansSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanServiceClient.GenerateForecastMetrics</c> and <c>KeywordPlanServiceClient.GenerateForecastMetricsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeywordPlanServiceClient.GenerateForecastMetrics</c> and
        /// <c>KeywordPlanServiceClient.GenerateForecastMetricsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GenerateForecastMetricsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanServiceClient.GenerateHistoricalMetrics</c> and <c>KeywordPlanServiceClient.GenerateHistoricalMetricsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeywordPlanServiceClient.GenerateHistoricalMetrics</c> and
        /// <c>KeywordPlanServiceClient.GenerateHistoricalMetricsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GenerateHistoricalMetricsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="KeywordPlanServiceSettings"/> object.</returns>
        public KeywordPlanServiceSettings Clone() => new KeywordPlanServiceSettings(this);
    }

    /// <summary>
    /// KeywordPlanService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class KeywordPlanServiceClient
    {
        /// <summary>
        /// The default endpoint for the KeywordPlanService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default KeywordPlanService scopes.
        /// </summary>
        /// <remarks>
        /// The default KeywordPlanService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="KeywordPlanServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V0.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// KeywordPlanServiceClient client = await KeywordPlanServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V0.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     KeywordPlanServiceClient.DefaultEndpoint.Host, KeywordPlanServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// KeywordPlanServiceClient client = KeywordPlanServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="KeywordPlanServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="KeywordPlanServiceClient"/>.</returns>
        public static async stt::Task<KeywordPlanServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, KeywordPlanServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="KeywordPlanServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V0.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// KeywordPlanServiceClient client = KeywordPlanServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V0.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     KeywordPlanServiceClient.DefaultEndpoint.Host, KeywordPlanServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// KeywordPlanServiceClient client = KeywordPlanServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="KeywordPlanServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeywordPlanServiceClient"/>.</returns>
        public static KeywordPlanServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, KeywordPlanServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="KeywordPlanServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="KeywordPlanServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeywordPlanServiceClient"/>.</returns>
        public static KeywordPlanServiceClient Create(grpccore::Channel channel, KeywordPlanServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="KeywordPlanServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="KeywordPlanServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeywordPlanServiceClient"/>.</returns>
        public static KeywordPlanServiceClient Create(grpccore::CallInvoker callInvoker, KeywordPlanServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            KeywordPlanService.KeywordPlanServiceClient grpcClient = new KeywordPlanService.KeywordPlanServiceClient(callInvoker);
            return new KeywordPlanServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, KeywordPlanServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, KeywordPlanServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, KeywordPlanServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, KeywordPlanServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC KeywordPlanService client.
        /// </summary>
        public virtual KeywordPlanService.KeywordPlanServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the plan to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::KeywordPlan> GetKeywordPlanAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetKeywordPlanAsync(
                new GetKeywordPlanRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the plan to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::KeywordPlan> GetKeywordPlanAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetKeywordPlanAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the plan to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::KeywordPlan GetKeywordPlan(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetKeywordPlan(
                new GetKeywordPlanRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested plan in full detail.
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
        public virtual stt::Task<gagvr::KeywordPlan> GetKeywordPlanAsync(
            GetKeywordPlanRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested plan in full detail.
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
        public virtual stt::Task<gagvr::KeywordPlan> GetKeywordPlanAsync(
            GetKeywordPlanRequest request,
            st::CancellationToken cancellationToken) => GetKeywordPlanAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested plan in full detail.
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
        public virtual gagvr::KeywordPlan GetKeywordPlan(
            GetKeywordPlanRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes keyword plans. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose keyword plans are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual keyword plans.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateKeywordPlansResponse> MutateKeywordPlansAsync(
            string customerId,
            scg::IEnumerable<KeywordPlanOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlansAsync(
                new MutateKeywordPlansRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes keyword plans. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose keyword plans are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual keyword plans.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateKeywordPlansResponse> MutateKeywordPlansAsync(
            string customerId,
            scg::IEnumerable<KeywordPlanOperation> operations,
            st::CancellationToken cancellationToken) => MutateKeywordPlansAsync(
                customerId,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes keyword plans. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose keyword plans are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual keyword plans.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateKeywordPlansResponse MutateKeywordPlans(
            string customerId,
            scg::IEnumerable<KeywordPlanOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlans(
                new MutateKeywordPlansRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes keyword plans. Operation statuses are
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
        public virtual stt::Task<MutateKeywordPlansResponse> MutateKeywordPlansAsync(
            MutateKeywordPlansRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes keyword plans. Operation statuses are
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
        public virtual stt::Task<MutateKeywordPlansResponse> MutateKeywordPlansAsync(
            MutateKeywordPlansRequest request,
            st::CancellationToken cancellationToken) => MutateKeywordPlansAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes keyword plans. Operation statuses are
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
        public virtual MutateKeywordPlansResponse MutateKeywordPlans(
            MutateKeywordPlansRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
        /// </summary>
        /// <param name="keywordPlan">
        /// The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GenerateForecastMetricsResponse> GenerateForecastMetricsAsync(
            string keywordPlan,
            gaxgrpc::CallSettings callSettings = null) => GenerateForecastMetricsAsync(
                new GenerateForecastMetricsRequest
                {
                    KeywordPlan = gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlan, nameof(keywordPlan)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
        /// </summary>
        /// <param name="keywordPlan">
        /// The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GenerateForecastMetricsResponse> GenerateForecastMetricsAsync(
            string keywordPlan,
            st::CancellationToken cancellationToken) => GenerateForecastMetricsAsync(
                keywordPlan,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
        /// </summary>
        /// <param name="keywordPlan">
        /// The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual GenerateForecastMetricsResponse GenerateForecastMetrics(
            string keywordPlan,
            gaxgrpc::CallSettings callSettings = null) => GenerateForecastMetrics(
                new GenerateForecastMetricsRequest
                {
                    KeywordPlan = gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlan, nameof(keywordPlan)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
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
        public virtual stt::Task<GenerateForecastMetricsResponse> GenerateForecastMetricsAsync(
            GenerateForecastMetricsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
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
        public virtual stt::Task<GenerateForecastMetricsResponse> GenerateForecastMetricsAsync(
            GenerateForecastMetricsRequest request,
            st::CancellationToken cancellationToken) => GenerateForecastMetricsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
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
        public virtual GenerateForecastMetricsResponse GenerateForecastMetrics(
            GenerateForecastMetricsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
        /// </summary>
        /// <param name="keywordPlan">
        /// The resource name of the keyword plan of which historical metrics are
        /// requested.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GenerateHistoricalMetricsResponse> GenerateHistoricalMetricsAsync(
            string keywordPlan,
            gaxgrpc::CallSettings callSettings = null) => GenerateHistoricalMetricsAsync(
                new GenerateHistoricalMetricsRequest
                {
                    KeywordPlan = gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlan, nameof(keywordPlan)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
        /// </summary>
        /// <param name="keywordPlan">
        /// The resource name of the keyword plan of which historical metrics are
        /// requested.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GenerateHistoricalMetricsResponse> GenerateHistoricalMetricsAsync(
            string keywordPlan,
            st::CancellationToken cancellationToken) => GenerateHistoricalMetricsAsync(
                keywordPlan,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
        /// </summary>
        /// <param name="keywordPlan">
        /// The resource name of the keyword plan of which historical metrics are
        /// requested.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual GenerateHistoricalMetricsResponse GenerateHistoricalMetrics(
            string keywordPlan,
            gaxgrpc::CallSettings callSettings = null) => GenerateHistoricalMetrics(
                new GenerateHistoricalMetricsRequest
                {
                    KeywordPlan = gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlan, nameof(keywordPlan)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
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
        public virtual stt::Task<GenerateHistoricalMetricsResponse> GenerateHistoricalMetricsAsync(
            GenerateHistoricalMetricsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
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
        public virtual stt::Task<GenerateHistoricalMetricsResponse> GenerateHistoricalMetricsAsync(
            GenerateHistoricalMetricsRequest request,
            st::CancellationToken cancellationToken) => GenerateHistoricalMetricsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
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
        public virtual GenerateHistoricalMetricsResponse GenerateHistoricalMetrics(
            GenerateHistoricalMetricsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// KeywordPlanService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class KeywordPlanServiceClientImpl : KeywordPlanServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetKeywordPlanRequest, gagvr::KeywordPlan> _callGetKeywordPlan;
        private readonly gaxgrpc::ApiCall<MutateKeywordPlansRequest, MutateKeywordPlansResponse> _callMutateKeywordPlans;
        private readonly gaxgrpc::ApiCall<GenerateForecastMetricsRequest, GenerateForecastMetricsResponse> _callGenerateForecastMetrics;
        private readonly gaxgrpc::ApiCall<GenerateHistoricalMetricsRequest, GenerateHistoricalMetricsResponse> _callGenerateHistoricalMetrics;

        /// <summary>
        /// Constructs a client wrapper for the KeywordPlanService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="KeywordPlanServiceSettings"/> used within this client </param>
        public KeywordPlanServiceClientImpl(KeywordPlanService.KeywordPlanServiceClient grpcClient, KeywordPlanServiceSettings settings)
        {
            GrpcClient = grpcClient;
            KeywordPlanServiceSettings effectiveSettings = settings ?? KeywordPlanServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetKeywordPlan = clientHelper.BuildApiCall<GetKeywordPlanRequest, gagvr::KeywordPlan>(
                GrpcClient.GetKeywordPlanAsync, GrpcClient.GetKeywordPlan, effectiveSettings.GetKeywordPlanSettings);
            _callMutateKeywordPlans = clientHelper.BuildApiCall<MutateKeywordPlansRequest, MutateKeywordPlansResponse>(
                GrpcClient.MutateKeywordPlansAsync, GrpcClient.MutateKeywordPlans, effectiveSettings.MutateKeywordPlansSettings);
            _callGenerateForecastMetrics = clientHelper.BuildApiCall<GenerateForecastMetricsRequest, GenerateForecastMetricsResponse>(
                GrpcClient.GenerateForecastMetricsAsync, GrpcClient.GenerateForecastMetrics, effectiveSettings.GenerateForecastMetricsSettings);
            _callGenerateHistoricalMetrics = clientHelper.BuildApiCall<GenerateHistoricalMetricsRequest, GenerateHistoricalMetricsResponse>(
                GrpcClient.GenerateHistoricalMetricsAsync, GrpcClient.GenerateHistoricalMetrics, effectiveSettings.GenerateHistoricalMetricsSettings);
            Modify_ApiCall(ref _callGetKeywordPlan);
            Modify_GetKeywordPlanApiCall(ref _callGetKeywordPlan);
            Modify_ApiCall(ref _callMutateKeywordPlans);
            Modify_MutateKeywordPlansApiCall(ref _callMutateKeywordPlans);
            Modify_ApiCall(ref _callGenerateForecastMetrics);
            Modify_GenerateForecastMetricsApiCall(ref _callGenerateForecastMetrics);
            Modify_ApiCall(ref _callGenerateHistoricalMetrics);
            Modify_GenerateHistoricalMetricsApiCall(ref _callGenerateHistoricalMetrics);
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
        partial void Modify_GetKeywordPlanApiCall(ref gaxgrpc::ApiCall<GetKeywordPlanRequest, gagvr::KeywordPlan> call);
        partial void Modify_MutateKeywordPlansApiCall(ref gaxgrpc::ApiCall<MutateKeywordPlansRequest, MutateKeywordPlansResponse> call);
        partial void Modify_GenerateForecastMetricsApiCall(ref gaxgrpc::ApiCall<GenerateForecastMetricsRequest, GenerateForecastMetricsResponse> call);
        partial void Modify_GenerateHistoricalMetricsApiCall(ref gaxgrpc::ApiCall<GenerateHistoricalMetricsRequest, GenerateHistoricalMetricsResponse> call);
        partial void OnConstruction(KeywordPlanService.KeywordPlanServiceClient grpcClient, KeywordPlanServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC KeywordPlanService client.
        /// </summary>
        public override KeywordPlanService.KeywordPlanServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetKeywordPlanRequest(ref GetKeywordPlanRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateKeywordPlansRequest(ref MutateKeywordPlansRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GenerateForecastMetricsRequest(ref GenerateForecastMetricsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GenerateHistoricalMetricsRequest(ref GenerateHistoricalMetricsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested plan in full detail.
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
        public override stt::Task<gagvr::KeywordPlan> GetKeywordPlanAsync(
            GetKeywordPlanRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanRequest(ref request, ref callSettings);
            return _callGetKeywordPlan.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested plan in full detail.
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
        public override gagvr::KeywordPlan GetKeywordPlan(
            GetKeywordPlanRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanRequest(ref request, ref callSettings);
            return _callGetKeywordPlan.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes keyword plans. Operation statuses are
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
        public override stt::Task<MutateKeywordPlansResponse> MutateKeywordPlansAsync(
            MutateKeywordPlansRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlansRequest(ref request, ref callSettings);
            return _callMutateKeywordPlans.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes keyword plans. Operation statuses are
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
        public override MutateKeywordPlansResponse MutateKeywordPlans(
            MutateKeywordPlansRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlansRequest(ref request, ref callSettings);
            return _callMutateKeywordPlans.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
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
        public override stt::Task<GenerateForecastMetricsResponse> GenerateForecastMetricsAsync(
            GenerateForecastMetricsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateForecastMetricsRequest(ref request, ref callSettings);
            return _callGenerateForecastMetrics.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
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
        public override GenerateForecastMetricsResponse GenerateForecastMetrics(
            GenerateForecastMetricsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateForecastMetricsRequest(ref request, ref callSettings);
            return _callGenerateForecastMetrics.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
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
        public override stt::Task<GenerateHistoricalMetricsResponse> GenerateHistoricalMetricsAsync(
            GenerateHistoricalMetricsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateHistoricalMetricsRequest(ref request, ref callSettings);
            return _callGenerateHistoricalMetrics.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
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
        public override GenerateHistoricalMetricsResponse GenerateHistoricalMetrics(
            GenerateHistoricalMetricsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateHistoricalMetricsRequest(ref request, ref callSettings);
            return _callGenerateHistoricalMetrics.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

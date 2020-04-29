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
using lro = Google.LongRunning;
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
    /// Settings for a <see cref="OfflineUserDataJobServiceClient"/>.
    /// </summary>
    public sealed partial class OfflineUserDataJobServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="OfflineUserDataJobServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="OfflineUserDataJobServiceSettings"/>.
        /// </returns>
        public static OfflineUserDataJobServiceSettings GetDefault() => new OfflineUserDataJobServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="OfflineUserDataJobServiceSettings"/> object with default settings.
        /// </summary>
        public OfflineUserDataJobServiceSettings() { }

        private OfflineUserDataJobServiceSettings(OfflineUserDataJobServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateOfflineUserDataJobSettings = existing.CreateOfflineUserDataJobSettings;
            GetOfflineUserDataJobSettings = existing.GetOfflineUserDataJobSettings;
            AddOfflineUserDataJobOperationsSettings = existing.AddOfflineUserDataJobOperationsSettings;
            RunOfflineUserDataJobSettings = existing.RunOfflineUserDataJobSettings;
            RunOfflineUserDataJobOperationsSettings = existing.RunOfflineUserDataJobOperationsSettings?.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(OfflineUserDataJobServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="OfflineUserDataJobServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="OfflineUserDataJobServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="OfflineUserDataJobServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="OfflineUserDataJobServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="OfflineUserDataJobServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="OfflineUserDataJobServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="OfflineUserDataJobServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="OfflineUserDataJobServiceClient"/> RPC methods is defined as:
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
        /// <c>OfflineUserDataJobServiceClient.CreateOfflineUserDataJob</c> and <c>OfflineUserDataJobServiceClient.CreateOfflineUserDataJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>OfflineUserDataJobServiceClient.CreateOfflineUserDataJob</c> and
        /// <c>OfflineUserDataJobServiceClient.CreateOfflineUserDataJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateOfflineUserDataJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OfflineUserDataJobServiceClient.GetOfflineUserDataJob</c> and <c>OfflineUserDataJobServiceClient.GetOfflineUserDataJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>OfflineUserDataJobServiceClient.GetOfflineUserDataJob</c> and
        /// <c>OfflineUserDataJobServiceClient.GetOfflineUserDataJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetOfflineUserDataJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OfflineUserDataJobServiceClient.AddOfflineUserDataJobOperations</c> and <c>OfflineUserDataJobServiceClient.AddOfflineUserDataJobOperationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>OfflineUserDataJobServiceClient.AddOfflineUserDataJobOperations</c> and
        /// <c>OfflineUserDataJobServiceClient.AddOfflineUserDataJobOperationsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings AddOfflineUserDataJobOperationsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OfflineUserDataJobServiceClient.RunOfflineUserDataJob</c> and <c>OfflineUserDataJobServiceClient.RunOfflineUserDataJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>OfflineUserDataJobServiceClient.RunOfflineUserDataJob</c> and
        /// <c>OfflineUserDataJobServiceClient.RunOfflineUserDataJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings RunOfflineUserDataJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>OfflineUserDataJobServiceClient.RunOfflineUserDataJob</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 300000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.25</description></item>
        /// <item><description>Maximum delay: 3600000 milliseconds</description></item>
        /// <item><description>Total timeout: 43200000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings RunOfflineUserDataJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(43200000L)),
                sys::TimeSpan.FromMilliseconds(300000L),
                1.25,
                sys::TimeSpan.FromMilliseconds(3600000L))
        };

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="OfflineUserDataJobServiceSettings"/> object.</returns>
        public OfflineUserDataJobServiceSettings Clone() => new OfflineUserDataJobServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OfflineUserDataJobServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class OfflineUserDataJobServiceClientBuilder : gaxgrpc::ClientBuilderBase<OfflineUserDataJobServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public OfflineUserDataJobServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override OfflineUserDataJobServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OfflineUserDataJobServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<OfflineUserDataJobServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OfflineUserDataJobServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => OfflineUserDataJobServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => OfflineUserDataJobServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => OfflineUserDataJobServiceClient.ChannelPool;
    }

    /// <summary>
    /// OfflineUserDataJobService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class OfflineUserDataJobServiceClient
    {
        /// <summary>
        /// The default endpoint for the OfflineUserDataJobService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default OfflineUserDataJobService scopes.
        /// </summary>
        /// <remarks>
        /// The default OfflineUserDataJobService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="OfflineUserDataJobServiceClient"/>, applying defaults for all unspecified settings,
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
        /// OfflineUserDataJobServiceClient client = await OfflineUserDataJobServiceClient.CreateAsync();
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
        ///     OfflineUserDataJobServiceClient.DefaultEndpoint.Host, OfflineUserDataJobServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// OfflineUserDataJobServiceClient client = OfflineUserDataJobServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="OfflineUserDataJobServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="OfflineUserDataJobServiceClient"/>.</returns>
        public static async stt::Task<OfflineUserDataJobServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, OfflineUserDataJobServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="OfflineUserDataJobServiceClient"/>, applying defaults for all unspecified settings,
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
        /// OfflineUserDataJobServiceClient client = OfflineUserDataJobServiceClient.Create();
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
        ///     OfflineUserDataJobServiceClient.DefaultEndpoint.Host, OfflineUserDataJobServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// OfflineUserDataJobServiceClient client = OfflineUserDataJobServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="OfflineUserDataJobServiceSettings"/>.</param>
        /// <returns>The created <see cref="OfflineUserDataJobServiceClient"/>.</returns>
        public static OfflineUserDataJobServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, OfflineUserDataJobServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="OfflineUserDataJobServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="OfflineUserDataJobServiceSettings"/>.</param>
        /// <returns>The created <see cref="OfflineUserDataJobServiceClient"/>.</returns>
        public static OfflineUserDataJobServiceClient Create(grpccore::Channel channel, OfflineUserDataJobServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="OfflineUserDataJobServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="OfflineUserDataJobServiceSettings"/>.</param>
        /// <returns>The created <see cref="OfflineUserDataJobServiceClient"/>.</returns>
        public static OfflineUserDataJobServiceClient Create(grpccore::CallInvoker callInvoker, OfflineUserDataJobServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OfflineUserDataJobService.OfflineUserDataJobServiceClient grpcClient = new OfflineUserDataJobService.OfflineUserDataJobServiceClient(callInvoker);
            return new OfflineUserDataJobServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, OfflineUserDataJobServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, OfflineUserDataJobServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, OfflineUserDataJobServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, OfflineUserDataJobServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC OfflineUserDataJobService client.
        /// </summary>
        public virtual OfflineUserDataJobService.OfflineUserDataJobServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Creates an offline user data job.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which to create an offline user data job.
        /// </param>
        /// <param name="job">
        /// Required. The offline user data job to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CreateOfflineUserDataJobResponse> CreateOfflineUserDataJobAsync(
            string customerId,
            gagvr::OfflineUserDataJob job,
            gaxgrpc::CallSettings callSettings = null) => CreateOfflineUserDataJobAsync(
                new CreateOfflineUserDataJobRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                },
                callSettings);

        /// <summary>
        /// Creates an offline user data job.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which to create an offline user data job.
        /// </param>
        /// <param name="job">
        /// Required. The offline user data job to be created.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CreateOfflineUserDataJobResponse> CreateOfflineUserDataJobAsync(
            string customerId,
            gagvr::OfflineUserDataJob job,
            st::CancellationToken cancellationToken) => CreateOfflineUserDataJobAsync(
                customerId,
                job,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an offline user data job.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which to create an offline user data job.
        /// </param>
        /// <param name="job">
        /// Required. The offline user data job to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CreateOfflineUserDataJobResponse CreateOfflineUserDataJob(
            string customerId,
            gagvr::OfflineUserDataJob job,
            gaxgrpc::CallSettings callSettings = null) => CreateOfflineUserDataJob(
                new CreateOfflineUserDataJobRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
                },
                callSettings);

        /// <summary>
        /// Creates an offline user data job.
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
        public virtual stt::Task<CreateOfflineUserDataJobResponse> CreateOfflineUserDataJobAsync(
            CreateOfflineUserDataJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates an offline user data job.
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
        public virtual stt::Task<CreateOfflineUserDataJobResponse> CreateOfflineUserDataJobAsync(
            CreateOfflineUserDataJobRequest request,
            st::CancellationToken cancellationToken) => CreateOfflineUserDataJobAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an offline user data job.
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
        public virtual CreateOfflineUserDataJobResponse CreateOfflineUserDataJob(
            CreateOfflineUserDataJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::OfflineUserDataJob> GetOfflineUserDataJobAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetOfflineUserDataJobAsync(
                new GetOfflineUserDataJobRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to get.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::OfflineUserDataJob> GetOfflineUserDataJobAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetOfflineUserDataJobAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::OfflineUserDataJob GetOfflineUserDataJob(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetOfflineUserDataJob(
                new GetOfflineUserDataJobRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the offline user data job.
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
        public virtual stt::Task<gagvr::OfflineUserDataJob> GetOfflineUserDataJobAsync(
            GetOfflineUserDataJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the offline user data job.
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
        public virtual stt::Task<gagvr::OfflineUserDataJob> GetOfflineUserDataJobAsync(
            GetOfflineUserDataJobRequest request,
            st::CancellationToken cancellationToken) => GetOfflineUserDataJobAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the offline user data job.
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
        public virtual gagvr::OfflineUserDataJob GetOfflineUserDataJob(
            GetOfflineUserDataJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Adds operations to the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob.
        /// </param>
        /// <param name="enablePartialFailure">
        /// True to enable partial failure for the offline user data job.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to be done.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AddOfflineUserDataJobOperationsResponse> AddOfflineUserDataJobOperationsAsync(
            string resourceName,
            bool? enablePartialFailure,
            scg::IEnumerable<OfflineUserDataJobOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => AddOfflineUserDataJobOperationsAsync(
                new AddOfflineUserDataJobOperationsRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                    EnablePartialFailure = enablePartialFailure ?? throw new sys::ArgumentNullException(nameof(enablePartialFailure)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Adds operations to the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob.
        /// </param>
        /// <param name="enablePartialFailure">
        /// True to enable partial failure for the offline user data job.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to be done.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AddOfflineUserDataJobOperationsResponse> AddOfflineUserDataJobOperationsAsync(
            string resourceName,
            bool? enablePartialFailure,
            scg::IEnumerable<OfflineUserDataJobOperation> operations,
            st::CancellationToken cancellationToken) => AddOfflineUserDataJobOperationsAsync(
                resourceName,
                enablePartialFailure,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds operations to the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob.
        /// </param>
        /// <param name="enablePartialFailure">
        /// True to enable partial failure for the offline user data job.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to be done.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AddOfflineUserDataJobOperationsResponse AddOfflineUserDataJobOperations(
            string resourceName,
            bool? enablePartialFailure,
            scg::IEnumerable<OfflineUserDataJobOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => AddOfflineUserDataJobOperations(
                new AddOfflineUserDataJobOperationsRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                    EnablePartialFailure = enablePartialFailure ?? throw new sys::ArgumentNullException(nameof(enablePartialFailure)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Adds operations to the offline user data job.
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
        public virtual stt::Task<AddOfflineUserDataJobOperationsResponse> AddOfflineUserDataJobOperationsAsync(
            AddOfflineUserDataJobOperationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Adds operations to the offline user data job.
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
        public virtual stt::Task<AddOfflineUserDataJobOperationsResponse> AddOfflineUserDataJobOperationsAsync(
            AddOfflineUserDataJobOperationsRequest request,
            st::CancellationToken cancellationToken) => AddOfflineUserDataJobOperationsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds operations to the offline user data job.
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
        public virtual AddOfflineUserDataJobOperationsResponse AddOfflineUserDataJobOperations(
            AddOfflineUserDataJobOperationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Runs the offline user data job.
        ///
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to run.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Empty>> RunOfflineUserDataJobAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => RunOfflineUserDataJobAsync(
                new RunOfflineUserDataJobRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Runs the offline user data job.
        ///
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to run.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Empty>> RunOfflineUserDataJobAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => RunOfflineUserDataJobAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs the offline user data job.
        ///
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to run.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Empty> RunOfflineUserDataJob(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => RunOfflineUserDataJob(
                new RunOfflineUserDataJobRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Runs the offline user data job.
        ///
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Empty>> RunOfflineUserDataJobAsync(
            RunOfflineUserDataJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunOfflineUserDataJobAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Empty>> PollOnceRunOfflineUserDataJobAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Empty>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                RunOfflineUserDataJobOperationsClient,
                callSettings);

        /// <summary>
        /// Runs the offline user data job.
        ///
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
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
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Empty> RunOfflineUserDataJob(
            RunOfflineUserDataJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>RunOfflineUserDataJob</c>.
        /// </summary>
        public virtual lro::OperationsClient RunOfflineUserDataJobOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunOfflineUserDataJob</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Empty> PollOnceRunOfflineUserDataJob(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Empty>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                RunOfflineUserDataJobOperationsClient,
                callSettings);

    }

    /// <summary>
    /// OfflineUserDataJobService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class OfflineUserDataJobServiceClientImpl : OfflineUserDataJobServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateOfflineUserDataJobRequest, CreateOfflineUserDataJobResponse> _callCreateOfflineUserDataJob;
        private readonly gaxgrpc::ApiCall<GetOfflineUserDataJobRequest, gagvr::OfflineUserDataJob> _callGetOfflineUserDataJob;
        private readonly gaxgrpc::ApiCall<AddOfflineUserDataJobOperationsRequest, AddOfflineUserDataJobOperationsResponse> _callAddOfflineUserDataJobOperations;
        private readonly gaxgrpc::ApiCall<RunOfflineUserDataJobRequest, lro::Operation> _callRunOfflineUserDataJob;

        /// <summary>
        /// Constructs a client wrapper for the OfflineUserDataJobService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="OfflineUserDataJobServiceSettings"/> used within this client </param>
        public OfflineUserDataJobServiceClientImpl(OfflineUserDataJobService.OfflineUserDataJobServiceClient grpcClient, OfflineUserDataJobServiceSettings settings)
        {
            GrpcClient = grpcClient;
            OfflineUserDataJobServiceSettings effectiveSettings = settings ?? OfflineUserDataJobServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            RunOfflineUserDataJobOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.RunOfflineUserDataJobOperationsSettings);
            _callCreateOfflineUserDataJob = clientHelper.BuildApiCall<CreateOfflineUserDataJobRequest, CreateOfflineUserDataJobResponse>(
                GrpcClient.CreateOfflineUserDataJobAsync, GrpcClient.CreateOfflineUserDataJob, effectiveSettings.CreateOfflineUserDataJobSettings)
                .WithGoogleRequestParam("customer_id", request => request.CustomerId);
            _callGetOfflineUserDataJob = clientHelper.BuildApiCall<GetOfflineUserDataJobRequest, gagvr::OfflineUserDataJob>(
                GrpcClient.GetOfflineUserDataJobAsync, GrpcClient.GetOfflineUserDataJob, effectiveSettings.GetOfflineUserDataJobSettings)
                .WithGoogleRequestParam("resource_name", request => request.ResourceName);
            _callAddOfflineUserDataJobOperations = clientHelper.BuildApiCall<AddOfflineUserDataJobOperationsRequest, AddOfflineUserDataJobOperationsResponse>(
                GrpcClient.AddOfflineUserDataJobOperationsAsync, GrpcClient.AddOfflineUserDataJobOperations, effectiveSettings.AddOfflineUserDataJobOperationsSettings)
                .WithGoogleRequestParam("resource_name", request => request.ResourceName);
            _callRunOfflineUserDataJob = clientHelper.BuildApiCall<RunOfflineUserDataJobRequest, lro::Operation>(
                GrpcClient.RunOfflineUserDataJobAsync, GrpcClient.RunOfflineUserDataJob, effectiveSettings.RunOfflineUserDataJobSettings)
                .WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callCreateOfflineUserDataJob);
            Modify_CreateOfflineUserDataJobApiCall(ref _callCreateOfflineUserDataJob);
            Modify_ApiCall(ref _callGetOfflineUserDataJob);
            Modify_GetOfflineUserDataJobApiCall(ref _callGetOfflineUserDataJob);
            Modify_ApiCall(ref _callAddOfflineUserDataJobOperations);
            Modify_AddOfflineUserDataJobOperationsApiCall(ref _callAddOfflineUserDataJobOperations);
            Modify_ApiCall(ref _callRunOfflineUserDataJob);
            Modify_RunOfflineUserDataJobApiCall(ref _callRunOfflineUserDataJob);
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
        partial void Modify_CreateOfflineUserDataJobApiCall(ref gaxgrpc::ApiCall<CreateOfflineUserDataJobRequest, CreateOfflineUserDataJobResponse> call);
        partial void Modify_GetOfflineUserDataJobApiCall(ref gaxgrpc::ApiCall<GetOfflineUserDataJobRequest, gagvr::OfflineUserDataJob> call);
        partial void Modify_AddOfflineUserDataJobOperationsApiCall(ref gaxgrpc::ApiCall<AddOfflineUserDataJobOperationsRequest, AddOfflineUserDataJobOperationsResponse> call);
        partial void Modify_RunOfflineUserDataJobApiCall(ref gaxgrpc::ApiCall<RunOfflineUserDataJobRequest, lro::Operation> call);
        partial void OnConstruction(OfflineUserDataJobService.OfflineUserDataJobServiceClient grpcClient, OfflineUserDataJobServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC OfflineUserDataJobService client.
        /// </summary>
        public override OfflineUserDataJobService.OfflineUserDataJobServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateOfflineUserDataJobRequest(ref CreateOfflineUserDataJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetOfflineUserDataJobRequest(ref GetOfflineUserDataJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_AddOfflineUserDataJobOperationsRequest(ref AddOfflineUserDataJobOperationsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_RunOfflineUserDataJobRequest(ref RunOfflineUserDataJobRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates an offline user data job.
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
        public override stt::Task<CreateOfflineUserDataJobResponse> CreateOfflineUserDataJobAsync(
            CreateOfflineUserDataJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOfflineUserDataJobRequest(ref request, ref callSettings);
            return _callCreateOfflineUserDataJob.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an offline user data job.
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
        public override CreateOfflineUserDataJobResponse CreateOfflineUserDataJob(
            CreateOfflineUserDataJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOfflineUserDataJobRequest(ref request, ref callSettings);
            return _callCreateOfflineUserDataJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the offline user data job.
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
        public override stt::Task<gagvr::OfflineUserDataJob> GetOfflineUserDataJobAsync(
            GetOfflineUserDataJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOfflineUserDataJobRequest(ref request, ref callSettings);
            return _callGetOfflineUserDataJob.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the offline user data job.
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
        public override gagvr::OfflineUserDataJob GetOfflineUserDataJob(
            GetOfflineUserDataJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOfflineUserDataJobRequest(ref request, ref callSettings);
            return _callGetOfflineUserDataJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds operations to the offline user data job.
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
        public override stt::Task<AddOfflineUserDataJobOperationsResponse> AddOfflineUserDataJobOperationsAsync(
            AddOfflineUserDataJobOperationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddOfflineUserDataJobOperationsRequest(ref request, ref callSettings);
            return _callAddOfflineUserDataJobOperations.Async(request, callSettings);
        }

        /// <summary>
        /// Adds operations to the offline user data job.
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
        public override AddOfflineUserDataJobOperationsResponse AddOfflineUserDataJobOperations(
            AddOfflineUserDataJobOperationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddOfflineUserDataJobOperationsRequest(ref request, ref callSettings);
            return _callAddOfflineUserDataJobOperations.Sync(request, callSettings);
        }

        /// <summary>
        /// Runs the offline user data job.
        ///
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
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
        public override async stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Empty>> RunOfflineUserDataJobAsync(
            RunOfflineUserDataJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunOfflineUserDataJobRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Empty>(
                await _callRunOfflineUserDataJob.Async(request, callSettings).ConfigureAwait(false), RunOfflineUserDataJobOperationsClient);
        }

        /// <summary>
        /// Runs the offline user data job.
        ///
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
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
        public override lro::Operation<pbwkt::Empty, pbwkt::Empty> RunOfflineUserDataJob(
            RunOfflineUserDataJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunOfflineUserDataJobRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Empty>(
                _callRunOfflineUserDataJob.Sync(request, callSettings), RunOfflineUserDataJobOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>RunOfflineUserDataJob</c>.
        /// </summary>
        public override lro::OperationsClient RunOfflineUserDataJobOperationsClient { get; }

    }

    // Partial classes to enable page-streaming

    // Partial Grpc class to enable LRO client creation
    public static partial class OfflineUserDataJobService
    {
        public partial class OfflineUserDataJobServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}

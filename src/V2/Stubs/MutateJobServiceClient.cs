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

using gagvr = Google.Ads.GoogleAds.V2.Resources;
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

namespace Google.Ads.GoogleAds.V2.Services
{
    /// <summary>
    /// Settings for a <see cref="MutateJobServiceClient"/>.
    /// </summary>
    public sealed partial class MutateJobServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="MutateJobServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="MutateJobServiceSettings"/>.
        /// </returns>
        public static MutateJobServiceSettings GetDefault() => new MutateJobServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="MutateJobServiceSettings"/> object with default settings.
        /// </summary>
        public MutateJobServiceSettings() { }

        private MutateJobServiceSettings(MutateJobServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateMutateJobSettings = existing.CreateMutateJobSettings;
            GetMutateJobSettings = existing.GetMutateJobSettings;
            ListMutateJobResultsSettings = existing.ListMutateJobResultsSettings;
            RunMutateJobSettings = existing.RunMutateJobSettings;
            RunMutateJobOperationsSettings = existing.RunMutateJobOperationsSettings?.Clone();
            AddMutateJobOperationsSettings = existing.AddMutateJobOperationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MutateJobServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="MutateJobServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="MutateJobServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="MutateJobServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="MutateJobServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="MutateJobServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="MutateJobServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="MutateJobServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="MutateJobServiceClient"/> RPC methods is defined as:
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
        /// <c>MutateJobServiceClient.CreateMutateJob</c> and <c>MutateJobServiceClient.CreateMutateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MutateJobServiceClient.CreateMutateJob</c> and
        /// <c>MutateJobServiceClient.CreateMutateJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateMutateJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MutateJobServiceClient.GetMutateJob</c> and <c>MutateJobServiceClient.GetMutateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MutateJobServiceClient.GetMutateJob</c> and
        /// <c>MutateJobServiceClient.GetMutateJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetMutateJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MutateJobServiceClient.ListMutateJobResults</c> and <c>MutateJobServiceClient.ListMutateJobResultsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MutateJobServiceClient.ListMutateJobResults</c> and
        /// <c>MutateJobServiceClient.ListMutateJobResultsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListMutateJobResultsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MutateJobServiceClient.RunMutateJob</c> and <c>MutateJobServiceClient.RunMutateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MutateJobServiceClient.RunMutateJob</c> and
        /// <c>MutateJobServiceClient.RunMutateJobAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings RunMutateJobSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>MutateJobServiceClient.RunMutateJob</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings RunMutateJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MutateJobServiceClient.AddMutateJobOperations</c> and <c>MutateJobServiceClient.AddMutateJobOperationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MutateJobServiceClient.AddMutateJobOperations</c> and
        /// <c>MutateJobServiceClient.AddMutateJobOperationsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings AddMutateJobOperationsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="MutateJobServiceSettings"/> object.</returns>
        public MutateJobServiceSettings Clone() => new MutateJobServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MutateJobServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class MutateJobServiceClientBuilder : gaxgrpc::ClientBuilderBase<MutateJobServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public MutateJobServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override MutateJobServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MutateJobServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<MutateJobServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MutateJobServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => MutateJobServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => MutateJobServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => MutateJobServiceClient.ChannelPool;
    }

    /// <summary>
    /// MutateJobService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class MutateJobServiceClient
    {
        /// <summary>
        /// The default endpoint for the MutateJobService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default MutateJobService scopes.
        /// </summary>
        /// <remarks>
        /// The default MutateJobService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="MutateJobServiceClient"/>, applying defaults for all unspecified settings,
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
        /// MutateJobServiceClient client = await MutateJobServiceClient.CreateAsync();
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
        ///     MutateJobServiceClient.DefaultEndpoint.Host, MutateJobServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// MutateJobServiceClient client = MutateJobServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="MutateJobServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="MutateJobServiceClient"/>.</returns>
        public static async stt::Task<MutateJobServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, MutateJobServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="MutateJobServiceClient"/>, applying defaults for all unspecified settings,
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
        /// MutateJobServiceClient client = MutateJobServiceClient.Create();
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
        ///     MutateJobServiceClient.DefaultEndpoint.Host, MutateJobServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// MutateJobServiceClient client = MutateJobServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="MutateJobServiceSettings"/>.</param>
        /// <returns>The created <see cref="MutateJobServiceClient"/>.</returns>
        public static MutateJobServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, MutateJobServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="MutateJobServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="MutateJobServiceSettings"/>.</param>
        /// <returns>The created <see cref="MutateJobServiceClient"/>.</returns>
        public static MutateJobServiceClient Create(grpccore::Channel channel, MutateJobServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="MutateJobServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="MutateJobServiceSettings"/>.</param>
        /// <returns>The created <see cref="MutateJobServiceClient"/>.</returns>
        public static MutateJobServiceClient Create(grpccore::CallInvoker callInvoker, MutateJobServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MutateJobService.MutateJobServiceClient grpcClient = new MutateJobService.MutateJobServiceClient(callInvoker);
            return new MutateJobServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, MutateJobServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, MutateJobServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, MutateJobServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, MutateJobServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC MutateJobService client.
        /// </summary>
        public virtual MutateJobService.MutateJobServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Creates a mutate job.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer for which to create a mutate job.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CreateMutateJobResponse> CreateMutateJobAsync(
            string customerId,
            gaxgrpc::CallSettings callSettings = null) => CreateMutateJobAsync(
                new CreateMutateJobRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                },
                callSettings);

        /// <summary>
        /// Creates a mutate job.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer for which to create a mutate job.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CreateMutateJobResponse> CreateMutateJobAsync(
            string customerId,
            st::CancellationToken cancellationToken) => CreateMutateJobAsync(
                customerId,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a mutate job.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer for which to create a mutate job.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CreateMutateJobResponse CreateMutateJob(
            string customerId,
            gaxgrpc::CallSettings callSettings = null) => CreateMutateJob(
                new CreateMutateJobRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                },
                callSettings);

        /// <summary>
        /// Creates a mutate job.
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
        public virtual stt::Task<CreateMutateJobResponse> CreateMutateJobAsync(
            CreateMutateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a mutate job.
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
        public virtual stt::Task<CreateMutateJobResponse> CreateMutateJobAsync(
            CreateMutateJobRequest request,
            st::CancellationToken cancellationToken) => CreateMutateJobAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a mutate job.
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
        public virtual CreateMutateJobResponse CreateMutateJob(
            CreateMutateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the MutateJob to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::MutateJob> GetMutateJobAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetMutateJobAsync(
                new GetMutateJobRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the MutateJob to get.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::MutateJob> GetMutateJobAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetMutateJobAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the MutateJob to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::MutateJob GetMutateJob(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetMutateJob(
                new GetMutateJobRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the mutate job.
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
        public virtual stt::Task<gagvr::MutateJob> GetMutateJobAsync(
            GetMutateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the mutate job.
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
        public virtual stt::Task<gagvr::MutateJob> GetMutateJobAsync(
            GetMutateJobRequest request,
            st::CancellationToken cancellationToken) => GetMutateJobAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the mutate job.
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
        public virtual gagvr::MutateJob GetMutateJob(
            GetMutateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the results of the mutate job. The job must be done.
        /// Supports standard list paging.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the MutateJob whose results are being listed.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="MutateJobResult"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMutateJobResultsResponse, MutateJobResult> ListMutateJobResultsAsync(
            string resourceName,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListMutateJobResultsAsync(
                new ListMutateJobResultsRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the results of the mutate job. The job must be done.
        /// Supports standard list paging.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the MutateJob whose results are being listed.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="MutateJobResult"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListMutateJobResultsResponse, MutateJobResult> ListMutateJobResults(
            string resourceName,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListMutateJobResults(
                new ListMutateJobResultsRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns the results of the mutate job. The job must be done.
        /// Supports standard list paging.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="MutateJobResult"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMutateJobResultsResponse, MutateJobResult> ListMutateJobResultsAsync(
            ListMutateJobResultsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the results of the mutate job. The job must be done.
        /// Supports standard list paging.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="MutateJobResult"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListMutateJobResultsResponse, MutateJobResult> ListMutateJobResults(
            ListMutateJobResultsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Runs the mutate job.
        ///
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the MutateJob to run.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>> RunMutateJobAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => RunMutateJobAsync(
                new RunMutateJobRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Runs the mutate job.
        ///
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the MutateJob to run.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>> RunMutateJobAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => RunMutateJobAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs the mutate job.
        ///
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the MutateJob to run.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata> RunMutateJob(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => RunMutateJob(
                new RunMutateJobRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Runs the mutate job.
        ///
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>> RunMutateJobAsync(
            RunMutateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunMutateJobAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>> PollOnceRunMutateJobAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                RunMutateJobOperationsClient,
                callSettings);

        /// <summary>
        /// Runs the mutate job.
        ///
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
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
        public virtual lro::Operation<pbwkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata> RunMutateJob(
            RunMutateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>RunMutateJob</c>.
        /// </summary>
        public virtual lro::OperationsClient RunMutateJobOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunMutateJob</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<pbwkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata> PollOnceRunMutateJob(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                RunMutateJobOperationsClient,
                callSettings);

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the MutateJob.
        /// </param>
        /// <param name="sequenceToken">
        /// A token used to enforce sequencing.
        ///
        /// The first AddMutateJobOperations request for a MutateJob should not set
        /// sequence_token. Subsequent requests must set sequence_token to the value of
        /// next_sequence_token received in the previous AddMutateJobOperations
        /// response.
        /// </param>
        /// <param name="mutateOperations">
        /// The list of mutates being added.
        ///
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this MutateJob. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(
            string resourceName,
            string sequenceToken,
            scg::IEnumerable<MutateOperation> mutateOperations,
            gaxgrpc::CallSettings callSettings = null) => AddMutateJobOperationsAsync(
                new AddMutateJobOperationsRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                    SequenceToken = gax::GaxPreconditions.CheckNotNullOrEmpty(sequenceToken, nameof(sequenceToken)),
                    MutateOperations = { gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)) },
                },
                callSettings);

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the MutateJob.
        /// </param>
        /// <param name="sequenceToken">
        /// A token used to enforce sequencing.
        ///
        /// The first AddMutateJobOperations request for a MutateJob should not set
        /// sequence_token. Subsequent requests must set sequence_token to the value of
        /// next_sequence_token received in the previous AddMutateJobOperations
        /// response.
        /// </param>
        /// <param name="mutateOperations">
        /// The list of mutates being added.
        ///
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this MutateJob. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(
            string resourceName,
            string sequenceToken,
            scg::IEnumerable<MutateOperation> mutateOperations,
            st::CancellationToken cancellationToken) => AddMutateJobOperationsAsync(
                resourceName,
                sequenceToken,
                mutateOperations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the MutateJob.
        /// </param>
        /// <param name="sequenceToken">
        /// A token used to enforce sequencing.
        ///
        /// The first AddMutateJobOperations request for a MutateJob should not set
        /// sequence_token. Subsequent requests must set sequence_token to the value of
        /// next_sequence_token received in the previous AddMutateJobOperations
        /// response.
        /// </param>
        /// <param name="mutateOperations">
        /// The list of mutates being added.
        ///
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this MutateJob. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AddMutateJobOperationsResponse AddMutateJobOperations(
            string resourceName,
            string sequenceToken,
            scg::IEnumerable<MutateOperation> mutateOperations,
            gaxgrpc::CallSettings callSettings = null) => AddMutateJobOperations(
                new AddMutateJobOperationsRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                    SequenceToken = gax::GaxPreconditions.CheckNotNullOrEmpty(sequenceToken, nameof(sequenceToken)),
                    MutateOperations = { gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)) },
                },
                callSettings);

        /// <summary>
        /// Add operations to the mutate job.
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
        public virtual stt::Task<AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(
            AddMutateJobOperationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Add operations to the mutate job.
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
        public virtual stt::Task<AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(
            AddMutateJobOperationsRequest request,
            st::CancellationToken cancellationToken) => AddMutateJobOperationsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add operations to the mutate job.
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
        public virtual AddMutateJobOperationsResponse AddMutateJobOperations(
            AddMutateJobOperationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// MutateJobService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class MutateJobServiceClientImpl : MutateJobServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateMutateJobRequest, CreateMutateJobResponse> _callCreateMutateJob;
        private readonly gaxgrpc::ApiCall<GetMutateJobRequest, gagvr::MutateJob> _callGetMutateJob;
        private readonly gaxgrpc::ApiCall<ListMutateJobResultsRequest, ListMutateJobResultsResponse> _callListMutateJobResults;
        private readonly gaxgrpc::ApiCall<RunMutateJobRequest, lro::Operation> _callRunMutateJob;
        private readonly gaxgrpc::ApiCall<AddMutateJobOperationsRequest, AddMutateJobOperationsResponse> _callAddMutateJobOperations;

        /// <summary>
        /// Constructs a client wrapper for the MutateJobService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MutateJobServiceSettings"/> used within this client </param>
        public MutateJobServiceClientImpl(MutateJobService.MutateJobServiceClient grpcClient, MutateJobServiceSettings settings)
        {
            GrpcClient = grpcClient;
            MutateJobServiceSettings effectiveSettings = settings ?? MutateJobServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            RunMutateJobOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.RunMutateJobOperationsSettings);
            _callCreateMutateJob = clientHelper.BuildApiCall<CreateMutateJobRequest, CreateMutateJobResponse>(
                GrpcClient.CreateMutateJobAsync, GrpcClient.CreateMutateJob, effectiveSettings.CreateMutateJobSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"customer_id={request.CustomerId}"));
            _callGetMutateJob = clientHelper.BuildApiCall<GetMutateJobRequest, gagvr::MutateJob>(
                GrpcClient.GetMutateJobAsync, GrpcClient.GetMutateJob, effectiveSettings.GetMutateJobSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource_name={request.ResourceName}"));
            _callListMutateJobResults = clientHelper.BuildApiCall<ListMutateJobResultsRequest, ListMutateJobResultsResponse>(
                GrpcClient.ListMutateJobResultsAsync, GrpcClient.ListMutateJobResults, effectiveSettings.ListMutateJobResultsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource_name={request.ResourceName}"));
            _callRunMutateJob = clientHelper.BuildApiCall<RunMutateJobRequest, lro::Operation>(
                GrpcClient.RunMutateJobAsync, GrpcClient.RunMutateJob, effectiveSettings.RunMutateJobSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource_name={request.ResourceName}"));
            _callAddMutateJobOperations = clientHelper.BuildApiCall<AddMutateJobOperationsRequest, AddMutateJobOperationsResponse>(
                GrpcClient.AddMutateJobOperationsAsync, GrpcClient.AddMutateJobOperations, effectiveSettings.AddMutateJobOperationsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource_name={request.ResourceName}"));
            Modify_ApiCall(ref _callCreateMutateJob);
            Modify_CreateMutateJobApiCall(ref _callCreateMutateJob);
            Modify_ApiCall(ref _callGetMutateJob);
            Modify_GetMutateJobApiCall(ref _callGetMutateJob);
            Modify_ApiCall(ref _callListMutateJobResults);
            Modify_ListMutateJobResultsApiCall(ref _callListMutateJobResults);
            Modify_ApiCall(ref _callRunMutateJob);
            Modify_RunMutateJobApiCall(ref _callRunMutateJob);
            Modify_ApiCall(ref _callAddMutateJobOperations);
            Modify_AddMutateJobOperationsApiCall(ref _callAddMutateJobOperations);
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
        partial void Modify_CreateMutateJobApiCall(ref gaxgrpc::ApiCall<CreateMutateJobRequest, CreateMutateJobResponse> call);
        partial void Modify_GetMutateJobApiCall(ref gaxgrpc::ApiCall<GetMutateJobRequest, gagvr::MutateJob> call);
        partial void Modify_ListMutateJobResultsApiCall(ref gaxgrpc::ApiCall<ListMutateJobResultsRequest, ListMutateJobResultsResponse> call);
        partial void Modify_RunMutateJobApiCall(ref gaxgrpc::ApiCall<RunMutateJobRequest, lro::Operation> call);
        partial void Modify_AddMutateJobOperationsApiCall(ref gaxgrpc::ApiCall<AddMutateJobOperationsRequest, AddMutateJobOperationsResponse> call);
        partial void OnConstruction(MutateJobService.MutateJobServiceClient grpcClient, MutateJobServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC MutateJobService client.
        /// </summary>
        public override MutateJobService.MutateJobServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_CreateMutateJobRequest(ref CreateMutateJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetMutateJobRequest(ref GetMutateJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListMutateJobResultsRequest(ref ListMutateJobResultsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_RunMutateJobRequest(ref RunMutateJobRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_AddMutateJobOperationsRequest(ref AddMutateJobOperationsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a mutate job.
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
        public override stt::Task<CreateMutateJobResponse> CreateMutateJobAsync(
            CreateMutateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMutateJobRequest(ref request, ref callSettings);
            return _callCreateMutateJob.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a mutate job.
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
        public override CreateMutateJobResponse CreateMutateJob(
            CreateMutateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMutateJobRequest(ref request, ref callSettings);
            return _callCreateMutateJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the mutate job.
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
        public override stt::Task<gagvr::MutateJob> GetMutateJobAsync(
            GetMutateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMutateJobRequest(ref request, ref callSettings);
            return _callGetMutateJob.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the mutate job.
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
        public override gagvr::MutateJob GetMutateJob(
            GetMutateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMutateJobRequest(ref request, ref callSettings);
            return _callGetMutateJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the results of the mutate job. The job must be done.
        /// Supports standard list paging.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="MutateJobResult"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListMutateJobResultsResponse, MutateJobResult> ListMutateJobResultsAsync(
            ListMutateJobResultsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMutateJobResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMutateJobResultsRequest, ListMutateJobResultsResponse, MutateJobResult>(_callListMutateJobResults, request, callSettings);
        }

        /// <summary>
        /// Returns the results of the mutate job. The job must be done.
        /// Supports standard list paging.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="MutateJobResult"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListMutateJobResultsResponse, MutateJobResult> ListMutateJobResults(
            ListMutateJobResultsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMutateJobResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMutateJobResultsRequest, ListMutateJobResultsResponse, MutateJobResult>(_callListMutateJobResults, request, callSettings);
        }

        /// <summary>
        /// Runs the mutate job.
        ///
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
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
        public override async stt::Task<lro::Operation<pbwkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>> RunMutateJobAsync(
            RunMutateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunMutateJobRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>(
                await _callRunMutateJob.Async(request, callSettings).ConfigureAwait(false), RunMutateJobOperationsClient);
        }

        /// <summary>
        /// Runs the mutate job.
        ///
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
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
        public override lro::Operation<pbwkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata> RunMutateJob(
            RunMutateJobRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunMutateJobRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>(
                _callRunMutateJob.Sync(request, callSettings), RunMutateJobOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>RunMutateJob</c>.
        /// </summary>
        public override lro::OperationsClient RunMutateJobOperationsClient { get; }

        /// <summary>
        /// Add operations to the mutate job.
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
        public override stt::Task<AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(
            AddMutateJobOperationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddMutateJobOperationsRequest(ref request, ref callSettings);
            return _callAddMutateJobOperations.Async(request, callSettings);
        }

        /// <summary>
        /// Add operations to the mutate job.
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
        public override AddMutateJobOperationsResponse AddMutateJobOperations(
            AddMutateJobOperationsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddMutateJobOperationsRequest(ref request, ref callSettings);
            return _callAddMutateJobOperations.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListMutateJobResultsRequest : gaxgrpc::IPageRequest { }
    public partial class ListMutateJobResultsResponse : gaxgrpc::IPageResponse<MutateJobResult>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<MutateJobResult> GetEnumerator() => Results.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class MutateJobService
    {
        public partial class MutateJobServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}

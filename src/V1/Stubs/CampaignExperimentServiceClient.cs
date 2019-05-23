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
using lro = Google.LongRunning;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
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
    /// Settings for a <see cref="CampaignExperimentServiceClient"/>.
    /// </summary>
    public sealed partial class CampaignExperimentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="CampaignExperimentServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="CampaignExperimentServiceSettings"/>.
        /// </returns>
        public static CampaignExperimentServiceSettings GetDefault() => new CampaignExperimentServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignExperimentServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignExperimentServiceSettings() { }

        private CampaignExperimentServiceSettings(CampaignExperimentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCampaignExperimentSettings = existing.GetCampaignExperimentSettings;
            CreateCampaignExperimentSettings = existing.CreateCampaignExperimentSettings;
            CreateCampaignExperimentOperationsSettings = existing.CreateCampaignExperimentOperationsSettings?.Clone();
            MutateCampaignExperimentsSettings = existing.MutateCampaignExperimentsSettings;
            GraduateCampaignExperimentSettings = existing.GraduateCampaignExperimentSettings;
            PromoteCampaignExperimentSettings = existing.PromoteCampaignExperimentSettings;
            PromoteCampaignExperimentOperationsSettings = existing.PromoteCampaignExperimentOperationsSettings?.Clone();
            EndCampaignExperimentSettings = existing.EndCampaignExperimentSettings;
            ListCampaignExperimentAsyncErrorsSettings = existing.ListCampaignExperimentAsyncErrorsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignExperimentServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="CampaignExperimentServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="CampaignExperimentServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="CampaignExperimentServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="CampaignExperimentServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="CampaignExperimentServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="CampaignExperimentServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="CampaignExperimentServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="CampaignExperimentServiceClient"/> RPC methods is defined as:
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
        /// <c>CampaignExperimentServiceClient.GetCampaignExperiment</c> and <c>CampaignExperimentServiceClient.GetCampaignExperimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CampaignExperimentServiceClient.GetCampaignExperiment</c> and
        /// <c>CampaignExperimentServiceClient.GetCampaignExperimentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetCampaignExperimentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignExperimentServiceClient.CreateCampaignExperiment</c> and <c>CampaignExperimentServiceClient.CreateCampaignExperimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CampaignExperimentServiceClient.CreateCampaignExperiment</c> and
        /// <c>CampaignExperimentServiceClient.CreateCampaignExperimentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateCampaignExperimentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CampaignExperimentServiceClient.CreateCampaignExperiment</c>.
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
        public lro::OperationsSettings CreateCampaignExperimentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignExperimentServiceClient.MutateCampaignExperiments</c> and <c>CampaignExperimentServiceClient.MutateCampaignExperimentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CampaignExperimentServiceClient.MutateCampaignExperiments</c> and
        /// <c>CampaignExperimentServiceClient.MutateCampaignExperimentsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings MutateCampaignExperimentsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignExperimentServiceClient.GraduateCampaignExperiment</c> and <c>CampaignExperimentServiceClient.GraduateCampaignExperimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CampaignExperimentServiceClient.GraduateCampaignExperiment</c> and
        /// <c>CampaignExperimentServiceClient.GraduateCampaignExperimentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GraduateCampaignExperimentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignExperimentServiceClient.PromoteCampaignExperiment</c> and <c>CampaignExperimentServiceClient.PromoteCampaignExperimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CampaignExperimentServiceClient.PromoteCampaignExperiment</c> and
        /// <c>CampaignExperimentServiceClient.PromoteCampaignExperimentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings PromoteCampaignExperimentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CampaignExperimentServiceClient.PromoteCampaignExperiment</c>.
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
        public lro::OperationsSettings PromoteCampaignExperimentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignExperimentServiceClient.EndCampaignExperiment</c> and <c>CampaignExperimentServiceClient.EndCampaignExperimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CampaignExperimentServiceClient.EndCampaignExperiment</c> and
        /// <c>CampaignExperimentServiceClient.EndCampaignExperimentAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings EndCampaignExperimentSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignExperimentServiceClient.ListCampaignExperimentAsyncErrors</c> and <c>CampaignExperimentServiceClient.ListCampaignExperimentAsyncErrorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CampaignExperimentServiceClient.ListCampaignExperimentAsyncErrors</c> and
        /// <c>CampaignExperimentServiceClient.ListCampaignExperimentAsyncErrorsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListCampaignExperimentAsyncErrorsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="CampaignExperimentServiceSettings"/> object.</returns>
        public CampaignExperimentServiceSettings Clone() => new CampaignExperimentServiceSettings(this);
    }

    /// <summary>
    /// CampaignExperimentService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class CampaignExperimentServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignExperimentService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default CampaignExperimentService scopes.
        /// </summary>
        /// <remarks>
        /// The default CampaignExperimentService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignExperimentServiceClient"/>, applying defaults for all unspecified settings,
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
        /// CampaignExperimentServiceClient client = await CampaignExperimentServiceClient.CreateAsync();
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
        ///     CampaignExperimentServiceClient.DefaultEndpoint.Host, CampaignExperimentServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CampaignExperimentServiceClient client = CampaignExperimentServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CampaignExperimentServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="CampaignExperimentServiceClient"/>.</returns>
        public static async stt::Task<CampaignExperimentServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, CampaignExperimentServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="CampaignExperimentServiceClient"/>, applying defaults for all unspecified settings,
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
        /// CampaignExperimentServiceClient client = CampaignExperimentServiceClient.Create();
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
        ///     CampaignExperimentServiceClient.DefaultEndpoint.Host, CampaignExperimentServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CampaignExperimentServiceClient client = CampaignExperimentServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CampaignExperimentServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignExperimentServiceClient"/>.</returns>
        public static CampaignExperimentServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, CampaignExperimentServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="CampaignExperimentServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CampaignExperimentServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignExperimentServiceClient"/>.</returns>
        public static CampaignExperimentServiceClient Create(grpccore::Channel channel, CampaignExperimentServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="CampaignExperimentServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CampaignExperimentServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignExperimentServiceClient"/>.</returns>
        public static CampaignExperimentServiceClient Create(grpccore::CallInvoker callInvoker, CampaignExperimentServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignExperimentService.CampaignExperimentServiceClient grpcClient = new CampaignExperimentService.CampaignExperimentServiceClient(callInvoker);
            return new CampaignExperimentServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, CampaignExperimentServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CampaignExperimentServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, CampaignExperimentServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CampaignExperimentServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC CampaignExperimentService client.
        /// </summary>
        public virtual CampaignExperimentService.CampaignExperimentServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the campaign experiment to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CampaignExperiment> GetCampaignExperimentAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCampaignExperimentAsync(
                new GetCampaignExperimentRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the campaign experiment to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CampaignExperiment> GetCampaignExperimentAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetCampaignExperimentAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the campaign experiment to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::CampaignExperiment GetCampaignExperiment(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCampaignExperiment(
                new GetCampaignExperimentRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
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
        public virtual stt::Task<gagvr::CampaignExperiment> GetCampaignExperimentAsync(
            GetCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
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
        public virtual stt::Task<gagvr::CampaignExperiment> GetCampaignExperimentAsync(
            GetCampaignExperimentRequest request,
            st::CancellationToken cancellationToken) => GetCampaignExperimentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
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
        public virtual gagvr::CampaignExperiment GetCampaignExperiment(
            GetCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        ///
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign experiment is being created.
        /// </param>
        /// <param name="campaignExperiment">
        /// The campaign experiment to be created.
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, CreateCampaignExperimentMetadata>> CreateCampaignExperimentAsync(
            string customerId,
            gagvr::CampaignExperiment campaignExperiment,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => CreateCampaignExperimentAsync(
                new CreateCampaignExperimentRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    CampaignExperiment = gax::GaxPreconditions.CheckNotNull(campaignExperiment, nameof(campaignExperiment)),
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        ///
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign experiment is being created.
        /// </param>
        /// <param name="campaignExperiment">
        /// The campaign experiment to be created.
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, CreateCampaignExperimentMetadata>> CreateCampaignExperimentAsync(
            string customerId,
            gagvr::CampaignExperiment campaignExperiment,
            bool? validateOnly,
            st::CancellationToken cancellationToken) => CreateCampaignExperimentAsync(
                customerId,
                campaignExperiment,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        ///
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign experiment is being created.
        /// </param>
        /// <param name="campaignExperiment">
        /// The campaign experiment to be created.
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
        public virtual lro::Operation<pbwkt::Empty, CreateCampaignExperimentMetadata> CreateCampaignExperiment(
            string customerId,
            gagvr::CampaignExperiment campaignExperiment,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => CreateCampaignExperiment(
                new CreateCampaignExperimentRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    CampaignExperiment = gax::GaxPreconditions.CheckNotNull(campaignExperiment, nameof(campaignExperiment)),
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        ///
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign experiment is being created.
        /// </param>
        /// <param name="campaignExperiment">
        /// The campaign experiment to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, CreateCampaignExperimentMetadata>> CreateCampaignExperimentAsync(
            string customerId,
            gagvr::CampaignExperiment campaignExperiment,
            gaxgrpc::CallSettings callSettings = null) => CreateCampaignExperimentAsync(
                new CreateCampaignExperimentRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    CampaignExperiment = gax::GaxPreconditions.CheckNotNull(campaignExperiment, nameof(campaignExperiment)),
                },
                callSettings);

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        ///
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign experiment is being created.
        /// </param>
        /// <param name="campaignExperiment">
        /// The campaign experiment to be created.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, CreateCampaignExperimentMetadata>> CreateCampaignExperimentAsync(
            string customerId,
            gagvr::CampaignExperiment campaignExperiment,
            st::CancellationToken cancellationToken) => CreateCampaignExperimentAsync(
                customerId,
                campaignExperiment,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        ///
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign experiment is being created.
        /// </param>
        /// <param name="campaignExperiment">
        /// The campaign experiment to be created.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, CreateCampaignExperimentMetadata> CreateCampaignExperiment(
            string customerId,
            gagvr::CampaignExperiment campaignExperiment,
            gaxgrpc::CallSettings callSettings = null) => CreateCampaignExperiment(
                new CreateCampaignExperimentRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    CampaignExperiment = gax::GaxPreconditions.CheckNotNull(campaignExperiment, nameof(campaignExperiment)),
                },
                callSettings);

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        ///
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, CreateCampaignExperimentMetadata>> CreateCampaignExperimentAsync(
            CreateCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCampaignExperimentAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, CreateCampaignExperimentMetadata>> PollOnceCreateCampaignExperimentAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, CreateCampaignExperimentMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateCampaignExperimentOperationsClient,
                callSettings);

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        ///
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
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
        public virtual lro::Operation<pbwkt::Empty, CreateCampaignExperimentMetadata> CreateCampaignExperiment(
            CreateCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>CreateCampaignExperiment</c>.
        /// </summary>
        public virtual lro::OperationsClient CreateCampaignExperimentOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCampaignExperiment</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<pbwkt::Empty, CreateCampaignExperimentMetadata> PollOnceCreateCampaignExperiment(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, CreateCampaignExperimentMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateCampaignExperimentOperationsClient,
                callSettings);

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign experiments are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual campaign experiments.
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
        public virtual stt::Task<MutateCampaignExperimentsResponse> MutateCampaignExperimentsAsync(
            string customerId,
            scg::IEnumerable<CampaignExperimentOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignExperimentsAsync(
                new MutateCampaignExperimentsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign experiments are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual campaign experiments.
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
        public virtual stt::Task<MutateCampaignExperimentsResponse> MutateCampaignExperimentsAsync(
            string customerId,
            scg::IEnumerable<CampaignExperimentOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            st::CancellationToken cancellationToken) => MutateCampaignExperimentsAsync(
                customerId,
                operations,
                partialFailure,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign experiments are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual campaign experiments.
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
        public virtual MutateCampaignExperimentsResponse MutateCampaignExperiments(
            string customerId,
            scg::IEnumerable<CampaignExperimentOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignExperiments(
                new MutateCampaignExperimentsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign experiments are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual campaign experiments.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCampaignExperimentsResponse> MutateCampaignExperimentsAsync(
            string customerId,
            scg::IEnumerable<CampaignExperimentOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignExperimentsAsync(
                new MutateCampaignExperimentsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign experiments are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual campaign experiments.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCampaignExperimentsResponse> MutateCampaignExperimentsAsync(
            string customerId,
            scg::IEnumerable<CampaignExperimentOperation> operations,
            st::CancellationToken cancellationToken) => MutateCampaignExperimentsAsync(
                customerId,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign experiments are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual campaign experiments.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateCampaignExperimentsResponse MutateCampaignExperiments(
            string customerId,
            scg::IEnumerable<CampaignExperimentOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignExperiments(
                new MutateCampaignExperimentsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
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
        public virtual stt::Task<MutateCampaignExperimentsResponse> MutateCampaignExperimentsAsync(
            MutateCampaignExperimentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
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
        public virtual stt::Task<MutateCampaignExperimentsResponse> MutateCampaignExperimentsAsync(
            MutateCampaignExperimentsRequest request,
            st::CancellationToken cancellationToken) => MutateCampaignExperimentsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
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
        public virtual MutateCampaignExperimentsResponse MutateCampaignExperiments(
            MutateCampaignExperimentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Graduates a campaign experiment to a full campaign. The base and experiment
        /// campaigns will start running independently with their own budgets.
        /// </summary>
        /// <param name="campaignExperiment">
        /// The resource name of the campaign experiment to graduate.
        /// </param>
        /// <param name="campaignBudget">
        /// Resource name of the budget to attach to the campaign graduated from the
        /// experiment.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GraduateCampaignExperimentResponse> GraduateCampaignExperimentAsync(
            string campaignExperiment,
            string campaignBudget,
            gaxgrpc::CallSettings callSettings = null) => GraduateCampaignExperimentAsync(
                new GraduateCampaignExperimentRequest
                {
                    CampaignExperiment = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignExperiment, nameof(campaignExperiment)),
                    CampaignBudget = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignBudget, nameof(campaignBudget)),
                },
                callSettings);

        /// <summary>
        /// Graduates a campaign experiment to a full campaign. The base and experiment
        /// campaigns will start running independently with their own budgets.
        /// </summary>
        /// <param name="campaignExperiment">
        /// The resource name of the campaign experiment to graduate.
        /// </param>
        /// <param name="campaignBudget">
        /// Resource name of the budget to attach to the campaign graduated from the
        /// experiment.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<GraduateCampaignExperimentResponse> GraduateCampaignExperimentAsync(
            string campaignExperiment,
            string campaignBudget,
            st::CancellationToken cancellationToken) => GraduateCampaignExperimentAsync(
                campaignExperiment,
                campaignBudget,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Graduates a campaign experiment to a full campaign. The base and experiment
        /// campaigns will start running independently with their own budgets.
        /// </summary>
        /// <param name="campaignExperiment">
        /// The resource name of the campaign experiment to graduate.
        /// </param>
        /// <param name="campaignBudget">
        /// Resource name of the budget to attach to the campaign graduated from the
        /// experiment.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual GraduateCampaignExperimentResponse GraduateCampaignExperiment(
            string campaignExperiment,
            string campaignBudget,
            gaxgrpc::CallSettings callSettings = null) => GraduateCampaignExperiment(
                new GraduateCampaignExperimentRequest
                {
                    CampaignExperiment = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignExperiment, nameof(campaignExperiment)),
                    CampaignBudget = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignBudget, nameof(campaignBudget)),
                },
                callSettings);

        /// <summary>
        /// Graduates a campaign experiment to a full campaign. The base and experiment
        /// campaigns will start running independently with their own budgets.
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
        public virtual stt::Task<GraduateCampaignExperimentResponse> GraduateCampaignExperimentAsync(
            GraduateCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Graduates a campaign experiment to a full campaign. The base and experiment
        /// campaigns will start running independently with their own budgets.
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
        public virtual stt::Task<GraduateCampaignExperimentResponse> GraduateCampaignExperimentAsync(
            GraduateCampaignExperimentRequest request,
            st::CancellationToken cancellationToken) => GraduateCampaignExperimentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Graduates a campaign experiment to a full campaign. The base and experiment
        /// campaigns will start running independently with their own budgets.
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
        public virtual GraduateCampaignExperimentResponse GraduateCampaignExperiment(
            GraduateCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Promotes the changes in a experiment campaign back to the base campaign.
        ///
        /// The campaign experiment is updated immediately with status PROMOTING.
        /// This method return a long running operation that tracks the promoting of
        /// the experiment campaign. If the promoting fails, a list of errors can be
        /// retrieved using the ListCampaignExperimentAsyncErrors method.
        /// </summary>
        /// <param name="campaignExperiment">
        /// The resource name of the campaign experiment to promote.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Empty>> PromoteCampaignExperimentAsync(
            string campaignExperiment,
            gaxgrpc::CallSettings callSettings = null) => PromoteCampaignExperimentAsync(
                new PromoteCampaignExperimentRequest
                {
                    CampaignExperiment = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignExperiment, nameof(campaignExperiment)),
                },
                callSettings);

        /// <summary>
        /// Promotes the changes in a experiment campaign back to the base campaign.
        ///
        /// The campaign experiment is updated immediately with status PROMOTING.
        /// This method return a long running operation that tracks the promoting of
        /// the experiment campaign. If the promoting fails, a list of errors can be
        /// retrieved using the ListCampaignExperimentAsyncErrors method.
        /// </summary>
        /// <param name="campaignExperiment">
        /// The resource name of the campaign experiment to promote.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Empty>> PromoteCampaignExperimentAsync(
            string campaignExperiment,
            st::CancellationToken cancellationToken) => PromoteCampaignExperimentAsync(
                campaignExperiment,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Promotes the changes in a experiment campaign back to the base campaign.
        ///
        /// The campaign experiment is updated immediately with status PROMOTING.
        /// This method return a long running operation that tracks the promoting of
        /// the experiment campaign. If the promoting fails, a list of errors can be
        /// retrieved using the ListCampaignExperimentAsyncErrors method.
        /// </summary>
        /// <param name="campaignExperiment">
        /// The resource name of the campaign experiment to promote.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Empty> PromoteCampaignExperiment(
            string campaignExperiment,
            gaxgrpc::CallSettings callSettings = null) => PromoteCampaignExperiment(
                new PromoteCampaignExperimentRequest
                {
                    CampaignExperiment = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignExperiment, nameof(campaignExperiment)),
                },
                callSettings);

        /// <summary>
        /// Promotes the changes in a experiment campaign back to the base campaign.
        ///
        /// The campaign experiment is updated immediately with status PROMOTING.
        /// This method return a long running operation that tracks the promoting of
        /// the experiment campaign. If the promoting fails, a list of errors can be
        /// retrieved using the ListCampaignExperimentAsyncErrors method.
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Empty>> PromoteCampaignExperimentAsync(
            PromoteCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PromoteCampaignExperimentAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Empty>> PollOncePromoteCampaignExperimentAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Empty>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                PromoteCampaignExperimentOperationsClient,
                callSettings);

        /// <summary>
        /// Promotes the changes in a experiment campaign back to the base campaign.
        ///
        /// The campaign experiment is updated immediately with status PROMOTING.
        /// This method return a long running operation that tracks the promoting of
        /// the experiment campaign. If the promoting fails, a list of errors can be
        /// retrieved using the ListCampaignExperimentAsyncErrors method.
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
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Empty> PromoteCampaignExperiment(
            PromoteCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>PromoteCampaignExperiment</c>.
        /// </summary>
        public virtual lro::OperationsClient PromoteCampaignExperimentOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PromoteCampaignExperiment</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Empty> PollOncePromoteCampaignExperiment(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Empty>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                PromoteCampaignExperimentOperationsClient,
                callSettings);

        /// <summary>
        /// Immediately ends a campaign experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// </summary>
        /// <param name="campaignExperiment">
        /// The resource name of the campaign experiment to end.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task EndCampaignExperimentAsync(
            string campaignExperiment,
            gaxgrpc::CallSettings callSettings = null) => EndCampaignExperimentAsync(
                new EndCampaignExperimentRequest
                {
                    CampaignExperiment = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignExperiment, nameof(campaignExperiment)),
                },
                callSettings);

        /// <summary>
        /// Immediately ends a campaign experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// </summary>
        /// <param name="campaignExperiment">
        /// The resource name of the campaign experiment to end.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task EndCampaignExperimentAsync(
            string campaignExperiment,
            st::CancellationToken cancellationToken) => EndCampaignExperimentAsync(
                campaignExperiment,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Immediately ends a campaign experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// </summary>
        /// <param name="campaignExperiment">
        /// The resource name of the campaign experiment to end.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void EndCampaignExperiment(
            string campaignExperiment,
            gaxgrpc::CallSettings callSettings = null) => EndCampaignExperiment(
                new EndCampaignExperimentRequest
                {
                    CampaignExperiment = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignExperiment, nameof(campaignExperiment)),
                },
                callSettings);

        /// <summary>
        /// Immediately ends a campaign experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task EndCampaignExperimentAsync(
            EndCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Immediately ends a campaign experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task EndCampaignExperimentAsync(
            EndCampaignExperimentRequest request,
            st::CancellationToken cancellationToken) => EndCampaignExperimentAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Immediately ends a campaign experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void EndCampaignExperiment(
            EndCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns all errors that occurred during CampaignExperiment create or
        /// promote (whichever occurred last).
        /// Supports standard list paging.
        /// </summary>
        /// <param name="resourceName">
        /// The name of the campaign experiment from which to retrieve the async
        /// errors.
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
        /// A pageable asynchronous sequence of <see cref="gr::Status"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListCampaignExperimentAsyncErrorsResponse, gr::Status> ListCampaignExperimentAsyncErrorsAsync(
            string resourceName,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListCampaignExperimentAsyncErrorsAsync(
                new ListCampaignExperimentAsyncErrorsRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns all errors that occurred during CampaignExperiment create or
        /// promote (whichever occurred last).
        /// Supports standard list paging.
        /// </summary>
        /// <param name="resourceName">
        /// The name of the campaign experiment from which to retrieve the async
        /// errors.
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
        /// A pageable sequence of <see cref="gr::Status"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListCampaignExperimentAsyncErrorsResponse, gr::Status> ListCampaignExperimentAsyncErrors(
            string resourceName,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListCampaignExperimentAsyncErrors(
                new ListCampaignExperimentAsyncErrorsRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns all errors that occurred during CampaignExperiment create or
        /// promote (whichever occurred last).
        /// Supports standard list paging.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gr::Status"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListCampaignExperimentAsyncErrorsResponse, gr::Status> ListCampaignExperimentAsyncErrorsAsync(
            ListCampaignExperimentAsyncErrorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns all errors that occurred during CampaignExperiment create or
        /// promote (whichever occurred last).
        /// Supports standard list paging.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gr::Status"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListCampaignExperimentAsyncErrorsResponse, gr::Status> ListCampaignExperimentAsyncErrors(
            ListCampaignExperimentAsyncErrorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// CampaignExperimentService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class CampaignExperimentServiceClientImpl : CampaignExperimentServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCampaignExperimentRequest, gagvr::CampaignExperiment> _callGetCampaignExperiment;
        private readonly gaxgrpc::ApiCall<CreateCampaignExperimentRequest, lro::Operation> _callCreateCampaignExperiment;
        private readonly gaxgrpc::ApiCall<MutateCampaignExperimentsRequest, MutateCampaignExperimentsResponse> _callMutateCampaignExperiments;
        private readonly gaxgrpc::ApiCall<GraduateCampaignExperimentRequest, GraduateCampaignExperimentResponse> _callGraduateCampaignExperiment;
        private readonly gaxgrpc::ApiCall<PromoteCampaignExperimentRequest, lro::Operation> _callPromoteCampaignExperiment;
        private readonly gaxgrpc::ApiCall<EndCampaignExperimentRequest, pbwkt::Empty> _callEndCampaignExperiment;
        private readonly gaxgrpc::ApiCall<ListCampaignExperimentAsyncErrorsRequest, ListCampaignExperimentAsyncErrorsResponse> _callListCampaignExperimentAsyncErrors;

        /// <summary>
        /// Constructs a client wrapper for the CampaignExperimentService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CampaignExperimentServiceSettings"/> used within this client </param>
        public CampaignExperimentServiceClientImpl(CampaignExperimentService.CampaignExperimentServiceClient grpcClient, CampaignExperimentServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CampaignExperimentServiceSettings effectiveSettings = settings ?? CampaignExperimentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateCampaignExperimentOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.CreateCampaignExperimentOperationsSettings);
            PromoteCampaignExperimentOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.PromoteCampaignExperimentOperationsSettings);
            _callGetCampaignExperiment = clientHelper.BuildApiCall<GetCampaignExperimentRequest, gagvr::CampaignExperiment>(
                GrpcClient.GetCampaignExperimentAsync, GrpcClient.GetCampaignExperiment, effectiveSettings.GetCampaignExperimentSettings);
            _callCreateCampaignExperiment = clientHelper.BuildApiCall<CreateCampaignExperimentRequest, lro::Operation>(
                GrpcClient.CreateCampaignExperimentAsync, GrpcClient.CreateCampaignExperiment, effectiveSettings.CreateCampaignExperimentSettings);
            _callMutateCampaignExperiments = clientHelper.BuildApiCall<MutateCampaignExperimentsRequest, MutateCampaignExperimentsResponse>(
                GrpcClient.MutateCampaignExperimentsAsync, GrpcClient.MutateCampaignExperiments, effectiveSettings.MutateCampaignExperimentsSettings);
            _callGraduateCampaignExperiment = clientHelper.BuildApiCall<GraduateCampaignExperimentRequest, GraduateCampaignExperimentResponse>(
                GrpcClient.GraduateCampaignExperimentAsync, GrpcClient.GraduateCampaignExperiment, effectiveSettings.GraduateCampaignExperimentSettings);
            _callPromoteCampaignExperiment = clientHelper.BuildApiCall<PromoteCampaignExperimentRequest, lro::Operation>(
                GrpcClient.PromoteCampaignExperimentAsync, GrpcClient.PromoteCampaignExperiment, effectiveSettings.PromoteCampaignExperimentSettings);
            _callEndCampaignExperiment = clientHelper.BuildApiCall<EndCampaignExperimentRequest, pbwkt::Empty>(
                GrpcClient.EndCampaignExperimentAsync, GrpcClient.EndCampaignExperiment, effectiveSettings.EndCampaignExperimentSettings);
            _callListCampaignExperimentAsyncErrors = clientHelper.BuildApiCall<ListCampaignExperimentAsyncErrorsRequest, ListCampaignExperimentAsyncErrorsResponse>(
                GrpcClient.ListCampaignExperimentAsyncErrorsAsync, GrpcClient.ListCampaignExperimentAsyncErrors, effectiveSettings.ListCampaignExperimentAsyncErrorsSettings);
            Modify_ApiCall(ref _callGetCampaignExperiment);
            Modify_GetCampaignExperimentApiCall(ref _callGetCampaignExperiment);
            Modify_ApiCall(ref _callCreateCampaignExperiment);
            Modify_CreateCampaignExperimentApiCall(ref _callCreateCampaignExperiment);
            Modify_ApiCall(ref _callMutateCampaignExperiments);
            Modify_MutateCampaignExperimentsApiCall(ref _callMutateCampaignExperiments);
            Modify_ApiCall(ref _callGraduateCampaignExperiment);
            Modify_GraduateCampaignExperimentApiCall(ref _callGraduateCampaignExperiment);
            Modify_ApiCall(ref _callPromoteCampaignExperiment);
            Modify_PromoteCampaignExperimentApiCall(ref _callPromoteCampaignExperiment);
            Modify_ApiCall(ref _callEndCampaignExperiment);
            Modify_EndCampaignExperimentApiCall(ref _callEndCampaignExperiment);
            Modify_ApiCall(ref _callListCampaignExperimentAsyncErrors);
            Modify_ListCampaignExperimentAsyncErrorsApiCall(ref _callListCampaignExperimentAsyncErrors);
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
        partial void Modify_GetCampaignExperimentApiCall(ref gaxgrpc::ApiCall<GetCampaignExperimentRequest, gagvr::CampaignExperiment> call);
        partial void Modify_CreateCampaignExperimentApiCall(ref gaxgrpc::ApiCall<CreateCampaignExperimentRequest, lro::Operation> call);
        partial void Modify_MutateCampaignExperimentsApiCall(ref gaxgrpc::ApiCall<MutateCampaignExperimentsRequest, MutateCampaignExperimentsResponse> call);
        partial void Modify_GraduateCampaignExperimentApiCall(ref gaxgrpc::ApiCall<GraduateCampaignExperimentRequest, GraduateCampaignExperimentResponse> call);
        partial void Modify_PromoteCampaignExperimentApiCall(ref gaxgrpc::ApiCall<PromoteCampaignExperimentRequest, lro::Operation> call);
        partial void Modify_EndCampaignExperimentApiCall(ref gaxgrpc::ApiCall<EndCampaignExperimentRequest, pbwkt::Empty> call);
        partial void Modify_ListCampaignExperimentAsyncErrorsApiCall(ref gaxgrpc::ApiCall<ListCampaignExperimentAsyncErrorsRequest, ListCampaignExperimentAsyncErrorsResponse> call);
        partial void OnConstruction(CampaignExperimentService.CampaignExperimentServiceClient grpcClient, CampaignExperimentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC CampaignExperimentService client.
        /// </summary>
        public override CampaignExperimentService.CampaignExperimentServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetCampaignExperimentRequest(ref GetCampaignExperimentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateCampaignExperimentRequest(ref CreateCampaignExperimentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateCampaignExperimentsRequest(ref MutateCampaignExperimentsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GraduateCampaignExperimentRequest(ref GraduateCampaignExperimentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_PromoteCampaignExperimentRequest(ref PromoteCampaignExperimentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_EndCampaignExperimentRequest(ref EndCampaignExperimentRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListCampaignExperimentAsyncErrorsRequest(ref ListCampaignExperimentAsyncErrorsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
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
        public override stt::Task<gagvr::CampaignExperiment> GetCampaignExperimentAsync(
            GetCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignExperimentRequest(ref request, ref callSettings);
            return _callGetCampaignExperiment.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
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
        public override gagvr::CampaignExperiment GetCampaignExperiment(
            GetCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignExperimentRequest(ref request, ref callSettings);
            return _callGetCampaignExperiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        ///
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
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
        public override async stt::Task<lro::Operation<pbwkt::Empty, CreateCampaignExperimentMetadata>> CreateCampaignExperimentAsync(
            CreateCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCampaignExperimentRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, CreateCampaignExperimentMetadata>(
                await _callCreateCampaignExperiment.Async(request, callSettings).ConfigureAwait(false), CreateCampaignExperimentOperationsClient);
        }

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        ///
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
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
        public override lro::Operation<pbwkt::Empty, CreateCampaignExperimentMetadata> CreateCampaignExperiment(
            CreateCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCampaignExperimentRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, CreateCampaignExperimentMetadata>(
                _callCreateCampaignExperiment.Sync(request, callSettings), CreateCampaignExperimentOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>CreateCampaignExperiment</c>.
        /// </summary>
        public override lro::OperationsClient CreateCampaignExperimentOperationsClient { get; }

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
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
        public override stt::Task<MutateCampaignExperimentsResponse> MutateCampaignExperimentsAsync(
            MutateCampaignExperimentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignExperimentsRequest(ref request, ref callSettings);
            return _callMutateCampaignExperiments.Async(request, callSettings);
        }

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
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
        public override MutateCampaignExperimentsResponse MutateCampaignExperiments(
            MutateCampaignExperimentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignExperimentsRequest(ref request, ref callSettings);
            return _callMutateCampaignExperiments.Sync(request, callSettings);
        }

        /// <summary>
        /// Graduates a campaign experiment to a full campaign. The base and experiment
        /// campaigns will start running independently with their own budgets.
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
        public override stt::Task<GraduateCampaignExperimentResponse> GraduateCampaignExperimentAsync(
            GraduateCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GraduateCampaignExperimentRequest(ref request, ref callSettings);
            return _callGraduateCampaignExperiment.Async(request, callSettings);
        }

        /// <summary>
        /// Graduates a campaign experiment to a full campaign. The base and experiment
        /// campaigns will start running independently with their own budgets.
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
        public override GraduateCampaignExperimentResponse GraduateCampaignExperiment(
            GraduateCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GraduateCampaignExperimentRequest(ref request, ref callSettings);
            return _callGraduateCampaignExperiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Promotes the changes in a experiment campaign back to the base campaign.
        ///
        /// The campaign experiment is updated immediately with status PROMOTING.
        /// This method return a long running operation that tracks the promoting of
        /// the experiment campaign. If the promoting fails, a list of errors can be
        /// retrieved using the ListCampaignExperimentAsyncErrors method.
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
        public override async stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Empty>> PromoteCampaignExperimentAsync(
            PromoteCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteCampaignExperimentRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Empty>(
                await _callPromoteCampaignExperiment.Async(request, callSettings).ConfigureAwait(false), PromoteCampaignExperimentOperationsClient);
        }

        /// <summary>
        /// Promotes the changes in a experiment campaign back to the base campaign.
        ///
        /// The campaign experiment is updated immediately with status PROMOTING.
        /// This method return a long running operation that tracks the promoting of
        /// the experiment campaign. If the promoting fails, a list of errors can be
        /// retrieved using the ListCampaignExperimentAsyncErrors method.
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
        public override lro::Operation<pbwkt::Empty, pbwkt::Empty> PromoteCampaignExperiment(
            PromoteCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteCampaignExperimentRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Empty>(
                _callPromoteCampaignExperiment.Sync(request, callSettings), PromoteCampaignExperimentOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>PromoteCampaignExperiment</c>.
        /// </summary>
        public override lro::OperationsClient PromoteCampaignExperimentOperationsClient { get; }

        /// <summary>
        /// Immediately ends a campaign experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task EndCampaignExperimentAsync(
            EndCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EndCampaignExperimentRequest(ref request, ref callSettings);
            return _callEndCampaignExperiment.Async(request, callSettings);
        }

        /// <summary>
        /// Immediately ends a campaign experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void EndCampaignExperiment(
            EndCampaignExperimentRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EndCampaignExperimentRequest(ref request, ref callSettings);
            _callEndCampaignExperiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns all errors that occurred during CampaignExperiment create or
        /// promote (whichever occurred last).
        /// Supports standard list paging.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gr::Status"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListCampaignExperimentAsyncErrorsResponse, gr::Status> ListCampaignExperimentAsyncErrorsAsync(
            ListCampaignExperimentAsyncErrorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCampaignExperimentAsyncErrorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCampaignExperimentAsyncErrorsRequest, ListCampaignExperimentAsyncErrorsResponse, gr::Status>(_callListCampaignExperimentAsyncErrors, request, callSettings);
        }

        /// <summary>
        /// Returns all errors that occurred during CampaignExperiment create or
        /// promote (whichever occurred last).
        /// Supports standard list paging.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gr::Status"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListCampaignExperimentAsyncErrorsResponse, gr::Status> ListCampaignExperimentAsyncErrors(
            ListCampaignExperimentAsyncErrorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCampaignExperimentAsyncErrorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCampaignExperimentAsyncErrorsRequest, ListCampaignExperimentAsyncErrorsResponse, gr::Status>(_callListCampaignExperimentAsyncErrors, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListCampaignExperimentAsyncErrorsRequest : gaxgrpc::IPageRequest { }
    public partial class ListCampaignExperimentAsyncErrorsResponse : gaxgrpc::IPageResponse<gr::Status>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<gr::Status> GetEnumerator() => Errors.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class CampaignExperimentService
    {
        public partial class CampaignExperimentServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}

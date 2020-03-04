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
using gr = Google.Rpc;
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
    /// Settings for a <see cref="CampaignDraftServiceClient"/>.
    /// </summary>
    public sealed partial class CampaignDraftServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="CampaignDraftServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="CampaignDraftServiceSettings"/>.
        /// </returns>
        public static CampaignDraftServiceSettings GetDefault() => new CampaignDraftServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignDraftServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignDraftServiceSettings() { }

        private CampaignDraftServiceSettings(CampaignDraftServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCampaignDraftSettings = existing.GetCampaignDraftSettings;
            MutateCampaignDraftsSettings = existing.MutateCampaignDraftsSettings;
            PromoteCampaignDraftSettings = existing.PromoteCampaignDraftSettings;
            PromoteCampaignDraftOperationsSettings = existing.PromoteCampaignDraftOperationsSettings?.Clone();
            ListCampaignDraftAsyncErrorsSettings = existing.ListCampaignDraftAsyncErrorsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignDraftServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="CampaignDraftServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="CampaignDraftServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="CampaignDraftServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="CampaignDraftServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="CampaignDraftServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="CampaignDraftServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="CampaignDraftServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="CampaignDraftServiceClient"/> RPC methods is defined as:
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
        /// <c>CampaignDraftServiceClient.GetCampaignDraft</c> and <c>CampaignDraftServiceClient.GetCampaignDraftAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CampaignDraftServiceClient.GetCampaignDraft</c> and
        /// <c>CampaignDraftServiceClient.GetCampaignDraftAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetCampaignDraftSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignDraftServiceClient.MutateCampaignDrafts</c> and <c>CampaignDraftServiceClient.MutateCampaignDraftsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CampaignDraftServiceClient.MutateCampaignDrafts</c> and
        /// <c>CampaignDraftServiceClient.MutateCampaignDraftsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings MutateCampaignDraftsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignDraftServiceClient.PromoteCampaignDraft</c> and <c>CampaignDraftServiceClient.PromoteCampaignDraftAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CampaignDraftServiceClient.PromoteCampaignDraft</c> and
        /// <c>CampaignDraftServiceClient.PromoteCampaignDraftAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings PromoteCampaignDraftSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CampaignDraftServiceClient.PromoteCampaignDraft</c>.
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
        public lro::OperationsSettings PromoteCampaignDraftOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignDraftServiceClient.ListCampaignDraftAsyncErrors</c> and <c>CampaignDraftServiceClient.ListCampaignDraftAsyncErrorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CampaignDraftServiceClient.ListCampaignDraftAsyncErrors</c> and
        /// <c>CampaignDraftServiceClient.ListCampaignDraftAsyncErrorsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListCampaignDraftAsyncErrorsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="CampaignDraftServiceSettings"/> object.</returns>
        public CampaignDraftServiceSettings Clone() => new CampaignDraftServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignDraftServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CampaignDraftServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignDraftServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public CampaignDraftServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override CampaignDraftServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignDraftServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<CampaignDraftServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignDraftServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => CampaignDraftServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CampaignDraftServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignDraftServiceClient.ChannelPool;
    }

    /// <summary>
    /// CampaignDraftService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class CampaignDraftServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignDraftService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default CampaignDraftService scopes.
        /// </summary>
        /// <remarks>
        /// The default CampaignDraftService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignDraftServiceClient"/>, applying defaults for all unspecified settings,
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
        /// CampaignDraftServiceClient client = await CampaignDraftServiceClient.CreateAsync();
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
        ///     CampaignDraftServiceClient.DefaultEndpoint.Host, CampaignDraftServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CampaignDraftServiceClient client = CampaignDraftServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CampaignDraftServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="CampaignDraftServiceClient"/>.</returns>
        public static async stt::Task<CampaignDraftServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, CampaignDraftServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="CampaignDraftServiceClient"/>, applying defaults for all unspecified settings,
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
        /// CampaignDraftServiceClient client = CampaignDraftServiceClient.Create();
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
        ///     CampaignDraftServiceClient.DefaultEndpoint.Host, CampaignDraftServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CampaignDraftServiceClient client = CampaignDraftServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CampaignDraftServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignDraftServiceClient"/>.</returns>
        public static CampaignDraftServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, CampaignDraftServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="CampaignDraftServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CampaignDraftServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignDraftServiceClient"/>.</returns>
        public static CampaignDraftServiceClient Create(grpccore::Channel channel, CampaignDraftServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="CampaignDraftServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CampaignDraftServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignDraftServiceClient"/>.</returns>
        public static CampaignDraftServiceClient Create(grpccore::CallInvoker callInvoker, CampaignDraftServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignDraftService.CampaignDraftServiceClient grpcClient = new CampaignDraftService.CampaignDraftServiceClient(callInvoker);
            return new CampaignDraftServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, CampaignDraftServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CampaignDraftServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, CampaignDraftServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CampaignDraftServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC CampaignDraftService client.
        /// </summary>
        public virtual CampaignDraftService.CampaignDraftServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested campaign draft in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign draft to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CampaignDraft> GetCampaignDraftAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCampaignDraftAsync(
                new GetCampaignDraftRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested campaign draft in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign draft to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CampaignDraft> GetCampaignDraftAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetCampaignDraftAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign draft in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign draft to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::CampaignDraft GetCampaignDraft(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCampaignDraft(
                new GetCampaignDraftRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested campaign draft in full detail.
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
        public virtual stt::Task<gagvr::CampaignDraft> GetCampaignDraftAsync(
            GetCampaignDraftRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested campaign draft in full detail.
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
        public virtual stt::Task<gagvr::CampaignDraft> GetCampaignDraftAsync(
            GetCampaignDraftRequest request,
            st::CancellationToken cancellationToken) => GetCampaignDraftAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign draft in full detail.
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
        public virtual gagvr::CampaignDraft GetCampaignDraft(
            GetCampaignDraftRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign drafts are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign drafts.
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
        public virtual stt::Task<MutateCampaignDraftsResponse> MutateCampaignDraftsAsync(
            string customerId,
            scg::IEnumerable<CampaignDraftOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignDraftsAsync(
                new MutateCampaignDraftsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign drafts are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign drafts.
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
        public virtual stt::Task<MutateCampaignDraftsResponse> MutateCampaignDraftsAsync(
            string customerId,
            scg::IEnumerable<CampaignDraftOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            st::CancellationToken cancellationToken) => MutateCampaignDraftsAsync(
                customerId,
                operations,
                partialFailure,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign drafts are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign drafts.
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
        public virtual MutateCampaignDraftsResponse MutateCampaignDrafts(
            string customerId,
            scg::IEnumerable<CampaignDraftOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignDrafts(
                new MutateCampaignDraftsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign drafts are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign drafts.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCampaignDraftsResponse> MutateCampaignDraftsAsync(
            string customerId,
            scg::IEnumerable<CampaignDraftOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignDraftsAsync(
                new MutateCampaignDraftsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign drafts are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign drafts.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCampaignDraftsResponse> MutateCampaignDraftsAsync(
            string customerId,
            scg::IEnumerable<CampaignDraftOperation> operations,
            st::CancellationToken cancellationToken) => MutateCampaignDraftsAsync(
                customerId,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign drafts are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign drafts.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateCampaignDraftsResponse MutateCampaignDrafts(
            string customerId,
            scg::IEnumerable<CampaignDraftOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignDrafts(
                new MutateCampaignDraftsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
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
        public virtual stt::Task<MutateCampaignDraftsResponse> MutateCampaignDraftsAsync(
            MutateCampaignDraftsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
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
        public virtual stt::Task<MutateCampaignDraftsResponse> MutateCampaignDraftsAsync(
            MutateCampaignDraftsRequest request,
            st::CancellationToken cancellationToken) => MutateCampaignDraftsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
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
        public virtual MutateCampaignDraftsResponse MutateCampaignDrafts(
            MutateCampaignDraftsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        ///
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v3.services.CampaignDraftService.ListCampaignDraftAsyncErrors] to view the list of
        /// error reasons.
        /// </summary>
        /// <param name="campaignDraft">
        /// Required. The resource name of the campaign draft to promote.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Empty>> PromoteCampaignDraftAsync(
            string campaignDraft,
            gaxgrpc::CallSettings callSettings = null) => PromoteCampaignDraftAsync(
                new PromoteCampaignDraftRequest
                {
                    CampaignDraft = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignDraft, nameof(campaignDraft)),
                },
                callSettings);

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        ///
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v3.services.CampaignDraftService.ListCampaignDraftAsyncErrors] to view the list of
        /// error reasons.
        /// </summary>
        /// <param name="campaignDraft">
        /// Required. The resource name of the campaign draft to promote.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Empty>> PromoteCampaignDraftAsync(
            string campaignDraft,
            st::CancellationToken cancellationToken) => PromoteCampaignDraftAsync(
                campaignDraft,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        ///
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v3.services.CampaignDraftService.ListCampaignDraftAsyncErrors] to view the list of
        /// error reasons.
        /// </summary>
        /// <param name="campaignDraft">
        /// Required. The resource name of the campaign draft to promote.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Empty> PromoteCampaignDraft(
            string campaignDraft,
            gaxgrpc::CallSettings callSettings = null) => PromoteCampaignDraft(
                new PromoteCampaignDraftRequest
                {
                    CampaignDraft = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignDraft, nameof(campaignDraft)),
                },
                callSettings);

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        ///
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v3.services.CampaignDraftService.ListCampaignDraftAsyncErrors] to view the list of
        /// error reasons.
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
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Empty>> PromoteCampaignDraftAsync(
            PromoteCampaignDraftRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PromoteCampaignDraftAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Empty>> PollOncePromoteCampaignDraftAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Empty>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                PromoteCampaignDraftOperationsClient,
                callSettings);

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        ///
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v3.services.CampaignDraftService.ListCampaignDraftAsyncErrors] to view the list of
        /// error reasons.
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
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Empty> PromoteCampaignDraft(
            PromoteCampaignDraftRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>PromoteCampaignDraft</c>.
        /// </summary>
        public virtual lro::OperationsClient PromoteCampaignDraftOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PromoteCampaignDraft</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<pbwkt::Empty, pbwkt::Empty> PollOncePromoteCampaignDraft(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<pbwkt::Empty, pbwkt::Empty>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                PromoteCampaignDraftOperationsClient,
                callSettings);

        /// <summary>
        /// Returns all errors that occurred during CampaignDraft promote. Throws an
        /// error if called before campaign draft is promoted.
        /// Supports standard list paging.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The name of the campaign draft from which to retrieve the async errors.
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
        public virtual gax::PagedAsyncEnumerable<ListCampaignDraftAsyncErrorsResponse, gr::Status> ListCampaignDraftAsyncErrorsAsync(
            string resourceName,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListCampaignDraftAsyncErrorsAsync(
                new ListCampaignDraftAsyncErrorsRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns all errors that occurred during CampaignDraft promote. Throws an
        /// error if called before campaign draft is promoted.
        /// Supports standard list paging.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The name of the campaign draft from which to retrieve the async errors.
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
        public virtual gax::PagedEnumerable<ListCampaignDraftAsyncErrorsResponse, gr::Status> ListCampaignDraftAsyncErrors(
            string resourceName,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListCampaignDraftAsyncErrors(
                new ListCampaignDraftAsyncErrorsRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns all errors that occurred during CampaignDraft promote. Throws an
        /// error if called before campaign draft is promoted.
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
        public virtual gax::PagedAsyncEnumerable<ListCampaignDraftAsyncErrorsResponse, gr::Status> ListCampaignDraftAsyncErrorsAsync(
            ListCampaignDraftAsyncErrorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns all errors that occurred during CampaignDraft promote. Throws an
        /// error if called before campaign draft is promoted.
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
        public virtual gax::PagedEnumerable<ListCampaignDraftAsyncErrorsResponse, gr::Status> ListCampaignDraftAsyncErrors(
            ListCampaignDraftAsyncErrorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// CampaignDraftService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class CampaignDraftServiceClientImpl : CampaignDraftServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCampaignDraftRequest, gagvr::CampaignDraft> _callGetCampaignDraft;
        private readonly gaxgrpc::ApiCall<MutateCampaignDraftsRequest, MutateCampaignDraftsResponse> _callMutateCampaignDrafts;
        private readonly gaxgrpc::ApiCall<PromoteCampaignDraftRequest, lro::Operation> _callPromoteCampaignDraft;
        private readonly gaxgrpc::ApiCall<ListCampaignDraftAsyncErrorsRequest, ListCampaignDraftAsyncErrorsResponse> _callListCampaignDraftAsyncErrors;

        /// <summary>
        /// Constructs a client wrapper for the CampaignDraftService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CampaignDraftServiceSettings"/> used within this client </param>
        public CampaignDraftServiceClientImpl(CampaignDraftService.CampaignDraftServiceClient grpcClient, CampaignDraftServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CampaignDraftServiceSettings effectiveSettings = settings ?? CampaignDraftServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            PromoteCampaignDraftOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.PromoteCampaignDraftOperationsSettings);
            _callGetCampaignDraft = clientHelper.BuildApiCall<GetCampaignDraftRequest, gagvr::CampaignDraft>(
                GrpcClient.GetCampaignDraftAsync, GrpcClient.GetCampaignDraft, effectiveSettings.GetCampaignDraftSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource_name={request.ResourceName}"));
            _callMutateCampaignDrafts = clientHelper.BuildApiCall<MutateCampaignDraftsRequest, MutateCampaignDraftsResponse>(
                GrpcClient.MutateCampaignDraftsAsync, GrpcClient.MutateCampaignDrafts, effectiveSettings.MutateCampaignDraftsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"customer_id={request.CustomerId}"));
            _callPromoteCampaignDraft = clientHelper.BuildApiCall<PromoteCampaignDraftRequest, lro::Operation>(
                GrpcClient.PromoteCampaignDraftAsync, GrpcClient.PromoteCampaignDraft, effectiveSettings.PromoteCampaignDraftSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"campaign_draft={request.CampaignDraft}"));
            _callListCampaignDraftAsyncErrors = clientHelper.BuildApiCall<ListCampaignDraftAsyncErrorsRequest, ListCampaignDraftAsyncErrorsResponse>(
                GrpcClient.ListCampaignDraftAsyncErrorsAsync, GrpcClient.ListCampaignDraftAsyncErrors, effectiveSettings.ListCampaignDraftAsyncErrorsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource_name={request.ResourceName}"));
            Modify_ApiCall(ref _callGetCampaignDraft);
            Modify_GetCampaignDraftApiCall(ref _callGetCampaignDraft);
            Modify_ApiCall(ref _callMutateCampaignDrafts);
            Modify_MutateCampaignDraftsApiCall(ref _callMutateCampaignDrafts);
            Modify_ApiCall(ref _callPromoteCampaignDraft);
            Modify_PromoteCampaignDraftApiCall(ref _callPromoteCampaignDraft);
            Modify_ApiCall(ref _callListCampaignDraftAsyncErrors);
            Modify_ListCampaignDraftAsyncErrorsApiCall(ref _callListCampaignDraftAsyncErrors);
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
        partial void Modify_GetCampaignDraftApiCall(ref gaxgrpc::ApiCall<GetCampaignDraftRequest, gagvr::CampaignDraft> call);
        partial void Modify_MutateCampaignDraftsApiCall(ref gaxgrpc::ApiCall<MutateCampaignDraftsRequest, MutateCampaignDraftsResponse> call);
        partial void Modify_PromoteCampaignDraftApiCall(ref gaxgrpc::ApiCall<PromoteCampaignDraftRequest, lro::Operation> call);
        partial void Modify_ListCampaignDraftAsyncErrorsApiCall(ref gaxgrpc::ApiCall<ListCampaignDraftAsyncErrorsRequest, ListCampaignDraftAsyncErrorsResponse> call);
        partial void OnConstruction(CampaignDraftService.CampaignDraftServiceClient grpcClient, CampaignDraftServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC CampaignDraftService client.
        /// </summary>
        public override CampaignDraftService.CampaignDraftServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetCampaignDraftRequest(ref GetCampaignDraftRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateCampaignDraftsRequest(ref MutateCampaignDraftsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_PromoteCampaignDraftRequest(ref PromoteCampaignDraftRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListCampaignDraftAsyncErrorsRequest(ref ListCampaignDraftAsyncErrorsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested campaign draft in full detail.
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
        public override stt::Task<gagvr::CampaignDraft> GetCampaignDraftAsync(
            GetCampaignDraftRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignDraftRequest(ref request, ref callSettings);
            return _callGetCampaignDraft.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested campaign draft in full detail.
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
        public override gagvr::CampaignDraft GetCampaignDraft(
            GetCampaignDraftRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignDraftRequest(ref request, ref callSettings);
            return _callGetCampaignDraft.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
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
        public override stt::Task<MutateCampaignDraftsResponse> MutateCampaignDraftsAsync(
            MutateCampaignDraftsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignDraftsRequest(ref request, ref callSettings);
            return _callMutateCampaignDrafts.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
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
        public override MutateCampaignDraftsResponse MutateCampaignDrafts(
            MutateCampaignDraftsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignDraftsRequest(ref request, ref callSettings);
            return _callMutateCampaignDrafts.Sync(request, callSettings);
        }

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        ///
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v3.services.CampaignDraftService.ListCampaignDraftAsyncErrors] to view the list of
        /// error reasons.
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
        public override async stt::Task<lro::Operation<pbwkt::Empty, pbwkt::Empty>> PromoteCampaignDraftAsync(
            PromoteCampaignDraftRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteCampaignDraftRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Empty>(
                await _callPromoteCampaignDraft.Async(request, callSettings).ConfigureAwait(false), PromoteCampaignDraftOperationsClient);
        }

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        ///
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v3.services.CampaignDraftService.ListCampaignDraftAsyncErrors] to view the list of
        /// error reasons.
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
        public override lro::Operation<pbwkt::Empty, pbwkt::Empty> PromoteCampaignDraft(
            PromoteCampaignDraftRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteCampaignDraftRequest(ref request, ref callSettings);
            return new lro::Operation<pbwkt::Empty, pbwkt::Empty>(
                _callPromoteCampaignDraft.Sync(request, callSettings), PromoteCampaignDraftOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>PromoteCampaignDraft</c>.
        /// </summary>
        public override lro::OperationsClient PromoteCampaignDraftOperationsClient { get; }

        /// <summary>
        /// Returns all errors that occurred during CampaignDraft promote. Throws an
        /// error if called before campaign draft is promoted.
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
        public override gax::PagedAsyncEnumerable<ListCampaignDraftAsyncErrorsResponse, gr::Status> ListCampaignDraftAsyncErrorsAsync(
            ListCampaignDraftAsyncErrorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCampaignDraftAsyncErrorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCampaignDraftAsyncErrorsRequest, ListCampaignDraftAsyncErrorsResponse, gr::Status>(_callListCampaignDraftAsyncErrors, request, callSettings);
        }

        /// <summary>
        /// Returns all errors that occurred during CampaignDraft promote. Throws an
        /// error if called before campaign draft is promoted.
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
        public override gax::PagedEnumerable<ListCampaignDraftAsyncErrorsResponse, gr::Status> ListCampaignDraftAsyncErrors(
            ListCampaignDraftAsyncErrorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCampaignDraftAsyncErrorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCampaignDraftAsyncErrorsRequest, ListCampaignDraftAsyncErrorsResponse, gr::Status>(_callListCampaignDraftAsyncErrors, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListCampaignDraftAsyncErrorsRequest : gaxgrpc::IPageRequest { }
    public partial class ListCampaignDraftAsyncErrorsResponse : gaxgrpc::IPageResponse<gr::Status>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<gr::Status> GetEnumerator() => Errors.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class CampaignDraftService
    {
        public partial class CampaignDraftServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}

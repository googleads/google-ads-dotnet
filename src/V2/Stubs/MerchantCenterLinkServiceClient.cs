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
    /// Settings for a <see cref="MerchantCenterLinkServiceClient"/>.
    /// </summary>
    public sealed partial class MerchantCenterLinkServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="MerchantCenterLinkServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="MerchantCenterLinkServiceSettings"/>.
        /// </returns>
        public static MerchantCenterLinkServiceSettings GetDefault() => new MerchantCenterLinkServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="MerchantCenterLinkServiceSettings"/> object with default settings.
        /// </summary>
        public MerchantCenterLinkServiceSettings() { }

        private MerchantCenterLinkServiceSettings(MerchantCenterLinkServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListMerchantCenterLinksSettings = existing.ListMerchantCenterLinksSettings;
            GetMerchantCenterLinkSettings = existing.GetMerchantCenterLinkSettings;
            MutateMerchantCenterLinkSettings = existing.MutateMerchantCenterLinkSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MerchantCenterLinkServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="MerchantCenterLinkServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="MerchantCenterLinkServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="MerchantCenterLinkServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="MerchantCenterLinkServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="MerchantCenterLinkServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="MerchantCenterLinkServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="MerchantCenterLinkServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="MerchantCenterLinkServiceClient"/> RPC methods is defined as:
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
        /// <c>MerchantCenterLinkServiceClient.ListMerchantCenterLinks</c> and <c>MerchantCenterLinkServiceClient.ListMerchantCenterLinksAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MerchantCenterLinkServiceClient.ListMerchantCenterLinks</c> and
        /// <c>MerchantCenterLinkServiceClient.ListMerchantCenterLinksAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListMerchantCenterLinksSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MerchantCenterLinkServiceClient.GetMerchantCenterLink</c> and <c>MerchantCenterLinkServiceClient.GetMerchantCenterLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MerchantCenterLinkServiceClient.GetMerchantCenterLink</c> and
        /// <c>MerchantCenterLinkServiceClient.GetMerchantCenterLinkAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetMerchantCenterLinkSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MerchantCenterLinkServiceClient.MutateMerchantCenterLink</c> and <c>MerchantCenterLinkServiceClient.MutateMerchantCenterLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MerchantCenterLinkServiceClient.MutateMerchantCenterLink</c> and
        /// <c>MerchantCenterLinkServiceClient.MutateMerchantCenterLinkAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings MutateMerchantCenterLinkSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="MerchantCenterLinkServiceSettings"/> object.</returns>
        public MerchantCenterLinkServiceSettings Clone() => new MerchantCenterLinkServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MerchantCenterLinkServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class MerchantCenterLinkServiceClientBuilder : gaxgrpc::ClientBuilderBase<MerchantCenterLinkServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public MerchantCenterLinkServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override MerchantCenterLinkServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MerchantCenterLinkServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<MerchantCenterLinkServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MerchantCenterLinkServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => MerchantCenterLinkServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => MerchantCenterLinkServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => MerchantCenterLinkServiceClient.ChannelPool;
    }

    /// <summary>
    /// MerchantCenterLinkService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class MerchantCenterLinkServiceClient
    {
        /// <summary>
        /// The default endpoint for the MerchantCenterLinkService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default MerchantCenterLinkService scopes.
        /// </summary>
        /// <remarks>
        /// The default MerchantCenterLinkService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="MerchantCenterLinkServiceClient"/>, applying defaults for all unspecified settings,
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
        /// MerchantCenterLinkServiceClient client = await MerchantCenterLinkServiceClient.CreateAsync();
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
        ///     MerchantCenterLinkServiceClient.DefaultEndpoint.Host, MerchantCenterLinkServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// MerchantCenterLinkServiceClient client = MerchantCenterLinkServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="MerchantCenterLinkServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="MerchantCenterLinkServiceClient"/>.</returns>
        public static async stt::Task<MerchantCenterLinkServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, MerchantCenterLinkServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="MerchantCenterLinkServiceClient"/>, applying defaults for all unspecified settings,
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
        /// MerchantCenterLinkServiceClient client = MerchantCenterLinkServiceClient.Create();
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
        ///     MerchantCenterLinkServiceClient.DefaultEndpoint.Host, MerchantCenterLinkServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// MerchantCenterLinkServiceClient client = MerchantCenterLinkServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="MerchantCenterLinkServiceSettings"/>.</param>
        /// <returns>The created <see cref="MerchantCenterLinkServiceClient"/>.</returns>
        public static MerchantCenterLinkServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, MerchantCenterLinkServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="MerchantCenterLinkServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="MerchantCenterLinkServiceSettings"/>.</param>
        /// <returns>The created <see cref="MerchantCenterLinkServiceClient"/>.</returns>
        public static MerchantCenterLinkServiceClient Create(grpccore::Channel channel, MerchantCenterLinkServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="MerchantCenterLinkServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="MerchantCenterLinkServiceSettings"/>.</param>
        /// <returns>The created <see cref="MerchantCenterLinkServiceClient"/>.</returns>
        public static MerchantCenterLinkServiceClient Create(grpccore::CallInvoker callInvoker, MerchantCenterLinkServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MerchantCenterLinkService.MerchantCenterLinkServiceClient grpcClient = new MerchantCenterLinkService.MerchantCenterLinkServiceClient(callInvoker);
            return new MerchantCenterLinkServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, MerchantCenterLinkServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, MerchantCenterLinkServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, MerchantCenterLinkServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, MerchantCenterLinkServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC MerchantCenterLinkService client.
        /// </summary>
        public virtual MerchantCenterLinkService.MerchantCenterLinkServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns Merchant Center links available for this customer.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer onto which to apply the Merchant Center link list
        /// operation.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListMerchantCenterLinksResponse> ListMerchantCenterLinksAsync(
            string customerId,
            gaxgrpc::CallSettings callSettings = null) => ListMerchantCenterLinksAsync(
                new ListMerchantCenterLinksRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                },
                callSettings);

        /// <summary>
        /// Returns Merchant Center links available for this customer.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer onto which to apply the Merchant Center link list
        /// operation.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListMerchantCenterLinksResponse> ListMerchantCenterLinksAsync(
            string customerId,
            st::CancellationToken cancellationToken) => ListMerchantCenterLinksAsync(
                customerId,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns Merchant Center links available for this customer.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer onto which to apply the Merchant Center link list
        /// operation.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListMerchantCenterLinksResponse ListMerchantCenterLinks(
            string customerId,
            gaxgrpc::CallSettings callSettings = null) => ListMerchantCenterLinks(
                new ListMerchantCenterLinksRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                },
                callSettings);

        /// <summary>
        /// Returns Merchant Center links available for this customer.
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
        public virtual stt::Task<ListMerchantCenterLinksResponse> ListMerchantCenterLinksAsync(
            ListMerchantCenterLinksRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns Merchant Center links available for this customer.
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
        public virtual stt::Task<ListMerchantCenterLinksResponse> ListMerchantCenterLinksAsync(
            ListMerchantCenterLinksRequest request,
            st::CancellationToken cancellationToken) => ListMerchantCenterLinksAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns Merchant Center links available for this customer.
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
        public virtual ListMerchantCenterLinksResponse ListMerchantCenterLinks(
            ListMerchantCenterLinksRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the Merchant Center link in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Resource name of the Merchant Center link.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::MerchantCenterLink> GetMerchantCenterLinkAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetMerchantCenterLinkAsync(
                new GetMerchantCenterLinkRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the Merchant Center link in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Resource name of the Merchant Center link.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::MerchantCenterLink> GetMerchantCenterLinkAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetMerchantCenterLinkAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Merchant Center link in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Resource name of the Merchant Center link.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::MerchantCenterLink GetMerchantCenterLink(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetMerchantCenterLink(
                new GetMerchantCenterLinkRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the Merchant Center link in full detail.
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
        public virtual stt::Task<gagvr::MerchantCenterLink> GetMerchantCenterLinkAsync(
            GetMerchantCenterLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the Merchant Center link in full detail.
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
        public virtual stt::Task<gagvr::MerchantCenterLink> GetMerchantCenterLinkAsync(
            GetMerchantCenterLinkRequest request,
            st::CancellationToken cancellationToken) => GetMerchantCenterLinkAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Merchant Center link in full detail.
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
        public virtual gagvr::MerchantCenterLink GetMerchantCenterLink(
            GetMerchantCenterLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates status or removes a Merchant Center link.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// The operation to perform on the link
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateMerchantCenterLinkResponse> MutateMerchantCenterLinkAsync(
            string customerId,
            MerchantCenterLinkOperation operation,
            gaxgrpc::CallSettings callSettings = null) => MutateMerchantCenterLinkAsync(
                new MutateMerchantCenterLinkRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
                },
                callSettings);

        /// <summary>
        /// Updates status or removes a Merchant Center link.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// The operation to perform on the link
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateMerchantCenterLinkResponse> MutateMerchantCenterLinkAsync(
            string customerId,
            MerchantCenterLinkOperation operation,
            st::CancellationToken cancellationToken) => MutateMerchantCenterLinkAsync(
                customerId,
                operation,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates status or removes a Merchant Center link.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// The operation to perform on the link
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateMerchantCenterLinkResponse MutateMerchantCenterLink(
            string customerId,
            MerchantCenterLinkOperation operation,
            gaxgrpc::CallSettings callSettings = null) => MutateMerchantCenterLink(
                new MutateMerchantCenterLinkRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
                },
                callSettings);

        /// <summary>
        /// Updates status or removes a Merchant Center link.
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
        public virtual stt::Task<MutateMerchantCenterLinkResponse> MutateMerchantCenterLinkAsync(
            MutateMerchantCenterLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates status or removes a Merchant Center link.
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
        public virtual stt::Task<MutateMerchantCenterLinkResponse> MutateMerchantCenterLinkAsync(
            MutateMerchantCenterLinkRequest request,
            st::CancellationToken cancellationToken) => MutateMerchantCenterLinkAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates status or removes a Merchant Center link.
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
        public virtual MutateMerchantCenterLinkResponse MutateMerchantCenterLink(
            MutateMerchantCenterLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// MerchantCenterLinkService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class MerchantCenterLinkServiceClientImpl : MerchantCenterLinkServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListMerchantCenterLinksRequest, ListMerchantCenterLinksResponse> _callListMerchantCenterLinks;
        private readonly gaxgrpc::ApiCall<GetMerchantCenterLinkRequest, gagvr::MerchantCenterLink> _callGetMerchantCenterLink;
        private readonly gaxgrpc::ApiCall<MutateMerchantCenterLinkRequest, MutateMerchantCenterLinkResponse> _callMutateMerchantCenterLink;

        /// <summary>
        /// Constructs a client wrapper for the MerchantCenterLinkService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MerchantCenterLinkServiceSettings"/> used within this client </param>
        public MerchantCenterLinkServiceClientImpl(MerchantCenterLinkService.MerchantCenterLinkServiceClient grpcClient, MerchantCenterLinkServiceSettings settings)
        {
            GrpcClient = grpcClient;
            MerchantCenterLinkServiceSettings effectiveSettings = settings ?? MerchantCenterLinkServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListMerchantCenterLinks = clientHelper.BuildApiCall<ListMerchantCenterLinksRequest, ListMerchantCenterLinksResponse>(
                GrpcClient.ListMerchantCenterLinksAsync, GrpcClient.ListMerchantCenterLinks, effectiveSettings.ListMerchantCenterLinksSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"customer_id={request.CustomerId}"));
            _callGetMerchantCenterLink = clientHelper.BuildApiCall<GetMerchantCenterLinkRequest, gagvr::MerchantCenterLink>(
                GrpcClient.GetMerchantCenterLinkAsync, GrpcClient.GetMerchantCenterLink, effectiveSettings.GetMerchantCenterLinkSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource_name={request.ResourceName}"));
            _callMutateMerchantCenterLink = clientHelper.BuildApiCall<MutateMerchantCenterLinkRequest, MutateMerchantCenterLinkResponse>(
                GrpcClient.MutateMerchantCenterLinkAsync, GrpcClient.MutateMerchantCenterLink, effectiveSettings.MutateMerchantCenterLinkSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"customer_id={request.CustomerId}"));
            Modify_ApiCall(ref _callListMerchantCenterLinks);
            Modify_ListMerchantCenterLinksApiCall(ref _callListMerchantCenterLinks);
            Modify_ApiCall(ref _callGetMerchantCenterLink);
            Modify_GetMerchantCenterLinkApiCall(ref _callGetMerchantCenterLink);
            Modify_ApiCall(ref _callMutateMerchantCenterLink);
            Modify_MutateMerchantCenterLinkApiCall(ref _callMutateMerchantCenterLink);
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
        partial void Modify_ListMerchantCenterLinksApiCall(ref gaxgrpc::ApiCall<ListMerchantCenterLinksRequest, ListMerchantCenterLinksResponse> call);
        partial void Modify_GetMerchantCenterLinkApiCall(ref gaxgrpc::ApiCall<GetMerchantCenterLinkRequest, gagvr::MerchantCenterLink> call);
        partial void Modify_MutateMerchantCenterLinkApiCall(ref gaxgrpc::ApiCall<MutateMerchantCenterLinkRequest, MutateMerchantCenterLinkResponse> call);
        partial void OnConstruction(MerchantCenterLinkService.MerchantCenterLinkServiceClient grpcClient, MerchantCenterLinkServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC MerchantCenterLinkService client.
        /// </summary>
        public override MerchantCenterLinkService.MerchantCenterLinkServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListMerchantCenterLinksRequest(ref ListMerchantCenterLinksRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetMerchantCenterLinkRequest(ref GetMerchantCenterLinkRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateMerchantCenterLinkRequest(ref MutateMerchantCenterLinkRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns Merchant Center links available for this customer.
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
        public override stt::Task<ListMerchantCenterLinksResponse> ListMerchantCenterLinksAsync(
            ListMerchantCenterLinksRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMerchantCenterLinksRequest(ref request, ref callSettings);
            return _callListMerchantCenterLinks.Async(request, callSettings);
        }

        /// <summary>
        /// Returns Merchant Center links available for this customer.
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
        public override ListMerchantCenterLinksResponse ListMerchantCenterLinks(
            ListMerchantCenterLinksRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMerchantCenterLinksRequest(ref request, ref callSettings);
            return _callListMerchantCenterLinks.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the Merchant Center link in full detail.
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
        public override stt::Task<gagvr::MerchantCenterLink> GetMerchantCenterLinkAsync(
            GetMerchantCenterLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMerchantCenterLinkRequest(ref request, ref callSettings);
            return _callGetMerchantCenterLink.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the Merchant Center link in full detail.
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
        public override gagvr::MerchantCenterLink GetMerchantCenterLink(
            GetMerchantCenterLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMerchantCenterLinkRequest(ref request, ref callSettings);
            return _callGetMerchantCenterLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates status or removes a Merchant Center link.
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
        public override stt::Task<MutateMerchantCenterLinkResponse> MutateMerchantCenterLinkAsync(
            MutateMerchantCenterLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateMerchantCenterLinkRequest(ref request, ref callSettings);
            return _callMutateMerchantCenterLink.Async(request, callSettings);
        }

        /// <summary>
        /// Updates status or removes a Merchant Center link.
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
        public override MutateMerchantCenterLinkResponse MutateMerchantCenterLink(
            MutateMerchantCenterLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateMerchantCenterLinkRequest(ref request, ref callSettings);
            return _callMutateMerchantCenterLink.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

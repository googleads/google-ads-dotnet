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
    /// Settings for a <see cref="GeoTargetConstantServiceClient"/>.
    /// </summary>
    public sealed partial class GeoTargetConstantServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="GeoTargetConstantServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="GeoTargetConstantServiceSettings"/>.
        /// </returns>
        public static GeoTargetConstantServiceSettings GetDefault() => new GeoTargetConstantServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="GeoTargetConstantServiceSettings"/> object with default settings.
        /// </summary>
        public GeoTargetConstantServiceSettings() { }

        private GeoTargetConstantServiceSettings(GeoTargetConstantServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetGeoTargetConstantSettings = existing.GetGeoTargetConstantSettings;
            SuggestGeoTargetConstantsSettings = existing.SuggestGeoTargetConstantsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GeoTargetConstantServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="GeoTargetConstantServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="GeoTargetConstantServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="GeoTargetConstantServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="GeoTargetConstantServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="GeoTargetConstantServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="GeoTargetConstantServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="GeoTargetConstantServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="GeoTargetConstantServiceClient"/> RPC methods is defined as:
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
        /// <c>GeoTargetConstantServiceClient.GetGeoTargetConstant</c> and <c>GeoTargetConstantServiceClient.GetGeoTargetConstantAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GeoTargetConstantServiceClient.GetGeoTargetConstant</c> and
        /// <c>GeoTargetConstantServiceClient.GetGeoTargetConstantAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetGeoTargetConstantSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GeoTargetConstantServiceClient.SuggestGeoTargetConstants</c> and <c>GeoTargetConstantServiceClient.SuggestGeoTargetConstantsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GeoTargetConstantServiceClient.SuggestGeoTargetConstants</c> and
        /// <c>GeoTargetConstantServiceClient.SuggestGeoTargetConstantsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SuggestGeoTargetConstantsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="GeoTargetConstantServiceSettings"/> object.</returns>
        public GeoTargetConstantServiceSettings Clone() => new GeoTargetConstantServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GeoTargetConstantServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class GeoTargetConstantServiceClientBuilder : gaxgrpc::ClientBuilderBase<GeoTargetConstantServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public GeoTargetConstantServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override GeoTargetConstantServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GeoTargetConstantServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<GeoTargetConstantServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GeoTargetConstantServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => GeoTargetConstantServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => GeoTargetConstantServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => GeoTargetConstantServiceClient.ChannelPool;
    }

    /// <summary>
    /// GeoTargetConstantService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class GeoTargetConstantServiceClient
    {
        /// <summary>
        /// The default endpoint for the GeoTargetConstantService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default GeoTargetConstantService scopes.
        /// </summary>
        /// <remarks>
        /// The default GeoTargetConstantService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="GeoTargetConstantServiceClient"/>, applying defaults for all unspecified settings,
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
        /// GeoTargetConstantServiceClient client = await GeoTargetConstantServiceClient.CreateAsync();
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
        ///     GeoTargetConstantServiceClient.DefaultEndpoint.Host, GeoTargetConstantServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// GeoTargetConstantServiceClient client = GeoTargetConstantServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="GeoTargetConstantServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="GeoTargetConstantServiceClient"/>.</returns>
        public static async stt::Task<GeoTargetConstantServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, GeoTargetConstantServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="GeoTargetConstantServiceClient"/>, applying defaults for all unspecified settings,
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
        /// GeoTargetConstantServiceClient client = GeoTargetConstantServiceClient.Create();
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
        ///     GeoTargetConstantServiceClient.DefaultEndpoint.Host, GeoTargetConstantServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// GeoTargetConstantServiceClient client = GeoTargetConstantServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="GeoTargetConstantServiceSettings"/>.</param>
        /// <returns>The created <see cref="GeoTargetConstantServiceClient"/>.</returns>
        public static GeoTargetConstantServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, GeoTargetConstantServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="GeoTargetConstantServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="GeoTargetConstantServiceSettings"/>.</param>
        /// <returns>The created <see cref="GeoTargetConstantServiceClient"/>.</returns>
        public static GeoTargetConstantServiceClient Create(grpccore::Channel channel, GeoTargetConstantServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="GeoTargetConstantServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="GeoTargetConstantServiceSettings"/>.</param>
        /// <returns>The created <see cref="GeoTargetConstantServiceClient"/>.</returns>
        public static GeoTargetConstantServiceClient Create(grpccore::CallInvoker callInvoker, GeoTargetConstantServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GeoTargetConstantService.GeoTargetConstantServiceClient grpcClient = new GeoTargetConstantService.GeoTargetConstantServiceClient(callInvoker);
            return new GeoTargetConstantServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, GeoTargetConstantServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, GeoTargetConstantServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, GeoTargetConstantServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, GeoTargetConstantServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC GeoTargetConstantService client.
        /// </summary>
        public virtual GeoTargetConstantService.GeoTargetConstantServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested geo target constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the geo target constant to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::GeoTargetConstant> GetGeoTargetConstantAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetGeoTargetConstantAsync(
                new GetGeoTargetConstantRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested geo target constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the geo target constant to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::GeoTargetConstant> GetGeoTargetConstantAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetGeoTargetConstantAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested geo target constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the geo target constant to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::GeoTargetConstant GetGeoTargetConstant(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetGeoTargetConstant(
                new GetGeoTargetConstantRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested geo target constant in full detail.
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
        public virtual stt::Task<gagvr::GeoTargetConstant> GetGeoTargetConstantAsync(
            GetGeoTargetConstantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested geo target constant in full detail.
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
        public virtual stt::Task<gagvr::GeoTargetConstant> GetGeoTargetConstantAsync(
            GetGeoTargetConstantRequest request,
            st::CancellationToken cancellationToken) => GetGeoTargetConstantAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested geo target constant in full detail.
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
        public virtual gagvr::GeoTargetConstant GetGeoTargetConstant(
            GetGeoTargetConstantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns GeoTargetConstant suggestions by location name or by resource name.
        /// </summary>
        /// <param name="locale">
        /// If possible, returned geo targets are translated using this locale. If not,
        /// en is used by default. This is also used as a hint for returned geo
        /// targets.
        /// </param>
        /// <param name="countryCode">
        /// Returned geo targets are restricted to this country code.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SuggestGeoTargetConstantsResponse> SuggestGeoTargetConstantsAsync(
            string locale,
            string countryCode,
            gaxgrpc::CallSettings callSettings = null) => SuggestGeoTargetConstantsAsync(
                new SuggestGeoTargetConstantsRequest
                {
                    Locale = gax::GaxPreconditions.CheckNotNullOrEmpty(locale, nameof(locale)),
                    CountryCode = gax::GaxPreconditions.CheckNotNullOrEmpty(countryCode, nameof(countryCode)),
                },
                callSettings);

        /// <summary>
        /// Returns GeoTargetConstant suggestions by location name or by resource name.
        /// </summary>
        /// <param name="locale">
        /// If possible, returned geo targets are translated using this locale. If not,
        /// en is used by default. This is also used as a hint for returned geo
        /// targets.
        /// </param>
        /// <param name="countryCode">
        /// Returned geo targets are restricted to this country code.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SuggestGeoTargetConstantsResponse> SuggestGeoTargetConstantsAsync(
            string locale,
            string countryCode,
            st::CancellationToken cancellationToken) => SuggestGeoTargetConstantsAsync(
                locale,
                countryCode,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns GeoTargetConstant suggestions by location name or by resource name.
        /// </summary>
        /// <param name="locale">
        /// If possible, returned geo targets are translated using this locale. If not,
        /// en is used by default. This is also used as a hint for returned geo
        /// targets.
        /// </param>
        /// <param name="countryCode">
        /// Returned geo targets are restricted to this country code.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SuggestGeoTargetConstantsResponse SuggestGeoTargetConstants(
            string locale,
            string countryCode,
            gaxgrpc::CallSettings callSettings = null) => SuggestGeoTargetConstants(
                new SuggestGeoTargetConstantsRequest
                {
                    Locale = gax::GaxPreconditions.CheckNotNullOrEmpty(locale, nameof(locale)),
                    CountryCode = gax::GaxPreconditions.CheckNotNullOrEmpty(countryCode, nameof(countryCode)),
                },
                callSettings);

        /// <summary>
        /// Returns GeoTargetConstant suggestions by location name or by resource name.
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
        public virtual stt::Task<SuggestGeoTargetConstantsResponse> SuggestGeoTargetConstantsAsync(
            SuggestGeoTargetConstantsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns GeoTargetConstant suggestions by location name or by resource name.
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
        public virtual stt::Task<SuggestGeoTargetConstantsResponse> SuggestGeoTargetConstantsAsync(
            SuggestGeoTargetConstantsRequest request,
            st::CancellationToken cancellationToken) => SuggestGeoTargetConstantsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns GeoTargetConstant suggestions by location name or by resource name.
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
        public virtual SuggestGeoTargetConstantsResponse SuggestGeoTargetConstants(
            SuggestGeoTargetConstantsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// GeoTargetConstantService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class GeoTargetConstantServiceClientImpl : GeoTargetConstantServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetGeoTargetConstantRequest, gagvr::GeoTargetConstant> _callGetGeoTargetConstant;
        private readonly gaxgrpc::ApiCall<SuggestGeoTargetConstantsRequest, SuggestGeoTargetConstantsResponse> _callSuggestGeoTargetConstants;

        /// <summary>
        /// Constructs a client wrapper for the GeoTargetConstantService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GeoTargetConstantServiceSettings"/> used within this client </param>
        public GeoTargetConstantServiceClientImpl(GeoTargetConstantService.GeoTargetConstantServiceClient grpcClient, GeoTargetConstantServiceSettings settings)
        {
            GrpcClient = grpcClient;
            GeoTargetConstantServiceSettings effectiveSettings = settings ?? GeoTargetConstantServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetGeoTargetConstant = clientHelper.BuildApiCall<GetGeoTargetConstantRequest, gagvr::GeoTargetConstant>(
                GrpcClient.GetGeoTargetConstantAsync, GrpcClient.GetGeoTargetConstant, effectiveSettings.GetGeoTargetConstantSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource_name={request.ResourceName}"));
            _callSuggestGeoTargetConstants = clientHelper.BuildApiCall<SuggestGeoTargetConstantsRequest, SuggestGeoTargetConstantsResponse>(
                GrpcClient.SuggestGeoTargetConstantsAsync, GrpcClient.SuggestGeoTargetConstants, effectiveSettings.SuggestGeoTargetConstantsSettings);
            Modify_ApiCall(ref _callGetGeoTargetConstant);
            Modify_GetGeoTargetConstantApiCall(ref _callGetGeoTargetConstant);
            Modify_ApiCall(ref _callSuggestGeoTargetConstants);
            Modify_SuggestGeoTargetConstantsApiCall(ref _callSuggestGeoTargetConstants);
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
        partial void Modify_GetGeoTargetConstantApiCall(ref gaxgrpc::ApiCall<GetGeoTargetConstantRequest, gagvr::GeoTargetConstant> call);
        partial void Modify_SuggestGeoTargetConstantsApiCall(ref gaxgrpc::ApiCall<SuggestGeoTargetConstantsRequest, SuggestGeoTargetConstantsResponse> call);
        partial void OnConstruction(GeoTargetConstantService.GeoTargetConstantServiceClient grpcClient, GeoTargetConstantServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC GeoTargetConstantService client.
        /// </summary>
        public override GeoTargetConstantService.GeoTargetConstantServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetGeoTargetConstantRequest(ref GetGeoTargetConstantRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SuggestGeoTargetConstantsRequest(ref SuggestGeoTargetConstantsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested geo target constant in full detail.
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
        public override stt::Task<gagvr::GeoTargetConstant> GetGeoTargetConstantAsync(
            GetGeoTargetConstantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGeoTargetConstantRequest(ref request, ref callSettings);
            return _callGetGeoTargetConstant.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested geo target constant in full detail.
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
        public override gagvr::GeoTargetConstant GetGeoTargetConstant(
            GetGeoTargetConstantRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGeoTargetConstantRequest(ref request, ref callSettings);
            return _callGetGeoTargetConstant.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns GeoTargetConstant suggestions by location name or by resource name.
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
        public override stt::Task<SuggestGeoTargetConstantsResponse> SuggestGeoTargetConstantsAsync(
            SuggestGeoTargetConstantsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestGeoTargetConstantsRequest(ref request, ref callSettings);
            return _callSuggestGeoTargetConstants.Async(request, callSettings);
        }

        /// <summary>
        /// Returns GeoTargetConstant suggestions by location name or by resource name.
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
        public override SuggestGeoTargetConstantsResponse SuggestGeoTargetConstants(
            SuggestGeoTargetConstantsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestGeoTargetConstantsRequest(ref request, ref callSettings);
            return _callSuggestGeoTargetConstants.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

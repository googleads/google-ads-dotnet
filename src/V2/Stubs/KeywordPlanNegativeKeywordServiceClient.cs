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
    /// Settings for a <see cref="KeywordPlanNegativeKeywordServiceClient"/>.
    /// </summary>
    public sealed partial class KeywordPlanNegativeKeywordServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="KeywordPlanNegativeKeywordServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="KeywordPlanNegativeKeywordServiceSettings"/>.
        /// </returns>
        public static KeywordPlanNegativeKeywordServiceSettings GetDefault() => new KeywordPlanNegativeKeywordServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="KeywordPlanNegativeKeywordServiceSettings"/> object with default settings.
        /// </summary>
        public KeywordPlanNegativeKeywordServiceSettings() { }

        private KeywordPlanNegativeKeywordServiceSettings(KeywordPlanNegativeKeywordServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetKeywordPlanNegativeKeywordSettings = existing.GetKeywordPlanNegativeKeywordSettings;
            MutateKeywordPlanNegativeKeywordsSettings = existing.MutateKeywordPlanNegativeKeywordsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(KeywordPlanNegativeKeywordServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="KeywordPlanNegativeKeywordServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="KeywordPlanNegativeKeywordServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="KeywordPlanNegativeKeywordServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="KeywordPlanNegativeKeywordServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="KeywordPlanNegativeKeywordServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="KeywordPlanNegativeKeywordServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="KeywordPlanNegativeKeywordServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="KeywordPlanNegativeKeywordServiceClient"/> RPC methods is defined as:
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
        /// <c>KeywordPlanNegativeKeywordServiceClient.GetKeywordPlanNegativeKeyword</c> and <c>KeywordPlanNegativeKeywordServiceClient.GetKeywordPlanNegativeKeywordAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeywordPlanNegativeKeywordServiceClient.GetKeywordPlanNegativeKeyword</c> and
        /// <c>KeywordPlanNegativeKeywordServiceClient.GetKeywordPlanNegativeKeywordAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetKeywordPlanNegativeKeywordSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanNegativeKeywordServiceClient.MutateKeywordPlanNegativeKeywords</c> and <c>KeywordPlanNegativeKeywordServiceClient.MutateKeywordPlanNegativeKeywordsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeywordPlanNegativeKeywordServiceClient.MutateKeywordPlanNegativeKeywords</c> and
        /// <c>KeywordPlanNegativeKeywordServiceClient.MutateKeywordPlanNegativeKeywordsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings MutateKeywordPlanNegativeKeywordsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="KeywordPlanNegativeKeywordServiceSettings"/> object.</returns>
        public KeywordPlanNegativeKeywordServiceSettings Clone() => new KeywordPlanNegativeKeywordServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="KeywordPlanNegativeKeywordServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class KeywordPlanNegativeKeywordServiceClientBuilder : gaxgrpc::ClientBuilderBase<KeywordPlanNegativeKeywordServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public KeywordPlanNegativeKeywordServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override KeywordPlanNegativeKeywordServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return KeywordPlanNegativeKeywordServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<KeywordPlanNegativeKeywordServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return KeywordPlanNegativeKeywordServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => KeywordPlanNegativeKeywordServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => KeywordPlanNegativeKeywordServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => KeywordPlanNegativeKeywordServiceClient.ChannelPool;
    }

    /// <summary>
    /// KeywordPlanNegativeKeywordService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class KeywordPlanNegativeKeywordServiceClient
    {
        /// <summary>
        /// The default endpoint for the KeywordPlanNegativeKeywordService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default KeywordPlanNegativeKeywordService scopes.
        /// </summary>
        /// <remarks>
        /// The default KeywordPlanNegativeKeywordService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="KeywordPlanNegativeKeywordServiceClient"/>, applying defaults for all unspecified settings,
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
        /// KeywordPlanNegativeKeywordServiceClient client = await KeywordPlanNegativeKeywordServiceClient.CreateAsync();
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
        ///     KeywordPlanNegativeKeywordServiceClient.DefaultEndpoint.Host, KeywordPlanNegativeKeywordServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// KeywordPlanNegativeKeywordServiceClient client = KeywordPlanNegativeKeywordServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="KeywordPlanNegativeKeywordServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="KeywordPlanNegativeKeywordServiceClient"/>.</returns>
        public static async stt::Task<KeywordPlanNegativeKeywordServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, KeywordPlanNegativeKeywordServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="KeywordPlanNegativeKeywordServiceClient"/>, applying defaults for all unspecified settings,
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
        /// KeywordPlanNegativeKeywordServiceClient client = KeywordPlanNegativeKeywordServiceClient.Create();
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
        ///     KeywordPlanNegativeKeywordServiceClient.DefaultEndpoint.Host, KeywordPlanNegativeKeywordServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// KeywordPlanNegativeKeywordServiceClient client = KeywordPlanNegativeKeywordServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="KeywordPlanNegativeKeywordServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeywordPlanNegativeKeywordServiceClient"/>.</returns>
        public static KeywordPlanNegativeKeywordServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, KeywordPlanNegativeKeywordServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="KeywordPlanNegativeKeywordServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="KeywordPlanNegativeKeywordServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeywordPlanNegativeKeywordServiceClient"/>.</returns>
        public static KeywordPlanNegativeKeywordServiceClient Create(grpccore::Channel channel, KeywordPlanNegativeKeywordServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="KeywordPlanNegativeKeywordServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="KeywordPlanNegativeKeywordServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeywordPlanNegativeKeywordServiceClient"/>.</returns>
        public static KeywordPlanNegativeKeywordServiceClient Create(grpccore::CallInvoker callInvoker, KeywordPlanNegativeKeywordServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient grpcClient = new KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient(callInvoker);
            return new KeywordPlanNegativeKeywordServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, KeywordPlanNegativeKeywordServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, KeywordPlanNegativeKeywordServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, KeywordPlanNegativeKeywordServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, KeywordPlanNegativeKeywordServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC KeywordPlanNegativeKeywordService client.
        /// </summary>
        public virtual KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient GrpcClient
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
        public virtual stt::Task<gagvr::KeywordPlanNegativeKeyword> GetKeywordPlanNegativeKeywordAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetKeywordPlanNegativeKeywordAsync(
                new GetKeywordPlanNegativeKeywordRequest
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
        public virtual stt::Task<gagvr::KeywordPlanNegativeKeyword> GetKeywordPlanNegativeKeywordAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetKeywordPlanNegativeKeywordAsync(
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
        public virtual gagvr::KeywordPlanNegativeKeyword GetKeywordPlanNegativeKeyword(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetKeywordPlanNegativeKeyword(
                new GetKeywordPlanNegativeKeywordRequest
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
        public virtual stt::Task<gagvr::KeywordPlanNegativeKeyword> GetKeywordPlanNegativeKeywordAsync(
            GetKeywordPlanNegativeKeywordRequest request,
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
        public virtual stt::Task<gagvr::KeywordPlanNegativeKeyword> GetKeywordPlanNegativeKeywordAsync(
            GetKeywordPlanNegativeKeywordRequest request,
            st::CancellationToken cancellationToken) => GetKeywordPlanNegativeKeywordAsync(
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
        public virtual gagvr::KeywordPlanNegativeKeyword GetKeywordPlanNegativeKeyword(
            GetKeywordPlanNegativeKeywordRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose negative keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual Keyword Plan negative
        /// keywords.
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
        public virtual stt::Task<MutateKeywordPlanNegativeKeywordsResponse> MutateKeywordPlanNegativeKeywordsAsync(
            string customerId,
            scg::IEnumerable<KeywordPlanNegativeKeywordOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlanNegativeKeywordsAsync(
                new MutateKeywordPlanNegativeKeywordsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose negative keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual Keyword Plan negative
        /// keywords.
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
        public virtual stt::Task<MutateKeywordPlanNegativeKeywordsResponse> MutateKeywordPlanNegativeKeywordsAsync(
            string customerId,
            scg::IEnumerable<KeywordPlanNegativeKeywordOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            st::CancellationToken cancellationToken) => MutateKeywordPlanNegativeKeywordsAsync(
                customerId,
                operations,
                partialFailure,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose negative keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual Keyword Plan negative
        /// keywords.
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
        public virtual MutateKeywordPlanNegativeKeywordsResponse MutateKeywordPlanNegativeKeywords(
            string customerId,
            scg::IEnumerable<KeywordPlanNegativeKeywordOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlanNegativeKeywords(
                new MutateKeywordPlanNegativeKeywordsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose negative keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual Keyword Plan negative
        /// keywords.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateKeywordPlanNegativeKeywordsResponse> MutateKeywordPlanNegativeKeywordsAsync(
            string customerId,
            scg::IEnumerable<KeywordPlanNegativeKeywordOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlanNegativeKeywordsAsync(
                new MutateKeywordPlanNegativeKeywordsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose negative keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual Keyword Plan negative
        /// keywords.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateKeywordPlanNegativeKeywordsResponse> MutateKeywordPlanNegativeKeywordsAsync(
            string customerId,
            scg::IEnumerable<KeywordPlanNegativeKeywordOperation> operations,
            st::CancellationToken cancellationToken) => MutateKeywordPlanNegativeKeywordsAsync(
                customerId,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose negative keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual Keyword Plan negative
        /// keywords.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateKeywordPlanNegativeKeywordsResponse MutateKeywordPlanNegativeKeywords(
            string customerId,
            scg::IEnumerable<KeywordPlanNegativeKeywordOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlanNegativeKeywords(
                new MutateKeywordPlanNegativeKeywordsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
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
        public virtual stt::Task<MutateKeywordPlanNegativeKeywordsResponse> MutateKeywordPlanNegativeKeywordsAsync(
            MutateKeywordPlanNegativeKeywordsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
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
        public virtual stt::Task<MutateKeywordPlanNegativeKeywordsResponse> MutateKeywordPlanNegativeKeywordsAsync(
            MutateKeywordPlanNegativeKeywordsRequest request,
            st::CancellationToken cancellationToken) => MutateKeywordPlanNegativeKeywordsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
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
        public virtual MutateKeywordPlanNegativeKeywordsResponse MutateKeywordPlanNegativeKeywords(
            MutateKeywordPlanNegativeKeywordsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// KeywordPlanNegativeKeywordService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class KeywordPlanNegativeKeywordServiceClientImpl : KeywordPlanNegativeKeywordServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetKeywordPlanNegativeKeywordRequest, gagvr::KeywordPlanNegativeKeyword> _callGetKeywordPlanNegativeKeyword;
        private readonly gaxgrpc::ApiCall<MutateKeywordPlanNegativeKeywordsRequest, MutateKeywordPlanNegativeKeywordsResponse> _callMutateKeywordPlanNegativeKeywords;

        /// <summary>
        /// Constructs a client wrapper for the KeywordPlanNegativeKeywordService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="KeywordPlanNegativeKeywordServiceSettings"/> used within this client </param>
        public KeywordPlanNegativeKeywordServiceClientImpl(KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient grpcClient, KeywordPlanNegativeKeywordServiceSettings settings)
        {
            GrpcClient = grpcClient;
            KeywordPlanNegativeKeywordServiceSettings effectiveSettings = settings ?? KeywordPlanNegativeKeywordServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetKeywordPlanNegativeKeyword = clientHelper.BuildApiCall<GetKeywordPlanNegativeKeywordRequest, gagvr::KeywordPlanNegativeKeyword>(
                GrpcClient.GetKeywordPlanNegativeKeywordAsync, GrpcClient.GetKeywordPlanNegativeKeyword, effectiveSettings.GetKeywordPlanNegativeKeywordSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource_name={request.ResourceName}"));
            _callMutateKeywordPlanNegativeKeywords = clientHelper.BuildApiCall<MutateKeywordPlanNegativeKeywordsRequest, MutateKeywordPlanNegativeKeywordsResponse>(
                GrpcClient.MutateKeywordPlanNegativeKeywordsAsync, GrpcClient.MutateKeywordPlanNegativeKeywords, effectiveSettings.MutateKeywordPlanNegativeKeywordsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"customer_id={request.CustomerId}"));
            Modify_ApiCall(ref _callGetKeywordPlanNegativeKeyword);
            Modify_GetKeywordPlanNegativeKeywordApiCall(ref _callGetKeywordPlanNegativeKeyword);
            Modify_ApiCall(ref _callMutateKeywordPlanNegativeKeywords);
            Modify_MutateKeywordPlanNegativeKeywordsApiCall(ref _callMutateKeywordPlanNegativeKeywords);
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
        partial void Modify_GetKeywordPlanNegativeKeywordApiCall(ref gaxgrpc::ApiCall<GetKeywordPlanNegativeKeywordRequest, gagvr::KeywordPlanNegativeKeyword> call);
        partial void Modify_MutateKeywordPlanNegativeKeywordsApiCall(ref gaxgrpc::ApiCall<MutateKeywordPlanNegativeKeywordsRequest, MutateKeywordPlanNegativeKeywordsResponse> call);
        partial void OnConstruction(KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient grpcClient, KeywordPlanNegativeKeywordServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC KeywordPlanNegativeKeywordService client.
        /// </summary>
        public override KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetKeywordPlanNegativeKeywordRequest(ref GetKeywordPlanNegativeKeywordRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateKeywordPlanNegativeKeywordsRequest(ref MutateKeywordPlanNegativeKeywordsRequest request, ref gaxgrpc::CallSettings settings);

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
        public override stt::Task<gagvr::KeywordPlanNegativeKeyword> GetKeywordPlanNegativeKeywordAsync(
            GetKeywordPlanNegativeKeywordRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanNegativeKeywordRequest(ref request, ref callSettings);
            return _callGetKeywordPlanNegativeKeyword.Async(request, callSettings);
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
        public override gagvr::KeywordPlanNegativeKeyword GetKeywordPlanNegativeKeyword(
            GetKeywordPlanNegativeKeywordRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanNegativeKeywordRequest(ref request, ref callSettings);
            return _callGetKeywordPlanNegativeKeyword.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
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
        public override stt::Task<MutateKeywordPlanNegativeKeywordsResponse> MutateKeywordPlanNegativeKeywordsAsync(
            MutateKeywordPlanNegativeKeywordsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlanNegativeKeywordsRequest(ref request, ref callSettings);
            return _callMutateKeywordPlanNegativeKeywords.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
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
        public override MutateKeywordPlanNegativeKeywordsResponse MutateKeywordPlanNegativeKeywords(
            MutateKeywordPlanNegativeKeywordsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlanNegativeKeywordsRequest(ref request, ref callSettings);
            return _callMutateKeywordPlanNegativeKeywords.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

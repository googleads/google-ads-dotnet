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
    /// Settings for a <see cref="KeywordPlanKeywordServiceClient"/>.
    /// </summary>
    public sealed partial class KeywordPlanKeywordServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="KeywordPlanKeywordServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="KeywordPlanKeywordServiceSettings"/>.
        /// </returns>
        public static KeywordPlanKeywordServiceSettings GetDefault() => new KeywordPlanKeywordServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="KeywordPlanKeywordServiceSettings"/> object with default settings.
        /// </summary>
        public KeywordPlanKeywordServiceSettings() { }

        private KeywordPlanKeywordServiceSettings(KeywordPlanKeywordServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetKeywordPlanKeywordSettings = existing.GetKeywordPlanKeywordSettings;
            MutateKeywordPlanKeywordsSettings = existing.MutateKeywordPlanKeywordsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(KeywordPlanKeywordServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="KeywordPlanKeywordServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="KeywordPlanKeywordServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="KeywordPlanKeywordServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="KeywordPlanKeywordServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="KeywordPlanKeywordServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="KeywordPlanKeywordServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="KeywordPlanKeywordServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="KeywordPlanKeywordServiceClient"/> RPC methods is defined as:
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
        /// <c>KeywordPlanKeywordServiceClient.GetKeywordPlanKeyword</c> and <c>KeywordPlanKeywordServiceClient.GetKeywordPlanKeywordAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeywordPlanKeywordServiceClient.GetKeywordPlanKeyword</c> and
        /// <c>KeywordPlanKeywordServiceClient.GetKeywordPlanKeywordAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetKeywordPlanKeywordSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanKeywordServiceClient.MutateKeywordPlanKeywords</c> and <c>KeywordPlanKeywordServiceClient.MutateKeywordPlanKeywordsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeywordPlanKeywordServiceClient.MutateKeywordPlanKeywords</c> and
        /// <c>KeywordPlanKeywordServiceClient.MutateKeywordPlanKeywordsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings MutateKeywordPlanKeywordsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="KeywordPlanKeywordServiceSettings"/> object.</returns>
        public KeywordPlanKeywordServiceSettings Clone() => new KeywordPlanKeywordServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="KeywordPlanKeywordServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class KeywordPlanKeywordServiceClientBuilder : gaxgrpc::ClientBuilderBase<KeywordPlanKeywordServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public KeywordPlanKeywordServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override KeywordPlanKeywordServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return KeywordPlanKeywordServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<KeywordPlanKeywordServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return KeywordPlanKeywordServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => KeywordPlanKeywordServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => KeywordPlanKeywordServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => KeywordPlanKeywordServiceClient.ChannelPool;
    }

    /// <summary>
    /// KeywordPlanKeywordService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class KeywordPlanKeywordServiceClient
    {
        /// <summary>
        /// The default endpoint for the KeywordPlanKeywordService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default KeywordPlanKeywordService scopes.
        /// </summary>
        /// <remarks>
        /// The default KeywordPlanKeywordService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="KeywordPlanKeywordServiceClient"/>, applying defaults for all unspecified settings,
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
        /// KeywordPlanKeywordServiceClient client = await KeywordPlanKeywordServiceClient.CreateAsync();
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
        ///     KeywordPlanKeywordServiceClient.DefaultEndpoint.Host, KeywordPlanKeywordServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// KeywordPlanKeywordServiceClient client = KeywordPlanKeywordServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="KeywordPlanKeywordServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="KeywordPlanKeywordServiceClient"/>.</returns>
        public static async stt::Task<KeywordPlanKeywordServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, KeywordPlanKeywordServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="KeywordPlanKeywordServiceClient"/>, applying defaults for all unspecified settings,
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
        /// KeywordPlanKeywordServiceClient client = KeywordPlanKeywordServiceClient.Create();
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
        ///     KeywordPlanKeywordServiceClient.DefaultEndpoint.Host, KeywordPlanKeywordServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// KeywordPlanKeywordServiceClient client = KeywordPlanKeywordServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="KeywordPlanKeywordServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeywordPlanKeywordServiceClient"/>.</returns>
        public static KeywordPlanKeywordServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, KeywordPlanKeywordServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="KeywordPlanKeywordServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="KeywordPlanKeywordServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeywordPlanKeywordServiceClient"/>.</returns>
        public static KeywordPlanKeywordServiceClient Create(grpccore::Channel channel, KeywordPlanKeywordServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="KeywordPlanKeywordServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="KeywordPlanKeywordServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeywordPlanKeywordServiceClient"/>.</returns>
        public static KeywordPlanKeywordServiceClient Create(grpccore::CallInvoker callInvoker, KeywordPlanKeywordServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            KeywordPlanKeywordService.KeywordPlanKeywordServiceClient grpcClient = new KeywordPlanKeywordService.KeywordPlanKeywordServiceClient(callInvoker);
            return new KeywordPlanKeywordServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, KeywordPlanKeywordServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, KeywordPlanKeywordServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, KeywordPlanKeywordServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, KeywordPlanKeywordServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC KeywordPlanKeywordService client.
        /// </summary>
        public virtual KeywordPlanKeywordService.KeywordPlanKeywordServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group keyword to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::KeywordPlanKeyword> GetKeywordPlanKeywordAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetKeywordPlanKeywordAsync(
                new GetKeywordPlanKeywordRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group keyword to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::KeywordPlanKeyword> GetKeywordPlanKeywordAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetKeywordPlanKeywordAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group keyword to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::KeywordPlanKeyword GetKeywordPlanKeyword(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetKeywordPlanKeyword(
                new GetKeywordPlanKeywordRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
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
        public virtual stt::Task<gagvr::KeywordPlanKeyword> GetKeywordPlanKeywordAsync(
            GetKeywordPlanKeywordRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
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
        public virtual stt::Task<gagvr::KeywordPlanKeyword> GetKeywordPlanKeywordAsync(
            GetKeywordPlanKeywordRequest request,
            st::CancellationToken cancellationToken) => GetKeywordPlanKeywordAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
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
        public virtual gagvr::KeywordPlanKeyword GetKeywordPlanKeyword(
            GetKeywordPlanKeywordRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan keywords.
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
        public virtual stt::Task<MutateKeywordPlanKeywordsResponse> MutateKeywordPlanKeywordsAsync(
            string customerId,
            scg::IEnumerable<KeywordPlanKeywordOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlanKeywordsAsync(
                new MutateKeywordPlanKeywordsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan keywords.
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
        public virtual stt::Task<MutateKeywordPlanKeywordsResponse> MutateKeywordPlanKeywordsAsync(
            string customerId,
            scg::IEnumerable<KeywordPlanKeywordOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            st::CancellationToken cancellationToken) => MutateKeywordPlanKeywordsAsync(
                customerId,
                operations,
                partialFailure,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan keywords.
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
        public virtual MutateKeywordPlanKeywordsResponse MutateKeywordPlanKeywords(
            string customerId,
            scg::IEnumerable<KeywordPlanKeywordOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlanKeywords(
                new MutateKeywordPlanKeywordsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan keywords.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateKeywordPlanKeywordsResponse> MutateKeywordPlanKeywordsAsync(
            string customerId,
            scg::IEnumerable<KeywordPlanKeywordOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlanKeywordsAsync(
                new MutateKeywordPlanKeywordsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan keywords.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateKeywordPlanKeywordsResponse> MutateKeywordPlanKeywordsAsync(
            string customerId,
            scg::IEnumerable<KeywordPlanKeywordOperation> operations,
            st::CancellationToken cancellationToken) => MutateKeywordPlanKeywordsAsync(
                customerId,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan keywords.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateKeywordPlanKeywordsResponse MutateKeywordPlanKeywords(
            string customerId,
            scg::IEnumerable<KeywordPlanKeywordOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateKeywordPlanKeywords(
                new MutateKeywordPlanKeywordsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
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
        public virtual stt::Task<MutateKeywordPlanKeywordsResponse> MutateKeywordPlanKeywordsAsync(
            MutateKeywordPlanKeywordsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
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
        public virtual stt::Task<MutateKeywordPlanKeywordsResponse> MutateKeywordPlanKeywordsAsync(
            MutateKeywordPlanKeywordsRequest request,
            st::CancellationToken cancellationToken) => MutateKeywordPlanKeywordsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
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
        public virtual MutateKeywordPlanKeywordsResponse MutateKeywordPlanKeywords(
            MutateKeywordPlanKeywordsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// KeywordPlanKeywordService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class KeywordPlanKeywordServiceClientImpl : KeywordPlanKeywordServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetKeywordPlanKeywordRequest, gagvr::KeywordPlanKeyword> _callGetKeywordPlanKeyword;
        private readonly gaxgrpc::ApiCall<MutateKeywordPlanKeywordsRequest, MutateKeywordPlanKeywordsResponse> _callMutateKeywordPlanKeywords;

        /// <summary>
        /// Constructs a client wrapper for the KeywordPlanKeywordService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="KeywordPlanKeywordServiceSettings"/> used within this client </param>
        public KeywordPlanKeywordServiceClientImpl(KeywordPlanKeywordService.KeywordPlanKeywordServiceClient grpcClient, KeywordPlanKeywordServiceSettings settings)
        {
            GrpcClient = grpcClient;
            KeywordPlanKeywordServiceSettings effectiveSettings = settings ?? KeywordPlanKeywordServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetKeywordPlanKeyword = clientHelper.BuildApiCall<GetKeywordPlanKeywordRequest, gagvr::KeywordPlanKeyword>(
                GrpcClient.GetKeywordPlanKeywordAsync, GrpcClient.GetKeywordPlanKeyword, effectiveSettings.GetKeywordPlanKeywordSettings)
                .WithGoogleRequestParam("resource_name", request => request.ResourceName);
            _callMutateKeywordPlanKeywords = clientHelper.BuildApiCall<MutateKeywordPlanKeywordsRequest, MutateKeywordPlanKeywordsResponse>(
                GrpcClient.MutateKeywordPlanKeywordsAsync, GrpcClient.MutateKeywordPlanKeywords, effectiveSettings.MutateKeywordPlanKeywordsSettings)
                .WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGetKeywordPlanKeyword);
            Modify_GetKeywordPlanKeywordApiCall(ref _callGetKeywordPlanKeyword);
            Modify_ApiCall(ref _callMutateKeywordPlanKeywords);
            Modify_MutateKeywordPlanKeywordsApiCall(ref _callMutateKeywordPlanKeywords);
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
        partial void Modify_GetKeywordPlanKeywordApiCall(ref gaxgrpc::ApiCall<GetKeywordPlanKeywordRequest, gagvr::KeywordPlanKeyword> call);
        partial void Modify_MutateKeywordPlanKeywordsApiCall(ref gaxgrpc::ApiCall<MutateKeywordPlanKeywordsRequest, MutateKeywordPlanKeywordsResponse> call);
        partial void OnConstruction(KeywordPlanKeywordService.KeywordPlanKeywordServiceClient grpcClient, KeywordPlanKeywordServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC KeywordPlanKeywordService client.
        /// </summary>
        public override KeywordPlanKeywordService.KeywordPlanKeywordServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetKeywordPlanKeywordRequest(ref GetKeywordPlanKeywordRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateKeywordPlanKeywordsRequest(ref MutateKeywordPlanKeywordsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
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
        public override stt::Task<gagvr::KeywordPlanKeyword> GetKeywordPlanKeywordAsync(
            GetKeywordPlanKeywordRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanKeywordRequest(ref request, ref callSettings);
            return _callGetKeywordPlanKeyword.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
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
        public override gagvr::KeywordPlanKeyword GetKeywordPlanKeyword(
            GetKeywordPlanKeywordRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanKeywordRequest(ref request, ref callSettings);
            return _callGetKeywordPlanKeyword.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
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
        public override stt::Task<MutateKeywordPlanKeywordsResponse> MutateKeywordPlanKeywordsAsync(
            MutateKeywordPlanKeywordsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlanKeywordsRequest(ref request, ref callSettings);
            return _callMutateKeywordPlanKeywords.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
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
        public override MutateKeywordPlanKeywordsResponse MutateKeywordPlanKeywords(
            MutateKeywordPlanKeywordsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlanKeywordsRequest(ref request, ref callSettings);
            return _callMutateKeywordPlanKeywords.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

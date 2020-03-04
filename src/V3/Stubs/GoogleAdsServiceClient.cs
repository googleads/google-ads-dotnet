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

using gagve = Google.Ads.GoogleAds.V3.Enums;
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
    /// Settings for a <see cref="GoogleAdsServiceClient"/>.
    /// </summary>
    public sealed partial class GoogleAdsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="GoogleAdsServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="GoogleAdsServiceSettings"/>.
        /// </returns>
        public static GoogleAdsServiceSettings GetDefault() => new GoogleAdsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="GoogleAdsServiceSettings"/> object with default settings.
        /// </summary>
        public GoogleAdsServiceSettings() { }

        private GoogleAdsServiceSettings(GoogleAdsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SearchSettings = existing.SearchSettings;
            SearchStreamSettings = existing.SearchStreamSettings;
            MutateSettings = existing.MutateSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GoogleAdsServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="GoogleAdsServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="GoogleAdsServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="GoogleAdsServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="GoogleAdsServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="GoogleAdsServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="GoogleAdsServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="GoogleAdsServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="GoogleAdsServiceClient"/> RPC methods is defined as:
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
        /// <c>GoogleAdsServiceClient.Search</c> and <c>GoogleAdsServiceClient.SearchAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GoogleAdsServiceClient.Search</c> and
        /// <c>GoogleAdsServiceClient.SearchAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SearchSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for calls to <c>GoogleAdsServiceClient.SearchStream</c>.
        /// </summary>
        /// <remarks>
        /// Default RPC expiration is 3600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings SearchStreamSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GoogleAdsServiceClient.Mutate</c> and <c>GoogleAdsServiceClient.MutateAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GoogleAdsServiceClient.Mutate</c> and
        /// <c>GoogleAdsServiceClient.MutateAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings MutateSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="GoogleAdsServiceSettings"/> object.</returns>
        public GoogleAdsServiceSettings Clone() => new GoogleAdsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GoogleAdsServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class GoogleAdsServiceClientBuilder : gaxgrpc::ClientBuilderBase<GoogleAdsServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public GoogleAdsServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override GoogleAdsServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GoogleAdsServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<GoogleAdsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GoogleAdsServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => GoogleAdsServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => GoogleAdsServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => GoogleAdsServiceClient.ChannelPool;
    }

    /// <summary>
    /// GoogleAdsService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class GoogleAdsServiceClient
    {
        /// <summary>
        /// The default endpoint for the GoogleAdsService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default GoogleAdsService scopes.
        /// </summary>
        /// <remarks>
        /// The default GoogleAdsService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="GoogleAdsServiceClient"/>, applying defaults for all unspecified settings,
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
        /// GoogleAdsServiceClient client = await GoogleAdsServiceClient.CreateAsync();
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
        ///     GoogleAdsServiceClient.DefaultEndpoint.Host, GoogleAdsServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// GoogleAdsServiceClient client = GoogleAdsServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="GoogleAdsServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="GoogleAdsServiceClient"/>.</returns>
        public static async stt::Task<GoogleAdsServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, GoogleAdsServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="GoogleAdsServiceClient"/>, applying defaults for all unspecified settings,
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
        /// GoogleAdsServiceClient client = GoogleAdsServiceClient.Create();
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
        ///     GoogleAdsServiceClient.DefaultEndpoint.Host, GoogleAdsServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// GoogleAdsServiceClient client = GoogleAdsServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="GoogleAdsServiceSettings"/>.</param>
        /// <returns>The created <see cref="GoogleAdsServiceClient"/>.</returns>
        public static GoogleAdsServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, GoogleAdsServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="GoogleAdsServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="GoogleAdsServiceSettings"/>.</param>
        /// <returns>The created <see cref="GoogleAdsServiceClient"/>.</returns>
        public static GoogleAdsServiceClient Create(grpccore::Channel channel, GoogleAdsServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="GoogleAdsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="GoogleAdsServiceSettings"/>.</param>
        /// <returns>The created <see cref="GoogleAdsServiceClient"/>.</returns>
        public static GoogleAdsServiceClient Create(grpccore::CallInvoker callInvoker, GoogleAdsServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GoogleAdsService.GoogleAdsServiceClient grpcClient = new GoogleAdsService.GoogleAdsServiceClient(callInvoker);
            return new GoogleAdsServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, GoogleAdsServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, GoogleAdsServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, GoogleAdsServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, GoogleAdsServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC GoogleAdsService client.
        /// </summary>
        public virtual GoogleAdsService.GoogleAdsServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns all rows that match the search query.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="GoogleAdsRow"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> SearchAsync(
            SearchGoogleAdsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns all rows that match the search query.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="GoogleAdsRow"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> Search(
            SearchGoogleAdsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns all rows that match the search stream query.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being queried.
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="summaryRowSetting">
        /// Determines whether a summary row will be returned. By default, summary row
        /// is not returned. If requested, the summary row will be sent in a response
        /// by itself after all other query results are returned.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual SearchStreamStream SearchStream(
            string customerId,
            string query,
            gagve::SummaryRowSettingEnum.Types.SummaryRowSetting? summaryRowSetting,
            gaxgrpc::CallSettings callSettings = null) => SearchStream(
                new SearchGoogleAdsStreamRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
                    SummaryRowSetting = summaryRowSetting ?? gagve::SummaryRowSettingEnum.Types.SummaryRowSetting.Unspecified, // Optional
                },
                callSettings);

        /// <summary>
        /// Returns all rows that match the search stream query.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being queried.
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual SearchStreamStream SearchStream(
            string customerId,
            string query,
            gaxgrpc::CallSettings callSettings = null) => SearchStream(
                new SearchGoogleAdsStreamRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
                },
                callSettings);

        /// <summary>
        /// Returns all rows that match the search stream query.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual SearchStreamStream SearchStream(
            SearchGoogleAdsStreamRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Server streaming methods for <c>SearchStream</c>.
        /// </summary>
        public abstract partial class SearchStreamStream : gaxgrpc::ServerStreamingBase<SearchGoogleAdsStreamResponse>
        {
        }

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        ///
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        ///
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        ///
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        ///
        /// ## Atomic Transaction Benefits
        ///
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the desired state directly, or the request
        /// fails and you can retry.
        ///
        /// ## Temp Resource Names
        ///
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        ///
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        ///
        /// Note:
        ///
        /// - Resources must be created with a temp name before the name can be reused.
        ///   For example, the previous CampaignBudget+Campaign example would fail if
        ///   the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        ///   types differ.
        ///
        /// ## Latency
        ///
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose resources are being modified.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of operations to perform on individual resources.
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
        public virtual stt::Task<MutateGoogleAdsResponse> MutateAsync(
            string customerId,
            scg::IEnumerable<MutateOperation> mutateOperations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateAsync(
                new MutateGoogleAdsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    MutateOperations = { gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        ///
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        ///
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        ///
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        ///
        /// ## Atomic Transaction Benefits
        ///
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the desired state directly, or the request
        /// fails and you can retry.
        ///
        /// ## Temp Resource Names
        ///
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        ///
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        ///
        /// Note:
        ///
        /// - Resources must be created with a temp name before the name can be reused.
        ///   For example, the previous CampaignBudget+Campaign example would fail if
        ///   the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        ///   types differ.
        ///
        /// ## Latency
        ///
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose resources are being modified.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of operations to perform on individual resources.
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
        public virtual stt::Task<MutateGoogleAdsResponse> MutateAsync(
            string customerId,
            scg::IEnumerable<MutateOperation> mutateOperations,
            bool? partialFailure,
            bool? validateOnly,
            st::CancellationToken cancellationToken) => MutateAsync(
                customerId,
                mutateOperations,
                partialFailure,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        ///
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        ///
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        ///
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        ///
        /// ## Atomic Transaction Benefits
        ///
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the desired state directly, or the request
        /// fails and you can retry.
        ///
        /// ## Temp Resource Names
        ///
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        ///
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        ///
        /// Note:
        ///
        /// - Resources must be created with a temp name before the name can be reused.
        ///   For example, the previous CampaignBudget+Campaign example would fail if
        ///   the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        ///   types differ.
        ///
        /// ## Latency
        ///
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose resources are being modified.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of operations to perform on individual resources.
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
        public virtual MutateGoogleAdsResponse Mutate(
            string customerId,
            scg::IEnumerable<MutateOperation> mutateOperations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => Mutate(
                new MutateGoogleAdsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    MutateOperations = { gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        ///
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        ///
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        ///
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        ///
        /// ## Atomic Transaction Benefits
        ///
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the desired state directly, or the request
        /// fails and you can retry.
        ///
        /// ## Temp Resource Names
        ///
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        ///
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        ///
        /// Note:
        ///
        /// - Resources must be created with a temp name before the name can be reused.
        ///   For example, the previous CampaignBudget+Campaign example would fail if
        ///   the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        ///   types differ.
        ///
        /// ## Latency
        ///
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose resources are being modified.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of operations to perform on individual resources.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateGoogleAdsResponse> MutateAsync(
            string customerId,
            scg::IEnumerable<MutateOperation> mutateOperations,
            gaxgrpc::CallSettings callSettings = null) => MutateAsync(
                new MutateGoogleAdsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    MutateOperations = { gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        ///
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        ///
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        ///
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        ///
        /// ## Atomic Transaction Benefits
        ///
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the desired state directly, or the request
        /// fails and you can retry.
        ///
        /// ## Temp Resource Names
        ///
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        ///
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        ///
        /// Note:
        ///
        /// - Resources must be created with a temp name before the name can be reused.
        ///   For example, the previous CampaignBudget+Campaign example would fail if
        ///   the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        ///   types differ.
        ///
        /// ## Latency
        ///
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose resources are being modified.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of operations to perform on individual resources.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateGoogleAdsResponse> MutateAsync(
            string customerId,
            scg::IEnumerable<MutateOperation> mutateOperations,
            st::CancellationToken cancellationToken) => MutateAsync(
                customerId,
                mutateOperations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        ///
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        ///
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        ///
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        ///
        /// ## Atomic Transaction Benefits
        ///
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the desired state directly, or the request
        /// fails and you can retry.
        ///
        /// ## Temp Resource Names
        ///
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        ///
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        ///
        /// Note:
        ///
        /// - Resources must be created with a temp name before the name can be reused.
        ///   For example, the previous CampaignBudget+Campaign example would fail if
        ///   the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        ///   types differ.
        ///
        /// ## Latency
        ///
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose resources are being modified.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of operations to perform on individual resources.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateGoogleAdsResponse Mutate(
            string customerId,
            scg::IEnumerable<MutateOperation> mutateOperations,
            gaxgrpc::CallSettings callSettings = null) => Mutate(
                new MutateGoogleAdsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    MutateOperations = { gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        ///
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        ///
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        ///
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        ///
        /// ## Atomic Transaction Benefits
        ///
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the desired state directly, or the request
        /// fails and you can retry.
        ///
        /// ## Temp Resource Names
        ///
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        ///
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        ///
        /// Note:
        ///
        /// - Resources must be created with a temp name before the name can be reused.
        ///   For example, the previous CampaignBudget+Campaign example would fail if
        ///   the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        ///   types differ.
        ///
        /// ## Latency
        ///
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
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
        public virtual stt::Task<MutateGoogleAdsResponse> MutateAsync(
            MutateGoogleAdsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        ///
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        ///
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        ///
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        ///
        /// ## Atomic Transaction Benefits
        ///
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the desired state directly, or the request
        /// fails and you can retry.
        ///
        /// ## Temp Resource Names
        ///
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        ///
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        ///
        /// Note:
        ///
        /// - Resources must be created with a temp name before the name can be reused.
        ///   For example, the previous CampaignBudget+Campaign example would fail if
        ///   the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        ///   types differ.
        ///
        /// ## Latency
        ///
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
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
        public virtual stt::Task<MutateGoogleAdsResponse> MutateAsync(
            MutateGoogleAdsRequest request,
            st::CancellationToken cancellationToken) => MutateAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        ///
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        ///
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        ///
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        ///
        /// ## Atomic Transaction Benefits
        ///
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the desired state directly, or the request
        /// fails and you can retry.
        ///
        /// ## Temp Resource Names
        ///
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        ///
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        ///
        /// Note:
        ///
        /// - Resources must be created with a temp name before the name can be reused.
        ///   For example, the previous CampaignBudget+Campaign example would fail if
        ///   the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        ///   types differ.
        ///
        /// ## Latency
        ///
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
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
        public virtual MutateGoogleAdsResponse Mutate(
            MutateGoogleAdsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// GoogleAdsService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class GoogleAdsServiceClientImpl : GoogleAdsServiceClient
    {
        private readonly gaxgrpc::ApiCall<SearchGoogleAdsRequest, SearchGoogleAdsResponse> _callSearch;
        private readonly gaxgrpc::ApiServerStreamingCall<SearchGoogleAdsStreamRequest, SearchGoogleAdsStreamResponse> _callSearchStream;
        private readonly gaxgrpc::ApiCall<MutateGoogleAdsRequest, MutateGoogleAdsResponse> _callMutate;

        /// <summary>
        /// Constructs a client wrapper for the GoogleAdsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GoogleAdsServiceSettings"/> used within this client </param>
        public GoogleAdsServiceClientImpl(GoogleAdsService.GoogleAdsServiceClient grpcClient, GoogleAdsServiceSettings settings)
        {
            GrpcClient = grpcClient;
            GoogleAdsServiceSettings effectiveSettings = settings ?? GoogleAdsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callSearch = clientHelper.BuildApiCall<SearchGoogleAdsRequest, SearchGoogleAdsResponse>(
                GrpcClient.SearchAsync, GrpcClient.Search, effectiveSettings.SearchSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"customer_id={request.CustomerId}"));
            _callSearchStream = clientHelper.BuildApiCall<SearchGoogleAdsStreamRequest, SearchGoogleAdsStreamResponse>(
                GrpcClient.SearchStream, effectiveSettings.SearchStreamSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"customer_id={request.CustomerId}"));
            _callMutate = clientHelper.BuildApiCall<MutateGoogleAdsRequest, MutateGoogleAdsResponse>(
                GrpcClient.MutateAsync, GrpcClient.Mutate, effectiveSettings.MutateSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"customer_id={request.CustomerId}"));
            Modify_ApiCall(ref _callSearch);
            Modify_SearchApiCall(ref _callSearch);
            Modify_ApiCall(ref _callSearchStream);
            Modify_SearchStreamApiCall(ref _callSearchStream);
            Modify_ApiCall(ref _callMutate);
            Modify_MutateApiCall(ref _callMutate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_SearchApiCall(ref gaxgrpc::ApiCall<SearchGoogleAdsRequest, SearchGoogleAdsResponse> call);
        partial void Modify_SearchStreamApiCall(ref gaxgrpc::ApiServerStreamingCall<SearchGoogleAdsStreamRequest, SearchGoogleAdsStreamResponse> call);
        partial void Modify_MutateApiCall(ref gaxgrpc::ApiCall<MutateGoogleAdsRequest, MutateGoogleAdsResponse> call);
        partial void OnConstruction(GoogleAdsService.GoogleAdsServiceClient grpcClient, GoogleAdsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC GoogleAdsService client.
        /// </summary>
        public override GoogleAdsService.GoogleAdsServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_SearchGoogleAdsRequest(ref SearchGoogleAdsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SearchGoogleAdsStreamRequest(ref SearchGoogleAdsStreamRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateGoogleAdsRequest(ref MutateGoogleAdsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns all rows that match the search query.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="GoogleAdsRow"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> SearchAsync(
            SearchGoogleAdsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchGoogleAdsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchGoogleAdsRequest, SearchGoogleAdsResponse, GoogleAdsRow>(_callSearch, request, callSettings);
        }

        /// <summary>
        /// Returns all rows that match the search query.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="GoogleAdsRow"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> Search(
            SearchGoogleAdsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchGoogleAdsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchGoogleAdsRequest, SearchGoogleAdsResponse, GoogleAdsRow>(_callSearch, request, callSettings);
        }

        /// <summary>
        /// Returns all rows that match the search stream query.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public override SearchStreamStream SearchStream(
            SearchGoogleAdsStreamRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchGoogleAdsStreamRequest(ref request, ref callSettings);
            return new SearchStreamStreamImpl(_callSearchStream.Call(request, callSettings));
        }

        internal sealed partial class SearchStreamStreamImpl : SearchStreamStream
        {
            /// <summary>
            /// Construct the server-streaming method for <c>SearchStream</c>.
            /// </summary>
            /// <param name="call">The underlying gRPC server-streaming call.</param>
            internal SearchStreamStreamImpl(grpccore::AsyncServerStreamingCall<SearchGoogleAdsStreamResponse> call)
            {
                GrpcCall = call;
            }

            /// <inheritdoc/>
            public override grpccore::AsyncServerStreamingCall<SearchGoogleAdsStreamResponse> GrpcCall { get; }

            /// <inheritdoc/>
            public override scg::IAsyncEnumerator<SearchGoogleAdsStreamResponse> ResponseStream => GrpcCall.ResponseStream;
        }

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        ///
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        ///
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        ///
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        ///
        /// ## Atomic Transaction Benefits
        ///
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the desired state directly, or the request
        /// fails and you can retry.
        ///
        /// ## Temp Resource Names
        ///
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        ///
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        ///
        /// Note:
        ///
        /// - Resources must be created with a temp name before the name can be reused.
        ///   For example, the previous CampaignBudget+Campaign example would fail if
        ///   the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        ///   types differ.
        ///
        /// ## Latency
        ///
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
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
        public override stt::Task<MutateGoogleAdsResponse> MutateAsync(
            MutateGoogleAdsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateGoogleAdsRequest(ref request, ref callSettings);
            return _callMutate.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        ///
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        ///
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        ///
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        ///
        /// ## Atomic Transaction Benefits
        ///
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the desired state directly, or the request
        /// fails and you can retry.
        ///
        /// ## Temp Resource Names
        ///
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        ///
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        ///
        /// Note:
        ///
        /// - Resources must be created with a temp name before the name can be reused.
        ///   For example, the previous CampaignBudget+Campaign example would fail if
        ///   the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        ///   types differ.
        ///
        /// ## Latency
        ///
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
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
        public override MutateGoogleAdsResponse Mutate(
            MutateGoogleAdsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateGoogleAdsRequest(ref request, ref callSettings);
            return _callMutate.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class SearchGoogleAdsRequest : gaxgrpc::IPageRequest { }
    public partial class SearchGoogleAdsResponse : gaxgrpc::IPageResponse<GoogleAdsRow>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<GoogleAdsRow> GetEnumerator() => Results.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}

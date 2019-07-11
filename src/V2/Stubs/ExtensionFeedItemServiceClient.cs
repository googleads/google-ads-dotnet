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
    /// Settings for a <see cref="ExtensionFeedItemServiceClient"/>.
    /// </summary>
    public sealed partial class ExtensionFeedItemServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ExtensionFeedItemServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ExtensionFeedItemServiceSettings"/>.
        /// </returns>
        public static ExtensionFeedItemServiceSettings GetDefault() => new ExtensionFeedItemServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ExtensionFeedItemServiceSettings"/> object with default settings.
        /// </summary>
        public ExtensionFeedItemServiceSettings() { }

        private ExtensionFeedItemServiceSettings(ExtensionFeedItemServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetExtensionFeedItemSettings = existing.GetExtensionFeedItemSettings;
            MutateExtensionFeedItemsSettings = existing.MutateExtensionFeedItemsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ExtensionFeedItemServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ExtensionFeedItemServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="ExtensionFeedItemServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ExtensionFeedItemServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ExtensionFeedItemServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ExtensionFeedItemServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="ExtensionFeedItemServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ExtensionFeedItemServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ExtensionFeedItemServiceClient"/> RPC methods is defined as:
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
        /// <c>ExtensionFeedItemServiceClient.GetExtensionFeedItem</c> and <c>ExtensionFeedItemServiceClient.GetExtensionFeedItemAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ExtensionFeedItemServiceClient.GetExtensionFeedItem</c> and
        /// <c>ExtensionFeedItemServiceClient.GetExtensionFeedItemAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetExtensionFeedItemSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExtensionFeedItemServiceClient.MutateExtensionFeedItems</c> and <c>ExtensionFeedItemServiceClient.MutateExtensionFeedItemsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ExtensionFeedItemServiceClient.MutateExtensionFeedItems</c> and
        /// <c>ExtensionFeedItemServiceClient.MutateExtensionFeedItemsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings MutateExtensionFeedItemsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ExtensionFeedItemServiceSettings"/> object.</returns>
        public ExtensionFeedItemServiceSettings Clone() => new ExtensionFeedItemServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ExtensionFeedItemServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ExtensionFeedItemServiceClientBuilder : gaxgrpc::ClientBuilderBase<ExtensionFeedItemServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public ExtensionFeedItemServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override ExtensionFeedItemServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ExtensionFeedItemServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<ExtensionFeedItemServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ExtensionFeedItemServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => ExtensionFeedItemServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ExtensionFeedItemServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => ExtensionFeedItemServiceClient.ChannelPool;
    }

    /// <summary>
    /// ExtensionFeedItemService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ExtensionFeedItemServiceClient
    {
        /// <summary>
        /// The default endpoint for the ExtensionFeedItemService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default ExtensionFeedItemService scopes.
        /// </summary>
        /// <remarks>
        /// The default ExtensionFeedItemService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="ExtensionFeedItemServiceClient"/>, applying defaults for all unspecified settings,
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
        /// ExtensionFeedItemServiceClient client = await ExtensionFeedItemServiceClient.CreateAsync();
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
        ///     ExtensionFeedItemServiceClient.DefaultEndpoint.Host, ExtensionFeedItemServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ExtensionFeedItemServiceClient client = ExtensionFeedItemServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ExtensionFeedItemServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ExtensionFeedItemServiceClient"/>.</returns>
        public static async stt::Task<ExtensionFeedItemServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ExtensionFeedItemServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ExtensionFeedItemServiceClient"/>, applying defaults for all unspecified settings,
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
        /// ExtensionFeedItemServiceClient client = ExtensionFeedItemServiceClient.Create();
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
        ///     ExtensionFeedItemServiceClient.DefaultEndpoint.Host, ExtensionFeedItemServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ExtensionFeedItemServiceClient client = ExtensionFeedItemServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ExtensionFeedItemServiceSettings"/>.</param>
        /// <returns>The created <see cref="ExtensionFeedItemServiceClient"/>.</returns>
        public static ExtensionFeedItemServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, ExtensionFeedItemServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ExtensionFeedItemServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ExtensionFeedItemServiceSettings"/>.</param>
        /// <returns>The created <see cref="ExtensionFeedItemServiceClient"/>.</returns>
        public static ExtensionFeedItemServiceClient Create(grpccore::Channel channel, ExtensionFeedItemServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ExtensionFeedItemServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ExtensionFeedItemServiceSettings"/>.</param>
        /// <returns>The created <see cref="ExtensionFeedItemServiceClient"/>.</returns>
        public static ExtensionFeedItemServiceClient Create(grpccore::CallInvoker callInvoker, ExtensionFeedItemServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ExtensionFeedItemService.ExtensionFeedItemServiceClient grpcClient = new ExtensionFeedItemService.ExtensionFeedItemServiceClient(callInvoker);
            return new ExtensionFeedItemServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, ExtensionFeedItemServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ExtensionFeedItemServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, ExtensionFeedItemServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ExtensionFeedItemServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ExtensionFeedItemService client.
        /// </summary>
        public virtual ExtensionFeedItemService.ExtensionFeedItemServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested extension feed item in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the extension feed item to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::ExtensionFeedItem> GetExtensionFeedItemAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetExtensionFeedItemAsync(
                new GetExtensionFeedItemRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested extension feed item in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the extension feed item to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::ExtensionFeedItem> GetExtensionFeedItemAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetExtensionFeedItemAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested extension feed item in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the extension feed item to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::ExtensionFeedItem GetExtensionFeedItem(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetExtensionFeedItem(
                new GetExtensionFeedItemRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested extension feed item in full detail.
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
        public virtual stt::Task<gagvr::ExtensionFeedItem> GetExtensionFeedItemAsync(
            GetExtensionFeedItemRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested extension feed item in full detail.
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
        public virtual stt::Task<gagvr::ExtensionFeedItem> GetExtensionFeedItemAsync(
            GetExtensionFeedItemRequest request,
            st::CancellationToken cancellationToken) => GetExtensionFeedItemAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested extension feed item in full detail.
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
        public virtual gagvr::ExtensionFeedItem GetExtensionFeedItem(
            GetExtensionFeedItemRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose extension feed items are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual extension feed items.
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
        public virtual stt::Task<MutateExtensionFeedItemsResponse> MutateExtensionFeedItemsAsync(
            string customerId,
            scg::IEnumerable<ExtensionFeedItemOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateExtensionFeedItemsAsync(
                new MutateExtensionFeedItemsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose extension feed items are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual extension feed items.
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
        public virtual stt::Task<MutateExtensionFeedItemsResponse> MutateExtensionFeedItemsAsync(
            string customerId,
            scg::IEnumerable<ExtensionFeedItemOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            st::CancellationToken cancellationToken) => MutateExtensionFeedItemsAsync(
                customerId,
                operations,
                partialFailure,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose extension feed items are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual extension feed items.
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
        public virtual MutateExtensionFeedItemsResponse MutateExtensionFeedItems(
            string customerId,
            scg::IEnumerable<ExtensionFeedItemOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateExtensionFeedItems(
                new MutateExtensionFeedItemsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose extension feed items are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual extension feed items.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateExtensionFeedItemsResponse> MutateExtensionFeedItemsAsync(
            string customerId,
            scg::IEnumerable<ExtensionFeedItemOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateExtensionFeedItemsAsync(
                new MutateExtensionFeedItemsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose extension feed items are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual extension feed items.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateExtensionFeedItemsResponse> MutateExtensionFeedItemsAsync(
            string customerId,
            scg::IEnumerable<ExtensionFeedItemOperation> operations,
            st::CancellationToken cancellationToken) => MutateExtensionFeedItemsAsync(
                customerId,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose extension feed items are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual extension feed items.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateExtensionFeedItemsResponse MutateExtensionFeedItems(
            string customerId,
            scg::IEnumerable<ExtensionFeedItemOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateExtensionFeedItems(
                new MutateExtensionFeedItemsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
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
        public virtual stt::Task<MutateExtensionFeedItemsResponse> MutateExtensionFeedItemsAsync(
            MutateExtensionFeedItemsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
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
        public virtual stt::Task<MutateExtensionFeedItemsResponse> MutateExtensionFeedItemsAsync(
            MutateExtensionFeedItemsRequest request,
            st::CancellationToken cancellationToken) => MutateExtensionFeedItemsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
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
        public virtual MutateExtensionFeedItemsResponse MutateExtensionFeedItems(
            MutateExtensionFeedItemsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// ExtensionFeedItemService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ExtensionFeedItemServiceClientImpl : ExtensionFeedItemServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetExtensionFeedItemRequest, gagvr::ExtensionFeedItem> _callGetExtensionFeedItem;
        private readonly gaxgrpc::ApiCall<MutateExtensionFeedItemsRequest, MutateExtensionFeedItemsResponse> _callMutateExtensionFeedItems;

        /// <summary>
        /// Constructs a client wrapper for the ExtensionFeedItemService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ExtensionFeedItemServiceSettings"/> used within this client </param>
        public ExtensionFeedItemServiceClientImpl(ExtensionFeedItemService.ExtensionFeedItemServiceClient grpcClient, ExtensionFeedItemServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ExtensionFeedItemServiceSettings effectiveSettings = settings ?? ExtensionFeedItemServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetExtensionFeedItem = clientHelper.BuildApiCall<GetExtensionFeedItemRequest, gagvr::ExtensionFeedItem>(
                GrpcClient.GetExtensionFeedItemAsync, GrpcClient.GetExtensionFeedItem, effectiveSettings.GetExtensionFeedItemSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource_name={request.ResourceName}"));
            _callMutateExtensionFeedItems = clientHelper.BuildApiCall<MutateExtensionFeedItemsRequest, MutateExtensionFeedItemsResponse>(
                GrpcClient.MutateExtensionFeedItemsAsync, GrpcClient.MutateExtensionFeedItems, effectiveSettings.MutateExtensionFeedItemsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"customer_id={request.CustomerId}"));
            Modify_ApiCall(ref _callGetExtensionFeedItem);
            Modify_GetExtensionFeedItemApiCall(ref _callGetExtensionFeedItem);
            Modify_ApiCall(ref _callMutateExtensionFeedItems);
            Modify_MutateExtensionFeedItemsApiCall(ref _callMutateExtensionFeedItems);
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
        partial void Modify_GetExtensionFeedItemApiCall(ref gaxgrpc::ApiCall<GetExtensionFeedItemRequest, gagvr::ExtensionFeedItem> call);
        partial void Modify_MutateExtensionFeedItemsApiCall(ref gaxgrpc::ApiCall<MutateExtensionFeedItemsRequest, MutateExtensionFeedItemsResponse> call);
        partial void OnConstruction(ExtensionFeedItemService.ExtensionFeedItemServiceClient grpcClient, ExtensionFeedItemServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ExtensionFeedItemService client.
        /// </summary>
        public override ExtensionFeedItemService.ExtensionFeedItemServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetExtensionFeedItemRequest(ref GetExtensionFeedItemRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateExtensionFeedItemsRequest(ref MutateExtensionFeedItemsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested extension feed item in full detail.
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
        public override stt::Task<gagvr::ExtensionFeedItem> GetExtensionFeedItemAsync(
            GetExtensionFeedItemRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExtensionFeedItemRequest(ref request, ref callSettings);
            return _callGetExtensionFeedItem.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested extension feed item in full detail.
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
        public override gagvr::ExtensionFeedItem GetExtensionFeedItem(
            GetExtensionFeedItemRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExtensionFeedItemRequest(ref request, ref callSettings);
            return _callGetExtensionFeedItem.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
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
        public override stt::Task<MutateExtensionFeedItemsResponse> MutateExtensionFeedItemsAsync(
            MutateExtensionFeedItemsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateExtensionFeedItemsRequest(ref request, ref callSettings);
            return _callMutateExtensionFeedItems.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes extension feed items. Operation
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
        public override MutateExtensionFeedItemsResponse MutateExtensionFeedItems(
            MutateExtensionFeedItemsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateExtensionFeedItemsRequest(ref request, ref callSettings);
            return _callMutateExtensionFeedItems.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

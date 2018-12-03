// Copyright 2018 Google LLC
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

// TODO( b/119694056): Removed Comment

using gagvr = Google.Ads.GoogleAds.V0.Resources;
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

namespace Google.Ads.GoogleAds.V0.Services
{
    /// <summary>
    /// Settings for a <see cref="SharedSetServiceClient"/>.
    /// </summary>
    public sealed partial class SharedSetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="SharedSetServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="SharedSetServiceSettings"/>.
        /// </returns>
        public static SharedSetServiceSettings GetDefault() => new SharedSetServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SharedSetServiceSettings"/> object with default settings.
        /// </summary>
        public SharedSetServiceSettings() { }

        private SharedSetServiceSettings(SharedSetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSharedSetSettings = existing.GetSharedSetSettings;
            MutateSharedSetsSettings = existing.MutateSharedSetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SharedSetServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="SharedSetServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="SharedSetServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="SharedSetServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="SharedSetServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="SharedSetServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="SharedSetServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="SharedSetServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="SharedSetServiceClient"/> RPC methods is defined as:
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
        /// <c>SharedSetServiceClient.GetSharedSet</c> and <c>SharedSetServiceClient.GetSharedSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SharedSetServiceClient.GetSharedSet</c> and
        /// <c>SharedSetServiceClient.GetSharedSetAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetSharedSetSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SharedSetServiceClient.MutateSharedSets</c> and <c>SharedSetServiceClient.MutateSharedSetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>SharedSetServiceClient.MutateSharedSets</c> and
        /// <c>SharedSetServiceClient.MutateSharedSetsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings MutateSharedSetsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="SharedSetServiceSettings"/> object.</returns>
        public SharedSetServiceSettings Clone() => new SharedSetServiceSettings(this);
    }

    /// <summary>
    /// SharedSetService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class SharedSetServiceClient
    {
        /// <summary>
        /// The default endpoint for the SharedSetService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default SharedSetService scopes.
        /// </summary>
        /// <remarks>
        /// The default SharedSetService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="SharedSetServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V0.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// SharedSetServiceClient client = await SharedSetServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V0.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     SharedSetServiceClient.DefaultEndpoint.Host, SharedSetServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// SharedSetServiceClient client = SharedSetServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SharedSetServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="SharedSetServiceClient"/>.</returns>
        public static async stt::Task<SharedSetServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, SharedSetServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="SharedSetServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V0.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// SharedSetServiceClient client = SharedSetServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V0.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     SharedSetServiceClient.DefaultEndpoint.Host, SharedSetServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// SharedSetServiceClient client = SharedSetServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="SharedSetServiceSettings"/>.</param>
        /// <returns>The created <see cref="SharedSetServiceClient"/>.</returns>
        public static SharedSetServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, SharedSetServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="SharedSetServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SharedSetServiceSettings"/>.</param>
        /// <returns>The created <see cref="SharedSetServiceClient"/>.</returns>
        public static SharedSetServiceClient Create(grpccore::Channel channel, SharedSetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="SharedSetServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="SharedSetServiceSettings"/>.</param>
        /// <returns>The created <see cref="SharedSetServiceClient"/>.</returns>
        public static SharedSetServiceClient Create(grpccore::CallInvoker callInvoker, SharedSetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SharedSetService.SharedSetServiceClient grpcClient = new SharedSetService.SharedSetServiceClient(callInvoker);
            return new SharedSetServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, SharedSetServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, SharedSetServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, SharedSetServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, SharedSetServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC SharedSetService client.
        /// </summary>
        public virtual SharedSetService.SharedSetServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested shared set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the shared set to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::SharedSet> GetSharedSetAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetSharedSetAsync(
                new GetSharedSetRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested shared set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the shared set to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::SharedSet> GetSharedSetAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetSharedSetAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested shared set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the shared set to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::SharedSet GetSharedSet(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetSharedSet(
                new GetSharedSetRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested shared set in full detail.
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
        public virtual stt::Task<gagvr::SharedSet> GetSharedSetAsync(
            GetSharedSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested shared set in full detail.
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
        public virtual stt::Task<gagvr::SharedSet> GetSharedSetAsync(
            GetSharedSetRequest request,
            st::CancellationToken cancellationToken) => GetSharedSetAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested shared set in full detail.
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
        public virtual gagvr::SharedSet GetSharedSet(
            GetSharedSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes shared sets. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose shared sets are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual shared sets.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateSharedSetsResponse> MutateSharedSetsAsync(
            string customerId,
            scg::IEnumerable<SharedSetOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateSharedSetsAsync(
                new MutateSharedSetsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes shared sets. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose shared sets are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual shared sets.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateSharedSetsResponse> MutateSharedSetsAsync(
            string customerId,
            scg::IEnumerable<SharedSetOperation> operations,
            st::CancellationToken cancellationToken) => MutateSharedSetsAsync(
                customerId,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes shared sets. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose shared sets are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual shared sets.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateSharedSetsResponse MutateSharedSets(
            string customerId,
            scg::IEnumerable<SharedSetOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateSharedSets(
                new MutateSharedSetsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes shared sets. Operation statuses are returned.
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
        public virtual stt::Task<MutateSharedSetsResponse> MutateSharedSetsAsync(
            MutateSharedSetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes shared sets. Operation statuses are returned.
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
        public virtual stt::Task<MutateSharedSetsResponse> MutateSharedSetsAsync(
            MutateSharedSetsRequest request,
            st::CancellationToken cancellationToken) => MutateSharedSetsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes shared sets. Operation statuses are returned.
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
        public virtual MutateSharedSetsResponse MutateSharedSets(
            MutateSharedSetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// SharedSetService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class SharedSetServiceClientImpl : SharedSetServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetSharedSetRequest, gagvr::SharedSet> _callGetSharedSet;
        private readonly gaxgrpc::ApiCall<MutateSharedSetsRequest, MutateSharedSetsResponse> _callMutateSharedSets;

        /// <summary>
        /// Constructs a client wrapper for the SharedSetService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SharedSetServiceSettings"/> used within this client </param>
        public SharedSetServiceClientImpl(SharedSetService.SharedSetServiceClient grpcClient, SharedSetServiceSettings settings)
        {
            GrpcClient = grpcClient;
            SharedSetServiceSettings effectiveSettings = settings ?? SharedSetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetSharedSet = clientHelper.BuildApiCall<GetSharedSetRequest, gagvr::SharedSet>(
                GrpcClient.GetSharedSetAsync, GrpcClient.GetSharedSet, effectiveSettings.GetSharedSetSettings);
            _callMutateSharedSets = clientHelper.BuildApiCall<MutateSharedSetsRequest, MutateSharedSetsResponse>(
                GrpcClient.MutateSharedSetsAsync, GrpcClient.MutateSharedSets, effectiveSettings.MutateSharedSetsSettings);
            Modify_ApiCall(ref _callGetSharedSet);
            Modify_GetSharedSetApiCall(ref _callGetSharedSet);
            Modify_ApiCall(ref _callMutateSharedSets);
            Modify_MutateSharedSetsApiCall(ref _callMutateSharedSets);
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
        partial void Modify_GetSharedSetApiCall(ref gaxgrpc::ApiCall<GetSharedSetRequest, gagvr::SharedSet> call);
        partial void Modify_MutateSharedSetsApiCall(ref gaxgrpc::ApiCall<MutateSharedSetsRequest, MutateSharedSetsResponse> call);
        partial void OnConstruction(SharedSetService.SharedSetServiceClient grpcClient, SharedSetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC SharedSetService client.
        /// </summary>
        public override SharedSetService.SharedSetServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetSharedSetRequest(ref GetSharedSetRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateSharedSetsRequest(ref MutateSharedSetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested shared set in full detail.
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
        public override stt::Task<gagvr::SharedSet> GetSharedSetAsync(
            GetSharedSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSharedSetRequest(ref request, ref callSettings);
            return _callGetSharedSet.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested shared set in full detail.
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
        public override gagvr::SharedSet GetSharedSet(
            GetSharedSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSharedSetRequest(ref request, ref callSettings);
            return _callGetSharedSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes shared sets. Operation statuses are returned.
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
        public override stt::Task<MutateSharedSetsResponse> MutateSharedSetsAsync(
            MutateSharedSetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateSharedSetsRequest(ref request, ref callSettings);
            return _callMutateSharedSets.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes shared sets. Operation statuses are returned.
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
        public override MutateSharedSetsResponse MutateSharedSets(
            MutateSharedSetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateSharedSetsRequest(ref request, ref callSettings);
            return _callMutateSharedSets.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

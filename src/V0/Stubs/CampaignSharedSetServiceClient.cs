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
    /// Settings for a <see cref="CampaignSharedSetServiceClient"/>.
    /// </summary>
    public sealed partial class CampaignSharedSetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="CampaignSharedSetServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="CampaignSharedSetServiceSettings"/>.
        /// </returns>
        public static CampaignSharedSetServiceSettings GetDefault() => new CampaignSharedSetServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignSharedSetServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignSharedSetServiceSettings() { }

        private CampaignSharedSetServiceSettings(CampaignSharedSetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCampaignSharedSetSettings = existing.GetCampaignSharedSetSettings;
            MutateCampaignSharedSetsSettings = existing.MutateCampaignSharedSetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignSharedSetServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="CampaignSharedSetServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="CampaignSharedSetServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="CampaignSharedSetServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="CampaignSharedSetServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="CampaignSharedSetServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="CampaignSharedSetServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="CampaignSharedSetServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="CampaignSharedSetServiceClient"/> RPC methods is defined as:
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
        /// <c>CampaignSharedSetServiceClient.GetCampaignSharedSet</c> and <c>CampaignSharedSetServiceClient.GetCampaignSharedSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CampaignSharedSetServiceClient.GetCampaignSharedSet</c> and
        /// <c>CampaignSharedSetServiceClient.GetCampaignSharedSetAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetCampaignSharedSetSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignSharedSetServiceClient.MutateCampaignSharedSets</c> and <c>CampaignSharedSetServiceClient.MutateCampaignSharedSetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CampaignSharedSetServiceClient.MutateCampaignSharedSets</c> and
        /// <c>CampaignSharedSetServiceClient.MutateCampaignSharedSetsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings MutateCampaignSharedSetsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="CampaignSharedSetServiceSettings"/> object.</returns>
        public CampaignSharedSetServiceSettings Clone() => new CampaignSharedSetServiceSettings(this);
    }

    /// <summary>
    /// CampaignSharedSetService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class CampaignSharedSetServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignSharedSetService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default CampaignSharedSetService scopes.
        /// </summary>
        /// <remarks>
        /// The default CampaignSharedSetService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignSharedSetServiceClient"/>, applying defaults for all unspecified settings,
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
        /// CampaignSharedSetServiceClient client = await CampaignSharedSetServiceClient.CreateAsync();
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
        ///     CampaignSharedSetServiceClient.DefaultEndpoint.Host, CampaignSharedSetServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CampaignSharedSetServiceClient client = CampaignSharedSetServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CampaignSharedSetServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="CampaignSharedSetServiceClient"/>.</returns>
        public static async stt::Task<CampaignSharedSetServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, CampaignSharedSetServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="CampaignSharedSetServiceClient"/>, applying defaults for all unspecified settings,
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
        /// CampaignSharedSetServiceClient client = CampaignSharedSetServiceClient.Create();
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
        ///     CampaignSharedSetServiceClient.DefaultEndpoint.Host, CampaignSharedSetServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CampaignSharedSetServiceClient client = CampaignSharedSetServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CampaignSharedSetServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignSharedSetServiceClient"/>.</returns>
        public static CampaignSharedSetServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, CampaignSharedSetServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="CampaignSharedSetServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CampaignSharedSetServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignSharedSetServiceClient"/>.</returns>
        public static CampaignSharedSetServiceClient Create(grpccore::Channel channel, CampaignSharedSetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="CampaignSharedSetServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CampaignSharedSetServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignSharedSetServiceClient"/>.</returns>
        public static CampaignSharedSetServiceClient Create(grpccore::CallInvoker callInvoker, CampaignSharedSetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignSharedSetService.CampaignSharedSetServiceClient grpcClient = new CampaignSharedSetService.CampaignSharedSetServiceClient(callInvoker);
            return new CampaignSharedSetServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, CampaignSharedSetServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CampaignSharedSetServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, CampaignSharedSetServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CampaignSharedSetServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC CampaignSharedSetService client.
        /// </summary>
        public virtual CampaignSharedSetService.CampaignSharedSetServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the campaign shared set to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CampaignSharedSet> GetCampaignSharedSetAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCampaignSharedSetAsync(
                new GetCampaignSharedSetRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the campaign shared set to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CampaignSharedSet> GetCampaignSharedSetAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetCampaignSharedSetAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the campaign shared set to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::CampaignSharedSet GetCampaignSharedSet(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCampaignSharedSet(
                new GetCampaignSharedSetRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
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
        public virtual stt::Task<gagvr::CampaignSharedSet> GetCampaignSharedSetAsync(
            GetCampaignSharedSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
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
        public virtual stt::Task<gagvr::CampaignSharedSet> GetCampaignSharedSetAsync(
            GetCampaignSharedSetRequest request,
            st::CancellationToken cancellationToken) => GetCampaignSharedSetAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
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
        public virtual gagvr::CampaignSharedSet GetCampaignSharedSet(
            GetCampaignSharedSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates or removes campaign shared sets. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign shared sets are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual campaign shared sets.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCampaignSharedSetsResponse> MutateCampaignSharedSetsAsync(
            string customerId,
            scg::IEnumerable<CampaignSharedSetOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignSharedSetsAsync(
                new MutateCampaignSharedSetsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates or removes campaign shared sets. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign shared sets are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual campaign shared sets.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCampaignSharedSetsResponse> MutateCampaignSharedSetsAsync(
            string customerId,
            scg::IEnumerable<CampaignSharedSetOperation> operations,
            st::CancellationToken cancellationToken) => MutateCampaignSharedSetsAsync(
                customerId,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes campaign shared sets. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign shared sets are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual campaign shared sets.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateCampaignSharedSetsResponse MutateCampaignSharedSets(
            string customerId,
            scg::IEnumerable<CampaignSharedSetOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignSharedSets(
                new MutateCampaignSharedSetsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates or removes campaign shared sets. Operation statuses are returned.
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
        public virtual stt::Task<MutateCampaignSharedSetsResponse> MutateCampaignSharedSetsAsync(
            MutateCampaignSharedSetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates or removes campaign shared sets. Operation statuses are returned.
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
        public virtual stt::Task<MutateCampaignSharedSetsResponse> MutateCampaignSharedSetsAsync(
            MutateCampaignSharedSetsRequest request,
            st::CancellationToken cancellationToken) => MutateCampaignSharedSetsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes campaign shared sets. Operation statuses are returned.
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
        public virtual MutateCampaignSharedSetsResponse MutateCampaignSharedSets(
            MutateCampaignSharedSetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// CampaignSharedSetService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class CampaignSharedSetServiceClientImpl : CampaignSharedSetServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCampaignSharedSetRequest, gagvr::CampaignSharedSet> _callGetCampaignSharedSet;
        private readonly gaxgrpc::ApiCall<MutateCampaignSharedSetsRequest, MutateCampaignSharedSetsResponse> _callMutateCampaignSharedSets;

        /// <summary>
        /// Constructs a client wrapper for the CampaignSharedSetService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CampaignSharedSetServiceSettings"/> used within this client </param>
        public CampaignSharedSetServiceClientImpl(CampaignSharedSetService.CampaignSharedSetServiceClient grpcClient, CampaignSharedSetServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CampaignSharedSetServiceSettings effectiveSettings = settings ?? CampaignSharedSetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCampaignSharedSet = clientHelper.BuildApiCall<GetCampaignSharedSetRequest, gagvr::CampaignSharedSet>(
                GrpcClient.GetCampaignSharedSetAsync, GrpcClient.GetCampaignSharedSet, effectiveSettings.GetCampaignSharedSetSettings);
            _callMutateCampaignSharedSets = clientHelper.BuildApiCall<MutateCampaignSharedSetsRequest, MutateCampaignSharedSetsResponse>(
                GrpcClient.MutateCampaignSharedSetsAsync, GrpcClient.MutateCampaignSharedSets, effectiveSettings.MutateCampaignSharedSetsSettings);
            Modify_ApiCall(ref _callGetCampaignSharedSet);
            Modify_GetCampaignSharedSetApiCall(ref _callGetCampaignSharedSet);
            Modify_ApiCall(ref _callMutateCampaignSharedSets);
            Modify_MutateCampaignSharedSetsApiCall(ref _callMutateCampaignSharedSets);
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
        partial void Modify_GetCampaignSharedSetApiCall(ref gaxgrpc::ApiCall<GetCampaignSharedSetRequest, gagvr::CampaignSharedSet> call);
        partial void Modify_MutateCampaignSharedSetsApiCall(ref gaxgrpc::ApiCall<MutateCampaignSharedSetsRequest, MutateCampaignSharedSetsResponse> call);
        partial void OnConstruction(CampaignSharedSetService.CampaignSharedSetServiceClient grpcClient, CampaignSharedSetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC CampaignSharedSetService client.
        /// </summary>
        public override CampaignSharedSetService.CampaignSharedSetServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetCampaignSharedSetRequest(ref GetCampaignSharedSetRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateCampaignSharedSetsRequest(ref MutateCampaignSharedSetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
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
        public override stt::Task<gagvr::CampaignSharedSet> GetCampaignSharedSetAsync(
            GetCampaignSharedSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignSharedSetRequest(ref request, ref callSettings);
            return _callGetCampaignSharedSet.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
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
        public override gagvr::CampaignSharedSet GetCampaignSharedSet(
            GetCampaignSharedSetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignSharedSetRequest(ref request, ref callSettings);
            return _callGetCampaignSharedSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or removes campaign shared sets. Operation statuses are returned.
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
        public override stt::Task<MutateCampaignSharedSetsResponse> MutateCampaignSharedSetsAsync(
            MutateCampaignSharedSetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignSharedSetsRequest(ref request, ref callSettings);
            return _callMutateCampaignSharedSets.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or removes campaign shared sets. Operation statuses are returned.
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
        public override MutateCampaignSharedSetsResponse MutateCampaignSharedSets(
            MutateCampaignSharedSetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignSharedSetsRequest(ref request, ref callSettings);
            return _callMutateCampaignSharedSets.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

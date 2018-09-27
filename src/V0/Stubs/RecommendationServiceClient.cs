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

// Generated code. DO NOT EDIT!

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
    /// Settings for a <see cref="RecommendationServiceClient"/>.
    /// </summary>
    public sealed partial class RecommendationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="RecommendationServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="RecommendationServiceSettings"/>.
        /// </returns>
        public static RecommendationServiceSettings GetDefault() => new RecommendationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="RecommendationServiceSettings"/> object with default settings.
        /// </summary>
        public RecommendationServiceSettings() { }

        private RecommendationServiceSettings(RecommendationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetRecommendationSettings = existing.GetRecommendationSettings;
            ApplyRecommendationSettings = existing.ApplyRecommendationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RecommendationServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="RecommendationServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="RecommendationServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="RecommendationServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="RecommendationServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="RecommendationServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="RecommendationServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="RecommendationServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="RecommendationServiceClient"/> RPC methods is defined as:
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
        /// <c>RecommendationServiceClient.GetRecommendation</c> and <c>RecommendationServiceClient.GetRecommendationAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>RecommendationServiceClient.GetRecommendation</c> and
        /// <c>RecommendationServiceClient.GetRecommendationAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetRecommendationSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommendationServiceClient.ApplyRecommendation</c> and <c>RecommendationServiceClient.ApplyRecommendationAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>RecommendationServiceClient.ApplyRecommendation</c> and
        /// <c>RecommendationServiceClient.ApplyRecommendationAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ApplyRecommendationSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="RecommendationServiceSettings"/> object.</returns>
        public RecommendationServiceSettings Clone() => new RecommendationServiceSettings(this);
    }

    /// <summary>
    /// RecommendationService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class RecommendationServiceClient
    {
        /// <summary>
        /// The default endpoint for the RecommendationService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default RecommendationService scopes.
        /// </summary>
        /// <remarks>
        /// The default RecommendationService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="RecommendationServiceClient"/>, applying defaults for all unspecified settings,
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
        /// RecommendationServiceClient client = await RecommendationServiceClient.CreateAsync();
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
        ///     RecommendationServiceClient.DefaultEndpoint.Host, RecommendationServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// RecommendationServiceClient client = RecommendationServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="RecommendationServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="RecommendationServiceClient"/>.</returns>
        public static async stt::Task<RecommendationServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, RecommendationServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="RecommendationServiceClient"/>, applying defaults for all unspecified settings,
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
        /// RecommendationServiceClient client = RecommendationServiceClient.Create();
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
        ///     RecommendationServiceClient.DefaultEndpoint.Host, RecommendationServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// RecommendationServiceClient client = RecommendationServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="RecommendationServiceSettings"/>.</param>
        /// <returns>The created <see cref="RecommendationServiceClient"/>.</returns>
        public static RecommendationServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, RecommendationServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="RecommendationServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="RecommendationServiceSettings"/>.</param>
        /// <returns>The created <see cref="RecommendationServiceClient"/>.</returns>
        public static RecommendationServiceClient Create(grpccore::Channel channel, RecommendationServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="RecommendationServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="RecommendationServiceSettings"/>.</param>
        /// <returns>The created <see cref="RecommendationServiceClient"/>.</returns>
        public static RecommendationServiceClient Create(grpccore::CallInvoker callInvoker, RecommendationServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RecommendationService.RecommendationServiceClient grpcClient = new RecommendationService.RecommendationServiceClient(callInvoker);
            return new RecommendationServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, RecommendationServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, RecommendationServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, RecommendationServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, RecommendationServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC RecommendationService client.
        /// </summary>
        public virtual RecommendationService.RecommendationServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested recommendation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the recommendation to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::Recommendation> GetRecommendationAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetRecommendationAsync(
                new GetRecommendationRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested recommendation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the recommendation to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::Recommendation> GetRecommendationAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetRecommendationAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested recommendation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the recommendation to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::Recommendation GetRecommendation(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetRecommendation(
                new GetRecommendationRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested recommendation in full detail.
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
        public virtual stt::Task<gagvr::Recommendation> GetRecommendationAsync(
            GetRecommendationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested recommendation in full detail.
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
        public virtual stt::Task<gagvr::Recommendation> GetRecommendationAsync(
            GetRecommendationRequest request,
            st::CancellationToken cancellationToken) => GetRecommendationAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested recommendation in full detail.
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
        public virtual gagvr::Recommendation GetRecommendation(
            GetRecommendationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Applies given recommendations with corresponding apply parameters.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer with the recommendation.
        /// </param>
        /// <param name="operations">
        /// The list of operations to apply recommendations.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ApplyRecommendationResponse> ApplyRecommendationAsync(
            string customerId,
            scg::IEnumerable<ApplyRecommendationOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => ApplyRecommendationAsync(
                new ApplyRecommendationRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Applies given recommendations with corresponding apply parameters.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer with the recommendation.
        /// </param>
        /// <param name="operations">
        /// The list of operations to apply recommendations.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ApplyRecommendationResponse> ApplyRecommendationAsync(
            string customerId,
            scg::IEnumerable<ApplyRecommendationOperation> operations,
            st::CancellationToken cancellationToken) => ApplyRecommendationAsync(
                customerId,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Applies given recommendations with corresponding apply parameters.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer with the recommendation.
        /// </param>
        /// <param name="operations">
        /// The list of operations to apply recommendations.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ApplyRecommendationResponse ApplyRecommendation(
            string customerId,
            scg::IEnumerable<ApplyRecommendationOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => ApplyRecommendation(
                new ApplyRecommendationRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Applies given recommendations with corresponding apply parameters.
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
        public virtual stt::Task<ApplyRecommendationResponse> ApplyRecommendationAsync(
            ApplyRecommendationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Applies given recommendations with corresponding apply parameters.
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
        public virtual stt::Task<ApplyRecommendationResponse> ApplyRecommendationAsync(
            ApplyRecommendationRequest request,
            st::CancellationToken cancellationToken) => ApplyRecommendationAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Applies given recommendations with corresponding apply parameters.
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
        public virtual ApplyRecommendationResponse ApplyRecommendation(
            ApplyRecommendationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// RecommendationService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class RecommendationServiceClientImpl : RecommendationServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetRecommendationRequest, gagvr::Recommendation> _callGetRecommendation;
        private readonly gaxgrpc::ApiCall<ApplyRecommendationRequest, ApplyRecommendationResponse> _callApplyRecommendation;

        /// <summary>
        /// Constructs a client wrapper for the RecommendationService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RecommendationServiceSettings"/> used within this client </param>
        public RecommendationServiceClientImpl(RecommendationService.RecommendationServiceClient grpcClient, RecommendationServiceSettings settings)
        {
            GrpcClient = grpcClient;
            RecommendationServiceSettings effectiveSettings = settings ?? RecommendationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetRecommendation = clientHelper.BuildApiCall<GetRecommendationRequest, gagvr::Recommendation>(
                GrpcClient.GetRecommendationAsync, GrpcClient.GetRecommendation, effectiveSettings.GetRecommendationSettings);
            _callApplyRecommendation = clientHelper.BuildApiCall<ApplyRecommendationRequest, ApplyRecommendationResponse>(
                GrpcClient.ApplyRecommendationAsync, GrpcClient.ApplyRecommendation, effectiveSettings.ApplyRecommendationSettings);
            Modify_ApiCall(ref _callGetRecommendation);
            Modify_GetRecommendationApiCall(ref _callGetRecommendation);
            Modify_ApiCall(ref _callApplyRecommendation);
            Modify_ApplyRecommendationApiCall(ref _callApplyRecommendation);
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
        partial void Modify_GetRecommendationApiCall(ref gaxgrpc::ApiCall<GetRecommendationRequest, gagvr::Recommendation> call);
        partial void Modify_ApplyRecommendationApiCall(ref gaxgrpc::ApiCall<ApplyRecommendationRequest, ApplyRecommendationResponse> call);
        partial void OnConstruction(RecommendationService.RecommendationServiceClient grpcClient, RecommendationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC RecommendationService client.
        /// </summary>
        public override RecommendationService.RecommendationServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetRecommendationRequest(ref GetRecommendationRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ApplyRecommendationRequest(ref ApplyRecommendationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested recommendation in full detail.
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
        public override stt::Task<gagvr::Recommendation> GetRecommendationAsync(
            GetRecommendationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRecommendationRequest(ref request, ref callSettings);
            return _callGetRecommendation.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested recommendation in full detail.
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
        public override gagvr::Recommendation GetRecommendation(
            GetRecommendationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRecommendationRequest(ref request, ref callSettings);
            return _callGetRecommendation.Sync(request, callSettings);
        }

        /// <summary>
        /// Applies given recommendations with corresponding apply parameters.
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
        public override stt::Task<ApplyRecommendationResponse> ApplyRecommendationAsync(
            ApplyRecommendationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApplyRecommendationRequest(ref request, ref callSettings);
            return _callApplyRecommendation.Async(request, callSettings);
        }

        /// <summary>
        /// Applies given recommendations with corresponding apply parameters.
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
        public override ApplyRecommendationResponse ApplyRecommendation(
            ApplyRecommendationRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApplyRecommendationRequest(ref request, ref callSettings);
            return _callApplyRecommendation.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

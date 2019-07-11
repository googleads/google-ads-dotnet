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
    /// Settings for a <see cref="FeedPlaceholderViewServiceClient"/>.
    /// </summary>
    public sealed partial class FeedPlaceholderViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="FeedPlaceholderViewServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="FeedPlaceholderViewServiceSettings"/>.
        /// </returns>
        public static FeedPlaceholderViewServiceSettings GetDefault() => new FeedPlaceholderViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="FeedPlaceholderViewServiceSettings"/> object with default settings.
        /// </summary>
        public FeedPlaceholderViewServiceSettings() { }

        private FeedPlaceholderViewServiceSettings(FeedPlaceholderViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetFeedPlaceholderViewSettings = existing.GetFeedPlaceholderViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FeedPlaceholderViewServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="FeedPlaceholderViewServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="FeedPlaceholderViewServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="FeedPlaceholderViewServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="FeedPlaceholderViewServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="FeedPlaceholderViewServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="FeedPlaceholderViewServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="FeedPlaceholderViewServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="FeedPlaceholderViewServiceClient"/> RPC methods is defined as:
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
        /// <c>FeedPlaceholderViewServiceClient.GetFeedPlaceholderView</c> and <c>FeedPlaceholderViewServiceClient.GetFeedPlaceholderViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>FeedPlaceholderViewServiceClient.GetFeedPlaceholderView</c> and
        /// <c>FeedPlaceholderViewServiceClient.GetFeedPlaceholderViewAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetFeedPlaceholderViewSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="FeedPlaceholderViewServiceSettings"/> object.</returns>
        public FeedPlaceholderViewServiceSettings Clone() => new FeedPlaceholderViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FeedPlaceholderViewServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class FeedPlaceholderViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<FeedPlaceholderViewServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public FeedPlaceholderViewServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override FeedPlaceholderViewServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FeedPlaceholderViewServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<FeedPlaceholderViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FeedPlaceholderViewServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => FeedPlaceholderViewServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => FeedPlaceholderViewServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => FeedPlaceholderViewServiceClient.ChannelPool;
    }

    /// <summary>
    /// FeedPlaceholderViewService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class FeedPlaceholderViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the FeedPlaceholderViewService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default FeedPlaceholderViewService scopes.
        /// </summary>
        /// <remarks>
        /// The default FeedPlaceholderViewService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="FeedPlaceholderViewServiceClient"/>, applying defaults for all unspecified settings,
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
        /// FeedPlaceholderViewServiceClient client = await FeedPlaceholderViewServiceClient.CreateAsync();
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
        ///     FeedPlaceholderViewServiceClient.DefaultEndpoint.Host, FeedPlaceholderViewServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// FeedPlaceholderViewServiceClient client = FeedPlaceholderViewServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="FeedPlaceholderViewServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="FeedPlaceholderViewServiceClient"/>.</returns>
        public static async stt::Task<FeedPlaceholderViewServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, FeedPlaceholderViewServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="FeedPlaceholderViewServiceClient"/>, applying defaults for all unspecified settings,
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
        /// FeedPlaceholderViewServiceClient client = FeedPlaceholderViewServiceClient.Create();
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
        ///     FeedPlaceholderViewServiceClient.DefaultEndpoint.Host, FeedPlaceholderViewServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// FeedPlaceholderViewServiceClient client = FeedPlaceholderViewServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="FeedPlaceholderViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="FeedPlaceholderViewServiceClient"/>.</returns>
        public static FeedPlaceholderViewServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, FeedPlaceholderViewServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="FeedPlaceholderViewServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="FeedPlaceholderViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="FeedPlaceholderViewServiceClient"/>.</returns>
        public static FeedPlaceholderViewServiceClient Create(grpccore::Channel channel, FeedPlaceholderViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="FeedPlaceholderViewServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="FeedPlaceholderViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="FeedPlaceholderViewServiceClient"/>.</returns>
        public static FeedPlaceholderViewServiceClient Create(grpccore::CallInvoker callInvoker, FeedPlaceholderViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FeedPlaceholderViewService.FeedPlaceholderViewServiceClient grpcClient = new FeedPlaceholderViewService.FeedPlaceholderViewServiceClient(callInvoker);
            return new FeedPlaceholderViewServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, FeedPlaceholderViewServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, FeedPlaceholderViewServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, FeedPlaceholderViewServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, FeedPlaceholderViewServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC FeedPlaceholderViewService client.
        /// </summary>
        public virtual FeedPlaceholderViewService.FeedPlaceholderViewServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the feed placeholder view to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::FeedPlaceholderView> GetFeedPlaceholderViewAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetFeedPlaceholderViewAsync(
                new GetFeedPlaceholderViewRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the feed placeholder view to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::FeedPlaceholderView> GetFeedPlaceholderViewAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetFeedPlaceholderViewAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the feed placeholder view to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::FeedPlaceholderView GetFeedPlaceholderView(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetFeedPlaceholderView(
                new GetFeedPlaceholderViewRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
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
        public virtual stt::Task<gagvr::FeedPlaceholderView> GetFeedPlaceholderViewAsync(
            GetFeedPlaceholderViewRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
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
        public virtual stt::Task<gagvr::FeedPlaceholderView> GetFeedPlaceholderViewAsync(
            GetFeedPlaceholderViewRequest request,
            st::CancellationToken cancellationToken) => GetFeedPlaceholderViewAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
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
        public virtual gagvr::FeedPlaceholderView GetFeedPlaceholderView(
            GetFeedPlaceholderViewRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// FeedPlaceholderViewService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class FeedPlaceholderViewServiceClientImpl : FeedPlaceholderViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetFeedPlaceholderViewRequest, gagvr::FeedPlaceholderView> _callGetFeedPlaceholderView;

        /// <summary>
        /// Constructs a client wrapper for the FeedPlaceholderViewService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FeedPlaceholderViewServiceSettings"/> used within this client </param>
        public FeedPlaceholderViewServiceClientImpl(FeedPlaceholderViewService.FeedPlaceholderViewServiceClient grpcClient, FeedPlaceholderViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            FeedPlaceholderViewServiceSettings effectiveSettings = settings ?? FeedPlaceholderViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetFeedPlaceholderView = clientHelper.BuildApiCall<GetFeedPlaceholderViewRequest, gagvr::FeedPlaceholderView>(
                GrpcClient.GetFeedPlaceholderViewAsync, GrpcClient.GetFeedPlaceholderView, effectiveSettings.GetFeedPlaceholderViewSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource_name={request.ResourceName}"));
            Modify_ApiCall(ref _callGetFeedPlaceholderView);
            Modify_GetFeedPlaceholderViewApiCall(ref _callGetFeedPlaceholderView);
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
        partial void Modify_GetFeedPlaceholderViewApiCall(ref gaxgrpc::ApiCall<GetFeedPlaceholderViewRequest, gagvr::FeedPlaceholderView> call);
        partial void OnConstruction(FeedPlaceholderViewService.FeedPlaceholderViewServiceClient grpcClient, FeedPlaceholderViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC FeedPlaceholderViewService client.
        /// </summary>
        public override FeedPlaceholderViewService.FeedPlaceholderViewServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetFeedPlaceholderViewRequest(ref GetFeedPlaceholderViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
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
        public override stt::Task<gagvr::FeedPlaceholderView> GetFeedPlaceholderViewAsync(
            GetFeedPlaceholderViewRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedPlaceholderViewRequest(ref request, ref callSettings);
            return _callGetFeedPlaceholderView.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested feed placeholder view in full detail.
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
        public override gagvr::FeedPlaceholderView GetFeedPlaceholderView(
            GetFeedPlaceholderViewRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedPlaceholderViewRequest(ref request, ref callSettings);
            return _callGetFeedPlaceholderView.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

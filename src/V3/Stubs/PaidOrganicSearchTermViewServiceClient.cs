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
    /// Settings for a <see cref="PaidOrganicSearchTermViewServiceClient"/>.
    /// </summary>
    public sealed partial class PaidOrganicSearchTermViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="PaidOrganicSearchTermViewServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="PaidOrganicSearchTermViewServiceSettings"/>.
        /// </returns>
        public static PaidOrganicSearchTermViewServiceSettings GetDefault() => new PaidOrganicSearchTermViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="PaidOrganicSearchTermViewServiceSettings"/> object with default settings.
        /// </summary>
        public PaidOrganicSearchTermViewServiceSettings() { }

        private PaidOrganicSearchTermViewServiceSettings(PaidOrganicSearchTermViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetPaidOrganicSearchTermViewSettings = existing.GetPaidOrganicSearchTermViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PaidOrganicSearchTermViewServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="PaidOrganicSearchTermViewServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="PaidOrganicSearchTermViewServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="PaidOrganicSearchTermViewServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="PaidOrganicSearchTermViewServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="PaidOrganicSearchTermViewServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="PaidOrganicSearchTermViewServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="PaidOrganicSearchTermViewServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="PaidOrganicSearchTermViewServiceClient"/> RPC methods is defined as:
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
        /// <c>PaidOrganicSearchTermViewServiceClient.GetPaidOrganicSearchTermView</c> and <c>PaidOrganicSearchTermViewServiceClient.GetPaidOrganicSearchTermViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>PaidOrganicSearchTermViewServiceClient.GetPaidOrganicSearchTermView</c> and
        /// <c>PaidOrganicSearchTermViewServiceClient.GetPaidOrganicSearchTermViewAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetPaidOrganicSearchTermViewSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="PaidOrganicSearchTermViewServiceSettings"/> object.</returns>
        public PaidOrganicSearchTermViewServiceSettings Clone() => new PaidOrganicSearchTermViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PaidOrganicSearchTermViewServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class PaidOrganicSearchTermViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<PaidOrganicSearchTermViewServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public PaidOrganicSearchTermViewServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override PaidOrganicSearchTermViewServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PaidOrganicSearchTermViewServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<PaidOrganicSearchTermViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PaidOrganicSearchTermViewServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => PaidOrganicSearchTermViewServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => PaidOrganicSearchTermViewServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => PaidOrganicSearchTermViewServiceClient.ChannelPool;
    }

    /// <summary>
    /// PaidOrganicSearchTermViewService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class PaidOrganicSearchTermViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the PaidOrganicSearchTermViewService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default PaidOrganicSearchTermViewService scopes.
        /// </summary>
        /// <remarks>
        /// The default PaidOrganicSearchTermViewService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="PaidOrganicSearchTermViewServiceClient"/>, applying defaults for all unspecified settings,
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
        /// PaidOrganicSearchTermViewServiceClient client = await PaidOrganicSearchTermViewServiceClient.CreateAsync();
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
        ///     PaidOrganicSearchTermViewServiceClient.DefaultEndpoint.Host, PaidOrganicSearchTermViewServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// PaidOrganicSearchTermViewServiceClient client = PaidOrganicSearchTermViewServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="PaidOrganicSearchTermViewServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="PaidOrganicSearchTermViewServiceClient"/>.</returns>
        public static async stt::Task<PaidOrganicSearchTermViewServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, PaidOrganicSearchTermViewServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="PaidOrganicSearchTermViewServiceClient"/>, applying defaults for all unspecified settings,
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
        /// PaidOrganicSearchTermViewServiceClient client = PaidOrganicSearchTermViewServiceClient.Create();
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
        ///     PaidOrganicSearchTermViewServiceClient.DefaultEndpoint.Host, PaidOrganicSearchTermViewServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// PaidOrganicSearchTermViewServiceClient client = PaidOrganicSearchTermViewServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="PaidOrganicSearchTermViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="PaidOrganicSearchTermViewServiceClient"/>.</returns>
        public static PaidOrganicSearchTermViewServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, PaidOrganicSearchTermViewServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="PaidOrganicSearchTermViewServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="PaidOrganicSearchTermViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="PaidOrganicSearchTermViewServiceClient"/>.</returns>
        public static PaidOrganicSearchTermViewServiceClient Create(grpccore::Channel channel, PaidOrganicSearchTermViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="PaidOrganicSearchTermViewServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="PaidOrganicSearchTermViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="PaidOrganicSearchTermViewServiceClient"/>.</returns>
        public static PaidOrganicSearchTermViewServiceClient Create(grpccore::CallInvoker callInvoker, PaidOrganicSearchTermViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient grpcClient = new PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient(callInvoker);
            return new PaidOrganicSearchTermViewServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, PaidOrganicSearchTermViewServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, PaidOrganicSearchTermViewServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, PaidOrganicSearchTermViewServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, PaidOrganicSearchTermViewServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC PaidOrganicSearchTermViewService client.
        /// </summary>
        public virtual PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the paid organic search term view to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::PaidOrganicSearchTermView> GetPaidOrganicSearchTermViewAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetPaidOrganicSearchTermViewAsync(
                new GetPaidOrganicSearchTermViewRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the paid organic search term view to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::PaidOrganicSearchTermView> GetPaidOrganicSearchTermViewAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetPaidOrganicSearchTermViewAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the paid organic search term view to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::PaidOrganicSearchTermView GetPaidOrganicSearchTermView(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetPaidOrganicSearchTermView(
                new GetPaidOrganicSearchTermViewRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
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
        public virtual stt::Task<gagvr::PaidOrganicSearchTermView> GetPaidOrganicSearchTermViewAsync(
            GetPaidOrganicSearchTermViewRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
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
        public virtual stt::Task<gagvr::PaidOrganicSearchTermView> GetPaidOrganicSearchTermViewAsync(
            GetPaidOrganicSearchTermViewRequest request,
            st::CancellationToken cancellationToken) => GetPaidOrganicSearchTermViewAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
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
        public virtual gagvr::PaidOrganicSearchTermView GetPaidOrganicSearchTermView(
            GetPaidOrganicSearchTermViewRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// PaidOrganicSearchTermViewService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class PaidOrganicSearchTermViewServiceClientImpl : PaidOrganicSearchTermViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetPaidOrganicSearchTermViewRequest, gagvr::PaidOrganicSearchTermView> _callGetPaidOrganicSearchTermView;

        /// <summary>
        /// Constructs a client wrapper for the PaidOrganicSearchTermViewService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PaidOrganicSearchTermViewServiceSettings"/> used within this client </param>
        public PaidOrganicSearchTermViewServiceClientImpl(PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient grpcClient, PaidOrganicSearchTermViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            PaidOrganicSearchTermViewServiceSettings effectiveSettings = settings ?? PaidOrganicSearchTermViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetPaidOrganicSearchTermView = clientHelper.BuildApiCall<GetPaidOrganicSearchTermViewRequest, gagvr::PaidOrganicSearchTermView>(
                GrpcClient.GetPaidOrganicSearchTermViewAsync, GrpcClient.GetPaidOrganicSearchTermView, effectiveSettings.GetPaidOrganicSearchTermViewSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource_name={request.ResourceName}"));
            Modify_ApiCall(ref _callGetPaidOrganicSearchTermView);
            Modify_GetPaidOrganicSearchTermViewApiCall(ref _callGetPaidOrganicSearchTermView);
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
        partial void Modify_GetPaidOrganicSearchTermViewApiCall(ref gaxgrpc::ApiCall<GetPaidOrganicSearchTermViewRequest, gagvr::PaidOrganicSearchTermView> call);
        partial void OnConstruction(PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient grpcClient, PaidOrganicSearchTermViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC PaidOrganicSearchTermViewService client.
        /// </summary>
        public override PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetPaidOrganicSearchTermViewRequest(ref GetPaidOrganicSearchTermViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
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
        public override stt::Task<gagvr::PaidOrganicSearchTermView> GetPaidOrganicSearchTermViewAsync(
            GetPaidOrganicSearchTermViewRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPaidOrganicSearchTermViewRequest(ref request, ref callSettings);
            return _callGetPaidOrganicSearchTermView.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
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
        public override gagvr::PaidOrganicSearchTermView GetPaidOrganicSearchTermView(
            GetPaidOrganicSearchTermViewRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPaidOrganicSearchTermViewRequest(ref request, ref callSettings);
            return _callGetPaidOrganicSearchTermView.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

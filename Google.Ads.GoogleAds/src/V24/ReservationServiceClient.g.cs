// Copyright 2026 Google LLC
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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Ads.GoogleAds.V24.Services
{
    /// <summary>Settings for <see cref="ReservationServiceClient"/> instances.</summary>
    public sealed partial class ReservationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ReservationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ReservationServiceSettings"/>.</returns>
        public static ReservationServiceSettings GetDefault() => new ReservationServiceSettings();

        /// <summary>Constructs a new <see cref="ReservationServiceSettings"/> object with default settings.</summary>
        public ReservationServiceSettings()
        {
        }

        private ReservationServiceSettings(ReservationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            QuoteCampaignsSettings = existing.QuoteCampaignsSettings;
            BookCampaignsSettings = existing.BookCampaignsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ReservationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.QuoteCampaigns</c> and <c>ReservationServiceClient.QuoteCampaignsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 14400 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings QuoteCampaignsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReservationServiceClient.BookCampaigns</c> and <c>ReservationServiceClient.BookCampaignsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 14400 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BookCampaignsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ReservationServiceSettings"/> object.</returns>
        public ReservationServiceSettings Clone() => new ReservationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReservationServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class ReservationServiceClientBuilder : gaxgrpc::ClientBuilderBase<ReservationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ReservationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ReservationServiceClientBuilder() : base(ReservationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ReservationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ReservationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ReservationServiceClient Build()
        {
            ReservationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ReservationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ReservationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ReservationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReservationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ReservationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReservationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReservationServiceClient.ChannelPool;
    }

    /// <summary>ReservationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for reservation related operations.
    /// This service is not publicly available.
    /// </remarks>
    public abstract partial class ReservationServiceClient
    {
        /// <summary>
        /// The default endpoint for the ReservationService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ReservationService scopes.</summary>
        /// <remarks>
        /// The default ReservationService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ReservationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ReservationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReservationServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ReservationServiceClient"/>.</returns>
        public static stt::Task<ReservationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ReservationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ReservationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReservationServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="ReservationServiceClient"/>.</returns>
        public static ReservationServiceClient Create() => new ReservationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ReservationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ReservationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ReservationServiceClient"/>.</returns>
        internal static ReservationServiceClient Create(grpccore::CallInvoker callInvoker, ReservationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReservationService.ReservationServiceClient grpcClient = new ReservationService.ReservationServiceClient(callInvoker);
            return new ReservationServiceClientImpl(grpcClient, settings, logger);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC ReservationService client</summary>
        public virtual ReservationService.ReservationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Proposes quotes for booking campaigns.
        /// This request can have a latency of 30 seconds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuoteCampaignsResponse QuoteCampaigns(QuoteCampaignsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Proposes quotes for booking campaigns.
        /// This request can have a latency of 30 seconds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuoteCampaignsResponse> QuoteCampaignsAsync(QuoteCampaignsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Proposes quotes for booking campaigns.
        /// This request can have a latency of 30 seconds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuoteCampaignsResponse> QuoteCampaignsAsync(QuoteCampaignsRequest request, st::CancellationToken cancellationToken) =>
            QuoteCampaignsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Proposes quotes for booking campaigns.
        /// This request can have a latency of 30 seconds.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer making the request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QuoteCampaignsResponse QuoteCampaigns(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            QuoteCampaigns(new QuoteCampaignsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Proposes quotes for booking campaigns.
        /// This request can have a latency of 30 seconds.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer making the request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuoteCampaignsResponse> QuoteCampaignsAsync(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            QuoteCampaignsAsync(new QuoteCampaignsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Proposes quotes for booking campaigns.
        /// This request can have a latency of 30 seconds.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer making the request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QuoteCampaignsResponse> QuoteCampaignsAsync(string customerId, st::CancellationToken cancellationToken) =>
            QuoteCampaignsAsync(customerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Books the requested campaigns.
        /// This request can have a latency of 30 seconds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BookCampaignsResponse BookCampaigns(BookCampaignsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Books the requested campaigns.
        /// This request can have a latency of 30 seconds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BookCampaignsResponse> BookCampaignsAsync(BookCampaignsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Books the requested campaigns.
        /// This request can have a latency of 30 seconds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BookCampaignsResponse> BookCampaignsAsync(BookCampaignsRequest request, st::CancellationToken cancellationToken) =>
            BookCampaignsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Books the requested campaigns.
        /// This request can have a latency of 30 seconds.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer making the request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BookCampaignsResponse BookCampaigns(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            BookCampaigns(new BookCampaignsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Books the requested campaigns.
        /// This request can have a latency of 30 seconds.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer making the request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BookCampaignsResponse> BookCampaignsAsync(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            BookCampaignsAsync(new BookCampaignsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Books the requested campaigns.
        /// This request can have a latency of 30 seconds.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer making the request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BookCampaignsResponse> BookCampaignsAsync(string customerId, st::CancellationToken cancellationToken) =>
            BookCampaignsAsync(customerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ReservationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for reservation related operations.
    /// This service is not publicly available.
    /// </remarks>
    public sealed partial class ReservationServiceClientImpl : ReservationServiceClient
    {
        private readonly gaxgrpc::ApiCall<QuoteCampaignsRequest, QuoteCampaignsResponse> _callQuoteCampaigns;

        private readonly gaxgrpc::ApiCall<BookCampaignsRequest, BookCampaignsResponse> _callBookCampaigns;

        /// <summary>
        /// Constructs a client wrapper for the ReservationService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ReservationServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ReservationServiceClientImpl(ReservationService.ReservationServiceClient grpcClient, ReservationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ReservationServiceSettings effectiveSettings = settings ?? ReservationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callQuoteCampaigns = clientHelper.BuildApiCall<QuoteCampaignsRequest, QuoteCampaignsResponse>("QuoteCampaigns", grpcClient.QuoteCampaignsAsync, grpcClient.QuoteCampaigns, effectiveSettings.QuoteCampaignsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callQuoteCampaigns);
            Modify_QuoteCampaignsApiCall(ref _callQuoteCampaigns);
            _callBookCampaigns = clientHelper.BuildApiCall<BookCampaignsRequest, BookCampaignsResponse>("BookCampaigns", grpcClient.BookCampaignsAsync, grpcClient.BookCampaigns, effectiveSettings.BookCampaignsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callBookCampaigns);
            Modify_BookCampaignsApiCall(ref _callBookCampaigns);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_QuoteCampaignsApiCall(ref gaxgrpc::ApiCall<QuoteCampaignsRequest, QuoteCampaignsResponse> call);

        partial void Modify_BookCampaignsApiCall(ref gaxgrpc::ApiCall<BookCampaignsRequest, BookCampaignsResponse> call);

        partial void OnConstruction(ReservationService.ReservationServiceClient grpcClient, ReservationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ReservationService client</summary>
        public override ReservationService.ReservationServiceClient GrpcClient { get; }

        partial void Modify_QuoteCampaignsRequest(ref QuoteCampaignsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BookCampaignsRequest(ref BookCampaignsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Proposes quotes for booking campaigns.
        /// This request can have a latency of 30 seconds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QuoteCampaignsResponse QuoteCampaigns(QuoteCampaignsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QuoteCampaignsRequest(ref request, ref callSettings);
            return _callQuoteCampaigns.Sync(request, callSettings);
        }

        /// <summary>
        /// Proposes quotes for booking campaigns.
        /// This request can have a latency of 30 seconds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QuoteCampaignsResponse> QuoteCampaignsAsync(QuoteCampaignsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QuoteCampaignsRequest(ref request, ref callSettings);
            return _callQuoteCampaigns.Async(request, callSettings);
        }

        /// <summary>
        /// Books the requested campaigns.
        /// This request can have a latency of 30 seconds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BookCampaignsResponse BookCampaigns(BookCampaignsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BookCampaignsRequest(ref request, ref callSettings);
            return _callBookCampaigns.Sync(request, callSettings);
        }

        /// <summary>
        /// Books the requested campaigns.
        /// This request can have a latency of 30 seconds.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BookCampaignsResponse> BookCampaignsAsync(BookCampaignsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BookCampaignsRequest(ref request, ref callSettings);
            return _callBookCampaigns.Async(request, callSettings);
        }
    }
}

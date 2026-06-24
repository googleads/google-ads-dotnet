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

namespace Google.Ads.GoogleAds.V22.Services
{
    /// <summary>Settings for <see cref="MultiPartyAuthReviewServiceClient"/> instances.</summary>
    public sealed partial class MultiPartyAuthReviewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MultiPartyAuthReviewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MultiPartyAuthReviewServiceSettings"/>.</returns>
        public static MultiPartyAuthReviewServiceSettings GetDefault() => new MultiPartyAuthReviewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="MultiPartyAuthReviewServiceSettings"/> object with default settings.
        /// </summary>
        public MultiPartyAuthReviewServiceSettings()
        {
        }

        private MultiPartyAuthReviewServiceSettings(MultiPartyAuthReviewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ResolveMultiPartyAuthReviewSettings = existing.ResolveMultiPartyAuthReviewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MultiPartyAuthReviewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MultiPartyAuthReviewServiceClient.ResolveMultiPartyAuthReview</c> and
        /// <c>MultiPartyAuthReviewServiceClient.ResolveMultiPartyAuthReviewAsync</c>.
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
        public gaxgrpc::CallSettings ResolveMultiPartyAuthReviewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MultiPartyAuthReviewServiceSettings"/> object.</returns>
        public MultiPartyAuthReviewServiceSettings Clone() => new MultiPartyAuthReviewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MultiPartyAuthReviewServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class MultiPartyAuthReviewServiceClientBuilder : gaxgrpc::ClientBuilderBase<MultiPartyAuthReviewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MultiPartyAuthReviewServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MultiPartyAuthReviewServiceClientBuilder() : base(MultiPartyAuthReviewServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MultiPartyAuthReviewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MultiPartyAuthReviewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MultiPartyAuthReviewServiceClient Build()
        {
            MultiPartyAuthReviewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MultiPartyAuthReviewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MultiPartyAuthReviewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MultiPartyAuthReviewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MultiPartyAuthReviewServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<MultiPartyAuthReviewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MultiPartyAuthReviewServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MultiPartyAuthReviewServiceClient.ChannelPool;
    }

    /// <summary>MultiPartyAuthReviewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Multi-Party Authorization requests.
    /// </remarks>
    public abstract partial class MultiPartyAuthReviewServiceClient
    {
        /// <summary>
        /// The default endpoint for the MultiPartyAuthReviewService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default MultiPartyAuthReviewService scopes.</summary>
        /// <remarks>
        /// The default MultiPartyAuthReviewService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MultiPartyAuthReviewService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MultiPartyAuthReviewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="MultiPartyAuthReviewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MultiPartyAuthReviewServiceClient"/>.</returns>
        public static stt::Task<MultiPartyAuthReviewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MultiPartyAuthReviewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MultiPartyAuthReviewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="MultiPartyAuthReviewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MultiPartyAuthReviewServiceClient"/>.</returns>
        public static MultiPartyAuthReviewServiceClient Create() => new MultiPartyAuthReviewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MultiPartyAuthReviewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MultiPartyAuthReviewServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MultiPartyAuthReviewServiceClient"/>.</returns>
        internal static MultiPartyAuthReviewServiceClient Create(grpccore::CallInvoker callInvoker, MultiPartyAuthReviewServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MultiPartyAuthReviewService.MultiPartyAuthReviewServiceClient grpcClient = new MultiPartyAuthReviewService.MultiPartyAuthReviewServiceClient(callInvoker);
            return new MultiPartyAuthReviewServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MultiPartyAuthReviewService client</summary>
        public virtual MultiPartyAuthReviewService.MultiPartyAuthReviewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Resolves the status of a Multi-Party Authorization review.
        /// 
        /// List of thrown errors:
        /// [AccessInvitationError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerUserAccessError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MultiPartyAuthReviewError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResolveMultiPartyAuthReviewResponse ResolveMultiPartyAuthReview(ResolveMultiPartyAuthReviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resolves the status of a Multi-Party Authorization review.
        /// 
        /// List of thrown errors:
        /// [AccessInvitationError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerUserAccessError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MultiPartyAuthReviewError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveMultiPartyAuthReviewResponse> ResolveMultiPartyAuthReviewAsync(ResolveMultiPartyAuthReviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resolves the status of a Multi-Party Authorization review.
        /// 
        /// List of thrown errors:
        /// [AccessInvitationError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerUserAccessError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MultiPartyAuthReviewError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveMultiPartyAuthReviewResponse> ResolveMultiPartyAuthReviewAsync(ResolveMultiPartyAuthReviewRequest request, st::CancellationToken cancellationToken) =>
            ResolveMultiPartyAuthReviewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resolves the status of a Multi-Party Authorization review.
        /// 
        /// List of thrown errors:
        /// [AccessInvitationError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerUserAccessError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MultiPartyAuthReviewError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="operations">
        /// Required. The operations to perform. Currently only one operation is
        /// supported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResolveMultiPartyAuthReviewResponse ResolveMultiPartyAuthReview(string customerId, scg::IEnumerable<ResolveMultiPartyAuthReviewOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            ResolveMultiPartyAuthReview(new ResolveMultiPartyAuthReviewRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Resolves the status of a Multi-Party Authorization review.
        /// 
        /// List of thrown errors:
        /// [AccessInvitationError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerUserAccessError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MultiPartyAuthReviewError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="operations">
        /// Required. The operations to perform. Currently only one operation is
        /// supported.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveMultiPartyAuthReviewResponse> ResolveMultiPartyAuthReviewAsync(string customerId, scg::IEnumerable<ResolveMultiPartyAuthReviewOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            ResolveMultiPartyAuthReviewAsync(new ResolveMultiPartyAuthReviewRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Resolves the status of a Multi-Party Authorization review.
        /// 
        /// List of thrown errors:
        /// [AccessInvitationError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerUserAccessError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MultiPartyAuthReviewError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="operations">
        /// Required. The operations to perform. Currently only one operation is
        /// supported.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveMultiPartyAuthReviewResponse> ResolveMultiPartyAuthReviewAsync(string customerId, scg::IEnumerable<ResolveMultiPartyAuthReviewOperation> operations, st::CancellationToken cancellationToken) =>
            ResolveMultiPartyAuthReviewAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MultiPartyAuthReviewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Multi-Party Authorization requests.
    /// </remarks>
    public sealed partial class MultiPartyAuthReviewServiceClientImpl : MultiPartyAuthReviewServiceClient
    {
        private readonly gaxgrpc::ApiCall<ResolveMultiPartyAuthReviewRequest, ResolveMultiPartyAuthReviewResponse> _callResolveMultiPartyAuthReview;

        /// <summary>
        /// Constructs a client wrapper for the MultiPartyAuthReviewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="MultiPartyAuthReviewServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MultiPartyAuthReviewServiceClientImpl(MultiPartyAuthReviewService.MultiPartyAuthReviewServiceClient grpcClient, MultiPartyAuthReviewServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MultiPartyAuthReviewServiceSettings effectiveSettings = settings ?? MultiPartyAuthReviewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callResolveMultiPartyAuthReview = clientHelper.BuildApiCall<ResolveMultiPartyAuthReviewRequest, ResolveMultiPartyAuthReviewResponse>("ResolveMultiPartyAuthReview", grpcClient.ResolveMultiPartyAuthReviewAsync, grpcClient.ResolveMultiPartyAuthReview, effectiveSettings.ResolveMultiPartyAuthReviewSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callResolveMultiPartyAuthReview);
            Modify_ResolveMultiPartyAuthReviewApiCall(ref _callResolveMultiPartyAuthReview);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ResolveMultiPartyAuthReviewApiCall(ref gaxgrpc::ApiCall<ResolveMultiPartyAuthReviewRequest, ResolveMultiPartyAuthReviewResponse> call);

        partial void OnConstruction(MultiPartyAuthReviewService.MultiPartyAuthReviewServiceClient grpcClient, MultiPartyAuthReviewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MultiPartyAuthReviewService client</summary>
        public override MultiPartyAuthReviewService.MultiPartyAuthReviewServiceClient GrpcClient { get; }

        partial void Modify_ResolveMultiPartyAuthReviewRequest(ref ResolveMultiPartyAuthReviewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Resolves the status of a Multi-Party Authorization review.
        /// 
        /// List of thrown errors:
        /// [AccessInvitationError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerUserAccessError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MultiPartyAuthReviewError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ResolveMultiPartyAuthReviewResponse ResolveMultiPartyAuthReview(ResolveMultiPartyAuthReviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResolveMultiPartyAuthReviewRequest(ref request, ref callSettings);
            return _callResolveMultiPartyAuthReview.Sync(request, callSettings);
        }

        /// <summary>
        /// Resolves the status of a Multi-Party Authorization review.
        /// 
        /// List of thrown errors:
        /// [AccessInvitationError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerUserAccessError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MultiPartyAuthReviewError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ResolveMultiPartyAuthReviewResponse> ResolveMultiPartyAuthReviewAsync(ResolveMultiPartyAuthReviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResolveMultiPartyAuthReviewRequest(ref request, ref callSettings);
            return _callResolveMultiPartyAuthReview.Async(request, callSettings);
        }
    }
}

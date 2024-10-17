// Copyright 2024 Google LLC
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

namespace Google.Ads.GoogleAds.V18.Services
{
    /// <summary>Settings for <see cref="RecommendationSubscriptionServiceClient"/> instances.</summary>
    public sealed partial class RecommendationSubscriptionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="RecommendationSubscriptionServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="RecommendationSubscriptionServiceSettings"/>.</returns>
        public static RecommendationSubscriptionServiceSettings GetDefault() =>
            new RecommendationSubscriptionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="RecommendationSubscriptionServiceSettings"/> object with default settings.
        /// </summary>
        public RecommendationSubscriptionServiceSettings()
        {
        }

        private RecommendationSubscriptionServiceSettings(RecommendationSubscriptionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateRecommendationSubscriptionSettings = existing.MutateRecommendationSubscriptionSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RecommendationSubscriptionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommendationSubscriptionServiceClient.MutateRecommendationSubscription</c> and
        /// <c>RecommendationSubscriptionServiceClient.MutateRecommendationSubscriptionAsync</c>.
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
        public gaxgrpc::CallSettings MutateRecommendationSubscriptionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RecommendationSubscriptionServiceSettings"/> object.</returns>
        public RecommendationSubscriptionServiceSettings Clone() => new RecommendationSubscriptionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RecommendationSubscriptionServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class RecommendationSubscriptionServiceClientBuilder : gaxgrpc::ClientBuilderBase<RecommendationSubscriptionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RecommendationSubscriptionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RecommendationSubscriptionServiceClientBuilder() : base(RecommendationSubscriptionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RecommendationSubscriptionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RecommendationSubscriptionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RecommendationSubscriptionServiceClient Build()
        {
            RecommendationSubscriptionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RecommendationSubscriptionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RecommendationSubscriptionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RecommendationSubscriptionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RecommendationSubscriptionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RecommendationSubscriptionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RecommendationSubscriptionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RecommendationSubscriptionServiceClient.ChannelPool;
    }

    /// <summary>RecommendationSubscriptionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage recommendation subscriptions.
    /// </remarks>
    public abstract partial class RecommendationSubscriptionServiceClient
    {
        /// <summary>
        /// The default endpoint for the RecommendationSubscriptionService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default RecommendationSubscriptionService scopes.</summary>
        /// <remarks>
        /// The default RecommendationSubscriptionService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RecommendationSubscriptionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RecommendationSubscriptionServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RecommendationSubscriptionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RecommendationSubscriptionServiceClient"/>.</returns>
        public static stt::Task<RecommendationSubscriptionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RecommendationSubscriptionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RecommendationSubscriptionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RecommendationSubscriptionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RecommendationSubscriptionServiceClient"/>.</returns>
        public static RecommendationSubscriptionServiceClient Create() =>
            new RecommendationSubscriptionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RecommendationSubscriptionServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RecommendationSubscriptionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RecommendationSubscriptionServiceClient"/>.</returns>
        internal static RecommendationSubscriptionServiceClient Create(grpccore::CallInvoker callInvoker, RecommendationSubscriptionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RecommendationSubscriptionService.RecommendationSubscriptionServiceClient grpcClient = new RecommendationSubscriptionService.RecommendationSubscriptionServiceClient(callInvoker);
            return new RecommendationSubscriptionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RecommendationSubscriptionService client</summary>
        public virtual RecommendationSubscriptionService.RecommendationSubscriptionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates given subscription with corresponding apply parameters.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateRecommendationSubscriptionResponse MutateRecommendationSubscription(MutateRecommendationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates given subscription with corresponding apply parameters.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRecommendationSubscriptionResponse> MutateRecommendationSubscriptionAsync(MutateRecommendationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates given subscription with corresponding apply parameters.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRecommendationSubscriptionResponse> MutateRecommendationSubscriptionAsync(MutateRecommendationSubscriptionRequest request, st::CancellationToken cancellationToken) =>
            MutateRecommendationSubscriptionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates given subscription with corresponding apply parameters.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the subscribing customer.
        /// </param>
        /// <param name="operations">
        /// Required. The list of create or update operations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateRecommendationSubscriptionResponse MutateRecommendationSubscription(string customerId, scg::IEnumerable<RecommendationSubscriptionOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateRecommendationSubscription(new MutateRecommendationSubscriptionRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates given subscription with corresponding apply parameters.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the subscribing customer.
        /// </param>
        /// <param name="operations">
        /// Required. The list of create or update operations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRecommendationSubscriptionResponse> MutateRecommendationSubscriptionAsync(string customerId, scg::IEnumerable<RecommendationSubscriptionOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateRecommendationSubscriptionAsync(new MutateRecommendationSubscriptionRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Mutates given subscription with corresponding apply parameters.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the subscribing customer.
        /// </param>
        /// <param name="operations">
        /// Required. The list of create or update operations.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRecommendationSubscriptionResponse> MutateRecommendationSubscriptionAsync(string customerId, scg::IEnumerable<RecommendationSubscriptionOperation> operations, st::CancellationToken cancellationToken) =>
            MutateRecommendationSubscriptionAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RecommendationSubscriptionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage recommendation subscriptions.
    /// </remarks>
    public sealed partial class RecommendationSubscriptionServiceClientImpl : RecommendationSubscriptionServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateRecommendationSubscriptionRequest, MutateRecommendationSubscriptionResponse> _callMutateRecommendationSubscription;

        /// <summary>
        /// Constructs a client wrapper for the RecommendationSubscriptionService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="RecommendationSubscriptionServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RecommendationSubscriptionServiceClientImpl(RecommendationSubscriptionService.RecommendationSubscriptionServiceClient grpcClient, RecommendationSubscriptionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RecommendationSubscriptionServiceSettings effectiveSettings = settings ?? RecommendationSubscriptionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateRecommendationSubscription = clientHelper.BuildApiCall<MutateRecommendationSubscriptionRequest, MutateRecommendationSubscriptionResponse>("MutateRecommendationSubscription", grpcClient.MutateRecommendationSubscriptionAsync, grpcClient.MutateRecommendationSubscription, effectiveSettings.MutateRecommendationSubscriptionSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateRecommendationSubscription);
            Modify_MutateRecommendationSubscriptionApiCall(ref _callMutateRecommendationSubscription);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateRecommendationSubscriptionApiCall(ref gaxgrpc::ApiCall<MutateRecommendationSubscriptionRequest, MutateRecommendationSubscriptionResponse> call);

        partial void OnConstruction(RecommendationSubscriptionService.RecommendationSubscriptionServiceClient grpcClient, RecommendationSubscriptionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RecommendationSubscriptionService client</summary>
        public override RecommendationSubscriptionService.RecommendationSubscriptionServiceClient GrpcClient { get; }

        partial void Modify_MutateRecommendationSubscriptionRequest(ref MutateRecommendationSubscriptionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Mutates given subscription with corresponding apply parameters.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateRecommendationSubscriptionResponse MutateRecommendationSubscription(MutateRecommendationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateRecommendationSubscriptionRequest(ref request, ref callSettings);
            return _callMutateRecommendationSubscription.Sync(request, callSettings);
        }

        /// <summary>
        /// Mutates given subscription with corresponding apply parameters.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateRecommendationSubscriptionResponse> MutateRecommendationSubscriptionAsync(MutateRecommendationSubscriptionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateRecommendationSubscriptionRequest(ref request, ref callSettings);
            return _callMutateRecommendationSubscription.Async(request, callSettings);
        }
    }
}

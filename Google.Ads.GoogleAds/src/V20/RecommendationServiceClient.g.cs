// Copyright 2025 Google LLC
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
using gagve = Google.Ads.GoogleAds.V20.Enums;
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

namespace Google.Ads.GoogleAds.V20.Services
{
    /// <summary>Settings for <see cref="RecommendationServiceClient"/> instances.</summary>
    public sealed partial class RecommendationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RecommendationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RecommendationServiceSettings"/>.</returns>
        public static RecommendationServiceSettings GetDefault() => new RecommendationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="RecommendationServiceSettings"/> object with default settings.
        /// </summary>
        public RecommendationServiceSettings()
        {
        }

        private RecommendationServiceSettings(RecommendationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ApplyRecommendationSettings = existing.ApplyRecommendationSettings;
            DismissRecommendationSettings = existing.DismissRecommendationSettings;
            GenerateRecommendationsSettings = existing.GenerateRecommendationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RecommendationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommendationServiceClient.ApplyRecommendation</c> and
        /// <c>RecommendationServiceClient.ApplyRecommendationAsync</c>.
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
        public gaxgrpc::CallSettings ApplyRecommendationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommendationServiceClient.DismissRecommendation</c> and
        /// <c>RecommendationServiceClient.DismissRecommendationAsync</c>.
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
        public gaxgrpc::CallSettings DismissRecommendationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecommendationServiceClient.GenerateRecommendations</c> and
        /// <c>RecommendationServiceClient.GenerateRecommendationsAsync</c>.
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
        public gaxgrpc::CallSettings GenerateRecommendationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RecommendationServiceSettings"/> object.</returns>
        public RecommendationServiceSettings Clone() => new RecommendationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RecommendationServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class RecommendationServiceClientBuilder : gaxgrpc::ClientBuilderBase<RecommendationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RecommendationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RecommendationServiceClientBuilder() : base(RecommendationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RecommendationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RecommendationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RecommendationServiceClient Build()
        {
            RecommendationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RecommendationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RecommendationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RecommendationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RecommendationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RecommendationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RecommendationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RecommendationServiceClient.ChannelPool;
    }

    /// <summary>RecommendationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage recommendations.
    /// </remarks>
    public abstract partial class RecommendationServiceClient
    {
        /// <summary>
        /// The default endpoint for the RecommendationService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default RecommendationService scopes.</summary>
        /// <remarks>
        /// The default RecommendationService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RecommendationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RecommendationServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="RecommendationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RecommendationServiceClient"/>.</returns>
        public static stt::Task<RecommendationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RecommendationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RecommendationServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="RecommendationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RecommendationServiceClient"/>.</returns>
        public static RecommendationServiceClient Create() => new RecommendationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RecommendationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RecommendationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RecommendationServiceClient"/>.</returns>
        internal static RecommendationServiceClient Create(grpccore::CallInvoker callInvoker, RecommendationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RecommendationService.RecommendationServiceClient grpcClient = new RecommendationService.RecommendationServiceClient(callInvoker);
            return new RecommendationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RecommendationService client</summary>
        public virtual RecommendationService.RecommendationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Applies given recommendations with corresponding apply parameters.
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
        public virtual ApplyRecommendationResponse ApplyRecommendation(ApplyRecommendationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Applies given recommendations with corresponding apply parameters.
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
        public virtual stt::Task<ApplyRecommendationResponse> ApplyRecommendationAsync(ApplyRecommendationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Applies given recommendations with corresponding apply parameters.
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
        public virtual stt::Task<ApplyRecommendationResponse> ApplyRecommendationAsync(ApplyRecommendationRequest request, st::CancellationToken cancellationToken) =>
            ApplyRecommendationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Applies given recommendations with corresponding apply parameters.
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
        /// Required. The ID of the customer with the recommendation.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to apply recommendations.
        /// If partial_failure=false all recommendations should be of the same type
        /// There is a limit of 100 operations per request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplyRecommendationResponse ApplyRecommendation(string customerId, scg::IEnumerable<ApplyRecommendationOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            ApplyRecommendation(new ApplyRecommendationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Applies given recommendations with corresponding apply parameters.
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
        /// Required. The ID of the customer with the recommendation.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to apply recommendations.
        /// If partial_failure=false all recommendations should be of the same type
        /// There is a limit of 100 operations per request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplyRecommendationResponse> ApplyRecommendationAsync(string customerId, scg::IEnumerable<ApplyRecommendationOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            ApplyRecommendationAsync(new ApplyRecommendationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Applies given recommendations with corresponding apply parameters.
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
        /// Required. The ID of the customer with the recommendation.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to apply recommendations.
        /// If partial_failure=false all recommendations should be of the same type
        /// There is a limit of 100 operations per request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplyRecommendationResponse> ApplyRecommendationAsync(string customerId, scg::IEnumerable<ApplyRecommendationOperation> operations, st::CancellationToken cancellationToken) =>
            ApplyRecommendationAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Dismisses given recommendations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DismissRecommendationResponse DismissRecommendation(DismissRecommendationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Dismisses given recommendations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DismissRecommendationResponse> DismissRecommendationAsync(DismissRecommendationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Dismisses given recommendations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DismissRecommendationResponse> DismissRecommendationAsync(DismissRecommendationRequest request, st::CancellationToken cancellationToken) =>
            DismissRecommendationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Dismisses given recommendations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer with the recommendation.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to dismiss recommendations.
        /// If partial_failure=false all recommendations should be of the same type
        /// There is a limit of 100 operations per request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DismissRecommendationResponse DismissRecommendation(string customerId, scg::IEnumerable<DismissRecommendationRequest.Types.DismissRecommendationOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            DismissRecommendation(new DismissRecommendationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Dismisses given recommendations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer with the recommendation.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to dismiss recommendations.
        /// If partial_failure=false all recommendations should be of the same type
        /// There is a limit of 100 operations per request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DismissRecommendationResponse> DismissRecommendationAsync(string customerId, scg::IEnumerable<DismissRecommendationRequest.Types.DismissRecommendationOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            DismissRecommendationAsync(new DismissRecommendationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Dismisses given recommendations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer with the recommendation.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to dismiss recommendations.
        /// If partial_failure=false all recommendations should be of the same type
        /// There is a limit of 100 operations per request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DismissRecommendationResponse> DismissRecommendationAsync(string customerId, scg::IEnumerable<DismissRecommendationRequest.Types.DismissRecommendationOperation> operations, st::CancellationToken cancellationToken) =>
            DismissRecommendationAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates Recommendations based off the requested recommendation_types.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateRecommendationsResponse GenerateRecommendations(GenerateRecommendationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates Recommendations based off the requested recommendation_types.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateRecommendationsResponse> GenerateRecommendationsAsync(GenerateRecommendationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates Recommendations based off the requested recommendation_types.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateRecommendationsResponse> GenerateRecommendationsAsync(GenerateRecommendationsRequest request, st::CancellationToken cancellationToken) =>
            GenerateRecommendationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates Recommendations based off the requested recommendation_types.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer generating recommendations.
        /// </param>
        /// <param name="recommendationTypes">
        /// Required. List of eligible recommendation_types to generate. If the
        /// uploaded criteria isn't sufficient to make a recommendation, or the
        /// campaign is already in the recommended state, no recommendation will be
        /// returned for that type. Generally, a recommendation is returned if all
        /// required fields for that recommendation_type are uploaded, but there are
        /// cases where this is still not sufficient.
        /// 
        /// The following recommendation_types are supported for recommendation
        /// generation:
        /// CAMPAIGN_BUDGET, KEYWORD, MAXIMIZE_CLICKS_OPT_IN,
        /// MAXIMIZE_CONVERSIONS_OPT_IN, MAXIMIZE_CONVERSION_VALUE_OPT_IN,
        /// SET_TARGET_CPA, SET_TARGET_ROAS, SITELINK_ASSET, TARGET_CPA_OPT_IN,
        /// TARGET_ROAS_OPT_IN
        /// </param>
        /// <param name="advertisingChannelType">
        /// Required. Advertising channel type of the campaign.
        /// The following advertising_channel_types are supported for recommendation
        /// generation:
        /// PERFORMANCE_MAX and SEARCH
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateRecommendationsResponse GenerateRecommendations(string customerId, scg::IEnumerable<gagve::RecommendationTypeEnum.Types.RecommendationType> recommendationTypes, gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType advertisingChannelType, gaxgrpc::CallSettings callSettings = null) =>
            GenerateRecommendations(new GenerateRecommendationsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                RecommendationTypes =
                {
                    gax::GaxPreconditions.CheckNotNull(recommendationTypes, nameof(recommendationTypes)),
                },
                AdvertisingChannelType = advertisingChannelType,
            }, callSettings);

        /// <summary>
        /// Generates Recommendations based off the requested recommendation_types.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer generating recommendations.
        /// </param>
        /// <param name="recommendationTypes">
        /// Required. List of eligible recommendation_types to generate. If the
        /// uploaded criteria isn't sufficient to make a recommendation, or the
        /// campaign is already in the recommended state, no recommendation will be
        /// returned for that type. Generally, a recommendation is returned if all
        /// required fields for that recommendation_type are uploaded, but there are
        /// cases where this is still not sufficient.
        /// 
        /// The following recommendation_types are supported for recommendation
        /// generation:
        /// CAMPAIGN_BUDGET, KEYWORD, MAXIMIZE_CLICKS_OPT_IN,
        /// MAXIMIZE_CONVERSIONS_OPT_IN, MAXIMIZE_CONVERSION_VALUE_OPT_IN,
        /// SET_TARGET_CPA, SET_TARGET_ROAS, SITELINK_ASSET, TARGET_CPA_OPT_IN,
        /// TARGET_ROAS_OPT_IN
        /// </param>
        /// <param name="advertisingChannelType">
        /// Required. Advertising channel type of the campaign.
        /// The following advertising_channel_types are supported for recommendation
        /// generation:
        /// PERFORMANCE_MAX and SEARCH
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateRecommendationsResponse> GenerateRecommendationsAsync(string customerId, scg::IEnumerable<gagve::RecommendationTypeEnum.Types.RecommendationType> recommendationTypes, gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType advertisingChannelType, gaxgrpc::CallSettings callSettings = null) =>
            GenerateRecommendationsAsync(new GenerateRecommendationsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                RecommendationTypes =
                {
                    gax::GaxPreconditions.CheckNotNull(recommendationTypes, nameof(recommendationTypes)),
                },
                AdvertisingChannelType = advertisingChannelType,
            }, callSettings);

        /// <summary>
        /// Generates Recommendations based off the requested recommendation_types.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer generating recommendations.
        /// </param>
        /// <param name="recommendationTypes">
        /// Required. List of eligible recommendation_types to generate. If the
        /// uploaded criteria isn't sufficient to make a recommendation, or the
        /// campaign is already in the recommended state, no recommendation will be
        /// returned for that type. Generally, a recommendation is returned if all
        /// required fields for that recommendation_type are uploaded, but there are
        /// cases where this is still not sufficient.
        /// 
        /// The following recommendation_types are supported for recommendation
        /// generation:
        /// CAMPAIGN_BUDGET, KEYWORD, MAXIMIZE_CLICKS_OPT_IN,
        /// MAXIMIZE_CONVERSIONS_OPT_IN, MAXIMIZE_CONVERSION_VALUE_OPT_IN,
        /// SET_TARGET_CPA, SET_TARGET_ROAS, SITELINK_ASSET, TARGET_CPA_OPT_IN,
        /// TARGET_ROAS_OPT_IN
        /// </param>
        /// <param name="advertisingChannelType">
        /// Required. Advertising channel type of the campaign.
        /// The following advertising_channel_types are supported for recommendation
        /// generation:
        /// PERFORMANCE_MAX and SEARCH
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateRecommendationsResponse> GenerateRecommendationsAsync(string customerId, scg::IEnumerable<gagve::RecommendationTypeEnum.Types.RecommendationType> recommendationTypes, gagve::AdvertisingChannelTypeEnum.Types.AdvertisingChannelType advertisingChannelType, st::CancellationToken cancellationToken) =>
            GenerateRecommendationsAsync(customerId, recommendationTypes, advertisingChannelType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RecommendationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage recommendations.
    /// </remarks>
    public sealed partial class RecommendationServiceClientImpl : RecommendationServiceClient
    {
        private readonly gaxgrpc::ApiCall<ApplyRecommendationRequest, ApplyRecommendationResponse> _callApplyRecommendation;

        private readonly gaxgrpc::ApiCall<DismissRecommendationRequest, DismissRecommendationResponse> _callDismissRecommendation;

        private readonly gaxgrpc::ApiCall<GenerateRecommendationsRequest, GenerateRecommendationsResponse> _callGenerateRecommendations;

        /// <summary>
        /// Constructs a client wrapper for the RecommendationService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RecommendationServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RecommendationServiceClientImpl(RecommendationService.RecommendationServiceClient grpcClient, RecommendationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RecommendationServiceSettings effectiveSettings = settings ?? RecommendationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callApplyRecommendation = clientHelper.BuildApiCall<ApplyRecommendationRequest, ApplyRecommendationResponse>("ApplyRecommendation", grpcClient.ApplyRecommendationAsync, grpcClient.ApplyRecommendation, effectiveSettings.ApplyRecommendationSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callApplyRecommendation);
            Modify_ApplyRecommendationApiCall(ref _callApplyRecommendation);
            _callDismissRecommendation = clientHelper.BuildApiCall<DismissRecommendationRequest, DismissRecommendationResponse>("DismissRecommendation", grpcClient.DismissRecommendationAsync, grpcClient.DismissRecommendation, effectiveSettings.DismissRecommendationSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callDismissRecommendation);
            Modify_DismissRecommendationApiCall(ref _callDismissRecommendation);
            _callGenerateRecommendations = clientHelper.BuildApiCall<GenerateRecommendationsRequest, GenerateRecommendationsResponse>("GenerateRecommendations", grpcClient.GenerateRecommendationsAsync, grpcClient.GenerateRecommendations, effectiveSettings.GenerateRecommendationsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGenerateRecommendations);
            Modify_GenerateRecommendationsApiCall(ref _callGenerateRecommendations);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApplyRecommendationApiCall(ref gaxgrpc::ApiCall<ApplyRecommendationRequest, ApplyRecommendationResponse> call);

        partial void Modify_DismissRecommendationApiCall(ref gaxgrpc::ApiCall<DismissRecommendationRequest, DismissRecommendationResponse> call);

        partial void Modify_GenerateRecommendationsApiCall(ref gaxgrpc::ApiCall<GenerateRecommendationsRequest, GenerateRecommendationsResponse> call);

        partial void OnConstruction(RecommendationService.RecommendationServiceClient grpcClient, RecommendationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RecommendationService client</summary>
        public override RecommendationService.RecommendationServiceClient GrpcClient { get; }

        partial void Modify_ApplyRecommendationRequest(ref ApplyRecommendationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DismissRecommendationRequest(ref DismissRecommendationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateRecommendationsRequest(ref GenerateRecommendationsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Applies given recommendations with corresponding apply parameters.
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
        public override ApplyRecommendationResponse ApplyRecommendation(ApplyRecommendationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApplyRecommendationRequest(ref request, ref callSettings);
            return _callApplyRecommendation.Sync(request, callSettings);
        }

        /// <summary>
        /// Applies given recommendations with corresponding apply parameters.
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
        public override stt::Task<ApplyRecommendationResponse> ApplyRecommendationAsync(ApplyRecommendationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApplyRecommendationRequest(ref request, ref callSettings);
            return _callApplyRecommendation.Async(request, callSettings);
        }

        /// <summary>
        /// Dismisses given recommendations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DismissRecommendationResponse DismissRecommendation(DismissRecommendationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DismissRecommendationRequest(ref request, ref callSettings);
            return _callDismissRecommendation.Sync(request, callSettings);
        }

        /// <summary>
        /// Dismisses given recommendations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DismissRecommendationResponse> DismissRecommendationAsync(DismissRecommendationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DismissRecommendationRequest(ref request, ref callSettings);
            return _callDismissRecommendation.Async(request, callSettings);
        }

        /// <summary>
        /// Generates Recommendations based off the requested recommendation_types.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateRecommendationsResponse GenerateRecommendations(GenerateRecommendationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateRecommendationsRequest(ref request, ref callSettings);
            return _callGenerateRecommendations.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates Recommendations based off the requested recommendation_types.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RecommendationError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateRecommendationsResponse> GenerateRecommendationsAsync(GenerateRecommendationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateRecommendationsRequest(ref request, ref callSettings);
            return _callGenerateRecommendations.Async(request, callSettings);
        }
    }
}

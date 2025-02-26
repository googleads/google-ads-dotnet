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

namespace Google.Ads.GoogleAds.V19.Services
{
    /// <summary>Settings for <see cref="AdParameterServiceClient"/> instances.</summary>
    public sealed partial class AdParameterServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdParameterServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdParameterServiceSettings"/>.</returns>
        public static AdParameterServiceSettings GetDefault() => new AdParameterServiceSettings();

        /// <summary>Constructs a new <see cref="AdParameterServiceSettings"/> object with default settings.</summary>
        public AdParameterServiceSettings()
        {
        }

        private AdParameterServiceSettings(AdParameterServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateAdParametersSettings = existing.MutateAdParametersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdParameterServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdParameterServiceClient.MutateAdParameters</c> and <c>AdParameterServiceClient.MutateAdParametersAsync</c>
        /// .
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
        public gaxgrpc::CallSettings MutateAdParametersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdParameterServiceSettings"/> object.</returns>
        public AdParameterServiceSettings Clone() => new AdParameterServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdParameterServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class AdParameterServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdParameterServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdParameterServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AdParameterServiceClientBuilder() : base(AdParameterServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AdParameterServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdParameterServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdParameterServiceClient Build()
        {
            AdParameterServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdParameterServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdParameterServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdParameterServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdParameterServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AdParameterServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdParameterServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdParameterServiceClient.ChannelPool;
    }

    /// <summary>AdParameterService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ad parameters.
    /// </remarks>
    public abstract partial class AdParameterServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdParameterService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdParameterService scopes.</summary>
        /// <remarks>
        /// The default AdParameterService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AdParameterService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AdParameterServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdParameterServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdParameterServiceClient"/>.</returns>
        public static stt::Task<AdParameterServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdParameterServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdParameterServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdParameterServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="AdParameterServiceClient"/>.</returns>
        public static AdParameterServiceClient Create() => new AdParameterServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdParameterServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdParameterServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AdParameterServiceClient"/>.</returns>
        internal static AdParameterServiceClient Create(grpccore::CallInvoker callInvoker, AdParameterServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdParameterService.AdParameterServiceClient grpcClient = new AdParameterService.AdParameterServiceClient(callInvoker);
            return new AdParameterServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AdParameterService client</summary>
        public virtual AdParameterService.AdParameterServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ad parameters. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AdParameterError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdParametersResponse MutateAdParameters(MutateAdParametersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ad parameters. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AdParameterError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdParametersResponse> MutateAdParametersAsync(MutateAdParametersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ad parameters. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AdParameterError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdParametersResponse> MutateAdParametersAsync(MutateAdParametersRequest request, st::CancellationToken cancellationToken) =>
            MutateAdParametersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes ad parameters. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AdParameterError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad parameters are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad parameters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdParametersResponse MutateAdParameters(string customerId, scg::IEnumerable<AdParameterOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdParameters(new MutateAdParametersRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes ad parameters. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AdParameterError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad parameters are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad parameters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdParametersResponse> MutateAdParametersAsync(string customerId, scg::IEnumerable<AdParameterOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdParametersAsync(new MutateAdParametersRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes ad parameters. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AdParameterError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad parameters are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad parameters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdParametersResponse> MutateAdParametersAsync(string customerId, scg::IEnumerable<AdParameterOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAdParametersAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdParameterService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ad parameters.
    /// </remarks>
    public sealed partial class AdParameterServiceClientImpl : AdParameterServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateAdParametersRequest, MutateAdParametersResponse> _callMutateAdParameters;

        /// <summary>
        /// Constructs a client wrapper for the AdParameterService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdParameterServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AdParameterServiceClientImpl(AdParameterService.AdParameterServiceClient grpcClient, AdParameterServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AdParameterServiceSettings effectiveSettings = settings ?? AdParameterServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateAdParameters = clientHelper.BuildApiCall<MutateAdParametersRequest, MutateAdParametersResponse>("MutateAdParameters", grpcClient.MutateAdParametersAsync, grpcClient.MutateAdParameters, effectiveSettings.MutateAdParametersSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAdParameters);
            Modify_MutateAdParametersApiCall(ref _callMutateAdParameters);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateAdParametersApiCall(ref gaxgrpc::ApiCall<MutateAdParametersRequest, MutateAdParametersResponse> call);

        partial void OnConstruction(AdParameterService.AdParameterServiceClient grpcClient, AdParameterServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdParameterService client</summary>
        public override AdParameterService.AdParameterServiceClient GrpcClient { get; }

        partial void Modify_MutateAdParametersRequest(ref MutateAdParametersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes ad parameters. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AdParameterError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAdParametersResponse MutateAdParameters(MutateAdParametersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdParametersRequest(ref request, ref callSettings);
            return _callMutateAdParameters.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes ad parameters. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AdParameterError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAdParametersResponse> MutateAdParametersAsync(MutateAdParametersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdParametersRequest(ref request, ref callSettings);
            return _callMutateAdParameters.Async(request, callSettings);
        }
    }
}

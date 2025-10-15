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

namespace Google.Ads.GoogleAds.V22.Services
{
    /// <summary>Settings for <see cref="AudienceServiceClient"/> instances.</summary>
    public sealed partial class AudienceServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AudienceServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AudienceServiceSettings"/>.</returns>
        public static AudienceServiceSettings GetDefault() => new AudienceServiceSettings();

        /// <summary>Constructs a new <see cref="AudienceServiceSettings"/> object with default settings.</summary>
        public AudienceServiceSettings()
        {
        }

        private AudienceServiceSettings(AudienceServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateAudiencesSettings = existing.MutateAudiencesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AudienceServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AudienceServiceClient.MutateAudiences</c> and <c>AudienceServiceClient.MutateAudiencesAsync</c>.
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
        public gaxgrpc::CallSettings MutateAudiencesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AudienceServiceSettings"/> object.</returns>
        public AudienceServiceSettings Clone() => new AudienceServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AudienceServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class AudienceServiceClientBuilder : gaxgrpc::ClientBuilderBase<AudienceServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AudienceServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AudienceServiceClientBuilder() : base(AudienceServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AudienceServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AudienceServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AudienceServiceClient Build()
        {
            AudienceServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AudienceServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AudienceServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AudienceServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AudienceServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AudienceServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AudienceServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AudienceServiceClient.ChannelPool;
    }

    /// <summary>AudienceService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage audiences.
    /// </remarks>
    public abstract partial class AudienceServiceClient
    {
        /// <summary>
        /// The default endpoint for the AudienceService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AudienceService scopes.</summary>
        /// <remarks>
        /// The default AudienceService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AudienceService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AudienceServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AudienceServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AudienceServiceClient"/>.</returns>
        public static stt::Task<AudienceServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AudienceServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AudienceServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AudienceServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AudienceServiceClient"/>.</returns>
        public static AudienceServiceClient Create() => new AudienceServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AudienceServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AudienceServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AudienceServiceClient"/>.</returns>
        internal static AudienceServiceClient Create(grpccore::CallInvoker callInvoker, AudienceServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AudienceService.AudienceServiceClient grpcClient = new AudienceService.AudienceServiceClient(callInvoker);
            return new AudienceServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AudienceService client</summary>
        public virtual AudienceService.AudienceServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates audiences. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AudienceError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAudiencesResponse MutateAudiences(MutateAudiencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates audiences. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AudienceError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAudiencesResponse> MutateAudiencesAsync(MutateAudiencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates audiences. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AudienceError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAudiencesResponse> MutateAudiencesAsync(MutateAudiencesRequest request, st::CancellationToken cancellationToken) =>
            MutateAudiencesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates audiences. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AudienceError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose audiences are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual audiences.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAudiencesResponse MutateAudiences(string customerId, scg::IEnumerable<AudienceOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAudiences(new MutateAudiencesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates audiences. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AudienceError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose audiences are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual audiences.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAudiencesResponse> MutateAudiencesAsync(string customerId, scg::IEnumerable<AudienceOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAudiencesAsync(new MutateAudiencesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates audiences. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AudienceError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose audiences are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual audiences.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAudiencesResponse> MutateAudiencesAsync(string customerId, scg::IEnumerable<AudienceOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAudiencesAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AudienceService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage audiences.
    /// </remarks>
    public sealed partial class AudienceServiceClientImpl : AudienceServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateAudiencesRequest, MutateAudiencesResponse> _callMutateAudiences;

        /// <summary>
        /// Constructs a client wrapper for the AudienceService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AudienceServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AudienceServiceClientImpl(AudienceService.AudienceServiceClient grpcClient, AudienceServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AudienceServiceSettings effectiveSettings = settings ?? AudienceServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateAudiences = clientHelper.BuildApiCall<MutateAudiencesRequest, MutateAudiencesResponse>("MutateAudiences", grpcClient.MutateAudiencesAsync, grpcClient.MutateAudiences, effectiveSettings.MutateAudiencesSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAudiences);
            Modify_MutateAudiencesApiCall(ref _callMutateAudiences);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateAudiencesApiCall(ref gaxgrpc::ApiCall<MutateAudiencesRequest, MutateAudiencesResponse> call);

        partial void OnConstruction(AudienceService.AudienceServiceClient grpcClient, AudienceServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AudienceService client</summary>
        public override AudienceService.AudienceServiceClient GrpcClient { get; }

        partial void Modify_MutateAudiencesRequest(ref MutateAudiencesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates audiences. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AudienceError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAudiencesResponse MutateAudiences(MutateAudiencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAudiencesRequest(ref request, ref callSettings);
            return _callMutateAudiences.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates audiences. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AudienceError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAudiencesResponse> MutateAudiencesAsync(MutateAudiencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAudiencesRequest(ref request, ref callSettings);
            return _callMutateAudiences.Async(request, callSettings);
        }
    }
}

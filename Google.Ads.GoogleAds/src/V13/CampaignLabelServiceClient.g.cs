// Copyright 2023 Google LLC
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
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V13.Services
{
    /// <summary>Settings for <see cref="CampaignLabelServiceClient"/> instances.</summary>
    public sealed partial class CampaignLabelServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignLabelServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignLabelServiceSettings"/>.</returns>
        public static CampaignLabelServiceSettings GetDefault() => new CampaignLabelServiceSettings();

        /// <summary>Constructs a new <see cref="CampaignLabelServiceSettings"/> object with default settings.</summary>
        public CampaignLabelServiceSettings()
        {
        }

        private CampaignLabelServiceSettings(CampaignLabelServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCampaignLabelsSettings = existing.MutateCampaignLabelsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignLabelServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignLabelServiceClient.MutateCampaignLabels</c> and
        /// <c>CampaignLabelServiceClient.MutateCampaignLabelsAsync</c>.
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
        public gaxgrpc::CallSettings MutateCampaignLabelsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignLabelServiceSettings"/> object.</returns>
        public CampaignLabelServiceSettings Clone() => new CampaignLabelServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignLabelServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CampaignLabelServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignLabelServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignLabelServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CampaignLabelServiceClientBuilder() : base(CampaignLabelServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CampaignLabelServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignLabelServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignLabelServiceClient Build()
        {
            CampaignLabelServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignLabelServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignLabelServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignLabelServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignLabelServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<CampaignLabelServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignLabelServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignLabelServiceClient.ChannelPool;
    }

    /// <summary>CampaignLabelService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage labels on campaigns.
    /// </remarks>
    public abstract partial class CampaignLabelServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignLabelService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignLabelService scopes.</summary>
        /// <remarks>
        /// The default CampaignLabelService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CampaignLabelService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignLabelServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignLabelServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignLabelServiceClient"/>.</returns>
        public static stt::Task<CampaignLabelServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignLabelServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignLabelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignLabelServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignLabelServiceClient"/>.</returns>
        public static CampaignLabelServiceClient Create() => new CampaignLabelServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignLabelServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignLabelServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CampaignLabelServiceClient"/>.</returns>
        internal static CampaignLabelServiceClient Create(grpccore::CallInvoker callInvoker, CampaignLabelServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignLabelService.CampaignLabelServiceClient grpcClient = new CampaignLabelService.CampaignLabelServiceClient(callInvoker);
            return new CampaignLabelServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CampaignLabelService client</summary>
        public virtual CampaignLabelService.CampaignLabelServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and removes campaign-label relationships.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [LabelError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignLabelsResponse MutateCampaignLabels(MutateCampaignLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and removes campaign-label relationships.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [LabelError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignLabelsResponse> MutateCampaignLabelsAsync(MutateCampaignLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and removes campaign-label relationships.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [LabelError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignLabelsResponse> MutateCampaignLabelsAsync(MutateCampaignLabelsRequest request, st::CancellationToken cancellationToken) =>
            MutateCampaignLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and removes campaign-label relationships.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [LabelError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose campaign-label relationships are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on campaign-label
        /// relationships.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignLabelsResponse MutateCampaignLabels(string customerId, scg::IEnumerable<CampaignLabelOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignLabels(new MutateCampaignLabelsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates and removes campaign-label relationships.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [LabelError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose campaign-label relationships are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on campaign-label
        /// relationships.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignLabelsResponse> MutateCampaignLabelsAsync(string customerId, scg::IEnumerable<CampaignLabelOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignLabelsAsync(new MutateCampaignLabelsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates and removes campaign-label relationships.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [LabelError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose campaign-label relationships are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on campaign-label
        /// relationships.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignLabelsResponse> MutateCampaignLabelsAsync(string customerId, scg::IEnumerable<CampaignLabelOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCampaignLabelsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CampaignLabelService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage labels on campaigns.
    /// </remarks>
    public sealed partial class CampaignLabelServiceClientImpl : CampaignLabelServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCampaignLabelsRequest, MutateCampaignLabelsResponse> _callMutateCampaignLabels;

        /// <summary>
        /// Constructs a client wrapper for the CampaignLabelService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CampaignLabelServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CampaignLabelServiceClientImpl(CampaignLabelService.CampaignLabelServiceClient grpcClient, CampaignLabelServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CampaignLabelServiceSettings effectiveSettings = settings ?? CampaignLabelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callMutateCampaignLabels = clientHelper.BuildApiCall<MutateCampaignLabelsRequest, MutateCampaignLabelsResponse>("MutateCampaignLabels", grpcClient.MutateCampaignLabelsAsync, grpcClient.MutateCampaignLabels, effectiveSettings.MutateCampaignLabelsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCampaignLabels);
            Modify_MutateCampaignLabelsApiCall(ref _callMutateCampaignLabels);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCampaignLabelsApiCall(ref gaxgrpc::ApiCall<MutateCampaignLabelsRequest, MutateCampaignLabelsResponse> call);

        partial void OnConstruction(CampaignLabelService.CampaignLabelServiceClient grpcClient, CampaignLabelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignLabelService client</summary>
        public override CampaignLabelService.CampaignLabelServiceClient GrpcClient { get; }

        partial void Modify_MutateCampaignLabelsRequest(ref MutateCampaignLabelsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates and removes campaign-label relationships.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [LabelError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCampaignLabelsResponse MutateCampaignLabels(MutateCampaignLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignLabelsRequest(ref request, ref callSettings);
            return _callMutateCampaignLabels.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates and removes campaign-label relationships.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [LabelError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCampaignLabelsResponse> MutateCampaignLabelsAsync(MutateCampaignLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignLabelsRequest(ref request, ref callSettings);
            return _callMutateCampaignLabels.Async(request, callSettings);
        }
    }
}

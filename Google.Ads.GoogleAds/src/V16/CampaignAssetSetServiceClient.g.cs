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
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V16.Services
{
    /// <summary>Settings for <see cref="CampaignAssetSetServiceClient"/> instances.</summary>
    public sealed partial class CampaignAssetSetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignAssetSetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignAssetSetServiceSettings"/>.</returns>
        public static CampaignAssetSetServiceSettings GetDefault() => new CampaignAssetSetServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignAssetSetServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignAssetSetServiceSettings()
        {
        }

        private CampaignAssetSetServiceSettings(CampaignAssetSetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCampaignAssetSetsSettings = existing.MutateCampaignAssetSetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignAssetSetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignAssetSetServiceClient.MutateCampaignAssetSets</c> and
        /// <c>CampaignAssetSetServiceClient.MutateCampaignAssetSetsAsync</c>.
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
        public gaxgrpc::CallSettings MutateCampaignAssetSetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignAssetSetServiceSettings"/> object.</returns>
        public CampaignAssetSetServiceSettings Clone() => new CampaignAssetSetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignAssetSetServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CampaignAssetSetServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignAssetSetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignAssetSetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CampaignAssetSetServiceClientBuilder() : base(CampaignAssetSetServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CampaignAssetSetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignAssetSetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignAssetSetServiceClient Build()
        {
            CampaignAssetSetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignAssetSetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignAssetSetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignAssetSetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignAssetSetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CampaignAssetSetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignAssetSetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignAssetSetServiceClient.ChannelPool;
    }

    /// <summary>CampaignAssetSetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign asset set
    /// </remarks>
    public abstract partial class CampaignAssetSetServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignAssetSetService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignAssetSetService scopes.</summary>
        /// <remarks>
        /// The default CampaignAssetSetService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CampaignAssetSetService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignAssetSetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignAssetSetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignAssetSetServiceClient"/>.</returns>
        public static stt::Task<CampaignAssetSetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignAssetSetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignAssetSetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignAssetSetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignAssetSetServiceClient"/>.</returns>
        public static CampaignAssetSetServiceClient Create() => new CampaignAssetSetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignAssetSetServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignAssetSetServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CampaignAssetSetServiceClient"/>.</returns>
        internal static CampaignAssetSetServiceClient Create(grpccore::CallInvoker callInvoker, CampaignAssetSetServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignAssetSetService.CampaignAssetSetServiceClient grpcClient = new CampaignAssetSetService.CampaignAssetSetServiceClient(callInvoker);
            return new CampaignAssetSetServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CampaignAssetSetService client</summary>
        public virtual CampaignAssetSetService.CampaignAssetSetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes campaign asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignAssetSetsResponse MutateCampaignAssetSets(MutateCampaignAssetSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes campaign asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignAssetSetsResponse> MutateCampaignAssetSetsAsync(MutateCampaignAssetSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes campaign asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignAssetSetsResponse> MutateCampaignAssetSetsAsync(MutateCampaignAssetSetsRequest request, st::CancellationToken cancellationToken) =>
            MutateCampaignAssetSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes campaign asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign asset sets are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign asset
        /// sets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignAssetSetsResponse MutateCampaignAssetSets(string customerId, scg::IEnumerable<CampaignAssetSetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignAssetSets(new MutateCampaignAssetSetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes campaign asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign asset sets are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign asset
        /// sets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignAssetSetsResponse> MutateCampaignAssetSetsAsync(string customerId, scg::IEnumerable<CampaignAssetSetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignAssetSetsAsync(new MutateCampaignAssetSetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes campaign asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign asset sets are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign asset
        /// sets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignAssetSetsResponse> MutateCampaignAssetSetsAsync(string customerId, scg::IEnumerable<CampaignAssetSetOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCampaignAssetSetsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CampaignAssetSetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign asset set
    /// </remarks>
    public sealed partial class CampaignAssetSetServiceClientImpl : CampaignAssetSetServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCampaignAssetSetsRequest, MutateCampaignAssetSetsResponse> _callMutateCampaignAssetSets;

        /// <summary>
        /// Constructs a client wrapper for the CampaignAssetSetService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CampaignAssetSetServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CampaignAssetSetServiceClientImpl(CampaignAssetSetService.CampaignAssetSetServiceClient grpcClient, CampaignAssetSetServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CampaignAssetSetServiceSettings effectiveSettings = settings ?? CampaignAssetSetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateCampaignAssetSets = clientHelper.BuildApiCall<MutateCampaignAssetSetsRequest, MutateCampaignAssetSetsResponse>("MutateCampaignAssetSets", grpcClient.MutateCampaignAssetSetsAsync, grpcClient.MutateCampaignAssetSets, effectiveSettings.MutateCampaignAssetSetsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCampaignAssetSets);
            Modify_MutateCampaignAssetSetsApiCall(ref _callMutateCampaignAssetSets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCampaignAssetSetsApiCall(ref gaxgrpc::ApiCall<MutateCampaignAssetSetsRequest, MutateCampaignAssetSetsResponse> call);

        partial void OnConstruction(CampaignAssetSetService.CampaignAssetSetServiceClient grpcClient, CampaignAssetSetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignAssetSetService client</summary>
        public override CampaignAssetSetService.CampaignAssetSetServiceClient GrpcClient { get; }

        partial void Modify_MutateCampaignAssetSetsRequest(ref MutateCampaignAssetSetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates or removes campaign asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCampaignAssetSetsResponse MutateCampaignAssetSets(MutateCampaignAssetSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignAssetSetsRequest(ref request, ref callSettings);
            return _callMutateCampaignAssetSets.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes campaign asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCampaignAssetSetsResponse> MutateCampaignAssetSetsAsync(MutateCampaignAssetSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignAssetSetsRequest(ref request, ref callSettings);
            return _callMutateCampaignAssetSets.Async(request, callSettings);
        }
    }
}

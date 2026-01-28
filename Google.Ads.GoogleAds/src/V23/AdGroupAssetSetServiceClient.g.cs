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

namespace Google.Ads.GoogleAds.V23.Services
{
    /// <summary>Settings for <see cref="AdGroupAssetSetServiceClient"/> instances.</summary>
    public sealed partial class AdGroupAssetSetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdGroupAssetSetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdGroupAssetSetServiceSettings"/>.</returns>
        public static AdGroupAssetSetServiceSettings GetDefault() => new AdGroupAssetSetServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AdGroupAssetSetServiceSettings"/> object with default settings.
        /// </summary>
        public AdGroupAssetSetServiceSettings()
        {
        }

        private AdGroupAssetSetServiceSettings(AdGroupAssetSetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateAdGroupAssetSetsSettings = existing.MutateAdGroupAssetSetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupAssetSetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupAssetSetServiceClient.MutateAdGroupAssetSets</c> and
        /// <c>AdGroupAssetSetServiceClient.MutateAdGroupAssetSetsAsync</c>.
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
        public gaxgrpc::CallSettings MutateAdGroupAssetSetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdGroupAssetSetServiceSettings"/> object.</returns>
        public AdGroupAssetSetServiceSettings Clone() => new AdGroupAssetSetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdGroupAssetSetServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class AdGroupAssetSetServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdGroupAssetSetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdGroupAssetSetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AdGroupAssetSetServiceClientBuilder() : base(AdGroupAssetSetServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AdGroupAssetSetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdGroupAssetSetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdGroupAssetSetServiceClient Build()
        {
            AdGroupAssetSetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdGroupAssetSetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdGroupAssetSetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdGroupAssetSetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdGroupAssetSetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AdGroupAssetSetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdGroupAssetSetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdGroupAssetSetServiceClient.ChannelPool;
    }

    /// <summary>AdGroupAssetSetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ad group asset set
    /// </remarks>
    public abstract partial class AdGroupAssetSetServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupAssetSetService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdGroupAssetSetService scopes.</summary>
        /// <remarks>
        /// The default AdGroupAssetSetService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AdGroupAssetSetService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupAssetSetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupAssetSetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdGroupAssetSetServiceClient"/>.</returns>
        public static stt::Task<AdGroupAssetSetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdGroupAssetSetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupAssetSetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupAssetSetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdGroupAssetSetServiceClient"/>.</returns>
        public static AdGroupAssetSetServiceClient Create() => new AdGroupAssetSetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdGroupAssetSetServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdGroupAssetSetServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AdGroupAssetSetServiceClient"/>.</returns>
        internal static AdGroupAssetSetServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupAssetSetServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupAssetSetService.AdGroupAssetSetServiceClient grpcClient = new AdGroupAssetSetService.AdGroupAssetSetServiceClient(callInvoker);
            return new AdGroupAssetSetServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AdGroupAssetSetService client</summary>
        public virtual AdGroupAssetSetService.AdGroupAssetSetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, or removes ad group asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupAssetSetsResponse MutateAdGroupAssetSets(MutateAdGroupAssetSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, or removes ad group asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAssetSetsResponse> MutateAdGroupAssetSetsAsync(MutateAdGroupAssetSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, or removes ad group asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAssetSetsResponse> MutateAdGroupAssetSetsAsync(MutateAdGroupAssetSetsRequest request, st::CancellationToken cancellationToken) =>
            MutateAdGroupAssetSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, or removes ad group asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad group asset sets are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group asset
        /// sets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupAssetSetsResponse MutateAdGroupAssetSets(string customerId, scg::IEnumerable<AdGroupAssetSetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupAssetSets(new MutateAdGroupAssetSetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, or removes ad group asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad group asset sets are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group asset
        /// sets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAssetSetsResponse> MutateAdGroupAssetSetsAsync(string customerId, scg::IEnumerable<AdGroupAssetSetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupAssetSetsAsync(new MutateAdGroupAssetSetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, or removes ad group asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad group asset sets are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group asset
        /// sets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAssetSetsResponse> MutateAdGroupAssetSetsAsync(string customerId, scg::IEnumerable<AdGroupAssetSetOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAdGroupAssetSetsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdGroupAssetSetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ad group asset set
    /// </remarks>
    public sealed partial class AdGroupAssetSetServiceClientImpl : AdGroupAssetSetServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateAdGroupAssetSetsRequest, MutateAdGroupAssetSetsResponse> _callMutateAdGroupAssetSets;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupAssetSetService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AdGroupAssetSetServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AdGroupAssetSetServiceClientImpl(AdGroupAssetSetService.AdGroupAssetSetServiceClient grpcClient, AdGroupAssetSetServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AdGroupAssetSetServiceSettings effectiveSettings = settings ?? AdGroupAssetSetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateAdGroupAssetSets = clientHelper.BuildApiCall<MutateAdGroupAssetSetsRequest, MutateAdGroupAssetSetsResponse>("MutateAdGroupAssetSets", grpcClient.MutateAdGroupAssetSetsAsync, grpcClient.MutateAdGroupAssetSets, effectiveSettings.MutateAdGroupAssetSetsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAdGroupAssetSets);
            Modify_MutateAdGroupAssetSetsApiCall(ref _callMutateAdGroupAssetSets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateAdGroupAssetSetsApiCall(ref gaxgrpc::ApiCall<MutateAdGroupAssetSetsRequest, MutateAdGroupAssetSetsResponse> call);

        partial void OnConstruction(AdGroupAssetSetService.AdGroupAssetSetServiceClient grpcClient, AdGroupAssetSetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdGroupAssetSetService client</summary>
        public override AdGroupAssetSetService.AdGroupAssetSetServiceClient GrpcClient { get; }

        partial void Modify_MutateAdGroupAssetSetsRequest(ref MutateAdGroupAssetSetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, or removes ad group asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAdGroupAssetSetsResponse MutateAdGroupAssetSets(MutateAdGroupAssetSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupAssetSetsRequest(ref request, ref callSettings);
            return _callMutateAdGroupAssetSets.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, or removes ad group asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAdGroupAssetSetsResponse> MutateAdGroupAssetSetsAsync(MutateAdGroupAssetSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupAssetSetsRequest(ref request, ref callSettings);
            return _callMutateAdGroupAssetSets.Async(request, callSettings);
        }
    }
}

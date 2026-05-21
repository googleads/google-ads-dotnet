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
    /// <summary>Settings for <see cref="AssetGroupListingGroupFilterServiceClient"/> instances.</summary>
    public sealed partial class AssetGroupListingGroupFilterServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="AssetGroupListingGroupFilterServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="AssetGroupListingGroupFilterServiceSettings"/>.</returns>
        public static AssetGroupListingGroupFilterServiceSettings GetDefault() =>
            new AssetGroupListingGroupFilterServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AssetGroupListingGroupFilterServiceSettings"/> object with default settings.
        /// </summary>
        public AssetGroupListingGroupFilterServiceSettings()
        {
        }

        private AssetGroupListingGroupFilterServiceSettings(AssetGroupListingGroupFilterServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateAssetGroupListingGroupFiltersSettings = existing.MutateAssetGroupListingGroupFiltersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AssetGroupListingGroupFilterServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetGroupListingGroupFilterServiceClient.MutateAssetGroupListingGroupFilters</c> and
        /// <c>AssetGroupListingGroupFilterServiceClient.MutateAssetGroupListingGroupFiltersAsync</c>.
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
        public gaxgrpc::CallSettings MutateAssetGroupListingGroupFiltersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AssetGroupListingGroupFilterServiceSettings"/> object.</returns>
        public AssetGroupListingGroupFilterServiceSettings Clone() => new AssetGroupListingGroupFilterServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AssetGroupListingGroupFilterServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class AssetGroupListingGroupFilterServiceClientBuilder : gaxgrpc::ClientBuilderBase<AssetGroupListingGroupFilterServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AssetGroupListingGroupFilterServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AssetGroupListingGroupFilterServiceClientBuilder() : base(AssetGroupListingGroupFilterServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AssetGroupListingGroupFilterServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AssetGroupListingGroupFilterServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AssetGroupListingGroupFilterServiceClient Build()
        {
            AssetGroupListingGroupFilterServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AssetGroupListingGroupFilterServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AssetGroupListingGroupFilterServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AssetGroupListingGroupFilterServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AssetGroupListingGroupFilterServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AssetGroupListingGroupFilterServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AssetGroupListingGroupFilterServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AssetGroupListingGroupFilterServiceClient.ChannelPool;
    }

    /// <summary>AssetGroupListingGroupFilterService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage asset group listing group filter.
    /// </remarks>
    public abstract partial class AssetGroupListingGroupFilterServiceClient
    {
        /// <summary>
        /// The default endpoint for the AssetGroupListingGroupFilterService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AssetGroupListingGroupFilterService scopes.</summary>
        /// <remarks>
        /// The default AssetGroupListingGroupFilterService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AssetGroupListingGroupFilterService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AssetGroupListingGroupFilterServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AssetGroupListingGroupFilterServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>
        /// The task representing the created <see cref="AssetGroupListingGroupFilterServiceClient"/>.
        /// </returns>
        public static stt::Task<AssetGroupListingGroupFilterServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AssetGroupListingGroupFilterServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AssetGroupListingGroupFilterServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AssetGroupListingGroupFilterServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AssetGroupListingGroupFilterServiceClient"/>.</returns>
        public static AssetGroupListingGroupFilterServiceClient Create() =>
            new AssetGroupListingGroupFilterServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AssetGroupListingGroupFilterServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AssetGroupListingGroupFilterServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AssetGroupListingGroupFilterServiceClient"/>.</returns>
        internal static AssetGroupListingGroupFilterServiceClient Create(grpccore::CallInvoker callInvoker, AssetGroupListingGroupFilterServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AssetGroupListingGroupFilterService.AssetGroupListingGroupFilterServiceClient grpcClient = new AssetGroupListingGroupFilterService.AssetGroupListingGroupFilterServiceClient(callInvoker);
            return new AssetGroupListingGroupFilterServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AssetGroupListingGroupFilterService client</summary>
        public virtual AssetGroupListingGroupFilterService.AssetGroupListingGroupFilterServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes asset group listing group filters. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAssetGroupListingGroupFiltersResponse MutateAssetGroupListingGroupFilters(MutateAssetGroupListingGroupFiltersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes asset group listing group filters. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetGroupListingGroupFiltersResponse> MutateAssetGroupListingGroupFiltersAsync(MutateAssetGroupListingGroupFiltersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes asset group listing group filters. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetGroupListingGroupFiltersResponse> MutateAssetGroupListingGroupFiltersAsync(MutateAssetGroupListingGroupFiltersRequest request, st::CancellationToken cancellationToken) =>
            MutateAssetGroupListingGroupFiltersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes asset group listing group filters. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose asset group listing group filters
        /// are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual asset group
        /// listing group filters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAssetGroupListingGroupFiltersResponse MutateAssetGroupListingGroupFilters(string customerId, scg::IEnumerable<AssetGroupListingGroupFilterOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAssetGroupListingGroupFilters(new MutateAssetGroupListingGroupFiltersRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes asset group listing group filters. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose asset group listing group filters
        /// are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual asset group
        /// listing group filters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetGroupListingGroupFiltersResponse> MutateAssetGroupListingGroupFiltersAsync(string customerId, scg::IEnumerable<AssetGroupListingGroupFilterOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAssetGroupListingGroupFiltersAsync(new MutateAssetGroupListingGroupFiltersRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes asset group listing group filters. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose asset group listing group filters
        /// are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual asset group
        /// listing group filters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetGroupListingGroupFiltersResponse> MutateAssetGroupListingGroupFiltersAsync(string customerId, scg::IEnumerable<AssetGroupListingGroupFilterOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAssetGroupListingGroupFiltersAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AssetGroupListingGroupFilterService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage asset group listing group filter.
    /// </remarks>
    public sealed partial class AssetGroupListingGroupFilterServiceClientImpl : AssetGroupListingGroupFilterServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateAssetGroupListingGroupFiltersRequest, MutateAssetGroupListingGroupFiltersResponse> _callMutateAssetGroupListingGroupFilters;

        /// <summary>
        /// Constructs a client wrapper for the AssetGroupListingGroupFilterService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AssetGroupListingGroupFilterServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AssetGroupListingGroupFilterServiceClientImpl(AssetGroupListingGroupFilterService.AssetGroupListingGroupFilterServiceClient grpcClient, AssetGroupListingGroupFilterServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AssetGroupListingGroupFilterServiceSettings effectiveSettings = settings ?? AssetGroupListingGroupFilterServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateAssetGroupListingGroupFilters = clientHelper.BuildApiCall<MutateAssetGroupListingGroupFiltersRequest, MutateAssetGroupListingGroupFiltersResponse>("MutateAssetGroupListingGroupFilters", grpcClient.MutateAssetGroupListingGroupFiltersAsync, grpcClient.MutateAssetGroupListingGroupFilters, effectiveSettings.MutateAssetGroupListingGroupFiltersSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAssetGroupListingGroupFilters);
            Modify_MutateAssetGroupListingGroupFiltersApiCall(ref _callMutateAssetGroupListingGroupFilters);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateAssetGroupListingGroupFiltersApiCall(ref gaxgrpc::ApiCall<MutateAssetGroupListingGroupFiltersRequest, MutateAssetGroupListingGroupFiltersResponse> call);

        partial void OnConstruction(AssetGroupListingGroupFilterService.AssetGroupListingGroupFilterServiceClient grpcClient, AssetGroupListingGroupFilterServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AssetGroupListingGroupFilterService client</summary>
        public override AssetGroupListingGroupFilterService.AssetGroupListingGroupFilterServiceClient GrpcClient { get; }

        partial void Modify_MutateAssetGroupListingGroupFiltersRequest(ref MutateAssetGroupListingGroupFiltersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates or removes asset group listing group filters. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAssetGroupListingGroupFiltersResponse MutateAssetGroupListingGroupFilters(MutateAssetGroupListingGroupFiltersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAssetGroupListingGroupFiltersRequest(ref request, ref callSettings);
            return _callMutateAssetGroupListingGroupFilters.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes asset group listing group filters. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAssetGroupListingGroupFiltersResponse> MutateAssetGroupListingGroupFiltersAsync(MutateAssetGroupListingGroupFiltersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAssetGroupListingGroupFiltersRequest(ref request, ref callSettings);
            return _callMutateAssetGroupListingGroupFilters.Async(request, callSettings);
        }
    }
}

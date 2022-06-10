// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V11.Services
{
    /// <summary>Settings for <see cref="AssetSetServiceClient"/> instances.</summary>
    public sealed partial class AssetSetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AssetSetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AssetSetServiceSettings"/>.</returns>
        public static AssetSetServiceSettings GetDefault() => new AssetSetServiceSettings();

        /// <summary>Constructs a new <see cref="AssetSetServiceSettings"/> object with default settings.</summary>
        public AssetSetServiceSettings()
        {
        }

        private AssetSetServiceSettings(AssetSetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateAssetSetsSettings = existing.MutateAssetSetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AssetSetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetSetServiceClient.MutateAssetSets</c> and <c>AssetSetServiceClient.MutateAssetSetsAsync</c>.
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
        public gaxgrpc::CallSettings MutateAssetSetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AssetSetServiceSettings"/> object.</returns>
        public AssetSetServiceSettings Clone() => new AssetSetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AssetSetServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class AssetSetServiceClientBuilder : gaxgrpc::ClientBuilderBase<AssetSetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AssetSetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AssetSetServiceClientBuilder()
        {
            UseJwtAccessWithScopes = AssetSetServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref AssetSetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AssetSetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AssetSetServiceClient Build()
        {
            AssetSetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AssetSetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AssetSetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AssetSetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AssetSetServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AssetSetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AssetSetServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AssetSetServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AssetSetServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AssetSetServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AssetSetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage asset set
    /// </remarks>
    public abstract partial class AssetSetServiceClient
    {
        /// <summary>
        /// The default endpoint for the AssetSetService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AssetSetService scopes.</summary>
        /// <remarks>
        /// The default AssetSetService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AssetSetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AssetSetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AssetSetServiceClient"/>.</returns>
        public static stt::Task<AssetSetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AssetSetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AssetSetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AssetSetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AssetSetServiceClient"/>.</returns>
        public static AssetSetServiceClient Create() => new AssetSetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AssetSetServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AssetSetServiceSettings"/>.</param>
        /// <returns>The created <see cref="AssetSetServiceClient"/>.</returns>
        internal static AssetSetServiceClient Create(grpccore::CallInvoker callInvoker, AssetSetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AssetSetService.AssetSetServiceClient grpcClient = new AssetSetService.AssetSetServiceClient(callInvoker);
            return new AssetSetServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AssetSetService client</summary>
        public virtual AssetSetService.AssetSetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAssetSetsResponse MutateAssetSets(MutateAssetSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetSetsResponse> MutateAssetSetsAsync(MutateAssetSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetSetsResponse> MutateAssetSetsAsync(MutateAssetSetsRequest request, st::CancellationToken cancellationToken) =>
            MutateAssetSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose asset sets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual asset sets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAssetSetsResponse MutateAssetSets(string customerId, scg::IEnumerable<AssetSetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAssetSets(new MutateAssetSetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose asset sets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual asset sets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetSetsResponse> MutateAssetSetsAsync(string customerId, scg::IEnumerable<AssetSetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAssetSetsAsync(new MutateAssetSetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose asset sets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual asset sets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetSetsResponse> MutateAssetSetsAsync(string customerId, scg::IEnumerable<AssetSetOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAssetSetsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AssetSetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage asset set
    /// </remarks>
    public sealed partial class AssetSetServiceClientImpl : AssetSetServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateAssetSetsRequest, MutateAssetSetsResponse> _callMutateAssetSets;

        /// <summary>
        /// Constructs a client wrapper for the AssetSetService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AssetSetServiceSettings"/> used within this client.</param>
        public AssetSetServiceClientImpl(AssetSetService.AssetSetServiceClient grpcClient, AssetSetServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AssetSetServiceSettings effectiveSettings = settings ?? AssetSetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callMutateAssetSets = clientHelper.BuildApiCall<MutateAssetSetsRequest, MutateAssetSetsResponse>(grpcClient.MutateAssetSetsAsync, grpcClient.MutateAssetSets, effectiveSettings.MutateAssetSetsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAssetSets);
            Modify_MutateAssetSetsApiCall(ref _callMutateAssetSets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateAssetSetsApiCall(ref gaxgrpc::ApiCall<MutateAssetSetsRequest, MutateAssetSetsResponse> call);

        partial void OnConstruction(AssetSetService.AssetSetServiceClient grpcClient, AssetSetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AssetSetService client</summary>
        public override AssetSetService.AssetSetServiceClient GrpcClient { get; }

        partial void Modify_MutateAssetSetsRequest(ref MutateAssetSetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates or removes asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAssetSetsResponse MutateAssetSets(MutateAssetSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAssetSetsRequest(ref request, ref callSettings);
            return _callMutateAssetSets.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAssetSetsResponse> MutateAssetSetsAsync(MutateAssetSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAssetSetsRequest(ref request, ref callSettings);
            return _callMutateAssetSets.Async(request, callSettings);
        }
    }
}

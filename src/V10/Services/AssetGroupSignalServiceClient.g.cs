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

namespace Google.Ads.GoogleAds.V10.Services
{
    /// <summary>Settings for <see cref="AssetGroupSignalServiceClient"/> instances.</summary>
    public sealed partial class AssetGroupSignalServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AssetGroupSignalServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AssetGroupSignalServiceSettings"/>.</returns>
        public static AssetGroupSignalServiceSettings GetDefault() => new AssetGroupSignalServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AssetGroupSignalServiceSettings"/> object with default settings.
        /// </summary>
        public AssetGroupSignalServiceSettings()
        {
        }

        private AssetGroupSignalServiceSettings(AssetGroupSignalServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateAssetGroupSignalsSettings = existing.MutateAssetGroupSignalsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AssetGroupSignalServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetGroupSignalServiceClient.MutateAssetGroupSignals</c> and
        /// <c>AssetGroupSignalServiceClient.MutateAssetGroupSignalsAsync</c>.
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
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateAssetGroupSignalsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AssetGroupSignalServiceSettings"/> object.</returns>
        public AssetGroupSignalServiceSettings Clone() => new AssetGroupSignalServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AssetGroupSignalServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class AssetGroupSignalServiceClientBuilder : gaxgrpc::ClientBuilderBase<AssetGroupSignalServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AssetGroupSignalServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AssetGroupSignalServiceClientBuilder()
        {
            UseJwtAccessWithScopes = AssetGroupSignalServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref AssetGroupSignalServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AssetGroupSignalServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AssetGroupSignalServiceClient Build()
        {
            AssetGroupSignalServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AssetGroupSignalServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AssetGroupSignalServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AssetGroupSignalServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AssetGroupSignalServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AssetGroupSignalServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AssetGroupSignalServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AssetGroupSignalServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AssetGroupSignalServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AssetGroupSignalServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AssetGroupSignalService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage asset group signal.
    /// </remarks>
    public abstract partial class AssetGroupSignalServiceClient
    {
        /// <summary>
        /// The default endpoint for the AssetGroupSignalService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AssetGroupSignalService scopes.</summary>
        /// <remarks>
        /// The default AssetGroupSignalService scopes are:
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
        /// Asynchronously creates a <see cref="AssetGroupSignalServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AssetGroupSignalServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AssetGroupSignalServiceClient"/>.</returns>
        public static stt::Task<AssetGroupSignalServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AssetGroupSignalServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AssetGroupSignalServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AssetGroupSignalServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AssetGroupSignalServiceClient"/>.</returns>
        public static AssetGroupSignalServiceClient Create() => new AssetGroupSignalServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AssetGroupSignalServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AssetGroupSignalServiceSettings"/>.</param>
        /// <returns>The created <see cref="AssetGroupSignalServiceClient"/>.</returns>
        internal static AssetGroupSignalServiceClient Create(grpccore::CallInvoker callInvoker, AssetGroupSignalServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AssetGroupSignalService.AssetGroupSignalServiceClient grpcClient = new AssetGroupSignalService.AssetGroupSignalServiceClient(callInvoker);
            return new AssetGroupSignalServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AssetGroupSignalService client</summary>
        public virtual AssetGroupSignalService.AssetGroupSignalServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes asset group signals. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAssetGroupSignalsResponse MutateAssetGroupSignals(MutateAssetGroupSignalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes asset group signals. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetGroupSignalsResponse> MutateAssetGroupSignalsAsync(MutateAssetGroupSignalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes asset group signals. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetGroupSignalsResponse> MutateAssetGroupSignalsAsync(MutateAssetGroupSignalsRequest request, st::CancellationToken cancellationToken) =>
            MutateAssetGroupSignalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes asset group signals. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose asset group signals are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual asset group signals.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAssetGroupSignalsResponse MutateAssetGroupSignals(string customerId, scg::IEnumerable<AssetGroupSignalOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAssetGroupSignals(new MutateAssetGroupSignalsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or removes asset group signals. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose asset group signals are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual asset group signals.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetGroupSignalsResponse> MutateAssetGroupSignalsAsync(string customerId, scg::IEnumerable<AssetGroupSignalOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAssetGroupSignalsAsync(new MutateAssetGroupSignalsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or removes asset group signals. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose asset group signals are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual asset group signals.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAssetGroupSignalsResponse> MutateAssetGroupSignalsAsync(string customerId, scg::IEnumerable<AssetGroupSignalOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAssetGroupSignalsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AssetGroupSignalService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage asset group signal.
    /// </remarks>
    public sealed partial class AssetGroupSignalServiceClientImpl : AssetGroupSignalServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateAssetGroupSignalsRequest, MutateAssetGroupSignalsResponse> _callMutateAssetGroupSignals;

        /// <summary>
        /// Constructs a client wrapper for the AssetGroupSignalService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AssetGroupSignalServiceSettings"/> used within this client.
        /// </param>
        public AssetGroupSignalServiceClientImpl(AssetGroupSignalService.AssetGroupSignalServiceClient grpcClient, AssetGroupSignalServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AssetGroupSignalServiceSettings effectiveSettings = settings ?? AssetGroupSignalServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callMutateAssetGroupSignals = clientHelper.BuildApiCall<MutateAssetGroupSignalsRequest, MutateAssetGroupSignalsResponse>(grpcClient.MutateAssetGroupSignalsAsync, grpcClient.MutateAssetGroupSignals, effectiveSettings.MutateAssetGroupSignalsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAssetGroupSignals);
            Modify_MutateAssetGroupSignalsApiCall(ref _callMutateAssetGroupSignals);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateAssetGroupSignalsApiCall(ref gaxgrpc::ApiCall<MutateAssetGroupSignalsRequest, MutateAssetGroupSignalsResponse> call);

        partial void OnConstruction(AssetGroupSignalService.AssetGroupSignalServiceClient grpcClient, AssetGroupSignalServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AssetGroupSignalService client</summary>
        public override AssetGroupSignalService.AssetGroupSignalServiceClient GrpcClient { get; }

        partial void Modify_MutateAssetGroupSignalsRequest(ref MutateAssetGroupSignalsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates or removes asset group signals. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAssetGroupSignalsResponse MutateAssetGroupSignals(MutateAssetGroupSignalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAssetGroupSignalsRequest(ref request, ref callSettings);
            return _callMutateAssetGroupSignals.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or removes asset group signals. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAssetGroupSignalsResponse> MutateAssetGroupSignalsAsync(MutateAssetGroupSignalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAssetGroupSignalsRequest(ref request, ref callSettings);
            return _callMutateAssetGroupSignals.Async(request, callSettings);
        }
    }
}

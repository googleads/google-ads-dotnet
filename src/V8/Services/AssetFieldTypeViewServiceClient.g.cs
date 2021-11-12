// Copyright 2021 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V8.Resources;
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

namespace Google.Ads.GoogleAds.V8.Services
{
    /// <summary>Settings for <see cref="AssetFieldTypeViewServiceClient"/> instances.</summary>
    public sealed partial class AssetFieldTypeViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AssetFieldTypeViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AssetFieldTypeViewServiceSettings"/>.</returns>
        public static AssetFieldTypeViewServiceSettings GetDefault() => new AssetFieldTypeViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AssetFieldTypeViewServiceSettings"/> object with default settings.
        /// </summary>
        public AssetFieldTypeViewServiceSettings()
        {
        }

        private AssetFieldTypeViewServiceSettings(AssetFieldTypeViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAssetFieldTypeViewSettings = existing.GetAssetFieldTypeViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AssetFieldTypeViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetFieldTypeViewServiceClient.GetAssetFieldTypeView</c> and
        /// <c>AssetFieldTypeViewServiceClient.GetAssetFieldTypeViewAsync</c>.
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
        public gaxgrpc::CallSettings GetAssetFieldTypeViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AssetFieldTypeViewServiceSettings"/> object.</returns>
        public AssetFieldTypeViewServiceSettings Clone() => new AssetFieldTypeViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AssetFieldTypeViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class AssetFieldTypeViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<AssetFieldTypeViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AssetFieldTypeViewServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AssetFieldTypeViewServiceClientBuilder()
        {
            UseJwtAccessWithScopes = AssetFieldTypeViewServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref AssetFieldTypeViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AssetFieldTypeViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AssetFieldTypeViewServiceClient Build()
        {
            AssetFieldTypeViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AssetFieldTypeViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AssetFieldTypeViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AssetFieldTypeViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AssetFieldTypeViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AssetFieldTypeViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AssetFieldTypeViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AssetFieldTypeViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AssetFieldTypeViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AssetFieldTypeViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AssetFieldTypeViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch asset field type views.
    /// </remarks>
    public abstract partial class AssetFieldTypeViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the AssetFieldTypeViewService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AssetFieldTypeViewService scopes.</summary>
        /// <remarks>
        /// The default AssetFieldTypeViewService scopes are:
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
        /// Asynchronously creates a <see cref="AssetFieldTypeViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AssetFieldTypeViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AssetFieldTypeViewServiceClient"/>.</returns>
        public static stt::Task<AssetFieldTypeViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AssetFieldTypeViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AssetFieldTypeViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AssetFieldTypeViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AssetFieldTypeViewServiceClient"/>.</returns>
        public static AssetFieldTypeViewServiceClient Create() => new AssetFieldTypeViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AssetFieldTypeViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AssetFieldTypeViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="AssetFieldTypeViewServiceClient"/>.</returns>
        internal static AssetFieldTypeViewServiceClient Create(grpccore::CallInvoker callInvoker, AssetFieldTypeViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AssetFieldTypeViewService.AssetFieldTypeViewServiceClient grpcClient = new AssetFieldTypeViewService.AssetFieldTypeViewServiceClient(callInvoker);
            return new AssetFieldTypeViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AssetFieldTypeViewService client</summary>
        public virtual AssetFieldTypeViewService.AssetFieldTypeViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested asset field type view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AssetFieldTypeView GetAssetFieldTypeView(GetAssetFieldTypeViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested asset field type view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AssetFieldTypeView> GetAssetFieldTypeViewAsync(GetAssetFieldTypeViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested asset field type view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AssetFieldTypeView> GetAssetFieldTypeViewAsync(GetAssetFieldTypeViewRequest request, st::CancellationToken cancellationToken) =>
            GetAssetFieldTypeViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested asset field type view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the asset field type view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AssetFieldTypeView GetAssetFieldTypeView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAssetFieldTypeView(new GetAssetFieldTypeViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested asset field type view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the asset field type view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AssetFieldTypeView> GetAssetFieldTypeViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAssetFieldTypeViewAsync(new GetAssetFieldTypeViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested asset field type view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the asset field type view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AssetFieldTypeView> GetAssetFieldTypeViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAssetFieldTypeViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested asset field type view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the asset field type view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AssetFieldTypeView GetAssetFieldTypeView(gagvr::AssetFieldTypeViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAssetFieldTypeView(new GetAssetFieldTypeViewRequest
            {
                ResourceNameAsAssetFieldTypeViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested asset field type view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the asset field type view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AssetFieldTypeView> GetAssetFieldTypeViewAsync(gagvr::AssetFieldTypeViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAssetFieldTypeViewAsync(new GetAssetFieldTypeViewRequest
            {
                ResourceNameAsAssetFieldTypeViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested asset field type view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the asset field type view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AssetFieldTypeView> GetAssetFieldTypeViewAsync(gagvr::AssetFieldTypeViewName resourceName, st::CancellationToken cancellationToken) =>
            GetAssetFieldTypeViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AssetFieldTypeViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch asset field type views.
    /// </remarks>
    public sealed partial class AssetFieldTypeViewServiceClientImpl : AssetFieldTypeViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAssetFieldTypeViewRequest, gagvr::AssetFieldTypeView> _callGetAssetFieldTypeView;

        /// <summary>
        /// Constructs a client wrapper for the AssetFieldTypeViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AssetFieldTypeViewServiceSettings"/> used within this client.
        /// </param>
        public AssetFieldTypeViewServiceClientImpl(AssetFieldTypeViewService.AssetFieldTypeViewServiceClient grpcClient, AssetFieldTypeViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AssetFieldTypeViewServiceSettings effectiveSettings = settings ?? AssetFieldTypeViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAssetFieldTypeView = clientHelper.BuildApiCall<GetAssetFieldTypeViewRequest, gagvr::AssetFieldTypeView>(grpcClient.GetAssetFieldTypeViewAsync, grpcClient.GetAssetFieldTypeView, effectiveSettings.GetAssetFieldTypeViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAssetFieldTypeView);
            Modify_GetAssetFieldTypeViewApiCall(ref _callGetAssetFieldTypeView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAssetFieldTypeViewApiCall(ref gaxgrpc::ApiCall<GetAssetFieldTypeViewRequest, gagvr::AssetFieldTypeView> call);

        partial void OnConstruction(AssetFieldTypeViewService.AssetFieldTypeViewServiceClient grpcClient, AssetFieldTypeViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AssetFieldTypeViewService client</summary>
        public override AssetFieldTypeViewService.AssetFieldTypeViewServiceClient GrpcClient { get; }

        partial void Modify_GetAssetFieldTypeViewRequest(ref GetAssetFieldTypeViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested asset field type view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::AssetFieldTypeView GetAssetFieldTypeView(GetAssetFieldTypeViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAssetFieldTypeViewRequest(ref request, ref callSettings);
            return _callGetAssetFieldTypeView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested asset field type view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::AssetFieldTypeView> GetAssetFieldTypeViewAsync(GetAssetFieldTypeViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAssetFieldTypeViewRequest(ref request, ref callSettings);
            return _callGetAssetFieldTypeView.Async(request, callSettings);
        }
    }
}

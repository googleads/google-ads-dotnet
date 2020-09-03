// Copyright 2020 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V3.Resources;
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

namespace Google.Ads.GoogleAds.V3.Services
{
    /// <summary>Settings for <see cref="CurrencyConstantServiceClient"/> instances.</summary>
    public sealed partial class CurrencyConstantServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CurrencyConstantServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CurrencyConstantServiceSettings"/>.</returns>
        public static CurrencyConstantServiceSettings GetDefault() => new CurrencyConstantServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CurrencyConstantServiceSettings"/> object with default settings.
        /// </summary>
        public CurrencyConstantServiceSettings()
        {
        }

        private CurrencyConstantServiceSettings(CurrencyConstantServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCurrencyConstantSettings = existing.GetCurrencyConstantSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CurrencyConstantServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CurrencyConstantServiceClient.GetCurrencyConstant</c> and
        /// <c>CurrencyConstantServiceClient.GetCurrencyConstantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCurrencyConstantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CurrencyConstantServiceSettings"/> object.</returns>
        public CurrencyConstantServiceSettings Clone() => new CurrencyConstantServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CurrencyConstantServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CurrencyConstantServiceClientBuilder : gaxgrpc::ClientBuilderBase<CurrencyConstantServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CurrencyConstantServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CurrencyConstantServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CurrencyConstantServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CurrencyConstantServiceClient Build()
        {
            CurrencyConstantServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CurrencyConstantServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CurrencyConstantServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CurrencyConstantServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CurrencyConstantServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CurrencyConstantServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CurrencyConstantServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CurrencyConstantServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CurrencyConstantServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CurrencyConstantServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CurrencyConstantService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch currency constants.
    /// </remarks>
    public abstract partial class CurrencyConstantServiceClient
    {
        /// <summary>
        /// The default endpoint for the CurrencyConstantService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CurrencyConstantService scopes.</summary>
        /// <remarks>The default CurrencyConstantService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CurrencyConstantServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CurrencyConstantServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CurrencyConstantServiceClient"/>.</returns>
        public static stt::Task<CurrencyConstantServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CurrencyConstantServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CurrencyConstantServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CurrencyConstantServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CurrencyConstantServiceClient"/>.</returns>
        public static CurrencyConstantServiceClient Create() => new CurrencyConstantServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CurrencyConstantServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CurrencyConstantServiceSettings"/>.</param>
        /// <returns>The created <see cref="CurrencyConstantServiceClient"/>.</returns>
        internal static CurrencyConstantServiceClient Create(grpccore::CallInvoker callInvoker, CurrencyConstantServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CurrencyConstantService.CurrencyConstantServiceClient grpcClient = new CurrencyConstantService.CurrencyConstantServiceClient(callInvoker);
            return new CurrencyConstantServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CurrencyConstantService client</summary>
        public virtual CurrencyConstantService.CurrencyConstantServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested currency constant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CurrencyConstant GetCurrencyConstant(GetCurrencyConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested currency constant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CurrencyConstant> GetCurrencyConstantAsync(GetCurrencyConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested currency constant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CurrencyConstant> GetCurrencyConstantAsync(GetCurrencyConstantRequest request, st::CancellationToken cancellationToken) =>
            GetCurrencyConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested currency constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the currency constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CurrencyConstant GetCurrencyConstant(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCurrencyConstant(new GetCurrencyConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested currency constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the currency constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CurrencyConstant> GetCurrencyConstantAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCurrencyConstantAsync(new GetCurrencyConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested currency constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the currency constant to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CurrencyConstant> GetCurrencyConstantAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCurrencyConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested currency constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the currency constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CurrencyConstant GetCurrencyConstant(gagvr::CurrencyConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCurrencyConstant(new GetCurrencyConstantRequest
            {
                ResourceNameAsCurrencyConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested currency constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the currency constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CurrencyConstant> GetCurrencyConstantAsync(gagvr::CurrencyConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCurrencyConstantAsync(new GetCurrencyConstantRequest
            {
                ResourceNameAsCurrencyConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested currency constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the currency constant to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CurrencyConstant> GetCurrencyConstantAsync(gagvr::CurrencyConstantName resourceName, st::CancellationToken cancellationToken) =>
            GetCurrencyConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CurrencyConstantService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch currency constants.
    /// </remarks>
    public sealed partial class CurrencyConstantServiceClientImpl : CurrencyConstantServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCurrencyConstantRequest, gagvr::CurrencyConstant> _callGetCurrencyConstant;

        /// <summary>
        /// Constructs a client wrapper for the CurrencyConstantService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CurrencyConstantServiceSettings"/> used within this client.
        /// </param>
        public CurrencyConstantServiceClientImpl(CurrencyConstantService.CurrencyConstantServiceClient grpcClient, CurrencyConstantServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CurrencyConstantServiceSettings effectiveSettings = settings ?? CurrencyConstantServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCurrencyConstant = clientHelper.BuildApiCall<GetCurrencyConstantRequest, gagvr::CurrencyConstant>(grpcClient.GetCurrencyConstantAsync, grpcClient.GetCurrencyConstant, effectiveSettings.GetCurrencyConstantSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCurrencyConstant);
            Modify_GetCurrencyConstantApiCall(ref _callGetCurrencyConstant);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCurrencyConstantApiCall(ref gaxgrpc::ApiCall<GetCurrencyConstantRequest, gagvr::CurrencyConstant> call);

        partial void OnConstruction(CurrencyConstantService.CurrencyConstantServiceClient grpcClient, CurrencyConstantServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CurrencyConstantService client</summary>
        public override CurrencyConstantService.CurrencyConstantServiceClient GrpcClient { get; }

        partial void Modify_GetCurrencyConstantRequest(ref GetCurrencyConstantRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested currency constant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::CurrencyConstant GetCurrencyConstant(GetCurrencyConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCurrencyConstantRequest(ref request, ref callSettings);
            return _callGetCurrencyConstant.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested currency constant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CurrencyConstant> GetCurrencyConstantAsync(GetCurrencyConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCurrencyConstantRequest(ref request, ref callSettings);
            return _callGetCurrencyConstant.Async(request, callSettings);
        }
    }
}

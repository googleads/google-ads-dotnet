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

using gagvr = Google.Ads.GoogleAds.V2.Resources;
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

namespace Google.Ads.GoogleAds.V2.Services
{
    /// <summary>Settings for <see cref="MobileAppCategoryConstantServiceClient"/> instances.</summary>
    public sealed partial class MobileAppCategoryConstantServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MobileAppCategoryConstantServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MobileAppCategoryConstantServiceSettings"/>.</returns>
        public static MobileAppCategoryConstantServiceSettings GetDefault() => new MobileAppCategoryConstantServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="MobileAppCategoryConstantServiceSettings"/> object with default settings.
        /// </summary>
        public MobileAppCategoryConstantServiceSettings()
        {
        }

        private MobileAppCategoryConstantServiceSettings(MobileAppCategoryConstantServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetMobileAppCategoryConstantSettings = existing.GetMobileAppCategoryConstantSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MobileAppCategoryConstantServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MobileAppCategoryConstantServiceClient.GetMobileAppCategoryConstant</c> and
        /// <c>MobileAppCategoryConstantServiceClient.GetMobileAppCategoryConstantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMobileAppCategoryConstantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MobileAppCategoryConstantServiceSettings"/> object.</returns>
        public MobileAppCategoryConstantServiceSettings Clone() => new MobileAppCategoryConstantServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MobileAppCategoryConstantServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class MobileAppCategoryConstantServiceClientBuilder : gaxgrpc::ClientBuilderBase<MobileAppCategoryConstantServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MobileAppCategoryConstantServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref MobileAppCategoryConstantServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MobileAppCategoryConstantServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MobileAppCategoryConstantServiceClient Build()
        {
            MobileAppCategoryConstantServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MobileAppCategoryConstantServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MobileAppCategoryConstantServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MobileAppCategoryConstantServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MobileAppCategoryConstantServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<MobileAppCategoryConstantServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MobileAppCategoryConstantServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => MobileAppCategoryConstantServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            MobileAppCategoryConstantServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MobileAppCategoryConstantServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>MobileAppCategoryConstantService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch mobile app category constants.
    /// </remarks>
    public abstract partial class MobileAppCategoryConstantServiceClient
    {
        /// <summary>
        /// The default endpoint for the MobileAppCategoryConstantService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default MobileAppCategoryConstantService scopes.</summary>
        /// <remarks>The default MobileAppCategoryConstantService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="MobileAppCategoryConstantServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="MobileAppCategoryConstantServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MobileAppCategoryConstantServiceClient"/>.</returns>
        public static stt::Task<MobileAppCategoryConstantServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MobileAppCategoryConstantServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MobileAppCategoryConstantServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="MobileAppCategoryConstantServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MobileAppCategoryConstantServiceClient"/>.</returns>
        public static MobileAppCategoryConstantServiceClient Create() =>
            new MobileAppCategoryConstantServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MobileAppCategoryConstantServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MobileAppCategoryConstantServiceSettings"/>.</param>
        /// <returns>The created <see cref="MobileAppCategoryConstantServiceClient"/>.</returns>
        internal static MobileAppCategoryConstantServiceClient Create(grpccore::CallInvoker callInvoker, MobileAppCategoryConstantServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient grpcClient = new MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient(callInvoker);
            return new MobileAppCategoryConstantServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC MobileAppCategoryConstantService client</summary>
        public virtual MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested mobile app category constant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::MobileAppCategoryConstant GetMobileAppCategoryConstant(GetMobileAppCategoryConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested mobile app category constant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MobileAppCategoryConstant> GetMobileAppCategoryConstantAsync(GetMobileAppCategoryConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested mobile app category constant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MobileAppCategoryConstant> GetMobileAppCategoryConstantAsync(GetMobileAppCategoryConstantRequest request, st::CancellationToken cancellationToken) =>
            GetMobileAppCategoryConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested mobile app category constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the mobile app category constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::MobileAppCategoryConstant GetMobileAppCategoryConstant(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileAppCategoryConstant(new GetMobileAppCategoryConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested mobile app category constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the mobile app category constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MobileAppCategoryConstant> GetMobileAppCategoryConstantAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileAppCategoryConstantAsync(new GetMobileAppCategoryConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested mobile app category constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the mobile app category constant to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MobileAppCategoryConstant> GetMobileAppCategoryConstantAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetMobileAppCategoryConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested mobile app category constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the mobile app category constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::MobileAppCategoryConstant GetMobileAppCategoryConstant(gagvr::MobileAppCategoryConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileAppCategoryConstant(new GetMobileAppCategoryConstantRequest
            {
                ResourceNameAsMobileAppCategoryConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested mobile app category constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the mobile app category constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MobileAppCategoryConstant> GetMobileAppCategoryConstantAsync(gagvr::MobileAppCategoryConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileAppCategoryConstantAsync(new GetMobileAppCategoryConstantRequest
            {
                ResourceNameAsMobileAppCategoryConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested mobile app category constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the mobile app category constant to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MobileAppCategoryConstant> GetMobileAppCategoryConstantAsync(gagvr::MobileAppCategoryConstantName resourceName, st::CancellationToken cancellationToken) =>
            GetMobileAppCategoryConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MobileAppCategoryConstantService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch mobile app category constants.
    /// </remarks>
    public sealed partial class MobileAppCategoryConstantServiceClientImpl : MobileAppCategoryConstantServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetMobileAppCategoryConstantRequest, gagvr::MobileAppCategoryConstant> _callGetMobileAppCategoryConstant;

        /// <summary>
        /// Constructs a client wrapper for the MobileAppCategoryConstantService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="MobileAppCategoryConstantServiceSettings"/> used within this client.
        /// </param>
        public MobileAppCategoryConstantServiceClientImpl(MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient grpcClient, MobileAppCategoryConstantServiceSettings settings)
        {
            GrpcClient = grpcClient;
            MobileAppCategoryConstantServiceSettings effectiveSettings = settings ?? MobileAppCategoryConstantServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetMobileAppCategoryConstant = clientHelper.BuildApiCall<GetMobileAppCategoryConstantRequest, gagvr::MobileAppCategoryConstant>(grpcClient.GetMobileAppCategoryConstantAsync, grpcClient.GetMobileAppCategoryConstant, effectiveSettings.GetMobileAppCategoryConstantSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetMobileAppCategoryConstant);
            Modify_GetMobileAppCategoryConstantApiCall(ref _callGetMobileAppCategoryConstant);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetMobileAppCategoryConstantApiCall(ref gaxgrpc::ApiCall<GetMobileAppCategoryConstantRequest, gagvr::MobileAppCategoryConstant> call);

        partial void OnConstruction(MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient grpcClient, MobileAppCategoryConstantServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MobileAppCategoryConstantService client</summary>
        public override MobileAppCategoryConstantService.MobileAppCategoryConstantServiceClient GrpcClient { get; }

        partial void Modify_GetMobileAppCategoryConstantRequest(ref GetMobileAppCategoryConstantRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested mobile app category constant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::MobileAppCategoryConstant GetMobileAppCategoryConstant(GetMobileAppCategoryConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMobileAppCategoryConstantRequest(ref request, ref callSettings);
            return _callGetMobileAppCategoryConstant.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested mobile app category constant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::MobileAppCategoryConstant> GetMobileAppCategoryConstantAsync(GetMobileAppCategoryConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMobileAppCategoryConstantRequest(ref request, ref callSettings);
            return _callGetMobileAppCategoryConstant.Async(request, callSettings);
        }
    }
}

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

using gagvr = Google.Ads.GoogleAds.V6.Resources;
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

namespace Google.Ads.GoogleAds.V6.Services
{
    /// <summary>Settings for <see cref="MobileDeviceConstantServiceClient"/> instances.</summary>
    public sealed partial class MobileDeviceConstantServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MobileDeviceConstantServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MobileDeviceConstantServiceSettings"/>.</returns>
        public static MobileDeviceConstantServiceSettings GetDefault() => new MobileDeviceConstantServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="MobileDeviceConstantServiceSettings"/> object with default settings.
        /// </summary>
        public MobileDeviceConstantServiceSettings()
        {
        }

        private MobileDeviceConstantServiceSettings(MobileDeviceConstantServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetMobileDeviceConstantSettings = existing.GetMobileDeviceConstantSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MobileDeviceConstantServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MobileDeviceConstantServiceClient.GetMobileDeviceConstant</c> and
        /// <c>MobileDeviceConstantServiceClient.GetMobileDeviceConstantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMobileDeviceConstantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MobileDeviceConstantServiceSettings"/> object.</returns>
        public MobileDeviceConstantServiceSettings Clone() => new MobileDeviceConstantServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MobileDeviceConstantServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class MobileDeviceConstantServiceClientBuilder : gaxgrpc::ClientBuilderBase<MobileDeviceConstantServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MobileDeviceConstantServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref MobileDeviceConstantServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MobileDeviceConstantServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MobileDeviceConstantServiceClient Build()
        {
            MobileDeviceConstantServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MobileDeviceConstantServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MobileDeviceConstantServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MobileDeviceConstantServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MobileDeviceConstantServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<MobileDeviceConstantServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MobileDeviceConstantServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => MobileDeviceConstantServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => MobileDeviceConstantServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MobileDeviceConstantServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>MobileDeviceConstantService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch mobile device constants.
    /// </remarks>
    public abstract partial class MobileDeviceConstantServiceClient
    {
        /// <summary>
        /// The default endpoint for the MobileDeviceConstantService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default MobileDeviceConstantService scopes.</summary>
        /// <remarks>
        /// The default MobileDeviceConstantService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="MobileDeviceConstantServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="MobileDeviceConstantServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MobileDeviceConstantServiceClient"/>.</returns>
        public static stt::Task<MobileDeviceConstantServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MobileDeviceConstantServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MobileDeviceConstantServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="MobileDeviceConstantServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MobileDeviceConstantServiceClient"/>.</returns>
        public static MobileDeviceConstantServiceClient Create() => new MobileDeviceConstantServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MobileDeviceConstantServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MobileDeviceConstantServiceSettings"/>.</param>
        /// <returns>The created <see cref="MobileDeviceConstantServiceClient"/>.</returns>
        internal static MobileDeviceConstantServiceClient Create(grpccore::CallInvoker callInvoker, MobileDeviceConstantServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MobileDeviceConstantService.MobileDeviceConstantServiceClient grpcClient = new MobileDeviceConstantService.MobileDeviceConstantServiceClient(callInvoker);
            return new MobileDeviceConstantServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC MobileDeviceConstantService client</summary>
        public virtual MobileDeviceConstantService.MobileDeviceConstantServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested mobile device constant in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::MobileDeviceConstant GetMobileDeviceConstant(GetMobileDeviceConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested mobile device constant in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MobileDeviceConstant> GetMobileDeviceConstantAsync(GetMobileDeviceConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested mobile device constant in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MobileDeviceConstant> GetMobileDeviceConstantAsync(GetMobileDeviceConstantRequest request, st::CancellationToken cancellationToken) =>
            GetMobileDeviceConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested mobile device constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the mobile device to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::MobileDeviceConstant GetMobileDeviceConstant(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileDeviceConstant(new GetMobileDeviceConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested mobile device constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the mobile device to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MobileDeviceConstant> GetMobileDeviceConstantAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileDeviceConstantAsync(new GetMobileDeviceConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested mobile device constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the mobile device to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MobileDeviceConstant> GetMobileDeviceConstantAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetMobileDeviceConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested mobile device constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the mobile device to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::MobileDeviceConstant GetMobileDeviceConstant(gagvr::MobileDeviceConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileDeviceConstant(new GetMobileDeviceConstantRequest
            {
                ResourceNameAsMobileDeviceConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested mobile device constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the mobile device to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MobileDeviceConstant> GetMobileDeviceConstantAsync(gagvr::MobileDeviceConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMobileDeviceConstantAsync(new GetMobileDeviceConstantRequest
            {
                ResourceNameAsMobileDeviceConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested mobile device constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the mobile device to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MobileDeviceConstant> GetMobileDeviceConstantAsync(gagvr::MobileDeviceConstantName resourceName, st::CancellationToken cancellationToken) =>
            GetMobileDeviceConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MobileDeviceConstantService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch mobile device constants.
    /// </remarks>
    public sealed partial class MobileDeviceConstantServiceClientImpl : MobileDeviceConstantServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetMobileDeviceConstantRequest, gagvr::MobileDeviceConstant> _callGetMobileDeviceConstant;

        /// <summary>
        /// Constructs a client wrapper for the MobileDeviceConstantService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="MobileDeviceConstantServiceSettings"/> used within this client.
        /// </param>
        public MobileDeviceConstantServiceClientImpl(MobileDeviceConstantService.MobileDeviceConstantServiceClient grpcClient, MobileDeviceConstantServiceSettings settings)
        {
            GrpcClient = grpcClient;
            MobileDeviceConstantServiceSettings effectiveSettings = settings ?? MobileDeviceConstantServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetMobileDeviceConstant = clientHelper.BuildApiCall<GetMobileDeviceConstantRequest, gagvr::MobileDeviceConstant>(grpcClient.GetMobileDeviceConstantAsync, grpcClient.GetMobileDeviceConstant, effectiveSettings.GetMobileDeviceConstantSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetMobileDeviceConstant);
            Modify_GetMobileDeviceConstantApiCall(ref _callGetMobileDeviceConstant);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetMobileDeviceConstantApiCall(ref gaxgrpc::ApiCall<GetMobileDeviceConstantRequest, gagvr::MobileDeviceConstant> call);

        partial void OnConstruction(MobileDeviceConstantService.MobileDeviceConstantServiceClient grpcClient, MobileDeviceConstantServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MobileDeviceConstantService client</summary>
        public override MobileDeviceConstantService.MobileDeviceConstantServiceClient GrpcClient { get; }

        partial void Modify_GetMobileDeviceConstantRequest(ref GetMobileDeviceConstantRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested mobile device constant in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::MobileDeviceConstant GetMobileDeviceConstant(GetMobileDeviceConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMobileDeviceConstantRequest(ref request, ref callSettings);
            return _callGetMobileDeviceConstant.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested mobile device constant in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::MobileDeviceConstant> GetMobileDeviceConstantAsync(GetMobileDeviceConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMobileDeviceConstantRequest(ref request, ref callSettings);
            return _callGetMobileDeviceConstant.Async(request, callSettings);
        }
    }
}

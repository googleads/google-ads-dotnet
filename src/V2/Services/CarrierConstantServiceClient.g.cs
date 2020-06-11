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
    /// <summary>Settings for <see cref="CarrierConstantServiceClient"/> instances.</summary>
    public sealed partial class CarrierConstantServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CarrierConstantServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CarrierConstantServiceSettings"/>.</returns>
        public static CarrierConstantServiceSettings GetDefault() => new CarrierConstantServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CarrierConstantServiceSettings"/> object with default settings.
        /// </summary>
        public CarrierConstantServiceSettings()
        {
        }

        private CarrierConstantServiceSettings(CarrierConstantServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCarrierConstantSettings = existing.GetCarrierConstantSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CarrierConstantServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CarrierConstantServiceClient.GetCarrierConstant</c> and
        /// <c>CarrierConstantServiceClient.GetCarrierConstantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCarrierConstantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CarrierConstantServiceSettings"/> object.</returns>
        public CarrierConstantServiceSettings Clone() => new CarrierConstantServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CarrierConstantServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CarrierConstantServiceClientBuilder : gaxgrpc::ClientBuilderBase<CarrierConstantServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CarrierConstantServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CarrierConstantServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CarrierConstantServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CarrierConstantServiceClient Build()
        {
            CarrierConstantServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CarrierConstantServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CarrierConstantServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CarrierConstantServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CarrierConstantServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CarrierConstantServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CarrierConstantServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CarrierConstantServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CarrierConstantServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CarrierConstantServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CarrierConstantService client wrapper, for convenient use.</summary>
    public abstract partial class CarrierConstantServiceClient
    {
        /// <summary>
        /// The default endpoint for the CarrierConstantService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CarrierConstantService scopes.</summary>
        /// <remarks>The default CarrierConstantService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CarrierConstantServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CarrierConstantServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CarrierConstantServiceClient"/>.</returns>
        public static stt::Task<CarrierConstantServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CarrierConstantServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CarrierConstantServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CarrierConstantServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CarrierConstantServiceClient"/>.</returns>
        public static CarrierConstantServiceClient Create() => new CarrierConstantServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CarrierConstantServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CarrierConstantServiceSettings"/>.</param>
        /// <returns>The created <see cref="CarrierConstantServiceClient"/>.</returns>
        internal static CarrierConstantServiceClient Create(grpccore::CallInvoker callInvoker, CarrierConstantServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CarrierConstantService.CarrierConstantServiceClient grpcClient = new CarrierConstantService.CarrierConstantServiceClient(callInvoker);
            return new CarrierConstantServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CarrierConstantService client</summary>
        public virtual CarrierConstantService.CarrierConstantServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested carrier constant in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CarrierConstant GetCarrierConstant(GetCarrierConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested carrier constant in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CarrierConstant> GetCarrierConstantAsync(GetCarrierConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested carrier constant in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CarrierConstant> GetCarrierConstantAsync(GetCarrierConstantRequest request, st::CancellationToken cancellationToken) =>
            GetCarrierConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested carrier constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the carrier constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CarrierConstant GetCarrierConstant(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCarrierConstant(new GetCarrierConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested carrier constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the carrier constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CarrierConstant> GetCarrierConstantAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCarrierConstantAsync(new GetCarrierConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested carrier constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the carrier constant to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CarrierConstant> GetCarrierConstantAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCarrierConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested carrier constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the carrier constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CarrierConstant GetCarrierConstant(gagvr::CarrierConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCarrierConstant(new GetCarrierConstantRequest
            {
                ResourceNameAsCarrierConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested carrier constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the carrier constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CarrierConstant> GetCarrierConstantAsync(gagvr::CarrierConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCarrierConstantAsync(new GetCarrierConstantRequest
            {
                ResourceNameAsCarrierConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested carrier constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the carrier constant to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CarrierConstant> GetCarrierConstantAsync(gagvr::CarrierConstantName resourceName, st::CancellationToken cancellationToken) =>
            GetCarrierConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CarrierConstantService client wrapper implementation, for convenient use.</summary>
    public sealed partial class CarrierConstantServiceClientImpl : CarrierConstantServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCarrierConstantRequest, gagvr::CarrierConstant> _callGetCarrierConstant;

        /// <summary>
        /// Constructs a client wrapper for the CarrierConstantService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CarrierConstantServiceSettings"/> used within this client.
        /// </param>
        public CarrierConstantServiceClientImpl(CarrierConstantService.CarrierConstantServiceClient grpcClient, CarrierConstantServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CarrierConstantServiceSettings effectiveSettings = settings ?? CarrierConstantServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCarrierConstant = clientHelper.BuildApiCall<GetCarrierConstantRequest, gagvr::CarrierConstant>(grpcClient.GetCarrierConstantAsync, grpcClient.GetCarrierConstant, effectiveSettings.GetCarrierConstantSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCarrierConstant);
            Modify_GetCarrierConstantApiCall(ref _callGetCarrierConstant);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCarrierConstantApiCall(ref gaxgrpc::ApiCall<GetCarrierConstantRequest, gagvr::CarrierConstant> call);

        partial void OnConstruction(CarrierConstantService.CarrierConstantServiceClient grpcClient, CarrierConstantServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CarrierConstantService client</summary>
        public override CarrierConstantService.CarrierConstantServiceClient GrpcClient { get; }

        partial void Modify_GetCarrierConstantRequest(ref GetCarrierConstantRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested carrier constant in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::CarrierConstant GetCarrierConstant(GetCarrierConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCarrierConstantRequest(ref request, ref callSettings);
            return _callGetCarrierConstant.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested carrier constant in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CarrierConstant> GetCarrierConstantAsync(GetCarrierConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCarrierConstantRequest(ref request, ref callSettings);
            return _callGetCarrierConstant.Async(request, callSettings);
        }
    }
}

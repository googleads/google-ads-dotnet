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
    /// <summary>Settings for <see cref="AdGroupSimulationServiceClient"/> instances.</summary>
    public sealed partial class AdGroupSimulationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdGroupSimulationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdGroupSimulationServiceSettings"/>.</returns>
        public static AdGroupSimulationServiceSettings GetDefault() => new AdGroupSimulationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AdGroupSimulationServiceSettings"/> object with default settings.
        /// </summary>
        public AdGroupSimulationServiceSettings()
        {
        }

        private AdGroupSimulationServiceSettings(AdGroupSimulationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdGroupSimulationSettings = existing.GetAdGroupSimulationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupSimulationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupSimulationServiceClient.GetAdGroupSimulation</c> and
        /// <c>AdGroupSimulationServiceClient.GetAdGroupSimulationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAdGroupSimulationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdGroupSimulationServiceSettings"/> object.</returns>
        public AdGroupSimulationServiceSettings Clone() => new AdGroupSimulationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdGroupSimulationServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AdGroupSimulationServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdGroupSimulationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdGroupSimulationServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AdGroupSimulationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdGroupSimulationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdGroupSimulationServiceClient Build()
        {
            AdGroupSimulationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdGroupSimulationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdGroupSimulationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdGroupSimulationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdGroupSimulationServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AdGroupSimulationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdGroupSimulationServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AdGroupSimulationServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AdGroupSimulationServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdGroupSimulationServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AdGroupSimulationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch ad group simulations.
    /// </remarks>
    public abstract partial class AdGroupSimulationServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupSimulationService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdGroupSimulationService scopes.</summary>
        /// <remarks>The default AdGroupSimulationService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupSimulationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupSimulationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdGroupSimulationServiceClient"/>.</returns>
        public static stt::Task<AdGroupSimulationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdGroupSimulationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupSimulationServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupSimulationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdGroupSimulationServiceClient"/>.</returns>
        public static AdGroupSimulationServiceClient Create() => new AdGroupSimulationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdGroupSimulationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdGroupSimulationServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupSimulationServiceClient"/>.</returns>
        internal static AdGroupSimulationServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupSimulationServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupSimulationService.AdGroupSimulationServiceClient grpcClient = new AdGroupSimulationService.AdGroupSimulationServiceClient(callInvoker);
            return new AdGroupSimulationServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AdGroupSimulationService client</summary>
        public virtual AdGroupSimulationService.AdGroupSimulationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group simulation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupSimulation GetAdGroupSimulation(GetAdGroupSimulationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group simulation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupSimulation> GetAdGroupSimulationAsync(GetAdGroupSimulationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group simulation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupSimulation> GetAdGroupSimulationAsync(GetAdGroupSimulationRequest request, st::CancellationToken cancellationToken) =>
            GetAdGroupSimulationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group simulation to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupSimulation GetAdGroupSimulation(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupSimulation(new GetAdGroupSimulationRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group simulation to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupSimulation> GetAdGroupSimulationAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupSimulationAsync(new GetAdGroupSimulationRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group simulation to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupSimulation> GetAdGroupSimulationAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupSimulationAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group simulation to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupSimulation GetAdGroupSimulation(gagvr::AdGroupSimulationName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupSimulation(new GetAdGroupSimulationRequest
            {
                ResourceNameAsAdGroupSimulationName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group simulation to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupSimulation> GetAdGroupSimulationAsync(gagvr::AdGroupSimulationName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupSimulationAsync(new GetAdGroupSimulationRequest
            {
                ResourceNameAsAdGroupSimulationName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group simulation to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupSimulation> GetAdGroupSimulationAsync(gagvr::AdGroupSimulationName resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupSimulationAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdGroupSimulationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch ad group simulations.
    /// </remarks>
    public sealed partial class AdGroupSimulationServiceClientImpl : AdGroupSimulationServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdGroupSimulationRequest, gagvr::AdGroupSimulation> _callGetAdGroupSimulation;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupSimulationService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AdGroupSimulationServiceSettings"/> used within this client.
        /// </param>
        public AdGroupSimulationServiceClientImpl(AdGroupSimulationService.AdGroupSimulationServiceClient grpcClient, AdGroupSimulationServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AdGroupSimulationServiceSettings effectiveSettings = settings ?? AdGroupSimulationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAdGroupSimulation = clientHelper.BuildApiCall<GetAdGroupSimulationRequest, gagvr::AdGroupSimulation>(grpcClient.GetAdGroupSimulationAsync, grpcClient.GetAdGroupSimulation, effectiveSettings.GetAdGroupSimulationSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAdGroupSimulation);
            Modify_GetAdGroupSimulationApiCall(ref _callGetAdGroupSimulation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdGroupSimulationApiCall(ref gaxgrpc::ApiCall<GetAdGroupSimulationRequest, gagvr::AdGroupSimulation> call);

        partial void OnConstruction(AdGroupSimulationService.AdGroupSimulationServiceClient grpcClient, AdGroupSimulationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdGroupSimulationService client</summary>
        public override AdGroupSimulationService.AdGroupSimulationServiceClient GrpcClient { get; }

        partial void Modify_GetAdGroupSimulationRequest(ref GetAdGroupSimulationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested ad group simulation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::AdGroupSimulation GetAdGroupSimulation(GetAdGroupSimulationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupSimulationRequest(ref request, ref callSettings);
            return _callGetAdGroupSimulation.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested ad group simulation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::AdGroupSimulation> GetAdGroupSimulationAsync(GetAdGroupSimulationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupSimulationRequest(ref request, ref callSettings);
            return _callGetAdGroupSimulation.Async(request, callSettings);
        }
    }
}

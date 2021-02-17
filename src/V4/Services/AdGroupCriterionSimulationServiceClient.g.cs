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

using gagvr = Google.Ads.GoogleAds.V4.Resources;
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

namespace Google.Ads.GoogleAds.V4.Services
{
    /// <summary>Settings for <see cref="AdGroupCriterionSimulationServiceClient"/> instances.</summary>
    public sealed partial class AdGroupCriterionSimulationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="AdGroupCriterionSimulationServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="AdGroupCriterionSimulationServiceSettings"/>.</returns>
        public static AdGroupCriterionSimulationServiceSettings GetDefault() =>
            new AdGroupCriterionSimulationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AdGroupCriterionSimulationServiceSettings"/> object with default settings.
        /// </summary>
        public AdGroupCriterionSimulationServiceSettings()
        {
        }

        private AdGroupCriterionSimulationServiceSettings(AdGroupCriterionSimulationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdGroupCriterionSimulationSettings = existing.GetAdGroupCriterionSimulationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupCriterionSimulationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupCriterionSimulationServiceClient.GetAdGroupCriterionSimulation</c> and
        /// <c>AdGroupCriterionSimulationServiceClient.GetAdGroupCriterionSimulationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAdGroupCriterionSimulationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdGroupCriterionSimulationServiceSettings"/> object.</returns>
        public AdGroupCriterionSimulationServiceSettings Clone() => new AdGroupCriterionSimulationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdGroupCriterionSimulationServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class AdGroupCriterionSimulationServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdGroupCriterionSimulationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdGroupCriterionSimulationServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AdGroupCriterionSimulationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdGroupCriterionSimulationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdGroupCriterionSimulationServiceClient Build()
        {
            AdGroupCriterionSimulationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdGroupCriterionSimulationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdGroupCriterionSimulationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdGroupCriterionSimulationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdGroupCriterionSimulationServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AdGroupCriterionSimulationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdGroupCriterionSimulationServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AdGroupCriterionSimulationServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            AdGroupCriterionSimulationServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdGroupCriterionSimulationServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AdGroupCriterionSimulationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch ad group criterion simulations.
    /// </remarks>
    public abstract partial class AdGroupCriterionSimulationServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupCriterionSimulationService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdGroupCriterionSimulationService scopes.</summary>
        /// <remarks>
        /// The default AdGroupCriterionSimulationService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupCriterionSimulationServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupCriterionSimulationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdGroupCriterionSimulationServiceClient"/>.</returns>
        public static stt::Task<AdGroupCriterionSimulationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdGroupCriterionSimulationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupCriterionSimulationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupCriterionSimulationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdGroupCriterionSimulationServiceClient"/>.</returns>
        public static AdGroupCriterionSimulationServiceClient Create() =>
            new AdGroupCriterionSimulationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdGroupCriterionSimulationServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdGroupCriterionSimulationServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupCriterionSimulationServiceClient"/>.</returns>
        internal static AdGroupCriterionSimulationServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupCriterionSimulationServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient grpcClient = new AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient(callInvoker);
            return new AdGroupCriterionSimulationServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AdGroupCriterionSimulationService client</summary>
        public virtual AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group criterion simulation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupCriterionSimulation GetAdGroupCriterionSimulation(GetAdGroupCriterionSimulationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group criterion simulation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupCriterionSimulation> GetAdGroupCriterionSimulationAsync(GetAdGroupCriterionSimulationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group criterion simulation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupCriterionSimulation> GetAdGroupCriterionSimulationAsync(GetAdGroupCriterionSimulationRequest request, st::CancellationToken cancellationToken) =>
            GetAdGroupCriterionSimulationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group criterion simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group criterion simulation to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupCriterionSimulation GetAdGroupCriterionSimulation(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupCriterionSimulation(new GetAdGroupCriterionSimulationRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group criterion simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group criterion simulation to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupCriterionSimulation> GetAdGroupCriterionSimulationAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupCriterionSimulationAsync(new GetAdGroupCriterionSimulationRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group criterion simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group criterion simulation to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupCriterionSimulation> GetAdGroupCriterionSimulationAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupCriterionSimulationAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group criterion simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group criterion simulation to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupCriterionSimulation GetAdGroupCriterionSimulation(gagvr::AdGroupCriterionSimulationName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupCriterionSimulation(new GetAdGroupCriterionSimulationRequest
            {
                ResourceNameAsAdGroupCriterionSimulationName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group criterion simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group criterion simulation to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupCriterionSimulation> GetAdGroupCriterionSimulationAsync(gagvr::AdGroupCriterionSimulationName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupCriterionSimulationAsync(new GetAdGroupCriterionSimulationRequest
            {
                ResourceNameAsAdGroupCriterionSimulationName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group criterion simulation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group criterion simulation to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupCriterionSimulation> GetAdGroupCriterionSimulationAsync(gagvr::AdGroupCriterionSimulationName resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupCriterionSimulationAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdGroupCriterionSimulationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch ad group criterion simulations.
    /// </remarks>
    public sealed partial class AdGroupCriterionSimulationServiceClientImpl : AdGroupCriterionSimulationServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdGroupCriterionSimulationRequest, gagvr::AdGroupCriterionSimulation> _callGetAdGroupCriterionSimulation;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupCriterionSimulationService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AdGroupCriterionSimulationServiceSettings"/> used within this client.
        /// </param>
        public AdGroupCriterionSimulationServiceClientImpl(AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient grpcClient, AdGroupCriterionSimulationServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AdGroupCriterionSimulationServiceSettings effectiveSettings = settings ?? AdGroupCriterionSimulationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAdGroupCriterionSimulation = clientHelper.BuildApiCall<GetAdGroupCriterionSimulationRequest, gagvr::AdGroupCriterionSimulation>(grpcClient.GetAdGroupCriterionSimulationAsync, grpcClient.GetAdGroupCriterionSimulation, effectiveSettings.GetAdGroupCriterionSimulationSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAdGroupCriterionSimulation);
            Modify_GetAdGroupCriterionSimulationApiCall(ref _callGetAdGroupCriterionSimulation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdGroupCriterionSimulationApiCall(ref gaxgrpc::ApiCall<GetAdGroupCriterionSimulationRequest, gagvr::AdGroupCriterionSimulation> call);

        partial void OnConstruction(AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient grpcClient, AdGroupCriterionSimulationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdGroupCriterionSimulationService client</summary>
        public override AdGroupCriterionSimulationService.AdGroupCriterionSimulationServiceClient GrpcClient { get; }

        partial void Modify_GetAdGroupCriterionSimulationRequest(ref GetAdGroupCriterionSimulationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested ad group criterion simulation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::AdGroupCriterionSimulation GetAdGroupCriterionSimulation(GetAdGroupCriterionSimulationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupCriterionSimulationRequest(ref request, ref callSettings);
            return _callGetAdGroupCriterionSimulation.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested ad group criterion simulation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::AdGroupCriterionSimulation> GetAdGroupCriterionSimulationAsync(GetAdGroupCriterionSimulationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupCriterionSimulationRequest(ref request, ref callSettings);
            return _callGetAdGroupCriterionSimulation.Async(request, callSettings);
        }
    }
}

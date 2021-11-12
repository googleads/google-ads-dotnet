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

using gagvr = Google.Ads.GoogleAds.V7.Resources;
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

namespace Google.Ads.GoogleAds.V7.Services
{
    /// <summary>Settings for <see cref="CampaignCriterionSimulationServiceClient"/> instances.</summary>
    public sealed partial class CampaignCriterionSimulationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="CampaignCriterionSimulationServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="CampaignCriterionSimulationServiceSettings"/>.</returns>
        public static CampaignCriterionSimulationServiceSettings GetDefault() =>
            new CampaignCriterionSimulationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignCriterionSimulationServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignCriterionSimulationServiceSettings()
        {
        }

        private CampaignCriterionSimulationServiceSettings(CampaignCriterionSimulationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCampaignCriterionSimulationSettings = existing.GetCampaignCriterionSimulationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignCriterionSimulationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignCriterionSimulationServiceClient.GetCampaignCriterionSimulation</c> and
        /// <c>CampaignCriterionSimulationServiceClient.GetCampaignCriterionSimulationAsync</c>.
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
        public gaxgrpc::CallSettings GetCampaignCriterionSimulationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignCriterionSimulationServiceSettings"/> object.</returns>
        public CampaignCriterionSimulationServiceSettings Clone() => new CampaignCriterionSimulationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignCriterionSimulationServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class CampaignCriterionSimulationServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignCriterionSimulationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignCriterionSimulationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CampaignCriterionSimulationServiceClientBuilder()
        {
            UseJwtAccessWithScopes = CampaignCriterionSimulationServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref CampaignCriterionSimulationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignCriterionSimulationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignCriterionSimulationServiceClient Build()
        {
            CampaignCriterionSimulationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignCriterionSimulationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignCriterionSimulationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignCriterionSimulationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignCriterionSimulationServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CampaignCriterionSimulationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignCriterionSimulationServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CampaignCriterionSimulationServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            CampaignCriterionSimulationServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignCriterionSimulationServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CampaignCriterionSimulationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch campaign criterion simulations.
    /// </remarks>
    public abstract partial class CampaignCriterionSimulationServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignCriterionSimulationService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignCriterionSimulationService scopes.</summary>
        /// <remarks>
        /// The default CampaignCriterionSimulationService scopes are:
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
        /// Asynchronously creates a <see cref="CampaignCriterionSimulationServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignCriterionSimulationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignCriterionSimulationServiceClient"/>.</returns>
        public static stt::Task<CampaignCriterionSimulationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignCriterionSimulationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignCriterionSimulationServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignCriterionSimulationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignCriterionSimulationServiceClient"/>.</returns>
        public static CampaignCriterionSimulationServiceClient Create() =>
            new CampaignCriterionSimulationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignCriterionSimulationServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignCriterionSimulationServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignCriterionSimulationServiceClient"/>.</returns>
        internal static CampaignCriterionSimulationServiceClient Create(grpccore::CallInvoker callInvoker, CampaignCriterionSimulationServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient grpcClient = new CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient(callInvoker);
            return new CampaignCriterionSimulationServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CampaignCriterionSimulationService client</summary>
        public virtual CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign criterion simulation in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignCriterionSimulation GetCampaignCriterionSimulation(GetCampaignCriterionSimulationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign criterion simulation in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignCriterionSimulation> GetCampaignCriterionSimulationAsync(GetCampaignCriterionSimulationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign criterion simulation in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignCriterionSimulation> GetCampaignCriterionSimulationAsync(GetCampaignCriterionSimulationRequest request, st::CancellationToken cancellationToken) =>
            GetCampaignCriterionSimulationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign criterion simulation in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign criterion simulation to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignCriterionSimulation GetCampaignCriterionSimulation(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignCriterionSimulation(new GetCampaignCriterionSimulationRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign criterion simulation in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign criterion simulation to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignCriterionSimulation> GetCampaignCriterionSimulationAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignCriterionSimulationAsync(new GetCampaignCriterionSimulationRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign criterion simulation in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign criterion simulation to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignCriterionSimulation> GetCampaignCriterionSimulationAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignCriterionSimulationAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign criterion simulation in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign criterion simulation to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignCriterionSimulation GetCampaignCriterionSimulation(gagvr::CampaignCriterionSimulationName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignCriterionSimulation(new GetCampaignCriterionSimulationRequest
            {
                ResourceNameAsCampaignCriterionSimulationName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign criterion simulation in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign criterion simulation to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignCriterionSimulation> GetCampaignCriterionSimulationAsync(gagvr::CampaignCriterionSimulationName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignCriterionSimulationAsync(new GetCampaignCriterionSimulationRequest
            {
                ResourceNameAsCampaignCriterionSimulationName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign criterion simulation in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign criterion simulation to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignCriterionSimulation> GetCampaignCriterionSimulationAsync(gagvr::CampaignCriterionSimulationName resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignCriterionSimulationAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CampaignCriterionSimulationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch campaign criterion simulations.
    /// </remarks>
    public sealed partial class CampaignCriterionSimulationServiceClientImpl : CampaignCriterionSimulationServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCampaignCriterionSimulationRequest, gagvr::CampaignCriterionSimulation> _callGetCampaignCriterionSimulation;

        /// <summary>
        /// Constructs a client wrapper for the CampaignCriterionSimulationService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CampaignCriterionSimulationServiceSettings"/> used within this client.
        /// </param>
        public CampaignCriterionSimulationServiceClientImpl(CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient grpcClient, CampaignCriterionSimulationServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CampaignCriterionSimulationServiceSettings effectiveSettings = settings ?? CampaignCriterionSimulationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCampaignCriterionSimulation = clientHelper.BuildApiCall<GetCampaignCriterionSimulationRequest, gagvr::CampaignCriterionSimulation>(grpcClient.GetCampaignCriterionSimulationAsync, grpcClient.GetCampaignCriterionSimulation, effectiveSettings.GetCampaignCriterionSimulationSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCampaignCriterionSimulation);
            Modify_GetCampaignCriterionSimulationApiCall(ref _callGetCampaignCriterionSimulation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCampaignCriterionSimulationApiCall(ref gaxgrpc::ApiCall<GetCampaignCriterionSimulationRequest, gagvr::CampaignCriterionSimulation> call);

        partial void OnConstruction(CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient grpcClient, CampaignCriterionSimulationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignCriterionSimulationService client</summary>
        public override CampaignCriterionSimulationService.CampaignCriterionSimulationServiceClient GrpcClient { get; }

        partial void Modify_GetCampaignCriterionSimulationRequest(ref GetCampaignCriterionSimulationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested campaign criterion simulation in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::CampaignCriterionSimulation GetCampaignCriterionSimulation(GetCampaignCriterionSimulationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignCriterionSimulationRequest(ref request, ref callSettings);
            return _callGetCampaignCriterionSimulation.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested campaign criterion simulation in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CampaignCriterionSimulation> GetCampaignCriterionSimulationAsync(GetCampaignCriterionSimulationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignCriterionSimulationRequest(ref request, ref callSettings);
            return _callGetCampaignCriterionSimulation.Async(request, callSettings);
        }
    }
}

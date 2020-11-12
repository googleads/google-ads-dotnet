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
    /// <summary>Settings for <see cref="CombinedAudienceServiceClient"/> instances.</summary>
    public sealed partial class CombinedAudienceServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CombinedAudienceServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CombinedAudienceServiceSettings"/>.</returns>
        public static CombinedAudienceServiceSettings GetDefault() => new CombinedAudienceServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CombinedAudienceServiceSettings"/> object with default settings.
        /// </summary>
        public CombinedAudienceServiceSettings()
        {
        }

        private CombinedAudienceServiceSettings(CombinedAudienceServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCombinedAudienceSettings = existing.GetCombinedAudienceSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CombinedAudienceServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CombinedAudienceServiceClient.GetCombinedAudience</c> and
        /// <c>CombinedAudienceServiceClient.GetCombinedAudienceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCombinedAudienceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CombinedAudienceServiceSettings"/> object.</returns>
        public CombinedAudienceServiceSettings Clone() => new CombinedAudienceServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CombinedAudienceServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CombinedAudienceServiceClientBuilder : gaxgrpc::ClientBuilderBase<CombinedAudienceServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CombinedAudienceServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CombinedAudienceServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CombinedAudienceServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CombinedAudienceServiceClient Build()
        {
            CombinedAudienceServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CombinedAudienceServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CombinedAudienceServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CombinedAudienceServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CombinedAudienceServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CombinedAudienceServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CombinedAudienceServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CombinedAudienceServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CombinedAudienceServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CombinedAudienceServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CombinedAudienceService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage combined audiences. This service can be used to list all
    /// your combined audiences with metadata, but won't show the structure and
    /// components of the combined audience.
    /// </remarks>
    public abstract partial class CombinedAudienceServiceClient
    {
        /// <summary>
        /// The default endpoint for the CombinedAudienceService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CombinedAudienceService scopes.</summary>
        /// <remarks>The default CombinedAudienceService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CombinedAudienceServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CombinedAudienceServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CombinedAudienceServiceClient"/>.</returns>
        public static stt::Task<CombinedAudienceServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CombinedAudienceServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CombinedAudienceServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CombinedAudienceServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CombinedAudienceServiceClient"/>.</returns>
        public static CombinedAudienceServiceClient Create() => new CombinedAudienceServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CombinedAudienceServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CombinedAudienceServiceSettings"/>.</param>
        /// <returns>The created <see cref="CombinedAudienceServiceClient"/>.</returns>
        internal static CombinedAudienceServiceClient Create(grpccore::CallInvoker callInvoker, CombinedAudienceServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CombinedAudienceService.CombinedAudienceServiceClient grpcClient = new CombinedAudienceService.CombinedAudienceServiceClient(callInvoker);
            return new CombinedAudienceServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CombinedAudienceService client</summary>
        public virtual CombinedAudienceService.CombinedAudienceServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested combined audience in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CombinedAudience GetCombinedAudience(GetCombinedAudienceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested combined audience in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CombinedAudience> GetCombinedAudienceAsync(GetCombinedAudienceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested combined audience in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CombinedAudience> GetCombinedAudienceAsync(GetCombinedAudienceRequest request, st::CancellationToken cancellationToken) =>
            GetCombinedAudienceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested combined audience in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the combined audience to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CombinedAudience GetCombinedAudience(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCombinedAudience(new GetCombinedAudienceRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested combined audience in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the combined audience to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CombinedAudience> GetCombinedAudienceAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCombinedAudienceAsync(new GetCombinedAudienceRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested combined audience in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the combined audience to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CombinedAudience> GetCombinedAudienceAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCombinedAudienceAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested combined audience in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the combined audience to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CombinedAudience GetCombinedAudience(gagvr::CombinedAudienceName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCombinedAudience(new GetCombinedAudienceRequest
            {
                ResourceNameAsCombinedAudienceName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested combined audience in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the combined audience to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CombinedAudience> GetCombinedAudienceAsync(gagvr::CombinedAudienceName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCombinedAudienceAsync(new GetCombinedAudienceRequest
            {
                ResourceNameAsCombinedAudienceName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested combined audience in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the combined audience to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CombinedAudience> GetCombinedAudienceAsync(gagvr::CombinedAudienceName resourceName, st::CancellationToken cancellationToken) =>
            GetCombinedAudienceAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CombinedAudienceService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage combined audiences. This service can be used to list all
    /// your combined audiences with metadata, but won't show the structure and
    /// components of the combined audience.
    /// </remarks>
    public sealed partial class CombinedAudienceServiceClientImpl : CombinedAudienceServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCombinedAudienceRequest, gagvr::CombinedAudience> _callGetCombinedAudience;

        /// <summary>
        /// Constructs a client wrapper for the CombinedAudienceService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CombinedAudienceServiceSettings"/> used within this client.
        /// </param>
        public CombinedAudienceServiceClientImpl(CombinedAudienceService.CombinedAudienceServiceClient grpcClient, CombinedAudienceServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CombinedAudienceServiceSettings effectiveSettings = settings ?? CombinedAudienceServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCombinedAudience = clientHelper.BuildApiCall<GetCombinedAudienceRequest, gagvr::CombinedAudience>(grpcClient.GetCombinedAudienceAsync, grpcClient.GetCombinedAudience, effectiveSettings.GetCombinedAudienceSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCombinedAudience);
            Modify_GetCombinedAudienceApiCall(ref _callGetCombinedAudience);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCombinedAudienceApiCall(ref gaxgrpc::ApiCall<GetCombinedAudienceRequest, gagvr::CombinedAudience> call);

        partial void OnConstruction(CombinedAudienceService.CombinedAudienceServiceClient grpcClient, CombinedAudienceServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CombinedAudienceService client</summary>
        public override CombinedAudienceService.CombinedAudienceServiceClient GrpcClient { get; }

        partial void Modify_GetCombinedAudienceRequest(ref GetCombinedAudienceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested combined audience in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::CombinedAudience GetCombinedAudience(GetCombinedAudienceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCombinedAudienceRequest(ref request, ref callSettings);
            return _callGetCombinedAudience.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested combined audience in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CombinedAudience> GetCombinedAudienceAsync(GetCombinedAudienceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCombinedAudienceRequest(ref request, ref callSettings);
            return _callGetCombinedAudience.Async(request, callSettings);
        }
    }
}

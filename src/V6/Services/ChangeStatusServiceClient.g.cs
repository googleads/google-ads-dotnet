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
    /// <summary>Settings for <see cref="ChangeStatusServiceClient"/> instances.</summary>
    public sealed partial class ChangeStatusServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ChangeStatusServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ChangeStatusServiceSettings"/>.</returns>
        public static ChangeStatusServiceSettings GetDefault() => new ChangeStatusServiceSettings();

        /// <summary>Constructs a new <see cref="ChangeStatusServiceSettings"/> object with default settings.</summary>
        public ChangeStatusServiceSettings()
        {
        }

        private ChangeStatusServiceSettings(ChangeStatusServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetChangeStatusSettings = existing.GetChangeStatusSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ChangeStatusServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ChangeStatusServiceClient.GetChangeStatus</c> and <c>ChangeStatusServiceClient.GetChangeStatusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetChangeStatusSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ChangeStatusServiceSettings"/> object.</returns>
        public ChangeStatusServiceSettings Clone() => new ChangeStatusServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ChangeStatusServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ChangeStatusServiceClientBuilder : gaxgrpc::ClientBuilderBase<ChangeStatusServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ChangeStatusServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref ChangeStatusServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ChangeStatusServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ChangeStatusServiceClient Build()
        {
            ChangeStatusServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ChangeStatusServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ChangeStatusServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ChangeStatusServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ChangeStatusServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ChangeStatusServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ChangeStatusServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ChangeStatusServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ChangeStatusServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ChangeStatusServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ChangeStatusService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch change statuses.
    /// </remarks>
    public abstract partial class ChangeStatusServiceClient
    {
        /// <summary>
        /// The default endpoint for the ChangeStatusService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ChangeStatusService scopes.</summary>
        /// <remarks>The default ChangeStatusService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ChangeStatusServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ChangeStatusServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ChangeStatusServiceClient"/>.</returns>
        public static stt::Task<ChangeStatusServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ChangeStatusServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ChangeStatusServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ChangeStatusServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ChangeStatusServiceClient"/>.</returns>
        public static ChangeStatusServiceClient Create() => new ChangeStatusServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ChangeStatusServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ChangeStatusServiceSettings"/>.</param>
        /// <returns>The created <see cref="ChangeStatusServiceClient"/>.</returns>
        internal static ChangeStatusServiceClient Create(grpccore::CallInvoker callInvoker, ChangeStatusServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ChangeStatusService.ChangeStatusServiceClient grpcClient = new ChangeStatusService.ChangeStatusServiceClient(callInvoker);
            return new ChangeStatusServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ChangeStatusService client</summary>
        public virtual ChangeStatusService.ChangeStatusServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested change status in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ChangeStatus GetChangeStatus(GetChangeStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested change status in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ChangeStatus> GetChangeStatusAsync(GetChangeStatusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested change status in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ChangeStatus> GetChangeStatusAsync(GetChangeStatusRequest request, st::CancellationToken cancellationToken) =>
            GetChangeStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested change status in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the change status to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ChangeStatus GetChangeStatus(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetChangeStatus(new GetChangeStatusRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested change status in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the change status to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ChangeStatus> GetChangeStatusAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetChangeStatusAsync(new GetChangeStatusRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested change status in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the change status to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ChangeStatus> GetChangeStatusAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetChangeStatusAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested change status in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the change status to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ChangeStatus GetChangeStatus(gagvr::ChangeStatusName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetChangeStatus(new GetChangeStatusRequest
            {
                ResourceNameAsChangeStatusName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested change status in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the change status to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ChangeStatus> GetChangeStatusAsync(gagvr::ChangeStatusName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetChangeStatusAsync(new GetChangeStatusRequest
            {
                ResourceNameAsChangeStatusName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested change status in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the change status to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ChangeStatus> GetChangeStatusAsync(gagvr::ChangeStatusName resourceName, st::CancellationToken cancellationToken) =>
            GetChangeStatusAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ChangeStatusService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch change statuses.
    /// </remarks>
    public sealed partial class ChangeStatusServiceClientImpl : ChangeStatusServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetChangeStatusRequest, gagvr::ChangeStatus> _callGetChangeStatus;

        /// <summary>
        /// Constructs a client wrapper for the ChangeStatusService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ChangeStatusServiceSettings"/> used within this client.</param>
        public ChangeStatusServiceClientImpl(ChangeStatusService.ChangeStatusServiceClient grpcClient, ChangeStatusServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ChangeStatusServiceSettings effectiveSettings = settings ?? ChangeStatusServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetChangeStatus = clientHelper.BuildApiCall<GetChangeStatusRequest, gagvr::ChangeStatus>(grpcClient.GetChangeStatusAsync, grpcClient.GetChangeStatus, effectiveSettings.GetChangeStatusSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetChangeStatus);
            Modify_GetChangeStatusApiCall(ref _callGetChangeStatus);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetChangeStatusApiCall(ref gaxgrpc::ApiCall<GetChangeStatusRequest, gagvr::ChangeStatus> call);

        partial void OnConstruction(ChangeStatusService.ChangeStatusServiceClient grpcClient, ChangeStatusServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ChangeStatusService client</summary>
        public override ChangeStatusService.ChangeStatusServiceClient GrpcClient { get; }

        partial void Modify_GetChangeStatusRequest(ref GetChangeStatusRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested change status in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::ChangeStatus GetChangeStatus(GetChangeStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChangeStatusRequest(ref request, ref callSettings);
            return _callGetChangeStatus.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested change status in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::ChangeStatus> GetChangeStatusAsync(GetChangeStatusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChangeStatusRequest(ref request, ref callSettings);
            return _callGetChangeStatus.Async(request, callSettings);
        }
    }
}

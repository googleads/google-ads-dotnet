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
    /// <summary>Settings for <see cref="PaidOrganicSearchTermViewServiceClient"/> instances.</summary>
    public sealed partial class PaidOrganicSearchTermViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PaidOrganicSearchTermViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PaidOrganicSearchTermViewServiceSettings"/>.</returns>
        public static PaidOrganicSearchTermViewServiceSettings GetDefault() => new PaidOrganicSearchTermViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="PaidOrganicSearchTermViewServiceSettings"/> object with default settings.
        /// </summary>
        public PaidOrganicSearchTermViewServiceSettings()
        {
        }

        private PaidOrganicSearchTermViewServiceSettings(PaidOrganicSearchTermViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetPaidOrganicSearchTermViewSettings = existing.GetPaidOrganicSearchTermViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PaidOrganicSearchTermViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PaidOrganicSearchTermViewServiceClient.GetPaidOrganicSearchTermView</c> and
        /// <c>PaidOrganicSearchTermViewServiceClient.GetPaidOrganicSearchTermViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPaidOrganicSearchTermViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PaidOrganicSearchTermViewServiceSettings"/> object.</returns>
        public PaidOrganicSearchTermViewServiceSettings Clone() => new PaidOrganicSearchTermViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PaidOrganicSearchTermViewServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class PaidOrganicSearchTermViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<PaidOrganicSearchTermViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PaidOrganicSearchTermViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref PaidOrganicSearchTermViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PaidOrganicSearchTermViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PaidOrganicSearchTermViewServiceClient Build()
        {
            PaidOrganicSearchTermViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PaidOrganicSearchTermViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PaidOrganicSearchTermViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PaidOrganicSearchTermViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PaidOrganicSearchTermViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<PaidOrganicSearchTermViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PaidOrganicSearchTermViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => PaidOrganicSearchTermViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            PaidOrganicSearchTermViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PaidOrganicSearchTermViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>PaidOrganicSearchTermViewService client wrapper, for convenient use.</summary>
    public abstract partial class PaidOrganicSearchTermViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the PaidOrganicSearchTermViewService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default PaidOrganicSearchTermViewService scopes.</summary>
        /// <remarks>The default PaidOrganicSearchTermViewService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="PaidOrganicSearchTermViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PaidOrganicSearchTermViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PaidOrganicSearchTermViewServiceClient"/>.</returns>
        public static stt::Task<PaidOrganicSearchTermViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PaidOrganicSearchTermViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PaidOrganicSearchTermViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="PaidOrganicSearchTermViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PaidOrganicSearchTermViewServiceClient"/>.</returns>
        public static PaidOrganicSearchTermViewServiceClient Create() =>
            new PaidOrganicSearchTermViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PaidOrganicSearchTermViewServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PaidOrganicSearchTermViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="PaidOrganicSearchTermViewServiceClient"/>.</returns>
        internal static PaidOrganicSearchTermViewServiceClient Create(grpccore::CallInvoker callInvoker, PaidOrganicSearchTermViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient grpcClient = new PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient(callInvoker);
            return new PaidOrganicSearchTermViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC PaidOrganicSearchTermViewService client</summary>
        public virtual PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::PaidOrganicSearchTermView GetPaidOrganicSearchTermView(GetPaidOrganicSearchTermViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::PaidOrganicSearchTermView> GetPaidOrganicSearchTermViewAsync(GetPaidOrganicSearchTermViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::PaidOrganicSearchTermView> GetPaidOrganicSearchTermViewAsync(GetPaidOrganicSearchTermViewRequest request, st::CancellationToken cancellationToken) =>
            GetPaidOrganicSearchTermViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the paid organic search term view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::PaidOrganicSearchTermView GetPaidOrganicSearchTermView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetPaidOrganicSearchTermView(new GetPaidOrganicSearchTermViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the paid organic search term view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::PaidOrganicSearchTermView> GetPaidOrganicSearchTermViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetPaidOrganicSearchTermViewAsync(new GetPaidOrganicSearchTermViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the paid organic search term view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::PaidOrganicSearchTermView> GetPaidOrganicSearchTermViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetPaidOrganicSearchTermViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the paid organic search term view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::PaidOrganicSearchTermView GetPaidOrganicSearchTermView(gagvr::PaidOrganicSearchTermViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetPaidOrganicSearchTermView(new GetPaidOrganicSearchTermViewRequest
            {
                ResourceNameAsPaidOrganicSearchTermViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the paid organic search term view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::PaidOrganicSearchTermView> GetPaidOrganicSearchTermViewAsync(gagvr::PaidOrganicSearchTermViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetPaidOrganicSearchTermViewAsync(new GetPaidOrganicSearchTermViewRequest
            {
                ResourceNameAsPaidOrganicSearchTermViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the paid organic search term view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::PaidOrganicSearchTermView> GetPaidOrganicSearchTermViewAsync(gagvr::PaidOrganicSearchTermViewName resourceName, st::CancellationToken cancellationToken) =>
            GetPaidOrganicSearchTermViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PaidOrganicSearchTermViewService client wrapper implementation, for convenient use.</summary>
    public sealed partial class PaidOrganicSearchTermViewServiceClientImpl : PaidOrganicSearchTermViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetPaidOrganicSearchTermViewRequest, gagvr::PaidOrganicSearchTermView> _callGetPaidOrganicSearchTermView;

        /// <summary>
        /// Constructs a client wrapper for the PaidOrganicSearchTermViewService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="PaidOrganicSearchTermViewServiceSettings"/> used within this client.
        /// </param>
        public PaidOrganicSearchTermViewServiceClientImpl(PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient grpcClient, PaidOrganicSearchTermViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            PaidOrganicSearchTermViewServiceSettings effectiveSettings = settings ?? PaidOrganicSearchTermViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetPaidOrganicSearchTermView = clientHelper.BuildApiCall<GetPaidOrganicSearchTermViewRequest, gagvr::PaidOrganicSearchTermView>(grpcClient.GetPaidOrganicSearchTermViewAsync, grpcClient.GetPaidOrganicSearchTermView, effectiveSettings.GetPaidOrganicSearchTermViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetPaidOrganicSearchTermView);
            Modify_GetPaidOrganicSearchTermViewApiCall(ref _callGetPaidOrganicSearchTermView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetPaidOrganicSearchTermViewApiCall(ref gaxgrpc::ApiCall<GetPaidOrganicSearchTermViewRequest, gagvr::PaidOrganicSearchTermView> call);

        partial void OnConstruction(PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient grpcClient, PaidOrganicSearchTermViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PaidOrganicSearchTermViewService client</summary>
        public override PaidOrganicSearchTermViewService.PaidOrganicSearchTermViewServiceClient GrpcClient { get; }

        partial void Modify_GetPaidOrganicSearchTermViewRequest(ref GetPaidOrganicSearchTermViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::PaidOrganicSearchTermView GetPaidOrganicSearchTermView(GetPaidOrganicSearchTermViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPaidOrganicSearchTermViewRequest(ref request, ref callSettings);
            return _callGetPaidOrganicSearchTermView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested paid organic search term view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::PaidOrganicSearchTermView> GetPaidOrganicSearchTermViewAsync(GetPaidOrganicSearchTermViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPaidOrganicSearchTermViewRequest(ref request, ref callSettings);
            return _callGetPaidOrganicSearchTermView.Async(request, callSettings);
        }
    }
}

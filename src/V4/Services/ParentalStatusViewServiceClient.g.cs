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
    /// <summary>Settings for <see cref="ParentalStatusViewServiceClient"/> instances.</summary>
    public sealed partial class ParentalStatusViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ParentalStatusViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ParentalStatusViewServiceSettings"/>.</returns>
        public static ParentalStatusViewServiceSettings GetDefault() => new ParentalStatusViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ParentalStatusViewServiceSettings"/> object with default settings.
        /// </summary>
        public ParentalStatusViewServiceSettings()
        {
        }

        private ParentalStatusViewServiceSettings(ParentalStatusViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetParentalStatusViewSettings = existing.GetParentalStatusViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ParentalStatusViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ParentalStatusViewServiceClient.GetParentalStatusView</c> and
        /// <c>ParentalStatusViewServiceClient.GetParentalStatusViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetParentalStatusViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ParentalStatusViewServiceSettings"/> object.</returns>
        public ParentalStatusViewServiceSettings Clone() => new ParentalStatusViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ParentalStatusViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class ParentalStatusViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<ParentalStatusViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ParentalStatusViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref ParentalStatusViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ParentalStatusViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ParentalStatusViewServiceClient Build()
        {
            ParentalStatusViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ParentalStatusViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ParentalStatusViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ParentalStatusViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ParentalStatusViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ParentalStatusViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ParentalStatusViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ParentalStatusViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ParentalStatusViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ParentalStatusViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ParentalStatusViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage parental status views.
    /// </remarks>
    public abstract partial class ParentalStatusViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the ParentalStatusViewService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ParentalStatusViewService scopes.</summary>
        /// <remarks>
        /// The default ParentalStatusViewService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ParentalStatusViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ParentalStatusViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ParentalStatusViewServiceClient"/>.</returns>
        public static stt::Task<ParentalStatusViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ParentalStatusViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ParentalStatusViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ParentalStatusViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ParentalStatusViewServiceClient"/>.</returns>
        public static ParentalStatusViewServiceClient Create() => new ParentalStatusViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ParentalStatusViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ParentalStatusViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="ParentalStatusViewServiceClient"/>.</returns>
        internal static ParentalStatusViewServiceClient Create(grpccore::CallInvoker callInvoker, ParentalStatusViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ParentalStatusViewService.ParentalStatusViewServiceClient grpcClient = new ParentalStatusViewService.ParentalStatusViewServiceClient(callInvoker);
            return new ParentalStatusViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ParentalStatusViewService client</summary>
        public virtual ParentalStatusViewService.ParentalStatusViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested parental status view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ParentalStatusView GetParentalStatusView(GetParentalStatusViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested parental status view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ParentalStatusView> GetParentalStatusViewAsync(GetParentalStatusViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested parental status view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ParentalStatusView> GetParentalStatusViewAsync(GetParentalStatusViewRequest request, st::CancellationToken cancellationToken) =>
            GetParentalStatusViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested parental status view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the parental status view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ParentalStatusView GetParentalStatusView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetParentalStatusView(new GetParentalStatusViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested parental status view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the parental status view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ParentalStatusView> GetParentalStatusViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetParentalStatusViewAsync(new GetParentalStatusViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested parental status view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the parental status view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ParentalStatusView> GetParentalStatusViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetParentalStatusViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested parental status view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the parental status view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ParentalStatusView GetParentalStatusView(gagvr::ParentalStatusViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetParentalStatusView(new GetParentalStatusViewRequest
            {
                ResourceNameAsParentalStatusViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested parental status view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the parental status view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ParentalStatusView> GetParentalStatusViewAsync(gagvr::ParentalStatusViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetParentalStatusViewAsync(new GetParentalStatusViewRequest
            {
                ResourceNameAsParentalStatusViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested parental status view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the parental status view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ParentalStatusView> GetParentalStatusViewAsync(gagvr::ParentalStatusViewName resourceName, st::CancellationToken cancellationToken) =>
            GetParentalStatusViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ParentalStatusViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage parental status views.
    /// </remarks>
    public sealed partial class ParentalStatusViewServiceClientImpl : ParentalStatusViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetParentalStatusViewRequest, gagvr::ParentalStatusView> _callGetParentalStatusView;

        /// <summary>
        /// Constructs a client wrapper for the ParentalStatusViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ParentalStatusViewServiceSettings"/> used within this client.
        /// </param>
        public ParentalStatusViewServiceClientImpl(ParentalStatusViewService.ParentalStatusViewServiceClient grpcClient, ParentalStatusViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ParentalStatusViewServiceSettings effectiveSettings = settings ?? ParentalStatusViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetParentalStatusView = clientHelper.BuildApiCall<GetParentalStatusViewRequest, gagvr::ParentalStatusView>(grpcClient.GetParentalStatusViewAsync, grpcClient.GetParentalStatusView, effectiveSettings.GetParentalStatusViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetParentalStatusView);
            Modify_GetParentalStatusViewApiCall(ref _callGetParentalStatusView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetParentalStatusViewApiCall(ref gaxgrpc::ApiCall<GetParentalStatusViewRequest, gagvr::ParentalStatusView> call);

        partial void OnConstruction(ParentalStatusViewService.ParentalStatusViewServiceClient grpcClient, ParentalStatusViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ParentalStatusViewService client</summary>
        public override ParentalStatusViewService.ParentalStatusViewServiceClient GrpcClient { get; }

        partial void Modify_GetParentalStatusViewRequest(ref GetParentalStatusViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested parental status view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::ParentalStatusView GetParentalStatusView(GetParentalStatusViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetParentalStatusViewRequest(ref request, ref callSettings);
            return _callGetParentalStatusView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested parental status view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::ParentalStatusView> GetParentalStatusViewAsync(GetParentalStatusViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetParentalStatusViewRequest(ref request, ref callSettings);
            return _callGetParentalStatusView.Async(request, callSettings);
        }
    }
}

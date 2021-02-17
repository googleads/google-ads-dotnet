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
    /// <summary>Settings for <see cref="AgeRangeViewServiceClient"/> instances.</summary>
    public sealed partial class AgeRangeViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AgeRangeViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AgeRangeViewServiceSettings"/>.</returns>
        public static AgeRangeViewServiceSettings GetDefault() => new AgeRangeViewServiceSettings();

        /// <summary>Constructs a new <see cref="AgeRangeViewServiceSettings"/> object with default settings.</summary>
        public AgeRangeViewServiceSettings()
        {
        }

        private AgeRangeViewServiceSettings(AgeRangeViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAgeRangeViewSettings = existing.GetAgeRangeViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AgeRangeViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgeRangeViewServiceClient.GetAgeRangeView</c> and <c>AgeRangeViewServiceClient.GetAgeRangeViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAgeRangeViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AgeRangeViewServiceSettings"/> object.</returns>
        public AgeRangeViewServiceSettings Clone() => new AgeRangeViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AgeRangeViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class AgeRangeViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<AgeRangeViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AgeRangeViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AgeRangeViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AgeRangeViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AgeRangeViewServiceClient Build()
        {
            AgeRangeViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AgeRangeViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AgeRangeViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AgeRangeViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AgeRangeViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AgeRangeViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AgeRangeViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AgeRangeViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AgeRangeViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AgeRangeViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AgeRangeViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage age range views.
    /// </remarks>
    public abstract partial class AgeRangeViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the AgeRangeViewService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AgeRangeViewService scopes.</summary>
        /// <remarks>
        /// The default AgeRangeViewService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AgeRangeViewServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AgeRangeViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AgeRangeViewServiceClient"/>.</returns>
        public static stt::Task<AgeRangeViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AgeRangeViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AgeRangeViewServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AgeRangeViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AgeRangeViewServiceClient"/>.</returns>
        public static AgeRangeViewServiceClient Create() => new AgeRangeViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AgeRangeViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AgeRangeViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="AgeRangeViewServiceClient"/>.</returns>
        internal static AgeRangeViewServiceClient Create(grpccore::CallInvoker callInvoker, AgeRangeViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AgeRangeViewService.AgeRangeViewServiceClient grpcClient = new AgeRangeViewService.AgeRangeViewServiceClient(callInvoker);
            return new AgeRangeViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AgeRangeViewService client</summary>
        public virtual AgeRangeViewService.AgeRangeViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested age range view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AgeRangeView GetAgeRangeView(GetAgeRangeViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested age range view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AgeRangeView> GetAgeRangeViewAsync(GetAgeRangeViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested age range view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AgeRangeView> GetAgeRangeViewAsync(GetAgeRangeViewRequest request, st::CancellationToken cancellationToken) =>
            GetAgeRangeViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested age range view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the age range view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AgeRangeView GetAgeRangeView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAgeRangeView(new GetAgeRangeViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested age range view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the age range view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AgeRangeView> GetAgeRangeViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAgeRangeViewAsync(new GetAgeRangeViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested age range view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the age range view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AgeRangeView> GetAgeRangeViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAgeRangeViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested age range view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the age range view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AgeRangeView GetAgeRangeView(gagvr::AgeRangeViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAgeRangeView(new GetAgeRangeViewRequest
            {
                ResourceNameAsAgeRangeViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested age range view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the age range view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AgeRangeView> GetAgeRangeViewAsync(gagvr::AgeRangeViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAgeRangeViewAsync(new GetAgeRangeViewRequest
            {
                ResourceNameAsAgeRangeViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested age range view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the age range view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AgeRangeView> GetAgeRangeViewAsync(gagvr::AgeRangeViewName resourceName, st::CancellationToken cancellationToken) =>
            GetAgeRangeViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AgeRangeViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage age range views.
    /// </remarks>
    public sealed partial class AgeRangeViewServiceClientImpl : AgeRangeViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAgeRangeViewRequest, gagvr::AgeRangeView> _callGetAgeRangeView;

        /// <summary>
        /// Constructs a client wrapper for the AgeRangeViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AgeRangeViewServiceSettings"/> used within this client.</param>
        public AgeRangeViewServiceClientImpl(AgeRangeViewService.AgeRangeViewServiceClient grpcClient, AgeRangeViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AgeRangeViewServiceSettings effectiveSettings = settings ?? AgeRangeViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAgeRangeView = clientHelper.BuildApiCall<GetAgeRangeViewRequest, gagvr::AgeRangeView>(grpcClient.GetAgeRangeViewAsync, grpcClient.GetAgeRangeView, effectiveSettings.GetAgeRangeViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAgeRangeView);
            Modify_GetAgeRangeViewApiCall(ref _callGetAgeRangeView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAgeRangeViewApiCall(ref gaxgrpc::ApiCall<GetAgeRangeViewRequest, gagvr::AgeRangeView> call);

        partial void OnConstruction(AgeRangeViewService.AgeRangeViewServiceClient grpcClient, AgeRangeViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AgeRangeViewService client</summary>
        public override AgeRangeViewService.AgeRangeViewServiceClient GrpcClient { get; }

        partial void Modify_GetAgeRangeViewRequest(ref GetAgeRangeViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested age range view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::AgeRangeView GetAgeRangeView(GetAgeRangeViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgeRangeViewRequest(ref request, ref callSettings);
            return _callGetAgeRangeView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested age range view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::AgeRangeView> GetAgeRangeViewAsync(GetAgeRangeViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgeRangeViewRequest(ref request, ref callSettings);
            return _callGetAgeRangeView.Async(request, callSettings);
        }
    }
}

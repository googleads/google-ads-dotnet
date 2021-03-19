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

using gagvr = Google.Ads.GoogleAds.V5.Resources;
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

namespace Google.Ads.GoogleAds.V5.Services
{
    /// <summary>Settings for <see cref="LanguageConstantServiceClient"/> instances.</summary>
    public sealed partial class LanguageConstantServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LanguageConstantServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LanguageConstantServiceSettings"/>.</returns>
        public static LanguageConstantServiceSettings GetDefault() => new LanguageConstantServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="LanguageConstantServiceSettings"/> object with default settings.
        /// </summary>
        public LanguageConstantServiceSettings()
        {
        }

        private LanguageConstantServiceSettings(LanguageConstantServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetLanguageConstantSettings = existing.GetLanguageConstantSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LanguageConstantServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LanguageConstantServiceClient.GetLanguageConstant</c> and
        /// <c>LanguageConstantServiceClient.GetLanguageConstantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLanguageConstantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LanguageConstantServiceSettings"/> object.</returns>
        public LanguageConstantServiceSettings Clone() => new LanguageConstantServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LanguageConstantServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class LanguageConstantServiceClientBuilder : gaxgrpc::ClientBuilderBase<LanguageConstantServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LanguageConstantServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref LanguageConstantServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LanguageConstantServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LanguageConstantServiceClient Build()
        {
            LanguageConstantServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LanguageConstantServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LanguageConstantServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LanguageConstantServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LanguageConstantServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<LanguageConstantServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LanguageConstantServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => LanguageConstantServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => LanguageConstantServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LanguageConstantServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>LanguageConstantService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch language constants.
    /// </remarks>
    public abstract partial class LanguageConstantServiceClient
    {
        /// <summary>
        /// The default endpoint for the LanguageConstantService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default LanguageConstantService scopes.</summary>
        /// <remarks>
        /// The default LanguageConstantService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="LanguageConstantServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="LanguageConstantServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LanguageConstantServiceClient"/>.</returns>
        public static stt::Task<LanguageConstantServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LanguageConstantServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LanguageConstantServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="LanguageConstantServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LanguageConstantServiceClient"/>.</returns>
        public static LanguageConstantServiceClient Create() => new LanguageConstantServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LanguageConstantServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LanguageConstantServiceSettings"/>.</param>
        /// <returns>The created <see cref="LanguageConstantServiceClient"/>.</returns>
        internal static LanguageConstantServiceClient Create(grpccore::CallInvoker callInvoker, LanguageConstantServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LanguageConstantService.LanguageConstantServiceClient grpcClient = new LanguageConstantService.LanguageConstantServiceClient(callInvoker);
            return new LanguageConstantServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC LanguageConstantService client</summary>
        public virtual LanguageConstantService.LanguageConstantServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested language constant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::LanguageConstant GetLanguageConstant(GetLanguageConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested language constant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LanguageConstant> GetLanguageConstantAsync(GetLanguageConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested language constant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LanguageConstant> GetLanguageConstantAsync(GetLanguageConstantRequest request, st::CancellationToken cancellationToken) =>
            GetLanguageConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested language constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the language constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::LanguageConstant GetLanguageConstant(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLanguageConstant(new GetLanguageConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested language constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the language constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LanguageConstant> GetLanguageConstantAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLanguageConstantAsync(new GetLanguageConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested language constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the language constant to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LanguageConstant> GetLanguageConstantAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetLanguageConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested language constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the language constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::LanguageConstant GetLanguageConstant(gagvr::LanguageConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLanguageConstant(new GetLanguageConstantRequest
            {
                ResourceNameAsLanguageConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested language constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the language constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LanguageConstant> GetLanguageConstantAsync(gagvr::LanguageConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLanguageConstantAsync(new GetLanguageConstantRequest
            {
                ResourceNameAsLanguageConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested language constant.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the language constant to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LanguageConstant> GetLanguageConstantAsync(gagvr::LanguageConstantName resourceName, st::CancellationToken cancellationToken) =>
            GetLanguageConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LanguageConstantService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch language constants.
    /// </remarks>
    public sealed partial class LanguageConstantServiceClientImpl : LanguageConstantServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetLanguageConstantRequest, gagvr::LanguageConstant> _callGetLanguageConstant;

        /// <summary>
        /// Constructs a client wrapper for the LanguageConstantService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="LanguageConstantServiceSettings"/> used within this client.
        /// </param>
        public LanguageConstantServiceClientImpl(LanguageConstantService.LanguageConstantServiceClient grpcClient, LanguageConstantServiceSettings settings)
        {
            GrpcClient = grpcClient;
            LanguageConstantServiceSettings effectiveSettings = settings ?? LanguageConstantServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetLanguageConstant = clientHelper.BuildApiCall<GetLanguageConstantRequest, gagvr::LanguageConstant>(grpcClient.GetLanguageConstantAsync, grpcClient.GetLanguageConstant, effectiveSettings.GetLanguageConstantSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetLanguageConstant);
            Modify_GetLanguageConstantApiCall(ref _callGetLanguageConstant);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetLanguageConstantApiCall(ref gaxgrpc::ApiCall<GetLanguageConstantRequest, gagvr::LanguageConstant> call);

        partial void OnConstruction(LanguageConstantService.LanguageConstantServiceClient grpcClient, LanguageConstantServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LanguageConstantService client</summary>
        public override LanguageConstantService.LanguageConstantServiceClient GrpcClient { get; }

        partial void Modify_GetLanguageConstantRequest(ref GetLanguageConstantRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested language constant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::LanguageConstant GetLanguageConstant(GetLanguageConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLanguageConstantRequest(ref request, ref callSettings);
            return _callGetLanguageConstant.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested language constant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::LanguageConstant> GetLanguageConstantAsync(GetLanguageConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLanguageConstantRequest(ref request, ref callSettings);
            return _callGetLanguageConstant.Async(request, callSettings);
        }
    }
}

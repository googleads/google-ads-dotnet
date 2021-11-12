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
    /// <summary>Settings for <see cref="GeoTargetConstantServiceClient"/> instances.</summary>
    public sealed partial class GeoTargetConstantServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GeoTargetConstantServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GeoTargetConstantServiceSettings"/>.</returns>
        public static GeoTargetConstantServiceSettings GetDefault() => new GeoTargetConstantServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="GeoTargetConstantServiceSettings"/> object with default settings.
        /// </summary>
        public GeoTargetConstantServiceSettings()
        {
        }

        private GeoTargetConstantServiceSettings(GeoTargetConstantServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetGeoTargetConstantSettings = existing.GetGeoTargetConstantSettings;
            SuggestGeoTargetConstantsSettings = existing.SuggestGeoTargetConstantsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GeoTargetConstantServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GeoTargetConstantServiceClient.GetGeoTargetConstant</c> and
        /// <c>GeoTargetConstantServiceClient.GetGeoTargetConstantAsync</c>.
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
        public gaxgrpc::CallSettings GetGeoTargetConstantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GeoTargetConstantServiceClient.SuggestGeoTargetConstants</c> and
        /// <c>GeoTargetConstantServiceClient.SuggestGeoTargetConstantsAsync</c>.
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
        public gaxgrpc::CallSettings SuggestGeoTargetConstantsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GeoTargetConstantServiceSettings"/> object.</returns>
        public GeoTargetConstantServiceSettings Clone() => new GeoTargetConstantServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GeoTargetConstantServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class GeoTargetConstantServiceClientBuilder : gaxgrpc::ClientBuilderBase<GeoTargetConstantServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GeoTargetConstantServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GeoTargetConstantServiceClientBuilder()
        {
            UseJwtAccessWithScopes = GeoTargetConstantServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref GeoTargetConstantServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GeoTargetConstantServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GeoTargetConstantServiceClient Build()
        {
            GeoTargetConstantServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GeoTargetConstantServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GeoTargetConstantServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GeoTargetConstantServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GeoTargetConstantServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<GeoTargetConstantServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GeoTargetConstantServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => GeoTargetConstantServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => GeoTargetConstantServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GeoTargetConstantServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>GeoTargetConstantService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch geo target constants.
    /// </remarks>
    public abstract partial class GeoTargetConstantServiceClient
    {
        /// <summary>
        /// The default endpoint for the GeoTargetConstantService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default GeoTargetConstantService scopes.</summary>
        /// <remarks>
        /// The default GeoTargetConstantService scopes are:
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
        /// Asynchronously creates a <see cref="GeoTargetConstantServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GeoTargetConstantServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GeoTargetConstantServiceClient"/>.</returns>
        public static stt::Task<GeoTargetConstantServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GeoTargetConstantServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GeoTargetConstantServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="GeoTargetConstantServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GeoTargetConstantServiceClient"/>.</returns>
        public static GeoTargetConstantServiceClient Create() => new GeoTargetConstantServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GeoTargetConstantServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GeoTargetConstantServiceSettings"/>.</param>
        /// <returns>The created <see cref="GeoTargetConstantServiceClient"/>.</returns>
        internal static GeoTargetConstantServiceClient Create(grpccore::CallInvoker callInvoker, GeoTargetConstantServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GeoTargetConstantService.GeoTargetConstantServiceClient grpcClient = new GeoTargetConstantService.GeoTargetConstantServiceClient(callInvoker);
            return new GeoTargetConstantServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC GeoTargetConstantService client</summary>
        public virtual GeoTargetConstantService.GeoTargetConstantServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested geo target constant in full detail.
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
        public virtual gagvr::GeoTargetConstant GetGeoTargetConstant(GetGeoTargetConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested geo target constant in full detail.
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
        public virtual stt::Task<gagvr::GeoTargetConstant> GetGeoTargetConstantAsync(GetGeoTargetConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested geo target constant in full detail.
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
        public virtual stt::Task<gagvr::GeoTargetConstant> GetGeoTargetConstantAsync(GetGeoTargetConstantRequest request, st::CancellationToken cancellationToken) =>
            GetGeoTargetConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested geo target constant in full detail.
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
        /// Required. The resource name of the geo target constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::GeoTargetConstant GetGeoTargetConstant(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetGeoTargetConstant(new GetGeoTargetConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested geo target constant in full detail.
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
        /// Required. The resource name of the geo target constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GeoTargetConstant> GetGeoTargetConstantAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetGeoTargetConstantAsync(new GetGeoTargetConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested geo target constant in full detail.
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
        /// Required. The resource name of the geo target constant to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GeoTargetConstant> GetGeoTargetConstantAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetGeoTargetConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested geo target constant in full detail.
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
        /// Required. The resource name of the geo target constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::GeoTargetConstant GetGeoTargetConstant(gagvr::GeoTargetConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetGeoTargetConstant(new GetGeoTargetConstantRequest
            {
                ResourceNameAsGeoTargetConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested geo target constant in full detail.
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
        /// Required. The resource name of the geo target constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GeoTargetConstant> GetGeoTargetConstantAsync(gagvr::GeoTargetConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetGeoTargetConstantAsync(new GetGeoTargetConstantRequest
            {
                ResourceNameAsGeoTargetConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested geo target constant in full detail.
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
        /// Required. The resource name of the geo target constant to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GeoTargetConstant> GetGeoTargetConstantAsync(gagvr::GeoTargetConstantName resourceName, st::CancellationToken cancellationToken) =>
            GetGeoTargetConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns GeoTargetConstant suggestions by location name or by resource name.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [GeoTargetConstantSuggestionError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestGeoTargetConstantsResponse SuggestGeoTargetConstants(SuggestGeoTargetConstantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns GeoTargetConstant suggestions by location name or by resource name.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [GeoTargetConstantSuggestionError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestGeoTargetConstantsResponse> SuggestGeoTargetConstantsAsync(SuggestGeoTargetConstantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns GeoTargetConstant suggestions by location name or by resource name.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [GeoTargetConstantSuggestionError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestGeoTargetConstantsResponse> SuggestGeoTargetConstantsAsync(SuggestGeoTargetConstantsRequest request, st::CancellationToken cancellationToken) =>
            SuggestGeoTargetConstantsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GeoTargetConstantService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch geo target constants.
    /// </remarks>
    public sealed partial class GeoTargetConstantServiceClientImpl : GeoTargetConstantServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetGeoTargetConstantRequest, gagvr::GeoTargetConstant> _callGetGeoTargetConstant;

        private readonly gaxgrpc::ApiCall<SuggestGeoTargetConstantsRequest, SuggestGeoTargetConstantsResponse> _callSuggestGeoTargetConstants;

        /// <summary>
        /// Constructs a client wrapper for the GeoTargetConstantService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="GeoTargetConstantServiceSettings"/> used within this client.
        /// </param>
        public GeoTargetConstantServiceClientImpl(GeoTargetConstantService.GeoTargetConstantServiceClient grpcClient, GeoTargetConstantServiceSettings settings)
        {
            GrpcClient = grpcClient;
            GeoTargetConstantServiceSettings effectiveSettings = settings ?? GeoTargetConstantServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetGeoTargetConstant = clientHelper.BuildApiCall<GetGeoTargetConstantRequest, gagvr::GeoTargetConstant>(grpcClient.GetGeoTargetConstantAsync, grpcClient.GetGeoTargetConstant, effectiveSettings.GetGeoTargetConstantSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetGeoTargetConstant);
            Modify_GetGeoTargetConstantApiCall(ref _callGetGeoTargetConstant);
            _callSuggestGeoTargetConstants = clientHelper.BuildApiCall<SuggestGeoTargetConstantsRequest, SuggestGeoTargetConstantsResponse>(grpcClient.SuggestGeoTargetConstantsAsync, grpcClient.SuggestGeoTargetConstants, effectiveSettings.SuggestGeoTargetConstantsSettings);
            Modify_ApiCall(ref _callSuggestGeoTargetConstants);
            Modify_SuggestGeoTargetConstantsApiCall(ref _callSuggestGeoTargetConstants);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetGeoTargetConstantApiCall(ref gaxgrpc::ApiCall<GetGeoTargetConstantRequest, gagvr::GeoTargetConstant> call);

        partial void Modify_SuggestGeoTargetConstantsApiCall(ref gaxgrpc::ApiCall<SuggestGeoTargetConstantsRequest, SuggestGeoTargetConstantsResponse> call);

        partial void OnConstruction(GeoTargetConstantService.GeoTargetConstantServiceClient grpcClient, GeoTargetConstantServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GeoTargetConstantService client</summary>
        public override GeoTargetConstantService.GeoTargetConstantServiceClient GrpcClient { get; }

        partial void Modify_GetGeoTargetConstantRequest(ref GetGeoTargetConstantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SuggestGeoTargetConstantsRequest(ref SuggestGeoTargetConstantsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested geo target constant in full detail.
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
        public override gagvr::GeoTargetConstant GetGeoTargetConstant(GetGeoTargetConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGeoTargetConstantRequest(ref request, ref callSettings);
            return _callGetGeoTargetConstant.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested geo target constant in full detail.
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
        public override stt::Task<gagvr::GeoTargetConstant> GetGeoTargetConstantAsync(GetGeoTargetConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGeoTargetConstantRequest(ref request, ref callSettings);
            return _callGetGeoTargetConstant.Async(request, callSettings);
        }

        /// <summary>
        /// Returns GeoTargetConstant suggestions by location name or by resource name.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [GeoTargetConstantSuggestionError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SuggestGeoTargetConstantsResponse SuggestGeoTargetConstants(SuggestGeoTargetConstantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestGeoTargetConstantsRequest(ref request, ref callSettings);
            return _callSuggestGeoTargetConstants.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns GeoTargetConstant suggestions by location name or by resource name.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [GeoTargetConstantSuggestionError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SuggestGeoTargetConstantsResponse> SuggestGeoTargetConstantsAsync(SuggestGeoTargetConstantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestGeoTargetConstantsRequest(ref request, ref callSettings);
            return _callSuggestGeoTargetConstants.Async(request, callSettings);
        }
    }
}

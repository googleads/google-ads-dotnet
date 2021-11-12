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

using gagvr = Google.Ads.GoogleAds.V8.Resources;
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

namespace Google.Ads.GoogleAds.V8.Services
{
    /// <summary>Settings for <see cref="KeywordThemeConstantServiceClient"/> instances.</summary>
    public sealed partial class KeywordThemeConstantServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="KeywordThemeConstantServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="KeywordThemeConstantServiceSettings"/>.</returns>
        public static KeywordThemeConstantServiceSettings GetDefault() => new KeywordThemeConstantServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="KeywordThemeConstantServiceSettings"/> object with default settings.
        /// </summary>
        public KeywordThemeConstantServiceSettings()
        {
        }

        private KeywordThemeConstantServiceSettings(KeywordThemeConstantServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetKeywordThemeConstantSettings = existing.GetKeywordThemeConstantSettings;
            SuggestKeywordThemeConstantsSettings = existing.SuggestKeywordThemeConstantsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(KeywordThemeConstantServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordThemeConstantServiceClient.GetKeywordThemeConstant</c> and
        /// <c>KeywordThemeConstantServiceClient.GetKeywordThemeConstantAsync</c>.
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
        public gaxgrpc::CallSettings GetKeywordThemeConstantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordThemeConstantServiceClient.SuggestKeywordThemeConstants</c> and
        /// <c>KeywordThemeConstantServiceClient.SuggestKeywordThemeConstantsAsync</c>.
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
        public gaxgrpc::CallSettings SuggestKeywordThemeConstantsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="KeywordThemeConstantServiceSettings"/> object.</returns>
        public KeywordThemeConstantServiceSettings Clone() => new KeywordThemeConstantServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="KeywordThemeConstantServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class KeywordThemeConstantServiceClientBuilder : gaxgrpc::ClientBuilderBase<KeywordThemeConstantServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public KeywordThemeConstantServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public KeywordThemeConstantServiceClientBuilder()
        {
            UseJwtAccessWithScopes = KeywordThemeConstantServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref KeywordThemeConstantServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<KeywordThemeConstantServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override KeywordThemeConstantServiceClient Build()
        {
            KeywordThemeConstantServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<KeywordThemeConstantServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<KeywordThemeConstantServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private KeywordThemeConstantServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return KeywordThemeConstantServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<KeywordThemeConstantServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return KeywordThemeConstantServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => KeywordThemeConstantServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => KeywordThemeConstantServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => KeywordThemeConstantServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>KeywordThemeConstantService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch Smart Campaign keyword themes.
    /// </remarks>
    public abstract partial class KeywordThemeConstantServiceClient
    {
        /// <summary>
        /// The default endpoint for the KeywordThemeConstantService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default KeywordThemeConstantService scopes.</summary>
        /// <remarks>
        /// The default KeywordThemeConstantService scopes are:
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
        /// Asynchronously creates a <see cref="KeywordThemeConstantServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordThemeConstantServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="KeywordThemeConstantServiceClient"/>.</returns>
        public static stt::Task<KeywordThemeConstantServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new KeywordThemeConstantServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="KeywordThemeConstantServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordThemeConstantServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="KeywordThemeConstantServiceClient"/>.</returns>
        public static KeywordThemeConstantServiceClient Create() => new KeywordThemeConstantServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="KeywordThemeConstantServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="KeywordThemeConstantServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeywordThemeConstantServiceClient"/>.</returns>
        internal static KeywordThemeConstantServiceClient Create(grpccore::CallInvoker callInvoker, KeywordThemeConstantServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            KeywordThemeConstantService.KeywordThemeConstantServiceClient grpcClient = new KeywordThemeConstantService.KeywordThemeConstantServiceClient(callInvoker);
            return new KeywordThemeConstantServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC KeywordThemeConstantService client</summary>
        public virtual KeywordThemeConstantService.KeywordThemeConstantServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested keyword theme constant in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordThemeConstant GetKeywordThemeConstant(GetKeywordThemeConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested keyword theme constant in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordThemeConstant> GetKeywordThemeConstantAsync(GetKeywordThemeConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested keyword theme constant in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordThemeConstant> GetKeywordThemeConstantAsync(GetKeywordThemeConstantRequest request, st::CancellationToken cancellationToken) =>
            GetKeywordThemeConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested keyword theme constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the keyword theme constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordThemeConstant GetKeywordThemeConstant(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordThemeConstant(new GetKeywordThemeConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested keyword theme constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the keyword theme constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordThemeConstant> GetKeywordThemeConstantAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordThemeConstantAsync(new GetKeywordThemeConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested keyword theme constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the keyword theme constant to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordThemeConstant> GetKeywordThemeConstantAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetKeywordThemeConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested keyword theme constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the keyword theme constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordThemeConstant GetKeywordThemeConstant(gagvr::KeywordThemeConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordThemeConstant(new GetKeywordThemeConstantRequest
            {
                ResourceNameAsKeywordThemeConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested keyword theme constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the keyword theme constant to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordThemeConstant> GetKeywordThemeConstantAsync(gagvr::KeywordThemeConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordThemeConstantAsync(new GetKeywordThemeConstantRequest
            {
                ResourceNameAsKeywordThemeConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested keyword theme constant in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the keyword theme constant to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordThemeConstant> GetKeywordThemeConstantAsync(gagvr::KeywordThemeConstantName resourceName, st::CancellationToken cancellationToken) =>
            GetKeywordThemeConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns KeywordThemeConstant suggestions by keyword themes.
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
        public virtual SuggestKeywordThemeConstantsResponse SuggestKeywordThemeConstants(SuggestKeywordThemeConstantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns KeywordThemeConstant suggestions by keyword themes.
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
        public virtual stt::Task<SuggestKeywordThemeConstantsResponse> SuggestKeywordThemeConstantsAsync(SuggestKeywordThemeConstantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns KeywordThemeConstant suggestions by keyword themes.
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
        public virtual stt::Task<SuggestKeywordThemeConstantsResponse> SuggestKeywordThemeConstantsAsync(SuggestKeywordThemeConstantsRequest request, st::CancellationToken cancellationToken) =>
            SuggestKeywordThemeConstantsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>KeywordThemeConstantService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch Smart Campaign keyword themes.
    /// </remarks>
    public sealed partial class KeywordThemeConstantServiceClientImpl : KeywordThemeConstantServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetKeywordThemeConstantRequest, gagvr::KeywordThemeConstant> _callGetKeywordThemeConstant;

        private readonly gaxgrpc::ApiCall<SuggestKeywordThemeConstantsRequest, SuggestKeywordThemeConstantsResponse> _callSuggestKeywordThemeConstants;

        /// <summary>
        /// Constructs a client wrapper for the KeywordThemeConstantService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="KeywordThemeConstantServiceSettings"/> used within this client.
        /// </param>
        public KeywordThemeConstantServiceClientImpl(KeywordThemeConstantService.KeywordThemeConstantServiceClient grpcClient, KeywordThemeConstantServiceSettings settings)
        {
            GrpcClient = grpcClient;
            KeywordThemeConstantServiceSettings effectiveSettings = settings ?? KeywordThemeConstantServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetKeywordThemeConstant = clientHelper.BuildApiCall<GetKeywordThemeConstantRequest, gagvr::KeywordThemeConstant>(grpcClient.GetKeywordThemeConstantAsync, grpcClient.GetKeywordThemeConstant, effectiveSettings.GetKeywordThemeConstantSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetKeywordThemeConstant);
            Modify_GetKeywordThemeConstantApiCall(ref _callGetKeywordThemeConstant);
            _callSuggestKeywordThemeConstants = clientHelper.BuildApiCall<SuggestKeywordThemeConstantsRequest, SuggestKeywordThemeConstantsResponse>(grpcClient.SuggestKeywordThemeConstantsAsync, grpcClient.SuggestKeywordThemeConstants, effectiveSettings.SuggestKeywordThemeConstantsSettings);
            Modify_ApiCall(ref _callSuggestKeywordThemeConstants);
            Modify_SuggestKeywordThemeConstantsApiCall(ref _callSuggestKeywordThemeConstants);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetKeywordThemeConstantApiCall(ref gaxgrpc::ApiCall<GetKeywordThemeConstantRequest, gagvr::KeywordThemeConstant> call);

        partial void Modify_SuggestKeywordThemeConstantsApiCall(ref gaxgrpc::ApiCall<SuggestKeywordThemeConstantsRequest, SuggestKeywordThemeConstantsResponse> call);

        partial void OnConstruction(KeywordThemeConstantService.KeywordThemeConstantServiceClient grpcClient, KeywordThemeConstantServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC KeywordThemeConstantService client</summary>
        public override KeywordThemeConstantService.KeywordThemeConstantServiceClient GrpcClient { get; }

        partial void Modify_GetKeywordThemeConstantRequest(ref GetKeywordThemeConstantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SuggestKeywordThemeConstantsRequest(ref SuggestKeywordThemeConstantsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested keyword theme constant in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::KeywordThemeConstant GetKeywordThemeConstant(GetKeywordThemeConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordThemeConstantRequest(ref request, ref callSettings);
            return _callGetKeywordThemeConstant.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested keyword theme constant in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::KeywordThemeConstant> GetKeywordThemeConstantAsync(GetKeywordThemeConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordThemeConstantRequest(ref request, ref callSettings);
            return _callGetKeywordThemeConstant.Async(request, callSettings);
        }

        /// <summary>
        /// Returns KeywordThemeConstant suggestions by keyword themes.
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
        public override SuggestKeywordThemeConstantsResponse SuggestKeywordThemeConstants(SuggestKeywordThemeConstantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestKeywordThemeConstantsRequest(ref request, ref callSettings);
            return _callSuggestKeywordThemeConstants.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns KeywordThemeConstant suggestions by keyword themes.
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
        public override stt::Task<SuggestKeywordThemeConstantsResponse> SuggestKeywordThemeConstantsAsync(SuggestKeywordThemeConstantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestKeywordThemeConstantsRequest(ref request, ref callSettings);
            return _callSuggestKeywordThemeConstants.Async(request, callSettings);
        }
    }
}

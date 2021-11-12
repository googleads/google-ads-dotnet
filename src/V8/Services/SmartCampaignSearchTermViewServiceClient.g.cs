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
    /// <summary>Settings for <see cref="SmartCampaignSearchTermViewServiceClient"/> instances.</summary>
    public sealed partial class SmartCampaignSearchTermViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="SmartCampaignSearchTermViewServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="SmartCampaignSearchTermViewServiceSettings"/>.</returns>
        public static SmartCampaignSearchTermViewServiceSettings GetDefault() =>
            new SmartCampaignSearchTermViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SmartCampaignSearchTermViewServiceSettings"/> object with default settings.
        /// </summary>
        public SmartCampaignSearchTermViewServiceSettings()
        {
        }

        private SmartCampaignSearchTermViewServiceSettings(SmartCampaignSearchTermViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSmartCampaignSearchTermViewSettings = existing.GetSmartCampaignSearchTermViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SmartCampaignSearchTermViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SmartCampaignSearchTermViewServiceClient.GetSmartCampaignSearchTermView</c> and
        /// <c>SmartCampaignSearchTermViewServiceClient.GetSmartCampaignSearchTermViewAsync</c>.
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
        public gaxgrpc::CallSettings GetSmartCampaignSearchTermViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SmartCampaignSearchTermViewServiceSettings"/> object.</returns>
        public SmartCampaignSearchTermViewServiceSettings Clone() => new SmartCampaignSearchTermViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SmartCampaignSearchTermViewServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class SmartCampaignSearchTermViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<SmartCampaignSearchTermViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SmartCampaignSearchTermViewServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SmartCampaignSearchTermViewServiceClientBuilder()
        {
            UseJwtAccessWithScopes = SmartCampaignSearchTermViewServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref SmartCampaignSearchTermViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SmartCampaignSearchTermViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SmartCampaignSearchTermViewServiceClient Build()
        {
            SmartCampaignSearchTermViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SmartCampaignSearchTermViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SmartCampaignSearchTermViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SmartCampaignSearchTermViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SmartCampaignSearchTermViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<SmartCampaignSearchTermViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SmartCampaignSearchTermViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => SmartCampaignSearchTermViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            SmartCampaignSearchTermViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SmartCampaignSearchTermViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>SmartCampaignSearchTermViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Smart campaign search term views.
    /// </remarks>
    public abstract partial class SmartCampaignSearchTermViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the SmartCampaignSearchTermViewService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default SmartCampaignSearchTermViewService scopes.</summary>
        /// <remarks>
        /// The default SmartCampaignSearchTermViewService scopes are:
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
        /// Asynchronously creates a <see cref="SmartCampaignSearchTermViewServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SmartCampaignSearchTermViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SmartCampaignSearchTermViewServiceClient"/>.</returns>
        public static stt::Task<SmartCampaignSearchTermViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SmartCampaignSearchTermViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SmartCampaignSearchTermViewServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SmartCampaignSearchTermViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SmartCampaignSearchTermViewServiceClient"/>.</returns>
        public static SmartCampaignSearchTermViewServiceClient Create() =>
            new SmartCampaignSearchTermViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SmartCampaignSearchTermViewServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SmartCampaignSearchTermViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="SmartCampaignSearchTermViewServiceClient"/>.</returns>
        internal static SmartCampaignSearchTermViewServiceClient Create(grpccore::CallInvoker callInvoker, SmartCampaignSearchTermViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient grpcClient = new SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient(callInvoker);
            return new SmartCampaignSearchTermViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC SmartCampaignSearchTermViewService client</summary>
        public virtual SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the attributes of the requested Smart campaign search term view.
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
        public virtual gagvr::SmartCampaignSearchTermView GetSmartCampaignSearchTermView(GetSmartCampaignSearchTermViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the attributes of the requested Smart campaign search term view.
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
        public virtual stt::Task<gagvr::SmartCampaignSearchTermView> GetSmartCampaignSearchTermViewAsync(GetSmartCampaignSearchTermViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the attributes of the requested Smart campaign search term view.
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
        public virtual stt::Task<gagvr::SmartCampaignSearchTermView> GetSmartCampaignSearchTermViewAsync(GetSmartCampaignSearchTermViewRequest request, st::CancellationToken cancellationToken) =>
            GetSmartCampaignSearchTermViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the attributes of the requested Smart campaign search term view.
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
        /// Required. The resource name of the Smart campaign search term view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::SmartCampaignSearchTermView GetSmartCampaignSearchTermView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetSmartCampaignSearchTermView(new GetSmartCampaignSearchTermViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the attributes of the requested Smart campaign search term view.
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
        /// Required. The resource name of the Smart campaign search term view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SmartCampaignSearchTermView> GetSmartCampaignSearchTermViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetSmartCampaignSearchTermViewAsync(new GetSmartCampaignSearchTermViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the attributes of the requested Smart campaign search term view.
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
        /// Required. The resource name of the Smart campaign search term view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SmartCampaignSearchTermView> GetSmartCampaignSearchTermViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetSmartCampaignSearchTermViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the attributes of the requested Smart campaign search term view.
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
        /// Required. The resource name of the Smart campaign search term view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::SmartCampaignSearchTermView GetSmartCampaignSearchTermView(gagvr::SmartCampaignSearchTermViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetSmartCampaignSearchTermView(new GetSmartCampaignSearchTermViewRequest
            {
                ResourceNameAsSmartCampaignSearchTermViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the attributes of the requested Smart campaign search term view.
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
        /// Required. The resource name of the Smart campaign search term view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SmartCampaignSearchTermView> GetSmartCampaignSearchTermViewAsync(gagvr::SmartCampaignSearchTermViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetSmartCampaignSearchTermViewAsync(new GetSmartCampaignSearchTermViewRequest
            {
                ResourceNameAsSmartCampaignSearchTermViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the attributes of the requested Smart campaign search term view.
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
        /// Required. The resource name of the Smart campaign search term view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SmartCampaignSearchTermView> GetSmartCampaignSearchTermViewAsync(gagvr::SmartCampaignSearchTermViewName resourceName, st::CancellationToken cancellationToken) =>
            GetSmartCampaignSearchTermViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SmartCampaignSearchTermViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Smart campaign search term views.
    /// </remarks>
    public sealed partial class SmartCampaignSearchTermViewServiceClientImpl : SmartCampaignSearchTermViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetSmartCampaignSearchTermViewRequest, gagvr::SmartCampaignSearchTermView> _callGetSmartCampaignSearchTermView;

        /// <summary>
        /// Constructs a client wrapper for the SmartCampaignSearchTermViewService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="SmartCampaignSearchTermViewServiceSettings"/> used within this client.
        /// </param>
        public SmartCampaignSearchTermViewServiceClientImpl(SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient grpcClient, SmartCampaignSearchTermViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            SmartCampaignSearchTermViewServiceSettings effectiveSettings = settings ?? SmartCampaignSearchTermViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetSmartCampaignSearchTermView = clientHelper.BuildApiCall<GetSmartCampaignSearchTermViewRequest, gagvr::SmartCampaignSearchTermView>(grpcClient.GetSmartCampaignSearchTermViewAsync, grpcClient.GetSmartCampaignSearchTermView, effectiveSettings.GetSmartCampaignSearchTermViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetSmartCampaignSearchTermView);
            Modify_GetSmartCampaignSearchTermViewApiCall(ref _callGetSmartCampaignSearchTermView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetSmartCampaignSearchTermViewApiCall(ref gaxgrpc::ApiCall<GetSmartCampaignSearchTermViewRequest, gagvr::SmartCampaignSearchTermView> call);

        partial void OnConstruction(SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient grpcClient, SmartCampaignSearchTermViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SmartCampaignSearchTermViewService client</summary>
        public override SmartCampaignSearchTermViewService.SmartCampaignSearchTermViewServiceClient GrpcClient { get; }

        partial void Modify_GetSmartCampaignSearchTermViewRequest(ref GetSmartCampaignSearchTermViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the attributes of the requested Smart campaign search term view.
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
        public override gagvr::SmartCampaignSearchTermView GetSmartCampaignSearchTermView(GetSmartCampaignSearchTermViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSmartCampaignSearchTermViewRequest(ref request, ref callSettings);
            return _callGetSmartCampaignSearchTermView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the attributes of the requested Smart campaign search term view.
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
        public override stt::Task<gagvr::SmartCampaignSearchTermView> GetSmartCampaignSearchTermViewAsync(GetSmartCampaignSearchTermViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSmartCampaignSearchTermViewRequest(ref request, ref callSettings);
            return _callGetSmartCampaignSearchTermView.Async(request, callSettings);
        }
    }
}

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
    /// <summary>Settings for <see cref="AdGroupAudienceViewServiceClient"/> instances.</summary>
    public sealed partial class AdGroupAudienceViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdGroupAudienceViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdGroupAudienceViewServiceSettings"/>.</returns>
        public static AdGroupAudienceViewServiceSettings GetDefault() => new AdGroupAudienceViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AdGroupAudienceViewServiceSettings"/> object with default settings.
        /// </summary>
        public AdGroupAudienceViewServiceSettings()
        {
        }

        private AdGroupAudienceViewServiceSettings(AdGroupAudienceViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdGroupAudienceViewSettings = existing.GetAdGroupAudienceViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupAudienceViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupAudienceViewServiceClient.GetAdGroupAudienceView</c> and
        /// <c>AdGroupAudienceViewServiceClient.GetAdGroupAudienceViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAdGroupAudienceViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdGroupAudienceViewServiceSettings"/> object.</returns>
        public AdGroupAudienceViewServiceSettings Clone() => new AdGroupAudienceViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdGroupAudienceViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class AdGroupAudienceViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdGroupAudienceViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdGroupAudienceViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AdGroupAudienceViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdGroupAudienceViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdGroupAudienceViewServiceClient Build()
        {
            AdGroupAudienceViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdGroupAudienceViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdGroupAudienceViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdGroupAudienceViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdGroupAudienceViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AdGroupAudienceViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdGroupAudienceViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AdGroupAudienceViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AdGroupAudienceViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdGroupAudienceViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AdGroupAudienceViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ad group audience views.
    /// </remarks>
    public abstract partial class AdGroupAudienceViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupAudienceViewService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdGroupAudienceViewService scopes.</summary>
        /// <remarks>
        /// The default AdGroupAudienceViewService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupAudienceViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupAudienceViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdGroupAudienceViewServiceClient"/>.</returns>
        public static stt::Task<AdGroupAudienceViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdGroupAudienceViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupAudienceViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupAudienceViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdGroupAudienceViewServiceClient"/>.</returns>
        public static AdGroupAudienceViewServiceClient Create() => new AdGroupAudienceViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdGroupAudienceViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdGroupAudienceViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupAudienceViewServiceClient"/>.</returns>
        internal static AdGroupAudienceViewServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupAudienceViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupAudienceViewService.AdGroupAudienceViewServiceClient grpcClient = new AdGroupAudienceViewService.AdGroupAudienceViewServiceClient(callInvoker);
            return new AdGroupAudienceViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AdGroupAudienceViewService client</summary>
        public virtual AdGroupAudienceViewService.AdGroupAudienceViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group audience view in full detail.
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
        public virtual gagvr::AdGroupAudienceView GetAdGroupAudienceView(GetAdGroupAudienceViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group audience view in full detail.
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
        public virtual stt::Task<gagvr::AdGroupAudienceView> GetAdGroupAudienceViewAsync(GetAdGroupAudienceViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group audience view in full detail.
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
        public virtual stt::Task<gagvr::AdGroupAudienceView> GetAdGroupAudienceViewAsync(GetAdGroupAudienceViewRequest request, st::CancellationToken cancellationToken) =>
            GetAdGroupAudienceViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group audience view in full detail.
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
        /// Required. The resource name of the ad group audience view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupAudienceView GetAdGroupAudienceView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAudienceView(new GetAdGroupAudienceViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group audience view in full detail.
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
        /// Required. The resource name of the ad group audience view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAudienceView> GetAdGroupAudienceViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAudienceViewAsync(new GetAdGroupAudienceViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group audience view in full detail.
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
        /// Required. The resource name of the ad group audience view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAudienceView> GetAdGroupAudienceViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupAudienceViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group audience view in full detail.
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
        /// Required. The resource name of the ad group audience view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupAudienceView GetAdGroupAudienceView(gagvr::AdGroupAudienceViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAudienceView(new GetAdGroupAudienceViewRequest
            {
                ResourceNameAsAdGroupAudienceViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group audience view in full detail.
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
        /// Required. The resource name of the ad group audience view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAudienceView> GetAdGroupAudienceViewAsync(gagvr::AdGroupAudienceViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAudienceViewAsync(new GetAdGroupAudienceViewRequest
            {
                ResourceNameAsAdGroupAudienceViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group audience view in full detail.
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
        /// Required. The resource name of the ad group audience view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAudienceView> GetAdGroupAudienceViewAsync(gagvr::AdGroupAudienceViewName resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupAudienceViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdGroupAudienceViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ad group audience views.
    /// </remarks>
    public sealed partial class AdGroupAudienceViewServiceClientImpl : AdGroupAudienceViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdGroupAudienceViewRequest, gagvr::AdGroupAudienceView> _callGetAdGroupAudienceView;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupAudienceViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AdGroupAudienceViewServiceSettings"/> used within this client.
        /// </param>
        public AdGroupAudienceViewServiceClientImpl(AdGroupAudienceViewService.AdGroupAudienceViewServiceClient grpcClient, AdGroupAudienceViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AdGroupAudienceViewServiceSettings effectiveSettings = settings ?? AdGroupAudienceViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAdGroupAudienceView = clientHelper.BuildApiCall<GetAdGroupAudienceViewRequest, gagvr::AdGroupAudienceView>(grpcClient.GetAdGroupAudienceViewAsync, grpcClient.GetAdGroupAudienceView, effectiveSettings.GetAdGroupAudienceViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAdGroupAudienceView);
            Modify_GetAdGroupAudienceViewApiCall(ref _callGetAdGroupAudienceView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdGroupAudienceViewApiCall(ref gaxgrpc::ApiCall<GetAdGroupAudienceViewRequest, gagvr::AdGroupAudienceView> call);

        partial void OnConstruction(AdGroupAudienceViewService.AdGroupAudienceViewServiceClient grpcClient, AdGroupAudienceViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdGroupAudienceViewService client</summary>
        public override AdGroupAudienceViewService.AdGroupAudienceViewServiceClient GrpcClient { get; }

        partial void Modify_GetAdGroupAudienceViewRequest(ref GetAdGroupAudienceViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested ad group audience view in full detail.
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
        public override gagvr::AdGroupAudienceView GetAdGroupAudienceView(GetAdGroupAudienceViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupAudienceViewRequest(ref request, ref callSettings);
            return _callGetAdGroupAudienceView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested ad group audience view in full detail.
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
        public override stt::Task<gagvr::AdGroupAudienceView> GetAdGroupAudienceViewAsync(GetAdGroupAudienceViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupAudienceViewRequest(ref request, ref callSettings);
            return _callGetAdGroupAudienceView.Async(request, callSettings);
        }
    }
}

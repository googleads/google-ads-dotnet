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
    /// <summary>Settings for <see cref="LifeEventServiceClient"/> instances.</summary>
    public sealed partial class LifeEventServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LifeEventServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LifeEventServiceSettings"/>.</returns>
        public static LifeEventServiceSettings GetDefault() => new LifeEventServiceSettings();

        /// <summary>Constructs a new <see cref="LifeEventServiceSettings"/> object with default settings.</summary>
        public LifeEventServiceSettings()
        {
        }

        private LifeEventServiceSettings(LifeEventServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetLifeEventSettings = existing.GetLifeEventSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LifeEventServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LifeEventServiceClient.GetLifeEvent</c> and <c>LifeEventServiceClient.GetLifeEventAsync</c>.
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
        public gaxgrpc::CallSettings GetLifeEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LifeEventServiceSettings"/> object.</returns>
        public LifeEventServiceSettings Clone() => new LifeEventServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LifeEventServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class LifeEventServiceClientBuilder : gaxgrpc::ClientBuilderBase<LifeEventServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LifeEventServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref LifeEventServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LifeEventServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LifeEventServiceClient Build()
        {
            LifeEventServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LifeEventServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LifeEventServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LifeEventServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LifeEventServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<LifeEventServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LifeEventServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => LifeEventServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => LifeEventServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LifeEventServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>LifeEventService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch Google Ads Life Events.
    /// </remarks>
    public abstract partial class LifeEventServiceClient
    {
        /// <summary>
        /// The default endpoint for the LifeEventService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default LifeEventService scopes.</summary>
        /// <remarks>
        /// The default LifeEventService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="LifeEventServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LifeEventServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LifeEventServiceClient"/>.</returns>
        public static stt::Task<LifeEventServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LifeEventServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LifeEventServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LifeEventServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LifeEventServiceClient"/>.</returns>
        public static LifeEventServiceClient Create() => new LifeEventServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LifeEventServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LifeEventServiceSettings"/>.</param>
        /// <returns>The created <see cref="LifeEventServiceClient"/>.</returns>
        internal static LifeEventServiceClient Create(grpccore::CallInvoker callInvoker, LifeEventServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LifeEventService.LifeEventServiceClient grpcClient = new LifeEventService.LifeEventServiceClient(callInvoker);
            return new LifeEventServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC LifeEventService client</summary>
        public virtual LifeEventService.LifeEventServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested life event in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::LifeEvent GetLifeEvent(GetLifeEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested life event in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LifeEvent> GetLifeEventAsync(GetLifeEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested life event in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LifeEvent> GetLifeEventAsync(GetLifeEventRequest request, st::CancellationToken cancellationToken) =>
            GetLifeEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested life event in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the LifeEvent to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::LifeEvent GetLifeEvent(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLifeEvent(new GetLifeEventRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested life event in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the LifeEvent to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LifeEvent> GetLifeEventAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLifeEventAsync(new GetLifeEventRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested life event in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the LifeEvent to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LifeEvent> GetLifeEventAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetLifeEventAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested life event in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the LifeEvent to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::LifeEvent GetLifeEvent(gagvr::LifeEventName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLifeEvent(new GetLifeEventRequest
            {
                ResourceNameAsLifeEventName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested life event in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the LifeEvent to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LifeEvent> GetLifeEventAsync(gagvr::LifeEventName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLifeEventAsync(new GetLifeEventRequest
            {
                ResourceNameAsLifeEventName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested life event in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the LifeEvent to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::LifeEvent> GetLifeEventAsync(gagvr::LifeEventName resourceName, st::CancellationToken cancellationToken) =>
            GetLifeEventAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LifeEventService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch Google Ads Life Events.
    /// </remarks>
    public sealed partial class LifeEventServiceClientImpl : LifeEventServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetLifeEventRequest, gagvr::LifeEvent> _callGetLifeEvent;

        /// <summary>
        /// Constructs a client wrapper for the LifeEventService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LifeEventServiceSettings"/> used within this client.</param>
        public LifeEventServiceClientImpl(LifeEventService.LifeEventServiceClient grpcClient, LifeEventServiceSettings settings)
        {
            GrpcClient = grpcClient;
            LifeEventServiceSettings effectiveSettings = settings ?? LifeEventServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetLifeEvent = clientHelper.BuildApiCall<GetLifeEventRequest, gagvr::LifeEvent>(grpcClient.GetLifeEventAsync, grpcClient.GetLifeEvent, effectiveSettings.GetLifeEventSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetLifeEvent);
            Modify_GetLifeEventApiCall(ref _callGetLifeEvent);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetLifeEventApiCall(ref gaxgrpc::ApiCall<GetLifeEventRequest, gagvr::LifeEvent> call);

        partial void OnConstruction(LifeEventService.LifeEventServiceClient grpcClient, LifeEventServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LifeEventService client</summary>
        public override LifeEventService.LifeEventServiceClient GrpcClient { get; }

        partial void Modify_GetLifeEventRequest(ref GetLifeEventRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested life event in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::LifeEvent GetLifeEvent(GetLifeEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLifeEventRequest(ref request, ref callSettings);
            return _callGetLifeEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested life event in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::LifeEvent> GetLifeEventAsync(GetLifeEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLifeEventRequest(ref request, ref callSettings);
            return _callGetLifeEvent.Async(request, callSettings);
        }
    }
}

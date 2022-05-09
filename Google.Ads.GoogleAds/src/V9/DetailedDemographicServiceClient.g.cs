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

using gagvr = Google.Ads.GoogleAds.V9.Resources;
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

namespace Google.Ads.GoogleAds.V9.Services
{
    /// <summary>Settings for <see cref="DetailedDemographicServiceClient"/> instances.</summary>
    public sealed partial class DetailedDemographicServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DetailedDemographicServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DetailedDemographicServiceSettings"/>.</returns>
        public static DetailedDemographicServiceSettings GetDefault() => new DetailedDemographicServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DetailedDemographicServiceSettings"/> object with default settings.
        /// </summary>
        public DetailedDemographicServiceSettings()
        {
        }

        private DetailedDemographicServiceSettings(DetailedDemographicServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDetailedDemographicSettings = existing.GetDetailedDemographicSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DetailedDemographicServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DetailedDemographicServiceClient.GetDetailedDemographic</c> and
        /// <c>DetailedDemographicServiceClient.GetDetailedDemographicAsync</c>.
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
        /// <item><description>Timeout: 14400 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDetailedDemographicSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DetailedDemographicServiceSettings"/> object.</returns>
        public DetailedDemographicServiceSettings Clone() => new DetailedDemographicServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DetailedDemographicServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class DetailedDemographicServiceClientBuilder : gaxgrpc::ClientBuilderBase<DetailedDemographicServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DetailedDemographicServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DetailedDemographicServiceClientBuilder()
        {
            UseJwtAccessWithScopes = DetailedDemographicServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref DetailedDemographicServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DetailedDemographicServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DetailedDemographicServiceClient Build()
        {
            DetailedDemographicServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DetailedDemographicServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DetailedDemographicServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DetailedDemographicServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DetailedDemographicServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<DetailedDemographicServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DetailedDemographicServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => DetailedDemographicServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => DetailedDemographicServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DetailedDemographicServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>DetailedDemographicService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch Google Ads Detailed Demographics.
    /// </remarks>
    public abstract partial class DetailedDemographicServiceClient
    {
        /// <summary>
        /// The default endpoint for the DetailedDemographicService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default DetailedDemographicService scopes.</summary>
        /// <remarks>
        /// The default DetailedDemographicService scopes are:
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
        /// Asynchronously creates a <see cref="DetailedDemographicServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DetailedDemographicServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DetailedDemographicServiceClient"/>.</returns>
        public static stt::Task<DetailedDemographicServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DetailedDemographicServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DetailedDemographicServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DetailedDemographicServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DetailedDemographicServiceClient"/>.</returns>
        public static DetailedDemographicServiceClient Create() => new DetailedDemographicServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DetailedDemographicServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DetailedDemographicServiceSettings"/>.</param>
        /// <returns>The created <see cref="DetailedDemographicServiceClient"/>.</returns>
        internal static DetailedDemographicServiceClient Create(grpccore::CallInvoker callInvoker, DetailedDemographicServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DetailedDemographicService.DetailedDemographicServiceClient grpcClient = new DetailedDemographicService.DetailedDemographicServiceClient(callInvoker);
            return new DetailedDemographicServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC DetailedDemographicService client</summary>
        public virtual DetailedDemographicService.DetailedDemographicServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested detailed demographic in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::DetailedDemographic GetDetailedDemographic(GetDetailedDemographicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested detailed demographic in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DetailedDemographic> GetDetailedDemographicAsync(GetDetailedDemographicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested detailed demographic in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DetailedDemographic> GetDetailedDemographicAsync(GetDetailedDemographicRequest request, st::CancellationToken cancellationToken) =>
            GetDetailedDemographicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested detailed demographic in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the DetailedDemographic to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::DetailedDemographic GetDetailedDemographic(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDetailedDemographic(new GetDetailedDemographicRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested detailed demographic in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the DetailedDemographic to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DetailedDemographic> GetDetailedDemographicAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDetailedDemographicAsync(new GetDetailedDemographicRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested detailed demographic in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the DetailedDemographic to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DetailedDemographic> GetDetailedDemographicAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetDetailedDemographicAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested detailed demographic in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the DetailedDemographic to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::DetailedDemographic GetDetailedDemographic(gagvr::DetailedDemographicName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDetailedDemographic(new GetDetailedDemographicRequest
            {
                ResourceNameAsDetailedDemographicName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested detailed demographic in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the DetailedDemographic to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DetailedDemographic> GetDetailedDemographicAsync(gagvr::DetailedDemographicName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDetailedDemographicAsync(new GetDetailedDemographicRequest
            {
                ResourceNameAsDetailedDemographicName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested detailed demographic in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the DetailedDemographic to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DetailedDemographic> GetDetailedDemographicAsync(gagvr::DetailedDemographicName resourceName, st::CancellationToken cancellationToken) =>
            GetDetailedDemographicAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DetailedDemographicService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch Google Ads Detailed Demographics.
    /// </remarks>
    public sealed partial class DetailedDemographicServiceClientImpl : DetailedDemographicServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDetailedDemographicRequest, gagvr::DetailedDemographic> _callGetDetailedDemographic;

        /// <summary>
        /// Constructs a client wrapper for the DetailedDemographicService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DetailedDemographicServiceSettings"/> used within this client.
        /// </param>
        public DetailedDemographicServiceClientImpl(DetailedDemographicService.DetailedDemographicServiceClient grpcClient, DetailedDemographicServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DetailedDemographicServiceSettings effectiveSettings = settings ?? DetailedDemographicServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetDetailedDemographic = clientHelper.BuildApiCall<GetDetailedDemographicRequest, gagvr::DetailedDemographic>(grpcClient.GetDetailedDemographicAsync, grpcClient.GetDetailedDemographic, effectiveSettings.GetDetailedDemographicSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetDetailedDemographic);
            Modify_GetDetailedDemographicApiCall(ref _callGetDetailedDemographic);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDetailedDemographicApiCall(ref gaxgrpc::ApiCall<GetDetailedDemographicRequest, gagvr::DetailedDemographic> call);

        partial void OnConstruction(DetailedDemographicService.DetailedDemographicServiceClient grpcClient, DetailedDemographicServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DetailedDemographicService client</summary>
        public override DetailedDemographicService.DetailedDemographicServiceClient GrpcClient { get; }

        partial void Modify_GetDetailedDemographicRequest(ref GetDetailedDemographicRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested detailed demographic in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::DetailedDemographic GetDetailedDemographic(GetDetailedDemographicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDetailedDemographicRequest(ref request, ref callSettings);
            return _callGetDetailedDemographic.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested detailed demographic in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::DetailedDemographic> GetDetailedDemographicAsync(GetDetailedDemographicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDetailedDemographicRequest(ref request, ref callSettings);
            return _callGetDetailedDemographic.Async(request, callSettings);
        }
    }
}

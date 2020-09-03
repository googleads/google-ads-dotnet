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
    /// <summary>Settings for <see cref="AdGroupAdServiceClient"/> instances.</summary>
    public sealed partial class AdGroupAdServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdGroupAdServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdGroupAdServiceSettings"/>.</returns>
        public static AdGroupAdServiceSettings GetDefault() => new AdGroupAdServiceSettings();

        /// <summary>Constructs a new <see cref="AdGroupAdServiceSettings"/> object with default settings.</summary>
        public AdGroupAdServiceSettings()
        {
        }

        private AdGroupAdServiceSettings(AdGroupAdServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdGroupAdSettings = existing.GetAdGroupAdSettings;
            MutateAdGroupAdsSettings = existing.MutateAdGroupAdsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupAdServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupAdServiceClient.GetAdGroupAd</c> and <c>AdGroupAdServiceClient.GetAdGroupAdAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAdGroupAdSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupAdServiceClient.MutateAdGroupAds</c> and <c>AdGroupAdServiceClient.MutateAdGroupAdsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateAdGroupAdsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdGroupAdServiceSettings"/> object.</returns>
        public AdGroupAdServiceSettings Clone() => new AdGroupAdServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdGroupAdServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AdGroupAdServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdGroupAdServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdGroupAdServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AdGroupAdServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdGroupAdServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdGroupAdServiceClient Build()
        {
            AdGroupAdServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdGroupAdServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdGroupAdServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdGroupAdServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdGroupAdServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AdGroupAdServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdGroupAdServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AdGroupAdServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AdGroupAdServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdGroupAdServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AdGroupAdService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ads in an ad group.
    /// </remarks>
    public abstract partial class AdGroupAdServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupAdService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdGroupAdService scopes.</summary>
        /// <remarks>The default AdGroupAdService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupAdServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdGroupAdServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdGroupAdServiceClient"/>.</returns>
        public static stt::Task<AdGroupAdServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdGroupAdServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupAdServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdGroupAdServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdGroupAdServiceClient"/>.</returns>
        public static AdGroupAdServiceClient Create() => new AdGroupAdServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdGroupAdServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdGroupAdServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupAdServiceClient"/>.</returns>
        internal static AdGroupAdServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupAdServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupAdService.AdGroupAdServiceClient grpcClient = new AdGroupAdService.AdGroupAdServiceClient(callInvoker);
            return new AdGroupAdServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AdGroupAdService client</summary>
        public virtual AdGroupAdService.AdGroupAdServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupAd GetAdGroupAd(GetAdGroupAdRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAd> GetAdGroupAdAsync(GetAdGroupAdRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAd> GetAdGroupAdAsync(GetAdGroupAdRequest request, st::CancellationToken cancellationToken) =>
            GetAdGroupAdAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupAd GetAdGroupAd(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAd(new GetAdGroupAdRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAd> GetAdGroupAdAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAdAsync(new GetAdGroupAdRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAd> GetAdGroupAdAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupAdAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupAd GetAdGroupAd(gagvr::AdGroupAdName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAd(new GetAdGroupAdRequest
            {
                ResourceNameAsAdGroupAdName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAd> GetAdGroupAdAsync(gagvr::AdGroupAdName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAdAsync(new GetAdGroupAdRequest
            {
                ResourceNameAsAdGroupAdName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAd> GetAdGroupAdAsync(gagvr::AdGroupAdName resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupAdAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes ads. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupAdsResponse MutateAdGroupAds(MutateAdGroupAdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ads. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAdsResponse> MutateAdGroupAdsAsync(MutateAdGroupAdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ads. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAdsResponse> MutateAdGroupAdsAsync(MutateAdGroupAdsRequest request, st::CancellationToken cancellationToken) =>
            MutateAdGroupAdsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes ads. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ads are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ads.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupAdsResponse MutateAdGroupAds(string customerId, scg::IEnumerable<AdGroupAdOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupAds(new MutateAdGroupAdsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes ads. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ads are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ads.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAdsResponse> MutateAdGroupAdsAsync(string customerId, scg::IEnumerable<AdGroupAdOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupAdsAsync(new MutateAdGroupAdsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes ads. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ads are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ads.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAdsResponse> MutateAdGroupAdsAsync(string customerId, scg::IEnumerable<AdGroupAdOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAdGroupAdsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdGroupAdService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ads in an ad group.
    /// </remarks>
    public sealed partial class AdGroupAdServiceClientImpl : AdGroupAdServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdGroupAdRequest, gagvr::AdGroupAd> _callGetAdGroupAd;

        private readonly gaxgrpc::ApiCall<MutateAdGroupAdsRequest, MutateAdGroupAdsResponse> _callMutateAdGroupAds;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupAdService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdGroupAdServiceSettings"/> used within this client.</param>
        public AdGroupAdServiceClientImpl(AdGroupAdService.AdGroupAdServiceClient grpcClient, AdGroupAdServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AdGroupAdServiceSettings effectiveSettings = settings ?? AdGroupAdServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAdGroupAd = clientHelper.BuildApiCall<GetAdGroupAdRequest, gagvr::AdGroupAd>(grpcClient.GetAdGroupAdAsync, grpcClient.GetAdGroupAd, effectiveSettings.GetAdGroupAdSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAdGroupAd);
            Modify_GetAdGroupAdApiCall(ref _callGetAdGroupAd);
            _callMutateAdGroupAds = clientHelper.BuildApiCall<MutateAdGroupAdsRequest, MutateAdGroupAdsResponse>(grpcClient.MutateAdGroupAdsAsync, grpcClient.MutateAdGroupAds, effectiveSettings.MutateAdGroupAdsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAdGroupAds);
            Modify_MutateAdGroupAdsApiCall(ref _callMutateAdGroupAds);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdGroupAdApiCall(ref gaxgrpc::ApiCall<GetAdGroupAdRequest, gagvr::AdGroupAd> call);

        partial void Modify_MutateAdGroupAdsApiCall(ref gaxgrpc::ApiCall<MutateAdGroupAdsRequest, MutateAdGroupAdsResponse> call);

        partial void OnConstruction(AdGroupAdService.AdGroupAdServiceClient grpcClient, AdGroupAdServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdGroupAdService client</summary>
        public override AdGroupAdService.AdGroupAdServiceClient GrpcClient { get; }

        partial void Modify_GetAdGroupAdRequest(ref GetAdGroupAdRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateAdGroupAdsRequest(ref MutateAdGroupAdsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested ad in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::AdGroupAd GetAdGroupAd(GetAdGroupAdRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupAdRequest(ref request, ref callSettings);
            return _callGetAdGroupAd.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested ad in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::AdGroupAd> GetAdGroupAdAsync(GetAdGroupAdRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupAdRequest(ref request, ref callSettings);
            return _callGetAdGroupAd.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes ads. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAdGroupAdsResponse MutateAdGroupAds(MutateAdGroupAdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupAdsRequest(ref request, ref callSettings);
            return _callMutateAdGroupAds.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes ads. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAdGroupAdsResponse> MutateAdGroupAdsAsync(MutateAdGroupAdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupAdsRequest(ref request, ref callSettings);
            return _callMutateAdGroupAds.Async(request, callSettings);
        }
    }
}

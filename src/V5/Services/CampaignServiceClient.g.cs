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
    /// <summary>Settings for <see cref="CampaignServiceClient"/> instances.</summary>
    public sealed partial class CampaignServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignServiceSettings"/>.</returns>
        public static CampaignServiceSettings GetDefault() => new CampaignServiceSettings();

        /// <summary>Constructs a new <see cref="CampaignServiceSettings"/> object with default settings.</summary>
        public CampaignServiceSettings()
        {
        }

        private CampaignServiceSettings(CampaignServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCampaignSettings = existing.GetCampaignSettings;
            MutateCampaignsSettings = existing.MutateCampaignsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignServiceClient.GetCampaign</c> and <c>CampaignServiceClient.GetCampaignAsync</c>.
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
        public gaxgrpc::CallSettings GetCampaignSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignServiceClient.MutateCampaigns</c> and <c>CampaignServiceClient.MutateCampaignsAsync</c>.
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
        public gaxgrpc::CallSettings MutateCampaignsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignServiceSettings"/> object.</returns>
        public CampaignServiceSettings Clone() => new CampaignServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class CampaignServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CampaignServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignServiceClient Build()
        {
            CampaignServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CampaignServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CampaignServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CampaignServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CampaignService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaigns.
    /// </remarks>
    public abstract partial class CampaignServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignService scopes.</summary>
        /// <remarks>
        /// The default CampaignService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CampaignServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignServiceClient"/>.</returns>
        public static stt::Task<CampaignServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CampaignServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignServiceClient"/>.</returns>
        public static CampaignServiceClient Create() => new CampaignServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignServiceClient"/>.</returns>
        internal static CampaignServiceClient Create(grpccore::CallInvoker callInvoker, CampaignServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignService.CampaignServiceClient grpcClient = new CampaignService.CampaignServiceClient(callInvoker);
            return new CampaignServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CampaignService client</summary>
        public virtual CampaignService.CampaignServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::Campaign GetCampaign(GetCampaignRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Campaign> GetCampaignAsync(GetCampaignRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Campaign> GetCampaignAsync(GetCampaignRequest request, st::CancellationToken cancellationToken) =>
            GetCampaignAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::Campaign GetCampaign(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaign(new GetCampaignRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Campaign> GetCampaignAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignAsync(new GetCampaignRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Campaign> GetCampaignAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::Campaign GetCampaign(gagvr::CampaignName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaign(new GetCampaignRequest
            {
                ResourceNameAsCampaignName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Campaign> GetCampaignAsync(gagvr::CampaignName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignAsync(new GetCampaignRequest
            {
                ResourceNameAsCampaignName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Campaign> GetCampaignAsync(gagvr::CampaignName resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes campaigns. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignsResponse MutateCampaigns(MutateCampaignsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaigns. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignsResponse> MutateCampaignsAsync(MutateCampaignsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaigns. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignsResponse> MutateCampaignsAsync(MutateCampaignsRequest request, st::CancellationToken cancellationToken) =>
            MutateCampaignsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes campaigns. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaigns are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaigns.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignsResponse MutateCampaigns(string customerId, scg::IEnumerable<CampaignOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaigns(new MutateCampaignsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes campaigns. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaigns are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaigns.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignsResponse> MutateCampaignsAsync(string customerId, scg::IEnumerable<CampaignOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignsAsync(new MutateCampaignsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes campaigns. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaigns are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaigns.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignsResponse> MutateCampaignsAsync(string customerId, scg::IEnumerable<CampaignOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCampaignsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CampaignService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaigns.
    /// </remarks>
    public sealed partial class CampaignServiceClientImpl : CampaignServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCampaignRequest, gagvr::Campaign> _callGetCampaign;

        private readonly gaxgrpc::ApiCall<MutateCampaignsRequest, MutateCampaignsResponse> _callMutateCampaigns;

        /// <summary>
        /// Constructs a client wrapper for the CampaignService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CampaignServiceSettings"/> used within this client.</param>
        public CampaignServiceClientImpl(CampaignService.CampaignServiceClient grpcClient, CampaignServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CampaignServiceSettings effectiveSettings = settings ?? CampaignServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCampaign = clientHelper.BuildApiCall<GetCampaignRequest, gagvr::Campaign>(grpcClient.GetCampaignAsync, grpcClient.GetCampaign, effectiveSettings.GetCampaignSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCampaign);
            Modify_GetCampaignApiCall(ref _callGetCampaign);
            _callMutateCampaigns = clientHelper.BuildApiCall<MutateCampaignsRequest, MutateCampaignsResponse>(grpcClient.MutateCampaignsAsync, grpcClient.MutateCampaigns, effectiveSettings.MutateCampaignsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCampaigns);
            Modify_MutateCampaignsApiCall(ref _callMutateCampaigns);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCampaignApiCall(ref gaxgrpc::ApiCall<GetCampaignRequest, gagvr::Campaign> call);

        partial void Modify_MutateCampaignsApiCall(ref gaxgrpc::ApiCall<MutateCampaignsRequest, MutateCampaignsResponse> call);

        partial void OnConstruction(CampaignService.CampaignServiceClient grpcClient, CampaignServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignService client</summary>
        public override CampaignService.CampaignServiceClient GrpcClient { get; }

        partial void Modify_GetCampaignRequest(ref GetCampaignRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateCampaignsRequest(ref MutateCampaignsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested campaign in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::Campaign GetCampaign(GetCampaignRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignRequest(ref request, ref callSettings);
            return _callGetCampaign.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested campaign in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::Campaign> GetCampaignAsync(GetCampaignRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignRequest(ref request, ref callSettings);
            return _callGetCampaign.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes campaigns. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCampaignsResponse MutateCampaigns(MutateCampaignsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignsRequest(ref request, ref callSettings);
            return _callMutateCampaigns.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes campaigns. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCampaignsResponse> MutateCampaignsAsync(MutateCampaignsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignsRequest(ref request, ref callSettings);
            return _callMutateCampaigns.Async(request, callSettings);
        }
    }
}

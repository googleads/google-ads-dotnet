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
    /// <summary>Settings for <see cref="KeywordPlanCampaignServiceClient"/> instances.</summary>
    public sealed partial class KeywordPlanCampaignServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="KeywordPlanCampaignServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="KeywordPlanCampaignServiceSettings"/>.</returns>
        public static KeywordPlanCampaignServiceSettings GetDefault() => new KeywordPlanCampaignServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="KeywordPlanCampaignServiceSettings"/> object with default settings.
        /// </summary>
        public KeywordPlanCampaignServiceSettings()
        {
        }

        private KeywordPlanCampaignServiceSettings(KeywordPlanCampaignServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetKeywordPlanCampaignSettings = existing.GetKeywordPlanCampaignSettings;
            MutateKeywordPlanCampaignsSettings = existing.MutateKeywordPlanCampaignsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(KeywordPlanCampaignServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanCampaignServiceClient.GetKeywordPlanCampaign</c> and
        /// <c>KeywordPlanCampaignServiceClient.GetKeywordPlanCampaignAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetKeywordPlanCampaignSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanCampaignServiceClient.MutateKeywordPlanCampaigns</c> and
        /// <c>KeywordPlanCampaignServiceClient.MutateKeywordPlanCampaignsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateKeywordPlanCampaignsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="KeywordPlanCampaignServiceSettings"/> object.</returns>
        public KeywordPlanCampaignServiceSettings Clone() => new KeywordPlanCampaignServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="KeywordPlanCampaignServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class KeywordPlanCampaignServiceClientBuilder : gaxgrpc::ClientBuilderBase<KeywordPlanCampaignServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public KeywordPlanCampaignServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref KeywordPlanCampaignServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<KeywordPlanCampaignServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override KeywordPlanCampaignServiceClient Build()
        {
            KeywordPlanCampaignServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<KeywordPlanCampaignServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<KeywordPlanCampaignServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private KeywordPlanCampaignServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return KeywordPlanCampaignServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<KeywordPlanCampaignServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return KeywordPlanCampaignServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => KeywordPlanCampaignServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => KeywordPlanCampaignServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => KeywordPlanCampaignServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>KeywordPlanCampaignService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Keyword Plan campaigns.
    /// </remarks>
    public abstract partial class KeywordPlanCampaignServiceClient
    {
        /// <summary>
        /// The default endpoint for the KeywordPlanCampaignService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default KeywordPlanCampaignService scopes.</summary>
        /// <remarks>The default KeywordPlanCampaignService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="KeywordPlanCampaignServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordPlanCampaignServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="KeywordPlanCampaignServiceClient"/>.</returns>
        public static stt::Task<KeywordPlanCampaignServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new KeywordPlanCampaignServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="KeywordPlanCampaignServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordPlanCampaignServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="KeywordPlanCampaignServiceClient"/>.</returns>
        public static KeywordPlanCampaignServiceClient Create() => new KeywordPlanCampaignServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="KeywordPlanCampaignServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="KeywordPlanCampaignServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeywordPlanCampaignServiceClient"/>.</returns>
        internal static KeywordPlanCampaignServiceClient Create(grpccore::CallInvoker callInvoker, KeywordPlanCampaignServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            KeywordPlanCampaignService.KeywordPlanCampaignServiceClient grpcClient = new KeywordPlanCampaignService.KeywordPlanCampaignServiceClient(callInvoker);
            return new KeywordPlanCampaignServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC KeywordPlanCampaignService client</summary>
        public virtual KeywordPlanCampaignService.KeywordPlanCampaignServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Keyword Plan campaign in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordPlanCampaign GetKeywordPlanCampaign(GetKeywordPlanCampaignRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Keyword Plan campaign in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanCampaign> GetKeywordPlanCampaignAsync(GetKeywordPlanCampaignRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Keyword Plan campaign in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanCampaign> GetKeywordPlanCampaignAsync(GetKeywordPlanCampaignRequest request, st::CancellationToken cancellationToken) =>
            GetKeywordPlanCampaignAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan campaign in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Keyword Plan campaign to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordPlanCampaign GetKeywordPlanCampaign(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanCampaign(new GetKeywordPlanCampaignRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan campaign in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Keyword Plan campaign to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanCampaign> GetKeywordPlanCampaignAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanCampaignAsync(new GetKeywordPlanCampaignRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan campaign in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Keyword Plan campaign to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanCampaign> GetKeywordPlanCampaignAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetKeywordPlanCampaignAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan campaign in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Keyword Plan campaign to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordPlanCampaign GetKeywordPlanCampaign(gagvr::KeywordPlanCampaignName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanCampaign(new GetKeywordPlanCampaignRequest
            {
                ResourceNameAsKeywordPlanCampaignName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan campaign in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Keyword Plan campaign to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanCampaign> GetKeywordPlanCampaignAsync(gagvr::KeywordPlanCampaignName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanCampaignAsync(new GetKeywordPlanCampaignRequest
            {
                ResourceNameAsKeywordPlanCampaignName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan campaign in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Keyword Plan campaign to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanCampaign> GetKeywordPlanCampaignAsync(gagvr::KeywordPlanCampaignName resourceName, st::CancellationToken cancellationToken) =>
            GetKeywordPlanCampaignAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes Keyword Plan campaigns. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateKeywordPlanCampaignsResponse MutateKeywordPlanCampaigns(MutateKeywordPlanCampaignsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes Keyword Plan campaigns. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanCampaignsResponse> MutateKeywordPlanCampaignsAsync(MutateKeywordPlanCampaignsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes Keyword Plan campaigns. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanCampaignsResponse> MutateKeywordPlanCampaignsAsync(MutateKeywordPlanCampaignsRequest request, st::CancellationToken cancellationToken) =>
            MutateKeywordPlanCampaignsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes Keyword Plan campaigns. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan campaigns are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan campaigns.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateKeywordPlanCampaignsResponse MutateKeywordPlanCampaigns(string customerId, scg::IEnumerable<KeywordPlanCampaignOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateKeywordPlanCampaigns(new MutateKeywordPlanCampaignsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan campaigns. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan campaigns are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan campaigns.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanCampaignsResponse> MutateKeywordPlanCampaignsAsync(string customerId, scg::IEnumerable<KeywordPlanCampaignOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateKeywordPlanCampaignsAsync(new MutateKeywordPlanCampaignsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan campaigns. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan campaigns are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan campaigns.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanCampaignsResponse> MutateKeywordPlanCampaignsAsync(string customerId, scg::IEnumerable<KeywordPlanCampaignOperation> operations, st::CancellationToken cancellationToken) =>
            MutateKeywordPlanCampaignsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>KeywordPlanCampaignService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Keyword Plan campaigns.
    /// </remarks>
    public sealed partial class KeywordPlanCampaignServiceClientImpl : KeywordPlanCampaignServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetKeywordPlanCampaignRequest, gagvr::KeywordPlanCampaign> _callGetKeywordPlanCampaign;

        private readonly gaxgrpc::ApiCall<MutateKeywordPlanCampaignsRequest, MutateKeywordPlanCampaignsResponse> _callMutateKeywordPlanCampaigns;

        /// <summary>
        /// Constructs a client wrapper for the KeywordPlanCampaignService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="KeywordPlanCampaignServiceSettings"/> used within this client.
        /// </param>
        public KeywordPlanCampaignServiceClientImpl(KeywordPlanCampaignService.KeywordPlanCampaignServiceClient grpcClient, KeywordPlanCampaignServiceSettings settings)
        {
            GrpcClient = grpcClient;
            KeywordPlanCampaignServiceSettings effectiveSettings = settings ?? KeywordPlanCampaignServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetKeywordPlanCampaign = clientHelper.BuildApiCall<GetKeywordPlanCampaignRequest, gagvr::KeywordPlanCampaign>(grpcClient.GetKeywordPlanCampaignAsync, grpcClient.GetKeywordPlanCampaign, effectiveSettings.GetKeywordPlanCampaignSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetKeywordPlanCampaign);
            Modify_GetKeywordPlanCampaignApiCall(ref _callGetKeywordPlanCampaign);
            _callMutateKeywordPlanCampaigns = clientHelper.BuildApiCall<MutateKeywordPlanCampaignsRequest, MutateKeywordPlanCampaignsResponse>(grpcClient.MutateKeywordPlanCampaignsAsync, grpcClient.MutateKeywordPlanCampaigns, effectiveSettings.MutateKeywordPlanCampaignsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateKeywordPlanCampaigns);
            Modify_MutateKeywordPlanCampaignsApiCall(ref _callMutateKeywordPlanCampaigns);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetKeywordPlanCampaignApiCall(ref gaxgrpc::ApiCall<GetKeywordPlanCampaignRequest, gagvr::KeywordPlanCampaign> call);

        partial void Modify_MutateKeywordPlanCampaignsApiCall(ref gaxgrpc::ApiCall<MutateKeywordPlanCampaignsRequest, MutateKeywordPlanCampaignsResponse> call);

        partial void OnConstruction(KeywordPlanCampaignService.KeywordPlanCampaignServiceClient grpcClient, KeywordPlanCampaignServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC KeywordPlanCampaignService client</summary>
        public override KeywordPlanCampaignService.KeywordPlanCampaignServiceClient GrpcClient { get; }

        partial void Modify_GetKeywordPlanCampaignRequest(ref GetKeywordPlanCampaignRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateKeywordPlanCampaignsRequest(ref MutateKeywordPlanCampaignsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested Keyword Plan campaign in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::KeywordPlanCampaign GetKeywordPlanCampaign(GetKeywordPlanCampaignRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanCampaignRequest(ref request, ref callSettings);
            return _callGetKeywordPlanCampaign.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Keyword Plan campaign in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::KeywordPlanCampaign> GetKeywordPlanCampaignAsync(GetKeywordPlanCampaignRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanCampaignRequest(ref request, ref callSettings);
            return _callGetKeywordPlanCampaign.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan campaigns. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateKeywordPlanCampaignsResponse MutateKeywordPlanCampaigns(MutateKeywordPlanCampaignsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlanCampaignsRequest(ref request, ref callSettings);
            return _callMutateKeywordPlanCampaigns.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan campaigns. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateKeywordPlanCampaignsResponse> MutateKeywordPlanCampaignsAsync(MutateKeywordPlanCampaignsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlanCampaignsRequest(ref request, ref callSettings);
            return _callMutateKeywordPlanCampaigns.Async(request, callSettings);
        }
    }
}

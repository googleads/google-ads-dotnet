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
    /// <summary>Settings for <see cref="KeywordPlanCampaignKeywordServiceClient"/> instances.</summary>
    public sealed partial class KeywordPlanCampaignKeywordServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="KeywordPlanCampaignKeywordServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="KeywordPlanCampaignKeywordServiceSettings"/>.</returns>
        public static KeywordPlanCampaignKeywordServiceSettings GetDefault() =>
            new KeywordPlanCampaignKeywordServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="KeywordPlanCampaignKeywordServiceSettings"/> object with default settings.
        /// </summary>
        public KeywordPlanCampaignKeywordServiceSettings()
        {
        }

        private KeywordPlanCampaignKeywordServiceSettings(KeywordPlanCampaignKeywordServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetKeywordPlanCampaignKeywordSettings = existing.GetKeywordPlanCampaignKeywordSettings;
            MutateKeywordPlanCampaignKeywordsSettings = existing.MutateKeywordPlanCampaignKeywordsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(KeywordPlanCampaignKeywordServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanCampaignKeywordServiceClient.GetKeywordPlanCampaignKeyword</c> and
        /// <c>KeywordPlanCampaignKeywordServiceClient.GetKeywordPlanCampaignKeywordAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetKeywordPlanCampaignKeywordSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanCampaignKeywordServiceClient.MutateKeywordPlanCampaignKeywords</c> and
        /// <c>KeywordPlanCampaignKeywordServiceClient.MutateKeywordPlanCampaignKeywordsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateKeywordPlanCampaignKeywordsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="KeywordPlanCampaignKeywordServiceSettings"/> object.</returns>
        public KeywordPlanCampaignKeywordServiceSettings Clone() => new KeywordPlanCampaignKeywordServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="KeywordPlanCampaignKeywordServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class KeywordPlanCampaignKeywordServiceClientBuilder : gaxgrpc::ClientBuilderBase<KeywordPlanCampaignKeywordServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public KeywordPlanCampaignKeywordServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref KeywordPlanCampaignKeywordServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<KeywordPlanCampaignKeywordServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override KeywordPlanCampaignKeywordServiceClient Build()
        {
            KeywordPlanCampaignKeywordServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<KeywordPlanCampaignKeywordServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<KeywordPlanCampaignKeywordServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private KeywordPlanCampaignKeywordServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return KeywordPlanCampaignKeywordServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<KeywordPlanCampaignKeywordServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return KeywordPlanCampaignKeywordServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => KeywordPlanCampaignKeywordServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            KeywordPlanCampaignKeywordServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => KeywordPlanCampaignKeywordServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>KeywordPlanCampaignKeywordService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Keyword Plan campaign keywords. KeywordPlanCampaign is
    /// required to add the campaign keywords. Only negative keywords are supported.
    /// A maximum of 1000 negative keywords are allowed per plan. This includes both
    /// campaign negative keywords and ad group negative keywords.
    /// </remarks>
    public abstract partial class KeywordPlanCampaignKeywordServiceClient
    {
        /// <summary>
        /// The default endpoint for the KeywordPlanCampaignKeywordService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default KeywordPlanCampaignKeywordService scopes.</summary>
        /// <remarks>
        /// The default KeywordPlanCampaignKeywordService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="KeywordPlanCampaignKeywordServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordPlanCampaignKeywordServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="KeywordPlanCampaignKeywordServiceClient"/>.</returns>
        public static stt::Task<KeywordPlanCampaignKeywordServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new KeywordPlanCampaignKeywordServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="KeywordPlanCampaignKeywordServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordPlanCampaignKeywordServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="KeywordPlanCampaignKeywordServiceClient"/>.</returns>
        public static KeywordPlanCampaignKeywordServiceClient Create() =>
            new KeywordPlanCampaignKeywordServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="KeywordPlanCampaignKeywordServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="KeywordPlanCampaignKeywordServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeywordPlanCampaignKeywordServiceClient"/>.</returns>
        internal static KeywordPlanCampaignKeywordServiceClient Create(grpccore::CallInvoker callInvoker, KeywordPlanCampaignKeywordServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient grpcClient = new KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient(callInvoker);
            return new KeywordPlanCampaignKeywordServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC KeywordPlanCampaignKeywordService client</summary>
        public virtual KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordPlanCampaignKeyword GetKeywordPlanCampaignKeyword(GetKeywordPlanCampaignKeywordRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanCampaignKeyword> GetKeywordPlanCampaignKeywordAsync(GetKeywordPlanCampaignKeywordRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanCampaignKeyword> GetKeywordPlanCampaignKeywordAsync(GetKeywordPlanCampaignKeywordRequest request, st::CancellationToken cancellationToken) =>
            GetKeywordPlanCampaignKeywordAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the plan to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordPlanCampaignKeyword GetKeywordPlanCampaignKeyword(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanCampaignKeyword(new GetKeywordPlanCampaignKeywordRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the plan to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanCampaignKeyword> GetKeywordPlanCampaignKeywordAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanCampaignKeywordAsync(new GetKeywordPlanCampaignKeywordRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the plan to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanCampaignKeyword> GetKeywordPlanCampaignKeywordAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetKeywordPlanCampaignKeywordAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the plan to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordPlanCampaignKeyword GetKeywordPlanCampaignKeyword(gagvr::KeywordPlanCampaignKeywordName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanCampaignKeyword(new GetKeywordPlanCampaignKeywordRequest
            {
                ResourceNameAsKeywordPlanCampaignKeywordName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the plan to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanCampaignKeyword> GetKeywordPlanCampaignKeywordAsync(gagvr::KeywordPlanCampaignKeywordName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanCampaignKeywordAsync(new GetKeywordPlanCampaignKeywordRequest
            {
                ResourceNameAsKeywordPlanCampaignKeywordName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the plan to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanCampaignKeyword> GetKeywordPlanCampaignKeywordAsync(gagvr::KeywordPlanCampaignKeywordName resourceName, st::CancellationToken cancellationToken) =>
            GetKeywordPlanCampaignKeywordAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes Keyword Plan campaign keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateKeywordPlanCampaignKeywordsResponse MutateKeywordPlanCampaignKeywords(MutateKeywordPlanCampaignKeywordsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes Keyword Plan campaign keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanCampaignKeywordsResponse> MutateKeywordPlanCampaignKeywordsAsync(MutateKeywordPlanCampaignKeywordsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes Keyword Plan campaign keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanCampaignKeywordsResponse> MutateKeywordPlanCampaignKeywordsAsync(MutateKeywordPlanCampaignKeywordsRequest request, st::CancellationToken cancellationToken) =>
            MutateKeywordPlanCampaignKeywordsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes Keyword Plan campaign keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan campaign
        /// keywords.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateKeywordPlanCampaignKeywordsResponse MutateKeywordPlanCampaignKeywords(string customerId, scg::IEnumerable<KeywordPlanCampaignKeywordOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateKeywordPlanCampaignKeywords(new MutateKeywordPlanCampaignKeywordsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan campaign keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan campaign
        /// keywords.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanCampaignKeywordsResponse> MutateKeywordPlanCampaignKeywordsAsync(string customerId, scg::IEnumerable<KeywordPlanCampaignKeywordOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateKeywordPlanCampaignKeywordsAsync(new MutateKeywordPlanCampaignKeywordsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan campaign keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan campaign
        /// keywords.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanCampaignKeywordsResponse> MutateKeywordPlanCampaignKeywordsAsync(string customerId, scg::IEnumerable<KeywordPlanCampaignKeywordOperation> operations, st::CancellationToken cancellationToken) =>
            MutateKeywordPlanCampaignKeywordsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>KeywordPlanCampaignKeywordService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Keyword Plan campaign keywords. KeywordPlanCampaign is
    /// required to add the campaign keywords. Only negative keywords are supported.
    /// A maximum of 1000 negative keywords are allowed per plan. This includes both
    /// campaign negative keywords and ad group negative keywords.
    /// </remarks>
    public sealed partial class KeywordPlanCampaignKeywordServiceClientImpl : KeywordPlanCampaignKeywordServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetKeywordPlanCampaignKeywordRequest, gagvr::KeywordPlanCampaignKeyword> _callGetKeywordPlanCampaignKeyword;

        private readonly gaxgrpc::ApiCall<MutateKeywordPlanCampaignKeywordsRequest, MutateKeywordPlanCampaignKeywordsResponse> _callMutateKeywordPlanCampaignKeywords;

        /// <summary>
        /// Constructs a client wrapper for the KeywordPlanCampaignKeywordService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="KeywordPlanCampaignKeywordServiceSettings"/> used within this client.
        /// </param>
        public KeywordPlanCampaignKeywordServiceClientImpl(KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient grpcClient, KeywordPlanCampaignKeywordServiceSettings settings)
        {
            GrpcClient = grpcClient;
            KeywordPlanCampaignKeywordServiceSettings effectiveSettings = settings ?? KeywordPlanCampaignKeywordServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetKeywordPlanCampaignKeyword = clientHelper.BuildApiCall<GetKeywordPlanCampaignKeywordRequest, gagvr::KeywordPlanCampaignKeyword>(grpcClient.GetKeywordPlanCampaignKeywordAsync, grpcClient.GetKeywordPlanCampaignKeyword, effectiveSettings.GetKeywordPlanCampaignKeywordSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetKeywordPlanCampaignKeyword);
            Modify_GetKeywordPlanCampaignKeywordApiCall(ref _callGetKeywordPlanCampaignKeyword);
            _callMutateKeywordPlanCampaignKeywords = clientHelper.BuildApiCall<MutateKeywordPlanCampaignKeywordsRequest, MutateKeywordPlanCampaignKeywordsResponse>(grpcClient.MutateKeywordPlanCampaignKeywordsAsync, grpcClient.MutateKeywordPlanCampaignKeywords, effectiveSettings.MutateKeywordPlanCampaignKeywordsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateKeywordPlanCampaignKeywords);
            Modify_MutateKeywordPlanCampaignKeywordsApiCall(ref _callMutateKeywordPlanCampaignKeywords);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetKeywordPlanCampaignKeywordApiCall(ref gaxgrpc::ApiCall<GetKeywordPlanCampaignKeywordRequest, gagvr::KeywordPlanCampaignKeyword> call);

        partial void Modify_MutateKeywordPlanCampaignKeywordsApiCall(ref gaxgrpc::ApiCall<MutateKeywordPlanCampaignKeywordsRequest, MutateKeywordPlanCampaignKeywordsResponse> call);

        partial void OnConstruction(KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient grpcClient, KeywordPlanCampaignKeywordServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC KeywordPlanCampaignKeywordService client</summary>
        public override KeywordPlanCampaignKeywordService.KeywordPlanCampaignKeywordServiceClient GrpcClient { get; }

        partial void Modify_GetKeywordPlanCampaignKeywordRequest(ref GetKeywordPlanCampaignKeywordRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateKeywordPlanCampaignKeywordsRequest(ref MutateKeywordPlanCampaignKeywordsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::KeywordPlanCampaignKeyword GetKeywordPlanCampaignKeyword(GetKeywordPlanCampaignKeywordRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanCampaignKeywordRequest(ref request, ref callSettings);
            return _callGetKeywordPlanCampaignKeyword.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::KeywordPlanCampaignKeyword> GetKeywordPlanCampaignKeywordAsync(GetKeywordPlanCampaignKeywordRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanCampaignKeywordRequest(ref request, ref callSettings);
            return _callGetKeywordPlanCampaignKeyword.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan campaign keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateKeywordPlanCampaignKeywordsResponse MutateKeywordPlanCampaignKeywords(MutateKeywordPlanCampaignKeywordsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlanCampaignKeywordsRequest(ref request, ref callSettings);
            return _callMutateKeywordPlanCampaignKeywords.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan campaign keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateKeywordPlanCampaignKeywordsResponse> MutateKeywordPlanCampaignKeywordsAsync(MutateKeywordPlanCampaignKeywordsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlanCampaignKeywordsRequest(ref request, ref callSettings);
            return _callMutateKeywordPlanCampaignKeywords.Async(request, callSettings);
        }
    }
}

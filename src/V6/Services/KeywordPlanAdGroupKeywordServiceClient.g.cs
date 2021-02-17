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
    /// <summary>Settings for <see cref="KeywordPlanAdGroupKeywordServiceClient"/> instances.</summary>
    public sealed partial class KeywordPlanAdGroupKeywordServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="KeywordPlanAdGroupKeywordServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="KeywordPlanAdGroupKeywordServiceSettings"/>.</returns>
        public static KeywordPlanAdGroupKeywordServiceSettings GetDefault() => new KeywordPlanAdGroupKeywordServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="KeywordPlanAdGroupKeywordServiceSettings"/> object with default settings.
        /// </summary>
        public KeywordPlanAdGroupKeywordServiceSettings()
        {
        }

        private KeywordPlanAdGroupKeywordServiceSettings(KeywordPlanAdGroupKeywordServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetKeywordPlanAdGroupKeywordSettings = existing.GetKeywordPlanAdGroupKeywordSettings;
            MutateKeywordPlanAdGroupKeywordsSettings = existing.MutateKeywordPlanAdGroupKeywordsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(KeywordPlanAdGroupKeywordServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanAdGroupKeywordServiceClient.GetKeywordPlanAdGroupKeyword</c> and
        /// <c>KeywordPlanAdGroupKeywordServiceClient.GetKeywordPlanAdGroupKeywordAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetKeywordPlanAdGroupKeywordSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanAdGroupKeywordServiceClient.MutateKeywordPlanAdGroupKeywords</c> and
        /// <c>KeywordPlanAdGroupKeywordServiceClient.MutateKeywordPlanAdGroupKeywordsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateKeywordPlanAdGroupKeywordsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="KeywordPlanAdGroupKeywordServiceSettings"/> object.</returns>
        public KeywordPlanAdGroupKeywordServiceSettings Clone() => new KeywordPlanAdGroupKeywordServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="KeywordPlanAdGroupKeywordServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class KeywordPlanAdGroupKeywordServiceClientBuilder : gaxgrpc::ClientBuilderBase<KeywordPlanAdGroupKeywordServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public KeywordPlanAdGroupKeywordServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref KeywordPlanAdGroupKeywordServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<KeywordPlanAdGroupKeywordServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override KeywordPlanAdGroupKeywordServiceClient Build()
        {
            KeywordPlanAdGroupKeywordServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<KeywordPlanAdGroupKeywordServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<KeywordPlanAdGroupKeywordServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private KeywordPlanAdGroupKeywordServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return KeywordPlanAdGroupKeywordServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<KeywordPlanAdGroupKeywordServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return KeywordPlanAdGroupKeywordServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => KeywordPlanAdGroupKeywordServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            KeywordPlanAdGroupKeywordServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => KeywordPlanAdGroupKeywordServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>KeywordPlanAdGroupKeywordService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Keyword Plan ad group keywords. KeywordPlanAdGroup is
    /// required to add ad group keywords. Positive and negative keywords are
    /// supported. A maximum of 10,000 positive keywords are allowed per keyword
    /// plan. A maximum of 1,000 negative keywords are allower per keyword plan. This
    /// includes campaign negative keywords and ad group negative keywords.
    /// </remarks>
    public abstract partial class KeywordPlanAdGroupKeywordServiceClient
    {
        /// <summary>
        /// The default endpoint for the KeywordPlanAdGroupKeywordService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default KeywordPlanAdGroupKeywordService scopes.</summary>
        /// <remarks>
        /// The default KeywordPlanAdGroupKeywordService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="KeywordPlanAdGroupKeywordServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordPlanAdGroupKeywordServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="KeywordPlanAdGroupKeywordServiceClient"/>.</returns>
        public static stt::Task<KeywordPlanAdGroupKeywordServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new KeywordPlanAdGroupKeywordServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="KeywordPlanAdGroupKeywordServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordPlanAdGroupKeywordServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="KeywordPlanAdGroupKeywordServiceClient"/>.</returns>
        public static KeywordPlanAdGroupKeywordServiceClient Create() =>
            new KeywordPlanAdGroupKeywordServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="KeywordPlanAdGroupKeywordServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="KeywordPlanAdGroupKeywordServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeywordPlanAdGroupKeywordServiceClient"/>.</returns>
        internal static KeywordPlanAdGroupKeywordServiceClient Create(grpccore::CallInvoker callInvoker, KeywordPlanAdGroupKeywordServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient grpcClient = new KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient(callInvoker);
            return new KeywordPlanAdGroupKeywordServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC KeywordPlanAdGroupKeywordService client</summary>
        public virtual KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Keyword Plan ad group keyword in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordPlanAdGroupKeyword GetKeywordPlanAdGroupKeyword(GetKeywordPlanAdGroupKeywordRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Keyword Plan ad group keyword in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanAdGroupKeyword> GetKeywordPlanAdGroupKeywordAsync(GetKeywordPlanAdGroupKeywordRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Keyword Plan ad group keyword in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanAdGroupKeyword> GetKeywordPlanAdGroupKeywordAsync(GetKeywordPlanAdGroupKeywordRequest request, st::CancellationToken cancellationToken) =>
            GetKeywordPlanAdGroupKeywordAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan ad group keyword in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group keyword to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordPlanAdGroupKeyword GetKeywordPlanAdGroupKeyword(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanAdGroupKeyword(new GetKeywordPlanAdGroupKeywordRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan ad group keyword in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group keyword to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanAdGroupKeyword> GetKeywordPlanAdGroupKeywordAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanAdGroupKeywordAsync(new GetKeywordPlanAdGroupKeywordRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan ad group keyword in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group keyword to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanAdGroupKeyword> GetKeywordPlanAdGroupKeywordAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetKeywordPlanAdGroupKeywordAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan ad group keyword in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group keyword to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordPlanAdGroupKeyword GetKeywordPlanAdGroupKeyword(gagvr::KeywordPlanAdGroupKeywordName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanAdGroupKeyword(new GetKeywordPlanAdGroupKeywordRequest
            {
                ResourceNameAsKeywordPlanAdGroupKeywordName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan ad group keyword in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group keyword to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanAdGroupKeyword> GetKeywordPlanAdGroupKeywordAsync(gagvr::KeywordPlanAdGroupKeywordName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanAdGroupKeywordAsync(new GetKeywordPlanAdGroupKeywordRequest
            {
                ResourceNameAsKeywordPlanAdGroupKeywordName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan ad group keyword in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group keyword to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanAdGroupKeyword> GetKeywordPlanAdGroupKeywordAsync(gagvr::KeywordPlanAdGroupKeywordName resourceName, st::CancellationToken cancellationToken) =>
            GetKeywordPlanAdGroupKeywordAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes Keyword Plan ad group keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateKeywordPlanAdGroupKeywordsResponse MutateKeywordPlanAdGroupKeywords(MutateKeywordPlanAdGroupKeywordsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes Keyword Plan ad group keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanAdGroupKeywordsResponse> MutateKeywordPlanAdGroupKeywordsAsync(MutateKeywordPlanAdGroupKeywordsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes Keyword Plan ad group keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanAdGroupKeywordsResponse> MutateKeywordPlanAdGroupKeywordsAsync(MutateKeywordPlanAdGroupKeywordsRequest request, st::CancellationToken cancellationToken) =>
            MutateKeywordPlanAdGroupKeywordsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes Keyword Plan ad group keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan ad group keywords are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan ad group
        /// keywords.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateKeywordPlanAdGroupKeywordsResponse MutateKeywordPlanAdGroupKeywords(string customerId, scg::IEnumerable<KeywordPlanAdGroupKeywordOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateKeywordPlanAdGroupKeywords(new MutateKeywordPlanAdGroupKeywordsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan ad group keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan ad group keywords are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan ad group
        /// keywords.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanAdGroupKeywordsResponse> MutateKeywordPlanAdGroupKeywordsAsync(string customerId, scg::IEnumerable<KeywordPlanAdGroupKeywordOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateKeywordPlanAdGroupKeywordsAsync(new MutateKeywordPlanAdGroupKeywordsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan ad group keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan ad group keywords are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan ad group
        /// keywords.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanAdGroupKeywordsResponse> MutateKeywordPlanAdGroupKeywordsAsync(string customerId, scg::IEnumerable<KeywordPlanAdGroupKeywordOperation> operations, st::CancellationToken cancellationToken) =>
            MutateKeywordPlanAdGroupKeywordsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>KeywordPlanAdGroupKeywordService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Keyword Plan ad group keywords. KeywordPlanAdGroup is
    /// required to add ad group keywords. Positive and negative keywords are
    /// supported. A maximum of 10,000 positive keywords are allowed per keyword
    /// plan. A maximum of 1,000 negative keywords are allower per keyword plan. This
    /// includes campaign negative keywords and ad group negative keywords.
    /// </remarks>
    public sealed partial class KeywordPlanAdGroupKeywordServiceClientImpl : KeywordPlanAdGroupKeywordServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetKeywordPlanAdGroupKeywordRequest, gagvr::KeywordPlanAdGroupKeyword> _callGetKeywordPlanAdGroupKeyword;

        private readonly gaxgrpc::ApiCall<MutateKeywordPlanAdGroupKeywordsRequest, MutateKeywordPlanAdGroupKeywordsResponse> _callMutateKeywordPlanAdGroupKeywords;

        /// <summary>
        /// Constructs a client wrapper for the KeywordPlanAdGroupKeywordService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="KeywordPlanAdGroupKeywordServiceSettings"/> used within this client.
        /// </param>
        public KeywordPlanAdGroupKeywordServiceClientImpl(KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient grpcClient, KeywordPlanAdGroupKeywordServiceSettings settings)
        {
            GrpcClient = grpcClient;
            KeywordPlanAdGroupKeywordServiceSettings effectiveSettings = settings ?? KeywordPlanAdGroupKeywordServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetKeywordPlanAdGroupKeyword = clientHelper.BuildApiCall<GetKeywordPlanAdGroupKeywordRequest, gagvr::KeywordPlanAdGroupKeyword>(grpcClient.GetKeywordPlanAdGroupKeywordAsync, grpcClient.GetKeywordPlanAdGroupKeyword, effectiveSettings.GetKeywordPlanAdGroupKeywordSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetKeywordPlanAdGroupKeyword);
            Modify_GetKeywordPlanAdGroupKeywordApiCall(ref _callGetKeywordPlanAdGroupKeyword);
            _callMutateKeywordPlanAdGroupKeywords = clientHelper.BuildApiCall<MutateKeywordPlanAdGroupKeywordsRequest, MutateKeywordPlanAdGroupKeywordsResponse>(grpcClient.MutateKeywordPlanAdGroupKeywordsAsync, grpcClient.MutateKeywordPlanAdGroupKeywords, effectiveSettings.MutateKeywordPlanAdGroupKeywordsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateKeywordPlanAdGroupKeywords);
            Modify_MutateKeywordPlanAdGroupKeywordsApiCall(ref _callMutateKeywordPlanAdGroupKeywords);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetKeywordPlanAdGroupKeywordApiCall(ref gaxgrpc::ApiCall<GetKeywordPlanAdGroupKeywordRequest, gagvr::KeywordPlanAdGroupKeyword> call);

        partial void Modify_MutateKeywordPlanAdGroupKeywordsApiCall(ref gaxgrpc::ApiCall<MutateKeywordPlanAdGroupKeywordsRequest, MutateKeywordPlanAdGroupKeywordsResponse> call);

        partial void OnConstruction(KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient grpcClient, KeywordPlanAdGroupKeywordServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC KeywordPlanAdGroupKeywordService client</summary>
        public override KeywordPlanAdGroupKeywordService.KeywordPlanAdGroupKeywordServiceClient GrpcClient { get; }

        partial void Modify_GetKeywordPlanAdGroupKeywordRequest(ref GetKeywordPlanAdGroupKeywordRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateKeywordPlanAdGroupKeywordsRequest(ref MutateKeywordPlanAdGroupKeywordsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested Keyword Plan ad group keyword in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::KeywordPlanAdGroupKeyword GetKeywordPlanAdGroupKeyword(GetKeywordPlanAdGroupKeywordRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanAdGroupKeywordRequest(ref request, ref callSettings);
            return _callGetKeywordPlanAdGroupKeyword.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Keyword Plan ad group keyword in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::KeywordPlanAdGroupKeyword> GetKeywordPlanAdGroupKeywordAsync(GetKeywordPlanAdGroupKeywordRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanAdGroupKeywordRequest(ref request, ref callSettings);
            return _callGetKeywordPlanAdGroupKeyword.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan ad group keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateKeywordPlanAdGroupKeywordsResponse MutateKeywordPlanAdGroupKeywords(MutateKeywordPlanAdGroupKeywordsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlanAdGroupKeywordsRequest(ref request, ref callSettings);
            return _callMutateKeywordPlanAdGroupKeywords.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan ad group keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateKeywordPlanAdGroupKeywordsResponse> MutateKeywordPlanAdGroupKeywordsAsync(MutateKeywordPlanAdGroupKeywordsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlanAdGroupKeywordsRequest(ref request, ref callSettings);
            return _callMutateKeywordPlanAdGroupKeywords.Async(request, callSettings);
        }
    }
}

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
    /// <summary>Settings for <see cref="KeywordPlanNegativeKeywordServiceClient"/> instances.</summary>
    public sealed partial class KeywordPlanNegativeKeywordServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="KeywordPlanNegativeKeywordServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="KeywordPlanNegativeKeywordServiceSettings"/>.</returns>
        public static KeywordPlanNegativeKeywordServiceSettings GetDefault() =>
            new KeywordPlanNegativeKeywordServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="KeywordPlanNegativeKeywordServiceSettings"/> object with default settings.
        /// </summary>
        public KeywordPlanNegativeKeywordServiceSettings()
        {
        }

        private KeywordPlanNegativeKeywordServiceSettings(KeywordPlanNegativeKeywordServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetKeywordPlanNegativeKeywordSettings = existing.GetKeywordPlanNegativeKeywordSettings;
            MutateKeywordPlanNegativeKeywordsSettings = existing.MutateKeywordPlanNegativeKeywordsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(KeywordPlanNegativeKeywordServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanNegativeKeywordServiceClient.GetKeywordPlanNegativeKeyword</c> and
        /// <c>KeywordPlanNegativeKeywordServiceClient.GetKeywordPlanNegativeKeywordAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetKeywordPlanNegativeKeywordSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanNegativeKeywordServiceClient.MutateKeywordPlanNegativeKeywords</c> and
        /// <c>KeywordPlanNegativeKeywordServiceClient.MutateKeywordPlanNegativeKeywordsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateKeywordPlanNegativeKeywordsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="KeywordPlanNegativeKeywordServiceSettings"/> object.</returns>
        public KeywordPlanNegativeKeywordServiceSettings Clone() => new KeywordPlanNegativeKeywordServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="KeywordPlanNegativeKeywordServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class KeywordPlanNegativeKeywordServiceClientBuilder : gaxgrpc::ClientBuilderBase<KeywordPlanNegativeKeywordServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public KeywordPlanNegativeKeywordServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref KeywordPlanNegativeKeywordServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<KeywordPlanNegativeKeywordServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override KeywordPlanNegativeKeywordServiceClient Build()
        {
            KeywordPlanNegativeKeywordServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<KeywordPlanNegativeKeywordServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<KeywordPlanNegativeKeywordServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private KeywordPlanNegativeKeywordServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return KeywordPlanNegativeKeywordServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<KeywordPlanNegativeKeywordServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return KeywordPlanNegativeKeywordServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => KeywordPlanNegativeKeywordServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            KeywordPlanNegativeKeywordServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => KeywordPlanNegativeKeywordServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>KeywordPlanNegativeKeywordService client wrapper, for convenient use.</summary>
    public abstract partial class KeywordPlanNegativeKeywordServiceClient
    {
        /// <summary>
        /// The default endpoint for the KeywordPlanNegativeKeywordService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default KeywordPlanNegativeKeywordService scopes.</summary>
        /// <remarks>The default KeywordPlanNegativeKeywordService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="KeywordPlanNegativeKeywordServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordPlanNegativeKeywordServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="KeywordPlanNegativeKeywordServiceClient"/>.</returns>
        public static stt::Task<KeywordPlanNegativeKeywordServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new KeywordPlanNegativeKeywordServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="KeywordPlanNegativeKeywordServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordPlanNegativeKeywordServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="KeywordPlanNegativeKeywordServiceClient"/>.</returns>
        public static KeywordPlanNegativeKeywordServiceClient Create() =>
            new KeywordPlanNegativeKeywordServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="KeywordPlanNegativeKeywordServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="KeywordPlanNegativeKeywordServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeywordPlanNegativeKeywordServiceClient"/>.</returns>
        internal static KeywordPlanNegativeKeywordServiceClient Create(grpccore::CallInvoker callInvoker, KeywordPlanNegativeKeywordServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient grpcClient = new KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient(callInvoker);
            return new KeywordPlanNegativeKeywordServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC KeywordPlanNegativeKeywordService client</summary>
        public virtual KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordPlanNegativeKeyword GetKeywordPlanNegativeKeyword(GetKeywordPlanNegativeKeywordRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanNegativeKeyword> GetKeywordPlanNegativeKeywordAsync(GetKeywordPlanNegativeKeywordRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanNegativeKeyword> GetKeywordPlanNegativeKeywordAsync(GetKeywordPlanNegativeKeywordRequest request, st::CancellationToken cancellationToken) =>
            GetKeywordPlanNegativeKeywordAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the plan to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordPlanNegativeKeyword GetKeywordPlanNegativeKeyword(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanNegativeKeyword(new GetKeywordPlanNegativeKeywordRequest
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
        public virtual stt::Task<gagvr::KeywordPlanNegativeKeyword> GetKeywordPlanNegativeKeywordAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanNegativeKeywordAsync(new GetKeywordPlanNegativeKeywordRequest
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
        public virtual stt::Task<gagvr::KeywordPlanNegativeKeyword> GetKeywordPlanNegativeKeywordAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetKeywordPlanNegativeKeywordAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the plan to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordPlanNegativeKeyword GetKeywordPlanNegativeKeyword(gagvr::KeywordPlanNegativeKeywordName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanNegativeKeyword(new GetKeywordPlanNegativeKeywordRequest
            {
                ResourceNameAsKeywordPlanNegativeKeywordName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the plan to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanNegativeKeyword> GetKeywordPlanNegativeKeywordAsync(gagvr::KeywordPlanNegativeKeywordName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanNegativeKeywordAsync(new GetKeywordPlanNegativeKeywordRequest
            {
                ResourceNameAsKeywordPlanNegativeKeywordName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the plan to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanNegativeKeyword> GetKeywordPlanNegativeKeywordAsync(gagvr::KeywordPlanNegativeKeywordName resourceName, st::CancellationToken cancellationToken) =>
            GetKeywordPlanNegativeKeywordAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateKeywordPlanNegativeKeywordsResponse MutateKeywordPlanNegativeKeywords(MutateKeywordPlanNegativeKeywordsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanNegativeKeywordsResponse> MutateKeywordPlanNegativeKeywordsAsync(MutateKeywordPlanNegativeKeywordsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanNegativeKeywordsResponse> MutateKeywordPlanNegativeKeywordsAsync(MutateKeywordPlanNegativeKeywordsRequest request, st::CancellationToken cancellationToken) =>
            MutateKeywordPlanNegativeKeywordsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose negative keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan negative
        /// keywords.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateKeywordPlanNegativeKeywordsResponse MutateKeywordPlanNegativeKeywords(string customerId, scg::IEnumerable<KeywordPlanNegativeKeywordOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateKeywordPlanNegativeKeywords(new MutateKeywordPlanNegativeKeywordsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose negative keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan negative
        /// keywords.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanNegativeKeywordsResponse> MutateKeywordPlanNegativeKeywordsAsync(string customerId, scg::IEnumerable<KeywordPlanNegativeKeywordOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateKeywordPlanNegativeKeywordsAsync(new MutateKeywordPlanNegativeKeywordsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose negative keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan negative
        /// keywords.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanNegativeKeywordsResponse> MutateKeywordPlanNegativeKeywordsAsync(string customerId, scg::IEnumerable<KeywordPlanNegativeKeywordOperation> operations, st::CancellationToken cancellationToken) =>
            MutateKeywordPlanNegativeKeywordsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>KeywordPlanNegativeKeywordService client wrapper implementation, for convenient use.</summary>
    public sealed partial class KeywordPlanNegativeKeywordServiceClientImpl : KeywordPlanNegativeKeywordServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetKeywordPlanNegativeKeywordRequest, gagvr::KeywordPlanNegativeKeyword> _callGetKeywordPlanNegativeKeyword;

        private readonly gaxgrpc::ApiCall<MutateKeywordPlanNegativeKeywordsRequest, MutateKeywordPlanNegativeKeywordsResponse> _callMutateKeywordPlanNegativeKeywords;

        /// <summary>
        /// Constructs a client wrapper for the KeywordPlanNegativeKeywordService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="KeywordPlanNegativeKeywordServiceSettings"/> used within this client.
        /// </param>
        public KeywordPlanNegativeKeywordServiceClientImpl(KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient grpcClient, KeywordPlanNegativeKeywordServiceSettings settings)
        {
            GrpcClient = grpcClient;
            KeywordPlanNegativeKeywordServiceSettings effectiveSettings = settings ?? KeywordPlanNegativeKeywordServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetKeywordPlanNegativeKeyword = clientHelper.BuildApiCall<GetKeywordPlanNegativeKeywordRequest, gagvr::KeywordPlanNegativeKeyword>(grpcClient.GetKeywordPlanNegativeKeywordAsync, grpcClient.GetKeywordPlanNegativeKeyword, effectiveSettings.GetKeywordPlanNegativeKeywordSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetKeywordPlanNegativeKeyword);
            Modify_GetKeywordPlanNegativeKeywordApiCall(ref _callGetKeywordPlanNegativeKeyword);
            _callMutateKeywordPlanNegativeKeywords = clientHelper.BuildApiCall<MutateKeywordPlanNegativeKeywordsRequest, MutateKeywordPlanNegativeKeywordsResponse>(grpcClient.MutateKeywordPlanNegativeKeywordsAsync, grpcClient.MutateKeywordPlanNegativeKeywords, effectiveSettings.MutateKeywordPlanNegativeKeywordsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateKeywordPlanNegativeKeywords);
            Modify_MutateKeywordPlanNegativeKeywordsApiCall(ref _callMutateKeywordPlanNegativeKeywords);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetKeywordPlanNegativeKeywordApiCall(ref gaxgrpc::ApiCall<GetKeywordPlanNegativeKeywordRequest, gagvr::KeywordPlanNegativeKeyword> call);

        partial void Modify_MutateKeywordPlanNegativeKeywordsApiCall(ref gaxgrpc::ApiCall<MutateKeywordPlanNegativeKeywordsRequest, MutateKeywordPlanNegativeKeywordsResponse> call);

        partial void OnConstruction(KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient grpcClient, KeywordPlanNegativeKeywordServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC KeywordPlanNegativeKeywordService client</summary>
        public override KeywordPlanNegativeKeywordService.KeywordPlanNegativeKeywordServiceClient GrpcClient { get; }

        partial void Modify_GetKeywordPlanNegativeKeywordRequest(ref GetKeywordPlanNegativeKeywordRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateKeywordPlanNegativeKeywordsRequest(ref MutateKeywordPlanNegativeKeywordsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::KeywordPlanNegativeKeyword GetKeywordPlanNegativeKeyword(GetKeywordPlanNegativeKeywordRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanNegativeKeywordRequest(ref request, ref callSettings);
            return _callGetKeywordPlanNegativeKeyword.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested plan in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::KeywordPlanNegativeKeyword> GetKeywordPlanNegativeKeywordAsync(GetKeywordPlanNegativeKeywordRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanNegativeKeywordRequest(ref request, ref callSettings);
            return _callGetKeywordPlanNegativeKeyword.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateKeywordPlanNegativeKeywordsResponse MutateKeywordPlanNegativeKeywords(MutateKeywordPlanNegativeKeywordsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlanNegativeKeywordsRequest(ref request, ref callSettings);
            return _callMutateKeywordPlanNegativeKeywords.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan negative keywords. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateKeywordPlanNegativeKeywordsResponse> MutateKeywordPlanNegativeKeywordsAsync(MutateKeywordPlanNegativeKeywordsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlanNegativeKeywordsRequest(ref request, ref callSettings);
            return _callMutateKeywordPlanNegativeKeywords.Async(request, callSettings);
        }
    }
}

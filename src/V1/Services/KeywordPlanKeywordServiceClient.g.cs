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

using gagvr = Google.Ads.GoogleAds.V1.Resources;
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

namespace Google.Ads.GoogleAds.V1.Services
{
    /// <summary>Settings for <see cref="KeywordPlanKeywordServiceClient"/> instances.</summary>
    public sealed partial class KeywordPlanKeywordServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="KeywordPlanKeywordServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="KeywordPlanKeywordServiceSettings"/>.</returns>
        public static KeywordPlanKeywordServiceSettings GetDefault() => new KeywordPlanKeywordServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="KeywordPlanKeywordServiceSettings"/> object with default settings.
        /// </summary>
        public KeywordPlanKeywordServiceSettings()
        {
        }

        private KeywordPlanKeywordServiceSettings(KeywordPlanKeywordServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetKeywordPlanKeywordSettings = existing.GetKeywordPlanKeywordSettings;
            MutateKeywordPlanKeywordsSettings = existing.MutateKeywordPlanKeywordsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(KeywordPlanKeywordServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanKeywordServiceClient.GetKeywordPlanKeyword</c> and
        /// <c>KeywordPlanKeywordServiceClient.GetKeywordPlanKeywordAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetKeywordPlanKeywordSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanKeywordServiceClient.MutateKeywordPlanKeywords</c> and
        /// <c>KeywordPlanKeywordServiceClient.MutateKeywordPlanKeywordsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateKeywordPlanKeywordsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="KeywordPlanKeywordServiceSettings"/> object.</returns>
        public KeywordPlanKeywordServiceSettings Clone() => new KeywordPlanKeywordServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="KeywordPlanKeywordServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class KeywordPlanKeywordServiceClientBuilder : gaxgrpc::ClientBuilderBase<KeywordPlanKeywordServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public KeywordPlanKeywordServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref KeywordPlanKeywordServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<KeywordPlanKeywordServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override KeywordPlanKeywordServiceClient Build()
        {
            KeywordPlanKeywordServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<KeywordPlanKeywordServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<KeywordPlanKeywordServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private KeywordPlanKeywordServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return KeywordPlanKeywordServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<KeywordPlanKeywordServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return KeywordPlanKeywordServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => KeywordPlanKeywordServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => KeywordPlanKeywordServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => KeywordPlanKeywordServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>KeywordPlanKeywordService client wrapper, for convenient use.</summary>
    public abstract partial class KeywordPlanKeywordServiceClient
    {
        /// <summary>
        /// The default endpoint for the KeywordPlanKeywordService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default KeywordPlanKeywordService scopes.</summary>
        /// <remarks>The default KeywordPlanKeywordService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="KeywordPlanKeywordServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordPlanKeywordServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="KeywordPlanKeywordServiceClient"/>.</returns>
        public static stt::Task<KeywordPlanKeywordServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new KeywordPlanKeywordServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="KeywordPlanKeywordServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordPlanKeywordServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="KeywordPlanKeywordServiceClient"/>.</returns>
        public static KeywordPlanKeywordServiceClient Create() => new KeywordPlanKeywordServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="KeywordPlanKeywordServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="KeywordPlanKeywordServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeywordPlanKeywordServiceClient"/>.</returns>
        internal static KeywordPlanKeywordServiceClient Create(grpccore::CallInvoker callInvoker, KeywordPlanKeywordServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            KeywordPlanKeywordService.KeywordPlanKeywordServiceClient grpcClient = new KeywordPlanKeywordService.KeywordPlanKeywordServiceClient(callInvoker);
            return new KeywordPlanKeywordServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC KeywordPlanKeywordService client</summary>
        public virtual KeywordPlanKeywordService.KeywordPlanKeywordServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordPlanKeyword GetKeywordPlanKeyword(GetKeywordPlanKeywordRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanKeyword> GetKeywordPlanKeywordAsync(GetKeywordPlanKeywordRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanKeyword> GetKeywordPlanKeywordAsync(GetKeywordPlanKeywordRequest request, st::CancellationToken cancellationToken) =>
            GetKeywordPlanKeywordAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group keyword to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordPlanKeyword GetKeywordPlanKeyword(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanKeyword(new GetKeywordPlanKeywordRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group keyword to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanKeyword> GetKeywordPlanKeywordAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanKeywordAsync(new GetKeywordPlanKeywordRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group keyword to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanKeyword> GetKeywordPlanKeywordAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetKeywordPlanKeywordAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group keyword to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordPlanKeyword GetKeywordPlanKeyword(gagvr::KeywordPlanKeywordName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanKeyword(new GetKeywordPlanKeywordRequest
            {
                ResourceNameAsKeywordPlanKeywordName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group keyword to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanKeyword> GetKeywordPlanKeywordAsync(gagvr::KeywordPlanKeywordName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanKeywordAsync(new GetKeywordPlanKeywordRequest
            {
                ResourceNameAsKeywordPlanKeywordName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group keyword to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlanKeyword> GetKeywordPlanKeywordAsync(gagvr::KeywordPlanKeywordName resourceName, st::CancellationToken cancellationToken) =>
            GetKeywordPlanKeywordAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateKeywordPlanKeywordsResponse MutateKeywordPlanKeywords(MutateKeywordPlanKeywordsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanKeywordsResponse> MutateKeywordPlanKeywordsAsync(MutateKeywordPlanKeywordsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanKeywordsResponse> MutateKeywordPlanKeywordsAsync(MutateKeywordPlanKeywordsRequest request, st::CancellationToken cancellationToken) =>
            MutateKeywordPlanKeywordsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan keywords.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateKeywordPlanKeywordsResponse MutateKeywordPlanKeywords(string customerId, scg::IEnumerable<KeywordPlanKeywordOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateKeywordPlanKeywords(new MutateKeywordPlanKeywordsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan keywords.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanKeywordsResponse> MutateKeywordPlanKeywordsAsync(string customerId, scg::IEnumerable<KeywordPlanKeywordOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateKeywordPlanKeywordsAsync(new MutateKeywordPlanKeywordsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan keywords are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan keywords.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanKeywordsResponse> MutateKeywordPlanKeywordsAsync(string customerId, scg::IEnumerable<KeywordPlanKeywordOperation> operations, st::CancellationToken cancellationToken) =>
            MutateKeywordPlanKeywordsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>KeywordPlanKeywordService client wrapper implementation, for convenient use.</summary>
    public sealed partial class KeywordPlanKeywordServiceClientImpl : KeywordPlanKeywordServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetKeywordPlanKeywordRequest, gagvr::KeywordPlanKeyword> _callGetKeywordPlanKeyword;

        private readonly gaxgrpc::ApiCall<MutateKeywordPlanKeywordsRequest, MutateKeywordPlanKeywordsResponse> _callMutateKeywordPlanKeywords;

        /// <summary>
        /// Constructs a client wrapper for the KeywordPlanKeywordService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="KeywordPlanKeywordServiceSettings"/> used within this client.
        /// </param>
        public KeywordPlanKeywordServiceClientImpl(KeywordPlanKeywordService.KeywordPlanKeywordServiceClient grpcClient, KeywordPlanKeywordServiceSettings settings)
        {
            GrpcClient = grpcClient;
            KeywordPlanKeywordServiceSettings effectiveSettings = settings ?? KeywordPlanKeywordServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetKeywordPlanKeyword = clientHelper.BuildApiCall<GetKeywordPlanKeywordRequest, gagvr::KeywordPlanKeyword>(grpcClient.GetKeywordPlanKeywordAsync, grpcClient.GetKeywordPlanKeyword, effectiveSettings.GetKeywordPlanKeywordSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetKeywordPlanKeyword);
            Modify_GetKeywordPlanKeywordApiCall(ref _callGetKeywordPlanKeyword);
            _callMutateKeywordPlanKeywords = clientHelper.BuildApiCall<MutateKeywordPlanKeywordsRequest, MutateKeywordPlanKeywordsResponse>(grpcClient.MutateKeywordPlanKeywordsAsync, grpcClient.MutateKeywordPlanKeywords, effectiveSettings.MutateKeywordPlanKeywordsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateKeywordPlanKeywords);
            Modify_MutateKeywordPlanKeywordsApiCall(ref _callMutateKeywordPlanKeywords);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetKeywordPlanKeywordApiCall(ref gaxgrpc::ApiCall<GetKeywordPlanKeywordRequest, gagvr::KeywordPlanKeyword> call);

        partial void Modify_MutateKeywordPlanKeywordsApiCall(ref gaxgrpc::ApiCall<MutateKeywordPlanKeywordsRequest, MutateKeywordPlanKeywordsResponse> call);

        partial void OnConstruction(KeywordPlanKeywordService.KeywordPlanKeywordServiceClient grpcClient, KeywordPlanKeywordServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC KeywordPlanKeywordService client</summary>
        public override KeywordPlanKeywordService.KeywordPlanKeywordServiceClient GrpcClient { get; }

        partial void Modify_GetKeywordPlanKeywordRequest(ref GetKeywordPlanKeywordRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateKeywordPlanKeywordsRequest(ref MutateKeywordPlanKeywordsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::KeywordPlanKeyword GetKeywordPlanKeyword(GetKeywordPlanKeywordRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanKeywordRequest(ref request, ref callSettings);
            return _callGetKeywordPlanKeyword.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Keyword Plan keyword in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::KeywordPlanKeyword> GetKeywordPlanKeywordAsync(GetKeywordPlanKeywordRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanKeywordRequest(ref request, ref callSettings);
            return _callGetKeywordPlanKeyword.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateKeywordPlanKeywordsResponse MutateKeywordPlanKeywords(MutateKeywordPlanKeywordsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlanKeywordsRequest(ref request, ref callSettings);
            return _callMutateKeywordPlanKeywords.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan keywords. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateKeywordPlanKeywordsResponse> MutateKeywordPlanKeywordsAsync(MutateKeywordPlanKeywordsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlanKeywordsRequest(ref request, ref callSettings);
            return _callMutateKeywordPlanKeywords.Async(request, callSettings);
        }
    }
}

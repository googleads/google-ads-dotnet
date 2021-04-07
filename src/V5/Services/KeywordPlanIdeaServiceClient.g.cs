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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V5.Services
{
    /// <summary>Settings for <see cref="KeywordPlanIdeaServiceClient"/> instances.</summary>
    public sealed partial class KeywordPlanIdeaServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="KeywordPlanIdeaServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="KeywordPlanIdeaServiceSettings"/>.</returns>
        public static KeywordPlanIdeaServiceSettings GetDefault() => new KeywordPlanIdeaServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="KeywordPlanIdeaServiceSettings"/> object with default settings.
        /// </summary>
        public KeywordPlanIdeaServiceSettings()
        {
        }

        private KeywordPlanIdeaServiceSettings(KeywordPlanIdeaServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GenerateKeywordIdeasSettings = existing.GenerateKeywordIdeasSettings;
            OnCopy(existing);
        }

        partial void OnCopy(KeywordPlanIdeaServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanIdeaServiceClient.GenerateKeywordIdeas</c> and
        /// <c>KeywordPlanIdeaServiceClient.GenerateKeywordIdeasAsync</c>.
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
        public gaxgrpc::CallSettings GenerateKeywordIdeasSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="KeywordPlanIdeaServiceSettings"/> object.</returns>
        public KeywordPlanIdeaServiceSettings Clone() => new KeywordPlanIdeaServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="KeywordPlanIdeaServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class KeywordPlanIdeaServiceClientBuilder : gaxgrpc::ClientBuilderBase<KeywordPlanIdeaServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public KeywordPlanIdeaServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref KeywordPlanIdeaServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<KeywordPlanIdeaServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override KeywordPlanIdeaServiceClient Build()
        {
            KeywordPlanIdeaServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<KeywordPlanIdeaServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<KeywordPlanIdeaServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private KeywordPlanIdeaServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return KeywordPlanIdeaServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<KeywordPlanIdeaServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return KeywordPlanIdeaServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => KeywordPlanIdeaServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => KeywordPlanIdeaServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => KeywordPlanIdeaServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>KeywordPlanIdeaService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to generate keyword ideas.
    /// </remarks>
    public abstract partial class KeywordPlanIdeaServiceClient
    {
        /// <summary>
        /// The default endpoint for the KeywordPlanIdeaService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default KeywordPlanIdeaService scopes.</summary>
        /// <remarks>
        /// The default KeywordPlanIdeaService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="KeywordPlanIdeaServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordPlanIdeaServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="KeywordPlanIdeaServiceClient"/>.</returns>
        public static stt::Task<KeywordPlanIdeaServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new KeywordPlanIdeaServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="KeywordPlanIdeaServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordPlanIdeaServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="KeywordPlanIdeaServiceClient"/>.</returns>
        public static KeywordPlanIdeaServiceClient Create() => new KeywordPlanIdeaServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="KeywordPlanIdeaServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="KeywordPlanIdeaServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeywordPlanIdeaServiceClient"/>.</returns>
        internal static KeywordPlanIdeaServiceClient Create(grpccore::CallInvoker callInvoker, KeywordPlanIdeaServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            KeywordPlanIdeaService.KeywordPlanIdeaServiceClient grpcClient = new KeywordPlanIdeaService.KeywordPlanIdeaServiceClient(callInvoker);
            return new KeywordPlanIdeaServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC KeywordPlanIdeaService client</summary>
        public virtual KeywordPlanIdeaService.KeywordPlanIdeaServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of keyword ideas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GenerateKeywordIdeaResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<GenerateKeywordIdeaResponse, GenerateKeywordIdeaResult> GenerateKeywordIdeas(GenerateKeywordIdeasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of keyword ideas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GenerateKeywordIdeaResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<GenerateKeywordIdeaResponse, GenerateKeywordIdeaResult> GenerateKeywordIdeasAsync(GenerateKeywordIdeasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>KeywordPlanIdeaService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to generate keyword ideas.
    /// </remarks>
    public sealed partial class KeywordPlanIdeaServiceClientImpl : KeywordPlanIdeaServiceClient
    {
        private readonly gaxgrpc::ApiCall<GenerateKeywordIdeasRequest, GenerateKeywordIdeaResponse> _callGenerateKeywordIdeas;

        /// <summary>
        /// Constructs a client wrapper for the KeywordPlanIdeaService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="KeywordPlanIdeaServiceSettings"/> used within this client.
        /// </param>
        public KeywordPlanIdeaServiceClientImpl(KeywordPlanIdeaService.KeywordPlanIdeaServiceClient grpcClient, KeywordPlanIdeaServiceSettings settings)
        {
            GrpcClient = grpcClient;
            KeywordPlanIdeaServiceSettings effectiveSettings = settings ?? KeywordPlanIdeaServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGenerateKeywordIdeas = clientHelper.BuildApiCall<GenerateKeywordIdeasRequest, GenerateKeywordIdeaResponse>(grpcClient.GenerateKeywordIdeasAsync, grpcClient.GenerateKeywordIdeas, effectiveSettings.GenerateKeywordIdeasSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGenerateKeywordIdeas);
            Modify_GenerateKeywordIdeasApiCall(ref _callGenerateKeywordIdeas);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GenerateKeywordIdeasApiCall(ref gaxgrpc::ApiCall<GenerateKeywordIdeasRequest, GenerateKeywordIdeaResponse> call);

        partial void OnConstruction(KeywordPlanIdeaService.KeywordPlanIdeaServiceClient grpcClient, KeywordPlanIdeaServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC KeywordPlanIdeaService client</summary>
        public override KeywordPlanIdeaService.KeywordPlanIdeaServiceClient GrpcClient { get; }

        partial void Modify_GenerateKeywordIdeasRequest(ref GenerateKeywordIdeasRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns a list of keyword ideas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GenerateKeywordIdeaResult"/> resources.</returns>
        public override gax::PagedEnumerable<GenerateKeywordIdeaResponse, GenerateKeywordIdeaResult> GenerateKeywordIdeas(GenerateKeywordIdeasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateKeywordIdeasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<GenerateKeywordIdeasRequest, GenerateKeywordIdeaResponse, GenerateKeywordIdeaResult>(_callGenerateKeywordIdeas, request, callSettings);
        }

        /// <summary>
        /// Returns a list of keyword ideas.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GenerateKeywordIdeaResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<GenerateKeywordIdeaResponse, GenerateKeywordIdeaResult> GenerateKeywordIdeasAsync(GenerateKeywordIdeasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateKeywordIdeasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<GenerateKeywordIdeasRequest, GenerateKeywordIdeaResponse, GenerateKeywordIdeaResult>(_callGenerateKeywordIdeas, request, callSettings);
        }
    }

    public partial class GenerateKeywordIdeasRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class GenerateKeywordIdeaResponse : gaxgrpc::IPageResponse<GenerateKeywordIdeaResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GenerateKeywordIdeaResult> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

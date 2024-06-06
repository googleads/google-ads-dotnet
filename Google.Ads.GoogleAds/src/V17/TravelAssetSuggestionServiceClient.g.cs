// Copyright 2024 Google LLC
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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Ads.GoogleAds.V17.Services
{
    /// <summary>Settings for <see cref="TravelAssetSuggestionServiceClient"/> instances.</summary>
    public sealed partial class TravelAssetSuggestionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TravelAssetSuggestionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TravelAssetSuggestionServiceSettings"/>.</returns>
        public static TravelAssetSuggestionServiceSettings GetDefault() => new TravelAssetSuggestionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="TravelAssetSuggestionServiceSettings"/> object with default settings.
        /// </summary>
        public TravelAssetSuggestionServiceSettings()
        {
        }

        private TravelAssetSuggestionServiceSettings(TravelAssetSuggestionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SuggestTravelAssetsSettings = existing.SuggestTravelAssetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TravelAssetSuggestionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TravelAssetSuggestionServiceClient.SuggestTravelAssets</c> and
        /// <c>TravelAssetSuggestionServiceClient.SuggestTravelAssetsAsync</c>.
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
        public gaxgrpc::CallSettings SuggestTravelAssetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TravelAssetSuggestionServiceSettings"/> object.</returns>
        public TravelAssetSuggestionServiceSettings Clone() => new TravelAssetSuggestionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TravelAssetSuggestionServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class TravelAssetSuggestionServiceClientBuilder : gaxgrpc::ClientBuilderBase<TravelAssetSuggestionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TravelAssetSuggestionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TravelAssetSuggestionServiceClientBuilder() : base(TravelAssetSuggestionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TravelAssetSuggestionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TravelAssetSuggestionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TravelAssetSuggestionServiceClient Build()
        {
            TravelAssetSuggestionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TravelAssetSuggestionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TravelAssetSuggestionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TravelAssetSuggestionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TravelAssetSuggestionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TravelAssetSuggestionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TravelAssetSuggestionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TravelAssetSuggestionServiceClient.ChannelPool;
    }

    /// <summary>TravelAssetSuggestionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to retrieve Travel asset suggestions.
    /// </remarks>
    public abstract partial class TravelAssetSuggestionServiceClient
    {
        /// <summary>
        /// The default endpoint for the TravelAssetSuggestionService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default TravelAssetSuggestionService scopes.</summary>
        /// <remarks>
        /// The default TravelAssetSuggestionService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TravelAssetSuggestionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TravelAssetSuggestionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="TravelAssetSuggestionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TravelAssetSuggestionServiceClient"/>.</returns>
        public static stt::Task<TravelAssetSuggestionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TravelAssetSuggestionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TravelAssetSuggestionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="TravelAssetSuggestionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TravelAssetSuggestionServiceClient"/>.</returns>
        public static TravelAssetSuggestionServiceClient Create() => new TravelAssetSuggestionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TravelAssetSuggestionServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TravelAssetSuggestionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TravelAssetSuggestionServiceClient"/>.</returns>
        internal static TravelAssetSuggestionServiceClient Create(grpccore::CallInvoker callInvoker, TravelAssetSuggestionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TravelAssetSuggestionService.TravelAssetSuggestionServiceClient grpcClient = new TravelAssetSuggestionService.TravelAssetSuggestionServiceClient(callInvoker);
            return new TravelAssetSuggestionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TravelAssetSuggestionService client</summary>
        public virtual TravelAssetSuggestionService.TravelAssetSuggestionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns Travel Asset suggestions. Asset
        /// suggestions are returned on a best-effort basis. There are no guarantees
        /// that all possible asset types will be returned for any given hotel
        /// property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestTravelAssetsResponse SuggestTravelAssets(SuggestTravelAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns Travel Asset suggestions. Asset
        /// suggestions are returned on a best-effort basis. There are no guarantees
        /// that all possible asset types will be returned for any given hotel
        /// property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestTravelAssetsResponse> SuggestTravelAssetsAsync(SuggestTravelAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns Travel Asset suggestions. Asset
        /// suggestions are returned on a best-effort basis. There are no guarantees
        /// that all possible asset types will be returned for any given hotel
        /// property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestTravelAssetsResponse> SuggestTravelAssetsAsync(SuggestTravelAssetsRequest request, st::CancellationToken cancellationToken) =>
            SuggestTravelAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns Travel Asset suggestions. Asset
        /// suggestions are returned on a best-effort basis. There are no guarantees
        /// that all possible asset types will be returned for any given hotel
        /// property.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="languageOption">
        /// Required. The language specifications in BCP 47 format (for example, en-US,
        /// zh-CN, etc.) for the asset suggestions. Text will be in this language.
        /// Usually matches one of the campaign target languages.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestTravelAssetsResponse SuggestTravelAssets(string customerId, string languageOption, gaxgrpc::CallSettings callSettings = null) =>
            SuggestTravelAssets(new SuggestTravelAssetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                LanguageOption = gax::GaxPreconditions.CheckNotNullOrEmpty(languageOption, nameof(languageOption)),
            }, callSettings);

        /// <summary>
        /// Returns Travel Asset suggestions. Asset
        /// suggestions are returned on a best-effort basis. There are no guarantees
        /// that all possible asset types will be returned for any given hotel
        /// property.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="languageOption">
        /// Required. The language specifications in BCP 47 format (for example, en-US,
        /// zh-CN, etc.) for the asset suggestions. Text will be in this language.
        /// Usually matches one of the campaign target languages.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestTravelAssetsResponse> SuggestTravelAssetsAsync(string customerId, string languageOption, gaxgrpc::CallSettings callSettings = null) =>
            SuggestTravelAssetsAsync(new SuggestTravelAssetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                LanguageOption = gax::GaxPreconditions.CheckNotNullOrEmpty(languageOption, nameof(languageOption)),
            }, callSettings);

        /// <summary>
        /// Returns Travel Asset suggestions. Asset
        /// suggestions are returned on a best-effort basis. There are no guarantees
        /// that all possible asset types will be returned for any given hotel
        /// property.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="languageOption">
        /// Required. The language specifications in BCP 47 format (for example, en-US,
        /// zh-CN, etc.) for the asset suggestions. Text will be in this language.
        /// Usually matches one of the campaign target languages.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestTravelAssetsResponse> SuggestTravelAssetsAsync(string customerId, string languageOption, st::CancellationToken cancellationToken) =>
            SuggestTravelAssetsAsync(customerId, languageOption, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TravelAssetSuggestionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to retrieve Travel asset suggestions.
    /// </remarks>
    public sealed partial class TravelAssetSuggestionServiceClientImpl : TravelAssetSuggestionServiceClient
    {
        private readonly gaxgrpc::ApiCall<SuggestTravelAssetsRequest, SuggestTravelAssetsResponse> _callSuggestTravelAssets;

        /// <summary>
        /// Constructs a client wrapper for the TravelAssetSuggestionService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="TravelAssetSuggestionServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TravelAssetSuggestionServiceClientImpl(TravelAssetSuggestionService.TravelAssetSuggestionServiceClient grpcClient, TravelAssetSuggestionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TravelAssetSuggestionServiceSettings effectiveSettings = settings ?? TravelAssetSuggestionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callSuggestTravelAssets = clientHelper.BuildApiCall<SuggestTravelAssetsRequest, SuggestTravelAssetsResponse>("SuggestTravelAssets", grpcClient.SuggestTravelAssetsAsync, grpcClient.SuggestTravelAssets, effectiveSettings.SuggestTravelAssetsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callSuggestTravelAssets);
            Modify_SuggestTravelAssetsApiCall(ref _callSuggestTravelAssets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SuggestTravelAssetsApiCall(ref gaxgrpc::ApiCall<SuggestTravelAssetsRequest, SuggestTravelAssetsResponse> call);

        partial void OnConstruction(TravelAssetSuggestionService.TravelAssetSuggestionServiceClient grpcClient, TravelAssetSuggestionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TravelAssetSuggestionService client</summary>
        public override TravelAssetSuggestionService.TravelAssetSuggestionServiceClient GrpcClient { get; }

        partial void Modify_SuggestTravelAssetsRequest(ref SuggestTravelAssetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns Travel Asset suggestions. Asset
        /// suggestions are returned on a best-effort basis. There are no guarantees
        /// that all possible asset types will be returned for any given hotel
        /// property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SuggestTravelAssetsResponse SuggestTravelAssets(SuggestTravelAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestTravelAssetsRequest(ref request, ref callSettings);
            return _callSuggestTravelAssets.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns Travel Asset suggestions. Asset
        /// suggestions are returned on a best-effort basis. There are no guarantees
        /// that all possible asset types will be returned for any given hotel
        /// property.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SuggestTravelAssetsResponse> SuggestTravelAssetsAsync(SuggestTravelAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestTravelAssetsRequest(ref request, ref callSettings);
            return _callSuggestTravelAssets.Async(request, callSettings);
        }
    }
}

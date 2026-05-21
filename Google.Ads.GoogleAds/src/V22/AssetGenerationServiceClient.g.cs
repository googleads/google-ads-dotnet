// Copyright 2026 Google LLC
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

namespace Google.Ads.GoogleAds.V22.Services
{
    /// <summary>Settings for <see cref="AssetGenerationServiceClient"/> instances.</summary>
    public sealed partial class AssetGenerationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AssetGenerationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AssetGenerationServiceSettings"/>.</returns>
        public static AssetGenerationServiceSettings GetDefault() => new AssetGenerationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AssetGenerationServiceSettings"/> object with default settings.
        /// </summary>
        public AssetGenerationServiceSettings()
        {
        }

        private AssetGenerationServiceSettings(AssetGenerationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GenerateTextSettings = existing.GenerateTextSettings;
            GenerateImagesSettings = existing.GenerateImagesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AssetGenerationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetGenerationServiceClient.GenerateText</c> and <c>AssetGenerationServiceClient.GenerateTextAsync</c>.
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
        public gaxgrpc::CallSettings GenerateTextSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AssetGenerationServiceClient.GenerateImages</c> and <c>AssetGenerationServiceClient.GenerateImagesAsync</c>
        /// .
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
        public gaxgrpc::CallSettings GenerateImagesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AssetGenerationServiceSettings"/> object.</returns>
        public AssetGenerationServiceSettings Clone() => new AssetGenerationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AssetGenerationServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class AssetGenerationServiceClientBuilder : gaxgrpc::ClientBuilderBase<AssetGenerationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AssetGenerationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AssetGenerationServiceClientBuilder() : base(AssetGenerationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AssetGenerationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AssetGenerationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AssetGenerationServiceClient Build()
        {
            AssetGenerationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AssetGenerationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AssetGenerationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AssetGenerationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AssetGenerationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AssetGenerationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AssetGenerationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AssetGenerationServiceClient.ChannelPool;
    }

    /// <summary>AssetGenerationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for generating new assets with generative AI.
    /// </remarks>
    public abstract partial class AssetGenerationServiceClient
    {
        /// <summary>
        /// The default endpoint for the AssetGenerationService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AssetGenerationService scopes.</summary>
        /// <remarks>
        /// The default AssetGenerationService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AssetGenerationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AssetGenerationServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AssetGenerationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AssetGenerationServiceClient"/>.</returns>
        public static stt::Task<AssetGenerationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AssetGenerationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AssetGenerationServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AssetGenerationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AssetGenerationServiceClient"/>.</returns>
        public static AssetGenerationServiceClient Create() => new AssetGenerationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AssetGenerationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AssetGenerationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AssetGenerationServiceClient"/>.</returns>
        internal static AssetGenerationServiceClient Create(grpccore::CallInvoker callInvoker, AssetGenerationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AssetGenerationService.AssetGenerationServiceClient grpcClient = new AssetGenerationService.AssetGenerationServiceClient(callInvoker);
            return new AssetGenerationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AssetGenerationService client</summary>
        public virtual AssetGenerationService.AssetGenerationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Uses generative AI to generate text that can be used as assets in a
        /// campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AssetGenerationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateTextResponse GenerateText(GenerateTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uses generative AI to generate text that can be used as assets in a
        /// campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AssetGenerationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateTextResponse> GenerateTextAsync(GenerateTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uses generative AI to generate text that can be used as assets in a
        /// campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AssetGenerationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateTextResponse> GenerateTextAsync(GenerateTextRequest request, st::CancellationToken cancellationToken) =>
            GenerateTextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Uses generative AI to generate images that can be used as assets in a
        /// campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AssetGenerationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateImagesResponse GenerateImages(GenerateImagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uses generative AI to generate images that can be used as assets in a
        /// campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AssetGenerationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateImagesResponse> GenerateImagesAsync(GenerateImagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uses generative AI to generate images that can be used as assets in a
        /// campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AssetGenerationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateImagesResponse> GenerateImagesAsync(GenerateImagesRequest request, st::CancellationToken cancellationToken) =>
            GenerateImagesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AssetGenerationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for generating new assets with generative AI.
    /// </remarks>
    public sealed partial class AssetGenerationServiceClientImpl : AssetGenerationServiceClient
    {
        private readonly gaxgrpc::ApiCall<GenerateTextRequest, GenerateTextResponse> _callGenerateText;

        private readonly gaxgrpc::ApiCall<GenerateImagesRequest, GenerateImagesResponse> _callGenerateImages;

        /// <summary>
        /// Constructs a client wrapper for the AssetGenerationService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AssetGenerationServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AssetGenerationServiceClientImpl(AssetGenerationService.AssetGenerationServiceClient grpcClient, AssetGenerationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AssetGenerationServiceSettings effectiveSettings = settings ?? AssetGenerationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGenerateText = clientHelper.BuildApiCall<GenerateTextRequest, GenerateTextResponse>("GenerateText", grpcClient.GenerateTextAsync, grpcClient.GenerateText, effectiveSettings.GenerateTextSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGenerateText);
            Modify_GenerateTextApiCall(ref _callGenerateText);
            _callGenerateImages = clientHelper.BuildApiCall<GenerateImagesRequest, GenerateImagesResponse>("GenerateImages", grpcClient.GenerateImagesAsync, grpcClient.GenerateImages, effectiveSettings.GenerateImagesSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGenerateImages);
            Modify_GenerateImagesApiCall(ref _callGenerateImages);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GenerateTextApiCall(ref gaxgrpc::ApiCall<GenerateTextRequest, GenerateTextResponse> call);

        partial void Modify_GenerateImagesApiCall(ref gaxgrpc::ApiCall<GenerateImagesRequest, GenerateImagesResponse> call);

        partial void OnConstruction(AssetGenerationService.AssetGenerationServiceClient grpcClient, AssetGenerationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AssetGenerationService client</summary>
        public override AssetGenerationService.AssetGenerationServiceClient GrpcClient { get; }

        partial void Modify_GenerateTextRequest(ref GenerateTextRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateImagesRequest(ref GenerateImagesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Uses generative AI to generate text that can be used as assets in a
        /// campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AssetGenerationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateTextResponse GenerateText(GenerateTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateTextRequest(ref request, ref callSettings);
            return _callGenerateText.Sync(request, callSettings);
        }

        /// <summary>
        /// Uses generative AI to generate text that can be used as assets in a
        /// campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AssetGenerationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateTextResponse> GenerateTextAsync(GenerateTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateTextRequest(ref request, ref callSettings);
            return _callGenerateText.Async(request, callSettings);
        }

        /// <summary>
        /// Uses generative AI to generate images that can be used as assets in a
        /// campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AssetGenerationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateImagesResponse GenerateImages(GenerateImagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateImagesRequest(ref request, ref callSettings);
            return _callGenerateImages.Sync(request, callSettings);
        }

        /// <summary>
        /// Uses generative AI to generate images that can be used as assets in a
        /// campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AssetGenerationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateImagesResponse> GenerateImagesAsync(GenerateImagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateImagesRequest(ref request, ref callSettings);
            return _callGenerateImages.Async(request, callSettings);
        }
    }
}

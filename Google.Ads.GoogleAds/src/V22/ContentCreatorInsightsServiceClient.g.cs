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
    /// <summary>Settings for <see cref="ContentCreatorInsightsServiceClient"/> instances.</summary>
    public sealed partial class ContentCreatorInsightsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ContentCreatorInsightsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ContentCreatorInsightsServiceSettings"/>.</returns>
        public static ContentCreatorInsightsServiceSettings GetDefault() => new ContentCreatorInsightsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ContentCreatorInsightsServiceSettings"/> object with default settings.
        /// </summary>
        public ContentCreatorInsightsServiceSettings()
        {
        }

        private ContentCreatorInsightsServiceSettings(ContentCreatorInsightsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GenerateCreatorInsightsSettings = existing.GenerateCreatorInsightsSettings;
            GenerateTrendingInsightsSettings = existing.GenerateTrendingInsightsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ContentCreatorInsightsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContentCreatorInsightsServiceClient.GenerateCreatorInsights</c> and
        /// <c>ContentCreatorInsightsServiceClient.GenerateCreatorInsightsAsync</c>.
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
        public gaxgrpc::CallSettings GenerateCreatorInsightsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ContentCreatorInsightsServiceClient.GenerateTrendingInsights</c> and
        /// <c>ContentCreatorInsightsServiceClient.GenerateTrendingInsightsAsync</c>.
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
        public gaxgrpc::CallSettings GenerateTrendingInsightsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ContentCreatorInsightsServiceSettings"/> object.</returns>
        public ContentCreatorInsightsServiceSettings Clone() => new ContentCreatorInsightsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ContentCreatorInsightsServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class ContentCreatorInsightsServiceClientBuilder : gaxgrpc::ClientBuilderBase<ContentCreatorInsightsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ContentCreatorInsightsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ContentCreatorInsightsServiceClientBuilder() : base(ContentCreatorInsightsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ContentCreatorInsightsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ContentCreatorInsightsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ContentCreatorInsightsServiceClient Build()
        {
            ContentCreatorInsightsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ContentCreatorInsightsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ContentCreatorInsightsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ContentCreatorInsightsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ContentCreatorInsightsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ContentCreatorInsightsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ContentCreatorInsightsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ContentCreatorInsightsServiceClient.ChannelPool;
    }

    /// <summary>ContentCreatorInsightsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Content Creator Insights Service helps users find information about YouTube
    /// Creators and their content and how these creators and their audiences can be
    /// reached with Google Ads. Accessible to allowlisted customers only.
    /// </remarks>
    public abstract partial class ContentCreatorInsightsServiceClient
    {
        /// <summary>
        /// The default endpoint for the ContentCreatorInsightsService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ContentCreatorInsightsService scopes.</summary>
        /// <remarks>
        /// The default ContentCreatorInsightsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ContentCreatorInsightsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ContentCreatorInsightsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ContentCreatorInsightsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ContentCreatorInsightsServiceClient"/>.</returns>
        public static stt::Task<ContentCreatorInsightsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ContentCreatorInsightsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ContentCreatorInsightsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ContentCreatorInsightsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ContentCreatorInsightsServiceClient"/>.</returns>
        public static ContentCreatorInsightsServiceClient Create() =>
            new ContentCreatorInsightsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ContentCreatorInsightsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ContentCreatorInsightsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ContentCreatorInsightsServiceClient"/>.</returns>
        internal static ContentCreatorInsightsServiceClient Create(grpccore::CallInvoker callInvoker, ContentCreatorInsightsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ContentCreatorInsightsService.ContentCreatorInsightsServiceClient grpcClient = new ContentCreatorInsightsService.ContentCreatorInsightsServiceClient(callInvoker);
            return new ContentCreatorInsightsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ContentCreatorInsightsService client</summary>
        public virtual ContentCreatorInsightsService.ContentCreatorInsightsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns insights for a collection of YouTube Creators and Channels.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateCreatorInsightsResponse GenerateCreatorInsights(GenerateCreatorInsightsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns insights for a collection of YouTube Creators and Channels.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateCreatorInsightsResponse> GenerateCreatorInsightsAsync(GenerateCreatorInsightsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns insights for a collection of YouTube Creators and Channels.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateCreatorInsightsResponse> GenerateCreatorInsightsAsync(GenerateCreatorInsightsRequest request, st::CancellationToken cancellationToken) =>
            GenerateCreatorInsightsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns insights for trending content on YouTube.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateTrendingInsightsResponse GenerateTrendingInsights(GenerateTrendingInsightsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns insights for trending content on YouTube.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateTrendingInsightsResponse> GenerateTrendingInsightsAsync(GenerateTrendingInsightsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns insights for trending content on YouTube.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateTrendingInsightsResponse> GenerateTrendingInsightsAsync(GenerateTrendingInsightsRequest request, st::CancellationToken cancellationToken) =>
            GenerateTrendingInsightsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ContentCreatorInsightsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Content Creator Insights Service helps users find information about YouTube
    /// Creators and their content and how these creators and their audiences can be
    /// reached with Google Ads. Accessible to allowlisted customers only.
    /// </remarks>
    public sealed partial class ContentCreatorInsightsServiceClientImpl : ContentCreatorInsightsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GenerateCreatorInsightsRequest, GenerateCreatorInsightsResponse> _callGenerateCreatorInsights;

        private readonly gaxgrpc::ApiCall<GenerateTrendingInsightsRequest, GenerateTrendingInsightsResponse> _callGenerateTrendingInsights;

        /// <summary>
        /// Constructs a client wrapper for the ContentCreatorInsightsService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ContentCreatorInsightsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ContentCreatorInsightsServiceClientImpl(ContentCreatorInsightsService.ContentCreatorInsightsServiceClient grpcClient, ContentCreatorInsightsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ContentCreatorInsightsServiceSettings effectiveSettings = settings ?? ContentCreatorInsightsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGenerateCreatorInsights = clientHelper.BuildApiCall<GenerateCreatorInsightsRequest, GenerateCreatorInsightsResponse>("GenerateCreatorInsights", grpcClient.GenerateCreatorInsightsAsync, grpcClient.GenerateCreatorInsights, effectiveSettings.GenerateCreatorInsightsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGenerateCreatorInsights);
            Modify_GenerateCreatorInsightsApiCall(ref _callGenerateCreatorInsights);
            _callGenerateTrendingInsights = clientHelper.BuildApiCall<GenerateTrendingInsightsRequest, GenerateTrendingInsightsResponse>("GenerateTrendingInsights", grpcClient.GenerateTrendingInsightsAsync, grpcClient.GenerateTrendingInsights, effectiveSettings.GenerateTrendingInsightsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGenerateTrendingInsights);
            Modify_GenerateTrendingInsightsApiCall(ref _callGenerateTrendingInsights);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GenerateCreatorInsightsApiCall(ref gaxgrpc::ApiCall<GenerateCreatorInsightsRequest, GenerateCreatorInsightsResponse> call);

        partial void Modify_GenerateTrendingInsightsApiCall(ref gaxgrpc::ApiCall<GenerateTrendingInsightsRequest, GenerateTrendingInsightsResponse> call);

        partial void OnConstruction(ContentCreatorInsightsService.ContentCreatorInsightsServiceClient grpcClient, ContentCreatorInsightsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ContentCreatorInsightsService client</summary>
        public override ContentCreatorInsightsService.ContentCreatorInsightsServiceClient GrpcClient { get; }

        partial void Modify_GenerateCreatorInsightsRequest(ref GenerateCreatorInsightsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateTrendingInsightsRequest(ref GenerateTrendingInsightsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns insights for a collection of YouTube Creators and Channels.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateCreatorInsightsResponse GenerateCreatorInsights(GenerateCreatorInsightsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateCreatorInsightsRequest(ref request, ref callSettings);
            return _callGenerateCreatorInsights.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns insights for a collection of YouTube Creators and Channels.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateCreatorInsightsResponse> GenerateCreatorInsightsAsync(GenerateCreatorInsightsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateCreatorInsightsRequest(ref request, ref callSettings);
            return _callGenerateCreatorInsights.Async(request, callSettings);
        }

        /// <summary>
        /// Returns insights for trending content on YouTube.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateTrendingInsightsResponse GenerateTrendingInsights(GenerateTrendingInsightsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateTrendingInsightsRequest(ref request, ref callSettings);
            return _callGenerateTrendingInsights.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns insights for trending content on YouTube.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateTrendingInsightsResponse> GenerateTrendingInsightsAsync(GenerateTrendingInsightsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateTrendingInsightsRequest(ref request, ref callSettings);
            return _callGenerateTrendingInsights.Async(request, callSettings);
        }
    }
}

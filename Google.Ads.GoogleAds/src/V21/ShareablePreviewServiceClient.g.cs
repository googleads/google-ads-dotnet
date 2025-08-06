// Copyright 2025 Google LLC
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

namespace Google.Ads.GoogleAds.V21.Services
{
    /// <summary>Settings for <see cref="ShareablePreviewServiceClient"/> instances.</summary>
    public sealed partial class ShareablePreviewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ShareablePreviewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ShareablePreviewServiceSettings"/>.</returns>
        public static ShareablePreviewServiceSettings GetDefault() => new ShareablePreviewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ShareablePreviewServiceSettings"/> object with default settings.
        /// </summary>
        public ShareablePreviewServiceSettings()
        {
        }

        private ShareablePreviewServiceSettings(ShareablePreviewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GenerateShareablePreviewsSettings = existing.GenerateShareablePreviewsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ShareablePreviewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ShareablePreviewServiceClient.GenerateShareablePreviews</c> and
        /// <c>ShareablePreviewServiceClient.GenerateShareablePreviewsAsync</c>.
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
        public gaxgrpc::CallSettings GenerateShareablePreviewsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ShareablePreviewServiceSettings"/> object.</returns>
        public ShareablePreviewServiceSettings Clone() => new ShareablePreviewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ShareablePreviewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class ShareablePreviewServiceClientBuilder : gaxgrpc::ClientBuilderBase<ShareablePreviewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ShareablePreviewServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ShareablePreviewServiceClientBuilder() : base(ShareablePreviewServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ShareablePreviewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ShareablePreviewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ShareablePreviewServiceClient Build()
        {
            ShareablePreviewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ShareablePreviewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ShareablePreviewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ShareablePreviewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ShareablePreviewServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ShareablePreviewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ShareablePreviewServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ShareablePreviewServiceClient.ChannelPool;
    }

    /// <summary>ShareablePreviewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to generate Shareable Previews.
    /// </remarks>
    public abstract partial class ShareablePreviewServiceClient
    {
        /// <summary>
        /// The default endpoint for the ShareablePreviewService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ShareablePreviewService scopes.</summary>
        /// <remarks>
        /// The default ShareablePreviewService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ShareablePreviewService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ShareablePreviewServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ShareablePreviewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ShareablePreviewServiceClient"/>.</returns>
        public static stt::Task<ShareablePreviewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ShareablePreviewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ShareablePreviewServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ShareablePreviewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ShareablePreviewServiceClient"/>.</returns>
        public static ShareablePreviewServiceClient Create() => new ShareablePreviewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ShareablePreviewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ShareablePreviewServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ShareablePreviewServiceClient"/>.</returns>
        internal static ShareablePreviewServiceClient Create(grpccore::CallInvoker callInvoker, ShareablePreviewServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ShareablePreviewService.ShareablePreviewServiceClient grpcClient = new ShareablePreviewService.ShareablePreviewServiceClient(callInvoker);
            return new ShareablePreviewServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ShareablePreviewService client</summary>
        public virtual ShareablePreviewService.ShareablePreviewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Shareable Preview.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateShareablePreviewsResponse GenerateShareablePreviews(GenerateShareablePreviewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Shareable Preview.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateShareablePreviewsResponse> GenerateShareablePreviewsAsync(GenerateShareablePreviewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Shareable Preview.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateShareablePreviewsResponse> GenerateShareablePreviewsAsync(GenerateShareablePreviewsRequest request, st::CancellationToken cancellationToken) =>
            GenerateShareablePreviewsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Shareable Preview.
        /// </summary>
        /// <param name="customerId">
        /// Required. The customer creating the shareable previews request.
        /// </param>
        /// <param name="shareablePreviews">
        /// Required. The list of shareable previews to generate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateShareablePreviewsResponse GenerateShareablePreviews(string customerId, scg::IEnumerable<ShareablePreview> shareablePreviews, gaxgrpc::CallSettings callSettings = null) =>
            GenerateShareablePreviews(new GenerateShareablePreviewsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ShareablePreviews =
                {
                    gax::GaxPreconditions.CheckNotNull(shareablePreviews, nameof(shareablePreviews)),
                },
            }, callSettings);

        /// <summary>
        /// Returns the requested Shareable Preview.
        /// </summary>
        /// <param name="customerId">
        /// Required. The customer creating the shareable previews request.
        /// </param>
        /// <param name="shareablePreviews">
        /// Required. The list of shareable previews to generate.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateShareablePreviewsResponse> GenerateShareablePreviewsAsync(string customerId, scg::IEnumerable<ShareablePreview> shareablePreviews, gaxgrpc::CallSettings callSettings = null) =>
            GenerateShareablePreviewsAsync(new GenerateShareablePreviewsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ShareablePreviews =
                {
                    gax::GaxPreconditions.CheckNotNull(shareablePreviews, nameof(shareablePreviews)),
                },
            }, callSettings);

        /// <summary>
        /// Returns the requested Shareable Preview.
        /// </summary>
        /// <param name="customerId">
        /// Required. The customer creating the shareable previews request.
        /// </param>
        /// <param name="shareablePreviews">
        /// Required. The list of shareable previews to generate.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateShareablePreviewsResponse> GenerateShareablePreviewsAsync(string customerId, scg::IEnumerable<ShareablePreview> shareablePreviews, st::CancellationToken cancellationToken) =>
            GenerateShareablePreviewsAsync(customerId, shareablePreviews, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ShareablePreviewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to generate Shareable Previews.
    /// </remarks>
    public sealed partial class ShareablePreviewServiceClientImpl : ShareablePreviewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GenerateShareablePreviewsRequest, GenerateShareablePreviewsResponse> _callGenerateShareablePreviews;

        /// <summary>
        /// Constructs a client wrapper for the ShareablePreviewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ShareablePreviewServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ShareablePreviewServiceClientImpl(ShareablePreviewService.ShareablePreviewServiceClient grpcClient, ShareablePreviewServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ShareablePreviewServiceSettings effectiveSettings = settings ?? ShareablePreviewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGenerateShareablePreviews = clientHelper.BuildApiCall<GenerateShareablePreviewsRequest, GenerateShareablePreviewsResponse>("GenerateShareablePreviews", grpcClient.GenerateShareablePreviewsAsync, grpcClient.GenerateShareablePreviews, effectiveSettings.GenerateShareablePreviewsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGenerateShareablePreviews);
            Modify_GenerateShareablePreviewsApiCall(ref _callGenerateShareablePreviews);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GenerateShareablePreviewsApiCall(ref gaxgrpc::ApiCall<GenerateShareablePreviewsRequest, GenerateShareablePreviewsResponse> call);

        partial void OnConstruction(ShareablePreviewService.ShareablePreviewServiceClient grpcClient, ShareablePreviewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ShareablePreviewService client</summary>
        public override ShareablePreviewService.ShareablePreviewServiceClient GrpcClient { get; }

        partial void Modify_GenerateShareablePreviewsRequest(ref GenerateShareablePreviewsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested Shareable Preview.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateShareablePreviewsResponse GenerateShareablePreviews(GenerateShareablePreviewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateShareablePreviewsRequest(ref request, ref callSettings);
            return _callGenerateShareablePreviews.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Shareable Preview.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateShareablePreviewsResponse> GenerateShareablePreviewsAsync(GenerateShareablePreviewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateShareablePreviewsRequest(ref request, ref callSettings);
            return _callGenerateShareablePreviews.Async(request, callSettings);
        }
    }
}

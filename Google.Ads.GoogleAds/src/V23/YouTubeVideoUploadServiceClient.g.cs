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
using gagvr = Google.Ads.GoogleAds.V23.Resources;
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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Ads.GoogleAds.V23.Services
{
    /// <summary>Settings for <see cref="YouTubeVideoUploadServiceClient"/> instances.</summary>
    public sealed partial class YouTubeVideoUploadServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="YouTubeVideoUploadServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="YouTubeVideoUploadServiceSettings"/>.</returns>
        public static YouTubeVideoUploadServiceSettings GetDefault() => new YouTubeVideoUploadServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="YouTubeVideoUploadServiceSettings"/> object with default settings.
        /// </summary>
        public YouTubeVideoUploadServiceSettings()
        {
        }

        private YouTubeVideoUploadServiceSettings(YouTubeVideoUploadServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateYouTubeVideoUploadSettings = existing.CreateYouTubeVideoUploadSettings;
            UpdateYouTubeVideoUploadSettings = existing.UpdateYouTubeVideoUploadSettings;
            RemoveYouTubeVideoUploadSettings = existing.RemoveYouTubeVideoUploadSettings;
            OnCopy(existing);
        }

        partial void OnCopy(YouTubeVideoUploadServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>YouTubeVideoUploadServiceClient.CreateYouTubeVideoUpload</c> and
        /// <c>YouTubeVideoUploadServiceClient.CreateYouTubeVideoUploadAsync</c>.
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
        public gaxgrpc::CallSettings CreateYouTubeVideoUploadSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>YouTubeVideoUploadServiceClient.UpdateYouTubeVideoUpload</c> and
        /// <c>YouTubeVideoUploadServiceClient.UpdateYouTubeVideoUploadAsync</c>.
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
        public gaxgrpc::CallSettings UpdateYouTubeVideoUploadSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>YouTubeVideoUploadServiceClient.RemoveYouTubeVideoUpload</c> and
        /// <c>YouTubeVideoUploadServiceClient.RemoveYouTubeVideoUploadAsync</c>.
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
        public gaxgrpc::CallSettings RemoveYouTubeVideoUploadSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="YouTubeVideoUploadServiceSettings"/> object.</returns>
        public YouTubeVideoUploadServiceSettings Clone() => new YouTubeVideoUploadServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="YouTubeVideoUploadServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class YouTubeVideoUploadServiceClientBuilder : gaxgrpc::ClientBuilderBase<YouTubeVideoUploadServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public YouTubeVideoUploadServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public YouTubeVideoUploadServiceClientBuilder() : base(YouTubeVideoUploadServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref YouTubeVideoUploadServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<YouTubeVideoUploadServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override YouTubeVideoUploadServiceClient Build()
        {
            YouTubeVideoUploadServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<YouTubeVideoUploadServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<YouTubeVideoUploadServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private YouTubeVideoUploadServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return YouTubeVideoUploadServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<YouTubeVideoUploadServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return YouTubeVideoUploadServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => YouTubeVideoUploadServiceClient.ChannelPool;
    }

    /// <summary>YouTubeVideoUploadService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage YouTube video uploads.
    /// </remarks>
    public abstract partial class YouTubeVideoUploadServiceClient
    {
        /// <summary>
        /// The default endpoint for the YouTubeVideoUploadService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default YouTubeVideoUploadService scopes.</summary>
        /// <remarks>
        /// The default YouTubeVideoUploadService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(YouTubeVideoUploadService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="YouTubeVideoUploadServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="YouTubeVideoUploadServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="YouTubeVideoUploadServiceClient"/>.</returns>
        public static stt::Task<YouTubeVideoUploadServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new YouTubeVideoUploadServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="YouTubeVideoUploadServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="YouTubeVideoUploadServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="YouTubeVideoUploadServiceClient"/>.</returns>
        public static YouTubeVideoUploadServiceClient Create() => new YouTubeVideoUploadServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="YouTubeVideoUploadServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="YouTubeVideoUploadServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="YouTubeVideoUploadServiceClient"/>.</returns>
        internal static YouTubeVideoUploadServiceClient Create(grpccore::CallInvoker callInvoker, YouTubeVideoUploadServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            YouTubeVideoUploadService.YouTubeVideoUploadServiceClient grpcClient = new YouTubeVideoUploadService.YouTubeVideoUploadServiceClient(callInvoker);
            return new YouTubeVideoUploadServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC YouTubeVideoUploadService client</summary>
        public virtual YouTubeVideoUploadService.YouTubeVideoUploadServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads a video to Google-managed or advertiser owned (brand) YouTube
        /// channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateYouTubeVideoUploadResponse CreateYouTubeVideoUpload(CreateYouTubeVideoUploadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads a video to Google-managed or advertiser owned (brand) YouTube
        /// channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateYouTubeVideoUploadResponse> CreateYouTubeVideoUploadAsync(CreateYouTubeVideoUploadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads a video to Google-managed or advertiser owned (brand) YouTube
        /// channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateYouTubeVideoUploadResponse> CreateYouTubeVideoUploadAsync(CreateYouTubeVideoUploadRequest request, st::CancellationToken cancellationToken) =>
            CreateYouTubeVideoUploadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Uploads a video to Google-managed or advertiser owned (brand) YouTube
        /// channel.
        /// </summary>
        /// <param name="customerId">
        /// Required. The customer ID requesting the upload. Required.
        /// </param>
        /// <param name="youTubeVideoUpload">
        /// Required. The initial details of the video to upload. Required.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateYouTubeVideoUploadResponse CreateYouTubeVideoUpload(string customerId, gagvr::YouTubeVideoUpload youTubeVideoUpload, gaxgrpc::CallSettings callSettings = null) =>
            CreateYouTubeVideoUpload(new CreateYouTubeVideoUploadRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                YouTubeVideoUpload = gax::GaxPreconditions.CheckNotNull(youTubeVideoUpload, nameof(youTubeVideoUpload)),
            }, callSettings);

        /// <summary>
        /// Uploads a video to Google-managed or advertiser owned (brand) YouTube
        /// channel.
        /// </summary>
        /// <param name="customerId">
        /// Required. The customer ID requesting the upload. Required.
        /// </param>
        /// <param name="youTubeVideoUpload">
        /// Required. The initial details of the video to upload. Required.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateYouTubeVideoUploadResponse> CreateYouTubeVideoUploadAsync(string customerId, gagvr::YouTubeVideoUpload youTubeVideoUpload, gaxgrpc::CallSettings callSettings = null) =>
            CreateYouTubeVideoUploadAsync(new CreateYouTubeVideoUploadRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                YouTubeVideoUpload = gax::GaxPreconditions.CheckNotNull(youTubeVideoUpload, nameof(youTubeVideoUpload)),
            }, callSettings);

        /// <summary>
        /// Uploads a video to Google-managed or advertiser owned (brand) YouTube
        /// channel.
        /// </summary>
        /// <param name="customerId">
        /// Required. The customer ID requesting the upload. Required.
        /// </param>
        /// <param name="youTubeVideoUpload">
        /// Required. The initial details of the video to upload. Required.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateYouTubeVideoUploadResponse> CreateYouTubeVideoUploadAsync(string customerId, gagvr::YouTubeVideoUpload youTubeVideoUpload, st::CancellationToken cancellationToken) =>
            CreateYouTubeVideoUploadAsync(customerId, youTubeVideoUpload, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates YouTube video's metadata, but only for videos uploaded using this
        /// API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UpdateYouTubeVideoUploadResponse UpdateYouTubeVideoUpload(UpdateYouTubeVideoUploadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates YouTube video's metadata, but only for videos uploaded using this
        /// API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateYouTubeVideoUploadResponse> UpdateYouTubeVideoUploadAsync(UpdateYouTubeVideoUploadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates YouTube video's metadata, but only for videos uploaded using this
        /// API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateYouTubeVideoUploadResponse> UpdateYouTubeVideoUploadAsync(UpdateYouTubeVideoUploadRequest request, st::CancellationToken cancellationToken) =>
            UpdateYouTubeVideoUploadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates YouTube video's metadata, but only for videos uploaded using this
        /// API.
        /// </summary>
        /// <param name="customerId">
        /// Required. The customer ID requesting the YouTube video upload update.
        /// Required.
        /// </param>
        /// <param name="youTubeVideoUpload">
        /// Required. The YouTube video upload resource to be updated. It's expected to
        /// have a valid resource name. Required.
        /// </param>
        /// <param name="updateMask">
        /// Required. FieldMask that determines which resource fields are modified in
        /// an update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UpdateYouTubeVideoUploadResponse UpdateYouTubeVideoUpload(string customerId, gagvr::YouTubeVideoUpload youTubeVideoUpload, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateYouTubeVideoUpload(new UpdateYouTubeVideoUploadRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                YouTubeVideoUpload = gax::GaxPreconditions.CheckNotNull(youTubeVideoUpload, nameof(youTubeVideoUpload)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates YouTube video's metadata, but only for videos uploaded using this
        /// API.
        /// </summary>
        /// <param name="customerId">
        /// Required. The customer ID requesting the YouTube video upload update.
        /// Required.
        /// </param>
        /// <param name="youTubeVideoUpload">
        /// Required. The YouTube video upload resource to be updated. It's expected to
        /// have a valid resource name. Required.
        /// </param>
        /// <param name="updateMask">
        /// Required. FieldMask that determines which resource fields are modified in
        /// an update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateYouTubeVideoUploadResponse> UpdateYouTubeVideoUploadAsync(string customerId, gagvr::YouTubeVideoUpload youTubeVideoUpload, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateYouTubeVideoUploadAsync(new UpdateYouTubeVideoUploadRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                YouTubeVideoUpload = gax::GaxPreconditions.CheckNotNull(youTubeVideoUpload, nameof(youTubeVideoUpload)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates YouTube video's metadata, but only for videos uploaded using this
        /// API.
        /// </summary>
        /// <param name="customerId">
        /// Required. The customer ID requesting the YouTube video upload update.
        /// Required.
        /// </param>
        /// <param name="youTubeVideoUpload">
        /// Required. The YouTube video upload resource to be updated. It's expected to
        /// have a valid resource name. Required.
        /// </param>
        /// <param name="updateMask">
        /// Required. FieldMask that determines which resource fields are modified in
        /// an update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateYouTubeVideoUploadResponse> UpdateYouTubeVideoUploadAsync(string customerId, gagvr::YouTubeVideoUpload youTubeVideoUpload, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateYouTubeVideoUploadAsync(customerId, youTubeVideoUpload, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes YouTube videos uploaded using this API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveYouTubeVideoUploadResponse RemoveYouTubeVideoUpload(RemoveYouTubeVideoUploadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes YouTube videos uploaded using this API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveYouTubeVideoUploadResponse> RemoveYouTubeVideoUploadAsync(RemoveYouTubeVideoUploadRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes YouTube videos uploaded using this API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveYouTubeVideoUploadResponse> RemoveYouTubeVideoUploadAsync(RemoveYouTubeVideoUploadRequest request, st::CancellationToken cancellationToken) =>
            RemoveYouTubeVideoUploadAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes YouTube videos uploaded using this API.
        /// </summary>
        /// <param name="customerId">
        /// Required. The customer ID requesting the YouTube video upload deletion.
        /// Required.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveYouTubeVideoUploadResponse RemoveYouTubeVideoUpload(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            RemoveYouTubeVideoUpload(new RemoveYouTubeVideoUploadRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Removes YouTube videos uploaded using this API.
        /// </summary>
        /// <param name="customerId">
        /// Required. The customer ID requesting the YouTube video upload deletion.
        /// Required.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveYouTubeVideoUploadResponse> RemoveYouTubeVideoUploadAsync(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            RemoveYouTubeVideoUploadAsync(new RemoveYouTubeVideoUploadRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Removes YouTube videos uploaded using this API.
        /// </summary>
        /// <param name="customerId">
        /// Required. The customer ID requesting the YouTube video upload deletion.
        /// Required.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveYouTubeVideoUploadResponse> RemoveYouTubeVideoUploadAsync(string customerId, st::CancellationToken cancellationToken) =>
            RemoveYouTubeVideoUploadAsync(customerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>YouTubeVideoUploadService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage YouTube video uploads.
    /// </remarks>
    public sealed partial class YouTubeVideoUploadServiceClientImpl : YouTubeVideoUploadServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateYouTubeVideoUploadRequest, CreateYouTubeVideoUploadResponse> _callCreateYouTubeVideoUpload;

        private readonly gaxgrpc::ApiCall<UpdateYouTubeVideoUploadRequest, UpdateYouTubeVideoUploadResponse> _callUpdateYouTubeVideoUpload;

        private readonly gaxgrpc::ApiCall<RemoveYouTubeVideoUploadRequest, RemoveYouTubeVideoUploadResponse> _callRemoveYouTubeVideoUpload;

        /// <summary>
        /// Constructs a client wrapper for the YouTubeVideoUploadService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="YouTubeVideoUploadServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public YouTubeVideoUploadServiceClientImpl(YouTubeVideoUploadService.YouTubeVideoUploadServiceClient grpcClient, YouTubeVideoUploadServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            YouTubeVideoUploadServiceSettings effectiveSettings = settings ?? YouTubeVideoUploadServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateYouTubeVideoUpload = clientHelper.BuildApiCall<CreateYouTubeVideoUploadRequest, CreateYouTubeVideoUploadResponse>("CreateYouTubeVideoUpload", grpcClient.CreateYouTubeVideoUploadAsync, grpcClient.CreateYouTubeVideoUpload, effectiveSettings.CreateYouTubeVideoUploadSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callCreateYouTubeVideoUpload);
            Modify_CreateYouTubeVideoUploadApiCall(ref _callCreateYouTubeVideoUpload);
            _callUpdateYouTubeVideoUpload = clientHelper.BuildApiCall<UpdateYouTubeVideoUploadRequest, UpdateYouTubeVideoUploadResponse>("UpdateYouTubeVideoUpload", grpcClient.UpdateYouTubeVideoUploadAsync, grpcClient.UpdateYouTubeVideoUpload, effectiveSettings.UpdateYouTubeVideoUploadSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callUpdateYouTubeVideoUpload);
            Modify_UpdateYouTubeVideoUploadApiCall(ref _callUpdateYouTubeVideoUpload);
            _callRemoveYouTubeVideoUpload = clientHelper.BuildApiCall<RemoveYouTubeVideoUploadRequest, RemoveYouTubeVideoUploadResponse>("RemoveYouTubeVideoUpload", grpcClient.RemoveYouTubeVideoUploadAsync, grpcClient.RemoveYouTubeVideoUpload, effectiveSettings.RemoveYouTubeVideoUploadSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callRemoveYouTubeVideoUpload);
            Modify_RemoveYouTubeVideoUploadApiCall(ref _callRemoveYouTubeVideoUpload);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateYouTubeVideoUploadApiCall(ref gaxgrpc::ApiCall<CreateYouTubeVideoUploadRequest, CreateYouTubeVideoUploadResponse> call);

        partial void Modify_UpdateYouTubeVideoUploadApiCall(ref gaxgrpc::ApiCall<UpdateYouTubeVideoUploadRequest, UpdateYouTubeVideoUploadResponse> call);

        partial void Modify_RemoveYouTubeVideoUploadApiCall(ref gaxgrpc::ApiCall<RemoveYouTubeVideoUploadRequest, RemoveYouTubeVideoUploadResponse> call);

        partial void OnConstruction(YouTubeVideoUploadService.YouTubeVideoUploadServiceClient grpcClient, YouTubeVideoUploadServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC YouTubeVideoUploadService client</summary>
        public override YouTubeVideoUploadService.YouTubeVideoUploadServiceClient GrpcClient { get; }

        partial void Modify_CreateYouTubeVideoUploadRequest(ref CreateYouTubeVideoUploadRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateYouTubeVideoUploadRequest(ref UpdateYouTubeVideoUploadRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveYouTubeVideoUploadRequest(ref RemoveYouTubeVideoUploadRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Uploads a video to Google-managed or advertiser owned (brand) YouTube
        /// channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CreateYouTubeVideoUploadResponse CreateYouTubeVideoUpload(CreateYouTubeVideoUploadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateYouTubeVideoUploadRequest(ref request, ref callSettings);
            return _callCreateYouTubeVideoUpload.Sync(request, callSettings);
        }

        /// <summary>
        /// Uploads a video to Google-managed or advertiser owned (brand) YouTube
        /// channel.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CreateYouTubeVideoUploadResponse> CreateYouTubeVideoUploadAsync(CreateYouTubeVideoUploadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateYouTubeVideoUploadRequest(ref request, ref callSettings);
            return _callCreateYouTubeVideoUpload.Async(request, callSettings);
        }

        /// <summary>
        /// Updates YouTube video's metadata, but only for videos uploaded using this
        /// API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UpdateYouTubeVideoUploadResponse UpdateYouTubeVideoUpload(UpdateYouTubeVideoUploadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateYouTubeVideoUploadRequest(ref request, ref callSettings);
            return _callUpdateYouTubeVideoUpload.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates YouTube video's metadata, but only for videos uploaded using this
        /// API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UpdateYouTubeVideoUploadResponse> UpdateYouTubeVideoUploadAsync(UpdateYouTubeVideoUploadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateYouTubeVideoUploadRequest(ref request, ref callSettings);
            return _callUpdateYouTubeVideoUpload.Async(request, callSettings);
        }

        /// <summary>
        /// Removes YouTube videos uploaded using this API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RemoveYouTubeVideoUploadResponse RemoveYouTubeVideoUpload(RemoveYouTubeVideoUploadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveYouTubeVideoUploadRequest(ref request, ref callSettings);
            return _callRemoveYouTubeVideoUpload.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes YouTube videos uploaded using this API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RemoveYouTubeVideoUploadResponse> RemoveYouTubeVideoUploadAsync(RemoveYouTubeVideoUploadRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveYouTubeVideoUploadRequest(ref request, ref callSettings);
            return _callRemoveYouTubeVideoUpload.Async(request, callSettings);
        }
    }
}

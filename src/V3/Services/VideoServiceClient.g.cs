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

using gagvr = Google.Ads.GoogleAds.V3.Resources;
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

namespace Google.Ads.GoogleAds.V3.Services
{
    /// <summary>Settings for <see cref="VideoServiceClient"/> instances.</summary>
    public sealed partial class VideoServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="VideoServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="VideoServiceSettings"/>.</returns>
        public static VideoServiceSettings GetDefault() => new VideoServiceSettings();

        /// <summary>Constructs a new <see cref="VideoServiceSettings"/> object with default settings.</summary>
        public VideoServiceSettings()
        {
        }

        private VideoServiceSettings(VideoServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetVideoSettings = existing.GetVideoSettings;
            OnCopy(existing);
        }

        partial void OnCopy(VideoServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>VideoServiceClient.GetVideo</c>
        ///  and <c>VideoServiceClient.GetVideoAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetVideoSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="VideoServiceSettings"/> object.</returns>
        public VideoServiceSettings Clone() => new VideoServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="VideoServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class VideoServiceClientBuilder : gaxgrpc::ClientBuilderBase<VideoServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public VideoServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref VideoServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<VideoServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override VideoServiceClient Build()
        {
            VideoServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<VideoServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<VideoServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private VideoServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return VideoServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<VideoServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return VideoServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => VideoServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => VideoServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => VideoServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>VideoService client wrapper, for convenient use.</summary>
    public abstract partial class VideoServiceClient
    {
        /// <summary>
        /// The default endpoint for the VideoService service, which is a host of "googleads.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default VideoService scopes.</summary>
        /// <remarks>The default VideoService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="VideoServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VideoServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="VideoServiceClient"/>.</returns>
        public static stt::Task<VideoServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new VideoServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="VideoServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VideoServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="VideoServiceClient"/>.</returns>
        public static VideoServiceClient Create() => new VideoServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="VideoServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="VideoServiceSettings"/>.</param>
        /// <returns>The created <see cref="VideoServiceClient"/>.</returns>
        internal static VideoServiceClient Create(grpccore::CallInvoker callInvoker, VideoServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            VideoService.VideoServiceClient grpcClient = new VideoService.VideoServiceClient(callInvoker);
            return new VideoServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC VideoService client</summary>
        public virtual VideoService.VideoServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested video in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::Video GetVideo(GetVideoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested video in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Video> GetVideoAsync(GetVideoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested video in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Video> GetVideoAsync(GetVideoRequest request, st::CancellationToken cancellationToken) =>
            GetVideoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested video in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the video to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::Video GetVideo(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetVideo(new GetVideoRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested video in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the video to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Video> GetVideoAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetVideoAsync(new GetVideoRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested video in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the video to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Video> GetVideoAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetVideoAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested video in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the video to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::Video GetVideo(gagvr::VideoName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetVideo(new GetVideoRequest
            {
                ResourceNameAsVideoName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested video in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the video to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Video> GetVideoAsync(gagvr::VideoName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetVideoAsync(new GetVideoRequest
            {
                ResourceNameAsVideoName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested video in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the video to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Video> GetVideoAsync(gagvr::VideoName resourceName, st::CancellationToken cancellationToken) =>
            GetVideoAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>VideoService client wrapper implementation, for convenient use.</summary>
    public sealed partial class VideoServiceClientImpl : VideoServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetVideoRequest, gagvr::Video> _callGetVideo;

        /// <summary>
        /// Constructs a client wrapper for the VideoService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="VideoServiceSettings"/> used within this client.</param>
        public VideoServiceClientImpl(VideoService.VideoServiceClient grpcClient, VideoServiceSettings settings)
        {
            GrpcClient = grpcClient;
            VideoServiceSettings effectiveSettings = settings ?? VideoServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetVideo = clientHelper.BuildApiCall<GetVideoRequest, gagvr::Video>(grpcClient.GetVideoAsync, grpcClient.GetVideo, effectiveSettings.GetVideoSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetVideo);
            Modify_GetVideoApiCall(ref _callGetVideo);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetVideoApiCall(ref gaxgrpc::ApiCall<GetVideoRequest, gagvr::Video> call);

        partial void OnConstruction(VideoService.VideoServiceClient grpcClient, VideoServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC VideoService client</summary>
        public override VideoService.VideoServiceClient GrpcClient { get; }

        partial void Modify_GetVideoRequest(ref GetVideoRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested video in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::Video GetVideo(GetVideoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVideoRequest(ref request, ref callSettings);
            return _callGetVideo.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested video in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::Video> GetVideoAsync(GetVideoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVideoRequest(ref request, ref callSettings);
            return _callGetVideo.Async(request, callSettings);
        }
    }
}

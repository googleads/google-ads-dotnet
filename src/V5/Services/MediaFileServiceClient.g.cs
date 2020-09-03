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

using gagvr = Google.Ads.GoogleAds.V5.Resources;
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

namespace Google.Ads.GoogleAds.V5.Services
{
    /// <summary>Settings for <see cref="MediaFileServiceClient"/> instances.</summary>
    public sealed partial class MediaFileServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MediaFileServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MediaFileServiceSettings"/>.</returns>
        public static MediaFileServiceSettings GetDefault() => new MediaFileServiceSettings();

        /// <summary>Constructs a new <see cref="MediaFileServiceSettings"/> object with default settings.</summary>
        public MediaFileServiceSettings()
        {
        }

        private MediaFileServiceSettings(MediaFileServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetMediaFileSettings = existing.GetMediaFileSettings;
            MutateMediaFilesSettings = existing.MutateMediaFilesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MediaFileServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MediaFileServiceClient.GetMediaFile</c> and <c>MediaFileServiceClient.GetMediaFileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMediaFileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MediaFileServiceClient.MutateMediaFiles</c> and <c>MediaFileServiceClient.MutateMediaFilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateMediaFilesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MediaFileServiceSettings"/> object.</returns>
        public MediaFileServiceSettings Clone() => new MediaFileServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MediaFileServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class MediaFileServiceClientBuilder : gaxgrpc::ClientBuilderBase<MediaFileServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MediaFileServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref MediaFileServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MediaFileServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MediaFileServiceClient Build()
        {
            MediaFileServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MediaFileServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MediaFileServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MediaFileServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MediaFileServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<MediaFileServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MediaFileServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => MediaFileServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => MediaFileServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MediaFileServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>MediaFileService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage media files.
    /// </remarks>
    public abstract partial class MediaFileServiceClient
    {
        /// <summary>
        /// The default endpoint for the MediaFileService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default MediaFileService scopes.</summary>
        /// <remarks>The default MediaFileService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="MediaFileServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MediaFileServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MediaFileServiceClient"/>.</returns>
        public static stt::Task<MediaFileServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MediaFileServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MediaFileServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MediaFileServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MediaFileServiceClient"/>.</returns>
        public static MediaFileServiceClient Create() => new MediaFileServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MediaFileServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MediaFileServiceSettings"/>.</param>
        /// <returns>The created <see cref="MediaFileServiceClient"/>.</returns>
        internal static MediaFileServiceClient Create(grpccore::CallInvoker callInvoker, MediaFileServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MediaFileService.MediaFileServiceClient grpcClient = new MediaFileService.MediaFileServiceClient(callInvoker);
            return new MediaFileServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC MediaFileService client</summary>
        public virtual MediaFileService.MediaFileServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested media file in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::MediaFile GetMediaFile(GetMediaFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested media file in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MediaFile> GetMediaFileAsync(GetMediaFileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested media file in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MediaFile> GetMediaFileAsync(GetMediaFileRequest request, st::CancellationToken cancellationToken) =>
            GetMediaFileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested media file in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the media file to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::MediaFile GetMediaFile(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMediaFile(new GetMediaFileRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested media file in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the media file to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MediaFile> GetMediaFileAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMediaFileAsync(new GetMediaFileRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested media file in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the media file to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MediaFile> GetMediaFileAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetMediaFileAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested media file in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the media file to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::MediaFile GetMediaFile(gagvr::MediaFileName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMediaFile(new GetMediaFileRequest
            {
                ResourceNameAsMediaFileName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested media file in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the media file to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MediaFile> GetMediaFileAsync(gagvr::MediaFileName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMediaFileAsync(new GetMediaFileRequest
            {
                ResourceNameAsMediaFileName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested media file in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the media file to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MediaFile> GetMediaFileAsync(gagvr::MediaFileName resourceName, st::CancellationToken cancellationToken) =>
            GetMediaFileAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates media files. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateMediaFilesResponse MutateMediaFiles(MutateMediaFilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates media files. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateMediaFilesResponse> MutateMediaFilesAsync(MutateMediaFilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates media files. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateMediaFilesResponse> MutateMediaFilesAsync(MutateMediaFilesRequest request, st::CancellationToken cancellationToken) =>
            MutateMediaFilesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates media files. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose media files are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual media file.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateMediaFilesResponse MutateMediaFiles(string customerId, scg::IEnumerable<MediaFileOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateMediaFiles(new MutateMediaFilesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates media files. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose media files are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual media file.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateMediaFilesResponse> MutateMediaFilesAsync(string customerId, scg::IEnumerable<MediaFileOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateMediaFilesAsync(new MutateMediaFilesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates media files. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose media files are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual media file.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateMediaFilesResponse> MutateMediaFilesAsync(string customerId, scg::IEnumerable<MediaFileOperation> operations, st::CancellationToken cancellationToken) =>
            MutateMediaFilesAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MediaFileService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage media files.
    /// </remarks>
    public sealed partial class MediaFileServiceClientImpl : MediaFileServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetMediaFileRequest, gagvr::MediaFile> _callGetMediaFile;

        private readonly gaxgrpc::ApiCall<MutateMediaFilesRequest, MutateMediaFilesResponse> _callMutateMediaFiles;

        /// <summary>
        /// Constructs a client wrapper for the MediaFileService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MediaFileServiceSettings"/> used within this client.</param>
        public MediaFileServiceClientImpl(MediaFileService.MediaFileServiceClient grpcClient, MediaFileServiceSettings settings)
        {
            GrpcClient = grpcClient;
            MediaFileServiceSettings effectiveSettings = settings ?? MediaFileServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetMediaFile = clientHelper.BuildApiCall<GetMediaFileRequest, gagvr::MediaFile>(grpcClient.GetMediaFileAsync, grpcClient.GetMediaFile, effectiveSettings.GetMediaFileSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetMediaFile);
            Modify_GetMediaFileApiCall(ref _callGetMediaFile);
            _callMutateMediaFiles = clientHelper.BuildApiCall<MutateMediaFilesRequest, MutateMediaFilesResponse>(grpcClient.MutateMediaFilesAsync, grpcClient.MutateMediaFiles, effectiveSettings.MutateMediaFilesSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateMediaFiles);
            Modify_MutateMediaFilesApiCall(ref _callMutateMediaFiles);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetMediaFileApiCall(ref gaxgrpc::ApiCall<GetMediaFileRequest, gagvr::MediaFile> call);

        partial void Modify_MutateMediaFilesApiCall(ref gaxgrpc::ApiCall<MutateMediaFilesRequest, MutateMediaFilesResponse> call);

        partial void OnConstruction(MediaFileService.MediaFileServiceClient grpcClient, MediaFileServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MediaFileService client</summary>
        public override MediaFileService.MediaFileServiceClient GrpcClient { get; }

        partial void Modify_GetMediaFileRequest(ref GetMediaFileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateMediaFilesRequest(ref MutateMediaFilesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested media file in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::MediaFile GetMediaFile(GetMediaFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMediaFileRequest(ref request, ref callSettings);
            return _callGetMediaFile.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested media file in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::MediaFile> GetMediaFileAsync(GetMediaFileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMediaFileRequest(ref request, ref callSettings);
            return _callGetMediaFile.Async(request, callSettings);
        }

        /// <summary>
        /// Creates media files. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateMediaFilesResponse MutateMediaFiles(MutateMediaFilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateMediaFilesRequest(ref request, ref callSettings);
            return _callMutateMediaFiles.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates media files. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateMediaFilesResponse> MutateMediaFilesAsync(MutateMediaFilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateMediaFilesRequest(ref request, ref callSettings);
            return _callMutateMediaFiles.Async(request, callSettings);
        }
    }
}

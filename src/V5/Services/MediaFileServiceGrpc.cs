// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/services/media_file_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V5.Services {
  /// <summary>
  /// Service to manage media files.
  /// </summary>
  public static partial class MediaFileService
  {
    static readonly string __ServiceName = "google.ads.googleads.v5.services.MediaFileService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.GetMediaFileRequest> __Marshaller_google_ads_googleads_v5_services_GetMediaFileRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.GetMediaFileRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Resources.MediaFile> __Marshaller_google_ads_googleads_v5_resources_MediaFile = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Resources.MediaFile.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesRequest> __Marshaller_google_ads_googleads_v5_services_MutateMediaFilesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesResponse> __Marshaller_google_ads_googleads_v5_services_MutateMediaFilesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesResponse.Parser));

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.GetMediaFileRequest, global::Google.Ads.GoogleAds.V5.Resources.MediaFile> __Method_GetMediaFile = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.GetMediaFileRequest, global::Google.Ads.GoogleAds.V5.Resources.MediaFile>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetMediaFile",
        __Marshaller_google_ads_googleads_v5_services_GetMediaFileRequest,
        __Marshaller_google_ads_googleads_v5_resources_MediaFile);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesRequest, global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesResponse> __Method_MutateMediaFiles = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesRequest, global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateMediaFiles",
        __Marshaller_google_ads_googleads_v5_services_MutateMediaFilesRequest,
        __Marshaller_google_ads_googleads_v5_services_MutateMediaFilesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V5.Services.MediaFileServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MediaFileService</summary>
    [grpc::BindServiceMethod(typeof(MediaFileService), "BindService")]
    public abstract partial class MediaFileServiceBase
    {
      /// <summary>
      /// Returns the requested media file in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Resources.MediaFile> GetMediaFile(global::Google.Ads.GoogleAds.V5.Services.GetMediaFileRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates media files. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesResponse> MutateMediaFiles(global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MediaFileService</summary>
    public partial class MediaFileServiceClient : grpc::ClientBase<MediaFileServiceClient>
    {
      /// <summary>Creates a new client for MediaFileService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MediaFileServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MediaFileService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MediaFileServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MediaFileServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MediaFileServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested media file in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Resources.MediaFile GetMediaFile(global::Google.Ads.GoogleAds.V5.Services.GetMediaFileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetMediaFile(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested media file in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Resources.MediaFile GetMediaFile(global::Google.Ads.GoogleAds.V5.Services.GetMediaFileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetMediaFile, null, options, request);
      }
      /// <summary>
      /// Returns the requested media file in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Resources.MediaFile> GetMediaFileAsync(global::Google.Ads.GoogleAds.V5.Services.GetMediaFileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetMediaFileAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested media file in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Resources.MediaFile> GetMediaFileAsync(global::Google.Ads.GoogleAds.V5.Services.GetMediaFileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetMediaFile, null, options, request);
      }
      /// <summary>
      /// Creates media files. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesResponse MutateMediaFiles(global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateMediaFiles(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates media files. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesResponse MutateMediaFiles(global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateMediaFiles, null, options, request);
      }
      /// <summary>
      /// Creates media files. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesResponse> MutateMediaFilesAsync(global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateMediaFilesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates media files. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesResponse> MutateMediaFilesAsync(global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateMediaFiles, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MediaFileServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MediaFileServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MediaFileServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetMediaFile, serviceImpl.GetMediaFile)
          .AddMethod(__Method_MutateMediaFiles, serviceImpl.MutateMediaFiles).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MediaFileServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetMediaFile, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.GetMediaFileRequest, global::Google.Ads.GoogleAds.V5.Resources.MediaFile>(serviceImpl.GetMediaFile));
      serviceBinder.AddMethod(__Method_MutateMediaFiles, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesRequest, global::Google.Ads.GoogleAds.V5.Services.MutateMediaFilesResponse>(serviceImpl.MutateMediaFiles));
    }

  }
}
#endregion

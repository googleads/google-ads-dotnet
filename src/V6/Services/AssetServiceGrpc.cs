// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v6/services/asset_service.proto
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

namespace Google.Ads.GoogleAds.V6.Services {
  /// <summary>
  /// Service to manage assets. Asset types can be created with AssetService are
  /// YoutubeVideoAsset, MediaBundleAsset and ImageAsset. TextAsset should be
  /// created with Ad inline.
  /// </summary>
  public static partial class AssetService
  {
    static readonly string __ServiceName = "google.ads.googleads.v6.services.AssetService";

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

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V6.Services.GetAssetRequest> __Marshaller_google_ads_googleads_v6_services_GetAssetRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V6.Services.GetAssetRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V6.Resources.Asset> __Marshaller_google_ads_googleads_v6_resources_Asset = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V6.Resources.Asset.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V6.Services.MutateAssetsRequest> __Marshaller_google_ads_googleads_v6_services_MutateAssetsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V6.Services.MutateAssetsRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V6.Services.MutateAssetsResponse> __Marshaller_google_ads_googleads_v6_services_MutateAssetsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V6.Services.MutateAssetsResponse.Parser));

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V6.Services.GetAssetRequest, global::Google.Ads.GoogleAds.V6.Resources.Asset> __Method_GetAsset = new grpc::Method<global::Google.Ads.GoogleAds.V6.Services.GetAssetRequest, global::Google.Ads.GoogleAds.V6.Resources.Asset>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAsset",
        __Marshaller_google_ads_googleads_v6_services_GetAssetRequest,
        __Marshaller_google_ads_googleads_v6_resources_Asset);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V6.Services.MutateAssetsRequest, global::Google.Ads.GoogleAds.V6.Services.MutateAssetsResponse> __Method_MutateAssets = new grpc::Method<global::Google.Ads.GoogleAds.V6.Services.MutateAssetsRequest, global::Google.Ads.GoogleAds.V6.Services.MutateAssetsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateAssets",
        __Marshaller_google_ads_googleads_v6_services_MutateAssetsRequest,
        __Marshaller_google_ads_googleads_v6_services_MutateAssetsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V6.Services.AssetServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AssetService</summary>
    [grpc::BindServiceMethod(typeof(AssetService), "BindService")]
    public abstract partial class AssetServiceBase
    {
      /// <summary>
      /// Returns the requested asset in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V6.Resources.Asset> GetAsset(global::Google.Ads.GoogleAds.V6.Services.GetAssetRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates assets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V6.Services.MutateAssetsResponse> MutateAssets(global::Google.Ads.GoogleAds.V6.Services.MutateAssetsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AssetService</summary>
    public partial class AssetServiceClient : grpc::ClientBase<AssetServiceClient>
    {
      /// <summary>Creates a new client for AssetService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AssetServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AssetService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AssetServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AssetServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AssetServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested asset in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V6.Resources.Asset GetAsset(global::Google.Ads.GoogleAds.V6.Services.GetAssetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsset(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested asset in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V6.Resources.Asset GetAsset(global::Google.Ads.GoogleAds.V6.Services.GetAssetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAsset, null, options, request);
      }
      /// <summary>
      /// Returns the requested asset in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V6.Resources.Asset> GetAssetAsync(global::Google.Ads.GoogleAds.V6.Services.GetAssetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAssetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested asset in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V6.Resources.Asset> GetAssetAsync(global::Google.Ads.GoogleAds.V6.Services.GetAssetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAsset, null, options, request);
      }
      /// <summary>
      /// Creates assets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V6.Services.MutateAssetsResponse MutateAssets(global::Google.Ads.GoogleAds.V6.Services.MutateAssetsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAssets(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates assets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V6.Services.MutateAssetsResponse MutateAssets(global::Google.Ads.GoogleAds.V6.Services.MutateAssetsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateAssets, null, options, request);
      }
      /// <summary>
      /// Creates assets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V6.Services.MutateAssetsResponse> MutateAssetsAsync(global::Google.Ads.GoogleAds.V6.Services.MutateAssetsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAssetsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates assets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V6.Services.MutateAssetsResponse> MutateAssetsAsync(global::Google.Ads.GoogleAds.V6.Services.MutateAssetsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateAssets, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AssetServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AssetServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AssetServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAsset, serviceImpl.GetAsset)
          .AddMethod(__Method_MutateAssets, serviceImpl.MutateAssets).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AssetServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAsset, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V6.Services.GetAssetRequest, global::Google.Ads.GoogleAds.V6.Resources.Asset>(serviceImpl.GetAsset));
      serviceBinder.AddMethod(__Method_MutateAssets, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V6.Services.MutateAssetsRequest, global::Google.Ads.GoogleAds.V6.Services.MutateAssetsResponse>(serviceImpl.MutateAssets));
    }

  }
}
#endregion

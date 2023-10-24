// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v15/services/asset_group_listing_group_filter_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2023 Google LLC
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
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V15.Services {
  /// <summary>
  /// Service to manage asset group listing group filter.
  /// </summary>
  public static partial class AssetGroupListingGroupFilterService
  {
    static readonly string __ServiceName = "google.ads.googleads.v15.services.AssetGroupListingGroupFilterService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersRequest> __Marshaller_google_ads_googleads_v15_services_MutateAssetGroupListingGroupFiltersRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersResponse> __Marshaller_google_ads_googleads_v15_services_MutateAssetGroupListingGroupFiltersResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersRequest, global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersResponse> __Method_MutateAssetGroupListingGroupFilters = new grpc::Method<global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersRequest, global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateAssetGroupListingGroupFilters",
        __Marshaller_google_ads_googleads_v15_services_MutateAssetGroupListingGroupFiltersRequest,
        __Marshaller_google_ads_googleads_v15_services_MutateAssetGroupListingGroupFiltersResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V15.Services.AssetGroupListingGroupFilterServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AssetGroupListingGroupFilterService</summary>
    [grpc::BindServiceMethod(typeof(AssetGroupListingGroupFilterService), "BindService")]
    public abstract partial class AssetGroupListingGroupFilterServiceBase
    {
      /// <summary>
      /// Creates, updates or removes asset group listing group filters. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersResponse> MutateAssetGroupListingGroupFilters(global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AssetGroupListingGroupFilterService</summary>
    public partial class AssetGroupListingGroupFilterServiceClient : grpc::ClientBase<AssetGroupListingGroupFilterServiceClient>
    {
      /// <summary>Creates a new client for AssetGroupListingGroupFilterService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public AssetGroupListingGroupFilterServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AssetGroupListingGroupFilterService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public AssetGroupListingGroupFilterServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected AssetGroupListingGroupFilterServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected AssetGroupListingGroupFilterServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates, updates or removes asset group listing group filters. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersResponse MutateAssetGroupListingGroupFilters(global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAssetGroupListingGroupFilters(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates or removes asset group listing group filters. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersResponse MutateAssetGroupListingGroupFilters(global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateAssetGroupListingGroupFilters, null, options, request);
      }
      /// <summary>
      /// Creates, updates or removes asset group listing group filters. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersResponse> MutateAssetGroupListingGroupFiltersAsync(global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAssetGroupListingGroupFiltersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates or removes asset group listing group filters. Operation
      /// statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersResponse> MutateAssetGroupListingGroupFiltersAsync(global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateAssetGroupListingGroupFilters, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override AssetGroupListingGroupFilterServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AssetGroupListingGroupFilterServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(AssetGroupListingGroupFilterServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_MutateAssetGroupListingGroupFilters, serviceImpl.MutateAssetGroupListingGroupFilters).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AssetGroupListingGroupFilterServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_MutateAssetGroupListingGroupFilters, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersRequest, global::Google.Ads.GoogleAds.V15.Services.MutateAssetGroupListingGroupFiltersResponse>(serviceImpl.MutateAssetGroupListingGroupFilters));
    }

  }
}
#endregion

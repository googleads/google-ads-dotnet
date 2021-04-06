// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/services/customer_manager_link_service.proto
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
  /// Service to manage customer-manager links.
  /// </summary>
  public static partial class CustomerManagerLinkService
  {
    static readonly string __ServiceName = "google.ads.googleads.v5.services.CustomerManagerLinkService";

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

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.GetCustomerManagerLinkRequest> __Marshaller_google_ads_googleads_v5_services_GetCustomerManagerLinkRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.GetCustomerManagerLinkRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Resources.CustomerManagerLink> __Marshaller_google_ads_googleads_v5_resources_CustomerManagerLink = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Resources.CustomerManagerLink.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkRequest> __Marshaller_google_ads_googleads_v5_services_MutateCustomerManagerLinkRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkResponse> __Marshaller_google_ads_googleads_v5_services_MutateCustomerManagerLinkResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkResponse.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkRequest> __Marshaller_google_ads_googleads_v5_services_MoveManagerLinkRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkResponse> __Marshaller_google_ads_googleads_v5_services_MoveManagerLinkResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkResponse.Parser));

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.GetCustomerManagerLinkRequest, global::Google.Ads.GoogleAds.V5.Resources.CustomerManagerLink> __Method_GetCustomerManagerLink = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.GetCustomerManagerLinkRequest, global::Google.Ads.GoogleAds.V5.Resources.CustomerManagerLink>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomerManagerLink",
        __Marshaller_google_ads_googleads_v5_services_GetCustomerManagerLinkRequest,
        __Marshaller_google_ads_googleads_v5_resources_CustomerManagerLink);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkRequest, global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkResponse> __Method_MutateCustomerManagerLink = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkRequest, global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateCustomerManagerLink",
        __Marshaller_google_ads_googleads_v5_services_MutateCustomerManagerLinkRequest,
        __Marshaller_google_ads_googleads_v5_services_MutateCustomerManagerLinkResponse);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkRequest, global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkResponse> __Method_MoveManagerLink = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkRequest, global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MoveManagerLink",
        __Marshaller_google_ads_googleads_v5_services_MoveManagerLinkRequest,
        __Marshaller_google_ads_googleads_v5_services_MoveManagerLinkResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V5.Services.CustomerManagerLinkServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CustomerManagerLinkService</summary>
    [grpc::BindServiceMethod(typeof(CustomerManagerLinkService), "BindService")]
    public abstract partial class CustomerManagerLinkServiceBase
    {
      /// <summary>
      /// Returns the requested CustomerManagerLink in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Resources.CustomerManagerLink> GetCustomerManagerLink(global::Google.Ads.GoogleAds.V5.Services.GetCustomerManagerLinkRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates or updates customer manager links. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkResponse> MutateCustomerManagerLink(global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Moves a client customer to a new manager customer.
      /// This simplifies the complex request that requires two operations to move
      /// a client customer to a new manager. i.e:
      /// 1. Update operation with Status INACTIVE (previous manager) and,
      /// 2. Update operation with Status ACTIVE (new manager).
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkResponse> MoveManagerLink(global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CustomerManagerLinkService</summary>
    public partial class CustomerManagerLinkServiceClient : grpc::ClientBase<CustomerManagerLinkServiceClient>
    {
      /// <summary>Creates a new client for CustomerManagerLinkService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CustomerManagerLinkServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CustomerManagerLinkService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CustomerManagerLinkServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CustomerManagerLinkServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CustomerManagerLinkServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested CustomerManagerLink in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Resources.CustomerManagerLink GetCustomerManagerLink(global::Google.Ads.GoogleAds.V5.Services.GetCustomerManagerLinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerManagerLink(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested CustomerManagerLink in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Resources.CustomerManagerLink GetCustomerManagerLink(global::Google.Ads.GoogleAds.V5.Services.GetCustomerManagerLinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCustomerManagerLink, null, options, request);
      }
      /// <summary>
      /// Returns the requested CustomerManagerLink in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Resources.CustomerManagerLink> GetCustomerManagerLinkAsync(global::Google.Ads.GoogleAds.V5.Services.GetCustomerManagerLinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerManagerLinkAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested CustomerManagerLink in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Resources.CustomerManagerLink> GetCustomerManagerLinkAsync(global::Google.Ads.GoogleAds.V5.Services.GetCustomerManagerLinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCustomerManagerLink, null, options, request);
      }
      /// <summary>
      /// Creates or updates customer manager links. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkResponse MutateCustomerManagerLink(global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCustomerManagerLink(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or updates customer manager links. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkResponse MutateCustomerManagerLink(global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateCustomerManagerLink, null, options, request);
      }
      /// <summary>
      /// Creates or updates customer manager links. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkResponse> MutateCustomerManagerLinkAsync(global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCustomerManagerLinkAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or updates customer manager links. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkResponse> MutateCustomerManagerLinkAsync(global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateCustomerManagerLink, null, options, request);
      }
      /// <summary>
      /// Moves a client customer to a new manager customer.
      /// This simplifies the complex request that requires two operations to move
      /// a client customer to a new manager. i.e:
      /// 1. Update operation with Status INACTIVE (previous manager) and,
      /// 2. Update operation with Status ACTIVE (new manager).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkResponse MoveManagerLink(global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MoveManagerLink(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Moves a client customer to a new manager customer.
      /// This simplifies the complex request that requires two operations to move
      /// a client customer to a new manager. i.e:
      /// 1. Update operation with Status INACTIVE (previous manager) and,
      /// 2. Update operation with Status ACTIVE (new manager).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkResponse MoveManagerLink(global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MoveManagerLink, null, options, request);
      }
      /// <summary>
      /// Moves a client customer to a new manager customer.
      /// This simplifies the complex request that requires two operations to move
      /// a client customer to a new manager. i.e:
      /// 1. Update operation with Status INACTIVE (previous manager) and,
      /// 2. Update operation with Status ACTIVE (new manager).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkResponse> MoveManagerLinkAsync(global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MoveManagerLinkAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Moves a client customer to a new manager customer.
      /// This simplifies the complex request that requires two operations to move
      /// a client customer to a new manager. i.e:
      /// 1. Update operation with Status INACTIVE (previous manager) and,
      /// 2. Update operation with Status ACTIVE (new manager).
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkResponse> MoveManagerLinkAsync(global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MoveManagerLink, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CustomerManagerLinkServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CustomerManagerLinkServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CustomerManagerLinkServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCustomerManagerLink, serviceImpl.GetCustomerManagerLink)
          .AddMethod(__Method_MutateCustomerManagerLink, serviceImpl.MutateCustomerManagerLink)
          .AddMethod(__Method_MoveManagerLink, serviceImpl.MoveManagerLink).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CustomerManagerLinkServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCustomerManagerLink, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.GetCustomerManagerLinkRequest, global::Google.Ads.GoogleAds.V5.Resources.CustomerManagerLink>(serviceImpl.GetCustomerManagerLink));
      serviceBinder.AddMethod(__Method_MutateCustomerManagerLink, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkRequest, global::Google.Ads.GoogleAds.V5.Services.MutateCustomerManagerLinkResponse>(serviceImpl.MutateCustomerManagerLink));
      serviceBinder.AddMethod(__Method_MoveManagerLink, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkRequest, global::Google.Ads.GoogleAds.V5.Services.MoveManagerLinkResponse>(serviceImpl.MoveManagerLink));
    }

  }
}
#endregion

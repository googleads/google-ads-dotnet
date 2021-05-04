// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/services/customer_user_access_service.proto
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

namespace Google.Ads.GoogleAds.V7.Services {
  /// <summary>
  /// This service manages the permissions of a user on a given customer.
  /// </summary>
  public static partial class CustomerUserAccessService
  {
    static readonly string __ServiceName = "google.ads.googleads.v7.services.CustomerUserAccessService";

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

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V7.Services.GetCustomerUserAccessRequest> __Marshaller_google_ads_googleads_v7_services_GetCustomerUserAccessRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V7.Services.GetCustomerUserAccessRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V7.Resources.CustomerUserAccess> __Marshaller_google_ads_googleads_v7_resources_CustomerUserAccess = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V7.Resources.CustomerUserAccess.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessRequest> __Marshaller_google_ads_googleads_v7_services_MutateCustomerUserAccessRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessResponse> __Marshaller_google_ads_googleads_v7_services_MutateCustomerUserAccessResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessResponse.Parser));

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V7.Services.GetCustomerUserAccessRequest, global::Google.Ads.GoogleAds.V7.Resources.CustomerUserAccess> __Method_GetCustomerUserAccess = new grpc::Method<global::Google.Ads.GoogleAds.V7.Services.GetCustomerUserAccessRequest, global::Google.Ads.GoogleAds.V7.Resources.CustomerUserAccess>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCustomerUserAccess",
        __Marshaller_google_ads_googleads_v7_services_GetCustomerUserAccessRequest,
        __Marshaller_google_ads_googleads_v7_resources_CustomerUserAccess);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessRequest, global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessResponse> __Method_MutateCustomerUserAccess = new grpc::Method<global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessRequest, global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateCustomerUserAccess",
        __Marshaller_google_ads_googleads_v7_services_MutateCustomerUserAccessRequest,
        __Marshaller_google_ads_googleads_v7_services_MutateCustomerUserAccessResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V7.Services.CustomerUserAccessServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CustomerUserAccessService</summary>
    [grpc::BindServiceMethod(typeof(CustomerUserAccessService), "BindService")]
    public abstract partial class CustomerUserAccessServiceBase
    {
      /// <summary>
      /// Returns the CustomerUserAccess in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V7.Resources.CustomerUserAccess> GetCustomerUserAccess(global::Google.Ads.GoogleAds.V7.Services.GetCustomerUserAccessRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates, removes permission of a user on a given customer. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CustomerUserAccessError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessResponse> MutateCustomerUserAccess(global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CustomerUserAccessService</summary>
    public partial class CustomerUserAccessServiceClient : grpc::ClientBase<CustomerUserAccessServiceClient>
    {
      /// <summary>Creates a new client for CustomerUserAccessService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CustomerUserAccessServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CustomerUserAccessService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CustomerUserAccessServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CustomerUserAccessServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CustomerUserAccessServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the CustomerUserAccess in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V7.Resources.CustomerUserAccess GetCustomerUserAccess(global::Google.Ads.GoogleAds.V7.Services.GetCustomerUserAccessRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerUserAccess(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the CustomerUserAccess in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V7.Resources.CustomerUserAccess GetCustomerUserAccess(global::Google.Ads.GoogleAds.V7.Services.GetCustomerUserAccessRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCustomerUserAccess, null, options, request);
      }
      /// <summary>
      /// Returns the CustomerUserAccess in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V7.Resources.CustomerUserAccess> GetCustomerUserAccessAsync(global::Google.Ads.GoogleAds.V7.Services.GetCustomerUserAccessRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCustomerUserAccessAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the CustomerUserAccess in full detail.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V7.Resources.CustomerUserAccess> GetCustomerUserAccessAsync(global::Google.Ads.GoogleAds.V7.Services.GetCustomerUserAccessRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCustomerUserAccess, null, options, request);
      }
      /// <summary>
      /// Updates, removes permission of a user on a given customer. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CustomerUserAccessError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessResponse MutateCustomerUserAccess(global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCustomerUserAccess(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates, removes permission of a user on a given customer. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CustomerUserAccessError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessResponse MutateCustomerUserAccess(global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateCustomerUserAccess, null, options, request);
      }
      /// <summary>
      /// Updates, removes permission of a user on a given customer. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CustomerUserAccessError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessResponse> MutateCustomerUserAccessAsync(global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCustomerUserAccessAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates, removes permission of a user on a given customer. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CustomerUserAccessError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessResponse> MutateCustomerUserAccessAsync(global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateCustomerUserAccess, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CustomerUserAccessServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CustomerUserAccessServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CustomerUserAccessServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCustomerUserAccess, serviceImpl.GetCustomerUserAccess)
          .AddMethod(__Method_MutateCustomerUserAccess, serviceImpl.MutateCustomerUserAccess).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CustomerUserAccessServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCustomerUserAccess, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V7.Services.GetCustomerUserAccessRequest, global::Google.Ads.GoogleAds.V7.Resources.CustomerUserAccess>(serviceImpl.GetCustomerUserAccess));
      serviceBinder.AddMethod(__Method_MutateCustomerUserAccess, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessRequest, global::Google.Ads.GoogleAds.V7.Services.MutateCustomerUserAccessResponse>(serviceImpl.MutateCustomerUserAccess));
    }

  }
}
#endregion

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/services/customer_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2025 Google LLC
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
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V20.Services {
  /// <summary>
  /// Service to manage customers.
  /// </summary>
  public static partial class CustomerService
  {
    static readonly string __ServiceName = "google.ads.googleads.v20.services.CustomerService";

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
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V20.Services.MutateCustomerRequest> __Marshaller_google_ads_googleads_v20_services_MutateCustomerRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V20.Services.MutateCustomerRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V20.Services.MutateCustomerResponse> __Marshaller_google_ads_googleads_v20_services_MutateCustomerResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V20.Services.MutateCustomerResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersRequest> __Marshaller_google_ads_googleads_v20_services_ListAccessibleCustomersRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersResponse> __Marshaller_google_ads_googleads_v20_services_ListAccessibleCustomersResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientRequest> __Marshaller_google_ads_googleads_v20_services_CreateCustomerClientRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientResponse> __Marshaller_google_ads_googleads_v20_services_CreateCustomerClientResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V20.Services.MutateCustomerRequest, global::Google.Ads.GoogleAds.V20.Services.MutateCustomerResponse> __Method_MutateCustomer = new grpc::Method<global::Google.Ads.GoogleAds.V20.Services.MutateCustomerRequest, global::Google.Ads.GoogleAds.V20.Services.MutateCustomerResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateCustomer",
        __Marshaller_google_ads_googleads_v20_services_MutateCustomerRequest,
        __Marshaller_google_ads_googleads_v20_services_MutateCustomerResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersRequest, global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersResponse> __Method_ListAccessibleCustomers = new grpc::Method<global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersRequest, global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListAccessibleCustomers",
        __Marshaller_google_ads_googleads_v20_services_ListAccessibleCustomersRequest,
        __Marshaller_google_ads_googleads_v20_services_ListAccessibleCustomersResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientRequest, global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientResponse> __Method_CreateCustomerClient = new grpc::Method<global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientRequest, global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateCustomerClient",
        __Marshaller_google_ads_googleads_v20_services_CreateCustomerClientRequest,
        __Marshaller_google_ads_googleads_v20_services_CreateCustomerClientResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V20.Services.CustomerServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CustomerService</summary>
    [grpc::BindServiceMethod(typeof(CustomerService), "BindService")]
    public abstract partial class CustomerServiceBase
    {
      /// <summary>
      /// Updates a customer. Operation statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [UrlFieldError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V20.Services.MutateCustomerResponse> MutateCustomer(global::Google.Ads.GoogleAds.V20.Services.MutateCustomerRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns resource names of customers directly accessible by the
      /// user authenticating the call.
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
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersResponse> ListAccessibleCustomers(global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a new client under manager. The new client customer is returned.
      ///
      /// List of thrown errors:
      ///   [AccessInvitationError]()
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CurrencyCodeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [ManagerLinkError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [StringLengthError]()
      ///   [TimeZoneError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientResponse> CreateCustomerClient(global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CustomerService</summary>
    public partial class CustomerServiceClient : grpc::ClientBase<CustomerServiceClient>
    {
      /// <summary>Creates a new client for CustomerService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CustomerServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CustomerService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CustomerServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CustomerServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CustomerServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Updates a customer. Operation statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [UrlFieldError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V20.Services.MutateCustomerResponse MutateCustomer(global::Google.Ads.GoogleAds.V20.Services.MutateCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCustomer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates a customer. Operation statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [UrlFieldError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V20.Services.MutateCustomerResponse MutateCustomer(global::Google.Ads.GoogleAds.V20.Services.MutateCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateCustomer, null, options, request);
      }
      /// <summary>
      /// Updates a customer. Operation statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [UrlFieldError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V20.Services.MutateCustomerResponse> MutateCustomerAsync(global::Google.Ads.GoogleAds.V20.Services.MutateCustomerRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCustomerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates a customer. Operation statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [UrlFieldError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V20.Services.MutateCustomerResponse> MutateCustomerAsync(global::Google.Ads.GoogleAds.V20.Services.MutateCustomerRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateCustomer, null, options, request);
      }
      /// <summary>
      /// Returns resource names of customers directly accessible by the
      /// user authenticating the call.
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
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersResponse ListAccessibleCustomers(global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAccessibleCustomers(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns resource names of customers directly accessible by the
      /// user authenticating the call.
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
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersResponse ListAccessibleCustomers(global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListAccessibleCustomers, null, options, request);
      }
      /// <summary>
      /// Returns resource names of customers directly accessible by the
      /// user authenticating the call.
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
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersResponse> ListAccessibleCustomersAsync(global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAccessibleCustomersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns resource names of customers directly accessible by the
      /// user authenticating the call.
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
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersResponse> ListAccessibleCustomersAsync(global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListAccessibleCustomers, null, options, request);
      }
      /// <summary>
      /// Creates a new client under manager. The new client customer is returned.
      ///
      /// List of thrown errors:
      ///   [AccessInvitationError]()
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CurrencyCodeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [ManagerLinkError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [StringLengthError]()
      ///   [TimeZoneError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientResponse CreateCustomerClient(global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateCustomerClient(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new client under manager. The new client customer is returned.
      ///
      /// List of thrown errors:
      ///   [AccessInvitationError]()
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CurrencyCodeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [ManagerLinkError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [StringLengthError]()
      ///   [TimeZoneError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientResponse CreateCustomerClient(global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateCustomerClient, null, options, request);
      }
      /// <summary>
      /// Creates a new client under manager. The new client customer is returned.
      ///
      /// List of thrown errors:
      ///   [AccessInvitationError]()
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CurrencyCodeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [ManagerLinkError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [StringLengthError]()
      ///   [TimeZoneError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientResponse> CreateCustomerClientAsync(global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateCustomerClientAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new client under manager. The new client customer is returned.
      ///
      /// List of thrown errors:
      ///   [AccessInvitationError]()
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CurrencyCodeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [ManagerLinkError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [StringLengthError]()
      ///   [TimeZoneError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientResponse> CreateCustomerClientAsync(global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateCustomerClient, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override CustomerServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CustomerServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CustomerServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_MutateCustomer, serviceImpl.MutateCustomer)
          .AddMethod(__Method_ListAccessibleCustomers, serviceImpl.ListAccessibleCustomers)
          .AddMethod(__Method_CreateCustomerClient, serviceImpl.CreateCustomerClient).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CustomerServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_MutateCustomer, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V20.Services.MutateCustomerRequest, global::Google.Ads.GoogleAds.V20.Services.MutateCustomerResponse>(serviceImpl.MutateCustomer));
      serviceBinder.AddMethod(__Method_ListAccessibleCustomers, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersRequest, global::Google.Ads.GoogleAds.V20.Services.ListAccessibleCustomersResponse>(serviceImpl.ListAccessibleCustomers));
      serviceBinder.AddMethod(__Method_CreateCustomerClient, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientRequest, global::Google.Ads.GoogleAds.V20.Services.CreateCustomerClientResponse>(serviceImpl.CreateCustomerClient));
    }

  }
}
#endregion

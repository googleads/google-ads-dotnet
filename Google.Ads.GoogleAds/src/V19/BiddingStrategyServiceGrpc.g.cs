// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/services/bidding_strategy_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2024 Google LLC
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

namespace Google.Ads.GoogleAds.V19.Services {
  /// <summary>
  /// Service to manage bidding strategies.
  /// </summary>
  public static partial class BiddingStrategyService
  {
    static readonly string __ServiceName = "google.ads.googleads.v19.services.BiddingStrategyService";

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
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesRequest> __Marshaller_google_ads_googleads_v19_services_MutateBiddingStrategiesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesResponse> __Marshaller_google_ads_googleads_v19_services_MutateBiddingStrategiesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesRequest, global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesResponse> __Method_MutateBiddingStrategies = new grpc::Method<global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesRequest, global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateBiddingStrategies",
        __Marshaller_google_ads_googleads_v19_services_MutateBiddingStrategiesRequest,
        __Marshaller_google_ads_googleads_v19_services_MutateBiddingStrategiesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V19.Services.BiddingStrategyServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of BiddingStrategyService</summary>
    [grpc::BindServiceMethod(typeof(BiddingStrategyService), "BindService")]
    public abstract partial class BiddingStrategyServiceBase
    {
      /// <summary>
      /// Creates, updates, or removes bidding strategies. Operation statuses are
      /// returned.
      ///
      /// List of thrown errors:
      ///   [AdxError]()
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [BiddingError]()
      ///   [BiddingStrategyError]()
      ///   [ContextError]()
      ///   [DatabaseError]()
      ///   [DateError]()
      ///   [DistinctError]()
      ///   [FieldError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [IdError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [NewResourceCreationError]()
      ///   [NotEmptyError]()
      ///   [NullError]()
      ///   [OperationAccessDeniedError]()
      ///   [OperatorError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringFormatError]()
      ///   [StringLengthError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesResponse> MutateBiddingStrategies(global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for BiddingStrategyService</summary>
    public partial class BiddingStrategyServiceClient : grpc::ClientBase<BiddingStrategyServiceClient>
    {
      /// <summary>Creates a new client for BiddingStrategyService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public BiddingStrategyServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for BiddingStrategyService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public BiddingStrategyServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected BiddingStrategyServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected BiddingStrategyServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates, updates, or removes bidding strategies. Operation statuses are
      /// returned.
      ///
      /// List of thrown errors:
      ///   [AdxError]()
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [BiddingError]()
      ///   [BiddingStrategyError]()
      ///   [ContextError]()
      ///   [DatabaseError]()
      ///   [DateError]()
      ///   [DistinctError]()
      ///   [FieldError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [IdError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [NewResourceCreationError]()
      ///   [NotEmptyError]()
      ///   [NullError]()
      ///   [OperationAccessDeniedError]()
      ///   [OperatorError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringFormatError]()
      ///   [StringLengthError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesResponse MutateBiddingStrategies(global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateBiddingStrategies(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes bidding strategies. Operation statuses are
      /// returned.
      ///
      /// List of thrown errors:
      ///   [AdxError]()
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [BiddingError]()
      ///   [BiddingStrategyError]()
      ///   [ContextError]()
      ///   [DatabaseError]()
      ///   [DateError]()
      ///   [DistinctError]()
      ///   [FieldError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [IdError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [NewResourceCreationError]()
      ///   [NotEmptyError]()
      ///   [NullError]()
      ///   [OperationAccessDeniedError]()
      ///   [OperatorError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringFormatError]()
      ///   [StringLengthError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesResponse MutateBiddingStrategies(global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateBiddingStrategies, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes bidding strategies. Operation statuses are
      /// returned.
      ///
      /// List of thrown errors:
      ///   [AdxError]()
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [BiddingError]()
      ///   [BiddingStrategyError]()
      ///   [ContextError]()
      ///   [DatabaseError]()
      ///   [DateError]()
      ///   [DistinctError]()
      ///   [FieldError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [IdError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [NewResourceCreationError]()
      ///   [NotEmptyError]()
      ///   [NullError]()
      ///   [OperationAccessDeniedError]()
      ///   [OperatorError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringFormatError]()
      ///   [StringLengthError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateBiddingStrategiesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes bidding strategies. Operation statuses are
      /// returned.
      ///
      /// List of thrown errors:
      ///   [AdxError]()
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [BiddingError]()
      ///   [BiddingStrategyError]()
      ///   [ContextError]()
      ///   [DatabaseError]()
      ///   [DateError]()
      ///   [DistinctError]()
      ///   [FieldError]()
      ///   [FieldMaskError]()
      ///   [HeaderError]()
      ///   [IdError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [NewResourceCreationError]()
      ///   [NotEmptyError]()
      ///   [NullError]()
      ///   [OperationAccessDeniedError]()
      ///   [OperatorError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [RequestError]()
      ///   [SizeLimitError]()
      ///   [StringFormatError]()
      ///   [StringLengthError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateBiddingStrategies, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override BiddingStrategyServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BiddingStrategyServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(BiddingStrategyServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_MutateBiddingStrategies, serviceImpl.MutateBiddingStrategies).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BiddingStrategyServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_MutateBiddingStrategies, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesRequest, global::Google.Ads.GoogleAds.V19.Services.MutateBiddingStrategiesResponse>(serviceImpl.MutateBiddingStrategies));
    }

  }
}
#endregion

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/services/recommendation_subscription_service.proto
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
  /// Service to manage recommendation subscriptions.
  /// </summary>
  public static partial class RecommendationSubscriptionService
  {
    static readonly string __ServiceName = "google.ads.googleads.v20.services.RecommendationSubscriptionService";

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
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionRequest> __Marshaller_google_ads_googleads_v20_services_MutateRecommendationSubscriptionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionResponse> __Marshaller_google_ads_googleads_v20_services_MutateRecommendationSubscriptionResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionRequest, global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionResponse> __Method_MutateRecommendationSubscription = new grpc::Method<global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionRequest, global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateRecommendationSubscription",
        __Marshaller_google_ads_googleads_v20_services_MutateRecommendationSubscriptionRequest,
        __Marshaller_google_ads_googleads_v20_services_MutateRecommendationSubscriptionResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V20.Services.RecommendationSubscriptionServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RecommendationSubscriptionService</summary>
    [grpc::BindServiceMethod(typeof(RecommendationSubscriptionService), "BindService")]
    public abstract partial class RecommendationSubscriptionServiceBase
    {
      /// <summary>
      /// Mutates given subscription with corresponding apply parameters.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RecommendationError]()
      ///   [RequestError]()
      ///   [UrlFieldError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionResponse> MutateRecommendationSubscription(global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RecommendationSubscriptionService</summary>
    public partial class RecommendationSubscriptionServiceClient : grpc::ClientBase<RecommendationSubscriptionServiceClient>
    {
      /// <summary>Creates a new client for RecommendationSubscriptionService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public RecommendationSubscriptionServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RecommendationSubscriptionService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public RecommendationSubscriptionServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected RecommendationSubscriptionServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected RecommendationSubscriptionServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Mutates given subscription with corresponding apply parameters.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RecommendationError]()
      ///   [RequestError]()
      ///   [UrlFieldError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionResponse MutateRecommendationSubscription(global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateRecommendationSubscription(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Mutates given subscription with corresponding apply parameters.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RecommendationError]()
      ///   [RequestError]()
      ///   [UrlFieldError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionResponse MutateRecommendationSubscription(global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateRecommendationSubscription, null, options, request);
      }
      /// <summary>
      /// Mutates given subscription with corresponding apply parameters.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RecommendationError]()
      ///   [RequestError]()
      ///   [UrlFieldError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionResponse> MutateRecommendationSubscriptionAsync(global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateRecommendationSubscriptionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Mutates given subscription with corresponding apply parameters.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RecommendationError]()
      ///   [RequestError]()
      ///   [UrlFieldError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionResponse> MutateRecommendationSubscriptionAsync(global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateRecommendationSubscription, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override RecommendationSubscriptionServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RecommendationSubscriptionServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(RecommendationSubscriptionServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_MutateRecommendationSubscription, serviceImpl.MutateRecommendationSubscription).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RecommendationSubscriptionServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_MutateRecommendationSubscription, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionRequest, global::Google.Ads.GoogleAds.V20.Services.MutateRecommendationSubscriptionResponse>(serviceImpl.MutateRecommendationSubscription));
    }

  }
}
#endregion

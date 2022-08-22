// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/services/keyword_plan_ad_group_keyword_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2022 Google LLC
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

namespace Google.Ads.GoogleAds.V10.Services {
  /// <summary>
  /// Service to manage Keyword Plan ad group keywords. KeywordPlanAdGroup is
  /// required to add ad group keywords. Positive and negative keywords are
  /// supported. A maximum of 10,000 positive keywords are allowed per keyword
  /// plan. A maximum of 1,000 negative keywords are allower per keyword plan. This
  /// includes campaign negative keywords and ad group negative keywords.
  /// </summary>
  public static partial class KeywordPlanAdGroupKeywordService
  {
    static readonly string __ServiceName = "google.ads.googleads.v10.services.KeywordPlanAdGroupKeywordService";

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
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsRequest> __Marshaller_google_ads_googleads_v10_services_MutateKeywordPlanAdGroupKeywordsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsResponse> __Marshaller_google_ads_googleads_v10_services_MutateKeywordPlanAdGroupKeywordsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsRequest, global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsResponse> __Method_MutateKeywordPlanAdGroupKeywords = new grpc::Method<global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsRequest, global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateKeywordPlanAdGroupKeywords",
        __Marshaller_google_ads_googleads_v10_services_MutateKeywordPlanAdGroupKeywordsRequest,
        __Marshaller_google_ads_googleads_v10_services_MutateKeywordPlanAdGroupKeywordsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V10.Services.KeywordPlanAdGroupKeywordServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of KeywordPlanAdGroupKeywordService</summary>
    [grpc::BindServiceMethod(typeof(KeywordPlanAdGroupKeywordService), "BindService")]
    public abstract partial class KeywordPlanAdGroupKeywordServiceBase
    {
      /// <summary>
      /// Creates, updates, or removes Keyword Plan ad group keywords. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [KeywordPlanAdGroupKeywordError]()
      ///   [KeywordPlanError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [ResourceCountLimitExceededError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsResponse> MutateKeywordPlanAdGroupKeywords(global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for KeywordPlanAdGroupKeywordService</summary>
    public partial class KeywordPlanAdGroupKeywordServiceClient : grpc::ClientBase<KeywordPlanAdGroupKeywordServiceClient>
    {
      /// <summary>Creates a new client for KeywordPlanAdGroupKeywordService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public KeywordPlanAdGroupKeywordServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for KeywordPlanAdGroupKeywordService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public KeywordPlanAdGroupKeywordServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected KeywordPlanAdGroupKeywordServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected KeywordPlanAdGroupKeywordServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates, updates, or removes Keyword Plan ad group keywords. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [KeywordPlanAdGroupKeywordError]()
      ///   [KeywordPlanError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [ResourceCountLimitExceededError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsResponse MutateKeywordPlanAdGroupKeywords(global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateKeywordPlanAdGroupKeywords(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan ad group keywords. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [KeywordPlanAdGroupKeywordError]()
      ///   [KeywordPlanError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [ResourceCountLimitExceededError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsResponse MutateKeywordPlanAdGroupKeywords(global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateKeywordPlanAdGroupKeywords, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan ad group keywords. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [KeywordPlanAdGroupKeywordError]()
      ///   [KeywordPlanError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [ResourceCountLimitExceededError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsResponse> MutateKeywordPlanAdGroupKeywordsAsync(global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateKeywordPlanAdGroupKeywordsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes Keyword Plan ad group keywords. Operation
      /// statuses are returned.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [KeywordPlanAdGroupKeywordError]()
      ///   [KeywordPlanError]()
      ///   [MutateError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      ///   [ResourceCountLimitExceededError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsResponse> MutateKeywordPlanAdGroupKeywordsAsync(global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateKeywordPlanAdGroupKeywords, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override KeywordPlanAdGroupKeywordServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new KeywordPlanAdGroupKeywordServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(KeywordPlanAdGroupKeywordServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_MutateKeywordPlanAdGroupKeywords, serviceImpl.MutateKeywordPlanAdGroupKeywords).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, KeywordPlanAdGroupKeywordServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_MutateKeywordPlanAdGroupKeywords, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsRequest, global::Google.Ads.GoogleAds.V10.Services.MutateKeywordPlanAdGroupKeywordsResponse>(serviceImpl.MutateKeywordPlanAdGroupKeywords));
    }

  }
}
#endregion

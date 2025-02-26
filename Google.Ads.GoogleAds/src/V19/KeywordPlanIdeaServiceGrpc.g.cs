// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/services/keyword_plan_idea_service.proto
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
  /// Service to generate keyword ideas.
  /// </summary>
  public static partial class KeywordPlanIdeaService
  {
    static readonly string __ServiceName = "google.ads.googleads.v19.services.KeywordPlanIdeaService";

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
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeasRequest> __Marshaller_google_ads_googleads_v19_services_GenerateKeywordIdeasRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeasRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeaResponse> __Marshaller_google_ads_googleads_v19_services_GenerateKeywordIdeaResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeaResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsRequest> __Marshaller_google_ads_googleads_v19_services_GenerateKeywordHistoricalMetricsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsResponse> __Marshaller_google_ads_googleads_v19_services_GenerateKeywordHistoricalMetricsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesRequest> __Marshaller_google_ads_googleads_v19_services_GenerateAdGroupThemesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesResponse> __Marshaller_google_ads_googleads_v19_services_GenerateAdGroupThemesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsRequest> __Marshaller_google_ads_googleads_v19_services_GenerateKeywordForecastMetricsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsResponse> __Marshaller_google_ads_googleads_v19_services_GenerateKeywordForecastMetricsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeasRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeaResponse> __Method_GenerateKeywordIdeas = new grpc::Method<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeasRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeaResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GenerateKeywordIdeas",
        __Marshaller_google_ads_googleads_v19_services_GenerateKeywordIdeasRequest,
        __Marshaller_google_ads_googleads_v19_services_GenerateKeywordIdeaResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsResponse> __Method_GenerateKeywordHistoricalMetrics = new grpc::Method<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GenerateKeywordHistoricalMetrics",
        __Marshaller_google_ads_googleads_v19_services_GenerateKeywordHistoricalMetricsRequest,
        __Marshaller_google_ads_googleads_v19_services_GenerateKeywordHistoricalMetricsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesResponse> __Method_GenerateAdGroupThemes = new grpc::Method<global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GenerateAdGroupThemes",
        __Marshaller_google_ads_googleads_v19_services_GenerateAdGroupThemesRequest,
        __Marshaller_google_ads_googleads_v19_services_GenerateAdGroupThemesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsResponse> __Method_GenerateKeywordForecastMetrics = new grpc::Method<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GenerateKeywordForecastMetrics",
        __Marshaller_google_ads_googleads_v19_services_GenerateKeywordForecastMetricsRequest,
        __Marshaller_google_ads_googleads_v19_services_GenerateKeywordForecastMetricsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V19.Services.KeywordPlanIdeaServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of KeywordPlanIdeaService</summary>
    [grpc::BindServiceMethod(typeof(KeywordPlanIdeaService), "BindService")]
    public abstract partial class KeywordPlanIdeaServiceBase
    {
      /// <summary>
      /// Returns a list of keyword ideas.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [KeywordPlanIdeaError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeaResponse> GenerateKeywordIdeas(global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeasRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns a list of keyword historical metrics.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsResponse> GenerateKeywordHistoricalMetrics(global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns a list of suggested AdGroups and suggested modifications
      /// (text, match type) for the given keywords.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesResponse> GenerateAdGroupThemes(global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns metrics (such as impressions, clicks, total cost) of a keyword
      /// forecast for the given campaign.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsResponse> GenerateKeywordForecastMetrics(global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for KeywordPlanIdeaService</summary>
    public partial class KeywordPlanIdeaServiceClient : grpc::ClientBase<KeywordPlanIdeaServiceClient>
    {
      /// <summary>Creates a new client for KeywordPlanIdeaService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public KeywordPlanIdeaServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for KeywordPlanIdeaService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public KeywordPlanIdeaServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected KeywordPlanIdeaServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected KeywordPlanIdeaServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns a list of keyword ideas.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [KeywordPlanIdeaError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeaResponse GenerateKeywordIdeas(global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeasRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateKeywordIdeas(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns a list of keyword ideas.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [KeywordPlanIdeaError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeaResponse GenerateKeywordIdeas(global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeasRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GenerateKeywordIdeas, null, options, request);
      }
      /// <summary>
      /// Returns a list of keyword ideas.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [KeywordPlanIdeaError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeaResponse> GenerateKeywordIdeasAsync(global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeasRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateKeywordIdeasAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns a list of keyword ideas.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [KeywordPlanIdeaError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeaResponse> GenerateKeywordIdeasAsync(global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeasRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GenerateKeywordIdeas, null, options, request);
      }
      /// <summary>
      /// Returns a list of keyword historical metrics.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
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
      public virtual global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsResponse GenerateKeywordHistoricalMetrics(global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateKeywordHistoricalMetrics(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns a list of keyword historical metrics.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsResponse GenerateKeywordHistoricalMetrics(global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GenerateKeywordHistoricalMetrics, null, options, request);
      }
      /// <summary>
      /// Returns a list of keyword historical metrics.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
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
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsResponse> GenerateKeywordHistoricalMetricsAsync(global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateKeywordHistoricalMetricsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns a list of keyword historical metrics.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsResponse> GenerateKeywordHistoricalMetricsAsync(global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GenerateKeywordHistoricalMetrics, null, options, request);
      }
      /// <summary>
      /// Returns a list of suggested AdGroups and suggested modifications
      /// (text, match type) for the given keywords.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
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
      public virtual global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesResponse GenerateAdGroupThemes(global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateAdGroupThemes(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns a list of suggested AdGroups and suggested modifications
      /// (text, match type) for the given keywords.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesResponse GenerateAdGroupThemes(global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GenerateAdGroupThemes, null, options, request);
      }
      /// <summary>
      /// Returns a list of suggested AdGroups and suggested modifications
      /// (text, match type) for the given keywords.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
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
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesResponse> GenerateAdGroupThemesAsync(global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateAdGroupThemesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns a list of suggested AdGroups and suggested modifications
      /// (text, match type) for the given keywords.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesResponse> GenerateAdGroupThemesAsync(global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GenerateAdGroupThemes, null, options, request);
      }
      /// <summary>
      /// Returns metrics (such as impressions, clicks, total cost) of a keyword
      /// forecast for the given campaign.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
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
      public virtual global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsResponse GenerateKeywordForecastMetrics(global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateKeywordForecastMetrics(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns metrics (such as impressions, clicks, total cost) of a keyword
      /// forecast for the given campaign.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsResponse GenerateKeywordForecastMetrics(global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GenerateKeywordForecastMetrics, null, options, request);
      }
      /// <summary>
      /// Returns metrics (such as impressions, clicks, total cost) of a keyword
      /// forecast for the given campaign.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
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
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsResponse> GenerateKeywordForecastMetricsAsync(global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateKeywordForecastMetricsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns metrics (such as impressions, clicks, total cost) of a keyword
      /// forecast for the given campaign.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [CollectionSizeError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsResponse> GenerateKeywordForecastMetricsAsync(global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GenerateKeywordForecastMetrics, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override KeywordPlanIdeaServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new KeywordPlanIdeaServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(KeywordPlanIdeaServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GenerateKeywordIdeas, serviceImpl.GenerateKeywordIdeas)
          .AddMethod(__Method_GenerateKeywordHistoricalMetrics, serviceImpl.GenerateKeywordHistoricalMetrics)
          .AddMethod(__Method_GenerateAdGroupThemes, serviceImpl.GenerateAdGroupThemes)
          .AddMethod(__Method_GenerateKeywordForecastMetrics, serviceImpl.GenerateKeywordForecastMetrics).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, KeywordPlanIdeaServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GenerateKeywordIdeas, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeasRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordIdeaResponse>(serviceImpl.GenerateKeywordIdeas));
      serviceBinder.AddMethod(__Method_GenerateKeywordHistoricalMetrics, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordHistoricalMetricsResponse>(serviceImpl.GenerateKeywordHistoricalMetrics));
      serviceBinder.AddMethod(__Method_GenerateAdGroupThemes, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateAdGroupThemesResponse>(serviceImpl.GenerateAdGroupThemes));
      serviceBinder.AddMethod(__Method_GenerateKeywordForecastMetrics, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateKeywordForecastMetricsResponse>(serviceImpl.GenerateKeywordForecastMetrics));
    }

  }
}
#endregion

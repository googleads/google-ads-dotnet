// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/services/reach_plan_service.proto
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

namespace Google.Ads.GoogleAds.V19.Services {
  /// <summary>
  /// Reach Plan Service gives users information about audience size that can
  /// be reached through advertisement on YouTube. In particular,
  /// GenerateReachForecast provides estimated number of people of specified
  /// demographics that can be reached by an ad in a given market by a campaign of
  /// certain duration with a defined budget.
  /// </summary>
  public static partial class ReachPlanService
  {
    static readonly string __ServiceName = "google.ads.googleads.v19.services.ReachPlanService";

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
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesRequest> __Marshaller_google_ads_googleads_v19_services_GenerateConversionRatesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesResponse> __Marshaller_google_ads_googleads_v19_services_GenerateConversionRatesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsRequest> __Marshaller_google_ads_googleads_v19_services_ListPlannableLocationsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsResponse> __Marshaller_google_ads_googleads_v19_services_ListPlannableLocationsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsRequest> __Marshaller_google_ads_googleads_v19_services_ListPlannableProductsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsResponse> __Marshaller_google_ads_googleads_v19_services_ListPlannableProductsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastRequest> __Marshaller_google_ads_googleads_v19_services_GenerateReachForecastRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastResponse> __Marshaller_google_ads_googleads_v19_services_GenerateReachForecastResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesResponse> __Method_GenerateConversionRates = new grpc::Method<global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GenerateConversionRates",
        __Marshaller_google_ads_googleads_v19_services_GenerateConversionRatesRequest,
        __Marshaller_google_ads_googleads_v19_services_GenerateConversionRatesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsRequest, global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsResponse> __Method_ListPlannableLocations = new grpc::Method<global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsRequest, global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListPlannableLocations",
        __Marshaller_google_ads_googleads_v19_services_ListPlannableLocationsRequest,
        __Marshaller_google_ads_googleads_v19_services_ListPlannableLocationsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsRequest, global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsResponse> __Method_ListPlannableProducts = new grpc::Method<global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsRequest, global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListPlannableProducts",
        __Marshaller_google_ads_googleads_v19_services_ListPlannableProductsRequest,
        __Marshaller_google_ads_googleads_v19_services_ListPlannableProductsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastResponse> __Method_GenerateReachForecast = new grpc::Method<global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GenerateReachForecast",
        __Marshaller_google_ads_googleads_v19_services_GenerateReachForecastRequest,
        __Marshaller_google_ads_googleads_v19_services_GenerateReachForecastResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V19.Services.ReachPlanServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ReachPlanService</summary>
    [grpc::BindServiceMethod(typeof(ReachPlanService), "BindService")]
    public abstract partial class ReachPlanServiceBase
    {
      /// <summary>
      /// Returns a collection of conversion rate suggestions for supported plannable
      /// products.
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
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesResponse> GenerateConversionRates(global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns the list of plannable locations (for example, countries).
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
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsResponse> ListPlannableLocations(global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns the list of per-location plannable YouTube ad formats with allowed
      /// targeting.
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
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsResponse> ListPlannableProducts(global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Generates a reach forecast for a given targeting / product mix.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [ReachPlanError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastResponse> GenerateReachForecast(global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ReachPlanService</summary>
    public partial class ReachPlanServiceClient : grpc::ClientBase<ReachPlanServiceClient>
    {
      /// <summary>Creates a new client for ReachPlanService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ReachPlanServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ReachPlanService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ReachPlanServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ReachPlanServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ReachPlanServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns a collection of conversion rate suggestions for supported plannable
      /// products.
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
      public virtual global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesResponse GenerateConversionRates(global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateConversionRates(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns a collection of conversion rate suggestions for supported plannable
      /// products.
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
      public virtual global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesResponse GenerateConversionRates(global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GenerateConversionRates, null, options, request);
      }
      /// <summary>
      /// Returns a collection of conversion rate suggestions for supported plannable
      /// products.
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
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesResponse> GenerateConversionRatesAsync(global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateConversionRatesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns a collection of conversion rate suggestions for supported plannable
      /// products.
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
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesResponse> GenerateConversionRatesAsync(global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GenerateConversionRates, null, options, request);
      }
      /// <summary>
      /// Returns the list of plannable locations (for example, countries).
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
      public virtual global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsResponse ListPlannableLocations(global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPlannableLocations(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of plannable locations (for example, countries).
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
      public virtual global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsResponse ListPlannableLocations(global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListPlannableLocations, null, options, request);
      }
      /// <summary>
      /// Returns the list of plannable locations (for example, countries).
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
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsResponse> ListPlannableLocationsAsync(global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPlannableLocationsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of plannable locations (for example, countries).
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
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsResponse> ListPlannableLocationsAsync(global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListPlannableLocations, null, options, request);
      }
      /// <summary>
      /// Returns the list of per-location plannable YouTube ad formats with allowed
      /// targeting.
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
      public virtual global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsResponse ListPlannableProducts(global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPlannableProducts(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of per-location plannable YouTube ad formats with allowed
      /// targeting.
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
      public virtual global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsResponse ListPlannableProducts(global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListPlannableProducts, null, options, request);
      }
      /// <summary>
      /// Returns the list of per-location plannable YouTube ad formats with allowed
      /// targeting.
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
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsResponse> ListPlannableProductsAsync(global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListPlannableProductsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the list of per-location plannable YouTube ad formats with allowed
      /// targeting.
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
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsResponse> ListPlannableProductsAsync(global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListPlannableProducts, null, options, request);
      }
      /// <summary>
      /// Generates a reach forecast for a given targeting / product mix.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [ReachPlanError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastResponse GenerateReachForecast(global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateReachForecast(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Generates a reach forecast for a given targeting / product mix.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [ReachPlanError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastResponse GenerateReachForecast(global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GenerateReachForecast, null, options, request);
      }
      /// <summary>
      /// Generates a reach forecast for a given targeting / product mix.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [ReachPlanError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastResponse> GenerateReachForecastAsync(global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GenerateReachForecastAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Generates a reach forecast for a given targeting / product mix.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [QuotaError]()
      ///   [RangeError]()
      ///   [ReachPlanError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastResponse> GenerateReachForecastAsync(global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GenerateReachForecast, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ReachPlanServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ReachPlanServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ReachPlanServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GenerateConversionRates, serviceImpl.GenerateConversionRates)
          .AddMethod(__Method_ListPlannableLocations, serviceImpl.ListPlannableLocations)
          .AddMethod(__Method_ListPlannableProducts, serviceImpl.ListPlannableProducts)
          .AddMethod(__Method_GenerateReachForecast, serviceImpl.GenerateReachForecast).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ReachPlanServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GenerateConversionRates, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateConversionRatesResponse>(serviceImpl.GenerateConversionRates));
      serviceBinder.AddMethod(__Method_ListPlannableLocations, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsRequest, global::Google.Ads.GoogleAds.V19.Services.ListPlannableLocationsResponse>(serviceImpl.ListPlannableLocations));
      serviceBinder.AddMethod(__Method_ListPlannableProducts, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsRequest, global::Google.Ads.GoogleAds.V19.Services.ListPlannableProductsResponse>(serviceImpl.ListPlannableProducts));
      serviceBinder.AddMethod(__Method_GenerateReachForecast, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastRequest, global::Google.Ads.GoogleAds.V19.Services.GenerateReachForecastResponse>(serviceImpl.GenerateReachForecast));
    }

  }
}
#endregion

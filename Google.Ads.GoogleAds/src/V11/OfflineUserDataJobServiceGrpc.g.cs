// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/services/offline_user_data_job_service.proto
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
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V11.Services {
  /// <summary>
  /// Service to manage offline user data jobs.
  /// </summary>
  public static partial class OfflineUserDataJobService
  {
    static readonly string __ServiceName = "google.ads.googleads.v11.services.OfflineUserDataJobService";

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
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobRequest> __Marshaller_google_ads_googleads_v11_services_CreateOfflineUserDataJobRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobResponse> __Marshaller_google_ads_googleads_v11_services_CreateOfflineUserDataJobResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsRequest> __Marshaller_google_ads_googleads_v11_services_AddOfflineUserDataJobOperationsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsResponse> __Marshaller_google_ads_googleads_v11_services_AddOfflineUserDataJobOperationsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V11.Services.RunOfflineUserDataJobRequest> __Marshaller_google_ads_googleads_v11_services_RunOfflineUserDataJobRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V11.Services.RunOfflineUserDataJobRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobRequest, global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobResponse> __Method_CreateOfflineUserDataJob = new grpc::Method<global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobRequest, global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateOfflineUserDataJob",
        __Marshaller_google_ads_googleads_v11_services_CreateOfflineUserDataJobRequest,
        __Marshaller_google_ads_googleads_v11_services_CreateOfflineUserDataJobResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsRequest, global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsResponse> __Method_AddOfflineUserDataJobOperations = new grpc::Method<global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsRequest, global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddOfflineUserDataJobOperations",
        __Marshaller_google_ads_googleads_v11_services_AddOfflineUserDataJobOperationsRequest,
        __Marshaller_google_ads_googleads_v11_services_AddOfflineUserDataJobOperationsResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Google.Ads.GoogleAds.V11.Services.RunOfflineUserDataJobRequest, global::Google.LongRunning.Operation> __Method_RunOfflineUserDataJob = new grpc::Method<global::Google.Ads.GoogleAds.V11.Services.RunOfflineUserDataJobRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RunOfflineUserDataJob",
        __Marshaller_google_ads_googleads_v11_services_RunOfflineUserDataJobRequest,
        __Marshaller_google_longrunning_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V11.Services.OfflineUserDataJobServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of OfflineUserDataJobService</summary>
    [grpc::BindServiceMethod(typeof(OfflineUserDataJobService), "BindService")]
    public abstract partial class OfflineUserDataJobServiceBase
    {
      /// <summary>
      /// Creates an offline user data job.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [NotAllowlistedError]()
      ///   [OfflineUserDataJobError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobResponse> CreateOfflineUserDataJob(global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Adds operations to the offline user data job.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [OfflineUserDataJobError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsResponse> AddOfflineUserDataJobOperations(global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Runs the offline user data job.
      ///
      /// When finished, the long running operation will contain the processing
      /// result or failure information, if any.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [OfflineUserDataJobError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> RunOfflineUserDataJob(global::Google.Ads.GoogleAds.V11.Services.RunOfflineUserDataJobRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for OfflineUserDataJobService</summary>
    public partial class OfflineUserDataJobServiceClient : grpc::ClientBase<OfflineUserDataJobServiceClient>
    {
      /// <summary>Creates a new client for OfflineUserDataJobService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public OfflineUserDataJobServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for OfflineUserDataJobService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public OfflineUserDataJobServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected OfflineUserDataJobServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected OfflineUserDataJobServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates an offline user data job.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [NotAllowlistedError]()
      ///   [OfflineUserDataJobError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobResponse CreateOfflineUserDataJob(global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateOfflineUserDataJob(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates an offline user data job.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [NotAllowlistedError]()
      ///   [OfflineUserDataJobError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobResponse CreateOfflineUserDataJob(global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateOfflineUserDataJob, null, options, request);
      }
      /// <summary>
      /// Creates an offline user data job.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [NotAllowlistedError]()
      ///   [OfflineUserDataJobError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobResponse> CreateOfflineUserDataJobAsync(global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateOfflineUserDataJobAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates an offline user data job.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [NotAllowlistedError]()
      ///   [OfflineUserDataJobError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobResponse> CreateOfflineUserDataJobAsync(global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateOfflineUserDataJob, null, options, request);
      }
      /// <summary>
      /// Adds operations to the offline user data job.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [OfflineUserDataJobError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsResponse AddOfflineUserDataJobOperations(global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddOfflineUserDataJobOperations(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Adds operations to the offline user data job.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [OfflineUserDataJobError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsResponse AddOfflineUserDataJobOperations(global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddOfflineUserDataJobOperations, null, options, request);
      }
      /// <summary>
      /// Adds operations to the offline user data job.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [OfflineUserDataJobError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsResponse> AddOfflineUserDataJobOperationsAsync(global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddOfflineUserDataJobOperationsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Adds operations to the offline user data job.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [FieldError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [MutateError]()
      ///   [OfflineUserDataJobError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsResponse> AddOfflineUserDataJobOperationsAsync(global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddOfflineUserDataJobOperations, null, options, request);
      }
      /// <summary>
      /// Runs the offline user data job.
      ///
      /// When finished, the long running operation will contain the processing
      /// result or failure information, if any.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [OfflineUserDataJobError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation RunOfflineUserDataJob(global::Google.Ads.GoogleAds.V11.Services.RunOfflineUserDataJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RunOfflineUserDataJob(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Runs the offline user data job.
      ///
      /// When finished, the long running operation will contain the processing
      /// result or failure information, if any.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [OfflineUserDataJobError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Google.LongRunning.Operation RunOfflineUserDataJob(global::Google.Ads.GoogleAds.V11.Services.RunOfflineUserDataJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RunOfflineUserDataJob, null, options, request);
      }
      /// <summary>
      /// Runs the offline user data job.
      ///
      /// When finished, the long running operation will contain the processing
      /// result or failure information, if any.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [OfflineUserDataJobError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> RunOfflineUserDataJobAsync(global::Google.Ads.GoogleAds.V11.Services.RunOfflineUserDataJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RunOfflineUserDataJobAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Runs the offline user data job.
      ///
      /// When finished, the long running operation will contain the processing
      /// result or failure information, if any.
      ///
      /// List of thrown errors:
      ///   [AuthenticationError]()
      ///   [AuthorizationError]()
      ///   [DatabaseError]()
      ///   [HeaderError]()
      ///   [InternalError]()
      ///   [OfflineUserDataJobError]()
      ///   [QuotaError]()
      ///   [RequestError]()
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> RunOfflineUserDataJobAsync(global::Google.Ads.GoogleAds.V11.Services.RunOfflineUserDataJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RunOfflineUserDataJob, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override OfflineUserDataJobServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OfflineUserDataJobServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(OfflineUserDataJobServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateOfflineUserDataJob, serviceImpl.CreateOfflineUserDataJob)
          .AddMethod(__Method_AddOfflineUserDataJobOperations, serviceImpl.AddOfflineUserDataJobOperations)
          .AddMethod(__Method_RunOfflineUserDataJob, serviceImpl.RunOfflineUserDataJob).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, OfflineUserDataJobServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateOfflineUserDataJob, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobRequest, global::Google.Ads.GoogleAds.V11.Services.CreateOfflineUserDataJobResponse>(serviceImpl.CreateOfflineUserDataJob));
      serviceBinder.AddMethod(__Method_AddOfflineUserDataJobOperations, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsRequest, global::Google.Ads.GoogleAds.V11.Services.AddOfflineUserDataJobOperationsResponse>(serviceImpl.AddOfflineUserDataJobOperations));
      serviceBinder.AddMethod(__Method_RunOfflineUserDataJob, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V11.Services.RunOfflineUserDataJobRequest, global::Google.LongRunning.Operation>(serviceImpl.RunOfflineUserDataJob));
    }

  }
}
#endregion

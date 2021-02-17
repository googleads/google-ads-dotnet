// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/services/batch_job_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
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
  /// Service to manage batch jobs.
  /// </summary>
  public static partial class BatchJobService
  {
    static readonly string __ServiceName = "google.ads.googleads.v5.services.BatchJobService";

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

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobRequest> __Marshaller_google_ads_googleads_v5_services_MutateBatchJobRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobResponse> __Marshaller_google_ads_googleads_v5_services_MutateBatchJobResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobResponse.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.GetBatchJobRequest> __Marshaller_google_ads_googleads_v5_services_GetBatchJobRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.GetBatchJobRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Resources.BatchJob> __Marshaller_google_ads_googleads_v5_resources_BatchJob = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Resources.BatchJob.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsRequest> __Marshaller_google_ads_googleads_v5_services_ListBatchJobResultsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsResponse> __Marshaller_google_ads_googleads_v5_services_ListBatchJobResultsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsResponse.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.RunBatchJobRequest> __Marshaller_google_ads_googleads_v5_services_RunBatchJobRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.RunBatchJobRequest.Parser));
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsRequest> __Marshaller_google_ads_googleads_v5_services_AddBatchJobOperationsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsResponse> __Marshaller_google_ads_googleads_v5_services_AddBatchJobOperationsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsResponse.Parser));

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobRequest, global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobResponse> __Method_MutateBatchJob = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobRequest, global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateBatchJob",
        __Marshaller_google_ads_googleads_v5_services_MutateBatchJobRequest,
        __Marshaller_google_ads_googleads_v5_services_MutateBatchJobResponse);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.GetBatchJobRequest, global::Google.Ads.GoogleAds.V5.Resources.BatchJob> __Method_GetBatchJob = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.GetBatchJobRequest, global::Google.Ads.GoogleAds.V5.Resources.BatchJob>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetBatchJob",
        __Marshaller_google_ads_googleads_v5_services_GetBatchJobRequest,
        __Marshaller_google_ads_googleads_v5_resources_BatchJob);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsRequest, global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsResponse> __Method_ListBatchJobResults = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsRequest, global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListBatchJobResults",
        __Marshaller_google_ads_googleads_v5_services_ListBatchJobResultsRequest,
        __Marshaller_google_ads_googleads_v5_services_ListBatchJobResultsResponse);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.RunBatchJobRequest, global::Google.LongRunning.Operation> __Method_RunBatchJob = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.RunBatchJobRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RunBatchJob",
        __Marshaller_google_ads_googleads_v5_services_RunBatchJobRequest,
        __Marshaller_google_longrunning_Operation);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsRequest, global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsResponse> __Method_AddBatchJobOperations = new grpc::Method<global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsRequest, global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddBatchJobOperations",
        __Marshaller_google_ads_googleads_v5_services_AddBatchJobOperationsRequest,
        __Marshaller_google_ads_googleads_v5_services_AddBatchJobOperationsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V5.Services.BatchJobServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of BatchJobService</summary>
    [grpc::BindServiceMethod(typeof(BatchJobService), "BindService")]
    public abstract partial class BatchJobServiceBase
    {
      /// <summary>
      /// Mutates a batch job.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobResponse> MutateBatchJob(global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns the batch job.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Resources.BatchJob> GetBatchJob(global::Google.Ads.GoogleAds.V5.Services.GetBatchJobRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns the results of the batch job. The job must be done.
      /// Supports standard list paging.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsResponse> ListBatchJobResults(global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Runs the batch job.
      ///
      /// The Operation.metadata field type is BatchJobMetadata. When finished, the
      /// long running operation will not contain errors or a response. Instead, use
      /// ListBatchJobResults to get the results of the job.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> RunBatchJob(global::Google.Ads.GoogleAds.V5.Services.RunBatchJobRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Add operations to the batch job.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsResponse> AddBatchJobOperations(global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for BatchJobService</summary>
    public partial class BatchJobServiceClient : grpc::ClientBase<BatchJobServiceClient>
    {
      /// <summary>Creates a new client for BatchJobService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public BatchJobServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for BatchJobService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public BatchJobServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected BatchJobServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected BatchJobServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Mutates a batch job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobResponse MutateBatchJob(global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateBatchJob(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Mutates a batch job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobResponse MutateBatchJob(global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateBatchJob, null, options, request);
      }
      /// <summary>
      /// Mutates a batch job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobResponse> MutateBatchJobAsync(global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateBatchJobAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Mutates a batch job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobResponse> MutateBatchJobAsync(global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateBatchJob, null, options, request);
      }
      /// <summary>
      /// Returns the batch job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Resources.BatchJob GetBatchJob(global::Google.Ads.GoogleAds.V5.Services.GetBatchJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBatchJob(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the batch job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Resources.BatchJob GetBatchJob(global::Google.Ads.GoogleAds.V5.Services.GetBatchJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetBatchJob, null, options, request);
      }
      /// <summary>
      /// Returns the batch job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Resources.BatchJob> GetBatchJobAsync(global::Google.Ads.GoogleAds.V5.Services.GetBatchJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetBatchJobAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the batch job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Resources.BatchJob> GetBatchJobAsync(global::Google.Ads.GoogleAds.V5.Services.GetBatchJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetBatchJob, null, options, request);
      }
      /// <summary>
      /// Returns the results of the batch job. The job must be done.
      /// Supports standard list paging.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsResponse ListBatchJobResults(global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListBatchJobResults(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the results of the batch job. The job must be done.
      /// Supports standard list paging.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsResponse ListBatchJobResults(global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListBatchJobResults, null, options, request);
      }
      /// <summary>
      /// Returns the results of the batch job. The job must be done.
      /// Supports standard list paging.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsResponse> ListBatchJobResultsAsync(global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListBatchJobResultsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the results of the batch job. The job must be done.
      /// Supports standard list paging.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsResponse> ListBatchJobResultsAsync(global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListBatchJobResults, null, options, request);
      }
      /// <summary>
      /// Runs the batch job.
      ///
      /// The Operation.metadata field type is BatchJobMetadata. When finished, the
      /// long running operation will not contain errors or a response. Instead, use
      /// ListBatchJobResults to get the results of the job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation RunBatchJob(global::Google.Ads.GoogleAds.V5.Services.RunBatchJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RunBatchJob(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Runs the batch job.
      ///
      /// The Operation.metadata field type is BatchJobMetadata. When finished, the
      /// long running operation will not contain errors or a response. Instead, use
      /// ListBatchJobResults to get the results of the job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation RunBatchJob(global::Google.Ads.GoogleAds.V5.Services.RunBatchJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RunBatchJob, null, options, request);
      }
      /// <summary>
      /// Runs the batch job.
      ///
      /// The Operation.metadata field type is BatchJobMetadata. When finished, the
      /// long running operation will not contain errors or a response. Instead, use
      /// ListBatchJobResults to get the results of the job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> RunBatchJobAsync(global::Google.Ads.GoogleAds.V5.Services.RunBatchJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RunBatchJobAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Runs the batch job.
      ///
      /// The Operation.metadata field type is BatchJobMetadata. When finished, the
      /// long running operation will not contain errors or a response. Instead, use
      /// ListBatchJobResults to get the results of the job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> RunBatchJobAsync(global::Google.Ads.GoogleAds.V5.Services.RunBatchJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RunBatchJob, null, options, request);
      }
      /// <summary>
      /// Add operations to the batch job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsResponse AddBatchJobOperations(global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddBatchJobOperations(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Add operations to the batch job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsResponse AddBatchJobOperations(global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddBatchJobOperations, null, options, request);
      }
      /// <summary>
      /// Add operations to the batch job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsResponse> AddBatchJobOperationsAsync(global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddBatchJobOperationsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Add operations to the batch job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsResponse> AddBatchJobOperationsAsync(global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddBatchJobOperations, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override BatchJobServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BatchJobServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(BatchJobServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_MutateBatchJob, serviceImpl.MutateBatchJob)
          .AddMethod(__Method_GetBatchJob, serviceImpl.GetBatchJob)
          .AddMethod(__Method_ListBatchJobResults, serviceImpl.ListBatchJobResults)
          .AddMethod(__Method_RunBatchJob, serviceImpl.RunBatchJob)
          .AddMethod(__Method_AddBatchJobOperations, serviceImpl.AddBatchJobOperations).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BatchJobServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_MutateBatchJob, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobRequest, global::Google.Ads.GoogleAds.V5.Services.MutateBatchJobResponse>(serviceImpl.MutateBatchJob));
      serviceBinder.AddMethod(__Method_GetBatchJob, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.GetBatchJobRequest, global::Google.Ads.GoogleAds.V5.Resources.BatchJob>(serviceImpl.GetBatchJob));
      serviceBinder.AddMethod(__Method_ListBatchJobResults, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsRequest, global::Google.Ads.GoogleAds.V5.Services.ListBatchJobResultsResponse>(serviceImpl.ListBatchJobResults));
      serviceBinder.AddMethod(__Method_RunBatchJob, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.RunBatchJobRequest, global::Google.LongRunning.Operation>(serviceImpl.RunBatchJob));
      serviceBinder.AddMethod(__Method_AddBatchJobOperations, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsRequest, global::Google.Ads.GoogleAds.V5.Services.AddBatchJobOperationsResponse>(serviceImpl.AddBatchJobOperations));
    }

  }
}
#endregion
